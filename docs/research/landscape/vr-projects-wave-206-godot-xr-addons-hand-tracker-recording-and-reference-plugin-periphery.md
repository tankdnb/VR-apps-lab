# VR Projects Wave 206: Godot XR Addons, Hand/Tracker Recording, and Reference Plugin Periphery

- Date: `2026-06-06`
- Research mode: GitHub code-reading pass
- Execution rule: static source-reading only; no external project was run,
  built, installed, or launched.
- Related program docs:
  - `../program/github-research-wave-206-plan.md`
  - `../program/github-research-wave-206-backlog.md`

## Why This Wave Matters

Godot XR is useful to `VR-apps-lab` not only as an engine, but as a set of
addon boundaries: hand pose recognition, pose-gated pickup, tracker sources,
recording, toolkit nodes, and native `XRInterface` plugins. Wave 206 studies
those boundaries as reusable patterns for future VR utilities.

The most important recurring seam is:

`external pose/protocol source -> normalized Godot tracker/hand/animation state`

## Project Findings

### `patrykkalinowski/godot-xr-kit`

- Interesting idea:
  bundle several XR utility primitives - hand-pose recognition, physics
  movement, input smoothing, and cinematic view - as a Godot addon kit.
- Code donor value:
  `hand_pose_recognition.gd` loads pose templates from JSON, compares bone
  quaternion angles against the current skeleton, early-exits when the
  accumulated error is already worse than the best candidate, thresholds the
  recognized pose, and emits a `new_pose` signal.
- Product reference value:
  useful as a compact addon-pack shape for small VR utility primitives.
- Architecture pattern:
  template-based hand-pose recognizer with signal output.
- Reusable method:
  serialize hand pose templates and make recognition emit stable pose-change
  events instead of leaking raw bone comparisons to consumers.
- Constraints / caveats:
  threshold and template quality drive behavior; parts of the kit are
  prototype-like.
- What to inspect next:
  compare pose template format with RevolNoom's pose catalogue and VRCFT/hand
  calibration tools.
- Why it matters for `VR-apps-lab`:
  hand-pose utilities need reproducible pose catalogs, not one-off gesture
  checks inside scene code.

### `RevolNoom/godot_xr_handtracking`

- Interesting idea:
  hand poses can gate object pickup and snapping, making hand interaction
  declarative at the object area level.
- Code donor value:
  `hand_pose_matcher.gd` compares current skeleton pose against catalogue
  poses and stabilizes recognized output. `xr_pick_area.gd` exposes
  pose-change, touch, and ranged pickup modes, stores allowed poses, finds
  hand-snap targets, validates parent/layer/setup configuration, and routes
  picked/dropped callbacks to the parent object.
- Product reference value:
  strong hand-interaction reference because it models object affordance as
  "this area is pickable under these poses."
- Architecture pattern:
  pose catalogue + hand snap + pick area contract.
- Reusable method:
  attach interaction constraints to target objects, not only to global hand
  controllers.
- Constraints / caveats:
  no controller support and limited physics/highlighting maturity.
- What to inspect next:
  compare with `godot-xr-tools2` pickup/snapping and Unity XR Interaction
  Toolkit affordance patterns.
- Why it matters for `VR-apps-lab`:
  pose-gated object interaction is useful for tool menus, calibration handles,
  and in-headset authoring surfaces.

#### Reusable Pattern Extraction

- Pattern candidate:
  `Pose-gated pick area with hand-snap contract`
- Problem solved:
  hand-tracking interactions need object-local rules for which poses can grab,
  snap, or activate a target.
- Reusable core:
  recognize stable hand poses, attach allowed-pose lists to pick areas, provide
  a hand-snap lookup, support touch/ranged/pose-change modes, and warn when
  setup is incomplete.
- Source evidence:
  `hand_pose_matcher.gd`, `xr_pick_area.gd`
- Abstraction boundary:
  pose recognizer owns skeleton matching; pick areas own affordance rules.
- What not to copy:
  hand-only assumptions, absent highlight feedback, or physics shortcuts.
- Method catalog action:
  add to modular XR toolkit primitive method.

### `Malcolmnixon/GodotXRVmcTracker`

- Interesting idea:
  receive VMC/OSC body and face data and republish it through Godot's `XRServer`
  trackers.
- Code donor value:
  `vmc_source.gd` registers `XRFaceTracker` and `XRBodyTracker`, listens to
  UDP OSC packets, handles `/VMC/Ext/Bone/Pos` and `/VMC/Ext/Blend/Val`,
  supports FREE/CALIBRATE/LOCKED position modes, transforms VMC-relative data
  into absolute joint transforms, maps to Godot body joints, sets root
  transforms under hips, and updates pose confidence. `osc_reader.gd` parses
  OSC messages and bundles.
- Product reference value:
  strong bridge donor for external mocap or avatar protocols entering a game
  engine.
- Architecture pattern:
  protocol source node -> normalized tracker updates -> Godot XRServer.
