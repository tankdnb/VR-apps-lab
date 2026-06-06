# VR Projects Wave 204: WebXR Runtime Dev Scaffolding, Polyfills, Emulators, and Input Profile Loaders

- Date: `2026-06-06`
- Research mode: GitHub code-reading pass
- Execution rule: static source-reading only; no external project was run,
  built, installed, or launched.
- Related program docs:
  - `../program/github-research-wave-204-plan.md`
  - `../program/github-research-wave-204-backlog.md`

## Why This Wave Matters

This wave studies projects that make WebXR development possible when the real
runtime is missing, incomplete, browser-specific, or too inconvenient for quick
iteration. The reusable value is not "polyfill everything forever"; it is the
set of boundaries these projects reveal:

- device abstraction behind `navigator.xr`
- emulator UI separated from injected runtime
- page-level event bridge for poses, buttons, device selection, and stereo mode
- input-profile JSON plus glTF visual-response mapping
- standalone browser shell security boundaries
- small API-drift shims for vendor browsers

These are useful for `VR-apps-lab` because many future VR utilities will need a
testable runtime boundary and a clear distinction between development emulation
and production headset behavior.

## Project Findings

### `immersive-web/webxr-polyfill`

- Interesting idea:
  expose WebXR through a fallback `navigator.xr` implementation only when the
  browser lacks native support.
- Code donor value:
  `WebXRPolyfill.js` installs API classes, patches `navigator.xr`, patches
  WebGL `makeXRCompatible`, and funnels runtime behavior into a device promise.
  `XRDevice.js` is the strongest boundary: sessions, animation frames,
  projection matrices, base poses, viewports, input sources, input poses, stage
  bounds, and feature/reference-space support sit behind one abstract device
  interface.
- Product reference value:
  useful as a minimal mental model for how a browser-runtime fallback should be
  layered even if the exact WebVR/Cardboard assumptions are stale.
- Architecture pattern:
  global API patch gate plus abstract device backend.
- Reusable method:
  keep polyfill injection separate from device implementation, and treat the
  device backend as the replaceable seam.
- Constraints / caveats:
  old API lineage, WebVR/Cardboard compatibility assumptions, and stale module
  support mean it should be copied conceptually, not literally.
- What to inspect next:
  compare the `XRDevice` surface against IWER and modern WebXR emulator shells.
- Why it matters for `VR-apps-lab`:
  future browser-native prototypes need a clean runtime adapter boundary rather
  than headset-specific code in scene components.

#### Reusable Pattern Extraction

- Pattern candidate:
  `WebXR device abstraction behind a guarded navigator.xr patch`
- Problem solved:
  apps can exercise WebXR-like flows while runtime support is missing or
  incomplete.
- Reusable core:
  install global API only when safe, centralize session/frame/pose/input
  behavior behind a device object, and keep graphics compatibility patches
  narrow.
- Source evidence:
  `src/WebXRPolyfill.js`, `src/devices/XRDevice.js`
- Abstraction boundary:
  app code sees `navigator.xr`; platform-specific behavior lives in the device
  implementation.
- What not to copy:
  stale Cardboard/WebVR assumptions or outdated spec compatibility paths.
- Method catalog action:
  update methods catalog with WebXR runtime device abstraction.

### `MozillaReality/WebXR-emulator-extension`

- Interesting idea:
  a browser extension injects a polyfilled WebXR runtime into pages and controls
  headset/controller state from a devtools panel.
- Code donor value:
  `content-script.js` creates the page bridge through custom events such as
  device selection, pose, input pose, button state, stereo effect, and exit
  immersive. `panel.js` maintains Three.js gizmos for headset/controllers and
  sends pose/button/device updates back to the page.
- Product reference value:
  strong developer-tool UX reference: browser page, extension content script,
  and control panel are clearly separated.
- Architecture pattern:
  devtools panel to content-script to injected-runtime bridge.
- Reusable method:
  control an emulated runtime through explicit event messages instead of
  coupling UI widgets directly to app code.
- Constraints / caveats:
  based on an older 2019 WebXR draft and limited input controls.
- What to inspect next:
  map its event bridge against IWER's newer emulation modules.
- Why it matters for `VR-apps-lab`:
  it suggests a test harness for VR utility UX without requiring headset access
  during every design iteration.

#### Reusable Pattern Extraction

- Pattern candidate:
  `Devtools-driven WebXR emulator bridge`
- Problem solved:
  developers need to edit device pose and input state while a WebXR app runs in
  a normal browser tab.
