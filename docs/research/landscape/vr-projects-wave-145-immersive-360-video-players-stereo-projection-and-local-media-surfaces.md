# VR Projects Wave 145: Immersive 360 Video Players, Stereo Projection, and Local Media Surfaces

- Date: `2026-06-05`
- Goal: study projection-aware immersive video players as reusable utility
  references for media playback, diagnostic viewers, and VR surface design.

## Why this wave exists

VR media players are useful donors because they force concrete answers to hard
utility questions: how to expose projection modes, how to load local media, how
to explain stereo layouts, how to make a playback UI usable in headset, and how
to separate renderer logic from user-facing media controls.

## Better workflow used in this wave

1. searched by WebXR video player, VR180 player, 360 viewer, stereoscopic
   video, local 360 player, and Vision Pro immersive video families;
2. deduplicated against previous video/player waves and known 360 viewer
   entries;
3. froze a shortlist across WebXR renderer-heavy, A-Frame minimal,
   single-file viewer, desktop local shell, and Vision Pro spatial player
   references;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `greggman/webxr-video` | WebXR video renderer/viewer/UI split with WebGL, WebGPU, and Layers variants |
| `brandynbuchanan/VR180-video-player` | Minimal A-Frame VR180 stereoscopic player |
| `ProGamerGov/html-360-viewer` | One-file drag/drop 360 image/video viewer |
| `thehancode/360-video-player` | Tauri/Svelte local 360 video shell around Video.js/videojs-vr |
| `acuteimmersive/openimmersive` | Vision Pro immersive/spatial video format and projection UX |

## Deep-pass notes by project

## `greggman/webxr-video`

