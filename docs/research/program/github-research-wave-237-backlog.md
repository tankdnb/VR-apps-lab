# GitHub Research Wave 237 Backlog

Date: 2026-06-06

Theme: WebXR depth, point-cloud, room-scan, and spatial dataset viewers.

## Completed In This Wave

- Studied `Ramith-D-Rodrigo/webxr-point-cloud` as a WebXR camera/depth pipeline
  with `unbounded`, `depth-sensing`, `camera-access`, and `dom-overlay`
  features, `XRWebGLBinding.getCameraImage`, CPU depth reads, camera
  framebuffer readback, randomized sample starts, worker reconstruction,
  Three point meshes, and GLTF export.
- Studied `Dhruvi509/Webxr-room-scanner` as a compact Babylon AR measurement
  tool with hit-test, anchor fallback, first/second point state, live preview
  line, and distance label.
- Studied `BSoDium/Lidar` as a React/Three XR lidar-ray grid with square
  raycaster arrays, visible hit/miss arrows, BVH-backed intersection intent,
  point-budget caveats, and terrain shader feedback.
- Studied `sterngefeuert/webxr-gaussian-splat` as a WebXR splat viewer with
  shared renderer/scene/camera, progressive loading, AR/VR button support,
  DOM overlay, drag/drop local file support, query-param loading, and desktop
  fallback controls.
- Studied `MikeWise2718/messelpit_viewer` as an Omniverse Kit spatial dataset
  viewer with separate desktop, streaming, and XR `.kit` apps, OpenXR startup
  diagnostics, in-VR floating panels, shared viewpoint controls, and
  RTX/Quest/driver caveats.
- Added a reusable method entry for spatial sensing and point-cloud XR viewer
  pipelines.

## Follow-Up Queue

1. Compare WebXR depth/camera capture, hit-test measurement, lidar ray grids,
   Gaussian splats, and dataset-scale viewers as a single spatial sensing
   matrix.
2. Extract a reusable `capture -> sample -> reconstruct -> render -> export`
   point-cloud pipeline with memory and worker boundaries.
3. Compare progressive loading and fallback UI across splats, point clouds,
   and large USD/Omniverse viewers.
4. Turn the Messelpit OpenXR startup lessons into a general XR startup
   diagnostics checklist.

## Do Not Spend Time On Yet

- Do not run browser or Omniverse demos.
- Do not copy large datasets, meshes, screenshots, or generated USD files.
- Do not treat a measurement demo as a full room scanner without evidence.
