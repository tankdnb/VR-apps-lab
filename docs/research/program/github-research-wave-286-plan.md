# GitHub Research Wave 286 Plan - Tilt Brush/Open Brush Creative Asset Pipelines, AR/Web Display, and Tilt Parsers

## Goal

Study Tilt Brush/Open Brush adjacent projects as reusable references for
creative XR asset pipelines: stroke capture, `.tilt` parsing, export,
preview/display, archive metadata, and provenance.

## Research Questions

- How do tools represent strokes, control points, brushes, thumbnails, and
  metadata?
- Which conversion and viewer boundaries are reusable for future VR asset
  browsers?
- How should shader/material restoration and license/provenance be documented?
- Which projects are code donors versus asset/archive references only?

## Shortlist

- `weeeBox/TiltBrushFile`
- `MrMMu/tiltbrushfbxexport`
- `FusedVR/ARKitTiltBrush`
- `dogtownmedia/ARKit-SceneKit-Paint-Tiltbrush-Demo`
- `thijsvb/TiltBrushDisplay`
- `arodic/polygone.art`
- `keijiro/Forestica`
- `PushyPixels/WebVR-Poly-Framework`

## Required Checks

- Deduplicate against prior Open Brush/Tilt asset, WebXR creative surface, and
  file/local asset browser waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep legacy SDK, dead Poly API, asset-heavy, and license/provenance caveats
  explicit.

## Expected Outputs

- Landscape synthesis for Wave 286.
- Registry/family entries for creative XR asset pipelines.
- Method catalog entry for creative asset parsing/export/display.
- Follow-up matrix around `.tilt`, brush metadata, conversion, preview,
  archive provenance, and shader/material restoration.
