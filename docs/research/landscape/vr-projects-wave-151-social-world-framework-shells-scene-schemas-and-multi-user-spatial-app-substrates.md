# VR Projects Wave 151: Social/World Framework Shells, Scene Schemas, and Multi-User Spatial App Substrates

- Date: `2026-06-05`
- Goal: study reusable social/world runtime patterns for collaborative VR
  utilities, shared diagnostics rooms, multi-user data surfaces, and spatial
  app shells.

## Why this wave exists

Single-user utilities are easier to reason about, but many high-value VR tools
become collaborative: a support person joins a user's space, developers inspect
runtime state together, or a group looks at shared telemetry. This wave studies
how social/world frameworks divide scene data, networking, avatars, media,
input, and app modules.

## Better workflow used in this wave

1. searched by WebXR social world, scene schema, Networked-AFrame, ARENA,
   headless social VR client, and web metaverse runtime families;
2. deduplicated against earlier networked/social XR and browser runtime waves;
3. froze a shortlist across semantic scene hub, Networked-AFrame world shell,
   MQTT/Jitsi scene client, Unity/social VR networking stack, and browser
   app-runtime references;
4. inspected local-only source clones;
5. extracted reusable methods without running, building, installing, or
   launching the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `phoenixbf/aton` | Scene JSON, semantic graphs, Photon networking, SUI, avatars |
| `PlumCantaloupe/circlesxr` | Networked-AFrame world shell and ownership/visibility model |
| `arenaxr/arena-web-core` | MQTT-backed scene client with spatial media and input publishing |
| `BasisVR/Basis` | Social VR network stack, headless clients, compressed avatars |
| `webaverse-studios/webaverse` | Browser app-runtime, world manager, and player manager substrate |

## Deep-pass notes by project

## `phoenixbf/aton`

