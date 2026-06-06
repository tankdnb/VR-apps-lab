# GitHub Research Wave 212 Plan

Date: 2026-06-06

Theme: shared-room WebXR and A-Frame presence, media, and peer-adapter
microprototypes.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Browser-native shared-room prototypes are useful because they expose the small
pieces that make a VR utility feel social or remotely controllable: room join,
pose broadcast, remote avatars, media streams, interpolation, chat, and
transport cleanup.

Wave 212 studies small WebXR/A-Frame multiplayer nodes to extract reusable
presence and media-adapter patterns rather than treating each repo as a full
product candidate.

## Search Families

- WebXR shared-room prototypes.
- A-Frame multiuser scene adapters.
- Socket.IO and WebRTC signaling.
- Deepstream or peer-network presence stores.
- Positional audio, media-stream, and remote avatar surfaces.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `jure/wooglies` | React/Three/WebXR shared-room prototype with Socket.IO room state, SnapshotInterpolation, simple-peer media, and positional audio. | Browser WebXR room with P2P audio |
| `danbuckland/aframe-socket-io` | A-Frame Socket.IO/WebRTC multiplayer prototype with separate game, media, and signaling layers. | A-Frame WebRTC room adapter |
| `Srushtika/realtime-multiplayer-webvr-aframe` | Tiny Deepstream/A-Frame presence-record example with generated avatars and periodic camera updates. | Minimal presence-record avatar sync |
| `RangerMauve/aframe-dat-peers-networking` | Beaker/datPeers A-Frame networking adapter with room/user messages and remote template entities. | Alternate peer-substrate adapter |

## Dedupe Notes

The wave intentionally avoids already deepened Networked-AFrame and WebXR
room projects. These repositories were selected because they show thinner
transport or media boundaries that were not yet represented in the registry as
source-level patterns.

## Code-Level Pass Targets

- Room join, leave, and user identity flow.
- Pose schema and update cadence.
- Interpolation or changed-state sending.
- Remote entity/avatar creation and cleanup.
- WebRTC, MediaStream, or positional-audio binding.
- Transport abstraction and adapter boundaries.
- Old dependency and obsolete platform caveats.

## Expected Outputs

- Wave 212 landscape synthesis.
- Registry and family placement for shared-room WebXR/A-Frame microprototypes.
- Method catalog entry for browser XR shared-room presence, pose, and media
  adapters.
- Follow-up backlog for comparing these small adapters with Networked-AFrame
  and modern React/Three XR room shells.
