# GitHub Research Wave 225 Backlog

Date: 2026-06-06

Theme: WebRTC/WebXR remote surfaces, camera streams, and spatial panels.

## Completed In This Wave

- Studied `binzume/webrtc-rdp` as a remote desktop stack with Ayame signaling,
  PIN pairing, persisted peer devices, media tracks, service requests,
  `controlEvent` data channels, file/control services, auth messages, and
  A-Frame WebXR client interactions.
- Studied `DiscreteTom/WebCaster` as a minimal screen-casting WebXR surface
  with WebRTC video textures, audio attachment, controller ray selection,
  grab/drop behavior, push/pull movement, and scale mode.
- Studied `hideki5123/stereo-webrtc-viewer` as a dual-WebRTC stereo camera
  viewer with left/right video textures assigned to WebXR views.
- Studied `rclarke87/WebXR-IPCam` as a WHEP/IP camera micro-reference with
  multiple A-Frame video panels, receive-only transceivers, and simple mute
  controls.
- Studied `JYJang476/VRMonitor` as a local QR-paired WebRTC monitor prototype
  with WebSocket signaling relay and Babylon video texture output.
- Added a reusable method entry for WebRTC surface ingress into XR panels.

## Follow-Up Queue

1. Build a WebRTC surface-ingress matrix across desktop, camera, stereo camera,
   local monitor, remote input, file transfer, and control channels.
2. Compare pairing approaches: PIN, QR, persisted device list, room ID, local
   LAN address, and WHEP endpoint.
3. Extract a neutral `surface source`, `signaling`, `media`, `control`,
   `security`, `spatial panel`, and `input feedback` schema.
4. Compare WebCaster controller manipulation with previous overlay-window and
   desktop-in-VR waves.
5. Revisit transport/security before treating any demo signaling flow as a
   donor for public utilities.

## Do Not Spend Time On Yet

- Do not run signaling servers, WebRTC demos, Electron apps, or PHP pages.
- Do not copy hardcoded ngrok, LAN, Ayame demo, or no-auth flows.
- Do not treat bundled `node_modules` or demo infrastructure as repo material.
