# VR Projects Wave 181: WebXR Multiplayer, Shared Rooms, and WebRTC Scene Shells

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 181 studies shared WebXR and Unity WebXR room projects: signaling servers,
peer connections, voice/data channels, binary pose payloads, shared-object
events, chat, classroom baselines, spatial HUD orchestration, and room presence
state.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `danielesteban/blocks` | WebXR room with signaling and P2P pose/audio | Strong room/P2P donor |
| `De-Panther/webxr-multiplayer-template` | Unity WebXR Lobby/Relay/Vivox/NGO template | Strong Unity shared-room donor |
| `kylebakerio/vrgoclub` | Social board-game WebXR product reference | Product reference only |
| `Immersive-Collective/webxr-webrtc-dc-scene` | WebXR media/capability scene | Capability/media reference |
| `Radet5/webroom-vr` | Shared-object WebXR room with VR/desktop users | Strong lightweight room donor |
| `JT5D/xrai-spatial-web` | Spatial presence rooms, HUD, view registry, agent overlay | Strong architecture reference |
| `RNMUDS/webxr-multiplayer-room` | A-Frame classroom with chat and avatar pose updates | Compact room baseline |

## `danielesteban/blocks`

- Interesting idea:
  split a WebXR multiplayer scene into a WebSocket/protobuf room server for
  identity/signaling and WebRTC SimplePeer channels for audio and pose data.
- Code donor value:
  high for room messages, peer lifecycle, binary pose packets, self-host config,
  and canvas-based in-world menu UI.
- Product reference value:
  high for collaborative WebXR tools, lightweight social spaces, and hosted
  room utilities.
- What to inspect next:
  compare its signaling/P2P split with socket.io/simple-peer and Unity Relay
  approaches.
- Source evidence:
  `server/messages.proto`, `server/room.js`, `client/core/room.js`,
  `client/core/peers.js`, `client/renderables/menu/index.js`, and
  `client/renderables/ui.js`.
- Reusable pattern extraction:
  WebXR room server plus P2P pose/audio channels.
- Reusable core:
  assign room identities, broadcast join/leave, forward peer signals, keep
  server messages small and typed, stream voice through WebRTC, and send
  head/hand state as compact binary payloads over DataChannel.
- Do not copy directly:
  voxel-world assumptions or old dependency versions.
- Caveats:
  strong architecture donor, but app-specific world and UI code should stay
  conceptual.

## `De-Panther/webxr-multiplayer-template`

- Interesting idea:
  adapt Unity's VR multiplayer template to WebXR using Lobby, Relay, Vivox,
  Netcode for GameObjects, XR hands, and world-space setup/offline panels.
- Code donor value:
  high for state machine orchestration, Lobby/Relay setup, Vivox voice state,
  XR hand pose bandwidth tiers, and networked UI widgets.
- Product reference value:
  high for Unity WebXR shared tools that need rooms, voice, avatar presence,
  and runtime settings.
- What to inspect next:
  compare its service-heavy approach with self-hosted WebSocket/WebRTC rooms.
- Source evidence:
  `NetworkManagerVRMultiplayer.cs`, `LobbyManager.cs`,
  `XRINetworkGameManager.cs`, `XRINetworkPlayer.cs`,
  `XRHandPoseReplicator.cs`, `PlayerOptions.cs`, `NetworkedSlider.cs`, and
  `OfflineMenu.cs`.
- Reusable pattern extraction:
  Unity WebXR multiplayer room shell.
- Reusable core:
  authenticate, quick-join or create lobbies, allocate Relay endpoints,
  heartbeat rooms, replicate player head/hands/name/color/voice state, choose
  hand-pose fidelity tiers, and use server/client RPCs for shared UI widgets.
- Do not copy directly:
  heavy Unity service dependencies unless the product actually needs them.
- Caveats:
  large dependency surface and template assumptions; best as architecture
  reference.

## `kylebakerio/vrgoclub`

- Interesting idea:
  frame a WebXR Go club as a cross-device social board-game product with
  live audio/video, tracked VR presence visible to desktop users, hand
  tracking, online-go.com sync, and KataGo heatmaps.
- Code donor value:
  low; the repository is mainly a promo/static page.
- Product reference value:
  high for social XR product framing, mixed VR/desktop spectators, and
  AI-assisted board analysis.
- What to inspect next:
  find source-complete board-game collaboration repos that implement this
  product shape.
- Source evidence:
  `README.txt`, `package.json`, and `index.html`.
- Reusable pattern extraction:
  social board-game XR product frame.
- Reusable core:
  combine shared board state, cross-device spectators, voice/video presence,
  tracked hands/controllers, and optional AI heatmap hints.
- Do not copy directly:
  there is no meaningful app implementation to copy.
- Caveats:
  product reference only.

## `Immersive-Collective/webxr-webrtc-dc-scene`

- Interesting idea:
  present WebRTC and WebXR capabilities in a Three.js scene, including webcam
  texture surfaces, controller/hand pointer visuals, and teleport helpers.
- Code donor value:
  medium for media-stream-to-texture, WebRTC capability diagnostics, rayline
  pointers, and teleport affordance snippets.
- Product reference value:
  medium for diagnostic panels and in-world media capability previews.
- What to inspect next:
  only revisit as a multiplayer donor if real DataChannel state sync is added.
