# Wave 400: VR Welding and Industrial Procedure Training

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device tests.

## Theme

This wave studies VR welding and industrial procedure trainers that turn a
physical skill into guided steps, part discovery, ghost-path practice, scoring,
and post-attempt feedback.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `Marcel-Castro/VR-Welding` | Studied with caveats | MRTK welding lab and gauge/lesson prototype |
| `stjakubi/VR-SLM-printer` | Studied | Metal 3D-printer procedure trainer |
| `NandiniDevraj/WeldingSimulationSpline` | Studied | Spline-guided welding accuracy trainer |

## Findings

### `Marcel-Castro/VR-Welding`

- Interesting idea: VR welding training framed around a lab environment,
  equipment attachment, gauges, lesson objects, and MRTK-style hand/controller
  affordances.
- Code donor value: custom scripts such as `Lesson`, `ValveGauge`,
  `RegulatorGauge`, `AttachToTarget`, `SetConnectedAnchor`, and
  `PositionFreezer`; the bundled MRTK dependency is support context, not the
  reusable core.
- Product reference value: useful as a safety-equipment and workstation
  composition reference for industrial micro-training.
- What to inspect next: lesson sequencing, gauge threshold semantics, torch and
  part state transitions, and whether scoring is scene-authored rather than
  centralized.
- Caveat: much of the repo is MRTK/vendor package surface; donor extraction
  should stay focused on the domain scripts.

### `stjakubi/VR-SLM-printer`

- Interesting idea: teach metal 3D-printer operation through discoverable parts,
  workflow gates, contextual errors, labels, and a quiz-ready learning flow.
- Code donor value: `LearningManager` auto-counts labelable `PrinterPartInfo`
  objects and tracks first-discovery progress; `BuildPlatform` notifies workflow
  state and triggers contextual `PrinterErrorSimulator` messages.
- Product reference value: strong reference for industrial procedure tools that
  need both guided exploration and workflow-error feedback.
- What to inspect next: `PrinterPartInfo`, `ControllerLabelDisplay`,
  `PrinterErrorSimulator`, quiz flow, and how workflow steps unlock one another.
- Caveat: compact source drop rather than a full public Unity project tree; good
  for method extraction, less useful as a turnkey donor.

### `NandiniDevraj/WeldingSimulationSpline`

- Interesting idea: compare the user's welding torch against an ideal ghost path
  and convert distance, orientation, and speed errors into live and summary
  scores.
- Code donor value: `UserAccuracyTracer`, `LessonManagerSimple`, `AccuracyHUD`,
  `WeldingAgent`, `IdealRecorder`, `IdealFollower`, `SplinePath`, and
  `welding_config.yml`.
- Product reference value: excellent pattern for skill trainers where correct
  performance is a continuous path rather than a discrete action.
- What to inspect next: ideal path recording, ML-Agents reward shaping,
  SenseGlove integration boundary, and how the ghost path is authored.
- Caveat: tolerance logic currently uses permissive `||` checks; reuse should
  decide whether all metrics must pass together.

## Reusable Pattern Extraction

- Pattern candidate: `Ghost-path skill trainer with attempt summary`.
- Problem solved: VR training tools need to teach motor skills by showing an
  ideal movement, hiding hints during exam mode, and summarizing accuracy after
  the attempt.
- Reusable core: ideal pose stream, user pose sampler, tangent frame, lateral
  error, orientation error, speed error, tolerance policy, weighted score, live
  HUD, guided/exam modes, and summary panel.
- Source evidence: `UserAccuracyTracer` calculates distance/angle/speed errors;
  `LessonManagerSimple` separates guided and exam modes and accumulates summary
  metrics; `LearningManager` shows how industrial parts can become discovery
  progress.
- Abstraction boundary: keep domain-specific assets and vendor packages outside
  the trainer core; expose only pose samples, tolerance config, scoring, and
  feedback surfaces.
- What not to copy: bundled SDK packages, scene-specific object names, unclear
  pass/fail semantics, or safety claims without a validated training protocol.
- Method catalog action: add Method 845.

