# GitHub Research Wave 201 Plan

- Date: `2026-06-06`
- Theme: `Networked-AFrame adapters, persistence, media, and Unity-client variants`
- Scope: Networked-AFrame adapters, room UI shells, avatar validation,
  persistence helpers, shared media state, spatial audio media streams, and
  Unity clients that speak NAF/EasyRTC-compatible protocols.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Earlier WebXR waves studied Networked-AFrame and broader social-room
substrates. Wave 201 studies its periphery: alternate adapters, media stream
bridges, persistence helpers, and cross-runtime client variants that show how
shared-room infrastructure can become a reusable utility substrate.

## Search Families

- Networked-AFrame signaling adapters
- WebRTC/SFU room backends
- WebXR room avatar and presence shells
- shared entity persistence helpers
- synchronized media components
- spatial audio stream bridges
- Unity clients for browser room protocols

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `networked-aframe/naf-firebase-adapter` | Firebase realtime DB adapter plus WebRTC data channels | Adapter contract donor |
| `mozilla/naf-janus-adapter` | Janus SFU adapter with audio/video and reconnect behavior | Robust media adapter donor |
| `networked-aframe/naf-valid-avatars` | Full NAF room shell with avatars, presence, chat, mic, and media buttons | Social room UX donor |
| `ttravaglini/networked-aframe-unity-client` | Unity client speaking NAF/EasyRTC concepts | Cross-runtime client donor |
| `chenzlabs/networked-aframe-synced-video-example` | Minimal synced singleton video component | Shared media micro-pattern |
| `martintribo/naf-persist` | PouchDB-backed entity persistence system | Persistence donor |
| `martintribo/naf-entity-saver` | Leave-time ownership/persistence hack | Ownership caveat reference |
| `AudioGroupCologne/networked-resonance-audio` | Adapter media stream into Resonance/Three positional audio | Spatial audio bridge donor |

## Dedupe Notes

- `networked-aframe/networked-aframe` itself was already partially studied;
  this wave studies adjacent adapter and helper repos.
- Browser room frameworks and WebRTC scene shells have prior waves; included
  repos must expose adapter, persistence, media, or cross-runtime lessons.
- Thin examples are retained only if they reveal a reusable shared-room method.

## Code-Level Pass Targets

- Adapter lifecycle, signaling, guaranteed/unreliable transport split, and
  peer/SFU responsibilities.
- Media stream boundaries for audio/video, screen/camera sharing, and spatial
  audio.
- Presence, avatar selection, username, chat, and room entry UX.
- Entity ownership, network ids, schema mappings, persistence, and leave-time
  handoff.
- Cross-runtime NAF concepts ported into Unity.

## Expected Outputs

- Wave 201 landscape synthesis.
- Registry/family placement for Networked-AFrame periphery.
- Methods around adapter contracts and shared-room persistence/ownership.
