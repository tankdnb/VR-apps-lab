# VR Projects Wave 174: Spatial Anchors, Shared Scenes, Magic Leap Persistence, and Colocation

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 174 studies spatial-anchor and colocation samples across Meta Unreal and
Magic Leap Unity/ARFoundation. The focus is reusable structure: anchor menus,
persistence state, shared scene reconstruction, localization gating, storage
callbacks, and anchor-to-content bindings.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `oculus-samples/Unreal-SpatialAnchorsSample` | Source-light Unreal spatial anchor baseline | Product/setup reference |
| `oculus-samples/Unreal-SharedAnchorsSample` | Shared-anchor UX donor | Strong menu/state reference |
| `oculus-samples/Unreal-SharedSceneSample` | Anchor-relative shared scene donor | Strong architecture reference |
| `magicleap/SpatialAnchorsExample` | Magic Leap persistence donor | Strong manager/storage donor |
| `dilmerv/MagicLeapSpatialAnchors` | Magic Leap anchor storage lifecycle donor | Strong compact lifecycle donor |

## `oculus-samples/Unreal-SpatialAnchorsSample`

- Interesting idea:
  provide the minimal Meta Unreal spatial anchor baseline as a Blueprint/content
  sample and developer setup reference.
- Code donor value:
  low-medium because the public project is mostly Blueprint/content and does
  not expose much C++ implementation.
- Product reference value:
  medium for sample packaging, project prerequisites, and spatial-anchor setup
  expectations in Unreal.
- What to inspect next:
  inspect Blueprint assets in-editor only if an Unreal anchor prototype becomes
  active work.
- Source evidence:
  README, project structure, content folders, and lack of substantial `Source`
  implementation.
- Reusable pattern extraction:
  source-light baseline for Meta Unreal spatial-anchor sample packaging.
- Reusable core:
  keep as a setup/context reference rather than a code donor.
- Do not copy directly:
  Blueprint-only behavior that has not been inspected in-editor.
- Caveats:
  not a strong source-level donor in static text/code reading.

## `oculus-samples/Unreal-SharedAnchorsSample`

- Interesting idea:
  expose shared anchor operations through stateful Unreal menus: create,
  select, load, save locally, save to cloud, hide/unsave/erase, orient to
  anchor, and share anchors in a LAN session context.
- Code donor value:
  medium for menu/action structure and module dependencies; lower for direct
  code because most behavior is Blueprint-driven.
- Product reference value:
  high for anchor action UX and local/cloud persistence state transitions.
- What to inspect next:
  map Blueprint menu state transitions into a generic anchor action menu
  checklist.
- Source evidence:
  README descriptions of `BP_MenuItem`, `BP_Menu_Main`, `BP_Menu_Anchor`,
  shared scene flow, LAN sessions, and `SharedAnchorsSample.Build.cs` module
  dependencies.
- Reusable pattern extraction:
  stateful shared-anchor action menu with local/cloud persistence states.
- Reusable core:
  separate create/select/load menu actions from selected-anchor actions, change
  menu options based on local/cloud state, support orient-to-anchor, and keep
  network session context explicit.
- Do not copy directly:
  Blueprint assumptions or Meta-specific cloud behavior into generic anchor
  utilities.
- Caveats:
  strongest as UX/state reference rather than text-source donor.

## `oculus-samples/Unreal-SharedSceneSample`

- Interesting idea:
  share a spatial anchor first, then serialize scene reconstruction data
  relative to that anchor so clients can reconstruct static mesh actors and
  semantic labels in a colocated multiplayer scene.
- Code donor value:
  medium-high for data-model and flow; Blueprint-heavy but architecturally
  clear.
- Product reference value:
  high for shared scene/colocation tooling and anchor-relative serialization.
- What to inspect next:
  compare anchor-relative scene records with marker-relative calibration and
  replayable scene snapshots from other families.
