# GitHub Research Wave 132 Backlog

- Date: `2026-06-05`
- Scope: VR keyboard, text-entry, avatar-keyboard, OpenVR keyboard bridge, and
  VRChat OSC input surfaces.

## Completed in this wave

- Studied `danielbuechele/react-360-keyboard` as a React 360 modal keyboard
  with promise-returning native module flow, emoji, and dictation.
- Studied `erosmarcon/vr-keyboard` as a Three.js canvas-texture/raycast
  keyboard with layouts, events, and target-field binding.
- Studied `jcorvinus/VRKeyboard` as a Unity physical keyboard where fingertip
  orientation, push depth, hover, and press throw drive activation.
- Studied `mrowrpurr/VR_Keyboard` as an OpenVR keyboard bridge for Skyrim VR
  mod scripts, including native overlay polling and Papyrus fallback routing.
- Studied `anosatsuk124/VRC-KeyboardController-in-VR_OSC` as a keyboard-to-
  VRChat OSC input emitter with explicit per-frame reset cadence.
- Studied `killfrenzy96/KillFrenzyVRCAvatarKeyboard` as a deprecated avatar-
  contained keyboard lineage with useful caveats about avatar parameter sync.

## Reuse candidates

- `VR_Keyboard` is the strongest native OpenVR keyboard bridge donor.
- `react-360-keyboard` is the strongest modal/promise UX donor.
- `vr-keyboard` is the strongest browser-native raycast keyboard donor.
- `VRKeyboard` is the strongest physical fingertip interaction reference.
- `VRC-KeyboardController-in-VR_OSC` is a compact VRChat OSC control donor.

## Follow-up backlog

1. Extract a comparison table for modal keyboard, raycast keyboard, physical
   keys, native OpenVR keyboard, and OSC input emitter patterns.
2. Compare OpenVR keyboard bridges with current overlay menu/input needs.
3. Revisit `KillFrenzyAvatarText` if avatar text-entry becomes an active
   VRChat creator-tool branch.
4. Add a future method note for text-entry fallback routing across desktop,
   VR overlay, and host-mod environments.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
