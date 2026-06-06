# GitHub Research Wave 189 Backlog

- Date: `2026-06-06`
- Theme: `VRChat chatbox media/status and bounded text composition microtools`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for VRChat OSC chatbox media/status tools.
- `Done` Dedupe against earlier VRChat chatbox, TTS, captions, and telemetry
  waves.
- `Done` Freeze a shortlist around media/status composition and small sender
  boundaries.

## Source Sync

- `Done` Confirm `RustyChatBox` in local-only cache.
- `Done` Confirm `vrc-osc-spotify` in local-only cache.
- `Done` Confirm `vrchat-osc-spotify` in local-only cache.
- `Done` Confirm `VRChatSpotifyControler` in local-only cache.
- `Done` Confirm `VRChat-OSC-ChatBox` in local-only cache.
- `Done` Confirm `VRChat_OSC_Display_Mate` in local-only cache.
- `Done` Confirm `VRChat_OSC_Chatbox_for_GO` in local-only cache.

## Code Reading

- `Done` Inspect Rust/egui app setup, config, dependency checks, OSC sender,
  media/system modules, and MPRIS/playerctl handling in `RustyChatBox`.
- `Done` Inspect Spotify OAuth, token persistence, polling, avatar parameter
  toggles, and Musixmatch lyric scheduling in `vrc-osc-spotify`.
- `Done` Inspect Python GUI templates, PKCE auth, progress bars, anti-spam,
  AFK tags, and keepalive behavior in `vrchat-osc-spotify`.
- `Done` Inspect Windows media session control and avatar OSC command mapping
  in `VRChatSpotifyControler`.
- `Done` Inspect placeholder registry, template expansion, preview, timer, and
  chatbox send flow in `VRChat-OSC-ChatBox`.
- `Done` Inspect window/system/media/heart-rate status aggregation and send
  gating in `VRChat_OSC_Display_Mate`.
- `Done` Inspect tiny Go chatbox CLI sender in
  `VRChat_OSC_Chatbox_for_GO`.

## Integration

- `Done` Create Wave 189 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for bounded chatbox composition, media status,
  template placeholders, and tiny sender baselines.
- `Next` Normalize a reusable chatbox composition contract: source modules,
  formatter, truncation, send cadence, keepalive, and privacy flags.