- Reusable method:
  keep protocol parsing, position mode/calibration, joint mapping, and tracker
  publication separated.
- Constraints / caveats:
  port/path assumptions and limited packet auth/rate diagnostics.
- What to inspect next:
  compare VMC mapping with Rokoko, Axis Studio, and VRM/VMC recorder projects.
- Why it matters for `VR-apps-lab`:
  this is a clean source-to-engine-tracker bridge shape.

#### Reusable Pattern Extraction

- Pattern candidate:
  `Godot protocol source to XRServer tracker bridge`
- Problem solved:
  external body/face/tracker streams need to become engine-native trackers
  before in-engine tools can reuse them.
- Reusable core:
  read protocol packets, normalize joint/blend values, preserve position mode
  and calibration state, publish to `XRBodyTracker`/`XRFaceTracker`, set
  confidence flags, and expose stale/connection diagnostics.
- Source evidence:
  `vmc_source.gd`, `osc_reader.gd`, `vmc_body.gd`
- Abstraction boundary:
  source plugin owns packet parsing and mapping; Godot consumers read XRServer
  trackers.
- What not to copy:
  fixed ports, unauthenticated OSC, or protocol-specific joints leaking into
  game logic.
- Method catalog action:
  create Godot tracker bridge method.

### `Malcolmnixon/GodotXRAxisStudioTracker`

- Interesting idea:
  Axis Studio packets can follow the same Godot XRServer tracker bridge
  pattern as VMC.
- Code donor value:
  `axis_studio_source.gd` reads vendor data, supports position modes, maps
  body joints, computes root transform, applies roll corrections, and publishes
  `XRBodyTracker` data.
- Product reference value:
  confirms the bridge method generalizes across vendor mocap protocols.
- Architecture pattern:
  vendor source plugin variant.
- Reusable method:
  reuse the same normalized tracker output boundary for each vendor protocol.
- Constraints / caveats:
  vendor mapping and calibration assumptions.
- What to inspect next:
  build a side-by-side vendor tracker source matrix.
- Why it matters for `VR-apps-lab`:
  variants show which parts of tracker bridges should be shared.

### `Malcolmnixon/GodotXRRokokoTracker`

- Interesting idea:
  a vendor mocap bridge can publish optional body, face, and finger tracking
  through one Godot XR source path.
- Code donor value:
  `rokoko_source.gd` handles body/fingers/face conditionally, maps vendor
  packets to Godot trackers, and sets tracking flags by available data.
- Product reference value:
  useful comparison node for optional tracking modalities.
- Architecture pattern:
  multi-modality vendor tracker source.
- Reusable method:
  treat body, face, and fingers as optional capabilities rather than assuming
  all are present.
- Constraints / caveats:
  vendor packet assumptions and limited diagnostics.
- What to inspect next:
  compare optional modality handling with VRCFT and OpenXR body/face inputs.
- Why it matters for `VR-apps-lab`:
  future tracker helpers should degrade gracefully by available capability.

### `Malcolmnixon/GodotXROpenXRTracker`

- Interesting idea:
  thin demos show how OpenXR tracker data and world scale can be exposed in
  Godot scenes.
- Code donor value:
  demo scripts initialize XR, enable `use_xr`, disable vsync, and use
  controller buttons to scale skeleton motion and `XRServer.world_scale`.
- Product reference value:
  small reference for world-scale and body/hand tracker demo controls.
- Architecture pattern:
  demo-level tracker visualization and scale control.
- Reusable method:
  expose world-scale controls explicitly in tracker demos.
- Constraints / caveats:
  thin demo/reference, not a full plugin pass.
- What to inspect next:
  inspect deeper only if OpenXR tracker extension handling becomes a priority.
- Why it matters for `VR-apps-lab`:
  tracker diagnostics often need world-scale controls during calibration.

### `Malcolmnixon/GodotXRAnimationRecorder`

- Interesting idea:
  record live XR body/face/hand tracker streams into Godot animation resources.
- Code donor value:
  `tracker_recorder.gd` selects body/face/left/right hand trackers from
  `XRServer`, creates recording resources, and records frame data with
  monotonic time. `animation_recorder.gd` builds an `Animation`, creates
  skeleton position/rotation and face blendshape tracks, optionally records
  root motion, connects to `skeleton_updated`, and optimizes tracks on stop.
- Product reference value:
  strong donor for diagnostics, mocap capture, replay, and calibration
  workflows.
- Architecture pattern:
  tracker stream capture -> animation track writer.
- Reusable method:
  separate live tracker sampling from output resource writing.
- Constraints / caveats:
  Godot-specific animation tracks and no external export path inspected.
- What to inspect next:
  compare with BVH/FBX/VRM/VMC recorder projects.
- Why it matters for `VR-apps-lab`:
  recording/replay is a recurring diagnostic pattern for tracking tools.

#### Reusable Pattern Extraction

