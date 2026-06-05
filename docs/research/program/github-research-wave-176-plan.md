# GitHub Research Wave 176 Plan

- Date: `2026-06-05`
- Theme: `DIY eye/mouth tracking, VRCFT modules, gaze calibration, and OpenXR eye consumers`
- Scope: camera-to-expression tracking apps, VRCFaceTracking modules,
  user-specific eye models, in-headset calibration routines, and OpenXR or
  Resonite eye-tracking consumers.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier waves covered VRCFT and OpenXR face/eye integration, but the repository
still needed a stronger view of the full creator-operated tracking pipeline:
hardware camera frames, model inference, per-user calibration, OSC/VRCFT output,
and runtime-side eye consumers.

## Search Families

- DIY eye tracking for VR headsets
- mouth and facial expression tracking
- VRChat VRCFaceTracking modules
- in-headset calibration clients
- OpenXR eye-gaze and face-tracking consumers
- Resonite/OpenXR eye-tracking bridges

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `Project-Babble/ProjectBabble` | Source-first mouth tracking app with camera ROI, ONNX inference, calibration, smoothing, and OSC output | DIY mouth tracking and expression bridge |
| `EyeTrackVR/EyeTrackVR` | Affordable eye tracking stack with multiple pupil algorithms, VRChat native/VRCFT outputs, and calibration | DIY eye tracking and OSC/VRCFT bridge |
| `cspark-development/VRCFaceTracking-TobiiXR` | Tobii Stream Engine module for VRCFaceTracking with native DLL extraction and per-eye mapping | Hardware SDK to VRCFT module |
| `ryan9411vr/EyeTracking` | Desktop ML eye-tracking client plus Unity target-acquisition helper and OSC output modes | User-trained eye model and VR calibration helper |
| `Project-Babble/BabbleCalibration` | Godot OpenVR/OpenXR calibration routine runner connected to Babble/Baballonia | In-headset calibration routine runner |
| `headassbtw/ResoniteOpenXREyeTracking` | Resonite mod that consumes OpenXR eye/face extensions through a headless session | OpenXR extension to engine input driver |
| `edvardsoe/foveated-rendering-demo` | Product/reference node around gaze-driven foveated rendering visualization | Gaze-product reference only |

## Dedupe Notes

- Existing VRCFT waves already cover broad module ecosystems and avatar
  preparation. This wave focuses on source-level camera, calibration, output,
  and OpenXR consumer mechanics.
- `Project-Babble` and `EyeTrackVR` are included because they expose reusable
  end-to-end pipeline shape, not just because they are popular projects.
- `edvardsoe/foveated-rendering-demo` is intentionally kept as source-light
  product reference only because the inspected snapshot does not provide a
  meaningful code donor surface.

## Code-Level Pass Targets

- camera capture, ROI, crop/rotate/flip, preview, and stale-frame behavior;
- ONNX/TensorFlow/pupil algorithm selection and model reload boundaries;
- calibration state, blink/openness routines, smoothing, and output filtering;
- VRChat native eye output, VRCFT v1/v2 avatar parameters, OSC schemas, and
  single-eye fallbacks;
- native hardware SDK wrapping and native DLL deployment strategy;
- OpenVR/OpenXR calibration backend boundaries and packet/routine flow;
- OpenXR eye/face extension setup, headless sessions, action spaces, and engine
  input-driver mapping.

## Expected Outputs

- Wave 176 landscape synthesis.
- Registry/family placement for DIY eye/mouth tracking and calibration.
- Methods around source-first tracking pipelines, multi-target expression
  output bridges, and in-headset calibration routine runners.
