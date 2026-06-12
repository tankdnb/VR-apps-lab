# Wave 279 - Remote, Cloud, WebRTC VR Streaming, and Live SDK Surfaces

This wave studies VR streaming and live-viewing projects across legacy LAN
remote rendering, Unity-hosted WebRTC, Quest video receivers, streaming SDKs,
and cloud live-session control planes.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- sensor/input uplink and rendered-frame downlink;
- Unity WebRTC video tracks and signaling servers;
- Quest-side video receiver textures and frame queues;
- SDK-style setup, backend abstractions, and streaming config;
- source-light streaming/product references with clear caveats.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `PierfrancescoSoffritti/RemoteVR_UnityServer` | Legacy remote VR Unity server | Studied with caveats | TCP/UDP server, gyro/touch input, rendered image output |
| `PierfrancescoSoffritti/RemoteVR_AndroidClient` | Legacy remote VR Android client | Studied with caveats | Calibrated gyro quaternion and UDP image/input packets |
| `TheAnonymousMan/WebRTC-VR-Server` | Unity-hosted WebRTC server | Studied | In-Unity WebSocket signaling, camera track, data channel |
| `GitEducaverse2024/com.educa360.live` | Unity live-streaming SDK | Studied | Config asset, backend abstraction, setup wizard, Quest capture workaround |
| `shinyoshiaki/quest-view` | Quest WebRTC video receiver | Studied with caveats | WebSocket signaling, I420-to-texture conversion, frame queue |
| `jlin3/substream-sdk` | Cloud streaming SDK/control plane | Studied with scope caveats | IVS stage allocation, auth, WHIP, webhooks, Unity streaming scripts |
| `kasimmj/vrcollab` | VR collaboration server reference | Source-light architecture reference | Pose-frame protocol, SFU/product architecture claims |
| `jakubtom/UnityRenderStreaming_StereoWebcam` | Stereo webcam streaming concept | README-only reference | Side-by-side camera stream through Unity Render Streaming |

## Code-Level Findings

### `PierfrancescoSoffritti/RemoteVR_UnityServer`

- Interesting idea:
  a Unity server receives phone gyro/touch input and streams rendered camera
  images back to a remote Android VR client.
- Code donor value:
  useful legacy protocol donor: TCP/UDP server abstraction, per-client player
  objects, initial gyro offset, remote touch flag, client resolution
  negotiation, and per-frame image output.
- Product reference value:
  good reference for the old "phone as headset input plus remote render"
  architecture.
- What to inspect next:
  serialization format, image compression, disconnect behavior, and replacement
  with WebRTC or a modern transport.
- Reusable pattern:
  sensor uplink plus rendered-frame downlink.
- Caveats:
  no auth/encryption, thread and collection-safety concerns, heavy image
  serialization, LAN assumptions, and old code.

### `PierfrancescoSoffritti/RemoteVR_AndroidClient`

- Interesting idea:
  the Android counterpart sends calibrated gyroscope quaternions and touch
  events while receiving server images over UDP.
- Code donor value:
  useful low-level reference for byte-buffer input packets, UDP session init,
  screen-resolution handshake, and quaternion integration from gyroscope delta.
- Product reference value:
  good historical reference for remote-phone VR clients.
- What to inspect next:
  packet loss behavior, timestamping, orientation drift, and a safer modern
  WebRTC equivalent.
- Reusable pattern:
  mobile sensor client for remote VR.
- Caveats:
  no reliability/quality control, old Android stack, no security, and LAN-only
  framing.

### `TheAnonymousMan/WebRTC-VR-Server`

- Interesting idea:
  Unity hosts its own WebSocket signaling server and WebRTC peer connection,
  then streams a camera track and opens a data channel without an external
  Node service.
- Code donor value:
  strong compact donor for `WebRTC.Update`, `RTCPeerConnection`, video
  transceiver setup, buffered ICE candidates, answer creation, WebSocketSharp
  session broadcast, main-thread coroutine dispatch, and queued data messages.
- Product reference value:
  good reference for a small self-contained "stream a Unity camera to browser"
  or operator dashboard.
- What to inspect next:
  multi-peer state, auth/TLS, resolution/config UI, and browser receiver.
- Reusable pattern:
  Unity-hosted WebRTC signaling and camera stream.
- Caveats:
  fixed port/resolution/STUN, no auth/TLS, broadcasted candidates, and likely
  single-peer assumptions.

### `GitEducaverse2024/com.educa360.live`

- Interesting idea:
  a Unity package exposes live streaming as an SDK with config assets, a setup
  wizard, backend abstraction, status events, and Quest-specific capture fixes.
- Code donor value:
  strongest SDK donor in the wave: `LiveStreamManager` singleton, compile-time
  backend selection, `ILiveStreamBackend`, WebRTC update coroutine, Native
  WebSocket draining, FPS monitor, manual capture rendering for Quest Vulkan
  single-pass instancing issues, `LiveStreamConfig`, validation, kill-switch
  settings, and editor setup wizard.
