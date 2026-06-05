# VR Projects Wave 178: Visual Impairment Simulation, Gaze-Contingent Accessibility, and UI A11y

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 178 studies visual accessibility and simulation tools: per-eye impairment
post-processing, gaze-contingent masks, mobile passthrough filters,
patient-data-driven visual fields, and screen-reader-like Unity UI helpers.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `petejonze/OpenVisSim` | Unity visual impairment simulator | Strong shader/pipeline donor with GPL/deprecation caveats |
| `VARID-XR/VARID-plugin-ue5` | Unreal visual impairment post-process plugin | Strong engine-plugin donor |
| `rulyox/VisualImpairmentVR` | Mobile/Cardboard passthrough impairment filters | Thin mobile reference |
| `ojwalch/LowVisionVR` | Android dual-eye camera filter app | Strong native mobile reference with deprecated APIs |
| `lukasmaxim/Glaucoma-VR` | Patient-data gaze-contingent Varjo simulator | Focused patient-data/mask donor |
| `mikrima/UnityAccessibilityPlugin` | Unity UI accessibility manager | Strong UI accessibility donor |

## `petejonze/OpenVisSim`

- Interesting idea:
  model visual impairments as per-eye post effects with linkable settings and
  gaze-contingent masks that combine overlay textures and blurred mip levels.
- Code donor value:
  high for Unity image-effect structure, per-eye setting sync, gaze-contingent
  field-loss masks, and generated overlay textures.
- Product reference value:
  high for accessibility simulation tools that help designers inspect
  experience rather than only read guidelines.
- What to inspect next:
  compare its Unity approach with VARID's Unreal plugin and decide the minimal
  engine-neutral impairment pipeline vocabulary.
- Source evidence:
  `BaseEffect.cs`, `LinkableBaseEffect.cs`, and `myFieldLoss.cs`.
- Reusable pattern extraction:
  gaze-contingent per-eye impairment post-processing.
- Reusable core:
  wrap each effect in a reusable post-process component, tag left/right eye
  effect pairs, copy `[Linkable]` fields from one eye to the other, generate
  mask/overlay textures, render blur mip levels, and update shader gaze
  coordinates from a gaze tracker.
- Do not copy directly:
  deprecated Unity 2017 implementation or GPL code without license review.
- Caveats:
  project is deprecated in favor of VARID; treat as source-level lesson.

## `VARID-XR/VARID-plugin-ue5`

- Interesting idea:
  expose eye-condition simulation as an Unreal plugin with Blueprint setters,
  per-eye state, normalized gaze input, debug modes, and RDG compute passes for
  blur pyramids.
- Code donor value:
  high for plugin API shape, condition-specific setters, per-eye state, and
  gaze-contingent rendering implementation.
- Product reference value:
  high for accessible simulation as a reusable engine plugin, not one-off demo.
- What to inspect next:
  map its condition API into a cross-engine catalog of impairment simulation
  controls.
- Source evidence:
  `VARIDBlueprintFunctionLibrary.h/cpp`, `VARIDRendering.cpp`, and
  `Shaders/Private/EyeConditions/*`.
- Reusable pattern extraction:
  Blueprint-facing gaze-contingent visual impairment plugin.
- Reusable core:
  provide `BeginRendering`/`EndRendering`, normalized gaze setters, per-eye
  condition setters with clamps, condition clear/reset helpers, debug modes,
  RDG blur pyramid generation, and eye-condition shader passes.
- Do not copy directly:
  UE5.5-specific rendering code into other engines without preserving an
  abstraction boundary.
- Caveats:
  accessibility simulation is not medical diagnosis; documentation should keep
  discomfort and validation caveats visible.

## `rulyox/VisualImpairmentVR`

- Interesting idea:
  stage a phone/Android camera feed onto a plane and apply simple distortion or
  impairment shaders for Cardboard-style VR.
- Code donor value:
  medium for a very small camera-to-material-to-shader pipeline.
- Product reference value:
  medium as a lightweight mobile passthrough simulation reference.
- What to inspect next:
  compare with `LowVisionVR` for native camera handling and performance.
- Source evidence:
  `CameraController.cs`, `RenderTextureCamera.cs`, and `Distortion.shader`.
- Reusable pattern extraction:
  mobile camera passthrough impairment shader staging.
- Reusable core:
  pull camera frames into `WebCamTexture`, render a duplicate camera to a
  texture, feed that texture into materials, update UV offsets, and apply
  normal-map based distortion or condition shaders.
- Do not copy directly:
  scene-per-condition assumptions or old Cardboard project structure.
