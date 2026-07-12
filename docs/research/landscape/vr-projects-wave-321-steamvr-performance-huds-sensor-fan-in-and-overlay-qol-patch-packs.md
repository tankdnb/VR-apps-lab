# Wave 321 - SteamVR Performance HUDs, Sensor Fan-In, and Overlay QoL Patch Packs

This wave studies small but dense overlay utilities: a SteamVR performance HUD
with multiple sensor providers and an XSOverlay patch pack that names many
real-world overlay friction points.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- OpenVR/SteamVR performance HUDs with explicit data-provider and renderer
  seams;
- XSOverlay tweak/patch projects that reveal overlay UX pain points;
- projects not already tracked in registry/families.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Karlan-Trade/VR-Performance-Profiler` | SteamVR performance HUD and sensor fan-in | Studied | Strong donor for OpenVR overlay manager, D3D/Direct2D rendering, HWiNFO/MSI/SteamVR provider fan-in, metric aggregation, and settings/tray split |
| `chaixshot/xsoverlay-tweak` | XSOverlay QoL patch pack | Studied | Strong product/UX reference for refresh-rate overrides, pointer, wrist, keyboard, haptics, overlay attach, and WebView friction patches |

## Code-Level Findings

### `Karlan-Trade/VR-Performance-Profiler`

- Interesting idea:
  a useful VR performance HUD is a sensor fan-in pipeline plus a headset
  placement surface, not just a text overlay.
- Code donor value:
  high. `OverlayManager` isolates OpenVR overlay lifecycle, default overlay
  flags, visibility, width/alpha, and DirectX texture submission.
  `MetricAggregator` normalizes usable readings and applies preference scoring
  for categories such as RAM, GPU memory, and power. `app.cpp` shows SteamVR
  readiness probing, process checks, configured metric selection, and
  settings/tray integration.
- Product reference value:
  high for performance HUDs, device monitors, runtime diagnostic panels, and
  operator overlays.
- What to inspect next:
  renderer text layout, web settings window, HWiNFO/MSI provider details, and
  failure UX when SteamVR or sensor providers are unavailable.
- Reusable pattern extraction:
  keep `sensor provider`, `metric aggregator`, `configured selection`,
  `renderer`, `overlay manager`, and `settings/tray UI` separate.

### `chaixshot/xsoverlay-tweak`

- Interesting idea:
  a patch pack is valuable research evidence because it names concrete overlay
  friction points users care about: pointer feel, keyboard state, wrist panel
  placement, haptics, overlay attach behavior, WebView stability, and frame
  rate.
- Code donor value:
  medium. The BepInEx/Harmony plugin enumerates many targeted patch modules,
  but direct reuse is limited because patches are app-internal and version
  fragile.
- Product reference value:
  very high. The patch taxonomy is a strong backlog generator for future
  overlay tools: pointer double-click delay, two-handed mode, trigger lock,
  wrist state restore, keyboard holding indicators, overlay anti-slip, curve
  refresh, toolbar gestures, WebView frozen fixes, and SteamVR compositor
  texture-format fixes.
- What to inspect next:
  individual patch classes for reusable UX principles, not direct code reuse.
- Reusable pattern extraction:
  treat patch packs as a friction map and compatibility warning surface.

## Reusable Pattern Extraction

- Pattern candidate:
  VR operator HUD boundary across telemetry providers, aggregation, user metric
  selection, renderer, overlay placement, and tray/settings control.
- Problem solved:
  performance utilities become brittle when provider-specific readings,
  renderer layout, overlay lifecycle, and user settings are tangled together.
- Reusable core:
  provider adapters, reading normalization, category preference scoring,
  configured metric selection, overlay renderer, runtime overlay manager,
  settings/tray control, and failure-state reporting.
- Source evidence:
  `Karlan-Trade/VR-Performance-Profiler` and `chaixshot/xsoverlay-tweak`.
- Abstraction boundary:
  keep telemetry collection separate from headset rendering, and keep patch
  packs as UX evidence unless their seams are stable.
- What not to copy:
  runtime/app-internal patches as stable APIs, hidden sensor selection rules, or
  overlay HUDs that fail silently when provider data is absent.
- Method catalog action:
  add a VR performance/operator HUD fan-in method.

## Follow-Up Gaps

- Compare HWiNFO/MSI/SteamVR fan-in with other battery/device monitor overlays.
- Build an XSOverlay friction matrix for pointer, keyboard, wrist, haptic,
  overlay attach, and WebView behaviors.
- Revisit patch-pack safety when app/runtime updates change internal symbols.
