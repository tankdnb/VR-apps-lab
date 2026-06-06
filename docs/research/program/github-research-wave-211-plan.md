# GitHub Research Wave 211 Plan

Date: 2026-06-06

Theme: VR teleoperation control frontends, robot bridges, safety gates, feedback HUDs, and WebXR/headset control loops.

Research mode: static source reading only. No external repository was run, built, installed, or launched.

## Why This Wave Exists

Teleoperation projects are not the center of `VR-apps-lab`, but they are unusually strong donors for VR utility architecture: mode switching, bidirectional telemetry, video surfaces, controller/hand tracking, robot command sidecars, safety gates, watchdogs, and operator HUDs.

Wave 211 deepens four teleop projects to extract control-surface and safety-loop patterns reusable beyond robotics.

## Search Families

- VR robot teleoperation frontends.
- WebXR headset control UIs.
- ROS/ROS2/UDP/WebSocket robot bridges.
- Stereo/video HUDs and command feedback.
- Safety gates, convergence checks, watchdogs, pause/home/calibration flows.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `h2r/GHOST` | Unity/Quest robot teleoperation with mode manager, controller input, point cloud/depth subscriptions, and robot joint publishing. | Unity ROS teleop frontend |
| `nakama-lab/VR_Teleop_Interface` | Multi-branch ROS2/Unity/ZED teleop architecture with command/status/error sequence docs. | Teleop architecture documentation |
| `kscalelabs/kbot_vr_teleop` | WebXR frontend plus Python IK and UDP robot command boundary, with tracking throttles and convergence checks. | WebXR robot command bridge |
| `open-thought/cambot` | WebXR stereo camera teleop with HUD, WebSocket/WebRTC transport, calibration, smoothing, watchdog, workspace bounds, and pause/home safety flows. | WebXR teleop safety stack |

## Dedupe Notes

The projects overlap with existing teleop and robotics entries, but previous registry notes did not fully extract the shared pattern: headset control surface plus command sidecar plus safety feedback loop.

## Code-Level Pass Targets

- VR/WebXR control frontend shape.
- Controller/hand/head tracking payloads.
- Robot command transport and schema.
- IK/convergence/safety gating.
- Video/HUD/telemetry feedback.
- Pause, home, calibration, watchdog, stale-data, and jump-prevention flows.

## Expected Outputs

- Wave 211 landscape synthesis.
- Registry/family deepening notes.
- Method catalog entry for WebXR/VR teleoperation control surface with safety gates and feedback loop.
- Follow-up backlog for adapting teleop safety patterns to non-robot VR utilities.
