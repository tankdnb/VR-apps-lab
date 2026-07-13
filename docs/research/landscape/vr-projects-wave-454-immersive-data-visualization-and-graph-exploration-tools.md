# Wave 454: Immersive data visualization and graph exploration tools

- Date: `2026-07-13`
- Scope: VR/XR data visualization, graph exploration, and educational data
  structure visualization tools.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `ronellsicat/DxR` | Studied | Immersive visualization grammar/toolkit |
| `molgenis/Graph2VR` | Studied | VR graph/SPARQL exploration tool |
| `VRcheology/VRcheology.github.io` | Studied | Data-backed educational archaeology VR visualization |
| `detjonmataj/Data-Structure-and-Algorithms-Visualization-in-VR` | Studied | Educational algorithm/data-structure visualization |

## Why this wave matters

The repository already has CAD, annotation, and scientific tooling families.
This wave adds a more general product line: VR as a data exploration surface
with data bindings, graph operations, visual query construction, spatial
layouts, educational reveal flows, and domain-specific dataset caveats.

## Project notes

### `ronellsicat/DxR`

- Interesting idea:
  Unity package for immersive visualizations where visual properties such as
  position, color, size, and mark choice can be mapped to data attributes by a
  runtime GUI or a concise JSON/programming interface inspired by Polestar and
  Vega-Lite.
- Code donor value:
  strong conceptual donor for data-to-mark/channel schemas, extensible custom
  marks, and runtime visualization authoring.
- Product reference value:
  shows VR visualization as a grammar-driven authoring system rather than a
  one-off scene.
- Source evidence:
  `README.md`, `docs/assets/*`, package structure under `Assets`, and examples
  describing JSON specs and interactive visualization generation.
- Reusable core:
  dataset record, mark type, channel mapping, runtime GUI, high-level spec,
  generated Unity objects, and extensibility hooks.
- What not to copy:
  research prototype assumptions or custom data format choices without a fresh
  schema review.
- What to inspect next:
  exact visualization spec format, mark/channel implementation, and whether the
  runtime GUI can inform `VR-apps-lab` utility dashboards.

### `molgenis/Graph2VR`

- Interesting idea:
  Unity VR application for exploring Linked Data/SPARQL graphs with node
  expansion, incoming/outgoing predicates, deletion/collapse, side-by-side
  comparison, visual query patterns, search, layout algorithms, and N-Triples
  save/export.
- Code donor value:
  useful reference for graph operation vocabulary, SPARQL endpoint settings,
  layout algorithm selection, persistent settings files, and Quest/Windows
  packaging differences.
- Product reference value:
  strong product branch for data-heavy VR utilities: query, inspect, compare,
  save, and recover graph state.
- Source evidence:
  `README.md`, `Graph2VR User manual (version 1.0.0).pdf`,
  `Assets/*`, `unityProject.vrmanifest`, and settings-file documentation.
- Reusable core:
  endpoint descriptor, starting query, graph node/edge records, expansion
  actions, visual query builder, layout selector, save/export path, and
  headset file-location instructions.
- What not to copy:
  LGPL code into incompatible components, educational Unity binary assumptions,
  or SPARQL-only domain constraints unless that is the target.
- What to inspect next:
  node/edge data model, layout implementations, query builder UI, and
  save-state schema.

### `VRcheology/VRcheology.github.io`

- Interesting idea:
  educational VR archaeology visualization that pulls from a real data source
  and turns provenience/artifact data into an explorable excavation world.
- Code donor value:
  mostly product/UX reference, with useful framing around data-backed discovery
  and reveal/excavation metaphors.
- Product reference value:
  shows how domain datasets can become lightweight VR learning/exploration
  utilities.
- Source evidence:
  `README`, `index.html`, `js/*`, `Assets/*`, and data/UI screenshots.
- Reusable core:
  domain dataset source, spatial placement from metadata, interaction metaphor,
  artifact reveal, explanatory UI, and domain provenance labels.
- What not to copy:
  hackathon-era code, old Unity/Web stack assumptions, or domain assets.
- What to inspect next:
  data fetch/parsing flow and artifact metadata schema.

### `detjonmataj/Data-Structure-and-Algorithms-Visualization-in-VR`

- Interesting idea:
  Quest-oriented Unity learning project that visualizes data structures and
  algorithms in VR.
- Code donor value:
  thin but useful as an educational visualization reference with scene/menu
  separation, prefabs, labels, path/line assets, and Oculus/XR settings.
- Product reference value:
  confirms that learning utilities need staged scenes, explanation labels, and
  simple spatial primitives more than heavy runtime infrastructure.
- Source evidence:
  `README.md`, `Assets/Scenes/MainMenu.unity`,
  `Assets/Scenes/AnimationScene.unity`, `Assets/Prefab/*`, and Oculus/XR
  settings assets.
- Reusable core:
  topic selector, algorithm state steps, spatial node/edge prefabs, text labels,
  replay/animation scene, and Quest support labels.
- What not to copy:
  bundled platform assets or course-specific content.
- What to inspect next:
  per-algorithm step representation and animation controller structure.

## Reusable pattern extraction

- Pattern candidate:
  `immersive data visualization grammar`.
- Problem solved:
  let VR utilities map structured data to spatial marks, graphs, labels, and
  operations instead of hard-coding every visualization as a scene.
- Reusable core:
  dataset descriptor, schema fields, mark/channel mapping, layout algorithm,
  interaction verbs, query/search, compare, save/export, provenance, and
  domain-specific explanation panels.
- Abstraction boundary:
  data provider owns raw records; visualization grammar owns mapping; VR layer
  owns spatial layout and interaction; export layer owns reusable outputs.
- Method catalog action:
  create a new method for immersive data visualization grammars.

## Caveats

- Some projects are research prototypes or educational demos with asset-heavy
  Unity projects.
- Licenses, dataset provenance, and third-party data terms matter more than
  usual in visualization tools.
- Domain-specific metaphors are valuable, but should not be mistaken for a
  universal visualization model.

