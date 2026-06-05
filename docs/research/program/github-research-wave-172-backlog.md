# GitHub Research Wave 172 Backlog

- Date: `2026-06-05`
- Theme: `Overlay window surfaces, game overlay managers, and scriptable overlay shells`
- Status: `Completed`

## Completed Pass

1. Search OpenVR/OpenXR overlay implementation families rather than generic
   overlay app lists.
2. Deduplicate against prior overlay, micro-surface, external host, and
   protocol-bridge waves.
3. Freeze a bounded shortlist around surface creation, IPC, input, capture,
   module gating, and scripting.
4. Sync shortlisted sources into local-only cache for static reading.
5. Inspect Electron offscreen shared textures, OpenVR overlay native bindings,
   injected overlay IPC, WKOpenVR feature plugins and flag gates, Honey Overlays
   WPF/layer/browser-host pipeline, Unity overlay baselines, and source-light
   scriptable-engine framing.
6. Separate source donors from product references and capture caveats.
7. Integrate results into registry, families, methods, current focus,
   not-yet, and indexes.

## Studied Repositories

| Project | Outcome |
|---|---|
| `imagitama/react-electron-openvr` | Added as Electron/React offscreen shared-texture OpenVR overlay donor |
| `KotRikD/steamvr-overlay` | Added as injected overlay window manager and typed IPC donor |
| `RealWhyKnot/WKOpenVR` | Added as modular SteamVR driver/overlay umbrella and safety-gated feature host donor |
| `SableVII/Sable-Overlay` | Added as Unity modular boundary overlay and JSON settings reference |
| `Alphasumsi/Honey_Overlays` | Added as game-specific OpenXR overlay engine, WPF editor, browser/window capture, and in-headset placement donor |
| `Ikeiwa/VRMocapOverlay` | Added as Unity/OpenVR overlay prefab and event-loop baseline |
| `4x8Matrix/Hoku` | Added as source-light scriptable overlay-engine product reference |

## Useful Follow-Up Work

- Build an overlay-substrate matrix across OpenVR overlays, Electron offscreen
  shared textures, injected window overlays, Unity overlay prefabs, and OpenXR
  composition layers.
- Compare input models: OpenVR mouse input, injected input capture/blocking,
  VR placement controls, and overlay module UI tabs.
- Extract a small reusable "overlay engine contract" that separates editor,
  renderer, capture source, pose model, and runtime transport.
- Revisit scriptable overlay engines only if `Hoku` or similar projects publish
  actual scripting/runtime code.

## Not Pursued In This Wave

- No overlay, target game, Electron app, Unity project, OpenXR layer, SteamVR
  module, or script runtime was launched.
- No found repository was run, built, installed, imported, or tested.
