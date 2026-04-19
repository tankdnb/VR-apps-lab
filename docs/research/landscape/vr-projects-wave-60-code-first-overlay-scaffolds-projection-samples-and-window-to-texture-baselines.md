# VR Projects Wave 60: Code-First Overlay Scaffolds, Projection Samples, and Window-to-Texture Baselines

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `code-first overlay scaffolds`, `projection samples`, and
  `window-to-texture baselines`.

## Why this wave exists

Previous overlay waves clarified hosts, dashboards, and higher-level templates,
but another donor layer still needed to be made explicit:

- the smallest believable `OpenVR` overlay samples;
- Linux or desktop capture pipelines that feed a real app window into an
  overlay texture;
- projection-overlay examples where frusta and transforms are explained rather
  than implied.

This wave exists to make
`code-first overlay scaffolds, projection samples, and window-to-texture baselines`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with overlay-baseline, projection-overlay, and window-capture
   queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `stevenjwheeler/OpenGL-VROverlay` | Tiny `C` and OpenGL donor for the most direct `draw -> texture -> OpenVR overlay` path |
| `ChristophHaag/OpenVRWindowOverlay` | Clear Linux donor for `X11 window capture -> GL texture -> SteamVR overlay` |
| `pfgithub/openvr-overlay-test` | Thin Zig baseline that keeps the raw `OpenVR` C API and texture-submit flow explicit |
| `hiinaspace/openvr-overlay-bunny` | Strong worked example for `SetOverlayTransformProjection`, per-eye frusta, and projection-overlay math |

## Deep-pass notes by project

## `stevenjwheeler/OpenGL-VROverlay`

