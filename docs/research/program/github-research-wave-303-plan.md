# GitHub Research Wave 303 Plan - Embodied Locomotion, Walking-in-Place, Redirected Walking, and RDW Experiment Packaging

## Goal

Study embodied locomotion and redirected-walking projects as reusable references
for input-source adapters, tracker allocation, walking-in-place movement
recognition, comfort controls, redirected-walking gains, impossible spaces, and
experiment metric capture.

## Research Questions

- How do projects separate raw tracker/controller input from normalized
  movement magnitude and direction?
- Which walking-in-place modes are implemented as reusable adapters?
- How are redirected-walking gains, room/portal transitions, and experiment
  metrics represented?
- Which projects are strong donors versus source-light fork/lineage references?

## Shortlist

- `singaporetech/immersification-wip-locomotion`
- `DarkerQueenSara/ProjetoVR-V2`
- `tmitro/ucf-ist-redirected-walking`
- `VRatPolito/CET-VR`

## Required Checks

- Deduplicate against older locomotion, comfort, and RDW waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep fork-lineage, vendored package, comfort, calibration, and participant
  safety caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 303.
- Registry/family entries for embodied locomotion and RDW packaging.
- Method catalog entry for locomotion/RDW boundaries.
- Follow-up gaps around locomotion matrices and RDW lineage cleanup.
