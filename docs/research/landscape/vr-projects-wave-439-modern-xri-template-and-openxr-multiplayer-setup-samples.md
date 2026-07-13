# VR Projects Wave 439: Modern XRI Template and OpenXR Multiplayer Setup Samples

Date: 2026-07-13

Theme: modern Unity/XRI project baselines, template assets, and setup-only
references that are useful for scaffolding future VR utility prototypes.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `Fist-Full-of-Shrimp/Shrimp-XRI-Template` | Unity 6/XRI 3.x template baseline | Code-level pass |
| `BanQingTian/MultiPlayer_Unity_OpenXR` | OpenXR multiplayer setup placeholder | README-only pass |

## Project Notes

### `Fist-Full-of-Shrimp/Shrimp-XRI-Template`

- Interesting idea: free Unity 6/XRI 3.x VR template with accessibility, hand
  menus, modern OpenXR packages, and extra interaction/video examples.
- Code donor value: useful donor for template organization, manifest/package
  baseline, teleport anchor visuals, callouts, hand subsystem management,
  XR knob/video scrub controls, ray attach modifiers, hand smoothing samples,
  and project validation rules.
- Product reference value: strong reference for a "known-good starting point"
  for future VR utility prototypes where package versions and interaction
  assets are visible.
- Architecture pattern: Unity project template combining XRI 3.4, XR Hands,
  OpenXR, Meta/OpenXR, Android XR, URP, composition layers, accessibility module,
  and template scripts under `VRTemplateAssets`.
- Reusable method: `modern XRI utility template baseline`.
- UX/product lesson: starter templates become more reusable when they include
  interaction affordance visuals, video/media controls, hand/controller support,
  validation scripts, and package manifests in one inspectable baseline.
- Caveats: broad template, much code comes from Unity samples, and package
  versions may age quickly.
- Source evidence: README states Unity 6/XRI 3.x template goals; `Packages/
  manifest.json` pins OpenXR/XRI/XR Hands/URP/accessibility modules;
  `VRTemplateAssets/Scripts` includes anchor visuals, callouts, knobs, video
  controls, ray attach modifiers, and hand subsystem management.
- Reusable core: manifest baseline, template asset grouping, locomotion and
  affordance visuals, hand/controller coexistence, validation rules, and media
  control samples.
- What not to copy: imported Unity sample code as original donor logic or large
  template scope without pruning for the target utility.
- Method catalog action: create modern XRI template/setup method.
- What to inspect next: compare with Meta, Unity, Godot, Unreal, and WebXR
  starter templates for minimal utility scaffolds.

### `BanQingTian/MultiPlayer_Unity_OpenXR`

- Interesting idea: repository title suggests multiplayer Unity/OpenXR setup,
  but the public tree currently contains only a README in the inspected clone.
- Code donor value: none from the current public tree.
- Product reference value: weak placeholder reference showing why setup-only or
  empty repos must be labeled honestly during research.
- Architecture pattern: README-only placeholder.
- Reusable method: `setup-reference honesty label`.
- UX/product lesson: do not promote a project to donor status just because its
  name matches a useful theme.
- Caveats: no `Assets`, `Packages`, scripts, or manifest were present in the
  inspected tree.
- Source evidence: local clone contained only `.git` and `README.md`.
- Reusable core: none beyond the process lesson.
- What not to copy: repo title, missing source claims, or inferred multiplayer
  architecture.
- Method catalog action: keep as project-local observation; do not create a
  multiplayer method from this repo.
- What to inspect next: source-available Unity/OpenXR multiplayer baselines with
  Netcode, Photon, Mirror, Normcore, or WebRTC synchronization.

## Reusable Pattern Extraction

- Pattern candidate: `modern XR template baseline with donor-scope labels`.
- Problem solved: future VR utilities need a predictable starting point, but
  templates vary from rich starter assets to empty setup placeholders.
- Reusable core: pinned package manifest, sample scenes, input/hand/locomotion
  assets, validation rules, small reusable controls, and a donor-scope label.
- Source evidence: `Shrimp-XRI-Template` provides a real Unity/XRI baseline;
  `MultiPlayer_Unity_OpenXR` demonstrates the need to label README-only repos.
- Abstraction boundary: package baseline and small controls are reusable; entire
  templates and empty titles are not evidence of architecture.

## Follow-Up Gaps

- Search for source-available Unity OpenXR multiplayer baselines with real
  networking code and avatar/state synchronization.
- Define a starter-template evaluation checklist: package versions, scenes,
  input maps, hand support, accessibility, validation, sample-code provenance,
  and what to remove for small utilities.
