using System.Text.Json;
using System.Text.Json.Serialization;

namespace VRRealityWindow.Core;

public sealed class MvpSettings
{
    public CameraSettings Camera { get; set; } = new();
    public OverlaySettings Overlay { get; set; } = new();
    public ProcessingSettings Processing { get; set; } = new();
    public RuntimeSettings Runtime { get; set; } = new();

    public static JsonSerializerOptions CreateJsonOptions()
    {
        var options = new JsonSerializerOptions
        {
            WriteIndented = true,
            PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower,
        };

        options.Converters.Add(new JsonStringEnumConverter(JsonNamingPolicy.SnakeCaseLower));
        return options;
    }

    public static MvpSettings CreateDefault() => new();
}

public sealed class CameraSettings
{
    public CameraSourceKind PreferredSource { get; set; } = CameraSourceKind.Auto;
    public RuntimePathKind PreferredRuntimePath { get; set; } = RuntimePathKind.Auto;
    public TargetHeadsetKind TargetHeadset { get; set; } = TargetHeadsetKind.Pico4Pro;
    public bool FallbackToTestPattern { get; set; } = true;
    public CameraFrameType FrameType { get; set; } = CameraFrameType.Undistorted;
    public uint DeviceIndex { get; set; } = 0;
    public int TestPatternWidth { get; set; } = 960;
    public int TestPatternHeight { get; set; } = 540;
}

public sealed class OverlaySettings
{
    public string OverlayKey { get; set; } = "com.vrapp.realitywindow.mvp";
    public string OverlayName { get; set; } = "Reality Window MVP";
    public AnchorMode AnchorMode { get; set; } = AnchorMode.WorldLocked;
    public float WidthInMeters { get; set; } = 0.35f;
    public float Opacity { get; set; } = 0.92f;
    public float SpawnDistanceMeters { get; set; } = 0.55f;
    public float SpawnVerticalOffsetMeters { get; set; } = -0.12f;
    public float TiltDegrees { get; set; } = 18f;
    public float HandDistanceMeters { get; set; } = 0.24f;
    public float HandVerticalOffsetMeters { get; set; } = -0.06f;
    public float HandLateralOffsetMeters { get; set; } = 0.08f;
    public uint SortOrder { get; set; } = 10;
}

public sealed class RuntimeSettings
{
    public int UpdateRateHz { get; set; } = 30;
    public int ProbeAttempts { get; set; } = 50;
    public int ProbeRetryDelayMs { get; set; } = 100;
    public int OverlayDurationSeconds { get; set; } = 0;
}

public sealed class ProcessingSettings
{
    public bool EnableBottomFocusCrop { get; set; } = false;
    public float BottomFocusHeightRatio { get; set; } = 0.55f;
}
