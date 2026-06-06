# VR Projects Wave 219: VRChat External Content Ingress, Image/GLB/Texture, and Avatar Data Surfaces

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-219-plan.md`
- `docs/research/program/github-research-wave-219-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

VRChat utilities frequently need content that is not baked into the world at
upload time. The reusable challenge is not only "download a thing", but how to
route external data into material textures, UI images, model hierarchies,
synced texture channels, persisted URL inputs, or avatar-thumbnail data
carriers while documenting platform/runtime limits.

## Project Findings

### `vrchat-community/examples-image-loading`

- Interesting idea: the official example demonstrates the minimal reliable
  remote image surface: keep a `VRCImageDownloader` alive, load captions via
  `VRCStringDownloader`, cache downloaded textures, choose the current slide
  from shared server time, and host content through GitHub Pages.
- Code donor value: high as a minimal baseline. `SlideshowFrame.cs` stores
  image URLs, caption URL, renderer, text field, slide duration,
  `_downloadedTextures`, persistent `VRCImageDownloader`, and
  `IUdonEventReceiver`. It downloads captions once, caches images after first
  load, applies textures to the material, updates captions, and disposes the
  downloader on destroy.
- Product reference value: high for simple galleries, notice boards, and
  slideshow surfaces.
- Architecture pattern: URL list plus downloader lifetime plus texture cache
  plus material/UI output plus shared-time selection.
- Reusable method: keep downloader ownership explicit and cache textures rather
  than redownloading every display cycle.
- Constraints and caveats: first-image caption timing issue, simple error
  handling, static URL list, and no user-entered URL/persistence UX.
- What to inspect next: modern SDK version, URL validation, and gallery manager
  UX.
- Why it matters for `VR-apps-lab`: it is the clean baseline for URL image
  ingestion.

#### Reusable Pattern Extraction

- Pattern candidate: VRChat external content ingress pipeline for image, model,
  texture, and avatar-data surfaces.
- Problem solved: worlds need externally updated content while Udon restricts
  file access, arbitrary decoding, runtime networking, and asset mutation.
- Reusable core: ingress source, downloader/parser/sync mechanism, cached
  runtime data, output surface, error/loading state, ownership/persistence
  policy, callback/progress events, and platform/runtime caveats.
- Source evidence: `SlideshowFrame.cs`, `GLBLoader.cs`,
  `LitePictureDownloader.cs`, `PictureLoaderURLInput.cs`,
  `SyncTexture.cs`, `SyncTexture2D.cs`, `SyncTextureManager.cs`,
  `RuntimeDecoder.cs`, and `AvatarImageEncoder.cs`.
- Abstraction boundary: URL download, model parse, synced texture chunks,
  avatar-image data carrier, UI/product controls, and persistence should stay
  separable.
- What not to copy: deprecated avatar-image workflows as a default path,
  unbounded user URL entry, GLB feature claims beyond implemented subsets, or
  texture chunk sizes without platform review.
- Method catalog action: create Method 664.

### `vr-voyage/vrchat-glb-loader`

- Interesting idea: a VRChat world can reconstruct GLB/VRM content at runtime
  by downloading serialized GLB data and parsing JSON, buffers, accessors,
  meshes, materials, textures, scenes, and material extensions with Udon data
  structures.
- Code donor value: very high for runtime parser architecture. `GLBLoader.cs`
  maintains parse state, GLB bytes, JSON raw text, `DataDictionary`/`DataList`
  structures, buffers/accessors/materials/textures/images/samplers/meshes/nodes
  arrays, material extension handlers, stats, and parse-state functions for
  main data, JSON, asset data, buffer views, accessors, images, samplers,
  textures, materials, meshes, nodes, scenes, and VRM metadata. It uses
  `VRCStringDownloader.LoadUrl`, DDS/preconverted texture parsing, and
  extension handling.
- Product reference value: very high for dynamic model display and
  user-supplied asset worlds.
- Architecture pattern: staged parser/reconstructor plus extension handlers
  plus prefab hierarchy output.
- Reusable method: represent unsupported runtime asset formats as explicit
  staged parse states with capability/caveat reporting.
- Constraints and caveats: textures require preconversion, bones/armatures,
  animations, blendshapes, cameras, and lights are not supported, and Udon
  parsing/performance constraints are significant.
- What to inspect next: UI panel, hierarchy manager, DDS reader, material
  extension implementations, and companion texture converters.
- Why it matters for `VR-apps-lab`: it is a strong dynamic content-loader
  donor with honest limitations.

### `DrBlackRat/VRC-Picture-Loader`

- Interesting idea: image ingress becomes a product when the package provides
  manager, lite downloader, URL input, persistence, tablet, texture settings,
  loading/error textures, light/dark UI, and setup menu.
