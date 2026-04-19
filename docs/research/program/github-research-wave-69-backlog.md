# GitHub Research Wave 69 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `OpenXR platform shells`, `layer managers`, and
  `runtime inspection workbenches`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for OpenXR platform shells, layer managers, and runtime inspectors
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans a broad plugin platform, a split desktop shell plus API layer stack, a runtime explorer, and a lint-and-fix layer manager

## Work package B: Local source acquisition

- `Done` Confirm `vrkit-platform` in local cache
- `Done` Confirm `clearxr-server` in local cache
- `Done` Confirm `openxr-explorer` in local cache
- `Done` Confirm `OpenXR-API-Layers-GUI` in local cache
- `Done` Keep template repos as secondary comparison nodes only
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect plugin manifests, service daemon flow, and OpenXR demo slices in `vrkit-platform`
- `Done` Inspect session management, API-layer interception, and landing-space split in `clearxr-server`
- `Done` Inspect runtime enumeration and shared GUI/CLI data model in `openxr-explorer`
- `Done` Inspect loader snapshots, linting, and fix-up flows in `OpenXR-API-Layers-GUI`

## Work package D: Repository updates

- `Done` Add Wave 69 plan document
- `Done` Add Wave 69 backlog document
- `Done` Add Wave 69 synthesis document
- `Done` Update the project registry for the OpenXR platform-shell donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up nodes changed
- `Done` Update the methods catalog with new OpenXR platform and inspection patterns
- `Done` Update documentation indexes to include Wave 69

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `vrkit-platform` visible whenever a future branch needs a stronger `plugin-manifest runtime or overlay platform` donor
- `Next` Keep `clearxr-server` visible whenever `VR-apps-lab` needs a cleaner `desktop shell plus API layer plus XR landing app` split
- `Next` Keep `openxr-explorer` visible whenever a future branch needs a `shared GUI plus CLI inspector` reference
- `Next` Keep `OpenXR-API-Layers-GUI` visible whenever a later branch needs a `lint-and-fix layer manager`
