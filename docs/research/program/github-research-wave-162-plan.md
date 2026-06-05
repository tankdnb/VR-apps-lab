# GitHub Research Wave 162 Plan

- Date: `2026-06-05`
- Theme: `Resonite creator import/export, inspection, and screenshot utility helpers`
- Scope: Unity-to-Resonite SDK/export workflows, Unity package importers,
  component browser search, and screenshot metadata extensions.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Wave 130 covered Resonite/Neos mod loaders, headless clients, and SDK/social
utility tooling. Wave 162 deepens a different creator-facing branch: tools
that move content into Resonite, inspect its component model, or preserve
world/photo context as reusable metadata.

## Search Families

- Resonite Unity SDK and editor workflows
- Unity-to-Resonite exporters
- Resonite Unity package importers
- Resonite component browser/search utilities
- screenshot metadata and sharing extensions
- creator pipeline helpers for social VR platforms

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `Yellow-Dog-Man/Resonite.UnitySDK` | Official Unity Editor SDK with ResoniteLink, generated bindings, converters, and realtime mode | Resonite creator SDKs |
| `Phylliida/ResoniteUnityExporter` | Unity package, mod, standalone server, shared DTOs, and IPC import processors | Unity-to-Resonite exporters |
| `dfgHiatus/ResoniteUnityPackagesImporter` | ResoniteModLoader mod for importing `.unitypackage` assets, prefabs, scenes, media, and raw files | Unity package importers |
| `BlueCyro/CherryPick` | Component selector search bar with cached worker list and generic type support | In-world/editor inspection QoL mods |
| `hantabaru1014/ResoniteScreenshotExtensions` | Screenshot metadata XMP, restore-on-import, format controls, folders, and Discord webhook integration | Screenshot metadata and sharing utilities |

## Dedupe Notes

- `ResoniteModLoader`, `Resolute`, `ResoniteLink`, and core Resonite modding
  references were already studied in Wave 130.
- This wave is not a repeat of runtime mod-loader research; it focuses on
  creator import/export, inspection, and artifact metadata.

## Code-Level Pass Targets

- generated binding and converter architecture;
- Unity editor window and realtime send workflows;
- shared DTO and IPC processor boundaries;
- asset/material/mesh/prefab/scene import flows;
- package extraction cache and duplicate handling;
- component selector UI patching and search ranking;
- screenshot metadata serialization, restore, and webhook output.

## Expected Outputs

- New Wave 162 landscape synthesis.
- Registry/family updates for Resonite creator workflows.
- Methods around generated data-model bindings, Unity-to-social-VR exporters,
  package import caches, component-search overlays, and screenshot metadata
  preservation.
