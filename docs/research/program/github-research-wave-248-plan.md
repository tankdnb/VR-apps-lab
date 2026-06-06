# GitHub Research Wave 248 Plan

Date: 2026-06-06

Theme: VRChat OBS world metadata and browser source overlays.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Recent overlay work covered headset and runtime surfaces. This wave adds a
stream-facing micro-utility slice: tools that detect the current VRChat world
and expose it to OBS as a browser source, text file, or OBS script action.

## Search Families

- VRChat OBS overlays.
- VRChat world metadata stream overlays.
- VRChat log readers for OBS.
- Browser-source widgets for world/author/thumbnail data.
- Local state adapters: registry, VRCX, logs, and API polling.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `Natsumi-sama/VRC-OBS-Overlay` | Blazor localhost browser source using VRChat registry location context and metadata scraping. | Registry-to-browser-source donor |
| `philippgitpush/vrc-obs-world-overlay` | Electron/Vue overlay reading VRCX SQLite and serving polished configurable overlay routes. | VRCX-backed OBS overlay donor |
| `ktmage/vrc-world-credit-streaming-overlay` | TypeScript log watcher, VRChat API client, Zod validation, SSE, and style-selectable browser source. | Typed log-to-SSE donor |
| `Mahcks/vrc-world-teller` | Tiny API poller writing `world.txt` for OBS text sources. | Plain-text OBS micro-reference |
| `Elocin-Anagram/VRC_World_Location` | PowerShell VRChat log tailer plus HTML browser source reading generated text files. | Windows log-to-file reference |
| `nosjo/obs-vrchat-log-reader` | OBS Lua script that reads VRChat logs and switches scenes. | OBS-native log-reader overlap |

## Dedupe Notes

Existing waves already cover broader VRChat chatbox, captions, social overlays,
OBS audience surfaces, and overlay hosts. This wave keeps only projects that
add a new or clearer world-metadata ingress/output pattern.

## Code-Level Pass Targets

- State ingress: registry, VRCX SQLite, log files, API polling.
- Metadata lookup and caching.
- Local server or OBS-native script boundary.
- Browser-source, text-file, or scene-switch output.
- Privacy, credential, rate-limit, and brittle-log caveats.

## Expected Outputs

- Wave 248 landscape synthesis.
- Registry/family entry for VRChat OBS world metadata overlays.
- Method catalog entry for VRChat world metadata overlay pipelines.
- Follow-up backlog for safe state-source comparison.
