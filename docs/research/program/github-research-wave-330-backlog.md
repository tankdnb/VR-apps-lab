# GitHub Research Wave 330 Backlog - SteamVR Device Provisioning, Base-Station Diagnostics, and Visual Asset Patchers

## Executed Scope

- Searched and deduplicated SteamVR dongle, base-station, icon, and render-model
  utilities.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted UF2 generation/flash flow, SteamVR firmware zip discovery,
  disabled flash buttons until prerequisites exist, serial-reader diagnostic
  queues, fault classification, Steam path registry lookup, current-state
  detection, resource copy/restore flows, and update-overwrite caveats.

## Studied Projects

- `jaki-gh/Viva-Dongle-Flasher`
- `TerayTech/SteamVR_BaseStation2.0_Diagnostic_Tool`
- `nicolas-riera/SteamVR-IconsSwitcher`
- `nicolas-riera/SteamVR-RenderModelSwitcher`

## Backlog Findings

- Extend the existing hardware provisioning method with GUI gating and
  resource-patcher caveats.
- Keep render-model and icon switchers as product references, not direct code
  donors, until backup/restore and version handling are stronger.
- Compare base-station serial diagnostics with future tracker inventory and
  hardware doctor ideas.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog captures target identity, disabled actions, backups, and
  firmware/resource provenance.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
