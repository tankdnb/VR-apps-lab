# GitHub Research Wave 202 Plan

- Date: `2026-06-06`
- Theme: `Lightweight XR editor, tour-builder, live-coding, and creator microtools`
- Scope: in-browser tour builders, A-Frame VR edit components, node-graph scene
  generation, WebXR controller editor templates, VR code/text workspaces,
  Unity in-VR animation editing, WebGL/Cardboard voxel editors, and VRChat
  creator microtools.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Prior creator waves covered large editor ecosystems. Wave 202 focuses on
lighter authoring surfaces: small tools that let a user place, edit, export, or
control VR content without becoming a full engine. These are especially useful
for extracting reusable UX and serialization patterns.

## Search Families

- WebXR and A-Frame in-headset editors
- browser 360 tour builders
- visual node graph scene tools
- VR controller authoring templates
- VR code/text workspaces
- Unity in-VR animation and avatar editing helpers
- VRChat creator microtools

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `Humangle/VRTourEditor` | Browser 360 tour editor with `.hvrj` manifest and zip export | Tour-builder donor |
| `caseyyee/aframe-vreditor-component` | A-Frame component for in-headset grab/clone/scale editing | In-VR edit primitive donor |
| `wakufactory/GNode` | Node graph that serializes/evaluates geometry and A-Frame entities | Visual scene graph donor |
| `flushpot1125/WebXR_VRController_Editor_template` | Babylon.js Editor-generated WebXR controller input template | Controller binding reference |
| `dkaraush/vrcode` | Three/WebXR text/code workspace with VR keyboard and ray-dragging | VR text workspace donor |
| `umiyuki/UnityVRAnimationEditor` | Unity in-VR animation editing with grab nodes and Animation Window bridge | In-VR Unity authoring donor |
| `evanw/webgl-vr-editor` | Cardboard/WebGL voxel editor with edit/play mode and undo | Historical lightweight editor reference |
| `Reava/VRC-Editor-Toolbox` | Unity/VRChat creator microtools for arrangement, teleport, naming, and light tools | Production microtool reference |

## Dedupe Notes

- Browser-based XR editor and live-coding waves already covered large
  frameworks; this wave focuses on new or more narrowly useful microtools.
- VR menu/radial waves are adjacent, but this pass is about authoring and
  editing content rather than command menus alone.
- Unity/VRChat editor utilities are included only where they show reusable
  production workflow patterns.

## Code-Level Pass Targets

- Manifest/export formats and zip/package generation.
- In-headset selection, raycasting, grabbing, reparenting, cloning, scaling, and
  undo.
- Node-graph serialization, socket/joint evaluation, and scene/entity bridge.
- WebXR controller component mapping and generated editor script attachment.
- VR text input, keyboard mesh, object dragging, and code workspace ergonomics.
- Unity Editor bridge points: Animation Window reflection, Undo, grabbable
  nodes, and creator microtools.

## Expected Outputs

- Wave 202 landscape synthesis.
- Registry/family placement for lightweight XR authoring surfaces.
- Method around browser/native XR authoring surfaces and serializable manifests.
