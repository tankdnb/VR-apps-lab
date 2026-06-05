# VR Projects Wave 163: External Pose, Object, and Sensor Data to VRChat OSC Bridges

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 163 studies projects that move external pose, object, mocap, or sensor
state into VRChat through OSC tracker endpoints or avatar parameters.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `jangxx/VRC-Tracked-Objects` | Avatar-relative tracked object bridges | Strong product and math donor |
| `FizzyApple12/VRChatOSCOptitrack` | Mocap-system to OSC tracker bridges | Useful primitive donor |
| `rogeraabbccdd/VRChat-MotionOSC` | Vision-based motion controls | Useful product/reference donor |
| `takana-v/quest_steamvr_fbt_tool` | SteamVR tracker to OSC FBT bridges | Useful simple script donor |
| `Alpyg/vrc_osc_tracker` | Camera pose-estimation OSC trackers | Useful calibration/pose donor |

## `jangxx/VRC-Tracked-Objects`

- Interesting idea:
  bring real-world handheld objects into VRChat by calibrating a Vive tracker
  relative to a controller/hand anchor and streaming the object transform into
  avatar parameters.
- Code donor value:
  high. The project includes WPF UI, config persistence, OpenVR device
  selection, calibration, matrix math, OSCQuery/manual OSC modes, and
  avatar-side setup docs.
- Product reference value:
  high. It explains the avatar package contract, VRCFury/manual setup,
  expression menu activation, calibration UX, status states, and troubleshooting.
- What to inspect next:
  compare its avatar-relative calibration model with VMT, SlimeVR, and
  `/tracking/trackers` endpoint approaches.
- Architecture pattern:
  app stores configurations, avatar IDs, serial numbers, OSC parameter names,
  and calibration matrices. OpenVR queries controllers and generic trackers,
  polls poses through `GetLastPoses`, computes controller-to-tracker and
  hand-to-controller transforms, extracts position/rotation, and sends values
  to avatar parameters. Calibration creates OpenVR overlay planes for visual
  alignment, keyboard arrows edit fields, and OSC state gates tracking by
  current avatar and optional activation parameter.
- Reusable method:
  avatar-relative tracked-object bridge with explicit calibration matrix and
  avatar package contract.
- Caveats:
  setup is involved, stability depends on hand/controller anchoring, avatar
  parameter contract is custom, and OpenVR/VRChat behavior can drift with scale
  changes.

## `FizzyApple12/VRChatOSCOptitrack`

- Interesting idea:
  map OptiTrack/NatNet rigid bodies directly to VRChat's OSC tracker endpoints
  and visualize the mocap environment while assigning tracker IDs.
- Code donor value:
  medium-high for NatNet ingestion, OSC tracker bundle writes, coordinate
  conversion, and visualization scaffolding.
- Product reference value:
  medium. It is primitive but honest about missing playspace calibration.
- What to inspect next:
  compare its rigid body mapping with robust calibration systems before using
  any mocap bridge as a product baseline.
- Architecture pattern:
  C++ app connects to NatNet, receives marker and rigid body frames, stores
  ordered collections, converts NatNet right-handed Z-up positions/rotations to
  a VRChat-friendly coordinate system, lets UI map OSC tracker IDs to OptiTrack
  rigid body IDs, writes `/tracking/trackers/{id}/position` and rotation
  messages into tinyosc bundles, sends to VRChat UDP port `9000`, and renders an
  ImGui/OpenGL environment and marker/rigid-body view.
- Reusable method:
  NatNet rigid-body to VRChat OSC tracker bridge with visual assignment UI.
- Caveats:
  no playspace calibration, Windows/Visual Studio/NatNet SDK dependency, and
  primitive product state.

## `rogeraabbccdd/VRChat-MotionOSC`

- Interesting idea:
  use webcam-derived motion and face cues as a lightweight VRChat control
  surface for movement, jumping, object manipulation, and avatar expressions.
- Code donor value:
  medium. The OSC sender and Electron/Vue shell are straightforward, while the
  motion algorithms are experimental.
- Product reference value:
  medium-high for an accessibility/alternate-control concept.
- What to inspect next:
  compare gesture thresholds and calibration with modern MediaPipe body/hand
  bridges.
