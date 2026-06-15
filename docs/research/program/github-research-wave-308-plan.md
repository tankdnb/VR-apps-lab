# GitHub Research Wave 308 Plan - VR/3D Annotation, Point-Cloud Labeling, and Linked-Data Note Surfaces

## Goal

Study VR annotation, point-cloud editing, and 3D labeling projects as reusable
references for spatial notes, target selectors, geometry handles, label
schemas, local/remote persistence, provenance, and revisit/navigation flows.

## Research Questions

- How do projects separate dataset import from annotation UX?
- Which geometry operations are exposed to the VR shell and which stay in a
  plugin or data-service boundary?
- How are annotation records shaped across target ID, world position, viewport
  pose, label taxonomy, author, and timestamp?
- What can be reused for future spatial review, QA, training, and data-labeling
  utilities?

## Shortlist

- `ahstevens/VR-Point-Cloud-Editor`
- `florianwirth/PointAtMe`
- `framefield/vr-annotate`

## Required Checks

- Deduplicate against earlier point-cloud, menu/control, diagnostics, and
  review-tool waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep native plugin, hardcoded path, REST/auth, and legacy VR dependency
  caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 308.
- Registry/family entries for annotation and point-cloud labeling tools.
- Method catalog entry for annotation/labeling boundaries.
- Follow-up gaps for annotation schema, geometry services, and persistence.
