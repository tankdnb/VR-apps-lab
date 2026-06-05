# GitHub Research Wave 107 Backlog

- Date: `2026-06-05`
- Scope: next GitHub discovery wave focused on
  `VRChat avatar dynamics`, `PhysBone migration`, `contact/collision prefabs`,
  and `in-game tuning`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for PhysBone migration, in-game tuning, grabbable
  avatar prop, contact tracker, and collision detection repositories
- `Done` Deduplicate surfaced repositories against registry and families
- `Done` Freeze a bounded shortlist spanning editor migration, runtime tuning,
  component grouping, grabbable prop, and collision-state prefab patterns

## Work package B: Local source acquisition

- `Done` Confirm `PhysBone-to-DynamicBone` in local cache
- `Done` Confirm `PhysBonesTK` in local cache
- `Done` Confirm `VRChat_PhysboneDetach` in local cache
- `Done` Confirm `Avatar-Prop` in local cache
- `Done` Confirm `Collision-Detection` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect PhysBone-to-DynamicBone editor window, duplicate-safe
  conversion path, lossless/lossy parameter mapping, collider migration, and
  gravity falloff handling
- `Done` Inspect PhysBonesTK expression menu structure, parameter ranges,
  command parameter, object reactivation reload trick, accessory item
  world-constraint controls, and animator assets
- `Done` Inspect VRChat_PhysboneDetach component copy/grouping, collider
  remapping dictionary, and name-based transfer caveats
- `Done` Inspect Avatar-Prop product framing, Modular Avatar and VRCFury
  install variants, contact tracker parameter surfaces, PhysBone/constraint
  model, and prop grab/drop behavior
- `Done` Inspect Collision-Detection particle/contact/FX bool flow,
  animator parameters, prefab shape, performance budget, and conditional
  Instancer hook

## Work package D: Repository updates

- `Done` Add Wave 107 plan document
- `Done` Add Wave 107 backlog document
- `Done` Add Wave 107 synthesis document
- `Done` Update the project registry for avatar dynamics and contact/collision
  donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with PhysBone migration, in-game tuning,
  component grouping, prop, and collision methods
- `Done` Update documentation indexes to include Wave 107

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Compare `PhysBonesTK` and future in-game tuning prefabs whenever
  avatar-parameter menu design becomes a focus
- `Next` Revisit `Avatar-Prop` and `Collision-Detection` with VRLabs
  `Contact-Tracker` lineage if a future pass needs deeper contact-driven
  interaction maps
- `Next` Use `PhysBone-to-DynamicBone` and `VRChat_PhysboneDetach` as
  comparison nodes for editor-side component migration and grouping tools
