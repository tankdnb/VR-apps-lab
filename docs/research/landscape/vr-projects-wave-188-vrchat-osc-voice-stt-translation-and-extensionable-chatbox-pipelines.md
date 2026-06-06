# VR Projects Wave 188: VRChat OSC Voice, STT, Translation, and Extensionable Chatbox Pipelines

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 188 studies voice-driven VRChat chatbox tools. The reusable value is in
microphone gating, recognizer/translator boundaries, OSC output behavior,
typing indicators, avatar parameter control, and extension hooks.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `MrShitFox/FoxTrans` | VAD-gated voice translation to chatbox | Strong direct pipeline donor |
| `ewrt101/OSC_Voice` | Multi-mode STT/file/time chatbox sender | Useful mode-router and local/cloud contrast |
| `R-VUt/OSC-SRTC` | GUI STT/translation app with avatar controls and extensions | Strong architecture/reference donor |

## `MrShitFox/FoxTrans`

- Interesting idea:
  capture microphone audio, gate speech with WebRTC VAD, translate direct audio
  through a cloud model, and send the translated text to VRChat chatbox with a
  typing indicator.
- Code donor value:
  high for VAD-gated segment buffering, pre-roll, WAV packing, direct
  audio-to-translation request flow, and small OSC chatbox sender.
- Product reference value:
  high for social VR users who need a small real-time speech translation
  companion.
- What to inspect next:
  retry/backoff behavior, token/cost UX, message-length handling, and language
  selection UI.
- Source evidence:
  `FoxTrans/Program.cs`, `Config.cs`, `VRChatOsc.cs`,
  `OpenRouterClient.cs`, and README.
- Reusable pattern extraction:
  VAD-gated direct audio-to-chatbox translation pipeline.
- Reusable core:
  record mono 16 kHz frames, keep a short pre-roll buffer, use aggressive VAD
  and speech/silence counters to segment phrases, pack the segment as WAV,
  call a translation model, send `/chatbox/typing` during processing, and send
  `/chatbox/input` when text returns.
- Do not copy directly:
  provider-specific model assumptions, custom OSC packing without validation,
  monolithic console flow, or cloud audio/API-key handling without explicit
  privacy UX.
- Caveats:
  cloud audio is sensitive, API cost and latency matter, and failure states
  need clearer user feedback.

## `ewrt101/OSC_Voice`

- Interesting idea:
  route several chatbox input modes from one console app: time display, file
  line display, local STT, AssemblyAI realtime streaming, and AssemblyAI chunk
  transcription.
- Code donor value:
  medium for the mode-router shape, manual OSC packet examples, threshold
  recording, and local/cloud STT comparison.
- Product reference value:
  medium for quick experiments that need one executable to test several
  chatbox sources.
- What to inspect next:
  model packaging, UTF-8 handling, microphone calibration, and paid API cost
  guardrails.
- Source evidence:
  `Program.cs`, `OSC_Core.cs`, `OSC_STT.cs`, `OSC_Display.cs`, and
  `SpeechToText_AssemblyAI.cs`.
- Reusable pattern extraction:
  chatbox input mode router across time, file, local STT, and cloud STT.
- Reusable core:
  present an input-mode menu, initialize a microphone source, route each mode
  to a common chatbox sender, toggle `/chatbox/typing`, and isolate local
  recognizer and cloud WebSocket/chunk recognizer paths behind mode-specific
  modules.
- Do not copy directly:
  hardcoded IP/ports, ASCII-only string packing, fixed file paths, crude audio
  thresholds, or cost-prone streaming defaults.
- Caveats:
  useful as a comparison donor, but needs stronger configuration, Unicode, and
  privacy handling before becoming product code.

## `R-VUt/OSC-SRTC`

- Interesting idea:
  combine GUI microphone selection, recognizer choice, translation provider
  choice, avatar OSC parameter controls, PTT, dual-language output, optional
  Romaji conversion, and a Flask extension chain.
- Code donor value:
  high for the full pipeline boundary: recognizer, translator, OSC server,
  chatbox output, GUI state, and extension registry.
- Product reference value:
  high for creator-facing voice translation tools where avatar state can drive
  source language, target language, enable/disable, and PTT behavior.
- What to inspect next:
  extension security, thread shutdown, provider error handling, and modern API
  availability.
- Source evidence:
  `OSC-SRTC.py`, `modules/SRTC_OSC.py`, `SRTC_Recognizer.py`,
  `SRTC_Translator.py`, `SRTC_Extension.py`, `SRTC_GUI.py`, and
  `api_settings.json`.
- Reusable pattern extraction:
  STT/translation pipeline with avatar OSC parameter control and extension
  chain.
- Reusable core:
  run a local OSC server for avatar parameters, map parameter callbacks to
  language/PTT/on-off state, capture and recognize speech, translate one or
  two target languages, optionally run message extensions, and send a composed
  chatbox message through `/chatbox/input`.
- Do not copy directly:
  query-string message forwarding, process-kill shutdown style, unofficial API
  assumptions, or provider keys stored without stronger guidance.
- Caveats:
  broad and strategically useful, but its implementation needs security and
  maintainability cleanup before reuse.

## Cross-Project Lessons

- Voice-to-chatbox tools need an explicit capture gate; otherwise cloud STT
  can become noisy, expensive, or privacy-hostile.
- Typing indicators are a small but important UX affordance while speech is
  being recognized or translated.
- Avatar OSC parameters can turn voice tools from desktop-only companions into
  in-world controllable utilities.
- Extension chains are powerful, but they need strict boundaries around input,
  output, provider credentials, and network exposure.
- The best reusable abstraction is not one recognizer provider; it is a stable
  capture -> recognize -> translate -> compose -> OSC output pipeline.

## Reuse Recommendations

1. Use `FoxTrans` as the compact VAD/pre-roll/direct-translation donor.
2. Use `OSC_Voice` as the mode-router contrast between local STT, cloud STT,
   file input, and display modes.
3. Use `OSC-SRTC` as the strongest architecture reference for avatar-controlled
   STT/translation plus extension processing.
4. Treat cloud audio, API costs, and private speech as first-class product
   caveats in any future `VR-apps-lab` voice sidecar.

## Follow-Up Gaps

- Compare message-length handling and truncation across voice/chatbox tools.
- Extract a provider-neutral STT/translation adapter contract.
- Define a privacy checklist for microphone-to-cloud VR companions.
- Compare avatar parameter schemas for language switching and PTT.
