# VR Projects Wave 231: WebXR Prototyping Runtime Micro-Frameworks and Experimental Primitives

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies WebXR runtime scaffolds and SDK-level primitives: script
lifecycle, gesture/depth/simulator modules, declarative React/Babylon scenes,
thin Three wrappers, starter caveats, single-file depth interaction demos, and
AR product UI examples.

## Why It Matters For `VR-apps-lab`

The repo now has enough raw WebXR examples that the next question is which
runtime patterns are reusable and which are merely starter demos. A future
utility should know when to adopt a framework, when to copy a micro-pattern,
and when to avoid a rough scaffold.

## Project Notes

### `google/xrblocks`

- Interesting idea:
  XR prototyping can be packaged as a script-oriented SDK with gestures,
  depth, simulator, UI blocks, AI agents, sound, video, world understanding,
  and samples under one import surface.
- Code donor value:
  `src/xrblocks.ts` shows the broad public API boundary: `Script`, `Core`,
  `Options`, `User`, XR buttons/effects, depth modules, hand/gesture
  recognizers, simulator, spatial UI layouts, sound/video, world objects, and
  agent/AI modules. Samples show AI, gesture, depth, measurement, and product
  interactions.
- Product reference value:
  strongest Wave 231 SDK donor for rapid browser/headset prototyping with
  desktop simulator and optional AI-assisted workflows.
- What to inspect next:
  compare `Script` lifecycle, dependency injection, simulator, gesture
  providers, and UI blocks in a focused SDK matrix.
- Architecture pattern:
  module-rich WebXR SDK with script lifecycle and simulator-backed prototyping.
- Caveats:
  Chrome/Android XR focus, permission-sensitive APIs, broad surface area, and
  AI/API-key boundaries.

### `w3reality/threelet`

- Interesting idea:
  a small wrapper can make Three.js/WebXR apps faster to start by owning the
  camera/scene/renderer defaults, render loop, XR buttons, and input events.
- Code donor value:
  the dist source exposes `Threelet` with optional VR/AR/XR flags, auto XR
  button setup, render-loop switching when entering XR, controller ray helpers,
  mouse/pointer/touch/XR event names, raycasting, capture, cleanup, and scene
  disposal.
- Product reference value:
  useful as a compact "thin runtime wrapper" reference for microtools that do
  not need a full SDK.
- What to inspect next:
  compare its event API against raw Three, XR Blocks, and A-Frame components.
- Architecture pattern:
  thin Three/WebXR runtime shell with input abstraction.
- Caveats:
  older/deprecated WebVR naming in docs, bundled dist inspection, and not a
  modern full-stack framework.

### `simonedevit/reactylon`

- Interesting idea:
  Babylon.js XR scenes can be managed through React components, generated
  typed props, automatic disposal, and scene injection.
- Code donor value:
  `packages/library/src/core/Scene.tsx` creates Babylon scenes, optional
  physics, default XR experience, GUI 3D manager, scene store, and reconciler
  root. `Engine.tsx` creates WebGPU/WebGL engines and supports manual render
  loop. `useModel.tsx` loads and disposes imported models.
- Product reference value:
  strong declarative framework reference for teams already building React
  surfaces and wanting XR without manual scene graph ownership everywhere.
- What to inspect next:
  compare reconciler and generated-component approach against React Three XR
  and imperative WebXR workbench shells.
- Architecture pattern:
  declarative React/Babylon scene ownership with XR hook and disposal policy.
- Caveats:
  framework commitment, generated API surface, and Babylon/React ecosystem
  coupling.

### `vishnu7560834213/threexr`

- Interesting idea:
  even rough starters can expose useful micro-recipes for VR button setup,
  controller grip setup, joystick extraction, capsule/player motion, and
  collision mesh updates.
- Code donor value:
  `vr.js` sets `renderer.xr.enabled`, appends `VRButton`, creates controller
  grips/models, reads gamepad axes/buttons, and returns a simple VR input
  object. `playerController.js` shows capsule state, keyboard/VR input merge,
  BVH collision handling, camera follow, animation switching, and cleanup.
