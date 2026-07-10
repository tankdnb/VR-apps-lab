# GitHub Research Wave 313 Plan - VRCFaceTracking Downstream Bridges, Simulation Panels, and Avatar Setup Automation

## Goal

Study downstream VRCFaceTracking bridges and setup utilities as reusable
references for protocol translation, named-pipe companion GUIs, simulation and
manual override state, avatar handoff, parameter metadata, and generated
animator assets.

## Research Questions

- How do downstream bridges translate VRCFT output into other avatar/runtime
  protocols?
- What patterns recur across companion GUIs, state snapshots, simulation
  engines, and diagnostics?
- How do editor-side setup tools turn face-tracking configuration into assets
  and animator layers?
- Where should reusable boundaries sit between upstream tracking, downstream
  consumers, and creator tooling?

## Shortlist

- `tkns3/VRCFTtoVMCP`
- `Toys0125/VirtualFaceTracking`
- `LumKitty/VRCFTnyan`
- `ImTiara/FaceTrackingSetup`
- `benaclejames/VRCFTSetupUtility`

## Required Checks

- Deduplicate against earlier VRCFT, avatar preparation, and face-tracking
  waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep downstream protocol assumptions, duplicated mapping code, and generated
  asset caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 313.
- Registry/family entries for downstream VRCFT bridges and setup tooling.
- Method catalog entry for VRCFT downstream bridge/setup automation.
- Follow-up gaps for compatibility matrices, tests, and metadata schemas.
