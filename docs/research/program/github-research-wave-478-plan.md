# GitHub Research Wave 478 Plan

- Date: `2026-07-18`
- Theme: Haptic feedback microtools and DIY peripheral bridges.

## Frozen Scope

- `nafraus/openxr-hapticsmanagerpro`
- `nafraus/openxr-haptics-manager`
- `Valsvirtuals/ProtoGlove`
- `UetaKento/VRHackathon_HapticsApp`
- `kunalchitkara010/VR-Haptics`
- Existing comparison refs: `LucidVR/lucidgloves`,
  `Z4urce/VRC-Haptic-Pancake`

## Research Questions

- How should utility haptics be represented as semantic feedback intents?
- Which minimal Unity/OpenXR haptic routers are useful as donor baselines?
- How do DIY peripherals affect capability, safety, and fallback labels?

## Required Extraction

- controller/peripheral target routing
- amplitude, duration, envelope, and overlap policy
- event intent and pattern asset model
- hover/UI retrofit flow
- device capability/safety boundary
- accessibility and cooldown caveats
