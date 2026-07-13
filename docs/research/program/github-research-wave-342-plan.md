# GitHub Research Wave 342 Plan - Spectator Cameras, Mixed-Reality Capture, and Multiplayer Observer Roles

## Goal

Study spectator and mixed-reality capture projects that expose reusable camera
rig, calibration, compositing, network, and observer-role patterns.

## Research Questions

- What is the minimal useful spectator-camera architecture?
- How do mature MRC stacks separate calibration, spatial alignment, camera
  pose, compositor, networking, and recording?
- How should multiplayer VR tools model observer roles separately from headset
  player roles?

## Shortlist

- `Unity-Technologies/VR-Spectator-Sample`
- `microsoft/MixedReality-SpectatorView`
- `Microsoft/MixedRealityCompanionKit`
- `spatialos/sdk-for-unity-vr-starter-project`

## Required Checks

- Deduplicate against prior MRC/capture and RealityMixer notes.
- Sync source only into local-only cache with LFS smudge disabled.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.
- Treat deprecated/cloud-era stacks as architecture references with caveats.

## Expected Outputs

- Landscape synthesis for Wave 342.
- Registry/family entries for spectator/MRC/observer-role projects.
- Method catalog entry for spectator capture decomposition.
