# VR Projects Wave 88: VRChat World-Authoring Toolkits, Optimization Helpers, and Prefab Ecosystems

- Date: `2026-04-21`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `VRChat world-authoring toolkits`, `Udon optimization helpers`, and
  `prefab ecosystem baselines`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of creator-facing VRChat media,
chatbox, and OSC tools, but it still lacked a cleaner answer to:

`what the strongest creator-side donors look like before runtime, when the main value is editor tooling, build protection, compiler intervention, and prefab-package decomposition`.

This wave exists to make that branch clearer.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with VRChat world toolkit, Udon optimization, and prefab
   ecosystem queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `oneVR/VRWorldToolkit` | Strong donor for editor-time build checks, creator automation, and policy enforcement in VRChat world authoring |
| `BlueAmulet/UdonSharpOptimizer` | Strong donor for compiler-pipeline interception and post-emit optimization of generated Udon |
| `Varneon/UdonEssentials` | Important historical prefab-suite donor whose event and prefab patterns still matter even though it is deprecated |
| `Varneon/VUdon` | Strong ecosystem and product-direction reference for package-based creator tooling around VRChat worlds |

## Deep-pass notes by project

## `oneVR/VRWorldToolkit`

- GitHub:
  [oneVR/VRWorldToolkit](https://github.com/oneVR/VRWorldToolkit)
- What it is:
  a Unity editor toolkit for VRChat world creation that combines build checks,
  creator automation, import helpers, and custom editor surfaces.
- Why it matters:
  it is the clearest donor in this wave for
  `world-authoring guardrails implemented as editor-time automation instead of documentation only`.
- Interesting ideas:
  intercept world builds and stop them when scene assumptions are broken; apply
  creator policy automatically when new Udon behaviours are added; keep
  several small quality-of-life tools under one authoring toolkit instead of
  scattering them across unrelated scripts.
- Interesting implementation choices:
  `Editor/BuildChecksManager.cs`
  implements `IVRCSDKBuildRequestedCallback` and checks scene state before a
  build continues; `Editor/DefaultUdonBehaviourSyncModeAssigner.cs`
  hooks `ObjectFactory.componentWasAdded` so new Udon behaviours receive a
  chosen sync default automatically, including delayed handling for
  UdonSharp-added components.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  this is a broad editor toolkit rather than one narrowly isolated method, so
  later passes may still want to peel off specific helper lines.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs
  `editor-time build guardrails and authoring automation`
  donors.

## `BlueAmulet/UdonSharpOptimizer`

- GitHub:
  [BlueAmulet/UdonSharpOptimizer](https://github.com/BlueAmulet/UdonSharpOptimizer)
- What it is:
  an optimization layer that hooks into UdonSharp compilation and rewrites the
  emitted program for smaller or cleaner generated Udon.
- Why it matters:
  it is the clearest donor in this wave for
  `compiler pipeline injection over generated creator scripts`.
- Interesting ideas:
  do not ask creators to hand-optimize generated Udon when the compiler output
  can be improved centrally; patch the pipeline at the compiler boundary so
  optimizations stay reusable across many world scripts.
- Interesting implementation choices:
  `Editor/OptimizerInject.cs`
  uses Harmony to patch `UdonSharpCompilerV1` internals and insert the
  optimizer into the emit flow; `Editor/Optimizer.cs`
  runs optimization passes over value tables and instruction streams rather
  than over source syntax.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  it depends on internal compiler structure and therefore inherits fragility
  whenever upstream compiler versions change.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `post-emit optimization pass over generated scripting VM code`
  donor.

## `Varneon/UdonEssentials`

- GitHub:
  [Varneon/UdonEssentials](https://github.com/Varneon/UdonEssentials)
- What it is:
  a deprecated but still instructive prefab collection for VRChat worlds that
  bundled event dispatching, player tools, world settings, consoles, and other
  creator conveniences.
- Why it matters:
  it is the clearest historical donor in this wave for
  `broad prefab-suite composition before package ecosystems became the preferred shape`.
- Interesting ideas:
  keep reusable creator features as prefab modules instead of one monolithic
  world system; provide a delegated update/event surface so many behaviours can
  subscribe without duplicating their own update loops.
- Interesting implementation choices:
  `Assets/Varneon/Udon Prefabs/Essentials/Event Dispatcher/Udon Programs/EventDispatcher.cs`
  acts as a central event bus for fixed, late, and post-late delegated events,
  with registration and removal APIs for world-side behaviours.
- Code donor value:
  medium.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  the repo is explicitly deprecated in favor of `VUdon`, so its strongest role
  is lineage and migration understanding rather than greenfield adoption.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `legacy prefab-suite baseline`
  before comparing newer package ecosystems.

## `Varneon/VUdon`

- GitHub:
  [Varneon/VUdon](https://github.com/Varneon/VUdon)
- What it is:
  an umbrella repository that maps a broader ecosystem of packageized Udon
  prefabs and creator tools such as quick menus, menu frameworks, player
  trackers, settings, and common shared packages.
- Why it matters:
  it is the clearest donor in this wave for
  `creator-tool ecosystem framing`
  rather than one isolated prefab.
- Interesting ideas:
  break creator tooling into many VCC-friendly packages; keep shared resources
  in a common package; let creators compose only the modules they need instead
  of importing one giant suite.
- Interesting implementation choices:
  the root repo acts more as an ecosystem map than a code-heavy monorepo, with
  package names and status surfaced explicitly so the shared lineage is easier
  to follow than in older prefab bundles.
- Code donor value:
  medium.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the strongest donor logic sits in the linked package repos, not in the
  umbrella repo itself.
- What to inspect next:
  revisit through specific packages when `VR-apps-lab` needs deeper passes on
  `quick menu`, `menu framework`, or `player tracking` creator tools.

## Main takeaways from Wave 88

- `VRChat creator tooling`
  now splits more cleanly into:
  - editor-time guardrails and build protection;
  - compiler-pipeline optimization;
  - legacy prefab-suite bundles;
  - package-ecosystem umbrellas.
- The strongest lesson from this wave is that
  `creator workflow donors`
  are often more reusable when they live before runtime: inside editor hooks,
  build callbacks, or package decomposition.
- Another strong lesson is that
  `ecosystem repos`
  still matter even when the deepest code lives elsewhere, because they reveal
  the right package split and product framing.

## Reusable methods clarified by this wave

- `VRChat world build-request gate with automated fix-or-block editor workflow`
- `Compiler-pipeline injection that optimizes generated Udon after UdonSharp emission`
- `Prefab-suite event-dispatch backbone for delegated update-style world logic`
- `Creator-tool package constellation with a shared common package and composable modules`

## Recommended next moves after this wave

1. Keep `VRWorldToolkit` visible as one of the strongest
   `editor guardrail and build-check`
   donors in the VRChat branch.
2. Treat `UdonSharpOptimizer` as a strong
   `compiler-pipeline intervention`
   reference whenever future research touches generated creator code.
3. Use `UdonEssentials` as a historical anchor when comparing older prefab
   suites with newer package ecosystems.
4. Revisit `VUdon` through individual package repos when a future pass needs
   sharper study of `QuickMenu`, `Menus`, `PlayerTracker`, or `Common`.
