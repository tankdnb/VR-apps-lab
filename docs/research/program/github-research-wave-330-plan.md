# GitHub Research Wave 330 Plan - SteamVR Device Provisioning, Base-Station Diagnostics, and Visual Asset Patchers

## Goal

Study SteamVR hardware-adjacent utilities that flash dongles, diagnose base
stations, or patch device icons/render models.

## Research Questions

- How do device provisioning tools expose target identity and irreversible
  actions?
- What diagnostics patterns appear in serial/base-station log viewers?
- How should visual asset patchers protect SteamVR driver/resource folders?

## Shortlist

- `jaki-gh/Viva-Dongle-Flasher`
- `TerayTech/SteamVR_BaseStation2.0_Diagnostic_Tool`
- `nicolas-riera/SteamVR-IconsSwitcher`
- `nicolas-riera/SteamVR-RenderModelSwitcher`

## Required Checks

- Deduplicate against Watchman dongle, hardware provisioning, tracker, and
  SteamVR resource patch waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, install, or launch any
  found project.
- Separate donor-worthy flow from risky firmware/resource mutation.

## Expected Outputs

- Landscape synthesis for Wave 330.
- Registry/family entries for studied projects.
- Method catalog entry for target-aware provisioning and resource patchers.
