# GitHub Research Wave 297 Backlog - XR Captions, Subtitles, Accessibility Text, and Live Caption Surfaces

## Executed Scope

- Searched and deduplicated Unity caption packages, A11Y toolkits, live
  caption apps, A-Frame directional caption demos, web caption prototypes, and
  VRChat video subtitle overlays.
- Froze an eight-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted timed caption models, head-locked renderers, safe-area sizing,
  directional arrows, SRT parsing, video-time binding, VRChat chunk sync, and
  live STT/multimodal caption architecture.

## Studied Projects

- `XR-Access-Initiative/chirp-captions`
- `A11YTK/A11YTK`
- `neogeek/a11ytk-rewrite`
- `craigm26/LiveCaptionsXR`
- `lavin-a/aframe-xr-access-design`
- `jayrosen-design/XR-Caption`
- `jacklul/USharpVideo-Subtitles`
- `Ikbenmathijs/VRC-ProTV-Subtitles`

## Backlog Findings

- Build a caption matrix across timed text, live STT, directional captions,
  object labels, VRChat video subtitles, and AR speaker-localized captions.
- Deepen `chirp-captions`, `A11YTK`, and `USharpVideo-Subtitles` as strongest
  donors.
- Compare this wave with older VRChat chatbox/STT and accessibility waves.
- Consider a reuse plan for parser, renderer, safe-area, direction arrows,
  live-STT adapter, style profile, and privacy consent.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an XR caption/subtitle accessibility method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
