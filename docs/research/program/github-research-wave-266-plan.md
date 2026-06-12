# GitHub Research Wave 266 Plan - Engine and Browser XR Utility Packages, Input, and Locomotion Primitives

## Goal

Study engine-side and browser-side XR utility packages as reusable primitive
references for device wrappers, input selectors, locomotion, component
diagnostics, and projection materials.

## Research Questions

- Which projects expose reusable primitive contracts instead of complete apps?
- How do they divide runtime devices, input events, selector modes, target
  modules, locomotion, and projection helpers?
- Which repos are implementation donors and which are source-light skeletons?
- Which framework-specific caveats block direct reuse?

## Shortlist

- `Silverlan/PragmaVR`
- `TheUtDuong/unity-vr-utilities`
- `loganator956/unity-vr-utilities`
- `nukadelic/UXRU`
- `Ponsukeee/VRInputModule`
- `Sunflower-Reality-Labs/aframe-srl-utils`
- `acerwebvr/Acer-VR-Utility-for-Browser-WebVR-Release`

## Required Checks

- Deduplicate against Unity XR microcontrols, A-Frame components, WebXR
  runtime scaffolding, and overlay media waves.
- Clone only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields and reusable pattern bridge fields.
- Update registry, families, methods, not-yet-studied, current focus, and
  indexes.

## Expected Outputs

- Landscape synthesis for Wave 266.
- Registry and family entries for engine/browser XR utility primitives.
- Method catalog entry for XR primitive package intake.
- Follow-up gaps around selector pipelines, locomotion/body models,
  projection materials, and legacy API migration.
