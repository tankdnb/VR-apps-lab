# GitHub Research Wave 192 Plan

- Date: `2026-06-06`
- Theme: `PSVR2 OpenXR passthrough, eye-tracking, and SteamVR integration shims`
- Scope: PSVR2-specific OpenXR API layers, SteamVR eye-tracking shims,
  Monado driver integration, and source-light integration wrappers.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier waves covered OpenXR layers, gaze tracking, passthrough, and vendor
runtime helpers as separate families. Wave 192 narrows the pass around PSVR2
because the projects expose the boundary between vendor hardware signals,
OpenXR/OpenVR compatibility, SteamVR integration, camera feeds, gaze
interaction, and runtime-driver plumbing.

## Search Families

- PSVR2 OpenXR passthrough layers
- PSVR2 SteamVR eye-tracking shims
- PSVR2 Monado/OpenXR driver forks
- OpenXR gaze interaction API layers
- Vendor-specific runtime integration wrappers

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `Obsidiate/psvr2passthrough` | OpenXR implicit API layer injecting PSVR2 camera passthrough into OpenXR frames | PSVR2 passthrough layer donor |
| `BattleAxeVR/PSVR2_STEAMVR_EYE_TRACKING_SHIM` | SteamVR driver shim exposing PSVR2 gaze through `XR_EXT_gaze_interaction` | SteamVR/OpenXR gaze shim donor |
| `DMJC/monado-psvr2` | Monado fork with PSVR2 driver, USB endpoints, camera/SLAM/status handling, and gaze extension context | Runtime driver integration reference |
| `etwodev/Volby` | Source-light PSVR2 SteamVR integration product framing | Thin product reference |
| `mbucchia/_ARCHIVE_OpenXR-Eye-Trackers` | Archived multi-source eye-tracker OpenXR API layer including PSVR2 Toolkit path | Multi-tracker gaze abstraction donor |

## Dedupe Notes

- The wave extends earlier OpenXR layer, gaze, and passthrough research but is
  kept PSVR2-specific.
- Archived or source-light repositories are documented as lineage/reference
  nodes rather than modern primary donors.
- No device, runtime, SteamVR, OpenXR, or calibration tests were attempted.

## Code-Level Pass Targets

- OpenXR API-layer negotiation and dispatch interception.
- Session/frame interception and passthrough composition conditions.
- PSVR2 camera shared-memory ingestion, calibration, and config boundaries.
- SteamVR server-driver shim boundaries and named-pipe gaze ingress.
- Runtime driver prober, USB endpoint, distortion, pose, and status plumbing.
- Multi-source gaze tracker abstraction and stale-data behavior.

## Expected Outputs

- Wave 192 landscape synthesis.
- Registry/family placement for PSVR2 runtime integration projects.
- Methods for camera-passthrough API layers, SteamVR gaze shims, and
  multi-source gaze layers.
