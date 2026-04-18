# VR Utility Methods Catalog

- Date: `2026-04-18`
- Purpose: extract reusable implementation methods and product patterns from the
  tracked VR repositories, so `VR.app` can grow around proven approaches rather
  than only around named projects.

## How to use this file

Use this document when designing a new module or utility and ask:

1. which implementation method fits the problem?
2. which public repositories already demonstrate that method?
3. is the method better suited as:
   - overlay
   - API layer
   - background desktop utility
   - service/bridge
   - driver
   - creator tool

## Method 1: OpenVR companion overlay app

- What it is:
  a standalone desktop app that connects to `SteamVR/OpenVR` and renders one or
  more overlays in VR.
- Good for:
  quick utility panels, wrist dashboards, notes, clocks, metrics, reference
  windows, small control surfaces.
- Why it matters:
  this is the shortest path to a usable VR utility on current PCVR hardware.
- Strong references:
  `DesktopPlus`, `OpenVRDesktopDisplayPortal`, `openvr_widgets`,
  `OpenVR-AdvancedSettings`, `WhereIsForward`, `OpenVRDeviceBattery`,
  `openvr-metrics`.
- Best fit for `VR.app`:
  near-term product work.

## Method 2: OpenXR API-layer utility

- What it is:
  a runtime-level layer that sits between the application and the OpenXR
  runtime.
- Good for:
  diagnostics, mirroring, motion compensation, image adjustment, experimental
  overlays, passthrough interception, runtime-level tooling.
- Why it matters:
  this is the cleanest path when utility behavior must exist below the app or
  across multiple apps.
- Strong references:
  `OpenXR-Toolkit`, `OpenXR-Layer-Template`, `OpenXR-Layer-OBSMirror`,
  `OpenXR-OverlayLayer`, `WMR-Passthrough`, `XRFrameTools`.
- Best fit for `VR.app`:
  medium-term and advanced tooling.

## Method 3: Wrist dashboard / controller-attached UI

- What it is:
  a utility surface attached to the controller or wrist, usually available on
  demand with quick interactions.
- Good for:
  quick actions, stats, battery levels, toggles, shortcuts, overlay controls.
- Why it matters:
  this is one of the most repeatable UX patterns across successful VR utilities.
- Strong references:
  `DesktopPortal`, `wlx-overlay-s`, `SteamVR_ClockOverlay_Public`,
  `OpenVR-AdvancedSettings`, `openvr_widgets`.
- Best fit for `VR.app`:
  first user-facing utility family.

## Method 4: Desktop-side companion utility

- What it is:
  a Windows or Linux helper app that complements VR usage without necessarily
  rendering in-headset UI.
- Good for:
  config editors, tray tools, runtime switching, battery watchers, install
  helpers, background diagnostics.
- Why it matters:
  many useful VR tools solve friction outside the headset, not only inside it.
- Strong references:
  `OpenXR-API-Layers-GUI`, `OpenXR-Runtime-Switcher` family,
  `steamvr-exconfig`, `OpenVRDeviceBattery`.
- Best fit for `VR.app`:
  setup utilities and companion workflows.

## Method 5: Micro-utility overlay

- What it is:
  a very small tool with one clear job and almost no platform baggage.
- Good for:
  clocks, forward arrows, cable-direction hints, battery hints, one-function
  overlays.
- Why it matters:
  these projects are often the cleanest examples of focused VR utility design.
- Strong references:
  `WhereIsForward`, `TurnSignal`, `SteamVR_ClockOverlay_Public`,
  `VRBattery`.
- Best fit for `VR.app`:
  fast MVPs and proof-of-value utilities.

## Method 6: Widget suite / utility shell

- What it is:
  one app hosts multiple small tools or panels under a shared runtime shell.
- Good for:
  dashboards, metrics, keyboards, window capture, toggles, status views.
- Why it matters:
  it reduces startup friction and encourages reuse of runtime scaffolding.
- Strong references:
  `openvr_widgets`, `OpenVR-AdvancedSettings`, `DesktopPortal`,
  `openvr-metrics`.
- Best fit for `VR.app`:
  long-term suite architecture.

## Method 7: Runtime switcher and doctor tool

- What it is:
  a tool that inspects XR runtime state, layers, manifests, and runtime
  selection.
- Good for:
  diagnosing broken XR setups, switching runtimes, enabling/disabling layers,
  spotting stale manifests.
- Why it matters:
  this is a natural product category for advanced XR users and developers.
- Strong references:
  `OpenXR-API-Layers-GUI`, `OpenXR-Runtime-Switcher` family,
  `openxr-explorer`.
- Best fit for `VR.app`:
  `OpenXR Doctor`.

## Method 8: Notification and remote-control service bus

- What it is:
  an external process or server drives VR overlay behavior through IPC,
  WebSocket, or JSON payloads.
- Good for:
  notifications, alerts, automation, integration with external apps, stream
  control, status messages.
- Why it matters:
  it turns VR utilities into a platform rather than a closed app.
