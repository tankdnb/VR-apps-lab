# GitHub Research Wave 34 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on `tracked-device geometry`,
  `CAD-to-tracker workflows`, and `auxiliary tracker tooling`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for reverse-engineered tracked devices, tracker-JSON authoring tools, derived trackers, and DIY IMU tracker stacks
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans documentation-heavy reverse engineering, CAD export, synthetic trackers, and full-stack DIY tracker systems
- `Done` Keep `ViveTrackers` as a follow-up comparison node instead of diluting the mainline shortlist

## Work package B: Local source acquisition

- `Done` Confirm `ViveTrackedDevice` in local cache
- `Done` Confirm `Fusion360_SteamVR_Json` in local cache
- `Done` Confirm `augmented-hip` in local cache
- `Done` Confirm `IMU-VR-Full-Body-Tracker` in local cache
- `Done` Confirm comparison metadata for `ViveTrackers`
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect reverse-engineering artifacts and submodule caveats in `ViveTrackedDevice`
- `Done` Inspect CAD-to-SteamVR JSON generation flow in `Fusion360_SteamVR_Json`
- `Done` Inspect derived waist-tracker registration and IK-assisted pose generation in `augmented-hip`
- `Done` Inspect firmware-plus-desktop-plus-driver decomposition in `IMU-VR-Full-Body-Tracker`

## Work package D: Repository updates

- `Done` Add Wave 34 plan document
- `Done` Add Wave 34 backlog document
- `Done` Add Wave 34 synthesis document
- `Done` Update the project registry for the new tracked-device and auxiliary-tracker donors
- `Done` Update overlap families for geometry, CAD, and auxiliary tracker tooling
- `Done` Update `not-yet-studied-deeply.md` with the honest follow-up nodes
- `Done` Update the methods catalog with tracked-device methods
- `Done` Update documentation indexes to include Wave 34

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `ViveTrackedDevice` only if the submodule-backed code or related artifacts become easier to traverse in a deeper hardware-design pass
- `Next` Compare `Fusion360_SteamVR_Json`, `augmented-hip`, and `IMU-VR-Full-Body-Tracker` directly as `authoring tool`, `derived tracker`, and `full-stack DIY tracker ecosystem`
