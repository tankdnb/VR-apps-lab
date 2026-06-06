# GitHub Research Wave 227 Backlog

Date: 2026-06-06

Theme: OpenGloves DIY haptics adapters, named pipes, and firmware variants.

## Completed In This Wave

- Studied `SparkleTech-VR/OpenPulseConverter` as a WIP HID-to-OpenGloves
  converter with Pulse VID/PID discovery, pull/splay bit extraction,
  calibration prompts, normalized flexion/splay output, named-pipe writes,
  OpenGloves force-feedback reads, haptic conversion, and many rough-code
  caveats.
- Studied `danwillm/opengloves-named-pipe-example` as the minimal v2 pipe
  contract reference: connect to `left` or `right` named pipe, fill flexion,
  splay, joystick, button, menu, calibrate, and trigger fields, then write at a
  tight loop.
- Studied `DasKatzchen/GloveBridge` as a small Python BLE-to-named-pipe bridge
  with target device names, pipe paths, GATT read/write loops, and rediscovery
  behavior, while noting missing imports and unfinished format assumptions.
- Studied `Stargazer6481/Compact-Gloves` as a DIY product/reference with BOM,
  hardware docs, printing/assembly docs, ESP32 Bluetooth Serial firmware,
  OpenGloves driver setup, standard format notes, and calibration guidance.
- Studied `xRayz3n/ExoTouch-2.0` as a LucidGloves firmware/hardware variant
  with AS5600 encoder input, I2C multiplexer selection, calibration loops,
  alphabetic encoding, serial/Bluetooth communication abstraction, and servo
  force-feedback output.
- Added a reusable method entry for OpenGloves-compatible DIY haptics adapter
  boundaries.

## Follow-Up Queue

1. Build an OpenGloves adapter boundary matrix across named pipes, BLE,
   Bluetooth Serial, USB Serial, HID, firmware packets, calibration, and
   haptic output.
2. Compare OpenGloves v1/v2 pipe formats, LucidGloves string formats, Compact
   Gloves format notes, and ExoTouch alphabetic encoding.
3. Extract a neutral `finger data`, `splay`, `buttons`, `trigger`, `haptics`,
   `calibration`, and `transport` schema.
4. Compare hardware documentation quality across Compact Gloves, ExoTouch,
   LucidGloves, and earlier DIY headset/controller waves.
5. Revisit safety boundaries for force-feedback hardware before any haptic
   prototype is promoted.

## Do Not Spend Time On Yet

- Do not flash firmware, pair BLE devices, open OpenGloves pipes, or run
  converter examples.
- Do not copy forked firmware wholesale into `VR-apps-lab`.
- Do not treat thin examples or rough WIP converters as production quality.
