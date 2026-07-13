# GitHub Research Wave 340 Backlog - visionOS Native Spatial Rendering, WebXR Probes, and XR Provider Boundaries

## Executed Scope

- Searched and deduplicated native visionOS rendering, WebXR-on-visionOS, and
  Unity visionOS XR provider/package projects.
- Froze a four-project shortlist spanning Metal compositor rendering,
  Three.js/WebXR hand/audio probe behavior, Unity XR provider package seams,
  and SwiftUI/RealityKit sample microapps.
- Read source and documentation statically from local-only cache with LFS
  smudge disabled.
- Extracted compositor loop, ARKit world tracking, LayerRenderer access,
  project validation, image/object tracking build processors, hand data, and
  microapp UX patterns.

## Studied Projects

- `metal-by-example/metal-spatial-rendering`
- `chrisdubya/avp-threejs-webxr-test`
- `needle-mirror/com.unity.xr.visionos`
- `IvanCampos/visionOS-examples`

## Backlog Findings

- Treat visionOS compositor and provider code as platform-boundary reference,
  not as copy-paste app code.
- Add validation/checklist ideas for simulator versus device, LayerRenderer
  readiness, permissions, image/object resources, and ARSession requirements.
- Keep WebXR probes lightweight and explicit about browser support, microphone
  permissions, pinch events, and hand/controller fallback.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include studied projects.
- Method catalog captures visionOS render/provider decomposition.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
