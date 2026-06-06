# GitHub Research Wave 213 Plan

Date: 2026-06-06

Theme: MRTK spatial UI, graphics, robotics, and gaze extension nodes.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

MRTK-related repositories are useful not because `VR-apps-lab` should become a
HoloLens project, but because they show mature boundaries for spatial UI:
interaction state, layout/data binding, visual feedback, accessibility,
extension services, calibration buttons, and alternate gaze inputs.

Wave 213 deepens MRTK and related extension nodes to extract reusable package
and component contracts for future VR utility surfaces.

## Search Families

- MRTK3 spatial UI and interaction packages.
- Mixed Reality graphics and shader feedback helpers.
- MRTK extension services for robotics and calibration.
- Gaze, dwell, and alternate input interaction layers.
- Accessibility and data-binding subsystems.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `MixedRealityToolkit/MixedRealityToolkit-Unity` | MRTK3 package baseline with XRI/OpenXR, stateful interactables, data binding, solvers, and accessibility packages. | Spatial UI package baseline |
| `microsoft/MixedReality-GraphicsTools-Unity` | MR visual fidelity package with proximity lights, material animators, mesh instancing, text inversion, and magnifier utilities. | Spatial visual feedback substrate |
| `ms-iot/ros_msft_mrtk` | Archived ROS2/MRTK HoloLens extension showing node singleton, lidar provider/renderer, QR spatial pinning, and hand-menu calibration. | MRTK robotics extension service |
| `The-COGAIN-Association/EyeMRTK` | Legacy gaze interaction toolkit with ray normalization, smoothing/saccade detection, dwell, and confirmation flows. | Gaze interaction layer |

## Dedupe Notes

MRTK has appeared before as a platform reference, but the registry did not yet
extract the reusable boundary between interaction state, data binding, shader
feedback, accessibility, extension services, and gaze input.

## Code-Level Pass Targets

- Package boundaries and feature ownership.
- Stateful interactable and pressable-button contracts.
- Data binding, theming, list placement, and pooling.
- Solver and placement tracking.
- Shader/material feedback helpers and performance utilities.
- Accessibility provider and visual override boundaries.
- Gaze smoothing, dwell, confirmation, and event dispatch.

## Expected Outputs

- Wave 213 landscape synthesis.
- Registry and family deepening for MRTK and related extension nodes.
- Method catalog entry for spatial UI package boundaries across interaction,
  data, visual, and accessibility layers.
- Follow-up backlog for adapting MRTK lessons to engine-neutral VR utility
  panels.
