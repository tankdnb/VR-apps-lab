namespace VRRealityWindow.Core.Utilities;

public static class BmpWriter
{
    public static void WriteBgra32(string path, CameraFrame frame)
    {
        if (frame.BytesPerPixel != 4)
        {
            throw new InvalidOperationException("BMP export expects a BGRA32 frame.");
        }

        Directory.CreateDirectory(Path.GetDirectoryName(path) ?? ".");

        const int fileHeaderSize = 14;
        const int dibHeaderSize = 40;
        var pixelBytes = frame.Width * frame.Height * frame.BytesPerPixel;
        var fileSize = fileHeaderSize + dibHeaderSize + pixelBytes;

        using var stream = File.Create(path);
        using var writer = new BinaryWriter(stream);

        writer.Write((byte)'B');
        writer.Write((byte)'M');
        writer.Write(fileSize);
        writer.Write((short)0);
        writer.Write((short)0);
        writer.Write(fileHeaderSize + dibHeaderSize);

        writer.Write(dibHeaderSize);
        writer.Write(frame.Width);
        writer.Write(-frame.Height);
        writer.Write((short)1);
        writer.Write((short)32);
        writer.Write(0);
        writer.Write(pixelBytes);
        writer.Write(2835);
        writer.Write(2835);
        writer.Write(0);
        writer.Write(0);
        writer.Write(frame.PixelData, 0, pixelBytes);
    }
}
