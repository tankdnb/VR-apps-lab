# GitHub Research Wave 343 Plan - Physics Hands, Two-Hand Interaction, and Hand Data Capture Baselines

## Goal

Study hand-physics and two-hand interaction projects that expose reusable
patterns for force-following hands, dynamic attach points, cross-platform hand
data, recording/playback, and WebXR hand prototypes.

## Research Questions

- How do physics hands separate tracked input, bone manipulation, rigidbody
  following, and grab behavior?
- What is reusable from two-hand interactions such as bows, staffs, sticks,
  and dynamic attach points?
- How should hand data capture/playback and provider APIs be represented as a
  reusable utility method?

## Shortlist

- `oxters168/VRPhysicsHands`
- `emilyslouie/xri-two-hands`
- `needle-mirror/com.unity.xr.hands`
- `sketchpunklabs/xrhand`

## Required Checks

- Deduplicate against prior XR Hands, hand gesture, and WebXR hand waves.
- Sync source only into local-only cache with LFS smudge disabled.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.
- Mark dependency-heavy samples and vendor/asset constraints clearly.

## Expected Outputs

- Landscape synthesis for Wave 343.
- Registry/family entries for physics hands and hand data capture projects.
- Method catalog entry for hand interaction/capture decomposition.
