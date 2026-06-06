# VR Projects Wave 190: Web, Phone, and Browser Remote OSC Control Surfaces

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 190 studies web and phone-facing VRChat OSC control surfaces. The useful
patterns are local web APIs, custom button stores, avatar parameter discovery,
browser joystick/keyboard controls, WebSocket relays, and the safety boundaries
needed before remote input is acceptable.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `sselecirPyM/WebVRChatOSC` | ASP.NET/Quasar local OSC control panel | Strong web-panel architecture donor |
| `MiaBub/VRChat-OSC-Controller-Client` | Browser/phone control client | Useful remote-control UX reference |
| `MiaBub/VRChat-OSC-Controller-Server` | WebSocket-to-OSC relay | Useful relay and command-map donor |

## `sselecirPyM/WebVRChatOSC`

- Interesting idea:
  a local web app exposes OSC send APIs, stored custom buttons, chatbox fields,
  joystick sliders, and VRChat avatar parameter discovery from OSC JSON files.
- Code donor value:
  high for service separation, LiteDB button persistence, CoreOSC send/listen
  service, avatar JSON scanning, `/avatar/change` tracking, and web UI
  composition.
- Product reference value:
  high for phone/browser control panels that sit beside VRChat.
- What to inspect next:
  security model, local-only binding, JavaScript action execution, and safer
  custom action schemas.
- Source evidence:
  `Program.cs`, `Config.cs`, `OSCService.cs`, `OSCAPIController.cs`,
  `ButtonAPIController.cs`, `AvatarAPIController.cs`,
  `MyBackgroundService.cs`, `webui/src/pages/IndexPage.vue`,
  `CustomButton.vue`, and `ParameterDialog.vue`.
- Reusable pattern extraction:
  web/phone OSC controller bridge with avatar parameter discovery.
- Reusable core:
  run a local HTTP UI, keep OSC send/listen in a service, expose a typed
  allowlisted send API, persist user-defined buttons, read VRChat OSC avatar
  JSON parameter files, track the last avatar from `/avatar/change`, and let
  browser controls send chatbox, input, and avatar parameter commands.
- Do not copy directly:
  arbitrary JavaScript button actions, public binding without auth, or raw OSC
  path sends without an allowlist.
- Caveats:
  strategically strong, but security boundaries should be designed before reuse.

## `MiaBub/VRChat-OSC-Controller-Client`

- Interesting idea:
  a static browser client turns keyboard keys, jump/send buttons, movement and
  camera joystick controls, and chatbox text into WebSocket commands.
- Code donor value:
  medium for browser-side input mapping, repeat suppression, reconnect, ping,
  joystick state, and chatbox command payloads.
- Product reference value:
  medium for phone-based helper controls and accessibility experiments.
- What to inspect next:
  connection setup, authentication, touch ergonomics, and command affordances
  on small screens.
- Source evidence:
  `js/app.js` and static UI files.
- Reusable pattern extraction:
  browser remote-control client for OSC relay.
- Reusable core:
  map keyboard and touch controls to named command payloads, suppress repeated
  keydown spam, send chatbox messages as a separate payload type, keep a
  WebSocket ping/reconnect loop, and make joystick controls explicit floats
  rather than key-only events.
- Do not copy directly:
  hardcoded public WebSocket endpoint, no auth, or remote input controls
  without visible state and stop controls.
- Caveats:
  useful UX sketch, but too risky as-is for a public control surface.

## `MiaBub/VRChat-OSC-Controller-Server`

- Interesting idea:
  a Node server receives browser WebSocket commands, maps them to VRChat OSC
  input/chatbox paths, applies a simple profanity filter, and broadcasts
  commands to other connected clients.
- Code donor value:
  medium for command-map shape, key-up-all safety idea, float joystick sends,
  and chatbox relay.
- Product reference value:
  medium for quick browser-to-VRChat remote control experiments.
- What to inspect next:
  authentication, origin checks, command allowlists, rate limits, and emergency
  stop behavior.
- Source evidence:
  `websocket_server.js`.
- Reusable pattern extraction:
  WebSocket-to-OSC relay with stateful input command map.
- Reusable core:
  accept JSON command messages, map command names to OSC paths and typed
  values, send `/input/*` and `/chatbox/input`, reset input states on demand,
  and keep relay logic separate from browser UI code.
- Do not copy directly:
  unauthenticated public WebSocket behavior, hardcoded ports/IPs, playful
  avatar parameter side effects, or unrestricted remote motion commands.
- Caveats:
  the relay pattern is reusable; the security model must be redesigned.

## Cross-Project Lessons

- Browser/phone control surfaces need a strict command allowlist before they
  send OSC into VRChat.
- Avatar parameter discovery from VRChat OSC JSON files is a strong UX shortcut
  for custom button builders.
- Remote input surfaces should expose connection state, last command, and a
  clear all-keys-up/emergency stop path.
- Arbitrary script execution is convenient for power users but unsafe as a
  default model.
- The useful boundary is browser UI -> local API/WebSocket -> OSC service, not
  browser code directly owning every OSC detail.

## Reuse Recommendations

1. Use `WebVRChatOSC` as the strongest local web-panel architecture donor.
2. Use the MiaBub client/server pair as a contrast case for browser joystick
   UX and relay command mapping.
3. Before prototyping a similar tool in `VR-apps-lab`, write a security
   checklist around binding, auth, origin, allowlists, rate limits, and
   emergency input reset.

## Follow-Up Gaps

- Define a safe JSON schema for user-configurable OSC buttons.
- Compare OSCQuery discovery against VRChat OSC avatar JSON discovery.
- Design a phone-first control layout that does not hide connection/emergency
  state.
- Decide whether remote input control belongs in a prototype, a diagnostic
  tool, or only a documented pattern.
