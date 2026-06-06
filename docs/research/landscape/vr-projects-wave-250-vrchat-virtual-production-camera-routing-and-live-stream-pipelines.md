# VR Projects Wave 250: VRChat Virtual Production, Camera Routing, and Live Stream Pipelines

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies VRChat event-production and media-routing references:
in-world camera rigs, TouchDesigner/OBS VJ routing, RTMP-to-HLS streaming for
VRChat video players, browser control of the VRChat camera OSC interface,
stream plugin surfaces, and avatar/browser-source output for OBS.

## Why It Matters For `VR-apps-lab`

Overlay research should also cover the operator environment around VR events.
These projects show how the useful boundary often spans Unity world prefabs,
desktop video tools, OBS, HLS servers, WebSocket/OSC control pages, and viewer
or audience-facing surfaces.

## Project Notes

### `designio360/virtualproduction-vrchat`

- Interesting idea:
  a VRChat world package can provide a virtual production stage with multiple
  cameras, a camera crane, controls, and overlay slides for live capture.
- Code donor value:
  the repository is mostly a README plus Unity package, so code evidence is
  limited. The README documents 10 cameras, camera crane controls, 12 overlay
  slides, keyboard and in-world button controls, lighting panel controls,
  fullscreen screen mapping, camera culling caveats, and OBS capture use.
- Product reference value:
  strong product reference for in-world production control surfaces and stage
  kits.
- What to inspect next:
  inspect package contents in a separate Unity-package analysis pass if the
  repository needs implementation-level evidence.
- Architecture pattern:
  VRChat world prefab -> in-world camera panel/crane/lights/overlays -> OBS
  capture.
- Reusable method:
  production worlds need camera state, shot selection, overlay slides, lighting
  controls, and stage reset semantics as first-class UX.
- Caveats:
  Unity package is not expanded in this wave, target Unity/VRChat SDK versions
  are old, and implementation details are mostly binary package evidence.

### `valkyriedimension/TD2VRC`

- Interesting idea:
  TouchDesigner visuals can be routed through OBS and into VRChat with
  concrete setup screenshots and an example `.toe` file.
- Code donor value:
  source is a guide plus images and `TD2VRC Rev1.toe`, so code donor value is
  low. The README and assets document stream key, RTSP, Spout capture, OBS
  media source capture, window capture, and stream-link input setup.
- Product reference value:
  useful workflow reference for live VJing and networked visual production in
  VRChat.
- What to inspect next:
  convert the guide into a transport checklist covering Spout, OBS, RTSP, and
  VRChat video player constraints.
- Architecture pattern:
  TouchDesigner output -> Spout/window/OBS capture -> network stream -> VRChat
  screen.
- Reusable method:
  visual-production notes should capture both media transport and operator
  screenshots, not only code.
- Caveats:
  mostly documentation/assets, no clean app code, and production reliability
  depends on external tools.

### `RemilRLs/StreamToVRC`

- Interesting idea:
  a minimal Docker Compose stack can convert OBS RTMP output into HLS segments
  consumable by VRChat video players.
- Code donor value:
  `docker-compose.yml` exposes RTMP and HTTP ports with `alfg/nginx-rtmp`.
  `nginx/nginx.conf.template` defines RTMP ingest, multiple ffmpeg-transcoded
  bitrate variants, HLS fragment settings, nested playlists, `Cache-Control:
  no-cache`, CORS headers, and `/hls` plus `/live` HTTP routes.
- Product reference value:
  strong micro-donor for stream-to-world-video-player infrastructure.
- What to inspect next:
  compare NGINX RTMP/HLS against MediaMTX from Wave 249.
- Architecture pattern:
  OBS RTMP -> NGINX RTMP application -> ffmpeg variants -> HLS HTTP -> VRChat
  world video player.
- Reusable method:
  document ingest port, public playback port, HLS latency, and firewall
  boundary separately.
- Caveats:
  sample uses broad open ports, ffmpeg command is fixed, and live streaming
  security is explicitly left to the operator.

### `dragokenlancer/VRC-Camera-control-webpage`

- Interesting idea:
  a local web page can control the VRChat beta camera through OSC and display
  preview sources from Spout, stream URL, or OBS virtual camera workflows.
