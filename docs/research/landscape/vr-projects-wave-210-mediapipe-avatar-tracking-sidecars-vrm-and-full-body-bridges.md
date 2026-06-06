# VR Projects Wave 210: MediaPipe Avatar Tracking Sidecars, VRM Mapping, and Full-Body Bridges

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-210-plan.md`
- `docs/research/program/github-research-wave-210-backlog.md`

Research mode: static source reading only. No external repository was run, built, installed, or launched.

## Why This Wave Matters

Camera-inference projects are useful because they repeatedly solve the same reusable problem: capture noisy model output, normalize it into a stable signal schema, expose tuning controls, and bridge the result into a VR target runtime or avatar system.

Wave 210 extracts that sidecar pattern across face, avatar, body, and full-body tracking projects.

## Project Findings

### `hotaru86/MediapipeFaceTracking_VRC`

- Interesting idea: map MediaPipe Face Landmarker blendshapes into VRChat/VRCFT OSC parameters with per-parameter sensitivity, min/max clamps, and explicit ARKit-to-VRCFT conversion.
- Code donor value: high. `mediapipe_facetracking_VRC.py` includes camera scanning, Tkinter settings UI, OSC IP/port fields, `blendshape_params.json` persistence, ARKit/VRCFT mapping dictionaries, sensitivity/min/max transforms, boolean decomposition for negative/signed parameters, and OSC sends under `/avatar/parameters/FT/v2/{name}`.
- Product reference value: high for a small sidecar that gives users direct tuning control over expressions.
- Architecture pattern: local camera inference sidecar plus normalization layer plus OSC output schema plus settings UI.
- Reusable method: keep model output names, target parameter names, tuning fields, and transport separately visible.
- Constraints and caveats: webcam/MediaPipe dependency, per-avatar tuning burden, and a single-process GUI/inference/transport design.
- What to inspect next: whether the mapping schema can be extracted into a reusable table format for other avatar targets.
- Why it matters for `VR-apps-lab`: it is a strong donor for expression tracking sidecars and parameter normalization.

#### Reusable Pattern Extraction

- Pattern candidate: expression signal normalizer and OSC bridge.
- Problem solved: convert model-specific blendshape output into target-avatar parameters users can tune.
- Reusable core: source signal table, target schema table, sensitivity/min/max fields, clamp logic, persistence, and transport send loop.
- Source evidence: `mediapipe_facetracking_VRC.py` and `blendshape_params.json`.
- Abstraction boundary: keep MediaPipe capture, mapping/tuning, and OSC transport separable.
- What not to copy: one-file coupling if future sidecars need multiple runtimes or diagnostics views.
- Method catalog action: create Method 655.

### `how-people-lived/mediapipe-vrm-tracking`

- Interesting idea: put face, hand, pose, VRM model loading, blendshape mapping, and JSON export into a browser-only avatar diagnostics workbench.
- Code donor value: medium to high. `facial_tracking_vrm.html` dynamically imports Three.js and `@pixiv/three-vrm`, supports VRM drag/drop, camera selection, Face/Hand/Pose landmarkers, expression toggles, finger/hand/arm controls, mapping configuration, JSON export, and recording-oriented frame state.
- Product reference value: high. It shows how useful a visual avatar workbench can be for tuning and debugging mappings before connecting to a VR runtime.
- Architecture pattern: browser-only diagnostics app with model preview, mapping editor, and exportable config.
- Reusable method: provide a live avatar preview and editable mapping surface for camera-inference tools.
- Constraints and caveats: large single HTML file, CDN dependency, no external transport bridge, and not structured as a library.
- What to inspect next: which mapping-editor ideas should be separated into a reusable UI component or config schema.
- Why it matters for `VR-apps-lab`: it is a strong product reference for mapping diagnostics, even if code reuse is selective.

### `Metastazius/VRBodyTrack`

- Interesting idea: stream MediaPipe body landmarks from Python into Unity through a named pipe, then compute useful exercise/pose angles inside the Unity app.
- Code donor value: medium. `ServerOpen/main.py` starts a body tracking thread, while `VRBodyTrack/Assets/Scripts/MediapipeRTStream.cs` opens `NamedPipeServerStream("VRBodyTrack")`, reads length-prefixed landmark lines, maps MediaPipe landmark IDs to Unity vectors, and computes elbow, shoulder, hip, and knee angles.
- Product reference value: medium for exercise analysis and Unity-side body diagnostics.
- Architecture pattern: Python inference producer plus Unity named-pipe consumer plus joint-angle calculation.
- Reusable method: keep a minimal local IPC bridge between model inference and Unity visualization/analysis.
- Constraints and caveats: blocking pipe connection pattern, hardcoded camera/path assumptions, checked-in Unity `Library` and generated artifacts, and limited runtime isolation.
- What to inspect next: non-blocking IPC, message schema validation, and extracting joint-angle calculation into a reusable module.
- Why it matters for `VR-apps-lab`: it gives a useful named-pipe bridge and body-angle computation reference, with clear caveats.

### `MasonSakai/VR-AI-Full-Body-Tracking`

- Interesting idea: combine browser camera feeds, MoveNet pose inference, calibration, multi-camera triangulation, Qt/dashboard tooling, and virtual tracker output into an AI full-body tracking pipeline.
- Code donor value: high for architecture fragments. `Remote1CamProcessing/src/ai-manager.js` shows TensorFlow MoveNet setup, WebGL backend use, keypoint score filtering, and named keypoint output. `VR_AI_FBT_Core/PoseTracker.cpp` shows config-driven tracker toggles, camera arrays, confidence flags, closest-ray triangulation, dampened tracker updates, hip/shoulder averaging, and virtual-device cleanup.
- Product reference value: high as an ambitious camera-based FBT product line, even though the runtime target is legacy.
- Architecture pattern: multi-process camera/inference pipeline plus calibration/triangulation core plus virtual tracker output.
- Reusable method: use confidence filtering, per-camera observations, calibration transforms, ray intersection, dampening, and tracker state gates before emitting body trackers.
- Constraints and caveats: legacy OpenVR Input Emulator dependency, Windows/Chrome/Qt assumptions, rewrite warning in README, and high complexity.
- What to inspect next: calibration UI, camera-manager/server split, and how to replace legacy Input Emulator output with a modern runtime bridge.
- Why it matters for `VR-apps-lab`: it is a strong donor for multi-camera tracker architecture and confidence-gated pose fusion.

#### Reusable Pattern Extraction

- Pattern candidate: multi-camera AI pose to virtual tracker bridge.
- Problem solved: turn 2D camera detections into stable tracker poses for VR avatar body tracking.
- Reusable core: per-camera keypoint confidence, camera calibration, ray/pose fusion, dampening, tracker enable flags, and runtime output boundary.
- Source evidence: `ai-manager.js` and `PoseTracker.cpp`.
- Abstraction boundary: keep camera inference, triangulation/calibration, and runtime tracker emission as separate subsystems.
- What not to copy: legacy Input Emulator target and hardcoded platform assumptions.
- Method catalog action: included in Method 655.

## Cross-Project Lessons

- Strong sidecars expose mappings and tuning instead of hiding them behind model output.
- Browser avatar previews are excellent diagnostics surfaces even when they are not production architecture.
- Transport choice matters less than a clear signal schema: OSC, named pipes, WebSocket, and virtual trackers can all consume the same normalized core.
- Repo hygiene should be tracked as a reuse caveat when generated Unity artifacts or binaries obscure the donor code.

## Method Catalog Actions

- Added Method 655: camera inference to avatar/tracker signal normalizer.

## Follow-Up Gaps

- Define a reusable tracking-sidecar schema covering source signals, target outputs, tuning ranges, confidence, calibration, and diagnostics.
- Compare OSC, WebSocket, named pipe, and runtime-driver outputs for future tracker helpers.
- Revisit multi-camera triangulation only when a tracker prototype needs a concrete donor.
