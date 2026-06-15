# GitHub Research Wave 300 Plan - XR Text Entry, Keyboard Variants, Gaze, Dictation, and Query Input Surfaces

## Goal

Study XR text-entry projects as reusable references for spatial keyboards,
gaze/dwell input, runtime keyboard packages, physical/direct key interaction,
dictation-adjacent routing, and structured query-entry surfaces.

## Research Questions

- How do keyboard projects separate layout data, key rendering, interaction
  source, text receiver, haptics, preview, and target input field?
- Which projects support direct controller/hand input, ray input, gaze/dwell
  input, or query-term composition?
- Which projects are strong code donors versus product references?
- What should become a reusable method in the text-entry catalog?

## Shortlist

- `ViRGIS-Team/VR-Keyboard`
- `magicleap/MagicLeapXRKeyboard`
- `fabio914/EyeTrackingKeyboard`
- `vitrivr/vitrivr-vr`

## Required Checks

- Deduplicate against earlier VR keyboard, WebView surface, WebXR UI, and
  accessibility text waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep vendor, prototype, accessibility, and privacy caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 300.
- Registry/family entries for XR text-entry surfaces.
- Method catalog entry for keyboard/gaze/dictation/query input boundaries.
- Follow-up gaps around an XR text-entry kit and mode matrix.
