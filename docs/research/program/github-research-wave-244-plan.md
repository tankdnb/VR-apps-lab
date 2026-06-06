# GitHub Research Wave 244 Plan

Date: 2026-06-06

Theme: OpenVR overlay micro-surfaces, telemetry panels, and game HUD
prototypes.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

After several broad waves on WebXR, Unity XR, and spatial workbenches, the
repository benefits from a compact overlay pass focused on small surfaces:
overlay lifecycle, texture submit, telemetry panels, edit-mode placement,
autostart manifests, and log-driven HUDs.

## Search Families

- OpenVR and SteamVR overlays.
- Controller-attached overlay surfaces.
- Telemetry micro-panels.
- Game journal and log-driven HUD overlays.
- Legacy overlay skeletons with readable source.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `Sch1nken/VRChatOverlay` | Minimal OpenVR/SFML/OpenGL overlay skeleton with tracked-device transforms and event polling. | Legacy OpenVR overlay skeleton |
| `ObnubiladO/vram-overlay` | WPF transparent topmost GPU-memory micro-panel with hotkey, context menu, fallback telemetry, and settings persistence. | Desktop telemetry panel reference |
| `Spacefish/OpenVR-Overlay` | C#/.NET OpenVR overlay with Vulkan texture submission, controller-relative placement, mouse events, and haptic feedback. | Modern OpenVR texture donor |
| `lukis101/VRPoleOverlay` | C# OpenVR playspace landmark overlay with edit mode, controller snap/drag, chaperone awareness, and autostart manifest. | Placement/edit-mode overlay donor |
| `AArchAngel/Remlok-HUD` | Unity/OVRLay Elite Dangerous HUD driven by journal file watching, mission parsing, and voice prompts. | Log-driven game HUD reference |

## Dedupe Notes

Prior waves already cover many overlays, notification panels, dashboards, and
SteamVR helpers. This wave keeps only projects that add a micro-surface lesson:
small overlay lifecycle, telemetry panel UX, graphics texture bridge, physical
landmark placement, or game-log feed.

## Code-Level Pass Targets

- OpenVR initialization and overlay identity.
- Overlay placement relative to tracked devices or playspace.
- Texture upload/submission boundaries.
- Event polling, hotkeys, and edit mode.
- Settings persistence and autostart manifests.
- External telemetry/log feed ingestion.

## Expected Outputs

- Wave 244 landscape synthesis.
- Registry/family entry for OpenVR overlay micro-surfaces.
- Method catalog entry for overlay micro-surface lifecycle boundaries.
- Follow-up backlog for overlay settings schema and OpenVR lifecycle matrix.
