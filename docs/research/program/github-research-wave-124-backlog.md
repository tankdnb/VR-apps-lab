# GitHub Research Wave 124 Backlog

- Date: `2026-06-05`
- Scope: VR treadmill, locomotion hardware, balance-board, BLE/serial/TCP, and
  virtual-controller bridge projects.

## Completed in this wave

- Studied `fer-sler/VR-Treadmill` as a minimal mouse-delta to virtual-gamepad
  bridge.
- Studied `TimStewartJ/vr-treadmill` as a more mature Windows adapter with
  settings, ViGEm readiness checks, decay/deadzone handling, and cleanup.
- Studied `Cycrus/slimstep_vr` as a load-cell to serial to OpenVR controller
  scalar input driver.
- Studied `jurassicjordan/GoobleBoxVR` as a Wii Balance Board adapter with
  standing, walking, flamingo, jump, and absence states.
- Studied `srepmub/tacovr` as a hardware-side treadmill control state machine.
- Studied `ssohbn/kittywalk-server` as a minimal TCP payload receiver.
- Studied `cybernetic-research/VR-treadmill-client-app` as a Unity/Quest
  controller-state relay.
- Studied `cybernetic-research/VR-treadmill-server-app` as an ESP32 BLE
  command/status firmware reference.

## Reuse candidates

- `TimStewartJ/vr-treadmill` is the strongest host-side donor for settings,
  driver readiness, status, cleanup, and virtual-gamepad output.
- `Cycrus/slimstep_vr` is the strongest runtime-side donor for sensor values
  exposed as OpenVR controller scalar inputs.
- `GoobleBoxVR` is a useful state-classification reference for balance-board
  and accessibility-style locomotion.
- `VR-treadmill-server-app` is a compact BLE command/status firmware reference.

## Follow-up backlog

1. Extract a generic hardware-input bridge checklist.
2. Compare treadmill state models against VR accessibility and simulator
   control sidecar projects.
3. Keep hardware-specific firmware as reference material unless a future
   prototype explicitly targets locomotion hardware.
4. If an input bridge prototype starts, add a dedicated reuse plan for
   `TimStewartJ/vr-treadmill` and `slimstep_vr`.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were used only as local study cache.
- Projects were documented as reusable patterns, not as dependencies.
