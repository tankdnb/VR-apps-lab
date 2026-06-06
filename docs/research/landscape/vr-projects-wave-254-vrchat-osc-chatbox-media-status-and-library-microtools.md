# VR Projects Wave 254: VRChat OSC Chatbox Media Status And Library Microtools

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies newly discovered VRChat OSC chatbox/media/status variants
that were not already in the registry. Most are micro-utilities rather than
large products, but they add useful lessons around cadence, templates,
platform-specific media state, OSC libraries, and chatbox privacy.

## Why It Matters For `VR-apps-lab`

The repository already has strong VRChat OSC and chatbox coverage. This wave
does not reopen that whole family; it fills residual gaps and extracts
implementation details from small variants that show different tradeoffs.

## Project Notes

### `lillithrosepup/Lilypad`

- Interesting idea:
  a Kotlin Multiplatform/Compose OSC chatbox client runs on Android hardware,
  supports modules, OSCQuery, game log parsing, OAuth, Spotify/LastFM, lyrics,
  avatar presets, banners, messages, and clocks.
- Code donor value:
  `core/modules` separates required core modules from normal modules.
  `Music.kt` handles Spotify OAuth through a lock-based local HTTP callback,
  refreshes tokens, polls now-playing state, and builds chatbox lines with
  timestamps and synced lyrics. `OSCSender.kt` resolves OSC address/port from
  OSCQuery when available and sends messages through a custom serializer.
- Product reference value:
  strong donor for modular chatbox architecture and Android/standalone
  companion framing.
- What to inspect next:
  inspect configuration persistence, module lifecycle, and game-storage log
  parsing in a dedicated VRChat companion-app deepening pass.
- Reusable pattern:
  module registry -> per-module config -> chatbox line builder -> OSCQuery
  address discovery -> OSC sender.
- Caveats:
  credential handling, Android portability, and lyrics/API terms need careful
  boundaries before reuse.

### `ohkaelynn/iron-heart-chatbox`

- Interesting idea:
  a tiny tray script reads heart-rate text output from Iron-Heart and sends
  contextual BPM messages to the VRChat chatbox.
- Code donor value:
  `iron-heart-chat.py` reads `config.json`, checks whether `iron-heart.exe` is
  running with `psutil`, reads a BPM text file, maintains recent BPM history,
  computes trend symbols and threshold messages, sends `/chatbox/input`, keeps
  the chatbox alive on a refresh interval, and exposes pause/exit through
  `pystray`.
- Product reference value:
  good micro-reference for file-based biometric bridge plus tray control.
- What to inspect next:
  compare against existing biometric/heart-rate bridges and add privacy notes
  around public chatbox status.
- Reusable pattern:
  text-file sensor output -> trend/status formatter -> cadence gate -> OSC
  chatbox sender -> tray pause.
- Caveats:
  hardcoded process name, file polling, public biometric output, and no
  consent/display policy.

### `MeltyMooncakes/VRChat-OSC-Script`

- Interesting idea:
  a Node/TypeScript chatbox script combines YAML line templates, MPRIS/Windows
  media data, incoming OSC property cache, and a plugin loader.
- Code donor value:
  `src/index.ts` parses `configs/config.yaml`, creates OSC client/server
  sockets, formats configured lines every 100 ms, rate-limits actual sends by
  `sendInterval`, and stores incoming OSC properties. `plugins.ts` loads
  plugins from a `plugins` directory and lets them format messages.
  `music.ts` supports Linux MPRIS through DBus and Windows media through a
  dynamic module.
- Product reference value:
  useful donor for a small extensible chatbox composer.
- What to inspect next:
  fix or document plugin loading behavior and compare plugin API safety with
  VRCOSC module packs.
- Reusable pattern:
  YAML lines -> formatter/plugin chain -> OSC send cadence -> incoming
  property cache.
- Caveats:
  plugin import trust, partial Windows media support, and possible plugin-loop
  bug in `loadAllPlugins`.

### `o0F-0oF/VRChat-Spotify-Chatbox`

- Interesting idea:
  a minimal Python Spotify window-title scraper sends the current Spotify
  title to the VRChat chatbox.
- Code donor value:
  `vsc.py` finds `Spotify.exe`, enumerates visible window handles, reads the
  active Spotify window title, clears the chatbox when idle, and sends updates
  every two seconds.
- Product reference value:
  useful as a "do the smallest thing" reference and caveat case.
- What to inspect next:
  compare window-title scraping against Spotify API and Windows media session
  APIs.
- Reusable pattern:
  desktop process/window title -> dedupe -> OSC chatbox sender.
- Caveats:
  Windows-only, brittle process/window title parsing, no reconnection when the
  initial handle disappears, and no template/privacy controls.

### `o0F-0oF/VRChat-Spotify-Chatbox-CS`

- Interesting idea:
  a C# variant repeats the Spotify window-title chatbox pattern with SharpOSC.
- Code donor value:
  `Program.cs` polls `Process.GetProcessesByName("Spotify")`, reads
  `MainWindowTitle`, and sends a hardcoded "Currently Playing" chatbox string
  through `SharpOSC.UDPSender`.
- Product reference value:
  useful comparison node against the Python variant.
- What to inspect next:
  treat mainly as a minimal C# OSC sender example, not a full product donor.
- Reusable pattern:
  process title poll -> fixed chatbox format -> UDP OSC send.
- Caveats:
  sends to port 8000 rather than the usual VRChat input port, no config, and no
  error handling.

### `Mezque/VRC-SpotifyOSC-Py`

- Interesting idea:
  a Spotipy-based script sends currently playing song, artist, progress,
  duration, and volume to the VRChat chatbox.
