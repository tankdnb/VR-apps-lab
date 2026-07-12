# GitHub Research Wave 323 Backlog - Narrow OpenXR API Layers, Cockpit Anchors, Inline Profilers, and Game Injection Toolkits

## Executed Scope

- Searched and deduplicated narrow OpenXR layer, profiler, cockpit anchor, and
  injection toolkit projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted action-state interception, treadmill-to-stick remapping,
  stage-space seat anchors, hotkey/audio feedback, inline CPU/GPU scopes, CSV
  traces, IPC/shmem split, and minimal-injection architecture.

## Studied Projects

- `Majed6/KATOXR`
- `robogears/cockpit-anchor`
- `mledour/xrprof`
- `AndrewAltimit/game-mods`

## Backlog Findings

- Compare KAT-style locomotion remapping with other OpenXR input micro-layers.
- Deepen cockpit anchoring against broader seated/cockpit calibration tools.
- Revisit `xrprof` when integrating profiling hooks into future API-layer
  prototypes.
- Compare ITK-style minimal injection with other VR game-retrofit architectures.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes relevant runtime/game-layer methods.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
