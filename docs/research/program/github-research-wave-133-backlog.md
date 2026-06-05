# GitHub Research Wave 133 Backlog

- Date: `2026-06-05`
- Scope: VR subtitle directors, caption surfaces, STT/translation overlays,
  OCR feedback cards, and projection-aware subtitle tooling.

## Completed in this wave

- Studied `bjennings76/vr-subtitles` as a Unity subtitle director with queue,
  priority, WPM duration, speaker roosting, stay-in-FOV behavior, and fade
  lifecycle.
- Studied `AhhhhHeyyy/VR-Subtitles-WIP` as a compact TMP subtitle/dialogue
  queue with wait-for-input progression and completion callbacks.
- Studied `CarlUpright/VR_SUBTITLES_BURNERRR` as a PowerShell/FFmpeg utility
  for burning subtitles into top-bottom stereo 360 video without horizontal
  disparity.
- Studied `zacharykeeler/VR-Subtitles-in-Unreal-5` as a report-only UX
  reference comparing fixed, character/comic, portrait, backing-plane, and
  HMD-fixed subtitle approaches.
- Studied `akbartus/WebVR-Captioning` as an A-Frame screenshot-to-caption
  prototype using remote image captioning and transient in-scene annotation.
- Studied `DanielCirry/STTS` as a larger STT/translation/OCR stack with SteamVR
  overlays, typed message log, CJK font handling, OCR control overlays, and
  VRChat OSC chatbox integration.

## Reuse candidates

- `STTS` is the strongest donor for speech/translation/OCR overlay pipelines.
- `vr-subtitles` is the strongest engine-side subtitle queue donor.
- `VR_SUBTITLES_BURNERRR` is the strongest projection-aware subtitle media
  micro-utility.
- `WebVR-Captioning` is a useful browser-native screenshot-to-caption pattern.

## Follow-up backlog

1. Extract a subtitle placement matrix: speaker-roosted, FOV-stabilized,
   HMD-fixed, world-fixed, comic/backing-plane, and transient annotation.
2. Compare STT/translation overlay history models across STTS and earlier
   VRChat speech/translation sidecars.
3. Turn stereo-360 subtitle constraints into a media helper checklist.
4. Revisit Unreal subtitle UX only if an Unreal utility prototype becomes
   active.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
