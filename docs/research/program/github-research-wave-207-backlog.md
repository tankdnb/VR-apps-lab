# GitHub Research Wave 207 Backlog

- Date: `2026-06-06`
- Theme: `React/Three XR runtime, spatial UI, and interaction lab surfaces`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for React Three XR runtime, spatial UI, WebXR lab,
  teleport, AR measurement, GLB viewer, and hand-tracked product UI projects.
- `Done` Dedupe against prior WebXR samples, React XR wrappers, hand tracking,
  and browser utility waves.
- `Done` Freeze a shortlist that distinguishes strong donors from thin
  starter/micro-reference repos.

## Source Sync

- `Done` Confirm `pmndrs/xr` in local-only cache.
- `Done` Confirm `pmndrs/uikit` in local-only cache.
- `Done` Confirm `webxr-playground` in local-only cache.
- `Done` Confirm `DefaultReactXR` in local-only cache.
- `Done` Confirm `xrTeleport` in local-only cache.
- `Done` Confirm `react-three-xr-measurement` in local-only cache.
- `Done` Confirm `BoltXR` in local-only cache.
- `Done` Confirm `glb-ar-viewer` in local-only cache.

## Code Reading

- `Done` Inspect `pmndrs/xr` store state, session/manager setup, offer/enter
  flows, input-source state sync, frame hooks, teleport targets, ray model,
  React `<XR>` boundary, and pointer-event integration.
- `Done` Inspect `pmndrs/uikit` Yoga/flex node, pointer-event properties,
  clipped casting, scroll handlers, input/selection bridge, hidden DOM input,
  and component/kits exports.
- `Done` Inspect `webxr-playground` lab registry, tuning presets, app store,
  XR root, origin controls, TagAlong HUD, selection lab, manipulation
  acquisition, and session logger sync.
- `Done` Inspect `DefaultReactXR` starter store options, pointer config,
  UIKit enter button, support checks, and `noEvents` Canvas boundary.
- `Done` Inspect `xrTeleport` raycast teleport target, normal-aligned marker,
  player pose update, and snap-turn threshold.
- `Done` Inspect `react-three-xr-measurement` AR hit-test reticle, select
  event, measurement line, midpoint label, and hit-test session features.
- `Done` Inspect `BoltXR` WebXR scene shell, IWER emulation flag, 3D panels,
  PIN/QR/product widgets, MediaPipe hand landmark gesture pipeline, and
  safety/product caveats.
- `Done` Inspect `glb-ar-viewer` Next.js model route, GLB upload/redirect,
  WebXR store with DOM overlay/hit-test, iOS fallback link, animation toggle,
  and transform controls.

## Integration

- `Done` Create Wave 207 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for React/Three XR store substrate, spatial UI
  layout/input, and WebXR interaction lab shells.
- `Next` Build a React/Three XR substrate matrix across store, input source,
  pointer events, UI layout, text input, teleport, HUD, lab logging, and
  starter maturity.
