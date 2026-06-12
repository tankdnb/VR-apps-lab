# Wave 271 - VR Whiteboard, Annotation, and Note-Taking Surfaces

This wave studies VR drawing, whiteboard, annotation, and remote markup
surfaces across A-Frame, Three.js/WebVR, Unity/Daydream, Unity/Oculus,
Babylon/WebXR, and artifact-heavy Unity projects.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- world-space drawing on boards and textures;
- collaborative WebVR/A-Frame drawing;
- remote annotation into VR scenes;
- Unity landmark/point-cloud/video annotation workflows;
- artifact hygiene for Unity whiteboard repos.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `jorisvddonk/drawplane` | A-Frame collaborative whiteboard | Studied | Crayon raycast, meshline strokes, PeerJS stroke sharing |
| `liuchen1701/VR-Whiteboard` | Unity Daydream whiteboard prototype | Studied with caveats | Raycast-to-board painter instantiation |
| `arcwhite/vr-whiteboard` | Three.js/WebVR dynamic texture whiteboard | Studied | UV/barycentric hit-to-canvas drawing pattern |
| `yankanp/web-vr-annotation` | Remote WebXR annotation bridge | Studied | WebSocket/WebRTC annotation and text injection |
| `MichaeliusAChapelo/VR-Annotation-Scripts` | Unity/Oculus landmark annotation scripts | Studied with license caveat | Raycast dots, import/export CSV, input mapping |
| `rafaelkuffner/VR-Annotator` | Unity point-cloud/video annotation tool | Studied with caveats | Annotation manager, point-cloud playback, timeline modes |
| `Danda420/vr-whiteboard` | Unity texture whiteboard | Studied with artifact caveat | Simple texture painting plus heavy checked-in Library/Temp |

## Code-Level Findings

### `jorisvddonk/drawplane`

- Interesting idea:
  a simple A-Frame VR blackboard where controller crayons draw meshline
  strokes and hosts share strokes to peers.
- Code donor value:
  strong for browser-native collaborative drawing: raycaster on `.drawable`,
  near-tip crayon geometry, meshline path append, line finalization, PeerJS
  host/client split, hash-based room identity, and `DRAW` message replay to
  connected clients.
- Product reference value:
  excellent minimal reference for collaborative sketch/notes in VR.
- What to inspect next:
  full-state sync for late joiners, eraser/color/tool palette, stroke
  persistence, and modern WebXR migration.
- Caveats:
  TODO for complete drawing sync, old PeerJS version, and a small path string
  typo in `linedrawer`.

### `liuchen1701/VR-Whiteboard`

- Interesting idea:
  Daydream controller raycast paints a Unity whiteboard by instantiating
  painter objects at hit positions.
- Code donor value:
  limited but clear: `GvrController.Orientation`, raycast against object named
  `WhiteBoard`, touch-state gate, and point prefab instantiation at hit point.
- Product reference value:
  useful as a very small mobile VR whiteboard prototype.
- What to inspect next:
  actual scene setup, painter prefab behavior, performance under many points,
  and migration off legacy GoogleVR.
- Caveats:
  legacy Daydream/GoogleVR stack, name-based object checks, and bundled
  TiltBrush example/vendor content.

### `arcwhite/vr-whiteboard`

- Interesting idea:
  use a dynamic canvas texture as a whiteboard in a Three.js/WebVR scene.
- Code donor value:
  useful for hit-to-texture mapping: VR viewer shell, controller exposure,
  event loop, dynamic texture, barycentric interpolation from face hit to UV,
  UV-to-canvas conversion, and texture `needsUpdate`.
- Product reference value:
  strong for board/panel surfaces where drawings should live on a material.
- What to inspect next:
  controller raycaster origin, stroke interpolation, eraser/palette, and
  WebXR migration from WebVR.
- Caveats:
  WebVR-era code, old Three.js conventions, and example-level implementation.

### `yankanp/web-vr-annotation`

- Interesting idea:
  split VR scene and annotation UI into two web clients connected by
  WebSocket/WebRTC.
- Code donor value:
  strong for remote annotation surfaces: HTTPS Express static server,
  WebSocket role registration, WebRTC offer/answer/ICE relay, VR canvas
  capture stream, annotation-client screen capture, normalized click
  coordinates, Babylon picking ray, temporary arrows, and floating text planes.
- Product reference value:
  excellent product reference for remote assistant, instructor, or operator
  markup in VR.
