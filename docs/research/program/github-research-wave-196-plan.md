# GitHub Research Wave 196 Plan

- Date: `2026-06-06`
- Theme: `VRChat chatbox status, media, lyrics, IDE presence, and MOTD micro-composers`
- Scope: small and medium sidecars that compose bounded VRChat chatbox text
  from IDE state, media sessions, MPRIS/MPD/Spotify, lyrics, MOTD plugins,
  speech translation, and template variables.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier chatbox waves established media/status composition as a strong VRChat
utility family. Wave 196 deepens that family with narrower micro-composers and
provider-split chatbox tools. The reusable value is not the exact message text,
but the architecture: source modules, templates, privacy controls, cropping,
cadence, change detection, typing indicators, and provider boundaries.

## Search Families

- VRChat OSC chatbox status tools
- IDE and activity to VRChat chatbox senders
- MPRIS, MPD, Windows media, and Spotify chatbox bridges
- lyric and translation chatbox sidecars
- plugin-based MOTD/status composers

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `Null-K/VRChatStatusTask` | IDE status, file, line, errors, warnings, and uptime to chatbox | IDE presence micro-composer |
| `bunboop/vrc-osc-mpris` | Linux MPRIS now-playing to chatbox with small-bubble mode | Media-status sender baseline |
| `Auzlex/vrchat-osc-windows-media` | Windows media session to chatbox with duplicate-send gate | Windows media micro-bridge |
| `lexiuwu71/sillyosc` | WPF status aggregator for time, media, system stats, chatbox, and Discord RPC | Multi-source status composer |
| `lexiuwu71/mpd-vrchat-osc` | Tiny MPD now-playing and remaining-time chatbox sender | Minimal MPD baseline |
| `AtomikkuLabs/VRC-Lyrics` | Flet GUI with Spotify/Windows playback providers, lyrics providers, and OSC managers | Strong lyrics/provider donor |
| `kotleni/vrchat-osc-motd` | TypeScript plugin fan-in composer for MOTD, AFK, PC stats, and Spotify | Plugin-composer donor |
| `KannaCS/VRCTalk` | Tauri speech recognition and translation pipeline to VRChat chatbox | Voice/translation sidecar overlap |

## Dedupe Notes

- These projects overlap with Wave 189 chatbox media/status work but are not
  duplicates of the already studied `RustyChatBox`, Spotify-only tools, or
  generic template GUI tools.
- `KannaCS/VRCTalk` overlaps Wave 188 voice/STT work; it is included here
  because its Tauri recognizer/provider split adds a useful chatbox pipeline
  comparison.
- No external repo was executed, built, installed, or launched.

## Code-Level Pass Targets

- Chatbox message composition and template placeholders.
- Text cropping, message-length policies, and send cadence.
- Provider splits for playback, lyrics, speech recognition, and translation.
- Privacy-sensitive fields such as filenames, active lines, media titles, and
  microphone/transcript content.
- Change detection, keepalive, typing indicators, and stop/clear behavior.
- Configuration storage and plugin/module boundaries.

## Expected Outputs

- Wave 196 landscape synthesis.
- Registry/family placement for chatbox status/media/lyrics micro-composers.
- Methods around provider-backed chatbox composers and plugin fan-in status
  composition.
