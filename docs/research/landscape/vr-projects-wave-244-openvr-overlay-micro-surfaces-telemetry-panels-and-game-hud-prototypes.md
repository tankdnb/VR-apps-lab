# VR Projects Wave 244: OpenVR Overlay Micro-Surfaces, Telemetry Panels, and Game HUD Prototypes

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies small overlay surfaces: legacy OpenVR overlay skeletons,
desktop telemetry panels that can inspire VR micro-panels, controller-attached
OpenVR textures, playspace landmark overlays, and game-log-driven HUDs.

## Why It Matters For `VR-apps-lab`

The repository already treats overlays as one of its strongest product
families. This wave adds smaller, sharper references for overlay lifecycle,
texture submission, telemetry polling, edit-mode placement, autostart
manifests, and external event feeds. The main value is not the apps as finished
products, but the reusable shell patterns around tiny always-available
surfaces.

## Project Notes

### `Sch1nken/VRChatOverlay`

- Interesting idea:
  a minimal OpenVR overlay can be understood as a small loop around runtime
  init, overlay creation, device-relative placement, event polling, and texture
  upload.
- Code donor value:
  `main.cpp` initializes OpenVR as `VRApplication_Overlay`, creates an overlay,
  comments dashboard overlay and keyboard options, enumerates tracked devices,
  applies a tracked-device-relative transform, sets width and alpha, shows the
  overlay, polls overlay events, draws through SFML/OpenGL, and submits pixels
  back to the overlay. The README also calls out absolute overlays,
  controller-relative overlays, dashboard overlays, moving overlays, keyboard
  input, and future chat plugin architecture.
- Product reference value:
  useful as an old but readable overlay mental model for a beginner-friendly
  OpenVR overlay tutorial.
- What to inspect next:
  compare its raw texture upload and SFML loop against newer Vulkan/C# overlay
  examples and existing overlay donors.
- Architecture pattern:
  OpenVR overlay app -> tracked-device transform -> SFML render texture ->
  overlay event loop -> texture submit.
- Reusable method:
  keep the overlay lifecycle tiny and explicit before adding product logic.
- Caveats:
  early prototype quality, flicker noted by README, no complete chat backend,
  and legacy OpenVR/OpenGL assumptions.

### `ObnubiladO/vram-overlay`

- Interesting idea:
  even a non-VR desktop overlay can be a strong reference for telemetry
  micro-panel UX: transparent, topmost, draggable, hotkey-toggleable, and
  locally configurable.
- Code donor value:
  the WPF app creates a transparent borderless topmost window, hides it from
  the taskbar, supports left-drag movement, exposes a right-click menu, toggles
  visibility through an F8 global hotkey, polls GPU process memory every
  second, uses `PerformanceCounter` for dedicated/shared GPU memory, falls back
  to WMI adapter memory counters, and persists settings to
  `%LOCALAPPDATA%\GpuMemoryOverlay\settings.json`.
- Product reference value:
  strong micro-utility reference for telemetry panels that should be small,
  legible, configurable, and low-friction.
- What to inspect next:
  map its desktop-panel settings model to VR overlay equivalents: transform,
  scale, opacity, refresh interval, color, and hide/show binding.
- Architecture pattern:
  timer-polled telemetry source -> compact transparent panel -> hotkey and
  context-menu controls -> local JSON settings.
- Reusable method:
  treat telemetry overlays as tiny persistent instruments with explicit
  fallback data providers.
- Caveats:
  not a VR runtime overlay, Windows-only WPF/PerformanceCounter assumptions,
  and process-memory counters are not the same as total VRAM budgeting.

### `Spacefish/OpenVR-Overlay`

- Interesting idea:
  a modern C# OpenVR overlay can submit Vulkan textures directly while keeping
  overlay creation, event polling, input method, and controller attachment in a
  small wrapper class.
- Code donor value:
  `VR.cs` wraps OpenVR initialization. `VROverlay.cs` creates an overlay, sets
  width, sets mouse input, starts an async polling task, fixes the overlay to a
  controller, submits `VRVulkanTextureData_t` through `Texture_t` with Vulkan
  instance/device/queue/image metadata, enables dashboard control-bar flags,
  polls mouse events, throttles haptic pulses, and handles dispose/hide/cancel
  cleanup.
- Product reference value:
  useful donor for C# overlay prototypes that want to avoid older OpenGL-only
  examples.
- What to inspect next:
  compare with the repository's previous OpenVR overlay donors around texture
  lifetime, dashboard visibility, and haptic feedback boundaries.
