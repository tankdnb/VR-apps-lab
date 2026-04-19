# VR Projects Wave 75: OpenXR Micro-Layers for View Shaping, Streamout, Debugging Capture, and Frame-Time Intervention

- Date: `2026-04-20`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `OpenXR micro-layers`, `view shaping`, `streamout`,
  `debugging capture`, and `frame-time intervention`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of OpenXR templates, runtime
inspectors, and larger utility platforms, but it still lacked a clearer answer
to
`what the best small, operator-facing, or developer-facing OpenXR layers look like`.

This wave exists to make that family clearer:

- per-app recenter and crop layers;
- layers that bootstrap settings from a template or application name;
- stream-out layers that bridge rendered output outward;
- developer-tool bridge layers around frame lifecycle;
- heavier frame-intervention layers split into explicit processing stages.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with OpenXR micro-layer, view-shaping, stream-out, and debug
   capture queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `rublev/OpenXR-RecenterOverride` | Strong donor for per-app recenter override with operator-facing controls |
| `mledour/OpenXR-Layer-crop-fov` | Strong donor for per-app FOV shaping with bootstrapped settings |
| `haraldsteinlechner/openxr_streamout_layer` | Strong donor for output stream-out over swapchain and frame hooks |
| `rAzoR8/openxr-renderdoc-layer` | Strong donor for developer-tool integration around frame lifecycle |
| `fzeruhn/Smoothing-OpenXR-Layer` | Strong comparison donor for staged frame intervention and heavier compute pipelines |

## Deep-pass notes by project

## `rublev/OpenXR-RecenterOverride`

- GitHub:
  [rublev/OpenXR-RecenterOverride](https://github.com/rublev/OpenXR-RecenterOverride)
- What it is:
  an OpenXR API layer that applies recenter overrides with per-app settings,
  logging, and operator-facing controls.
- Why it matters:
  it is the clearest donor in this wave for
  `per-app OpenXR layer with operator micro-controls`.
- Interesting ideas:
  bootstrap config by application name; let tiny keyboard controls and audio
  feedback exist at layer level; keep the override logic inside view-location
  hooks rather than a separate app.
- Interesting implementation choices:
  `OpenXR-RecenterOverride/layer.cpp`
  shows application-name config selection, logging, keyboard handling, and
  pose override inside `xrLocateViews`.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  purpose-built, but exactly the kind of
  `one strong value`
  layer that makes this family useful.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs an
  `operator-facing micro-layer`
  donor.

## `mledour/OpenXR-Layer-crop-fov`

- GitHub:
  [mledour/OpenXR-Layer-crop-fov](https://github.com/mledour/OpenXR-Layer-crop-fov)
- What it is:
  an OpenXR API layer that applies per-app crop and FOV shaping with global
  defaults and local overrides.
- Why it matters:
  it is the clearest donor in this wave for
  `per-app layer config bootstrapped from a global template`.
- Interesting ideas:
  copy settings into app-specific files on first run; keep opt-in enable flags
  local to the app; log and bypass cleanly when disabled.
- Interesting implementation choices:
  `openxr-api-layer/layer.cpp`
  shows application-name resolution, settings bootstrap, per-app log files,
  and FOV or extent modification inside the layer's runtime hooks.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  tightly focused, but unusually mature in how it handles per-app settings and
  safe bypass.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `per-app OpenXR patch layer`
  donor.

## `haraldsteinlechner/openxr_streamout_layer`

- GitHub:
  [haraldsteinlechner/openxr_streamout_layer](https://github.com/haraldsteinlechner/openxr_streamout_layer)
- What it is:
  an OpenXR layer that intercepts frame output and streams rendered data to
  external consumers.
- Why it matters:
  it is the clearest donor in this wave for
  `stream-out layer over swapchain and frame hooks`.
- Interesting ideas:
  treat stream-out as a runtime-side layer concern instead of another app;
  make session and swapchain interception the integration boundary; use a
  transport surface such as websocket streaming rather than only local debug
  output.
- Interesting implementation choices:
  `src/api_layer_streamout.cpp`
  hooks `xrCreateSession`, swapchain lifecycle, and `xrEndFrame`, then routes
  output through a websocket-driven stream-out path.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the graphics path is narrower than a full cross-API product, but the layer
  boundary is very clear.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs an
  `OpenXR output stream bridge`
  donor.

## `rAzoR8/openxr-renderdoc-layer`

- GitHub:
  [rAzoR8/openxr-renderdoc-layer](https://github.com/rAzoR8/openxr-renderdoc-layer)
- What it is:
  an OpenXR layer that integrates RenderDoc capture into XR frame lifecycle.
- Why it matters:
  it is the clearest donor in this wave for
  `developer-tool integration layer around frame lifecycle`.
- Interesting ideas:
  treat external capture tooling as a layer responsibility; resolve graphics
  binding details at session start; trigger capture around frame hooks.
- Interesting implementation choices:
  `src/Layer.cpp`
  hooks session creation and frame boundaries, identifies the graphics API
  device context, and coordinates RenderDoc start or stop behavior.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  developer-tool specific, but exactly the kind of narrow integration layer
  that expands what API layers can do.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `tool-bridge OpenXR layer`
  donor.

## `fzeruhn/Smoothing-OpenXR-Layer`

- GitHub:
  [fzeruhn/Smoothing-OpenXR-Layer](https://github.com/fzeruhn/Smoothing-OpenXR-Layer)
- What it is:
  a heavier Vulkan and CUDA-based OpenXR layer for motion smoothing and frame
  intervention.
- Why it matters:
  it is the clearest comparison donor in this wave for
  `staged frame-intervention layer`
  rather than a tiny runtime patch.
- Interesting ideas:
  split frame intervention into explicit pipeline stages; keep queueing,
  bypass, synthesis, optical flow, and stereo adaptation visible in separate
  components.
- Interesting implementation choices:
  the repo's `openxr-api-layer` plus its synthesizer, optical-flow, pose-warp,
  and related components make the layer readable as a processing pipeline
  instead of one giant hook body.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  broad and technically deep enough that the repo remains
  `Partially studied`
  even after this pass.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a stronger
  `advanced frame-intervention`
  comparison.

## Main takeaways from Wave 75

- `OpenXR micro-layer donors` split more cleanly into:
  - `per-app operator-facing override layer`
  - `per-app view-shaping layer with bootstrapped settings`
  - `stream-out transport layer`
  - `developer-tool bridge layer`
  - `staged frame-intervention layer`
- The strongest lesson from this wave is that
  `OpenXR API layer`
  is not only a template or compatibility surface. It can be a productized
  micro-utility, a developer-tool bridge, or a research-grade frame pipeline.
- Another strong lesson is that the best small layers make application identity
  and configuration first-class rather than burying everything in one global
  toggle.

## Reusable methods clarified by this wave

- `Per-application OpenXR layer that bootstraps local config from a global template and exposes operator micro-controls`
- `Frame-lifecycle OpenXR layer that plugs external tools or transports into swapchain and session hooks`

## Recommended next moves after this wave

1. Treat `OpenXR-RecenterOverride` and `OpenXR-Layer-crop-fov` as the clearest
   donors in this wave for
   `per-app operator-facing utility layers`.
2. Treat `openxr_streamout_layer` and `openxr-renderdoc-layer` as strong
   donors for
   `tool or transport integration around frame lifecycle`.
3. Keep `Smoothing-OpenXR-Layer` visible whenever `VR-apps-lab` needs an
   `advanced intervention layer`
   comparison, but remain honest that it is still only partially normalized at
   this depth.
