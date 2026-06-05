# VR Projects Wave 142: VRM/Avatar Web Stacks, Model Specs, Runtime Loaders, and Browser Avatar/Mocap Surfaces

- Date: `2026-06-05`
- Goal: study VRM as a reusable avatar runtime/spec layer across Unity,
  browser, A-Frame, and avatar/mocap surfaces.

## Why this wave exists

Avatar work often crosses runtime boundaries: Unity tools, browser renderers,
OSC/VMC pose streams, MediaPipe tracking, face blendshapes, spring bones,
first-person visibility, and licensing metadata. VRM is useful because it
bundles many of those concerns into a reusable model/runtime contract.

## Better workflow used in this wave

1. searched by VRM, Three.js VRM, A-Frame VRM, browser avatar, MediaPipe avatar,
   and VRM specification families;
2. deduplicated against prior VMC, MediaPipe, VRChat avatar, and face tracking
   waves;
3. froze a shortlist across Unity runtime/editor, Three.js runtime, A-Frame
   components, browser avatar/mocap product, and spec repository;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `vrm-c/UniVRM` | Canonical Unity VRM runtime/editor/import/export stack |
| `pixiv/three-vrm` | Modular Three.js VRM loader/runtime |
| `binzume/aframe-vrm` | A-Frame VRM component layer |
| `ButzYung/SystemAnimatorOnline` | Browser avatar/mocap and XR Animator lineage reference |
| `vrm-c/vrm-specification` | Canonical VRM extension and schema contracts |

## Deep-pass notes by project

## `vrm-c/UniVRM`

