# GitHub Research Wave 286 Backlog - Tilt Brush/Open Brush Creative Asset Pipelines, AR/Web Display, and Tilt Parsers

## Executed Scope

- Searched and deduplicated Tilt Brush/Open Brush parsers, exporters, display
  surfaces, AR drawing baselines, and Poly archive references.
- Froze an eight-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted `.tilt` archive parsing, brush/control-point schema, FBX export
  metadata, AR camera-position painting, SceneKit line drawing, Processing OBJ
  preview, Poly archive provenance, and Unity/WebVR package caveats.

## Studied Projects

- `weeeBox/TiltBrushFile`
- `MrMMu/tiltbrushfbxexport`
- `FusedVR/ARKitTiltBrush`
- `dogtownmedia/ARKit-SceneKit-Paint-Tiltbrush-Demo`
- `thijsvb/TiltBrushDisplay`
- `arodic/polygone.art`
- `keijiro/Forestica`
- `PushyPixels/WebVR-Poly-Framework`

## Backlog Findings

- Build a Tilt/Open Brush creative asset matrix across `.tilt` parsing, stroke
  control points, brush IDs, geometry export, shader/material restoration,
  AR/Web display, Poly archive metadata, and provenance/license gates.
- Deepen `weeeBox/TiltBrushFile` as the strongest `.tilt` parsing donor.
- Deepen `MrMMu/tiltbrushfbxexport` for export metadata and brush grouping,
  while treating it as legacy.
- Explore whether `polygone.art` metadata can support a VR-native asset
  browser with explicit license and author display.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a creative XR asset pipeline method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
