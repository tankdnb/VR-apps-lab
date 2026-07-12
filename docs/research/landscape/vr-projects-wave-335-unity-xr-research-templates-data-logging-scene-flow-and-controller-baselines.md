# Wave 335 - Unity XR Research Templates, Data Logging, Scene Flow, and Controller Baselines

This wave studies Unity XR research scaffolds and minimal controller baselines:
Quest-oriented project templates, data logging, player singletons, scene flow,
Meta Interaction SDK coexistence, and a small XR player controller example.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to:

- Unity XR research templates and open templates;
- player/data/scene manager architecture;
- data export and experiment telemetry;
- minimal locomotion/controller baselines and empty rejected candidates.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `TAU-XR/TAUXR-Research-Template` | Unity XR research template and data logging scaffold | Studied | Strong product/architecture reference for base scene, TXR player, data manager, scene manager, continuous CSV logs, hand/eye/face tracking surfaces, and Meta Interaction SDK coexistence |
| `TAU-XR/TAUXR-OpenTemplate` | Unity XR open template variant | Studied | Useful variant of the same template lineage with similar docs plus packaged sample/editor assets; reinforces the reusable base-scene/data-manager shape |
| `dilmerv/XRToolKitPlayerController` | Minimal Unity XR player controller baseline | Studied | Useful micro-donor for explicit XRNode device lookup, joystick movement, jump button gating, rigidbody/capsule setup, and test-scene existence checks |
| `traggett/UnityXRInteractionToolkitExtensions` | Empty Unity XR extension candidate | Rejected/empty | No code donor value in current clone; keep as a dedupe note only |

## Code-Level Findings

### `TAU-XR/TAUXR-Research-Template`

- Interesting idea: XR research projects benefit from a base scene that already
  has a player singleton, data manager, scene manager, calibration, and
  optional Meta Interaction SDK coexistence.
- Code donor value: medium-high as a structural reference. The strongest
  evidence is in docs and prefabs rather than a small isolated package. Docs
  describe `TXRPlayer`, `TXRDataManager`, `TXRSceneManager`, continuous data
  writer, face expression exporter, hand/controller/pinch managers, eye
  tracking, exported CSVs under persistent data, additive scene loading, and
  player repositioning.
- Product reference value: very high for future VR experiment helper apps and
  telemetry scaffolds.
- What to inspect next: `Assets/TAUXR` scripts for concrete CSV schema,
  singleton lifetime, calibration flow, and session/trial/round managers.
- Architecture pattern: base scene + player singleton + data manager + scene
  manager + experiment flow managers.
- Reusable method: XR research template with telemetry scaffold.
- Constraints / caveats: large Unity template with third-party packages and
  Quest/Meta assumptions; reuse concepts, not wholesale assets.

### `TAU-XR/TAUXR-OpenTemplate`

- Interesting idea: an open template variant can ship the same research-facing
  TXR structure with sample scenes and packaged settings, making it a public
  onboarding baseline.
- Code donor value: medium. The docs mirror research-template concepts:
  `TXR_Player`, `TXR_DataManager`, `TXR_SceneManager`, continuous logging,
  face expression export, eye tracking, additive scenes, and Meta Interaction
  SDK coexistence.
- Product reference value: high for public sample organization and onboarding.
- What to inspect next: differences from Research Template, sample UI set
  scenes, package dependency surface, and whether docs are generated or hand
  maintained.
- Caveat: template-heavy and includes many third-party/vendor assets; direct
  copying is inappropriate.

### `dilmerv/XRToolKitPlayerController`

- Interesting idea: a small player-controller repo can serve as a readable
  locomotion baseline with tests that verify the scene and component exist.
- Code donor value: medium. `XRPlayerController.cs` requires rigidbody and
  capsule collider, configures collider shape, resolves an `InputDevice` from
  an `XRNode`, reads `CommonUsages.primary2DAxis` for movement, reads
  `primaryButton` for jump gating, and uses ground checks. Tests load the
  `XRPlayerController` scene and assert `XRRig` plus component presence.
- Product reference value: medium for beginner-friendly controller baselines
  and smoke-test shape.
- What to inspect next: modern XR Origin replacement for `XRRig`, movement
  relative to headset/controller, and physics safety.
- Caveat: old Unity/XR Interaction Toolkit naming and simple movement logic.

### `traggett/UnityXRInteractionToolkitExtensions`

- Interesting idea: none confirmed from source.
- Code donor value: none. The repository cloned as empty.
- Product reference value: none beyond a dedupe/rejected note.
- What to inspect next: only if the repo later gains content.
- Caveat: do not include as a donor.

## Reusable Pattern Extraction

- Pattern candidate: XR research template and telemetry scaffold.
- Problem solved: research and lab VR apps repeatedly need player references,
  hand/controller/eye/face tracking surfaces, structured logging, scene flow,
  and calibration before the actual experiment starts.
- Reusable core: base scene, player singleton, data manager, continuous writer,
  event logger, face/eye optional exporters, scene manager, additive scene
  switching, calibration state, session/trial/round managers, and lightweight
  smoke-test scene checks.
- Source evidence: `TAU-XR/TAUXR-Research-Template`,
  `TAU-XR/TAUXR-OpenTemplate`, and `dilmerv/XRToolKitPlayerController`.
- Abstraction boundary: keep player state, data collection, scene flow,
  calibration, experiment flow, and vendor SDK integration separate.
- What not to copy: large third-party package payloads, vendor-specific Quest
  assumptions without adapters, old `XRRig` assumptions, or empty extension
  repos as evidence.
- Method catalog action: add XR research template and telemetry scaffold.

## Follow-Up Gaps

- Inspect TAUXR concrete scripts for CSV schema, session/trial flow, and
  singleton lifecycle.
- Compare Unity research-template architecture with Godot spatial/wrist UI and
  tracker recording waves.
- Define a public `VR-apps-lab` experiment-template checklist without copying
  vendor assets.
