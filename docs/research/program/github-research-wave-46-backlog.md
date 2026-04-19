# GitHub Research Wave 46 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `XR latency measurement`, `recording parsers`, and
  `experiment harnesses`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for motion-to-photon tools, tracking-latency rigs, and XR recording parsers
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans Unity experiment scenes, external hardware rigs, a consumer-grade VRChat methodology, and parser or analyzer stacks for simulator recordings

## Work package B: Local source acquisition

- `Done` Confirm `motion-to-photon-measurement` in local cache
- `Done` Confirm `VRLate` in local cache
- `Done` Confirm `VR-Motion-to-photon-latency-` in local cache
- `Done` Confirm `dreyevr_recording_analyzer` in local cache
- `Done` Confirm `DReyeVR-parser` in local cache
- `Done` Confirm `vrlatency` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect UXF session structure and movement plus color tracking in `motion-to-photon-measurement`
- `Done` Inspect microcontroller, brightness encoding, and serial capture flow in `VRLate`
- `Done` Inspect Udon thresholding and visual state coding in `VR-Motion-to-photon-latency-`
- `Done` Inspect parser-plus-notebook structure in `dreyevr_recording_analyzer`
- `Done` Inspect cacheable standalone parser flow in `DReyeVR-parser`
- `Done` Inspect experiment classes and Arduino integration in `vrlatency`

## Work package D: Repository updates

- `Done` Add Wave 46 plan document
- `Done` Add Wave 46 backlog document
- `Done` Add Wave 46 synthesis document
- `Done` Update the project registry for XR latency and recording-analysis tooling
- `Done` Update overlap families for visual coding rigs, hardware-assisted latency systems, and parser or analyzer stacks
- `Done` Update `not-yet-studied-deeply.md` with honest follow-up nodes
- `Done` Update the methods catalog with latency and parser methods
- `Done` Update documentation indexes to include Wave 46

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare `motion-to-photon-measurement`, `VRLate`, and `vrlatency` directly as `Unity experiment scene`, `external hardware rig`, and `scriptable Python lab`
- `Next` Keep `dreyevr_recording_analyzer` and `DReyeVR-parser` paired whenever a future branch needs `recording parser plus notebook analyzer` references
