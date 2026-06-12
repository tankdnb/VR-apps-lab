# GitHub Research Wave 287 Backlog - Gaussian Splat XR Unity Viewers, VR Forks, and External Render Bus Surfaces

## Executed Scope

- Searched and deduplicated Gaussian splat Unity packages, VR viewer forks,
  generated-world importers, and external render-bus projects.
- Froze a nine-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted scripted importers, source-coordinate conversion, renderer
  registration, GPU sorting/cutouts, dynamic block streaming, VR runtime file
  loading, file browser/favorites, WorldLabs prompt/import flow, `.env`
  handling, CUDA IPC, socket/JSON handshakes, and Unity native plugin cleanup
  concerns.

## Studied Projects

- `wuyize25/gsplat-unity`
- `dylanebert/UnityGaussianSplatting`
- `HiFi-Human/DynGsplat-unity`
- `Enndee/Splatviewer_VR`
- `ninjamode/Unity-VR-Gaussian-Splatting`
- `ptc-lexvandersluijs/Unity3DGS_VR`
- `nigelhartman/worldlabs_unity`
- `RockyXu66/splatbus`
- `roth-hex-lab/Multi-Layer-Anatomy-GS-Unity-Rendering`

## Backlog Findings

- Build a Gaussian splat XR matrix across `.ply`, `.spz`, `.spx`, `.sog`, and
  `.splat` import, source coordinates, GPU sorting, cutouts, runtime loading,
  VR controls, dynamic blocks, generated worlds, and external render buses.
- Deepen `wuyize25/gsplat-unity`, `HiFi-Human/DynGsplat-unity`, and
  `Enndee/Splatviewer_VR` as the strongest reusable donors.
- Deepen `RockyXu66/splatbus` only as an advanced external-renderer pattern
  with security, GPU, and cleanup caveats.
- Treat VR forks as comparison nodes unless they add clear unique interaction,
  rendering, or runtime loading code beyond the package lineage.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a Gaussian splat XR rendering method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
