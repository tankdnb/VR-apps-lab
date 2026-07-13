# Wave 456: BIM/IFC viewer kernels for spatial review tools

- Date: `2026-07-13`
- Scope: browser BIM/IFC viewers, model property inspection, measurements,
  sectioning, project lists, and WebGL/Three.js viewer kernels that can inform
  future XR spatial review utilities.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `ThatOpen/web-ifc-viewer` | Studied | IFC.js viewer kernel and export tools |
| `xeokit/xeokit-bim-viewer` | Studied | BIM review app shell with tools/explorers |
| `aothms/BIMsurfer` | Studied | BIMServer/glTF viewer lineage |
| `thingraph/bim-viewer` | Studied | Vue/Three BIM project browser |

## Why this wave matters

`VR-apps-lab` already tracks immersive data and point-cloud tools, but BIM/IFC
review adds a different reusable shape: property trees, storeys, classes,
measurements, clipping, model lists, object queries, and import/export
boundaries. These are useful if a future VR utility needs to review industrial,
architectural, or scanned spaces rather than just render them.

## Project notes

### `ThatOpen/web-ifc-viewer`

- Interesting idea:
  compact IFC viewer API that bundles context, IFC loading, clipping, floor
  plans, dimensions, grid/axes, selection windows, glTF/PDF/DXF export, and
  edge projection behind one facade.
- Code donor value:
  strong donor for a `viewer services` facade where future VR review tools can
  treat load/select/clip/measure/export as named services.
- Product reference value:
  shows a practical way to keep model inspection tools discoverable without
  exposing raw loader internals to the app shell.
- Source evidence:
  `viewer/src/ifc-viewer-api.ts`, `viewer/src/components/ifc/*`,
  `viewer/src/components/display/plans/*`,
  `viewer/src/components/selection/*`, and
  `viewer/src/components/import-export/*`.
- Reusable core:
  viewer context, model manager, property/spatial-structure access, selection
  manager, clipping manager, plan/storey manager, dimensions, export writers,
  and wasm-path/deployment caveat.
- What not to copy:
  deprecated API surface, Dropbox-specific loading, old package lock state, or
  IFC.js deployment assumptions without version pinning.
- What to inspect next:
  selector event flow, property cache behavior, section/fill rendering, and
  edge projection output shape.

### `xeokit/xeokit-bim-viewer`

- Interesting idea:
  full BIM review shell with explorer tabs for models, objects, classes, and
  storeys, plus toolbar actions for fit/reset/first-person/orthographic,
  hiding, selection, sectioning, measurements, and property inspection.
- Code donor value:
  excellent donor for review-tool UX decomposition: `Server`, `Controller`,
  `BIMViewer`, explorers, toolbar tools, context menus, and measurement
  plugins are separated enough to reuse conceptually.
- Product reference value:
  demonstrates a mature "professional utility" vocabulary that future VR
  spatial review tools should expose: model inventory, object tree, classes,
  storeys, properties, sections, and measurements.
- Source evidence:
  `src/BIMViewer.js`, `src/Controller.js`, `src/server/Server.js`,
  `src/toolbar/*`, `src/inspector/PropertiesInspector.js`, and
  `src/webComponent/webComponent.js`.
- Reusable core:
  model/server abstraction, tabbed explorers, toolbar mode controllers,
  measurement context menus, hide/select/section modes, busy modal, localization
  labels, and web-component embedding path.
- What not to copy:
  CSS/FontAwesome-heavy DOM templates directly, SDK-locked implementation
  details, or default performance thresholds without validation.
- What to inspect next:
  model tree schemas, BCF viewpoint use, object KD-tree/collision helpers, and
  embedded viewer configuration.

### `aothms/BIMsurfer`

- Interesting idea:
  early WebGL BIM viewer lineage with BIMServer login/revision loading,
  API-based model loading, glTF loading, metadata rendering, static tree
  rendering, notifier, and event forwarding.
- Code donor value:
  useful as lineage reference for server-backed BIM review: async login,
  revision resolution, model id mapping, geometry loader, and metadata tree are
  explicit.
- Product reference value:
  shows why review utilities need both local-file and server-backed model
  paths, especially for enterprise/project repositories.
- Source evidence:
  `bimsurfer/src/BimSurfer.js`, `bimsurfer/src/BimServerModel.js`,
  `bimsurfer/src/BimServerGeometryLoader.js`, `bimsurfer/src/MetaDataRenderer.js`,
  `bimsurfer/src/StaticTreeRenderer.js`, and `demo/*`.
- Reusable core:
  load-source switch, BIMServer API adapter, revision/project lookup, id mapping
  between GUID and viewer id, geometry loader, metadata renderer, tree renderer,
  and camera/selection event bridge.
- What not to copy:
  old RequireJS/xeogl stack, hard-coded BIMServer version assumptions, or demo
  credentials/setup style.
- What to inspect next:
  metadata tree shape, preload query strategy, and GUID/id mapping lifecycle.

### `thingraph/bim-viewer`

- Interesting idea:
  Vue/Three project browser that separates sample projects, custom projects,
  project services, upload flow, public config, and bundled IFCLoader/web-ifc
  assets.
- Code donor value:
  useful for project-list and upload UX around a viewer kernel rather than the
  rendering kernel itself.
- Product reference value:
  shows a small but important product layer: spatial review utilities often need
  project cards, sample data, custom uploads, delete paths, and split-method
  configuration before the headset view begins.
- Source evidence:
  `src/views/projects/Projects.tsx`, `src/service/project.ts`,
  `src/core/ProjectManager*`, `public/config/projects.json`,
  `public/three/js/libs/ifc/IFCLoader.js`, and `public/config/base.json`.
- Reusable core:
  project registry, sample/custom separation, upload form data, model split
  setting, service interceptor, local config files, and viewer asset bundle.
- What not to copy:
  bundled wasm/vendor files, placeholder create-project warning, or sample
  assets as product data.
- What to inspect next:
  `ProjectManager` persistence model, split-method semantics, and model viewer
  route handoff.

## Reusable pattern extraction

- Pattern candidate:
  `spatial model review kernel`.
- Problem solved:
  make large structured spatial models reviewable through explicit services for
  load, select, classify, inspect, measure, section, export, and project
  switching.
- Reusable core:
  model descriptor, loader/wasm path, scene context, object id map, property
  tree, class/storey explorer, selection controller, measurement tools,
  clipping/section tools, export adapters, project registry, busy/progress UI,
  and deployment/version labels.
- Abstraction boundary:
  model loader owns file/server ingestion; viewer kernel owns scene/object ids;
  tool controllers own selection/measurement/section actions; project shell owns
  sample/custom/upload lifecycle.
- Method catalog action:
  create a new method for spatial model review kernels.

## Caveats

- These projects are not VR apps by themselves; their value is as model-review
  substrate for future immersive utilities.
- WebAssembly/vendor asset deployment and large-model performance must be
  treated as explicit product constraints.
- Enterprise BIM terms such as storeys, classes, properties, viewpoints, and
  BCF should be translated carefully for VR users.

