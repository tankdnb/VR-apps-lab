# VR Projects Wave 247: Webcam Avatar Body Tracking Bridges and VRM Motion Surfaces

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies camera, avatar, and body-tracking bridges: IMU plus headset
HTTP loops, browser multi-camera MediaPipe to OSC, Linux MediaPipe to SteamVR
synthetic trackers, browser VRM/Vtubing surfaces, and Unity avatar retargeting
with Photon networking.

## Why It Matters For `VR-apps-lab`

VR utilities often need to turn imperfect body data into usable avatar,
tracker, or overlay state. This wave focuses on the pipeline boundaries:
sensor/camera input, calibration, smoothing, transport, pose solving,
retargeting, synthetic tracker output, and product framing. It complements the
hardware tracker wave by studying software bridges that turn body signals into
VR-facing motion surfaces.

## Project Notes

### `zekailin00/VR-Full-Body-Tracking-System`

- Interesting idea:
  an experimental full-body tracking system can split into firmware sensor
  upload, Flask pose computation, Unity headset/controller upload, Unity pose
  polling, and avatar application.
- Code donor value:
  firmware reads LSM6DSOX accelerometer/gyro data on ESP8266, posts CSV-like
  IMU data to `/tracker-runtime/GyroAcc1`, and hardcodes WiFi/server targets.
  The Flask server exposes `/tracker-runtime/GyroAcc1`,
  `/unity-runtime/headset-data`, and `/unity-runtime/pose-data`. The algorithm
  module keeps shared input/output structs, locks updates, smooths IMU data via
  exponential moving average or buffers, maps physical IMU IDs to body parts,
  combines headset/controller pose with IMU estimates, and computes joint
  outputs. `VRDataStreaming.cs` posts HMD/controller position and Euler
  rotations, polls pose JSON, and applies rotations to named avatar bones.
- Product reference value:
  useful architecture reference for a student/research bridge where multiple
  devices feed one pose solver and Unity consumes the result.
- What to inspect next:
  compare its HTTP polling loop with OSC, WebSocket, shared-memory, and driver
  feeds from other tracker waves.
- Architecture pattern:
  ESP8266 IMU HTTP posts + Unity HMD/controller HTTP posts -> Flask shared
  pose solver -> Unity JSON polling -> bone rotations.
- Reusable method:
  make sensor input structs and pose output structs explicit before optimizing
  transport.
- Caveats:
  hardcoded WiFi credentials/IPs, coarse HTTP polling, student/research code,
  Euler-angle fragility, and some Unity code overrides solved pose with static
  rotations.

### `Raraph84/Cameras-Full-Body-Tracking`

- Interesting idea:
  browser cameras can be converted into SlimeVR/VRChat tracker poses through
  WebRTC video streams, MediaPipe landmark extraction, calibration storage,
  DLT triangulation, smoothing, and OSC output.
- Code donor value:
  the TypeScript server hosts HTTPS static pages and a WebSocket signaling
  server. It stores calibration data in `calibrations.json`, relays WebRTC
  offers/answers/ICE between streamer and viewer roles, receives landmarks,
  triangulates two calibrated MediaPipe pose streams through projection
  matrices, computes hip and foot yaw, smooths poses at 60 Hz, and sends
  `/tracking/trackers/{id}/position` and `/rotation` OSC messages to
  localhost:9000. The browser viewer imports MediaPipe Tasks Vision, receives
  a WebRTC stream, draws landmarks, throttles landmark sends to 10 Hz, and
  reconnects on socket close. `calibration.js` provides a four-corner square
  calibration UI, homography math, focal length estimation, reprojection
  preview, and save flow.
- Product reference value:
  strong donor for camera-to-tracker bridge UX and multi-stage calibration.
- What to inspect next:
  compare its browser WebRTC bridge against native webcam/SteamVR drivers and
  SlimeVR OSC bridge conventions.
- Architecture pattern:
  camera streamer -> WebRTC viewer -> browser MediaPipe -> server
  triangulation/smoothing -> OSC tracker poses.
- Reusable method:
  split camera streaming, calibration, landmark detection, triangulation, and
  VR tracker output into separately inspectable modules.
- Caveats:
  assumes two calibrated streams named `1` and `2`, local HTTPS certificates,
  OSC target conventions, and limited tracker set from hips/ankles.

### `DubbsPi/Mediapipe-SteamVR-Full-Body-Tracking-for-Linux`

- Interesting idea:
  a Linux SteamVR driver can expose synthetic generic trackers fed by a Python
  MediaPipe process over a Unix domain socket.
- Code donor value:
  `driver.cpp` implements `ITrackedDeviceServerDriver` for generic tracker
  devices, creates trackers for MediaPipe landmark indices 11-32, sets serial,
  model, and render model properties, starts a communication thread, listens
  on `/tmp/vr_unix_socket.sock`, receives fixed packets of one network-order
  int and three floats, and updates tracker poses through
  `TrackedDevicePoseUpdated` with identity rotation. `mediapipe_vr_sender.py`
  captures webcam frames, brightens and flips them, runs MediaPipe
  PoseLandmarker, filters landmarks by visibility, smooths 2D and world
  landmarks with deques, exposes GUI sliders for XYZ offset/smoothing/brightness,
  persists config, displays landmarks/FPS, and sends world landmark positions
  to the socket.
- Product reference value:
  strong bridge reference for local CV process plus SteamVR driver separation.
- What to inspect next:
  compare its synthetic tracker driver to prior custom-device plumbing and
  SlimeVR/OSC bridges.
