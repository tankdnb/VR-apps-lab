# GitHub Research Wave 33 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on `alternative OpenXR runtimes`,
  `special-display paths`, and `platform experiments outside the ordinary
  headset runtime model`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for special-display runtimes, embedded OpenXR frameworks, and nonstandard platform experiments
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans installable runtimes, embedded frameworks, and server-backed proof-of-concept stacks
- `Done` Keep `openxr-3d-display` and `OpenDisplayXR` as secondary follow-up nodes instead of overloading the mainline shortlist

## Work package B: Local source acquisition

- `Done` Confirm `displayxr-runtime` in local cache
- `Done` Confirm `XRGameBridge` in local cache
- `Done` Confirm `OpenXRKit` in local cache
- `Done` Confirm `FruitXR` in local cache
- `Done` Confirm comparison metadata for `openxr-3d-display` and `OpenDisplayXR`
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect runtime layering and separation-of-concerns rules in `displayxr-runtime`
- `Done` Inspect runtime bootstrap, system enumeration, and graphics-backend split in `XRGameBridge`
- `Done` Inspect embedded Apple runtime structure in `OpenXRKit`
- `Done` Inspect the runtime-server split and local IPC model in `FruitXR`

## Work package D: Repository updates

- `Done` Add Wave 33 plan document
- `Done` Add Wave 33 backlog document
- `Done` Add Wave 33 synthesis document
- `Done` Update the project registry for the new alternative-runtime donors
- `Done` Update overlap families for special-display and platform-experiment runtime paths
- `Done` Update `not-yet-studied-deeply.md` with the honest follow-up nodes
- `Done` Update the methods catalog with runtime-architecture methods
- `Done` Update documentation indexes to include Wave 33

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `openxr-3d-display` and `OpenDisplayXR` if a future pass needs a narrower Monado-derived comparison branch for spatial displays
- `Next` Compare `displayxr-runtime`, `OpenXRKit`, and `FruitXR` directly as `clean layered runtime`, `embedded framework runtime`, and `server-backed platform experiment`