- Source evidence:
  README categories for UI, Spatial Anchors Management, Scene Reconstruction,
  `BP_MenuManagerComponent`, `BP_SpacialAnchorManagementComponent`,
  `NetMulticast_LoadScene`, shared anchor ID, semantic labels, relative
  transforms, static mesh references, and `SharedSceneSampleBPLibrary.cpp`.
- Reusable pattern extraction:
  anchor-relative shared scene serialization and reconstruction.
- Reusable core:
  gate long operations through async start/end UI utilities, share the anchor
  before sharing scene data, store object transforms relative to the shared
  anchor, include semantic labels and mesh references, multicast scene load
  data, and expose visibility toggles by semantic label.
- Do not copy directly:
  sample-only network assumptions or typoed/internal Blueprint names as API
  conventions.
- Caveats:
  Blueprint-heavy; implementation details require future in-editor inspection.

## `magicleap/SpatialAnchorsExample`

- Interesting idea:
  manage Magic Leap 2 persistent anchors through localization events, anchor
  events, background query workers, local JSON bindings, and an in-app Space
  selector.
- Code donor value:
  high for anchor manager state, localization-gated querying, binding storage,
  thread dispatch, persistent content restore, and Space selection UI.
- Product reference value:
  high for vendor anchor tools that need to teach users why localization,
  spaces, anchor IDs, and object bindings matter.
- What to inspect next:
  compare its binding storage abstraction with Meta local/cloud UUID storage
  patterns.
- Source evidence:
  `AnchorManager.cs`, `PersistentContentExample.cs`,
  `BindingsLocalStorage.cs`, `ThreadDispatcher.cs`, and `SpaceSelector.cs`.
- Reusable pattern extraction:
  localization-gated spatial anchor persistence with binding storage and
  worker-thread queries.
- Reusable core:
  listen for localization and anchor events, clear/reload anchors on space
  changes, query only when localized and head pose is valid, dispatch worker
  work back to the main thread, bind content metadata to anchor IDs in local
  JSON storage, and provide an in-app Space list/status selector.
- Do not copy directly:
  Magic Leap-only APIs or storage paths into portable utilities.
- Caveats:
  vendor-specific but very useful as a manager/state reference.

## `dilmerv/MagicLeapSpatialAnchors`

- Interesting idea:
  provide a compact ARFoundation/OpenXR Spatial Anchors Storage API lifecycle:
  create anchor, publish to storage, query around controller, instantiate from
  storage, delete, and display anchor confidence/status.
- Code donor value:
  high for publish/query/delete callback flow, local/stored anchor lists,
  status panel, and confidence UI.
- Product reference value:
  high for anchor utility tooling and developer-facing diagnostics.
- What to inspect next:
  account for the known anchor duplication issue before treating the flow as a
  reusable baseline.
- Source evidence:
  `AnchorCreator.cs`, `AnchorControlPanel.cs`, `AnchorState.cs`, and README
  notes about OpenXR Spatial Anchors API and Storage API.
- Reusable pattern extraction:
  ARFoundation/OpenXR Storage API anchor lifecycle with visible status UI.
- Reusable core:
  wait for the anchor subsystem, create anchors from controller input, publish
  once tracking is ready, maintain local and stored anchor records, handle
  query/creation/publish/delete callbacks, show restore/clear controls, and
  display pose/confidence/tracking state near each anchor.
- Do not copy directly:
  sample duplication behavior without mitigation.
- Caveats:
  known duplication issue and Magic Leap-specific storage feature.

## Cross-Project Lessons

- Anchor utilities need UX around state, not just API calls: created, selected,
  saved local, saved cloud/storage, shared, localized, queried, hidden, erased,
  and failed all need visible states.
- Shared scene reconstruction should store transforms relative to a stable
  anchor rather than assuming global coordinates.
- Vendor anchor stacks repeatedly need localization readiness, query cadence,
  persistent bindings, and status surfaces.
- Blueprint-heavy official samples can still be valuable if they expose a clear
  user-flow or data-model lesson.
- Spatial-anchor work belongs in the repository as reusable colocation and
  persistence knowledge, not as a single platform-specific app goal.
