# Wave 294 - WebXR Hand-Tracking Primitives, Emulation, MIDI, and Hand-Driven Utilities

This wave studies WebXR hand-tracking projects as reusable references for
gesture detection, worker-backed pose matching, webcam/head/hand emulation,
hand physics, hand-to-MIDI controls, palm menus, gaze tests, WebSocket relays,
and starter app structure.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- WebXR hand joints and gesture primitives;
- browser-native emulation and test harnesses;
- hand-driven utility controls, MIDI, menus, and physics;
- hand/gaze hybrid UX references;
- lightweight starters that clarify minimum viable WebXR hand structure.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `AdaRoseCannon/handy-work` | Worker-backed WebXR hand pose library | Studied | Pose registry, worker isolation, A-Frame controls, fuse timings, and magnetic hand helpers |
| `mrdoob/webxr-webcam-emulator` | Browser WebXR webcam emulator | Studied | Chrome extension polyfill emulating head/hand tracking via MediaPipe and storage-configured stereo toggle |
| `fcor/hand-tracking-butane` | WebXR hand physics interaction demo | Studied | Three.js hands, Cannon bodies, molecule/atom bodies, constraints, and hand-object collision model |
| `miguelppais/airbender-webxr-midi` | Hand-to-MIDI control surface | Studied | Spatial dual-hand controller UI for selecting MIDI output, channels, presets, and mapping controls |
| `RichardMeng1/custom-hand-gaze-webxr` | Hand/gaze experimental utility suite | Studied | Hand ordering, palm-up menu, poke interaction, gaze ray extraction, games, and WSS relay test |
| `tatta-chotdog/webxr-hands-starter` | Minimal WebXR hand starter | Studied | Controller/hand manager split and simple distance-threshold gesture classifier |

## Code-Level Findings

### `AdaRoseCannon/handy-work`

- Interesting idea:
  WebXR hand pose detection can be moved into a worker-backed, framework
  agnostic pose registry so the main render loop stays light.
- Code donor value:
  high. `handy-work` exposes `loadPose`, `getPose`, `setPose`,
  `generatePose`, and `update`; `handy-controls.js` adds WebXR
  `hand-tracking`, normalizes joints, handles controller fallback, and emits
  pose events with fuse timing; `magnet-helpers.js` adds constrained magnetic
  following primitives.
- Product reference value:
  very high for browser-native hand UI and gesture libraries.
- What to inspect next:
  worker message format, pose file schema, false positives, event names,
  A-Frame lifecycle cleanup, and pose authoring UX.

### `mrdoob/webxr-webcam-emulator`

- Interesting idea:
  WebXR hand/head tracking can be emulated in the browser using a Chrome
  extension, MediaPipe, and an injected polyfill.
- Code donor value:
  medium/high conceptually. `polyfill.js` defines WebXR hand joints, tracks
  head/hand state, initializes MediaPipe face/hand landmarkers, smooths
  position/depth, and listens for stereo config messages. `popup.js` stores
  enable/stereo toggles.
- Product reference value:
  very high for no-HMD/headsetless testing and WebXR developer utilities.
- What to inspect next:
  fidelity of XRFrame/XRHand emulation, permission prompts, camera privacy,
  extension injection constraints, and compatibility with real WebXR sessions.

### `fcor/hand-tracking-butane`

- Interesting idea:
  hand tracking can drive a physics world by mapping hand model children to
  kinematic physics bodies and colliding them with atoms/molecules.
- Code donor value:
  medium/high. `index.js` sets up Three.js WebXR hands, Cannon physics, static
  hand sphere bodies, atom bodies, distance constraints, and molecular
  visualization.
- Product reference value:
  high for hand-driven inspect/manipulate utilities and scientific models.
- What to inspect next:
  where hand body poses are synchronized each frame, interaction stability,
  physics scale, constraint tuning, and server/data endpoint assumptions.

### `miguelppais/airbender-webxr-midi`

