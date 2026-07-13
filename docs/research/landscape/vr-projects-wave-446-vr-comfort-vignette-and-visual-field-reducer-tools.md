# Wave 446: VR comfort vignette and visual-field reducer tools

## Theme

This wave studies comfort vignettes, tunnelling, and visual-field reducers. The
reusable method is a parameterized visual-field effect with trigger source,
mask/aperture behavior, user intensity, performance boundary, and honest caveats
about medical/accessibility claims.

## Shortlist

| Project | Status | Family placement |
|---|---|---|
| `RaniaMostafa0/Virtual-Reality-Simulation-of-Retinal-Diseases` | New study | Educational visual-field simulation |
| `SixWays/UnityVrTunnelling` | New study | Simple VR tunnelling |
| `ExtendRealityLtd/Tilia.Visuals.Vignette.Unity` | Deepened existing node | Vignette prefab/package |
| `sigtrapgames/VrTunnellingPro-Unity` | Deepened existing node | Advanced VR tunnelling |

## Project notes

### `RaniaMostafa0/Virtual-Reality-Simulation-of-Retinal-Diseases`

- Interesting idea:
  an educational Quest/Unity app that simulates retinal-disease symptoms with
  condition buttons, severity slider, contextual popups, and low-clutter UI that
  remains usable while vision is degraded.
- Code donor value:
  moderate for symptom taxonomy, severity-driven effect profiles, educational
  panel framing, and contrast/spacing considerations under impaired visibility.
- Product reference value:
  strong for accessibility review tools and low-vision simulation surfaces.
- Architecture pattern:
  disease/profile selection plus severity parameter plus effect pipeline plus
  explanatory UI before simulation.
- Source evidence:
  README lists 12 conditions, Meta Quest 2, Unity/OpenCV, severity slider,
  disease panel, informational popups, and effect mappings such as Gaussian
  blur, center scotoma, randomized patch masking, radial grayscale tunnel
  vision, and white-overlay haze.
- Reusable core:
  condition profile registry, severity value, effect stack, visible explanation,
  low-clutter UI constraints, and clear educational/awareness caveat.
- What not to copy:
  medical accuracy claims, named disease mappings, or clinical framing without
  expert validation.
- Method catalog action:
  contributes to `Comfort vignette and visual-field reducer`.
- What to inspect next:
  compare symptom effect profiles against general low-vision accessibility
  methods from earlier waves.

### `SixWays/UnityVrTunnelling`

- Interesting idea:
  a minimal Unity camera effect for dynamic FOV reduction during rotation to
  reduce simulator sickness.
- Code donor value:
  good compact reference for attaching a tunnelling effect to a camera, linking
  a reference transform, computing stereo matrices, and rendering a shader-based
  vignette.
- Product reference value:
  useful as the small baseline before adopting a large comfort plugin.
- Source evidence:
  README describes dynamic vignetting while rotating, attach-to-camera usage,
  `Ref Transform`, Resources shader requirement, and cubemap/cage effect;
  source includes `Assets/Scripts/ImageEffects/Tunnelling.cs` and
  `Assets/Resources/Shaders/Tunnelling.shader`.
- Reusable core:
  camera component, reference transform, angular velocity/rotation trigger,
  shader material, stereo projection/view matrices, feather/coverage settings,
  and optional cage/cubemap background.
- What not to copy:
  deprecated package status or old image-effect pipeline assumptions without
  adapting to current render pipelines.
- Method catalog action:
  contributes to `Comfort vignette and visual-field reducer`.
- What to inspect next:
  compare the simple effect against VR Tunnelling Pro's preset/mask system.

### `ExtendRealityLtd/Tilia.Visuals.Vignette.Unity`

- Interesting idea:
  a package-level vignette visual component that fits into Tilia/Zinnia-style
  prefab composition.
- Code donor value:
  moderate for packaging a visual comfort effect as a reusable prefab/module
  rather than a scene-specific script.
- Product reference value:
  useful when VR-apps-lab needs a plug-in visual component with clear package
  boundary.
- Reusable core:
  prefab/module boundary, configurable vignette parameters, and integration
  with an existing interaction toolkit ecosystem.
- Source evidence:
  package naming and source layout frame it as `Tilia.Visuals.Vignette.Unity`.
- What not to copy:
  dependency-heavy Tilia/Zinnia ecosystem if the target prototype only needs a
  lightweight effect.
- Method catalog action:
  strengthens vignette method notes.
- What to inspect next:
  inspect how Tilia exposes public configuration in prefabs versus scripts.

### `sigtrapgames/VrTunnellingPro-Unity`

- Interesting idea:
  an advanced open-source VR tunnelling toolkit with post-process, opaque,
  mobile, preset, masking, stencil, background, blur, and performance modes.
- Code donor value:
  high as a mature parameter taxonomy for comfort vignettes and masking.
- Product reference value:
  strong reference for user-facing comfort settings and platform performance
  boundaries.
- Architecture pattern:
  runtime components plus ScriptableObject preset assets plus editor inspectors
  plus shader variants for image/post-process and mobile/vertex paths.
- Source evidence:
  docs describe `Tunnelling`, `TunnellingOpaque`, `TunnellingMobile`, presets,
  coverage/feather, user option recommendation, background modes, masking,
  stencil settings, mobile limitations, and `Sigtrap.VrTunnellingPro`
  namespace; source includes `TunnellingPreset`, `TunnellingPresetMobile`,
  editor preset inspectors, and shader resources.
- Reusable core:
  effect coverage, feather, preset override flags, force-vignette mode,
  masking/stencil controls, mobile path, background mode, blur/cage options, and
  explicit user intensity/disable settings.
- What not to copy:
  plugin-specific editor UI, old Unity pipeline assumptions, or comfort claims
  without user testing.
- Method catalog action:
  contributes to `Comfort vignette and visual-field reducer`.
- What to inspect next:
  extract a pipeline-agnostic comfort settings schema.

## Synthesis

The reusable pattern is broader than "darken the edges." It should separate:

- trigger source
- effect intensity
- aperture/coverage
- feather/easing
- mask and excluded objects
- render-pipeline path
- mobile performance mode
- user preference and disable option
- educational or medical caveat

## Follow-up backlog

- Draft a render-pipeline-neutral comfort vignette schema.
- Compare comfort vignettes with low-vision simulation filters.
- Track which approaches include UI/transparent objects and which do not.
- Decide whether VR-apps-lab needs a comfort settings panel prototype.
