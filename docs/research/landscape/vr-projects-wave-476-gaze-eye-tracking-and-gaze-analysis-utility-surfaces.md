# Wave 476: Gaze Eye-Tracking And Gaze-Analysis Utility Surfaces

- Date: `2026-07-18`
- Scope: gaze input, eye-tracking shims, dwell buttons, and offline semantic
  gaze-analysis pipelines.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `Haddley/vision-eye-tracking` | Studied | Browser/WebXR eye-gaze shim, provider split, visible gaze cursor, and trainer metrics |
| `Adkaros/VR-GazeControl` | Studied | Minimal Unity head-forward dwell raycast manager and target trigger components |
| `eman2XR/VR-Gaze-pointer-and-buttons` | Studied | Unity gaze pointer prefab with reticle, dwell loader, hover audio, and button events |
| `xyethan/OcuShape` | Source-light reference | Eye ellipse/gaze-estimation concept with no inspected code donor surface |
| `ni1o1/vr-gaze-pipeline` | Studied | Offline 3D gaze pipeline from gaze rays to fixations, semantic labels, and attention shares |

## Project Notes

### `Haddley/vision-eye-tracking`

- Interesting idea:
  Prototype a WebXR `eye-tracking` feature shim around an OpenXR-style
  `XR_EXT_eye_gaze_interaction` mental model, while making sample quality and
  privacy boundaries visible.
- Code donor value:
  `installWebXREyeTracking(options)` patches `navigator.xr.requestSession` and
  adds `XRFrame.getEyeGazes(baseSpace)` with simulated and WebSocket providers,
  confidence, sample time, stale-sample rejection, and provider metadata.
- Product reference value:
  Good reference for an eye-gaze trainer or diagnostics panel because it shows
  fixation, smooth-pursuit, and saccade beads plus a visible cursor and local
  export flow.
- Source evidence:
  `webxr-eye-tracking.js`, `main.js`, and `RESEARCH.md`.
- Reusable core:
  provider abstraction, base-space gaze pose, confidence field, stale timeout,
  local-only export, visible local-bridge warning, gaze cursor, per-target
  error metrics, on-target threshold, RMS/mean error, and reacquisition latency.
- What not to copy:
  Do not imply shipping browser support for continuous gaze and do not treat the
  simulated provider as real calibration evidence.
- What to inspect next:
  Compare this shim against Quest/OpenXR eye-data providers and define a
  provider-neutral gaze sample schema.

### `Adkaros/VR-GazeControl`

- Interesting idea:
  Treat gaze input as a tiny component contract: a manager owns raycast timing,
  while targets only implement enter, leave, and complete events.
- Code donor value:
  `GazeManager.cs` uses camera-forward physics raycasts, gaze delay, cursor
  fill progress, and SendMessage event dispatch into `GazeTrigger`.
- Product reference value:
  Useful as a compact teaching/reference baseline for headset-only or no-hand
  UI activation.
- Source evidence:
  `Assets/Scripts/Gaze/GazeManager.cs` and `GazeTrigger.cs`.
- Reusable core:
  ray provider, current target, dwell timer, progress renderer, hover lifecycle,
  completion event, and target component.
- What not to copy:
  The bundled Unity `Library`/OVR/HoloToolkit bulk and the target-leave bug
  where leave can be sent to the current hit object rather than the previous
  target.
- What to inspect next:
  Convert the idea into an input-neutral gaze target interface with disabled,
  blocked, dwell, and cancel states.

### `eman2XR/VR-Gaze-pointer-and-buttons`

- Interesting idea:
  Package gaze selection as a prefab: reticle placement, hover/click audio,
  dwell loader, and UnityEvent hooks live together.
- Code donor value:
  `Pointer.cs` and `GazeButton.cs` show forward raycast, reticle placement on
  hit, tag-filtered buttons, enter/stay/exit lifecycle, `clickTime`, loader
  scaling, and hover/click audio.