- Architecture pattern:
  C# OpenVR wrapper -> Vulkan texture bridge -> controller-relative overlay ->
  mouse event/haptic feedback loop.
- Reusable method:
  isolate graphics API texture submission behind one overlay wrapper.
- Caveats:
  example-level app key and overlay identity, unsafe/Vulkan complexity, and
  no broader product shell around settings or recovery.

### `lukis101/VRPoleOverlay`

- Interesting idea:
  a physical playspace landmark can be represented as a configurable overlay
  with in-VR edit mode, controller snap, drag adjustment, fade, and chaperone
  awareness.
- Code donor value:
  `Program.cs` initializes OpenVR as an overlay app, checks overlay/application
  interfaces, optionally writes a SteamVR autostart manifest, creates and
  configures an overlay, caches chaperone data, updates based on HMD refresh
  cadence, and exposes console keys for reload and edit mode. The edit mode
  handles trigger press/unpress, double-press snap-to-controller, hold-drag
  fine adjustment, and settings save. `Configuration.cs` validates color,
  transparency, height, diameter, fade distance, drag scale, image path, and
  chaperone-derived values. `OpenVRUtilities.cs` writes a `.vrmanifest` and
  toggles autolaunch.
- Product reference value:
  strong donor for calibration/edit-mode overlays and physical-environment
  helpers.
- What to inspect next:
  compare controller-snap placement with wrist/menu overlay placement and
  room/chaperone offset handling in prior overlay waves.
- Architecture pattern:
  settings file -> OpenVR overlay -> chaperone-aware placement -> edit-mode
  controller interaction -> autostart manifest.
- Reusable method:
  make in-headset placement an explicit mode with snap, drag, save, reload,
  and chaperone-change handling.
- Caveats:
  physical pole use case is niche, OpenVR/SteamVR-specific, and the code needs
  careful handling around playspace offsets and OVRAS-style space drag.

### `AArchAngel/Remlok-HUD`

- Interesting idea:
  a game-specific HUD can be driven by external journal/log files instead of
  game memory hooks, turning filesystem events into overlay state.
- Code donor value:
  Unity scripts poll for the Elite Dangerous process, watch the journal folder
  with `FileSystemWatcher`, read the newest journal file with shared access,
  parse JSON event lines, classify mission types, maintain mission lists, sort
  by distance/reward/time, download cartographic data, update mission UI, and
  speak voice prompts through a Windows voice helper.
- Product reference value:
  useful product reference for log-driven HUDs, mission dashboards, and voice
  feedback surfaces.
- What to inspect next:
  compare this file-watch model with notification overlays, log monitors, and
  server-driven overlay feeds already in the repository.
- Architecture pattern:
  process gate -> file watcher -> event parser -> mission model -> HUD and
  voice feedback.
- Reusable method:
  for game or tool companions, prefer external event/log feeds before invasive
  hooks when the data is available.
- Caveats:
  hardcoded local paths, old Unity/network API usage, game-specific data
  dependencies, and asset-heavy OVRLay coupling.

## Reusable Pattern Extraction

- Pattern candidate:
  overlay micro-surface lifecycle with telemetry, placement, and external-feed
  boundaries.
- Problem solved:
  small VR utility overlays need to stay understandable while still handling
  placement, texture updates, settings, input, external data, and lifecycle
  cleanup.
- Reusable core:
  runtime initialization, overlay identity, transform placement, texture source,
  event polling, small config schema, hide/show/edit controls, optional
  autostart, telemetry or log ingestion, and explicit cleanup.
- Source evidence:
  `Sch1nken/VRChatOverlay`, `ObnubiladO/vram-overlay`,
  `Spacefish/OpenVR-Overlay`, `lukis101/VRPoleOverlay`, and
  `AArchAngel/Remlok-HUD`.
- Abstraction boundary:
  keep runtime overlay plumbing separate from graphics texture generation,
  placement/edit state, data ingestion, and product-specific rendering.
- What not to copy:
  hardcoded local paths, legacy OpenGL assumptions as a default, old game data
  endpoints, app keys copied verbatim, or desktop-only topmost behavior as a VR
  overlay substitute.
- Method catalog action:
  add a method entry for overlay micro-surface lifecycle boundaries.

## Follow-Up Gaps

- Build a compact OpenVR overlay lifecycle matrix across C++, C#, Vulkan,
  OpenGL, dashboard, and controller-relative examples.
- Extract an overlay settings schema for transform, opacity, scale, refresh
  interval, hotkeys, and edit-mode state.
- Compare log-driven HUDs with notification overlays and local server-driven
  overlay feeds.
