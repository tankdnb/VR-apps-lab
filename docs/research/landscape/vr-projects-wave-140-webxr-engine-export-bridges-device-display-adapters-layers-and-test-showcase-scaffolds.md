# VR Projects Wave 140: WebXR Engine Export Bridges, Device-Display Adapters, Layers, and Test/Showcase Scaffolds

- Date: `2026-06-05`
- Goal: study browser-XR infrastructure projects that turn engines, displays,
  layers, tests, and product showcases into reusable WebXR utility patterns.

## Why this wave exists

Browser-native XR is not only a content delivery channel. It is also a useful
utility substrate for configuration panels, diagnostics, quick prototypes,
public demos, no-install support tools, and display-surface experiments. This
wave focuses on bridge and infrastructure projects rather than finished apps.

## Better workflow used in this wave

1. searched by WebXR export, Unity WebGL XR, layers, test API, Looking Glass,
   and Quest showcase families;
2. deduplicated against prior WebXR samples, emulator, polyfill, A-Frame, and
   React/Three XR waves;
3. froze a shortlist across engine export, minimal bridge, display adapter,
   layer polyfill, testing API, and showcase examples;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `De-Panther/unity-webxr-export` | Unity package-level WebXR loader and settings bridge |
| `Rufus31415/Simple-WebXR-Unity` | Minimal Unity WebXR bridge with editor simulator |
| `Looking-Glass/looking-glass-webxr` | Custom WebXR device adapter for non-HMD display output |
| `immersive-web/webxr-layers-polyfill` | Composition layer API shim and renderer reference |
| `immersive-web/webxr-test-api` | Deterministic browser test-device API reference |
| `meta-quest/webxr-showcases` | Feature-gated Quest/WebXR product showcase examples |

## Deep-pass notes by project

## `De-Panther/unity-webxr-export`

