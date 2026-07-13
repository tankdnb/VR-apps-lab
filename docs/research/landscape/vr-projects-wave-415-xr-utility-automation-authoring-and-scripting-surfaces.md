# VR Projects Wave 415 - XR Utility Automation Authoring And Scripting Surfaces

- Date: `2026-07-13`
- Scope: in-headset authoring, sleep/automation overlays, broad AR/XR SDK
  control surfaces, and scripting-language OpenXR access.
- Rule: source/documentation reading only; no builds, installs, launches, sign
  ins, shell commands from projects, or device tests were performed.

## Shortlist

- `RangerMauve/dat-xr-scene-ide`
- `Eidenz/NemuriXR`
- `Phantomxm2021/ARMOD-Framework`
- `drypy/openxr.py`

## Project Notes

### `RangerMauve/dat-xr-scene-ide`

- Interesting idea: A-Frame/WebXR scene editor that injects a curved terminal
  into the scene and lets commands manipulate DOM entities/attributes.
- Code donor value: good small donor for in-headset authoring: `editor-system`
  toggles an `a-curvedimage` terminal, command handlers implement `ls`, `cat`,
  `cd`, `write`, `mkdir`, `eval`, and scene traversal.
- Product reference value: validates a surprising but useful authoring pattern:
  command-line editing inside VR rather than only flat desktop inspectors.
- Source evidence: README roadmap and `editor-terminal.js`.
- Reusable core: terminal surface plus scene-DOM command adapter.
- What not to copy: unsafe `eval` and old Dat archive assumptions.
- What to inspect next: design safe allowlisted in-headset scripting commands
  for diagnostics and scene tweaking.

### `Eidenz/NemuriXR`

- Interesting idea: Linux/Monado VR sleeping utility with desktop app,
  in-headset OpenXR overlay, shared config, Unix-socket IPC, VRChat log/API/OSC
  automations, brightness/fan/audio control, and phase-based sleep state.
- Code donor value: strong utility architecture donor: `crates/core` stores
  config/state/IPC, `crates/overlay` presents quick in-headset controls, and
  `desktop` Tauri/Svelte app owns long-running automation.
- Product reference value: excellent example of a real-world VR utility with
  phased state, safety net, quick overlay, tray/desktop app, local config, and
  external app automations.
- Source evidence: README, `crates/core/src/config.rs`,
  `crates/core/src/ipc.rs`, `crates/overlay/src/client.rs`,
  `desktop/src/lib/api.ts`, and `desktop/src/lib/state.svelte.ts`.
- Reusable core: phase-state automation engine plus overlay control surface and
  desktop host connected by IPC.
- What not to copy: account/session automation without explicit privacy,
  consent, and credential hygiene.
- What to inspect next: extract a generic phase-based VR utility automation
  model.

### `Phantomxm2021/ARMOD-Framework`

- Interesting idea: broad AR/XR framework for adding AR capabilities to
  existing applications, with Unity/Android/iOS folders, docs, dashboard
  framing, session management, light estimation, and app/service API limits.
- Code donor value: useful as a capability-wrapper reference, especially for
  SDK feature gating, visual configuration, platform configuration mutation,
  native/Unity options, and public docs/education surfaces.
- Product reference value: shows how a large SDK frames `enhance existing app`
  and `build new app` paths with dashboard, tutorials, and commercial support
  boundaries.
- Source evidence: README, CHANGELOG, `Android/`, `iOS/`, and feature notes
  around session management, UGUI camera API, light estimation, and API quotas.
- Reusable core: capability-oriented SDK shell with visual config, platform
  mutation, feature toggles, docs/tutorials, and quota/support caveats.
- What not to copy: broad platform claims or service dependencies without
  verified support boundaries.
- What to inspect next: compare with vendor OpenXR extension wrapper waves.

### `drypy/openxr.py`

- Interesting idea: Python `ctypes` bindings for OpenXR 1.0 with generated
  package layout and examples/tests.
- Code donor value: useful scripting-access reference for diagnostics,
  prototyping, and automation tools where Python should inspect or call OpenXR
  without a full C++ app.
- Product reference value: supports a future `XR doctor / scripting probe`
  direction for quick runtime checks and teaching material.
- Source evidence: README, `src/`, `test/`, `etc/`, package metadata, and
  references to Ruby/Dart sibling bindings.
- Reusable core: scripting-language binding layer over OpenXR loader and spec
  types.
- What not to copy: assuming runtime/device availability from Python package
  install alone.
- What to inspect next: whether a small Python OpenXR diagnostic probe belongs
  in future working-lab examples.

## Extracted Method Candidate

`XR utility automation and scripting surface`: expose a bounded command layer
for XR authoring, automation, diagnostics, or phase-state control, with a clear
split between in-headset controls, desktop/host automation, scripting bindings,
configuration, and safety/privacy gates.
