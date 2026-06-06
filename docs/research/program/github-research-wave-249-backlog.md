# GitHub Research Wave 249 Backlog

Date: 2026-06-06

Theme: VRChat OBS control, OSC scene switching, and movie night queues.

## Completed In This Wave

- Studied `nerdywoffy/vrchat-obs-controller` as a Go sidecar with YAML config,
  VRChat OSC parameter contracts, OBS v5 and Streamlabs adapters, 500 ms
  status polling, stream/record/replay/scene commands, and avatar feedback.
- Studied `rogeraabbccdd/VRChat-OBSOSC` as a compact Node bridge with
  config.ini, OBS WebSocket v4/v5 compatibility, startup scene/stream sync,
  event subscriptions, and expression-menu parameter mapping.
- Studied `ioarchive/obscontrol` as a historical MelonLoader/ReMod quick-menu
  OBS controller with world leave/join scene switching and strong EAC/TOS
  caveats.
- Studied `TuTu475/VRC-OBS-MicControl` as an OBS Python script with OSC
  parsing, source selection, debounce, correction interval, inversion, and
  debug settings for microphone mute sync.
- Studied `dimebag29/VRChatObsMicMuteLink` as a Windows tray app mapping
  VRChat mute OSC to global OBS hotkey chords.
- Studied `0x29a-blink/VRChat-Movie-Night` as a local event operator stack
  with auth, media library/queue, OBS media-source control, auto-advance,
  OBS busy/offline handling, MediaMTX HLS presets, and HLS readiness checks.
- Studied `MissingNO123/OBS-Scripts-for-VRChat` as OBS-native Python scripts
  for VRChat loading-screen scene switching and OSC action-menu OBS controls.
- Added a reusable method entry for bidirectional VRChat-to-OBS control
  bridges.

## Follow-Up Queue

1. Compare OBS control placement: external sidecar, OBS script, tray hotkey
   shim, local web app, and historical game mod.
2. Extract a minimal OBS WebSocket v5 adapter with reconnect/backoff and
   status feedback.
3. Build a safe avatar-parameter schema for stream, record, replay, scene, and
   mic state.

## Do Not Spend Time On Yet

- Do not run OBS, VRChat, scripts, mods, web apps, MediaMTX, or movie stacks.
- Do not reuse VRChat mod hooks as current architecture.
- Do not copy empty OBS passwords, global hotkeys, or broad movie-download
  features into the repo.
