# GitHub Research Wave 183 Plan

- Date: `2026-06-06`
- Theme: `DIY VR headset/controller hardware, firmware, and spec references`
- Scope: open DIY headset designs, SteamVR-compatible DIY controller stacks,
  microcontroller HID reports, BLE HID transport, OpenVR driver shells, camera
  marker tracking, hardware BOMs, PCBs, CAD references, and headset spec data.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

DIY hardware projects expose practical boundaries that software-only VR
utilities often hide: firmware packet shapes, calibration, USB/BLE HID, driver
resource manifests, haptics, optical/mechanical constraints, and device spec
data. This wave studies them as reusable architecture and constraint patterns.

## Search Families

- DIY open-source VR headsets
- DIY SteamVR controller firmware and drivers
- microcontroller HID report descriptors
- BLE HID input/output transport
- camera/IR marker controller tracking
- headset/controller PCB and CAD references
- VR headset specification datasets

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `vis3r/NxtVR` | Raspberry Pi Pico/STM32 DIY headset with TinyUSB HID HMD reports and MPU6050 calibration | DIY headset firmware/HID |
| `Kwiatens/FloV3R` | DIY 6DoF headset/controller hardware plan with PCBs, BOMs, PSMoveServiceEx/HadesVR dependency, and incomplete firmware | DIY headset/controller hardware reference |
| `Jade-Vincent/Persephone-VR-Headset` | CAD/BOM headset reference built around display, lenses, Pro Micro/Pico, and MPU6050 | DIY headset CAD/BOM reference |
| `CSParnell78/OpenVision` | Source-light DIY headset concept with display, Pro Micro, gyro, phone shell, and wireless transmitter choices | Source-light headset concept |
| `vrrare/vr-headset-specs` | JSON/CSV headset specs dataset with schema for display, optics, tracking, physical, and feature fields | Headset specs dataset |
| `dhfmzk/VRController` | Arduino/MPU9250 Bluetooth controller with explicit 34-byte quaternion/position/input packet | DIY controller firmware packet |
| `BlaiseSaunders/DIY-VR-Controller-OpenCV` | Python/OpenCV IR bright-spot tracker sending normalized coordinates over UDP | Vision marker tracker |
| `Windastella/open-vr-controller` | No-progress OpenXR DIY controller concept; retained as excluded/thin reference only | Source-light concept |
| `shehraan/DIY_VR_Controller` | ESP32/MPU6050 controller with Madgwick filter, BLE HID, haptics, OpenVR driver, profiles, and tests | Full DIY controller stack |

## Dedupe Notes

- `Relativty`, `HadesVR`, and `DIY_VR_Controllers` were already studied, so
  they are treated as lineage/overlap references only.
- Source-light hardware concepts are not promoted as strong donors unless they
  add a useful BOM, CAD, spec, or protocol lesson.
- Built binaries and third-party driver artifacts in study repos are caveats
  and must not be copied into `VR-apps-lab`.

## Code-Level Pass Targets

- HID report descriptors and firmware packet layouts;
- IMU calibration, bias storage, filters, and drift caveats;
- BLE HID input reports and output/haptics command paths;
- OpenVR driver resource manifests, input profiles, properties, and freshness
  thresholds;
- camera marker detection and normalized coordinate UDP output;
- BOM/CAD/PCB and display/optics constraints;
- headset specs schemas and dataset fields.

## Expected Outputs

- Wave 183 landscape synthesis.
- Registry/family placement for DIY headset/controller hardware and spec
  references.
- Methods around microcontroller HID, driver boundary mapping, vision-marker
  controllers, spec datasets, and hardware constraint capture.
