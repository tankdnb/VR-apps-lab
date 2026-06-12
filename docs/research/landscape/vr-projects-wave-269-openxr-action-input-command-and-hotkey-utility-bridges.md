# Wave 269 - OpenXR Action/Input Command and Hotkey Utility Bridges

This wave studies projects that turn OpenXR, Unity XR, UEVR, keyboard, or OSC
input into higher-level commands and diagnostics.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- OpenXR action polling and action-set test harnesses;
- input-to-command bridges;
- Unity event-driven OpenXR input wrappers;
- generated OpenXR action code;
- UEVR controller-touch to keyboard mappings;
- VRChat hotkey-to-OSC pulse utilities;
- runtime-fork references where input/device boundaries are the useful part.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `art0007i/openxr-command-runner` | OpenXR input-to-command bridge | Studied | Strong action-to-shell-command donor |
| `swirllyman/SimpleOpenXRInput` | Unity OpenXR input facade | Studied | Event-driven high-level controller input wrapper |
| `gameflorist/uevr-touch-buttons-mapping-plugin` | UEVR/OpenXR touch-to-key bridge | Studied | Runtime-side keyboard output plus haptic confirmation |
| `germansmedia/openxr-actions-test` | Low-level OpenXR action test harness | Partially studied | Raw FFI action/session diagnostics with artifact caveats |
| `danwillm/openxr-actions-tester` | JSON-driven OpenXR action tester | Studied | Headless JSON action-set poller for buttons and tracker poses |
| `brycehutchings/OpenXR-Action-Code-Generator` | OpenXR action code generator | Studied | Generates C/C++ helper structs from action manifests |
| `tmddn0230/monado-input-system` | Monado fork/input-device reference | Variant/reference only | Useful for runtime input/device boundaries, not direct copy |
| `Somahc/VRCVoiceHotkey` | Hotkey-to-VRChat-OSC bridge | Studied with caveats | Compact tray hotkey that pulses `/input/Voice` |

## Code-Level Findings

### `art0007i/openxr-command-runner`

- Interesting idea:
  run arbitrary command-line commands from OpenXR controller inputs.
- Code donor value:
  strong. It creates an EXTX overlay session, parses JSON5 action/binding
  config, supports simple and detailed command definitions, maps action paths
  to bool or float actions, and detects single, double, long, and double-long
  clicks before spawning commands.
- Product reference value:
  excellent baseline for a VR hotkey/action bridge.
- What to inspect next:
  command allowlists, confirmation UX, logging, user config generation, and
  safer process spawning.
- Caveats:
  requires `XR_EXTX_overlay`, Vulkan setup, manual config creation, and strong
  safety review before arbitrary command execution.

### `swirllyman/SimpleOpenXRInput`

- Interesting idea:
  wrap Unity OpenXR input into static events and getters.
- Code donor value:
  useful for a simple input facade: one `InputActionMap`, left/right
  controller bindings, static events for joystick/grip/trigger/buttons/menu,
  and haptic helper assignment through `XRControllerWithRumble`.
- Product reference value:
  good reference for onboarding examples and compact controller telemetry.
- What to inspect next:
  modern Unity Input System/OpenXR compatibility, action asset generation, and
  lifecycle cleanup for static events.
- Caveats:
  index-based action lists and static state make it a teaching baseline, not a
  robust library without cleanup.

### `gameflorist/uevr-touch-buttons-mapping-plugin`

- Interesting idea:
  reclaim unused OpenXR touch inputs in UEVR and emit keyboard keys.
- Code donor value:
  useful for runtime-side remapping: UEVR plugin initialization, OpenXR backend
  check, `get_action_handle`, edge-triggered `SendInput` key down/up, per-key
  state, and haptic vibration on activation.
- Product reference value:
  practical example of bridging "unused controller affordance" into legacy
  game inputs.
- What to inspect next:
  configurable key mapping, per-game profile conflict handling, and OpenVR
  support.
- Caveats:
  keyboard/gamepad mode switching can confuse games, and UEVR/plugin APIs are
  a specialized ecosystem.

### `germansmedia/openxr-actions-test`

- Interesting idea:
  raw Rust FFI OpenXR action/session test app.
- Code donor value:
  partial: useful as evidence for explicit proc loading, code-to-string
  diagnostics, instance/session/action setup, and low-level error reporting.
- Product reference value:
  a rough "how much ceremony an action test harness needs" reference.
- What to inspect next:
  action polling loop, cleanup, validation, and whether tracked `target/`
  artifacts match source.