- Source evidence:
  `src/index.js`, `demos/WebRTC-APIs/README.md`,
  `OUT-OF-BAND.md`, `WebXR-teleport/src/libs/teleport.js`, and
  `WebXR-starter/RAYLINES.md`.
- Reusable pattern extraction:
  WebXR media capability panel.
- Reusable core:
  check browser capabilities, request media streams, apply webcam/video frames
  to in-world textures, expose ray/pointer affordances, and document manual
  offer/answer/ICE concepts.
- Do not copy directly:
  the repository title's DataChannel implication as if it were implemented.
- Caveats:
  useful as capability/media reference, not as a true multiplayer sync donor.

## `Radet5/webroom-vr`

- Interesting idea:
  combine socket.io discovery/signaling, simple-peer DataChannels, VR and
  desktop users, Cannon physics objects, and explicit grab/release events.
- Code donor value:
  high for lightweight room transport, shared object ownership, throw velocity,
  remote avatars, and screen-user fallback.
- Product reference value:
  high for browser-native collaboration rooms and shared physical-object
  experiments.
- What to inspect next:
  compare object authority and reconciliation with larger multiplayer
  frameworks.
- Source evidence:
  `src/js/app.ts`, `room-manager.ts`, `server-data-manager.ts`,
  `vr-user.ts`, `screen-user.ts`, `other-player.ts`, and
  `physical-objects-manager.ts`.
- Reusable pattern extraction:
  shared-object WebXR room with VR/desktop fallback.
- Reusable core:
  use a signaling server to connect peers, broadcast player state at a fixed
  cadence, attach/release objects on controller selection, transfer object
  poses/velocities, render simple remote avatars, and keep a keyboard/mouse
  fallback user model.
- Do not copy directly:
  hardcoded public API endpoints or WIP scene assumptions.
- Caveats:
  prototype/WIP but valuable for small shared-object utilities.

## `JT5D/xrai-spatial-web`

- Interesting idea:
  treat spatial web as a set of rooms, presence state, pluggable views, HUD
  orchestration, hand/voice input, and agent overlays rather than one scene.
- Code donor value:
  high for room-state separation, WebSocket presence, view lifecycle registry,
  hook bus, HUD orchestrator, hand-tracking fallback, and voice/agent overlay.
- Product reference value:
  high for future VR dashboards, diagnostic spaces, and collaborative
  knowledge/graph tools.
- What to inspect next:
  separate implemented runtime pieces from spec/roadmap materials.
- Source evidence:
  `room-manager.mjs`, `room-state.mjs`, `presence-ws.mjs`,
  `spatial-ui.mjs`, `hud/orchestrator.mjs`, `view-registry.mjs`,
  `hand-tracker.mjs`, and `agent-overlay.mjs`.
- Reusable pattern extraction:
  spatial HUD orchestrator with pluggable views and presence.
- Reusable core:
  keep room membership and shared view/filter state transport-agnostic, expose
  a WebSocket protocol for join/cursor/view/filter changes, register view
  plugins with `init/generate/update/clear/dispose`, and compose HUD, voice,
  gesture, minimap, and agent tools through a bus.
- Do not copy directly:
  AI/platform assumptions or roadmap/spec text as finished implementation.
- Caveats:
  broad spatial-web lab rather than a pure WebXR multiplayer app.

## `RNMUDS/webxr-multiplayer-room`

- Interesting idea:
  provide a minimal A-Frame classroom/social room with Socket.IO join/chat,
  PeerJS setup, colored avatars, and periodic pose updates.
- Code donor value:
  medium for compact A-Frame room scaffolding, HTTPS/static server setup, chat,
  and avatar pose throttling.
- Product reference value:
  medium-high for teaching, onboarding, or small shared-room prototypes.
- What to inspect next:
  add interpolation and real PeerJS media/data usage before treating it as a
  robust multiplayer base.
- Source evidence:
  `server.js` and `public/main.js`.
- Reusable pattern extraction:
  minimal A-Frame social room.
- Reusable core:
  serve an HTTPS scene, let users join a room, create simple avatar entities,
  broadcast pose updates only when movement/rotation thresholds are exceeded,
  and add chat as a first-class shared-room surface.
- Do not copy directly:
  lack of auth/security and unfinished PeerJS voice/data usage.
- Caveats:
  useful baseline, not production multiplayer infrastructure.

## Cross-Project Lessons

- Shared WebXR tools usually need both a room model and a media/state model;
  treating signaling, presence, voice, pose, and shared objects as separate
  layers makes reuse easier.
- Strong donors define update cadence and payload shape explicitly:
  protobuf messages, Float32Array pose packets, NetworkVariables, or JSON
  object events.
- Product references matter when they show mixed VR/desktop/spectator roles
  even if the implementation is incomplete.

## Methods Added Or Reinforced

- WebXR room server plus P2P pose/audio channel.
- Unity WebXR Lobby/Relay/Vivox/NGO room shell.
- Shared-object WebXR room with VR/desktop fallback.
- Spatial HUD/view-registry and presence orchestration.

## Follow-Up Gaps

- Build a shared-room transport matrix across WebSocket, WebRTC, socket.io,
  PeerJS, Unity Relay, and service-hosted rooms.
- Compare media permissions and privacy boundaries for voice, webcam, and
  screen/video surfaces.
- Define a small reusable room schema for future `VR-apps-lab` prototypes.
