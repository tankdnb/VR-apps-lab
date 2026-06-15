# GitHub Research Wave 310 Plan - Game-Specific VR Retrofit Mods, OpenXR/SteamVR Bootstrap, UI Patches, and Comfort Product Lessons

## Goal

Study game-specific VR retrofit mods as reusable references for runtime
bootstrap, graphics/session bridges, input remapping, world-space UI
conversion, virtual keyboards, comfort modes, compatibility gates, and
user-facing setup guidance.

## Research Questions

- How do retrofit projects separate runtime startup, render bridge, input
  remapping, UI conversion, and game-specific patches?
- Which UI migration patterns are reusable for non-game VR utilities?
- How do virtual keyboards, action maps, and input prompt replacements work in
  mature mods?
- Which comfort/setup/support lessons should inform future VR utility product
  design?

## Shortlist

- `ethanporcaro/BF2VR-Alpha`
- `DrBibop/RoR2VRMod`
- `Raicuparta/nomai-vr`
- `Raicuparta/two-forks-vr`
- `LukeRoss00/gta5-real-mod`

## Required Checks

- Deduplicate against earlier UEVR, REFramework, Rai Pal, overlay, menu, and
  virtual keyboard waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep process-injection, licensing, binary-mod, game-specific API, and support
  caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 310.
- Registry/family entries for VR retrofit mod architecture and product lessons.
- Method catalog entry for game-specific VR retrofit boundaries.
- Follow-up gaps for UI conversion, input mapping, comfort modes, and support
  docs.
