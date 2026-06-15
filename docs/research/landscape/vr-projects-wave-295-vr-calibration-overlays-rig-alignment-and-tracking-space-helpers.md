# Wave 295 - VR Calibration Overlays, Rig Alignment, and Tracking-Space Helpers

This wave studies calibration and alignment projects as reusable references for
avatar/body calibration, display/surface calibration, Pupil Labs calibration
scripts, interactive-space calibration managers, device readiness checks,
tracker pose smoothing, and lightweight VRChat/SlimeVR calibration helpers.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- body/avatar/VRIK calibration from HMD and tracker poses;
- fish-tank/display surface corner calibration;
- Pupil Labs calibration/validation scripts;
- Unity calibration managers for interactive rooms and device checks;
- micro-utilities around VRChat calibration detection and SlimeVR body values.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `mika-sandbox/Unity-VRIK-Calibration` | SteamVR/VRIK avatar calibration baseline | Studied | Avatar scale, HMD assignment, tracker activation, FinalIK targets, and VRIK root controller handoff |
| `ahstevens/FishTankCalibrator` | Display/surface calibration utility | Studied | Surface corner collection, DLL projection calculation, XML output, and editor visualization |
| `PeterWolf93/PupilLabs_VR_Calibration` | Pupil Labs calibration/validation scripts | Studied | Polynomial calibration functions, validation grid, pupil data loading, plotting, masking, and deg conversion |
| `TKorpXR/MooveoPlugin` | Interactive-space calibration SDK | Studied | Device checkers, calibration state, point/normal config, controller/tracker testers, cursor UI, and OpenVR tracker smoothing |
| `CamsAvis/VRC-Calibration-Detection` | VRChat calibration flag micro-utility | Studied as source-light product reference | Avatar prefab sets a bool when calibration completes |
| `Erimelowo/SlimeVR-Calibration` | SlimeVR body-proportion helper | Studied as micro-utility | Browser skeleton visualizer driven by user-entered body segment lengths |

## Code-Level Findings

### `mika-sandbox/Unity-VRIK-Calibration`

- Interesting idea:
  avatar calibration can be represented as a compact sequence: fix IK
  transforms, compute avatar scale from player height/view position, assign HMD
  and active trackers, then add root control only when pelvis/leg targets exist.
- Code donor value:
  high for a minimal baseline. `AvatarCalibrator.cs` shows the calibration
  sequence and scale formula; `SteamVRTracker.cs` wraps tracker pose/input
  source and target object selection.
- Product reference value:
  high for body calibration helpers and tracker setup tools.
- What to inspect next:
  `SteamVRTrackerBase`, target assignment details, tracker validity, UI flow,
  saved calibration profiles, and FinalIK dependency boundaries.

### `ahstevens/FishTankCalibrator`

- Interesting idea:
  immersive display surfaces can be calibrated by collecting four corners,
  calling a projection-calibration library, and writing surface data.
- Code donor value:
  medium/high. `CalibrationManager.cs` defines surface corners, calls
  `ScreenCalibrator.dll`, manages probe points, calibration XML, and multiple
  surfaces. `FishTankSurface.cs` stores corner vectors and draws editor lines.
- Product reference value:
  high for CAVE/fish-tank, virtual display, and physical-display alignment
  tools.
- What to inspect next:
  DLL source/license, XML schema, load/save behavior, corner interaction UX,
  and coordinate convention.

### `PeterWolf93/PupilLabs_VR_Calibration`

- Interesting idea:
  gaze calibration can be handled as an offline data pipeline with pupil data,
  validation data, polynomial design matrices, masks, plots, and coefficient
  export.
- Code donor value:
  medium/high. `calib_main.py` coordinates pupil loading, validation building,
  plotting, degree conversion, masking, and coefficient output;
  `calib_function.py` builds polynomial terms and fits linear regression
  coefficients.
- Product reference value:
  high for research calibration and validation pipelines.
