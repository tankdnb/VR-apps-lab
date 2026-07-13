# Wave 359: VR Sports Fitness Movement Training Badminton and Reaction Games

## Scope

This wave studies VR sports and fitness projects where hand/body movement,
targets, equipment proxies, hit validation, scoring, tutorials, and multiplayer
or drill flow matter. The reusable lesson is a sport skill loop that can be
reused outside one game.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `oculus-samples/Unity-MoveFast` | Studied | Meta fitness sample with hand-hit detectors, pose gating, target zones, score incrementers, velocity scoring, combo breakers, tutorial, results UI, and 90 FPS setting |
| `partharora1105/Badminton_VR` | Partially studied | Badminton direction marker for racket/shuttle interaction, scoring, and sport-specific movement comparison |
| `rishidevde/Badminton_Computer_Graphics` | Partially studied | Quest 3 badminton direction marker with XR Interaction Toolkit, realistic racket interaction, XR movement, and gameplay mechanics framing |
| `LittleQBerry/REVERIE-Sports` | Partially studied | Sports-learning/training direction marker for future drill and coaching comparison |
| `ticahere/VIRD-demo` | Partially studied | Movement/training demo marker for future sensor, rehab, or drill-loop inspection |
| `oculus-samples/Unity-UltimateGloveBall` | Studied | Meta multiplayer sports sample with local/remote player entities, gloves, UI hover ownership, arena services, Photon/Netcode-style package boundaries, and voice/network caveats |

## Reusable Pattern Extraction

- Pattern candidate: `VR sports skill loop and movement-feedback shell`.
- Problem solved: sport/fitness VR needs reliable hit validation, movement
  metrics, scoring, tutorials, comfort, and reset rather than only physics
  collisions.
- Reusable core: equipment proxy, target/ball object, valid-hit detector,
  pose/velocity gate, target zone, drill timeline, score/combo/result service,
  tutorial state, feedback spawner, session metrics, reset, safety/space labels,
  and optional multiplayer authority.
- Source evidence: Unity-MoveFast includes `HandHitDetector`, `TriggerZone`,
  `ScoreIncrementer`, `ScoreKeeper`, `ComboBreaker`, `Tutorial`,
  `ExerciseResults`, and results UI; Unity-UltimateGloveBall exposes local
  player/glove service structure and network/voice package boundaries.
- Abstraction boundary: input/hand tracking should produce movement and hit
  events; drill state, scoring, results, and multiplayer authority should be
  separate services.
- What not to copy: sample-store art/content, network package assumptions,
  unbounded physical motions without playspace safety, or score systems without
  miss/failure semantics.
- Method catalog action: create a new sports skill-loop method.

## Project Notes

### `oculus-samples/Unity-MoveFast`

- Interesting idea: fast-action fitness is structured around validated hand
  poses, target zones, velocity-aware scoring, combos, tutorial state, and
  results.
- Code donor value: very high for hit detector, trigger zone, score services,
  combo breaker, tutorial, feedback spawners, and results UI.
- Product reference value: very strong for small training/fitness utilities.
- What to inspect next: drill timeline data, comfort/safety copy, and hand
  tracking confidence feedback.
- Caveats: official sample with SDK/vendor content; reuse architecture, not
  bundled assets.

### `oculus-samples/Unity-UltimateGloveBall`

- Interesting idea: a glove-ball arena separates local/remote player entities,
  glove interaction ownership, arena services, networking, and voice packages.
- Code donor value: high for multiplayer sport service boundaries and local
  player entity references.
- Product reference value: strong for networked VR sports surfaces.
- What to inspect next: authority, ball state replication, lobby/session reset,
  and UI ownership.
- Caveats: heavier network/sample stack than needed for small utilities.

### `rishidevde/Badminton_Computer_Graphics`

- Interesting idea: badminton provides a concrete racket/shuttle equipment proxy
  for testing sports interaction beyond boxing-style hand hits.
- Code donor value: moderate pending deeper custom script pass.
- Product reference value: useful for racket-sport controls and scoring.
- What to inspect next: shuttle physics, hit validity, serving flow, and score
  reset.
- Caveats: source was treated as a direction marker in this wave.

### `partharora1105/Badminton_VR`

- Interesting idea: a narrow badminton project can act as a micro-reference for
  single-sport mechanics.
- Code donor value: moderate pending deeper script isolation.
- Product reference value: useful as comparison against the newer Quest/XRI
  badminton direction.
- What to inspect next: racket tracking, shuttle collision, AI/opponent flow,
  and score UI.
- Caveats: not promoted as a full donor until deeper pass.

## Product Direction

This wave supports a `VR drill and sports loop` branch: target spawning,
valid-hit detection, scoring, tutorials, results, and safety/comfort labels can
be reused for fitness, training, rehab-adjacent practice, and sports utilities.

