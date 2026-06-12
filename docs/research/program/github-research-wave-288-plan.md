# GitHub Research Wave 288 Plan - MRUK Room-Aware Mixed Reality Scene Data and Panel Placement Utilities

## Goal

Study MRUK and mixed-reality utility projects as reusable references for
room-aware scene data, semantic anchors, environment raycasts, world-locked
panel placement, room export, and lightweight MR path/waypoint interactions.

## Research Questions

- How do MRUK samples expose room, wall, floor, global mesh, QR, and semantic
  anchor data to utility code?
- Which patterns keep panel placement, world-lock, raycast visualization, and
  manual placement separate?
- How can scanned rooms be exported into JSON, reports, OBJ, GLB, or per-room
  artifacts?
- Which projects are clean donors versus artifact-heavy samples?

## Shortlist

- `oculus-samples/Unity-MRUtilityKitSample`
- `dilmerv/MixedRealityUtilityKitDemos`
- `oculus-samples/Unreal-MRUtilityKitSample`
- `VeksCZ/XRHouseDesignExport`
- `Luizfelm/FlightFollower`

## Required Checks

- Deduplicate against prior passthrough, room scan, Meta MR, and spatial UI
  waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep SDK sample, artifact-heavy export, permission/storage, and Unreal
  blueprint/content caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 288.
- Registry/family entries for MRUK room-aware mixed-reality utilities.
- Method catalog entry for room-aware MR utility boundaries.
- Follow-up gaps around MRUK scene doctors, exporters, and panel-placement
  utility shells.
