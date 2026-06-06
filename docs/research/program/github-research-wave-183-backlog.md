# GitHub Research Wave 183 Backlog

- Date: `2026-06-06`
- Theme: `DIY VR headset/controller hardware, firmware, and spec references`
- Status: executed as static source-reading pass
- Build/run status: not run, not built, not installed, not launched

## Completed Intake

- Shortlisted DIY headset, controller, vision-tracker, and headset-spec
  repositories.
- Deduplicated against earlier Relativty/HadesVR/DIY hardware waves.
- Read firmware, driver, schema, and documentation entry points without
  executing found projects.
- Integrated DIY hardware methods into canonical docs.

## Follow-Up Work

- Create a `DIY XR hardware boundary matrix` comparing:
  firmware packet, USB/BLE HID, driver profile, calibration, haptics, CAD/BOM,
  and optical constraints.
- Compare DIY controller driver strategies:
  OpenVR driver, OpenXR target, HadesVR dependency, PSMoveServiceEx, HID-only,
  and UDP marker tracking.
- Create a headset-spec schema note that can feed future compatibility,
  recommendation, or device inventory tooling.
- Preserve source-light projects as concept references without overstating
  donor maturity.

## Reuse Candidates

- TinyUSB HMD HID report and calibration flow from `NxtVR`.
- Hardware/BOM/PCB documentation shape from `FloV3R` and
  `Persephone-VR-Headset`.
- JSON/CSV headset spec schema from `vr-headset-specs`.
- Arduino 34-byte quaternion/position/input packet from `VRController`.
- IR bright-spot UDP tracker from `DIY-VR-Controller-OpenCV`.
- ESP32 BLE HID plus OpenVR driver boundary from `DIY_VR_Controller`.

## Caveats To Preserve

- Hardware projects are often incomplete, risky, old, or dependent on external
  driver stacks.
- Built driver binaries, CAD dumps, and third-party libraries are not content
  to import into this public research repo.
- Any future hardware-inspired prototype should start from protocol/schema
  boundaries, not from copying a whole device build.
