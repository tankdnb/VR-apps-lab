using VRRealityWindow.Core.Abstractions;

namespace VRRealityWindow.Core.Processing;

public sealed class BottomFocusCropProcessor : IFrameProcessor
{
    private readonly float _heightRatio;
    private byte[]? _buffer;

    public BottomFocusCropProcessor(float heightRatio)
    {
        if (float.IsNaN(heightRatio) || float.IsInfinity(heightRatio))
        {
            throw new ArgumentOutOfRangeException(nameof(heightRatio), "Height ratio must be a finite number.");
        }

        _heightRatio = Math.Clamp(heightRatio, 0.1f, 1.0f);
    }

    public string Name => FormattableString.Invariant($"bottom-focus-crop({_heightRatio:0.00})");

    public bool IsEnabled => _heightRatio < 0.999f;

    public CameraFrame Process(CameraFrame frame)
    {
        ArgumentNullException.ThrowIfNull(frame);

        if (!IsEnabled || frame.BytesPerPixel != 4)
        {
            return frame;
        }

        var width = frame.Width;
        var height = frame.Height;
        if (width <= 0 || height <= 0)
        {
            return frame;
        }

        var keptHeight = Math.Max(1, (int)MathF.Round(height * _heightRatio));
        if (keptHeight >= height)
        {
            return frame;
        }

        var destination = EnsureBuffer(width * height * frame.BytesPerPixel);
        var rowBytes = width * frame.BytesPerPixel;
        var sourceStartY = Math.Max(0, height - keptHeight);

        for (var y = 0; y < height; y++)
        {
            var sourceY = sourceStartY + SampleNormalized(y, height) * (keptHeight - 1);
            var y0 = Math.Clamp((int)MathF.Floor(sourceY), sourceStartY, height - 1);
            var y1 = Math.Min(y0 + 1, height - 1);
            var t = sourceY - y0;

            var sourceOffset0 = y0 * rowBytes;
            var sourceOffset1 = y1 * rowBytes;
            var destinationOffset = y * rowBytes;

            if (y0 == y1)
            {
                Buffer.BlockCopy(frame.PixelData, sourceOffset0, destination, destinationOffset, rowBytes);
                continue;
            }

            for (var x = 0; x < rowBytes; x += 4)
            {
                destination[destinationOffset + x + 0] = LerpByte(frame.PixelData[sourceOffset0 + x + 0], frame.PixelData[sourceOffset1 + x + 0], t);
                destination[destinationOffset + x + 1] = LerpByte(frame.PixelData[sourceOffset0 + x + 1], frame.PixelData[sourceOffset1 + x + 1], t);
                destination[destinationOffset + x + 2] = LerpByte(frame.PixelData[sourceOffset0 + x + 2], frame.PixelData[sourceOffset1 + x + 2], t);
                destination[destinationOffset + x + 3] = LerpByte(frame.PixelData[sourceOffset0 + x + 3], frame.PixelData[sourceOffset1 + x + 3], t);
            }
        }

        return new CameraFrame(
            destination,
            width,
            height,
            frame.BytesPerPixel,
            frame.Sequence,
            frame.ExposureTimestamp,
            $"{frame.SourceName}+bottom-focus-crop");
    }

    private byte[] EnsureBuffer(int requiredLength)
    {
        if (_buffer is null || _buffer.Length != requiredLength)
        {
            _buffer = new byte[requiredLength];
        }

        return _buffer;
    }

    private static float SampleNormalized(int index, int count)
    {
        if (count <= 1)
        {
            return 0f;
        }

        return index / (float)(count - 1);
    }

    private static byte LerpByte(byte a, byte b, float t)
    {
        return (byte)Math.Clamp(MathF.Round(a + ((b - a) * t)), 0f, 255f);
    }
}
