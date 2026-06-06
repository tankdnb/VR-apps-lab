# VR Projects Wave 227: OpenGloves DIY Haptics Adapters, Named Pipes, and Firmware Variants

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-227-plan.md`
- `docs/research/program/github-research-wave-227-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

OpenGloves-style projects are valuable because they expose a reusable boundary:
DIY hardware and firmware produce finger data, a bridge normalizes and sends it
to a driver protocol, and haptic output travels back to physical actuators.
This wave studies small converters and variants to document that boundary
without treating every fork as a new full product.

## Project Findings

### `SparkleTech-VR/OpenPulseConverter`

- Interesting idea: a hardware-specific converter can adapt BiFrost Pulse HID
  reports into OpenGloves input data and translate OpenGloves haptic output
  back into Pulse-friendly feedback values.
- Code donor value: high for adapter-boundary evidence, not for direct copying.
  `OpenPulseConverter.cpp` opens Pulse HID devices by VID/PID, connects to
  OpenGloves v2 named pipes, reads Pulse reports, extracts pull/splay bits,
  calibrates spread/flat/fist positions, clamps and normalizes flexion/splay,
  maps gesture/button fields, writes `OpenGloveInputData`, reads
  `OutputStructure` force-feedback values, and converts per-finger haptics.
  `InputTypes.h` documents Pulse bit extraction and `OPGData.h` documents the
  OpenGloves input/output structs.
- Product reference value: medium for converter sidecars and DIY haptic
  bridges.
- Architecture pattern: HID hardware adapter plus calibration/normalization
  plus OpenGloves named-pipe sink plus haptic feedback source.
- Reusable method: isolate hardware packet parsing from the normalized
  OpenGloves data contract.
- Constraints and caveats: WIP code, Windows named-pipe coupling, rough naming
  and globals, hardcoded VID/PID and pipe paths, crash/destructor comments, and
  hardware-specific haptic math.
- What to inspect next: old implementation, filter tuning, error/reconnect
  handling, and whether haptic timing/duration is actually respected.
- Why it matters for `VR-apps-lab`: it is one of the clearest examples of the
  full hardware-to-driver-to-haptics adapter loop.

#### Reusable Pattern Extraction

- Pattern candidate: OpenGloves-compatible adapter boundary for DIY haptic
  glove variants.
- Problem solved: DIY glove projects vary by sensors, firmware, transport, and
  haptic hardware, but VR tools need a stable normalized hand and force-feedback
  contract.
- Reusable core: hardware transport adapter, packet decoder, calibration model,
  normalized flexion/splay/buttons/trigger schema, driver sink, haptic source,
  output scaling, and explicit variant caveats.
- Source evidence: OpenPulseConverter HID/parser/pipe/haptics code,
  `opengloves-named-pipe-example` v2 struct writer, GloveBridge BLE/pipe flow,
  Compact Gloves firmware/docs, and ExoTouch LucidGloves firmware variant.
- Abstraction boundary: firmware, transport, converter sidecar, normalized
  input schema, driver protocol, haptic feedback schema, and hardware actuator
  scaling should be separate.
- What not to copy: forked firmware wholesale, hardcoded pins/pipe names,
  WIP converter globals, unguarded hardware feedback math, or thin examples as
  complete product architecture.
- Method catalog action: create Method 672.

### `danwillm/opengloves-named-pipe-example`

- Interesting idea: the smallest useful OpenGloves donor is the pipe contract
  itself: connect to a hand pipe, fill a data struct, and write it repeatedly.
- Code donor value: medium as a minimal contract reference. `main.cpp` defines
  a `NamedPipe<T>` wrapper over Windows `CreateFileA`, `WaitNamedPipeA`, and
  `WriteFile`, then defines `v2PipeData` with flexion, splay, joystick, button,
  grab, pinch, menu, calibrate, and trigger value fields.
- Product reference value: low by itself, high as a test fixture idea for
  driver or adapter experiments.
- Architecture pattern: tiny named-pipe writer around a stable normalized hand
  struct.
- Reusable method: create protocol examples that exercise the sink without
  needing real hardware.
- Constraints and caveats: Windows-only, writes synthetic data forever, no
  haptic read path, no validation UI, and no product shell.
- What to inspect next: matching OpenGloves driver pipe versions and output
  pipe contracts.
- Why it matters for `VR-apps-lab`: it gives a clean minimal baseline for
  documenting OpenGloves input shape.

### `DasKatzchen/GloveBridge`

- Interesting idea: a Python bridge can discover BLE glove devices, read GATT
  data, write driver input pipes, read force-feedback pipes, and send haptic
  output back over BLE.
