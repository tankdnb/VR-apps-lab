# GitHub Research Wave 213 Backlog

Date: 2026-06-06

Theme: MRTK spatial UI, graphics, robotics, and gaze extension nodes.

## Completed In This Wave

- Deepened `MixedRealityToolkit/MixedRealityToolkit-Unity` as the MRTK3
  package baseline for XRI/OpenXR, stateful interactables, data binding,
  solvers, and accessibility.
- Studied `microsoft/MixedReality-GraphicsTools-Unity` as a visual feedback and
  performance substrate for MR materials, proximity lights, instancing, text
  inversion, and magnification.
- Studied `ms-iot/ros_msft_mrtk` as an archived MRTK robotics extension with
  ROS2 node ownership, lidar provider/renderer separation, QR spatial pinning,
  and hand-menu calibration.
- Studied `The-COGAIN-Association/EyeMRTK` as a legacy gaze interaction layer
  with ray sources, smoothing, saccade detection, dwell, and confirmation.
- Added a reusable method entry for spatial UI package boundaries with
  interaction, data, visual, and accessibility layers.

## Follow-Up Queue

1. Build an engine-neutral spatial UI contract inspired by MRTK: interactable,
   visual state, data source, placement solver, and accessibility provider.
2. Compare MRTK hand menus, near/far interaction, gaze dwell, and controller
   confirmation with existing VR menu and overlay families.
3. Use Graphics Tools as a reference for separating visual-material feedback
   from input logic.
4. Use `ros_msft_mrtk` as a cautionary but useful example of extension services
   and calibration actions behind a hand menu.
5. Convert EyeMRTK's gaze pipeline into a reusable alternate-input checklist.

## Do Not Spend Time On Yet

- Do not migrate old HoloLens or Unity 2017 code.
- Do not treat MRTK package APIs as engine-neutral without adaptation.
- Do not run Unity samples or package imports from the studied repositories.