- Caveats:
  checked-in `target/debug` binaries/artifacts and raw generated FFI make it a
  weak donor compared with cleaner harnesses.

### `danwillm/openxr-actions-tester`

- Interesting idea:
  describe action sets and suggested bindings in JSON, then poll them in a
  headless OpenXR session.
- Code donor value:
  strong for diagnostics: JSON action-set parsing, extension injection,
  `XR_MND_headless`, action creation, suggested bindings per interaction
  profile, bool/pose action state printing, and Vive tracker pose example.
- Product reference value:
  useful for an OpenXR input doctor or binding sanity checker.
- What to inspect next:
  cross-platform timing, non-Windows support, richer output formats, and
  runtime capability reports.
- Caveats:
  Windows timing path and command-line-only UX.

### `brycehutchings/OpenXR-Action-Code-Generator`

- Interesting idea:
  generate C/C++ helper structs from an OpenXR action manifest.
- Code donor value:
  useful for codegen boundaries: manifest models, custom JSON converter for
  dynamic suggested-binding names, action-set structs, action-state structs,
  subaction helpers, `xrStringToPath`, and suggested binding arrays.
- Product reference value:
  good reference for reducing OpenXR action boilerplate in prototypes.
- What to inspect next:
  validation TODOs, naming customization, haptic helpers, and generated header
  traceability.
- Caveats:
  early-stage generator with many TODOs and Windows-oriented `strcpy_s`.

### `tmddn0230/monado-input-system`

- Interesting idea:
  Monado-scale runtime fork that exposes input/device boundaries.
- Code donor value:
  reference only. Useful evidence includes `xrt_device.h` input/output and
  binding-pair structures, asynchronous hand-tracking wrapper, and Xreal Air
  driver packet/IMU/control plumbing.
- Product reference value:
  useful when reasoning about runtime-driver versus app-level utility
  boundaries.
- What to inspect next:
  diff against canonical Monado, branch purpose, and whether any novel input
  system work exists beyond upstream runtime code.
- Caveats:
  Monado itself is already represented in the repository; this fork should
  stay a variant/reference until unique changes are isolated.

### `Somahc/VRCVoiceHotkey`

- Interesting idea:
  a Windows tray utility that maps Ctrl+M to a VRChat OSC voice pulse.
- Code donor value:
  useful micro-bridge: low-level keyboard hook, tray lifecycle, guard against
  repeat activation, UDP OSC packet building with 4-byte padding, and
  `/input/Voice` 0 -> 1 -> 0 pulse timing.
- Product reference value:
  compact proof that a hotkey bridge can be tiny and user-facing.
- What to inspect next:
  configurable hotkey, OSC address, port, cooldown, feedback, and hook
  recovery.
- Caveats:
  no README, mojibake comments, hardcoded Ctrl+M/localhost:9000, and Windows
  only.

## Reusable Pattern Extraction

- Pattern candidate:
  input/action-to-command bridge boundary.
- Problem solved:
  VR users need quick actions that cross runtime input, app hotkeys, desktop
  commands, OSC endpoints, and game input systems.
- Reusable core:
  input source, action/binding schema, gesture recognizer, command target,
  safety gate, feedback/haptics, cooldown/release semantics, config file, and
  diagnostics.
- Source evidence:
  OpenXR command runner config and click handlers, UEVR `SendInput` bridge,
  Unity OpenXR event facade, JSON action testers, code generator, Monado input
  abstractions, and VRChat OSC hotkey pulse.
- Abstraction boundary:
  separate low-level input acquisition from command dispatch, and make command
  targets auditable.
- What not to copy:
  arbitrary shell execution without allowlists, checked-in build artifacts,
  hardcoded hotkeys/ports, runtime forks without diff isolation, or stale raw
  OpenXR boilerplate.
- Method catalog action:
  create a method for OpenXR/action input-to-command bridges.

## Family Placement

This wave creates an OpenXR/action command bridge family. It overlaps with
VRChat OSC micro-control, SteamVR dashboard shims, and OpenXR diagnostics, but
its core value is the bridge from controller/action semantics to user-visible
commands.

## Backlog Impact

- Add a VR hotkey/action bridge matrix comparing OpenXR actions, UEVR touch
  mappings, Unity events, keyboard hooks, and OSC pulses.
- Deepen `openxr-command-runner` before any command-runner prototype.
- Use `openxr-actions-tester` and `OpenXR-Action-Code-Generator` as input
  doctor/codegen references.
