# GitHub Research Wave 314 Backlog - PSVR2Toolkit Downstream Clients, Gaze Capture, Haptics, and Installer Microtools

## Executed Scope

- Searched and deduplicated PSVR2Toolkit downstream client utilities.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted native gaze-image capture adapters, OSC/WebSocket rumble relays,
  signed-driver validation and rollback flows, GitHub release update checks,
  and game-state-to-trigger-effect IPC patterns.

## Studied Projects

- `BnuuySolutions/PSVR2Toolkit.Baballonia`
- `tabithamoon/PSVR2HeadpatHaptics`
- `MaidScientistIzutsumiMarin/psvr2toolkit-installer`
- `Kingoooooooo/Pistol-Whip-Adaptive-Triggers`

## Backlog Findings

- Build a comparison matrix across PSVR2Toolkit capture, haptics, calibration,
  VRCFT, and runtime-helper clients.
- Deepen installer rollback/failure handling and release-asset assumptions.
- Revisit adaptive-trigger consumers for generic policy layers and stronger
  safety gates.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a PSVR2 toolkit downstream client method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
