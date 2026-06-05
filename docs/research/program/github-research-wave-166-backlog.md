# GitHub Research Wave 166 Backlog

- Date: `2026-06-05`
- Theme: `Gaussian splat immersive 3D asset viewers, editors, and XR display surfaces`
- Status: `Completed`

## Completed Pass

1. Search Gaussian splat editor, viewer, WebXR, Three.js, PlayCanvas, Unity,
   native OpenXR, and VFX Graph projects.
2. Deduplicate against earlier immersive video, analytics, creative asset, and
   browser viewer waves.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect browser editor command histories, PlayCanvas GSplat loaders, WebXR
   viewer camera/collision flows, Three.js loader/sort boundaries, Unity asset
   and renderer scripts, native CUDA/OpenXR plugin APIs, and VFX Graph binders.
5. Add seven Gaussian splat projects with differentiated donor postures.
6. Integrate results into registry, families, methods, not-yet queue, current
   focus, and indexes.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `playcanvas/supersplat` | Added as browser Gaussian splat editor with command history and GPU data processor |
| `playcanvas/supersplat-viewer` | Added as static WebXR splat viewer with settings schema, camera modes, collision, and annotations |
| `playcanvas/model-viewer` | Added as general PlayCanvas model viewer and AR/XR placement substrate |
| `mkkellogg/GaussianSplats3D` | Added as Three.js drop-in splat library with workers, loaders, and WebXR caveats |
| `aras-p/UnityGaussianSplatting` | Added as Unity asset/runtime renderer, editing, and compression donor |
| `clarte53/GaussianSplattingVRViewerUnity` | Added as native CUDA/OpenXR Unity plugin and VR splat viewer reference |
| `keijiro/SplatVFX` | Added as experimental VFX Graph splat data binder and substrate caveat |

## Useful Follow-Up Work

- Build a splat-content matrix separating editor, static viewer, engine
  runtime, native plugin, VFX substrate, format support, and XR support.
- Compare WebXR viewer collision/navigation with VR-native Unity/OpenXR
  manipulation patterns.
- Keep licensing/training-data caveats explicit for splat models even when the
  viewer code is permissively licensed.

## Not Pursued In This Wave

- No browser editor/viewer, Unity project, native plugin, CUDA code, VFX Graph,
  sample model, or WebXR session was launched.
- No found repository was run, built, installed, imported, or tested.
