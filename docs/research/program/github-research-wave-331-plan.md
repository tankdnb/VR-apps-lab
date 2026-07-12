# GitHub Research Wave 331 Plan - Overlay Surface Proxies, Dashboard Notifications, Hand Redirection, and Tracker Recording Utilities

## Goal

Study overlay and interaction utility projects that proxy desktop content into
VR, render dashboard notifications, redirect hand targets, or record SteamVR
tracker data.

## Research Questions

- Which surface-proxy patterns are reusable for VR overlay/window helpers?
- How do overlay apps separate QML/UI rendering, OpenVR texture submission,
  socket ingestion, and manifest lifecycle?
- What interaction/data utilities are useful for future hand, tracker, and
  experiment-support tools?

## Shortlist

- `Eldon27232/KugouLyricsMirror`
- `ZephyrVR/tempest-overlay`
- `AndreZenner/hand-redirection-toolkit`
- `Avdbergnmf/SteamVR-Utils`

## Required Checks

- Deduplicate against OpenVR overlays, desktop/window capture, hand interaction,
  and tracker recording waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, install, or launch any
  found project.
- Mark old/vendor-heavy and research-toolkit caveats clearly.

## Expected Outputs

- Landscape synthesis for Wave 331.
- Registry/family entries for studied projects.
- Method catalog entry for proxy-surface and interaction-data utility
  boundaries.
