# GitHub Research Wave 188 Plan

- Date: `2026-06-06`
- Theme: `VRChat OSC voice, STT, translation, and extensionable chatbox pipelines`
- Scope: microphone capture, VAD, local/cloud STT, translation, VRChat
  chatbox output, typing indicators, avatar parameter control, and extension
  hooks around spoken text.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier waves covered text, captions, TTS, and chatbox companions. This wave
narrows in on spoken voice-to-chatbox pipelines where the interesting reusable
knowledge is not the UI alone, but the capture gate, recognizer/translator
boundary, OSC output schema, and extension points.

## Search Families

- VRChat OSC speech-to-text companions
- VRChat chatbox translation tools
- VAD-gated microphone pipelines
- local versus cloud STT routing
- avatar-parameter controlled chatbox utilities
- extensionable text-processing sidecars

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `MrShitFox/FoxTrans` | C# WebRTC VAD pipeline that sends direct voice translation to VRChat chatbox | VAD-gated translation sidecar |
| `ewrt101/OSC_Voice` | Multi-mode C# console tool for time/file/local STT/cloud STT to chatbox | STT mode-router reference |
| `R-VUt/OSC-SRTC` | Python GUI STT/translation tool with avatar OSC controls and extension server | Extensionable STT/translation pipeline |

## Dedupe Notes

- Earlier VRChat text/chatbox waves already covered TTS and template
  composition; this wave only keeps projects where microphone/STT/translation
  architecture adds new lessons.
- General OSC libraries and thin chatbox senders were deferred unless they
  showed capture, translation, extension, or control boundaries.
- Forks and simple clones were excluded unless they added a distinct pipeline
  shape.

## Code-Level Pass Targets

- microphone capture and VAD thresholds;
- speech segment buffering and typing indicator behavior;
- local versus cloud recognizer boundaries;
- translation provider abstraction and language settings;
- chatbox OSC packing, booleans, and message length constraints;
- avatar parameter control, PTT, and extension hooks;
- privacy, API-key, and cloud-audio caveats.

## Expected Outputs

- Wave 188 landscape synthesis.
- Registry and family placement for voice/STT/translation chatbox pipelines.
- Methods for VAD-gated translation, avatar-controlled STT pipelines, and
  chatbox input mode routers.
