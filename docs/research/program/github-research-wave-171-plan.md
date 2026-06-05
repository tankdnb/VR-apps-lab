# GitHub Research Wave 171 Plan

- Date: `2026-06-05`
- Theme: `XR behavior recording, physiological replay, olfactory display, and sparse-camera mocap`
- Scope: XR experiment record/replay, in-situ analysis, physiological/event
  timeline surfaces, Unity recording/replay internals, olfactory device bridges,
  and sparse-camera motion-capture export pipelines.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

The repository needs more coverage of research-grade XR instrumentation:
recording user behavior, replaying sessions, linking event markers to timelines,
driving physical outputs, and importing reconstructed motion into VR/3D tools.
Wave 171 studies a coherent LIRIS XR cluster that spans documentation-first
tooling, Unity source, hardware bridging, and computer-vision mocap.

## Search Families

- XR behavioral recording and replay
- physiological timeline and in-situ analysis tools
- Unity XR event/object tracking packages
- multisensory and olfactory XR devices
- sparse-camera motion capture and BVH/USD/Rerun export helpers

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `liris-xr/PLUME` | Documentation-first record/replay toolbox with `.plm`, asset bundles, viewer timeline, event markers, and physiological signals | XR instrumentation product reference |
| `liris-xr/XREcho` | Unity source for recording tracked objects/events, replaying CSV sessions, and visualizing gaze/trajectory/heatmaps | Unity XR record/replay donor |
| `liris-xr/Nebula-Core` | Unity-to-serial/Android olfactory display bridge with head-proximity diffusion behavior and experiment CSV logging | Multisensory XR hardware bridge donor |
| `liris-xr/kineo` | Calibration-free sparse RGB camera motion capture with offline/online pipelines and BVH/USD/Rerun-style exports | XR-adjacent mocap helper donor |

## Dedupe Notes

- PLUME is retained as product/method documentation, not as a code donor,
  because this repository contains the docs site rather than recorder/viewer
  source.
- XREcho and PLUME are related conceptually but not duplicates: PLUME provides
  mature product framing, while XREcho exposes reusable Unity source patterns.
- Kineo is XR-adjacent rather than an HMD app; it is included because mocap
  export/import is directly useful for VR utility and content pipelines.

## Code-Level Pass Targets

- PLUME recorder/viewer workflow, `.plm` records, asset-bundle replay,
  physiological signals, event markers, and timeline UX;
- XREcho singleton/config managers, tracked object discovery, scene reload
  handling, CSV format/data files, replay clones, camera switching, gaze,
  trajectory, and heatmap scripts;
- Nebula serial/Android plugin bridge, port handshake, command mapping,
  proximity-based diffusion, GUI override, and experiment CSV logging;
- Kineo pipeline stage abstraction, Hydra configs, online camera calibration,
  live camera views, triangulation, bundle adjustment, BVH/USD exports, and
  research-license caveats.

## Expected Outputs

- New Wave 171 landscape synthesis.
- Registry/family placement for XR instrumentation, multisensory hardware, and
  sparse-camera mocap helper lines.
- Methods around docs-first instrumentation UX, Unity record/replay packages,
  replay analysis surfaces, olfactory display bridges, experiment state
  logging, modular CV mocap pipelines, and motion export helpers.
