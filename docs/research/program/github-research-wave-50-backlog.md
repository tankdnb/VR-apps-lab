# GitHub Research Wave 50 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `XR-glasses workspace shells`, `OpenVR HMD paths`, and
  `head-tracked screen tools`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for XR-glasses workspace shells, thin OpenVR HMD paths, head-tracking sidecars, and screen-transformation tools
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans Linux workspace shells, stereoscopic screen transformation, direct OpenVR HMD adaptation, and non-XR head-tracking export

## Work package B: Local source acquisition

- `Done` Confirm `breezy-desktop` in local cache
- `Done` Confirm `desktop2stereo` in local cache
- `Done` Confirm `OpenVR-xrealAirGlassesHMD` in local cache
- `Done` Confirm `PhoenixHeadTracker` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect desktop-environment integration, driver IPC, and shell layering in `breezy-desktop`
- `Done` Inspect capture, depth, and stereo output pipeline boundaries in `desktop2stereo`
- `Done` Inspect driver class responsibilities and IMU-backed display behavior in `OpenVR-xrealAirGlassesHMD`
- `Done` Inspect sidecar controls, filters, and export modes in `PhoenixHeadTracker`

## Work package D: Repository updates

- `Done` Add Wave 50 plan document
- `Done` Add Wave 50 backlog document
- `Done` Add Wave 50 synthesis document
- `Done` Update the project registry for XR-glasses shells, OpenVR HMD paths, and head-tracked screen tools
- `Done` Update overlap families for the XR-glasses family
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes
- `Done` Update the methods catalog with shell, screen-pipeline, and glasses-driver methods
- `Done` Update documentation indexes to include Wave 50

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare `breezy-desktop`, `OpenVR-xrealAirGlassesHMD`, and `PhoenixHeadTracker` directly as `workspace shell`, `runtime-facing HMD path`, and `non-XR tracking sidecar`
- `Next` Keep `desktop2stereo` visible whenever a future branch needs `screen transformation` rather than driver-backed display ownership
