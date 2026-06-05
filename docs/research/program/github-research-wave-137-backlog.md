# GitHub Research Wave 137 Backlog

- Date: `2026-06-05`
- Scope: VR creative authoring tools, painting/modeling apps, brush/menu
  systems, command histories, exports, and browser-native authoring surfaces.

## Completed in this wave

- Studied `googlevr/tilt-brush` as a mature archived Unity VR creative app
  with app-state lifecycle, brush/environment catalogs, pointer/controller
  systems, panels, sketch save/load, export, tutorial, and command surfaces.
- Studied `icosa-foundation/open-brush` as the active Tilt Brush evolution
  with modern XR/OpenXR direction, Lua/API surfaces, Photon multiplayer, and
  external automation hooks.
- Studied `googlevr/blocks` as a Unity VR modeling app with command/proto edit
  history, mesh property changes, grouping, copy/delete/move operations, and
  OBJ/FBX/glTF/export service flows.
- Studied `SideQuestVR/SideSketch` as a Tilt Brush fork/variant with rebrand
  and distribution/platform lessons but limited unique architecture beyond the
  upstream lineage.
- Studied `zach-capalbo/vartiste` as a WebXR/A-Frame creative app with
  componentized shelves, brush packs, user brushes, upload/interceptor flows,
  and avatar/spectator/Hubs integration references.

## Reuse candidates

- `open-brush` is the strongest modern creative-tool donor because it extends
  Tilt Brush with APIs and multiplayer.
- `tilt-brush` remains the canonical large Unity architecture reference.
- `blocks` is the strongest command/export donor.
- `vartiste` is the strongest browser-native shelf/tool component donor.
- `SideSketch` should stay a fork/variant comparison node.

## Follow-up backlog

1. Extract a VR tool/menu/shelf comparison matrix across Tilt Brush, Open
   Brush, Blocks, Vartiste, A-Painter, and A-Frame hand UI projects.
2. Build a reusable creative-tool anatomy: app state, catalogs, tools, panels,
   commands, save/load, export, and external automation.
3. Compare Unity panel managers with WebXR component shelves.
4. Revisit Open Brush APIs if external automation or scripting becomes an
   active prototype branch.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
