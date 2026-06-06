# GitHub Research Wave 217 Backlog

Date: 2026-06-06

Theme: StardustXR client infrastructure, panel protocols, and spatial desktop
microclients.

## Completed In This Wave

- Studied `StardustXR/core` as a Rust workspace for wire messaging, KDL
  protocols, Fusion client abstractions, scenegraph nodes, spatial transforms,
  resources, and async event loops.
- Studied `StardustXR/molecules` as a high-level interaction library with
  grabbables, buttons, touch/hover planes, zones, keyboard/mouse, drop
  handlers, visual debug, and input action queues.
- Studied `StardustXR/asteroids` as a declarative UI layer with state reify,
  element diffing, resource registry, task callbacks, and panel/button
  elements.
- Studied `StardustXR/panel-item` as a protocol and Asteroids integration layer
  for panel items, surface updates, cursor/toplevel/child state, and acceptor
  events.
- Studied `StardustXR/wayland-service` as a Wayland socket/service bridge with
  Vulkan context, binder device, xdg/core/dmabuf protocols, and panel item
  provider registration.
- Studied `StardustXR/gravity` as a spatial launcher that creates a transform,
  obtains connection environment, generates a startup token, and execs another
  application.
- Added a reusable method entry for a spatial desktop client stack.

## Follow-Up Queue

1. Compare StardustXR panel-item and Wayland service boundaries with SteamVR
   overlay and desktop-in-VR projects.
2. Build a matrix for spatial desktop clients: protocol, scenegraph, input,
   UI toolkit, surface bridge, launcher, and persistence.
3. Revisit earlier StardustXR server/flatland waves and link them to this
   client-side stack.
4. Treat `gravity` as a micro-utility reference for future placement-aware
   launchers.
5. Study how StardustXR zones and grabbables could inform non-Linux overlay
   surface placement UX.

## Do Not Spend Time On Yet

- Do not attempt to run StardustXR server, clients, or Wayland service in this
  research repository.
- Do not assume StardustXR APIs are stable product dependencies.
- Do not merge Linux-specific Wayland/binder assumptions into cross-platform
  overlay plans without an adaptation layer.
