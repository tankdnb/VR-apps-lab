# VR Projects Wave 441: Body Face Hand Tracking and Avatar Motion Donor Stack

Date: 2026-07-13

Theme: tracking-provider, landmark, retargeting, and motion-prediction projects
that can inform future avatar, diagnostics, and accessibility helpers.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `oculus-samples/Unity-Movement` | Vendor body/face/eye tracking package | Code-level pass |
| `UPC-ViRVIG/MMVR` | HMD/controller to full-body motion prediction | Code-level pass |
| `TesseraktZero/UnityHandTrackingWithMediapipe` | Android MediaPipe hand landmark bridge | Code-level pass |
| `homuler/MediaPipeUnityPlugin` | General MediaPipe graph/task runner for Unity | Code-level pass |

## Project Notes

### `oculus-samples/Unity-Movement`

- Interesting idea: Meta package exposing body, eye, and face tracking through
  Unity/OpenXR-era Movement SDK samples and project setup tasks.
- Code donor value: useful donor for feature validation, retargeting setup,
  runtime fidelity/joint-set toggles, and sample UI that explains tracking
  modes.
- Product reference value: strong reference for a tracking diagnostics panel
  that tells the user which body/face/eye features are enabled, requested, and
  currently usable.
- Architecture pattern: package-level runtime/editor split with setup tasks,
  helper menus, retargeters, OVR body/fidelity toggles, character spawn menu,
  hip pinning calibration, and face/viseme mapping helpers.
- Reusable method: `tracking provider to avatar/motion pipeline`.
- UX/product lesson: tracking-heavy tools need visible setup validation and
  runtime toggles for fidelity, joint set, and animation state.
- Caveats: Oculus license and Meta SDK dependency; source is valuable as
  architecture evidence, not a copy-paste donor for generic OpenXR tools.
- Source evidence: README documents Body/Eye/Face Tracking requirements; 
  `MovementSDKProjectSetupTasks.cs` adds OVR project validation tasks;
  `MovementBodyTrackingFidelityToggle.cs`,
  `MovementBodyTrackingJointToggle.cs`, and `MovementCharacterSpawnMenu.cs`
  expose runtime tracking controls.
- Reusable core: feature setup checklist, permission/status validation, runtime
  mode toggles, retargeting component boundary, and tracking-status UI.
- What not to copy: vendor-specific SDK code, license-bound assets, or Meta-only
  assumptions as generic OpenXR behavior.
- Method catalog action: create tracking provider pipeline method.
- What to inspect next: exact retargeting data contracts and how confidence or
  missing joints are surfaced.

### `UPC-ViRVIG/MMVR`

- Interesting idea: combines motion matching with learned orientation prediction
  to animate avatars from consumer VR inputs rather than full mocap suits.
- Code donor value: strong donor for HMD/controller feature vectors, projected
  body direction, velocity smoothing, calibration, and separating training data
  from runtime prediction.
- Product reference value: confirms a future lab branch around "low-sensor avatar
  plausibility" for social, accessibility, and recording tools.
- Architecture pattern: Unity runtime controller plus Python training scripts;
  `VRDirectionPredictor` converts HMD/controller rotations, velocities, and
  angular velocities into normalized features for a Barracuda model.
- Reusable method: `low-sensor avatar motion inference pipeline`.
- UX/product lesson: full-body avatars from limited inputs need calibration and
  confidence framing because accuracy and visual plausibility are separate
  product goals.
- Caveats: academic/non-commercial license, Final IK dependency for some scenes,
  external datasets, and no runtime validation in this pass.
- Source evidence: README describes motion matching, orientation prediction,
  HMD/controller input, dataset/training flow, and Final IK caveats;
  `VRDirectionPredictor.cs`, `TrackersDataset.cs`, `PoseDataset.cs`, and
  `Calibrator.cs` show feature extraction, normalization, smoothing, and height
  calibration.
- Reusable core: tracker feature vector schema, HMD-projected heading,
  smoothed velocity/angular velocity, calibration button, model/data separation,
  and debug direction indicator.
- What not to copy: trained models/datasets without license review, Final IK
  integration, or paper-specific claims as general utility behavior.
- Method catalog action: create tracking provider pipeline method with
  prediction/motion-matching subpattern.
- What to inspect next: export a neutral "three tracked points to avatar state"
  schema for future comparisons.

### `TesseraktZero/UnityHandTrackingWithMediapipe`

- Interesting idea: Android MediaPipe app detects hand landmarks, streams them
  to PC Unity through ADB reverse TCP and protobuf, then maps landmarks to a
  rigged hand model.
