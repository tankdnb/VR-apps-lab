# VR Projects Wave 162: Resonite Creator Import/Export, Inspection, and Screenshot Utility Helpers

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 162 deepens the Resonite branch from runtime modding into creator-facing
workflows: Unity editor SDKs, Unity-to-Resonite exporters, `.unitypackage`
importers, component selection/search UX, and screenshot metadata preservation.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `Yellow-Dog-Man/Resonite.UnitySDK` | Resonite creator SDKs | Strong architecture donor |
| `Phylliida/ResoniteUnityExporter` | Unity-to-Resonite exporters | Strong pipeline donor |
| `dfgHiatus/ResoniteUnityPackagesImporter` | Unity package importers | Strong import/cache reference |
| `BlueCyro/CherryPick` | In-world/editor inspection QoL mods | Strong micro-UX donor |
| `hantabaru1014/ResoniteScreenshotExtensions` | Screenshot metadata and sharing utilities | Strong metadata utility donor |

## `Yellow-Dog-Man/Resonite.UnitySDK`

- Interesting idea:
  let Unity Editor become a Resonite content authoring surface through
  ResoniteLink, generated bindings, converters, and realtime scene sending.
- Code donor value:
  high. The generated binding/converter architecture is a strong data-model
  bridge reference.
- Product reference value:
  high. It frames creator onboarding, beta limitations, issue taxonomy, and
  extensible converter contribution paths clearly.
- What to inspect next:
  compare generated bindings and converters against other engine-to-social-VR
  bridges before designing any generic asset bridge.
- Architecture pattern:
  ResoniteLink exposes scene hierarchy, components, fields, and asset import
  operations. A bindings generator connects to Resonite, walks component/type
  definitions, emits Unity-side binding shells, maps primitives to Unity types,
  generates wrappers for components, and keeps generated files version-stamped.
  Converter systems then map Unity components/materials into Resonite bindings
  and support realtime updates from the editor.
- Reusable method:
  generated data-model bindings plus converter registry for cross-engine
  creator tooling.
- Caveats:
  beta state, frequent breakage warning, incomplete conversion coverage, and
  ResoniteLink dependency.

## `Phylliida/ResoniteUnityExporter`

- Interesting idea:
  avoid intermediate file limits by sending raw Unity mesh/material/bone/etc.
  data through IPC to Resonite-side import processors.
- Code donor value:
  high. It has a clear split between Unity package, shared DTOs, import library,
  mod, standalone server, and bridge library.
- Product reference value:
  high for creator workflow design: package manager install, window UI,
  standalone mode, mod mode, material mappings, and avatar/world support list.
- What to inspect next:
  compare memory-mapped IPC and processor registration with ResoniteLink's
  higher-level data-model approach.
- Architecture pattern:
  Unity gathers scene/avatar data into shared DTOs. `ResoniteBridgeLib` handles
  IPC/serialization. `ImportFromUnityLib` registers named processors such as
  `ImportSlotHierarchy`, `ImportToStaticMesh`, `ImportToTexture2D`,
  `ImportAvatar`, material, dynamic bone, constraint, and package creation
  handlers. A Resonite mod imports directly into the focused world, while a
  standalone server loads Resonite libraries to create `.resonitepackage`
  output.
- Reusable method:
  shared DTO plus named IPC processor pipeline for engine-to-social-VR content
  export.
- Caveats:
  Resonite libraries and mod/standalone setup are heavy, Linux support is a
  todo, and several asset categories are incomplete.

## `dfgHiatus/ResoniteUnityPackagesImporter`

- Interesting idea:
  treat `.unitypackage` files as importable Resonite content with extraction,
  cache reuse, asset-type toggles, and alpha prefab/scene reconstruction.
- Code donor value:
  high for import/cache/material mapping details.
- Product reference value:
  medium-high for "drop a Unity package into a social VR platform" workflows.
- What to inspect next:
  compare package extraction cache and material/texture mapping against Unity
  SDK converters and general asset import helpers.
