# Wave 272 - VR File, Local Asset, and VRM Browser Surfaces

This wave studies VR file browsers, local asset catalogs, runtime VRM import,
and spatial file-manager metaphors across Unity, Rust desktop tooling, and
source-light demand references.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- runtime local-file and VRM import;
- folder/file browsing inside VR;
- local asset cataloging and tag/category metadata;
- spatial file objects, shelves, previews, and destructive operation caveats;
- source-light demand signals for local file browsers.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `NaruAkitsuki/VrmFileManager` | Runtime VRM import helper | Studied with caveats | Compact file-to-avatar import and post-import normalization |
| `AkiMoriDev/VRC-Files-Manager` | Local asset catalog and file packager | Studied with caveats | SQLite metadata, tags/categories, root-folder sync |
| `SirSerl/VRFileManager` | Spatial VR file manager | Studied with artifact and safety caveats | Files as grabbable objects, shelves, previews, copy/trash/move tools |
| `agoetschm/vr_file_browser` | Spatial folder expansion prototype | Studied with caveats | Directory nodes as world objects with focus/unfocus lifecycle |
| `Vode1969/vr-file-browser` | Compact in-VR file picker | Studied with caveats | Extension-filtered file picker with scroll rows and collider selection |
| `hunterdquant/Seeker` | Source-light local file browser intent | Source-light | Confirms demand for loading non-project local files in Unity |

## Code-Level Findings

### `NaruAkitsuki/VrmFileManager`

- Interesting idea:
  import a local `.vrm` file at runtime and immediately normalize it as a
  usable player/avatar object.
- Code donor value:
  useful compact import helper: `File.ReadAllBytes`, `VRMImporterContext`,
  `ParseGlb`, `LoadAsyncTask`, parent assignment, local position reset,
  `Rigidbody` freeze rotation, `CapsuleCollider`, animator-controller
  assignment, tag assignment, and `ShowMeshes`.
- Product reference value:
  good reference for a local avatar import action in a VR asset browser.
- What to inspect next:
  permission gates, streaming/large-file handling, resource-path cleanup,
  controller/avatar setup abstraction, and error reporting.
- Caveats:
  hardcoded resource path, external `TagName.Player`, full file read into
  memory, and little failure handling.

### `AkiMoriDev/VRC-Files-Manager`

- Interesting idea:
  maintain a local root-folder asset catalog with categories, tags, search, and
  item folder packaging.
- Code donor value:
  useful for local asset inventory: `eframe/egui` UI, `rfd` root picker,
  `config.json`, SQLite `files`, `tags`, `categories`, and `subcategories`,
  filesystem-to-category sync, name search, and item packaging into
  root/category/name folders with fixed `data.txt` and `image.png` outputs.
- Product reference value:
  good companion reference for asset libraries that later feed VR browsers or
  creator tools.
- What to inspect next:
  durable item metadata table, duplicate naming policy, thumbnail handling,
  drag/drop import, and VR-facing export schema.
- Caveats:
  desktop-only, no README, fixed output names, incomplete item persistence,
  and some UI state is still prototype-grade.

### `SirSerl/VRFileManager`

- Interesting idea:
  represent the filesystem as physical objects placed on cabinet shelves, with
  file-type-specific prefabs and tools for copy, trash, preview, and move.
- Code donor value:
  strong conceptual donor after safety redesign: `FileBrowser` maps file
  extensions to prefabs, paginates shelves, supports search/sort by
  name/time/type/size, opens folders, moves dropped file objects into
  directories, and uses separate preview/copy/trash tools. `OpenPicture`
  loads image bytes into a sprite, `OpenAudio` loads file audio, and
  `CopyMachine` creates unique copies.
- Product reference value:
  excellent for "files as objects" VR UX, especially shelves, tool stations,
  previews, and drag/drop operations.
- What to inspect next:
  undo/confirmation model, safe trash instead of direct delete, path abstraction
  for non-Windows systems, and artifact cleanup.
- Caveats:
  destructive delete/move/copy operations, legacy Unity/SteamVR payload,
  checked-in vendor/artifact weight, Windows path assumptions, and no rollback.

### `agoetschm/vr_file_browser`

- Interesting idea:
  expand directories as nested world objects and collapse unfocused branches.
- Code donor value:
  useful minimal spatial browsing pattern: folder node stores `path`, opens by
  reading `DirectoryInfo.GetFileSystemInfos`, creates child nodes around the
  parent, includes a `..` parent entry, and `Global.SetFocus` destroys
  unrelated subobjects.
- Product reference value:
  good old-stack reference for "folder as spatial tree" interaction.
- What to inspect next:
  modern XR input, permission/error handling, preview mode, and persistence of
  navigation state.
- Caveats:
  GoogleVR-era project, experimental `Application.persistentDataPath` parent
  climbing, and little filesystem safety logic.

### `Vode1969/vr-file-browser`

- Interesting idea:
  provide a small in-VR file picker with extension filtering and controller-ray
  row selection.
- Code donor value:
  useful picker skeleton: starts from logical drives, hides system/hidden
  folders, keeps a path stack, scrolls folder and file windows, filters files
  by extension, stores selected paths on row colliders, and exposes an
  `execute()` hook for consuming the chosen file.
- Product reference value:
  strong reference for a narrow "pick one file in VR" utility rather than a
  complete file manager.
- What to inspect next:
  input abstraction, platform path providers, exception handling, richer file
  filters, and safe display of full paths.
- Caveats:
  Windows-centric drives, paths stored in GameObject names, keyboard
  placeholder input, and minimal permissions/errors.

### `hunterdquant/Seeker`

- Interesting idea:
  a Unity VR file browser intended for loading local files that are not inside
  the Unity project.
- Code donor value:
  none found in the inspected branch; README-only intent.
- Product reference value:
  useful demand signal for a recurring pain point: local files need a VR-native
  intake path.
- What to inspect next:
  whether another branch, release, or related project contains implementation.
- Caveats:
  no implementation evidence beyond README/LICENSE.

## Cross-Project Synthesis

The reusable file/asset browser boundary is:

1. locate or choose a root;
2. list folders/files safely;
3. filter and classify by type;
4. represent items as rows, world objects, shelves, or catalog records;
5. preview or import selected content;
6. isolate destructive operations behind confirmations, undo, or a recycle
   model;
7. persist tags/categories or recent paths separately from raw filesystem
   state.

`SirSerl/VRFileManager` is the strongest UX reference, but it should not be
copied without safety redesign. `Vode1969/vr-file-browser` is the cleanest
micro-picker reference. `VrmFileManager` gives a narrow runtime-import action
that could sit behind a browser. `VRC-Files-Manager` shows the companion
catalog side that a VR surface could consume later.

## Method/Catalog Actions

- Add a method for local file/asset browser pipelines across runtime import,
  metadata cataloging, spatial shelves, filtered pickers, and safe operations.
- Add a follow-up matrix for VR file/local asset browsers and permission gates.
- Place source-light `Seeker` as a demand signal rather than a donor.

## Follow-Up Backlog

- Compare local-file permission models across Unity desktop, Android/Quest, and
  browser/WebXR.
- Design a safe file-operation policy for VR file managers: preview, copy,
  move, delete, undo, and confirmation.
- Prototype a metadata-backed asset browser where desktop cataloging and VR
  selection are separate layers.
