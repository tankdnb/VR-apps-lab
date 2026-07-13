# Wave 387: Spatial Application UX Patterns for Science, Rehab, and Strategy Tools

## Theme

Application-level VR/MR interaction patterns: scientific dataset exploration,
hand-tracked passthrough strategy gameplay, and rehabilitation task systems.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `Superkart/Immersive_Cosmology_Explorer` | Studied | Unity VR/desktop scientific visualization with data filtering, radial menus, session state, and collaboration framing |
| `WallerTheDeveloper/vr-tower-defense` | Studied | Meta Quest passthrough tower-defense project with wrist menu, pinch gestures, factories, state machines, and object pooling |
| `vladyslav-tsalko/REMIRE` | Deepened | Mixed-reality rehabilitation app marker with MRUK, hand tracking, grab rules, adaptive tasks, and LFS artifact caveat |

## Dedupe Notes

`REMIRE` was previously partial; this wave deepens its README-level interaction
model only because the LFS APK checkout failed. The other two projects add
application UX patterns that are useful as product references rather than
runtime/toolkit donors.

## Code-Level Findings

### `Superkart/Immersive_Cosmology_Explorer`

- Interesting idea: scientific VR can pair large point-cloud visualization
  with desktop synchronization, radial menus, filters, time steps, annotations,
  and session replay.
- Code donor value: `ImmersiveCosmologyExplorer/Assets` contains `Scripts`,
  `XR`, `XRI`, `UI`, `Shaders`, sample particle CSVs, scenes, and render
  texture resources.
- Product reference value: strong reference for analysis workbenches where VR
  and desktop users share state.
- What to inspect next: particle loader, LOD/culling, filter UI, annotation
  schema, and session serialization.
- Caveat: large assets and external docs/build links require provenance review.

### `WallerTheDeveloper/vr-tower-defense`

- Interesting idea: use passthrough and hand tracking for a spatial strategy
  game with wrist tower menu, pinch selection, auto-placement, and undoable
  commands.
- Code donor value: README architecture names `Core/Commands`, `Factories`,
  `HealthSystem`, `Pooling`, `StateMachine`, `TowerUnits`, `Hands`, and
  `UI/Inventory`.
- Product reference value: useful for VR utility menus because it combines
  wrist UI, spatial buttons, hover/pinch feedback, factories, and object pools.
- What to inspect next: wrist menu activation, tower placement command,
  ScriptableObject unit config, and pooling lifecycle.
- Caveat: game combat logic should not be copied into utility interaction code.

### `vladyslav-tsalko/REMIRE`

- Interesting idea: rehab tasks can be object-driven: objects define allowed
  grab states, finger combinations, difficulty, and adaptive placement based on
  detected table and user reach.
- Code donor value: README documents MRUK scene understanding, Meta XR Hands,
  pinch/grab/release, multi-finger/two-hand rules, grip strength, unstable-edge
  handling, and per-task difficulty.
- Product reference value: useful for task/calibration utilities that need
  per-object constraints and adaptive real-world placement.
- What to inspect next: task definitions, grab-rule assets, reach calibration,
  force thresholds, and clinical caveat labels.
- Caveat: checkout reported a missing LFS APK object; avoid artifact-based
  conclusions and use source/docs only.

## Reusable Pattern Extraction

- Pattern candidate: spatial application UX pattern library.
- Problem solved: product-level VR tools need reusable interaction grammar for
  radial/wrist menus, object-driven task rules, filters, placement, pooling,
  session state, and desktop collaboration.
- Reusable core: radial menu, wrist menu, pinch/hover feedback, object rule
  asset, command/undo action, factory/pool, adaptive placement, dataset filter,
  annotation/session state, desktop mirror, and caveat label.
- Source evidence: ICE README/Assets layout, tower-defense architecture README,
  and REMIRE README interaction/task sections plus LFS failure caveat.
- Abstraction boundary: app-specific science/game/clinical content should stay
  separate from menu, state, task-rule, and placement primitives.
- What not to copy: domain claims, game combat systems, clinical flows without
  validation, LFS artifacts, or desktop collaboration without conflict state.
- Method catalog action: add Method 832.

## Family Placement

Creates a spatial application UX pattern family for science, rehab, and
strategy-style examples where product behavior informs reusable utility
interaction patterns.

## Follow-Up Gaps

- Extract a common wrist/radial menu vocabulary across utility and game refs.
- Compare object-driven rehab grab rules with inventory/socket methods.
- Define a session-state schema for VR/desktop analysis tools.
