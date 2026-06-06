# Wave 258 - VRChat OSC Micro-Control, Input, and Avatar-Parameter Utilities

This wave studies compact VRChat OSC utilities that manipulate avatar
parameters, chatbox text, global hotkeys, controller axes, MIDI, BLE heart
rate, and shell-driven commands.

## Scope

The wave focused on microtools where the reusable value is the control
boundary:

- state mirror from VRChat OSC parameters;
- external input or sensor source;
- safety gate, debounce, queue, or cooldown;
- direct-address OSC sender or typed OSC library;
- visible tray/UI/shell operator surface.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Sayamame-beans/VRC_AFK_AutoMuter` | VRChat OSC micro-control | Studied | AFK and mute-state mirror with delayed voice toggle pulse |
| `03milo/InputFixer` | VRChat OSC input remapper | Studied | OpenVR controller state to VRChat axis correction |
| `Airbee/VRChat-OSC-Scaling` | Avatar parameter microtool | Studied | Tiny eye-height sender UI |
| `koturn/OscRapidUseRight` | OSC input automation | Studied | Global hotkey to repeated `/input/UseRight` pulses |
| `Hino-VRChat/vrchat-mute-toggle` | Robust tray OSC microtool | Studied | Hotkey queue, state mirror, process lifecycle, and tray state |
| `SourLemonJuice/VRChat-OSC-Shell` | Shell-friendly OSC wrapper | Studied | CLI chatbox/typing primitive for scripts |
| `YimuQrrr/OSC_Tool` | VRChat OSC toolkit | Studied | Chatbox, scanner, address tester, MIDI mapping, and key modes |
| `xiaoBingge114514/VRChat-OSC-Chat-Tool` | Chatbox status composer | Studied | Large desktop status, music, lyrics, heart-rate, and system composer |
| `Ero-Cat/hr_push` | Sensor bridge to OSC/chatbox | Studied | BLE heart-rate bridge with HTTP/WS/MQTT/OSC outputs |
| `kb10uy/phorcys` | Typed OSC and avatar config libraries | Studied | Rust OSC parser, VRChat config helpers, MIDI-to-parameter mapper |

## Code-Level Findings

### `Sayamame-beans/VRC_AFK_AutoMuter`

- Interesting idea:
  mirror `AFK` and `MuteSelf` avatar parameters and emit a delayed
  `/input/Voice` pulse only when the local state says it is needed.
- Code donor value:
  useful for small state-machine utilities that need to avoid fighting
  VRChat's own OSC parameter stream.
- Product reference value:
  focused one-value utility with immediate user benefit.
- What to inspect next:
  safer handling of toggle semantics, reconnect, and port sharing.
- Caveats:
  assumes voice input toggle behavior and uses blocking OSC server flow.

### `03milo/InputFixer`

- Interesting idea:
  poll OpenVR controller axes and resend corrected axis values through VRChat
  OSC input endpoints.
- Code donor value:
  useful for `hardware input -> threshold/normalize -> OSC input` adapters and
  menu-safety zeroing when controller state reads fail.
- Product reference value:
  shows that tiny input remappers can solve real VRChat control edge cases.
- What to inspect next:
  binding model, right-hand support, cadence limits, and menu detection.
- Caveats:
  left controller only, OpenVR-specific, and sends at a high rate.

### `Airbee/VRChat-OSC-Scaling`

- Interesting idea:
  a single text field can be enough UI for a useful avatar parameter edit.
- Code donor value:
  narrow donor for tiny customtkinter sender surfaces and direct eye-height
  OSC output.
- Product reference value:
  strong reminder that microtools do not need broad feature scope.
- What to inspect next:
  input clamping, parameter discovery, and confirmation feedback.
- Caveats:
  README names official limits but code does not strongly enforce them.

### `koturn/OscRapidUseRight`

- Interesting idea:
  global hotkey starts/stops repeated raw OSC `/input/UseRight` press/release
  packets and always sends release on stop.
- Code donor value:
  useful for pre-encoded OSC packet loops, hotkey UI, and safe release in a
  `finally` path.
- Product reference value:
  compact automation utility for repeated interaction.
- What to inspect next:
  abuse/spam safeguards, accessibility framing, and clear user warnings.
- Caveats:
  raw packet maintenance and input automation risk.

### `Hino-VRChat/vrchat-mute-toggle`

- Interesting idea:
  combine global hotkey, queued OSC sender worker, OSC state listener, process
  polling, tray status, and periodic hook reinstall into a robust microtool.
- Code donor value:
  strong donor for microtool resilience: queue serialization, cooldown,
  client recreation, listener fallback, and visible tray state.
- Product reference value:
  one of the best references in this wave for turning a tiny OSC action into a
  dependable user tool.
- What to inspect next:
  port conflict UX, admin/global hook guidance, and initial-state handling.
- Caveats:
  no VRChat state query exists, so initial state is inferred.

### `SourLemonJuice/VRChat-OSC-Shell`

- Interesting idea:
  expose VRChat chatbox and typing as shell commands so normal scripts can
  drive VRChat status without embedding an OSC library.
- Code donor value:
  useful for CLI contract, chatbox length guard, and scriptable status
  examples.
- Product reference value:
  a shell wrapper is a valid product surface for power users.
- What to inspect next:
  safer string construction, Windows portability, and more commands.
- Caveats:
  source has rough C memory/string handling and Linux-centric includes.

### `YimuQrrr/OSC_Tool`

- Interesting idea:
  combine chatbox, OSC scanning, address test sliders, MIDI mapping, VRChat log
  monitoring, and key-file modes in one compact toolkit.
- Code donor value:
  good for address-test UI, type-switching parameter sender, MIDI-to-parameter
  mapping, and command mini-shell framing.
- Product reference value:
  useful as a playground for VRChat OSC debugging and quick control.
- What to inspect next:
  split monolithic features into separate safe modules and remove unsafe
  command side effects.
- Caveats:
  broad tool surface, process-kill/open commands, and language/encoding polish
  issues.

### `xiaoBingge114514/VRChat-OSC-Chat-Tool`

- Interesting idea:
  compose chatbox output from music, lyrics, heart rate, Windows media, system
  stats, templates, and history.
- Code donor value:
  useful for status compositor concepts, source-adapter list, template
  persistence, and periodic send policy.
- Product reference value:
  shows demand for a multi-source desktop companion that projects status into
  VRChat.
- What to inspect next:
  module boundaries, privacy toggles, and per-source opt-in.
- Caveats:
  very large monolithic script, Windows and BLE dependencies, and public status
  privacy risks.

### `Ero-Cat/hr_push`

- Interesting idea:
  cross-platform BLE heart-rate bridge with multiple output protocols,
  connection-state parameters, chatbox templates, stale gates, and throttling.
- Code donor value:
  strong donor for BLE Heart Rate Service parsing, validation, output
  throttling, multi-protocol coordinator, and OSC/chatbox safety rules.
- Product reference value:
  polished example of a sensor bridge with user-facing settings and multiple
  integration targets.
- What to inspect next:
  permission flows, biometric consent, and device reconnect behavior.
- Caveats:
  biometric data needs explicit privacy and opt-in rules.

### `kb10uy/phorcys`

- Interesting idea:
  treat VRChat OSC as a typed library and config-driven mapping surface rather
  than one-off packet writes.
- Code donor value:
  strong for OSC parsing/serialization, VRChat OSC config discovery, avatar
  config serde, MIDI table mapping, avatar id validation, and typed parameter
  checks.
- Product reference value:
  useful foundation for future robust OSC tools and test fixtures.
- What to inspect next:
  current compatibility with VRChat config formats and library extraction.
- Caveats:
  workspace complexity and older dependencies.

## Reusable Pattern Extraction

- Pattern candidate:
  VRChat OSC micro-control utility with explicit input source, safety gate, and
  visible state.
- Problem solved:
  many VRChat helper tasks are too small for a full app but too risky for raw
  unbounded OSC sends.
- Reusable core:
  source adapter, typed OSC address contract, state mirror, queue/cooldown,
  safety release or blanking behavior, process/lifecycle gate, visible tray/UI,
  config, privacy mode, and port conflict handling.
- Source evidence:
  AFK muter state mirror, OpenVR axis fixer, rapid input sender, robust mute
  toggle, CLI shell wrapper, OSC toolkit, chatbox composer, BLE heart-rate
  bridge, and Rust typed OSC libraries.
- Abstraction boundary:
  control source and OSC destination must be separated so hotkeys, BLE, MIDI,
  shell scripts, log events, and UI widgets can reuse one sender/state layer.
- What not to copy:
  unbounded automation, public biometric output without consent, unsafe shell
  commands, unvalidated parameter ranges, monolithic script growth, and fixed
  ports without recovery.
- Method catalog action:
  create a new VRChat OSC micro-control method and link it to existing chatbox,
  sensor, haptics, and OSCQuery methods.

## Family Placement

This wave creates a family for VRChat OSC micro-control and external-signal
utilities. It overlaps with chatbox/media waves, biometric bridges, MIDI
bridges, haptics, and diagnostics, but its center is direct control of
avatar/input parameters rather than content composition alone.

## Backlog Impact

- Build a VRChat OSC microtool safety checklist.
- Compare queue, debounce, cooldown, and release semantics across input
  helpers.
- Add a future matrix for port conflicts, OSCQuery discovery, typed address
  contracts, and external-sensor privacy.
