# GitHub Research Wave 227 Plan

Date: 2026-06-06

Theme: OpenGloves DIY haptics adapters, named pipes, and firmware variants.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

The repository already tracks OpenGloves/LucidGloves lineage, but the useful
implementation lesson is the adapter boundary: hardware firmware, BLE/serial
or HID transport, named pipes, normalized finger data, force feedback, and
driver compatibility. This wave studies converter and variant projects that
make that boundary visible.

## Search Families

- OpenGloves named-pipe examples.
- DIY glove converter sidecars.
- BLE/serial bridges into OpenGloves.
- Firmware variants and hardware documentation.
- Force-feedback and haptic output adapters.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `SparkleTech-VR/OpenPulseConverter` | WIP converter from BiFrost Pulse gloves to OpenGloves named-pipe input and haptic output. | Hardware-to-OpenGloves converter |
| `danwillm/opengloves-named-pipe-example` | Minimal C++ example for writing OpenGloves v2 input data to Windows named pipes. | Named-pipe contract micro-reference |
| `DasKatzchen/GloveBridge` | Python BLE bridge concept between LucidGloves devices and OpenGloves named pipes. | BLE-to-pipe bridge |
| `Stargazer6481/Compact-Gloves` | Compact DIY SteamVR glove with BOM/docs, ESP32 firmware, Bluetooth Serial, OpenGloves setup, and calibration docs. | DIY glove product/reference |
| `xRayz3n/ExoTouch-2.0` | Exoskeleton glove hardware and LucidGloves-based firmware variant with encoder input and servo haptics. | Firmware/hardware variant |

## Dedupe Notes

OpenGloves and LucidGloves were already known family anchors. This wave avoids
re-studying them as primary projects and instead studies adapter-sidecar and
variant projects that expose reusable boundary lessons.

## Code-Level Pass Targets

- OpenGloves named-pipe input and force-feedback output shape.
- HID/BLE/serial transport and reconnect behavior.
- Finger data parsing, calibration, normalization, and mapping.
- Firmware encoding formats, gesture buttons, joystick, and haptic limits.
- Hardware documentation and onboarding structure.
- Caveats around variants, forks, hardcoded paths, and rough prototypes.

## Expected Outputs

- Wave 227 landscape synthesis.
- Registry/family entries for OpenGloves-compatible adapters.
- Method catalog entry for DIY haptics adapter boundaries.
- Follow-up backlog for OpenGloves adapter and firmware-variant matrix.
