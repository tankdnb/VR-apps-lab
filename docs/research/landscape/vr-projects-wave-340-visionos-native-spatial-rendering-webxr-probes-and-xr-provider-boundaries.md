# Wave 340 - visionOS Native Spatial Rendering, WebXR Probes, and XR Provider Boundaries

This wave studies visionOS native rendering and Unity/provider projects that
expose reusable seams for compositor-facing render loops, browser probes, and
platform validation.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to visionOS native Metal/CompositorServices rendering,
WebXR/Three.js probe behavior on Apple Vision Pro, Unity visionOS XR provider
package structure, and SwiftUI/RealityKit sample microapps.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `metal-by-example/metal-spatial-rendering` | visionOS native compositor rendering | Studied | Strong source donor for ARKit world tracking, CompositorServices frame timing, dedicated versus layered drawables, and Metal vertex amplification |
| `chrisdubya/avp-threejs-webxr-test` | WebXR-on-visionOS probe | Studied | Small browser probe combining Three.js WebXR, hand pinch events, object scaling, and microphone/MediaRecorder capture |
| `needle-mirror/com.unity.xr.visionos` | Unity visionOS XR provider package | Studied | Strong package-boundary donor for provider APIs, LayerRenderer access, authorization events, project validation, build processors, and AR resource packaging |
| `IvanCampos/visionOS-examples` | SwiftUI/RealityKit microapp gallery | Studied | Product/reference set for head anchoring, battery/status widgets, hand tracking, WebSocket/social feed, music, and small spatial UI apps |

## Code-Level Findings

### `metal-by-example/metal-spatial-rendering`

- Interesting idea: a minimal native renderer can make the compositor boundary
  explicit instead of hiding it behind an engine.
- Code donor value: high for platform boundary reading. `SpatialRenderingEngine`
  owns the render thread, ARKit world-tracking session, predicted frame timing,
  device-anchor query, update/submission phases, drawable acquisition, and
  presentation. `SpatialRenderer` separates resources, pipeline creation,
  per-view pose constants, dedicated versus layered layouts, vertex
  amplification, and mixed-immersion environment cutoff.
- Product reference value: high for a future low-level visionOS renderer note.
- What to inspect next: error handling around pose query failure, renderer
  state invalidation, input gathering hooks, and mixed/full immersion switching.
- Caveat: this is visionOS/Metal-specific and should not be generalized as an
  OpenXR runtime pattern.

### `chrisdubya/avp-threejs-webxr-test`

- Interesting idea: a tiny WebXR probe can combine interaction, object
  manipulation, and browser media permission checks in one visible scene.
- Code donor value: medium. `main.js` uses Three.js `VRButton`, hand and
  controller models, `pinchstart`/`pinchend`, fingertip collision checks,
  two-hand scaling, object attach/detach, and `MediaRecorder` microphone
  capture tied to grab/release.
- Product reference value: medium for quick Apple Vision Pro browser probes.
- What to inspect next: WebXR feature detection, permission prompts, audio blob
  export, unsupported-browser messaging, and controller fallback.
- Caveat: prototype-scale and not a production recorder.

### `needle-mirror/com.unity.xr.visionos`

- Interesting idea: a platform package is a reusable checklist for how to
  expose XR support safely: provider APIs, build processors, validation rules,
  authorization events, and resource conversion.
- Code donor value: high as architecture reference. It includes runtime APIs
  for immersive-space readiness, LayerRenderer pointer access, simulator
  detection, authorization status, frame-repeat control, XR subsystems,
  VisionOS settings, image/object tracking build processors, plist helpers, and
  project validation rules for color space, ARSession, loader state, app mode,
  HDR, and scene requirements.
- Product reference value: high for future validation docs and platform gates.
- What to inspect next: `VisionOSBuildProcessor`, `VisionOSRuntimeSettings`,
  image/object tracking processors, native API wrappers, and OpenXR/ARFoundation
  feature mapping.
- Caveat: mirrored Unity package source; reuse should be conceptual and license
  aware.

### `IvanCampos/visionOS-examples`

- Interesting idea: a microapp gallery is useful for product pattern mining
  because each app isolates one spatial OS behavior.
- Code donor value: medium. The repository exposes small SwiftUI/RealityKit
  examples around head anchoring, battery display, hand tracking, DualSense
  controller input, WebSocket feed visualization, chat/search surfaces, music,
  countdown, and lightweight immersive toggles.
- Product reference value: high for utility-shell ideas.
- What to inspect next: `HandTrackingModel`, `ControllerManager`,
  `WebSocketService`, battery view model, and immersive-space toggles.
- Caveat: broad sample collection; each microapp needs separate maturity
  checks before becoming a donor.

## Reusable Pattern Extraction

- Pattern candidate: visionOS compositor/provider decomposition.
- Problem solved: native visionOS and Unity visionOS projects often blur
  rendering, ARKit permissions, compositor timing, validation, and app UI.
- Reusable core: immersive-space state, AR/world-tracking provider,
  LayerRenderer/compositor handle, predicted timing, drawable lifecycle,
  per-view pose constants, renderer layout mode, frame-repeat/performance
  policy, authorization events, project validation rules, resource build
  processors, and simulator/device flags.
- Source evidence: `metal-by-example/metal-spatial-rendering`,
  `needle-mirror/com.unity.xr.visionos`,
  `chrisdubya/avp-threejs-webxr-test`, and
  `IvanCampos/visionOS-examples`.
- Abstraction boundary: keep OS permissions, compositor frame lifecycle,
  rendering resources, interaction probes, validation rules, and product UI
  separate.
- What not to copy: platform-specific native pointers without readiness checks,
  hidden build-time mutations, microphone capture without consent UX, or sample
  microapps without support labels.
- Method catalog action: add a new visionOS compositor/provider method.

## Follow-Up Gaps

- Compare `com.unity.xr.visionos` validation rules against existing
  OpenXR/Quest validation patterns.
- Build a platform-gate checklist for visionOS utilities: simulator/device,
  immersive style, LayerRenderer availability, permissions, and package
  dependencies.
- Deepen WebXR-on-visionOS probes only where browser capability and permission
  reporting are explicit.
