# VR Projects Wave 149: Immersive Analytics, Spatial Data Visualization, and Scientific Viewer Substrates

- Date: `2026-06-05`
- Goal: study data-rich VR/WebXR visualization projects as reusable references
  for diagnostics, telemetry, scientific inspection, and analytics surfaces.

## Why this wave exists

`VR-apps-lab` has many references for overlays, input, runtime helpers, and
media surfaces. It also needs patterns for showing complex information in VR:
graphs, selections, filters, volumes, scientific structures, and session state.
This wave looks at data visualization as a utility substrate.

## Better workflow used in this wave

1. searched by immersive analytics, WebXR data visualization, A-Frame graph,
   scientific WebGL viewer, and notebook 3D visualization families;
2. deduplicated against prior browser/WebXR utility waves;
3. froze a shortlist across grammar compiler, graph scene shell, graph
   component, scientific plugin viewer, and notebook widget bridge references;
4. inspected local-only source clones;
5. extracted reusable methods without running, building, installing, or
   launching the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `vriajs/vria` | Immersive analytics grammar and spatial view compiler |
| `vasturiano/3d-force-graph-vr` | WebVR/WebXR graph scene shell with ray interaction |
| `vasturiano/aframe-forcegraph-component` | A-Frame force graph component and accessor schema |
| `molstar/molstar` | Scientific viewer plugin shell with XR support and snapshots |
| `widgetti/ipyvolume` | Notebook-to-WebGL 3D visualization bridge |

## Deep-pass notes by project

## `vriajs/vria`

