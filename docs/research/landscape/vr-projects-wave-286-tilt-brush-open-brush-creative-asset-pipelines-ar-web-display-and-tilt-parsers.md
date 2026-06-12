# Wave 286 - Tilt Brush/Open Brush Creative Asset Pipelines, AR/Web Display, and Tilt Parsers

This wave studies Tilt Brush/Open Brush adjacent projects as reusable
references for creative XR asset pipelines: stroke capture, `.tilt` parsing,
brush metadata, geometry export, lightweight viewers, AR drawing baselines, web
display, and public archive/provenance handling.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Tilt Brush/Open Brush file and geometry conversion;
- AR drawing and stroke capture baselines;
- web/Processing/Unity display surfaces for sketches and exported geometry;
- Poly/Tilt archive and provenance references;
- brush, control-point, material, and metadata boundaries.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `weeeBox/TiltBrushFile` | `.tilt` parser and writer | Studied | Binary header, zipped sketch data, strokes, control points, metadata, thumbnail |
| `MrMMu/tiltbrushfbxexport` | Tilt JSON to FBX exporter | Studied with legacy caveats | Mesh grouping, brush metadata, FBX layers, vertex colors, export metadata |
| `FusedVR/ARKitTiltBrush` | AR painting baseline | Studied | ARFrame camera-position strokes, particle-based painting, color/reset modes |
| `dogtownmedia/ARKit-SceneKit-Paint-Tiltbrush-Demo` | SceneKit AR drawing baseline | Studied | ARSCNView line nodes, color picker, session interruption hooks |
| `thijsvb/TiltBrushDisplay` | Processing OBJ display micro-viewer | Studied | Minimal OBJ/shader rotation viewer for exported brush geometry |
| `arodic/polygone.art` | Poly archive/provenance catalog | Studied as archive reference | Salvaged asset catalog, CC-BY framing, torrent/split archive distribution |
| `keijiro/Forestica` | Unity Tilt Brush scene render reference | Studied with asset-heavy caveat | Materials/post-processing/render setup around a Tilt Brush artwork |
| `PushyPixels/WebVR-Poly-Framework` | Unity Poly/WebVR framework | Studied with package caveats | Poly asset browser/import direction and WebVR presentation framing |

## Code-Level Findings

### `weeeBox/TiltBrushFile`

- Interesting idea:
  `.tilt` is handled as a structured archive with a binary header and zipped
  sketch payload rather than as an opaque asset blob.
- Code donor value:
  very high: `TBFile.cs` reads/writes the header, extracts `thumbnail.png`,
  `data.sketch`, and `metadata.json`, parses brush strokes, clones data, and
  writes a new archive; `TBBrushStroke.cs` exposes brush index, color, size,
  flags, and control points.
- Product reference value:
  high for creative asset browsers, validators, converters, and sketch
  inspection tools.
- What to inspect next:
  `TBControlPoint`, version handling, brush GUID mapping, temp-directory
  safety, and metadata schema compatibility with Open Brush.

### `MrMMu/tiltbrushfbxexport`

- Interesting idea:
  Tilt Brush JSON exports are converted to FBX while preserving per-brush mesh
  grouping, vertex colors, normals, UVs, tangents, and extra metadata.
- Code donor value:
  high with legacy caveats: `mm_geometry_json_to_fbx.py` uses Tilt Brush
  `iter_meshes`, merges by brush or stroke, writes FBX layer data, creates
  Lambert materials, records brush GUID/name and mesh arrays, and emits sidecar
  export metadata.
- Product reference value:
  high for offline conversion flows and for understanding what asset metadata
  should survive export.
- What to inspect next:
  Python/FBX SDK versioning, Open Brush native exporter overlap, brush shader
  restoration, and license/provenance handling.

### `FusedVR/ARKitTiltBrush`

- Interesting idea:
  AR drawing can be expressed as camera-forward sampled points that become
  particle systems, making it a compact baseline for stroke capture and
  immediate visual feedback.
- Code donor value:
  medium: `PaintManager.cs` and `ParticlePainter.cs` subscribe to
  `ARFrameUpdatedEvent`, sample camera position plus forward offset, threshold
  point distance, instantiate particle systems, manage color and reset state,
  and expose simple modes.
- Product reference value:
  medium/high for fast XR sketch prototypes and "paint from tracked device"
  interaction primitives.
- What to inspect next:
  modern ARFoundation migration, stroke persistence, pressure/width input, and
  conversion from particle points to reusable geometry.

### `dogtownmedia/ARKit-SceneKit-Paint-Tiltbrush-Demo`

- Interesting idea:
  SceneKit line nodes provide a minimal AR stroke UX with color picker support
  and explicit AR session interruption hooks.
