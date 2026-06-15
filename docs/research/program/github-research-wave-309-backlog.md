# GitHub Research Wave 309 Backlog - VR Motion Capture, Pose Recording, BVH, Muscle Compression, and Body Tracker Samples

## Executed Scope

- Searched and deduplicated motion capture, pose recording, BVH, muscle
  compression, and PICO motion/body tracker projects.
- Froze a five-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted roomscale humanoid IK, Unity Recorder coupling, SteamVR
  pose/controller-state text logs, playback device injection, BVH recorder/
  parser separation, muscle-space compression product flow, tracker serial
  inventory, confidence feedback, calibration/battery UI, 24-joint body pose,
  CSV playback, and bone-length updates.

## Studied Projects

- `alexismorin/OpenMocap`
- `andrewjc/VRRecorder`
- `emilianavt/BVHTools`
- `gree/MuscleCompressor`
- `Pico-Developer/PICOMotionTrackerSample-Unity`

## Backlog Findings

- Build a capture/replay matrix for device type, sample clock, schema,
  compression, playback injection, avatar retargeting, and export target.
- Deepen `gree/MuscleCompressor` to isolate the actual muscle stream and
  compression code.
- Compare PICO tracker state UI with earlier device-monitor and diagnostics
  waves.
- Compare BVH export with future OSC/WebSocket tracker bridge formats.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a motion capture and pose recording method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
