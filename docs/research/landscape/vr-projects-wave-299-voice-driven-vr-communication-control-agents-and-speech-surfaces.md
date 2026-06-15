# Wave 299 - Voice-Driven VR Communication, Control, Agents, and Speech Surfaces

This wave studies voice-related VR/XR projects as references for microphone
consent, speech command mapping, avatar/OSC output, voice chat transport,
assistant pipelines, speech bubbles, feedback recording, and in-world voice UX.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- official Voice SDK sample/product patterns;
- STT/TTS/agent service orchestration;
- microphone-to-Opus voice chat loops;
- VRChat voice-to-OSC/chatbox/parameter sidecars;
- networked speech bubble and emote surfaces;
- source-light voice interaction samples and feedback capture.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `oculus-samples/voicesdk-samples-whisperer` | Meta Voice SDK sample/product UX | Studied with asset-heavy caveats | Consent/onboarding, mic level events, listenable objects, speech bubbles, voice UI, and spatial audio product framing |
| `UCL-VR/ubiq-genie` | Conversational agent and transcription service stack | Studied | Node service orchestration, audio receiver, STT, text generation, TTS, Unity receivers, and networked assistant audio |
| `vr-the-feedback/vr-the-feedback-unity` | VR voice feedback recorder | Studied as legacy/source-light reference | Grabbable mic, record/save feedback flow, backend/project-key caveat, and SteamVR/VRTK dependency notes |
| `nikaera/MagicOnionExample-OculusMobileVoiceChat` | Oculus mobile voice chat transport | Studied | Microphone capture, Opus encode/decode, MagicOnion streaming hub, avatar transforms, and remote audio playback |
| `xiaolazhu/vrc-voice-params` | VRChat voice-to-OSC avatar parameter sidecar | Studied | Web Speech UI, command CRUD, Go OSC sender, filtered debug receive, and voice command to avatar parameter mapping |
| `Jurangren/VRC-Voicebridge` | VRChat STT/translation/TTS/OSC sidecar | Studied | Pipeline cancel points, local Whisper, translation, TTS, OSC chatbox/typing/voice paths, virtual mic playback, and tray/status overlay |
| `Alchemishty/ExpressVR` | Networked speech bubble and emote wheel | Studied | Networked speech bubble registry, emote broadcast RPCs, XR input abstraction, and settings-driven bubble animation |
| `ahmedbegovic/VoiceInteractionVR` | Voice interaction puzzle sample | Studied as source-light puzzle reference | Simple voice/puzzle product marker; inspected source is mostly puzzle/interaction logic rather than reusable voice plumbing |

## Code-Level Findings

### `oculus-samples/voicesdk-samples-whisperer`

- Interesting idea:
  a voice SDK sample can teach voice UX through consent-gated onboarding,
  listenable objects, mic-level feedback, speech bubbles, and spatial audio
  cues, not only speech recognition API calls.
- Code donor value:
  medium with asset-heavy caveats. `MicInputValue.cs` listens to Voice SDK mic
  level changes; voice/listenable object scripts, `VoiceUI.cs`,
  `SpeakGestureWatcher.cs`, `SpeechBubble.cs`, and audio managers are useful
  product references, but the repo is heavily sample-content driven.
- Product reference value:
  very high for Quest voice UX and consent-first interaction design.
- What to inspect next:
  Voice SDK activation/deactivation flow, entity/intent handling, consent UI,
  failure states, localization, and whether listenable objects can be separated
  into a reusable utility package.

### `UCL-VR/ubiq-genie`

- Interesting idea:
  voice agents work best as explicit service pipelines: receive media, transcribe
  speech, generate text, synthesize audio, and send structured audio/message
  responses back into Unity.
- Code donor value:
  very high. `Node/apps/conversational_agent/app.ts` wires `MediaReceiver`,
  `SpeechToTextService`, `TextGenerationService`, and `TextToSpeechService`.
  `Node/apps/transcription/app.ts` records audio and CSV transcriptions.
  `ConversationalAgentManager.cs` receives audio info/data and injects PCM into
  Unity audio. `TranscriptionReceiver.cs` receives networked transcription
  messages.
- Product reference value:
  very high for assistant overlays, social XR agents, research transcription,
  and service-orchestrated speech tools.
- What to inspect next:
  peer identity/permissions, OpenAI/Azure key handling, child process lifecycle,
  latency, failure recovery, and local/offline alternatives.

### `vr-the-feedback/vr-the-feedback-unity`

- Interesting idea:
  user voice feedback can be captured in VR through a grabbable microphone
  object with explicit record/save actions.
- Code donor value:
  low/source-light in this pass. README-level guidance names
  `VRTheFeedbackManager`, `GrabbableMic`, `RecordFeedback`, and `SaveFeedback`,
  but the visible source is dominated by legacy SteamVR/VRTK payloads.
- Product reference value:
  medium for in-headset feedback capture and voice-note UX.
- What to inspect next:
  manager/controller source, upload schema, backend dependency, consent,
  retention policy, and local-only feedback mode.

### `nikaera/MagicOnionExample-OculusMobileVoiceChat`

- Interesting idea:
  a compact voice chat loop can be modeled as microphone ring buffer, Opus
  encoder, streaming hub payload, avatar transform sync, Opus decoder, and
  remote audio source playback.
- Code donor value:
  very high. `MicrophoneRecorder.cs` reads 48 kHz microphone data into process
  buffers. `MicrophoneEncoder.cs` queues PCM and emits Opus frames.
  `GamingHub.cs` broadcasts player parts and voice data through MagicOnion.
  `GamingHubClient.cs` joins rooms, updates remote avatars, and plays remote
  audio. `OpusPlayer.cs` decodes packets into an AudioClip ring.
