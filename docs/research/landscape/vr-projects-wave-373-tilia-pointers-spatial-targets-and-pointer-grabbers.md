# Wave 373: Tilia Pointers Spatial Targets and Pointer Grabbers

## Theme

World-space pointer, target, and distance-grab affordances for VR menus,
overlays, object panels, and spatial controls.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity` | Studied | Straight/curved object pointer prefabs and pointer payload extractors |
| `ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity` | Studied | Hover/activation target state with source validity and dispatcher processing |
| `ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity` | Studied | Pointer/distance grabber layer that connects pointers to interactables |

## Dedupe Notes

Prior waves studied many overlay and menu applications. This wave is lower
level: it studies reusable pointer/target primitives that can be used by
overlays, in-world menus, diagnostic panels, and remote object controls.

## Code-Level Findings

### `ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity`

- Interesting idea: package a pointer as object-space origin, repeated
  segment, destination, raycast rules, event payload, and extractors.
- Code donor value: pointer facade/extractor classes show a clean way to pull
  caster, origin, segment, destination, and source objects from pointer events.
- Product reference value: future utility overlays can treat laser pointers,
  curved rays, and reticles as replaceable indicator modules instead of hard
  coding raycasts into every feature.
- What to inspect next: prefab hierarchy for straight vs curved pointer
  visuals and collision filters.
- Caveat: pointer visuals alone are not a menu system; target rules and command
  dispatch must remain separate.

### `ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity`

- Interesting idea: spatial targets expose hover and activation actions as
  flags, with source validity, target override, collidable collections, and
  events for first enter, enter, exit, last exit, and activation.
- Code donor value: `SpatialTargetFacade`, `Dispatcher`, target processor
  prefabs, and `RuleContainer` checks are a useful model for target-state
  machines in VR UI.
- Product reference value: useful for wrist buttons, floating panels, world
  anchors, diagnostics nodes, and object handles where the UI element needs
  hover, lock cursor, hide cursor, select/deselect, and collision policy.
- What to inspect next: dispatcher-to-target relationship and how target groups
  manage deselect-other behavior.
- Caveat: flag-heavy behavior is powerful but needs clear docs and visual
  state indicators.

### `ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity`

- Interesting idea: pointer rays can initiate grab/interaction flows through a
  separate pointer grabber facade with target validity and raycast rules.
- Code donor value: `PointerGrabberFacade` separates pointer input, object
  targets, rule containers, physics cast configuration, and interactor output.
- Product reference value: strong reference for remote control overlays,
  desktop-in-VR, object inspectors, and dashboard panels that need distance
  activation without turning every target into a bespoke script.
- What to inspect next: distance grabber prefab setup and interaction with
  `Tilia.Interactions.Interactables.Unity`.
- Caveat: remote grab affordances need conflict rules when hand/touch and
  pointer selection compete.

## Reusable Pattern Extraction

- Pattern candidate: pointer-target-dispatch shell.
- Problem solved: VR tools need a reusable way to aim, hover, activate, and
  optionally grab from distance without each feature owning raycast logic.
- Reusable core: pointer source, cast policy, visual ray, cursor/destination,
  surface payload, target facade, hover state, activation state, source
  validity, target validity, group deselection, event dispatcher, and conflict
  policy.
- Source evidence: ObjectPointers pointer component extractors,
  `SpatialTargetFacade` hover/activation flags, `Dispatcher` validity checks,
  and `PointerGrabberFacade` raycast/target-validity bridge.
- Abstraction boundary: pointer visuals and physics casts are separate from
  target command behavior.
- What not to copy: hardcoded line styles, target flags without visible state,
  or pointer grabs that bypass interaction authority.
- Method catalog action: add Method 818.

## Family Placement

This wave creates a family for pointer, spatial target, and remote grab
primitives. It supports existing overlay, menu, desktop-in-VR, and diagnostics
families as an implementation layer.

## Why It Matters for `VR-apps-lab`

Overlay windows and VR menus are only usable when pointing, hover feedback,
activation, and rules are predictable. These packages give reusable vocabulary
for that layer.

## Follow-Up Gaps

- Compare this with previously studied hand menu and overlay projects.
- Draft an overlay control primitive spec: pointer source, target, command,
  disabled state, and feedback.
- Inspect how pointer target events should be logged for diagnostics and
  accessibility tuning.
