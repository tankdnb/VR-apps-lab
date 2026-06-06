# VR Projects Wave 202: Lightweight XR Editor, Tour-Builder, Live-Coding, and Creator Microtools

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 202 studies small authoring surfaces that sit between "demo" and "full
engine": 360 tour builders, in-headset edit components, node-graph scene tools,
controller templates, VR text/code workspaces, Unity in-VR animation tools,
historical Cardboard voxel editors, and VRChat creator microtools. The reusable
value is interaction and serialization: how users select, manipulate, persist,
export, and safely bridge authoring work across VR and desktop editor contexts.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `Humangle/VRTourEditor` | Browser 360 tour editor and runtime exporter | Strong tour-builder donor |
| `caseyyee/aframe-vreditor-component` | In-headset A-Frame edit component | Interaction primitive donor |
| `wakufactory/GNode` | Visual node graph for geometry/A-Frame entities | Node-graph donor |
| `flushpot1125/WebXR_VRController_Editor_template` | Babylon.js Editor WebXR controller template | Controller binding reference |
| `dkaraush/vrcode` | WebXR text/code workspace | VR text workspace donor |
| `umiyuki/UnityVRAnimationEditor` | Unity in-VR animation editing | Strong Unity authoring donor |
| `evanw/webgl-vr-editor` | Historical Cardboard/WebGL voxel editor | Lightweight editor reference |
| `Reava/VRC-Editor-Toolbox` | Unity/VRChat creator microtools | Production microtool reference |

## `Humangle/VRTourEditor`

- Interesting idea:
  a browser editor builds 360-photo tours as a `.hvrj` JSON graph, places
  teleport/link buttons with desktop or VR ray picking, autosaves to
  localStorage, and exports a zip containing a standalone WebXR runtime player.
- Code donor value:
  high for manifest/export shape, generated runtime, 360 sphere texture
  management, link placement, VR and desktop pickers, autosave, and zip
  packaging.
- Product reference value:
  high for creator-friendly tour-building UX.
- What to inspect next:
  file/import security, asset path hygiene, mobile UX, offline packaging,
  manifest versioning, and controller placement precision.
- Source evidence:
  `editor.js`, `generate-files.js`, `sample/index.js`, and sample `.hvrj`
  assets.
- Reusable pattern extraction:
  serializable 360 tour authoring surface with generated runtime export.
- Reusable core:
  represent scenes as a small manifest, render each panorama into an inside-out
  sphere, place link buttons by ray direction, autosave working state, and
  generate a runtime package that reads the manifest without the editor shell.
- Do not copy directly:
  unvalidated localStorage/import data, fixed CDN/runtime assumptions, or
  project-name-derived DOM ids without sanitation.
- Caveats:
  strong donor for tour/manifest/export patterns.

## `caseyyee/aframe-vreditor-component`

- Interesting idea:
  an A-Frame component makes children editable in VR: controller grip collision
  selects objects, reparenting attaches grabbed objects to the hand, two-hand
  grabbing clones an object, and selected objects can be scaled along axes.
- Code donor value:
  high for minimal in-headset manipulation primitives.
- Product reference value:
  high as a small "make this scene editable" pattern.
- What to inspect next:
  modern A-Frame/controller APIs, undo, transform persistence, matrix/euler
  correctness, selection feedback, and mobile/no-controller fallback.
- Source evidence:
  `src/edit.js` and `src/matrix.js`.
- Reusable pattern extraction:
  grab/reparent/clone/scale edit component.
- Reusable core:
  discover controllers, map grip close/open to selection, test collision
  against editable children, temporarily reparent to the hand while preserving
  world transform, clone on two-hand grab, and write final transform back to the
  entity.
- Do not copy directly:
  old A-Frame API usage, lack of undo, or loose `self.selected` bug patterns.
- Caveats:
  historical but very clear interaction donor.

## `wakufactory/GNode`

- Interesting idea:
  a visual node graph defines geometry and A-Frame entities through nodes,
  sockets, joints, serialized positions, and an editor bridge.
- Code donor value:
  high for node/socket model, graph serialization, edit UI bridge, node menu,
  A-Frame entity integration, and simple VR movement helpers.
- Product reference value:
  high for lightweight visual scene generation.
- What to inspect next:
  graph validation, cycle handling, type safety, import/export UX, runtime
  performance, and modernizing the editor.
