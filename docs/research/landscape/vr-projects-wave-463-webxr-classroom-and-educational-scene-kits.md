# Wave 463: WebXR classroom and educational scene kits

- Date: `2026-07-13`
- Scope: WebXR classroom scenes, educational components, physics sandboxes,
  interactive lessons, Sketchfab/embed surfaces, Quest A-Frame helpers, scene
  routers, assets, and simple win/lose exercise components.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `Utopiah/WebXR_edu_components` | Studied | A-Frame exercise component |
| `Group-47-Capstone-2019/Immersive-Web-VR-AR` | Studied | WebXR physics classroom scenes |
| `ManishRShetty/classroom-webxr` | Studied | Next/Sketchfab classroom shell |
| `RuiqingCHEN/webxr-interactive-classroom` | Studied | Three.js classroom environment |
| `elinsprojects/AnimalClassroom-WebXR` | Studied | WebXR animal classroom scene |
| `disasteroftheuniverse/SuperQuest` | Cross-wave reference | Quest A-Frame education helper kit |

## Why this wave matters

Education projects are often small, but they reveal reusable product patterns:
lesson routing, scene state preservation, embedded 3D content, guided exercises,
physics sandboxes, interactive controllers, and content-specific caveats. These
patterns are directly useful for VR utility examples and onboarding labs.

## Project notes

### `Utopiah/WebXR_edu_components`

- Interesting idea:
  tiny A-Frame exercise component that defines win/lose conditions, time
  limits, color matching, feedback text, and click-driven source objects.
- Code donor value:
  useful as a minimal "lesson validator" pattern: the scene owns instruction
  and feedback surfaces, while the component owns condition checks.
- Product reference value:
  shows how tiny educational interactions can be packaged as reusable
  components instead of full applications.
- Source evidence:
  `aframe-exercise-component/aframe-exercise-component.js`,
  `aframe-exercise-component/index.html`, `README.md`, and `RESEARCH.md`.
- Reusable core:
  exercise state, win condition, lose condition, total time, progress counter,
  instruction element, feedback element, click source, and feedback text.
- What not to copy:
  rough timing implementation, global mutable exercise object, or one-off color
  matching rules without schema.
- What to inspect next:
  generalized lesson state schema and scoring/export hooks.

### `Group-47-Capstone-2019/Immersive-Web-VR-AR`

- Interesting idea:
  WebXR classroom app with routed scenes for home, planets, kinematics, lasers,
  and pendulums, including physics sandbox interaction and scene state restore.
- Code donor value:
  strong donor for browser-XR educational shell architecture: router, current
  scene holder, saved scene state, asset loader queue, welcome/loading UI, and
  per-scene start/remove lifecycle.
- Product reference value:
  shows how an educational VR lab can be a scene pack rather than one hardcoded
  demo.
- Source evidence:
  `src/scripts/router.js`, `src/scripts/scenes/xr-scene.js`,
  `src/scripts/scenes/kinematics.js`, `src/scripts/scenes/planets/*`,
  `src/scripts/xrController.js`, `src/scripts/interactions.js`, and
  `src/scripts/loader.js`.
- Reusable core:
  route-to-scene map, saved state per route, reset camera, loader queue,
  loading/welcome screens, scene start/remove lifecycle, physics body/mesh
  arrays, instructional guide text, and interaction triggers.
- What not to copy:
  course assets, old deployment config, or hard-coded scene content.
- What to inspect next:
  scene base class, controller abstraction, and lesson state export.

### `ManishRShetty/classroom-webxr`

- Interesting idea:
  minimal Next.js classroom shell embedding Sketchfab content with XR-related
  iframe permissions.
- Code donor value:
  lightweight reference for embedding external 3D model viewers in a classroom
  route while surfacing XR permission attributes.
- Product reference value:
  suggests a low-cost content browser path for education/reference utilities:
  web app shell plus embeddable 3D content.
- Source evidence:
  `src/components/SketchfabViewer.tsx`, `src/app/page.tsx`,
  `next.config.ts`, `Dockerfile`, and `README.md`.
- Reusable core:
  embed wrapper, iframe permissions, autostart/autospin model URL, page shell,
  and deploy container.
- What not to copy:
  fixed Sketchfab model id, non-standard iframe attributes without validation,
  or Next boilerplate as XR infrastructure.
- What to inspect next:
  permission behavior across browsers and how to make embedded content
  selectable/indexed.

### `RuiqingCHEN/webxr-interactive-classroom`

- Interesting idea:
  Three.js classroom environment with VRButton, controller model factory,
  GLTF/video/audio assets, spatial audio/media, and lab assignment structure.
- Code donor value:
  useful as a scene-composition reference for asset-heavy educational rooms:
  models, video, sound, water/texture libs, controllers, and assignment docs.
- Product reference value:
  reminds us that education scenes need asset provenance and content navigation,
  not only XR entry.
- Source evidence:
  `README.md`, `labs/Assignment2/asign2.js`, `labs/Assignment2/index.html`,
  `libs/VRButton.js`, `libs/XRControllerModelFactory.js`, and `assets/*`.
- Reusable core:
  classroom asset bundle, VR entry button, controller models, GLTF/media
  loading, spatial audio/video, and assignment packaging.
- What not to copy:
  bundled library/vendor files, large media assets, or course-specific content.
- What to inspect next:
  lesson interaction logic and asset manifest needs.

## Reusable pattern extraction

- Pattern candidate:
  `browser XR lesson scene pack`.
- Problem solved:
  organize educational XR content as routeable, stateful scenes with explicit
  lesson objectives, assets, input handlers, feedback, and reset/loading flows.
- Reusable core:
  route map, scene base class, loader queue, saved scene state, welcome/loading
  UI, instruction panels, exercise conditions, feedback state, asset manifest,
  embedded model viewer, controller adapter, and lesson export hooks.
- Abstraction boundary:
  shell owns routes/loading; scene owns domain objects; exercise component owns
  validation; content layer owns assets and provenance.
- Method catalog action:
  create a new method for browser XR lesson scene packs.

## Caveats

- Many educational repos are course demos; keep asset and content provenance
  explicit.
- External embeds need permission, availability, and privacy labels.
- Lesson scoring should be schema-backed before reuse in serious tools.

