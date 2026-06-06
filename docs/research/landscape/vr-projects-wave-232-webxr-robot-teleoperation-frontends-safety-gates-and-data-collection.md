# VR Projects Wave 232: WebXR Robot Teleoperation Frontends, Safety Gates, and Data Collection

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies WebXR and Quest robot-operation surfaces: headset/controller
pose streams, robot adapters, safety gates, telemetry channels, operator HUDs,
validation modes, and recording flows.

## Why It Matters For `VR-apps-lab`

Teleoperation projects are unusually rich donors because they force the
architecture to name safety, stale data, command schemas, feedback, and
operator state. Even if `VR-apps-lab` does not build a robot tool, these
patterns translate directly to risky VR utility actions, overlay controls,
external-device bridges, and diagnostics.

## Project Notes

### `SpesRobotics/teleop`

- Interesting idea:
  a very small WebXR frontend can become a reusable robot command source if it
  exposes a callback contract, motion gate, scale control, and transform
  limiter.
- Code donor value:
  `teleop/__init__.py` exposes FastAPI/WebSocket `/ws`, receives JSON pose
  packets, converts RUB to FLU, starts relative pose only while movement is
  enabled, applies scale, and protects against pose jumps. `teleop-ui.js`
  provides a shadow-DOM UI with hold-to-move, gripper state, scale presets,
  stats, server diagnostics, and reserved buttons.
- Product reference value:
  strong micro-utility reference for a "headset as safe pose source" bridge.
- What to inspect next:
  compare its `Teleop.subscribe(callback)` shape and transform limiter against
  more complete robot adapters.
- Architecture pattern:
  WebXR pose source plus server-side transform and safety boundary.
- Caveats:
  compact by design, not a full robot control product, and safety depends on
  the downstream controller.

### `ajhai/teleop-xr`

- Interesting idea:
  robot teleoperation benefits from a typed transport that carries commands,
  status, joint state, images, errors, connection state, and heartbeat as one
  schema.
- Code donor value:
  `common/transport.proto` defines action types and payloads. The server uses
  FastAPI WebSocket manager, lazy robot instances, robot config registry,
  monitoring loops, joint group mapping, and binary protobuf messages. The
  frontend manages reconnect, 200 ms heartbeat, camera image blob URLs, and
  in-scene camera planes.
- Product reference value:
  good reference for robot adapter boundaries and mixed command/status/camera
  dashboards.
- What to inspect next:
  compare the protobuf schema against WebRTC and JSON payloads from other
  teleop surfaces.
- Architecture pattern:
  robot adapter manager plus typed binary control/status/media channel.
- Caveats:
  broader app complexity, robot-specific adapters, and server security need
  production review.

### `fracapuano/maniskill-quest-teleop`

- Interesting idea:
  Quest telemetry can be separated from video/control paths with feature gates,
  backpressure limits, stale-hand handling, and debug capture.
- Code donor value:
  `web/app.js` creates unordered telemetry and ordered control data channels,
  samples hands/controllers/views/head at different rates, enforces buffered
  amount limits, and supports telemetry-only mode. `bridge/server.py` and
  `bridge/state.py` expose session config, offer handling, debug capture,
  thread-safe telemetry copies, stale hand retention, and control events.
- Product reference value:
  strong donor for Quest telemetry bridges, dataset collection, and debugging
  surfaces.
- What to inspect next:
  compare telemetry-only versus video mode and data-channel cadence against
  other WebRTC XR tools.
- Architecture pattern:
  WebRTC telemetry/control bridge with rate partitioning and stale-source
  policy.
- Caveats:
  research/simulation orientation, aiortc/server complexity, and debug capture
  privacy concerns.

### `almond-bot/axol-vr`

- Interesting idea:
  headset HUD state should be explicit: teleop, data collection, pending
  recording, recording, saving, and error are different operator states.
- Code donor value:
  `AxolVRClient.tsx` reads controller poses, grip values, body-tracked elbows,
  button edges, lock flags, reset, state, and sequence each frame. It sends a
  stable JSON payload and handles A/B/X/Y mode transitions. The app uses R3F/XR
  state, body tracking, axis markers, HUD panels, and a countdown before
  recording.
- Product reference value:
  strong operator-HUD and data-collection UX reference.
- What to inspect next:
  compare its `AxolPoseData` shape against Quest/Fairino, cambot, and kbot
  payloads.
- Architecture pattern:
  headset-side operator state machine plus pose/data-collection stream.
- Caveats:
  project-specific robot workflow and body tracking support assumptions.

### `vivek-kanjarla/Quest3-Fairino`

- Interesting idea:
  physical robot control should be staged through transport, stale detection,
  deadman control, delta mapping, simulation validation, and diagnostics.
- Code donor value:
  `quest3.py` supports Vuer, Oculus Reader/ADB, and UDP modes with stale
  invalidation. `mapper_vr.py` maps Quest deltas to FR5 targets, clamps
  position/rotation, reuses IK seed, checks joint limits, and rate-limits
  joints. `sim_bridge.py` separates sim-only, sim-then-execute, and live-only
  modes. `diag_controller.py` reports controller tracking and input state.
- Product reference value:
  strongest safety/process reference in this wave.
- What to inspect next:
  extract a device-neutral safety checklist from stale gates, deadman,
  sim/validate/execute, and episode recording.
- Architecture pattern:
  safety-first robot control pipeline with staged execution and diagnostics.
- Caveats:
  robot-specific SDK and hardware, local certificate/network assumptions, and
  physical actuation risk.

## Reusable Pattern Extraction

- Pattern candidate:
  XR teleoperation command bridge with safety-gated input.
- Problem solved:
  external devices need headset/controller data, but raw pose streams are too
  risky without validity, mode, feedback, and validation boundaries.
- Reusable core:
  separate XR input source, transport, robot/device adapter, safety gates,
  stale-data policy, transform mapping, feedback/HUD, validation/simulation,
  recording, and debug capture.
- Source evidence:
  `SpesRobotics/teleop`, `ajhai/teleop-xr`,
  `fracapuano/maniskill-quest-teleop`, `almond-bot/axol-vr`, and
  `vivek-kanjarla/Quest3-Fairino`.
- Abstraction boundary:
  headset payload schema should not contain hardware actuation logic; robot or
  device-specific control should live behind an adapter and validation layer.
- What not to copy:
  hardcoded hardware addresses, certificates, robot SDK commands, no-auth
  control servers, direct physical actuation, or ADB/network assumptions.
- Method catalog action:
  add a method entry for XR teleoperation command bridges with safety gates.

## Follow-Up Gaps

- Build a teleoperation safety matrix across WebXR/Quest projects.
- Compare transport choices: JSON/WebSocket, protobuf, WebRTC, UDP, ADB, and
  Python scene bridges.
- Extract a normalized operator payload schema for pose, grips, locks, state,
  reset, sequence, stale validity, and recording mode.
