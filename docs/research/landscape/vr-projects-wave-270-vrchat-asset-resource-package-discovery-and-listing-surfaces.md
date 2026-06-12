# Wave 270 - VRChat Asset, Resource, Package Discovery, and Listing Surfaces

This wave studies VRChat creator discovery surfaces: static asset indexes,
resource websites, graph browsers, A-Frame DAM browsers, VPM package listings,
package templates, and one false-positive repository that should not be
treated as VR research.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- VRChat asset/resource catalog UIs;
- package listing and public landing-page UX;
- Unity editor/world utility resource packs;
- visual graph/resource discovery surfaces;
- source and security caveats for non-fit search results.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `vanquish3r/vrchat-asset-browser` | Static VRChat asset index | Studied | Search/filter/sort over community asset JSON |
| `marklibert404-eng/Obelisk` | Rejected false positive | Non-fit/security caveat | Browser VPN extension, not VRChat asset tooling |
| `Fraxul/VRChatResources` | VRChat editor/Udon microtools | Studied | Scene visibility, prefab cleanup, player counter, manual occlusion |
| `dark-swordsman/VRCRW` | VRChat resource graph website | Studied | Next/Prisma resource cards plus Pixi graph view |
| `tiry/nuxeo-vr-assets-browser` | A-Frame DAM asset browser | Studied | VR asset grid backed by Nuxeo document API |
| `ElMoha943/valenvrc_package_listing` | VPM package listing | Studied | GitHub Actions publication and multi-package listing |
| `Purpzie/vpm` | VPM package listing UX | Studied | Generated landing page, Add-to-VCC links, package modal |
| `Limitex/vrchat-package-template` | VRChat package template | Studied with caveats | VPM-ready package skeleton and asmdef/package metadata |

## Code-Level Findings

### `vanquish3r/vrchat-asset-browser`

- Interesting idea:
  a fully static, searchable VRChat free asset database.
- Code donor value:
  useful for static catalog UX: fetch JSON, normalize fields, derive category
  filters, search by name/author/description, sort by name/date, render cards,
  linkify notes, preview links, theme persistence, and back-to-top navigation.
- Product reference value:
  strong for public knowledge-base UX that can be hosted cheaply.
- What to inspect next:
  data provenance, schema validation, link checking, license display, and
  update workflow from community sheets.
- Caveats:
  AI-generated site code and compiled public data require careful license and
  attribution handling.

### `marklibert404-eng/Obelisk`

- Interesting idea:
  none for this repo's VRChat/VR asset scope.
- Code donor value:
  none for `VR-apps-lab`. It is a browser VPN/proxy extension with remote
  content injection behavior.
- Product reference value:
  only as a false-positive and security hygiene reminder.
- What to inspect next:
  nothing for VR research unless a separate VR-relevant branch exists.
- Caveats:
  not VR/VRChat asset tooling; includes proxy permissions, all-URL access,
  remote content code loading, and should not be promoted as a VR donor.

### `Fraxul/VRChatResources`

- Interesting idea:
  a compact bag of VRChat creator/editor scripts that solve real world-authoring
  pain points.
- Code donor value:
  strong for Unity editor utilities: recursive scene selection, visibility
  filters, collision proxy visualization, GPU instancing conflict/opportunity
  scans, prefab static-flag batch edits, transform/scale repair, player
  trigger occupancy tracking, and manual occlusion volume toggles.
- Product reference value:
  good reference for small creator QoL tools that do not need a large app.
- What to inspect next:
  menu organization, Undo coverage, VPM packaging, and Udon ownership/network
  assumptions.
- Caveats:
  loose scripts rather than a polished package; Udon scripts require
  UdonSharp/VRChat SDK review.

### `dark-swordsman/VRCRW`

- Interesting idea:
  present VRChat resources both as cards and as a graph of related resources.
- Code donor value:
  useful for resource graph UX: Prisma/MongoDB models, `Resource`,
  `GraphNode`, `GraphRelation`, card grid components, Pixi stage, draggable
  graph offsets, mouse-centered zoom, relation serialization, and node/relation
  render separation.
- Product reference value:
  useful for future "VR utility pattern map" or relationship browser.
