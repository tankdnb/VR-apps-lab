# GitHub Research Wave 336 Plan - Headsetless OpenXR, Godot, Bevy, and Runtime Simulator Harnesses

## Goal

Study no-headset and simulator workflows that make XR development possible
without constantly wearing or attaching a physical headset.

## Research Questions

- Where should a simulator sit: OpenXR runtime, engine XR plugin, editor
  autoload, app template, or companion runtime selector?
- How do projects map keyboard, mouse, gamepad, replay, and forwarded tracker
  data into HMD/controller state?
- Which pieces are reusable as future VR utility diagnostics and test harnesses?

## Shortlist

- `jrng/openxr_simulator`
- `Cafezinhu/godot-vr-simulator`
- `sanky369/OpenXRSim`
- `kcking/bevy_xr_app`
- `demonixis/OpenXR-OSX`

## Required Checks

- Deduplicate against earlier OpenXR simulator/runtime and Rust engine waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.

## Expected Outputs

- Landscape synthesis for Wave 336.
- Registry/family entries for simulator harnesses.
- Method catalog entry for no-headset XR simulator harness boundaries.
