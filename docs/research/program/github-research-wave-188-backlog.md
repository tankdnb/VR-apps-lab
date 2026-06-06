# GitHub Research Wave 188 Backlog

- Date: `2026-06-06`
- Theme: `VRChat OSC voice, STT, translation, and extensionable chatbox pipelines`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for VRChat OSC voice, STT, and translation companions.
- `Done` Dedupe against earlier chatbox, captions, and TTS waves.
- `Done` Freeze a bounded shortlist around microphone-to-chatbox pipelines.

## Source Sync

- `Done` Confirm `FoxTrans` in local-only cache.
- `Done` Confirm `OSC_Voice` in local-only cache.
- `Done` Confirm `OSC-SRTC` in local-only cache.

## Code Reading

- `Done` Inspect WebRTC VAD, pre-roll, OpenRouter request, WAV packing, and
  chatbox OSC output in `FoxTrans`.
- `Done` Inspect mode selection, manual OSC packing, local STT, AssemblyAI
  streaming/chunk flows, and threshold recording in `OSC_Voice`.
- `Done` Inspect GUI, recognizer/translator routing, avatar OSC parameter
  callbacks, PTT behavior, dual-language output, and Flask extension bridge in
  `OSC-SRTC`.

## Integration

- `Done` Create Wave 188 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for voice-to-chatbox translation and mode
  routing.
- `Next` Compare cloud privacy, cost, and stale/error UX across voice tools
  before promoting any single pipeline as a preferred implementation.
