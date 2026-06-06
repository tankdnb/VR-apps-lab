# VR Projects Wave 205: A-Frame UI, Locomotion, Environment, and Physics Micro-Components

- Date: `2026-06-06`
- Research mode: GitHub code-reading pass
- Execution rule: static source-reading only; no external project was run,
  built, installed, or launched.
- Related program docs:
  - `../program/github-research-wave-205-plan.md`
  - `../program/github-research-wave-205-backlog.md`

## Why This Wave Matters

A-Frame's strongest reuse pattern is the small component: a scene-attached unit
with a schema, lifecycle, event outputs, and a narrow responsibility. Wave 205
studies component-sized solutions for locomotion, keyboards, environment
generation, physics, React bridging, daylight, and environment maps.

For `VR-apps-lab`, the lesson is not to adopt A-Frame wholesale. The valuable
part is how these repos package reusable interaction and scene behavior so it
can be dropped into many prototypes.

## Project Findings

### `c-frame/aframe-cursor-teleport`

- Interesting idea:
  cursor-driven teleport gives desktop and mobile users a navigation fallback
  even without VR controllers.
- Code donor value:
  `index.js` defines a `cursor-teleport` component with camera head/rig links,
  collision and ignore selectors, landing-angle constraints, transition speed,
  cursor style, and default ground-plane fallback. It raycasts from the camera,
  filters ignored meshes, updates a target marker, and eases rig movement.
- Product reference value:
  useful fallback interaction for browser demos where not every user has a
  headset/controller path.
- Architecture pattern:
  declarative component schema plus raycast-driven target resolver.
- Reusable method:
  provide a non-controller navigation path with explicit collision and UI
  ignore lists.
- Constraints / caveats:
  not a full controller locomotion system and uses older A-Frame patterns.
- What to inspect next:
  compare cursor fallback with modern hand/controller teleport and browser
  desktop preview controls.
- Why it matters for `VR-apps-lab`:
  foundation prototypes should remain inspectable in desktop mode.

### `supermedium/aframe-super-keyboard`

- Interesting idea:
  a keyboard texture atlas plus raycaster UV lookup can turn a 2D image into a
  VR text-entry surface.
- Code donor value:
  `index.js` defines `super-keyboard` with alignment, filters, font, hand,
  image path, raycaster object injection, colors, `maxLength`, model, and value
  options. It maps raycaster intersections to UV key positions, handles hover
  and input state, updates labels/cursor, and emits value changes.
- Product reference value:
  strong reference for "text input as a small utility surface" rather than a
  large UI framework.
- Architecture pattern:
  texture atlas -> UV hit mapping -> filtered text model -> value event.
- Reusable method:
  separate input hit-testing, key layout/filtering, display text, and output
  events.
- Constraints / caveats:
  old A-Frame/text dependencies and asset path assumptions.
- What to inspect next:
  compare with Unity, Godot, Stardust, and WebXR text-entry approaches in the
  keyboard matrix.
- Why it matters for `VR-apps-lab`:
  text entry is a repeated problem for diagnostics, overlay settings, and
  in-headset utility tools.

#### Reusable Pattern Extraction

- Pattern candidate:
  `Raycast-to-UV text-entry surface`
- Problem solved:
  VR users need a lightweight keyboard without native OS text input support.
- Reusable core:
  render a key atlas, map pointer hits into UV cells, apply key filters, update
  text/cursor state, and emit a bounded value-change event.
- Source evidence:
  `supermedium/aframe-super-keyboard/index.js`
- Abstraction boundary:
  keyboard component owns hit mapping and text model; consumers receive value
  events.
- What not to copy:
  old asset paths, global listeners without cleanup, or keyboard images as the
  only source of truth.
- Method catalog action:
  update A-Frame component primitive method rather than creating a one-off
  keyboard-only method.

### `supermedium/aframe-environment-component`

- Interesting idea:
  one declarative component can generate a usable VR scene context from a small
  preset schema.
- Code donor value:
  `index.js` builds sky, fog, lights, play area, ground, grid, and dressing
  entities, with presets and procedural terrain/lathe/extrude/mesh dressing.
- Product reference value:
  helpful for utility prototypes that need context and scale quickly without
  custom art direction.
- Architecture pattern:
  scene-context preset generator.
- Reusable method:
  define environment presets as configuration and let a component own generated
  entities.
- Constraints / caveats:
  large hardcoded mesh/preset data and older A-Frame assumptions.
- What to inspect next:
  compare with Godot/Unity environment presets and `@react-three/drei`
  staging helpers.
- Why it matters for `VR-apps-lab`:
  utilities need believable spatial context during interaction tests.

### `n5ro/aframe-physics-system`

- Interesting idea:
  physics can be exposed as an A-Frame system with replaceable local, worker,
  network, and Ammo/CANNON drivers.
- Code donor value:
  `src/system.js` chooses drivers, manages gravity, iteration, friction,
  restitution, debug, and fixed timesteps. Body components create CANNON bodies
  from A-Frame objects via `three-to-cannon`, sync static/dynamic transforms,
  and emit load/collision events. The worker driver uses snapshot buffering and
  serializes body updates/contact events across a worker boundary.
- Product reference value:
  useful for any engine-agnostic utility that needs "scene object to physics
  substrate" rather than one hardwired physics engine.
- Architecture pattern:
  scene system plus driver boundary plus body component sync.
- Reusable method:
  keep physics stepping and entity-body synchronization behind a driver
  interface, with worker/network modes isolated.
- Constraints / caveats:
  dependency age, physics-engine complexity, and worker serialization
  performance risks.
