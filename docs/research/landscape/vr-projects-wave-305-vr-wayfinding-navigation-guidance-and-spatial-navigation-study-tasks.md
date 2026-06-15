# Wave 305 - VR Wayfinding, Navigation Guidance, and Spatial Navigation Study Tasks

This wave studies VR wayfinding and navigation projects as reusable references
for gaze-to-destination movement, spatial navigation tasks, route/room
condition management, agent guidance, haptic wayfinding, comfort-linked
navigation aids, and experiment telemetry.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- VR wayfinding and spatial navigation study tasks;
- navigation goals, target sequencing, room transitions, and route guidance;
- agent/hint interactions and participant decisions;
- path, time, head orientation, and decision telemetry;
- source-light haptic and comfort/navigation references where they add product
  direction.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `pepwuper/Google-Cardboard-VR-Navigation` | Gaze-to-NavMesh micro-navigation | Studied | Minimal gaze cursor to NavMeshAgent destination plus player-following UI helper |
| `npresearchlab/NavCity_Toolkit` | Spatial navigation task harness | Studied | Target sequence, participant CSV logging, headset position, frame/time, target name, and orientation capture |
| `zcbtmfc/Wayfinding-Task` | Agent-guided room decision study | Studied | Multi-room additive scene loading, condition randomization, agent advice, decision logging, and time-delta metrics |
| `maxleblanc/sightless-vr` | Haptic wayfinding and ghost-architecture reference | Studied as source-light product reference | Haptic wearable/Unity/Arduino concept for navigating virtual architectural obstacles without visual display |
| `angsamuel/GingerVR` | Navigation comfort technique reference | Studied as source-light comfort node | Collection of comfort/navigation aids such as virtual nose, dynamic blur/FOV, dots, viewpoint snapping, vision lock, and VirtualCAVE |

## Code-Level Findings

### `pepwuper/Google-Cardboard-VR-Navigation`

- Interesting idea:
  the smallest useful VR navigation helper can map gaze/cursor position to a
  NavMesh destination and keep UI anchored to the player's ground position.
- Code donor value:
  medium as a micro-utility. `PlayerMotor.cs` takes a `Cursor` transform and
  sets a `NavMeshAgent.destination` to that cursor position when a floor event
  fires. `FollowPlayer.cs` copies the player X/Z position while preserving the
  follower object's height, useful for keeping floor-level menus or guidance
  surfaces aligned.
- Product reference value:
  medium for simple headset/gaze navigation, no-controller demos, and
  constrained museum/gallery/wayfinding prototypes.
- What to inspect next:
  navmesh failure behavior, comfort constraints, recentering, event trigger
  setup, target affordance, and modern XR Interaction Toolkit equivalents.
- Reusable pattern extraction:
  model gaze navigation as `target source -> destination resolver -> movement
  actuator`, with UI-follow helpers kept separate.

### `npresearchlab/NavCity_Toolkit`

- Interesting idea:
  a spatial navigation task can be represented by a current target index,
  participant-facing target text, and frame/time/pose CSV recording.
- Code donor value:
  high for study harness basics. `CSV_Writer.cs` writes participant ID, X/Z
  position, frame count, total time, lapsed time, target name, and rotation
  values. `TargetManager.cs` stores an ordered target array and advances only
  when the current target matches the required target. `text.cs` updates a UI
  mission statement with the active target name.
- Product reference value:
  high for training, wayfinding evaluation, and route-learning prototypes.
- What to inspect next:
  target trigger scripts, participant setup UI, data folder creation,
  target-order randomization, reset behavior, and camera/rotation CSV schema
  cleanup.
- Reusable pattern extraction:
  keep target sequencing, participant instruction text, movement logging, and
  route-completion triggers as separable modules.

### `zcbtmfc/Wayfinding-Task`

- Interesting idea:
  wayfinding studies can compare agent-provided advice by pairing randomized
  conditions with room transitions, advice playback, and decision time deltas.
- Code donor value:
  high for study-state architecture. `SceneManagerScript.cs` loads rooms
  additively, generates an eight-condition list, assigns agent side/answer
  combinations, starts trials, and records room/condition state. `LoadNextRoom.cs`
  unloads previous rooms, loads the next room, instantiates agents, assigns
  rotations and audio clips, and compensates for rotated room orientation.
  `AskAgent.cs` triggers agent audio/animation through XR controller or desktop
  input and logs ask time and distance. `MazeLogging.cs` writes subject,
  trial, room, condition, agent positions/answers/ask times/distances,
  decision, and derived time deltas.
