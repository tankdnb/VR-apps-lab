# VR Projects Wave 175: VRChat OSC Web Panels, Debug Surfaces, and Sensor Bridges

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 175 studies VRChat OSC helper surfaces and bridges: web chat panels,
diagnostic listeners, OSCQuery parameter browsers, controller/avatar
micro-tools, Leap Motion finger-to-parameter bridges, and heart-rate sensor
pipelines.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `ThatGuyThimo/leapmotion-osc` | Finger-to-avatar OSC bridge | Medium focused bridge donor |
| `a2942/VRChat-OSC-WEB-Chat` | Browser chatbox panel micro-utility | Medium product/UX donor |
| `qbitzvr/Drone-OSC-Controller` | Controller/avatar micro-tool reference | Product workflow reference |
| `ChrisFeline/VRChatOSCLib` | OSC client primitive library | Strong small-library donor |
| `firocore/VRChatOSCDebugger` | Lightweight diagnostic listener | Strong micro-diagnostic donor |
| `Misaka-L/VRChatOscDebugger` | OSCQuery-aware diagnostic surface | Strong parameter-browser reference |
| `networkpenetrationtester/VRChat-OSC-WebPanel` | Web parameter panel and OSC router donor | Strong router/panel donor |
| `200Tigersbloxed/HRtoVRChat_OSC` | Biometric sensor-to-avatar bridge donor | Strong sensor/SDK bridge donor |

## `ThatGuyThimo/leapmotion-osc`

- Interesting idea:
  map Leap Motion finger distance and spread values directly into VRChat avatar
  parameters, with a tiny Unity UI showing controller connection, FPS, and hand
  visibility.
- Code donor value:
  medium for finger metric extraction, parameter naming, and status UI.
- Product reference value:
  high for small sensor-to-avatar bridges where one external device unlocks one
  visible avatar capability.
- What to inspect next:
  compare its raw distance/spread mapping with calibration, smoothing, and
  dead-zone methods from hand-tracking/finger-tracking families.
- Source evidence:
  `Assets/LeapmotionOSC/Scripts/LeapmotionOSC.cs` and `UnityUI.cs`.
- Reusable pattern extraction:
  finger-tracking sensor to avatar-parameter OSC bridge.
- Reusable core:
  subscribe to the hand-tracking frame event, compute per-finger distance from
  palm and metacarpal/proximal spread, normalize spread against finger-specific
  limits, send `/avatar/parameters/...` values, and expose connection/hand/FPS
  status in a tiny UI.
- Do not copy directly:
  raw unsmoothed values, hardcoded port, or debug logging in the frame loop.
- Caveats:
  focused and simple; needs calibration/smoothing before becoming a general
  template.

## `a2942/VRChat-OSC-WEB-Chat`

- Interesting idea:
  make VRChat chatbox input available as a browser/mobile-friendly Flask panel
  with configurable OSC endpoint, avatars, colors, background image, typing
  state, and persistent config/assets.
- Code donor value:
  medium for small web-to-OSC route structure and config persistence.
- Product reference value:
  high for chatbox sidecars and quick browser/mobile remote-control panels.
- What to inspect next:
  compare with earlier chatbox/TTS sidecars for message pacing, history, and
  safety around network-exposed web forms.
- Source evidence:
  `HTML osc chat/osc_viewer.py` and `templates/index.html`.
- Reusable pattern extraction:
  browser chatbox panel with persisted visual theme and OSC chat/typing posts.
- Reusable core:
  keep OSC and web config in JSON, store uploaded assets in a local data
  folder, expose POST routes for chatbox input and typing indicator, reconnect
  OSC when endpoint settings change, and make the browser UI responsive enough
  for secondary devices.
- Do not copy directly:
  unauthenticated network-exposed form handling or default internet-facing bind
  without explicit user warnings.
- Caveats:
  README encoding is noisy and security hardening is outside current scope.

## `qbitzvr/Drone-OSC-Controller`

- Interesting idea:
  solve a specific VRCLens drone-control discomfort by routing opposite-hand or
  Xbox controller inputs through VRChat OSC/avatar parameters and an avatar menu
  workflow.
