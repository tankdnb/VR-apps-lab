# GitHub Research Wave 283 Plan - XR Study Recording, Replay, Analysis, and Multimodal Training Data

## Goal

Study XR recording/replay and multimodal study-data projects as reusable
references for transform/sound/generic channels, recorder IDs, scene metadata,
analysis queries, immersive replay UI, LSL/Tobii capture, and hand-pose
training transport.

## Research Questions

- How do projects capture what happened in an XR session for replay and
  analysis?
- Which data channels, IDs, metadata, file formats, buffers, and query APIs are
  reusable?
- How do replay and analysis become an in-VR UX rather than only desktop
  postprocessing?
- What privacy and validation caveats apply to eye, head, EEG, voice, and hand
  study data?

## Shortlist

- `vrsys/Recording-And-Analysis-Plugin`
- `vrsys/Immersive-Study-Analyzer`
- `mvidaldp/wd_ride`
- `leonkoech/SignWhisper`

## Required Checks

- Deduplicate against prior study-data, instrumentation, mocap, rehab, hand,
  and training waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep biometric/privacy, vendor-payload, binary-format, and prototype caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 283.
- Registry/family entries for XR study recording/replay analysis.
- Method catalog entry for XR study recording and replay pipelines.
- Follow-up matrix around transforms, scene graph, sound, generic channels,
  recorder IDs, analysis queries, multimodal logs, and replay UI.
