# GitHub Research Wave 246 Plan

Date: 2026-06-06

Theme: SlimeVR DIY tracker hardware, PCB, case, and firmware boundaries.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

The repository has many tracker bridge and body-tracking software references,
but fewer notes on hardware boundaries. This wave studies DIY tracker
repositories for reusable lessons around PCB families, IMU compatibility,
battery/charging, enclosure ergonomics, firmware configuration, packet schema,
and open-hardware caveats.

## Search Families

- SlimeVR DIY tracker boards.
- Tracker PCB variants and IMU adapter boards.
- Tracker cases, clips, straps, and battery layouts.
- Zephyr or embedded tracker firmware skeletons.
- Open-hardware licensing and maker documentation.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `zhangwenchao1992/SlimeVR_DeftTracker` | Full tracker kit with main tracker, auxiliary tracker, charge hub, cases, PCBs, photos, and firmware subtree. | Full hardware kit reference |
| `frosty6742/frozen-slimes-v2` | Wemos/IMU PCB with strap slots, battery/charger design, IMU bridge pads, and assembly/flashing notes. | Maker PCB documentation donor |
| `TheButlah/slimevr_pcb` | Board family split between simple breakout and ESP32-C3/RISC-V/BLE advanced design with IMU compatibility jumpers. | Hardware family donor |
| `gumorr/GummySlime` | Hand-solderable SlimeVR-compatible board with ESP32-C3, module IMU boundary, auxiliary pads, and firmware defines. | Hand-solderability reference |
| `Tropingenie/Caribou-Slime` | ESP32-C3/BMI270 tracker board with BOM/cost notes and reciprocal open-hardware license framing. | License/BOM reference |
| `infopcgood/SMORES` | Source-light compact nRF52840/ICM-45686 SlimeVR board direction. | Needs deeper schematic study |
| `ZRock35/TinyOfficial-Case` | SlimeVR case remix with strap loops, open/closed tops, battery orientation, foam, and connector warnings. | Mechanical ergonomics reference |
| `1vers1on/vr_trackers` | Zephyr tracker skeleton with sensor/fuel/charger init, packet schema, gyroscope calibration, and board files. | Firmware boundary donor |

## Dedupe Notes

Previous waves cover SlimeVR server/client, tracker bridges, OSC/WebSocket
bridges, and synthetic tracker drivers. This wave stays hardware-boundary
focused and does not re-study SlimeVR itself as software.

## Code-Level Pass Targets

- Board family structure and manufacturing outputs.
- MCU, IMU, charger, battery, and expansion boundaries.
- Firmware config macros and packet schemas.
- Calibration routines and sensor abstraction.
- Case/strap/battery ergonomics.
- License and hardware documentation caveats.

## Expected Outputs

- Wave 246 landscape synthesis.
- Registry/family entry for DIY tracker hardware boundaries.
- Method catalog entry for hardware/firmware tracker boundary capture.
- Follow-up backlog for SlimeVR derivative matrix and tracker note template.
