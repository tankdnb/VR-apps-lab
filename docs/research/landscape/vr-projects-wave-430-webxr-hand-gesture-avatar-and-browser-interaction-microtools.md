# VR Projects Wave 430: WebXR Hand Gesture, Avatar, and Browser Interaction Microtools

Date: 2026-07-13

Theme: browser-first WebXR experiments that use hand joints, gesture recognition,
avatar hand model adapters, and direct hand interaction as reusable UX references.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `AlbertoElias/webxr-hand-tracking` | WebXR hand avatar/model harness | Code-level pass |
| `kimbanica/aframe-libras` | WebXR gesture trainer | Code-level pass |
| `Phocidae-dev/Kinetic-Swarm` | WebXR hand interaction microgame | Code-level pass |

## Cross-Project Synthesis

This wave shows three useful WebXR hand patterns. `webxr-hand-tracking` is a
model-adapter harness: it compares different hand/avatar renderers and lets the
user switch them with pinch events. `aframe-libras` is a gesture trainer: it
checks browser XR support, renders hand joint markers, compares thumb/index
distance, and requires a dwell time before accepting the gesture. `Kinetic-Swarm`
is an interaction playground: it uses hand state and motion to control a swarm of
orbs through lift, freeze, push, pull, draw, and orbit-like interactions.

The reusable lesson is that WebXR hand tooling should expose both the raw joint
debug story and the user-facing gesture affordance. A lab-quality hand tool needs
capability checks, visible target gestures, confidence/dwell rules, and a way to
compare render/input models.

## Project Notes

### `AlbertoElias/webxr-hand-tracking`

- Interesting idea: a small WebXR harness for switching between multiple hand and
  avatar model systems.
- Code donor value: three.js WebXR setup, controller fallback rays,
  `renderer.xr.getHand`, avatar model factory, and pinch-driven model switching.
- Product reference value: useful for validating hand visual styles before
  committing to one avatar representation.
- Architecture pattern: WebXR scene shell plus hand model adapter factory.
- Reusable method: `WebXR hand/avatar adapter harness`.
- UX/product lesson: pinch-to-cycle is a compact in-headset debug affordance for
  comparing hand model variants.
- Caveats: demo-scale app, limited documentation, no calibration or performance
  instrumentation.
- Source evidence: `main.js` defines `HAND_TYPES`, creates hand and controller
  objects, calls `XRAvatarModelFactory.createAvatarModel`, and toggles visibility
  on `pinchend`.
- Reusable core: WebXR hand acquisition, model adapter interface, paired left/right
  hand switching, controller fallback visualization.
- What not to copy: hard-coded model list without capability or asset provenance.
- Method catalog action: update WebXR hand tooling method.
- What to inspect next: whether a generic hand-model comparison harness belongs
  in VR-apps-lab as a browser sample.

### `kimbanica/aframe-libras`

- Interesting idea: a WebXR/A-Frame gesture trainer for a hand-sign gesture with
  visible joint markers and dwell-based acceptance.
- Code donor value: `navigator.xr` capability checks, `hand-tracking-controls`,
  full WebXR joint list, `getPose` joint sampling, marker visualization, and a
  thumb-tip/index-tip distance threshold with hold duration.
- Product reference value: strong reference for accessible hand-training flows,
  tutorial gestures, and in-headset skill practice.
- Architecture pattern: single A-Frame scene plus a custom `trainer-pincha`
  component.
- Reusable method: `WebXR gesture trainer with target pose and dwell threshold`.
- UX/product lesson: show capability status, target gesture, live progress, and
  joint markers so the user understands why recognition succeeds or fails.
- Caveats: one right-hand gesture, fixed threshold, CDN runtime, and no
  per-user calibration.
- Source evidence: `index.html` checks `isSessionSupported('immersive-vr')`,
  creates left/right `hand-tracking-controls`, samples WebXR joints, and validates
  a PINCA gesture after roughly 500 ms under the distance threshold.
- Reusable core: capability gate, joint marker layer, target pose, threshold,
  dwell timer, progress feedback.
- What not to copy: single-language assumptions, magic distance constants, and
  uncalibrated one-hand-only recognition.
- Method catalog action: update WebXR hand tooling method.
- What to inspect next: extend the pattern to multi-gesture sets, calibration, and
  confidence scoring.

### `Phocidae-dev/Kinetic-Swarm`

- Interesting idea: a WebXR hand interaction microgame where gestures control a
  swarm of animated orbs.
- Code donor value: browser-first scene shell, gesture hint layer, hand-state
  processor, orb state machine, cooldown rules, and many hand-to-motion mappings.
- Product reference value: useful for direct-manipulation VR UX: lift, freeze,
  push, pull, explode, draw-to-joints, and orbit shaping.
- Architecture pattern: single-file WebXR/three.js experiment with config-driven
  orb physics and gesture state.
- Reusable method: `hand-driven spatial object control lab`.
- UX/product lesson: gesture grids and live hints help a playful WebXR experiment
  become learnable instead of mysterious.
- Caveats: hackathon-style single file, broad gesture set, emoji-rich UI, and no
  formal gesture confidence model.
- Source evidence: `index.html` advertises lift/freeze/size gestures, processes
  `session.inputSources`, tracks handedness, moves orbs through states such as
  `orbiting`, `drawing`, `frozen`, `pushed`, and `exploded`, and applies gesture
  cooldowns.
- Reusable core: hand-state processor, object state machine, gesture cooldown,
  visual hint grid, and spatial feedback.
- What not to copy: monolithic single-file structure or gesture magic numbers
  without calibration.
- Method catalog action: update WebXR hand tooling method.
- What to inspect next: extract a clean hand-gesture state machine from a similar
  project with tests or modular files.

## Reusable Pattern Extraction

- Pattern candidate: `WebXR hand interaction lab`.
- Problem solved: hand-tracking apps need a way to inspect raw joints, teach
  gestures, compare hand rendering, and validate direct manipulation mechanics.
- Reusable core: capability checks, hand/controller fallback, joint sampling,
  visible markers, target gesture, dwell/cooldown logic, model adapter, gesture
  hint layer, and object state machine.
- Source evidence: `webxr-hand-tracking` supplies avatar adapter switching,
  `aframe-libras` supplies joint/dwell training, and `Kinetic-Swarm` supplies
  direct manipulation gesture loops.
- Abstraction boundary: gesture definitions and adapters are reusable; demo assets,
  CDN choices, and magic thresholds should be replaceable.
- Method catalog action: add/update WebXR hand gesture/avatar lab method.

## Follow-Up Gaps

- Find WebXR hand projects with modular gesture classifiers or calibration files.
- Compare A-Frame hand controls, three.js hand models, Babylon.js hand meshes, and
  native Quest hand streams.
- Define a minimal VR-apps-lab browser sample for hand-joint visualization and
  gesture threshold tuning.
