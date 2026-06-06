# GitHub Research Wave 242 Backlog

Date: 2026-06-06

Theme: CV, mocap, and industrial VR training control loops.

## Completed In This Wave

- Studied `WestCoastGod/XR-CV-Forceps-Tracking-Unity` as a strong donor for
  physical-tool MR interaction: ArUco marker detection, multi-marker rigid pose
  estimation, reprojection error, One Euro filters for position/rotation/scale,
  visibility-marker clamp state, clamp freeze, geometric object-size mapping,
  and XRI grab/release state.
- Studied `jghanania/MotionCapture-AgilityLadder-XR-Study` as a Quest/OptiTrack
  research harness with balanced Latin-square condition ordering, AR/VR/real
  world mode switching, occlusion control, avatar scaling, camera-rig alignment
  to mocap head markers, ladder path sequencing, foot-contact measurement, and
  participant CSV logging.
- Studied `jesusfernandorl/Industrial_Twin_XR-Safe-Robotics-and-6-Axis-VR-Control`
  as a source-light industrial training reference for deadman switch, soft
  limits, interlock logic, physical HMI feedback, spatial audio, Unity Robotics
  Hub/ROS future direction, and safety-standard framing.
- Studied `purva-rana/MindscapeVR` as a source-light rehab narrative reference
  for clinical-room to abstract mindscape transition, neural blockage
  metaphors, and trigger-driven difficulty escalation.
- Added a reusable method entry for sensor-tracked training/control loops with
  calibration, smoothing, safety, feedback, and logging boundaries.

## Follow-Up Queue

1. Build a matrix across ArUco, OptiTrack, EMG/accelerometer, ROS, WebSocket,
   OSC, and VRChat avatar-parameter ingress paths.
2. Compare this wave's CSV logging with the XR research data lifecycle and
   validation waves.
3. Find a code-backed industrial robot VR training repo with deadman,
   interlock, soft-limit, and HMI source before deepening that branch.

## Do Not Spend Time On Yet

- Do not run Quest camera, OpenCV, OptiTrack, Unity, or robot simulations.
- Do not promote medical or industrial claims beyond source-observed design
  references.
- Do not copy hardware marker IDs, lab naming, or local CSV paths as defaults.
