# GitHub Research Wave 204 Backlog

- Date: `2026-06-06`
- Theme: `WebXR runtime/dev scaffolding, polyfills, emulators, and input profile loaders`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for WebXR polyfills, emulator extensions, standalone
  runtime shells, viewer-specific device adapters, input-profile loaders, and
  API-drift shims.
- `Done` Dedupe against official WebXR samples, input profiles, layers
  polyfill, test API, and earlier WebXR waves.
- `Done` Freeze a shortlist spanning fallback runtime, emulator UI, profile
  loader, device adapter, and micro-shim roles.

## Source Sync

- `Done` Confirm `webxr-polyfill` in local-only cache.
- `Done` Confirm `WebXR-emulator-extension` in local-only cache.
- `Done` Confirm `webxr-input-profiles-loader` in local-only cache.
- `Done` Confirm `xrview` in local-only cache.
- `Done` Confirm `holokit-webxr` in local-only cache.
- `Done` Confirm `holoweb-webxr-polyfills` in local-only cache.
- `Done` Confirm `magicleap-helio-webxr-polyfill` in local-only cache.

## Code Reading

- `Done` Inspect global API injection, `navigator.xr` install path,
  `makeXRCompatible` patching, and abstract `XRDevice` boundary in
  `webxr-polyfill`.
- `Done` Inspect content-script injection, page custom events, devtools panel
  pose/button/device controls, and old-spec limitations in
  `WebXR-emulator-extension`.
- `Done` Inspect profile-list fetching, profile JSON cache, handedness layout
  routing, glTF asset loading, and visual-response animation in
  `webxr-input-profiles-loader`.
- `Done` Inspect Tauri multi-webview shell, URL normalization, all-frame init
  script injection, IWER runtime install, DevUI, and capability isolation in
  `xrview`.
- `Done` Inspect HoloKit device subclassing, immersive AR support, multiview
  projection/viewport logic, and broad WebXR module surface in
  `holokit-webxr`.
- `Done` Inspect `holoweb-webxr-polyfills` as an overlapping HoloKit-style
  variant rather than a full new donor.
- `Done` Inspect Magic Leap Helio `navigator.xr` request/session/frame shim and
  hardcoded browser API drift handling.

## Integration

- `Done` Create Wave 204 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for WebXR device abstraction, emulator shells,
  and input-profile model loading.
- `Next` Build a WebXR runtime compatibility matrix across browser extension,
  standalone shell, app-level polyfill, viewer-specific adapter, and micro-shim
  approaches.
