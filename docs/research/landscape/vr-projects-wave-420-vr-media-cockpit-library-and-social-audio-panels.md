# VR Projects Wave 420 - VR Media Cockpit Library And Social Audio Panels

- Date: `2026-07-13`
- Theme: VR media/library panels, cockpit companion tablets, and social-VR
  audio recognition overlays.

## Shortlist

| Project | Study status | Why it matters |
|---|---|---|
| `VersaYT/JellyVR` | Studied | Godot/OpenXR Jellyfin theater with XR controller toggles, floating controls, MPV playback, and server/login/content UI states |
| `fpw/avitab` | Studied | X-Plane cockpit tablet with chart/map/manual/notes apps, native window and VR panel lifecycle, and simulator command bindings |
| `Soapwood/VXMusic` | Studied | Social-VR music recognition companion with desktop client, SteamVR plugin launch, HUD notifications, VRChat ChatBox output, logs, and library exports |

## Cross-Project Synthesis

This wave treats media tools as in-headset companion panels rather than just
players. JellyVR is a full media-theater shell, AviTab is a cockpit-native
knowledge tablet, and VXMusic is a recognition sidecar that routes results into
VR HUDs, VRChat, Spotify/Last.fm, and local logs.

Reusable pattern:

- provider adapter for media, documents, recognition, or cockpit data;
- in-VR panel with explicit open/close, placement, and focus behavior;
- companion app or plugin registration for startup and notifications;
- local library/log export for later desktop inspection;
- service integration boundaries for Jellyfin, simulator APIs, Shazam,
  Spotify, Last.fm, SteamVR, XSOverlay, OVR Toolkit, and VRChat ChatBox.

## Project Notes

### `VersaYT/JellyVR`

- Interesting idea:
  make a Jellyfin client feel like a VR cinema by combining Godot OpenXR,
  controller-driven panels, MPV playback, and server/login/content states.
- Code donor value:
  `godot_project/jellyvr_client.gd` shows OpenXR setup, controller button
  routing, menu/keyboard toggles, floating player controls, and MPV lifecycle.
  `godot_project/UI/state_machine.gd` is useful as a UI state signal bus.
- Product reference value:
  strong reference for a headset-first media library where playback controls,
  settings, server connection, and content browsing are spatial UI states.
- Source evidence:
  README states JellyVR is a Jellyfin VR movie theater made with Godot 4.4 and
  C++; source includes OpenXR action map, Godot UI scenes, MPV bridge, and
  native network utility code.
- Reusable core:
  XR panel toggles, floating controls, content-provider client, playback state
  model, keyboard visibility, and media session cleanup.
- What not to copy:
  app-specific Jellyfin assumptions, early-development UX gaps, or hard-wired
  Godot scene structure without a provider abstraction.
- What to inspect next:
  authentication persistence, MPV error recovery, theater environment switching,
  Android export caveats, and provider-neutral media descriptors.

### `fpw/avitab`

- Interesting idea:
  put a tablet-style app launcher directly into a flight cockpit so PDF charts,
  maps, routes, airports, notes, and manuals do not require leaving VR.
- Code donor value:
  `src/avitab/AviTab.cpp` exposes command registration, menu entries, native
  window creation, panel creation, app switching, window rect persistence, and
  cleanup. `src/charts/ChartService.cpp` shows local/provider chart routing.
- Product reference value:
  excellent reference for domain-specific companion tablets: a VR utility does
  not need to own the whole session if it owns a high-value panel surface.
- Source evidence:
  README describes VR cockpit tablet use and chart/document apps; source shows
  `AviTab/toggle_tablet` and per-app commands for charts, airports, routes,
  maps, manuals, notes, Navigraph, and about.
- Reusable core:
  domain tablet shell, app launcher, simulator command bindings, panel/window
  lifecycle, persistent placement, and content-provider multiplexing.
- What not to copy:
  X-Plane-only plugin interfaces, legacy repository location, and aviation data
  specifics unless building a cockpit tool.
- What to inspect next:
  current `TeamAvitab/avitab` fork, aircraft integration APIs, touch/ray input
  mapping, and chart provider auth.

### `Soapwood/VXMusic`

- Interesting idea:
  recognize music during social VR sessions and route results through HUD
  notifications, local libraries, VRChat ChatBox, and music services.
- Code donor value:
  README/source layout document a full companion-product shell: installer,
  updater, SteamVR plugin install, notification targets, track library, logs,
  and service connection tabs.
- Product reference value:
  strong pattern for social-VR micro-utilities: one narrow value, many output
  surfaces, and friendly user-facing setup.
- Source evidence:
  README documents Shazam recognition, SteamVR/XSOverlay/OVR Toolkit
  notifications, VRChat ChatBox, Spotify playlists, Last.fm scrobbling, logs,
  and SteamVR plugin installation.
- Reusable core:
  recognition trigger, result record, notification router, social-app output,
  desktop client settings, update prompt, and local evidence/log folder.
- What not to copy:
  brand-specific assets, third-party service credentials, or social broadcast
  defaults without consent controls.
- What to inspect next:
  notification adapters, VRChat world-name detection, Spotify review fallback,
  and privacy/retention choices for recognition logs.

## Reusable Pattern Extraction

- Pattern candidate:
  `VR media/cockpit companion panel`.
- Problem solved:
  users need media, documents, recognition results, maps, or helper data inside
  VR without breaking immersion or losing session context.
- Reusable core:
  provider adapter, panel lifecycle, placement/focus behavior, input adapter,
  local library/logs, notification routing, companion startup, and settings.
- Abstraction boundary:
  keep external providers and simulator/social-platform integrations behind
  adapters; keep the in-VR panel as a generic command and display surface.
- Method catalog action:
  add new method for media/cockpit companion panels.

## Follow-Up Gaps

- Compare native overlay, simulator plugin panel, Godot scene panel, and
  desktop companion notification routing.
- Design a neutral `media/document/recognition event` schema.
- Capture consent defaults for social sharing and local retention.
