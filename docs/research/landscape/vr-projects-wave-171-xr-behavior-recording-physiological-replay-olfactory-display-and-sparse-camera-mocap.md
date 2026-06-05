# VR Projects Wave 171: XR Behavior Recording, Physiological Replay, Olfactory Display, and Sparse-Camera Mocap

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 171 studies research-grade XR instrumentation: recording and replaying
experiences, linking event markers and physiological signals to timelines,
driving physical olfactory devices from Unity scenes, and reconstructing motion
from sparse RGB cameras for export into 3D/VR pipelines.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `liris-xr/PLUME` | XR instrumentation product reference | Strong docs/UX/method reference |
| `liris-xr/XREcho` | Unity XR record/replay donor | Strong source-level instrumentation donor |
| `liris-xr/Nebula-Core` | Multisensory XR hardware bridge donor | Strong serial/Android physical-output donor |
| `liris-xr/kineo` | Sparse-camera mocap helper donor | Strong pipeline/export reference; research-license caveat |

## `liris-xr/PLUME`

- Interesting idea:
  frame XR research instrumentation as a recorder/viewer workflow: record the
  environment, user behavior, event markers, and synchronized physiological
  signals into `.plm`, then replay sessions with an independent viewer,
  timeline, camera switching, event markers, and analysis surfaces.
- Code donor value:
  low for source because this repository is documentation-first, but high for
  workflow, UX, and documentation structure.
- Product reference value:
  very high for future VR-apps-lab instrumentation and replay tools.
- What to inspect next:
  study `PLUME-Recorder` and `PLUME-Viewer` source repositories separately if
  available and license-compatible.
- Source evidence:
  `docs/learn/tutorials/beginner/basics/record.md`,
  `replay.md`, `record_custom_data.md`, `in-situ_analysis.md`, and heatmap
  tutorial docs.
- Reusable pattern extraction:
  docs-first XR instrumentation tutorial track with recorder, record file,
  asset bundle, viewer, timeline, markers, and physiological signals.
- Reusable core:
  let users add a recorder with minimal app changes, capture native-frequency
  physiological streams independently from the app refresh rate, store a
  portable session file, replay through a standalone viewer, and make event
  markers visible both in a list and on a timeline.
- Do not copy directly:
  product claims without verifying recorder/viewer source behavior.
- Caveats:
  repository is a documentation site, not the full implementation source.

## `liris-xr/XREcho`

- Interesting idea:
  implement Unity-side XR recording and replay with tracked object discovery,
  camera/controller/interactable tracking, scene load events, CSV metadata and
  data files, clone-based replay, camera switching, gaze visualization,
  trajectory display, and heatmaps.
- Code donor value:
  high for instrumentation internals: record manager, replay manager, event
  manager, data providers, CSV formats, object path tracking, and analysis
  components.
- Product reference value:
  high for replayable diagnostics and study tooling inside Unity prototypes.
- What to inspect next:
  modernize the architecture around namespaces, tests, OpenXR events, and a
  cleaner data-provider/replay-observer boundary.
- Source evidence:
  `Assets/XREcho/Scripts/XREcho.cs`,
  `Record/RecordingManager.cs`, `Record/EventManager.cs`,
  `Record/IRecordDataProvider.cs`, `Replay/ReplayManager.cs`,
  `Replay/ShowGaze.cs`, `Analysis/Heatmap/PositionHeatmapManager.cs`, and UI
  scripts.
- Reusable pattern extraction:
  Unity XR behavioral recording/replay package with providers, metadata, event
  files, and in-situ analysis surfaces.
- Reusable core:
  auto-discover main camera, XR controllers, interactables, tracked layers, and
  optional eye tracker; export object/event formats separately from data rows;
  preserve recording/replay across scene loads; clone tracked objects for
  replay; expose trajectory, gaze, heatmap, and timeline controls.
- Do not copy directly:
  old singleton-heavy structure or TODO-heavy internals without refactor.
- Caveats:
  useful source donor but needs cleanup before being a modern baseline.

