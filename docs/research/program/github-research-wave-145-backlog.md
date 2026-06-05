# GitHub Research Wave 145 Backlog

- Date: `2026-06-05`
- Scope: WebXR video players, VR180 samples, one-file 360 viewers, Tauri local
  video shells, and Vision Pro immersive/spatial video UI.

## Completed in this wave

- Studied `greggman/webxr-video` as a modular WebXR video player with
  renderer/viewer/UI separation, WebGL/WebGPU/WebXR Layers variants, controller
  rays mapped into a canvas UI, playlist directory scanning, projection modes,
  and stereo layout settings.
- Studied `brandynbuchanan/VR180-video-player` as a tiny A-Frame VR180 sample
  with `a-videosphere`, left/right stereoscopic layout, and basic in-scene
  play/seek controls.
- Studied `ProGamerGov/html-360-viewer` as a single-file browser 360 image and
  video viewer with drag/drop, URL query loading, stereo toggles, zoom,
  fullscreen, screenshot, and video controls.
- Studied `thehancode/360-video-player` as a Tauri/Svelte local video shell
  using file picker/drop events, `convertFileSrc`, Video.js, and `videojs-vr`.
- Studied `acuteimmersive/openimmersive` as a Vision Pro spatial/immersive
  video player with projection selection, frame-packing selection, FOV,
  baseline/disparity controls, local/gallery/HLS sources, and custom immersive
  attachments.

## Reuse candidates

- `greggman/webxr-video` is the strongest code donor for renderer/viewer/UI
  separation and in-XR canvas UI event mapping.
- `acuteimmersive/openimmersive` is the strongest product reference for
  projection/frame-packing UX and format explanation.
- `ProGamerGov/html-360-viewer` is a strong micro-utility reference for
  one-file drag/drop viewers.
- `thehancode/360-video-player` is useful for local desktop packaging of a
  browser-based VR media surface.
- `brandynbuchanan/VR180-video-player` is a tiny reference for A-Frame VR180
  scaffolding.

## Follow-up backlog

1. Extract a projection/layout vocabulary covering 180, 360, equirectangular,
   rectilinear, side-by-side, over-under, baseline, disparity, and FOV.
2. Compare WebXR layer/video texture approaches with previous browser video
   waves and OpenVR overlay media surfaces.
3. Consider a reusable `projection-aware media surface` note for future media
   diagnostics or overlay panels.
4. Track CORS/autoplay/local-file caveats as browser media utility constraints.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
