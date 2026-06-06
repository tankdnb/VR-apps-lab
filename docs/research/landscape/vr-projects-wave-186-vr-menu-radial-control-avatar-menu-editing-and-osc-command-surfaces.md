# VR Projects Wave 186: VR Menu, Radial Control, Avatar-Menu Editing, and OSC Command Surfaces

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 186 studies command surfaces for VR utilities: in-headset radial menus,
physical/animated menu items, Quest app-launcher metaphors, VRChat menu editing,
and desktop OSC companions that provide controls unavailable or inconvenient in
the in-game radial menu.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `VRwithAndrew/VR-RadialMenu` | Unity radial menu tutorial/template | Source-light baseline |
| `Gustorvo/RadialMenuVR` | Physically animated radial menu | Strong radial-menu donor |
| `ryangadz/RadialMenu` | Unreal XR radial-menu plugin assets | Binary/source-light reference |
| `GabrielDiDomenico/RadialMenu` | Wrist-rotation radial menu demo | Thin wrist-menu reference |
| `kblood/Quest-VR-Menu` | Quest VR launcher/home menu prototype | Product/code reference |
| `CascadianVR/VRC-Menu-Translator` | Unity Editor VRChat expression-menu translator | Strong editor utility reference |
| `Tazaur/VrCScalingTool` | Windows OSC scaling command companion | Strong desktop OSC command donor |

## `VRwithAndrew/VR-RadialMenu`

- Interesting idea:
  small Unity radial-menu tutorial template with art, prefab, scene, and stub
  scripts.
- Code donor value:
  low; core scripts were effectively empty in this pass.
- Product reference value:
  medium as a tutorial/product-line signal for simple radial menu construction.
- What to inspect next:
  revisit only if tutorial branch/source is completed.
- Source evidence:
  `Assets/Prefabs/RadialMenu.prefab`, `Assets/Textures/*`,
  `Assets/Scripts/RadialMenu.cs`, `RadialSection.cs`, and `InputManager.cs`.
- Reusable pattern extraction:
  none beyond source-light radial menu skeleton.
- Caveats:
  do not treat as donor-worthy code.

## `Gustorvo/RadialMenuVR`

- Interesting idea:
  build a dynamic radial menu that can open/close, rotate items, emit hover and
  selection events, attach indicators/text, and animate using numeric springs.
- Code donor value:
  high for menu item management, hover/selection lifecycle, attachments, and
  spring animation.
- Product reference value:
  high for in-headset command palettes and tool menus.
- What to inspect next:
  hand-tracking support, nested menus, state machine roadmap, and audio velocity
  feedback.
- Source evidence:
  `README.md`, `Assets/RadialMenuVR/Scripts/RadialMenu.cs`,
  `ItemsManager.cs`, `MenuMover.cs`, `MenuScaler.cs`,
  `AttachmentBase.cs`, `AttachedIndicator.cs`, `AttachedText.cs`,
  `Animators/NumericSpring.cs`, and demo scripts.
- Reusable pattern extraction:
  numeric-spring radial command menu.
- Reusable core:
  derive item positions from radius/count/circle mode, track hovered index,
  emit hover/select/toggle/rebuild events, support circular or half-circle
  stepping, animate positions/scale/rotation through reusable animators, and
  keep attached indicators/text following the selected item.
- Do not copy directly:
  `NaughtyAttributes` dependency, incomplete roadmap features, and hardwired
  demo/audio assets.
- Caveats:
  strong donor but still early-development code.

## `ryangadz/RadialMenu`

- Interesting idea:
  Unreal Engine plugin asset pack for XR radial menus, with Blueprint assets,
  materials, example items, and icon enum/data-table assets.
- Code donor value:
  low in source form because most logic is `.uasset` content.
- Product reference value:
  medium for Unreal/XR radial menu packaging and sample-asset structure.
- What to inspect next:
  inspect in Unreal only if a future Unreal prototype needs Blueprint-level
  radial menu behavior.
- Source evidence:
  `README.md`, `RadialMenu.uplugin`, `Content/BP_RadialMenu.uasset`,
  `BP_MenuItem.uasset`, `BPI_MenuItems*.uasset`, `BPFL_RadialMenuMath.uasset`,
  and example assets.
- Reusable pattern extraction:
  source-light Unreal radial menu asset pack.
- Caveats:
  binary assets limit static code extraction.

## `GabrielDiDomenico/RadialMenu`

- Interesting idea:
  explore radial menu navigation through wrist rotation in a Unity/XRI sample
  project.
- Code donor value:
  low-medium; custom code visible in the pass was small and much of the project
  is imported XRI/hand samples.
- Product reference value:
  medium for wrist-rotation menu concept and alpha-hit-test UI selection.
- What to inspect next:
  identify whether wrist-angle selection logic exists outside template/sample
  files.
- Source evidence:
  `README.md`, `Assets/Samples/.../RadialMenuVR/CanvasHandler.cs`,
  `matrixClass.cs`, XRI starter assets, XR Hands samples, and scene files.
- Reusable pattern extraction:
  wrist-rotation radial menu concept.
