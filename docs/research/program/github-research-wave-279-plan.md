# GitHub Research Wave 279 Plan - Remote, Cloud, WebRTC VR Streaming, and Live SDK Surfaces

## Goal

Study remote/cloud VR streaming projects as reusable references for sensor
uplink, video downlink, Unity WebRTC, signaling, Quest receiver textures,
streaming SDK setup, and cloud session lifecycle control.

## Research Questions

- How do projects connect headset/phone input to remote rendering or live
  camera output?
- Which signaling, WebRTC, UDP/TCP, WHIP, or cloud-stage boundaries appear?
- How are FPS, bitrate, resolution, frame queues, and kill-switch behavior
  configured?
- Which repos are code donors versus source-light streaming product sketches?

## Shortlist

- `PierfrancescoSoffritti/RemoteVR_UnityServer`
- `PierfrancescoSoffritti/RemoteVR_AndroidClient`
- `TheAnonymousMan/WebRTC-VR-Server`
- `GitEducaverse2024/com.educa360.live`
- `shinyoshiaki/quest-view`
- `jlin3/substream-sdk`
- `kasimmj/vrcollab`
- `jakubtom/UnityRenderStreaming_StereoWebcam`

## Required Checks

- Deduplicate against prior WebRTC, surface-ingress, media streaming, Quest
  helper, and event-production waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory fields and reusable pattern bridge fields.
- Keep privacy, auth, TLS, and external-cloud caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 279.
- Registry/family entries for remote/cloud/WebRTC VR streaming surfaces.
- Method catalog entry for remote VR streaming lifecycle boundaries.
- Follow-up matrix around sensor uplink, video tracks, signaling, frame queues,
  SDK setup, stage pools, recording, and privacy gates.
