# VR Projects Wave 187: Heart-Rate, Wearable, ANT/BLE, and Sensor-to-OSC Bridge Variants

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 187 studies smaller sensor-to-avatar bridge variants. The goal is not to
replace earlier rich biometric references, but to compare transport choices,
parameter schemas, connection-state behavior, and avatar compatibility.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `kamyu1537/hr-osc` | Tauri HTTP/WebSocket/OSC heart-rate app | Compact multi-ingress bridge reference |
| `Curtis-VL/HeartRateOnStream-OSC` | OBS WebSocket shim to VRChat OSC | Strong compatibility-shim donor |
| `Solexid/OSC-VRChat-Feeder` | Android/MAUI BLE and phone-sensor feeder | Strong profile/sensor feeder reference |
| `TangNPC/ble-osc-heartrate` | Python BLE advertisement scanner | Minimal BLE advertisement donor |
| `KotRikD/vrc_hyperate_chatbox` | Electron Hyperate to chatbox/OSC app | Strong web-service chatbox donor |
| `DangerKiddy/HeartRateMonitorVRC` | Desktop BLE pulse-oximeter to VRChat | Strong BLE/reconnect/schema donor |
| `RedlineTriad/vrchat_ant_hr` | Rust ANT+ heart-rate bridge | Strong ANT+ anomaly-filter donor |
| `Naraenda/osc-hr-ble` | Tiny Rust BLE GATT HR to OSC bundle | Compact BLE/GATT donor |

## `kamyu1537/hr-osc`

- Interesting idea:
  combine a Tauri desktop app with HTTP heart-rate input, OSC send commands,
  and configurable VRChat parameter output.
- Code donor value:
  medium for HTTP receiver state, Tauri/Rust OSC commands, and UI-service split.
- Product reference value:
  medium for small companion apps that accept several HR sources.
- What to inspect next:
  frontend service loop, Stromno/Pulsoid integrations, and config persistence.
- Source evidence:
  `README.md`, `src/lib/osc.ts`, `src/lib/http_server.ts`,
  `src-tauri/src/osc.rs`, `src-tauri/src/http_server.rs`, and settings
  components.
- Reusable pattern extraction:
  small Tauri HR bridge with HTTP ingress.
- Reusable core:
  expose a local HTTP endpoint for raw BPM updates, store latest BPM/update
  time, invoke native OSC send commands from the UI, validate target host/port,
  and keep transport code behind service helpers.
- Do not copy directly:
  sparse README, unclear source-specific setup, or app-specific UI.
- Caveats:
  useful multi-ingress shape, but less mature than richer biometric hubs.

## `Curtis-VL/HeartRateOnStream-OSC`

- Interesting idea:
  impersonate enough of OBS WebSocket to receive `HeartRateOnStream` updates
  from a Wear OS/Android workflow, then forward them to VRChat OSC parameters.
- Code donor value:
  high for protocol shim and parameter compatibility.
- Product reference value:
  high for adapting existing companion apps without requiring a new wearable
  protocol.
- What to inspect next:
  robust JSON handling, reconnect behavior, and configurable port/password.
- Source evidence:
  `README.md` and `Program.cs`.
- Reusable pattern extraction:
  OBS/WebSocket compatibility shim for sensor ingress.
- Reusable core:
  host a WebSocket server, answer OBS-style hello/identify/request messages,
  parse `SetInputSettings` on a known text source, update latest BPM, publish
  `isHRConnected`/`isHRActive`, and send multiple compatible HR parameter
  encodings.
- Do not copy directly:
  hardcoded request IDs, busy loop, no cancellation, and string-built JSON.
- Caveats:
  compact but conceptually very useful compatibility adapter.

## `Solexid/OSC-VRChat-Feeder`

- Interesting idea:
  Android/MAUI app that can send Mi Band/BLE HR, sleep status, steps, calories,
  distance, touch controls, and device rotation to VRChat OSC through profiles.
