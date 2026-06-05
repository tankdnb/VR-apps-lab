# VR Projects Wave 125: Unity VR Experiment Frameworks, Data Capture, and Study Orchestration Helpers

- Date: `2026-06-05`
- Goal: study Unity-based VR experiment frameworks and research helpers as
  reusable references for session/trial orchestration, data handlers, tracker
  logging, remote settings, and study deployment.

## Why this wave exists

`VR-apps-lab` is not a psychology experiment repository, but VR experiment
frameworks contain strong reusable architecture for any utility that needs:

- repeatable sessions;
- block/trial lifecycle;
- settings provenance;
- pose/input trackers;
- output tables and files;
- resume/fallback behavior;
- cloud or local upload sidecars.

These patterns transfer cleanly to diagnostics, calibration, training,
accessibility, and operator tools.

## Better workflow used in this wave

1. searched GitHub by Unity VR experiment framework, UXF, trial manager,
   data capture, and VR motion tracking families;
2. deduplicated against engine/toolkit waves and existing data-capture
   references;
3. froze a bounded shortlist;
4. inspected source code from local-only cache;
5. avoided running, building, installing, or launching any project;
6. extracted reusable lifecycle, data, tracker, and deployment methods.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `immersivecognition/unity-experiment-framework` | Canonical UXF session/block/trial/data-handler/tracker framework |
| `BioMotionLab/TUX` | Editor-authored experiment design, variable system, and runtime runner |
| `jinwook31/Unity-Experiment-Trial-Manager` | Minimal CSV-driven trial manager |
| `Nesbi/PsyWueVR` | Psychology VR controller with subject profile and headtracking toggles |
| `social-spatial-interaction-lab/VR_Motion_Tracker` | UXF plus Unity MR/OpenXR tracking shell |
| `SensoriMotorControlLab/vr_experiment_framework_v3` | JSON/UXF task generator with pseudo-randomization and resume |
| `jackbrookes/uxf-s3-uploader` | UXF write-file cloud upload sidecar |
| `jackbrookes/uxf-web-settings` | Remote settings download with local fallback and session setup |

## Deep-pass notes by project

## `immersivecognition/unity-experiment-framework`

