# VR Projects Wave 63: Specialized Effect Overlays, Visibility Shaping, and Passthrough Cutout Surfaces

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `specialized effect overlays`, `visibility shaping`, and
  `passthrough cutout surfaces`.

## Why this wave exists

The overlay corpus in `VR-apps-lab` already had dashboards, notes, media
surfaces, and companion shells, but another branch still needed to be made
explicit:

- overlays whose job is a visual effect rather than a traditional UI;
- comfort surfaces that constrain or reshape vision;
- passthrough cutout tools where the overlay acts as a hole into physical
  space.

This wave exists to make
`specialized effect overlays, visibility shaping, and passthrough cutout surfaces`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with passthrough-cutout, black-bar, comfort-ring, and
   effect-overlay queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `Alex-J-Lopez/OpenMixerXR` | Strong donor for world-space chroma-key passthrough cutouts with dashboard management and physical grab or resize |
| `joaoseabra/SteamVRBlackBarOverlay` | Focused donor for top-of-view masking and field-of-view shaping |
| `tnsgud9/VR-Overlay-Half_Ring` | Comfort-oriented Unity overlay that rotates with headset roll and exposes a simple settings UI |
| `RedHawk989/OpenVR-Windows-Activation` | Useful lower-bound donor for a static-image environmental effect overlay |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `emymin/EmyOverlay` | Public repo still too thin and under-documented to justify promotion beyond a follow-up node |

## Deep-pass notes by project

## `Alex-J-Lopez/OpenMixerXR`

- GitHub:
  [Alex-J-Lopez/OpenMixerXR](https://github.com/Alex-J-Lopez/OpenMixerXR)
- What it is:
  a `C++`, `D3D11`, and `ImGui` SteamVR overlay app that manages multiple
  chroma-colored boxes in 3D space so an external passthrough system can turn
  those boxes into transparent cutout windows.
- Why it matters:
  it is the clearest donor in the repo for
  `overlay as a passthrough cutout manager with spatial editing`.
- Interesting ideas:
  treat each cutout as a first-class box with its own transform, color, fade,
  and visibility; separate dashboard editing from physical grab or resize; keep
  recalibration and future layout persistence visible in the product model.
- Interesting implementation choices:
  `src/OverlayManager.h`
  manages the overlay-handle lifecycle,
  `DashboardUI.cpp`
  renders an `ImGui` dashboard into a shared `D3D11` texture and submits it as a
  dashboard overlay, while
  `GrabController.cpp`
  turns controller grips into move-mode and two-hand resize behavior for the
  active cutout box.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  tied to chroma-key passthrough rather than generic mixed reality, but the
  `effect overlay with spatial editing` pattern is very strong.
- What to inspect next:
  treat it as a main donor whenever a future branch needs
  `spatial cutout editing`, `effect-first overlay dashboard`, or
  `controller-driven box manipulation`.

## `joaoseabra/SteamVRBlackBarOverlay`

- GitHub:
  [joaoseabra/SteamVRBlackBarOverlay](https://github.com/joaoseabra/SteamVRBlackBarOverlay)
- What it is:
  a focused `C++` `OpenVR` overlay that creates a persistent black bar near the
  top of the user's field of view.
- Why it matters:
  it is a clean donor for
  `visibility shaping through a simple HMD-relative overlay`.
- Interesting ideas:
  keep the effect narrow and always-on; generate a file-backed texture instead
  of building a larger renderer; expose bar height, width, and distance as
  explicit product parameters.
- Interesting implementation choices:
  `src/BlackBarOverlay.cpp`
  sets an HMD-relative transform, creates a bitmap file for the mask texture,
  calls `SetOverlayFromFile()`, and keeps the overlay out of the normal
  dashboard tab flow.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium.
- Caveats:
  narrow and visually simple, but strong precisely because it turns a tiny
  effect into a clear product.
- What to inspect next:
  keep it visible whenever a future branch needs
  `field-of-view mask` or `top-of-view comfort overlay` patterns.

## `tnsgud9/VR-Overlay-Half_Ring`

- GitHub:
  [tnsgud9/VR-Overlay-Half_Ring](https://github.com/tnsgud9/VR-Overlay-Half_Ring)
- What it is:
  a Unity comfort overlay that keeps a half-ring stabilized against headset roll
  and exposes basic texture, color, and visibility toggles.
- Why it matters:
  it is a useful donor for
  `comfort overlay driven by head orientation rather than dashboard state`.
- Interesting ideas:
  align the comfort surface with roll; keep overlay visibility conditional on
  head pitch; expose customization through a simple overlay-side settings UI.
- Interesting implementation choices:
  `Assets/Half-Ring/OverlayRing.cs`
  rotates the overlay against headset roll,
  `SettingManager.cs`
  toggles visibility and swaps textures based on pitch and options, and
  `UI_Manager.cs`
  exposes a simple Unity-side configuration surface.
- Code donor value:
  medium.
- Product reference value:
  high.
- Architecture reference value:
  medium.
- Caveats:
  older Unity project with noisy assets, but the comfort pattern is still clear.
- What to inspect next:
  keep it visible whenever a future branch needs
  `motion-sickness comfort surface` or
  `orientation-aware overlay` references.

## `RedHawk989/OpenVR-Windows-Activation`

- GitHub:
  [RedHawk989/OpenVR-Windows-Activation](https://github.com/RedHawk989/OpenVR-Windows-Activation)
- What it is:
  a tiny meme overlay that places a Windows activation image in HMD-relative
  space and keeps it visible as a persistent environmental effect.
- Why it matters:
  it is a useful lower bound for
  `static-image environmental effect overlay`.
- Interesting ideas:
  prove the effect with almost no machinery; keep image path and HMD-relative
  transform explicit; accept that a low-complexity repo can still carry a clear
  product lesson.
- Interesting implementation choices:
  `src/main.cpp`
  initializes `OpenVR`, loads a single image from disk, shows the overlay, and
  refreshes the HMD-relative transform in a simple loop.
- Code donor value:
  low-medium.
- Product reference value:
  medium.
- Architecture reference value:
  low-medium.
- Caveats:
  intentionally minimal and partly a joke, but still useful as a lower-bound
  effect overlay.
- What to inspect next:
  revisit only if a future branch needs a `small static-image overlay effect`
  comparison.

## Main takeaways from Wave 63

- `Effect-first overlays` split more cleanly into:
  - `passthrough cutout manager`
  - `field-of-view shaping mask`
  - `comfort ring tied to head orientation`
  - `static-image environmental effect`
- The strongest lesson from this wave is that
  `overlay utility`
  should include perception- and comfort-shaping tools, not only dashboards and
  content panels.
- Another strong lesson is that a very small repo can still matter when it
  proves a narrow visual effect cleanly enough to inspire a future reusable
  tool.

## Reusable methods clarified by this wave

- `Spatial passthrough cutout overlay managed through a dashboard and controller grab or resize flow`
- `Visibility-shaping comfort overlay anchored to head pose, field-of-view, or roll`

## Recommended next moves after this wave

1. Treat `OpenMixerXR` as the clearest donor for
   `effect-first overlay with spatial editing and passthrough cutouts`.
2. Keep `SteamVRBlackBarOverlay` visible whenever `VR-apps-lab` needs a
   minimal `visibility mask` reference.
3. Keep `VR-Overlay-Half_Ring` visible for
   `comfort overlay tied to headset orientation`.
4. Keep `OpenVR-Windows-Activation` as a lower-bound comparison node for tiny
   static-image effects rather than a stronger donor than the other repos in
   this wave.
