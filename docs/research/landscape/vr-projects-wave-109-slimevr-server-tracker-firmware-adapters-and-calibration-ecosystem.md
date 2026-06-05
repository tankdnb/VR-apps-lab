# VR Projects Wave 109: SlimeVR Server, Tracker Firmware, Adapters, and Calibration Ecosystem

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `SlimeVR server`, `tracker firmware`, `Joy-Con`, `Mocopi`, `HaritoraX`, and
  `calibration ecosystem` patterns.

## Why this wave exists

SlimeVR is useful for `VR-apps-lab` because it is a complete tracking
ecosystem, not one narrow bridge. The reusable knowledge spans firmware packet
design, server orchestration, skeleton calibration, runtime bridges, OSC/VMC
outputs, WebSocket APIs, battery diagnostics, consumer-device adapters, BLE
normalization, and guided tracker setup UX.

This wave studies SlimeVR and adjacent adapters as a practical architecture
reference for future tracker helpers.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by SlimeVR server, firmware, Joy-Con, Mocopi, and HaritoraX
   families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `SlimeVR/SlimeVR-Server` | Central tracker hub with skeleton calibration, driver bridges, OSC/VMC/BVH outputs, GUI, and API surfaces |
| `SlimeVR/SlimeVR-Tracker-ESP` | Firmware-side tracker protocol with IMU, battery, calibration, feature flags, and diagnostics packets |
| `carl-anders/slimevr-wrangler` | Joy-Con-to-SlimeVR adapter with packet serialization, status UI, rotation/accel mapping, and reset action |
| `moslime/moslime` | Sony Mocopi BLE-to-SlimeVR bridge with autodiscovery, packet-drop checks, battery reporting, and reconnect loops |
| `OCSYT/SlimeTora` | HaritoraX-to-SlimeVR desktop shell with guided setup, model/dongle detection, tracker emulation, visualization, and button mappings |

## Deep-pass notes by project

## `SlimeVR/SlimeVR-Server`