- Code donor value: high. `PictureLoaderManager.cs` coordinates many
  downloaders, counts loaded/errors, updates status UI, supports load-on-start,
  manual load, auto reload, disabled UI, and delayed reload. `LitePictureDownloader.cs`
  owns `VRCImageDownloader`, old-loader disposal, `TextureInfo` settings,
  material property and `RawImage` application, aspect-ratio updates,
  loading/error textures, auto reload, and callbacks to URL input.
  `PictureLoaderURLInput.cs` owns lock state, network-synced URL, ownership
  request checks, UI text, persistence reference, saved URL loading, retry
  scheduling, and downloader coordination.
- Product reference value: very high for user-facing VRChat image surfaces.
- Architecture pattern: manager/lite downloader/url input/persistence/tablet
  modes over a shared image-download core.
- Reusable method: separate minimal downloader from multi-surface manager,
  user URL entry, persistence, and portable/tablet UX.
- Constraints and caveats: user URL trust, persistence authority mode,
  VRChat-specific UI and packages, and many prefab references.
- What to inspect next: `PictureLoaderPersistence`, tablet rotation/menu, and
  setup editor scripts.
- Why it matters for `VR-apps-lab`: it is the strongest product UX reference
  for image ingress.

### `Narazaka/SyncTexture`

- Interesting idea: Texture2D data can be synchronized through chunked encoded
  color data with progress, callbacks, manager sequencing, resend behavior, and
  late-join support.
- Code donor value: very high for constrained runtime data transfer.
  `SyncTexture.cs` owns `BulkCount`, `SyncInterval`, progress, synced index,
  prepare/cancel/force start, callback events, chunk serialization, partial
  receive application, and send/receive completion. `SyncTexture2D.cs` reads
  the source texture through `VRCAsyncGPUReadback` or chunked `GetPixels`,
  stores source colors, and applies full or partial receive colors to the
  target texture. `SyncTextureManager.cs` sequences multiple textures, supports
  resend, cancel, and ownership-transfer restart.
- Product reference value: high for shared whiteboards, generated images,
  avatar/world state snapshots, and texture-as-data channels.
- Architecture pattern: chunked texture sender/receiver plus manager plus
  callbacks plus color encoders.
- Reusable method: expose sync progress and callbacks so consumers can show
  partial receive state instead of blocking on a whole texture.
- Constraints and caveats: bandwidth/serialization cost, chunk size tuning,
  GPU readback availability, texture size, and VRChat sync limits.
- What to inspect next: color encoder variants, late-join behavior, and sample
  scenes.
- Why it matters for `VR-apps-lab`: it generalizes "surface as data bus" beyond
  audio shaders.

### `Miner28/AvatarImageReader`

- Interesting idea: before modern string loading, avatar thumbnail images could
  carry encoded text/data into a world by reading avatar pedestal textures at
  runtime and decoding bytes from pixels.
- Code donor value: high as historical workaround and data-carrier pattern.
  `AvatarImageEncoder.cs` converts UTF-8/UTF-16 text to bytes, slices data
  across available avatars, writes a 7-pixel header with length, next avatar
  ID, version, and data mode, and generates RGBA images. `RuntimeDecoder.cs`
  waits for the avatar pedestal clone and `_WorldTex`, copies the render
  texture into a `Texture2D`, reads header/data bytes, queues next avatar load
  when chained, and decodes UTF-8/UTF-16 incrementally across frames before
  writing `outputString`, TMP output, or callback events.
- Product reference value: medium-high as a deprecated but clever ingress
  pattern.
- Architecture pattern: editor encoder plus runtime pedestal texture reader
  plus multi-avatar data chain plus frame-sliced decoder.
- Reusable method: when runtime IO is constrained, encode data into allowed
  visual carriers and provide clear capacity/platform limits.
- Constraints and caveats: README marks it deprecated in favor of string
  loading, requires avatar/pedestal setup, depends on VRChat rendering
  behavior, and Quest capacity is much smaller than PC.
- What to inspect next: migration path to string loading, build checks, and
  multi-avatar manager.
- Why it matters for `VR-apps-lab`: it preserves a historically important
  workaround and highlights deprecation discipline.

## Cross-Project Lessons

- External content ingress should name its source, carrier, parser/sync layer,
  output surface, authority/persistence policy, and platform limits.
- Minimal official samples are useful baselines; productized packages add
  manager state, URL input, persistence, error/loading UI, and portable tablet
  UX.
- Runtime model loading should document unsupported asset features as first
  class caveats.
- Texture synchronization and avatar-image encoding show that pixel channels
  can become data buses, but capacity and runtime costs must be explicit.
- Deprecated workarounds still matter when they explain why newer APIs are
  preferable.

## Method Catalog Actions

- Added Method 664: VRChat external content ingress pipeline for image, model,
  texture, and avatar-data surfaces.

## Follow-Up Gaps

- Build a VRChat content-ingress matrix across URL image, string loading,
  picture manager, GLB loader, synced texture, avatar image, and shader data
  buses.
- Compare external content authority: static URL list, user URL input,
  instance owner, network master, persistence, synced chunks, and avatar-owned
  data.
- Revisit prior Udon encoding/string-loading research and mark
  `AvatarImageReader` as deprecated but historically important.
