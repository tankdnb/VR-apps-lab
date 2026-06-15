# Wave 308 - VR/3D Annotation, Point-Cloud Labeling, and Linked-Data Note Surfaces

This wave studies VR annotation and 3D labeling tools as reusable references
for spatial notes, point-cloud inspection, in-VR bounding boxes, linked-data
annotation records, source-local persistence, REST-backed sync, sequence
navigation, and provenance-aware data collection.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- point-cloud editors and in-VR 3D labeling workflows;
- geometry handles for labels, boxes, nearest-point queries, and outlier
  inspection;
- local and remote persistence for annotation records;
- spatial navigation back to an annotation viewport;
- reusable boundaries between dataset import, annotation UX, persistence,
  provenance, and geometry services.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `ahstevens/VR-Point-Cloud-Editor` | Native-plugin point-cloud editor and inspection utility | Studied | Unity manager plus native `PointCloudPlugin` boundary for LAZ import/export, LOD/culling, closest-point queries, outlier highlighting/deletion, and editor/runtime control |
| `florianwirth/PointAtMe` | In-VR point-cloud and camera-image labeling tool | Studied | Sequence navigation, synchronized point clouds/images, in-VR bounding boxes, track metadata, class/quality dialogs, and controller-driven label manipulation |
| `framefield/vr-annotate` | Linked-data architectural VR annotation package | Studied | Annotation manager, local/REST persistence, target/node selectors, W3C-ish annotation JSON-LD, annotation gizmos, and teleportable annotation tours |

## Code-Level Findings

### `ahstevens/VR-Point-Cloud-Editor`

- Interesting idea:
  point-cloud editing in VR works best when the Unity layer stays thin and the
  heavy geometry service remains behind a native plugin boundary.
- Code donor value:
  high. `pointCloud.cs` stores raw data path, point-cloud ID, adjustment
  transforms, EPSG/UTM metadata, bounds, ground level, and miniature reset
  logic. `pointCloudManager.cs` wraps `PointCloudPlugin` calls for camera
  updates, world matrices, render-event hook, LAZ open/save, custom save/load,
  frustum culling, LOD, octree debug, closest-point query, sphere queries,
  undo, outlier highlight/delete, UTM adjustment, and debug logging.
- Product reference value:
  high for survey, mapping, inspection, and data-cleaning VR utilities where
  the VR UI should expose navigation and selection while a native module owns
  indexing, streaming, and geometry mutation.
- What to inspect next:
  native plugin API shape, LAZ format assumptions, editor window lifecycle,
  render-event threading, command-line import/export mode, and undo semantics.
- Reusable pattern extraction:
  use a `Unity shell -> native geometry service -> VR/editor controls`
  boundary for large spatial datasets.

### `florianwirth/PointAtMe`

- Interesting idea:
  3D labeling benefits from a combined scene timeline: each frame can bind a
  point cloud, synchronized camera images, active boxes, track IDs, and label
  quality metadata.
- Code donor value:
  high. `LabelToolManager.cs` controls sequence index, dataset names,
  class/priority/direction/parking/lane dialogs, current track ID, scale
  factors, and OVR controller thresholds. `PointCloudManager.cs` loads `.pcd`
  data, splits meshes into roughly 65k-point chunks, creates mesh assets and
  prefabs, and synchronizes image frequency with point-cloud frames.
  `SetBoxes.cs` creates and loads cube labels, colors tracks, manipulates boxes
  by controller hand-trigger relative transforms, and stores class/quality,
  priority, direction, parking, lane, first/last/clearest-shot metadata.
- Product reference value:
  high for annotation labs, replayable labeling tasks, and dataset QA tools
  where VR control is used for fast spatial adjustment rather than final model
  training.
- What to inspect next:
  save format, `LabeledObject` serialization, sample datasets, track ID
  merging, box resize affordances, and portability away from hardcoded paths.
- Reusable pattern extraction:
  treat in-VR labeling as `dataset sequence -> synchronized modalities ->
  geometry handles -> taxonomy dialogs -> track metadata -> save/export`.

### `framefield/vr-annotate`

- Interesting idea:
  architectural VR annotations become more reusable when each note stores both
  the target object path and the viewer position needed to revisit the note.
- Code donor value:
  high. `AnnotationManager.cs` creates annotations with target node,
  `LinkedDataID`, annotation position, viewport position, author, timestamp,
  and gizmo prefab. It can move to previous/next annotations by selecting a
  gizmo and teleporting to the stored viewport. `Serialization.cs` supports a
  local `Application.dataPath` database and a REST target at
  `http://127.0.0.1:8301/targets/`, reads all JSON annotations for a target,
  and writes targets/annotations locally or through `UnityWebRequest`.
  `Annotation.cs` serializes a W3C-style JSON-LD annotation with creator,
  timestamp, textual body, target ID, node graph selector, simulation time,
  annotation position, and viewport position.
- Product reference value:
  very high for review tools, spatial issue trackers, architectural
  walkthroughs, QA tours, and annotation-backed training environments.
- What to inspect next:
  node graph selector UX, target tree selection, REST service expectations,
  keyboard entry flow, auth/versioning gaps, and annotation merge/conflict
  behavior.
- Reusable pattern extraction:
  separate `spatial note body`, `target selector`, `viewport recall`,
  `provenance`, and `storage adapter`.

## Reusable Pattern Extraction

- Pattern candidate:
  VR annotation and point-cloud labeling boundary across spatial target, label
  schema, geometry handle, persistence, navigation, and provenance.
- Problem solved:
  annotation tools often mix raw dataset loading, label editing, target
  identity, visual feedback, save format, and review navigation. Reuse needs
  each layer to remain replaceable.
- Reusable core:
  data source adapter, spatial target selector, annotation/label schema,
  geometry handle or query service, controller manipulation, taxonomy dialog,
  provenance fields, local/remote persistence adapter, and revisit/navigation
  command.
- Source evidence:
  `ahstevens/VR-Point-Cloud-Editor`, `florianwirth/PointAtMe`, and
  `framefield/vr-annotate`.
- Abstraction boundary:
  keep dataset import, geometry operations, in-VR label manipulation,
  annotation record, storage adapter, and review navigation separate.
- What not to copy:
  hardcoded workstation paths, unauthenticated localhost REST assumptions,
  native plugin lock-in, legacy SteamVR/OVR dependencies, and asset-heavy
  project structure.
- Method catalog action:
  add a VR annotation and point-cloud labeling method.

## Follow-Up Gaps

- Build a matrix for annotation record fields: target ID, node path, world
  position, viewport pose, author, time, class, quality, and external data ID.
- Compare local JSON, REST-backed sync, LAZ/custom point-cloud formats, and
  dataset folder conventions.
- Deepen native point-cloud plugin boundaries and safe geometry mutation
  commands without adopting project-specific binaries.
- Compare these workflows with earlier menu/control and gaze/pinch waves for
  fast taxonomy selection in headset.
