# GitHub Research Wave 332 Plan - A-Frame VR UI Primitives, DOM Surfaces, and In-Scene Input Widgets

## Goal

Study small A-Frame/WebXR UI components that turn 2D interface ideas into
in-scene VR primitives: HTML-to-plane rendering, flex-like 2D layouts, virtual
keyboards, text input, and pop-up dialogs.

## Research Questions

- Which browser UI primitives are reusable for VR overlay-like utility panels?
- How do projects translate raycaster/controller events into DOM, text, and
keyboard interactions?
- Which pieces are donor-worthy as patterns rather than packages?

## Shortlist

- `supereggbert/aframe-htmlembed-component`
- `binzume/aframe-xylayout`
- `WandererOU/aframe-keyboard`
- `EditVR/aframe-dialog-popup-component`

## Required Checks

- Deduplicate against A-Frame GUI, WebXR keyboard, and browser UI waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.
- Separate mature donor patterns from old component packaging.

## Expected Outputs

- Landscape synthesis for Wave 332.
- Registry/family entries for studied projects.
- Method catalog entry for browser-native VR UI primitive layering.
