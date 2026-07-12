# GitHub Research Wave 339 Plan - Unreal Vendor OpenXR Interaction Samples, Hand Tracking, and MR Feature Bridges

## Goal

Study Unreal/vendor OpenXR sample projects that demonstrate interaction hubs,
hand tracking, body tracking, MR features, and plugin-side utility boundaries.

## Research Questions

- How do vendor samples structure hub scenes, controller interactions, hand-only
  flows, and body/eye/MR features?
- Which parts are product references versus reusable code donors?
- How should future Unreal XR utilities separate plugin data access, UI
  interaction, rendering, and vendor dependencies?

## Shortlist

- `picoxr/PICO_UE5_OpenXRSample`
- `oculus-samples/Unreal-InteractionSDK-Sample`
- `demonixis/FSOpenXRHandTracking`
- `varjocom/VarjoUnrealOpenXRExamples`

## Required Checks

- Deduplicate against prior Unreal/OpenXR/vendor waves.
- Sync source only into local-only cache with LFS smudge disabled.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.
- Treat large sample content as product reference unless a bounded source
  component is isolated.

## Expected Outputs

- Landscape synthesis for Wave 339.
- Registry/family entries for Unreal/vendor OpenXR samples.
- Method catalog entry for vendor OpenXR interaction sample decomposition.
