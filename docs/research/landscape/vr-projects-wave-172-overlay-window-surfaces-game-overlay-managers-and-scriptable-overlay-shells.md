# VR Projects Wave 172: Overlay Window Surfaces, Game Overlay Managers, and Scriptable Overlay Shells

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 172 studies overlay implementation substrates: Electron/React OpenVR
overlays, injected window-surface managers, modular SteamVR driver/overlay
umbrellas, game-specific OpenXR overlay engines, Unity overlay baselines, and
scriptable overlay product framing.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `imagitama/react-electron-openvr` | Browser-backed OpenVR overlay donor | Strong implementation donor |
| `KotRikD/steamvr-overlay` | Injected overlay/window manager donor | Strong IPC/surface donor with risk caveats |
| `RealWhyKnot/WKOpenVR` | Modular driver/overlay utility shell | Strong architecture donor |
| `SableVII/Sable-Overlay` | Unity modular boundary overlay reference | Medium Unity/module/settings donor |
| `Alphasumsi/Honey_Overlays` | Game-specific OpenXR overlay manager donor | Very strong architecture and UX donor |
| `Ikeiwa/VRMocapOverlay` | Unity OpenVR overlay baseline | Medium baseline/event-loop donor |
| `4x8Matrix/Hoku` | Scriptable overlay product reference | Product reference only; source-light |

## `imagitama/react-electron-openvr`

- Interesting idea:
  expose OpenVR overlays as Electron windows and React components, using
  offscreen rendering plus Windows NT shared texture handles to submit browser
  UI into SteamVR.
- Code donor value:
  high for overlay surface lifecycle, offscreen paint handling, native shared
  texture submission, and declarative React props for overlay creation/update.
- Product reference value:
  high for browser-backed utility panels, quick dashboards, media/chat panels,
  and internal overlay tooling.
- What to inspect next:
  test only in a future prototype branch whether shared-handle submission is
  robust enough for modern Electron/OpenVR versions.
- Source evidence:
  `electron-openvr/main-src/overlays/create.ts`,
  `addon/src/overlay.cpp`, and React overlay component sources.
- Reusable pattern extraction:
  Electron offscreen shared-texture overlay lifecycle with native OpenVR
  submission.
- Reusable core:
  create a transparent offscreen `BrowserWindow`, enable shared texture
  painting, pass the native handle to a small OpenVR addon, set overlay mouse
  scale/input mode, and keep overlay lifecycle declarative from React props.
- Do not copy directly:
  Windows-only shared texture assumptions or arbitrary overlay HTML without a
  tighter preload/security boundary.
- Caveats:
  early-stage package, Windows-specific rendering path, and native addon
  maintenance burden.

## `KotRikD/steamvr-overlay`

- Interesting idea:
  manage overlay-like game windows through a Node/Rust stack that injects a
  DLL into a target process, then controls window position, anchor, margins,
  shared handles, input listening, input blocking, and cursor behavior through
  typed IPC.
- Code donor value:
  high for the command model and typed request boundaries; lower for direct
  reuse because process injection is intentionally high-risk.
- Product reference value:
  medium-high for external overlay managers that need to expose explicit
  window/input operations.
- What to inspect next:
  compare its request schema against OpenVR overlay and OpenXR layer control
  protocols before designing any generic overlay engine contract.
- Source evidence:
  `packages/core/native/src/overlay.rs` and `crates/common/src/request.rs`.
- Reusable pattern extraction:
  injected overlay surface manager with typed IPC and explicit input capture
  controls.
- Reusable core:
  model window operations as requests, keep per-window IDs, separate shared
  handle updates from position/input commands, and make input blocking an
  explicit user-visible capability rather than an implicit side effect.
- Do not copy directly:
  DLL injection or target-process hooks into safe companion tools.
- Caveats:
  injection/anti-cheat and process-boundary risk; strongest value is the API
  shape, not the invasive deployment path.

## `RealWhyKnot/WKOpenVR`

- Interesting idea:
  package multiple SteamVR utility modules behind one driver/overlay umbrella,
  using flag files, safety markers, per-module pipes, shared memory, logs, and
  ImGui tabs to keep experimental features controllable.
- Code donor value:
  very high for modular feature-shell architecture, feature safety gates,
  pipe-channel boundaries, debug tools, and driver/overlay split.
- Product reference value:
  high for a future `VR utility suite` direction where modules share one
  trusted host rather than multiplying driver DLLs.
- What to inspect next:
  turn the feature plugin contract into a reusable `utility module host`
  template for overlays and runtime helpers.
- Source evidence:
  `core/src/overlay/main.cpp`,
  `FeaturePlugin.h`, `FeatureFlags.cpp`, protocol headers, and pipe names.
- Reusable pattern extraction:
  umbrella SteamVR driver/overlay with flag-gated modules and safety
  auto-disable.
- Reusable core:
  expose modules through a common interface, gate activation through marker
  files and safety state, isolate module IPC through named pipes/channels, show
  module tabs in one overlay, and keep dev tools/logs close to each feature.
- Do not copy directly:
  driver-specific assumptions, process-global hook constraints, or module
  implementations without license/dependency review.
- Caveats:
  complex umbrella architecture; valuable but should be reduced before reuse.

## `SableVII/Sable-Overlay`

