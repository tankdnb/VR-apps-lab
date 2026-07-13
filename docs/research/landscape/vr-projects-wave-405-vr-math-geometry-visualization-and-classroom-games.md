# Wave 405: VR Math, Geometry Visualization, and Classroom Games

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device tests.

## Theme

This wave studies VR math and visual-reasoning projects. The reusable value is
the conversion of abstract material into embodied tasks: equations as targets,
matrices as spatial bars, hyperbolic geometry as controller-driven rendering,
and classroom/world shells as learning surfaces.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `Rud156/MathSaber` | Studied | VR math game and teacher analytics |
| `PNCaruana/VR-Classroom` | Studied | Spatial matrix/FFT visualization classroom |
| `mtwoodard/hypVR-Ray` | Studied | WebVR hyperbolic raymarching/controller adapter |
| `jmacd/grraph` | Lightly studied | Unity math/graph playground reference |

## Findings

### `Rud156/MathSaber`

- Interesting idea: Beat-Saber-like equation practice where math questions
  become timed embodied actions and results can be collected for a teacher.
- Code donor value: `EquationAndBlockGenerator`, equation spawners,
  `EquationsAnalyticsManager`, `CustomEquationData`, block controllers, sword
  controllers, and text-file logging.
- Product reference value: strong model for turning dry educational content
  into a rhythmic, repeatable, analytics-friendly VR loop.
- What to inspect next: custom question file schema, teacher/stat export,
  grade/operator progression, and error feedback.
- Caveat: game-specific slicing/assets are less reusable than the
  question-to-action-to-analytics loop.

### `PNCaruana/VR-Classroom`

- Interesting idea: a classroom scene uses generated spatial bars to visualize
  matrix/FFT data inside VR.
- Code donor value: `BoardGraph` instantiates matrix cells as scaled/colorized
  bars; `Tools` contains complex-number helpers and 2D FFT logic.
- Product reference value: useful reference for turning tabular/scientific data
  into a 3D board that can be walked around and compared visually.
- What to inspect next: input data loading, graph refresh model, performance
  for larger matrices, and classroom interaction state.
- Caveat: code is prototype-grade and includes rough data-loading assumptions.

### `mtwoodard/hypVR-Ray`

- Interesting idea: WebVR hyperbolic raymarching experiment with browser VR
  display discovery and a controller adapter layer.
- Code donor value: `VRController.js`, `VREffect.js`, `Controls.js`, shaders,
  and fallback display handling.
- Product reference value: good proof that advanced math environments can use
  thin browser-side input abstractions rather than full engine stacks.
- What to inspect next: shader parameter controls, controller pose transforms,
  and how hyperbolic coordinates are exposed to the user.
- Caveat: old WebVR APIs require modernization to WebXR before reuse.

### `jmacd/grraph`

- Interesting idea: a small VR graph/math playground node.
- Code donor value: limited; useful mainly as a search marker for graph and
  geometry learning projects.
- Product reference value: reminds us to separate mathematical object models
  from rendering shells.
- What to inspect next: scene assets, graph data representation, and whether
  useful interaction scripts exist outside the visible code surface.
- Caveat: thin source surface in this pass; keep as light reference.

## Reusable Pattern Extraction

- Pattern candidate: `VR learning loop from abstract problem to embodied action and evidence`.
- Problem solved: math/science VR tools need to make invisible abstractions
  actionable, inspectable, and measurable without becoming only a flat quiz.
- Reusable core: content schema, problem generator, spatial object mapper,
  timed interaction, correctness validator, feedback object, score/analytics
  record, teacher/operator export, optional 3D data board, and advanced
  visualization adapter.
- Source evidence: `MathSaber` separates equations, spawners, block
  controllers, analytics, and custom equation data; `VR-Classroom` maps matrix
  values to bar scale/color; `hypVR-Ray` separates WebVR controller polling
  from geometry rendering.
- Abstraction boundary: keep domain content, spatial representation,
  interaction action, and analytics export independent.
- What not to copy: game-specific rhythm assets, obsolete WebVR APIs,
  hard-coded matrix dimensions, or educational claims without learning
  validation.
- Method catalog action: add Method 850.

