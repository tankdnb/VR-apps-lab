# VR Projects Wave 207: React/Three XR Runtime, Spatial UI, and Interaction Lab Surfaces

- Date: `2026-06-06`
- Research mode: GitHub code-reading pass
- Execution rule: static source-reading only; no external project was run,
  built, installed, or launched.
- Related program docs:
  - `../program/github-research-wave-207-plan.md`
  - `../program/github-research-wave-207-backlog.md`

## Why This Wave Matters

React/Three XR projects are now mature enough to study as a runtime substrate,
not just as demos. Wave 207 pulls together the main layers:

- XR store and session/input lifecycle
- pointer events and teleport interactions
- spatial UI layout, clipping, scroll, text input, and kits
- interaction-lab shell with HUD, tuning, logs, and testable labs
- small AR/WebXR microtools that show single-purpose UX flows

For `VR-apps-lab`, this wave is important because it provides a browser-native
path for future utility surfaces without requiring every prototype to become a
Unity, Godot, or native OpenXR project.

## Project Findings

### `pmndrs/xr`

- Interesting idea:
  model WebXR as a store with session state, input-source states, layer
  entries, feature options, and React bindings rather than as scattered
  components.
- Code donor value:
  `packages/xr/src/store.ts` defines `XRState`, `XRStoreOptions`, session
  enter/offer flows, `WebXRManager` binding, frame hooks, layer entries,
  emulator injection, frame-rate/framebuffer options, and debounced input-source
  synchronization. `input.ts` classifies hands, controllers, transient
  pointers, gaze, and screen input with event buffers and stable IDs.
  `teleport.ts` marks teleport targets, filters pointer targets, computes a
  smoothed teleport ray group, and renders line progress against
  intersections. `packages/react/xr/src/xr.tsx` connects the store to
  React Three Fiber, swaps camera during sessions, calls frame hooks, and
  provides default XR elements.
- Product reference value:
  strongest current donor for browser-native XR app shells, diagnostics, and
  interaction prototypes.
- Architecture pattern:
  vanilla XR store plus React binding layer.
- Reusable method:
  keep session/input/runtime state independent from component rendering so
  tools can inspect, test, and swap UI around it.
- Constraints / caveats:
  modern dependency surface and API churn require version pinning.
- What to inspect next:
  deeper compare of controller layout, hand model, hit-test, anchors, layers,
  and pointer-events package internals.
- Why it matters for `VR-apps-lab`:
  provides a strong browser-native base for XR utilities and interaction labs.

#### Reusable Pattern Extraction

- Pattern candidate:
  `React/Three XR store runtime substrate`
- Problem solved:
  WebXR apps need one inspectable place for session, input, features, layers,
  frame hooks, and emulation instead of duplicating runtime code per component.
- Reusable core:
  create a vanilla store, bind it to the renderer's `WebXRManager`, centralize
  enter/offer/session setup, synchronize input sources into typed states, route
  per-frame updates through hooks, and expose React context only at the edge.
- Source evidence:
  `packages/xr/src/store.ts`, `packages/xr/src/input.ts`,
  `packages/xr/src/teleport.ts`, `packages/react/xr/src/xr.tsx`
- Abstraction boundary:
  store owns WebXR lifecycle and state; React components render and subscribe.
- What not to copy:
  undocumented internal APIs or version-volatile defaults without pinning and
  compatibility notes.
- Method catalog action:
  create React/Three XR store substrate method.

### `pmndrs/uikit`

- Interesting idea:
  3D UI can behave like a web layout/input system while still rendering into a
  Three.js scene.
- Code donor value:
  `flex/node.ts` wraps Yoga nodes, commits child order, updates measurements,
  handles web-like flex shrink behavior, and propagates layout signals.
  `panel/interaction` adds pointer-event properties, clipped casts, and
  ordering offsets. `scroll.ts` implements pointer-drag and wheel scroll with
  rubber-band/ancestor scroll handling. `components/input.ts` and
  `text/input/hidden-input.ts` use an offscreen DOM input/textarea as the
  actual text-entry surface while rendering text, caret, and selection in 3D.
- Product reference value:
  strongest spatial UI donor in this wave because it tackles layout, events,
  text, selection, clipping, scroll, and kits as one substrate.
- Architecture pattern:
  web-like UI layout engine adapted to 3D scene objects.
- Reusable method:
  keep layout, hit-testing, text input, and rendering as separate subsystems
  with explicit bridges.
- Constraints / caveats:
  complex dependency stack and hidden DOM input bridge need accessibility and
  headset-browser testing.
- What to inspect next:
  compare default/shadcn/horizon kits, panel instancing, font loading, and
  performance tradeoffs.
- Why it matters for `VR-apps-lab`:
  future overlay-like browser tools need reliable spatial UI, not hand-built
  meshes for every panel.

#### Reusable Pattern Extraction

- Pattern candidate:
  `Spatial UI substrate with Yoga layout and DOM text-input bridge`
- Problem solved:
  VR tools need panels, forms, scroll areas, and text input that are more
  structured than loose 3D meshes.
