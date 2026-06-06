# VR Projects Wave 203: ContactGlove, Haritora, and Vendor Tracker Bridge Sidecars

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 203 studies vendor-specific glove and tracker bridges that translate
ContactGlove or Haritora data into generic VR runtime inputs, avatar setup
packages, keyboard events, SlimeVR packets, VMC/OSC streams, and camera/IMU
fusion sidecars. The reusable value is the boundary between vendor protocols
and generic VR utility contracts.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `hyblocker/freescuba` | ContactGlove OpenVR driver plus overlay | Strong driver/overlay donor |
| `Diver-X/ContactGloveOSC` | Official VRChat avatar setup package | Avatar setup reference |
| `1000100Den/Glove2Kb` | VMC/OSC hand-pose to keyboard utility | Input micro-bridge reference |
| `sim1222/haritorax-slimevr-bridge` | Haritora BLE to SlimeVR UDP bridge | Strong protocol bridge donor |
| `JovannMC/haritorax-interpreter` | Haritora COM/Bluetooth interpreter library | Protocol interpreter donor |
| `JovannMC/haritora-gx-poc` | Haritora GX serial data probe | Thin protocol probe |
| `cytsai1008/HaritoraToSlime` | OSC Haritora to SlimeVR bridge | SlimeVR packet reference |
| `Fuwaaaaaa/osc_haritorax2_camera_tracking` | Camera/IMU fusion tracking middleware | Strong runtime sidecar donor |

## `hyblocker/freescuba`

- Interesting idea:
  a ContactGlove integration split across an OpenVR driver, an overlay app, a
  serial protocol layer, named-pipe IPC, input profiles, skeleton components,
  haptics stubs, and tracker pose offsets.
- Code donor value:
  very high for driver/overlay split, OpenVR controller props, input component
  creation, skeleton updates, pose and input worker threads, named-pipe
  protocol, serial discovery, COBS/CRC packet handling, and calibration structs.
- Product reference value:
  very high for vendor hardware to SteamVR controller integration.
- What to inspect next:
  installation/update safety, SteamVR driver compatibility, pose offset UI,
  calibration flow, haptics implementation, shadow tracker selection, and
  security of local IPC.
- Source evidence:
  `src/openvr_driver/contactglove_device.cpp`,
  `src/openvr_driver/device_provider.cpp`, `src/openvr_driver/ipc_server.cpp`,
  `src/openvr_overlay/ipc_client.cpp`,
  `src/openvr_overlay/contact_glove/serial_communication.cpp`,
  `src/openvr_overlay/contact_glove/calibration.cpp`, and
  `src/ipc_protocol.hpp`.
- Reusable pattern extraction:
  vendor glove runtime bridge with driver/overlay/serial/IPC split.
- Reusable core:
  keep runtime device presentation in the driver, keep user configuration and
  serial hardware access in a companion overlay, exchange normalized glove
  state through a local IPC protocol, feed SteamVR input/skeleton components at
  a stable cadence, and isolate calibration data from raw packet parsing.
- Do not copy directly:
  driver installation, Index controller impersonation, hook/injection code,
  physical haptics, or hardware-specific VID/PID assumptions.
- Caveats:
  strongest driver-side donor, but high-risk and platform-specific.

## `Diver-X/ContactGloveOSC`

- Interesting idea:
  an official Unity package prepares VRChat avatars for ContactGlove OSC by
  adding parameters, prefabs, expression menus, smooth animator assets, and
  optional hand-sign animation copy flows.
- Code donor value:
  high for avatar setup window, localized UI, VRCAvatarDescriptor handling,
  parameter rename/copy tools, automatic prefab insertion, revert flow, and VPM
  package shape.
- Product reference value:
  high for vendor avatar integration UX.
- What to inspect next:
  generated parameter contract, controller merge safety, undo/revert coverage,
  VPM dependency/versioning, and animation/controller conflict detection.
- Source evidence:
  `Packages/jp.diver-x.contactgloveosc/Editor/AutomaticSetup.cs`,
  `ParameterRenameTool.cs`, `HandSignCopyTool.cs`, runtime prefabs, expression
  menu assets, and `package.json`.
- Reusable pattern extraction:
  vendor avatar setup package with automatic parameter/controller installation.
- Reusable core:
  expose one setup window, select an avatar descriptor, choose full/lite
  parameter budgets, copy or rename parameters, insert prefabs/assets, provide a
  revert action, and keep package metadata consumable by creator package tools.
- Do not copy directly:
  vendor parameter names, generated animator assets, or automatic controller
  mutations without conflict previews.
- Caveats:
  strong setup/reference donor rather than runtime bridge donor.

## `1000100Den/Glove2Kb`

- Interesting idea:
  a Unity utility receives VMC/OSC hand bone rotations, applies origin/deadzone
  correction, detects grip and crossing gestures, moves a pointer, and maps
  hand/finger states to keyboard-like input.
