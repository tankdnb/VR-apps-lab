# GitHub Research Wave 181 Plan

- Date: `2026-06-06`
- Theme: `WebXR multiplayer/shared rooms and WebRTC scene shells`
- Scope: WebXR room servers, peer signaling, WebRTC/DataChannel scene state,
  Unity WebXR multiplayer templates, A-Frame classrooms, spatial-web presence
  rooms, and WebXR product references.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Shared VR utility tools need more than a local overlay. They often need rooms,
presence, voice, cursor/pose streams, shared objects, chat, or remote
collaboration. This wave studies WebXR and Unity-WebXR multiplayer shells as
reusable state, signaling, and UX patterns.

## Search Families

- WebXR multiplayer rooms
- WebRTC and DataChannel scene transport
- WebSocket signaling and room registries
- WebXR shared-object and physics scenes
- Unity WebXR multiplayer templates
- A-Frame classroom/social spaces
- spatial-web presence and agent HUD shells

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `danielesteban/blocks` | WebXR voxel room with WebSocket/protobuf signaling, SimplePeer audio/data, and canvas UI | WebXR room and P2P scene state |
| `De-Panther/webxr-multiplayer-template` | Unity WebXR multiplayer template using Lobby, Relay, Vivox, NGO, and hand pose replication | Unity WebXR multiplayer shell |
| `kylebakerio/vrgoclub` | Product reference for social WebXR board-game presence and AI assistance | WebXR social product reference |
| `Immersive-Collective/webxr-webrtc-dc-scene` | WebXR media/capability scene with WebRTC framing but limited DataChannel implementation | WebRTC capability reference |
| `Radet5/webroom-vr` | socket.io/simple-peer room with VR and desktop users, physics objects, and grab/release events | Shared-object WebXR room |
| `JT5D/xrai-spatial-web` | Spatial-web presence rooms, view registry, HUD orchestration, hand/voice/agent overlay pieces | Spatial HUD/presence shell |
| `RNMUDS/webxr-multiplayer-room` | Minimal A-Frame classroom with Socket.IO, PeerJS setup, chat, and avatar pose updates | A-Frame social room baseline |

## Dedupe Notes

- Earlier social XR waves covered broader frameworks. This wave focuses on
  room/signaling/state transport and reusable shared-scene shells.
- `vrgoclub` is retained as product reference only because the repo is mainly a
  promo/static page.
- `webxr-webrtc-dc-scene` was not treated as a true DataChannel sync donor
  after code review; its value is capability/media-surface reference.

## Code-Level Pass Targets

- signaling messages, room state, join/leave and peer lifecycle;
- P2P audio/data channel setup and low-overhead pose payloads;
- Unity Lobby/Relay/Vivox/NGO WebXR state and hand-pose replication;
- shared object grab/release and physics state events;
- chat, classroom, presence, and fallback desktop flows;
- spatial HUD orchestration and view registry boundaries;
- capability diagnostics and in-world media textures.

## Expected Outputs

- Wave 181 landscape synthesis.
- Registry/family placement for WebXR multiplayer and shared-room shells.
- Methods around signaling-plus-P2P room state, Unity WebXR rooms, shared-object
  scene events, and spatial HUD/view-registry orchestration.
