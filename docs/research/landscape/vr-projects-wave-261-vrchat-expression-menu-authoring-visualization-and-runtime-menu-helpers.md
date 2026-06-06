# Wave 261 - VRChat Expression Menu Authoring, Visualization, and Runtime Menu Helpers

This wave studies VRChat expression-menu, avatar-toggle, material-menu, and
runtime-menu helper projects. The focus is not "menus" as a vague UX topic,
but reusable authoring pipelines: source selection, generated assets,
parameter contracts, visual inspection, conflict handling, undo, and caveated
runtime quick-menu modification.

## Scope

The wave was bounded to projects that help create, inspect, or alter VRChat
menus:

- expression menu icons and visualizers;
- menu/parameter/animator merging;
- outfit/prop toggle generation;
- text-to-menu and object-toggle generators;
- runtime quick-menu helper libraries;
- menu visibility/rendering patches.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `nekochanfood/VRCStyledIconMaker` | Expression menu icon pipeline | Studied | Asset preprocessing for menu icons with padding, gradient, and shadow rules |
| `nekoare/vrchat-expression-menu-visualizer` | Expression menu visualizer/editor | Studied | Unity editor tree/grid view, Modular Avatar reflection, drag/drop editing, generated metadata |
| `imagitama/vrc-menu-merger` | Menu/params/animator merger | Studied | Merges menus, expression parameters, and animator layers with conflict checks |
| `zutozuto/VRChat-Menu-Creation-Tool` | Outfit/prop menu generator | Studied | ScriptableObject config for clothes, ornaments, extra groups, sub toggles, show/hide paths |
| `Knucklesfan/VRChatTextToMenu` | Text-to-submenu generator | Studied | Generates nested menu YAML pages from text lines |
| `Lucario4LyfeYT/EasyToggle` | Object toggle generator | Studied | Creates animation clips, animator layers, parameters, and menus from selected objects |
| `AtiLion/VRCMenuUtils` | Runtime quick-menu mod library | Caveated reference | Reflection-based VRChat UI/quick-menu API for mods |
| `CaelBun/DontOverrenderMyMenuV2` | Runtime menu render patch | Caveated reference | Menu overrender fix via cloned UI camera, culling masks, Harmony patches, quick-menu toggle |

## Code-Level Findings

### `nekochanfood/VRCStyledIconMaker`

- Interesting idea:
  treat expression-menu icons as a repeatable mini-pipeline rather than manual
  image editing.
- Code donor value:
  useful for fixed 256 icon canvas, SVG-to-PNG resize/padding via `sharp`,
  PIL/OpenCV recolor, gradient fill, transparent canvas expansion, and drop
  shadow generation.
- Product reference value:
  good micro-utility shape for creator-facing polish tools.
- What to inspect next:
  GUI/wizard potential, icon licensing, batch naming, and VPM integration.
- Caveats:
  scripts are local asset processors, not Unity-integrated authoring tools.

### `nekoare/vrchat-expression-menu-visualizer`

- Interesting idea:
  visualize expression menus as a navigable tree/grid, including
  ModularAvatar-installed menu items, and allow editing with drag/drop.
- Code donor value:
  strong for EditorWindow state, avatar descriptor selection, visited menu
  tracking, control search, stats, edit mode, multilingual labels, reflection
  against ModularAvatar types, generated marker components, metadata sync on
  hierarchy changes, and editor-only generated objects.
- Product reference value:
  excellent reference for a creator workbench that turns nested menu assets
  into inspectable and editable structure.
- What to inspect next:
  save path semantics, Undo coverage, generated asset cleanup, and conflict
  handling across ModularAvatar and native expression menus.
- Caveats:
  large editor script, localization encoding in raw output, and high risk of
  accidental destructive saves if not wrapped carefully.

### `imagitama/vrc-menu-merger`

- Interesting idea:
  merge multiple expression menus, parameter lists, and animator controllers
  as one explicit creator-side composition step.
- Code donor value:
  useful for 8-control VRChat menu cap enforcement, duplicate control handling,
  parameter type conflict checks, animator layer and parameter merging, and
  `AssetDatabase.CreateAsset` output.
- Product reference value:
  good example of "composition assistant" tooling for avatars with many
  modular features.
- What to inspect next:
  submenu deep merge, animator state-machine reference safety, asset copy vs
  reference semantics, and Undo/preview.
- Caveats:
  merge logic is shallow and may retain references to source assets.

### `zutozuto/VRChat-Menu-Creation-Tool`

- Interesting idea:
  model clothing, ornaments, extra groups, sub toggles, default state, and
  show/hide object paths in a persistent ScriptableObject config.
- Code donor value:
  strong for avatar-specific config asset creation, hierarchy-path capture,
  show/hide list generation, preview toggling, extra-hide logic, grouped
  alternatives, sub-toggle data, and VRC SDK gated editor menu.
- Product reference value:
  useful for future avatar setup assistants that need repeatable toggle/menu
  generation without forcing users to hand-wire every animator path.
