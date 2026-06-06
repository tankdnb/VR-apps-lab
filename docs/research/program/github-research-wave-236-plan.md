# GitHub Research Wave 236 Plan

Date: 2026-06-06

Theme: VR locomotion, embodiment, and comfort microcontrols.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Locomotion and embodied-control code often hides reusable utility patterns:
comfort vignettes, snap-turn fades, dynamic collider sizing, teleport preview
gates, head-relative movement, and head/hand-only avatar estimation. This wave
collects compact donors that can inform future VR tools without treating them
as one product.

## Search Families

- VR locomotion and comfort systems.
- WebXR teleport and smooth locomotion wrappers.
- Head/hand-only IK and embodiment helpers.
- Arm swing and movement experiments.
- Micro-controls that can be reused in overlay or utility tools.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `RoWoCha/LocomotionVR` | SteamVR locomotion demo with blinders, snap turns, dynamic speed, and intensity gates. | Comfort locomotion donor |
| `pascalmariany/Unity-WebXR-Teleportation-and-SmoothLocomotion` | WebXR smooth movement plus delayed teleport wrapper and arc casting. | WebXR locomotion reference |
| `dabeschte/VRArmIK` | Head and hand tracked arm/shoulder IK with calibration and clamp behavior. | Embodiment donor |
| `ralph-immrsv/UnityVR-ArmSwingMovement` | Search result for arm-swing locomotion; checkout contained no source beyond ignore files. | Source-light exclusion note |

## Dedupe Notes

Generic locomotion and accessibility have prior coverage, but these specific
Unity/WebXR comfort and embodiment micro-donors were not represented as a
coherent stack. `UnityVR-ArmSwingMovement` is retained only as a source-light
search result so it is not repeatedly rediscovered.

## Code-Level Pass Targets

- Speed, direction, and turn input mapping.
- Vignette intensity and comfort gating.
- Teleport preview/commit state.
- HMD-relative collider and movement handling.
- Head/hand-only avatar calibration and shoulder/arm constraints.
- Caveats around demo maturity and copied assumptions.

## Expected Outputs

- Wave 236 landscape synthesis.
- Registry and family entries for comfort/embodiment microcontrols.
- Method catalog entry for comfort-aware locomotion and embodiment boundaries.
- Follow-up backlog for a locomotion/comfort comparison matrix.
