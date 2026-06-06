# VR Projects Wave 199: VRChat Avatar Remote Control, Toy Automation, Time, and Smart-Light Sidecars

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 199 studies VRChat OSC sidecars where avatar parameters become control
surfaces or where external state becomes avatar-visible parameters. The
reusable value is remote boards, automation sequences, generic OSC harnesses,
physical-output safety, Socket.IO web toys, and micro state bridges for time or
smart-home state.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `Sakura0721/osc-toys` | VRChat OSC to DG-LAB Coyote WebUI | Safety-sensitive bridge donor |
| `UnusualNorm/VRChat-OSC-Toys` | Web toy menu and MIDI-to-avatar controls | Web companion reference |
| `Blise518B/OscGoesPurrr` | Multi-backend haptic router product framing | Source-light product reference |
| `jangxx/VRC-Avatar-Remote-Server` | Web remote avatar control board | Strong remote-board donor |
| `njm2360/vrchat-osc-automator` | OSC/keyboard/mouse automation sequencer | Strong automation donor |
| `t-34400/SimpleVRChatOSCSender` | Generic VRChat OSC sender/receiver GUI | Probe/harness donor |
| `TheUnifox/OSCTimeSender` | Local time to avatar params | Tiny state bridge |
| `hrolfurgylfa/vrchat-light-sync` | Home Assistant light state to avatar params | Smart-home state bridge |

## `Sakura0721/osc-toys`

- Interesting idea:
  a FastAPI/WebUI app listens to VRChat OSC contact/proximity parameters and
  maps them to DG-LAB Coyote output channels with WebUI configuration and
  safe-mode caps.
- Code donor value:
  high for WebUI/device separation, moving-average smoothing, bounded power
  mapping, pattern selection, settings persistence, and safety warnings.
- Product reference value:
  high for physical-output bridge cautionary design.
- What to inspect next:
  decoupling OSC from BLE, auth for WebUI, local trust boundary, and emergency
  stop behavior.
- Source evidence:
  `main.py`, `routers/coyote.py`, `settings.py`,
  `toys/estim/coyote/dg_interface.py`, and `dg_encoding.py`.
- Reusable pattern extraction:
  avatar parameter to safety-capped physical output bridge.
- Reusable core:
  listen to explicit float parameters, smooth values over a short window, map
  normalized input to bounded channel output, expose max power and pattern
  controls in a local UI, persist settings, and prevent risky changes while a
  device is connected.
- Do not copy directly:
  e-stim defaults, physical-output behavior, missing WebUI auth, or any path
  without consent, panic stop, and local-only trust review.
- Caveats:
  safety-sensitive; document architecture lessons, not device behavior to
  replicate.

## `UnusualNorm/VRChat-OSC-Toys`

- Interesting idea:
  a Next.js app uses Socket.IO namespaces for web toy surfaces, shared cursors,
  and a MIDI-to-avatar instrument that allocates notes across avatar parameter
  channels.
- Code donor value:
  medium for Socket.IO namespace separation, shared cursor rooms, note-channel
  allocation, and web companion UI.
- Product reference value:
  high for playful web companion control surfaces.
- What to inspect next:
  missing/incomplete OuijAtar server handlers, auth, mobile UX, and parameter
  schema.
- Source evidence:
  `pages/api/socket.ts`, `namespaces/MidiAtar.ts`,
  `namespaces/CursorShare.ts`, `pages/MidiAtar/index.tsx`, and
  `components/Home/Menu.tsx`.
- Reusable pattern extraction:
  web companion toy menu with namespaced real-time control.
- Reusable core:
  split each toy into a Socket.IO namespace, keep web UI state synchronized
  with remote participants, allocate finite avatar parameter channels for
  active notes/actions, and broadcast shared cursors or active state to the
  group.
- Do not copy directly:
  unauthenticated public control, incomplete server events, or hardcoded avatar
  paths as final design.
- Caveats:
  fun UX reference; not a mature secure remote-control tool.