- GitHub:
  [SlimeVR/SlimeVR-Server](https://github.com/SlimeVR/SlimeVR-Server)
- What it is:
  the main SlimeVR server and desktop GUI stack for receiving trackers,
  calibrating a skeleton, and sending tracking data to SteamVR, VRChat OSC,
  VMC, and recording/export paths.
- Interesting idea:
  a tracker helper should be a hub with multiple hardware inputs and multiple
  runtime outputs, with calibration and diagnostics sitting in the middle.
- Code-level notes:
  `server/desktop/src/main/java/dev/slimevr/desktop/Main.kt`
  creates the desktop entry point, checks ports, loads config, starts
  `VRServer`, configures HID, and provides driver bridges. On Windows it
  exposes named-pipe bridges such as `\\.\pipe\SlimeVRDriver`,
  `\\.\pipe\SlimeVRInput`, and `\\.\pipe\SlimeVRRpc`; on Linux it uses Unix
  socket bridge variants.
  The server tree contains OSC/VRC/VMC handlers, BVH recording/export code,
  RPC/data-feed protocol packages, and WebSocket API surfaces.
  `gui/src/hooks/websocket-api.ts`
  wraps a FlatBuffer WebSocket API with RPC, data feed, pubsub, reconnect, and
  timed-out state. `gui/src/components/vr-mode/VRModePage.tsx` shows a
  VR-friendly mode with tracker setup/checklist context.
- Code donor value:
  very high for tracker hub architecture, server/driver bridge split, and
  WebSocket-driven diagnostics UI.
- Product reference value:
  very high for guided full-body tracking setup, calibration, and device-state
  visibility.
- Caveats:
  it is a large ecosystem project; future reuse should isolate hub, bridge,
  and diagnostics patterns rather than clone the whole stack.
- What to inspect next:
  compare with virtual tracker hosts, OSC tracker bridges, and calibration
  tools already tracked in `VR-apps-lab`.

## `SlimeVR/SlimeVR-Tracker-ESP`

- GitHub:
  [SlimeVR/SlimeVR-Tracker-ESP](https://github.com/SlimeVR/SlimeVR-Tracker-ESP)
- What it is:
  ESP8266/ESP32 firmware for SlimeVR IMU trackers.
- Interesting idea:
  firmware should send more than pose: it should expose sensor identity,
  errors, calibration state, battery, temperature, signal quality, and feature
  flags so the host can explain tracker health.
- Code-level notes:
  `src/main.cpp`
  initializes Wi-Fi, OTA, battery, and sensor manager paths, then continuously
  updates network, sensors, OTA, and battery state.
  `src/network/packets.h`
  defines packet types for heartbeat, handshake, acceleration, battery, tap,
  error, sensor info, rotation data, magnetometer accuracy, signal strength,
  temperature, feature flags, config acknowledgement, flex data, bundle, and
  inspection. `src/network/connection.cpp`
  sends UDP packets and supports bundling modes. Configuration and calibration
  state live under `src/configuration/`, and battery reporting lives in
  `src/batterymonitor.cpp`.
- Code donor value:
  high for firmware packet vocabulary and diagnostics protocol design.
- Product reference value:
  high for making tracker health visible instead of treating firmware as a
  black box.
- Caveats:
  hardware and IMU support is broad, so any reuse should first isolate the
  protocol and health-reporting model.
- What to inspect next:
  compare packet and diagnostics fields against the server UI and adapter
  health surfaces.

## `carl-anders/slimevr-wrangler`

- GitHub:
  [carl-anders/slimevr-wrangler](https://github.com/carl-anders/slimevr-wrangler)
- What it is:
  a Rust/Iced app that uses Nintendo Switch Joy-Cons as SlimeVR trackers.
- Interesting idea:
  consumer controllers can become tracker inputs if an adapter normalizes
  their IMU stream, identity, reset action, and status into the server's
  tracker protocol.
- Code-level notes:
  `protocol/src/lib.rs`
  defines SlimeVR packet serialization with Deku, including quaternion,
  strings, rotation, handshake, acceleration, ping, sensor info, user action,
  and handshake response shapes.
  `src/joycon/communication.rs`
  performs the UDP handshake, maps Joy-Con IMU data into rotation and
  gravity-compensated acceleration packets, sends sensor info and reset user
  actions, and tracks device status. `src/main.rs`
  exposes an Iced UI with settings, device status cards, server connection,
  update checks, and Steam blacklist warning context.
- Code donor value:
  high for consumer-controller-to-tracker adapter structure.
- Product reference value:
  high for a small hardware bridge with explicit status and reset affordances.
- Caveats:
  Joy-Con Bluetooth and IMU behavior can be platform-sensitive, so this is a
  pattern donor more than a universal adapter recipe.
- What to inspect next:
  compare with Mocopi and HaritoraX adapters to separate shared SlimeVR
  protocol pieces from device-specific connection layers.

## `moslime/moslime`

- GitHub:
  [moslime/moslime](https://github.com/moslime/moslime)
- What it is:
  a Python bridge that sends Sony Mocopi tracker data into SlimeVR.
- Interesting idea:
  a BLE tracker adapter can provide value by replacing a first-party mobile
  app path with direct local normalization, autodiscovery, and diagnostics.
- Code-level notes:
  `moslime_common.py`
  stores JSON config, performs SlimeVR UDP autodiscovery, builds handshake,
  sensor-info, rotation, acceleration, battery, and error packets, and applies
  quaternion conversion/correction.
  `moslime.py`
  connects to each Mocopi BLE peripheral, handles command and notification
  UUIDs, waits for SlimeVR handshake response, parses IMU notifications,
  detects packet drops from tracker counters, sends rotation and acceleration
  packets, periodically requests battery/status, and reconnects devices.
- Code donor value:
  high for BLE tracker normalization and SlimeVR packet construction.
- Product reference value:
  medium-high for a direct bridge that reduces app-chain dependency.
- Caveats:
  BLE libraries, tracker firmware, and platform support can be brittle; a
  productized version needs clear device discovery and recovery UX.
- What to inspect next:
  compare packet-drop and reconnect diagnostics with SlimeTora's UI-rich
  hardware status model.

## `OCSYT/SlimeTora`

- GitHub:
  [OCSYT/SlimeTora](https://github.com/OCSYT/SlimeTora)
- What it is:
  an Electron/TypeScript desktop app that connects HaritoraX trackers to
  SlimeVR across BLE, Classic COM, and GX dongle paths.
- Interesting idea:
  a tracker adapter can become a guided hardware setup product: detect model,
  dongle, port, pairing, tracker order, battery, button bindings, debug state,
  and visualization.
- Code-level notes:
  `src/main.ts`
  loads config, detects COM ports and GX dongles, instantiates HaritoraX
  interpreters, uses `@slimevr/tracker-emulation`, creates emulated trackers
  with stable or random MACs, attaches sensors, and routes events for connect,
  disconnect, magnetometer state, buttons, IMU, battery, pairing, logs, and
  errors.
  Button multi-click actions map to SlimeVR reset/pause functions. IMU data is
  converted into quaternions and acceleration and sent through
  `sendRotationData` and `sendAcceleration`. Battery updates are smoothed
  before reaching SlimeVR and UI surfaces.
- Code donor value:
  very high for guided hardware adapter shell and tracker-emulation use.
- Product reference value:
  very high for onboarding, auto-detection, visualization, and per-tracker
  diagnostics.
- Caveats:
  it is a large vendor-specific adapter; reuse should focus on onboarding,
  detection, tracker-emulation, and diagnostics patterns.
- What to inspect next:
  compare SlimeTora's guided UI with SlimeVR Server's setup wizard and other
  hardware bridge apps.

## Main takeaways from Wave 109

- SlimeVR is best understood as a tracker ecosystem: firmware, server hub,
  skeleton calibration, runtime bridges, and hardware adapters.
- Tracker adapters are strongest when they expose health, battery, reconnect,
  packet-drop, and reset behavior as visible product states.
- The server hub pattern matters because it lets many inputs share calibration
  and many outputs share normalized tracking data.
- Firmware protocol design should include diagnostics and feature discovery,
  not only pose packets.

## Reusable methods clarified by this wave

- `Tracker server hub with skeleton calibration and multi-output runtime bridges`
- `Firmware tracker protocol with diagnostics packets and calibration persistence`
- `Consumer tracker adapters that normalize Joy-Con, Mocopi, or HaritoraX streams into SlimeVR`

## Recommended next moves after this wave

1. Keep SlimeVR Server visible as the strongest tracker hub and guided setup
   reference.
2. Keep SlimeVR Tracker ESP visible as the firmware-side diagnostics protocol
   reference.
3. Compare slimevr-wrangler, moslime, and SlimeTora whenever future work needs
   a hardware adapter pattern.
4. Revisit SlimeVR alongside virtual tracker, OSC bridge, and calibration
   families when tracker helper prototypes become active.
