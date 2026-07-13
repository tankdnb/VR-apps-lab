# Wave 376: Tilia Spatial Buttons Highlighters and World UI State

## Theme

Prefab-level spatial UI controls and feedback state for in-world VR buttons,
menus, panels, and object affordances.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `ExtendRealityLtd/Tilia.Interactions.SpatialButtons.Unity` | Studied | Spatial click/toggle/option buttons built on spatial targets and object pointers |
| `ExtendRealityLtd/Tilia.Visuals.InteractableHighlighter.Unity` | Studied | Interactable highlight state tied to touch/grab events and validity rules |

## Dedupe Notes

Wave 373 covered pointers and spatial targets. This wave studies the next UI
layer: button state, style state, grouped options, and highlight feedback.

## Code-Level Findings

### `ExtendRealityLtd/Tilia.Interactions.SpatialButtons.Unity`

- Interesting idea: model spatial UI buttons as prefab state machines with
  enabled, hover, active, disabled, and grouped option behavior.
- Code donor value: `SpatialButtonFacade` exposes `ButtonStyle` records for
  text, font size, font color, mesh color, and appearance containers across
  enabled/disabled and active/hover states.
- Product reference value: useful for overlay settings panels, wrist menus,
  diagnostics toggles, mode selectors, calibration choices, and remote-control
  panels.
- What to inspect next: click/toggle/option prefab differences and group
  dispatcher behavior.
- Caveat: button style state should remain data-driven and visibly disabled;
  do not hide command rules inside prefab internals.

### `ExtendRealityLtd/Tilia.Visuals.InteractableHighlighter.Unity`

- Interesting idea: highlight state is a separate module connected to an
  `InteractableFacade`, material overrides, validity rules, and highlight/
  unhighlight events.
- Code donor value: `InteractableHighlighterFacade` and configurator register
  interactable events and route valid interactor touches into highlight proxy
  emitters.
- Product reference value: useful for object inspectors, selectable tools,
  snap zones, training props, and focus hints in dense VR utility scenes.
- What to inspect next: material restore behavior and how grab state suppresses
  or changes highlight.
- Caveat: highlight materials need accessibility alternatives and should not be
  the only state indicator.

## Reusable Pattern Extraction

- Pattern candidate: spatial UI state module.
- Problem solved: in-world controls need explicit visual and interaction state
  instead of ad-hoc color changes in each button script.
- Reusable core: button state, style record, text/mesh style, disabled state,
  hover state, active state, option group, spatial target bridge,
  interactable-linked highlight, validity rule, feedback event, and style
  restore path.
- Source evidence: `SpatialButtonFacade.ButtonStyle`,
  `SpatialButtonFacade` enabled/hover/active style sets, and
  `InteractableHighlighterFacade` material/validity/events.
- Abstraction boundary: command behavior is separate from visual state; pointer
  and interactable sources are adapters.
- What not to copy: opaque prefab-only state, color-only feedback, or command
  routing hidden inside style objects.
- Method catalog action: add Method 821.

## Family Placement

Creates a family for spatial UI button/highlight state. It strengthens overlay,
menu, accessibility, diagnostics, and pointer-target families.

## Follow-Up Gaps

- Compare with prior hand menu and overlay window waves.
- Draft a compact state vocabulary for `enabled`, `hovered`, `active`,
  `disabled`, `selected`, and `blocked`.
- Inspect whether UI state should emit telemetry for usability diagnostics.
