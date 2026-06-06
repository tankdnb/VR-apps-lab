# VR Projects Wave 223: XR Creator/CAD/UI Workbenches and Legacy Unity Interaction Donors

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-223-plan.md`
- `docs/research/program/github-research-wave-223-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

VR utilities are not only overlays and diagnostics. They also need real
interaction systems: menus, panels, file pickers, keyboards, snapping, CAD
selection, mesh editing, mirrors, and embodied feedback. This wave collects
creator-workbench patterns from one modern FreeCAD/OpenXR addon and three
legacy but source-rich Unity projects.

## Project Findings

### `kwahoo2/freecad-xr-workbench`

- Interesting idea: bring XR into FreeCAD as a Python addon instead of a C++
  fork, so movement, menus, modeling tools, and OpenXR rendering can iterate
  without rebuilding FreeCAD.
- Code donor value: very high as a creator-workbench architecture reference.
  `commonXR.py` owns pyopenxr/OpenGL integration, QOpenGLWidget bridge,
  session/swapchain state, movement, controller state, menu, preview, document
  interaction, and Qt widget projection. `controllerXR.py` models controller
  scenegraph, ray visualization, pick actions, picked tails, normals, and
  texture coordinates. `menuCoin.py` implements buttons, sliders, labels,
  radio groups, menu placement, ray selection, and release-to-select behavior.
  `movementXR.py` separates Arch, Free, keyboard, teleport, and floor helpers.
  `qtWidgetRender.py` renders FreeCAD Qt widgets as 3D textured faces.
  `documentInteraction.py` implements line builder, cube builder, selection,
  dragging, active body detection, and placement conversion.
- Product reference value: very high for CAD, inspection, and in-headset
  authoring.
- Architecture pattern: host-app addon plus OpenXR render loop plus scenegraph
  controller/UI nodes plus CAD command adapters.
- Reusable method: keep host-app domain commands separate from XR input and
  3D menu presentation.
- Constraints and caveats: FreeCAD/Python/Pivy/Coin3D specific, pyopenxr and
  OpenGL runtime requirements, platform windowing differences, and CAD-specific
  assumptions.
- What to inspect next: reload scenegraph flow, preferences, third-person
  camera tracker docs, and selection/edit menu internals.
- Why it matters for `VR-apps-lab`: it is one of the strongest open references
  for using VR as a serious creator workspace.

#### Reusable Pattern Extraction

- Pattern candidate: creator workbench interaction shell with CAD/model/UI edit
  affordances.
- Problem solved: in-headset creation requires more than controller poses; it
  needs discoverable menus, mode state, picking, manipulation, snapping,
  panels, file/text/color input, feedback, and host-app command adapters.
- Reusable core: runtime/session wrapper, controller ray/pick layer, menu/panel
  layer, command-mode state, document/model adapter, selection model,
  snapping/working-plane helpers, and feedback surfaces.
- Source evidence: FreeCAD XR `commonXR.py`, `controllerXR.py`, `menuCoin.py`,
  `movementXR.py`, `qtWidgetRender.py`, `documentInteraction.py`;
  Createthis VR UI `PanelBase.cs`, `PanelManager.cs`, `Keyboard.cs`,
  `FileBase.cs`, `KineticScroller.cs`, `TouchPadMenuController.cs`;
  Mesh Maker VR `Mesh.cs`, `Mode.cs`, `VertexController.cs`,
  `TriangleController.cs`, `Selection.cs`, `Snap.cs`; Unity IK
  `IKControl.cs`, `MirrorReflection.cs`, and `TranslucentController.cs`.
- Abstraction boundary: XR runtime, interaction widgets, domain command model,
  persistence, and visual feedback should be separate.
- What not to copy: old Unity 5.x dependencies, asset-store package
  assumptions, host-app-specific APIs, or checked-in third-party assets as
  general implementation baselines.
- Method catalog action: create Method 668.

### `createthis/createthis_vr_ui`

- Interesting idea: complex VR app UI can be factory-built from panels,
  buttons, keyboards, file dialogs, scrollers, profiles, and defaults rather
  than hand-assembled scene objects.
