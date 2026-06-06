# GitHub Research Wave 189 Plan

- Date: `2026-06-06`
- Theme: `VRChat chatbox media/status and bounded text composition microtools`
- Scope: Spotify/media status, system telemetry, template variables, Linux
  chatbox composers, tiny CLI senders, keepalive/anti-spam, and bounded
  message formatting for VRChat chatbox.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Previous waves already proved that VRChat chatbox is a flexible social display
surface. This wave studies smaller media/status tools to extract message
composition, truncation, dependency checks, playback polling, template
variables, and send-cadence patterns.

## Search Families

- VRChat OSC Spotify chatbox tools
- VRChat OSC status display companions
- Linux chatbox composers
- system telemetry to chatbox
- tiny OSC chatbox sender utilities
- template/placeholder chatbox UIs

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `Voiasis/RustyChatBox` | Linux Rust/egui chatbox toolkit with media/system modules | Linux chatbox composer |
| `bddvlpr/vrc-osc-spotify` | Node/TypeScript Spotify OAuth, playback polling, and lyric scheduling | Spotify bridge with lyric scheduler |
| `Massivendurchfall/vrchat-osc-spotify` | Python GUI Spotify status composer with progress bars and anti-spam | Polished media/status chatbox app |
| `Jakhaxz/VRChatSpotifyControler` | Avatar OSC parameters control desktop Spotify and now-playing output | Avatar-menu media controller |
| `Null-K/VRChat-OSC-ChatBox` | Placeholder/template GUI with live preview and timed sending | Template-variable chatbox surface |
| `WillW129/VRChat_OSC_Display_Mate` | Windows status aggregator for window title, system stats, media, idle, HR | Status aggregator microtool |
| `nekochanfood/VRChat_OSC_Chatbox_for_GO` | Minimal Go CLI for one-off or continuous chatbox sends | Tiny sender baseline |

## Dedupe Notes

- Earlier chatbox waves covered broader TTS/AI/chat surfaces; this wave keeps
  projects where composition, media/status, cadence, or bounded text behavior
  is the main value.
- Simple clones with no extra composition model were excluded.
- Voice/STT projects were separated into Wave 188.

## Code-Level Pass Targets

- message templates, placeholder registries, and preview UX;
- 144-character truncation, progress bar formatting, and anti-spam;
- Spotify OAuth, token persistence, playback polling, and lyric timing;
- media control from avatar OSC parameters;
- Linux dependency-gated modules and system telemetry;
- tiny sender baselines and what they intentionally omit.

## Expected Outputs

- Wave 189 landscape synthesis.
- Registry/family placement for chatbox media/status microtools.
- Methods around Linux chatbox composers, media-to-chatbox bridges, bounded
  template senders, and tiny sender baselines.
