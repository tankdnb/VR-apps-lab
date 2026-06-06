# GitHub Research Wave 203 Backlog

- Date: `2026-06-06`
- Theme: `ContactGlove, Haritora, and vendor tracker bridge sidecars`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for ContactGlove OpenVR/OSC packages, glove input
  utilities, Haritora BLE/serial interpreters, Haritora to SlimeVR bridges, and
  camera/IMU fusion sidecars.
- `Done` Exclude already studied OpenGloves/LucidGloves ecosystem repos.
- `Done` Dedupe against SlimeVR, VMC, MediaPipe tracking, and external pose
  ingress waves.
- `Done` Freeze a shortlist that spans driver, avatar package, interpreter,
  SlimeVR bridge, and full runtime sidecar layers.

## Source Sync

- `Done` Confirm `freescuba` in local-only cache.
- `Done` Confirm `ContactGloveOSC` in local-only cache.
- `Done` Confirm `Glove2Kb` in local-only cache.
- `Done` Confirm `haritorax-slimevr-bridge` in local-only cache.
- `Done` Confirm `haritorax-interpreter` in local-only cache.
- `Done` Confirm `haritora-gx-poc` in local-only cache.
- `Done` Confirm `HaritoraToSlime` in local-only cache.
- `Done` Confirm `osc_haritorax2_camera_tracking` in local-only cache.

## Code Reading

- `Done` Inspect OpenVR driver activation, controller props, skeleton and haptic
  components, input/pose threads, named-pipe protocol, serial communication,
  COBS/CRC, overlay UI split, and input profiles in `freescuba`.
- `Done` Inspect Unity package structure, automatic setup window, VRChat avatar
  descriptor handling, parameter rename/copy tools, expression menus, and
  hand-sign animation assets in `ContactGloveOSC`.
- `Done` Inspect VMC/OSC `/VMC/Ext/Bone/Pos` hand-pose reception, wrist/finger
  origin correction, grip activation, pointer movement, and keyboard input
  mapping in `Glove2Kb`.
- `Done` Inspect BLE scan/connect, Haritora characteristic UUIDs, IMU decode,
  battery/main-button notifications, SlimeVR handshake, rotation/gravity sends,
  and UDP packet handling in `haritorax-slimevr-bridge`.
- `Done` Inspect TypeScript COM/Bluetooth/Linux-Bluetooth interpreter, tracker
  maps, settings, battery/mag/button/info events, and public EventEmitter API in
  `haritorax-interpreter`.
- `Done` Inspect Python GX serial echo server, tracker/battery/button parsing,
  and IMU decode proof-of-concept in `haritora-gx-poc`.
- `Done` Inspect OSC tracker handler, SlimeVR handshake, add-IMU packets,
  rotation/accel packet encoding, config, and broadcast discovery in
  `HaritoraToSlime`.
- `Done` Inspect receiver selection, camera subprocess/shared memory,
  preflight checks, fusion engine, event bus subscribers, REST/dashboard,
  config validation, calibration persistence, tests, and docs in
  `osc_haritorax2_camera_tracking`.

## Integration

- `Done` Create Wave 203 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for vendor protocol interpreters and tracking
  fusion/diagnostic sidecars.
- `Next` Build a ContactGlove/Haritora bridge matrix across transport,
  runtime output, calibration, safety, diagnostics, and maturity.
