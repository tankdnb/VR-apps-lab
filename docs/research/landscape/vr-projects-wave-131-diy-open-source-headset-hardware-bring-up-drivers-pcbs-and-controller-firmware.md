# VR Projects Wave 131: DIY Open-Source Headset Hardware Bring-Up, Drivers, PCBs, and Controller Firmware

- Date: `2026-06-05`
- Goal: study DIY/open-source headset projects as reusable references for
  hardware bring-up, OpenVR driver shells, HID/UART/RF data transport, IMU
  filtering, controller input mapping, PCB/CAD assets, and configuration GUI
  tooling.

## Why this wave exists

DIY headset projects are useful to `VR-apps-lab` even when we are not building
hardware. They expose the full chain from physical signals to runtime objects:

- firmware packet formats;
- HID, UART, RF, and serial transports;
- IMU calibration and filtering;
- OpenVR HMD display components;
- controller and tracker property/input components;
- PCB, BOM, Gerber, STL, and assembly references;
- GUI-driven driver settings and calibration files.

## Better workflow used in this wave

1. searched by DIY VR headset, HadesVR, Relativty, controller firmware, PCB,
   and OpenVR driver families;
2. deduplicated against virtual-HMD, no-HMD, OpenVR driver, tracker bridge, and
   locomotion hardware waves;
3. froze a hardware-bring-up shortlist;
4. inspected local-only source clones;
5. separated strong full-stack donors from hardware-only or weak candidates;
6. extracted driver/firmware/hardware methods without attempting builds.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `relativty/Relativty` | Full DIY headset with firmware, OpenVR driver, PCB, Gerbers, and mechanical files |
| `HadesVR/HadesVR` | DIY headset/controller/tracker ecosystem with driver, firmware, RF, docs, and settings |
| `HadesVR/Wand-Controller` | Controller PCB/firmware reference for HadesVR ecosystem |
| `HadesVR/Basic-HMD-PCB` | Beginner HMD PCB, firmware, and calibration/reference hardware |
| `JX5S/HadesVR_GUI_Tool` | Qt GUI for editing HadesVR driver settings |
| `dmcke5/DIY_VR_Controllers` | HadesVR-compatible controller hardware/firmware variant |
| `dietzus/DietzVR` | Empty/near-empty current clone; recorded as weak candidate only |

## Deep-pass notes by project

## `relativty/Relativty`

