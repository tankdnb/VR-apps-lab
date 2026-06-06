# GitHub Research Wave 231 Backlog

Date: 2026-06-06

Theme: WebXR prototyping runtime micro-frameworks, AI-assisted XR primitives,
and experimental interaction demos.

## Completed In This Wave

- Studied `google/xrblocks` as a broad WebXR SDK with script lifecycle,
  options, AI/Gemini/OpenAI agent modules, hand gesture recognition, WebXR and
  MediaPipe pose estimators, depth, simulator, UI blocks, spatial panels,
  sound/video/world modules, and many runnable samples.
- Studied `w3reality/threelet` as a compact Three.js/WebXR wrapper with
  auto-created camera/scene/renderer, optional VR/AR buttons, render-loop
  switching, input event abstraction, controller ray/drag helper, and disposal
  utilities.
- Studied `simonedevit/reactylon` as a declarative React/Babylon framework
  with custom reconciler, scene injection, generated component surface,
  `createDefaultXRExperienceAsync` hook, WebGPU/WebGL engine wrapper,
  automatic disposal, model hook, NullEngine test wrapper, and CLI ecosystem.
- Studied `vishnu7560834213/threexr` as a rough Three/Vite starter and
  scaffold with VR button setup, controller grips, joystick extraction,
  player capsule, BVH collision mesh, and cleanup caveats.
- Studied `ARDings/EverythingController` as a single-file XR Blocks demo that
  samples depth into a point cloud, uses it as body collision geometry, exposes
  spatial settings panel controls, and toggles debug/occlusion rendering.
- Studied `dmvrg/webxr-ar-demos` as a product-style WebXR AR demo set with
  Spectacles focus, hand pinch, UI planes, color/size controls, burger exploded
  view, switch toggles, product tag clouds, and simple game interactions.
- Added a reusable method entry for WebXR prototyping runtime primitive stacks.

## Follow-Up Queue

1. Compare SDK/runtime stacks across `XR Blocks`, `threelet`, `Reactylon`,
   `pmndrs/xr`, A-Frame, Babylon, and raw Three examples.
2. Build a WebXR interaction primitive matrix for gestures, depth, simulator,
   UI panels, controller rays, model viewers, sound, video, and world
   understanding.
3. Compare declarative scene/reconciler approaches against imperative
   workbench shells from Wave 230.
4. Extract safety and maturity labels so rough starters do not get promoted to
   core donor status.
5. Revisit depth-sensing body-collision demos only after privacy, comfort, and
   hardware support caveats are captured.

## Do Not Spend Time On Yet

- Do not run samples, install package dependencies, or open XR demos.
- Do not treat `threexr` as a mature framework.
- Do not copy one-file depth or product demos without feature, permission, and
  device-support review.
