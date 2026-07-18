# GitHub Research Wave 474 Plan

- Date: `2026-07-18`
- Theme: Quest camera CV inference and controller-defined visual search
  utilities.

## Frozen scope

- `daninloops/Quest3-Flask-Server-YOLO-Detection`
- `SemyanovVisuals/gigafind`
- `imranbsh13/autosim-ai`
- `WestCoastGod/XR-CV-Forceps-Tracking-Unity` as comparison anchor only

## Research questions

- How do Quest camera/CV tools separate capture, user intent, transport,
  inference, and in-headset result display?
- What is the reusable core of controller-defined visual search?
- Which security, privacy, calibration, and cloud-key caveats must be made
  visible before reuse?

## Required extraction

- camera permission and intrinsics boundary
- controller-to-camera or region-selection model
- sidecar transport and inference endpoint
- result schema for bbox/mask/label/pose outputs
- privacy, calibration, and API-key caveats
