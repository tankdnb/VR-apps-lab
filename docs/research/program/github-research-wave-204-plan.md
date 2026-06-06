# GitHub Research Wave 204 Plan

- Date: `2026-06-06`
- Theme: `WebXR runtime/dev scaffolding, polyfills, emulators, and input profile loaders`
- Scope: WebXR polyfill/device abstraction, browser-extension and desktop
  emulator shells, WebXR input-profile model loading, and vendor-browser API
  shims.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Previous WebXR waves covered official samples, input profiles, hand tracking,
layers, test APIs, and React/Three wrappers. Wave 204 goes one layer lower: how
projects emulate or patch WebXR runtime availability, route device/input data
into apps, and translate WebXR input-profile metadata into engine-side visual
models.

## Search Families

- WebXR polyfills and runtime shims
- desktop WebXR emulators
- WebXR browser extension developer tools
- input-profile model loaders
- viewer-specific WebXR device adapters
- vendor-browser API drift shims

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `immersive-web/webxr-polyfill` | Baseline JS WebXR polyfill with device abstraction boundary | Runtime fallback donor |
| `MozillaReality/WebXR-emulator-extension` | Browser extension that injects an emulated XR runtime and devtools panel | Developer emulator donor |
| `De-Panther/webxr-input-profiles-loader` | Unity package that loads WebXR input-profile JSON and glTF visual responses | Input model loader donor |
| `michelesandroni/xrview` | Tauri desktop WebXR emulator shell with trust-separated browser and toolbar webviews | Standalone emulator shell donor |
| `holokit/holokit-webxr` | Viewer-specific WebXR polyfill with AR, secondary views, hands, anchors, depth, and camera modules | Device adapter reference |
| `realitydeslab/holoweb-webxr-polyfills` | HoloKit-style polyfill variant with broad WebXR module type surface | Fork/variant comparison node |
| `mvilledieu/magicleap-helio-webxr-polyfill` | Magic Leap Helio API drift compatibility shim | Micro-shim reference |

## Dedupe Notes

- Official `webxr-samples`, `webxr-input-profiles`,
  `webxr-layers-polyfill`, `webxr-test-api`, and older tracked Mozilla
  polyfill lines were excluded or treated as already covered.
- `holoweb-webxr-polyfills` is retained as a variant only because it largely
  overlaps with HoloKit-style WebXR polyfill code.
- `xrview` was kept because it changes the product shape from browser extension
  to standalone desktop emulator shell.

## Code-Level Pass Targets

- Global API injection, `navigator.xr` patching, `makeXRCompatible` shims, and
  compatibility gates.
- Abstract XR device interfaces: session request, frame loop, poses, viewports,
  projection matrices, input sources, reference spaces, and feature support.
- Devtools or shell message bridge between UI controls and injected page
  runtime.
- Input-profile list/profile JSON fetching, layout routing, glTF loading, and
  visual-response transform animation.
- Trust boundaries for standalone emulator shells that load untrusted web
  content.
- Vendor/browser-specific API-drift patches and stale-spec caveats.

## Expected Outputs

- Wave 204 landscape synthesis.
- Registry and family placement for WebXR runtime/dev scaffolding projects.
- Methods for WebXR device abstraction, emulator injection shells, and
  input-profile model loaders.
