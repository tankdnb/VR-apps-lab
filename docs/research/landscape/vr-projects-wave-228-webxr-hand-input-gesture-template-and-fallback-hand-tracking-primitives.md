# VR Projects Wave 228: WebXR Hand Input, Gesture Templates, and Fallback Hand Tracking

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies small WebXR hand-input projects that expose reusable hand
utility primitives: pose templates, wrist-local gesture capture, pinch/palm
menu triggers, hand/controller pointer fallback, MediaPipe fallback, and WebXR
hand-input performance/privacy constraints.

## Why It Matters For `VR-apps-lab`

Future overlay windows, menus, diagnostics, accessibility tools, and creator
surfaces need hand input that is not bound to one demo scene. The reusable
boundary is:

- `hand source`: WebXR native hand, mechanical controller, MediaPipe, or
  simulator.
- `feature extraction`: joint vectors, wrist-local positions, palm orientation,
  pinch distance, or pose template score.
- `gesture state`: started, updated, ended, confidence, cooldown.
- `action sink`: menu open, pointer active, command event, object grab, or
  accessibility shortcut.
- `policy`: performance budget, sampling precision, privacy, and fallback
  behavior.

## Project Notes

### `stewdio/handy.js`

- Interesting idea:
  turn WebXR hand joints into a small pose-recognition layer attached to
  Three.js `renderer.xr.getHand()` objects.
- Code donor value:
  `src/Handy.js` keeps a `jointNames` table, injects helper methods with
  `makeHandy`, snapshots wrist/head-relative pose data, compares live joints
  against pose templates, sorts search results, and emits `pose began` /
  `pose ended` custom events.
- Product reference value:
  shows how a VR utility can treat gestures as named events instead of raw
  joint reads, which is useful for hand menus, overlay shortcuts, and
  accessibility commands.
- What to inspect next:
  compare threshold tuning, false positives, and temporal gestures against
  `martatesar/webxr-hands-gestures-recognition` and `XR Blocks`.
- Architecture pattern:
  pose-template matcher plus event stream over WebXR hand Object3Ds.
- Reusable method:
  bounded pose search; the source sets a small per-hand search duration budget
  so gesture matching does not silently consume the frame.
- Caveats:
  old browser/Quest assumptions, vendored Three.js, static pose templates, and
  no robust temporal gesture model.

### `stewdio/vr-hands`

- Interesting idea:
  early WebXR hand gestures directly drive visible scene actions such as fist,
  horns, and finger-gun behavior.
- Code donor value:
  the older `scripts/Handy.js` and `scripts/main.js` show direct use of
  `renderer.xr.getHand`, hand model factories, gesture event names, and
  gesture-to-action bindings.
- Product reference value:
  useful lineage for "gesture is the command surface" prototypes.
- What to inspect next:
  keep only as a comparison node for `handy.js`; do not build on it directly.
- Architecture pattern:
  prototype-level gesture detector wired straight into scene behavior.
- Caveats:
  the project is deprecated, uses older WebXR hand APIs, and is weaker as a
  donor than `handy.js`.

### `physicslibrary/Threejs-VR-Hand-Input`

- Interesting idea:
  tiny hand-input recipes are valuable: palm-up toggles, pinch distances, and
  wrist-relative checks can be reused faster than a full framework.
- Code donor value:
  the example HTML files and `OculusHandPointerModel` show `getHand`, joint
  reads such as `index-finger-tip` and `wrist`, and pinch/pointer threshold
  logic.
- Product reference value:
  good micro-reference for "open a menu when palm is up" or "activate pointer
  when thumb/index distance is below threshold".
- What to inspect next:
  compare with modern Three.js hand model factories and spec-compliant
  `XRHand` joint access.
- Architecture pattern:
  hand recipe examples rather than a library.
- Caveats:
  old Three.js/Oculus helper lineage and minimal packaging.

### `vrmeup/threejs-webxr-hands-example`

- Interesting idea:
  unify hand and mechanical controller input behind a pointer-like interaction
  layer.
- Code donor value:
  `xrInput.js` creates controllers and hand controllers, handles
  connect/disconnect, and routes to `xrHandControllerInput.js` or
  mechanical-controller modules. `xrGestureTracker.js` computes wrist
  quaternion, palm orientation, finger vectors, and index direction.
