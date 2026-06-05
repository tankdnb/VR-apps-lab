# VR Projects Wave 170: Quest, PICO, HoloLens Marker Tracking and Remote Hand-Data Utilities

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 170 studies camera and tracking utilities that turn passthrough frames,
vendor marker callbacks, HoloLens CV data, or Quest hand state into reusable
poses, scene objects, and remote streams.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `TakashiYoshinaga/QuestArUcoMarkerTracking` | Quest marker tracking donor | Strong calibrated passthrough marker donor |
| `picoxr/ArUcoMarkerTracking` | PICO marker callback donor | Strong vendor callback reference |
| `handzlikchris/Unity.QuestRemoteHandTracking` | Remote hand-data bridge donor | Strong protocol split reference |
| `doughtmw/ArUcoDetectionHoloLens-Unity` | HoloLens marker tracking reference | Useful packaged calibration reference |
| `NormandErwan/ArucoUnity` | Unity ArUco calibration package donor | Strong reusable package reference |
| `nooway077/HoloLens2CVExperiments` | HoloLens CV pose pipeline donor | Strong Research Mode transform reference |

## `TakashiYoshinaga/QuestArUcoMarkerTracking`

- Interesting idea:
  use Quest passthrough camera access plus OpenCVForUnity to detect ArUco and
  ChArUco markers, scale camera intrinsics to current resolution, and map
  marker IDs to scene objects.
- Code donor value:
  high for camera intrinsic matrix construction, detector parameter tuning,
  marker pose estimation, debug texture toggles, and marker ID/object updates.
- Product reference value:
  high for Quest calibration tools, marker-assisted alignment, diagnostics, and
  mixed-reality utility prototypes.
- What to inspect next:
  compare Quest camera intrinsics flow against Meta official passthrough/camera
  samples and generic OpenCV marker packages.
- Source evidence:
  `QuestMarkerTracking_New/Assets/Scripts/ArUcoMarkerTracking.cs`,
  `ArUcoTrackingAppCoordinator.cs`, and `CameraImageAduster.cs`.
- Reusable pattern extraction:
  calibrated passthrough-camera ArUco marker pose pipeline.
- Reusable core:
  retrieve camera intrinsics, scale focal length and principal point to the
  active frame size, set detector/refine parameters, detect markers, estimate
  canonical marker pose, and use marker IDs to update named scene objects.
- Do not copy directly:
  vendor-specific setup without runtime capability checks.
- Caveats:
  Unity/Meta/OpenCVForUnity dependent and camera APIs are vendor/version
  sensitive.

## `picoxr/ArUcoMarkerTracking`

- Interesting idea:
  use PICO Enterprise marker tracking callbacks instead of local OpenCV
  detection, then create/update scene objects by marker ID and pose.
- Code donor value:
  medium-high for vendor callback setup, seethrough lifecycle, marker object
  map, and resume handling.
- Product reference value:
  high for vendor-specific marker utilities and device capability comparisons.
- What to inspect next:
  compare vendor-provided marker pose quality and coordinate frames with local
  OpenCV detection on Quest.
- Source evidence:
  `Assets/Scripts/MarkerScanning.cs` and `Assets/Scripts/SeethroughManager.cs`.
- Reusable pattern extraction:
  vendor marker-callback scene-object map.
- Reusable core:
  initialize vendor enterprise service, bind marker callbacks with tracking
  origin mode, enable seethrough, and keep a dictionary from marker IDs to
  GameObjects updated from callback poses.
- Do not copy directly:
  large bundled SDK packages when only the callback pattern is needed.
- Caveats:
  PICO Enterprise API specific; not portable without abstraction.

## `handzlikchris/Unity.QuestRemoteHandTracking`

- Interesting idea:
  stream Quest hand state remotely by sending high-frequency hand pose data over
  UDP and heavier skeleton/mesh data over length-prefixed TCP packets, with
  optional gzip and XML serialization.
- Code donor value:
  high for transport split, packet framing, sender/receiver queueing, and Unity
  event handoff.
- Product reference value:
  high for remote diagnostics, desktop preview, recording, and tracker/hand
  bridge utilities.
- What to inspect next:
  compare XML/gzip/UDP/TCP choices against OSC, WebSocket, protobuf, and binary
  pose packet formats used in other waves.
- Source evidence:
  `PacketProtocol.cs`, `HandsDataSender.cs`, `HandsDataReceiver.cs`,
  `HandsDataRecorder`, `HandsDataPlayer`, OVR feeder classes, gzip helpers, and
  TCP/UDP utilities.