- Interesting idea:
  present a SteamVR boundary utility as a Unity modular overlay with separate
  module interfaces, module setting UI, persisted JSON settings, and boundary
  visualization controls.
- Code donor value:
  medium for Unity overlay module organization, setting UI contracts, OSC
  controller hooks, and saved setting structure.
- Product reference value:
  high for small focused utilities where boundaries, centers, walls, colors,
  widths, and sensitivity need user-facing tuning.
- What to inspect next:
  extract the module/settings schema without inheriting the bundled SteamVR
  package weight.
- Source evidence:
  `Assets/Sable Overlay/Runtime`, module interfaces, `BoundaryModule.cs`,
  `OverlaySettingsModule.cs`, `OverlayLogModule.cs`, `OSC Controller.cs`, and
  `Assets/Saved Settings/Boundary Module.json`.
- Reusable pattern extraction:
  Unity overlay dashboard with modular feature panels and human-readable JSON
  settings.
- Reusable core:
  define a module interface, keep module settings UI separate from runtime
  logic, serialize tuned values to JSON, and provide log/settings modules
  beside the feature module.
- Do not copy directly:
  full vendor package contents or sparse project framing.
- Caveats:
  README is thin and the repo includes large package/vendor context.

## `Alphasumsi/Honey_Overlays`

- Interesting idea:
  build a game-specific OpenXR overlay engine for iRacing with a WPF editor,
  hidden browser hosts, window capture, D3D11 composition quads, named-pipe
  JSON control, per-car/session layouts, and in-headset place/edit controls.
- Code donor value:
  very high for editor/runtime split, pipe protocol, hidden WebView/browser
  source management, Windows Graphics Capture, OpenXR layer composition, and
  VR placement UX.
- Product reference value:
  very high for serious overlay tooling: source status, per-context layouts,
  quick VR placement, recentering, keybinds, and source lifecycle management.
- What to inspect next:
  extract a generic overlay-manager architecture that separates layout editor,
  capture source, runtime engine, and VR placement controls.
- Source evidence:
  `engine/openxr-api-layer/engine_link.cpp`,
  `engine/openxr-api-layer/layer.cpp`, WPF browser-host manager code, layout
  models, and README architecture notes.
- Reusable pattern extraction:
  external editor plus OpenXR layer engine with hidden browser/window capture
  and length-prefixed JSON pipe.
- Reusable core:
  keep the editor outside the XR process, send bounded JSON commands over a
  named pipe, run non-blocking pipe reads in the layer, spawn one hidden browser
  host per source, capture windows into D3D11 textures, compose quad layers, and
  provide trigger/modifier-based in-VR placement.
- Do not copy directly:
  iRacing-specific app gates, app-specific input semantics, or Windows-only
  capture code without abstraction.
- Caveats:
  game-specific, Windows/D3D11-heavy, and much larger than a micro-utility.

## `Ikeiwa/VRMocapOverlay`

- Interesting idea:
  use a Unity camera/render texture pipeline plus OpenVR overlay handlers to
  display mocap-related content as dashboard or scene overlays.
- Code donor value:
  medium for old but readable Unity/OpenVR overlay prefabs, event polling, and
  overlay handler structure.
- Product reference value:
  medium for motion-capture visualization overlays and Unity overlay samples.
- What to inspect next:
  compare against newer Unity overlay patterns before using as a baseline.
- Source evidence:
  `Unity_Overlay.cs`, `OVR_Overlay_Handler.cs`, and `OVR_Handler_Events.cs`.
- Reusable pattern extraction:
  Unity render-texture-to-OpenVR overlay prefab with dashboard/event handling.
- Reusable core:
  register overlays from Unity components, submit render textures, configure
  dashboard thumbnails/visibility/device tracking, poll OpenVR events, and
  surface dashboard/standby/quit callbacks.
- Do not copy directly:
  legacy OVRLay-derived code without modernization.
- Caveats:
  older Unity/OpenVR style and sparse project context.

## `4x8Matrix/Hoku`

- Interesting idea:
  frame an OpenVR overlay engine as a Luau-driven system with 2D testing,
  OpenGL integration, and VR overlay support.
- Code donor value:
  currently low because the public repository is source-light.
- Product reference value:
  medium for scriptable overlay-engine framing and rapid UI iteration.
- What to inspect next:
  revisit if runtime/source code lands or if Luau/OpenGL integration becomes
  available.
- Source evidence:
  repository README and project framing.
- Reusable pattern extraction:
  scriptable overlay engine concept for separating overlay content logic from
  native runtime glue.
- Reusable core:
  keep this as a product-direction note: scripting can make overlay experiments
  faster if the native surface/runtime boundary is small and stable.
- Do not copy directly:
  roadmap claims without implementation.
- Caveats:
  not a current code donor.

## Cross-Project Lessons

- Overlay reuse is less about "show a quad" and more about surface ownership,
  capture source, input routing, update cadence, pose model, and lifecycle
  safety.
- Browser-backed overlays and hidden browser hosts are strong product patterns
  when paired with a native texture bridge.
- Invasive overlay paths should be documented as architecture references, not
  promoted as safe default implementation choices.
- Modular overlay suites need explicit feature gates, status/log surfaces, and
  rollback/safety markers.
- In-headset placement is a reusable UX pattern: grab/move/scale/opacity/cycle
  controls can be product-defining for overlay utilities.
