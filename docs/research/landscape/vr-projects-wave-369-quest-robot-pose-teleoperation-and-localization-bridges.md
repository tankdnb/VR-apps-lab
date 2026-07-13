# Wave 369: Quest Robot Pose Teleoperation and Localization Bridges

## Scope

This wave studies projects that use VR headset/controller/hand pose as a robot
input or localization source: Quest-to-robot pose streams, ROS/NetworkTables
bridges, gripper/button mapping, safety state, video downlinks, and coordinate
conversion.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `aadhithya14/Open-Teach` | Studied | Research-grade Meta Quest teleoperation and data collection stack with Unity VR apps, ZMQ keypoint streams, hand-frame transforms, gesture state, robot operators, camera streams, configs, and dataset collection |
| `paulonhantumbojr/sawyer_vr_teleop` | Studied | Quest 2 to Sawyer ROS teleoperation with ROS TCP Connector, headset/controller pose publishing, desired trajectory topics, velocity controller, gripper mapping, and safety warnings |
| `MARSProgramming/QuestNavTest` | Studied | QuestNav FRC localization bridge using Quest pose over NetworkTables 4, heartbeat topics, battery/connectivity state, yaw/position zeroing, and wired/power adapter operational guidance |

## Reusable Pattern Extraction

- Pattern candidate: `headset pose to robot command bridge with safety state`.
- Problem solved: VR tracking is useful for robots, but raw HMD/controller/hand poses need transport, calibration, coordinate conversion, rate limits, heartbeat, and explicit robot authority before they become commands.
- Reusable core: XR pose source, hand/controller topic schema, coordinate-space converter, initial-frame calibration, scale/resolution mode, pause/enable gesture, transport adapter, robot operator/controller, heartbeat, battery and connection health, command limits, gripper/action mapping, video/graph downlink, dataset recorder, and reset/zero routines.
- Source evidence: Open-Teach uses Unity camera streams and Python operators with ZMQ keypoint subscribers/publishers, homogeneous transform conversion, teleop stop/continue state, high/low resolution scale, gripper pinch mapping, filters, and command publishing; sawyer_vr_teleop publishes Quest HMD and controller poses to ROS topics and documents `/desired_trajectory`, velocity control, and gripper mapping; QuestNav uses NT4 topics for position, quaternion, euler angles, battery, heartbeat, zeroing, and robot pose compensation.
- Abstraction boundary: XR pose streaming should stop at a validated command boundary; robot control, safety policy, and hardware-specific SDKs should be replaceable adapters.
- What not to copy: real-robot credentials/IPs, hardware-specific velocity limits, unsafe default commands, headset mounting assumptions, or training data collection without consent/provenance.
- Method catalog action: create a headset pose to robot command bridge method.

## Project Notes

### `aadhithya14/Open-Teach`

- Interesting idea: teleoperation is treated as a full pipeline: VR UI, camera streams, ZMQ transport, robot operators, simulated/real robot adapters, and demonstration data collection.
- Code donor value: very high for hand-frame transforms, ZMQ topic split, robot-operator classes, gesture pause/gripper mapping, scale modes, filters, and dataset separation.
- Product reference value: strong for advanced robot operator cockpits and reproducible manipulation data capture.
- What to inspect next: exact Unity UI state, config schema, dataset metadata, failure states, and safety interlocks.
- Caveats: research stack is large and dependency-heavy; do not reuse install paths, robot assumptions, or policy-training pipeline wholesale.

### `paulonhantumbojr/sawyer_vr_teleop`

- Interesting idea: Unity publishes Quest headset/controller poses through ROS TCP Connector, while ROS nodes convert desired trajectories into Sawyer joint velocity commands and gripper actions.
- Code donor value: high for pose-topic naming, FLU coordinate conversion, Unity-to-ROS boundary, RViz/real robot mode split, and gripper control notes.
- Product reference value: useful for industrial/robotics teleop prototypes where headset pose becomes command intent.
- What to inspect next: launch files, controller mapping, velocity clamps, simulated versus real Sawyer mode separation, and operator feedback UX.
- Caveats: real robot safety risk; do not copy velocity settings or assume ROS control topics are safe without hardware-specific limits.

### `MARSProgramming/QuestNavTest`

- Interesting idea: a Quest headset is mounted on an FRC robot as a high-rate localization sensor and speaks NetworkTables topics to the robot code.
- Code donor value: high for heartbeat design, NT4 topic schema, pose/yaw conversion, battery/connection checks, zeroing commands, and hardware operational notes.
- Product reference value: strong for headset-as-tracker, robot localization, and infrastructure diagnostics.
- What to inspect next: Unity-side publisher path, mount offset calibration, time synchronization, wired Ethernet reliability, and competition-mode constraints.
- Caveats: FRC-specific hardware/rules; Quest battery and USB-C power behavior are part of the design, not incidental details.

## Product Direction

This wave strengthens the existing robotics branch with a sharper `XR pose bus`
concept: future utilities can expose HMD/controller/hand pose as a validated
transport schema with health, calibration, safety, and downstream robot adapters.

