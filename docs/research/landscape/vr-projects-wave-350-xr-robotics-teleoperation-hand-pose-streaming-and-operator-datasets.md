# Wave 350: XR Robotics Teleoperation Hand Pose Streaming and Operator Datasets

## Scope

This wave studies headset-side robot operation stacks. The reusable pattern is
the operator cockpit: hand/head/controller tracking uplink, video/simulation
downlink, robot or simulator adapters, safety state, recording, and a clear
control surface for the human operator.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `arghyasur1991/synth-vr` | Studied | Quest MR package for physics humanoids with hand tracking, MRUK room colliders, passthrough rendering, scene wizard, MuJoCo scene setup, performance manager, lighting estimation, and permission checks |
| `unitreerobotics/xr_teleoperate` | Studied | Unitree XR teleoperation framework with AVP/PICO/Quest support, Vuer/WebRTC/HTTPS setup, hand/controller modes, robot/end-effector selection, simulation/physical deployment, recording, IPC, and safety notes |
| `Improbable-AI/VisionProTeleop` | Studied | Vision Pro robotics ecosystem with hand/head streaming, video/audio/simulation return streams, MuJoCo/Isaac AR scene streaming, egocentric dataset recording, cloud sync, calibration, and companion app |
| `XR-Robotics/XRoboToolkit-Unity-Client-Quest` | Studied | Quest Unity client with operator UI panel for network status, pose channel toggles, Send/A-button pause, remote stereo vision, data collection, logs, JNI/Android video plugin, and QoS split |
| `GeneralTrajectory/dex-teleop` | Studied | VR dexterous teleoperation system with Vive Tracker to xArm, Quest hand tracking to Inspire hands, HDF5 synchronized recording, safety limits, collision checks, and bimanual support |
| `h2r/GHOST` | Studied | Unity half of a Spot teleoperation stack with point-cloud visualization, gesture controls, Quest 3 testing, URDF via ROSBridge, and `ros_reality` dependency |
| `wengmister/quest-wrist-tracker` | Studied | Quest hand/wrist telemetry app with 21 hand landmarks, 6DoF wrist pose, UDP/TCP streaming, in-headset configuration, HUD/logs, phantom hand visualization, video streaming, and Python SDK |

## Reusable Pattern Extraction

- Pattern candidate: `XR robotics operator cockpit`.
- Problem solved: teleoperation needs a durable boundary between headset
  tracking, operator UI, video/simulation feedback, robot adapters, recording,
  and safety state.
- Reusable core: headset capability profile, tracking channel selectors,
  hand/controller/head packet schema, video source descriptor, WebRTC/UDP/TCP/
  DDS/ROSBridge transport adapters, robot/end-effector profile, simulator/
  physical mode switch, safety state machine, emergency pause, recording
  metadata, operator HUD, calibration/alignment tools, and replay/export path.
- Source evidence: XRoboToolkit exposes network/tracking/send/video/record
  panel controls; xr_teleoperate documents robot/arm/end-effector modes and
  simulation/physical launch parameters; VisionProTeleop streams hand/head data
  and video/simulation back to AVP; dex-teleop records synchronized HDF5 and
  applies workspace/collision gates; quest-wrist-tracker isolates hand packet
  streaming as a micro-utility.
- Abstraction boundary: headset apps should not directly know robot SDK
  details; robot adapters should consume normalized pose/action streams with
  safety mediation.
- What not to copy: live robot execution defaults, hardcoded lab IPs and
  certificates, proprietary camera permissions without fallback, opaque cloud
  uploads, or teleop flows without a visible pause/stop state.
- Method catalog action: create a new XR robotics operator-cockpit method.

## Project Notes

### `arghyasur1991/synth-vr`

- Interesting idea: a Unity package wizard configures MR robot simulation
  scenes by validating Meta Building Blocks and adding physics hands, room
  meshes, performance settings, and permissions.
- Code donor value: high for `VRSceneSetupWizard`, `PlayerHandBodies`,
  `SceneMeshManager`, `QuestPerformanceManager`, `PlayerLocomotion`, and
  ambient-light estimation.