- GitHub:
  [vrm-c/UniVRM](https://github.com/vrm-c/UniVRM)
- What it is:
  Unity packages, samples, and runtime/editor tooling for VRM/glTF.
- Interesting idea:
  avatar import/export is a full runtime pipeline: humanoid mapping,
  expressions, first-person visibility, look-at, spring bones, materials,
  metadata, migration, and sample viewers all matter.
- Code-level notes:
  sample and runtime trees expose VRM 0.x and VRM 1.0 workflows, migration
  exporters, simple viewers, animation bridges, BVH loading, spring-bone
  toggles, fast/default runtime choices, expression controls, first-person
  samples, cloth/spring experiments, metadata callbacks, and WebGL file-dialog
  helpers.
- Architecture pattern:
  engine-native avatar runtime plus import/export/migration/editor and sample
  viewer layers.
- Reusable method:
  avatar utilities need runtime controls and metadata validation, not only
  model loading.
- Code donor value:
  high for Unity avatar runtime, importer/exporter, viewer, and migration
  patterns.
- Product reference value:
  high for avatar tools and checkers.
- Caveats:
  large Unity project; reuse should target narrow runtime/editor ideas.
- What to inspect next:
  map UniVRM runtime features to VMC, MediaPipe, and VRChat avatar utilities.

## `pixiv/three-vrm`

- GitHub:
  [pixiv/three-vrm](https://github.com/pixiv/three-vrm)
- What it is:
  modular Three.js packages for loading and controlling VRM models.
- Interesting idea:
  VRM loading is best expressed as a set of composable loader plugins rather
  than one monolithic parser.
- Code-level notes:
  `VRMLoaderPlugin` owns plugins for expression, first-person, humanoid,
  look-at, meta, spring-bone, MToon material, and node constraint loading. Its
  `afterRoot` step assembles a `VRM` object when metadata and humanoid are
  present. The `VRM` runtime updates core behavior, node constraints,
  spring-bone manager, and materials. Utility modules cover VRM0 rotation and
  morph/mesh optimization.
- Architecture pattern:
  GLTFLoader plugin composition plus runtime manager update loop.
- Reusable method:
  avatar pipelines should make humanoid, expression, look-at, spring, material,
  and constraint modules swappable.
- Code donor value:
  high for browser avatar loader/runtime composition.
- Product reference value:
  high for web avatar previewers and browser mocap surfaces.
- Caveats:
  Three.js-specific and version-sensitive with VRM extensions.
- What to inspect next:
  compare with A-Frame wrappers and MediaPipe VRM tracking.

## `binzume/aframe-vrm`

- GitHub:
  [binzume/aframe-vrm](https://github.com/binzume/aframe-vrm)
- What it is:
  A-Frame components and runtime helpers for VRM avatars.
- Interesting idea:
  avatar behavior can become declarative scene markup through focused
  components: model load, animation, skeleton debug, posing, and mimic/IK.
- Code-level notes:
  `aframe-vrm.js` registers `vrm` for loading a VRM source, first-person mode,
  blink interval, look-at target, model-loaded/model-error events, and physics
  debug body updates. `vrm-anim` loads clips and controls playback. `vrm-poser`
  exposes pose get/set and bone handles. `vrm-mimic` links target entities to
  avatar IK chains with simpleIK and bone constraints.
- Architecture pattern:
  declarative A-Frame component layer over a VRM runtime.
- Reusable method:
  avatar controls should expose small scene-level components rather than a
  hidden global manager.
- Code donor value:
  high for A-Frame avatar glue and poser/mimic component ideas.
- Product reference value:
  medium-high for browser avatar experiments.
- Caveats:
  older runtime lineage and custom helper modules need compatibility review.
- What to inspect next:
  compare with modern `three-vrm` and A-Frame hand/tracking components.

## `ButzYung/SystemAnimatorOnline`

- GitHub:
  [ButzYung/SystemAnimatorOnline](https://github.com/ButzYung/SystemAnimatorOnline)
- What it is:
  a browser/desktop animation system with XR Animator, VRM/MMD, AI motion
  capture, audio-reactive animation, and many legacy host modes.
- Interesting idea:
  an avatar/mocap surface can combine webcam/AI motion capture, VRM/MMD
  rendering, audio beat/FFT reactions, desktop widget behavior, and browser
  deployment.
- Code-level notes:
  the project contains `XR_Animator.html`, System Animator variants, MMD and
  Three.js trees, docs for browser host modes, and changelog entries for XR as
  an engine, AI motion capture from webcam/media, VRM/BVH/FBX motion support,
  MMD physics in workers, audio-beat animation, child animations, transparent
  backgrounds, and embedded media/3D surfaces.
- Architecture pattern:
  legacy desktop animation platform evolved into browser avatar/mocap engine.
- Reusable method:
  avatar utilities can layer media input, mocap, audio reactivity, and runtime
  host modes, but must separate modern donor ideas from legacy baggage.
- Code donor value:
  medium for product-level architecture and media/avatar feature breadth.
- Product reference value:
  high for browser avatar/mocap ambition.
- Caveats:
  very large legacy codebase with embedded assets and old host modes; reuse
  should be selective.
- What to inspect next:
  compare with MediaPipe VRM tracking, VMC recorders, and avatar face-tracking
  modules.

## `vrm-c/vrm-specification`

- GitHub:
  [vrm-c/vrm-specification](https://github.com/vrm-c/vrm-specification)
- What it is:
  canonical VRM specification and schema repository.
- Interesting idea:
  avatar runtime behavior should be driven by explicit extension contracts:
  humanoid, first-person, expressions, look-at, spring bones, node constraints,
  MToon material, metadata, license, and compatibility fallbacks.
- Code-level notes:
  the specification tree includes VRM 0.0, VRMC_vrm 1.0, materials, node
  constraints, spring-bone and extended-collider definitions, animation, and
  schema files. The node constraint docs define roll, aim, and rotation
  constraints; material docs define MToon/fallback relationships; spring-bone
  docs define collider behavior and compatibility notes.
- Architecture pattern:
  schema-first avatar behavior contract.
- Reusable method:
  any avatar utility should cite the spec layer when interpreting runtime
  behavior, permissions, and compatibility.
- Code donor value:
  medium as schema/reference source.
- Product reference value:
  high for validation, compatibility, and support-boundary design.
- Caveats:
  specification repository, not an application donor.
- What to inspect next:
  use it as the source of truth for future avatar checker or converter
  research.

## Cross-project synthesis

- Strongest runtime donors:
  `UniVRM`, `three-vrm`, `aframe-vrm`.
- Strongest spec authority:
  `vrm-specification`.
- Strongest product breadth reference:
  `SystemAnimatorOnline`.
- Main reusable methods:
  avatar runtime feature matrix, loader plugin composition, declarative
  component glue, browser mocap/avatar surfaces, and schema-first validation.

## Fit for `VR-apps-lab`

This wave strengthens avatar-facing utility foundations: avatar previewers,
model validators, mocap bridges, expression/viseme tools, first-person checks,
and browser avatar surfaces. It should be cross-linked with VMC, MediaPipe,
VRChat face tracking, avatar OSC, and creative authoring waves.
