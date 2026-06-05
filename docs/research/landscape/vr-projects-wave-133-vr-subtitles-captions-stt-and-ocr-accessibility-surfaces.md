# VR Projects Wave 133: VR Subtitles, Captions, STT, and OCR Accessibility Surfaces

- Date: `2026-06-05`
- Goal: study VR subtitle, caption, STT/translation, OCR, and projection-aware
  subtitle tools as reusable accessibility and information-surface patterns.

## Why this wave exists

Accessibility surfaces in VR are also general utility surfaces. Subtitle queues,
speaker anchoring, transient OCR cards, speech logs, and projection-aware media
subtitles all teach how to put information into VR without making the user
fight the headset.

## Better workflow used in this wave

1. searched by VR subtitle, caption, STT, translation, OCR, and stereo-360
   subtitle families;
2. deduplicated against audio/media, VRChat speech, and overlay waves;
3. froze a shortlist covering engine-side, browser-side, media-side, and
   overlay-side implementations;
4. inspected local-only source clones;
5. separated code donors from report-only UX references;
6. extracted methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `bjennings76/vr-subtitles` | Unity subtitle director with queue, priority, WPM timing, and FOV behavior |
| `AhhhhHeyyy/VR-Subtitles-WIP` | Compact Unity/TMP dialogue queue and subtitle display |
| `CarlUpright/VR_SUBTITLES_BURNERRR` | Projection-aware subtitle burn-in for stereo 360 top-bottom video |
| `zacharykeeler/VR-Subtitles-in-Unreal-5` | Report-only Unreal subtitle UX comparison |
| `akbartus/WebVR-Captioning` | A-Frame/WebVR screenshot-to-caption prototype |
| `DanielCirry/STTS` | STT/translation/OCR system with SteamVR overlays and VRChat OSC |

## Deep-pass notes by project

## `bjennings76/vr-subtitles`

