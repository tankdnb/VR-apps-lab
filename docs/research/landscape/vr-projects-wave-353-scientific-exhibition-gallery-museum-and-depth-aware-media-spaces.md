# Wave 353: Scientific Exhibition Gallery Museum and Depth-Aware Media Spaces

## Scope

This wave studies VR exhibition and media-gallery projects that turn assets,
rooms, displays, cloud metadata, or local image folders into navigable XR
spaces. The reusable lesson is a workshop-grade exhibit scaffold with
replaceable content adapters.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `eisclimber/ExPresS-XR` | Studied | Scientific OpenXR toolkit with rig setup, movement modes, near/far interactions, hand/wrist menus, data gathering, questionnaires, debug console, localization, and setup dialogs |
| `eisclimber/VRMuseumTemplate` | Studied | Beginner-oriented VR exhibition workshop template with handout and completed exhibit structure on top of ExPresS-XR |
| `Hempp/street-art-gallery` | Studied | Compact gallery reference for spatial art display and simple room/media framing |
| `Kilamper/Art-Museum-VR` | Studied | Spanish VR art room with creative 3D object interaction, pixel-art canvas, and floating instructions |
| `ericyoondotcom/OculusGooglePhotos` | Studied | Oculus/Google Photos direction marker for external personal-media gallery ingestion |
| `usmanbutt-dev/VR-DepthAPI-Gallery` | Studied | Quest gallery with local storage scanning, image display, opacity slider, movable UI panels, and Meta Depth API occlusion |
| `echo3Dco/Unity-Oculus-echo3D-demo-VR-Zoo-Explorer` | Studied | Cloud-managed VR zoo using echo3D project keys, scene metadata, 3D model indexes, and audio/video project separation |

## Reusable Pattern Extraction

- Pattern candidate: `workshop-grade exhibition/gallery template boundary`.
- Problem solved: galleries need fast content replacement without rewriting XR
  rig, interaction, data collection, or media-display plumbing.
- Reusable core: room/exhibit scaffold, content slots, media/source adapter,
  object metadata, display controller, quiz/tour/narration hooks, hand/wrist
  menu, local/cloud/depth-aware ingestion, setup wizard/handout, provenance,
  comfort, and build/export route.
- Source evidence: ExPresS-XR exposes setup dialogs, interaction primitives,
  data gathering, button quizzes, questionnaires, and wrist menus;
  VRMuseumTemplate adds handout/completed-exhibit teaching structure;
  VR-DepthAPI-Gallery separates `GalleryManager`, `LocalStorageService`, and
  image display/occlusion scripts; echo3D Zoo uses cloud metadata and project
  keys for content.
- Abstraction boundary: exhibit logic should consume a content manifest or
  adapter; XR rig and media transport should be reusable across exhibits.
- What not to copy: hardcoded API keys, cloud-only content paths without local
  fallback, asset-store UI skin dependencies, or workshop assumptions without
  public setup docs.
- Method catalog action: create a new exhibition/gallery template method.

## Project Notes

### `eisclimber/ExPresS-XR`

- Interesting idea: a research/exhibition toolkit bundles movement,
  interaction, quiz, data gathering, debug, localization, and hand/wrist UI
  primitives.
- Code donor value: high for scaffold and editor/setup workflow patterns.
- Product reference value: strong for public scientific XR templates.
- What to inspect next: data export/upload boundaries, questionnaire schema,
  and reusable setup dialogs.
- Caveats: large Unity toolkit; reuse conceptually before importing wholesale.

### `eisclimber/VRMuseumTemplate`

- Interesting idea: a museum template includes both a teaching handout and a
  completed exhibit, making it reusable for onboarding non-game-developers.
- Code donor value: moderate-to-high for documentation and folder convention.
- Product reference value: strong for beginner-facing VR exhibition workflows.
- What to inspect next: handout steps, scene object naming, and exhibit slot
  schema.
- Caveats: depends on ExPresS-XR conventions.

### `usmanbutt-dev/VR-DepthAPI-Gallery`

- Interesting idea: Quest-local images become movable VR panels that can be
  occluded by real-world depth.
- Code donor value: high for local storage scan, gallery manager, image display,
  UI panels, opacity control, and depth occlusion boundary.
- Product reference value: strong for MR photo/media utilities.
- What to inspect next: Android storage permission flow and image memory budget.
- Caveats: Meta Depth API and Quest storage permissions are platform-specific.

### `echo3Dco/Unity-Oculus-echo3D-demo-VR-Zoo-Explorer`

- Interesting idea: scene content is managed through echo3D metadata and project
  keys rather than bundled only in the Unity scene.
- Code donor value: moderate for cloud-content adapter shape.
- Product reference value: useful for remotely curated exhibit/zoo content.
- What to inspect next: metadata schema, API failure UI, and offline fallback.
- Caveats: cloud dependency and credential hygiene.

## Product Direction

This wave supports a `VR exhibit builder` branch: reusable XR rig + content
manifest + media adapters + setup docs can make small galleries, science demos,
and local/depth-aware media surfaces faster to create.

