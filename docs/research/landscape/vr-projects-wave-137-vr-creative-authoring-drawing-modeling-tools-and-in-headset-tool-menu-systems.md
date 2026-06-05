# VR Projects Wave 137: VR Creative Authoring, Drawing/Modeling Tools, and In-Headset Tool/Menu Systems

- Date: `2026-06-05`
- Goal: study creative VR tools as reusable references for in-headset menus,
  tool catalogs, command systems, panels, shelves, and asset/export workflows.

## Why this wave exists

Creative tools are among the best references for complex VR utility UX. They
must let users switch tools, manage modes, configure brushes, save work, export
assets, recover from mistakes, and understand controller affordances without
leaving the headset. This wave treats them as architecture and interaction
donors, not just art applications.

## Better workflow used in this wave

1. searched by VR painting, VR modeling, Tilt Brush lineage, WebXR authoring,
   and brush/shelf/menu families;
2. deduplicated against prior WebXR creative-tool and hand-menu waves;
3. froze a shortlist of canonical donors and variants;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `googlevr/tilt-brush` | Canonical Unity VR painting app architecture |
| `icosa-foundation/open-brush` | Active Open Brush fork with API, XR, and multiplayer extension points |
| `googlevr/blocks` | Unity VR modeling app with command history and export pipeline |
| `SideQuestVR/SideSketch` | Tilt Brush fork/variant useful for rebrand/distribution lessons |
| `zach-capalbo/vartiste` | Browser-native WebXR/A-Frame authoring surface with shelves and brush packs |

## Deep-pass notes by project

## `googlevr/tilt-brush`

