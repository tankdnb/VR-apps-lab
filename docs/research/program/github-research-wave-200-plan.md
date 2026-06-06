# GitHub Research Wave 200 Plan

- Date: `2026-06-06`
- Theme: `VRCOSC module packs, add-on modules, and plugin-distribution boundaries`
- Scope: official and third-party VRCOSC modules, stream-service modules,
  sensor modules, avatar-parameter compatibility shims, file/chatbox
  ingestion, and non-Twitch live-event bridges.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier waves studied `VRCOSC` as a companion-app and plugin host. Wave 200
looks one layer outward: how reusable modules are packaged, how event sources
become avatar parameters or chatbox variables, and where third-party module
packs draw safety, compatibility, and distribution boundaries.

## Search Families

- VRCOSC official module packs
- VRCOSC third-party add-on modules
- VRChat OSC live-event and chatbox bridges
- avatar parameter synchronization helpers
- sensor-to-avatar modules
- OpenVR/SteamVR device-to-avatar modules

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `VolcanicArts/VRCOSC-Modules` | Official module pack showing broad SDK usage and event/source boundaries | VRCOSC module host donor |
| `CrookedToe/CrookedToe-s-Modules` | Third-party OSCLeash and audio-reaction modules | Movement/audio module-pack variant |
| `Yeusepe/Yeusepes-Modules` | Large service-heavy module pack with Spotify, Discord, Shazam, QR, and VRChat API tooling | External-service module-pack reference |
| `FuviiPeshu/FuviiOSC` | SteamVR/VRChat body-device modules for haptics, paw tracking, and avatar changes | Device-to-avatar module pack |
| `WentTheFox/VRCOSC-BluetoothHeartrate` | BLE heart-rate VRCOSC module with runtime status and optional WebSocket side channel | Sensor module donor |
| `RichiCoder1/VrcOscLeash` | Avatar-config-driven OSCLeash compatibility module | Avatar-prefab compatibility donor |
| `03milo/File-Reading-Module` | Tiny file-to-chatbox micro-module | Micro-ingress reference |
| `TZFC/VRCOSC-Bilibili` | Bilibili live event bridge with async queues and parameter decay | Non-Twitch audience-event bridge |

## Dedupe Notes

- `VolcanicArts/VRCOSC` itself was already studied as a host; this wave studies
  module-pack boundaries and add-on ecosystems instead.
- Twitch, media, audio, haptics, physical-output, and sensor bridges were
  previously covered in adjacent families; included projects must add a
  VRCOSC-module or non-Twitch live-event lesson.
- Forks or thin modules are retained only when they add a compatibility,
  packaging, or micro-utility lesson.

## Code-Level Pass Targets

- Module registration, settings, persistence, and runtime-view patterns.
- Event-source adapters such as Twitch EventSub, Bilibili live rooms, media
  providers, speech commands, BLE advertisements, and file polling.
- Avatar parameter schemas, parameter caching, wildcard handlers, and reset
  behavior.
- SteamVR/OpenVR device access, haptic output, tracker-role mapping, and
  movement-control caveats.
- Safety boundaries around physical output, credential storage, local paths,
  and external-service APIs.

## Expected Outputs

- Wave 200 landscape synthesis.
- Registry and family placement for VRCOSC module packs.
- Methods around module-pack distribution and event-source-to-avatar queues.
