# GitHub Research Wave 285 Backlog - bHaptics Wearable Haptics Routers, Simulator Bridges, and Android Service Boundaries

## Executed Scope

- Searched and deduplicated bHaptics, simulator haptics, avatar haptics, and
  Android haptic-service projects.
- Froze a six-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted simulator telemetry-to-pattern mapping, WebSocket player queues,
  VRChat avatar camera/motor parsing, Android AIDL service calls, direct
  dot-frame scripts, and Unreal content/package references.

## Studied Projects

- `cercata/pysim2bhap`
- `HerpDerpinstine/bHapticsLib`
- `NovaVoidHowl/VRCBhapticsIntegration`
- `Team-Beef-Studios/HapticsService`
- `SeekND/YAWVR-and-BHaptics-addons`
- `bhaptics/TactUnrealEngine4`

## Backlog Findings

- Build a wearable haptics matrix across `.tact` catalogs, dot/frame APIs,
  simulator telemetry, avatar camera triggers, Android AIDL services, Unreal
  pairing UI, device status, consent, and emergency stop.
- Deepen `HerpDerpinstine/bHapticsLib` as the strongest transport donor.
- Deepen `Team-Beef-Studios/HapticsService` for standalone Android/Quest
  service boundaries.
- Treat `NovaVoidHowl/VRCBhapticsIntegration` as a high-value product reference
  with modding and VRChat compatibility caveats.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a wearable haptics router method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
