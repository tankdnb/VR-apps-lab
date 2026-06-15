# GitHub Research Wave 309 Plan - VR Motion Capture, Pose Recording, BVH, Muscle Compression, and Body Tracker Samples

## Goal

Study VR motion capture, pose recording, BVH, muscle compression, and body
tracker samples as reusable references for tracker ingestion, retargeting,
recording, playback, export, compression, calibration, and diagnostics.

## Research Questions

- How do projects separate live tracking APIs from avatar retargeting and
  recorder/export logic?
- Which pose/controller-state schemas are reusable for replay and QA?
- How are BVH hierarchy, channel order, humanoid bones, and engine transforms
  separated?
- What tracker inventory, confidence, calibration, and battery state should
  future utilities expose?

## Shortlist

- `alexismorin/OpenMocap`
- `andrewjc/VRRecorder`
- `emilianavt/BVHTools`
- `gree/MuscleCompressor`
- `Pico-Developer/PICOMotionTrackerSample-Unity`

## Required Checks

- Deduplicate against earlier tracker bridge, body tracking, OSC/WebSocket, and
  diagnostics waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep legacy XR/SteamVR, vendor SDK, dependency-heavy, unversioned schema, and
  compression-caveat notes explicit.

## Expected Outputs

- Landscape synthesis for Wave 309.
- Registry/family entries for mocap, pose recording, BVH, compression, and body
  tracker samples.
- Method catalog entry for motion capture and pose-recording boundaries.
- Follow-up gaps for capture/replay matrices and tracker diagnostics.
