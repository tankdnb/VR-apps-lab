# GitHub Research Wave 236 Backlog

Date: 2026-06-06

Theme: VR locomotion, embodiment, and comfort microcontrols.

## Completed In This Wave

- Studied `RoWoCha/LocomotionVR` as a SteamVR locomotion demo with HMD-relative
  joystick movement, speed ramping, dynamic CharacterController height,
  snap-turn rotation around the head, speed-linked vignette intensity,
  snap-turn full vignette, and trigger-volume intensity gates.
- Studied `pascalmariany/Unity-WebXR-Teleportation-and-SmoothLocomotion` as a
  WebXR movement/teleport hybrid with deadzone-filtered thumbstick movement,
  optional camera-yaw rotation, controller-axis teleport preview delay,
  release-to-commit teleport, ballistic arc linecast, marker placement, and
  head/body offset compensation.
- Studied `dabeschte/VRArmIK` as a head/hand-only avatar embodiment donor with
  persisted HMD and wrist calibration, shoulder pose estimation, behind-head
  handling, arm-length clamping, elbow rotation, and local XR node input.
- Checked `ralph-immrsv/UnityVR-ArmSwingMovement`; the local checkout contained
  only git/ignore metadata and no usable source, so it is recorded as a
  source-light exclusion note rather than a donor.
- Added a reusable method entry for a comfort-aware locomotion and embodiment
  microcontrol stack.

## Follow-Up Queue

1. Compare comfort vignette logic across locomotion demos, game retrofit mods,
   and accessibility locomotion systems.
2. Extract a small movement wrapper pattern that separates input source,
   movement mode, comfort policy, and avatar/collider adaptation.
3. Compare WebXR teleport preview/commit flows against Unity XR Interaction
   Toolkit and A-Frame teleport components.
4. Build a head/hand-only embodiment caveat matrix: calibration, arm length,
   shoulder pose, behind-head motion, and tool offsets.

## Do Not Spend Time On Yet

- Do not run Unity or browser demos.
- Do not copy demo scenes, assets, or controller binding defaults directly.
- Do not treat source-light arm-swing search results as studied donors until
  usable source is available.
