# Wave 296 - Spatial Anchors, Colocation, Persistent MR Spaces, and Room Registration

This wave studies spatial-anchor and persistent mixed-reality projects as
references for shared MR spaces, room scan persistence, scene registration,
anchor-relative drawing surfaces, launcher-like MR shells, and experiment
alignment helpers.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Meta shared spatial anchors and colocation session groups;
- persistent room scans and room-relative relocation;
- single-anchor setup scenes and universal anchor helpers;
- anchored stylus/canvas workflows;
- experiment registration and replay helpers;
- Quest launcher/product shells that place utility content in MR.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `oculus-samples/Unity-SharedSpatialAnchors` | Meta shared spatial anchors and colocation groups | Deepened from partial | Strong official reference for anchor creation, saving, sharing, group discovery, alignment, and MRUK world-lock handoff |
| `oculus-samples/Unity-Discover` | Meta MR sample/product composition | Deepened from partial/source-heavy | Useful as MR app composition reference, but less direct donor than the anchor-focused sample |
| `arghyasur1991/QuestRoomScan` | Persistent room scan and relocation toolkit | Studied | Room scan packages, MRUK fallback anchors, OVRSpatialAnchor persistence, relocation matrices, scene-object registry, and runtime guard |
| `NirajArts/SpatialAnchorTracking_Meta` | Single-universal-anchor setup helper | Studied | UI-driven create/delete/load/reposition flow and transform application from a persistent anchor |
| `jamesdowzard/quest-launcher` | Quest MR launcher shell | Studied | Android helper bridge, model loading, HUD/orbit shell, and app bootstrap separation |
| `ftmghorbani/MX_Ink_2Ddrawing_Sample` | Anchored stylus/canvas MR drawing | Studied | Stylus pressure/double-tap input, three-anchor canvas setup, PlayerPrefs persistence, and OpenXR action bindings |
| `abhinavazad/XR-Experiment-Design-Toolbox` | Experiment registration and scene reconstruction | Studied | Procrustes re-registration, anchor JSON schema, prefab placement, movement replay, and experiment logs |

## Code-Level Findings

### `oculus-samples/Unity-SharedSpatialAnchors`

- Interesting idea:
  alignment is treated as a first-class boundary: choose an anchor, make it the
  origin, then keep non-anchored objects consistent when the world origin moves.
- Code donor value:
  very high. `Alignment.cs`, `AnchorSource.cs`, `ColoDiscoAnchor.cs`,
  `ColoDiscoMan.cs`, `LocallySaved.cs`, `SharedAnchorLoader.cs`, and
  `PhotonAnchorManager.cs` show anchor source typing, save/load/share flows,
  remembered UUIDs, group sharing, Photon handoff, and MRUK custom world lock.
- Product reference value:
  very high for colocated utilities, shared overlays, and persistent MR
  workspaces.
- What to inspect next:
  complete Photon session setup, permissions, failure states, user-facing
  status panels, and how group share UX should degrade when cloud sharing is
  unavailable.

### `oculus-samples/Unity-Discover`

- Interesting idea:
  a larger MR sample can be mined for product composition even when anchor code
  is less isolated than in the dedicated Shared Spatial Anchors sample.
- Code donor value:
  medium/source-heavy. The repo is useful for scene composition, player/enemy
  object organization, and product framing, but this pass did not promote it as
  the main anchor donor.
- Product reference value:
  medium/high for end-to-end MR experience framing.
- What to inspect next:
  exact MRUK/spatial-anchor usage, scene setup conventions, onboarding, and
  whether smaller utility panels can be separated from the full sample.

### `arghyasur1991/QuestRoomScan`

- Interesting idea:
  room scanning can be packaged as a persistent artifact set tied to an anchor,
  with relocation computed as `anchor_now * inverse(anchor_at_save)`.
- Code donor value:
  very high. `RoomScanner.cs` separates depth capture, volume integration, mesh
  extraction, render modes, and optional modules. `RoomScanPersistence.cs`
  stores versioned scan packages with `scan.bin`, `anchor.json`, triplanar
  data, splats, refined meshes, and scene objects. `RoomAnchorManager.cs`
  combines MRUK scene loading, OVRSpatialAnchor creation/localization, fallback
  matrices, and relocation. `XRRuntimeGuard.cs` centralizes Quest/XR availability
  checks.
- Product reference value:
  very high for room-aware utility workbenches and persistent environment
  captures.
- What to inspect next:
  native mesh/atlas dependencies, package migration, privacy of room data,
  deletion/export UX, and recovery when anchors fail to localize.

### `NirajArts/SpatialAnchorTracking_Meta`

- Interesting idea:
  a persistent "universal anchor" can be managed by a setup scene and exposed
  to other scene objects as a transform source.
