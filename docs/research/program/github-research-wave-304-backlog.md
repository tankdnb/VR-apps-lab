# GitHub Research Wave 304 Backlog - In-VR Questionnaires, Study Surveys, Affect Ratings, and Remote Lab Overlays

## Executed Scope

- Searched and deduplicated VR questionnaire, survey toolkit, remote-lab, and
  affect-rating projects.
- Froze a five-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted schema-driven page generation, per-page validation, haptic/audio
  feedback settings, participant/condition metadata, CSV/TXT export, optional
  upload, replay-aligned answer logs, Photon questionnaire sync, and
  analysis-pipeline caveats.

## Studied Projects

- `MartinFk/VRQuestionnaireToolkit`
- `JakobJoSchmidt/immersive-questionnaire-unity-vr`
- `microsoft/Remote-Lab`
- `Pepn/SurveyToolkit`
- `afourcade/AffectTracker_validation`

## Backlog Findings

- Deepen `microsoft/Remote-Lab` replay, OBS, custom-variable, and protobuf
  channels as a broader remote-study donor.
- Inspect `afourcade/AffectTracker` runtime repository to connect continuous
  affect input UX with the validation pipeline.
- Build a survey toolkit comparison matrix across JSON, CSV,
  ScriptableObject, prefab variants, replay-aligned answers, and upload
  models.
- Add privacy guidance for participant IDs, headset logs, questionnaire
  answers, video/OBS captures, and affect-rating traces.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an in-VR questionnaire/research-study method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
