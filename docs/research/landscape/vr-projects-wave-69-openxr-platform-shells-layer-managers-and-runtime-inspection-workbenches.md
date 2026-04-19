# VR Projects Wave 69: OpenXR Platform Shells, Layer Managers, and Runtime Inspection Workbenches

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `OpenXR platform shells`, `layer managers`, and
  `runtime inspection workbenches`.

## Why this wave exists

`VR-apps-lab` already had strong coverage of runtime switchers and template
repos, but it still lacked a sharper answer to
`what larger OpenXR utility platforms look like once they own more than one task`.

This wave exists to make that family clearer:

- plugin-manifest runtime or overlay platforms;
- desktop shells that own pairing and session state;
- API layers that rewrite runtime behavior;
- runtime explorers that share one data model across GUI and CLI;
- lint-and-fix tools for layer-store hygiene.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with OpenXR platform, layer manager, and runtime explorer
   queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `vrkit-platform/vrkit-platform` | Strong donor for plugin-manifest runtime or overlay platform architecture |
| `clear-xr/clearxr-server` | Strong donor for desktop shell plus OpenXR layer plus XR landing-space trifurcation |
| `maluoi/openxr-explorer` | Strong donor for shared GUI plus CLI runtime inspection |
| `fredemmott/OpenXR-API-Layers-GUI` | Strong donor for lint-and-fix API-layer management |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `mbucchia/OpenXR-Layer-Template` | Already valuable as a template donor, but not the main point of this deeper pass |
| `Ybalrid/OpenXR-API-Layer-Template` | Useful comparison node, but weaker than the shortlisted repos for platform lessons |

## Deep-pass notes by project

## `vrkit-platform/vrkit-platform`

- GitHub:
  [vrkit-platform/vrkit-platform](https://github.com/vrkit-platform/vrkit-platform)
- What it is:
  a broader OpenXR and overlay utility platform with a plugin system, native
  and web-tech components, service-daemon slices, and OpenXR-facing demo code.
- Why it matters:
  it is the clearest donor in this wave for
  `plugin-manifest runtime or overlay platform with service sidecars`.
- Interesting ideas:
  declare plugin components through a manifest; let overlay-capable modules sit
  beside service daemons; keep native and desktop-host concerns visible instead
  of burying them in one app entry point.
- Interesting implementation choices:
  `docs/Design/PluginSystem/Plugin System Design.md`
  exposes `vrkit-plugin.json5`, plugin clients, and component-manager
  contracts,
  `packages/cpp/app-cli/src/ServiceDaemonArgCommand.cpp`
  shows daemon-owned services such as telemetry and track maps, and
  `packages/cpp/app-openxr-demo/src/OpenXrProgram.cpp`
  shows the OpenXR-facing side of the platform.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  still broad, but this pass was strong enough to narrow the value to its
  plugin and service architecture rather than treating the whole monorepo as an
  undifferentiated shell.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `plugin-manifest runtime or overlay platform`
  donor.

## `clear-xr/clearxr-server`

- GitHub:
  [clear-xr/clearxr-server](https://github.com/clear-xr/clearxr-server)
- What it is:
  a runtime-side utility platform split across a desktop streamer or session
  host, an OpenXR API layer, and an XR landing-space application.
- Why it matters:
  it is the clearest donor in this wave for
  `desktop shell plus API layer plus XR landing app`.
- Interesting ideas:
  let session and pairing lifecycle live in a desktop host; keep input or
  runtime patching inside the layer; let the landing-space app own XR-side
  interaction and environment.
- Interesting implementation choices:
  `clearxr-streamer/src/session_management.rs`
  models pairing, session state, and process control,
  `clearxr-layer/src/lib.rs`
  intercepts OpenXR action-state flow, and
  `clearxr-space/src/xr_session.rs`
  makes the landing-space app's extension and action setup visible.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  broader than a pure diagnostic tool, but unusually valuable because the
  runtime split is explicit and modern.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `runtime-side utility platform with multiple cooperating processes`
  donor.

## `maluoi/openxr-explorer`

- GitHub:
  [maluoi/openxr-explorer](https://github.com/maluoi/openxr-explorer)
- What it is:
  an OpenXR runtime explorer and runtime switch helper that reuses one
  information model across GUI and CLI surfaces.
- Why it matters:
  it is the clearest donor in this wave for
  `shared runtime inspection model across GUI and CLI`.
- Interesting ideas:
  keep runtime enumeration, manifest handling, and active inspection data in
  one model; let both GUI and CLI consume the same tables; store user runtime
  overrides separately from the baked-in runtime list.
- Interesting implementation choices:
  `src/common/xrruntime.cpp`
  handles runtime discovery and defaults,
  `src/openxrexplorer/openxr_info.cpp`
  constructs inspection tables by actually probing runtime state, and
  `src/openxrexplorer/app_cli.cpp`
  reuses the same data instead of inventing a separate command-line model.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  more inspector-focused than platform-focused, but important because it shows
  the strongest current `doctor` pattern.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs an
  `OpenXR doctor/runtime inspector`
  donor.

## `fredemmott/OpenXR-API-Layers-GUI`

- GitHub:
  [fredemmott/OpenXR-API-Layers-GUI](https://github.com/fredemmott/OpenXR-API-Layers-GUI)
- What it is:
  a desktop GUI that reads layer stores, snapshots loader state, lints layer
  configuration, and offers fix-up actions.
- Why it matters:
  it is the clearest donor in this wave for
  `lint-and-fix layer manager rather than a raw list editor`.
- Interesting ideas:
  treat layer state as something to validate and repair; keep fixable warnings
  first-class; snapshot loader environment before and after state resolution.
- Interesting implementation choices:
  `src/GUI.cpp`
  exposes tabbed layer-store editing,
  `src/Linter.cpp`
  registers lint rules and fix strategies, and
  `src/LoaderData.cpp`
  models loader-state snapshots including enabled layers and environment data.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  very Windows-centric, but still one of the best `repair-oriented diagnostics`
  donors in the OpenXR ecosystem.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `layer-state linter and fixer`
  donor.

## Main takeaways from Wave 69

- `OpenXR utility platforms` split more cleanly into:
  - `plugin-manifest runtime or overlay platform`
  - `desktop session host plus API layer plus landing-space app`
  - `shared GUI plus CLI runtime inspector`
  - `layer-store linter and fixer`
- The strongest lesson from this wave is that
  `runtime utility`
  is not one category. Platform shells, inspectors, and repair-oriented tools
  all solve different slices of the same problem space.
- Another strong lesson is that the best donors explicitly model state:
  plugin manifests, session state, loader snapshots, and runtime tables are all
  treated as first-class data rather than hidden implementation details.

## Reusable methods clarified by this wave

- `Plugin-manifest runtime or overlay platform with service-daemon sidecars`
- `Desktop XR shell split across session host, OpenXR API layer, and XR landing-space app`
- `OpenXR inspector or layer manager that shares one loader-state model across GUI, CLI, linting, and fix flows`

## Recommended next moves after this wave

1. Treat `vrkit-platform` as the clearest donor in this wave for
   `plugin-manifest utility platform`.
2. Treat `clearxr-server` as the strongest donor for a
   `desktop shell plus API layer plus XR-side app`
   split.
3. Keep `openxr-explorer` visible whenever `VR-apps-lab` needs a stronger
   `OpenXR doctor`
   reference.
4. Keep `OpenXR-API-Layers-GUI` visible whenever a future branch needs a
   `repair-oriented layer manager`
   donor.
