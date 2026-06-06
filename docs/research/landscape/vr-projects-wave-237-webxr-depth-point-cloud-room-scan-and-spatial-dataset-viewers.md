# VR Projects Wave 237: WebXR Depth, Point-Cloud, Room-Scan, and Spatial Dataset Viewers

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies spatial sensing and spatial viewer utilities: WebXR depth and
camera access, point cloud generation, AR measurement, lidar-style ray grids,
Gaussian splats, and large dataset XR/streaming viewers.

## Why It Matters For `VR-apps-lab`

Future VR utilities will need to ingest spatial evidence, visualize it, export
it, and explain failures. These projects help separate capture, sampling,
reconstruction, rendering, export, viewer loading, and startup diagnostics.

## Project Notes

### `Ramith-D-Rodrigo/webxr-point-cloud`

- Interesting idea:
  browser-native WebXR can capture camera/depth data and turn it into a
  reusable point-cloud artifact with DOM overlay controls.
- Code donor value:
  `app.ts` requests `unbounded`, `depth-sensing`, `camera-access`, and
  `dom-overlay`, uses `XRWebGLBinding.getCameraImage`, reads camera pixels from
  a framebuffer, and toggles capture/point-cloud/export controls.
  `point_cloud.ts` samples depth with randomized starting offsets and projects
  points into world space. `worker.ts` transfers depth/camera buffers to
  workers, uses `rawValueToMeters` and `normDepthBufferFromNormView`, and
  returns positions/colors for Three point meshes.
- Product reference value:
  strong WebXR sensing donor for capture/export utility flows.
- What to inspect next:
  memory lifecycle, worker queue backpressure, GLTF export size, and point
  disposal.
- Architecture pattern:
  feature-gated WebXR capture pipeline with optional worker reconstruction.
- Caveats:
  experimental browser feature dependencies and cleanup caveats around scene
  point removal/disposal.

### `Dhruvi509/Webxr-room-scanner`

- Interesting idea:
  a room-scanner search result can still be useful as a measurement micro-tool
  if its actual behavior is documented honestly.
- Code donor value:
  `script.js` creates a Babylon WebXR AR experience with default UI disabled,
  background remover, hit-test, and anchor features. The hit-test callback
  moves a preview dot, draws a live line from the first selected point, shows a
  rounded distance label, and uses anchor creation when available with a clone
  fallback otherwise.
- Product reference value:
  good compact hit-test measurement state-machine reference.
- What to inspect next:
  compare with richer room scanning, boundary capture, and mesh reconstruction
  projects.
- Architecture pattern:
  first-point/second-point AR measurement flow with anchor fallback.
- Caveats:
  name overclaims "room scanner"; code is closer to point-to-point measure.

### `BSoDium/Lidar`

- Interesting idea:
  lidar-style reveal mechanics can be reused as a diagnostic visualization:
  show what rays hit, where data exists, and what remains unknown.
- Code donor value:
  `LidarArray.ts` creates a square array of Three `Raycaster` and
  `ArrowHelper` objects, rotates each ray around up/right axes, colors arrows
  based on hit state, and sets helper length to hit distance. `App.tsx` wires
  React Three XR, `VRButton`, controllers, terrain, room, dashboard, and maze
  view. README notes a fixed point budget and BVH-backed raycast intent.
- Product reference value:
  good simulated-sensor UX reference for calibration or environment probes.
- What to inspect next:
  point buffer lifecycle and how capture trigger adds points in fuller builds.
- Architecture pattern:
  visible ray-grid sensor with point-budgeted reveal surface.
- Caveats:
  game/prototype maturity; movement and point budget are unfinished.

### `sterngefeuert/webxr-gaussian-splat`

- Interesting idea:
  a splat viewer can be a small spatial asset utility if file ingestion,
  loading progress, desktop fallback, and XR entry are kept simple.
- Code donor value:
  `main.js` shares a Three renderer/camera/scene with `GaussianSplats3D.Viewer`,
  enables WebXR, supports AR DOM overlay and VR button, disables built-in
  controls, and configures progressive loading and GPU/storage options.
  `ui.js` manages idle/loading/loaded UI states, progress bar, drag/drop blob
  URLs, query-param loading, and reload.
- Product reference value:
  useful compact viewer donor for spatial asset inspection.
- What to inspect next:
  compare with prior Gaussian splat editor/viewer waves and native Unity/Unreal
  runtimes.
- Architecture pattern:
  progressive spatial asset viewer with URL/local-file ingestion and XR/desktop
  fallback.
- Caveats:
  viewer-only scope and library-specific performance/device assumptions.

### `MikeWise2718/messelpit_viewer`

- Interesting idea:
  large scientific datasets need multiple launch targets and an explicit XR
  startup playbook, not just one "VR mode".
- Code donor value:
  Omniverse `.kit` files split Explorer, Viewer, Streaming, and XR app variants.
  The XR app enables `omni.kit.xr.bundle.generic`, OpenXR display settings, XR
  debug, large teleport arc height, and RTX/RT2 settings, while the streaming
  app uses livestream extensions. Docs explain startup order, controller/action
  map caveats, OpenXR runtime selection, and why domain viewpoint logic should
  live outside desktop/VR UI modules.
- Product reference value:
  strong product/operations reference for large spatial dataset viewers.
- What to inspect next:
  isolate generic startup diagnostics and desktop/VR panel mirroring into a
  reusable playbook.
- Architecture pattern:
  multi-target dataset viewer with shared domain controls and separate XR/
  streaming shells.
- Caveats:
  heavy Omniverse/RTX/driver setup; do not copy dataset or vendor-specific
  runtime assumptions.

## Reusable Pattern Extraction

- Pattern candidate:
  spatial sensing and point-cloud XR viewer pipeline.
- Problem solved:
  VR tools need to capture spatial data, reconstruct or measure it, visualize
  it, export it, and explain startup/runtime caveats.
- Reusable core:
  separate permission/feature gate, capture source, sampling policy, worker or
  reconstruction stage, render representation, export/ingest adapter, progress
  UI, fallback mode, and startup diagnostics.
- Source evidence:
  `webxr-point-cloud`, `Webxr-room-scanner`, `Lidar`,
  `webxr-gaussian-splat`, and `messelpit_viewer`.
- Abstraction boundary:
  keep raw capture separate from point/splat/dataset renderer; keep viewer
  loading state separate from XR session state; keep dataset domain controls
  independent from desktop/VR panel implementation.
- What not to copy:
  overclaimed scanner labels, undisposed scene buffers, heavy datasets, device
  secrets, old driver assumptions, or experimental browser feature flags as
  guaranteed platform support.
- Method catalog action:
  add a method entry for spatial sensing and point-cloud XR viewer pipelines.

## Follow-Up Gaps

- Build a matrix across WebXR depth capture, AR hit-test measurement, lidar ray
  grids, Gaussian splat viewers, and Omniverse dataset apps.
- Extract point-cloud lifecycle rules: sample stride, randomized sampling,
  worker transfer, scene disposal, export size, and progress UX.
- Generalize Messelpit's OpenXR startup lessons into a reusable XR startup
  diagnostics checklist.
