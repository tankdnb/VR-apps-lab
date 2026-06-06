# GitHub Research Wave 252 Backlog

Date: 2026-06-06

Theme: hands-free OpenXR hand tracking input and wrist UI microtools.

## Completed In This Wave

- Studied `SimForgeEngineering/DCS-HandsFree` as a tiny StereoKit/OpenXR
  head-to-cursor mapper with quaternion-to-pitch/yaw conversion, normalized
  viewport mapping, foreground-window bounds, and Windows cursor output.
- Studied `JonahSagers/VRChord` as a Unity XR Hands chording keyboard with
  curl detection, chord dictionaries, fist-distance enable latch, thumb-driven
  space/backspace, text targets, key indicators, and caret feedback.
- Studied `Haidere1/VarjoXR-CustomHandTracking-Test` as an Unreal/Varjo hand
  keypoint and pinch interaction sample with poseable hand mesh, tip spheres,
  widget component, enhanced input contexts, and scene manipulation.
- Studied `zodiepupper/godothandtrackingtests` as a Godot OpenXR raw hand joint
  experiment with procedural trackers, fingertip collision layers, wrist menu,
  passthrough enablement, smoothing, and 3D panel addon.
- Added a reusable method entry for hands-free and hand-derived utility input.

## Follow-Up Queue

1. Build a comparison matrix across head-to-cursor, chording, pinch-ray,
   wrist-menu, and controller input.
2. Extract a calibration/recenter checklist for controllerless helpers.
3. Compare hand-derived input against accessibility and cockpit-control waves.

## Do Not Spend Time On Yet

- Do not run Unity, Unreal, Godot, OpenXR runtimes, StereoKit apps, or headset
  tests.
- Do not copy hardcoded angle thresholds, sample assets, or vendor-specific
  wiring as generic architecture.
- Do not treat controllerless input as safe without an explicit disable path.
