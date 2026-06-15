# GitHub Research Wave 302 Backlog - Quest Camera CV, Object Detection, Segmentation, and World Marker Pipelines

## Executed Scope

- Searched and deduplicated Quest passthrough camera CV, object detection,
  OpenCV/ArUco, Sentis, segmentation, and world-marker projects.
- Froze a four-project shortlist, with `Unity-SpatialLingo` intentionally used
  as a cross-wave overlap reference from Wave 301.
- Read source and documentation statically from local-only cache.
- Extracted inference idle gates, layer-per-frame scheduling, async output
  readbacks, OpenCV `Mat` conversion with pose/intrinsics metadata,
  environment-raycast placement, mask rendering, tracked taxa, and privacy/debug
  lessons.

## Studied Projects

- `demoPlz/Unity-MultiObjectDetection`
- `EnoxSoftware/QuestWithOpenCVForUnityExample`
- `rikturnbull/xr-image-segmentation`
- `oculus-samples/Unity-SpatialLingo`

## Backlog Findings

- Deepen active source state for `Unity-MultiObjectDetection`; some inspected
  inference code appeared in commented sections.
- Build a detection/segmentation matrix across object boxes, masks, ArUco/QR,
  world markers, tracked taxa, and privacy gates.
- Compare OpenCV, Sentis, and official Meta object-classifier boundaries.
- Consider a reuse plan for a camera-CV diagnostic surface showing frame state,
  model state, inference latency, raycast hit, confidence, and marker lifecycle.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a Quest camera CV/world-marker method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
