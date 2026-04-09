#nullable enable
using System.Runtime.InteropServices;
using Valve.VR;
using VRRealityWindow.Core;
using VRRealityWindow.Core.Utilities;

namespace VRRealityWindow.OpenVr;

public sealed class OpenVrOverlayPresenter : IDisposable
{
    private readonly OpenVrRuntime _runtime;
    private readonly OverlaySettings _settings;
    private ulong _overlayHandle;
    private bool _visible;
    private AnchorMode _currentAnchorMode;
    private OverlayImageUploadMode _uploadMode = OverlayImageUploadMode.Raw;
    private string? _fileBackedOverlayPath;
    private DateTime _lastFileUploadUtc = DateTime.MinValue;
    private bool _fileBackedFrameUploaded;
    private HmdMatrix34_t _currentAbsoluteTransform;
    private HmdMatrix34_t _currentHandRelativeTransform;
    private bool _hasCurrentAbsoluteTransform;

    public OpenVrOverlayPresenter(OpenVrRuntime runtime, OverlaySettings settings)
    {
        _runtime = runtime;
        _settings = settings;
    }

    public bool IsVisible => _visible;
    public float WidthInMeters => _settings.WidthInMeters;
    public float Opacity => _settings.Opacity;
    public float TiltDegrees => _settings.TiltDegrees;
    public AnchorMode CurrentAnchorMode => _currentAnchorMode;

    public void Initialize()
    {
        _runtime.EnsureInitialized();

        var existing = 0UL;
        var findError = _runtime.Overlay.FindOverlay(_settings.OverlayKey, ref existing);
        if (findError == EVROverlayError.None && existing != 0)
        {
            _runtime.Overlay.DestroyOverlay(existing);
        }

        var createError = _runtime.Overlay.CreateOverlay(_settings.OverlayKey, _settings.OverlayName, ref _overlayHandle);
        ThrowIfOverlayError(createError, "CreateOverlay");

        ThrowIfOverlayError(_runtime.Overlay.SetOverlayWidthInMeters(_overlayHandle, _settings.WidthInMeters), "SetOverlayWidthInMeters");
        ThrowIfOverlayError(_runtime.Overlay.SetOverlayAlpha(_overlayHandle, _settings.Opacity), "SetOverlayAlpha");
        ThrowIfOverlayError(_runtime.Overlay.SetOverlaySortOrder(_overlayHandle, _settings.SortOrder), "SetOverlaySortOrder");
        SetAnchorMode(_settings.AnchorMode);
    }

    public void SetAnchorMode(AnchorMode anchorMode)
    {
        EnsureOverlayCreated();
        _settings.AnchorMode = anchorMode;
        _currentAnchorMode = anchorMode;

        switch (anchorMode)
        {
            case AnchorMode.WorldLocked:
                ApplyWorldLockedTransform();
                break;

            case AnchorMode.LeftHandLocked:
                ApplyHandLockedTransform(ETrackedControllerRole.LeftHand, true);
                break;

            case AnchorMode.RightHandLocked:
                ApplyHandLockedTransform(ETrackedControllerRole.RightHand, false);
                break;

            default:
                throw new InvalidOperationException($"Unsupported anchor mode: {anchorMode}");
        }
    }

    public void UpdateFrame(CameraFrame frame)
    {
        EnsureOverlayCreated();

        if (_uploadMode == OverlayImageUploadMode.File)
        {
            UpdateFrameFromFile(frame);
            return;
        }

        if (frame.BytesPerPixel != 4)
        {
            throw new InvalidOperationException("OpenVR raw overlay update expects BGRA32 frames.");
        }

        using var pin = new PinnedBuffer(frame.PixelData);
        var rawError = _runtime.Overlay.SetOverlayRaw(_overlayHandle, pin.Pointer, (uint)frame.Width, (uint)frame.Height, (uint)frame.BytesPerPixel);
        if (rawError == EVROverlayError.None)
        {
            return;
        }

        if (rawError == EVROverlayError.RequestFailed)
        {
            SwitchToFileBackedMode(frame);
            return;
        }

        ThrowIfOverlayError(rawError, "SetOverlayRaw");
    }