- What to inspect next:
  generated animator/menu output functions, path stability on renamed objects,
  localization, and data migration.
- Caveats:
  Chinese/Japanese UI strings, Unity editor-only scope, and path-based state
  can drift when hierarchy changes.

### `Knucklesfan/VRChatTextToMenu`

- Interesting idea:
  generate chains of VRChat menu assets from plain text, handling the 8-item
  page limit with placeholder submenu references.
- Code donor value:
  useful mainly as a minimal example of YAML asset generation and post-pass
  GUID replacement.
- Product reference value:
  good warning/reference for text-driven menu generation and page-size limits.
- What to inspect next:
  safe Unity API replacement for raw YAML, encoding, sorting, icon assignment,
  and direct asset creation.
- Caveats:
  writes Unity YAML by hand, includes compiled output, and relies on a
  placeholder/post pass.

### `Lucario4LyfeYT/EasyToggle`

- Interesting idea:
  turn selected GameObjects into toggle parameters, clips, animator layers,
  and expression menu controls in one editor action.
- Code donor value:
  useful for object selection intake, per-object default state, animation clip
  generation against `m_IsActive`, parameter existence checks, VRC parameter
  appending, menu pagination by 8 controls, and zero-duration transitions.
- Product reference value:
  good small-tool reference for avatar feature toggles.
- What to inspect next:
  path validation, parameter budget, Undo, duplicate object names, asset folder
  safety, and default-state preview.
- Caveats:
  simple one-file implementation; can create many animator layers and params.

### `AtiLion/VRCMenuUtils`

- Interesting idea:
  provide a runtime mod API for VRChat quick-menu pages, buttons, scroll views,
  popups, and pre-flow UI setup.
- Code donor value:
  conceptual value for UI factory shapes, lifecycle gating, reflection against
  VRChat UI managers, and quick-menu duplication/clearing.
- Product reference value:
  useful only as historical runtime-menu UX reference, not as code to copy.
- What to inspect next:
  safer analogues in SDK-supported overlay or OSC surfaces.
- Caveats:
  mod/runtime reflection path with EAC/TOS fragility; do not reuse directly.

### `CaelBun/DontOverrenderMyMenuV2`

- Interesting idea:
  make the VRChat menu render above problematic shaders by splitting UI/menu
  layers into a cloned camera and exposing a quick-menu toggle.
- Code donor value:
  conceptual donor for camera/layer/culling-mask separation, menu visibility
  mode toggle, persistent preferences, and user-facing enable/disable control.
- Product reference value:
  useful as a rendering-problem case study for in-headset menu legibility.
- What to inspect next:
  supported alternatives, shader/queue root causes, and overlay-side menu
  visibility patterns that avoid runtime patching.
- Caveats:
  MelonLoader/Harmony mod, obfuscated VRChat internals, and runtime patching
  are not safe reuse targets.

## Reusable Pattern Extraction

- Pattern candidate:
  VRChat expression-menu authoring pipeline with generated assets, preview,
  conflict checks, and undoable composition.
- Problem solved:
  avatar creators need to combine many toggles, menus, params, animator
  layers, icons, materials, and ModularAvatar items without losing track of
  limits or hidden conflicts.
- Reusable core:
  source intake, icon/material/object selection, parameter contract, menu cap
  handling, generated assets, preview/visualizer, conflict detection,
  undo/rollback, metadata markers, and caveated runtime boundary.
- Source evidence:
  icon processing in `VRCStyledIconMaker`, tree/grid editing in
  `vrchat-expression-menu-visualizer`, merge checks in `vrc-menu-merger`,
  outfit config in `VRChat-Menu-Creation-Tool`, YAML/menu pagination in
  `VRChatTextToMenu`, toggle generation in `EasyToggle`, and runtime menu
  caveats from `VRCMenuUtils` and `DontOverrenderMyMenuV2`.
- Abstraction boundary:
  creator-time asset generation should be separated from runtime VRChat menu
  patching; the former can become reusable, the latter should stay historical
  reference unless an official route exists.
- What not to copy:
  direct runtime patches, raw Unity YAML generation, unbounded layer/parameter
  creation, opaque hierarchy path assumptions, and destructive saves without
  Undo or preview.
- Method catalog action:
  create a method for expression-menu authoring and generated avatar-control
  assets.

## Family Placement

This wave creates a VRChat expression-menu authoring and runtime menu helper
family. It overlaps with earlier radial-menu, Udon-menu, VRCFury, and avatar
composition waves, but focuses specifically on menu assets, parameters,
icons, toggles, and authoring ergonomics.

## Backlog Impact

- Build an expression-menu authoring checklist: input objects, generated
  params, 8-item page limits, icon pipeline, animator changes, Undo, and
  preview.
- Compare ModularAvatar, VRCFury, native expression menus, and raw Unity asset
  generation as separate authoring strategies.
- Keep runtime quick-menu mods as historical UX references only.
