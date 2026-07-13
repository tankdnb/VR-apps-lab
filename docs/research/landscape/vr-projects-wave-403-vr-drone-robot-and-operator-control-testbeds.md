# Wave 403: VR Drone, Robot, and Operator-Control Testbeds

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device tests.

## Theme

This wave studies VR operator-control testbeds: simple drone-control prototypes
and a richer robotic-arm experiment harness. The reusable value is input mapping,
control-mode selection, trial logging, and operator feedback.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `vkrishnan998/UnityVR-Drone-Simulation` | Studied with caveats | Simple VR drone movement/user-study prototype |
| `GTamilSelvan07/Unity_VR_Drone_Simulator` | Studied | Compact drone-control and power-up scripts |
| `MPI-IS/ArmSym` | Studied | VR assistive robotic-arm trial harness |

## Findings

### `vkrishnan998/UnityVR-Drone-Simulation`

- Interesting idea: a VR drone simulation built as a user-study environment with
  a small script surface.
- Code donor value: `PlayerController` and `CameraController` demonstrate a
  minimal rigidbody movement baseline and follow camera relationship.
- Product reference value: useful mostly as a lightweight control-mapping stub
  for drone or vehicle experiments.
- What to inspect next: user-study protocol, scene route, task goals, and any
  untracked survey/logging material.
- Caveat: donor value is modest; do not overpromote it beyond a movement
  baseline.

### `GTamilSelvan07/Unity_VR_Drone_Simulator`

- Interesting idea: a tiny drone simulator exposes movement, max-speed tuning,
  battery/player behaviour, penalties, and power-ups as isolated scripts.
- Code donor value: `DronePlayer`, `Drone_Movement`, `PowerUpObject`,
  `IncreaseMaxSpeed`, `VirusPenalty`, `PlayerCollision`, and
  `BatteryPlayerBehaviour`.
- Product reference value: good micro-utility reference for treating operator
  state as explicit tunable parameters and environmental modifiers.
- What to inspect next: mapping to VR controller inputs, battery depletion
  semantics, collision feedback, and speed cap UI.
- Caveat: many controls are keyboard-driven; reuse needs an input adapter before
  becoming a VR utility pattern.

### `MPI-IS/ArmSym`

- Interesting idea: VR research harness for assistive robotic-arm control with
  trials, subject/session JSON, multiple control modes, biosignal ingress, and
  preallocated data logging.
- Code donor value: `AAExperimentMasterScript`, `armsym_controlmodes`,
  `armsym_robot`, `armsym_hand`, `armsym_logger`, `datamanagement`,
  `armsym_configurationscene`, and LSL biosignal inlet integration.
- Product reference value: excellent operator-control reference for future VR
  utilities that bridge controller poses, robot kinematics, external signals,
  and trial-grade telemetry.
- What to inspect next: `TrialMasterScript`, condition JSON schema, pause and
  questionnaire flow, inverse kinematics implementation, and LSL dependency
  boundary.
- Caveat: old Unity/SteamVR stack and research-specific paths; keep the trial
  harness and logger pattern, not the legacy runtime.

## Reusable Pattern Extraction

- Pattern candidate: `Operator-control testbed with pluggable control modes and trial logger`.
- Problem solved: VR operator tools need to compare control strategies while
  preserving trial state, participant configuration, live control data, and
  external signal inputs.
- Reusable core: session JSON, subject/config data, practice/trial switch,
  control-mode index, delegate or strategy dispatch, controller pose sampling,
  optional biosignal ingress, robot/device abstraction, preallocated telemetry
  buffer, per-trial folder, and CSV/JSON output.
- Source evidence: `AAExperimentMasterScript` owns trial progression and
  session/subject files; `armsym_controlmodes` dispatches control strategies and
  logs controller/robot state each frame; `armsym_logger` preallocates rows and
  writes joint/controller data to `Joint_Data.csv`.
- Abstraction boundary: separate operator input, robot/device model, trial
  protocol, and data writer so each can be swapped independently.
- What not to copy: hard-coded relative data paths, old SteamVR dependency
  assumptions, or clinical/assistive claims without study context.
- Method catalog action: add Method 848.

