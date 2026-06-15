# GitHub Research Wave 303 Backlog - Embodied Locomotion, Walking-in-Place, Redirected Walking, and RDW Experiment Packaging

## Executed Scope

- Searched and deduplicated walking-in-place, redirected walking, RDW lineage,
  comfort locomotion, and training-locomotion projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted input-source adapter patterns, movement aggregation, Vive tracker
  allocation, arm/head/leg movement recognition, translation/rotation gain
  logic, room graph/portal handoff, RDW metrics, XRI direction blending,
  joystick blocked states, and tunnelling comfort preset references.

## Studied Projects

- `singaporetech/immersification-wip-locomotion`
- `DarkerQueenSara/ProjetoVR-V2`
- `tmitro/ucf-ist-redirected-walking`
- `VRatPolito/CET-VR`

## Backlog Findings

- Deepen `immersification-wip-locomotion` as the strongest WIP donor.
- Treat `ucf-ist-redirected-walking` as source-light/fork-lineage until the
  RDWT artifact or custom scripts are inspected.
- Compare this wave with earlier RDW/RDW2/RDWT projects to avoid inflating
  fork lines as independent methods.
- Build a locomotion matrix across joystick, teleport, arm-swing, head-bob,
  leg-lift, tracker/full-body, redirected walking, comfort tunnelling, and
  experiment metric export.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an embodied locomotion/RDW method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
