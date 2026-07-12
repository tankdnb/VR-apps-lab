# Wave 334 - Godot XR Hand Poses, Spatial Entities, Wrist UI, and Android Surface Bridges

This wave studies Godot XR interaction and surface utilities: hand pose
detection, auto hand tracking, radial menus, spatial entities, persistent
anchors, wrist UI, and Android surface/plugin bridges for OpenXR composition
layers.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to:

- Godot OpenXR hand and controller interaction helpers;
- radial and wrist UI control surfaces;
- spatial entity and anchor management;
- Android plugin/surface bridge examples.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Malcolmnixon/GodotXRHandPoseDetector` | Godot XR hand pose detector | Studied | Strong donor for pose resources, hand tracker lookup, fitness functions, hold/release timing, and pose started/ended signals |
| `Godot-Dojo/Godot-XR-AH` | Godot XR auto hand, radial menu, and spatial anchor add-ons | Studied | Strong donor for controller/hand fallback, skeleton mapping, radial menu ray selection, and FB scene/spatial anchor glue |
| `BastiaanOlij/spatial-entities-demo` | Godot OpenXR spatial entities and wrist UI demo | Studied | Strong donor for tracker-to-scene management, persistent UUID mapping, anchor child scenes, wrist SubViewport UI, and touch-to-mouse injection |
| `GodotVR/godot-openxr-android-surface-plugin-example` | Godot OpenXR Android surface composition layer example | Studied | Strong donor for Android plugin boundary, `get_android_surface`, Kotlin `MediaPlayer` surface update, and composition-layer media surface flow |
| `yelrom0/godot-openxr-notification-handler-plugin` | Godot Android notification plugin experiment | Thin/low maturity | Useful as a warning and follow-up: currently close to the Android plugin template, not yet a strong notification donor |

## Code-Level Findings

### `Malcolmnixon/GodotXRHandPoseDetector`

- Interesting idea: hand gestures can be modeled as reusable resources with
  fitness functions and hold/release timing, emitting semantic pose signals
  instead of raw joint data.
- Code donor value: high. `hand_pose_detector.gd` subscribes to XRServer
  tracker changes, reads `XRHandTracker`, checks palm tracking flags, updates
  `HandPoseData`, finds the best pose, ramps `_new_hold`, decays
  `_current_hold`, and emits `pose_started`/`pose_ended`. `fitness_function.gd`
  provides smoothstep/range scoring with configuration warnings.
- Product reference value: very high for gesture-driven menus, accessibility
  actions, and hand-only utility tools.
- What to inspect next: pose resource authoring UX, action map integration,
  demo inspector scene, and false-positive handling.
- Architecture pattern: raw hand tracker + pose data resource + fitness
  scoring + temporal hysteresis + semantic signals.
- Reusable method: hand pose resource recognizer.
- Constraints / caveats: depends on OpenXR hand tracking quality and authored
  pose sets.

### `Godot-Dojo/Godot-XR-AH`

- Interesting idea: auto hand tracking and radial menu utilities can be shipped
  as add-ons with explicit tracker discovery, skeleton mapping, fallback, and
  context menu selection.
- Code donor value: high. `auto_handtracker.gd` resolves controller and hand
  trackers, maps OpenXR hand joints to skeleton bones, manages active/valid
  hand tracking, tracks trigger/grip values, and warns about missing hand
  tracking project settings. `RadialMenu.gd` creates a menu disk in front of the
  aim pose, raycasts items, highlights selection, emits `menuitemselected`, and
  cleans up generated menu items.
- Product reference value: high for VR utility menus and controller/hand
  fallback UX.
- What to inspect next: `auto_handfuncs`, simulator support, radial menu item
  scene, and spatial anchor add-on maturity.
- Caveat: research/add-on style code with debug prints and assumptions around
  tracker names.

### `BastiaanOlij/spatial-entities-demo`

- Interesting idea: spatial entities can be handled as runtime-discovered XR
  trackers that instantiate typed scenes and persist child scene identity by
  anchor UUID.
- Code donor value: high. `SpatialEntitiesManager` subscribes to XRServer
  tracker added/updated/removed signals, instantiates scenes for anchors,
  planes, markers, and spatial entities, and exposes static create/remove
  helpers. `OpenXRSpatialAnchor3D` stores child scene paths by UUID and loads
  them when persistent anchors return. `wrist_ui.gd` maps 3D touch bodies into
  SubViewport mouse move/down/up events and hides the UI when facing away.
- Product reference value: very high for spatial diagnostics, persistent
  annotation tools, and wrist control panels.
- What to inspect next: UUID database implementation, marker/plane scenes,
  collision creation tool, and wrist UI display logic.
- Caveat: demonstration project; reuse architecture and scenes selectively.

### `GodotVR/godot-openxr-android-surface-plugin-example`

- Interesting idea: a Godot OpenXR composition layer can expose an Android
  surface that native Kotlin code drives with `MediaPlayer`, enabling hardware
  video decode into an XR surface.
- Code donor value: high for Android boundary. README documents the Android
  plugin requirement. `main.gd` waits for `OpenXRCompositionLayerQuad`,
  calls `get_android_surface()`, and forwards the surface/video path into the
  Android plugin. Kotlin `GodotAndroidPlugin.kt` receives a `Surface?` and
  updates a `MediaPlayer` surface.
- Product reference value: high for video players, media overlays, and Android
  surface utilities in Godot XR.
- What to inspect next: surface lifecycle, pause/resume, audio routing, file
  selection, and vendor differences.
- Caveat: Android-only and requires plugin build/export workflow.

### `yelrom0/godot-openxr-notification-handler-plugin`

- Interesting idea: Android notifications could be bridged into Godot XR with a
  background notification server/plugin boundary.
- Code donor value: low in current state. The inspected code still has template
  names, TODO comments, and a `helloWorld` demo path.
- Product reference value: medium as a gap marker for notification bridge
  research.
- What to inspect next: whether a later branch implements
  `NotificationListenerService`, permissions, queueing, and Godot event emit.
- Caveat: do not treat as a current donor implementation.

## Reusable Pattern Extraction

- Pattern candidate: Godot XR gesture, menu, spatial entity, and Android
  surface bridge boundaries.
- Problem solved: Godot XR utilities need semantic hand inputs, compact
  in-headset menus, persistent spatial references, and native Android surfaces
  without blending every concern into one scene script.
- Reusable core: XR tracker resolver, pose resource model, fitness scoring,
  hold/release hysteresis, radial menu disk, raycast selection, SubViewport
  wrist input bridge, tracker-to-scene manager, UUID persistence, Android
  plugin export wrapper, and surface handoff API.
- Source evidence: `Malcolmnixon/GodotXRHandPoseDetector`,
  `Godot-Dojo/Godot-XR-AH`, `BastiaanOlij/spatial-entities-demo`, and
  `GodotVR/godot-openxr-android-surface-plugin-example`.
- Abstraction boundary: keep tracker discovery, semantic gesture state, UI
  selection, spatial persistence, native Android service/surface work, and app
  content separate.
- What not to copy: template plugin code, debug-only tracker assumptions,
  persistent anchors without schema/version metadata, or hardwired media paths.
- Method catalog action: add Godot XR gesture/menu/surface bridge boundaries.

## Follow-Up Gaps

- Compare Godot radial/wrist UI with prior Unity and OpenVR menu waves.
- Search for a mature Godot Android notification listener or companion app.
- Extract a Godot XR utility menu checklist from hand pose, radial, and wrist
  UI examples.
