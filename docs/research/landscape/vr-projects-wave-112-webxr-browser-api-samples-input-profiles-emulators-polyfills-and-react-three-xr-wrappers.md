# VR Projects Wave 112: WebXR Browser API Samples, Input Profiles, Emulators, Polyfills, and React/Three XR Wrappers

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for repositories that map
  browser-native `WebXR` session shells, controller-profile assets, emulator
  injection, polyfill lineage, and React/Three wrapper patterns.

## Why this wave exists

Browser XR is a different utility substrate from native OpenXR and SteamVR
overlays. It can ship small demos, local dashboards, WebSocket operator panels,
controller-profile visualizers, and fast prototyping surfaces without an engine
project.

This wave studies WebXR projects as reusable references for future browser
diagnostics, lightweight XR tools, and web-first interaction experiments.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by WebXR samples, input profile, emulator, polyfill, and
   React/Three wrapper families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `immersive-web/webxr-samples` | Canonical browser API exercises for sessions, reference spaces, input, anchors, hit tests, hands, teleport, and positional audio |
| `immersive-web/webxr-input-profiles` | Controller profile registry plus motion-controller asset and validation tooling |
| `meta-quest/immersive-web-emulator` | Browser-extension emulator that injects a WebXR runtime, DevUI, and synthetic environment |
| `mozilla/webxr-polyfill` | Historical WebXR/WebVR polyfill lineage with display and reality abstractions |
| `pmndrs/xr` | Modern React Three Fiber and vanilla wrapper around WebXR stores, inputs, teleport, anchors, layers, and emulation |

## Deep-pass notes by project

## `immersive-web/webxr-samples`

