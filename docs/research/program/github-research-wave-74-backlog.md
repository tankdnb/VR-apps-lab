# GitHub Research Wave 74 Backlog

- Date: `2026-04-20`
- Scope: next GitHub discovery wave focused on
  `OpenVR capture`, `replay`, and
  `orchestration toolchains`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for OpenVR capture, replay, mocap, and orchestration repos
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist that spans a capture-to-replay toolchain, a post-capture helper, an orchestration shell, and a VR-native mocap studio

## Work package B: Local source acquisition

- `Done` Confirm `vr-capture-replay` in local cache
- `Done` Confirm `virtual-camera-offset` in local cache
- `Done` Confirm `VRScout_Agent_Orchestration_Unity_Project` in local cache
- `Done` Confirm `ViRe` in local cache
- `Done` Keep `ovr-motion-capture` as a secondary comparison node only because the public snapshot is too thin
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect tape file flow, replay driver, and helper automation flags in `vr-capture-replay`
- `Done` Inspect tracker-to-camera offset normalization in `virtual-camera-offset`
- `Done` Inspect IPC, inference loop, and virtual-device control in `VRScout_Agent_Orchestration_Unity_Project`
- `Done` Inspect BVH recording, settings UI, and operator control flow in `ViRe`

## Work package D: Repository updates

- `Done` Add Wave 74 plan document
- `Done` Add Wave 74 backlog document
- `Done` Add Wave 74 synthesis document
- `Done` Update the project registry for capture and orchestration donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new record-replay and orchestration patterns
- `Done` Update documentation indexes to include Wave 74

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Keep `vr-capture-replay` visible whenever a future branch needs a stronger `capture-to-tape plus replay-driver` donor
- `Next` Keep `virtual-camera-offset` visible whenever a future branch needs a narrower `post-capture spatial offset normalizer`
- `Next` Keep `VRScout_Agent_Orchestration_Unity_Project` visible whenever `VR-apps-lab` needs a broader `capture plus inference plus virtual-device control` comparison
- `Next` Keep `ViRe` visible whenever a future branch needs a `VR-native recording studio shell`
