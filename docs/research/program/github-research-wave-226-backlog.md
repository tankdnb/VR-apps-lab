# GitHub Research Wave 226 Backlog

Date: 2026-06-06

Theme: Browser media, depth-video projection, and gaze-viewer surfaces.

## Completed In This Wave

- Studied `amariichi/VideoDepthViewer3D` as a heavy but valuable depth-video
  pipeline with FastAPI/PyAV/PyTorch backend, depth inference workers, priority
  queues, WebSocket binary depth maps, frontend depth synchronization, relief
  versus pinhole projection, RawXR rendering, and performance knobs.
- Studied `mysterion/aframe-vr-player` as a local-first A-Frame VR video
  player with file picker, projection presets, stereo layer masks, persistent
  settings, subtitles, timeline, camera adjustment, and recenter controls.
- Studied `mrgeralds/WebXR-TV-Demo` as a WebXR TV shell with DASH playback,
  channel metadata, info bar, paged channel menu, volume controls, secondary
  screen, and VR controller repositioning of the app plane.
- Studied `orgixmh/GazeDesk` as a README-level Cardboard/MJPEG desktop viewer
  product reference with head cursor, gaze dwell actions, SBS/Flat tuning,
  pan/zoom/IPD, wake lock, and local persistence.
- Studied `ZhiqiaoGong/3D-Streaming-Demo` as a minimal WebRTC SBS streaming
  demo with publisher `captureStream`, receiver texture split, per-eye layers,
  debug/XR layout modes, and reconnect behavior.
- Added a reusable method entry for projection-aware browser media viewers.

## Follow-Up Queue

1. Build a browser media projection matrix across flat, 180, 360, SBS, per-eye,
   depth mesh, TV, gaze desktop, and local-player modes.
2. Compare depth buffering and latency knobs with earlier low-latency WebRTC
   and video-streaming waves.
3. Extract a neutral player surface schema: source, transport, projection,
   controls, persistence, recovery, accessibility, and caveats.
4. Compare A-Frame layer masking, Three.js layer masking, and raw XR per-eye
   rendering for stereo media.
5. Revisit gaze/dwell controls as an accessibility branch rather than a media
   feature only.

## Do Not Spend Time On Yet

- Do not run ML models, FastAPI servers, WebRTC signaling, or browser demos.
- Do not treat hardcoded CORS/proxy/media URLs as reusable configuration.
- Do not import vendored media/player stacks into `VR-apps-lab`.