- GitHub:
  [relativty/Relativty](https://github.com/relativty/Relativty)
- What it is:
  an open-source DIY VR headset project with firmware, OpenVR driver,
  electronics, mechanical assets, and setup documentation.
- Interesting idea:
  a headset repo can be a true physical-to-runtime reference: PCB/Gerbers,
  STL/Fusion files, Arduino firmware, HID reports, driver factory, HMD display
  component, pose update threads, and optional external position tracking.
- Code-level notes:
  `DriverFactory.cpp` exposes `HmdDriverFactory` and returns an
  `IServerTrackedDeviceProvider` for OpenVR. `Relativty_HMDDriver.cpp`
  initializes HID, opens the device by VID/PID, starts quaternion/vector/pose
  update threads, reads 64-byte HID packets, supports MPU DMP or float
  quaternion packets, calibrates quaternion offsets via key input, optionally
  accepts position vectors over a TCP socket, and calls
  `TrackedDevicePoseUpdated`. `firmware.ino` defines a vendor HID report,
  initializes MPU6050 DMP, calibrates accel/gyro, and sends 63-byte HID reports
  from FIFO packets.
- Code donor value:
  very high for OpenVR HMD driver bring-up, HID pose ingestion, and hardware
  repo structure.
- Product reference value:
  high for DIY hardware documentation and full-stack packaging.
- Caveats:
  older Windows/OpenVR/HID driver assumptions and GPL licensing.
- What to inspect next:
  compare with HadesVR's richer settings and controller/tracker stack.

## `HadesVR/HadesVR`

- GitHub:
  [HadesVR/HadesVR](https://github.com/HadesVR/HadesVR)
- What it is:
  a DIY PC VR headset/controller/tracker ecosystem with documentation,
  firmware, driver, RF receiver, and hardware assets.
- Interesting idea:
  a DIY headset stack should make data transport, driver settings, display
  geometry, distortion, controller emulation, tracker roles, and calibration
  explicit and editable.
- Code-level notes:
  `driver_main.cpp` reads HMD/display settings from SteamVR settings, exposes
  an OpenVR HMD display component, sets model, serial, render target,
  frequency, IPD, display-on-desktop/direct-mode flags, eye-to-head matrices,
  FOV, distortion values, and window/viewport geometry. `devices.hpp` creates
  controller and tracker properties, controller roles, skeleton components,
  haptic components, boolean inputs, scalar inputs, input profiles, icons, and
  render models for Index/Vive style emulation. `Headset.ino` defines HID or
  UART transport, RF controller/tracker packet structures, IMU calibration
  data, HMD raw and controller payloads, optional RF modules, and FastIMU-based
  sensor handling. `dataHandler.cpp` parses HMD/controller/tracker packets,
  updates quaternions, accelerometer state, battery, fingers, buttons, joystick
  axes, Madgwick filter, Kalman filters, and pose output.
- Code donor value:
  very high for driver settings, input components, and transport/packet
  demultiplexing.
- Product reference value:
  very high for an open hardware ecosystem with docs and GUI-adjacent tooling.
- Caveats:
  complex stack with hardware assumptions and Windows/OpenVR focus.
- What to inspect next:
  extract a driver-settings schema and hardware transport diagnostic checklist.

## `HadesVR/Wand-Controller`

- GitHub:
  [HadesVR/Wand-Controller](https://github.com/HadesVR/Wand-Controller)
- What it is:
  DIY Vive-wand-like controller PCB and firmware for the HadesVR ecosystem.
- Interesting idea:
  controller firmware can package orientation, accelerometer, buttons,
  trigger, joystick, battery, finger placeholders, grip force, and role
  selection into a compact RF packet.
- Code-level notes:
  `Firmware.ino` defines left/right role compile switches, button pins,
  joystick ranges/deadzones, battery thresholds, NRF24L01 pipe selection,
  FastIMU setup, Madgwick orientation filter, calibration storage, and a
  `ctrlData` payload with quaternion, accel, buttons, analog trigger,
  joystick axes, trackpad emulation, battery, finger, grip, and data fields.
  README documents PCB panelization, through-hole design, RF requirements,
  upload wiring, IMU/magnetometer calibration, and joystick mode toggle.
- Code donor value:
  high for controller RF payload and calibration/user-doc patterns.
- Product reference value:
  high for open controller hardware.
- Caveats:
  hardware-specific and not Bluetooth; needs HadesVR receiver.
- What to inspect next:
  compare with `DIY_VR_Controllers` calibration variant.

## `HadesVR/Basic-HMD-PCB`

- GitHub:
  [HadesVR/Basic-HMD-PCB](https://github.com/HadesVR/Basic-HMD-PCB)
- What it is:
  a beginner-friendly PCB and firmware for converting phone VR shells into PC
  VR headset hardware.
- Interesting idea:
  a hardware starter kit can be valuable when it documents BOM, PCB files,
  firmware, calibration, VID/PID lookup, tracking LED color codes, and
  compatibility with controller RF.
- Code-level notes:
  the repo includes firmware, EasyEDA board/schematic JSON, Gerbers, schematic
  PDF, screenshots, and detailed README instructions. The README documents
  Arduino Pro Micro core, IMU, NRF24L01, optional dual RF modules, FastIMU
  compatibility, serial calibration, EEPROM storage, VID/PID discovery, and
  LED error states.
- Code donor value:
  medium-high for hardware onboarding and calibration checklist design.
- Product reference value:
  high as a beginner kit reference.
- Caveats:
  mostly hardware/documentation donor rather than runtime code donor.
- What to inspect next:
  use as a hardware-facing docs template if `VR-apps-lab` adds device recipes.

## `JX5S/HadesVR_GUI_Tool`

- GitHub:
  [JX5S/HadesVR_GUI_Tool](https://github.com/JX5S/HadesVR_GUI_Tool)
- What it is:
  a Qt GUI for editing HadesVR driver settings.
- Interesting idea:
  driver settings should have a human-facing editor that preserves categories,
  types, order, readability, and default values instead of forcing users to
  hand-edit JSON.
- Code-level notes:
  `vrsettings.cpp` loads internal default settings from Qt resources, reads a
  target `default.vrsettings`, flattens category/key pairs into a settings map,
  emits change notifications, and writes JSON back using an `order.txt` file
  to preserve human-readable ordering despite Qt JSON ordering behavior.
  `default_settings.json` covers driver transport, HID/UART, PSM frequency,
  direct mode, headless mode, display geometry, IPD, FOV, distortion, HMD
  filter/Kalman offsets, controllers, trackers, and experimental drift
  correction.
- Code donor value:
  high for settings editor and ordered JSON-writing patterns.
- Product reference value:
  high for driver support tooling.
- Caveats:
  manually ordered writer and GUI tied to HadesVR schema.
- What to inspect next:
  extract a generic VR driver settings editor model.

## `dmcke5/DIY_VR_Controllers`

- GitHub:
  [dmcke5/DIY_VR_Controllers](https://github.com/dmcke5/DIY_VR_Controllers)
- What it is:
  HadesVR-compatible 3D printed wireless controller hardware and firmware.
- Interesting idea:
  a small variant repo can still add reusable lessons when it improves
  calibration UX and mechanical packaging around an existing ecosystem.
- Code-level notes:
  README documents 3D printed wireless controllers, BOM, PCB files, ISP
  flashing, IMU calibration, joystick/trigger calibration, and button labels.
  Firmware is a HadesVR Wand variant that adds joystick/trigger calibration
  variables and routines, analog trigger input, controller role switches, RF24,
  FastIMU, Madgwick filter, battery, and input payload fields.
- Code donor value:
  medium-high for calibration routine and hardware variant documentation.
- Product reference value:
  high for variant/fork lessons.
- Caveats:
  derived from HadesVR firmware and hardware-specific.
- What to inspect next:
  compare calibration UX with HadesVR Basic HMD serial calibration.

## `dietzus/DietzVR`

- GitHub:
  [dietzus/DietzVR](https://github.com/dietzus/DietzVR)
- What it is:
  currently a weak/empty candidate in the cloned state.
- Interesting idea:
  none extracted from source; the current clone only contains repository
  metadata and license files.
- Code-level notes:
  the local clone contained `.gitignore` and `LICENSE` only.
- Code donor value:
  none in the current state.
- Product reference value:
  none in the current state.
- Caveats:
  keep as rejected/weak candidate unless source appears later.
- What to inspect next:
  revisit only if future repository contents appear.

## Cross-project synthesis

Reusable lessons:

- hardware repos should include firmware, driver, settings, PCB, BOM, Gerbers,
  and mechanical files together;
- runtime drivers need explicit display geometry, direct/desktop display
  modes, distortion values, input profiles, and device properties;
- firmware packets should be versioned/typed enough for driver demux;
- HID/UART/RF transports need diagnostics and connection-state UX;
- calibration should be a guided workflow with visible state, not hidden magic;
- settings editors matter as much as the driver when the schema is large.

Best donor candidates:

- `HadesVR/HadesVR` for driver settings, device components, transport demux,
  and hardware docs;
- `relativty/Relativty` for minimal OpenVR HMD/HID bring-up;
- `HadesVR_GUI_Tool` for settings editor patterns;
- `Wand-Controller` and `DIY_VR_Controllers` for controller firmware and
  calibration variants.

## Reuse implications for `VR-apps-lab`

This wave suggests a `hardware bring-up and driver support` branch:

- OpenVR HMD bring-up anatomy;
- driver settings schema and GUI editor pattern;
- firmware packet and transport diagnostics checklist;
- controller input component and skeletal/haptic setup references;
- hardware documentation structure for PCB/BOM/STL/Firmware repos.

## Quality notes

- No found project was built, launched, installed, flashed, or run.
- Source clones were used only for code reading and are local-only.
