# GitHub Research Wave 319 Backlog - Stereo Display-Surface Viewers, Depth Conversion, and Spatial-Display Runtimes

## Executed Scope

- Searched and deduplicated stereo-viewer, display-surface, and spatial-display
  runtime projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted desktop/window ingress, depth-to-stereo transforms, OpenXR output
  loops, shared-memory control planes, camera-centric vs display-centric rig
  boundaries, and local 2D composition layers.

## Studied Projects

- `Bastian-Noel/DepthVistaXR`
- `BerZerker96/Osiris-Vr-Viewer`
- `DisplayXR/displayxr-unity`
- `DisplayXR/displayxr-demo-gaussiansplat`

## Backlog Findings

- Compare shared-memory viewer control with file- and socket-based control
  planes in adjacent viewer families.
- Revisit `DisplayXR` against other explicit view-rig or spatial-display
  runtime stacks.
- Deepen the 2D-on-3D composition boundary across Unity and non-Unity viewer
  implementations.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a stereo/display-surface viewer method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
