# Wave 304 - In-VR Questionnaires, Study Surveys, Affect Ratings, and Remote Lab Overlays

This wave studies VR questionnaire and research-study tooling as reusable
references for in-headset surveys, subjective ratings, experiment overlays,
completion gates, CSV exports, remote-lab synchronization, replay logs, and
participant-facing study UX.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- in-VR questionnaire and survey generation;
- Likert, slider, checkbox, radio, grid, and text-entry questionnaire flows;
- research-study capture overlays, replay logs, and remote synchronization;
- continuous affect-rating and post-processing references;
- dedupe against older recording/replay, training-assessment, text-entry, and
  gaze-study waves.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `MartinFk/VRQuestionnaireToolkit` | VR questionnaire package and standard survey toolkit | Studied | JSON-driven questionnaire generation, multi-page VR/Desktop mode, mandatory validation, standard survey batteries, feedback options, local/server export |
| `JakobJoSchmidt/immersive-questionnaire-unity-vr` | Lightweight immersive Likert questionnaire service | Studied | CSV-driven questions, configurable page size, timed editing, scale inversion, bipolar output, and compact standalone questionnaire logic |
| `microsoft/Remote-Lab` | Remote XR study toolkit and questionnaire/replay overlay | Studied | ScriptableObject questionnaire content, single/multiple/slider UI, skip handling, Photon network sync, UI event replay, OBS integration, and custom variable logging |
| `Pepn/SurveyToolkit` | Cross-platform Unity survey UI toolkit | Studied | ScriptableObject survey pages, prefab-backed question types, required-field highlighting, CSV output, and optional upload pipeline |
| `afourcade/AffectTracker_validation` | Continuous affect-rating validation and analysis reference | Studied as source-light analysis node | Published affect-rating validation pipeline, continuous rating import/plots, survey preprocessing, and analysis package structure |

## Code-Level Findings

### `MartinFk/VRQuestionnaireToolkit`

- Interesting idea:
  VR questionnaires can be packaged as a reusable study instrument with
  standard batteries, JSON questionnaire definitions, headset/desktop modes,
  feedback tuning, and local/remote export.
- Code donor value:
  high. `GenerateQuestionnaire.cs` reads multiple JSON questionnaire paths,
  parses questionnaire metadata and per-page question records, then asks
  `PageFactory.cs` to create page prefabs for radio, radio grid, checkbox,
  checkbox grid, dropdown, linear scale, and text input. `PageController.cs`
  validates mandatory questions before page changes and turns the final
  forward action into a submit action. `ExportToCSV.cs` collects answers by
  question type, writes question type/text/id/answer rows, supports local and
  remote save modes, and exposes a `QuestionnaireFinishedEvent`.
  `StudySetup.cs` persists panel transform settings and exposes haptic/audio
  feedback parameters for hover and select.
- Product reference value:
  very high for research-app survey overlays, pre/in/post study questionnaires,
  and participant-facing configuration panels.
- What to inspect next:
  JSON schema examples, remote server posting code after `CheckURIValidity`,
  UXF integration details, package license for bundled dependencies, and
  whether the old SteamVR/Vive Input dependency can be isolated behind an
  input adapter.
- Reusable pattern extraction:
  separate questionnaire schema, page factory, page controller, answer export,
  study participant metadata, and feedback configuration.

### `JakobJoSchmidt/immersive-questionnaire-unity-vr`

- Interesting idea:
  a compact questionnaire service can load a semicolon CSV, create multiple
  Likert questions per page, track per-question editing time, and append one
  participant row to a CSV.
- Code donor value:
  medium. `QuestionnaireService.cs` loads intro/farewell text and question
  labels from CSV, supports numeric labels, fully verbal scales, one-question
  text mode, randomized scale inversion, page navigation, answer storage, and
  CSV output with optional question text and editing time. `Question.cs` keeps
  answer, inversion state, display state, and cumulative editing time as a
  small data object.
- Product reference value:
  high for a small embeddable VR study survey where the full framework cost of
  RemoteLab or VRQuestionnaireToolkit is not needed.
- What to inspect next:
  sample CSV files, prefab hierarchy assumptions, unanswered-question behavior,
  localization, input-module setup, and privacy-safe participant identifiers.
- Reusable pattern extraction:
  keep a "thin survey overlay" option for utility tools that only need
  Likert-scale capture and CSV export.

### `microsoft/Remote-Lab`

- Interesting idea:
  questionnaires become more valuable when they are part of a remote-study
  stack that records transforms, UI events, custom variables, OBS video state,
  and replay data.
