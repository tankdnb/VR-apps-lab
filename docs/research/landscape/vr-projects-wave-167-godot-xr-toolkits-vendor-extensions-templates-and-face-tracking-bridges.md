# VR Projects Wave 167: Godot XR Toolkits, Vendor Extensions, Templates, and Face-Tracking Bridges

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 167 studies Godot XR reusable building blocks: scene-node toolkits,
OpenXR vendor extension stacks, game-template composition, GDExtension
face-tracking bridges, and older OpenVR UI/teleport primitives.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `GodotVR/godot-xr-tools` | Godot XR toolkit donor | Strong function-node toolkit donor |
| `GodotVR/godot_openxr_vendors` | Godot vendor extension matrix | Strong vendor/export gate donor |
| `Malcolmnixon/godot-xr-dungeon-template` | Godot XR product template | Useful product-template reference |
| `beepobb/godot-htc-face-tracking-bridge` | Face-tracking bridge reference | Source-driven caveat donor |
| `boku-ilen/godot-vr-toolkit` | Legacy toolkit primitive reference | Useful older UI/teleport primitive donor |

## `GodotVR/godot-xr-tools`

- Interesting idea:
  package XR interaction, movement, hands, audio, effects, staging, desktop
  support, and user settings as composable Godot scenes and scripts rather than
  a monolithic runtime.
- Code donor value:
  high for function-node contracts, exported settings, configuration warnings,
  pointer/pickup/teleport flows, movement-provider ordering, and editor-friendly
  scene composition.
- Product reference value:
  high for Godot-based VR utility prototypes.
- What to inspect next:
  build a function-by-function matrix across pointer, pickup, teleport,
  locomotion, hands, desktop support, user settings, staging, and audio.
- Source evidence:
  `README.md`, `addons/godot-xr-tools/functions/movement_provider.gd`,
  `function_pointer.gd`, `function_pickup.gd`, and `function_teleport.gd`.
- Reusable pattern extraction:
  Godot XR function-node toolkit with exported configuration and warnings.
- Reusable core:
  model each XR capability as a scene node with exported properties, runtime
  helper creation, configuration warnings, action names, collision masks,
  controller signals, and clear integration points with `XROrigin3D`,
  `XRController3D`, and `XRToolsPlayerBody`.
- Do not copy directly:
  all scenes into unrelated tools; select only the function families needed.
- Caveats:
  Godot version compatibility matters and toolkit breadth can hide which module
  is actually being reused.

## `GodotVR/godot_openxr_vendors`

- Interesting idea:
  expose vendor-specific OpenXR extensions to Godot through a GDExtension stack,
  editor export features, class docs, samples, and Android vendor package
  toggles.
- Code donor value:
  high for extension wrapper patterns, export option generation, vendor
  mutually-exclusive toggles, feature gates, performance metrics monitors, and
  composition layer settings.
- Product reference value:
  high for diagnostics, capability matrices, vendor-specific helper tools, and
  future Godot XR prototypes.
- What to inspect next:
  build a vendor matrix across Android XR, Meta, Pico, HTC, Magic Leap, Lynx,
  Khronos, validation layers, passthrough, depth, anchors, render models, body,
  face, hands, and performance metrics.
- Source evidence:
  `README.md`, `plugin/src/main/cpp/export/export_plugin.cpp`,
  `meta_export_plugin.cpp`,
  `extensions/openxr_fb_composition_layer_alpha_blend_extension.cpp`,
  `extensions/openxr_android_performance_metrics_extension.cpp`,
  `samples/performance-metrics-sample/main.gd`, `doc_classes/`, and
  `thirdparty/androidxr/include/androidxr/`.
- Reusable pattern extraction:
  Godot OpenXR vendor extension package with export feature gates.
- Reusable core:
  request extension availability through wrapper classes, expose project and
  export options, prevent conflicting vendor plugins, map vendor features into
  export features/manifests, expose runtime classes and docs, and provide small
  samples for metrics or capability surfaces.
- Do not copy directly:
  vendor-specific code without gating and runtime capability checks.
- Caveats:
  vendor licensing, Android export complexity, and fast-changing OpenXR vendor
  extension behavior.

## `Malcolmnixon/godot-xr-dungeon-template`

- Interesting idea:
  show XR Tools and OpenXR Vendors inside a complete small game shell with
  persistence, staging, HUD, pause menu, NPCs, world zones, and item modifiers.
- Code donor value:
  medium for product shell composition, persistence patterns, HUD/menu
  connections, and zone/staging state.
- Product reference value:
  high for turning toolkit modules into a working Godot XR experience.
- What to inspect next:
  extract template-level structure separately from bundled dependencies and
  asset packs.
