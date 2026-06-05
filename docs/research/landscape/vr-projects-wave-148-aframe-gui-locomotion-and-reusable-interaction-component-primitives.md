# VR Projects Wave 148: A-Frame GUI, Locomotion, and Reusable Interaction Component Primitives

- Date: `2026-06-05`
- Goal: study reusable A-Frame UI, locomotion, and input components as donors
  for browser-backed VR utility menus and control panels.

## Why this wave exists

Browser VR utilities often fail at the same layer: they can enter WebXR, but
they do not have a stable menu, button, pointer, grab, or teleport vocabulary.
This wave collects component-level A-Frame patterns that can be reused before
building a full framework.

## Better workflow used in this wave

1. searched by A-Frame GUI, teleport, grab/drop, hand UI, and WebXR menu
   families;
2. deduplicated against existing A-Frame/WebXR framework and hand-input waves;
3. froze a shortlist across widget library, locomotion helper, interaction
   normalizer, world/menu factory, and menu registry references;
4. inspected local-only source clones;
5. extracted reusable methods without running, building, installing, or
   launching the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `rdub80/aframe-gui` | Declarative A-Frame widget and flex-like layout primitives |
| `fernandojsg/aframe-teleport-controls` | Compact teleport ray and landing-validation helper |
| `wmurphyrd/aframe-super-hands-component` | Semantic grab/drop/stretch/click interaction events |
| `Minty-Crisp/AUXL` | Broad A-Frame menu/world construction kit |
| `SvetimFM/aframe-webxr-ui-toolkit` | Lifecycle-managed menu registry and hand pressables |

## Deep-pass notes by project

## `rdub80/aframe-gui`