- Product reference value:
  very high for guided-navigation training, NPC hint systems, and navigation
  study tooling.
- What to inspect next:
  `MadeDecision.cs`, `EnteredRoom.cs`, full condition model, room authoring
  docs, agent replacement instructions, CSV delimiter consistency, and
  participant consent/setup.
- Reusable pattern extraction:
  pair route progression with condition randomization and decision telemetry,
  so wayfinding UX can be evaluated rather than only experienced.

### `maxleblanc/sightless-vr`

- Interesting idea:
  wayfinding does not need to be purely visual; a haptic wearable can make
  virtual walls and ghost architecture perceivable in a physical room.
- Code donor value:
  low/source-light in this pass. The README documents a Unity/Arduino/RF24
  architecture in which tracked position and virtual-wall contact drive a
  wireless vibrating wearable.
- Product reference value:
  high for accessibility, haptic guidance, invisible boundaries, and
  no-HMD/spatial-awareness product directions.
- What to inspect next:
  Unity scripts, Arduino sender/receiver code, collision-to-haptic mapping,
  haptic intensity/duration schema, safety boundaries, and wearable latency.
- Reusable pattern extraction:
  treat haptic navigation as a feedback channel fed by spatial collision or
  proximity events, not as a special-case scene effect.

### `angsamuel/GingerVR`

- Interesting idea:
  wayfinding and navigation should be considered together with comfort aids:
  rest frames, dynamic blur/FOV, viewpoint snapping, vision lock, and
  reference-frame overlays can change how users tolerate movement.
- Code donor value:
  low/source-light in this pass, because the inspected material was primarily
  README-level technique descriptions rather than clean source modules.
- Product reference value:
  medium for comfort-option menus and navigation safety presets.
- What to inspect next:
  scripts/prefabs for DynamicFOV, HeadSnapper, VisionLock, DotEffect,
  VirtualCAVE, user tuning parameters, and compatibility with existing comfort
  waves.
- Reusable pattern extraction:
  keep comfort/navigation aids configurable and visible to the user rather than
  baking them into movement code.

## Reusable Pattern Extraction

- Pattern candidate:
  VR wayfinding study boundary across target sequencing, guidance sources,
  movement/destination adapters, room transitions, comfort aids, haptic
  feedback, decision capture, and telemetry.
- Problem solved:
  navigation projects mix movement implementation, route authoring, hints,
  NPC/agent advice, comfort effects, physical-space cues, and experiment logs.
  Reuse needs a structure where wayfinding UX can be tested, tuned, and
  compared.
- Reusable core:
  target/waypoint list, active target state, gaze/controller destination
  source, movement actuator, route/room loader, condition randomizer, guidance
  or agent channel, haptic/proximity feedback channel, comfort preset, decision
  gate, participant/session metadata, path/time/head-pose log, and derived
  time-delta metrics.
- Source evidence:
  `pepwuper/Google-Cardboard-VR-Navigation`,
  `npresearchlab/NavCity_Toolkit`, `zcbtmfc/Wayfinding-Task`,
  `maxleblanc/sightless-vr`, and `angsamuel/GingerVR`.
- Abstraction boundary:
  keep movement, route state, hints/agents, haptics, comfort effects,
  participant setup, and logs separate.
- What not to copy:
  global static target state without reset, `Application.dataPath` logs as the
  only persistence path, comfort effects without opt-in, haptic walls without
  safety checks, or guidance conditions that cannot be reconstructed from logs.
- Method catalog action:
  add a VR wayfinding and navigation study method.

## Follow-Up Gaps

- Deepen `zcbtmfc/Wayfinding-Task` decision, room entry, and condition-model
  scripts.
- Deepen `sightless-vr` if source code is available outside the README-heavy
  checkout.
- Compare these navigation tasks with earlier locomotion and training
  assessment waves to separate movement mechanics from wayfinding evaluation.
- Build a navigation matrix across gaze-to-NavMesh, target sequence, NPC/agent
  advice, haptic boundary, comfort rest-frame, room transition, and telemetry.
