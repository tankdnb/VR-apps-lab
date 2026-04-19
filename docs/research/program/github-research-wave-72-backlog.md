# GitHub Research Wave 72 Backlog

- Date: `2026-04-20`
- Scope: next GitHub discovery wave focused on
  `OpenVR overlay access layers`, `starter variants`, and
  `minimal shell experiments`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for OpenVR overlay wrappers, starter repos, and minimal shell variants
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans a focused Rust access layer, a tiny C# dashboard starter, a C++ shell sketch, and a managed desktop-plus-overlay split

## Work package B: Local source acquisition

- `Done` Confirm `ovr_overlay` in local cache
- `Done` Confirm `OpenVROverlayTest` in local cache
- `Done` Confirm `UniversalVROverlay` in local cache
- `Done` Confirm `OpenVR.ALBRT.overlay` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect feature-gated subsystem access and overlay manager design in `ovr_overlay`
- `Done` Inspect lower-bound dashboard overlay bootstrap flow in `OpenVROverlayTest`
- `Done` Inspect `OverlayManager`, `StaticOverlay`, and `WindowOverlay` split in `UniversalVROverlay`
- `Done` Inspect desktop-shell and shared-backend split in `OpenVR.ALBRT.overlay`

## Work package D: Repository updates

- `Done` Add Wave 72 plan document
- `Done` Add Wave 72 backlog document
- `Done` Add Wave 72 synthesis document
- `Done` Update the project registry for overlay access layers and starter variants
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new overlay implementation patterns
- `Done` Update documentation indexes to include Wave 72

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `ovr_overlay` visible whenever a future branch needs a stronger `overlay-focused OpenVR access layer`
- `Next` Keep `OpenVROverlayTest` visible whenever `VR-apps-lab` needs a smaller `dashboard overlay bootstrap`
- `Next` Keep `UniversalVROverlay` visible as a useful `architecture sketch` comparison even though parts of the shell stay unfinished
- `Next` Keep `OpenVR.ALBRT.overlay` visible whenever a future branch needs a cleaner `desktop UI plus shared overlay backend` donor