- GitHub:
  [immersive-web/webxr-samples](https://github.com/immersive-web/webxr-samples)
- What it is:
  a canonical collection of WebXR browser samples.
- Interesting idea:
  a small `WebXRSampleApp` shell can make session support checks, inline
  fallback, immersive requests, reference-space setup, layer creation, and
  frame-loop wiring explicit enough for many tiny XR tools.
- Code-level notes:
  `js/webxr-sample-app.js` wraps `navigator.xr.isSessionSupported`, inline
  and immersive session startup, `gl.makeXRCompatible`, projection or WebGL
  layer creation, reference-space requests, and frame scheduling.
  `js/render/scenes/scene.js` updates input sources, target-ray and grip poses,
  controller meshes, lasers, cursors, hit tests, hover/select state, and
  optional stats rendering. Samples such as `input-profiles.html` and
  `teleportation.html` demonstrate controller-profile assets and
  reference-space offset teleporting.
- Code donor value:
  high for a compact WebXR session/input/teleport baseline.
- Product reference value:
  high for browser-first diagnostics, sample apps, and small operator panels.
- Caveats:
  intentionally sample-oriented; future products should wrap the patterns in
  their own error handling, permission UX, persistence, and telemetry.
- What to inspect next:
  compare against framework wrappers before building a browser-based utility.

## `immersive-web/webxr-input-profiles`

- GitHub:
  [immersive-web/webxr-input-profiles](https://github.com/immersive-web/webxr-input-profiles)
- What it is:
  a registry, asset library, validator, viewer, and motion-controller helper
  package for WebXR input sources.
- Interesting idea:
  controller rendering becomes portable when each device family is represented
  by a profile, component layout, gamepad mapping, and glTF asset contract.
- Code-level notes:
  `packages/motion-controllers/src/motionController.js` builds a
  `MotionController` from an `XRInputSource`, selected profile, asset URL, and
  handedness layout, then updates components from `xrInputSource.gamepad`.
  `packages/registry/src/validateRegistryProfile.js` validates `xr-standard`
  inheritance, component definitions, gamepad mappings, duplicates, and axis
  ordering. The asset tutorial documents profile JSON and glTF node naming
  expectations.
- Code donor value:
  very high for controller-profile registry and validation patterns.
- Product reference value:
  high for controller visualizers, input diagnostics, and hardware capability
  panels.
- Caveats:
  WebXR-specific profile model; use as a pattern for registries even outside
  the browser.
- What to inspect next:
  compare with native runtime controller-model discovery and OpenXR interaction
  profiles.

## `meta-quest/immersive-web-emulator`

- GitHub:
  [meta-quest/immersive-web-emulator](https://github.com/meta-quest/immersive-web-emulator)
- What it is:
  a browser extension that emulates WebXR devices and environments on desktop.
- Interesting idea:
  emulator/devtools can be injected per domain at `document_start`, while the
  main page receives an installed WebXR runtime, DevUI, and synthetic
  environment module.
- Code-level notes:
  `src/index.ts` sets `window.CustomWebXRPolyfill`, creates an `XRDevice`
  based on a Quest profile, installs runtime hooks, installs DevUI, installs a
  synthetic environment module, and loads a room scene. `src/service-worker.ts`
  manages a domain-scoped content script in the main world, extension toggle
  state, unregistering, and page reloads.
- Code donor value:
  high for emulator injection boundaries and browser-devtool architecture.
- Product reference value:
  high for browser-first XR diagnostics and device simulation.
- Caveats:
  browser-extension and WebXR-device specific; feature coverage is bounded by
  emulator scope and browser support.
- What to inspect next:
  compare with IWER and browser devtools patterns when designing WebXR test
  harnesses.

## `mozilla/webxr-polyfill`

- GitHub:
  [mozilla/webxr-polyfill](https://github.com/mozilla/webxr-polyfill)
- What it is:
  a deprecated historical WebXR polyfill.
- Interesting idea:
  older WebXR work modeled displays, realities, anchors, layers, AR camera
  streams, and fallback display paths as separable abstractions before the
  modern WebXR API stabilized.
- Code-level notes:
  `polyfill/XRPolyfill.js` installs XR classes onto `window`, registers
  display and reality surfaces, and wires shared or private realities.
  `polyfill/display/FlatDisplay.js` models an AR magic-window display with
  ARKit, ARCore, WebVR, or device-orientation providers, camera/FOV handling,
  and anchor/event paths.
- Code donor value:
  low-medium as direct code, high as architecture history.
- Product reference value:
  medium for understanding browser XR fallback and abstraction evolution.
- Caveats:
  deprecated and non-standard; do not treat as a modern production dependency.
- What to inspect next:
  only revisit when documenting browser XR history or fallback abstractions.

## `pmndrs/xr`

- GitHub:
  [pmndrs/xr](https://github.com/pmndrs/xr)
- What it is:
  a modern WebXR wrapper for React Three Fiber and vanilla Three.js.
- Interesting idea:
  WebXR app state can be expressed as a store that owns session state,
  reference spaces, input-source states, detected planes/meshes, layer entries,
  DOM overlay roots, emulator hooks, and interaction events.
- Code-level notes:
  `packages/xr/src/store.ts` centralizes session, media binding, origin
  reference space, origin, DOM overlay root, visibility, frame rate, mode,
  input-source states, detected geometry, layers, and emulator state.
  `packages/xr/src/input.ts` defines typed controller, hand, pointer, gaze, and
  screen states with stable ids and select/squeeze wiring.
  `packages/xr/src/teleport.ts` turns scene objects into teleport targets and
  computes world-space pointer-up destinations.
- Code donor value:
  high for session-store, typed input, event, teleport, and emulator patterns.
- Product reference value:
  high for web-based tools that need a polished framework surface.
- Caveats:
  framework coupling matters; reuse the abstractions even when not adopting the
  package directly.
- What to inspect next:
  compare React-driven state models with native overlay state machines.

## Main takeaways from Wave 112

- Browser XR has reusable utility patterns beyond demos: session shells,
  controller-profile registries, emulator injection, and framework stores.
- WebXR samples are strongest as API anatomy references.
- Input profiles are the cleanest donor for portable controller visualization.
- Emulator/devtools projects show how to build safe, scoped runtime injection.
- Deprecated polyfills should be framed as history, not production direction.

## Reusable methods clarified by this wave

- `WebXR session shell with inline/immersive split and input-source flow`
- `WebXR input profile registry and motion-controller asset validator`
- `Domain-scoped browser WebXR emulator injection with DevUI`
- `Polyfill display/reality abstraction as historical fallback reference`
- `WebXR framework store with typed input states, teleport, and emulator hooks`

## Recommended next moves after this wave

1. Use `webxr-samples` as the compact browser API baseline.
2. Use `webxr-input-profiles` when designing controller visualization or input
   diagnostics.
3. Use `immersive-web-emulator` as the browser-emulator architecture reference.
4. Keep `pmndrs/xr` visible as the modern wrapper/store reference.
5. Keep `webxr-polyfill` in the archive as deprecated history.
