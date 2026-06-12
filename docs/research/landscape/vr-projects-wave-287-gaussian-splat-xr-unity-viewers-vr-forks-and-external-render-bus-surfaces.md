# Wave 287 - Gaussian Splat XR Unity Viewers, VR Forks, and External Render Bus Surfaces

This wave studies Gaussian splat XR and Unity projects as reusable references
for splat importers, GPU resource lifecycles, sorting, VR viewer UX, runtime
loading, dynamic splat streaming, generated-world import, and external render
bus integration.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Unity Gaussian splat package/runtime implementations;
- VR-focused viewer forks and sample projects;
- importer and runtime loading formats such as `.ply`, `.spz`, `.spx`, `.sog`,
  and `.splat`;
- dynamic/block-streamed splat sequences;
- external GPU/render-bus handoff experiments;
- generated scene/world import tooling.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `wuyize25/gsplat-unity` | Unity Gaussian splat package/runtime | Studied | Scripted importer, compression/cache, GPU resources, sorter, cutouts, global draw |
| `dylanebert/UnityGaussianSplatting` | Minimal Unity `.splat` importer | Studied | Compact ScriptedImporter and data-binder baseline |
| `HiFi-Human/DynGsplat-unity` | Dynamic Gaussian splat runtime | Studied | Addressables block streaming, frame assets, compute updates, codebooks |
| `Enndee/Splatviewer_VR` | VR splat viewer fork | Studied | Runtime file loading, OpenXR controls, browser/favorites/movie mode, file associations |
| `ninjamode/Unity-VR-Gaussian-Splatting` | VR/URP splat project | Studied with fork/sample caveats | VR sample project and package layout around Gaussian splatting |
| `ptc-lexvandersluijs/Unity3DGS_VR` | VR/BIRP splat project | Studied with fork/sample caveats | XR Interaction Toolkit sample integration and hand/input side nodes |
| `nigelhartman/worldlabs_unity` | Generated-world to Unity splat import | Studied | API/editor window, prompt workflow, `.spz` import, env key loader |
| `RockyXu66/splatbus` | External render bus and Unity native plugin | Studied | Python/OpenGL client, Unity native plugin, CUDA IPC, socket/JSON handshake |
| `roth-hex-lab/Multi-Layer-Anatomy-GS-Unity-Rendering` | Domain-specific splat rendering reference | Studied with specialization caveat | Multi-layer anatomy splat viewer/use-case framing |

## Code-Level Findings

### `wuyize25/gsplat-unity`

- Interesting idea:
  Gaussian splats are packaged as a Unity-native runtime with importer,
  asset/cache policy, renderer registration, GPU sorting, cutouts, and optional
  global merged rendering.
- Code donor value:
  very high: `GsplatImporter.cs` handles `.ply`/`.spz`, source-coordinate
  conversion, compression modes, cache keys, import progress, and renderer
  reference refresh; `GsplatRenderer.cs` exposes asset binding, async upload,
  sort/cutout cadence, global sorter registration, bounds, GPU resources, and
  draw/update lifecycle.
- Product reference value:
  high for any `VR-apps-lab` spatial asset viewer, import wizard, or rendering
  substrate around large point/splat scenes.
- What to inspect next:
  `GsplatRendererImpl`, global sorter, cutout editor, VR stereo rendering
  behavior, memory budgets, and mobile/Quest constraints.

### `dylanebert/UnityGaussianSplatting`

- Interesting idea:
  a smaller `.splat` Unity flow demonstrates the minimum shape: a
  `ScriptedImporter` creates a `SplatData` asset that downstream binders and
  shaders can consume.
- Code donor value:
  medium: `SplatImporter.cs` is compact but useful as a minimal importer
  pattern; `SplatData`, binders, gizmos, and shadergraph assets are the next
  donor points.
- Product reference value:
  medium for starter projects and teaching the split between imported data,
  renderer, and scene controls.
- What to inspect next:
  binary format parsing, shadergraph data layout, camera/controller scripts,
  and memory/performance limits.

### `HiFi-Human/DynGsplat-unity`

- Interesting idea:
  dynamic splats are represented as frame/block assets that can be streamed,
  decoded, and uploaded over time rather than one static asset.
- Code donor value:
  very high: `DynGsplatRenderer.cs` shows `AssetReferenceT`, async/sync
  loading, sliding-window block streaming, `DynGplatBlockAsset` handles,
  compute kernels for opacity/block updates, codebook buffers, frame indices,
  and resource disposal.
- Product reference value:
  high for time-varying volumetric captures, avatar/performance replay, and
  large dynamic scene playback.
- What to inspect next:
  importer/compression scripts, Addressables packaging, frame timing,
  streaming failure behavior, and VR frame budget implications.

### `Enndee/Splatviewer_VR`

- Interesting idea:
  Gaussian splats become a full VR utility rather than only an editor package:
  runtime file loading, OpenXR locomotion, browser/favorites, movie mode,
  desktop fallback, and file associations.
- Code donor value:
  high by repository documentation and package layout: README names runtime
  loading for `.ply`, `.spz`, `.spx`, and `.sog`, `RuntimeSplatLoader`,
  GPU-friendly layout upload, shell association helpers, and browser preload
  RAM budget.
- Product reference value:
  very high for a VR-native splat viewer UX and local asset browser.
- What to inspect next:
  runtime loader scripts, browser/favorites state, Quest file permissions,
  movie mode buffering, and file association scripts.

### `ninjamode/Unity-VR-Gaussian-Splatting`

- Interesting idea:
  Gaussian splat rendering is combined with a Unity VR/URP project and XR
  Interaction Toolkit sample assets to create a ready viewer baseline.
