# GitHub Research Wave 294 Plan - WebXR Hand-Tracking Primitives, Emulation, MIDI, and Hand-Driven Utilities

## Goal

Study WebXR hand-tracking projects as reusable references for hand joint
sampling, gesture recognition, worker-backed pose matching, browser emulation,
hand physics, hand-to-command output, palm menus, and lightweight starter app
boundaries.

## Research Questions

- How do projects separate joint acquisition, gesture recognition, UI actions,
  and external side effects?
- What is reusable in WebXR hand emulation and headsetless testing?
- How are hand menus, poke/pinch actions, MIDI, and WebSocket transports framed?
- Which small starter projects clarify the minimum viable architecture?

## Shortlist

- `AdaRoseCannon/handy-work`
- `mrdoob/webxr-webcam-emulator`
- `fcor/hand-tracking-butane`
- `miguelppais/airbender-webxr-midi`
- `RichardMeng1/custom-hand-gaze-webxr`
- `tatta-chotdog/webxr-hands-starter`

## Required Checks

- Deduplicate against earlier WebXR hand, menu, and UI toolkit waves.
- Sync sources only into local-only cache.
- Read source statically; do not run, build, install, or launch projects.
- Extract mandatory project fields and reusable pattern bridge fields.
- Keep browser permissions, camera privacy, threshold, transport, and demo
  caveats explicit.

## Expected Outputs

- Landscape synthesis for Wave 294.
- Registry/family entries for WebXR hand primitives and hand-driven utilities.
- Method catalog entry for WebXR hand utility/emulation/control boundaries.
- Follow-up gaps around pose schemas, emulation, palm menus, and command
  adapters.
