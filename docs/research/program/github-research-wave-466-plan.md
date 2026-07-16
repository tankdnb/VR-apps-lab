# GitHub Research Wave 466 Plan

- Date: `2026-07-16`
- Theme: XR telepresence video and robot overlay stacks.

## Frozen scope

- `microsoft/Virtual-Robot-Overlay-for-Online-Meetings`
- `microsoft/MixedReality-WebRTC`
- `epiception/Virtual-Telepresence`
- `unitreerobotics/xr_teleoperate` as existing overlap reference
- `aadhithya14/Open-Teach` as existing overlap reference

## Research questions

- How do telepresence stacks split video, signaling, events, VR viewer, AR
  overlay, and robot actuation?
- What relay/sidecar pattern is reusable for future VR operator tools?
- What should not be copied due to old hardware, deprecated dependencies, or
  unsafe command surfaces?

## Required extraction

- component split
- transport/signaling model
- robot command surface
- caveats and safety boundaries
- method action for XR telepresence relay stacks

