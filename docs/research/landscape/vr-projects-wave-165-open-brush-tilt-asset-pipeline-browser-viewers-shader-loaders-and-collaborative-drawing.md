# VR Projects Wave 165: Open Brush, Tilt Asset Pipeline, Browser Viewers, Shader Loaders, and Collaborative Drawing

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 165 studies the reusable asset and tooling layer around Open Brush and
Tilt Brush: app-state boundaries, external sketch loading, browser viewers,
shader restoration, raw `.tilt` parsing, conversion tools, and collaborative
stroke messages.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `icosa-foundation/open-brush` | Creative VR app and sketch pipeline donor | Strong app/API/export donor |
| `icosa-foundation/gallery-viewer` | Browser creative asset viewer | Strong viewer/metadata donor |
| `icosa-foundation/three-icosa` | Creative export shader loader | Strong material restoration donor |
| `icosa-foundation/three-tiltloader` | Raw sketch file ingestion | Useful compact loader donor |
| `Prystopia/c-sharp-tiltbrush-toolkit` | Creative asset manipulation | Useful programmatic toolkit donor |
| `DrHibbitts/TiltBrushConverter` | Export conversion utility | Useful conversion option donor |
| `Phylliida/P2PDraw` | Collaborative drawing primitive | Useful protocol idea with caveats |

## `icosa-foundation/open-brush`

- Interesting idea:
  evolve Tilt Brush into a broader creative VR platform with OpenXR direction,
  app state, sketch loading, API/Lua/editor tooling, multiplayer surfaces, and
  export utilities.
- Code donor value:
  high for external `.tilt` load handling, app command routing, sketch path
  management, editor generators, brush/export tooling, and app-state boundaries.
- Product reference value:
  high for creative VR tool architecture, not just brush UX.
- What to inspect next:
  deep-read Lua/API generation, command dispatch, panel/menu systems, and
  multiplayer boundaries if a future creative utility prototype needs a host.
- Source evidence:
  `Assets/Scripts/App.cs`, `Assets/Scripts/API/ApiEndpointAttribute.cs`,
  `Assets/Editor/LuaAssetImporter.cs`, `LuaSkillGenerator.cs`,
  `LuaDocsGenerator.cs`, `GlTF_EditorExporter.cs`, and brush editor scripts.
- Reusable pattern extraction:
  external sketch load queue with safe user-sketch copy and command dispatch.
- Reusable core:
  accept outside load requests, copy non-user sketches into a controlled user
  path with collision-safe naming, enqueue the requested sketch, and let the
  normal app load command own scene state.
- Do not copy directly:
  the entire creative app; reuse app-boundary lessons and asset pipeline
  patterns.
- Caveats:
  large Unity codebase and broad product scope.

## `icosa-foundation/gallery-viewer`

- Interesting idea:
  view Open Brush/Tilt exports and other 3D formats in the browser while
  restoring scene metadata, camera, lighting, environment, and XR navigation.
- Code donor value:
  high for format normalization, metadata parsing, XR/desktop controls, and
  environment reconstruction.
- Product reference value:
  high for public creative asset viewers and lightweight immersive galleries.
- What to inspect next:
  compare its metadata restoration with Open Brush export data and decide which
  fields future viewers should preserve.
- Source evidence:
  `src/viewer.ts`.
- Reusable pattern extraction:
  browser creative asset viewer with authoring metadata restoration.
- Reusable core:
  load multiple 3D formats, detect Open Brush/Tilt metadata, convert coordinate
  conventions, replace lights/environment, and expose both desktop navigation
  and XR viewing.
- Caveats:
  browser performance and format-specific shader assets still need careful
  packaging.

## `icosa-foundation/three-icosa`

- Interesting idea:
  restore Open Brush/Tilt material intent in generic Three.js glTF viewers by
  handling brush-specific extensions, material names, shader files, and texture
  fallbacks.
- Code donor value:
  high for glTF extension handling, brush GUID/name mapping, shader loading,
  attribute remapping, and material cache boundaries.
- Product reference value:
  high for web viewers that need exported sketches to look like authoring-tool
  output rather than generic meshes.
- What to inspect next:
  align extension handling with `gallery-viewer` and raw `.tilt` loader paths.
- Source evidence:
  `src/loader/GOOGLE_tilt_brush_material.js` and `src/TiltShaderLoader.js`.
- Reusable pattern extraction:
  format-specific material extension and shader replacement layer.
- Reusable core:
  detect exported brush metadata, map material identifiers to brush assets,
  patch texture URIs, load shaders/includes/textures asynchronously, cache
  materials, and bridge custom attributes into renderer-native geometry.
- Caveats:
  requires brush asset packaging outside the npm package.

## `icosa-foundation/three-tiltloader`

