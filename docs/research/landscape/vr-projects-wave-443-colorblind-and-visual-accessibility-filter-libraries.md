# VR Projects Wave 443: Colorblind and Visual Accessibility Filter Libraries

Date: 2026-07-13

Theme: Unity colorblind simulation/correction libraries and visual-accessibility
filters that can become small reusable accessibility layers for VR utilities.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `mariosubspace/colorblind-unity` | Built-in pipeline image-effect simulation | Code-level pass |
| `am1goo/unity-srp-colorblindness` | URP renderer feature and volume override | Code-level pass |
| `taqu/UnityColorblind` | Portable colorblind shader algorithms | Code-level pass |
| `SOHNE/Colorblindness` | Runtime profile manager for SRP volumes | Code-level pass |
| `macabrett/BrettMStory.Unity.ColorBlind` | Minimal camera component simulator | Code-level pass |

## Project Notes

### `mariosubspace/colorblind-unity`

- Interesting idea: Unity image-effect shader package for simulating color
  deficiencies with test scene, error mask texture, mask strength, blinking
  speed, and linear color-space requirement.
- Code donor value: useful donor for packaging simulation modes, material
  parameters, custom inspector controls, and test-scene visualization.
- Product reference value: good reference for a VR accessibility settings panel
  that can preview color modes against representative UI/content.
- Architecture pattern: camera image effect with shader include,
  `ColorblindSimulationImageEffect`, material enum parameter, and editor shader
  UI.
- Reusable method: `colorblind visual accessibility filter library`.
- UX/product lesson: visual filters should include preview/test content and
  color-space caveats, not only matrices.
- Caveats: built-in image-effect era, linear-color assumption, and algorithm
  provenance must remain visible.
- Source evidence: README documents test scene, shader controls, linear color
  requirement, and sources; `ColorDeficiencyTools.cginc` contains LMS/daltonize
  functions; editor scripts expose deficiency enum controls.
- Reusable core: deficiency enum, material parameters, preview scene, color-space
  caveat, algorithm source citation, and optional error emphasis layer.
- What not to copy: matrices without attribution or built-in pipeline code into
  URP/HDRP without adapting render pass boundaries.
- Method catalog action: create visual accessibility filter method.
- What to inspect next: port camera-image-effect controls into an XR-safe
  per-eye render pipeline implementation.

### `am1goo/unity-srp-colorblindness`

- Interesting idea: URP package that exposes color blindness support as a
  renderer feature plus Volume override.
- Code donor value: strong donor for modern URP integration: package layout,
  renderer feature, render pass, override component, editor UI, and shader.
- Product reference value: practical reference for future VR utilities that use
  URP and need accessibility toggles integrated with volume/profile settings.
- Architecture pattern: `ColorBlindnessRendererFeature` injects a render pass,
  `ColorBlindness` override activates only when selected mode differs from
  normal, and render pass reads the active Volume component.
- Reusable method: `URP volume-driven accessibility filter`.
- UX/product lesson: accessibility filters should be toggled from the same
  settings system as other post effects so scenes do not need custom camera
  scripts.
- Caveats: URP 14/Unity 2022.3 target, native render pass/MSAA requirements, and
  screen-space overlay UI limitation.
- Source evidence: README documents URP renderer feature and volume override
  setup; `ColorBlindnessRenderPass.cs`, `ColorBlindnessRendererFeature.cs`, and
  `ColorBlindness.cs` show render pass and Volume override boundaries.
- Reusable core: renderer feature, volume override, mode enum, render-pass
  activation guard, package naming, and known limitation list.
- What not to copy: URP-version-specific APIs without compatibility labels.
- Method catalog action: update visual accessibility filter method with URP
  render-pass subpattern.
- What to inspect next: how this behaves with XR single-pass/multipass and
  screen-space/canvas UI.

### `taqu/UnityColorblind`

- Interesting idea: tiny shader-only colorblind simulation sample with optional
  HCIRN method and portable matrix/math functions.
- Code donor value: useful algorithm donor because the shader keeps LMS
  conversion, coefficient tables, and alternative method license warning close
  to the code.
- Product reference value: reference for documenting algorithm provenance and
  license caveats in accessibility methods.
- Architecture pattern: one hidden shader plus simple image effect wrapper.
- Reusable method: `algorithm-provenance-labeled color filter`.
- UX/product lesson: users and developers should know whether a mode simulates,
  corrects, or daltonizes, and whether the source algorithm has commercial
  restrictions.
- Caveats: minimal repo, old image effect, and HCIRN commercial-use warning.
- Source evidence: README documents optional HCIRN method and license caveat;
  `Colorblind.shader` contains LMS matrices, protan/deutan/tritan coefficients,
  anomaly/base fragment functions, and source comments.
