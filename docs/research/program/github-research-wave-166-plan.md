# GitHub Research Wave 166 Plan

- Date: `2026-06-05`
- Theme: `Gaussian splat immersive 3D asset viewers, editors, and XR display surfaces`
- Scope: browser splat editors, static WebXR viewers, general model viewers,
  Three.js splat libraries, Unity asset/runtime renderers, native OpenXR/Unity
  plugins, and VFX Graph splat substrates.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Gaussian splats are becoming a reusable content primitive for immersive
capture, spatial viewers, creator previews, and high-density 3D backgrounds.
Wave 166 studies the utility side: editors, viewers, settings schemas, XR
navigation, format loaders, runtime render systems, and performance caveats.

## Search Families

- Gaussian splat browser editors
- WebXR splat viewers
- Three.js splat libraries
- PlayCanvas splat tooling
- Unity Gaussian splat runtimes
- native OpenXR/Unity splat plugins
- VFX Graph splat experiments

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `playcanvas/supersplat` | Browser editor for inspecting, editing, optimizing, and publishing splats | Splat editor and asset pipeline |
| `playcanvas/supersplat-viewer` | Self-contained static splat viewer with settings schema, WebXR, collision, and annotations | WebXR splat viewer |
| `playcanvas/model-viewer` | General glTF/model viewer with AR/XR placement and PlayCanvas app shell | General immersive model viewer substrate |
| `mkkellogg/GaussianSplats3D` | Three.js splat library with multi-format loaders, WebXR, workers, and optimization controls | Drop-in web splat rendering |
| `aras-p/UnityGaussianSplatting` | Unity asset/import/runtime renderer with editing, cutouts, compression, and VR caveats | Unity splat runtime |
| `clarte53/GaussianSplattingVRViewerUnity` | OpenXR Unity viewer using native CUDA/differential rasterization plugin | Native plugin VR splat viewer |
| `keijiro/SplatVFX` | Unity VFX Graph splat experiment and data binder | VFX substrate experiment |

## Dedupe Notes

- Earlier video/media and data-visualization waves did not deeply cover
  Gaussian splat-specific edit/view/render boundaries.
- This wave treats Unity/web/native projects separately because their reusable
  value differs: editor state, static viewer settings, library integration,
  native render plugin, and shader/VFX substrate.

## Code-Level Pass Targets

- editor event bus, command history, async data processing, import/export;
- viewer settings schema, camera modes, collision, annotations, and WebXR;
- format loader boundaries for PLY/SOG/SPZ/SPLAT/KSPLAT;
- worker sorting, culling, WebXR tradeoffs, and drop-in integration;
- Unity asset compression, renderer command buffers, cutouts, and VR caveats;
- native plugin model/Pov/context management and CUDA/texture boundary;
- VFX Graph buffer binding and known limitations.

## Expected Outputs

- New Wave 166 landscape synthesis.
- Registry and family updates for Gaussian splat viewers/editors/runtime
  surfaces.
- Methods around command-history editors, WebXR viewer settings, drop-in splat
  libraries, Unity asset/runtime renderers, native plugin boundaries, and VFX
  Graph splat substrates.
