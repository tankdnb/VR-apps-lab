# VR Projects Wave 124: VR Treadmill Locomotion, Hardware Input Adapters, and Virtual Controller Bridges

- Date: `2026-06-05`
- Goal: study small VR treadmill and locomotion-hardware projects as reusable
  references for sensor-to-input bridges, virtual controller output, hardware
  status surfaces, and thin locomotion utilities.

## Why this wave exists

Locomotion hardware projects are rarely polished products, but they expose
valuable reusable seams:

- sensor capture;
- calibration and thresholding;
- smoothing or latency tradeoffs;
- keyboard, gamepad, OpenVR driver, BLE, serial, and TCP output;
- hardware readiness diagnostics;
- user-facing safety states such as standing, walking, jump, absent, stop, and
  reconnect.

This wave treats treadmill projects as input-adapter and bridge references, not
as dependencies to run from `VR-apps-lab`.

## Better workflow used in this wave

1. searched GitHub by VR treadmill, walk-in-place, balance-board, serial
   treadmill, OpenVR treadmill driver, and Unity controller relay families;
2. deduplicated against the registry and existing locomotion/input bridge
   families;
3. froze a bounded shortlist;
4. inspected local source clones under `.research-sources/github/`;
5. avoided running, building, installing, or launching any project;
6. extracted donor value, product value, caveats, family placement, and
   reusable methods.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `fer-sler/VR-Treadmill` | Minimal mouse-delta to virtual-gamepad treadmill proof |
| `TimStewartJ/vr-treadmill` | More mature Windows mouse-to-ViGEm bridge with settings and driver readiness checks |
| `Cycrus/slimstep_vr` | End-to-end load-cell, serial, and OpenVR virtual controller driver |
| `jurassicjordan/GoobleBoxVR` | Wii Balance Board to keyboard or virtual joystick adapter with locomotion-state detection |
| `srepmub/tacovr` | Arduino treadmill control loop with Pixy sensors and stepper state machine |
| `ssohbn/kittywalk-server` | Minimal Rust TCP receiver for treadmill byte payloads |
| `cybernetic-research/VR-treadmill-client-app` | Unity/Quest controller-state relay over TCP |
| `cybernetic-research/VR-treadmill-server-app` | ESP32 BLE command/status firmware for treadmill control |

## Deep-pass notes by project

## `fer-sler/VR-Treadmill`

