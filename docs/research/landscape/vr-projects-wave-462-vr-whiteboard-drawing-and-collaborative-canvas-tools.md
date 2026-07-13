# Wave 462: VR whiteboard drawing and collaborative canvas tools

- Date: `2026-07-13`
- Scope: VR/WebXR/Unity whiteboards, canvas texture painting, collaborative
  rooms, hand-tracked board creation, HoloLens shared boards, infinite board
  concepts, Yjs document schemas, persistence, and accessibility tests.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `marlon360/whiteboard-vr` | Studied | WebXR collaborative texture painting |
| `donth77/komuboard` | Studied | Realtime collaborative board schema |
| `MarekMarchlewicz/Painting` | Studied | Unity VR whiteboard painting |
| `Zuehlke/SharedWhiteboard` | Studied | HoloLens/WebApp shared whiteboard |
| `alpercanberk/Handtracking-Whiteboard-Oculus` | Studied | Quest hand-tracked whiteboard |
| `Haczar/InfiniteWBVR` | Lightly studied | SteamVR infinite whiteboard concept |

## Why this wave matters

Whiteboards are a recurring VR utility shape: draw on a surface, share strokes,
erase, change color/size, persist state, invite others into a room, and support
desktop/mobile/VR access. This wave extracts board/canvas patterns rather than
just noting "VR drawing" as a feature.

## Project notes

### `marlon360/whiteboard-vr`

- Interesting idea:
  web-based collaborative whiteboard for VR, desktop, and mobile using A-Frame,
  a dynamic canvas texture, raycaster UV painting, room ids, and Socket.IO draw
  events.
- Code donor value:
  strong donor for texture-backed board painting: controller ray intersection
  provides UV coordinates, the canvas is updated, `needsUpdate` refreshes the
  texture, and remote draw/erase messages replay strokes by room.
- Product reference value:
  shows a complete lightweight product loop: random room, shared URL, VR
  drawing, desktop/touch fallback, color/size/eraser/erase-all controls.
- Source evidence:
  `src/components/texture-painter.component.js`, `src/vr.js`,
  `server.js`, `server-ssl.js`, `src/components/color-picker.component.js`,
  `src/components/eraser-picker.component.js`, and `src/components/room-number.component.js`.
- Reusable core:
  canvas texture, raycaster UV mapping, local stroke replay, remote stroke
  replay, room id, color/size/eraser state, clear-all event, desktop/touch
  fallback, controller trigger state, and texture update lifecycle.
- What not to copy:
  old dependency versions, raw Socket.IO event schema without auth/rate limits,
  or fixed canvas dimensions as a universal board model.
- What to inspect next:
  server event routing, room lifecycle, compression, and undo/redo possibilities.

### `donth77/komuboard`

- Interesting idea:
  modern collaborative whiteboard with shared contract package, Yjs document
  schema, PartyServer room routing, Durable Object persistence, upload contract,
  a11y/e2e tests, and planned VR renderer boundary.
- Code donor value:
  excellent donor for durable board state: `objects` map, `order` array,
  stroke/text/connector/stamp/image objects, room id sanitization, presence
  payloads, max connections, corruption-safe persistence, and upload limits.
- Product reference value:
  demonstrates a mature collaboration model where desktop/mobile/VR clients
  share one schema instead of inventing separate canvas models.
- Source evidence:
  `packages/shared/src/schema.ts`, `packages/shared/src/index.ts`,
  `packages/shared/src/uploads.ts`, `packages/worker/src/persistence.ts`,
  `packages/worker/src/reap.ts`, and `e2e/*`.
- Reusable core:
  Yjs doc, object map, z-order array, stroke schema, text runs, connectors,
  images, stamps, grouping/locking, room id sanitizer, close codes, max
  connections, corrupt-doc policy, upload caps, and accessibility tests.
- What not to copy:
  app branding, provider-specific Cloudflare/PartyServer wiring, or editor UI
  assumptions without VR renderer design.
- What to inspect next:
  VR package/client boundary, awareness schema, conflict behavior, and renderer
  projection into spatial boards.

### `MarekMarchlewicz/Painting`

- Interesting idea:
  Unity VR drawing/painting prototype focused on a board surface and paint
  preview flow.
- Code donor value:
  useful as a compact Unity painting reference for materials, board texture,
  shader-on-top behavior, and simple VR drawing UX.
- Product reference value:
  reinforces that whiteboard tools can be valuable even as a narrow microtool.
- Source evidence:
  `README.md`, `Assets/Materials/*`, `Assets/Textures/*`, `ProjectSettings/*`,
  `PaintingPreview.gif`, and Unity scenes/assets.
- Reusable core:
  board material, paint texture, brush interaction, preview artifact, and simple
  Unity project shape.
- What not to copy:
  imported assets/project bulk or old Unity settings wholesale.
- What to inspect next:
  brush scripts, texture write path, and input mapping.

### `Zuehlke/SharedWhiteboard`

- Interesting idea:
  HoloLens shared whiteboard with a web app, whiteboard detection pipeline,
  session service tests, and image processing components for extracting board
  rectangles/corners/dark areas.
- Code donor value:
  useful donor for physical-board detection and shared session architecture
  rather than only virtual drawing.
- Product reference value:
  suggests a hybrid meeting utility: detect a physical board, align it, share
  state, and let headset/web clients interact.
- Source evidence:
  `WebApp/WhiteBoardDetection/*`, `WebApp/SharedWhiteBoard.Tests/*`,
  `HoloLensApp/*`, and `README.md`.
- Reusable core:
  rectangle finder, corner finder, image rotator, dark-area extractor,
  similarity checker, service tests, HoloLens app boundary, and web app.
- What not to copy:
  old solution files/db artifacts or image-processing thresholds without
  calibration.
- What to inspect next:
  session service model, HoloLens alignment path, and detection tuning.

## Reusable pattern extraction

- Pattern candidate:
  `collaborative spatial whiteboard substrate`.
- Problem solved:
  represent board content, drawing input, room membership, persistence, and
  desktop/mobile/VR clients through one shared canvas/document model.
- Reusable core:
  room id, board object schema, z-order, stroke points, text/connectors/images,
  brush settings, eraser/clear-all, UV/ray mapping, local/remote replay,
  presence, persistence, corrupt-state policy, upload limits, and accessibility
  checks.
- Abstraction boundary:
  board schema owns durable content; renderer owns surface projection; input
  adapter owns ray/hand/mouse/touch conversion; collaboration layer owns room,
  sync, persistence, and limits.
- Method catalog action:
  create a new method for collaborative spatial whiteboard substrates.

## Caveats

- Realtime drawing needs rate limits, room lifecycle, auth/visibility policy,
  and abuse handling before product reuse.
- Unity/SteamVR whiteboard repos can be asset-heavy; reusable value is the
  painting model and input flow.
- Shared physical/virtual whiteboards need explicit calibration and privacy
  labels.

