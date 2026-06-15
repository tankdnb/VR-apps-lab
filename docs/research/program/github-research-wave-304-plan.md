# GitHub Research Wave 304 Plan - In-VR Questionnaires, Study Surveys, Affect Ratings, and Remote Lab Overlays

## Goal

Study in-VR questionnaire, survey, affect-rating, and remote-lab projects as
reusable references for schema-driven study UI, participant metadata, required
answer validation, feedback, export, replay alignment, and remote
questionnaire sync.

## Research Questions

- How do projects separate questionnaire schema from generated VR UI pages?
- Which validation, feedback, and answer-export patterns are reusable?
- How are participant/session fields, frame/location metadata, and replay logs
  attached to answers?
- Which upload, remote-lab, and affect-analysis paths are useful but require
  privacy or security caveats?

## Shortlist

- `MartinFk/VRQuestionnaireToolkit`
- `JakobJoSchmidt/immersive-questionnaire-unity-vr`
- `microsoft/Remote-Lab`
- `Pepn/SurveyToolkit`
- `afourcade/AffectTracker_validation`

## Required Checks

- Deduplicate against earlier study recording, training assessment, and
  analytics waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep participant privacy, upload secrets, old input dependencies, and
  analysis-only repository caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 304.
- Registry/family entries for in-VR questionnaires and remote study overlays.
- Method catalog entry for questionnaire and research-study overlay
  boundaries.
- Follow-up gaps around Remote-Lab replay/protobuf, AffectTracker runtime, and
  privacy guidance.
