# VR Projects Wave 144: WebXR Hand Tracking, Hand Input Surfaces, and Hand-Data Bridges

- Date: `2026-06-05`
- Goal: study WebXR hand tracking as a reusable input, UI, and data-export
  substrate for browser-native VR utilities.

## Why this wave exists

Hands are not only an avatar or demo feature. For utility tools they can become
low-friction controls: pinch selection, wrist or fingertip panels, direct
object manipulation, ray pointing without controllers, and remote pose streams
for robots, diagnostics, gesture classifiers, or companion apps.

## Better workflow used in this wave

1. searched by WebXR hand tracking, A-Frame hand controls, Quest hand demos,
   Babylon hand features, and WebSocket hand-pose bridges;
2. deduplicated against prior WebXR, A-Frame, MediaPipe, avatar, and tracking
   bridge waves;
3. froze a shortlist across low-level joints, A-Frame components, tiny pinch
   drawing, Quest passthrough interaction, and WebSocket export;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `marlon360/webxr-handtracking` | Hand joint extraction, A-Frame hand components, pinch gestures, fingertip rays |
| `TakashiYoshinaga/webxr-hand-tracking-sample` | Minimal pinch drawing and left/right hand role split |
| `rick98033/webxr-hand-tracking-websocket` | Browser hand tracking exported as WebSocket JSON |
| `danielklinkhammer/webxr-quest2` | Single-file Quest passthrough hand-grab demo |

## Deep-pass notes by project

## `marlon360/webxr-handtracking`