- GitHub:
  [rdub80/aframe-gui](https://github.com/rdub80/aframe-gui)
- What it is:
  an A-Frame GUI component set with panels, buttons, toggles, sliders, input,
  loaders, progress bars, rounded/beveled geometry, and Troika text.
- Interesting idea:
  represent common VR widgets as declarative A-Frame components with shared
  style fields and hover/focus/active state.
- Code-level notes:
  `src/index.js` registers `gui-item`, `bevelbox`, `gui-interactable`,
  `gui-flex-container`, `gui-label`, `gui-button`, icon buttons, toggles,
  radio controls, loaders, progress bars, sliders, input, cursor, rounded
  helpers, and reset-cursor. `src/components/button.js` exposes schema fields
  for event name, value, font, colors, border, focus, hover, active, toggle,
  and toggle state, then builds planes/boxes/bevel boxes plus Troika text.
  `src/components/flex-container.js` lays out children from `gui-item`
  dimensions and margins using `flexDirection`, `justifyContent`,
  `alignItems`, padding, panel color, rounded settings, and global styles.
- Architecture pattern:
  declarative widget components plus a layout container and shared interaction
  component.
- Reusable method:
  expose a small VR widget inventory as A-Frame schemas rather than as
  imperative scene code.
- Code donor value:
  high for widget schema shape, text integration, hover/focus state, and simple
  layout panels.
- Product reference value:
  high for quick WebXR settings panels and in-headset control surfaces.
- Constraints and caveats:
  callback binding still leans on global `window` functions and some code uses
  older A-Frame-era patterns.
- What to inspect next:
  compare with `aframe-webxr-ui-toolkit` to decide whether future utilities
  should favor component schemas or menu classes.

## `fernandojsg/aframe-teleport-controls`

- GitHub:
  [fernandojsg/aframe-teleport-controls](https://github.com/fernandojsg/aframe-teleport-controls)
- What it is:
  an A-Frame teleport controls component supporting parabolic and line rays.
- Interesting idea:
  treat locomotion as a self-contained component with configurable start/end
  events, visual ray state, collision validation, and rig movement.
- Code-level notes:
  `index.js` defines `teleport-controls` schema fields for ray type,
  trigger button or custom start/end events, collision entities, hit entity,
  camera rig, origin, curve colors, opacity, line width, curve point count,
  curve speed, landing normal, maximum landing angle, and incremental drawing.
  The `tick` path throttles ray updates, decomposes controller matrices,
  computes direction, casts parabolic or straight segments, and switches visual
  hit/miss state. `lib/ParabolicCurve.js` implements the projectile path and
  `lib/RayCurve.js` builds dynamic geometry for curved or straight rays.
- Architecture pattern:
  input event gate plus visual ray plus landing validator plus rig reposition.
- Reusable method:
  use custom locomotion start/end events so teleport UX can be driven by
  controllers, hands, keyboard, or future menu actions.
- Code donor value:
  high for minimal locomotion and landing validation.
- Product reference value:
  medium-high for utility scenes that need safe navigation without a full game
  locomotion stack.
- Constraints and caveats:
  narrow scope by design; it does not solve broader comfort, snap-turn, or
  accessibility policy.
- What to inspect next:
  compare with WebXR framework teleport implementations from Wave 147.

## `wmurphyrd/aframe-super-hands-component`

- GitHub:
  [wmurphyrd/aframe-super-hands-component](https://github.com/wmurphyrd/aframe-super-hands-component)
- What it is:
  an A-Frame interaction system and reaction component set for hover, grab,
  stretch, drag/drop, draggable/droppable, and clickable behavior.
- Interesting idea:
  normalize many raw input sources into semantic interaction events that scene
  objects can accept or reject.
- Code-level notes:
  `index.js` registers a system plus reaction components such as `hoverable`,
  `grabbable`, `stretchable`, `drag-droppable`, `draggable`, `droppable`, and
  `clickable`. The main schema maps controller, hand, mouse, and touch button
  events into grab, stretch, drag, drop, and click start/end arrays. Runtime
  state tracks hovered entities, ordered intersections, active gesture state,
  cancelable events, global event handlers, and promotion of hovered elements
  after grab/drop transitions.
- Architecture pattern:
  input-source normalization plus cancelable semantic events plus opt-in
  reaction components.
- Reusable method:
  define interaction as `hover-start`, `grab-start`, `stretch-start`,
  `drag-start`, `dragover-start`, and `drag-drop` events instead of coupling
  app code to device-specific button names.
- Code donor value:
  high for event vocabulary and object reaction boundaries.
- Product reference value:
  high for utility panels that need direct manipulation, object pickup, or
  drag/drop without rewriting per-controller logic.
- Constraints and caveats:
  a semantic event layer can become magical if the accept/reject flow is not
  documented clearly for future contributors.
- What to inspect next:
  compare with WebXR hand pinch/ray approaches and A-Frame GUI button focus
  patterns.

## `Minty-Crisp/AUXL`

- GitHub:
  [Minty-Crisp/AUXL](https://github.com/Minty-Crisp/AUXL)
- What it is:
  a broad A-Frame world and interaction framework with systems for menus,
  movement, controls, inventory, physics, weather, games, and external loading.
- Interesting idea:
  use reusable object cores, layers, and menu factories as a construction kit
  for spatial apps rather than authoring every entity directly.
- Code-level notes:
  `src/index.js` imports the central `system/auxl.js` plus controls, movement,
  run, misc, material, menu, door, inventory, physics, weather, games,
  external, load, and CSS modules. `src/system/auxl.js` tracks profile, world,
  scene, libraries, worlds, dynamic JavaScript maps, HTML overlay references,
  controller/mobile buttons, scene loading throttle, profile/settings, color
  schemes, and system text. `src/system/menu.js` exposes factories including
  `Menu`, `MultiMenu`, `MegaMenu`, `HoverMenu`, `ComboLock`, and `ScrollMenu`.
  Menus build prompts and option cores into layers, support vertical,
  horizontal, loop, circle, and path-based layouts, and register scene tracker
  state.
- Architecture pattern:
  world system plus object core/layer factories plus menu factories.
- Reusable method:
  build utility menus from data and factory objects so world state, menu
  options, click actions, and scene transitions stay inspectable.
- Code donor value:
  medium-high for menu factories, scene tracking, and construction-kit
  boundaries.
- Product reference value:
  high for larger browser utility shells that need more than one panel.
- Constraints and caveats:
  the framework is broad and global/system-heavy; future reuse should extract
  small menu/data patterns rather than import the whole architecture.
- What to inspect next:
  compare AUXL menu factories with smaller lifecycle-managed menu registries.

## `SvetimFM/aframe-webxr-ui-toolkit`

- GitHub:
  [SvetimFM/aframe-webxr-ui-toolkit](https://github.com/SvetimFM/aframe-webxr-ui-toolkit)
- What it is:
  a compact A-Frame/WebXR UI toolkit with menu classes, a menu registry,
  button utilities, a pressable component, and interaction helpers.
- Interesting idea:
  separate menu lifecycle from individual buttons and make cleanup an explicit
  part of spatial UI.
- Code-level notes:
  `src/index.js` imports `pressable`, `button`, and `scene-state`, then exports
  `BaseMenu`, `MenuRegistry`, `UIElements`, `Geometry`, and `Interaction`.
  `src/utils/base-menu.js` tracks an id, container, elements, event handlers,
  `init`, `render`, and `cleanup`, plus helpers for titles, subtitles,
  dividers, buttons, and text input placeholders. `src/utils/menu-registry.js`
  tracks registered menus, active menu, and container, and hides/cleans the
  active menu before showing another. `src/components/pressable.js` detects
  finger presses from `hand-tracking-controls` by bounding-box checks and
  press/hover thresholds. `src/utils/interaction.js` includes hand/controller
  discovery, pinch position, pinch state, debounce/throttle, ray intersection,
  and gaze checks.
- Architecture pattern:
  lifecycle-managed menu registry plus hand-tracking press surfaces.
- Reusable method:
  keep menu cleanup, event handler tracking, and active-menu switching as
  first-class runtime responsibilities.
- Code donor value:
  high for small UI lifecycle design and hand pressables.
- Product reference value:
  high for simple browser VR utilities with one active settings/help menu.
- Constraints and caveats:
  smaller project with narrower coverage than full GUI frameworks.
- What to inspect next:
  combine with `aframe-gui` widget breadth and `super-hands` semantic events.

## Cross-project synthesis

The useful split is:

- `aframe-gui` gives widget breadth and declarative styling;
- `aframe-teleport-controls` gives locomotion as a small replaceable
  component;
- `super-hands` gives semantic interaction events;
- `AUXL` gives a broad world/menu factory system;
- `aframe-webxr-ui-toolkit` gives lifecycle-managed menus and hand pressables.

For `VR-apps-lab`, the best reusable pattern is not to choose one full
framework. The stronger direction is a small browser utility shell composed
from:

- declarative widget schemas;
- semantic interaction events;
- explicit menu lifecycle cleanup;
- optional teleport/ray helpers;
- hand pressables only when controllerless use matters.

## Methods extracted

- Declarative A-Frame widget inventory with flex-like layout and focus state.
- Event-start/end teleport ray with landing validation.
- Semantic interaction grammar for hover, grab, stretch, drag, drop, and click.
- Lifecycle-managed WebXR menu registry with hand-tracking pressables.

## New gaps opened

- Compare A-Frame menu strategies against Three/Babylon/PlayCanvas UI
  strategies from Wave 147.
- Build a small matrix of controller ray, hand pinch, finger press, and
  mouse/touch fallback behaviors.
- Decide which menu lifecycle convention should become the default for future
  browser utility examples.
