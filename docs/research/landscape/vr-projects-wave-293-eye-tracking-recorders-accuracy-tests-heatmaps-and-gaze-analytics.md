# Wave 293 - Eye-Tracking Recorders, Accuracy Tests, Heatmaps, and Gaze Analytics

This wave studies VR eye-tracking projects as reusable references for gaze
recording, accuracy calibration, heatmaps, Pupil Labs/FOVE/PICO/Vive SRanipal
integration, CSV export, and research-data boundaries.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- VR eye-tracking recorders and CSV/logging pipelines;
- accuracy tests, field-of-view calibration, and target hit workflows;
- gaze heatmaps, gaze rays, target highlighting, and visual feedback;
- vendor SDK wrappers and sample projects with reusable data boundaries;
- source-light/demo-only eye-tracking candidates that should not be promoted
  without more source evidence.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `med-material/VREyeTrackingAccuracyTest` | Pupil Labs accuracy/FOV test harness | Studied | Circle targets, gaze path capture, FOV calibration, CSV logging, menu settings, and Pupil plugin payload |
| `RealBrandonChen/Unity-Eyetracking-Heatmap` | Pupil Labs heatmap/recording shell | Studied | Subscription controllers, frame/gaze listeners, recording requests, calibration controllers, and visualization scripts |
| `simpleOmnia/sXR` | Experiment framework with gaze channel | Studied | SRanipal gaze recording, tagged files, dataframe helper, replay/experiment infrastructure |
| `FoveHMD/UnityPlugin` | FOVE Unity SDK reference | Studied | Gaze recorder export settings, gaze object registration, calibration/test scenes, and project checks |
| `FoveHMD/FoveUnitySample` | FOVE gaze interaction sample | Studied | Minimal gaze ray cursor and combined-eye fallback behavior |
| `n3urovirtual/PicoXR_EyeTracking_Demo` | PICO gaze demo/source-light reference | Studied with source caveats | README/screenshots plus PICO SDK eye-tracking API surface rather than released app source |
| `VR-HCI-Group/Unity-VR-EyeTracking` | SRanipal eye-data recorder | Studied | Vive SRanipal callback, gaze ray, openness, pupil diameter/position, and CSV/TXT output |
| `caseycotes-turpin/EyeTrackingAnalysis` | Analysis search candidate | Source-light/exclusion note | README-only in this pass; useful mainly as a duplicate-search marker |

## Code-Level Findings

### `med-material/VREyeTrackingAccuracyTest`

- Interesting idea:
  an eye-tracking utility can combine FOV calibration, target shrink tests,
  gaze path capture, and participant/config logging in one harness.
- Code donor value:
  high. `LoggerBehavior.cs` logs every 50 ms; `CsvWriter.cs` serializes object
  properties; `GameController.cs` drives target/gaze display options; gaze and
  FOV scripts capture ray hits, saved paths, and target movement.
- Product reference value:
  very high for accuracy diagnostics and study-grade calibration screens.
- What to inspect next:
  Pupil plugin integration, database uploader, CSV headers, menu settings,
  target timing, privacy model, and whether imported MessagePack/FFmpeg code
  should be treated as vendor payload.

### `RealBrandonChen/Unity-Eyetracking-Heatmap`

- Interesting idea:
  Pupil Labs data can be separated into request, subscription, gaze, frame,
  calibration, recording, and visualization controllers.
- Code donor value:
  high. `GazeController.cs` forwards `GazeData` events; `FrameListener.cs`
  subscribes to eye frames and decodes eye index from topics;
  `RecordingController.cs` wraps start/stop recording and custom path options.
- Product reference value:
  high for heatmaps, gaze debugging, and recording controls.
- What to inspect next:
  ZeroMQ/Pupil service assumptions, calibration target flow, time sync,
  heatmap generation, and cleanup of subscriptions.

### `simpleOmnia/sXR`

- Interesting idea:
  gaze recording belongs inside a broader experiment framework with tagged
  output, replay, object tracking, scene objects, and settings.
- Code donor value:
  medium/high. `GazeHandler.cs` records SRanipal combined/left/right rays,
  screen fixation, eye positions/rotations, pupil sizes, and openness into a
  tagged `eyetracker` file; `DataFrame.cs` provides simple CSV analysis helpers.
- Product reference value:
  high for research-oriented VR utility shells.
- What to inspect next:
  conditional compilation, experiment handler file semantics, replay mode,
  controller/object channels, and dependency footprint.

### `FoveHMD/UnityPlugin`

- Interesting idea:
  a vendor plugin can expose gaze recording and object-gaze registration as
  reusable Unity behaviors.