- Product reference value:
  excellent reference for a VR live SDK that guides setup rather than asking
  developers to discover settings by trial and error.
- What to inspect next:
  exact backend implementations, portal API, recording/privacy policy, and
  dependency/fork maintenance.
- Reusable pattern:
  live-streaming SDK with guided setup and backend boundary.
- Caveats:
  external portal service, forked WebRTC dependency, streaming privacy, Spanish
  docs, and runtime claims not validated in this pass.

### `shinyoshiaki/quest-view`

- Interesting idea:
  a Quest Unity app receives a WebRTC video stream and renders decoded I420
  frames into a texture.
- Code donor value:
  useful for receiver-side frame queues, max-queue dropping, unsafe YUV-to-RGBA
  conversion, texture upload, WebSocket signaling, and data-channel wrappers.
- Product reference value:
  good Quest-side viewing surface reference.
- What to inspect next:
  plugin lineage, signaling compatibility, frame conversion cost, and secure
  pairing.
- Reusable pattern:
  WebRTC video receiver as VR texture.
- Caveats:
  old plugin/vendor payload, brittle signaling strings, no auth/TLS, possible
  STUN typo, and unsafe frame conversion.

### `jlin3/substream-sdk`

- Interesting idea:
  a streaming platform SDK models live sessions as authenticated allocations of
  cloud stages, publish tokens, viewer URLs, WHIP endpoints, webhooks, and
  recording/highlight flows.
- Code donor value:
  strong backend architecture donor: platform whitelisting, SDK version clamps,
  IVS stage allocation/release, stream records, webhooks, WHIP constraints,
  auth scopes, and Unity streaming script families.
- Product reference value:
  useful for a future "VR app broadcasts to a managed session" control plane.
- What to inspect next:
  Unity script internals, SDK packaging, local dev story, secrets, and
  VR-specific capture assumptions.
- Reusable pattern:
  streaming lifecycle control plane.
- Caveats:
  broad platform monorepo, not all parts are VR-specific, external AWS/IVS and
  AI services, and source may be evolving.

### `kasimmj/vrcollab`

- Interesting idea:
  a VR collaboration server README describes pose frames, WebRTC SFU, spatial
  audio, asset hosting, and SDKs.
- Code donor value:
  low in inspected source, because the actual tree is much thinner than the
  architecture claims.
- Product reference value:
  useful as a collaboration/control-plane product sketch and evidence of what
  fields a pose frame should name.
- What to inspect next:
  whether SFU, SDK, auth, and pose-sync code exist in another branch or later
  release.
- Reusable pattern:
  source-light pose-stream server reference.
- Caveats:
  README overclaims relative to code, default docker credentials, and missing
  SDK/server components in inspected tree.

### `jakubtom/UnityRenderStreaming_StereoWebcam`

- Interesting idea:
  a stereo webcam feed is streamed through Unity Render Streaming for phone-in-
  headset viewing.
- Code donor value:
  low in this pass because the repo is README-only.
- Product reference value:
  useful as a simple stereo-video concept node.
- What to inspect next:
  whether project files or receiver code exist elsewhere.
- Reusable pattern:
  stereo webcam stream as immersive preview.
- Caveats:
  README-only evidence and no source donor value found.

## Reusable Pattern Extraction

- Pattern candidate:
  remote VR streaming lifecycle.
- Problem solved:
  connect headset or phone input, rendered camera output, WebRTC/video
  transport, signaling, session control, and privacy gates into one streaming
  architecture.
- Reusable core:
  capture source, input uplink, output frame or video track, signaling channel,
  peer/session lifecycle, backend abstraction, resolution/FPS/bitrate config,
  frame queue, auth/pairing, kill-switch, and cleanup.
- Source evidence:
  `RemoteVR_UnityServer`, `RemoteVR_AndroidClient`,
  `TheAnonymousMan/WebRTC-VR-Server`, `com.educa360.live`, `quest-view`, and
  `substream-sdk`.
- Abstraction boundary:
  keep capture, transport, signaling, cloud allocation, viewer UI, and privacy
  policy as separate layers.
- What not to copy:
  unauthenticated UDP/WebSocket streams, fixed ports without pairing, brittle
  signaling payloads, unbounded frame queues, external cloud dependency without
  failover, or streaming claims without device evidence.
- Method catalog action:
  add a remote/cloud VR streaming method.

## Follow-Up Gaps

- Build a streaming matrix across sensor uplink, video tracks, signaling,
  frame queues, SDK setup, stage pools, recording, and privacy gates.
- Deepen `com.educa360.live` for setup wizard and Quest capture SDK patterns.
- Deepen `TheAnonymousMan/WebRTC-VR-Server` for compact Unity-hosted WebRTC.
- Treat `kasimmj/vrcollab` and `UnityRenderStreaming_StereoWebcam` as
  source-light concept nodes until source evidence improves.
