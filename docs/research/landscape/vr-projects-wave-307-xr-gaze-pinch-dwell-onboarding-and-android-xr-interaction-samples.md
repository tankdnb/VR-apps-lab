# Wave 307 - XR Gaze, Pinch, Dwell, Onboarding, and Android XR Interaction Samples

This wave studies gaze, dwell, pinch, and onboarding interaction projects as
reusable references for gaze rays, reticles, dwell progress, multimodal
confirmation, spatial menus, guide cards, gaze accuracy tests, gesture
samples, and Android XR interaction sample composition.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- gaze/dwell interaction kits and lightweight gaze interactables;
- gaze plus controller/pinch confirmation patterns;
- spatial context menus, guide cards, gaze guidance, and onboarding;
- eye-gaze provider adapters and coordinate conversion;
- Android XR sample-matrix references for gaze/pinch, gesture run, permission
  dashboards, and user simulation settings.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `DFKI-Interactive-Machine-Learning/de.dfki-iml.xr-gaze-interaction-toolkit` | Full gaze interaction, monitoring, menus, and onboarding toolkit | Studied | XRI gaze manager, gaze assist, highlight/info panels, radial/pie/list/grid menus, guide/quiz/questionnaire cards, attention monitoring, CSV export, and accuracy grid |
| `tomazsaraiva/unity-gaze-interaction` | Minimal gaze raycast/dwell interaction package | Studied | Small source boundary for interactor, interactable events, reticle placement, progress fill, activation, and exit delay |
| `microsoft/MixedReality-EyeTracking-Sample` | HoloLens extended eye-gaze provider adapter | Studied | Permission, tracker watcher, frame-rate selection, per-eye/combined gaze, tracker-space to world/camera-space conversion |
| `holokit/holokit-unity-sdk` | Optical see-through gaze/dwell/pinch reference | Studied | GazeRaycastInteractor, IGazeRaycastInteractable, dwell loading sample, pinch gesture callback, hand/gesture managers, stereo AR shell |
| `android/xr-unity-samples` | Android XR interaction sample matrix | Studied as bounded subset | GazeAndPinch plane state, catapult hover/pinch activation, GestureRun action mapping, permissions/status dashboard, user simulation assets |

## Code-Level Findings

### `DFKI-Interactive-Machine-Learning/de.dfki-iml.xr-gaze-interaction-toolkit`

- Interesting idea:
  gaze interaction is strongest when it is not only a ray and reticle, but a
  full toolkit covering menu layouts, onboarding cards, attention monitoring,
  accuracy validation, and persistence.
- Code donor value:
  very high. `GlobalGazeManager.cs` wraps XRI gaze interactor access, gaze
  indicator toggling, gaze assistance, original interactor restoration, virtual
  AOIs, and resource folder creation. `GazeInteractable.cs` adds highlighting,
  information displays, local/global gaze parameters, and confirmation flags
  for dwell and controller input. `RadialMenu.cs` and `PieMenu.cs` arrange
  spatial menu entries with DOTween reveal animations. `GuideCardManager.cs`
  supports multimedia guide cards, task progression, highlight reminders, audio
  reminders, and progress controls. `XRInteractionManager.cs` tracks gaze/left
  controller/right controller raycast and hover/select events. `CsvExporter.cs`
  flattens nested telemetry into configurable CSV. `GazeAccuracyGrid.cs`
  generates gaze nodes, controls order, aggregates accuracy/precision, and
  reports acceptability thresholds.
- Product reference value:
  very high for VR onboarding, gaze-first menus, accessibility control
  surfaces, training instructions, research telemetry, and gaze calibration UX.
- What to inspect next:
  `SimpleGazeInteractable`, `ContextMenu<T>`, gaze guidance arrows,
  questionnaire card data, visual attention chart updaters, JSON persistence,
  and package licensing constraints.
- Reusable pattern extraction:
  treat gaze as a platform layer with interaction, menu, guidance, onboarding,
  monitoring, and validation modules.

### `tomazsaraiva/unity-gaze-interaction`

- Interesting idea:
  a minimal gaze toolkit can be explained as three scripts: interactor,
  interactable, and reticle.
- Code donor value:
  high as a compact baseline. `GazeInteractor.cs` raycasts from transform
  forward, enforces min/max distance, instantiates a reticle, calls
  enter/stay/exit, fills dwell progress, and activates once dwell reaches one.
  `GazeInteractable.cs` exposes enter/stay/exit/activated events plus Unity
  events and an exit delay. `GazeReticle.cs` scales with distance, aligns to the
  hit normal, supports invisible/visible modes, and renders progress fill.
  `ResourcesManager.cs` keeps prefab lookup simple.
- Product reference value:
  high for no-controller menus, quick headset onboarding, and a small donor
  boundary that can be ported to other engines.
- What to inspect next:
  sample scenes, layer setup, reticle prefab, activation reset behavior,
  accessibility dwell duration, and whether activation should be cancelable.
- Reusable pattern extraction:
  define gaze interaction as `ray source -> target hit -> interactable events
  -> reticle/progress -> activation`.

### `microsoft/MixedReality-EyeTracking-Sample`

- Interesting idea:
  vendor eye-gaze data should be wrapped into a provider that returns valid/invalid
  per-eye or combined gaze in world and camera spaces.
- Code donor value:
  high for HoloLens/Mixed Reality. `ExtendedEyeGazeDataProvider.cs` requests eye
  permission, starts an `EyeGazeTrackerWatcher`, opens the tracker, selects the
  highest supported target frame rate, uses a `SpatialGraphNode` for tracker
  pose, reads left/right/combined gaze in tracker space, converts to Unity
  world space, and exposes camera-space readings. `EETDataProviderTest.cs`
  places visual objects 1.5 meters along left/right/combined gaze rays.
