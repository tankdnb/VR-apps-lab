#nullable enable
using System.Runtime.InteropServices;
using Valve.VR;
using VRRealityWindow.Core;
using VRRealityWindow.Core.Abstractions;

namespace VRRealityWindow.OpenVr;

public sealed class OpenVrTrackedCameraProvider : ICameraProvider
{
    private readonly OpenVrRuntime _runtime;
    private readonly ProviderDiagnostics _diagnostics = new()
    {
        ProviderName = "OpenVRTrackedCameraProvider",
    };

    private CameraProviderConfig? _config;
    private ulong _streamHandle;
    private byte[]? _rawBuffer;
    private byte[]? _bgraBuffer;
    private CameraVideoStreamFrameHeader_t _header;

    public OpenVrTrackedCameraProvider(OpenVrRuntime runtime)
    {
        _runtime = runtime;
    }

    public string SourceName => "openvr-tracked-camera";

    public CameraProviderStatus Status { get; private set; } = CameraProviderStatus.Uninitialized;

    public ProviderDiagnostics Diagnostics => _diagnostics;

    public void Initialize(CameraProviderConfig config)
    {
        _runtime.EnsureInitialized();
        _config = config;
        _diagnostics.DeviceIndex = config.DeviceIndex;
        _diagnostics.LastError = string.Empty;
        Status = CameraProviderStatus.Ready;
    }

    public bool IsAvailable()
    {
        EnsureInitialized();

        var hasCamera = false;
        var error = _runtime.TrackedCamera.HasCamera(_config!.DeviceIndex, ref hasCamera);
        _diagnostics.HasCamera = hasCamera;

        if (error != EVRTrackedCameraError.None)
        {
            _diagnostics.LastError = DescribeError(error);
            Status = CameraProviderStatus.Error;
            return false;
        }

        if (!hasCamera)
        {
            _diagnostics.LastError = "Tracked camera is not exposed by this HMD.";
            Status = CameraProviderStatus.Unavailable;
        }

        return hasCamera;
    }

    public void Start()
    {
        EnsureInitialized();

        if (!IsAvailable())
        {
            throw new InvalidOperationException(_diagnostics.LastError);
        }

        var frameType = ToOpenVrFrameType(_config!.FrameType);
        uint width = 0;
        uint height = 0;
        uint frameBufferSize = 0;

        var frameSizeError = _runtime.TrackedCamera.GetCameraFrameSize(
            _config.DeviceIndex,
            frameType,
            ref width,
            ref height,
            ref frameBufferSize);

        if (frameSizeError != EVRTrackedCameraError.None)
        {
            Status = CameraProviderStatus.Error;
            _diagnostics.LastError = DescribeError(frameSizeError);
            throw new InvalidOperationException(_diagnostics.LastError);
        }

        var acquireError = _runtime.TrackedCamera.AcquireVideoStreamingService(_config.DeviceIndex, ref _streamHandle);
        if (acquireError != EVRTrackedCameraError.None)
        {
            Status = CameraProviderStatus.Error;
            _diagnostics.LastError = DescribeError(acquireError);
            throw new InvalidOperationException(_diagnostics.LastError);
        }

        _rawBuffer = new byte[frameBufferSize];
        _bgraBuffer = new byte[width * height * 4];
        _diagnostics.Width = (int)width;
        _diagnostics.Height = (int)height;
        _diagnostics.BytesPerPixel = 4;
        _diagnostics.LastError = string.Empty;
        Status = CameraProviderStatus.Streaming;
    }

