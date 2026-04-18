# VR Projects Wave 8: GitHub Search and Source Pass

- Date: `2026-04-18`
- Goal: add a new serious research wave based on GitHub search results that did
  not already exist in the `VR.app` registry, then push the useful findings
  back into the structured research system.

## Why this wave exists

The repository already had a large curated base, but it was still missing a
class of projects that are especially useful for `how to build VR utilities`,
not only `what utility products already exist`.

This wave focused on:

- overlay implementation references;
- SteamVR environment and runtime helper utilities;
- OpenXR overlay utilities;
- small monitoring and support tools;
- micro-utility design patterns.

## Better research workflow used in this wave

Compared with a naive `search everything -> clone everything` approach, this
wave used a tighter process:

1. search GitHub with focused `gh search repos` queries;
2. compare results against the registry;
3. freeze a shortlist;
4. clone only the shortlist into `.research-sources/github/`;
5. inspect code and extract methods;
6. promote the results into the repository structure.

This keeps `VR.app` scalable and makes future waves repeatable.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `sh-akira/VROverlay` | Unity/OpenVR overlay example with controller-to-UI input path |
| `BenWoodford/SteamVR-Webkit` | Browser-backed overlay toolkit with JS interop |
| `beniwtv/vr-streaming-overlay` | Godot-based configurable overlay shell |
| `Nyabsi/steamvr_overlay_vulkan` | Modern C++/Vulkan/ImGui overlay template |
| `Beyley/eepyxr` | OpenXR overlay utility using `EXTX_overlay` |
| `matzman666/OpenVR-MicrophoneControl` | Dashboard micro-utility tied to system audio state |
| `simonowen/dashfix` | Injection-based SteamVR dashboard input fixer |
| `sencercoltu/steamvr-undistort` | Runtime distortion-adjustment tool for custom lenses |
| `W-Drew/SteamVR-Toggle` | Very small desktop-side SteamVR toggle helper |
| `elvissteinjr/SteamVR-VoidScene` | Minimal scene app that supports overlay-heavy workflows |
| `copperpixel/steamvrbattery` | Minimal CLI battery monitor using OpenVR utility mode |

## Deep-pass notes by project

## `sh-akira/VROverlay`

