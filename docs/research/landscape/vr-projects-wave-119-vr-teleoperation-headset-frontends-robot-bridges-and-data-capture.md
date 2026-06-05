# VR Projects Wave 119: VR Teleoperation Headset Frontends, Robot Bridges, and Data Capture

- Date: `2026-06-05`
- Goal: add a focused GitHub discovery wave for VR teleoperation projects that
  turn headsets, controllers, and hand tracking into robot-control surfaces,
  simulation-control loops, stereo camera views, diagnostics, and data-capture
  workflows.

## Why this wave exists

Teleoperation projects use VR differently from overlays or scene apps. The
headset becomes an operator surface; the controller or hand pose becomes a
control input; and the real value is often in transport, safety, IK/MPC,
visualization, and dataset logging.

This wave studies VR teleop repositories as reusable architecture references
for future VR utilities that need low-latency pose transport, WebXR or Unity
frontends, SteamVR/OpenVR controller bridges, robot/simulation command loops,
operator HUDs, watchdogs, recenter/pause affordances, and synchronized capture.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by VR teleop, WebXR robot teleop, OpenVR robot control,
   Quest teleoperation, Isaac Sim VR teleop, and ROS/Unity robot interface
   families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, product value, caveats, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `kscalelabs/kbot_vr_teleop` | WebXR headset frontend, Python IK, UDP command relay, robot meshes, and Rerun visualizer sidecars |
| `dwaitbhatt/xarm_vr_teleop` | Lightweight headset-free SteamVR/OpenVR controller-to-xArm bridge |
| `NVlabs/collab-sim` | Isaac Sim/OpenXR VR robot teleoperation, MPC/IK, environment reset, and demonstration capture |
| `wengmister/franka-vr-teleop` | Quest hand-pose streaming, ROS2 conversion, UDP/TCP bridge, weighted IK, Ruckig, and pause/recenter controls |
| `nakama-lab/VR_Teleop_Interface` | Unity/Quest/ROS2/ZED/Franka multi-branch teleop interface with stereo feed and haptic feedback |
| `open-thought/cambot` | WebXR stereo camera-arm telepresence with WebSocket/WebRTC, HUD, safety bounds, and watchdog |
| `plund-dtu/UR_VR_Teleop` | OpenVR/Meta Quest controller bridge for Universal Robots with RTDE, gripper control, and data collection |

## Deep-pass notes by project

## `kscalelabs/kbot_vr_teleop`

