namespace VRRealityWindow.Core;

public enum CameraSourceKind
{
    Auto,
    PicoOfficial,
    OpenVrTrackedCamera,
    TestPattern,
}

public enum CameraProviderStatus
{
    Uninitialized,
    Ready,
    Streaming,
    Unavailable,
    Unsupported,
    Error,
}

public enum RuntimePathKind
{
    Auto,
    SteamVrOpenVr,
    PicoOfficial,
}

public enum TargetHeadsetKind
{
    Generic,
    Pico4Pro,
}

public enum CameraFrameType
{
    Distorted,
    Undistorted,
    MaximumUndistorted,
}

public enum AnchorMode
{
    WorldLocked,
    LeftHandLocked,
    RightHandLocked,
}

public sealed class CameraProviderConfig
{
    public CameraSourceKind Source { get; set; } = CameraSourceKind.Auto;
    public CameraFrameType FrameType { get; set; } = CameraFrameType.Undistorted;
    public uint DeviceIndex { get; set; } = 0;
    public int TestPatternWidth { get; set; } = 960;
    public int TestPatternHeight { get; set; } = 540;
    public RuntimePathKind PreferredRuntimePath { get; set; } = RuntimePathKind.Auto;
    public TargetHeadsetKind TargetHeadset { get; set; } = TargetHeadsetKind.Pico4Pro;
}

public sealed class ProviderDiagnostics
{
    public string ProviderName { get; init; } = string.Empty;
    public uint DeviceIndex { get; set; }
    public bool HasCamera { get; set; }
    public int Width { get; set; }
    public int Height { get; set; }
    public int BytesPerPixel { get; set; }
    public ulong LastFrameSequence { get; set; }
    public long FramesReceived { get; set; }
    public long EmptyPolls { get; set; }
    public string LastError { get; set; } = string.Empty;
}

public sealed class CameraFrame
{
    public CameraFrame(
        byte[] pixelData,
        int width,
        int height,
        int bytesPerPixel,
        ulong sequence,
        ulong exposureTimestamp,
        string sourceName)
    {
        PixelData = pixelData;
        Width = width;
        Height = height;
        BytesPerPixel = bytesPerPixel;
        Sequence = sequence;
        ExposureTimestamp = exposureTimestamp;
        SourceName = sourceName;
    }

    public byte[] PixelData { get; }
    public int Width { get; }
    public int Height { get; }
    public int BytesPerPixel { get; }
    public ulong Sequence { get; }
    public ulong ExposureTimestamp { get; }
    public string SourceName { get; }
}
