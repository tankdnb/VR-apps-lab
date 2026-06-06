# GitHub Research Wave 202 Backlog

- Date: `2026-06-06`
- Theme: `Lightweight XR editor, tour-builder, live-coding, and creator microtools`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for WebXR/A-Frame editors, tour builders, scene graph
  tools, VR code workspaces, Unity in-VR animation tools, and VRChat creator
  microtools.
- `Done` Dedupe against prior WebXR editor, authoring, menu, and VRChat
  creator-tool waves.
- `Done` Freeze a shortlist that covers authoring surfaces rather than one
  framework only.

## Source Sync

- `Done` Confirm `VRTourEditor` in local-only cache.
- `Done` Confirm `aframe-vreditor-component` in local-only cache.
- `Done` Confirm `GNode` in local-only cache.
- `Done` Confirm `WebXR_VRController_Editor_template` in local-only cache.
- `Done` Confirm `vrcode` in local-only cache.
- `Done` Confirm `UnityVRAnimationEditor` in local-only cache.
- `Done` Confirm `webgl-vr-editor` in local-only cache.
- `Done` Confirm `VRC-Editor-Toolbox` in local-only cache.

## Code Reading

- `Done` Inspect `.hvrj` link graph, 360 sphere teleport buttons, desktop and
  VR ray picking, localStorage autosave, save/export zip, and generated runtime
  player in `VRTourEditor`.
- `Done` Inspect A-Frame `edit` component controller discovery, grip events,
  collision selection, reparent-on-grab, clone-on-two-hand grab, and axis-scale
  behavior in `aframe-vreditor-component`.
- `Done` Inspect node/socket/joint model, serialized graph data, node edit
  bridge, A-Frame entity nodes, and VR movement helpers in `GNode`.
- `Done` Inspect Babylon.js Editor script attachment, `fromScene` node links,
  default XR experience setup, controller component ids, and performance
  pipeline disabling in `WebXR_VRController_Editor_template`.
- `Done` Inspect Three/WebXR scene shell, controller ray dragging, VR display
  objects, VR keyboard mesh, textarea object, and object movement filters in
  `vrcode`.
- `Done` Inspect Unity node generation, VRTK grabbable target setup, Undo-backed
  animation recording, Animation Window reflection helper, and pointer-to-editor
  window bridge in `UnityVRAnimationEditor`.
- `Done` Inspect Cardboard/WebGL edit/play mode, voxel cursor, orientation
  mapping, undo tracker, file save/load, and headset rendering in
  `webgl-vr-editor`.
- `Done` Inspect Unity Editor microtools for circle placement, teleport to
  transform, sequential naming, light-volume toggles, and Bakery mass editing
  in `VRC-Editor-Toolbox`.

## Integration

- `Done` Create Wave 202 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable method for in-browser/in-headset authoring surfaces with
  serializable manifests.
- `Next` Build a lightweight XR authoring matrix across selection, manipulation,
  serialization, undo, export, and engine/editor integration.
