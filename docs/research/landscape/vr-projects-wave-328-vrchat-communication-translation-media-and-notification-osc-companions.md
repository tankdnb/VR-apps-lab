# Wave 328 - VRChat Communication, Translation, Media, and Notification OSC Companions

This wave studies VRChat OSC companions that turn speech, translation, media
state, and desktop notifications into in-VR communication surfaces.

No external project was run, installed, or launched.

## Scope

The wave was bounded to:

- STT, TTS, translation, and chatbox output companions;
- peer/self channel separation for subtitles and chatbox output;
- media-status and system-status chatbox microtools;
- desktop notification to avatar-parameter pipelines.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `PaciStardust/HOSCY` | Modular VRChat communication and OSC companion | Studied | Strong donor for modular recognition providers, Whisper subprocess IPC, OSC routing/OSCQuery, output preprocessors, counters, AFK, TTS, and legacy-config migration |
| `kapitalismho/PuriPuly-heart` | LLM two-way VRChat translation and subtitle overlay | Studied | Strong product and architecture donor for self versus peer speech channels, context-aware LLM translation, native subtitle overlay, brokered key flow, provider routing, and privacy/cost framing |
| `VespeiProjects/SpotifyOSC` | Narrow media/status chatbox sidecar | Studied | Small WPF donor for Spotify process polling, chatbox output, prefix/save options, and fallback CPU/RAM/GPU status text |
| `shadorki/vrc-osc-discord-band` | Desktop notification to avatar wearable | Studied | Compact product reference for Windows notification listener, Discord call/message classification, OSC avatar bracelet parameters, config file port override, and Unity package setup flow |

## Code-Level Findings

### `PaciStardust/HOSCY`

- Interesting idea:
  a VRChat communication companion can be built as a modular service graph
  rather than a single chatbox script.
- Code donor value:
  high. The current rewrite keeps dependency injection, config loading, OSC
  send/receive/routing, OSCQuery, media controls, STT providers, TTS, textbox
  control, and translation as separable services. The Whisper V2 process uses
  JSON IPC records for logs, status, keepalive, mute, and recognition output.
  The legacy config loader maps old OSC, recognition, textbox, AFK, counter,
  media, and translation settings into the new model.
- Product reference value:
  high for communication/accessibility companions where manual text, voice,
  translation, notifications, and avatar controls share one operator surface.
- What to inspect next:
  current UI recreation, final V1 module lifecycle, OSC relay filters, and how
  provider secrets are stored.
- Architecture pattern:
  `desktop communication shell + modular services + external recognition
  worker + OSC/OSCQuery routing + output preprocessors`.
- Reusable method:
  channel-separated VRChat communication companion.
- UX pattern:
  one companion covers manual input, automatic speech, textbox presets,
  translated output, media display, mute/AFK indicators, and notifications.
- Constraints / caveats:
  rewrite is explicitly in progress; old release branch may differ from
  inspected current source; cloud providers and microphone handling need clear
  privacy notes.
- Why it matters for `VR-apps-lab`:
  it is a strong evidence source for building VR communication utilities as
  modules with explicit provider and output boundaries.

### `kapitalismho/PuriPuly-heart`

- Interesting idea:
  VRChat translation can separate the user's own translated speech from peer
  speech that belongs in a subtitle overlay, not the public chatbox.
- Code donor value:
  high. The repo has explicit domain context, Python provider layers,
  `python-osc`, WebSocket/native overlay components, broker/key delivery docs,
  prompt templates, cost/performance framing, and native overlay tests that
  distinguish `peer:*` and `self:*` caption blocks.
- Product reference value:
  very high for social VR accessibility: it frames translation as natural
  conversation, not literal sentence conversion, and documents costs, provider
  choices, latency, Discord onboarding, and low-noise caveats.
- What to inspect next:
  native overlay runtime, provider routing controller, managed-key trust model,
  peer audio capture boundaries, and local history retention.
- Architecture pattern:
  `speech capture + ASR provider + context-aware LLM translation + channel
  router + VR subtitle overlay + optional VRChat OSC output`.
- Reusable method:
  self/peer channel separation for speech utilities.
- UX pattern:
  quick onboarding with Discord auth, visible STT/TRANS/Subtitles toggles, and
  guidance around Earmuff/noise conditions for peer translation.
- Constraints / caveats:
  AGPL license, cloud STT/LLM costs, provider privacy, and social consent are
  central reuse constraints.
- Why it matters for `VR-apps-lab`:
  it gives the strongest recent reference for separating public chat output
  from private accessibility/subtitle surfaces.

### `VespeiProjects/SpotifyOSC`

- Interesting idea:
  a tiny companion can keep one strong value proposition: show current media
  state in the VRChat chatbox.
- Code donor value:
  medium-low. `MainWindow.xaml.cs` polls Spotify processes, formats text,
  persists settings under common app data, sends `/chatbox/input` to
  `127.0.0.1:9000`, and can fall back to CPU/RAM/GPU status messages.
- Product reference value:
  medium as a simple media/status microtool.
- What to inspect next:
  safer Spotify metadata source, message rate limiting, and better separation
  between UI thread, polling, and OSC sender.
- Caveat:
  WPF app is small and somewhat monolithic; it creates UDP senders inside the
  update path and uses broad exception handling.

### `shadorki/vrc-osc-discord-band`

- Interesting idea:
  desktop notifications can drive avatar-worn status hardware, not just a text
  overlay.
- Code donor value:
  medium. `main.py` wires a Windows notification listener to `DiscordBand`.
  The tool classifies Discord notifications and sends avatar parameters through
  OSC. `config.py` provides a local JSON port override. The Unity package and
  README document avatar FX/controller setup.
- Product reference value:
  high for wearable/avatar-parameter notification UX.
- What to inspect next:
  `DiscordBand` parameter timing, debounce/reset policy, and Windows
  notification permission edge cases.
- Caveat:
  Windows-only notification API, avatar package setup burden, and Discord-only
  source assumptions.

## Reusable Pattern Extraction

- Pattern candidate:
  channel-separated VRChat communication companion.
- Problem solved:
  speech, translation, notifications, and media-status tools often compete for
  the same chatbox or avatar parameters; without channel separation they leak
  private/peer content into public output or become hard to reason about.
- Reusable core:
  source adapters, recognition/provider modules, translation/context module,
  output preprocessor, self/peer channel router, chatbox sink, subtitle/overlay
  sink, avatar-parameter sink, OSCQuery discovery, config migration, rate
  limits, provider privacy notes, and visible operator toggles.
- Source evidence:
  `PaciStardust/HOSCY`, `kapitalismho/PuriPuly-heart`,
  `VespeiProjects/SpotifyOSC`, and `shadorki/vrc-osc-discord-band`.
- Abstraction boundary:
  keep input capture, provider calls, routing policy, output formatting, OSC
  transport, overlay/subtitle rendering, and avatar setup separate.
- What not to copy:
  peer speech to public chatbox, cloud provider use without consent/privacy
  notes, unbounded chatbox sends, hardcoded ports without config, or avatar
  parameter pulses without reset/debounce.
- Method catalog action:
  add a channel-separated communication companion method.

## Follow-Up Gaps

- Compare subtitle overlay and chatbox output rules across accessibility waves.
- Build a privacy matrix for VRChat communication companions.
- Revisit HOSCY after the V1 rewrite UI is complete.
