# GitHub Research Wave 224 Backlog

Date: 2026-06-06

Theme: XR research data lifecycle templates, validation, and analysis pipelines.

## Completed In This Wave

- Studied `ResXR/resxr-unity-research-template` as a Quest/Unity research
  template with persistent base scene, `ResXRPlayer`, scene manager, room
  calibration, session/task/trial flow, `ResXRDataManager`, custom CSV data
  classes, events, continuous tracking, face expression streams, live sample
  callbacks, and metadata.
- Studied `ResXR/resxr-python-pipeline` as the downstream half of the same
  lifecycle: YAML configuration, session discovery, continuous-data splitting,
  BIDS motion/events/channels output, validation registry, quality masking,
  derivative output, and reports.
- Studied `ixperience-lab/VRSTK` as a legacy scientific VR toolkit combining
  experiment phase control, tracking, biosignal/OSC/serial ingestion,
  questionnaires, replay, JSON import/export, and R/Python analysis templates.
- Deepened `eisclimber/ExPresS-XR` for data-gathering bindings, local/HTTP CSV
  export, periodic/input-triggered export, arbitrary component member binding,
  and editor-guided setup dialogs.
- Added a reusable method entry for XR research data lifecycles.

## Follow-Up Queue

1. Build an XR research data lifecycle matrix across Unity capture templates,
   downstream validation, biosignal streams, event markers, and editor setup
   helpers.
2. Compare ResXR event/session metadata with VRSTK stage/event replay and
   ExPresS-XR binding-driven data export.
3. Extract a small neutral schema proposal for `session`, `task`, `trial`,
   `event`, `continuous stream`, `quality flag`, and `metadata` fields.
4. Compare BIDS output with simpler CSV/JSON output for non-academic utility
   tools.
5. Revisit privacy and storage guidance before any future prototype records
   face, eye, body, or biometrics data.

## Do Not Spend Time On Yet

- Do not run Unity scenes, Python pipelines, or editor setup dialogs.
- Do not copy Quest/OVR-specific tracking code as a generic baseline.
- Do not treat BIDS as mandatory for every `VR-apps-lab` utility.
