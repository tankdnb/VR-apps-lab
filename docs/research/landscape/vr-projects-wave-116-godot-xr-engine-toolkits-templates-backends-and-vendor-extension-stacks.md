# VR Projects Wave 116: Godot XR Engine Toolkits, Templates, Backends, and Vendor Extension Stacks

- Date: `2026-06-05`
- Goal: add a focused GitHub discovery wave for Godot XR toolkits, starter
  templates, OpenXR/OpenVR backends, vendor-extension packaging, and deprecated
  mobile VR bridges.

## Why this wave exists

Godot gives `VR-apps-lab` a different engine-side reference model from Unity,
Unreal, native OpenXR, or WebXR. Its useful patterns are often packaged as
addons, scenes, scripts, action maps, export presets, GDExtensions, and vendor
feature wrappers.

This wave studies Godot XR repositories as reusable references for lightweight
utility prototypes, interaction scene packs, vendor-extension exploration, and
runtime/device configuration patterns.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by Godot XR toolkit, OpenXR plugin, OpenVR plugin, vendor
   extension, and mobile VR families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, product value, caveats, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `GodotVR/godot-xr-tools` | Modular XR scene/toolkit addon with hands, pointers, movement, interactables, desktop support, effects, staging, and settings |
| `GodotVR/godot-xr-template` | Starter project wiring XR Tools, OpenXR action maps, vendor plugin dependency, and export presets |
| `GodotVR/godot_openxr_for_godot_3.x` | Legacy Godot 3 OpenXR backend showing runtime/session/action/extension split |
| `GodotVR/godot_openxr_vendors` | Godot 4 vendor OpenXR extension stack with export plugins and device feature wrappers |
| `GodotVR/godot_openvr` | Godot 4 OpenVR/SteamVR backend with action manifests, skeletons, play-area, battery, and render-model helpers |
| `GodotVR/godot_oculus_mobile` | Deprecated Oculus Mobile bridge useful as migration/API-shaping reference only |

## Deep-pass notes by project

## `GodotVR/godot-xr-tools`

