# GitHub Research Wave 293 Backlog - Eye-Tracking Recorders, Accuracy Tests, Heatmaps, and Gaze Analytics

## Executed Scope

- Searched and deduplicated VR eye-tracking, Pupil Labs, FOVE, PICO, SRanipal,
  heatmap, accuracy-test, and analysis projects.
- Froze an eight-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted FOV/accuracy target workflows, gaze path capture, CSV/tagged-file
  schemas, Pupil subscription/recording controllers, FOVE gaze recorder and
  gazable objects, PICO API caveats, and Vive SRanipal logging patterns.

## Studied Projects

- `med-material/VREyeTrackingAccuracyTest`
- `RealBrandonChen/Unity-Eyetracking-Heatmap`
- `simpleOmnia/sXR`
- `FoveHMD/UnityPlugin`
- `FoveHMD/FoveUnitySample`
- `n3urovirtual/PicoXR_EyeTracking_Demo`
- `VR-HCI-Group/Unity-VR-EyeTracking`
- `caseycotes-turpin/EyeTrackingAnalysis`

## Backlog Findings

- Build an eye-tracking utility matrix across vendor SDK, calibration,
  validity/confidence, coordinate spaces, event timing, CSV schema, heatmaps,
  and privacy.
- Deepen `VREyeTrackingAccuracyTest`, `Unity-Eyetracking-Heatmap`, `sXR`, and
  `FoveHMD/UnityPlugin` as strongest donor clusters.
- Compare with face/eye-tracking module waves so avatar-tracking and
  research-recording patterns stay separate.
- Consider a future reuse plan for a neutral gaze recorder with adapters,
  calibration status, schema versioning, and explicit export consent.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an eye-tracking recorder/analytics method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
