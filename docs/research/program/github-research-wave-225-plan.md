# GitHub Research Wave 225 Plan

Date: 2026-06-06

Theme: WebRTC/WebXR remote surfaces, camera streams, and spatial panels.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Remote surfaces are a recurring VR utility need: desktop windows, camera feeds,
file/control channels, stereo views, and lightweight local monitors. This wave
looks at WebRTC and WebXR projects that bring external media or desktop state
into XR panels, with attention to pairing, signaling, control data, texture
mapping, and spatial manipulation.

## Search Families

- WebRTC remote desktop in WebXR.
- Browser screen casting to XR panels.
- Stereo camera feeds and per-eye texture routing.
- WHEP/IP camera ingress into A-Frame/WebXR scenes.
- Local QR/WebSocket signaling for VR monitors.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `binzume/webrtc-rdp` | WebRTC remote desktop with WebXR client, pairing, persisted devices, media stream, data channels, file/control services, and spatial input. | WebRTC remote desktop surface |
| `DiscreteTom/WebCaster` | Minimal peerjs/three.js screen caster with WebXR screen panels and controller grab/move/scale interactions. | WebXR screen casting microtool |
| `hideki5123/stereo-webrtc-viewer` | Sora WebRTC stereo viewer with separate left/right connections and per-eye WebXR rendering. | Stereo camera/WebRTC viewer |
| `rclarke87/WebXR-IPCam` | Tiny WHEP/IP camera viewer with multiple A-Frame video panels and mute controls. | IP camera surface microtool |
| `JYJang476/VRMonitor` | Local WebRTC monitor prototype with QR pairing, WebSocket signaling, PHP pages, and Babylon video texture output. | Local VR monitor reference |

## Dedupe Notes

Earlier waves studied broader WebRTC remote rendering and browser streaming.
This wave is narrower: remote surfaces as panels inside XR, with specific
interest in media/control separation, spatial manipulation, pairing, and
camera/screen ingress.

## Code-Level Pass Targets

- Signaling and pairing flow.
- Media stream versus data/control channel split.
- WebXR panel creation and video-texture mapping.
- Controller input, drag, scale, and window manipulation.
- Stereo/per-eye texture assignment.
- Security, auth, hardcoded URL, and demo-server caveats.

## Expected Outputs

- Wave 225 landscape synthesis.
- Registry/family entries for WebRTC remote surfaces.
- Method catalog entry for media/data/control split into XR panels.
- Follow-up backlog for a WebRTC surface-ingress matrix.
