# VR Projects Wave 412 - Lightweight OpenXR Render Framework Adapters

- Date: `2026-07-13`
- Scope: small OpenXR/OpenVR bridges that graft XR session, swapchain, pose, and
  action handling onto lightweight rendering frameworks.
- Rule: source/documentation reading only; no builds, installs, launches, or
  device tests were performed.

## Shortlist

- `FireFlyForLife/rlOpenXR`
- `caszuu/rlxr`
- `branchpanic/raylib-openvr`
- `geefr/vsgvr`

## Project Notes

### `FireFlyForLife/rlOpenXR`

- Interesting idea: Raylib-facing OpenXR binding that keeps the public API close
  to Raylib while wrapping head/hand pose and rendering setup.
- Code donor value: useful as a small-framework adapter reference where the app
  should not learn raw OpenXR for common pose/render tasks.
- Product reference value: validates a friendly `XR add-on for simple graphics
  framework` direction for demos and teaching tools.
- Source evidence: README design decisions, `include/`, `src/`, and `examples/`.
- Reusable core: thin API facade over OpenXR instance/session/render state,
  head/hand pose access, and Raylib render integration.
- What not to copy: Windows-only and WIP support boundaries.
- What to inspect next: compare its API shape against `rlxr` for a tiny XR app
  scaffold pattern.

### `caszuu/rlxr`

- Interesting idea: single-header OpenXR module for Raylib with session,
  reference-space, rendering, actions, suggested bindings, haptics, and
  platform graphics binding handling.
- Code donor value: strongest source donor in this wave: `InitXr`, `UpdateXr`,
  `BeginXrMode`, `rlLoadAction`, `rlSuggestBinding`, swapchain lifecycle,
  action spaces, and per-platform binding detection are all visible in
  `src/rlxr.h`.
- Product reference value: good pattern for small standalone VR utilities that
  need OpenXR without adopting a large engine.
- Source evidence: `src/rlxr.h`, `examples/`, `docs/android.md`, and README API
  cheatsheet.
- Reusable core: single-header style lifecycle facade with explicit pre-update
  action registration and frame-mode boundary.
- What not to copy: assertions and one-header density can hide state complexity;
  future production code should expose diagnostics more clearly.
- What to inspect next: overlay-session TODO (`XR_EXTX_overlay`) and Android
  helper path.

### `branchpanic/raylib-openvr`

- Interesting idea: prototype OpenVR support for Raylib using raylib stereo
  rendering facilities and HMD/controller tracking.
- Code donor value: useful comparison node for OpenVR versus OpenXR adapter
  boundaries in the same lightweight-rendering family.
- Product reference value: shows the older SteamVR/OpenVR path for tiny C
  experiments and why OpenXR adapter shape is preferable for future work.
- Source evidence: README, `examples/`, CMake layout, and raylib fork/submodule
  boundary.
- Reusable core: keep VR backend support in the rendering framework boundary
  and leave examples as small app-level validation.
- What not to copy: submodule/fork dependency and prototype status.
- What to inspect next: whether its example structure offers simpler onboarding
  than OpenXR samples.

### `geefr/vsgvr`

- Interesting idea: OpenXR integration for VulkanSceneGraph with controller
  tracking, models, desktop view, OpenXR input, and coordinate-space notes.
- Code donor value: useful for Vulkan-based utilities that need an engine-ish
  scene graph but still want explicit OpenXR lifecycle and extension awareness.
- Product reference value: validates `render-framework XR adapter` as a family
  larger than Raylib; the same boundaries apply to VSG/Vulkan tools.
- Source evidence: README status table, `vsgvr/`, `examples/`, and extension/
  coordinate-space documentation.
- Reusable core: graphics-framework adapter with explicit OpenXR extension,
  coordinate-space, controller-model, input, and desktop mirror constraints.
- What not to copy: VSG-specific coordinate assumptions without conversion
  labels.
- What to inspect next: document coordinate-space adapters across OpenXR,
  VulkanSceneGraph, Raylib, and app scene coordinates.

## Extracted Method Candidate

`Tiny XR render-framework adapter`: wrap OpenXR/OpenVR lifecycle behind a small
framework-facing API that owns session, swapchains, reference spaces, action
binding, haptics, and per-platform graphics binding, while leaving app code to
think in the host framework's render loop.
