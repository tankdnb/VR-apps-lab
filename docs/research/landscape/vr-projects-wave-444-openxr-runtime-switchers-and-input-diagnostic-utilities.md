# Wave 444: OpenXR runtime switchers and input diagnostic utilities

## Theme

This wave studies small Windows/OpenXR operator utilities that make runtime
selection and input bring-up visible. The useful pattern is not the UI shell by
itself; it is the combination of runtime manifest discovery, safe switching,
status display, and controller/input probing.

## Shortlist

| Project | Status | Family placement |
|---|---|---|
| `philip0000000/OpenXR-Input-Explorer` | New study | OpenXR runtime/input diagnostics |
| `Teqqles/OpenXRRuntimeSwitcher` | New study | OpenXR runtime switchers |
| `Ybalrid/OpenXR-Runtime-Manager` | Deepened existing node | OpenXR runtime switchers |
| `jonyrh/OXR_Switcher` | Deepened existing node | OpenXR runtime switchers |

## Project notes

### `philip0000000/OpenXR-Input-Explorer`

- Interesting idea:
  a .NET/WPF OpenXR controller input explorer that treats runtime/session/input
  bring-up as an inspectable desktop diagnostic surface.
- Code donor value:
  useful C# split around `OpenXRService`, `D3D11GraphicsService`, controller
  state models, action sets, and a WPF display path for pose/value state.
- Product reference value:
  strong reference for an `OpenXR input doctor` that explains whether runtime,
  graphics binding, session creation, controller pose, and actions are alive.
- Architecture pattern:
  desktop UI plus OpenXR service boundary plus graphics-device bootstrap before
  session creation.
- Reusable method:
  input diagnostic surface with explicit runtime/session/action/controller
  status rows.
- Source evidence:
  README lists OpenXR initialization, D3D11-backed session creation, controller
  position/rotation tracking, and action-set examples; source exposes
  `Services/OpenXRService.cs`, `Services/D3D11GraphicsService.cs`, and
  `Models/ControllerState.cs`.
- Reusable core:
  isolate loader/session setup, graphics binding, action-set creation, pose
  polling, and UI state mapping so diagnostics can show exactly which stage
  failed.
- What not to copy:
  SteamVR-only assumptions, prototype UI layout, or a future API-layer idea
  before the tool has a stable non-invasive observer design.
- Method catalog action:
  contributes to `OpenXR runtime/input operator surface`.
- What to inspect next:
  compare against `openxr-explorer`, API-layer samples, and OpenXR loader
  diagnostics to decide whether VR-apps-lab needs a neutral input probe schema.

### `Teqqles/OpenXRRuntimeSwitcher`

- Interesting idea:
  a modern Windows runtime switcher with friendly runtime names/icons, custom
  runtime persistence, manifest validation, tray integration, and hotkey/startup
  affordances.
- Code donor value:
  high for safe registry adapter boundaries, manifest parsing, runtime metadata,
  registry change detection, tray status, startup task abstraction, and tests.
- Product reference value:
  strong reference for a runtime-switch microtool that does not force users into
  registry editing or vendor settings panels.
- Architecture pattern:
  WinForms/WPF-style shell over service abstractions for registry, runtime
  metadata, icon resources, startup tasks, and manifest validation.
- Source evidence:
  README documents `HKLM\SOFTWARE\Khronos\OpenXR\1\ActiveRuntime`, manifest JSON
  parsing, custom runtimes, tray icon state, and comparison against other
  switchers; source includes `OpenXRRuntimeService`, `WindowsRegistryService`,
  `RuntimeInfoProvider`, `RegistryChangeDetector`, and unit tests for invalid
  manifests.
- Reusable core:
  runtime registry read, available-runtimes list, manifest JSON validation,
  DLL existence check, friendly name/icon mapping, custom runtime persistence,
  safe switch action, change detector, and visible active-runtime status.
- What not to copy:
  bundled icon assets, admin-elevation mechanism, local runtime path presets, or
  Windows-only UX as a cross-platform architecture.
- Method catalog action:
  contributes to `OpenXR runtime/input operator surface`.
- What to inspect next:
  extract a runtime manifest validation checklist for future `OpenXR doctor`
  docs.

### `Ybalrid/OpenXR-Runtime-Manager`

- Interesting idea:
  a compact utility that enumerates the current OpenXR runtime and lets the
  operator select another one.
- Code donor value:
  moderate as a minimal reference for Windows OpenXR registry handling and known
  manifest path fallback.
- Product reference value:
  good comparison point for a simpler no-tray, no-custom-runtime runtime manager.
- Source evidence:
  README states it edits `HKLM\SOFTWARE\Khronos\OpenXR\1`, relies on Windows
  runtime enumeration and known manifest paths, and explicitly does not handle
  32-bit runtime configuration from a 64-bit build.
- Reusable core:
  keep current-runtime display, known runtime list, and switching action small
  enough to audit.
- What not to copy:
  limited 32-bit coverage and hard-coded manifest knowledge as the only
  discovery strategy.
- Method catalog action:
  strengthens existing runtime switcher notes.
- What to inspect next:
  compare its enumeration path with Teqqles' validation-heavy approach.

### `jonyrh/OXR_Switcher`

- Interesting idea:
  a small GUI runtime switcher that displays installed x32/x64 OpenXR runtimes
  and supports shortcut-driven switching by runtime number.
- Code donor value:
  moderate for quick-command/runtime-index UX and icon/category coverage across
  Oculus, Meta, SteamVR, VirtualDesktop, WMR, Vive, Varjo, Pimax, and Monado.
- Product reference value:
  useful for a `launcher shortcut switches runtime` operator pattern.
- Source evidence:
  README documents x32/x64 active runtime switching, runtime list display, icon
  families, shortcut argument switching, and demo mode.
- Reusable core:
  runtime list, runtime-number command argument, and visible vendor icon mapping.
- What not to copy:
  index-only switching without a confirmation/manifest validation layer.
- Method catalog action:
  strengthens existing runtime switcher notes.
- What to inspect next:
  inspect command-line mode together with launch-profile tools from earlier
  waves.

## Synthesis

Runtime switchers are not just convenience apps. They are operator surfaces for
hidden global XR state. A reusable VR-apps-lab pattern should combine:

- active runtime readout
- available runtime inventory
- manifest validation
- safe switch/rollback story
- tray or compact status indicator
- optional launch-profile integration
- input/session probe for controller bring-up

## Follow-up backlog

- Define a neutral `runtime manifest record` shape.
- Compare 32-bit and 64-bit registry views explicitly.
- Add a runtime-switch safety checklist to a future OpenXR doctor reuse plan.
- Connect input diagnostic status rows to runtime-switcher status so users can
  see whether switching actually fixed controller/session state.
