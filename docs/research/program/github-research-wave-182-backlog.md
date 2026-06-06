# GitHub Research Wave 182 Backlog

- Date: `2026-06-06`
- Theme: `ROS/robot teleoperation bridges and VR operator shells`
- Status: executed as static source-reading pass
- Build/run status: not run, not built, not installed, not launched

## Completed Intake

- Shortlisted ROS/Unity/OpenVR teleoperation and operator-shell projects.
- Deduplicated against prior teleoperation, tracker, and external data bridge
  families.
- Read source entry points without executing found projects.
- Integrated teleoperation bridge methods into canonical docs.

## Follow-Up Work

- Create a `VR teleoperation bridge matrix` comparing:
  Unity ROS-TCP, ROS#, rosbridge, WebSocket JSON, OpenVR native, and direct ROS
  node approaches.
- Compare safety gates:
  enable services, mode switching, distance thresholds, stale-pose handling,
  gripper toggles, and operator-ready checkboxes.
- Compare camera feedback paths:
  ROS compressed images, HTTP MJPEG/video feed, UDP JPEG chunking, OpenCV GL
  textures, and world-space camera grids.
- Keep robot-specific repos as pattern donors only unless a future prototype
  explicitly targets robotics.

## Reuse Candidates

- Pose-to-IK safety-gated command bridge from `vr_teleop`.
- Unity OpenXR tracker/controller publisher from `vr_ros2_bridge`.
- OpenVR operator dashboard and camera surface from `vr-teleoperation`.
- Fixed-rate WebSocket-to-ROS mode buffer from `zz0320/vr_teleoperation_ros`.
- ROS camera grid and diagnostics shell from
  `VR-Teleoperation-Robotics-Platform`.

## Caveats To Preserve

- Most repos are robot-specific and not direct VR utility code.
- Several projects use legacy ROS1, hardcoded paths/IPs, generated cache, or
  compiled binaries.
- Future prototypes should separate operator UI, transport, safety gates, and
  robot-specific actuation.
