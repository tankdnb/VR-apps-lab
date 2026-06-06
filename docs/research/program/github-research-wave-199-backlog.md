# GitHub Research Wave 199 Backlog

- Date: `2026-06-06`
- Theme: `VRChat avatar remote control, toy automation, time, and smart-light sidecars`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for VRChat OSC remote boards, automation sequencers,
  generic OSC senders, toy bridges, shared web control toys, time senders, and
  smart-home state bridges.
- `Done` Dedupe against previously studied physical-output, browser OSC,
  haptics, MIDI, and media/status families.
- `Done` Freeze a shortlist that covers control-surface architecture rather
  than one device type.

## Source Sync

- `Done` Confirm `osc-toys` in local-only cache.
- `Done` Confirm `VRChat-OSC-Toys` in local-only cache.
- `Done` Confirm `OscGoesPurrr` in local-only cache.
- `Done` Confirm `VRC-Avatar-Remote-Server` in local-only cache.
- `Done` Confirm `vrchat-osc-automator` in local-only cache.
- `Done` Confirm `SimpleVRChatOSCSender` in local-only cache.
- `Done` Confirm `OSCTimeSender` in local-only cache.
- `Done` Confirm `vrchat-light-sync` in local-only cache.

## Code Reading

- `Done` Inspect FastAPI/WebUI routes, settings, moving-average window,
  DG-LAB/Coyote BLE interface, safe-mode power caps, patterns, and warning
  caveats in `osc-toys`.
- `Done` Inspect Next.js Socket.IO namespace setup, MIDI note channel
  allocation, shared cursor room behavior, and web toy menu structure in
  `VRChat-OSC-Toys`.
- `Done` Mark `OscGoesPurrr` as source-light multi-backend haptic router
  product reference with smoothing, discovery, profiles, and diagnostics
  claims.
- `Done` Inspect Express/Socket.IO server, config, session/API-key auth,
  board/avatar/control schema, avatar change handling, parameter hashing, and
  OSC send boundaries in `VRC-Avatar-Remote-Server`.
- `Done` Inspect WPF/MVVM sequence model, polymorphic slot schema, OSC sender,
  transitions, loops, breakpoints, keyboard/mouse senders, reset-on-complete,
  and import/export service in `vrchat-osc-automator`.
- `Done` Inspect Tkinter tabs, OSC sender/receiver, avatar param tools,
  input-controller controls, chatbox payloads, tracker sends, and config UI in
  `SimpleVRChatOSCSender`.
- `Done` Inspect fixed local time normalization and 10-second sends in
  `OSCTimeSender`.
- `Done` Inspect Home Assistant config, light polling, hue/brightness
  normalization, change-only sends, and bearer-token caveats in
  `vrchat-light-sync`.

## Integration

- `Done` Create Wave 199 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for avatar remote boards, automation sequencers,
  and external device/status micro-bridges.
- `Next` Build a control-surface safety matrix across auth, remote access,
  reset behavior, physical output, state polling, and OSC port binding.
