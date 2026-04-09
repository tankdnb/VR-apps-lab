using System.Diagnostics;
using VRRealityWindow.Core.Abstractions;

namespace VRRealityWindow.Core.Providers;

public sealed class TestPatternCameraProvider : ICameraProvider
{
    private readonly Stopwatch _clock = Stopwatch.StartNew();
    private readonly ProviderDiagnostics _diagnostics = new()
    {
        ProviderName = "TestPatternCameraProvider",
        HasCamera = true,
    };

    private byte[]? _buffer;
    private CameraProviderConfig? _config;
    private ulong _sequence;

    public string SourceName => "test-pattern";

    public CameraProviderStatus Status { get; private set; } = CameraProviderStatus.Uninitialized;

    public ProviderDiagnostics Diagnostics => _diagnostics;

    public void Initialize(CameraProviderConfig config)
    {
        _config = config;
        _buffer = new byte[config.TestPatternWidth * config.TestPatternHeight * 4];
        _diagnostics.DeviceIndex = config.DeviceIndex;
        _diagnostics.Width = config.TestPatternWidth;
        _diagnostics.Height = config.TestPatternHeight;
        _diagnostics.BytesPerPixel = 4;
        _diagnostics.LastError = string.Empty;
        Status = CameraProviderStatus.Ready;
    }

    public bool IsAvailable() => true;

    public void Start()
    {
        EnsureInitialized();
        Status = CameraProviderStatus.Streaming;
    }

    public CameraFrame? GetFrame()
    {
        EnsureStreaming();

        if (_buffer is null || _config is null)
        {
            return null;
        }

        RenderPattern(_buffer, _config.TestPatternWidth, _config.TestPatternHeight, _clock.Elapsed.TotalSeconds);

        _sequence++;
        _diagnostics.LastFrameSequence = _sequence;
        _diagnostics.FramesReceived++;

        return new CameraFrame(
            _buffer,
            _config.TestPatternWidth,
            _config.TestPatternHeight,
            4,
            _sequence,
            (ulong)_clock.ElapsedMilliseconds,
            SourceName);
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
        _buffer = null;
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
            throw new InvalidOperationException("Camera provider is not initialized.");
        }
    }

    private void EnsureStreaming()
    {
        if (Status != CameraProviderStatus.Streaming)
        {
            throw new InvalidOperationException("Camera provider is not streaming.");
        }
    }

    private static void RenderPattern(byte[] buffer, int width, int height, double timeSeconds)
    {
        var phase = (float)(timeSeconds * 0.75);
        var centerX = width * 0.5f;
        var centerY = height * 0.5f;

        for (var y = 0; y < height; y++)
        {
            for (var x = 0; x < width; x++)
            {
                var index = ((y * width) + x) * 4;
                var fx = x / (float)Math.Max(width - 1, 1);
                var fy = y / (float)Math.Max(height - 1, 1);
                var grid = ((x / 32) + (y / 32)) % 2 == 0 ? 0.12f : 0.0f;
                var ring = MathF.Sin(MathF.Sqrt((x - centerX) * (x - centerX) + (y - centerY) * (y - centerY)) * 0.045f - phase * 5f);

                var b = ClampByte((0.15f + fx * 0.65f + grid) * 255f);
                var g = ClampByte((0.20f + fy * 0.65f + grid) * 255f);
                var r = ClampByte((0.35f + (ring * 0.25f) + grid) * 255f);

                buffer[index + 0] = b;
                buffer[index + 1] = g;
                buffer[index + 2] = r;
                buffer[index + 3] = 255;
            }
        }

        DrawCrosshair(buffer, width, height);
    }

    private static void DrawCrosshair(byte[] buffer, int width, int height)
    {
        var cx = width / 2;
        var cy = height / 2;

        for (var x = Math.Max(0, cx - 40); x < Math.Min(width, cx + 40); x++)
        {
            SetPixel(buffer, width, x, cy, 255, 255, 255);
        }

        for (var y = Math.Max(0, cy - 40); y < Math.Min(height, cy + 40); y++)
        {
            SetPixel(buffer, width, cx, y, 255, 255, 255);
        }
    }

    private static void SetPixel(byte[] buffer, int width, int x, int y, byte b, byte g, byte r)
    {
        var index = ((y * width) + x) * 4;
        buffer[index + 0] = b;
        buffer[index + 1] = g;
        buffer[index + 2] = r;
        buffer[index + 3] = 255;
    }

    private static byte ClampByte(float value)
    {
        if (value < 0f)
        {
            return 0;
        }

        if (value > 255f)
        {
            return 255;
        }

        return (byte)value;
    }
}