## `Blise518B/OscGoesPurrr`

- Interesting idea:
  source-light product framing for a multi-backend VRChat OSC to haptics router
  spanning Bluetooth toys, SteamVR trackers, bHaptics, DG-LAB, OWO, OSR2, and
  diagnostics.
- Code donor value:
  low until source boundaries are visible.
- Product reference value:
  high for product direction: multi-backend routing, smoothing, discovery,
  profile binding, real-time debugger, and safety caps.
- What to inspect next:
  actual source release, backend abstractions, OSCQuery discovery, safety
  gates, and profile model.
- Source evidence:
  README and `docs/index.html`.
- Reusable pattern extraction:
  multi-backend haptic router product framing.
- Do not copy directly:
  product claims without implementation evidence.
- Caveats:
  useful as direction confirmation, not a code donor yet.

## `jangxx/VRC-Avatar-Remote-Server`

- Interesting idea:
  a web server lets an owner create boards where other people can control
  selected avatar parameters through password/API-key protected pages and
  Socket.IO realtime actions.
- Code donor value:
  very high for board/avatar/control schema, session/API-key auth, avatar
  change tracking, parameter hashing, grouped controls, and action execution.
- Product reference value:
  very high for safe remote-avatar-control product design.
- What to inspect next:
  client UI build, Cloudflare tunnel deployment risk, per-board permission
  model, rate limits, and audit logging.
- Source evidence:
  `index.js`, `src/config.js`, `src/board.js`,
  `src/socket_manager.js`, `src/backend_avatar_param_control.js`,
  `src/vrc_avatar_manager.js`, and `src/osc_manager.js`.
- Reusable pattern extraction:
  avatar remote board and automation sender with named actions.
- Reusable core:
  model boards, avatars, groups, and controls; require board/admin login or API
  keys; listen for `/avatar/change`; hash avatar ids before exposing them;
  validate control type and data type; send button/toggle/range actions only
  when the target avatar is active; and mirror parameter updates back to
  subscribed clients.
- Do not copy directly:
  internet exposure without rate limits/audit logs, tunnel defaults, or broad
  remote control without user-owned permissions.
- Caveats:
  strongest remote-control donor in this wave.

## `njm2360/vrchat-osc-automator`

- Interesting idea:
  a WPF/MVVM application builds automation profiles from typed sequence slots:
  OSC sends, waits, random waits, loops, breakpoints, keyboard input, mouse
  input, transitions, hotkeys, and import/export.
- Code donor value:
  very high for sequence schema, reset-on-complete, transition interpolation,
  held-input cleanup, multi-target OSC sending, JSON import/export, and tests.
- Product reference value:
  high for desktop macro utility UX.
- What to inspect next:
  safety presets, profile sharing, command validation, and optional dry-run
  previews.
- Source evidence:
  `Models/SequenceSlot.cs`, `Services/SequencePlayerService.cs`,
  `Services/OscSenderService.cs`, `Services/SequenceImportExportService.cs`,
  `docs/detailed-design.md`, and tests.
- Reusable pattern extraction:
  OSC/input automation sequencer with reset and import/export semantics.
- Reusable core:
  represent every action as a typed slot, serialize slots with a discriminator,
  support loops, breakpoints, transitions, random waits, hotkeys, pause/resume,
  reset OSC values when complete or interrupted, release held keyboard/mouse
  inputs on pause/stop, and export/import profile JSON.
- Do not copy directly:
  OS-level input automation without user confirmation, unsafe profiles, or
  profile sharing without validation.
- Caveats:
  excellent method donor; it should inform any future macro/automation helper.

## `t-34400/SimpleVRChatOSCSender`

- Interesting idea:
  a Tkinter app covers the official VRChat OSC surfaces in one test harness:
  avatar parameters, input controller, chatbox, trackers, receiver, and port
  configuration.
- Code donor value:
  high as a documentation-aligned generic sender/receiver harness.
- Product reference value:
  medium for developer/debug tooling.
