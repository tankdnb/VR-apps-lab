# VR Projects Wave 222: Cockpit Hand-Clicking, Calibration, Observer, and Passthrough Microhelpers

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-222-plan.md`
- `docs/research/program/github-research-wave-222-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

Microhelpers are often more reusable than large apps because they expose one
sharp value: translate hands into cockpit clicks, calibrate tracking origins,
align a mixed-device observer, or turn a headset camera into a VR overlay.
Their donor value is in bounded translation, state machines, safety gates, and
honest caveats.

## Project Findings

### `fredemmott/HTCC`

- Interesting idea: an OpenXR API layer can consume hand tracking itself,
  report hand tracking as unsupported to the target app, and then expose
  simulator-friendly virtual controller/pointer/click/scroll actions.
- Code donor value: very high for input translation boundaries.
  `APILayer.cpp` intercepts action/state/space/session calls, creates
  hand-tracking and PointCTRL sources, and sets up `VirtualControllerSink`.
  `HandTrackingSource.cpp` translates OpenXR hand joints and optional
  `XR_FB_hand_tracking_aim` into cockpit ray, pinch click, scroll, wake/sleep,
  one-hand arbitration, and hibernate behavior. `VirtualControllerSink.cpp`
  maps DCS/MSFS action paths and stabilizes aim/grip poses while actions are
  active. `Config.cpp` loads HKLM settings plus per-app overrides.
- Product reference value: very high for simulator utility design.
- Architecture pattern: API-layer interception plus private input source plus
  app-specific virtual action sink.
- Reusable method: hide low-level input from the app when the utility owns the
  translation and must avoid conflicting action bindings.
- Constraints and caveats: simulator focus, Windows/registry config, PointCTRL
  path, per-exe overrides, and complex OpenXR interception.
- What to inspect next: settings app UX and exact per-simulator binding maps.
- Why it matters for `VR-apps-lab`: it is a strong model for safe, bounded
  input translation helpers.

#### Reusable Pattern Extraction

- Pattern candidate: purpose-bounded VR input/calibration helper with safe
  app-specific translation.
- Problem solved: a raw XR signal is not always useful directly; users need a
  narrow helper that translates it into the target application's expected
  actions without destabilizing the runtime.
- Reusable core: source adapter, target action sink, state machine, config
  profile, safety gates, diagnostics/monitor mode, saved transform or action
  mapping, and explicit scope caveats.
- Source evidence: HTCC `APILayer.cpp`, `HandTrackingSource.cpp`,
  `VirtualControllerSink.cpp`, `Config.cpp`; motoc `sampled.rs`, `offset.rs`,
  `monitor.rs`, `common.rs`; HoloViveObserver `AlignmentManager.cs` and
  `HoloViveNetworkManager.cs`; index camera passthrough `main.rs`,
  `config.rs`, `pipeline.rs`, `projection.rs`, `events.rs`, and `vrapi.rs`.
- Abstraction boundary: input source, translation logic, target sink,
  persistence, diagnostics, and UX controls should remain separable.
- What not to copy: simulator-specific bindings, Monado-only APIs, legacy
  Unity networking, or hardware-specific camera assumptions as general
  defaults.
- Method catalog action: create Method 667.

### `galister/motoc`

- Interesting idea: calibration is treated as a CLI workflow with multiple
  interchangeable `Calibrator` implementations: monitor, sampled calibration,
  offset maintenance, recentering, and floor methods.
- Code donor value: high. `main.rs` enumerates Monado devices/origins, supports
  reset/adjust/monitor/calibrate/continue flows, and enters an OpenXR loop with
  `MND_headless` and `MNDX_xdev_space`. `sampled.rs` collects paired device
  samples, computes rotation via delta-sample SVD, solves translation, retries
  failed calibration, saves profiles, and can replace itself with continuous
  `OffsetMethod`. `offset.rs` smooths constant offsets, rejects fast movement,
  handles tracking jumps/anomalies, and sets tracking-origin offsets.
  `monitor.rs` prints stage/local/origin/device pose, velocity, spin, and
  battery state. `common.rs` serializes saved calibration JSON.
