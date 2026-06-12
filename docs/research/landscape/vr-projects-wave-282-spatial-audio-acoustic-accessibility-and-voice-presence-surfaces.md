# Wave 282 - Spatial Audio, Acoustic Accessibility, and Voice Presence Surfaces

This wave studies sound-related VR/XR projects as references for positional
audio, BRIR preprocessing, accessibility-first acoustic navigation, onboarding
audio, echo/object descriptions, voice-chat presence, and source-light media
conversion caveats.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- WebXR/Three.js positional audio and browser XR audio-context behavior;
- binaural/BRIR preprocessing;
- blind/low-vision acoustic museum navigation and echo-description UX;
- WebRTC voice presence, VAD, and speaking-state indicators;
- non-fit immersive-media side nodes discovered during audio search, retained
  only with caveats.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `nikita-s-nair/Spatial-Audio-VR` | WebXR positional audio starter | Studied | Three.js `PositionalAudio`, XR session audio resume, controller setup |
| `rvedantv/Spatial-Audio-VR` | BRIR preprocessing reference | Source-light audio reference | Binaural room impulse response convolution workflow |
| `xavieraustralia/aioptimisationlabvirtual` | Voice-presence web surface | Studied with scope caveats | WebRTC voice chat, VAD, speaking UI, reconnecting WebSocket |
| `lanzhang76/artEcho` | Acoustic accessibility museum | Studied | Onboarding, positional audio, echo samples, object descriptions, interruption recovery |
| `Devanik21/Hackathon-VR-180-Immersive-Experience` | Immersive media conversion side node | Non-fit/source-light reference | Streamlit 2D-to-VR180 depth-conversion sketch, not an audio donor |

## Code-Level Findings

### `nikita-s-nair/Spatial-Audio-VR`

- Interesting idea:
  a WebXR room uses Three.js `PositionalAudio` speakers with a browser XR
  fallback device emulator.
- Code donor value:
  useful compact donor for listener setup, GLTF speaker placement, audio buffer
  loading, distance model/ref distance/rolloff configuration, controller setup,
  and `AudioContext` resume on XR session start.
- Product reference value:
  good starter reference for a spatial audio demo or diagnostic scene.
- What to inspect next:
  multi-source mixing, mobile autoplay behavior, room scale, and accessibility
  affordances.
- Reusable pattern:
  browser WebXR positional audio starter.
- Caveats:
  remote model assets, simple attenuation model, and no robust accessibility
  layer.

### `rvedantv/Spatial-Audio-VR`

- Interesting idea:
  dry audio is convolved with binaural room impulse responses to generate a
  stereo spatial output.
- Code donor value:
  limited but useful preprocessing reference for BRIR convolution,
  normalization, and asset preparation.
- Product reference value:
  good reminder that spatial audio utilities may need offline asset pipelines,
  not only runtime components.
- What to inspect next:
  impulse-response source, room metadata, automation, and export format.
- Reusable pattern:
  BRIR-based spatial audio preprocessing.
- Caveats:
  audio-only Scilab workflow, not an interactive VR app.

### `xavieraustralia/aioptimisationlabvirtual`

- Interesting idea:
  voice communication is represented as presence UI: active peers, speaking
  rings, and local "You" state.
- Code donor value:
  `use-voice-chat.ts` and `VoiceChat.tsx` are useful references for WebRTC peer
  setup, STUN config, offer/answer/ICE over WebSocket, remote audio elements,
  `AnalyserNode` voice-activity detection, speaking broadcasts, reconnecting
  WebSocket, and compact speaking indicators.
- Product reference value:
  good reference for companion dashboards or shared VR workspaces that need
  voice presence rather than a full social platform.
- What to inspect next:
  auth, permission UX, room identity, echo cancellation, and VR surface
  integration.
- Reusable pattern:
  voice presence indicator plus WebRTC audio transport.
- Caveats:
  broad web app, not clearly immersive VR, microphone/privacy risks.

### `lanzhang76/artEcho`

- Interesting idea:
  a web-based acoustic museum for blind and low-vision users uses positional
  chamber sounds, echo samples, object descriptions, hints, and keyboard-driven
  exploration.
- Code donor value:
  strongest donor in the wave: `audioManager.js` coordinates onboarding stages,
  footsteps, hints, chamber/object positional sounds, echo playback with fades,
  mutually exclusive object/echo descriptions, gallery/BGM restoration, and
  keyboard-control audio interruptions; `sketch.js` sets accessibility
  attributes on the canvas and wires GLTF/DRACO loading, listener, camera,
  chamber state, and navigation.
- Product reference value:
  excellent reference for accessibility-first VR where audio is the primary UI,
  not decoration.
- What to inspect next:
  user-study findings, asset provenance, keyboard mapping, screen-reader
  behavior, and whether the audio state machine can be generalized.
- Reusable pattern:
  acoustic accessibility surface with interruption recovery.
- Caveats:
  older web stack, bundled assets/dist output, and many authored audio files.

### `Devanik21/Hackathon-VR-180-Immersive-Experience`

- Interesting idea:
  a Streamlit app sketches 2D-to-VR180 conversion using OpenCV, depth
  estimation, and optional Gemini insights.
- Code donor value:
  low for this wave; useful only as a source-light immersive media conversion
  side node.
- Product reference value:
  evidence that "immersive media" search terms can return depth-conversion
  utilities unrelated to VR audio.
- What to inspect next:
  whether a true VR180 player/exporter exists elsewhere in the project.
- Reusable pattern:
  none promoted for audio/accessibility.
- Caveats:
  off-theme for sound, README overclaims relative to inspected source, and API
  key/dependency risks.

## Reusable Pattern Extraction

- Pattern candidate:
  spatial audio and acoustic accessibility surface.
- Problem solved:
  make sound in XR useful as navigation, context, description, collaboration
  presence, and feedback rather than a single ambient track.
- Reusable core:
  listener attachment, positional sources, falloff and directional cones,
  browser audio-context resume, BRIR preprocessing, onboarding narration, hint
  cadence, object descriptions, echo playback, interruption/restoration policy,
  voice VAD, speaking-state UI, and microphone/privacy gates.
- Source evidence:
  `Spatial-Audio-VR` by `nikita-s-nair`, `Spatial-Audio-VR` by `rvedantv`,
  `aioptimisationlabvirtual`, and `artEcho`.
- Abstraction boundary:
  keep audio asset preparation, runtime spatialization, accessibility state,
  voice transport, and interruption policy separate.
- What not to copy:
  autoplay assumptions, unguarded microphone capture, hardcoded audio stages,
  bundled dist assets as source architecture, or off-theme media converters as
  audio donors.
- Method catalog action:
  add a spatial audio/acoustic accessibility method.

## Follow-Up Gaps

- Build a spatial audio/accessibility matrix across positional sources, BRIR
  preprocess, onboarding/hints, echo/object descriptions, voice VAD, and
  audio interruption/restoration.
- Deepen `artEcho` as the strongest accessibility audio donor.
- Compare WebXR, Unity, Steam Audio, and browser WebRTC voice-presence
  boundaries in a future pass.
- Keep `Devanik21/Hackathon-VR-180-Immersive-Experience` as an off-theme
  media-conversion side node, not a promoted audio method source.
