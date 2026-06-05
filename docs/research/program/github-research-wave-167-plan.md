# GitHub Research Wave 167 Plan

- Date: `2026-06-05`
- Theme: `Godot XR toolkits, vendor extensions, templates, and face-tracking bridges`
- Scope: Godot XR Tools function nodes, OpenXR vendor extension stacks, starter
  game/template composition, HTC face-tracking GDExtension bridges, and older
  OpenVR UI/teleport/toolkit primitives.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier Godot waves identified the ecosystem but left key projects partially
studied. Wave 167 deepens the practical toolkit layer: how Godot packages XR
functions as scene nodes, how vendor extensions are exposed and export-gated,
and how small GDExtension or older OpenVR toolkits reveal reusable patterns.

## Search Families

- Godot XR toolkits and scene packs
- Godot OpenXR vendor extension packages
- Godot XR templates and sample games
- Godot GDExtension face tracking bridges
- older Godot OpenVR UI, teleport, and interaction nodes

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `GodotVR/godot-xr-tools` | Modular XR functions for movement, pointer, pickup, teleport, hands, settings, desktop support, audio, and staging | Godot XR toolkit donor |
| `GodotVR/godot_openxr_vendors` | GDExtension stack for vendor OpenXR features, export gates, docs, samples, and performance metrics | Godot vendor extension matrix |
| `Malcolmnixon/godot-xr-dungeon-template` | Product template showing XR Tools, vendors, persistence, HUD/pause menu, and game shell composition | Godot XR product template |
| `beepobb/godot-htc-face-tracking-bridge` | Small HTC facial tracking GDExtension bridge into Godot `XRFaceTracker` | Face-tracking bridge reference |
| `boku-ilen/godot-vr-toolkit` | Older OpenVR/Godot toolkit with viewport-to-mesh UI, ray interaction, teleport, and interactables | Legacy toolkit primitive reference |

## Dedupe Notes

- `GodotVR/godot-xr-tools` and `GodotVR/godot_openxr_vendors` were already
  tracked as partially studied and are promoted by this pass.
- `GodotVR/godot-xr-template` was already studied and remains comparison
  context, not part of the frozen shortlist.
- `beepobb/godot-htc-face-tracking-bridge` has a template README; source files
  drive its value, so it is documented with caveats.

## Code-Level Pass Targets

- XR Tools function-node exports, configuration warnings, movement provider
  contracts, pointer events, pickup/ranged grab, and teleport flow;
- vendor extension class/doc surface, export feature gates, Android package
  toggles, composition layers, and performance metrics sample;
- template-level persistence, staging, HUD/pause menu, and interaction shell;
- HTC facial tracking request, session, process, expression mapping, and
  `XRFaceTracker` registration;
- legacy Godot OpenVR viewport-to-mesh UI, ray pointer, teleport, and
  interactable base classes.

## Expected Outputs

- New Wave 167 landscape synthesis.
- Registry and family updates for Godot XR toolkits/vendor extension stacks.
- Methods around function-node toolkits, vendor extension/export gates,
  template game shells, face-tracking GDExtension bridges, and legacy
  viewport-to-mesh UI primitives.
