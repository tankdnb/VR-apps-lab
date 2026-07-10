# GitHub Research Wave 313 Backlog - VRCFaceTracking Downstream Bridges, Simulation Panels, and Avatar Setup Automation

## Executed Scope

- Searched and deduplicated downstream VRCFaceTracking bridges and setup tools.
- Froze a five-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted OSC-to-VMC translation, local discovery/avatar-change handoff,
  named-pipe GUI companions, simulation engines, persistent session state,
  VNyan consumer adapters, searchable setup inspectors, param metadata, blend
  shape diff capture, and generated animator layer builders.

## Studied Projects

- `tkns3/VRCFTtoVMCP`
- `Toys0125/VirtualFaceTracking`
- `LumKitty/VRCFTnyan`
- `ImTiara/FaceTrackingSetup`
- `benaclejames/VRCFTSetupUtility`

## Backlog Findings

- Build a compatibility matrix across VMC/PerfectSync, VNyan, and other future
  downstream VRCFT consumers.
- Deepen `VirtualFaceTracking` expression mapping, tests, and GUI/module
  contract durability.
- Deepen the generated asset shape and parameter metadata schema in the setup
  tools.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a VRCFT downstream bridge/setup method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
