# GitHub Research Wave 160 Plan

- Date: `2026-06-05`
- Theme: `Foveated rendering, quad-view settings, and graphics-layer adaptation helpers`
- Scope: quad-view companion settings, OpenVR/OpenXR foveation shims, vendor
  SDK compatibility layers, and Unity native VRS integration.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier OpenXR and overlay waves covered runtime tools, API layers, and
passthrough helpers. Wave 160 adds a narrower rendering-adaptation slice:
projects that alter foveation, quad-view configuration, recommended view
sizes, rendering submission, or vendor feature availability without requiring
the target application to be rewritten.

## Search Families

- OpenXR foveated rendering layers
- Varjo quad-view and foveated rendering helpers
- OpenVR fixed foveated rendering wrappers
- Unity native plugin VRS integrations
- vendor SDK compatibility shims
- source-light quad-view settings companions

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `TallyMouse/QuadViewsCompanion` | Source-light companion for safely creating and editing QuadViews settings | Quad-view settings companions |
| `mbucchia/PimaxMagic4All` | Vendor SDK emulation shim that brings Pimax LibMagic DFR to non-Pimax headsets | Vendor foveated-rendering compatibility layers |
| `fholger/openvr_foveated` | OpenVR `openvr_api.dll` wrapper with RDM/VRS fixed foveated rendering and hotkeys | OpenVR foveated rendering wrappers |
| `mbucchia/_ARCHIVE_Varjo-Foveated` | Archived OpenXR API layer translating quad-view/foveated Varjo extension behavior | OpenXR quad-view/foveation API layers |
| `ViveSoftware/ViveFoveatedRendering` | Unity package plus native D3D11/NVAPI VRS plugin with eye-tracking support | Unity native VRS integration |

## Dedupe Notes

- `mbucchia/Quad-Views-Foveated`, `mbucchia/OpenXR-Vk-D3D12`,
  `OpenXR-Toolkit`, and earlier OpenXR layer projects remain comparison
  context and were not duplicated.
- `QuadViewsCompanion` is intentionally classified as source-light because its
  public donor surface is installer/README level, but its settings UX is still
  relevant.

## Code-Level Pass Targets

- settings backup, validation, locale handling, and runtime exclusion patterns;
- vendor SDK function emulation and provider fallback chains;
- OpenVR DLL replacement and compositor/D3D11 hook boundaries;
- OpenXR `next` chain injection, view configuration, and frame/FOV patches;
- Unity command buffer placement and native plugin event flow;
- VRS capability checks, preset surfaces, and unsupported-hardware fallback.

## Expected Outputs

- New Wave 160 landscape synthesis.
- Registry/family updates for foveation helpers and rendering-adaptation
  layers.
- Methods around safe quad-view config companions, vendor SDK emulation,
  OpenVR submission wrappers, OpenXR view-chain adapters, and Unity VRS plugin
  splits.