- GitHub:
  [phoenixbf/aton](https://github.com/phoenixbf/aton)
- What it is:
  a WebXR/Three platform for 3D scenes, semantic graphs, spatial UI, media,
  networking, and web applications.
- Interesting idea:
  make scene JSON and semantic scene graphs first-class runtime inputs, then
  attach spatial UI, Photon networking, avatars, media flow, navigation, and
  server APIs around that core.
- Code-level notes:
  `public/src/ATON.js` assembles a broad module namespace including Node, POV,
  EventHub, MatHub, SceneHub, AudioHub, Nav, XR, SUI, UI, Photon,
  SemFactory, MediaFlow, App, FX, MRes, requests, and graph services.
  `public/src/ATON.scenehub.js` loads scene JSON, clears scene and semantic
  roots, parses top-level fields such as title, description, FX, environment,
  soundscape, nav mode, locomotion graph, measurements, viewpoints, scene
  graph, semantic graph, and XPF network. It builds scene and semantic nodes
  from JSON nodes/edges and can persist/edit server-backed scene changes.
  `public/src/ATON.sui.js` builds spatial UI roots, teleport indicators,
  semantic icons, measurement lines, labels, point editors, and info nodes.
  `public/src/ATON.photon.js` tracks socket connection state, user ids,
  avatar lists, focus nodes, chat log, user colors, state send frequency, and
  avatar materials. `public/src/ATON.avatar.js` builds avatar labels, talk
  audio, focus positions, stream panels, and smoothed current/target state.
- Architecture pattern:
  modular scene platform with JSON scene hub, semantic graph, spatial UI, and
  networked avatars.
- Reusable method:
  separate scene graph, semantic graph, navigation, measurements, viewpoints,
  and media into parseable scene JSON sections.
- Code donor value:
  high for scene schema parsing, semantic graph handling, and spatial UI
  module boundaries.
- Product reference value:
  high for collaborative diagnostics rooms and shared 3D data viewers.
- Constraints and caveats:
  broad framework with globals and older web patterns; reuse should extract
  schema/module ideas, not import the whole platform.
- What to inspect next:
  compare scene JSON with `vria` configs and Webaverse app specs.

## `PlumCantaloupe/circlesxr`

- GitHub:
  [PlumCantaloupe/circlesxr](https://github.com/PlumCantaloupe/circlesxr)
- What it is:
  a Networked-AFrame based framework and set of worlds for shared WebXR
  experiences.
- Interesting idea:
  generate worlds from shared parts while using components to track user,
  avatar, object-world identity, networked ownership, and visibility.
- Code-level notes:
  `src/webpack.worlds.parts/circles_scene_properties.part.html` configures
  renderer options, `networked-scene`, room, connection callbacks, audio,
  adapter, server URL, shadows, VR mode UI, loading screen, device-orientation
  permission UI, enter UI, and scene shadow components. `circles_avatar_manager.part.html`
  creates the manager entity and `Player1` rig with avatar model/color/name
  attributes. `src/components/circles-user-networked.js` updates remote avatar
  head, hair, body, colors, visible name, user type, device icon, and world
  metadata after avatar load events. `src/components/circles-object-world.js`
  records source world, object id, pickup state, and creation time. `src/components/circles-networked-basic.js`
  detects Networked-AFrame clones, attaches `networked` templates, publishes
  attach/detach messages over the Circles websocket, tracks last known object
  data, elects visible/hosting instances, and toggles interactivity/visibility.
  World `settings.JSON` files store name, authors, image path, descriptions,
  tags, type, visibility, and supported devices.
- Architecture pattern:
  Networked-AFrame world shell plus generated world parts plus ownership and
  world-identity components.
- Reusable method:
  keep networked object identity separate from rendered entity identity so
  clones, ownership, and cross-world visibility can be reasoned about.
- Code donor value:
  medium-high for NAF object ownership, world identity, and world template
  composition.
- Product reference value:
  high for social WebXR room packaging and user onboarding.
- Constraints and caveats:
  application/world content is mixed with framework code; reuse should focus
  on generated parts and components.
- What to inspect next:
  compare object ownership flow with ARENA MQTT object publishing.

## `arenaxr/arena-web-core`

- GitHub:
  [arenaxr/arena-web-core](https://github.com/arenaxr/arena-web-core)
- What it is:
  the A-Frame-based web client core for the ARENA platform.
- Interesting idea:
  publish scene objects, user presence, hands, controller events, text input,
  and media surfaces through an MQTT/Jitsi/WebRTC-backed spatial client.
- Code-level notes:
  `src/index.js` loads A-Frame systems, geometries, components, patches, and
  CSS. `src/components/camera/arena-user.js` builds another user's head model,
  name text, microphone icon, Jitsi state, video/audio ids, panoramic video
  state, distance tracking, and a Chrome AEC workaround that routes WebAudio
  through a local WebRTC loopback. `src/components/camera/arena-hand.js`
  publishes controller connection, deletion, pose updates, and button events
  to MQTT topics using rounded positions/quaternions and per-hand object ids.
  `src/components/object/jitsi-video.js` binds a Jitsi user's video track to a
  geometry or videosphere by id or display name and retries until media is
  ready. `src/systems/scene/screenshare.js` registers screenshareable objects
  and exposes an HTML select list of available targets. `src/components/object/text-input.js`
  opens a SweetAlert DOM prompt, limits text, and publishes a clientEvent to
  public/private/program MQTT topics. `src/aframe-mods/webrtc-positional-sound.js`
  patches A-Frame sound to accept media streams as positional audio sources.
  `src/components/renderfusion/remote-render.js` computes object stats and
  hides local geometry when remote rendering is enabled.
- Architecture pattern:
  MQTT-backed scene object protocol plus Jitsi media surfaces plus A-Frame
  components.
- Reusable method:
  publish user hands and UI events as scene-user objects/events so remote tools
  can subscribe without owning the whole client.
- Code donor value:
  high for scene message topics, hand publishing, media binding, text prompt,
  and WebRTC positional audio patches.
- Product reference value:
  high for shared diagnostics dashboards, remote support rooms, and spatial
  control surfaces.
- Constraints and caveats:
  platform-specific globals and services mean reuse should extract component
  boundaries and protocol shapes.
- What to inspect next:
  compare MQTT scene messages against OSC/WebSocket bridge families.

## `BasisVR/Basis`

- GitHub:
  [BasisVR/Basis](https://github.com/BasisVR/Basis)
- What it is:
  a Unity/social VR platform and networking stack with server, client,
  avatars, media, and tooling packages.
- Interesting idea:
  include headless synthetic clients that send realistic compressed avatar pose
  packets, making load testing and network diagnostics part of the platform.
- Code-level notes:
  `Basis Server/BasisNetworkCore/BasisNetworkShell.cs` defines networking
  abstractions such as disconnect reasons, event-based listener callbacks,
  connection requests, peers, managers, delivery methods, packet readers,
  stats, MTU, and send primitives. `BasisNetworkStackRegistry.cs` registers
  network stacks, parsers, probes, tick hooks, peer introducers, active stack
  changes, fallback behavior, and server probe results. The console client
  files create headless users: `ClientManager.cs` creates many clients with
  display names, DIDs, avatar change messages, ready messages, manual network
  mode, reconnect logic, auth challenge signing, and cached avatar/password
  bytes. `MovementSender.cs` builds and sends high-quality avatar sync packets
  with position, bone rotations, scale, hips rotation, sequence byte, and
  unreliable delivery. `FakePoseGenerator.cs` generates 51-bone natural
  standing poses, idle animation, smallest-three compressed quaternions,
  explicit hips identity/local slots, and per-client phase offsets.
  `BasisAvatarBitPacking.cs` and `BasisBoneRotationCompression.cs` define
  quality levels, packet sizes, bone write order, bits-per-component tables,
  anatomical ranges, and compressed tail slots. `BasisAvatarBuffer.cs` uses a
  lock-free pool for decoded avatar buffers. `BasisAvatarFactory.cs` handles
  local/remote avatar loading, fallback avatars, content checks, download and
  addressable gates, and cancellation tokens.
- Architecture pattern:
  social VR transport registry plus compressed avatar sync plus synthetic
  headless clients.
- Reusable method:
  design diagnostics clients that speak the real avatar/network protocol rather
  than simplified fake messages.
- Code donor value:
  very high for headless clients, packet compression, and avatar network
  testing patterns.
- Product reference value:
  high for load tests, replay tools, and multi-user diagnostics infrastructure.
- Constraints and caveats:
  large Unity platform; reuse should focus on protocol/testing concepts.
- What to inspect next:
  compare headless clients with no-HMD virtual-HMD workflows and replay tools.

## `webaverse-studios/webaverse`

- GitHub:
  [webaverse-studios/webaverse](https://github.com/webaverse-studios/webaverse)
- What it is:
  a browser-based spatial world/runtime project with engine, client,
  multiplayer, app-runtime, and app/module concepts.
- Interesting idea:
  represent each world object as an `App` with components, dynamic modules,
  activation/wear/use/destroy events, and app managers owned by worlds and
  players.
- Code-level notes:
  `packages/app-runtime/app.js` defines `App` as a `THREE.Object3D` with
  components, description, app type, modules, content id, instance id, component
  update events, activate/wear/unwear/use/destroy events, and transform state.
  `packages/app-runtime/import-manager.js` resolves object URLs, dynamically
  imports modules, creates apps from specs, applies transforms, binds component
  templates, and supports async app creation from an engine. `packages/client/src/comms/client-comms.js`
  creates postMessage-based proxies for diorama manager, local player, and IO
  handler. `packages/engine/realms/world.js` owns an `AppManager`, HP manager,
  world object, render-priority scene binding concepts, and realm spec loading
  through scene URLs. `packages/engine/players-manager.js` owns local and
  remote players, creates local/remote player app managers, dispatches player
  changes, and updates avatars. Client components such as `AiMenu`, `Chat`,
  `DomRenderer`, and `Equipment` show the split between React/DOM UI and engine
  runtime state.
- Architecture pattern:
  browser world runtime with app specs, component templates, dynamic imports,
  app managers, and player managers.
- Reusable method:
  treat spatial world objects as loadable apps with components and lifecycle
  events rather than as static scene nodes.
- Code donor value:
  high for app-runtime/module boundaries and world/player app-manager split.
- Product reference value:
  high for extensible browser VR utility shells and plugin-like spatial tools.
- Constraints and caveats:
  large and historically changing codebase; patterns should be extracted with
  version awareness.
- What to inspect next:
  compare app specs/components with ATON scene JSON and VRIA visualization
  configs.

## Cross-project synthesis

This wave shows five ways to make VR utilities shared:

- ATON: scene JSON plus semantic graph plus spatial UI and avatars;
- CirclesXR: Networked-AFrame worlds, generated parts, object ownership;
- ARENA: MQTT scene protocol plus Jitsi/WebRTC media and DOM prompts;
- Basis: Unity social VR networking plus headless avatar clients;
- Webaverse: app-runtime modules and world/player app managers.

For `VR-apps-lab`, the reusable collaborative utility shape is:

- scene/world definition is data, not scattered imperative code;
- object identity is separate from network clone identity;
- user, hand, media, text, and object events are published as protocol
  messages;
- headless clients can simulate real users for testing;
- app modules/components make shared utility panels extensible.

## Methods extracted

- Scene-schema social world client with spatial media, avatars, network state,
  and services.
- MQTT-backed spatial scene event protocol for hands, media, prompts, and
  object state.
- Headless/social VR network client with fake pose generation and compressed
  avatar packets.
- Spatial app-runtime with dynamic modules, component templates, world managers,
  and player app managers.

## New gaps opened

- Compare scene JSON, app specs, and visualization grammars as one broader
  `spatial data/schema` family.
- Build a shared-room utility architecture note for remote diagnostics and
  collaborative support.
- Track synthetic/headless clients as a diagnostics, load-test, and replay
  branch.
