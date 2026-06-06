# VR Projects Wave 217: StardustXR Client Infrastructure, Panel Protocols, and Spatial Desktop Microclients

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-217-plan.md`
- `docs/research/program/github-research-wave-217-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

StardustXR is valuable because it is not merely an overlay implementation. It
models XR desktop work as a stack: wire protocol, scenegraph, spatial nodes,
input fields, interaction primitives, declarative UI, panel protocols, Wayland
surface ingestion, and spatial launch placement. That stack is useful for
future VR utilities even if the target platform is not Linux/StardustXR.

## Project Findings

### `StardustXR/core`

- Interesting idea: Stardust clients share a multi-crate core where wire
  messaging, KDL protocol definitions, generated Fusion wrappers, object
  registry, scenegraph nodes, spatial transforms, and async event loops are
  separate.
- Code donor value: very high as architecture evidence. `wire` defines the
  standard client/server connection, FlatBuffer message format, messenger,
  scenegraph trait, flex serialization, file descriptors, and shared values.
  `protocol` parses KDL IDL into aspects, members, argument types, and
  inheritance. `fusion` exposes `Client`, `ClientHandle`, resources,
  `Root`, `Spatial`, fields, input, drawable, audio, camera, and item
  abstractions.
- Product reference value: very high for XR-native desktop clients and
  service/client split design.
- Architecture pattern: protocol workspace with wire transport, typed protocol
  generation, scenegraph object registry, and spatial client wrappers.
- Reusable method: keep connection/event loop, protocol schema, spatial object
  API, and product UI outside one another.
- Constraints and caveats: Linux/StardustXR ecosystem, async Rust, generated
  protocol code, and server availability assumptions.
- What to inspect next: resource prefix behavior, query streams, object
  registry lifecycle, and item/panel protocol evolution.
- Why it matters for `VR-apps-lab`: it is a strong donor for scenegraph-first
  utility architecture.

#### Reusable Pattern Extraction

- Pattern candidate: spatial desktop client stack with protocol, UI, panel, and
  placement layers.
- Problem solved: XR desktop tools need surfaces, input, placement, lifecycle,
  and app launch without hardwiring everything into a single overlay process.
- Reusable core: wire messaging, protocol schema, typed client wrappers,
  scenegraph/spatial nodes, fields/input, high-level interaction widgets,
  declarative UI diffing, panel item protocol, surface bridge, and startup
  placement token.
- Source evidence: `wire/src/lib.rs`, `protocol/src/lib.rs`,
  `fusion/src/client.rs`, `fusion/src/spatial.rs`, and protocol IDL files.
- Abstraction boundary: protocol/client substrate, interaction primitives, UI,
  surface ingestion, and launcher stay separate.
- What not to copy: Linux-only transport assumptions, unstable APIs, generated
  protocol internals, or server-specific deployment shape.
- Method catalog action: create Method 662.

### `StardustXR/molecules`

- Interesting idea: common XR interactions can be packaged as "molecules" over
  Fusion: grabbables, buttons, hover/touch planes, zones, keyboard/mouse
  bridges, drop handlers, reparenting, and visual debugging.
- Code donor value: high. `grabbable.rs` creates an input handler and content
  spatial, supports pointer modes, magnetism, reparenting, momentum settings,
  linear/angular velocity, and visual debug lines. `button.rs`, touch/hover
  planes, input-action queues, and zone modules provide reusable interaction
  building blocks.
- Product reference value: high for any spatial utility needing grasp, move,
  hover, press, debug, and drop behavior.
- Architecture pattern: high-level interaction primitives over a lower-level
  scenegraph/spatial/input API.
- Reusable method: package invisible interaction fields with debug visuals and
  configurable physics/gesture settings.
- Constraints and caveats: coupled to Fusion/StardustXR and Rust async object
  lifecycle.
- What to inspect next: zone capture rules, keyboard/mouse bridges, and drop
  handler behavior.
- Why it matters for `VR-apps-lab`: it gives vocabulary for reusable spatial
  interaction widgets.

### `StardustXR/asteroids`

- Interesting idea: StardustXR UI can be declarative without macro-heavy usage:
  application state reifies into elements, and the projector diffs dynamic
  element trees into spatial objects.
- Code donor value: high. `Projector` creates element inners recursively,
  stores an element map and resource registry, drains task callbacks, reifies a
  new blueprint, diffs it against old state, and drives per-frame updates.
  Element modules wrap panels, buttons, keyboards, mice, models, lines,
  grabbables, reparentables, and other primitives.
- Product reference value: high for declarative spatial UI and state-driven
  panels.
- Architecture pattern: app state plus reify function plus dynamic diff plus
  resource registry plus per-frame hooks.
