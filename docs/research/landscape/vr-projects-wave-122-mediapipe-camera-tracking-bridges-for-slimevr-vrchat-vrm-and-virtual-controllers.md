# VR Projects Wave 122: MediaPipe Camera Tracking Bridges for SlimeVR, VRChat, VRM, and Virtual Controllers

- Date: `2026-06-05`
- Goal: add a focused GitHub discovery wave for small camera/MediaPipe bridge
  projects that turn webcam landmarks into tracker packets, avatar expressions,
  Unity avatar pose streams, browser VRM animation, or virtual-controller OSC.

## Why this wave exists

Vision tracking often looks like one big product category, but the reusable
engineering value is usually in the seams:

- which landmarks are trusted;
- how axes/quaternions/blendshapes are derived;
- how smoothing and calibration are handled;
- which transport format is emitted;
- how target-specific assumptions are isolated.

This wave studies small repos because they make those seams visible.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by MediaPipe VR, SlimeVR, VRChat face tracking, VRM tracking,
   and webcam controller bridge families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist of new micro-bridges;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, product value, caveats, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `TkskKurumi/SlimeVR-Tracker-Mediapipe` | MediaPipe pose landmarks converted into SlimeVR-style UDP tracker rotations |
| `hotaru86/MediapipeFaceTracking_VRC` | Webcam face tracking mapped toward VRChat avatar parameters |
| `how-people-lived/mediapipe-vrm-tracking` | Browser-only MediaPipe face/hand/arm tracking for VRM and ARKit-like blendshapes |
| `Metastazius/VRBodyTrack` | Python MediaPipe world landmarks streamed through a Windows named pipe into Unity avatar IK |
| `vwitted/mediapipe_VR_controller` | Minimal MediaPipe Hands wrist landmark exported as virtual-controller OSC |

## Deep-pass notes by project

## `TkskKurumi/SlimeVR-Tracker-Mediapipe`

