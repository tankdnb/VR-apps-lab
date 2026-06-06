# GitHub Research Wave 182 Plan

- Date: `2026-06-06`
- Theme: `ROS/robot teleoperation bridges and VR operator shells`
- Scope: Unity-to-ROS pose bridges, ROS1/ROS2 controller/tracker publishers,
  OpenVR operator stations, WebSocket-to-ROS command buffers, ROS camera panels,
  TF-to-Unity bridges, and robot teleoperation control modes.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

VR operator tools are a strong source of reusable patterns: tracked pose
conversion, safety gates, command modes, camera panels, robot feedback, data
collection controls, and human-in-the-loop dashboards. This wave studies robot
teleoperation repos for bridge architecture, not for robot-specific reuse.

## Search Families

- Unity VR to ROS teleoperation
- ROS2 controller/tracker publishers
- OpenVR robot operator stations
- WebSocket-to-ROS command adapters
- TF and camera streams into Unity
- robot control modes and safety gates

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `UM-ARM-Lab/vr_teleop` | ROS1 teleop controller with MoveIt IK, gripper commands, and enabled/safety gates | ROS VR pose-to-IK bridge |
| `UM-ARM-Lab/vr_ros2_bridge` | Unity OpenXR controller/tracker publisher to ROS2 with HTC Vive tracker roles | ROS2 XR device publisher |
| `h2r/ros_reality_bridge` | Legacy TF/camera/rosbridge pipeline for Unity reality bridge | Legacy ROS-to-Unity scene bridge |
| `Intelligent-Robotics-Lab/vr-teleoperation` | C++ OpenVR operator station with ROS, ImGui, camera view, and calibrated transform mapping | OpenVR robot operator station |
| `zz0320/vr_teleoperation_ros` | WebSocket VR pose receiver, fixed-rate ROS publisher, modes, smoothing, IK, cameras, and audio feedback | WebSocket-to-ROS teleop bridge |
| `Mcen25/VR-Teleoperation-Robotics-Platform` | Unity XRI/ROS# camera shell and network diagnostics for robot views | Thin Unity ROS camera reference |
| `lingxiaomeng/VR_teleoperation_ros` | Empty clone during source sync; excluded from studied registry entries | Excluded empty source candidate |

## Dedupe Notes

- Earlier Wave 119 covered VR teleoperation broadly. This wave deepens ROS and
  operator-shell implementation details with new or previously thin repos.
- `lingxiaomeng/VR_teleoperation_ros` cloned as an empty repository and was not
  registered as a studied project.
- Robot-specific hardcoded paths, URDFs, compiled binaries, and generated cache
  files are treated as caveats, not reusable content.

## Code-Level Pass Targets

- tracked controller/HMD pose schemas and coordinate conversion;
- MoveIt/RelaxedIK pose-to-joint boundaries and safety gates;
- enabled services, mode toggles, command hold behavior, and gripper logic;
- WebSocket receive buffers and fixed-rate ROS publish loops;
- OpenVR action input abstraction and operator mode UI;
- ROS camera display grids, ROS# subscriptions, and network diagnostics;
- TF-to-Unity frame export and legacy rosbridge/camera compression.

## Expected Outputs

- Wave 182 landscape synthesis.
- Registry/family placement for ROS/robot teleoperation projects.
- Methods around VR-to-ROS command bridges, normalized XR device publishers,
  operator camera panels, safety gates, and fixed-rate command buffers.