- Product reference value: high for tracking-origin operator tools.
- Architecture pattern: CLI commands plus calibrator state machine plus saved
  transform profile.
- Reusable method: represent calibration as replaceable strategies with
  progress/status and explicit end conditions.
- Constraints and caveats: Monado/WiVRn dependency, Linux orientation, device
  role assumptions, and continuous mode requires a rigid tracker-to-HMD mount.
- What to inspect next: floor method, profile naming, and UI opportunities for
  non-terminal users.
- Why it matters for `VR-apps-lab`: it is a strong modern contrast to older
  OpenVR calibration utilities.

### `dag10/HoloViveObserver`

- Interesting idea: a HoloLens observer and a Vive player can align shared
  space by asking the HoloLens user to place a floating controller target and
  the Vive user to click the corresponding physical controller pose.
- Code donor value: medium as historical UX. `AlignmentManager.cs` coordinates
  alignment state, controller availability, target pose, finish/cancel events,
  and local transform application. `AlignmentClient.cs` creates the floating
  controller target, sends target info, requests alignment, applies final
  offset/rotation, and listens for manager events. `ControllerAlignment.cs`
  sends trigger clicks during alignment. `HoloViveNetworkManager.cs` separates
  VR and HoloLens player prefabs and auto creates/joins a default Unity
  multiplayer match.
- Product reference value: medium-high for mixed-device observer workflows.
- Architecture pattern: networked alignment manager plus role-specific clients
  plus controller-click calibration.
- Reusable method: make mixed-device alignment an explicit two-party ritual,
  not a hidden offset.
- Constraints and caveats: old Unity 5.x, modified SteamVR/HoloToolkit,
  Unity cloud multiplayer, checked-in build artifacts in the repository, and
  legacy code quality issues such as a recursive `IsAligned` getter.
- What to inspect next: modern equivalents using OpenXR anchors or WebRTC
  shared-room approaches.
- Why it matters for `VR-apps-lab`: it is a historical product pattern for
  shared-room observer calibration.

### `yshui/index_camera_passthrough`

- Interesting idea: headset camera passthrough can be modeled as a capture and
  projection pipeline feeding a configurable VR overlay, with explicit tradeoffs
  between "from camera" and "from eye" projection.
- Code donor value: high for Linux/display-surface architecture. `main.rs`
  finds the Valve Index camera through udev, writes first-run config/actions,
  captures V4L frames with one mmap buffer, tracks capture timestamps, and
  coordinates overlay state. `config.rs` defines backend, camera device,
  display mode, HMD/sticky/absolute positioning, two-controller toggle, open
  delay, z-order, and debug settings. `pipeline.rs` documents camera data to
  upload, YUYV conversion, lens correction, projection, and final output.
  `projection.rs` computes per-eye MVPs using camera calibration, HMD pose,
  overlay transform, and projection mode. `vrapi.rs` abstracts OpenVR/OpenXR
  texture submission, action state, overlay show/hide, position, and display
  mode.
- Product reference value: high for camera-to-overlay utilities and Linux
  passthrough experiments.
- Architecture pattern: capture thread plus GPU processing pipeline plus VR
  backend trait plus configurable overlay placement.
- Reusable method: document optical/projection tradeoffs and expose position
  modes rather than pretending passthrough is perfect.
- Constraints and caveats: Linux/Index camera focus, motion-sickness warning,
  OpenVR/OpenXR backend limitations, and experimental projection quality.
- What to inspect next: OpenXR backend implementation, distortion correction,
  and controller-follow overlay TODO.
- Why it matters for `VR-apps-lab`: it is a strong camera-to-overlay reference
  without being a general passthrough product.

## Cross-Project Synthesis

Good microhelpers have a compact structure:

- one sharp user problem
- source signal adapter
- target action/display/calibration sink
- small state machine
- explicit safety gates
- profile/config persistence
- monitor or feedback mode
- narrow caveat list

For `VR-apps-lab`, this reinforces that small VR tools can be strategically
important when they expose their translation boundary and do not pretend to be
general-purpose engines.
