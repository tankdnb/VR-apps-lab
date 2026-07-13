# VR Projects Wave 433: VR Scientific Annotation Point-Cloud and Slice-Stack Tools

Date: 2026-07-13

Theme: scientific annotation utilities that turn dense point clouds or image
stacks into interactable VR/3D data with gaze, hand, raycast, labels, and export.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `RMonica/vr_hand_gaze_annotation` | VR point-cloud annotation | Code-level pass |
| `newgen211/Vr-axion` | Neuron image-stack annotation | Code-level pass |

## Project Notes

### `RMonica/vr_hand_gaze_annotation`

- Interesting idea: point-cloud annotation in Unity using Quest Pro eye tracking,
  hand/controller rays, bounding boxes, PCL-backed point operations, labels, and
  experiment counters.
- Code donor value: C# wrapper over a native PCL plugin, controller/eye mode
  switch, cone/radius selection parameters, bounding-box point search, label
  colors, undo/redo counters, and point-cloud save/load calls.
- Product reference value: strong reference for research-grade VR annotation
  tools where interaction method, label provenance, and export matter as much as
  visualization.
- Architecture pattern: Unity UI/input layer plus native point-cloud plugin for
  heavy PCD load/save/search operations.
- Reusable method: `VR point-cloud annotation bridge`.
- UX/product lesson: support multiple annotation modes because eye, controller,
  and box workflows have different precision and fatigue tradeoffs.
- Caveats: requires Oculus XR, Oculus Integration, Quest Link eye tracking,
  Unity Movement, URP, and a locally built C++/PCL DLL.
- Source evidence: README documents controller/eye/box modes and PCL build;
  `PointCloudGenerator.cs` imports `rviz_cloud_annotation_plugin` functions for
  load/save, labels, point searches along rays, and points-in-box; interaction
  scripts manage eye/controller rays and menu label colors.
- Reusable core: dataset slot, native point-cloud adapter, mode-specific ray
  parameters, label palette, hover/selection materials, box search, undo/redo,
  save/export.
- What not to copy: hard dependency on one native DLL shape, editor-only setup
  assumptions, and undocumented study metrics without schema.
- Method catalog action: add a scientific VR annotation method.
- What to inspect next: compare with other point-cloud annotation repos for file
  formats, experiment logging, and privacy/provenance.

### `newgen211/Vr-axion`

- Interesting idea: manual neuron tracing over a stack of image slices rendered
  as transparent quads, with raycast point placement, move/connect modes, undo,
  and JSON export.
- Code donor value: `StackRenderer`, `RaycastDraw`, `AnnotationConfig`,
  `SphereAnnotation`, and experimental auto-annotation hooks.
- Product reference value: useful as a small reference for turning 2D scientific
  image stacks into an interactive 3D annotation surface.
- Architecture pattern: image slices become z-spaced quads with a parent collider;
  raycast tools create spheres and line renderers; annotations export to JSON.
- Reusable method: `slice-stack raycast annotation`.
- UX/product lesson: scientific tracing tools need explicit modes for draw, move,
  annotate, connect, undo, and export.
- Caveats: repo includes generated Unity folders such as `Library`, uses
  keyboard/mouse controls despite VR positioning, and lacks robust dataset
  metadata/versioning.
- Source evidence: README explains stack rendering and tracing; `StackRenderer.cs`
  creates textured quads and collider bounds; `RaycastDraw.cs` validates hits by
  texture brightness, creates spheres/connections, moves points, toggles labels,
  and writes `annotations.json`.
- Reusable core: slice importer, z-spacing, raycast validation against image
  pixels, point/connection graph, edit modes, JSON export, configurable thresholds.
- What not to copy: committed Unity cache, hard-coded keyboard controls, and
  exports without coordinate-space provenance.
- Method catalog action: add a scientific VR annotation method.
- What to inspect next: convert the mode model to XR controller/hand input and add
  coordinate-space metadata to exports.

## Reusable Pattern Extraction

- Pattern candidate: `scientific spatial annotation workbench`.
- Problem solved: scientific datasets need in-headset selection, labeling,
  tracing, and export, not just rendering.
- Reusable core: dataset adapter, spatial rendering proxy, mode controller,
  input adapters, selection volume/ray, label palette, editable annotation graph,
  undo/redo, metrics, and export schema.
- Source evidence: `vr_hand_gaze_annotation` supplies point-cloud/native-plugin
  depth; `Vr-axion` supplies slice-stack/tracing simplicity.
- Abstraction boundary: annotation schema and interaction modes are reusable;
  dataset-specific native plugins and study assets should be replaceable.

## Follow-Up Gaps

- Define a neutral `spatial-annotation.json` schema with coordinate frames,
  labels, source dataset id, confidence, and user/session metadata.
- Compare eye-gaze, controller ray, hand pinch, and bounding-box selection for
  accuracy and fatigue.
