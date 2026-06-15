# Wave 298 - OpenXR/Unity Hand Gesture Recognition, Sign Learning, and Hand Data Bridges

This wave studies Unity/OpenXR hand tracking projects that turn hand joints or
hand-shape samples into gesture recognition, sign-learning feedback, controller
substitution, teleoperation data streams, and reusable debug/recording tools.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Unity XR Hands gesture datasets and recognizers;
- editor gesture recording/training tools;
- static and dynamic gesture classification;
- sign-language learning prototypes;
- hand-to-controller adaptation;
- hand-joint transport for remote/robot control.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `HankunYu/Kuji-Kiri` | Unity XR Hands gesture recognition package | Studied | Strong donor for hand snapshots, feature extraction, MLP static classifier, DTW dynamic recognizer, state machine, and editor training tools |
| `Phlegmati/SimpleGestureRecorder` | Unity XR Hands gesture recording/debug tool | Studied | Minimal editor recorder for XRHandShape assets, distance debug, combo detection, and screenshot capture |
| `TF-polygon/XR-SignQuest` | VR ASL/sign-learning app | Studied with asset/model caveats | Product reference for mirror-camera YOLO/ONNX sign feedback, confidence color, and VR memory constraints |
| `ariesiitr/Hand-Tracking-VR` | Unitypackage hand-tracking demo | Source-light/package reference | README and package artifact reference for controller-free hand interaction |
| `Vin-meido/COM3D25_OpenXRHandsPOC` | OpenXR hands to legacy controller/game input POC | Studied | Hand tracking controller adapter, InputAction filters, One Euro smoothing, and asset-bundle/sample caveats |
| `ARCLab-MIT/BeaVR-app` | Quest hand tracking to robot teleoperation | Studied | XR Hands joint streaming over NetMQ, in-VR IP setup, pinch toggles, camera/graph streams, and OpenXR/OVR comparison notes |

## Code-Level Findings

### `HankunYu/Kuji-Kiri`

- Interesting idea:
  hand gesture recognition can be packaged as a full pipeline: XRHand sample,
  wrist-local normalized snapshot, feature vector, classifier/DTW recognizer,
  confidence threshold, state machine, and editor dataset/training workflow.
- Code donor value:
  very high. `HandFeatureExtractor.cs` transforms joints into wrist-local
  pose data. `StaticGestureRecognizer.cs` uses MLP probabilities and
  thresholds. `DynamicGestureRecognizer.cs` uses a sliding window, LB Keogh,
  DTW, and distance-to-confidence conversion. `GestureStateMachine.cs` adds
  detect/hold/release/cooldown transitions. `MlpTrainer.cs` gives dataset,
  validation, loss, accuracy, learning-rate, and early-stop structure.
- Product reference value:
  very high for gesture-driven utilities and training/debug apps.
- What to inspect next:
  dataset JSON schema, runtime sample rate, left/right normalization, gesture
  studio UX, model asset versioning, and calibration for different hand sizes.

### `Phlegmati/SimpleGestureRecorder`

- Interesting idea:
  a small editor-facing recorder can make XRHandShape assets and gesture
  debugging approachable without a complete ML pipeline.
- Code donor value:
  high as a micro-tool. `GestureRecorder.cs` records finger shape data over a
  timed window, creates `XRHandShape` assets, captures screenshots, and saves
  assets. `SimpleGesture.cs` subscribes to `jointsUpdated` and checks hand
  shape/pose conditions with interval and hold-time gates.
  `DistanceBetweenJoints.cs` and visual debug scripts help tune thresholds.
- Product reference value:
  high for gesture authoring and QA tooling.
- What to inspect next:
  generated asset schema, combo detector, screenshot naming, editor-only
  boundaries, and how to compare recorded gestures across users.

### `TF-polygon/XR-SignQuest`

- Interesting idea:
  a sign-learning VR app can use a virtual mirror as the feedback surface:
  capture hand view, run YOLO/ONNX inference, draw bounding boxes/confidence,
  and reward clean signs with simple color changes.
- Code donor value:
  medium with asset/model caveats. The README and visible scripts indicate a
  Barracuda/ONNX pipeline, RenderTexture to Texture2D to Tensor conversion,
  candidate decoding, NMS, confidence thresholds, and logging/export scripts,
  but the repo is model/asset-heavy.
