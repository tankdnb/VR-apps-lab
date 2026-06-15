# Wave 302 - Quest Camera CV, Object Detection, Segmentation, and World Marker Pipelines

This wave studies Quest camera computer-vision projects as references for
object detection, OpenCV bridging, segmentation, Sentis scheduling,
environment-raycast marker placement, and debug/permission surfaces.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Quest passthrough camera to CV/inference pipelines;
- Sentis/YOLO object detection and segmentation loops;
- OpenCV/ArUco/ByteTrack style camera utilities;
- marker placement from detections into world space;
- overlap with Wave 301 only where camera wrapper lessons feed CV pipelines.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `demoPlz/Unity-MultiObjectDetection` | Quest camera object detection and marker placement | Studied with fork/commented-code caveats | Permission-aware menu, layer-per-frame Sentis scheduling, marker de-dupe, environment raycast placement, and recenter cleanup |
| `EnoxSoftware/QuestWithOpenCVForUnityExample` | Quest passthrough to OpenCV bridge | Studied with package/license caveats | MRUK passthrough to OpenCV `Mat`, calibration metadata, ArUco detection, YOLOX/Sentis toggles, ByteTrack, and debug controls |
| `rikturnbull/xr-image-segmentation` | Quest passthrough image segmentation prototype | Studied | Inference state machine, asynchronous output requests, reusable mask texture/display split, and segmentation UI layer |
| `oculus-samples/Unity-SpatialLingo` | Camera object classifier and taxon tracker overlap | Cross-wave reference from Wave 301 | Object classifier, face blur, taxon reliability, and camera detection to world-state pattern |

## Code-Level Findings

### `demoPlz/Unity-MultiObjectDetection`

- Interesting idea:
  object detection in MR should pause around user state, scene permissions, and
  previous inference completion before it places world markers.
- Code donor value:
  high with caveats. `DetectionManager.cs` waits for model load, checks
  `WebCamTexture`, shows an initial menu with scene permission status, gates
  inference when paused or a prior run is active, and uses the controller A
  button to spawn markers. Marker placement uses environment raycast hits,
  class/name plus distance de-duplication, and clears markers on display
  recenter. `SentisInferenceRunManager.cs` shows layer-per-frame scheduling,
  empty-tensor warm-up, separate output requests, confidence thresholds, and
  non-maximum suppression, though the inspected file included commented
  sections.
- Product reference value:
  high for detection overlays, object-label utilities, and camera-assisted
  spatial notes.
- What to inspect next:
  active branch/source state, model files, marker prefab lifecycle, scene
  permission UX, detection latency, false positive handling, and privacy copy.
- Reusable pattern extraction:
  gate camera inference by permission, app state, and previous inference
  completion, then place/de-dupe markers through an environment-raycast adapter.

### `EnoxSoftware/QuestWithOpenCVForUnityExample`

- Interesting idea:
  a strong Quest CV bridge exposes camera frames as OpenCV `Mat` objects along
  with pose, focal length, principal point, sensor size, and resolution metadata.
- Code donor value:
  very high conceptually, with package/license caveats. `QuestPassthrough2MatHelper.cs`
  wraps MRUK `PassthroughCameraAccess`, uses AsyncGPUReadback or a synchronous
  Texture2D path, converts camera textures to OpenCV matrices, and caches pose,
  intrinsics, sensor metadata, and resolution. `QuestArUcoExample.cs` exposes
  marker dictionary choices, smoothing, preview, low-pass/SOLVEPNP toggles,
  worker-thread copies, camera matrix/distortion coefficients, and AR-object
  cache behavior. `QuestMultiObjectTrackingExample.cs` combines OpenCV DNN
  YOLOX, optional Sentis backend, async inference, ByteTrack, model/class-file
  preparation, and FPS/debug text.
- Product reference value:
  very high for calibration-aware CV utilities, marker calibration, and object
  tracking workbenches.
- What to inspect next:
  OpenCVForUnity licensing, MRUK version dependency, camera calibration
  accuracy, threading costs, model loading, frame ownership, and package split.
