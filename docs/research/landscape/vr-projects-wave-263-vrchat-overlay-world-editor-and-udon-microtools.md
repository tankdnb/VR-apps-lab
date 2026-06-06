# Wave 263 - VRChat Overlay, World Editor, and Udon Microtools

This wave studies smaller VRChat utility projects that do not fit neatly into
one large product line: desktop overlay variants, Unity overlay projects,
editor QoL packages, avatar asset inspectors, old world-editor tools, package
templates, and tiny Udon runtime scripts.

## Scope

The wave was bounded to source-light but useful VRChat utility references:

- desktop overlay or overlay-like companion surfaces;
- Unity/SteamVR overlay experiments;
- editor helper packages for avatars and materials;
- avatar asset scanning and reporting;
- world editor one-shot tools;
- Udon switch/audio/auto-hide micro-scripts;
- package-template and listing references.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `o0F-0oF/vrchatoverlay` | Desktop overlay/log companion | Studied | Avalonia transparent click-through player-list overlay from VRChat logs |
| `kizuki1749/VRChatOverlay` | Unity/SteamVR overlay experiment | Partially studied | Unity scene with SteamVR overlay render texture and bundled VRChat API client |
| `kxn4t/kanameliser-editor-plus` | VRChat editor QoL package | Studied | Mesh info, NDMF preview, material copy/matching, MA material helper, AO bounds, blendshape insertion |
| `Zaknin/VRCTools` | Avatar asset inspector | Studied | Unity editor scan/report/packaging tool for avatar renderers, materials, textures, missing refs, and performance icons |
| `Himakuma/VRChatWorldTools` | Old world editor reset helper | Studied | SDK2 button reset-position listener injector |
| `yassann325/VRC-NetworkQueue` | VPM template/package reference | Source-light | Mostly VRChat template-package baseline with listing website and package skeleton |
| `PeaceKunihiro/vrchat-udon-tools` | Udon runtime microtools | Studied | Cycle switch, audio selector, and auto-hide scripts with Udon sync |

## Code-Level Findings

### `o0F-0oF/vrchatoverlay`

- Interesting idea:
  create a transparent, click-through desktop overlay that tails VRChat logs
  and renders the current player list.
- Code donor value:
  useful for FileSystemWatcher log discovery, tailing the active log with
  `FileShare.ReadWrite`, join/leave regex parsing, UI-thread dispatch, and
  Win32 `WS_EX_LAYERED | WS_EX_TRANSPARENT` window style.
- Product reference value:
  good tiny overlay/companion reference when an in-headset overlay API is not
  required.
- What to inspect next:
  multiple log file rotation, process wait safety, privacy, duplicate joins,
  UX placement, and optional OBS/browser-source output.
- Caveats:
  busy waits, `GetProcessesByName()[0]` risk, checked-in build artifacts, and
  desktop overlay rather than native VR overlay.

### `kizuki1749/VRChatOverlay`

- Interesting idea:
  build a Unity/SteamVR overlay surface around VRChat social/world API data.
- Code donor value:
  partial donor for scene-level overlay layout, `OverlayRenderTexture`, SteamVR
  overlay component, overlay position/rotation, and a bundled C# VRChat API
  client with friends/world/notification endpoints.
- Product reference value:
  useful as a historical example of "VRChat data in an OpenVR overlay" rather
  than as clean reusable code.
- What to inspect next:
  actual custom overlay scripts, API credential handling, scene interactions,
  and separation from bundled SteamVR/API artifacts.
- Caveats:
  repository includes `Library`, `bin`, `obj`, `.vs`, DLLs, Unity project
  artifacts, and likely stale API/auth assumptions. Do not copy directly.

### `kxn4t/kanameliser-editor-plus`

- Interesting idea:
  package many tiny avatar editor quality-of-life tools as one VPM-installable
  helper suite.
- Code donor value:
  strong for mesh info calculation that skips `EditorOnly`, NDMF preview
  comparison, component manager/search, material copy matching by relative
  path/name/depth/fuzzy similarity, ModularAvatar material setter/swap
  generation, AO bounds/root-bone batch UI, and missing blendshape insertion.
- Product reference value:
  strong creator workbench reference because it targets repeated avatar setup
  pain points with small focused tools.
- What to inspect next:
  object matcher details, Undo coverage, package release flow, NDMF optional
  integration, and material-helper generated object cleanup.
- Caveats:
  editor-only, assumes Unity 2022.3+, and several features depend on optional
  NDMF or Modular Avatar packages.

### `Zaknin/VRCTools`

