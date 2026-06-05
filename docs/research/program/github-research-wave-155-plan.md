# GitHub Research Wave 155 Plan

- Date: `2026-06-05`
- Theme: `Hand tracking, simulated XR hands, and reusable hand/control primitives`
- Scope: hand tracking extension bridges, no-HMD hand simulators, gesture-pose
  packages, and broader XR toolkit primitives for data gathering, value ranges,
  sockets, and menus.

## Why This Wave Exists

Recent hand-focused waves covered WebXR hand input and browser data bridges.
Wave 155 complements that with engine/native patterns: Unity OpenXR extension
hooks for hand joints and meshes, editor-side hand simulation, source-light
gesture packages, and a deeper pass over scientific XR toolkit primitives.

## Search Families

- Unity OpenXR hand tracking extensions
- no-HMD hand/control simulation
- gesture pose and hand animation packages
- Unity XR interaction/toolkit primitives
- data gathering and scientific/exhibition XR utilities
- sockets, value-range interactables, menu factories, and setup flows

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `joemarshall/openxrhands` | Unity OpenXR feature bridge for hand joints and Oculus hand mesh extension | Native/engine hand tracking bridges |
| `MThogersen/AutoHandSimulator` | Keyboard/mouse hand and body simulation for AutoHand/Mock HMD workflows | No-HMD hand simulation |
| `InfernoDigital/RoboHands-UnityXR` | Source-light gesture-pose package with useful hand-pose inventory framing | Gesture-pose package references |
| `eisclimber/ExPresS-XR` | Broad toolkit deepening around data gathering, value ranges, sockets, menus, and setup helpers | Unity XR toolkit primitives |

## Dedupe Notes

- `ExPresS-XR` was already partially studied; this wave deepens it only for
  data, interaction primitive, socket, menu, and toolkit-pattern extraction.
- `RoboHands-UnityXR` is source-light and uses external package/demo links, so
  it is treated as product reference only.
- This wave intentionally avoids redoing WebXR hand-tracking projects from
  Wave 144.

## Code-Level Pass Targets

- OpenXR extension hook and P/Invoke boundary.
- Predicted display time handling.
- Hand mesh/joint data conversion.
- Simulated pose driver replacement and keyboard/mouse control mapping.
- Toolkit data gathering, value-range, socket, and menu factory patterns.
- Source-light and package-access caveats.

## Expected Outputs

- New Wave 155 landscape synthesis.
- Registry/family updates for hand tracking and hand-control primitives.
- Methods around OpenXR hand extension bridges, no-HMD hand simulation, and
  scientific XR toolkit composition.
