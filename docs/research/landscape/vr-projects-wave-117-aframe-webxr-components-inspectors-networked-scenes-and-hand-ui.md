# VR Projects Wave 117: A-Frame WebXR Components, Inspectors, Networked Scenes, and Hand UI

- Date: `2026-06-05`
- Goal: add a focused GitHub discovery wave for A-Frame/WebXR component
  ecosystems, visual inspectors, locomotion packs, networked scene sync,
  diagnostics components, and hand-tracking extras.

## Why this wave exists

Wave 112 covered low-level WebXR APIs, input profiles, emulators, polyfills,
and React/Three wrappers. A-Frame sits one layer above that: it makes XR scenes
and utilities composable through entities, components, systems, primitives,
schemas, and browser tooling.

This wave studies A-Frame repositories as reusable references for browser XR
utility shells, in-headset diagnostics, scene inspectors, hand/controller
experiments, and multi-user operator panels.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by A-Frame, WebXR component, inspector, networked scene,
   locomotion, hand-tracking, and in-VR diagnostics families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, product value, caveats, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `aframevr/aframe` | Canonical declarative WebXR entity-component runtime |
| `aframevr/aframe-inspector` | Visual scene graph and live component editor for A-Frame scenes |
| `c-frame/aframe-extras` | Locomotion, controls, navmesh, loader, primitive, and misc helper pack |
| `networked-aframe/networked-aframe` | Schema-driven multi-user entity sync with WebRTC/WebSocket adapter boundaries |
| `supermedium/superframe` | Broad A-Frame component library with logs, haptics, layout, state, and input helpers |
| `gftruj/aframe-hand-tracking-controls-extras` | Hand-joint helper API and pinch/drag/teleport controls for WebXR hands |

## Deep-pass notes by project

## `aframevr/aframe`

