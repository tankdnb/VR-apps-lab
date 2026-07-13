# VR Projects Wave 421 - Lighthouse Base Station And Home Automation Bridges

- Date: `2026-07-13`
- Theme: Lighthouse/base-station power management as VR-room automation.

## Shortlist

| Project | Study status | Why it matters |
|---|---|---|
| `jariz/homeassistant-basestation` | Studied with archive caveat | Home Assistant switch entity for Valve Index Base Stations over BLE |
| `ShayBox/Lighthouse` | Studied | Rust CLI/library for V1/V2 Lighthouse power state management with retries and target selection |

## Cross-Project Synthesis

This wave reframes base-station control as a room-state primitive. One branch
connects VR hardware to Home Assistant automations; the other exposes a
scriptable command-line core that can be wrapped by launchers, dashboards, or
startup flows.

Reusable pattern:

- discover and normalize base-station identity;
- expose state as `on`, `off`, or `standby`;
- target all devices or selected devices;
- handle BLE failures with explicit availability, retries, and logs;
- let higher-level automation decide when VR hardware should wake or sleep.

## Project Notes

### `jariz/homeassistant-basestation`

- Interesting idea:
  make Lighthouse V2 devices normal Home Assistant switches so VR-room startup,
  shutdown, presence, lighting, and Wake-on-LAN flows can be automated.
- Code donor value:
  `custom_components/basestation/switch.py` shows a compact Home Assistant
  `SwitchEntity` with BLE device resolution, `BleakClient`, power
  characteristic writes, polling, and availability state.
- Product reference value:
  good reference for exposing VR hardware as smart-home entities rather than
  app-local settings.
- Source evidence:
  README documents BLE MAC discovery, YAML config, grouping multiple base
  stations, and automation ideas; code uses `PWR_CHARACTERISTIC`, `PWR_ON`,
  `PWR_STANDBY`, and Home Assistant bluetooth resolution.
- Reusable core:
  device entity wrapper, availability status, read/write state, grouped device
  control, and automation hooks.
- What not to copy:
  archived maintenance state, synchronous `asyncio.run` wrappers in newer Home
  Assistant contexts, or MAC-address-only UX without discovery support.
- What to inspect next:
  maintained forks, config-flow migration, ESPHome gateway approach, and
  bluetooth permission/failure UX.

### `ShayBox/Lighthouse`

- Interesting idea:
  ship a small Rust utility for V1/V2 base-station power states with adapters,
  scan timeouts, target matching, retries, and quiet/verbose logging.
- Code donor value:
  `src/lib.rs` separates adapter discovery, scan loops, peripheral filtering,
  service discovery, and GATT writes. `src/main.rs` adds command parsing,
  V1/V2 UUID selection, target matching, retries, and failure aggregation.
- Product reference value:
  strong microtool reference: one command does one VR-room operation well, and
  its CLI shape is easy to wrap in launchers or automations.
- Source evidence:
  README documents `--state`, `--bsid`, timeout, retries, retry delay, and V1/V2
  targeting; source uses `btleplug`, `tokio`, `clap`, `tracing`, and UUIDs for
  Lighthouse commands.
- Reusable core:
  scan-with-timeout, target normalization, multi-adapter iteration, write
  retries, failure collection, and tiny release binary profile.
- What not to copy:
  raw BLE command assumptions without hardware warnings, automatic all-device
  targeting without preview, or platform permission caveats hidden from users.
- What to inspect next:
  V1/V2 command byte provenance, macOS/Linux permission differences, Windows
  support, and dry-run/list-device mode.

## Reusable Pattern Extraction

- Pattern candidate:
  `Base-station automation bridge`.
- Problem solved:
  VR-room hardware has its own power and readiness lifecycle, but users want it
  aligned with room presence, SteamVR launch, home automation, and shutdown.
- Reusable core:
  device discovery, stable identifiers, state command mapping, availability
  polling, retries, target preview, group control, and automation integration.
- Abstraction boundary:
  keep BLE/protocol writes behind a hardware adapter; expose safe commands and
  status to smart-home, CLI, overlay, or launcher layers.
- Method catalog action:
  add new method for base-station automation bridges.

## Follow-Up Gaps

- Compare Home Assistant, CLI, ESPHome gateway, and SteamVR launcher triggers.
- Add dry-run and target identity preview to any future VR hardware microtool.
- Document user-facing warnings for range, permissions, and unsupported states.
