# VR Projects Wave 55: Creator Control Overlays, Research Stations, and Specialized Companion-Presence Surfaces

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `creator control overlays`, `research stations`, and
  `specialized companion-presence surfaces`.

## Why this wave exists

`VR-apps-lab` already had creator tools, workflow helpers, and communication
sidecars, but another branch still needed a clearer donor map:

- overlays that control another creator tool such as `OBS` through a local
  protocol;
- standalone overlay stations designed for VR research rather than productivity;
- overlays that visualize a collaborator or another tracked entity in your own
  playspace;
- overlays anchored to a specific environmental object for safety or awareness.

This wave exists to make
`creator control overlays, research stations, and specialized companion-presence surfaces`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with creator-overlay, questionnaire-overlay, companion-overlay,
   and anchored-awareness queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `99oblivius/VRBro-Overlay` | Strong donor for a creator-facing OBS control overlay with wrist menu, dashboard, and local plugin protocol |
| `kuentzel/ROVER` | Strong donor for a standalone VR questionnaire and study station implemented as an overlay-driven tool |
| `imagitama/steamvr-overlay-vrbuddy` | Useful donor for visualizing another person's head and hands as overlays in your own playspace |
| `lukis101/VRPoleOverlay` | Focused donor for a spatial-awareness overlay anchored to a known object in the room |

## Deep-pass notes by project

## `99oblivius/VRBro-Overlay`

- GitHub:
  [99oblivius/VRBro-Overlay](https://github.com/99oblivius/VRBro-Overlay)
- What it is:
  a SteamVR companion app for controlling OBS Studio through a paired OBS
  plugin, with both a wrist menu and a dashboard surface.
- Why it matters:
  it is the clearest donor in the repo for
  `creator control overlay over a local plugin protocol`.
- Interesting ideas:
  keep creator controls accessible on the wrist while still offering a fuller
  dashboard; separate network transport from scene and button logic; let scene
  switching behave as a first-class overlay UI.
- Interesting implementation choices:
  `Assets/Scripts/Network.cs`
  makes the local OBS protocol explicit, while
  `Assets/Scripts/VRBroOverlay.cs`
  and
  `Assets/Scripts/VRBroDash.cs`
  show the split between wrist menu and dashboard overlay.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  tightly coupled to the paired OBS plugin, but that is also what makes the
  local control surface pattern concrete.
- What to inspect next:
  keep it visible whenever a future branch needs
  `overlay as remote control surface for creator tools`.

## `kuentzel/ROVER`

- GitHub:
  [kuentzel/ROVER](https://github.com/kuentzel/ROVER)
- What it is:
  a standalone overlay-driven VR questionnaire toolkit for research studies,
  with desktop configuration, import or export flows, and a study-sequencing
  model.
- Why it matters:
  it is the clearest donor in the repo for
  `overlay-driven research station with study data model and operator tooling`.
- Interesting ideas:
  separate overlay rendering, desktop operator UI, study import, and result
  flow; let the tool exist as a standalone executable instead of an SDK only;
  support imported questionnaires and reusable item or section data.
- Interesting implementation choices:
  `Assets/ROVER/Scripts/Base/OverlayManager.cs`
  makes the overlay state and runtime connection explicit,
  `Assets/ROVER/Scripts/Base/DesktopUserInterfaceManager.cs`
  shows the operator-side mirror and configuration layer, and
  `Assets/ROVER/Scripts/Data/StudyJsonImportExportManager.cs`
  plus `StudyManager.cs`
  expose the study schema and sequencing model.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  large Unity repo with research-specific baggage, but the overlay station and
  study-model split are still unusually clear.
- What to inspect next:
  keep it visible whenever a future branch needs
  `standalone in-VR questionnaire or study tooling`.

## `imagitama/steamvr-overlay-vrbuddy`

- GitHub:
  [imagitama/steamvr-overlay-vrbuddy](https://github.com/imagitama/steamvr-overlay-vrbuddy)
- What it is:
  a SteamVR overlay app that displays another person's head and hands in your
  playspace by receiving their tracking data over Steam or direct IP.
- Why it matters:
  it is a clear donor for
  `remote companion visualization through multiple overlay handles`.
- Interesting ideas:
  represent another user with just the parts that matter most for coordination;
  keep networking separate from rendering; expose offset and look-at-player
  options as explicit settings rather than hiding them.
- Interesting implementation choices:
  `Program.cs`
  shows the sender or receiver startup model, while
  `Render.cs`
  makes the `tracking data -> separate head or hand overlays -> transform and
  texture update` path explicit.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium-high.
- Caveats:
  still rough and narrow, but the companion-visualization lesson is distinctive
  enough to keep.
- What to inspect next:
  revisit only if a future branch needs a deeper
  `shared-space collaborator overlay` comparison.

## `lukis101/VRPoleOverlay`

- GitHub:
  [lukis101/VRPoleOverlay](https://github.com/lukis101/VRPoleOverlay)
- What it is:
  a C# OpenVR overlay that renders a configurable cylinder to show the location
  of a stationary fitness pole in the user's playspace.
- Why it matters:
  it is the clearest donor in the repo for
  `anchored awareness overlay over a known environmental object`.
- Interesting ideas:
  use chaperone color and height as defaults; calibrate the overlay in VR by
  dragging it with a controller; keep configuration small and reloadable from a
  JSON file.
- Interesting implementation choices:
  `VRPoleOverlay/Program.cs`
  makes the `settings load -> chaperone sync -> overlay configure -> in-VR drag
  edit mode` path explicit, while
  `Configuration.cs`
  shows a compact but practical parameter model for a spatial awareness overlay.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  its domain is very narrow, but that narrowness is also the strongest lesson:
  overlays can exist to visualize one real-world object only.
- What to inspect next:
  keep it visible whenever a future branch needs
  `anchored object or room-awareness overlays`.

## Main takeaways from Wave 55

- `Specialized overlay surfaces` are clearer when split into:
  - `creator control overlay over local plugin protocol`
  - `standalone research questionnaire station`
  - `remote companion visualization overlay`
  - `anchored object-awareness overlay`
- The strongest lesson from this wave is that a good VR display surface is often
  defined by the `context it knows`, not by how many generic desktop features
  it exposes.

## Reusable methods clarified by this wave

- `Creator control overlay over a local plugin protocol`
- `Standalone research station with overlay manager, operator UI, and study schema`
- `Remote companion visualization through multiple overlay handles`
- `Anchored awareness overlay tied to a known object or room feature`

## Recommended next moves after this wave

1. Treat `VRBro-Overlay` as the main creator-control donor for future
   `overlay-driven OBS or workflow control` ideas.
2. Keep `ROVER` visible whenever `VR-apps-lab` needs a
   `standalone study station` reference rather than a browser survey in VR.
3. Keep `steamvr-overlay-vrbuddy` and `VRPoleOverlay` visible as proofs that
   `specialized contextual overlays` deserve their own design branch.