- Caveats:
  thin Unity 2018 sample; useful as compact reference.

## `ojwalch/LowVisionVR`

- Interesting idea:
  implement dual-eye Android camera preview with multiple low-vision filter
  modes, joystick/gamepad controls, and RenderScript kernels.
- Code donor value:
  high for native mobile camera-to-filter-to-dual-view structure.
- Product reference value:
  high for assistive passthrough concepts and low-vision filter exploration.
- What to inspect next:
  translate its filter modes into modern Android/Unity compute or shader
  alternatives because RenderScript is deprecated.
- Source evidence:
  `MainActivity.java`, `Filter.java`, and `filters.rs`.
- Reusable pattern extraction:
  mobile dual-eye passthrough filter pipeline.
- Reusable core:
  maintain left/right preview and overlay textures, use camera callback buffers,
  process frames asynchronously, switch modes for normal/edge/center/warp/
  periphery, expose zoom/parameter controls through input devices, and keep
  filter settings mutable at runtime.
- Do not copy directly:
  deprecated RenderScript and old Android camera APIs.
- Caveats:
  contains old release-style artifacts and platform assumptions; use as design
  and pipeline reference.

## `lukasmaxim/Glaucoma-VR`

- Interesting idea:
  convert patient visual-field data into alpha masks, then use Varjo gaze and
  context/focus cameras to simulate glaucoma-like field loss.
- Code donor value:
  medium-high for patient-data-to-texture conversion, per-eye mask handling,
  and Varjo gaze/context/focus shader parameters.
- Product reference value:
  medium-high for individualized simulation workflows.
- What to inspect next:
  validate gaze/status handling and separate own code from bundled vendor
  assets before any reuse.
- Source evidence:
  `DataLoader.cs`, `MaskGenerator.cs`, `Post-Processing/Mask.cs`,
  `MaskSettings.cs`, `BoxBlurMask.cs`, `BoxBlurMask.shader`, and
  `GazeLogger.cs`.
- Reusable pattern extraction:
  patient-data-driven gaze-contingent impairment mask.
- Reusable core:
  load patient grid data, transform values into mask alpha, generate context
  and focus textures, collect Varjo gaze/HMD pose, update shader offsets and
  per-eye scales, and log gaze/pupil/focus values for analysis.
- Do not copy directly:
  vendor assets, no-doc assumptions, or likely bugs around left/right validity
  and reused gaze variables.
- Caveats:
  project has little documentation and strong Varjo-specific assumptions.

## `mikrima/UnityAccessibilityPlugin`

- Interesting idea:
  bring screen-reader-like navigation, labels, hints, TTS/audio queue,
  touch-explore, menu containers, virtual keyboard, and platform wrappers into
  Unity UI.
- Code donor value:
  high for accessibility manager, element metadata, container ordering, audio
  queue, and platform TTS wrappers.
- Product reference value:
  high for future VR menus that need non-visual or low-vision operation.
- What to inspect next:
  adapt its 2D UI ordering model into spatial/VR menu focus order and
  controller/hand input.
- Source evidence:
  `UAP_AccessibilityManager.cs`, `UAP_BaseElement.cs`,
  `AccessibleUIGroupRoot.cs`, `UAP_AudioQueue.cs`, and Android TTS wrapper
  files.
- Reusable pattern extraction:
  screen-reader-like Unity UI accessibility layer.
- Reusable core:
  register accessible UI elements with labels/prefixes/hints, manage active
  containers and popups, compute 2D navigation order, support touch exploration
  and gestures, queue spoken/audio feedback with interrupt policies, expose a
  virtual keyboard, and wrap platform TTS behavior.
- Do not copy directly:
  examples with separate licensing or 2D assumptions without a VR adaptation
  pass.
- Caveats:
  does not expose a native platform accessibility tree; it is an in-app
  accessibility layer.

## Extracted Methods

- Gaze-contingent visual impairment pipeline:
  impairment effects need per-eye state, gaze coordinates, mask generation,
  blur levels, debug views, and clear controls.
- Mobile passthrough impairment filter:
  camera frames can be staged into dual-eye previews and mutable filters, but
  modern replacements are needed for deprecated mobile APIs.
- Screen-reader-like Unity UI:
  VR menus can inherit focus order, spoken labels, hints, audio queues, and
  virtual keyboard concepts from 2D Unity accessibility systems.

## Why This Matters For `VR-apps-lab`

This wave broadens the repository beyond performance/overlay utility work into
accessibility as a reusable engineering branch. It provides concrete methods
for building accessibility diagnostics, simulation tools, and more usable VR
menu systems.