- Code donor value: useful donor for landmark transport, phone-as-tracker
  architecture, result cache, Kalman filtering, wrist orientation estimation,
  and landmark-to-rig transform links.
- Product reference value: good reference for low-cost external camera/phone
  tracking companions where the VR app consumes a normalized landmark stream.
- Architecture pattern: Android sidecar app plus Unity socket receiver;
  `LandmarkSocket` starts ADB reverse forwarding, reads landmark types and
  protobuf messages, and updates `LandmarkResultSet`.
- Reusable method: `landmark sidecar to Unity rig bridge`.
- UX/product lesson: external tracking helpers need connection state, device
  selection, manual path overrides, and graceful stale-data behavior.
- Caveats: old Unity version, hard-coded ADB/app package names, thread aborts,
  and source launches the Android companion during normal use; research pass did
  not run anything.
- Source evidence: README documents Android MediaPipe detection plus ADB/protobuf
  transport; `LandmarkSocket.cs`, `LandmarkResultSet.cs`, `HandLandmark.cs`, and
  filter classes show socket ingress, landmark cache, wrist orientation, depth
  calibration, and Kalman smoothing.
- Reusable core: sidecar process label, landmark protobuf schema, per-hand cache,
  smoothing filter, transform-link adapter, connection status, and device/path
  configuration.
- What not to copy: hard-coded package name, `Thread.Abort`, auto-launch side
  effects, or sample avatar assets.
- Method catalog action: update tracking provider pipeline with sidecar/landmark
  transport details.
- What to inspect next: compare with WebSocket, UDP, OSC, and logcat landmark
  transport for latency and reliability.

### `homuler/MediaPipeUnityPlugin`

- Interesting idea: broad Unity native plugin that exposes MediaPipe tasks,
  calculator graphs, packets, GPU/CPU modes, and sample runners for hands, pose,
  face, object detection, segmentation, and audio classification.
- Code donor value: strong architecture donor for graph runner lifecycle,
  image-source abstraction, asset/resource management, CPU/GPU fallback, packet
  timestamping, and annotation controller boundaries.
- Product reference value: confirms that future VR tools can treat camera/vision
  inference as a provider with clear graph, model, and image source contracts.
- Architecture pattern: `Bootstrap` initializes logging, asset loader,
  inference mode, GPU resources, and image sources; `GraphRunner` owns graph
  initialization, packets, timestamps, stream outputs, and shutdown.
- Reusable method: `MediaPipe graph runner as tracking provider`.
- UX/product lesson: vision-based utilities should surface model/resource
  readiness and CPU/GPU fallback instead of hiding it inside scene scripts.
- Caveats: native plugin complexity, platform support matrix, GPU limitations on
  desktop, and required models/libraries are not included in a plain clone.
- Source evidence: README documents C# MediaPipe API, supported platforms and
  solutions; `Bootstrap.cs`, `AppSettings.cs`, `GraphRunner.cs`, and
  `PoseLandmarkerRunner.cs` show resource setup, image source construction,
  graph configuration, texture frame pools, and timestamped packet flow.
- Reusable core: provider lifecycle, image source abstraction, task/graph config,
  resource loader, inference mode label, packet timestamping, and output
  annotation boundary.
- What not to copy: native build system, bundled models, or plugin internals
  without platform/license review.
- Method catalog action: create tracking provider pipeline method with graph
  runner source evidence.
- What to inspect next: isolate a minimal provider interface usable by VR
  diagnostics and avatar tools without taking the full plugin.

## Reusable Pattern Extraction

- Pattern candidate: `tracking provider to avatar/motion pipeline`.
- Problem solved: VR utilities often need to combine headset/controller data,
  vendor tracking, camera landmarks, and avatar retargeting without coupling to
  one provider.
- Reusable core: provider label, timestamped samples, confidence/status flags,
  landmark/body schema, calibration, smoothing, retargeting boundary,
  prediction/model boundary, and visible diagnostics.
- Source evidence: Meta Movement setup/toggles, MMVR direction prediction,
  TesseraktZero ADB landmark bridge, and homuler MediaPipe graph runner.
- Abstraction boundary: provider ingestion and normalized tracking state are
  reusable; vendor SDK internals, licensed datasets, and sample avatars are not.

## Follow-Up Gaps

- Design a neutral tracking-provider schema for body, face, eye, hand, and
  low-sensor avatar motion donors.
- Compare sidecar transport options for landmark streams: ADB reverse TCP,
  WebSocket, OSC, UDP, gRPC, logcat, and shared memory.
