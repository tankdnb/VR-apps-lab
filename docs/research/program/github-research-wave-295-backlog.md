# GitHub Research Wave 295 Backlog - VR Calibration Overlays, Rig Alignment, and Tracking-Space Helpers

## Executed Scope

- Searched and deduplicated VR calibration, VRIK, fish-tank/display,
  Pupil Labs, interactive-space calibration, VRChat calibration detection, and
  SlimeVR helper projects.
- Froze a six-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted avatar scale and tracker assignment, display corner calibration,
  Pupil Labs polynomial calibration scripts, Mooveo device checkers and
  points/normals config, VRChat calibration bool UX, and SlimeVR body skeleton
  preview.

## Studied Projects

- `mika-sandbox/Unity-VRIK-Calibration`
- `ahstevens/FishTankCalibrator`
- `PeterWolf93/PupilLabs_VR_Calibration`
- `TKorpXR/MooveoPlugin`
- `CamsAvis/VRC-Calibration-Detection`
- `Erimelowo/SlimeVR-Calibration`

## Backlog Findings

- Build a calibration matrix across HMD/tracker/avatar, surface/display,
  gaze/eye, room/interactive-space, and body-proportion workflows.
- Deepen `MooveoPlugin`, `Unity-VRIK-Calibration`, and `FishTankCalibrator` as
  strongest setup-tool donors.
- Compare with older OpenVR/SlimeVR calibration waves so tracker-space,
  body-scale, and display-surface calibration stay coherently named.
- Consider a future reuse plan for a calibration doctor: device readiness,
  guided capture, validation report, profile save/load, and rollback.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a calibration/alignment helper method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
