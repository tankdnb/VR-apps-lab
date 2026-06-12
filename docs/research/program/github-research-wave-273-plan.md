# GitHub Research Wave 273 Plan - VR Performance Tuning, FSR, and FPS Helper Surfaces

## Goal

Study VR performance helper projects around OpenVR FSR, VRPerfKit,
configuration managers, runtime loader wrappers, and FPS/comfort baselines.

## Research Questions

- How do performance mod managers discover targets and manage install state?
- What rollback or backup patterns appear before DLL/config mutation?
- How do projects expose settings schemas and compatibility warnings?
- Which projects are implementation donors versus binary/config references?

## Shortlist

- `tappi287/openvr_fsr_app`
- `LavaGang/ML_OpenVR_FSR`
- `komori/vrperfkit-ocq2`
- `GodotVR/godot_openvr_fps`

## Required Checks

- Deduplicate against earlier `fholger/openvr_fsr`, `fholger/vrperfkit`, and
  rendering adaptation waves.
- Clone only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields and reusable pattern bridge fields.
- Update registry, families, methods, not-yet-studied, and indexes.

## Expected Outputs

- Landscape synthesis for Wave 273.
- Registry/family entries for VR performance tuning helpers.
- Method catalog entry for performance mod-manager boundaries.
- Follow-up gaps around DLL replacement, runtime extraction, and compatibility
  evidence.