- Reusable core:
  use a layout engine for size/position, route pointer events with order and
  clipping, implement scroll as pointer/wheel state, render text/selection in
  3D, and delegate real text editing to an offscreen HTML input when useful.
- Source evidence:
  `flex/node.ts`, `panel/interaction/clipped-cast.ts`, `scroll.ts`,
  `components/input.ts`, `text/input/hidden-input.ts`
- Abstraction boundary:
  UI components declare properties; layout/input/render subsystems own the
  difficult mechanics.
- What not to copy:
  hidden DOM input assumptions without focus/keyboard/accessibility testing.
- Method catalog action:
  create spatial UI substrate method.

### `kewanglab/webxr-playground`

- Interesting idea:
  a WebXR project can be organized as an interaction research lab shell rather
  than a single app.
- Code donor value:
  `src/config/labs.ts` registers selection, placement, locomotion, and
  manipulation labs with tuning presets. `src/xr/core/xrStore.ts` defines
  default hand/controller pointer configs. `XRRoot.tsx` composes shared scene,
  mode-specific AR/VR scene layers, `XROrigin`, lab content, and TagAlong HUD.
  `TagAlongHUD.tsx` smoothly follows the headset in lower-left view space.
  `SelectionLab.tsx` implements tri-state ray/pinch/touch orbs with timing,
  haptic/audio hooks, and live tuning. `useManipulation.ts` manages
  acquire/manipulate/release with proximity or ray acquisition. The logger
  stores lab notes and syncs them to desktop.
- Product reference value:
  excellent match for `VR-apps-lab` because it is explicitly a shell for many
  focused experiments and live comparison.
- Architecture pattern:
  lab registry + shared XR root + per-lab behavior + HUD/logger/tuning.
- Reusable method:
  make interaction experiments first-class units with metadata, tuning, HUD
  reporting, and session notes.
- Constraints / caveats:
  it is a fast-moving research shell and includes local testing assumptions.
- What to inspect next:
  study its placement, locomotion, manipulation techniques, API logs, and
  visual capture docs more deeply.
- Why it matters for `VR-apps-lab`:
  it mirrors the repository's own "lab not one app" positioning at the app
  architecture level.

#### Reusable Pattern Extraction

- Pattern candidate:
  `WebXR interaction lab shell with live tuning and in-headset HUD`
- Problem solved:
  interaction techniques are hard to compare when each demo has its own shell,
  controls, metrics, and logging.
- Reusable core:
  register labs by mode and question, expose runtime tuning presets, share XR
  root/origin/HUD, provide per-lab metrics, support session notes, and keep
  reusable interaction primitives outside individual labs.
- Source evidence:
  `src/config/labs.ts`, `src/xr/core/XRRoot.tsx`,
  `src/xr/hud/TagAlongHUD.tsx`, `src/labs/cross-xr/SelectionLab.tsx`,
  `src/labs/cross-xr/manipulation/useManipulation.ts`,
  `src/ui/TestLoggerPanel.tsx`
- Abstraction boundary:
  shell owns session, HUD, tuning, logs, and routing; labs own one interaction
  question.
- What not to copy:
  app-specific visuals, local device-testing assumptions, or one lab's metrics
  as universal metrics.
- Method catalog action:
  create interaction lab shell method.

### `WawasCode/DefaultReactXR`

- Interesting idea:
  a minimal Vite starter combines React Three XR, pointer-events, UIKit, and an
  enter-XR button.
- Code donor value:
  `App.tsx` configures hand/controller pointer models, disables teleport
  pointers, wraps a scene in `<XR>`, uses `PointerEvents`, `Canvas events={noEvents}`,
  and shows a UIKit `Fullscreen` enter button outside immersive sessions.
  `EnterXRButton.tsx` checks `immersive-vr` and `immersive-ar` support and calls
  `store.enterXR`.
- Product reference value:
  useful starter baseline for a small browser-native XR prototype.
- Architecture pattern:
  minimal XR store + UIKit entry UI.
- Reusable method:
  keep support checks and enter buttons separate from scene content.
- Constraints / caveats:
  starter only; not enough diagnostics or production UX.
- What to inspect next:
  compare with `webxr-playground` for a richer shell.
- Why it matters for `VR-apps-lab`:
  compact baseline for future WebXR spikes.

### `randykeller11/xrTeleport`

- Interesting idea:
  implement basic React Three XR teleport and snap-rotation as tiny components.
- Code donor value:
  `TeleportTravel.js` raycasts from controller to a target group, aligns a
  teleport indicator to hit normals, and copies player position/rotation on
  select. `SnapRotation.js` reads controller gamepad axes, thresholds input,
  debounces snapping, and rotates the XR player by increments.
- Product reference value:
  simple locomotion micro-reference.
- Architecture pattern:
  locomotion as isolated scene component.
- Reusable method:
  use one component for travel targets and another for snap turning.
- Constraints / caveats:
  older `@react-three/xr` API and minimal comfort/validation.
- What to inspect next:
  compare with `pmndrs/xr` modern teleport utilities.
- Why it matters for `VR-apps-lab`:
  shows the minimal implementation baseline that richer methods improve on.

### `alxxtexxr/react-three-xr-measurement`

