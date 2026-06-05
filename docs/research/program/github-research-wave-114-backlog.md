# GitHub Research Wave 114 Backlog

- Date: `2026-06-05`
- Scope: next GitHub discovery wave focused on Meta Quest MR camera, depth,
  spatial-anchor, presence-style app, and motif sample repositories.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for Quest passthrough camera, depth API, shared spatial
  anchors, Discover-style full apps, and MR motif repositories
- `Done` Deduplicate surfaced repositories against registry and families
- `Done` Freeze a bounded shortlist spanning camera, depth, anchors, app
  composition, and reusable MR motifs

## Work package B: Local source acquisition

- `Done` Confirm `Unity-PassthroughCameraApiSamples` in local cache
- `Done` Confirm `Unity-DepthAPI` in local cache
- `Done` Confirm `Unity-SharedSpatialAnchors` in local cache
- `Done` Confirm `Unity-Discover` in local cache
- `Done` Confirm `Unity-MRMotifs` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect Passthrough Camera API samples, camera access permission,
  camera-to-world rays, brightness estimation, object detection, Sentis
  inference manager, and anchor-backed detection markers
- `Done` Inspect Depth API package, BiRP/URP split, environment depth manager
  usage, occlusion cutout, depth bias utility, hand removal, and depth mask
  samples
- `Done` Inspect Shared Spatial Anchors loader, Photon anchor publishing,
  colocation advertisement/discovery, group UUIDs, anchor binding, and
  world-origin alignment helpers
- `Done` Inspect Unity Discover docs and project structure as full MR app
  composition reference
- `Done` Inspect MR Motifs passthrough fader/dissolver/slider, colocated space
  sharing manager, MRUK room sharing, shared activities, and instant placement
  themes

## Work package D: Repository updates

- `Done` Add Wave 114 plan document
- `Done` Add Wave 114 backlog document
- `Done` Add Wave 114 synthesis document
- `Done` Update the project registry for Quest MR sample donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with camera, depth, shared-anchor, and MR
  motif methods
- `Done` Update documentation indexes to include Wave 114

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Synthesize a camera-depth-anchor utility plan if MR diagnostics become
  active scope
- `Next` Compare MR Motifs with Unity Discover when designing product-level MR
  helper app structure
- `Next` Keep Quest OS, Unity, MRUK, permission, and hardware requirements
  explicit in any reuse plan