- Code donor value:
  high as a vendor-reference boundary. `GazeRecorder.cs` provides export
  settings, recording sync modes, coordinate spaces, output folder behavior,
  and execution-order handling. `GazableObject.cs` registers colliders for gaze
  object detection and supports velocity-source selection.
- Product reference value:
  high for SDK adapter design, but tied to FOVE hardware/runtime.
- What to inspect next:
  calibration manager, event callbacks, profile scenes, settings editor,
  coordinate-space export details, and license constraints.

### `FoveHMD/FoveUnitySample`

- Interesting idea:
  a gaze cursor can fall back from per-eye gaze to combined gaze when a feature
  license denies access.
- Code donor value:
  medium. `FOVE3DCursor.cs` reads a gaze ray, falls back to combined gaze,
  raycasts, and places a cursor at hit point or a default point along the ray.
- Product reference value:
  medium/high for minimal gaze interaction examples.
- What to inspect next:
  `FoveBehavior`, control sample flow, error handling, cursor smoothing, and
  how samples differ from the plugin package.

### `n3urovirtual/PicoXR_EyeTracking_Demo`

- Interesting idea:
  gaze-based text-to-speech and gaze selection are useful product references
  for accessibility-oriented eye tracking.
- Code donor value:
  low/medium in this pass. The README says source was not yet released, while
  the visible tree mostly exposes PICO SDK/runtime code such as
  `PXR_EyeTracking.cs`.
- Product reference value:
  high conceptually for gaze-based selection/TTS UX, with source caveats.
- What to inspect next:
  branches/releases, actual demo source availability, PICO API changes after
  the README date, and permission/runtime requirements.

### `VR-HCI-Group/Unity-VR-EyeTracking`

- Interesting idea:
  a compact SRanipal recorder can capture gaze direction, gaze position,
  openness, pupil diameter, pupil position, and hit-distance metrics.
- Code donor value:
  medium/high. `EyeDataCollect.cs` and `EyeDataSave.cs` register SRanipal
  callbacks, retrieve gaze rays, write headers, and append tab/CSV data.
- Product reference value:
  high for simple Vive Pro Eye data logging and diagnostics.
- What to inspect next:
  callback lifecycle, file closing, coordinate mapping, time zone assumptions,
  and separation from bundled SteamVR payload.

### `caseycotes-turpin/EyeTrackingAnalysis`

- Interesting idea:
  analysis-only repos may be useful once raw data schema is known.
- Code donor value:
  low in this pass because only README-level content was visible.
- Product reference value:
  low/medium as a future analysis-search marker.
- What to inspect next:
  branches, notebooks, releases, datasets, and whether analysis scripts are
  distributed outside the default tree.

## Reusable Pattern Extraction

- Pattern candidate:
  eye-tracking recorder/analytics boundary across vendor gaze ingress,
  calibration, target tests, session logging, heatmaps, and export privacy.
- Problem solved:
  gaze data is useful only when source, calibration state, timing, coordinate
  space, target context, and consent/export rules stay visible.
- Reusable core:
  vendor adapter, gaze ray sampler, validity/confidence channel, calibration
  targets, FOV/accuracy task, gaze path/heatmap visualizer, recording state,
  CSV/tagged-file schema, frame listener, session metadata, and analysis hook.
- Source evidence:
  `VREyeTrackingAccuracyTest`, `Unity-Eyetracking-Heatmap`, `sXR`,
  `UnityPlugin`, `FoveUnitySample`, `PicoXR_EyeTracking_Demo`, and
  `Unity-VR-EyeTracking`.
- Abstraction boundary:
  keep vendor SDK, calibration task, sampling/logging, visualization, analysis,
  and consent/privacy separate.
- What not to copy:
  unclosed file streams, hardcoded local paths, telemetry without consent,
  vendor SDK payloads as original architecture, or source-light demos as
  donor-quality implementations.
- Method catalog action:
  add an eye-tracking recorder/analytics method.

## Follow-Up Gaps

- Build an eye-tracking utility matrix across vendor SDK, calibration,
  validity/confidence, coordinate spaces, event timing, CSV schema, heatmaps,
  and privacy.
- Deepen `VREyeTrackingAccuracyTest`, `Unity-Eyetracking-Heatmap`, `sXR`, and
  `FoveHMD/UnityPlugin` as strongest donor clusters.
- Compare with face/eye-tracking module waves so avatar-tracking and
  research-recording patterns stay separate.
- Consider a future reuse plan for a neutral gaze recorder with adapters,
  calibration status, schema versioning, and explicit export consent.
