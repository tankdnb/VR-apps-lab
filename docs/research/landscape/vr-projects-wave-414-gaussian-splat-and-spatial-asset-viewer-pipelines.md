# VR Projects Wave 414 - Gaussian Splat And Spatial Asset Viewer Pipelines

- Date: `2026-07-13`
- Scope: 3D Gaussian splat viewers, WebXR export helpers, PlayCanvas/asset
  viewer routes, and immersive spatial asset inspection workflows.
- Rule: source/documentation reading only; no builds, installs, launches, or
  device tests were performed.

## Shortlist

- `warpgatelabs/RSR`
- `hyperlogic/splatapult`
- `jacobvanbeets/splat-vr-viewer`
- `eleanor-studio/photon.editor`

## Project Notes

### `warpgatelabs/RSR`

- Interesting idea: native Windows Direct3D 12/OpenXR viewer for 3D Gaussian
  Splatting with PLY and SOG support, runtime VR toggle, DLSS option, and VR
  grip controls.
- Code donor value: useful product reference for asset-viewer command model:
  folder cycling, VR toggle, movement speed, grip translate, controller attach,
  pinch-scale, reset, and compressed SOG format support.
- Product reference value: confirms that immersive asset viewers need both
  desktop and VR controls, direct file opening, and folder navigation.
- Source evidence: README features, supported formats, desktop/VR control table,
  and runtime VR toggle notes.
- Reusable core: spatial asset viewer shell with file browser/direct open,
  runtime XR toggle, locomotion, object transform, scale, and format labels.
- What not to copy: Windows/D3D12/DLSS-only assumptions as generic viewer
  requirements.
- What to inspect next: compare SOG/PLY metadata handling with WebXR and Unity
  splat viewers already cataloged.

### `hyperlogic/splatapult`

- Interesting idea: C++/OpenGL Gaussian splat renderer with desktop and OpenXR
  VR mode, camera path/frustum visualization, world transform persistence, and
  Quest-oriented build notes.
- Code donor value: strong method donor: `vr.json` stores starting world pose/
  scale, camera configs are discovered from `cameras.json`, and VR controls
  include single/double/triple grab semantics for translate/rotate/scale.
- Product reference value: useful for inspection tools where the user aligns a
  captured scene and wants to persist that alignment.
- Source evidence: README controls, `BUILD.md`, `src/app.cpp`, `GaussianCloud`,
  `SplatRenderer`, `CamerasConfig`, and shader asset unpacking in Android path.
- Reusable core: splat viewer with camera provenance, SfM point cloud toggle,
  camera frustum/path display, VR world-transform manipulation, and alignment
  persistence.
- What not to copy: Quest build fragility and SDK-version pinning.
- What to inspect next: normalize `asset alignment profile` across splat/point
  cloud/NeRF viewers.

### `jacobvanbeets/splat-vr-viewer`

- Interesting idea: LichtFeld Studio plugin that exports the active Gaussian
  splat to PLY, starts a localhost HTTP server, and opens a PlayCanvas WebXR
  viewer.
- Code donor value: excellent bridge pattern for creator-tool-to-WebXR viewer:
  panel data model, selected node detection, export thread, temp file cleanup,
  `_config.json`, HTTP server lifecycle, and browser launch.
- Product reference value: demonstrates low-friction `one-click VR preview`
  from a desktop authoring tool without embedding a full native XR runtime.
- Source evidence: `panels/splat_vr_panel.py`, `core/launcher.py`,
  `core/__init__.py`, `viewer/index.html`, `viewer/viewer.js`, and README.
- Reusable core: authoring-tool panel -> exported asset -> localhost viewer ->
  WebXR session, with cleanup and crash recovery.
- What not to copy: GPL/licensing implications and host-specific LichtFeld API.
- What to inspect next: adapt the pattern for local docs, model previews, or
  diagnostic scene snapshots.

### `eleanor-studio/photon.editor`

- Interesting idea: web playground for `photon-editor` with HTML controls bound
  to a Three.js/WebXR-capable scene engine, dynamic GLB/GLTF loading, camera and
  environment controls, and micro-interaction toggles.
- Code donor value: useful UI-to-engine binding reference: standard web inputs
  drive scene/camera/environment properties through a clean editor API.
- Product reference value: good browser-native authoring/preview surface for
  lightweight XR assets and demos.
- Source evidence: README implementation notes, `main.js`, `public/`, and
  Vite/Three.js setup.
- Reusable core: reactive web controls mapped to scene engine actions, asset
  loader, camera/environment controls, and preview loop.
- What not to copy: playground-specific styling or npm package assumptions.
- What to inspect next: compare with PlayCanvas/editor and WebXR in-headset
  authoring waves.

## Extracted Method Candidate

`Spatial asset viewer with alignment profile`: combine direct file/asset
ingress, desktop and VR controls, scene transform manipulation, camera/frustum
metadata, compression/format labels, and saved alignment profile for repeatable
review.
