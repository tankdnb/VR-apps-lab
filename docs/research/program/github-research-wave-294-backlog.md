# GitHub Research Wave 294 Backlog - WebXR Hand-Tracking Primitives, Emulation, MIDI, and Hand-Driven Utilities

## Executed Scope

- Searched and deduplicated WebXR hand tracking, webcam emulation, hand-driven
  MIDI/control, hand physics, palm-menu, and starter projects.
- Froze a six-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted worker-backed pose detection, A-Frame handy controls, webcam
  MediaPipe polyfill, Cannon hand physics, spatial MIDI mapping UI, palm-up
  menus, gaze ray extraction, WSS relay tests, and minimal hand gesture
  managers.

## Studied Projects

- `AdaRoseCannon/handy-work`
- `mrdoob/webxr-webcam-emulator`
- `fcor/hand-tracking-butane`
- `miguelppais/airbender-webxr-midi`
- `RichardMeng1/custom-hand-gaze-webxr`
- `tatta-chotdog/webxr-hands-starter`

## Backlog Findings

- Build a WebXR hand utility matrix across joint sampling, gesture thresholds,
  pose files, workers, palm menus, emulators, Web MIDI, WebSocket, and privacy.
- Deepen `handy-work`, `webxr-webcam-emulator`, and
  `custom-hand-gaze-webxr` as strongest reusable donors.
- Compare with earlier WebXR hand/menu waves so hand input, menu UI, and
  transport patterns do not duplicate each other.
- Consider a future reuse plan for a browser-native hand debug panel with
  pose viewer, gesture events, emulation toggle, and command output adapters.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a WebXR hand utility/emulation/control method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
