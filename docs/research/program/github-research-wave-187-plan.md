# GitHub Research Wave 187 Plan

- Date: `2026-06-06`
- Theme: `Heart-rate, wearable, ANT/BLE, and sensor-to-OSC bridge variants`
- Scope: Tauri/Rust heart-rate apps, OBS/WebSocket shims, Android/MAUI BLE
  feeders, Python BLE advertisement scanners, Hyperate chatbox apps, desktop
  BLE pulse-oximeter tools, ANT+ dongle bridges, and tiny Rust BLE senders.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier waves covered strong biometric hubs such as `iron-heart` and
`vrc-osc-miband-hrm`. This wave studies smaller variants to extract reusable
parameter schemas, transport-specific readers, connection-state behavior, and
failure modes for sensor-to-avatar tools.

## Search Families

- VRChat heart-rate OSC bridge variants
- BLE heart-rate monitor readers
- ANT+ heart-rate dongle bridges
- OBS/WebSocket compatibility shims
- Hyperate/Pulsoid-style web service companions
- Android/phone sensor feeders to OSC

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `kamyu1537/hr-osc` | Tauri app with HTTP heart-rate receiver and OSC sender | Tauri HR bridge |
| `Curtis-VL/HeartRateOnStream-OSC` | OBS-WebSocket-shaped server that receives Wear OS HR and sends VRChat OSC | OBS/WebSocket HR shim |
| `Solexid/OSC-VRChat-Feeder` | MAUI Android feeder for Mi Band/BLE HR, steps, rotation, and profiles | Android sensor feeder |
| `TangNPC/ble-osc-heartrate` | Minimal Python BLE advertisement to OSC parameter sender | BLE advertisement micro-bridge |
| `KotRikD/vrc_hyperate_chatbox` | Electron Hyperate-to-chatbox and prefab-compatible OSC sender | Hyperate chatbox bridge |
| `DangerKiddy/HeartRateMonitorVRC` | Desktop BLE pulse-oximeter app with reconnection and derived parameters | Desktop BLE pulse-ox donor |
| `RedlineTriad/vrchat_ant_hr` | Rust ANT+ dongle bridge with BPM modes and anomaly filtering | ANT+ HR bridge |
| `Naraenda/osc-hr-ble` | Tiny Rust BLE GATT HR parser publishing bundled OSC params | Tiny BLE HR sender |

## Dedupe Notes

- `nullstalgia/iron-heart` and `vard88508/vrc-osc-miband-hrm` were already
  studied in earlier biometric waves and remain the richer reference pair.
- This wave is intentionally variant-focused: the value is comparing transport
  and schema boundaries, not declaring every HR bridge a separate product line.
- Repositories that were only forks or exact duplicates were excluded.

## Code-Level Pass Targets

- heart-rate parameter naming, normalization, digit splitting, and beat booleans;
- BLE GATT versus BLE advertisement versus ANT+ data paths;
- HTTP/WebSocket/OBS compatibility shims;
- reconnect/failure handling and active/connected avatar parameters;
- profile/model shape for phone sensor feeder apps;
- chatbox formatting and debounce behavior.

## Expected Outputs

- Wave 187 landscape synthesis.
- Registry/family placement for sensor-to-avatar bridge variants.
- Methods around wearable HR parameter schemas, OBS/WebSocket shims,
  BLE/ANT+ readers, and sensor feeder profiles.
