# Wave 453: WebXR MRTK and Unity interaction bridge samples

- Date: `2026-07-13`
- Scope: Unity/WebXR interaction export and MRTK-style hand interaction
  references.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `AnderSystems/WebXR-Interactions` | Studied | Unity WebXR UI/raycast interaction bridge |
| `calebcram/WebXR-MRTK-HandInteraction` | Studied | WebXR-hosted MRTK hand interaction build/reference |
| `Rufus31415/MixedRealityToolkit-Unity-WebXR` | Already tracked; overlap reference | Existing WebXR/MRTK retrofit family |

## Why this wave matters

`VR-apps-lab` already tracks WebXR export and toolkit retrofit paths, but this
wave narrows the question to interaction handoff: how Unity scenes expose
WebXR-compatible input, raycast UI, hand interaction demos, build templates,
and browser-hosted control surfaces.

## Project notes

### `AnderSystems/WebXR-Interactions`

- Interesting idea:
  a Unity WebGL/WebXR project that layers raycast interaction and UI examples
  over Mozilla/Unity WebXR Toolkit style export.
- Code donor value:
  useful for WebGL template structure, WebXR loader/settings assets, WebGL
  bridge plugin, URP/WebXR scene configuration, and interactive training-scene
  assets.
- Product reference value:
  shows how browser-deployed XR utilities need a WebXR template, a Unity-side
  interaction layer, and explicit UI/raycast affordances rather than only a
  build button.
- Source evidence:
  `Assets/Plugins/WebGL.jslib`, `Assets/XR/Settings/WebXRSettings.asset`,
  `Assets/XR/Loaders/WebXRLoader.asset`, WebGL templates under
  `Assets/WebGLTemplates/*`, and interaction/demo assets under `Assets/Systems`.
- Reusable core:
  WebXR build template, WebXR loader settings, Unity-to-browser bridge file,
  ray/UI target conventions, controller affordance cues, and fallback web UI.
- What not to copy:
  large demo assets, bundled TextMesh Pro material, Portuguese tutorial media,
  or project-specific scene content.
- What to inspect next:
  exact input event adapters, raycast hit routing, and whether interaction code
  can be lifted out of the demo assets.

### `calebcram/WebXR-MRTK-HandInteraction`

- Interesting idea:
  a published WebXR build of MRTK's hand interaction demo aimed at HoloLens,
  Quest, PCVR browser emulator, Android, and iOS WebXR Viewer paths.
- Code donor value:
  limited source donor value because the repo mostly contains build artifacts,
  but it is valuable as a product/reference node for browser-hosted MRTK-style
  hand interaction demos.
- Product reference value:
  shows cross-device WebXR distribution framing: one URL, multiple XR-capable
  browser/device targets, and named demo variants.
- Source evidence:
  `README.md`, `index.html`, `webxr.js`, `Build/Build_WebXRHandInteraction.*`,
  and `TemplateData/*`.
- Reusable core:
  hosted demo landing page, WebXR bootstrap, build artifact routing, device
  support labels, and sample-family linking.
- What not to copy:
  minified/generated Unity build outputs or old WebXR/MRTK build assumptions.
- What to inspect next:
  original Unity project if available, input profile handling, and how hand
  poses map into MRTK interactions before export.

### `Rufus31415/MixedRealityToolkit-Unity-WebXR`

- Interesting idea:
  existing tracked POC that remains the stronger source-level comparison for
  WebXR/MRTK retrofits.
- Code donor value:
  keep as overlap reference for transparent Unity canvas, Three.js/WebXR camera
  bridge, and `SendMessage` transform JSON.
- Product reference value:
  helps distinguish build-artifact demos from reusable bridge architecture.
- What to inspect next:
  consolidate with WebXR export samples into a bridge-pattern matrix.

## Reusable pattern extraction

- Pattern candidate:
  `WebXR exported interaction bridge`.
- Problem solved:
  make Unity/MRTK interactions visible in a browser-hosted XR runtime without
  treating WebXR export as only a packaging target.
- Reusable core:
  WebXR loader, build template, browser bootstrap, Unity bridge plugin,
  reference-space/camera handoff, controller/hand input mapping, raycast UI,
  device support labels, and generated-build provenance.
- Abstraction boundary:
  browser owns XR session and page lifecycle; Unity owns scene/interactions;
  bridge code owns input and pose translation.
- Method catalog action:
  create a new method for WebXR exported interaction bridges.

## Caveats

- Several repos are proof-of-concept or generated-build heavy.
- Do not treat hosted WebXR demo repos as maintainable source donors unless the
  original Unity project and bridge code are present.
- Device support claims need date and browser/runtime labels.

