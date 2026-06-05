# GitHub Research Wave 173 Plan

- Date: `2026-06-05`
- Theme: `OpenXR API-layer adaptation, hand transform offsets, and graphics compatibility`
- Scope: OpenXR API layers that adapt incoming data, modify hand transforms,
  bridge unsupported graphics bindings, or provide minimal layer skeletons for
  future diagnostics and runtime helpers.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

The repository has many OpenXR layer references, but this wave narrows onto
runtime-side adaptation: turning OSC data into standard OpenXR extensions,
offsetting hand tracking at the API boundary, substituting incompatible
graphics bindings, and starting small layer experiments from modern templates.

## Search Families

- OpenXR API-layer templates
- OpenXR facial/eye tracking adapters
- OpenXR hand tracking transform layers
- graphics-binding compatibility layers
- runtime-side diagnostics and capability shims

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `LordOfDragons/openxr_oscclient` | OSC eye/face tracking data exposed through OpenXR extension functions | Protocol-to-OpenXR extension adapter |
| `CraigMason/OpenXR-Hand-Transform-Offset-Layer` | Micro-layer that offsets hand joint poses for desktop-mounted hand tracking | Hand tracking coordinate adaptation layer |
| `Sorenon/sorenon_openxr_layer` | Rust layer that replaces unsupported OpenGL paths with Vulkan/external-memory compatibility | Graphics compatibility API layer |
| `maluoi/openxr-layer-template` | Minimal C11/CMake template with generated dispatch and manifest scaffolding | OpenXR layer starter template |

## Dedupe Notes

- `LordOfDragons/openxr_oscclient` was already visible in the follow-up queue;
  this wave upgrades it into a deeper source-level study.
- Prior OpenXR layer waves cover passthrough, foveation, validation, and
  capability injection; this wave adds adaptation and compatibility as the
  coherent theme.
- `maluoi/openxr-layer-template` is separate from earlier template references
  because it is a compact C template with generated dispatch structure.

## Code-Level Pass Targets

- OpenXR loader negotiation, extension filtering, instance/session/space
  interception, and OSC receive mapping;
- hand-joint transform interception through `xrLocateHandJointsEXT` and
  reloadable text config;
- graphics binding substitution, runtime detection, session/swapchain wrapper
  registries, and external-memory release paths;
- C layer dispatch skeleton, generated functions, manifest disable controls,
  and minimal override/requested function lists.

## Expected Outputs

- New Wave 173 landscape synthesis.
- Registry/family placement for OpenXR adaptation and compatibility layers.
- Methods around OSC-to-extension adapters, runtime-side hand transform
  correction, graphics compatibility layers, and minimal layer templates.
