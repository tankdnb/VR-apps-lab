# GitHub Research Wave 61 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `managed-language overlay starters`, `UIToolkit templates`, and
  `higher-level scaffolds`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for Unity, C#, and managed-language overlay starters
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans a reusable UIToolkit template, a focused content-feeder overlay, a managed Vulkan interop host, and a broader Unity scaffold

## Work package B: Local source acquisition

- `Done` Confirm `uitoko-ovr` in local cache
- `Done` Confirm `BasicOverlay` in local cache
- `Done` Confirm `OpenVR-Overlay` in local cache
- `Done` Confirm `WT-OpenVR-Overlay` in local cache
- `Done` Confirm `zenn-overlay-tutorial` as a surfaced comparison node
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect lifecycle, render-texture ownership, and OpenVR event bridging in `uitoko-ovr`
- `Done` Inspect predicted HMD-relative placement and external metadata refresh in `BasicOverlay`
- `Done` Inspect the managed Vulkan texture path and overlay-event loop in `OpenVR-Overlay`
- `Done` Inspect the Unity-plus-local-webservice shape of `WT-OpenVR-Overlay`
- `Done` Confirm that `zenn-overlay-tutorial` is better treated as a follow-up tutorial node than a mainline donor

## Work package D: Repository updates

- `Done` Add Wave 61 plan document
- `Done` Add Wave 61 backlog document
- `Done` Add Wave 61 synthesis document
- `Done` Update the project registry for managed-language and higher-level overlay scaffolds
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes where needed
- `Done` Update the methods catalog with new starter and UI-bridge methods
- `Done` Update documentation indexes to include Wave 61

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `uitoko-ovr` visible whenever a future branch needs a reusable Unity `UIToolkit` overlay template
- `Next` Keep `OpenVR-Overlay` visible whenever a future branch needs managed-language Vulkan texture interop
- `Next` Revisit `WT-OpenVR-Overlay` only if a future pass needs a sharper comparison between reusable overlay framework pieces and app-specific Unity shell logic