- Code donor value:
  high for profile schema, BLE service handling, foreground worker, and
  normalization/clamping model.
- Product reference value:
  high for phone/wearable sensor feeder apps.
- What to inspect next:
  profile UI lifecycle, background reliability, and modern BLE permission
  handling.
- Source evidence:
  `README.md`, `OscVrcMaui/Services/OSCService.cs`, `BLEService.cs`,
  `DeviceSensorsService.cs`, `Models/Profile.cs`, `Services/ProfileDataStore.cs`,
  and Android platform files.
- Reusable pattern extraction:
  profile-driven phone sensor feeder to OSC.
- Reusable core:
  select a sensor input type, configure root OSC path and parameter name,
  normalize/clamp value ranges, persist profiles, connect BLE devices,
  subscribe to HR/steps characteristics, and send int/bool/float OSC values
  from a foreground-capable mobile app.
- Do not copy directly:
  bundled DLLs, device-specific magic bytes, or old MAUI/Shiny assumptions
  without validation.
- Caveats:
  strong design reference with device-specific BLE constraints.

## `TangNPC/ble-osc-heartrate`

- Interesting idea:
  scan BLE advertisements, filter by manufacturer company ID, extract a HR byte,
  and send several VRChat avatar parameters.
- Code donor value:
  medium as a very small BLE advertisement micro-bridge.
- Product reference value:
  medium for quick wearable experiments.
- What to inspect next:
  device-specific advertisement formats, reconnection/backoff, and config file.
- Source evidence:
  `README.md`, `app.py`, and `requirements.txt`.
- Reusable pattern extraction:
  BLE advertisement HR micro-bridge.
- Reusable core:
  use a BLE scanner callback, filter manufacturer data by company ID, extract
  BPM from a known offset, map BPM to raw/digits/float parameters, and send OSC
  to localhost VRChat.
- Do not copy directly:
  fixed company ID, hardcoded byte offset, and no stale-data handling.
- Caveats:
  compact but highly device-specific.

## `KotRikD/vrc_hyperate_chatbox`

- Interesting idea:
  connect to Hyperate's WebSocket, format heart-rate updates for VRChat
  chatbox, and optionally send compatibility parameters for VRCOSC/HrOSC
  prefabs.
- Code donor value:
  high for web-service subscription, chatbox debounce, trend icons, connection
  state, and Electron IPC boundary.
- Product reference value:
  high for stream/social VR companions where chatbox display matters.
- What to inspect next:
  API token handling, rate limits, and configurable OSC target.
- Source evidence:
  `README.md`, `src/features/hyperateMonitor.ts`, `utils/heartRateUtils.ts`,
  `src/main.ts`, hooks, and renderer components.
- Reusable pattern extraction:
  web-service HR to chatbox and prefab-compatible OSC sender.
- Reusable core:
  join a service WebSocket channel, send periodic service heartbeat, ignore zero
  or duplicate BPM values, debounce chatbox sends, template text with BPM/time/
  trend, emit UI events, and send both chatbox messages and avatar parameters.
- Do not copy directly:
  hardcoded default OSC port, embedded service-specific assumptions, and
  unchecked public API key practices.
- Caveats:
  strong social/presentation donor.

## `DangerKiddy/HeartRateMonitorVRC`

- Interesting idea:
  connect directly to a Bluetooth pulse oximeter on Windows or via helper phone
  app, process HR into many avatar parameters, and emulate beat pulses.
- Code donor value:
  high for BLE pairing/reconnect, GATT HR parsing, low/high session ranges,
  digit splitting, and beat emulation.
- Product reference value:
  high for desktop companion sensor bridges.
- What to inspect next:
  helper phone transport, UI device selection, and dependency packaging.
- Source evidence:
  `README.md`, `Services/BluetoothService.cs`, `HeartRateProcessor.cs`,
  `ProcessedHeartRate.cs`, `VrChatService.cs`, `OSC.cs`, and UI files.
