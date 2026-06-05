# VR Projects Wave 160: Foveated Rendering, Quad-View Settings, and Graphics-Layer Adaptation Helpers

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 160 studies utilities that adapt rendering behavior around existing VR
applications: quad-view settings companions, vendor SDK compatibility shims,
OpenVR DLL wrappers, OpenXR API layers, and Unity native VRS plugins.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `TallyMouse/QuadViewsCompanion` | Quad-view settings companions | Source-light product/settings reference |
| `mbucchia/PimaxMagic4All` | Vendor foveation SDK compatibility layers | Strong architecture donor with caveats |
| `fholger/openvr_foveated` | OpenVR foveated rendering wrappers | Strong low-level donor with compatibility caveats |
| `mbucchia/_ARCHIVE_Varjo-Foveated` | OpenXR quad-view/foveation API layers | Strong archived API-layer reference |
| `ViveSoftware/ViveFoveatedRendering` | Unity native VRS integration | Strong Unity/native split reference |

## `TallyMouse/QuadViewsCompanion`

- Interesting idea:
  wrap a fragile QuadViews settings file in a safer companion UI that can
  create an initial config, load/update existing `settings.cfg`, and rename
  incompatible files to timestamped backups.
- Code donor value:
  low. Public source is not available beyond installers and README-level
  behavior.
- Product reference value:
  medium-high. It shows the value of a narrow settings companion for runtime
  features that otherwise require manual config editing.
- What to inspect next:
  compare its backup, decimal-locale, runtime exclude, and default-discovery
  behavior against Quad-Views-Foveated and OpenXR Toolkit settings UX.
- Architecture pattern:
  source-light companion app for reading runtime defaults, editing user
  settings, handling incompatible config files safely, replacing comma decimal
  separators, and supporting Pimax runtime/app exclusions.
- Reusable method:
  safe config companion for advanced XR runtime/layer settings.
- Caveats:
  source-light, Windows/runtime-specific, and not a code donor unless source is
  published later.

## `mbucchia/PimaxMagic4All`

- Interesting idea:
  emulate enough Pimax/PVR API behavior that Pimax LibMagic dynamic foveated
  rendering can work with non-Pimax headsets.
- Code donor value:
  high for compatibility-layer architecture. It has clear DLL entry points,
  settings, OpenVR/Varjo/OSC eye providers, and detour helpers.
- Product reference value:
  high for "vendor feature adapter" framing, especially the fallback chain from
  headset eye tracking to VRChat OSC/Baballonia-style inputs.
- What to inspect next:
  compare its provider fallback model with VRCFT modules, OpenXR Toolkit, and
  vendor-specific eye tracking utilities.
- Architecture pattern:
  a Windows shim exposes Pimax-facing functions, initializes eye-tracking
  providers, reads settings, attaches to target apps, and fills PVR structures.
  It tries OpenVR, Varjo, and VRChat OSC/Baballonia providers, and can still
  enable fixed foveated rendering without eye tracking.
- Reusable method:
  vendor SDK emulation shim with multi-provider eye-tracking fallback.
- Caveats:
  proprietary Pimax LibMagic dependency, Detours-style hooking, Windows/OpenVR
  assumptions, and invasive compatibility behavior.

## `fholger/openvr_foveated`

- Interesting idea:
  replace a game's `openvr_api.dll` with a wrapper that injects fixed foveated
  rendering into D3D11 SteamVR apps without modifying game code.
- Code donor value:
  high for low-level hook and post-processing architecture.
- Product reference value:
  medium-high. It is a clear example of power-user rendering intervention with
  config, hotkeys, logs, debug capture, and compatibility warnings.
- What to inspect next:
  compare its game-compatibility story with `openvr_fsr`, OpenXR Toolkit, and
  non-invasive engine-side approaches.
- Architecture pattern:
  modified OpenVR loader finds the real `vrclient.dll`, installs IVRSystem and
  IVRCompositor hooks, intercepts `Submit`, hooks D3D11 context methods, and
  applies radial density masking or NVAPI VRS. Config reads `openvr_mod.cfg`
  for ring radii, VRS mode, sharpening, debug mode, and hotkeys.