- Code donor value:
  medium: `ViewController.swift` runs an AR world-tracking session, creates
  line geometry between previous and current camera positions while a button is
  highlighted, and delegates color selection.
- Product reference value:
  medium for minimal mobile AR drawing and session-state UI behavior.
- What to inspect next:
  `SCNNode` line extension, stroke storage, interruption recovery, and how
  color/brush settings are persisted.

### `thijsvb/TiltBrushDisplay`

- Interesting idea:
  a tiny Processing viewer can make exported OBJ brush geometry inspectable
  with rotation, axis display, and a shader hook.
- Code donor value:
  low/medium: `objDisplayer.pde` is small but useful as a minimal "geometry
  preview" baseline around `loadShape`, shader application, rotation, and axis
  labels.
- Product reference value:
  medium for quick validators and preview tools where full Unity/WebXR is too
  heavy.
- What to inspect next:
  texture/material handling, multi-object loads, camera controls, and whether
  brush-specific shaders can be previewed cheaply.

### `arodic/polygone.art`

- Interesting idea:
  a dead platform's public 3D asset collection is preserved as a searchable web
  archive with license/provenance language and downloadable split/torrent
  payloads.
- Code donor value:
  low for XR runtime code, but useful for archive metadata and public
  preservation framing.
- Product reference value:
  high for asset-catalog provenance, license notices, and "public archive, not
  vendor service dependency" framing.
- What to inspect next:
  `assets/*/data.json` schema, thumbnail/model paths, author credit fields,
  and whether query/search metadata can inform a VR asset browser.

### `keijiro/Forestica`

- Interesting idea:
  a Tilt Brush artwork can be treated as a render/lighting/material package,
  showing that creative-asset reuse needs shader and postprocess restoration,
  not just geometry import.
- Code donor value:
  low/medium in this pass because the repository is asset-heavy, but the
  material/postprocessing layout is a useful render reference.
- Product reference value:
  medium for "preserve the look" pipelines around exported brush art.
- What to inspect next:
  material assignments, shader dependencies, render pipeline assumptions, and
  how brush visuals degrade without original shaders.

### `PushyPixels/WebVR-Poly-Framework`

- Interesting idea:
  Poly/WebVR style presentation can be framed as an import/browse/display
  workflow rather than only a static model viewer.
- Code donor value:
  medium with package caveats: the repository contains PolyToolkit editor
  asset-browser code and WebVR/Unity presentation assets, but much of the
  inspected value is framework/vendor payload.
- Product reference value:
  medium/high for asset browsing UX and WebVR presentation framing.
- What to inspect next:
  `AssetBrowserManager.cs`, Poly API assumptions, import cache behavior, and
  how to replace the dead service boundary with archive/local sources.

## Reusable Pattern Extraction

- Pattern candidate:
  creative XR asset pipeline across stroke capture, file parsing, conversion,
  display, and provenance.
- Problem solved:
  creative VR sketches and 3D assets are useful only if tools can preserve
  stroke structure, brush identity, metadata, thumbnails, materials, export
  formats, and license/provenance across viewers and engines.
- Reusable core:
  stroke/control-point schema, brush index/GUID/name/color/size metadata,
  archive reader/writer, thumbnail and metadata sidecars, geometry exporter,
  material/shader restoration, lightweight preview surface, AR/WebXR viewer,
  asset catalog schema, author/license fields, and provenance warnings.
- Source evidence:
  `TiltBrushFile`, `tiltbrushfbxexport`, `ARKitTiltBrush`,
  `ARKit-SceneKit-Paint-Tiltbrush-Demo`, `TiltBrushDisplay`,
  `polygone.art`, `Forestica`, and `WebVR-Poly-Framework`.
- Abstraction boundary:
  keep authoring capture, file parsing, export, preview, shader/material
  restoration, catalog metadata, and license/provenance policy separate.
- What not to copy:
  obsolete Poly service assumptions, legacy FBX SDK pinning, temp extraction
  without cleanup, asset archives without credit paths, or particle strokes as
  final geometry without conversion.
- Method catalog action:
  add a creative XR asset pipeline method.

## Follow-Up Gaps

- Build a Tilt/Open Brush creative asset matrix across `.tilt` parsing, stroke
  control points, brush IDs, geometry export, shader/material restoration,
  AR/Web display, Poly archive metadata, and provenance/license gates.
- Deepen `weeeBox/TiltBrushFile` as the strongest `.tilt` parsing donor.
- Deepen `MrMMu/tiltbrushfbxexport` for export metadata and brush grouping,
  while treating it as legacy.
- Explore whether `polygone.art` metadata can support a VR-native asset
  browser with explicit license and author display.
