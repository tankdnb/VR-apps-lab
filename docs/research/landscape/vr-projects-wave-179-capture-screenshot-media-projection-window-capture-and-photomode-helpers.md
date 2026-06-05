# VR Projects Wave 179: Capture, Screenshot, Media Projection, Window Capture, and Photomode Helpers

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 179 studies capture and media helper projects that turn screens, windows,
cameras, render textures, cubemaps, Quest screen output, or video streams into
reusable textures, screenshots, recordings, or in-game photography surfaces.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `yasirkula/Unity360ScreenshotCapture` | Unity 360/equirectangular screenshot capture | Strong capture donor |
| `rurre/Editor-Screenshot` | Unity editor transparent screenshot utility | Strong authoring UX donor |
| `Team-on/UnityScreenShooter` | Screenshot sequence and runtime capture helper | Medium sequence donor |
| `Phylliida/UnityWindowsCapture` | Windows window/desktop/Chromium texture capture | Strong surface-ingress donor with age caveats |
| `t-34400/QuestMediaProjection` | Quest screen capture, barcode, save, and WebRTC plugin | Strong Android wrapper reference with archive caveat |
| `UnityTechnologies/PhotoMode` | In-game photomode control surface | Strong UX/control donor |
| `vimeo/vimeo-unity-sdk` | Unity 360/stereo video record/upload/playback SDK | Strong media pipeline reference |

## `yasirkula/Unity360ScreenshotCapture`

- Interesting idea:
  capture a Unity scene as an equirectangular 360 image by rendering a cubemap,
  converting it to equirectangular projection, reading pixels sync/async, and
  embedding panorama metadata.
- Code donor value:
  high for cubemap capture, converter shader, async GPU readback path, and
  GPano XMP metadata injection.
- Product reference value:
  high for creator tools, diagnostics, panorama export, and VR scene capture.
- What to inspect next:
  compare its image capture path with video/360 recorders and editor screenshot
  utilities.
- Source evidence:
  `Plugins/Simple360Render/I360Render.cs` and
  `EquirectangularConverter.shader`.
- Reusable pattern extraction:
  cubemap-to-equirectangular screenshot capture with metadata.
- Reusable core:
  render a camera to a cubemap, convert to equirectangular render texture, use
  async GPU readback when available, fall back to `ReadPixels`, encode JPEG/PNG,
  inject GPano XMP metadata, and clean temporary render textures.
- Do not copy directly:
  render pipeline assumptions without testing target engine/runtime support.
- Caveats:
  relies on platform support for `RenderToCubemap` and related Unity paths.

## `rurre/Editor-Screenshot`

- Interesting idea:
  make screenshots an editor authoring workflow with camera preview, scene-view
  following, transparent backgrounds, resolution presets, near-clip override,
  and persistent settings.
- Code donor value:
  high for Unity editor UX, preview render textures, transparent capture, and
  saved editor settings.
- Product reference value:
  high for asset thumbnails, VRChat/world presentation images, and repeatable
  creator screenshots.
- What to inspect next:
  merge its editor UX lessons with runtime screenshot sequence tools.
- Source evidence:
  `EditorScreenshot.cs` and `EditorScreenshotUtility.cs`.
- Reusable pattern extraction:
  authoring-time transparent screenshot tool.
- Reusable core:
  expose camera selection, preview rendering, resolution presets, transparent
  background toggles, unique file names, `EditorPrefs` persistence, scene-view
  camera following, and create-camera-from-scene-view actions.
- Do not copy directly:
  editor-only assumptions into runtime tools.
- Caveats:
  not a runtime VR capture tool; best as authoring utility reference.

## `Team-on/UnityScreenShooter`

- Interesting idea:
  define screenshot capture as repeatable data: target camera, resolution,
  multiplier, overlay UI, language, timescale pause, and structured filenames.
- Code donor value:
  medium for screenshot sequencing, file naming, and capture settings data.
