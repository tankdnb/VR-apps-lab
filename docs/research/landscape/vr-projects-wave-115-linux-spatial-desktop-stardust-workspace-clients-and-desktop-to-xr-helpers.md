# VR Projects Wave 115: Linux Spatial Desktop, Stardust Workspace Clients, and Desktop-to-XR Helpers

- Date: `2026-06-05`
- Goal: add the next serious GitHub discovery wave for Linux spatial desktop
  repositories, Stardust XR client utilities, virtual monitors, launchers,
  workspace grouping, and compositor-assisted desktop-to-XR bridges.

## Why this wave exists

Desktop-in-VR is not one pattern. It can be a full workspace shell, a panel
bridge for Wayland apps, a virtual monitor wrapped around the user, an XR app
launcher, a spatial workspace grouping tool, or a companion that mirrors
existing desktop windows through compositor metadata.

This wave studies Linux spatial desktop projects as references for future
panel/window overlays, app launchers, virtual displays, and workspace helpers.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by Linux VR desktop, Stardust client, virtual monitor,
   workspace, launcher, xrdesktop, and picom companion families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `SimulaVR/Simula` | Full Linux VR desktop/window manager with gaze-active windows, workspace shortcuts, mouse/keyboard grab, and Godot/OpenXR backend glue |
| `StardustXR/flatland` | Stardust client for 2D app panels with pointer/touch input, resize handles, close buttons, panel transfer, and placement |
| `StardustXR/kiara` | Stardust shell that launches Niri and maps a 360-degree virtual monitor/ring into XR |
| `StardustXR/protostar` | Stardust launcher family that parses desktop entries and launches apps into the XR connection environment |
| `StardustXR/magnetar` | Workspace client that groups captured clients/windows into movable cylindrical cells |
| `yshui/picom-xrdesktop-companion` | X11/picom DBus companion that mirrors desktop windows to xrdesktop/gxr/gulkan surfaces |

## Deep-pass notes by project

## `SimulaVR/Simula`

