# GitHub Research Wave 174 Backlog

- Date: `2026-06-05`
- Theme: `Spatial anchors, shared scenes, Magic Leap persistence, and colocation`
- Status: `Completed`

## Completed Pass

1. Search spatial-anchor, shared-anchor, shared-scene, Magic Leap, and anchor
   storage families.
2. Deduplicate against prior Quest/MR Unity sample coverage.
3. Freeze a bounded shortlist around Unreal Meta anchors and Magic Leap
   persistence/storage samples.
4. Sync shortlisted sources into local-only cache for static reading.
5. Inspect README flows, Blueprint/C++ support code where present, menu
   components, anchor save/share/erase states, shared scene serialization,
   Magic Leap localization/query events, local binding storage, and ARFoundation
   storage callbacks.
6. Mark Blueprint-heavy or source-light projects honestly rather than
   overstating donor value.
7. Integrate results into registry, families, methods, current focus,
   not-yet, and indexes.

## Studied Repositories

| Project | Outcome |
|---|---|
| `oculus-samples/Unreal-SpatialAnchorsSample` | Added as source-light Meta Unreal spatial anchor baseline |
| `oculus-samples/Unreal-SharedAnchorsSample` | Added as shared-anchor menu, persistence, and cloud/local state UX reference |
| `oculus-samples/Unreal-SharedSceneSample` | Added as anchor-relative shared scene serialization and reconstruction donor |
| `magicleap/SpatialAnchorsExample` | Added as Magic Leap localization-gated anchor manager and persistent binding donor |
| `dilmerv/MagicLeapSpatialAnchors` | Added as ARFoundation/OpenXR Storage API lifecycle and status UI donor |

## Useful Follow-Up Work

- Build a spatial-anchor persistence matrix across Meta Unity, Meta Unreal,
  Magic Leap, ARFoundation, local save files, cloud save, and shared anchors.
- Revisit `oculus-samples/Unreal-Discover` with sparse/LFS-aware source
  handling if MR app-level motif coverage becomes a priority.
- Extract a generic anchor action menu pattern: create, select, save local,
  save cloud, load, share, orient, hide, erase, and status.
- Compare anchor-relative scene serialization with earlier marker-tracking and
  calibration families.

## Not Pursued In This Wave

- No Unreal project, Unity project, Magic Leap sample, headset, anchor service,
  cloud anchor flow, or scene capture flow was launched.
- No found repository was run, built, installed, imported, or tested.
