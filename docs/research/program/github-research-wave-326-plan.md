# GitHub Research Wave 326 Plan - KAT Walk Linux Locomotion Overlay and OpenXR Layer Split

## Goal

Study a fresh KAT Walk Linux utility that combines USB sensor decoding,
locomotion fusion, an in-VR wrist HUD, and an OpenXR implicit layer without
treating the external repo as something to build or validate locally.

## Research Questions

- How can hardware sensor streams feed locomotion through a runtime layer while
  keeping tuning and diagnostics visible in VR?
- What boundary separates daemon, parser, locomotion model, shared-memory bus,
  HUD renderer, and OpenXR layer?
- Which overlay interaction patterns are reusable for future VR utility HUDs?

## Shortlist

- `BBPSBB/katwalk-linux`
- `Kiichiuwu/WTVFSVR-war-thunder-virtual-flight-stick-for-vr`

## Required Checks

- Deduplicate against KATOXR, walking-in-place, OpenXR layer, and overlay HUD
  waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch the found projects.
- If a candidate has no source, mark it source-light/empty instead of forcing
  donor value.

## Expected Outputs

- Landscape synthesis for Wave 326.
- Registry/family entries for Linux treadmill locomotion and empty/source-light
  virtual flight-stick candidates.
- Method catalog entry for hardware sensor daemon plus OpenXR HUD/layer split.