- Product reference value:
  useful only as a caveated starter/reference for player/controller glue, not
  as a mature framework.
- What to inspect next:
  compare against better-maintained starter frameworks before using any shape.
- Architecture pattern:
  rough Three/Vite starter with controller/player helper modules.
- Caveats:
  README is minimal/garbled, console logs in hot input path, duplicated sample
  app/scaffold folders, and immature packaging.

### `ARDings/EverythingController`

- Interesting idea:
  body-as-controller interaction can be prototyped by sampling depth into a
  point cloud and using real-world body/space points as collision geometry.
- Code donor value:
  the single `evc.html` file uses XR Blocks, configures depth options, samples
  depth on a grid, reconstructs hit points along view rays, filters floor
  points, updates an instanced debug/occlusion mesh, and exposes live spatial
  panel controls for offsets, cube size, hit radius, debug, and occlusion.
- Product reference value:
  useful microdemo for depth diagnostics, calibration sliders, and
  passthrough-world collision UX.
- What to inspect next:
  compare with Quest MR depth samples and XR Blocks depth abstractions before
  any product reuse.
- Architecture pattern:
  single-file depth point-cloud collision tool with spatial settings panel.
- Caveats:
  depth-sensing hardware dependency, privacy/comfort concerns, single-file
  demo shape, and device support variability.

### `dmvrg/webxr-ar-demos`

- Interesting idea:
  product-style AR interactions can be built from small modules: hand pinch,
  UI panels, exploded views, color/size controls, tag clouds, and direct
  model manipulation.
- Code donor value:
  burger and chair demos separate XR scene setup, hand input, model/material
  modules, UI panels, and experience logic. `Burger/HandTracking.js` shows
  thumb/index joint reads, pinch state, object grabbing, UI plane hit tests,
  switch cooldowns, and two-hand open/rejoin behavior.
- Product reference value:
  strong UX reference for future AR viewer/configurator utilities and
  in-world menu panels.
- What to inspect next:
  compare hand UI modules against Wave 228 hand primitives and Wave 230 menu
  surfaces.
- Architecture pattern:
  product demo modules around hand-driven AR configuration.
- Caveats:
  demo-specific assets, Spectacles focus, no unified framework layer, and
  not a diagnostics utility by itself.

## Reusable Pattern Extraction

- Pattern candidate:
  WebXR prototyping runtime primitive stack.
- Problem solved:
  small XR tools repeat the same boilerplate: session setup, renderer/camera,
  input, hand gestures, depth, simulator, UI, model loading, sound/video, and
  cleanup.
- Reusable core:
  choose a runtime tier, expose script/component lifecycle, centralize options,
  keep session/input/depth/UI modules separate, support desktop simulator or
  fallback, make disposal explicit, and label maturity so demos do not become
  accidental frameworks.
- Source evidence:
  `google/xrblocks`, `w3reality/threelet`, `simonedevit/reactylon`,
  `vishnu7560834213/threexr`, `ARDings/EverythingController`, and
  `dmvrg/webxr-ar-demos`.
- Abstraction boundary:
  separate SDK/runtime core, application scripts/components, interaction
  primitives, simulator/fallbacks, and product-specific demo logic.
- What not to copy:
  rough starter code as a platform, one-file depth demos without permission
  review, hardcoded assets, console-heavy hot paths, and framework lock-in
  without product fit.
- Method catalog action:
  add a method entry for WebXR prototyping runtime primitive stacks.

## Follow-Up Gaps

- Build a WebXR SDK/runtime matrix across XR Blocks, threelet, Reactylon,
  React Three XR, A-Frame, Babylon, and raw Three.
- Compare depth/gesture/UI primitives across Waves 228, 230, and 231.
- Add maturity labels to future framework notes so thin starters are not
  treated as high-confidence code donors.
