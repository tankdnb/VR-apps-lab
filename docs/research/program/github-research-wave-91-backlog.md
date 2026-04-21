# GitHub Research Wave 91 Backlog

- Date: `2026-04-21`
- Scope: next GitHub discovery wave focused on
  `VRChat interaction prefabs`, `utility UI`, and
  `dynamic information-surface tools`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for VRChat keypads, markers, dynamic board carriers, and Udon UI infrastructure
- `Done` Deduplicate the results against the registry
- `Done` Freeze a bounded shortlist spanning access-control prefabs, shared drawing surfaces, dynamic text carriers, and pool-backed UI infrastructure

## Work package B: Local source acquisition

- `Done` Confirm `U-Key` in local cache
- `Done` Confirm `VRCMarker` in local cache
- `Done` Confirm `AvatarImageReader` in local cache
- `Done` Confirm `UdonRecyclingScrollRect` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect access rules, event relays, and remote allow-list loading in `U-Key`
- `Done` Inspect manual sync, local-vs-remote trail handling, and eraser ownership in `VRCMarker`
- `Done` Inspect runtime pedestal decoding and editor encoder split in `AvatarImageReader`
- `Done` Inspect datasource contract, delayed initialization, and pool-backed cell reuse in `UdonRecyclingScrollRect`

## Work package D: Repository updates

- `Done` Add Wave 91 plan document
- `Done` Add Wave 91 backlog document
- `Done` Add Wave 91 synthesis document
- `Done` Update the project registry for VRChat interaction and utility-UI donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with new prefab and utility-UI patterns
- `Done` Update documentation indexes to include Wave 91

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Next` Commit the wave results
- `Next` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `AvatarImageReader` only when a future pass needs deeper migration thinking around post-string-loading dynamic data carriers
- `Next` Revisit `UdonLeaderBoard` when a future pass needs a stronger `board or scoreboard layer over recycled UI cells`
- `Next` Keep `U-Key`, `VRCMarker`, and `UdonRecyclingScrollRect` visible as complementary donors for world utility surfaces
