# VR Projects Wave 45: Redirected-Walking Toolkits, Locomotion Sidecars, and Space-Redirection Research

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `redirected walking`, `locomotion adaptation`, and
  `space-redirection research toolkits`.

## Why this wave exists

`VR-apps-lab` already had motion compensation and several room-space helpers,
but one broader locomotion branch was still weakly modeled:

- redirected-walking frameworks with pluggable redirectors and resetters;
- experiment harnesses for path generation, tracking-space variation, and batch
  runs;
- multi-user redirected-walking platforms with networking and fairness logic;
- comfort-heavy locomotion modules that solve `small room` constraints through
  rewind and prevention logic instead of redirection research.

This wave exists to make
`redirected walking, locomotion adaptation, and space-redirection research`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with redirected-walking and locomotion-toolkit queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `USC-ICT-MxR/RDWT` | Foundational donor for a redirected-walking manager with pluggable redirectors, resetters, and simulation tools |
| `yaoling1997/OpenRDW` | Strong donor for an expanded redirected-walking research platform with richer algorithms, configuration, and experiment control |
| `omegafantasy/OpenRDW2` | Strong donor for multi-user online redirected walking with networking and batch experiment generation |
| `ElectricNightOwl/ArmSwinger` | Strong donor for a comfort-heavy locomotion module with safety, rewind, smoothing, and prevention systems |
| `Knerten0815/VR_Dodge_Study` | Useful comparison node for thesis-driven changes on top of the OpenRDW lineage |

## Secondary candidates surfaced in the same wave

No secondary candidate in this wave was stronger than the frozen shortlist.

## Deep-pass notes by project

## `USC-ICT-MxR/RDWT`

- GitHub:
  [USC-ICT-MxR/RDWT](https://github.com/USC-ICT-MxR/RDWT)
- What it is:
  the original Redirected Walking Toolkit for Unity, with simulation support and
  a central redirection manager.
- Why it matters:
  it is the clearest foundational donor in the repo for
  `redirected-walking manager plus pluggable redirector and resetter stack`.
- Interesting ideas:
  centralize user-state updates in one manager; treat redirectors, resetters,
  triggers, walkers, and statistics logging as swappable components; keep
  simulation tooling close to the runtime toolkit.
- Interesting implementation choices:
  `RedirectionManager.cs` and
  `SimulationManager.cs`
  make the `user state -> redirect or reset -> experiment setup and path seed`
  flow explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  research-toolkit framing is stronger than end-user product framing.
- What to inspect next:
  keep it visible whenever a future branch needs a baseline
  `redirector plus resetter` architecture reference.

## `yaoling1997/OpenRDW`

- GitHub:
  [yaoling1997/OpenRDW](https://github.com/yaoling1997/OpenRDW)
- What it is:
  an expanded redirected-walking platform that grows beyond RDWT into richer
  configuration, visualization, algorithms, and experiment control.
- Why it matters:
  it is the clearest donor in the repo for
  `redirected-walking research platform with broader experiment ownership`.
- Interesting ideas:
  move from a small toolkit to a configurable experiment platform; expose
  redirector and resetter choice explicitly; integrate more advanced algorithms,
  visualization, and multi-avatar setup into one stack.
- Interesting implementation choices:
  `GlobalConfiguration.cs` and
  `RedirectionManager.cs`
  make the `global experiment config -> per-avatar manager -> redirector or
  resetter choice` flow explicit.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  research breadth is the main value, not product polish.
- What to inspect next:
  keep it visible whenever a future branch needs
  `config-heavy redirected-walking research ownership` rather than only one
  locomotion algorithm.

## `omegafantasy/OpenRDW2`

- GitHub:
  [omegafantasy/OpenRDW2](https://github.com/omegafantasy/OpenRDW2)
- What it is:
  a multi-user online redirected-walking platform that extends the OpenRDW line
  with networking, separate-space logic, and batch experiment generation.
- Why it matters:
  it is the clearest donor in the repo for
  `multi-user space-redirection experiment stack`.
- Interesting ideas:
  model multiple physical spaces and one virtual space; synchronize reset flows;
  push networking into the core experiment story; generate large command-file
  batches for repeatable research.
- Interesting implementation choices:
  `GlobalConfiguration.cs`,
  `RedirectionManager.cs`,
  `NetworkManager.cs`, and
  `BatchExperimentGenerator.cs`
  make the `experiment config -> multi-avatar runtime -> network sync ->
  generated batch files` path explicit.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  still strongly research-shaped, but a very valuable architecture donor.
- What to inspect next:
  keep it visible whenever a future branch needs
  `online or multi-user room-space experimentation`.

## `ElectricNightOwl/ArmSwinger`

- GitHub:
  [ElectricNightOwl/ArmSwinger](https://github.com/ElectricNightOwl/ArmSwinger)
- What it is:
  a Unity arm-swing locomotion library with a large comfort and safety stack.
- Why it matters:
  it is the clearest donor in the repo for
  `comfort-heavy locomotion module with rewind and prevention layers`.
- Interesting ideas:
  treat locomotion as a configurable safety system as much as a movement system;
  layer smoothing, inertia, wall-clip prevention, climb and fall prevention,
  pushback override, and rewind history into one reusable component.
- Interesting implementation choices:
  `scripts/ArmSwinger.cs`
  exposes a broad yet explicit `movement -> smoothing -> inertia -> raycast and
  collision prevention -> rewind or pushback` model.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  locomotion-specific rather than a general room-redirection toolkit.
- What to inspect next:
  keep it visible whenever a future branch needs
  `small-room locomotion hygiene` rather than research-grade redirected walking.

## `Knerten0815/VR_Dodge_Study`

- GitHub:
  [Knerten0815/VR_Dodge_Study](https://github.com/Knerten0815/VR_Dodge_Study)
- What it is:
  a bachelor-thesis-driven fork of OpenRDW focused on dodging behavior and reset
  research.
- Why it matters:
  it is a useful comparison node for
  `thesis-specific variation on a broader redirected-walking platform`.
- Interesting ideas:
  adapt an existing redirected-walking platform to a narrower behavioral study;
  add trial-data and sampling-interval concerns that are more study-specific
  than platform-wide.
- Interesting implementation choices:
  `README.md` and
  `ExperimentSetup.cs`
  make the `OpenRDW fork -> thesis data additions` boundary explicit.
- Code donor value:
  low-medium.
- Product reference value:
  medium.
- Architecture reference value:
  medium.
- Caveats:
  weaker as a standalone donor than the main OpenRDW line.
- What to inspect next:
  treat it as a `fork or variant only` node unless a future pass specifically
  needs the study-specific deltas.

## Main takeaways from Wave 45

- `Redirected walking` is now a distinct family, not just a side note near
  motion compensation and room alignment.
- The strongest split in this family is:
  - `baseline redirected-walking toolkit`
  - `expanded experiment platform`
  - `multi-user online redirected-walking stack`
  - `comfort-heavy locomotion sidecar with rewind and prevention`
  - `thesis-specific fork or variant`
- The most reusable lesson is that room-limited locomotion work often separates
  into `research algorithm platforms` and `user-facing comfort locomotion
  modules`, and those should not be flattened into one bucket.