- Reusable pattern extraction:
  make passthrough-to-CV conversion a first-class adapter that carries camera
  pose/intrinsics metadata with each frame.

### `rikturnbull/xr-image-segmentation`

- Interesting idea:
  segmentation pipelines are easier to reason about when inference execution,
  output readback, and mask display are separate components.
- Code donor value:
  high for prototype architecture. `IEPassthroughTrigger.cs` waits for model
  load, attaches the camera texture to a preview surface, and runs inference
  only when idle. `IEExecutor.cs` implements a visible state machine across
  running, output requests, success/error, cleanup, and completion while
  scheduling model layers over frames. `IEMasker.cs` creates/reuses mask
  RawImages and textures, clips masks to boxes, applies confidence thresholds,
  and hides unused masks.
- Product reference value:
  high for object-highlighting, scene understanding, and accessibility overlays
  that need segmentation masks instead of boxes.
- What to inspect next:
  mask texture churn, allocation profiling, camera privacy UI, color policy,
  model source, confidence calibration, and whether masks should be world
  anchored or screen-attached.
- Reusable pattern extraction:
  keep camera trigger, inference executor, output readback, and mask renderer
  separate so segmentation can feed either UI masks or world annotations.

### `oculus-samples/Unity-SpatialLingo`

- Interesting idea:
  object detection is more product-ready when it becomes a tracked semantic
  world entity rather than a raw bounding box.
- Code donor value:
  high as a cross-wave reference. `ImageObjectClassifier.cs` and
  `CameraTaxonTracker.cs` show model scheduling, class filtering, depth/raycast
  sampling, reliability scoring, and lifecycle events for detected taxa.
- Product reference value:
  very high for MR assistants and camera-aware labels.
- What to inspect next:
  model/runtime support, face blur defaults, taxonomy updates, and sample
  ownership.
- Reusable pattern extraction:
  route detection outputs through a reliability-aware world tracker before
  invoking UX or automation.

## Reusable Pattern Extraction

- Pattern candidate:
  Quest camera CV boundary across camera adapter, inference scheduler,
  detector/segmenter, world projection, marker/tracker state, and debug/privacy
  UI.
- Problem solved:
  camera CV demos often tangle permissions, frame conversion, model execution,
  output parsing, raycast projection, markers, and privacy. Reuse needs
  explicit layers and evidence for each transformation.
- Reusable core:
  camera frame adapter, intrinsics/pose metadata, inference idle gate,
  layer-per-frame scheduling, asynchronous output requests, confidence/NMS,
  detector or segmenter adapter, environment raycast, marker de-dupe, tracked
  taxon/reliability state, mask renderer, debug FPS/status, and privacy gate.
- Source evidence:
  `Unity-MultiObjectDetection`, `QuestWithOpenCVForUnityExample`,
  `xr-image-segmentation`, and `Unity-SpatialLingo`.
- Abstraction boundary:
  keep capture, frame metadata, inference execution, output parsing,
  world-placement, marker/tracker lifecycle, display, and privacy policy
  separate.
- What not to copy:
  inference loops without idle/backpressure gates, raw boxes without confidence
  or de-dupe, package-locked OpenCV code without license review, camera frames
  without intrinsics/pose metadata, or recognition features without consent and
  face/object privacy policy.
- Method catalog action:
  add a Quest camera CV and world-marker method.

## Follow-Up Gaps

- Deepen active source state for `Unity-MultiObjectDetection`; some inspected
  inference code was present as commented sections.
- Compare OpenCV, Sentis, and official Meta object-classifier approaches on
  frame format, scheduling, intrinsics, world projection, and debug UX.
- Build a detection/segmentation matrix covering object boxes, masks, ArUco/QR,
  world markers, tracked taxa, and privacy.
- Consider a reuse plan for a camera-CV diagnostic surface that can show frame,
  model state, inference latency, raycast hit, confidence, and marker lifecycle.
