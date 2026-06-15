# GitHub Research Wave 297 Plan - XR Captions, Subtitles, Accessibility Text, and Live Caption Surfaces

## Goal

Study XR caption and subtitle projects as reusable references for timed text,
live captions, safe-area head-locked rendering, source-direction hints,
object-attached labels, VRChat video subtitles, and accessibility text
settings.

## Research Questions

- How do projects separate caption sources, parsers, clocks, renderers,
  placement modes, sync, and user settings?
- Which render placements are headset-locked, object-attached, screen/video,
  directional, or AR speaker-localized?
- How do live caption projects handle STT, model management, privacy, and
  failure states?
- Which VRChat subtitle projects are useful as constrained Udon donors?

## Shortlist

- `XR-Access-Initiative/chirp-captions`
- `A11YTK/A11YTK`
- `neogeek/a11ytk-rewrite`
- `craigm26/LiveCaptionsXR`
- `lavin-a/aframe-xr-access-design`
- `jayrosen-design/XR-Caption`
- `jacklul/USharpVideo-Subtitles`
- `Ikbenmathijs/VRC-ProTV-Subtitles`

## Required Checks

- Deduplicate against older caption, STT, OCR, chatbox, video-player, and
  accessibility waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep privacy, parser budget, sync, safe-area, and source-light caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 297.
- Registry/family entries for caption/subtitle accessibility surfaces.
- Method catalog entry for XR caption/subtitle boundaries.
- Follow-up gaps around a caption utility kit and cross-runtime caption matrix.
