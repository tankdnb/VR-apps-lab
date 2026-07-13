# Wave 388: Quest Passthrough Camera Capture, Vision Streaming, and Detection Bridges

## Theme

Quest passthrough camera access as a utility substrate: local capture,
WebRTC/GPU offload, object detection, 3D bounding boxes, and spatial result
placement.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `samuelm2/OpenQuestCapture` | Studied | Quest camera capture and 3D reconstruction package with native camera library boundary |
| `danieloquelis/Unity-QuestVisionStream` | Studied | Unity package for Passthrough Camera API WebRTC streaming to external inference servers |
| `sandeepv6/questvision` | Studied | Quest 3 object detection and 3D bounding-box MR sample with server-side vision |

## Dedupe Notes

Official Meta camera API samples, `QuestCameraKit`, and `Unity-SpatialLingo`
were already covered in Waves 301-302. This wave studies adjacent community
projects that emphasize capture packaging, stream offload, and server/client
vision boundaries.

## Code-Level Findings

### `samuelm2/OpenQuestCapture`

- Interesting idea: package Quest camera access with Unity assets, a native
  camera library, docs, and a 3D reconstruction folder.
- Code donor value: `QuestCameraLib`, `quest-3d-reconstruction`, `Assets`,
  `docs`, `Packages`, and `rebuild_kotlin_library.ps1` show a native-library
  plus Unity wrapper envelope.
- Product reference value: useful for future camera capture utilities that need
  a clear native/Unity boundary and rebuild script provenance.
- What to inspect next: camera permission flow, Kotlin/native library API,
  reconstruction data format, and rebuild reproducibility.
- Caveat: native camera code must retain Android/Quest permission and platform
  guards.

### `danieloquelis/Unity-QuestVisionStream`

- Interesting idea: offload heavy vision by streaming Quest PCA frames over
  WebRTC to local/cloud GPU inference and returning results to Unity.
- Code donor value: `com.questvisionstream`, `QuestVisionStreamServer`,
  `webrtc_server.py`, `video_processor.py`, and package build scripts show a
  reusable package/server split.
- Product reference value: strong reference for keeping headset UX responsive
  while external machines run object detection or other CV models.
- What to inspect next: signaling schema, latency budget, reconnect state,
  frame metadata, and result transport back to Unity.
- Caveat: privacy, bandwidth, and cloud inference boundaries need explicit UI.

### `sandeepv6/questvision`

- Interesting idea: combine Quest camera, YOLO/Sentis-style detection,
  WebSocket server flow, 2D/3D boxes, and scene raycasts into a small MR vision
  app.
- Code donor value: `ObjectDetection`, `ObjectDetectionServer/server.py`, and
  README feature list show a headset app plus Python server boundary for
  detection and spatial anchoring.
- Product reference value: useful for future "detect and annotate real world"
  tools where labels must become spatial markers, not just screen overlays.
- What to inspect next: 3D box placement math, de-duplication, tracking
  confidence, and marker lifetime.
- Caveat: model/provider assumptions and camera privacy must not be hidden.

## Reusable Pattern Extraction

- Pattern candidate: Quest passthrough vision capture and inference bridge.
- Problem solved: MR vision tools need camera permissions, frame transport,
  inference offload, spatial projection, and privacy state as first-class
  pieces.
- Reusable core: camera wrapper, permission gate, native/library boundary,
  frame metadata, WebRTC/WebSocket transport, server processor, detection
  result schema, spatial raycast, marker/box lifetime, reconnect state, and
  privacy label.
- Source evidence: `QuestCameraLib`, `quest-3d-reconstruction`,
  `com.questvisionstream`, `QuestVisionStreamServer`, `webrtc_server.py`,
  `video_processor.py`, `ObjectDetection`, and `ObjectDetectionServer`.
- Abstraction boundary: camera capture and streaming should not own model
  choice, marker policy, or cloud-provider credentials.
- What not to copy: raw cloud streaming without consent UI, native binaries
  without rebuild provenance, or 2D detections without spatial reliability
  labels.
- Method catalog action: add Method 833.

## Family Placement

Creates a Quest passthrough vision bridge family. It overlaps with the existing
camera API families but captures community packaging/offload patterns.

## Follow-Up Gaps

- Draft a camera frame/result schema for Quest vision utilities.
- Compare WebRTC and WebSocket result loops for latency and privacy UX.
- Add a native-library provenance checklist for Quest camera wrappers.
