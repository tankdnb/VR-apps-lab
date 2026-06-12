# Wave 266 - Engine and Browser XR Utility Packages, Input, and Locomotion Primitives

This wave studies engine-side and browser-side XR utility packages: tracked
device wrappers, Unity input selectors, WebXR/A-Frame component primitives,
legacy XR input helpers, and source-light runtime support packages.

## Scope

The wave was bounded to projects that expose reusable primitives rather than
complete end-user products:

- engine-side OpenVR tracked-device entities;
- video or texture utility wrappers in an engine context;
- Unity XR input and locomotion helpers;
- selector pipelines for laser and collision input;
- A-Frame/WebXR locomotion, controller event panels, and projection materials;
- release-only or source-light browser utility packages.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Silverlan/PragmaVR` | Engine-side OpenVR utility addon | Studied | Tracked device entities, render model fallback, haptics, laser primitives, and video player texture wrapper |
| `TheUtDuong/unity-vr-utilities` | Source-light Unity skeleton | Source-light | Mostly project settings; little implementation evidence |
| `loganator956/unity-vr-utilities` | Unity runtime loader switch | Studied | Tiny XR loader-specific controller prefab switch |
| `nukadelic/UXRU` | Legacy Unity XR utility primitives | Studied | XR InputDevice tracker, player locomotion, collider follow, and transform smoothing helpers |
| `Ponsukeee/VRInputModule` | Unity VR input module selectors | Studied | Device abstraction, input event routing, laser selector, collision selector, and module handoff |
| `Sunflower-Reality-Labs/aframe-srl-utils` | A-Frame component primitives | Studied | Oculus Touch locomotion/events, projector material, and component micro-library shape |
| `acerwebvr/Acer-VR-Utility-for-Browser-WebVR-Release` | Browser WebVR release package | Source-light | Historical WMR browser WebVR installer/extension reference |

## Code-Level Findings

### `Silverlan/PragmaVR`

- Interesting idea:
  model OpenVR tracked devices as engine entities with render models, pose
  state, device roles, and haptic output.
- Code donor value:
  strong for `vr_tracked_device` component structure, device index/type/serial
  handling, fallback HMD/controller/tracker models, OpenVR activity state,
  base-pose relative updates, controller role lookup, haptic pulses, laser
  cylinder primitives, and mpv-backed video texture wrapper.
- Product reference value:
  useful for any engine plugin that needs to turn runtime devices into visible
  scene objects and utility surfaces.
- What to inspect next:
  session lifecycle, input binding, render-model caching, tracked-device loss,
  and how engine callbacks synchronize with render frames.
- Caveats:
  tightly bound to Pragma engine Lua APIs and OpenVR bindings.

### `TheUtDuong/unity-vr-utilities`

- Interesting idea:
  repository name suggests Unity VR helpers, but the current default branch is
  mostly project settings.
- Code donor value:
  very low in the inspected branch.
- Product reference value:
  useful as a source-light classification case.
- What to inspect next:
  releases, branches, or linked assets.
- Caveats:
  do not promote as a utility package donor without implementation evidence.

### `loganator956/unity-vr-utilities`

- Interesting idea:
  switch active controller prefabs based on the active Unity XR loader.
- Code donor value:
  narrow but clear donor for runtime loader enumeration and Oculus-specific
  controller object enable/disable behavior.
- Product reference value:
  tiny reference for compatibility shims inside Unity XR template projects.
- What to inspect next:
  loader name matching, non-Oculus branches, editor/runtime differences, and
  config-driven prefab lists.
- Caveats:
  hardcoded string checks and narrow scope.

### `nukadelic/UXRU`

- Interesting idea:
  wrap legacy Unity XR `InputDevice` access into tracker, player movement, and
  smoothing helpers.
- Code donor value:
  useful for feature discovery, no-garbage device lists, primary/secondary
  axis fallbacks, button pressed/released state arrays, update timing flags,
  dynamic body collider follow, force-based locomotion, tilt/turn controls,
  teleport reset, and transform lerp timing options.
- Product reference value:
  good historical baseline for low-level XR interaction primitives before XR
  Interaction Toolkit.
- What to inspect next:
  migration mapping to modern Input System and XR Interaction Toolkit.
- Caveats:
  deprecated upstream and tied to legacy Unity XR helpers.

### `Ponsukeee/VRInputModule`

- Interesting idea:
  decouple VR device input from target selection and target behavior through
  interfaces.
- Code donor value:
  strong for `IInputDevice`, `IInputModule`, and `IInputModuleSelector`
  boundaries, click/double-click/release/pad input types, current handling
  module handoff, selector switching, raycast laser selection, trigger
  collision selection, `OnSet`/`OnUnset`, and default input module fallback.
- Product reference value:
  useful for custom VR UI systems where ray, touch, and default handlers need
  one routing model.
- What to inspect next:
  SteamVR v2 device adapter, double-click bug around sub-click state, UI
  feedback, and module lifecycle tests.
- Caveats:
  old SteamVR dependency and small API rough edges.

### `Sunflower-Reality-Labs/aframe-srl-utils`

- Interesting idea:
  package WebXR/A-Frame behaviors as small declarative components with visible
  debug output.
- Code donor value:
  useful for thumbstick locomotion, run/walk speed controls, two-hand grab
  movement and rotation, controller event HUDs, A-Frame event maps, projection
  material components, projector transforms, and equirectangular shader
  uniform plumbing.
- Product reference value:
  good reference for browser XR component primitives and in-scene diagnostics.
- What to inspect next:
  cleanup handlers, modern A-Frame compatibility, controller profiles, and
  projection shader details.
- Caveats:
  old A-Frame style, some assumptions around `#rig`, Oculus Touch, and debug
  logging.

