# VR Projects Wave 105: VRCFury Toggle Automation, Avatar Animator DSLs, and Editor QoL Overlays

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `VRCFury installer automation`, `toggle generation`,
  `avatar animator DSLs`, and `editor QoL overlays`.

## Why this wave exists

Avatar composition had already become a strong repository branch, but the
VRCFury-centered layer needed a more specific synthesis. This wave focuses on
how avatar features get installed, previewed, toggled, menu-paginated, and
generated from code or editor tooling.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by VRCFury and avatar automation families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `VRCFury/VRCFury` | Major feature-builder substrate for avatar automation |
| `RealWhyKnot/wk-vrcfury-qol` | Reflection-backed QoL overlay and clone-preview extension around VRCFury |
| `SuperFlue/VRCToggleToolkit` | Focused editor generator for toggles, clips, FX layers, parameters, and menus |
| `hai-vr/animator-as-code-vrchat` | Code-first DSL extensions for VRChat animator behaviors |
| `vr-voyage/vrchat-quick-toggle-vrcfury` | Tiny public-API micro-utility that creates VRCFury toggles from selection |

## Deep-pass notes by project

## `VRCFury/VRCFury`

- GitHub:
  [VRCFury/VRCFury](https://github.com/VRCFury/VRCFury)
- What it is:
  a broad avatar feature automation system for VRChat creators.
- Interesting idea:
  avatar install automation can expose a public API while keeping a deeper
  feature-builder and build-pipeline substrate underneath.
- Code-level notes:
  `MenuSplitter.cs`
  splits VRChat expression menus when they exceed control limits and clamps
  defensive SDK edge cases.
  `VRCAvatarUtils.cs`
  discovers avatar controllers, menus, parameters, and materializes defaults
  with useful error hints.
  `VRCFuryInjectorTest.cs`
  validates dependency injection contexts for services, feature builders,
  action builders, editor methods, build methods, and autowired fields.
  `FuryToggle.cs`
  exposes a compact public toggle wrapper with menu path, slider, default,
  saved state, exclusive tags, global parameter, and actions.
- Code donor value:
  very high for feature-builder substrate, public API design, and build-time
  guardrails.
- Product reference value:
  very high for non-destructive avatar feature installation.
- Caveats:
  the project is large, so this wave focused on representative architecture
  seams rather than full coverage.
- What to inspect next:
  NDMF integration, conflict resolution, feature ordering, and generated
  controller artifacts.

## `RealWhyKnot/wk-vrcfury-qol`

- GitHub:
  [RealWhyKnot/wk-vrcfury-qol](https://github.com/RealWhyKnot/wk-vrcfury-qol)
- What it is:
  a VRCFury QoL extension that injects context tools, inspector buttons,
  banners, previews, hot reload, and reference helpers where creators already
  work.
- Interesting idea:
  extend an existing creator ecosystem with a reflection-backed shell instead
  of forking the upstream tool.
- Code-level notes:
  `VrcfQol.cs`
  lazily resolves VRCFury internal types, caches reflection handles, and
  exposes typed registration helpers for property, flipbook, toggle, and
  action tools.
  `VrcfQolInspectorOverlay.cs`
  polls open Unity inspector roots and injects UIElements controls inline while
  the right-click context menu stays the authoritative fallback.
  `PreviewTool.cs`
  clones an avatar, applies VRCFury state actions to the clone, hides the
  original, and cleans abandoned previews across reloads, play mode changes,
  and quit.
- Code donor value:
  very high for reflection extension shells, inspector overlays, and
  non-destructive clone preview.
- Product reference value:
  high because it improves workflow without replacing the upstream tool.
- Caveats:
  reflection-backed integration is powerful but brittle across upstream
  internal changes.
- What to inspect next:
  compare its clone preview cleanup against avatar emulator donors.

## `SuperFlue/VRCToggleToolkit`

- GitHub:
  [SuperFlue/VRCToggleToolkit](https://github.com/SuperFlue/VRCToggleToolkit)
- What it is:
  a Unity editor tool that generates VRChat avatar toggles, animation clips,
  FX controller layers, expression parameters, and menu entries.
- Interesting idea:
  turn repetitive avatar toggle work into one explicit generation window while
  keeping dangerous regeneration choices visible.
- Code-level notes:
  `VRCToggleToolkitAuto.cs`
  auto-fills from `VRCAvatarDescriptor`, collects toggle GameObjects and
  settings, generates clips, applies animator layers, creates VRChat
  parameters and expression menu entries, supports exclusive toggles,
  fallback state, save subfolders, and write-default choices.
- Code donor value:
  high for generator-window structure and toggle asset emission.
- Product reference value:
  high as a focused creator micro-tool.
- Caveats:
  it is an older, more direct generator style than modern build-pipeline
  systems, so it is best treated as a workflow reference.
- What to inspect next:
  compare generated assets against VRCFury and Modular Avatar approaches.

## `hai-vr/animator-as-code-vrchat`

- GitHub:
  [hai-vr/animator-as-code-vrchat](https://github.com/hai-vr/animator-as-code-vrchat)
- What it is:
  VRChat-specific extension methods for the Animator As Code library.
- Interesting idea:
  make VRChat animator behaviors code-first while preserving readable fluent
  authoring.
- Code-level notes:
  `AacVRCExtensions.cs`
  adds fluent methods for parameter drivers, increase/decrease/remap/copy
  behavior, local and unsynced randomization, local-only driving, and
  `VRCAnimatorPlayAudio` setup with safe defaults such as never applying
  play or stop unless explicitly requested.
- Code donor value:
  very high for DSL design around VRChat animator behaviors.
- Product reference value:
  high for code-first creator automation.
- Caveats:
  it is strongest when paired with a broader animator-as-code workflow.
- What to inspect next:
  use it as a comparison node for future code-generated avatar component
  graphs.

## `vr-voyage/vrchat-quick-toggle-vrcfury`

- GitHub:
  [vr-voyage/vrchat-quick-toggle-vrcfury](https://github.com/vr-voyage/vrchat-quick-toggle-vrcfury)
- What it is:
  a tiny Unity editor helper that creates VRCFury item toggles from selected
  GameObjects.
- Interesting idea:
  a public API can make useful tools tiny. This repo proves that a high-value
  creator action can fit in a very small script.
- Code-level notes:
  `VoyageHelpers.cs`
  iterates selected GameObjects, calls `FuryComponents.CreateToggle(go)`,
  adds a turn-on action, sets a `Toggles/{go.name}` menu path, and uses the
  object's active state to choose a default-on state.
- Code donor value:
  medium-high as a micro-utility template.
- Product reference value:
  high because it shows the benefit of exposing stable public APIs.
- Caveats:
  it is intentionally thin and relies on VRCFury to do the heavy lifting.
- What to inspect next:
  keep it as a small reference for future one-click creator helper prototypes.

## Main takeaways from Wave 105

- VRCFury automation is a distinct family inside avatar tooling, not just a
  duplicate of Modular Avatar or generic package management.
- The strongest architecture pattern is `feature substrate plus thin public
  APIs`.
- Reflection-backed QoL overlays can add real creator value without forking an
  upstream tool, but they need careful cleanup and graceful failure.
- Code-first animator DSLs are a serious reusable branch for future avatar
  automation prototypes.
- Micro-utilities matter because they reveal whether a public API is actually
  ergonomic.

## Reusable methods clarified by this wave

- `Feature-builder avatar installer with DI verification, public API wrappers, and menu auto-pagination`
- `Reflection-backed editor extension shell with inspector overlay, clone preview, and cleanup`
- `Toggle generator that emits clips, FX layers, parameters, expression menu entries, and exclusive state`
- `VRChat animator DSL for parameter drivers and safe play-audio behavior`
- `Tiny public-API micro-tool over selected avatar objects`

## Recommended next moves after this wave

1. Keep `VRCFury` visible as a strong avatar feature-substrate donor.
2. Keep `wk-vrcfury-qol` visible as the current best reflection-backed QoL
   overlay donor.
3. Compare `VRCToggleToolkit`, `vrchat-quick-toggle-vrcfury`, and VRCFury
   public APIs whenever a future prototype needs toggle generation.
4. Treat `animator-as-code-vrchat` as the clearest current code-first VRChat
   animator behavior donor.
