# Wave 390: MR Robot, SLAM, User Study, and Passthrough Analysis Dashboards

## Theme

Mixed-reality dashboards for robots, SLAM, user studies, and synchronized
replay: Quest operator surfaces that combine scene understanding, networking,
recording, and analysis.

## Frozen Shortlist

| Project | Status | Why it was included |
|---|---|---|
| `mustafizur-r/WalkerProject` | Studied | Quest MR gait rehab/robot walker serious game with MRUK, Photon, MQTT, and tracking feedback |
| `prakash-aryan/MR-SLAM` | Studied | Unity/Quest multi-robot SLAM dashboard with ROS2 backend, map merge, Nav2, and stats publisher |
| `danieljtrujillo/The-Future-is-Chrome-MIT-Reality-Hack-2026` | Studied | Quest/robot hackathon app with robot server, docs, and Booster Robotics SDK assets |
| `mi2lab/mrat-passthrough-quest` | Studied | MRAT Quest passthrough user-testing toolkit with recording/replay and cross-device tracking |

## Dedupe Notes

Prior robotics waves focused on pose/teleop control loops. This wave focuses on
MR dashboards and analysis/replay layers around robot or user behavior.

## Code-Level Findings

### `mustafizur-r/WalkerProject`

- Interesting idea: combine MRUK scene understanding, collaborative robot
  walker state, avatar feedback, Photon sync, and MQTT robot coordination in a
  rehabilitation serious game.
- Code donor value: `Assets`, `Packages`, `ProjectSettings`, and README feature
  list show room/floor detection, robot matrix publishing, patient/robot
  tracking, and multiplayer/network boundaries.
- Product reference value: useful for MR rehabilitation/operator tools where
  robot state and patient feedback share one scene.
- What to inspect next: MQTT payloads, robot calibration, avatar feedback, and
  clinical/safety labels.
- Caveat: clinical claims and robot control must be treated as high-risk.

### `prakash-aryan/MR-SLAM`

- Interesting idea: make Quest/Unity a multi-robot SLAM dashboard while ROS2
  owns map generation, merge, Nav2, TF, and lightweight stats topics.
- Code donor value: `ros_backend`, `multi_robot_slam.launch.py`,
  `multi_robot_nav2.launch.py`, `slam_stats_publisher.py`, and
  `MULTI_ROBOT_GUIDE.md` show dashboard/backend separation.
- Product reference value: strong pattern for showing robot maps in VR without
  streaming entire SLAM internals into Unity.
- What to inspect next: Unity map subscription, namespace scheme, map merge
  lifecycle, and stale robot detection.
- Caveat: full map data can be heavy; stats/result topics need clear semantics.

### `danieljtrujillo/The-Future-is-Chrome-MIT-Reality-Hack-2026`

- Interesting idea: a hackathon MR/robot app can still reveal useful service
  boundaries: Unity app, `robot-server`, docs, and bundled robotics SDK.
- Code donor value: `Assets`, `docs`, `robot-server`, and Booster Robotics SDK
  folders show a multi-service app structure with robot control references.
- Product reference value: useful as a cautionary donor for separating robot
  vendor SDKs, server processes, and Unity scene logic.
- What to inspect next: server API, robot command authority, websocket/service
  split, and cleanup of large vendor SDK assets.
- Caveat: hackathon repos often mix prototype code and vendor drops; extract
  architecture lessons only.

### `mi2lab/mrat-passthrough-quest`

- Interesting idea: user testing in passthrough MR can be packaged as recording,
  replay, remote tracking, and analysis modes rather than one app scene.
- Code donor value: `Assets`, `Documents`, `MRAT-release`, and README show
  local/online recording, replay, live head/hand tracking from PC/Quest/browser,
  first-person and handheld mobile modes.
- Product reference value: strong reference for research instrumentation and UX
  replay tools in `VR-apps-lab`.
- What to inspect next: recording schema, replay synchronization, remote device
  protocol, and privacy/consent surfaces.
- Caveat: participant data capture requires explicit consent and retention
  policy.

## Reusable Pattern Extraction

- Pattern candidate: MR robot and user-study dashboard with replay.
- Problem solved: operator/research tools need scene context, robot/user state,
  network health, recording, replay, and safety/consent state in one UI.
- Reusable core: MR scene context, robot/user identity, topic/namespace map,
  lightweight stats channel, command authority, replay log, remote tracking
  source, connection health, consent label, and stale-data indicator.
- Source evidence: WalkerProject README, MR-SLAM `ros_backend` launch/stats
  files, The-Future-is-Chrome `robot-server/docs/Assets`, and MRAT
  `Documents/MRAT-release` plus README.
- Abstraction boundary: Unity/MR dashboard should not own SLAM, robot safety,
  or raw participant retention policy.
- What not to copy: clinical/robot claims without validation, whole vendor SDK
  dumps, raw maps without decimation, or recording without consent metadata.
- Method catalog action: add Method 835.

## Family Placement

Creates an MR robot/SLAM/user-study dashboard family. It extends prior
teleoperation waves with analysis and replay surfaces.

## Follow-Up Gaps

- Define a dashboard state schema for robot/user identity, topics, freshness,
  and authority.
- Compare MRAT replay logs with existing telemetry/session methods.
- Add consent/retention labels to any future participant-recording utility.
