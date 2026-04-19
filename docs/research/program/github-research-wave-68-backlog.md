# GitHub Research Wave 68 Backlog

- Date: `2026-04-19`
- Scope: next GitHub discovery wave focused on
  `VirtualMotionTracker adapters`, `OSC action compilers`, and
  `skeletal validation utilities`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for `VMT`, SteamVR OSC exporters, and skeletal-input validation helpers
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans a mature tracker host, thin OSC exporters, a protocol adapter, a skeletal validator, and a config-driven OSC action compiler

## Work package B: Local source acquisition

- `Done` Confirm `VirtualMotionTracker` in local cache
- `Done` Confirm `SteamVR_To_OSC` in local cache
- `Done` Confirm `OpenVR-OSC` in local cache
- `Done` Confirm `VMC2VMT` in local cache
- `Done` Confirm `SkeletonPoseTester` in local cache
- `Done` Confirm `OVR-VRC-OSC-Bridge` in local cache
- `Done` Confirm secondary candidates as comparison nodes only
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect manager, OSC transport, and driver/provider split in `VirtualMotionTracker`
- `Done` Inspect action-manifest and config-mapped OSC export flow in `SteamVR_To_OSC`
- `Done` Inspect minimal pose-bundle export shape in `OpenVR-OSC`
- `Done` Inspect protocol-adapter flow in `VMC2VMT`
- `Done` Inspect skeletal validation shape in `SkeletonPoseTester`
- `Done` Inspect generated action manifest, analog mapping, and rotate-state logic in `OVR-VRC-OSC-Bridge`

## Work package D: Repository updates

- `Done` Add Wave 68 plan document
- `Done` Add Wave 68 backlog document
- `Done` Add Wave 68 synthesis document
- `Done` Update the project registry for new VMT-adjacent donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up nodes changed
- `Done` Update the methods catalog with new VMT and OSC-compiler patterns
- `Done` Update documentation indexes to include Wave 68

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `VirtualMotionTracker` visible whenever a future branch needs a stronger `manager plus driver` virtual-tracker host donor
- `Next` Keep `OVR-VRC-OSC-Bridge` visible whenever `VR-apps-lab` needs a clearer `config-defined input-to-OSC compiler`
- `Next` Keep `VMC2VMT` visible whenever a future branch needs a `protocol adapter feeding an existing tracker host`
- `Next` Revisit `SkeletonPoseTester` only when a later branch needs more explicit skeletal-validation tooling
