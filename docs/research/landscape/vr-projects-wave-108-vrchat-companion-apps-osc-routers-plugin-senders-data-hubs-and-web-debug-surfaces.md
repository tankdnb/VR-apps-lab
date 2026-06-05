# VR Projects Wave 108: VRChat Companion Apps, OSC Routers, Plugin Senders, Data Hubs, and Web Debug Surfaces

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `VRChat companion apps`, `OSC routers`, `plugin senders`, `data hubs`, and
  `web debug surfaces`.

## Why this wave exists

VRChat utility work is not only avatar prefabs or Udon worlds. A lot of the
reusable engineering sits in companion apps that live next to VRChat: desktop
social dashboards, overlay feeds, OSC routers, plugin sender hosts, small data
hubs, and browser panels for live avatar parameters.

This wave studies those tools as a coherent family of external control and
inspection surfaces.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by VRChat companion, OSC router, data hub, and browser-control
   families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `vrcx-team/VRCX` | Large VRChat companion app with desktop UI, rich social state, overlay feed, and Linux offscreen overlay rendering path |
| `SutekhVRC/VOR` | Rust OSC fan-out router with route config, packet filtering, malformed-packet repair, and debug streams |
| `YABam/VRCOSCGUI` | Plugin-hosted OSC sender framework where plugins request sends and the holder owns sockets |
| `PlagueVRC/VRCOSCDataHub` | Narrow OSC-to-TCP hub that forwards parsed VRChat OSC data to multiple downstream programs |
| `EveryDayCompute/VRCOSCWeb` | Browser-based avatar parameter debug and control surface backed by OSC and avatar JSON files |

## Deep-pass notes by project

## `vrcx-team/VRCX`

