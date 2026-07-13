# Wave 457: A-Frame controller, menu, and remote interaction microcomponents

- Date: `2026-07-13`
- Scope: small A-Frame/WebXR interaction components for controller cursors,
  transform controls, wrist/controller menus, fallback buttons, remote-phone
  controls, and peripheral input adapters.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `fernandojsg/aframe-camera-transform-controls-component` | Studied | Two-hand camera rig transform |
| `bryik/aframe-controller-cursor-component` | Studied | Controller ray cursor event bridge |
| `kfarr/aframe-select-bar-component` | Studied | Controller-attached option/menu bar |
| `DougReeder/aframe-button-controls` | Studied | Lowest-common-denominator button fallback |
| `polats/aframe-polats-extras` | Studied | Remote phone/Daydream/WebRTC controls |
| `3DRudder/aframe-3dRudder` | Studied | Foot-controller input adapter |
| `inplayo-com/aframe-interactive-areas` | Lightly studied | Declarative interactive area sample |

## Why this wave matters

Recent waves covered larger toolkit stacks and radial menus. This wave collects
microcomponents where the reusable idea is intentionally small: one component
normalizes a controller, cursor, menu row, camera transform, or remote input
source. These are exactly the pieces a VR utility library can reuse without
adopting a whole engine framework.

## Project notes

### `fernandojsg/aframe-camera-transform-controls-component`

- Interesting idea:
  two-hand transform control for an A-Frame camera rig: one-hand drag pans the
  rig, two-hand interaction scales/rotates, and an in-world hint shows scale.
- Code donor value:
  strong donor for a "world grab/scale" controller mode with explicit
  `onStart`/`onEnd` event names and reset behavior when disabled.
- Product reference value:
  useful for inspection/review tools where users need to resize or reposition
  the world/model around themselves.
- Source evidence:
  `index.js`, `examples/basic/index.html`, `examples/scene/index.html`, and
  `tests/*`.
- Reusable core:
  camera rig id, left/right controller state, drag start points, one-hand pan,
  two-hand center/scale/rotation, scale hint, enable/reset lifecycle, and custom
  event names.
- What not to copy:
  hard-coded hand entity ids, old A-Frame assumptions, or direct world scaling
  without comfort limits.
- What to inspect next:
  rotation math, event compatibility with modern WebXR controllers, and comfort
  constraints for scale/rotate speed.

### `bryik/aframe-controller-cursor-component`

- Interesting idea:
  controller laser cursor that wraps A-Frame raycaster intersections into
  familiar mouse-style events such as hover, down, up, and click.
- Code donor value:
  useful as a tiny input adapter: raycast events become UI-neutral pointer
  events, while the component owns beam geometry and intersected element state.
- Product reference value:
  reinforces that VR utility UI should accept a generic pointer stream instead
  of binding every panel directly to controller-specific events.
- Source evidence:
  `index.js`, `docs/basic/index.html`, `docs/properties/index.html`, and
  `docs/gaze-cursor-comparison/index.html`.
- Reusable core:
  raycaster dependency, beam mesh, hover state, currently intersected entity,
  trigger-down entity tracking, click guard, and two-way event emission.
- What not to copy:
  old `CylinderBufferGeometry` naming, default far-distance assumptions, or
  visual style as a fixed UX.
- What to inspect next:
  pointer capture behavior when moving between panels, near/far tuning, and
  mapping to modern pointer-event terminology.

### `kfarr/aframe-select-bar-component`

- Interesting idea:
  controller-attached select bar built from HTML `optgroup` and `option`
  children, with horizontal option previews, group switching, icons, and
  trackpad/trigger event handling.
- Code donor value:
  good donor for a declarative menu schema where content authors define options
  in markup and the component renders spatial menu rows.
- Product reference value:
  useful for quick-action bars in VR tools: inspect, erase, save, teleport, new,
  exit, and other commands can become visible controller-local cards.
- Source evidence:
  `index.js`, `examples/basic/index.html`, `examples/basic/icon_*.png`, and
  `tests/index.test.js`.
- Reusable core:
  optgroup/option parser, visible preview window, selected index, looped index
  helper, icons/text labels, controller event binding, option/group next/prev
  events, and commit event.
- What not to copy:
  "ghetto testing" asserts in runtime source, old trackpad assumptions, fixed
  seven-option layout, or asset icons.
- What to inspect next:
  keyboard/controller fallback, dynamic option updates, accessibility labels,
  and modern thumbstick mapping.

### `DougReeder/aframe-button-controls`

- Interesting idea:
  lowest-common-denominator A-Frame button component that maps screen pointer,
  touch, mouse, WebXR select/squeeze events, and gamepads into `buttondown` and
  `buttonup`.
- Code donor value:
  strong reference for fallback-first input abstraction, especially for
  cross-device WebXR demos that should still work on mobile/desktop.
- Product reference value:
  useful for utility UI that must remain operable even when full tracked
  controller support is unavailable.
- Source evidence:
  `aframe-button-controls.js`, `README.md`, and `example.html`.
- Reusable core:
  pointer/touch/mouse fallback, `enter-vr` session listener registration,
  `selectstart/selectend`, `squeezestart/squeezeend`, synthetic gamepad record,
  permission warning, debug mode, and poll mode.
- What not to copy:
  console-heavy debug messages, iframe permission text verbatim, or legacy
  `vrdisplaypresentchange` behavior.
- What to inspect next:
  modern WebXR input-source profile mapping and how to represent multi-button
  controllers in a provider-neutral schema.

### `polats/aframe-polats-extras`

- Interesting idea:
  remote-control package that combines Daydream/mobile phone input, WebRTC or
  WebSocket broker, pair code overlay, raycaster target, orientation data, and
  debug textarea.
- Code donor value:
  useful as a remote input bridge reference: pairing, overlay setup, peer state,
  orientation/quaternion, button/touch state, and controller model state are in
  one component boundary.
- Product reference value:
  suggests a fallback controller product branch: phone-as-controller for
  headsetless demos, classrooms, kiosks, or accessibility fallbacks.
- Source evidence:
  `src/controls/vr-remote-controls.js`, `src/proxyserver/*`,
  `run-proxyserver.js`, and `src/controls/README.md`.
- Reusable core:
  pair code, broker URL, peer connection, overlay, orientation state, ray target,
  debug surface, connect event, and remote cursor state.
- What not to copy:
  public Heroku broker dependency, old Daydream assumptions, or mixed
  commented-out code without cleanup.
- What to inspect next:
  message schema, peer reconnect behavior, and privacy/consent labels for
  phone sensor streaming.

## Reusable pattern extraction

- Pattern candidate:
  `input-neutral WebXR microcomponent`.
- Problem solved:
  make one small interaction behavior reusable by translating device-specific
  controller, pointer, touch, phone, or peripheral input into stable component
  events.
- Reusable core:
  component schema, input-source adapter, state cache, event normalization,
  visual affordance, enable/pause/remove lifecycle, fallback path, debug labels,
  and command/menu payload.
- Abstraction boundary:
  device adapter owns raw events; component owns state and spatial affordance;
  app consumes normalized events and command ids.
- Method catalog action:
  create a new method for input-neutral WebXR microcomponents.

## Caveats

- Many components target older A-Frame/WebVR-era APIs and should be treated as
  patterns, not drop-in dependencies.
- Controller assumptions vary widely: trackpad, thumbstick, Daydream, GearVR,
  screen, foot controller, phone sensors, and WebXR input sources.
- The reusable value is in the adapter boundaries and event vocabulary.

