# VR Projects Wave 212: Shared-Room WebXR/A-Frame Presence, WebRTC, and Peer-Adapter Microprototypes

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-212-plan.md`
- `docs/research/program/github-research-wave-212-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

Shared-room VR utilities need more than a scene. They need identity, room
membership, pose payloads, remote avatar creation, interpolation, media stream
binding, transport cleanup, and a way to show other people or devices as
present in the same space.

Wave 212 studies small browser and A-Frame projects because microprototypes
make those boundaries easier to see than large social platforms.

## Project Findings

### `jure/wooglies`

- Interesting idea: a browser WebXR room can combine server-relayed pose
  snapshots with direct peer media streams and positional audio, then use audio
  analysis to drive lightweight avatar behavior.
- Code donor value: high. `server/index.js` keeps per-space Socket.IO rooms,
  Twilio ICE discovery, `move`, `snapshot`, `peers`, and `signal` events.
  `OtherPlayers.jsx` uses `SnapshotInterpolation(60)` over head and controller
  pose fields. `Space.jsx` wires simple-peer, audio contexts, media stream
  destinations, and signaling. `Player.jsx` emits keyboard, headset, and
  controller poses. `Box.jsx` binds peer audio streams into `THREE.PositionalAudio`
  and an analyser.
- Product reference value: high for small shared WebXR rooms with voice, fuzzy
  avatar presence, and media-reactive identity.
- Architecture pattern: React/Three/WebXR client plus Socket.IO room server plus
  WebRTC peer media plus SnapshotInterpolation pose state.
- Reusable method: keep authoritative room membership on the server, but send
  media peer-to-peer and smooth remote head/controller transforms on the
  client.
- Constraints and caveats: experimental project, old dependencies, Twilio ICE
  dependency, small-room assumptions, and no production trust or moderation
  model.
- What to inspect next: room lifecycle cleanup, avatar representation,
  positional-audio tuning, and whether media/analyser state can be abstracted
  for non-social utility peers.
- Why it matters for `VR-apps-lab`: it is the strongest Wave 212 donor for
  shared-room pose plus voice/media presence.

#### Reusable Pattern Extraction

- Pattern candidate: browser XR shared-room presence plus P2P media.
- Problem solved: make remote people or tools visible and audible in a WebXR
  scene without building a full social platform.
- Reusable core: room id, client id, pose schema, server snapshots,
  interpolation field list, peer signaling, media-stream attachment, positional
  audio, and peer cleanup.
- Source evidence: `server/index.js`, `OtherPlayers.jsx`, `Space.jsx`,
  `Player.jsx`, and `Box.jsx`.
- Abstraction boundary: separate room membership, pose snapshots, WebRTC media,
  avatar rendering, and audio analysis.
- What not to copy: Twilio-specific setup, old package versions, fuzzy avatar
  visuals as a general UI, or trust assumptions.
- Method catalog action: create Method 657.

### `danbuckland/aframe-socket-io`

- Interesting idea: an A-Frame scene can be split into a game/pose system, a
  WebRTC media system, a video-texture component, and a Socket.IO signaling
  server.
- Code donor value: medium to high. `source/server/sockets.js` stores user pose
  and avatar metadata, emits join/update events, builds peer connections with
  `add-peer`, and relays ICE/session descriptions. `source/systems/game.js`
  owns local and remote player objects. `source/systems/webrtc.js` handles
  camera/mic access, `RTCPeerConnection`, and audio/video toggles.
  `source/components/video-stream.js` maps remote media streams onto A-Frame
  video textures.
- Product reference value: medium for old but readable room/media boundaries.
- Architecture pattern: A-Frame ECS systems for pose and media, plus a thin
  Socket.IO signaling server.
- Reusable method: keep media-stream binding as a component and keep signaling
  separate from local entity creation.
- Constraints and caveats: old WebRTC and A-Frame assumptions, full peer mesh,
  limited VR ergonomics, and prototype-level security.
- What to inspect next: remote-player cleanup, track mute UX, and how a modern
  WebXR client would replace the old A-Frame APIs.
- Why it matters for `VR-apps-lab`: it is a compact source-level reference for
  pose/game/media separation in a browser XR room.

### `Srushtika/realtime-multiplayer-webvr-aframe`

- Interesting idea: a shared VR scene can be reduced to presence records,
  periodic camera position/rotation updates, and generated avatar entities.
- Code donor value: low to medium. `main.js` logs into Deepstream, creates a
  `user/{id}` record, sends camera pose every 100ms, subscribes to presence
  changes, creates avatar entities, and removes them when users leave.
- Product reference value: medium as a minimal baseline for presence-driven
  avatar UX.
- Architecture pattern: external realtime record store plus A-Frame generated
  avatars.
- Reusable method: treat remote users as records with pose fields and keep
  avatar creation/removal driven by presence events.
- Constraints and caveats: obsolete Deepstream hub credentials, old A-Frame
  version, CDN reliance, and no media or interpolation.
- What to inspect next: whether the record/presence pattern can be expressed as
  a modern WebSocket or CRDT adapter.
- Why it matters for `VR-apps-lab`: it defines the lowest useful baseline for
  a shared-room presence system.

### `RangerMauve/aframe-dat-peers-networking`

- Interesting idea: the networking substrate can be an adapter that turns
  transport messages into A-Frame scene events and remote template entities.
- Code donor value: medium. `dat-peers-networking.js` wraps Beaker `datPeers`
  in a `NetworkingEvents` event target, defines room and user messages,
  includes `connect`, `enter_room`, `leave_room`, `move`, and `chat`, and
  exposes A-Frame components for a networked scene, local objects, and remote
  entities.
- Product reference value: low to medium because datPeers is obsolete, but the
  adapter shape is useful.
- Architecture pattern: transport adapter plus scene-level components plus
  remote entity templates.
- Reusable method: normalize peer messages into scene events and only emit
  changed position state.
- Constraints and caveats: Beaker/datPeers is not a current browser platform,
  and the sample only proves a narrow peer model.
- What to inspect next: event names and remote-template lifecycle as a possible
  generic adapter contract for future WebXR utilities.
- Why it matters for `VR-apps-lab`: it shows how to preserve a scene-facing API
  even when the transport substrate changes.

## Cross-Project Lessons

- Shared-room systems should separate membership, pose state, media streams,
  and scene rendering.
- Small prototypes often make cleanup and stale-peer behavior more visible than
  large frameworks.
- Pose schemas should be explicit: head, hands/controllers, avatar metadata,
  and media state should not be hidden inside ad hoc objects.
- Obsolete transports can still donate adapter boundaries even when their
  platform choices should not be copied.

## Method Catalog Actions

- Added Method 657: browser XR shared-room presence, pose, and media adapter.

## Follow-Up Gaps

- Compare Wave 212 with Networked-AFrame and newer React/Three XR shared-room
  stacks.
- Build a presence/media payload matrix that separates user identity, pose,
  audio/video, avatar, room membership, and cleanup.
- Identify a modern transport set for future prototypes: WebSocket, WebRTC
  data channels, WebTransport, LiveKit, or CRDT-backed rooms.