- Product reference value:
  high for eye-tracking adapters, gaze validation overlays, and diagnostics.
- What to inspect next:
  package license/proprietary DLL constraints, permission UX, missing-data
  cadence, calibration state, remoting limitations, and fallback behavior when
  tracker is removed.
- Reusable pattern extraction:
  never expose raw vendor eye data directly; normalize it through validity,
  coordinate-space conversion, timestamping, and fallback semantics.

### `holokit/holokit-unity-sdk`

- Interesting idea:
  optical see-through mobile XR can combine gaze raycast dwell with hand-pinch
  gesture recognition, stereo rendering, and calibration/setup samples.
- Code donor value:
  high. `GazeRaycastInteractor.cs` raycasts from `HoloKitCameraManager.CenterEyePose`,
  tracks current `IGazeRaycastInteractable`, and calls entered/selected/exited
  events. `IGazeRaycastInteractable.cs` gives a very small target interface.
  `GazeGestureInteractor.cs` listens to `HandGestureRecognitionManager.OnHandGestureChanged`
  and invokes `IGazeGestureInteractable.OnGestureSelected()` when the active
  gaze target receives a pinch. `GazeAndDwellButtonController.cs` and
  `CircleInteractableController.cs` show dwell-loading UI and page-dot/percent
  feedback.
- Product reference value:
  high for gaze+pinch confirmation, mobile optical-see-through utilities, and
  low-complexity dwell buttons.
- What to inspect next:
  `HandGestureRecognitionManager`, camera manager render-mode switching,
  phone calibration samples, world-origin reset, Android phone support, and the
  dwell decrement bug pattern in sample scripts.
- Reusable pattern extraction:
  keep gaze target selection and gesture confirmation as two separate layers.

### `android/xr-unity-samples`

- Interesting idea:
  Android XR samples are useful as a platform sample matrix: each sample is a
  bounded interaction story with shared origin, permission, menu, and user
  simulation infrastructure.
- Code donor value:
  high as bounded subset. `GazeAndPinch.cs` enables plane detection and gaze
  interaction, tracks scene phase, handles plane state, shows searching/plane
  identified panels, validates plane suitability, scales scene contents, and
  scales catapult launch forces. `CatapultController.cs` activates on hover,
  uses pinch `InputActionProperty` to launch, keeps one active catapult, and
  restores/deactivates materials. `GestureDetector.cs` maps handedness plus
  gesture enum to left/right pinch/grasp actions. `Home.cs` enables passthrough,
  hides status dashboard when the menu is active, and spawns a menu tutorial
  unless the user already pressed the menu button. `StatusDashboard.cs` requests
  Android XR permissions, enables managers based on granted permissions, checks
  head/hand/gesture/eye/face/plane/depth/mesh states, and reads XRI/OpenXR
  input actions. User simulation assets define fallback environments and
  simulator actions.
- Product reference value:
  very high for Android XR onboarding, capability dashboards, permissions,
  gaze+pinch samples, and a future sample-browser structure.
- What to inspect next:
  `Common/Scripts/MenusAndUI`, `DominantHandManager`, input mode variables,
  XRSamples hand device, feature tag catalog, and each sample's state machine.
- Reusable pattern extraction:
  wrap platform samples with shared capability/status, permissions, menu,
  simulation, and scene-state infrastructure.

## Reusable Pattern Extraction

- Pattern candidate:
  gaze, pinch, and dwell interaction boundary across ray source, target
  interface, reticle/progress, confirmation trigger, spatial menu, onboarding,
  monitoring, accuracy validation, and platform capability state.
- Problem solved:
  gaze interaction projects often conflate target detection, visual feedback,
  activation, menu layout, tutorial flow, telemetry, calibration, and platform
  permissions. Reuse needs each layer to be replaceable.
- Reusable core:
  gaze/eye/camera ray provider, interactable interface, enter/stay/exit events,
  dwell timer, reticle/progress visual, activation/reset state, controller or
  pinch confirmation adapter, radial/pie/list/grid menu layout, guide card,
  attention/AOI monitor, accuracy grid, CSV export, permission/status dashboard,
  and user simulation settings.
- Source evidence:
  `de.dfki-iml.xr-gaze-interaction-toolkit`,
  `tomazsaraiva/unity-gaze-interaction`,
  `microsoft/MixedReality-EyeTracking-Sample`, `holokit/holokit-unity-sdk`,
  and `android/xr-unity-samples`.
- Abstraction boundary:
  keep gaze provider, interactable contract, feedback visuals, confirmation
  input, menu/onboarding UI, monitoring/export, and platform capability state
  separate.
- What not to copy:
  sample-only dwell decrement bugs, vendor eye-tracking DLL assumptions,
  hidden permission prompts, gaze activation without cancel/reset UX, or
  telemetry export without privacy boundaries.
- Method catalog action:
  add a gaze/pinch/dwell interaction and onboarding method.

## Follow-Up Gaps

- Deepen GTK `SimpleGazeInteractable`, context-menu base classes, questionnaire
  cards, and visual attention monitoring exporters.
- Deepen Android XR `Common/MenusAndUI`, feature tags, input mode variables,
  and user simulation settings.
- Compare gaze menu layouts with earlier VR menu/control waves.
- Build a gaze interaction matrix across reticle, dwell, pinch/controller
  confirmation, accuracy test, onboarding cards, AOI monitoring, and platform
  permission state.
