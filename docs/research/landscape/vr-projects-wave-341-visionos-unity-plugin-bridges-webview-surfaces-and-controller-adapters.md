# Wave 341 - visionOS Unity Plugin Bridges, WebView Surfaces, and Controller Adapters

This wave studies Unity-side visionOS adapter projects that expose Apple
frameworks, web surfaces, external controllers, and setup templates.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to Unity visionOS plug-in packaging, Apple framework
bridges, Metal-mode webview surfaces, controller API compatibility layers, and
template/checklist projects.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `apple/unityplugins` | Apple framework Unity plug-in bridge | Studied | Strong bridge architecture reference for Apple.Core build steps, native wrappers, Accessibility, CoreHaptics, PHASE, GameController, and SpatialController packages |
| `vuplex/visionos-metal-webview-example` | visionOS webview surface sample | Studied | Practical reference for world-space Canvas WebView on Apple Vision Pro, Metal app mode, passthrough toggle, mock editor fallback, and Tracked Device Graphic Raycaster setup |
| `surreal-interactive/SDK` | Vision Pro controller adapter SDK | Studied | Product/reference donor for mapping Oculus-style controller APIs to Surreal Touch, hand/controller mode switching, haptics, camera rig prefab, and Bluetooth plist postprocessing |
| `TonGarcia/UnityVisionVRTemplate` | Unity visionOS setup template/checklist | Studied | Documentation/template reference for XR package setup, PolySpatial, ARKit/OpenXR/XR Hands/XRI settings, URP/foveation/depth notes, and simulator workflow |

## Code-Level Findings

### `apple/unityplugins`

- Interesting idea: Apple framework access is packaged as multiple Unity UPM
  plug-ins over a shared core build/postprocess system.
- Code donor value: high as architecture reference. `Apple.Core` includes build
  profiles, native library declarations, shell command wrappers, signing/Xcode
  command wrappers, availability checks, interop wrappers, and tests. Other
  packages expose Accessibility nodes/notifications, CoreHaptics, GameController,
  GameKit, PHASE spatial audio, and SpatialController.
- Product reference value: high for capability bridge cataloguing.
- What to inspect next: Apple.Core build-step orchestration, PHASE geometry and
  material audio boundaries, SpatialController API surface, and Accessibility
  node ordering.
- Caveat: platform-specific and WWDC/beta branch behavior should be labelled.

### `vuplex/visionos-metal-webview-example`

- Interesting idea: a browser panel in visionOS is mostly an integration
  problem: Metal mode, world-space canvas, event camera, tracked-device
  raycaster, passthrough, and editor fallback all matter.
- Code donor value: medium. `VisionOSMetalWebViewExample.cs`, scene settings,
  PolySpatial settings, XR loaders, and README setup steps show how the WebView
  prefab is adapted from a general Canvas demo into a visionOS Metal scene.
- Product reference value: high for web panel utilities.
- What to inspect next: script API calls, mock webview behavior, passthrough
  toggle, input routing, keyboard/text entry, and non-Canvas WebView caveat.
- Caveat: depends on Vuplex commercial/native package; direct code reuse is
  limited.

### `surreal-interactive/SDK`

- Interesting idea: a third-party controller SDK can reduce porting cost by
  mapping known Oculus-style inputs into a new device API.
- Code donor value: medium-high for adapter shape. The repo provides
  `SVRInput`, `SVRManager`, `SVRControllerManager`, `SVRInputApi`, grabbable and
  distance-grab scripts, `SVRCameraRig`, haptic trigger API, hand/controller
  mode switching, and `SVRBuildPostProcessor.cs` for Bluetooth permissions.
- Product reference value: high for controller migration UX.
- What to inspect next: native input transport, tracking-mode switching,
  haptic ranges, controller pose freshness, and permission failure UX.
- Caveat: vendor hardware-specific; use as adapter pattern, not as general
  visionOS input baseline.

### `TonGarcia/UnityVisionVRTemplate`

- Interesting idea: a setup template can be valuable even when code is thin if
  it captures cross-tool friction points.
- Code donor value: low-medium. The value is mostly checklist and project
  settings: ARKit/OpenXR/XR Hands/XRI/PolySpatial setup, simulator target,
  URP profiles, foveated rendering notes, depth compositing, VolumeCamera
  concepts, and XRI interaction taxonomy.
- Product reference value: medium for onboarding docs.
- What to inspect next: actual scene prefabs, XR loader settings, hand
  expression captures, and whether the template is kept current.
- Caveat: docs-heavy and version-fragile.

## Reusable Pattern Extraction

- Pattern candidate: visionOS Unity adapter package.
- Problem solved: Unity visionOS projects need to integrate platform
  frameworks, Metal/PolySpatial modes, input devices, web surfaces, permissions,
  and build settings without turning each utility into a one-off setup script.
- Reusable core: shared core package, native interop wrappers, availability
  gates, build profiles, plist/Xcode postprocessors, feature packages,
  capability-specific examples, world-space surface prefab, input API migration
  map, simulator/device checklist, and dependency/license labels.
- Source evidence: `apple/unityplugins`,
  `vuplex/visionos-metal-webview-example`, `surreal-interactive/SDK`, and
  `TonGarcia/UnityVisionVRTemplate`.
- Abstraction boundary: keep platform framework wrappers, build mutation,
  surface UI, input adapters, permissions, and onboarding templates separate.
- What not to copy: commercial native package assumptions, hidden plist
  mutations, vendor-controller coupling without fallback, or stale Unity/Xcode
  version checklists.
- Method catalog action: add a visionOS Unity adapter packaging method.

## Follow-Up Gaps

- Compare Apple PHASE/CoreHaptics bridges with existing spatial-audio and
  haptics method families.
- Inspect Surreal SDK input freshness and hand/controller fallback behavior.
- Create a generic platform-adapter checklist for future Unity XR utility
  templates.
