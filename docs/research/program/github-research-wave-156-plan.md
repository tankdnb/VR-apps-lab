# GitHub Research Wave 156 Plan

- Date: `2026-06-05`
- Theme: `OpenXR/VRCFT eye-face modules, calibration clients, and avatar facetracking preparation`
- Scope: VRCFaceTracking modules, OpenXR face/eye extension ingress, avatar
  blendshape preparation, and PSVR2 eye-calibration client design.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier VRCFaceTracking work covered core modules and avatar preparation at a
high level. Wave 156 narrows in on the implementation seams: OpenXR runtime
selection, extension selection, local versus remote tracking ingress,
filtering/sensitivity, avatar authoring helpers, and real-time calibration
clients.

## Search Families

- VRCFaceTracking OpenXR modules
- Meta Quest Pro / ALXR / PSVR2 eye and face tracking
- OpenXR eye-gaze calibration clients
- avatar facetracking templates and threshold editors
- runtime switchers and extension-selection helpers
- unified expression mapping and blendshape preparation

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `regzo2/VRCFaceTracking-QuestProOpenXR` | Direct Meta OpenXR eye/face module for VRCFT with runtime switching and expression mapping | VRCFT OpenXR module variants |
| `korejan/VRCFT-ALXR-Modules` | Dual local/remote ALXR VRCFT modules with extension selection, headless mode, filters, and hot-reloaded sensitivity | VRCFT local/remote ingress modules |
| `PawlygonStudio/VRC-Facetracking` | Avatar-side facetracking package with prefabs, Unified Expression/ARKit setup, threshold editor, and OSC cleanup | Avatar facetracking preparation |
| `tobexeon/PSVR2EyeTrackingCalibration` | Real-time PSVR2 eye-gaze calibration client previously queued as not studied deeply | Eye-tracking calibration clients |

## Dedupe Notes

- `tobexeon/PSVR2EyeTrackingCalibration` already existed as a comparison node
  and is promoted here from `Not studied deeply`.
- `regzo2/VRCFaceTracking-QuestProOpenXR` is archived/broken upstream, so it is
  kept as a method reference rather than a recommended dependency.
- This wave does not duplicate the core VRCFT/template wave; it extracts
  implementation patterns around modules, calibration, and avatar-side setup.

## Code-Level Pass Targets

- runtime selection and teardown behavior;
- OpenXR extension and native DLL boundaries;
- local versus remote tracking ingress;
- filtering, sensitivity, and config hot reload;
- unified expression and ARKit blendshape mapping;
- avatar-side editor tools and OSC config cleanup;
- calibration UX and data persistence.

## Expected Outputs

- New Wave 156 landscape synthesis.
- Registry/family updates for OpenXR/VRCFT and calibration nodes.
- Methods around local/remote tracking modules, expression mapping, avatar
  facetracking authoring, and real-time calibration clients.
