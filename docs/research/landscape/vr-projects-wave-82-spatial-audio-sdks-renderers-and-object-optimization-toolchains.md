# VR Projects Wave 82: Spatial Audio SDKs, Renderers, and Object-Optimization Toolchains

- Date: `2026-04-20`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `spatial audio SDKs`, `renderers`, and `object-optimization toolchains`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of overlays, media surfaces, and
runtime tooling, but it still lacked a clearer answer to:

`what reusable audio-engine patterns exist under the UI layer when the problem is spatialization, ambisonics, or spatial-audio object budgets`.

This wave exists to make that family clearer.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with spatializer, ambisonics, binaural, and spatial-audio
   object queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `microsoft/spatialaudio-unity` | Strong donor for native DSP spatializer packaging inside Unity |
| `videolabs/libspatialaudio` | Strong architecture reference for a unified renderer spanning multiple spatial-audio models |
| `GoogleChrome/omnitone` | Strong donor for ambisonic decoding and binaural rendering in the browser |
| `VoidXH/Cavern` | Broad audio framework with source-listener semantics, filtering, and immersive layout tooling |
| `carbonengine/spatial-audio-clustering` | Strong donor for reducing spatial-audio object count through clustering without abandoning spatial intent |

## Deep-pass notes by project

## `microsoft/spatialaudio-unity`

