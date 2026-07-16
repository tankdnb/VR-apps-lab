# Wave 467: Browser VR Gaussian splat components and viewer variants

- Date: `2026-07-16`
- Scope: small WebXR/A-Frame Gaussian splat components, browser-friendly splat
  rendering, shader/data-texture boundaries, worker sorting, VR pixel scaling,
  cutout/depth variants, and relation to already studied native/Unity/OpenXR
  splat viewers.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `quadjr/aframe-gaussian-splatting` | Studied | A-Frame component implementation of a 3D Gaussian splat viewer with worker sorting and WebXR pixel-ratio controls |
| `3DStreet/aframe-gaussian-splatting` | Studied as fork/variant | Fork adding depth/discard controls, cutout/transparency demos, and hosted sample asset references |
| `clarte53/GaussianSplattingVRViewerUnity` | Cross-wave reference | Already studied native CUDA/OpenXR Unity viewer |
| `Enndee/Splatviewer_VR` | Cross-wave reference | Already studied VR splat viewer with runtime file loading |
| `hyperlogic/splatapult` | Cross-wave reference | Already studied OpenGL/OpenXR splat viewer |
| `jacobvanbeets/splat-vr-viewer` | Cross-wave reference | Already studied WebXR PlayCanvas viewer launched from LichtFeld Studio |

## Project notes

### `quadjr/aframe-gaussian-splatting`

- Interesting idea: a Gaussian splat renderer packaged as an A-Frame component,
  so a scene can declare `gaussian_splatting="src: ..."` rather than owning a
  full custom viewer app.
- Code donor value: high conceptually; `index.js` is a compact component that
  covers schema, renderer pixel ratio, XR framebuffer scale, data textures,
  shader material, streaming fetch, worker sorting, and splat index updates.
- Product reference value: high for lightweight browser XR previews and
  documentation demos.
- Source evidence: `index.js`, `index.html`, `cutout-demo.html`, `README.md`,
  `dist/aframe-gaussian-splatting-component.min.js`.
- Reusable core: A-Frame schema, `src`, `pixelRatio`, `xrPixelRatio`,
  WebGL texture buffers, instanced quad geometry, covariance/color textures,
  projection/model-view uniform refresh, worker-sorted indexes, and progressive
  fetch path.
- What not to copy: raw shader code without license/provenance review, demo
  asset URLs, hard-coded defaults, and memory-heavy assumptions without device
  labels.
- What to inspect next: modern WebXR performance on Quest/browser runtimes and
  source-data format handling.

### `3DStreet/aframe-gaussian-splatting`

- Interesting idea: a practical fork that keeps the A-Frame component shape but
  adds `depthWrite` and `discardFilter` controls plus transparency/cutout demos.
- Code donor value: medium to high; it is a useful comparison for exposing
  rendering knobs directly in declarative scene attributes.
- Product reference value: high; future VR-apps-lab demos could use a similar
  declarative "large spatial asset preview" component with explicit caveats.
- Source evidence: `index.js`, `transparency-sorting.html`,
  `cutout-demo.html`, `assets/train.splat`, `README.md`.
- Reusable core: component-level render knobs, alpha discard threshold,
  depth-write toggle, nested splat entities, scene-level stats, and demo
  patterns for sorting/cutout issues.
- What not to copy: sample splat asset, hosted Hugging Face asset assumptions,
  retry loop without user status, and shader tuning without performance labels.
- What to inspect next: whether this should update the existing splat viewer
  method as a browser-component subcase rather than a separate product branch.

## Reusable pattern extraction

- Pattern candidate: `Declarative WebXR splat preview component`.
- Problem solved: heavy spatial captures are useful in VR, but full native
  viewers are not always needed; a browser scene sometimes needs an embeddable
  preview component with explicit quality/performance controls.
- Reusable core: declarative component schema, splat source descriptor, device
  pixel ratio, XR framebuffer scale, render knobs, data-texture upload,
  progressive stream, worker sorting, format caveats, demo asset provenance,
  and visible loading/performance state.
- Source evidence: `quadjr/aframe-gaussian-splatting/index.js` and
  `3DStreet/aframe-gaussian-splatting/index.js`.
- Abstraction boundary: keep format parsing/rendering separate from scene UX,
  file hosting, and engine-specific declarative attributes.
- What not to copy: demo assets, old shader assumptions, silent retries, and
  unbounded memory/vertex counts without device labels.
- Method catalog action: add `Method 912`.

## Why this matters for VR-apps-lab

The repository already covers several native and Unity VR splat viewers. This
wave adds the browser-component layer: how to embed splat preview into a WebXR
scene as a reusable utility building block.

