# GitHub Research Wave 168 Plan

- Date: `2026-06-05`
- Theme: `Rust, Bevy, wgpu, and OpenXR app/rendering bring-up`
- Scope: Rust OpenXR app shells, Bevy XR plugin boundaries, wgpu/Vulkan
  graphics binding, OpenXR runtime stubs, and live-data XR visualization.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier OpenXR waves covered runtime, layer, overlay, and validation families.
Wave 168 looks at the application bring-up layer: how a tool or prototype can
own an OpenXR session, graphics binding, input loop, render loop, and optional
engine integration without turning into a monolithic app.

## Search Families

- Rust OpenXR examples and engines
- Bevy OpenXR plugins and architecture notes
- wgpu/OpenXR/Vulkan interop samples
- OpenXR runtime stubs and test harnesses
- live network data visualization in XR

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `awtterpip/bevy_oxr` | Bevy OpenXR plugin stack with render-world integration, actions, passthrough, hands, and overlay examples | Bevy OpenXR plugin donor |
| `leetvr/hotham` | Rust mobile VR engine with split XR/Vulkan/render/input/audio/gui/haptics contexts and OpenXR client stub | Rust XR engine/test harness donor |
| `blaind/xrbevy` | Earlier Bevy OpenXR architecture notes around renderer ownership, swapchains, and handle transfer | Bevy OpenXR architecture caution |
| `matthewjberger/wgpu-example` | Minimal wgpu/OpenXR/Vulkan bring-up with Android and desktop entry paths | wgpu/OpenXR graphics binding donor |
| `robotics-erlangen/xrvis` | Live network data visualization with Bevy XR panels, controller-ray UI picking, and multicast discovery | Live-data XR visualization reference |

## Dedupe Notes

- Broad OpenXR sample searches produced many already-studied loader, layer, and
  runtime repositories; this wave keeps only application/engine bring-up nodes.
- `xrbevy` is older and mainly valuable as an architecture lesson, not as a
  current implementation baseline.
- `hotham` produced Git LFS pointer warnings for image assets, but source files
  needed for static reading were available.

## Code-Level Pass Targets

- OpenXR instance/system/session initialization and extension selection;
- Bevy render-world handoff and custom render plugin scheduling;
- wgpu/Vulkan device creation and runtime graphics requirements;
- OpenXR frame wait/begin/end and swapchain image lifecycle;
- engine context splits, focused-state update loops, and HMD/stage entities;
- OpenXR runtime shim entry points for loader/runtime negotiation;
- live data ingestion, panel spawning, and ray-to-UI pointer forwarding.

## Expected Outputs

- New Wave 168 landscape synthesis.
- Registry/family placement for Rust and Bevy OpenXR app bring-up donors.
- Methods around Bevy OpenXR render-plugin lifecycle, Rust XR engine context
  splits, OpenXR runtime stubs, wgpu/OpenXR/Vulkan graphics binding, and
  network-data-to-XR panel visualization.
