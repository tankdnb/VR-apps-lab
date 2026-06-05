# GitHub Research Wave 106 Backlog

- Date: `2026-06-05`
- Scope: next GitHub discovery wave focused on
  `VRCFaceTracking`, `tracking modules`, `cross-platform face-tracking shells`,
  and `blendshape preparation`.

## Status legend

- `Done`
- `Next`

## Work package A: Search and shortlist

- `Done` Search GitHub for VRCFaceTracking core, module, provider, and
  blendshape-preparation repositories
- `Done` Deduplicate surfaced repositories against registry and families
- `Done` Freeze a bounded shortlist spanning core, cross-platform shell,
  Project Babble module, MeowFace module, and Blender shape-key helper

## Work package B: Local source acquisition

- `Done` Confirm `VRCFaceTracking` in local cache
- `Done` Confirm `VRCFaceTracking.Avalonia` in local cache
- `Done` Confirm `VRCFT-Babble` in local cache
- `Done` Confirm `VRCFaceTracking-MeowFace` in local cache
- `Done` Confirm `VRCFaceTracking-blender-plugin` in local cache
- `Done` Verify that local source cache remains outside git tracking

## Work package C: Code-level deep pass

- `Done` Inspect VRCFaceTracking SDK lifecycle, unified tracking data model,
  parameter sender loop, OSC output, and sandboxed module-process IPC
- `Done` Inspect VRCFaceTracking.Avalonia cross-platform shell, module
  compatibility matrix, registry service, rating/download metadata, legacy
  module migration, and drag/drop overlay control
- `Done` Inspect VRCFT-Babble local OSC receiver, address-to-expression mapping,
  scaling rules, and module update flow
- `Done` Inspect VRCFaceTracking-MeowFace UDP JSON receive loop, local IP
  discovery, MeowFace blendshape JSON converter, and eye/expression mapping
- `Done` Inspect VRCFaceTracking-blender-plugin predefined VRCFT label list,
  shape-key selection UI, duplicate handling, and create/overwrite operator

## Work package D: Repository updates

- `Done` Add Wave 106 plan document
- `Done` Add Wave 106 backlog document
- `Done` Add Wave 106 synthesis document
- `Done` Update the project registry for face-tracking core, modules, and
  blendshape-preparation donors
- `Done` Update relevant overlap families
- `Done` Update `not-yet-studied-deeply.md` where follow-up themes changed
- `Done` Update the methods catalog with face-tracking module, registry,
  provider mapping, and DCC authoring methods
- `Done` Update documentation indexes to include Wave 106

## Work package E: Verification and publish

- `Done` Verify local source cache is still ignored
- `Done` Review git status and documentation integrity
- `Done` Verify the new wave is linked from the documentation indexes
- `Done` Commit the wave results
- `Done` Push the updated research base to GitHub

## Follow-up candidates after this wave

- `Next` Revisit `VRCFaceTracking`
  for a deeper module registry, OSCQuery, mutator, and sandbox packet pass
- `Next` Compare `VRCFT-Babble` and `VRCFaceTracking-MeowFace` against more
  hardware modules when a future pass needs a provider-module matrix
- `Next` Use `VRCFaceTracking-blender-plugin` as a seed for avatar authoring
  pipeline and shape-key preparation research
