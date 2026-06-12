# Wave 274 - Playspace, Chaperone, Boundary, and Safety-Awareness Utilities

This wave studies VR playspace and safety-awareness utilities across OpenVR
chaperone queries, Echo VR position monitoring, MRTK boundary payloads, and
Quest mixed-reality intervention research.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- OpenVR chaperone/play-area access;
- player-position and playspace-abuse detection;
- boundary/teleport/playspace frameworks and artifact-heavy projects;
- Quest passthrough safety interventions;
- study logging and safety experiment orchestration.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `GiantSox/ChaperoneFail` | OpenVR chaperone query caution | Studied as failure reference | Shows a common unsafe API usage shape |
| `Graicc/Echo-Vr-Playspace-Abuse-Detector` | Player capsule and abuse detector | Studied with caveats | Local Echo API polling and follower playspace model |
| `benpaddlejones/VR-Playspace` | MRTK/Unity playspace payload | Partially studied with artifact caveat | Boundary, teleport, WMR controller, and chaperone-info references |
| `TXST-CS7389I-Spring-2026-Group-Project/DreamGuard` | MR safety intervention framework | Studied with caveats | Passthrough window/grid/detection/depth study platform |

## Code-Level Findings

### `GiantSox/ChaperoneFail`

- Interesting idea:
  poll OpenVR chaperone play-area state as a tiny console experiment.
- Code donor value:
  mostly negative evidence: initializes OpenVR as `VRApplication_Other` and
  calls `VRChaperone()->GetPlayAreaRect`, but passes a null `HmdQuad_t *`.
- Product reference value:
  useful as a caution that boundary APIs need safe buffers, init errors, and
  null handling before they become a diagnostic helper.
- What to inspect next:
  correct OpenVR chaperone sample usage and whether a fixed branch exists.
- Caveats:
  unsafe pointer usage, no error handling, and no product logic beyond polling.

### `Graicc/Echo-Vr-Playspace-Abuse-Detector`

- Interesting idea:
  model each Echo VR player's allowed physical playspace as a bubble that
  follows reported velocity and slowly moves toward the player's head.
- Code donor value:
  useful detection pattern: Unity `UnityWebRequest` polling of
  `http://127.0.0.1:6721/session`, JSON DTOs for teams/players, settings JSON
  for diameter/speed, player prefab instantiation, team/player index mapping,
  velocity-integrated playspace movement, `MoveTowards` recentering, bounds
  containment test, and good/bad material feedback plus offender list.
- Product reference value:
  strong reference for a gameplay-safety monitor that separates live telemetry,
  allowed region model, visual feedback, and operator list.
- What to inspect next:
  polling cadence, null-data handling, multiplayer identity drift, punishment
  policy, and non-Echo generalization.
- Caveats:
  game-specific local API, rough team-room reset bounds, no robust error/null
  handling, keyboard controls, and fixed display resolution.

### `benpaddlejones/VR-Playspace`

- Interesting idea:
  a Unity/MRTK playspace project that bundles WMR controller assets, chaperone
  info, boundary visualization, teleport system, and custom object interaction.
- Code donor value:
  limited direct donor: most value comes from MRTK boundary and teleport
  references, a checked-in `chaperone_info.vrchap` play-area JSON, WMR
  controller models, and custom interaction snippets like
  `DragAndDropHandler` using MRTK focus/input events plus simple spawner/video
  triggers.
- Product reference value:
  useful as an artifact-heavy baseline for how boundary and teleport systems
  can swamp a small project if vendor/sample payload is not separated.
- What to inspect next:
  isolate original scene intent, remove Library/PackageCache/obj payloads, and
  compare MRTK boundary abstractions with OpenXR/Quest equivalents.
- Caveats:
  no root README, huge checked-in Unity/MRTK/Library/obj payload, unclear
  original contribution, and mostly vendor framework code.

### `TXST-CS7389I-Spring-2026-Group-Project/DreamGuard`

- Interesting idea:
  compare multiple MR safety techniques: guardian grid, passthrough window,
  detection-triggered passthrough, and depth-bubble style interventions.
- Code donor value:
  strong research/framework donor: Unity `RoomExperiment` condition enum and
  event flow, `StudyLogger` CSV session/position/controller/headset/orb/
  performance logs, Godot `DreamGuard` style orchestrator, passthrough window
  and fragment nodes, alpha-blend/XR environment-mode management, menu-based
  style switching, and Quest/Godot comments about Canvas layers not writing
  XR eye swapchain alpha.
- Product reference value:
  excellent reference for safety utilities that should expose intervention
  style, trigger source, logging, and limitations rather than one magic mode.
- What to inspect next:
  object/depth trigger implementation, Meta Depth API path, YOLO pipeline,
  study-analysis scripts, and transferable UX beyond the experiment.
- Caveats:
  study platform rather than product, Meta Quest/Godot/Unity mix, fixed study
  assumptions, large assets, and some APIs are vendor/depth specific.

## Cross-Project Synthesis

The reusable playspace safety boundary is:

1. obtain runtime, game, or sensor space data;
2. define the safe region and coordinate frame;
3. update the region or player model over time;
4. detect leaving, intrusion, or risk;
5. choose an intervention style;
6. log event and pose evidence;
7. surface confidence and caveats to users/operators.

`DreamGuard` is the strongest safety-intervention and study-logging donor.
`Echo-Vr-Playspace-Abuse-Detector` is the strongest compact telemetry-to-bounds
reference. `ChaperoneFail` and `VR-Playspace` are useful mainly as caution and
framework/artifact references.

## Method/Catalog Actions

- Add a method for playspace safety interventions across chaperone APIs,
  follower capsules, passthrough windows, detection/depth triggers, and study
  logging.
- Add a follow-up matrix for chaperone, guardian, player capsule, depth, and
  passthrough safety models.
- Mark null-pointer and artifact-heavy projects as caution/reference entries.

## Follow-Up Backlog

- Build a safety-intervention comparison table: grid, window, vignette,
  fragment, depth bubble, detection reveal, and operator alert.
- Extract a logging schema for safety utilities: event, trigger, pose, room,
  condition, confidence, false positive, and recovery.
- Compare OpenVR chaperone, MRTK boundary, Meta Guardian/Depth, and game-local
  telemetry as different data sources.
