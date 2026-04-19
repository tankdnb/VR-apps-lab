# VR Projects Wave 61: Managed-Language Overlay Starters, UIToolkit Templates, and Higher-Level Scaffolds

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `managed-language overlay starters`, `UIToolkit templates`, and
  `higher-level scaffolds`.

## Why this wave exists

Earlier overlay waves clarified native hosts and low-level baselines, but
another reusable branch still needed to be separated more cleanly:

- Unity and `C#` overlay starters that preserve explicit runtime boundaries;
- overlay templates that translate `OpenVR` events into real UI frameworks;
- app-specific higher-level shells whose architecture is still useful even when
  the product itself is narrow.

This wave exists to make
`managed-language overlay starters, UIToolkit templates, and higher-level scaffolds`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with `Unity`, `C#`, `UIToolkit`, and managed overlay queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `someka-vrc/uitoko-ovr` | Strong donor for a reusable Unity `UIToolkit` overlay template with explicit `OpenVR` lifecycle and event bridging |
| `AanthonyRusso/BasicOverlay` | Focused donor for a desktop-side metadata feed driving a small in-headset overlay |
| `Spacefish/OpenVR-Overlay` | Managed-language donor for Vulkan texture interop, controller attachment, and direct overlay-event polling |
| `Daniel-Webster/WT-OpenVR-Overlay` | Useful but broader Unity scaffold whose local webservice and embedded overlay framework still teach reusable architecture lessons |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `kurohuku7/zenn-overlay-tutorial` | Interesting tutorial and appendix line, but better treated as a future teaching-material node than as a mainline code donor |

## Deep-pass notes by project

## `someka-vrc/uitoko-ovr`

