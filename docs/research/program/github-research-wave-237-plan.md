# GitHub Research Wave 237 Plan

Date: 2026-06-06

Theme: WebXR depth, point-cloud, room-scan, and spatial dataset viewers.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Spatial sensing utilities are a natural next layer for `VR-apps-lab`: depth
capture, point clouds, hit-test measurement, lidar-like reveal mechanics,
Gaussian splat viewing, and dataset-scale XR panels all map to future
diagnostics, calibration, and data-viewer tools.

## Search Families

- WebXR depth-sensing and camera-access examples.
- Browser point-cloud capture and export.
- Room measurement and hit-test scanners.
- Lidar, Gaussian splat, and spatial dataset viewers.
- XR/streaming variants for large scientific scenes.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `Ramith-D-Rodrigo/webxr-point-cloud` | WebXR camera/depth capture into point clouds with worker path and GLTF export. | WebXR sensing donor |
| `Dhruvi509/Webxr-room-scanner` | Babylon WebXR AR hit-test measurement with anchor fallback and UI state. | Measurement micro-tool |
| `BSoDium/Lidar` | React/Three XR lidar-style ray grid and point-cloud reveal gameplay. | Simulated sensor reference |
| `sterngefeuert/webxr-gaussian-splat` | Three/WebXR Gaussian splat viewer with progressive loading and drag/drop. | Spatial asset viewer |
| `MikeWise2718/messelpit_viewer` | Omniverse Kit dataset viewer with XR/streaming variants and VR panel lessons. | Large spatial dataset reference |

## Dedupe Notes

Gaussian splat, media, and data visualization families have prior coverage.
This wave focuses on the sensing-to-viewer pipeline: WebXR depth/camera, point
sampling, measurement state, lidar reveal, splat ingestion, and large
scientific dataset operationalization.

## Code-Level Pass Targets

- WebXR session feature gates for depth and camera access.
- Depth and camera texture sampling.
- Workerized point-cloud reconstruction.
- Hit-test and anchor fallback state machines.
- XR viewer loading, progress, and fallback UI.
- Large-scene XR versus streaming split.

## Expected Outputs

- Wave 237 landscape synthesis.
- Registry/family entries for spatial sensing and dataset viewers.
- Method catalog entry for point-cloud/spatial-viewer pipelines.
- Follow-up backlog for a sensing/viewer comparison matrix.
