# GitHub Research Wave 176 Backlog

- Date: `2026-06-05`
- Theme: `DIY eye/mouth tracking, VRCFT modules, gaze calibration, and OpenXR eye consumers`
- Status: executed as static source-reading pass
- Build/run status: not run, not built, not installed, not launched

## Completed Intake

- Shortlisted source-first eye/mouth tracking and calibration projects.
- Deduplicated against VRCFT, OpenXR adapter, OSC, and avatar-tracking families.
- Synced source into temporary local-only research cache.
- Read camera/inference/calibration/output entry points without executing code.
- Integrated findings into landscape, registry, families, methods, and focus
  backlog.

## Follow-Up Work

- Compare `ProjectBabble`, `EyeTrackVR`, and `ryan9411vr/EyeTracking` as a
  pipeline matrix:
  capture source, model type, calibration model, smoothing, output schema, and
  fallback behavior.
- Create a reusable `tracking-output-schema` note covering VRChat native,
  VRCFT v1/v2, OSC avatar parameters, and engine-specific input drivers.
- Decide whether `BabbleCalibration` should seed a future generic in-headset
  calibration wizard pattern.
- Revisit `ResoniteOpenXREyeTracking` if Resonite/OpenXR eye-tracking support
  becomes an active prototype direction.
- Keep license/hardware caveats visible before treating any code as a donor.

## Reuse Candidates

- Camera ROI and ONNX inference loop from `ProjectBabble`.
- Multi-algorithm per-eye processing and VRCFT/native output routing from
  `EyeTrackVR`.
- User-trained model plus VR target-acquisition helper split from
  `ryan9411vr/EyeTracking`.
- Embedded native SDK module pattern from `VRCFaceTracking-TobiiXR`.
- Backend-abstracted in-headset calibration routines from
  `BabbleCalibration`.
- Headless OpenXR extension consumption into engine input devices from
  `ResoniteOpenXREyeTracking`.

## Caveats To Preserve

- Do not run found projects during research passes.
- Do not copy non-commercial, GPL, or asset-heavy code without license review.
- Treat hardware-specific calibration constants as product lessons, not general
  defaults.
- Treat source-light foveated rendering demos as product references unless a
  code-rich snapshot is found later.
