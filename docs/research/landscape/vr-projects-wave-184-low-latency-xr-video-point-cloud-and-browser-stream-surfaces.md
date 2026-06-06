# VR Projects Wave 184: Low-Latency XR Video, Point-Cloud, and Browser Stream Surfaces

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 184 studies small XR display-surface and stream-ingress projects: WebRTC
video to Unity textures, LiveKit stereo panels, UDP point-cloud reconstruction,
Quest MediaProjection senders, and native WebView video surfaces.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `bugman-007/XR-Low-Latency-Stereo-Streaming` | WebRTC sender/signaling/Unity receiver POC | Compact receiver boundary reference |
| `livekit-examples/spatial-video` | Meta Spatial SDK stereo panel connected to LiveKit room video | Strong stereo panel product reference |
| `Cont-ai-ner/PointCast3D` | RealSense UDP point-cloud sender and Unity mesh receiver | Compact payload/mesh donor |
| `studio4evr/FFMPEG-VRQ` | Empty repo from search | Excluded/source-light note |
| `N78Wy/relavr` | Quest MediaProjection/WebRTC sender app | Strong sender-state and codec-policy donor |
| `ranvuemor/SpatialVideoBrowser` | Native Quest/Unity WebView video browser | Product reference for browser video surfaces |

## `bugman-007/XR-Low-Latency-Stereo-Streaming`

- Interesting idea:
  split an XR stream POC into browser sender, WebSocket signaling server, and
  Unity receiver that binds a WebRTC `VideoStreamTrack` to a material texture.
- Code donor value:
  medium for a small sender/signaling/receiver boundary and Unity texture
  handoff.
- Product reference value:
  high for future camera-feed panels, remote diagnostics, and operator views.
- What to inspect next:
  add stereo, authentication, TURN, adaptive bitrate, and production error
  handling if this shape becomes a prototype.
- Source evidence:
  `poc-xr-stream/README.md`, `signaling/server.js`,
  `sender/src/main.js`, `receiver/Assets/Scripts/SignalingClient.cs`,
  `WebRTCReceiver.cs`, and `VideoRenderer.cs`.
- Reusable pattern extraction:
  WebRTC media-to-XR texture receiver.
- Reusable core:
  keep signaling messages separate from media, receive SDP/ICE over WebSocket,
  buffer ICE until the remote description is set, subscribe to the remote video
  track, and assign decoded textures to a world-space renderer.
- Do not copy directly:
  LAN-only/no-auth assumptions, string-built JSON, no TURN, and mono webcam
  scope.
- Caveats:
  POC quality, but the boundary is clean enough to reuse conceptually.

## `livekit-examples/spatial-video`

- Interesting idea:
  use Meta Spatial SDK panels to present a LiveKit room video track as a
  left-right stereo surface in an immersive Quest environment.
- Code donor value:
  medium for panel registration, stereo sizing, renderer lifecycle, and debug
  feature registration.
- Product reference value:
  high for telepresence, robot camera walls, immersive cinema, and operator
  surfaces.
- What to inspect next:
  dynamic stream format negotiation and multi-track selection.
- Source evidence:
  `README.md`, `LiveKitStereoViewer/app/src/main/java/.../ImmersiveActivity.kt`,
  `app/scenes/*`, and `res/layout/renderer.xml`.
- Reusable pattern extraction:
  fixed-contract stereo stream panel.
- Reusable core:
  register a transparent panel, set pixel and world dimensions from the stereo
  layout, mark stereo mode as left-right, subscribe to the first video track,
  attach the track to a `SurfaceViewRenderer`, and hide it on unsubscribe.
- Do not copy directly:
  hardcoded server/token values or fixed `3840x1080` assumptions.
- Caveats:
  sample requires Meta Spatial SDK and LiveKit service setup.

## `Cont-ai-ner/PointCast3D`

- Interesting idea:
  stream RealSense depth/color as compact UDP point chunks and rebuild the
  latest complete frame into a Unity `MeshTopology.Points` mesh.
- Code donor value:
  high for chunk header shape, frame reassembly, point payload, and mesh update
  boundary.
- Product reference value:
  medium for live spatial previews, robot perception panels, calibration, and
  diagnostics.
- What to inspect next:
  packet loss behavior, frame eviction, GPU point rendering, and compression.
- Source evidence:
  `Sender/real_sense_udp_sender.py`, `Receiver/UdpPointCloudSaver.cs`, and
  `Docs/architecture-diagram.png`.
- Reusable pattern extraction:
  UDP point-cloud fragment reassembly to Unity mesh.
- Reusable core:
  pack points as little-endian `x/y/z + rgb`, prefix each UDP packet with
  `frame_id`, `total_chunks`, and `chunk_index`, reassemble complete frames on
  a background receiver thread, and update the mesh on Unity's main thread.
