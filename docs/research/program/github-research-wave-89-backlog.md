# GitHub Research Wave 89 Backlog

- Date: `2026-04-21`
- Scope: next GitHub discovery wave focused on
  `VRChat world runtime infrastructure`, `voice and networking helpers`, and
  `per-player state systems`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for VRChat world runtime helpers, audio-control packages, and Udon networking tools
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist spanning voice-state control, byte-level transport, moving-platform locomotion, and per-player object anchoring

## Work package B: Local source acquisition

- `Done` Confirm `UdonVoiceUtils` in local cache
- `Done` Confirm `UNet` in local cache
- `Done` Confirm `UdonPlayerPlatformHook` in local cache
- `Done` Confirm `CyanPlayerObjectPool` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect controller, override-list, and configuration-model split in `UdonVoiceUtils`
- `Done` Inspect connection, socket, manager, and event API split in `UNet`
- `Done` Inspect moving-platform hook, menu pause, and velocity inheritance logic in `UdonPlayerPlatformHook`
- `Done` Inspect assignment model, helper API, and editor setup helper in `CyanPlayerObjectPool`

## Work package D: Repository updates

- `Done` Add Wave 89 plan document
- `Done` Add Wave 89 backlog document
- `Done` Add Wave 89 synthesis document
- `Done` Update the project registry for VRChat world-runtime donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new world-runtime patterns
- `Done` Update documentation indexes to include Wave 89

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `UdonLeaderBoard` when a future pass needs more world-side list and scoreboard infrastructure
- `Next` Compare `UdonVoiceUtils` and `AudioManager` more directly as two different world voice-state strategies
- `Next` Keep `UNet` and `CyanPlayerObjectPool` visible as complementary lower-layer donors for future creator-world runtime tools
