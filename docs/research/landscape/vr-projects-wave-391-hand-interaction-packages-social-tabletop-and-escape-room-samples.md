# Wave 391: Hand Interaction Packages, Social Tabletop, and Escape Room Samples

## Theme

Hand interaction and product samples: OpenXR hand package wrappers, social
tabletop colocation, and escape-room interaction references.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `Extrys/XRMasterHands` | Studied | Unity package for OpenXR hand tracking via Input System with samples and gesture/joystick helpers |
| `oculus-samples/Unity-SpiritSling` | Studied | Official MR social tabletop game with contextual board placement, anchors, avatars, networking, and hand grabs |
| `francesctr4/EscapeRoomVR` | Studied | Unity VR escape-room sample with puzzle/object interaction structure |

## Dedupe Notes

Previous waves covered Tilia/Unity hand and spatial UI primitives. This wave
adds a lightweight hand package, a large official social tabletop sample, and a
small app-level puzzle reference.

## Code-Level Findings

### `Extrys/XRMasterHands`

- Interesting idea: package Unity OpenXR hand tracking as `Runtime`, `Editor`,
  and `Samples~` instead of forcing each project to wire Input System details.
- Code donor value: `Runtime`, `Editor`, `Samples~`, package metadata, gesture
  samples, and `Sample_HandJoystick.cs` show hand pose to action/joystick
  mapping.
- Product reference value: useful for future hand-menu/input tools where hand
  poses become commands without a full interaction framework.
- What to inspect next: skeleton driver, hand binding config, sample gestures,
  and package install assumptions.
- Caveat: package maturity and OpenXR provider compatibility need testing
  before code reuse.

### `oculus-samples/Unity-SpiritSling`

- Interesting idea: a social MR tabletop sample demonstrates contextual board
  placement, scene-aware visibility, hand grabs, avatars, networking rooms,
  shared anchors, and platform configuration.
- Code donor value: `Assets/SpiritSling`, `Documentation`, networking scripts,
  `ConnectionManager`, `NetworkPlayer`, shared anchor setup docs, and LFS-heavy
  assets show a full social MR app envelope.
- Product reference value: strong reference for multiplayer tabletop utilities
  and colocated MR session setup.
- What to inspect next: board placement scoring, shared anchor lifecycle,
  room UI, player disconnect handling, and platform service gates.
- Caveat: very large LFS/vendor sample; extract architecture and UX patterns,
  not full project bulk.

### `francesctr4/EscapeRoomVR`

- Interesting idea: a compact VR escape-room project can be used as a puzzle
  interaction reference for locks, keys, inspectable objects, and room flow.
- Code donor value: `VR Project`, Unity assets, README, and project folders
  show a small app-level structure rather than a framework.
- Product reference value: useful for task/puzzle flow inspiration where
  utility tools need object state, hinting, and sequence gates.
- What to inspect next: puzzle state machines, inventory/object pickup, reset
  flow, and hint UI.
- Caveat: app-specific puzzle content should stay separate from reusable
  interaction primitives.

## Reusable Pattern Extraction

- Pattern candidate: hand-command package and social tabletop interaction
  envelope.
- Problem solved: VR/MR tools need hand pose commands, contextual placement,
  shared anchors, room/session UI, player presence, and puzzle/task gates as
  reusable concepts.
- Reusable core: hand skeleton driver, pose-to-action map, gesture sample,
  hand joystick, contextual board placement, shared anchor lifecycle, room UI,
  player disconnect state, puzzle state, object gate, and hint/reset surface.
- Source evidence: `XRMasterHands` `Runtime/Editor/Samples~`,
  `Sample_HandJoystick.cs`, SpiritSling `Documentation` and networking scripts,
  and EscapeRoomVR Unity project structure.
- Abstraction boundary: hand package and session/anchor infrastructure should
  not own game rules, puzzle content, or vendor platform secrets.
- What not to copy: LFS-heavy official sample bulk, platform app IDs, puzzle
  content as framework code, or hand gestures without fallback input.
- Method catalog action: add Method 836.

## Family Placement

Creates a hand package/social tabletop/puzzle sample family. It links hand
input packages to colocated MR and task-flow product references.

## Follow-Up Gaps

- Compare hand pose-to-action maps with prior voice/action command schemas.
- Draft a shared-anchor session checklist for social MR utilities.
- Extract a minimal puzzle/task state pattern from escape-room samples.
