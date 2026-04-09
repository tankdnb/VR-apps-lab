using System.Runtime.InteropServices;
using VRRealityWindow.Core.Abstractions;

namespace VRRealityWindow.Core.Providers;

public sealed class PicoOfficialCameraProvider : ICameraProvider
{
    private readonly ProviderDiagnostics _diagnostics = new()
    {
        ProviderName = "PicoOfficialCameraProvider",
    };

    private CameraProviderConfig? _config;

    public string SourceName => "pico-official";

    public CameraProviderStatus Status { get; private set; } = CameraProviderStatus.Uninitialized;

    public ProviderDiagnostics Diagnostics => _diagnostics;

    public void Initialize(CameraProviderConfig config)
    {
        _config = config;
        _diagnostics.DeviceIndex = config.DeviceIndex;
        _diagnostics.LastError = string.Empty;
        Status = CameraProviderStatus.Ready;
    }

    public bool IsAvailable()
    {
        EnsureInitialized();

        Status = CameraProviderStatus.Unsupported;
        _diagnostics.HasCamera = false;
        _diagnostics.LastError = RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
            ? "PICO official raw camera access is not implemented in this Windows desktop MVP. The next probe should run on-device with the PICO OpenXR runtime and verify whether XR_PICO_camera_image plus XR_EXT_future are advertised. If only XR_PICO_secure_mixed_reality is available, the app will not receive raw camera or sensor data back."
            : "PICO official raw camera access is not implemented in this MVP build yet. The next spike should use the official PICO/OpenXR stack on-device and verify XR_PICO_camera_image availability before attempting camera capture.";
        return false;
    }

    public void Start()
    {
        throw new InvalidOperationException("PICO official camera provider is not implemented in this MVP build yet.");
    }

    public CameraFrame? GetFrame()
    {
        return null;
    }

    public void Stop()
    {
        if (Status == CameraProviderStatus.Streaming)
        {
            Status = CameraProviderStatus.Ready;
        }
    }

    public void Shutdown()
    {
        Stop();
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
            throw new InvalidOperationException("PICO official camera provider is not initialized.");
        }
    }
}