- GitHub:
  [someka-vrc/uitoko-ovr](https://github.com/someka-vrc/uitoko-ovr)
- What it is:
  a Unity overlay template built around `UIToolkit`, `RenderTexture`, and a
  reusable `OpenVR` lifecycle layer.
- Why it matters:
  it is the clearest donor in the repo for
  `Unity UIToolkit overlay scaffold with explicit OpenVR event forwarding`.
- Interesting ideas:
  treat overlay lifecycle, persistent settings, and UI document ownership as
  first-class template concerns; keep overlay input bridging explicit instead of
  hiding it behind a custom widget framework.
- Interesting implementation choices:
  `Runtime/Scripts/Core/BaseOverlay.cs`
  owns `UIDocument` plus `RenderTexture`,
  `OpenVRLifeCycle.cs`
  keeps init and shutdown explicit, and
  `VROverlayInputBridge.cs`
  translates `OpenVR` overlay events into `UIToolkit` pointer, click, scroll,
  and hover semantics.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  Unity-specific, but unusually strong as a reusable template rather than one
  app.
- What to inspect next:
  treat it as a main donor whenever a future branch needs
  `overlay-first Unity UI scaffolding`.

## `AanthonyRusso/BasicOverlay`

- GitHub:
  [AanthonyRusso/BasicOverlay](https://github.com/AanthonyRusso/BasicOverlay)
- What it is:
  a focused `C++` overlay that launches a small Python helper, reads refreshed
  media metadata and cover art from the desktop side, and positions the overlay
  in front of the user with predicted timing.
- Why it matters:
  it is a strong donor for
  `desktop-side content feeder driving a narrow in-headset overlay`.
- Interesting ideas:
  keep the overlay simple; let a separate helper own media lookup; use a
  predicted HMD-relative placement path instead of a fixed transform; refresh
  assets from files rather than forcing a broader local service host.
- Interesting implementation choices:
  `BasicOverlay/src/OverlayApp.cpp`
  shows the
  `python helper -> changed assets -> overlay refresh`
  contract and uses
  `GetTimeSinceLastVsync`,
  `Prop_DisplayFrequency_Float`,
  and
  `Prop_SecondsFromVsyncToPhotons_Float`
  to place the overlay ahead of the user's view.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium.
- Caveats:
  product-specific and rough around packaging, but the `desktop data feeder ->
  overlay refresh` boundary is useful.
- What to inspect next:
  keep it visible whenever a future branch needs
  `overlay with a tiny external metadata producer`.

## `Spacefish/OpenVR-Overlay`

- GitHub:
  [Spacefish/OpenVR-Overlay](https://github.com/Spacefish/OpenVR-Overlay)
- What it is:
  a `.NET` overlay host that initializes `OpenVR`, renders texture content via
  a Vulkan path, attaches the overlay to a controller, and polls overlay events
  on a background task.
- Why it matters:
  it is the clearest donor in the repo for
  `managed-language overlay host with GPU-native texture interop`.
- Interesting ideas:
  keep the whole host managed without abandoning direct texture interop; use a
  small background event loop rather than a heavy UI toolkit; keep controller
  attachment and overlay control-bar flags visible in code.
- Interesting implementation choices:
  `VROverlay.cs`
  creates the overlay, loads a texture through a custom Vulkan engine,
  packages `VRVulkanTextureData_t`, and sends haptic pulses on overlay mouse
  movement while polling overlay events asynchronously.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  still a thin example, but that thinness is what makes the Vulkan interop
  lesson reusable.
- What to inspect next:
  keep it visible whenever a future branch needs
  `managed Vulkan texture interop for OpenVR overlays`.

## `Daniel-Webster/WT-OpenVR-Overlay`

- GitHub:
  [Daniel-Webster/WT-OpenVR-Overlay](https://github.com/Daniel-Webster/WT-OpenVR-Overlay)
- What it is:
  a broader Unity overlay application for War Thunder that combines an embedded
  overlay framework lineage, app-specific scenes, settings UI, and a local
  webservice client pointed at `http://localhost:8111/`.
- Why it matters:
  it is useful less as a clean starter and more as an honest
  `higher-level Unity scaffold over a local game data surface`.
- Interesting ideas:
  combine reusable overlay helpers with a narrow domain app; keep a local
  service boundary explicit; layer settings and overlay framework code around a
  game-specific control surface.
- Interesting implementation choices:
  `Assets/WTOVRLay/Scripts/Webservice/WTService.cs`
  keeps the local service contract visible, while the `Assets/OVRLay/`
  framework lineage and surrounding settings scripts expose how the overlay app
  is assembled.
- Code donor value:
  medium.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium.
- Caveats:
  broad, noisy, and more app-specific than the stronger main donors in this
  wave.
- What to inspect next:
  revisit only if a future pass needs a sharper comparison between reusable
  framework pieces and app-specific Unity shell logic.

## Main takeaways from Wave 61

- `Managed-language overlay donors` split more cleanly into:
  - `Unity UIToolkit template with event bridge`
  - `desktop-side metadata feeder for a narrow overlay`
  - `managed GPU-interoperable overlay host`
  - `broader Unity scaffold over a local service`
- The strongest lesson from this wave is that a reusable overlay starter does
  not have to choose between `managed language ergonomics` and `explicit
  runtime behavior`.
- Another strong lesson is that `app-specific overlay scaffolds` still matter
  when they reveal service boundaries, settings models, or overlay-framework
  lineage that smaller starter repos omit.

## Reusable methods clarified by this wave

- `UIToolkit overlay scaffold with explicit OpenVR event-to-UI bridging`
- `Managed-language overlay host with GPU-native texture interop and controller-attached defaults`
- `Desktop-side content feeder that refreshes a narrow overlay through scripts, files, or local services`

## Recommended next moves after this wave

1. Treat `uitoko-ovr` as the clearest donor for
   `Unity overlay template plus event bridge`.
2. Keep `OpenVR-Overlay` visible whenever `VR-apps-lab` needs managed-language
   texture interop with a direct `OpenVR` host.
3. Keep `BasicOverlay` visible for
   `desktop metadata feeder -> overlay refresh` patterns.
4. Keep `WT-OpenVR-Overlay` as a partial scaffold node rather than promoting it
   as a cleaner donor than the template-first repos.