- Do not copy directly:
  no packet-loss timeout, thread abort, one-socket-per-frame sender, and
  full-mesh CPU rebuild as final performance strategy.
- Caveats:
  small but valuable payload/receiver reference.

## `studio4evr/FFMPEG-VRQ`

- Interesting idea:
  search result promised a Unity plugin for Quest VR180 SBS live-stream decode.
- Code donor value:
  none in this pass; the cloned repository was empty.
- Product reference value:
  low, retained only as a directional search clue.
- What to inspect next:
  revisit only if source files appear.
- Source evidence:
  empty clone under `.research-sources/github/studio4evr/FFMPEG-VRQ`.
- Reusable pattern extraction:
  none.
- Caveats:
  exclude from donor lists until real source exists.

## `N78Wy/relavr`

- Interesting idea:
  turn a Quest 3 into a WebRTC sender using MediaProjection capture,
  optional system audio, QR/manual receiver connection, modular codec policy,
  and foreground-service session ownership.
- Code donor value:
  high for clean module boundaries, session coordinator, permission gateway,
  codec support matrix, SDP codec preference, and adaptive profile downgrade.
- Product reference value:
  high for remote support, mirror/capture, diagnostics, and headset-to-web
  streaming tools.
- What to inspect next:
  receiver contract, real-device privacy UX, and production signaling server.
- Source evidence:
  `README.md`, `core/session/StreamingSessionCoordinator.kt`,
  `platform/media-codec/*`, `platform/webrtc/WebRtcPublisherFactory.kt`,
  `AdaptiveVideoProfileController.kt`, `JsonSignalingMessageCodec.kt`,
  `app/MediaProjectionForegroundService.kt`, and `SenderQrScannerOverlay.kt`.
- Reusable pattern extraction:
  MediaProjection/WebRTC sender session state machine.
- Reusable core:
  request or restore projection permission, validate config, probe codec
  capabilities, resolve profile, open signaling, create publish session,
  observe RTC events, expose state via `StateFlow`, downgrade bitrate/FPS/
  resolution after repeated overload windows, and release all closeables on
  stop/failure.
- Do not copy directly:
  app-specific UI strings, QR payload conventions, or assumptions that system
  audio capture is always available.
- Caveats:
  sender-side only; receiver and security model need separate study.

## `ranvuemor/SpatialVideoBrowser`

- Interesting idea:
  avoid WebXR/CORS/DRM browser limitations by running a native Unity/Quest app
  with TLabWebView rendered onto a world-space canvas/texture.
- Code donor value:
  low-medium in this pass because most value is project configuration and
  scene composition rather than custom code.
- Product reference value:
  high for spatial browser/video shells and web-content panels.
- What to inspect next:
  TLabWebView package usage, input forwarding, keyboard, permissions, and
  lifecycle around web pages.
- Source evidence:
  `README.md`, `Packages/manifest.json`, `Assets/Scenes/SampleScene.unity`,
  `ProjectSettings/XRPackageSettings.asset`, and XRI/CompositionLayers assets.
- Reusable pattern extraction:
  native WebView-to-world-surface browser shell.
- Reusable core:
  use a native Android WebView-backed texture, place it on a world-space canvas
  or panel, combine with XRI locomotion/input, and frame it as a browser-video
  surface instead of a WebXR page.
- Do not copy directly:
  test URL, template assets, or unresolved package/version assumptions.
- Caveats:
  useful as product shape, not yet a strong code donor.

## Cross-Project Lessons

- Transport and display should be separate layers: WebRTC/LiveKit/UDP/WebView
  are ingress layers; renderer/panel/mesh/canvas is the XR presentation layer.
- Stereo/media surfaces need explicit format contracts, not implicit texture
  assumptions.
- Low-latency tools need status, fallback, and downgrade paths as first-class
  UX, not hidden logs.
- Point-cloud streams are closer to diagnostics/calibration tools than media
  players; they need packet-loss and frame-age policies early.
- Native WebView surfaces are a practical route when WebXR cannot access the
  needed web media.

## Reuse Recommendations

1. Use `relavr` as the strongest donor for Quest sender session state,
   permissions, codec policy, and adaptive downgrade.
2. Use `PointCast3D` as the compact donor for packetized spatial data to Unity
   mesh reconstruction.
3. Use `spatial-video` as the product reference for fixed-contract stereo
   panels.
4. Keep `XR-Low-Latency-Stereo-Streaming` as the minimal WebRTC receiver
   baseline.
5. Treat `SpatialVideoBrowser` as a browser-video shell reference and revisit
   only if a future prototype needs WebView input and lifecycle detail.