- What to inspect next:
  compare with Godot XR toolkits and Unity interaction physics hands.
- Why it matters for `VR-apps-lab`:
  future interaction labs may need physics without coupling all prototypes to
  one engine.

#### Reusable Pattern Extraction

- Pattern candidate:
  `Scene physics driver boundary with worker interpolation`
- Problem solved:
  XR scene components need physics behavior but should not own the physics
  engine or threading model.
- Reusable core:
  expose a driver contract, keep bodies as components, cap timestep, sync
  transforms in predictable directions, serialize worker snapshots, and emit
  collision/contact events.
- Source evidence:
  `src/system.js`, `src/components/body/body.js`,
  `src/drivers/worker-driver.js`
- Abstraction boundary:
  scene entities declare bodies; driver owns stepping, transport, and engine
  implementation.
- What not to copy:
  stale physics libraries, broad auto-shape assumptions, or network physics
  without ownership/latency policy.
- Method catalog action:
  create physics driver boundary method.

### `supermedium/aframe-react`

- Interesting idea:
  React components can act as a thin attribute/event diff layer over A-Frame
  entities.
- Code donor value:
  `src/index.js` defines `Entity` and `Scene` wrappers that diff attributes,
  remove missing attributes, attach/detach event maps, support primitives,
  class/id/mixin, and `data-*` forwarding.
- Product reference value:
  reference for framework-boundary adapters where declarative UI drives a
  retained 3D scene graph.
- Architecture pattern:
  React props -> A-Frame attribute/event bridge.
- Reusable method:
  keep bridge logic thin and explicit; do not hide the underlying runtime.
- Constraints / caveats:
  old React class-component approach and not a modern XR runtime.
- What to inspect next:
  compare with React Three Fiber and Godot/Unity editor wrappers.
- Why it matters for `VR-apps-lab`:
  many tools need a small adapter between UI state and scene runtime.

### `topstar-ai/aframe-blink`

- Interesting idea:
  teleport UX benefits from rotation selection, parabolic feedback, hit/miss
  colors, and explicit `teleported` events.
- Code donor value:
  `src/index.js` adapts teleport controls with parabolic root calculation,
  incremental trajectory drawing, thumbstick support, rotation quaternion
  output, target angle limits, collision selectors, and start/end/teleported
  events.
- Product reference value:
  good micro-reference for "teleport as a rich interaction" rather than just
  moving a rig.
- Architecture pattern:
  locomotion component with visual trajectory and event contract.
- Reusable method:
  publish old/new positions, hit point, and rotation so tools can log,
  validate, or replay locomotion.
- Constraints / caveats:
  WIP status and legacy controller/event assumptions.
- What to inspect next:
  compare with Godot `xr-tools2` teleport gating and fade behavior.
- Why it matters for `VR-apps-lab`:
  diagnostics and comfort tools need locomotion events, not silent movement.

### `EX3D/aframe-daylight-system`

- Interesting idea:
  time, latitude, declination, and north orientation can drive sky, fog, and
  sun position as a tiny scene component.
- Code donor value:
  the component computes sun altitude/azimuth and updates sky shader, fog, and
  sun-position values from a compact schema.
- Product reference value:
  small proof that environment state can be parameterized and exposed as a
  reusable control surface.
- Architecture pattern:
  environment state micro-component.
- Reusable method:
  expose meaningful physical-ish parameters rather than raw shader values.
- Constraints / caveats:
  rough math/comments and narrow maintenance value.
- What to inspect next:
  compare with Unity/Godot day-night systems if environment controls become a
  priority.
- Why it matters for `VR-apps-lab`:
  useful as a micro-utility pattern for controlled scene conditions.

### `msfeldstein/aframe-environment-map-component`

- Interesting idea:
  capture only environment objects into a CubeCamera/PMREM and apply the result
  as an environment map to selected scene targets.
- Code donor value:
  `index.js` hides/shows environment and non-environment objects, captures a
  cube map, generates PMREM, and assigns `envMap` to target materials.
- Product reference value:
  compact reference for "environment capture as utility component."
- Architecture pattern:
  render-helper component that temporarily changes scene visibility.
- Reusable method:
  isolate capture targets from render targets and restore visibility after
  capture.
- Constraints / caveats:
  older Three PMREM APIs and visibility side effects require careful review.
- What to inspect next:
  compare with current Three/R3F environment helpers.
- Why it matters for `VR-apps-lab`:
  environment capture is useful for asset viewers and spatial UI polish.

## Cross-Project Synthesis

### Strongest reusable methods

- Declarative VR scene component primitive with schema/events/lifecycle.
- Raycast-to-UV keyboard or menu surface.
- Teleport component that emits target, rotation, and old/new pose data.
- Scene physics driver boundary with worker/network interpolation.
- Environment preset generator for quick interaction labs.

### Best product references

- `aframe-super-keyboard` for compact VR text entry.
- `aframe-physics-system` for component-to-runtime driver boundary.
- `aframe-blink` for teleport orientation and event output.
- `aframe-environment-component` for instant scene context.

### What Not To Copy

- old A-Frame or React APIs without migration;
- giant hardcoded component state without a clear schema;
- global listeners without lifecycle cleanup;
- physics/network code without ownership, latency, and debug policy;
- hidden visibility side effects in render helpers.

## Placement

- Registry section:
  `A-Frame UI, locomotion, environment, and physics micro-components`
- Family section:
  `A-Frame UI, locomotion, environment, and physics micro-components`
- Methods:
  A-Frame component primitive and scene physics driver boundary.
- Follow-up queue:
  A-Frame component matrix across schema, input source, event outputs,
  lifecycle, assets, and maintenance risk.