- Reusable core: portable shader math, source comments, mode labels, and license
  warning beside the algorithm.
- What not to copy: HCIRN mode into commercial or public code without license
  review.
- Method catalog action: update visual accessibility filter method with
  algorithm provenance and license caution.
- What to inspect next: compare algorithm outputs against modern accessibility
  guidance and real-user testing.

### `SOHNE/Colorblindness`

- Interesting idea: runtime colorblindness manager for URP/HDRP using volume
  profiles, F1 cycling, PlayerPrefs persistence, and automatic filter application
  across scene migration.
- Code donor value: useful donor for settings persistence, runtime profile
  cycling, singleton management, async resource loading, and scene-level volume
  update.
- Product reference value: strong product reference for VR accessibility menus:
  profile list, hotkey/controller shortcut, persistence, and caveat text.
- Architecture pattern: `Colorblindness` manager loads `VolumeProfile` resources
  by enum type, persists selected profile in `PlayerPrefs`, and applies
  components to volumes.
- Reusable method: `runtime accessibility profile manager`.
- UX/product lesson: filters are more useful when they are runtime-switchable,
  persisted, and automatically reapplied rather than scene-local.
- Caveats: README explicitly notes lack of tests with colorblind people; current
  implementation uses keyboard F1 by default, which needs VR/controller mapping.
- Source evidence: README documents eight profiles, F1 runtime loading,
  PlayerPrefs, and scene migration; `Colorblindness.cs` defines enum profiles,
  singleton, preference key, `Change`, and async profile loading.
- Reusable core: accessibility profile registry, persisted preference, runtime
  cycling, resource-based profile loading, scene reapply, and validation caveat.
- What not to copy: keyboard-only shortcut, unvalidated effectiveness claims, or
  singleton assumptions without lifecycle review.
- Method catalog action: update visual accessibility filter method with runtime
  profile-manager subpattern.
- What to inspect next: controller-accessible settings UI and per-user profiles
  for VR tools.

### `macabrett/BrettMStory.Unity.ColorBlind`

- Interesting idea: minimal class-library style color blind simulator component
  that can be placed on a camera with a dropdown type selector.
- Code donor value: useful as the smallest donor shape: camera component,
  enum/dropdown, shader folder, and editor popup.
- Product reference value: shows the minimum viable accessibility filter surface
  for prototypes before a full render-pipeline package exists.
- Architecture pattern: `ColorBlindSimulator` MonoBehaviour with selected type
  property and custom editor dropdown.
- Reusable method: `minimal camera accessibility simulator`.
- UX/product lesson: a tiny component is better than no accessibility preview in
  early prototypes, as long as it is labeled as simulation and pipeline-limited.
- Caveats: old/simple code, camera-effect assumptions, and no broad validation.
- Source evidence: README describes copying `ColorBlindSimulator.cs` plus shader
  folder and adding the component to a camera; source contains enum and editor
  dropdown choices.
- Reusable core: minimal install path, enum selector, camera attachment, and
  prototype-only caveat.
- What not to copy: camera-only approach as final XR accessibility architecture.
- Method catalog action: update visual accessibility filter method with minimal
  prototype variant.
- What to inspect next: create a common settings UI that can drive both minimal
  camera effects and URP/HDRP render-pass implementations.

## Reusable Pattern Extraction

- Pattern candidate: `colorblind visual accessibility filter library`.
- Problem solved: VR utilities need visual accessibility options that are
  testable, runtime-switchable, render-pipeline-aware, and honest about
  simulation/correction limits.
- Reusable core: deficiency/profile registry, algorithm source evidence, render
  integration boundary, runtime setting/persistence, preview/test scene,
  UI/controller access, color-space/pipeline caveats, and validation warning.
- Source evidence: built-in image effect in `colorblind-unity`, URP render pass
  in `unity-srp-colorblindness`, portable shader math in `UnityColorblind`,
  runtime profile manager in `SOHNE/Colorblindness`, and minimal camera component
  in `BrettMStory.Unity.ColorBlind`.
- Abstraction boundary: settings/profile model and render-pass concept are
  reusable; exact shader matrices, old image-effect code, and unvalidated claims
  must remain provenance-labeled.

## Follow-Up Gaps

- Build a VR accessibility filter checklist: simulation vs correction,
  color-space, render pipeline, XR stereo mode, UI inclusion/exclusion,
  controller-accessible settings, persistence, screenshots, and caveats.
- Compare colorblind filters with broader low-vision tools such as contrast,
  outline, text scaling, captions, brightness, and UI recoloring.
