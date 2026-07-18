# Wave 474: Quest camera CV inference and controller-defined visual search utilities

- Date: `2026-07-18`
- Scope: Quest/passthrough camera capture, controller-defined regions, CV/AI
  sidecars, detection polling endpoints, segmentation masks, and visual-search
  utility surfaces.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `daninloops/Quest3-Flask-Server-YOLO-Detection` | Studied | Minimal Flask + YOLO polling sidecar for latest bounding-box detection |
| `SemyanovVisuals/gigafind` | Studied | Quest 3 Unity client plus FastAPI/SAM2/Groq sidecar for controller-defined real-world object masks and descriptions |
| `imranbsh13/autosim-ai` | Lightly studied | Early Unity/Quest perception roadmap with synthetic data, YOLO, DeepLab, Sentis, and VR deployment phases |
| `WestCoastGod/XR-CV-Forceps-Tracking-Unity` | Comparison anchor | Existing studied camera/CV project used only to compare pose/marker tracking boundaries |

## Project notes

### `daninloops/Quest3-Flask-Server-YOLO-Detection`

- Interesting idea: a tiny desktop CV sidecar can keep a latest detection result
  in memory while a headset or companion polls a `/detection` JSON endpoint.
- Code donor value: medium as the smallest readable capture/inference/polling
  split.
- Product reference value: medium for quick visual target helpers or lab demos.
- Source evidence: `yolo_server.py`.
- Reusable core: webcam capture loop, background daemon thread, YOLO model
  inference, class/confidence filter, shared latest-result dictionary, JSON
  endpoint, and simple no-detection clear state.
- What not to copy: first-run model download at runtime, `cv2.imshow` inside
  the server loop, no locking around shared state, unauthenticated network
  endpoint, fixed camera index, fixed COCO class, and no privacy/status UI.
- What to inspect next: typed result schema, cadence throttling, queue/backlog
  behavior, and whether a Quest client consumes the endpoint.

### `SemyanovVisuals/gigafind`

- Interesting idea: a user can select an object by placing two VR controller
  corners over the real world, then send recent passthrough frames plus a 2D
  projected bounding box to a segmentation/LLM sidecar.
- Code donor value: high for controller-to-camera projection, batched frame
  upload, mask return, and in-VR result display.
- Product reference value: high for inspection, component identification,
  technical training, and accessibility visual-search tools.
- Source evidence: `README.md`, `client/Assets/Scripts/PassthroughCameraCapture.cs`,
  `SAM2Api.cs`, `AppManager.cs`, `server/api.py`, `seq_lib.py`, `llm_req.py`,
  and `types.py`.
- Reusable core: Quest passthrough camera manager, permission helper, camera
  intrinsics, controller world-to-camera projection, two-corner bbox, five-frame
  capture burst, `UnityWebRequest` multipart upload, bbox batch string, FastAPI
  `/boxes` endpoint, SAM2 batch predictor, best-mask selection, transparent PNG
  crop, LLM short description in response header, output canvas resize, and
  texture/text callback event.
- What not to copy: hard-coded LAN IP, hard-coded Groq API key, server-side
  y-offset patch, MPS/Mac-specific inference assumption, hotspot routing
  assumptions, unauthenticated upload endpoint, and cloud LLM use without
  consent.
- What to inspect next: calibration UI for 3D-to-2D offset, local/offline
  description fallback, request privacy labels, and stable segmentation result
  schema.

### `imranbsh13/autosim-ai`

- Interesting idea: a CV/VR project can be planned as a staged pipeline from
  Unity simulation to synthetic data, perception training, sensor fusion, ONNX
  or Sentis inference, and Quest deployment.
- Code donor value: low right now; the current source is mostly a Unity driving
  environment with XR input bindings and a roadmap.
- Product reference value: medium as a phased backlog for perception-heavy VR
  simulation tools.
- Source evidence: `README.md`, Unity project manifest/settings, XR input
  actions, and `MainDriving.unity`.
- Reusable core: phase checklist, Unity Perception target, YOLO/DeepLab target,
  camera and telemetry fusion plan, Sentis/ONNX deployment boundary, Quest/OpenXR
  target, and driving environment scene.
- What not to copy: claiming completed perception features before source-backed
  implementation, placeholder architecture/results, and asset/template bulk.
- What to inspect next: when Phase 2+ lands, inspect data export schemas,
  annotation formats, model runtime adapters, and VR telemetry surfaces.

### `WestCoastGod/XR-CV-Forceps-Tracking-Unity`

- Interesting idea: marker/forceps tracking remains a useful comparison anchor
  because it frames camera CV as tool-pose tracking rather than object
  segmentation or description.
- Code donor value: already covered in earlier camera/CV waves; no new registry
  entry added here.
- Product reference value: medium as a boundary comparison for medical/training
  visual tracking utilities.
- Source evidence: existing registry/family coverage and quick comparison to
  the Wave 474 projects.
- Reusable core: treat pose/tracker CV, object-detection CV, and
  controller-defined segmentation as separate result contracts.
- What not to copy: re-adding already studied repositories as new wave entries.
- What to inspect next: a unified CV result schema across bbox, mask, pose, and
  label outputs.

## Reusable pattern extraction

- Pattern candidate: `Controller-defined camera/CV inference sidecar and result
  surface`.
- Problem solved: Quest camera utilities need to let the user define what
  should be analyzed, send only bounded evidence to an inference sidecar, and
  display the result with clear privacy and calibration state.
- Reusable core: camera permission gate, camera intrinsics, controller-to-camera
  projection, region capture intent, recent-frame burst, encoded multipart
  upload, typed bbox/mask/label result, inference-sidecar status, confidence and
  calibration offset, in-headset texture/text panel, request throttling, and
  privacy/consent labels.
- Source evidence: `Quest3-Flask-Server-YOLO-Detection/yolo_server.py`,
  `gigafind/client/Assets/Scripts/*.cs`,
  `gigafind/server/api.py`, `gigafind/server/seq_lib.py`,
  `gigafind/server/llm_req.py`, and `autosim-ai/README.md`.
- Abstraction boundary: keep camera capture, region definition, transport,
  inference backend, result schema, and VR presentation independent.
- What not to copy: embedded keys, hard-coded IPs, unbounded camera uploads,
  unauthenticated endpoints, cloud inference without consent, and calibration
  offsets hidden in server code.
- Method catalog action: add `Method 919`.

## Why this matters for VR-apps-lab

This wave deepens the camera/operator line from Wave 471. It shows how future
visual-search utilities can be user-directed, region-bounded, and sidecar-based
instead of blindly streaming all camera data.