- Source evidence:
  `gnode.js`, `gnedit.js`, `afcompo.js`, `nedit.js`, and sample graph JSON.
- Reusable pattern extraction:
  visual node graph as serializable XR scene authoring layer.
- Reusable core:
  define nodes with typed input/output sockets, serialize nodes and joints,
  keep editor positions separate from node parameters, evaluate inputs before
  node logic, and bridge generated outputs into A-Frame entities.
- Do not copy directly:
  loose JavaScript typing, minimal validation, or graph execution without cycle
  and error policy.
- Caveats:
  useful as a compact architecture reference for visual authoring.

## `flushpot1125/WebXR_VRController_Editor_template`

- Interesting idea:
  a Babylon.js Editor-generated scene attaches TypeScript scripts to named
  scene nodes, creates a default WebXR experience, maps motion-controller
  components to scene feedback, and disables postprocess pipelines for
  performance.
- Code donor value:
  medium-to-high for generated-editor script lifecycle, `fromScene` linking,
  controller component mapping, and performance guardrails.
- Product reference value:
  medium for controller-driven scene templates.
- What to inspect next:
  generated script stability, input profile differences, feature detection,
  scene metadata lifecycle, and editor-template portability.
- Source evidence:
  `src/scenes/WebXR_VRController_Input/WebXR_VRControllerInput.ts` and
  `src/scenes/tools.ts`.
- Reusable pattern extraction:
  editor-generated scene script with explicit WebXR controller bindings.
- Reusable core:
  attach scripts through scene metadata, resolve named nodes into typed fields,
  create default XR experience, subscribe to controller component state changes,
  and turn input events into visible scene feedback.
- Do not copy directly:
  hardcoded component indexes or generated-scene names as universal bindings.
- Caveats:
  good template/reference, not a broad authoring framework.

## `dkaraush/vrcode`

- Interesting idea:
  a Three/WebXR workspace places a textarea/code display and a VR keyboard in a
  spatial scene; controllers raycast movable VR display objects and drag them
  by preserving ray distance and relative rotation.
- Code donor value:
  high for VR keyboard mesh generation, ray-drag state, movable display filters,
  and text-surface ergonomics.
- Product reference value:
  high for "small VR IDE/workbench" UX.
- What to inspect next:
  actual editing persistence, keyboard text injection, caret/selection model,
  modern Three/WebXR APIs, multi-window layout, and desktop file integration.
- Source evidence:
  `src/app/app.ts`, `src/app/controllers.ts`, `src/app/keyboard.ts`,
  `src/app/textarea.ts`, and `src/app/display.ts`.
- Reusable pattern extraction:
  spatial text/code workspace with ray-drag controls and VR keyboard.
- Reusable core:
  model displays and keyboards as movable scene objects, raycast only objects
  that opt into movement, store drag start ray/object transforms, update object
  pose from ray changes, and make key surfaces visible/pressable in VR.
- Do not copy directly:
  incomplete multi-controller scaling, old Three encoding APIs, or keyboard
  events without accessibility text fallback.
- Caveats:
  not a mature IDE, but a strong UX donor.

## `umiyuki/UnityVRAnimationEditor`

- Interesting idea:
  Unity objects tagged as animation nodes become VR-grabbable control points;
  ungrabs use Unity Undo and Animation Window helpers to record transform curves
  into the active clip, while pointer components bridge VR rays into captured
  editor-window interactions.
- Code donor value:
  very high for in-VR authoring nodes, VRTK grabbable setup, Undo-backed
  recording, Animation Window reflection helper, node type visuals, and
  controller/animation-window bridge.
- Product reference value:
  very high for in-editor VR authoring workflows.
- What to inspect next:
  modern XR Interaction Toolkit port, UnityEditor internal API breakage,
  FinalIK dependency, undo/recording safety, and editor-window capture
  replacement.
- Source evidence:
  `GenerateNodes.cs`, `Node.cs`, `wAnimationWindowHelper.cs`,
  `AnimationWindowController.cs`, `AnimWindowPointerRenderer.cs`, and
  controller helper scripts.
- Reusable pattern extraction:
  VR-grabbable authoring nodes that record into a desktop editor timeline.
