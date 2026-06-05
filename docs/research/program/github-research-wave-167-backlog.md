# GitHub Research Wave 167 Backlog

- Date: `2026-06-05`
- Theme: `Godot XR toolkits, vendor extensions, templates, and face-tracking bridges`
- Status: `Completed`

## Completed Pass

1. Search Godot XR toolkit, OpenXR vendor extension, template/game shell,
   GDExtension face tracking, and legacy OpenVR toolkit projects.
2. Deduplicate against earlier Godot engine/toolkit and OpenXR vendor coverage.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect Godot XR Tools function nodes, movement providers, pointer/pickup
   and teleport flows, vendor export plugins, extension classes, performance
   metrics sample, dungeon template persistence/HUD/menu scripts, HTC facial
   tracking bridge code, and legacy viewport-to-mesh UI scripts.
5. Promote `GodotVR/godot-xr-tools` and `GodotVR/godot_openxr_vendors` from
   partially studied and add three supporting references.
6. Integrate results into registry, families, methods, not-yet queue, current
   focus, and indexes.

## Promoted Or Clarified Repositories

| Project | Outcome |
|---|---|
| `GodotVR/godot-xr-tools` | Promoted as Godot XR function-node toolkit donor |
| `GodotVR/godot_openxr_vendors` | Promoted as Godot OpenXR vendor extension and export-gate matrix |
| `Malcolmnixon/godot-xr-dungeon-template` | Added as Godot XR product template with persistence, HUD, pause menu, and staging references |
| `beepobb/godot-htc-face-tracking-bridge` | Added as source-driven HTC facial tracking GDExtension bridge caveat |
| `boku-ilen/godot-vr-toolkit` | Added as older Godot OpenVR viewport-to-mesh UI, ray, teleport, and interactable primitive reference |

## Useful Follow-Up Work

- Build a Godot XR toolkit matrix by function node: pointer, pickup, teleport,
  movement, hands, desktop support, user settings, staging, and audio.
- Build a vendor extension matrix across Meta, Pico, Android XR, HTC, Magic
  Leap, Lynx, Khronos, and validation layer features.
- Compare Godot scene-node composition with Unity prefab/toolkit composition
  when designing future reusable VR utility samples.

## Not Pursued In This Wave

- No Godot project, export plugin, GDExtension, OpenXR session, HTC runtime,
  OpenVR runtime, sample game, or Android export was launched.
- No found repository was run, built, installed, imported, or tested.
