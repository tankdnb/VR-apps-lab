# VR Projects Wave 132: VR Keyboard, Text-Entry, and OSC Input Surfaces

- Date: `2026-06-05`
- Goal: study reusable VR text-entry and control-input surfaces across WebVR,
  Three.js, Unity, OpenVR, host-mod, and VRChat OSC patterns.

## Why this wave exists

VR utility tools often need text entry, quick search, notes, commands, or
remote-control input. This wave focuses on the actual input surface patterns,
not on shipping a keyboard app.

## Better workflow used in this wave

1. searched by VR keyboard, text-entry, OpenVR keyboard, and VRChat OSC input
   families;
2. deduplicated against existing overlay, VRChat text, avatar sidecar, and menu
   waves;
3. froze a bounded shortlist across different host environments;
4. inspected local-only source clones;
5. separated donor-worthy input mechanisms from deprecated historical ideas;
6. extracted methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `danielbuechele/react-360-keyboard` | React 360 modal text input with native module boundary |
| `erosmarcon/vr-keyboard` | Browser-native Three.js keyboard with raycast events |
| `jcorvinus/VRKeyboard` | Unity physical/fingertip keypress keyboard |
| `mrowrpurr/VR_Keyboard` | OpenVR keyboard bridge for Skyrim VR mod scripts |
| `anosatsuk124/VRC-KeyboardController-in-VR_OSC` | Keyboard-to-VRChat OSC control emitter |
| `killfrenzy96/KillFrenzyVRCAvatarKeyboard` | Deprecated avatar-contained keyboard lineage |

## Deep-pass notes by project

## `danielbuechele/react-360-keyboard`

