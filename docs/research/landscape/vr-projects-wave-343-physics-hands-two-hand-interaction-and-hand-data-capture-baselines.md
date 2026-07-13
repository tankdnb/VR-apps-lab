# Wave 343 - Physics Hands, Two-Hand Interaction, and Hand Data Capture Baselines

This wave studies hand-physics and two-hand interaction projects that expose
implementation seams for tactile manipulation, tool-like interactions, hand data
providers, and capture/playback.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to force/joint-driven hands, two-hand XRI interactions,
Unity XR Hands package boundaries, and WebXR hand prototype utilities.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `oxters168/VRPhysicsHands` | Unity/Oculus physics hand baseline | Studied | Source donor for fully physics-based hands controlled by forces/joints, input-to-bone abstraction, emulator, Oculus hand/touch input adapters, and grabber bridge |
| `emilyslouie/xri-two-hands` | XRI two-hand interaction prototypes | Studied | Product/code reference for dynamic attach points, multi-grabbable objects, bow and arrow, hockey/staff/stick interactions, pull measurement, and custom interaction manager concepts |
| `needle-mirror/com.unity.xr.hands` | Unity XR Hands package baseline | Studied | Strong package/API donor for cross-platform hand subsystem, OpenXR features, hand mesh data, gestures, capture recording, playback, and provider interfaces |
| `sketchpunklabs/xrhand` | WebXR/Three.js hand prototype lab | Studied | Browser reference for XR hand/controller managers, hand model prototypes, slide locomotion, debug surfaces, and lightweight WebXR hand experimentation |

## Code-Level Findings

### `oxters168/VRPhysicsHands`

- Interesting idea: tracked hands can be represented as physics bodies that
  follow input using forces and joints, letting the world affect the hands.
- Code donor value: high for physics-hand boundaries. The repo includes
  `BoneId`, `BonePart`, `HandBoneValues`, `IHandBoneManipulator`,
  `HandEmulator`, `HandEmulatorToGrabber`, `InterfaceSwitcher`,
  `OculusHandTrackingInput`, and `OculusTouchInput`.
- Product reference value: high for hand presence and tactile demos.
- What to inspect next: force tuning, joint stability, collision layers,
  object-grab bridge, editor tooling, and UnityHelpers/Oculus dependencies.
- Caveat: Oculus Quest hand tracking and external dependency specific.

### `emilyslouie/xri-two-hands`

- Interesting idea: two-hand objects are better treated as custom attach and
  constraint problems rather than ordinary single-hand grabs.
- Code donor value: medium-high. The project includes `CustomInteractionManager`,
  `ObjectManipulator`, `VirtualTransformChild`, bow/arrow/notch/quiver/pull
  scripts, staff/stick/cymbal/lawn tool prototypes, and multiple scenes showing
  dynamic attach points and multi-grabbable interactions.
- Product reference value: high for utility tools requiring two-hand operation.
- What to inspect next: primary/secondary grab role transitions, dynamic attach
  point math, bow string renderer, haptic/audio feedback, and asset/license
  provenance.
- Caveat: Hackweek prototype with large imported packages and asset-heavy
  content.

### `needle-mirror/com.unity.xr.hands`

- Interesting idea: hand tracking should expose both raw hand data and
  authoring/diagnostic tools: gestures, capture, playback, provider APIs, and
  OpenXR feature toggles.
- Code donor value: high as package boundary reference. It includes
  `XRHandSubsystem`, provider interfaces, `XRHandJoint`, mesh data, Meta aim
  state, processing utilities, skeleton driver, tracking events, common
  gestures, hand capture recording blobs, frame buffers, playback providers,
  time controllers, coordinate transforms, gesture editors, and OpenXR feature
  drawers.
- Product reference value: high for diagnostics and hand-input tooling.
- What to inspect next: capture file format, playback interpolation, provider
  implementation docs, motion-range feature, data-source feature, and gesture
  debugger UX.
- Caveat: mirrored Unity package; reuse should be conceptual and license aware.

### `sketchpunklabs/xrhand`

- Interesting idea: WebXR hand experiments benefit from a small library split
  around manager, input, controller, hand, locomotion, dynamic meshes, and
  prototype pages.
- Code donor value: medium. The repo includes `XRManager`, `XRInputManager`,
  `XRController`, `XRHand`, `XRSlideLocomotion`, dynamic point/line/mesh
  helpers, GLTF utilities, and prototype HTML pages for hand models and debug.
- Product reference value: medium for browser-native hand labs.
- What to inspect next: joint sampling, controller fallback, debug view,
  locomotion comfort, and Quest local dev workflow.
- Caveat: prototype-scale and browser/device support dependent.

## Reusable Pattern Extraction

- Pattern candidate: hand interaction and capture decomposition.
- Problem solved: hand utilities often mix raw tracking, physics following,
  gesture semantics, grab rules, two-hand constraints, and diagnostics.
- Reusable core: hand provider/subsystem, joint and mesh data model, pose
  validity, input adapter, bone manipulator, physics follower, collision/grab
  bridge, primary/secondary attach model, constraint/pull measurement, gesture
  authoring, hand capture recorder, playback/interpolation, coordinate
  transform, debug visualizer, and platform fallback labels.
- Source evidence: `oxters168/VRPhysicsHands`,
  `emilyslouie/xri-two-hands`, `needle-mirror/com.unity.xr.hands`, and
  `sketchpunklabs/xrhand`.
- Abstraction boundary: keep tracking source, hand representation, physical
  actuation, semantic interaction, two-hand object logic, capture/playback, and
  debug UI separate.
- What not to copy: vendor-only input assumptions, unstable force constants,
  imported asset/plugin blobs, gesture rules without recording evidence, or
  browser demos without capability checks.
- Method catalog action: add hand interaction/capture decomposition.

## Follow-Up Gaps

- Compare `com.unity.xr.hands` capture/playback with earlier gesture recorder
  and hand-data bridge waves.
- Extract a two-hand object checklist for tools, weapons, panels, sliders, and
  calibration handles.
- Build a physics-hand safety note around collision layers, force limits, and
  user comfort.
