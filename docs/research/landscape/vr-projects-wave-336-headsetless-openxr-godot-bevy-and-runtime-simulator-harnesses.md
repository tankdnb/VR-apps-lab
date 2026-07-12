# Wave 336 - Headsetless OpenXR, Godot, Bevy, and Runtime Simulator Harnesses

This wave studies simulator workflows that let XR utilities be developed,
debugged, or demonstrated without a physical headset in the loop.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to runtime-level OpenXR simulators, engine/editor simulator
plugins, keyboard/mouse/gamepad/UDP/replay-driven pose injection, and runtime
operator architecture lessons.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `jrng/openxr_simulator` | OpenXR runtime simulator | Studied | Runtime-level donor for loader negotiation, session/view/swapchain stubs, keyboard/mouse HMD control, and D3D11/OpenGL surface paths |
| `Cafezinhu/godot-vr-simulator` | Godot editor XR simulator | Studied | Compact editor autoload that injects XR camera/controller tracker poses and OpenXR action-map button inputs from keyboard/mouse |
| `sanky369/OpenXRSim` | Unreal XR simulator plugin | Studied | Strong Unreal simulator donor with HMD/input-device modules, Slate panel, room JSON, XInput, UDP forwarding, and record/replay |
| `kcking/bevy_xr_app` | Rust/Bevy XR starter with simulator | Studied | Product reference for keeping simulator, editor, Quest, PCVR, and app-shell flows in one starter template |
| `demonixis/OpenXR-OSX` | Cross-platform runtime selector and streaming client | Studied as architecture reference | Broad runtime reference for runtime JSON selection, Home apps, Quest/PICO client telemetry, Unity editor helper, and simulator windows |

## Code-Level Findings

### `jrng/openxr_simulator`

- Interesting idea: a lightweight OpenXR runtime can act as the simulator
  boundary, letting ordinary OpenXR apps launch against a desktop window.
- Code donor value: high conceptually. `runtime.c` implements loader
  negotiation, instance/session creation, stereo view configuration, swapchains,
  frame lifecycle, action paths, and `xrLocateViews` from simulated head pose.
- Product reference value: high for an OpenXR doctor/simulator product branch.
- What to inspect next: action-state completeness, controller emulation depth,
  runtime manifest registration safety, and graphics API coverage.
- Caveat: low-level C runtime code is brittle to copy directly; reuse the
  boundary and manifest model, not the whole runtime.

### `Cafezinhu/godot-vr-simulator`

- Interesting idea: a Godot editor autoload can discover XR nodes, create
  missing trackers, and drive controller poses/actions without changing app
  scenes.
- Code donor value: medium-high. `XRSimulator.gd` maps WASD/arrows to joystick
  inputs, Q/E selection to left/right controllers, mouse motion/scroll to pose
  changes, mouse buttons to trigger/grip, and keys to action-map names.
- Product reference value: high for a future engine-neutral "simulate hands and
  controllers" checklist.
- What to inspect next: Godot 4 compatibility, controller profile variance,
  action-map validation, and cleanup when scenes reload.

### `sanky369/OpenXRSim`

- Interesting idea: Unreal simulator support can be modeled as a real XR system
  plugin rather than a scene-only mock.
- Code donor value: high. The plugin splits `IHeadMountedDisplayModule`,
  `IXRTrackingSystem`, `IStereoRendering`, `IInputDevice`, shared simulator
  state, room subsystem, Slate panel, UDP JSON forwarding, XInput support, and
  JSON record/replay.
- Product reference value: very high for repeatable XR utility tests.
- What to inspect next: replay JSON schema, data-forward packet schema, HMD
  plugin priority behavior, and functional automation tests.
- Caveat: Unreal-only and not a full OpenXR runtime; do not confuse engine
  simulation with loader/runtime emulation.

### `kcking/bevy_xr_app`

- Interesting idea: an app starter can normalize simulator, editor, Quest, and
  PCVR development modes in one documented template.
- Code donor value: medium. The important lesson is feature-gated simulator
  support and clear build-mode separation more than a standalone utility.
- Product reference value: medium-high for Rust/Bevy XR onboarding.
- What to inspect next: simulator feature internals, controller entity model,
  Bevy editor coexistence, and Android packaging assumptions.

### `demonixis/OpenXR-OSX`

- Interesting idea: a runtime ecosystem can include Home apps, runtime JSON
  selection, headset clients, Unity editor helpers, streaming telemetry, and
  simulator windows as one operator surface.
- Code donor value: medium as bounded helpers. `scripts/unity` shows a Unity
  editor runtime selector and macOS OpenXR loader postprocessor; docs describe
  runtime status, transport readiness, ADB reverse setup, Quest/PICO client
  telemetry, and simulator windows.
- Product reference value: high for future runtime-operator utilities.
- What to inspect next: protocol docs, Home app runtime-state model, USB/WiFi
  transport readiness UI, and simulator fallback behavior.

## Reusable Pattern Extraction

- Pattern candidate: no-headset XR simulator harness.
- Problem solved: XR utilities need repeatable development, demos, and
  diagnostics even when a headset is unavailable, uncomfortable, or too slow to
  put on for every iteration.
- Reusable core: simulator boundary, runtime/editor registration, HMD pose
  model, controller pose/action model, keyboard/mouse/gamepad adapters,
  optional external pose forwarding, room/environment fixture, record/replay,
  status panel, and clear "simulated versus real runtime" labelling.
- Source evidence: `jrng/openxr_simulator`,
  `Cafezinhu/godot-vr-simulator`, `sanky369/OpenXRSim`,
  `kcking/bevy_xr_app`, and `demonixis/OpenXR-OSX`.
- Abstraction boundary: keep app logic, simulated device state, input adapters,
  runtime/engine registration, and replay/storage separate.
- What not to copy: full unofficial runtimes, hardcoded controller profiles,
  hidden runtime registration, replay formats without schema, or simulator
  state that diverges from real action paths.
- Method catalog action: add no-headset XR simulator harness.

## Follow-Up Gaps

- Define a simulator feature checklist for future `VR-apps-lab` prototypes.
- Compare engine-plugin simulation against runtime-level simulation for overlay
  and diagnostic tools.
- Inspect replay/forwarding schemas as possible reusable data formats.
