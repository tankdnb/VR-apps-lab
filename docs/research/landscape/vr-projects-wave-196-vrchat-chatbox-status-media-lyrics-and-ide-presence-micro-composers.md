# VR Projects Wave 196: VRChat Chatbox Status, Media, Lyrics, and IDE Presence Micro-Composers

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 196 studies VRChat OSC chatbox sidecars that compose short messages from
external activity: coding status, media playback, lyrics, system status, MOTD
plugins, speech recognition, and translation. The reusable value is provider
boundaries, template/cropping policy, send cadence, privacy controls, and
clear/typing behavior.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `Null-K/VRChatStatusTask` | IDE presence to chatbox | Strong IDE/status donor |
| `bunboop/vrc-osc-mpris` | Linux MPRIS media status sender | Compact baseline |
| `Auzlex/vrchat-osc-windows-media` | Windows media session sender | Windows media reference |
| `lexiuwu71/sillyosc` | Multi-source status and Discord RPC composer | Product/UX reference |
| `lexiuwu71/mpd-vrchat-osc` | MPD now-playing sender | Tiny baseline |
| `AtomikkuLabs/VRC-Lyrics` | Playback and lyrics provider pipeline | Strong lyrics/provider donor |
| `kotleni/vrchat-osc-motd` | Plugin fan-in chatbox composer | Strong plugin-method donor |
| `KannaCS/VRCTalk` | Tauri STT/translation chatbox sidecar | Voice/translation overlap donor |

## `Null-K/VRChatStatusTask`

- Interesting idea:
  an IntelliJ project service turns IDE context into a VRChat chatbox status
  message with placeholders for project, file, errors, warnings, uptime, line
  text, and line number.
- Code donor value:
  high for scheduled IDE-state sampling, template placeholders, cropping, and
  service lifecycle cleanup.
- Product reference value:
  high for developer presence utilities.
- What to inspect next:
  privacy defaults, per-project opt-in, ignore patterns, and whether line/file
  fields should be disabled by default.
- Source evidence:
  `VRChatStatusService.java`, `VRChatStatusSettings.java`, and
  `VRChatStatusConfigurable.java`.
- Reusable pattern extraction:
  provider-backed chatbox status composer with template and cropping policy.
- Reusable core:
  collect source fields from a provider, render through a user template, crop
  risky or long fields, send at a bounded cadence, and clear or stop the
  scheduled sender when disabled.
- Do not copy directly:
  raw editor line/file exposure, project names, or error counts without a
  privacy checklist.
- Caveats:
  developer-presence tools are useful but can leak sensitive work context.

## `bunboop/vrc-osc-mpris`

- Interesting idea:
  a compact Rust program reads Linux MPRIS playback metadata and sends
  now-playing status to VRChat chatbox.
- Code donor value:
  medium for MPRIS player lookup, TOML config, small-bubble formatting, and
  minimal sender shape.
- Product reference value:
  medium for Linux media-status coverage.
- What to inspect next:
  sleep behavior when no player is found, reconnect policy, error recovery,
  and anti-spam.
- Source evidence:
  `src/main.rs` and `config.toml`.
- Reusable pattern extraction:
  media-session provider to bounded chatbox message.
- Reusable core:
  find an active or configured media player, normalize artist/title/status and
  progress, render optional compact text, and send to `/chatbox/input`.
- Do not copy directly:
  busy-loop no-player behavior or panic-style error handling.
- Caveats:
  very useful as a baseline, but needs production hardening.

## `Auzlex/vrchat-osc-windows-media`

- Interesting idea:
  a Python script reads Windows global media sessions and sends changed
  now-playing messages to VRChat chatbox.
- Code donor value:
  medium for Windows Media Controls integration and duplicate-send gating.
- Product reference value:
  medium for a Windows-native media micro-tool.
- What to inspect next:
  session selection, paused/no-media behavior, config UI, and packaging
  hygiene.
- Source evidence:
  `osc_windows_media.py`.
- Reusable pattern extraction:
  Windows media session to chatbox bridge with change detection.
- Reusable core:
  poll the active media session, filter media type, format artist/title, keep a
  last-sent value, and avoid repeated chatbox sends.
- Do not copy directly:
  bundled release artifacts, global mutable state, or fixed message policy.
- Caveats:
  Windows-only and intentionally small.

## `lexiuwu71/sillyosc`

- Interesting idea:
  a WPF app combines time, media status, system stats, VRChat chatbox output,
  and Discord Rich Presence in one status companion.
- Code donor value:
  medium for multi-source status composition and simple config persistence.
- Product reference value:
  high for a user-facing "status hub" utility.
- What to inspect next:
  source-module abstraction, privacy controls, process-title scraping, and
  separate chatbox versus Discord output policies.
- Source evidence:
  `sillyosc/MainWindow.xaml.cs`.
- Reusable pattern extraction:
  multi-output status composer.
- Reusable core:
  keep a simple settings file, select source modules, render media/time/system
  fields, scroll long media titles, and update chatbox/RPC on different
  cadences.
- Do not copy directly:
  legacy config format, process-title scraping, or chatbox and Discord output
  coupling.
- Caveats:
  useful product framing, weaker internal modularity.

## `lexiuwu71/mpd-vrchat-osc`

