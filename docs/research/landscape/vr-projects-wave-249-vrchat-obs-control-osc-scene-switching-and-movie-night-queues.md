# VR Projects Wave 249: VRChat OBS Control, OSC Scene Switching, and Movie Night Queues

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies control bridges where VRChat, OSC, OBS WebSocket, OBS scripts,
or a local web app drive stream state: start/stop streaming, recording, replay
buffer, scene selection, microphone muting, loading-screen transitions, and
movie-night queue playback.

## Why It Matters For `VR-apps-lab`

VR utility work often needs an operator surface that is reachable from inside
VR but affects desktop infrastructure outside VR. These projects show several
control boundaries: avatar expression menus, OSC parameters, OBS WebSocket,
OBS Python/Lua scripts, VRChat mods, keyboard hotkey shims, and local queue
management.

## Project Notes

### `nerdywoffy/vrchat-obs-controller`

- Interesting idea:
  an external Go sidecar can map VRChat avatar parameters to OBS and
  Streamlabs actions, then send OBS status back to VRChat.
- Code donor value:
  `app.go` defines parameter addresses for replay buffer, recording, stream,
  and scene selector. It polls OBS every 500 ms and sends status booleans and
  current scene number to `/avatar/parameters/...`. `obs/obs.go` defines a
  backend-neutral interface, while `obs/v5` and `obs/streamlabs` implement OBS
  WebSocket v5 and Streamlabs RPC. `osc/server.go` provides typed boolean and
  integer listeners.
- Product reference value:
  strong reference for avatar-action-menu-driven stream controls.
- What to inspect next:
  compare the poll loop with event-driven OBS status subscriptions.
- Architecture pattern:
  YAML config -> OSC server/client -> OBS backend adapter -> avatar status
  feedback.
- Reusable method:
  define the VRChat parameter contract first, then isolate OBS version
  differences behind a small interface.
- Caveats:
  stores OBS credentials in config, assumes local OSC addresses, and can spam
  state updates if not rate-limited.

### `rogeraabbccdd/VRChat-OBSOSC`

- Interesting idea:
  a compact Node bridge can control OBS from avatar expression menus and keep
  the avatar synced with current OBS stream/scene state.
- Code donor value:
  `index.js` creates an OSC server/client pair, loads `config.ini`, supports
  OBS WebSocket v4 and v5 libraries, sends startup stream and scene status back
  to avatar parameters, subscribes to OBS stream and scene events, and maps
  incoming `stream` and `scene` parameter changes to OBS operations.
  `utils/obs.js` isolates v4/v5 request names.
- Product reference value:
  clean micro-reference for a small public bridge with screenshots and
  expression-menu setup.
- What to inspect next:
  compare with `vrchat-obs-controller` for schema naming and feedback cadence.
- Architecture pattern:
  config.ini -> OBS WebSocket adapter -> OSC parameter bridge -> expression
  menu.
- Reusable method:
  support OBS WebSocket API version drift in one adapter file.
- Caveats:
  default password is empty, setup depends on avatar parameters, and no
  permission model beyond localhost config is visible.

### `ioarchive/obscontrol`

- Interesting idea:
  a VRChat mod can expose OBS controls directly inside the VRChat quick menu
  and switch scenes on world leave/join.
- Code donor value:
  `Main.cs` is a MelonLoader mod with ReMod UI dependencies and Harmony patches
  for world join. `OBSMenu.cs` builds a quick-menu page, connects to
  obs-websocket, displays connection/stream/record/scene state, and adds
  buttons for recording and streaming. `World.cs` stores the prior scene and
  switches scenes on leave/join based on preferences.
- Product reference value:
  useful UX reference for in-headset operator controls, but not a recommended
  reuse path.
- What to inspect next:
  translate the quick-menu UX into a compliant OSC/overlay surface.
- Architecture pattern:
  game mod -> quick menu controls -> obs-websocket -> scene lifecycle hooks.
- Reusable method:
  world-transition state can drive stream scene changes, but it should be
  implemented through supported external channels.
- Caveats:
  README says it no longer works because of EAC, VRChat mods carry policy risk,
  and source is useful mainly as historical UX reference.

### `TuTu475/VRC-OBS-MicControl`

- Interesting idea:
  an OBS Python script can listen to VRChat's `muteself` OSC output and correct
  OBS microphone mute state with debounce and periodic reconciliation.
- Code donor value:
  `VRC-OBS-MicControl.py` parses OSC messages and bundles, exposes OBS script
  settings for source name, port, debounce, correction interval, inversion, and
  debug logs, and applies mute state to a selected OBS audio source.
- Product reference value:
  strong micro-utility reference for one narrowly valuable automation.
- What to inspect next:
  compare direct OBS source control with hotkey-based mute bridges.
- Architecture pattern:
  OBS script settings -> UDP OSC listener -> debounce/correction -> audio
  source mute.
- Reusable method:
  for noisy social-VR state, add both debounce and periodic state correction.
- Caveats:
  fixed localhost and parameter name unless editing code, OBS Python
  environment dependency, and source-name localization issues.