### `acerwebvr/Acer-VR-Utility-for-Browser-WebVR-Release`

- Interesting idea:
  release a browser WebVR utility package for Acer/WMR headsets across several
  browsers.
- Code donor value:
  no source donor in the inspected branch; useful only for release packaging
  and platform support framing.
- Product reference value:
  historical reference for browser-to-WMR utility distribution.
- What to inspect next:
  archived installers, extension behavior, and whether source exists
  elsewhere.
- Caveats:
  old WebVR era, release/install only, no code pass beyond docs.

## Reusable Pattern Extraction

- Pattern candidate:
  engine/browser XR utility primitive boundary.
- Problem solved:
  utility packages often provide raw primitives rather than finished products.
  They are reusable only when the boundary between runtime device, input event,
  selector, scene entity, UI feedback, and host framework is explicit.
- Reusable core:
  runtime/device adapter, input feature map, selector mode, target module
  contract, visible debug state, locomotion/body model, projection/material
  helper, and framework-specific caveats.
- Source evidence:
  `PragmaVR`, `unity-vr-utilities`, `UXRU`, `VRInputModule`,
  `aframe-srl-utils`, and source-light Acer/TheUtDuong entries.
- Abstraction boundary:
  engine primitives, Unity prefabs, and browser components should be compared
  by the contracts they expose, not by whether they are polished apps.
- What not to copy:
  deprecated XR APIs without migration notes, hardcoded rig names, old WebVR
  install flows, or vendor/sample payloads as original donor code.
- Method catalog action:
  create a method for XR primitive package intake and reuse classification.

## Family Placement

This wave creates an engine/browser XR utility primitives family. It overlaps
with Unity XR microcontrols, A-Frame components, WebXR runtime scaffolding,
and overlay media substrates, but its focus is lower-level input, device, and
projection primitives.

## Backlog Impact

- Add an XR primitives matrix comparing device wrappers, selectors,
  locomotion/body models, projection materials, and framework caveats.
- Deepen `Ponsukeee/VRInputModule` and `aframe-srl-utils` for reusable input
  and component design.
- Keep source-light Unity/WebVR repositories caveated until code evidence is
  found.