- GitHub:
  [googlevr/tilt-brush](https://github.com/googlevr/tilt-brush)
- What it is:
  the archived open-source release of Google's Unity VR painting app.
- Interesting idea:
  treat a complex VR app as a set of catalogs, managers, panels, commands, and
  explicit app states rather than as one monolithic scene.
- Code-level notes:
  `App.cs` coordinates loading states, brush/environment catalogs,
  `BrushController`, `PointerManager`, quick load, panels, tutorial hints,
  sketch load/export, and HTTP load callbacks. The project separates large
  areas such as Audio, Environments, Materials, Models, Plugins, Prefabs,
  Resources, Scenes, Scripts, Shaders, SteamVR input, and native C++ support.
- Code donor value:
  high for mature VR app lifecycle, panel/tool organization, catalogs, and
  global command surfaces.
- Product reference value:
  high for in-headset creative workflow expectations.
- Caveats:
  archived Unity 2018/SteamVR-era code and large codebase; reuse should be
  conceptual and selective.
- What to inspect next:
  compare panel/tool switching with Open Brush and WebXR shelf models.

## `icosa-foundation/open-brush`

- GitHub:
  [icosa-foundation/open-brush](https://github.com/icosa-foundation/open-brush)
- What it is:
  the community-led continuation of Tilt Brush.
- Interesting idea:
  evolve an archived VR creative tool into an extensible platform with modern
  XR direction, scripting/API surfaces, and multiplayer.
- Code-level notes:
  the project adds OpenXR/XR settings, API modules, Lua wrappers for app,
  brush, camera, color, environment, group, guide, headset, image, and layer
  operations, plus Photon multiplayer files such as `PhotonManager`,
  `PhotonPlayerRig`, RPC batching, voice, and shared structs.
- Code donor value:
  very high for external automation/API design and creative-tool extension
  surfaces.
- Product reference value:
  high for modernizing a large VR tool while preserving user workflow.
- Caveats:
  very large Unity project; needs targeted extraction before prototype reuse.
- What to inspect next:
  create a focused reuse note around Open Brush API boundaries if scripting
  becomes active.

## `googlevr/blocks`

- GitHub:
  [googlevr/blocks](https://github.com/googlevr/blocks)
- What it is:
  the archived open-source release of Google's Unity VR modeling app.
- Interesting idea:
  model editing as serializable commands that can support undo, persistence,
  and export rather than direct scene mutations only.
- Code-level notes:
  `proto/command_protos.proto` defines command messages such as add mesh,
  change face properties, composite command, copy, delete, move, replace, and
  set mesh groups. The source includes command classes under
  `Assets/Scripts/model/core` and export code for OBJ, FBX, glTF, thumbnails,
  and service upload flows.
- Code donor value:
  high for command-object edit history and multi-format export pipeline.
- Product reference value:
  high for VR modeling and asset workflow structure.
- Caveats:
  archived code and not a small utility donor.
- What to inspect next:
  compare command serialization with any future VR editor or calibration UI
  that needs undo/history.

## `SideQuestVR/SideSketch`

- GitHub:
  [SideQuestVR/SideSketch](https://github.com/SideQuestVR/SideSketch)
- What it is:
  a SideQuest-branded Tilt Brush fork/variant.
- Interesting idea:
  a fork can be valuable as a distribution and rebrand lesson even when its
  architecture mostly follows upstream.
- Code-level notes:
  `App.cs` changes display/vendor naming to SideSketch/SideQuest while keeping
  some Tilt Brush folder assumptions, includes platform checks, and adds a
  request path such as audio-reactive brush toggling.
- Code donor value:
  low-medium; mainly a fork/variant comparison node.
- Product reference value:
  medium for rebrand, distribution, and platform-port lessons.
- Caveats:
  do not treat it as a separate full donor from Tilt Brush/Open Brush unless a
  future pass finds unique architectural changes.
- What to inspect next:
  only revisit if SideQuest-specific packaging or audio-reactive brush work
  becomes relevant.

## `zach-capalbo/vartiste`

- GitHub:
  [zach-capalbo/vartiste](https://github.com/zach-capalbo/vartiste)
- What it is:
  a WebXR/A-Frame creative authoring app.
- Interesting idea:
  browser-native VR tools can be composed from small A-Frame systems and
  movable shelves instead of Unity-style manager singletons.
- Code-level notes:
  `brush-editor.js` registers an A-Frame brush system, loads brush packs,
  supports default and user brushes, and includes image, stretch, lambda,
  procedural, FX, flood fill, line, and fill-shape brushes. `shelf.js` defines
  a movable shelf component with close/pin/hide behavior, frames, popups,
  grab-root, and dynamic sizing. `avatar.js` references remote avatar,
  spectator, Hubs, and ReadyPlayerMe-compatible pose export paths.
- Code donor value:
  high for componentized WebXR shelves, brush packs, and browser-native tool
  surfaces.
- Product reference value:
  high for web-first VR authoring UX.
- Caveats:
  large browser app; targeted component extraction is safer than broad reuse.
- What to inspect next:
  compare with A-Frame inspectors, hand menus, and browser-native diagnostic
  surfaces.

## Cross-project extraction

- Mature creative VR tools need a tool-state spine:
  app states, catalogs, panels/shelves, commands, persistence, export, and
  controller hints should be designed together.
- Forks are comparison nodes:
  `SideSketch` should strengthen lineage understanding without inflating the
  registry as an independent architecture.
- Unity and WebXR solve menu/shelf problems differently:
  Unity projects lean on managers and renderable panels, while WebXR/A-Frame
  projects lean on entities/components and movable shelves.
- Command serialization matters outside art tools:
  modeling commands in `Blocks` are also relevant to calibration editors,
  scene setup tools, and any VR utility that needs undo/history.

## Reusable methods extracted

- VR creative tool app-state with catalogs, panel manager, global command
  surface, and load/export lifecycle.
- Componentized browser-native authoring shelves and brush systems.
- Command/proto-based VR modeling edit history and multi-format export
  pipeline.

## Caveats for future use

- These are large projects; copying code directly would be high-risk.
- Archived GoogleVR projects are best treated as architecture references.
- Open Brush is active but too broad for one pass; future reuse should target
  API boundaries or a specific panel/tool path.

## Next gaps

- Build a menu/shelf/tool comparison matrix across Unity, WebXR, and dashboard
  overlay projects.
- Queue a focused Open Brush API pass if external automation becomes active.
- Compare creative-tool command histories with diagnostics/checklist editing
  needs.
