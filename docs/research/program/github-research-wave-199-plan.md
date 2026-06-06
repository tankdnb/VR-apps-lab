# GitHub Research Wave 199 Plan

- Date: `2026-06-06`
- Theme: `VRChat avatar remote control, toy automation, time, and smart-light sidecars`
- Scope: web remote boards, Socket.IO toy menus, VRChat OSC automation
  sequencers, generic OSC sender/debug panels, avatar-controlled physical
  devices, local time/status senders, and Home Assistant light-state bridges.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

VRChat OSC utilities often turn avatar parameters into local actions or expose
remote control surfaces that can operate the avatar through a sidecar. Wave 199
studies this space as a control-surface family: safe remote boards, sequence
automation, toy/haptic routers, web companion menus, generic OSC probes, time
senders, and smart-home state bridges.

## Search Families

- VRChat avatar remote web boards
- VRChat OSC automation sequencers
- generic VRChat OSC sender/debug tools
- avatar parameter to physical device/toy bridges
- web/Socket.IO control toys and shared cursor surfaces
- time and smart-home state to avatar parameter bridges

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `Sakura0721/osc-toys` | FastAPI/WebUI VRChat OSC to DG-LAB Coyote bridge with safe-mode caps | Safety-sensitive physical output donor |
| `UnusualNorm/VRChat-OSC-Toys` | Next.js/Socket.IO web toys, shared cursors, and MIDI-to-avatar channel allocation | Web toy/menu reference |
| `Blise518B/OscGoesPurrr` | Source-light multi-backend haptic router product framing | Product reference |
| `jangxx/VRC-Avatar-Remote-Server` | Full web remote board for controlling avatar parameters via Socket.IO and auth | Strong remote board donor |
| `njm2360/vrchat-osc-automator` | WPF sequence automator for OSC, keyboard, mouse, loops, transitions, import/export | Strong automation donor |
| `t-34400/SimpleVRChatOSCSender` | Tkinter sender/receiver covering avatar params, input, chatbox, trackers, config | Generic OSC harness donor |
| `TheUnifox/OSCTimeSender` | Tiny local time to avatar parameter sender | Micro state bridge |
| `hrolfurgylfa/vrchat-light-sync` | Home Assistant smart-light state to avatar parameters | Smart-home state bridge |

## Dedupe Notes

- This wave overlaps physical-output, browser/phone control, MIDI, and chatbox
  waves, but is focused on control surfaces and sidecar state bridges.
- Safety-sensitive physical-output projects are documented for architecture and
  caveats only; no device, BLE, audio, VRChat, or local web server was started.
- Source-light product references are retained as framing nodes only.

## Code-Level Pass Targets

- Remote board schema: board, avatar, controls, groups, password, API keys, and
  Socket.IO events.
- OSC automation sequence model: slots, loops, breakpoints, transitions,
  reset-on-complete, import/export, and held-input cleanup.
- Generic OSC sender/receiver tabs for chatbox, avatar params, input, trackers,
  and port config.
- Avatar parameter to physical output safety caps, smoothing windows, and
  WebUI guardrails.
- Web companion surfaces using Socket.IO namespaces, MIDI note allocation, and
  shared cursors.
- Micro bridges for time and smart-home state with normalization and polling.

## Expected Outputs

- Wave 199 landscape synthesis.
- Registry/family placement for avatar remote-control and device/status
  sidecars.
- Methods around avatar remote boards, automation sequencers, and external
  device/status micro-bridges.
