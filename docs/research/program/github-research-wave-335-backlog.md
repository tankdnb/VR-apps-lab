# GitHub Research Wave 335 Backlog - Unity XR Research Templates, Data Logging, Scene Flow, and Minimal Controller Baselines

## Executed Scope

- Searched and deduplicated Unity XR research/template projects.
- Froze a four-project shortlist including one empty rejected candidate.
- Read source and documentation statically from local-only cache.
- Extracted base scene composition, TXR player/data/scene manager roles,
  continuous CSV logging, hand/eye/face tracking data surfaces, additive scene
  transitions, Meta Interaction SDK coexistence notes, controller locomotion
  baseline, and test-scene existence checks.

## Studied Projects

- `TAU-XR/TAUXR-Research-Template`
- `TAU-XR/TAUXR-OpenTemplate`
- `dilmerv/XRToolKitPlayerController`
- `traggett/UnityXRInteractionToolkitExtensions` (empty repository; rejected as
  a code donor)

## Backlog Findings

- Treat TAUXR as a research-template/product-structure reference, not as a
  drop-in dependency.
- Extract the "base scene + player singleton + data manager + scene manager"
  shape for future experiment utilities.
- Treat `XRToolKitPlayerController` as a minimal locomotion/test-scene baseline.
- Do not spend more study time on the empty `traggett` repo unless content
  appears later.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied or rejected projects.
- Method catalog captures XR research template and telemetry scaffold
  boundaries.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
