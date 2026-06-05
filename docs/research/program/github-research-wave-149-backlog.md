# GitHub Research Wave 149 Backlog

- Date: `2026-06-05`
- Scope: immersive analytics, graph visualization, scientific viewer shells,
  XR input mapping, snapshots, and notebook bridges.

## Completed in this wave

- Studied `vriajs/vria` as a React/A-Frame immersive analytics grammar with
  config compilation, spatial views, marks, axes, legends, filters, selection,
  and builder UI concepts.
- Studied `vasturiano/3d-force-graph-vr` as an A-Frame scene shell around a VR
  force graph with controller/mouse raycasters and camera-attached tooltips.
- Studied `vasturiano/aframe-forcegraph-component` as an A-Frame component
  wrapper around `three-forcegraph` with accessor schemas, JSON/function
  parsers, hover, click, loading text, and raycaster integration.
- Studied `molstar/molstar` as a large scientific viewer plugin shell with
  managers, commands, state snapshots, Canvas3D parameters, and WebXR input
  mapping.
- Studied `widgetti/ipyvolume` as a Jupyter widget bridge for 3D scatter,
  mesh, and volume visualization with synced traitlets, data serialization,
  texture tiling, stereo/panorama options, and embed exports.

## Reuse candidates

- `vria` is the strongest donor for an immersive analytics grammar and
  spatial-view compiler.
- `3d-force-graph-vr` is the strongest product reference for quickly placing
  data graphs in an XR scene shell.
- `aframe-forcegraph-component` is the strongest small donor for an
  accessor-schema A-Frame component.
- `Mol*` is the strongest architecture donor for viewer managers, snapshots,
  plugin state, XR input, and scientific interaction.
- `ipyvolume` is the strongest donor for notebook-to-WebGL data transport and
  texture tiling.

## Follow-up backlog

1. Extract a `VR diagnostics visualization grammar` note from `vria`,
   force-graph accessors, and Mol* snapshots.
2. Compare camera-attached tooltips, legends, and labels against overlay/HUD
   families.
3. Track notebook/widget bridges as a potential route for offline data
   analysis feeding VR tools.
4. Compare WebXR scientific viewer state snapshots with runtime replay,
   session capture, and diagnostics waves.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
