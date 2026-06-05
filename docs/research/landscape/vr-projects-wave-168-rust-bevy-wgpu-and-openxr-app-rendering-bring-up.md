# VR Projects Wave 168: Rust, Bevy, wgpu, and OpenXR App/Rendering Bring-Up

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 168 studies application-side OpenXR bring-up in Rust: engine plugin
boundaries, render-loop ownership, wgpu/Vulkan interop, OpenXR runtime stubs,
and live network data visualization inside XR panels.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `awtterpip/bevy_oxr` | Bevy OpenXR plugin donor | Strong render/session lifecycle donor |
| `leetvr/hotham` | Rust XR engine/test harness donor | Strong context-split and runtime-stub donor |
| `blaind/xrbevy` | Bevy OpenXR architecture caution | Useful legacy design reference |
| `matthewjberger/wgpu-example` | wgpu/OpenXR graphics binding donor | Strong low-level bring-up reference |
| `robotics-erlangen/xrvis` | Live-data XR visualization reference | Strong network-to-panel UX reference |

## `awtterpip/bevy_oxr`

- Interesting idea:
  package OpenXR lifecycle and Bevy render-world integration as plugins that
  can own the XR session, graphics binding, frame loop, views, actions, and
  optional features such as passthrough, hands, and overlay examples.
- Code donor value:
  high for Bevy plugin boundaries, OpenXR init resources, session state event
  handlers, render extract resources, swapchain lifecycle, and custom
  `RenderPlugin` creation around OpenXR-provided wgpu objects.
- Product reference value:
  high for future Bevy-based XR utility prototypes and Rust OpenXR app shells.
- What to inspect next:
  compare its `OxrInitPlugin` and `OxrRenderPlugin` with smaller raw OpenXR
  samples to isolate the minimum viable plugin contract.
- Source evidence:
  `crates/bevy_openxr/src/lib.rs`,
  `crates/bevy_openxr/src/openxr/init.rs`,
  `crates/bevy_openxr/src/openxr/render.rs`, and examples such as
  `overlay.rs`, `raw_actions.rs`, and `sessions.rs`.
- Reusable pattern extraction:
  Bevy OpenXR render-plugin lifecycle with manual wgpu device/queue handoff.
- Reusable core:
  initialize OpenXR instance/system/session first, create graphics-bound wgpu
  device and queue, inject them into Bevy rendering, then schedule XR frame
  wait, view location, camera spawning, swapchain image wait/release, and
  end-frame work as explicit render stages/resources.
- Do not copy directly:
  broad fast-moving Bevy/OpenXR crate code without pinning Bevy, wgpu, and
  OpenXR crate versions.
- Caveats:
  engine integration code is version-sensitive and larger than a minimal tool
  needs.

## `leetvr/hotham`

- Interesting idea:
  split a mobile Rust VR engine into explicit contexts for XR, Vulkan, render,
  audio, GUI, haptics, input, physics, and ECS world state, plus provide an
  OpenXR runtime/client stub for testing loader interactions.
- Code donor value:
  high for context construction order, Android event pre-processing, focused
  OpenXR update loops, HMD/stage entity setup, and runtime shim entry points.
- Product reference value:
  medium-high for building a small reusable XR engine harness or OpenXR test
  environment.
- What to inspect next:
  isolate the runtime stub into a minimal loader negotiation/reference note and
  compare against OpenXR validation/runtime test tooling.
- Source evidence:
  `hotham/src/engine.rs`, `hotham/src/lib.rs`, and
  `hotham-openxr-client/src/lib.rs`.
- Reusable pattern extraction:
  context-split Rust XR engine with stage/HMD entities and focused-state tick
  loop; OpenXR runtime stub through loader negotiation and function pointer
  shims.
- Reusable core:
  build contexts in dependency order, create durable stage/HMD ECS entities,
  update XR views/input only when the session is focused, and expose a small
  fake runtime surface through `xrNegotiateLoaderRuntimeInterface` plus
  function pointer dispatch for frame, input, and session calls.
- Do not copy directly:
  complete engine architecture or bundled mobile assumptions into unrelated
  utilities.
- Caveats:
  source sync reported Git LFS pointer warnings for image assets; source files
  used for the pass were available.

