# VR Projects Wave 129: VMC/VRM Motion-Capture Protocol, OSC Transform Receivers, and Recording/Export Tools

- Date: `2026-06-05`
- Goal: study VMC Protocol and adjacent utilities as reusable motion stream
  architecture for VRM avatars, OSC transforms, external trackers, recording,
  replay, and BVH export.

## Why this wave exists

Many VR utility ideas need a simple way to move pose data between apps. VMC is
valuable because it is not just one app; it is a protocol family:

- OSC/UDP motion messages;
- performer, assistant, and marionette roles;
- root, bone, tracker, HMD, controller, camera, blendshape, and status
  messages;
- Unity receiver/sender components;
- stream validation, packet limiting, filters, and daisy-chain receivers;
- recording, replay, and BVH export.

## Better workflow used in this wave

1. searched by VMC, VRM, OSC transform, mocap receiver, BVH export, and motion
   recorder families;
2. deduplicated against VRChat OSC, tracker bridge, MediaPipe, SlimeVR, and VMT
   waves;
3. froze a protocol-centered shortlist;
4. inspected local-only source clones;
5. separated core protocol value from app-specific avatar tooling;
6. extracted reusable stream and export methods.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `sh-akira/VirtualMotionCapture` | Full VMC app with control panel, sender/receiver, IPC, and tracker settings |
| `sh-akira/VirtualMotionCaptureProtocol` | Canonical VMC protocol docs and sample sender/receiver scripts |
| `gpsnmeajp/EasyVirtualMotionCaptureForUnity` | Unity receiver package with filters, cutoffs, daisy-chain, and validators |
| `sh-akira/QuestOSCTransformSender` | Quest-side OSC transform sender reference |
| `infosia/vmc2bvh` | VMC stream to BVH and blendshape export CLI |
| `infosia/vmcrec` | VMC stream record/replay using FlatBuffers |

## Deep-pass notes by project

## `sh-akira/VirtualMotionCapture`

