# Wave 289 - WebXR Spatial UI Primitives, Mesh Text Layout, and Fullstack UI Shells

This wave studies WebXR UI projects as reusable references for canvas-backed
panels, mesh-native text/layout, A-Frame component wrappers, controller raycast
selection, and simple socket-backed WebXR UI shells.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Three.js/WebXR UI surfaces;
- canvas-to-texture panels and widgets;
- mesh-native text/block layout systems;
- A-Frame wrappers around spatial UI primitives;
- fullstack WebXR shells where UI actions cross a socket/server boundary.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `NikLever/CanvasUI` | Canvas-to-plane WebXR UI | Studied | CanvasTexture panel system with buttons, sliders, keyboard, color picker, scrolling, and controller raycasts |
| `felixmariotto/three-mesh-ui` | Mesh-native WebXR UI layout | Studied | Minimal Three.js Object3D UI system with Blocks, Text, layout, font assets, and deferred update manager |
| `Retchut/aframe-mesh-ui-components` | A-Frame wrapper for mesh UI | Studied | Componentizes `three-mesh-ui` blocks/text for declarative A-Frame scenes |
| `shiveshjadon/webxr-fullstack-boilerplate` | Socket-backed WebXR UI shell | Studied with boilerplate caveat | React/Three/WebXR starter with `three-mesh-ui`, VR controls, select states, and Socket.IO button messages |

## Code-Level Findings

### `NikLever/CanvasUI`

- Interesting idea:
  ordinary canvas drawing becomes an immersive UI surface by mapping a
  `CanvasTexture` onto a one-meter plane and translating controller ray hits
  back into canvas coordinates.
- Code donor value:
  high: `CanvasUI.js` builds offscreen canvas state, a `PlaneGeometry` mesh,
  `CanvasTexture`, `MeshBasicMaterial`, config/content objects, update flags,
  controller event listeners, raycaster intersection, UV-to-pixel mapping,
  hover/select states, scroll state, keyboard linkage, sliders, color picker,
  and texture invalidation.
- Product reference value:
  very high for quick in-headset settings panels, debug dashboards, launchers,
  and spatial forms where HTML DOM is unavailable inside immersive mode.
- What to inspect next:
  `CanvasKeyboard`, dropdown/slider/picker modules, example-specific config
  shapes, accessibility gaps, text rendering limits, and performance with large
  dynamic panels.

### `felixmariotto/three-mesh-ui`

- Interesting idea:
  spatial UI can be represented as regular Three.js `Object3D`s rather than a
  textured canvas, with nested blocks, MSDF text, layout constraints, keyboard,
  and a manual update loop.
- Code donor value:
  very high: `Block.js` composes `BoxComponent`, `InlineManager`,
  `MaterialManager`, and `MeshUIComponent`; `UpdateManager.js` defers parsing,
  layout, and inner updates until `ThreeMeshUI.update()` to avoid redundant
  layout work.
- Product reference value:
  very high for WebXR menus, settings panels, embedded tutorials, keyboard
  input, and XR-safe information surfaces.
- What to inspect next:
  Text/font loading, keyboard example, interactive button states, hidden
  overflow, raycast helper patterns, and current 7.x architecture changes.

### `Retchut/aframe-mesh-ui-components`

- Interesting idea:
  `three-mesh-ui` can be exposed as declarative A-Frame components so scene
  authors can compose blocks/text through entity attributes.
- Code donor value:
  medium/high: `mesh-block.js` registers an A-Frame component, maps schema
  attributes into `ThreeMeshUI.Block`, calls `ThreeMeshUI.update()` in `tick`,
  and recursively registers child `mesh-block`/`mesh-text` components.
- Product reference value:
  high for author-friendly spatial UI kits and teaching examples where
  declarative scene markup is preferred over imperative Three.js.
- What to inspect next:
  `mesh-container`, `mesh-text`, lifecycle cleanup, event binding, and how it
  handles nested updates or dynamic content changes.

### `shiveshjadon/webxr-fullstack-boilerplate`

- Interesting idea:
  a WebXR UI shell can combine React, Three.js, `three-mesh-ui`,
  `VRButton`, controller selection, and Socket.IO so in-headset buttons trigger
  server-visible events.
- Code donor value:
  medium: `App.js` wires renderer XR mode, room mesh, `VRControl`,
  pointer/touch/controller select state, raycast UI hover/selected states,
  `ThreeMeshUI.update()`, and a `newButton` UI that talks to a Socket.IO
  server. `server.js` is a minimal Express/static/socket listener.
- Product reference value:
  high as a small pattern for WebXR remote-control panels, collaborative
  operator surfaces, and network-backed in-headset UI.
- What to inspect next:
  button factory, socket event schema, React lifecycle cleanup, HTTPS/WebXR
  deployment, multi-user state, and CORS/header typos.

## Reusable Pattern Extraction

- Pattern candidate:
  WebXR spatial UI primitive boundary across canvas panels, mesh layout,
  declarative wrappers, controller raycasts, and socket-backed actions.
- Problem solved:
  immersive browser sessions cannot rely on ordinary DOM UI once the user is in
  XR, so tools need explicit spatial UI construction and interaction loops.
- Reusable core:
  panel mesh, canvas or mesh-text renderer, config/content schema, texture or
  geometry update flag, UV-to-widget hit testing, controller raycaster,
  hover/select state, keyboard/slider/picker widgets, layout update manager,
  A-Frame component wrapper, and optional socket/server command bridge.
- Source evidence:
  `CanvasUI`, `three-mesh-ui`, `aframe-mesh-ui-components`, and
  `webxr-fullstack-boilerplate`.
- Abstraction boundary:
  keep UI description, rendering backend, input/raycast handling, widget state,
  update cadence, and transport/server actions separate.
- What not to copy:
  global mutable select state without cleanup, hardcoded localhost sockets,
  canvas panels where true mesh text/layout is needed, or mesh UI without font
  asset/version planning.
- Method catalog action:
  add a WebXR spatial UI primitive method.

## Follow-Up Gaps

- Build a WebXR UI method matrix comparing canvas texture panels,
  mesh-native layout, A-Frame wrappers, and React/Socket shell patterns.
- Deepen `three-mesh-ui` around text layout, keyboard, current version changes,
  and memory/dispose behavior.
- Deepen `CanvasUI` around widget semantics, input text, scrolling, and mobile
  headset browser constraints.
- Compare these with earlier `aframe-gui` and `aframe-webxr-ui-toolkit` entries
  without duplicating those already-studied projects.