- Product reference value:
  strong reference for future utilities that should support both hands and
  controllers without duplicating menu or pointer code.
- What to inspect next:
  compare damped pointer smoothing against overlay menu raycasters and
  controller fallback patterns.
- Architecture pattern:
  input-source abstraction with damped hand pointer and pinch/palm gates.
- Caveats:
  demo-level code, narrow browser support notes, and no packaged API.

### `martatesar/webxr-hands-gestures-recognition`

- Interesting idea:
  an in-headset learner records wrist-local gesture templates and saves them as
  JSON, instead of requiring all gestures to be hand-authored in code.
- Code donor value:
  `HandGestureRecognition.ts` converts joints into wrist-local coordinates and
  compares them against template thresholds. `HandsGestureLearner.ts` captures
  template positions and uses the opposite hand pinch as a confirmation gate.
- Product reference value:
  useful UX pattern for user-defined hand shortcuts, accessibility gestures,
  and operator-specific menu commands.
- What to inspect next:
  add a better persistence and review surface around learned gestures before
  reusing the idea.
- Architecture pattern:
  wrist-local template recognizer plus learner/recorder helper.
- Caveats:
  demo ergonomics, typo-level roughness, console/download persistence, and no
  temporal gesture handling.

### `beemsoft/webxr-handtracking-playground`

- Interesting idea:
  the same scene can consume either native WebXR hand tracking or browser
  MediaPipe hand landmarks, which keeps desktop/browser study loops useful.
- Code donor value:
  `HandPoseManager` and physics variants render/update hand landmark meshes,
  detect open/stop-hand poses, and create Cannon/Ammo proxy interactions.
  `VrInitializer` and `WebXRManager` show the bridge into WebXR mode.
- Product reference value:
  good reference for diagnostic tools that need a desktop fallback before a
  headset session is available.
- What to inspect next:
  separate a neutral hand-source interface from demo physics and ball logic.
- Architecture pattern:
  dual hand-source pipeline with physics proxy joints.
- Caveats:
  mixed demo code, checked-in cert/assets, hand-authored thresholds, and
  physics coupling.

### `immersive-web/webxr-hand-input`

- Interesting idea:
  the hand-input explainer is a better boundary reference than many demos
  because it describes joint semantics, pose APIs, batch pose reads, and
  privacy tradeoffs.
- Code donor value:
  no product code donor, but the explainer defines the 25-joint model,
  `XRInputSource.hand`, `XRFrame.getJointPose`, `fillPoses`, and
  `fillJointRadii`.
- Product reference value:
  establishes constraints for any future hand input utility: performance,
  browser feature detection, sampling precision, and privacy.
- What to inspect next:
  compare current browser/runtime support against the explainer before any
  production-facing method is implemented.
- Architecture pattern:
  API/spec boundary reference.
- Caveats:
  not an app; use as governance and technical constraints, not as UI guidance.

## Reusable Pattern Extraction

- Pattern candidate:
  WebXR hand-pose template and gesture-event bridge.
- Problem solved:
  raw hand joints are too low-level for overlay/menu utilities and too costly
  to reason about repeatedly in product code.
- Reusable core:
  normalize source hand data, compute wrist-local or palm-relative features,
  compare against templates or simple thresholds, emit started/updated/ended
  gesture events, expose confidence or score, apply frame-budget limits, and
  document sampling/privacy policy.
- Source evidence:
  `stewdio/handy.js`, `martatesar/webxr-hands-gestures-recognition`,
  `vrmeup/threejs-webxr-hands-example`, `beemsoft/webxr-handtracking-playground`,
  and `immersive-web/webxr-hand-input`.
- Abstraction boundary:
  keep hand-source adapters separate from gesture recognizers and keep
  recognizers separate from action sinks such as menus, overlay windows, or
  object grabs.
- What not to copy:
  old WebXR helper APIs, vendored Three.js stacks, hardcoded thresholds,
  console-only persistence, and gesture data recording without privacy review.
- Method catalog action:
  add a new method entry for WebXR hand-pose template and gesture-event
  bridges.

## Follow-Up Gaps

- Build a hand-input matrix across template, threshold, palm, pinch, temporal,
  fallback, and privacy dimensions.
- Compare with `google/xrblocks` after Wave 231 because XR Blocks has a broader
  gesture subsystem.
- Extract a neutral command-event schema for future in-headset menu and overlay
  utility prototypes.
