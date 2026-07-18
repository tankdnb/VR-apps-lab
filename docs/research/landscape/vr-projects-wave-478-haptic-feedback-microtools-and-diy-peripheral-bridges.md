# Wave 478: Haptic Feedback Microtools And DIY Peripheral Bridges

- Date: `2026-07-18`
- Scope: OpenXR/Unity haptic managers, feedback microcomponents, haptic game
  references, and DIY glove/peripheral hardware boundaries.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `nafraus/openxr-hapticsmanagerpro` | Studied | Unity OpenXR haptic manager with layered/overlapping impulses and data assets |
| `nafraus/openxr-haptics-manager` | Studied | Minimal Unity XR Interaction Toolkit haptic router |
| `Valsvirtuals/ProtoGlove` | Studied as hardware reference | Modular DIY glove/haptic hardware shell and printable part taxonomy |
| `UetaKento/VRHackathon_HapticsApp` | Studied | Meta XR Haptics tactile matching game and `.haptic` asset usage |
| `kunalchitkara010/VR-Haptics` | Studied | Retrofit hover haptics for Unity objects and UI widgets |
| `LucidVR/lucidgloves` | Existing comparison | Prior DIY glove bridge reference |
| `Z4urce/VRC-Haptic-Pancake` | Existing comparison | Prior haptic bridge reference |

## Project Notes

### `nafraus/openxr-hapticsmanagerpro`

- Interesting idea:
  Haptics should be routed as overlapping feedback intents with combination
  modes and typed data assets, not as one-off controller calls.
- Code donor value:
  `XRHapticsManagerPro.cs` keeps active impulses per controller side, processes
  them in `FixedUpdate`, clamps output, and dispatches
  `SendHapticImpulse`. `HapticData<T>` and curve/custom impulse classes provide
  reusable authoring data.
- Product reference value:
  Strong donor for tool feedback profiles where hover, warning, confirm,
  collision, and background signals may overlap.
- Source evidence:
  `XRHapticsManagerPro/XRHapticsManagerPro.cs`, `HapticData.cs`, and
  `CurveHapticImpulse.cs`.
- Reusable core:
  left/right/both targets, active impulse registry, time-step processing,
  add/multiply/override intent, intensity clamp, duration, curve envelope,
  interactable/interactor/controller adapters, and typed haptic data.
- What not to copy:
  Singleton lock-in, Unity-only dependencies, and incomplete-looking
  operation/priority layer semantics without a clearer policy.
- What to inspect next:
  Turn the manager into a provider-neutral haptic intent router with safety
  limits and accessibility profiles.

### `nafraus/openxr-haptics-manager`

- Interesting idea:
  Keep a tiny haptic baseline that can send an impulse to a controller,
  interactor, interactable, side, or both sides with minimal ceremony.
- Code donor value:
  `VRHapticsManager.cs` shows overloads around `XRDirectInteractor`,
  `XRBaseController`, and `XRBaseInteractable`.
- Product reference value:
  Useful baseline for tutorials and prototypes before adding queued/overlapping
  haptic policy.
- Source evidence:
  `VRHapticsManager.cs`.
- Reusable core:
  side routing, amplitude/duration parameters, controller lookup from
  interactor/interactable, and both-hands helper.
- What not to copy:
  No concurrency, envelope, cooldown, capability check, or safety profile.
- What to inspect next:
  Use as the "minimum viable adapter" under a richer intent layer.

### `Valsvirtuals/ProtoGlove`

- Interesting idea:
  A DIY haptic/tracking peripheral can be documented as modular hardware
  surfaces: baseplate, harness, module slots, controller mounts, and actuator
  positions.
- Code donor value:
  No runtime code donor value was found in this pass; value is in part taxonomy
  and modular physical layout.
- Product reference value:
  Useful for planning hardware-facing bridges because it separates hand
  platform, tracker mount, controller mount, finger guides, and fingertip LRA
  options.
- Source evidence:
  `README.md`, `Presets/Modular.md`, and STL part inventory.
