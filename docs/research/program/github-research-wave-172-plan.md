# GitHub Research Wave 172 Plan

- Date: `2026-06-05`
- Theme: `Overlay window surfaces, game overlay managers, and scriptable overlay shells`
- Scope: OpenVR overlay windows, Electron/React overlay shells, injected game
  overlay managers, modular SteamVR overlay hosts, Unity overlay baselines, and
  scriptable overlay-engine references.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

The repository already has broad overlay coverage, but still benefits from a
new pass over implementation substrates: browser-backed OpenVR overlays,
process-injected window surfaces, modular driver/overlay umbrellas, game-focused
OpenXR overlay engines, and Unity overlay baselines.

Wave 172 focuses on how overlay windows are created, updated, positioned,
captured, made interactive, and exposed to users or feature modules.

## Search Families

- OpenVR overlay shell implementations
- Electron/browser-backed SteamVR overlays
- game-specific overlay managers and capture engines
- modular overlay/driver control panels
- Unity overlay prefabs and dashboard surfaces
- scriptable overlay engine experiments

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `imagitama/react-electron-openvr` | Electron offscreen shared-texture OpenVR overlay stack with React lifecycle bindings | Browser-backed OpenVR overlay donor |
| `KotRikD/steamvr-overlay` | Node/Rust overlay manager with injected target-process surfaces and typed IPC | Injected overlay/window manager donor |
| `RealWhyKnot/WKOpenVR` | Umbrella SteamVR driver/overlay with flag-gated feature modules, pipes, safety gates, and ImGui tabs | Modular driver/overlay utility shell |
| `SableVII/Sable-Overlay` | Unity modular boundary overlay with module UI and JSON settings | Unity overlay module reference |
| `Alphasumsi/Honey_Overlays` | iRacing OpenXR overlay engine with WPF editor, hidden browser hosts, window capture, and in-headset placement | Game-specific OpenXR overlay manager donor |
| `Ikeiwa/VRMocapOverlay` | Unity/OpenVR overlay baseline for mocap display surfaces and event handling | Unity OpenVR overlay baseline |
| `4x8Matrix/Hoku` | Luau-driven OpenVR overlay engine concept | Scriptable overlay product reference |

## Dedupe Notes

- Earlier overlay waves already cover many OpenVR overlay micro-utilities,
  dashboard shells, protocol bridges, and browser-backed surfaces.
- This wave keeps only projects that add implementation-specific lessons around
  surface creation, IPC, input, module gating, capture, or scriptable overlay
  framing.
- `Hoku` is retained as a product/reference node only because the current
  public repository is source-light.

## Code-Level Pass Targets

- Electron offscreen rendering, Windows shared texture handles, native OpenVR
  submission, and declarative React overlay lifecycle props;
- injected overlay DLL/window manager IPC, shared-handle updates, input capture,
  and blocking cursor semantics;
- modular overlay host plugin interface, flag-file activation, pipe isolation,
  safety markers, and feature-gated driver deployment;
- WPF editor to OpenXR layer engine pipe protocol, hidden WebView/browser host
  lifecycle, Windows Graphics Capture, D3D11 composition quads, and place-in-VR
  UX;
- Unity overlay prefab/event baselines, module settings, and boundary overlay
  configuration.

## Expected Outputs

- New Wave 172 landscape synthesis.
- Registry and family placement for overlay surfaces and external overlay
  engines.
- Methods around Electron shared-texture overlays, injected overlay IPC,
  modular overlay feature hosts, and editor-driven OpenXR overlay engines.
