# VR Projects Wave 147: WebXR Runtime Frameworks, Session/Input Feature Managers, and Testable Spatial UI Substrates

- Date: `2026-06-05`
- Goal: study major WebXR framework foundations as architecture references for
  browser-backed VR utility shells.

## Why this wave exists

Single-purpose WebXR samples are useful, but reusable utility work eventually
needs a stable substrate: session lifecycle, feature gating, controller/hand
abstraction, UI surfaces, input actions, locomotion, layers, and test/control
tools. This wave compares four framework-level answers to that problem.

## Better workflow used in this wave

1. searched by WebXR manager, WebXR engine, hand/input abstraction, DOM overlay,
   layers, locomotion, and dev tooling families;
2. deduplicated against previous WebXR sample, A-Frame, React/Three XR, engine
   export, and browser editor waves;
3. froze a shortlist across minimal renderer, feature-manager engine,
   service-oriented engine, and ECS/dev-tooling framework references;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `mrdoob/three.js` | Minimal renderer-level WebXR manager and controller spaces |
| `BabylonJS/Babylon.js` | WebXR session manager, experience helper, and feature manager stack |
| `playcanvas/engine` | Evented XR service taxonomy and hand/input subsystem model |
| `facebook/immersive-web-sdk` | ECS/action/spatial-UI framework with runtime-first dev tooling |

## Deep-pass notes by project

## `mrdoob/three.js`