- GitHub:
  [fer-sler/VR-Treadmill](https://github.com/fer-sler/VR-Treadmill)
- What it is:
  a small Python mouse-delta to virtual Xbox gamepad adapter.
- Interesting idea:
  the simplest possible treadmill adapter can recenter the mouse, treat vertical
  delta as locomotion intent, smooth it, clamp it, and write the result to a
  virtual gamepad stick.
- Code-level notes:
  `treadmill.py` combines `pynput`, PyQt6 controls, and `vgamepad`. It polls
  mouse Y movement, recenters the pointer to a fixed screen coordinate, averages
  recent delta, clamps output into `[-32768, 32767]`, sends left-stick Y, and
  exposes sensitivity, polling rate, and stop-key controls.
- Code donor value:
  medium for a very small mouse-delta-to-gamepad bridge loop.
- Product reference value:
  medium as a proof that locomotion helpers can be tiny single-value adapters.
- Caveats:
  hardcoded screen position, global state, and prototype UI assumptions.
- What to inspect next:
  compare with `TimStewartJ/vr-treadmill` for driver readiness, settings, and
  safer loop cleanup.

## `TimStewartJ/vr-treadmill`

- GitHub:
  [TimStewartJ/vr-treadmill](https://github.com/TimStewartJ/vr-treadmill)
- What it is:
  a Windows Python treadmill utility that converts mouse movement into a
  ViGEm-backed virtual gamepad.
- Interesting idea:
  a thin adapter becomes much more reusable when it has explicit config,
  runtime status, driver probing, atomic settings, and guaranteed gamepad reset
  behavior.
- Code-level notes:
  `src/vrtread/engine.py` defines `TreadmillConfig` and `TreadmillStatus`,
  accumulates mouse deltas through a listener, recenters cursor via `user32`,
  applies sensitivity, decay, deadzone, and an update loop thread, calls
  `timeBeginPeriod(1)`, and resets the virtual gamepad in `finally`.
  `driver.py` probes the ViGEmBus service with `sc.exe query` and exposes a
  `DriverStatus`. `settings.py` persists validated JSON settings atomically
  under `%APPDATA%`.
- Code donor value:
  high for adapter status, settings, driver readiness, and cleanup boundaries.
- Product reference value:
  high for a small but user-facing locomotion bridge.
- Caveats:
  Windows and ViGEm-specific.
- What to inspect next:
  use as the baseline for a generic `input bridge readiness panel` method.

## `Cycrus/slimstep_vr`

- GitHub:
  [Cycrus/slimstep_vr](https://github.com/Cycrus/slimstep_vr)
- What it is:
  a load-cell treadmill project with Arduino capture and an OpenVR server
  driver that exposes scalar controller inputs.
- Interesting idea:
  a hardware sensor can be promoted into VR as a controller-like tracked device
  even when the pose itself is invalid, as long as the scalar input components
  are stable and named predictably.
- Code-level notes:
  `load_cell_module.ino` reads HX711 load cells and sends normalized serial
  values while explicitly avoiding EMA smoothing because of latency. The
  OpenVR driver adds a controller-class tracked device, sets role and input
  profile metadata, creates scalar components for trigger, trackpad Y, and
  joystick Y, keeps X axes at zero, reads serial COM ports through a SetupAPI
  friendly-name match, and reconnects after read errors.
- Code donor value:
  very high for sensor-to-serial-to-OpenVR-controller plumbing.
- Product reference value:
  high for hardware adapter diagnostics and scalar input design.
- Caveats:
  old OpenVR driver assumptions and hardware-specific serial discovery.
- What to inspect next:
  compare with virtual tracker/input emulator families for naming and action
  binding conventions.

## `jurassicjordan/GoobleBoxVR`

- GitHub:
  [jurassicjordan/GoobleBoxVR](https://github.com/jurassicjordan/GoobleBoxVR)
- What it is:
  a Linux Wii Balance Board adapter that converts joystick device events into
  keyboard or virtual joystick output.
- Interesting idea:
  locomotion state can be derived from simple balance-board axis patterns:
  standing, walking, one-foot stance, jump, and user absence.
- Code-level notes:
  `gooblebox.py` scans `/dev/input/js*`, offers Zenity or terminal selection,
  reads Linux joystick event packets with `struct.unpack`, normalizes axes,
  classifies walking, flamingo stance, jump, and absence by thresholds and
  hold timers, then emits either `pyautogui` key events or `vgamepad` output.
- Code donor value:
  medium-high for state classification and fallback device-selection UX.
- Product reference value:
  medium for low-cost accessibility and DIY locomotion experiments.
- Caveats:
  Linux joystick device assumptions and prototype terminal/Zenity UI.
- What to inspect next:
  extract a hardware-state taxonomy for balance-board, treadmill, and load-cell
  bridges.

## `srepmub/tacovr`

- GitHub:
  [srepmub/tacovr](https://github.com/srepmub/tacovr)
- What it is:
  an Arduino/Infento omnidirectional treadmill control experiment.
- Interesting idea:
  treadmill firmware can be structured as a calibrated foot-sensor state
  machine before any VR runtime integration exists.
- Code-level notes:
  `tacovr.ino` uses Pixy sensors over I2C, AccelStepper motors, left/right
  calibration positions, and a state machine with `INIT_L`, `WAIT_L`, `STEP_L`,
  `WAIT_R`, and `STEP_R`. It prints serial diagnostics while moving motors to
  keep foot positions centered.
- Code donor value:
  medium for hardware-side calibration and state-machine framing.
- Product reference value:
  medium for understanding physical locomotion control loops.
- Caveats:
  highly hardware-specific and not directly a VR utility app.
- What to inspect next:
  compare firmware-side state events with host-side bridge states.

## `ssohbn/kittywalk-server`

- GitHub:
  [ssohbn/kittywalk-server](https://github.com/ssohbn/kittywalk-server)
- What it is:
  a tiny Rust TCP receiver for treadmill payload bytes.
- Interesting idea:
  even a minimal server can be useful as a protocol probe when hardware emits
  very small fixed-size payloads.
- Code-level notes:
  `src/main.rs` listens on `127.0.0.1:1300`, accepts clients, reads 3-byte
  buffers, and prints them.
- Code donor value:
  low-medium for the smallest possible TCP payload receiver.
- Product reference value:
  low-medium as a protocol-probe micro-utility.
- Caveats:
  no semantic protocol model beyond raw bytes.
- What to inspect next:
  keep as a comparison node for hardware ingress probes.

## `cybernetic-research/VR-treadmill-client-app`

- GitHub:
  [cybernetic-research/VR-treadmill-client-app](https://github.com/cybernetic-research/VR-treadmill-client-app)
- What it is:
  a Unity/Quest client that relays XR controller joystick state to a TCP bridge.
- Interesting idea:
  a headset-side client can act as the control surface for external treadmill
  hardware by sending only changed controller state.
- Code-level notes:
  `JoystickListener.cs` enumerates left and right XR `InputDevice` instances,
  reads `CommonUsages.primary2DAxis`, detects movement above a minimum delta,
  serializes controller joystick state, and sends it through a TCP helper.
  The paired C# bridge server listens on `127.0.0.1:50505`.
- Code donor value:
  medium for Quest/Unity controller-state relay anatomy.
- Product reference value:
  medium-high for external-device control surfaces.
- Caveats:
  sample-level project with many starter assets.
- What to inspect next:
  compare with OpenXR/OSC controller-state bridges before designing any
  generic relay.

## `cybernetic-research/VR-treadmill-server-app`

- GitHub:
  [cybernetic-research/VR-treadmill-server-app](https://github.com/cybernetic-research/VR-treadmill-server-app)
- What it is:
  ESP32 BLE treadmill server firmware plus small test utility material.
- Interesting idea:
  physical treadmill control can be exposed as a tiny BLE service with separate
  control and status characteristics.
- Code-level notes:
  `vr-treadmill-server.ino` defines a BLE service with control and status
  characteristics, sets `STOPPED`/`RUNNING` states, accepts writes, notifies
  status, drives an output pin, resets state on disconnect, and restarts
  advertising.
- Code donor value:
  medium for minimal BLE command/status firmware.
- Product reference value:
  medium for external-device control loop design.
- Caveats:
  firmware-specific and intentionally narrow.
- What to inspect next:
  compare BLE command/status shape with TCP and serial treadmill bridges.

## Cross-project synthesis

This wave adds a reusable `locomotion hardware bridge` pattern:

- capture raw sensor or controller state;
- normalize it into a small locomotion/status model;
- add calibration, thresholds, smoothing, and stop/reset behavior;
- expose output as keyboard, virtual gamepad, OpenVR input components, BLE,
  serial, or TCP;
- surface driver/device readiness early;
- treat reconnect and cleanup as part of product UX, not only engineering
  plumbing.

The strongest code donors are `vr-treadmill` for host-side adapter hygiene and
`slimstep_vr` for sensor-to-OpenVR input plumbing.

## Follow-up

1. Extract a generic hardware-input bridge checklist: discovery, calibration,
   status, output schema, reset, and diagnostics.
2. Compare locomotion bridge states with accessibility, simulator, and
   virtual-controller families.
3. Avoid promoting hardware-specific treadmill code into prototypes unless a
   concrete utility branch needs it.
