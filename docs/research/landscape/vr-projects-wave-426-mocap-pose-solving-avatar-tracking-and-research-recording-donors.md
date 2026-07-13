# VR Projects Wave 426 - Mocap Pose Solving Avatar Tracking And Research Recording Donors

- Date: `2026-07-13`
- Theme: video mocap, pose solving, avatar tracking, forwarding, and research-grade recording pipelines.

## Shortlist

| Project | Study status | Why it matters |
|---|---|---|
| `xianfei/SysMocap` | Studied | Electron/Vue/three.js/MediaPipe/Kalidokit avatar mocap app with VRM/FBX binding and WebXR/OBS forwarding |
| `yeemachine/kalidokit` | Studied | Solver library turning face/pose/hand landmarks into VRM/Live2D-friendly rotations, blendshapes, and poses |
| `emilianavt/OpenSeeFace` | Studied | CPU face/facial landmark tracker with UDP transport and Unity receiver/launcher integration |
| `freemocap/freemocap` | Studied | Open-source research-grade motion capture platform with recording/session pipeline orientation |

## Cross-Project Synthesis

This wave turns mocap projects into reusable VR utility architecture. The
shared pattern is a multi-stage pipeline:

- capture source;
- landmark/model inference;
- solver or tracker normalization;
- avatar/rig binding;
- transport or forwarding;
- recording/session metadata.

The strongest reuse value for `VR-apps-lab` is not to copy a whole mocap app,
but to define a neutral pose/tracker pipeline that can feed OSC, WebSocket,
UDP, WebXR, Unity, or avatar tools.

## Project Notes

### `xianfei/SysMocap`

- Interesting idea:
  combine webcam/video mocap, avatar rendering, model import, recording, OBS
  browser-source, and WebXR forwarding in one desktop application.
- Code donor value:
  repo documents an Electron main process, worker-thread forwarding server,
  MediaPipe Holistic to Kalidokit solving, three.js/three-vrm rendering,
  VRM/FBX/glTF binding, and WebXR web client split.
- Product reference value:
  strong reference for an end-user mocap utility with model import, dark GUI,
  recording, and external-output modes.
- Source evidence:
  README lists MediaPipe Holistic, Kalidokit, VRM 0.x/1.0, Mixamo FBX auto
  skeleton detection, OBS, full-body mocap, WebXR forwarding over HTTPS, and
  Electron/Vue UI; repo notes describe `webserv/worker.js`, `webserv/server.js`,
  Socket.IO message forwarding, and a standalone `webserv/public` renderer.
- Reusable core:
  landmark pipeline, rig solver, avatar renderer, model binding map,
  forwarding worker, Socket.IO transport, HTTPS/WebXR flag, recording helpers,
  and settings groups.
- What not to copy:
  legacy Electron security settings, duplicated rig logic, misspelled internal
  channels, or bundled model assumptions without provenance checks.
- What to inspect next:
  forwarding payload schema, settings migration, avatar binding boundaries, and
  whether OSC/WebSocket adapters can wrap the same pose records.

### `yeemachine/kalidokit`

- Interesting idea:
  package pose/face/hand solving as a reusable library between landmark models
  and avatar rigs.
- Code donor value:
  README documents `Face.solve`, `Pose.solve`, `Hand.solve`, `stabilizeBlink`,
  and solver outputs for face/head/mouth/eye/pupil and body/hand rotations.
- Product reference value:
  excellent boundary reference: keep ML landmark detection separate from rig
  solving and avatar transport.
- Source evidence:
  README describes MediaPipe/TensorFlow.js landmark inputs, VRM/Live2D use,
  blendshape/kinematics calculation, and solver APIs for face, pose, and hand.
- Reusable core:
  typed landmark input, solver layer, normalized joint/blendshape output,
  blink stabilization, and rig-facing adapter.
- What not to copy:
  deprecated package assumptions, model-specific landmark ordering without
  validation, or solver outputs without confidence/stale-state metadata.
- What to inspect next:
  current maintained forks, output schema stability, and avatar rig mapping
  tests.

### `emilianavt/OpenSeeFace`

- Interesting idea:
  run face tracking as a separate process that sends data over UDP to a Unity
  receiver, enabling privacy/performance isolation.
- Code donor value:
  README documents `facetracker.py`, UDP tracking data, Unity `OpenSee`
  receiver, calibration/expression detection, and `OpenSeeLauncher` process
  lifecycle.
- Product reference value:
  strong reference for sidecar trackers that can run on another PC and expose a
  narrow transport surface to VR apps.
- Source evidence:
  README states that `facetracker.py` tracks webcam/video and sends UDP data;
  Unity side receives packets into public `trackingData`; `OpenSeeLauncher`
  can start/stop the tracker process, list cameras, and use Windows job objects
  to stop child processes if the app crashes.
- Reusable core:
  tracker sidecar, camera selection, UDP packet schema, receiver component,
  calibration save/load, expression detection, process supervisor, and privacy
  warning.
- What not to copy:
  thread-unsafe Unity data access, opaque UDP schema without versioning, or
  face tracking defaults without consent and camera indicators.
- What to inspect next:
  packet schema, Unity receiver thread boundary, and process restart/error
  handling.

### `freemocap/freemocap`

- Interesting idea:
  position motion capture as a low-cost, hardware/software agnostic,
  research-grade recording platform.
- Code donor value:
  project structure and README emphasize installable Python package, GUI,
  documentation, session/recording workflow, and research/education use.
- Product reference value:
  useful reference for dataset-oriented capture tools: session metadata,
  reproducibility, export, and analysis matter as much as live avatar output.
- Source evidence:
  README describes FreeMoCap as a free, open-source, low-cost, research-grade
  motion capture platform for decentralized research, education, and training.
- Reusable core:
  recording session model, participant/experiment metadata, camera source
  abstraction, processing pipeline, export artifacts, and documentation path.
- What not to copy:
  research claims without validation labels, large platform scope, or capture
  hardware assumptions without calibration and provenance.
- What to inspect next:
  session folder schema, camera calibration artifacts, export formats, and
  replay/analysis boundaries.

## Reusable Pattern Extraction

- Pattern candidate:
  `Pose solver and tracker data pipeline`.
- Problem solved:
  VR utilities need reusable body/face/hand/tracker streams without coupling to
  one app, model, avatar format, or transport.
- Reusable core:
  capture source, landmark provider, solver layer, confidence/stale metadata,
  normalized rig/blendshape record, transport adapters, avatar binding,
  recording/session artifacts, and privacy/performance split.
- Source evidence:
  `xianfei/SysMocap`, `yeemachine/kalidokit`, `emilianavt/OpenSeeFace`, and
  `freemocap/freemocap`.
- Abstraction boundary:
  keep detection, solving, transport, avatar binding, and recording as separate
  swappable stages.
- What not to copy:
  insecure Electron defaults, deprecated solver assumptions, unversioned UDP
  packets, or research-grade claims without calibration and validation notes.
- Method catalog action:
  add new method for pose solver/tracker data pipelines.

## Follow-Up Gaps

- Draft a neutral pose/tracker JSON schema for OSC/WebSocket/UDP bridges.
- Compare avatar binding approaches for VRM, Mixamo FBX, Live2D, Unity
  humanoid, and VRChat parameters.
- Define privacy labels for camera, face, body, and recording data.

