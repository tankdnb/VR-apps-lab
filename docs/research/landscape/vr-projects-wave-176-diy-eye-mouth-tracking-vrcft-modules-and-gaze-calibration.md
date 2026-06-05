# VR Projects Wave 176: DIY Eye/Mouth Tracking, VRCFT Modules, and Gaze Calibration

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 176 studies the practical expression-tracking stack around VR utilities:
camera input, ROI processing, model inference, per-user calibration, OSC/VRCFT
output, in-headset routines, and OpenXR/engine-side eye consumers.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `Project-Babble/ProjectBabble` | DIY mouth tracking and expression OSC bridge | Strong pipeline donor with license caveats |
| `EyeTrackVR/EyeTrackVR` | DIY eye tracking and VRChat/VRCFT bridge | Strong pipeline and output donor |
| `cspark-development/VRCFaceTracking-TobiiXR` | Hardware SDK to VRCFT module | Strong module-boundary donor |
| `ryan9411vr/EyeTracking` | User-trained eye model plus VR target-acquisition helper | Strong workflow donor with build/data caveats |
| `Project-Babble/BabbleCalibration` | In-headset calibration routine runner | Strong calibration UX donor |
| `headassbtw/ResoniteOpenXREyeTracking` | OpenXR eye/face extension to Resonite input driver | Strong runtime-consumer donor |
| `edvardsoe/foveated-rendering-demo` | Gaze/foveation product reference | Source-light product reference |

## `Project-Babble/ProjectBabble`

- Interesting idea:
  use commodity cameras and a source-first desktop app to infer mouth
  expression values, calibrate them, smooth them, and publish them through OSC
  for social VR expression systems.
- Code donor value:
  high for camera ROI handling, ONNX provider setup, calibration/smoothing, and
  OSC expression emission.
- Product reference value:
  high for creator-operated face tracking where setup, preview, calibration,
  and output status must all be visible.
- What to inspect next:
  compare its mouth output schema with VRCFT blendshape preparation and
  avatar-parameter naming in earlier waves.
- Source evidence:
  `BabbleApp/babbleapp.py`, `BabbleApp/babble_processor.py`, and
  `BabbleApp/osc.py`.
- Reusable pattern extraction:
  source camera frame to expression vector to OSC bridge.
- Reusable core:
  load persisted config, select CPU/GPU ONNX providers, crop/rotate/flip camera
  frames, run model inference on a bounded queue, apply calibration and
  `OneEuroFilter` smoothing, publish normalized expression values under a
  configurable OSC path, and listen for recalibration commands.
- Do not copy directly:
  broad exception handling, hardware-specific defaults, or non-commercial code
  without license review.
- Caveats:
  useful as architecture and product reference; direct code reuse is constrained
  by license and hardware/model assumptions.

## `EyeTrackVR/EyeTrackVR`

- Interesting idea:
  provide an affordable eye-tracking stack that supports multiple eye
  algorithms, calibration states, preview/metrics, VRChat native eye output,
  VRCFT v1/v2 avatar parameters, and single-eye fallback.
- Code donor value:
  high for multi-algorithm per-eye processing, output-mode switching, latency
  metrics, and VRCFT/native schema mapping.
- Product reference value:
  high for DIY tracking apps where hardware setup, safety, algorithm choice,
  and avatar output must be made understandable.
- What to inspect next:
  extract a normalized comparison table for `DADDY`, `LEAP`, `HSF`, RANSAC,
  blink, and pupil-dilation flows.
- Source evidence:
  `EyeTrackApp/eye_processor.py`,
  `EyeTrackApp/osc/VRChatOSCSender.py`, and
  `EyeTrackApp/osc/VRCFTModuleMessenger.py`.
- Reusable pattern extraction:
  per-eye processing pipeline with multi-target output fan-out.
- Reusable core:
  keep per-eye capture state, support multiple pupil/eye algorithms, expose
  warmup and calibration gates, throttle previews, track output FPS/latency,
  switch between native VRChat eye vectors and VRCFT avatar parameters, and
  preserve single-eye operation when one eye is unavailable.
- Do not copy directly:
  hardware-specific safety assumptions or heavy model assets without reviewing
  license, calibration, and IR-safety implications.
- Caveats:
  good donor for pipeline structure; physical camera and IR safety concerns are
  part of the product, not optional documentation.

## `cspark-development/VRCFaceTracking-TobiiXR`

- Interesting idea:
  wrap the Tobii Stream Engine as a VRCFaceTracking module, including embedded
  native DLL extraction, update-thread subscription, validity checks, and
  mapping into VRCFT eye data.
- Code donor value:
  high for the hardware SDK wrapper and VRCFT module boundary.
- Product reference value:
  medium-high for device-specific tracking modules that should feel like
  installable adapters rather than full standalone apps.
- What to inspect next:
  compare with other VRCFT modules to define a common native-SDK packaging and
  teardown checklist.
- Source evidence:
  `ExternalTrackingModule.cs` and `DLLHandler.cs`.
- Reusable pattern extraction:
  hardware SDK to VRCFaceTracking module bridge.
- Reusable core:
  implement `ExtTrackingModule`, extract bundled native DLLs into a versioned
  temp folder, prepend the DLL path, create SDK/device contexts, subscribe to
  wearable consumer data on a worker thread, map normalized sensor values to
  VRCFT eyes, and unsubscribe/destroy/free contexts during teardown.
- Do not copy directly:
  hardcoded first-device assumptions or calibration constants without a
  user-visible calibration surface.
- Caveats:
  comments and structure suggest release/build fragility and race-risk areas;
  use as module-boundary lesson first.

## `ryan9411vr/EyeTracking`

