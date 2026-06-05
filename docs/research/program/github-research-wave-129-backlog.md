# GitHub Research Wave 129 Backlog

- Date: `2026-06-05`
- Scope: VMC/VRM motion streams, OSC transform senders/receivers, and
  recording/export tools.

## Completed in this wave

- Studied `sh-akira/VirtualMotionCapture` as a full motion app with Unity
  runtime, WPF control panel, IPC, sender/receiver settings, and tracker
  management.
- Studied `sh-akira/VirtualMotionCaptureProtocol` as the canonical role-based
  OSC protocol and sample sender/receiver reference.
- Studied `gpsnmeajp/EasyVirtualMotionCaptureForUnity` as a Unity receiver
  package with filters, cutoffs, packet limiting, validation, and daisy-chain.
- Studied `sh-akira/QuestOSCTransformSender` as a simple Quest HMD/controller
  transform publisher.
- Studied `infosia/vmc2bvh` as a VMC-to-BVH and blendshape export utility.
- Studied `infosia/vmcrec` as a FlatBuffers-based VMC recorder/replay/dump
  utility.

## Reuse candidates

- `VirtualMotionCaptureProtocol` is the strongest protocol reference.
- `EasyVirtualMotionCaptureForUnity` is the strongest Unity receiver donor.
- `vmc2bvh` is the strongest stream-to-offline-export donor.
- `vmcrec` is the strongest typed motion-log donor.

## Follow-up backlog

1. Build a pose-stream protocol matrix across VMC, SlimeVR, VMT, MediaPipe,
   VRChat OSC, and OpenVR tracker exports.
2. Extract a minimal VMC receiver diagnostic panel concept.
3. Compare BVH export and FlatBuffers record/replay for future capture tools.
4. Revisit Quest transform sending if headset-local pose bridge prototypes
   become active.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
