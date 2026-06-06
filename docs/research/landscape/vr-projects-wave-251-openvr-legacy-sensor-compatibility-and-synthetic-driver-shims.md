# VR Projects Wave 251: OpenVR Legacy Sensor Compatibility and Synthetic Driver Shims

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies OpenVR/SteamVR driver-side adaptation projects for legacy
sensors, identity compatibility, no-HMD play, DIY HMD experiments, and
vendor/DIY headset bridges. The focus is not whether these should be used
today, but what driver boundaries they expose.

## Why It Matters For `VR-apps-lab`

Custom-device utilities often become fragile because hardware polling,
runtime registration, pose filtering, compatibility identity, calibration, and
user settings are coupled. These projects show how mature and rough drivers
separate or fail to separate those boundaries.

## Project Notes

### `SDraw/driver_leap`

- Interesting idea:
  a self-contained SteamVR driver can turn Leap Motion hand tracking into
  Index-like controllers plus a companion control/overlay app.
- Code donor value:
  `driver_leap/Core/CServerDriver.cpp` registers a Leap tracking reference and
  left/right controllers, starts a Leap poller, sets HMD tracking mode/policy,
  launches `leap_control.exe`, and updates device state in `RunFrame`.
  `CLeapStation.cpp` sets tracking-reference properties and render models.
  `CLeapIndexController.cpp` maps hand skeleton offsets, controller serials,
  input states, and skeleton transforms. `CLeapPoller.cpp` keeps the Leap
  connection and tracking event loop on a thread. `leap_control` adds hand and
  cursor overlays plus settings.
- Product reference value:
  strong donor for legacy sensor to controller-driver architecture.
- What to inspect next:
  compare skeleton/input mapping against OpenXR hand-tracking layers.
- Architecture pattern:
  Leap SDK poller -> hand frame/skeleton mapping -> OpenVR controller devices
  -> companion settings/overlay app.
- Reusable method:
  keep vendor polling, SteamVR device registration, skeleton mapping, and user
  settings in separate modules.
- Caveats:
  depends on Ultraleap runtime, Windows/OpenVR stack, legacy hand-tracking
  assumptions, and manual SteamVR driver activation.

### `SDraw/driver_kinectV1`

- Interesting idea:
  Kinect skeleton data can be exposed as configurable SteamVR generic trackers
  with an in-dashboard calibration surface.
- Code donor value:
  `CKinectHandler.cpp` initializes Kinect runtime 1.8 skeleton tracking and
  keeps filtered frame data. `CTrackerVive.cpp` exposes body joints as
  generic trackers with Vive Tracker-style properties, serials, controller
  type names, firmware/dongle fields, and battery state. `CalibrationHelper`
  uses controller axes and trigger state to adjust root position/rotation and
  saves the base transform.
- Product reference value:
  strong historical reference for body-joint-to-tracker mapping and dashboard
  calibration.
- What to inspect next:
  compare V1/V2 differences and whether the calibration model can inform
  modern camera tracker bridges.
- Architecture pattern:
  Kinect skeleton frames -> joint filters -> tracker devices -> dashboard
  calibration/settings.
- Reusable method:
  body trackers should expose joint enablement, smoothing, calibration, and
  base-transform visibility to users.
- Caveats:
  depends on obsolete Kinect runtime/hardware, Windows only, and spoofed Vive
  Tracker identity fields.

### `SDraw/driver_kinectV2`

- Interesting idea:
  the Kinect V2 fork repeats the body-joint-to-tracker architecture with a
  different Microsoft sensor runtime and similar dashboard UX.
- Code donor value:
  file layout mirrors the V1 driver: Kinect handler, joint filters, server
  driver, tracker device properties, and dashboard managers. README documents
  Kinect Runtime 2.0, tracker toggles, calibration transform, interpolation,
  and relay device state.
- Product reference value:
  useful comparison node for keeping sensor-specific code behind a common
  driver/dashboard pattern.
- What to inspect next:
  extract a shared "sensor skeleton to SteamVR tracker" template by comparing
  V1 and V2.
- Architecture pattern:
  Kinect V2 runtime -> skeleton frames -> generic trackers -> dashboard
  settings/calibration.
- Reusable method:
  isolate sensor runtime differences from the tracker identity and calibration
  surface.
- Caveats:
  legacy hardware/runtime, similar spoofed tracker identity caveats, and no
  modern OpenXR path.

### `schellingb/PseudoVive`

- Interesting idea:
  a load-first OpenVR driver can patch device properties so compatibility
  checks see Vive model/manufacturer names.
- Code donor value:
  README explains alphabetical driver load ordering, the `2vive` and
  `2vive_toggle` variants, and runtime systray toggling. `driver_2vive.cpp`
  uses MinHook around `IVRProperties::WritePropertyBatch`, stores original and
  replacement property values, and substitutes manufacturer/model names for
  HMDs, controllers, and tracking references.
- Product reference value:
  strong cautionary reference for compatibility shims and identity spoofing.
- What to inspect next:
  compare with current runtime compatibility gates and safer feature probes.
- Architecture pattern:
  early-loaded driver shim -> property write hook -> identity substitution ->
  optional tray toggle.
- Reusable method:
  when studying compatibility, distinguish feature detection from model-name
  checks and document the risk of spoofing.
