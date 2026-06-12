# GitHub Research Wave 275 Backlog - VR Launchers, Startup Orchestration, and App-Library Surfaces

## Executed Scope

- Searched and deduplicated VR launcher, shortcut, profile runner, and
  external-app handoff projects.
- Froze a nine-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted Quest hidden URI launchers, CLI profile orchestration, OpenVR
  background agent loops, WMR device toggles, UWP SteamVR shortcuts, VR
  table-carousels, Quest commandline launchers, and VRChat URI/IPC workbenches.

## Studied Projects

- `ptrpaws/vrLauncher`
- `conexto/vrLauncher`
- `blakeblair/uvrl`
- `marianhlavac/immersion-vr-agent`
- `dewaffled/vr-launcher`
- `Paladinleeds/PaladinVR-Launcher`
- `keithbphillips/vr-pinball-launcher`
- `CactusVRStudios/Lambda1VR_Launcher`
- `Bluscream/VRChatLauncher`

## Backlog Findings

- Build a launcher/startup orchestration matrix across app registry, launch
  channel, config variant, backup/restore, profile step, process wait, runtime
  lifecycle, and return-to-menu behavior.
- Treat `ptrpaws/vrLauncher` and `conexto/vrLauncher` as one variant line
  around hardcoded Quest `systemux://` catalogs.
- Deepen `uvrl` and `vr-pinball-launcher` as the strongest architecture and VR
  handoff donors.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a launcher/startup orchestration method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
