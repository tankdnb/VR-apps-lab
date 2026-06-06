# VR Projects Wave 185: Accessibility, Embodied Locomotion, Redirected Walking, and Zero-G Control

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 185 studies locomotion as reusable utility design: embodied wheelchair
movement, accessibility mode packaging, hub/modifier abstractions, zero-G
grab/thruster controls, and redirected-walking tools with logging.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `justinmajetich/vr-wheelchair` | Wheelchair locomotion rig for Unity/XRI | Strong embodied input reference |
| `XR-Access-Initiative/Locomotion-Accessibility-Toolkit` | Accessibility mode package around XRI locomotion | Product/accessibility reference |
| `simeonradivoev/echo-unity` | Zero-G grab, thruster, IK, and 3D UI mechanics | Strong movement mechanics donor |
| `DigitalDiceworks/ddw-locomotion-system` | Natural locomotion hub/input/modifier system | Strong abstraction donor |
| `curvaturegames/space-extender` | Redirected walking Unity package | Strong redirector/tooling donor |
| `LariWa/VR-Locomotion` | Empty repo from search | Excluded/source-light note |

## `justinmajetich/vr-wheelchair`

- Interesting idea:
  model locomotion around wheelchair embodiment instead of treating locomotion
  only as stick/teleport movement.
- Code donor value:
  high for wheel interaction, disposable grab points, brake assist, haptics,
  and controller-velocity sampling.
- Product reference value:
  high for accessibility, embodiment, training, empathy, and alternative
  locomotion UX.
- What to inspect next:
  body-size scaling, dynamic braking, and haptic/audio feedback completion.
- Source evidence:
  `README.md`, `Assets/Prefabs/VRWC_WheelchairRig.prefab`,
  `VRWC_WheelInteractable.cs`, `VRWC_GrabPoint.cs`,
  `VRWC_XRNodeVelocitySupplier.cs`, and `VRWC_WheelAudio.cs`.
- Reusable pattern extraction:
  embodied wheel-grab locomotion rig.
- Reusable core:
  make wheels XR interactables, spawn a disposable jointed grab point at the
  user's hand, force-select the proxy, cancel when the hand drifts away, brake
  when hand velocity approaches zero, and map wheel deceleration to haptics.
- Do not copy directly:
  prototype-only prefab setup, hardcoded thresholds, or one embodiment as the
  only accessibility solution.
- Caveats:
  stronger as input/embodiment pattern than as complete accessibility toolkit.

## `XR-Access-Initiative/Locomotion-Accessibility-Toolkit`

- Interesting idea:
  package multiple locomotion styles for users with different physical
  abilities: gaze teleportation, smooth controller locomotion, and snap turn.
- Code donor value:
  low-medium because much of the project is XRI sample/package content.
- Product reference value:
  high for accessibility framing and mode-set documentation.
- What to inspect next:
  identify any custom controls beyond imported XRI starter assets.
- Source evidence:
  `README.md`, `VRC 8-Meta First Hand project/Packages/manifest.json`,
  `Assets/Scenes/ClockTowerVR.unity`, XRI starter assets, and instruction UI
  images.
- Reusable pattern extraction:
  accessibility locomotion option pack.
- Reusable core:
  present locomotion as a configurable menu of supported modes, document which
  physical abilities each mode assumes, and include in-world instructions for
  teleport, smooth movement, and snap turning.
- Do not copy directly:
  APK artifacts, imported samples as original code, or accessibility claims
  without user testing.
- Caveats:
  useful as product framing; limited custom code was visible.

## `simeonradivoev/echo-unity`

- Interesting idea:
  recreate zero-G locomotion with hand grabs, physics joints, thrusters,
  procedural IK, dynamic object interaction, and realistic/comfort movement
  toggle.
- Code donor value:
  high for grab-depth grace, static/dynamic joint split, release behavior,
  thruster heat, and 3D touch/UI details.
- Product reference value:
  high for embodied non-walking locomotion, training, and in-headset tool
  interactions.
- What to inspect next:
  separate player-essential mechanics from demo-specific UI and art.
- Source evidence:
  `README.md`, `Assets/Scripts/Mechanics/GrabMoveController.cs`,
  `ThrustersController.cs`, `RealisticMovementController.cs`,
  `HandIKController.cs`, `GrabObject.cs`, and UI scripts.
