# GitHub Research Wave 290 Backlog - VR Assembly, Maintenance, and Procedure Training Workflows

## Executed Scope

- Searched and deduplicated VR assembly, maintenance, training, and companion
  dashboard projects.
- Froze a seven-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted part state machines, attach point IDs, sockets, compatible snap
  checks, hand-release policy, JSON assembly persistence, thumbnails, stats,
  scoring/timer loops, tool selection, work-step controllers, Angular score
  dashboards, and source-light/skipped caveats.

## Studied Projects

- `T0riU/VR-Assembly-Manager`
- `carlosMoragon/VR-Assembly-Simulator`
- `NopparatSang/SCGVR2`
- `JonyHM/VRDoorAssembly`
- `lintglitch/vr-assembly`
- `nyu-lgcoop/VRTrainingUnity`
- `White-H-21/VR-assembly-system` was skipped as an empty/no-source candidate.

## Backlog Findings

- Deepen `T0riU/VR-Assembly-Manager` into a reuse plan for reusable
  snap/socket/persistence architecture.
- Extract a procedure-authoring schema from `SCGVR2` without copying hardcoded
  GameObject flows.
- Compare score/timer/ranking models across Wave 280 training projects and
  this assembly-specific wave.
- Decide whether `VR-apps-lab` should prototype a minimal assembly-method
  sample: two parts, attach IDs, socket validation, save/load, and score event.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an assembly/procedure workflow method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
