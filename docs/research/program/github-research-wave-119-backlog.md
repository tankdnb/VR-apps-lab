# GitHub Research Wave 119 Backlog

- Date: `2026-06-05`
- Scope: VR teleoperation, WebXR/Unity/SteamVR frontends, robot-control
  transports, IK/MPC loops, diagnostics, safety gates, and demonstration data
  capture.

## Completed in this wave

- Studied `kscalelabs/kbot_vr_teleop` as a WebXR headset frontend plus Python
  IK and UDP command relay with Rerun visualization sidecars.
- Studied `dwaitbhatt/xarm_vr_teleop` as a lightweight headset-free OpenVR
  controller-to-xArm bridge.
- Studied `NVlabs/collab-sim` as an Isaac Sim/OpenXR VR teleop and MPC
  demonstration-capture research stack.
- Studied `wengmister/franka-vr-teleop` as a Quest hand-streaming, ROS2
  conversion, UDP/TCP/ADB reverse, weighted IK, and Ruckig velocity-control
  stack for Franka.
- Deepened `nakama-lab/VR_Teleop_Interface` from an existing not-yet marker
  into a partially studied Unity/ROS2/Quest/ZED/Franka bridge.
- Studied `open-thought/cambot` as a WebXR stereo camera-arm telepresence
  system with WebSocket/WebRTC transport, head-pose IK, HUD, watchdog, and
  safety bounds.
- Studied `plund-dtu/UR_VR_Teleop` as an OpenVR/Meta Quest controller bridge
  for Universal Robots with RTDE, gripper control, pause/recenter, and camera
  data collection.

## Reuse candidates

- `kbot_vr_teleop` is the strongest donor for WebXR headset frontend plus
  Python IK/UDP command relay anatomy.
- `cambot` is the strongest product reference for a polished browser headset
  telepresence surface with HUD, transport toggles, watchdog, and safety
  controls.
- `collab-sim` is the strongest simulation reference for VR controller poses,
  MPC, environment reset, and demonstration replay.
- `franka-vr-teleop` is a strong robot-control reference for pause/recenter,
  smoothing, weighted IK, and jerk-limited velocity output.
- `UR_VR_Teleop` is a compact donor for sequential teleop loop plus camera and
  robot-state logging.

## Follow-up backlog

1. Extract a generic VR teleop control-surface blueprint: headset frontend,
   pose transport, command server, IK/control loop, safety gates, visualizer,
   and data logger.
2. Compare WebXR (`kbot_vr_teleop`, `cambot`) against Unity/ROS
   (`VR_Teleop_Interface`) and OpenVR/SteamVR (`xarm_vr_teleop`,
   `UR_VR_Teleop`) control surfaces.
3. Deepen `collab-sim` if simulation telemetry overlays or robot-demo replay
   tools become a target.
4. Track K-Scale follow-up repositories (`arm-teleop`, `kbotv2_teleop`,
   `kteleop`) as lineage candidates only if they add a new architecture.
5. Consider a reuse-plan document for VR teleop safety and diagnostics if this
   family becomes a prototype branch.

## Quality notes

- No third-party project was built or launched.
- Downloaded source clones belong only in local cache and should be removed
  after the wave is committed.
- Physical robot code is documented as reference material only; `VR-apps-lab`
  is not becoming a robot-control application.