- Interesting idea:
  provide an avatar asset inspector that scans renderers, materials, textures,
  shaders, missing refs, package previews, and performance-oriented summaries.
- Code donor value:
  strong for scanner result model, renderer/material/texture collection,
  texture and mesh memory estimation, missing script/material/mesh detection,
  shader family labels, tabbed EditorWindow, export/package preview states,
  and performance rank icons.
- Product reference value:
  good reference for a future avatar diagnostics panel.
- What to inspect next:
  report exporter and packager details, threshold logic, mobile/PC target
  differences, and generated Unity package hygiene.
- Caveats:
  repository includes a `.unitypackage`; code appears fresh but should be
  treated as editor tool reference, not runtime VR utility.

### `Himakuma/VRChatWorldTools`

- Interesting idea:
  make a one-click editor tool that wires all `VRC_SceneResetPosition`
  callbacks to a selected reset button.
- Code donor value:
  low but clear donor for Unity editor persistent listener automation and
  targeted world setup repair.
- Product reference value:
  useful as an old micro-utility example: one repetitive scene-authoring task,
  one menu command.
- What to inspect next:
  SDK3/Udon equivalent and safer component discovery.
- Caveats:
  SDK2-era `VRCSDK2` dependency and narrow functionality.

### `yassann325/VRC-NetworkQueue`

- Interesting idea:
  mostly a VRChat template-package baseline with a generated VPM listing site.
- Code donor value:
  source-light; useful mainly for package-template structure, `Packages`
  skeleton, VPM manifest, listing website, and GitHub Pages workflow shape.
- Product reference value:
  good reminder to classify template-derived repositories carefully instead of
  treating them as unique implementation donors.
- What to inspect next:
  whether a real NetworkQueue package exists beyond the template/demo content.
- Caveats:
  appears largely template-derived; do not count as deep Udon donor yet.

### `PeaceKunihiro/vrchat-udon-tools`

- Interesting idea:
  keep Udon world utilities tiny: a synced cycle switch, a synced audio
  selector, and an auto-hide component.
- Code donor value:
  useful for `UdonSynced` index state, `RequestSerialization`, owner transfer
  on interact, array-driven object activation, audio clip stop-slot behavior,
  and delayed hide via `SendCustomEventDelayedSeconds`.
- Product reference value:
  good microtool reference for world authors: small scripts can be valuable if
  they solve one interaction cleanly.
- What to inspect next:
  null bounds, late join behavior, owner contention, UI feedback, and package
  installation shape.
- Caveats:
  personal/source-light repo with minimal docs; scripts need robustness review.

## Reusable Pattern Extraction

- Pattern candidate:
  VRChat utility microtool triage boundary across overlay, editor, world, and
  Udon surfaces.
- Problem solved:
  small VRChat projects are easy to misclassify. Some are strong donors, some
  are templates, some are historical artifacts, and some are caveated runtime
  experiments.
- Reusable core:
  surface type, data source, entry point, artifact hygiene, generated assets,
  runtime/editor boundary, sync/network model, package distribution, caveats,
  and donor/reference/follow-up classification.
- Source evidence:
  transparent log overlay in `vrchatoverlay`, Unity/SteamVR scene overlay in
  `VRChatOverlay`, editor QoL suite in `kanameliser-editor-plus`, avatar asset
  scanner in `VRCTools`, SDK2 reset listener in `VRChatWorldTools`, template
  package reference in `VRC-NetworkQueue`, and Udon scripts in
  `vrchat-udon-tools`.
- Abstraction boundary:
  a "VRChat utility" should be categorized first by surface: desktop overlay,
  SteamVR overlay, Unity editor package, world editor command, Udon runtime
  component, or distribution template.
- What not to copy:
  checked-in `Library/bin/obj`, stale API credentials, template content as
  unique donor evidence, SDK2-only assumptions, or tiny Udon scripts without
  sync/late-join review.
- Method catalog action:
  create a method for source-light VRChat utility triage and reuse
  classification.

## Family Placement

This wave creates a source-light VRChat overlay, editor, world, and Udon
microtool family. It overlaps with overlay micro-surfaces, creator diagnostics,
Udon menus, and VPM packaging, but its real purpose is classification: how to
extract value from small or messy repos without over-promoting them.

## Backlog Impact

- Add a source-light utility triage checklist: surface, data source, artifacts,
  donor value, package state, and caveats.
- Deepen `kanameliser-editor-plus` and `Zaknin/VRCTools` if avatar editor
  diagnostics becomes a stronger active direction.
- Treat `kizuki1749/VRChatOverlay` as historical/partial until custom scripts
  are separated from bundled SteamVR/API artifacts.
