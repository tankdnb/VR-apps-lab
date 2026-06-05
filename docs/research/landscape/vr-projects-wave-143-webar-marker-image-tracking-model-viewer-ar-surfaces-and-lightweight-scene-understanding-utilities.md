# VR Projects Wave 143: WebAR Marker/Image Tracking, Model-Viewer AR Surfaces, and Lightweight Scene-Understanding Utilities

- Date: `2026-06-05`
- Goal: study browser-native AR tracking, placement, model viewing, and
  environment-awareness patterns that can be reused in mixed-reality utility
  tools.

## Why this wave exists

Mixed-reality utilities need practical placement and tracking building blocks:
image targets, marker events, face anchors, location-based objects, hit-test,
plane/anchor event flows, model placement launchers, light/depth sensing, and
debug surfaces. Browser AR projects expose these as small reusable patterns.

## Better workflow used in this wave

1. searched by WebAR marker, image target, A-Frame AR, model-viewer AR,
   hit-test, anchors, planes, light, and depth families;
2. deduplicated against prior WebXR, A-Frame, passthrough, Quest MR, and browser
   utility waves;
3. froze a shortlist across tracking library, marker/location stack, micro
   starter, A-Frame helper, production model viewer, and environment-aware AR
   renderer;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `hiukim/mind-ar-js` | Image/face tracking, compiler, A-Frame integration, and occluders |
| `AR-js-org/AR.js` | Marker, NFT, and location-based WebAR stack |
| `akbartus/Simple-AR` | Minimal WebAR starter and cross-framework reference |
| `chenzlabs/aframe-ar` | A-Frame WebXR AR helper components |
| `google/model-viewer` | Production AR model-viewer web component and fallback UX |
| `tentone/enva-xr` | Environment-aware WebXR AR renderer with hit-test/light/depth |

## Deep-pass notes by project

## `hiukim/mind-ar-js`

