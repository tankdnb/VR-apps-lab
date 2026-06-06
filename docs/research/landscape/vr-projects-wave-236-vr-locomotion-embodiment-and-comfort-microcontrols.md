# VR Projects Wave 236: VR Locomotion, Embodiment, and Comfort Microcontrols

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies compact locomotion and embodiment donors: comfort blinders,
snap-turn fades, HMD-relative movement, delayed teleport, dynamic collider
height, and head/hand-only arm estimation.

## Why It Matters For `VR-apps-lab`

Many VR utilities need small movement, menu, or embodiment affordances even
when they are not games. The reusable value here is not "make a locomotion
system", but separate input, movement mode, comfort response, avatar/collider
adaptation, calibration, and caveats.

## Project Notes

### `RoWoCha/LocomotionVR`

- Interesting idea:
  comfort can be treated as a runtime response to movement speed and zone
  context, not just a static setting.
- Code donor value:
  `VRController.cs` uses HMD-relative joystick direction, ramps current speed,
  clamps it to max speed, updates `CharacterController` height/center from the
  camera local pose, and snap-turns around the head. `BlindersVR.cs` drives a
  post-processing vignette from speed/max-speed and exposes a snap-turn
  intensity pulse. `IntensityGate.cs` lets trigger volumes raise or lower max
  vignette intensity.
- Product reference value:
  strong micro-donor for comfort policy plus movement wrapper.
- What to inspect next:
  compare against movement-vignette implementations in game retrofit mods and
  accessibility locomotion systems.
- Architecture pattern:
  movement controller plus independent comfort visual policy plus environment
  comfort gates.
- Caveats:
  demo-level SteamVR project; do not copy scene/binding assumptions directly.

### `pascalmariany/Unity-WebXR-Teleportation-and-SmoothLocomotion`

- Interesting idea:
  smooth movement and teleport can coexist if teleport preview is delayed and
  commit is clearly separated from stick movement.
- Code donor value:
  `SmoothLocomotion.cs` reads WebXR controller thumbstick axes, applies a
  deadzone, optionally rotates movement by camera yaw, and translates the
  player. `WebXRTeleporterWrapper.cs` supports flat/controller/axis modes and
  uses axis hold to show a teleport preview after a delay, then commits on
  release. `VRTeleporter.cs` builds a capped ballistic arc with linecasts,
  places a marker on valid ground, and compensates for head/body offset when
  teleporting.
- Product reference value:
  useful WebXR movement/teleport UX donor for browser-native utilities.
- What to inspect next:
  compare axis-hold preview with XR Interaction Toolkit teleport providers and
  A-Frame teleport components.
- Architecture pattern:
  split smooth locomotion, teleport preview/commit, and arc/marker geometry.
- Caveats:
  demo wrapper around existing packages; scale constants and movement
  semantics need product-specific review.

### `dabeschte/VRArmIK`

- Interesting idea:
  a believable upper-body approximation can be built from HMD and hand poses if
  calibration, shoulder estimation, and arm constraints are explicit.
- Code donor value:
  `PoseManager.cs` persists HMD height and wrist width calibration. `VRArmIK.cs`
  computes elbow/arm geometry, clamps overextension, applies hand delta, and
  manages elbow rotation. `ShoulderPoser.cs` derives shoulders from head/hand
  relationships, handles hands behind the head, and constrains shoulder
  rotation relative to head rotation. `LocalVrTrackingInput.cs` copies XR node
  pose when available.
- Product reference value:
  strong embodiment donor for avatar preview, tool-hand offsets, and body
  hints in utility UIs.
- What to inspect next:
  compare with full-body IK, wrist-dashboard pose assumptions, and game-mod
  hand offset calibration.
- Architecture pattern:
  tracked input adapter, persisted body calibration, shoulder poser, arm solver,
  and avatar reference transforms.
- Caveats:
  optimized for Oculus Touch era input; visual plausibility is not anatomical
  truth.

### `ralph-immrsv/UnityVR-ArmSwingMovement`

- Interesting idea:
  arm-swing locomotion remains a useful search family, but this repository did
  not provide usable source in the checked tree.
- Code donor value:
  none from this pass; checkout contained only git/ignore metadata.
- Product reference value:
  retained as a dedupe/exclusion note to avoid re-adding the same empty result.
- What to inspect next:
  only revisit if source appears or a fork contains real implementation files.
- Architecture pattern:
  source-light search result.
- Caveats:
  not a studied donor.

## Reusable Pattern Extraction

- Pattern candidate:
  comfort-aware locomotion and embodiment microcontrol stack.
- Problem solved:
  small VR utilities need movement, teleport, snap turn, comfort feedback,
  collider/body adaptation, and hand/arm hints without turning into a full
  game locomotion framework.
- Reusable core:
  separate input adapter, movement mode, teleport preview/commit, comfort
  visual policy, environment comfort gates, body/collider calibration, and
  avatar/arm estimation.
- Source evidence:
  `LocomotionVR`, `Unity-WebXR-Teleportation-and-SmoothLocomotion`,
  `VRArmIK`, and the source-light `UnityVR-ArmSwingMovement` exclusion.
- Abstraction boundary:
  keep movement math independent from comfort rendering; keep teleport arc and
  marker independent from input binding; keep body calibration independent from
  avatar solver.
- What not to copy:
  demo scene assumptions, hardcoded controller bindings, old SteamVR/Oculus
  defaults, fixed comfort intensities, or embodiment math as medical/ergonomic
  truth.
- Method catalog action:
  add a method entry for comfort-aware locomotion and embodiment boundaries.

## Follow-Up Gaps

- Compare speed-linked vignette, snap-turn fade, movement vignette, and
  comfort-zone gates across standalone demos and retrofit mods.
- Build a teleport UX matrix around preview delay, arc shape, marker validity,
  head/body offset compensation, and release-to-commit semantics.
- Compare head/hand-only IK donors with wrist UI, full-body tracking, and
  calibration microhelpers.
