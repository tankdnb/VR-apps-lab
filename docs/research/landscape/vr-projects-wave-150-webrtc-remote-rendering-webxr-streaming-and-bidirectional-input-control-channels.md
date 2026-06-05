# VR Projects Wave 150: WebRTC Remote Rendering, WebXR Streaming, and Bidirectional Input/Control Channels

- Date: `2026-06-05`
- Goal: study streaming architectures where rendered pixels flow to a browser
  or headset client while pose, input, and control data flow back to the
  renderer.

## Why this wave exists

Some future VR utilities may be easiest to build as a split system: heavy
rendering or simulation runs in Unity/Unreal/desktop, while the headset or
browser becomes a display and sensor surface. This wave studies how existing
projects connect video streams, data channels, input remoting, and WebXR pose
messages.

## Better workflow used in this wave

1. searched by WebXR streaming, Unity Render Streaming, Unity WebRTC, Unreal
   Pixel Streaming, signaling, and matchmaker families;
2. deduplicated against media playback, WebXR framework, and engine export
   waves;
3. froze a shortlist across focused Unity VR streaming, Unity streaming stack,
   Unity WebRTC primitives, Unreal Pixel Streaming, and Azure deployment
   shell references;
4. inspected local-only source clones;
5. extracted reusable methods without running, building, installing, or
   launching the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `FusedVR/VRStreaming` | Focused WebXR-to-Unity VR streaming prototype |
| `Unity-Technologies/UnityRenderStreaming` | Unity render streaming stack and browser input remoting |
| `Unity-Technologies/com.unity.webrtc` | Low-level Unity WebRTC primitives |
| `EpicGamesExt/PixelStreamingInfrastructure` | Unreal Pixel Streaming WebXR and input client |
| `Azure/Unreal-Pixel-Streaming` | Deployment-oriented signaling and matchmaker shell |

## Deep-pass notes by project

## `FusedVR/VRStreaming`