- Interesting idea:
  load raw `.tilt` files directly in Three.js by unzipping the sketch archive
  and parsing stroke binary data into geometry and brush materials.
- Code donor value:
  medium-high for compact file parsing and stroke-to-geometry construction.
- Product reference value:
  medium for quick browser sketch previews without a full conversion step.
- What to inspect next:
  verify mask/offset semantics against Open Brush source before relying on
  exact binary interpretations.
- Source evidence:
  `src/TiltLoader.js`.
- Reusable pattern extraction:
  raw `.tilt` zip/binary stroke loader into renderable geometry.
- Reusable core:
  skip the `.tilt` header, unzip metadata and stroke data, parse brush index,
  color, size, masks, and control points, flip coordinate handedness, build
  stroke geometry, and bind dynamic shader uniforms.
- Caveats:
  some binary mask comments remain uncertain in source.

## `Prystopia/c-sharp-tiltbrush-toolkit`

- Interesting idea:
  treat `.tilt` files as editable data, not only viewer input, by exposing C#
  parse/manipulate/write helpers.
- Code donor value:
  medium for stroke model classes, header/control-point helpers, export parsing,
  and mesh merge utilities.
- Product reference value:
  medium for offline creative asset manipulation.
- What to inspect next:
  compare its write path with Open Brush's current file format and export
  expectations.
- Source evidence:
  `TiltbrushHelper/Export.cs`, control point/header classes, metadata classes,
  and example scripts.
- Reusable pattern extraction:
  programmatic `.tilt` authoring and editing toolkit.
- Reusable core:
  expose strokes, control points, brush identifiers, headers, metadata, and
  mesh exports as typed objects that can be modified and written back.
- Caveats:
  may lag newer Open Brush file variants.

## `DrHibbitts/TiltBrushConverter`

- Interesting idea:
  expose conversion choices for Tilt Brush exports: OBJ/FBX target, merge
  strategy, cooked/raw geometry, backfaces, and GUI progress.
- Code donor value:
  medium for mesh merge/backface rules, FBX/OBJ export scaffolding, and
  option-oriented GUI flow.
- Product reference value:
  medium for creator utility UX around export options.
- What to inspect next:
  translate the converter option model to modern Python/Unity/web pipelines if
  future import/export tools need it.
- Source evidence:
  `convert_to_fbx.py`, `convert_to_obj.py`, `FBXConverterGui.py`, and
  `OBJConverterGui.py`.
- Reusable pattern extraction:
  conversion utility with explicit geometry semantics and progress UI.
- Reusable core:
  separate source discovery, per-stroke/per-brush merge policies, backface
  handling, output writer, and GUI/multiprocessing progress.
- Caveats:
  old Python 2.7 and Autodesk FBX SDK dependency.

## `Phylliida/P2PDraw`

- Interesting idea:
  collaborative VR drawing can be represented as simple stroke segment add and
  remove messages with float-array payloads.
- Code donor value:
  medium for the message protocol and Unity main-thread queueing.
- Product reference value:
  medium as a tiny collaborative drawing concept.
- What to inspect next:
  reimplement the protocol idea with modern networking and modern XR input
  APIs before reuse.
- Source evidence:
  `Draw/Assets/Marker.cs`, `World.cs`, and `UnityP2P/Peer.cs`.
- Reusable pattern extraction:
  collaborative stroke segment add/remove protocol.
- Reusable core:
  assign segment IDs, serialize stroke point arrays, send add/remove messages
  to peers, and replay existing segments to newly joined peers.
- Caveats:
  old Unity VR API, hardcoded signaling, checked-in build/cache artifacts, and
  prototype-level robustness.

## Cross-Project Lessons

- Creative VR assets need a pipeline, not a single viewer.
- Brush shader restoration is a first-class compatibility layer.
- File loaders should preserve authoring metadata, lighting, environment, and
  camera context where possible.
- Collaborative drawing can start from very small protocols, but reliability
  and modern XR input layers should be redesigned.
- Conversion tools should make geometry semantics visible instead of silently
  flattening strokes.

## Reusable Methods Extracted

- External `.tilt` load queue with safe user-sketch copy.
- Browser viewer metadata restoration for creative VR exports.
- Open Brush/Tilt glTF material extension and shader replacement.
- Raw `.tilt` zip/binary stroke loader.
- Programmatic `.tilt` edit/write toolkit.
- Conversion utility with merge/backface option UX.
- Collaborative stroke segment add/remove protocol.

## Follow-Up Backlog

- Build an Open Brush/Tilt asset pipeline map from raw file to web viewer,
  shader restoration, conversion, and collaboration.
- Promote Open Brush API/Lua/editor systems into a deeper reuse plan only if a
  future creative-tool branch needs them.
- Keep old or messy Unity drawing prototypes as protocol references, not code
  baselines.