- Interesting idea:
  split eye tracking into a desktop ML client, user-specific model training,
  OSC output modes, and a Unity VR target-acquisition helper for collecting
  gaze labels inside VR.
- Code donor value:
  high for the training/runtime split, TensorFlow.js inference service,
  openness calibration, and Unity-to-desktop WebSocket target feed.
- Product reference value:
  high for user-owned calibration workflows where the user collects training
  data in VR and then runs a personalized tracking model.
- What to inspect next:
  compare its data collection UX against `BabbleCalibration` routines and
  `EyeTrackVR` calibration states.
- Source evidence:
  `electron-react-app/src/services/trackingComputationService.ts`,
  `trackingTransmissionService.ts`, `OscSenderUtils.ts`,
  `opennessComputationService.ts`, `thetaService.ts`, and
  `VRTA/Assets/GazeTracker/GazeThetaDisplay.cs`.
- Reusable pattern extraction:
  in-headset target-acquisition helper plus desktop inference bridge.
- Reusable core:
  stream frames from cameras, reload TensorFlow models on config changes,
  process fresh left/right frames at a configured tracking rate, train open and
  closed eye classifiers, apply blink hysteresis and delay, normalize gaze
  output for VRChat native/VRCFT v1/v2, and receive target theta from a Unity
  WebSocket server during calibration.
- Do not copy directly:
  repo-specific training scripts, LFS/binary assumptions, or fragile source
  build steps without cleanup.
- Caveats:
  the study clone reported an LFS pointer warning for `websocket-sharp.dll`;
  treat binary/dependency state as caveat.

## `Project-Babble/BabbleCalibration`

- Interesting idea:
  run calibration as an in-headset routine system with OpenVR/OpenXR backend
  abstractions, TCP packets, reticle/gaze/dilation/convergence/debug routines,
  floor indicators, and start/end audio.
- Code donor value:
  high for backend abstraction, routine switching, and packet-driven
  calibration flow.
- Product reference value:
  high for any future tracking tool that should calibrate where the user is
  actually looking rather than only on a desktop monitor.
- What to inspect next:
  turn its routine taxonomy into a generic `calibration-routine-runner` note.
- Source evidence:
  `MainScene.cs`, `OpenVRBackend.cs`, and `OpenXRBackend.cs`.
- Reusable pattern extraction:
  backend-abstracted in-headset calibration routine runner.
- Reusable core:
  choose runtime backend by command line or platform heuristic, connect to a
  local companion over TCP, dispatch packets into routines, pool overlay/world
  elements, expose reticle/text/video/tutorial/graph/debug routines, and send a
  routine-finished packet to the desktop controller.
- Do not copy directly:
  incomplete OpenXR overlay backend or app-specific packet names without an
  explicit protocol contract.
- Caveats:
  strong calibration UX donor, but backend coverage is uneven.

## `headassbtw/ResoniteOpenXREyeTracking`

- Interesting idea:
  create a headless OpenXR session inside a Resonite mod, consume eye/face
  tracking extensions, and expose the result as a Resonite input driver.
- Code donor value:
  high for OpenXR extension setup, headless session use, action-space gaze
  fallback, and engine input mapping.
- Product reference value:
  high for runtime-side data consumers that bridge XR extension state into an
  engine without relying on per-world scripts.
- What to inspect next:
  compare with OpenXR API-layer eye/face adapters to decide when to consume
  extension data in-app versus at the runtime layer.
- Source evidence:
  `OpenXREyeTracking.cs`, `OpenXRInstance.cs`,
  `FacebookFaceTracking2.cs`, and `EyeGazeInteraction.cs`.
- Reusable pattern extraction:
  headless OpenXR extension consumer to engine input driver.
- Reusable core:
  register a custom input driver, enumerate required extensions, create an
  OpenXR instance/session with `XR_MND_headless`, prefer richer face-tracking
  extensions when available, fall back to eye-gaze action spaces, locate gaze
  spaces per frame, and map expression weights or poses into engine eye state.
- Do not copy directly:
  extension-specific assumptions or not-yet-implemented destruction paths.
- Caveats:
  README notes that `XR_EXT_eye_gaze_interaction` support is theoretical/not
  working in its target environment; treat fallback behavior cautiously.

## `edvardsoe/foveated-rendering-demo`

- Interesting idea:
  visualize gaze-driven foveated rendering behavior as a small product/demo
  concept.
- Code donor value:
  low in the inspected snapshot because it exposes README/LICENSE only.
- Product reference value:
  medium for communicating gaze/foveation value to non-engine users.
- What to inspect next:
  revisit only if a code-rich branch or related repository appears.
- Source evidence:
  README and repository structure.
- Reusable pattern extraction:
  source-light foveated rendering explainer/demo reference.
- Caveats:
  not a current code donor.

## Extracted Methods

- Source-first camera tracking pipeline:
  camera frames, ROI transforms, model/pupil inference, calibration, smoothing,
  and OSC output should be treated as separate observable stages.
- Multi-target eye/expression output bridge:
  one tracking source can fan out to VRChat native eye vectors, VRCFT v1/v2,
  OSC avatar parameters, and engine input drivers when schemas are explicit.
- In-headset calibration routine runner:
  calibration should be modeled as routines, backend adapters, packets, and
  completion events instead of one desktop-only settings panel.
- Headless OpenXR extension consumer:
  engine tools can consume eye/face extensions through a headless session and
  translate them into local input-driver data.

## Why This Matters For `VR-apps-lab`

This wave strengthens the repository's reusable tracking branch. It shows that
the valuable part is not just "eye tracking works"; the reusable knowledge is
the pipeline contract, output schema, calibration UX, and runtime-consumer
boundary.
