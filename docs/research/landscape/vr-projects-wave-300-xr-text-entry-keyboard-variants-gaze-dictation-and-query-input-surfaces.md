# Wave 300 - XR Text Entry, Keyboard Variants, Gaze, Dictation, and Query Input Surfaces

This wave studies XR text-entry projects as reusable references for spatial
keyboards, gaze/dwell typing, runtime keyboard package boundaries, physical
key/collider input, dictation-adjacent text routing, and query-building
interfaces.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Unity XR keyboard packages and collider-driven buttons;
- vendor keyboard packages with layout data and input receiver boundaries;
- gaze/dwell keyboard prototypes for hands-free input;
- larger VR applications where keyboard, dictation, and query terms feed a
  common text/query pipeline;
- dedupe against earlier VR keyboard, WebView keyboard, and accessibility text
  waves.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `ViRGIS-Team/VR-Keyboard` | Minimal Unity XR keyboard package | Studied | Event-driven key lifecycle, upper/lower/other layout layers, and direct interactor boundary |
| `magicleap/MagicLeapXRKeyboard` | Vendor XR keyboard package and layout system | Studied with vendor/deprecation caveats | Manager/layout/input-receiver split, JSON-like layout data, follow/recenter, haptics, and TMP input routing |
| `fabio914/EyeTrackingKeyboard` | Gaze/dwell keyboard prototype | Studied with prototype caveats | Hands-free ray/dwell typing, eye-height following, highlight/audio feedback, and shift/secondary modes |
| `vitrivr/vitrivr-vr` | Search/query VR application with multiple text surfaces | Studied | Static text router, physical keyboard generator, dictation controllers, and modular query term providers |

## Code-Level Findings

### `ViRGIS-Team/VR-Keyboard`

- Interesting idea:
  a reusable VR keyboard can be a tiny event surface: keys emit text, enter,
  and backspace events while the keyboard owns only current layer state.
- Code donor value:
  high for a compact Unity package. `Keyboard.cs` exposes `UnityEvent<string>
  KeyPressed`, `EnterPressed`, `BackspacePressed`, and a `Status` enum for
  upper, lower, and other layouts. `KeyboardButton.cs` swaps labels by
  `KeyboardStatusTypes` and forwards the active value on hover. The interactor
  layer creates/registers an `XRUIInputModule`, removes the standalone input
  module, and maps collider bounds into tracked-device model state.
- Product reference value:
  high for small utility keyboards, quick text panels, command prompts, and
  in-headset settings forms.
- What to inspect next:
  debounce, explicit click versus hover-to-type, localization, long-press
  accents, password/privacy mode, controller/hand parity, and error recovery
  when the scene already owns an input module.
- Reusable pattern extraction:
  use keyboard semantics as events and keep collider/raycast/direct interaction
  separate from text mutation.

### `magicleap/MagicLeapXRKeyboard`

- Interesting idea:
  a production-ish keyboard package is more than key prefabs: it needs a
  manager, layout data, input receiver, follow/recenter behavior, haptics,
  preview state, and input-field lifecycle hooks.
- Code donor value:
  very high conceptually. `KeyboardManager.cs` centralizes show/despawn,
  collider enabling delay, and user-follow behavior. `KeyboardBuilder.cs`
  regenerates rows and keys from `KeyboardLayoutData`, including widths, gaps,
  labels, code values, colors, margins, icons, and accent hints. `TMPInputFieldTextReceiver.cs`
  hides mobile input, listens to TMP select/submit, sends keyboard events to
  `TMP_InputField.ProcessEvent`, clears preview, and despawns on disable.
- Product reference value:
  very high for package shape, input-field integration, and authorable keyboard
  layouts.
- What to inspect next:
  vendor dependencies, license/support status, XRI/OpenXR modernization,
  hand/controller input parity, accessibility settings, and whether layout data
  can be imported into a runtime-neutral keyboard kit.
- Reusable pattern extraction:
  separate keyboard manager, layout builder, text receiver, follow/recenter,
  haptics, and preview affordances.

