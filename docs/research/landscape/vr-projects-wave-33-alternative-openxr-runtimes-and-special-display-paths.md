# VR Projects Wave 33: Alternative OpenXR Runtimes and Special-Display Paths

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `alternative OpenXR runtimes`, `special-display paths`, and
  `platform experiments outside the ordinary headset runtime model`.

## Why this wave exists

Many repositories in `VR-apps-lab` already cover runtime switchers, API layers,
and utilities, but they do not yet map another valuable branch clearly enough:

- OpenXR runtimes that target `3D displays`, `spatial laptops`, or other
  non-headset hardware;
- embedded runtime frameworks that live inside a platform app;
- experimental runtimes whose main value is architectural, not product-ready
  completeness.

This wave exists to make `alternative OpenXR runtime architecture` a clearer
family inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with special-display runtime, embedded OpenXR, Apple OpenXR,
   and nonstandard runtime queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `DisplayXR/displayxr-runtime` | Strongest architecture donor for a cleanly layered OpenXR runtime aimed at special displays rather than ordinary HMDs |
| `JoeyAnthony/XRGameBridge` | Useful donor for a narrow special-display runtime wrapper around existing game-mod workflows |
| `warrenm/OpenXRKit` | Best embedded-runtime donor for Apple-platform OpenXR bring-up outside the normal desktop-loader model |
| `rinsuki/FruitXR` | Valuable proof-of-concept donor for a runtime/server split with local IPC and a WebXR-facing control boundary |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `maximum-game-22/openxr-3d-display` | Relevant Monado-derived comparison node, but the mainline architecture lesson was already better expressed by `displayxr-runtime` |
| `Kartaverse/OpenDisplayXR` | Useful project cluster for later follow-up, but weaker as a primary donor than the more explicit runtime implementations in this wave |

## Deep-pass notes by project

## `DisplayXR/displayxr-runtime`

- GitHub:
  [DisplayXR/displayxr-runtime](https://github.com/DisplayXR/displayxr-runtime)
- What it is:
  an OpenXR runtime for spatial displays and 3D monitors built around a clear
  Monado-derived but strongly simplified runtime decomposition.
- Why it matters:
  it is the strongest donor in the repo for
  `cleanly layered alternative runtime architecture`.
- Interesting ideas:
  articulate explicit separation-of-concerns rules; isolate device drivers,
  state tracking, compositors, and display processors; treat special-display
  support as first-class runtime work instead of as a compatibility afterthought.
- Interesting implementation choices:
  `docs/architecture/separation-of-concerns.md` and the corresponding
  `src/xrt/` layout make the runtime layering and vendor-isolation rules
  unusually explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  very high.
- Caveats:
  still a specialized runtime branch, not a general utility tool.
- What to inspect next:
  keep it as the main architecture donor whenever a future `VR-apps-lab`
  branch needs a `special-display runtime` or a clearer `runtime layering`
  reference.

## `JoeyAnthony/XRGameBridge`

- GitHub:
  [JoeyAnthony/XRGameBridge](https://github.com/JoeyAnthony/XRGameBridge)
- What it is:
  a focused OpenXR runtime path for running specific modded games on spatial
  displays like the Leia SR and Samsung Odyssey 3D lines.
- Why it matters:
  it is the strongest donor in the repo for
  `narrow special-display runtime wrapper around a known consumer workflow`.
- Interesting ideas:
  keep the runtime narrowly aimed at a concrete workload; expose supported
  graphics backends explicitly; separate settings, hooks, and window handling
  from core runtime bring-up.
- Interesting implementation choices:
  `runtime_openxr/src/main.cpp` and
  `runtime_openxr/src/system.cpp` make the bootstrap, system reporting, and
  graphics-backend split very easy to inspect.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  purposefully narrow and heavily shaped by the target display workflow.
- What to inspect next:
  compare it with `displayxr-runtime` whenever a future path needs to choose
  between `clean generalized architecture` and `focused applied runtime`.

## `warrenm/OpenXRKit`

- GitHub:
  [warrenm/OpenXRKit](https://github.com/warrenm/OpenXRKit)
- What it is:
  an experimental OpenXR runtime framework for iOS and visionOS built as an
  embedded Apple-platform library.
- Why it matters:
  it is the strongest donor in the repo for
  `embedded or platform-native OpenXR runtime framework`.
- Interesting ideas:
  sidestep ordinary desktop assumptions; package the runtime as a framework;
  split platform-specific system implementations for `iOS` and `visionOS`; use
  platform-native graphics and interaction managers instead of retrofitting a
  desktop runtime shell.
- Interesting implementation choices:
  `OpenXRKit/OpenXRKit/OpenXRKit/Source/instance_apple.cpp` and the broader
  `Source/` tree make the internal `instance -> system -> session` layering and
  platform branching visible.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  explicitly experimental and not a drop-in runtime for normal desktop usage.
- What to inspect next:
  keep it as the best reference whenever a future study needs
  `platform-native embedded runtime` lessons rather than ordinary Windows
  runtime registration flows.

## `rinsuki/FruitXR`

- GitHub:
  [rinsuki/FruitXR](https://github.com/rinsuki/FruitXR)
- What it is:
  a very early macOS OpenXR runtime proof of concept with a local runtime
  server, Mach IPC, and a WebXR-facing bridge.
- Why it matters:
  it is the clearest donor in the repo for
  `runtime/server split with local IPC in a nontraditional platform experiment`.
- Interesting ideas:
  separate the runtime surface from the host app; use local IPC rather than
  forcing everything into one process; expose a bridge layer to other client
  technologies while keeping a minimal runtime core.
- Interesting implementation choices:
  `Sources/Runtime/XRInstance.swift` and `Sources/App/XRServer.swift` make the
  `runtime primitives -> Mach IPC server` split explicit.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  deliberately non-conformant and highly experimental.
- What to inspect next:
  keep it as the best proof-of-concept donor whenever a future platform path
  needs `local runtime service boundaries` more than standards completeness.

## Main takeaways from Wave 33

- `Alternative OpenXR runtimes` are now a meaningful branch inside the repo,
  not only fringe proof-of-concept noise.
- The strongest split in this family is:
  - `clean layered special-display runtime`
  - `focused applied runtime for a narrow consumer workflow`
  - `embedded platform-native runtime framework`
  - `runtime/server proof of concept with local IPC`
- The most reusable lesson is usually `runtime decomposition`, not platform
  support claims:
  - explicit layer boundaries
  - per-platform system implementations
  - graphics-backend separation
  - server-backed runtime ownership
  - vendor or hardware isolation rules.

## Reusable methods clarified by this wave

- `Cleanly layered alternative OpenXR runtime for special displays`
- `Embedded or platform-native OpenXR runtime framework`
- `Runtime/server split with local IPC for experimental OpenXR platforms`

## Recommended next moves after this wave

1. Treat `displayxr-runtime` as the main architecture donor for
   `special-display OpenXR runtime` work.
2. Keep `XRGameBridge` as the most applied donor for a narrow
   `runtime wrapper around a concrete display workflow`.
3. Use `OpenXRKit` whenever a future path needs
   `embedded runtime framework` lessons on a platform-native stack.
4. Keep `FruitXR` visible as the most useful proof of concept for
   `runtime/server separation` in a nontraditional platform branch.
