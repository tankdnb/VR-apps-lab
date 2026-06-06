# GitHub Research Wave 200 Backlog

- Date: `2026-06-06`
- Theme: `VRCOSC module packs, add-on modules, and plugin-distribution boundaries`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for VRCOSC module packs, add-on modules, sensor
  modules, live-event bridges, and avatar-parameter compatibility helpers.
- `Done` Dedupe against the existing VRCOSC host, chatbox, haptics, sensor,
  Twitch, physical-output, and audio-reactive waves.
- `Done` Freeze a shortlist focused on module ecosystem boundaries rather than
  another generic VRChat OSC list.

## Source Sync

- `Done` Confirm `VRCOSC-Modules` in local-only cache.
- `Done` Confirm `CrookedToe-s-Modules` in local-only cache.
- `Done` Confirm `Yeusepes-Modules` in local-only cache.
- `Done` Confirm `FuviiOSC` in local-only cache.
- `Done` Confirm `VRCOSC-BluetoothHeartrate` in local-only cache.
- `Done` Confirm `VrcOscLeash` in local-only cache.
- `Done` Confirm `File-Reading-Module` in local-only cache.
- `Done` Confirm `VRCOSC-Bilibili` in local-only cache.

## Code Reading

- `Done` Inspect official module SDK usage, EventSub nodes, media provider
  flow, voice commands, parameter sync, PiShock safety surface, and OpenVR
  gesture extraction in `VRCOSC-Modules`.
- `Done` Inspect OSCLeash wildcard/legacy path compatibility, movement reset,
  audio device selection, band outputs, spike detection, and AGC in
  `CrookedToe-s-Modules`.
- `Done` Inspect Spotify service modules, QR/screen-code modules, Discord and
  Shazam module structure, and native/service dependency caveats in
  `Yeusepes-Modules`.
- `Done` Inspect Haptickle trigger modes, tracker haptics, SteamVR tracker-role
  mapping, paw/controller parameters, and avatar changer boundaries in
  `FuviiOSC`.
- `Done` Inspect BLE advertisement watcher, selected-device persistence,
  runtime view, reconnect behavior, and optional local WebSocket rebroadcast in
  `VRCOSC-BluetoothHeartrate`.
- `Done` Inspect avatar-config-driven parameter discovery, wildcard route
  compatibility, legacy OSCLeash paths, and movement cleanup in `VrcOscLeash`.
- `Done` Inspect local file polling, chatbox variable/event output, and path
  privacy caveats in `File-Reading-Module`.
- `Done` Inspect Bilibili live event dispatch, async queues, accumulators,
  chatbox and parameter consumers, and parameter decay in `VRCOSC-Bilibili`.

## Integration

- `Done` Create Wave 200 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for VRCOSC module-pack boundaries and
  event-source-to-avatar queues.
- `Next` Build a VRCOSC module trust matrix covering credentials, physical
  output, local files, live services, OpenVR access, and avatar compatibility.