- Reusable core:
  inject runtime early, keep a side panel as the operator UI, pass bounded pose
  and button events through a content-script bridge, and mirror session state
  back to the panel.
- Source evidence:
  `src/extension/content-script.js`, `src/app/panel.js`
- Abstraction boundary:
  page runtime receives synthetic XR events; panel owns controls and visual
  manipulators.
- What not to copy:
  stale spec names, extension-only assumptions, or incomplete input-button
  coverage.
- Method catalog action:
  create emulator-shell method entry.

### `De-Panther/webxr-input-profiles-loader`

- Interesting idea:
  load WebXR input-profile metadata and glTF controller models into Unity with
  visual-response animation.
- Code donor value:
  `InputProfileLoader.cs` fetches `profilesList.json`, resolves aliases,
  downloads profile JSON, caches layout routings, and maps handedness plus
  component responses. `InputProfileModel.cs` loads the profile glTF, finds
  nodes referenced by visual responses, and interpolates transforms for
  button/axis states.
- Product reference value:
  shows how to make runtime controller model display independent of one native
  engine input stack.
- Architecture pattern:
  profile list -> profile JSON -> handedness layout routing -> glTF visual
  response nodes.
- Reusable method:
  keep controller model rendering driven by standardized profile metadata.
- Constraints / caveats:
  CDN dependency, Unity package constraints, and asset/shader packaging should
  be reviewed before reuse.
- What to inspect next:
  compare with `@pmndrs/xr` controller layout and visual-response helpers.
- Why it matters for `VR-apps-lab`:
  input-profile loading is a reusable asset pipeline for diagnostics,
  tutorials, controller visualizers, and emulator UIs.

#### Reusable Pattern Extraction

- Pattern candidate:
  `Input profile to engine model visual-response loader`
- Problem solved:
  controller visuals and input affordances should match runtime-reported
  profiles without hand-coding every device model.
- Reusable core:
  resolve input-source profile names, fetch profile metadata, cache layout
  routing, load glTF assets, bind named nodes to visual responses, and animate
  them from button/axis state.
- Source evidence:
  `InputProfileLoader.cs`, `InputProfileModel.cs`
- Abstraction boundary:
  runtime input profiles provide metadata; engine code only handles fetch,
  cache, render, and animation.
- What not to copy:
  hardcoded CDN assumptions or Unity-only asset management.
- Method catalog action:
  create input-profile loader method.

### `michelesandroni/xrview`

- Interesting idea:
  a standalone Tauri desktop browser shell injects an IWER WebXR runtime into
  every frame and keeps toolbar capabilities separated from the web content
  browser view.
- Code donor value:
  `xr-inject.ts` installs `CustomWebXRPolyfill`, creates an `XRDevice`, loads
  the synthetic environment, DevUI, and Meta Quest 3 profile. `lib.rs`
  normalizes URLs, blocks non-http(s), creates local toolbar and external
  browser webviews, injects the init script into all frames, resizes child
  views, and keeps the browser webview out of Tauri capabilities.
- Product reference value:
  stronger than a browser extension when a team wants a dedicated WebXR lab
  shell with controlled navigation and visible dev controls.
- Architecture pattern:
  trust-separated multi-webview shell plus all-frame runtime injection.
- Reusable method:
  separate the privileged shell/toolbar from untrusted web content and inject
  runtime glue at the browser boundary.
- Constraints / caveats:
  Tauri multi-webview behavior and capability isolation are security-critical.
- What to inspect next:
  compare browser-shell trust model with overlay browser surfaces and WebView
  utilities.
- Why it matters for `VR-apps-lab`:
  suggests a future "WebXR doctor/playground" app shape that can load external
  demos without giving them shell privileges.

#### Reusable Pattern Extraction

- Pattern candidate:
  `Standalone WebXR emulator shell with capability-isolated web content`
- Problem solved:
  developers need a controlled desktop shell for WebXR pages without trusting
  every loaded site with native app capabilities.
- Reusable core:
  create a privileged local toolbar, isolate external browser content, inject a
  runtime script into frames, validate navigation URLs, and expose emulator
  controls through the shell.
- Source evidence:
  `src/xr-inject.ts`, `src-tauri/src/lib.rs`
- Abstraction boundary:
  shell owns native capabilities and navigation; page receives WebXR runtime
  API only.
- What not to copy:
  broad capability exposure, unvalidated schemes, or hidden native bridges in
  the external browser view.
