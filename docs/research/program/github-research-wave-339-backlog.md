# GitHub Research Wave 339 Backlog - Unreal Vendor OpenXR Interaction Samples, Hand Tracking, and MR Feature Bridges

## Executed Scope

- Searched and deduplicated Unreal/vendor OpenXR sample projects.
- Froze a four-project shortlist spanning PICO, Meta, generic OpenXR hand
  tracking, and Varjo OpenXR examples.
- Read source and documentation statically from local-only cache with LFS
  smudge disabled.
- Extracted hub/menu scene patterns, controller/hand/body interaction scenes,
  interaction SDK dependency boundaries, instanced hand rendering, pinch/ray
  input, MetaXR skeleton bridge, Varjo MR/eye/hand feature framing, and vendor
  plugin caveats.

## Studied Projects

- `picoxr/PICO_UE5_OpenXRSample`
- `oculus-samples/Unreal-InteractionSDK-Sample`
- `demonixis/FSOpenXRHandTracking`
- `varjocom/VarjoUnrealOpenXRExamples`

## Backlog Findings

- Treat vendor samples as product references unless source components are small
  and bounded.
- Capture hub/menu and feature-demo organization as reusable UX structure.
- Keep hand data access, rendering, gestures, rays, and vendor SDK bridges
  separated.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include studied projects.
- Method catalog captures Unreal/vendor interaction sample decomposition.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