- Strong references:
  `OpenVROverlayPipe`, `OpenVRNotificationPipe`, `OpenVR2WS`, `VnotifieR`.
- Best fit for `VR.app`:
  automation and integration layer.

## Method 9: Virtual tracker bridge

- What it is:
  external software or sensors are converted into virtual SteamVR/OpenVR
  trackers, poses, or skeletal data.
- Good for:
  mocap, body tracking, custom sensors, OSC-driven tracking, remote tracking,
  experimental input devices.
- Why it matters:
  this is one of the richest architectural spaces in the entire repo.
- Strong references:
  `VirtualMotionTracker`, `PSMoveServiceEx-VMT`,
  `OpenVR-Tracker-Websocket-Driver`, `OpenVR-Driver`,
  `VirtualDesktop-OpenVR-Trackers`.
- Best fit for `VR.app`:
  tracker bridge platform and experimentation tools.

## Method 10: OSC and external automation bridge

- What it is:
  VR events or poses are exported to OSC, or OSC commands are imported into the
  VR stack.
- Good for:
  VRChat, home automation, stream control, cross-app triggers, integration with
  creative tools.
- Why it matters:
  OSC is a low-friction control plane for VR automation.
- Strong references:
  `SteamVR_To_OSC`, `OpenVR2OSC`, `steamvr-osc-control`, `VRCOSC`,
  `VRC-OSC`.
- Best fit for `VR.app`:
  external integration modules.

## Method 11: Device monitor and battery watcher

- What it is:
  a utility that tracks connected devices, battery state, roles, or health.
- Good for:
  battery overlays, inventory views, tray monitors, device status dashboards,
  notifications.
- Why it matters:
  small but very practical user value.
- Strong references:
  `OpenVRDeviceBattery`, `VRBattery`, `OpenVR-Display-Devices`,
  `SteamVR-Devices-Battery-Status`.
- Best fit for `VR.app`:
  diagnostics and device health tools.

## Method 12: Calibration wizard

- What it is:
  step-by-step guided alignment or calibration flow for tracking, eye tracking,
  motion compensation, or spatial registration.
- Good for:
  device alignment, eye tracking, mixed tracking spaces, reticle calibration,
  role assignment.
- Why it matters:
  calibration UX is often the difference between a clever tool and a usable
  tool.
- Strong references:
  `OpenVR-SpaceCalibrator`, `OpenXR-MotionCompensation`,
  `EyeTrackVR-OpenVR-Calibration-Overlay`.
- Best fit for `VR.app`:
  tracking helpers and setup tools.

## Method 13: Vendor enhancement layer

- What it is:
  augment the official vendor stack rather than replacing it.
- Good for:
  unlocking extra features, developer APIs, prediction improvements, haptics
  upgrades, optional mod layers.
- Why it matters:
  useful when the official stack exists but leaves value on the table.
- Strong references:
  `PSVR2Toolkit`.
- Best fit for `VR.app`:
  future vendor-specific research branches.

## Method 14: Creator and research capture tool

- What it is:
  a utility focused on logging, capture, workflow, and content creation rather
  than only live overlay UX.
- Good for:
  session capture, pose logging, NLA recording, performance capture, workflow
  support.
- Why it matters:
  creator tools open a different product track than end-user overlays.
- Strong references:
  `clovr`, `tracking-toolkit`, `XRFrameTools`, `openvr-metrics`,
  `OpenKneeboard`.
- Best fit for `VR.app`:
  diagnostics and creator tools branch.

## Method 15: Passthrough and scoped reality layer experiment

- What it is:
  insert or compose limited real-world imagery or passthrough data into VR.
- Good for:
  external camera windows, projection experiments, scoped passthrough, reality
  tool prototypes.
- Why it matters:
  still valuable as a research direction, even when vendor support is unstable.
- Strong references:
  `openxr-steamvr-passthrough`, `WMR-Passthrough`, `VRPassthrough`,
  `LeapOVRPassthrough`.
- Best fit for `VR.app`:
  experiments only unless hardware support is proven.

## Method 16: Custom device plumbing and driver prototyping

- What it is:
  integrate new device classes or experimental hardware into the VR stack using
  OpenVR drivers and related plumbing.
- Good for:
  gloves, glasses, Arduino HMDs, cockpit control bridges, distributed tracking.
- Why it matters:
  it is the main path for hardware experimentation in PCVR.
- Strong references:
  `opengloves-driver`, `GlassVr`, `OpenVR-ArduinoHMD`,
  `hotas-vr-controller`, `hobo_vr`, `Simple-OpenVR-Driver-Tutorial`.
- Best fit for `VR.app`:
  advanced research and hardware bridge branch.

## Recommended usage inside `VR.app`

When a new utility idea appears:

1. classify it first by `method`;
2. then map it to a `project family`;
3. then look up which repositories already demonstrate that method;
4. then decide whether `VR.app` should build it as:
   - overlay
   - desktop companion
   - service
   - API layer
   - driver
   - creator tool
