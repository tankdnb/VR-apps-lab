# Wave 348: Gaze Eye Analytics Saccade Fixation and XR Behavior Telemetry

## Scope

This wave studies projects that turn eye/head/user behavior into reusable VR
signals. The useful pattern is the split between live gaze ingress,
calibration, confidence filtering, online events, offline fixation/heatmap
analysis, tracker orchestration, privacy gates, and dashboard-facing telemetry.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `MotorControlLearning/SaccadeVR-mobile` | Source-light reference | Mobile/Vive Pro Eye saccade study marker that reinforces the need to separate experiment protocol from detector logic |
| `pupil-labs/hmd-eyes` | Studied | Unity/Pupil network plug-in with RequestController, SubscriptionsController, calibration flow, Gaze/Pupil listeners, time sync, recording, annotations, screencast, and eye-frame visualization |
| `AndreZenner/saccade-detection` | Studied | Unity/Vive Pro Eye online saccade and blink detector with speed/acceleration/noise thresholds, event callbacks, test scenarios, CSV logging, and inspector tuning |
| `ViveSoftware/VRS-Studio-OpenXR` | Studied as vendor sample bundle | HTC OpenXR feature showcase with eye gaze, facial/body tracking, Ultimate Tracker, spectator camera, hand interaction, and vendor-capability gating |
| `Robertson-Lab/vrGazeCore-Toolbox` | Studied | MATLAB/Python toolbox for raw VR gaze processing into fixations, duration-weighted and time-segmented density maps, confidence filtering, headset-specific parameters, and output folders |
| `GossipAnalyticsXR/Gossip_Analytics_Unity-SDK` | Studied | Unity XR analytics SDK with auto-trackers, heatmaps, eye/hand/controller tracking, session/performance/device trackers, build checks, environment keys, and uninstall tooling |

## Reusable Pattern Extraction

- Pattern candidate: `XR gaze analytics boundary`.
- Problem solved: gaze data is useful only when live device ingress, confidence,
  calibration, online events, offline analysis, dashboards, and privacy are not
  tangled into one experiment script.
- Reusable core: eye provider adapter, calibration controller, confidence and
  mapping-context filter, gaze ray or fixation event stream, online saccade/
  blink detector, timestamp converter, recorder/annotation channel, offline
  fixation and heatmap batch job, tracker registry, scene/play-area metadata,
  privacy policy, and capability labels.
- Source evidence: hmd-eyes separates Pupil requests/subscriptions from
  listeners and calibration; saccade-detection exposes tunable detector
  thresholds and events; vrGazeCore converts raw data into fixations and
  heatmaps; Gossip auto-deploys trackers and heatmap capture behind settings.
- Abstraction boundary: application logic should consume normalized gaze/
  fixation/events, not vendor message dictionaries or analytics SDK internals.
- What not to copy: raw gaze uploads without consent, fixed confidence
  thresholds, hidden dashboard dependencies, forced production screenshot
  capture, vendor-only APIs without fallback, or calibration UI that cannot be
  audited.
- Method catalog action: create a new gaze analytics method.

## Project Notes

### `MotorControlLearning/SaccadeVR-mobile`

- Interesting idea: saccade studies need mobile/VR experiment shells that keep
  protocol, detector, and logged metrics separable.
- Code donor value: modest due to thin visible source signal in this pass.
- Product reference value: useful as a study-design marker.
- What to inspect next: task protocol, data schema, and whether detector code is
  reusable outside the original experiment.
- Caveats: treat as source-light until deeper file evidence is collected.

### `pupil-labs/hmd-eyes`

- Interesting idea: eye tracking is wrapped as a Unity plug-in with a network
  layer, high-level Pupil/Gaze listeners, and flow-control components.
- Code donor value: high for RequestController, SubscriptionsController,
  GazeListener, PupilListener, GazeController, CalibrationController, TimeSync,
  RecordingController, AnnotationPublisher, ScreenCast, and FrameVisualizer.
- Product reference value: strong for a gaze-provider module in future VR
  utilities.
- What to inspect next: message parsing, NetMQ lifecycle, replay behavior, and
  a normalized provider interface across Pupil/OpenXR/Vive.
- Caveats: old Unity/.NET requirements and explicit warning not to copy the
  plugin folder directly.

### `AndreZenner/saccade-detection`

- Interesting idea: online saccade/blink detection becomes a Unity component
  with inspector-tunable velocity, acceleration, noise, sample, and break
  thresholds.
- Code donor value: high for `SaccadeDetection.cs`, event callbacks, test
  scenarios, logging, and CSV replay/simulation hooks.
- Product reference value: strong for live interaction triggers, redirected
  walking research, and gaze diagnostics.
- What to inspect next: false-positive handling, device-specific SRanipal
  assumptions, and detector abstraction away from SteamVR/Vive Pro Eye.
- Caveats: Unity package plus vendor SDK requirements; parameters are not
  universal.

### `ViveSoftware/VRS-Studio-OpenXR`

- Interesting idea: vendor samples bundle eye gaze with facial/body tracking,
  hand interaction, Ultimate Tracker, and spectator-camera features.
- Code donor value: moderate as a feature-gating and sample-scene reference.
- Product reference value: useful for capability inventory and vendor extension
  UX.
- What to inspect next: OpenXR feature enablement, eye-gaze action paths, and
  fallback labels for unsupported hardware.
- Caveats: vendor sample breadth is high, but reuse must avoid direct
  dependency on one device stack.

### `Robertson-Lab/vrGazeCore-Toolbox`

- Interesting idea: raw VR eye-tracking data is converted into fixations,
  density maps, time-segmented heatmaps, GIFs, and group-level outputs.
- Code donor value: high for `findFixations`, `fix2Heat`, confidence filtering,
  headset parameters, viewport degree conversion, and result directory shape.
- Product reference value: strong for offline analytics and study reporting.
- What to inspect next: Python parity with MATLAB, equirectangular edge
  handling, and import adapters for modern headset exports.
- Caveats: MATLAB toolbox dependencies and research-tool maturity.

### `GossipAnalyticsXR/Gossip_Analytics_Unity-SDK`

- Interesting idea: XR analytics is a deployable Unity package with automatic
  tracker setup, environment keys, tracker inventory, heatmaps, and reversible
  uninstall.
- Code donor value: high for tracker registry, auto tracker host, build
  preprocessor, settings asset, heatmap capture, and per-domain components.
- Product reference value: strong for analytics-product UX and instrumentation
  onboarding.
- What to inspect next: payload schema, offline/local mode feasibility,
  consent UI, and privacy-safe defaults.
- Caveats: hosted dashboard/subscription dependency and production image
  capture behavior need explicit privacy gates.

## Product Direction

This wave supports a `gaze and behavior analytics` branch for VR utilities:
live gaze providers, event detectors, local recorders, offline heatmaps,
instrumented UX diagnostics, and privacy-aware dashboards.

