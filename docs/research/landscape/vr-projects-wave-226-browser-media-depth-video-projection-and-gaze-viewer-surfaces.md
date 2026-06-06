# VR Projects Wave 226: Browser Media, Depth-Video Projection, and Gaze-Viewer Surfaces

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-226-plan.md`
- `docs/research/program/github-research-wave-226-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

Media viewers are deceptively important VR utilities. A good player has to
separate media source, transport, projection, player controls, spatial layout,
debug view, persistence, and recovery. This wave studies browser-based media
projects that cover depth video, projection presets, stereo layers, TV
navigation, gaze-controlled desktop viewing, and SBS streaming.

## Project Findings

### `amariichi/VideoDepthViewer3D`

- Interesting idea: video can be transformed into an interactive depth surface
  by pairing backend depth inference with a WebXR frontend that adapts buffer
  lead, inflight requests, and projection mode.
- Code donor value: high as a latency-aware media architecture reference.
  `backend/main.py` exposes FastAPI session/stream routes and frontend log
  capture. The backend design described in source and docs uses PyAV decoding,
  inference workers, queueing, binary WebSocket depth maps, and cache cleanup.
  `depthSyncController.ts` adjusts max inflight requests from worker capacity
  and computes depth lead from queue/decode/inference/safety timing. Projection
  helpers separate pinhole and relief projection controls.
- Product reference value: high for depth-video viewers, 3D media tools, and
  performance-tuned stream surfaces.
- Architecture pattern: backend media/depth pipeline plus frontend buffer
  controller plus projection renderer plus RawXR path.
- Reusable method: make media latency and processing capacity visible to the
  frontend instead of guessing fixed buffering values.
- Constraints and caveats: heavy ML backend, model/download/runtime
  requirements, local data/cache management, and not a lightweight utility.
- What to inspect next: mesh reconstruction, missing-frame recovery, report
  logs, and how user projection controls map to depth artifacts.
- Why it matters for `VR-apps-lab`: it shows a serious pattern for
  performance-aware 3D media beyond ordinary video playback.

#### Reusable Pattern Extraction

- Pattern candidate: projection-aware browser media viewer with synchronized
  source, projection, and control layers.
- Problem solved: immersive media tools become fragile when source transport,
  projection geometry, UI controls, stereo/depth state, performance, and
  recovery are fused into one player script.
- Reusable core: separate media source, transport adapter, projection transform,
  panel or mesh renderer, player/control shell, persistence, debug/XR layouts,
  latency/recovery policy, and accessibility controls.
- Source evidence: VideoDepthViewer3D backend/frontend, aframe-vr-player
  stereo/settings/presets, WebXR-TV-Demo livestream and move-app components,
  GazeDesk README design, and 3D-Streaming-Demo receiver/publisher.
- Abstraction boundary: media source, transport, projection, controls,
  spatial placement, persistence, recovery, and caveats should remain separate.
- What not to copy: heavy ML stack unless required, hardcoded media/proxy URLs,
  demo signaling, old vendored A-Frame/player stacks, or README-only features
  as implementation evidence.
- Method catalog action: create Method 671.

### `mysterion/aframe-vr-player`

- Interesting idea: a browser VR video player can be local-first and still
  support projection presets, stereo eye routing, settings persistence,
  subtitles, timeline controls, camera adjustment, and recenter behavior.
- Code donor value: high for player-shell structure. `Stereo.js` uses object
  layers to route left, right, or both-eye visibility. Settings components load,
  migrate, and persist options such as resume behavior, preset, eye, view angle,
  UI angle, and cursor type. Component files cover file input, timeline,
  subtitles, stereo camera, camera adjustment, recentering, seek, volume,
  settings, and hide-controls behavior. Preset modules cover flat, 180, 360,
  fisheye, SBS, and top/bottom variants.
- Product reference value: high for local video tools and projection-aware
  browser media surfaces.
- Architecture pattern: A-Frame component player plus projection presets plus
  eye-layer masking plus persistent settings.
- Reusable method: keep projection presets declarative and make stereo eye
  visibility an explicit layer concern.
- Constraints and caveats: browser playback limits, vendored A-Frame/assets,
  and player-specific assumptions.
- What to inspect next: subtitle parser, file input UX, preset geometry, and
  recenter/timeline event flow.
- Why it matters for `VR-apps-lab`: it provides a compact map of player
  controls that future media panels should not forget.