- GitHub:
  [hiukim/mind-ar-js](https://github.com/hiukim/mind-ar-js)
- What it is:
  a browser AR library for image target and face tracking with A-Frame and
  Three.js integrations.
- Interesting idea:
  AR tracking becomes reusable when target compilation, controller setup,
  A-Frame systems, target events, anchors, and occlusion helpers are separated.
- Code-level notes:
  image examples use `Compiler` and `OfflineCompiler` flows to create `.mind`
  target files. `image-target/aframe.js` registers anchors by target index,
  loads target dimensions, updates world matrices, and emits `targetFound`,
  `targetLost`, and `targetUpdate`. `face-target/aframe.js` registers face
  systems, anchor entities, face mesh entities, camera mirroring, landmark
  matrices, face occluders, and face target components.
- Architecture pattern:
  compiler plus tracking controller plus declarative A-Frame system/components.
- Reusable method:
  make target preparation and runtime tracking observable and event-driven.
- Code donor value:
  high for browser marker/face tracking architecture.
- Product reference value:
  high for lightweight AR placement utilities.
- Caveats:
  camera/browser performance and asset/model licensing need careful handling.
- What to inspect next:
  compare target compiler and event semantics with AR.js and model-viewer.

## `AR-js-org/AR.js`

- GitHub:
  [AR-js-org/AR.js](https://github.com/AR-js-org/AR.js)
- What it is:
  a WebAR library stack for marker, NFT image tracking, and location-based AR
  with A-Frame and Three.js adapters.
- Interesting idea:
  WebAR utility flows benefit from declarative marker/location components and
  explicit found/lost/update events.
- Code-level notes:
  Three.js entry points export marker controls, toolkit context/source, marker
  helpers, multi-marker controls, and location-only modules. A-Frame examples
  show marker events, barcode markers, NFT video targets, GPS camera/entity
  placement, simulated latitude/longitude, distance display, smoothing, and
  look-at text for location labels.
- Architecture pattern:
  toolkit source/context plus A-Frame/Three adapter components.
- Reusable method:
  treat marker/location state as events and component properties, not as hidden
  camera magic.
- Code donor value:
  medium-high for marker/location component patterns.
- Product reference value:
  high for lightweight WebAR examples.
- Caveats:
  legacy WebAR lineage and browser/device limitations are significant.
- What to inspect next:
  compare marker/NFT/location approaches with WebXR hit-test/anchor flows.

## `akbartus/Simple-AR`

- GitHub:
  [akbartus/Simple-AR](https://github.com/akbartus/Simple-AR)
- What it is:
  a small WebAR starter with A-Frame examples and alternate Three.js/Babylon.js
  examples.
- Interesting idea:
  a thin AR starter can be valuable as onboarding if it exposes camera start,
  target detection, and distance feedback in simple terms.
- Code-level notes:
  the A-Frame example wraps a small scene with camera and target setup. The
  README/API framing calls out camera start and target-distance events, while
  alternate framework folders show similar starter concepts outside A-Frame.
- Architecture pattern:
  micro-starter API plus cross-framework examples.
- Reusable method:
  small AR helpers should document one clear event contract before becoming a
  framework.
- Code donor value:
  low-medium because much of the implementation is bundled/minified.
- Product reference value:
  medium for onboarding and small proof-of-value demos.
- Caveats:
  limited source readability and older library assumptions.
- What to inspect next:
  use only as comparison against more inspectable AR component stacks.

## `chenzlabs/aframe-ar`

- GitHub:
  [chenzlabs/aframe-ar](https://github.com/chenzlabs/aframe-ar)
- What it is:
  an A-Frame component layer for browser AR, including WebXR AR and WebXR
  Viewer-era support.
- Interesting idea:
  AR can be introduced to an A-Frame scene through a small `ar` component and
  separate camera, raycaster, image, plane, and anchor helpers.
- Code-level notes:
  `ar-camera.js` disables/restores look-controls during AR and updates camera
  projection matrices from the AR source. `ar-images.js` delegates add/remove
  image targets. `ar-anchors.js` queries source anchors. `ar-planes.js`
  tracks plane/anchor add, update, and remove groups and emits corresponding
  events. Raycaster examples show a mark entity following AR ray intersections.
- Architecture pattern:
  A-Frame source abstraction plus thin feature components.
- Reusable method:
  expose AR features as small scene components that can be absent when the
  browser cannot support them.
- Code donor value:
  medium-high for A-Frame AR component boundaries.
- Product reference value:
  medium for scene-authoring ergonomics.
- Caveats:
  older WebXR AR support assumptions; verify against current browsers before
  reuse.
- What to inspect next:
  compare with `mind-ar-js` and WebXR sample feature gates.

## `google/model-viewer`

- GitHub:
  [google/model-viewer](https://github.com/google/model-viewer)
- What it is:
  a production web component for displaying 3D models on the web with AR
  launch modes and annotation/hotspot support.
- Interesting idea:
  AR model placement is a product surface problem as much as a rendering
  problem: fallback modes, default AR buttons, exit buttons, posters, hotspots,
  annotations, and platform detection matter.
- Code-level notes:
  constants detect WebXR hit-test support, iOS Quick Look candidates, Scene
  Viewer candidates, and mobile/browser quirks. `ar.ts` defines AR modes such
  as `webxr`, `scene-viewer`, `quick-look`, and `none`, with fallback handling.
  `template.ts` provides poster, AR button, exit WebXR AR button, and slotted
  UI. `annotation.ts` manages hotspot maps, surface attachment, position/normal
  updates, and hit-derived hotspot data.
- Architecture pattern:
  web component with platform fallback, AR session modes, slots, hotspots, and
  annotation surfaces.
- Reusable method:
  utility placement tools need explicit fallback and UI slot strategy, not only
  a renderer.
- Code donor value:
  high for AR launch/fallback and annotation/hotspot surface design.
- Product reference value:
  very high for public-facing AR placement UX.
- Caveats:
  large production component with broad browser/platform compatibility logic.
- What to inspect next:
  compare AR fallback logic with WebXR showcases and Quest MR samples.

## `tentone/enva-xr`

- GitHub:
  [tentone/enva-xr](https://github.com/tentone/enva-xr)
- What it is:
  an environment-aware AR renderer using WebXR.
- Interesting idea:
  scene understanding features such as hit-test, anchors, planes, light probe,
  reflection cube maps, and depth sensing can be negotiated through a focused
  renderer config.
- Code-level notes:
  `ARRendererConfig.ts` exposes hit-test, light-probe, depth-sensing,
  depth-texture, depth-canvas texture, image tracking, front-facing camera, and
  GUI overlay options. `ARRenderer.ts` validates WebXR/HTTPS, requests an
  immersive-ar session with optional anchors and plane detection, pushes
  required features for hit-test, light-estimation, and depth-sensing, creates
  hit-test sources, light probes, depth textures, depth debug canvases, and
  updates AR objects each frame before rendering.
- Architecture pattern:
  feature-negotiated AR renderer with environment data surfaces and debug
  outputs.
- Reusable method:
  scene-understanding utilities should make feature flags and debug depth/light
  surfaces first-class.
- Code donor value:
  high for WebXR AR renderer anatomy and depth/light/hit-test organization.
- Product reference value:
  medium-high for MR utility prototypes.
- Caveats:
  many APIs are browser/device dependent and may require origin/security setup.
- What to inspect next:
  compare with Quest depth/MR samples and model-viewer placement flows.

## Cross-project synthesis

- Strongest tracking donors:
  `mind-ar-js`, `AR.js`.
- Strongest production AR surface:
  `model-viewer`.
- Strongest A-Frame feature wrapper:
  `aframe-ar`.
- Strongest WebXR environment renderer:
  `enva-xr`.
- Main reusable methods:
  target compiler/event flow, marker/location components, AR fallback launch
  modes, hotspot/annotation surfaces, feature-negotiated AR renderers, and
  depth/light debug outputs.

## Fit for `VR-apps-lab`

This wave strengthens browser MR utility foundations. It is especially useful
for future object-placement helpers, target-based diagnostics, AR checklists,
spatial annotations, and WebXR scene-understanding experiments.