- Code donor value: high as UI toolkit reference. `PanelBase.cs` manages
  grabbable panels, visibility, selectable state, global hide-all behavior,
  placement near controller, and default profiles. `PanelManager.cs` tracks
  panels. `Keyboard.cs` switches lower/upper/number/symbol panels, owns a text
  buffer, and exposes a done callback. `FileBase.cs` builds directory and file
  objects from filesystem paths and feeds them into `KineticScroller.cs`.
  `KineticScroller.cs` uses grab distance to distinguish click from scroll and
  preserves controller velocity. `TouchPadMenuController.cs` builds donut-slice
  radial menu geometry, highlights the selected sector, and triggers on pad
  release. `ExampleMasterUIFactory.cs` composes keyboard, file open/save, and
  tools panels from editor factories.
- Product reference value: high for in-VR utility apps needing panels,
  keyboard, and file dialogs.
- Architecture pattern: profiles/defaults plus factory-generated UI plus
  grabbable panels plus controller menu.
- Reusable method: design VR UI as composable panels and input widgets with
  explicit placement and selection rules.
- Constraints and caveats: Unity 5/SteamVR/VRTK era, optional asset-store color
  picker, old dependencies, and not a modern XRI baseline.
- What to inspect next: color picker integration and panel layout containers.
- Why it matters for `VR-apps-lab`: it gives concrete product patterns for
  menus, file dialogs, and keyboards inside VR.

### `createthis/mesh_maker_vr`

- Interesting idea: in-VR mesh editing can be modeled as command modes over
  vertex and triangle objects, with sticky selection, snapping, color feedback,
  and tool panels.
- Code donor value: high as interaction donor. `Mesh.cs` owns vertices,
  triangles, edges, selection, alignment tools, persistence, copy, extrusion,
  and render options. `Mode.cs` centralizes command transitions and decides
  when to create vertex or triangle instances, clear selections, run copy/paste,
  fill, extrude, merge, flip normals, and set render modes. `VertexController.cs`
  handles drag start/update/end, controller-index arbitration, snapping,
  rotation around pivot, sticky selected vertices, delete, face creation, and
  selection modes. `TriangleController.cs` handles pick color, triangle select,
  vertex select by triangle, delete, normal flip, fill, and collision mesh
  updates. `Selection.cs` broadcasts selection drags, tracks selected vertices
  and triangles, and updates sticky selection. `Snap.cs` rounds position and
  rotation deltas.
- Product reference value: high for creator tools, but legacy.
- Architecture pattern: mode manager plus model controllers plus selection
  state plus visual feedback.
- Reusable method: make edit modes explicit and let each mode configure
  selectability, render options, and command semantics.
- Constraints and caveats: development version, broken reference images and
  alignment tools, Unity 5.6, SteamVR, asset-store dependencies, and old UI
  stack.
- What to inspect next: persistence format, extrusion, alignment tools, and
  integration tests.
- Why it matters for `VR-apps-lab`: it is a rich reference for in-VR mesh
  authoring interactions even if the technology is dated.

### `createthis/unity_vr_ik_mecanim`

- Interesting idea: even a tiny demo can teach embodied feedback: controller
  transforms drive hand IK, hip tracker drives avatar placement, a mirror gives
  self-inspection, and translucent controllers reduce visual occlusion.
- Code donor value: medium. `IKControl.cs` uses Mecanim `OnAnimatorIK` to set
  left/right hand IK positions/rotations, copies HMD head rotation, and places
  the avatar from a hip tracker. `MirrorReflection.cs` creates reflection
  cameras and render textures with recursion guard and clip plane math.
  `TranslucentController.cs` swaps SteamVR render model materials when loaded.
- Product reference value: medium for avatar calibration and feedback UX.
- Architecture pattern: tracking inputs plus avatar IK plus mirror surface plus
  controller visual treatment.
- Reusable method: give users an embodied feedback surface when calibration or
  avatar pose matters.
- Constraints and caveats: explicitly recommends Final IK over Mecanim,
  assumes Vive tracker on hip, head position not used, old Unity/SteamVR, and
  demo-only quality.
- What to inspect next: mirror placement UX and modern full-body IK analogs.
- Why it matters for `VR-apps-lab`: it adds a small but useful embodied
  feedback reference for calibration and creator tools.

## Cross-Project Synthesis

Creator workbenches need a richer interaction stack than ordinary overlays:

- runtime/session integration
- controller ray and picking
- menu/panel system
- command-mode state
- domain object selection
- snapping and working planes
- file/text/color input
- visual and embodied feedback
- persistence and undo/export boundaries

For `VR-apps-lab`, this wave strengthens the backlog around VR menus,
authoring surfaces, CAD helpers, in-headset tool panels, and creative utility
prototypes.
