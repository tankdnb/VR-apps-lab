# GitHub Research Wave 210 Backlog

Date: 2026-06-06

Theme: MediaPipe/avatar tracking sidecars and camera-inference bridges.

## Completed In This Wave

- Deepened `hotaru86/MediapipeFaceTracking_VRC` as a MediaPipe to VRCFT OSC expression mapper.
- Deepened `how-people-lived/mediapipe-vrm-tracking` as a browser VRM avatar diagnostics and mapping tool.
- Deepened `Metastazius/VRBodyTrack` as a Python/MediaPipe to Unity named-pipe body bridge.
- Deepened `MasonSakai/VR-AI-Full-Body-Tracking` as a multi-camera AI FBT and virtual tracker pipeline.
- Added a reusable method entry for camera inference to avatar/tracker signal normalization.

## Follow-Up Queue

1. Compare OSC, named-pipe, WebSocket, and virtual-driver outputs for camera-inference sidecars.
2. Extract a clean mapping schema for source signals, normalized values, target parameters, tuning fields, and diagnostics.
3. Revisit `VR-AI-Full-Body-Tracking` specifically for multi-camera triangulation and calibration flow if tracker prototypes resume.
4. Use `mediapipe-vrm-tracking` as a reference for browser-based mapping UI and JSON export, not as a production architecture.
5. Track repo hygiene caveats where Unity `Library`, binaries, pycache, or hardcoded local paths are checked into public projects.

## Do Not Spend Time On Yet

- Do not evaluate tracking quality by running models.
- Do not reuse hardcoded Python paths, camera IDs, or checked-in Unity artifact layouts.
- Do not treat legacy OpenVR Input Emulator pipelines as a modern runtime target without a migration plan.