- Product reference value:
  medium-high for localization QA, store screenshots, and predictable creator
  capture.
- What to inspect next:
  compare with editor-only screenshot tools and 360 capture tools.
- Source evidence:
  `ScreenshotTaker.cs` and `ScreenshotData.cs`.
- Reusable pattern extraction:
  deterministic screenshot sequence helper.
- Reusable core:
  keep screenshot settings as data objects, pause/unpause time when needed,
  wait one frame before capture, include product/resolution/language/UI state
  in filenames, and target either camera or screen capture.
- Do not copy directly:
  project-specific default output paths without user controls.
- Caveats:
  smaller donor than the editor and 360 capture tools, but useful as repeatable
  capture pattern.

## `Phylliida/UnityWindowsCapture`

- Interesting idea:
  capture individual Windows windows, desktops, cursor state, and Chromium
  pages into Unity textures using Win32 BitBlt, Desktop Duplication, native
  plugin callbacks, and shared-memory browser textures.
- Code donor value:
  high for window enumeration, capture lifecycle, texture upload, cursor
  composition, desktop duplication, and Chromium capture boundary.
- Product reference value:
  high for desktop-in-VR, window overlays, live reference panels, and captured
  browser surfaces.
- What to inspect next:
  compare with overlay engines that capture hidden browser/window sources into
  OpenXR layers.
- Source evidence:
  `WindowCaptureManager.cs`, `WindowCapture.cs`, `DesktopCapture.cs`, and
  `ChromiumCapture.cs`.
- Reusable pattern extraction:
  external window/desktop/browser texture ingress for Unity.
- Reusable core:
  maintain a window capture registry, add/remove captures as windows appear or
  disappear, create compatible device contexts, resize buffers on window
  changes, align bitmap rows into RGB texture data, use Desktop Duplication via
  plugin callbacks for full desktop capture, draw cursor pixels, and wrap
  Chromium offscreen browser textures with random shared memory/port IDs.
- Do not copy directly:
  old generated Unity folders, Windows-only APIs, broad catch blocks, or
  unmanaged-resource cleanup patterns without modernization.
- Caveats:
  valuable as a surface-ingress reference, not as drop-in modern code.

## `t-34400/QuestMediaProjection`

- Interesting idea:
  wrap Android MediaProjection for Quest so captured screen frames can become
  Unity `Texture2D` values, barcode results, saved images, or WebRTC streams.
- Code donor value:
  high for AndroidJavaObject service wrapper, view-model events, barcode
  services, image saving, WebRTC peer wrappers, and signaling example.
- Product reference value:
  high for headset-side screen capture, remote viewing, QR/barcode workflows,
  and diagnostic surfaces.
- What to inspect next:
  compare with official Quest Passthrough Camera APIs and decide which parts
  remain useful as screen-capture rather than camera-capture reference.
- Source evidence:
  `ServiceContainer.cs`, `MediaProjectionService.cs`,
  `MediaProjectionViewModel.cs`, `BarcodeReaderViewModel.cs`,
  `ImageSaverViewModel.cs`, `WebRtcMediaProjectionManager.cs`,
  `PeerConnection.cs`, `SignalingClient.cs`, and
  `BarcodeHighlightController.cs`.
- Reusable pattern extraction:
  Quest MediaProjection service to Unity texture/event/WebRTC bridge.
- Reusable core:
  create Java service objects from Unity lifecycle events, expose a
  `ServiceContainer`, poll latest images at a configurable interval, invoke
  `UnityEvent<Texture2D>` when texture data updates, create barcode readers
  with crop/format options, request bitmap saving, create WebRTC peer
  connections from the media projection manager, and drive offer/candidate
  signaling over WebSocket.
- Do not copy directly:
  archived workaround assumptions or platform permissions without current Meta
  API review.
- Caveats:
  author archives it as reference because official passthrough camera access is
  now available; it remains useful as screen-capture and Android wrapper study.