- GitHub:
  [vrcx-team/VRCX](https://github.com/vrcx-team/VRCX)
- What it is:
  a large Electron/Vue VRChat companion app for friends, worlds, avatars,
  notes, invites, instance stats, notifications, Discord Rich Presence, image
  management, restart/rejoin flows, and a VR overlay feed.
- Interesting idea:
  a companion app can become an operator feed for social, location, avatar,
  media, and device state rather than only a desktop archive.
- Code-level notes:
  `src-electron/main.js`
  creates the Electron main process, exposes IPC handlers, and on Linux builds
  an offscreen overlay window whose painted bitmap is copied into a shared
  memory path under `/dev/shm/vrcx_overlay`.
  `src/vr/vr.js`
  and `src/vr/Vr.vue`
  define the VR overlay route and feed UI. The feed surfaces friends, worlds,
  current location, avatar changes, video links, chatbox events, social status,
  CPU/online-friend summaries, and headset/controller/tracker/base-station
  device states with battery and connection indicators.
- Code donor value:
  high for desktop-companion architecture, overlay feed design, and offscreen
  Electron rendering into a runtime-facing buffer.
- Product reference value:
  very high for showing how a companion app can turn background VRChat state
  into a live in-headset operator surface.
- Caveats:
  the app is large, long-lived, and deeply tied to VRChat behavior; the useful
  donor value should be extracted as patterns rather than copied wholesale.
- What to inspect next:
  compare VRCX overlay feed design with OpenVR overlay-first shells such as
  DesktopPlus, SteamVR-WebApps, and VRSceneOverlay.

## `SutekhVRC/VOR`

- GitHub:
  [SutekhVRC/VOR](https://github.com/SutekhVRC/VOR)
- What it is:
  a cross-platform OSC router for VRChat that receives OSC on one port and
  forwards it to multiple configured apps.
- Interesting idea:
  OSC port contention can be solved as a first-class router product with
  packet filters, app routes, debug modes, and premade configs for common
  consumers.
- Code-level notes:
  `src/routing.rs`
  listens on the VRChat OSC socket, applies packet filtering, broadcasts
  accepted packet buffers to route workers, and supports both sync and async
  route modes.
  `src/pf.rs`
  implements `PacketFilter` with blacklist, whitelist, malformed-packet
  filtering, `rosc` decode/encode cleanup, and debug messages for allowed or
  dropped packets. Route workers emit status and error events so the UI can
  explain where data is going.
- Code donor value:
  high for OSC fan-out routing, packet sanitation, and debug instrumentation.
- Product reference value:
  high for a narrow utility that solves a painful local integration problem.
- Caveats:
  router behavior must be careful about lag, dropped routes, and malformed
  sender packets; the strongest value is in the explicit debug path.
- What to inspect next:
  compare against haptics, speech, tracking, and avatar-automation sidecars
  that all compete for the same VRChat OSC ports.

## `YABam/VRCOSCGUI`

- GitHub:
  [YABam/VRCOSCGUI](https://github.com/YABam/VRCOSCGUI)
- What it is:
  a Windows OSC holder app with a plugin model; plugins request OSC sends and
  receive holder status instead of each plugin owning the socket directly.
- Interesting idea:
  a plugin-hosted OSC sender can centralize network ownership while allowing
  small feature modules to stay simple.
- Code-level notes:
  `IOSCPlugin/IOSCPlugin.cs`
  defines the plugin contract: `WhoAmI`, `Action`, `Settings`,
  `OnHolderStatusChange`, `OnHolderOSCReceived`, plus events for console
  output and `SendOSCRequest`. `HolderStatus` exposes local and remote
  endpoints and UDP status, giving plugins enough context without giving them
  responsibility for socket lifecycle.
- Code donor value:
  medium-high for plugin contract design and socket ownership boundaries.
- Product reference value:
  medium-high for a modular desktop OSC utility where feature plugins can be
  developed independently.
- Caveats:
  this wave only needed the holder/plugin boundary; deeper inspection should
  compare actual bundled plugins and settings persistence.
- What to inspect next:
  compare plugin-hosted OSC senders with module-host patterns from
  VRCFaceTracking and VRCFury-style public API helpers.

## `PlagueVRC/VRCOSCDataHub`

- GitHub:
  [PlagueVRC/VRCOSCDataHub](https://github.com/PlagueVRC/VRCOSCDataHub)
- What it is:
  a small OSC-to-TCP data hub that forwards VRChat OSC values to downstream
  local programs in a simple split-friendly text format.
- Interesting idea:
  a local bridge can reduce OSC complexity for downstream tools by normalizing
  addresses and typed values into a plain text stream.
- Code-level notes:
  `DataHubDesign.cs`
  starts an OSC server on port `9001`, receives all OSC packets, iterates
  values by type tag, supports common OSC value types, formats each message as
  `address;value|value`, and sends it through a TCP server.
  `TCPLib/TCP_Server.cs`
  accepts a TCP client and exposes a simple `Send(string)` path for downstream
  consumers.
- Code donor value:
  medium for OSC type-tag extraction and text normalization.
- Product reference value:
  high for a tiny bridge that makes VRChat OSC usable by non-OSC tools.
- Caveats:
  the TCP implementation is intentionally simple and should be redesigned for
  multiple clients, framing, backpressure, and cleaner receive loops before any
  serious reuse.
- What to inspect next:
  compare with WebSocket data hubs and OSC routers when designing local debug
  buses.

## `EveryDayCompute/VRCOSCWeb`

- GitHub:
  [EveryDayCompute/VRCOSCWeb](https://github.com/EveryDayCompute/VRCOSCWeb)
- What it is:
  a Quart-based web app that displays and controls VRChat avatar parameters
  through OSC, WebSockets, and local avatar JSON files.
- Interesting idea:
  avatar parameter debugging can be a browser app: read VRChat avatar JSON,
  draw live controls, send OSC back, and show parameter updates without a full
  desktop shell.
- Code-level notes:
  `VRCOSCWebInterface.py`
  starts a Quart app, runs an OSC dispatcher on `127.0.0.1:9001`, tracks
  `/avatar/change` and `/avatar/parameter/*`, loads avatar parameter metadata
  from `AppData/LocalLow/VRChat/VRChat/OSC/.../Avatars/*.json`, broadcasts
  state to WebSocket clients, and sends OSC messages to VRChat on port `9000`.
  `templates/interface.html`
  uses D3 to create sliders, buttons, chatbox controls, WASD movement buttons,
  reconnect logic, and inbound/outbound debug toggles.
- Code donor value:
  high for OSC plus WebSocket plus avatar JSON control architecture.
- Product reference value:
  very high for browser-native avatar debugging and operator controls.
- Caveats:
  it assumes VRChat's local OSC avatar JSON layout and local ports; a reusable
  version should expose profile selection and error states more explicitly.
- What to inspect next:
  compare with Electron and overlay shells to decide when browser surfaces are
  enough for a VR utility.

## Main takeaways from Wave 108

- VRChat companion utilities split into desktop companion state, overlay
  feeds, OSC routing, plugin-hosted sends, data hubs, and browser debug panels.
- OSC tools become much more useful when they include status, packet filters,
  route-level debug, and simple downstream formats.
- Browser panels are strong product references for fast local debugging,
  especially when paired with avatar JSON metadata.
- Large companion apps should be mined for architecture patterns and UX flows,
  not copied as monoliths.

## Reusable methods clarified by this wave

- `Companion overlay live-feed shell with offscreen Electron rendering`
- `VRChat OSC fan-out router with packet filtering and route debug stream`
- `Plugin-host OSC sender where extensions request sends and holder owns sockets`
- `OSC-to-TCP data hub with type-tag extraction and split-friendly payloads`
- `Browser avatar-parameter debug surface backed by OSC and avatar JSON`

## Recommended next moves after this wave

1. Keep VRCX visible as the strongest large companion and overlay-feed
   reference.
2. Keep VOR visible as the cleanest local OSC router and debug-instrumented
   fan-out reference.
3. Compare VRCOSCGUI, VRCOSCDataHub, and VRCOSCWeb when designing small local
   control surfaces that should not become giant apps.
4. Revisit OSC routing whenever speech, haptics, tracking, avatar automation,
   and browser debug tools need to coexist.
