# VR Projects Wave 189: VRChat Chatbox Media/Status and Bounded Text Composition Microtools

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 189 studies small VRChat chatbox tools that turn media playback, status,
system telemetry, templates, and one-off messages into bounded OSC chatbox
output. The key reusable knowledge is composition, cadence, truncation, and
module boundaries.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `Voiasis/RustyChatBox` | Linux Rust/egui chatbox composer | Strong Linux/status module donor |
| `bddvlpr/vrc-osc-spotify` | Spotify OAuth and lyrics to chatbox | Strong playback/lyrics scheduler donor |
| `Massivendurchfall/vrchat-osc-spotify` | Polished Python Spotify status GUI | Strong bounded composition reference |
| `Jakhaxz/VRChatSpotifyControler` | Avatar OSC controlled desktop Spotify | Useful media control reference |
| `Null-K/VRChat-OSC-ChatBox` | Template/placeholder chatbox GUI | Strong template-variable donor |
| `WillW129/VRChat_OSC_Display_Mate` | Windows status aggregator | Useful status/keepalive reference |
| `nekochanfood/VRChat_OSC_Chatbox_for_GO` | Minimal Go chatbox CLI | Tiny sender baseline |

## `Voiasis/RustyChatBox`

- Interesting idea:
  a Linux-first chatbox toolkit with egui UI, persisted config, media controls,
  system stats, clipboard/live edit, dependency checks, and rosc OSC output.
- Code donor value:
  high for module config, playerctl/MPRIS handling, dependency-gated features,
  and system telemetry composition.
- Product reference value:
  high for non-Windows VRChat companions and chatbox dashboards.
- What to inspect next:
  UI/data separation, Unicode/emoji rendering, and how modules should be
  composed without coupling them tightly to the app shell.
- Source evidence:
  `src/main.rs`, `config.rs`, `osc.rs`, `modules/media.rs`,
  `modules/status.rs`, and `modules/component.rs`.
- Reusable pattern extraction:
  Linux chatbox composer with dependency-gated modules.
- Reusable core:
  load a persistent config, check optional dependencies, let modules format
  media/status/system strings, gate unavailable features visibly, and send
  composed text through `/chatbox/input`.
- Do not copy directly:
  Linux-only command assumptions, early proof-of-concept UI coupling, or
  emoji/string behavior without fresh validation.
- Caveats:
  strong architecture signal for Linux chatbox tools, but still early.

## `bddvlpr/vrc-osc-spotify`

- Interesting idea:
  connect Spotify OAuth playback state to VRChat chatbox and optionally
  schedule lyric lines against current playback progress.
- Code donor value:
  high for OAuth callback/token persistence, playback polling, avatar boolean
  state, and lyric timeout scheduling.
- Product reference value:
  high for music/status companions and stream-facing social VR tools.
- What to inspect next:
  rate limits, Musixmatch/internal API fragility, secret management, and user
  controls for lyric verbosity.
- Source evidence:
  `src/index.ts`, `src/app/index.ts`, `config.ts`, `cache.ts`, and `mxm.ts`.
- Reusable pattern extraction:
  Spotify/playback-to-chatbox bridge with OAuth token persistence and lyric
  scheduling.
- Reusable core:
  run a local OAuth callback, persist access/refresh tokens, refresh before
  expiry, poll playback state, send now-playing text, clear old lyric timers,
  and schedule lyric lines relative to playback progress.
- Do not copy directly:
  internal Musixmatch assumptions, captcha-sensitive flows, or secrets/config
  defaults without stronger UX.
- Caveats:
  donor-worthy pipeline, but external service fragility is the main risk.

## `Massivendurchfall/vrchat-osc-spotify`

- Interesting idea:
  polished Python GUI that turns Spotify playback into compact chatbox status
  with templates, progress bars, quiet mode, AFK tags, anti-spam, and keepalive.
- Code donor value:
  high for bounded message composition, PKCE auth, progress bar formats,
  anti-spam checks, and send-if-changed behavior.
- Product reference value:
  high for user-facing chatbox utilities that need to feel configurable rather
  than hacky.
- What to inspect next:
  Windows-specific idle/process helpers, privacy messaging, and optional
  anti-AFK behavior boundaries.
- Source evidence:
  `main.py` and `build.py`.
- Reusable pattern extraction:
  bounded media-status composer with template, progress, anti-spam, and
  keepalive policy.
- Reusable core:
  authenticate through Spotify PKCE, format playback fields through templates,
  clamp chatbox text to the VRChat limit, send only when changed or after a
  keepalive interval, and expose user settings for progress bars and tags.
- Do not copy directly:
  anti-AFK behavior, Windows-only helpers, or credentials handling without
  clear consent and storage rules.
- Caveats:
  excellent product reference; ethically sensitive automation features should
  stay out of generic reusable patterns.

## `Jakhaxz/VRChatSpotifyControler`

- Interesting idea:
  avatar OSC parameters drive desktop Spotify controls such as play/pause,
  next/previous, volume, and now-playing chatbox output.
- Code donor value:
  medium for mapping avatar expression-menu parameters to desktop media
  session and volume actions.
- Product reference value:
  medium for avatar-menu-controlled desktop companions.
