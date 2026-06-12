# GitHub Research Wave 268 Plan - VR/WebXR/Godot Measurement and Body-Distance Utilities

## Goal

Study small VR measurement and calibration projects, then extract reusable
boundaries for visual calibration, body measurement state, mobile camera
distance capture, and remote measurement helpers.

## Research Questions

- Which measurement repos contain real source versus empty placeholders?
- How do projects represent scale, units, confidence, and user-editable
  values?
- Which parts are reusable in future VR calibration, accessibility, or
  inspection tools?
- What caveats appear around browser camera, orientation, WebRTC, and backend
  submission?

## Shortlist

- `leetarry/VR_Measure`
- `rlaboiss/ipd-vr-measure`
- `AyOhEe/Godot-VR-Measurements`
- `NeosoftMadhuri/webxr-measure`
- `maverickjimmx/webxr-measure`
- `Vedant22-marda/webxr-measurement-app`

## Required Checks

- Deduplicate against spatial workbench, Quest companion, and browser
  surface-ingress waves.
- Clone only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields and reusable pattern bridge fields.
- Update registry, families, methods, not-yet-studied, current focus, and
  indexes.

## Expected Outputs

- Landscape synthesis for Wave 268.
- Registry/family entries for measurement and calibration utilities.
- Method catalog entry for measurement/calibration boundaries.
- Follow-up gaps for calibrated browser measurement and Godot measurement
  state.