- GitHub:
  [marlon360/webxr-handtracking](https://github.com/marlon360/webxr-handtracking)
- What it is:
  a WebXR hand-tracking example set with A-Frame and lower-level Three/WebXR
  helpers for hand meshes, gesture events, fingertip raycasting, physics hooks,
  and drawing.
- Interesting idea:
  expose hand joints as reusable scene entities first, then build gestures,
  raycasters, drawing, and physics behavior on top.
- Code-level notes:
  `js/aframe/hand-tracking.js` registers a system that reads
  `session.inputSources`, skips non-hand sources, iterates `XRHand` joints,
  calls `frame.getJointPose`, stores visibility, position, orientation, radius,
  and emits an `init-hands` event. `hand-tracking-gestures.js` depends on that
  component and emits `started-pinch` / `ended-pinch` with separate pinch and
  release thresholds. `finger-raycaster.js` orients a tiny helper at the index
  tip and maps it into an A-Frame raycaster.
- Architecture pattern:
  low-level joint cache system plus composable A-Frame behavior components.
- Reusable method:
  model hand tracking as `joint stream -> gesture events -> UI behaviors`
  instead of hardwiring gesture logic into every tool.
- Code donor value:
  high for `XRHand` pose extraction, pinch hysteresis, fingertip ray origin,
  and component boundaries.
- Product reference value:
  medium for browser hand UI experiments and in-headset drawing.
- Caveats:
  examples are demo-oriented, and thresholds are hand/device sensitive.
- What to inspect next:
  compare its pinch thresholds with PlayCanvas/Babylon hand abstractions and
  previous A-Frame hand UI repos.

## `TakashiYoshinaga/webxr-hand-tracking-sample`

- GitHub:
  [TakashiYoshinaga/webxr-hand-tracking-sample](https://github.com/TakashiYoshinaga/webxr-hand-tracking-sample)
- What it is:
  a tiny A-Frame WebXR hand tracking sample where the right hand creates boxes
  while pinching and the left hand clears the scene.
- Interesting idea:
  assign different hands different utility verbs to avoid mode-heavy UI.
- Code-level notes:
  `sample/index.html` attaches `pinchstarted`, `pinchmoved`, and `pinchended`
  listeners to `hand-tracking-controls`. Right-hand pinch places small boxes at
  the pinch position, adds new boxes after the pinch moves more than a distance
  threshold, and cycles color on release. Left-hand pinch removes all generated
  boxes. A separate polling loop mirrors the right index tip into a visible
  sphere.
- Architecture pattern:
  direct event-driven hand role split with minimal scene mutation.
- Reusable method:
  use hand role assignment for simple utilities: one hand acts, the other
  resets, confirms, or switches modes.
- Code donor value:
  medium-low as a compact event example.
- Product reference value:
  medium for hand-first micro-tools and teaching demos.
- Caveats:
  small sample with direct DOM/scene mutation and no abstraction layer.
- What to inspect next:
  test the hand-role idea against menus, annotation tools, and calibration
  wizards.

## `rick98033/webxr-hand-tracking-websocket`

- GitHub:
  [rick98033/webxr-hand-tracking-websocket](https://github.com/rick98033/webxr-hand-tracking-websocket)
- What it is:
  a Babylon.js-oriented WebXR hand tracking bridge that streams hand joint data
  over WebSocket for external tools, teleoperation, gesture recognition, or
  research capture.
- Interesting idea:
  treat WebXR hand tracking as a browser-side sensor that can feed any local or
  remote consumer through a simple JSON transport.
- Code-level notes:
  `src/hand-tracking.js` wraps connection state, auto-reconnect,
  handedness selection, update-rate limiting, Babylon
  `WebXRFeatureName.HAND_TRACKING` enablement, hand add/remove callbacks, and
  an `onBeforeRenderObservable` transmission loop. It maps 13 common joints to
  Babylon `WebXRHandJoint` enums, extracts position and wrist quaternion, emits
  `type`, `handedness`, `joints`, `timestamp`, and `jointCount`, and exposes
  status callbacks. `examples/server-example.py` documents a simple receiver
  shape.
- Architecture pattern:
  XR feature adapter plus rate-limited WebSocket telemetry bridge.
- Reusable method:
  publish hand pose as a stable external-data product with explicit joint
  subset, handedness, timestamp, and connection state.
- Code donor value:
  high for a browser-to-tool bridge, reconnect policy, and payload shape.
- Product reference value:
  high for diagnostics, gesture capture, teleoperation, and no-install hand
  sensor utilities.
- Caveats:
  depends on Babylon's hand feature wrapper and only exports a selected joint
  subset by default.
- What to inspect next:
  normalize the payload against OSC/VMC/SlimeVR and WebSocket tracker bridge
  schemas.

## `danielklinkhammer/webxr-quest2`

- GitHub:
  [danielklinkhammer/webxr-quest2](https://github.com/danielklinkhammer/webxr-quest2)
- What it is:
  a single-file A-Frame Quest browser demo for passthrough hand interaction.
- Interesting idea:
  a useful hand interaction prototype can fit in one HTML file if it clearly
  separates interactable metadata, hand collider behavior, and scene feedback.
- Code-level notes:
  `index.html` requests `hand-tracking` and `local-floor`, optionally requests
  bounded floor, mesh detection, and plane detection, and renders with
  transparent background for passthrough. `hand-collider` finds index and thumb
  tip bones from `hand-tracking-controls`, detects pinch with a 3 cm threshold,
  computes the pinch midpoint, grabs the nearest `.interactive` element within
  15 cm, stores an offset, scales/colors the object while active, and updates
  hover colors by distance. Laser controls remain available as fallback rays.
- Architecture pattern:
  single-file passthrough scene with direct hand collider and interactable
  metadata.
- Reusable method:
  for hand-first tools, combine near-hand direct manipulation with visible
  hover/active color feedback and fallback rays.
- Code donor value:
  medium for pinch-midpoint grabbing and passthrough-friendly defaults.
- Product reference value:
  high for quick Quest browser prototypes and MR utility demos.
- Caveats:
  bone-name scanning and fixed thresholds may need device-specific tuning.
- What to inspect next:
  compare its direct grabbing with engine-level hand abstractions in Wave 147.

## Cross-project synthesis

- Strongest code donors:
  `marlon360/webxr-handtracking` and
  `rick98033/webxr-hand-tracking-websocket`.
- Strongest product references:
  `danielklinkhammer/webxr-quest2` and
  `TakashiYoshinaga/webxr-hand-tracking-sample`.
- Main reusable methods:
  joint stream abstraction, pinch hysteresis, fingertip raycasting, hand role
  split, pinch-midpoint object grabbing, and WebSocket hand-pose telemetry.

## Fit for `VR-apps-lab`

This wave strengthens hand-first utility patterns. Future overlay, browser,
or mixed-reality tools can use these methods for controllerless menus,
calibration gestures, diagnostics, annotation, and hand-pose export.