- Code donor value:
  low-medium because the repository is primarily package/documentation rather
  than readable source code.
- Product reference value:
  high for avatar-authored micro-tools that improve one awkward VR workflow.
- What to inspect next:
  inspect package contents only if VRChat avatar-side controller helpers become
  active scope.
- Source evidence:
  README install/usage/menu/tweak documentation.
- Reusable pattern extraction:
  avatar/menu-mediated controller micro-tool for one high-friction VR workflow.
- Reusable core:
  expose enable/mode/speed controls through an avatar submenu, integrate with
  an external OSC sender, document exact animator/parameter merge steps, and
  provide comfort tweaks for smoothing.
- Do not copy directly:
  avatar package assumptions or third-party asset dependencies without review.
- Caveats:
  current source value is mostly product workflow and documentation.

## `ChrisFeline/VRChatOSCLib`

- Interesting idea:
  wrap VRChat OSC into a small C# library with convenient methods for avatar
  parameters, input buttons/axes, chatbox messages, typing state, async sends,
  listener events, and message type classification.
- Code donor value:
  high for a compact library surface and typed VRChat OSC address helpers.
- Product reference value:
  high for future C# utilities that need OSC without re-implementing paths.
- What to inspect next:
  compare API naming with OSCQuery-aware libraries and decide a preferred
  `VR-apps-lab` helper vocabulary.
- Source evidence:
  `VRChatOSC.cs`, `VRChatOSCAsync.cs`, `VRCMessage.cs`, and `VRCInput.cs`.
- Reusable pattern extraction:
  typed VRChat OSC client/listener primitive library.
- Reusable core:
  centralize chatbox, avatar parameter, and input address constants; provide
  overloads for bool/int/float parameters; expose typed input enums/structs;
  parse incoming messages into default/custom/avatar-change categories; and
  expose listener callbacks for tools.
- Do not copy directly:
  small parsing bugs or console coloring assumptions without cleanup.
- Caveats:
  simple helper library; not a full diagnostics app.

## `firocore/VRChatOSCDebugger`

- Interesting idea:
  combine a wildcard python-osc listener, live Tkinter table, ignore list,
  copy/context actions, clear button, and VRChat log parsing for OSC-related
  settings visibility.
- Code donor value:
  high for a tiny diagnostic surface that still includes useful filtering and
  environment checks.
- Product reference value:
  high for an `OSC doctor` or parameter monitor micro-utility.
- What to inspect next:
  compare with OSCQuery-based debuggers to decide when passive listening is
  enough and when discovery is required.
- Source evidence:
  `debugger.py` and README.
- Reusable pattern extraction:
  lightweight passive OSC live table with ignore-list filtering and VRChat log
  sanity checks.
- Reusable core:
  listen on UDP `9001` with a wildcard dispatcher, store latest value per
  address, refresh a table at short intervals, allow multi-select copy and
  ignore-list persistence, parse latest VRChat log for OSC/self-interaction
  settings, and keep UI small.
- Do not copy directly:
  encoding issues, hardcoded paths, or broad exception swallowing without
  cleanup.
- Caveats:
  passive listener only; it cannot discover parameter schemas by itself.

## `Misaka-L/VRChatOscDebugger`

- Interesting idea:
  build a desktop OSC debugger around OSCQuery service discovery, connection to
  host info/nodes, hierarchical parameter tree display, avatar-change refresh,
  and local-address filtering.
- Code donor value:
  high for OSCQuery connection flow, service list UI, tree data grid, and
  message filtering.
- Product reference value:
  high for a more structured parameter browser than passive packet sniffers.
- What to inspect next:
  compare its OSCQuery model with prior OSCQuery library wave and with web
  panel approaches.
- Source evidence:
  `OscService.cs`, `OscHostService.cs`, `OscViewModel.cs`, and `OscView.axaml`.
- Reusable pattern extraction:
  OSCQuery-aware VRChat parameter browser and diagnostic surface.
- Reusable core:
  discover OSCQuery services, fetch host info and node tree, derive send/query
  endpoints, refresh services periodically, register diagnostic endpoints,
  filter incoming messages by local or connected endpoint, and render parameter
  paths/types/values/descriptions in a tree grid.