- GitHub:
  [GodotVR/godot-xr-tools](https://github.com/GodotVR/godot-xr-tools)
- What it is:
  a Godot addon with support scenes, functions, scripts, and helpers for AR/VR
  projects.
- Interesting idea:
  XR utility interaction can be packaged as reusable scene/function nodes
  rather than as one app: gaze pointers, pickup, pose detection, teleport,
  movement providers, hands, interactables, effects, events, staging, rumble,
  desktop support, and user settings all live as composable toolkit pieces.
- Code-level notes:
  `addons/godot-xr-tools/functions/` contains `function_gaze_pointer.gd`,
  `function_pointer.gd`, `function_pickup.gd`, `function_pose_detector.gd`,
  `function_teleport.gd`, and movement modules. `events/pointer_event.gd`
  defines pointer event objects and signal payloads. `hands/collision_hand.gd`
  handles hand skeleton/collision behavior and pickup forces. `effects/` adds
  fade/vignette comfort pieces, while `desktop-support/`, `staging/`, and
  `user_settings/` round out non-headset and configuration workflows.
- Code donor value:
  very high for Godot-side interaction scaffolding and reusable utility scenes.
- Product reference value:
  high for building small XR tools where interaction modules should be visible
  and swappable.
- Caveats:
  Godot project conventions and addon scene wiring are not portable verbatim to
  native overlay or Unity projects.
- What to inspect next:
  compare pickup, gaze, locomotion, and hand modules against Unity MRTK/XRI,
  Unreal UXTools, and WebXR hand-component patterns.

## `GodotVR/godot-xr-template`

- GitHub:
  [GodotVR/godot-xr-template](https://github.com/GodotVR/godot-xr-template)
- What it is:
  a Godot starter project for simple VR projects using XR Tools and OpenXR
  vendor support.
- Interesting idea:
  a reusable XR baseline should include not just sample scenes, but also action
  maps, export presets, vendor plugin toggles, and device-feature flags.
- Code-level notes:
  the template includes `openxr_action_map.tres`, `project.godot`, and
  `export_presets.cfg`. The Android export presets expose feature toggles for
  Meta, Pico, Lynx, Khronos, and related OpenXR vendor plugins, including
  hand tracking and passthrough-related flags.
- Code donor value:
  high for starter wiring and project layout.
- Product reference value:
  high for a minimum viable Godot XR utility baseline.
- Caveats:
  template defaults are useful as shape, not as guaranteed current device
  settings.
- What to inspect next:
  map the action-map and export-preset shape against `godot_openxr_vendors`
  feature wrappers.

## `GodotVR/godot_openxr_for_godot_3.x`

- GitHub:
  [GodotVR/godot_openxr_for_godot_3.x](https://github.com/GodotVR/godot_openxr_for_godot_3.x)
- What it is:
  a maintenance-mode OpenXR plugin for Godot 3.x.
- Interesting idea:
  even legacy engine bindings can clarify clean runtime architecture:
  interface class, OpenXR API wrapper, config object, action sets/actions,
  poses, hands, skeletons, and extension wrappers are kept as distinct layers.
- Code-level notes:
  `src/gdclasses/` exposes `XRInterfaceOpenXR`, `OpenXRConfig`, `OpenXRHand`,
  `OpenXRPose`, and `OpenXRSkeleton`. `src/openxr/` contains `OpenXRApi`,
  action/action-set glue, and extension wrappers for hand tracking,
  passthrough, foveation, display refresh, color space, and performance-related
  features.
- Code donor value:
  medium-high for binding architecture and extension-wrapper boundaries.
- Product reference value:
  medium for understanding legacy OpenXR support and migration constraints.
- Caveats:
  Godot 3 and maintenance-mode status make it unsuitable as a current support
  target.
- What to inspect next:
  compare its extension wrapper split with the newer Godot 4 vendor extension
  repository.

## `GodotVR/godot_openxr_vendors`

- GitHub:
  [GodotVR/godot_openxr_vendors](https://github.com/GodotVR/godot_openxr_vendors)
- What it is:
  a Godot 4 GDExtension plugin that packages vendor-specific OpenXR extensions
  not exposed directly by Godot core.
- Interesting idea:
  vendor-specific runtime capabilities can be made manageable by separating
  extension wrappers, editor helpers, export plugins, and project setup flows.
- Code-level notes:
  `plugin/src/main/cpp/classes/` contains classes for Android XR features such
  as anchors, environment depth, hit results, light estimation, scene meshing,
  and trackables. Meta/Facebook extension classes cover passthrough geometry,
  render models, spatial anchors/entities/queries, hand tracking mesh, body,
  face, scene, space warp, environment depth, colocation discovery, boundary
  visibility, and simultaneous hands/controllers. `export/` contains export
  plugin paths for Android, Khronos, Lynx, Magic Leap, Meta, Pico, and
  validation setup.
- Code donor value:
  very high for optional vendor-extension packaging and export-time feature
  toggles.
- Product reference value:
  very high for device capability explorers, setup checkers, and vendor feature
  diagnostics.
- Caveats:
  feature availability is vendor/runtime-specific and should be treated as
  optional capability, not baseline behavior.
- What to inspect next:
  make a feature matrix for passthrough, anchors, environment depth, hand/body
  tracking, face tracking, render models, and colocation.

## `GodotVR/godot_openvr`

- GitHub:
  [GodotVR/godot_openvr](https://github.com/GodotVR/godot_openvr)
- What it is:
  a Godot 4 GDExtension backend for OpenVR/SteamVR.
- Interesting idea:
  a legacy SteamVR backend still teaches useful utility patterns: action
  manifests, tracking universe selection, play-area queries, skeleton actions,
  render model metadata, device battery, and charging state.
- Code-level notes:
  `register_types.cpp` registers `XRInterfaceOpenVR`,
  `OpenVROverlayContainer`, `OpenVRSkeleton`, and `OpenVREventHandler`.
  `xr_interface_openvr.cpp` exposes application type, tracking universe,
  action manifest path, action sets, play area, device battery and charging,
  render model names, and render model loading. `OpenVRSkeleton.*` handles
  skeletal action data and bone hierarchy/reference transforms.
- Code donor value:
  high for SteamVR device metadata and action-manifest plumbing.
- Product reference value:
  medium-high for diagnostics around play area, battery, skeletons, and render
  models.
- Caveats:
  OpenVR-specific and not a substitute for modern OpenXR work.
- What to inspect next:
  compare with earlier OpenVR driver/action waves when planning SteamVR
  diagnostics.

## `GodotVR/godot_oculus_mobile`

- GitHub:
  [GodotVR/godot_oculus_mobile](https://github.com/GodotVR/godot_oculus_mobile)
- What it is:
  a deprecated Godot Android plugin for Oculus Mobile / Quest-era VrApi.
- Interesting idea:
  deprecated vendor bridges are still useful for API-shaping lessons: expose
  runtime capabilities through small script-callable wrappers, keep session
  guards explicit, and document migration to OpenXR clearly.
- Code-level notes:
  the plugin exposes Android/GDNative-style wrappers such as tracking
  transform, guardian system, utilities, performance, display refresh,
  foveation, controller velocity, and VrApi proxy helpers. Native files such as
  `api_common.h` show session guard helpers.
- Code donor value:
  low-medium; useful mainly for wrapper shape and migration notes.
- Product reference value:
  medium as a cautionary legacy bridge.
- Caveats:
  archived/deprecated; use OpenXR instead for current work.
- What to inspect next:
  only revisit if documenting migration from legacy vendor SDKs to OpenXR.

## Main takeaways from Wave 116

- Godot XR work splits into scene-pack toolkits, project templates, runtime
  backends, vendor-extension packs, and legacy vendor bridges.
- `godot-xr-tools` is the strongest direct donor for reusable interaction
  modules.
- `godot-xr-template` is valuable because it captures project wiring, not
  because it is a complex app.
- `godot_openxr_vendors` is the key donor for optional capability packaging and
  export-time device features.
- Deprecated mobile bridges should be kept as migration references, not as
  current support targets.

## Reusable methods clarified by this wave

- `Godot XR scene-pack utility toolkit with function nodes and reusable scenes`
- `Godot XR starter template with action map, vendor dependency, and export
  feature toggles`
- `Godot vendor OpenXR extension packaging and export-plugin capability gates`
- `SteamVR/OpenVR backend metadata bridge for Godot utilities`

## Recommended next moves after this wave

1. Use `godot-xr-tools` as the main Godot interaction donor.
2. Use `godot-xr-template` when drafting a minimal Godot XR project baseline.
3. Turn `godot_openxr_vendors` into a feature matrix before any vendor-specific
   prototype work.
4. Keep deprecated Oculus Mobile material as historical/migration context only.
