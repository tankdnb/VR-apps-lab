# Wave 471: Device camera WebRTC AI and ROS operator surfaces

- Date: `2026-07-16`
- Scope: headset/device-camera samples, WebRTC signaling, multimodal AI camera
  queries, XREAL camera processing layers, and ROS operator surfaces that turn
  camera, audio, sensor, and robot state into in-headset panels.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `magicleap/MagicLeap2UnityWebRTCExample` | Studied | Unity/Magic Leap WebRTC camera streaming sample with signaling server and device/editor roles |
| `hyunaseo/OpenAI-for-Galaxy-XR` | Studied | Galaxy XR OpenXR/Android XR sample combining voice, egocentric camera frames, and OpenAI responses |
| `takatronix/xreal_ai_cam` | Studied | XREAL camera/image-processing prototype with raw and processed camera layers |
| `leggedrobotics/unity_ros_teleoperation` | Studied | Quest/OpenXR ROS teleoperation surface with camera, stereo, audio, hands, haptics, lidar, markers, TF, and VR streaming |

## Project notes

### `magicleap/MagicLeap2UnityWebRTCExample`

- Interesting idea: a device/editor WebRTC sample that streams RenderTexture or
  camera media between Magic Leap 2 and PC through a tiny Python signaling
  server.
- Code donor value: high as a readable camera/WebRTC split.
- Product reference value: high for camera relay, remote assistance, and
  operator preview tools.
- Source evidence: `README.md`, `Server/server.py`, `Assets/Scripts/*`,
  `Assets/Shaders/StrideAdjustmentShader.shader`, and package manifest.
- Reusable core: camera provider interface, WebCameraTexture/MLCamera choice,
  permission manager, microphone manager, WebRTC controller, server
  communication, login/offers/answers/ICE endpoints, world-space IP input UI,
  and troubleshooting labels.
- What not to copy: unauthenticated local signaling server, Bottle server
  sample, Magic Leap specific camera APIs, and demo-only network assumptions.
- What to inspect next: WebRTC state/error UI and whether the signaling
  contract should align with earlier telepresence relay methods.

### `hyunaseo/OpenAI-for-Galaxy-XR`

- Interesting idea: a Unity Android XR sample that combines microphone input,
  latest egocentric camera JPEG, and OpenAI realtime/responses output into an
  in-world assistant surface.
- Code donor value: medium to high as a multimodal capture/query boundary
  reference.
- Product reference value: high for assistive XR, visual QA, captioning, and
  "ask about what I see" utilities.
- Source evidence: `README.md`, `Assets/Scripts/OpenAIQueryVision.cs`,
  `StreamPassthrough.cs`, Android manifest notes, and prefab references.
- Reusable core: camera plugin bridge, latest JPEG retrieval, sample-image
  fallback, base64 data URL builder, microphone/realtime session, streamed
  audio callback, in-world text output, warning flags, and DrawPassThroughOnQuad
  preview.
- What not to copy: embedded API-key assumptions, cloud dependency without
  privacy gate, assistant persona prompt, and camera capture without explicit
  consent/status UI.
- What to inspect next: privacy labels, local/offline model fallback, and
  capture cadence throttling.

### `takatronix/xreal_ai_cam`

- Interesting idea: an XREAL/Unity camera prototype that separates raw camera
  layer, processed image layer, object-detection controller, and layer manager.
- Code donor value: medium; useful for UI/layer decomposition around device
  camera processing.
- Product reference value: medium to high for AR glasses visual assist tools.
- Source evidence: `README.md`, `Assets/Scenes/XREALRawCameraLayer.cs`,
  `XREALProcessedImageLayer.cs`, `XREALLayerManager.cs`, and
  `ObjectDetectionController.cs`.
- Reusable core: ARCameraManager frame subscription, XRCpuImage acquisition,
  YUV/texture update path, raw image layer, processed layer, processing type
  enum, alpha/toggle controls, AI processing interval, and detection display.
- What not to copy: placeholder AI processing, device-specific assumptions,
  generated/demo scene state, and unverified model-integration claims.
- What to inspect next: true XREAL device support boundaries and latency of CPU
  image conversion.

### `leggedrobotics/unity_ros_teleoperation`

- Interesting idea: a full Quest/OpenXR operator surface for ROS robots with
  camera viewers, stereo streams, audio, hands, haptics, lidar, markers, TF,
  VR streaming, and menu-based ROS endpoint connection.
- Code donor value: high as a modular operator-surface reference.
- Product reference value: high for robot/industrial XR tools.
- Source evidence: `README.md`, `Assets/RSL/Sensors/Camera`,
  `Assets/RSL/Sensors/Audio`, `Assets/RSL/Telemetry/Hands`,
  `Assets/RSL/Core/TF`, `Assets/Components/Menu`, and docs.
- Reusable core: ROS TCP endpoint boundary, ROS1/ROS2 switch, menu connection
  state, floating camera window, stereo per-eye camera rendering, audio
  stream, hand pose publishing, headset TF publisher, lidar/marker viewers,
  haptics, and VR view streamer.
- What not to copy: robot-specific ROS assumptions, Ubuntu/Unity version
  constraints, large Unity project bulk, and teleoperation without safety and
  authorization gates.
- What to inspect next: menu/schema boundaries for safe command authorization
  and sensor-panel layout.

## Reusable pattern extraction

- Pattern candidate: `Device-camera operator surface with capture, inference,
  transport, and status gates`.
- Problem solved: headset camera and robot/sensor utilities must separate frame
  capture, permission, transport, inference, display, and command surfaces.
- Reusable core: camera provider interface, permission gate, latest-frame cache,
  image encode path, transport/signaling or ROS endpoint, world-space preview,
  inference/query adapter, audio stream, sensor panels, connection state,
  warning/status labels, and privacy/safety boundaries.
- Source evidence: `MagicLeap2UnityWebRTCExample/Assets/Scripts/*`,
  `MagicLeap2UnityWebRTCExample/Server/server.py`,
  `OpenAI-for-Galaxy-XR/Assets/Scripts/OpenAIQueryVision.cs`,
  `xreal_ai_cam/Assets/Scenes/*`, and
  `unity_ros_teleoperation/README.md`.
- Abstraction boundary: keep device capture, transport, AI/vision processing,
  operator UI, and robot command adapters independent.
- What not to copy: unauthenticated signaling, cloud API calls without consent,
  device-specific camera code, and robot teleoperation commands without safety
  gates.
- Method catalog action: add `Method 916`.

## Why this matters for VR-apps-lab

This wave connects several active repo directions: passthrough/camera access,
remote assistance, AI vision helpers, and robot teleoperation. The reusable
lesson is to design camera/operator tools as gated, status-rich pipelines.