- Product reference value:
  high for multiplayer voice, communication helpers, and low-latency audio
  transport studies.
- What to inspect next:
  jitter buffering, packet loss, mute/privacy controls, room auth, echo
  cancellation, positional audio, and mobile CPU/network constraints.

### `xiaolazhu/vrc-voice-params`

- Interesting idea:
  voice commands can be a desktop sidecar that maps Web Speech transcripts to
  VRChat OSC avatar parameter writes with a small command CRUD UI.
- Code donor value:
  high for sidecar structure. `frontend/src/main.js` manages Web Speech API
  continuous/interim recognition, language switching, restart behavior, command
  CRUD, OSC debug events, and port settings. `command_service.go` matches
  lowercased command text and calls OSC output. `osc_util.go` sends OSC messages
  and filters noisy received addresses.
- Product reference value:
  very high for hands-free avatar controls and companion apps.
- What to inspect next:
  Web Speech browser dependency, command ambiguity, confirmation UX, safety
  allowlists, debouncing, localization, and parameter type validation.

### `Jurangren/VRC-Voicebridge`

- Interesting idea:
  a VRChat speech sidecar can expose a cancelable pipeline: recognized text,
  translation, TTS generation, chatbox output, voice-state OSC, virtual mic
  playback, tray UI, and desktop status overlay.
- Code donor value:
  very high. `core/pipeline.py` coordinates translation, TTS, OSC chatbox,
  voice toggle, virtual mic playback, cancellation, progress callbacks, and
  cleanup. `services/local_whisper.py` caches a faster-whisper GPU model and
  transcribes 16 kHz audio. `services/osc_client.py` sends chatbox, typing, and
  voice OSC paths. `ui/status_overlay.py` shows topmost progress/done/error
  states.
- Product reference value:
  very high for VRChat speech/translation/TTS utilities.
- What to inspect next:
  GPU-only assumption, config schema, virtual mic routing, hotkey cancel UX,
  privacy, error reporting, and translated text moderation.

### `Alchemishty/ExpressVR`

- Interesting idea:
  speech/emote expression can be represented as a networked bubble registry
  and radial input layer, instead of only raw voice chat.
- Code donor value:
  high. `NetworkedSpeechBubble.cs` registers bubbles by owner client, applies
  settings, shows/hides emotes, and animates pop/squash timing.
  `EmoteWheelManager.cs` manages config, bubble settings, registration,
  server/client RPC broadcast, local events, sounds, and manual local display.
  XR abstraction files separate generic and OVR input providers.
- Product reference value:
  high for multiplayer communication surfaces and avatar-adjacent expression
  tools.
- What to inspect next:
  Netcode version, text vs sprite emotes, moderation, cooldowns, ownership,
  packet spam, accessibility, and whether speech bubbles can carry STT text.

### `ahmedbegovic/VoiceInteractionVR`

- Interesting idea:
  voice interaction can be part of puzzle activation and environmental response,
  but the reusable value depends on the actual speech-recognition boundary.
- Code donor value:
  low/source-light in this pass. Inspected code primarily shows puzzle
  activation, color sequence, object highlighting, and door/puzzle progression.
- Product reference value:
  medium as a small voice-interaction search marker.
- What to inspect next:
  Speech SDK integration files, command grammar, confidence handling, puzzle
  event mapping, and fallback input.

## Reusable Pattern Extraction

- Pattern candidate:
  voice-driven XR utility boundary across mic consent, capture, recognition,
  command/agent pipeline, transport, output surface, and privacy controls.
- Problem solved:
  voice features often mix microphone access, command mapping, AI services,
  avatar output, chatbox text, and audio playback. Reuse needs explicit
  boundaries and user control.
- Reusable core:
  consent gate, mic level meter, audio ring buffer, STT adapter, command map,
  service pipeline, text generation/TTS adapter, Opus encoder/decoder, OSC
  chatbox/parameter output, networked speech bubble, status overlay, cancel
  point, language setting, and privacy/export policy.
- Source evidence:
  `voicesdk-samples-whisperer`, `ubiq-genie`,
  `MagicOnionExample-OculusMobileVoiceChat`, `vrc-voice-params`,
  `VRC-Voicebridge`, `ExpressVR`, and `vr-the-feedback-unity`.
- Abstraction boundary:
  keep microphone capture, recognition, command matching, agent/TTS services,
  transport, avatar/OSC output, UI feedback, and privacy/consent separate.
- What not to copy:
  always-on mic without consent, cloud STT/TTS without clear privacy messaging,
  voice commands without confirmation for destructive actions, OSC writes
  without type/path validation, voice chat without mute/room auth, or TTS
  pipelines without cancellation and error states.
- Method catalog action:
  add a voice-driven XR communication/control method.

## Follow-Up Gaps

- Build a matrix across Voice SDK commands, local STT, cloud STT/TTS, VRChat
  OSC/chatbox sidecars, multiplayer voice chat, speech bubbles, and feedback
  recording.
- Deepen `UCL-VR/ubiq-genie`, `MagicOnionExample-OculusMobileVoiceChat`,
  `VRC-Voicebridge`, and `vrc-voice-params` as strongest donors.
- Compare with older VRChat chatbox/STT waves so translation, command, chatbox,
  and voice chat pipelines are named distinctly.
- Consider a future reuse plan for a speech utility kit: consent gate, mic
  level, STT adapter, command registry, OSC output, TTS/agent adapter, status
  overlay, and privacy checklist.
