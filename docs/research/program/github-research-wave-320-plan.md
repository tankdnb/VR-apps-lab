# GitHub Research Wave 320 Plan - Declarative Overlay Frameworks, Free Overlay Shells, and Spatial Manipulation Clients

## Goal

Study projects that expose overlay and spatial UI surfaces as reusable
application shells rather than one-off panels.

## Research Questions

- How can a VR overlay framework separate widget trees, render trees, layer
  trees, and runtime overlay submission?
- What is reusable in small free/open overlay shells even when the
  implementation is prototype-like?
- How do spatial clients such as StardustXR tools model hand/ray selection and
  manipulation without reducing everything to flat panels?

## Shortlist

- `sumx21t-3310/FloatSoda`
- `DelfinVT-uwu/FreeOverlay`
- `Schmarni-Dev/absolute-solver`

## Required Checks

- Deduplicate against earlier SteamVR overlay, desktop-in-VR, and StardustXR
  waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep framework donor value separate from product-reference value.

## Expected Outputs

- Landscape synthesis for Wave 320.
- Registry and family entries for declarative overlay shells and spatial
  manipulation clients.
- Method catalog entry for overlay framework boundaries across UI tree,
  renderer, runtime overlay, and input.
