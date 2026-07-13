# Wave 384: Quest Hand Streaming, Steering, and ROS Bridge Utilities

## Theme

Quest/OpenXR hand tracking as a reusable data source for robots, simulators,
vehicle controls, and ROS pipelines.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `NU-MECH-ENG-495/vr-hand-tracking` | Studied | Unity/Meta hand joint angle capture plus UDP and ROS2 receiver/visualizer |
| `minsley/avatar-quest` | Studied | Native Quest OpenXR hand curl to ESP32 UDP stream with passthrough/debug overlay |
| `yefeblgn/VR-Hand-Steering-Bridge` | Studied | PC OpenXR hand-joint reader that maps two-hand pose to vJoy steering |
| `lts0429/teleoperation` | Studied | Meta Quest 3 pose packets converted to ROS2 topics and MoveIt teleoperation demos |

## Dedupe Notes

`wengmister/quest-wrist-tracker` and `GeneralTrajectory/dex-teleop` were
already studied. This wave adds narrower bridge variants that clarify
packet/pose conversion, OpenXR loader discovery, steering output, and ROS2 topic
boundaries.

## Code-Level Findings

### `NU-MECH-ENG-495/vr-hand-tracking`

- Interesting idea: split hand tracking into a Quest Unity sender and a C++
  ROS2 receiver/visualizer.
- Code donor value: `UnityProject`, `src/hand_tracking_quest`,
  `HandTrackerQuest.cpp`, `JointAngleVisualizer.cpp`, `UDP_socket.py`, and
  `hand.launch.xml` show a hand-joint pipeline with explicit ROS launch.
- Product reference value: useful for utility tools that need a hand telemetry
  appliance rather than a full robot stack.
- What to inspect next: UDP packet schema, angle normalization, dropped-packet
  behavior, and ROS topic naming.
- Caveat: robotics safety and calibration are outside the lightweight sender.

### `minsley/avatar-quest`

- Interesting idea: native Quest OpenXR can compute finger curl values and send
  compact servo packets directly to an ESP32.
- Code donor value: `src/main.cpp` shows `XR_EXT_hand_tracking`,
  `XR_FB_HAND_TRACKING_MESH`, passthrough extension setup, finger curl math,
  wrist roll, 60 Hz UDP send interval, and TinyUI/debug overlay framing.
- Product reference value: strong micro-utility reference for hand-to-actuator
  demos with visible in-headset feedback.
- What to inspect next: packet versioning, target IP config, confidence gates,
  and servo saturation handling.
- Caveat: hardcoded network endpoints and actuator mapping must not be copied
  into reusable tools.

### `yefeblgn/VR-Hand-Steering-Bridge`

- Interesting idea: treat Quest hand pose through Virtual Desktop/OpenXR as a
  desktop input bridge for non-VR software.
- Code donor value: `Program.cs`, `OpenXRSession`, `SteeringCalculator`,
  `VJoyController`, config JSON, and OpenXR loader discovery show a clean
  runtime-to-virtual-device loop.
- Product reference value: useful for future controller-remap utilities where
  hand posture becomes a synthetic desktop/game input.
- What to inspect next: Kalman tuning, loader/runtime fallback, vJoy failure
  states, and calibration UX.
- Caveat: target-app assumptions should stay in config, not in the OpenXR
  session reader.

### `lts0429/teleoperation`

- Interesting idea: receive Quest headset/hand packets over UDP and publish
  normalized ROS2 pose topics plus TF frames.
- Code donor value: `udp_client.cpp` parses `LeftHandPos`, `LeftHandRot`,
  `RightHandPos`, `RightHandRot`, `HeadsetPos`, and `HeadsetRot`, converts
  Unity coordinates to ROS, and publishes `headset`, `left_hand`, and
  `right_hand` pose streams.
- Product reference value: useful bridge pattern for diagnostics panels that
  show exactly how pose packets map into robot/world frames.
- What to inspect next: frame naming, timestamping, packet validation, and
  MoveIt safety limits.
- Caveat: the checked-in APK should be treated as an artifact, not source.

## Reusable Pattern Extraction

- Pattern candidate: Quest hand telemetry bridge to ROS, actuators, and virtual
  inputs.
- Problem solved: hand tracking is only reusable if source pose/joint data,
  packet schema, runtime loader, conversion math, and output adapter are
  explicit.
- Reusable core: hand source, joint/curl calculator, confidence gate, packet
  schema, transport adapter, coordinate converter, output adapter, debug HUD,
  calibration profile, and safety/fallback state.
- Source evidence: `HandTrackerQuest.cpp`, `JointAngleVisualizer.cpp`,
  `avatar-quest/src/main.cpp`, `VR-Hand-Steering-Bridge/Program.cs`, and
  `teleoperation/udp_client.cpp`.
- Abstraction boundary: OpenXR/Quest capture should not own robot servo limits,
  vehicle control policy, or MoveIt execution rules.
- What not to copy: hardcoded IPs, binary APK artifacts, unversioned packet
  strings, hidden Kalman/steering assumptions, or pose conversion without frame
  labels.
- Method catalog action: add Method 829.

## Family Placement

Creates a Quest hand telemetry bridge family. It extends tracker/teleoperation
families with smaller hand-to-output adapter examples.

## Follow-Up Gaps

- Define a neutral hand telemetry packet schema with timestamps and confidence.
- Compare curl-angle normalization across robot hand and virtual steering uses.
- Add safety-state vocabulary for hand-to-actuator bridges.