- Reusable core:
  use controller or wrist orientation to choose radial sectors, combine UI
  raycast results with alpha-hit-test sprites, and separate the concept from
  imported XRI starter assets.
- Do not copy directly:
  sample bloat, imported hand/XRI assets, or incomplete custom logic.
- Caveats:
  useful idea signal, not a mature donor.

## `kblood/Quest-VR-Menu`

- Interesting idea:
  create a Quest VR home/menu where grabbable app cubes collide with a console
  cube to launch installed Android apps.
- Code donor value:
  medium for Android package introspection, launch intent calls, and physical
  command-object metaphor.
- Product reference value:
  high for VR launcher/home surfaces and non-panel command UX.
- What to inspect next:
  app enumeration, package-to-cube assignment, error handling, and permissions
  on modern Quest firmware.
- Source evidence:
  `README.md`, `Assets/_MyStuff/Scripts/GameCubeApp.cs`,
  `ConsoleCube.cs`, `AndroidNativeFunctions/Scripts/AndroidNativeFunctions.cs`,
  scenes, and Android native helper scripts.
- Reusable pattern extraction:
  physical VR launcher menu using Android intents.
- Reusable core:
  represent apps as labeled 3D objects, use physical collision/selection as
  command confirmation, get launch intents from Android package manager, and
  call `startActivity` from Unity's current Android activity.
- Do not copy directly:
  random app assignment, brittle plugin code, old Oculus/Unity setup, or
  incomplete failure fallback.
- Caveats:
  prototype quality but conceptually useful.

## `CascadianVR/VRC-Menu-Translator`

- Interesting idea:
  recursively traverse VRChat expression menus in Unity Editor and translate
  menu/control names one-by-one or in bulk.
- Code donor value:
  high for compact editor-window traversal and asset mutation.
- Product reference value:
  high for creator-facing menu QA, localization, and accessibility tooling.
- What to inspect next:
  undo support, API rate/error handling, URL escaping, dry-run preview, and
  non-Google translation providers.
- Source evidence:
  `README.md` and `VRCMenuTranslator.cs`.
- Reusable pattern extraction:
  recursive VRChat expression-menu editor utility.
- Reusable core:
  open an editor window, take an avatar root, get its `VRCAvatarDescriptor`,
  recursively collect nested `VRCExpressionsMenu` assets, show menu/control
  rows, mutate names, rename menu assets, mark dirty, and save assets.
- Do not copy directly:
  blocking `.Result` HTTP, unescaped query strings, no Undo integration, and no
  robust API failure handling.
- Caveats:
  strong micro-utility pattern with obvious hardening needs.

## `Tazaur/VrCScalingTool`

- Interesting idea:
  provide a Windows desktop command surface for VRChat avatar scale, including
  slots, nudge controls, hotkeys, OSC receive triggers, OSCQuery discovery, tray
  UI, and SteamVR manifest registration.
- Code donor value:
  high for OSC command slot model, local persistence, avatar feedback, global
  hotkeys, and SteamVR app manifest generation.
- Product reference value:
  high for desktop companions that make in-game commands faster than radial
  menus.
- What to inspect next:
  safety caps, multi-avatar profiles, OSCQuery compatibility, and signed build
  distribution.
- Source evidence:
  `README.md`, `osc_client.py`, `osc_server.py`, `oscquery.py`, `slots.py`,
  `persistence.py`, `steamvr.py`, `ui.py`, and `scaling_main.py`.
- Reusable pattern extraction:
  desktop OSC macro surface with slots and avatar feedback.
- Reusable core:
  clamp command values, send OSC to `/avatar/eyeheight`, listen for avatar
  bool triggers, expose an OSCQuery tree for parameters, persist named slots,
  provide global hotkeys, maintain undo state, and register as a SteamVR
  dashboard app via `.vrmanifest`.
- Do not copy directly:
  avatar-scale-specific limits, Windows-only assumptions, or unsigned binary
  distribution caveats.
- Caveats:
  very useful companion-tool donor even though it is not an in-HMD overlay.

## Cross-Project Lessons

- VR command surfaces are not only in-headset radial menus; editor tools and
  desktop companions are also part of the menu/control ecosystem.
- The best radial menus separate item placement, hover state, selection events,
  attachments, and animation.
- Physical object commands can make launcher/menu actions feel tangible but
  need safety/error feedback.
- Creator-facing menu utilities should include dry-run, undo, and validation
  when they mutate assets.
- Desktop OSC companions can bypass in-game radial limits, but they must expose
  clear safety bounds and avatar state feedback.

## Reuse Recommendations

1. Use `Gustorvo/RadialMenuVR` as the strongest in-headset radial-menu donor.
2. Use `Tazaur/VrCScalingTool` as the strongest desktop companion command
   surface donor.
3. Use `CascadianVR/VRC-Menu-Translator` as the editor-side traversal/mutation
   reference.
4. Keep `Quest-VR-Menu` as a physical launcher/menu concept.
5. Mark `VRwithAndrew/VR-RadialMenu`, `ryangadz/RadialMenu`, and
   `GabrielDiDomenico/RadialMenu` as source-light or thin comparison nodes.
