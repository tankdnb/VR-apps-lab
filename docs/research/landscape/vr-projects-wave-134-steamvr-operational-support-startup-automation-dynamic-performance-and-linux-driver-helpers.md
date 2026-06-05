# VR Projects Wave 134: SteamVR Operational Support, Startup Automation, Dynamic Performance, and Linux Driver Helpers

- Date: `2026-06-05`
- Goal: study VR operational helper utilities: SteamVR lifecycle automation,
  dynamic runtime settings, Linux device permissions, and vendor driver
  support/proxy patterns.

## Why this wave exists

Not every reusable VR utility appears as an overlay. A lot of value sits in the
support layer around the runtime: starting companion scripts, reacting to quit
events, controlling supersampling, fixing Linux permissions, or proxying vendor
drivers to expose unsupported hardware.

## Better workflow used in this wave

1. searched by SteamVR startup, dynamic resolution, Linux udev, and Vive Pro 2
   driver families;
2. deduplicated against earlier runtime, driver, Linux, and performance waves;
3. froze a compact operational-support shortlist;
4. inspected local-only source clones;
5. separated micro-utility, settings-controller, package/reference, and
   driver-proxy lessons;
6. extracted methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `BOLL7708/OpenVRStartup` | SteamVR startup/shutdown command-file automation |
| `Erimelowo/OpenVR-Dynamic-Resolution` | Runtime feedback controller for SteamVR supersampling |
| `ValveSoftware/steam-devices` | Linux udev permissions/device inventory reference |
| `CertainLach/VivePro2-Linux-Driver` | Linux Vive Pro 2 driver proxy and HID control stack |

## Deep-pass notes by project

## `BOLL7708/OpenVRStartup`

