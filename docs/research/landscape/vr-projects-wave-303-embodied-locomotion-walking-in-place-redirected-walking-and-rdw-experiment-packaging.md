# Wave 303 - Embodied Locomotion, Walking-in-Place, Redirected Walking, and RDW Experiment Packaging

This wave studies embodied locomotion and redirected-walking projects as
references for input-source adapters, walking-in-place modes, tracker
allocation, comfort overlays, joystick direction choices, RDW gains, impossible
spaces, and experiment metric capture.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- walking-in-place locomotion scripts and sensor adapters;
- redirected walking and impossible-space experiment packaging;
- locomotion comfort and direction references;
- source-light or fork-lineage RDW nodes only where they add comparison value;
- dedupe against older locomotion, comfort, and RDW waves.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `singaporetech/immersification-wip-locomotion` | Walking-in-place locomotion input adapters | Studied | Head/arm/leg/full-body input modes, movement aggregation, Vive tracker allocation, swing/step/lift detectors, and reset windows |
| `DarkerQueenSara/ProjetoVR-V2` | Redirected walking and impossible-space research prototype | Studied with research/student caveats | Translation/rotation gains, room graph/portal generation, teleport room handoff, and rich experiment metric CSVs |
| `tmitro/ucf-ist-redirected-walking` | RDWT lineage/source-light package reference | Studied as source-light/fork-lineage node | Vive/OpenVR redirected walking framework marker, but visible source is mostly vendored SteamVR/VRTK plus packaged RDWT artifact |
| `VRatPolito/CET-VR` | Training/product locomotion and comfort reference | Studied as product/reference node | XRI dynamic move provider, joystick movement affordances, blocked state, arrow direction, jump curve, and tunnelling comfort presets |

## Code-Level Findings

### `singaporetech/immersification-wip-locomotion`

- Interesting idea:
  walking-in-place locomotion can be a set of interchangeable magnitude sources
  feeding a common movement manager rather than one monolithic movement script.
- Code donor value:
  very high. `InputManager.cs` exposes direction/magnitude inputs.
  `MovementManager.cs` selects input source type, enables head/arm/leg/full-body
  components, aggregates movement input in a dictionary, resets stale values
  after a small time window, and applies Rigidbody velocity. `TrackerDeviceAllocator.cs`
  detects and assigns Vive trackers by OpenVR render model names and required
  tracker counts. `ArmSwingMovement.cs`, `HeadBobMovement.cs`, and
  `LegLiftMovement.cs` provide separate swing, bob, and leg-lift recognition
  strategies with thresholds, smoothing, acceleration/deceleration, and static
  checks.
- Product reference value:
  very high for embodied locomotion settings, accessibility locomotion
  profiles, and tracker-aware movement helpers.
- What to inspect next:
  calibration UI, tracker loss handling, comfort/safety limits, user tuning
  presets, seated mode, fallback input, and newer OpenXR tracker alternatives.
- Reusable pattern extraction:
  keep locomotion input sources as adapters that emit normalized movement
  magnitude/direction into a single movement manager.

### `DarkerQueenSara/ProjetoVR-V2`

- Interesting idea:
  redirected walking research code is most reusable when it pairs world gains
  and impossible-space room transitions with detailed experiment metrics.
- Code donor value:
  medium as research code. `RedirectedWalking.cs` applies translation gain
  inside tagged regions using `RD_VARs.TranslationGain`. `RotationGain.cs`
  rotates the world around the camera rig based on yaw delta. `Teleporter.cs`
  activates destination rooms, offsets the player by room deltas, and
  deactivates the initial room. `RoomFactory.cs` procedurally creates rooms,
  exits, doors, portals, and orientation maps. CSV artifacts expose sampled
  real/virtual positions, center/boundary distances, injected translations and
  rotations, gains, and sampling intervals.
- Product reference value:
  high for experiment packaging, impossible-space demos, and RDW metric
  schemas.
- What to inspect next:
  gain thresholds, collision safety, room graph constraints, participant
  consent, metric schema, VRTK/Oculus dependencies, and how teleport/RDW states
  are explained to users.
