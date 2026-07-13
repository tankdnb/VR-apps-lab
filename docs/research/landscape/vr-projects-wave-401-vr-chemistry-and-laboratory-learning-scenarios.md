# Wave 401: VR Chemistry and Laboratory Learning Scenarios

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device tests.

## Theme

This wave studies chemistry and laboratory VR projects where reusable value is
less about the subject matter itself and more about scenario goals, object
affordances, reaction feedback, and guided scientific exploration.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `chemistry-lab/chemistry-lab-vr` | Studied | Chemistry lab scenario and molecule interaction toolkit |
| `alinaduca/BachelorsThesis-UnityLab` | Studied with caveats | Chemistry education app with tutor/chatbot framing |

## Findings

### `chemistry-lab/chemistry-lab-vr`

- Interesting idea: chemistry learning is represented through tangible
  molecule/atom objects, scenario goals, environment changes, and lab
  interactions rather than flat quizzes.
- Code donor value: `LakeGoal`, `PyrolysisGoal`, `AtomGun`, `AtomTarget`,
  `AtomHologram`, `AtomPack`, `MoleculePack`, `Grabbable`, `Sampleable`,
  `ParticleManager`, and `SceneLoader`.
- Product reference value: useful for VR utility demos that need object-level
  validation and visible consequences when the correct object is used.
- What to inspect next: scenario authoring model, molecule pack data shape,
  sample collection, particle cleanup, and scene transition timing.
- Caveat: large MRTK/Unity extension surface; reuse should extract the lab
  scenario pattern instead of copying the whole project.

### `alinaduca/BachelorsThesis-UnityLab`

- Interesting idea: chemistry education app combines VR reactions, documentation,
  demo material, and AI tutor/chatbot framing.
- Code donor value: custom project scripts are mixed with large Inworld,
  TextMeshPro, and Unity samples; reusable inspection points include
  `BookCanvasManager`, 3D chat panels, interaction feedback buttons, and
  character/tutor UI surfaces.
- Product reference value: strong reminder that educational VR benefits from a
  learning companion, documentation route, and replayable demonstration media.
- What to inspect next: custom reaction scripts, whether tutor content is
  data-driven, and how the thesis maps learning goals to scene tasks.
- Caveat: a lot of inspected code is vendor/sample scaffolding; cite only custom
  learning-flow and tutor-surface decisions as donor value.

## Reusable Pattern Extraction

- Pattern candidate: `Lab scenario goal with visible consequence feedback`.
- Problem solved: educational VR labs need objective validation, but the user
  should understand success through the environment, not only a score panel.
- Reusable core: domain object metadata, trigger/goal validator, correct-object
  predicate, environment response list, particle/material state changes, delayed
  scene transition, and optional tutor/explanation surface.
- Source evidence: `LakeGoal` checks a `MoleculePack` abbreviation against the
  correct solution, fades dirty objects, stops dirty particles, changes water
  material, and calls `SceneLoader`; `Grabbable` separates pickup/drop/throw
  affordances from the scenario goal.
- Abstraction boundary: keep chemistry facts in data objects and keep feedback
  effects in scenario configuration; the generic method is valid for safety,
  repair, museum, and training scenarios too.
- What not to copy: full MRTK bundle, hard-coded one-off scene names, or AI tutor
  dependencies without a privacy and offline fallback story.
- Method catalog action: add Method 846.

