# GitHub Research Wave 164 Plan

- Date: `2026-06-05`
- Theme: `VRChat, OBS, audience captions, translation, and chat-ingress surfaces`
- Scope: local speech/OCR platforms, OBS/browser caption surfaces, VRChat OSC
  chatbox bridges, stream chat ingress, and scene-caption experiments.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier text waves covered VRChat chatbox tools, subtitles, TTS, and audience
chat overlays. Wave 164 narrows the pass to caption and translation pipelines
that route text between microphone/OCR/vision inputs, browser or OBS surfaces,
VRChat OSC, and stream-facing chat.

## Search Families

- VRChat live captions and translation
- OBS browser captions and stream captions
- websocket-driven caption overlays
- VRChat OSC chatbox pacing
- Twitch chat ingress for Unity/VR worlds
- AI/vision caption experiments for VRChat scenes

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `Sharrnah/whispering` | Local speech/OCR/TTS/translation platform with websocket overlays and VRChat OSC outputs | Multimodal caption and chatbox sidecars |
| `mmpneo/curses` | OBS, Twitch, Discord, STT/TTS/translation, browser, and VRChat targets behind one event bus | Audience caption fan-out surfaces |
| `Harry-Jing/vrc-live-caption` | Source-light VRChat live caption and translation product reference | VRChat caption micro-utilities |
| `FionnaPrefabs/Fionnas-Audio-Captions-Prefab` | VPM/package-listing caveat around caption prefab distribution | Package/distribution reference only |
| `Vinventive/VRChat-to-BLIP` | Window-capture to BLIP scene caption loop for VRChat | Vision-caption accessibility experiments |
| `lexonegit/Unity-Twitch-Chat` | Unity Twitch IRC client with metadata-aware chat queues | Audience chat ingress for VR apps |

## Dedupe Notes

- `Sharrnah/whispering` was already tracked as partially studied and is
  promoted by this pass into a deeper caption/overlay/OSC source-reading note.
- Prior VRChat chatbox tools remain comparison context; this wave focuses on
  caption fan-out and audience text ingress rather than generic chatbox
  composition.
- `Fionnas-Audio-Captions-Prefab` is intentionally treated as source-light
  packaging context, not a deep donor.

## Code-Level Pass Targets

- websocket overlay configuration and browser URL contracts;
- OSC chatbox pacing, chunking, and typing state;
- central text event buses and target fan-out;
- OBS native caption and browser-source integration;
- Twitch IRC metadata and Unity main-thread queueing;
- window capture and AI scene-caption boundaries;
- caveats around heavyweight model dependencies and source-light repos.

## Expected Outputs

- New Wave 164 landscape synthesis.
- Registry and family updates for caption, translation, OBS, VRChat OSC, and
  audience chat-ingress surfaces.
- Methods around websocket/OSC caption fan-out, text-event buses, vision-caption
  loops, and Unity Twitch chat ingestion.
