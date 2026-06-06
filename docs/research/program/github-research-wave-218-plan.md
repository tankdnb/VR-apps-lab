# GitHub Research Wave 218 Plan

Date: 2026-06-06

Theme: VRChat/Udon runtime diagnostics, data structures, and predictive sync
utilities.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

VRChat/Udon utilities often become reusable not through one flashy prefab, but
through foundations: lifecycle helpers, logging, network time, profiling,
data-structure workarounds, serialized events, prediction, and in-world tuning.

Wave 218 studies a TLP/Guribo cluster to extract Udon runtime substrate
patterns and caveats.

## Search Families

- Udon runtime helper frameworks.
- Udon profiling overlays and diagnostics.
- Udon data structures and list/tree workarounds.
- Predictive sync and physics state replication.
- In-world tuning and debugging surfaces.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `Guribo/UdonUtils` | Base scripts/tools for TLP packages: lifecycle base class, logging, network time, sync helpers, events, factories, physics helpers, recording, task scheduler, and tests. | Udon utility substrate |
| `Guribo/UdonProfiling` | Screen-space Udon performance overlay with global profiler handler and MVC-ish performance stat UI. | Udon diagnostics overlay |
| `Guribo/UdonLeaderBoard` | Package reference for leaderboard lineage, but current checkout contains only package placeholder and README. | Product/package reference |
| `Guribo/UdonAVLTree` | U# AVL tree implementation using `DataList` nodes and wire-like in-order links. | Udon data-structure workaround |
| `Guribo/UdonVehicleSync` | Predictive smooth synchronization for non-kinematic rigidbodies with dynamic send rate and in-world sync tweaking. | Predictive sync utility |

## Dedupe Notes

`Guribo/UdonUtils` was partially studied in earlier Udon helper waves and is
deepened here for runtime substrate boundaries. `UdonLeaderBoard` was already
queued as not-studied deeply; this wave records it honestly as package/product
reference only because the current source checkout contains no substantive
runtime files beyond placeholder/package metadata.

## Code-Level Pass Targets

- TLP base lifecycle, logging, serialization retry, and sync pause/dirty flow.
- Accurate sync behavior, network time, prediction reduction, and snapshot
  hooks.
- Profiling overlay model/controller/handler and frame-time accumulation.
- DataList-backed AVL node representation and tree balancing.
- Vehicle sync sender/receiver split, dynamic send rate, rigidbody prediction,
  teleport/respawn, and tweak UI.
- Package caveats and missing-source limitations.

## Expected Outputs

- Wave 218 landscape synthesis.
- Registry/family entries for Udon runtime diagnostics and sync foundations.
- Method catalog entry for an Udon runtime utility substrate.
- Follow-up backlog for Udon data/sync/profiling matrices.
