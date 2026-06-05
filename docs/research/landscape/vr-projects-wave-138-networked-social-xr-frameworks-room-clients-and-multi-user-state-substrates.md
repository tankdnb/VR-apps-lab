# VR Projects Wave 138: Networked/Social XR Frameworks, Room Clients, and Multi-User State Substrates

- Date: `2026-06-05`
- Goal: study social/networked XR projects as reusable references for rooms,
  presence, permissions, state sync, avatars, media, and collaboration.

## Why this wave exists

Collaboration is a recurring need for VR utilities: remote diagnostics, guided
setup, shared calibration, event operations, social companion tools, and
multi-user dashboards all need some combination of room membership, identity,
permissions, state sync, and presence. This wave focuses on the substrate, not
on social worlds as products.

## Better workflow used in this wave

1. searched by Unity networking, WebXR social rooms, spatial web clients, and
   collaborative XR framework families;
2. deduplicated against browser shell, WebXR samples, and social ecosystem
   waves;
3. froze a shortlist across Unity, browser, and spatial-web stacks;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `UCL-VR/ubiq` | Research-friendly Unity/browser/Node networking substrate |
| `mozilla/hubs` | Mature WebXR room client with permissions, presence, media, and ECS state |
| `janusvr/janusweb` | Spatial web client with declarative rooms and viewer embeds |
| `vrsys/vrsys-core` | Unity Netcode/XRI/Meta Avatar framework composition reference |

## Deep-pass notes by project

## `UCL-VR/ubiq`

- GitHub:
  [UCL-VR/ubiq](https://github.com/UCL-VR/ubiq)
- What it is:
  a Unity/browser/Node networking library for VR research and teaching.
- Interesting idea:
  keep networked XR infrastructure small, self-hostable, research-friendly,
  and inspectable rather than productizing it as a locked social platform.
- Code-level notes:
  `Node/app.ts` creates a room server with TCP/WSS wrappers, nconf
  configuration, ICE provider support, room-type configuration, and graceful
  shutdown. Browser samples use `WebSocketConnectionWrapper`, `NetworkScene`,
  `RoomClient`, peer events, WebRTC peer connections, avatars, microphone
  tracks, arbitrary network IDs, and component statistics. Unity files include
  network scene, room client, avatar, and VoIP peer connection paths.
- Code donor value:
  very high for research-friendly room/network scene architecture.
- Product reference value:
  high for collaborative diagnostics and lab tools.
- Caveats:
  broad cross-platform framework; reuse should start from one room/client path.
- What to inspect next:
  extract a minimal room plus arbitrary-component message bus skeleton.

## `mozilla/hubs`

- GitHub:
  [mozilla/hubs](https://github.com/mozilla/hubs)
- What it is:
  a mature WebXR social room client.
- Interesting idea:
  permissioned social rooms can be modeled as a channel with explicit actions,
  presence events, media/object operations, and networked ECS components.
- Code-level notes:
  `hub-channel.js` wraps Phoenix channels, permission tokens, hub updates,
  mute/kick, camera spawn, drawing/media/object actions, pinning, voice/chat,
  entry events, streaming, recording, raise-hand, and typing. `bit-components`
  defines ECS networked/owned/transform/holdable/hover/held/media/camera
  components and related state.
- Code donor value:
  high for permissioned room channels, presence, media actions, and ECS
  networked state.
- Product reference value:
  high for WebXR social room UX and moderation surfaces.
- Caveats:
  large archived product stack with many external services and historical
  dependencies.
- What to inspect next:
  compare Hubs permissions/actions with smaller collaborative utility needs.

## `janusvr/janusweb`

- GitHub:
  [janusvr/janusweb](https://github.com/janusvr/janusweb)
- What it is:
  a web client for JanusVR spatial worlds.
- Interesting idea:
  spatial web rooms can be embedded as generated viewer frames and declarative
  snippets rather than only as full apps.
- Code-level notes:
  `scripts/client.js` initializes systems for controls, physics, AI, world,
  admin, render, and sound, creates a player, supports options such as chat,
  VoIP, networking, URL, autoload, and server, and defines viewer/frame custom
  elements for images, video, 360 video, models, and avatars. The external
  connection uses a WebSocket binary subprotocol, login retry, room
  subscribe/unsubscribe by URL hash, reconnect, enter, and leave.
- Code donor value:
  medium-high for declarative spatial-web embedding and room connection
  lifecycle.
- Product reference value:
  high for browser/spatial-web frontends.
- Caveats:
  historical codebase and not a focused utility.
- What to inspect next:
  compare viewer-frame generation with WebXR media and immersive browser shell
  waves.

## `vrsys/vrsys-core`

- GitHub:
  [vrsys/vrsys-core](https://github.com/vrsys/vrsys-core)
- What it is:
  a Unity framework/core package for networked XR systems.
- Interesting idea:
  package social/networked XR infrastructure as prefabs and settings: network
  manager, user spawner, connection manager, user prefabs, and collocation
  settings.
- Code-level notes:
  the current pass surfaced Unity assets and prefab references such as
  `NETCODE-NetworkManager`, `VRSYS-NetworkUserSpawner`,
  `VRSYS-ConnectionManager`, network prefab lists, desktop/HMD/Meta Avatar
  user prefabs, and collocation settings.
- Code donor value:
  medium pending a targeted package-script pass.
- Product reference value:
  medium-high for Unity framework composition and prefab packaging.
- Caveats:
  current code-level extraction is weaker than Ubiq/Hubs/JanusWeb because the
  pass mostly exposed package/prefab structure.
- What to inspect next:
  revisit package scripts if Unity Netcode/XRI/Meta Avatar composition becomes
  active.

## Cross-project extraction

- Room infrastructure should be explicit:
  room servers, room clients, peer events, presence, permissions, and shutdown
  behavior are first-class utility architecture.
- Collaboration should be inspectable:
  Ubiq's component statistics and arbitrary network IDs are especially useful
  for research and diagnostics tools.
- Permissions are a product surface:
  Hubs shows that spawn, media, camera, chat, voice, pin, mute, and kick actions
  should be designed as permissioned capabilities.
- Declarative rooms and embeds are useful beyond social VR:
  JanusWeb-style generated viewer frames can inform media/reference panels and
  spatial web utility shells.

## Reusable methods extracted

- Research-friendly network scene with room/peer properties and arbitrary
  component listener.
- Permissioned WebXR room channel with presence/action events and ECS
  networked components.
- Declarative room snippet/generated viewer for spatial web/media embeds.

## Caveats for future use

- Social XR projects are large and often service-dependent.
- Multi-user state brings moderation, identity, and privacy concerns even for
  utility tools.
- A future prototype should start from a tiny room/message substrate before
  adopting avatar/media complexity.

## Next gaps

- Build a room/presence/permission checklist for collaborative VR utilities.
- Compare Ubiq, Hubs, JanusWeb, VRSYS, and VRChat world networking references.
- Queue a collaboration-diagnostics pass if remote support tools become active.