- Reusable pattern extraction:
  pair RDW gain logic with explicit experiment telemetry so redirected movement
  remains measurable and debuggable.

### `tmitro/ucf-ist-redirected-walking`

- Interesting idea:
  RDW repositories often function as packaging and lineage references even
  when the visible source is mostly vendor payloads.
- Code donor value:
  low/source-light in this pass. README-level material identifies an HTC
  Vive/OpenVR redirected walking framework using SteamVR plugin and VRTK, while
  the visible tree is dominated by vendored packages and an `RDWT-master.zip`
  artifact.
- Product reference value:
  medium as an RDWT lineage and packaging comparison node.
- What to inspect next:
  unpacked RDWT artifact, custom scripts outside vendored folders, license,
  version provenance, and difference from already studied `USC-ICT-MxR/RDWT`.
- Reusable pattern extraction:
  keep fork/lineage nodes as comparison evidence unless they expose new custom
  logic or experiment packaging.

### `VRatPolito/CET-VR`

- Interesting idea:
  training and evaluation projects often reveal locomotion product surfaces:
  direction modes, blocked states, visual arrows, jump curves, and tunnelling
  presets.
- Code donor value:
  medium. `DynamicMoveProvider.cs` from XRI starter assets blends head-relative
  and hand-relative movement direction per hand by input magnitude.
  `JoystickMovement.cs` manages walk/run/jump, blocked state, left/right pad
  modes, controller-facing arrow affordances, gravity/jump curves, and
  CharacterController movement. `VRTP_ExampleMovement.cs` shows a comfort
  preset surface for tunnelling, cages, skyboxes, smoothing, and mode switching.
- Product reference value:
  high for locomotion settings, comfort previews, and training app movement
  affordances.
- What to inspect next:
  custom training scripts, comfort-profile persistence, motion logging,
  vignette/tunnelling config, direction-mode UI, and whether locomotion blocks
  are tied to task state.
- Reusable pattern extraction:
  expose locomotion direction, blocked state, and comfort preset as user-facing
  utility controls instead of hidden scene constants.

## Reusable Pattern Extraction

- Pattern candidate:
  embodied locomotion boundary across input-source adapters, movement manager,
  tracker allocation, comfort controls, redirected-walking gains, and metrics.
- Problem solved:
  locomotion projects mix raw trackers, controller axes, gain manipulation,
  collision/room logic, comfort effects, and research logs. Reuse needs
  separable input, movement, comfort, and measurement layers.
- Reusable core:
  input source adapter, normalized magnitude/direction, tracker allocator,
  stale-input reset, movement manager, direction reference selector,
  blocked/safety state, comfort preset, translation/rotation gain module,
  room/portal graph, teleport handoff, real/virtual pose log, gain metric log,
  and calibration/tuning UI.
- Source evidence:
  `immersification-wip-locomotion`, `ProjetoVR-V2`,
  `ucf-ist-redirected-walking`, and `CET-VR`.
- Abstraction boundary:
  keep sensor allocation, locomotion recognition, movement application,
  comfort mitigation, RDW gain/world transform, room/portal transitions, and
  experiment telemetry separate.
- What not to copy:
  tracker render-model assumptions without fallback, fixed thresholds without
  calibration, RDW gains without safety/metrics, vendored package trees as
  donor evidence, or comfort modes without user-visible controls.
- Method catalog action:
  add an embodied locomotion and redirected-walking method.

## Follow-Up Gaps

- Deepen `immersification-wip-locomotion` as the strongest WIP donor.
- Treat `ucf-ist-redirected-walking` as a lineage/source-light node until the
  RDWT artifact or custom scripts are unpacked and compared.
- Compare RDW/RDW2/RDWT variants already studied with this wave so fork lines
  are not inflated as new product branches.
- Build a locomotion matrix across joystick, teleport, arm-swing, head-bob,
  leg-lift, tracker/full-body, redirected walking, comfort tunnelling, and
  experiment metric export.