## `liris-xr/Nebula-Core`

- Interesting idea:
  bridge Unity XR scene behavior to a physical olfactory display through serial
  communication on Windows/editor or an Android plugin on Quest, then drive
  odor diffusion by head proximity, triggers, GUI override, and experiment
  randomization/logging.
- Code donor value:
  high for serial port handshake, Android plugin wrapper, command mapping,
  physical-output state, proximity/duty-cycle behavior, and CSV experiment
  logging.
- Product reference value:
  high for multisensory VR tools and physical-output bridges beyond haptics.
- What to inspect next:
  compare Nebula's command model with haptics and OSC/serial bridge patterns
  from earlier physical-output waves.
- Source evidence:
  `Nebula-UnitySoftware/Assets/Scripts/Nebula/NebulaManager.cs`,
  `NebulaOdorDiffuser.cs`,
  `Nebula-Experiment/UnitySoftware/Assets/Scripts/NebulaStaticCom.cs`, and
  `PseudoRandomizerExperiment.cs`.
- Reusable pattern extraction:
  olfactory display bridge from Unity scenario logic to Android/native diffuser
  commands; experiment randomizer/state machine for multisensory XR trials.
- Reusable core:
  find the device through a handshake, map semantic commands to device
  commands, provide both automatic proximity behavior and UI override, keep
  physical output cleanup on application quit, and log experiment trial state
  into CSV.
- Do not copy directly:
  blocking threads, thread aborts, or device-specific serial commands without a
  safer abstraction.
- Caveats:
  hardware-specific and experimental; strongest value is bridge shape.

## `liris-xr/kineo`

- Interesting idea:
  reconstruct metric 3D motion from sparse RGB cameras without complex manual
  calibration, using modular pipeline stages, offline/online modes, live camera
  calibration, 2D keypoint detectors, triangulation, bundle adjustment, and
  export to BVH/USD/Rerun-style visualization outputs.
- Code donor value:
  high for pipeline-stage architecture, Hydra config composition, online camera
  flow, triangulation, bundle adjustment history/timing annotations, and motion
  export stages.
- Product reference value:
  high for future mocap import/export helpers, avatar animation preparation,
  and external motion capture utility branches.
- What to inspect next:
  decide whether VR-apps-lab should track BVH, USD, Rerun, or Unity/Unreal
  import helpers as the primary reusable output path.
- Source evidence:
  `README.md`, `kineo/pipeline/pipeline.py`,
  `kineo/demo/online/demo.py`, `kineo/geometry/triangulation.py`,
  `kineo/pipeline/stages/bundle_adjustment.py`,
  `kineo/pipeline/stages/export_to_usd.py`,
  `kineo/pipeline/stages/bvh/export_bvh.py`, and
  `configs/demo/realtime/realtime_viz.yaml`.
- Reusable pattern extraction:
  modular sparse-camera mocap reconstruction pipeline with online calibration
  and motion export stages.
- Reusable core:
  define typed pipeline stages with runtime configs, instantiate them from
  Hydra/OmegaConf, collect live or offline multi-camera views, load/validate
  camera calibration annotations, run detection/reconstruction stages, track
  per-stage timings, and export reconstructed motion to interchange formats.
- Do not copy directly:
  model-heavy research code, datasets, checkpoints, or non-commercial research
  licensed components into public utility code.
- Caveats:
  research-license and heavy ML dependency stack; best as architecture/export
  reference unless a narrower compatible helper is extracted.

## Cross-Project Lessons

- XR instrumentation needs a complete chain: capture, metadata, event markers,
  analysis views, replay controls, and portable export/replay packaging.
- Timeline UX is a reusable diagnostic pattern, not only a research feature.
- Physical-output bridges should model device discovery, semantic commands,
  override modes, cleanup, and experiment logging explicitly.
- Mocap helper tooling belongs in the repository's broader VR utility scope
  because it feeds avatar animation, replay, diagnostics, and content pipelines
  even when it is not an HMD app.