- GitHub:
  [sh-akira/VirtualMotionCapture](https://github.com/sh-akira/VirtualMotionCapture)
- What it is:
  a Unity-based motion capture and VRM avatar app with a WPF control panel and
  VMC Protocol support.
- Interesting idea:
  motion utilities benefit from a split between VR scene/runtime, desktop
  control panel, memory-mapped IPC, OSC sender/receiver settings, and tracker
  assignment/config windows.
- Code-level notes:
  the repo contains Unity scene/scripts, `ControlWindowWPF`, build root files,
  OpenVR plugin files, and `UnityMemoryMappedFile`. `ControlWPFWindow.cs`
  exposes external motion sender/receiver toggles, address/port/period
  changes, receiver list management, recenter commands, MIDI/blendshape
  settings, tracking filters, virtual motion tracker setup, and tracker moved
  notifications. The IPC command layer keeps desktop UI and Unity runtime
  loosely coupled.
- Code donor value:
  high for companion control-panel plus runtime bridge architecture.
- Product reference value:
  high for motion utility UX and settings breadth.
- Caveats:
  large Unity app; reuse should focus on boundaries, not whole-app code.
- What to inspect next:
  compare its receiver management with EVMC4U's component-level receiver
  approach.

## `sh-akira/VirtualMotionCaptureProtocol`

- GitHub:
  [sh-akira/VirtualMotionCaptureProtocol](https://github.com/sh-akira/VirtualMotionCaptureProtocol)
- What it is:
  documentation and Unity samples for VMC Protocol.
- Interesting idea:
  define motion exchange as a role-based OSC protocol rather than a single app
  integration.
- Code-level notes:
  protocol docs describe OSC over local UDP, default Marionette/Performer
  ports, partial implementation tolerance, UTF-8 strings, bundle size
  expectations, adjustable send periods, unknown-message ignoring, and role
  separation. `SampleBonesReceive.cs` applies `/VMC/Ext/Root/Pos`,
  `/VMC/Ext/Bone/Pos`, `/VMC/Ext/Blend/Val`, and `/VMC/Ext/Blend/Apply` to a
  VRM1 model. `SampleTrackerSend.cs` sends virtual HMD/controller/tracker
  transforms and blendshape values.
- Code donor value:
  very high for a simple, typed pose-stream protocol.
- Product reference value:
  very high for interoperability-first motion tooling.
- Caveats:
  local-network assumptions and need for robust validation in hostile networks.
- What to inspect next:
  build a compact protocol matrix across VMC, SlimeVR, VMT, VRChat OSC, and
  MediaPipe bridges.

## `gpsnmeajp/EasyVirtualMotionCaptureForUnity`

- GitHub:
  [gpsnmeajp/EasyVirtualMotionCaptureForUnity](https://github.com/gpsnmeajp/EasyVirtualMotionCaptureForUnity)
- What it is:
  a Unity package for receiving VMC Protocol data and applying it to VRM
  avatars.
- Interesting idea:
  a reusable receiver should expose packet limiting, freeze, root options,
  blendshape sync, bone-position sync, cutoffs, low-pass filters, auto VRM
  load hooks, late-update overwrite mode, and daisy-chain forwarding.
- Code-level notes:
  `ExternalReceiver.cs` has inspector-exposed options for freezing, packet
  limiting, root position/rotation/scale synchronization, blendshape and bone
  options, hand/eye/body/leg/arm cutoffs, filters, auto-loading, calibration
  behavior, status counters, dropped packet counts, and next-receiver chaining.
  `ExternalReceiverManager.cs` forwards messages across receivers with an
  infinite-loop guard. `CommunicationValidator.cs` captures status, calibration
  state, receiver port/path, window attributes, and displays optional on-screen
  receive state.
- Code donor value:
  very high for Unity component-level receiver design.
- Product reference value:
  high for avatar/motion app integration.
- Caveats:
  many inspector options; future reuse should create simpler presets.
- What to inspect next:
  extract a minimal receiver component for diagnostics or overlay pose panels.

## `sh-akira/QuestOSCTransformSender`

- GitHub:
  [sh-akira/QuestOSCTransformSender](https://github.com/sh-akira/QuestOSCTransformSender)
- What it is:
  a small Unity Quest project that sends HMD and controller transforms over
  VMC-style OSC.
- Interesting idea:
  a headset app can publish its own pose/controller transforms as a lightweight
  motion bridge without a desktop runtime driver.
- Code-level notes:
  `ExternalSender.cs` sends world and local transforms for HMD, left
  controller, and right controller to `/VMC/Ext/Hmd/Pos`,
  `/VMC/Ext/Hmd/Pos/Local`, `/VMC/Ext/Con/Pos`, and
  `/VMC/Ext/Con/Pos/Local`. It also exposes address/port changes by updating
  the OSC client fields and reenabling the component.
- Code donor value:
  medium-high for headset pose publishing.
- Product reference value:
  high for simple Quest-to-desktop transform bridge ideas.
- Caveats:
  small sample and reflection-based OSC client configuration.
- What to inspect next:
  compare with Quest controller relay and teleoperation waves.

## `infosia/vmc2bvh`

- GitHub:
  [infosia/vmc2bvh](https://github.com/infosia/vmc2bvh)
- What it is:
  a C++ CLI that listens for VMC OSC data and exports BVH motion files.
- Interesting idea:
  a live pose stream can become an offline artifact when the utility records
  only after load/calibration, maps VRM humanoid bones to a skeleton, samples by
  FPS interval, and writes separate hierarchy, motion, and blendshape outputs.
- Code-level notes:
  `Vmc2Bvh.cpp` waits for `/VMC/Ext/OK` loaded/calibrated state, receives VRM
  file path, parses VRM with `cgltf`, builds humanoid bone mapping, updates
  root and bone transforms from VMC messages, records changed blendshape
  values on apply, writes BVH hierarchy/motion at a configured FPS, supports
  in-place root translation suppression, and emits a sidecar blend JSON.
- Code donor value:
  high for live stream to offline export.
- Product reference value:
  high for diagnostics, capture, and replay tooling.
- Caveats:
  CLI-oriented and assumes VRM availability/path messages.
- What to inspect next:
  compare export design with `vmcrec` replay format.

## `infosia/vmcrec`

- GitHub:
  [infosia/vmcrec](https://github.com/infosia/vmcrec)
- What it is:
  a C++ VMC motion recorder and replay/dump utility.
- Interesting idea:
  motion streams can be compressed into a typed binary log with explicit
  command addresses, timestamps, bone indices, blendshape name tables, and
  availability state.
- Code-level notes:
  `VMCPacketListener.cpp` starts recording after calibration, collects root,
  humanoid bone transforms, blendshape values, and availability status, then
  serializes FlatBuffers records with length prefixes. `VMC.Marionette.fbs`
  defines `Address`, `Available`, `Vec3`, `Vec4`, `Command`, `Bone`, and
  `Value`. `main.cpp` supports record and replay modes, validates FlatBuffers,
  and prints record summaries.
- Code donor value:
  high for typed motion recording and replay.
- Product reference value:
  high for debugging motion streams.
- Caveats:
  replay mode currently acts more like validated dump/sample output than a
  full OSC rebroadcast.
- What to inspect next:
  design a generic pose-stream capture format for `VR-apps-lab`.

## Cross-project synthesis

Reusable lessons:

- role names and ports make OSC integrations easier to reason about;
- receivers should ignore unsupported messages and validate known ones;
- runtime apps need recenter, address, port, period, and receiver-list controls;
- packet limiting, freeze, filters, and bone cutoffs are practical UX features;
- exporters should record calibration/load state before trusting a stream;
- record/replay formats should include names, indices, timestamps, and
  availability state.

Best donor candidates:

- `VirtualMotionCaptureProtocol` for protocol shape;
- `EasyVirtualMotionCaptureForUnity` for receiver components;
- `vmc2bvh` and `vmcrec` for recording/export tooling;
- `VirtualMotionCapture` for companion runtime/control-panel architecture.

## Reuse implications for `VR-apps-lab`

This wave suggests a `pose-stream utility` branch:

- VMC/OSC receiver diagnostics panel;
- pose-stream recorder/replayer;
- bridge schema matrix across VMC, SlimeVR, VMT, VRChat OSC, and MediaPipe;
- Quest transform sender reference;
- calibration-aware motion capture export helpers.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were used only for code reading and are local-only.