- Code donor value:
  medium with fork/sample caveats: the tree exposes package runtime/editor
  files such as `GaussianSplatRenderer`, `GpuSorting`, URP pass/feature,
  cutout tools, and VR scene scripts like anatomy spawning/cycling.
- Product reference value:
  medium/high for "put splats into an XR scene" scaffolding.
- What to inspect next:
  custom VR scripts versus upstream package code, interaction controls,
  render pipeline settings, and asset payload hygiene.

### `ptc-lexvandersluijs/Unity3DGS_VR`

- Interesting idea:
  a BIRP/VR fork shows how a Gaussian splat package is paired with XR
  Interaction Toolkit starter assets and hand/input side scripts.
- Code donor value:
  medium with fork/sample caveats: the readable value is the package layout,
  `GaussianSplatRenderer`, `GpuSorting`, editor tools, and `AnimateHandOnInput`
  style input glue.
- Product reference value:
  medium as a comparison node for render-pipeline and XR sample integration.
- What to inspect next:
  actual scene interaction logic, hand input behavior, BIRP constraints, and
  divergence from upstream GaussianSplatting package.

### `nigelhartman/worldlabs_unity`

- Interesting idea:
  generated 3D worlds can flow into Unity as mesh or Gaussian splat assets
  through an editor window with prompt input, API polling, import quality, and
  scene loading options.
- Code donor value:
  high: `WorldLabsEditorWindow.cs` shows API configuration, text/image/video
  prompts, paginated world list, pending operations, import menu, `.spz`/`.ply`
  file import, compression-quality dialog, and scene placement; `EnvLoader.cs`
  shows `.env`, embedded Resources, and system environment resolution.
- Product reference value:
  high for generated XR asset workbenches and "create/import/view" editor UX.
- What to inspect next:
  `WorldLabsClient`, asset download paths, secret handling, build-time env
  embedding, and offline/cache behavior.

### `RockyXu66/splatbus`

- Interesting idea:
  an external Gaussian splat renderer can drive Unity or OpenGL clients through
  CUDA IPC, socket/JSON handshakes, shared color/depth buffers, and native
  rendering plugin events.
- Code donor value:
  very high but advanced: `RenderingPlugin.cpp` shows Unity native plugin
  lifecycle, rendering-thread texture/buffer handles, D3D/OpenGL/CUDA interop,
  length-prefixed TCP packets, base64 IPC handles, JSON metadata, reconnect
  loop, color/depth buffer offsets, and cleanup; `viewer.py` shows a Python
  OpenGL client using CUDA texture registration and camera-pose messages.
- Product reference value:
  high for advanced external-renderer-to-XR-surface experiments.
- What to inspect next:
  `splatbus` protocol package, synchronization semantics, depth composition,
  failure cleanup, cross-GPU constraints, and security of local IPC.

### `roth-hex-lab/Multi-Layer-Anatomy-GS-Unity-Rendering`

- Interesting idea:
  Gaussian splats are used as a domain-specific multi-layer anatomy rendering
  reference, showing medical/scientific use-case pressure on viewer controls and
  layer management.
- Code donor value:
  low/medium in this pass because the value is specialized and appears close
  to package/fork layout rather than a new generic renderer.
- Product reference value:
  medium for anatomy/scientific viewer product framing and layer-oriented
  spatial asset inspection.
- What to inspect next:
  layer toggles, scene organization, annotation needs, and whether the project
  adds unique runtime code beyond upstream package material.

## Reusable Pattern Extraction

- Pattern candidate:
  Gaussian splat XR rendering pipeline across import formats, GPU resources,
  VR viewer UX, dynamic sequences, generated worlds, and external render buses.
- Problem solved:
  large splat scenes need a pipeline that covers import, compression, GPU
  upload, sorting, cutouts, runtime file loading, VR navigation, dynamic
  playback, generation/import UX, and external renderer integration without
  binding every step to one Unity scene.
- Reusable core:
  scripted importer, source-coordinate conversion, cache key, asset resource
  lifecycle, GPU buffers, sorter, cutouts, render-pipeline pass, runtime file
  loader, file browser/favorites, desktop fallback, dynamic block streaming,
  generated-world API import, environment-secret loader, external color/depth
  render bus, camera pose protocol, and cleanup/error policy.
- Source evidence:
  `gsplat-unity`, `UnityGaussianSplatting`, `DynGsplat-unity`,
  `Splatviewer_VR`, `Unity-VR-Gaussian-Splatting`, `Unity3DGS_VR`,
  `worldlabs_unity`, `splatbus`, and
  `Multi-Layer-Anatomy-GS-Unity-Rendering`.
- Abstraction boundary:
  keep file import, asset compression/cache, renderer resources, sort/cutout
  policy, VR controls/browser, dynamic streaming, generation API, and external
  render transport separate.
- What not to copy:
  huge sample asset payloads, upstream fork code without noting lineage,
  secret embedding without user control, CUDA/D3D/OpenGL interop without
  cleanup and hardware checks, or viewer UX without file-permission and memory
  budgets.
- Method catalog action:
  add a Gaussian splat XR rendering method.

## Follow-Up Gaps

- Build a Gaussian splat XR matrix across `.ply`, `.spz`, `.spx`, `.sog`, and
  `.splat` import, source coordinates, GPU sorting, cutouts, runtime loading,
  VR controls, dynamic blocks, generated worlds, and external render buses.
- Deepen `wuyize25/gsplat-unity`, `HiFi-Human/DynGsplat-unity`, and
  `Enndee/Splatviewer_VR` as the strongest reusable donors.
- Deepen `RockyXu66/splatbus` only as an advanced external-renderer pattern
  with security, GPU, and cleanup caveats.
- Treat VR forks as comparison nodes unless they add clear unique interaction,
  rendering, or runtime loading code beyond the package lineage.
