# GitHub Research Wave 63 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `specialized effect overlays`, `visibility shaping`, and
  `passthrough cutout surfaces`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for passthrough cutouts, visibility masks, and comfort overlays
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans chroma-key passthrough boxes, an HMD-top black-bar mask, a roll-driven comfort ring, and a narrow static-image effect overlay

## Work package B: Local source acquisition

- `Done` Confirm `OpenMixerXR` in local cache
- `Done` Confirm `SteamVRBlackBarOverlay` in local cache
- `Done` Confirm `VR-Overlay-Half_Ring` in local cache
- `Done` Confirm `OpenVR-Windows-Activation` in local cache
- `Done` Confirm `EmyOverlay` as a surfaced comparison node
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect the multi-box overlay manager, dashboard UI, and controller grab or resize flow in `OpenMixerXR`
- `Done` Inspect the HMD-relative black-bar transform and file-backed texture path in `SteamVRBlackBarOverlay`
- `Done` Inspect the roll-driven overlay logic and simple settings UI in `VR-Overlay-Half_Ring`
- `Done` Inspect the static image plus HMD-relative transform loop in `OpenVR-Windows-Activation`
- `Done` Confirm that `EmyOverlay` remains too thin for mainline promotion in this pass

## Work package D: Repository updates

- `Done` Add Wave 63 plan document
- `Done` Add Wave 63 backlog document
- `Done` Add Wave 63 synthesis document
- `Done` Update the project registry for effect-first and visibility-shaping overlays
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes where needed
- `Done` Update the methods catalog with new visual-effect overlay methods
- `Done` Update documentation indexes to include Wave 63

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `OpenMixerXR` visible whenever a future branch needs `overlay as passthrough cutout manager`
- `Next` Keep `SteamVRBlackBarOverlay` and `VR-Overlay-Half_Ring` visible whenever a future branch needs comfort-oriented visibility shaping
- `Next` Revisit `OpenVR-Windows-Activation` only if a future pass needs a `small static-image effect overlay` lower bound