- Reusable pattern extraction:
  desktop BLE HR bridge with derived avatar parameters.
- Reusable core:
  scan paired BLE devices, connect to Heart Rate service/measurement
  characteristic, subscribe to notifications, parse 8-bit/16-bit HR based on
  flags, reconnect on disconnect, compute normalized values, digits, session
  min/max, beat pulses, and publish active/connected flags.
- Do not copy directly:
  bundled Windows metadata/DLLs, tested-device assumptions, or WPF-specific UI
  code as cross-platform.
- Caveats:
  strong donor but Windows-specific.

## `RedlineTriad/vrchat_ant_hr`

- Interesting idea:
  bridge ANT+ heart-rate sensors through a USB dongle to VRChat OSC with
  selectable BPM modes and anomaly filtering.
- Code donor value:
  high for transport-specific reader separation and beat-time filtering.
- Product reference value:
  high for sports/fitness-grade sensor bridges.
- What to inspect next:
  ANT channel parsing, multi-device selection, and permission setup UX.
- Source evidence:
  `README.md`, `src/main.rs`, `src/ant.rs`, `src/bpm.rs`, `src/osc.rs`,
  `src/output.rs`, and `src/config.rs`.
- Reusable pattern extraction:
  ANT+ HR bridge with BPM mode and anomaly filter.
- Reusable core:
  run the ANT reader on a separate thread, send HR data through watch/broadcast
  channels, select computed or intra-beat BPM, skip likely missed/doubled beats,
  support log-only mode, and send normalized float to VRChat OSC.
- Do not copy directly:
  Linux USB permission setup as invisible prerequisite or single-output schema.
- Caveats:
  strong transport reference for non-BLE HR devices.

## `Naraenda/osc-hr-ble`

- Interesting idea:
  minimal Rust BLE GATT heart-rate reader that publishes several avatar
  parameters in one OSC bundle.
- Code donor value:
  high for compact GATT HR parser and bundled parameter send.
- Product reference value:
  medium for tiny CLI bridges and protocol examples.
- What to inspect next:
  device selection, reconnection, stale-data behavior, and config.
- Source evidence:
  `readme`, `src/main.rs`, `Cargo.toml`, and unit test for HR parsing.
- Reusable pattern extraction:
  tiny BLE GATT HR to OSC bundle sender.
- Reusable core:
  parse the BLE Heart Rate Measurement flags, support 8-bit and 16-bit BPM,
  optional energy/rr intervals, subscribe to GATT notifications, split BPM into
  digits, map float HR to `-1..1`, and send related OSC messages as one bundle.
- Do not copy directly:
  first-connected-device selection and no reconnect/config UX.
- Caveats:
  excellent small parser reference.

## Cross-Project Lessons

- Heart-rate bridges converge on a few reusable avatar parameters: raw BPM,
  digits, normalized float, connected/active booleans, and sometimes beat
  pulses or session min/max.
- Transport-specific code should be isolated: BLE GATT, BLE advertisements,
  ANT+, HTTP, OBS WebSocket, Hyperate WebSocket, and phone sensors each have
  different failure modes.
- Compatibility shims can be valuable when an existing wearable app only speaks
  OBS, HTTP, or a web service.
- Connection state matters as much as BPM; avatar parameters should expose
  active, connected, and stale states.
- Tiny bridges are useful donors if they make the packet/parser/schema boundary
  obvious.

## Reuse Recommendations

1. Use `HeartRateMonitorVRC` and `osc-hr-ble` for BLE GATT parsing and derived
   parameter schemas.
2. Use `vrchat_ant_hr` for ANT+ transport and beat anomaly filtering.
3. Use `HeartRateOnStream-OSC` for OBS/WebSocket compatibility-shim design.
4. Use `OSC-VRChat-Feeder` for phone/wearable multi-sensor profile design.
5. Use `vrc_hyperate_chatbox` for chatbox formatting, trend display, and
   web-service heartbeat behavior.
