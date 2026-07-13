# VR Projects Wave 417 - WebXR Capture Avatar And Micro Editor Surfaces

- Date: `2026-07-13`
- Scope: small WebXR/browser projects that expose capture, avatar preview, and in-browser scene editing ideas.
- Rule: source/documentation reading only; no builds, installs, launches, or device tests were performed.

## Shortlist

- `k1pp0/model-viewer-webxr-capture`
- `voyagerD/webxr-avatar`
- `Damfino1970/quest2-webxr-editor`

## Project Notes

### `k1pp0/model-viewer-webxr-capture`

- Interesting idea: companion custom element for `<model-viewer>` that injects WebXR AR screenshot capture without forking upstream `model-viewer`.
- Code donor value: strongest donor in this wave: custom element shell, host-symbol reflection, idempotent global patches, frame hook subscription, camera-access injection, capture provider lifecycle, preview UI, share/download action, and Chrome workaround boundaries.
- Product reference value: excellent reference for plugin-like browser XR utilities that must extend a host component without owning it.
- Source evidence: `src/model-viewer-webxr-capture.ts`, `src/host-bridge.ts`, `src/webxr-capture-provider.ts`, `src/three-components/WebXRCapture.ts`, tests, and README.
- Reusable core: companion element, host resolution, optional feature injection, frame dispatcher, capture lifecycle, Blob result API, preview overlay, and compatibility warning path.
- What not to copy: private-symbol reflection or monkey-patching without explicit version gates and failure messages.
- What to inspect next: adapt the pattern into a general `hosted WebXR companion plugin` method.

### `voyagerD/webxr-avatar`

- Interesting idea: tiny WebXR avatar scene with GLB animation assets and minimal browser deployment.
- Code donor value: modest; useful as a micro reference for asset layout and browser-delivered avatar proof of concept.
- Product reference value: validates that lightweight WebXR avatar demos can be useful as thin educational or preview surfaces.
- Source evidence: `index.html`, `assets/waving.glb`, `assets/walk_man.glb`, `assets/jump.glb`, and README.
- Reusable core: static asset scene, animated avatar assets, browser-first preview, and GitHub Pages style deployment.
- What not to copy: treating an asset demo as a full avatar system.
- What to inspect next: whether animation-state selection or input binding exists beyond the static page.

### `Damfino1970/quest2-webxr-editor`

- Interesting idea: small WebXR application hosted on GitHub Pages, framed as a Quest 2 editor.
- Code donor value: thin, but useful as a micro-example of browser-first deployment and single-page WebXR experiment packaging.
- Product reference value: reinforces the `tiny WebXR editor surface` direction already seen in prior waves.
- Source evidence: `index.html` and README.
- Reusable core: static deployment, one-file experiment shape, browser-accessible XR entry point.
- What not to copy: low documentation depth or unclear editor model.
- What to inspect next: whether the live page exposes scene editing beyond the checked-in source.

## Extracted Method Candidate

`Hosted WebXR companion surface`: attach a browser XR feature as a companion element or thin page around a host viewer/editor, with explicit capability checks, lifecycle cleanup, and warnings for private host integration points.