- Interesting idea:
  AR hit-test reticle plus select events can create a tiny distance measurement
  tool.
- Code donor value:
  `App.js` uses `ARCanvas` with required `hit-test`, updates a reticle from hit
  matrices, stores two selected points, draws a line, computes distance in
  centimeters, and places a midpoint label.
- Product reference value:
  excellent micro-utility reference: one job, immediate value.
- Architecture pattern:
  AR hit-test to measurement state.
- Reusable method:
  reticle -> point capture -> line/label overlay.
- Constraints / caveats:
  old API and no persistence/export.
- What to inspect next:
  compare with model viewer placement controls and spatial-anchor measurement
  tools.
- Why it matters for `VR-apps-lab`:
  measurement is a reusable diagnostic/creator utility pattern.

### `BOLTEVM/BoltXR`

- Interesting idea:
  a product-specific spatial UI combines WebXR scene panels, optional IWER
  emulation, and hand-tracked 2D overlay interactions.
- Code donor value:
  `WalletXR.tsx` initializes optional IWER emulation via env flags, checks AR/VR
  support, exposes a minimal overlay, and enters AR/VR through a shared store.
  `Scene.tsx` arranges dashboard, QR panel, contract clipboard, PIN pad, secure
  panel, tokens, environment selector, and swap scale in 3D. `HandTrackWallet`
  and `useHandInteractions.ts` use MediaPipe hand landmarks, smooth index-tip
  position, detect pinch distance, handle tap/drag/two-hand scale, close/dismiss
  zones, and optional haptic feedback.
- Product reference value:
  useful for hand gesture and spatial-product UI patterns, not for crypto
  product logic.
- Architecture pattern:
  product scene plus separate hand-landmark overlay interaction system.
- Reusable method:
  convert camera hand landmarks into bounded UI gestures with tap/drag/scale
  thresholds and visible hit zones.
- Constraints / caveats:
  crypto/security scope, product claims, generated-feeling UI, and non-XR 2D
  overlay assumptions require caution.
- What to inspect next:
  compare hand landmark gesture logic with WebXR hand joints and MediaPipe
  bridge waves.
- Why it matters for `VR-apps-lab`:
  it is a cautionary but useful hand-interaction reference for gesture
  thresholds and overlay widgets.

### `aazutaku/glb-ar-viewer`

- Interesting idea:
  a Next.js app lets users load or route a GLB into AR with WebXR/dom-overlay
  controls and an iOS launcher fallback.
- Code donor value:
  `PageClient.tsx` routes uploaded `.glb` object URLs or server keys into an
  AR viewer route. `ARCanvas.tsx` creates an XR store with `local`,
  `hit-test`, `dom-overlay`, optional anchors, and DOM overlay root; checks
  immersive-AR support; exposes iOS launcher fallback; toggles animation; and
  offers simple transform controls. `route.ts` streams model data from R2 with
  GLB content type and cache headers. `GLBModel.tsx` loads GLB and plays or
  stops animations through `AnimationMixer`.
- Product reference value:
  compact AR model viewer and asset-preview utility pattern.
- Architecture pattern:
  upload/key route -> model URL -> AR store with dom-overlay controls.
- Reusable method:
  keep asset loading, AR session start, fallback launcher, animation playback,
  and transform controls visibly separate.
- Constraints / caveats:
  template README, rough localization/encoding, simple controls, and no asset
  validation beyond extension check.
- What to inspect next:
  compare with `model-viewer`, WebAR marker/image tracking, and asset pipeline
  waves.
- Why it matters for `VR-apps-lab`:
  future asset preview utilities can reuse the product shape while hardening
  validation and controls.

## Cross-Project Synthesis

### Strongest reusable methods

- React/Three XR store runtime substrate.
- Spatial UI substrate with layout, pointer, scroll, text, and clipping.
- Interaction lab shell with live tuning, HUD, and session logs.
- AR hit-test measurement microtool.
- GLB AR viewer with DOM overlay controls and fallback launch path.
- Hand landmark to UI gesture overlay pipeline.

### Best product references

- `pmndrs/xr` for runtime and input architecture.
- `pmndrs/uikit` for spatial UI infrastructure.
- `webxr-playground` for lab/product framing.
- `react-three-xr-measurement` and `glb-ar-viewer` for micro-utility shape.
- `BoltXR` only as a cautious reference for gesture and product panel patterns.

### What Not To Copy

- version-volatile internals without pinning;
- hidden DOM text input assumptions without accessibility testing;
- product-specific crypto/security logic from `BoltXR`;
- old `@react-three/xr` APIs from microtools as current best practice;
- asset loading without validation, size limits, or object URL lifecycle
  review.

## Placement

- Registry section:
  `React/Three XR runtime, spatial UI, and interaction lab surfaces`
- Family section:
  `React/Three XR runtime, spatial UI, and interaction lab surfaces`
- Methods:
  React/Three XR store substrate, spatial UI substrate, interaction lab shell.
- Follow-up queue:
  React/Three XR substrate matrix across store, input source, pointer events,
  UI layout, text input, teleport, HUD, lab logging, and starter maturity.