- Method catalog action:
  merge with emulator-shell method.

### `holokit/holokit-webxr`

- Interesting idea:
  a device-specific WebXR polyfill adapts HoloKit-style AR viewer behavior into
  WebXR `XRDevice` semantics.
- Code donor value:
  `HoloKitXRDevice.ts` extends the polyfill device boundary, supports inline
  and immersive AR sessions, handles local/viewer reference spaces, moves the
  canvas into a presentation window, and calculates multiview projection and
  viewport data.
- Product reference value:
  useful for understanding how a specialized viewer can expose a WebXR-shaped
  runtime without becoming a general browser.
- Architecture pattern:
  viewer-specific `XRDevice` subclass.
- Reusable method:
  hide viewer output quirks behind session/view/projection methods.
- Constraints / caveats:
  HoloKit-specific assumptions and rough code paths reduce direct donor value.
- What to inspect next:
  compare with modern handheld AR `dom-overlay`, anchors, camera, and depth
  handling in supported browsers.
- Why it matters for `VR-apps-lab`:
  helpful as a warning and reference for device adapters: the boundary is good,
  but device-specific behavior must stay quarantined.

### `realitydeslab/holoweb-webxr-polyfills`

- Interesting idea:
  broad HoloKit-style WebXR module surface including anchors, planes, meshes,
  hands, camera, depth, and layers.
- Code donor value:
  mostly comparison value: its structure mirrors the HoloKit polyfill family
  and exposes the same kind of device-specific type surface.
- Product reference value:
  variant evidence that viewer-specific WebXR polyfills tend to become broad
  compatibility surfaces quickly.
- Architecture pattern:
  fork/variant of HoloKit-style WebXR device and API classes.
- Reusable method:
  keep as overlap evidence, not as a separate method source.
- Constraints / caveats:
  retained as variant only unless a future diff reveals unique module behavior.
- What to inspect next:
  compare deltas against `holokit-webxr` only if HoloKit-specific research
  becomes a priority.
- Why it matters for `VR-apps-lab`:
  reinforces dedupe practice: not every fork-shaped repo deserves a separate
  method.

### `mvilledieu/magicleap-helio-webxr-polyfill`

- Interesting idea:
  a compact shim patches Magic Leap Helio's older WebXR API shape into a more
  expected app-facing API.
- Code donor value:
  `HelioWebXRPolyfill.js` checks Helio user agent and `navigator.xr`, maps
  `supportsSessionMode` to `supportsSession`, forces immersive AR session
  request behavior, wraps session request, patches frame pose methods, input
  sources, render state, and reference-space calls.
- Product reference value:
  good micro-reference for runtime API drift patches when a browser has partial
  or renamed support.
- Architecture pattern:
  vendor-browser API shim.
- Reusable method:
  isolate API drift in a small compatibility layer and document version
  assumptions clearly.
- Constraints / caveats:
  very old, hardcoded Helio behavior, and not a general WebXR compatibility
  answer.
- What to inspect next:
  collect modern browser compatibility shims before any real adapter work.
- Why it matters for `VR-apps-lab`:
  teaches a useful caution: compatibility shims should be tiny, explicit, and
  disposable.

## Cross-Project Synthesis

### Strongest reusable methods

- WebXR device abstraction behind a guarded global API patch.
- Devtools or shell-driven emulator bridge.
- Input-profile metadata to engine/controller model loader.
- Capability-isolated WebXR emulator shell.
- Small vendor-browser API drift shim.

### Best product references

- `xrview` for a standalone emulator/product shell.
- `WebXR-emulator-extension` for operator controls and synthetic device state.
- `webxr-input-profiles-loader` for controller visual model loading.

### What Not To Copy

- stale WebVR/Cardboard assumptions;
- old 2019 draft method names as current API truth;
- viewer-specific HoloKit/Helio behavior as general WebXR architecture;
- shell designs that give untrusted web content native capabilities;
- CDN or asset assumptions without offline/cache policy.

## Placement

- Registry section:
  `WebXR runtime/dev scaffolding, polyfills, emulators, and input profile loaders`
- Family section:
  `WebXR runtime/dev scaffolding, polyfills, emulators, and input profile loaders`
- Methods:
  WebXR runtime device abstraction, emulator shell injection, input-profile
  model loader.
- Follow-up queue:
  WebXR runtime compatibility matrix across extension, standalone shell,
  app-level polyfill, viewer adapter, and micro-shim approaches.
