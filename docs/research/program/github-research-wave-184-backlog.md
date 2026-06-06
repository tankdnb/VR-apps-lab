# GitHub Research Wave 184 Backlog

- Date: `2026-06-06`
- Theme: `Low-latency XR video, point-cloud, and browser stream surfaces`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for Quest/OpenXR low-latency stereo streaming and
  WebRTC examples.
- `Done` Search GitHub for point-cloud streaming, MediaProjection senders, and
  native browser-video surfaces.
- `Done` Dedupe against `project-registry.md`, `project-families.md`, and recent
  wave documents.
- `Done` Exclude already studied `XRFrameTools`, `xrtlab/clovr`, `vrperfkit`,
  and ALVR/WiVRn-line streaming repos.

## Source Sync

- `Done` Confirm `XR-Low-Latency-Stereo-Streaming` in local cache.
- `Done` Confirm `spatial-video` in local cache.
- `Done` Confirm `PointCast3D` in local cache.
- `Done` Confirm `FFMPEG-VRQ` cloned as an empty repository.
- `Done` Confirm `relavr` in local cache.
- `Done` Confirm `SpatialVideoBrowser` in local cache.

## Code Reading

- `Done` Inspect WebRTC signaling, Unity receiver, and texture handoff in
  `XR-Low-Latency-Stereo-Streaming`.
- `Done` Inspect Meta Spatial SDK panel registration and LiveKit track binding
  in `spatial-video`.
- `Done` Inspect RealSense sender packet layout and Unity point-cloud mesh
  receiver in `PointCast3D`.
- `Done` Inspect modular MediaProjection, codec policy, WebRTC signaling, and
  adaptive profile code in `relavr`.
- `Done` Inspect Unity/XRI/WebView project shape and README architecture in
  `SpatialVideoBrowser`.

## Integration

- `Done` Create Wave 184 landscape document.
- `Done` Update registry and project-family placement.
- `Done` Add reusable methods for stream surfaces and sender state machines.
- `Next` Compare WebRTC, LiveKit, UDP point clouds, and WebView surfaces as a
  generic `external surface ingress to XR display` matrix.
