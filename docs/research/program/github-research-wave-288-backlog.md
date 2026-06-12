# GitHub Research Wave 288 Backlog - MRUK Room-Aware Mixed Reality Scene Data and Panel Placement Utilities

## Executed Scope

- Searched and deduplicated MRUK room-aware utility samples, MRUK demos,
  scene-data exporters, Unreal MRUK samples, and small MR path interactions.
- Froze a five-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted room binding, environment raycasts, world-lock toggles, panel
  placement, wall anchor spawning, QR tracking, room export, model/report
  generation, in-headset export menu, and path-to-checkpoint spawning patterns.

## Studied Projects

- `oculus-samples/Unity-MRUtilityKitSample`
- `dilmerv/MixedRealityUtilityKitDemos`
- `oculus-samples/Unreal-MRUtilityKitSample`
- `VeksCZ/XRHouseDesignExport`
- `Luizfelm/FlightFollower`

## Backlog Findings

- Build an MRUK utility matrix across room loading, anchors, raycasts,
  global-mesh access, panel placement, world-lock, QR tracking, export, and
  diagnostics.
- Deepen `XRHouseDesignExport` around report/model generation, but treat its
  checked-in artifacts as a hygiene caveat.
- Compare Unity and Unreal MRUK patterns once blueprint inspection is feasible.
- Prototype a tiny `VR-apps-lab` MRUK scene doctor concept: permissions,
  current room, anchor inventory, surface raycast, and export status.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a room-aware MR utility method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
