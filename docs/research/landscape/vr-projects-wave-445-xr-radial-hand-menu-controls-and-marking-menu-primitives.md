# Wave 445: XR radial hand menu controls and marking-menu primitives

## Theme

This wave studies radial, hand-attached, and gesture-oriented menu primitives.
The reusable value is in activation pose, angular selection, hover/selection
feedback, submenu boundaries, and the fallback path between mouse/gamepad,
controller ray, and tracked hands.

## Shortlist

| Project | Status | Family placement |
|---|---|---|
| `connorpugh/XRRadialMarkingMenu` | New study | XR radial/marking menus |
| `jesuisse/godot-radial-menu-control` | New study | Engine-neutral radial menu primitive |
| `Oyshoboy/RadialMenuVR` | Deepened existing node | Unity radial menu primitive |
| `NovaUI-Unity/XRHandMenuSample` | Deepened existing node | Hand-attached menu panels |

## Project notes

### `connorpugh/XRRadialMarkingMenu`

- Interesting idea:
  a Unity/XR radial marking-menu package that frames command selection as a
  fast spatial gesture rather than a flat panel click.
- Code donor value:
  useful as a conceptual donor for angular command sectors, menu activation,
  selection confirmation, and controller-friendly command vocabulary.
- Product reference value:
  strong for overlay/window tools that need compact command palettes without
  blocking the user with large panels.
- Reusable core:
  activation input, center point, angle-to-item mapping, selection preview,
  commit/cancel path, and optional nested command levels.
- Source evidence:
  repository source and naming center on XR radial marking-menu behavior rather
  than a generic 2D menu.
- What not to copy:
  scene-specific menu art or Unity-only assumptions before separating command
  schema from rendering.
- Method catalog action:
  contributes to `XR radial hand menu primitive`.
- What to inspect next:
  compare with wrist menus and keyboard/text-entry waves for command density
  limits.

### `jesuisse/godot-radial-menu-control`

- Interesting idea:
  a Godot 4 `Control`-based radial/pie menu with submenus, exported geometry
  properties, theme support, gamepad/mouse input, hover/selection signals, and
  explicit usability caveats.
- Code donor value:
  high for engine-neutral menu API shape: `set_items`, `open_menu`, item IDs,
  submenu-as-action, geometry/radius/arc controls, signals, and optional plugin
  packaging.
- Product reference value:
  excellent reference for documenting radial-menu constraints honestly,
  especially item-count limits, submenu stack warnings, and animation opt-out.
- Architecture pattern:
  reusable control node with public geometry properties, theme resources,
  signal output, and optional plugin/scene install path.
- Source evidence:
  README documents `RadialMenu.gd`, `drawing_library.gd`, `RadialMenu.tscn`,
  `set_items`, `open_menu`, `item_selected`, `item_hovered`, `cancelled`,
  `menu_opened`, `menu_closed`, gamepad setup, arc/radius/width properties, and
  the recommendation to avoid too many items.
- Reusable core:
  item registry, radius/arc/deadzone settings, hover state, selected item,
  accept/cancel signals, submenu boundary, keyboard/gamepad/mouse mapping, and
  theme hooks.
- What not to copy:
  desktop mouse assumptions directly into XR; use the API shape, not the exact
  input model.
- Method catalog action:
  contributes to `XR radial hand menu primitive`.
- What to inspect next:
  map Godot's `Control` API shape to Unity overlay/panel command schemas.

### `Oyshoboy/RadialMenuVR`

- Interesting idea:
  a compact Unity VR radial-menu sample that keeps the implementation small
  enough to use as a teaching reference.
- Code donor value:
  moderate for quick angle-to-button mapping and minimal UI wiring.
- Product reference value:
  useful as a micro-utility baseline when a full menu framework would be too
  heavy.
- Reusable core:
  radial item layout, selection angle, hover indication, and controller-driven
  confirm path.
- Source evidence:
  source includes `Scripts/RadialMenu`-style Unity scripts focused on VR menu
  item selection.
- What not to copy:
  prototype visual styling and any hard-coded item count.
- Method catalog action:
  strengthens existing radial menu notes.
- What to inspect next:
  compare against Godot's richer public API and Nova's hand-panel activation.

### `NovaUI-Unity/XRHandMenuSample`

- Interesting idea:
  a hand menu sample where palm orientation opens a launcher, which then routes
  to panel UIs such as settings, apps, contacts, and notifications.
- Code donor value:
  high for hand-menu activation logic, panel handoff, push-button gesture
  handling, slider/toggle interaction, and hand-relative repositioning.
- Product reference value:
  strong for wrist/palm overlay tools and VR utility dashboards.
- Architecture pattern:
  `PanelUIController` owns activation and panel state; `HandLauncher` owns the
  launcher list; each panel owns a focused feature; `PushButton` and panel
  scripts own gestures and visuals.
- Source evidence:
  README names `PanelUIController`, `HandLauncher`, `SettingsPanel`,
  `AppsPanel`, `ContactsPanel`, and `NotificationPanel`; source shows palm
  angle threshold logic, tracked-hand checks, panel activation state, and
  gesture handlers for press/drag/release/cancel.
- Reusable core:
  hand visibility gate, palm/head angle threshold, launcher active state,
  selected panel state, hand-relative placement, panel-close callback, and
  physical button/slider affordances.
- What not to copy:
  Nova asset dependency or Meta/OVR hand assumptions unless the target tool
  intentionally uses that stack.
- Method catalog action:
  contributes to `XR radial hand menu primitive`.
- What to inspect next:
  extract a generic wrist/hand menu activation policy with controller fallback.

## Synthesis

Good VR menus are less about pretty panels and more about activation policy,
selection grammar, and escape routes. The best reusable menu primitive should
make these decisions explicit:

- where the menu appears
- what pose or button opens it
- how item angles are mapped
- how hover differs from commit
- how cancel/back/submenu behaves
- how many items remain usable
- what fallback exists for controller or gamepad users

## Follow-up backlog

- Create a command-schema-first radial menu note decoupled from Unity/Godot.
- Compare wrist menu, radial menu, and floating overlay panel tradeoffs.
- Add item-count and animation/accessibility caveats to future UI methods.
- Study controller fallback for hand-first menu designs.
