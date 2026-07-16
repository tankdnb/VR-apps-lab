# Wave 469: WebXR VRM avatar optimization and companion viewer microtools

- Date: `2026-07-16`
- Scope: browser VRM avatar utilities that optimize WebGL/VRM assets, preview
  avatars, persist avatar libraries, map VRMA animations, and provide asset
  registry metadata for reusable XR avatar tools.

## Shortlist

| Project | Status | Why it belongs |
|---|---|---|
| `WebXR-JP/avatar-optimizer` | Studied | Monorepo for VRM/MToon optimization, texture compression, atlas material, and debug viewer |
| `chrisdubya/vrm-webxr` | Studied | Minimal React/Three/WebXR VRM loading baseline |
| `royalkingjoey/YumeVRM` | Studied | Browser VRM companion with saved avatar library, VRMA actions, speech/lip-sync, and settings persistence |
| `ToxSam/open-source-avatars` | Studied as registry/reference | VRM avatar metadata registry with license/project indirection and Mixamo/VRM 0.x notes |
| `pixiv/three-vrm` | Existing overlap reference | Already studied core VRM runtime and loader |

## Project notes

### `WebXR-JP/avatar-optimizer`

- Interesting idea: treat WebXR avatar performance as an asset pipeline problem:
  combine MToon materials, atlas textures, compress to KTX2, and validate via
  a dedicated debug viewer.
- Code donor value: high conceptually; the package split is more valuable than
  any one implementation detail.
- Product reference value: high for future avatar viewers, social utilities,
  and WebXR scenes that need predictable draw-call/texture budgets.
- Source evidence: `packages/avatar-optimizer`, `packages/mtoon-atlas`,
  `packages/texture-compression`, `packages/debug-viewer`, implementation
  docs, and tests.
- Reusable core: optimizer package, MToon atlas material, packed parameter
  texture layout, KTX2/Basis compression wrapper, debug viewer, Spector hooks,
  skeleton/springbone helpers, and roundtrip tests.
- What not to copy: bundled WASM without license review, sample VRM artifacts,
  Japanese-only operational notes without translation, and shader assumptions
  without visual regression tests.
- What to inspect next: exact optimizer pipeline and how it reports before/after
  draw calls, texture count, file size, and visual differences.

### `chrisdubya/vrm-webxr`

- Interesting idea: a tiny React Three Fiber baseline for loading a VRM avatar
  into a WebXR-capable scene.
- Code donor value: medium; `src/Avatar.tsx` is compact evidence for the
  minimum loader/runtime loop.
- Product reference value: medium as a small baseline to compare against larger
  avatar companion apps.
- Source evidence: `README.md`, `src/Avatar.tsx`, `package.json`, and WebXR
  HTTPS note.
- Reusable core: `GLTFLoader`, `VRMLoaderPlugin`, `VRMUtils`, VRM0 rotation,
  unnecessary joint removal, and per-frame `vrm.update(delta)`.
- What not to copy: minimal UI, no asset provenance model, no performance
  diagnostics, and no avatar library state.
- What to inspect next: whether a small VRM preview component belongs beside
  the splat/point-cloud preview methods.

### `royalkingjoey/YumeVRM`

- Interesting idea: a browser avatar companion app that combines VRM loading,
  saved local libraries, VRMA actions, idle/gaze/rest-pose behavior, speech,
  lip-sync, and settings persistence.
- Code donor value: medium to high as a product-shell reference; it is more
  valuable for state/lifecycle design than for direct code reuse.
- Product reference value: high for companion/avatar-facing VR tools.
- Source evidence: `README.md`, `src/app.ts`, `src/vrm/vrmLoader.ts`,
  `src/vrm/vrmaLoader.ts`, `src/vrm/restPose.ts`, `src/storage/*`,
  `vite.config.ts`, and UI overlay code.
- Reusable core: saved avatar library, background/font persistence,
  file-backed dev API, VRMA upload/preview, rest-pose adjustment, idle/gaze
  behavior, action/emotion tags, speech playback hooks, and reset view.
- What not to copy: API-key handling assumptions, companion personality prompt,
  project-specific assets, and local-file persistence without security labels.
- What to inspect next: separating avatar runtime, user library, animation
  library, speech/lip-sync, and UI settings into provider-neutral modules.

### `ToxSam/open-source-avatars`

- Interesting idea: a metadata-first registry for free VRM avatars that keeps
  project licenses, avatar files, thumbnails, alternate FBX links, and VRM
  format caveats out of the viewer runtime.
- Code donor value: medium; the schema and docs are the reusable part.
- Product reference value: high for any sample viewer that needs legally
  traceable test avatars.
- Source evidence: `AGENTS.md`, `docs/api-reference.md`,
  `docs/avatar-format.md`, `data/projects.json`, `data/avatars/*.json`, and
  `integrations/mixamo-rig-map.*`.
- Reusable core: collection index, per-project license, per-avatar
  `model_file_url`, thumbnail, metadata, optional FBX alternate, rig-map
  reference, and VRM 0.x versus 1.0 caveats.
- What not to copy: assuming every listed avatar is performance-safe, treating
  project-level license as per-avatar validation, or using VRM 0.x animation
  helpers on VRM 1.0 without adaptation.
- What to inspect next: asset provenance labels for future sample scenes.

## Reusable pattern extraction

- Pattern candidate: `Avatar asset pipeline with optimizer, previewer, and
  provenance registry`.
- Problem solved: avatar utilities need more than a loader; they need asset
  provenance, performance budgets, animation compatibility, persistence, and
  viewer diagnostics.
- Reusable core: avatar registry, license/project indirection, loader plugin,
  runtime update loop, optimizer pipeline, material/texture atlas, texture
  compression, debug viewer, saved library, animation library, rest-pose/idle
  behavior, and visible performance/provenance labels.
- Source evidence: `avatar-optimizer/packages/*`, `vrm-webxr/src/Avatar.tsx`,
  `YumeVRM/src/app.ts`, `YumeVRM/src/vrm/*`, and
  `open-source-avatars/docs/api-reference.md`.
- Abstraction boundary: keep asset registry, optimization, avatar runtime,
  animation runtime, and companion UI separate.
- What not to copy: sample avatars without license review, WASM/shader code
  without provenance, cloud API assumptions, and unbounded avatar complexity
  without runtime budgets.
- Method catalog action: add `Method 914`.

## Why this matters for VR-apps-lab

The repo already tracks VRM runtimes and mocap bridges. This wave adds the
missing utility layer around avatar asset intake, optimization, persistence,
and preview diagnostics.

