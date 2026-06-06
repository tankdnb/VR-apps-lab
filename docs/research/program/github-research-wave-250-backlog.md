# GitHub Research Wave 250 Backlog

Date: 2026-06-06

Theme: VRChat virtual production, camera routing, and live stream pipelines.

## Completed In This Wave

- Studied `designio360/virtualproduction-vrchat` as a source-light Unity
  package reference for VRChat production stages with 10 cameras, a camera
  crane, 12 overlay slides, lighting controls, fullscreen screen mapping,
  in-world buttons, keyboard controls, and OBS capture.
- Studied `valkyriedimension/TD2VRC` as a TouchDesigner-to-VRChat VJ routing
  workflow using OBS, Spout/window capture, RTSP, stream links, and screenshot
  documentation.
- Studied `RemilRLs/StreamToVRC` as a compact Docker/NGINX RTMP-to-HLS donor
  with multi-bitrate ffmpeg variants, HLS fragment settings, CORS/no-cache
  headers, and VRChat video-player URL framing.
- Studied `dragokenlancer/VRC-Camera-control-webpage` as a POC local web
  camera controller with password sessions, public-viewing separation,
  hand-rolled OSC parsing, camera pose/zoom address mapping, and preview
  routing intent.
- Studied `reece-berens/vrc-stream-plugins` as an adjacent browser-source
  plugin shell with a small auth/API service, Next routes, plugin output
  pages, and typed event-score helpers.
- Studied `furukawa1020/VRcoverOBS` as an adjacent avatar/OBS output system
  with OpenSeeFace/MediaPipe-to-WebSocket gateway, browser avatar runtime,
  tracking reconnect logic, canvas-to-WebSocket streaming, and OBS browser
  source/virtual camera docs.
- Added a reusable method entry for VR event production media pipelines.

## Follow-Up Queue

1. Compare NGINX RTMP/HLS with MediaMTX for VRChat video player streaming.
2. Extract a production operator checklist: camera controls, preview, stream
   URL, HLS latency, public ports, auth, and OBS source setup.
3. Decide which source-light Unity packages warrant package extraction passes.

## Do Not Spend Time On Yet

- Do not run Unity, TouchDesigner, OBS, Docker, NGINX, MediaMTX, gateways, or
  tracking services.
- Do not promote package-only repos to code donors without expanded source.
- Do not treat public stream ports or beta camera OSC addresses as safe
  defaults.