- Source evidence:
  `README.md`, `game/game_state.gd`,
  `components/persistent/persistent_world.gd`,
  `game/objects/pause_menu/pause_menu_3d.gd`,
  `game/objects/status_hud/status_hud.gd`, and
  `game/npcs/skeleton/skeleton.gd`.
- Reusable pattern extraction:
  Godot XR product-template shell with persistence, staging, HUD, and pause
  menu.
- Reusable core:
  keep global game state in an autoloaded persistent world, connect HUD/menu UI
  to state signals, save current zone/player transform, and use staging to
  switch XR scenes.
- Do not copy directly:
  full game assets or bundled dependency copies.
- Caveats:
  more product-template than utility library; donor value is composition.

## `beepobb/godot-htc-face-tracking-bridge`

- Interesting idea:
  bridge HTC OpenXR facial tracking weights into Godot's `XRFaceTracker` through
  a focused GDExtension.
- Code donor value:
  medium-high for source-level extension wrapper lifecycle, requested extension
  dictionary, session handles, expression reads, mapping to Godot face blend
  shapes, and tracker registration.
- Product reference value:
  medium as a small bridge pattern and caveat around template-derived repos.
- What to inspect next:
  compare with `godot_openxr_vendors` HTC facial tracking support and avoid
  duplicate maintenance if upstream covers it.
- Source evidence:
  `src/openxr_htc_facial_tracking_extension.cpp`,
  `src/openxr_htc_facial_tracking_extension.h`, and
  `project/bin/godot_htc_facial_tracking_bridge.gdextension`.
- Reusable pattern extraction:
  GDExtension OpenXR face-tracking bridge to engine-native face tracker.
- Reusable core:
  request a vendor extension, create eye/lip facial tracker handles on session
  creation, query predicted display time, read expression weights, map vendor
  expressions into engine blendshape slots, and register an engine face tracker.
- Do not copy directly:
  README/template scaffolding or duplicate vendor code without checking
  upstream status.
- Caveats:
  README is still generic godot-cpp template text; value is source-driven.

## `boku-ilen/godot-vr-toolkit`

- Interesting idea:
  an older Godot/OpenVR toolkit collects viewport-to-mesh UI, controller ray
  interaction, teleport arcs, object interaction, and simple menu/object demos.
- Code donor value:
  medium for viewport coordinate mapping, fake mouse events, ray/indicator UX,
  teleport visualization, and interactable base class flow.
- Product reference value:
  medium for legacy lessons and lightweight UI primitives.
- What to inspect next:
  port only the concepts to modern Godot 4/OpenXR patterns; do not reuse old
  OpenVR/GDNative dependencies directly.
- Source evidence:
  `addons/vr-toolkit/Gui/GuiInteraction.gd`,
  `addons/vr-toolkit/Gui/ViewportToMesh.gd`,
  `addons/vr-toolkit/Locomotion/RayTeleport.gd`, and
  `addons/vr-toolkit/Objects/VRInteractable.gd`.
- Reusable pattern extraction:
  viewport-to-mesh VR UI interaction with controller ray and synthetic mouse
  events.
- Reusable core:
  raycast from a controller, orient hit indicators to the collision normal,
  convert 3D hit points through the UI mesh transform into viewport
  coordinates, synthesize mouse motion/button events, and feed them to the
  embedded viewport.
- Do not copy directly:
  old Godot 3/OpenVR plugin bundles and binary dependencies.
- Caveats:
  legacy stack, Oculus-focused testing note, and outdated APIs.

## Cross-Project Lessons

- Godot XR reusability often comes from scene composition and exported node
  settings rather than from a central service layer.
- Vendor OpenXR work needs an explicit matrix of runtime support, export flags,
  project settings, docs, and samples.
- Product templates are valuable when they show how toolkit pieces compose with
  persistence, staging, HUD, and menus.
- Small GDExtension bridges can be excellent learning references even when
  their README is generic.
- Legacy OpenVR toolkits should be mined for UX primitives, not copied as
  dependencies.

## Reusable Methods Extracted

- Godot XR function-node toolkit with exported configuration and warnings.
- Godot OpenXR vendor extension package with export feature gates.
- Godot XR product-template shell with persistence, staging, HUD, and pause
  menu.
- GDExtension OpenXR face-tracking bridge to engine-native face tracker.
- Viewport-to-mesh VR UI interaction with synthetic mouse events.

## Follow-Up Backlog

- Build a Godot XR function-node matrix.
- Build a Godot OpenXR vendor feature/export matrix.
- Compare Godot node composition with Unity prefab/toolkit composition for
  future reusable VR utility samples.
- Revisit HTC face tracking only after checking overlap with
  `godot_openxr_vendors`.
