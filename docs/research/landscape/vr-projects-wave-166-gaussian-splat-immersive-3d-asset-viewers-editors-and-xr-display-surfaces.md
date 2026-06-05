# VR Projects Wave 166: Gaussian Splat Immersive 3D Asset Viewers, Editors, and XR Display Surfaces

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 166 studies Gaussian splat tooling as reusable VR utility infrastructure:
browser editors, self-contained WebXR viewers, general model viewers, Three.js
libraries, Unity runtime renderers, native OpenXR plugins, and VFX Graph
experiments.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `playcanvas/supersplat` | Splat editor and asset pipeline | Strong editor/data-pipeline donor |
| `playcanvas/supersplat-viewer` | WebXR splat viewer | Strong static viewer donor |
| `playcanvas/model-viewer` | General immersive model viewer substrate | Useful model/XR shell reference |
| `mkkellogg/GaussianSplats3D` | Drop-in web splat rendering | Strong library donor with caveats |
| `aras-p/UnityGaussianSplatting` | Unity splat runtime | Strong Unity runtime donor |
| `clarte53/GaussianSplattingVRViewerUnity` | Native plugin VR splat viewer | Strong native/OpenXR boundary reference |
| `keijiro/SplatVFX` | VFX substrate experiment | Useful experimental caveat |

## `playcanvas/supersplat`

- Interesting idea:
  a browser-based editor can inspect, select, edit, optimize, and publish
  Gaussian splats without a native install.
- Code donor value:
  high for event-driven editor actions, command history, shared async command
  queue, asset loading through `splat-transform`, GPU data processors, and
  import/export boundaries.
- Product reference value:
  high for a public splat utility with clear edit/publish framing.
- What to inspect next:
  separate product/editor UI from the reusable data processor and command
  history model.
- Source evidence:
  `src/editor.ts`, `src/edit-history.ts`, `src/asset-loader.ts`,
  `src/data-processor/index.ts`, `src/io/read/loader.ts`, and
  `src/io/write/writer.ts`.
- Reusable pattern extraction:
  Gaussian splat editor with serialized command history and GPU data passes.
- Reusable core:
  load and validate splat data, reorder for performance, route all destructive
  edits through a shared command queue, keep undo/redo cursor state, run heavy
  selection/bounds/histogram work on GPU, and export with progress writers.
- Do not copy directly:
  full editor UI unless the product is an editor.
- Caveats:
  browser GPU capabilities and splat file variants require explicit checks.

## `playcanvas/supersplat-viewer`

- Interesting idea:
  package a splat scene as a self-contained static website with URL-driven
  content/settings and optional WebXR/AR mode.
- Code donor value:
  high for settings schema/migration, URL parameters, camera modes, collision
  gating, annotations, animation tracks, and XR entry handling.
- Product reference value:
  high for publishable immersive captures and shareable spatial scenes.
- What to inspect next:
  compare its settings schema with editor export output and with general model
  viewers.
- Source evidence:
  `README.md`, `src/xr.ts`, `src/app.ts`, and `src/camera-manager.ts`.
- Reusable pattern extraction:
  static WebXR splat viewer with camera, collision, annotation, and schema
  boundaries.
- Reusable core:
  keep viewer settings in typed JSON, support content/collision/skybox/poster
  URL overrides, gate WebXR on WebGL, restore camera rig state on session exit,
  and choose orbit/fly/walk/animation camera modes from scene bounds and
  settings.
- Do not copy directly:
  PlayCanvas-specific UI if a future prototype uses another engine.
- Caveats:
  WebXR requires WebGL mode, while the viewer otherwise prefers WebGPU when
  available.

## `playcanvas/model-viewer`

- Interesting idea:
  a general glTF scene viewer can share the same app-shell lessons as splat
  viewers: drag/drop content, background handling, XR managers, and AR object
  placement.
- Code donor value:
  medium for PlayCanvas app setup, resource handlers, GSplat support, and AR
  placement controller flow.
- Product reference value:
  medium-high for a robust baseline viewer before splat-specific features are
  added.
- What to inspect next:
  compare its `XRObjectPlacementController` with splat viewer XR navigation and
  future asset-inspection utilities.
- Source evidence:
  `README.md`, `src/app.ts`, and `src/xr-mode.ts`.
- Reusable pattern extraction:
  general model viewer shell with AR placement and resource-handler stack.
- Reusable core:
  centralize engine app initialization, register resource/component systems,
  expose URL/drag-drop content loading, and isolate XR placement as a controller
  with hit-test and DOM overlay input.
- Caveats:
  it is not splat-specific, so donor value is mostly viewer shell and XR
  placement.

## `mkkellogg/GaussianSplats3D`

- Interesting idea:
  make Gaussian splat rendering available as a Three.js library that can be
  self-driven, drop-in, multi-scene, multi-format, and WebXR-capable.
- Code donor value:
  high for loader selection, worker sorting, WebXR mode gating, optional
  external renderer/camera integration, progressive load, raycasting, and
  performance controls.
- Product reference value:
  high for web apps that need splat rendering without adopting a full editor.
- What to inspect next:
  compare its sorting/culling caveats with PlayCanvas and Unity runtimes before
  choosing a web renderer.
- Source evidence:
  `README.md`, `src/Viewer.js`, `src/webxr/WebXRMode.js`, `VRButton.js`, and
  loader directories for PLY/SPLAT/KSPLAT/SPZ.
- Reusable pattern extraction:
  drop-in Gaussian splat renderer library with loader and worker boundaries.
