# GitHub Research Wave 190 Plan

- Date: `2026-06-06`
- Theme: `Web, phone, and browser remote OSC control surfaces`
- Scope: local web panels, phone/browser controls, WebSocket-to-OSC relays,
  avatar parameter introspection, custom buttons, joystick/keyboard inputs,
  chatbox senders, and remote-control safety caveats.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier waves covered OSC diagnostics and desktop companions. This wave studies
browser and phone-facing control surfaces where the reusable issue is how a
web UI becomes a safe OSC command surface for VRChat.

## Search Families

- VRChat OSC web panels
- phone browser avatar controllers
- WebSocket-to-OSC relays
- browser chatbox and joystick controls
- avatar OSC JSON parameter browsers
- customizable button/action surfaces

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `sselecirPyM/WebVRChatOSC` | ASP.NET/Quasar web UI with OSC API, custom buttons, and avatar JSON parameter discovery | Local web OSC control panel |
| `MiaBub/VRChat-OSC-Controller-Client` | Static web client for keyboard, joystick, jump, and chatbox commands over WebSocket | Browser/phone remote-control client |
| `MiaBub/VRChat-OSC-Controller-Server` | Node WebSocket server mapping remote commands to VRChat OSC input/chatbox paths | WebSocket-to-OSC relay |

## Dedupe Notes

- Earlier OSC debug/web-panel waves covered listeners and diagnostics; this
  wave keeps projects that actually control avatar input or custom command
  surfaces.
- Thin chatbox-only tools were left in Wave 189 unless they introduced a
  browser remote-control architecture.
- Remote-control projects with no source or no VRChat OSC boundary were
  excluded.

## Code-Level Pass Targets

- local HTTP API and WebSocket relay boundaries;
- custom button/action persistence;
- avatar OSC JSON discovery and last-avatar tracking;
- browser joystick, keyboard, and chatbox command schemas;
- command debouncing and key-up safety;
- authentication, origin, public URL, and arbitrary-script risks.

## Expected Outputs

- Wave 190 landscape synthesis.
- Registry and family placement for browser/phone OSC control surfaces.
- Methods for web/phone controller bridges, avatar parameter browsers, and
  WebSocket-to-OSC relays.
