# VR Projects Wave 164: VRChat, OBS, Audience Captions, Translation, and Chat-Ingress Surfaces

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 164 studies caption and text-ingress projects that move speech, OCR,
translation, stream chat, or AI scene captions into browser overlays, OBS,
VRChat OSC chatbox outputs, avatar text, Discord, or Unity-side VR surfaces.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `Sharrnah/whispering` | Multimodal caption and chatbox sidecars | Strong architecture donor; heavy dependency caveat |
| `mmpneo/curses` | Audience caption fan-out surfaces | Strong event-bus and target donor |
| `Harry-Jing/vrc-live-caption` | VRChat caption micro-utilities | Source-light product reference |
| `FionnaPrefabs/Fionnas-Audio-Captions-Prefab` | VPM package/distribution reference | Caveat only |
| `Vinventive/VRChat-to-BLIP` | Vision-caption accessibility experiments | Useful narrow concept donor |
| `lexonegit/Unity-Twitch-Chat` | Audience chat ingress for VR apps | Useful Unity transport donor |

## `Sharrnah/whispering`

- Interesting idea:
  make local speech recognition, translation, OCR, TTS, RVC, and LLM features
  available through multiple output surfaces, including browser websocket
  overlays and VRChat OSC chatbox messages.
- Code donor value:
  high for websocket overlay routing, browser remote commands, plugin timer
  hooks, OSC chatbox chunking, typing state, and output transport separation.
- Product reference value:
  high for a caption platform that treats VRChat as one consumer instead of the
  whole product.
- What to inspect next:
  split the heavyweight model stack from the thin websocket/OSC presentation
  layer and compare browser overlay URL flags with OBS source patterns.
- Source evidence:
  `documentation/websocket-clients.md`, `audioWhisper.py`, `websocket.py`, and
  `VRC_OSCLib.py`.
- Reusable pattern extraction:
  local multimodal caption platform with transport fan-out.
- Reusable core:
  keep input/model processing behind a sidecar, expose a browser overlay
  protocol, pace chatbox messages through a dedicated OSC sender, and let
  clients configure overlay behavior through URL parameters.
- Do not copy directly:
  the full AI/model dependency surface unless a future prototype explicitly
  needs it.
- Caveats:
  heavyweight dependencies, broad scope, and likely GPU/model setup burden.

## `mmpneo/curses`

- Interesting idea:
  normalize STT, translation, Twitch chat, Discord, manual text, OBS, TTS, and
  VRChat outputs around a shared text-event bus.
- Code donor value:
  high. The server service split, `TextEventSchema`, pubsub history, target
  abstractions, OBS caption integration, VRChat chatbox typing, and animated
  browser text elements are strong donor boundaries.
- Product reference value:
  high for stream-facing and avatar-facing captions that can target OBS native
  captions, browser overlays, VRChat chatbox/avatar text, Discord, and TTS.
- What to inspect next:
  compare its text event model with earlier chatbox template engines and build
  a target capability matrix.
- Source evidence:
  `src/server/index.ts`, `src/shared/services/pubsub/index.ts`,
  `src/server/services/vrc/index.ts`, `src/server/services/obs/index.ts`, and
  `src/client/elements/text/index.tsx`.
- Reusable pattern extraction:
  central caption event bus with target-specific delivery adapters.
- Reusable core:
  define text events once, preserve recent history, then let each target adapt
  final/interim text, emotes, timers, profanity masking, animation, and native
  caption calls.
- Do not copy directly:
  the whole app shell; the reusable unit is the service boundary and event
  model.
- Caveats:
  broad web/Tauri-style app scope and some VR value is indirect through OBS and
  VRChat targets.

## `Harry-Jing/vrc-live-caption`

- Interesting idea:
  focus directly on microphone speech-to-text and translation for VRChat
  chatbox captions, including Chinese and mixed Chinese-English use cases.
- Code donor value:
  low. The clone is README-only in this pass.
- Product reference value:
  medium as a source-light signal that live translation to VRChat chatbox is a
  recognized micro-utility.
- What to inspect next:
  find forks/releases or a maintained implementation before treating it as a
  donor.