- What to inspect next:
  type parsing, receiver restart race, parameter history UX, and validation.
- Source evidence:
  `main.py`, `osc/osc_sender.py`, `osc/osc_receiver.py`, `views/*`, and
  `services/*`.
- Reusable pattern extraction:
  generic VRChat OSC surface harness.
- Reusable core:
  keep a configurable UDP sender and receiver, expose separate UI tabs for
  each official OSC surface, rebuild receiver config on demand, and let users
  send typed avatar/input/chatbox/tracker payloads.
- Do not copy directly:
  unverified behavior claims, minimal error handling, or bool parsing quirks.
- Caveats:
  strongest as an internal reference/probe utility shape.

## `TheUnifox/OSCTimeSender`

- Interesting idea:
  a tiny C# program sends normalized local hour and minute values to avatar
  parameters every ten seconds.
- Code donor value:
  low-to-medium as a simple state-to-parameter micro-bridge.
- Product reference value:
  medium for avatar status effects.
- What to inspect next:
  24-hour support, timezone/user config, persistent UDP client, and parameter
  naming.
- Source evidence:
  `OSCTimeSender/Program.cs`.
- Reusable pattern extraction:
  external state to normalized avatar parameters.
- Reusable core:
  read local state, normalize it to VRChat-friendly floats, send at a low
  cadence, and keep the parameter contract obvious.
- Do not copy directly:
  fixed paths/ports or recreating UDP clients per send as final design.
- Caveats:
  useful micro-utility proof of value.

## `hrolfurgylfa/vrchat-light-sync`

- Interesting idea:
  a Rust sidecar polls Home Assistant light state and mirrors on/off, hue, and
  brightness to VRChat avatar parameters only when state changes.
- Code donor value:
  high for external service polling, normalization, change-only sends, and
  config shape.
- Product reference value:
  high for smart-home-to-avatar state bridges.
- What to inspect next:
  bearer token storage, HTTPS support, reconnect/backoff, and multiple lights.
- Source evidence:
  `src/main.rs` and `settings.example.yaml`.
- Reusable pattern extraction:
  external device/status to avatar parameter micro-bridge.
- Reusable core:
  configure external service credentials and VRChat target, poll at a bounded
  rate, translate service-specific values into normalized avatar parameters,
  compare against previous state, and send only on changes.
- Do not copy directly:
  plaintext bearer-token examples, panic-on-request failures, or HTTP-only
  assumptions.
- Caveats:
  strong tiny donor for external-state bridges.

## Cross-Project Lessons

- Remote avatar control needs auth, scope, active-avatar checks, rate limits,
  and reset behavior.
- Automation utilities should treat cleanup as a first-class feature: held keys
  and OSC values must be released on stop/pause/failure.
- Physical-output bridges require safety caps, visible local control, and
  consent boundaries before feature ambition.
- Generic OSC sender/receiver harnesses are valuable foundation tools because
  they document official OSC surfaces in code.
- Micro state bridges are useful when their contract is obvious: normalized
  value, low cadence, change detection, and safe credential storage.

## Reuse Recommendations

1. Use `VRC-Avatar-Remote-Server` as the strongest remote board/control donor.
2. Use `vrchat-osc-automator` as the strongest automation sequencer donor.
3. Use `SimpleVRChatOSCSender` as a generic OSC harness reference.
4. Use `osc-toys` only for safety-aware physical-output architecture lessons.
5. Use `vrchat-light-sync` and `OSCTimeSender` for external-state micro-bridge
   baselines.

## Follow-Up Gaps

- Build a remote-control safety matrix across auth, active-avatar validation,
  rate limits, reset behavior, audit logs, and internet exposure.
- Extract a reusable OSC automation sequence schema with slots, transitions,
  loops, reset-on-complete, and import/export validation.
- Compare local web UI, Socket.IO, WPF, Tkinter, and CLI surfaces for VRChat
  sidecar control utilities.
- Define minimum requirements for any physical-output bridge before it can
  become a prototype direction in `VR-apps-lab`.
