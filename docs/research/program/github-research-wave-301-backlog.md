# GitHub Research Wave 301 Backlog - Quest Passthrough Camera Wrappers, Permissions, Capture, and QR World Tracking

## Executed Scope

- Searched and deduplicated Quest camera wrapper, camera permissions, QR
  tracking, and camera-object-world-state projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted permission/support gates, Android Camera2 wrapper structure,
  continuous capture session callbacks, YUV/WebCamTexture conversion, QR
  decode/raycast/filter loops, marker pooling, tracked taxon reliability, and
  privacy-sensitive camera/object surfaces.

## Studied Projects

- `xrdevrob/QuestCameraKit`
- `Uralstech/UXR.QuestCamera`
- `HoloLabInc/QuestCameraTools-Unity`
- `oculus-samples/Unity-SpatialLingo`

## Backlog Findings

- Deepen `UXR.QuestCamera`, `QuestCameraTools-Unity`, and
  `Unity-SpatialLingo` as strongest donors.
- Build a Quest camera matrix across permission, support gate, camera source,
  frame format, conversion, metadata, detection, world placement, and privacy.
- Compare HoloLab and Uralstech wrappers with official Meta camera samples.
- Consider a reuse plan for a camera diagnostic/marker toolkit.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a Quest camera wrapper/world-tracking method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