- Code donor value: low to medium. `Glovebridge.py` defines target left/right
  devices, v1 OpenGloves input and force-feedback pipe paths, Nordic UART-like
  characteristic UUIDs, background BLE scanning, per-device connection tasks,
  BLE read to pipe write, pipe read to BLE write, and rediscovery after errors.
- Product reference value: medium for BLE bridge sidecars and quick hardware
  experiments.
- Architecture pattern: async BLE discovery plus per-device bidirectional pipe
  bridge.
- Reusable method: keep discovery/reconnect as a background task separate from
  per-device read/write loops.
- Constraints and caveats: missing `BleakError` import in inspected source,
  string writes to binary-ish pipe paths, placeholder UUID comments, sparse
  README, and unfinished format assumptions.
- What to inspect next: actual packet formats, pipe open modes, exception
  handling, and compatibility with current OpenGloves driver versions.
- Why it matters for `VR-apps-lab`: it shows the simplest bridge shape for BLE
  hardware even when implementation quality is early.

### `Stargazer6481/Compact-Gloves`

- Interesting idea: a DIY glove repo can be valuable as product documentation:
  BOM, printing, wiring, firmware, driver setup, calibration, and user-facing
  constraints are all part of the reusable pattern.
- Code donor value: medium. The firmware reads ESP32 flex sensors, joystick,
  trigger, and buttons, builds an OpenGloves-like data string, and sends it over
  Bluetooth Serial while echoing over USB Serial. Docs cover OpenGloves driver
  setup, communication selection, standard data format notes, and calibration.
- Product reference value: high for hardware onboarding and DIY user flow.
- Architecture pattern: hardware documentation plus simple firmware plus
  OpenGloves driver pairing plus calibration guide.
- Reusable method: document hardware-adjacent utilities as an end-to-end build,
  flash, driver, calibrate, and troubleshoot path.
- Constraints and caveats: repo badges and some wiki links look placeholder-like,
  firmware is compact and hardware-specific, and OpenGloves parser alignment
  needs verification.
- What to inspect next: hardware STLs/STEP files, left-hand firmware, wiring
  diagrams, and actual OpenGloves parser compatibility.
- Why it matters for `VR-apps-lab`: it adds a documentation/onboarding pattern
  for future physical-device research notes.

### `xRayz3n/ExoTouch-2.0`

- Interesting idea: a LucidGloves-derived firmware can adapt to exoskeleton
  hardware with AS5600 encoders, I2C multiplexer selection, calibration loops,
  serial/Bluetooth output, and servo-based force feedback.
- Code donor value: medium as a firmware-variant reference. `_main.ino` owns
  communication selection, input setup, calibration loops, gesture/button
  logic, output encoding, haptic readback, and loop timing. `input.ino` reads
  AS5600 sensors through a multiplexer, tracks min/max calibration, maps raw
  values to an analog range, supports deadzones, and reads buttons. `Encoding.ino`
  supports legacy and alphabetic formats. `haptics.ino` maps OpenGloves haptic
  limits to servo positions. `AdvancedConfig.h` contains encoding, loop,
  calibration, clamp, and median-filter options.
- Product reference value: medium for force-feedback glove variants and
  hardware documentation.
- Architecture pattern: LucidGloves-compatible firmware core plus
  hardware-specific sensor and haptic modules.
- Reusable method: separate communication, input acquisition, encoding,
  gestures, calibration, and haptic output in firmware variants.
- Constraints and caveats: derivative firmware, hardware-specific pins and
  mechanics, possible bugs in dynamic scaling loops, and not a new driver
  architecture.
- What to inspect next: encoder debug sketch, servo safety limits, hardware
  assembly tolerances, and current LucidGloves upstream differences.
- Why it matters for `VR-apps-lab`: it helps document how variants should be
  treated as boundary lessons rather than duplicate primary projects.

## Cross-Project Synthesis

OpenGloves-compatible DIY hardware should be documented as a chain:

- sensor/hardware module: flex sensor, encoder, button, joystick, servo, or
  haptic actuator;
- firmware module: calibration, filtering, encoding, and transport;
- transport: USB Serial, Bluetooth Serial, BLE GATT, HID, or named pipe;
- converter sidecar: packet decode, normalization, validation, and reconnect;
- driver sink: OpenGloves v1/v2 input contract;
- haptic source: force-feedback output contract and actuator scaling;
- user flow: build, flash, pair, configure driver, calibrate, test, and recover.

For `VR-apps-lab`, this wave strengthens haptic bridge, DIY hardware,
physical-output safety, and adapter-boundary documentation.
