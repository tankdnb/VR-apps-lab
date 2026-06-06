# VR Projects Wave 224: XR Research Data Lifecycle Templates, Validation, and Analysis Pipelines

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-224-plan.md`
- `docs/research/program/github-research-wave-224-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

VR utilities often need to know what happened in a session, not only render a
panel or move a tracker. Research projects make this need explicit: they define
participants, sessions, tasks, trials, event markers, continuous streams,
metadata, validation, replay, and analysis. This wave extracts data-lifecycle
patterns that can be reused in future diagnostics, accessibility, calibration,
training, and study-oriented tools.

## Project Findings

### `ResXR/resxr-unity-research-template`

- Interesting idea: make a Unity/Quest research project a clear-box template
  with a persistent base scene, player rig, scene manager, room calibration,
  flow-management objects, tracking collectors, events, and custom data tables.
- Code donor value: very high as a data-capture architecture reference.
  `ResXRDataManager.cs` maps plain C# data classes to CSV headers, writes
  session-timestamped files, records built-in events and trial data, flushes
  rows immediately, manages continuous collectors, stores session metadata, and
  exposes callbacks for live continuous and face-expression samples.
- Product reference value: high for research, diagnostics, training logs, and
  any utility that needs explainable data export.
- Architecture pattern: persistent base scene plus session/task/trial flow plus
  data manager plus tracking collectors plus calibration utilities.
- Reusable method: define event, continuous stream, and custom table capture
  separately, then make metadata and clock sources explicit.
- Constraints and caveats: Meta Quest/OVR heavy, large Unity project, active
  research scope, and not a general runtime utility baseline.
- What to inspect next: room calibration details, detector components, body and
  eye tracking collectors, and demo experiments.
- Why it matters for `VR-apps-lab`: it is a strong donor for future
  diagnostics or experiment tools that need structured logs without hiding data
  shape inside gameplay scripts.

#### Reusable Pattern Extraction

- Pattern candidate: XR research data lifecycle with capture, event markers,
  stream metadata, and downstream validation.
- Problem solved: XR data becomes hard to reuse when session flow, event
  markers, continuous samples, clocks, quality checks, and exports are hidden
  in one scene or one CSV file.
- Reusable core: session/task/trial model, explicit event table, continuous
  tracking streams, custom data tables, session metadata, quality flags,
  offline stream splitting, raw/derivative outputs, and reports.
- Source evidence: ResXR Unity `ResXRDataManager.cs`; ResXR Python
  `pipeline.py`, `splitter.py`, `validation/registry.py`, and
  `pipeline_config.yaml`; VRSTK stage/replay/biosignal/questionnaire scripts;
  ExPresS-XR data gathering and setup-dialog scripts.
- Abstraction boundary: in-app capture, schema/metadata, validation,
  preprocessing, output layout, and analysis/reporting should be separate.
- What not to copy: Quest-only assumptions, BIDS as a universal requirement,
  legacy Unity assets, or editor-specific setup flows as runtime code.
- Method catalog action: create Method 669.

### `ResXR/resxr-python-pipeline`

- Interesting idea: treat Unity/Quest tracking output as raw data that should
  be split, validated, transformed into BIDS-style files, quality masked, and
  reported.
- Code donor value: very high for post-hoc processing. `pipeline.py` drives
  config loading, session discovery, loading, stream splitting, validation,
  raw BIDS writing, preprocessing, derivative writing, and report generation.
  `splitter.py` turns monolithic continuous data into per-tracking-system
  streams and normalizes alternate time columns. `validation/registry.py`
  provides a check registry with required-stream declarations and failure
  capture. `pipeline_config.yaml` documents sampling rates, input patterns,
  device metadata, enabled systems, validations, quality masking, and report
  knobs.
- Product reference value: high for any future `XR data doctor`, study export,
  tracker-quality report, or accessibility-session audit.
- Architecture pattern: CLI/programmatic pipeline plus declarative config plus
  validators plus raw/derivative output stages.
- Reusable method: keep validation rules declarative and run them before
  transforming or masking data.
- Constraints and caveats: BIDS-oriented, research-specific schema, and tied to
  ResXR-style capture conventions.
- What to inspect next: report templates, preprocessing masks, and how missing
  streams are communicated to users.
- Why it matters for `VR-apps-lab`: it shows how a utility can be valuable even
  after the headset session ends.

### `ixperience-lab/VRSTK`

- Interesting idea: a scientific VR toolkit can combine study flow, tracking,
  biosignals, questionnaires, replay, JSON export, and analysis templates in
  one reusable research stack.
- Code donor value: medium to high as a broad pattern inventory. `TestController`
  and `TestStage` show phase/condition control. `ScenePlayback` and
  `TrackedObjects` show replay-oriented data use. `TrackingBitalinoWithOSC` and
  serial Bitalino scripts show biosignal ingress. Questionnaire and analysis
  exporters write CSV. R/Python tools indicate downstream analysis intent.
- Product reference value: high for study orchestration and replay concepts,
  lower as modern implementation baseline.
- Architecture pattern: experiment controller plus telemetry/event layer plus
  sensor adapters plus replay plus analysis sidecars.
- Reusable method: treat biosignals, questionnaires, object tracking, and
  replay as first-class streams rather than ad hoc extra files.
- Constraints and caveats: legacy Unity/OpenXR/XRI era, broad and messy
  project, checked-in outputs and binaries, and not a codebase to copy
  wholesale.
- What to inspect next: replay JSON schema, validity score calculation, and
  multiplayer/asymmetric embodiment code.
- Why it matters for `VR-apps-lab`: it broadens the research-data pattern
  beyond Quest tracking into biosignals, questionnaires, replay, and analysis.

### `eisclimber/ExPresS-XR`

- Interesting idea: experiment/exhibition tooling can be author-guided through
  editor setup dialogs and data-gathering bindings rather than manual scene
  wiring.
- Code donor value: high as a deepening reference. `DataGatherer.cs` supports
  local CSV and HTTP export, periodic export, update-driven export, input
  action export, per-playthrough file timestamps, and local file validation.
  `DataGatheringBinding.cs` binds component members to export columns. Editor
  setup dialogs and menu-creation helpers scaffold data gathering,
  experimentation tutorials, rooms, IK, presentations, buttons, and sockets.
- Product reference value: high for creator-facing setup and low-code data
  collection workflows.
- Architecture pattern: editor wizard plus component/member binding plus export
  runner plus local/remote sinks.
- Reusable method: let authors bind arbitrary component data to named columns,
  but keep export sinks and timing policy explicit.
- Constraints and caveats: already tracked before this wave, Unity-specific,
  broad asset footprint, and reflection-style binding needs safety guards.
- What to inspect next: HTTP receiver expectations, binding validation UX, and
  setup-dialog extensibility.
- Why it matters for `VR-apps-lab`: it complements ResXR by showing an
  authoring-wizard approach to research data capture.

## Cross-Project Synthesis

The strongest reusable idea is a two-stage lifecycle:

1. capture stage: session metadata, event markers, custom data rows, continuous
   streams, and calibration state are emitted from the XR app;
2. processing stage: streams are split, validated, quality-masked, transformed,
   exported, and reported outside the XR app.

For `VR-apps-lab`, this suggests future utility designs where diagnostics,
calibration, accessibility, training, and research tools share a clear data
contract instead of inventing one-off logs.
