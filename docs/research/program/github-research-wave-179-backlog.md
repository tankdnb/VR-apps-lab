# GitHub Research Wave 179 Backlog

- Date: `2026-06-05`
- Theme: `Capture, screenshot, media projection, window capture, and photomode helpers`
- Status: executed as static source-reading pass
- Build/run status: not run, not built, not installed, not launched

## Completed Intake

- Shortlisted capture, screenshot, MediaProjection, window-capture, photomode,
  and media playback/recording projects.
- Deduplicated against overlay, media player, 360 video, and desktop-in-VR
  families.
- Read source entry points without executing any found project.
- Integrated capture/surface-ingress patterns into the canonical docs.

## Follow-Up Work

- Create a `surface-ingress matrix` comparing:
  screen capture, window capture, desktop duplication, MediaProjection,
  render texture, camera cubemap, and remote video stream.
- Compare editor screenshot utilities against runtime capture tools:
  authoring value, user value, metadata output, and repeatability.
- Keep Quest MediaProjection as reference-only if official passthrough camera
  APIs supersede it for new production work.
- Track capture privacy, permissions, and platform restrictions whenever these
  patterns move from research into prototype code.

## Reuse Candidates

- Cubemap/equirectangular screenshot plus GPano metadata from
  `Unity360ScreenshotCapture`.
- Transparent editor thumbnail/preview UX from `Editor-Screenshot`.
- Deterministic screenshot sequence settings from `UnityScreenShooter`.
- Win32 window/desktop texture capture boundaries from `UnityWindowsCapture`.
- Quest MediaProjection service/view-model wrapper from `QuestMediaProjection`.
- Photomode camera/postprocess/UI handoff from `PhotoMode`.
- MediaEncoder 360/stereo recording and upload/playback lifecycle from
  `vimeo-unity-sdk`.

## Caveats To Preserve

- Capture tools are privacy-sensitive; permission and user-visible consent
  should be part of any future prototype.
- Some capture paths are Windows-only, Quest-only, editor-only, or deprecated.
- Do not import old generated Unity folders or binary artifacts from study
  repos into this public repository.