- Code donor value:
  medium. `InitAnchorManager.cs` provides UI actions for create/delete/reset,
  positioning, completing, loading, and status logging. `SetUniversalAnchor.cs`
  stores anchor/center transforms. `CustomSpatialAnchor.cs` exposes singleton
  and event-style access to the active anchor.
- Product reference value:
  high for simple setup flows and "anchor once, reuse everywhere" utilities.
- What to inspect next:
  underlying `UniversalSpatialAnchor.cs`, persistence format, duplicate-anchor
  handling, and scene transition safety.

### `jamesdowzard/quest-launcher`

- Interesting idea:
  an MR utility shell can be split into Android helper bridge, Unity bootstrap,
  model viewer, and HUD rather than one monolithic app scene.
- Code donor value:
  medium. `AppBootstrap.cs`, `LauncherBridge.cs`, `ModelLoader.cs`,
  `ModelInfoHUD.cs`, `OrbitController.cs`, Kotlin bridge code, and design docs
  show a useful launcher/product shell boundary.
- Product reference value:
  high for Quest app libraries, model shelves, and MR utility launchers.
- What to inspect next:
  Android package query permissions, hidden-activity launch behavior,
  rollback/safety UX, and anchor/placement policy for launcher content.

### `ftmghorbani/MX_Ink_2Ddrawing_Sample`

- Interesting idea:
  a physical stylus can place a three-point spatial canvas, draw on it, and
  persist both anchors and canvas state across sessions.
- Code donor value:
  medium/high. `CanvasSetupManager.cs`, `StylusHandler.cs`, `VrStylusHandler.cs`,
  `LineDrawing.cs`, and `RuntimeActionBindings.json` show pressure thresholding,
  OpenXR stylus paths, double-tap/hold gestures, anchor placement, canvas
  generation, and drawing lifecycle.
- Product reference value:
  high for MR note surfaces, physical-tool input, and anchored whiteboards.
- What to inspect next:
  PlayerPrefs schema, multi-canvas handling, anchor validity, undo stack,
  stroke export, and Logitech MX Ink dependency boundaries.

### `abhinavazad/XR-Experiment-Design-Toolbox`

- Interesting idea:
  experiment spaces can be restored by loading anchor/prefab JSON and optionally
  re-registering the virtual scene to physical markers using Procrustes
  alignment.
- Code donor value:
  high. `AnchorReinitiateManager.cs`, `AnchorUIManager.cs`,
  `ExperimentManager.cs`, `PrefabPlacer.cs`, and `ReplayMovement.cs` show
  anchor JSON, registration metrics, experiment lifecycle logs, prefab
  reconstruction, and replay-oriented data capture.
- Product reference value:
  high for research setup tools and repeatable spatial-study workflows.
- What to inspect next:
  JSON schema versioning, absolute-path assumptions, transform error metrics,
  participant privacy, and editor/runtime separation.

## Reusable Pattern Extraction

- Pattern candidate:
  spatial-anchor and persistent MR-space boundary across anchor lifecycle,
  world alignment, content attachment, session discovery, persistence, and
  relocation.
- Problem solved:
  MR utilities often fail when world origin, room data, or shared anchors are
  treated as scene details instead of reusable infrastructure.
- Reusable core:
  anchor source type, create/localize/save/load/erase/share actions, remembered
  UUIDs, session/group discovery, MRUK fallback transform, origin realignment,
  anchor-relative content parent, package manifest, relocation matrix, scene
  object registry, and visible status/repair UI.
- Source evidence:
  `Unity-SharedSpatialAnchors`, `QuestRoomScan`,
  `SpatialAnchorTracking_Meta`, `quest-launcher`,
  `MX_Ink_2Ddrawing_Sample`, and `XR-Experiment-Design-Toolbox`.
- Abstraction boundary:
  keep anchor lifecycle, room/scene source, world-origin alignment, content
  placement, sharing transport, persistence package, and user feedback separate.
- What not to copy:
  anchor UUIDs without ownership/status metadata, hidden PlayerPrefs schemas,
  cloud/group share paths without offline fallback, room scans without privacy
  controls, absolute file paths in experiment loaders, or launcher actions
  without package permission checks.
- Method catalog action:
  add a spatial anchor, colocation, and persistent MR space method.

## Follow-Up Gaps

- Build a matrix across local anchors, cloud/shared anchors, MRUK room anchors,
  Procrustes registration, and anchor-relative content packages.
- Deepen `Unity-SharedSpatialAnchors` and `QuestRoomScan` as strongest donors.
- Compare this wave with older world-locking and spatial-anchor waves so
  colocation, room persistence, and registration terminology stays consistent.
- Consider a future reuse plan for a "persistent MR utility shell": anchor
  inventory, repair flow, package export, and privacy-aware room data cleanup.
