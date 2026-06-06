# GitHub Research Wave 226 Plan

Date: 2026-06-06

Theme: Browser media, depth-video projection, and gaze-viewer surfaces.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

The repository already has audio/video and WebXR media coverage, but browser
media viewers remain a rich source of reusable projection, control, and
accessibility ideas. This wave focuses on video players, depth video, SBS
stereo, TV-like channel shells, gaze-controlled desktop viewers, and projection
aware browser playback.

## Search Families

- Depth-video and 3D video viewers.
- WebXR/A-Frame video players.
- Projection presets, SBS stereo, and per-eye layers.
- Browser TV/live-stream shells.
- Gaze/head-cursor desktop or media viewers.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `amariichi/VideoDepthViewer3D` | FastAPI/Three/WebXR depth-video pipeline with backend inference, depth buffers, projection modes, RawXR rendering, and tuning controls. | Depth-video projection viewer |
| `mysterion/aframe-vr-player` | A-Frame/WebXR video player with local file support, projection presets, stereo layers, settings, timeline, subtitles, and recenter controls. | Browser VR video player |
| `mrgeralds/WebXR-TV-Demo` | A-Frame/DASH TV demo with channel menu, info bar, volume controls, secondary screen, and controller-only repositioning. | WebXR TV surface shell |
| `orgixmh/GazeDesk` | README-level Cardboard/MJPEG desktop viewer with head cursor, gaze dwell menu, SBS tuning, wake lock, and local storage. | Gaze desktop/media viewer |
| `ZhiqiaoGong/3D-Streaming-Demo` | Minimal WebRTC SBS video streamer that splits one video texture into left/right eye layers with debug and XR layouts. | SBS streaming demo |

## Dedupe Notes

Earlier waves covered panoramic players, stereo media, and WebRTC remote
rendering. This wave is bounded to browser-side media projection and control
surface patterns: depth meshes, projection presets, per-eye layers, TV menus,
gaze controls, and recovery/debug modes.

## Code-Level Pass Targets

- Source/transport separation: file, DASH, WHEP/WebRTC, MJPEG, or backend depth
  stream.
- Projection logic: flat, 180, 360, SBS, per-eye layers, and depth mesh.
- Player controls: timeline, subtitles, presets, channel menu, volume, recenter,
  and gaze/dwell.
- Runtime tuning: buffering, inflight requests, jitter, scaling, and reconnect.
- Caveats around heavy ML, hardcoded endpoints, browser APIs, and demo servers.

## Expected Outputs

- Wave 226 landscape synthesis.
- Registry/family entries for browser media projection viewers.
- Method catalog entry for projection-aware browser media viewers.
- Follow-up backlog for a media/depth projection matrix.
