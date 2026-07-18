# GitHub Research Wave 476 Plan

- Date: `2026-07-18`
- Theme: Gaze, eye-tracking, and gaze-analysis utility surfaces.

## Frozen Scope

- `Haddley/vision-eye-tracking`
- `Adkaros/VR-GazeControl`
- `eman2XR/VR-Gaze-pointer-and-buttons`
- `xyethan/OcuShape`
- `ni1o1/vr-gaze-pipeline`

## Research Questions

- How do gaze utilities separate gaze provider, target lifecycle, dwell intent,
  and visible feedback?
- Which fields are needed to make eye/gaze data reusable without hiding privacy
  or calibration state?
- Where is gaze useful as live input and where is it better treated as offline
  analysis evidence?

## Required Extraction

- gaze provider and sample schema
- dwell target lifecycle
- reticle/progress/audio feedback
- confidence/stale/calibration state
- fixation and semantic label pipeline
- privacy, retention, and source caveats
