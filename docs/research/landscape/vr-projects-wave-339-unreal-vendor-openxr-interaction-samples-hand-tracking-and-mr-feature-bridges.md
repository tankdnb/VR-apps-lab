# Wave 339 - Unreal Vendor OpenXR Interaction Samples, Hand Tracking, and MR Feature Bridges

This wave studies Unreal/vendor OpenXR samples that demonstrate controller,
hand, body, eye, and mixed-reality feature surfaces.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to Unreal OpenXR/vendor sample projects, hub/menu and
feature-demo scene organization, hand tracking, pinch/ray input, body tracking,
eye tracking, MR features, and plugin dependency boundaries.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `picoxr/PICO_UE5_OpenXRSample` | PICO Unreal OpenXR interaction sample | Studied | Product reference for centralized VR hub, controller ray selection, movement/teleport/UI/grab/haptics, hand gestures, and full-body avatar tracking |
| `oculus-samples/Unreal-InteractionSDK-Sample` | Meta Unreal Interaction SDK sample | Studied | Product/dependency reference for packaging a C++ sample around required Meta XR and Interaction SDK plugins |
| `demonixis/FSOpenXRHandTracking` | Unreal OpenXR hand tracking plugin | Studied | Strong bounded code donor for `FXRMotionControllerData` hand rendering, pinch detection, Enhanced Input hooks, hand rays, and MetaXR skeleton bridge |
| `varjocom/VarjoUnrealOpenXRExamples` | Varjo OpenXR Unreal MR sample | Studied | Product reference for MR feature framing: pass-through, depth occlusion, foveated rendering, markers, eye tracking, and hand tracking via Varjo/OpenXR plugins |

## Code-Level Findings

### `picoxr/PICO_UE5_OpenXRSample`

- Interesting idea: a vendor sample can be organized as a hub that routes users
  into controller, hand, and body-tracking scenes.
- Code donor value: medium-low because much of the implementation is binary
  Unreal assets. The README is still strong product evidence: controller
  locomotion/teleport/UI/grab/spawn/remote-grab/haptics, hand gesture particle
  and color actions, pinch grab, V-gesture scene return, and full-body avatar
  drive.
- Product reference value: high for demo-lab organization.
- What to inspect next: Blueprint graphs, PICO plugin integration, input action
  assets, body tracker mapping, and hub scene transitions.
- Caveat: vendor/engine-version pinned and asset-heavy.

### `oculus-samples/Unreal-InteractionSDK-Sample`

- Interesting idea: Meta's sample is explicit about external plugin
  requirements and should be treated as a dependency-boundary reference.
- Code donor value: medium-low from the cloned source surface. The project
  includes an `OculusInteractionSamples` plugin with C++ sample helpers, but the
  core interaction behavior depends on separately installed Meta XR and
  Interaction SDK plugins.
- Product reference value: high for setup documentation, dependency honesty,
  and sample packaging.
- What to inspect next: sample plugin classes such as reset/reposition helpers,
  generated widget examples, and dependency/license boundaries.
- Caveat: Meta license and plugin downloads limit direct reuse.

### `demonixis/FSOpenXRHandTracking`

- Interesting idea: hand tracking can be decomposed into data retrieval,
  lightweight rendering, pinch state, Enhanced Input events, hand-ray follower,
  and vendor skeleton bridge.
- Code donor value: high. `UFSInstancedHand` uses instanced meshes/wireframe
  options, updates from `FXRMotionControllerData`, exposes Blueprint functions,
  supports pinch detection, optional Enhanced Input action registration, a
  lagged hand-ray follower, and a MetaXR skeleton-to-motion-data bridge.
- Product reference value: high for hand-only utility input.
- What to inspect next: `FSInstancedHand.cpp`, gesture detector roadmap,
  tracking-loss behavior, ray smoothing, and MetaXR compile flag.
- Caveat: UE 5.4.x and optional MetaXR assumptions.

### `varjocom/VarjoUnrealOpenXRExamples`

- Interesting idea: vendor examples should frame advanced MR capabilities as
  separable feature surfaces: pass-through, depth, foveation, markers, eye
  tracking, and hand tracking.
- Code donor value: low-medium; current clone is sample-project heavy with many
  assets and config files. The README is the strongest public source for
  feature scope and branch/version policy.
- Product reference value: high for enterprise MR feature taxonomy.
- What to inspect next: Varjo plugin example maps, config defaults, marker
  flows, and eye/hand plugin usage.
- Caveat: requires Varjo hardware/runtime/plugin; do not generalize support.

## Reusable Pattern Extraction

- Pattern candidate: Unreal/vendor OpenXR interaction sample decomposition.
- Problem solved: vendor XR samples often mix onboarding, scene routing,
  controller input, hand/body/eye tracking, MR rendering, and plugin setup in
  one large project.
- Reusable core: hub scene, feature cards, controller interaction scene,
  hand-only scene, body/eye/MR feature scenes, input action assets, vendor
  plugin adapter, tracking-data component, gesture/pinch/ray layer, settings
  and setup docs, and explicit dependency/license gates.
- Source evidence: `picoxr/PICO_UE5_OpenXRSample`,
  `oculus-samples/Unreal-InteractionSDK-Sample`,
  `demonixis/FSOpenXRHandTracking`, and
  `varjocom/VarjoUnrealOpenXRExamples`.
- Abstraction boundary: keep vendor plugin setup, tracked data acquisition,
  interaction semantics, rendering/debug visualization, scene routing, and
  sample content separate.
- What not to copy: vendor assets, binary Unreal content without source
  evidence, hardware-specific assumptions, license-restricted plugin code, or
  hub/menu UX that hides unsupported devices.
- Method catalog action: add Unreal/vendor OpenXR interaction sample
  decomposition.

## Follow-Up Gaps

- Inspect source-readable sample helper classes in Meta and PICO projects.
- Compare Unreal hand-ray smoothing against Godot and WebXR hand utility waves.
- Build a vendor sample checklist for future `VR-apps-lab` Unreal prototypes.
