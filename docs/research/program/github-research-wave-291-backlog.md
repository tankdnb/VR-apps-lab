# GitHub Research Wave 291 Backlog - Mixed Reality Robotics, ROS/Unity, URDF/CAD, and Digital Twin Control Surfaces

## Executed Scope

- Searched and deduplicated mixed-reality robotics, ROS/Unity bridge,
  URDF/CAD, digital-twin control, and trajectory-teaching projects.
- Froze an eight-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted IK baselines, ROS joint subscribers, URDF/Xacro editor import,
  CAD shapes/states data model, MQTT command publishing, MRTK trajectory
  capture, server-authoritative robot architecture, SSE live-state helper,
  Dobot TCP driver ports, feedback parsing, and acceleration-limited setpoint
  streaming.

## Studied Projects

- `2000222/Robotic-Arm-IK-in-Unity`
- `sabeaussan/ROS_Unity`
- `KosmosisDire/UrdfUnityToolkit`
- `bernhard-42/three-cad-viewer`
- `KKallas/manual-override`
- `mortenterhart/mixed-reality-robot-control`
- `MixedRealityETHZ/Mixed-Reality-Robotic-Grasp-Teacher`
- `giuliano-97/mixed_reality_robots`

## Backlog Findings

- Build a robotics utility matrix across URDF/CAD import, ROS bridge, MQTT,
  SSE/WebSocket, IK, trajectory teaching, calibration, and safety policy.
- Deepen `UrdfUnityToolkit`, `manual-override`, and `three-cad-viewer` as the
  strongest reusable architecture donors.
- Compare Wave 291 with earlier teleoperation waves so robot-control patterns
  do not fragment across multiple family names.
- Consider a future reuse plan for a safe MR robot-control shell: imported
  robot model, live joint state, operator dashboard, command queue, and E-stop.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an MR robotics/digital-twin control method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
