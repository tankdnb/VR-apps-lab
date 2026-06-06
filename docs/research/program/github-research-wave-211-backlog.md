# GitHub Research Wave 211 Backlog

Date: 2026-06-06

Theme: VR teleoperation control surfaces, robot bridges, HUDs, and safety gates.

## Completed In This Wave

- Deepened `h2r/GHOST` as a Unity/Quest ROS teleoperation frontend.
- Deepened `nakama-lab/VR_Teleop_Interface` as architecture documentation for ROS2/Unity/ZED command and safety flows.
- Deepened `kscalelabs/kbot_vr_teleop` as a WebXR to Python IK/UDP robot command bridge.
- Deepened `open-thought/cambot` as a WebXR stereo camera teleop stack with HUD, transport, calibration, and safety gates.
- Added a reusable method entry for WebXR/VR teleoperation control surfaces with feedback and safety gating.

## Follow-Up Queue

1. Extract a general "VR control surface with safety gates" pattern that can apply to overlay automation, remote desktops, and diagnostics tools, not only robots.
2. Compare WebXR and Unity teleop frontends for portability, hand-tracking support, HUD design, and deployment friction.
3. Use `cambot` as the strongest donor for watchdog, pause/home, calibration, transport selection, and HUD telemetry.
4. Use `kbot_vr_teleop` as the strongest donor for headset frontend plus Python control/IK sidecar boundaries.
5. Preserve `VR_Teleop_Interface` diagrams as a documentation reference for command/status/error sequences.

## Do Not Spend Time On Yet

- Do not run robot, IK, or WebXR servers from these projects.
- Do not treat robot-specific command schemas as reusable without abstraction.
- Do not copy safety code without adapting it to the target actuator/runtime risk model.
