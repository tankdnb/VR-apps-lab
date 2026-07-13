# GitHub Research Wave 341 Plan - visionOS Unity Plugin Bridges, WebView Surfaces, and Controller Adapters

## Goal

Study visionOS Unity-side plugin/adaptation projects that bridge Apple
frameworks, web surfaces, external controllers, and template/checklist
packaging into XR utilities.

## Research Questions

- How do Unity visionOS projects package Apple framework bridges and build
  steps?
- What does a practical visionOS webview surface need besides a prefab?
- How do third-party controller adapters map existing VR input APIs onto
  Apple Vision Pro?

## Shortlist

- `apple/unityplugins`
- `vuplex/visionos-metal-webview-example`
- `surreal-interactive/SDK`
- `TonGarcia/UnityVisionVRTemplate`

## Required Checks

- Deduplicate against prior WebView, Meta/Quest, and `openimmersive` waves.
- Sync source only into local-only cache with LFS smudge disabled.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.
- Distinguish package architecture from commercial/vendor plugin caveats.

## Expected Outputs

- Landscape synthesis for Wave 341.
- Registry/family entries for visionOS Unity plugin bridges and adapters.
- Method catalog entry for visionOS Unity adapter packaging.
