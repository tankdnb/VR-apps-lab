# Wave 301 - Quest Passthrough Camera Wrappers, Permissions, Capture, and QR World Tracking

This wave studies Quest camera access projects as references for camera
permission gates, WebCamTexture/native capture wrappers, metadata exposure,
continuous/on-demand sessions, QR detection, world-raycast placement, and
camera observation tracking.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Quest passthrough camera wrappers and package boundaries;
- Android/HorizonOS camera permission and support gates;
- capture session, conversion, and metadata layers;
- QR/world marker tracking from camera frames;
- object/taxon tracking surfaces that bridge camera detections to MR world
  state.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `xrdevrob/QuestCameraKit` | Quest camera sample kit and marker utilities | Studied as sample/common-layer reference | Marker pooling and marker hide/update lifecycle for detected QR/world labels |
| `Uralstech/UXR.QuestCamera` | Native Quest camera wrapper package | Studied | Permission/support gates, Camera2 device discovery, session/converter split, metadata, and error taxonomy |
| `HoloLabInc/QuestCameraTools-Unity` | Quest camera tools, QR detection, and world tracking | Studied | WebCamTexture manager, cancellation-aware QR detection, environment raycast placement, filters, anchor selection, and tracking events |
| `oculus-samples/Unity-SpatialLingo` | Official camera/object/speech MR sample | Studied | Camera taxon tracker, reliability model, object classifier, face blur, and evented detection surfaces |

## Code-Level Findings

### `xrdevrob/QuestCameraKit`

- Interesting idea:
  camera detections become more usable when markers are pooled, updated, and
  hidden by recency instead of spawned/destroyed per frame.
- Code donor value:
  medium in this pass. `MarkerPool.cs` preallocates and reuses marker
  controllers. `MarkerController.cs` updates marker transform, scale, text, and
  visibility, then hides markers after a short idle timeout.
- Product reference value:
  high for QR/debug overlays, world labels, and camera-assisted utility demos.
- What to inspect next:
  QR detection sample scripts, camera permission flow, pose conversion, marker
  ownership, lost-marker state, and whether the sample exposes confidence or
  detection timestamps.
- Reusable pattern extraction:
  use a marker pool with update/lost state for camera detections rather than
  raw per-frame object creation.

### `Uralstech/UXR.QuestCamera`

- Interesting idea:
  Quest camera access should be a package boundary with explicit support
  checks, permission names, camera device discovery, sessions, converters,
  metadata, and error reporting.
- Code donor value:
  very high. `QuestCameraManager.cs` exposes HorizonOS/Quest support gates,
  `horizonos.permission.HEADSET_CAMERA`, `android.permission.CAMERA`, camera
  source/eye metadata keys, device discovery/cache/refresh, and pipeline
  creation. `CameraDevice.cs` wraps Android camera callbacks and names access,
  in-use, disabled, service, security, and illegal-argument errors.
  `ContinuousCaptureSession.cs` receives Y/U/V ByteBuffer pointers, row strides,
  pixel stride, and timestamps through a Java proxy, while `YUVConverter.cs`
  handles conversion boundaries.
- Product reference value:
  very high for Quest camera tools, camera diagnostics, and privacy-aware MR
  helpers.
- What to inspect next:
  native plugin implementation, on-demand session behavior, GPU converter
  costs, device close/reopen lifecycle, permission denial UI, and HorizonOS
  version compatibility.
- Reusable pattern extraction:
  keep permission/support checks, camera device discovery, capture session,
  pixel conversion, metadata, and errors as separate layers.

### `HoloLabInc/QuestCameraTools-Unity`

- Interesting idea:
  QR world tracking becomes reusable when detection, camera pose, environment
  raycasts, filtering, anchor selection, physical size, and lost/detected events
  are separate components.
- Code donor value:
  very high. `WebCamTextureManager.cs` wraps camera permission/support checks,
  wait-for-camera behavior, requested/highest resolution selection, and cleanup.
  `QuestQRTracking.cs` decodes frames on a cancellable loop and raycasts QR
  corners into the environment. `QRDetector.cs` and `QRTracker.cs` separate
  decode, target text, filters, anchor point, rotation constraints,
  scale-by-physical-size, and first/detected/lost callbacks.
- Product reference value:
  very high for camera-driven setup, world labels, calibration marks, and MR
  QR utilities.
- What to inspect next:
  permission UI, privacy messaging, tracking filters, multi-QR ownership,
  anchor persistence, raycast failure behavior, and camera-frame lifecycle.
- Reusable pattern extraction:
  treat QR tracking as decode -> raycast -> filter -> anchor/scale -> evented
  state, not as a monolithic camera script.

### `oculus-samples/Unity-SpatialLingo`

- Interesting idea:
  camera detections can be promoted into tracked world taxa with reliability,
  sample history, visibility rules, and add/update/remove events.
- Code donor value:
  high with official-sample caveats. `CameraTaxonTracker.cs` polls camera
  frames, runs `ImageObjectClassifier`, samples detection rectangles through
  depth/environment raycasts, merges tracked taxa, and emits lifecycle events.
  `CameraTrackedTaxon.cs` stores surface samples, extents, reliability score,
  observe/miss counts, timestamps, distance/angle visibility limits, and stale
  behavior. The object classifier package includes GPUCompute inference,
  layer-per-frame scheduling, class filtering, face detection, and face blur
  utilities.
- Product reference value:
  very high for MR assistants, world object labels, camera-aware captions, and
  privacy-sensitive object recognition.
- What to inspect next:
  package licenses, model provenance, classifier/runtime support, face blur
  privacy defaults, object taxonomy, confidence thresholds, and scene
  permission UX.
- Reusable pattern extraction:
  promote camera detections into an evented world-state tracker with reliability
  and sample history before driving UI or behavior.

## Reusable Pattern Extraction

- Pattern candidate:
  Quest camera utility boundary across permission/support gate, capture session,
  frame conversion, metadata, detection, world placement, and privacy.
- Problem solved:
  camera tools become fragile when permission checks, pixel buffers, detection,
  raycasts, markers, and user-facing state are mixed together.
- Reusable core:
  platform support check, headset/camera permissions, camera inventory,
  selected eye/source metadata, continuous/on-demand session, YUV/WebCamTexture
  conversion, frame timestamp, detection adapter, environment raycast, marker
  pool, QR/object tracker, reliability/lost state, debug UI, and privacy policy.
- Source evidence:
  `QuestCameraKit`, `UXR.QuestCamera`, `QuestCameraTools-Unity`, and
  `Unity-SpatialLingo`.
- Abstraction boundary:
  keep platform permissions, capture, conversion, detection, world placement,
  marker/tracker state, and UI/privacy separate.
- What not to copy:
  camera reads without visible consent, hardcoded resolution assumptions,
  detection UI without lost state, raycast placement without confidence,
  package-specific camera APIs hidden inside product logic, or face/object
  recognition without privacy controls.
- Method catalog action:
  add a Quest camera wrapper and world-tracking method.

## Follow-Up Gaps

- Deepen `UXR.QuestCamera`, `QuestCameraTools-Unity`, and `Unity-SpatialLingo`
  as strongest donors.
- Compare camera-frame wrappers across Meta samples, Uralstech, HoloLab, and
  older passthrough/camera waves.
- Build a matrix for camera utilities: permission, camera source, frame format,
  conversion, metadata, detection, raycast placement, privacy, and debug UI.
- Consider a reuse plan for a Quest camera diagnostic/marker toolkit.
