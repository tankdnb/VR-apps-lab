# GitHub Research Wave 191 Backlog

- Date: `2026-06-06`
- Theme: `VRC haptics server, firmware, hardware, and trigger bridge lineage`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for VRC haptics, VRChat contact haptics, firmware,
  hardware, preset triggers, and tracker haptic modules.
- `Done` Dedupe against earlier broad haptics waves.
- `Done` Freeze a lineage-focused shortlist around server, firmware, hardware,
  and bridge boundaries.

## Source Sync

- `Done` Confirm `VRCH-Server` in local-only cache.
- `Done` Confirm `VRCH-Firmware` in local-only cache.
- `Done` Confirm `VRC-Haptics-Host` in local-only cache.
- `Done` Confirm `VRC-Haptics-Firmware` lineage repo in local-only cache.
- `Done` Confirm `VRC-Haptics-Hardware` lineage repo in local-only cache.
- `Done` Confirm `HapticPatternTriggerOSC` in local-only cache.
- `Done` Confirm `AXHaptics` in local-only cache.
- `Done` Confirm `VRCHaptics` legacy repo in local-only cache.

## Code Reading

- `Done` Inspect Rust/Tauri server startup, VRC OSC listener, map cache,
  haptic input nodes, interpolation, device manager, WiFi/BLE boundaries, and
  config save loop in `VRCH-Server`.
- `Done` Inspect PlatformIO firmware config, LittleFS persistence, serial/OSC
  commands, multicast discovery, WiFi callbacks, PCA/LEDC PWM output, and
  thermal/power caveats in `VRCH-Firmware`.
- `Done` Inspect Python lineage host, VRC OSC callbacks, board handler, mDNS
  discovery, modulation, and `/h` packet output in `VRC-Haptics-Host`.
- `Done` Inspect hardware lineage README and PCB/BOM/Gerber/KiCad structure in
  `VRC-Haptics-Hardware`.
- `Done` Inspect bHaptics preset import, OSC parameter mapping, boolean reset,
  and WinForms control flow in `HapticPatternTriggerOSC`.
- `Done` Inspect AXIS/VRCOSC module mappings, UDP command format, node
  vibration, and compatibility/deprecation notes in `AXHaptics`.
- `Done` Inspect legacy VB.NET host, VRC OSC parser, device provisioning,
  multicast packet output, hardware docs, and Arduino firmware in
  `VRCHaptics`.

## Integration

- `Done` Create Wave 191 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for haptics servers, firmware/device boundaries,
  preset triggers, and tracker haptic modules.
- `Next` Build a haptic event schema matrix across contact receivers, avatar
  parameters, bHaptics presets, tracker nodes, firmware packets, and hardware
  maps.
