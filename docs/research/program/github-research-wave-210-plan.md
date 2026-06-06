# GitHub Research Wave 210 Plan

Date: 2026-06-06

Theme: MediaPipe/avatar tracking sidecars, VRM/browser mappers, named-pipe bridges, and AI full-body tracker pipelines.

Research mode: static source reading only. No external repository was run, built, installed, or launched.

## Why This Wave Exists

Camera-inference sidecars are recurring donors for VR utilities because they turn commodity cameras into avatar, expression, body, or tracker signals. Wave 210 deepens projects that map MediaPipe or AI pose output into VRChat, VRM, Unity, or virtual tracker systems.

The aim is to extract normalization, mapping, tuning, and bridge patterns, not to validate tracking accuracy.

## Search Families

- MediaPipe face, hand, pose, and body tracking sidecars.
- VRChat/VRCFT OSC expression bridges.
- Browser VRM avatar diagnostics and mapping UIs.
- Unity named-pipe pose bridges.
- AI full-body tracking and virtual tracker generation.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `hotaru86/MediapipeFaceTracking_VRC` | MediaPipe Face Landmarker to VRChat/VRCFT OSC with ARKit mapping and tunable per-parameter ranges. | Face-expression OSC sidecar |
| `how-people-lived/mediapipe-vrm-tracking` | Browser MediaPipe to VRM avatar tracking, blendshape UI, mapping editor, and JSON export. | Browser avatar diagnostics |
| `Metastazius/VRBodyTrack` | Python/MediaPipe to Unity named-pipe body landmark bridge with joint-angle calculation. | Named-pipe body tracking bridge |
| `MasonSakai/VR-AI-Full-Body-Tracking` | Multi-camera AI FBT pipeline with browser camera pages, MoveNet, calibration, triangulation, and virtual tracker output. | AI full-body tracking bridge |

## Dedupe Notes

The projects overlap with already known tracker bridge and avatar tracking families. Wave 210 is a deepening pass focused on reusable signal normalization and mapping boundaries.

## Code-Level Pass Targets

- Camera/inference intake and model choice.
- Expression, landmark, or keypoint normalization.
- Mapping to target schemas such as VRCFT OSC, VRM expressions, Unity body joints, or virtual trackers.
- Configuration, per-parameter tuning, confidence gates, and persistence.
- Bridge transports: OSC, browser app state, named pipe, Qt/browser server, virtual tracker runtime.
- Repo hygiene and hardcoded-path caveats.

## Expected Outputs

- Wave 210 landscape synthesis.
- Registry/family deepening notes.
- Method catalog entry for camera inference to avatar/tracker signal normalizer.
- Follow-up backlog for clean sidecar architecture and diagnostics UI.