- GitHub:
  [bjennings76/vr-subtitles](https://github.com/bjennings76/vr-subtitles)
- What it is:
  a Unity subtitle framework for VR scenes.
- Interesting idea:
  subtitles in VR should be queued, timed, prioritized, optionally attached to
  speakers, and kept legible in the user's field of view.
- Code-level notes:
  `SubtitleDirector.cs` is a singleton with a queued `List<Subtitle>`,
  `SubtitleUI`, `FaceTarget`, and `StayInFov`. It uses the headset transform
  through VRTK, creates/sorts subtitles, roosts on speaker targets, fades out,
  clears active subtitles, and calculates duration from WPM/minimum duration.
  `Subtitle.cs` stores text, portrait, duration, target time, priority,
  template, speaker, and lifecycle events (`OnShow`, `OnComplete`,
  `OnCancel`). `SubtitleUI.cs` binds portrait/text and fades a canvas group.
- Code donor value:
  high for queued subtitle lifecycle and FOV/speaker placement.
- Product reference value:
  high for accessibility and narrative VR utilities.
- Caveats:
  older Unity/VRTK dependency assumptions.
- What to inspect next:
  compare subtitle placement against HMD-fixed and world-fixed references.

## `AhhhhHeyyy/VR-Subtitles-WIP`

- GitHub:
  [AhhhhHeyyy/VR-Subtitles-WIP](https://github.com/AhhhhHeyyy/VR-Subtitles-WIP)
- What it is:
  a WIP Unity subtitle/dialogue prototype.
- Interesting idea:
  a very small dialogue controller can still be useful if it cleanly separates
  queue, wait-for-input, line start/complete events, and UI presentation.
- Code-level notes:
  `Subtitle.cs` binds TextMeshPro speaker and subtitle text, shows a canvas,
  stops any active coroutine, hides after delay, and invokes a completion
  callback. `DialogueController.cs` manages a queue of `DialogueLine`, exposes
  `OnLineStart`, `OnLineComplete`, `OnQueueEmpty`, supports `waitForInput`,
  and continues dialogue on request.
- Code donor value:
  medium for compact dialogue queue and callback flow.
- Product reference value:
  medium for small tutorial/training apps.
- Caveats:
  WIP sample, not a full accessibility system.
- What to inspect next:
  compare with stronger subtitle director timing/FOV behavior.

## `CarlUpright/VR_SUBTITLES_BURNERRR`

- GitHub:
  [CarlUpright/VR_SUBTITLES_BURNERRR](https://github.com/CarlUpright/VR_SUBTITLES_BURNERRR)
- What it is:
  a PowerShell/FFmpeg helper for burning subtitles into 360 stereo top-bottom
  videos.
- Interesting idea:
  subtitles in stereo 360 video need projection-aware placement; burning the
  same subtitle into both eye halves avoids horizontal disparity.
- Code-level notes:
  `burn_360_subs.ps1` checks `ffmpeg` and `ffprobe`, probes dimensions, copies
  the SRT to a temp path, splits top/bottom halves, burns identical ASS
  subtitles into each half, stacks them with `vstack`, maps audio, and computes
  font size/margins from half-height. The script deliberately keeps text
  centered and avoids eye mismatch for top-bottom stereo.
- Code donor value:
  high for projection-aware media preprocessing.
- Product reference value:
  high as a narrow but valuable VR media micro-utility.
- Caveats:
  offline burn-in tool, not an interactive overlay.
- What to inspect next:
  extract a subtitle geometry checklist for stereo/equirectangular media.

## `zacharykeeler/VR-Subtitles-in-Unreal-5`

- GitHub:
  [zacharykeeler/VR-Subtitles-in-Unreal-5](https://github.com/zacharykeeler/VR-Subtitles-in-Unreal-5)
- What it is:
  a report/project reference for VR subtitle UX in Unreal.
- Interesting idea:
  compare subtitle presentation modes as UX options: fixed below character,
  character/comic style with portrait/backing plane, and HMD-fixed display.
- Code-level notes:
  current clone is mostly report/readme material rather than reusable source,
  so it was treated as a UX reference only.
- Code donor value:
  low in the current clone.
- Product reference value:
  medium for subtitle placement comparison.
- Caveats:
  report-only, not a code donor.
- What to inspect next:
  revisit only if Unreal subtitle surface work becomes active.

## `akbartus/WebVR-Captioning`

- GitHub:
  [akbartus/WebVR-Captioning](https://github.com/akbartus/WebVR-Captioning)
- What it is:
  an A-Frame/WebVR prototype that screenshots the scene and sends the image to
  an image-captioning model.
- Interesting idea:
  a VR scene can use a screenshot-to-caption loop as a transient annotation or
  accessibility hint surface.
- Code-level notes:
  `js/main.js` captures the A-Frame scene screenshot canvas, converts it to a
  data URL, sends it to a Hugging Face image-captioning Space, writes caption
  text to a scene element, shows the captured photo, hides it after timeout,
  and triggers an environment animation when the caption contains a target word.
- Code donor value:
  medium for WebXR screenshot-to-remote-caption flow.
- Product reference value:
  high for scene-reader and transient annotation ideas.
- Caveats:
  remote model dependency and demo-level robustness.
- What to inspect next:
  compare with local OCR overlays and privacy-sensitive captioning workflows.

## `DanielCirry/STTS`

- GitHub:
  [DanielCirry/STTS](https://github.com/DanielCirry/STTS)
- What it is:
  a speech-to-text, translation, TTS, OCR, VR overlay, and VRChat OSC system.
- Interesting idea:
  combine typed message history, transient notifications, OCR capture controls,
  translation, and VRChat chatbox output into one local companion pipeline.
- Code-level notes:
  `python/integrations/vr_overlay.py` creates SteamVR overlays for a
  notification surface and message log, with dataclass settings for tracking
  target, x/y/width/height/distance, fonts, colors, opacity, and fade. It
  renders text with PIL, supports Latin/CJK fonts, keeps typed messages
  (`user`, `speaker`, `ai`, `system`), tracks devices, and submits raw overlay
  pixels. `vr_ocr_overlay.py` adds OCR-specific overlays: toggle button,
  capture region, camera button, corner handles, close button, and translation
  overlay. `engine.py` orchestrates STT, translation, TTS, AI, VRChat OSC,
  speaker capture, OCR, and VR overlay. `vrchat_osc.py` handles queueing,
  VRChat chatbox limits, and emoji conversion. The frontend/backend split uses
  Tauri spawning a Python backend.
- Code donor value:
  very high for speech/translation/OCR overlay architecture.
- Product reference value:
  very high for accessibility companion tools.
- Caveats:
  large multi-feature stack; needs careful slicing before reuse.
- What to inspect next:
  compare with prior VRChat speech/translation sidecars and caption overlays.

## Cross-project synthesis

Reusable lessons:

- Subtitle surfaces need duration, priority, placement, and lifecycle events.
- Speaker-roosted and FOV-stabilized subtitles solve different user problems.
- Simple dialogue queues remain useful when wait-for-input and completion
  events are explicit.
- Stereo 360 subtitles must handle per-eye geometry and disparity.
- Scene screenshot captioning can be a browser-native accessibility pattern.
- Speech/translation/OCR overlays need typed message history, font fallback,
  tracking targets, fade, and output bridges.

Best donor candidates:

- `STTS` for STT/translation/OCR overlay pipelines.
- `vr-subtitles` for subtitle queue/FOV/speaker behavior.
- `VR_SUBTITLES_BURNERRR` for projection-aware subtitle media tooling.
- `WebVR-Captioning` for screenshot-to-caption WebXR flow.

## Reuse implications for `VR-apps-lab`

This wave suggests an `accessibility and caption surfaces` branch:

- queued subtitle director;
- subtitle placement matrix;
- speech/translation message overlay;
- OCR capture/control overlay;
- projection-aware media subtitle preprocessing;
- scene-reader/caption prototype.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were used only for code reading and are local-only.
