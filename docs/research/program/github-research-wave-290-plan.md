# GitHub Research Wave 290 Plan - VR Assembly, Maintenance, and Procedure Training Workflows

## Goal

Study VR assembly and maintenance projects as reusable references for
part/socket snapping, step validation, save/loadable assemblies, scoring,
timing, tool selection, and companion dashboards.

## Research Questions

- How do assembly projects model parts, attach points, sockets, snap IDs, and
  compatibility?
- Which patterns support saving/restoring user-authored assemblies?
- How do maintenance training projects sequence steps, tools, timers, scores,
  and rankings?
- Where should companion dashboards and score APIs sit relative to headset-side
  training logic?

## Shortlist

- `T0riU/VR-Assembly-Manager`
- `carlosMoragon/VR-Assembly-Simulator`
- `NopparatSang/SCGVR2`
- `JonyHM/VRDoorAssembly`
- `lintglitch/vr-assembly`
- `White-H-21/VR-assembly-system`
- `nyu-lgcoop/VRTrainingUnity`

## Required Checks

- Deduplicate against prior training, assessment, procedure, menu, and assembly
  waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep SDK/vendor payload, source-light, empty-repo, and hardcoded-scene caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 290.
- Registry/family entries for VR assembly, maintenance, and procedure training.
- Method catalog entry for assembly/procedure workflow boundaries.
- Follow-up gaps around snap/socket reuse, procedure authoring, scoring, and
  companion dashboards.