- Reusable pattern extraction:
  remote hand-data split transport: UDP poses plus TCP skeleton/mesh with
  length-prefixed framing.
- Reusable core:
  send frequently changing pose data over a lossy low-latency channel, send
  bulky skeleton/mesh snapshots over reliable framed packets, process receive
  queues on Unity's main thread, and expose updates through events.
- Do not copy directly:
  older OVRPlugin/XML implementation choices without modernizing.
- Caveats:
  useful protocol lesson; serialization and API layer are dated.

## `doughtmw/ArUcoDetectionHoloLens-Unity`

- Interesting idea:
  package a HoloLens ArUco detection project with OpenCV/HoloLensForCV,
  calibration assets, and Research Mode context.
- Code donor value:
  low-medium because the repository is dependency-heavy, but useful for
  calibration setup and HoloLens CV project structure.
- Product reference value:
  medium for HoloLens marker-tracking research workflows.
- What to inspect next:
  locate the smallest modern HoloLens2 marker sample with cleaner dependency
  boundaries.
- Source evidence:
  Unity project structure, `HoloLensCamCalib`, `HoloLensForCV`, bundled MRTK
  context, OpenCV package references, and README guidance.
- Reusable pattern extraction:
  HoloLens ArUco calibration/Research Mode project packaging reference.
- Reusable core:
  keep camera calibration data explicit and treat HoloLens CV dependencies as a
  separate layer from application marker behavior.
- Do not copy directly:
  bundled dependency folders or old MRTK/OpenCV package state.
- Caveats:
  packaged sample rather than clean donor; document as reference only.

## `NormandErwan/ArucoUnity`

- Interesting idea:
  provide a reusable Unity ArUco package with camera abstraction, board and
  ChArUco calibration, multi-camera image buffers, asynchronous calibration,
  and camera-parameter persistence.
- Code donor value:
  high for package structure, calibration controllers, camera abstraction, and
  saved parameter flow.
- Product reference value:
  high for calibration wizards and marker-tracking helper tools.
- What to inspect next:
  extract a small calibration wizard pattern that can be reused independently
  of the older package.
- Source evidence:
  `Assets/ArucoUnity/Scripts/Cameras/ArucoCamera.cs`,
  `Calibrations/ArucoCameraCalibration.cs`, and
  `Editor/ExportArucoUnityPackage.cs`.
- Reusable pattern extraction:
  Unity ArUco calibration package architecture with async multi-camera/ChArUco
  capture.
- Reusable core:
  abstract camera sources, collect marker corners/IDs/images per camera, require
  enough observations, support ChArUco interpolation, run calibration
  asynchronously, and save timestamped camera parameters.
- Do not copy directly:
  old Unity/OpenCV package assumptions without maintenance review.
- Caveats:
  more general AR/CV package than VR-specific utility.

## `nooway077/HoloLens2CVExperiments`

- Interesting idea:
  compare HoloLens2 Research Mode spatial camera marker tracking with a
  non-Research Mode OpenCV bridge, exposing intrinsics, marker pose estimation,
  and camera-to-world transform composition.
- Code donor value:
  high for HoloLens camera calibration constants, Research Mode camera loop,
  marker-to-camera and camera-to-world composition, and HUD diagnostics.
- Product reference value:
  high for HoloLens/AR utility diagnostics and coordinate-frame lessons.
- What to inspect next:
  extract a coordinate transform note comparing HoloLens, Quest, PICO, and
  generic Unity/OpenCV marker flows.
- Source evidence:
  `aruco-pose-estimation/projects/researchmode/.../MarkerTracker.cs`,
  `nonresearchmode/OpenCVBridge/OpenCVBridge/OpenCVHelper.cpp`, and
  `CameraUtils.cs`.
- Reusable pattern extraction:
  HoloLens research-mode marker pose pipeline with camera-to-world transform
  composition.
- Reusable core:
  initialize spatial cameras, set camera intrinsics per sensor, detect markers,
  estimate marker-to-camera pose, compose with camera-to-world transforms, and
  surface live diagnostics.
- Do not copy directly:
  HoloLens-specific setup into portable VR tools.
- Caveats:
  HoloLens-specific and older; still valuable for coordinate reasoning.

## Cross-Project Lessons

- Marker tracking utilities should separate camera source, intrinsics,
  detection/callback, coordinate transform, and scene-object mapping.
- Vendor callbacks can be simpler than local OpenCV, but reduce portability.
- Remote tracking bridges benefit from transport separation: high-frequency
  pose data and heavy structural data often deserve different channels.
- HoloLens and Quest/PICO flows should be compared by coordinate frames and
  calibration data rather than by README feature lists.
