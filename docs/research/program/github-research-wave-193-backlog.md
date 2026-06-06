# GitHub Research Wave 193 Backlog

- Date: `2026-06-06`
- Theme: `VRChat OSC physical-output safety and device-control bridge variants`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for DG-LAB, PiShock, OpenShock, Sensora, shocker, and
  VRChat OSC physical-output bridge variants.
- `Done` Dedupe against earlier haptics and OSC companion waves.
- `Done` Freeze a safety-focused shortlist around routing, mode mapping,
  cooldowns, panic stops, and UI transparency.

## Source Sync

- `Done` Confirm `DG-LAB-VRCOSC` in local-only cache.
- `Done` Confirm `VRChat_X_DGLAB` in local-only cache.
- `Done` Confirm `VRCHAT-OSC-to-DGLAB` in local-only cache.
- `Done` Confirm `VRC-DGLAB` in local-only cache.
- `Done` Confirm `DG-LAB-VRChat-Sensora` in local-only cache.
- `Done` Confirm `ShockVRC` in local-only cache.
- `Done` Confirm `PiShockTouch` in local-only cache.
- `Done` Confirm `VRChat-Shocker-Link-CPP` in local-only cache.

## Code Reading

- `Done` Inspect PySide6 app tabs, YAML config, DGLab command queue, source
  enable/cooldown flags, chatbox telemetry, OSCQuery server, and SoundPad/ToN
  integrations in `DG-LAB-VRCOSC`.
- `Done` Inspect source-light C# DG-LAB GUI variant in `VRChat_X_DGLAB`.
- `Done` Inspect Tkinter rule editor, default parameter rules, waveform
  patterns, channels, intensity, and ticks in `VRCHAT-OSC-to-DGLAB`.
- `Done` Inspect FastAPI lifespan, OSC service, job service, debounce,
  waveform fill, DGLab service, config service, and tests in `VRC-DGLAB`.
- `Done` Inspect Sensora WebSocket/HTTP/OSC orchestration, channel modes,
  rate limits, safety window, waveform monitoring, and chatbox status in
  `DG-LAB-VRChat-Sensora`.
- `Done` Inspect ShockVRC avatar menu schema, PiShock/OpenShock API bridge,
  target selection, and config caveats.
- `Done` Inspect PiShockTouch installer, avatar OSC JSON patching, contact
  receiver parameter schema, and API call path.
- `Done` Inspect Shocker Link C++ hub, OSCQuery, queue, panic hotkey, dynamic
  cooldown, curve presets, serial/API backends, notifications, and telemetry.

## Integration

- `Done` Create Wave 193 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for safety-first physical-output routers and
  parameter-threshold device mappers.
- `Next` Build a physical-output safety matrix across consent, local auth,
  panic stop, global disable, queue clearing, max duration/intensity, per-user
  cooldown, and chatbox/status visibility.