- Do not copy directly:
  incomplete search UI or submodule/dependency assumptions without cleanup.
- Caveats:
  no README in the inspected root snapshot; architecture must be inferred from
  source.

## `networkpenetrationtester/VRChat-OSC-WebPanel`

- Interesting idea:
  implement a TypeScript VRChat OSC interface/router that loads the current
  avatar JSON, builds input/output type maps, caches path-pattern listeners,
  routes messages to external apps, acknowledges sends by observing echoes, and
  exposes avatar parameters through a Svelte panel.
- Code donor value:
  high for router/listener cache, avatar structure loading, type maps, send
  acknowledgement, and frontend parameter panel shape.
- Product reference value:
  high for browser-based OSC parameter dashboards and external app routing.
- What to inspect next:
  decide whether acknowledgement-by-echo is robust enough for a reusable OSC
  tool or only suitable as a best-effort diagnostic.
- Source evidence:
  `src/backend/src/osc_interface.ts`, `osc_router.ts`,
  `message_listener.ts`, `modules.ts`, `src/frontend/src/routes/+page.svelte`,
  `avatar.remote.ts`, and `parameter.svelte`.
- Reusable pattern extraction:
  web parameter panel with avatar JSON type maps and OSC route forwarding.
- Reusable core:
  load last/current avatar structure from VRChat OSC files, build input/output
  maps, update avatar state on `/avatar/change`, cache pattern matchers and
  known address matches, forward matched messages to external app endpoints,
  send typed values to VRChat, and expose current avatar parameters through a
  live web UI.
- Do not copy directly:
  raw cookie/API handling, aggressive polling, or TODO-heavy write controls
  without hardening.
- Caveats:
  promising but still rough; frontend write controls look incomplete.

## `200Tigersbloxed/HRtoVRChat_OSC`

- Interesting idea:
  convert many heart-rate sources into VRChat avatar parameters, with a
  parameter normalization layer, service/device managers, SDK/plugin ingress,
  reflection and network SDK paths, an app bridge, heartbeat booleans, and
  avatar file awareness.
- Code donor value:
  high for sensor manager architecture, parameter mapping, plugin ingress,
  app bridge messages, and avatar/OSC file integration.
- Product reference value:
  very high for biometric avatar utilities and sensor-to-OSC bridge products.
- What to inspect next:
  extract a generic sensor bridge schema that is not heart-rate-specific:
  raw value, normalized value, source name, active/connected booleans, and
  heartbeat/status.
- Source evidence:
  `OSCManager.cs`, `ParamsManager.cs`, `Program.cs`, `HRManagers/*`,
  `SDKManager.cs`, `HRSDK.cs`, `AppBridge.cs`, `Messages.cs`, README, and SDK
  docs.
- Reusable pattern extraction:
  biometric sensor-to-avatar OSC bridge with SDK/plugin ingress and status
  parameters.
- Reusable core:
  separate sensor managers from OSC parameter writers, normalize values into
  integer/float/bool avatar parameters, reset parameters on shutdown, detect
  target app presence, watch `/avatar/change` and avatar JSON files, expose an
  SDK for reflected or networked device plugins, and stream app-bridge status
  messages for helper UIs.
- Do not copy directly:
  service-specific endpoints, old app naming, or broad plugin loading without
  a security boundary.
- Caveats:
  larger app with many integrations; best reuse is the bridge architecture and
  schema rather than the full codebase.

## Cross-Project Lessons

- VRChat OSC utilities become more reusable when they separate address helpers,
  parameter schemas, UI surfaces, and transport/listener loops.
- Passive OSC debuggers are useful for live values; OSCQuery-aware tools are
  better for parameter structure and discoverability.
- Sensor bridges should publish both raw/normalized values and explicit
  connected/active/heartbeat state.
- Browser panels are strong companion surfaces, but network exposure and
  message pacing need first-class warnings.
- Micro-utilities matter: a single awkward workflow, such as drone control or
  chatbox entry, can justify a focused reusable pattern.
