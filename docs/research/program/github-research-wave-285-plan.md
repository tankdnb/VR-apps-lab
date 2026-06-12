# GitHub Research Wave 285 Plan - bHaptics Wearable Haptics Routers, Simulator Bridges, and Android Service Boundaries

## Goal

Study bHaptics and wearable-haptics projects as reusable references for
event-to-pattern routing, simulator telemetry, device/player APIs, avatar
haptic triggers, and Android service boundaries.

## Research Questions

- How do projects separate haptic event sources from wearable transport?
- Which `.tact`, frame, dot, service, and device-status APIs are reusable?
- How are intensity, duration, angle, and device position represented?
- What safety, consent, cooldown, and panic-stop boundaries are missing or
  visible?

## Shortlist

- `cercata/pysim2bhap`
- `HerpDerpinstine/bHapticsLib`
- `NovaVoidHowl/VRCBhapticsIntegration`
- `Team-Beef-Studios/HapticsService`
- `SeekND/YAWVR-and-BHaptics-addons`
- `bhaptics/TactUnrealEngine4`

## Required Checks

- Deduplicate against prior haptics, physical-output, VRChat, cockpit, and
  wearable-feedback waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep physical-output safety, modding, device support, and asset-heavy caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 285.
- Registry/family entries for wearable haptics routers and service boundaries.
- Method catalog entry for haptic event routing.
- Follow-up matrix around `.tact` catalogs, dot/frame APIs, avatar triggers,
  Android services, device status, and safety gates.
