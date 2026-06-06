# GitHub Research Wave 232 Backlog

Date: 2026-06-06

Theme: WebXR robot teleoperation frontends, safety gates, and data
collection.

## Completed In This Wave

- Studied `SpesRobotics/teleop` as a compact WebXR pose bridge with
  FastAPI/WebSocket entry point, shadow-DOM control UI, hold-to-move gate,
  pose scaling, RUB-to-FLU transform conversion, relative pose reset, and
  transform jump/velocity limiting.
- Studied `ajhai/teleop-xr` as a protobuf-backed robot adapter surface with
  binary WebSocket messages, heartbeat, robot manager, joint/state/camera
  payloads, camera texture planes, reconnect behavior, and AR help overlays.
- Studied `fracapuano/maniskill-quest-teleop` as a Quest WebRTC telemetry
  bridge with unordered telemetry channel, ordered control channel, hand,
  controller, view, and head state, backpressure guards, stale-hand logic, and
  debug capture endpoints.
- Studied `almond-bot/axol-vr` as an R3F headset operator HUD and data
  collection surface with explicit teleop/recording/saving/error state, button
  edge handling, body-tracked elbow payloads, controller poses, grip values,
  lock flags, and countdown UX.
- Studied `vivek-kanjarla/Quest3-Fairino` as a safety-first Quest3 to Fairino
  control stack with transport modes, stale-data invalidation, deadman switch,
  delta Cartesian mapping, IK seed reuse, joint/rate limits, sim/validate/live
  modes, diagnostics, and episode recording.
- Added a reusable method entry for XR teleoperation command bridges with
  safety gates and validation layers.

## Follow-Up Queue

1. Compare WebXR, WebRTC, UDP, ADB, and protobuf transport choices across
   teleoperation projects.
2. Extract a normalized operator payload schema for head, hands, controllers,
   grippers, locks, mode, reset, sequence, and stale validity.
3. Build a safety-gate checklist covering deadman, stale timeout, jump
   protection, sim validation, rate limits, pause/home, and debug capture.
4. Compare headset HUD approaches across `axol-vr`, `Quest3-Fairino`, `cambot`,
   and `kbot_vr_teleop`.
5. Decide whether the strongest teleoperation donor deserves a reuse plan.

## Do Not Spend Time On Yet

- Do not run robot control examples or connect to hardware.
- Do not copy robot-specific SDK commands or LAN endpoints.
- Do not promote physical-control code without a safety and validation review.
