namespace VRRealityWindow.Core.Abstractions;

public interface ICameraProvider : IDisposable
{
    string SourceName { get; }
    CameraProviderStatus Status { get; }
    ProviderDiagnostics Diagnostics { get; }

    void Initialize(CameraProviderConfig config);
    bool IsAvailable();
    void Start();
    CameraFrame? GetFrame();
    void Stop();
    void Shutdown();
}
