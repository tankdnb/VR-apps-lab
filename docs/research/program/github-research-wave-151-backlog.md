# GitHub Research Wave 151 Backlog

- Date: `2026-06-05`
- Scope: scene schemas, social world shells, multi-user state, avatars,
  spatial media, headless clients, and app runtimes.

## Completed in this wave

- Studied `phoenixbf/aton` as a modular WebXR/Three platform with scene JSON,
  scene/semantic graph parsers, spatial UI, Photon networking, avatars,
  media flow, navigation, and server-backed scene hub concepts.
- Studied `PlumCantaloupe/circlesxr` as a Networked-AFrame world framework with
  generated world parts, user/avatar templates, permissions overlay,
  networked object ownership, world identity, and cross-world visibility
  state.
- Studied `arenaxr/arena-web-core` as an MQTT-backed A-Frame scene client with
  user/hand publishing, Jitsi video, screenshareable objects, spatial audio
  stream patches, text-input prompts, and remote-render visibility boundaries.
- Studied `BasisVR/Basis` as a Unity/social VR stack with transport registry,
  network abstractions, headless console clients, fake pose generation,
  compressed avatar packets, avatar loading/fallback, and buffer pools.
- Studied `webaverse-studios/webaverse` as a browser world/app runtime with
  `App` components, dynamic import manager, component templates, client/engine
  comms proxies, world/app managers, and local/remote player managers.

## Reuse candidates

- `ATON` is the strongest donor for scene JSON, semantic graph, spatial UI,
  and modular WebXR platform boundaries.
- `circlesxr` is the strongest donor for Networked-AFrame world packaging and
  ownership/visibility handling.
- `arena-web-core` is the strongest donor for MQTT scene messages, spatial
  media objects, controller/hand publishing, and DOM prompt bridges.
- `Basis` is the strongest donor for headless avatar test clients and
  compressed avatar sync packets.
- `webaverse` is the strongest donor for app module runtime and world/player
  manager boundaries.

## Follow-up backlog

1. Extract a `shared VR utility room architecture` note comparing scene schema,
   object ownership, player state, media objects, and app module systems.
2. Compare MQTT/NAF/Photon/WebRTC/Jitsi transport boundaries with prior
   bridge, OSC, WebSocket, and remote streaming waves.
3. Track headless/synthetic clients as a major diagnostics/load-test branch.
4. Compare scene JSON and component templates against immersive analytics
   configs from Wave 149.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
