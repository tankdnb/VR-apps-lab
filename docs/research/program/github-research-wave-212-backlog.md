# GitHub Research Wave 212 Backlog

Date: 2026-06-06

Theme: shared-room WebXR and A-Frame presence, media, and peer adapters.

## Completed In This Wave

- Studied `jure/wooglies` as a React/Three/WebXR shared-room prototype with
  Socket.IO snapshots, simple-peer media, positional audio, and analyser-driven
  avatar reactivity.
- Studied `danbuckland/aframe-socket-io` as an A-Frame Socket.IO/WebRTC room
  adapter with separated game, WebRTC, video-texture, and server-signaling
  layers.
- Studied `Srushtika/realtime-multiplayer-webvr-aframe` as a minimal
  Deepstream-backed presence-record and avatar-sync sample.
- Studied `RangerMauve/aframe-dat-peers-networking` as a Beaker/datPeers
  networking adapter with room/user events and remote template entities.
- Added a reusable method entry for browser XR shared-room presence, pose, and
  media adapters.

## Follow-Up Queue

1. Compare the Wave 212 adapters against Networked-AFrame and newer WebXR room
   shells to build a transport-pattern matrix.
2. Extract a canonical room-state payload for browser XR utilities: user id,
   display name, head pose, hand/controller poses, media state, and avatar
   metadata.
3. Prototype a documentation template for shared-room cleanup: leave events,
   peer teardown, media-track disposal, and stale remote entity removal.
4. Use `jure/wooglies` as the strongest donor for P2P positional audio plus
   interpolated avatar pose.
5. Use `aframe-socket-io` as the clearest small example of separating server
   signaling, local pose sync, WebRTC media, and video surface binding.

## Do Not Spend Time On Yet

- Do not modernize old A-Frame, Deepstream, Beaker, or WebRTC APIs inside these
  repos.
- Do not treat obsolete transports such as datPeers as current deployment
  recommendations.
- Do not run demo servers or browser clients from the studied projects.