- Code donor value:
  very high. `QuestionnaireContent.cs` defines ScriptableObject questions with
  `ChoicesType` values for none, single, multiple, and slider, including
  labels, min/max, whole-number flags, and skip permission. `QuestionnaireManager.cs`
  instantiates UI templates, handles previous/next/skip/submit, validates
  required toggle answers, logs answers with frame count and location, and
  writes UI events to `ReplayManager`. `NetQuestionnaireManager.cs` mirrors
  questionnaire setup through Photon view IDs and RPC-serialized question data.
  The broader runtime includes `ReplayManager`, `Recordable`, `InteractableUI`,
  `ObsManager`, and protobuf record examples.
- Product reference value:
  very high for remote usability studies, overlay diagnostics, replayable
  experiment sessions, and multi-user moderator/participant research flows.
- What to inspect next:
  replay file schema, OBS failure behavior, Photon ownership edges, participant
  folder layout, data consent UX, and how to decouple the questionnaire module
  from the full remote-lab package.
- Reusable pattern extraction:
  pair questionnaire answers with frame/time/location and replay/UI-event
  channels so survey data can be interpreted against session behavior.

### `Pepn/SurveyToolkit`

- Interesting idea:
  survey authoring can be modeled as ScriptableObject data plus prefab-backed
  form components, with pages populated at runtime.
- Code donor value:
  high. `SurveyManager.cs` discovers child `QuestionnairePage`s, advances
  pages, writes GUID/timestamp CSV files to `Application.persistentDataPath`,
  and optionally uploads through `DataUploader.cs`. `QuestionnairePage.cs`
  instantiates `FormObjectData` items, wires submit buttons, highlights
  incomplete required questions, and changes submit copy based on page count.
  `SliderQuestion.cs` and `SliderQuestionData.cs` show the question/prefab/data
  split for a slider input.
- Product reference value:
  high for reusable survey components across VR, desktop, and mobile tools.
- What to inspect next:
  full question component set, upload security hardening, comma escaping,
  accessibility/font scaling, and how the toolkit behaves with XR UI modules.
- Reusable pattern extraction:
  make question types prefab variants driven by data assets; keep validation
  and export in the manager/page layer.

### `afourcade/AffectTracker_validation`

- Interesting idea:
  continuous affect-rating tools need a companion validation and analysis
  pipeline, not only an in-headset rating widget.
- Code donor value:
  low/source-light for runtime code in this pass, but medium for analysis
  structure. README describes preprocessing/import modules for continuous
  ratings, motion, pre/post surveys, BIDS formatting, CR/SR correlation, survey
  plots, radar plots, and modeling notebooks/R scripts.
- Product reference value:
  high for affect-aware VR study tools and continuous valence/arousal rating
  validation.
- What to inspect next:
  `afourcade/AffectTracker` runtime repository, data format, rating-input UX,
  timestamp alignment, BIDS output, and privacy/clinical constraints.
- Reusable pattern extraction:
  whenever a VR utility collects subjective or continuous ratings, also define
  the downstream import, cleaning, plotting, and validation path.

## Reusable Pattern Extraction

- Pattern candidate:
  in-VR questionnaire and research-study overlay boundary across schema,
  page/prefab generation, completion validation, feedback, export, replay,
  network sync, and analysis.
- Problem solved:
  VR study code often mixes UI layout, participant metadata, question schema,
  input handling, data export, remote moderation, replay, and post-processing.
  Reuse needs a clean separation so future VR utilities can add surveys without
  becoming one-off research apps.
- Reusable core:
  questionnaire schema, page factory, question component, required-field gate,
  answer store, participant/session metadata, timestamp/frame/location fields,
  feedback settings, local CSV writer, optional secure upload, replay/UI-event
  bridge, remote synchronization adapter, and analysis import path.
- Source evidence:
  `MartinFk/VRQuestionnaireToolkit`,
  `JakobJoSchmidt/immersive-questionnaire-unity-vr`, `microsoft/Remote-Lab`,
  `Pepn/SurveyToolkit`, and `afourcade/AffectTracker_validation`.
- Abstraction boundary:
  keep survey authoring, UI instantiation, input/selection handling,
  validation, persistence, network sync, replay logging, and offline analysis
  separate.
- What not to copy:
  hardcoded upload secrets, participant names in filenames without consent
  policy, old vendor input packages as core assumptions, CSV output without
  escaping strategy, or questionnaire data that cannot be aligned to session
  timeline.
- Method catalog action:
  add an in-VR questionnaire and research-study overlay method.

## Follow-Up Gaps

- Deepen `microsoft/Remote-Lab` replay, OBS, custom-variable, and protobuf
  channels as a broader remote-study donor.
- Inspect `afourcade/AffectTracker` runtime repository to connect continuous
  affect input UX with the validation pipeline.
- Build a survey toolkit comparison matrix across JSON, CSV, ScriptableObject,
  prefab variants, replay-aligned answers, and upload models.
- Add privacy guidance for participant IDs, headset logs, questionnaire
  answers, video/OBS captures, and affect-rating traces.