- Code donor value:
  medium for VMC hand-pose ingestion, origin correction timers, grip gating,
  pointer movement, and gesture-to-input mapping.
- Product reference value:
  medium for glove-to-keyboard accessibility/control ideas.
- What to inspect next:
  keyboard event backend, safety/consent for OS input, parameter tuning, left
  hand/right hand gesture conflicts, and modern OSC/VMC parsing.
- Source evidence:
  `src/Glove2Kb_v0.2.1.cs`.
- Reusable pattern extraction:
  hand pose to local input micro-bridge.
- Reusable core:
  receive bone rotations, normalize with deadzone/origin correction, gate input
  behind a deliberate grip state, move a visible pointer, and map only explicit
  gestures to local input.
- Do not copy directly:
  OS input without allowlists, hardcoded gesture thresholds, or unclear
  keyboard injection behavior.
- Caveats:
  source encoding appears garbled in the terminal, but code structure is clear.

## `sim1222/haritorax-slimevr-bridge`

- Interesting idea:
  a Rust bridge scans Haritora trackers over BLE, decodes sensor/battery/button
  notifications, performs a SlimeVR UDP handshake, and forwards rotation,
  gravity, battery, and magnetometer status.
- Code donor value:
  very high for BLE characteristic mapping, tracker discovery, async worker
  loop, IMU decode, SlimeVR packet encoding, packet counters, broadcast
  handshake, and battery forwarding.
- Product reference value:
  high for clean vendor-to-SlimeVR bridge architecture.
- What to inspect next:
  multi-tracker identity and roles, reconnection, calibration, mac/privacy
  handling, SlimeVR protocol version drift, and settings UI.
- Source evidence:
  `src/main.rs`, `src/haritora.rs`, `src/slimevr.rs`, and math helpers.
- Reusable pattern extraction:
  vendor BLE tracker to generic SlimeVR UDP bridge.
- Reusable core:
  discover vendor peripherals, subscribe to sensor/battery/button
  characteristics, decode raw IMU packets into normalized rotation/gravity,
  handshake with the generic receiver, and publish packets at the protocol
  boundary rather than leaking vendor-specific fields downstream.
- Do not copy directly:
  unwrap-heavy error handling, random port assumptions, role ambiguity, or no
  reconnect/backoff policy.
- Caveats:
  strongest compact Haritora bridge donor.

## `JovannMC/haritorax-interpreter`

- Interesting idea:
  a TypeScript library exposes HaritoraX COM, Bluetooth, and Linux Bluetooth
  connection modes through an EventEmitter API with typed events for IMU,
  tracker data, magnetometer status, buttons, battery, info, connect, and
  disconnect.
- Code donor value:
  high for protocol interpreter layering, tracker maps, settings maps,
  connection mode abstraction, public event API, and documentation of tracker
  data shapes.
- Product reference value:
  high for a reusable library boundary instead of one-off bridges.
- What to inspect next:
  full packet decode paths, write/settings support, TypeScript type coverage,
  reconnect behavior, and cross-platform Bluetooth support.
- Source evidence:
  `src/HaritoraX.ts`, `src/index.ts`, `src/mode/com.ts`,
  `src/mode/bluetooth.ts`, `src/mode/bluetooth-linux.ts`, and `src/types.ts`.
- Reusable pattern extraction:
  vendor tracker interpreter library with event API.
- Reusable core:
  hide transport differences behind one class, emit typed events for each data
  domain, keep tracker identity maps centralized, expose settings writes as
  explicit methods, and let downstream bridges decide whether to output OSC,
  SlimeVR, logs, or UI.
- Do not copy directly:
  incomplete or experimental protocol assumptions without device tests.
- Caveats:
  good library-shape donor; maturity should be verified before depending on it.

## `JovannMC/haritora-gx-poc`

- Interesting idea:
  a Python proof-of-concept receives echoed serial data, labels packet families,
  decodes IMU rotation/gravity, and logs battery/button/other tracker data.
- Code donor value:
  low-to-medium as a protocol probe and raw-data logging reference.
- Product reference value:
  low, except as a first-step reverse-engineering workflow.
- What to inspect next:
  real serial transport, parser robustness, packet captures, GX settings
  fields, and separation from manual RealTerm echo workflow.
- Source evidence:
  `script.py`.
- Reusable pattern extraction:
  protocol capture/probe harness.
- Reusable core:
  accept raw captured device lines, classify labels, decode known packet types,
  log unknowns, and keep parser functions small enough to compare against
  mature bridge implementations.
- Do not copy directly:
  manual echo workflow, global button counters, or unbounded TCP server loop.
- Caveats:
  retained as thin protocol clue, not mature bridge.

## `cytsai1008/HaritoraToSlime`

