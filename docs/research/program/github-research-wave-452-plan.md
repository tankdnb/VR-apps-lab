# GitHub Research Wave 452 Plan

- Wave: `452`
- Theme: `XR analytics privacy and session telemetry SDKs`
- Status: `completed`

## Frozen scope

- `CognitiveVR/cvr-sdk-unity`
- `CognitiveVR/xrprivacyframework-unity`
- `CognitiveVR/c3d-sdk-webxr`
- `CognitiveVR/cvr-sdk-unreal`

## Research questions

- How do mature XR analytics SDKs separate session, scene, gaze, dynamic
  object, sensor, controller, boundary, exit poll, and network layers?
- How should privacy categories gate telemetry collectors?
- Which parts are reusable as pattern guidance rather than provider-specific
  code?

## Dedupe notes

- Compared against existing analytics entries:
  `informXR/iXRLibForUnity`, `ArborXR/abxrlib-for-unity`, and
  `GossipAnalyticsXR/Gossip_Analytics_Unity-SDK`.
- These CognitiveVR repos were not already tracked as registry entries.

## Expected outputs

- Wave landscape document.
- Registry section for analytics/privacy SDKs.
- Family placement for privacy-gated telemetry.
- Method catalog entry for privacy-gated XR telemetry.
- Follow-up backlog item for payload schemas and consent persistence.

