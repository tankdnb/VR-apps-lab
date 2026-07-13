# Wave 372: Tilia Input Adapters and Action Composition Packages

## Theme

Unity XR input adapter packages that convert platform input into reusable
actions and composable action transforms.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `ExtendRealityLtd/Tilia.Input.UnityInputManager` | Studied | Legacy Unity Input Manager wrapper into Zinnia action types |
| `ExtendRealityLtd/Tilia.Input.UnityInputSystem` | Studied | New Unity Input System callback/property transformers and XR velocity source |
| `ExtendRealityLtd/Tilia.Input.CombinedActions.Unity` | Studied | Combinators for boolean/float/vector action routing, angle ranges, and double-click actions |

## Dedupe Notes

This wave avoids duplicating already-studied broad SteamVR/OpenXR input SDKs.
It focuses on package-sized Unity utility donors where the value is the adapter
boundary: platform input becomes neutral `BooleanAction`, `FloatAction`,
`Vector2Action`, or `Vector3Action` streams that other VR tools can consume.

## Code-Level Findings

### `ExtendRealityLtd/Tilia.Input.UnityInputManager`

- Interesting idea: wrap legacy named axes/buttons as processable action
  components rather than reading `Input.*` directly in tool scripts.
- Code donor value: small `UnityInputManagerAxis1DAction`,
  `UnityInputManagerAxis2DAction`, and `UnityInputManagerButtonAction` classes
  show how an old input backend can still feed a neutral action graph.
- Product reference value: useful for compatibility layers where a VR utility
  needs to support older Unity projects without coupling every feature to one
  input API.
- What to inspect next: editor/prefab samples that map common OpenVR/Oculus
  names into action assets.
- Caveat: legacy input names are project settings, so the reusable piece is the
  wrapper boundary, not the specific axis names.

### `ExtendRealityLtd/Tilia.Input.UnityInputSystem`

- Interesting idea: convert `InputAction.CallbackContext` and
  `InputActionProperty` into typed action streams and velocity trackers.
- Code donor value: `CallbackContextToBoolean`, `CallbackContextToFloat`,
  `CallbackContextToVector2`, `CallbackContextToVector3`, and
  `InputActionPropertyVelocityTracker` are strong references for typed input
  extraction and enable/disable lifecycle handling.
- Product reference value: a future VR utility can expose a neutral input
  schema while letting projects bind controller, hand, keyboard, or custom
  actions through Unity's Input System.
- What to inspect next: `Samples~/GenericXR` bindings and how they can be
  documented as a portable default binding pack.
- Caveat: do not copy Unity project sample maps as universal defaults; treat
  them as binding templates.

### `ExtendRealityLtd/Tilia.Input.CombinedActions.Unity`

- Interesting idea: make input composition explicit through action components
  such as axes-to-vector, axes-to-angle, angle-range-to-boolean, boolean-to-axis,
  and double-click actions.
- Code donor value: `AxesToVector3Action`, `AxesToAngleAction`,
  `AngleRangeToBooleanFacade`, `BooleanTo1DAxisAction`, and
  `DoubleClickActionFacade` show reusable input grammar primitives.
- Product reference value: this is useful for overlay menus, radial menus,
  locomotion modes, tool modifiers, and accessibility remaps where raw input
  needs policy before it becomes a command.
- What to inspect next: whether a compact `VR-apps-lab` action grammar can
  reuse these categories without inheriting the whole Tilia/Zinnia stack.
- Caveat: component graphs can become hard to debug unless the final command
  path is visible in docs or debug UI.

## Reusable Pattern Extraction

- Pattern candidate: input backend adapter plus action-composition graph.
- Problem solved: VR utilities need stable commands while Unity projects vary
  between legacy input, Input System, OpenXR, vendor SDKs, and custom devices.
- Reusable core: backend reader, typed action stream, source enable lifecycle,
  value conversion, velocity tracker, action combiner, command naming, debug
  labels, binding preset, and override path.
- Source evidence: Unity Input Manager action wrappers, Input System callback
  transformers, `InputActionPropertyVelocityTracker`, and CombinedActions
  axes/angle/double-click components.
- Abstraction boundary: project/vendor input stays outside; utility features
  consume only neutral action values and named command events.
- What not to copy: project-specific binding names, opaque prefab graphs, or
  deep dependency chains without a debug surface.
- Method catalog action: add Method 817.

## Family Placement

This wave creates a dedicated family for Unity XR input adapters and action
composition packages. It overlaps with menu/control waves, locomotion waves,
and accessibility/remapping waves, but its distinct lesson is the input-command
boundary.

## Why It Matters for `VR-apps-lab`

Many future tools in this repository will need input, but the repository should
not choose one SDK as the permanent center. These packages show how to keep
input backends replaceable while documenting a reusable command grammar.

## Follow-Up Gaps

- Compare this action grammar with existing OpenXR action set samples already
  in the registry.
- Draft a small neutral command schema for overlays, diagnostics, locomotion,
  and tool toggles.
- Inspect whether Zinnia actions can inspire a lightweight standalone sample
  without importing the full ecosystem.
