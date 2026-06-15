# GitHub Research Wave 302 Plan - Quest Camera CV, Object Detection, Segmentation, and World Marker Pipelines

## Goal

Study Quest camera CV projects as reusable references for passthrough-to-CV
adapters, Sentis/OpenCV inference, object detection, segmentation masks,
environment-raycast marker placement, tracked semantic entities, debug surfaces,
and camera privacy boundaries.

## Research Questions

- How do projects schedule inference without blocking the frame loop?
- How are camera frames, pose/intrinsics metadata, model execution, output
  parsing, world projection, and marker lifecycle separated?
- Which projects are useful for object boxes, masks, ArUco/QR, or tracked
  semantic world state?
- What should become a reusable camera-CV method?

## Shortlist

- `demoPlz/Unity-MultiObjectDetection`
- `EnoxSoftware/QuestWithOpenCVForUnityExample`
- `rikturnbull/xr-image-segmentation`
- `oculus-samples/Unity-SpatialLingo`

## Required Checks

- Deduplicate against previous Quest camera, MRUK, marker, and object detection
  waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep package/license, model provenance, privacy, and commented-source caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 302.
- Registry/family entries for Quest camera CV and marker pipelines.
- Method catalog entry for camera-CV inference and world-marker boundaries.
- Follow-up gaps around detection/segmentation matrices and diagnostics.