- GitHub:
  [vriajs/vria](https://github.com/vriajs/vria)
- What it is:
  a React/A-Frame immersive analytics library driven by a visualization
  configuration grammar.
- Interesting idea:
  compile a declarative data visualization config into spatial views, axes,
  legends, marks, filters, and selection callbacks.
- Code-level notes:
  `src/index.js` exposes a React `VRIA` component that uses reducer state,
  compiles JSON config through `compileVisConfig`, supports `setSelection`,
  `setFilters`, `onSelection`, `onFilter`, `onConfigParsed`,
  `additionalFilters`, and `customMarks`, then maps compiled views into
  A-Frame entities. `src/grammar/compileVisConfig.js` validates and normalizes
  view definitions, parses datasets, infers defaults, resolves mark type,
  shape, tooltip, encoding scales, ranges, schemes, `nice`, and `zero`.
  `src/components/core/View/index.js` places each view at configured spatial
  coordinates, applies rotation and user-height offsets, and renders legends,
  axes, axis filters, and marks. The builder UI exposes field/channel/mark
  forms for constructing configs.
- Architecture pattern:
  declarative immersive analytics grammar plus compiler plus A-Frame view
  renderer.
- Reusable method:
  keep data-view configuration, selection/filter state, and spatial rendering
  separated so a utility can recompile views without rewriting scene code.
- Code donor value:
  high for config grammar, selection/filter callbacks, and spatial chart
  construction.
- Product reference value:
  high for VR dashboards, telemetry views, and data-rich diagnostics.
- Constraints and caveats:
  analytics grammar reuse requires careful downscoping for small utility
  tools.
- What to inspect next:
  map the grammar shape onto runtime diagnostics data such as devices,
  batteries, frame timing, tracker state, or event logs.

## `vasturiano/3d-force-graph-vr`

- GitHub:
  [vasturiano/3d-force-graph-vr](https://github.com/vasturiano/3d-force-graph-vr)
- What it is:
  a VR wrapper around a 3D force graph built with A-Frame and Kapsule.
- Interesting idea:
  package a data graph as a full XR scene shell with camera, controllers,
  cursor/raycasters, tooltip, and graph methods.
- Code-level notes:
  `src/3d-force-graph-vr.js` wraps an A-Frame forcegraph component and exposes
  props for graph data, dimensions, DAG settings, node/link accessors, object
  overrides, arrows, particles, force engine, warmup/cooldown, and callbacks.
  It creates an embedded A-Frame scene, sky, camera group with movement
  controls, camera-attached tooltip/subtooltip, mouse cursor, and left/right
  laser raycasters targeting `[forcegraph]`. Raycasting can be disabled when
  no interaction props are registered. Methods pass through to the inner graph,
  including bounding box, particle emission, d3 force access, reheating, and
  refresh.
- Architecture pattern:
  graph component plus self-contained XR scene shell.
- Reusable method:
  expose graph interactions as node/link callbacks while hiding the scene and
  controller wiring inside a wrapper.
- Code donor value:
  medium-high for controller/mouse raycaster integration around data graphs.
- Product reference value:
  high for quick graph dashboards and relationship maps.
- Constraints and caveats:
  the shell is optimized for force graphs, not general chart composition.
- What to inspect next:
  compare tooltip placement and raycaster activation with overlay data panels.

## `vasturiano/aframe-forcegraph-component`

- GitHub:
  [vasturiano/aframe-forcegraph-component](https://github.com/vasturiano/aframe-forcegraph-component)
- What it is:
  an A-Frame component wrapper around `three-forcegraph`.
- Interesting idea:
  define data graph behavior as an A-Frame schema of data accessors and
  callbacks, then let normal A-Frame raycasters drive hover and click.
- Code-level notes:
  `src/index.js` registers a `forcegraph` component with schema fields for
  `jsonUrl`, nodes, links, dimensions, DAG mode, node/link accessors, visuals,
  particles, and callback functions. Parsers support JSON/function/accessor
  values. Initialization creates camera-attached loading/info text, retains
  camera references, listens for `camera-set-active`, creates a
  `ThreeForceGraph`, binds it to `object3D`, tracks `raycaster-intersected`
  details, and dispatches click events to node/link handlers.
- Architecture pattern:
  data component schema plus raycaster-driven hover/click.
- Reusable method:
  make a data visualization component configurable by accessor names/functions
  so it can be reused across different data shapes.
- Code donor value:
  high for accessor schema and A-Frame raycaster interaction.
- Product reference value:
  medium-high for small graph panels inside browser VR tools.
- Constraints and caveats:
  function parsing is powerful but needs safe boundaries if reused in a public
  utility.
- What to inspect next:
  compare accessor schemas with `vria` encoding channels.

## `molstar/molstar`

- GitHub:
  [molstar/molstar](https://github.com/molstar/molstar)
- What it is:
  a large molecular/scientific visualization platform with plugin state,
  commands, managers, snapshots, Canvas3D, and XR support.
- Interesting idea:
  treat a complex viewer as a plugin shell whose managers own state,
  interaction, rendering, selection, labels, tasks, snapshots, and XR input.
- Code-level notes:
  `src/mol-plugin/context.ts` defines a `PluginContext` that owns config,
  state, commands, Canvas3D, layout, animation loop, representation registries,
  query/data formats, builders, helpers, managers for structure hierarchy,
  components, measurement, selection, focus, volume hierarchy, camera,
  animation, snapshots, labels, tasks, drag/drop, and behavior/events for
  busy, hover, click, drag, key, labels, layout, and canvas init.
  `src/mol-canvas3d/canvas3d.ts` includes parameters for camera mode, stereo,
  FOV, clipping, viewport, reset duration, postprocessing, marking, renderer,
  trackball, pointer, and XR manager params. `src/mol-canvas3d/helper/xr-manager.ts`
  manages WebXR session support, reference spaces, passthrough toggle, scale
  factor, controller target rays, viewer pose, stereo cameras, gesture scale,
  and mapping XR input sources into pointer/input observers. `src/mol-plugin/state.ts`
  captures and restores snapshots of data, behavior, animation, camera,
  Canvas3D, interactivity, structure focus, selection, and component options.
- Architecture pattern:
  plugin context plus managers plus command/state/snapshot bus plus XR input
  mapper.
- Reusable method:
  design scientific and diagnostics viewers around restorable state snapshots
  and named managers rather than one monolithic render loop.
- Code donor value:
  very high for snapshot, manager, command, and XR input mapping architecture.
- Product reference value:
  high for serious inspection tools that need reproducibility and session
  restoration.
- Constraints and caveats:
  much too large to copy directly; useful patterns should be extracted as
  small architecture notes.
- What to inspect next:
  compare Mol* snapshots with runtime capture/replay and no-HMD diagnostics
  families.

## `widgetti/ipyvolume`

- GitHub:
  [widgetti/ipyvolume](https://github.com/widgetti/ipyvolume)
- What it is:
  a Jupyter widget system for interactive 3D plotting, scatter, mesh, and
  volume visualization.
- Interesting idea:
  bridge Python-side scientific data into a browser/WebGL 3D viewer using
  synced widget traits and serialization helpers.
- Code-level notes:
  `ipyvolume/widgets.py` defines Python traitlet models for scatter and volume
  data, syncing arrays, scales, selection, hover, click, geometry, textures,
  material, volume clamp ranges, opacity, brightness, transfer functions, ray
  steps, render method, lighting, extents, and clipping. `ipyvolume/serialize.py`
  handles image/texture serialization and volume tiling, including cube-to-tile
  and PNG/JSON volume conversion. `js/src/figure.ts` builds the Three renderer,
  toolbar, fullscreen, stereo, screenshot, camera controls, selection modes,
  popup, scene, camera, controls, shaders, scatter/mesh/volume models, and
  stereo/panorama/cube settings. `js/src/embed.ts` exports models and views for
  standalone embed bundles.
- Architecture pattern:
  Python traitlet data model plus JS WebGL view plus texture/data serializers.
- Reusable method:
  treat notebooks as data producers and the VR/WebGL surface as a synced
  inspection client.
- Code donor value:
  high for volume tiling, trait sync, and embed architecture.
- Product reference value:
  medium-high for research workflows where VR diagnostics consume analysis
  data generated elsewhere.
- Constraints and caveats:
  notebook widget assumptions are different from standalone VR utilities.
- What to inspect next:
  test conceptually against telemetry logs and captured pose/session data.

## Cross-project synthesis

This wave splits the data-surface problem into five layers:

- `vria` compiles declarative analytics configs into spatial views;
- `3d-force-graph-vr` packages graph data as a ready XR scene;
- `aframe-forcegraph-component` exposes graph behavior as an A-Frame component;
- `Mol*` shows how a serious viewer manages state, snapshots, and XR input;
- `ipyvolume` shows how notebook/scientific data reaches browser 3D.

For `VR-apps-lab`, the strongest reusable direction is a small diagnostics
visualization substrate with:

- declarative data view specs;
- explicit selection/filter callbacks;
- accessor schemas for graph-like data;
- snapshot/restoration of viewer state;
- optional notebook or offline-data import paths.

## Methods extracted

- Immersive analytics grammar compiler with spatial views and selection/filter
  callbacks.
- A-Frame graph visualization component with accessor schema and raycaster
  hover/click.
- Scientific viewer plugin shell with managers, command bus, snapshots, and XR
  input mapping.
- Notebook-to-WebGL volume/data widget bridge with trait sync and texture
  tiling.

## New gaps opened

- Create a `diagnostic visualization grammar` note for future VR utility data.
- Compare graph ray interactions with overlay pointer/cursor systems.
- Track state snapshots as a candidate pattern for VR session diagnostics and
  reproducible bug reports.
