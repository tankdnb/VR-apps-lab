# Wave 290 - VR Assembly, Maintenance, and Procedure Training Workflows

This wave studies VR assembly and maintenance projects as reusable references
for part/socket snapping, procedure-step validation, save/loadable assemblies,
score/timer loops, tool selection, and companion dashboards.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- VR assembly manager and snap-point systems;
- maintenance/procedure training step controllers;
- scoring, timing, ranking, and final feedback loops;
- tool selection panels and per-step work gates;
- companion dashboards and score APIs;
- source-light or empty repositories only when they clarify caveats.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `T0riU/VR-Assembly-Manager` | Assembly snap/socket and persistence system | Studied | Strongest donor: parts, attach IDs, sockets, snap validation, JSON save/load, thumbnails, stats, and prefab registry |
| `carlosMoragon/VR-Assembly-Simulator` | Procedure assembly training scenario | Studied with asset/vendor caveats | Score/timer and piece-placement scripts inside a larger Unity/FMOD/XRI project |
| `NopparatSang/SCGVR2` | Maintenance process workflow | Studied with SDK-heavy caveat | Process controller, tool selection, screw/bolt/locknut steps, timers, rankings, and OVR interactions |
| `JonyHM/VRDoorAssembly` | Companion scoreboard/admin dashboard | Studied as companion reference | Angular score table and score service for training result display/API integration |
| `lintglitch/vr-assembly` | Source-light assembly scene reference | Studied with source-light caveat | Mostly assets/environment material in this pass, useful as a weak comparison node |
| `White-H-21/VR-assembly-system` | Empty/no-source candidate | Skipped | Repository had no readable checked-out HEAD/content in local study cache |
| `nyu-lgcoop/VRTrainingUnity` | Legacy/source-light training shell | Studied with source-light caveat | Mostly Standard Assets in inspected tree; retained as a low-signal training reference |

## Code-Level Findings

### `T0riU/VR-Assembly-Manager`

- Interesting idea:
  assembly is modeled as parts with attach points and sockets that validate by
  matching IDs, then disable grabbing and persist part/snap relations to JSON.
- Code donor value:
  very high: `AssemblyPart.cs` manages `Free`, `Held`, and `Attached` states,
  XR grab listeners, trigger colliders, attach point visuals, hand release,
  socket alignment, and detach/release. `AssemblySocket.cs` filters compatible
  parts by accepted attach ID and state, chooses closest candidates, forces hand
  release, and delegates attachment to managers. `AssemblySaveSystem.cs`
  serializes prefab names, order indices, snap poses, relations, buildability,
  thumbnails, best times, and restores assemblies in phases.
- Product reference value:
  very high for a reusable VR assembly authoring/training toolkit.
- What to inspect next:
  `AssemblyModeManager`, `SnapPointSetup`, `PartRegistry`,
  `PrefabRegistry`, JSON schema examples, UI flows, and error/undo handling.

### `carlosMoragon/VR-Assembly-Simulator`

- Interesting idea:
  a VR assembly training scenario can score the user over time, penalize
  mistakes, and gate placement through tag/collision-based pieces.
- Code donor value:
  medium/low with caveats: `ScoreManager.cs` implements score decay,
  error penalties, final display, and score retrieval; `PlaceRemovePiece.cs`
  snaps matching-tag objects on collision, disables grabbing briefly, and
  reactivates XR grabbing after a delay.
- Product reference value:
  medium for training assessment loops and student-project procedure framing.
- What to inspect next:
  `Detect_object`, `Timer_Manager`, lab/practice managers, scene progression,
  and whether any custom logic is hidden behind large vendor/asset payloads.

### `NopparatSang/SCGVR2`

- Interesting idea:
  maintenance is expressed as a sequence of work steps with specific tools,
  object activation/deactivation, animations, timers, ranking, and tool panels.
- Code donor value:
  high for workflow logic: `ProcessSystem.cs` models work types such as anim,
  setup, remove, screw, bolt plate, and locknut; it validates tags, locks tool
  colliders/grab points, animates screw movement, toggles active/deactive
  objects, and notifies `ProcessController`. `GameplaySystem.cs` selects
  process variants, starts timers, ends games, and opens ranking panels.
  `ToolsSelectSystem.cs` toggles tool panels and moves selected tools to a
  staging transform.
- Product reference value:
  high for maintenance training, guided repairs, and sequential procedure UX.
- What to inspect next:
  `ProcessController`, `RankingProcess`, `ScrewProgress`, highlight scripts,
  process data representation, and localization/authoring needs.

### `JonyHM/VRDoorAssembly`

- Interesting idea:
  a VR training app can have a web companion that displays scores and submits
  results via a normal API.
- Code donor value:
  medium as a companion pattern: `ScoreComponent` renders an Angular Material
  table from route-resolved `ScoresResponse`, and `ScoreService` wraps
  `/score` GET/POST requests.
- Product reference value:
  high for separating headset-side training from instructor dashboards,
  analytics pages, and class/admin surfaces.
- What to inspect next:
  backend API, auth/current-user flow, score schema, resolver, and whether the
  VR side is in a separate repository.

### Source-Light and Skipped Nodes

- `lintglitch/vr-assembly`:
  source-light in this pass; useful mainly as a weak environment/asset
  comparison node unless custom interaction scripts are found later.
- `nyu-lgcoop/VRTrainingUnity`:
  mostly Standard Assets in inspected source; not promoted as a donor.
- `White-H-21/VR-assembly-system`:
  skipped because the local clone had no usable checked-out repository content.

## Reusable Pattern Extraction

- Pattern candidate:
  VR assembly/procedure workflow boundary across parts, sockets, snap IDs,
  step validation, save/load, scoring, and companion dashboards.
- Problem solved:
  assembly and maintenance apps become brittle when physical interaction,
  training sequence, persistence, scoring, and instructor reporting are fused
  into scene scripts.
- Reusable core:
  part state machine, attach point ID schema, socket compatibility filter,
  closest-candidate snap, hand-release policy, snap transform alignment,
  visual affordances, step/work-type controller, tool validation, active object
  gates, score/timer/ranking loop, JSON assembly persistence, thumbnail,
  prefab registry, and web companion score API.
- Source evidence:
  `VR-Assembly-Manager`, `VR-Assembly-Simulator`, `SCGVR2`,
  `VRDoorAssembly`, plus source-light/empty caveats from `vr-assembly`,
  `VRTrainingUnity`, and `VR-assembly-system`.
- Abstraction boundary:
  keep physical manipulation, snap validation, procedure graph, persistence,
  scoring, instructor dashboard, and analytics/export separate.
- What not to copy:
  tag-only validation as a full assembly model, vendor SDK payloads, hardcoded
  scene/object names, hidden procedure data in GameObject names, or dashboards
  without score schema/versioning.
- Method catalog action:
  add an assembly/procedure training workflow method.

## Follow-Up Gaps

- Deepen `T0riU/VR-Assembly-Manager` into a reuse plan for reusable
  snap/socket/persistence architecture.
- Extract a procedure-authoring schema from `SCGVR2` without copying hardcoded
  GameObject flows.
- Compare score/timer/ranking models across Wave 280 training projects and
  this assembly-specific wave.
- Decide whether `VR-apps-lab` should prototype a minimal assembly-method
  sample: two parts, attach IDs, socket validation, save/load, and score event.