- Reusable pattern extraction:
  zero-G grab/thruster movement with comfort toggle.
- Reusable core:
  use grab grace windows, penetration checks, hand rigidbodies, static and
  dynamic configurable joints, mass-scale tuning, release dampening, heat-based
  thrusters, and a realism toggle that switches body rotation constraints and
  physically accurate release.
- Do not copy directly:
  game-specific objective code, demo assets, and performance-heavy mesh
  intersection code without profiling.
- Caveats:
  strong donor, but larger than a utility micro-sample.

## `DigitalDiceworks/ddw-locomotion-system`

- Interesting idea:
  split natural locomotion into hub, active input providers, movement
  consumers, and modifiers such as sprint.
- Code donor value:
  high for clean abstraction boundaries and XML-documented Unity components.
- Product reference value:
  high for future configurable locomotion tools and labs.
- What to inspect next:
  input implementations under `Scripts/Inputs` and compatibility with modern
  XR Input System.
- Source evidence:
  `docs/system.md`, `Assets/NaturalLocomotion/Scripts/LocomotionHub.cs`,
  `NaturalInput.cs`, `TranslationMovement.cs`, `RigidbodyMovement.cs`, and
  `ToggleSprint.cs`.
- Reusable pattern extraction:
  locomotion hub with input/modifier/movement split.
- Reusable core:
  active inputs register with a hub, the hub distinguishes primary and
  secondary input, modifiers transform normalized vectors, movement consumers
  subscribe to `onInput`, and end-primary events reset physics state.
- Do not copy directly:
  old SteamVR package contents or legacy project setup.
- Caveats:
  abstraction is more valuable than bundled legacy dependencies.

## `curvaturegames/space-extender`

- Interesting idea:
  provide a Unity package for redirected walking and level-design assistance:
  translation gains, rotation gains, overlapping rooms, custom editor UI, and
  CSV logging.
- Code donor value:
  high for gain application, redirector base class, editor surface, and
  redirection telemetry.
- Product reference value:
  high for locomotion research tools and spatial design diagnostics.
- What to inspect next:
  sample prefabs, minimap/editor UX, and modern XR compatibility.
- Source evidence:
  `package.json`, `Runtime/Redirectors/BaseRedirector.cs`,
  `TranslationRedirector.cs`, `RotationRedirector.cs`,
  `OverlappingRedirector.cs`, `SpaceExtenderLoggingManager.cs`, and editor
  scripts.
- Reusable pattern extraction:
  redirected-walking gain tool with telemetry.
- Reusable core:
  define start/end play areas, apply redirection to a parent play-area object,
  derive gain from HMD translation or rotation, clamp progress, expose events
  for start/end, and log redirector ID, duration, and total real rotation to
  CSV.
- Do not copy directly:
  old Unity version assumptions, singleton auto-creation, or equality checks on
  floats as final quality.
- Caveats:
  strong research tooling donor with modernization needs.

## `LariWa/VR-Locomotion`

- Interesting idea:
  search result described a comparison of locomotion techniques.
- Code donor value:
  none in this pass; clone contained no files.
- Product reference value:
  low until source appears.
- What to inspect next:
  revisit only if the repository gains content.
- Source evidence:
  empty clone under `.research-sources/github/LariWa/VR-Locomotion`.
- Reusable pattern extraction:
  none.
- Caveats:
  exclude from studied donor lists.

## Cross-Project Lessons

- Good locomotion references expose the physical assumptions of the user, not
  just the input mapping.
- Accessibility should be documented as a matrix of options and ability
  requirements.
- Movement systems become reusable faster when input, modifiers, and movement
  consumers are separate components.
- Redirection and comfort tools need telemetry/logging to become useful
  research instruments.
- Zero-G systems need explicit comfort toggles because physical realism and
  usability pull in different directions.

## Reuse Recommendations

1. Use `ddw-locomotion-system` as the clearest hub/modifier/movement
   abstraction donor.
2. Use `space-extender` as the strongest redirected-walking and telemetry donor.
3. Use `echo-unity` for zero-G grab/thruster mechanics and comfort toggles.
4. Use `vr-wheelchair` for embodied wheel-grab and haptic/brake patterns.
5. Treat `Locomotion-Accessibility-Toolkit` as an accessibility framing
   reference, not as a deep custom-code donor.