- GitHub:
  [BOLL7708/OpenVRStartup](https://github.com/BOLL7708/OpenVRStartup)
- What it is:
  an archived/deprecated OpenVR utility for running command files on SteamVR
  startup and shutdown.
- Interesting idea:
  SteamVR lifecycle events can be turned into a simple automation surface:
  `start/` scripts on attach and `stop/` scripts on quit.
- Code-level notes:
  `Program.cs` defines `./start/` and `./stop/` command folders, logs to
  `OpenVRStartup.log`, waits for `OpenVR.Init(VRApplication_Overlay)`, installs
  an app manifest, sets autolaunch for app key `boll7708.openvrstartup`, runs
  start scripts, waits for `VREvent_Quit` when stop scripts exist, acknowledges
  quit, shuts down, and runs stop scripts. First-run messaging is based on log
  file presence.
- Code donor value:
  medium-high for SteamVR autolaunch and quit-event automation.
- Product reference value:
  high for tiny operational micro-utilities.
- Caveats:
  archived/deprecated in favor of BVRTK.
- What to inspect next:
  extract a runtime lifecycle automation checklist.

## `Erimelowo/OpenVR-Dynamic-Resolution`

- GitHub:
  [Erimelowo/OpenVR-Dynamic-Resolution](https://github.com/Erimelowo/OpenVR-Dynamic-Resolution)
- What it is:
  a lightweight OpenVR app that dynamically adjusts HMD resolution based on
  performance and VRAM pressure.
- Interesting idea:
  runtime settings can be controlled by a safety-gated feedback loop: frame
  timing, CPU timing, dashboard visibility, app whitelist/blacklist, manual
  override detection, and VRAM budget.
- Code-level notes:
  `main.cpp` defines a large `settings.ini` model for autostart, minimize,
  whitelist/blacklist, resolution delay/min/max, thresholds, reprojection mode,
  VRAM target/limit, and debug values. It initializes
  `VRApplication_Overlay`, registers manifests/autolaunch, sets SteamVR manual
  supersample override keys, reads compositor frame timing arrays, optionally
  loads NVML for VRAM, avoids adjustment while the dashboard is visible, checks
  CPU thresholds and app gates, and uses ImGui/GLFW/tray UI. `setup.cpp`
  registers app key `steam.overlay.3243840` through `IVRApplications`.
- Code donor value:
  very high for frametime/VRAM feedback controller and SteamVR settings flow.
- Product reference value:
  high for runtime support tooling.
- Caveats:
  SteamVR-specific and uses GPU-vendor APIs for some signals.
- What to inspect next:
  compare with earlier diagnostics/layer intervention methods.

## `ValveSoftware/steam-devices`

- GitHub:
  [ValveSoftware/steam-devices](https://github.com/ValveSoftware/steam-devices)
- What it is:
  Valve's Linux udev rules package for Steam-related devices, including SteamVR
  devices.
- Interesting idea:
  device access is part of VR tooling; keeping a vendor/device permission
  inventory avoids mysterious "runtime cannot see hardware" failures.
- Code-level notes:
  `60-steam-vr.rules` grants HID/raw permissions with `MODE="0660"` and
  `TAG+="uaccess"` for SteamVR/HTC/Valve/Bigscreen and adjacent devices, with
  vendor IDs such as `28de`, `0bb4`, and `35bd`.
- Code donor value:
  medium as a support-boundary and packaging reference.
- Product reference value:
  high for Linux troubleshooting and setup-doctor design.
- Caveats:
  rules inventory rather than application code.
- What to inspect next:
  turn into a Linux VR device-permission checklist if Linux support becomes
  active.

## `CertainLach/VivePro2-Linux-Driver`

- GitHub:
  [CertainLach/VivePro2-Linux-Driver](https://github.com/CertainLach/VivePro2-Linux-Driver)
- What it is:
  a Linux Vive Pro 2 driver/proxy stack that intercepts SteamVR's
  `driver_lighthouse` and adds HMD support behavior.
- Interesting idea:
  unsupported headset support can be achieved by proxying a vendor driver,
  wrapping the needed interfaces, and delegating everything else.
- Code-level notes:
  README describes HMD image/audio/camera/power management, settings such as
  resolution, brightness, noise cancellation, and required kernel patches for
  non-desktop HMD/display timings. `hmd.rs` implements Rust vtable proxying:
  `HmdDisplay` wraps `IVRDisplayComponent` functions such as window bounds,
  render target size, eye viewport, projection, and distortion. `HmdDriver`
  delegates activation to the real driver, then writes properties including
  display frequency, frame rates, vsync-to-photons, and runtime frame-rate
  support. `settings.rs` wraps `IVRSettings` and `IVRProperties` with typed
  helpers. `vive-hid` reads zlib-decoded JSON config from HID, defines display
  modes, and sends feature reports for brightness/resolution/mode control.
  `install.sh` backs up the original lighthouse driver, patches it, replaces
  the current driver with the proxy, and copies the lens server.
- Code donor value:
  very high for proxy-driver structure, typed settings/properties, and HID
  configuration control.
- Product reference value:
  high for vendor-support research and Linux device support.
- Caveats:
  driver replacement and kernel/display patches are high-risk operationally.
- What to inspect next:
  reuse only as a research reference unless a driver-support prototype exists.

## Cross-project synthesis

Reusable lessons:

- SteamVR app manifests and autolaunch can turn small utilities into lifecycle
  companions.
- Quit events should be handled explicitly when a utility owns cleanup scripts.
- Dynamic performance control needs gates, cooldowns, manual override checks,
  and visibility/app state awareness.
- Linux VR support often fails at device permission boundaries before app code.
- Proxy drivers should wrap only the interfaces they need and delegate the rest.
- Typed settings/property helpers reduce driver-support mistakes.

Best donor candidates:

- `OpenVR-Dynamic-Resolution` for feedback-controller runtime settings.
- `VivePro2-Linux-Driver` for proxy-driver and HID/settings patterns.
- `OpenVRStartup` for lifecycle automation.
- `steam-devices` for Linux device-permission support references.

## Reuse implications for `VR-apps-lab`

This wave suggests a `SteamVR operational support` branch:

- lifecycle/autolaunch script runner;
- runtime settings feedback controller;
- Linux device-permission doctor;
- proxy-driver anatomy reference;
- typed OpenVR settings/property helpers;
- support-boundary documentation for risky driver operations.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were used only for code reading and are local-only.
