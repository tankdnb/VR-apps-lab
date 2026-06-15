# GitHub Research Wave 293 Plan - Eye-Tracking Recorders, Accuracy Tests, Heatmaps, and Gaze Analytics

## Goal

Study VR eye-tracking projects as reusable references for vendor gaze ingress,
calibration, accuracy tests, gaze visualization, recording, CSV/tagged export,
analysis, and privacy-aware research data boundaries.

## Research Questions

- How do projects separate vendor SDK access from sampling, calibration,
  visualization, and export?
- Which data fields are useful for gaze logs and accuracy/validity reports?
- How do heatmap, target-test, and gaze-cursor flows differ?
- Which projects are true donors versus SDK payloads or source-light demos?

## Shortlist

- `med-material/VREyeTrackingAccuracyTest`
- `RealBrandonChen/Unity-Eyetracking-Heatmap`
- `simpleOmnia/sXR`
- `FoveHMD/UnityPlugin`
- `FoveHMD/FoveUnitySample`
- `n3urovirtual/PicoXR_EyeTracking_Demo`
- `VR-HCI-Group/Unity-VR-EyeTracking`
- `caseycotes-turpin/EyeTrackingAnalysis`

## Required Checks

- Deduplicate against VRCFaceTracking, study recording/replay, and prior gaze
  capture waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep hardware/runtime, privacy, source-light, and vendor payload caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 293.
- Registry/family entries for eye tracking and gaze analytics.
- Method catalog entry for eye-tracking recorder/analytics boundaries.
- Follow-up gaps around gaze schema, calibration, validity, and consent.
