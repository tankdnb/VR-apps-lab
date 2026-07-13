# VR Projects Wave 434: XR Educational Model Annotation and Passthrough Retrofit Samples

Date: 2026-07-13

Theme: educational XR samples that add callouts, exploded-view learning flows,
large-asset setup, and passthrough retrofits to model-inspection applications.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `Chinmay-HS/AeroVerse-XR-Headsets` | XR educational model annotation | Code-level pass |
| `MixedRealityDevelopment-CalebCram/Neuroanatomy_Passthrough_Quest2` | Quest passthrough retrofit | Code-level/product pass |

## Project Notes

### `Chinmay-HS/AeroVerse-XR-Headsets`

- Interesting idea: OpenXR-based immersive education app with model selection,
  exploded views, floating annotations, external large-asset downloads, and
  release-build automation.
- Code donor value: annotation collision avoidance, model-bound scaling, callout
  line renderer, annotation manager keyed by part names, model dropdown/spawner,
  animation metadata, and asset-download/CI setup notes.
- Product reference value: strong reference for educational utility apps where
  models need inspect, annotate, explode, and progress/achievement layers.
- Architecture pattern: OpenXR/XRI Unity project with model-specific annotations
  and externally downloaded model/video resources.
- Reusable method: `educational model callout and asset-gated setup`.
- UX/product lesson: model callouts should scale with distance and model bounds,
  avoid overlap, face the camera, and be toggleable by the learner.
- Caveats: README mentions AI/Firebase/TensorFlow aspirations, but inspected core
  evidence is mainly annotation/model UI and asset workflow; external assets are
  not in git.
- Source evidence: README explains OpenXR/XRI choice and external asset download;
  `Annotation.cs` handles dynamic scale, bounds, collision avoidance, camera-facing
  rotation, and line renderer; `AnnotationManager.cs` spawns labels by
  `PartIdentifier.partName`.
- Reusable core: part registry, label entries, callout prefab, scale/avoidance
  logic, line-to-target, model switch cleanup, large-asset setup script, release
  build asset hydration.
- What not to copy: unverified AI/product claims, Google Drive asset dependence
  without checksum/provenance, and sample packages committed as app logic.
- Method catalog action: add educational model annotation method.
- What to inspect next: model metadata schemas for exploded views, quizzes, and
  progress tracking.

### `MixedRealityDevelopment-CalebCram/Neuroanatomy_Passthrough_Quest2`

- Interesting idea: retrofit an existing VR neuroanatomy app for Quest 2 mixed
  reality passthrough by updating Unity compatibility, adding passthrough
  components, and removing virtual backgrounds.
- Code donor value: limited as a passthrough implementation donor, but useful for
  studying how an older Oculus/OVR educational app organizes brain-part toggles,
  labels, laser selection, teleport floor, foveated rendering, and "build a brain"
  modes.
- Product reference value: useful reminder that many legacy VR learning apps can
  become MR references through scene/background and runtime setting changes.
- Architecture pattern: OVRInput-driven educational object app with ray/laser
  SendMessage interactions and scene-level passthrough retrofit.
- Reusable method: `legacy educational VR to passthrough retrofit audit`.
- UX/product lesson: passthrough retrofits should document what was removed,
  what runtime components were added, and what legacy interactions still assume
  controller/OVR APIs.
- Caveats: sparse README, old code style, OVR-specific input, SendMessage usage,
  and passthrough changes are mostly scene/config rather than clean reusable code.
- Source evidence: README states Unity update, manual passthrough components, and
  virtual background removal; scripts include `brainMaster`, `brainPart2`,
  `newLaser`, `floorTeleport`, `toggleBrains`, `oculusFFR`, and menu controls.
- Reusable core: retrofit checklist, legacy input audit, scene-background removal,
  object-part interaction inventory, and performance setting note.
- What not to copy: legacy `SendMessage` interaction routing and untracked scene
  modifications as the only explanation of passthrough behavior.
- Method catalog action: update educational model annotation/passthrough retrofit
  method.
- What to inspect next: compare with source-clean passthrough retrofit samples
  that expose Passthrough Layer setup in scripts or documented prefab diffs.

## Reusable Pattern Extraction

- Pattern candidate: `educational XR model inspection and retrofit`.
- Problem solved: learning apps need model selection, part labels, exploded state,
  callouts, large assets, and sometimes MR passthrough migration.
- Reusable core: part registry, annotation manager, callout layout, line renderer,
  model state cleanup, asset hydration, build workflow, retrofit checklist, and
  runtime capability caveats.
- Source evidence: `AeroVerse-XR-Headsets` shows callout/asset setup; `Neuroanatomy
  Passthrough Quest2` shows legacy VR-to-MR retrofit framing.
- Abstraction boundary: model metadata and callout behavior are reusable; large
  assets, vendor SDK components, and scene-only retrofits need provenance labels.

## Follow-Up Gaps

- Build a reusable educational model metadata schema for parts, labels, exploded
  transforms, quizzes, and asset provenance.
- Compare scene-only passthrough retrofits against scripted/runtime-detectable MR
  capability setup.
