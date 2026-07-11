# GitHub Research Wave 319 Plan - Stereo Display-Surface Viewers, Depth Conversion, and Spatial-Display Runtimes

## Goal

Study viewer-style XR utilities as reusable references for flat-to-stereo
transforms, runtime-driven display geometry, shared control planes, and
secondary composition layers.

## Research Questions

- How do strong viewer tools separate source capture or ingest from runtime
  output?
- What control-plane patterns recur across GUI/viewer splits and spatial-display
  runtime plugins?
- Which projects are strongest as display/view-rig donors versus viewer-only
  product references?
- What interaction or layout ideas matter most for display-centric tools?

## Shortlist

- `Bastian-Noel/DepthVistaXR`
- `BerZerker96/Osiris-Vr-Viewer`
- `DisplayXR/displayxr-unity`
- `DisplayXR/displayxr-demo-gaussiansplat`

## Required Checks

- Deduplicate against earlier video/viewer, virtual-display, and Gaussian-splat
  waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep transform-pipeline, shared-memory, runtime-geometry, and source-specific
  caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 319.
- Registry/family entries for stereo/display-surface viewer donors.
- Method catalog entry for stereo/display-surface viewer boundaries.
- Follow-up gaps for shared control planes, `XR_EXT_view_rig`, and 2D-on-3D
  composition reuse.
