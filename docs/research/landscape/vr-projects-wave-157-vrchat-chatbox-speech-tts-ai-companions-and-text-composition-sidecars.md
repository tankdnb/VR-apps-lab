# VR Projects Wave 157: VRChat Chatbox, Speech/TTS, AI Companions, and Text-Composition Sidecars

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 157 studies VRChat text and speech sidecars as composition systems:
assistant output, TTS audio routing, chatbox pagination, telemetry/status
messages, placeholder engines, visual editors, and OSC forwarders.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `S0L0GUY/NOVA-AI` | AI chatbox/automation sidecars | Strong concept donor with API/runtime caveats |
| `MaurerKrisztian/vrc-tts-osc` | TTS-to-chatbox micro-utilities | Focused product/method reference |
| `hollyntt/XOSC` | Linux chatbox telemetry surfaces | Strong Linux-first chatbox status donor |
| `TheArmagan/advosc` | Visual chatbox composition and OSC automation | Strong editor/engine donor |

## `S0L0GUY/NOVA-AI`

- Interesting idea:
  route a local-first multimodal AI assistant into VRChat through OSC chatbox,
  typing state, avatar input commands, screenshot tools, and persistent memory.
- Code donor value:
  medium-high. The architecture is useful, but direct reuse depends on API,
  audio, and prompt decisions.
- Product reference value:
  high. It frames AI companionship as a sidecar with memory, voice, visuals,
  and avatar actions rather than only text generation.
- What to inspect next:
  compare its tool-calling and chatbox pagination with smaller chatbox bots
  before adopting any AI assistant pattern.
- Architecture pattern:
  Python supervisor restarts the main assistant process; `nova.py` loads YAML
  config/prompt, audio I/O, Gemini Live session, screenshot queues, SQLite
  memory, tool definitions, and VRChat OSC. Text chunks are buffered, typing
  state is toggled, long responses are paginated into chatbox-safe pages, idle
  monitoring can trigger movement tools, and memory tools expose short-term,
  long-term, quick-note, fetch, update, delete, search, and archive actions.
- Reusable method:
  AI assistant sidecar with prompt/config separation, persistent memory, typed
  tool mapping, chatbox pagination, and OSC avatar-action bridge.
- Caveats:
  API-key dependent, broad scope, live audio/device assumptions, and any future
  reuse should isolate the OSC/tool/memory contracts from the AI provider.

## `MaurerKrisztian/vrc-tts-osc`

- Interesting idea:
  combine typed text, generated speech, virtual audio cable output, and VRChat
  chatbox display into one narrow accessibility/communication workflow.
- Code donor value:
  medium. The code is simple and rough but the audio-routing contract is clear.
- Product reference value:
  high for a focused TTS micro-utility.
- What to inspect next:
  compare voice selection, queueing, replay, and pacing against TTS Wizard,
  VRCT, and other text workflow tools.
- Architecture pattern:
  Tkinter GUI selects input/output audio devices, OpenAI or ElevenLabs keys and
  voice, TTS service, volume, and optional AI/STT process. TTS generation sends
  `/chatbox/typing`, generates `ttsoutput.mp3`, sends `/chatbox/input`, clears
  typing state, and plays the MP3 through the selected device so VRChat hears
  it through a virtual microphone path.
- Reusable method:
  TTS-to-VRChat bridge using chatbox echo plus virtual-audio microphone
  routing.
- Caveats:
  early-stage, temporary output file, API-key and virtual-cable setup burden,
  limited pacing/queue sophistication.

## `hollyntt/XOSC`

- Interesting idea:
  make a native Linux/Steam Deck chatbox status manager that composes compact
  VRChat messages from music, hardware telemetry, network state, weather,
  custom statuses, and manual overrides.
- Code donor value:
  high for Linux-first telemetry gathering and compact chatbox formatting.
- Product reference value:
  high. It is a practical status surface for users who do not want a heavy
  Python/Electron stack.
- What to inspect next:
  compare its Linux hardware/media sources with Windows telemetry sidecars and
  decide whether a platform-neutral data adapter layer is worth documenting.
- Architecture pattern:
  C# Raylib/ImGui app stores config under user config paths, exposes tabs for
  dashboard/status/chatbox/hardware/network/appearance/updater, polls `/proc`
  and `/sys` on Linux, uses `playerctl` and `xdotool` fallbacks for media,
  parses VRChat logs for AFK and hardware names, optionally checks weather and
  network ping, alternates status/hardware pages, builds short chatbox strings,
  and sends raw OSC UDP packets with `/chatbox/input` type tags.
- Reusable method:
  Linux-native chatbox telemetry composer with compact formatting and graceful
  platform fallbacks.
- Caveats:
  many platform probes are best-effort, some visible source contains release
  and updater concerns, and OSC packet building should be validated if reused.

## `TheArmagan/advosc`

- Interesting idea:
  one placeholder engine powers both a beginner-friendly block editor and a
  power-user advanced template editor, then the same resolved values can drive
  chatbox output or arbitrary OSC forwarding.
- Code donor value:
  high. The editor/placeholder/forwarder separation is a strong reusable
  pattern.
- Product reference value:
  high. It shows how OSC power tools can be made approachable without removing
  advanced escape hatches.
- What to inspect next:
  build a placeholder-engine matrix across ADVOSC, XOSC, chatbox bots, and
  overlay/status tools.
- Architecture pattern:
  Electron main process opens OSC sockets on local ports, bridges file watching
  and OSC send/receive through IPC, and starts media monitoring. Renderer code
  maintains avatar schema/parameter stores, watches VRChat OSC and local avatar
  data folders, locks parameters when needed, and exposes chatbox modules. The
  template engine resolves `{{Module;Param}}` and inner `[[Module:Param]]`
  placeholders, guards recursive/excessive calls, persists module values, and
  auto-sends rendered chatbox text. The simple editor builds block types for
  text, media, progress, conditions, OSC data, hotkeys, trackers, numbers, and
  animations; the OSC forwarder evaluates templates on per-entry timers and
  casts/mapps results to Float/Int/Bool/String.
- Reusable method:
  placeholder-driven chatbox and OSC automation engine with simple/advanced
  editors, schema-aware path picker, and typed forwarding rules.
- Caveats:
  Windows-focused, broad app surface, bundled native helpers, and needs careful
  permissions/path handling before reuse.

## Cross-Project Lessons

- VRChat text utilities should separate generation, formatting, pacing, and
  transport.
- Chatbox UX improves when typing state, pagination, preview, and fallback text
  are explicit.
- TTS tools need audio routing as a first-class setup concept, not an afterthought.
- Placeholder engines become more valuable when they can drive both chatbox
  display and arbitrary OSC output.

## Reusable Methods Extracted

- AI assistant sidecar with memory/tool-calling and VRChat OSC output.
- TTS-to-chatbox bridge with virtual-audio microphone routing.
- Linux-native chatbox telemetry composer.
- Placeholder engine with visual block editor, advanced template editor, and
  typed OSC forwarder.

## Follow-Up Backlog

- Compare chatbox pagination, typing indicators, message length limits, and
  pacing across all text-sidecar references.
- Extract a template/placeholder engine checklist for future OSC utilities.
- Keep AI assistant patterns provider-neutral by documenting the OSC/tool
  contract separately from model-specific code.
