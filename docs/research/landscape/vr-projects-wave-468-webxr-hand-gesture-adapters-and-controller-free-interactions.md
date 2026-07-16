# Wave 468: WebXR hand gesture adapters and controller-free interactions

- Date: `2026-07-16`
- Scope: WebXR and Quest hand-tracking projects that turn raw hand joints,
  pinch distances, and controller/hand mode switches into reusable interaction
  events for grabbing, dragging, stretching, teleporting, and VRTK-style input.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `rjimenezz/aframe-free-hands-component` | Studied | A-Frame hand-interaction library with pinch/point gestures, colliders, and semantic interactables |
| `FireDragonGameStudio/WebXR-DePanther-VRTK` | Studied | WebXR Export plus VRTK template with controller and hand gesture mappings |
| `FusedVR/Oculus-Quest-VRTK` | Studied as legacy comparison | Quest/VRTK bridge that maps hand pinches into controller-like buttons and axes |

## Project notes

### `rjimenezz/aframe-free-hands-component`

- Interesting idea: replace controller-oriented `super-hands` style reactions
  with bare-hand WebXR gestures while preserving declarative A-Frame attributes
  like `grabbable`, `hoverable`, `draggable`, `droppable`, and `stretchable`.
- Code donor value: high conceptually; `src/gestures`, `src/interactables`,
  `src/colliders`, and `src/utils` separate gesture sensing, collision math,
  and object reactions.
- Product reference value: high for browser XR utilities that need natural
  object manipulation without forcing controller hardware.
- Source evidence: `README.md`, `src/gestures/pinch-gesture.js`,
  `src/gestures/point-gesture.js`, `src/interactables/grabbable.js`,
  `src/interactables/stretchable.js`, and debug examples.
- Reusable core: hand joint pose sampling, pinch start/end hysteresis,
  point posture detection, hand collider entity, OBB/SAT collider choice,
  semantic gesture events, interactable attributes, debug visualizers, and
  declarative scene setup.
- What not to copy: typo-prone event/component names, debug console strings,
  demo videos/assets, and fixed pinch thresholds without per-device calibration
  labels.
- What to inspect next: how this pattern behaves with modern WebXR input
  profiles, accessibility affordances, and controller fallback.

### `FireDragonGameStudio/WebXR-DePanther-VRTK`

- Interesting idea: provide a WebXR/VRTK template where controllers and hand
  tracking can drive the same interaction stack, including grab, teleport,
  snap turn, warp, and visual state indicators.
- Code donor value: medium; the strongest value is the input-mapping pattern,
  not a polished reusable package.
- Product reference value: high as a practical hand/controller parity example
  for browser-exported Unity scenes.
- Source evidence: `README.md`, `Assets/Scripts/TeleporterIndicatorOffset.cs`,
  WebXR input profile sample scripts, and project action mappings.
- Reusable core: controller/hand mode switch, index pinch for grab, middle
  finger pinch for teleport aim/execute, pinky pinch for snap turn, interaction
  proxy cube near wrist/controller, state color coding, and threshold caveats.
- What not to copy: unmaintained sample assumptions, hard-coded gesture choices,
  and claims that every Tilia package works without per-package verification.
- What to inspect next: gesture action assets and threshold tuning files in a
  deeper pass if WebXR hand locomotion becomes a prototype target.

### `FusedVR/Oculus-Quest-VRTK`

- Interesting idea: abstract Quest hand tracking and Touch controllers behind
  one input manager that exposes controller-like `GetButton` and `GetAxis`
  calls to VRTK consumers.
- Code donor value: medium as a legacy adapter comparison; `HandSDK/Scripts`
  show the cleanest boundary.
- Product reference value: medium; useful for understanding how hand pinches
  can impersonate controller buttons for old interaction stacks.
- Source evidence: `README.md`, `Assets/HandSDK/Scripts/InputControl.cs`,
  `InputManager.cs`, `HandsController.cs`, `TouchControllers.cs`,
  `VRTKExample/Script/OVRButton.cs`, and `OVRAxis.cs`.
- Reusable core: active-controller detection, hand/controller visibility swap,
  pinch-to-button mapping, pinch strength to axis value, and adapter components
  that feed an existing toolkit.
- What not to copy: bundled old Oculus sample bulk, legacy VRTK assumptions,
  and OVR-specific offsets without OpenXR/XRI abstraction.
- What to inspect next: whether the active-input-mode adapter should be
  generalized into a provider-neutral method for controller/hand parity.

## Reusable pattern extraction

- Pattern candidate: `Hand gesture adapter layer for controller-free utility
  interactions`.
- Problem solved: hand tracking produces joints and confidence signals, while
  many utility scenes need semantic events such as grab, click, teleport,
  drag, and axis-like values.
- Reusable core: hand support gate, joint sampler, gesture detector,
  hysteresis thresholds, confidence labels, collider/proxy object, semantic
  event bridge, interactable reactions, controller fallback, debug indicators,
  and per-device caveats.
- Source evidence: `aframe-free-hands-component/src/gestures/*`,
  `aframe-free-hands-component/src/interactables/*`,
  `WebXR-DePanther-VRTK/README.md`, and
  `Oculus-Quest-VRTK/Assets/HandSDK/Scripts/*`.
- Abstraction boundary: keep raw hand data and gesture detection separate from
  object behavior, locomotion policy, and toolkit-specific adapters.
- What not to copy: one-size-fits-all thresholds, demo gestures that overload
  fingers, provider-specific controller names, and unlabelled tracking-quality
  assumptions.
- Method catalog action: add `Method 913`.

## Why this matters for VR-apps-lab

Many future utilities should work without controllers. This wave adds a
concrete adapter pattern for turning bare-hand input into reusable interaction
contracts while preserving fallback and confidence caveats.