- GitHub:
  [De-Panther/unity-webxr-export](https://github.com/De-Panther/unity-webxr-export)
- What it is:
  a Unity package that exports WebGL builds with a WebXR loader, subsystem
  registration, input/camera bridge scripts, settings, build processors, and
  examples.
- Interesting idea:
  treat WebXR browser capabilities as explicit Unity XR settings instead of
  burying them in JavaScript glue.
- Code-level notes:
  `WebXRSettings.cs` serializes VR/AR reference-space requirements, optional
  features such as hit-test and hand tracking, framebuffer scale, manager
  autoload, input-system autoload, and optional disabling of Unity's
  XRDisplaySubsystem. `WebXRLoader.cs` registers the WebXR plugin in WebGL,
  passes the JSON settings into the native bridge, and starts or stops display
  and input subsystems. Camera and controller scripts subscribe to manager
  events, update per-eye views, map buttons/axes, and handle haptics.
- Architecture pattern:
  package-level XR loader plus JSON feature manifest plus runtime component
  bridge.
- Reusable method:
  engine export settings should become a readable compatibility contract.
- Code donor value:
  high for Unity package loader boundaries, feature gating, and browser bridge
  configuration.
- Product reference value:
  medium-high for WebXR export ergonomics and setup UI.
- Caveats:
  Unity/WebGL specific and dependent on browser WebXR feature availability.
- What to inspect next:
  compare with Godot, A-Frame, and React/Three WebXR capability gates.

## `Rufus31415/Simple-WebXR-Unity`

- GitHub:
  [Rufus31415/Simple-WebXR-Unity](https://github.com/Rufus31415/Simple-WebXR-Unity)
- What it is:
  a compact Unity package for entering WebXR sessions from WebGL with a single
  component, JavaScript library, examples, and editor simulation.
- Interesting idea:
  a small WebXR bridge can expose enough state for useful prototypes without a
  full Unity XR subsystem stack.
- Code-level notes:
  `SimpleWebXR.cs` owns session state, Enter AR/VR UI, user height, left/right
  input source state, select/squeeze callbacks, hit-test position/rotation, and
  per-eye cameras. It initializes WebXR through shared data arrays passed to
  `SimpleWebXR.jslib`, then updates state in `LateUpdate`. The editor
  simulator mirrors head/hand transforms and projection data for local
  iteration.
- Architecture pattern:
  one-component bridge backed by shared JS/C# arrays and editor fake-device
  simulation.
- Reusable method:
  start with a tiny bridge and only grow into subsystems when the prototype
  needs it.
- Code donor value:
  high for minimal browser bridge, input event shape, hit-test data flow, and
  simulator pattern.
- Product reference value:
  medium for lightweight Unity WebXR prototypes and demos.
- Caveats:
  smaller bridge means fewer built-in guardrails than full XR management.
- What to inspect next:
  compare update-loop timing and input abstractions against
  `unity-webxr-export`.

## `Looking-Glass/looking-glass-webxr`

- GitHub:
  [Looking-Glass/looking-glass-webxr](https://github.com/Looking-Glass/looking-glass-webxr)
- What it is:
  a WebXR polyfill-backed device adapter for Looking Glass holographic
  displays.
- Interesting idea:
  WebXR can target a custom display surface, not only a headset, if a project
  supplies an XRDevice-like adapter and view/projection model.
- Code-level notes:
  `LookingGlassXRDevice.ts` supports inline and immersive-vr session modes,
  accepts viewer/local/local-floor reference spaces, rejects bounded/unbounded
  spaces, moves the canvas into the Looking Glass window when a base layer is
  set, and computes multiple projection/inverse-view matrices from display
  configuration such as view count, view cone, aspect, field of view, and target
  diameter.
- Architecture pattern:
  non-HMD XRDevice adapter plus canvas/window lifecycle plus multi-view
  projection synthesis.
- Reusable method:
  custom display surfaces should own reference-space support and view
  generation explicitly.
- Code donor value:
  high for display adapter anatomy and multi-view output modeling.
- Product reference value:
  medium-high for virtual-display and non-headset XR workflows.
- Caveats:
  display-specific and uses polyfill abstractions that may diverge from native
  browser implementations.
- What to inspect next:
  compare with virtual-display and XR-glasses waves for display lifecycle
  reuse.

## `immersive-web/webxr-layers-polyfill`

- GitHub:
  [immersive-web/webxr-layers-polyfill](https://github.com/immersive-web/webxr-layers-polyfill)
- What it is:
  a polyfill for WebXR composition layers.
- Interesting idea:
  layer APIs can be shimmed by patching sessions and routing composition layer
  objects through specialized WebGL renderers.
- Code-level notes:
  `layers-polyfill.ts` detects WebXR, avoids native layers, patches
  `XRSession` render state and requestSession behavior, injects `XRWebGLBinding`
  and `XRMediaBinding`, and strips the `layers` required feature for supported
  immersive-vr polyfill paths. Renderer modules cover projection, quad, cube,
  cylinder, and equirect layers, including media textures, stereo layouts,
  texture arrays, viewport setup, texture rects, UVs, and transforms.
- Architecture pattern:
  compatibility shim plus session patch plus per-layer renderer classes.
- Reusable method:
  isolate compatibility interception from layer rendering implementation.
- Code donor value:
  high for composition-layer API emulation and media/layer renderers.
- Product reference value:
  medium for browser media panels and surface composition.
- Caveats:
  polyfill strategy must be treated as compatibility reference, not a guarantee
  of current browser support.
- What to inspect next:
  compare with media-player and overlay-panel needs around quad/cylinder/equirect
  surfaces.

## `immersive-web/webxr-test-api`

- GitHub:
  [immersive-web/webxr-test-api](https://github.com/immersive-web/webxr-test-api)
- What it is:
  a specification/explainer repository for a WebXR testing-only API used by
  Web Platform Tests and browser internals.
- Interesting idea:
  deterministic fake XR devices, views, poses, input sources, and extension
  data can make XR APIs testable without physical hardware.
- Code-level notes:
  The explainer models a flow where tests connect a fake device, request normal
  WebXR sessions, set viewer origin or tracking loss, connect simulated input
  sources, wait for frames, and assert behavior. Extension hooks include
  deterministic hit-test worlds and DOM overlay pointer positions before input
  simulation.
- Architecture pattern:
  testing-only fake-device control surface that feeds real WebXR-facing APIs.
- Reusable method:
  prototype diagnostics should separate device simulation from application code.
- Code donor value:
  medium as spec/test-harness reference, not application code.
- Product reference value:
  high for no-HMD, CI, and deterministic XR validation thinking.
- Caveats:
  not intended for production web content.
- What to inspect next:
  pair with no-HMD OpenVR/OpenXR fake-device projects to design a cross-runtime
  test vocabulary.

## `meta-quest/webxr-showcases`

- GitHub:
  [meta-quest/webxr-showcases](https://github.com/meta-quest/webxr-showcases)
- What it is:
  a set of Quest/WebXR showcase experiences including furniture placement,
  measurement, controller interaction, and product configuration.
- Interesting idea:
  showcase apps are useful because they show complete feature-gated user flows,
  not just isolated API calls.
- Code-level notes:
  `chairs-etc` requests hit-test, plane-detection, and anchors for room capture
  and furniture placement. `realmeasure` uses optional local-floor, layers,
  anchors, and unbounded features with measurement tools. `sneaker-builder`
  demonstrates product configuration, UI planes, ray/claw pointer modes, and
  controller raycaster distance handling. `flap-frenzy` is a small controller
  movement interaction reference.
- Architecture pattern:
  product-scale WebXR scene with explicit feature requirements and focused
  interaction idioms.
- Reusable method:
  utility demos should expose feature requirements at session start and keep
  controller modes visible.
- Code donor value:
  medium-high for feature-gated WebXR scene scaffolds and interaction examples.
- Product reference value:
  high for AR placement, measurement, and configurator UX.
- Caveats:
  showcase code is tuned for sample experiences, not generic library reuse.
- What to inspect next:
  compare with Meta Unity MR samples for shared room, anchor, and measurement
  patterns.

## Cross-project synthesis

- Strongest code donors:
  `unity-webxr-export`, `Simple-WebXR-Unity`, `looking-glass-webxr`,
  `webxr-layers-polyfill`.
- Strongest product references:
  `webxr-showcases`, then `unity-webxr-export`.
- Strongest infrastructure reference:
  `webxr-test-api`.
- Main reusable methods:
  feature/refspace manifesting, minimal bridge simulation, custom display
  adapter lifecycle, layer session patching, deterministic fake-device testing,
  and feature-gated showcase UX.

## Fit for `VR-apps-lab`

This wave strengthens browser-native utility foundations: WebXR export,
testing, custom displays, media layers, AR placement, and small product demos.
It should influence future browser-backed overlay/control panels and no-install
diagnostic prototypes.