    public void SetOpacity(float opacity)
    {
        EnsureOverlayCreated();
        _settings.Opacity = Math.Clamp(opacity, 0.05f, 1.0f);
        ThrowIfOverlayError(_runtime.Overlay.SetOverlayAlpha(_overlayHandle, _settings.Opacity), "SetOverlayAlpha");
    }

    public void SetWidth(float widthInMeters)
    {
        EnsureOverlayCreated();
        _settings.WidthInMeters = Math.Clamp(widthInMeters, 0.10f, 2.00f);
        ThrowIfOverlayError(_runtime.Overlay.SetOverlayWidthInMeters(_overlayHandle, _settings.WidthInMeters), "SetOverlayWidthInMeters");
    }

    public void SetTilt(float tiltDegrees)
    {
        _settings.TiltDegrees = Math.Clamp(tiltDegrees, -80f, 80f);
        SetAnchorMode(_currentAnchorMode);
    }

    public void FreezeHandLockedToWorld(in HmdMatrix34_t controllerPose, bool leftHand)
    {
        var absoluteTransform = OpenVrPoseMath.Multiply(controllerPose, _currentHandRelativeTransform);
        ThrowIfOverlayError(
            _runtime.Overlay.SetOverlayTransformAbsolute(
                _overlayHandle,
                ETrackingUniverseOrigin.TrackingUniverseStanding,
                ref absoluteTransform),
            "SetOverlayTransformAbsolute");

        _settings.AnchorMode = AnchorMode.WorldLocked;
        _currentAnchorMode = AnchorMode.WorldLocked;
        _currentAbsoluteTransform = absoluteTransform;
        _hasCurrentAbsoluteTransform = true;
    }

    public void AttachToHandPreservingWorldPose(in HmdMatrix34_t controllerPose, ETrackedControllerRole role, bool leftHand)
    {
        EnsureOverlayCreated();

        var absoluteTransform = _hasCurrentAbsoluteTransform
            ? _currentAbsoluteTransform
            : OpenVrPoseMath.Multiply(
                controllerPose,
                OpenVrPoseMath.CreateHandLockedTransform(
                    leftHand,
                    _settings.HandDistanceMeters,
                    _settings.HandVerticalOffsetMeters,
                    _settings.HandLateralOffsetMeters,
                    _settings.TiltDegrees));

        var inverseController = OpenVrPoseMath.InvertRigid(controllerPose);
        var relativeTransform = OpenVrPoseMath.Multiply(inverseController, absoluteTransform);

        ThrowIfOverlayError(
            _runtime.Overlay.SetOverlayTransformTrackedDeviceRelative(_overlayHandle, _runtime.GetControllerIndex(role), ref relativeTransform),
            "SetOverlayTransformTrackedDeviceRelative");

        _currentHandRelativeTransform = relativeTransform;
        _currentAnchorMode = leftHand ? AnchorMode.LeftHandLocked : AnchorMode.RightHandLocked;
        _settings.AnchorMode = _currentAnchorMode;
    }

    public void Show()
    {
        EnsureOverlayCreated();
        ThrowIfOverlayError(_runtime.Overlay.ShowOverlay(_overlayHandle), "ShowOverlay");
        _visible = true;
    }

    public void Hide()
    {
        EnsureOverlayCreated();
        ThrowIfOverlayError(_runtime.Overlay.HideOverlay(_overlayHandle), "HideOverlay");
        _visible = false;
    }

    public void ToggleVisibility()
    {
        if (_visible)
        {
            Hide();
        }
        else
        {
            Show();
        }
    }

    public void Dispose()
    {
        if (_overlayHandle != 0)
        {
            _runtime.Overlay.DestroyOverlay(_overlayHandle);
            _overlayHandle = 0;
            _visible = false;
        }

        if (!string.IsNullOrWhiteSpace(_fileBackedOverlayPath) && File.Exists(_fileBackedOverlayPath))
        {
            try
            {
                File.Delete(_fileBackedOverlayPath);
            }
            catch
            {
            }
        }
    }