- GitHub:
  [immersivecognition/unity-experiment-framework](https://github.com/immersivecognition/unity-experiment-framework)
- What it is:
  the Unity Experiment Framework, a session/block/trial/data framework for
  Unity experiments.
- Interesting idea:
  experiments become reusable when lifecycle, settings, trackers, and storage
  backends are explicit framework objects instead of scene-specific scripts.
- Code-level notes:
  `Session.cs` owns participant details, blocks, trials, settings, active data
  handlers, tracked objects, save flags, base paths, and lifecycle events.
  `Trial.cs` stores trial status, settings, results, begin/end behavior, and
  per-trial file emission. `Tracker.cs` defines measurement descriptors,
  update modes, recording state, and data rows. `DataHandler.cs` abstracts
  tables, JSON, text, bytes, and data-type folder routing.
- Code donor value:
  very high for lifecycle, tracker, and storage boundaries.
- Product reference value:
  very high for calibration, diagnostics, and guided-study utilities.
- Caveats:
  framework scope is larger than many small tools need.
- What to inspect next:
  extract a minimal session/trial/tracker subset for non-experiment VR
  utilities.

## `BioMotionLab/TUX`

- GitHub:
  [BioMotionLab/TUX](https://github.com/BioMotionLab/TUX)
- What it is:
  a Unity experiment toolkit with editor-authored design assets, runtime
  runners, variable systems, and output managers.
- Interesting idea:
  research workflows benefit from separating experiment design authoring from
  runtime execution, while still giving designers variable/randomization
  control.
- Code-level notes:
  `ExperimentRunner.cs` loads an experiment design, script references, session
  data, trial table mode, GUI, runnable design, output manager, and custom
  experiment class. `OutputManager.cs` writes `Outputtable` data through
  events. `ExperimentDesignFile.cs` stores repetitions, randomization modes,
  factory variables, column names, control settings, and GUI settings.
- Code donor value:
  high for editor-authored design and runtime runner split.
- Product reference value:
  high for internal utility builders and guided operator workflows.
- Caveats:
  broad toolkit with research-domain assumptions.
- What to inspect next:
  compare the design-file model with UXF settings and VR-Builder graph
  workflows.

## `jinwook31/Unity-Experiment-Trial-Manager`

- GitHub:
  [jinwook31/Unity-Experiment-Trial-Manager](https://github.com/jinwook31/Unity-Experiment-Trial-Manager)
- What it is:
  a compact CSV-driven Unity trial manager.
- Interesting idea:
  a lightweight CSV loop can be enough for fast VR prototypes that need
  repeatable conditions without a full framework.
- Code-level notes:
  `ExperimentManager.cs` initializes `TrialData`, reads trial columns, records
  result arrays, advances rows, and resets the environment. The repository also
  contains CSV reader/writer, logger, timer, and trial data helpers.
- Code donor value:
  medium for minimum viable trial-loop anatomy.
- Product reference value:
  medium for small diagnostics and calibration prototypes.
- Caveats:
  narrow and less structured than UXF or TUX.
- What to inspect next:
  use only as a simple-baseline comparison node.

## `Nesbi/PsyWueVR`

- GitHub:
  [Nesbi/PsyWueVR](https://github.com/Nesbi/PsyWueVR)
- What it is:
  a Unity VR psychology experiment helper package.
- Interesting idea:
  a study controller can combine subject representation, input file defaults,
  camera/headtracking toggles, blackout, instructions, and status UI in one
  scene-level coordinator.
- Code-level notes:
  `ExperimentController.cs` requires `DataReader` and `DataWriter`, creates a
  default input key/value file if missing, configures subject representation,
  parents the camera to the viewpoint, and controls blackout, instructions,
  status, and headtracking camera scale.
- Code donor value:
  medium for subject/profile and scene-control orchestration.
- Product reference value:
  medium for guided setup and accessibility-style user state.
- Caveats:
  research-specific and older Unity assumptions.
- What to inspect next:
  compare subject/session setup with UXF participant details.

## `social-spatial-interaction-lab/VR_Motion_Tracker`

- GitHub:
  [social-spatial-interaction-lab/VR_Motion_Tracker](https://github.com/social-spatial-interaction-lab/VR_Motion_Tracker)
- What it is:
  a Unity MR/OpenXR motion tracker built around UXF and XR starter assets.
- Interesting idea:
  a practical data-capture shell can be thin if it composes UXF with an XR/MR
  template and scene-level start/finish controls.
- Code-level notes:
  custom code under `Assets/Mine` is small, including UXF session start/end
  hooks. The project includes UXF rig usage, streaming assets for shuttle task
  settings, OpenXR configuration, Meta controller profiles, and passthrough
  feature flags.
- Code donor value:
  medium for composition of UXF and XR/MR template pieces.
- Product reference value:
  medium-high for pose-logging shells.
- Caveats:
  custom code is thin; much value comes from composition choices.
- What to inspect next:
  compare with Meta MR motif samples and UXF tracking modules.

## `SensoriMotorControlLab/vr_experiment_framework_v3`

- GitHub:
  [SensoriMotorControlLab/vr_experiment_framework_v3](https://github.com/SensoriMotorControlLab/vr_experiment_framework_v3)
- What it is:
  a Unity/UXF-based VR experiment framework with JSON-driven task generation.
- Interesting idea:
  a study generator can build blocks and trials from settings prefixes,
  pseudo-randomize linked variables, resume progress, and instantiate task
  logic from reusable task classes.
- Code-level notes:
  `ExperimentGenerator.cs` reads UXF session settings, selects session blocks,
  handles `trials_in_block`, interprets `per_block_` and `per_block_list_`
  prefixes, supports pseudo-randomization and linked pseudo-random lists,
  resumes with `PlayerPrefs`, and serializes block settings with JSON. The
  project includes controller, task, input handler, tracker, and serializer
  components.
- Code donor value:
  high for data-driven block/trial generation and resume.
- Product reference value:
  high for calibration and guided utility workflows.
- Caveats:
  tightly coupled to UXF and lab task assumptions.
- What to inspect next:
  extract a generic settings-prefix convention for utility wizards.

## `jackbrookes/uxf-s3-uploader`

- GitHub:
  [jackbrookes/uxf-s3-uploader](https://github.com/jackbrookes/uxf-s3-uploader)
- What it is:
  a Unity sidecar that uploads UXF write-file outputs to S3.
- Interesting idea:
  data export can be attached as a sidecar to the framework's write-file event
  instead of being baked into trial logic.
- Code-level notes:
  `S3Uploader.cs` uses AWS Cognito credentials and S3 bucket ScriptableObjects,
  accepts `UXF.WriteFileInfo`, tags objects, tracks in-flight uploads, calls
  async `PutObjectAsync`, and disposes the S3 client.
- Code donor value:
  medium-high for cloud upload sidecar shape.
- Product reference value:
  medium-high for diagnostics and capture upload workflows.
- Caveats:
  AWS-specific and credential-sensitive.
- What to inspect next:
  compare with local-only and offline-first data handlers.

## `jackbrookes/uxf-web-settings`

- GitHub:
  [jackbrookes/uxf-web-settings](https://github.com/jackbrookes/uxf-web-settings)
- What it is:
  a Unity helper that downloads UXF session settings from the web with a local
  fallback.
- Interesting idea:
  remote study configuration should include a cached fallback and write release
  metadata into the session.
- Code-level notes:
  `WebSessionSetup.cs` downloads settings JSON with `UnityWebRequest`, falls
  back to `StreamingAssets/web_settings.json`, writes the fallback after a
  successful download, creates participant details from a short GUID, device,
  datetime, and editor flag, begins a UXF session, and records release info.
- Code donor value:
  medium-high for remote-config plus fallback session setup.
- Product reference value:
  high for deployment-friendly VR tools.
- Caveats:
  assumes web availability and UXF session shape.
- What to inspect next:
  combine with uploader sidecars into a generic deployment harness.

## Cross-project synthesis

This wave adds a reusable `VR study and data-capture harness` pattern:

- define a session object with participant/context metadata;
- generate blocks/trials from settings, CSV, JSON, or editor-authored assets;
- attach trackers to pose, input, and custom measurements;
- write data through interchangeable handlers;
- expose remote settings, local fallback, and upload as sidecars;
- keep start/end/resume states explicit.

The strongest donor is UXF's lifecycle/data-handler/tracker split. TUX and
`vr_experiment_framework_v3` add strong authoring and task-generation lessons.

## Follow-up

1. Extract a small `session/trial/tracker/data-handler` blueprint for
   diagnostics and calibration utilities.
2. Compare Unity experiment orchestration with teleoperation data-capture and
   MR motif samples.
3. Consider a reuse plan only if `VR-apps-lab` starts a runnable calibration,
   diagnostics, or guided-test prototype.
