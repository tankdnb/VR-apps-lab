# GitHub Research Wave 192 Backlog

- Date: `2026-06-06`
- Theme: `PSVR2 OpenXR passthrough, eye-tracking, and SteamVR integration shims`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for PSVR2 passthrough, SteamVR eye tracking, Monado
  PSVR2 driver, and OpenXR eye-tracker layer projects.
- `Done` Dedupe against earlier OpenXR layer, gaze, passthrough, and runtime
  helper waves.
- `Done` Freeze a PSVR2-specific shortlist around camera passthrough, gaze,
  and runtime-driver plumbing.

## Source Sync

- `Done` Confirm `psvr2passthrough` in local-only cache.
- `Done` Confirm `PSVR2_STEAMVR_EYE_TRACKING_SHIM` in local-only cache.
- `Done` Confirm `monado-psvr2` in local-only cache.
- `Done` Confirm `Volby` in local-only cache.
- `Done` Confirm `_ARCHIVE_OpenXR-Eye-Trackers` in local-only cache.

## Code Reading

- `Done` Inspect OpenXR API-layer negotiation, dispatch table, session
  adoption, frame interception, config loading, button toggles, and D3D11
  composition path in `psvr2passthrough`.
- `Done` Inspect PSVR2 shared-memory camera feed, calibration metadata,
  per-eye swapchains, IPD handling, visibility gates, and caveats in
  `psvr2passthrough`.
- `Done` Inspect SteamVR server-driver detour, HMD wrapping, named-pipe gaze
  protocol, validity checks, and calibration caveats in
  `PSVR2_STEAMVR_EYE_TRACKING_SHIM`.
- `Done` Inspect Monado PSVR2 driver option, USB endpoint constants, prober,
  distortion, pose/view handling, status/SLAM/camera flows, and runtime
  integration boundaries in `monado-psvr2`.
- `Done` Inspect archived OpenXR eye-tracker API-layer extension handling,
  tracker selection, PSVR2 Toolkit TCP polling, gaze validity, and stale-data
  behavior in `_ARCHIVE_OpenXR-Eye-Trackers`.
- `Done` Mark `Volby` as source-light product framing only.

## Integration

- `Done` Create Wave 192 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for PSVR2 passthrough layers, SteamVR gaze shims,
  and multi-source OpenXR gaze layers.
- `Next` Extract a PSVR2 calibration and safety matrix covering camera
  latency, distortion, reprojection, gaze validity, and driver/runtime risks.