- Product reference value: strong for setup wizards and room-aware robotics
  demos.
- What to inspect next: MuJoCo hand body mapping, contact-force haptics roadmap,
  and safe multi-agent support.
- Caveats: depends on synth-core, patched MuJoCo, Unity 6000, and Meta SDKs.

### `unitreerobotics/xr_teleoperate`

- Interesting idea: one host stack supports multiple XR devices, robot arm
  profiles, end-effectors, simulation, physical deployment, image services,
  recording, and IPC.
- Code donor value: high for launch parameter matrix, teleop folder split,
  robot control modules, hand retargeting, episode writer, IPC, and motion
  switcher.
- Product reference value: strong for professional robot operator workflows.
- What to inspect next: `television.py`, `tv_wrapper.py`, retargeting, safety
  state diagram, and episode schema.
- Caveats: hardware-specific, certificate-heavy, and dangerous if copied
  without safety defaults.

### `Improbable-AI/VisionProTeleop`

- Interesting idea: Vision Pro is treated as a bidirectional robotics endpoint:
  tracking uplink plus video/audio/simulation downlink and dataset recording.
- Code donor value: high for `avp_stream`, `Tracking Streamer`, simulation
  configuration, marker/stylus tracking APIs, and public dataset browser.
- Product reference value: strong for AVP robotics and egocentric data capture.
- What to inspect next: WebRTC lifecycle, cloud sync opt-in, tracking data
  schema, and calibration manager.
- Caveats: App Store components and personal cloud workflows are product
  dependencies, not purely local code.

### `XR-Robotics/XRoboToolkit-Unity-Client-Quest`

- Interesting idea: the headset UI explicitly exposes operator toggles for
  network, tracking channels, send/pause, remote vision, recording, and logs.
- Code donor value: high for operator panel design, JNI/Android split, video
  source config, and pose/video channel separation.
- Product reference value: strong Quest teleop client reference.
- What to inspect next: C# UI controllers, Android plugin protocol, packet
  format, and data collection file layout.
- Caveats: Quest-specific plugin constraints and unsupported OpenXR/XR Hands in
  this project.

### `GeneralTrajectory/dex-teleop`

- Interesting idea: VR tracking and Quest hand tracking are combined into a
  bimanual robot manipulation and imitation-learning recorder.
- Code donor value: high for xArm adapter, Quest hand receiver, HDF5 recorder,
  synchronized timestamps, workspace boundaries, collision checks, and smooth
  re-engagement.
- Product reference value: strong for safety-gated recording workflows.
- What to inspect next: `xarm_adapter.py`, `teleop_recorder.py`,
  `quest_hand_receiver.py`, and HDF5 replay.
- Caveats: README includes live-control commands; reuse must default to dry-run
  and safety locks.

### `h2r/GHOST`

- Interesting idea: teleoperation can use immersive point-cloud visualization
  and gesture controls with URDF-driven robot loading.
- Code donor value: moderate pending deeper Unity script inspection.
- Product reference value: useful as a Spot/ROSBridge operator reference.
- What to inspect next: ROSBridge topic model, point-cloud renderer, gesture
  recognizers, and `ros_reality` dependency.
- Caveats: Unity half only; full system requires external ROS stack.

### `wengmister/quest-wrist-tracker`

- Interesting idea: a standalone Quest app turns hand/wrist tracking into a
  low-latency telemetry appliance with in-headset configuration and debug HUD.
- Code donor value: high for packet format, UDP/TCP modes, HUD/log console,
  phantom hand visualization, and Python SDK boundary.
- Product reference value: strong micro-utility reference for teleop and motion
  capture.
- What to inspect next: packet schema, reconnect behavior, video streaming, and
  SDK visualization scripts.
- Caveats: external app/store distribution and sensor privacy need clear labels.

## Product Direction

This wave supports an `XR robotics operator` branch for VR-apps-lab: headset
telemetry micro-utilities, robot video panels, safety-gated pose transport,
dataset recorders, and simulation/physical mode operator cockpits.