    public CameraFrame? GetFrame()
    {
        EnsureStreaming();

        if (_rawBuffer is null || _config is null)
        {
            return null;
        }

        var frameType = ToOpenVrFrameType(_config.FrameType);
        using var pin = new PinnedBuffer(_rawBuffer);
        _header = default;

        var error = _runtime.TrackedCamera.GetVideoStreamFrameBuffer(
            _streamHandle,
            frameType,
            pin.Pointer,
            (uint)_rawBuffer.Length,
            ref _header,
            (uint)Marshal.SizeOf<CameraVideoStreamFrameHeader_t>());

        if (error == EVRTrackedCameraError.NoFrameAvailable)
        {
            _diagnostics.EmptyPolls++;
            return null;
        }

        if (error != EVRTrackedCameraError.None)
        {
            Status = CameraProviderStatus.Error;
            _diagnostics.LastError = DescribeError(error);
            throw new InvalidOperationException(_diagnostics.LastError);
        }

        var normalizedFrame = NormalizeFrame(_rawBuffer, _header);
        _diagnostics.Width = (int)_header.nWidth;
        _diagnostics.Height = (int)_header.nHeight;
        _diagnostics.BytesPerPixel = normalizedFrame.BytesPerPixel;
        _diagnostics.LastFrameSequence = _header.nFrameSequence;
        _diagnostics.FramesReceived++;
        _diagnostics.LastError = string.Empty;

        return normalizedFrame;
    }

    public void Stop()
    {
        if (_streamHandle != 0)
        {
            _runtime.TrackedCamera.ReleaseVideoStreamingService(_streamHandle);
            _streamHandle = 0;
        }

        if (Status == CameraProviderStatus.Streaming)
        {
            Status = CameraProviderStatus.Ready;
        }
    }

    public void Shutdown()
    {
        Stop();
        _rawBuffer = null;
        _bgraBuffer = null;
        _config = null;
        Status = CameraProviderStatus.Uninitialized;
    }

    public void Dispose()
    {
        Shutdown();
    }

    private void EnsureInitialized()
    {
        if (Status == CameraProviderStatus.Uninitialized || _config is null)
        {
            throw new InvalidOperationException("OpenVR camera provider is not initialized.");
        }
    }

    private void EnsureStreaming()
    {
        if (Status != CameraProviderStatus.Streaming)
        {
            throw new InvalidOperationException("OpenVR camera provider is not streaming.");
        }
    }

    private CameraFrame NormalizeFrame(byte[] rawBuffer, CameraVideoStreamFrameHeader_t header)
    {
        if (_bgraBuffer is null)
        {
            throw new InvalidOperationException("Normalized buffer is not allocated.");
        }

        var width = checked((int)header.nWidth);
        var height = checked((int)header.nHeight);
        var sequence = (ulong)header.nFrameSequence;
        var sourceBytesPerPixel = checked((int)header.nBytesPerPixel);

        if (sourceBytesPerPixel == 4)
        {
            return new CameraFrame(rawBuffer, width, height, 4, sequence, header.ulFrameExposureTime, SourceName);
        }

        if (sourceBytesPerPixel == 3)
        {
            var pixelCount = width * height;
            for (var i = 0; i < pixelCount; i++)
            {
                var src = i * 3;
                var dst = i * 4;
                _bgraBuffer[dst + 0] = rawBuffer[src + 0];
                _bgraBuffer[dst + 1] = rawBuffer[src + 1];
                _bgraBuffer[dst + 2] = rawBuffer[src + 2];
                _bgraBuffer[dst + 3] = 255;
            }

            return new CameraFrame(_bgraBuffer, width, height, 4, sequence, header.ulFrameExposureTime, SourceName);
        }

        Status = CameraProviderStatus.Error;
        _diagnostics.LastError = $"Unsupported source pixel format: {sourceBytesPerPixel} bytes per pixel.";
        throw new InvalidOperationException(_diagnostics.LastError);
    }

    private string DescribeError(EVRTrackedCameraError error)
    {
        var name = _runtime.TrackedCamera.GetCameraErrorNameFromEnum(error);
        return string.IsNullOrWhiteSpace(name) ? error.ToString() : name;
    }

    private static EVRTrackedCameraFrameType ToOpenVrFrameType(CameraFrameType frameType) =>
        frameType switch
        {
            CameraFrameType.Distorted => EVRTrackedCameraFrameType.Distorted,
            CameraFrameType.Undistorted => EVRTrackedCameraFrameType.Undistorted,
            CameraFrameType.MaximumUndistorted => EVRTrackedCameraFrameType.MaximumUndistorted,
            _ => EVRTrackedCameraFrameType.Undistorted,
        };

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
