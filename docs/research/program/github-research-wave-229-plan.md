# GitHub Research Wave 229 Plan

Date: 2026-06-06

Theme: Immersive data, robotics, and scientific visualization workbenches.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

The repository has many overlay and runtime utilities, but fewer high-signal
examples of data-first immersive tools. This wave studies projects where Python
or web data pipelines drive XR scenes, robotics models, scientific spaces,
teleoperation visualizations, and multi-format viewers.

## Search Families

- WebXR data visualization workbenches.
- Python-to-XR scene bridges.
- Robotics and URDF/MJCF/USD viewers.
- Scientific collaboration and callout rooms.
- Data-to-spatial-encoding pipelines.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `vuer-ai/vuer` | Python async event bridge to browser/WebXR scenes with robotics and teleoperation examples. | Python-to-XR scene bridge |
| `thomann/plotAR` | QR-paired immersive plot artifact with WebSocket controller/keyboard path and export support. | Data artifact to VR viewer |
| `TsatsuAmable/nemosyne` | Data-native A-Frame/WebXR visualization engine with semantic mapping and transform DSL. | Spatial data encoding pipeline |
| `smrghsh/brahma` | Shared scientific WebXR room shell with avatars, callouts, grasp/select modules, and networking. | Collaborative visualization shell |
| `jurmy24/mechaverse` | Multi-format browser robotics viewer for URDF, MJCF, and USD dispatch. | Robotics viewer dispatch reference |

## Dedupe Notes

This wave avoids re-studying generic WebXR framework repos and focuses on
data/robotics/science workbenches where the reusable lesson is the data-to-scene
or file-to-viewer boundary.

## Code-Level Pass Targets

- Python/WebSocket scene-delta bridges.
- QR or URL pairing for generated immersive artifacts.
- Semantic field mapping, layout engines, and transform DSLs.
- Collaborative avatar/callout/event state.
- Robotics file detection and viewer dispatch.
- Security, transport, browser, and data privacy caveats.

## Expected Outputs

- Wave 229 landscape synthesis.
- Registry/family entries for immersive data workbenches.
- Method catalog entry for data-to-spatial-encoding pipelines.
- Follow-up backlog for data/robotics visualization matrices.