- Architecture pattern:
  Electron main process opens a UDP OSC port to VRChat and exposes IPC handlers
  such as face parameter sends, movement, look, jump, and item manipulation.
  Renderer-side motion modules use webcam landmarks/gestures, thresholds, and
  pinch state to trigger IPC events. Settings choose webcam device and avatar
  face parameters.
- Reusable method:
  webcam motion/face recognition to VRChat OSC command bridge.
- Caveats:
  experimental, old Electron/Node stack, hardcoded VRChat movement semantics,
  and likely needs modern vision-model replacement before reuse.

## `takana-v/quest_steamvr_fbt_tool`

- Interesting idea:
  use SteamVR-recognized trackers from a PC or Quest-adjacent workflow as
  VRChat OSC FBT trackers by sending `/tracking/trackers/{n}` position and
  rotation messages.
- Code donor value:
  medium. The Python script is simple and useful as a minimal OpenVR-to-OSC
  reference.
- Product reference value:
  medium. It documents headless SteamVR/null-driver setup and tray-style
  operation.
- What to inspect next:
  compare its simple height offset and serial config against robust tracker
  calibration systems.
- Architecture pattern:
  Python reads `qsft_config.ini`, initializes OpenVR as an overlay app, logs
  device serials, resolves configured device names to indexes, optionally uses a
  standard device to derive a Y offset, polls `VRCompositor().getLastPoses`,
  extracts position and Euler rotation from device matrices, sends OSC position
  and rotation to `/tracking/trackers/{i+1}`, and runs a wx taskbar icon with
  exit handling.
- Reusable method:
  minimal SteamVR tracker to VRChat OSC FBT bridge with serial-based config.
- Caveats:
  simple Euler math, no robust calibration, Japanese README, OpenVR dependency,
  and proof-of-concept posture.

## `Alpyg/vrc_osc_tracker`

- Interesting idea:
  use MediaPipe pose landmarks from calibrated cameras to synthesize hip,
  feet, and head trackers for VRChat OSC.
- Code donor value:
  medium-high for calibration command modes and tracker abstraction.
- Product reference value:
  medium. It is a compact example of camera pose estimation to OSC trackers.
- What to inspect next:
  compare intrinsic/extrinsic calibration and tracker smoothing against other
  MediaPipe-to-SlimeVR/OSC bridges.
- Architecture pattern:
  CLI supports frame capture, intrinsic calibration, stereo extrinsic
  calibration, transform solving, config file loading, and normal tracking.
  Runtime loads MediaPipe pose landmarker, maps nose, hip midpoint, and ankles
  into tracker objects, applies offsets through a tracker abstraction, and sends
  OSC messages to `/tracking/trackers/{namespace}/position` and rotation.
- Reusable method:
  camera-calibrated MediaPipe pose-landmark to VRChat OSC tracker sender.
- Caveats:
  camera calibration quality dominates results, rotation inference is limited,
  and model/camera/runtime requirements make it a research reference rather
  than a turnkey tracker.

## Cross-Project Lessons

- Pose bridges need a declared coordinate contract: avatar-relative,
  playspace-relative, camera-relative, or device-relative.
- Calibration UX is the product, not an optional setup page.
- VRChat OSC tracker endpoints are simple enough for prototypes, but smoothing,
  scale, activation, and avatar-side contracts decide whether the tool feels
  usable.
- Vision-based controls should separate gesture recognition from OSC command
  mapping so thresholds can be replaced without rewriting the bridge.

## Reusable Methods Extracted

- Avatar-relative tracked-object bridge with calibration matrix.
- NatNet rigid body to VRChat OSC tracker bridge.
- Webcam motion and face recognition to OSC command bridge.
- Minimal SteamVR tracker serial config to OSC FBT sender.
- Camera-calibrated MediaPipe pose landmark to OSC tracker sender.

## Follow-Up Backlog

- Build a pose-ingress matrix across OpenVR, NatNet, MediaPipe, VMC, VMT,
  SlimeVR, and VRChat OSC tracker endpoints.
- Split calibration patterns into avatar-relative, playspace-relative,
  camera-relative, and device-relative categories.
- Promote simple scripts as method donors only, not as product baselines, until
  calibration and smoothing are robust.
