# GitHub Research Wave 308 Backlog - VR/3D Annotation, Point-Cloud Labeling, and Linked-Data Note Surfaces

## Executed Scope

- Searched and deduplicated VR annotation, point-cloud editing, and in-VR
  labeling projects.
- Froze a three-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted native plugin boundaries, point-cloud metadata, LOD/culling,
  closest-point and outlier operations, point-cloud/image sequence navigation,
  bounding-box label manipulation, class/quality dialogs, linked-data
  annotation JSON, local/REST persistence, and annotation tour navigation.

## Studied Projects

- `ahstevens/VR-Point-Cloud-Editor`
- `florianwirth/PointAtMe`
- `framefield/vr-annotate`

## Backlog Findings

- Build a matrix for annotation record fields: target ID, node path, world
  position, viewport pose, author, timestamp, class, quality, and external data
  ID.
- Deepen native point-cloud plugin boundaries without adopting project-specific
  binaries.
- Compare local JSON, REST sync, LAZ/custom point-cloud formats, and dataset
  folder conventions.
- Compare in-headset taxonomy dialogs with earlier menu/control and gaze
  interaction waves.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an annotation and point-cloud labeling method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
