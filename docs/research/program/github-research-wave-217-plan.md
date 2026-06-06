# GitHub Research Wave 217 Plan

Date: 2026-06-06

Theme: StardustXR client infrastructure, panel protocols, and spatial desktop
microclients.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

StardustXR is a useful counterpoint to SteamVR/OpenVR overlay thinking. It
models clients, scenegraph objects, fields, panel items, Wayland surfaces, and
spatial launch placement as an XR-native desktop ecosystem rather than a single
overlay app.

Wave 217 studies the client-side StardustXR stack to extract reusable protocol,
interaction, UI, panel, and launcher boundaries.

## Search Families

- Linux spatial desktop and StardustXR clients.
- Scenegraph and client protocol libraries.
- High-level spatial interaction primitives.
- Declarative spatial UI toolkits.
- Wayland-to-spatial-surface services.
- Spatial application launch and placement helpers.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `StardustXR/core` | Workspace containing wire, protocol, fusion, and gluon crates for client/server connection, KDL protocols, scenegraph nodes, spatial objects, fields, input, drawable, audio, camera, and items. | StardustXR protocol/client substrate |
| `StardustXR/molecules` | High-level widget and interaction primitives over Fusion, including grabbable, button, touch/hover planes, keyboard/mouse, drop handlers, zones, and debugging. | Spatial interaction primitives |
| `StardustXR/asteroids` | Declarative UI library for StardustXR with state reification, element diffing, task callbacks, resource registry, and UI elements. | Declarative spatial UI |
| `StardustXR/panel-item` | Panel item protocol crate and Asteroids integration for panel shell/acceptor events and surface updates. | Panel protocol boundary |
| `StardustXR/wayland-service` | Wayland service that binds a socket, Vulkan context, binder device, panel item provider, xdg/core/dmabuf protocols, and Stardust client resources. | Wayland surface bridge |
| `StardustXR/gravity` | Micro-utility that launches apps/clients at a specified spatial transform via startup tokens and connection environment. | Spatial launcher |

## Dedupe Notes

Earlier waves studied `StardustXR/server`, `flatland`, `kiara`, `protostar`,
`magnetar`, and the Linux spatial desktop family. Wave 217 focuses on
client-side libraries and microclient infrastructure not previously captured in
detail.

## Code-Level Pass Targets

- Wire/protocol/fusion/gluon split and generated protocol boundary.
- Client connection, event loop, resources, and spatial root setup.
- Spatial, field, input, drawable, audio, camera, and item abstractions.
- Interaction primitives such as grabbable, button, touch plane, zones, and
  visual debugging.
- Declarative UI state reification and element diffing.
- Panel item provider/acceptor/surface update flow.
- Wayland socket, xdg/core/dmabuf protocol mapping, and panel provider.
- Startup token and spatial placement launcher.

## Expected Outputs

- Wave 217 landscape synthesis.
- Registry/family entries for StardustXR client infrastructure.
- Method catalog entry for a spatial desktop client stack boundary.
- Follow-up backlog for comparing StardustXR against overlay-first desktops.