- Reusable method: treat spatial UI as a diffable tree while keeping callbacks
  and resources explicit.
- Constraints and caveats: specific to StardustXR/Fusion and Rust UI style.
- What to inspect next: task callback model, migration/resource behavior, and
  panel shell composition.
- Why it matters for `VR-apps-lab`: it is a strong conceptual donor for
  future spatial UI toolkit notes.

### `StardustXR/panel-item`

- Interesting idea: panel surfaces have a dedicated protocol with toplevel,
  child, cursor, geometry, surface update target, keymap, field, and spatial
  reference types, plus an Asteroids shell that receives panel events.
- Code donor value: high. Generated `protocol.rs` defines the external
  protocol and typed data. `asteroids/src/panel_shell.rs` creates a panel shell
  handler, tracks surface update channels for toplevel/cursor, reacts to
  fullscreen/title/app-id/resize/min/max/child/cursor events, and binds item
  output spatial transforms.
- Product reference value: high for desktop-window-in-XR and panel protocol
  design.
- Architecture pattern: protocol crate plus UI toolkit integration plus
  event-channel bridge.
- Reusable method: model panel state as toplevel/child/cursor/surface events
  rather than a single texture blob.
- Constraints and caveats: no README, generated protocol, Stardust-specific
  binder/gluon assumptions.
- What to inspect next: acceptor lifecycle, input event path, and surface
  texture synchronization.
- Why it matters for `VR-apps-lab`: it sharpens the idea of overlay windows as
  protocol-backed panel items.

### `StardustXR/wayland-service`

- Interesting idea: Wayland clients can enter StardustXR through a service that
  owns a Wayland socket, Vulkan context, binder device, panel item provider,
  xdg/core/dmabuf protocol modules, and frame dispatcher.
- Code donor value: high. `main.rs` wires socket path, logging, binder device,
  gluon connection, Stardust `Client`, local resources, async event loop,
  Vulkan context, frame dispatcher, Wayland socket, and `PanelItemProvider`.
  `panel_item_provider.rs` registers acceptors, imports fields from spatial
  IDs, keeps acceptor mappings, and binds provider references to files.
- Product reference value: high for Linux desktop-to-XR surface bridges.
- Architecture pattern: OS compositor protocol service plus XR panel provider.
- Reusable method: separate surface ingestion service from panel UI consumers
  and spatial placement.
- Constraints and caveats: Linux/Wayland/Vulkan/binder specificity, no generic
  cross-platform overlay behavior.
- What to inspect next: dmabuf buffer backing, pointer/keyboard protocols, and
  frame pacing.
- Why it matters for `VR-apps-lab`: it is a strong reference for desktop
  surface ingestion boundaries.

### `StardustXR/gravity`

- Interesting idea: spatial placement can be a tiny launcher: create a spatial
  at x/y/z/yaw, obtain the server connection environment, generate a startup
  token from that spatial root, set environment variables, and exec the target
  command.
- Code donor value: medium-high as a micro-utility. `main.rs` parses x/y/z/yaw
  and command args, connects to Stardust, creates a `Spatial`, starts an async
  event loop, reads connection environment, generates `STARDUST_STARTUP_TOKEN`,
  and `execvp`s the target.
- Product reference value: very high for placement-aware launch UX.
- Architecture pattern: spatial launcher and startup token injector.
- Reusable method: pass spatial context to launched tools through a small,
  explicit startup contract.
- Constraints and caveats: assumes Stardust server and optional Flatland for
  2D apps; current implementation is intentionally tiny.
- What to inspect next: saved layouts, facing-current-user behavior, and
  command validation.
- Why it matters for `VR-apps-lab`: it is a clean micro-utility pattern for
  spawning helper surfaces in known positions.

## Cross-Project Lessons

- Spatial desktop tooling benefits from stack boundaries: protocol, client,
  interaction primitives, UI, panel/surface protocol, and launcher.
- "Overlay window" can be modeled as a protocol object with toplevel, child,
  cursor, input, and update events rather than just a texture.
- High-level interaction primitives should include visual debug toggles because
  many useful widgets are otherwise invisible fields.
- Tiny placement launchers are valuable product references even when they have
  little code.

## Method Catalog Actions

- Added Method 662: spatial desktop client stack with protocol, UI, panel, and
  placement layers.

## Follow-Up Gaps

- Build a StardustXR client-stack matrix that links prior server/flatland
  findings with core/molecules/asteroids/panel/wayland/gravity.
- Compare StardustXR panel protocol with SteamVR overlays, OpenXR composition
  layers, desktop capture overlays, and WebXR DOM/layer surfaces.
- Extract placement-launcher UX rules for future overlay/window utility
  prototypes.
