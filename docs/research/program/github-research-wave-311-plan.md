# GitHub Research Wave 311 Plan - Rust, Bevy, and Godot OpenXR Bring-Up Variants, App Shells, and Input/Rendering Boundaries

## Goal

Study Rust/Bevy/Godot OpenXR experiments as reusable references for app-shell
bring-up, graphics binding, swapchain lifecycle, frame-loop systems, input
resources, engine extension boundaries, and platform adapters.

## Research Questions

- How do Rust and Bevy projects expose OpenXR lifecycle as engine resources?
- Which parts of the XR frame loop are reusable across engines?
- How are render plugins, manual texture views, swapchain images, and frame
  submission connected?
- When should Godot/Rust split scene setup from type-safe controller logic?

## Shortlist

- `blaind/bevy_openxr`
- `MalekiRe/bevy_openxr_android`
- `occuros/bevy_openxr_performance_test`
- `richardanaya/godot_openxr__rust`
- `TheHellBox/SlashMania`

## Required Checks

- Deduplicate against earlier Rust OpenXR, Hotham, Bevy, Godot, and app-shell
  waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep engine-version, unsafe lifecycle, Android packaging, panic-heavy sample,
  and maturity caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 311.
- Registry/family entries for Rust, Bevy, and Godot OpenXR bring-up variants.
- Method catalog entry for Rust/Bevy/Godot OpenXR app-shell boundaries.
- Follow-up gaps for render graph, graphics initialization, and input action
  handling.
