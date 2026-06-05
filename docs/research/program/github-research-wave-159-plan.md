# GitHub Research Wave 159 Plan

- Date: `2026-06-05`
- Theme: `Haptic, physical-output routers, and wearable feedback bridges`
- Scope: avatar contact to hardware bridges, OWO Skin VRChat integration, and
  device-neutral game haptics routing.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier haptics waves covered bHaptics and avatar-driven feedback. Wave 159
adds a physical-output bridge comparison across three shapes: a DIY Bluetooth
ESP32 pat strap, a feature-rich OWO Skin VRChat integration, and a
device-neutral Intiface game vibration router that turns game/controller rumble
into external hardware output.

## Search Families

- VRChat haptic bridges
- OSCQuery and avatar contact feedback
- wearable haptic device adapters
- DIY ESP32/Bluetooth physical-output utilities
- OWO Skin / muscle-map integrations
- game haptics routers and XInput/UWP event capture

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `kikookraft/HapticPatPat` | DIY low-latency VRChat head-pat feedback bridge using OSCQuery, Bluetooth, and ESP32 PWM motors | DIY avatar-contact haptics |
| `sync1211/owoskin-vrc` | OWO Skin VRChat integration with OSCQuery, collider/velocity/audio effects, presets, UI, CLI, and Unity payloads | Wearable haptics and avatar-driven feedback |
| `intiface/intiface-game-haptics-router` | Device-neutral game rumble router using process injection, XInput/UWP hooks, visualizer, and Intiface Central | Generic game haptics routers |

## Dedupe Notes

- Existing haptics references such as bHaptics, `vrc-owo-suit`, and
  `ShockOSC` remain comparison context; this wave adds new implementation
  shapes instead of repeating those entries.
- `intiface-game-haptics-router` is not a VRChat utility and is kept as a
  haptics-router architecture reference, with explicit caveats around process
  injection and anti-cheat.

## Code-Level Pass Targets

- OSCQuery discovery and fallback ports;
- avatar contact parameter naming and event vocabulary;
- intensity decay and smoothing;
- Bluetooth/firmware packet contracts;
- wearable muscle mapping and sensation lifecycles;
- audio-reactive and velocity/collider effect modules;
- process injection, hook payloads, IPC, visualizer, and device selection
  patterns.

## Expected Outputs

- New Wave 159 landscape synthesis.
- Registry/family updates for DIY haptics, OWO VRChat integration, and generic
  game haptics routing.
- Methods around avatar-contact-to-device bridges, OSCQuery endpoint
  advertisement, wearable haptics effect engines, and generic rumble routers.
