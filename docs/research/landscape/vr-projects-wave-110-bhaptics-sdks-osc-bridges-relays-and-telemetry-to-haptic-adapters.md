# VR Projects Wave 110: bHaptics SDKs, OSC Bridges, Relays, and Telemetry-to-Haptic Adapters

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `bHaptics SDKs`, `OSC bridges`, `relay wrappers`, and
  `telemetry-to-haptic adapters`.

## Why this wave exists

Not every VR utility has to be visual. Haptics are a reusable output channel
for game events, avatar parameters, accessibility cues, telemetry, rhythm,
warnings, and social signals. bHaptics is useful here because the ecosystem
includes official SDK surfaces and community bridge tools that translate OSC,
logs, and WebSocket commands into wearable feedback.

This wave studies haptics as an integration family rather than as a device
shopping list.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by bHaptics SDK, OSC, relay, and command bridge families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `bhaptics/haptic-library` | Native C++ library exposing Player connection, feedback registration, submit variants, and device status APIs |
| `bhaptics/tact-js` | Browser/TypeScript SDK facade for event, dot, path, glove, device, mapping, and playing-state calls |
| `bhaptics/tact-python` | Thin Python API reference and command example for async haptics control |
| `HerpDerpinstine/bHapticsOSC` | VRChat OSC-to-bHaptics bridge with config reload, reflection-bound OSC handlers, and per-device motor buffers |
| `Dteyn/bHapticsRelay` | Generic WPF relay that turns log lines or WebSocket commands into SDK2 haptic playback calls |

## Deep-pass notes by project

## `bhaptics/haptic-library`

