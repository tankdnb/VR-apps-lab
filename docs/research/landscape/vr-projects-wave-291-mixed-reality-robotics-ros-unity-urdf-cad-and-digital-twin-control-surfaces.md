# Wave 291 - Mixed Reality Robotics, ROS/Unity, URDF/CAD, and Digital Twin Control Surfaces

This wave studies mixed-reality robotics projects as reusable references for
URDF/CAD import, ROS-to-Unity joint state, IK targets, robot command surfaces,
MQTT/digital-twin control, trajectory teaching, and server-authoritative safety
boundaries.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- robot/digital-twin control surfaces with XR/MR relevance;
- ROS/Unity bridge examples and joint-state subscribers;
- URDF/Xacro import and robot asset pipelines;
- CAD tree viewers suitable for inspectable digital twins;
- hand/trajectory teaching prototypes;
- operator/server architectures with explicit safety gates.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `2000222/Robotic-Arm-IK-in-Unity` | Minimal Unity robotic-arm IK baseline | Studied | Compact gradient-descent IK and joint-axis representation |
| `sabeaussan/ROS_Unity` | ROS-to-Unity joint-state bridge | Studied | ROSSharp-style `Float32MultiArray` subscriber rotating Unity joints over time |
| `KosmosisDire/UrdfUnityToolkit` | URDF/Xacro Unity import pipeline | Studied | Editor menu import/parse/clean actions plus XML parsing helpers |
| `bernhard-42/three-cad-viewer` | CAD tree and part-state viewer | Studied | Hierarchical shapes/states data model for inspectable web digital twins |
| `KKallas/manual-override` | Server-authoritative robot control architecture | Studied | Architecture docs and Dobot prototype driver with WebSocket/SSE/live-state/safety framing |
| `mortenterhart/mixed-reality-robot-control` | MQTT-backed MR digital twin control | Studied | Unity/MRTK robot shelf UI publishing `store in/out` commands over MQTT |
| `MixedRealityETHZ/Mixed-Reality-Robotic-Grasp-Teacher` | Hand trajectory/grasp teaching shell | Studied with prototype caveat | MRTK hand pinch trajectory recording and scene UI toggling |
| `giuliano-97/mixed_reality_robots` | ROS/MRTK robotics integration reference | Studied with vendor-heavy caveat | ROS launch/URDF examples and Unity mixed-reality shell overlap |

## Code-Level Findings

### `2000222/Robotic-Arm-IK-in-Unity`

- Interesting idea:
  a small Unity robotic arm can be controlled with target-position IK using
  per-joint axes, forward kinematics, and finite-difference partial gradients.
- Code donor value:
  medium/high as a minimal baseline: `IKController.cs` stores joint angles,
  computes forward kinematics, measures target distance, estimates gradients,
  updates angles from end effector backwards, and writes local Euler rotations.
  `ArmJoint.cs` stores rotation axis and start offset.
- Product reference value:
  medium for simple digital-twin manipulation or educational robotics panels.
- What to inspect next:
  constraints, joint limits, coordinate conventions, target UI, convergence
  behavior, and replacement with safer analytical/ROS-side control for real
  hardware.

### `sabeaussan/ROS_Unity`

- Interesting idea:
  Unity joints can subscribe to ROS arrays and animate toward desired joint
  angles with a simple per-frame stepping policy.
- Code donor value:
  medium: `JointAngleSubscriber.cs` extends `UnitySubscriber<Float32MultiArray>`,
  reads `message.data[id]`, compares desired/new angles, applies a sign and
  local rotation axis flags, and stops when the target angle is reached.
- Product reference value:
  high for ROS-to-Unity visualizers, robot state mirrors, and training/digital
  twin shells.
- What to inspect next:
  launch files, ROS publishers, file-server/robot description flow, ML-Agent
  reacher scripts, message versioning, and jitter/smoothing.

### `KosmosisDire/UrdfUnityToolkit`

- Interesting idea:
  URDF/Xacro import is exposed as Unity editor menu actions, turning robot
  description files into scene assets and cleaning generated materials/meshes.
- Code donor value:
  high: `URDFImporterExtension.cs` validates `.urdf` and `.xacro` selections,
  converts Xacro to temporary URDF, calls `URDFBuilder.Build`, provides parse
  and clean actions, and handles folder conventions. XML helpers convert
  attributes into typed numbers, booleans, strings, and `Vector3`.
- Product reference value:
  very high for robotics asset pipelines and digital twin setup tools.
- What to inspect next:
  `URDFBuilder`, mesh import via Assimp, material mapping, coordinate
  conversion, joint limits, generated hierarchy, and cleanup reliability.

### `bernhard-42/three-cad-viewer`

- Interesting idea:
  CAD can be represented as a hierarchical `Shapes` tree with leaf geometry,
  transforms, visibility states, edges, faces, topology metadata, and a viewer
  notification callback.
- Code donor value:
  high: the data-format docs define recursive groups/leaves, slash-separated
  IDs, `loc` transforms, bounding boxes, face/edge visibility states, flat or
  nested arrays, face/edge counts, vertex/normal/triangle/edge payloads, and
  viewer/display options.
- Product reference value:
  very high for web-based CAD/digital-twin inspectors that need part trees,
  edge toggles, opacity, and per-part state.
