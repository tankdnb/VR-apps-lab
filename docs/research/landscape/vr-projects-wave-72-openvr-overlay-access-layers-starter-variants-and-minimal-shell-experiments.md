# VR Projects Wave 72: OpenVR Overlay Access Layers, Starter Variants, and Minimal Shell Experiments

- Date: `2026-04-20`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `OpenVR overlay access layers`, `starter variants`, and
  `minimal shell experiments`.

## Why this wave exists

`VR-apps-lab` already had many overlay products, dashboards, and template
repos, but it still lacked a clearer picture of the
`small implementation layers that sit directly on top of OpenVR overlays`.

This wave exists to make that family clearer:

- overlay-focused access layers rather than full runtime wrappers;
- tiny dashboard overlay bootstraps;
- architecture-sketch shells for static and window overlays;
- desktop-window control shells over shared overlay backends.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with overlay wrapper, starter repo, and small-shell queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `TheButlah/ovr_overlay` | Strong donor for an overlay-focused OpenVR access layer instead of a full binding stack |
| `ViveIsAwesome/OpenVROverlayTest` | Strong lower-bound donor for a tiny C# dashboard overlay bootstrap |
| `scudzey/UniversalVROverlay` | Useful architecture-sketch donor for `OverlayManager` plus static/window overlay split |
| `albrt-vr/OpenVR.ALBRT.overlay` | Strong donor for a desktop UI shell over a shared overlay backend |

## Deep-pass notes by project

## `TheButlah/ovr_overlay`

- GitHub:
  [TheButlah/ovr_overlay](https://github.com/TheButlah/ovr_overlay)
- What it is:
  a Rust OpenVR access layer that deliberately focuses on overlay usage instead
  of wrapping the entire OpenVR surface equally.
- Why it matters:
  it is the clearest donor in this wave for
  `overlay-focused OpenVR wrapper with explicit context ownership`.
- Interesting ideas:
  initialize once in overlay mode; expose subsystem managers behind a typed
  context; feature-gate only the interfaces the client actually needs.
- Interesting implementation choices:
  `src/lib.rs`
  uses `Context::init()` and typed manager accessors while
  `src/overlay.rs`
  wraps overlay creation, visibility, opacity, transforms, curvature, and
  image or raw-data updates.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  it is intentionally narrower than a full OpenVR wrapper, but that focus is
  exactly what makes it useful here.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `small reusable overlay backplane`
  donor.

## `ViveIsAwesome/OpenVROverlayTest`

- GitHub:
  [ViveIsAwesome/OpenVROverlayTest](https://github.com/ViveIsAwesome/OpenVROverlayTest)
- What it is:
  a tiny C# dashboard overlay sample that creates a dashboard overlay, sets
  images from disk, and polls visibility in a very direct loop.
- Why it matters:
  it is the clearest donor in this wave for
  `minimal dashboard overlay bootstrap without abstraction fog`.
- Interesting ideas:
  keep the entire bootstrap visible in one file; use raw file-backed image
  surfaces; treat `visible / not visible` as the control loop.
- Interesting implementation choices:
  `Program.cs`
  initializes OpenVR, creates the dashboard overlay, sets both the main image
  and thumbnail, then uses a tight visibility loop to drive state changes.
- Code donor value:
  medium-high.
- Product reference value:
  low-medium.
- Architecture reference value:
  medium-high.
- Caveats:
  tiny and product-thin, but unusually useful because it shows the lower bound
  honestly.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `small dashboard overlay starter`
  donor.

## `scudzey/UniversalVROverlay`

- GitHub:
  [scudzey/UniversalVROverlay](https://github.com/scudzey/UniversalVROverlay)
- What it is:
  a C++ overlay experiment that separates a central `OverlayManager` from
  static and window-overlay classes.
- Why it matters:
  it is the clearest donor in this wave for
  `architecture-sketch overlay shell with separate overlay classes`.
- Interesting ideas:
  keep overlay registration centralized; let one shell own multiple overlay
  implementations; make the difference between `static image` and
  `window-backed overlay`
  explicit in class boundaries.
- Interesting implementation choices:
  `src/main.cpp`
  shows the app bootstrap and registration flow while
  `src/OverlayManager.cpp`, `src/StaticOverlay.cpp`, and
  `src/WindowOverlay.cpp`
  expose the intended shell split, even though the window-backed path remains
  unfinished.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  medium-high.
- Caveats:
  parts of the implementation are incomplete, so it is strongest as an
  `architecture sketch`
  rather than a finished donor.
- What to inspect next:
  keep it visible when future overlay work needs a
  `manager plus overlay subclasses`
  comparison.

## `albrt-vr/OpenVR.ALBRT.overlay`

- GitHub:
  [albrt-vr/OpenVR.ALBRT.overlay](https://github.com/albrt-vr/OpenVR.ALBRT.overlay)
- What it is:
  a managed overlay application that splits desktop `WinUI` shell concerns from
  shared overlay backend concerns.
- Why it matters:
  it is the clearest donor in this wave for
  `desktop window plus shared overlay backend`.
- Interesting ideas:
  keep desktop navigation and settings in a normal windowed shell; start and
  supervise the overlay backend from that shell; isolate render and OpenVR
  ownership in shared code instead of scattering it through UI pages.
- Interesting implementation choices:
  `ALBRT.overlay.win64/ALBRT.overlay.win64/MainWindow.xaml.cs`
  wires the desktop shell and backend events while
  `Shared Projects/ALBRT.overlay.cs/ALBRTManager.cs`
  owns SteamVR checks, overlay registration, render-loop start, and event
  polling.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  broader than a tiny starter, but precisely because it shows how a desktop
  control shell can sit over an overlay backend.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `configurable overlay app with desktop settings shell`
  donor.

## Main takeaways from Wave 72

- `overlay implementation donors` split more cleanly into:
  - `overlay-focused access layer`
  - `tiny dashboard bootstrap`
  - `architecture-sketch manager-plus-subclass shell`
  - `desktop shell plus shared overlay backend`
- The strongest lesson from this wave is that
  `overlay implementation`
  is not one layer. Binding strategy, starter size, and desktop-control split
  all matter.
- Another strong lesson is that small or incomplete repos can still be valuable
  when they make ownership and lifecycle boundaries unusually visible.

## Reusable methods clarified by this wave

- `Overlay-focused OpenVR wrapper with context-owned managers and feature-gated subsystem access`
- `Minimal dashboard overlay starter that keeps manifest, image surfaces, and visibility loop explicit`
- `Shared overlay backend plus desktop-window control shell`

## Recommended next moves after this wave

1. Treat `ovr_overlay` as the clearest donor in this wave for a
   `small overlay-focused access layer`.
2. Treat `OpenVROverlayTest` as the smallest honest donor for a
   `dashboard overlay bootstrap`.
3. Keep `UniversalVROverlay` visible as an
   `overlay architecture sketch`
   comparison rather than pretending it is a more complete donor than it is.
4. Keep `OpenVR.ALBRT.overlay` visible whenever a future branch needs a
   `desktop shell over shared overlay runtime`
   reference.
