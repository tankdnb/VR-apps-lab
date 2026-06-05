# GitHub Research Wave 174 Plan

- Date: `2026-06-05`
- Theme: `Spatial anchors, shared scenes, Magic Leap persistence, and colocation`
- Scope: Unreal Meta spatial-anchor samples, shared anchor and shared scene
  flows, Magic Leap spatial-anchor persistence, anchor storage APIs,
  localization/state managers, and anchor-relative scene reconstruction.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Prior mixed-reality waves touched Quest/Meta anchors and scene APIs, but a more
focused colocation pass is useful for reusable patterns: anchor action menus,
local/cloud persistence, shared scene serialization, Magic Leap localization,
storage bindings, and confidence/status UI.

## Search Families

- Meta Unreal spatial anchors
- shared anchors and shared scene reconstruction
- Magic Leap spatial anchor persistence
- ARFoundation/OpenXR anchor storage
- colocation and anchor-relative scene data

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `oculus-samples/Unreal-SpatialAnchorsSample` | Meta Unreal spatial anchor baseline with Blueprint-first sample structure | Source-light Unreal anchor baseline |
| `oculus-samples/Unreal-SharedAnchorsSample` | Shared anchor flow with local/cloud save states, menus, and LAN session context | Shared-anchor UX donor |
| `oculus-samples/Unreal-SharedSceneSample` | Shared spatial anchor plus Scene API reconstruction and multiplayer scene data | Anchor-relative shared scene donor |
| `magicleap/SpatialAnchorsExample` | Magic Leap 2 anchor manager, localization, persistent content bindings, and space selector | Magic Leap persistence donor |
| `dilmerv/MagicLeapSpatialAnchors` | Compact ARFoundation/OpenXR Storage API lifecycle with status/control panel | Magic Leap anchor storage lifecycle donor |

## Dedupe Notes

- Earlier Meta/MR waves cover Unity Shared Spatial Anchors, Unity Discover,
  Depth API, and related Meta samples. This wave avoids repeating those and
  focuses on Unreal/Magic Leap samples not yet integrated deeply.
- `oculus-samples/Unreal-Discover` looked relevant but was not retained in the
  frozen source-pass scope because the public clone was too heavy for this
  heartbeat pass; it remains a follow-up candidate.
- Blueprint-heavy Unreal samples are retained when they expose meaningful UX,
  state, menu, or scene-sharing patterns.

## Code-Level Pass Targets

- Unreal Blueprint/menu flow from create/select/load/save/share/hide/erase
  anchor states;
- shared scene data model: shared anchor ID, semantic labels, transforms
  relative to anchor, mesh references, multicast reconstruction;
- Magic Leap localization and anchor event managers, background query workers,
  persistent binding storage, and in-app space selectors;
- ARFoundation/OpenXR Storage API publish/query/delete callbacks, control panel
  diagnostics, and anchor confidence/status UI.

## Expected Outputs

- New Wave 174 landscape synthesis.
- Registry/family placement for spatial anchor, colocation, and shared-scene
  persistence samples.
- Methods around stateful anchor menus, anchor-relative scene serialization,
  localization-gated anchor persistence, and anchor storage lifecycle UI.