### `fabio914/EyeTrackingKeyboard`

- Interesting idea:
  gaze/dwell text entry can be implemented as a simple raycast and dwell timer,
  with keyboard height following the user gaze rig.
- Code donor value:
  medium as a prototype. `EyeTrackingKeyboard.cs` raycasts from
  `eyeTransform.forward`, accumulates dwell time with `selectionTime`, follows
  `eyeTransform.position.y - 0.1f`, highlights selected keys, plays audio on
  commit, and handles shift, secondary symbols, enter, and backspace inline.
- Product reference value:
  high for accessibility, hands-free fallback, and controller-loss text entry.
- What to inspect next:
  gaze validity/confidence, calibration, dwell cancellation, accidental
  selection protection, text-field focus, fatigue, and per-user dwell settings.
- Reusable pattern extraction:
  treat gaze keyboards as a separate input mode with confirmation, dwell,
  confidence, and fallback policy instead of a direct copy of controller keys.

### `vitrivr/vitrivr-vr`

- Interesting idea:
  text entry in VR search tools is not just a keyboard; it can be a common
  router fed by physical keys, phrases, dictation, and spatial query-term
  providers.
- Code donor value:
  high for architecture. `TextInputManager.cs` routes characters, words,
  phrases, word-level backspace, and keyboard events to the current TMP input.
  `PhysicalKeyboardController.cs` generates rows from key strings with key
  sizes, padding, spacebar sizing, and callbacks. Query providers such as
  `QueryTermProviderFactory.cs` and `ModularQueryTermManager.cs` show how
  grabbable/droppable query terms can be staged into a search pipeline.
- Product reference value:
  high for search, media browsers, library utilities, and structured command
  entry.
- What to inspect next:
  dictation controllers, query-term lifecycle, multi-field focus, undo/edit
  model, keyboard layout switching, and whether query terms can become a
  reusable command-palette pattern.
- Reusable pattern extraction:
  route all text-like input through a common text/query boundary rather than
  binding each UI surface directly to an input field.

## Reusable Pattern Extraction

- Pattern candidate:
  XR text-entry boundary across keyboard manager, layout data, interaction
  source, text receiver, gaze/dwell mode, dictation/query inputs, and privacy.
- Problem solved:
  VR tools often bolt a keyboard directly to a single input field. Reuse needs
  a neutral input contract that supports controller rays, direct hands,
  gaze/dwell, phrases, dictation, and structured query tokens.
- Reusable core:
  keyboard manager, row/key layout data, active key layer, key event stream,
  text receiver adapter, input-module guard, direct/raycast/gaze interactor,
  dwell confirmation, word/phrase insertion, query-term provider, haptics/audio
  feedback, follow/recenter behavior, and privacy mode.
- Source evidence:
  `VR-Keyboard`, `MagicLeapXRKeyboard`, `EyeTrackingKeyboard`, and
  `vitrivr-vr`.
- Abstraction boundary:
  keep keyboard rendering, key semantics, input source, target text field,
  query model, and feedback policy separate.
- What not to copy:
  hover-to-type without debounce, fixed dwell thresholds without calibration,
  vendor-specific keyboard code without package review, hidden mobile keyboard
  suppression without fallback, or direct text-field mutation from every key.
- Method catalog action:
  add an XR text-entry method covering keyboard, gaze, dictation, and query
  input surfaces.

## Follow-Up Gaps

- Compare this wave against earlier WebView, A-Frame, VRChat keyboard, and
  accessibility text waves to avoid conflating keyboard rendering with text
  routing.
- Deepen `MagicLeapXRKeyboard`, `VR-Keyboard`, and `vitrivr-vr` as the strongest
  donors.
- Build a matrix for text-entry modes: controller ray, direct poke, gaze/dwell,
  physical keyboard, dictation, command palette, and query tokens.
- Consider a reuse plan for an XR text-entry kit with layout data, target
  adapters, privacy settings, dwell mode, and validation hooks.
