# GitHub Research Wave 196 Backlog

- Date: `2026-06-06`
- Theme: `VRChat chatbox status, media, lyrics, IDE presence, and MOTD micro-composers`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for VRChat OSC chatbox status, media, IDE presence,
  lyrics, MOTD, MPRIS, MPD, and speech translation sidecars.
- `Done` Dedupe against earlier chatbox, Spotify, voice/STT, and companion app
  waves.
- `Done` Freeze a bounded shortlist focused on composition architecture rather
  than another generic chatbox link list.

## Source Sync

- `Done` Confirm `VRChatStatusTask` in local-only cache.
- `Done` Confirm `vrc-osc-mpris` in local-only cache.
- `Done` Confirm `vrchat-osc-windows-media` in local-only cache.
- `Done` Confirm `sillyosc` in local-only cache.
- `Done` Confirm `mpd-vrchat-osc` in local-only cache.
- `Done` Confirm `VRC-Lyrics` in local-only cache.
- `Done` Confirm `vrchat-osc-motd` in local-only cache.
- `Done` Confirm `VRCTalk` in local-only cache.

## Code Reading

- `Done` Inspect IntelliJ service scheduling, template placeholders, editor
  highlighter counts, cropping, settings persistence, and chatbox sends in
  `VRChatStatusTask`.
- `Done` Inspect MPRIS player lookup, TOML config, small-bubble formatting,
  playback fields, and send cadence in `vrc-osc-mpris`.
- `Done` Inspect Windows Media Controls polling, playback-type filtering,
  duplicate-send gate, and chatbox payload in `vrchat-osc-windows-media`.
- `Done` Inspect WPF config, media/system/time aggregation, scrolling title,
  Discord RPC side-channel, and chatbox loop in `sillyosc`.
- `Done` Inspect MPD polling, remaining-time formatting, and tiny Python OSC
  sender in `mpd-vrchat-osc`.
- `Done` Inspect Flet app structure, playback providers, lyrics providers,
  queued worker updates, chatbox/parameter OSC managers, and clear-on-stop
  behavior in `VRC-Lyrics`.
- `Done` Inspect TypeScript plugin loader, plugin lifecycle, output fan-in,
  and default MOTD/AFK/PC stats/Spotify plugins in `vrchat-osc-motd`.
- `Done` Inspect Tauri/Rust OSC commands, WebSpeech and Whisper recognizers,
  mute listener, typing indicator, translation retry behavior, and provider
  switching in `VRCTalk`.

## Integration

- `Done` Create Wave 196 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for provider-backed chatbox composers and
  plugin fan-in status composition.
- `Next` Build a chatbox status privacy/cadence matrix covering source fields,
  templates, truncation, anti-spam, clear behavior, and cloud-provider risks.
