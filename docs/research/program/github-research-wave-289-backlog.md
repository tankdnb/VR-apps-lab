# GitHub Research Wave 289 Backlog - WebXR Spatial UI Primitives, Mesh Text Layout, and Fullstack UI Shells

## Executed Scope

- Searched and deduplicated WebXR UI, Three.js mesh UI, A-Frame mesh UI, and
  socket-backed WebXR starter projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted canvas-to-plane panels, CanvasTexture invalidation, UV-to-widget
  hit testing, controller raycasts, hover/select/scroll states, mesh-native
  blocks/text, deferred layout updates, A-Frame component wrappers, and Socket.IO
  button actions.

## Studied Projects

- `NikLever/CanvasUI`
- `felixmariotto/three-mesh-ui`
- `Retchut/aframe-mesh-ui-components`
- `shiveshjadon/webxr-fullstack-boilerplate`

## Backlog Findings

- Build a WebXR UI method matrix comparing canvas texture panels,
  mesh-native layout, A-Frame wrappers, and React/Socket shell patterns.
- Deepen `three-mesh-ui` around text layout, keyboard, current version changes,
  and memory/dispose behavior.
- Deepen `CanvasUI` around widget semantics, input text, scrolling, and mobile
  headset browser constraints.
- Compare these with earlier `aframe-gui` and `aframe-webxr-ui-toolkit` entries
  without duplicating those already-studied projects.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a WebXR spatial UI primitive method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
