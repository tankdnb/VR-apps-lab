# Wave 366: Avatar Embodiment Mirror Therapy Tool Use Calibration and Movement Study Harnesses

## Scope

This wave studies embodiment-heavy VR projects where calibration is the product:
self-avatar target offsets, SteamVR universe alignment, tool-use tasks, mirror
therapy rigs, hand tracking, task flow, and movement recording.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `JashoBell/vr-tool-use` | Studied | Dissertation study harness with participant calibration, avatar IK target calibration, universe alignment, tool/reaching tasks, UXF logging, VRPN/Manus/OpenVR trackers, and One Euro filters |
| `eric-cornellvel/VR-MirrorTherapy` | Studied | Mirror-therapy Unity project with custom mirror rig scripts, hand tracking, sphere tasks, save data helpers, object/transform following, and Oculus SDK caveats |

## Reusable Pattern Extraction

- Pattern candidate: `embodiment calibration and mirrored-body study shell`.
- Problem solved: embodiment tools need explicit calibration, validation,
  target offsets, task sequencing, and telemetry before avatar or mirror effects
  are meaningful.
- Reusable core: participant setup, tracker inventory, universe alignment,
  avatar selection, IK target finder, target offset persistence, mirrored body
  mapper, task generator, instruction/audio channel, movement recorder, filter,
  save/export layer, and manual override path.
- Source evidence: vr-tool-use includes `ParticipantCalibration`,
  `AvatarCalibration`, `ExperimentCalibration`, `AvatarHandler`, VRPN/OpenVR/
  Manus trackers, task scripts, and One Euro filters; VR-MirrorTherapy includes
  `VRMirror`, `VRRig`, `MixamoOVRHandTracking`, `TransformFollow`,
  `ObjectFollow`, `SphereSpawner`, `SphereDetection`, and `SaveData`.
- Abstraction boundary: calibration should produce persistent offsets and
  validation state; task scripts should consume calibrated poses without owning
  hardware setup.
- What not to copy: clinical claims, participant data assumptions, paid FinalIK
  or device SDK assumptions, hardcoded PlayerPrefs keys, or mirrored-limb
  behavior without safety/ethics labels.
- Method catalog action: create an embodiment calibration method.

## Project Notes

### `JashoBell/vr-tool-use`

- Interesting idea: a research-grade embodiment study uses explicit
  participant calibration, avatar target calibration, universe validation, task
  generation, and high-rate tracker recording.
- Code donor value: very high for calibration flow, target offset persistence,
  avatar loading/target attachment, task sequencing, movement trackers, and
  filtering.
- Product reference value: strong for embodiment, avatar setup, tool-use study,
  and motion-analysis utilities.
- What to inspect next: export schemas, anonymization, tracker failure states,
  and how the results repository maps to raw logs.
- Caveats: research stack with FinalIK, Manus, VRPN, SteamVR, and Vive eye
  tracking dependencies; reuse boundaries, not hardware assumptions.

### `eric-cornellvel/VR-MirrorTherapy`

- Interesting idea: mirror therapy is implemented as a rig/mirror layer with
  hand tracking, transform following, sphere spawning/detection tasks, skin
  color adjustment, and data saving.
- Code donor value: moderate to high for mirror/body mapping, task objects,
  save helpers, and hand-tracking rig glue.
- Product reference value: useful for rehab-adjacent mirror-body interaction
  and embodied feedback.
- What to inspect next: exact mirror mapping, task scoring, session export,
  comfort/clinical caveats, and Oculus SDK removal boundary.
- Caveats: large bundled Oculus SDK; no clinical claims should be copied.

## Product Direction

This wave supports an `embodiment calibration lab` branch: future tools can
share tracker inventory, avatar/mirror calibration, task sequencing, and
movement export before choosing a particular avatar SDK or clinical framing.

