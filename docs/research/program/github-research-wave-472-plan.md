# GitHub Research Wave 472 Plan

- Date: `2026-07-18`
- Theme: in-VR questionnaires, study forms, and biosignal experiment templates.

## Frozen scope

- `jkalliok/VRQuestionnaire`
- `leebrien/O-VR-HEAR-Forms`
- `CodeLavi/eeg-vr-unity-survey`
- `NEUROSPEC-AG/VR-EEG-Sample-Experiment`

## Research questions

- How do in-headset questionnaire tools separate form schema, VR widgets,
  participant id, result storage, and task continuation?
- Which patterns are reusable for SSQ, NASA-TLX, UEQ-S, and custom study forms?
- How can VR study templates expose biosignal trigger or serial marker state
  without locking the method to one hardware device?

## Required extraction

- questionnaire schema and widget model
- participant/session/result storage model
- completion callback or task continuation boundary
- consent/privacy and study-flow caveats
- biosignal trigger/provider boundary