- GitHub:
  [sh-akira/VROverlay](https://github.com/sh-akira/VROverlay)
- What it is:
  a Unity-based SteamVR overlay example that shows a texture and routes
  controller input into Unity UI.
- Why it matters:
  it is a clean example of `legacy Unity + OpenVR overlay + VR UI pointer`
  plumbing in one small repo.
- Interesting ideas:
  invisible quad used as the ray target for overlay interaction; custom
  `BaseInputModule` that maps overlay cursor UVs into Unity UI raycasts.
- Interesting implementation choices:
  creates overlays with per-instance unique keys; updates overlay texture,
  alpha, width, bounds, mouse scale, and absolute transform every frame;
  recovers the overlay handle if it becomes invalid.
- Code donor value:
  medium for Unity-specific overlay interaction.
- Product reference value:
  medium for controller-driven utility UIs.
- Architecture reference value:
  high for Unity/OpenVR overlay lifecycle.
- Caveats:
  built against older Unity and legacy SteamVR plugin assumptions.
- What to inspect next:
  controller cursor smoothing and event routing for more complex UI.

## `BenWoodford/SteamVR-Webkit`

- GitHub:
  [BenWoodford/SteamVR-Webkit](https://github.com/BenWoodford/SteamVR-Webkit)
- What it is:
  a C# toolkit for building SteamVR overlays whose UI is rendered via
  off-screen Chromium/CefSharp.
- Why it matters:
  it demonstrates a `web UI inside VR overlay` method that is still unusual and
  powerful for dashboards and remote-control surfaces.
- Interesting ideas:
  dashboard and in-game overlays from the same toolkit; JS interop modules for
  applications and notifications; optional backside overlay and overlay-to-
  overlay attachment.
- Interesting implementation choices:
  off-screen Chromium rendering to OpenGL textures; explicit attachment model
  (`Absolute`, `Hmd`, `Overlay`, etc.); keyboard routing only when focused node
  needs text; optional non-dashboard input for in-game overlays.
- Code donor value:
  high if `VR.app` ever wants HTML/CSS dashboards.
- Product reference value:
  high for browser-based control surfaces.
- Architecture reference value:
  high for overlay abstraction design.
- Caveats:
  old dependency stack and dated documentation.
- What to inspect next:
  how the test app packages overlay manifests and browser resources.

## `beniwtv/vr-streaming-overlay`

- GitHub:
  [beniwtv/vr-streaming-overlay](https://github.com/beniwtv/vr-streaming-overlay)
- What it is:
  a Godot-based SteamVR overlay project for streamers, built around configurable
  overlays, widgets, and connectors.
- Why it matters:
  it treats overlays as `configurable instances`, not one fixed panel, which is
  very relevant to `VR.app` as a future utility suite.
- Interesting ideas:
  signal-driven overlay lifecycle; per-overlay configuration dictionaries;
  split between overlay config, widgets, and connectors; tracker-relative or
  absolute positioning.
- Interesting implementation choices:
  initializes OpenVR in overlay mode via Godot plugin; creates overlay nodes
  dynamically from saved configuration; re-renders overlays when settings
  change; tracks left/right-hand devices by scanning `ARVRServer`.
- Code donor value:
  medium-high for config-driven overlay systems.
- Product reference value:
  high for streamer/utility overlay suites.
- Architecture reference value:
  high for `overlay shell + widgets + settings` design.
- Caveats:
  project is early-state and tied to Godot OpenVR plugin specifics.
- What to inspect next:
  connector/widget contracts and settings persistence model.

## `Nyabsi/steamvr_overlay_vulkan`

- GitHub:
  [Nyabsi/steamvr_overlay_vulkan](https://github.com/Nyabsi/steamvr_overlay_vulkan)
- What it is:
  a modern C++23 OpenVR overlay template built around Vulkan, ImGui, SDL3, and
  higher-level OpenVR wrappers.
- Why it matters:
  this is one of the strongest `implementation reference` repos in the whole
  new wave.
- Interesting ideas:
  OpenVR-specific ImGui platform backend; optional SDL window backend when a
  desktop window is needed; wrapper class for OpenVR overlay operations;
  explicit dashboard/world overlay examples.
- Interesting implementation choices:
  starts as `VRApplication_Background`; auto-installs manifest when missing;
  syncs update loop to HMD refresh rate; exposes keyboard, mouse, haptics,
  world-relative and device-relative transforms through a typed wrapper.
- Code donor value:
  high for any future C++ overlay work.
- Product reference value:
  medium, because it is a template rather than a finished product.
- Architecture reference value:
  very high.
- Caveats:
  Vulkan-first and newer GPU/toolchain assumptions may be heavier than many
  users need.
- What to inspect next:
  how the custom ImGui OpenVR backend maps pointer and text input events.

## `Beyley/eepyxr`

- GitHub:
  [Beyley/eepyxr](https://github.com/Beyley/eepyxr)
- What it is:
  a Linux OpenXR overlay app designed as a sleep/comfort utility for runtimes
  supporting `EXTX_overlay`.
- Why it matters:
  it is a practical `OpenXR overlay utility` reference rather than only an API
  layer template.
- Interesting ideas:
  overlay priority set to maximum placement; optional process-killer on startup
  to prevent duplicate sessions; system-tray exit path; explicit environment
  blend mode negotiation.
- Interesting implementation choices:
  uses `SDL_OpenXR_LoadLibrary`, dynamic extension discovery, overlay-specific
  session create info, GPU-device creation with XR properties, and alpha-blend
  preference if the runtime supports it.
- Code donor value:
  medium-high for native OpenXR overlay apps.
- Product reference value:
  medium-high for comfort or accessibility overlays.
- Architecture reference value:
  high for OpenXR overlay session bootstrap.
- Caveats:
  Linux-first; depends on `EXTX_overlay`, which is not widely available.
- What to inspect next:
  config system and session/frame loop behavior across different runtimes.

## `matzman666/OpenVR-MicrophoneControl`

- GitHub:
  [matzman666/OpenVR-MicrophoneControl](https://github.com/matzman666/OpenVR-MicrophoneControl)
- What it is:
  a Qt/OpenVR dashboard overlay for muting the microphone and handling
  push-to-talk inside VR.
- Why it matters:
  it is a strong example of a `dashboard micro-utility` that bridges VR controls
  with OS-level functionality.
- Interesting ideas:
  dashboard overlay plus separate HMD-relative notification overlay; persistent
  push-to-talk bindings; system audio control from inside VR.
- Interesting implementation choices:
  renders Qt widgets via `QGraphicsScene` into an FBO, then uploads that as the
  overlay texture; uses `QSettings` for persistence; Windows audio handled
  through `IMMDeviceEnumerator` and `IAudioEndpointVolume`.
- Code donor value:
  medium for Qt/OpenVR apps and system integration.
- Product reference value:
  high for voice, mute, and status utilities.
- Architecture reference value:
  high for `GUI toolkit -> offscreen texture -> dashboard overlay`.
- Caveats:
  deprecated because it was merged into `OpenVR-AdvancedSettings`.
- What to inspect next:
  how notification timing and PTT state changes are surfaced to the user.

## `simonowen/dashfix`

- GitHub:
  [simonowen/dashfix](https://github.com/simonowen/dashfix)
- What it is:
  a Windows utility that fixes unwanted controller/gamepad interference in the
  OpenVR dashboard by injecting a DLL into target processes.
- Why it matters:
  it demonstrates a very practical `runtime hygiene helper` pattern.
- Interesting ideas:
  desktop GUI plus injected DLL split; registry-driven allow/block list; hot
  reconfiguration without restarting the target process.
- Interesting implementation choices:
  watches processes, injects with `CreateRemoteThread + LoadLibraryW`, hooks
  `SDL_JoystickGetAxis`, and zeroes axis movement for blocked devices; listens
  for registry changes to refresh behavior live.
- Code donor value:
  medium-high for process-injection utilities.
- Product reference value:
  high for narrow VR pain-point tools.
- Architecture reference value:
  high for `GUI + injector + shared config` design.
- Caveats:
  Windows-only and intentionally invasive.
- What to inspect next:
  how broadly the hook pattern generalizes beyond SDL controller interference.

## `sencercoltu/steamvr-undistort`

- GitHub:
  [sencercoltu/steamvr-undistort](https://github.com/sencercoltu/steamvr-undistort)
- What it is:
  a SharpDX/OpenVR utility for tuning lens distortion and intrinsics for custom
  spherical lenses.
- Why it matters:
  this is a rare example of a `calibration + rendering adjustment` utility that
  is neither a general overlay nor a driver.
- Interesting ideas:
  in-headset controller-driven calibration workflow; toggling between compositor
  distortion and custom pixel-shader distortion; manual safe export of updated
  configuration.
- Interesting implementation choices:
  D3D11 + OpenVR compositor path; JSON config load/write; hidden mesh and
  controller rendering toggles; distortion math lives in a custom pixel shader.
- Code donor value:
  medium for calibration and rendering-control tools.
- Product reference value:
  medium-high for headset tuning and maker workflows.
- Architecture reference value:
  high for `specialized runtime adjustment utility`.
- Caveats:
  niche use case and older SharpDX stack.
- What to inspect next:
  how coefficient editing and controller interactions are mapped in the UI flow.

## `W-Drew/SteamVR-Toggle`

- GitHub:
  [W-Drew/SteamVR-Toggle](https://github.com/W-Drew/SteamVR-Toggle)
- What it is:
  a tiny AutoHotkey tray utility that enables or disables SteamVR by renaming
  its installation directory.
- Why it matters:
  it is a perfect example of a `small, sharp desktop helper` that solves one
  specific pain point with almost no platform complexity.
- Interesting ideas:
  stateful tray icon; parameterized install path; no direct runtime integration
  required at all.
- Interesting implementation choices:
  filesystem rename as the entire toggle mechanism; tray menu actions remain
  understandable and reversible.
- Code donor value:
  low-medium because the implementation is tiny.
- Product reference value:
  high for micro-utility design.
- Architecture reference value:
  medium for tray-only helpers.
- Caveats:
  brittle if SteamVR lives in unusual paths or if updates change the install
  layout.
- What to inspect next:
  whether a less invasive toggle exists through manifests or Steam settings.

## `elvissteinjr/SteamVR-VoidScene`

- GitHub:
  [elvissteinjr/SteamVR-VoidScene](https://github.com/elvissteinjr/SteamVR-VoidScene)
- What it is:
  a minimal SteamVR scene application that submits a static eye texture in order
  to reduce the cost of SteamVR's default blank space when using overlays.
- Why it matters:
  this introduces a useful pattern that `VR.app` had not documented before:
  `support scene app for overlay-heavy workflows`.
- Interesting ideas:
  use a tiny scene app as a performance helper; expose settings through
  `steamvr.vrsettings`; optional debug-command path to suspend rendering even
  more aggressively.
- Interesting implementation choices:
  registers its own scene-app manifest at startup; uses a 1x1 D3D11 texture as
  both eye textures; has command-line setters for runtime settings; can switch
  between normal loop and debug-command split loop.
- Code donor value:
  medium-high for performance-support helpers.
- Product reference value:
  high for desktop-in-VR and overlay-first use cases.
- Architecture reference value:
  high for `scene host/support app` design.
- Caveats:
  hackier features rely on SteamVR debug commands that could change.
- What to inspect next:
  how this interacts with overlay launch order and app manifests in mixed setups.

## `copperpixel/steamvrbattery`

- GitHub:
  [copperpixel/steamvrbattery](https://github.com/copperpixel/steamvrbattery)
- What it is:
  a basic CLI utility that displays left/right controller battery levels using
  OpenVR utility mode.
- Why it matters:
  it is the smallest clear example in the repo so far of `CLI + OpenVR property
  polling`.
- Interesting ideas:
  utility-mode app instead of overlay; cross-platform build instructions; simple
  update interval and verbose mode.
- Interesting implementation choices:
  detects controller roles, polls `Prop_DeviceBatteryPercentage_Float`, and
  refreshes stdout until exit signals arrive.
- Code donor value:
  medium for device-state polling patterns.
- Product reference value:
  medium for tray/CLI monitors.
- Architecture reference value:
  medium-high for minimal runtime-access tools.
- Caveats:
  only covers controllers and intentionally stays very small.
- What to inspect next:
  whether it can be expanded into a richer inventory or alert tool.

## Repositories discovered in this wave but not yet deeply studied

| Project | Why it matters next |
|---|---|
| `KainosSoftwareLtd/VRSceneOverlay` | Unity scene-overlay sample worth comparing to `VROverlay` |
| `artumino/SteamVR_HUDCenter` | Focused HUD-centering micro-tool |
| `LapisGit/LapisOverlay` | Work-in-progress multi-purpose overlay shell |
| `elvissteinjr/SteamVR-PrimaryDesktopOverlay` | Single-purpose desktop overlay sample from a strong maintainer |
| `Nexz/turncountervr` | Rotation/cable-awareness micro-utility |
| `vrkit-platform/vrkit-platform` | OpenXR monitor and overlay platform |
| `LunarG/OpenXR-Overlays-UE4-Plugin` | Engine-side overlay integration angle |
| `KaftanOS/SteamVR-Battery-Checker` | Charging-state and battery micro-helper |
| `DavidRisch/steamvr_utils` | Linux-side SteamVR helper collection |
| `choyai/SteamVRTrackerUtility` | Tracker power/role utility path |

## Special note on `mbucchia/_ARCHIVE_OverXR`

- GitHub:
  [mbucchia/_ARCHIVE_OverXR](https://github.com/mbucchia/_ARCHIVE_OverXR)
- Discovery result:
  the repository was discovered during this wave and cloned into the local
  cache, but the archive is effectively empty in its current GitHub state.
- Research decision:
  keep it in the registry as a comparison/archive node, but do not promote it as
  a meaningful code donor until there is real code, history, or release content
  to inspect.

## Main conclusions from this wave

1. `VR.app` needed stronger coverage of `implementation reference repos`, not
   only end-user utility products.
2. `SteamVR environment helpers` are now clearly a separate family:
   toggles, dashboard fixes, distortion tools, and support-scene apps.
3. The `web UI overlay` path is strong enough to be treated as a first-class
   method.
4. `OpenXR overlay utilities` should be tracked separately from OpenXR API
   layers and runtime switchers.
5. Future research waves should stay capped and use the local source cache by
   default.