- Interesting idea:
  a very small Python MPD sender displays playing/paused state, artist/title,
  time, and remaining duration in VRChat chatbox.
- Code donor value:
  low-to-medium as a readable baseline.
- Product reference value:
  medium for minimal MPD integration.
- What to inspect next:
  config loading, connection recovery, and MPD event subscription instead of
  polling.
- Source evidence:
  `main.py`.
- Reusable pattern extraction:
  tiny status sender for one provider.
- Reusable core:
  poll provider state, format a compact status line, and send at a fixed
  interval.
- Do not copy directly:
  minimal error handling as production behavior.
- Caveats:
  valuable because it shows the smallest viable shape.

## `AtomikkuLabs/VRC-Lyrics`

- Interesting idea:
  a Flet desktop app separates playback providers, lyrics providers, worker
  updates, and OSC managers for chatbox or parameter output.
- Code donor value:
  high for provider boundaries, queued update events, lyrics timing, and
  chatbox/parameter output abstraction.
- Product reference value:
  high for a polished music/lyrics companion.
- What to inspect next:
  lyrics-provider rate limits, Spotify credential handling, cache policy, and
  message-length behavior.
- Source evidence:
  `app.py`, `core/service_manager.py`, `core/osc_manager.py`,
  `core/lrc_worker.py`, `playback/*`, and `lyrics/*`.
- Reusable pattern extraction:
  playback/lyrics provider pipeline into OSC output managers.
- Reusable core:
  isolate playback source, lyrics source, worker queue, message formatter, and
  OSC destination so chatbox and avatar parameters can share state without
  sharing transport details.
- Do not copy directly:
  cloud credentials, cookies, provider-specific API assumptions, or lyric text
  timing without user controls.
- Caveats:
  one of the strongest method donors in this wave.

## `kotleni/vrchat-osc-motd`

- Interesting idea:
  a TypeScript app dynamically loads plugins that each produce chatbox text,
  then joins non-empty plugin outputs into one bounded MOTD/status message.
- Code donor value:
  high for plugin lifecycle, output fan-in, and status module boundaries.
- Product reference value:
  high for extensible chatbox utilities.
- What to inspect next:
  plugin sandboxing, config schema, message-length policy, and per-plugin
  enable/cadence settings.
- Source evidence:
  `src/main.ts`, `src/pluginsloader.ts`, `src/pluginbase.ts`,
  `src/VrcOscClient.ts`, and `plugins/*`.
- Reusable pattern extraction:
  plugin fan-in chatbox composer.
- Reusable core:
  define plugin lifecycle hooks, load modules from a plugin folder, collect
  each plugin's optional output, trim empty values, join into one message, and
  send through one OSC client.
- Do not copy directly:
  unsandboxed dynamic imports, fixed ports, or missing per-plugin safeguards.
- Caveats:
  strong architecture seed, but needs trust and length controls.

## `KannaCS/VRCTalk`

- Interesting idea:
  a Tauri app combines Web Speech or Whisper recognition, translation
  providers, VRChat mute awareness, typing indicators, and chatbox output.
- Code donor value:
  high for provider switching, recognition lifecycle, mute listener, typing
  state, and Tauri Rust OSC commands.
- Product reference value:
  high for speech accessibility and multilingual chatbox utilities.
- What to inspect next:
  privacy policy, offline versus cloud recognition, translation retries,
  transcript history, and microphone permission UX.
- Source evidence:
  `src/components/VRCTalk.tsx`, `src/recognizers/WebSpeech.ts`,
  `src/recognizers/Whisper.ts`, and `src-tauri/src/lib.rs`.
- Reusable pattern extraction:
  recognizer/translator provider chain to chatbox output.
- Reusable core:
  keep recognizers behind a common interface, queue final transcripts, apply
  translation with retry/validation, emit typing status while speech is being
  detected, and stop recognition when VRChat mute state requires it.
- Do not copy directly:
  cloud speech or translation calls without explicit privacy controls.
- Caveats:
  overlaps voice/STT research, but the provider-boundary lesson matters here.

## Cross-Project Lessons

- Chatbox utility quality is mostly about source boundaries, cadence, privacy,
  and text length, not just OSC sending.
- Provider modules should be isolated from formatting and OSC transport.
- File names, editor lines, active windows, media titles, lyrics, and speech
  transcripts are all privacy-sensitive by default.
- Change detection and clear-on-stop behavior prevent spam and stale status.
- Plugin fan-in is powerful, but needs trust boundaries and per-module policy.

## Reuse Recommendations

1. Use `VRC-Lyrics` as the strongest provider-pipeline donor.
2. Use `vrchat-osc-motd` for plugin fan-in status composition.
3. Use `VRChatStatusTask` for IDE/status scheduling and cropping lessons.
4. Use `VRCTalk` for recognizer/translation lifecycle and typing-state design.
5. Use the MPRIS/MPD/Windows media projects as minimal provider baselines.

## Follow-Up Gaps

- Build a chatbox status privacy matrix across source fields and default
  visibility.
- Extract a reusable chatbox composer interface: provider, formatter, limiter,
  change detector, transport, and clear policy.
- Compare message-length strategies: crop, rotate, paginate, omit, and
  summarize.
- Decide how plugin trust should work for local-only chatbox extension hosts.
