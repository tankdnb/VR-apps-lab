# VR Projects Wave 211: VR Teleoperation Control Frontends, Robot Bridges, and Safety HUDs

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-211-plan.md`
- `docs/research/program/github-research-wave-211-backlog.md`

Research mode: static source reading only. No external repository was run, built, installed, or launched.

## Why This Wave Matters

Teleoperation repositories are strong donors for VR utilities because they make control risk explicit. They need clear modes, live feedback, calibration, command gating, stale-data handling, transport visibility, and emergency pause/home behavior.

Those lessons apply beyond robots: remote desktop controls, overlay automation, diagnostics tools, and runtime helpers all benefit from explicit feedback loops and safe command boundaries.

## Project Findings

### `h2r/GHOST`

- Interesting idea: a Quest/Unity robot teleoperation frontend can be organized around explicit control modes, controller commands, robot joint publishing, and optional point-cloud/depth visualization.
- Code donor value: medium to high. `ModeManager.cs` disables all control modes, switches active mode, updates UI text, and adjusts camera far plane for dynamic arm mode. `ArmInputPublisher.cs` converts Unity arm angles into robot coordinate conventions and publishes joint arrays. `VRGeneralControls.cs` maps controller buttons to stow, mode switching, gripper actions, and optional visual subscribers.
- Product reference value: high for immersive robot-control UI and mode-oriented operator flows.
- Architecture pattern: Unity XR frontend plus ROS publisher/subscriber glue plus mode manager.
- Reusable method: put user-facing control mode state at the center of the VR operator UI, then gate publishers and visualizations through that state.
- Constraints and caveats: Unity/Meta stack, external `ros_reality` dependency, robot-specific coordinate transforms, and research prototype assumptions.
- What to inspect next: point cloud/depth rendering path, mode-specific input handling, and how safety state is communicated to the operator.
- Why it matters for `VR-apps-lab`: it is a useful donor for explicit VR control modes and operator-state UI.

### `nakama-lab/VR_Teleop_Interface`

- Interesting idea: teleoperation architecture can be documented as branch-separated subsystems plus command/status/error sequence diagrams, making safety and integration boundaries visible before code inspection.
- Code donor value: low to medium from main branch because it is documentation-heavy, but the architecture is valuable. README maps Unity VR, ROS2 Franka, and ZED Docker branches, and the command docs show valid/invalid command, out-of-bounds, halt, logging, and display flows.
- Product reference value: medium to high for clear teleop documentation practice.
- Architecture pattern: multi-branch system map with explicit topic contracts and sequence diagrams.
- Reusable method: document control command lifecycle, status feedback, invalid-command behavior, and error handling as first-class research artifacts.
- Constraints and caveats: implementation is spread across branches, so main-branch source is not enough for code reuse.
- What to inspect next: branch-specific Unity scripts and ROS2 nodes if a future teleop/control prototype needs concrete code.
- Why it matters for `VR-apps-lab`: it is a documentation-pattern donor for future complex utility systems.

### `kscalelabs/kbot_vr_teleop`

- Interesting idea: use a WebXR headset frontend for operator input and feedback, then keep IK and robot command emission in a Python sidecar with convergence checks.
- Code donor value: high. `frontend/src/WebXR.tsx` handles immersive VR session request, video plane, URDF/STL loading, WebSocket tracking, controller data, status canvas, pause controls, and visual feedback. `frontend/src/lib/tracking.ts` extracts hand-tracking joint matrices or controller grip poses, throttles messages, gates command sending through pause state, and sends JSON. `command_conn.py` defines newline-terminated UDP JSON robot commands. `teleop_core.py` receives wrist/joystick/gripper state, warm-starts IK, resets on stale messages, computes gripper/finger signals, reports kinematics back to the client, and only sends commands after convergence/distance checks.
- Product reference value: high. It shows a modern browser/headset frontend plus local control sidecar split.
- Architecture pattern: WebXR frontend plus WebSocket tracking/control stream plus Python IK/command sidecar plus UDP robot transport.
- Reusable method: make headset tracking payloads explicit, throttle them, keep pause gates near the frontend, and keep actuator commands behind sidecar-level convergence checks.
- Constraints and caveats: robot-specific URDF/IK/UDP schema, active research stack, and safety assumptions tied to the target hardware.
- What to inspect next: tracking message schema, status canvas feedback, IK convergence visualization, and how pause state is persisted/recovered.
- Why it matters for `VR-apps-lab`: it is a strong donor for WebXR control surfaces and sidecar command boundaries.

#### Reusable Pattern Extraction

- Pattern candidate: WebXR control frontend plus command sidecar gate.
- Problem solved: collect headset/controller/hand input in the browser while keeping risky command logic in a separate local process.
- Reusable core: WebXR session, hand/controller tracking extraction, message throttle, pause gate, WebSocket payloads, sidecar solver/validator, command transport, and feedback channel.
- Source evidence: `WebXR.tsx`, `tracking.ts`, `command_conn.py`, and `teleop_core.py`.
- Abstraction boundary: separate operator input, command validation/IK, robot transport, and feedback visualization.
- What not to copy: robot-specific kinematics or UDP schema without a target-specific safety review.
- Method catalog action: create Method 656.

### `open-thought/cambot`

- Interesting idea: a WebXR teleoperation app should expose stereo video, HUD telemetry, transport choice, calibration, smoothing, workspace bounds, watchdog timeout, pause, home, and automatic headset-removal safety as one operator loop.
- Code donor value: very high. `cambot/teleop/server.py` uses aiohttp WebSocket/HTTPS plumbing, optional WebRTC manager, client locks, camera demand, telemetry messages, ping RTT loop, frame backpressure, and binary frame headers. `client/index.html` builds the WebXR/Three.js viewer, HUD, stereo/video settings, resolution buttons, transport toggle, calibrate/position/pause controls, and debug overlays. `app.py` connects head tracking to robot control with smoothing, max joint velocity, home/resting positions, workspace bounds, max position delta, watchdog timeout, neutral calibration, pause behavior, and jump-prevention gates.
- Product reference value: very high. It is one of the clearest examples of a VR control surface that treats safety and operator feedback as product features.
- Architecture pattern: WebXR stereo video frontend plus WebSocket/WebRTC transport plus robot-control app with explicit safety envelope.
- Reusable method: combine live feedback, transport health, calibration, pause/home state, smoothing, jump limits, and watchdogs into the control surface design.
- Constraints and caveats: robot-specific, requires hardware-aware safety review, and the camera/servo assumptions should not be copied blindly.
- What to inspect next: HUD state model, frame backpressure logic, headset-removal pause flow, and WebRTC fallback design.
- Why it matters for `VR-apps-lab`: it is the strongest donor in this wave for safe VR control loops and operator HUD design.

#### Reusable Pattern Extraction

- Pattern candidate: safety-first WebXR teleoperation HUD.
- Problem solved: let an operator control a physical or remote system from VR while continuously seeing command state, video state, transport health, and safety status.
- Reusable core: WebXR viewer, stereo/video plane, HUD telemetry, transport selection, ping/RTT, frame backpressure, calibration, pause/home, workspace bounds, jump limits, and watchdog timeout.
- Source evidence: `server.py`, `client/index.html`, and `app.py`.
- Abstraction boundary: separate operator UI, media transport, pose/command state, and actuator safety enforcement.
- What not to copy: hardware-specific servo assumptions or safety thresholds.
- Method catalog action: included in Method 656.

## Cross-Project Lessons

- Control surfaces need explicit modes, not hidden state.
- Bidirectional feedback is a safety feature: the operator must see command, status, transport, and error state.
- WebXR can be a serious headset frontend when risky logic stays in a sidecar or robot-control process.
- Teleop safety patterns can inform non-robot VR utilities wherever user commands affect a remote runtime, desktop, overlay, or device.

## Method Catalog Actions

- Added Method 656: WebXR/VR teleoperation control surface with safety gates and feedback loop.

## Follow-Up Gaps

- Generalize teleop safety gates into a VR utility-control pattern for remote desktops, overlay automation, diagnostics actions, and device tools.
- Compare Unity and WebXR frontend tradeoffs for future control panels.
- Build a documentation template for command/status/error sequence diagrams based on `VR_Teleop_Interface`.
