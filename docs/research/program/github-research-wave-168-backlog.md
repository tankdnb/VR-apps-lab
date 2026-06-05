# GitHub Research Wave 168 Backlog

- Date: `2026-06-05`
- Theme: `Rust, Bevy, wgpu, and OpenXR app/rendering bring-up`
- Status: `Completed`

## Completed Pass

1. Search Rust, Bevy, wgpu, and OpenXR app bring-up repositories.
2. Deduplicate against existing OpenXR runtime, layer, overlay, and sample
   coverage.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect plugin entry points, OpenXR init/render files, engine contexts,
   runtime shim exports, wgpu/Vulkan graphics binding, network ingestion, and
   XR panel/picking code.
5. Extract reusable app-shell methods rather than treating the projects as
   runnable products.
6. Integrate results into registry, families, methods, not-yet queue, current
   focus, and indexes.

## Studied Repositories

| Project | Outcome |
|---|---|
| `awtterpip/bevy_oxr` | Added as Bevy OpenXR plugin/render lifecycle donor |
| `leetvr/hotham` | Added as Rust XR engine context split and OpenXR runtime stub donor |
| `blaind/xrbevy` | Added as legacy Bevy OpenXR architecture caution/reference |
| `matthewjberger/wgpu-example` | Added as explicit wgpu/OpenXR/Vulkan graphics binding sample |
| `robotics-erlangen/xrvis` | Added as live network data to XR panel visualization reference |

## Useful Follow-Up Work

- Build a Rust OpenXR app-shell comparison matrix across raw OpenXR, wgpu,
  Bevy, and custom-engine approaches.
- Extract a minimal "OpenXR app doctor" skeleton from the common init, frame,
  graphics, and input boundaries.
- Compare Bevy XR render-world scheduling with Unity/Godot engine plugin
  boundaries when designing future prototypes.

## Not Pursued In This Wave

- No Rust sample, Android package, Bevy app, OpenXR runtime stub, network
  visualizer, or graphics example was launched.
- No found repository was run, built, installed, imported, or tested.
