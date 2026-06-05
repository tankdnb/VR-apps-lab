# GitHub Research Wave 142 Backlog

- Date: `2026-06-05`
- Scope: VRM/avatar runtimes, loaders, specs, A-Frame components, and browser
  avatar/mocap surfaces.

## Completed in this wave

- Studied `vrm-c/UniVRM` as a Unity VRM runtime/editor ecosystem with import,
  export, migration, humanoid, expressions, look-at, spring bones,
  first-person, metadata, and viewer samples.
- Studied `pixiv/three-vrm` as a modular Three.js VRM loader/runtime with
  loader plugins for humanoid, expressions, first-person, look-at, meta,
  spring bones, MToon materials, and node constraints.
- Studied `binzume/aframe-vrm` as A-Frame VRM glue with `vrm`, `vrm-anim`,
  `vrm-skeleton`, `vrm-poser`, and `vrm-mimic` components.
- Studied `ButzYung/SystemAnimatorOnline` as a browser/avatar/mocap surface
  with XR Animator lineage, VRM/MMD support, AI motion capture, audio-reactive
  animation, and desktop/widget history.
- Studied `vrm-c/vrm-specification` as the canonical VRM extension/schema
  source for humanoid, first-person, expression, look-at, spring-bone,
  constraint, MToon, license, and metadata contracts.

## Reuse candidates

- `UniVRM` is strongest for Unity import/export/runtime/editor workflows.
- `three-vrm` is strongest for modular browser avatar runtime composition.
- `aframe-vrm` is strongest for declarative WebXR/avatar component APIs.
- `SystemAnimatorOnline` is useful as an ambitious browser avatar/mocap
  product reference with caveats.
- `vrm-specification` is the authority for compatibility and data contracts.

## Follow-up backlog

1. Build a VRM runtime matrix: Unity, Three.js, A-Frame, browser mocap, and spec
   extension responsibilities.
2. Compare VRM expression/look-at/spring-bone flows with VMC, MediaPipe,
   VRChat face tracking, and avatar OSC waves.
3. Extract a reusable avatar-preview/checker concept only if avatar utility
   work becomes active.
4. Keep spec links close to any future code-donor note to avoid model-license
   and compatibility mistakes.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
