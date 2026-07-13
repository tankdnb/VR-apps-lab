# Wave 358: VR Creative Authoring Sculpting Painting Modeling and Content Retrieval Tools

## Scope

This wave studies VR creative tools below the large Open Brush/Tilt ecosystem:
painting palettes, line/tube meshes, sculpting, voxel/SDF modeling, OBJ
import/export, and content-retrieval loops. The reusable lesson is a creative
document pipeline rather than a single brush script.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `eman2XR/Virtual-Studio` | Studied | Unity VR painting/design toolkit with color picker, paint palette, eraser, paint brush, mesh extrusion, grabbable objects, networked brush traces, transform saver, and OBJ exporter |
| `DhruvaRawal/SculpIt` | Studied | Thin sculpt/draw reference with camera-rig spawning and line drawing scripts |
| `johnsandiego/PolySculpt` | Partially studied | Poly/SteamVR sculpting direction for deeper custom script isolation and VRTK-era interaction comparison |
| `not-surt/CarveVR` | Partially studied | Voxel sculpting direction marker; useful for comparing abandoned/minimal sculpting implementations |
| `E-BAO/3D-VR-Painting` | Partially studied | Oculus-era 3D painting direction marker for brush/stroke comparison |
| `Rowl1ng/SketchyVR` | Studied | Sketching pipeline with color manager, line/point managers, mesh line renderer, tube renderer, save sketch logic, OBJ exporter, and OBJ import loader |
| `SamuelBoerlin/3D-VR-Modelling-and-Vitrivr` | Studied | VR sculpting integrated with Vitrivr/Cineast retrieval: CSG/SDF/voxel components, query plates/results, JSON converter, OBJ loader, and API adapter |

## Reusable Pattern Extraction

- Pattern candidate: `VR creative authoring stroke mesh and export pipeline`.
- Problem solved: VR creative tools need to preserve authoring state,
  geometry generation, object manipulation, persistence, and export without
  coupling everything to one scene.
- Reusable core: tool mode, brush/material/color state, stroke generator,
  line/tube/mesh/voxel/SDF backend, grabbable object layer, save/export/import,
  provenance metadata, query/retrieval adapter, undo/reset, and performance
  budgets.
- Source evidence: Virtual-Studio exposes color picker, paint palette, eraser,
  paint brush, mesh extrusion, grabbables, transform saver, and OBJ exporter;
  SketchyVR includes line/point managers, tube renderer, save logic, OBJ export,
  and OBJ import; 3D-VR-Modelling-and-Vitrivr includes sculpting, voxelizer,
  SDF, query result objects, `UnityCineastApi`, and JSON conversion.
- Abstraction boundary: controller/hand input should choose tools and sample
  points; geometry backends should own mesh/voxel output; exporters and
  retrieval services should be adapters.
- What not to copy: asset-store/vendor interaction systems, scene-hardcoded
  save paths, abandoned code without provenance, or export logic without
  material/license metadata.
- Method catalog action: create a new creative authoring method.

## Project Notes

### `eman2XR/Virtual-Studio`

- Interesting idea: Tilt Brush-like painting/design tools are packaged as a
  reusable Unity toolkit with palette, brush, eraser, mesh extrusion, grab, and
  export pieces.
- Code donor value: high for palette/brush/eraser modules, object outlining,
  mesh extrusion, transform saving, and OBJ export boundary.
- Product reference value: strong for creator-facing tools embedded into other
  VR apps.
- What to inspect next: save workflow, networked stroke playback, and brush
  document schema.
- Caveats: old Unity/SteamVR stack and stripped vendor dependencies.

### `Rowl1ng/SketchyVR`

- Interesting idea: sketching combines line/tube rendering with save/export and
  OBJ import rather than only live strokes.
- Code donor value: high for `LineManager`, `MeshLineRenderer`,
  `TubeRenderer`, `SaveSketchLogic`, `ObjExporter`, and OBJ import path.
- Product reference value: strong for a small creative utility shell.
- What to inspect next: stroke persistence format, material/color schema, and
  undo.
- Caveats: likely prototype-grade; needs cleanup before direct reuse.

### `SamuelBoerlin/3D-VR-Modelling-and-Vitrivr`

- Interesting idea: VR sculpting becomes a search interface: sculpt a shape,
  query Cineast/Vitrivr, spawn similar objects, then voxelize or modify results.
- Code donor value: very high for sculpting/voxel/SDF modules, query result UI,
  JSON conversion, OBJ loading, and API adapter split.
- Product reference value: very strong for research and creator tooling.
- What to inspect next: retrieval result schema, server failure handling, and
  asset provenance.
- Caveats: retrieval service dependency and heavier algorithmic code.

### `DhruvaRawal/SculpIt`

- Interesting idea: very small line-drawing and rig-spawn scripts can still
  validate a minimal creative-tool shell.
- Code donor value: low to moderate, useful as a micro-reference.
- Product reference value: useful for showing the lower bound of a drawing
  prototype.
- What to inspect next: stroke storage and interaction affordances.
- Caveats: thin codebase.

## Product Direction

This wave supports a `VR creative workbench` branch: a reusable tool menu plus
stroke/mesh document model, export/import adapters, and optional retrieval or
gallery integration.

