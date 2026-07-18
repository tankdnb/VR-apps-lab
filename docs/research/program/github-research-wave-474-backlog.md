# GitHub Research Wave 474 Backlog

- Date: `2026-07-18`
- Status: completed.

## Completed

- Dedupe checked against prior Quest camera, device-camera operator, OpenQuest,
  and marker/CV tracking families.
- Studied minimal Flask/YOLO polling sidecar, Quest/SAM2/Groq controller-defined
  segmentation pipeline, early AutoSim CV/VR roadmap, and forceps tracking as an
  existing comparison anchor.
- Added method `Controller-defined camera/CV inference sidecar and result
  surface`.

## Follow-up

- Create a unified CV result schema across detection bbox, segmentation mask,
  object label/description, and tracked pose.
- Add calibration UI requirements for controller/world-to-camera projection
  offsets.
- Document cloud/sidecar privacy gates for camera-frame upload and API-key
  handling.
