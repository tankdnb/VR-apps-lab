# Wave 288 - MRUK Room-Aware Mixed Reality Scene Data and Panel Placement Utilities

This wave studies Meta MRUK and mixed-reality utility projects as reusable
references for room-aware scene data, semantic anchors, environment raycasts,
world-locked panels, room export, and small MR path/placement interactions.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- MRUK room/anchor/semantic-surface samples;
- environment raycast and world-lock panel placement;
- wall/floor/global-mesh interaction examples;
- room scan export to JSON, OBJ, GLB, reports, and per-room artifacts;
- small MR utility interactions that turn tracked drawing paths into spatial
  waypoints.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `oculus-samples/Unity-MRUtilityKitSample` | MRUK room-aware utility samples | Studied | Official sample set for environment raycasts, panel magnetism, world-lock, wall anchors, QR tracking, nav mesh, and virtual-home behaviors |
| `dilmerv/MixedRealityUtilityKitDemos` | MRUK demo/debug surface | Studied | Compact wall-anchor toggle/debug baseline around `MRUK.RoomCreatedEvent` and room binding |
| `oculus-samples/Unreal-MRUtilityKitSample` | Unreal MRUK scene-data sample | Studied with blueprint/content caveat | Unreal counterpart with readable VR pawn/game-state C++ plus blueprint-heavy scene decoration and widget assets |
| `VeksCZ/XRHouseDesignExport` | MRUK room export and dollhouse/report utility | Studied with artifact-heavy caveat | Strong exporter/report pattern hidden inside generated Android/Unity artifacts |
| `Luizfelm/FlightFollower` | MR path-following micro utility | Studied | Small XR Interaction Toolkit sample for drawing a path and spawning checkpoints along it |

## Code-Level Findings

### `oculus-samples/Unity-MRUtilityKitSample`

- Interesting idea:
  MRUK is used as a scene-data substrate for practical utilities: panels snap to
  detected surfaces, balls collide with room geometry, wall anchors receive
  objects, QR codes become tracked anchors, and samples expose virtual-home,
  keyboard, navmesh, relighting, and space-map behaviors.
- Code donor value:
  high: `EnvironmentPanelPlacement.cs` shows controller raycasts through
  `EnvironmentRaycastManager`, environment/manual pose blending, vertical
  surface `PlaceBox`, floor/upright collision checks, rolling-average normal
  smoothing, panel scale/move controls, raycast visualization, and MRUK
  world-lock toggling.
- Product reference value:
  very high for room-aware overlay/panel placement, spatial utility HUDs,
  scene-aware object spawning, and mixed-reality diagnostic panels.
- What to inspect next:
  `RoomMesh`, `NavMeshSampleController`, `QRCodeManager`,
  `KeyboardManager`, `VirtualHome` spawners, and mobile performance constraints.

### `dilmerv/MixedRealityUtilityKitDemos`

- Interesting idea:
  a small MRUK demo binds the current room and toggles objects on every wall
  anchor with logging, making scene availability visible to the user.
- Code donor value:
  medium: `MRUKDemo.cs` wires `RoomCreatedEvent`, stores the active `MRUKRoom`,
  iterates `currentRoom.WallAnchors`, instantiates prefabs as anchor children,
  and clears them on repeat input.
- Product reference value:
  high as a compact debug/teaching reference for wall/floor/room-anchor
  availability and scene-permission UX.
- What to inspect next:
  scene setup, debugger scene, permission prompts, logger surface, and whether
  the prefab/UI conventions can become a reusable MRUK inspector.

### `oculus-samples/Unreal-MRUtilityKitSample`

- Interesting idea:
  the same MRUK scene-data concepts appear in Unreal through scene decorators,
  scene data providers, widgets, and VR pawn/game-state C++.
- Code donor value:
  low/medium in this pass because much of the behavior is blueprint/content
  `.uasset` material, but `DemoVRPawn`, `VRPawn`, `RoomMesh`, and game-state C++
  are useful Unreal-side entry points.
- Product reference value:
  medium/high for Unreal parity and product framing around scene decoration
  menus and anchor-driven MR utility panels.
- What to inspect next:
  Blueprint graphs, `RoomMesh` C++ behavior, widget flow, PCG raycast assets,
  and how Unreal MRUK exposes semantic surfaces compared with Unity.

### `VeksCZ/XRHouseDesignExport`

- Interesting idea:
  MRUK room scans can be turned into an exportable "house design" package:
  filtered rooms, semantic labels, JSON dumps, text reports, OBJ/GLB models,
  per-room breakdowns, logs, and an in-headset menu.
- Code donor value:
  high but noisy: `MRUKExporter.cs` sequences scene sync, permission/request
  fallback, room filtering by floor area, session folder creation, JSON/report
  writes, analytical mesh exports, reconstruction exports, raw scan exports,
  MTL output, and per-room subfolders. `MRUKDataProcessor.cs` extracts labels,
  anchors, plane rects, semantic labels, mesh counts, and safe names.
- Product reference value:
  very high for a future MRUK scene doctor/exporter, room inspector, or
  offline reconstruction utility.
- What to inspect next:
  `XRModelFactory`, `GLBExporter`, `OBJWriter`, `DollHouseVisualizer`, storage
  permissions, report HTML/SVG generation, and artifact cleanup strategy.

### `Luizfelm/FlightFollower`

- Interesting idea:
  the user draws a spatial line with a controller tip, then the app spawns
  checkpoints uniformly along that line for a flight-following mini utility.
- Code donor value:
  medium: `DrawLine.cs` records a `LineRenderer` polyline by distance threshold
  from an XR tip, and `SpawnObjectsOverLine.cs` samples line length to place
  checkpoint prefabs.
- Product reference value:
  medium for MR path authoring, route preview, training waypoints, and
  lightweight gesture-to-spatial-task utilities.
- What to inspect next:
  controller input binding, plane controller, checkpoint logic, path clearing,
  and how line sampling should handle very short paths.

## Reusable Pattern Extraction

- Pattern candidate:
  room-aware MR utility boundary across scene data, semantic anchors,
  environment raycasts, panel placement, export, and path authoring.
- Problem solved:
  mixed-reality utilities need to treat the room as a live data source without
  coupling every feature directly to a single scene or prefab.
- Reusable core:
  scene permission/load gate, current-room binding, semantic anchor iteration,
  wall/floor/global-mesh access, environment raycast, surface-size/collision
  validation, world-lock status, smoothing, debug visualization, room export,
  report generation, and path-to-waypoint sampling.
- Source evidence:
  `Unity-MRUtilityKitSample`, `MixedRealityUtilityKitDemos`,
  `Unreal-MRUtilityKitSample`, `XRHouseDesignExport`, and `FlightFollower`.
- Abstraction boundary:
  keep scene acquisition, anchor/semantic model, placement solver, UI panel,
  exporter, diagnostics, and gameplay/use-case logic separate.
- What not to copy:
  generated Android/Unity build artifacts, sample SDK payloads as application
  architecture, room labels without fallback/caveats, or export flows without
  permission/storage failure handling.
- Method catalog action:
  add a room-aware MR utility method.

## Follow-Up Gaps

- Build an MRUK utility matrix across room loading, anchors, raycasts,
  global-mesh access, panel placement, world-lock, QR tracking, export, and
  diagnostics.
- Deepen `XRHouseDesignExport` around report/model generation, but treat its
  checked-in artifacts as a hygiene caveat.
- Compare Unity and Unreal MRUK patterns once blueprint inspection is feasible.
- Prototype a tiny `VR-apps-lab` MRUK scene doctor concept: permissions,
  current room, anchor inventory, surface raycast, and export status.
