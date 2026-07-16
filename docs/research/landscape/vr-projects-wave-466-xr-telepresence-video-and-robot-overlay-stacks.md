# Wave 466: XR telepresence video and robot overlay stacks

- Date: `2026-07-16`
- Scope: telepresence stacks that combine browser video capture, WebRTC,
  Unity/VR clients, HoloLens/AR overlays, robot command sidecars, signaling,
  and operator caveats.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `microsoft/Virtual-Robot-Overlay-for-Online-Meetings` | Studied | Multi-component VROOM research prototype with server, 360 broadcaster, VR viewer, AR local overlay, and robot controller |
| `microsoft/MixedReality-WebRTC` | Studied as infrastructure reference | Deprecated but rich MR WebRTC library with C++/C#/Unity layers, NodeDSS sample UI, HoloLens notes, and MRC caveats |
| `epiception/Virtual-Telepresence` | Lightly studied | Older Cardboard/Raspberry Pi/robot telepresence stack with robot control scripts and hardware-caveat value |
| `unitreerobotics/xr_teleoperate` | Cross-wave reference | Already studied Wave 350; modern XR robot teleoperation overlap |
| `aadhithya14/Open-Teach` | Cross-wave reference | Already studied Wave 369; Quest teleop/data-collection overlap |

## Project notes

### `microsoft/Virtual-Robot-Overlay-for-Online-Meetings`

- Interesting idea: a full XR telepresence prototype split into explicit
  components: Node server, browser 360 broadcaster, Unity WMR remote VR app,
  HoloLens local AR overlay, and robot-controller sidecar.
- Code donor value: high conceptually; direct code reuse should be cautious
  because the repo includes old Unity/UWP packages and research-prototype
  assumptions.
- Product reference value: high; the split is excellent for future
  telepresence/operator overlay architecture.
- Source evidence: `README.md`, `VROOM-Server/server.js`,
  `VROOM-Server/dss-and-events.js`, `VROOM-360Broadcaster/js/main.js`,
  `VROOM-Remote-VR/Assets/NetworkEvents.cs`,
  `VROOM-Local-AR/Assets/VROOM-Local-AR/NetworkEvents.cs`,
  `VROOM-RobotController/VROOM-RobotController/NetworkEvents.cs`.
- Reusable core: HTTPS static broadcaster, HTTP/HTTPS signaling servers,
  queue-based WebRTC DSS messages, event store, browser camera stream,
  Unity network event polling, local/remote peer ids, and robot command
  sidecar.
- Product reference value: it shows how "overlay" can mean a remote user avatar
  over a physical robot, not just a compositor window.
- What not to copy: bundled NuGet/binary packages, hard-coded peer ids, polling
  without auth, self-signed cert setup assumptions, old WMR/HoloLens v1 stack,
  and equipment-specific Beam robot control.
- What to inspect next: exact Unity remote-VR avatar/control scripts and
  HoloLens marker alignment flow.

### `microsoft/MixedReality-WebRTC`

- Interesting idea: infrastructure stack for real-time MR media with native
  C/C++, C# async API, Unity components, UWP examples, and HoloLens MRC notes.
- Code donor value: medium as architecture reference; the README explicitly
  marks the project deprecated.
- Product reference value: high; it gives vocabulary for peer connection,
  signaling, tracks, data channels, webcam/MRC capture, and Unity sample UI.
- Source evidence: `README.md`,
  `libs/unity/samples/Runtime/Scripts/NodeDssSignalerUI.cs`,
  `examples/TestAppUwp/ViewModel/*`, docs/manual architecture.
- Reusable core: layered media library boundary, signaling interface,
  local/remote peer id UI, `PlayerPrefs` remembered peer, Unity components,
  UWP view models, and capture/codec caveat documentation.
- What not to copy: deprecated library dependency, old WebRTC milestone,
  unsupported platform claims, and build system bulk.
- What to inspect next: use only as a schema/reference for future media bridge
  docs, not as a dependency recommendation.

### `epiception/Virtual-Telepresence`

- Interesting idea: old but concrete cardboard/Raspberry Pi telepresence stack
  tying SBS VR viewing, robot hardware, camera streaming, servos, keyboard
  control, and hardware test scripts.
- Code donor value: low; useful as historical reference for minimal robot
  command mapping and hardware test vocabulary.
- Product reference value: medium; shows telepresence as a system of camera,
  gimbal, robot locomotion, and viewer assumptions.
- Source evidence: `README.md`,
  `Surrogates/Python-Code/Python-Code-version1.0/Sample_Experiments.py`,
  `servo_blasteroid.py`, `fipi.py`, Firebird C project files.
- Reusable core: hardware manifest, dependency list, robot command tests,
  servo pan/tilt controls, keyboard movement mapping, and stop/buzzer/sensor
  test modes.
- What not to copy: Python 2 style, compiled artifacts, hardware-specific
  Firebird assumptions, Android app dependencies, and no modern safety layer.
- What to inspect next: only as a historical contrast against modern Quest/XR
  teleoperation families.

## Reusable pattern extraction

- Pattern candidate: `XR telepresence relay stack`.
- Problem solved: telepresence utilities need multiple processes to coordinate
  video, avatar pose, remote commands, local overlays, robot control, and
  safety state.
- Reusable core: component inventory, media broadcaster, signaling/event relay,
  VR viewer, local AR overlay, robot command sidecar, peer identity, polling or
  push transport, command schema, status labels, and equipment caveats.
- Source evidence: VROOM `server.js`, `dss-and-events.js`, broadcaster
  `main.js`, Unity/C# `NetworkEvents.cs`, MR-WebRTC README and Unity sample UI,
  Virtual-Telepresence hardware scripts.
- Abstraction boundary: media transport, command transport, avatar/overlay
  rendering, and robot actuation must be separate services.
- What not to copy: unauthenticated polling, hard-coded ids, old binaries,
  hardware-specific robot commands, or deprecated WebRTC dependency choices.
- Method catalog action: add `Method 911`.

## Why this matters for VR-apps-lab

This wave strengthens the "remote operator surface" direction. It connects
overlay thinking, video streaming, robot control, and safety/caveat labels into
one reusable system pattern.