- GitHub:
  [greggman/webxr-video](https://github.com/greggman/webxr-video)
- What it is:
  an unfinished but architecturally rich WebXR video player with WebGL,
  WebGPU, and WebXR Layers implementations.
- Interesting idea:
  split VR video playback into viewer/session orchestration, renderer backend,
  UI canvas, and media list logic.
- Code-level notes:
  `js/vr-video.js` owns app setup, video element state, GUI settings, playback
  events, directory scanning, and UI mode switching. `js/vr-video-viewer.js`
  owns session support, origin reset, XR frame draw, controller/mouse pointer
  mapping into a canvas UI, per-controller button bits, and event dispatch for
  `axismove`, `squeeze`, and playback controls. Renderer variants live under
  `js/webgl`, `js/webgpu`, and `js/webxr-layers`. `player-ui.js` renders
  play/pause, prev/next, speed, settings, list, exit, close, and a timeline into
  a canvas that is then projected inside VR.
- Architecture pattern:
  media app shell plus XR viewer plus backend renderer plus canvas UI texture.
- Reusable method:
  keep in-headset UI as an addressable 2D surface and translate controller rays
  into pointer events.
- Code donor value:
  high for renderer/viewer/UI boundaries and XR controller-to-UI mapping.
- Product reference value:
  medium-high for projection-heavy media tools.
- Caveats:
  project is explicitly unfinished and includes debug/global knobs.
- What to inspect next:
  compare its UI texture approach with quad/cylinder layer surface references.

## `brandynbuchanan/VR180-video-player`

- GitHub:
  [brandynbuchanan/VR180-video-player](https://github.com/brandynbuchanan/VR180-video-player)
- What it is:
  a minimal A-Frame VR180 video player sample.
- Interesting idea:
  the smallest useful VR180 player can be described as a video asset,
  `a-videosphere`, stereoscopic layout flag, and a basic in-scene control
  panel.
- Code-level notes:
  `index.html` creates an `a-videosphere` with `stereoscopic="left-right"`,
  points it at a `video` asset, and adds a simple control plane with play/pause
  and seek indicator. The code listens to video `timeupdate`, toggles playback,
  and attempts seek by click position.
- Architecture pattern:
  declarative A-Frame media sphere plus tiny DOM/video control bridge.
- Reusable method:
  for proof-of-value media tools, start from explicit projection/layout tags
  before building a full media library.
- Code donor value:
  low-medium as a tiny scaffold.
- Product reference value:
  medium for onboarding and projection demos.
- Caveats:
  click-to-seek logic is rough and lacks robust controller input mapping.
- What to inspect next:
  compare A-Frame stereo flags with more complete player projection settings.

## `ProGamerGov/html-360-viewer`

- GitHub:
  [ProGamerGov/html-360-viewer](https://github.com/ProGamerGov/html-360-viewer)
- What it is:
  a lightweight, single-file browser viewer for 360 images and videos.
- Interesting idea:
  one-file utilities are valuable when they expose file drop, URL loading,
  stereo mode, zoom, screenshot, and video controls without requiring an app
  build.
- Code-level notes:
  `viewer360.html` includes instructions, metadata, embedded CSS, A-Frame load,
  drag/drop controls, file input, query-string `url` / `src` loading, stereo
  modes for mono, top-bottom, and side-by-side media, video playback controls,
  zoom controls, fullscreen, reset, and screenshot affordances.
- Architecture pattern:
  portable single HTML utility with media source intake and projection toggles.
- Reusable method:
  build some diagnostics as copyable one-file viewers when deployment friction
  matters more than framework reuse.
- Code donor value:
  medium for intake/control UX and URL parameter shape.
- Product reference value:
  high for quick local/hosted 360 inspection.
- Caveats:
  single-file design is convenient but can become hard to maintain as features
  grow.
- What to inspect next:
  connect its stereo query parameters to a shared projection vocabulary.

## `thehancode/360-video-player`

- GitHub:
  [thehancode/360-video-player](https://github.com/thehancode/360-video-player)
- What it is:
  a desktop-packaged local 360 video player built with Tauri, Svelte,
  Video.js, and `videojs-vr`.
- Interesting idea:
  wrap a browser-based 360 viewer as a local desktop utility when file access
  and drag/drop matter more than headset-native runtime integration.
- Code-level notes:
  `src/App.svelte` switches from a selector screen to a `Vid` component once a
  path is selected. `SelectorTauri.svelte` uses Tauri `open`, `convertFileSrc`,
  `tauri://file-drop`, and dragover handling to convert local files into safe
  media URLs. `Vid.svelte` loads Video.js and `videojs-vr` assets, sets a
  fullscreen video element, and points the source at the selected path.
- Architecture pattern:
  desktop file shell plus web media player surface.
- Reusable method:
  use Tauri or a similar shell when local file permissions are the central
  product value.
- Code donor value:
  medium for local file intake and packaging pattern.
- Product reference value:
  medium-high for simple local media utilities.
- Caveats:
  relies on third-party video player plugins and is not a custom XR runtime
  integration.
- What to inspect next:
  compare with overlay window/browser-surface packaging patterns.

## `acuteimmersive/openimmersive`

- GitHub:
  [acuteimmersive/openimmersive](https://github.com/acuteimmersive/openimmersive)
- What it is:
  a free/open-source spatial and immersive video player for Apple Vision Pro.
- Interesting idea:
  projection and frame packing are user-facing decisions that deserve clear
  controls and explanations, not hidden decoder details.
- Code-level notes:
  `OpenImmersiveApp.swift` defines projection options for equirectangular,
  rectilinear, and Apple Immersive video, plus frame-packing options for
  default, side-by-side, and over-under. App state stores selected item, FOV,
  forced FOV, baseline, disparity, and timecode readout visibility.
  `SourcesList.swift` exposes gallery, file, and stream URL intake, shows the
  selected format, provides a projection picker, field-of-view picker, frame
  packing picker, baseline/disparity steppers, and opens an `ImmersiveSpace`
  with custom buttons and attachments.
- Architecture pattern:
  format-option model plus source intake plus immersive player attachment
  surface.
- Reusable method:
  expose media geometry and stereo assumptions in the UI, especially when
  metadata may be missing or wrong.
- Code donor value:
  medium-high for format option modeling and immersive attachment patterns.
- Product reference value:
  high for projection-aware media player UX.
- Caveats:
  Vision Pro/SwiftUI/OpenImmersive specific.
- What to inspect next:
  compare with browser and native players to form a cross-platform media format
  checklist.

## Cross-project synthesis

- Strongest code donors:
  `greggman/webxr-video`, `acuteimmersive/openimmersive`, and
  `thehancode/360-video-player`.
- Strongest product references:
  `acuteimmersive/openimmersive`, `ProGamerGov/html-360-viewer`, and
  `greggman/webxr-video`.
- Main reusable methods:
  projection-aware settings, canvas UI as XR surface, local file/drop intake,
  stereo layout toggles, WebXR layer/render backend separation, and format
  explanation UI.

## Fit for `VR-apps-lab`

This wave strengthens media utility foundations. Future VR tools can reuse the
projection vocabulary, local media intake patterns, in-headset playback UI
surface, and explicit format controls for diagnostics, overlay panels, and
media QA helpers.