- GitHub:
  [bhaptics/haptic-library](https://github.com/bhaptics/haptic-library)
- What it is:
  a C++11 bHaptics library that talks to bHaptics Player and exposes a native
  API for registering, playing, stopping, querying, and submitting feedback.
- Interesting idea:
  haptics integration should expose both high-level event playback and
  low-level dot/path submission so tools can choose between authored patterns
  and generated tactile output.
- Code-level notes:
  `include/shared/HapticLibrary.h`
  exports C ABI functions such as `Initialise`, `Destroy`,
  `RegisterFeedback`, `RegisterFeedbackFromTactFile`,
  `LoadAndRegisterFeedback`, `SubmitRegistered`,
  `SubmitRegisteredWithOption`, `SubmitByteArray`, `SubmitPathArray`,
  `Submit`, `SubmitDot`, `SubmitPath`, `IsFeedbackRegistered`, `IsPlaying`,
  `TurnOff`, feedback enable/disable/toggle calls, device-playing checks, and
  position response queries.
  `src/hapticsManager.cpp`
  owns the WebSocket client to bHaptics Player, reconnect behavior, registered
  feedback resend, JSON request creation, `.tact` loading, dot/path
  conversion, and turn-off/status calls.
- Code donor value:
  high for native SDK facade shape and Player WebSocket command organization.
- Product reference value:
  high for defining the minimum command surface a reusable haptics bridge
  should provide.
- Caveats:
  it depends on bHaptics Player and vendor runtime behavior; `VR-apps-lab`
  should reuse the facade pattern, not the dependency as a foundation.
- What to inspect next:
  compare SDK1 and SDK2 wrappers when designing haptics bridge abstractions.

## `bhaptics/tact-js`

- GitHub:
  [bhaptics/tact-js](https://github.com/bhaptics/tact-js)
- What it is:
  a TypeScript/ESM SDK for controlling bHaptics devices from JavaScript.
- Interesting idea:
  haptics control can be exposed to browser-native panels and web dashboards,
  not only desktop apps or game plugins.
- Code-level notes:
  `sdk/src/index.ts`
  wraps the web/wasm bridge and exposes `Tact.init`, `ping`, `pingAll`,
  `motorTest`, `play`, `playLoop`, `playGlove`, `playDot`, `playPath`,
  `pause`, `resume`, `stop`, `stopAll`, `getConnectedDevices`,
  `getHapticMappings`, `getEvent`, `isDeviceConnected`, `isConnected`,
  `isPlaying`, and `isPlayingByEventKey`.
  The API uses typed position values and arrays for dot/path calls, which
  makes it a concise reference for browser haptics panels.
- Code donor value:
  medium-high for web API shape and typed command facade.
- Product reference value:
  high for browser-based utility surfaces that include tactile output.
- Caveats:
  much of the runtime behavior lives in the wasm/player bridge, so the repo is
  most useful as API-surface reference.
- What to inspect next:
  combine with browser OSC dashboards if a future tool needs browser controls
  plus tactile feedback.

## `bhaptics/tact-python`

- GitHub:
  [bhaptics/tact-python](https://github.com/bhaptics/tact-python)
- What it is:
  a Python SDK reference for controlling bHaptics devices through bHaptics
  Player.
- Interesting idea:
  Python scripting can be a lightweight automation layer for haptic events,
  motor tests, device status, and tooling experiments.
- Code-level notes:
  `python_test.py`
  demonstrates async registry/init, event playback, stop by request or event,
  dot sweeps, path points, glove patterns, ping and ping-all, device VSM,
  position swap, device-info JSON, mapping queries, connected status, Player
  installed/running checks, and Player launch.
- Code donor value:
  medium because the repo is mostly a command reference rather than a full
  architecture donor.
- Product reference value:
  medium-high for quick haptics scripts and automation prototypes.
- Caveats:
  thin implementation surface; treat it as API exploration rather than a deep
  product model.
- What to inspect next:
  compare with simulation telemetry or accessibility scripts that could emit
  haptic cues.

## `HerpDerpinstine/bHapticsOSC`

- GitHub:
  [HerpDerpinstine/bHapticsOSC](https://github.com/HerpDerpinstine/bHapticsOSC)
- What it is:
  a discontinued/as-is VRChat OSC bridge for bHaptics Player.
- Interesting idea:
  avatar OSC parameters can drive wearable motor buffers when the bridge owns
  device config, avatar reset behavior, and safe gating around avatar state.
- Code-level notes:
  `bHapticsOSC/Program.cs`
  loads connection, device, and VRChat configs, watches config files for
  reloads, connects bHaptics and OSC managers, attaches OSC handlers by
  reflection, and starts VRChat support.
  `OscLib/OscManager.cs`
  defines connection config, receiver/sender packet queue, reflection-based
  `IOscAddress` binding, and parameter validation before method invocation.
  `bHapticsOSC/VRChatSupport.cs`
  creates per-device schemes for head, vest, arms, hands, and feet, attaches
  OSC paths under `/avatar/parameters/bHapticsOSC_*`, handles bool/int
  intensity values, avatar change, AFK/in-station/seated states, and submits
  per-motor buffers on a timed loop. It also resets devices on avatar change
  and can remove generated avatar OSC config files.
- Code donor value:
  high for OSC address binding, config hot reload, and per-device motor-buffer
  routing.
- Product reference value:
  high for avatar-driven haptics as a social VR utility.
- Caveats:
  discontinued, VRChat-specific, config-heavy, and GPL; reuse should be
  conceptual unless licensing and maintenance fit.
- What to inspect next:
  compare with OSC routers and haptics relay tools so avatar parameters do not
  monopolize local OSC routing.

## `Dteyn/bHapticsRelay`

- GitHub:
  [Dteyn/bHapticsRelay](https://github.com/Dteyn/bHapticsRelay)
- What it is:
  a WPF relay for modders that turns log lines or WebSocket commands into
  bHaptics SDK2 playback calls.
- Interesting idea:
  generic haptics integration can work without game SDK hooks by tailing logs
  or exposing a local WebSocket command surface.
- Code-level notes:
  `BhapticsSDK2Wrapper.cs`
  documents SDK2 P/Invoke-style calls for registry/init, WebSocket connection,
  reinit, play variants, pause/resume/stop/isPlaying, dot/waveform/path
  playback, device connectivity, ping, swap, VSM, device info, Player status,
  and mappings.
  `MainWindow.xaml.cs`
  validates config, checks or launches Player, initializes cloud mappings with
  offline fallback JSON, monitors Player connection, tails log files with
  `FileSystemWatcher` plus polling, hosts a Fleck WebSocket server, parses
  `[bHaptics]` CSV commands, sends SDK calls, and replies with request status.
- Code donor value:
  very high for generic event-to-haptics relay architecture.
- Product reference value:
  high for making haptics usable by games or tools that only expose logs or
  local network messages.
- Caveats:
  WIP and Windows/WPF-specific; command parsing and fallback mapping should be
  hardened before reuse.
- What to inspect next:
  compare with racing telemetry, sim telemetry, and accessibility alert tools
  that need event-to-output adapters.

## Main takeaways from Wave 110

- Haptics utilities split into SDK facades, browser/Python command layers,
  avatar OSC bridges, and generic log/WebSocket relays.
- The strongest bridge tools expose event playback and generated dot/path
  output together.
- Avatar OSC haptics need route safety, avatar-change reset, and device gating.
- Generic relays are valuable because many apps can emit logs or WebSocket
  messages even when they cannot integrate a vendor SDK directly.

## Reusable methods clarified by this wave

- `Haptic player SDK facade with event, dot, path, status, and device-management calls`
- `Avatar OSC-to-haptics bridge with per-motor buffers and avatar-change reset`
- `Generic haptics relay from log lines or WebSocket commands`

## Recommended next moves after this wave

1. Keep bHapticsRelay visible as the strongest generic haptic relay reference.
2. Keep bHapticsOSC visible as the strongest avatar OSC-to-haptics bridge
   reference, with maintenance and licensing caveats.
3. Keep tact-js visible when future browser-based operator panels need tactile
   output.
4. Compare haptics bridges with OSC routers, telemetry adapters, and
   accessibility alert patterns.
