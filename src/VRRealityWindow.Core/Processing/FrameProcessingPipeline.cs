using VRRealityWindow.Core.Abstractions;

namespace VRRealityWindow.Core.Processing;

public sealed class FrameProcessingPipeline
{
    private readonly IReadOnlyList<IFrameProcessor> _processors;

    public FrameProcessingPipeline(IEnumerable<IFrameProcessor>? processors = null)
    {
        _processors = processors?.Where(processor => processor.IsEnabled).ToArray() ?? Array.Empty<IFrameProcessor>();
    }

    public bool HasProcessors => _processors.Count > 0;

    public string Description => _processors.Count == 0
        ? "disabled"
        : string.Join(" -> ", _processors.Select(processor => processor.Name));

    public CameraFrame Process(CameraFrame frame)
    {
        ArgumentNullException.ThrowIfNull(frame);

        var currentFrame = frame;
        foreach (var processor in _processors)
        {
            currentFrame = processor.Process(currentFrame);
        }

        return currentFrame;
    }

    public static FrameProcessingPipeline Create(ProcessingSettings settings)
    {
        ArgumentNullException.ThrowIfNull(settings);

        var processors = new List<IFrameProcessor>();
        if (settings.EnableBottomFocusCrop)
        {
            processors.Add(new BottomFocusCropProcessor(settings.BottomFocusHeightRatio));
        }

        return new FrameProcessingPipeline(processors);
    }
}
