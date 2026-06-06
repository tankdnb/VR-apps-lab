# VR Projects Wave 242: CV, Mocap, and Industrial VR Training Control Loops

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies VR/MR training projects that connect external sensing or
safety logic to in-headset interactions: ArUco-tracked surgical forceps,
OptiTrack-backed agility-ladder studies, industrial robot digital-twin safety
concepts, and narrative rehabilitation training references.

## Why It Matters For `VR-apps-lab`

VR utilities often need to ingest real-world state: camera markers, mocap
skeletons, physical tools, study conditions, robot-safety gates, or participant
logs. These projects show how to structure that loop: external sensing,
calibration, smoothing, state transition, visual/physical feedback, and
research data capture.

## Project Notes

### `WestCoastGod/XR-CV-Forceps-Tracking-Unity`

- Interesting idea:
  controller-free MR tool interaction can be driven by printed ArUco marker
  rigs and passthrough-camera pose estimation instead of tracked controllers.
- Code donor value:
  `RigidCubeAxesMinimal.cs` tracks marker IDs, configures marker size, applies
  position/rotation One Euro filters, estimates a rigid cube pose, maintains
  marker-visibility state, and controls clamp animation with smoothing/freeze
  gates. `RigidBodyPoseEstimator.cs` aggregates marker corner correspondences
  and computes pose plus reprojection error. `OneEuroFilters.cs` provides float,
  `Vector3`, and quaternion filters. `ForcepsController.cs` keeps trigger
  candidate objects, maps marker-visibility clamp state to grab/release,
  calculates clamp rotation from object radius and attach transform geometry,
  freezes clamp animation while holding objects, and exposes tag filters.
- Product reference value:
  very strong donor for physical-tool-to-XR interaction and marker-based
  training utilities.
- What to inspect next:
  inspect camera-frame acquisition and OpenCV wrapper details before promoting
  to a concrete prototype.
- Architecture pattern:
  passthrough camera -> ArUco detection -> multi-marker rigid pose -> smoothing
  -> visibility state -> tool clamp state -> XR grab/release.
- Reusable method:
  separate pose estimation, smoothing, visibility-derived control, and
  interaction/grab logic into distinct modules.
- Caveats:
  hardware-specific Quest 3 passthrough path, printed marker geometry,
  reflection access to private fields, and medical-training context.

### `jghanania/MotionCapture-AgilityLadder-XR-Study`

- Interesting idea:
  a VR/AR/real-world study can be expressed as condition state plus mocap
  alignment plus per-step logging rather than one monolithic scene.
- Code donor value:
  `SettingsManager.cs` defines environment, visualization, path, gender, and
  subject metadata; uses a balanced Latin square for condition order; switches
  VR/AR/real-world occlusion and avatar visibility; and logs CSV rows.
  `AgilityLadderController.cs` steps through ladder paths, computes foot
  contact offsets and foot angles relative to current field cells, infers step
  direction, rotates coordinates by ladder orientation, and calls `LogToCSV`.
  `OptitrackController.cs` toggles marker visualization, scales avatars,
  aligns the camera rig to OptiTrack head markers, and persists avatar scale.
  The editor script exposes participant and condition controls.
- Product reference value:
  strong donor for XR study orchestration and measured training tasks.
- What to inspect next:
  compare its study logging with prior XR research data lifecycle templates.
- Architecture pattern:
  condition manager plus mocap alignment plus path sequencer plus CSV logging.
- Reusable method:
  make study condition, participant metadata, calibration, and measurement
  logging explicit first-class modules.
- Caveats:
  OptiTrack dependency, lab-specific marker naming, local CSV paths, and
  research-specific assumptions.

### `jesusfernandorl/Industrial_Twin_XR-Safe-Robotics-and-6-Axis-VR-Control`

- Interesting idea:
  industrial VR training should model safety behavior explicitly: soft limits,
  interlocks, deadman switch, HMI feedback, and staged capability roadmap.
- Code donor value:
  the sparse pass found README-level design material only. It documents XR
  Interaction Toolkit, Unity Robotics Hub, inverse kinematics, ROS/PLC future
  direction, ISO 13849-1 deadman switch framing, ISO 10218-1 soft-limit
  framing, IEC 61131-3 interlock logic, physical button travel, spatial audio,
  and a phased roadmap from basic axis movement to PLC synchronization.
- Product reference value:
  useful safety/product reference for robot-control UX and operator training.
- What to inspect next:
  revisit if source scripts are added; specifically look for axis clamp,
  deadman, interlock, and HMI feedback implementation.
- Architecture pattern:
  staged digital-twin training concept with safety gates and HMI feedback.
- Reusable method:
  treat robot/operator VR controls as fail-closed systems with software limits,
  interlocks, and explicit feedback.
- Caveats:
  source-light README pass; strong conceptual value but no code donor yet.

### `purva-rana/MindscapeVR`

- Interesting idea:
  VR rehabilitation education can translate invisible clinical or cognitive
  processes into spatial metaphors with clear act structure.
- Code donor value:
  sparse pass found README-level material only. The project frames a clinical
  room -> mindscape transition, neural network hub, obstacle/blockage
  progression, trigger-driven difficulty escalation, and XR Interaction
  Toolkit physics-based interactions.
- Product reference value:
  concept reference for training/rehab narrative framing and "make invisible
  systems navigable" UX.
- What to inspect next:
  revisit only if source scripts or scene logic become available.
- Architecture pattern:
  narrative state transition from grounded physical context to abstract spatial
  training world.
- Reusable method:
  use spatial metaphor and staged environment deterioration as feedback for
  complex real-world processes.
- Caveats:
  source-light in this pass; not a code donor without scripts.

## Reusable Pattern Extraction

- Pattern candidate:
  sensor-tracked training control loop with calibration, smoothing, condition
  state, and logging.
- Problem solved:
  training utilities need to connect messy real-world inputs to repeatable VR
  state transitions while preserving calibration, safety, and data capture.
- Reusable core:
  isolate sensor ingress, calibration/alignment, smoothing/validity gates,
  task condition state, interaction state machine, feedback, and logging.
- Source evidence:
  `XR-CV-Forceps-Tracking-Unity`, `MotionCapture-AgilityLadder-XR-Study`,
  industrial robot training concept, and `MindscapeVR` narrative reference.
- Abstraction boundary:
  keep sensor acquisition separate from interaction policy; keep safety gates
  separate from visual feedback; keep logging schema separate from scene logic.
- What not to copy:
  medical claims, lab marker IDs, hardcoded local file paths, hardware-specific
  assumptions, or source-light concepts as audited implementation.
- Method catalog action:
  add a method entry for sensor-tracked training/control loops.

## Follow-Up Gaps

- Build a matrix across ArUco, OptiTrack, EMG/accelerometer, ROS, WebSocket,
  and OSC training ingress paths.
- Compare study CSV schemas from this wave against the existing XR research
  data lifecycle track.
- If industrial robot control is revisited, prioritize repos with actual
  deadman/interlock/soft-limit source code.