### `mrgeralds/WebXR-TV-Demo`

- Interesting idea: live TV in XR can be modeled as a spatial app shell with
  channel metadata, channel menu, info bar, volume controls, secondary screen,
  and controller-only repositioning.
- Code donor value: medium to high. `livestream.js` defines A-Frame components
  for video player, secondary player, channel up/down, channel selection menu,
  send-to-secondary, and hide-secondary behavior. It uses dash.js playback,
  service-list parsing, channel metadata updates, and raycastable menu classes.
  `moveApp.js` defines a VR move plane that temporarily exposes a placement
  target and applies position/rotation back to the whole app placeholder.
- Product reference value: high for media dashboards, live-event surfaces, and
  movable app panels.
- Architecture pattern: media engine plus metadata/menu shell plus secondary
  screen plus repositionable spatial frame.
- Reusable method: make the whole media app movable as one object instead of
  moving each control separately.
- Constraints and caveats: CORS/proxy assumptions, hardcoded demo UI, A-Frame
  dependencies, and not a complete TV product.
- What to inspect next: channel service schema, secondary-screen lifecycle, and
  controller-only navigation ergonomics.
- Why it matters for `VR-apps-lab`: it connects media playback with a practical
  overlay/window placement pattern.

### `orgixmh/GazeDesk`

- Interesting idea: a Cardboard-style desktop/media viewer can use head cursor,
  gaze dwell, haptics, SBS tuning, pan/zoom/IPD controls, wake lock, and local
  persistence to stay usable without full controllers.
- Code donor value: low because the current checkout is README-level, but the
  product pattern is useful.
- Product reference value: medium to high for accessibility, phone/Cardboard,
  headsetless, and fallback-control workflows.
- Architecture pattern: MJPEG desktop source plus HTTPS proxy plus WebXR or
  DeviceOrientation head cursor plus gaze menu.
- Reusable method: design a controller-free control surface with explicit dwell
  timing, recenter countdown, haptic feedback, and persistence.
- Constraints and caveats: source files were not present in the inspected
  checkout, README says some pieces are planned, and MJPEG/browser constraints
  are significant.
- What to inspect next: viewer implementation if source appears, dwell timing,
  local-storage schema, and WebRTC/H.264 roadmap.
- Why it matters for `VR-apps-lab`: it keeps accessibility and fallback input
  visible inside media/viewer research.

### `ZhiqiaoGong/3D-Streaming-Demo`

- Interesting idea: one SBS video stream can be split into left/right eye
  meshes by texture repeat/offset and layer masking, with separate debug and XR
  layouts.
- Code donor value: medium. `receiver/main.js` creates Three.js/WebXR state,
  Socket.IO signaling, WebRTC peer lifecycle, video texture split into left and
  right halves, per-eye layers, debug side-by-side layout, XR overlap layout,
  visible-size scaling, and reconnect behavior. `publisher/main.js` captures a
  local SBS video element with `captureStream`, publishes the track, and
  re-offers on receiver rejoin or network recovery.
- Product reference value: medium for stereo-video debugging and SBS stream
  viewers.
- Architecture pattern: publisher video capture plus WebRTC signaling plus
  receiver-side SBS texture split plus XR/debug layouts.
- Reusable method: keep debug and immersive layouts separate so stereo problems
  can be inspected outside the headset.
- Constraints and caveats: demo server, no auth, local file-only publisher, and
  playback restart behavior on reconnect.
- What to inspect next: server signaling, sync drift, aspect ratio handling,
  and better recovery without restarting playback.
- Why it matters for `VR-apps-lab`: it is a small but clear donor for SBS
  texture splitting and per-eye debug workflows.

## Cross-Project Synthesis

Projection-aware media tools should name:

- source: file, DASH, WebRTC, WHEP, MJPEG, or backend depth stream;
- transport: local file, dash.js, WebSocket, Socket.IO, WebRTC, or HTTPS proxy;
- projection: flat, 180, 360, SBS, per-eye layers, relief, pinhole, or depth
  mesh;
- controls: timeline, subtitles, channel menu, volume, recenter, gaze menu, or
  placement plane;
- persistence: settings, presets, local storage, or session state;
- recovery: reconnect, missing frames, debug layout, or performance tuning;
- caveats: browser support, hardcoded endpoints, heavy models, or source-light
  projects.

For `VR-apps-lab`, this wave strengthens immersive media, browser viewer,
projection, accessibility, and spatial panel product branches.