- GitHub:
  [danielbuechele/react-360-keyboard](https://github.com/danielbuechele/react-360-keyboard)
- What it is:
  a virtual keyboard for React 360 where the app calls a native module and
  receives entered text asynchronously.
- Interesting idea:
  expose VR text input as a promise-returning modal service instead of forcing
  every scene to own keyboard state.
- Code-level notes:
  `Keyboard.js` keeps modal state for `value`, `shift`, and mode
  (`alphabetic`, `numeric`, `emoji`, `dictation`). The native module exposes
  `NativeModules.Keyboard.startInput(config)` and resolves once input ends.
  The UI supports `initialValue`, placeholder, sound, emoji, dictation, return
  key label, tint color, fade in/out via `Animated.Value`, `Backspace`, return,
  emoji selection, and Web Speech API dictation.
- Code donor value:
  high for promise/callback lifecycle, modal input configuration, and optional
  dictation/emoji modes.
- Product reference value:
  high for headset-friendly text input that feels like a service, not a scene
  component.
- Caveats:
  tied to React 360 and browser speech APIs.
- What to inspect next:
  compare with OpenVR-native keyboard bridges for non-browser overlays.

## `erosmarcon/vr-keyboard`

- GitHub:
  [erosmarcon/vr-keyboard](https://github.com/erosmarcon/vr-keyboard)
- What it is:
  a Three.js virtual keyboard rendered as a canvas texture and controlled by
  raycasting.
- Interesting idea:
  keep the keyboard self-contained: layout, drawing, hit testing, target field
  focus, and key events live together.
- Code-level notes:
  `VRKeyboard.js` defines `VRKey` objects with type-specific width/height,
  collision checks, multiple layouts (`number_pad`, `numeric`, `numeric_alt`,
  `alphabets_lower`, `alphabets_upper`), and target value mutation. It creates
  a canvas texture, uses `THREE.Raycaster`, dispatches keyboard events
  (`keydown`, `keyup`, `keyhold`, `keyover`, `keyout`, `update`), and handles
  `SHIFT`, `DELETE`, `ENTER`, and layout switching.
- Code donor value:
  high for browser-native keyboard layout, hit testing, and event modeling.
- Product reference value:
  medium-high for WebXR utilities that need text without native overlays.
- Caveats:
  custom canvas/text rendering and old Three.js assumptions need modernization.
- What to inspect next:
  extract a generic raycast-keyboard state diagram.

## `jcorvinus/VRKeyboard`

- GitHub:
  [jcorvinus/VRKeyboard](https://github.com/jcorvinus/VRKeyboard)
- What it is:
  a Unity VR keyboard focused on physical key interaction.
- Interesting idea:
  model keys as pressable physical surfaces with fingertip orientation and
  push-depth gates, not just raycast buttons.
- Code-level notes:
  `Keyboard.cs` uses a `StringBuilder`, output text binding, character sets,
  mode changes, and non-character key handling. `FingerButton.cs` tracks
  fingertips inside collision bounds, filters index/middle/thumb and chirality,
  checks fingertip orientation using `Vector3.Dot`, tracks furthest push point,
  calculates throw value against `ButtonThrowDistance`, debounces reactivation,
  fires hover/activate events, and changes audio pitch/volume as a key is
  pressed.
- Code donor value:
  high for hand/finger-driven physical button UX.
- Product reference value:
  medium-high for VR menus where tactile metaphor matters more than speed.
- Caveats:
  Unity/hand-tracking assumptions and physical keypress UX may be slower than
  ray or native keyboard input.
- What to inspect next:
  compare with hand-menu and near/far UI primitives from earlier engine waves.

## `mrowrpurr/VR_Keyboard`

- GitHub:
  [mrowrpurr/VR_Keyboard](https://github.com/mrowrpurr/VR_Keyboard)
- What it is:
  an OpenVR keyboard bridge for Skyrim VR mods.
- Interesting idea:
  wrap SteamVR's keyboard in a native DLL and expose it to a script/mod host
  through a polling API plus a non-VR fallback path.
- Code-level notes:
  `VRKeyboard.h` creates an OpenVR overlay, calls `ShowKeyboardForOverlay`,
  polls keyboard events (`VREvent_KeyboardClosed`, `VREvent_KeyboardDone`),
  reads text with `GetKeyboardText`, and uses a thread/atomic state for open
  lifetime. `VRKeyboardPapyrus.h` registers `OpenKeyboard` and
  `PollForFinishedKeyboardEntry`. `VRKeyboard.psc` exposes
  `GetKeyboardInput(startingText="", waitInterval=0.1)` and polls in
  `Utility.WaitMenuMode`. `TextInputUtil.psc` routes to the VR keyboard in
  Skyrim VR and to `UIExtensions` text entry outside VR.
- Code donor value:
  very high for native OpenVR keyboard bridge, event polling, and host-script
  integration.
- Product reference value:
  high for mod-host and overlay utility text entry.
- Caveats:
  specific to Skyrim VR/Papyrus and SteamVR/OpenVR.
- What to inspect next:
  extract a reusable "host script calls native VR modal input" blueprint.

## `anosatsuk124/VRC-KeyboardController-in-VR_OSC`

- GitHub:
  [anosatsuk124/VRC-KeyboardController-in-VR_OSC](https://github.com/anosatsuk124/VRC-KeyboardController-in-VR_OSC)
- What it is:
  a Rust/egui keyboard controller that emits VRChat OSC input messages.
- Interesting idea:
  treat keyboard keys as a transient control source for VRChat by sending OSC
  values and explicitly resetting them every evaluation tick.
- Code-level notes:
  `osc.rs` uses `rosc`, default loopback host, receiver port `9000`, sender
  port `9001`, and `/input` address base. `input/mod.rs` tracks movement and
  looking state, sends `/input/Vertical`, `/input/Horizontal`, and
  `/input/LookHorizontal`, then resets values in `eval()`. `app.rs` provides
  an egui/eframe shell with locale detection and canvas sizing.
- Code donor value:
  medium-high for compact OSC sender/reset cadence and input-state mapping.
- Product reference value:
  high for VRChat control sidecars and accessibility tools.
- Caveats:
  does not solve in-headset text display by itself; it is an input emitter.
- What to inspect next:
  compare with earlier VRChat OSC routers and avatar automation sidecars.

## `killfrenzy96/KillFrenzyVRCAvatarKeyboard`

- GitHub:
  [killfrenzy96/KillFrenzyVRCAvatarKeyboard](https://github.com/killfrenzy96/KillFrenzyVRCAvatarKeyboard)
- What it is:
  a deprecated VRChat avatar-contained keyboard.
- Interesting idea:
  before stronger external sidecars, avatar parameters and finger colliders
  were used to build text-entry-like behavior inside the avatar itself.
- Code-level notes:
  the README documents that the project became broken after VRChat AV3
  `2021.1.1` because sub-animators could no longer change parameters. Its
  original approach used avatar parameter sync, an in-world marker, desktop
  mode, FX layers, expression menu/parameters, and finger colliders attached to
  avatar bones.
- Code donor value:
  low for current code reuse, medium as a historical constraint lesson.
- Product reference value:
  medium for understanding why external sidecars/OSC are safer than avatar-
  contained keyboards.
- Caveats:
  deprecated/broken by platform behavior.
- What to inspect next:
  inspect `KillFrenzyAvatarText` only if avatar text-entry becomes active.

## Cross-project synthesis

Reusable lessons:

- VR text entry should be a service boundary when possible: call, await result,
  close, and restore context.
- Browser/WebXR keyboards need their own layout, hit-test, and event model.
- Physical keypress UI needs orientation/depth/debounce checks, not just
  collider enter events.
- Native OpenVR keyboard integration is valuable when the host environment
  lacks text input.
- OSC input emitters must reset transient values deliberately or movement
  commands stick.
- Deprecated avatar-contained keyboards are still useful as platform-risk
  warnings.

Best donor candidates:

- `VR_Keyboard` for OpenVR keyboard bridge and host-script API.
- `react-360-keyboard` for modal promise lifecycle.
- `vr-keyboard` for raycast/canvas keyboard architecture.
- `VRKeyboard` for fingertip physical keypress UX.
- `VRC-KeyboardController-in-VR_OSC` for OSC input emission.

## Reuse implications for `VR-apps-lab`

This wave suggests a `VR text-entry surfaces` branch:

- modal keyboard service interface;
- raycast keyboard layout/event model;
- native OpenVR keyboard bridge;
- physical fingertip button pattern;
- OSC input emitter/reset cadence;
- host fallback routing between desktop, VR, and mod environments.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were used only for code reading and are local-only.
