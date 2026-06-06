# VR Projects Wave 243: Spatial Measuring, Modeling, Collaboration, and MR Workbench Surfaces

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies spatial workbench surfaces: browser AR measurement and box
projection, hand-driven MR mesh deformation, climate/resilience planning
panels, cooperative networked object manipulation, and social gallery product
references.

## Why It Matters For `VR-apps-lab`

The repository already has many overlay and diagnostics references. This wave
adds a more workbench-oriented cluster: measure the real world, turn dimensions
into editable/projection objects, manipulate meshes with hands, place scenario
solutions, log planning actions, and coordinate multiple users around shared
objects.

## Project Notes

### `rtkCode/Sizer`

- Interesting idea:
  a browser AR app can form a full measure -> model -> project loop instead of
  a one-shot ruler.
- Code donor value:
  `Measurement.vue` uses A-Frame/WebXR hit-test with `dom-overlay`, a reticle,
  controller `select` events, point-pair distance calculation, live line
  preview, length/width/height slots, and local history save before routing to
  a build scene. `Angle.vue` reuses the same reticle and point-pair pattern to
  collect two vectors and compute included angle. `BuildScene.vue` provides a
  toolbar for new/duplicate/undo/clear/project, A-Frame box editing, drag and
  rotation gesture components, and persisted box position/rotation/size data.
  `ProjectScene.vue` projects saved boxes onto an AR.js marker and exposes
  marker-found/lost feedback. `history.js` stores local JSON in `localStorage`.
- Product reference value:
  strong browser-native reference for spatial measurement, local-first
  modeling, and marker-based projection.
- What to inspect next:
  compare with WebXR depth/room-scan measurement waves and extract a cleaner
  data schema for measured objects.
- Architecture pattern:
  WebXR hit-test measurement -> local object model -> A-Frame edit scene ->
  AR.js marker projection.
- Reusable method:
  keep spatial measurement output as simple JSON object state so it can be
  edited, stored, and projected later.
- Caveats:
  older A-Frame/AR.js stack, browser AR device support limits, typoed
  `hasPlain`, and localStorage-only persistence.

### `byte-banditt/Meshelanjelo`

- Interesting idea:
  MR mesh editing can be driven by hand pinch and a reusable deformer rather
  than directly mutating vertices in app logic.
- Code donor value:
  `XRHandMeshManipulator.cs` reads left/right `OVRHand` index pinch, chooses
  pointer-pose center, maps left pinch to pull and right pinch to push, smooths
  intensity, rebounds to neutral, and updates `PushPullDeformer` parameters.
  `PushPullDeformer.cs` extends the Deform package, declares vertex/normal data
  needs, schedules a Burst job, transforms vertices to world space, computes
  radius falloff, displaces along normals, and writes back local displacement.
  The README explains Deform/Deformable component usage, push/pull semantics,
  lighting caveats, and future add/delete/elastic/feedback ideas.
- Product reference value:
  strong donor for hand-driven MR authoring and localized deformation tools.
- What to inspect next:
  inspect scene/prefab binding after a non-sparse pass if this becomes a
  prototype candidate.
- Architecture pattern:
  hand pinch/pointer pose -> smoothed deformer parameters -> job-based local
  mesh displacement.
- Reusable method:
  expose spatial hand input as parameters to a reusable deformer instead of
  coupling input code to mesh buffers.
- Caveats:
  Meta/Oculus hand tracking dependency, Deform package coupling, and no
  explicit undo/history model in the inspected scripts.

### `B22DigitalTwins2022/ar-resilience-planner-v2`

- Interesting idea:
  an MR planning utility can structure work as additive scenes, persistent
  panels, selectable solution categories, simulation update, and user-study
  logs.
- Code donor value:
  `App.cs` loads simulation and city scenes additively. `Menu.cs` persists
  menu-open state with `PlayerPrefs`, toggles a menu offset, and logs open/close
  actions. `PanelSelector.cs` initializes panel buttons, activates one panel at
  a time, persists active panel index, and logs panel openings. `SolutionManager.cs`
  discovers `SolutionModel` objects, groups them by solution type, toggles
  highlighted/active state, and calls `ClimateSimulation.Instance.UpdateSimulation`.
  `DataLogger.cs` creates timestamped user-study folders and CSV logs for
  continuous position, actions, and simulation metrics.
