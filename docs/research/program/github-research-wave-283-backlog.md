# GitHub Research Wave 283 Backlog - XR Study Recording, Replay, Analysis, and Multimodal Training Data

## Executed Scope

- Searched and deduplicated XR recording, replay, study analysis, multimodal
  capture, and hand-pose training projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted native recorder endpoints, Unity-side recording/replay UI,
  transform/sound/generic channels, analysis requests, radial time navigation,
  Tobii/LSL eye/head/object-hit streams, protobuf IO, replay visualization, and
  Netcode/Leap hand-pose transport.

## Studied Projects

- `vrsys/Recording-And-Analysis-Plugin`
- `vrsys/Immersive-Study-Analyzer`
- `mvidaldp/wd_ride`
- `leonkoech/SignWhisper`

## Backlog Findings

- Build an XR study recording matrix across transforms, scene graph, sound,
  generic channels, recorder IDs, analysis queries, multimodal EEG/eye/head
  logs, and replay UI.
- Deepen `vrsys/Recording-And-Analysis-Plugin` and
  `vrsys/Immersive-Study-Analyzer` as the strongest framework donors.
- Deepen `mvidaldp/wd_ride` for LSL/Tobii/object-hit schema and replay
  visualization.
- Treat `leonkoech/SignWhisper` as a hand-pose training/networking reference
  until ASL scoring and persistence are clearer.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an XR study recording/replay analysis method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
