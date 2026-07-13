# Wave 347: NeRF Gaussian Splat and Light Field VR Viewers

## Scope

This wave studies VR viewers for neural and volumetric spatial media. The
useful pattern is not a single renderer; it is the separation between asset
format, loading, GPU/native rendering, stereo texture handoff, VR navigation,
file browsing, quality scaling, and platform caveats.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `uhhhci/immersive-ngp` | Studied | Unity/instant-ngp stereo NeRF renderer with native plug-in wrapper, external textures, OpenGL/OpenVR/MRTK setup, DLSS support, 6DoF locomotion, volume slices, crop/FoV/edit concepts, and Magic NeRF Lens branch |
| `alexwing/nerf_Unity_VR` | Studied | Smaller Unity NeRF VR experiment with camera/depth/scene scripts, Quest/URP project settings, and source-light but useful scene-shell evidence |
| `zachdrouin/GaussianSplatViewer` | Studied | Quest 3 Gaussian splat viewer with async binary PLY loader, Burst jobs, Gaussian data model, compute shaders, radix sort, culling, LOD/streaming managers, VR file browser, and locomotion |
| `julienkay/LightfieldVideoUnity` | Studied as release-only reference | Light-field video viewer concept for Quest/Rift with compiled releases only and explicit note that Unity video playback was insufficient without proprietary components |

## Reusable Pattern Extraction

- Pattern candidate: `neural spatial media viewer decomposition`.
- Problem solved: NeRF, splat, and light-field viewers need different renderers
  but share the same product skeleton: asset discovery, loader, renderer,
  stereo output, navigation, quality controls, and performance caveats.
- Reusable core: spatial-media descriptor, file/source browser, async loader,
  metadata parser, native plug-in or compute-render adapter, left/right texture
  handoff, camera-pose update, depth sorting/culling, LOD/streaming,
  locomotion, crop/FoV tools, capability labels, and cleanup lifecycle.
- Source evidence: immersive-ngp's native `ngp_shared` wrapper and external
  textures, GaussianSplatViewer's Burst PLY loader and GPU radix sorter,
  nerf_Unity_VR's small scene scripts, and LightfieldVideoUnity's release-only
  caveat about high-resolution video playback.
- Abstraction boundary: the viewer shell should not depend on one renderer;
  format-specific loaders/renderers should plug into shared browsing,
  navigation, quality, and cleanup services.
- What not to copy: native plug-ins without source/build provenance,
  hardcoded model paths, unbounded GPU memory use, proprietary video playback
  dependencies, or demos without per-device performance labeling.
- Method catalog action: create a new neural spatial media viewer method.

## Project Notes

### `uhhhci/immersive-ngp`

- Interesting idea: instant-ngp is wrapped as a stereo Unity renderer with
  external left/right textures.
- Code donor value: high for C# native plug-in boundary, `GL.IssuePluginEvent`
  lifecycle, stereo camera pose update, external texture creation, cleanup,
  and edit/crop/FoV concepts.
- Product reference value: strong for high-end NeRF workbench direction.
- What to inspect next: native C++ plug-in, Magic NeRF Lens branch, depth
  occlusion, crop boxes, and saved-edit schema.
- Caveats: old Unity/OpenVR/MRTK/OpenGL stack and native build complexity.

### `alexwing/nerf_Unity_VR`

- Interesting idea: small Unity shell around NeRF/depth scene experiments.
- Code donor value: modest; useful for camera/depth scripts and scene-shell
  contrast with immersive-ngp.
- Product reference value: low-to-moderate as a thin baseline.
- What to inspect next: renderer implementation and whether assets/scripts are
  enough for a reproducible viewer.
- Caveats: source-light for core NeRF rendering.

### `zachdrouin/GaussianSplatViewer`

- Interesting idea: standalone Quest splat viewer treats PLY loading, splat
  data, sorting, rendering, culling, LOD, file access, and locomotion as
  separate runtime modules.
- Code donor value: high for `PLYLoader`, `GaussianSplatAsset`,
  `GaussianSplatRenderer`, `SplatSorter`, `SplatCuller`,
  `ChunkStreamingManager`, `VRFileBrowser`, and `FileSystemAccessor`.
- Product reference value: strong Quest viewer reference.
- What to inspect next: Android storage permissions, file-browser UX, adaptive
  quality thresholds, and memory caps.
- Caveats: overlaps conceptually with earlier splat waves but adds a clean
  Quest-focused module split.

### `julienkay/LightfieldVideoUnity`

- Interesting idea: layered-mesh light-field video is framed as a quality/
  performance sweet spot for VR playback.
- Code donor value: low because source is not present.
- Product reference value: useful as a caveat and product direction marker for
  high-resolution light-field media.
- What to inspect next: release behavior, asset format assumptions, and legal
  status if source is ever published.
- Caveats: compiled applications only and proprietary playback dependency.

## Product Direction

This wave supports a `spatial media viewer` branch that can compare NeRF,
Gaussian splats, light fields, panoramic video, and volumetric media under one
shared browser/navigation/performance shell.

