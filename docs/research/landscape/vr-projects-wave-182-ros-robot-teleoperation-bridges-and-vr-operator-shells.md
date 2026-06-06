# VR Projects Wave 182: ROS/Robot Teleoperation Bridges and VR Operator Shells

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 182 studies VR-to-robot operator systems: Unity/OpenXR controller
publishers, ROS1/ROS2 bridges, MoveIt/RelaxedIK command paths, OpenVR operator
stations, WebSocket command buffers, camera panels, TF exports, mode switches,
and safety gates.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `UM-ARM-Lab/vr_teleop` | ROS1 VR pose-to-IK teleoperation | Strong safety-gated IK bridge donor |
| `UM-ARM-Lab/vr_ros2_bridge` | Unity OpenXR controller/tracker publisher to ROS2 | Strong XR device publisher donor |
| `h2r/ros_reality_bridge` | Legacy ROS/TF/camera to Unity bridge | Legacy scene/camera bridge reference |
| `Intelligent-Robotics-Lab/vr-teleoperation` | OpenVR/ROS robot operator station | Strong operator-shell reference |
| `zz0320/vr_teleoperation_ros` | WebSocket-to-ROS command modes, IK, camera UDP, and audio feedback | Strong command-buffer donor |
| `Mcen25/VR-Teleoperation-Robotics-Platform` | Unity XRI/ROS# camera and diagnostics shell | Thin camera-panel reference |
| `lingxiaomeng/VR_teleoperation_ros` | Empty source sync candidate | Excluded from studied registry entries |

## `UM-ARM-Lab/vr_teleop`

- Interesting idea:
  gate VR arm control behind an enable service, transform VR pose targets into
  MoveIt IK, seed IK from measured robot joints, and publish commands only when
  the target is near enough to current state.
- Code donor value:
  high for pose-to-IK pipeline, measured-state seeding, joint-distance safety
  threshold, gripper command gating, and ROS service control.
- Product reference value:
  high for any VR operator utility that needs explicit arm/hand state,
  operator enable/disable, and safe command publishing.
- What to inspect next:
  compare its safety gate with mode-switch and stale-data gates in other
  teleoperation projects.
- Source evidence:
  `vive_msgs/msg/Controller.msg`, `ViveSystem.msg`,
  `dual_arm_teleop/include/unity_teleop.hpp`,
  `dual_arm_teleop/src/unity_teleop.cpp`, `unity_arm.cpp`, and
  `srv/SetEnabled.srv`.
- Reusable pattern extraction:
  safety-gated VR pose to robot IK bridge.
- Reusable core:
  receive tracked controller poses and joystick/gripper states, keep a
  teleop-enabled service gate, seed IK from measured joint positions, reject
  commands that jump too far from measured state, publish validity state, and
  publish gripper/arm commands only while enabled.
- Do not copy directly:
  robot-specific Victor dependencies, ROS1 install assumptions, or old headers
  without cleanup.
- Caveats:
  powerful architecture reference, but not a generic VR app utility.

## `UM-ARM-Lab/vr_ros2_bridge`

- Interesting idea:
  use Unity OpenXR to publish normalized controllers and Vive trackers to ROS2,
  including pose, twist, buttons, axes, and tracker roles.
- Code donor value:
  high for XR device enumeration, OpenXR HTC tracker role profile, Unity to ROS
  coordinate conversion, and debug pose/twist topics.
- Product reference value:
  high for diagnostics, robotics, external tracker inventory, and
  headset-to-ROS utility bridges.
- What to inspect next:
  compare its ROS-TCP-Connector path with ROS# and direct WebSocket approaches.
- Source evidence:
  `Runtime/Scripts/PublishControllerInfo.cs`,
  `Runtime/Scripts/HTCViveTrackerProfile.cs`, message definitions, and
  `Packages/manifest.json`.
- Reusable pattern extraction:
  normalized XR controller/tracker publisher.
- Reusable core:
  enumerate tracked XR devices, filter controllers and HTC tracker roles,
  publish pose/twist/button/axis snapshots at a fixed cadence, convert Unity
  left-handed transforms to ROS right-handed frames, and expose debug topics.
- Do not copy directly:
  HTC/OpenXR-specific role assumptions or duplicated button queries.
- Caveats:
  publisher/bridge reference only; robot actuation is out of scope.

## `h2r/ros_reality_bridge`

- Interesting idea:
  sweep ROS TF frames and camera sources into a compact string stream for a
  Unity scene, using rosbridge and camera compression launch plumbing.
- Code donor value:
  medium for legacy TF export, simple scene-state string packing, and launch
  orchestration of cameras/rosbridge.
- Product reference value:
  medium for understanding older ROS-to-Unity scene bridge constraints.
- What to inspect next:
  convert the string protocol concept into typed JSON/protobuf if reused.
- Source evidence:
  `src/unityNode.py`, `src/garyunityNode.py`, and launch files.
- Reusable pattern extraction:
  TF frame sweep to external scene bridge.
- Reusable core:
  enumerate relevant TF frames, look up transforms relative to a base frame,
  pack link poses into a compact outgoing stream, and start camera compression
  plus rosbridge in one launch topology.
- Do not copy directly:
  Python2/ROS Indigo/Baxter-specific code or untyped string protocol.
- Caveats:
  legacy reference, not a modern donor.

## `Intelligent-Robotics-Lab/vr-teleoperation`

- Interesting idea:
  build a complete OpenVR operator station with ROS publishing, ImGui status
  panels, modes, in-HMD camera texture, OpenVR input actions, and calibrated
  human-to-robot transform mapping.
- Code donor value:
  high for operator mode shell, action abstraction, camera-to-GL texture
  surface, dashboard controls, and calibrated transform-to-joint mapping.
