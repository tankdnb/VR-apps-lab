# Wave 473: VR/WebXR wayfinding, navigation guidance, and semantic simplification

- Date: `2026-07-18`
- Scope: VR navigation aids, map-placement studies, controller-driven path
  rails, semantic scene simplification, browser route graphs, and immersive
  navigation handoff design.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `renatezhang/wayfinding-prototype` | Lightly studied | Unity wayfinding study prototype around map placement, wrong-bus-stop scenario, and telemetry plan |
| `TheStarTiger/vr-navigation-trails` | Studied | Small Unity scripts for thumbstick-driven nav path rails, vignette opacity, locomotion velocity, and sickness telemetry |
| `bionicvisionlab/2025-VRST-SmartRaster` | Studied | Unity bionic-vision wayfinding experiment with semantic scene simplification and subject-seeded scenarios |
| `FireFlyDeveloper/webxr-indoor-nav-demo4-react` | Studied | WebXR/Three route graph with A* pathfinding, AR arrows, destination markers, and arrival state |
| `immersive-web/navigation` | Studied as design reference | Immersive Web design notes for UA/browser-initiated session navigation and security/privacy constraints |

## Project notes

### `renatezhang/wayfinding-prototype`

- Interesting idea: a wayfinding study can vary where maps are placed in an
  environment and log whether participants recover after a route is blocked.
- Code donor value: low to medium; the source pass shows more Unity/template
  scene structure than reusable custom navigation code.
- Product reference value: high for study design around route replanning and
  map placement.
- Source evidence: `README.md`, Unity project structure, and stated data
  collection plan.
- Reusable core: wrong-start scenario, target destination, barricade-triggered
  replanning, map-placement conditions, planned head-orientation logs, time at
  map, SUS/NASA-TLX, and open-ended questions.
- What not to copy: unimplemented condition claims, headset-not-tested status,
  and missing concrete telemetry logger.
- What to inspect next: whether the planned telemetry schema becomes source
  backed and how map objects are labelled in scene.

### `TheStarTiger/vr-navigation-trails`

- Interesting idea: a navigation hint can be generated only while the thumbstick
  is active, showing a hovering path rail from the user to a raycast/navmesh
  target.
- Code donor value: medium as a tiny implementation of path-preview and comfort
  overlays.
- Product reference value: high for lightweight in-VR wayfinding assistance.
- Source evidence: `NavRailMesh.cs`, `OpacityChanger2DAxis.cs`,
  `OpacityChanger.cs`, `LocomotionVelocity.cs`, and `SicknessTracker.cs`.
- Reusable core: input-active gate, raycast or forward projected target,
  `NavMesh.CalculatePath`, line renderer corners raised by hover height,
  hide-on-inactive behavior, input-responsive vignette radius/alpha, and rough
  camera-motion comfort sampling.
- What not to copy: old Oculus axis names, rough Euler-angle sickness math,
  missing settings/profile persistence, and no semantic destination model.
- What to inspect next: provider-neutral input bindings, route confidence
  labels, and destination-intent integration.

### `bionicvisionlab/2025-VRST-SmartRaster`

- Interesting idea: wayfinding accessibility experiments can treat the displayed
  world as a condition, switching between control, SmartEdges, and SmartRaster
  simplification while preserving scenario prompts and logs.
- Code donor value: high for scenario randomization and experiment controller
  structure.
- Product reference value: high for low-vision, bionic-vision, and semantic
  simplification utilities.
- Source evidence: `README.md`, `SmartRasterManager.cs`,
  `NavigationManager.cs`, `ScenarioController.cs`, `ExperimentController.cs`,
  and `PathsController.cs`.
- Reusable core: subject-id seeded counterbalancing, phase-to-display-mode map,
  randomized table/door/object conditions, prompt/question state machine,
  distraction toggles, path rebuilding, block/trial logs, and difficulty
  ratings.
- What not to copy: hard-coded subject/block rules, external package lock-in,
  bionic-vision shader specifics, and research-scene assumptions.
- What to inspect next: portable condition schema, display-mode labels, and
  scene simplification primitives that can work outside this restaurant task.

### `FireFlyDeveloper/webxr-indoor-nav-demo4-react`

- Interesting idea: a browser XR navigation helper can pair a small waypoint
  graph with A* pathfinding, DOM destination UI, and world-space route arrows.
- Code donor value: medium to high for a compact WebXR route-overlay baseline.
- Product reference value: high for indoor guide, museum route, training, and
  accessibility navigation panels.
- Source evidence: `src/MapData.js`, `src/Navigation.jsx`, `src/Scene.js`,
  `src/App.jsx`, and `src/WebXRButton.jsx`.
- Reusable core: waypoint/edge schema, adjacency builder, Euclidean A*,
  global nav state, destination selector, route tube, repeated arrow meshes,
  destination marker ring, local-floor viewer-pose polling, distance-to-next
  waypoint, step advancement, arrival state, and visibility-change reference
  reset.
- What not to copy: hard-coded map origin, `window.__navState` globals,
  checked-in `node_modules`/`dist`, no anchor/calibration layer, and fixed
  one-meter arrival threshold.
- What to inspect next: room calibration, route editing UI, stale-pose
  diagnostics, and accessibility-friendly instruction modes.

### `immersive-web/navigation`

- Interesting idea: immersive navigation can be treated as a browser/UA
  controlled capability instead of requiring every page to expose its own
  "enter VR" button.
- Code donor value: low; this is a standards/design reference, not a code
  library.
- Product reference value: high for safe immersive deep links, kiosk flows, and
  cross-page VR content transitions.
- Source evidence: `README.md` and design notes in the repo.
- Reusable core: `sessiongranted` concept, UA-controlled immersive entry,
  seamless in-VR navigation, interstitial/browser UI, visible origin/destination
  state, same-origin versus cross-origin privacy notes, and fallback to windowed
  mode.
- What not to copy: assuming application code alone can grant immersive
  navigation, or hiding cross-origin/security prompts from users.
- What to inspect next: modern WebXR/browser status and how product utilities
  should expose deep-link warnings today.

## Reusable pattern extraction

- Pattern candidate: `Wayfinding guidance graph with semantic navigation study
  loop`.
- Problem solved: VR navigation tools need to combine route intent, visual
  guidance, comfort, map semantics, and research/quality evidence.
- Reusable core: destination/waypoint graph, route solver, path rail or arrow
  renderer, arrival/step state, map-placement or semantic-display condition,
  subject/session randomization, head/position/time logs, comfort vignette,
  route-block/replanning scenario, and visible browser/runtime navigation
  boundaries.
- Source evidence: `vr-navigation-trails/NavRailMesh.cs`,
  `2025-VRST-SmartRaster/Assets/SmartRaster/Scripts/*`,
  `webxr-indoor-nav-demo4-react/src/*`, `wayfinding-prototype/README.md`, and
  `immersive-web/navigation/README.md`.
- Abstraction boundary: keep route graph, renderer, locomotion/comfort adapter,
  study condition controller, and browser/session handoff independent.
- What not to copy: hard-coded maps, old input axes, unvalidated study
  conditions, global browser state, and immersive entry without explicit user or
  UA status.
- Method catalog action: add `Method 918`.

## Why this matters for VR-apps-lab

This wave extends the lab beyond overlay windows into guided spatial behavior:
how a utility can tell the user where to go, why that route is trustworthy, and
how to log whether the guidance actually helped.