- GitHub:
  [aframevr/aframe](https://github.com/aframevr/aframe)
- What it is:
  a browser-based 3D/AR/VR framework built around declarative HTML and
  entity-component-system composition.
- Interesting idea:
  WebXR utilities can expose low-level XR behavior as declarative components:
  tracked controls, hand controls, hand-tracking grab controls, laser controls,
  raycaster, cursor, sound, layers, hit test, stats, screenshot, and XR mode UI.
- Code-level notes:
  `src/index.js` exports and registers components, systems, primitives, and
  scenes. `src/components/` contains input, hand, raycaster, cursor, sound,
  layer, AR hit-test, XR-mode UI, stats, screenshot, and debug components.
  `systems/camera.js` includes default camera behavior and spectator rendering
  after the VR render path.
- Code donor value:
  high for declarative browser XR component architecture.
- Product reference value:
  high for fast browser utilities and operator panels.
- Caveats:
  browser/WebXR limits apply; not a native overlay runtime.
- What to inspect next:
  compare A-Frame component registration with Godot scene packs and Unity
  prefab/toolkit packages.

## `aframevr/aframe-inspector`

- GitHub:
  [aframevr/aframe-inspector](https://github.com/aframevr/aframe-inspector)
- What it is:
  a visual inspector and scene editor for A-Frame scenes.
- Interesting idea:
  a VR utility runtime can embed its own scene graph, component editor, entity
  selection, history, shortcuts, camera controls, and export/copy actions as a
  devtool-like overlay.
- Code-level notes:
  `src/index.js` finds the active A-Frame scene, initializes cameras, creates
  an inspector root, wires selection, listens for entity/component events, and
  manages history. `components/components/AddComponent.js` enumerates
  `AFRAME.components` and adds components to entities. `CommonComponents.js`
  includes copy-to-clipboard and selected-entity GLB export paths.
- Code donor value:
  very high for browser scene-inspector and live-editing architecture.
- Product reference value:
  very high for diagnostics and visual authoring surfaces.
- Caveats:
  A-Frame-specific object/component model.
- What to inspect next:
  compare with in-headset debug overlays, Unity editor validation, and WebXR
  emulator/devtool patterns.

## `c-frame/aframe-extras`

- GitHub:
  [c-frame/aframe-extras](https://github.com/c-frame/aframe-extras)
- What it is:
  an A-Frame add-on pack for controls, loaders, pathfinding, primitives, and
  miscellaneous helpers.
- Interesting idea:
  locomotion should be a composable input aggregator where gamepad, keyboard,
  touch, trackpad, checkpoint, and other control sources can feed one movement
  component, optionally constrained to a navmesh.
- Code-level notes:
  `src/controls/` includes `movement-controls`, `checkpoint-controls`,
  gamepad, keyboard, touch, trackpad, and nipple controls. `src/pathfinding/`
  provides navmesh/nav-agent/system code. `src/misc/` includes checkpoint,
  grab, sphere-collider, and cube-env-map helpers. The controls README explains
  the `isVelocityActive`, `getVelocityDelta`, and `getPositionDelta` contract
  for custom controls.
- Code donor value:
  high for composable locomotion and navmesh-constrained movement.
- Product reference value:
  medium-high for browser XR movement and input abstraction.
- Caveats:
  older physics/kinematic assumptions should be reviewed before reuse.
- What to inspect next:
  compare locomotion input aggregation with Godot XR Tools and Unreal
  movement components.

## `networked-aframe/networked-aframe`

- GitHub:
  [networked-aframe/networked-aframe](https://github.com/networked-aframe/networked-aframe)
- What it is:
  a multi-user A-Frame networking library for syncing entities, components,
  voice/video, and WebRTC/WebSocket-backed scene state.
- Interesting idea:
  networked XR scene sync can be schema-driven: each entity declares what
  components replicate, while adapter classes hide whether transport is
  WebRTC, Socket.IO, or another server.
- Code-level notes:
  `src/components/networked-scene.js` defines scene configuration such as
  server URL, app, room, adapter, audio/video, and debug behavior.
  `src/adapters/AdapterFactory.js` registers adapters including WebSocket
  EasyRTC, Socket.IO, and uWS variants. `server/socketio-server.js` manages
  rooms, occupants, broadcast/send, and disconnect messages.
  `networked-hand-controls.js` propagates hand gestures, button events, and
  model state.
- Code donor value:
  very high for schema-driven sync and pluggable transport boundaries.
- Product reference value:
  high for collaborative browser utilities and multi-user operator surfaces.
- Caveats:
  browser networking and A-Frame component schemas shape the implementation.
- What to inspect next:
  compare with OSC/WebSocket bridge families and native overlay sidecars.

## `supermedium/superframe`

- GitHub:
  [supermedium/superframe](https://github.com/supermedium/superframe)
- What it is:
  a broad collection of A-Frame components and utilities.
- Interesting idea:
  a VR utility pattern library can consist of many thin components, each with
  one clear value: in-VR logs, haptics, FPS counters, camera recording,
  layouts, state, templates, audio analysis, thumb controls, and colliders.
- Code-level notes:
  `components/log/index.js` exposes an in-VR logging surface through
  `AFRAME.log` and `<a-log>` style usage with channels, filters, and maximum
  entries. `thumb-controls` normalizes thumbstick/thumbpad movement into
  directional start/end events with thresholds. Other packages cover haptics,
  state, templates, layout, and debug helpers.
- Code donor value:
  high for micro-component design and in-VR diagnostics.
- Product reference value:
  high for small browser XR helper utilities.
- Caveats:
  individual components vary in age and maintenance status.
- What to inspect next:
  identify the smallest reusable diagnostic subset: log, stats, haptics,
  input normalization, and state.

## `gftruj/aframe-hand-tracking-controls-extras`

- GitHub:
  [gftruj/aframe-hand-tracking-controls-extras](https://github.com/gftruj/aframe-hand-tracking-controls-extras)
- What it is:
  A-Frame extras for WebXR hand tracking, navigation, and simplified hand joint
  access.
- Interesting idea:
  hand tracking becomes easier to reuse when joint data is wrapped in helper
  methods and pinch gestures drive small locomotion widgets such as hand
  teleport, drag-move, drag-rotate, finger cursor, and touchy fingertips.
- Code-level notes:
  `components/src/` includes drag-move, drag-rotate, extended teleport
  controls, finger cursor, hand teleport, and touchy fingertip components. The
  code listens for pinch start/move/end and hand-tracking readiness events,
  creates rays/fade affordances, and exposes helpers such as position,
  direction, normal, quaternion, radius, and validity accessors.
- Code donor value:
  high for WebXR hand-joint helpers and pinch locomotion controls.
- Product reference value:
  high for hand-first utility UI experiments.
- Caveats:
  built around WebXR hand input and A-Frame event semantics.
- What to inspect next:
  compare with WebXR hand samples, Godot hand collision, and Unreal hand
  tracking adapters.

## Main takeaways from Wave 117

- Browser XR utility work benefits from a declarative component registry plus
  explicit systems, primitives, schemas, and inspector tooling.
- `aframe-inspector` is especially valuable because it turns scene state into a
  live debugging/editing surface.
- `networked-aframe` provides a clean schema/adapter model for networked XR
  state.
- `superframe` and hand extras show that small components can be strong donors
  even when they are not full applications.

## Reusable methods clarified by this wave

- `Declarative WebXR component registry and primitive system`
- `Embeddable WebXR scene inspector and live component editor`
- `Schema-driven networked entity sync with pluggable WebRTC/WebSocket adapters`
- `WebXR hand-joint helper API with pinch locomotion and hand UI widgets`

## Recommended next moves after this wave

1. Use A-Frame as a reference for browser utility prototypes, not as a
   replacement for native overlays.
2. Use `aframe-inspector` as the main donor for live scene inspection ideas.
3. Compare `networked-aframe` adapter architecture with existing OSC/WebSocket
   bridge methods.
4. Keep hand-tracking extras in the backlog for any future hand/wrist UI wave.
