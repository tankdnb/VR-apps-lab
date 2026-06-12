# GitHub Research Wave 287 Plan - Gaussian Splat XR Unity Viewers, VR Forks, and External Render Bus Surfaces

## Goal

Study Gaussian splat XR and Unity projects as reusable references for splat
import, runtime rendering, GPU sorting, VR viewer UX, dynamic playback,
generated-world import, and external render-bus surfaces.

## Research Questions

- How do projects import and normalize `.ply`, `.spz`, `.spx`, `.sog`,
  `.splat`, and dynamic splat data?
- Which runtime renderer, sorting, cutout, resource, and cleanup boundaries are
  reusable?
- How do VR viewers handle locomotion, file browsing, runtime loading, desktop
  fallback, and memory budgets?
- When is a repo a strong donor versus a fork/sample comparison node?

## Shortlist

- `wuyize25/gsplat-unity`
- `dylanebert/UnityGaussianSplatting`
- `HiFi-Human/DynGsplat-unity`
- `Enndee/Splatviewer_VR`
- `ninjamode/Unity-VR-Gaussian-Splatting`
- `ptc-lexvandersluijs/Unity3DGS_VR`
- `nigelhartman/worldlabs_unity`
- `RockyXu66/splatbus`
- `roth-hex-lab/Multi-Layer-Anatomy-GS-Unity-Rendering`

## Required Checks

- Deduplicate against prior Gaussian splat, spatial sensing, file browser,
  creative asset, and external surface-ingress waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep fork lineage, sample asset payload, secret/API, GPU interop, and
  hardware-support caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 287.
- Registry/family entries for Gaussian splat XR rendering and viewer surfaces.
- Method catalog entry for Gaussian splat XR rendering pipelines.
- Follow-up matrix around import formats, GPU resources, VR UX, dynamic
  sequences, generated worlds, and external render buses.
