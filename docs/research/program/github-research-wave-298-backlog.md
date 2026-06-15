# GitHub Research Wave 298 Backlog - OpenXR/Unity Hand Gesture Recognition, Sign Learning, and Hand Data Bridges

## Executed Scope

- Searched and deduplicated Unity XR Hands recognizers, gesture recorders,
  sign-learning apps, hand-to-controller POCs, package demos, and hand-data
  teleoperation bridges.
- Froze a six-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted wrist-local snapshots, MLP static recognition, DTW dynamic
  recognition, gesture state machines, editor recording/training, hand-shape
  assets, mirror-camera YOLO feedback, One Euro smoothing, and NetMQ joint
  streams.

## Studied Projects

- `HankunYu/Kuji-Kiri`
- `Phlegmati/SimpleGestureRecorder`
- `TF-polygon/XR-SignQuest`
- `ariesiitr/Hand-Tracking-VR`
- `Vin-meido/COM3D25_OpenXRHandsPOC`
- `ARCLab-MIT/BeaVR-app`

## Backlog Findings

- Build a comparison matrix across XRHandShape recorders, MLP classifiers, DTW
  recognizers, sign-learning inference, controller adapters, and joint streams.
- Deepen `Kuji-Kiri`, `SimpleGestureRecorder`, and `BeaVR-app` as strongest
  donors.
- Compare this wave with WebXR hand waves so runtime-specific terms stay
  aligned.
- Consider a reuse plan for a hand gesture kit with recorder, dataset schema,
  recognizer adapters, debug panels, confidence display, and output clamps.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a Unity/OpenXR hand gesture method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