- Product reference value:
  strong reference for planning panels, scenario solutions, and logged MR
  decision support.
- What to inspect next:
  inspect `SimulationPanel`, `ClimateSimulation`, and `SolutionModel` in a
  deeper pass if climate/decision-support UX becomes a target.
- Architecture pattern:
  additive scene shell plus persistent menu/panel state plus solution groups
  plus simulation/logging.
- Reusable method:
  combine operator panels with explicit action/simulation logging so planning
  tools can be replayed or evaluated.
- Caveats:
  older project, local file logging, and domain-specific resilience model.

### `adityanooka/Unity-Dive-VR`

- Interesting idea:
  collaborative VR object handling can gate physics by multi-user selection
  count and use server-owned object spawning/reactions.
- Code donor value:
  `CollaborativeLift.cs` watches `XRGrabInteractable.interactorsSelecting` on
  the server, writes a `NetworkVariable<bool>`, and toggles Rigidbody kinematic
  state based on whether two or more interactors are selecting the object.
  `RandomSpawner.cs` spawns networked objects on the server. `NetworkReaction.cs`
  runs server-only proximity response using connected players.
  `Steering.cs` combines VR input actions with desktop debug fallback and
  camera-forward swim movement. `NetworkMovement.cs` guards movement by
  ownership. README highlights Netcode for GameObjects, ownership transfer,
  ray casting, Go-Go technique, and comfort movement.
- Product reference value:
  useful donor for collaborative manipulation gates and network authority
  boundaries.
- What to inspect next:
  inspect ownership transfer and scene prefab setup in a deeper pass if shared
  workbench collaboration becomes a prototype branch.
- Architecture pattern:
  Netcode authority plus XRI selection count plus network variables plus
  server-only object spawning/reaction.
- Reusable method:
  represent cooperative object affordances as synchronized state derived from
  interactor selection, not as local-only physics guesses.
- Caveats:
  course/project code, simple server authority assumptions, and some stubbed
  AI methods.

### `Hempp/street-art-gallery`

- Interesting idea:
  a social VR gallery can be framed as a package of content surfaces plus
  social affordances: hotspots, guided tours, emotes, voice chat, nametags,
  comfort settings, and gathering zones.
- Code donor value:
  sparse checkout found README-level material only; referenced source folders
  were not present in the sparse source pass. The README is still useful as a
  product checklist for social gallery features and multiplayer stack options.
- Product reference value:
  product/reference only, useful for gallery/onboarding/social-surface
  feature framing.
- What to inspect next:
  revisit if `exports/unity_vr_interactive` source appears in a non-sparse
  or release artifact.
- Architecture pattern:
  social gallery feature matrix with artwork metadata, hotspots, guided tour,
  avatars, emotes, voice, and comfort settings.
- Reusable method:
  keep shared spatial content tools honest about social and comfort affordance
  requirements, not just object rendering.
- Caveats:
  no code in this pass; do not treat it as implementation donor.

## Reusable Pattern Extraction

- Pattern candidate:
  spatial workbench loop for measure, model, manipulate, project, collaborate,
  and log.
- Problem solved:
  useful XR tools often need a chain from real-world input to editable state,
  feedback, collaboration, and later review.
- Reusable core:
  capture spatial input, normalize it into simple object/state records, provide
  an edit/manipulation surface, expose projection or placement feedback,
  synchronize collaborative state when needed, and log actions/metrics.
- Source evidence:
  `Sizer`, `Meshelanjelo`, `ar-resilience-planner-v2`, `Unity-Dive-VR`, and
  `street-art-gallery`.
- Abstraction boundary:
  keep measurement data separate from rendering, keep hand input separate from
  deformation algorithms, keep planning panels separate from simulation logic,
  and keep network authority separate from local interaction feel.
- What not to copy:
  old browser dependencies without modernization, local-only persistence as a
  final architecture, source-light gallery claims as code, or course project
  networking assumptions without testing.
- Method catalog action:
  add a method entry for spatial workbench state loops.

## Follow-Up Gaps

- Compare Sizer, Meshelanjelo, prior CAD/modeling waves, and WebXR drawing
  waves into a single spatial-authoring workbench matrix.
- Extract undo/history requirements for hand-driven mesh editing and AR
  measurement tools.
- Compare collaborative object gates in Unity Netcode against WebXR shared-room
  ownership and VRChat/Udon sync patterns.
