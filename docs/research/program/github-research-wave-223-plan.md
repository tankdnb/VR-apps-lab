# GitHub Research Wave 223 Plan

Date: 2026-06-06

Theme: XR creator/CAD/UI workbenches and legacy Unity interaction donors.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

The repository needs more references for doing real work inside VR: CAD
inspection, controller menus, panel systems, file dialogs, mesh authoring,
selection, snapping, mirrors, and avatar/IK feedback. This wave studies creator
tools and older Unity projects that still contain reusable interaction ideas.

## Search Families

- OpenXR CAD and workbench addons.
- In-headset controller menus and 3D UI panels.
- VR file/keyboard/color picker utilities.
- Mesh authoring and geometry manipulation tools.
- Avatar IK, mirrors, and embodied feedback references.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `kwahoo2/freecad-xr-workbench` | Modern Python OpenXR FreeCAD addon with controller menus, CAD editing, Qt widget projection, movement, and third-person camera. | CAD/XR workbench |
| `createthis/createthis_vr_ui` | Source release of Mesh Maker VR's UI system: panels, buttons, keyboard, file dialogs, factories, kinetic scroller, touchpad menu. | Legacy Unity VR UI toolkit |
| `createthis/mesh_maker_vr` | Open-source development version of a VR mesh authoring tool with vertex/triangle controllers, snapping, selection, modes, and persistence. | VR mesh authoring |
| `createthis/unity_vr_ik_mecanim` | Small SteamVR Mecanim IK/mirror demo with hip tracker, controller hands, translucent controllers, and mirror feedback. | Embodied feedback micro-reference |

## Dedupe Notes

Earlier waves covered VR creative authoring and menu systems, but these
projects were chosen as concrete source donors for menu, CAD, panel, mesh, and
embodied-feedback patterns. The Createthis projects are legacy Unity donors;
their value is interaction structure, not modern dependency adoption.

## Code-Level Pass Targets

- OpenXR FreeCAD addon boundaries and controller menu behavior.
- CAD selection, working plane, line/cube builder, dragging, and Qt widget
  projection.
- Unity VR panel, keyboard, file dialog, scroller, touchpad, and factory
  architecture.
- Mesh editing modes, vertex/triangle controllers, snapping, selection, and
  HUD feedback.
- IK/mirror feedback boundaries and limitations.

## Expected Outputs

- Wave 223 landscape synthesis.
- Registry/family entries for XR creator/CAD/UI workbenches.
- Method catalog entry for creator workbench interaction shells.
- Follow-up backlog for in-VR menu and authoring-surface matrices.