- GitHub:
  [TkskKurumi/SlimeVR-Tracker-Mediapipe](https://github.com/TkskKurumi/SlimeVR-Tracker-Mediapipe)
- What it is:
  a Python MediaPipe pose bridge that sends SlimeVR-compatible tracker
  rotations over UDP.
- Interesting idea:
  a webcam skeleton can be converted into multiple virtual trackers by deriving
  approximate local axes from landmarks, smoothing quaternions over time, and
  sending separate SlimeVR packets per body segment.
- Code-level notes:
  `detect.py` captures camera frames, runs `mp_pose.Pose`, converts landmarks
  into a custom coordinate system, estimates hip/leg/ankle axes, handles
  visibility, and builds a calibration lookup from pose vectors through a KD
  tree. `geometry.py` implements point, coordinate-system, quaternion,
  cross-product, and yaw/pitch/roll helpers. `main.py` smooths axes and
  calibration quaternions, creates hip/ankle/leg tracker quaternions, and sends
  them through several `UdpClient.client` instances. `UdpClient.py` implements
  SlimeVR-like handshake, heartbeat, packet buffers, and quaternion payloads.
- Code donor value:
  high for landmark-to-axis construction, smoothing, calibration lookup, and
  SlimeVR UDP packet anatomy.
- Product reference value:
  medium-high for camera-based tracking experiments and tracker bridge
  diagnostics.
- Caveats:
  hardcoded camera index, experimental coordinate conversion, and fragile
  calibration; not a production tracker.
- What to inspect next:
  compare packet format with SlimeVR firmware/server references from Wave 109.

## `hotaru86/MediapipeFaceTracking_VRC`

- GitHub:
  [hotaru86/MediapipeFaceTracking_VRC](https://github.com/hotaru86/MediapipeFaceTracking_VRC)
- What it is:
  a Python webcam face-tracking application for VRChat-facing expression
  output.
- Interesting idea:
  a compact face bridge can bundle the MediaPipe face landmarker task, map
  blendshape coefficients into avatar parameters, and send them through a
  simple local output path.
- Code-level notes:
  `mediapipe_facetracking_VRC.py` is the main application and includes camera
  capture, MediaPipe face-landmarker setup, blendshape handling, UI/debug
  output, and target parameter emission logic. The repository also includes
  `face_landmarker_v2_with_blendshapes.task`, making the model dependency
  explicit.
- Code donor value:
  medium-high for webcam face tracking to avatar expression mapping.
- Product reference value:
  high for small avatar-facing tracking utilities.
- Caveats:
  language/local setup assumptions and bundled model file; target schema needs
  careful verification before reuse.
- What to inspect next:
  compare with VRCFaceTracking module patterns from Wave 106 and ALVR payload
  adapter patterns from Wave 120.

## `how-people-lived/mediapipe-vrm-tracking`

- GitHub:
  [how-people-lived/mediapipe-vrm-tracking](https://github.com/how-people-lived/mediapipe-vrm-tracking)
- What it is:
  a browser-only MediaPipe and VRM tracking demo for face, hands, arms, and
  ARKit-compatible blendshape intent.
- Interesting idea:
  browser-only avatar tracking can be packaged as a single-page lab where
  camera input, MediaPipe inference, VRM avatar rendering, and blendshape
  mapping stay inspectable in one file.
- Code-level notes:
  `facial_tracking_vrm.html` and `facial_tracking_demo.html` combine browser
  UI, MediaPipe task loading, camera access, tracking loop, blendshape mapping,
  and VRM/avatar output surfaces.
- Code donor value:
  medium for browser-only tracking demo structure and blendshape mapping.
- Product reference value:
  medium-high for quick avatar calibration or preview tools.
- Caveats:
  single-file demo style; needs modularization before reuse.
- What to inspect next:
  compare with WebXR/A-Frame utility patterns if browser avatar diagnostics
  become active.

## `Metastazius/VRBodyTrack`

- GitHub:
  [Metastazius/VRBodyTrack](https://github.com/Metastazius/VRBodyTrack)
- What it is:
  a Python MediaPipe server plus Unity avatar project for body tracking.
- Interesting idea:
  a tracking bridge can keep computer-vision capture in a Python process and
  feed a Unity avatar scene through a simple named-pipe text protocol.
- Code-level notes:
  `ServerOpen/body.py` captures camera frames, runs MediaPipe pose with world
  landmarks, formats 33 landmark rows as `id|x|y|z`, and writes length-prefixed
  ASCII payloads to `\\.\pipe\VRBodyTrack`. Unity-side scripts such as
  `MediapipeRTStream.cs` and `AvatarController.cs` consume landmarks and apply
  IK-style rotations to avatar hands/feet/spine.
- Code donor value:
  medium for process split and text-pipe landmark transport.
- Product reference value:
  medium for Unity avatar preview/tracking experiments.
- Caveats:
  repository includes Unity cache/build artifacts and editor state; use only as
  a reference for process boundaries.
- What to inspect next:
  compare with cleaner Unity/OSC body-tracking bridges before any reuse.

## `vwitted/mediapipe_VR_controller`

- GitHub:
  [vwitted/mediapipe_VR_controller](https://github.com/vwitted/mediapipe_VR_controller)
- What it is:
  a minimal Python MediaPipe Hands bridge that sends one hand landmark as a
  virtual-controller pose over OSC.
- Interesting idea:
  the smallest useful bridge can prove an output transport with one landmark
  before solving full hand pose.
- Code-level notes:
  `vr_controller.py` opens a webcam, runs `mp_hands.Hands`, takes wrist
  landmark `0`, maps it into a simple position payload, and sends it to
  `/VMT/Raw/Unity` over OSC through `pythonosc`.
- Code donor value:
  low-medium as a tiny OSC transport proof.
- Product reference value:
  medium as a micro-utility or classroom example.
- Caveats:
  one landmark, hardcoded local port, no orientation, and no calibration.
- What to inspect next:
  compare against stronger VMT/OSC bridges before any real prototype.

## Cross-project synthesis

These projects reinforce a `camera landmark bridge` method:

- capture camera frames;
- run MediaPipe model;
- choose landmarks and confidence gates;
- derive axes, quaternions, blendshapes, or simple positions;
- smooth and calibrate;
- emit target-specific payloads through UDP, OSC, browser state, named pipes,
  or Unity scripts.

The reusable pattern is the boundary, not the tracking quality. Good future
tools should make target schema, calibration state, and debug visualization
explicit.

## Follow-up

1. Compare MediaPipe-to-SlimeVR, MediaPipe-to-VMT, and MediaPipe-to-VRChat OSC
   schemas.
2. Extract a reusable calibration/smoothing checklist for camera tracking
   bridges.
3. Keep these repos categorized as micro-bridges, not mature tracking systems.