- Interesting idea:
  a Python bridge receives Haritora tracking over OSC, converts Euler values to
  quaternions, performs SlimeVR UDP discovery/handshake, sends add-IMU packets,
  and forwards rotation/accel packets for multiple trackers.
- Code donor value:
  medium-to-high for SlimeVR packet encoding, add-IMU workaround, OSC handler
  shape, and config bootstrap.
- Product reference value:
  medium for pragmatic bridge flow.
- What to inspect next:
  OSC address parsing bug risk, quaternion axis mapping, packet timing, config
  validation, reconnect, and acceleration correctness.
- Source evidence:
  `main.py` and `reference.txt`.
- Reusable pattern extraction:
  OSC tracker stream to SlimeVR packet bridge.
- Reusable core:
  receive tracker-addressed OSC events, keep per-tracker state, convert
  rotations to the target protocol's quaternion order, perform discovery and
  handshake, register multiple IMUs, throttle sends, and maintain packet
  counters.
- Do not copy directly:
  broad exception swallowing, unfinished acceleration, or string-parsing bugs.
- Caveats:
  useful packet reference; less mature than the Rust bridge.

## `Fuwaaaaaa/osc_haritorax2_camera_tracking`

- Interesting idea:
  a full tracking middleware fuses Haritora/SlimeVR-style IMU input with
  camera tracking, exposes dashboard/REST/OBS/notifications/recording outputs,
  performs preflight checks, and has a broad test suite around calibration,
  receivers, fusion, persistence, and diagnostics.
- Code donor value:
  very high for subsystem lifecycle, receiver abstraction, event bus, fusion
  engine, state machine, shared-memory camera subprocess, pose predictor,
  preflight checks, config validation, calibration persistence, REST/dashboard,
  VMC sender, OBS overlay, recorder, and test coverage.
- Product reference value:
  very high for "tracking helper as diagnosable runtime sidecar".
- What to inspect next:
  runtime UX, installation, sensor role mapping, camera calibration wizard,
  data privacy, Japanese/i18n polish, and actual latency under load.
- Source evidence:
  `src/osc_tracking/main.py`, `fusion_engine.py`, `camera_tracker.py`,
  `config.py`, `preflight.py`, receiver/sender modules, persistence modules,
  tools, docs, and tests.
- Reusable pattern extraction:
  tracking fusion sidecar with diagnostics and preflight gates.
- Reusable core:
  select receiver backends by config, run camera tracking in a separate process
  with shared memory, fuse camera positions and IMU rotations through a state
  machine, publish frame events to optional outputs, gate startup with
  actionable preflight checks, expose diagnostics through dashboard/API/OBS, and
  keep tests around protocol and calibration boundaries.
- Do not copy directly:
  app-specific UI/assets, unreviewed generated docs, or camera model defaults
  without calibration UX.
- Caveats:
  strongest mature sidecar donor in the wave.

## Cross-Project Lessons

- Vendor device utilities become reusable when they translate into generic
  contracts: SteamVR input/skeleton, VRChat avatar parameters, SlimeVR UDP,
  VMC/OSC, keyboard events, or a receiver protocol.
- Driver integration and companion overlays should be split; the driver should
  present normalized runtime state while the companion owns hardware discovery,
  calibration, and user-facing controls.
- SlimeVR packet compatibility is an important bridge target, but it requires
  handshake, packet counters, role identity, and multi-IMU registration details.
- Mature tracking sidecars need diagnostics: preflight checks, state-machine
  modes, confidence/quality signals, dashboard/API/notifications, and tests.
- Thin protocol probes are valuable only when marked as probes, not promoted to
  product references.

## Reuse Recommendations

1. Use `freescuba` as the strongest ContactGlove driver/overlay architecture
   donor, with high-risk caveats.
2. Use `ContactGloveOSC` as the avatar setup/package UX reference.
3. Use `haritorax-slimevr-bridge` as the strongest compact Haritora-to-SlimeVR
   protocol donor.
4. Use `haritorax-interpreter` for the reusable library/event API boundary.
5. Use `osc_haritorax2_camera_tracking` as the mature diagnostics/fusion
   sidecar donor.
6. Keep `haritora-gx-poc`, `HaritoraToSlime`, and `Glove2Kb` as comparison
   nodes for protocol probing and micro-bridge patterns.

## Follow-Up Gaps

- Build a ContactGlove/Haritora matrix across transport, runtime output,
  calibration, diagnostics, maturity, and safety.
- Compare driver-level, OSC/avatar-level, SlimeVR-level, and VMC-level bridge
  outputs for future tracker helper prototypes.
- Extract a minimum diagnostic checklist for tracking bridges: connection
  state, battery, role mapping, stale data, calibration, mode, and packet loss.
- Decide whether a `VR-apps-lab` spike should target a generic receiver
  protocol first instead of one vendor device.
