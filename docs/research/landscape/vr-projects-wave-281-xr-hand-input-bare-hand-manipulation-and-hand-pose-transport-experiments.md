# Wave 281 - XR Hand Input, Bare-Hand Manipulation, and Hand-Pose Transport Experiments

This wave studies hand-input projects as references for XR Hands processing,
OpenXR hand skeleton delivery, bare-hand object manipulation, pose smoothing,
gesture detection, passthrough interaction, and packetized hand-pose transport.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- OpenXR/XR Hands and Unreal hand-tracking integration;
- pinch, poke, and bare-hand object manipulation;
- filtering, hand visualization, floor-origin, and passthrough-gallery helpers;
- hand-pose transport, packetization, replay, and codec boundaries.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Mystfit/NectoXRTemplate` | Unreal OpenXR hand template | Studied with dependency caveats | Hand tracking to LiveLink skeleton and replicated VR character setup |
| `Clyfr/BURG-v2` | Unity XR Hands sample aggregation | Studied with sample caveats | One Euro filtering, pinch midpoint proxy, and poke gesture detector |
| `reubenlavin08/spindle-whorl-ar` | Quest passthrough bare-hand gallery | Studied | XR Hands pinch-grab, hand visualization, floor origin, and procedural artifact mesh |
| `Zer0pa/ZPE-XR` | Hand-pose codec and replay model | Studied with runtime caveats | Packetized two-hand pose transport, recovery, evidence/caveat discipline |

## Code-Level Findings

### `Mystfit/NectoXRTemplate`

- Interesting idea:
  an Unreal template wraps OpenXR hand tracking into a LiveLink skeleton and
  replicated VR character architecture.
- Code donor value:
  useful Unreal boundary donor: `HandtrackedVRCharacter.cpp` replaces controller
  components, sets motion sources, attaches to a network smoother, and the
  cross-platform LiveLink source builds hand subjects and parent-relative bone
  transforms from OpenXR hand keypoints.
- Product reference value:
  good reference for packaging avatar presence, OpenXR hands, and replication
  as a reusable UE template rather than one-off scene code.
- What to inspect next:
  plugin ownership, runtime feature gating, network smoothing behavior, and
  whether hand confidence is exposed to UX.
- Reusable pattern:
  OpenXR hand skeleton to LiveLink/avatar boundary.
- Caveats:
  broad template with heavy plugins, mixed custom/vendor code, and some sparse
  or commented helper logic.

### `Clyfr/BURG-v2`

- Interesting idea:
  collect practical XR Hands manipulation helpers around smoothing, pinch
  points, and poke gesture events.
- Code donor value:
  `HandsOneEuroFilterPostProcessor.cs`, `PinchPointFollow.cs`, and
  `PokeGestureDetector.cs` are useful static references for subsystem
  registration, tracking-loss reset, midpoint filtering, and distance-based
  finger-state checks.
- Product reference value:
  good Unity sample reference for hand interaction feel and gesture primitives.
- What to inspect next:
  which files are original versus imported Unity samples, gesture thresholds,
  and interactor integration.
- Reusable pattern:
  XR hand smoothing and derived interaction proxies.
- Caveats:
  sample aggregation, not a clean standalone product donor.

### `reubenlavin08/spindle-whorl-ar`

- Interesting idea:
  Quest passthrough AR presents cultural artifacts as grabbable discs with
  bare-hand pinch interaction and explicit provenance/cultural constraints.
- Code donor value:
  strongest donor in the wave: `XrHandsPinchGrab.cs` handles subsystem lookup,
  pinch hysteresis, nearest-grabbable selection, pose offsets, tracking-loss
  release, smoothing, and disc-spin suppression; `SimpleHandViz.cs` visualizes
  joints; `ForceFloorOrigin.cs` retries floor origin; `MakeWhorlDisc.cs`
  generates a biconvex annulus mesh.
- Product reference value:
  excellent reference for passthrough object inspection, bare-hand
  manipulation, and culturally careful dataset framing.
- What to inspect next:
  asset provenance workflow, Quest version pins, editor scripts, and how object
  metadata can be generalized into a gallery schema.
- Reusable pattern:
  XR Hands bare-hand passthrough object manipulation.
- Caveats:
  Quest/Meta version assumptions, editor scripts with build side effects if run,
  and cultural-data sensitivity.

### `Zer0pa/ZPE-XR`

- Interesting idea:
  hand poses are treated as compact transport/replay frames with explicit codec
  evidence and known benchmark caveats.
- Code donor value:
  strong data-boundary donor: `api.py` normalizes frame arrays and exposes
  encode/decode/classify APIs; `codec.py` defines header/checksum,
  keyframe/delta, CRC32, quantization, and validation; `network.py` models
  packet loss, recovery, and concealment.
- Product reference value:
  useful for future hand-pose replay, network sync, and diagnostic transport
  experiments.
- What to inspect next:
  runtime integration, schema versioning, timestamp model, and comparison to
  OpenXR/Leap packet formats.
- Reusable pattern:
  packetized hand-pose transport and replay boundary.
- Caveats:
  not a complete XR runtime, benchmark claims are explicitly partial, and
  codec choices need independent validation.

## Reusable Pattern Extraction

- Pattern candidate:
  hand input and pose transport boundary.
- Problem solved:
  bridge raw hand tracking into stable manipulation, avatar skeletons, network
  packets, and replay surfaces without mixing tracking confidence, gesture UX,
  and transport in one layer.
- Reusable core:
  subsystem acquisition, joint confidence, tracking-loss reset, pinch/poke
  gesture detector, hysteresis, smoothing/filtering, hand visualization,
  coordinate origin control, avatar/LiveLink adapter, packet codec, replay
  recovery, and evidence/caveat metadata.
- Source evidence:
  `NectoXRTemplate`, `BURG-v2`, `spindle-whorl-ar`, and `ZPE-XR`.
- Abstraction boundary:
  keep raw runtime hand data, derived gestures, object manipulation, avatar
  output, and transport/replay formats independent.
- What not to copy:
  hardcoded gesture thresholds as universal defaults, vendor plugin payloads as
  original donor code, build side effects, and compression claims without
  runtime evidence.
- Method catalog action:
  add a hand-input and pose-transport method.

## Follow-Up Gaps

- Build an XR hand matrix across XRHandSubsystem, OpenXR LiveLink, pinch/poke
  detectors, One Euro filters, passthrough manipulation, and packet replay.
- Deepen `spindle-whorl-ar` as a passthrough/bare-hand manipulation donor.
- Deepen `ZPE-XR` for hand-pose transport and replay schema ideas.
- Compare XR Hands, Leap, OpenXR keypoints, LiveLink, and VMC-style hand
  transport formats in a future synthesis.