- Code donor value:
  `server.js` implements password/session handling, static serving, OSC UDP
  send/receive, VRChat camera pose and zoom address mapping, server-side
  authoritative camera state, manual OSC message parsing, and config editing.
  `public/app.js` separates authenticated controls from public viewing and
  disables controls for unauthenticated viewers. `spout-bridge.js` is a bridge
  boundary placeholder for preview routing.
- Product reference value:
  useful POC for remote director controls around VRChat's camera OSC surface.
- What to inspect next:
  compare camera-control safety against operator permission and public-viewing
  models.
- Architecture pattern:
  browser control surface -> local auth/session -> OSC camera commands ->
  preview/video output path.
- Reusable method:
  separate public viewing from authenticated camera control even in prototypes.
- Caveats:
  POC status, default password creation, hand-rolled OSC parser, and VRChat
  beta camera address stability risk.

### `reece-berens/vrc-stream-plugins`

- Interesting idea:
  stream overlays can be packaged as web plugins backed by a small auth/API
  service rather than one monolithic overlay.
- Code donor value:
  the repo splits `tm-auth-api-express` from a Next app under
  `vrc-stream-plugins`. Pages under `app/plugins/*` expose individual plugin
  outputs and configuration surfaces, while helper hooks wrap external API
  access and typed event/score structures.
- Product reference value:
  useful adjacent reference for stream plugin modularity and browser-source
  plugin routes.
- What to inspect next:
  inspect whether any plugin is VRChat-specific beyond stream-context naming.
- Architecture pattern:
  small API/auth helper -> Next plugin pages -> OBS browser-source outputs.
- Reusable method:
  treat stream overlays as independent routeable plugins with output pages.
- Caveats:
  appears event/stream oriented rather than deeply VR-specific, and donor value
  is mostly plugin-shell structure.

### `furukawa1020/VRcoverOBS`

- Interesting idea:
  a streamer-facing avatar tool can combine AI/body tracking, a WebSocket
  gateway, a browser-rendered avatar, and OBS setup docs for virtual camera or
  browser-source output.
- Code donor value:
  `apps/gateway/index.js` bridges OpenSeeFace UDP and MediaPipe OSC into
  WebSocket tracking data. `apps/web/src/main.ts` initializes avatar,
  tracking, audio, and UI modules. `TrackingClient.ts` reconnects to the
  gateway and emits typed tracking events. `CanvasStreamer.ts` captures a
  canvas to JPEG blobs at reduced resolution/FPS over WebSocket. The OBS guide
  documents browser-source transparency and virtual-camera setup.
- Product reference value:
  useful adjacent reference for avatar-as-stream-surface tooling.
- What to inspect next:
  compare with prior VRM/avatar waves before promoting it as a VR-specific
  donor.
- Architecture pattern:
  tracking processes -> WebSocket gateway -> browser avatar runtime -> OBS
  browser source or virtual camera.
- Reusable method:
  split tracking ingest, avatar rendering, audio/AI modules, and OBS output.
- Caveats:
  broad streamer-avatar scope, model/tool dependencies, and not primarily a VR
  runtime utility.

## Reusable Pattern Extraction

- Pattern candidate:
  VR event production media pipeline.
- Problem solved:
  VR events need camera control, visual inputs, stream routing, overlay output,
  and public playback surfaces that cross world content and desktop tools.
- Reusable core:
  production source, operator control surface, media ingest, transcode/segment
  layer, playback URL, viewer surface, preview path, and security/latency
  caveats.
- Source evidence:
  `virtualproduction-vrchat`, `TD2VRC`, `StreamToVRC`,
  `VRC-Camera-control-webpage`, `vrc-stream-plugins`, and `VRcoverOBS`.
- Abstraction boundary:
  separate in-world camera/stage controls from desktop media routing, and
  separate media routing from browser-source overlays.
- What not to copy:
  old Unity package assumptions, public streaming ports without access policy,
  beta camera OSC addresses as stable API, one-off VJ screenshots as code
  evidence, or broad avatar/AI stacks as core VR utility architecture.
- Method catalog action:
  add a method entry for VR event production media pipelines.

## Follow-Up Gaps

- Compare NGINX RTMP/HLS and MediaMTX for VRChat video player use.
- Build an operator checklist for camera control, preview, stream URL, HLS
  latency, public port exposure, and OBS browser-source fallbacks.
- Decide when virtual-production packages should become reuse plans versus
  product references only.
