# GitHub Research Wave 191 Plan

- Date: `2026-06-06`
- Theme: `VRC haptics server, firmware, hardware, and trigger bridge lineage`
- Scope: avatar-driven haptic output, OSC contact receivers, device managers,
  WiFi/BLE firmware, DIY hardware, bHaptics preset triggers, tracker haptic
  modules, and older lineage projects.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier haptics waves covered SDKs, relays, and physical-output routers. This
wave focuses on the VRC haptics lineage because it exposes a complete boundary
from avatar OSC parameters to server mapping, interpolation, device discovery,
firmware packet handling, and hardware documentation.

## Search Families

- VRC haptics OSC servers
- VRChat contact receiver haptics
- DIY ESP haptic firmware
- bHaptics pattern trigger OSC tools
- tracker haptic modules
- avatar-driven physical output bridges

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `VRC-Haptics/VRCH-Server` | Modern Rust/Tauri haptics manager with VRC OSC, interpolation, WiFi/BLE devices | Mature VRC haptics server donor |
| `VRC-Haptics/VRCH-Firmware` | ESP32/ESP8266 firmware with OSC commands, config, multicast, PWM/PCA outputs | Firmware protocol donor |
| `virtuallyaverage/VRC-Haptics-Host` | Older Python host showing readable contact-to-device flow | Lineage/simple server donor |
| `virtuallyaverage/VRC-Haptics-Firmware` | Superseded firmware lineage | Historical firmware reference |
| `virtuallyaverage/VRC-Haptics-Hardware` | Hardware/PCB/BOM lineage moved to newer org | Hardware documentation reference |
| `sync1211/HapticPatternTriggerOSC` | OSC booleans trigger bHaptics `.tact` patterns | Vendor preset trigger bridge |
| `TahvoDev/AXHaptics` | VRCOSC module mapping avatar haptic params to AXIS tracker vibrations | Tracker haptics module reference |
| `Pillazo/VRCHaptics` | Legacy end-to-end DIY haptics stack with VB.NET host and ESP firmware | Legacy DIY baseline |

## Dedupe Notes

- Earlier haptics waves already covered broad bHaptics SDKs and generic
  telemetry-to-haptics adapters; this wave keeps projects with VRC contact,
  server, firmware, hardware, or trigger lineage value.
- Superseded repositories are kept as lineage/reference nodes, not promoted as
  equally modern donors.
- Hardware and firmware were studied statically only; no flashing, building,
  or device tests were attempted.

## Code-Level Pass Targets

- VRC OSC contact parameter ingestion and `/avatar/change` handling;
- haptic input maps, node groups, interpolation, and output intensity shaping;
- device manager boundaries and WiFi/BLE transport;
- firmware config, serial commands, OSC commands, mDNS/multicast discovery,
  and PWM/PCA motor output;
- bHaptics `.tact` preset imports and boolean reset behavior;
- tracker-haptic compatibility mappings and deprecated hardware caveats.

## Expected Outputs

- Wave 191 landscape synthesis.
- Registry/family placement for VRC haptics lineage.
- Methods for OSC-to-device haptics servers, firmware/hardware boundaries,
  preset trigger bridges, and tracker haptics modules.
