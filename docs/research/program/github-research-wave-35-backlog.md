# GitHub Research Wave 35 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on `expressive tracking`,
  `face and eye input`, and `avatar-facing input bridges`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for face-tracking platforms, hand remappers, gaze layers, and avatar-facing bridges
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans broad platforms, provider remappers, SteamVR drivers, and an OpenXR API layer
- `Done` Keep `quest_steamvr_fbt_tool` as a later follow-up node instead of promoting it ahead of the stronger mainline donors

## Work package B: Local source acquisition

- `Done` Confirm `Baballonia` in local cache
- `Done` Confirm `HandshakeVR` in local cache
- `Done` Confirm `mercury_steamvr_driver` in local cache
- `Done` Confirm `PSVR2_OpenXR_Eye_Tracking` in local cache
- `Done` Confirm comparison metadata for `quest_steamvr_fbt_tool`
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect overlay-assisted calibration and capture-module boundaries in `Baballonia`
- `Done` Inspect provider switching and hand-remapping layers in `HandshakeVR`
- `Done` Inspect tracking subprocess and device registration flow in `mercury_steamvr_driver`
- `Done` Inspect named-pipe gaze ingestion and extension-gated layer activation in `PSVR2_OpenXR_Eye_Tracking`

## Work package D: Repository updates

- `Done` Add Wave 35 plan document
- `Done` Add Wave 35 backlog document
- `Done` Add Wave 35 synthesis document
- `Done` Update the project registry for the new expressive-tracking donors
- `Done` Update overlap families for avatar-facing input bridges
- `Done` Update `not-yet-studied-deeply.md` with the honest follow-up nodes
- `Done` Update the methods catalog with expressive-input methods
- `Done` Update documentation indexes to include Wave 35

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `quest_steamvr_fbt_tool` if a future wave needs a tighter comparison between Quest-native body state and avatar-facing export tools
- `Next` Compare `Baballonia`, `HandshakeVR`, `mercury_steamvr_driver`, and `PSVR2_OpenXR_Eye_Tracking` directly as `platform`, `provider remapper`, `driver with subprocess`, and `vendor-specific gaze layer`