- Reusable pattern extraction:
  product framing only: microphone caption micro-utility for VRChat OSC.
- Caveats:
  no meaningful code-level donor surface in the current repository state.

## `FionnaPrefabs/Fionnas-Audio-Captions-Prefab`

- Interesting idea:
  package audio-caption related assets through a VPM-style distribution flow.
- Code donor value:
  low for captions. The repository currently reads like a VPM package template
  with release/listing workflow scaffolding rather than a caption implementation.
- Product reference value:
  low-medium for package distribution and listing automation caveats.
- What to inspect next:
  only revisit if actual prefab/runtime caption assets appear.
- Source evidence:
  `README.md`, `.github/workflows/release.yml`, `build-listing.yml`,
  `Website/`, and `Packages/com.vrchat.demo-template/package.json`.
- Reusable pattern extraction:
  VPM package/listing workflow reference, not a VR caption method.
- Caveats:
  template residue dominates the repository; do not treat it as a caption donor.

## `Vinventive/VRChat-to-BLIP`

- Interesting idea:
  capture the VRChat desktop window and feed frames into BLIP to generate
  natural-language scene captions.
- Code donor value:
  medium for the window-capture-to-vision loop and active-window handling.
- Product reference value:
  medium for accessibility, AI scene awareness, and future overlay/assistant
  experiments.
- What to inspect next:
  add a transport boundary: websocket overlay, chatbox, screen-reader, or
  diagnostics panel.
- Source evidence:
  `vision_encoder.py`.
- Reusable pattern extraction:
  VR window capture to AI scene-caption sidecar.
- Reusable core:
  find the target app window, capture client-area pixels to memory, run a
  captioning model on a paced interval, and expose generated text to a separate
  presentation layer.
- Do not copy directly:
  high-end GPU assumptions or the missing output UX.
- Caveats:
  experimental, Windows-specific capture dependencies, high hardware
  requirements, and no polished VR output path.

## `lexonegit/Unity-Twitch-Chat`

- Interesting idea:
  provide Unity projects with a lightweight Twitch IRC client that can read and
  send chat while preserving tags, emotes, badges, name colors, and connection
  alerts.
- Code donor value:
  medium-high for threaded IRC read/write, main-thread event queues, metadata
  parsing, rate-limit checks, and reconnect behavior.
- Product reference value:
  medium-high for audience chat panels, stream-facing VR worlds, and in-headset
  chat surfaces.
- What to inspect next:
  compare with browser-source chat overlays and decide when Unity-native chat
  ingress is worth the extra runtime code.
- Source evidence:
  `IRC.cs`, `Chatter.cs`, and `TwitchConnection.*`.
- Reusable pattern extraction:
  Unity audience chat ingress with metadata-aware main-thread queue.
- Reusable core:
  isolate IRC connection threads, normalize chat/emote/badge metadata into a
  message object, cap per-frame event processing, and expose Unity events.
- Caveats:
  Twitch-specific, no WebGL, and presentation UX is left to the consuming app.

## Cross-Project Lessons

- Captions should be modeled as events, not as UI widgets.
- VRChat chatbox output needs pacing, chunking, typing state, and fallback
  formatting before it feels usable.
- Browser overlays, OBS native captions, avatar text, Discord, Twitch, and
  Unity text are different targets with different delivery guarantees.
- Heavy AI stacks are valuable only if their transport and presentation layers
  can be reused independently.
- Source-light caption repos are useful as product signals, but they should not
  inflate the donor catalog.

## Reusable Methods Extracted

- Local multimodal caption platform with websocket overlay and OSC chatbox
  fan-out.
- Text-event bus for captions across OBS, browser, VRChat, Twitch, Discord,
  and TTS targets.
- Window-capture vision caption loop for VR scene accessibility.
- Unity Twitch IRC ingress with metadata-aware main-thread queues.

## Follow-Up Backlog

- Build a caption-surface matrix across input, formatter, transport, and target.
- Compare chatbox, browser overlay, OBS native caption, avatar text, and
  in-world Unity text as presentation endpoints.
- Keep package/distribution references separate from real caption
  implementation donors.
