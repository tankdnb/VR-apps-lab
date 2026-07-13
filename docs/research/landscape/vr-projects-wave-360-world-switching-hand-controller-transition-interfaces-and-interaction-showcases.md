# Wave 360: World Switching Hand Controller Transition Interfaces and Interaction Showcases

## Scope

This wave studies VR projects that help users move between virtual worlds,
preview destinations, switch between hand and controller input, and use
showcase/debug tooling as reusable scaffolding. The reusable lesson is not a
single app; it is a transition-interface boundary that can power future VR
utilities, labs, launchers, and environment switchers.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `mott-lab/WorldSwitchUI` | Studied | CHI 2026 experiment software with portal, gallery, wheel, palette, and world-in-miniature transition interfaces separated from interaction controllers |
| `oculus-samples/Unity-NorthStar` | Studied | Meta Quest showcase with debug menu, scene loading, hand/IK helpers, editor hygiene tools, subtitles, and vendor-sample boundaries |
| `alexismorin/Unity-VR-Hand-Tracking-Template` | Source-light | Quest hand-tracking bootstrap with performance-oriented Unity/Oculus setup notes and modular kit framing |
| `Corysia/Unity-Oculus-Example` | Source-light | Oculus Integration starter recipe for animated hands, locomotion, collision, grabbing, graphics settings, and credential caveats |

## Reusable Pattern Extraction

- Pattern candidate: `world-transition interface and preview-palette boundary`.
- Problem solved: VR utilities often need to move users between environments,
  modes, or data spaces without hiding destination context or binding UI to one
  input device.
- Reusable core: world target catalog, destination metadata, transition UI
  manager, display interface, interaction handler, activation gesture,
  controller button adapter, preview surface, confirmation/cancel path, state
  handoff, task/session logger, and hand/controller fallback.
- Source evidence: WorldSwitchUI splits display code under
  `Scripts/TransitionInterfaces` from interaction controllers, includes
  `TransitionManager`, `TransitionUIManager`, `WorldTargetManager`, and multiple
  portal/gallery/palette/WIM variants. Unity-NorthStar adds debug menu,
  scene-loader, IK, subtitle, and editor tooling examples.
- Abstraction boundary: transition UI should describe and preview destinations;
  interaction adapters should map hands/controllers to activation events; world
  loading and logging should stay behind services.
- What not to copy: paid assets, study-specific coin tasks, vendor sample
  content, hardcoded experiment scenes, or setup recipes that assume one old SDK
  version.
- Method catalog action: create a new world-transition method.

## Project Notes

### `mott-lab/WorldSwitchUI`

- Interesting idea: a research harness compares portal, gallery, wheel,
  palette, and world-in-miniature interfaces for moving between VR worlds.
- Code donor value: very high for transition interface classes, interaction
  handlers, target/menu managers, hand smoothing, study UI, data logging, and
  Latin-square experiment utilities.
- Product reference value: very strong for launchers, scene switchers,
  mode-switching overlays, and spatial navigation tools.
- What to inspect next: measured user preference, error rate, preview
  readability, and whether palette/WIM variants generalize to utility panels.
- Caveats: built as experiment software with paid assets and study tasks; reuse
  the interface boundary, not the content pack.

### `oculus-samples/Unity-NorthStar`

- Interesting idea: a large vendor showcase keeps debug actions, scene loading,
  hand/IK tools, subtitle/dialogue, and editor hygiene visible instead of hiding
  them inside scene content.
- Code donor value: high for debug menu/action handlers, IK/retarget helpers,
  grab repair tools, scene loader, FPS display, prefab/model utilities, and
  subtitle text pipeline.
- Product reference value: strong for how a polished sample exposes debug and
  maintenance surfaces around XR interaction.
- What to inspect next: how debug actions are registered, how hand-grab repair
  tools map to assets, and how Application Spacewarp constraints shape scene
  design.
- Caveats: vendor-heavy Meta sample; copy structure and maintenance ideas, not
  SDK-specific assumptions.

### `alexismorin/Unity-VR-Hand-Tracking-Template`

- Interesting idea: a template packages Quest hand tracking around known Unity,
  Oculus Integration, rendering, compression, and performance settings.
- Code donor value: low to moderate; useful as a setup checklist and modular
  bootstrap reference.
- Product reference value: useful for documenting starter assumptions and
  performance defaults.
- What to inspect next: hand interaction prefabs, lighting/tracking caveats,
  and whether the template still maps cleanly to modern OpenXR/Interaction SDK.
- Caveats: older Unity/Oculus stack; do not treat as a current build baseline.

### `Corysia/Unity-Oculus-Example`

- Interesting idea: a compact starter recipe explains animated hands,
  thumbstick locomotion, collision, simple grabbing, Android/Quest settings, and
  LocalAvatar App ID caveats.
- Code donor value: moderate as a checklist for first-scene interaction setup.
- Product reference value: useful for beginner-facing documentation and
  credential hygiene warnings.
- What to inspect next: collision constraints, layer matrix choices, and how to
  translate the recipe to modern packages.
- Caveats: old Oculus Integration 1.40 guidance; preserve only the setup logic.

## Product Direction

This wave supports a `world switcher and transition preview` branch: future VR
utilities can expose environments, modes, datasets, or workspaces through a
destination catalog, preview UI, activation adapter, and logging/debug shell.