- Code donor value:
  `src/Spotify.py` uses Spotify OAuth scopes for now-playing/playback state,
  formats volume icons and progress strings, creates a `Settings/settings.ini`
  preference for keep-sending behavior, and schedules repeated sends with
  timers/threads.
- Product reference value:
  useful comparison against title-scraping variants because it uses the official
  Spotify API.
- What to inspect next:
  replace inline client-id/client-secret guidance with safer config loading and
  revisit timer recursion.
- Reusable pattern:
  media API auth -> now-playing state -> preference-controlled cadence -> OSC
  chatbox output.
- Caveats:
  credential setup burden, timer recursion, and public music/volume disclosure.

### `Mezque/VRC-ClockOSC-Py`

- Interesting idea:
  a single-purpose clock sender updates the VRChat chatbox with local time.
- Code donor value:
  `src/clockOSC.py` formats local time with `time.strftime`, sends
  `/chatbox/input`, sleeps, and recursively calls itself.
- Product reference value:
  useful micro-utility baseline for cadence and bounded value.
- What to inspect next:
  replace recursion with a normal loop and add send-rate/privacy guidance.
- Reusable pattern:
  local status string -> fixed cadence -> chatbox sender.
- Caveats:
  recursion loop, no config file, and chatbox spam risk.

### `eepyfemboi/ezmusic-desktop-client`

- Interesting idea:
  a desktop client combines ezmusic web playback, local cookies, Discord Rich
  Presence, system stats, and VRChat chatbox output.
- Code donor value:
  `client.py` uses `pywebview`, stores an access token cookie, queries remote
  metadata, formats CPU/GPU/RAM/network frames, connects Discord RPC, and
  drives chatbox output through `python-osc`.
- Product reference value:
  useful cautionary reference for "media client plus status broadcaster" scope
  creep.
- What to inspect next:
  separate media playback, credentials, Discord RPC, stats, and chatbox output
  into explicit modules before reuse.
- Reusable pattern:
  local webview media client -> metadata/cache -> status frames -> Discord and
  OSC outputs.
- Caveats:
  auto-installs missing Python packages at import time, stores cookies locally,
  remote service dependency, and broad personal-status output.

### `ActuallyAbby/VRC-JavaOSC`

- Interesting idea:
  a Java library wraps VRChat OSC send/receive ports, avatar parameter paths,
  listeners, and optional parameter caching.
- Code donor value:
  `VRCOsc.java` provides a builder with default VRChat ports, creates
  `OSCPortIn` and `OSCPortOut`, registers listeners using pattern selectors
  for `/avatar/parameters/*`, emits typed parameter change events, supports
  listener unregister, sends parameter values, and can cache last-known values.
- Product reference value:
  good donor for a language-specific OSC wrapper shape.
- What to inspect next:
  compare with .NET/Rust/Python OSC wrappers and OSCQuery-aware libraries.
- Reusable pattern:
  typed avatar parameter object -> listener registry -> send/cache API.
- Caveats:
  parameter regex is narrow, chatbox is not the focus, and library maturity is
  modest.

### `Disconnect3301/DisconnectOSC`

- Interesting idea:
  a C# console tool toggles small VRChat OSC functions such as recording timer,
  typing indicator, nameplate hiding, booping, and player logging.
- Code donor value:
  `DisconnectOSC.cs` creates a command loop, toggles feature flags, sends
  startup/status messages through `BuildSoft.VRChat.Osc`, and coordinates
  mutually exclusive modes. `Functions/Recording.cs` runs a background thread
  that sends an elapsed recording timer with a blinking symbol.
- Product reference value:
  useful example of operator microcommands and chatbox function toggles.
- What to inspect next:
  separate playful/social functions from legitimate utility features and remove
  tracked build artifacts if studying deeper.
- Reusable pattern:
  console command surface -> feature flags -> per-feature background loops ->
  OSC output.
- Caveats:
  includes build outputs and `.vs` state in the repo, playful/spammy features,
  and minimal safety gates.

## Reusable Pattern Extraction

- Pattern candidate:
  bounded chatbox/status composer with cadence, source, and privacy boundaries.
- Problem solved:
  many tiny tools send status into VRChat chatbox, but they need a common shape
  to avoid spam, credential leaks, and unstable source adapters.
- Reusable core:
  data source, formatter/template, cadence/dedupe, send target, optional
  OSCQuery, local control surface, privacy flags, and failure state.
- Source evidence:
  `Lilypad`, `iron-heart-chatbox`, `VRChat-OSC-Script`,
  `VRChat-Spotify-Chatbox`, `VRChat-Spotify-Chatbox-CS`,
  `VRC-SpotifyOSC-Py`, `VRC-ClockOSC-Py`, `ezmusic-desktop-client`,
  `VRC-JavaOSC`, and `DisconnectOSC`.
- Abstraction boundary:
  keep source adapters separate from chatbox formatting and OSC transport.
- What not to copy:
  auto-install-on-import, public biometric output without consent, recursive
  send loops, broad cookies/tokens, or untrusted plugin loading.
- Method catalog action:
  add a method that consolidates residual chatbox/status composer variants.

## Family Placement

This wave extends the VRChat chatbox/status/media and OSC library families.
It is a gap-fill wave; earlier waves remain the main references for stronger
chatbox and OSC companion frameworks.

## Follow-Up Gaps

- Build a small matrix of source type versus privacy risk: media title,
  biometric, system stats, time, avatar parameter, plugin output.
- Extract a safe cadence and dedupe checklist for `/chatbox/input`.
- Decide which chatbox microtools are useful as donor code and which are only
  product references or anti-patterns.
