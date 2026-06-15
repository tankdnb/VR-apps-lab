# GitHub Research Wave 310 Backlog - Game-Specific VR Retrofit Mods, OpenXR/SteamVR Bootstrap, UI Patches, and Comfort Product Lessons

## Executed Scope

- Searched and deduplicated game-specific VR retrofit mods and source-light
  comfort/product references.
- Froze a five-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted D3D11/OpenXR session and swapchain binding, virtual gamepad output,
  Unity OpenXR loader bootstrap, body-specific hand/tool mapping, ordered
  module activation, SteamVR manifest/action maps, virtual keyboard patching,
  world-space canvas conversion, static/interactive UI classification, setup
  discipline, fixed/HMD-relative HUD behavior, recenter gestures, and cutscene
  comfort modes.

## Studied Projects

- `ethanporcaro/BF2VR-Alpha`
- `DrBibop/RoR2VRMod`
- `Raicuparta/nomai-vr`
- `Raicuparta/two-forks-vr`
- `LukeRoss00/gta5-real-mod`

## Backlog Findings

- Build a retrofit matrix covering runtime, render bridge, input output,
  UI conversion, keyboard strategy, recentering, comfort modes, and support
  warnings.
- Compare world-space canvas conversion with earlier overlay/menu/control
  waves.
- Deepen virtual keyboard, input prompt, wrist/watch HUD, and laser-pointer UI
  patterns.
- Treat source-light comfort docs as product references, not code donors.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a game-specific VR retrofit method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