- Reusable core:
  expose self-driven and external-loop modes, support `.ply`, `.splat`,
  `.ksplat`, and `.spz`, use workers/WASM for sorting, allow external
  Three.js scene/camera/renderer integration, and disable incompatible
  optimizations in WebXR mode.
- Do not copy directly:
  inactive-maintenance assumptions or custom format choices without comparison.
- Caveats:
  README notes inactive development, CPU sort artifacts, mobile limits, and
  very large scene failure modes.

## `aras-p/UnityGaussianSplatting`

- Interesting idea:
  treat splats as Unity assets with compression choices, runtime rendering,
  camera/debug controls, editing, cutouts, merge/export, and pipeline-specific
  rendering integrations.
- Code donor value:
  high for asset data layout, compression enums, renderer command buffers,
  GPU sorting, cutout/edit/export model, and render-pipeline split.
- Product reference value:
  high for Unity-based spatial capture viewers and editor utilities.
- What to inspect next:
  compare its renderer with native plugin approaches for VR performance and
  maintenance risk.
- Source evidence:
  `readme.md`, `package/Runtime/GaussianSplatAsset.cs`,
  `package/Runtime/GaussianSplatRenderer.cs`, and `docs/splat-editing.md`.
- Reusable pattern extraction:
  Unity Gaussian splat asset/runtime pipeline with edit/render separation.
- Reusable core:
  import splat files into compressed asset chunks, attach renderer components,
  gather active splats per camera, sort and draw procedural splats through
  command buffers, expose debug modes and cutouts, and export modified data.
- Do not copy directly:
  rendering code without validating graphics API support and license/data
  provenance.
- Caveats:
  project warns about limited platform testing, graphics API requirements, and
  original training-data license considerations.

## `clarte53/GaussianSplattingVRViewerUnity`

- Interesting idea:
  integrate a CUDA differential Gaussian rasterizer as a Unity native plugin
  and use OpenXR to view multiple splat models in VR with controller movement,
  scale, menu, and performance telemetry.
- Code donor value:
  high for native plugin API boundaries, per-POV render contexts, CUDA texture
  interop, model load/remove, crop controls, and Unity/OpenXR menu concepts.
- Product reference value:
  high as a VR-native splat viewer and performance caveat reference.
- What to inspect next:
  compare native plugin cost/risk against Unity pure-renderer and web viewers.
- Source evidence:
  `README.md`, `UnityPlugin/source/GaussianSplatting.cpp`, and
  `UnityPlugin/source/PluginAPI.cpp`.
- Reusable pattern extraction:
  native CUDA/OpenXR Unity plugin boundary for splat rendering.
- Reusable core:
  keep model loading and GPU transfer behind a plugin API, create per-camera or
  per-eye render contexts, map native textures/depth, set camera/model draw
  parameters, preprocess, draw, and expose model/menu controls at the Unity
  layer.
- Do not copy directly:
  CUDA-only architecture unless the hardware target justifies it.
- Caveats:
  Windows/CUDA hardware requirements, low VR sample performance in README, and
  native plugin complexity.

## `keijiro/SplatVFX`

- Interesting idea:
  express Gaussian splats as Unity VFX Graph data using ScriptableObject
  arrays, graphics buffers, binders, shader graph, and VFX blocks.
- Code donor value:
  medium for VFX data binding, buffer lifetime, importer shape, and visual
  effect substrate.
- Product reference value:
  medium as an experiment and contrast case to full renderers.
- What to inspect next:
  use as a visual-effect/particle substrate reference, not as the default
  viewer path.
- Source evidence:
  `README.md`, `Runtime/SplatData.cs`, `Runtime/SplatDataBinder.cs`,
  `Editor/SplatImporter.cs`, and `VFX/Splat.vfx`.
- Reusable pattern extraction:
  Unity VFX Graph splat data binder and visual-effect substrate.
- Reusable core:
  store splat arrays in a ScriptableObject, lazily allocate graphics buffers,
  bind splat count/position/axis/color buffers into VFX Graph exposed
  properties, and release GPU resources on disable.
- Do not copy directly:
  projection algorithm as a production renderer.
- Caveats:
  README explicitly says it is not ready and has artifacts/pops.

## Cross-Project Lessons

- Splat utilities should declare whether they are editors, static viewers,
  libraries, engine runtimes, native plugins, or shader experiments.
- WebXR splat viewers need explicit renderer fallback rules because WebGPU and
  WebXR support do not always align.
- Performance and data provenance caveats belong in the product surface, not
  hidden in developer notes.
- Heavy splat editing needs command serialization and GPU processing
  boundaries.
- Native plugin approaches can unlock performance but should be classified as
  high-risk donors.

## Reusable Methods Extracted

- Gaussian splat editor with serialized command history and GPU data passes.
- Static WebXR splat viewer with schema, camera, collision, and annotations.
- General model viewer shell with XR/AR placement controller.
- Drop-in Three.js splat renderer with multi-format loaders and worker sorting.
- Unity Gaussian splat asset/runtime render pipeline with edit/export support.
- Native CUDA/OpenXR Unity plugin render boundary.
- Unity VFX Graph splat data binder substrate.

## Follow-Up Backlog

- Build a Gaussian splat utility matrix by format support, XR mode, collision,
  annotations, editing, export, runtime, and hardware assumptions.
- Compare WebXR viewer navigation against VR-native manipulation/menu flows.
- Keep license and capture/training-data provenance caveats visible for future
  public docs.
