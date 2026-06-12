# GitHub Research Wave 279 Backlog - Remote, Cloud, WebRTC VR Streaming, and Live SDK Surfaces

## Executed Scope

- Searched and deduplicated remote VR, WebRTC, cloud streaming, and live SDK
  projects.
- Froze an eight-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted legacy LAN remote VR protocols, Android gyro/touch clients,
  Unity-hosted WebRTC signaling, Quest video receiver textures, streaming SDK
  setup wizards, cloud stage allocation, WHIP endpoints, and source-light
  collaboration/streaming references.

## Studied Projects

- `PierfrancescoSoffritti/RemoteVR_UnityServer`
- `PierfrancescoSoffritti/RemoteVR_AndroidClient`
- `TheAnonymousMan/WebRTC-VR-Server`
- `GitEducaverse2024/com.educa360.live`
- `shinyoshiaki/quest-view`
- `jlin3/substream-sdk`
- `kasimmj/vrcollab`
- `jakubtom/UnityRenderStreaming_StereoWebcam`

## Backlog Findings

- Build a streaming matrix across capture source, input uplink, video track,
  signaling, peer/session lifecycle, backend abstraction, frame queue, pairing,
  kill-switch, and cleanup.
- Deepen `GitEducaverse2024/com.educa360.live` as the strongest SDK/setup
  donor.
- Deepen `TheAnonymousMan/WebRTC-VR-Server` as the compact Unity-hosted WebRTC
  donor.
- Keep `kasimmj/vrcollab` and
  `jakubtom/UnityRenderStreaming_StereoWebcam` as source-light references until
  source evidence improves.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a remote/cloud VR streaming method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
