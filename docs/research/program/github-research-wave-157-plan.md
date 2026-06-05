# GitHub Research Wave 157 Plan

- Date: `2026-06-05`
- Theme: `VRChat chatbox, speech/TTS, AI companions, and text-composition sidecars`
- Scope: AI-to-chatbox assistants, TTS/audio routing, Linux chatbox telemetry,
  and visual chatbox/template editors for VRChat OSC.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

VRChat text-sidecar waves already covered STT, translation, and chatbox
senders. Wave 157 revisits the family from the composition side: how messages
are generated, paginated, previewed, synthesized into voice, routed through
virtual audio devices, and made configurable for nontechnical users.

## Search Families

- VRChat chatbox companions
- TTS-to-OSC and virtual audio cable tools
- AI assistants with VRChat OSC tool calls
- Linux-native chatbox/status managers
- placeholder/template chatbox editors
- OSC forwarders and avatar parameter editors

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `S0L0GUY/NOVA-AI` | Local-first Gemini assistant with memory, audio, screenshot, tool-calling, and VRChat OSC output | AI chatbox/automation sidecars |
| `MaurerKrisztian/vrc-tts-osc` | Narrow TTS + virtual audio + chatbox sender previously queued as not studied deeply | TTS-to-chatbox micro-utilities |
| `hollyntt/XOSC` | Linux/Steam Deck native C# chatbox manager for music, hardware, status, weather, and network telemetry | Linux chatbox telemetry surfaces |
| `TheArmagan/advosc` | Electron/Svelte chatbox editor, placeholder engine, avatar parameter control, and OSC forwarder | Visual chatbox composition and OSC automation |

## Dedupe Notes

- `MaurerKrisztian/vrc-tts-osc` was already known as a Wave 48 comparison node
  and is deepened here because the TTS/audio-routing contract is distinct.
- `XOSC` overlaps telemetry/status families but is kept here because its user
  value is chatbox composition.
- `advosc` also overlaps avatar-parameter control families; this wave studies
  its chatbox/template/editor side.

## Code-Level Pass Targets

- OSC chatbox paging and typing indicators;
- virtual-audio routing and speech generation flow;
- prompt/config/memory separation for AI assistants;
- Linux hardware/media/weather/status gathering;
- placeholder engines and recursion/failure guards;
- simple block editor versus advanced template editor;
- OSC forwarder rule intervals, casting, and mapping.

## Expected Outputs

- New Wave 157 landscape synthesis.
- Registry/family updates for chatbox, TTS, Linux status, and template editor
  sidecars.
- Methods around AI tool-calling to OSC, virtual-audio TTS, chatbox telemetry,
  and placeholder-driven OSC forwarding.
