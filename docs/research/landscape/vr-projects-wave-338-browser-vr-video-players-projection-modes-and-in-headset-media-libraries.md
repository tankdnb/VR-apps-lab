# Wave 338 - Browser VR Video Players, Projection Modes, and In-Headset Media Libraries

This wave studies browser-based VR media players with 180/360 projection,
stereo layout, file/source, and in-headset media-library lessons.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to WebXR/WebVR video player surfaces, mono/stereo/180/360
projection modes, media source/catalog/thumbnail flows, and in-headset file
browser and playback controls.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `TimoWilhelm/vr-player` | Modern WebXR 180/360 video player | Studied | Strong donor for layout enums, file/URL input, worker-assisted layout detection, requestVideoFrameCallback texture upload, and WebXR session renderer split |
| `Bivrost/360WebPlayer` | Embeddable 360/WebVR media player | Studied | Mature product reference for declarative embed configuration, mono/stereo video/picture, HLS, touch/keyboard/gyro/WebVR input, browser support matrix, and CORS/HTTPS caveats |
| `michal-repo/web_vr_video_player` | In-headset WebXR media-library player | Studied | Strong UX donor for JSON media catalogs, generated thumbnails, folder search/sort, VR keyboard, draggable panels, controller shortcuts, and screen/projection switching |

## Code-Level Findings

### `TimoWilhelm/vr-player`

- Interesting idea: keep player state, WebXR session, video element, renderer,
  debug renderer, and video-layout recognition separated.
- Code donor value: high. `types.ts` defines `mono`, `stereoTopBottom`, and
  `stereoLeftRight`; `renderer.ts` computes aspect/model/UV offsets;
  `vrRenderer.ts` renders per XR view and uploads video textures only when new
  decoded frames are available; the app uses drag/drop, URL input, atoms, and a
  worker for layout/format recognition.
- Product reference value: high for lightweight browser media utilities.
- What to inspect next: format detection accuracy, worker privacy/performance,
  WebXR Layers alternatives, and mobile headset browser behavior.

### `Bivrost/360WebPlayer`

- Interesting idea: a 360 player can be a declarative embeddable component with
  many compatibility paths rather than a single fullscreen app.
- Code donor value: medium-high. The README and `src` show `<bivrost-player>`
  configuration, URL/type/loop/source options, media type autodetection from
  names, HLS support, picture/video support, input modules for mouse, keyboard,
  touch, gyro, and legacy WebVR.
- Product reference value: high for public-facing browser media surfaces.
- What to inspect next: projection/stereoscopy type tables, media parser,
  analytics privacy, current WebXR modernization path, and WordPress plugin
  boundaries.
- Caveat: older WebVR-era code and licensing/commercial-use constraints; reuse
  concepts and compatibility matrix, not the full player.

### `michal-repo/web_vr_video_player`

- Interesting idea: a browser VR media player can include a full in-headset file
  browser with search, sorting, thumbnails, source switching, draggable panels,
  and controller shortcuts.
- Code donor value: high for UX. The README describes JSON catalog generation,
  filename tags for `_SBS`, `_TB`, `_360`, `_SCREEN`, `sphere180`, `sphere360`,
  thumbnails via scripts, WebXR HTTPS/CORS requirements, and controller
  shortcuts. Source files expose Three.js video textures, stereo eye layers,
  sphere geometries, file-browser panels, VR keyboard/search, sources selector,
  draggable player/control panels, and mode switching.
- Product reference value: very high for future in-headset media-library tools.
- What to inspect next: catalog schema versioning, thumbnail generation safety,
  multi-source trust model, localization, and accessibility controls.

## Reusable Pattern Extraction

- Pattern candidate: projection-aware browser VR media surface.
- Problem solved: VR media utilities need to map arbitrary local/remote videos
  into correct 2D, 180, 360, mono, and stereo layouts while still giving users
  usable in-headset source and playback controls.
- Reusable core: media source descriptor, projection/layout enum, stereo UV
  mapping, eye-layer assignment, frame-aware video texture upload, WebXR session
  renderer, debug/flat renderer, file/URL/catalog input, thumbnail metadata,
  VR file browser, search/sort, draggable controls, controller shortcuts, and
  CORS/HTTPS validation.
- Source evidence: `TimoWilhelm/vr-player`, `Bivrost/360WebPlayer`, and
  `michal-repo/web_vr_video_player`.
- Abstraction boundary: keep media metadata, projection renderer, source
  discovery, catalog generation, player controls, and browser capability checks
  separate.
- What not to copy: stale WebVR assumptions, hardcoded filename parsing without
  schema, media paths without trust/CORS checks, analytics without consent, or
  monolithic player UI tied to one folder layout.
- Method catalog action: add projection-aware browser VR media surface.

## Follow-Up Gaps

- Define a media descriptor schema for future VR media experiments.
- Compare WebXR Layers video paths against manual WebGL sphere rendering.
- Extract a standalone in-headset file/source browser pattern.
