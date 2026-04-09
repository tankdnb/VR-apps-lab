namespace VRRealityWindow.Core.Abstractions;

public interface IFrameProcessor
{
    string Name { get; }
    bool IsEnabled { get; }

    CameraFrame Process(CameraFrame frame);
}