- GitHub:
  [microsoft/spatialaudio-unity](https://github.com/microsoft/spatialaudio-unity)
- What it is:
  a cross-platform Unity spatializer plugin with native DSP code, packaging
  scripts, and a sample scene.
- Why it matters:
  it is the clearest donor in this wave for
  `engine spatializer package with explicit native DSP boundary`.
- Interesting ideas:
  keep the native DSP code, sample app, packaging scripts, and Unity-facing
  integration together in one repo; support both Windows and Android with the
  same higher-level plugin story; treat sample scenes as part of the integration
  story, not just marketing.
- Interesting implementation choices:
  `SpatializerPlugin.cpp`
  shows the Unity audio-plugin boundary clearly: distance attenuation is
  captured separately, HRTF sources are acquired through `HrtfWrapper`, and
  stereo passthrough vs full spatialization is decided inside
  `ShouldSpatialize`; the sample script `SpatializeOnOff.cs`
  keeps the engine-facing toggle minimal.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  this repo is Unity-first and plugin-build-heavy, so its main reuse value is
  in packaging and DSP boundaries rather than as a VR app reference.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `native spatializer inside an engine`
  baseline.

## `videolabs/libspatialaudio`

- GitHub:
  [videolabs/libspatialaudio](https://github.com/videolabs/libspatialaudio)
- What it is:
  a C++ library for spatial audio encoding, decoding, object rendering, speaker
  rendering, and binauralization.
- Why it matters:
  it is the clearest architecture reference in this wave for
  `one renderer abstraction spanning many spatial-audio models`.
- Interesting ideas:
  unify HOA, objects, speaker feeds, and binaural output under one
  `Renderer` concept; treat standards such as ADM and IAMF as applications of
  the renderer rather than as separate hard-coded subsystems; expose both theory
  and implementation docs as part of the reusable donor surface.
- Interesting implementation choices:
  the repo's documentation makes the architecture unusually legible: the same
  `Renderer` class is positioned as the gateway for HOA, object, speaker, and
  binaural paths, while the docs explicitly separate conceptual background from
  implementation references.
- Code donor value:
  medium-high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  the repo is broad and library-first, so it is only partially exhausted by
  this pass and deserves a deeper future study if `VR-apps-lab` needs a fuller
  audio-renderer donor.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `unified spatial audio renderer`
  comparison.

## `GoogleChrome/omnitone`

- GitHub:
  [GoogleChrome/omnitone](https://github.com/GoogleChrome/omnitone)
- What it is:
  a Web Audio API ambisonic decoder and binaural renderer for first-order and
  higher-order ambisonics.
- Why it matters:
  it is the clearest donor in this wave for
  `web ambisonic rendering with explicit audio-graph structure`.
- Interesting ideas:
  keep channel routing, rotation, and convolution as explicit modules; expose
  rendering mode switching between `ambisonic`, `bypass`, and `off`; make
  camera-linked or input-linked rotation a public API concern.
- Interesting implementation choices:
  `foa-renderer.js`
  builds a clear graph out of `FOARouter`, `FOARotator`, and `FOAConvolver`,
  while the renderer keeps `setRotationMatrix*` and `setRenderingMode`
  explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  browser codec support and multichannel media decode remain external
  constraints, so the repo is strongest as an audio-graph donor rather than a
  complete browser product template.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `web ambisonics`
  baseline.

## `VoidXH/Cavern`

- GitHub:
  [VoidXH/Cavern](https://github.com/VoidXH/Cavern)
- What it is:
  a broad C# audio framework spanning immersive rendering, filtering,
  calibration, measurement, and Unity integration.
- Why it matters:
  it is the clearest broad-framework comparison node in this wave for
  `source-listener audio architecture plus immersive layout tooling`.
- Interesting ideas:
  keep `Listener` and `Source` semantics close to familiar engine patterns while
  still supporting immersive layouts and upmixing; treat calibration,
  virtualization, and remapping as first-class parts of the audio framework;
  expose quick-start usage that reads like an engine subsystem, not a research
  paper.
- Interesting implementation choices:
  `Listener.cs`
  shows how layout loading, symmetry checks, renderer selection, and source
  attachment all live inside one explicit listener object; the broader file tree
  shows dedicated branches for filters, remapping, rendering, and channel
  configuration.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the repo is extremely broad and not VR-specific, so this pass only partially
  exhausts it.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a broad
  `immersive audio framework`
  comparison.

## `carbonengine/spatial-audio-clustering`

- GitHub:
  [carbonengine/spatial-audio-clustering](https://github.com/carbonengine/spatial-audio-clustering)
- What it is:
  a Wwise object processor plugin that clusters nearby spatial audio objects to
  reduce system object consumption.
- Why it matters:
  it is the clearest donor in this wave for
  `audio object budget optimization without throwing away spatial intent`.
- Interesting ideas:
  cluster audio objects by distance threshold and reuse output objects across
  frames; keep unclustered outputs for objects that should remain separate;
  treat object count as an optimization surface that can be productized.
- Interesting implementation choices:
  `ObjectClusterFX.cpp`
  makes the lifecycle explicit: prepare input objects, map them to cluster
  outputs, reuse prior output objects where possible, then clear and refill
  output buffers according to current cluster state; K-means is used as a live
  object-management strategy, not just an offline analysis step.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  the repo is Wwise-specific and game-audio-first, so its main reuse value is
  in optimization strategy rather than direct drop-in VR tooling.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `spatial audio object budget`
  reference.

## Main takeaways from Wave 82

- `Spatial audio substrate`
  now splits more cleanly into:
  - `native engine spatializer package`
  - `unified multi-model renderer library`
  - `browser ambisonic renderer`
  - `broad immersive audio framework`
  - `spatial audio object budget optimizer`
- The strongest lesson from this wave is that many reusable audio ideas live
  under the visible UX layer. They show up as renderer abstractions, listener
  models, DSP plugin boundaries, or live object-budget management.
- Another strong lesson is that some of the best donors here are not
  VR-exclusive repos, but they still matter because they solve the exact audio
  substrate problems future VR tools may need.

## Reusable methods clarified by this wave

- `Cross-platform engine spatializer package with native DSP plugin boundary and engine-facing sample integration`
- `Unified spatial audio renderer that spans HOA, object, speaker, and binaural models behind one top-level abstraction`
- `Switchable web ambisonic renderer with explicit channel routing, rotation, and rendering-mode control`
- `Broad immersive audio framework that keeps listener or source semantics while exposing filters, remapping, and calibration`
- `Spatial audio object-clustering processor that reuses output objects and collapses dense sound fields into centroid-driven groups`

## Recommended next moves after this wave

1. Treat `spatialaudio-unity` as the clearest
   `native engine spatializer`
   donor in this wave.
2. Keep `libspatialaudio` and `Cavern` visible as deeper future passes when
   `VR-apps-lab` needs richer audio substrate references.
3. Keep `spatial-audio-clustering` visible whenever a future branch needs
   `audio object budget optimization`
   rather than ordinary mixing.