- Architecture pattern:
  Python webcam/CV process -> Unix socket packets -> OpenVR server driver ->
  generic tracker poses.
- Reusable method:
  keep computer-vision inference outside the VR driver and feed a small packet
  protocol into synthetic devices.
- Caveats:
  Linux-specific socket path, identity rotations only in inspected driver,
  install scripts were not run, and OpenVR SDK path/build setup is external.

### `yeemachine/kalidoface-3d`

- Interesting idea:
  a browser Vtubing surface can combine webcam face/body/hand tracking,
  Kalidokit solving, VRM avatar loading, local model/background persistence,
  OBS browser-source mode, and peer-to-peer social product framing.
- Code donor value:
  README and package metadata show a Svelte/Vite web app using Three,
  `@pixiv/three-vrm`, MediaPipe Holistic/Pose/Face Mesh, TensorFlow models,
  Kalidokit, localforage, interact.js, and PeerJS. The public build exposes
  VRM drag-and-drop, locally saved models, backgrounds, stickers, chroma keys,
  selfie/first-person camera modes, OBS browser-object guidance, and a
  six-digit private voice call flow.
- Product reference value:
  strong product reference for webcam-to-avatar UX, streamer surfaces, and
  local-first personalization.
- What to inspect next:
  inspect unbundled source or Kalidokit itself if the repository needs code
  evidence for solving math rather than product flow.
- Architecture pattern:
  browser webcam -> MediaPipe/Kalidokit solving -> Three/VRM avatar surface ->
  local customization -> OBS/P2P social output.
- Reusable method:
  treat avatar tracking tools as product surfaces with model import, local
  persistence, background/chroma controls, and streaming integration.
- Caveats:
  source checkout mostly exposes README/package and bundled build, so use this
  wave as product/reference evidence rather than clean code donor.

### `Neleac/MesekaiUnity`

- Interesting idea:
  Unity avatar motion tracking can separate MediaPipe landmark solvers,
  retargeting to ReadyPlayerMe avatars, blendshape transfer, and Photon
  multiplayer serialization.
- Code donor value:
  `PoseSolver.cs` maps MediaPipe world landmarks to avatar arm chains,
  computes shoulder alignment, handles mirror mode, resets joint rotations,
  solves parent-child limb rotations with `Quaternion.FromToRotation`, and
  smooths with Slerp. `HandSolver.cs` maps hand landmarks to finger chains,
  aligns hand basis, clamps thumb/finger rotations, tracks detection state, and
  handles mirror mode. `FaceSolver.cs` builds a face plane from nose, head
  edges, and nasal landmarks, rotates the head bone, normalizes face landmarks,
  and maps eyes, brows, jaw, smile, and frown to blendshapes with smoothing.
  `MotionTransfer.cs` copies blendshapes and recursive joint rotations from a
  template avatar to a target avatar. `NetworkPlayer.cs` disables local controls
  for remote players, serializes blendshape weights and joint rotations through
  Photon, loads ReadyPlayerMe avatars from URLs, hides default meshes, and
  retargets received data to custom avatars.
- Product reference value:
  strong donor for webcam-avatar retargeting and networked avatar expression
  replication.
- What to inspect next:
  compare with browser Kalidokit/VRM and prior avatar embodiment waves to build
  a retargeting method matrix.
- Architecture pattern:
  MediaPipe Unity plugin landmarks -> pose/hand/face solvers -> template
  avatar -> motion/blendshape transfer -> Photon network avatar.
- Reusable method:
  solve motion on a stable template avatar, then transfer rotations and
  blendshapes to swappable user avatars.
- Caveats:
  depends on a forked MediaPipeUnityPlugin and submodules/LFS, uses hardcoded
  image dimensions in hand/face solvers, and assumes ReadyPlayerMe-style
  hierarchy/blendshape names.

## Reusable Pattern Extraction

- Pattern candidate:
  camera/avatar tracking bridge pipeline with calibration, transport, solving,
  and retargeting boundaries.
- Problem solved:
  body tracking projects become hard to reuse when camera/sensor capture,
  calibration, inference, smoothing, transport, driver output, and avatar
  retargeting are tangled together.
- Reusable core:
  capture source, calibration flow, landmark or IMU buffer, smoothing policy,
  pose solver, transport protocol, output adapter, synthetic tracker or avatar
  target, retargeting layer, user-facing tuning controls, and caveat logging.
- Source evidence:
  `VR-Full-Body-Tracking-System`, `Cameras-Full-Body-Tracking`,
  `Mediapipe-SteamVR-Full-Body-Tracking-for-Linux`, `kalidoface-3d`, and
  `MesekaiUnity`.
- Abstraction boundary:
  separate sensor/camera capture from inference, inference from pose solving,
  solving from transport, and transport from tracker or avatar application.
- What not to copy:
  hardcoded IPs and WiFi credentials, bundled/minified product builds as code
  evidence, fixed image dimensions, student polling loops as production
  architecture, or identity rotations as complete body tracking.
- Method catalog action:
  add a method entry for camera/avatar tracking bridge pipelines.

## Follow-Up Gaps

- Build a matrix comparing HTTP, WebSocket/WebRTC, OSC, Unix socket, and
  SteamVR driver output for body tracking bridges.
- Compare template-avatar retargeting with VRM/Kalidokit solving and
  SteamVR/SlimeVR tracker pose output.
- Extract a calibration UX checklist for camera-based body tracking: square
  calibration, reprojection preview, stream identity, smoothing, offsets, and
  validity feedback.
