# GitHub Research Wave 291 Plan - Mixed Reality Robotics, ROS/Unity, URDF/CAD, and Digital Twin Control Surfaces

## Goal

Study mixed-reality robotics projects as reusable references for URDF/CAD
import, ROS-to-Unity joint state, IK targets, robot command surfaces,
MQTT/digital-twin control, trajectory teaching, and server-authoritative safety
boundaries.

## Research Questions

- How do projects bring robot descriptions, CAD trees, or URDF/Xacro assets
  into visual/digital-twin surfaces?
- How do ROS, MQTT, Socket/SSE, or direct TCP drivers move state and commands?
- Which parts are safe to reuse for visualization versus real robot control?
- Where should calibration, E-stop, speed limits, and command validation live?

## Shortlist

- `2000222/Robotic-Arm-IK-in-Unity`
- `sabeaussan/ROS_Unity`
- `KosmosisDire/UrdfUnityToolkit`
- `bernhard-42/three-cad-viewer`
- `KKallas/manual-override`
- `mortenterhart/mixed-reality-robot-control`
- `MixedRealityETHZ/Mixed-Reality-Robotic-Grasp-Teacher`
- `giuliano-97/mixed_reality_robots`

## Required Checks

- Deduplicate against prior teleoperation, robotics, CAD, tracking, and
  external-device control waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep safety, physical-output, planned-vs-implemented, vendor-heavy, and
  naive-IK caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 291.
- Registry/family entries for mixed-reality robotics and digital twin control.
- Method catalog entry for MR robotics/digital-twin boundaries.
- Follow-up gaps around URDF/CAD import, ROS/MQTT/SSE transport, calibration,
  and server-authoritative safety.