- What to inspect next:
  viewer state diff callbacks, tree UI, selection/pinning, part highlighting,
  WebXR embedding feasibility, and CAD-to-robot frame mapping.

### `KKallas/manual-override`

- Interesting idea:
  robot operation is framed as a server-authoritative system: clients can be
  human pages or agents, but robot drivers, vision, scoring, calibration,
  E-stop, speed limits, and shared-zone arbitration belong to the server.
- Code donor value:
  very high conceptually: `docs/ARCHITECTURE.md` separates game server, vision
  service, robot drivers, referee GUI, clients, calibration frames, data flow,
  protocols, and safety. `hub/live.py` provides a reusable Server-Sent Events
  `LiveState` helper. `dobot_joint.py` documents Dobot dashboard/motion/
  feedback ports, parses feedback packets, exposes state, clamps speed factor,
  and streams acceleration-limited `ServoJ` joint setpoints.
- Product reference value:
  very high for any future VR/MR robot control surface or physical-output
  utility.
- What to inspect next:
  WebSocket API prototypes, calibration pages, camera/ArUco pipeline,
  dashboard UI, safety limits, and which planned architecture parts are fully
  implemented versus documented targets.

### `mortenterhart/mixed-reality-robot-control`

- Interesting idea:
  an MR digital twin UI can publish compact robot commands over MQTT while also
  updating local animation and shelf occupancy state.
- Code donor value:
  medium: `MRMqttClient.cs` publishes `si{id}` and `so{id}` commands to a
  `commands` topic, while `RobotCommands.cs` tracks selected shelf, object
  position, button colors, animator triggers, and user warnings.
- Product reference value:
  high for small MR operator panels and digital twin command surfaces.
- What to inspect next:
  MQTT connection settings, command acknowledgements, safety/permission gates,
  actual robot receiver, and MRTK UI components.

### `MixedRealityETHZ/Mixed-Reality-Robotic-Grasp-Teacher`

- Interesting idea:
  a teacher can record hand/pinch trajectory samples in MR and store positions
  as a grasp/trajectory demonstration.
- Code donor value:
  medium with prototype caveats: `Trajectory.cs` uses MRTK hand-joint utilities,
  pinch thresholding, countdown text, trajectory sphere instantiation, position
  lists, and reset behavior. `SceneUIHandler.cs` provides a minimal scene
  toggle.
- Product reference value:
  high for demonstration capture, grasp teaching, and embodied robot-command
  authoring.
- What to inspect next:
  ROS/robot export path, trajectory smoothing/resampling, grasp pose schema,
  persistence, and operator review UI.

### `giuliano-97/mixed_reality_robots`

- Interesting idea:
  a robotics/MR repo can bundle ROS launch/URDF packages, Jackal/Panda
  simulation scripts, and a Unity mixed-reality shell.
- Code donor value:
  low/medium in this pass because Unity content is heavily vendor/MRTK-based,
  but `VelCommander.py` is a clear ROS `cmd_vel` publisher baseline and the
  repo helps place MR robotics projects in the ROS/URDF family.
- Product reference value:
  medium for family overlap and ROS/Unity simulation framing.
- What to inspect next:
  custom Unity scripts beyond MRTK payload, launch graphs, Panda/Jackal
  simulation data flow, and robot description import conventions.

## Reusable Pattern Extraction

- Pattern candidate:
  mixed-reality robotics/digital-twin boundary across URDF/CAD import,
  ROS/joint state, IK targets, operator UI, live state, calibration, and
  safety-authoritative robot drivers.
- Problem solved:
  XR robot tools need a digital twin and operator interface without letting
  headset/UI clients bypass physical safety, coordinate calibration, or robot
  driver constraints.
- Reusable core:
  URDF/Xacro import, CAD tree and part states, joint/pose data model,
  ROS subscriber, MQTT/Socket/SSE transport, IK target baseline, hand trajectory
  teaching, server-authoritative command validation, feedback parsing,
  acceleration-limited setpoint streaming, calibration frames, E-stop, and
  operator/referee dashboard.
- Source evidence:
  `Robotic-Arm-IK-in-Unity`, `ROS_Unity`, `UrdfUnityToolkit`,
  `three-cad-viewer`, `manual-override`,
  `mixed-reality-robot-control`,
  `Mixed-Reality-Robotic-Grasp-Teacher`, and `mixed_reality_robots`.
- Abstraction boundary:
  keep asset import, digital-twin visualization, live robot state, command
  transport, calibration, safety policy, and headset/operator UI separate.
- What not to copy:
  UI-driven robot commands without server-side safety, MQTT commands without
  acknowledgements, naive IK as real-hardware control, fixed coordinate frames,
  vendor payloads as architecture evidence, or planned docs as implemented code
  without caveats.
- Method catalog action:
  add a mixed-reality robotics/digital-twin control method.

## Follow-Up Gaps

- Build a robotics utility matrix across URDF/CAD import, ROS bridge, MQTT,
  SSE/WebSocket, IK, trajectory teaching, calibration, and safety policy.
- Deepen `UrdfUnityToolkit`, `manual-override`, and `three-cad-viewer` as the
  strongest reusable architecture donors.
- Compare Wave 291 with earlier teleoperation waves so robot-control patterns
  do not fragment across multiple family names.
- Consider a future reuse plan for a safe MR robot-control shell: imported
  robot model, live joint state, operator dashboard, command queue, and E-stop.
