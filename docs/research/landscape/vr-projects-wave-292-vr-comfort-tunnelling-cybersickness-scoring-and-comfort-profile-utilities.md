# Wave 292 - VR Comfort Tunnelling, Cybersickness Scoring, and Comfort Profile Utilities

This wave studies comfort-oriented VR utility projects as reusable references
for tunnelling/vignette rendering, velocity-driven comfort intervention,
comfort-score state machines, shared user comfort profiles, and
foveated-rendering/perceptual artifact controls.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- vignette and tunnelling overlays for artificial locomotion comfort;
- runtime comfort presets and user-adjustable comfort profiles;
- cybersickness scoring and hysteresis/state-machine approaches;
- foveated rendering controls with perceived comfort/artifact relevance;
- source-light comfort candidates worth excluding from future duplicate waves.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `sigtrapgames/VrTunnellingPro-Unity` | Unity tunnelling comfort plugin | Studied | Rich post-process tunnelling stack with presets, masking, cage/window modes, shaders, and runtime controls |
| `ExtendRealityLtd/Tilia.Visuals.Vignette.Unity` | Tilia/VRTK vignette prefab | Studied | Facade/configurator split for velocity/angular-velocity driven vignette intensity |
| `BryanRalston/vr-comfort-framework` | Comfort score and cybersickness state model | Studied | Score calculation plus asymmetric fold/recovery state machine and intervention framing |
| `Skyfall1235/VR-Player-Comfort-Profile-SDK` | Shared player comfort profile SDK | Studied | JSON profile schema for locomotion, turning, vignette, subtitles, haptics, and control preferences |
| `KRASAV4EK/BP_Foveated-Rendering-In-PC-VR` | Foveated rendering comfort/perception reference | Studied with asset-heavy caveats | URP VRS feature, gaze marker, and user-study framing around artifacts/perceived quality |
| `melisgokalp/Cybersickness` | Comfort experiment search candidate | Source-light/exclusion note | Search hit contained no usable source tree in the local study pass |

## Code-Level Findings

### `sigtrapgames/VrTunnellingPro-Unity`

- Interesting idea:
  comfort can be implemented as a configurable tunnelling platform rather than
  a single black vignette.
- Code donor value:
  high. `TunnellingBase.cs` separates shared settings and motion parameters;
  `TunnellingPresetBase.cs` exposes overrideable motion/color/background
  settings; shaders cover blur, cage, stencil, window, and mobile variants.
- Product reference value:
  very high for any future comfort helper, locomotion utility, or user-facing
  comfort settings panel.
- What to inspect next:
  render-pipeline compatibility, mobile/SRP tradeoffs, preset switching UX,
  masking/cockpit-object behavior, and how to expose safe defaults to users.

### `ExtendRealityLtd/Tilia.Visuals.Vignette.Unity`

- Interesting idea:
  a small prefab can expose comfort as a facade while the configurator handles
  velocity sources, angular velocity, smoothing, magnitude limits, and visuals.
- Code donor value:
  high conceptually. `VignetteFacade.cs` is the public API and
  `VignetteConfigurator.cs` implements the velocity-to-effect pipeline.
- Product reference value:
  high for Unity package boundaries and inspector-friendly comfort modules.
- What to inspect next:
  Zinnia dependencies, lifecycle hooks, prefab wiring, and how the effect
  behaves when velocity sources are missing or disabled.

### `BryanRalston/vr-comfort-framework`

- Interesting idea:
  cybersickness interventions can be driven by a smoothed comfort score and an
  asymmetric state machine instead of direct per-frame toggles.
- Code donor value:
  medium/high. `ComfortScore.cs` models locomotion type, angular velocity,
  dropped frames, and session duration; `ComfortStateMachine.cs` uses fold,
  recovery, sustain timers, and a conservative post-recovery window.
- Product reference value:
  high for comfort dashboards, adaptive settings, and research instrumentation.
- What to inspect next:
  validation evidence, threshold tuning, intervention mapping, privacy around
  symptoms, and whether the theory docs match implemented behavior.

### `Skyfall1235/VR-Player-Comfort-Profile-SDK`

- Interesting idea:
  comfort preferences can be stored as a portable profile instead of being
  reconfigured independently in every application.
- Code donor value:
  high for schema ideas. `VRPlayerComfortProfile.cs` groups movement, visuals,
  and other settings; `ProfileManager.cs` creates/parses JSON profiles;
  sample JSON includes turn style, degrees, locomotion style, direction source,
  vignette values, subtitles, haptics, grip toggle, and trigger/grip swap.
- Product reference value:
  very high for cross-app comfort onboarding and accessibility settings.
- What to inspect next:
  schema versioning, platform storage path, missing parser methods,
  interoperability with OpenXR accessibility settings, and privacy/consent.

### `KRASAV4EK/BP_Foveated-Rendering-In-PC-VR`

- Interesting idea:
  foveated rendering tools should expose user-visible quality/artifact controls
  and gaze visualization, not only performance toggles.
- Code donor value:
  medium. `FoveatedVrsFeature.cs` injects URP render passes, toggles ETFR,
  levels, masks, and debug logging; `GazeMarker.cs` raycasts gaze to a world
  dot with fallback placement.
- Product reference value:
  high for performance/comfort panels where users need to see and tune the
  current gaze/foveation state.
- What to inspect next:
  VRS shader generation, gaze input source, thesis/user-study findings, and
  artifact thresholds before using this as a production comfort model.

### `melisgokalp/Cybersickness`

- Interesting idea:
  the search result suggests a controller-setting comfort experiment.
- Code donor value:
  low in this pass because the local clone did not expose a usable source tree.
- Product reference value:
  low/medium as a duplicate-search exclusion and possible future artifact hunt.
- What to inspect next:
  repository history, branches, releases, and whether data/code exists outside
  the default branch.

## Reusable Pattern Extraction

- Pattern candidate:
  VR comfort intervention boundary across motion signal, sickness/comfort
  score, effect renderer, user profile, and performance/artifact control.
- Problem solved:
  comfort features are often hardcoded per app, making them hard to reuse,
  tune, explain, or preserve across tools.
- Reusable core:
  motion/velocity inputs, comfort score, hysteresis state machine, intervention
  policy, vignette/tunnelling renderer, presets, user comfort profile schema,
  gaze/foveation indicator, debug mask, and user-facing override controls.
- Source evidence:
  `VrTunnellingPro-Unity`, `Tilia.Visuals.Vignette.Unity`,
  `vr-comfort-framework`, `VR-Player-Comfort-Profile-SDK`,
  and `BP_Foveated-Rendering-In-PC-VR`.
- Abstraction boundary:
  keep sensing/scoring, intervention policy, rendering, profile persistence,
  and UI separate.
- What not to copy:
  fixed thresholds without user control, a single vignette as the whole comfort
  system, unversioned profile schemas, vendor-heavy performance code without
  validation, or symptom-related telemetry without consent.
- Method catalog action:
  add a VR comfort intervention/profile method.

## Follow-Up Gaps

- Build a comfort utility matrix across tunnelling modes, vignette intensity,
  motion inputs, score/state models, user profiles, and foveation controls.
- Compare Wave 292 with earlier locomotion/comfort waves so comfort methods do
  not fragment across multiple family names.
- Deepen `VrTunnellingPro-Unity`, `Tilia.Visuals.Vignette.Unity`, and
  `VR-Player-Comfort-Profile-SDK` as the strongest reusable donors.
- Consider a future reuse plan for a comfort settings panel with profile import,
  vignette preview, intervention status, and safe defaults.