## `blaind/xrbevy`

- Interesting idea:
  document an older Bevy/OpenXR architecture that exposes the hard parts:
  global OpenXR state, custom swapchains, Vulkan/wgpu handle ownership,
  hand-tracker state, and renderer transfer boundaries.
- Code donor value:
  medium for architecture cautions and naming/ownership lessons, not for
  current implementation copying.
- Product reference value:
  medium as a design-history reference for future Bevy XR work.
- What to inspect next:
  compare these notes with `bevy_oxr` to identify which early design problems
  were resolved by newer Bevy render-world APIs.
- Source evidence:
  `docs/architecture.md` and `src/lib.rs`.
- Reusable pattern extraction:
  Bevy OpenXR architecture caution around renderer/backend ownership.
- Reusable core:
  treat OpenXR instance/session/swapchain handles as first-class ownership
  boundaries and avoid hiding low-level renderer state behind unclear globals.
- Do not copy directly:
  legacy API assumptions.
- Caveats:
  legacy/precursor project; useful mainly as an architecture warning.

## `matthewjberger/wgpu-example`

- Interesting idea:
  show explicit OpenXR graphics bring-up for a wgpu application, including
  Android and desktop paths, Vulkan graphics requirements, runtime-created
  Vulkan instance/device, and swapchain creation.
- Code donor value:
  high for low-level graphics binding order and for exposing OpenXR-created
  Vulkan objects to wgpu HAL.
- Product reference value:
  high for diagnostics or micro-tools that need a minimal non-engine OpenXR
  rendering path.
- What to inspect next:
  extract a step-by-step OpenXR/wgpu graphics binding checklist and compare it
  with C++/Vulkan OpenXR samples.
- Source evidence:
  `src/xr.rs` and `src/lib.rs`.
- Reusable pattern extraction:
  explicit wgpu/OpenXR/Vulkan bridge with runtime-created Vulkan
  instance/device.
- Reusable core:
  require `KHR_vulkan_enable2`, query graphics requirements, let OpenXR create
  Vulkan objects, bridge the physical device into wgpu HAL, and keep Android
  app event polling separate from the XR render loop.
- Do not copy directly:
  sample-level unsafe graphics code without a narrow target and validation.
- Caveats:
  small sample; useful for bring-up order more than product architecture.

## `robotics-erlangen/xrvis`

- Interesting idea:
  convert live network state into spatial XR panels and field visualizations,
  using Bevy XR interaction for pointer picking and controller-ray UI input.
- Code donor value:
  high for multicast discovery, UDP/WebSocket/protobuf ingestion, panel
  spawning, and ray-to-texture/UI pointer mapping.
- Product reference value:
  high for future diagnostics dashboards, telemetry overlays, robot/control
  panels, and live-data VR viewers.
- What to inspect next:
  separate the domain-specific robot soccer protocol from the generic live
  data panel and picking architecture.
- Source evidence:
  `xrvis-vr/src/interaction/picking.rs`,
  `sslgame/src/network_tasks.rs`, and
  `xrvis-vr/src/panels/game_state.rs`.
- Reusable pattern extraction:
  live network data to XR panels with multicast discovery, protobuf streams,
  and ray-to-UI pointer forwarding.
- Reusable core:
  discover/refresh network interfaces, ingest live packets on background tasks,
  normalize state into resources, spawn panels near meaningful spatial anchors,
  sort ray hits by distance, and keep pointer focus while dragging.
- Do not copy directly:
  robot-soccer protocol logic unless building that exact viewer.
- Caveats:
  domain-specific data model; interaction and ingestion patterns are the real
  donor value.

## Cross-Project Lessons

- Rust OpenXR tooling has at least three useful layers: raw graphics bring-up,
  engine plugin integration, and runtime/test harness shims.
- Bevy integration is powerful but version-sensitive; future donors should
  extract contracts, not wholesale plugin internals.
- wgpu/OpenXR examples are valuable because they expose graphics object
  ownership that engine samples often hide.
- Live telemetry viewers are a strong product branch for `VR-apps-lab`: they
  combine network ingestion, spatial panels, and pointer UX without needing a
  full consumer app.
