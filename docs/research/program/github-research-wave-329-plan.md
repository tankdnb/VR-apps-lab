# GitHub Research Wave 329 Plan - SteamVR Runtime Settings, Recovery, and WMR Patch Microtools

## Goal

Study small SteamVR operational tools that modify runtime availability,
settings, recovery flow, or WMR driver configuration.

## Research Questions

- What is the safe boundary between runtime discovery, config mutation, process
  kill/restart, and user-visible rollback?
- Which microtools are useful as cautionary references for fragile but valuable
  SteamVR maintenance actions?
- How should future VR utilities document destructive or hardcoded assumptions?

## Shortlist

- `demonixis/SteamVREnabler`
- `ZipFile/ovr-update-settings`
- `Raphiiko/Raphiis-SteamVR-Crash-Recovery`
- `Burnt-Delta/ez-wmr`

## Required Checks

- Deduplicate against runtime launch, SteamVR config, performance tuning, and
  hardware/session helper waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, install, or launch any
  found project.
- Capture fragile path/process/config assumptions honestly.

## Expected Outputs

- Landscape synthesis for Wave 329.
- Registry/family entries for studied projects.
- Method catalog entry for reversible SteamVR operation microtools.
