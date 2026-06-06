# GitHub Research Wave 245 Plan

Date: 2026-06-06

Theme: OpenXR micro-layer render shaping, foveation, and tracking diagnostics.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

The repository already has many OpenXR runtime and layer references. This wave
adds narrow API-layer variants that show how to intervene in views, frames,
swapchains, graphics devices, and diagnostics without studying another large
toolkit end-to-end.

## Search Families

- OpenXR API layers.
- Render-scaling and post-processing layers.
- Foveated rendering and gaze-driven layers.
- Tracking diagnostics and recorder layers.
- Archived/superseded micro-layers with clear source evidence.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `danny1marshall1587-maker/MonoEye` | Experimental OpenXR layer that reports mono view state and uses depth-warp reconstruction concepts. | Render-shaping layer reference |
| `TripleJ160/Beyond-EVO` | D3D12/VRS foveated-rendering layer with eye-gaze pipeline, capability gates, config, and named-pipe controls. | Foveation/control donor |
| `marcsabat/xr-tracking-diagnostics` | Minimal tracking recorder layer intercepting frame/session flow and writing pose CSV traces. | Diagnostic layer donor |
| `mbucchia/_ARCHIVE_XR_APILAYER_NOVENDOR_nis_scaler` | Archived NIS scaler ancestor with swapchain/resource hooks, D3D11 resources, stats, hotkeys, and screenshots. | Archived post-process layer reference |

## Dedupe Notes

Existing registry entries include OpenXR Toolkit, Quad-Views-Foveated,
OpenXR-Layer-Template, validation tools, and layer GUIs. This wave keeps only
micro-layers that add a distinct boundary lesson: view-count intervention,
D3D12/VRS/gaze gates, tiny recorder hook surface, or archived swapchain scaler
resource management.

## Code-Level Pass Targets

- Loader negotiation and dispatch table setup.
- Hook scope and bypass/config strategy.
- Session graphics binding and device capability checks.
- View/frame/swapchain interception.
- Gaze/action pipeline and VRS resource management.
- Pose recording, CSV trace schema, and user feedback.

## Expected Outputs

- Wave 245 landscape synthesis.
- Registry/family entry for OpenXR micro-layer variants.
- Method catalog entry for API-layer intervention boundaries.
- Follow-up backlog for layer-safety checklist and comparison with larger
  OpenXR toolkits.
