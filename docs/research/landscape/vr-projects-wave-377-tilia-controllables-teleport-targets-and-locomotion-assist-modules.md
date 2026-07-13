# Wave 377: Tilia Controllables Teleport Targets and Locomotion Assist Modules

## Theme

Constrained physical controls and locomotion assist modules: sliders, levers,
teleport targets, climbing, movement amplification, and collider following.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `ExtendRealityLtd/Tilia.Interactions.Controllables.Unity` | Studied | Linear/angular physics and transform drives for sliders/levers |
| `ExtendRealityLtd/Tilia.Locomotors.TeleportTargets.Unity` | Studied | Point/area teleport target prefab creation boundary |
| `ExtendRealityLtd/Tilia.Locomotors.Climbing.Unity` | Studied | Climbable/climbing facade with release velocity multiplier |
| `ExtendRealityLtd/Tilia.Locomotors.MovementAmplifier.Unity` | Studied | Source-to-target movement amplification with ignored radius and multiplier |
| `ExtendRealityLtd/Tilia.Trackers.ColliderFollower.Unity` | Studied | Collider follower module that tracks a source and supports snap-to-source |

## Dedupe Notes

Wave 374 covered teleporter and axis movement. This wave studies companion
modules that constrain or assist movement and physical controls.

## Code-Level Findings

### `ExtendRealityLtd/Tilia.Interactions.Controllables.Unity`

- Interesting idea: sliders/levers are modeled as linear or angular drives with
  a shared drive facade, axis selection, limits, target values, and either
  physics-joint or transform implementations.
- Code donor value: `LinearDriveFacade`, `AngularDriveFacade`,
  `LinearJointDrive`, `LinearTransformDrive`, `AngularDrive`, and editor
  creator windows show a reusable constrained-control grammar.
- Product reference value: useful for VR settings panels, cockpit controls,
  calibration sliders, physical toggles, laboratory knobs, and training props.
- What to inspect next: value event emission and target-value thresholding.
- Caveat: physics and transform drives should be explicit modes; do not mix
  them silently in one control.

### Locomotion assist packages

- Interesting idea: locomotion support is decomposed into teleport target
  prefabs, climbable objects, movement amplification, and collider follower
  tracking.
- Code donor value: `TeleportTargets` editor prefab creator exposes point/area
  target packages; `ClimbableFacade` exposes release velocity multiplier;
  `MovementAmplifierFacade` exposes source, target, ignored radius, and
  multiplier; `ColliderFollowerFacade` exposes source tracking and snap.
- Product reference value: useful for comfort prototypes, accessibility
  movement variants, interaction safety, physical-space movement repair, and
  collidable proxy utilities.
- What to inspect next: target validity/area behavior in teleport target
  prefabs and movement amplifier stabilization internals.
- Caveat: movement amplification and climbing need explicit comfort and safety
  labels.

## Reusable Pattern Extraction

- Pattern candidate: constrained control and locomotion assist module set.
- Problem solved: VR tools need physical controls and movement helpers without
  rewriting axis/limit/physics/transform logic per prototype.
- Reusable core: drive axis, drive limit, target value, threshold, physics vs
  transform mode, prefab creator, point/area teleport target, climb release
  multiplier, source/target movement amplifier, ignored radius, collider
  follower, snap-to-source, and comfort caveats.
- Source evidence: controllable drive classes, prefab creator scripts,
  `ClimbableFacade`, `MovementAmplifierFacade`, and `ColliderFollowerFacade`.
- Abstraction boundary: feature code consumes control values or locomotion
  intents; module internals own physics, transforms, and collider following.
- What not to copy: hardcoded drive limits, unclear physics/transform mode,
  locomotion amplification without comfort labels, or hidden collider proxies.
- Method catalog action: add Method 822.

## Family Placement

Creates a family for constrained controls and locomotion assist modules. It
connects to inventory sockets, locomotion, accessibility, and simulator
families.

## Follow-Up Gaps

- Compare with cockpit, settings, and calibration UI waves.
- Draft a slider/knob value schema for VR utility settings.
- Inspect how drive value changes should integrate with haptics and telemetry.