- GitHub:
  [FusedVR/VRStreaming](https://github.com/FusedVR/VRStreaming)
- What it is:
  a Unity package/prototype that extends Unity Render Streaming for VR/WebXR
  clients.
- Interesting idea:
  use the browser/WebXR client as the headset pose and controller source while
  Unity streams rendered camera output back through WebRTC.
- Code-level notes:
  `Runtime/Scripts/VRInputManager.cs` extends Unity Render Streaming's
  `InputChannelReceiverBase` and handles a data channel protocol with
  `VRDataType` values for pose/rotation, button, axis, display, enter VR,
  exit VR, and crypto. `SetChannel` creates a `RemoteInputReceiver`, attaches
  or removes remote keyboard, mouse, and touchscreen devices, and routes data
  channel messages through `remoteInput.ProcessInput`. `OnMessage` parses
  binary pose floats, flips Z/W coordinate conventions, dispatches button and
  axis events, handles display size, VR mode events, and JSON crypto payloads.
  `Runtime/Scripts/ApplyVRData.cs` applies incoming pose data to transforms.
  `Runtime/Scripts/VRCamStream.cs` extends `VideoStreamSender`, creates a
  WebRTC-supported render texture, assigns multiple cameras into split rects,
  creates a `VideoStreamTrack`, and updates bitrate/framerate through RTP
  sender parameters.
- Architecture pattern:
  Unity render sender plus WebXR pose/control data-channel receiver.
- Reusable method:
  define a compact binary VR data channel with typed pose, button, axis,
  display, and session-mode messages.
- Code donor value:
  high for minimal VR streaming protocol and camera-stream composition.
- Product reference value:
  high for remote Unity utilities where the headset/browser is a thin client.
- Constraints and caveats:
  coordinate conversion and device mapping are project-specific and must be
  documented if reused.
- What to inspect next:
  compare protocol shape with Unreal Pixel Streaming WebXR messages.

## `Unity-Technologies/UnityRenderStreaming`

- GitHub:
  [Unity-Technologies/UnityRenderStreaming](https://github.com/Unity-Technologies/UnityRenderStreaming)
- What it is:
  Unity's render streaming package and browser web app stack.
- Interesting idea:
  separate signaling, peer negotiation, media/data channels, and browser input
  remoting into reusable layers.
- Code-level notes:
  `WebApp/client/src/inputremoting.js` defines `LocalInputManager` and
  `InputRemoting` message types for connect, disconnect, new layout, new
  device, new events, remove device, change usages, start sending, and stop
  sending. `WebApp/client/src/peer.js` wraps `RTCPeerConnection` with
  polite/impolite negotiation, resend-offer loop, track/datachannel/candidate
  events, glare handling, descriptions, and stats. `Runtime/Scripts/DataChannelBase.cs`
  abstracts `RTCDataChannel` lifecycle, label/local state, connection id,
  open/close/message handlers, and string/byte sends. `Runtime/Scripts/RenderStreaming.cs`
  handles static settings and automatic streaming object creation.
  `Runtime/Scripts/SignalingManager.cs` creates signaling from settings,
  registers handlers, starts signaling, and supports command-line overrides.
- Architecture pattern:
  signaling manager plus peer wrapper plus data-channel base plus input
  remoting protocol.
- Reusable method:
  keep generic input remoting independent from any one VR pose protocol.
- Code donor value:
  high for Unity-side streaming architecture and browser peer negotiation.
- Product reference value:
  high for remote dashboards, remote control, streamed previews, and thin VR
  clients.
- Constraints and caveats:
  not VR-specific by itself; VR semantics must be layered on top.
- What to inspect next:
  use it as the general streaming substrate behind a smaller VR-specific
  control protocol.

## `Unity-Technologies/com.unity.webrtc`

- GitHub:
  [Unity-Technologies/com.unity.webrtc](https://github.com/Unity-Technologies/com.unity.webrtc)
- What it is:
  Unity's lower-level WebRTC package.
- Interesting idea:
  expose direct peer connection, track, transceiver, and data-channel
  primitives when higher-level render streaming is too opinionated.
- Code-level notes:
  `Runtime/Scripts/RTCPeerConnection.cs` wraps peer connection lifecycle,
  ICE/signaling/track/connection events, disposal, track and transceiver
  management, data-channel creation, and async offer/answer patterns.
  `Runtime/Scripts/RTCDataChannel.cs` exposes ordered delivery,
  packet-life/retransmit options, protocol, negotiated channels, channel id,
  open/close/message handlers, byte-array messages, and lifecycle events.
- Architecture pattern:
  low-level WebRTC primitive layer for custom Unity protocols.
- Reusable method:
  when a VR utility protocol needs unusual pose/control messages, build on
  data-channel primitives rather than forcing everything through a full remote
  desktop stack.
- Code donor value:
  high for custom Unity data-channel work.
- Product reference value:
  medium-high as infrastructure rather than a product UX reference.
- Constraints and caveats:
  requires signaling, session policy, and app protocol design elsewhere.
- What to inspect next:
  pair with a minimal signaling server and `VRStreaming`-style message schema.

## `EpicGamesExt/PixelStreamingInfrastructure`

- GitHub:
  [EpicGamesExt/PixelStreamingInfrastructure](https://github.com/EpicGamesExt/PixelStreamingInfrastructure)
- What it is:
  the Unreal Pixel Streaming infrastructure repository with browser frontend,
  signaling protocol, input controllers, and WebXR client pieces.
- Interesting idea:
  a browser WebXR client can render the streamed Unreal video as an XR texture
  while sending HMD, eye, and gamepad data back to the streamer.
- Code-level notes:
  `Common/src/Protocol/SignallingProtocol.ts` defines a transport-backed JSON
  signaling protocol with versioning, generic and typed message events,
  unhandled events, and outbound message hooks. `Frontend/library/src/DataChannel/DataChannelController.ts`
  creates a data channel, sets ordered delivery and binary mode, and exposes
  open/close/message/error extension points. Keyboard and mouse controllers
  normalize browser input into streamer handlers. `Frontend/library/src/WebXR/WebXRController.ts`
  requests `immersive-vr`, creates an XR-compatible WebGL2 canvas, compiles
  shaders, projects the WebRTC video texture into headset views, creates the
  base `XRWebGLLayer`, tries 90 FPS, updates views per XR frame, sends XR data
  to Unreal, updates texture, renders, and updates XR gamepad state. Its
  message flow sends eye-view data selectively when IPD/projection changes and
  otherwise sends HMD transform updates.
- Architecture pattern:
  WebXR video projection client plus selective pose/eye/gamepad data-channel
  messages.
- Reusable method:
  send expensive or structural XR data only when it changes, while streaming
  cheap HMD transforms every frame.
- Code donor value:
  high for browser WebXR streaming client design.
- Product reference value:
  high for remote Unreal VR utilities and streamed immersive experiences.
- Constraints and caveats:
  large infrastructure with Unreal-specific assumptions; reuse should focus on
  protocol and WebXR client boundaries.
- What to inspect next:
  compare with Unity's pose/button/axis protocol and media-surface controls.

## `Azure/Unreal-Pixel-Streaming`

- GitHub:
  [Azure/Unreal-Pixel-Streaming](https://github.com/Azure/Unreal-Pixel-Streaming)
- What it is:
  an Azure-oriented Unreal Pixel Streaming deployment and signaling stack.
- Interesting idea:
  make signaling, matchmaker, auth, logging, frontend proxying, and lifecycle
  scripts part of the streaming utility architecture rather than an afterthought.
- Code-level notes:
  `Engine/.../SignallingWebServer/cirrus.js` is an Express signaling server
  with options for frontend hosting, matchmaker, HTTPS, auth, logging,
  lifecycle behavior, Application Insights, HSTS/helmet, frontend proxying,
  streamer/matchmaker ports, STUN config, matchmaker keepalive/retry, static
  routes, login, and game session data. Additional modules support matchmaker
  configuration, connection management, logging, VMSS, start scripts, and
  peering/deployment workflows.
- Architecture pattern:
  operational signaling/matchmaker shell around a streaming runtime.
- Reusable method:
  separate streaming protocol lessons from deployment-scale lessons, but keep
  both visible when planning remote VR utilities.
- Code donor value:
  medium for signaling/deployment structure.
- Product reference value:
  medium-high for operational streaming service planning.
- Constraints and caveats:
  older deployment stack and not a VR-specific client by itself.
- What to inspect next:
  compare with current Pixel Streaming infrastructure before copying any
  server details.

## Cross-project synthesis

This wave identifies three distinct layers:

- VR-specific data channels: `VRStreaming` and Pixel Streaming WebXR messages;
- generic streaming substrate: Unity Render Streaming and Unity WebRTC;
- operational signaling/deployment: Unreal/Azure signaling and matchmakers.

For `VR-apps-lab`, the reusable pattern is:

- stream pixels separately from control data;
- keep pose, buttons, axes, display, session mode, and gamepad events typed;
- send high-frequency transforms cheaply;
- send structural eye/projection/display changes only when needed;
- keep signaling/matchmaker concerns outside the app protocol.

## Methods extracted

- WebXR-to-Unity remote VR streaming protocol over WebRTC data channels.
- Render streaming stack with signaling manager, peer wrapper, data channel,
  and input remoting.
- Low-level Unity WebRTC primitive layer for custom VR data protocols.
- Pixel-streaming WebXR client with video texture projection and selective HMD
  or eye pose messages.

## New gaps opened

- Build a comparative remote VR protocol matrix: Unity pose/button/axis,
  Unity input remoting, Unreal HMD/eye/gamepad, and browser media controls.
- Track signaling/matchmaker deployment as a separate family from pose/control
  protocols.
- Compare streamed video surfaces against immersive 360/video-player UI
  patterns from Wave 145.
