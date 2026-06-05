# GitHub Research Wave 131 Backlog

- Date: `2026-06-05`
- Scope: DIY headset hardware bring-up, OpenVR drivers, firmware, PCBs,
  controller packets, and settings GUI tooling.

## Completed in this wave

- Studied `relativty/Relativty` as a full DIY headset reference with firmware,
  OpenVR driver, HID pose ingestion, PCBs, Gerbers, and mechanical assets.
- Studied `HadesVR/HadesVR` as a richer DIY headset/controller/tracker stack
  with driver settings, RF/HID/UART transport, display geometry, filters, and
  controller/tracker OpenVR inputs.
- Studied `HadesVR/Wand-Controller` as HadesVR-compatible controller PCB and
  firmware reference.
- Studied `HadesVR/Basic-HMD-PCB` as a beginner HMD PCB and calibration
  reference.
- Studied `JX5S/HadesVR_GUI_Tool` as a Qt settings editor for driver JSON.
- Studied `dmcke5/DIY_VR_Controllers` as a HadesVR-compatible controller
  variant with joystick/trigger calibration.
- Rejected/deprioritized `dietzus/DietzVR` because the current clone contains
  no reusable source beyond license metadata.

## Reuse candidates

- `HadesVR/HadesVR` is the strongest donor for settings, driver components,
  transport demux, and controller/tracker mapping.
- `relativty/Relativty` is the strongest compact OpenVR HMD/HID bring-up donor.
- `HadesVR_GUI_Tool` is the strongest settings-editor donor.
- `Wand-Controller` and `DIY_VR_Controllers` are useful firmware/calibration
  variants.

## Follow-up backlog

1. Extract an OpenVR HMD driver bring-up anatomy note from Relativty and
   HadesVR.
2. Build a firmware packet/transport diagnostic checklist.
3. Compare driver settings schemas with GUI editor requirements.
4. Revisit DIY hardware only if a hardware-support prototype becomes active.

## Quality notes

- No found project was built, launched, installed, flashed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
