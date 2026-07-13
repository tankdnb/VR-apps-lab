# VR Projects Wave 413 - Runtime Retrofit SLAM And OpenXR Engine Substrates

- Date: `2026-07-13`
- Scope: larger runtime, game, SLAM, and engine substrates that show how OpenXR
  or Monado integration crosses app, hardware, and tracking boundaries.
- Rule: source/documentation reading only; no builds, installs, launches, or
  device tests were performed.

## Shortlist

- `mcxr-org/MCXR`
- `alexstrei/Custom-VR`
- `CIFASIS/basalt-xr`
- `Adrian-Hirt/XRe`

## Project Notes

### `mcxr-org/MCXR`

- Interesting idea: Minecraft VR/AR mod using OpenXR and Fabric, split into
  `mcxr-core`, `mcxr-play`, and controls.
- Code donor value: useful game-retrofit reference for mod-bound OpenXR
  integration, title/world UX caveats, Java/LWJGL OpenXR structs, and
  first-person object rendering adjustments.
- Product reference value: shows how a non-VR game ecosystem can expose VR mode
  while preserving non-VR/server compatibility boundaries.
- Source evidence: README comparison table, `mcxr-core`, `mcxr-play`,
  `controls`, OpenXR Java wrappers, and first-person map renderer.
- Reusable core: split base mod support from active VR play layer and keep
  server/non-VR compatibility explicit.
- What not to copy: archived status and game-specific mixin strategy.
- What to inspect next: how modded UI, controls, and world scale are separated
  from core OpenXR runtime setup.

### `alexstrei/Custom-VR`

- Interesting idea: 3D-printable custom headset project combining mechanical
  design, part list, Monado driver integration, and Basalt binaries.
- Code donor value: useful hardware-boundary reference for BOM, printed case,
  display/IPD modules, driver fork location, and setup documentation.
- Product reference value: reinforces that DIY XR projects need provenance,
  assembly docs, driver/runtime docs, and realistic experimental disclaimers.
- Source evidence: README, `Headset/`, `Monado/`, `imgs/`, and included PDF.
- Reusable core: hardware project envelope: BOM, printable parts, runtime fork,
  tracking dependency, assembly media, and status caveats.
- What not to copy: compiled binaries or hardware claims without verification.
- What to inspect next: map its Monado fork and Basalt dependency into a
  device-driver bring-up checklist.

### `CIFASIS/basalt-xr`

- Interesting idea: Basalt fork improved for tracking XR devices with Monado,
  including dataset and real-device notes.
- Code donor value: useful SLAM/tracking substrate reference: environment
  variables, `libbasalt.so` discovery by Monado, dataset replay, debug GUI
  flags, RealSense notes, calibration/config files, and development docs.
- Product reference value: gives a concrete example of XR tracking as a service
  dependency rather than an app feature.
- Source evidence: README sections for `VIT_SYSTEM_LIBRARY_PATH`, Monado dataset
  usage, `SLAM_CONFIG`, `SLAM_SUBMIT_FROM_START`, `XRT_DEBUG_GUI`, and docs.
- Reusable core: tracking backend adapter with dataset replay path, calibration
  config, runtime library discovery, debug UI, and device support caveats.
- What not to copy: full third-party SLAM code or dataset setup as app runtime
  logic.
- What to inspect next: extract SLAM/debug environment matrix for Monado-based
  utilities.

### `Adrian-Hirt/XRe`

- Interesting idea: WIP XR engine from scratch with OpenXR and Vulkan,
  simulation/render split, OBJ loading, text/bitmap/line rendering, controller
  tracking, grab movement, teleporting, highlighting, and basic hand tracking.
- Code donor value: useful full-stack educational engine reference where
  `Application`, `OpenXrHandler`, scene/model/material/resource managers, and
  components are explicitly named.
- Product reference value: shows how to grow from bring-up sample to reusable
  utility engine primitives without hiding scene, input, and resource layers.
- Source evidence: README feature list and `include/xre/application.h` imports
  for OpenXR handler, scene, resource, grabbable, and button components.
- Reusable core: application shell with simulation update, render pass, resource
  manager, scene components, input picking/highlight, teleport, and grab.
- What not to copy: WIP status and bundled external dependencies wholesale.
- What to inspect next: compare its component model with Unity/Godot interaction
  envelopes already cataloged.

## Extracted Method Candidate

`Runtime substrate boundary map`: for bigger XR integrations, document app/game
layer, runtime driver, tracking backend, calibration/config, render engine,
input/control layer, and compatibility mode as separate adapter surfaces.