- GitHub:
  [mrdoob/three.js](https://github.com/mrdoob/three.js)
- What it is:
  a widely used JavaScript 3D engine whose WebXR layer exposes a concise
  renderer-level API for sessions, controllers, hands, and examples.
- Interesting idea:
  keep the core XR manager small and expose controller target-ray, grip, and
  hand spaces as stable scene groups.
- Code-level notes:
  `src/renderers/webxr/WebXRManager.js` tracks `XRSession`, reference space,
  foveation, WebGL binding/layers, render targets, per-eye cameras, and
  controller input sources. `getController`, `getControllerGrip`, and
  `getHand` lazily create `WebXRController` objects. Session events are
  forwarded to controller groups after updating poses. `WebXRController.js`
  separates target-ray, grip, and hand spaces, initializes hand joints on
  connect, and updates group matrices from XR frames. `VRButton.js` wraps
  support checks, optional features, session start/end, and unsupported/HTTPS
  messaging. `webxr_vr_teleport.html` demonstrates reference-space offset
  teleportation from controller ray/floor intersection.
- Architecture pattern:
  renderer-owned WebXR manager plus scene groups for each input coordinate
  space.
- Reusable method:
  expose XR input spaces as ordinary scene nodes while keeping session details
  inside the renderer.
- Code donor value:
  high for minimal session/input boundary design.
- Product reference value:
  medium-high for small browser utility prototypes.
- Caveats:
  intentionally low-level; application features are usually assembled from
  examples or external libraries.
- What to inspect next:
  pair with `greggman/webxr-video` and IWSDK to compare UI surface choices.

## `BabylonJS/Babylon.js`

- GitHub:
  [BabylonJS/Babylon.js](https://github.com/BabylonJS/Babylon.js)
- What it is:
  a full-featured web engine with a large modular WebXR stack.
- Interesting idea:
  centralize session lifecycle in a session manager, then attach optional XR
  capabilities through typed feature modules that can extend session init.
- Code-level notes:
  `webXRExperienceHelper.ts` creates a `WebXRSessionManager`, `WebXRCamera`,
  and `WebXRFeaturesManager`, enters/exits XR, extends `XRSessionInit` through
  enabled features, sets reference space, initializes render targets, and
  restores pre-XR scene state on session end. `webXRSessionManager.ts` exposes
  observables for frame, session init/end, reference-space initialization, and
  readiness, tracks current frame/timestamp, world scaling factor, render target
  providers, and `runInXRFrame`. `webXRFeaturesManager.ts` defines feature
  contracts, feature names, dependency hooks, compatibility checks, and
  session-init extensions. Feature modules include hand tracking, DOM overlay,
  layers, hit-test, anchors, planes, meshes, depth sensing, movement, and
  teleportation.
- Architecture pattern:
  session manager plus experience helper plus modular feature manager.
- Reusable method:
  treat each XR capability as a feature with compatibility, dependencies,
  attach/detach, observables, and optional session-init extension.
- Code donor value:
  high for feature manager design and session lifecycle observability.
- Product reference value:
  high for browser utility shells that need many optional XR modules.
- Caveats:
  large engine surface; borrowing requires careful downscoping.
- What to inspect next:
  extract a minimal feature-manager pattern for `VR-apps-lab` prototypes.

## `playcanvas/engine`

- GitHub:
  [playcanvas/engine](https://github.com/playcanvas/engine)
- What it is:
  a web game engine with an evented WebXR service layer.
- Interesting idea:
  make XR capabilities visible as typed services under a single manager rather
  than as ad-hoc helpers scattered across the app.
- Code-level notes:
  `src/framework/xr/xr-manager.js` exposes DOM overlay, hit-test, image
  tracking, plane detection, mesh detection, input, light estimation, views,
  anchors, graphics binding, session state, and availability/error/start/end
  events. `xr-input.js` listens to `inputsourceschange`, `select`, `squeeze`,
  and related events, maps them to `XrInputSource` objects, and re-emits typed
  events. `xr-hand.js` builds wrist/finger/joint objects from `XRHand`, updates
  joint poses every frame, calculates a hand ray from joint geometry, and
  emulates squeeze by checking closed fingers. `xr-dom-overlay.js` wraps DOM
  overlay root, support, availability, and overlay state.
- Architecture pattern:
  evented manager with explicit subsystem objects for each XR capability.
- Reusable method:
  expose optional XR modules as inspectable services with support/availability
  state and evented lifecycle.
- Code donor value:
  high for XR service taxonomy, input events, and hand ray/squeeze emulation.
- Product reference value:
  medium-high for tool shells and diagnostics.
- Caveats:
  engine-integrated APIs need adaptation for non-PlayCanvas prototypes.
- What to inspect next:
  compare hand ray and squeeze emulation with Wave 144 raw hand examples.

## `facebook/immersive-web-sdk`

- GitHub:
  [facebook/immersive-web-sdk](https://github.com/facebook/immersive-web-sdk)
- What it is:
  a Meta-backed immersive web framework built on Three.js with ECS, spatial UI,
  input systems, locomotion, layers, dev tooling, and runtime control.
- Interesting idea:
  immersive web development can be made testable and agent-controllable by
  pairing runtime state files, WebSocket relay/control, CLI/MCP surfaces, and
  browser/headset emulation.
- Code-level notes:
  `packages/xr-input/src/xr-input-manager.ts` owns `XROrigin`, controller and
  hand visual adapters, primary source selection, gamepad state, multi-pointers,
  session update flow, no-session pointer disabling, hand/controller visual
  updates, head tracking, and pointer updates. The package also includes
  stateful gamepads, ray/touch/grab pointers, animated hand/controller visuals,
  and input-profile loading. `packages/core` contains action-backed input,
  grab systems, locomotion providers, environment raycast, layers, and
  screen-space UI systems. `packages/vite-plugin-dev/src/runtime-session.ts`
  writes a normalized runtime session file with local URL, port, browser state,
  timestamps, and mutation queues. The CLI/changelog surface documents MCP-like
  tools for XR session management, device control, browser observation, scene
  hierarchy, pause/step/snapshot/diff, and controller/hand transforms.
- Architecture pattern:
  ECS/action layer plus XR input manager plus runtime-first dev-control
  surface.
- Reusable method:
  make XR prototypes observable and controllable by design: runtime session
  state, input action layer, synthetic device controls, and scene inspection.
- Code donor value:
  high for testable XR workflow, input manager boundaries, action-backed
  locomotion, and spatial UI compilation.
- Product reference value:
  high for future browser-backed authoring/diagnostic utilities.
- Caveats:
  fast-moving framework with broad scope; reuse should be conceptual unless a
  browser utility branch explicitly adopts it.
- What to inspect next:
  compare its runtime control surface with no-HMD/fake-device and WebXR test
  API references from prior waves.

## Cross-project synthesis

- Strongest code donors:
  `BabylonJS/Babylon.js`, `playcanvas/engine`, and `mrdoob/three.js`.
- Strongest product/process reference:
  `facebook/immersive-web-sdk`.
- Main reusable methods:
  renderer-owned session manager, typed feature manager, evented XR service
  taxonomy, controller target-ray/grip/hand spaces, hand squeeze emulation,
  DOM overlay state wrapper, action-backed locomotion, and runtime-first XR
  testing/control.

## Fit for `VR-apps-lab`

This wave strengthens browser-backed utility foundations. Future WebXR tools
in `VR-apps-lab` can borrow a clear substrate model: session manager, feature
registry, input/hand manager, UI/layer surface, action layer, and optional
runtime control surface for diagnostics or no-HMD workflows.
