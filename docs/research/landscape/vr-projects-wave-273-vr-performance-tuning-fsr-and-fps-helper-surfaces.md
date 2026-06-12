# Wave 273 - VR Performance Tuning, FSR, and FPS Helper Surfaces

This wave studies VR performance helper projects around OpenVR FSR/VRPerfKit
installation, runtime extraction, configuration schemas, and FPS/comfort
baselines.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- mod-manager surfaces for OpenVR FSR, foveated rendering, and VRPerfKit;
- DLL backup/restore and config writing patterns;
- runtime loader/extraction wrappers;
- binary-only tuning variants;
- engine-side FPS/comfort starter baselines.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `tappi287/openvr_fsr_app` | VR performance mod manager | Studied with caveats | Steam-library scan, DLL install/uninstall, config-schema UI |
| `LavaGang/ML_OpenVR_FSR` | Runtime mod loader wrapper | Studied with caveats | Extract/load OpenVR FSR without replacing game files |
| `komori/vrperfkit-ocq2` | Binary/config-only tuning variant | Source-light/binary-only | Quality-focused VRPerfKit config reference only |
| `GodotVR/godot_openvr_fps` | FPS/comfort starter baseline | Studied with caveats | 90Hz setup, movement vignette, viewport UI, interaction state |

## Code-Level Findings

### `tappi287/openvr_fsr_app`

- Interesting idea:
  a GUI mod manager that discovers VR games, installs performance DLL mods,
  edits settings, and restores originals.
- Code donor value:
  strong for manager boundaries: Steam app/library scanning, custom app
  manifests, cached selected DLL paths, source mod directory selection,
  install/uninstall toggles, original DLL rename to `.orig`, config write,
  reset settings, launch through Steam URI, and Vue components for searchable
  app tables and schema-driven settings.
- Product reference value:
  excellent reference for performance-tuning companion tools that must expose
  compatibility warnings and rollback.
- What to inspect next:
  modern mod compatibility, admin/elevation boundaries, signed file integrity,
  per-game allowlists, and safer UX around destructive replacement.
- Caveats:
  modifies game DLLs, is Windows-centric, includes PowerShell/admin helpers,
  pins older mod versions, and explicitly does not know game compatibility.

### `LavaGang/ML_OpenVR_FSR`

- Interesting idea:
  load the OpenVR FSR mod at runtime via MelonLoader instead of replacing a
  game's OpenVR DLL on disk.
- Code donor value:
  useful loader-wrapper pattern: `OnApplicationEarlyStart`, user-data folder
  creation, old log deletion, default cfg creation, embedded `openvr_api.dll`
  extraction, resource refresh, and `NativeLibrary.Load` before OpenVR starts.
- Product reference value:
  good alternative to file replacement for modded Unity/MelonLoader games.
- What to inspect next:
  compatibility with current runtimes, binary provenance, config migration, and
  per-title disable/rollback UX.
- Caveats:
  bundled binary resource, Windows x64, MelonLoader-specific host boundary, and
  no broad compatibility model.

### `komori/vrperfkit-ocq2`

- Interesting idea:
  a "quality tweaked" VRPerfKit package variant for a specific use case.
- Code donor value:
  none as source donor in the inspected branch; it contains binary DLLs and
  config.
- Product reference value:
  useful as a reminder that users share tuned config bundles, not just tools.
- What to inspect next:
  diff against upstream VRPerfKit config and whether the quality claims map to
  documented settings.
- Caveats:
  binary-only; do not copy DLLs or treat it as implementation evidence.

### `GodotVR/godot_openvr_fps`

- Interesting idea:
  a finished Godot OpenVR FPS tutorial that encodes performance and comfort
  assumptions for a playable VR baseline.
- Code donor value:
  useful adjacent baseline: OpenVR interface discovery/init, `arvr` viewport,
  HDR/vsync/90Hz physics settings, movement vignette rendered at runtime target
  size, viewport-to-material 3D UI, controller state tracking, teleport and
  artificial movement, grab/throw logic, and WMR button-index notes.
- Product reference value:
  good reference for "performance helper needs a comfort baseline" when
  tuning affects locomotion and frame cadence.
- What to inspect next:
  Godot 4/OpenXR migration, input binding modernization, and metrics overlay
  hooks.
- Caveats:
  tutorial/game rather than utility, Godot 3/OpenVR era, and controller
  indices are partly hardcoded.

## Cross-Project Synthesis

The reusable performance-tuning boundary is:

1. discover a target app;
2. classify the launch/runtime path;
3. verify selected files and versions;
4. create a backup before modification;
5. write settings from an explicit schema;
6. expose compatibility as unknown unless proven;
7. support uninstall/restore;
8. keep comfort/FPS baselines visible when tuning changes render behavior.

`openvr_fsr_app` is the strongest product reference for a manager UI.
`ML_OpenVR_FSR` is the strongest loader-boundary variant. `vrperfkit-ocq2`
should stay a config/binary caution node. `godot_openvr_fps` is not a mod
manager, but it grounds performance tuning in runtime frame cadence and comfort.

## Method/Catalog Actions

- Add a method for VR performance tuning managers across discovery,
  backup/restore, config schemas, runtime loading, and comfort baselines.
- Add a follow-up matrix for DLL replacement versus runtime extraction.
- Mark binary-only variants as reference-only unless source evidence exists.

## Follow-Up Backlog

- Compare performance-manager safety UX across DLL replacement, API layers,
  runtime injection, and config-only helpers.
- Extract a reusable config-schema model with setting ranges, categories,
  descriptions, and hotkey capture.
- Define compatibility evidence levels: unknown, manually reported, verified,
  known broken, or deprecated.
