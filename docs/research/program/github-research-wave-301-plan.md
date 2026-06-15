# GitHub Research Wave 301 Plan - Quest Passthrough Camera Wrappers, Permissions, Capture, and QR World Tracking

## Goal

Study Quest camera wrapper and QR/world-tracking projects as reusable
references for permission gates, camera device/session boundaries, frame
conversion, metadata, marker pools, QR detection, environment raycasts, tracked
world detections, and privacy-aware camera utility design.

## Research Questions

- How do projects expose Quest/HorizonOS support and camera permissions?
- Which camera APIs are wrapped as WebCamTexture, native Camera2 sessions, or
  higher-level sample utilities?
- How are frame metadata, camera pose, QR/object detections, raycasts, markers,
  and tracked world state separated?
- Which parts are reusable package boundaries versus sample-only product code?

## Shortlist

- `xrdevrob/QuestCameraKit`
- `Uralstech/UXR.QuestCamera`
- `HoloLabInc/QuestCameraTools-Unity`
- `oculus-samples/Unity-SpatialLingo`

## Required Checks

- Deduplicate against existing Meta passthrough camera, MRUK, QR, and marker
  tracking waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Extract permission/support, capture/session, conversion, metadata,
  detection, placement, privacy, and caveat fields.

## Expected Outputs

- Landscape synthesis for Wave 301.
- Registry/family entries for Quest camera wrappers and QR/world tracking.
- Method catalog entry for Quest camera capture and world tracking boundaries.
- Follow-up gaps around camera diagnostics and marker/QR tracking utilities.
