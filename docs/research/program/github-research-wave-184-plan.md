# GitHub Research Wave 184 Plan

- Date: `2026-06-06`
- Theme: `Low-latency XR video, point-cloud, and browser stream surfaces`
- Scope: Quest/OpenXR stereo streaming, WebRTC-to-Unity texture receivers,
  LiveKit stereo panels, UDP point-cloud streams, MediaProjection senders, and
  native WebView video surfaces.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Many future VR utilities need to display or forward live external surfaces
before they become full overlays: robot camera feeds, desktop or Quest captures,
browser video, stereo panels, point clouds, or remote diagnostics. This wave
studies the boundary between transport, decode, texture/panel presentation, and
runtime permissions.

## Search Families

- Quest/OpenXR low-latency stereo video
- WebRTC sender/receiver examples for XR
- LiveKit spatial video viewer samples
- UDP point-cloud streamers
- MediaProjection and WebRTC sender shells
- native web-video-to-world-surface browsers

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `bugman-007/XR-Low-Latency-Stereo-Streaming` | Minimal sender/signaling/Unity receiver boundary for WebRTC video surfaces | WebRTC-to-XR texture receiver |
| `livekit-examples/spatial-video` | Meta Spatial SDK stereo panel connected to LiveKit room tracks | Spatial stereo streaming panel |
| `Cont-ai-ner/PointCast3D` | RealSense-to-Quest UDP point-cloud sender and Unity mesh receiver | Point-cloud streaming surface |
| `studio4evr/FFMPEG-VRQ` | Empty repository found during search; retained only as exclusion note | Empty source-light streaming candidate |
| `N78Wy/relavr` | Modular Quest MediaProjection/WebRTC sender with codec policy and state model | Quest-to-web sender shell |
| `ranvuemor/SpatialVideoBrowser` | Native Unity/Quest WebView video surface for browser streams | Browser video surface |

## Dedupe Notes

- `XRFrameTools`, `xrtlab/clovr`, and `fholger/vrperfkit` were found again but
  are already studied, so they were excluded from the new shortlist.
- This wave does not repeat ALVR/WiVRn streaming architecture. It focuses on
  small display-surface and media-ingress examples.
- `studio4evr/FFMPEG-VRQ` cloned as an empty repository and is documented only
  as an empty candidate.

## Code-Level Pass Targets

- WebRTC signaling boundaries and ICE/SDP message shape;
- decoded texture or renderer handoff in Unity/Meta Spatial SDK;
- stereo panel sizing and left-right projection assumptions;
- UDP chunking, reassembly, point payload shape, and mesh update cost;
- MediaProjection permission and foreground-service ownership;
- codec/fps/bitrate/resolution downgrade policies;
- browser/WebView-to-world-surface composition and dependency caveats.

## Expected Outputs

- Wave 184 landscape synthesis.
- Registry/family placement for live XR stream surfaces.
- Methods around WebRTC-to-texture receivers, stereo panel contracts, UDP
  point-cloud payloads, and Quest MediaProjection sender state machines.