- Architecture pattern:
  a ResoniteModLoader mod patches import extension support for
  `.unitypackage`, hashes packages into a cache, unpacks each Unity asset
  directory while preserving paths, can skip already imported package contents,
  exposes settings for raw files, prefabs, text, textures, documents, meshes,
  point clouds, audio, fonts, and videos, and maps material texture slots into
  Resonite material components.
- Reusable method:
  package extraction cache plus configurable asset-type import pipeline.
- Caveats:
  large packages can hang, prefab/scene support is alpha, Unicode filename
  constraints exist, and some Unity systems such as animation/physbones are not
  imported.

## `BlueCyro/CherryPick`

- Interesting idea:
  add immediate search and generic typing to Resonite's component selector
  rather than forcing users through category browsing.
- Code donor value:
  medium-high. The UI patch and cache/ranking logic are small and focused.
- Product reference value:
  high for creator QoL micro-utility framing.
- What to inspect next:
  compare search ranking, scope filtering, and generic type handling with other
  component/search palettes.
- Architecture pattern:
  a Harmony patch replaces/augments `ComponentSelector.SetupUI`, builds a
  search field above the normal browser, creates overlapping normal/search
  roots, caches worker/component metadata after engine initialization, ranks
  results by case-insensitive match ratio, scopes by category path, limits
  result count, supports single-click/double-click behavior, hides ProtoFlux by
  config, and constructs generic component type buttons through type parsing.
- Reusable method:
  in-world component palette search overlay with cached worker metadata and
  generic-type selection.
- Caveats:
  Resonite UI internals and Harmony patches may be brittle, and the method is
  platform-specific to Resonite-style component browsers.

## `hantabaru1014/ResoniteScreenshotExtensions`

- Interesting idea:
  make screenshots portable artifacts by embedding Resonite photo metadata as
  XMP and restoring it when the image is imported later.
- Code donor value:
  high for metadata serialization, restore-on-import, and sharing hooks.
- Product reference value:
  high. It turns a screenshot into a context-rich social artifact with folder
  organization, format options, and optional Discord sharing.
- What to inspect next:
  compare this to VRChat camera/path tools and mixed-reality capture metadata
  needs.
- Architecture pattern:
  patches screenshot save/import flows, collects `PhotoMetadata`, serializes
  location, host, users, camera, FOV, stereo, pose, scale, app version, and time
  into namespaced XMP, upserts metadata into JPEG/WEBP/PNG output, restores
  metadata into imported images, supports legacy JSON graph loading, offers
  format/folder settings, and can generate a "Post to Discord" menu item or
  auto-upload with selected embed fields.
- Reusable method:
  screenshot metadata preservation with XMP round-trip and optional sharing
  workflow.
- Caveats:
  metadata privacy needs care, Discord webhook settings are sensitive, and image
  format/library dependencies should be isolated in any reuse.

## Cross-Project Lessons

- Creator tooling needs both data-model bridges and user-facing recovery paths
  for unsupported content.
- Generated bindings are powerful when the target platform exposes a stable
  component/type definition API.
- Small creator QoL tools such as search palettes can be as reusable as large
  importers because they reduce in-headset authoring friction.
- Metadata-rich screenshots are a reusable pattern for diagnostics, social
  sharing, world provenance, and capture workflows.

## Reusable Methods Extracted

- Generated data-model bindings plus converter registry.
- Shared DTO and named IPC processor content-export pipeline.
- Unity package extraction cache and asset-type import switches.
- In-world component palette search overlay.
- Screenshot metadata XMP round-trip with restore-on-import.

## Follow-Up Backlog

- Build a creator import/export comparison across Resonite SDK, Unity exporter,
  Unity package importer, VRChat SDK tools, and generic asset converters.
- Extract a binding/converter checklist that separates data-model discovery,
  primitive mapping, wrapper generation, and converter registration.
- Compare photo/screenshot metadata approaches across social VR and mixed
  reality capture utilities.
