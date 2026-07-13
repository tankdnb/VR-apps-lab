# VR Projects Wave 427 - WebXR Toolkit Retrofit Bridges For MRTK And HPTK

- Date: `2026-07-13`
- Theme: WebXR/WebGL retrofit bridges for Unity interaction toolkits.

## Shortlist

| Project | Study status | Why it matters |
|---|---|---|
| `Rufus31415/MixedRealityToolkit-Unity-WebXR` | Studied with deprecation caveat | MRTK fork/POC showing Unity WebGL canvas over WebXR/Three.js camera/video, transparent background, and SendMessage camera bridge |
| `Rufus31415/HPTK-Sample-WebXR` | Studied | Unity sample wiring HPTK to SimpleWebXR hand joints through a WebXR input data provider |

## Cross-Project Synthesis

This wave focuses on retrofitting existing Unity interaction toolkits into
browser/WebXR targets. Both projects show that the key donor value is the
adapter boundary, not the entire fork:

- browser/WebXR session and capability state;
- Unity WebGL/WebAssembly build constraints;
- coordinate/scale/rotation conversion;
- hand or camera data provider;
- transparent DOM/canvas composition;
- honest caveats when the prototype is deprecated or inefficient.

## Project Notes

### `Rufus31415/MixedRealityToolkit-Unity-WebXR`

- Interesting idea:
  retrofit MRTK hand-interaction scenes into a browser AR/WebXR proof of
  concept by layering a transparent Unity WebGL canvas over a WebXR/Three.js
  camera/video world.
- Code donor value:
  README and source document WebGL export template, transparent-background
  `.jslib`, JavaScript-to-Unity camera transform messages, and hard-coded
  scale/FOV caveats.
- Product reference value:
  useful historical reference for browser-hosted XR utility surfaces that need
  to compose DOM/video/world mesh with a Unity panel or scene.
- Source evidence:
  README states the repo is deprecated in favor of `Simple-WebXR-Unity`; it
  describes a WebGL export template, WebXR session start, Three.js world-mesh
  display, Unity canvas overlay, and `unityInstance.SendMessage`; `JSConnector.cs`
  parses JSON into camera position/rotation/FOV; `TransparentBackground.jslib`
  alters WebGL clear behavior to preserve alpha.
- Reusable core:
  WebXR host page, Unity canvas overlay, transparent background hook,
  camera-pose bridge, coordinate conversion, feature/fallback labels, and
  migration path to a smaller maintained bridge.
- What not to copy:
  deprecated fork, browser-specific XRViewer assumptions, hard-coded iPhone
  FOV/scale, JSON `SendMessage` loop as a performance-sensitive production
  transport, or modified package cache files.
- What to inspect next:
  how `Simple-WebXR-Unity` replaced this fork and what modern WebXR Layers or
  WebGPU paths change.

### `Rufus31415/HPTK-Sample-WebXR`

- Interesting idea:
  plug WebXR hand joints into Hand Physics Toolkit through a small input data
  provider, keeping toolkit hand physics separate from browser data ingress.
- Code donor value:
  `WebXRInputDataProvider.cs` maps `SimpleWebXR.LeftInput/RightInput.Hand`
  joints into HPTK bones, converts rotations, gates confidence on session and
  availability, and includes editor JSON test hands.
- Product reference value:
  strong reference for adapting toolkit-specific hand models to WebXR without
  rewriting the toolkit.
- Source evidence:
  package manifest depends on `com.jorgejgnz.hptk` and XR/Oculus packages;
  `WebXRInputDataProvider.cs` checks `SimpleWebXR.InSession`, maps
  `WebXRHand.WRIST`, thumb/index/middle/ring/little joints to HPTK bones,
  applies `_webxrToHPTKRotation`, updates finger poses, and sets confidence.
- Reusable core:
  WebXR session gate, hand availability gate, toolkit bone map, coordinate
  conversion, confidence state, editor fixture data, and provider abstraction.
- What not to copy:
  exact joint mapping bugs or comments, Oculus-heavy sample dependencies, or
  all HPTK sample assets when only the data provider pattern is needed.
- What to inspect next:
  modern WebXR hand-tracking support, left/right joint parity, physics-hand
  stability, and neutral hand-joint schemas.

## Reusable Pattern Extraction

- Pattern candidate:
  `WebXR toolkit retrofit adapter`.
- Problem solved:
  useful Unity XR toolkits often assume native runtimes, while browser/WebXR
  delivery needs small adapters for camera, hands, canvas composition, and
  capability fallback.
- Reusable core:
  WebXR host/session layer, Unity WebGL build profile, browser-to-engine data
  provider, coordinate conversion, hand/camera schema, transparent canvas or
  surface composition, editor fixtures, and deprecation/migration labels.
- Source evidence:
  `Rufus31415/MixedRealityToolkit-Unity-WebXR` and
  `Rufus31415/HPTK-Sample-WebXR`.
- Abstraction boundary:
  keep browser session plumbing and toolkit interaction code separate; let the
  adapter own transforms, feature gates, and fallback state.
- What not to copy:
  abandoned full forks, hard-coded device calibration, heavy JSON bridges in
  frame loops, or undocumented package-cache modifications.
- Method catalog action:
  add new method for WebXR toolkit retrofit adapters.

## Follow-Up Gaps

- Compare `Simple-WebXR-Unity`, Unity WebXR Export, and toolkit-specific input
  providers as adapter layers.
- Define a neutral browser hand/camera pose schema for Unity/Godot/WebXR tools.
- Document browser feature gates: HTTPS, permissions, WebXR Hands, WebGL
  transparency, and WebXR Layers.

