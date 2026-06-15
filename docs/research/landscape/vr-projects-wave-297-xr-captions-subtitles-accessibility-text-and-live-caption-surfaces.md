# Wave 297 - XR Captions, Subtitles, Accessibility Text, and Live Caption Surfaces

This wave studies caption/subtitle and accessibility text projects as reusable
references for VR-readable text surfaces, head-locked safe areas, object/source
captioning, directional audio hints, live caption pipelines, VRChat video
subtitle overlays, and multimodal accessibility apps.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Unity caption/subtitle packages;
- head-locked and object-attached caption renderers;
- safe-area and direction-indicator logic;
- live speech-to-text and multimodal caption apps;
- WebXR/A-Frame directional captions;
- VRChat/Udon video subtitle overlays.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `XR-Access-Initiative/chirp-captions` | Unity XR caption system | Studied | Caption source/render manager split, head-locked renderer, safe area, and audio-source direction arrows |
| `A11YTK/A11YTK` | Unity accessibility toolkit captions/subtitles | Studied | SRT parser, subtitle source controllers, mode-specific renderers, and headset/object/screen placement |
| `neogeek/a11ytk-rewrite` | A11YTK rewrite/follow-up | Studied as variant | Useful as rewrite marker and package-shape comparison node |
| `craigm26/LiveCaptionsXR` | Live AR/XR captioning app | Studied | Flutter/native architecture with stereo audio, on-device STT, multimodal enhancement, localization, and anchored captions |
| `lavin-a/aframe-xr-access-design` | A-Frame directional captions and access design | Studied | Browser/WebXR directional caption controller and scene-level accessibility concept |
| `jayrosen-design/XR-Caption` | Web stereo caption prototype | Studied as micro-reference | Small Flask/web stereo caption surface for projection/layout comparison |
| `jacklul/USharpVideo-Subtitles` | VRChat/Udon video subtitle overlay | Studied | URL/text subtitle loading, parser chunking, update-rate controls, sync modes, and overlay styling |
| `Ikbenmathijs/VRC-ProTV-Subtitles` | ProTV subtitle micro-integration | Studied | Minimal VRCStringDownloader subtitle parser and current-time sync for ProTV |

## Code-Level Findings

### `XR-Access-Initiative/chirp-captions`

- Interesting idea:
  captions are modeled as source events that flow through a render manager into
  a selected positioning mode, rather than being tied to one UI prefab.
- Code donor value:
  very high. `CaptionSystem.cs`, `CaptionSource.cs`,
  `CaptionRenderManager.cs`, `CaptionRenderer.cs`, `HeadLockedPositioner.cs`,
  `IndicatorArrowsController.cs`, and `SafeArea.cs` show timed captions,
  renderer switching, safe-area sizing from camera FOV, stacked caption layout,
  and left/right arrows toward off-screen audio sources.
- Product reference value:
  very high for accessibility overlays and in-world caption helpers.
- What to inspect next:
  caption option persistence, source authoring workflow, localization, contrast
  settings, multi-speaker identity, and hand/controller interaction with the
  caption surface.

### `A11YTK/A11YTK`

- Interesting idea:
  subtitles can be represented as reusable source controllers and renderers
  with separate placement modes for headset, object, and screen use.
- Code donor value:
  high. `SRT.cs` parses timestamps and blocks. `SubtitleController.cs` loads
  prefabs/options and prevents screen-mode misuse in VR.
  `SubtitleRenderer.cs` handles camera parenting, object billboard behavior,
  wrapping, background styling, and visibility. `SubtitleVideoPlayerController`
  binds subtitle time to Unity `VideoPlayer.time`.
- Product reference value:
  high for subtitle assets, video captions, tooltip-like accessibility, and
  object-attached labels.
- What to inspect next:
  rewrite status, option assets, runtime API shape, tests, localization,
  screen-reader overlap, and support for streaming/live caption sources.

### `neogeek/a11ytk-rewrite`

- Interesting idea:
  a rewrite/fork can be useful as a package-shape and modernization marker even
  when it does not displace the original as the main donor.
- Code donor value:
  low/medium in this pass because the strongest source evidence remains in
  `A11YTK/A11YTK`.
- Product reference value:
  medium for package-maintenance comparison.
- What to inspect next:
  package structure, API differences, what was simplified, and whether rewrite
  behavior stays compatible with original A11YTK assets.

### `craigm26/LiveCaptionsXR`

- Interesting idea:
  live captions can be a full multimodal stack: audio capture, STT, contextual
  enhancement, speaker localization, AR anchors, model management, and visible
  session state.
- Code donor value:
  high as architecture reference. Docs and files show Flutter services,
  Android/iOS native plugins, stereo audio capture, Whisper/Gemma model
  management, MethodChannels, AR session states, localization, and caption
  models with confidence/timestamps.