- Pattern candidate:
  `XR tracker stream to animation/resource recorder`
- Problem solved:
  live tracking bugs are hard to debug without capture and replay artifacts.
- Reusable core:
  select trackers by name, sample body/face/hand data at a stable cadence,
  preserve timestamps, write skeleton and blendshape tracks, record optional
  root motion, and optimize/export after stop.
- Source evidence:
  `tracker_recorder.gd`, `animation_recorder.gd`
- Abstraction boundary:
  tracker reader samples XRServer state; recorder writes engine-native assets.
- What not to copy:
  engine-only output formats as the only archival path, or hidden tracker-name
  assumptions.
- Method catalog action:
  create tracker stream recording method.

### `GodotVR/godot_xr_reference`

- Interesting idea:
  provide a minimal reference XR plugin that implements Godot's native
  `XRInterface` lifecycle, view transforms, projections, and simple input.
- Code donor value:
  `xr_interface_reference.cpp` binds properties for eye height, IPD,
  display/lens parameters, oversample, distortion, mouse/head tracking, and
  WASD movement; initializes the interface, registers a head tracker, sets the
  primary interface, and computes render target size, view count, camera
  transform, per-eye transform, and projection matrices.
- Product reference value:
  important baseline for anyone building custom runtime/display/device support
  inside Godot.
- Architecture pattern:
  minimal native `XRInterface` plugin skeleton.
- Reusable method:
  use a reference plugin as a learning path before adding product logic.
- Constraints / caveats:
  native build/submodule requirements and reference-only behavior.
- What to inspect next:
  compare with Godot OpenXR vendors plugin and Monado/OpenXR runtime adapters.
- Why it matters for `VR-apps-lab`:
  gives a native boundary for future Godot runtime experiments.

### `BastiaanOlij/godot-xr-tools2`

- Interesting idea:
  XR toolkit v2 is organized as modular nodes for hands, player movement,
  teleport, pickup, snapping, UI, debug, spectator, and staging.
- Code donor value:
  `xrt2_teleport.gd` is a strong example: hand attachment function, start/cancel
  and done signals, exported fade/input/rotation/color/raycast options,
  overridable `_check_can_teleport` and `_perform_teleport`, movement-provider
  disable while teleporting, fade tween, arc/raycast/target, slope and body
  collision checks.
- Product reference value:
  strong toolkit architecture reference because it shows reusable XR behavior
  as attachable functions rather than one monolithic player controller.
- Architecture pattern:
  hand attachment function plus movement-provider coordination.
- Reusable method:
  decompose XR player behavior into nodes with clear enable/disable and signal
  contracts.
- Constraints / caveats:
  WIP v2 and API stability risk.
- What to inspect next:
  compare with stable `godot-xr-tools` v1 and Unity XR Interaction Toolkit.
- Why it matters for `VR-apps-lab`:
  future Godot spikes should copy the modularity lesson, not the whole toolkit.

#### Reusable Pattern Extraction

- Pattern candidate:
  `Modular XR toolkit function node`
- Problem solved:
  XR player behavior becomes hard to reuse when locomotion, hands, UI, pickup,
  and comfort effects are fused into one controller.
- Reusable core:
  model each function as a node, expose exported options, emit state signals,
  coordinate with movement providers, support overridable checks, and keep fade
  or comfort effects explicit.
- Source evidence:
  `player/teleport_function/xrt2_teleport.gd`
- Abstraction boundary:
  function node owns one interaction; player/staging owns composition.
- What not to copy:
  WIP APIs or toolkit-global assumptions without version pinning.
- Method catalog action:
  create modular XR toolkit primitive method.

## Cross-Project Synthesis

### Strongest reusable methods

- Godot protocol source to XRServer tracker bridge.
- XR tracker stream to animation/resource recorder.
- Pose-gated pick area with hand-snap contract.
- Modular XR toolkit function node.
- Native `XRInterface` reference plugin baseline.

### Best product references

- `GodotXRVmcTracker` for external mocap to engine trackers.
- `GodotXRAnimationRecorder` for capture/replay diagnostics.
- `godot-xr-tools2` for modular toolkit composition.
- `godot_xr_handtracking` for pose-gated object affordances.
- `godot_xr_reference` for native plugin learning path.

### What Not To Copy

- fixed OSC ports and unauthenticated packet ingress;
- vendor joint names leaking into app logic;
- hand-only assumptions where controller fallback matters;
- recorder output without export/interchange planning;
- WIP toolkit APIs without version tracking.

## Placement

- Registry section:
  `Godot XR addon periphery: hands, tracker bridges, recording, and reference plugin baselines`
- Family section:
  `Godot XR addon periphery: hands, tracker bridges, recording, and reference plugin baselines`
- Methods:
  Godot tracker bridge, XR tracker stream recorder, modular XR toolkit
  primitive.
- Follow-up queue:
  Godot XR addon matrix across hand pose, pickup, tracker source, recorder,
  toolkit node, and native interface layers.
