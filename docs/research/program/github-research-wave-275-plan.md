# GitHub Research Wave 275 Plan - VR Launchers, Startup Orchestration, and App-Library Surfaces

## Goal

Study VR launchers, startup orchestrators, shell shortcuts, app-library
surfaces, and external-app handoff patterns across Quest, Windows/WMR, SteamVR,
Unity, Python CLI, and VRChat tooling.

## Research Questions

- Which launch channels are used: Android intents, `systemux://`, Steam URI,
  UWP URI launch, native process, Flatpak, script, or web URL?
- How do projects model app metadata, config variants, profile steps, and
  rollback?
- How do VR launchers hide/show menus and return after external apps exit?
- Which repos are donor-worthy versus fork, deprecated, or micro-utility
  references?

## Shortlist

- `ptrpaws/vrLauncher`
- `conexto/vrLauncher`
- `blakeblair/uvrl`
- `marianhlavac/immersion-vr-agent`
- `dewaffled/vr-launcher`
- `Paladinleeds/PaladinVR-Launcher`
- `keithbphillips/vr-pinball-launcher`
- `CactusVRStudios/Lambda1VR_Launcher`
- `Bluscream/VRChatLauncher`

## Required Checks

- Deduplicate against SteamVR operational support, command surfaces, Quest
  helper, and VRChat companion waves.
- Clone only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields and reusable pattern bridge fields.
- Update registry, families, methods, not-yet-studied, and indexes.

## Expected Outputs

- Landscape synthesis for Wave 275.
- Registry/family entries for launchers and startup orchestration surfaces.
- Method catalog entry for launch-profile and app-library boundaries.
- Follow-up gaps around launch channels, rollback, app profiles, process
  lifecycle, and safety gates.
