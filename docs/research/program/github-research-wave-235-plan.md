# GitHub Research Wave 235 Plan

Date: 2026-06-06

Theme: Browser-native WebXR drawing, whiteboard, and creative surfaces.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Creative WebXR tools are useful as reusable interaction donors even when the
product itself is not a utility. This wave looks for browser-native drawing,
whiteboard, sketch, measurement, palette, brush, stroke, and collaborative
creative-surface patterns that can be reused in future VR utilities.

## Search Families

- WebXR whiteboards and drawing probes.
- 3D paint tools and brush engines.
- VR tool menus, color pickers, rulers, and shape placement.
- Shared/collaborative stroke transports.
- Browser-native creative workbench surfaces.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `localtoast42/webxr-whiteboard` | Thin WebXR interaction probe with controller model, grip/ray spaces, and object hit testing. | Micro-interaction probe |
| `felixtrz/canvrs` | Elixr/Three AR painting tool with multitool model, pressure strokes, eraser, colors, and line bounding boxes. | WebXR paint micro-tool |
| `n1ckfg/LightningLoops` | Networked LATK stroke animation with socket.io frame exchange, generative turtle morphs, and Magenta input. | Collaborative/generative stroke surface |
| `nuonical/webxr-babylon` | Babylon playground with WebXR controller drawing, palette, tube/ribbon/metaball strokes, chunking, limits, and tests. | Browser-native creative workbench |
| `sierrajanson/Harold-in-VR` | A-Frame drawing/prototyping tool with menu, color wheel, ruler, shapes, grid, and mode isolation. | VR drawing tool/menu reference |
| `cpufreestyle/vr-paint` | A-Painter fork preserving brush registration, shared buffer geometry, .apa/.json save/load, upload, and controller mappings. | Mature brush/storage donor |

## Dedupe Notes

Open Brush, Tilt Brush, Vartiste, A-Painter, and broader creative tools are
already represented. This wave focuses on additional browser-native variants
and smaller project-level patterns that were not yet in the registry.

## Code-Level Pass Targets

- Controller input and pressure mapping.
- Brush/stroke point storage and geometry rebuilding.
- Eraser, palette, tool mode, and menu gating.
- Save/load, share, and stroke transport.
- Measurement, shape placement, and UI feedback patterns.
- Performance limits, chunking, and cleanup.

## Expected Outputs

- Wave 235 landscape synthesis.
- Registry/family entries for browser-native creative surfaces.
- Method catalog entry for WebXR creative stroke workbench boundaries.
- Follow-up backlog for brush/menu/storage comparison.
