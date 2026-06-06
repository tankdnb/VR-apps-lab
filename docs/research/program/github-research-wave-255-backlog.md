# GitHub Research Wave 255 Backlog

Date: 2026-06-06

Theme: XR desktop, smart glasses, and WebXR authoring utility surfaces.

## Completed In This Wave

- Studied `ProjectBlueSkies/xr-desktop` as a Viture XR Pro Linux desktop
  experiment with C IMU daemon, udev/vendor SDK discovery, seqlock-style
  shared-memory quaternion IPC, and GNOME Shell extension world-lock transform.
- Studied `mhalder/xreal-desktop-mode` as an ADB shell setup helper for Android
  desktop mode, external display ID detection, density tuning, wireless-debug
  reconnect, and persistent settings.
- Studied `marbetschar/wingpanel-indicator-xrdesktop` as a small Wingpanel
  plugin exposing XR desktop enabled state through DBus and popover/display
  widgets.
- Studied `cong-lab/LabOS-Runtime` as a VITURE glasses operational runtime
  reference with hardware config connector, local dashboard, media/audio
  bridge, STT/TTS, and remote agent/model service boundaries.
- Studied `sawa-zen/three-fiber-webxr-toolbox` as a WebXR developer-tool
  component set with in-XR console, error surface, passthrough portal, remote
  display component, and Socket.IO/WebRTC signaling plugin.
- Studied `laffan/blender-webxr-tools` as a Blender WebXR export microtool
  with bake/transform/export operators, gltfjsx execution, and JSX update
  modes.
- Studied `pravinpoudel/building-annotation` as a WebXR/Three.js annotation
  model for scanned spaces with manual camera/target coordinate capture.
- Added a reusable method entry for XR edge utility surfaces.

## Follow-Up Queue

1. Build a matrix across glasses IMU, Android display settings, desktop
   indicators, local dashboards, WebXR dev servers, Blender export tools, and
   annotation surfaces.
2. Deepen `LabOS-Runtime` only if the repository wants a lab-assistant or
   voice-operated glasses workflow pass.
3. Compare WebXR remote-display development helpers with native desktop-in-VR
   overlays.

## Do Not Spend Time On Yet

- Do not run shell scripts, ADB, GNOME extensions, Docker, VITURE connectors,
  WebXR dev servers, Blender, or Node tooling.
- Do not copy device-setting mutation, open signaling defaults, broad lab
  runtime stacks, or regex JSX rewriting as recommended defaults.
- Do not treat early smart-glasses desktop projects as complete virtual display
  runtimes without separate validation.
