# GitHub Research Wave 299 Backlog - Voice-Driven VR Communication, Control, Agents, and Speech Surfaces

## Executed Scope

- Searched and deduplicated Voice SDK samples, conversational agents,
  transcription services, voice chat examples, VRChat voice sidecars, speech
  bubbles, voice feedback recorders, and voice-puzzle samples.
- Froze an eight-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted mic-level events, service-orchestrated STT/TTS/agents, Opus voice
  chat, Web Speech to OSC parameter writes, cancelable VRChat TTS pipelines,
  status overlays, and networked speech bubble/emote surfaces.

## Studied Projects

- `oculus-samples/voicesdk-samples-whisperer`
- `UCL-VR/ubiq-genie`
- `vr-the-feedback/vr-the-feedback-unity`
- `nikaera/MagicOnionExample-OculusMobileVoiceChat`
- `xiaolazhu/vrc-voice-params`
- `Jurangren/VRC-Voicebridge`
- `Alchemishty/ExpressVR`
- `ahmedbegovic/VoiceInteractionVR`

## Backlog Findings

- Build a voice matrix across Voice SDK, local/cloud STT, TTS, VRChat OSC,
  chatbox, avatar parameters, voice chat, speech bubbles, and feedback capture.
- Deepen `ubiq-genie`, `MagicOnionExample-OculusMobileVoiceChat`,
  `VRC-Voicebridge`, and `vrc-voice-params` as strongest donors.
- Compare with older chatbox/STT/TTS waves so command, translation, chatbox,
  and voice chat pipelines are not conflated.
- Consider a reuse plan for a speech utility kit with consent gate, mic level,
  STT adapter, command registry, OSC output, TTS/agent adapter, status overlay,
  and privacy checklist.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a voice-driven XR communication/control method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