## `UnityTechnologies/PhotoMode`

- Interesting idea:
  package in-game photography as a self-contained UX surface with camera
  orbit/offset, pause integration, post-process sliders, filters, frames,
  stickers, UI/grid toggles, and render-feature activation.
- Code donor value:
  high for camera/event-system handoff, control surface organization, sticker
  mode, UI reset, and URP blit render feature.
- Product reference value:
  high for any VR/3D utility that needs a polished capture/control mode rather
  than a raw screenshot button.
- What to inspect next:
  adapt photomode controls to VR controller/hand input and comfort rules.
- Source evidence:
  `PhotoMode.cs`, `PhotoModePauser.cs`, `PhotoModeStickerController.cs`,
  `Blit.cs`, and `TextSlider.cs`.
- Reusable pattern extraction:
  in-game photomode control surface.
- Reusable core:
  switch EventSystems, raise activation events, move a Cinemachine photo camera
  around a player object, reset sliders/stickers/filters, toggle UI and grid,
  expose post-processing sliders, use unscaled time while paused, disable
  player input during photo mode, and isolate post effects in a render feature.
- Do not copy directly:
  flat-screen defaults without VR-specific interaction and comfort adaptation.
- Caveats:
  built for PC/console Unity, not VR-first, but its control-surface structure
  is reusable.

## `vimeo/vimeo-unity-sdk`

- Interesting idea:
  combine Unity recording, 360/stereo capture, upload chunks, playback
  controls, Vimeo metadata/API access, and optional AVPro/Depthkit integration
  into a media SDK.
- Code donor value:
  high for record/upload/playback lifecycle, MediaEncoder inputs, 360 cubemap
  capture, chunked upload, and video controller events.
- Product reference value:
  high for immersive media surfaces, 360 video workflows, and record/share
  utilities.
- What to inspect next:
  compare with local-only 360/stereo video players and WebXR media surfaces.
- Source evidence:
  `VimeoRecorder.cs`, `RecorderController.cs`, `EncoderManager.cs`,
  `CameraInput.cs`, `VimeoPlayer.cs`, and `VimeoUploader.cs`.
- Reusable pattern extraction:
  media record/upload/playback pipeline with 360/stereo support.
- Reusable core:
  expose recorder state and upload events, switch between encoder backends,
  initialize screen/camera/render-texture inputs, capture 360 stereo via
  cubemap-to-equirectangular rendering, use MediaEncoder in editor, upload
  files in TUS-style chunks with progress events, load video metadata, and pass
  selected video URLs into Unity/AVPro playback controllers.
- Do not copy directly:
  account-token assumptions or editor-only MediaEncoder paths without target
  platform review.
- Caveats:
  tied to Vimeo account/API requirements; useful as media pipeline reference.

## Extracted Methods

- Cubemap/equirectangular screenshot capture:
  use cubemap render, equirectangular conversion, optional async readback, and
  metadata embedding for panorama-friendly artifacts.
- Authoring screenshot utility:
  editor tools should expose camera preview, transparent background, resolution
  presets, saved settings, and repeatable file naming.
- Window/desktop/browser texture ingress:
  captured external surfaces need lifecycle, resize, cursor, texture upload,
  and platform-resource cleanup boundaries.
- Quest screen projection bridge:
  Android service wrappers can expose screen capture as Unity textures, events,
  barcode results, saved images, and WebRTC streams.
- Photomode control surface:
  camera, pause, post-processing, overlays, stickers, frames, and UI visibility
  can be modeled as a mode with reset and activation events.
- Media record/playback SDK:
  360/stereo capture and upload/playback need encoder input abstractions,
  progress events, metadata loading, and account/API caveats.

## Why This Matters For `VR-apps-lab`

This wave strengthens the "surface" side of VR utilities. Overlays, diagnostics,
and helper apps often start by capturing or generating pixels; this batch gives
the repository reusable patterns for how those pixels enter, leave, and become
operator-facing tools.