- What to inspect next:
  auth, room IDs, Quest casting limitations, annotation persistence, latency,
  and secure certificate handling.
- Caveats:
  local certs committed, single VR/annotation client slots, and comments note
  canvas capture limitations in immersive mode.

### `MichaeliusAChapelo/VR-Annotation-Scripts`

- Interesting idea:
  annotate 3D objects in Unity/Oculus by placing, moving, deleting, importing,
  and exporting landmark dots.
- Code donor value:
  useful for annotation workflows: input mapping enum, dominant-hand switch,
  raycast line, selectable dots, object transform/scale controls, CSV import
  of positions/normals, export with normal vectors, and reset-to-identity
  calibration before serialization.
- Product reference value:
  strong for research annotation tooling and landmark capture.
- What to inspect next:
  replace hardcoded paths, add license-safe alternative, configurable
  datasets, and modern XR input.
- Caveats:
  repository explicitly has no reuse license; do not copy code directly.

### `rafaelkuffner/VR-Annotator`

- Interesting idea:
  annotate recorded point-cloud/video/skeleton data in VR with multiple
  annotation modes.
- Code donor value:
  useful as a rich architecture reference: `AnnotationManager` mode state,
  static annotation list, speech/scribbler/visual/mark/floor modes,
  point-cloud video player, native plugin frame ingestion, skeleton playback,
  config file parsing, and UI collider helpers.
- Product reference value:
  strong reference for timeline-based review and dataset annotation.
- What to inspect next:
  plugin API contract, data formats, annotation serialization, UI flow, and
  artifact cleanup.
- Caveats:
  no README, checked-in Unity player/plugins/datasets, and large artifact
  payload.

### `Danda420/vr-whiteboard`

- Interesting idea:
  simplest Unity physical whiteboard: pen raycast writes pixels into a
  `Texture2D`.
- Code donor value:
  useful micro-pattern: board owns a 2048 texture, pen caches color block,
  raycasts from tip, converts `textureCoord` to pixels, interpolates between
  last and current touch, writes pixels, then applies texture.
- Product reference value:
  strong tiny baseline for texture-backed boards.
- What to inspect next:
  packaging cleanup, performance with large textures, pressure/eraser/color,
  and save/export.
- Caveats:
  repo includes `Library`, `Temp`, `Logs`, user settings, and build artifacts;
  donor value is in the two scripts, not the repository hygiene.

## Reusable Pattern Extraction

- Pattern candidate:
  VR whiteboard and annotation intake boundary.
- Problem solved:
  VR utilities need ways to create, share, persist, and remote-control marks in
  space: strokes on boards, dots on objects, arrows in scenes, text planes,
  and timeline annotations.
- Reusable core:
  hit source, target surface, coordinate transform, mark model, stroke/dot/text
  persistence, collaboration/transport, edit/delete flow, export schema,
  artifact hygiene, and license gate.
- Source evidence:
  A-Frame meshline strokes in `drawplane`, Unity raycast/painter in
  `VR-Whiteboard`, Three.js UV dynamic texture in `vr-whiteboard`,
  WebSocket/WebRTC remote arrows in `web-vr-annotation`, Unity landmark CSV
  export in `VR-Annotation-Scripts`, point-cloud annotation in `VR-Annotator`,
  and texture painting in `Danda420/vr-whiteboard`.
- Abstraction boundary:
  separate mark capture, coordinate mapping, storage/export, and transport so
  future overlay or utility tools can reuse the same annotation model.
- What not to copy:
  no-license code, committed Unity `Library/Temp/Logs`, hardcoded local paths,
  committed certs, legacy WebVR/Daydream APIs without migration notes, or
  vendor payloads as original logic.
- Method catalog action:
  create a method for whiteboard and annotation surface reuse.

## Family Placement

This wave creates a VR whiteboard/annotation family. It overlaps with browser
creative surfaces, WebRTC remote rendering, XR research data lifecycle, and
overlay media micro-surfaces.

## Backlog Impact

- Build a whiteboard/annotation matrix across meshline strokes, dynamic
  textures, texture pixels, landmark dots, remote arrows/text, and timeline
  annotations.
- Deepen `drawplane`, `web-vr-annotation`, and `Danda420/vr-whiteboard` as
  minimal donors with caveats.
- Treat no-license and artifact-heavy projects as reference-only unless code
  can be replaced cleanly.
