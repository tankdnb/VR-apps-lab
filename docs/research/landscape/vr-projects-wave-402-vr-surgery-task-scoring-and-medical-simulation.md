# Wave 402: VR Surgery Task Scoring and Medical Simulation

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device tests.

## Theme

This wave studies VR surgery simulators as task-scoring references. The useful
patterns are surgical-tool input envelopes, carefulness scoring, step completion,
and hand/controller fallback rather than clinical claims.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `UoA-eResearch/SurgeryQuest` | Studied with caveats | Quest surgery simulator and hand/controller fallback |
| `IsaacYu15/VR-Surgery` | Studied | Surgery robot task simulator with cutting, grabbing, and suturing scores |

## Findings

### `UoA-eResearch/SurgeryQuest`

- Interesting idea: Oculus Quest surgery simulator with explicit hand tracking
  versus controller fallback switching.
- Code donor value: `HandManager` toggles hand visuals and controller objects
  depending on `OVRHand.IsTracked` and Touch-controller availability; `Slice`
  shows a simple cutting interaction stub.
- Product reference value: useful for medical or precision-task VR tools that
  need transparent input-mode fallback.
- What to inspect next: scene-level surgical steps, how tools are represented,
  and whether hand-tracking loss is surfaced to the user.
- Caveat: code-level donor value is thinner than the product framing; avoid
  treating it as a validated medical simulator.

### `IsaacYu15/VR-Surgery`

- Interesting idea: simulate surgery-robot skills as separate lessons for
  grabbing, cutting, and suturing with score counters and task completion gates.
- Code donor value: `lessonCuttingGameManager`, `generateRandomCutPattern`,
  `sutureLessonGameManager`, `sutureInBounds`, `Rope`, `lessonGrabbingManager`,
  `objectsContained`, and the custom `OVRSnip` grab handler.
- Product reference value: strong reference for precision-task UX: users are
  penalized for inaccurate cuts, touching sensitive surfaces, excessive needle
  velocity, or incomplete task state.
- What to inspect next: cut inaccuracy calculation in `Slicer`, rope/collider
  ring detection, tray containment logic, and how lessons are selected.
- Caveat: uses older Oculus/OVR and bundled vendor assets; reuse the scoring
  primitives, not the whole runtime shell.

## Reusable Pattern Extraction

- Pattern candidate: `Precision-task scoring with carefulness penalties`.
- Problem solved: VR tools that teach careful manipulation need scoring based on
  accuracy, collision discipline, speed limits, and completion state rather than
  only binary success.
- Reusable core: task lesson manager, target/containment state, random or
  authored path, touch counters, velocity threshold, inaccuracy metric, object
  completion gate, score floor, and result display.
- Source evidence: `lessonCuttingGameManager` scores cuts by `Slicer.inaccuracy`
  after both pieces reach a tray; `sutureLessonGameManager` deducts for mesh
  touches and needle velocity while checking ring pass-through; `HandManager`
  demonstrates input fallback between hands and controllers.
- Abstraction boundary: separate clinical content, instrument models, and task
  scoring rules from the generic lesson engine.
- What not to copy: clinical training claims, old Oculus packages, or ADB/build
  deployment helpers embedded in vendor packages.
- Method catalog action: add Method 847.

