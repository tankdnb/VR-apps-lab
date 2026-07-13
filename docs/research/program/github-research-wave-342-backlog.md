# GitHub Research Wave 342 Backlog - Spectator Cameras, Mixed-Reality Capture, and Multiplayer Observer Roles

## Executed Scope

- Searched and deduplicated spectator camera, mixed-reality capture, companion
  capture, and multiplayer observer-role projects.
- Froze a four-project shortlist spanning a minimal Unity spectator sample,
  Microsoft Spectator View, Mixed Reality Companion Kit, and SpatialOS VR
  starter project.
- Read source and documentation statically from local-only cache with LFS
  smudge disabled.
- Extracted two-camera spectator rigs, attachment-point cycling, calibration
  data, camera pose providers, marker/QR alignment, compositor wrappers,
  recording services, asset bundling, remoting/commander tools, and
  headset-player versus flycam-spectator role separation.

## Studied Projects

- `Unity-Technologies/VR-Spectator-Sample`
- `microsoft/MixedReality-SpectatorView`
- `Microsoft/MixedRealityCompanionKit`
- `spatialos/sdk-for-unity-vr-starter-project`

## Backlog Findings

- Keep spectator products layered: simple camera presentation can be useful
  without full MRC calibration.
- Mature MRC stacks need explicit calibration artifacts, coordinate services,
  pose caches, synchronization, recording, and device setup docs.
- Multiplayer observer roles should be modelled separately from player input
  and authority.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include studied projects.
- Method catalog captures spectator/MRC decomposition.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