- What to inspect next:
  parameter naming conventions, command debounce, and safer media-session
  abstraction.
- Source evidence:
  `main.py`.
- Reusable pattern extraction:
  avatar-menu media control bridge.
- Reusable core:
  listen for avatar OSC parameter changes, map booleans/floats to media
  commands, invoke local desktop media controls, and periodically publish
  now-playing text to chatbox.
- Do not copy directly:
  hardcoded avatar parameters, Windows-only media key/volume dependencies, or
  command injection without debounce.
- Caveats:
  useful command-surface idea, but not a general media framework.

## `Null-K/VRChat-OSC-ChatBox`

- Interesting idea:
  a template/placeholder GUI for VRChat chatbox with categorized variables,
  preview, timer sending, and a small extension hook for extra placeholders.
- Code donor value:
  high for placeholder catalog, template expansion, preview UX, and generic
  system-info source modules.
- Product reference value:
  high for small configurable chatbox surfaces.
- What to inspect next:
  placeholder safety, cross-platform metric availability, and length-aware
  preview warnings.
- Source evidence:
  `vrc_osc_chatbox/main.py`, `ui/app.py`, `config.py`,
  `variables/catalog.py`, `variables/registry.py`, `variables/template.py`,
  `osc/__init__.py`, and `system_info.py`.
- Reusable pattern extraction:
  template-variable chatbox composer with live preview.
- Reusable core:
  keep placeholders in categories, expand `{key}` tokens through a registry,
  preview the resulting message, warn or truncate at the chatbox limit, and
  send manually or on a timer.
- Do not copy directly:
  platform-specific shell/system probes, simple truncation as the only length
  policy, or UI strings without localization planning.
- Caveats:
  strong generic composition donor for future chatbox utilities.

## `WillW129/VRChat_OSC_Display_Mate`

- Interesting idea:
  aggregate active window title, system stats, now-playing information, idle
  time, and Pulsoid heart rate into a compact VRChat chatbox status loop.
- Code donor value:
  medium for change-detection plus keepalive send gating and modular status
  sources.
- Product reference value:
  medium for "what am I doing now" social status panels.
- What to inspect next:
  privacy filters for window titles, heavier browser/Selenium heart-rate
  scraping, and module failure isolation.
- Source evidence:
  `main.py`, `modules/vrc_osc.py`, `formatter.py`, `now_playing.py`,
  `system_stats.py`, and `get_heartrate_pulsoid_URL.py`.
- Reusable pattern extraction:
  status aggregator with change and keepalive send gating.
- Reusable core:
  poll several local status sources, format a short multi-line message, send
  only when content changes or a keepalive interval expires, and keep OSC output
  behind one module.
- Do not copy directly:
  Selenium-based scraping as a default path, unfiltered active-window exposure,
  or Windows-only assumptions as cross-platform behavior.
- Caveats:
  useful microtool reference with privacy-sensitive defaults.

## `nekochanfood/VRChat_OSC_Chatbox_for_GO`

- Interesting idea:
  a minimal Go CLI that sends a text string to VRChat chatbox once or
  continuously.
- Code donor value:
  low-to-medium as the smallest useful sender baseline.
- Product reference value:
  medium for scripts, automations, and debugging.
- What to inspect next:
  packaging as a safe CLI, UTF-8/length behavior, and optional typing/sound
  flags.
- Source evidence:
  `main.go`.
- Reusable pattern extraction:
  tiny chatbox sender baseline.
- Reusable core:
  accept message, host, port, and continuous-mode flags, build an OSC
  `/chatbox/input` message, and send it through a tiny CLI.
- Do not copy directly:
  no length checks, no typing indicator, no rate limits, and minimal error UX.
- Caveats:
  intentionally small; best as a test helper, not a full app.

## Cross-Project Lessons

- Chatbox utilities need a source-module -> formatter -> limiter -> send
  cadence boundary.
- Bounded composition matters because VRChat chatbox is short; good tools make
  truncation, progress bars, and optional fields explicit.
- Media/status tools should not leak private window titles, secrets, or idle
  state without visible user control.
- Linux, Windows, browser, and tiny CLI implementations each reveal different
  portability constraints.
- Avatar OSC parameters can be both output status and input controls.

## Reuse Recommendations

1. Use `RustyChatBox` for Linux module/dependency-aware chatbox composition.
2. Use `vrc-osc-spotify` and `vrchat-osc-spotify` for OAuth/playback polling,
   lyric timing, bounded formatting, anti-spam, and keepalive.
3. Use `VRChat-OSC-ChatBox` as the strongest generic placeholder/template
   donor.
4. Use `VRChat_OSC_Display_Mate` for change/keepalive gating and
   multi-source status composition.
5. Keep `VRChat_OSC_Chatbox_for_GO` as the tiny sender baseline for tests and
   scripts.

## Follow-Up Gaps

- Define a reusable chatbox composition contract with privacy flags.
- Compare message-length strategies: truncate, elide fields, rotate pages, or
  send timed fragments.
- Compare Spotify/media integrations against generic MPRIS/GSMTC providers.
- Decide which chatbox sender baseline belongs in future `VR-apps-lab`
  prototype utilities.
