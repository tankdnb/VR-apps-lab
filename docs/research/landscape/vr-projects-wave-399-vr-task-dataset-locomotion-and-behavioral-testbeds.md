# Wave 399: VR Task Dataset, Locomotion, and Behavioral Testbeds

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device
  tests.

## Theme

This wave studies VR testbeds that generate task datasets or compare user
behavior: annotated kitchen interactions, eye-tracked gambling studies, and
locomotion evaluation scenarios.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `michaelkoller/vacesimulator` | Studied | Annotated task dataset simulator |
| `JohnBacho/VIBES-Lab-Project2` | Studied | Eye-tracked behavioral study app |
| `VRatPolito/LET-VR` | Studied | Locomotion evaluation testbed |

## Findings

### `michaelkoller/vacesimulator`

- Interesting idea: use a rich VR kitchen to record object-interaction samples
  and postprocess RGB, depth, segmentation, predicates, recipes, and action
  events.
- Code donor value: `DisplayRecipe`, `RecordObjectPosRot`,
  `JSONDataStructures`, `ColorByNumber`, `DepthCamScript`, `InPredicate`,
  `OnPredicate`, `GraspMessage`, and `PlayModeManager`.
- Product reference value: excellent pattern for turning VR interactions into
  machine-learning-friendly datasets.
- What to inspect next: recording folder schema, replay state machine, object
  ID governance, segmentation color assignment, and predicate quality.
- Caveat: old Unity/SteamVR/VRTK stack and large assets; donor value is the
  dataset pipeline, not the legacy runtime shell.

### `JohnBacho/VIBES-Lab-Project2`

- Interesting idea: a VR behavioral study with dual gambling modalities,
  tutorial flow, wallets, trial-level CSV, and eye/pupil metrics.
- Code donor value: trial CSV schema, VIVE SRanipal integration, sXR
  `GazeInputManager`, wallet/bet/payout concepts, and companion CSV processor
  reference.
- Product reference value: useful as a study-app checklist for linking
  interaction events, physiological signals, and condition order.
- What to inspect next: trial controller scripts, calibration start flow,
  consent/ethics labels, and CSV processor assumptions.
- Caveat: gambling and physiological claims need careful ethics/privacy
  framing.

### `VRatPolito/LET-VR`

- Interesting idea: compare locomotion techniques with scenarios,
  questionnaire material, weighted scoring, configuration files, calibration,
  and per-scenario loggers.
- Code donor value: `LocomotionManager`, `InputManagement`,
  `Calibration`, `CalibrationData`, `ConfigurationLookUp`,
  `StatisticsLoggerBase`, `StatisticsLoggerS1/S2/S3`, and build helpers.
- Product reference value: strong evaluation harness for locomotion and comfort
  tradeoffs rather than a single locomotion implementation.
- What to inspect next: scoring spreadsheet, config parser, logger metrics,
  scenario task taxonomy, and custom locomotion adapter points.
- Caveat: some treadmill SDKs are excluded by license; custom techniques need
  clear plugin gates.

## Reusable Pattern Extraction

- Pattern candidate: `VR task testbed and dataset recorder`.
- Problem solved: VR research utilities need repeatable task conditions,
  calibrated participants, input/physiology streams, objective metrics, and
  replayable/exportable datasets.
- Reusable core: participant/config file, scenario selector, task condition,
  calibration artifact, input adapter, recording toggle, object/action event
  schema, predicate/segmentation/depth exports, trial CSV, logger sampling
  rate, scoring material, and replay/postprocess mode.
- Source evidence: VACE recording/postprocess scripts, VIBES trial/pupil CSV
  framing, and LET-VR configuration/calibration/statistics logger scripts.
- Abstraction boundary: separate experiment control, participant data, device
  adapters, task content, and export pipelines.
- What not to copy: clinical/behavioral claims without protocol context,
  gambling content, legacy SDK bundles, or hardware-specific assumptions hidden
  behind generic metrics.
- Method catalog action: add Method 844.