- What to inspect next:
  input data schema, calibration forms, validation masking, plotting outputs,
  time fixers, and whether scripts assume a specific headset/camera layout.

### `TKorpXR/MooveoPlugin`

- Interesting idea:
  calibration for interactive spaces should include device readiness checks,
  tester spawning, cursor UI, point/normal persistence, and tracker smoothing.
- Code donor value:
  very high. `CalibrationManager.cs` manages device checker configs, tester
  prefabs, state, points/normals, events, UI updates, and calibration
  controllers. `DeviceCheckerManager.cs` centralizes checkers. `MooveoConfig.cs`
  persists points and normals. `SteamVR_Tracker.cs` converts OpenVR poses and
  smooths position/rotation.
- Product reference value:
  very high for room/setup diagnostics and operator-facing calibration tools.
- What to inspect next:
  complete calibration algorithm, `CalibrationManagerBase`, controller input,
  UI toolkit, global settings JSON, checker implementations, and package
  cleanup from duplicated project/package folders.

### `CamsAvis/VRC-Calibration-Detection`

- Interesting idea:
  calibration completion can be exposed to an avatar as a simple boolean signal.
- Code donor value:
  low in this pass because inspected content is README-level setup guidance.
- Product reference value:
  medium for micro-utility UX: one boolean can unlock avatar states or user
  feedback after calibration.
- What to inspect next:
  prefab contents, animator parameters, Modular Avatar/AV3 integration, and
  whether generated assets can be inspected from a release.

### `Erimelowo/SlimeVR-Calibration`

- Interesting idea:
  body calibration can be made approachable with a browser skeleton preview
  driven by body-segment length inputs.
- Code donor value:
  medium as a micro-utility. `slimevrSkeleton.js` reads number inputs, stores
  body lengths, updates a canvas skeleton, and redraws head/spine/hips/legs.
- Product reference value:
  high for onboarding UX and body-measurement preview tools.
- What to inspect next:
  SlimeVR value mapping, units, validation, export/import format, dark mode,
  mobile layout, and how values transfer into tracker configuration.

## Reusable Pattern Extraction

- Pattern candidate:
  calibration/alignment boundary across measured sources, calibration task,
  validation, persisted transforms/values, readiness checks, and user feedback.
- Problem solved:
  calibration logic is often hidden in scenes or vendor tools, making setup
  fragile and hard to debug across devices, trackers, avatars, and displays.
- Reusable core:
  source device checker, HMD/tracker pose capture, avatar scale formula,
  target assignment, surface corner capture, polynomial calibration, validation
  plots, points/normals config, tracker smoothing, body measurement preview,
  completion signal, and calibration profile persistence.
- Source evidence:
  `Unity-VRIK-Calibration`, `FishTankCalibrator`,
  `PupilLabs_VR_Calibration`, `MooveoPlugin`,
  `VRC-Calibration-Detection`, and `SlimeVR-Calibration`.
- Abstraction boundary:
  keep device readiness, data capture, solving, validation, persistence, and
  feedback/UI separate.
- What not to copy:
  hidden scene-only calibration state, missing validity checks, unversioned
  XML/JSON/profile files, DLL-dependent math without source/license review,
  tracker smoothing without diagnostics, or avatar booleans without clear
  setup docs.
- Method catalog action:
  add a calibration/alignment helper method.

## Follow-Up Gaps

- Build a calibration matrix across HMD/tracker/avatar, surface/display,
  gaze/eye, room/interactive-space, and body-proportion workflows.
- Deepen `MooveoPlugin`, `Unity-VRIK-Calibration`, and `FishTankCalibrator` as
  strongest setup-tool donors.
- Compare with older OpenVR/SlimeVR calibration waves so tracker-space,
  body-scale, and display-surface calibration stay coherently named.
- Consider a future reuse plan for a calibration doctor: device readiness,
  guided capture, validation report, profile save/load, and rollback.
