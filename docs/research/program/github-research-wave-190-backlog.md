# GitHub Research Wave 190 Backlog

- Date: `2026-06-06`
- Theme: `Web, phone, and browser remote OSC control surfaces`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for VRChat OSC web panels and phone/browser control
  surfaces.
- `Done` Dedupe against earlier OSC diagnostics, web-panel, and chatbox waves.
- `Done` Freeze a focused shortlist around browser control, local APIs, and
  WebSocket relays.

## Source Sync

- `Done` Confirm `WebVRChatOSC` in local-only cache.
- `Done` Confirm `VRChat-OSC-Controller-Client` in local-only cache.
- `Done` Confirm `VRChat-OSC-Controller-Server` in local-only cache.

## Code Reading

- `Done` Inspect ASP.NET service setup, CoreOSC service, LiteDB button store,
  avatar JSON parameter loader, background `/avatar/change` tracking, and
  Quasar UI components in `WebVRChatOSC`.
- `Done` Inspect browser keyboard, joystick, chatbox, reconnect, and ping logic
  in `VRChat-OSC-Controller-Client`.
- `Done` Inspect Node WebSocket command map, OSC input/chatbox sends, profanity
  filter, key-up-all behavior, and broadcast behavior in
  `VRChat-OSC-Controller-Server`.

## Integration

- `Done` Create Wave 190 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable method for web/phone OSC controller bridges.
- `Next` Extract a security checklist for browser-to-OSC command surfaces:
  auth, origin, local-only binding, command allowlist, and emergency key-up.
