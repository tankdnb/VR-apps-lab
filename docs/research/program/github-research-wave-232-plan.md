# GitHub Research Wave 232 Plan

Date: 2026-06-06

Theme: WebXR robot teleoperation frontends, safety gates, and data
collection.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Earlier teleoperation waves covered ROS, Unity, and robot-specific VR shells.
This wave narrows the lens to browser/headset frontends that turn Quest,
WebXR, WebRTC, WebSocket, or phone/headset pose streams into robot control,
recording, and validation flows.

## Search Families

- WebXR robot teleoperation surfaces.
- Quest controller, hand, body, and head telemetry bridges.
- Robot command/status/camera transports.
- Safety-gated physical robot control.
- Data collection and episode recording frontends.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `SpesRobotics/teleop` | Compact WebXR pose-to-Python callback bridge with motion gate, scaling, and transform limiting. | WebXR teleop safety bridge |
| `ajhai/teleop-xr` | FastAPI/protobuf robot adapter with camera/status/control channels. | Robot adapter and telemetry surface |
| `fracapuano/maniskill-quest-teleop` | Quest WebRTC telemetry bridge with hand/controller/head state and debug capture. | Quest telemetry and dataset bridge |
| `almond-bot/axol-vr` | R3F headset HUD for teleop, data collection, recording, and body-tracked elbow state. | Operator HUD and data collection |
| `vivek-kanjarla/Quest3-Fairino` | Quest3 to Fairino robot stack with deadman switch, stale gates, sim/validate/execute modes, and diagnostics. | Safety-first physical robot pipeline |

## Dedupe Notes

`vuer`, `GHOST`, `VR_Teleop_Interface`, `kbot_vr_teleop`, and `cambot` are
already tracked, so this wave focuses on not-yet-tracked WebXR/Quest control
frontends and adapter variants.

## Code-Level Pass Targets

- Motion-enable and deadman gates.
- Pose transform conversion, scaling, and jump protection.
- Robot adapter boundary and message schema.
- WebSocket, WebRTC, protobuf, and UDP transport tradeoffs.
- Camera/status/HUD feedback.
- Recording, validation, debug capture, and diagnostics.

## Expected Outputs

- Wave 232 landscape synthesis.
- Registry/family entries for WebXR robot control surfaces.
- Method catalog entry for XR teleoperation command bridges with safety gates.
- Follow-up backlog for safety/HUD/recording comparison.
