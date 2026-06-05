# GitHub Research Wave 170 Backlog

- Date: `2026-06-05`
- Theme: `Quest, PICO, HoloLens marker tracking and remote hand-data utilities`
- Status: `Completed`

## Completed Pass

1. Search Quest, PICO, HoloLens, Unity ArUco, and remote hand-tracking utility
   repositories.
2. Deduplicate against existing tracking-helper, camera, passthrough, and
   hand-tracking coverage.
3. Sync shortlisted source into local-only cache for static reading.
4. Inspect passthrough camera intrinsic scaling, ArUco/ChArUco detection,
   marker ID scene mapping, PICO Enterprise callbacks, seethrough lifecycle,
   OVR hand polling, UDP/TCP hand transport, HoloLens CV bridge files, Research
   Mode camera transforms, and Unity calibration package scripts.
5. Mark bundled/old dependency-heavy repositories as references with caveats.
6. Integrate results into registry, families, methods, not-yet queue, current
   focus, and indexes.

## Studied Repositories

| Project | Outcome |
|---|---|
| `TakashiYoshinaga/QuestArUcoMarkerTracking` | Added as calibrated Quest passthrough camera marker-tracking donor |
| `picoxr/ArUcoMarkerTracking` | Added as PICO vendor marker callback and seethrough lifecycle donor |
| `handzlikchris/Unity.QuestRemoteHandTracking` | Added as remote Quest hand-data split transport donor |
| `doughtmw/ArUcoDetectionHoloLens-Unity` | Added as dependency-heavy HoloLens ArUco calibration/Research Mode reference |
| `NormandErwan/ArucoUnity` | Added as reusable Unity ArUco camera/calibration package donor |
| `nooway077/HoloLens2CVExperiments` | Added as HoloLens2 Research Mode marker pose pipeline donor |

## Useful Follow-Up Work

- Build a marker-tracking matrix across Quest, PICO, HoloLens, and generic
  Unity/OpenCV flows.
- Extract a small "camera intrinsics to marker pose" checklist for future
  passthrough/camera helper prototypes.
- Compare hand-data transport choices: OSC, WebSocket, UDP/TCP, named pipes,
  and file replay.

## Not Pursued In This Wave

- No Quest app, PICO app, HoloLens app, Unity package, camera feed, OpenCV
  pipeline, or hand-tracking stream was launched.
- No found repository was run, built, installed, imported, or tested.
