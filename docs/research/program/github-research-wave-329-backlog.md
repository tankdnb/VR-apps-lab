# GitHub Research Wave 329 Backlog - SteamVR Runtime Settings, Recovery, and WMR Patch Microtools

## Executed Scope

- Searched and deduplicated SteamVR runtime/config/recovery microtools.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted runtime path discovery from `openvrpaths.vrpath`, process kill
  lists, OpenVR `IVRSettings` CLI operations, VRChat log world relaunch,
  SteamVR URI/runtime relaunch, WMR `default.vrsettings` patching, and config
  persistence caveats.

## Studied Projects

- `demonixis/SteamVREnabler`
- `ZipFile/ovr-update-settings`
- `Raphiiko/Raphiis-SteamVR-Crash-Recovery`
- `Burnt-Delta/ez-wmr`

## Backlog Findings

- Use `ovr-update-settings` as the cleanest low-level settings boundary.
- Use `SteamVREnabler`, `Crash-Recovery`, and `ez-wmr` mainly as cautionary
  microtool references because they mutate folders, kill processes, parse logs,
  or patch config files directly.
- Future prototypes should add dry-run, backups, target previews, and explicit
  restore paths before copying this family.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog captures config mutation and recovery safety boundaries.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