- Product reference value:
  high for VR control rooms, robot dashboard overlays, and operator safety UX.
- What to inspect next:
  isolate the reusable operator-shell structure from Pepper/Nao-specific
  kinematics and hardcoded paths.
- Source evidence:
  `EntryPoint.cpp`, `RobotControllerApp.cpp`, `RosNode.cpp`,
  `CameraView.cpp`, `WindowOverlay.cpp`, `VRInput.h`, and `VRInput.cpp`.
- Reusable pattern extraction:
  VR operator station with mode gate, dashboard, and camera feedback.
- Reusable core:
  initialize VR/runtime/renderer/ROS together, expose Standby/Control/
  Calibration modes, map OpenVR actions into operator commands, show camera
  imagery as a VR surface, keep ImGui status controls visible, and publish
  robot transform/joint/base commands at a controlled cadence.
- Do not copy directly:
  hardcoded absolute paths, old ROS/OpenVR assumptions, or robot-specific
  geometry.
- Caveats:
  strong product/architecture reference with high portability work.

## `zz0320/vr_teleoperation_ros`

- Interesting idea:
  receive Unity/VR pose JSON over WebSocket, buffer it into ROS messages at a
  fixed rate, split arm/torso/base modes, smooth poses, publish RelaxedIK/robot
  commands, forward camera frames over UDP, and play audio feedback on data
  collection state.
- Code donor value:
  high for fixed-rate command buffering, mode separation, pose smoothing,
  gripper soft clamp, long-press service triggers, UDP JPEG chunking, and
  RelaxedIK integration.
- Product reference value:
  high for remote operator panels, robotics labs, and data-collection workflows
  that need explicit operator feedback.
- What to inspect next:
  separate robot-specific message types from reusable command/mode/state
  architecture.
- Source evidence:
  `src/vr_client_node/vr_data_receiver.py`,
  `src/vr_client_node/vr_ros_adapter.py`,
  `src/vr_client_node/robot_cmd_publisher.py`,
  `src/vr_client_node/camera_sender.py`,
  `src/ik_node/relaxed_ik_rust.py`, and config files.
- Reusable pattern extraction:
  WebSocket-to-ROS fixed-rate operator command buffer.
- Reusable core:
  accept VR packets over WebSocket, store latest operator state, publish at a
  fixed ROS timer rate, map modes to arm/torso/base command families, smooth
  position/quaternion deltas, debounce toggles, gate data collection by
  long-press service calls, and provide audio/status feedback.
- Do not copy directly:
  hardcoded robot paths, generated cache, binary `librelaxed_ik_lib.so`, or
  robot-specific messages.
- Caveats:
  strong pattern donor but needs extraction into clean transport/schema layers.

## `Mcen25/VR-Teleoperation-Robotics-Platform`

- Interesting idea:
  use Unity/XRI with ROS# and HTTP camera feeds to put robot camera streams and
  network diagnostics into a world-space VR panel.
- Code donor value:
  medium for ROS camera display grids, ROS# topic subscription, compressed/raw
  image handling, HTTP video-feed fallback, SSH/network diagnostics, and Unity
  insecure-HTTP editor setup.
- Product reference value:
  medium for operator camera walls and robot connectivity check panels.
- What to inspect next:
  find whether a later commit adds true robot command output beyond camera
  display.
- Source evidence:
  `Assets/Scripts/ROSCameraManager.cs`,
  `Assets/Scripts/ROSCameraSubscriber.cs`,
  `Assets/Scripts/EnableCamerasViews.cs`,
  `Assets/Scripts/NetworkConnectionTest.cs`,
  `Assets/Scripts/SSH.cs`, and `Packages/manifest.json`.
- Reusable pattern extraction:
  ROS camera wall in a Unity XR scene.
- Reusable core:
  configure ROS bridge endpoints, create world-space camera panels, subscribe
  to compressed image topics before raw fallback, update textures/FPS labels,
  and add explicit network tests for HTTP support, robot reachability, and
  camera endpoint availability.
- Do not copy directly:
  hardcoded IP addresses, plaintext SSH relaxations, or generated template
  content.
- Caveats:
  thin teleoperation donor; more camera/diagnostic shell than control system.

## `lingxiaomeng/VR_teleoperation_ros`

- Interesting idea:
  none captured in this wave because the synchronized source was empty.
- Code donor value:
  none for this pass.
- Product reference value:
  none for this pass.
- What to inspect next:
  only revisit if the upstream repository gains source content.
- Caveats:
  excluded from registry/family studied entries to avoid false coverage.

## Cross-Project Lessons

- VR teleoperation is a pipeline: tracked input, coordinate conversion,
  command buffering, safety gate, robot-specific actuation, operator feedback,
  and camera/diagnostic surfaces.
- Fixed-rate publishing is useful even when input arrives asynchronously; it
  makes stale-data, smoothing, and mode behavior easier to reason about.
- Safety should not be only a UI checkbox. Stronger donors combine enable
  services, mode gates, thresholds, stale-data handling, and visible feedback.

## Methods Added Or Reinforced

- Safety-gated VR pose to robot IK bridge.
- Normalized XR controller/tracker publisher for ROS.
- VR operator station with dashboard and camera feedback.
- WebSocket-to-ROS fixed-rate operator command buffer.
- ROS camera wall in a Unity XR scene.

## Follow-Up Gaps

- Create a VR teleoperation bridge matrix across ROS-TCP, ROS#, rosbridge,
  WebSocket, UDP camera feeds, and native OpenVR operator shells.
- Extract a generic `operator mode and safety gate` checklist for future
  remote-control VR tools.
- Keep robotics-specific work as research unless a future prototype explicitly
  targets robot operation.
