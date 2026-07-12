# GitHub Research Wave 335 Plan - Unity XR Research Templates, Data Logging, Scene Flow, and Minimal Controller Baselines

## Goal

Study Unity XR research and interaction scaffolds that can inform future
experiment-support utilities: preconfigured Quest templates, data logging,
scene flow, TXR player singleton surfaces, and a minimal XR player controller
baseline.

## Research Questions

- What should a reusable XR research template provide beyond a scene and
  controller?
- How do templates organize player state, hand/eye tracking, logging, scene
  transitions, and exported data?
- Which parts are reusable as documentation patterns rather than code donors?

## Shortlist

- `TAU-XR/TAUXR-Research-Template`
- `TAU-XR/TAUXR-OpenTemplate`
- `dilmerv/XRToolKitPlayerController`
- `traggett/UnityXRInteractionToolkitExtensions`

## Required Checks

- Deduplicate against Unity XR input, starter, and experimental framework
  waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.
- Mark empty or template-heavy repos honestly.

## Expected Outputs

- Landscape synthesis for Wave 335.
- Registry/family entries for studied projects.
- Method catalog entry for XR research template and telemetry scaffold
  boundaries.
