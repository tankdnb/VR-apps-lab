# GitHub Research Wave 299 Plan - Voice-Driven VR Communication, Control, Agents, and Speech Surfaces

## Goal

Study voice-related VR/XR projects as reusable references for microphone
consent, speech command mapping, STT/TTS/agent pipelines, OSC/avatar output,
voice chat transport, networked speech bubbles, and feedback capture.

## Research Questions

- How do projects separate mic capture, recognition, command matching, agent
  services, transport, output, and privacy/consent?
- Which projects are useful for sidecar control, voice chat, assistant
  orchestration, or in-world expression surfaces?
- How do VRChat voice sidecars handle OSC paths, chatbox output, virtual mic
  routing, cancellation, and status UI?
- Which projects are source-light product references rather than code donors?

## Shortlist

- `oculus-samples/voicesdk-samples-whisperer`
- `UCL-VR/ubiq-genie`
- `vr-the-feedback/vr-the-feedback-unity`
- `nikaera/MagicOnionExample-OculusMobileVoiceChat`
- `xiaolazhu/vrc-voice-params`
- `Jurangren/VRC-Voicebridge`
- `Alchemishty/ExpressVR`
- `ahmedbegovic/VoiceInteractionVR`

## Required Checks

- Deduplicate against older VRChat STT/chatbox/TTS, audio, communication, and
  remote-control waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep privacy, consent, OSC safety, cloud-service, package, and source-light
  caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 299.
- Registry/family entries for voice-driven XR utilities.
- Method catalog entry for voice communication/control boundaries.
- Follow-up gaps around a speech utility kit and VRChat voice/OSC pipeline
  matrix.
