# GitHub Research Wave 134 Backlog

- Date: `2026-06-05`
- Scope: SteamVR operational support, startup automation, dynamic performance
  control, Linux device permissions, and vendor driver helpers.

## Completed in this wave

- Studied `BOLL7708/OpenVRStartup` as an archived/deprecated but useful
  lifecycle automation micro-utility that runs command files on SteamVR
  startup and shutdown.
- Studied `Erimelowo/OpenVR-Dynamic-Resolution` as an OpenVR overlay app that
  adjusts SteamVR supersampling using frame timing, CPU thresholds, app
  gates, dashboard gates, and optional NVML VRAM pressure.
- Studied `ValveSoftware/steam-devices` as the canonical Linux udev permission
  inventory for SteamVR, HTC, Valve, Bigscreen, and related HID/raw devices.
- Studied `CertainLach/VivePro2-Linux-Driver` as a Linux vendor-driver proxy
  stack with OpenVR vtable wrapping, typed SteamVR settings/properties, HID
  config/control, and install packaging.

## Reuse candidates

- `OpenVR-Dynamic-Resolution` is the strongest donor for runtime feedback
  controllers around SteamVR settings.
- `VivePro2-Linux-Driver` is the strongest donor for proxy-driver, typed
  settings/property wrappers, and vendor HID control lessons.
- `OpenVRStartup` is a useful lifecycle automation micro-utility reference.
- `steam-devices` is a support-boundary reference for Linux device access.

## Follow-up backlog

1. Extract a SteamVR operational-support checklist covering manifests,
   autolaunch, quit events, settings, and dashboard/app gating.
2. Compare dynamic resolution safety gates with earlier frametime diagnostics
   and runtime intervention layers.
3. Turn Linux udev/device inventory into a troubleshooting reference if Linux
   headset support becomes active.
4. Revisit proxy-driver techniques only for driver-support research, not as a
   default utility path.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
