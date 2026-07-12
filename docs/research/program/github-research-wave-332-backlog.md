# GitHub Research Wave 332 Backlog - A-Frame VR UI Primitives, DOM Surfaces, and In-Scene Input Widgets

## Executed Scope

- Searched and deduplicated A-Frame/WebXR UI primitive projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted DOM-to-canvas plane rendering, raycaster coordinate mapping,
  flex-like in-scene layout, text input caret handling, virtual keyboard
  dispatch, dialog placement, and camera-facing popup behavior.

## Studied Projects

- `supereggbert/aframe-htmlembed-component`
- `binzume/aframe-xylayout`
- `WandererOU/aframe-keyboard`
- `EditVR/aframe-dialog-popup-component`

## Backlog Findings

- Treat HTML-to-texture and ray-to-DOM translation as a reusable overlay-panel
  method.
- Keep layout, input, keyboard, and dialog as separate primitives rather than a
  single monolithic UI package.
- Record old dependency and maintenance caveats before copying any component
  directly.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog captures browser-native VR UI primitive layering.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