- Product reference value:
  very high for real-time accessibility products.
- What to inspect next:
  privacy defaults, on-device/offline guarantees, model download UX, caption
  anchoring accuracy, failure states, and headset-native XR portability.

### `lavin-a/aframe-xr-access-design`

- Interesting idea:
  directional captions can be prototyped in WebXR with a small controller that
  maps source direction and scene state into readable labels.
- Code donor value:
  medium. `directional-caption-controller.js`,
  `directional_captions.html`, and custom A-Frame components are useful for
  browser-native caption experiments.
- Product reference value:
  high for WebXR accessibility sketches and source-direction teaching.
- What to inspect next:
  exact caption data schema, audio source binding, controller fallback, mobile
  browser behavior, and contrast/scale options.

### `jayrosen-design/XR-Caption`

- Interesting idea:
  a tiny web/stereo caption view is useful as a layout reference even when the
  code is not a full XR runtime.
- Code donor value:
  low/medium. `app.py`, `index.html`, and `stereo.html` provide a compact web
  surface for text/stereo layout.
- Product reference value:
  medium for projection and stereo-caption experiments.
- What to inspect next:
  input source, deployment assumptions, stereo layout math, and whether it can
  be generalized into a WebXR caption panel.

### `jacklul/USharpVideo-Subtitles`

- Interesting idea:
  VRChat video subtitles need parser budget limits, URL-vs-text sync choices,
  chunked network synchronization, and overlay styling controls.
- Code donor value:
  high for Udon/VRChat constraints. `SubtitleManager.cs` manages VRC URL
  loading, local/synced subtitle data, chunk sync, update rate, parser time
  limit, current video time, overlap support, and callbacks.
  `SubtitleOverlayHandler.cs` exposes font size/color, background opacity,
  margin, alignment, and screen placement behavior.
- Product reference value:
  very high for VRChat movie/video accessibility tools.
- What to inspect next:
  supported subtitle formats, parser failure recovery, lock/permission model,
  world performance, and integration with other video player prefabs.

### `Ikbenmathijs/VRC-ProTV-Subtitles`

- Interesting idea:
  a minimal subtitle integration can still be valuable if it cleanly maps
  downloaded text to a video player's current time.
- Code donor value:
  medium as a micro-reference. `ProTVSubtitles.cs` uses
  `VRCStringDownloader`, parses `-->` timestamp blocks, stores time/text arrays,
  updates text based on `tvManager.currentTime`, and resyncs indexes after time
  jumps.
- Product reference value:
  high as a small, understandable ProTV extension.
- What to inspect next:
  format edge cases, network ownership, text styling, multiple languages, and
  behavior during seek/loop/live streams.

## Reusable Pattern Extraction

- Pattern candidate:
  XR caption/subtitle boundary across source events, timed text parsing,
  positioning modes, safe-area rendering, directional hints, live STT, sync, and
  accessibility settings.
- Problem solved:
  caption tools often mix parsing, audio/video timing, layout, user settings,
  and network sync in one object, making them hard to reuse across VR apps.
- Reusable core:
  caption source, timed caption model, SRT/VTT parser, live STT event stream,
  renderer manager, headset/object/screen placement modes, safe-area/FOV
  limits, source-direction arrows, video-time binding, chunked sync, user
  styling options, confidence/timestamp fields, and privacy/model status.
- Source evidence:
  `chirp-captions`, `A11YTK`, `LiveCaptionsXR`,
  `aframe-xr-access-design`, `XR-Caption`, `USharpVideo-Subtitles`, and
  `VRC-ProTV-Subtitles`.
- Abstraction boundary:
  keep transcription/subtitle source, parser, timing clock, renderer, placement
  policy, network sync, user options, and privacy/model status separate.
- What not to copy:
  captions without safe-area limits, unbounded per-frame parsing, live audio
  capture without consent, hardcoded language/model assumptions, VRChat URL
  sync without permissions, or text overlays without contrast/scale controls.
- Method catalog action:
  add an XR caption/subtitle accessibility method.

## Follow-Up Gaps

- Build a caption matrix across timed text, live STT, object labels, directional
  source captions, VRChat video subtitles, and AR speaker-localized captions.
- Deepen `chirp-captions`, `A11YTK`, and `USharpVideo-Subtitles` as strongest
  source-level donors.
- Compare this wave with older caption/STT waves so VRChat chatbox, overlay
  captions, and XR accessibility text stay distinct but connected.
- Consider a future reuse plan for a caption utility kit: parser, renderer,
  safe area, direction arrows, live STT adapter, style profile, and privacy
  consent.
