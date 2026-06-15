# GitHub Research Wave 311 Backlog - Rust, Bevy, and Godot OpenXR Bring-Up Variants, App Shells, and Input/Rendering Boundaries

## Executed Scope

- Searched and deduplicated Rust, Bevy, Godot, Android/Quest, and minimal
  OpenXR app-shell experiments.
- Froze a five-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted WGPU/OpenXR handoff, Bevy custom runners, typed XR resources,
  controller gizmo systems, manual render plugin replacement, future XR
  resource handoff, left/right manual texture views, event polling, frame
  wait/begin/end systems, swapchain image lifecycle, Godot Rust GDExtension
  controller logic, and hand-rolled OpenGL OpenXR frame streams.

## Studied Projects

- `blaind/bevy_openxr`
- `MalekiRe/bevy_openxr_android`
- `occuros/bevy_openxr_performance_test`
- `richardanaya/godot_openxr__rust`
- `TheHellBox/SlashMania`

## Backlog Findings

- Build a Rust XR app-shell matrix comparing Bevy, Godot, hand-rolled OpenGL,
  WGPU/OpenXR, Android/Quest packaging, and input action handling.
- Deepen `occuros` graphics initialization and swapchain image safety.
- Deepen `blaind` render graph, hand-tracking, and platform modules.
- Compare Godot Rust extension boundaries with Unity native plugin and OpenXR
  layer/plugin boundaries from earlier waves.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a Rust/Bevy/Godot OpenXR app-shell method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
