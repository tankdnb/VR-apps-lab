# GitHub Research Wave 181 Backlog

- Date: `2026-06-06`
- Theme: `WebXR multiplayer/shared rooms and WebRTC scene shells`
- Status: executed as static source-reading pass
- Build/run status: not run, not built, not installed, not launched

## Completed Intake

- Shortlisted WebXR and Unity WebXR shared-room projects.
- Deduplicated against earlier WebXR framework, social world, and remote
  rendering waves.
- Read source entry points without executing found projects.
- Integrated room/state/transport methods into canonical docs.

## Follow-Up Work

- Create a `shared XR room matrix` comparing:
  WebSocket-only rooms, WebSocket signaling plus WebRTC P2P, Unity Relay/NGO,
  socket.io/simple-peer, and PeerJS/A-Frame baselines.
- Compare pose payload models:
  JSON, protobuf, Float32Array binary, NetworkVariables, and per-object events.
- Add a future safety note for public rooms:
  identity, moderation, room capacity, auth, and media permission boundaries.
- Revisit `webxr-webrtc-dc-scene` only if it grows actual DataChannel state
  synchronization.

## Reuse Candidates

- Signaling server plus P2P state/audio split from `blocks`.
- Unity WebXR Lobby/Relay/Vivox/NGO room shell from
  `webxr-multiplayer-template`.
- Shared object grab/release model from `webroom-vr`.
- Presence room and view-registry shell from `xrai-spatial-web`.
- A-Frame classroom/chat/avatar baseline from `webxr-multiplayer-room`.

## Caveats To Preserve

- Several projects are demos, WIP, or product references rather than maintained
  multiplayer infrastructure.
- Voice/video and webcam capture require explicit permission handling.
- Public room tools need threat-modeling before becoming prototypes.
