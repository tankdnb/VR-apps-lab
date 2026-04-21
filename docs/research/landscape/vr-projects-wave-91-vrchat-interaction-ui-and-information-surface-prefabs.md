# VR Projects Wave 91: VRChat Interaction, UI, and Information-Surface Prefabs

- Date: `2026-04-21`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `VRChat interaction prefabs`, `utility UI`, and
  `dynamic information-surface tools`.

## Why this wave exists

`VR-apps-lab` already had better coverage of creator media systems and OSC-side
utilities than of small world-side interaction prefabs. It still lacked a
cleaner answer to:

`what the strongest reusable world utility donors look like when the main value is keypads, shared markers, dynamic text carriers, and reusable UI infrastructure for large lists or boards`.

This wave exists to make that branch clearer.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with VRChat keypad, marker, dynamic board, and Udon UI
   infrastructure queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `Reava/U-Key` | Strong donor for access-control prefabs with rich configuration, remote allow-list loading, and per-solution routing |
| `z3y/VRCMarker` | Strong donor for a shared drawing surface with compact sync strategy and PC-plus-Quest scope |
| `Miner28/AvatarImageReader` | Strong reference for dynamic text or data transport through avatar thumbnail images and runtime decoding |
| `Guribo/UdonRecyclingScrollRect` | Strong donor for reusable pool-backed list UI infrastructure inside Udon worlds |

## Deep-pass notes by project

## `Reava/U-Key`

- GitHub:
  [Reava/U-Key](https://github.com/Reava/U-Key)
- What it is:
  a keypad and passcode prefab for VRChat worlds with configurable door
  objects, allow and deny lists, custom event relays, per-code routing, and
  optional remote allow-list loading.
- Why it matters:
  it is the clearest donor in this wave for
  `world access-control surface with rich prefab configuration instead of custom scripting`.
- Interesting ideas:
  keep the main access-control logic prefab-driven; allow both static and
  remotely loaded allow lists; support extra objects, per-solution routing, and
  custom event relays so one keypad can power richer world logic than `open one door`.
- Interesting implementation choices:
  `Runtime/Scripts/Keypad.cs`
  merges the primary passcode with additional solutions and doors, supports
  allow and deny lists, remote string loading through `VRCStringDownloader`,
  custom event relays, teleport-on-grant behavior, and strong logging for
  creator debugging.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  it is still a prefab-first utility, so many extension points are configured
  rather than deeply abstracted.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `configurable access-control or keypad surface`
  donor.

## `z3y/VRCMarker`

- GitHub:
  [z3y/VRCMarker](https://github.com/z3y/VRCMarker)
- What it is:
  a VRChat world prefab for drawing 3D lines on PC and Quest, with sync,
  gradients, undo, and optional higher-end commercial features outside the free
  public core.
- Why it matters:
  it is the clearest donor in this wave for
  `shared world drawing tool with compact sync state`.
- Interesting ideas:
  generate the local trail with higher-frequency updates while syncing only the
  minimal state or recent points needed for remote reconstruction; keep
  erasing and interaction ownership local to whoever currently owns the marker.
- Interesting implementation choices:
  `Runtime/Scripts/Marker.cs`
  splits pickup interaction, local-vs-remote update rate, ownership, and color
  texture generation; `MarkerSync.cs`
  sends only a small synced state plus recent trail points and reconstructs the
  remote trail on deserialization.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  some richer features live in the commercial branch, so the public repo is
  strongest as a sync and drawing-baseline donor.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `shared marker or annotation surface`
  donor.

## `Miner28/AvatarImageReader`

- GitHub:
  [Miner28/AvatarImageReader](https://github.com/Miner28/AvatarImageReader)
- What it is:
  a system for encoding text into avatar thumbnail images and decoding it at
  runtime inside VRChat worlds, originally intended for dynamic boards,
  supporter lists, and updatable world text.
- Why it matters:
  it is the clearest reference in this wave for
  `dynamic information carrier that piggybacks on avatar imagery`.
- Interesting ideas:
  use avatar thumbnail images as a cross-platform data carrier; separate
  editor-side encoding and upload from runtime-side decoding; allow chained
  avatars for higher data capacity.
- Interesting implementation choices:
  `Runtime/Udon Programs/RuntimeDecoder.cs`
  searches the generated avatar pedestal hierarchy, finds the `_WorldTex`,
  copies the texture through a render path, and decodes bytes into text; the
  repo also includes editor encoders and helper windows for preparing the data.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the README explicitly marks the overall technique deprecated because the
  surrounding platform path changed, so it is now more of a reference and
  historical donor than a current recommendation.
- What to inspect next:
  revisit only when a future pass needs deeper thinking about
  `dynamic data carriers inside creator-world constraints`.

## `Guribo/UdonRecyclingScrollRect`

- GitHub:
  [Guribo/UdonRecyclingScrollRect](https://github.com/Guribo/UdonRecyclingScrollRect)
- What it is:
  a Udon adaptation of a recycling scroll rect that reuses a small pool of UI
  cells rather than instantiating one element per row.
- Why it matters:
  it is the clearest donor in this wave for
  `large-list UI infrastructure inside creator worlds`.
- Interesting ideas:
  port the familiar `recycling list plus datasource` pattern into Udon; keep
  pooling and datasource contracts explicit; use delayed initialization because
  UI layout and Udon timing do not always settle in one frame.
- Interesting implementation choices:
  `Runtime/RecyclingScrollRect.cs`
  fronts the system and switches between horizontal and vertical backends;
  `Runtime/Recycling System/RecyclingScrollView.cs`
  owns pooled cells, datasource hookup, and delayed initialization through
  Udon events and a UI cell pool.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  the repo is honest that not every layout path is equally polished yet, with
  vertical scrolling strongest in the current public state.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `pool-backed UI list or scoreboard substrate`
  donor.

## Main takeaways from Wave 91

- `VRChat interaction and utility UI`
  now splits more cleanly into:
  - access-control prefabs;
  - shared marker and annotation surfaces;
  - dynamic data carriers;
  - lower-layer pooled list infrastructure.
- The strongest lesson from this wave is that
  `world utility donors`
  are often small but high leverage: a keypad, marker, or list infrastructure
  can shape a lot of creator-world UX.
- Another strong lesson is that
  `information surfaces`
  are sometimes built on unusual transport or storage layers, and those
  constraints are worth documenting even when the approach later becomes
  historical.

## Reusable methods clarified by this wave

- `Configurable keypad prefab with allow and deny lists, per-solution routing, remote allow-list loading, and event relays`
- `Shared 3D marker tool that keeps local trail generation separate from compact manual-sync state updates`
- `Avatar-thumbnail text or data carrier with editor encoder and runtime pedestal-image decoder`
- `Pool-backed recycling scroll rect for Udon with datasource contract and delayed view initialization`

## Recommended next moves after this wave

1. Keep `U-Key` visible as a strong
   `interaction prefab with rich configuration`
   donor.
2. Treat `VRCMarker` as one of the strongest
   `shared drawing and annotation`
   donors in the creator-world branch.
3. Keep `AvatarImageReader` visible as a historical but still useful
   `dynamic data carrier under world constraints`
   reference.
4. Use `UdonRecyclingScrollRect` as a foundation donor whenever future work
   needs scoreboards, large lists, or repeated UI cells in creator worlds.
