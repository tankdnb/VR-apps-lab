# GitHub Research Wave 295 Plan - VR Calibration Overlays, Rig Alignment, and Tracking-Space Helpers

## Goal

Study VR calibration and alignment projects as reusable references for avatar
calibration, surface/display calibration, eye-tracking calibration scripts,
interactive-space setup managers, device readiness checks, and body/tracker
micro-utilities.

## Research Questions

- How do projects separate device readiness, data capture, solving,
  validation, persistence, and feedback?
- Which calibration values belong in profiles or reports?
- How do body/avatar, display/surface, gaze, and tracker calibration flows
  overlap?
- Which micro-utilities are product references rather than code donors?

## Shortlist

- `mika-sandbox/Unity-VRIK-Calibration`
- `ahstevens/FishTankCalibrator`
- `PeterWolf93/PupilLabs_VR_Calibration`
- `TKorpXR/MooveoPlugin`
- `CamsAvis/VRC-Calibration-Detection`
- `Erimelowo/SlimeVR-Calibration`

## Required Checks

- Deduplicate against older OpenVR/SlimeVR calibration, tracker, and
  measurement waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep DLL/source, vendor SDK, profile schema, micro-utility, and
  source-light caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 295.
- Registry/family entries for calibration/alignment utilities.
- Method catalog entry for calibration/alignment helper boundaries.
- Follow-up gaps around calibration doctor, profiles, validation reports, and
  rollback.
