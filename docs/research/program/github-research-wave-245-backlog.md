# GitHub Research Wave 245 Backlog

Date: 2026-06-06

Theme: OpenXR micro-layer render shaping, foveation, and tracking diagnostics.

## Completed In This Wave

- Studied `danny1marshall1587-maker/MonoEye` as an experimental OpenXR layer
  with loader negotiation, generated dispatch, view-count intervention,
  internal stereo state, Vulkan utility boundaries, environment config,
  enable/bypass flags, and debug paths.
- Studied `TripleJ160/Beyond-EVO` as a game/hardware-specific D3D12 layer with
  OpenXR session graphics binding capture, VRS Tier 2 checks, eye-gaze actions,
  smoothing/fallback logic, shading-rate image resources, heatmap/debug paths,
  INI config, and named-pipe live controls.
- Studied `marcsabat/xr-tracking-diagnostics` as a minimal OpenXR doctor layer
  with dispatch table setup, session/reference-space management, `xrWaitFrame`
  pose recording, F9 toggle, beeps, logs, duration config, and CSV output.
- Studied `mbucchia/_ARCHIVE_XR_APILAYER_NOVENDOR_nis_scaler` as an archived
  swapchain/post-process layer with D3D11 device wrapping, scaler resources,
  config, stats, screenshots, hotkeys, and resource lifecycle hooks.
- Added a reusable method entry for OpenXR API-layer intervention loops.

## Follow-Up Queue

1. Compare micro-layer safety patterns against OpenXR Toolkit, Quad-Views, API
   layer templates, and layer GUI tooling.
2. Extract a layer-safety checklist covering manifest, config, bypass, logs,
   capability gates, output paths, cleanup, and uninstall story.
3. Split future reuse notes between render-changing layers, diagnostics layers,
   and installer/config helper layers.

## Do Not Spend Time On Yet

- Do not run or install any API layer.
- Do not treat archived NIS scaler code as current best practice.
- Do not promote game/hardware-specific foveation logic as generic without
  separate validation.
