# GitHub Research Wave 187 Backlog

- Date: `2026-06-06`
- Theme: `Heart-rate, wearable, ANT/BLE, and sensor-to-OSC bridge variants`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for VRChat heart-rate OSC bridges and wearable HR tools.
- `Done` Search GitHub for BLE, ANT+, Hyperate, HeartRateOnStream, and Android
  sensor feeder variants.
- `Done` Dedupe against existing biometric waves and exclude already studied
  `iron-heart` and `vrc-osc-miband-hrm`.
- `Done` Freeze a variant-focused shortlist around transport/schema lessons.

## Source Sync

- `Done` Confirm `hr-osc` in local cache.
- `Done` Confirm `HeartRateOnStream-OSC` in local cache.
- `Done` Confirm `OSC-VRChat-Feeder` in local cache.
- `Done` Confirm `ble-osc-heartrate` in local cache.
- `Done` Confirm `vrc_hyperate_chatbox` in local cache.
- `Done` Confirm `HeartRateMonitorVRC` in local cache.
- `Done` Confirm `vrchat_ant_hr` in local cache.
- `Done` Confirm `osc-hr-ble` in local cache.

## Code Reading

- `Done` Inspect Tauri OSC/HTTP bridge code in `hr-osc`.
- `Done` Inspect OBS WebSocket shim and VRChat parameter sends in
  `HeartRateOnStream-OSC`.
- `Done` Inspect MAUI BLE, profiles, OSC service, and background feeder shape in
  `OSC-VRChat-Feeder`.
- `Done` Inspect BLE manufacturer advertisement parsing in
  `ble-osc-heartrate`.
- `Done` Inspect Hyperate WebSocket, chatbox formatting, debounce, and
  compatibility sends in `vrc_hyperate_chatbox`.
- `Done` Inspect desktop BLE reconnect, HR parsing, derived parameters, and
  beat emulation in `HeartRateMonitorVRC`.
- `Done` Inspect ANT+ BPM modes and anomaly filter in `vrchat_ant_hr`.
- `Done` Inspect Rust BLE GATT HR parser and OSC bundle send in `osc-hr-ble`.

## Integration

- `Done` Create Wave 187 landscape document.
- `Done` Update registry/family placement.
- `Done` Add methods for HR parameter schema variants, OBS/WebSocket shims, and
  BLE/ANT+ readers.
- `Next` Build a biometric bridge compatibility table across parameter names,
  source transport, connection status, and avatar prefab compatibility.