- Reusable core:
  generate visible node proxies for tagged objects, make target transforms
  grabbable, capture pre-grab transform, use editor Undo as the recording
  boundary, write curves at the current animation time, and expose timeline
  controls inside VR.
- Do not copy directly:
  VRTK-era APIs, reflection into UnityEditor internals, or direct collider
  mutation without migration planning.
- Caveats:
  strongest authoring donor in this wave, but modernization is required.

## `evanw/webgl-vr-editor`

- Interesting idea:
  a historical Cardboard/WebGL voxel editor switches between play and edit
  modes, moves a voxel cursor relative to headset orientation, supports undo
  commits, saves level/lightmap files, and renders through pass-through or
  Cardboard headset paths.
- Code donor value:
  medium for compact edit/play mode split, undo tracker, file save/load, and
  orientation-relative edit cursor.
- Product reference value:
  medium as an early lightweight VR editor reference.
- What to inspect next:
  modern WebXR port, controller input, file format, browser permissions, and
  mobile headset comfort.
- Source evidence:
  `v3/src/core/app.sk`, `v3/src/core/modes.sk`,
  `v3/src/core/undo.sk`, and `v3/src/core/headset.sk`.
- Reusable pattern extraction:
  lightweight edit/play mode with explicit undo commits.
- Reusable core:
  keep play and edit modes separate, let edit mode own cursor/selection, batch
  voxel mutations into undo commits, and make save/load a first-class path.
- Do not copy directly:
  obsolete Cardboard assumptions or custom language/toolchain dependencies.
- Caveats:
  more historical inspiration than direct donor.

## `Reava/VRC-Editor-Toolbox`

- Interesting idea:
  a VRChat creator toolbox packages tiny Unity Editor commands: arrange objects
  in a circle, teleport selections to a target transform, rename children
  sequentially, toggle light-volume support, and edit Bakery light sources in
  bulk.
- Code donor value:
  medium for production microtool shape, Undo usage, MenuItem placement, and
  targeted creator workflow automation.
- Product reference value:
  high for "small editor QoL tools are valuable" framing.
- What to inspect next:
  validation, undo coverage across all tools, package metadata, scoped
  operations, and prefab/stage safety.
- Source evidence:
  `Editor/CirclePlacer.cs`, `Editor/TeleportToTransform.cs`,
  `Editor/SequentialGameobjectNaming.cs`, `Editor/BakeryEditorAddons.cs`, and
  README.
- Reusable pattern extraction:
  creator microtool package with one strong operation per window/menu.
- Reusable core:
  keep each tool narrow, expose it from an obvious editor menu, use selection
  and object fields, record Undo before mutation, and solve repetitive scene
  layout tasks without a full app shell.
- Do not copy directly:
  broad project-wide mutations without previews or missing Undo coverage.
- Caveats:
  strong product reference for small workflow helpers.

## Cross-Project Lessons

- Good XR authoring tools are often small: link placement, grab/edit, graph
  serialization, keyboard text, animation-node recording, or bulk arrangement.
- Serialization is the product boundary: `.hvrj`, graph JSON, scene metadata,
  entity attributes, voxel levels, and Unity animation curves all decide
  whether the authoring work survives the session.
- Undo and reset matter more in authoring tools than visual polish.
- In-headset editing benefits from a desktop/editor bridge when the target
  workflow is Unity or VRChat content creation.
- Controller bindings need feature detection and explicit profile handling;
  hardcoded component indexes are good examples but weak abstractions.

## Reuse Recommendations

1. Use `VRTourEditor` for manifest/export and tour-link placement patterns.
2. Use `aframe-vreditor-component` for minimal grab/reparent/clone/scale
   primitives.
3. Use `GNode` for compact visual graph serialization and A-Frame output.
4. Use `vrcode` for VR text workspace and keyboard/ray-drag UX.
5. Use `UnityVRAnimationEditor` as the strongest in-VR Unity authoring donor.
6. Use `VRC-Editor-Toolbox` as evidence that microtools belong in the lab
   alongside bigger VR apps.

## Follow-Up Gaps

- Build a lightweight XR authoring matrix across selection, manipulation,
  serialization, undo, export, and engine/editor integration.
- Compare in-headset editing versus desktop editor companion patterns.
- Extract a safe controller binding layer for generated WebXR/Babylon/Three
  editor templates.
- Decide which microtools could become small `spikes/` prototypes in
  `VR-apps-lab`.
