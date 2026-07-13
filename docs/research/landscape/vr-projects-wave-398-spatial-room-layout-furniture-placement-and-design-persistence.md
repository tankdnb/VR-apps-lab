# Wave 398: Spatial Room Layout, Furniture Placement, and Design Persistence

- Date: `2026-07-13`
- Scope: code-level reading pass only; no builds, installs, launches, or device
  tests.

## Theme

This wave studies spatial room-design apps as utility references for anchored
object placement, room reconstruction, layout save/load, material changes, and
catalog-driven model intake.

## Shortlist

| Repository | Status | Family placement |
|---|---|---|
| `TeamFWS/room-designer` | Studied | MR room layout and persistence |
| `pnlt/VNE5T-SolutionForAVR` | Studied | VR interior-design product reference |
| `lakshmikosre/Elite-In-Decora` | Studied lightly | AR interior-design requirements/reference |

## Findings

### `TeamFWS/room-designer`

- Interesting idea: combine Quest MR room import with manual room creation,
  furniture placement, wall painting, IKEA model fetching, and persistent
  anchored layouts.
- Code donor value: `MRInitialization`, `RaySpawner`,
  `FurnitureManipulator`, `RoomLayoutManager`, `MRAnchoredLayoutData`,
  `SaveDataSerializer`, `IkeaModelLoader`, and manual grid room scripts.
- Product reference value: strong utility pattern for "place object in room,
  anchor it, save it, reload it, and explain failures".
- What to inspect next: anchor lifecycle, localization failures, model cache
  invalidation, layout migration, and provider/legal caveats for product model
  scraping.
- Caveat: asset/vendor-heavy Meta XR project; best donor is the layout schema
  and anchor/save flow.

### `pnlt/VNE5T-SolutionForAVR`

- Interesting idea: frame VR interior design as a product workspace with object
  manipulation, material swapping, measurement, annotations, snapshots, export,
  and AI recommendations.
- Code donor value: Unity project structure, Quest/URP/Meta XR assumptions, UI
  and interaction framing, and public-facing feature taxonomy.
- Product reference value: useful as a product-scope checklist for future
  spatial authoring utilities.
- What to inspect next: whether claimed measurement/annotation/export/AI
  systems exist as code, and which parts are prototype framing only.
- Caveat: academic/research-only notice and broad claims; treat as product
  reference more than code donor until deeper validation.

### `lakshmikosre/Elite-In-Decora`

- Interesting idea: AR interior design requirements around catalog, gallery,
  cart, product recommendation, room photos, and AR placement.
- Code donor value: Android/app structure is thin for VR reuse, but diagrams
  and requirements capture commerce/catalog constraints.
- Product reference value: useful to separate design utility features from
  shopping/product-data features.
- What to inspect next: ARCore integration depth, object placement code, and
  whether catalog APIs are implemented or only specified.
- Caveat: not a VR donor; keep as lightweight requirements/reference node.

## Reusable Pattern Extraction

- Pattern candidate: `anchored spatial layout persistence`.
- Problem solved: spatial utilities need object catalogs, placement previews,
  anchors, manipulation, material changes, and durable layout state.
- Reusable core: room source, scene labels, placement ray, preview object,
  furniture record, anchor UUID, relative transform, model cache key, layout
  JSON, save/load service, localization failure UI, material/paint tool, and
  export/snapshot affordance.
- Source evidence: Room Designer's MRUK/OVR anchor pipeline and layout
  serializer, VNE5T's interior-design feature taxonomy, and Elite-In-Decora's
  catalog/commerce requirements.
- Abstraction boundary: keep anchor persistence separate from model loading and
  keep product catalog data separate from the spatial layout document.
- What not to copy: scraped model URLs without provenance, broad AI claims,
  shopping/cart flows unless the utility actually needs commerce, or anchors
  without recovery UI.
- Method catalog action: add Method 843.