- GitHub:
  [kscalelabs/kbot_vr_teleop](https://github.com/kscalelabs/kbot_vr_teleop)
- What it is:
  a K-Scale VR teleoperation stack with a React/WebXR headset frontend, Python
  IK and command relay, policies, robot assets, and Rerun visualization tools.
- Interesting idea:
  a headset web app can stream hand/controller tracking through WebSocket,
  display robot/video surfaces in VR, then let a Python sidecar perform IK and
  send UDP command packets to the robot while a separate Rerun sidecar mirrors
  the same commands for diagnostics.
- Code-level notes:
  `frontend/src/WebXR.tsx` runs the XR loop, controller input, hand/controller
  tracking, WebSocket setup, joystick state, and robot mesh updates.
  `frontend/src/lib/tracking.ts` normalizes hand joints, controller poses, and
  joystick axes into shared tracking messages. `src/kscale_vr_teleop/` contains
  command connection, signaling, tracking handler, hand IK, JAX IK, teleop
  core, and finger UDP helpers. `command_conn.py` converts arm angles and
  joysticks into JSON UDP command fields. `rerun/visualizer.py` listens for the
  same command schema and logs robot state/plots to Rerun. `notes.md` explains
  why the project avoids ngrok/Vuer-style latency and uses local HTTPS plus
  custom JAX IK.
- Code donor value:
  very high for WebXR headset frontend, tracking transport, IK sidecar, UDP
  command schema, and diagnostics sidecar anatomy.
- Product reference value:
  very high for VR operator panels and robot-control utilities.
- Caveats:
  robot-specific command schema and K-Bot assumptions; do not copy into
  `VR-apps-lab` as runnable robot code.
- What to inspect next:
  compare with `cambot` for browser headset UX polish and with `collab-sim`
  for data capture/replay.

## `dwaitbhatt/xarm_vr_teleop`

- GitHub:
  [dwaitbhatt/xarm_vr_teleop](https://github.com/dwaitbhatt/xarm_vr_teleop)
- What it is:
  a lightweight OpenVR/SteamVR controller teleoperation bridge for xArm6.
- Interesting idea:
  useful VR teleop does not always need a headset display. A tracked controller
  plus SteamVR null-driver/no-HMD setup can provide 6DoF input for robot pose
  targets and gripper state.
- Code-level notes:
  `triad_openvr.py` wraps OpenVR device discovery, pose matrices, quaternions,
  velocities, battery, controller inputs, and haptic pulses. `robot_control.py`
  initializes controller and xArm state, computes relative pose deltas,
  smooths VR position, clips velocities, runs inverse kinematics, supports
  several control modes, uses trigger for gripper open/close, and menu button
  to exit. `xarm6.py` wraps xArm API calls for end-effector, joint, velocity,
  and gripper helpers.
- Code donor value:
  high for minimal OpenVR controller-to-robot bridge anatomy.
- Product reference value:
  medium-high for headsetless VR input and lab-control tools.
- Caveats:
  physical robot safety, hardcoded paths/config, and hardware assumptions make
  this reference-only.
- What to inspect next:
  compare null-driver setup and controller polling with no-HMD/virtual-HMD
  families.

## `NVlabs/collab-sim`

- GitHub:
  [NVlabs/collab-sim](https://github.com/NVlabs/collab-sim)
- What it is:
  a research package for GPU-accelerated robot teleoperation with Isaac Sim,
  OpenXR/VR, MPC/IK via CuRobo, and demonstration collection/replay.
- Interesting idea:
  a simulation teleop stack can integrate VR rendering, physics, controller
  poses/buttons, robot MPC, environment reset, logging, and replay into one
  research loop.
- Code-level notes:
  `collab_robot_controller.py` wraps robot control, CuRobo IK/MPC solver
  setup, goal updates, and MPC steps. `collab_vrteleop.py` and demos wire VR
  controller follower frames, button managers, robot reset callbacks, and
  controller-triggered gripper/reset actions. `collab_teleop_utils.py` includes
  Isaac Sim helpers, object loading, random cube placement, world state
  logging, and `SimDataLog` for VR demonstration output. Example demos cover
  single and dual Franka teleoperation, environment reset, data logging, and
  replay.
- Code donor value:
  high for VR-to-MPC simulation loop and demonstration logging.
- Product reference value:
  high for simulation telemetry, reset, replay, and training-data workflows.
- Caveats:
  heavy Isaac Sim/CUDA/CuRobo stack; valuable for architecture, not quick reuse.
- What to inspect next:
  deep-dive data logging and replay if simulation telemetry tools become a
  `VR-apps-lab` branch.

## `wengmister/franka-vr-teleop`

- GitHub:
  [wengmister/franka-vr-teleop](https://github.com/wengmister/franka-vr-teleop)
- What it is:
  a Franka VR teleoperation system using a Meta Quest hand-tracking app,
  ROS2-side conversion, UDP/TCP streaming, weighted IK, Ruckig trajectories,
  and joint-space velocity control.
- Interesting idea:
  high-performance teleop benefits from separating headset pose acquisition,
  ROS visualization/smoothing, TCP/ADB or UDP transport, real-time robot
  client, weighted IK, jerk-limited trajectory generation, pause/recenter, and
  debug pose publishing.
- Code-level notes:
  `vr_to_robot_converter.py` receives VR pose data, smooths position and
  orientation, handles fist-based pause/resume, recalibrates initial pose on
  resume, publishes VR/robot target poses, sends absolute pose commands, and
  optionally manages `adb reverse` for TCP streaming. `franka_vr_control_client.cpp`
  opens a nonblocking UDP server, filters VR pose, computes deltas from the
  initial pose, configures weighted IK, initializes Ruckig, blends targets,
  outputs smooth joint velocities, and falls back to zero velocity on errors.
- Code donor value:
  very high for smoothing, pause/recenter, weighted IK, Ruckig, and transport
  boundary patterns.
- Product reference value:
  high for responsive hand-pose teleoperation and operator safety UX.
- Caveats:
  physical robot and real-time control assumptions; reference only.
- What to inspect next:
  compare pause/recenter and smoothing design with `UR_VR_Teleop` and
  `cambot`.

## `nakama-lab/VR_Teleop_Interface`

- GitHub:
  [nakama-lab/VR_Teleop_Interface](https://github.com/nakama-lab/VR_Teleop_Interface)
- What it is:
  a multi-branch Unity/ROS2/Docker teleoperation interface for Franka, ZED2
  stereo camera, force/torque feedback, and Meta Quest 2.
- Interesting idea:
  a teleop interface can treat Unity as the headset/control frontend, ROS TCP
  as the topic bridge, ZED as a separate camera/Docker system, and Franka as a
  separate control system, with haptic feedback from force/torque readings and
  SSH-triggered infrastructure launch from Unity.
- Code-level notes:
  the main branch documents the architecture and links branch-specific code:
  Unity scripts for controller input, movement publishing, vibration manager,
  stereo camera feed, image subscriber, and SSH runner; ROS2 nodes for pose
  modification, impedance control, gripper command, force/torque filter; and
  ZED bridge/ROS TCP endpoint deployment.
- Code donor value:
  medium-high for multi-machine ROS/Unity/Quest/ZED bridge architecture.
- Product reference value:
  high for operator workflow, stereo feed, and haptic feedback loop.
- Caveats:
  multi-branch project; this wave deepened architecture status but did not
  exhaust every branch.
- What to inspect next:
  inspect branch-specific Unity and ROS code if stereo video or haptic feedback
  becomes a focused prototype direction.

## `open-thought/cambot`

- GitHub:
  [open-thought/cambot](https://github.com/open-thought/cambot)
- What it is:
  a 6-DoF stereo camera arm with WebXR telepresence and head-pose control.
- Interesting idea:
  a polished browser telepresence utility can combine stereo video,
  WebSocket/WebRTC transport, WebXR head pose, controller buttons, VR HUD,
  watchdog pause, workspace bounds, smoothing, velocity clamping, and robot
  diagnostics in one operator surface.
- Code-level notes:
  `cambot/teleop/server.py` serves HTTPS/WebSocket, streams frames, accepts
  head pose messages, manages WebRTC availability, exposes telemetry, and
  detects bufferbloat/RTT pauses. `client/index.html` implements WebXR, stereo
  video texture, transport toggle, HUD, controller button shortcuts, WebSocket
  reconnect, head-pose sending, and headset visibility pause behavior.
  `ik_solver.py` maps WebXR coordinates to robot frame, captures neutral pose,
  clamps position deltas or workspace bounds, validates IK/FK periodically, and
  returns last valid angles on failure. The README documents home, pause,
  resolution, transport, HUD, watchdog, and safety controls.
- Code donor value:
  very high for WebXR telepresence UX, transport fallback, HUD, watchdog, and
  safety bounds.
- Product reference value:
  very high for VR operator surface design.
- Caveats:
  custom hardware and servo assumptions; reuse concepts, not robot-specific
  control values.
- What to inspect next:
  compare browser headset UI and transport design with `kbot_vr_teleop`.

## `plund-dtu/UR_VR_Teleop`

- GitHub:
  [plund-dtu/UR_VR_Teleop](https://github.com/plund-dtu/UR_VR_Teleop)
- What it is:
  a lightweight Meta Quest/OpenVR teleoperation controller for Universal
  Robots using `ur_rtde`, Robotiq gripper control, and optional data capture.
- Interesting idea:
  a compact teleop loop can make pause/unpause and recenter explicit: read
  controller pose/buttons, reset controller and robot reference state on
  unpause, map VR axes into robot frame, servo toward Cartesian targets, and
  log cameras/robot state at a lower frequency than the control loop.
- Code-level notes:
  `ur_teleop_utils.py` initializes RTDE control/receive, gripper, OpenVR, home
  pose, pause loop, controller readings, axis remap matrices, trigger-driven
  gripper, `servoL` target updates, and recenter-on-unpause state reset.
  `ur_teleop_data_collection.py` adds RealSense multiprocessing/shared-memory
  workers, episode data dictionaries for joint states, gripper state, EEF
  poses, RGB/depth images, forces, A-button save, B-button reset, and 15 Hz
  logging. `ur_teleop_custom_data_collection.py` shows a simpler loop for
  custom logging formats.
- Code donor value:
  high for compact OpenVR controller loop, pause/recenter, and data logging.
- Product reference value:
  high for robot-learning data collection workflows.
- Caveats:
  physical robot safety and RTDE/Quest/SteamVR assumptions; reference only.
- What to inspect next:
  compare data collection structure with `collab-sim` and future synchronized
  capture backlogs.

## Main takeaways from Wave 119

- VR teleoperation is a control-surface architecture family: headset frontend,
  pose transport, command bridge, IK/MPC/control loop, safety gates, visualizer,
  and data capture.
- WebXR appears repeatedly as a practical headset frontend for robot utilities,
  especially when local HTTPS/WebSocket/WebRTC is controlled by the project.
- Pause/recenter/watchdog/smoothing/workspace bounds are not optional polish;
  they are the core UX for safe operator control.
- Diagnostics sidecars such as Rerun visualizers and simulation replay tools
  are reusable outside robotics.
- Robot-specific code should stay reference-only unless a future prototype
  intentionally enters that domain.

## Reusable methods clarified by this wave

- `VR teleop headset frontend plus desktop IK and UDP robot relay`
- `Headset-free OpenVR controller-pose to robot-command bridge`
- `Simulation VR teleop loop with MPC, reset callbacks, and demonstration replay`
- `Teleop pause, recenter, smoothing, watchdog, and workspace safety gates`
- `VR teleop diagnostics sidecar and synchronized data-capture loop`

## Recommended next moves after this wave

1. Draft a generic VR teleop architecture map if this family becomes an active
   product branch.
2. Use `cambot` and `kbot_vr_teleop` as the strongest WebXR control-surface
   references.
3. Use `franka-vr-teleop` and `UR_VR_Teleop` for pause/recenter and smoothing
   patterns.
4. Use `collab-sim` as the primary simulation/data replay reference.
5. Move `VR_Teleop_Interface` from not-yet to partially studied, with branch
   deepening still available as a follow-up.
