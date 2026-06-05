# GitHub Research Wave 119 Plan

- Date: `2026-06-05`
- Goal: study VR teleoperation and robot-control projects as reusable
  references for headset frontends, pose/control transport, IK/MPC loops,
  diagnostics, safety affordances, and synchronized data capture.

## Why this wave exists

Earlier waves covered tracking bridges, OSC/WebSocket relays, synthetic
drivers, and simulation overlays. Teleoperation projects use VR in a different
way: the headset, controllers, and hand tracking become a control surface for
physical robots, simulation robots, or camera arms.

This wave studies teleop repositories as product and architecture references
for future VR utility tools that need low-latency pose streams, safety gates,
operator HUDs, device/robot visualizers, and data-capture workflows.

## Search scope

Primary search directions for this wave:

- WebXR headset frontends for robot teleop;
- OpenVR/SteamVR controller-pose robot bridges;
- Unity/ROS2/Quest teleoperation interfaces;
- Isaac Sim/OpenXR robot teleoperation and demonstration capture;
- robot-control transport via UDP, TCP, ROS topics, WebSocket, and WebRTC;
- safety affordances such as pause, recenter, watchdog, workspace bounds, and
  smoothing.

## Frozen shortlist for code-level study

- `kscalelabs/kbot_vr_teleop`
- `dwaitbhatt/xarm_vr_teleop`
- `NVlabs/collab-sim`
- `wengmister/franka-vr-teleop`
- `nakama-lab/VR_Teleop_Interface`
- `open-thought/cambot`
- `plund-dtu/UR_VR_Teleop`

## Execution model

### Step 1: Search and deduplicate

- search GitHub by VR teleop, WebXR robot teleop, OpenVR robot control,
  Quest teleoperation, Isaac Sim VR teleop, and ROS/Unity VR robot interface
  families;
- compare candidates against registry and family docs;
- treat `nakama-lab/VR_Teleop_Interface` as a deepening of an existing
  not-yet-studied marker rather than as a brand-new discovery.

### Step 2: Freeze the shortlist

- include WebXR humanoid teleop, headset-free OpenVR xArm control, Isaac
  Sim/MPC VR teleop, Franka Quest hand-streaming, Unity/ROS/Quest/ZED bridge,
  WebXR stereo camera arm, and UR controller/data-capture teleop.

### Step 3: Sync local source cache

- clone shortlisted repositories into `.research-sources/github/`;
- keep the clones local-only and outside git tracking.

### Step 4: Perform the code-level pass

For each shortlisted repository inspect:

- headset frontend, browser, Unity, SteamVR, or Isaac Sim boundary;
- pose, controller, hand, joystick, and button data model;
- UDP, TCP, WebSocket, WebRTC, ROS topic, or internal simulation transport;
- IK, MPC, trajectory, joint-velocity, and robot-command layers;
- operator HUD, visualization, haptics, pause/recenter/watchdog, and safety
  gates;
- data capture, replay, camera sync, and diagnostics.

### Step 5: Promote findings into repository structure

Update:

- `landscape/` with a new Wave 119 synthesis document;
- `catalog/project-registry.md`;
- `landscape/project-families.md`;
- `landscape/not-yet-studied-deeply.md`;
- `methods/vr-utility-methods-catalog.md`;
- documentation indexes that surface the new wave.

### Step 6: Verify before publishing

For this type of work, the main checks are:

- teleop repositories are treated as control-surface architecture references,
  not as software to run in this repository;
- safety and data-capture caveats remain visible;
- robot-specific code is not copied into tracked source;
- `.research-sources/` stays ignored by git;
- the new wave is linked from the research indexes.

## Definition of done

This wave is complete when:

1. the plan and backlog are documented;
2. the shortlist is confirmed in the local source cache;
3. a Wave 119 synthesis document exists with code-level findings;
4. registry and families represent VR teleoperation donors clearly;
5. methods capture headset frontends, pose transport, IK/MPC, safety gates,
   visualizers, and data capture;
6. documentation indexes link to the new wave;
7. the result is committed and pushed to GitHub.
