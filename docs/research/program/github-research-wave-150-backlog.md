# GitHub Research Wave 150 Backlog

- Date: `2026-06-05`
- Scope: WebRTC remote rendering, WebXR streaming, signaling, input remoting,
  and bidirectional pose/control channels.

## Completed in this wave

- Studied `FusedVR/VRStreaming` as a Unity Render Streaming extension where a
  browser/WebXR client sends headset pose, button, axis, display, and VR mode
  messages over a data channel while receiving rendered camera textures.
- Studied `Unity-Technologies/UnityRenderStreaming` as a higher-level Unity
  streaming stack with signaling manager, peer wrapper, data channel base, and
  browser input-remoting protocol.
- Studied `Unity-Technologies/com.unity.webrtc` as the low-level Unity WebRTC
  primitive layer for peer connections, tracks, transceivers, and data
  channels.
- Studied `EpicGamesExt/PixelStreamingInfrastructure` as an Unreal streaming
  infrastructure with signaling protocol, browser data-channel controller,
  input controllers, and WebXR video/pose/gamepad client.
- Studied `Azure/Unreal-Pixel-Streaming` as a deployment-oriented Unreal Pixel
  Streaming shell with signaling server, matchmaker support, auth/logging,
  frontend proxying, and Azure-oriented lifecycle scripts.

## Reuse candidates

- `VRStreaming` is the strongest small donor for WebXR-to-Unity pose/control
  protocol design.
- `UnityRenderStreaming` is the strongest donor for reusable Unity signaling,
  peer, data-channel, and input-remoting architecture.
- `com.unity.webrtc` is the strongest donor when a custom Unity VR utility
  needs lower-level WebRTC control.
- `PixelStreamingInfrastructure` is the strongest donor for browser WebXR
  video projection and selective HMD/eye/gamepad messages to Unreal.
- `Azure/Unreal-Pixel-Streaming` is useful mainly for deployment, matchmaker,
  and signaling-server operational lessons.

## Follow-up backlog

1. Extract a `remote VR utility protocol` note comparing Unity pose messages,
   Unity input remoting, and Unreal WebXR data messages.
2. Compare video texture UI from streaming stacks against Wave 145 media
   surface controls.
3. Track signaling/matchmaker deployment patterns separately from headset-side
   pose/control protocols.
4. Consider whether future `VR-apps-lab` prototypes need a minimal data-channel
   schema for pose, buttons, and diagnostic events.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