- GitHub:
  [SimulaVR/Simula](https://github.com/SimulaVR/Simula)
- What it is:
  a Linux VR window manager and workspace shell built around Godot, Nix,
  Monado/OpenXR, OpenHMD, xpra, and desktop app surfaces.
- Interesting idea:
  a productivity desktop in VR can use gaze-active windows, keyboard/mouse
  grab state, workspace-level shortcuts, surface grab/move/scale/depth
  controls, webcam view, and display-server isolation as core UX primitives.
- Code-level notes:
  the README documents gaze activation, `Super` shortcuts for grab, terminal,
  cursor-to-gaze, click-at-gaze, surface/workspace grabbing, launcher,
  background cycling, depth/scale/resize/transparency, workspace switching,
  pinning, screenshots, video capture, and config reload. Godot plugin code
  such as `Plugin/VR.hs` initializes OpenXR or OpenHMD backends through
  Godot's ARVR server. `MonadoHudTypes.hs` captures frame timing structures
  useful for diagnostics.
- Code donor value:
  medium-high for full-shell architecture and VR desktop shortcuts.
- Product reference value:
  very high for Linux workspace UX and desktop-in-VR design.
- Caveats:
  full shell scope is large; use as reference, not as a quick donor.
- What to inspect next:
  compare window focus, input grab, and workspace semantics with Stardust
  micro-clients.

## `StardustXR/flatland`

- GitHub:
  [StardustXR/flatland](https://github.com/StardustXR/flatland)
- What it is:
  a Stardust XR client that exposes desktop app surfaces as spatial panels.
- Interesting idea:
  a 2D app panel in XR needs toplevel state, surface reification, pointer and
  touch injection, physical resize handles, close affordances, panel transfer,
  and first-placement heuristics.
- Code-level notes:
  `src/main.rs` manages panel items, toplevel state, size changes, close calls,
  keyboard input, pointer buttons, relative/absolute pointer motion, scroll,
  and touch events. `resize_handles.rs` models hand/pointer grab thresholds,
  corner positioning, pointer-distance adjustment through scroll, and content
  transform updates. `pointer_input.rs`, `touch_input.rs`,
  `close_button.rs`, `panel_shell_transfer.rs`, and
  `initial_panel_placement.rs` show hover planes, selection, scrolling,
  multi-touch, exposure-based close, shell capture/transfer, HMD-relative
  placement, and face-user rotation.
- Code donor value:
  very high for panel/window input and physical affordances.
- Product reference value:
  very high for desktop surface overlays and panel-based utilities.
- Caveats:
  Stardust-specific APIs and Linux desktop assumptions.
- What to inspect next:
  compare with WayVR and xrdesktop families before designing panel helpers.

## `StardustXR/kiara`

- GitHub:
  [StardustXR/kiara](https://github.com/StardustXR/kiara)
- What it is:
  a Stardust app shell that uses Niri with a 360-degree virtual monitor.
- Interesting idea:
  instead of mirroring existing windows one by one, a spatial shell can launch
  an external Wayland compositor and map its virtual monitor around the user.
- Code-level notes:
  `src/main.rs` connects to Stardust, registers item UI, obtains connection
  environment variables, starts `niri` with a config, and kills the compositor
  when the event loop ends. `src/ring.rs` maps pointer, hand, and tip positions
  to virtual screen coordinates on a ring, forwards events to the panel, sets
  toplevel size, and applies surface material.
- Code donor value:
  high for external compositor launch and ring-mapped monitor patterns.
- Product reference value:
  high for virtual monitor shells and spatial workspaces.
- Caveats:
  Stardust and Niri specific; concept is portable, implementation is not.
- What to inspect next:
  compare with flatland for per-panel versus virtual-monitor approaches.

## `StardustXR/protostar`

- GitHub:
  [StardustXR/protostar](https://github.com/StardustXR/protostar)
- What it is:
  a collection of Stardust launchers for desktop applications.
- Interesting idea:
  an XR launcher should parse desktop entries, inherit the XR connection
  environment, create startup tokens, launch apps through systemd or double
  fork, and present app icons in grab-friendly spatial layouts.
- Code-level notes:
  `protostar/src/application.rs` parses desktop entries, strips field codes,
  obtains Stardust connection environment and startup token, and launches apps
  through systemd transient services or shell double-fork fallback.
  `protostar/src/xdg.rs` scans XDG application directories.
  `hexagon_launcher/src/main.rs` loads desktop files, filters `OnlyShowIn`,
  loads icons, sorts apps, and builds a hex launcher surface.
- Code donor value:
  high for launcher plumbing and desktop-entry handling.
- Product reference value:
  high for XR app launchers and utility start surfaces.
- Caveats:
  Linux desktop environment assumptions; not relevant to Windows utilities
  without adaptation.
- What to inspect next:
  reuse as a model for launching helper apps into an XR session environment.

## `StardustXR/magnetar`

- GitHub:
  [StardustXR/magnetar](https://github.com/StardustXR/magnetar)
- What it is:
  a Stardust workspace client that groups clients/windows into movable
  cylindrical areas.
- Interesting idea:
  workspace management can be spatial: captured windows belong to cells, and
  moving the workspace root moves the grouped clients as one unit.
- Code-level notes:
  `src/magnetar.rs` creates a root spatial, cylindrical `Field`, input handler
  queue, cells, field transform/height updates, root Y positioning, and client
  state. `src/cell.rs` creates cell roots, visual rings, zones, queued zoneable
  capture, and parent-in-place capture. `grab_circle.rs` and `ring.rs` provide
  visible input affordances.
- Code donor value:
  high for spatial grouping, zone capture, and workspace-root movement.
- Product reference value:
  high for workspace organization and multi-panel utility layouts.
- Caveats:
  strongly tied to Stardust zone/client semantics.
- What to inspect next:
  compare with Simula workspaces and flatland panels for workspace UX.

## `yshui/picom-xrdesktop-companion`

- GitHub:
  [yshui/picom-xrdesktop-companion](https://github.com/yshui/picom-xrdesktop-companion)
- What it is:
  a Rust companion program that uses picom DBus window metadata and xrdesktop
  to mirror X11 desktop windows into VR/XR space.
- Interesting idea:
  a standalone desktop-to-XR helper can avoid reimplementing all X11 window
  manager logic by asking picom for window state, then passing textures and
  input through xrdesktop/gxr/gulkan.
- Code-level notes:
  `app/src/picom.rs` defines DBus proxies for picom compositor/window signals
  and properties such as window id, client window, mapped state, name, next,
  focus, and type. `app/src/main.rs` manages X11 composite/damage resources,
  GL and gulkan textures, xrdesktop windows, input events, cursor texture
  state, window maps, and cleanup. The README documents early-stage caveats:
  window stacking changes, best-effort raise behavior, no stacking restoration,
  and overlay mode being safer than scene mode.
- Code donor value:
  medium-high for X11 compositor metadata and xrdesktop bridge anatomy.
- Product reference value:
  high for desktop mirroring tradeoffs and caveats.
- Caveats:
  Linux/X11/picom/xrdesktop specific and early-stage; not a general VR desktop
  solution.
- What to inspect next:
  compare with Stardust and Wayland-based approaches when planning desktop
  surface helpers.

## Main takeaways from Wave 115

- Linux desktop-in-XR work splits into full shells, per-panel bridges, virtual
  monitor shells, launchers, workspace grouping, and compositor companions.
- flatland is the strongest donor for panel input and physical affordances.
- kiara and protostar show reusable external compositor/app-launch boundaries.
- magnetar clarifies spatial workspace grouping.
- picom-xrdesktop-companion is valuable mainly for X11 metadata and xrdesktop
  bridge caveats.

## Reusable methods clarified by this wave

- `Linux XR desktop shell with Godot/OpenXR workspace composition`
- `Stardust 2D-app bridge and virtual monitor clients for Linux spatial desktops`
- `Stardust spatial launcher and workspace grouping micro-clients`
- `Picom/XR desktop companion bridge for desktop window surfaces`

## Recommended next moves after this wave

1. Use flatland as the primary Stardust panel/input donor.
2. Use Simula as full-shell UX reference, not as a compact donor.
3. Compare kiara, protostar, and magnetar as smaller spatial desktop
   micro-utility patterns.
4. Keep picom-xrdesktop-companion caveats visible when discussing X11 mirroring.
