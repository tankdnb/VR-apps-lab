# GitHub Research Wave 298 Plan - OpenXR/Unity Hand Gesture Recognition, Sign Learning, and Hand Data Bridges

## Goal

Study Unity/OpenXR hand projects as reusable references for joint sampling,
gesture recording, static/dynamic recognition, sign-learning feedback,
controller adaptation, and hand-joint transport.

## Research Questions

- How do projects separate XRHand sampling, normalization, dataset capture,
  recognizers, gesture state, UI feedback, and side effects?
- Which projects use rule/threshold gestures, ML classifiers, DTW sequences,
  mirror-camera inference, or transport-only joint streams?
- What editor tooling helps authors create, debug, and validate gestures?
- Which projects are package/source-light references rather than code donors?

## Shortlist

- `HankunYu/Kuji-Kiri`
- `Phlegmati/SimpleGestureRecorder`
- `TF-polygon/XR-SignQuest`
- `ariesiitr/Hand-Tracking-VR`
- `Vin-meido/COM3D25_OpenXRHandsPOC`
- `ARCLab-MIT/BeaVR-app`

## Required Checks

- Deduplicate against WebXR hand, Unity XR interaction, teleoperation, and
  gesture/menu waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep hand-size calibration, per-frame inference, package-only, and transport
  safety caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 298.
- Registry/family entries for Unity/OpenXR hand gesture projects.
- Method catalog entry for hand gesture recognition and hand-data bridge
  boundaries.
- Follow-up gaps around a gesture utility kit and Unity/WebXR vocabulary
  alignment.