    private void ApplyWorldLockedTransform()
    {
        var transform = _runtime.TryGetHmdPose(out var hmdPose)
            ? OpenVrPoseMath.CreateWorldLockedTransform(
                hmdPose,
                _settings.SpawnDistanceMeters,
                _settings.SpawnVerticalOffsetMeters,
                _settings.TiltDegrees)
            : OpenVrPoseMath.CreateFallbackWorldTransform(
                _settings.SpawnDistanceMeters,
                _settings.SpawnVerticalOffsetMeters,
                _settings.TiltDegrees);

        ThrowIfOverlayError(
            _runtime.Overlay.SetOverlayTransformAbsolute(
                _overlayHandle,
                ETrackingUniverseOrigin.TrackingUniverseStanding,
                ref transform),
            "SetOverlayTransformAbsolute");

        _currentAbsoluteTransform = transform;
        _hasCurrentAbsoluteTransform = true;
    }

    private void ApplyHandLockedTransform(ETrackedControllerRole role, bool leftHand)
    {
        var controllerIndex = _runtime.GetControllerIndex(role);
        if (controllerIndex == Valve.VR.OpenVR.k_unTrackedDeviceIndexInvalid)
        {
            throw new InvalidOperationException($"Controller for role {role} is not available. Turn on the controller and confirm SteamVR has assigned the hand role.");
        }

        var localTransform = OpenVrPoseMath.CreateHandLockedTransform(
            leftHand,
            _settings.HandDistanceMeters,
            _settings.HandVerticalOffsetMeters,
            _settings.HandLateralOffsetMeters,
            _settings.TiltDegrees);

        ThrowIfOverlayError(
            _runtime.Overlay.SetOverlayTransformTrackedDeviceRelative(_overlayHandle, controllerIndex, ref localTransform),
            "SetOverlayTransformTrackedDeviceRelative");

        _currentHandRelativeTransform = localTransform;
    }

    private void EnsureOverlayCreated()
    {
        if (_overlayHandle == 0)
        {
            throw new InvalidOperationException("Overlay has not been initialized.");
        }
    }

    private void SwitchToFileBackedMode(CameraFrame frame)
    {
        if (frame.Width > 1920 || frame.Height > 1080)
        {
            throw new InvalidOperationException("SetOverlayRaw failed and file-backed fallback requires the frame to fit within 1920x1080.");
        }

        Console.WriteLine("[overlay] SetOverlayRaw returned RequestFailed. Switching to SetOverlayFromFile fallback.");
        _uploadMode = OverlayImageUploadMode.File;
        UpdateFrameFromFile(frame, forceWrite: true);
    }

    private void UpdateFrameFromFile(CameraFrame frame, bool forceWrite = false)
    {
        if (frame.BytesPerPixel != 4)
        {
            throw new InvalidOperationException("File-backed overlay update expects BGRA32 frames.");
        }

        if (_fileBackedOverlayPath is null)
        {
            var directory = Path.Combine(Path.GetTempPath(), "VRRealityWindowMvp");
            Directory.CreateDirectory(directory);
            _fileBackedOverlayPath = Path.Combine(directory, $"overlay-{Environment.ProcessId}.png");
        }

        if (_fileBackedFrameUploaded && !forceWrite)
        {
            return;
        }

        var nowUtc = DateTime.UtcNow;
        if (!forceWrite && (nowUtc - _lastFileUploadUtc).TotalMilliseconds < 250)
        {
            return;
        }

        PngWriter.WriteBgra32(_fileBackedOverlayPath, frame);
        ThrowIfOverlayError(_runtime.Overlay.SetOverlayFromFile(_overlayHandle, _fileBackedOverlayPath), "SetOverlayFromFile");
        _lastFileUploadUtc = nowUtc;
        _fileBackedFrameUploaded = true;
    }

    private static void ThrowIfOverlayError(EVROverlayError error, string operation)
    {
        if (error != EVROverlayError.None)
        {
            throw new InvalidOperationException($"{operation} failed: {error}");
        }
    }

    private enum OverlayImageUploadMode
    {
        Raw,
        File,
    }

    private sealed class PinnedBuffer : IDisposable
    {
        private readonly GCHandle _handle;

        public PinnedBuffer(byte[] buffer)
        {
            _handle = GCHandle.Alloc(buffer, GCHandleType.Pinned);
            Pointer = _handle.AddrOfPinnedObject();
        }

        public IntPtr Pointer { get; }

        public void Dispose()
        {
            if (_handle.IsAllocated)
            {
                _handle.Free();
            }
        }
    }
}
