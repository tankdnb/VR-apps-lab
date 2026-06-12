# Wave 267 - Source-Light OpenVR/SteamVR Overlay, Tweak, and HUD Variants

This wave studies small or source-light overlay-related repositories. The goal
is not to promote every overlay name into a donor, but to classify what they
contribute: minimal OpenVR texture submission, game HUD intent, Unity overlay
project shells, or MR image-overlay UX references.

## Scope

The wave was bounded to compact overlay and overlay-like projects:

- README-only or near-empty OpenVR/SteamVR overlay ideas;
- Unity SteamVR overlay/tweak project shells;
- minimal native OpenVR overlay texture loops;
- Quest MR image/heatmap panel overlays;
- source-light triage and artifact hygiene.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `bwmcadams/vorpal` | README-only game overlay idea | Source-light | Elite Dangerous VR overlay intent without implementation evidence |
| `UpsilonScorpi/VRP-Overlay` | README-only overlay placeholder | Source-light | Minimal placeholder with no donor code |
| `LapisGit/OVRTweaks` | Unity/SteamVR overlay project shell | Partially studied | SteamVR-heavy Unity project with overlay/tweak intent but mostly vendor/sample payload |
| `JasonPKnoll/vr_overlay` | Minimal native OpenVR overlay | Studied | Tiny C/rawdraw/OpenVR texture submission loop attached to a controller |
| `pouya-codes/VR_overlay` | Quest MR image overlay demo | Studied with caveats | Unity scripts for passthrough H&E plus heatmap overlay, opacity, and hand/controller toggles |

## Code-Level Findings

### `bwmcadams/vorpal`

- Interesting idea:
  proof-of-concept Elite Dangerous VR overlay.
- Code donor value:
  none in the inspected default branch beyond README intent.
- Product reference value:
  useful only as evidence that game-specific micro-HUD overlays recur as a
  product need.
- What to inspect next:
  branches, releases, or linked projects with implementation.
- Caveats:
  README-only; do not count as donor code.

### `UpsilonScorpi/VRP-Overlay`

- Interesting idea:
  placeholder for an overlay project.
- Code donor value:
  none found.
- Product reference value:
  only a source-light classification example.
- What to inspect next:
  releases or alternate branches.
- Caveats:
  README-only and marked "do not modify" in French.

### `LapisGit/OVRTweaks`

- Interesting idea:
  SteamVR tool/overlay intended to enhance the VR experience with useful or
  fun features.
- Code donor value:
  partial at most; the inspected tree is mostly Unity project settings, XR
  settings, and a large bundled SteamVR plugin/sample payload rather than
  clearly separated bespoke overlay logic.
- Product reference value:
  useful as a cautionary example for overlay project intake: name and README
  are not enough if custom source is not isolated.
- What to inspect next:
  branches, releases, scene objects, custom namespaces, or commits that
  separate original overlay/tweak code from Valve sample assets.
- Caveats:
  vendor-heavy Unity project; do not copy or classify as a strong overlay
  donor until custom code is identified.

### `JasonPKnoll/vr_overlay`

- Interesting idea:
  demonstrate the smallest possible native OpenVR overlay loop: create an
  OpenGL texture, draw a desktop window, and submit it as an overlay.
- Code donor value:
  strong as a minimal baseline for OpenVR C API use, `VR_InitInternal` as an
  overlay app, function-table lookup, `CreateOverlay`, width/color/texture
  bounds, OpenGL texture setup, `glCopyTexImage2D`, `SetOverlayTexture`, and
  tracked-device-relative placement on the left controller.
- Product reference value:
  excellent tiny implementation baseline for "how little code can show pixels
  in VR".
- What to inspect next:
  shutdown, event loop exit, texture lifetime, error returns, controller
  selection, overlay key naming, and build hygiene.
- Caveats:
  includes a binary executable in the repository, has no robust shutdown, and
  `has_associated_overlay` is not initialized before use.

### `pouya-codes/VR_overlay`

- Interesting idea:
  a Quest 3 mixed-reality image panel for a pathology image with an aligned AI
  heatmap overlay, opacity controls, and hand/controller toggles.
- Code donor value:
  useful for layered image sprites, `CanvasGroup` opacity, heatmap visibility
  toggles, controller cooldowns, hand pinch/grab gesture hooks, passthrough
  layer creation, and image-pair switching model.
- Product reference value:
  useful narrow UX reference for "show aligned annotation over an image in
  MR" even though it is not a general overlay framework.
- What to inspect next:
  real texture loading for image-pair switching, Quest passthrough opacity,
  Meta XR SDK version, panel placement/grab behavior, and clinical-data
  privacy language.
- Caveats:
  README content is mixed with dataset documentation, some scripts are
  placeholders, and OVR APIs make it Meta/Quest-specific.

## Reusable Pattern Extraction

- Pattern candidate:
  source-light overlay and HUD triage boundary.
- Problem solved:
  overlay searches return many project names with little or mixed source. A
  useful research pass must separate README-only ideas, vendor-heavy shells,
  minimal donors, and narrow product references.
- Reusable core:
  source evidence level, overlay API boundary, texture submission path, input
  or placement model, artifact hygiene, product intent, and donor/reference
  classification.
- Source evidence:
  README-only `vorpal` and `VRP-Overlay`, vendor-heavy `OVRTweaks`, minimal C
  OpenVR loop in `vr_overlay`, and Quest MR heatmap panel in `VR_overlay`.
- Abstraction boundary:
  a project can still be useful if it is source-light, but only as product
  demand evidence or triage data unless it exposes inspectable implementation.
- What not to copy:
  checked-in binaries, uninitialized state, vendor plugin payloads as original
  code, placeholder docs, or mixed clinical/demo material without cleanup.
- Method catalog action:
  create a method for source-light overlay intake and minimal donor
  classification.

## Family Placement

This wave creates a source-light OpenVR/SteamVR overlay variant family. It
overlaps with OpenVR overlay micro-surfaces and overlay media micro-surfaces,
but its main value is classification rigor around thin, messy, or placeholder
overlay projects.

## Backlog Impact

- Add a source-light overlay matrix comparing README-only, vendor-heavy,
  minimal native, and MR image-panel cases.
- Deepen `JasonPKnoll/vr_overlay` as a minimal OpenVR overlay baseline if a
  native overlay sample is needed.
- Keep `OVRTweaks` partial until custom overlay/tweak code is separated from
  bundled SteamVR content.
