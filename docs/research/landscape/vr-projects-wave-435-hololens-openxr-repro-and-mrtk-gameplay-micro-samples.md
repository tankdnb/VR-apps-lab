# VR Projects Wave 435: HoloLens OpenXR Repro and MRTK Gameplay Micro-Samples

Date: 2026-07-13

Theme: small HoloLens/OpenXR/MRTK projects that are more valuable as setup,
reproduction, and interaction references than as large code donors.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `camnewnham/Unity-Repro-OpenXR-TrackingLoss` | HoloLens tracking-state repro | Code-level pass |
| `Purecon/Hololens-SphereDefender-` | MRTK hand-touch gameplay sample | Code-level pass |
| `nikolajIvanov/MRTK-Tutorial` | HoloLens OpenXR/MRTK setup reference | Thin setup pass |

## Project Notes

### `camnewnham/Unity-Repro-OpenXR-TrackingLoss`

- Interesting idea: a minimal HoloLens repro project for OpenXR/ARFoundation
  tracking state not recovering after moving spaces while sensors are covered.
- Code donor value: small but useful status panel pattern combining ARSession
  state with `InputTracking.trackingAcquired`/`trackingLost` for Head and
  CenterEye nodes.
- Product reference value: strong reference for diagnostic repro repos: document
  exact package versions, repro steps, expected behavior, and visible state.
- Architecture pattern: minimal Unity scene with AR mesh visuals, OpenXR/Mixed
  Reality packages, and a text status component.
- Reusable method: `XR tracking-loss repro harness`.
- UX/product lesson: tracking bugs need in-scene state labels, not just console
  logs, because the failure occurs on-device.
- Caveats: focused repro only; not a reusable app or broad diagnostic tool.
- Source evidence: README lists HoloLens repro steps and package versions;
  `TrackingStateText.cs` subscribes to `ARSession.stateChanged`,
  `InputTracking.trackingAcquired`, and `trackingLost`, then writes state text.
- Reusable core: package/version manifest, step-by-step repro script, state text,
  head/center-eye tracking labels, and spatial mesh visibility expectation.
- What not to copy: issue-specific assumptions without runtime/device labels.
- Method catalog action: add HoloLens/OpenXR repro harness method.
- What to inspect next: collect more repro repos for anchors, meshing, remoting,
  and permission failures.

### `Purecon/Hololens-SphereDefender-`

- Interesting idea: HoloLens/OpenXR MRTK mini-game where enemies spawn on a sphere
  and the player protects it through hand touch/interactions.
- Code donor value: ScriptableObject-driven enemy waves, sphere-surface spawning,
  game-finished event, hand touch handler, and basic MRTK tutorial components.
- Product reference value: useful as a simple spatial gameplay loop for "defend a
  zone around a real-world object" prototypes.
- Architecture pattern: MRTK/OpenXR Unity game with wave data in ScriptableObjects
  and hand touch events for interaction.
- Reusable method: `sphere-zone spatial gameplay loop`.
- UX/product lesson: small MR games can be structured around a central protected
  volume, wave timing, and touch/hand-driven feedback.
- Caveats: tutorial-level code, third-party effect assets, incomplete touch
  handler methods throwing `NotImplementedException`, and limited README.
- Source evidence: README states HoloLens/OpenXR versions; `EnemiesSpawner.cs`
  uses `SphereCollider.radius`, wave/subwave ScriptableObjects, spawn timers, and
  `onGameFinished`; `TestSphereTouch.cs` implements `IMixedRealityTouchHandler`.
- Reusable core: sphere-spawn volume, wave/subwave data, central objective,
  completion event, hand-touch hook, and tooltip feedback.
- What not to copy: incomplete touch handlers and asset-pack demo code.
- Method catalog action: add HoloLens/MRTK micro-sample method.
- What to inspect next: find polished MR mini-games with complete hand-touch
  lifecycle and object-state feedback.

### `nikolajIvanov/MRTK-Tutorial`

- Interesting idea: a thin HoloLens/MRTK/OpenXR tutorial project with local MRTK
  package archives and scenes, useful mainly as setup evidence.
- Code donor value: low; no meaningful custom scripts were present in the
  inspected tree.
- Product reference value: useful as a package-manifest/setup snapshot for
  HoloLens tutorial work.
- Architecture pattern: Unity project with MRTK Foundation/StandardAssets tgz
  packages and Microsoft Mixed Reality OpenXR package in `manifest.json`.
- Reusable method: `thin HoloLens tutorial setup reference`.
- UX/product lesson: setup-only repos should be labeled as such so they do not
  masquerade as implementation donors.
- Caveats: scene-only, no custom scripts, old package versions, and limited
  product learning value.
- Source evidence: `Packages/manifest.json` references MRTK Foundation
  `2.8.3`, StandardAssets `2.8.3`, Unity OpenXR `1.6.0`, and Microsoft Mixed
  Reality OpenXR `1.7.0`.
- Reusable core: package manifest snapshot and scene organization.
- What not to copy: package archive pinning without provenance or compatibility
  notes.
- Method catalog action: keep as project-local observation under HoloLens setup
  references.
- What to inspect next: prefer repos with custom MRTK interaction code for future
  waves.

## Reusable Pattern Extraction

- Pattern candidate: `XR repro and micro-sample harness`.
- Problem solved: some XR findings are best preserved as minimal reproductions or
  tiny gameplay loops, not as broad reusable frameworks.
- Reusable core: exact package versions, reproduction steps, visible runtime
  state, minimal scene, tiny interaction loop, and clear "thin reference" labels.
- Source evidence: tracking-loss repro supplies state labels; SphereDefender
  supplies a small wave/touch loop; MRTK-Tutorial supplies package setup context.
- Abstraction boundary: repro scripts and setup manifests are reusable as
  diagnostics references; tutorial scenes should not be promoted to methods
  without implementation logic.

## Follow-Up Gaps

- Collect HoloLens repro repos for anchors, scene understanding, spatial mesh,
  permissions, remoting, and tracking recovery.
- Build a standard "XR repro note" template with device, package versions,
  steps, visible state, expected result, actual result, and mitigation.
