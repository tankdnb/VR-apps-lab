# Wave 363: Voice Intent Command Spellcasting and Speech to XR Action Adapters

## Scope

This wave studies voice-controlled XR projects where speech becomes action:
spellcasting, command registries, intent handlers, AR placement commands,
transcripts, and SDK-level speech/TTS/lipsync boundaries. The reusable value is
the adapter between voice systems and explicit XR actions.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `eugenek07/hairy-otter` | Studied | Meta/Wit.ai VR spellcasting prototype with voice activation, transcript UI, Conduit intent mapping, command validation, and spell dispatcher |
| `ajinkyasatuse/Enchantress_AR` | Studied | Unity AR voice-command prototype using Windows `KeywordRecognizer`, AR raycast placement, command dictionary, summon/fight/fly actions, and fallback spawn logic |
| `wit-ai/wit-unity` | Studied as substrate | Wit.ai Unity SDK with `VoiceService`, request/transcription events, Conduit parameter provider, intent/entity handlers, TTS, cache, audio, and lipsync boundaries |

## Reusable Pattern Extraction

- Pattern candidate: `voice intent to XR action dispatcher`.
- Problem solved: voice-controlled XR tools need a safe bridge from microphone
  input to explicit actions without mixing speech capture, NLU, command
  validation, action execution, feedback, and privacy.
- Reusable core: mic activation/deactivation, consent state, cooldown,
  transcript UI, recognizer/intent adapter, command registry, entity/parameter
  resolver, action dispatcher, spatial target resolver, feedback channel,
  unrecognized-command path, credentials/privacy labels, and offline/vendor
  fallback.
- Source evidence: hairy-otter includes `VoiceController`, `Spells`, and
  Conduit scripts for cast/change-light commands; Enchantress_AR uses a
  `Dictionary<string, Action>` with `KeywordRecognizer` and AR raycast/fallback
  placement; wit-unity exposes `VoiceService`, `WitIntentMatcher`,
  transcription events, request factories, TTS cache, and lipsync components.
- Abstraction boundary: speech systems should output command intents and
  parameters; XR objects should consume validated action events; credentials,
  mic permissions, transcript UI, and fallback states should be explicit.
- What not to copy: hardcoded magic words as product UX, always-on microphone
  capture, cloud credentials, emoji/debug-only feedback, or command execution
  without confirmation for destructive actions.
- Method catalog action: create a new voice-to-XR action dispatcher method.

## Project Notes

### `eugenek07/hairy-otter`

- Interesting idea: spellcasting is implemented as voice intent recognition that
  maps recognized spell names to an explicit spell dispatcher.
- Code donor value: high for small command dispatch, activation/deactivation,
  cooldown, transcript feedback, unrecognized command handling, and Conduit
  intent mapping.
- Product reference value: strong for hands-busy control, accessibility-adjacent
  commands, and magical/metaphoric utility UX.
- What to inspect next: microphone permission UX, offline behavior, confidence
  thresholds, and command cancellation.
- Caveats: playful prototype; reuse the dispatcher boundary, not the fantasy
  framing or cloud assumptions.

### `ajinkyasatuse/Enchantress_AR`

- Interesting idea: Windows speech keywords map through a dictionary to AR
  placement and combat actions, with raycast floor targeting and a fallback
  spawn in front of the camera.
- Code donor value: high for a minimal local keyword command registry, spatial
  target resolver, visual placement indicator, and action fallback logic.
- Product reference value: useful for local/offline command prototypes and AR/VR
  object-spawn utilities.
- What to inspect next: confidence thresholds, microphone focus UX, command
  grammar growth, and safe confirmation for irreversible actions.
- Caveats: Windows speech and AR Foundation are not portable to every headset;
  isolate recognizer and target resolver.

### `wit-ai/wit-unity`

- Interesting idea: the SDK separates voice service requests, transcription,
  intent/entity handlers, Conduit parameter mapping, TTS playback/cache, and
  lipsync animation.
- Code donor value: high as a substrate reference for adapter boundaries,
  events, request lifecycle, transcript streams, and speech output/lipsync
  surfaces.
- Product reference value: strong for deciding what a neutral voice layer should
  expose before binding to a vendor service.
- What to inspect next: request cancellation, privacy surface, on-device/cloud
  split, and how to represent TTS/lipsync as optional output modules.
- Caveats: vendor SDK; do not vendor-copy into the repo or assume its service
  availability.

## Product Direction

This wave supports a `voice command utility layer` branch: VR tools can expose a
neutral command registry with mic state, transcript, recognizer adapter,
parameter resolver, action dispatcher, and explicit safety/privacy boundaries.

