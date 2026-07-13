# VR Projects Wave 436: Unity Coordinate Calibration and Cardboard Profile Micro-Libraries

Date: 2026-07-13

Theme: small Unity calibration libraries where the reusable value is not a full
application, but a bounded calibration loop, persistence model, and runtime
screen/profile correction surface.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `MaxHeimbrock/KabschCalibrationUnity` | Coordinate-space calibration micro-library | Code-level pass |
| `epyyny/google_cardboard_calibration_unity_plugin` | Cardboard viewer/screen calibration plugin fork | Code-level pass |

## Project Notes

### `MaxHeimbrock/KabschCalibrationUnity`

- Interesting idea: Unity package for aligning real-world objects with VR/AR
  tracking systems through Kabsch 3D-to-3D correspondences.
- Code donor value: strong micro-library donor for source/target point capture,
  Kabsch matrix solving, mean-distance error reporting, tooltip calibration,
  editor source-point authoring, and JSON transform persistence.
- Product reference value: useful reference for calibration utilities where the
  user needs visible point order, target placement, error feedback, and a saved
  transform.
- Architecture pattern: scene-level `CalibrationManager`, per-object
  `CalibrateObject`, static `KabschSolver`, tooltip solver, editor point tools,
  and transform persistence helper.
- Reusable method: `coordinate-system calibration micro-library`.
- UX/product lesson: calibration should show point progress and error in user
  units, then offer save/load so a stable tracking setup can be reused.
- Caveats: SteamVR-era input example, imported solver/tooling lineage, and
  assumptions around parent transforms during tooltip calibration.
- Source evidence: README documents source/target point workflow, mean distance
  error, tooltip calibration, and JSON save/load; `CalibrateObject.cs` applies
  `KabschSolver.SolveKabsch`; `TransformPersistence.cs` saves and loads
  transform records.
- Reusable core: correspondence capture, solver boundary, error metric,
  tooltip calibration, color-coded point order, and persistence.
- What not to copy: old input bindings, unqualified object-name matching, or
  calibration assumptions without tracking-space labels.
- Method catalog action: create a new coordinate/viewer calibration method.
- What to inspect next: compare with tracker calibration, room alignment,
  camera-to-headset calibration, and QR/profile-based viewer calibration repos.

### `epyyny/google_cardboard_calibration_unity_plugin`

- Interesting idea: modified Cardboard XR plugin that adds a ruler/DPI
  calibration path so phone screen parameters can be corrected in-app.
- Code donor value: useful for screen/profile calibration flow, DPI fallback,
  safe-area/orientation recalculation, and native XR loader parameter handoff.
- Product reference value: strong reminder that low-end/mobile VR needs
  user-visible calibration when device DPI or viewer profile data is unreliable.
- Architecture pattern: forked Cardboard XR package with new `Runtime/Ruler`
  scripts, edited `XRLoader`, and retained upstream package shape.
- Reusable method: `viewer-profile calibration micro-tool`.
- UX/product lesson: a simple ruler-style calibration can be more practical than
  asking users to understand lens/profile internals.
- Caveats: Android-focused, Vulkan untested, and most code is upstream
  Cardboard rather than new donor code.
- Source evidence: README identifies `Runtime/Ruler`, edited `XRLoader.cs`, and
  Android/OpenGLES caveats; `XRLoader.cs` uses `Screen.dpi` fallback and sends
  screen params to native Cardboard; `Widget.cs` converts safe-area and DPI
  values.
- Reusable core: calibration scene, DPI/safe-area measurement, loader parameter
  bridge, and profile-update trigger.
- What not to copy: full plugin fork without upstream tracking or native binary
  provenance.
- Method catalog action: merge with coordinate calibration into a general
  calibration micro-library method.
- What to inspect next: modern Cardboard/OpenXR viewer-profile tools, QR profile
  editors, and mobile screen-geometry validation utilities.

## Reusable Pattern Extraction

- Pattern candidate: `calibration micro-library with visible error and
  persistence`.
- Problem solved: many VR utilities need to align a physical device, viewer, or
  coordinate system without becoming a large calibration application.
- Reusable core: point/profile capture, solver or measurement boundary, runtime
  parameter handoff, visible error/scale feedback, persistence, and caveats for
  device/runtime assumptions.
- Source evidence: `KabschCalibrationUnity` provides 3D correspondence solving;
  `google_cardboard_calibration_unity_plugin` provides screen/profile
  recalculation hooks.
- Abstraction boundary: solver/measurement logic should be reusable; old input
  bindings, full forks, and native binaries need provenance before reuse.

## Follow-Up Gaps

- Study more calibration repos around tracker-to-world, camera-to-headset,
  controller-tip, and mixed-reality anchor alignment.
- Define a neutral calibration artifact schema with source space, target space,
  samples, error, timestamp, device/runtime, and persistence path.
