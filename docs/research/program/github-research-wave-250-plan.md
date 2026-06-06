# GitHub Research Wave 250 Plan

Date: 2026-06-06

Theme: VRChat virtual production, camera routing, and live stream pipelines.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

After OBS metadata and control bridges, this wave studies event-production
pipelines: camera rigs, VJ routing, RTMP/HLS conversion, camera-control pages,
stream-plugin surfaces, and avatar/browser-source output.

## Search Families

- VRChat virtual production rigs.
- VRChat VJ and TouchDesigner routing.
- OBS to VRChat video player streaming.
- VRChat camera OSC control pages.
- Browser-source stream plugin surfaces.
- Avatar/virtual-camera output for OBS.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `designio360/virtualproduction-vrchat` | Unity package reference for VRChat production stage with cameras, crane, overlays, lighting, and OBS capture. | In-world production kit reference |
| `valkyriedimension/TD2VRC` | TouchDesigner/OBS/VRChat VJ setup guide with routing screenshots and `.toe` file. | VJ routing workflow reference |
| `RemilRLs/StreamToVRC` | Dockerized RTMP to HLS conversion stack for OBS to VRChat world video players. | Stream transport donor |
| `dragokenlancer/VRC-Camera-control-webpage` | Passworded local web page controlling VRChat camera OSC pose/zoom and preview routing. | Camera-control POC |
| `reece-berens/vrc-stream-plugins` | Stream plugin shell with API helper and routeable output pages. | Browser-source plugin shell reference |
| `furukawa1020/VRcoverOBS` | Avatar/tracking/web-gateway/browser-source system with OBS setup docs. | Streamer-avatar output reference |

## Dedupe Notes

Earlier waves cover media playback, mixed reality capture, overlays, and
browser surfaces. This wave keeps only projects that add event-production or
stream-routing operator patterns.

## Code-Level Pass Targets

- Camera, crane, overlay, and lighting control UX.
- RTMP/HLS transport and segment settings.
- Camera OSC pose/zoom control and auth separation.
- Stream plugin route/output structure.
- Tracking/avatar browser-source and virtual-camera output paths.
- Latency, public port, and preview caveats.

## Expected Outputs

- Wave 250 landscape synthesis.
- Registry/family entry for VRChat virtual production and live stream
  pipelines.
- Method catalog entry for VR event production media pipelines.
- Follow-up backlog for HLS/MediaMTX/NGINX and camera-control comparisons.