- Reusable method:
  OpenVR DLL replacement wrapper with D3D11 compositor submission
  post-processing.
- Caveats:
  game compatibility is explicitly hit-or-miss, D3D11-only, invasive, and VRS
  depends on vendor GPU support.

## `mbucchia/_ARCHIVE_Varjo-Foveated`

- Interesting idea:
  use an OpenXR API layer to make apps that support Varjo quad views also use
  Varjo foveated rendering without app code changes.
- Code donor value:
  high as an archived API-layer skeleton for view-chain manipulation and
  frame-flow intervention.
- Product reference value:
  medium. It is archived, but its troubleshooting/logging and installer shape
  are useful references.
- What to inspect next:
  compare its OpenXR `next` chain and FOV patching against Quad-Views-Foveated
  and newer OpenXR Toolkit layer patterns.
- Architecture pattern:
  the layer intercepts `xrCreateInstance`, checks quad-view and foveated
  support, parses settings, modifies `xrEnumerateViewConfigurationViews`
  results, injects `XrFoveatedViewConfigurationViewVARJO`, creates reference
  spaces, toggles foveated flags in `xrLocateViews`, scales focus/peripheral
  FOV and recommended image sizes, and patches projection views in
  `xrEndFrame`.
- Reusable method:
  OpenXR quad-view/foveation API-layer adapter that manipulates view
  configuration and frame submission.
- Caveats:
  archived, Varjo/DCS-specific lineage, advanced OpenXR layer risk, and should
  be treated as architecture reference rather than direct reuse target.

## `ViveSoftware/ViveFoveatedRendering`

- Interesting idea:
  package native D3D11/NVAPI variable rate shading behind a Unity component,
  editor UI, command buffers, and optional eye-tracking support.
- Code donor value:
  high for Unity/native plugin separation and command-buffer placement.
- Product reference value:
  medium-high for engine plugin UX: presets, custom region/rate controls,
  visualization, and capability checks.
- What to inspect next:
  compare Unity command-buffer insertion points with modern XR plugin
  pipelines and OpenXR foveation extensions.
- Architecture pattern:
  Unity scripts expose render mode, shading rate presets, pattern presets,
  custom regions, gaze updater, and visualizer. The component initializes a
  native plugin, attaches command buffers before/after forward or deferred
  passes, and sends plugin events. Native C++ receives Unity D3D11 interfaces,
  initializes NVAPI VRS helper, latches gaze, enables/disables shading rate
  resources, and logs unsupported setup.
- Reusable method:
  Unity component plus native D3D11 VRS plugin split with explicit render-pass
  command-buffer control.
- Caveats:
  older Unity/D3D11/NVIDIA Turing-era dependency profile, SRanipal-specific
  eye tracking, and not a general OpenXR foveation solution.

## Cross-Project Lessons

- Rendering adaptation ranges from safe config companions to invasive DLL/API
  layers; those should not be mixed in one product-risk bucket.
- Foveation tools need fallback UX for missing eye tracking, missing VRS,
  unsupported runtimes, and incompatible games.
- Settings backup and human-readable logs matter as much as the rendering
  trick when users are editing runtime-layer behavior.
- Good donor seams include provider fallback chains, OpenXR view-chain edits,
  OpenVR submission hooks, and Unity native plugin command placement.

## Reusable Methods Extracted

- Safe quad-view settings companion with backup and config sanitation.
- Vendor foveated-rendering SDK emulation shim with multi-provider eye fallback.
- OpenVR DLL replacement foveation wrapper with D3D11 submission hooks.
- OpenXR quad-view/foveation API-layer adapter.
- Unity component plus native VRS plugin command-buffer split.

## Follow-Up Backlog

- Build a rendering-adaptation matrix separating settings companions, API
  layers, DLL wrappers, engine plugins, and vendor SDK shims.
- Compare OpenXR Toolkit, Quad-Views-Foveated, Varjo-Foveated, PimaxMagic4All,
  and OpenVR Foveated by risk surface and reuse posture.
- Keep source-light settings companions as product references only unless source
  becomes available.
