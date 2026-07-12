# GitHub Research Wave 325 Backlog - SteamVR Hardware Provisioning, Session Autolaunch, and Watchman Dongle Utilities

## Executed Scope

- Searched and deduplicated SteamVR autolaunch, dongle flashing, and Watchman
  hardware utility projects.
- Froze a three-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted USB device watcher, tray/manual launch fallback, Steam URI launch,
  single-instance guard, firmware flashing warnings, SteamVR tool reuse,
  default-path fragility, nRF52840/USB-hub Watchman hardware packaging, BOM,
  PCB/case artifacts, and firmware-source caveats.

## Studied Projects

- `The-Graze/PSVR2-SteamVR-AutoLaunch`
- `ykeara/SteamVR-Dongle-Flash`
- `ugokutennp/flowing-dongle-ccd`

## Backlog Findings

- Compare USB-triggered launch helpers with broader runtime operator sidecars.
- For future hardware helpers, require dry-run, device inventory, explicit
  target selection, and rollback/impossibility warnings before destructive
  actions.
- Keep `flowing-dongle-ccd` as hardware/product reference more than code donor.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes the hardware/session microhelper method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