- Interesting idea:
  bare hands can become a spatial MIDI control surface with headset-side
  preset and mapping UI.
- Code donor value:
  medium. `index.html` contains the whole product shell: MIDI output scan,
  channel selection, preset grid, hand mapping controls, LED status, and
  WebXR/MIDI import map.
- Product reference value:
  high for hand-to-command utilities, live performance tools, and control
  mapping panels.
- What to inspect next:
  hand gesture/mapping implementation later in the file, Web MIDI permission
  behavior on headset browsers, latency/backpressure, and safe MIDI range
  clamping.

### `RichardMeng1/custom-hand-gaze-webxr`

- Interesting idea:
  hand tracking, gaze rays, palm menus, small games, and local WSS relay tests
  can live as a compact browser-native experimental suite.
- Code donor value:
  high. `main.js` orders hands/controllers by handedness, wires Three.js hand
  models, palm menu, game menu, gaze games, and back button. `palm-menu.js`
  detects palm-up state, positions a canvas-textured panel above the palm, and
  uses right-index poke selection with cooldown. `eye-tracking.js` extracts
  gaze rays from `targetRaySpace`. `ws-server.js` shows a simple HTTPS/WSS
  broadcast relay.
- Product reference value:
  very high for hand/gaze utility UX and browser-native debug menus.
- What to inspect next:
  gesture robustness, canvas panel sizing, cleanup/dispose, WSS certificate
  flow, and whether Manifold-specific tests should become generic adapters.

### `tatta-chotdog/webxr-hands-starter`

- Interesting idea:
  a starter can teach the minimum viable split between scene, controllers, hand
  models, and gesture classification.
- Code donor value:
  medium. `ControllerManager.js` initializes controllers/grips/hands;
  `HandManager.js` reads WebXR joints, measures finger-to-wrist distances, and
  classifies simple rock/paper/scissors-like gestures.
- Product reference value:
  high for onboarding and small WebXR hand prototypes.
- What to inspect next:
  handedness/index mapping, thresholds per hand size, smoothing, visibility
  loss, and gesture schema extraction.

## Reusable Pattern Extraction

- Pattern candidate:
  WebXR hand utility boundary across joint sampling, gesture recognition,
  emulation, UI/menu actions, external control transport, and fallback.
- Problem solved:
  WebXR hand apps often mix rendering, recognition, interaction, and external
  side effects in one loop, making gestures hard to tune or reuse.
- Reusable core:
  XRHand joint sampler, pose registry, worker recognition, fuse/hysteresis
  timing, controller fallback, palm/wrist menu, poke/pinch actions, hand
  physics bodies, emulator/polyfill, Web MIDI/WebSocket output, and starter
  scene/controller/hand managers.
- Source evidence:
  `handy-work`, `webxr-webcam-emulator`, `hand-tracking-butane`,
  `airbender-webxr-midi`, `custom-hand-gaze-webxr`, and
  `webxr-hands-starter`.
- Abstraction boundary:
  keep hand data acquisition, recognition, interaction UI, emulation/testing,
  and external command transport separate.
- What not to copy:
  raw distance thresholds without calibration, camera-based emulation without
  privacy UI, hand-to-MIDI outputs without clamping/backpressure, hardcoded
  WSS certificates, or physics demos without scale/stability notes.
- Method catalog action:
  add a WebXR hand utility/emulation/control method.

## Follow-Up Gaps

- Build a WebXR hand utility matrix across joint sampling, gesture thresholds,
  pose files, workers, palm menus, emulators, Web MIDI, WebSocket, and privacy.
- Deepen `handy-work`, `webxr-webcam-emulator`, and
  `custom-hand-gaze-webxr` as strongest reusable donors.
- Compare with earlier WebXR hand/menu waves so hand input, menu UI, and
  transport patterns do not duplicate each other.
- Consider a future reuse plan for a browser-native hand debug panel with
  pose viewer, gesture events, emulation toggle, and command output adapters.
