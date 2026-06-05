# GitHub Research Wave 170 Plan

- Date: `2026-06-05`
- Theme: `Quest, PICO, HoloLens marker tracking and remote hand-data utilities`
- Scope: passthrough camera marker tracking, vendor marker callbacks, HoloLens
  Research Mode pipelines, reusable Unity ArUco calibration packages, and
  remote Quest hand-tracking transports.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Marker tracking and remote hand-data utilities sit between diagnostics,
calibration, tracking helpers, and mixed-reality prototyping. Wave 170 studies
how small projects turn camera frames, vendor callbacks, or hand skeleton data
into reusable scene transforms and network streams.

## Search Families

- Quest passthrough camera marker tracking
- PICO Enterprise marker callbacks
- HoloLens ArUco and Research Mode camera pipelines
- Unity ArUco calibration packages
- remote Quest hand tracking over UDP/TCP

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `TakashiYoshinaga/QuestArUcoMarkerTracking` | Quest passthrough camera ArUco/ChArUco tracking with camera intrinsics and marker object mapping | Quest marker tracking donor |
| `picoxr/ArUcoMarkerTracking` | PICO Enterprise marker callback sample with seethrough and marker ID pose updates | PICO vendor marker callback donor |
| `handzlikchris/Unity.QuestRemoteHandTracking` | Remote Quest hand data sender/receiver with UDP pose stream and TCP skeleton/mesh stream | Remote hand-data bridge donor |
| `doughtmw/ArUcoDetectionHoloLens-Unity` | HoloLens ArUco project with camera calibration, HoloLensForCV, and Research Mode context | HoloLens marker tracking reference |
| `NormandErwan/ArucoUnity` | General Unity ArUco package with camera abstraction and calibration controllers | Unity ArUco calibration package donor |
| `nooway077/HoloLens2CVExperiments` | HoloLens2 Research Mode and non-Research Mode marker pose experiments | HoloLens CV pose pipeline donor |

## Dedupe Notes

- The wave keeps both Quest/PICO vendor paths because the implementation model
  differs: local OpenCV detection vs vendor marker callback.
- HoloLens repositories include bundled dependencies and older setups; they are
  documented as pipeline references rather than clean code donors.
- `Unity.QuestRemoteHandTracking` is kept for protocol structure despite older
  OVR/XML choices.

## Code-Level Pass Targets

- passthrough camera intrinsics scaling and marker pose estimation;
- marker ID to GameObject mapping and debug texture/object toggles;
- vendor marker callback registration and seethrough lifecycle;
- hand pose/skeleton/mesh transport split across UDP/TCP;
- HoloLens Research Mode camera intrinsics/extrinsics and marker-to-world
  transform composition;
- Unity ArUco camera, board, ChArUco, and calibration package structure.

## Expected Outputs

- New Wave 170 landscape synthesis.
- Registry/family placement for marker tracking, hand-data streaming, and
  HoloLens CV utility lines.
- Methods around calibrated passthrough marker tracking, vendor marker
  callbacks, remote hand-data split transport, Unity ArUco calibration
  packages, and HoloLens research-mode marker pose pipelines.