- Caveats:
  hooks runtime property writes, intentionally misrepresents devices, and is
  useful as historical compatibility evidence rather than a default pattern.

### `r57zone/Half-Life-Alyx-novr`

- Interesting idea:
  a game-specific SteamVR driver can emulate HMD/controllers and map keyboard
  or mouse input to VR controller actions for no-HMD gameplay.
- Code donor value:
  README and setup docs document SteamVR driver install, render/window
  settings, room setup, launch options, and extensive key-to-controller
  bindings. `driver_sample.cpp` includes OpenVR driver sample code, INI
  parsing, key-name to virtual-key mapping, and simulated VR input. Legacy
  TrueOpenVR code defines HMD/controller structures and many action bindings.
- Product reference value:
  useful no-HMD/control-mapping reference and caveat-heavy retrofit example.
- What to inspect next:
  compare with other headsetless/virtual-HMD flows already tracked.
- Architecture pattern:
  SteamVR sample driver -> config-driven virtual display/HMD -> keyboard/mouse
  action mapping -> game-specific setup guide.
- Reusable method:
  no-HMD drivers need explicit binding docs, setup recipes, and game-specific
  caveats because the mapping is the product.
- Caveats:
  game-specific, fragile, includes piracy-adjacent setup notes in README,
  broad key injection, and not a general utility donor.

### `lixiangwuxian/Viulux-V9-Driver-for-SteamVR`

- Interesting idea:
  a vendor headset driver can stitch Relativty and OpenHMD lineage into a
  SteamVR driver for a specific device.
- Code donor value:
  this checkout is README-only. The README documents Viulux V9, Relativty and
  OpenHMD lineage, 3DoF/6DoF with Nolo kit, Nolo controller tracking/buttons,
  vibration, double-click calibration/turn actions, and prominent bug notes.
- Product reference value:
  useful source-light hardware-bridge reference, mainly as cautionary lineage.
- What to inspect next:
  inspect the linked `Viulux-Driver` source before treating it as code donor.
- Architecture pattern:
  vendor headset display/IMU + OpenHMD/Relativty lineage + Nolo tracking kit ->
  SteamVR driver.
- Reusable method:
  hardware bridge notes should separate claimed features, required accessory
  kits, bugs, and source availability.
- Caveats:
  no implementation source in this checkout, external download links, known
  startup/controller bugs, and user-risk warning.

### `Blockmann2K/MurlokVR`

- Interesting idea:
  a DIY headset experiment can split firmware, Rust host runtime, shared
  memory pose transport, and OpenVR HMD driver.
- Code donor value:
  `src/firmware` contains Rust embedded bring-up around BNO08x. `src/host`
  separates a Rust runtime from an OpenVR driver. `runtime/src/main.rs` reads
  serial quaternion data, writes shared memory, and uses a sequence counter.
  `driver/src/hmd_driver_factory.cpp` exposes `HmdDriverFactory`,
  `device_provider.cpp` registers an HMD, `hmd_device_driver.cpp` reads driver
  settings, creates input components, starts a pose update thread, and reads
  snapshots through `shared_memory.h` using a seqlock-like pattern.
- Product reference value:
  good educational donor for DIY HMD driver boundaries, even if immature.
- What to inspect next:
  inspect display component, firmware packet schema, and hardware docs in a
  future DIY headset pass.
- Architecture pattern:
  firmware IMU -> serial host runtime -> shared memory pose buffer -> OpenVR
  HMD driver.
- Reusable method:
  use a tiny shared-memory pose contract between a hardware runtime and VR
  driver instead of putting serial parsing inside the driver.
- Caveats:
  early WIP, hardcoded COM port, partial display/pose maturity, Windows shared
  memory, and educational sample-driver lineage.

## Reusable Pattern Extraction

- Pattern candidate:
  OpenVR compatibility driver boundary for legacy sensors and synthetic
  devices.
- Problem solved:
  legacy or DIY hardware needs to enter SteamVR without coupling sensor IO,
  identity, calibration, pose transport, and driver registration into one blob.
- Reusable core:
  driver manifest, factory/provider, hardware or shim source, device identity,
  pose/input contract, calibration/settings surface, companion control app,
  compatibility caveats, and unload/cleanup path.
- Source evidence:
  `driver_leap`, `driver_kinectV1`, `driver_kinectV2`, `PseudoVive`,
  `Half-Life-Alyx-novr`, `Viulux-V9-Driver-for-SteamVR`, and `MurlokVR`.
- Abstraction boundary:
  separate sensor/runtime IO from SteamVR device registration, and separate
  compatibility shims from real feature support.
- What not to copy:
  model-name spoofing as normal compatibility, obsolete SDKs without caveats,
  global key injection as a default UX, README-only hardware claims as code
  evidence, or hardcoded serial ports as architecture.
- Method catalog action:
  add a method entry for OpenVR compatibility driver boundaries.

## Follow-Up Gaps

- Build a driver-boundary matrix comparing Leap, Kinect, PseudoVive, no-HMD,
  vendor headset, and DIY HMD approaches.
- Deepen the relationship between legacy OpenVR drivers and modern OpenXR hand,
  tracker, and virtual-device patterns.
- Extract a minimal safe checklist for driver manifests, device identity,
  settings, calibration, and cleanup.
