# Wave 385: XR Robot Teleoperation Control Loops and Dataset Recorders

## Theme

XR-to-robot teleoperation stacks with image downlinks, arm/hand controller
selection, ROS compatibility, discovery, calibration, and episode recording.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `fiveages-sim/xr_teleoperate_ocs2_ros2` | Studied | Python XR teleoperation stack with TeleVuer, arm/hand controller selection, shared-memory images, and episode writer |
| `IIT-SoftBots/UnitySoftbotsTeleopRelease` | Studied | Unity soft-robot teleoperation shell with Movement SDK calibration, ROS1/ROS2 compatibility, discovery, and UI modules |
| `stex2005/Unity-HTC` | Studied | Unity/SteamVR tracker-without-HMD setup using Null Driver and tracker-to-object role assignment |

## Dedupe Notes

Prior waves covered robot pose bridges and dexterous teleoperation. This wave
adds a control-loop/data-recorder view and one headsetless tracker setup that
is useful for calibration rigs and lab instrumentation.

## Code-Level Findings

### `fiveages-sim/xr_teleoperate_ocs2_ros2`

- Interesting idea: treat XR teleoperation as a selectable control loop where
  head camera, wrist cameras, hand/controller input, arm type, end effector,
  simulation mode, and recording mode are configured at launch.
- Code donor value: `teleop_hand_and_arm.py` wires `TeleVuerWrapper`, image
  shared memory, Unitree/H1 arm controllers, Dex/Inspire/BrainCo hand
  controllers, keyboard record toggles, and simulation/headless flags.
- Product reference value: strong reference for building operator consoles
  that separate input source, robot target, camera feeds, and dataset capture.
- What to inspect next: TeleVuer packet schema, IK safety, queue lifecycle, and
  emergency stop behavior.
- Caveat: robot-specific controllers and hardware assumptions should be
  abstracted behind adapter records.

### `IIT-SoftBots/UnitySoftbotsTeleopRelease`

- Interesting idea: a Unity operator interface can discover robots over the
  network, calibrate operator body dimensions, and switch ROS1/ROS2
  communication modes.
- Code donor value: README and project layout identify `Core`, `Teleop`,
  `Network`, `Calibration`, `Simulation`, `UI`, robot prefabs, ROS messages,
  and Python broadcast-side support.
- Product reference value: useful for future VR operator tools where the user
  must see connection state, discovered targets, calibration, and mode
  selection before control.
- What to inspect next: robot discovery packet format, Movement SDK body
  calibration, UI target list, and ROS mode adapter boundary.
- Caveat: license and actual script completeness need follow-up before code
  reuse.

### `stex2005/Unity-HTC`

- Interesting idea: headsetless Vive tracker workflows can be documented as a
  Unity project plus SteamVR Null Driver setup and tracker role assignment.
- Code donor value: README documents base stations, trackers, Null Driver,
  direct tracker-to-object binding, logical roles, and dynamic swapping.
- Product reference value: useful for calibration labs, physical props, and
  body/hand tracking tools where no HMD should be required.
- What to inspect next: tracker serial persistence, role UI, null-driver setup
  rollback, and SteamVR action binding assumptions.
- Caveat: bundled SteamVR packages are not the reusable method; extract the
  tracker role model and operator checklist.

## Reusable Pattern Extraction

- Pattern candidate: XR robot teleoperation control loop with dataset recorder.
- Problem solved: teleoperation tools need explicit separation between XR input,
  camera downlinks, robot adapters, simulation/headless modes, recording, and
  operator calibration.
- Reusable core: input-source selector, robot adapter record, end-effector
  adapter, camera shared memory, discovery broadcast, calibration prompt,
  connection state, record toggle, episode writer, safety limits, and
  headsetless tracker role map.
- Source evidence: `teleop_hand_and_arm.py`, `EpisodeWriter`, IIT README
  architecture modules, robot prefabs/ROS folders, and Unity-HTC Null Driver
  tracker-role README.
- Abstraction boundary: robot-specific IK/control and input capture should be
  adapters; UI owns mode selection and safety state.
- What not to copy: hardware-specific controllers as generic logic, recording
  without metadata, tracker roles without serial identity, or robot control
  without stop/recovery state.
- Method catalog action: add Method 830.

## Family Placement

Creates an XR robot teleoperation control-loop family. It extends prior
robotics work with operator-console, recording, discovery, and headsetless
tracker lessons.

## Follow-Up Gaps

- Draft an operator console schema for robot targets, modes, feeds, and safety.
- Compare episode writer metadata with existing telemetry schema work.
- Add headsetless tracker role persistence to calibration-method backlog.
