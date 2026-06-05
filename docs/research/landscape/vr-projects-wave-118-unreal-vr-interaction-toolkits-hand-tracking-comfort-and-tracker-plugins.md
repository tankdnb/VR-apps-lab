# VR Projects Wave 118: Unreal VR Interaction Toolkits, Hand Tracking, Comfort, and Tracker Plugins

- Date: `2026-06-05`
- Goal: add a focused GitHub discovery wave for Unreal VR interaction,
  replicated grip systems, MR UX primitives, comfort tunnelling, OpenXR hand
  tracking, Vive tracker role plugins, and small multiplayer XR frameworks.

## Why this wave exists

Unreal XR projects package reusable knowledge differently from Unity, Godot,
WebXR, or native OpenXR samples. The useful material often appears as plugin
modules, C++ components, Blueprint-facing primitives, replicated controller
state, OpenXR extension hooks, or post-process comfort effects.

This wave studies Unreal VR repositories as references for future interaction
systems, hand/controller abstractions, comfort settings, tracker diagnostics,
and engine-side utility prototypes.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by Unreal VR interaction, replicated grip, MR UX, hand
   tracking, Vive tracker, comfort tunnelling, and multiplayer XR families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, product value, caveats, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `mordentral/VRExpansionPlugin` | Replicated grip, movement, controller, and OpenXR hand pose framework |
| `1runeberg/RunebergVRPlugin` | Compact Blueprint/C++ component pack for pawn, grab, gaze, gesture, teleport, and climb |
| `microsoft/MixedReality-UXTools-Unreal` | Archived but valuable MR UX primitives, hand tracking abstraction, near/far input, and simulation |
| `sigtrapgames/VrTunnellingPro-UE4` | Comfort tunnelling, vignette, mask, and preset plugin reference |
| `demonixis/FSOpenXRHandTracking` | Small OpenXR hand tracking, pinch, ray, and Enhanced Input adapter |
| `Rectus/UE4OpenXRViveTrackerPlugin` | OpenXR extension plugin mapping Vive tracker roles into Unreal motion sources |
| `V4C38/ue5-xrcore` | Modern small XRCore framework with replicated hands, interactors, lasers, connectors, and physics helpers |

## Deep-pass notes by project

## `mordentral/VRExpansionPlugin`

