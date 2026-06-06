# GitHub Research Wave 249 Plan

Date: 2026-06-06

Theme: VRChat OBS control, OSC scene switching, and movie night queues.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Wave 248 covered stream-facing world metadata. This wave shifts from display
to control: how in-VR actions, avatar parameters, log events, OBS scripts, or
local web apps change OBS stream, recording, replay buffer, microphone, scene,
and media playback state.

## Search Families

- VRChat OSC to OBS bridges.
- OBS WebSocket stream/record/scene controllers.
- OBS-native Python/Lua scripts for VRChat.
- VRChat loading-screen scene switching.
- VRChat movie night and world video-player queue tooling.
- Microphone mute synchronization.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `nerdywoffy/vrchat-obs-controller` | Go OSC sidecar with OBS v5/Streamlabs adapters, replay/record/stream/scene controls, and avatar feedback. | Bidirectional OSC-to-OBS donor |
| `rogeraabbccdd/VRChat-OBSOSC` | Node OBS v4/v5 bridge controlled by avatar expression menu parameters. | Compact OSC-to-OBS reference |
| `ioarchive/obscontrol` | Historical VRChat mod with quick-menu OBS controls and world-transition scene switching. | In-headset UX reference with policy caveats |
| `TuTu475/VRC-OBS-MicControl` | OBS Python script that debounces VRChat `muteself` OSC and corrects OBS microphone mute state. | OBS-native mic sync donor |
| `dimebag29/VRChatObsMicMuteLink` | Tray app that maps VRChat `MuteSelf` OSC to OBS hotkeys. | Hotkey-shim fallback reference |
| `0x29a-blink/VRChat-Movie-Night` | Local web app driving OBS media source, queues, MediaMTX/HLS, and VRChat movie-night playback. | Event/movie operator donor |
| `MissingNO123/OBS-Scripts-for-VRChat` | OBS scripts for VRChat loading scene switching and OSC action-menu OBS control. | OBS-native control donor |

## Dedupe Notes

Earlier waves cover captions, chatbox output, audience surfaces, and some OBS
bridges. This shortlist focuses on actual OBS control flows and keeps
historical mod approaches only as UX/caveat references.

## Code-Level Pass Targets

- VRChat parameter schema and OSC listeners.
- OBS WebSocket v4/v5 and Streamlabs adapters.
- OBS-native script APIs.
- Scene switching, recording, streaming, replay buffer, and microphone mute.
- Queue/player state, auto-advance, HLS health, and media-source control.
- Safety: auth, localhost assumptions, debounce, and status feedback.

## Expected Outputs

- Wave 249 landscape synthesis.
- Registry/family entry for VRChat OBS control bridges.
- Method catalog entry for bidirectional VRChat-to-OBS control.
- Follow-up backlog for safe control schemas and minimal adapters.
