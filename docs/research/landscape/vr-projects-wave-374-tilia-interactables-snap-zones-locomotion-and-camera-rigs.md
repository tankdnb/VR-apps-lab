# Wave 374: Tilia Interactables Snap Zones Locomotion and Camera Rigs

## Theme

Prefab-level interaction, snapping, locomotion, and camera-rig utilities that
can become reusable building blocks for VR lab tools.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `ExtendRealityLtd/Tilia.Interactions.Interactables.Unity` | Studied | Interactor/interactable facade model with touch/grab state and providers |
| `ExtendRealityLtd/Tilia.Interactions.SnapZone.Unity` | Studied | Snap zone state machine with validity, transition, highlight, and thrown-object options |
| `ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity` | Studied | Teleport target, offset, floor snap, fade, and rule-based destination logic |
| `ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity` | Studied | Axis-driven movement facade with target, forward offset, rotation pivot, and camera rules |
| `ExtendRealityLtd/Tilia.CameraRigs.XRPluginFramework.Unity` | Studied | XR Plugin Framework camera rig node records and prefab creator boundary |
| `ExtendRealityLtd/Tilia.CameraRigs.SpatialSimulator.Unity` | Studied | Editor/runtime spatial simulator direction for headsetless scene interaction |

## Dedupe Notes

This wave does not treat Tilia as a monolithic app. It studies package-sized
utility layers that can inform `VR-apps-lab` prototype structure: facades,
configurators, prefabs, rig aliases, locomotion modules, and snap/interaction
state machines.

## Code-Level Findings

### `ExtendRealityLtd/Tilia.Interactions.Interactables.Unity`

- Interesting idea: interactor and interactable state are modeled through
  public facades, typed events, attach points, velocity trackers, providers,
  receivers, and rule helpers.
- Code donor value: `InteractorFacade` and `InteractableFacade` expose touch,
  grab, active touched/grabbed objects, precision attach points, grab provider
  selection, and secondary-to-primary swap behavior.
- Product reference value: strong base for tool handles, floating control
  panels, object inspectors, grab-to-configure utilities, and training props.
- What to inspect next: grab providers/receivers and stack behavior for
  multi-interactor conflicts.
- Caveat: the full package is broad; copy the state vocabulary, not the whole
  dependency graph.

### `ExtendRealityLtd/Tilia.Interactions.SnapZone.Unity`

- Interesting idea: snap zones expose state as `ZoneIsEmpty`,
  `ZoneIsActivated`, and `ZoneIsSnapped`, with validity rules, transition
  duration, scale application, highlight policy, and auto-snap thrown objects.
- Code donor value: `SnapZoneFacade` is a compact reference for socket,
  docking, holster, and object-placement tools.
- Product reference value: useful for body-attached tool trays, overlay window
  docking, calibration object placement, and reusable equipment sockets.
- What to inspect next: transition implementation and unsnap behavior.
- Caveat: auto-snap thrown objects should be opt-in and visible to users.

### `ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity`

- Interesting idea: teleport logic separates target, offset, destination
  rotation, camera fade validity, target validity, floor snapping, and blink
  thresholds.
- Code donor value: `TeleporterFacade` gives a reusable settings surface for
  locomotion modules that need offset-aware target relocation.
- Product reference value: helpful for lab prototypes that need comfort-aware
  repositioning, recenter tools, or room-scale movement helpers.
- What to inspect next: dash vs instant prefab internals and floor-snap pause
  behavior.
- Caveat: teleport gains/thresholds should be tuned per app and comfort mode.

### `ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity`

- Interesting idea: axis movement has explicit horizontal/vertical action
  inputs, multipliers, target, forward offset, rotation pivot, scene camera
  rules, and position/rotation events.
- Code donor value: `AxisMoveFacade` and `AxisMoveConfigurator` show a
  readable way to map two action axes into lateral/vertical/longitudinal motion
  while keeping target/camera rules configurable.
- Product reference value: useful for desktop-in-VR cursor movement, debug fly
  rigs, spatial simulators, and accessibility locomotion variants.
- What to inspect next: how pivot and scene camera rules are wired in prefab
  hierarchy.
- Caveat: axis movement needs comfort gates and collision policy.

### Camera rig packages

- Interesting idea: camera rigs are packaged as prefabs and records rather
  than hardwired directly into features.
- Code donor value: `XRFrameworkNodeRecord` records XR node type/priority
  style metadata, while editor prefab creators expose rig setup as reusable
  menu actions.
- Product reference value: future lab samples can use a tracked-alias or rig
  adapter boundary so utility features do not care which XR rig is installed.
- What to inspect next: spatial simulator input source and tracked alias
  integration.
- Caveat: rig packages are version-sensitive and should remain behind an
  adapter in this repository.

## Reusable Pattern Extraction

- Pattern candidate: facade-configurator prefab module with rig and locomotion
  adapters.
- Problem solved: VR tools become tangled when interaction, locomotion, rig
  setup, and object placement are embedded directly in feature scripts.
- Reusable core: public facade, internal configurator, typed events, validity
  rules, provider/receiver boundary, snap state, locomotion target, offset,
  camera validity, rig alias, prefab creator, and conflict policy.
- Source evidence: `InteractorFacade`, `InteractableFacade`, `SnapZoneFacade`,
  `TeleporterFacade`, `AxisMoveFacade`, `XRFrameworkNodeRecord`, and prefab
  creator scripts.
- Abstraction boundary: feature tools depend on facades and events; rig,
  physics, and scene hierarchy remain replaceable internals.
- What not to copy: whole vendor package trees, opaque prefab graphs without
  diagrams, or locomotion defaults without comfort/collision checks.
- Method catalog action: add Method 819.

## Family Placement

This wave creates a family for prefab-level interaction, docking, locomotion,
and rig adapter modules. It overlaps with inventory, menus, locomotion, and
headsetless workflow families.

## Why It Matters for `VR-apps-lab`

Future utilities will likely need a small kit of tool handles, snap docks,
movement helpers, and rig adapters. This wave documents a mature package shape
for those modules.

## Follow-Up Gaps

- Create a lightweight `VR-apps-lab` module checklist for facade/configurator
  samples.
- Compare Tilia snap zones with inventory/socket waves.
- Inspect how to document prefab internals without committing vendor assets.
