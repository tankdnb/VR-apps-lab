# GitHub Research Wave 220 Plan

Date: 2026-06-06

Theme: world-locking, spatial coordinate stabilization, and anchor-sharing
bindings.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

XR utilities often fail when the user's tracking origin drifts, resets, or
cannot be shared across sessions and devices. This wave studies projects that
separate raw tracking space from a stabilized world frame and bind that frame
to QR markers, spatial anchors, cloud anchors, or engine-specific camera
hierarchies.

## Search Families

- World-locked coordinate systems.
- Spatial-anchor persistence and cloud binding.
- QR marker to scene alignment.
- Cross-engine anchor-management implementations.
- Minimal anchor save/load UI references.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `microsoft/MixedReality-WorldLockingTools-Unity` | Canonical Unity implementation of spongy/locked/frozen coordinates, anchor graph, alignment pins, and persistence hooks. | World-locking core |
| `microsoft/MixedReality-WorldLockingTools-Samples` | QR Space Pins and Azure Spatial Anchors samples that productize environment binding and sharing. | Marker/cloud binding UX |
| `microsoft/WorldLockingTools-Unreal` | Unreal port showing the same coordinate-stabilization concept through AR pins, FrozenWorld, and pawn hierarchy adjustment. | Cross-engine port |
| `brunoshine/StereoKit.Samples.AzureSpatialAnchors` | Minimal StereoKit ASA demo with explicit session state, locate/save/delete UI, and nearby-anchor search. | Minimal anchor persistence UI |

## Dedupe Notes

Earlier waves covered broad spatial-anchor and colocation samples, but these
projects were not yet represented as a focused world-locking and coordinate
stabilization family. `kojoopuni/azureSpatialAnchorsUnityARFoundationExplorations`
was inspected during search, but the checkout contained no useful source beyond
repository metadata, so it was rejected rather than promoted.

## Code-Level Pass Targets

- Spongy/raw, locked/frozen, adjustment-frame, and camera-parent boundaries.
- Anchor graph creation, linkage, culling, save/load, and refreeze behavior.
- Alignment pins and finite reference-pose interpolation.
- QR marker and ASA binding/publish/search/delete UX.
- Unreal ARPin and pawn hierarchy translation of the same pattern.
- Minimal cloud-anchor session state and feedback loops.

## Expected Outputs

- Wave 220 landscape synthesis.
- Registry/family entries for world-locking and anchor-sharing donors.
- Method catalog entry for world-locked coordinate stabilization with
  marker/cloud-anchor binding.
- Follow-up backlog for a spatial-stability matrix.
