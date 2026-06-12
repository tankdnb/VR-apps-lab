# Wave 283 - XR Study Recording, Replay, Analysis, and Multimodal Training Data

This wave studies projects that record, replay, analyze, or stream study data
from XR sessions. The focus is transform/sound/generic channels, recorder IDs,
analysis queries, radial time-navigation UI, LSL/Tobii multimodal capture, and
networked hand-pose training surfaces.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- native and Unity-side recording/replay plugins;
- transform, sound, generic, annotation, and scene-graph metadata channels;
- immersive analysis UI, radial menus, object selection, and position previews;
- eye/head/LSL multimodal capture and replay;
- hand-pose networking where it supports training or study capture.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `vrsys/Recording-And-Analysis-Plugin` | Native XR recording and analysis plugin | Studied | Recorder IDs, transform/sound/generic channels, ring buffers, composable analysis queries |
| `vrsys/Immersive-Study-Analyzer` | Unity immersive replay/analysis UI | Studied | Recorder controller, transform recorder, analysis UI, radial time/navigation controls |
| `mvidaldp/wd_ride` | Multimodal VR study capture | Studied with artifact caveats | Tobii eye tracking, head vector raycasts, LSL streams, protobuf IO, replay visualization |
| `leonkoech/SignWhisper` | ASL/hand-pose networked training surface | Studied with prototype caveats | Leap hand encoding over Netcode, avatar head sync, minigame shell |

## Code-Level Findings

### `vrsys/Recording-And-Analysis-Plugin`

- Interesting idea:
  a cross-platform native plugin records and replays transform, sound, and
  generic time-series data while exposing Unity/Unreal-style C endpoints.
- Code donor value:
  very strong donor: `RecorderEndpoints.cpp` exposes recorder-ID scoped APIs
  for creating/opening recordings, recording transforms/generic/sound data,
  retrieving replay chunks, registering scene object paths/components, mapping
  old/new object IDs, and reading duration/sound metadata; `Recorder.cpp`
  implements buffered writes, ring-buffer replay, metadata updates, optional
  compression, and state checks.
- Product reference value:
  excellent reference for engine-agnostic study capture and replay.
- What to inspect next:
  binary format stability, compression support in analysis, threading safety,
  Unity/Unreal bindings, and metadata migration.
- Reusable pattern:
  recorder-ID scoped multi-channel XR recording backend.
- Caveats:
  native C++ complexity, file-format version risk, and TODOs around compressed
  analysis.

### `vrsys/Immersive-Study-Analyzer`

- Interesting idea:
  the native recording plugin is surfaced inside Unity as record/replay
  controllers, analysis requests, radial UI, annotations, and collaboration
  controls.
- Code donor value:
  strong Unity-side donor: `RecorderController.cs` manages recording
  directories, recorder state, transform/audio/generic recorder dictionaries,
  playback timing, CSV/WAV export flags, and tooltips; `TransformRecorder.cs`
  registers object paths/components, records only changed transforms, handles
  teleportation gaps, and replays hierarchy-aware transforms; `ImmersiveAnalysis.cs`
  builds distance/gaze/containment/sound/velocity query UI and position
  previews; `RadialMenuManager.cs` synchronizes radial menu state over Photon.
- Product reference value:
  excellent reference for immersive study-analysis UX inside VR rather than
  desktop-only postprocessing.
- What to inspect next:
  full annotation flow, multi-user replay, export UI, query authoring UX, and
  dependency boundaries around Photon/voice.
- Reusable pattern:
  in-VR replay and analysis control surface.
- Caveats:
  large Unity project, Photon/vendor dependencies, and plugin-coupled design.

### `mvidaldp/wd_ride`

- Interesting idea:
  a city-ride VR study records head tracking, eye tracking, gaze-hit objects,
  object groups, hit positions, frame counts, and replay visualization.
- Code donor value:
  strong multimodal capture donor: `ETRecorder.cs` reads Tobii world/local gaze
  data, blink validity, gaze and nose-vector raycast hits, pads fixed-size
  object arrays, and pushes samples to LSL; `LSLStreams.cs` declares named
  stream channels and metadata; `SerializableTrackingData.cs` and `IO.cs` show
  protobuf-based async save/load; `TrackerReplay.cs` replays camera transform
  and visualizes hit positions as dots.
- Product reference value:
  good reference for human-subject VR rides, attention studies, and replayable
  scene-analysis data.
- What to inspect next:
  EEG stream plumbing, participant IDs, consent/privacy, synchronization,
  export pipeline, and replay controls.
- Reusable pattern:
  LSL-backed eye/head/object-hit recording pipeline.
- Caveats:
  very large asset/vendor payload, Tobii/LSL dependencies, fixed array sizes,
  and privacy-sensitive biometric data.

### `leonkoech/SignWhisper`

- Interesting idea:
  a sign-language learning prototype sends Leap hand poses over Unity Netcode
  while syncing avatar head/body and minigame state.
- Code donor value:
  useful focused donor: `NetworkHands.cs` encodes left/right Leap hands as
  `VectorHand` bytes, sends tracked flags and byte arrays through ServerRpc and
  ClientRpc, decodes remote hands into hand models, and disables local visual
  models for owners; `NetworkPlayer.cs` maps camera pose to avatar head/body;
  `GameController.cs` shows a small matching minigame shell.
- Product reference value:
  useful training reference for hand-language multiplayer presence and pose
  transport.
- What to inspect next:
  gesture/ASL scoring, feedback model, lesson content, Relay setup, and whether
  pose recordings are persisted.
- Reusable pattern:
  networked hand-pose training presence.
- Caveats:
  prototype state, debug logs, partial hand/provider logic, and claims not fully
  backed by inspected source.

## Reusable Pattern Extraction

- Pattern candidate:
  XR study recording, replay, and analysis pipeline.
- Problem solved:
  capture what happened in an XR session, replay it, query meaningful
  intervals, and connect it to study metrics without hardwiring every data
  source to one scene.
- Reusable core:
  recorder IDs, transform channel, sound channel, generic channel, metadata and
  scene graph registry, ring buffers, recording/replay states, file versioning,
  object-ID remapping, analysis queries, position retrieval, annotation UI,
  radial/time controls, multimodal LSL streams, biometric privacy gates, and
  export/replay visualization.
- Source evidence:
  `Recording-And-Analysis-Plugin`, `Immersive-Study-Analyzer`, `wd_ride`, and
  `SignWhisper`.
- Abstraction boundary:
  keep sensor capture, storage format, replay state, analysis/query logic,
  visualization UI, and privacy/export policy separate.
- What not to copy:
  biometric capture without consent language, fixed participant IDs or array
  dimensions as universal defaults, vendor-heavy project payloads, unversioned
  binary formats, or prototype multiplayer claims without scoring evidence.
- Method catalog action:
  add an XR study recording/replay analysis method.

## Follow-Up Gaps

- Build an XR study recording matrix across transforms, scene graph, sound,
  generic channels, recorder IDs, analysis queries, multimodal EEG/eye/head
  logs, and replay UI.
- Deepen `vrsys/Recording-And-Analysis-Plugin` and
  `vrsys/Immersive-Study-Analyzer` as the strongest framework donors.
- Deepen `wd_ride` for LSL/Tobii/object-hit schema and replay visualization.
- Treat `SignWhisper` as a hand-pose training/networking reference until the
  ASL scoring and persistence story is clearer.
