# Wave 472: In-VR questionnaires, study forms, and biosignal experiment templates

- Date: `2026-07-18`
- Scope: in-headset questionnaire panels, study-form schemas, participant result
  storage, biosignal trigger gates, and public study-flow framing for VR
  research utilities.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `jkalliok/VRQuestionnaire` | Studied | Additive Unity questionnaire scene with SSQ prefab flow, CSV output, and receiver callback |
| `leebrien/O-VR-HEAR-Forms` | Studied | Schema-driven Unity questionnaire sequence with SSQ, NASA-TLX, UEQ-S, participant JSON store, and panel controller |
| `CodeLavi/eeg-vr-unity-survey` | Lightly studied | Public EEG/VR study landing page with consent, onboarding, questionnaire, debrief, and privacy framing |
| `NEUROSPEC-AG/VR-EEG-Sample-Experiment` | Studied | Unity neuroscience VR sample with phase scenes and MMBT-S serial trigger-box scripts |

## Project notes

### `jkalliok/VRQuestionnaire`

- Interesting idea: a questionnaire scene can be loaded additively on top of a
  running VR task, collect SSQ answers, save a CSV, broadcast
  `QuestionnaireSaved`, and unload itself.
- Code donor value: medium as a compact additive-scene and callback baseline.
- Product reference value: high for "pause task, ask in headset, resume task"
  research flows.
- Source evidence: `README.md`, `Assets/Scripts/ExampleScene.cs`,
  `QSystem.cs`, `MultiPrefab.cs`, `SliderPrefab.cs`, and `TextPrefab.cs`.
- Reusable core: additive questionnaire scene, external base path/user id,
  receiver callback, prefab initialization, ready-state checks, slider and
  multiple-choice prefabs, per-user CSV and single-file CSV modes.
- What not to copy: `OnGUI`, static mutable globals, unchecked CSV escaping,
  manual researcher save as the only completion gate, and checked-in Unity
  cache/package bulk.
- What to inspect next: whether the field schema should become provider-neutral
  and whether answers need timestamps, consent ids, and trial ids.

### `leebrien/O-VR-HEAR-Forms`

- Interesting idea: a VR questionnaire can be driven from JSON instruments and a
  controller/view/model split rather than hard-coded UI panels.
- Code donor value: high for schema-driven forms, sequenced instruments, and
  append-only participant results.
- Product reference value: high for reusable research modules that need SSQ,
  NASA-TLX, UEQ-S, or similar study instruments inside VR.
- Source evidence: `README.md`, `QuestionnaireDataStructures.cs`,
  `QuestionnaireModel.cs`, `QuestionnaireController.cs`,
  `QuestionnaireManager.cs`, `SliderView.cs`, `ToggleGroupView.cs`,
  `ssq.json`, `nasatlx.json`, and `ueqs.json`.
- Reusable core: `QuestionnaireData` schema, question ids, slider/radio/multiple
  choice types, title/question states, forward/back navigation, response map,
  `OnQuestionnaireCompleted`, timestamped `QuestionnaireResult`, participant
  merge by id, and pretty JSON file output.
- What not to copy: placeholder participant id, Meta SDK lock-in, raw persistent
  storage without retention policy, and sample asset bulk.
- What to inspect next: consent/deletion flow, missing-answer validation, export
  format compatibility, and neutral XRI/OpenXR input adapters.

### `CodeLavi/eeg-vr-unity-survey`

- Interesting idea: even a source-light study page is useful as a public
  research-product reference because it explains consent, setup, VR onboarding,
  in-headset questionnaire, debrief, and anonymization boundaries.
- Code donor value: low; the repo is a static page rather than a reusable VR
  implementation.
- Product reference value: medium for study-flow copy, participant expectation
  setting, accessibility contact, and privacy language.
- Source evidence: `eeg_vr.html`.
- Reusable core: public participant flow, time estimate, headset/hardware note,
  consent and withdrawal framing, anonymized/pseudonymized data statement,
  onboarding sequence, in-headset questionnaire mention, and debrief step.
- What not to copy: placeholder form/contact assumptions, static-page-only
  implementation, and study-specific institutional wording.
- What to inspect next: whether a linked Unity source appears and whether the
  participant-facing copy can become a reusable study-page checklist.

### `NEUROSPEC-AG/VR-EEG-Sample-Experiment`

- Interesting idea: a VR research sample can pair phase scenes with a serial
  trigger-box adapter so headset events are synchronized with EEG or other
  biosignal recording systems.
- Code donor value: high for the hardware-trigger boundary and operator status
  UI.
- Product reference value: high for neuroscience and biosignal-aware VR study
  templates.
- Source evidence: `README.md`,
  `Assets/NeurospecTriggerBox-Unity-master/Scripts/SerialPort_MMBTS.cs`,
  `SerialPort_MMBTS_Test.cs`, `Assets/Scripts/JewelryTrail.cs`, and
  `ChangeScene.cs`.
- Reusable core: welcome/trial/end scene phases, COM-port selection, serial
  connect/disconnect status, TTL trigger byte send/read, trigger duration and
  interval controls, reset-to-zero trigger behavior, and no-port UI labels.
- What not to copy: hardware-specific MMBT-S and COM3 assumptions, Windows/Quest
  Link setup as a default, scene-specific jewelry task logic, and UI tied to one
  trigger box.
- What to inspect next: a provider-neutral `BiosignalTriggerProvider`
  abstraction and trial event schema that can map to serial, LSL, OSC, or file
  markers.

## Reusable pattern extraction

- Pattern candidate: `In-VR questionnaire sequence and biosignal-aware study
  form`.
- Problem solved: VR utilities need to collect structured participant answers
  and synchronize research events without leaving the headset or losing trial
  context.
- Reusable core: participant/session id, instrument schema, additive scene or
  panel surface, title/question states, slider/radio/multiple-choice widgets,
  required-answer validation, timestamped answer records, CSV/JSON export,
  completion callback, consent/privacy labels, optional biosignal trigger
  provider, and operator no-device state.
- Source evidence: `VRQuestionnaire/Assets/Scripts/Questionnaire_stuff/*`,
  `O-VR-HEAR-Forms/Assets/Scripts/Questionnaire/*`,
  `eeg-vr-unity-survey/eeg_vr.html`, and
  `VR-EEG-Sample-Experiment/Assets/NeurospecTriggerBox-Unity-master/Scripts/*`.
- Abstraction boundary: keep questionnaire schema, VR widget rendering,
  participant data store, task callbacks, and biosignal trigger provider
  independent.
- What not to copy: static global form state, unchecked CSV, hard-coded
  participant ids, embedded hardware ports, and private study wording without
  review.
- Method catalog action: add `Method 917`.

## Why this matters for VR-apps-lab

This wave turns research participation itself into a reusable VR utility
pattern. Future tools can embed questionnaires, consent/status labels, and
biosignal markers as modules instead of rebuilding study plumbing for each
prototype.