### `dimebag29/VRChatObsMicMuteLink`

- Interesting idea:
  a small tray app can listen for VRChat mute OSC and press OBS hotkeys instead
  of controlling OBS through its API.
- Code donor value:
  the Python script starts a daemon OSC server on localhost:9001, maps
  `/avatar/parameters/MuteSelf`, and sends Shift+Ctrl+Alt+[ or ] through
  `win32api.keybd_event`. It packages as a tray app with pystray and an icon.
- Product reference value:
  useful fallback pattern when an app should avoid OBS WebSocket configuration.
- What to inspect next:
  treat this as hotkey-shim reference, not a preferred OBS integration.
- Architecture pattern:
  OSC listener -> state callback -> OS hotkey injection -> OBS hotkey mapping.
- Reusable method:
  hotkey shims can be a low-friction fallback, but should be explicit about
  focus, security, and key-conflict caveats.
- Caveats:
  Windows-only, global hotkey injection, hardcoded key chords, and booth page
  hosts the primary product docs.

### `0x29a-blink/VRChat-Movie-Night`

- Interesting idea:
  a local password-protected web app can manage movie-night downloads,
  watchlists, queues, OBS media-source playback, and MediaMTX HLS output for
  VRChat video players.
- Code donor value:
  `backend/app/obs/controller.py` wraps obs-websocket v5 with thread-safe
  connect/retry/backoff, transient-busy handling, media playback controls, and
  playback-ended callbacks. `playqueue/manager.py` keeps queue order,
  current-index state, auto-advance debouncing, stall detection, and player
  broadcasts. `mediamtx/settings.py` patches HLS presets in `mediamtx.yml` and
  applies them through the MediaMTX control API. `network_utils.py` builds LAN
  HLS URLs and validates playlist readiness. The README names the full
  OBS -> RTMP -> MediaMTX -> HLS -> VRChat screen pipeline.
- Product reference value:
  strong donor for event-night operator surfaces and stream-to-world tooling.
- What to inspect next:
  extract a smaller "OBS media source queue to HLS" reusable plan.
- Architecture pattern:
  authenticated local web app -> queue/player service -> OBS media source ->
  RTMP ingest -> MediaMTX HLS -> VRChat video player.
- Reusable method:
  keep media queue state, OBS control, stream-health checks, and HLS tuning as
  separate services.
- Caveats:
  broad app scope, many external tools, ports and credentials to secure, and
  torrent/search features that are outside `VR-apps-lab`'s reusable core.

### `MissingNO123/OBS-Scripts-for-VRChat`

- Interesting idea:
  OBS scripts can provide both loading-screen scene switching and avatar
  action-menu control without a standalone companion app.
- Code donor value:
  `vrcload-sceneswitcher.py` tails the active VRChat log, detects destination
  and world-transition lines, stores the last scene, and switches OBS frontend
  scenes through script settings. `osc-radial.py` uses `vrchat_oscquery` to
  listen for configurable avatar parameters, controls recording, streaming,
  replay buffer, save replay, pause, and scene index slots, and sends status
  back to VRChat.
- Product reference value:
  excellent reference for OBS-native automation packaging.
- What to inspect next:
  build a matrix comparing this OBS-script approach with external sidecars.
- Architecture pattern:
  OBS script UI -> log watcher or OSCQuery server -> OBS frontend operations
  -> optional avatar feedback.
- Reusable method:
  when OBS is the only output target, an OBS script can reduce install
  complexity and keep configuration in the OBS scripts panel.
- Caveats:
  depends on OBS Python scripting, VRChat log strings, and avatar parameter
  setup; script reload behavior needs care.

## Reusable Pattern Extraction

- Pattern candidate:
  VRChat-to-OBS bidirectional control bridge.
- Problem solved:
  streamers need to control desktop streaming software while in VR and need to
  know whether the command actually changed OBS state.
- Reusable core:
  command source, parameter schema, OBS backend adapter, idempotent action
  mapping, status feedback, debounce/backoff, scene list mapping, and visible
  failure state.
- Source evidence:
  `vrchat-obs-controller`, `VRChat-OBSOSC`, `obscontrol`,
  `VRC-OBS-MicControl`, `VRChatObsMicMuteLink`,
  `VRChat-Movie-Night`, and `OBS-Scripts-for-VRChat`.
- Abstraction boundary:
  separate VRChat input contract from OBS API version, and separate OBS action
  execution from status feedback.
- What not to copy:
  VRChat mod hooks as a current architecture, global hotkeys without conflict
  review, empty/default OBS passwords, broad media-piracy-adjacent features, or
  command handlers without debouncing.
- Method catalog action:
  add a method entry for bidirectional VRChat-to-OBS control bridges.

## Follow-Up Gaps

- Compare avatar-parameter naming across OBS control bridges.
- Extract a minimal OBS WebSocket v5 adapter and a minimal OBS-native script
  pattern.
- Build safety notes for stream controls: confirmation, auth, localhost-only,
  scene index bounds, debounce, and feedback.
