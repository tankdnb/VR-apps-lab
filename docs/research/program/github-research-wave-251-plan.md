# GitHub Research Wave 251 Plan

Date: 2026-06-06

Theme: OpenVR legacy sensor compatibility and synthetic driver shims.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

The repository already has many tracker, driver, and hardware waves. This wave
adds a narrower compatibility slice: legacy sensors, identity spoofing,
no-HMD/game-specific drivers, vendor headset bridges, and DIY HMD runtime to
driver boundaries.

## Search Families

- SteamVR/OpenVR legacy sensor drivers.
- Kinect and Leap Motion driver adapters.
- SteamVR device identity compatibility shims.
- No-HMD and virtual-HMD drivers.
- DIY headset runtime and shared-memory driver splits.
- Vendor headset bridge lineage.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `SDraw/driver_leap` | Leap Motion to SteamVR controller driver with companion control/overlay app. | Legacy hand sensor driver donor |
| `SDraw/driver_kinectV1` | Kinect V1 skeleton to SteamVR generic tracker driver with dashboard calibration. | Legacy body tracker donor |
| `SDraw/driver_kinectV2` | Kinect V2 variant with similar tracker/dashboard split. | Sensor-variant comparison node |
| `schellingb/PseudoVive` | Early-load OpenVR property hook that spoofs Vive model/manufacturer names. | Compatibility shim cautionary donor |
| `r57zone/Half-Life-Alyx-novr` | Game-specific no-HMD SteamVR driver and keyboard/mouse control mapping. | No-HMD retrofit reference |
| `lixiangwuxian/Viulux-V9-Driver-for-SteamVR` | Source-light vendor headset bridge lineage from Relativty/OpenHMD and Nolo. | Hardware bridge caveat reference |
| `Blockmann2K/MurlokVR` | DIY headset split across firmware, Rust runtime, shared memory, and OpenVR driver. | DIY HMD runtime-driver donor |

## Dedupe Notes

Earlier waves cover OpenVR driver tutorials, mixed controller bridges,
headsetless tools, DIY hardware, and tracker bridges. This wave keeps projects
that add legacy sensor details, identity-shim lessons, or a clearer
runtime-to-driver boundary.

## Code-Level Pass Targets

- Driver manifest, factory, provider, and device registration.
- Sensor polling and pose/input mapping.
- Device identity, serial/model/manufacturer properties.
- Calibration/dashboard settings.
- Runtime-to-driver transport such as shared memory.
- Compatibility, spoofing, obsolete SDK, and policy caveats.

## Expected Outputs

- Wave 251 landscape synthesis.
- Registry/family entry for OpenVR legacy sensor and compatibility shims.
- Method catalog entry for OpenVR compatibility driver boundaries.
- Follow-up backlog for a driver-boundary comparison matrix.
