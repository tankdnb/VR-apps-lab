# GitHub Research Wave 223 Backlog

Date: 2026-06-06

Theme: XR creator/CAD/UI workbenches and legacy Unity interaction donors.

## Completed In This Wave

- Studied `kwahoo2/freecad-xr-workbench` as a modern Python OpenXR FreeCAD
  addon with addon-over-fork philosophy, pyopenxr/OpenGL integration,
  Free/Arch movement, teleport, controller menus, line/cube builder, selection,
  dragging, working planes, Qt widget projection, and tracked third-person
  camera support.
- Studied `createthis/createthis_vr_ui` as a legacy but source-rich Unity VR
  UI toolkit with panel factories, panel manager, grabbable panels, keyboard
  state, file open/save dialogs, kinetic scroller, selectable/highlight
  materials, touchpad radial menu, and editor generation helpers.
- Studied `createthis/mesh_maker_vr` as a VR mesh authoring tool with
  vertex/triangle controllers, selection broadcasting, snap and rotation
  increments, mode transitions, fill/normal/delete operations, color feedback,
  HUD outline updates, and persistence/settings.
- Studied `createthis/unity_vr_ik_mecanim` as a small avatar/embodied feedback
  reference with controller-hand IK, hip tracker body placement, headset
  rotation, mirror render texture, translucent controller materials, and
  explicit Mecanim limitations.
- Added a reusable method entry for creator workbench interaction shells.

## Follow-Up Queue

1. Build an in-VR creator UI matrix: controller menu, wrist menu, touchpad menu,
   panels, file dialog, keyboard, color picker, working plane, and command
   mode.
2. Compare FreeCAD XR's release-to-select menu with Createthis touchpad radial
   menu and previous VRChat/Udon menu waves.
3. Extract a CAD/authoring "interaction primitives" note: ray picking,
   snapping, selected-object state, working plane, drag handles, and undo.
4. Revisit modern Unity XR Interaction Toolkit equivalents for panels and
   authoring widgets before promoting any legacy Unity code as implementation
   baseline.
5. Compare mirror/IK/avatar feedback with stream-facing and mixed-reality
   capture waves if embodied feedback becomes active scope.

## Do Not Spend Time On Yet

- Do not import or run Unity projects, FreeCAD addons, or SteamVR scenes.
- Do not treat old Unity 5.6 dependencies as recommended.
- Do not copy third-party asset-store dependent code into `VR-apps-lab`.
