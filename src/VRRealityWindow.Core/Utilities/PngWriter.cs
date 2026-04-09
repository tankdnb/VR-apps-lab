using System.IO.Compression;

namespace VRRealityWindow.Core.Utilities;

public static class PngWriter
{
    private static readonly byte[] Signature = new byte[] { 137, 80, 78, 71, 13, 10, 26, 10 };

    public static void WriteBgra32(string path, CameraFrame frame)
    {
        if (frame.BytesPerPixel != 4)
        {
            throw new InvalidOperationException("PNG export expects a BGRA32 frame.");
        }

        if (frame.Width <= 0 || frame.Height <= 0)
        {
            throw new InvalidOperationException("PNG export expects a non-empty frame.");
        }

        Directory.CreateDirectory(Path.GetDirectoryName(path) ?? ".");

        var scanlineLength = 1 + (frame.Width * 4);
        var rawData = new byte[scanlineLength * frame.Height];

        for (var y = 0; y < frame.Height; y++)
        {
            var srcRowStart = y * frame.Width * 4;
            var dstRowStart = y * scanlineLength;
            rawData[dstRowStart] = 0;

            for (var x = 0; x < frame.Width; x++)
            {
                var src = srcRowStart + (x * 4);
                var dst = dstRowStart + 1 + (x * 4);
                rawData[dst + 0] = frame.PixelData[src + 2];
                rawData[dst + 1] = frame.PixelData[src + 1];
                rawData[dst + 2] = frame.PixelData[src + 0];
                rawData[dst + 3] = frame.PixelData[src + 3];
            }
        }

        using var stream = File.Create(path);
        stream.Write(Signature, 0, Signature.Length);

        Span<byte> ihdr = stackalloc byte[13];
        WriteInt32BigEndian(ihdr[..4], frame.Width);
        WriteInt32BigEndian(ihdr.Slice(4, 4), frame.Height);
        ihdr[8] = 8;
        ihdr[9] = 6;
        ihdr[10] = 0;
        ihdr[11] = 0;
        ihdr[12] = 0;
        WriteChunk(stream, "IHDR", ihdr.ToArray());

        using var compressed = new MemoryStream();
        using (var zlib = new ZLibStream(compressed, CompressionLevel.Fastest, leaveOpen: true))
        {
            zlib.Write(rawData, 0, rawData.Length);
        }

        WriteChunk(stream, "IDAT", compressed.ToArray());
        WriteChunk(stream, "IEND", Array.Empty<byte>());
    }

    private static void WriteChunk(Stream stream, string type, byte[] data)
    {
        Span<byte> lengthBytes = stackalloc byte[4];
        WriteInt32BigEndian(lengthBytes, data.Length);
        stream.Write(lengthBytes);

        var typeBytes = System.Text.Encoding.ASCII.GetBytes(type);
        stream.Write(typeBytes, 0, typeBytes.Length);
        if (data.Length > 0)
        {
            stream.Write(data, 0, data.Length);
        }

        var crcInput = new byte[typeBytes.Length + data.Length];
        Buffer.BlockCopy(typeBytes, 0, crcInput, 0, typeBytes.Length);
        if (data.Length > 0)
        {
            Buffer.BlockCopy(data, 0, crcInput, typeBytes.Length, data.Length);
        }

        Span<byte> crcBytes = stackalloc byte[4];
        WriteUInt32BigEndian(crcBytes, Crc32(crcInput));
        stream.Write(crcBytes);
    }

    private static uint Crc32(byte[] bytes)
    {
        uint crc = 0xFFFFFFFF;
        foreach (var b in bytes)
        {
            crc ^= b;
            for (var i = 0; i < 8; i++)
            {
                var mask = (uint)-(int)(crc & 1);
                crc = (crc >> 1) ^ (0xEDB88320 & mask);
            }
        }

        return ~crc;
    }

    private static void WriteInt32BigEndian(Span<byte> destination, int value)
    {
        destination[0] = (byte)((value >> 24) & 0xFF);
        destination[1] = (byte)((value >> 16) & 0xFF);
        destination[2] = (byte)((value >> 8) & 0xFF);
        destination[3] = (byte)(value & 0xFF);
    }

    private static void WriteUInt32BigEndian(Span<byte> destination, uint value)
    {
        destination[0] = (byte)((value >> 24) & 0xFF);
        destination[1] = (byte)((value >> 16) & 0xFF);
        destination[2] = (byte)((value >> 8) & 0xFF);
        destination[3] = (byte)(value & 0xFF);
    }
}
