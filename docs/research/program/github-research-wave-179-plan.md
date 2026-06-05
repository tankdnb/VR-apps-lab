# GitHub Research Wave 179 Plan

- Date: `2026-06-05`
- Theme: `Capture, screenshot, media projection, window capture, and photomode helpers`
- Scope: 360 screenshots, editor screenshot tools, deterministic screenshot
  sequences, Windows desktop/window capture, Quest MediaProjection,
  photomode control surfaces, and 360/stereo media record/playback SDKs.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Overlay and utility tools often need pixels from somewhere else: a window, a
desktop, a camera, a render texture, a Quest screen, or a 360 capture. This wave
studies capture helpers as reusable surface-ingress and media-output patterns
for future VR utilities.

## Search Families

- Unity 360/equirectangular screenshot capture
- editor screenshot and thumbnail utilities
- screenshot sequence automation
- Windows desktop/window capture to Unity texture
- Quest screen capture and MediaProjection
- Unity photomode control surfaces
- 360/stereo video record and playback SDKs

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `yasirkula/Unity360ScreenshotCapture` | Cubemap-to-equirectangular capture with async readback and GPano metadata | 360 screenshot capture |
| `rurre/Editor-Screenshot` | Unity editor transparent screenshot and thumbnail tool with camera preview | Editor screenshot utility |
| `Team-on/UnityScreenShooter` | Runtime/editor screenshot sequence helper with resolution/language/UI options | Screenshot automation |
| `Phylliida/UnityWindowsCapture` | Windows window/desktop/Chromium capture into Unity textures | Window/desktop texture ingress |
| `t-34400/QuestMediaProjection` | Quest screen capture as Texture2D plus barcode, save, and WebRTC streaming | Quest screen texture ingress |
| `UnityTechnologies/PhotoMode` | In-game camera/postprocess/sticker/frame photomode control surface | Photomode UX and control surface |
| `vimeo/vimeo-unity-sdk` | Unity video record/upload and 4K/360/stereo playback via Vimeo APIs | 360/stereo media SDK |

## Dedupe Notes

- Earlier overlay waves covered browser/window capture inside OpenXR overlay
  engines. This wave treats capture helpers as reusable media/surface building
  blocks independent of any one overlay runtime.
- `QuestMediaProjection` is archived by its author because newer official
  Passthrough Camera APIs exist; it remains useful as a screen-capture and
  Android service wrapper reference.
- `UnityWindowsCapture` includes old generated/junk Unity folders in its source
  snapshot. Only its capture code is treated as research evidence.

## Code-Level Pass Targets

- cubemap render, equirectangular conversion, async GPU readback, and metadata
  embedding;
- editor camera preview, transparent backgrounds, resolution presets, and
  persistent editor settings;
- screenshot sequences, file naming, pause/unpause, UI/language variants;
- Win32 BitBlt, Desktop Duplication, cursor composition, Chromium texture
  capture, and texture update lifecycle;
- Android Java service wrappers, MediaProjection image polling, barcode
  readers, image saving, WebRTC peer creation, and signaling;
- photomode activation, event-system/camera handoff, UI toggles, stickers,
  filters, frames, blit render feature, and pause behavior;
- Unity MediaEncoder recording, 360/stereo cubemap capture, Vimeo upload
  chunks, and playback controller events.

## Expected Outputs

- Wave 179 landscape synthesis.
- Registry/family placement for capture and media projection helpers.
- Methods around 360 screenshots, authoring capture tools, window/desktop
  texture ingress, Quest screen projection, photomode surfaces, and media
  record/playback pipelines.