- Product reference value:
  Strong micro-UX reference for simple VR menus where users need visual and
  audio confirmation before dwell activation.
- Source evidence:
  `Assets/Gaze pointer/Scripts/Pointer.cs` and `GazeButton.cs`.
- Reusable core:
  target tag/filter, reticle transform, dwell progress visualization, hover
  feedback, click feedback, activation event, and prefab-level setup.
- What not to copy:
  Tag-string assumptions, singleton pointer ownership, and lack of XR input
  abstraction.
- What to inspect next:
  Merge with a controller/pinch target interface so gaze is only one provider.

### `xyethan/OcuShape`

- Interesting idea:
  Use robust eye-ellipse estimation as a preprocessing step for gaze estimation
  rather than relying only on final gaze rays.
- Code donor value:
  No code donor value was confirmed in this pass because the repository was
  source-light.
- Product reference value:
  Reference only for a possible camera/CV preprocessing branch in eye-gaze
  tooling.
- Source evidence:
  README-level claim only.
- Reusable core:
  Treat as a follow-up note for eye ellipse quality metrics, not as a reusable
  implementation.
- What not to copy:
  Do not promote this into a method without inspected source or validation
  details.
- What to inspect next:
  Search for active eye-ellipse implementations with datasets, calibration, and
  runtime constraints.

### `ni1o1/vr-gaze-pipeline`

- Interesting idea:
  Convert raw HMD pose and gaze into semantic attention records by expanding a
  visual cone, computing estimated gaze points, segmenting fixations, labelling
  them by KNN, and aggregating attention shares.
- Code donor value:
  Strong offline analytics donor with `ConeConfig`, visual-cone expansion,
  3D I-DT fixation detection, saccade extraction, KNN labels, aggregation, CLI
  timing/memory logs, and documented input/output schemas.
- Product reference value:
  Useful for research dashboards, gaze QA tools, accessibility studies, and
  post-session attention reports.
- Source evidence:
  `pipeline/visual_cone.py`, `pipeline/idt_3d.py`,
  `pipeline/knn_labeller.py`, `analysis/aggregate_attention.py`, and
  `docs/data_format.md`.
- Reusable core:
  gaze stream schema, fixation schema, reference cloud/sign meshes, cone rays,
  attention weighting, 3D dispersion/time thresholds, semantic labels, and
  aggregate output.
- What not to copy:
  Do not present it as runtime overlay code; it is an offline research pipeline
  and external datasets are not redistributed.
- What to inspect next:
  Adapt its schemas into a privacy-aware gaze analytics artifact format for
  `VR-apps-lab`.

## Reusable Pattern Extraction

- Pattern candidate:
  `Gaze interaction and analysis pipeline with confidence and semantic target
  evidence`.
- Problem solved:
  VR utilities often treat gaze as a simple ray click; this wave shows the need
  to store confidence, dwell intent, sample freshness, target semantics, and
  privacy boundaries.
- Reusable core:
  gaze provider, base-space ray/pose, confidence, timestamp, stale gate, target
  lifecycle, dwell progress, feedback channels, fixation segmentation,
  semantic labels, aggregate attention, and export/retention labels.
- Source evidence:
  `Haddley/vision-eye-tracking`, `Adkaros/VR-GazeControl`,
  `eman2XR/VR-Gaze-pointer-and-buttons`, and `ni1o1/vr-gaze-pipeline`.
- Abstraction boundary:
  Keep runtime input events separate from offline analytics so a gaze button
  does not leak raw eye data into long-term study artifacts by default.
- What not to copy:
  Do not copy hidden eye-data collection, simulated provider claims, old Unity
  project caches, or semantic attention conclusions without calibration and
  consent.
- Method catalog action:
  Add `Method 921`.

## Why This Matters For `VR-apps-lab`

Gaze belongs in the utility foundation as both an input provider and a research
signal. The reusable lesson is not only "dwell click"; it is a clean split
between gaze source, target intent, visible feedback, confidence, analysis
artifacts, and privacy/retention policy.