- Product reference value:
  very high for learning UX and immediate corrective feedback.
- What to inspect next:
  `InferenceViewer.cs`, model ownership/license, tensor allocation discipline,
  frame-rate impact, sequence gestures, and accessibility of sign training.

### `ariesiitr/Hand-Tracking-VR`

- Interesting idea:
  unitypackage-only repos can still mark a common product direction:
  controller-free grab/pinch/point demos packaged for learners.
- Code donor value:
  low in this pass because source is packaged rather than directly visible.
- Product reference value:
  medium as a learning/demo marker.
- What to inspect next:
  unpacked package contents, license, exact scripts/prefabs, and whether any
  gesture thresholds are reusable.

### `Vin-meido/COM3D25_OpenXRHandsPOC`

- Interesting idea:
  hand tracking can be adapted into a legacy game/controller API by filtering
  OpenXR hand inputs into virtual button states and smoothed positions.
- Code donor value:
  medium/high. `HandTrackingController.cs` maps XR hand device bindings to
  primary/grip/trigger-like actions through short/long/passthrough filters.
  `OneEuroFilterVector3.cs` provides configurable jitter smoothing.
- Product reference value:
  high for retrofit/control adapter experiments.
- What to inspect next:
  device binding stability, action filter edge cases, patching risks,
  hand pose fidelity, asset-bundle/sample dependencies, and game-specific
  coupling.

### `ARCLab-MIT/BeaVR-app`

- Interesting idea:
  hand tracking can be treated as a transport payload: ordered 26-joint
  vectors, pinch/status channels, and network streams to a robot/server.
- Code donor value:
  high for transport boundaries. `GestureDetectorXR.cs` defines XR Hands joint
  order, serializes left/right hand vectors, sends absolute/relative data,
  handles left-hand pinch toggles, and logs tracked counts. `NetMQController.cs`
  creates named sockets, reconnects after failures, sends with short timeouts,
  and cleans up. `NetworkManager.cs` loads IP/port config and in-headset
  PlayerPrefs overrides.
- Product reference value:
  high for teleoperation, hand-data bridges, and in-VR network setup.
- What to inspect next:
  server receiver protocol, coordinate frames, security, stale data handling,
  calibration, robot-side safety gates, and jitter/packet loss handling.

## Reusable Pattern Extraction

- Pattern candidate:
  Unity/OpenXR hand gesture boundary across joint sampling, normalization,
  recording, recognition, state transitions, feedback, and output transport.
- Problem solved:
  hand input is noisy and easy to bake into scenes. Reuse needs a clear path
  from raw joints to stable events or external data without hiding thresholds,
  models, or confidence.
- Reusable core:
  XRHandSubsystem source, ordered joint schema, wrist-local snapshots,
  feature vectors, static classifier, dynamic DTW window, gesture state machine,
  hold/cooldown gates, editor recorder, visual threshold debugger, sign-learning
  feedback surface, One Euro smoothing, command filters, and network packet
  schema.
- Source evidence:
  `Kuji-Kiri`, `SimpleGestureRecorder`, `XR-SignQuest`,
  `COM3D25_OpenXRHandsPOC`, and `BeaVR-app`.
- Abstraction boundary:
  keep joint acquisition, normalization, training/recording, recognition,
  gesture state, UI feedback, and side effects or transport separate.
- What not to copy:
  fixed distance thresholds without calibration, packaged assets as source
  evidence, per-frame tensor allocations without profiling, hand-to-controller
  patching without user opt-in, or robot/OSC output without stale gates and
  safety validation.
- Method catalog action:
  add an OpenXR/Unity hand gesture recognition and hand-data bridge method.

## Follow-Up Gaps

- Build a comparison matrix across XRHandShape recorders, MLP classifiers, DTW
  recognizers, mirror-camera inference, controller adapters, and joint streams.
- Deepen `Kuji-Kiri`, `SimpleGestureRecorder`, and `BeaVR-app` as strongest
  code donors.
- Compare this wave with WebXR hand waves so browser and Unity hand pipelines
  share vocabulary without merging runtime-specific details.
- Consider a future reuse plan for a hand gesture utility kit: recorder,
  dataset schema, recognizer adapters, debug panels, confidence display, and
  output clamps.
