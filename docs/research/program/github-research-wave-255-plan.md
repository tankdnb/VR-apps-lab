# GitHub Research Wave 255 Plan

Date: 2026-06-06

Theme: XR desktop, smart glasses, and WebXR authoring utility surfaces.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

The research base has strong overlay/runtime coverage, but useful XR utilities
also live at the OS display, smart-glasses, dev-server, and authoring-tool
edges. This wave studies those boundary tools.

## Search Families

- Smart-glasses desktop runtimes.
- Android/Xreal desktop-mode setup helpers.
- XR desktop panel indicators.
- VITURE glasses runtime/dashboard assistants.
- WebXR dev helper components.
- Blender-to-WebXR export tools.
- WebXR annotation surfaces.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `ProjectBlueSkies/xr-desktop` | Viture IMU daemon, shared memory, and GNOME extension for world-locked desktop. | Smart-glasses desktop donor |
| `mhalder/xreal-desktop-mode` | ADB helper for Android desktop mode and Xreal display density. | Display setup microtool |
| `marbetschar/wingpanel-indicator-xrdesktop` | Wingpanel indicator with DBus state for XR desktop enablement. | Desktop companion indicator |
| `cong-lab/LabOS-Runtime` | VITURE glasses lab-assistant runtime with dashboard, media, voice, and config connectors. | Operational glasses runtime reference |
| `sawa-zen/three-fiber-webxr-toolbox` | WebXR developer helpers: error surface, console, passthrough portal, remote display. | WebXR dev-tool donor |
| `laffan/blender-webxr-tools` | Blender sidebar for WebXR export, baking, transforms, and gltfjsx update. | Authoring pipeline microtool |
| `pravinpoudel/building-annotation` | WebXR/Three.js scanned-space annotation coordinate model. | Annotation surface reference |

## Dedupe Notes

Earlier waves cover large WebXR frameworks, spatial desktops, and smart-glasses
SDKs. This wave keeps smaller edge utilities that expose OS/hardware/authoring
contracts.

## Code-Level Pass Targets

- Hardware/OS source and setup boundary.
- IPC/config transport.
- Desktop/shell/dashboard visible surface.
- Dev-server or DCC export flow.
- Security, platform, and version caveats.

## Expected Outputs

- Wave 255 landscape synthesis.
- Registry/family entry for XR edge utility surfaces.
- Method catalog entry for OS/hardware/WebXR authoring edge utilities.
- Follow-up backlog for smart-glasses and WebXR developer-surface matrices.
