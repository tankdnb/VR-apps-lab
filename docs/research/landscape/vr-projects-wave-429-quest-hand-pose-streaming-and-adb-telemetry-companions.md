# VR Projects Wave 429: Quest Hand/Pose Streaming and ADB Telemetry Companions

Date: 2026-07-13

Theme: Quest-side or Quest-adjacent companions that expose hand/controller pose,
button state, host discovery, install flow, and runtime status to desktop tools.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `MOVIN3D/MOVIN-MetaQuest-APK` | Quest hand-streaming setup companion | Product/setup pass; APK-only |
| `rail-berkeley/oculus_reader` | Quest pose/button telemetry bridge | Code-level pass |

## Cross-Project Synthesis

Both projects treat the Quest headset as a telemetry source for a desktop-side
workflow. `MOVIN-MetaQuest-APK` is valuable for its product flow: developer-mode
install, local-network permissions, same-Wi-Fi host discovery, manual IP fallback,
controller-only setup, and explicit hand-tracking connection status.
`oculus_reader` is valuable for implementation structure: a Python sidecar starts
an APK through ADB, reads structured transform/button lines from logcat, and
supports USB or network transport.

The reusable lesson is a `Quest telemetry companion`: separate setup controls from
captured hand motion, show permission/connectivity state plainly, and label the
transport as a development bridge when it depends on ADB/logcat.

## Project Notes

### `MOVIN3D/MOVIN-MetaQuest-APK`

- Interesting idea: a Quest companion app that streams hand tracking data to a
  desktop mocap tool while keeping the in-headset setup UI controller-only.
- Code donor value: low as a source donor because the repository contains an APK
  and setup documentation, not inspectable app source.
- Product reference value: high for permission, discovery, reconnect, and status
  UX around a Quest-side companion.
- Architecture pattern: headset APK plus desktop host discovery over local Wi-Fi.
- Reusable method: `Quest-side hand-streaming companion setup flow`.
- UX/product lesson: avoid using hand tracking as UI input while the user's hands
  are the captured subject; use controllers for setup and reserve hands for data.
- Caveats: APK-only repository, unknown streaming protocol internals, and limited
  donor value without source.
- Source evidence: README documents ADB install, developer mode, unknown sources,
  Hand Tracking and Local Network permissions, up to five scanned PC hosts, manual
  IP fallback, reconnect states, and left/right hand tracking indicators.
- Reusable core: permission checklist, host discovery/manual fallback, connection
  state display, controller-only setup during hand capture.
- What not to copy: binary APK as a code donor or any undocumented private
  streaming protocol.
- Method catalog action: create/update Quest telemetry companion method.
- What to inspect next: find source-available Quest hand-streaming companions for
  protocol, privacy, and latency comparisons.

### `rail-berkeley/oculus_reader`

- Interesting idea: a Python bridge that reads Quest headset/controller transforms
  and buttons from a companion APK through ADB/logcat.
- Code donor value: simple transport bootstrap, APK auto-install/start, USB or
  TCP ADB modes, log parser, transform/button state cache, and optional ROS path.
- Product reference value: useful as a small "pose reader sidecar" pattern for
  robotics, calibration, or tracker-bridge experiments.
- Architecture pattern: Quest APK emits tagged records; Python desktop process
  starts the app, tails logcat, parses packets, and exposes latest transforms.
- Reusable method: `ADB/logcat pose telemetry bridge`.
- UX/product lesson: development bridges need explicit start/stop commands and a
  clear transport mode so users understand whether USB or Wi-Fi is active.
- Caveats: active Quest 3 support moved to a fork, logcat is not a robust
  production transport, and schema versioning is weak.
- Source evidence: `oculus_reader/reader.py` uses `ppadb`, installs/starts the APK,
  reads logcat tag `wE9ryARX`, parses transform/button segments, and supports
  `adb tcpip`/remote connect.
- Reusable core: APK bootstrap, transport selection, tagged packet parser,
  thread-safe latest pose/button state, explicit stop command.
- What not to copy: production dependence on ad-hoc logcat lines without schema
  version, reconnection policy, and privacy framing.
- Method catalog action: create/update Quest telemetry companion method.
- What to inspect next: compare with WebSocket, OSC, BLE, and native OpenXR
  sidecar transports for latency and reliability.

## Reusable Pattern Extraction

- Pattern candidate: `Quest telemetry companion bridge`.
- Problem solved: desktop tools often need headset/controller/hand pose without
  becoming a full Quest app or VR runtime themselves.
- Reusable core: headset-side app, install/bootstrap path, permission/status UX,
  transport mode, host discovery/manual target, packet schema, parser, latest
  state cache, and stop/reconnect controls.
- Source evidence: `MOVIN-MetaQuest-APK` documents the user-facing setup and
  connection model; `oculus_reader` exposes the desktop-side ADB/logcat parser.
- Abstraction boundary: protocol/schema and connection state are reusable; binary
  APKs and ad-hoc logcat transport should be treated as prototypes.
- Method catalog action: add a Quest hand/pose streaming companion method.

## Follow-Up Gaps

- Study source-available Quest hand-streaming apps with WebSocket or OSC transport.
- Compare ADB/logcat telemetry with OpenXR-native capture, browser WebXR capture,
  and desktop VR runtime bridges.
- Define minimum privacy and consent language for hand/controller telemetry tools.
