# VR Projects Wave 73: WayVR Ecosystem Add-ons, Linux Dashboard Extensions, and IPC-Backed Overlay Surfaces

- Date: `2026-04-20`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on the
  `WayVR ecosystem`, `Linux dashboard extensions`, and
  `IPC-backed overlay surfaces`.

## Why this wave exists

`VR-apps-lab` already had Linux overlay control shells and browser-backed
overlay runtimes in scope, but it still lacked a clearer picture of the
`ecosystem around one Linux desktop-in-VR host`
where compositor core, dashboard, protocol crate, and scripted panel extensions
live in separate repos.

This wave exists to make that family clearer:

- compositor-capable host cores;
- external dashboards over explicit local IPC;
- standalone IPC crates that carry the host protocol;
- panel or script extensions that mutate live overlay content.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with WayVR, Linux dashboard, and overlay-host IPC queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `oo8dev/wayvr` | Strong donor for an embedded compositor as a VR app-surface host |
| `oo8dev/wayvr-dashboard` | Strong donor for an external dashboard client over explicit IPC |
| `oo8dev/wayvr-ipc` | Strong donor for a standalone overlay-host protocol crate |
| `noideaman/WayvrWalltaker` | Strong donor for script and panel-XML extensions over a larger host |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `devnet82-ship-it/wivrn-stack-control` | Adjacent Linux XR control surface, but not as directly useful for the WayVR host ecosystem itself |

## Deep-pass notes by project

## `oo8dev/wayvr`

- GitHub:
  [oo8dev/wayvr](https://github.com/oo8dev/wayvr)
- What it is:
  a Rust Wayland compositor and display host intended to surface Linux apps
  inside a VR overlay environment.
- Why it matters:
  it is the clearest donor in this wave for
  `embedded compositor as VR app-surface provider`.
- Interesting ideas:
  use a real compositor core instead of remote-desktop capture; keep window,
  display, and composition concerns explicit; treat VR surfaces as a host
  runtime that other repos can extend.
- Interesting implementation choices:
  `src/lib.rs`
  and the surrounding modules expose client, display, compositor, and window
  layers while the repo's use of `smithay` and related graphics crates makes
  the compositor boundary explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  archived and folded into another project lineage, but still an unusually
  valuable donor for host architecture.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs an
  `embedded compositor host`
  donor.

## `oo8dev/wayvr-dashboard`

- GitHub:
  [oo8dev/wayvr-dashboard](https://github.com/oo8dev/wayvr-dashboard)
- What it is:
  a `Tauri` plus `Preact` dashboard app that speaks to WayVR through a defined
  IPC client.
- Why it matters:
  it is the clearest donor in this wave for
  `dashboard client over a local overlay-host protocol`.
- Interesting ideas:
  keep operator UX in a separate desktop app; expose host capabilities through
  frontend commands; let the dashboard evolve independently from the compositor
  core.
- Interesting implementation choices:
  `src-tauri/src/main.rs`
  shows environment setup and host connection while
  `src-tauri/src/frontend_ipc.rs`
  exposes commands for apps, games, devices, and host information through
  `wayvr_ipc::client::WayVRClient`.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  archived and merged back into the host line, but still a strong donor for
  `dashboard over IPC`
  patterns.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `desktop dashboard client over local-socket VR host protocol`
  donor.

## `oo8dev/wayvr-ipc`

- GitHub:
  [oo8dev/wayvr-ipc](https://github.com/oo8dev/wayvr-ipc)
- What it is:
  the standalone IPC crate that defines the WayVR protocol and client-side
  transport behavior.
- Why it matters:
  it is the clearest donor in this wave for
  `separate protocol crate for an overlay-host ecosystem`.
- Interesting ideas:
  keep host protocol separate from any one dashboard app; use a handshake,
  queued request or response model, and signals over local sockets.
- Interesting implementation choices:
  `src/client.rs`
  shows socket setup, handshake flow, serial request queueing, and signal
  handling instead of burying that logic in one consumer app.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  very protocol-focused, but that is precisely why it matters.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `host protocol crate`
  donor rather than another monolithic app.

## `noideaman/WayvrWalltaker`

- GitHub:
  [noideaman/WayvrWalltaker](https://github.com/noideaman/WayvrWalltaker)
- What it is:
  a small WayVR extension that uses panel XML plus shell scripts to pull live
  media into a WayVR panel.
- Why it matters:
  it is the clearest donor in this wave for
  `script and panel XML extension over a larger VR host`.
- Interesting ideas:
  declare a panel surface in XML; bind buttons to shell helpers; use a
  websocket-plus-download loop to update live content without modifying the
  host core.
- Interesting implementation choices:
  `walltaker.xml`
  defines the panel structure while
  `walltaker.sh`, `walltakerctl.sh`, and `walltakerconfig.sh`
  show websocket subscription, media fetch, and panel update flow.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium-high.
- Caveats:
  narrow and shell-driven, but exactly the kind of `small host extension`
  donor that larger ecosystems need.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `panel extension and shell script plugin`
  donor.

## Main takeaways from Wave 73

- `WayVR ecosystem donors` split more cleanly into:
  - `embedded compositor core`
  - `external dashboard client`
  - `standalone protocol crate`
  - `panel XML plus script extension`
- The strongest lesson from this wave is that
  `Linux desktop-in-VR host`
  is not one repo or one executable. Core, protocol, dashboard, and extension
  module can all be separate reusable layers.
- Another strong lesson is that host-extension value often lives in small
  scripting surfaces and panel schemas, not only in the host core.

## Reusable methods clarified by this wave

- `Overlay host extension through explicit IPC protocol, dedicated dashboard client, and embeddable compositor core`
- `Panel-XML and script-driven live content module inside a larger VR host`

## Recommended next moves after this wave

1. Treat `wayvr`, `wayvr-dashboard`, and `wayvr-ipc` as one of the clearest
   current donor lines for a
   `host core plus protocol plus dashboard client`
   architecture.
2. Keep `WayvrWalltaker` visible whenever `VR-apps-lab` needs a small but
   honest `panel-extension` reference.
3. Keep this family visible whenever future Linux XR work starts drifting back
   toward monolithic host assumptions.