- GitHub:
  [mordentral/VRExpansionPlugin](https://github.com/mordentral/VRExpansionPlugin)
- What it is:
  a large Unreal VR plugin family for interaction, motion controllers, grips,
  movement, replication, and OpenXR expansion helpers.
- Interesting idea:
  VR interaction in networked Unreal projects needs a dedicated authority layer
  around grips, drops, sockets, controller transforms, late updates, movement
  actions, smoothing, and conflict events.
- Code-level notes:
  `VRExpansionPlugin` and `OpenXRExpansionPlugin` are separate plugin modules.
  `GripMotionControllerComponent.h` extends motion-controller behavior with
  position replication, object grip replication, late updates, smoothing,
  tracking scale/limits, socket/drop/grip events, teleport notifications, and
  client-authority conflict handling. Movement types include custom serialized
  VR movement actions and teleport flags. The OpenXR module includes hand pose
  animation integration and skeleton mapping.
- Code donor value:
  very high for replicated VR grip and movement architecture.
- Product reference value:
  high for multiplayer VR utility and interaction systems.
- Caveats:
  broad, mature, and engine-specific; use selectively instead of copying the
  whole framework concept.
- What to inspect next:
  compare grip authority and replication with Unity networked interaction and
  native overlay input bridges.

## `1runeberg/RunebergVRPlugin`

- GitHub:
  [1runeberg/RunebergVRPlugin](https://github.com/1runeberg/RunebergVRPlugin)
- What it is:
  a VR plugin with Blueprint/C++ components for common VR mechanics.
- Interesting idea:
  a compact engine toolkit can package common mechanics as separate components:
  pawn, grabber, simple grabber, movement, teleporter, gaze, gestures, gesture
  database, climb, and custom gravity.
- Code-level notes:
  `RunebergVR_Gaze` exposes start/end gaze, duration activation, target mesh,
  face-pawn rotation, and gaze hit/activate/lost events. `RunebergVR_Gestures`
  records gesture samples and uses a gesture database data asset plus dynamic
  time warping style matching. Other components provide movement, teleport,
  grab, simple grab, climb, and pawn setup.
- Code donor value:
  high for compact component boundaries and Blueprint-facing feature shape.
- Product reference value:
  medium-high for starter interaction kits and training prototypes.
- Caveats:
  smaller and older than some modern Unreal XR stacks.
- What to inspect next:
  compare gesture and gaze components with A-Frame, Godot, and Unity utility
  primitives.

## `microsoft/MixedReality-UXTools-Unreal`

- GitHub:
  [microsoft/MixedReality-UXTools-Unreal](https://github.com/microsoft/MixedReality-UXTools-Unreal)
- What it is:
  an archived Unreal plugin for mixed-reality UX building blocks.
- Interesting idea:
  MR UX should separate hand tracking, near/far pointers, input simulation,
  controls, interactions, constraints, manipulation, and widget/touchable
  layers so utilities can share a common near/far UI vocabulary.
- Code-level notes:
  modules include `UXTools`, `UXToolsInput`, `XRSimulation`, and editor-facing
  pieces. `IUxtHandTracker.h` defines a modular hand-tracker interface for
  tracking status, joint state, pointer/grip poses, grabbing, and selection.
  `UxtDefaultHandTracker.cpp` maps OpenXR/MSFT hand interaction, Mixed Reality,
  Oculus Touch, and XR simulation data. Controls and interactions include
  pressable buttons, sliders, bounds controls, far beams, finger cursors,
  surface magnetism, touchable volumes, hand menus, near menus, manipulators,
  grab/far/poke target interfaces, and two-hand rotate/scale constraints.
- Code donor value:
  high for UX primitive architecture and input simulation boundaries.
- Product reference value:
  very high for MR menus, slates, hand UI, and near/far interactions.
- Caveats:
  archived; treat as reference material, not a current dependency plan.
- What to inspect next:
  synthesize near/far MR UI primitives across Unreal UXTools, Unity MRTK,
  Godot XR Tools, and WebXR components.

## `sigtrapgames/VrTunnellingPro-UE4`

- GitHub:
  [sigtrapgames/VrTunnellingPro-UE4](https://github.com/sigtrapgames/VrTunnellingPro-UE4)
- What it is:
  an Unreal VR comfort plugin for tunnelling and peripheral-vision reduction.
- Interesting idea:
  comfort controls can be packaged as a user-configurable effect system with
  vignette, skybox/cubemap, windows, world-space portals, blur, masks, and
  presets rather than as one hardcoded fade.
- Code-level notes:
  plugin content includes materials, meshes, and presets. Source modules such
  as `VRTP`, `VRTPMask`, and `VRTPMobile` split standard, mask, and mobile
  comfort paths.
- Code donor value:
  medium for comfort-effect organization and preset shape.
- Product reference value:
  high for user-facing comfort settings.
- Caveats:
  effect implementation is engine/render-pipeline specific.
- What to inspect next:
  compare with accessibility and simulator-sickness mitigation families.

## `demonixis/FSOpenXRHandTracking`

- GitHub:
  [demonixis/FSOpenXRHandTracking](https://github.com/demonixis/FSOpenXRHandTracking)
- What it is:
  an Unreal OpenXR hand-tracking plugin and sample-style adapter.
- Interesting idea:
  a small hand-tracking adapter can convert OpenXR skeleton data into
  instanced hand rendering, pinch detection, Enhanced Input actions, and a
  smoothed hand ray.
- Code-level notes:
  `UFSInstancedHand` uses instanced static meshes for hand rendering and
  updates from `FXRMotionControllerData`. The code exposes pinch tests,
  registerable input actions, optional hand rays, relative rotation options,
  speed smoothing, and threshold settings.
- Code donor value:
  high for compact hand tracking, pinch-as-input, and hand ray patterns.
- Product reference value:
  high for hand-first utilities and diagnostics.
- Caveats:
  tested target and engine assumptions should be checked before reuse.
- What to inspect next:
  compare with WebXR hands, Godot collision hands, and Unity hand menu tools.

## `Rectus/UE4OpenXRViveTrackerPlugin`

- GitHub:
  [Rectus/UE4OpenXRViveTrackerPlugin](https://github.com/Rectus/UE4OpenXRViveTrackerPlugin)
- What it is:
  an Unreal OpenXR plugin for Vive tracker role support through
  `XR_HTCX_vive_tracker_interaction`.
- Interesting idea:
  a thin OpenXR extension plugin can turn runtime tracker paths and role names
  into engine motion sources without patching the engine.
- Code-level notes:
  the plugin implements `IInputDeviceModule`, `IOpenXRExtensionPlugin`, and
  `IMotionController`. It adds the required Vive tracker extension, enumerates
  Vive tracker paths, and maps roles such as camera, chest, elbows, feet, knees,
  shoulders, keyboard, waist, and handheld to Unreal motion source names.
- Code donor value:
  high for OpenXR extension plugin anatomy and tracker role mapping.
- Product reference value:
  high for tracker diagnostics and custom-device input exposure.
- Caveats:
  the README notes unfinished input/disconnect handling and SteamVR/runtime
  issues.
- What to inspect next:
  compare with tracker inventory, SlimeVR, and custom-device plumbing waves.

## `V4C38/ue5-xrcore`

- GitHub:
  [V4C38/ue5-xrcore](https://github.com/V4C38/ue5-xrcore)
- What it is:
  a modern Unreal 5 XR interaction and utility framework.
- Interesting idea:
  a smaller XR framework can still include multiplayer-ready hands, lasers,
  interactors, interactions, connectors, holograms, highlights, and replicated
  physics helpers.
- Code-level notes:
  modules include `Core`, `Interactions`, `Connections`, and `Utilities`.
  Components include XR hands, laser components, settings, interactors,
  interaction components, grab/trigger interactions, connector sockets,
  connector holograms, highlight components, replicated physics, and utility
  functions.
- Code donor value:
  medium-high for modern compact component boundaries.
- Product reference value:
  high for small multiplayer XR utility frameworks.
- Caveats:
  younger and smaller than the larger Unreal plugin ecosystems.
- What to inspect next:
  compare with `VRExpansionPlugin` to separate lightweight interaction needs
  from full replicated grip infrastructure.

## Main takeaways from Wave 118

- Unreal VR donor material splits into replicated interaction frameworks,
  compact component packs, MR UX primitive libraries, comfort effect plugins,
  hand-tracking adapters, tracker role plugins, and small multiplayer utility
  frameworks.
- `VRExpansionPlugin` is the strongest donor for replicated grips and movement.
- `MixedReality-UXTools-Unreal` remains a valuable UX reference even though it
  is archived.
- `FSOpenXRHandTracking` and `UE4OpenXRViveTrackerPlugin` show the value of
  narrow OpenXR extension/adaptation plugins.
- Comfort effects deserve product-level settings and presets, not a hidden
  hardcoded shader.

## Reusable methods clarified by this wave

- `Unreal replicated grip and VR movement authority layer`
- `Unreal MR UX primitives with hand tracking, near/far input, and simulation`
- `VR comfort tunnelling preset and mask component system`
- `OpenXR hand tracking adapter with pinch-as-input and smoothed hand ray`
- `OpenXR tracker-role-to-motion-source bridge`

## Recommended next moves after this wave

1. Use `VRExpansionPlugin` as the main Unreal replicated interaction donor.
2. Use `MixedReality-UXTools-Unreal` for MR UI primitive synthesis, with
   archived status visible.
3. Keep tracker role mapping in the custom-device/backlog branch.
4. Compare comfort/tunnelling plugins with accessibility overlays before
   designing comfort settings.
