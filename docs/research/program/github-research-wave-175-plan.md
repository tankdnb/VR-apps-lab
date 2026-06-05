# GitHub Research Wave 175 Plan

- Date: `2026-06-05`
- Theme: `VRChat OSC web panels, debug surfaces, controller helpers, and sensor bridges`
- Scope: VRChat OSC chat/web panels, diagnostic listeners, OSCQuery-aware
  parameter browsers, controller micro-tools, finger tracking bridges,
  biometric/heart-rate bridges, and reusable OSC client primitives.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

The repository has strong VRChat OSC coverage, but this wave narrows onto
operator-facing surfaces and small bridges: web chat panels, debug tables,
OSCQuery parameter views, avatar input helpers, Leap Motion finger parameters,
and biometric sensor-to-avatar pipelines.

## Search Families

- VRChat OSC web panels and chatbox helpers
- VRChat OSC diagnostic UIs
- OSCQuery-aware parameter browsers
- controller/avatar micro-tools
- finger tracking and sensor bridges
- biometric and heart-rate OSC senders

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `ThatGuyThimo/leapmotion-osc` | Leap Motion finger distances/spread mapped to VRChat avatar parameters | Finger-to-avatar OSC bridge |
| `a2942/VRChat-OSC-WEB-Chat` | Flask browser chatbox panel with configurable theme/assets and OSC chatbox sending | Browser chatbox panel micro-utility |
| `qbitzvr/Drone-OSC-Controller` | Avatar/controller workflow for VRCLens drone control through OSC parameters | Controller/avatar micro-tool reference |
| `ChrisFeline/VRChatOSCLib` | C# VRChat OSC client/listener wrapper with typed parameters, inputs, chatbox, and message parsing | OSC client primitive library |
| `firocore/VRChatOSCDebugger` | Tkinter/python-osc live OSC parameter table with ignore list and VRChat log setting checks | Lightweight diagnostic listener |
| `Misaka-L/VRChatOscDebugger` | Avalonia/OSCQuery debugger with service discovery and hierarchical parameter tree | OSCQuery-aware diagnostic surface |
| `networkpenetrationtester/VRChat-OSC-WebPanel` | TypeScript OSC router/interface with avatar JSON loading and Svelte parameter panel | Web parameter panel and OSC router donor |
| `200Tigersbloxed/HRtoVRChat_OSC` | Heart-rate service/device/SDK bridge to VRChat avatar parameters with app bridge | Biometric sensor-to-avatar bridge donor |

## Dedupe Notes

- Earlier waves cover broad VRChat companion apps, OSC routers, chatbox sidecars,
  and OSCQuery libraries. This wave focuses on projects that expose UI,
  diagnostics, or bridge-specific parameter methods not already captured.
- `ThatGuyThimo/leapmotion-osc` was already visible as a follow-up candidate;
  this wave upgrades it into a source-level study.
- Several repos are intentionally micro-utilities. They are included because
  focused user value is a valid reuse signal in this repository.

## Code-Level Pass Targets

- Leap Motion hand/finger update loop, finger distance/spread calculation,
  OSC parameter naming, and connection status UI;
- Flask chatbox route handling, config persistence, file-backed assets, theme
  options, and OSC chatbox/typing messages;
- typed VRChat OSC C# wrapper methods for parameters, inputs, chatbox, listener
  events, and message type classification;
- Python/Tk diagnostic table, ignore list, VRChat log parsing, and async OSC
  listener;
- Avalonia/OSCQuery service discovery, connection state, tree parameter UI, and
  local-address filtering;
- TypeScript router/interface, path-pattern listener cache, avatar JSON loading,
  type maps, acknowledged sends, and Svelte parameter views;
- heart-rate manager selection, sensor/device support, parameter normalization,
  SDK/reflection/network plugin model, and app bridge messages.

## Expected Outputs

- New Wave 175 landscape synthesis.
- Registry/family placement for OSC web panels, diagnostics, and sensor bridges.
- Methods around VRChat OSC diagnostic panels, OSCQuery parameter browsers,
  sensor/finger-to-avatar parameter bridges, and biometric SDK ingress.
