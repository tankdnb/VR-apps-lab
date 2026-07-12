# GitHub Research Wave 321 Plan - SteamVR Performance HUDs, Sensor Fan-In, and Overlay QoL Patch Packs

## Goal

Study performance and quality-of-life overlay utilities as references for
small but useful VR operator surfaces.

## Research Questions

- How should headset performance HUDs separate sensor providers, aggregation,
  rendering, and overlay placement?
- Which XSOverlay QoL patches reveal recurring friction points in overlay UX?
- Which parts are strong implementation donors versus product-direction
  evidence only?

## Shortlist

- `Karlan-Trade/VR-Performance-Profiler`
- `chaixshot/xsoverlay-tweak`

## Required Checks

- Deduplicate against prior performance tuning, overlay micro-surface, and
  XSOverlay utility waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep patch-pack caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 321.
- Registry/family entries for performance HUD and XSOverlay tweak donors.
- Method catalog entry for sensor-provider fan-in to VR operator HUDs.