- What to inspect next:
  seed/admin workflow, graph editing, link schema, accessibility, and database
  deployment assumptions.
- Caveats:
  graph UI appears experimental and contains debug naming/logging.

### `tiry/nuxeo-vr-assets-browser`

- Interesting idea:
  browse DAM assets inside a VR scene.
- Code donor value:
  useful for A-Frame asset-browser patterns: authenticated Nuxeo provider,
  thumbnail/preview/rendition selection by document type, A-Frame asset grid,
  cursor/fuse interactions, animated up/down paging, and zoom panel.
- Product reference value:
  strong historical reference for spatial asset libraries and VR content
  management.
- What to inspect next:
  modern A-Frame/WebXR migration, auth/token safety, CORS, and large asset
  pagination.
- Caveats:
  old A-Frame/WebVR stack and hardcoded default credentials/local server.

### `ElMoha943/valenvrc_package_listing`

- Interesting idea:
  publish a curated VRChat package listing with custom website and generated
  VPM index.
- Code donor value:
  useful for publication workflow: `source.json` with package release arrays,
  GitHub Actions checkout of `vrchat-community/package-list-action`, copying
  website data, `BuildMultiPackageListing`, deployment to production branch,
  and CNAME support.
- Product reference value:
  good reference for creator package distribution and public package pages.
- What to inspect next:
  release validation, broken-link checks, package metadata quality, and
  rollback.
- Caveats:
  generated website and release URLs should be validated before reuse.

### `Purpzie/vpm`

- Interesting idea:
  small VPM listing with a generated Fluent UI landing page.
- Code donor value:
  useful for listing UX: package search, copyable listing URLs, `vcc://`
  add-repo deep links, package info modal, dependency/license display, and
  row-level package menu.
- Product reference value:
  strong UX reference for making package repositories understandable to users.
- What to inspect next:
  generated-template source, accessibility, dependency display, and fallback
  behavior outside VCC.
- Caveats:
  app script is templated and depends on generation context.

### `Limitex/vrchat-package-template`

- Interesting idea:
  a VPM-ready package skeleton for distributing VRChat content.
- Code donor value:
  useful for package structure: `package.json` metadata, VPM dependencies,
  documentation/changelog/license URLs, Editor/Runtime asmdefs, Samples,
  Tests, Documentation, and Source asset folder convention.
- Product reference value:
  useful baseline for future `VR-apps-lab` reusable packages.
- What to inspect next:
  actual automation from `vrchat-package-lister`, docs content, release flow,
  and tests.
- Caveats:
  template content is mostly skeletal and documentation URL is placeholder-like.

## Reusable Pattern Extraction

- Pattern candidate:
  asset/resource/package discovery surface boundary.
- Problem solved:
  creator ecosystems need searchable indexes, package publication pages, graph
  navigation, and VR-native asset browsers before users can discover reusable
  tools safely.
- Reusable core:
  source manifest, item schema, metadata normalization, search/filter/sort,
  preview/download/install action, provenance/license display, package index
  generation, relation graph, and publication pipeline.
- Source evidence:
  static JSON cards in `vrchat-asset-browser`, Unity/Udon utilities in
  `VRChatResources`, resource graph in `VRCRW`, A-Frame/Nuxeo browser,
  Valenvrc and Purpzie VPM listings, and Limitex package skeleton.
- Abstraction boundary:
  keep catalog data, presentation, install route, and package generation as
  separate layers.
- What not to copy:
  remote-content browser extensions, hardcoded credentials, unvalidated public
  release URLs, placeholder docs, or AI-generated catalog code without schema
  checks.
- Method catalog action:
  create a method for VRChat resource and package discovery surfaces.

## Family Placement

This wave creates a VRChat asset/resource/package discovery family. It overlaps
with VPM publication tooling and VRChat creator helpers, but its main value is
public discovery UX and installability.

## Backlog Impact

- Build a resource discovery matrix across static asset index, graph view,
  VR-native DAM browser, VPM listing, and package template.
- Use `Fraxul/VRChatResources` as a creator microtool donor.
- Keep `Obelisk` as rejected/non-fit security evidence only.
