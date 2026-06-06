# GitHub Research Wave 244 Backlog

Date: 2026-06-06

Theme: OpenVR overlay micro-surfaces, telemetry panels, and game HUD
prototypes.

## Completed In This Wave

- Studied `Sch1nken/VRChatOverlay` as a legacy OpenVR overlay skeleton with
  `VRApplication_Overlay`, overlay creation, tracked-device-relative
  placement, width/alpha settings, event polling, and SFML/OpenGL texture
  upload.
- Studied `ObnubiladO/vram-overlay` as a desktop telemetry micro-panel with a
  transparent WPF topmost window, F8 global hotkey, context menu, draggable
  surface, GPU memory counters, WMI fallback, and JSON settings persistence.
- Studied `Spacefish/OpenVR-Overlay` as a C# OpenVR/Vulkan overlay donor with
  `VRVulkanTextureData_t` submission, controller-relative placement, mouse
  input, control-bar flags, event polling, and haptic feedback.
- Studied `lukis101/VRPoleOverlay` as a physical playspace landmark overlay
  with edit mode, trigger snap/drag, chaperone height/color, fade settings,
  SteamVR autostart manifest, reload/save flow, and config validation.
- Studied `AArchAngel/Remlok-HUD` as a log-driven Unity/OVRLay HUD with
  process checks, `FileSystemWatcher`, Elite journal parsing, mission
  filtering/sorting, EDDB data loading, and voice prompts.
- Added a reusable method entry for overlay micro-surface lifecycle boundaries.

## Follow-Up Queue

1. Build an OpenVR overlay lifecycle matrix across C++, C#, OpenGL, Vulkan,
   dashboard overlays, controller-relative overlays, and keyboard/input flows.
2. Extract a shared overlay settings schema for transform, scale, opacity,
   refresh interval, hotkeys, edit mode, and autostart.
3. Compare log-driven HUDs with notification overlays and server-driven overlay
   message feeds.

## Do Not Spend Time On Yet

- Do not run SteamVR, Unity, or found overlay applications.
- Do not treat WPF topmost behavior as proof of VR overlay behavior.
- Do not copy hardcoded game paths, old EDDB endpoints, or example overlay keys
  into reusable code.
