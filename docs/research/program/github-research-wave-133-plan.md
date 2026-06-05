# GitHub Research Wave 133 Plan

- Date: `2026-06-05`
- Goal: study VR subtitle, caption, speech/translation, OCR, and projection-
  aware subtitle tooling as reusable accessibility and information-surface
  patterns.

## Why this wave exists

Captions and subtitles are a practical VR utility family. They combine legible
in-headset placement, queueing, timing, speaker context, speech recognition,
translation, OCR, projection constraints, and transient feedback surfaces.

## Search scope

Primary search directions:

- VR subtitles;
- Unity subtitle directors;
- Unreal VR subtitle UX references;
- WebVR captioning;
- speech-to-text VR overlays;
- OCR and translation overlay helpers;
- 360 stereo subtitle burn-in tools.

## Frozen shortlist for code-level study

- `bjennings76/vr-subtitles`
- `AhhhhHeyyy/VR-Subtitles-WIP`
- `CarlUpright/VR_SUBTITLES_BURNERRR`
- `zacharykeeler/VR-Subtitles-in-Unreal-5`
- `akbartus/WebVR-Captioning`
- `DanielCirry/STTS`

## Execution model

### Step 1: Search and deduplicate

- search by accessibility/caption/speech/OCR families;
- deduplicate against earlier audio, VRChat speech/translation, overlay, and
  media-player waves.

### Step 2: Freeze the shortlist

- include engine-side subtitle directors, projection-aware media tooling,
  WebVR captioning, and a larger STT/translation/OCR overlay system.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep sources local-only and outside git history.

### Step 4: Perform the code-level pass

Inspect:

- subtitle queue and duration logic;
- speaker anchoring and field-of-view behavior;
- wait-for-input dialogue flow;
- stereo 360 subtitle geometry;
- screenshot-to-caption flow;
- STT/translation/OCR overlay rendering, history, and transport.

### Step 5: Promote findings into repository structure

Update Wave 133 landscape, registry, families, methods, backlog, current focus,
and indexes.

### Step 6: Verify before publishing

- no found project is run, built, installed, or launched;
- local source cache is cleaned after documentation integration.

## Definition of done

This wave is complete when VR subtitle/caption accessibility patterns are
documented with reusable timing, placement, overlay, OCR, and caveat notes.
