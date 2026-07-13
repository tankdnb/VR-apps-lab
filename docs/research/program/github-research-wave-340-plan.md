# GitHub Research Wave 340 Plan - visionOS Native Spatial Rendering, WebXR Probes, and XR Provider Boundaries

## Goal

Study visionOS native rendering and provider-level projects that expose reusable
patterns for compositor-facing render loops, WebXR/browser probes, and Unity
visionOS XR package boundaries.

## Research Questions

- How do visionOS samples separate ARKit world tracking, compositor timing,
  stereo drawables, Metal rendering, and immersive-space UI?
- What should a browser/WebXR probe capture on Apple Vision Pro?
- Which Unity visionOS package seams are useful as validation, provider, and
  build-processing references?

## Shortlist

- `metal-by-example/metal-spatial-rendering`
- `chrisdubya/avp-threejs-webxr-test`
- `needle-mirror/com.unity.xr.visionos`
- `IvanCampos/visionOS-examples`

## Required Checks

- Deduplicate against prior `openimmersive`, Meta passthrough, WebXR, and
  visionOS notes.
- Sync source only into local-only cache with LFS smudge disabled.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.
- Treat sample apps as platform references unless reusable code boundaries are
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 340.
- Registry/family entries for visionOS native render and provider references.
- Method catalog entry for compositor-facing visionOS render/provider
  decomposition.