- GitHub:
  [stevenjwheeler/OpenGL-VROverlay](https://github.com/stevenjwheeler/OpenGL-VROverlay)
- What it is:
  a tiny `C` plus rawdraw plus OpenGL sample that creates one `OpenVR` overlay,
  draws into a small window, copies the pixels into a GL texture, and submits
  that texture every frame.
- Why it matters:
  it is one of the clearest lower bounds in the repo for
  `raw OpenVR texture-submit overlay`.
- Interesting ideas:
  keep the dependency surface minimal; use `FnTable` lookup directly; attach the
  overlay relative to the right-hand controller; keep even a battery-overlay
  variant visible in comments rather than hiding it in abstractions.
- Interesting implementation choices:
  `hello.c`
  exposes `CNOVRGetOpenVRFunctionTable()`,
  `AssociateOverlay()`,
  and the simple
  `glCopyTexImage2D() -> SetOverlayTexture()`
  loop with almost no extra framework.
- Code donor value:
  high.
- Product reference value:
  low-medium.
- Architecture reference value:
  medium.
- Caveats:
  intentionally bare and not a polished product, but that is exactly why it is
  valuable as a lower-bound donor.
- What to inspect next:
  keep it visible whenever a future overlay prototype risks overcomplicating the
  minimal texture-submit path.

## `ChristophHaag/OpenVRWindowOverlay`

- GitHub:
  [ChristophHaag/OpenVRWindowOverlay](https://github.com/ChristophHaag/OpenVRWindowOverlay)
- What it is:
  a Linux and `X11` overlay utility that captures a specific window via
  `ximagesrc`, pipes frames through `GStreamer`, uploads them into an OpenGL
  texture, and exposes that texture as an `OpenVR` overlay.
- Why it matters:
  it is the clearest donor in the repo for
  `real desktop window capture -> OpenVR overlay texture`.
- Interesting ideas:
  take an actual window id as the product boundary; keep the capture path
  explicit; allow keyboard nudging of overlay position and width during bring-up
  instead of hiding transforms behind a UI.
- Interesting implementation choices:
  `overlay.cpp`
  shows the full
  `ximagesrc -> appsink -> gdk pixbuf -> glTexSubImage2D -> SetOverlayTexture`
  path while keeping overlay translation and width updates direct and readable.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  Linux and `X11` specific, but unusually strong for that platform branch.
- What to inspect next:
  keep it visible whenever a future branch needs a desktop-window donor that is
  more explicit than a full browser or dashboard host.

## `pfgithub/openvr-overlay-test`

- GitHub:
  [pfgithub/openvr-overlay-test](https://github.com/pfgithub/openvr-overlay-test)
- What it is:
  a Zig port of a minimal rawdraw plus OpenGL overlay sample that uses the
  `OpenVR` C API directly and anchors the overlay to the left hand.
- Why it matters:
  it helps prove that the `tiny overlay baseline` family is not only a C-lineage
  trick; the same donor pattern survives in a higher-level systems language.
- Interesting ideas:
  keep the whole example thin enough that `language choice` is the main
  variable; preserve the same direct `FnTable` access and `glCopyTexImage2D`
  submit path.
- Interesting implementation choices:
  `src/main.zig`
  exposes `associateOverlay()`,
  direct `openvr_capi.h`
  usage,
  rawdraw rendering, and
  `Texture_t`
  submission without wrapping the API behind a thicker engine.
- Code donor value:
  medium-high.
- Product reference value:
  low.
- Architecture reference value:
  medium.
- Caveats:
  mostly useful as a baseline and language-translation node, not as a product
  reference.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` wants a minimal Zig-side overlay
  starting point.

## `hiinaspace/openvr-overlay-bunny`

- GitHub:
  [hiinaspace/openvr-overlay-bunny](https://github.com/hiinaspace/openvr-overlay-bunny)
- What it is:
  a Python and OpenGL projection-overlay sample that renders a spinning Stanford
  bunny per eye, reads frusta and eye transforms from SteamVR, and pushes the
  matching projection state back through `SetOverlayTransformProjection()`.
- Why it matters:
  it is the clearest donor in the repo for
  `projection overlay with honest frustum and transform math`.
- Interesting ideas:
  keep the wrapper thin; document transform direction explicitly; use two
  overlay handles as the reliable path; preserve debug modes that reveal why the
  math behaves the way it does.
- Interesting implementation choices:
  `runtime.py`
  stays laser-focused on the required API surface,
  `app.py`
  keeps the full control loop visible, and
  `docs/transform-notes.md`
  records the verified interpretation choices instead of pretending the API is
  self-explanatory.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  still an experimental sample and honest about overlay jitter, but that
  honesty is part of the donor value.
- What to inspect next:
  treat it as the main donor whenever a future overlay branch needs
  `projection overlays`, `per-eye frusta`, or `transform-debug notes`.

## Main takeaways from Wave 60

- `Low-level overlay donors` split more cleanly into:
  - `tiny texture-submit baseline`
  - `desktop window capture bridge`
  - `projection-overlay math explainer`
- The strongest lesson from this wave is that
  `overlay implementation reference`
  should not mean only `big framework`.
  Small baselines are strategically important because they keep future
  prototypes honest about what the true minimal runtime boundary looks like.
- Another strong lesson is that `projection overlays` deserve explicit donor
  treatment because the public documentation is weak and the transform direction
  is easy to misunderstand.

## Reusable methods clarified by this wave

- `Raw OpenVR texture-submit baseline over a tiny GL or rawdraw render loop`
- `Desktop or app-window capture pipeline mirrored into an OpenVR overlay texture`
- `Projection-overlay wrapper with explicit per-eye frusta and transform-direction notes`

## Recommended next moves after this wave

1. Treat `openvr-overlay-bunny` as the clearest donor for
   `projection overlay math and frustum handling`.
2. Keep `OpenVRWindowOverlay` visible whenever `VR-apps-lab` needs a concrete
   `window capture -> overlay texture` path.
3. Keep `OpenGL-VROverlay` and `openvr-overlay-test` as lower-bound references
   for minimal overlay bring-up in `C` or Zig.