- Reusable core:
  module taxonomy, ESP32/controller mount ideas, LRA fingertip option,
  snap-fit rails, remixable blanks, and preset bundles.
- What not to copy:
  Do not commit large STL/vendor assets into this repo and do not treat hardware
  ergonomics or electrical safety as validated.
- What to inspect next:
  Pair with firmware/runtime bridges that publish capability and safety state.

### `UetaKento/VRHackathon_HapticsApp`

- Interesting idea:
  A tactile-memory task can use haptic clips as game objects: feel a vibration,
  search for a matching pair, then judge with both triggers.
- Code donor value:
  Useful sample of Meta XR Haptics clip playback, `.haptic` assets,
  `HapticClipPlayer` usage, label matching, and simple state reset.
- Product reference value:
  Good UX reference for haptic training, comparison, or accessibility
  calibration tasks.
- Source evidence:
  `Assets/kikuhana/Scripts/MatchingSystem.cs` and Meta XR Haptics sample
  scripts/assets.
- Reusable core:
  named haptic assets, left/right player selection, object label matching,
  trigger state, judge action, matched-object reset, and clip priority/intensity
  hints from the sample package.
- What not to copy:
  The full Unity/Meta sample bulk, garbled README encoding, and game-specific
  object setup.
- What to inspect next:
  Define a haptic pattern catalog with labels, device target, intensity, and
  accessibility fallback.

### `kunalchitkara010/VR-Haptics`

- Interesting idea:
  Retrofit haptic affordance onto existing Unity interactables and UI elements
  through small scripts instead of redesigning the whole interaction system.
- Code donor value:
  `GameObjectHoverHaptics.cs`, `UIHoverHaptics.cs`, and `AddScriptToUI.cs`
  show object hover events, `XRBaseControllerInteractor` haptic impulses,
  UI pointer enter handling, and startup scanner injection for common UI
  components.
- Product reference value:
  Strong micro-utility reference for making legacy spatial UI feel more
  responsive.
- Source evidence:
  `GameObjectHoverHaptics.cs`, `UIHoverHaptics.cs`, and `AddScriptToUI.cs`.
- Reusable core:
  serializable intensity/duration profile, hover event adapter, XR UI pointer
  lookup, tag/filter selection, auto-add interactable, and UI component scan.
- What not to copy:
  Startup-wide `FindObjectsOfType`, tag/index mismatch risks, no cooldown, and
  no accessibility or user-intensity profile.
- What to inspect next:
  Add haptic debounce, intent names, and accessibility strength presets.

## Reusable Pattern Extraction

- Pattern candidate:
  `Haptic feedback microtool with event intent routing profile and peripheral
  safety boundary`.
- Problem solved:
  VR utilities need haptics that map semantic events to device targets while
  respecting intensity, overlap, cooldown, accessibility, and hardware safety.
- Reusable core:
  event intent, side/device target, capability check, amplitude, duration,
  envelope, active impulse registry, combination policy, cooldown, pattern asset
  id, peripheral capability record, and disable/fallback state.
- Source evidence:
  `nafraus/openxr-hapticsmanagerpro`, `nafraus/openxr-haptics-manager`,
  `kunalchitkara010/VR-Haptics`, `UetaKento/VRHackathon_HapticsApp`, and
  hardware-reference `Valsvirtuals/ProtoGlove`.
- Abstraction boundary:
  Keep haptic intent and target routing independent from Unity/Meta/OpenXR
  calls so provider replacement does not change product behavior.
- What not to copy:
  Hidden strong vibrations, unbounded repeated hover pulses, game-only clip
  names, unvalidated DIY hardware assumptions, or sample-package bulk.
- Method catalog action:
  Add `Method 923`.

## Why This Matters For `VR-apps-lab`

Haptics are a reusable feedback channel across overlays, diagnostics,
controllers, accessibility, and hardware bridges. The important reusable unit is
an intent router with visible limits, not just an API call.
