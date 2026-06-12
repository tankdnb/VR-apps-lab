# VR Utility Methods Catalog

- Date: `2026-04-21`
- Purpose: extract reusable implementation methods and product patterns from the
  tracked VR repositories, so `VR-apps-lab` can grow around proven approaches rather
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
  `openvr-metrics`, `VROverlay`, `SteamVR-Webkit`,
  `steamvr_overlay_vulkan`.
- Best fit for `VR-apps-lab`:
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
- Best fit for `VR-apps-lab`:
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
- Best fit for `VR-apps-lab`:
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
  `steamvr-exconfig`, `OpenVRDeviceBattery`, `SteamVR-Toggle`, `dashfix`,
  `OculusKiller`, `WFOVFix`, `SteamVRAdaptiveBrightness`,
  `SteamVR-ActionsManifestValidator`, `Lighthouse-Scale-Fix`.
- Best fit for `VR-apps-lab`:
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
- Best fit for `VR-apps-lab`:
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
  `openvr-metrics`, `vr-streaming-overlay`.
- Best fit for `VR-apps-lab`:
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
  `openxr-explorer`, `OpenXR-Inventory`, `xr-picker`,
  `OpenXR-Simulator`, `VirtualDesktop-OpenXR`.
- Best fit for `VR-apps-lab`:
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
- Best fit for `VR-apps-lab`:
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
  `OpenVR-Tracker-Websocket-Driver`, `Simple-OpenVR-Bridge-Driver`,
  `OpenVR-Driver`, `soph_wireless`,
  `VirtualDesktop-OpenVR-Trackers`.
- Best fit for `VR-apps-lab`:
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
  `SteamVR_To_OSC`, `OpenVR2OSC`, `steamvr-osc-control`, `OpenVR-OSC`,
  `VRCThumbParamsOSC`, `axis-vrc-osc-bridge`, `VRCOSC`, `VRC-OSC`.
- Best fit for `VR-apps-lab`:
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
  `SteamVR-Devices-Battery-Status`, `steamvrbattery`.
- Best fit for `VR-apps-lab`:
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
  `EyeTrackVR-OpenVR-Calibration-Overlay`,
  `OpenXR-Canonical-Pose-Tool`.
- Best fit for `VR-apps-lab`:
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
- Best fit for `VR-apps-lab`:
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
  `OpenKneeboard`, `OBS-OpenVR-Input-Plugin`, `Valve virtual_display`,
  `SuperScreenShotterVR`, `Periodic-Immersive-SteamVR-Screenshots`.
- Best fit for `VR-apps-lab`:
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
- Best fit for `VR-apps-lab`:
  experiments only unless hardware support is proven.

## Method 16: Runtime graphics adapter layer

- What it is:
  an API layer or runtime-side component that bridges incompatible graphics
  paths between the app and the active XR runtime.
- Good for:
  Vulkan-to-D3D runtime bridging, compatibility experiments, graphics
  interop, and runtime bring-up on awkward platform combinations.
- Why it matters:
  not every XR compatibility problem is solved by a runtime switcher; some
  need a true graphics adapter in the middle.
- Strong references:
  `OpenXR-Vk-D3D12`, `VirtualDesktop-OpenXR`, `OpenComposite`, `xrizer`.
- Best fit for `VR-apps-lab`:
  advanced compatibility and runtime research.

## Method 17: Library plus sandbox learning harness

- What it is:
  a reusable runtime wrapper paired with a small sandbox executable that proves
  the wrapper in practice.
- Good for:
  onboarding, engine bring-up, extension experimentation, and keeping complex
  runtime setup reusable without hiding it completely.
- Why it matters:
  this is one of the best ways to turn raw XR bring-up knowledge into a
  reusable development asset.
- Strong references:
  `OpenXRProvider`, `OpenXR-SDK-Source` samples, `Simple-OpenVR-Driver-Tutorial`.
- Best fit for `VR-apps-lab`:
  future sample apps and reusable experimental foundations.

## Method 18: Virtual display and remote presentation driver

- What it is:
  a driver or utility path that repurposes XR compositor output for another
  display, transport, or presentation flow rather than a standard HMD.
- Good for:
  wireless transport, creator capture, 3D displays, AR glasses, simulated
  hardware, and special-purpose stereo output workflows.
- Why it matters:
  this opens a whole class of VR-adjacent tools that are not classic overlays
  and not classic runtime switchers either.
- Strong references:
  `ValveSoftware/virtual_display`, `VRto3D`, `Virtual-Display-Driver`,
  `OpenDisplayXR-VDD`.
- Best fit for `VR-apps-lab`:
  advanced workflow tooling and repurposed-output experiments.

## Method 19: Validation and config-patch micro-tool

- What it is:
  a very focused utility that validates one XR artifact or applies one safe
  configuration fix with backup and rollback behavior.
- Good for:
  manifest linting, SteamVR settings hygiene, one-off environment fixes,
  repair flows, and preflight checks.
- Why it matters:
  tiny helpers like these often solve real workflow pain faster than larger
  dashboard products.
- Strong references:
  `SteamVR-ActionsManifestValidator`, `Lighthouse-Scale-Fix`, `WFOVFix`,
  `steamvr-exconfig`.
- Best fit for `VR-apps-lab`:
  desktop-side helpers and future doctor/preflight tools.

## Method 16: Custom device plumbing and driver prototyping

- What it is:
  integrate new device classes or experimental hardware into the VR stack using
  OpenVR drivers, pose-rewrite layers, or input-emulation sidecars.
- Good for:
  gloves, glasses, Arduino HMDs, cockpit control bridges, distributed tracking,
  legacy peripheral recovery, synthetic controllers, and simulator-linked pose
  manipulation.
- Why it matters:
  it is the main path for hardware experimentation in PCVR.
- Strong references:
  `opengloves-driver`, `GlassVr`, `OpenVR-ArduinoHMD`,
  `hotas-vr-controller`, `hobo_vr`, `Simple-OpenVR-Driver-Tutorial`,
  `SteamVR-OpenHMD`, `Oculus_Touch_Steam_Link`,
  `SlimeVR-OpenVR-Driver`, `VirtualSteamVRDriver`, `driver_hydra`,
  `OpenPSVR`, `OpenVR-driver-for-DIY`, `SegsVRControllerDriverSample`,
  `Barebone`, `Joy2OpenVR`, `SteamVR-Glove`,
  `OpenVR-MotionCompensation`.
- Best fit for `VR-apps-lab`:
  advanced research and hardware bridge branch.

## Method 17: Web-rendered overlay surface

- What it is:
  render a web UI or browser surface into a VR overlay and treat the browser as
  the primary UI layer.
- Good for:
  rich dashboards, remote-control panels, streamer tools, HTML/CSS-based
  interfaces, plugin-friendly control surfaces.
- Why it matters:
  this can dramatically speed up UI iteration and lowers the cost of complex
  panel design.
- Strong references:
  `SteamVR-Webkit`, `overlay_experiments`.
- Best fit for `VR-apps-lab`:
  advanced dashboards and external-control surfaces.

## Method 18: SteamVR environment helper and runtime hygiene tool

- What it is:
  a narrow helper that improves the way SteamVR behaves around startup,
  dashboard input, compositor state, or overlay-heavy workflows.
- Good for:
  toggles, dashboard fixes, distortion tuning, headroom helpers, tray tools,
  pre-launch configuration.
- Why it matters:
  many valuable VR utilities are not overlays at all - they remove runtime
  friction around SteamVR.
- Strong references:
  `steamvr-exconfig`, `dashfix`, `SteamVR-Toggle`, `steamvr-undistort`,
  `SteamVR-VoidScene`, `OculusKiller`, `SteamVRNoHeadset`,
  `ViveTrackerExample`, `WFOVFix`, `SteamVRLinuxFixes`.
- Best fit for `VR-apps-lab`:
  desktop-side support tools and maintenance helpers.

## Method 19: Headless overlay host

- What it is:
  an app whose real job is to keep one or more VR overlays alive while the
  desktop window stays hidden, minimized, or visually irrelevant.
- Good for:
  background overlay suites, tray-driven utilities, Unity-based dashboards
  without desktop clutter, status indicators that should feel always-on.
- Why it matters:
  many practical VR tools are valuable precisely because they do not behave
  like normal foreground desktop apps.
- Strong references:
  `HeadlessOverlayToolkit`, `SteaMeeter`, `VRCMicOverlay`.
- Best fit for `VR-apps-lab`:
  always-on utility hosts and background helper surfaces.

## Method 20: Runtime inventory and capability matrix

- What it is:
  a structured catalog of runtime, middleware, or client capabilities that can
  be parsed, compared, and rendered into human-readable reports or diagnostics.
- Good for:
  capability dashboards, compatibility reports, runtime-health tools, extension
  support matrices, and environment triage.
- Why it matters:
  prose notes alone do not scale once the repository starts comparing many XR
  runtimes, layers, and clients.
- Strong references:
  `OpenXR-Inventory`, `xr-picker`.
- Best fit for `VR-apps-lab`:
  capability intelligence behind `OpenXR Doctor` and related research tools.

## Method 21: Vendor shell replacement and runtime auto-redirect

- What it is:
  replace, intercept, or supervise a vendor launcher or dashboard process so it
  redirects into a different VR runtime or workflow.
- Good for:
  Oculus-to-SteamVR flows, startup cleanup, desktop runtime redirection, and
  narrow environment helpers.
- Why it matters:
  not every valuable VR tool lives inside the headset; some remove friction by
  fixing runtime launch behavior.
- Strong references:
  `OculusKiller`.
- Best fit for `VR-apps-lab`:
  advanced environment-helper and compatibility research.

## Method 22: Headsetless and null-driver development workflow

- What it is:
  run SteamVR or OpenXR tooling without a real headset through null drivers,
  virtual HMDs, or simulator runtimes.
- Good for:
  tool development, test harnesses, tracker-only workflows, manual QA without
  full hardware, and reproducible dev setups.
- Why it matters:
  this method lowers the barrier to developing VR utilities and diagnostics.
- Strong references:
  `SteamVRNoHeadset`, `ViveTrackerExample`, `VirtualSteamVRDriver`,
  `OpenXR-Simulator`, `unity-openvr-tracking`.
- Best fit for `VR-apps-lab`:
  developer tooling, research harnesses, and workflow docs.

## Method 23: OpenVR mirror-surface capture bridge

- What it is:
  acquire SteamVR/OpenVR mirror textures and route them into an external
  desktop application or capture pipeline.
- Good for:
  OBS plugins, creator tools, debugging, stream production, and research
  recording.
- Why it matters:
  capture bridges are a distinct class of VR utility that connects runtime
  output to non-VR tools.
- Strong references:
  `OBS-OpenVR-Input-Plugin`.
- Best fit for `VR-apps-lab`:
  creator workflows and runtime-inspection side tools.

## Method 24: Mixed tracking and controller bridge

- What it is:
  convert foreign runtime devices, external services, or non-native hardware
  into SteamVR/OpenVR controllers, trackers, sensors, or HMD-like devices.
- Good for:
  MixedVR setups, controller reuse, tracker bridging, external pose services,
  and hardware interoperability experiments.
- Why it matters:
  this is one of the richest paths for turning external ecosystems into usable
  VR devices.
- Strong references:
  `Oculus_Touch_Steam_Link`, `SteamVR-OpenHMD`,
  `SlimeVR-OpenVR-Driver`.
- Best fit for `VR-apps-lab`:
  tracker-bridge and driver-plumbing research.

## Method 25: Vision-tracking sidecar with switchable backend

- What it is:
  a camera or CV pipeline estimates pose or gestures in a sidecar process and
  can target more than one output backend such as a SteamVR driver, OSC, or a
  lightweight bridge protocol.
- Good for:
  low-cost body tracking, webcam hand tracking, Quest-friendly calibration
  flows, and experiments where the tracking frontend should stay decoupled from
  the runtime output path.
- Why it matters:
  this method turns one fragile tracker experiment into a reusable pipeline with
  multiple delivery targets.
- Strong references:
  `Mediapipe-VR-Fullbody-Tracking`, `HandCameraDriver`,
  `NVIDIA-BodyTracking`.
- Best fit for `VR-apps-lab`:
  experimental tracking bridges and calibration-first prototypes.

## Method 26: Plugin-based tracking host with service endpoints

- What it is:
  a host application defines contracts for `device plugins` and `service
  endpoints`, then centralizes calibration, lifecycle, and settings UX while
  letting diverse sensors and output targets plug into the same shell.
- Good for:
  alternative tracking ecosystems, modular device support, mixed output targets,
  and long-lived desktop hosts that should survive beyond one sensor class.
- Why it matters:
  this is the cleanest architecture in the repo so far for turning a messy
  tracking ecosystem into a coherent product platform.
- Strong references:
  `KinectToVR/Amethyst`.
- Best fit for `VR-apps-lab`:
  long-term tracking lab architecture and reusable bridge hosts.

## Method 27: Headsetless camera runtime

- What it is:
  a custom OpenXR runtime pretends to be real XR hardware while a separate
  tracker process feeds it camera-derived head and hand input.
- Good for:
  no-HMD QA, education, accessibility experiments, runtime debugging, and
  fake-hardware bring-up without dedicated devices.
- Why it matters:
  this is qualitatively different from a null driver or simulator because it
  owns actual runtime registration, swapchain flow, and runtime-side input.
- Strong references:
  `aethervr`, `OpenXR-Simulator`, `VirtualSteamVRDriver`.
- Best fit for `VR-apps-lab`:
  research harnesses, headsetless workflow docs, and advanced runtime
  experimentation.

## Method 28: Overlay toolkit and prefab scaffolding

- What it is:
  a lightweight helper layer that wraps overlay creation, render-texture
  submission, and pointer/input translation into reusable scene components or
  plugin nodes rather than a full end-user utility product.
- Good for:
  rapid overlay prototyping, Unity or Godot experiments, internal labs, and
  reusable host scaffolding for future utility suites.
- Why it matters:
  this is the shortest path between `raw overlay API` and `finished overlay
  product`, and it keeps early UX experiments from turning into throwaway code.
- Strong references:
  `OVRLay`, `OVROverlayManager`, `openvr_widgets`, `ovr-utils-dashboard`.
- Best fit for `VR-apps-lab`:
  future overlay host abstractions and reusable prototype scaffolds.

## Method 29: Driver ingress endpoint for external tracker feeds

- What it is:
  an OpenVR driver exposes a transport endpoint such as a `named pipe` or local
  `WebSocket` so external programs can spawn, update, or query trackers without
  embedding the whole tracking stack inside the driver.
- Good for:
  CV sidecars, locomotion helpers, browser-based prototypes, mixed-language
  experiments, and custom sensors that should stay out-of-process.
- Why it matters:
  this is one of the cleanest ways to decouple `tracking producer` from
  `SteamVR driver lifecycle`.
- Strong references:
  `Simple-OpenVR-Bridge-Driver`, `OpenVR-Tracker-Websocket-Driver`,
  `3NekoSystem/OpenVR-Tracker-Websocket-Driver`,
  `SegsVRControllerDriverSample`.
- Best fit for `VR-apps-lab`:
  tracker bridge services and experimental sensor ingress.

## Method 30: Engine-side tracked-device adapter with SteamVR role reuse

- What it is:
  a game-engine package reads OpenVR device poses directly and reuses
  SteamVR tracker-role bindings or serial mappings inside scene objects,
  without needing the full end-user SteamVR app stack.
- Good for:
  Unity tools, no-HMD tracker workflows, previs, device visualization, and
  internal lab apps.
- Why it matters:
  it turns SteamVR device state into a reusable engine subsystem instead of a
  one-off integration script.
- Strong references:
  `unity-openvr-tracking`, `SteamVRTrackerUtility`, `ViveTrackerExample`.
- Best fit for `VR-apps-lab`:
  engine plugins, no-HMD development workflows, and internal research tools.

## Method 31: Direct tracker and controller state export to OSC consumers

- What it is:
  a desktop sidecar turns SteamVR state, tracker roles, controller actions, or
  vendor-specific body data into OSC messages for VRChat or other consumers,
  without requiring a new SteamVR driver.
- Good for:
  avatar parameters, Quest-friendly workflows, remote control surfaces, and
  thin consumer-facing bridges.
- Why it matters:
  sometimes the shortest and most honest utility path is
  `SteamVR or vendor SDK -> OSC consumer`, not `new driver`.
- Strong references:
  `OpenVR-OSC`, `VRCThumbParamsOSC`, `axis-vrc-osc-bridge`,
  `OpenVR2OSC`, `SteamVR_To_OSC`.
- Best fit for `VR-apps-lab`:
  direct consumer bridges, avatar utilities, and quick automation prototypes.

## Method 32: Existing UI stack to overlay texture bridge

- What it is:
  an overlay host reuses a mature UI stack such as `WinForms`, `WPF`, `CEF`,
  or `ImGui`, rasterizes it into a texture, and translates overlay input back
  into that UI runtime.
- Good for:
  dashboard apps, browser-backed utilities, desktop-parity tools, and
  productivity overlays that should not be rebuilt from scratch as VR-only UI.
- Why it matters:
  this is one of the shortest paths from `desktop-grade UI` to
  `usable VR overlay`, and it keeps the overlay layer focused on transport,
  lifecycle, and input translation.
- Strong references:
  `SteamVR_HUDCenter`, `SteamVR-WebApps`, `h-view`.
- Best fit for `VR-apps-lab`:
  future overlay shells, control surfaces, and diagnostics tools with desktop
  parity.

## Method 33: Overlay patch micro-tool over an existing runtime surface

- What it is:
  a tiny helper finds an overlay the runtime already owns and modifies its
  bounds, placement, or behavior instead of rendering a new overlay host.
- Good for:
  desktop-overlay crop tools, workflow patches, corrective helpers, and
  extremely narrow utilities that should stay small.
- Why it matters:
  sometimes the right VR utility is not `new overlay app`; it is
  `surgical patch over the overlay users already have`.
- Strong references:
  `SteamVR-PrimaryDesktopOverlay`.
- Best fit for `VR-apps-lab`:
  small corrective helpers and runtime-comfort micro-tools.

## Method 34: Scene-based overlay scaffold with tracked attachments

- What it is:
  a Unity or engine scene acts as the overlay body, while tracked-device
  helpers, sensors, or simple interactions drive scene content inside that
  overlay space.
- Good for:
  embodied HUDs, tracker-mounted scenes, experimental utility shells,
  sensor-enhanced overlays, and rapid spatial UI experiments.
- Why it matters:
  not every useful overlay should start as a flat desktop panel; some utility
  concepts are easier to prototype as a small scene with tracked attachments.
- Strong references:
  `VRSceneOverlay`, `VROverlay`, `OVROverlayManager`.
- Best fit for `VR-apps-lab`:
  experimental overlay concepts, scene-overlay labs, and tracker-aware utility
  prototypes.

## Method 35: State-transition device watcher with multi-channel alerts

- What it is:
  a background helper watches device properties over time and reacts when a
  state changes in a meaningful way, instead of only displaying a raw snapshot.
- Good for:
  charging warnings, device-health alerts, reconnect hints, and narrow
  background utilities with desktop or in-headset notifications.
- Why it matters:
  many practical VR device tools become useful only when they detect
  `something changed`, not when they merely print current numbers.
- Strong references:
  `openvr-battery-monitoring`, `vive-wireless-info-overlay`.
- Best fit for `VR-apps-lab`:
  device-health watchers and narrow status helpers.

## Method 36: Pose inventory snapshot exporter

- What it is:
  a utility captures the current runtime pose inventory and turns it into a
  reusable artifact such as an `FBX`, scene snapshot, or creator-side data
  export.
- Good for:
  avatar fitting, previs, creator tools, diagnostics, room-state capture, and
  device-layout inspection.
- Why it matters:
  it turns volatile live runtime state into something the user can reuse,
  compare, or import elsewhere.
- Strong references:
  `openvr-device-positions`.
- Best fit for `VR-apps-lab`:
  creator utilities, diagnostics, and export helpers.

## Method 37: Remote overlay session via API layer plus out-of-process client

- What it is:
  an OpenXR API layer owns the interception and session injection, while a
  separate process supplies the overlay content and drives the remote session.
- Good for:
  cross-app overlays, experimental runtime-level composition, and research into
  layer-host coordination.
- Why it matters:
  this is fundamentally different from a companion overlay app because the
  overlay exists inside an unaware host application's runtime path.
- Strong references:
  `OpenXR-OverlayLayer`, `OpenXR-OverlayLayer-1`.
- Best fit for `VR-apps-lab`:
  advanced OpenXR layer research and future runtime-level utility experiments.

## Method 38: Registry-plus-probe runtime switcher

- What it is:
  a runtime manager reads the official registry state or manifest state, then
  supplements it with well-known path probes and optional runtime-specific
  discovery helpers.
- Good for:
  OpenXR runtime switching, manifest inspection, setup diagnostics, and
  developer-facing runtime hygiene tools.
- Why it matters:
  real user setups are often messier than the ideal registry state, so a useful
  switcher needs both official discovery and pragmatic probing.
- Strong references:
  `OpenXR-Runtime-Manager`, `xr-picker`, `openxr-explorer`.
- Best fit for `VR-apps-lab`:
  `OpenXR Doctor` and runtime management helpers.

## Method 39: Protocol-adapter OpenXR layer for foreign sensor data

- What it is:
  an OpenXR API layer ingests data from an external service or protocol and
  presents it as a runtime-facing extension, action state, or tracked signal.
- Good for:
  eye tracking, controller fixes, vendor-specific bridges, and runtime-level
  experiments where a new SteamVR driver would be the wrong boundary.
- Why it matters:
  sometimes the cleanest adaptation surface is `protocol -> OpenXR layer`, not
  `protocol -> new driver`.
- Strong references:
  `etvr-openxr-layer`, `clearxr-layer`, `OpenXR-Eye-Trackers`.
- Best fit for `VR-apps-lab`:
  advanced runtime adaptation and experimental extension bridges.

## Method 40: Multi-transport custom-device provider with sidecar control surface

- What it is:
  an OpenVR driver owns one or more tracked devices, but discovery,
  configuration, calibration, or user-facing controls live in a separate helper
  process, overlay, or desktop app.
- Good for:
  DIY hardware, gloves, nonstandard controllers, repurposed glasses, and
  complex setups that need multiple transport backends.
- Why it matters:
  it keeps the SteamVR driver small enough to stay stable while moving the
  messy operational logic into a more flexible sidecar.
- Strong references:
  `opengloves-driver`, `GlassVr`.
- Best fit for `VR-apps-lab`:
  future custom-device platforms and bridge-heavy hardware tools.

## Method 41: Vendor-driver wrapper with proxy hooks and local IPC

- What it is:
  a shim loads the original vendor driver, proxies or hooks selected internal
  surfaces, and exposes extra capabilities through a local IPC or developer API
  layer.
- Good for:
  optional vendor feature unlocks, developer APIs, haptics upgrades, eye
  tracking access, and non-destructive enhancement layers.
- Why it matters:
  this is the cleanest path when replacing the vendor stack would be too risky
  or too expensive.
- Strong references:
  `PSVR2Toolkit`.
- Best fit for `VR-apps-lab`:
  vendor-enhancement research and carefully-scoped official-stack extensions.

## Method 42: Runtime-aware DXGI proxy performance mod

- What it is:
  a drop-in `dxgi.dll` or graphics-proxy utility intercepts the rendering path,
  forwards to the original graphics library when needed, and applies scaling,
  foveation, or image-treatment logic through one runtime-aware config surface.
- Good for:
  VR performance helpers, render-scale utilities, compatibility-focused fork
  lines, and graphics-path experiments that should stay outside the main app.
- Why it matters:
  this is a distinct construction method from overlays, API layers, or drivers;
  the product boundary is the proxy DLL itself.
- Strong references:
  `vrperfkit`, `VRPerfKit_RSF`, `OpenVRPerfKit`.
- Best fit for `VR-apps-lab`:
  graphics-path utilities and rendering-side experimentation.

## Method 43: Single-pass VR sweet-spot shader bundle

- What it is:
  a compact VR-focused shader pack groups several useful image treatments into
  one coherent effect surface instead of exposing a loose pile of unrelated
  post-process scripts.
- Good for:
  sharpening, color tuning, center-mask shaping, lightweight image cleanup, and
  user-facing visual-comfort adjustments.
- Why it matters:
  sometimes the best donor is not a runtime or driver architecture, but a well
  packaged `one strong visual toolkit` that matches VR needs.
- Strong references:
  `reshade-vrtoolkit`.
- Best fit for `VR-apps-lab`:
  rendering experiments and compact visual-adjustment modules.

## Method 44: Plugin-host tracking platform with device and service endpoints

- What it is:
  a desktop host provides calibration, settings, lifecycle, and UX, while
  swappable plugins represent tracking devices and output-side service
  endpoints.
- Good for:
  modular tracking labs, alternative body-tracking platforms, mixed hardware
  stacks, and future systems that need both input-device and output-service
  variation.
- Why it matters:
  it scales much better than a monolithic tracking app when the family of
  devices and outputs keeps growing.
- Strong references:
  `Amethyst`.
- Best fit for `VR-apps-lab`:
  future tracking-host experiments and research-oriented utility shells.

## Method 45: Switchable CV tracking backend with web control surface

- What it is:
  one computer-vision tracking pipeline can target different downstream outputs
  such as a SteamVR driver or an OSC consumer, while settings and calibration
  are exposed through a lightweight web UI.
- Good for:
  Quest-friendly workflows, camera-based prototypes, thin companion tools, and
  backend experiments where a heavy desktop host would be overkill.
- Why it matters:
  it keeps `pose estimation`, `output choice`, and `control surface` separated,
  which makes camera-tracking utilities more reusable.
- Strong references:
  `Mediapipe-VR-Fullbody-Tracking`.
- Best fit for `VR-apps-lab`:
  camera-side utility prototypes and lightweight calibration/control surfaces.

## Method 46: External driver protocol with language bindings and poser processes

- What it is:
  a SteamVR driver exposes an explicit contract so external processes, scripts,
  or language bindings can act as device posers instead of hiding all ingress
  inside one private daemon.
- Good for:
  experimentation, scripting, research harnesses, Linux-friendly tooling, and
  custom hardware labs where the driver should stay small and stable.
- Why it matters:
  it turns the driver into a reusable platform boundary instead of a sealed
  implementation detail.
- Strong references:
  `hobo_vr`.
- Best fit for `VR-apps-lab`:
  future bridge experiments, lab tooling, and scriptable device-ingress paths.

## Method 47: Firmware-plus-driver co-designed custom device ecosystem

- What it is:
  a hardware repo and a runtime repo are designed as one system, with transport,
  encoding, haptics, and driver expectations aligned across both sides.
- Good for:
  gloves, wearable controllers, DIY hardware families, and projects where one
  driver repo alone hides too much of the real architecture.
- Why it matters:
  many of the strongest custom-device lessons live at the ecosystem level, not
  just in the final SteamVR bridge.
- Strong references:
  `opengloves-driver`, `lucidgloves`.
- Best fit for `VR-apps-lab`:
  future custom-device platforms and donor analysis for hardware ecosystems.

## Method 48: Tracked-controller relocation via config offsets and click interception

- What it is:
  a bridge keeps SteamVR tracking but reshapes the effective controller pose and
  input semantics around a real physical object through offsets, hooks, and
  supplemental click devices.
- Good for:
  cockpit hardware, tool handles, props, attachment-based experiments, and
  narrow but high-value physical workflow utilities.
- Why it matters:
  this is a useful product pattern whenever the user's real hardware should
  define the interaction model more than the stock VR controller shape.
- Strong references:
  `hotas-vr-controller`.
- Best fit for `VR-apps-lab`:
  physical workflow tools, attachment experiments, and niche controller
  adaptation utilities.

## Method 49: Local speech-recognition sidecar feeding a native VR overlay

- What it is:
  speech recognition runs in a local service or sidecar, while a separate VR
  surface subscribes to caption messages and owns the visual presentation.
- Good for:
  accessibility captions, language tools, communication helpers, and
  experimental assistive overlays.
- Why it matters:
  it keeps the heavy speech stack separate from the render loop and lets the
  overlay stay simple.
- Strong references:
  `live-captions-vr`, `OpenVRCaptions`.
- Best fit for `VR-apps-lab`:
  accessibility tools and caption-oriented overlay experiments.

## Method 50: Multi-output local transcription utility with VR overlay as one consumer

- What it is:
  a local speech host performs transcription once, then routes the result to
  one or more consumers such as a SteamVR overlay, OSC client, browser page, or
  host-app integration.
- Good for:
  speech-to-text utilities, social VR helpers, accessibility hubs, and
  lightweight automation surfaces.
- Why it matters:
  the reusable core is the transcription service, not any one target surface.
- Strong references:
  `VRCTextboxSTT`, `UniversalVR-CC`.
- Best fit for `VR-apps-lab`:
  future local STT hosts and mixed-output assistive tools.

## Method 51: Null-driver config swapper with backup-safe mode toggling

- What it is:
  a tiny utility snapshots or preserves relevant settings, flips SteamVR into a
  null-driver or no-HMD configuration, and can restore the previous state.
- Good for:
  headsetless QA, no-HMD bring-up, graphics-path testing, and low-friction dev
  workflows.
- Why it matters:
  turning a fragile manual edit into a repeatable mode switch has outsized
  value for development ergonomics.
- Strong references:
  `SteamVRNullFlipper`, `SteamVRNoHeadset`.
- Best fit for `VR-apps-lab`:
  headsetless workflow helpers and SteamVR environment micro-tools.

## Method 52: Automation-friendly simulator runtime with shared core plus GUI or API controllers

- What it is:
  a simulator runtime exposes one core control layer, while desktop GUI tools,
  scripts, or automation clients all talk to the same underlying simulator API.
- Good for:
  XR QA sandboxes, scripted runtime testing, fake-hardware bring-up, and
  developer tooling.
- Why it matters:
  it scales much better than one-off debug UIs because the simulator becomes a
  reusable platform boundary.
- Strong references:
  `OpenXR-Simulator`, `ox-sim-driver`.
- Best fit for `VR-apps-lab`:
  future scriptable QA runtimes and runtime-bring-up tools.

## Method 53: SDK-first device bridge with a separated dedicated driver repo

- What it is:
  a device family exposes transport and capability logic through a public SDK or
  API layer first, while the runtime-specific driver lives as a thinner
  downstream bridge.
- Good for:
  glasses bridges, custom displays, hardware SDKs, and device families that may
  target several runtime integrations over time.
- Why it matters:
  it keeps hardware-specific logic from being trapped inside one runtime plugin.
- Strong references:
  `RayNeo-Air-3S-Pro-OpenVR`, `RayNeo-Air-3S-Pro-OpenVR-Driver`.
- Best fit for `VR-apps-lab`:
  custom-device platforms and repurposed-output research.

## Method 54: Vendor enhancement ecosystem built around local IPC and downstream consumers

- What it is:
  a vendor-wrapper layer exposes extra capabilities through a local IPC or
  developer API, and smaller downstream repos consume that contract for
  app-specific features or utilities.
- Good for:
  eye-tracking access, haptics extensions, trigger tuning, and non-destructive
  augmentation of official stacks.
- Why it matters:
  the ecosystem value is in the contract and the downstream consumers, not only
  in the main wrapper itself.
- Strong references:
  `PSVR2Toolkit`.
- Best fit for `VR-apps-lab`:
  vendor-enhancement research and local developer-API experiments.

## Method 55: Consumer-specific module over vendor IPC

- What it is:
  a small adapter consumes a broader vendor IPC contract and maps only the
  target-app semantics that matter for one host ecosystem.
- Good for:
  engine mods, avatar tracking adapters, and host-specific feature bridges.
- Why it matters:
  it keeps the vendor integration generic while allowing small downstream
  specializations to move quickly.
- Strong references:
  `PSVR2Toolkit.VRCFT`, `ResonitePSVR2`.
- Best fit for `VR-apps-lab`:
  downstream module design and ecosystem-aware utility contracts.

## Method 56: Config micro-tool over vendor IPC

- What it is:
  a narrow desktop utility talks to a vendor IPC contract to expose one
  high-value configuration flow with little extra product baggage.
- Good for:
  trigger tuning, haptics presets, calibration helpers, and other small control
  surfaces.
- Why it matters:
  many of the best vendor utilities should stay small and focused rather than
  being folded into one giant shell.
- Strong references:
  `PSVR2ToolkitTriggerConfig`.
- Best fit for `VR-apps-lab`:
  focused companion apps and single-purpose tuning tools.

## Method 57: Driver-side pose rewrite with shared library and overlay configuration

- What it is:
  a driver hooks or intercepts pose flow, applies correction logic, and exposes
  its configuration through a shared library plus an overlay or dashboard
  control surface.
- Good for:
  motion compensation, pose manipulation, experimental alignment tools, and
  runtime-side correction research.
- Why it matters:
  it combines low-level correction power with a user-facing configuration path.
- Strong references:
  `OpenVR-MotionCompensation`.
- Best fit for `VR-apps-lab`:
  advanced alignment utilities and pose-rewrite experiments.

## Method 58: Continuous calibration overlay layered on top of a one-shot alignment baseline

- What it is:
  a calibration tool keeps the standard point-sequence and initial solve, but
  then adds metrics, persistence, and live correction logic for ongoing
  alignment.
- Good for:
  mixed-tracking workflows, long sessions, unstable spaces, and evolving sensor
  alignment.
- Why it matters:
  the real product value is often the continuous correction layer, not only the
  initial calibration solve.
- Strong references:
  `OpenVR-SpaceCalibrator2`, `OpenVR-SpaceCalibrator`.
- Best fit for `VR-apps-lab`:
  future calibration helpers and alignment UX research.

## Method 59: Pose capture to reconstruction pipeline for spatial alignment experiments

- What it is:
  a runtime capture tool records images and tracked poses, then feeds them into
  an offline reconstruction or mapping pipeline to produce alignment-friendly
  spatial artifacts.
- Good for:
  room mapping, scene reconstruction, spatial diagnostics, and environment
  alignment experiments.
- Why it matters:
  some alignment problems are solved better by better capture artifacts than by
  yet another live overlay.
- Strong references:
  `openvr-room-mapping`.
- Best fit for `VR-apps-lab`:
  spatial diagnostics, room-scan experiments, and calibration-adjacent capture
  tools.

## Method 60: Tracked physical keyboard with hand-proximity reveal and MR boundary visualization

- What it is:
  a VR typing surface is anchored to a runtime-tracked real keyboard, while the
  app controls visibility, boundary rendering, and hand-near reveal behavior.
- Good for:
  mixed-reality desk setups, setup and login flows, configuration panels, and
  utilities that benefit from real hardware typing instead of synthetic keys.
- Why it matters:
  when real hardware exists, the best UX is often not another floating keyboard
  but a better `tracked-hardware wrapper`.
- Strong references:
  `Unity-TrackedKeyboard`, `XR-Keyboard`.
- Best fit for `VR-apps-lab`:
  desk-aware setup tools, MR configuration surfaces, and tracked-input
  experiments.

## Method 61: Non-native spatial keyboard with semantic layouts, validation surfaces, and event callbacks

- What it is:
  a reusable keyboard component exposes layout modes, validation or placeholder
  surfaces, and host-facing events instead of forcing each app to own its own
  text-entry logic.
- Good for:
  search fields, setup wizards, quick text entry, naming flows, and any tool
  that needs small but structured user input inside XR.
- Why it matters:
  the reusable unit is not the key art but the `keyboard lifecycle contract`.
- Strong references:
  `MRTK-Keyboard`, `VRKeys`, `XR-Interaction-Toolkit-Examples`.
- Best fit for `VR-apps-lab`:
  utility-side text entry, setup UI, and keyboard components that can be shared
  across future tools.

## Method 62: Palm-up launcher that opens richer world-space panels at a separate popup anchor

- What it is:
  a small launcher appears on or near the hand, but the heavier content opens
  at a detached popup anchor that is easier to read and interact with.
- Good for:
  quick actions, tool palettes, small dashboards, wrist or palm launchers, and
  utilities that need fast access without making the hand itself too crowded.
- Why it matters:
  it separates `quick reveal` from `serious interaction`, which usually
  produces a calmer VR menu UX.
- Strong references:
  `XRHandMenuSample`, `mr-example-meta-openxr`, `MixedRealityToolkit-Unity`.
- Best fit for `VR-apps-lab`:
  hand-first utility shells, launcher patterns, and compact control surfaces.

## Method 63: Menu-archetype generator with radial, ring, and default templates plus editor-side modifiers

- What it is:
  menu behavior is packaged as reusable archetypes and creator tools, while a
  separate modifier layer tunes style or behavior after generation.
- Good for:
  Unity-heavy toolkits, reusable UI kits, experiments that compare radial and
  ring menus, and teams that want faster iteration on menu shape.
- Why it matters:
  it turns menus from one-off scene objects into reusable authoring assets.
- Strong references:
  `VRMenuDesigner`.
- Best fit for `VR-apps-lab`:
  internal XR UI kits, reusable menu scaffolds, and faster prototyping of menu
  variants.

## Method 64: Physicalized radial selection that materializes actual interactables into the hand

- What it is:
  a radial menu acts less like a command list and more like a temporary picker
  that resolves into a real tool or interactable already attached to the user's
  hand.
- Good for:
  tool selection, inventory wheels, controller-attached object pickers, and
  workflows where the selected item should become immediately grabbable.
- Why it matters:
  it blurs the boundary between `menu` and `interaction`, which is often more
  natural in VR than clicking a detached UI command.
- Strong references:
  `UnityXR-Physicalized-Radial-Menu`, `RadialMenuVR`.
- Best fit for `VR-apps-lab`:
  tool-palette experiments, radial pickers, and embodied command surfaces.

## Method 65: XR UI interaction stack that extends EventSystem with ray, poke, and hand input

- What it is:
  a framework adapts the normal UI event system to XR by adding custom input
  modules, raycasters, hand or poke interaction, and activation heuristics.
- Good for:
  world-space menus, panels, keyboards, toolkit-scale UI, and utilities that
  want to reuse ordinary UI controls in XR.
- Why it matters:
  many future VR tools should extend a UI substrate instead of rebuilding every
  control as a special case.
- Strong references:
  `ViveInputUtility-Unity`, `XR-Interaction-Toolkit-Examples`,
  `MixedRealityToolkit-Unity`.
- Best fit for `VR-apps-lab`:
  shared UI infrastructure, framework selection, and future toolkit-oriented
  prototypes.

## Method 66: Teleoperation workspace with palm-menu control hub and live connection-state surfaces

- What it is:
  a VR workspace exposes remote-system control through palm menus, side panels,
  and live status indicators rather than one flat generic dashboard.
- Good for:
  teleoperation, operations dashboards, remote procedure control, and control
  rooms for external services or devices.
- Why it matters:
  workflow structure and state visibility often matter more than raw command
  density in embodied control tools.
- Strong references:
  `unity_ros_teleoperation`, `ReachyTeleoperation`, `ros_reality`.
- Best fit for `VR-apps-lab`:
  control-room research, operator dashboards, and command-oriented utility
  surfaces.

## Method 67: Thin VR control frontend that streams controller state to an external robot or service process

- What it is:
  the VR app stays intentionally thin and exports controller pose or button
  state to another process that owns the real business logic.
- Good for:
  robotics frontends, remote-system control, simulator input, and fast XR
  command bridges.
- Why it matters:
  it keeps the VR layer simple and reusable when the real product logic lives
  elsewhere.
- Strong references:
  `UR10_Teleop`.
- Best fit for `VR-apps-lab`:
  thin bridge apps, embodied input exporters, and sidecar-controlled workflow
  tools.

## Method 68: Browser-automation sidecar that turns a social service into a VR overlay surface

- What it is:
  a desktop automation layer extracts presence or voice state from a social
  service, while a separate OpenVR app renders that state as a configurable VR
  overlay.
- Good for:
  voice presence, chat status, social participation indicators, and
  communication overlays when no direct public API gives the exact UI surface
  the product needs.
- Why it matters:
  it separates `service scraping or automation` from `VR presentation`, which
  keeps the overlay side simpler and more reusable.
- Strong references:
  `discord-vr`.
- Best fit for `VR-apps-lab`:
  social overlays, companion presence surfaces, and communication-sidecar
  experiments.

## Method 69: Native chat companion with dual social-service and OSC outputs

- What it is:
  a small desktop-native app owns chat composition and history, while the same
  surface can send messages to both a social platform and a local `OSC`
  consumer.
- Good for:
  VRChat-adjacent chat helpers, streaming companions, desktop-side message
  entry, and bridge tools where XR-facing consumers should not own service auth.
- Why it matters:
  it turns a simple chat utility into a reusable `dual-output communication
  surface`.
- Strong references:
  `VRCattoChatto`.
- Best fit for `VR-apps-lab`:
  desktop-side VR companions, OSC chat bridges, and social utility micro-tools.

## Method 70: Service-first communication utility where the overlay is only one consumer

- What it is:
  the core product is a background service or engine, while the VR overlay or
  VR-specific UI is only one optional consumer of the real service outputs.
- Good for:
  proximity systems, social-safety tools, local communication helpers, and
  products where VR should have controls or visibility but not necessarily own
  the whole architecture.
- Why it matters:
  many useful VR utilities should be `service-first`, with overlay UX treated
  as a thin control layer rather than the whole app.
- Strong references:
  `vrchat-proximity-app`.
- Best fit for `VR-apps-lab`:
  hybrid utilities, overlay-optional helpers, and VR companions that sit on
  top of a broader desktop-side engine.

## Method 71: Local speech platform with OSC and websocket multi-consumer outputs

- What it is:
  a speech, translation, or assistant host keeps capture and inference local,
  then fans results out through `OSC`, `WebSocket`, files, playback, or plugin
  channels for many downstream consumers.
- Good for:
  captions, avatar chat helpers, translation overlays, accessibility tools, and
  any VR workflow that should consume speech without owning the inference stack.
- Why it matters:
  it treats VR as one consumer of a broader local speech platform instead of
  rebuilding a speech pipeline inside each overlay utility.
- Strong references:
  `whispering`, `VRCTextboxSTT`.
- Best fit for `VR-apps-lab`:
  speech-sidecar research, accessibility tools, and communication hosts with
  multiple VR or non-VR outputs.

## Method 72: Cleanly layered alternative OpenXR runtime for special displays

- What it is:
  an OpenXR runtime is decomposed into strict layers for state tracking,
  compositing, device drivers, and display processors, with explicit rules
  about what each layer must not own.
- Good for:
  spatial displays, 3D monitors, glasses, and future runtime experiments where
  ordinary headset assumptions do not apply.
- Why it matters:
  explicit runtime decomposition makes alternative platform work easier to
  reason about and reuse.
- Strong references:
  `displayxr-runtime`.
- Best fit for `VR-apps-lab`:
  runtime-architecture research, special-display experiments, and future
  nontraditional OpenXR platform work.

## Method 73: Embedded or platform-native OpenXR runtime framework

- What it is:
  the OpenXR runtime is packaged as a framework or library inside a
  platform-native app rather than as a normal desktop runtime registered for
  general system-wide use.
- Good for:
  mobile platforms, Apple-platform XR experiments, tightly integrated vendor
  apps, and runtimes where the host app should own lifecycle and services.
- Why it matters:
  not every useful runtime path should look like a Windows desktop runtime
  installation.
- Strong references:
  `OpenXRKit`.
- Best fit for `VR-apps-lab`:
  platform-native runtime research, embedded-framework experiments, and
  alternative XR host architectures.

## Method 74: Runtime-server split with local IPC for experimental OpenXR platforms

- What it is:
  the runtime surface and the controlling host application are separated by a
  local IPC boundary, so the runtime primitives can stay lean while the host
  owns lifecycle, bridges, or UI integration.
- Good for:
  proof-of-concept runtimes, nontraditional platforms, WebXR bridges, and
  experimental runtime ownership models.
- Why it matters:
  it provides a cleaner way to explore runtime behavior on platforms where one
  monolithic process is awkward or unnatural.
- Strong references:
  `FruitXR`.
- Best fit for `VR-apps-lab`:
  platform experiments, runtime-service research, and bridge-heavy runtime
  prototypes.

## Method 75: CAD-to-SteamVR tracking JSON generation from physical design geometry

- What it is:
  a CAD or authoring environment produces SteamVR tracking definitions by
  converting construction axes, points, or other design-time geometry into the
  sensor map that the runtime expects.
- Good for:
  custom tracked-device design, Lighthouse hardware experiments, and repeatable
  authoring of tracker geometry without hand-editing large JSON payloads.
- Why it matters:
  it moves a complex device-definition step into a tool where the physical
  design already exists.
- Strong references:
  `Fusion360_SteamVR_Json`.
- Best fit for `VR-apps-lab`:
  custom-device research, tracked-hardware authoring workflows, and future
  design-tool utilities.

## Method 76: Derived virtual tracker from existing tracked nodes with role-specific device registration

- What it is:
  a driver derives a missing tracked role from other tracked nodes, then
  registers the result as if it were a real device with believable metadata and
  role hints.
- Good for:
  synthetic waist or torso trackers, missing-role reconstruction, lightweight
  augmentation of partial body-tracking setups, and role-specific helpers.
- Why it matters:
  it treats synthetic tracking as `runtime-visible device generation`, not only
  as app-local math.
- Strong references:
  `augmented-hip`.
- Best fit for `VR-apps-lab`:
  derived-tracker helpers, role reconstruction tools, and synthetic device
  experiments.

## Method 77: DIY tracker ecosystem split across firmware, desktop control app, and driver

- What it is:
  a custom tracking system is intentionally split into hardware firmware, a
  desktop configurator or calibration app, and a runtime driver that registers
  the tracked devices.
- Good for:
  IMU trackers, WiFi-connected custom devices, maker hardware projects, and
  future custom sensor ecosystems.
- Why it matters:
  it keeps hardware bring-up, user configuration, and runtime registration from
  collapsing into one hard-to-maintain component.
- Strong references:
  `IMU-VR-Full-Body-Tracker`.
- Best fit for `VR-apps-lab`:
  DIY hardware research, driver-plus-companion patterns, and custom-device
  ecosystem design.

## Method 78: Overlay-assisted calibration over modular expressive-tracking capture sources

- What it is:
  an expressive-tracking platform keeps capture backends modular, then runs
  calibration or trainer flows through a dedicated overlay surface or overlay
  program.
- Good for:
  face tracking, eye tracking, trainer UX, multi-camera or multi-source
  platforms, and any expressive-input tool that needs a guided user flow.
- Why it matters:
  calibration becomes a reusable `service plus overlay` boundary rather than an
  ad hoc scene or one-off window.
- Strong references:
  `Baballonia`.
- Best fit for `VR-apps-lab`:
  expressive-tracking platforms, overlay-guided trainer tools, and reusable
  calibration-host infrastructure.

## Method 79: Cross-provider hand-input remapping into a common interaction model

- What it is:
  a compatibility layer swaps or adapts multiple hand or controller providers
  into one shared interaction stack, without forcing the rest of the app to
  care which provider is active.
- Good for:
  hand-tracking fallbacks, mixed controller or optical input, provider
  migration, and interoperability between existing XR interaction stacks.
- Why it matters:
  it lets a future tool reuse one `hand interaction contract` across multiple
  tracking backends.
- Strong references:
  `HandshakeVR`, `HandOfLesser`.
- Best fit for `VR-apps-lab`:
  input-compatibility layers, shared hand abstractions, and future bridge tools
  that should tolerate multiple tracking sources.

## Method 80: Vendor-specific gaze IPC translated into an OpenXR API layer

- What it is:
  a vendor-specific eye-tracking source is exposed through local IPC and then
  adapted into standard OpenXR gaze extensions by an API layer that only
  activates when the relevant extensions are requested.
- Good for:
  vendor eye-tracking unlocks, custom gaze hardware, experimental gaze sources,
  and XR runtimes where the standard app contract should hide vendor-specific
  plumbing.
- Why it matters:
  it creates a reusable bridge from `custom gaze backend` to
  `standard OpenXR-facing surface`.
- Strong references:
  `PSVR2_OpenXR_Eye_Tracking`, `OpenXR-Eye-Trackers`,
  `etvr-openxr-layer`.
- Best fit for `VR-apps-lab`:
  gaze-layer research, vendor enhancement paths, and future eye-tracking bridge
  experiments.

## Method 81: Runtime-side XR utility platform split across desktop host, landing-space app, and API layer

- What it is:
  a broader XR utility platform divides responsibilities between a desktop host,
  a runtime-adjacent app or landing space, and an API layer that adapts data or
  behavior at the runtime boundary.
- Good for:
  service-heavy XR utilities, runtime augmentation, companion spaces,
  transport-to-runtime adaptation, and platform-shaped diagnostic tools.
- Why it matters:
  it keeps orchestration, UX, and runtime adaptation from collapsing into one
  hard-to-maintain binary.
- Strong references:
  `clearxr-server`.
- Best fit for `VR-apps-lab`:
  larger runtime-side tools that need both desktop control surfaces and
  runtime-level adaptation.

## Method 82: Plugin-manifest overlay platform with Electron control shell and native overlay interop

- What it is:
  a desktop application hosts overlays through native interop while a plugin
  system, manifest model, and persistence layer manage feature growth.
- Good for:
  monitor surfaces, dashboard suites, modular overlay platforms, domain-specific
  utility shells, and plugin-driven XR tooling.
- Why it matters:
  it turns a one-off overlay app into a reusable platform with install,
  update, and persistence semantics.
- Strong references:
  `vrkit-platform`.
- Best fit for `VR-apps-lab`:
  future overlay platforms that may need extensibility beyond one utility.

## Method 83: IPC command surface that spawns synthetic controllers and trackers

- What it is:
  an OpenVR driver exposes a narrow command-oriented IPC contract so external
  processes can create controllers or trackers and update their pose or input
  state.
- Good for:
  controller emulation, external sensor bridges, custom input devices, rapid
  prototyping, and thin language bindings on top of a driver.
- Why it matters:
  it makes `external process -> synthetic SteamVR device` a reusable platform
  boundary instead of a one-off hardcoded bridge.
- Strong references:
  `Yet-Another-OpenVR-IPC-Driver`, `Simple-OpenVR-Bridge-Driver`.
- Best fit for `VR-apps-lab`:
  driver bridges, custom-device experiments, and controller-emulation helpers.

## Method 84: Gesture-configurable hand-tracking bridge that emulates full controllers

- What it is:
  a hand-tracking tool maps gesture states into controller semantics through a
  lightweight gesture config and a dedicated SteamVR-facing input profile.
- Good for:
  optical hand tracking, controllerless interaction experiments, accessibility
  fallbacks, and hand-to-controller compatibility layers.
- Why it matters:
  it separates `gesture meaning` from `SteamVR controller contract`, which
  makes the emulation model easier to adapt or replace.
- Strong references:
  `Quest-Link-Hand-Tracking`.
- Best fit for `VR-apps-lab`:
  hand-tracking adaptation experiments and controllerless interaction research.

## Method 85: CI-friendly SteamVR manifest linter with disableable warning gates

- What it is:
  a focused validator checks SteamVR action metadata, rejects malformed JSON,
  and treats expected issues as explicit warnings that can be disabled one by
  one.
- Good for:
  CI, preflight validation, action-manifest authoring, regression checks, and
  small workflow helpers.
- Why it matters:
  it moves fragile SteamVR metadata problems from runtime debugging into a
  reproducible validation step.
- Strong references:
  `SteamVR-ActionsManifestValidator`.
- Best fit for `VR-apps-lab`:
  doctor tools, preflight helpers, and contributor-facing validation scripts.

## Method 86: Mirror-texture feedback daemon that continuously rewrites runtime settings

- What it is:
  a background helper samples compositor or mirror-texture output, derives one
  live metric from it, and continuously rewrites one runtime setting in
  response.
- Good for:
  adaptive brightness, scene-dependent quality helpers, dynamic comfort
  settings, and runtime feedback experiments driven by live rendered output.
- Why it matters:
  it creates a reusable pattern for `observe compositor output -> apply focused
  environment adjustment`.
- Strong references:
  `SteamVRAdaptiveBrightness`.
- Best fit for `VR-apps-lab`:
  environment helpers, runtime feedback experiments, and narrow adaptive
  utilities.

## Method 87: Offscreen-browser overlay toolkit with JS interop and dual dashboard/in-game surfaces

- What it is:
  a reusable overlay toolkit renders a browser offscreen, maps it to VR
  overlay textures, and exposes keyboard, messaging, and JS interop helpers for
  both dashboard and in-game surfaces.
- Good for:
  web-driven control panels, browser-backed overlays, companion-app UIs, rich
  dashboard surfaces, and rapid UI experimentation.
- Why it matters:
  it turns `browser UI in VR` into a reusable construction method instead of a
  one-off product implementation.
- Strong references:
  `SteamVR-Webkit`, `SteamVR-WebApps`.
- Best fit for `VR-apps-lab`:
  browser-backed overlay experiments and reusable VR UI host layers.

## Method 88: Settings-driven overlay suite with reusable overlay instances and persistence sync

- What it is:
  one overlay shell instantiates multiple overlay types from saved settings and
  keeps each instance synchronized through reusable persistence and lifecycle
  helpers.
- Good for:
  dashboard suites, overlay bundles, user-configurable utility collections,
  reusable scene-based overlay frameworks, and multi-surface helper apps.
- Why it matters:
  it separates `overlay content` from `overlay lifecycle and persistence`,
  which is one of the clearest ways to scale a VR utility suite.
- Strong references:
  `ovr-utils-dashboard`.
- Best fit for `VR-apps-lab`:
  overlay suite architecture and multi-tool host foundations.

## Method 89: Character-budgeted chatbox composition over modular desktop status providers

- What it is:
  a desktop-side host polls multiple providers, formats their outputs into
  compact fragments, then assembles one bounded text string for a small chatbox
  or avatar-facing text surface.
- Good for:
  social VR chatbox tools, compact status dashboards, subtitle or now-playing
  helpers, and any limited-character utility surface.
- Why it matters:
  it turns a tiny text budget into a reusable composition problem rather than a
  pile of ad hoc string concatenation.
- Strong references:
  `vrcosc-magicchatbox`, `OSC-Chat-Tools`.
- Best fit for `VR-apps-lab`:
  chatbox sidecars, compact social-VR status tools, and small text-output
  utilities.

## Method 90: Generated avatar text surface over block-addressed OSC parameter pages

- What it is:
  a tool pages text across a grid of avatar parameters, then generates the
  animator or asset scaffolding needed to render that text visibly on the
  avatar.
- Good for:
  speech-to-avatar text, long-form avatar text surfaces, subtitle-like avatar
  displays, and social-VR communication helpers.
- Why it matters:
  it separates `text rendering on avatar` from ordinary overlay or chatbox
  surfaces and makes the asset burden manageable.
- Strong references:
  `TaSTT`.
- Best fit for `VR-apps-lab`:
  avatar-facing text surfaces and future speech-to-text utility experiments.

## Method 91: Existing overlay keyboard patched into VRChat chatbox input

- What it is:
  a plugin augments an existing VR overlay keyboard or text-entry surface so it
  can send into a chatbox or other external text endpoint.
- Good for:
  text entry in overlay-first workflows, micro-patches to existing utility
  hosts, chatbox entry helpers, and retrofit-style integrations.
- Why it matters:
  it often costs less to patch an existing input surface than to build and own
  a full keyboard stack.
- Strong references:
  `xsoverlay-keyboard-osc`, `VRCTextboxOSC`.
- Best fit for `VR-apps-lab`:
  overlay patch tools, text-entry helpers, and small retrofits over existing VR
  UI hosts.

## Method 92: Configuration-driven OSC router with companion-process lifecycle management

- What it is:
  a focused routing host loads route presets, optionally launches companion
  tools, waits for a target VR app when needed, and handles cleanup on exit.
- Good for:
  sidecar suites, avatar-facing automation stacks, route-based OSC tools,
  small desktop orchestrators, and service bundles around one VR workflow.
- Why it matters:
  it treats `transport routing plus tool lifecycle` as one reusable product
  boundary instead of two unrelated scripts.
- Strong references:
  `VRCRouter`.
- Best fit for `VR-apps-lab`:
  small desktop orchestration shells and OSC-aware companion stacks.

## Method 93: Plugin-based device telemetry host with modular consumers and OSC side effects

- What it is:
  a desktop host acquires headset or device telemetry, exposes plugin
  boundaries for new consumers, and fans the data out through OSC or adjacent
  desktop integrations.
- Good for:
  device monitors, headset telemetry utilities, RGB or media side effects,
  modular consumer platforms, and broad desktop companion apps.
- Why it matters:
  it keeps acquisition, plugin logic, and consumer outputs from collapsing into
  one hardware-specific app.
- Strong references:
  `Quest2-VRC`, `OscGoesBrrr`.
- Best fit for `VR-apps-lab`:
  telemetry hosts, device-sidecar platforms, and modular companion utilities.

## Method 94: OSCQuery-aware avatar parameter bridge for desktop services, replay, and actuator control

- What it is:
  a utility discovers avatar parameters through OSCQuery, maps them into
  desktop or hardware actions, and may also cache or replay parameter state
  across context changes.
- Good for:
  audio-tool bridges, consumer automation tools, avatar-state persistence,
  desktop hotkey or device control, and VRChat sidecars.
- Why it matters:
  it turns avatar parameters into a general-purpose automation bus while
  preserving discovery and context continuity.
- Strong references:
  `VRCMeeter`, `VRCAvatarParameterSync`, `OSCLeash`, `OSCLock`.
- Best fit for `VR-apps-lab`:
  avatar-facing automation tools and parameter-aware companion services.

## Method 95: XR-glasses platform split across base driver, workspace shell, and game-mode wrapper

- What it is:
  a special-display stack separates hardware driver duties from workspace UX,
  then optionally wraps the whole platform in a Game Mode or platform-native
  control shell.
- Good for:
  XR glasses, Linux workspace shells, platform-specific wrappers, special
  displays, and future headset-adjacent desktop environments.
- Why it matters:
  it preserves clean ownership between `hardware access`, `workspace behavior`,
  and `platform-native control surfaces`.
- Strong references:
  `XRLinuxDriver`, `breezy-desktop`, `decky-XRGaming`.
- Best fit for `VR-apps-lab`:
  XR-glasses research, special-display stacks, and workspace-shell concepts.

## Method 96: User-session virtual display service coordinated through named-pipe IPC

- What it is:
  a virtual-display stack keeps driver installation separate from a
  user-session service and exposes a structured IPC layer for control apps or
  bindings.
- Good for:
  managed virtual displays, creator workflows, per-user display toggles,
  desktop streaming helpers, and control-panel style utilities.
- Why it matters:
  it treats `virtual display` as a managed service surface rather than only a
  one-time driver install.
- Strong references:
  `virtual-display-rs`.
- Best fit for `VR-apps-lab`:
  virtual-display service tools and desktop-side control hosts.

## Method 97: Captured desktop or video content transformed into a head-tracked spatial screen

- What it is:
  a utility captures desktop or video content, optionally transforms it, then
  stabilizes or presents it as a head-tracked screen on a special display.
- Good for:
  XR glasses, personal theater utilities, spatial screens, stereoscopic
  desktop tools, and narrow creator or media workflows.
- Why it matters:
  it clarifies the difference between `screen utility` and `full XR runtime or
  workspace shell`.
- Strong references:
  `viture_virtual_display`, `desktop2stereo`.
- Best fit for `VR-apps-lab`:
  spatial screen helpers and special-display utilities.

## Method 98: Wearable-haptics bridge with grouped outputs and change-tracked OSC routing

- What it is:
  a desktop bridge groups wearable outputs, tracks only changed OSC or avatar
  signals, and routes those changes into hardware behaviors with a usable
  settings surface.
- Good for:
  wearable haptics, avatar-driven feedback, grouped actuator control, social-VR
  hardware sidecars, and configurable tactile routers.
- Why it matters:
  it turns `avatar signal -> haptic hardware` into a reusable routing and
  grouping problem rather than a pile of one-off device calls.
- Strong references:
  `ShockOSC`, `VRC-Haptic-Pancake`.
- Best fit for `VR-apps-lab`:
  tactile sidecars, wearable routers, and avatar-driven hardware tools.

## Method 99: Sparse avatar contact solving into richer multi-actuator haptic placement

- What it is:
  a bridge observes a small set of avatar contact receivers, then solves or
  infers richer actuator placement across more hardware endpoints than the input
  authoring alone would suggest.
- Good for:
  haptic wearables, tactile solver experiments, sparse authoring workflows, and
  richer avatar-driven feedback without dense setup everywhere.
- Why it matters:
  it makes `solver logic` the main donor surface instead of requiring direct
  one-to-one mappings for every tactile event.
- Strong references:
  `vrc-patpatpat`.
- Best fit for `VR-apps-lab`:
  tactile inference experiments and avatar-driven haptic mapping research.

## Method 100: DIY tactile wearable platform split across firmware and hardware-reference repos

- What it is:
  a wearable ecosystem keeps firmware and hardware-reference artifacts in
  separate repos so the physical platform and the embedded software can evolve
  together without collapsing into one opaque package.
- Good for:
  maker wearables, firmware-plus-PCB ecosystems, tactile hardware experiments,
  and future donor lines that need both fabrication and embedded software
  references.
- Why it matters:
  it makes `DIY hardware platform structure` explicit and reusable, not only the
  final desktop bridge.
- Strong references:
  `senseshift-firmware`, `senseshift-hardware`.
- Best fit for `VR-apps-lab`:
  DIY tactile wearable research and broader custom-hardware donor systems.

## Method 101: Live chaperone editor over the SteamVR working copy

- What it is:
  a utility loads the current SteamVR chaperone working copy, exposes walls or
  playspace surfaces as editable geometry, and writes updates back without
  forcing the user through raw file edits.
- Good for:
  room-boundary editors, capture-space tools, in-headset setup utilities, and
  advanced room-alignment helpers.
- Why it matters:
  it turns `room setup` into a manipulable runtime surface rather than a hidden
  config file.
- Strong references:
  `ChaperoneTweak`, `RotatoExpress`.
- Best fit for `VR-apps-lab`:
  playspace tools and room-boundary authoring utilities.

## Method 102: Boundary import or file-editor workflow over chaperone geometry

- What it is:
  a tool imports room geometry from another runtime or edits raw chaperone files
  in a higher-level editor, then rewrites boundary data back into the target
  format.
- Good for:
  vendor-boundary importers, Unity-based room editors, desktop setup tools, and
  migration helpers between XR ecosystems.
- Why it matters:
  it separates `where boundaries come from` from `where they are consumed`.
- Strong references:
  `Guardian2Chaperone`, `unity-chaperone-tweaker`, `xr-chaperone`.
- Best fit for `VR-apps-lab`:
  boundary conversion tools and desktop-oriented room authoring flows.

## Method 103: Shared-playspace peer overlay over lightweight LAN pose broadcast

- What it is:
  a tool broadcasts local room-space pose to peers over a simple LAN protocol,
  then visualizes remote users as overlays or room markers with distance-aware
  presentation.
- Good for:
  co-located VR helpers, shared-room awareness, safety markers, and lightweight
  multi-user presence tools.
- Why it matters:
  it gives `shared physical space` its own minimal product shape without
  requiring a full session platform.
- Strong references:
  `OpenVRSharedPlayspace`.
- Best fit for `VR-apps-lab`:
  shared-space utilities and safety-oriented peer-visibility helpers.

## Method 104: Redirected-walking manager with pluggable redirectors, resetters, and motion controllers

- What it is:
  a central manager owns user-state updates and delegates behavior to swappable
  redirector, resetter, movement-controller, and statistics modules.
- Good for:
  redirected-walking toolkits, locomotion research, algorithm benchmarks, and
  configurable movement experiments.
- Why it matters:
  it keeps locomotion algorithms comparable instead of hard-wiring one method
  into one scene.
- Strong references:
  `RDWT`, `OpenRDW`.
- Best fit for `VR-apps-lab`:
  locomotion research notes and future movement-experiment scaffolds.

## Method 105: Batchable space-redirection experiment harness with path seeds, tracking spaces, and networked avatars

- What it is:
  a research stack models path generation, tracking-space variation, multi-user
  state, and batch command-file generation as first-class experiment surfaces.
- Good for:
  repeated locomotion experiments, multi-user redirected walking, fairness or
  synchronized-reset studies, and large parameter sweeps.
- Why it matters:
  it treats `space-redirection research` as a platform, not a single demo.
- Strong references:
  `OpenRDW2`.
- Best fit for `VR-apps-lab`:
  research-platform references and batchable locomotion study designs.

## Method 106: Comfort-heavy locomotion module with smoothing, prevention, and rewind layers

- What it is:
  a locomotion component layers controller smoothing, inertia, collision
  prevention, climb or fall checks, and rewind or pushback behavior into one
  movement stack.
- Good for:
  arm-swing movement, small-room locomotion, comfort-heavy prototypes, and
  movement systems that need guard rails.
- Why it matters:
  it makes `movement hygiene` an explicit reusable system instead of scattered
  one-off checks.
- Strong references:
  `ArmSwinger`.
- Best fit for `VR-apps-lab`:
  locomotion helpers and movement-comfort experiments.

## Method 107: Video-aligned motion-to-photon harness with scene-coded visual markers

- What it is:
  an XR scene tracks real movement proxies while encoding timing or state
  changes into visible screen colors so later video analysis can align physical
  and virtual motion.
- Good for:
  motion-to-photon measurement, controller-latency experiments, high-speed video
  workflows, and scene-based latency validation.
- Why it matters:
  it creates a reusable `alignment surface` between the engine and a camera.
- Strong references:
  `motion-to-photon-measurement`.
- Best fit for `VR-apps-lab`:
  measurement tools and latency-validation research.

## Method 108: External latency rig with microcontroller capture and brightness-coded engine output

- What it is:
  a utility couples a microcontroller-based measurement rig with engine-side
  visual encoding, so physical sensors can record end-to-end delay rather than
  only software timestamps.
- Good for:
  serious latency validation, distributed XR experiments, external validation of
  headset or streaming claims, and lab-grade measurement setups.
- Why it matters:
  it bridges `what the engine thinks happened` and `what the hardware actually
  showed`.
- Strong references:
  `VRLate`.
- Best fit for `VR-apps-lab`:
  measurement methodology and external-validation donor lines.

## Method 109: Scriptable XR latency lab built from reusable experiment classes

- What it is:
  a framework exposes display, tracking, and total-latency experiments as
  reusable classes over shared stimulus and Arduino abstractions.
- Good for:
  research labs, repeatable latency tests, custom experiment automation, and
  lightweight validation frameworks.
- Why it matters:
  it turns `latency testing` into a reusable library problem rather than a one
  off script or scene.
- Strong references:
  `vrlatency`.
- Best fit for `VR-apps-lab`:
  experiment harness design and validation-tool architecture.

## Method 110: Cacheable parser layer over rich XR recording logs with notebook analyzers on top

- What it is:
  a parser normalizes recorder output into cached structured arrays, then higher
  level notebook or analysis code consumes that cached representation.
- Good for:
  replay analytics, simulator research, offline investigation tools, and
  recording-debug workflows.
- Why it matters:
  it keeps parsing reusable while letting domain analysis evolve separately.
- Strong references:
  `dreyevr_recording_analyzer`, `DReyeVR-parser`.
- Best fit for `VR-apps-lab`:
  offline analysis tools and recording-introspection research.

## Method 111: Modular telemetry overlay host with adapters, widgets, and preset-aware lifecycle control

- What it is:
  a desktop host separates telemetry adapters, overlay state, widgets or
  modules, and preset loading into explicit layers rather than one monolithic
  overlay process.
- Good for:
  racing or sim overlays, compact status HUDs, tray-controlled overlays, and
  modular always-on-top utilities.
- Why it matters:
  it gives `overlay host architecture` a clear reusable blueprint.
- Strong references:
  `TinyPedal`.
- Best fit for `VR-apps-lab`:
  overlay hosts and modular desktop companion utilities.

## Method 112: Multi-instance telemetry sidecar with device-role ownership and IPC coordination

- What it is:
  a sidecar platform splits ownership of several device roles across master and
  child instances, then coordinates them over IPC while sharing telemetry and
  settings logic.
- Good for:
  multi-peripheral control stacks, FFB or haptics sidecars, specialized device
  shells, and large desktop companions.
- Why it matters:
  it prevents multi-device systems from collapsing into one opaque process with
  tangled state.
- Strong references:
  `VPforce-TelemFFB`.
- Best fit for `VR-apps-lab`:
  device-sidecar platforms and multi-role desktop services.

## Method 113: Telemetry normalization bridge from unsupported games into UDP, MMF, or callback outputs

- What it is:
  a platform acquires telemetry from many incompatible or injected sources, then
  normalizes that data into common transport formats for downstream tools.
- Good for:
  telemetry bridges, motion rigs, simulator sidecars, cross-game helper
  platforms, and protocol adapters.
- Why it matters:
  it treats `integration breadth` as a reusable bridge layer instead of one
  provider at a time.
- Strong references:
  `SpaceMonkey`.
- Best fit for `VR-apps-lab`:
  cross-runtime bridges and adapter-heavy utility platforms.

## Method 114: Research simulator platform split across VR runtime, sensor stream, and recorder or replayer pipeline

- What it is:
  a simulator stack separates immersive runtime behavior from structured sensor
  output and replay infrastructure, so the platform can serve both live use and
  offline analysis.
- Good for:
  research simulators, replay-aware VR platforms, richer experimental
  environments, and analytics-ready XR systems.
- Why it matters:
  it shows how `VR platform plus research data product` can be one coherent
  architecture.
- Strong references:
  `DReyeVR`.
- Best fit for `VR-apps-lab`:
  platform-level research references and replay-aware simulator tooling.

## Method 115: Mobile or handheld chatbox relay with a floating overlay entry surface

- What it is:
  a mobile-first tool exposes a floating entry surface, local history, and
  configurable local or remote targets, then forwards text into VRChat chatbox
  `OSC`.
- Good for:
  handheld relay tools, phone-assisted VR text entry, companion-device chatbox
  workflows, and lightweight in-headset communication helpers that do not
  require a desktop textbox.
- Why it matters:
  it turns `chat entry away from the desktop` into a distinct reusable product
  shape.
- Strong references:
  `Chatbox`.
- Best fit for `VR-apps-lab`:
  handheld relay utilities and remote-first text-entry experiments.

## Method 116: Translation and transcription desktop shell over overlay, local-model, and OSCQuery services

- What it is:
  a desktop shell keeps visible UI thin while backend services manage local
  speech models, translation or transcription, overlay surfaces, and
  `OSCQuery`-aware VRChat output.
- Good for:
  speech tools, translation sidecars, caption-adjacent social utilities,
  overlay-assisted chat helpers, and desktop companions that need richer local
  model management.
- Why it matters:
  it shows how `speech shell plus overlay plus OSC` can remain modular instead
  of collapsing into one monolith.
- Strong references:
  `VRCT`.
- Best fit for `VR-apps-lab`:
  speech-oriented social VR sidecars and overlay-plus-OSC desktop hosts.

## Method 117: Avatar text-surface installer driven by pointer-indexed parameter grids

- What it is:
  an editor-side system installs parameters, menus, and animator content, then
  uses a pointer plus chunked parameter blocks to display text directly on the
  avatar.
- Good for:
  avatar-visible text systems, reusable Unity installers, generated animator
  scaffolding, and communication tools that need more than one bounded chatbox
  line.
- Why it matters:
  it treats `avatar parameters as a display bus` rather than only a control
  surface.
- Strong references:
  `KillFrenzyAvatarText`, `TaSTT`.
- Best fit for `VR-apps-lab`:
  avatar-text tooling and editor-time install workflows.

## Method 118: Tiny buffered chatbox micro-utility with one background sender task

- What it is:
  a very small desktop utility keeps UI and user flow minimal while a single
  background queue task enforces chatbox timing and optional typing behavior.
- Good for:
  minimal VRChat helpers, one-value desktop utilities, rate-limited text
  senders, and compact companion tools that should stay legible and easy to
  reason about.
- Why it matters:
  it shows how little product surface is needed for a useful `text sender`
  utility.
- Strong references:
  `VRCOSCChatbox`.
- Best fit for `VR-apps-lab`:
  micro-utilities and single-purpose desktop helper patterns.

## Method 119: OSCQuery-aware discovery and auto-connect library for chatbox, tracker, or monitoring clients

- What it is:
  a reusable library exposes service discovery, advertising, and auto-connect
  flows so end-user tools can find compatible `OSCQuery` peers rather than rely
  on hardcoded endpoints.
- Good for:
  chatbox utilities, tracker bridges, monitor tools, desktop companions, and
  any future donor line that benefits from local auto-discovery.
- Why it matters:
  it turns `peer discovery` into a shareable utility layer instead of many
  one-off implementations.
- Strong references:
  `vrc-oscquery-lib`.
- Best fit for `VR-apps-lab`:
  shared discovery helpers and auto-connect infrastructure for future sidecars.

## Method 120: AI or automation bridge into VRChat OSC over a WebSocket relay

- What it is:
  a bridge keeps raw `OSC` behind a relay server while higher-level automation
  clients talk to a safer WebSocket or tool-oriented interface.
- Good for:
  AI companions, automation frameworks, tool servers, scripted control
  surfaces, and sidecars that should not embed low-level VRChat transport logic
  everywhere.
- Why it matters:
  it adds an explicit `relay boundary` between VRChat `OSC` and higher-level
  tools.
- Strong references:
  `vrchat-mcp-osc`.
- Best fit for `VR-apps-lab`:
  automation bridges and tool-facing service layers over avatar-facing inputs.

## Method 121: Animator-side smoothing layer generated from avatar-facing OSC parameters

- What it is:
  editor tooling generates proxy parameters, blendtrees, and behaviors so noisy
  avatar-facing `OSC` inputs can be smoothed on the consumer side.
- Good for:
  avatar animation cleanup, hand or face parameter smoothing, remote-input
  refinement, and Unity-side generators that save repetitive manual setup.
- Why it matters:
  it makes `parameter hygiene on the consumer side` a reusable construction
  method.
- Strong references:
  `OSCmooth`.
- Best fit for `VR-apps-lab`:
  avatar tooling and editor-generated refinement layers.

## Method 122: Diagnostics-rich desktop companion shell over typed IPC and service status surfaces

- What it is:
  a desktop host separates frontend and backend through typed IPC while
  exposing transport health, discovery status, config state, and diagnostics as
  first-class product surfaces.
- Good for:
  OSC companions, runtime helpers, desktop service shells, device-control apps,
  and broader utilities that need more than a hidden tray process.
- Why it matters:
  it gives `desktop companion architecture` a clearer blueprint than a single
  script or form.
- Strong references:
  `OscGoesBrrr`.
- Best fit for `VR-apps-lab`:
  larger desktop hosts with explicit diagnostics and service coordination.

## Method 123: XR-glasses workspace shell layered over driver, compositor, and environment hooks

- What it is:
  a workspace shell sits above the base hardware driver and integrates with the
  host compositor or environment instead of bundling every layer into one repo
  role.
- Good for:
  XR-glasses productivity shells, special-display workspace tools,
  platform-native wrappers, and display stacks that need clear ownership
  between device access and UX.
- Why it matters:
  it keeps `special-display UX` separate from `special-display hardware access`.
- Strong references:
  `breezy-desktop`, `XRLinuxDriver`.
- Best fit for `VR-apps-lab`:
  workspace-shell research and layered special-display utility design.

## Method 124: 2D-to-stereo screen pipeline with latest-frame capture, depth estimation, and multi-output modes

- What it is:
  a utility captures ordinary desktop or video content, estimates depth, and
  emits stereoscopic or other special-display outputs through a latest-frame
  processing pipeline.
- Good for:
  XR-glasses screen tools, nontraditional display experiments, creator-facing
  screen pipelines, and display workflows that do not own the runtime.
- Why it matters:
  it treats `screen transformation` as its own reusable product branch instead
  of a side effect of a driver stack.
- Strong references:
  `desktop2stereo`.
- Best fit for `VR-apps-lab`:
  screen-transformation utilities and special-display comparison work.

## Method 125: Lightweight OpenVR HMD driver over a glasses IMU backend

- What it is:
  a thin OpenVR driver adapts glasses orientation data into a tracked-device and
  display-component path that looks like a headset to the runtime.
- Good for:
  custom HMD experiments, special-display runtime paths, driver learning,
  glasses integrations, and minimal device-plumbing prototypes.
- Why it matters:
  it shows the minimum useful structure for `nonstandard display as an HMD`.
- Strong references:
  `OpenVR-xrealAirGlassesHMD`.
- Best fit for `VR-apps-lab`:
  device-plumbing research and thin runtime-facing display adapters.

## Method 126: 3DoF glasses head-tracking sidecar for UDP or mouse-look consumers

- What it is:
  a thin desktop sidecar reads head orientation from a glasses device, applies
  filtering and mappings, and exports that motion to non-XR consumers such as
  opentrack or mouse-look.
- Good for:
  non-VR head tracking, sim or creator tools, hybrid display workflows, and
  situations where a full XR runtime would be overkill.
- Why it matters:
  it turns `special-display tracking` into a reusable sidecar problem rather
  than only a runtime-integration problem.
- Strong references:
  `PhoenixHeadTracker`.
- Best fit for `VR-apps-lab`:
  tracking sidecars and non-runtime head-orientation bridges.

## Method 127: Thin biometric bridge with OSCQuery auto-config, multi-client fan-out, and chatbox templating

- What it is:
  a focused bridge discovers VRChat clients automatically, fans biometric values
  out to several avatar or chatbox targets, and supports small template-driven
  message output.
- Good for:
  heart-rate overlays, wearable-to-avatar bridges, in-VR status surfaces, and
  thin monitoring tools that still need clean discovery.
- Why it matters:
  it shows how `one-value bridge` tools can still have strong discovery and UX
  polish.
- Strong references:
  `PulsoidToOSC`.
- Best fit for `VR-apps-lab`:
  biometric bridges and small telemetry-to-avatar utilities.

## Method 128: Rich biometric sidecar platform with multiple inputs, charts, logs, and output sinks

- What it is:
  a richer host keeps transport inputs, charts, logs, files, and output sinks
  coordinated through one operator-facing companion shell.
- Good for:
  biometrics companions, multi-source monitoring apps, research sidecars,
  operator dashboards, and desktop tools that must expose state rather than act
  like invisible bridges.
- Why it matters:
  it turns `biometric tooling` into a full sidecar-platform pattern rather than
  a single sensor relay.
- Strong references:
  `iron-heart`.
- Best fit for `VR-apps-lab`:
  operator-facing biometrics shells and richer telemetry companions.

## Method 129: Plugin-oriented avatar-facing accessory manager with persisted settings and OSCQuery services

- What it is:
  a host application provides logging, config, and plugin registration while
  individual accessory plugins expose their own parameters and settings
  callbacks on top of avatar-facing `OSC`.
- Good for:
  actuator ecosystems, modular consumer-device bridges, settings-heavy desktop
  hosts, and broader accessory-control platforms.
- Why it matters:
  it keeps `one host, many accessories` maintainable instead of hardwiring each
  target device into the core app.
- Strong references:
  `vrc-osc-manager`.
- Best fit for `VR-apps-lab`:
  accessory-control hosts and plugin-oriented sidecar platforms.

## Method 130: Minimal browser-plus-local bridge for wearable telemetry into avatar-facing OSC

- What it is:
  a browser acquires wearable data through WebBluetooth or a similar web-facing
  input API while a tiny local bridge forwards normalized values into avatar-
  facing `OSC`.
- Good for:
  fast wearable experiments, low-overhead heart-rate bridges, browser-assisted
  device integrations, and situations where a full desktop host would be
  unnecessary.
- Why it matters:
  it makes `web plus local bridge` a clear reusable pattern for simple device
  integrations.
- Strong references:
  `vrc-osc-miband-hrm`.
- Best fit for `VR-apps-lab`:
  lightweight wearable bridges and quick acquisition-to-OSC prototypes.

## Method 131: Embedded accessory-control firmware with OSC, browser config, and emergency-stop surfaces

- What it is:
  embedded firmware owns Wi-Fi onboarding, local config, accessory control, and
  an emergency-stop path while exposing `OSC` and browser configuration
  surfaces.
- Good for:
  safety-aware controllers, standalone accessory devices, networked DIY
  hardware, and embedded companions that should not depend on a large desktop
  host.
- Why it matters:
  it treats `controller safety and config UX` as a first-class architecture
  concern on the device itself.
- Strong references:
  `OpenShock-ESP-Legacy`.
- Best fit for `VR-apps-lab`:
  embedded controller research and accessory-control platform design.

## Method 132: Hierarchical biosignal schema flattened into VRChat-friendly OSC paths

- What it is:
  an internal signal model keeps biometrics and other measurements structured as
  a nested tree, then a reporter layer flattens that tree into the path format
  VRChat and similar consumers expect.
- Good for:
  neurofeedback tools, biosignal exporters, complex telemetry-to-avatar
  bridges, and systems that should preserve richer semantics internally.
- Why it matters:
  it avoids collapsing all signal meaning into one flat parameter bag too early.
- Strong references:
  `BrainFlowsIntoVRChat`.
- Best fit for `VR-apps-lab`:
  richer telemetry schemas and measurement-heavy avatar-facing tools.

## Method 133: Engine-native projection-overlay extension over an existing scene graph

- What it is:
  an engine extension exposes overlay-specific runtime hooks so an ordinary 3D
  scene can render as an `OpenVR` projection overlay instead of becoming the
  main scene app.
- Good for:
  in-VR annotation, helper scenes, tracked debug visuals, room markup, and
  narrow overlay tools that still want full engine rendering and input.
- Why it matters:
  it avoids rebuilding scene logic in a separate overlay process when the real
  donor value is `engine-native scene content as overlay`.
- Strong references:
  `godot-openvr-overlay`, `VRSceneOverlay`.
- Best fit for `VR-apps-lab`:
  future engine-backed overlays and scene-native helper surfaces.

## Method 134: Offscreen UI stack bridged into an overlay texture with explicit OpenVR event forwarding

- What it is:
  a UI stack such as `ImGui`, Win32, or Unity UI renders offscreen, then the
  resulting texture is submitted to `OpenVR` while overlay events are translated
  back into the UI input model.
- Good for:
  dashboard tools, settings panels, debug UIs, and focused control surfaces
  that need ordinary widgets without adopting a full browser stack.
- Why it matters:
  it turns `overlay UI` into a reusable bridge pattern instead of a one-off
  sample.
- Strong references:
  `csharp-openvr-overlay-imgui`, `OpenVROverlay_imgui`, `SampleVRO`,
  `LibOverlay`.
- Best fit for `VR-apps-lab`:
  desktop-backed panels, debug tools, and lightweight in-headset control UIs.

## Method 135: Focused overlay wrapper over external launcher or media toolchains

- What it is:
  an overlay stays intentionally small and delegates launching, playback,
  capture, or media state to external desktop tools or buses.
- Good for:
  quick-launch panels, media controls, video surfaces, and cases where the
  overlay should orchestrate rather than own the full media stack.
- Why it matters:
  it is often cheaper and cleaner to wrap a capable external tool than to turn
  the overlay itself into a heavyweight desktop suite.
- Strong references:
  `launcher-openvr-overlay`, `mpris-openvr-overlay`, `vr-video-player-overlay`,
  `MPVR`.
- Best fit for `VR-apps-lab`:
  focused display shells and narrow media/control surfaces.

## Method 136: Overlay plus localhost dashboard sidecar for live communication or creator control state

- What it is:
  the headset overlay is paired with a localhost web panel or local client API
  so the same tool can be adjusted from desktop while staying visible in VR.
- Good for:
  communication overlays, creator control surfaces, operator tools, and any
  stateful overlay that benefits from richer out-of-headset configuration.
- Why it matters:
  it keeps the VR surface compact while preserving a stronger operator
  experience on desktop.
- Strong references:
  `SteamVR-Discord-Overlay`, `VRBro-Overlay`, `h-view`.
- Best fit for `VR-apps-lab`:
  dual-surface sidecars that need both in-headset presence and desktop control.

## Method 137: Session-scoped annotation or questionnaire station driven by an explicit scene or data model

- What it is:
  an overlay owns a small scene state or study schema rather than mirroring a
  desktop window, and updates that state directly from controller actions or
  operator inputs.
- Good for:
  drawing, markup, guided studies, questionnaires, checklists, and operator-led
  VR tasks that need structure rather than raw screen sharing.
- Why it matters:
  it treats the overlay as a first-class application with its own state model,
  not as a thin visual wrapper over another app.
- Strong references:
  `vr-notes-anywhere`, `ROVER`.
- Best fit for `VR-apps-lab`:
  research stations, annotation tools, and structured workflow surfaces.

## Method 138: Context-aware companion or anchored-awareness overlay driven by remote state, gestures, or room geometry

- What it is:
  an overlay exists to visualize one contextual thing in the user's space:
  another person, a wrist timer, or a known environmental object.
- Good for:
  collaborator awareness, safety helpers, equipment awareness, game-specific
  status overlays, and remote-presence markers.
- Why it matters:
  it shows that a good overlay can be defined by `what contextual state it
  knows`, not by how much generic desktop functionality it exposes.
- Strong references:
  `steamvr-overlay-vrbuddy`, `SmudgeTimerOpenVR`, `VRPoleOverlay`.
- Best fit for `VR-apps-lab`:
  contextual micro-overlays and specialized awareness surfaces.

## Method 139: Browser runtime overlay host with native backend, child app daemons, and local HTTP or IPC contracts

- What it is:
  a native `OpenVR` host owns handles, process launch, and texture transport
  while browser-facing app surfaces live in child runtimes, daemons, or local
  web apps.
- Good for:
  overlay runtime platforms, multi-app hosts, local web-driven utilities, and
  overlays where the app logic should stay separate from the headset shell.
- Why it matters:
  it turns `overlay host` into a reusable runtime boundary instead of one more
  monolithic utility app.
- Strong references:
  `ovrsalt`, `ovrly`.
- Best fit for `VR-apps-lab`:
  browser-backed overlay platforms and local-runtime host experiments.

## Method 140: Offscreen desktop UI runtime mirrored directly into an OpenVR texture stream

- What it is:
  an offscreen browser or declarative desktop UI runtime renders frames that
  are captured and submitted directly to an `OpenVR` overlay texture.
- Good for:
  `Electron` overlays, desktop-first tools with VR presence, fast UI
  experimentation, and modern declarative interface stacks.
- Why it matters:
  it makes `desktop UI runtime -> VR overlay` a clear bridge pattern instead of
  a one-off hack.
- Strong references:
  `electron-openvr`, `ComposeVR`, `Omni-Tune`.
- Best fit for `VR-apps-lab`:
  desktop-first companion tools and alternative overlay UI runtime experiments.

## Method 141: Linux desktop or system-service overlay shell with a non-VR debug path and controller-mouse interaction

- What it is:
  a Linux overlay shell couples desktop capture or service panels with
  controller-driven interaction and preserves a desktop-only mode for debugging
  and iteration.
- Good for:
  Linux overlay shells, service-panel dashboards, device-routing tools, and
  environments where in-headset debugging would be too slow.
- Why it matters:
  it treats `desktop fallback` as a first-class engineering pattern rather than
  a temporary hack.
- Strong references:
  `OVR4X11`, `SVRLinuxTools`, `OpenVR_Audio_Manager`.
- Best fit for `VR-apps-lab`:
  Linux-side control shells and stateful routing or inventory overlays.

## Method 142: Micro-overlay exposed as a tiny local HTTP or OSC control plane

- What it is:
  a very small overlay keeps its VR-side surface simple while exposing a local
  `HTTP` or `OSC` endpoint that lets external tools drive state changes.
- Good for:
  comfort helpers, automation-friendly overlay widgets, one-value status
  surfaces, and local integrations that do not need a full desktop app.
- Why it matters:
  it makes `micro-overlay plus local automation surface` a reusable product
  pattern.
- Strong references:
  `OVRBrightnessAPI`.
- Best fit for `VR-apps-lab`:
  tiny comfort tools and easily scriptable overlay helpers.

## Method 143: Plugin-fed informational surface with reusable providers and multiple output sinks

- What it is:
  data providers or plugins generate small contextual information while the
  host can route the result to an in-headset overlay, chatbox, file, or other
  output sink.
- Good for:
  status surfaces, workflow overlays, automation dashboards, and tools that
  should serve more than one consumer at once.
- Why it matters:
  it avoids hardwiring `one informational surface = one output path`.
- Strong references:
  `VR-Slideshow-Overlay`.
- Best fit for `VR-apps-lab`:
  modular informational surfaces and multi-consumer helper tools.

## Method 144: Timer-driven overlay that escalates from passive HUD to closeable notification and restart loop

- What it is:
  an overlay begins as a passive time or session surface, then transitions into
  a stronger reminder or notification flow that supports dismissal or restart.
- Good for:
  break reminders, session hygiene tools, guided routines, and small behavior
  nudges inside VR.
- Why it matters:
  it makes `status display` and `intervention loop` explicit stages of the same
  product.
- Strong references:
  `VRSessionTimer`.
- Best fit for `VR-apps-lab`:
  session helpers, reminder overlays, and intervention-oriented micro-tools.

## Method 145: Embodied locomotion overlay that maps gaze or tracker motion into avatar-control intent

- What it is:
  an overlay plus control stack turns body motion, tracker deltas, or gaze
  inputs into locomotion or avatar-facing movement signals.
- Good for:
  controllerless locomotion, embodied exercise overlays, tracker-driven motion
  helpers, and avatar-facing movement adapters.
- Why it matters:
  it treats the overlay as part of a bodily control loop rather than a passive
  status display.
- Strong references:
  `bikeheadvr`.
- Best fit for `VR-apps-lab`:
  embodied-control experiments and movement-side helper tools.

## Method 146: Desktop editor paired with a native VR helper over a framed streaming protocol

- What it is:
  a richer desktop editor owns profiles and editing UX while a smaller native
  VR helper mirrors just the live tuning state into an overlay surface.
- Good for:
  tuning tools, profile editors, creator utilities, and any workflow where the
  desktop should remain the main editing surface.
- Why it matters:
  it prevents `VR presence` from forcing the entire tool into the headset.
- Strong references:
  `Omni-Tune`.
- Best fit for `VR-apps-lab`:
  live tuning surfaces and desktop-first tools with in-headset feedback.

## Method 147: External-device control overlay with persisted config, hand switching, and remote API fan-out

- What it is:
  a headset overlay controls remote devices through an API client while keeping
  configuration, placement, and hand-specific behavior as explicit local state.
- Good for:
  networked accessory control, remote hardware panels, in-headset device UIs,
  and overlays that must manage both local and remote state.
- Why it matters:
  it turns `overlay as remote-device control panel` into a reusable product and
  architecture pattern.
- Strong references:
  `OVR-Shock`, `OpenShock/VROverlay`.
- Best fit for `VR-apps-lab`:
  remote-device overlays and external-accessory control surfaces.

## Method 148: Raw OpenVR texture-submit baseline over a tiny GL or rawdraw render loop

- What it is:
  a very small overlay host renders into a local OpenGL surface, copies or
  uploads that surface into a texture, and submits the texture directly to
  `OpenVR`.
- Good for:
  bring-up references, minimal overlay experiments, language-port baselines,
  and cases where the real need is understanding the smallest working overlay
  loop.
- Why it matters:
  it keeps `minimum viable overlay` explicit instead of forcing every future
  idea through a large host framework.
- Strong references:
  `OpenGL-VROverlay`, `openvr-overlay-test`.
- Best fit for `VR-apps-lab`:
  low-level overlay prototypes and implementation references.

## Method 149: Desktop or app-window capture pipeline mirrored into an OpenVR overlay texture

- What it is:
  a real desktop or application window is captured, converted into a GPU-ready
  image or texture, and then mirrored into an `OpenVR` overlay.
- Good for:
  desktop proxy surfaces, app-window overlays, Linux capture helpers, and
  focused workflows where one external window should appear in-headset.
- Why it matters:
  it turns `window capture -> overlay texture` into a reusable bridge pattern
  instead of a one-off hack.
- Strong references:
  `OpenVRWindowOverlay`, `OVR_SLDO`.
- Best fit for `VR-apps-lab`:
  desktop-adjacent overlays and focused reference-window utilities.

## Method 150: Projection-overlay wrapper with explicit per-eye frusta and transform-direction notes

- What it is:
  an overlay host reads per-eye frusta and eye transforms from the runtime,
  renders matching textures, and pushes the corresponding projection metadata
  back into `OpenVR` while documenting the correct transform direction.
- Good for:
  projection overlays, per-eye experimental surfaces, passthrough-style
  overlays, and math-heavy runtime bring-up work.
- Why it matters:
  public documentation for this corner of `OpenVR` is thin, so a verified
  worked example is unusually valuable.
- Strong references:
  `openvr-overlay-bunny`.
- Best fit for `VR-apps-lab`:
  projection-overlay experiments and transform-debug references.

## Method 151: UIToolkit overlay scaffold with explicit OpenVR event-to-UI bridging

- What it is:
  a Unity overlay template owns a `RenderTexture` or UI document while a
  dedicated bridge translates `OpenVR` overlay events into UI pointer, click,
  hover, and scroll semantics.
- Good for:
  Unity utility overlays, structured in-headset tools, reusable UI templates,
  and cases where conventional UI widgets should behave correctly in VR.
- Why it matters:
  it makes `overlay input bridge` an explicit reusable layer instead of hiding
  it inside one project.
- Strong references:
  `uitoko-ovr`.
- Best fit for `VR-apps-lab`:
  Unity overlay templates and higher-level UI scaffolds.

## Method 152: Managed-language overlay host with GPU-native texture interop and controller-attached defaults

- What it is:
  a managed-language host initializes `OpenVR`, prepares GPU-native texture data
  such as Vulkan or DXGI handles, and attaches the overlay to a controller or
  tracked node with minimal extra framework.
- Good for:
  managed-language experiments, narrow utility overlays, texture interop demos,
  and scaffolds where the runtime behavior should stay visible.
- Why it matters:
  it proves that `managed-language overlay host` does not have to give up direct
  compositor-facing texture transport.
- Strong references:
  `OpenVR-Overlay`.
- Best fit for `VR-apps-lab`:
  managed overlay hosts and GPU interop experiments.

## Method 153: Desktop-side content feeder that refreshes a narrow overlay through scripts, files, or local services

- What it is:
  a helper script, file contract, or local service owns content acquisition
  while the overlay only refreshes a small in-headset surface from those
  external artifacts.
- Good for:
  media status overlays, now-playing surfaces, app-specific overlays, and tools
  where desktop context should remain outside the overlay host itself.
- Why it matters:
  it preserves a clean split between `data producer` and `overlay renderer`.
- Strong references:
  `BasicOverlay`, `WT-OpenVR-Overlay`.
- Best fit for `VR-apps-lab`:
  desktop-first companion overlays and app-specific control surfaces.

## Method 154: Secure companion bridge that feeds a tabbed overlay shell over encrypted local networking

- What it is:
  an external device or phone talks to a local overlay shell through an
  encrypted transport, while the overlay exposes richer state, keyboard input,
  and tabbed workflows in VR.
- Good for:
  phone companions, secure notification mirrors, message or chat utilities, and
  device-facing overlay shells.
- Why it matters:
  it makes `companion overlay` a serious architecture pattern rather than a
  throwaway notification mirror.
- Strong references:
  `OVRPhoneBridge`.
- Best fit for `VR-apps-lab`:
  secure device companions and stateful bridge-driven overlays.

## Method 155: Desktop-authored text or image micro-overlay generated on demand from local UI state

- What it is:
  a small desktop utility lets the operator type, paste, or assemble content,
  rasterizes that content locally, and sends it into a transient or narrow VR
  overlay surface.
- Good for:
  text pushers, notification helpers, ephemeral notes, operator cues, and other
  small one-value overlays.
- Why it matters:
  it shows that a useful overlay can be driven by a tiny desktop authoring tool
  instead of a full local service or dashboard host.
- Strong references:
  `ViveOverlayPaster`.
- Best fit for `VR-apps-lab`:
  operator-driven micro-tools and transient content surfaces.

## Method 156: Spatial passthrough cutout overlay managed through a dashboard and controller grab or resize flow

- What it is:
  an overlay host manages one or more world-space colored boxes or quads that
  are edited from a dashboard and manipulated physically with controllers so an
  external passthrough or chroma-key system can turn them into view cutouts.
- Good for:
  desk cutouts, keyboard visibility windows, passthrough helpers, and other
  spatial masking tools.
- Why it matters:
  it turns `overlay as visual hole into the physical world` into a reusable
  product and architecture pattern.
- Strong references:
  `OpenMixerXR`.
- Best fit for `VR-apps-lab`:
  passthrough cutout tools and effect-first spatial overlays.

## Method 157: Visibility-shaping comfort overlay anchored to head pose, field-of-view, or roll

- What it is:
  a narrow overlay uses HMD-relative placement or orientation to mask part of
  the visible field, stabilize a comfort shape, or add a persistent visual
  intervention.
- Good for:
  motion-sickness comfort tools, field-of-view masks, static image effects, and
  other overlays that shape perception rather than display app content.
- Why it matters:
  it makes `visual intervention overlay` a reusable family instead of a set of
  isolated novelty projects.
- Strong references:
  `SteamVRBlackBarOverlay`, `VR-Overlay-Half_Ring`,
  `OpenVR-Windows-Activation`.
- Best fit for `VR-apps-lab`:
  comfort overlays, visibility-shaping tools, and specialized effect surfaces.

## Method 158: Single-file OpenXR bootstrap with explicit extension filtering and graphics bring-up

- What it is:
  a compact sample keeps instance creation, extension filtering, graphics
  requirements, swapchains, action sets, and the frame loop visible in one
  place instead of spreading them across a larger framework.
- Good for:
  bring-up references, low-level debugging, first OpenXR utilities, and
  comparing graphics-backend setup paths.
- Why it matters:
  it provides an honest `minimum viable OpenXR app` donor that future tools can
  learn from without reverse-engineering a large sample suite.
- Strong references:
  `OpenXRSamples`.
- Best fit for `VR-apps-lab`:
  OpenXR bring-up notes and runtime-facing graphics prototypes.

## Method 159: Structured OpenXR app split into context, headset, controllers, mirror view, and renderer

- What it is:
  an OpenXR sample app separates runtime and graphics bring-up, headset frame
  lifecycle, controller bindings and spaces, mirror output, and rendering into
  explicit modules.
- Good for:
  reusable XR app scaffolds, diagnostics tools, sample-based prototypes, and
  future utility apps that should stay engine-light.
- Why it matters:
  it shows a stronger middle ground between a one-file tutorial and a full
  engine integration.
- Strong references:
  `openxr-vulkan-example`.
- Best fit for `VR-apps-lab`:
  structured OpenXR sample architecture and future utility-app scaffolds.

## Method 160: Shared OpenXR utility core reused across many tiny feature samples

- What it is:
  a repo centralizes loader, session, and common utility flow in one shared
  OpenXR layer while keeping feature demos small and specific.
- Good for:
  sample suites, experimental branches, feature spikes, and codebases that need
  many XR experiments over one stable runtime baseline.
- Why it matters:
  it prevents `feature sample sprawl` from forcing every experiment to
  reimplement XR bring-up from scratch.
- Strong references:
  `android_openxr_gles`.
- Best fit for `VR-apps-lab`:
  shared XR utility layers and feature-sample comparison work.

## Method 161: Safe and raw OpenXR binding stack generated from the Khronos registry

- What it is:
  a binding project keeps a low-level raw layer close to the native API while
  exposing a safer or more ergonomic wrapper layer above it.
- Good for:
  new XR tooling stacks, language bindings, wrapper libraries, and runtimes
  that need both power-user and ergonomic entry points.
- Why it matters:
  it separates `native API fidelity` from `ergonomic host-language use` instead
  of forcing one compromise surface.
- Strong references:
  `openxrs`.
- Best fit for `VR-apps-lab`:
  future XR binding experiments and language-level tool foundations.

## Method 162: Build-integrated binding generator that adapts API naming to host-language conventions

- What it is:
  wrapper code is generated during the build rather than only pre-shipped, and
  the emitted surface is adapted to the naming and idioms of the target
  language.
- Good for:
  bindings, SDK facades, language-specific toolchains, and repos where the
  generator should stay a visible part of maintenance.
- Why it matters:
  it keeps code generation honest and reproducible while still producing a
  host-language-friendly API.
- Strong references:
  `openxr-zig`.
- Best fit for `VR-apps-lab`:
  future wrapper-generation experiments and host-language adaptation notes.

## Method 163: Packaged Python OpenXR facade over generated raw calls with optional API-layer insertion

- What it is:
  generated raw calls are wrapped in a more Pythonic layer, loader handling is
  packaged for the host OS, and optional tooling exists to insert a Python-side
  API layer into the OpenXR flow.
- Good for:
  scripting-heavy XR tools, automation, rapid experiments, and lightweight
  inspection utilities.
- Why it matters:
  it shows that a scripting language can still participate in serious
  runtime-level XR work rather than only calling into finished apps.
- Strong references:
  `pyopenxr`.
- Best fit for `VR-apps-lab`:
  scripting-first XR tooling and rapid OpenXR experiments.

## Method 164: OpenVR runtime facade that separates one-time context initialization from subsystem handles

- What it is:
  a wrapper initializes OpenVR once, then exposes typed handles or subsystems
  such as compositor, system, or chaperone through explicit runtime-owned
  objects.
- Good for:
  wrappers, language bindings, experiments, and utility code that should avoid
  global runtime confusion.
- Why it matters:
  it makes runtime ownership clear and reduces wrapper ambiguity around
  `who owns OpenVR state`.
- Strong references:
  `rust-openvr`.
- Best fit for `VR-apps-lab`:
  OpenVR wrapper notes and runtime-facing tool foundations.

## Method 165: Object-oriented OpenVR wrapper with heartbeat-based draw, input, and update loops

- What it is:
  a higher-level OpenVR facade centralizes runtime lifecycle and exposes
  repeating draw, input, and update phases as explicit wrapper concepts rather
  than leaving every app to rediscover them.
- Good for:
  managed-language utility hosts, runtime-facing app frameworks, and broader
  OpenVR-based tool shells.
- Why it matters:
  it turns `OpenVR app structure` into a reusable architecture pattern instead
  of a project-specific convention.
- Strong references:
  `OpenVR.NET`.
- Best fit for `VR-apps-lab`:
  managed OpenVR hosts and higher-level runtime façade experiments.

## Method 166: OpenVR tracking-export bridge with pluggable publishers for ROS, WebSocket, file, or other consumers

- What it is:
  one tracking host owns OpenVR collection while separate publisher modules
  relay the resulting data into ROS, WebSocket, files, or other consumers.
- Good for:
  robotics bridges, diagnostics exporters, multi-consumer tracking tools, and
  runtime-side telemetry services.
- Why it matters:
  it keeps `tracking collection` separate from `transport choice`, which makes
  future extensions much easier.
- Strong references:
  `openvr_ros_bridge`.
- Best fit for `VR-apps-lab`:
  tracker-export services and modular telemetry helpers.

## Method 167: OpenVR pose recorder and replayer that serializes device metadata and motion timelines

- What it is:
  a runtime tool records device properties and timed pose or input samples into
  a structured format, then replays them through another OpenVR-facing layer.
- Good for:
  reproducible debugging, playback harnesses, regression scenarios, simulated
  tracking, and test fixtures around motion data.
- Why it matters:
  it turns transient runtime behavior into reusable artifacts for later
  debugging or comparison.
- Strong references:
  `openvr-input-recorder`.
- Best fit for `VR-apps-lab`:
  tracking capture, replay harnesses, and motion-debug tooling.

## Method 168: Native VR consumer for ROS or robotics topics with both world-space data and HMD-relative overlays

- What it is:
  a VR app consumes robotics topics directly and presents them as point clouds,
  markers, transforms, images, or UI surfaces inside VR.
- Good for:
  robotics visualization, operator workspaces, inspection tools, and XR clients
  for external simulation or sensing systems.
- Why it matters:
  it shows the other half of the bridge pattern: not just exporting VR data
  outward, but pulling external runtime data into VR as a native client.
- Strong references:
  `vrviz`.
- Best fit for `VR-apps-lab`:
  robotics-facing XR clients and external-data visualization tools.

## Method 169: Manager-plus-driver virtual-tracker platform with OSC ingress, runtime health checks, and synthetic-device pooling

- What it is:
  a desktop manager owns transport, runtime checks, skeletal or tracker
  configuration, and user-facing control while a paired driver exposes a larger
  pool of synthetic SteamVR devices.
- Good for:
  virtual tracker platforms, calibration helpers, motion-compensation tools,
  and reusable ingress hosts that should support many upstream sources.
- Why it matters:
  it separates `transport and operator UX` from `SteamVR device exposure`,
  which scales much better than one-off tracker drivers.
- Strong references:
  `VirtualMotionTracker`.
- Best fit for `VR-apps-lab`:
  tracker hosts, OSC-driven synthetic devices, and validation-friendly virtual
  tracker services.

## Method 170: Action-manifest OpenVR utility that exports controller state to OSC through config-defined mappings

- What it is:
  a small OpenVR utility reads action-manifest values, converts them into OSC
  messages, and lets mapping logic stay mostly in configuration instead of deep
  custom runtime code.
- Good for:
  avatar-facing bridges, control-surface exports, quick controller-to-OSC
  tools, and thin automation helpers.
- Why it matters:
  it shows that `controller to OSC` can be a narrow utility layer instead of a
  full driver or heavyweight companion stack.
- Strong references:
  `SteamVR_To_OSC`, `OVR-VRC-OSC-Bridge`.
- Best fit for `VR-apps-lab`:
  small controller export tools and declarative input-translation surfaces.

## Method 171: Protocol adapter and validation layer around an existing virtual-tracker host

- What it is:
  a repo does not reinvent SteamVR device exposure; instead it adapts another
  upstream protocol or data model into an existing tracker host and adds small
  validation utilities around that boundary.
- Good for:
  protocol bridges, fast experiments, compatibility layers, and skeletal or
  tracker integration testing.
- Why it matters:
  it reduces duplicated driver work and keeps new experiments focused on the
  data contract that is actually changing.
- Strong references:
  `VMC2VMT`, `SkeletonPoseTester`.
- Best fit for `VR-apps-lab`:
  adapter layers into established tracker platforms and small validation nodes.

## Method 172: Plugin-manifest runtime or overlay platform with service-daemon sidecars

- What it is:
  a host platform loads plugins from explicit manifests while background
  daemons or services own long-running runtime coordination and lower-level
  integration work.
- Good for:
  extensible utility platforms, multi-plugin runtime tools, service-backed
  overlay shells, and larger research labs that should stay modular.
- Why it matters:
  it turns `plugin platform` into a reusable architecture pattern rather than a
  product-specific implementation accident.
- Strong references:
  `vrkit-platform`.
- Best fit for `VR-apps-lab`:
  extensible runtime-tool hosts and multi-module research platforms.

## Method 173: Desktop XR shell split across session host, OpenXR API layer, and XR landing-space app

- What it is:
  one repo divides responsibility between a desktop session or streamer host,
  an API-layer integration surface, and an XR-side client or landing-space
  application.
- Good for:
  runtime-side platforms, desktop-to-XR shells, session-owning workbenches, and
  hybrid OpenXR utility products.
- Why it matters:
  it makes `XR shell` a composable system of cooperating processes instead of a
  monolith.
- Strong references:
  `clearxr-server`.
- Best fit for `VR-apps-lab`:
  runtime-side utility platforms and future desktop-plus-XR companion systems.

## Method 174: OpenXR inspector or layer manager that shares one loader-state model across GUI, CLI, linting, and fix flows

- What it is:
  a runtime inspector keeps one canonical view of loader or layer state and
  reuses it across GUI displays, CLI summaries, lint passes, and repair
  actions.
- Good for:
  doctor tools, runtime diagnostics, repair assistants, and any project that
  should expose the same truth in multiple operator surfaces.
- Why it matters:
  it prevents `diagnostic drift` between interfaces and makes fix actions more
  trustworthy.
- Strong references:
  `openxr-explorer`, `OpenXR-API-Layers-GUI`.
- Best fit for `VR-apps-lab`:
  OpenXR doctor tools, runtime inspectors, and layer-state fixers.

## Method 175: Mixed-VR bridge that reuses official controller profiles and render models while sourcing pose or input from another runtime

- What it is:
  a bridge surfaces foreign-runtime devices inside SteamVR while deliberately
  reusing official controller bindings, render models, or role semantics.
- Good for:
  mixed-runtime controller bridges, alternative-hardware reuse, and
  controller-emulation paths that should feel native inside SteamVR.
- Why it matters:
  it makes the bridge more maintainable and more compatible than inventing a
  completely custom controller identity.
- Strong references:
  `Oculus_Touch_Steam_Link`, `SteamVR-OpenHMD`, `PSVR-SteamVR-openHMD`.
- Best fit for `VR-apps-lab`:
  mixed-runtime controller bridges and hardware-adaptation experiments.

## Method 176: External-command synthetic-device driver with named-pipe or socket command grammar, state updates, and fixed-pose fallback

- What it is:
  a SteamVR driver exposes trackers or controllers that are fed by an external
  process over sockets or named pipes using a clear command grammar for
  creation, pose updates, input, and fallback states.
- Good for:
  remote control, simulator ingress, custom hardware bridges, automation, and
  experiments where a non-driver process owns the real data source.
- Why it matters:
  it turns `external program controls SteamVR devices` into a reusable and
  debuggable contract.
- Strong references:
  `Yet-Another-OpenVR-IPC-Driver`.
- Best fit for `VR-apps-lab`:
  remote-ingress drivers and external-process synthetic-device platforms.

## Method 177: Declarative hand-gesture mapping into SteamVR controller semantics through per-action config

- What it is:
  hand-tracking gestures are translated into controller-style trigger, grip,
  button, and joystick semantics mostly through explicit config rather than
  hard-coded action logic.
- Good for:
  hand-emulation bridges, accessibility remappers, experimental controllerless
  flows, and user-tunable gesture systems.
- Why it matters:
  it keeps `gesture meaning` editable and avoids burying every behavior inside
  driver code.
- Strong references:
  `Quest-Link-Hand-Tracking`.
- Best fit for `VR-apps-lab`:
  configurable hand-to-controller bridges and input-remapping prototypes.

## Method 178: Tutorial-grade OpenVR driver shell with central provider, reusable device classes, and debugger-friendly workflow

- What it is:
  a small but complete driver tutorial keeps provider setup, device classes,
  registration, and update flow obvious enough to serve as a learning baseline.
- Good for:
  onboarding, new driver experiments, custom-device bring-up, and future
  synthetic-device research that should start from an honest baseline.
- Why it matters:
  it lowers the cost of entering OpenVR driver work without hiding the real
  structure under excessive framework code.
- Strong references:
  `Simple-OpenVR-Driver-Tutorial`.
- Best fit for `VR-apps-lab`:
  driver learning paths and low-level SteamVR experimentation notes.

## Method 179: Narrow input-emulation driver that exposes controller scalar components for external locomotion hardware

- What it is:
  a tiny driver surface focuses on only the controller components needed for an
  external hardware scenario, such as scalar axes or a small set of buttons.
- Good for:
  locomotion hardware, purpose-built accessories, low-complexity control
  bridges, and minimal driver proofs.
- Why it matters:
  it shows that not every donor-worthy driver needs full controller parity.
- Strong references:
  `openvr-driver-example`.
- Best fit for `VR-apps-lab`:
  small custom-hardware drivers and minimalist input-emulation experiments.

## Method 180: DIY HMD or tracker driver fed by serial, file, or lightweight remote channels with configurable display and pose sources

- What it is:
  an OpenVR device is driven by serial IMU data, text files, or other
  lightweight remote channels while display assumptions and pose sources remain
  configurable.
- Good for:
  hobby hardware, quick hardware bridges, prototype remote feeds, and low-cost
  synthetic device experiments.
- Why it matters:
  it reveals the simplest viable ingress contracts for custom HMD or tracker
  work without requiring a heavyweight protocol stack.
- Strong references:
  `OpenVR-ArduinoHMD`, `RemoteVVR`.
- Best fit for `VR-apps-lab`:
  DIY device plumbing and remote-input research baselines.

## Method 181: Tracking-override generic tracker used to replace head pose or test third-party tracking systems

- What it is:
  a generic tracker driver is structured so it can substitute for head pose or
  act as an override harness when validating external tracking pipelines.
- Good for:
  calibration experiments, head-pose replacement, third-party tracker
  validation, and tracking-system comparison work.
- Why it matters:
  it turns `generic tracker driver` into a reusable testing surface rather than
  only another synthetic device example.
- Strong references:
  `OpenVR-Tracker-Driver-Example`.
- Best fit for `VR-apps-lab`:
  tracking-override harnesses and external tracking validation tools.

## Method 182: Overlay-focused OpenVR wrapper with context-owned managers and feature-gated subsystem access

- What it is:
  a binding or wrapper layer initializes OpenVR in overlay mode and exposes
  only the subsystem managers the client actually needs through a typed
  context.
- Good for:
  reusable overlay backplanes, Rust or managed helper libraries, and projects
  that want to stay narrow instead of wrapping the entire runtime equally.
- Why it matters:
  it keeps overlay ownership explicit while avoiding a monolithic binding
  surface.
- Strong references:
  `ovr_overlay`.
- Best fit for `VR-apps-lab`:
  reusable overlay helper libraries and focused implementation backends.

## Method 183: Minimal dashboard overlay starter that keeps manifest, image surfaces, and visibility loop explicit

- What it is:
  a tiny overlay app creates a dashboard overlay, sets images or textures,
  polls visibility, and keeps almost the entire runtime lifecycle visible in
  one place.
- Good for:
  lower-bound overlay learning, quick proofs, bootstrap templates, and sanity
  checks around overlay lifecycle.
- Why it matters:
  it gives the smallest honest dashboard overlay baseline without hiding the
  important calls under extra abstraction.
- Strong references:
  `OpenVROverlayTest`, `UniversalVROverlay`.
- Best fit for `VR-apps-lab`:
  small dashboard starters and lower-bound overlay examples.

## Method 184: Shared overlay backend plus desktop-window control shell

- What it is:
  a desktop shell owns settings, navigation, and operator UX while a shared
  backend owns SteamVR checks, overlay registration, render loop, and event
  polling.
- Good for:
  configurable overlay apps, operator dashboards, and tools that need richer
  settings than a pure in-headset shell should own.
- Why it matters:
  it keeps desktop UX and overlay runtime internals separate without losing
  coordination between them.
- Strong references:
  `OpenVR.ALBRT.overlay`.
- Best fit for `VR-apps-lab`:
  desktop-plus-overlay utilities with richer configuration flow.

## Method 185: Overlay host extension through explicit IPC protocol, dedicated dashboard client, and embeddable compositor core

- What it is:
  a VR host ecosystem is split between compositor-capable core, standalone
  protocol crate, and external dashboard client that talks over local IPC.
- Good for:
  Linux desktop-in-VR hosts, multi-process overlay platforms, dashboard
  clients, and protocolized plugin ecosystems.
- Why it matters:
  it lets the host grow through stable extension boundaries instead of one
  monolithic application.
- Strong references:
  `wayvr`, `wayvr-dashboard`, `wayvr-ipc`.
- Best fit for `VR-apps-lab`:
  Linux overlay hosts and protocolized runtime-side utility ecosystems.

## Method 186: Panel-XML and script-driven live content module inside a larger VR host

- What it is:
  a host exposes panel schema and script hooks so a small extension can fetch
  external content, mutate panel state, and add live surfaces without changing
  the host core.
- Good for:
  plugin-fed panels, shared content surfaces, low-ceremony extensions, and
  host ecosystems that should stay mod-friendly.
- Why it matters:
  it proves that meaningful overlay extensions can live in declarative panel
  files and small shell helpers rather than compiled host code.
- Strong references:
  `WayvrWalltaker`.
- Best fit for `VR-apps-lab`:
  scriptable panel modules and lightweight host-extension patterns.

## Method 187: Capture-to-tape and replay-driver workflow with helper utilities and automation flags

- What it is:
  runtime state is captured into structured artifacts, then replayed through
  synthetic devices, with helper tools and simple file-based automation flags
  around the pipeline.
- Good for:
  regression harnesses, reproducible VR testing, record-and-replay workflows,
  and validation scenarios around motion or input data.
- Why it matters:
  it turns transient VR runtime behavior into reusable artifacts for later
  debugging and automation.
- Strong references:
  `vr-capture-replay`.
- Best fit for `VR-apps-lab`:
  record-replay harnesses and regression-friendly capture tooling.

## Method 188: XR orchestration workspace that couples synchronized capture, inference loops, and operator controls

- What it is:
  a host captures synchronized runtime state, routes it through inference or
  automation loops, and exposes control surfaces that feed actions or device
  commands back into VR.
- Good for:
  agent testing, automation, closed-loop research, and creator or operator
  workspaces that combine capture with control.
- Why it matters:
  it shows that capture becomes much more powerful when it participates in an
  explicit control loop instead of only producing offline logs.
- Strong references:
  `VRScout_Agent_Orchestration_Unity_Project`, `ViRe`.
- Best fit for `VR-apps-lab`:
  orchestration sidecars, agent-workspace tooling, and in-VR recording shells.

## Method 189: Per-application OpenXR layer that bootstraps local config from a global template and exposes operator micro-controls

- What it is:
  a layer resolves application identity, creates per-app config and log files
  from shared defaults, and applies runtime overrides or hotkeys inside the
  layer hook path.
- Good for:
  recenter overrides, crop or FOV utilities, app-specific runtime patches, and
  small operator-facing OpenXR tools.
- Why it matters:
  it turns API layers into usable micro-utilities instead of one-off hacks with
  one global toggle.
- Strong references:
  `OpenXR-RecenterOverride`, `OpenXR-Layer-crop-fov`.
- Best fit for `VR-apps-lab`:
  per-app OpenXR utility layers and runtime micro-tools.

## Method 190: Frame-lifecycle OpenXR layer that plugs external tools or transports into swapchain and session hooks

- What it is:
  an API layer intercepts session, swapchain, or frame lifecycle calls so it
  can trigger developer tools, stream output outward, or run staged
  intervention logic.
- Good for:
  RenderDoc-style capture layers, stream-out utilities, transport bridges, and
  heavier frame-processing experiments.
- Why it matters:
  it shows that OpenXR layers can act as tool or transport adapters, not only
  compatibility patches.
- Strong references:
  `openxr-renderdoc-layer`, `openxr_streamout_layer`,
  `Smoothing-OpenXR-Layer`.
- Best fit for `VR-apps-lab`:
  developer-tool bridges, output-stream layers, and advanced intervention
  research.

## Method 191: Implicit OpenXR capability-injection layer that surfaces external hardware support through extension emulation or override

- What it is:
  an API layer advertises or overrides runtime extension support so external
  hardware can appear as a native OpenXR capability without application changes.
- Good for:
  hand-tracking bridges, peripheral support injection, vendor or third-party
  sensor support, and compatibility surfaces for runtimes that lack a feature.
- Why it matters:
  it turns `new capability` into a runtime-layer problem instead of an
  engine-by-engine integration problem.
- Strong references:
  `OpenXRHandTracking`.
- Best fit for `VR-apps-lab`:
  capability-injection layers and external-sensor OpenXR experiments.

## Method 192: OpenXR input-remapping layer with external input-runtime ownership and per-handle wrapper registries

- What it is:
  an API layer intercepts input or action flow, owns an external input runtime,
  and tracks per-handle state through wrappers or registries.
- Good for:
  controller remapping, accessibility input layers, alternative input stacks,
  and external runtime bridges into OpenXR semantics.
- Why it matters:
  it makes input remapping a runtime-layer concern rather than an engine plugin
  or app-specific patch.
- Strong references:
  `openxr_remapping_layer`.
- Best fit for `VR-apps-lab`:
  runtime-side input bridges and remapping experiments.

## Method 193: Minimal Rust OpenXR API-layer skeleton with explicit loader negotiation and forwarding hooks

- What it is:
  a tiny layer starter exports the mandatory negotiation and forwarding entry
  points without hiding them behind a larger framework.
- Good for:
  bring-up experiments, new API-layer prototypes, haptics or extension stubs,
  and learning the real OpenXR loader contract.
- Why it matters:
  it gives a lower-bound starter for capability layers without abstraction fog.
- Strong references:
  `OpenXR_ApiLayer_Patstrap`.
- Best fit for `VR-apps-lab`:
  small Rust API-layer experiments and learning baselines.

## Method 194: Macro-generated OpenXR API-layer framework with typed per-handle data registries

- What it is:
  a framework generates the dangerous loader plumbing while layer authors attach
  typed data to raw XR handles and write normal Rust override functions.
- Good for:
  faster layer authoring, cleaner per-handle state management, safer Rust
  experimentation, and reusable layer toolkits.
- Why it matters:
  it lowers the cost of building nontrivial OpenXR layers without forcing each
  project to hand-roll the same negotiation code.
- Strong references:
  `quark`.
- Best fit for `VR-apps-lab`:
  Rust OpenXR layer authoring and reusable helper frameworks.

## Method 195: Tiny graphics-facing OpenXR facade that collapses session, frame, and swapchain boilerplate

- What it is:
  a narrow wrapper owns OpenXR instance, session, spaces, swapchains, and frame
  lifecycle so the caller can stay mostly inside a rendering-centric API.
- Good for:
  graphics-engine bring-up, small demos, renderer integrations, and learning
  the minimum reusable wrapper boundary.
- Why it matters:
  it shows how far OpenXR boilerplate can be compressed before a wrapper starts
  becoming a full engine framework.
- Strong references:
  `rayxr`.
- Best fit for `VR-apps-lab`:
  small renderer helpers and graphics-facing XR baselines.

## Method 196: Registry-backed OpenXR layer inspection and reordering micro-tool

- What it is:
  a tiny operator tool lists installed layers, inspects registry state, and
  enables, disables, or reorders layers directly.
- Good for:
  workflow hygiene, debugging broken layer stacks, lightweight repair actions,
  and operator-facing diagnostics.
- Why it matters:
  it treats loader state as a first-class operational surface rather than only
  something a full GUI should own.
- Strong references:
  `openxr-layer-scripts`.
- Best fit for `VR-apps-lab`:
  OpenXR doctor micro-tools and layer-state hygiene utilities.

## Method 197: Configurable runtime post-process OpenXR layer with live reload and staged image effects

- What it is:
  an API layer applies image-processing or post-process steps at frame end while
  resolving config from multiple locations and reloading settings live.
- Good for:
  sharpening layers, runtime visual adjustments, operator-facing graphics
  patches, and narrow image-processing utilities.
- Why it matters:
  it turns frame-end intervention into a productizable utility pattern rather
  than a one-off shader experiment.
- Strong references:
  `OpenXR-CAS`.
- Best fit for `VR-apps-lab`:
  runtime adaptation layers and operator-facing graphics micro-tools.

## Method 198: Engine-native OpenXR extension plugin that injects optional passthrough or composition-layer support without full vendor SDK lock-in

- What it is:
  an engine plugin hooks into engine lifecycle points, requests optional OpenXR
  extensions, and inserts extra composition behavior without adopting a whole
  vendor stack.
- Good for:
  vendor-specific feature bridges, one-feature engine plugins, portability-first
  XR projects, and minimal feature extraction from larger SDKs.
- Why it matters:
  it shows how to add one OpenXR capability cleanly while keeping the rest of
  the project on a smaller, more portable stack.
- Strong references:
  `ue-openxr-passthrough`.
- Best fit for `VR-apps-lab`:
  engine-side feature plugins and extension-integration references.

## Method 199: Minimal engine passthrough sample that couples transparent scene configuration with runtime extension calls

- What it is:
  a thin engine sample toggles passthrough through the engine's XR interface and
  makes transparent background or scene setup an explicit part of the feature.
- Good for:
  lower-bound mixed-reality samples, engine bring-up, troubleshooting
  passthrough support, and educational references.
- Why it matters:
  it keeps the real dependency between scene transparency and passthrough
  visibility obvious instead of burying it in a giant sample.
- Strong references:
  `godot_test_passthrough`, `mr-openxr-unity-meta-passthrough-sample`.
- Best fit for `VR-apps-lab`:
  engine-level passthrough samples and setup references.

## Method 200: External-texture desktop capture bridge that feeds a managed OpenVR overlay surface

- What it is:
  a native desktop-capture path writes into a texture that a managed overlay
  shell reuses directly as an overlay surface.
- Good for:
  desktop mirrors, native window capture bridges, Unity or managed overlay
  experiments, and texture-ownership studies.
- Why it matters:
  it makes the capture and overlay boundaries explicit instead of merging them
  into one opaque app layer.
- Strong references:
  `DesktopOverlayer`.
- Best fit for `VR-apps-lab`:
  desktop-surface overlays and native-to-managed texture bridge experiments.

## Method 201: CLI-first Linux overlay host that turns portal and PipeWire capture into controllable OpenVR window overlays

- What it is:
  a command-driven host acquires capture streams through Linux desktop portals
  and PipeWire, then exposes overlays, transforms, color keys, and saved state
  through textual commands and macro files.
- Good for:
  Linux overlay utilities, automation-friendly VR shells, capture-backed window
  surfaces, and host designs that should not depend on a GUI.
- Why it matters:
  it proves that a usable overlay host can be CLI-first and still own a rich
  scene and capture model.
- Strong references:
  `ovr-penguin`.
- Best fit for `VR-apps-lab`:
  command-first overlay hosts and Linux capture-backed utility shells.

## Recommended usage inside `VR-apps-lab`

When a new utility idea appears:

1. classify it first by `method`;
2. then map it to a `project family`;
3. then look up which repositories already demonstrate that method;
4. then decide whether `VR-apps-lab` should build it as:
   - overlay
   - desktop companion
   - service
   - API layer
   - driver
   - creator tool

## Method 202: Dashboard microphone-control overlay with OS endpoint state and controller-driven push-to-talk

- What it is:
  a focused dashboard surface exposes mute, recording level, or push-to-talk
  state directly over OS microphone endpoints.
- Good for:
  SteamVR dashboards, voice-state utilities, accessibility helpers, and quick
  audio control without alt-tabbing to desktop panels.
- Why it matters:
  it treats microphone state as a first-class VR utility concern rather than a
  background desktop-only setting.
- Strong references:
  `OpenVR-MicrophoneControl`.
- Best fit for `VR-apps-lab`:
  mic-state overlays and push-to-talk utility surfaces.

## Method 203: Local speech-to-text sidecar with overlay, OSC, browser, and websocket fan-out

- What it is:
  a local STT pipeline transcribes microphone input once and then fans the
  output into several sinks such as overlays, OSC, browser sources, or
  websocket consumers.
- Good for:
  chatbox helpers, avatar text tools, companion apps, assistive captions, and
  speech-driven utility surfaces.
- Why it matters:
  it shows how one audio-input pipeline can feed many VR and non-VR consumers
  cleanly.
- Strong references:
  `VRCTextboxSTT`.
- Best fit for `VR-apps-lab`:
  speech sidecars and multi-sink voice-input helpers.

## Method 204: Virtual speaker-plus-microphone routing substrate for VR voice and streaming workflows

- What it is:
  a virtual audio-device pair creates synthetic speaker and microphone endpoints
  that higher-level VR or streaming tools can route through.
- Good for:
  voice-routing utilities, streaming helpers, test harnesses, and headless or
  remote audio workflows.
- Why it matters:
  it captures the lower layer that many audio-control tools depend on but do
  not expose directly.
- Strong references:
  `Virtual-Audio-Driver`.
- Best fit for `VR-apps-lab`:
  audio routing helpers and routing-substrate studies.

## Method 205: Speaker-topology-first VR music player with local library ingestion and synchronized speaker catch-up

- What it is:
  a VR music player treats speakers as editable world objects, loads local audio
  files into a queue, and keeps newly added speakers synchronized with current
  playback.
- Good for:
  listening-room experiments, spatial music tools, speaker playgrounds, and
  local-library VR players.
- Why it matters:
  it makes the sound-stage layout itself part of the product rather than just
  the invisible backend.
- Strong references:
  `around-sound`.
- Best fit for `VR-apps-lab`:
  immersive music-player concepts and spatial listening tools.

## Method 206: Desktop immersive media shell with pluggable headset backends and mirrored operator UI

- What it is:
  a desktop media shell owns file or URL ingestion, buffering, and ordinary UI
  controls while delegating actual VR playback to replaceable headset backends.
- Good for:
  360 players, immersive media shells, desktop-plus-headset workflows, and
  multi-backend playback tools.
- Why it matters:
  it proves immersive media software can keep a strong desktop operator story
  while still supporting multiple VR runtimes or devices.
- Strong references:
  `360PlayerWindows`.
- Best fit for `VR-apps-lab`:
  headset-aware media shells and playback-controller references.

## Method 207: Browser-native immersive video shell with projection-manager and device-abstraction layers

- What it is:
  a WebXR or browser player separates public playback controls from projection
  handling and device-specific rendering behavior.
- Good for:
  browser-based immersive video players, device-targeted playback tools, and
  thin in-headset media shells.
- Why it matters:
  it keeps projection logic explicit instead of burying it inside a monolithic
  player blob.
- Strong references:
  `WebXR-video-player`.
- Best fit for `VR-apps-lab`:
  browser-backed media surfaces and projection-aware playback tools.

## Method 208: Engine-integrated media substrate for broad-codec, stream-aware, and immersive playback scenarios

- What it is:
  an engine media package wraps a powerful codec or streaming backend and then
  exposes several player shapes such as minimal playback, 360 playback,
  subtitles, and streamed content.
- Good for:
  engine-side media tools, creator plugins, immersive video surfaces, and
  stream-capable playback foundations.
- Why it matters:
  it turns media playback into a reusable backend layer instead of one bespoke
  player scene.
- Strong references:
  `vlc-unity`.
- Best fit for `VR-apps-lab`:
  engine-side playback substrates and media backend comparisons.

## Method 209: Cross-platform engine spatializer package with native DSP boundary and sample integration

- What it is:
  an engine package ships native DSP code, build or packaging flow, and sample
  integration together as one spatializer product.
- Good for:
  Unity spatializers, engine audio plugins, cross-platform DSP studies, and
  mixed reality audio integration.
- Why it matters:
  it makes the plugin boundary and engine-facing contract explicit instead of
  leaving them inside private tooling.
- Strong references:
  `spatialaudio-unity`.
- Best fit for `VR-apps-lab`:
  engine audio integration and native DSP packaging references.

## Method 210: Unified spatial audio renderer abstraction spanning HOA, object, speaker, and binaural models

- What it is:
  one top-level renderer abstraction routes several spatial-audio models behind
  a shared interface rather than fragmenting them into isolated pipelines.
- Good for:
  immersive audio frameworks, reusable rendering libraries, and architecture
  studies that span many output models.
- Why it matters:
  it shows how to keep audio rendering extensible across standards and output
  forms without losing coherence.
- Strong references:
  `libspatialaudio`.
- Best fit for `VR-apps-lab`:
  spatial-audio architecture references and deeper audio-substrate studies.

## Method 211: Web ambisonic renderer with explicit rotation routing and rendering-mode control

- What it is:
  a browser ambisonic renderer exposes routing, rotation, and rendering mode as
  explicit public controls over a clear audio graph.
- Good for:
  WebXR audio work, browser ambisonics, spatial-media tools, and lightweight
  binaural renderers.
- Why it matters:
  it keeps soundfield control and decode mode visible instead of hiding them in
  opaque helpers.
- Strong references:
  `omnitone`.
- Best fit for `VR-apps-lab`:
  browser-side spatial audio and web playback experiments.

## Method 212: Spatial audio object-clustering processor for output-budget reduction without collapsing spatial intent

- What it is:
  an object processor clusters nearby sound objects, reuses output objects, and
  mixes them into centroid-driven spatial outputs.
- Good for:
  dense combat scenes, particle-heavy sound design, and object-budget-aware
  immersive audio systems.
- Why it matters:
  it shows how to productize `object budget management` as a reusable audio
  utility pattern.
- Strong references:
  `spatial-audio-clustering`.
- Best fit for `VR-apps-lab`:
  audio-performance tooling and object-budget optimization studies.

## Method 213: GPU-broadcast audio-reactive texture bus for creator ecosystems

- What it is:
  audio analysis is converted into a shared texture or similar GPU-facing
  surface that shaders and scripts can both consume.
- Good for:
  creator tools, avatar or world reactivity, stage visuals, and reusable
  sound-reactive systems.
- Why it matters:
  it turns audio-reactive behavior into shared infrastructure rather than
  isolated prefab scripts.
- Strong references:
  `audiolink`.
- Best fit for `VR-apps-lab`:
  creator-side audio-reactive utilities and shader-driven systems.

## Method 214: Network-synced media player core with backend proxy split between player logic and concrete video components

- What it is:
  one synced player behaviour owns state, permissions, playlists, and timing
  while a proxy layer hides the concrete media backend or player implementation.
- Good for:
  networked creator tools, synced media surfaces, multi-backend player shells,
  and VR social-space playback systems.
- Why it matters:
  it makes backend swapping possible without contaminating the whole player
  logic.
- Strong references:
  `USharpVideo`, `VVMW`.
- Best fit for `VR-apps-lab`:
  synced media-player cores and backend abstraction studies.

## Method 215: Owner-routed queue companion with per-user limits, URL policy, and playback handoff around an existing player

- What it is:
  a queue layer sits beside a media player and handles request ownership,
  policy, moderation, and playback handoff without owning the whole playback
  engine itself.
- Good for:
  creator moderation, shared media queues, multi-user playback systems, and
  queue-aware control panels.
- Why it matters:
  it captures the often-missing `queue and permissions shell` around synced
  playback.
- Strong references:
  `USharpVideoQueue`.
- Best fit for `VR-apps-lab`:
  queue companions and multi-user media workflow tools.

## Method 216: Priority-based world voice-state manager with zone membership and fake occlusion

- What it is:
  player voice settings are modeled as composable state, with zones, priority,
  and transition logic deciding which values apply.
- Good for:
  social spaces, staged events, fake occlusion, room-aware voice behavior, and
  voice moderation utilities inside creator ecosystems.
- Why it matters:
  it turns voice behavior into a reusable world system instead of a one-off
  trigger script.
- Strong references:
  `AudioManager`.
- Best fit for `VR-apps-lab`:
  world voice-state tools and social-space audio-control utilities.

## Method 217: Browser panoramic player core with explicit split across media source, stereoscopy, projection, and renderer mode

- What it is:
  a browser playback framework keeps media loading, stereoscopy detection,
  projection family, renderer mode, and player shell as separate public
  concepts instead of one monolithic viewer.
- Good for:
  browser immersive playback, 360 and stereo media players, WebXR video tools,
  and projection-aware media shells.
- Why it matters:
  it keeps the playback taxonomy visible and reusable instead of hiding it in
  one app-specific render path.
- Strong references:
  `360WebPlayer`.
- Best fit for `VR-apps-lab`:
  browser-backed immersive playback donors and projection-aware media tools.

## Method 218: Existing HTML5 player plugin that swaps rendering or canvas strategy based on projection and media layout

- What it is:
  an ordinary web video player is upgraded through a plugin that changes the
  rendering backend according to projection type, media layout, or panoramic
  mode.
- Good for:
  plugin-based immersive playback, upgrading existing media stacks, panoramic
  video players, and incremental web-player enhancement.
- Why it matters:
  it shows how to add VR-aware playback without discarding the broader player
  ecosystem.
- Strong references:
  `videojs-panorama`.
- Best fit for `VR-apps-lab`:
  projection-aware upgrades over existing player shells.

## Method 219: Projection-aware Video.js VR plugin over an ordinary player shell

- What it is:
  a `Video.js` plugin models several immersive layouts explicitly and plugs VR
  playback into an existing player lifecycle instead of replacing the whole
  stack.
- Good for:
  180 and 360 media, cubemap playback, equi-angular content, and web-player
  layout taxonomy.
- Why it matters:
  it turns projection choice into a clean public contract instead of a hidden
  implementation detail.
- Strong references:
  `videojs-vr`.
- Best fit for `VR-apps-lab`:
  player-plugin references and layout-taxonomy donors.

## Method 220: Cross-platform mobile VR-player wrapper built as platform view plus native playback bridge

- What it is:
  a mobile wrapper keeps a small cross-platform API while delegating actual 360
  playback to native platform views and SDK integrations.
- Good for:
  mobile immersive media shells, Flutter wrappers, thin product surfaces, and
  cross-platform XR media tools.
- Why it matters:
  it makes the platform-view and bridge boundary explicit instead of pretending
  immersive playback is purely cross-platform UI.
- Strong references:
  `VR-Player`.
- Best fit for `VR-apps-lab`:
  mobile wrapper references and native-bridge comparison nodes.

## Method 221: Unity panoramic sphere component with image-video parity and shader-backed projection modes

- What it is:
  one Unity component owns both image and video playback across several
  panoramic layouts through a reusable sphere plus shader pipeline.
- Good for:
  Unity panoramic viewers, immersive media surfaces, projection-mode
  components, and compact stereo or 360 playback baselines.
- Why it matters:
  it keeps the viewing surface reusable even when content type changes from
  still image to video.
- Strong references:
  `Unity_Panorama180View`.
- Best fit for `VR-apps-lab`:
  engine-side panoramic surface donors and shader-backed playback references.

## Method 222: Vendor sample matrix for layout-specific immersive video surfaces

- What it is:
  a vendor sample pack expresses several video layouts through dedicated scenes,
  materials, and geometry combinations instead of one abstracted player core.
- Good for:
  headset-vendor playback references, layout validation, immersive media
  samples, and engine integration checklists.
- Why it matters:
  it shows that some of the clearest reusable value comes from explicit layout
  matrices rather than from a generalized framework.
- Strong references:
  `VideoPlayer-UnityXR`.
- Best fit for `VR-apps-lab`:
  vendor layout references and playback-surface comparison work.

## Method 223: High-level panoramic authoring shell paired with a lower-level programmable viewing actor

- What it is:
  one layer handles cinematic or tour authoring while a lower-level actor or
  sphere remains available for direct programmer control.
- Good for:
  panoramic tour tooling, engine-side authoring workflows, immersive player
  plugins, and Unreal or Unity media systems.
- Why it matters:
  it exposes a cleaner split between quick content assembly and lower-level
  playback control.
- Strong references:
  `ue5-stereo-panoramic-player-demo`.
- Best fit for `VR-apps-lab`:
  authoring-surface references and higher-vs-lower-level playback design.

## Method 224: Prefab-level creator-side video system split into video manager, audio manager, and screen manager

- What it is:
  a creator-facing playback package models video, audio, and display surfaces
  as separate manager domains under one player shell.
- Good for:
  VRChat media systems, creator tools, synced playback shells, and
  multi-surface video experiences.
- Why it matters:
  it keeps the player from collapsing into one script and makes screen or audio
  integration reusable on its own.
- Strong references:
  `VideoTXL`.
- Best fit for `VR-apps-lab`:
  creator-side media systems and manager-split playback donors.

## Method 225: Owner-synced Udon video player with backend switching, late-join sync, and re-sync heuristics

- What it is:
  one Udon player core owns playback state, network time, backend choice, and
  recovery logic for late joiners or drift.
- Good for:
  synchronized social playback, shared media screens, lean creator tools, and
  Udon-based event spaces.
- Why it matters:
  it provides a compact lower bound for `synced video shell` without needing a
  much larger package ecosystem.
- Strong references:
  `UdonVideoplayer`.
- Best fit for `VR-apps-lab`:
  sync-core references and compact creator-side media shells.

## Method 226: Modular creator-facing media frontend with playlist, queue, history, and handler extension surfaces

- What it is:
  a creator-facing player breaks controller logic into partials and exposes
  handler, playlist, queue, history, and module surfaces as first-class public
  structure.
- Good for:
  event or venue media systems, creator-side playback shells, extension-heavy
  media packages, and workflow-rich social spaces.
- Why it matters:
  it shows how a media frontend can keep growing features without collapsing
  into one monolithic player script.
- Strong references:
  `YamaPlayer`.
- Best fit for `VR-apps-lab`:
  modular creator-side video systems and event-oriented playback frontends.

## Method 227: Projection-transform media viewer shell over ordinary playback engines with head-motion logging

- What it is:
  an ordinary media engine is wrapped in a shell that transforms projection or
  framing behavior and can log viewer head motion as part of playback.
- Good for:
  nonstandard 3D viewers, transformed stereo playback, media reprojection, and
  experimental framing workflows.
- Why it matters:
  it shows how `player plus transform logic` can become its own product shape
  without a full engine rewrite.
- Strong references:
  `VR-reversal`.
- Best fit for `VR-apps-lab`:
  transform-driven viewer shells and unconventional media tooling.

## Method 228: Volumetric and VR180 playback substrate that spans WebXR and engine export targets

- What it is:
  a broad playback substrate supports volumetric or VR180 media across a web
  player plus export or integration paths for game engines.
- Good for:
  volumetric media research, VR180 playback, WebXR viewers, and multi-target
  immersive media stacks.
- Why it matters:
  it keeps the core media substrate reusable across more than one delivery
  environment.
- Strong references:
  `lifecast_public`.
- Best fit for `VR-apps-lab`:
  volumetric playback references and cross-target media substrate studies.

## Method 229: Monocular-depth-to-3D media viewer with pluggable inference backends and mesh controls

- What it is:
  image or video inputs are expanded into a navigable 3D surface through
  interchangeable inference paths plus viewer-side mesh and playback controls.
- Good for:
  depth-expanded media tools, experimental 3D viewers, inference-backed media
  shells, and nonstandard immersive playback.
- Why it matters:
  it turns `2D media to 3D surface` into a reusable viewer architecture rather
  than a one-off demo.
- Strong references:
  `DepthViewer`.
- Best fit for `VR-apps-lab`:
  nonstandard media viewers and depth-based playback experimentation.

## Method 230: Immersive dome-viewer environment with local media, NDI, and Spout ingest

- What it is:
  an immersive viewing environment treats local files and live media feeds as
  parallel inputs under one dome-style playback shell with XR menu anchoring.
- Good for:
  dome or projection environments, live media ingest tools, spatial viewing
  rooms, and creator-facing media shells.
- Why it matters:
  it captures a broader `media environment` product shape where ingest and
  spatial presentation matter as much as playback controls.
- Strong references:
  `DomeTools`.
- Best fit for `VR-apps-lab`:
  immersive media environments and source-ingest playback references.

## Method 231: VRChat world build-request gate with automated fix-or-block editor workflow

- What it is:
  a world-authoring toolkit intercepts the build pipeline, checks scene
  assumptions, and either blocks or helps fix the build before creators publish
  broken content.
- Good for:
  creator guardrails, publish-time validation, editor automation, and world
  authoring hygiene.
- Why it matters:
  it moves quality enforcement into tooling instead of leaving it as a wiki or
  checklist.
- Strong references:
  `VRWorldToolkit`.
- Best fit for `VR-apps-lab`:
  creator-world authoring tools and editor-time validation helpers.

## Method 232: Compiler-pipeline injection that optimizes generated Udon after UdonSharp emission

- What it is:
  a Harmony-style patch hooks the creator compiler pipeline and runs
  optimization passes over generated program output instead of over author code.
- Good for:
  generated-script optimization, post-emit cleanup, compiler extensions, and
  creator toolchains.
- Why it matters:
  it captures a reusable way to improve generated code centrally rather than
  expecting creators to optimize every script by hand.
- Strong references:
  `UdonSharpOptimizer`.
- Best fit for `VR-apps-lab`:
  compiler-adjacent tooling and generated-code optimization research.

## Method 233: Creator-tool package constellation with shared common package and composable prefab modules

- What it is:
  a creator ecosystem is broken into many smaller packages plus a shared common
  layer so projects can compose only the modules they need.
- Good for:
  creator ecosystems, VCC-friendly packaging, prefab suite decomposition, and
  reusable package families.
- Why it matters:
  it provides a stronger long-term packaging shape than one monolithic prefab
  dump.
- Strong references:
  `VUdon`.
- Best fit for `VR-apps-lab`:
  ecosystem design and creator-tool packaging strategy.

## Method 234: World voice-state controller with composable override lists, privacy channels, and occlusion models

- What it is:
  player voice and avatar-audio behavior are modeled through override objects,
  priority, privacy channels, and configuration models rather than through
  isolated triggers.
- Good for:
  social spaces, staged events, voice zoning, privacy channels, and
  creator-world audio behavior.
- Why it matters:
  it turns voice-state behavior into reusable runtime infrastructure.
- Strong references:
  `UdonVoiceUtils`.
- Best fit for `VR-apps-lab`:
  world voice-state systems and creator-world runtime infrastructure.

## Method 235: Reliable byte-buffer message bus over manual-sync Udon connections

- What it is:
  a creator-world transport layer builds reliable targeted messaging, sequence
  handling, and serialization helpers over manual-sync byte arrays.
- Good for:
  world runtime infrastructure, creator-side transport, binary messaging,
  targeted sync, and reusable Udon networking.
- Why it matters:
  it exposes a cleaner transport contract than one-off synced variables.
- Strong references:
  `UNet`.
- Best fit for `VR-apps-lab`:
  creator-world transport patterns and reusable runtime substrate.

## Method 236: Moving-platform hook that keeps local players aligned to moving colliders with menu-aware pause and velocity inheritance

- What it is:
  a narrow world helper detects valid moving colliders, offsets or teleports
  the local player to follow them, pauses on menu interaction, and can preserve
  velocity on unhook.
- Good for:
  moving platforms, vehicles, elevators, locomotion correction, and dynamic
  world geometry.
- Why it matters:
  it captures a stubborn runtime problem as a reusable prefab-scale solution.
- Strong references:
  `UdonPlayerPlatformHook`.
- Best fit for `VR-apps-lab`:
  narrow creator-world locomotion helpers and moving-frame utilities.

## Method 237: Per-player pooled object assignment with master verification and compiler-agnostic integration contract

- What it is:
  each player is assigned one pooled object through stable mapping logic,
  verification, and a small event contract that works across several Udon
  authoring styles.
- Good for:
  per-player anchors, scoreboards, player-owned world gadgets, deterministic
  player ordering, and creator-world infrastructure.
- Why it matters:
  it separates `player state anchor` from player identity and makes the pattern
  reusable across systems.
- Strong references:
  `CyanPlayerObjectPool`.
- Best fit for `VR-apps-lab`:
  per-player infrastructure and creator-world state helpers.

## Method 238: Prefab-first multicam creator rig with desktop output switching, autopilot, and optional fisheye branches

- What it is:
  a creator camera system keeps most of the authoring surface in prefabs while
  small controller scripts handle output toggling, camera order, and autopilot.
- Good for:
  world staging, event coverage, creator cinematography, and desktop capture
  rigs.
- Why it matters:
  it shows how far a prefab-first camera workflow can go before it needs a
  larger control console.
- Strong references:
  `VRChatCameraWorks`.
- Best fit for `VR-apps-lab`:
  creator camera rigs and staging-surface references.

## Method 239: Permission-gated world camera console with synchronized live feed, handheld camera control, and low-cost standby mode

- What it is:
  a world-side console owns live output switching, operator authorization,
  handheld camera control, and a reduced-cost inactive-camera mode.
- Good for:
  venue control, event moderation, streamed world coverage, and operator-facing
  staging systems.
- Why it matters:
  it captures a richer `camera operations console` shape than simple camera
  prefabs alone.
- Strong references:
  `CameraSystem`.
- Best fit for `VR-apps-lab`:
  creator control panels and event-camera systems.

## Method 240: Avatar-side camera-path authoring through an OSC companion

- What it is:
  an avatar encodes path and setting data through contacts, constraints, or
  other avatar mechanics while an external companion program reconstructs and
  plays the camera path.
- Good for:
  avatar-driven control systems, camera-path authoring, OSC-based creator
  workflows, and off-avatar companion tooling.
- Why it matters:
  it exposes a strong `in-avatar authoring plus external companion`
  architecture.
- Strong references:
  `Camera-System`.
- Best fit for `VR-apps-lab`:
  companion-bound creator tools and avatar-driven external control patterns.

## Method 241: Modular world admin menu with watch camera, permissions, teleports, HUD, and voice modules

- What it is:
  an admin surface is broken into cooperating modules so camera viewing,
  moderation, movement, messaging, and permissions stay composable instead of
  collapsing into one script.
- Good for:
  moderation tools, roleplay or event administration, world operator panels,
  and creator control systems.
- Why it matters:
  it demonstrates a scalable shape for broad world-operation tooling.
- Strong references:
  `GMMenu`.
- Best fit for `VR-apps-lab`:
  admin-control packages and modular creator-world operations tooling.

## Method 242: Configurable keypad prefab with remote allow-list loading and event relays

- What it is:
  a world keypad stays prefab-configurable while supporting allow and deny
  lists, additional solutions, remote string updates, and custom event relays.
- Good for:
  access control, gates, doors, privileged interactions, and creator-world
  utility prefabs.
- Why it matters:
  it shows how a small world utility can remain highly configurable without
  becoming a one-off script.
- Strong references:
  `U-Key`.
- Best fit for `VR-apps-lab`:
  interaction-prefab donors and small creator-world utilities.

## Method 243: Shared 3D marker tool that keeps local trail generation separate from compact manual-sync state updates

- What it is:
  a marker generates trails locally at one cadence while only syncing minimal
  state and recent points needed for remote reconstruction.
- Good for:
  whiteboards, annotations, spatial notes, collaborative drawing, and creator
  markers.
- Why it matters:
  it captures a strong lower-bound sync model for shared drawing tools.
- Strong references:
  `VRCMarker`.
- Best fit for `VR-apps-lab`:
  collaborative annotation and shared spatial-marking tools.

## Method 244: Avatar-thumbnail text or data carrier with editor encoder and runtime pedestal-image decoder

- What it is:
  a creator workflow encodes text or data into avatar imagery in the editor and
  decodes it at runtime through pedestal image inspection.
- Good for:
  dynamic world text, boards, membership data, constrained data transport, and
  historical platform-workaround studies.
- Why it matters:
  it captures an unusual but instructive `data carrier under platform
  constraints` pattern.
- Strong references:
  `AvatarImageReader`.
- Best fit for `VR-apps-lab`:
  dynamic information-surface research and constrained data-carrier patterns.

## Method 245: Pool-backed recycling scroll rect for Udon with datasource contract and delayed view initialization

- What it is:
  a creator-world list UI keeps only enough cells to cover the viewport and
  reuses them through a datasource contract, delayed initialization, and a UI
  cell pool.
- Good for:
  scoreboards, large lists, repeated UI cells, creator dashboards, and
  world-side menus.
- Why it matters:
  it turns scalable list UI into reusable world infrastructure instead of a
  one-off menu implementation.
- Strong references:
  `UdonRecyclingScrollRect`.
- Best fit for `VR-apps-lab`:
  creator-world UI infrastructure and list or board systems.

## Method 246: Avatar-parameter persistence through data avatars, parameter writers, and finger-bone readback

- What it is:
  a creator-world persistence system writes data into avatar parameters or
  staged data avatars, then reconstructs saved state through controlled avatar
  slot switching and bone-rotation readback.
- Good for:
  in-platform persistence under severe platform limits, portable save state,
  constrained data carriers, and creator-world save systems that cannot rely on
  external storage.
- Why it matters:
  it captures a clever `pure in-world persistence` pattern instead of assuming
  all meaningful save state must escape into a companion app.
- Strong references:
  `NUSaveState`.
- Best fit for `VR-apps-lab`:
  constrained persistence donors and creator-world state encoding research.

## Method 247: World save companion that parses logs and fans state into local history, notifications, OSC, WebSocket, and plugins

- What it is:
  a desktop sidecar watches VRChat logs, reconstructs world state, persists it
  locally, and republishes it through several outputs such as notifications,
  chatbox, OSC, WebSocket, webhook, or script plugins.
- Good for:
  world-specific companion apps, save managers, event relays, sidecar
  automation hosts, and log-driven recovery systems.
- Why it matters:
  it turns `log parsing` into a reusable sidecar substrate with multiple output
  surfaces rather than a one-off parser script.
- Strong references:
  `ToNSaveManager`.
- Best fit for `VR-apps-lab`:
  companion-app research, event fan-out architectures, and save-manager donors.

## Method 248: Auto-registered holster inventory with per-item owner arrays and hand-collider access control

- What it is:
  a creator-world inventory scans the scene for valid pickups and holsters,
  auto-builds ownership arrays, and lets local holsters enforce access and
  placement through hand-collider gating.
- Good for:
  pickup inventories, holster systems, shared equipment, roleplay worlds, and
  world-side ownership substrate.
- Why it matters:
  it shows how to keep `inventory setup` mostly declarative and editor-driven
  instead of manually wiring every pickup to custom scripts.
- Strong references:
  `InventorySystem`.
- Best fit for `VR-apps-lab`:
  creator-world inventory donors and reusable pickup-ownership infrastructure.

## Method 249: Terms-compliant external web and local-storage bridge using log commands plus virtual MIDI

- What it is:
  an external helper process listens to world-emitted log commands, executes
  HTTP, WebSocket, browser, or local-storage work outside the client, and sends
  results back into the world through a constrained MIDI channel.
- Good for:
  creator-world web access, local persistence, external sidecars, constrained
  request or response bridges, and platform-safe companion architecture.
- Why it matters:
  it captures a reusable way to extend world capabilities without client mods
  while staying honest about trust boundaries and protocol limits.
- Strong references:
  `Udon-MIDI-Web-Helper`.
- Best fit for `VR-apps-lab`:
  external sidecar design, creator-world bridge patterns, and constrained
  transport research.

## Method 250: Unity-editor Udon emulation with simulated players, event injection, and multi-client launch automation

- What it is:
  an editor toolkit simulates enough of the player and Udon lifecycle to let
  creators rehearse logic locally, trigger events manually, and speed up
  multi-client testing flows.
- Good for:
  world testing, creator iteration loops, local rehearsal, event debugging, and
  multiplayer QA acceleration.
- Why it matters:
  it shortens the gap between writing creator logic and checking whether it
  behaves sensibly, without requiring a full live VRChat launch for every edit.
- Strong references:
  `GotoUdon`.
- Best fit for `VR-apps-lab`:
  creator diagnostics, simulation tools, and editor-side testing donors.

## Method 251: Sortable Udon behaviour explorer with source drill-through and sync metadata inspection

- What it is:
  an editor window treats scene UdonBehaviours as a sortable searchable table,
  exposing sync mode, program assets, symbols, source links, and other metadata
  in one place.
- Good for:
  scene audits, creator diagnostics, metadata inspection, source navigation, and
  world review workflows.
- Why it matters:
  it turns Udon scene inspection into a first-class tool instead of forcing
  creators through slow per-object inspector traversal.
- Strong references:
  `UdonExplorer`.
- Best fit for `VR-apps-lab`:
  creator-world diagnostics and scene inventory tooling.

## Method 252: Compiler-pipeline instrumentation that emits Perfetto-compatible traces for UdonSharp

- What it is:
  a Harmony-patched compiler extension injects profiling keys or hooks into
  generated UdonSharp output and exports runtime trace data into a stronger
  external visualization tool such as Perfetto.
- Good for:
  generated-code profiling, trace capture, compile-time tooling, and creator
  performance diagnostics.
- Why it matters:
  it captures a powerful `instrument the compiler, not every script` strategy
  for profiling constrained creator environments.
- Strong references:
  `UdonSharpProfiler`.
- Best fit for `VR-apps-lab`:
  compiler-adjacent tooling and trace-based diagnostics research.

## Method 253: Roslyn analyzer suite for unsupported UdonSharp patterns and network-event contract validation

- What it is:
  a static-analysis layer encodes Udon or UdonSharp constraints as analyzer
  rules so unsupported language features and invalid visibility or networking
  patterns surface before compile or upload time.
- Good for:
  creator IDE guardrails, ecosystem-specific linting, code fixes, and
  compatibility validation.
- Why it matters:
  it moves platform knowledge into machine-checkable rules instead of leaving
  it as tribal knowledge or README warnings.
- Strong references:
  `UdonRabbit.Analyzer`.
- Best fit for `VR-apps-lab`:
  creator diagnostics and analyzer-authoring patterns.

## Method 254: Local-player bone-collider skeleton driving physics-first buttons and switches with fallback mode

- What it is:
  a creator interaction stack builds colliders from local-player avatar bones
  and uses them to drive buttons or switches, while still offering a fallback
  interaction path when hand bones are unavailable.
- Good for:
  embodied buttons, switches, levers, world control surfaces, and physics-first
  creator interaction.
- Why it matters:
  it creates a stronger embodied interaction baseline than generic `Interact`
  events by giving world mechanics a reusable hand or body representation.
- Strong references:
  `immersive-interactions`.
- Best fit for `VR-apps-lab`:
  creator-world interaction donors and physical control-surface research.

## Method 255: Sleep-aware manual-sync control surface with collider filtering, cooldowns, ownership transfer, and rich feedback layers

- What it is:
  a physical control surface stays cheap when idle, wakes on valid interaction,
  and layers collider filtering, ownership transfer, cooldowns, haptics, tint,
  textures, and optional manual sync over one reusable prefab pattern.
- Good for:
  world buttons, switches, levers, operator panels, and shared physical
  interaction surfaces.
- Why it matters:
  it captures how to make a `physical UI prefab` both rich and practical
  instead of either too thin or too expensive.
- Strong references:
  `immersive-interactions`.
- Best fit for `VR-apps-lab`:
  physical creator controls and embodied world-surface donors.

## Method 256: Grapple or tether controller with spherecast auto-aim, spring projection, and optional rigidbody manipulation

- What it is:
  a locomotion helper uses combined raycast or spherecast detection to acquire a
  tether target, then applies spring-style movement to the player or manipulates
  lighter rigidbodies through the same tether abstraction.
- Good for:
  grapple mechanics, swing locomotion, tether tools, traversal experiments, and
  physical object manipulation.
- Why it matters:
  it captures a compact but reusable `focused locomotion mechanic` pattern
  rather than requiring a whole movement framework.
- Strong references:
  `UdonTether`.
- Best fit for `VR-apps-lab`:
  locomotion experiments and embodied mechanic donors.

## Method 257: Extensible custom movement controller with VRChat-like inputs, platform inheritance, and ground or stance abstraction

- What it is:
  a movement package separates a broad abstract controller substrate from a
  concrete implementation so ground handling, gravity, stance, platforms, and
  VR versus desktop input mapping can evolve without rewriting the whole stack.
- Good for:
  custom locomotion, movement frameworks, world-specific traversal, platform
  inheritance, and embodied control systems.
- Why it matters:
  it shows how to keep `movement` extensible and debuggable instead of burying
  everything in one monolithic behaviour.
- Strong references:
  `NUMovement`.
- Best fit for `VR-apps-lab`:
  movement-framework references and creator-world locomotion systems.

## Method 258: Pickup-driven hinge door with signed-angle target, spring or drag motion, and synced sound cues

- What it is:
  a physical hinge object derives target rotation from pickup-handle position,
  keeps spring or drag motion in a compact controller, and syncs angle plus
  audio cues instead of full transform state.
- Good for:
  doors, lockers, hinged controls, physical handles, and narrow mechanical
  prefabs.
- Why it matters:
  it captures a very reusable lower-bound pattern for small physical mechanics
  that still feel embodied.
- Strong references:
  `UdonDoor`.
- Best fit for `VR-apps-lab`:
  compact mechanic donors and pickup-driven interaction research.

## Method 259: Motion-controller steering kart rig with seat, handle, throttle, and visual-state split

- What it is:
  a creator vehicle system decomposes steering, seating, throttle, and wheel or
  visual state into cooperating modules, with controller-hand geometry driving
  the steering surface in VR mode.
- Good for:
  vehicles, rideables, cockpit mechanics, racing worlds, and embodied control
  rigs.
- Why it matters:
  it shows a more scalable `vehicle shell` shape than one script that handles
  every seat, wheel, and state concern at once.
- Strong references:
  `KurotoriUdonKart`.
- Best fit for `VR-apps-lab`:
  vehicle mechanics and creator-world embodied-control donors.

## Method 260: Creator-world utility foundation with base lifecycle, singleton identity, execution-order validation, and shared common helpers

- What it is:
  a broad utility substrate standardizes base behaviour lifecycle, logging,
  dirty-state or sync handling, singleton lookup, execution-order policies, and
  common helper functions under one creator ecosystem.
- Good for:
  large creator packages, shared runtime substrate, package ecosystems, and
  reusable world foundations.
- Why it matters:
  it captures how a `creator framework` can stay coherent across many prefabs
  and helpers instead of repeating setup and lifecycle logic everywhere.
- Strong references:
  `UdonUtils`.
- Best fit for `VR-apps-lab`:
  creator-world foundations and reusable utility-layer architecture.

## Method 261: Data-container emulation via object-backed lists, paired arrays, JSON DOM, and array-extension helpers when native containers are insufficient

- What it is:
  a family of helpers emulates lists, dictionaries, queues, stacks, JSON DOM,
  and list-like array operations through object records, paired arrays, or
  extension methods when native container choices are missing or intentionally
  avoided.
- Good for:
  creator substrate, serialization, fallback collections, constrained scripting,
  and historical platform-workaround studies.
- Why it matters:
  it captures several honest strategies for `container ergonomics under
  platform constraints`, from archived object-backed substrates to modern
  array-first helper layers.
- Strong references:
  `udon-list`, `udon-dictionary`, `udon-json`, `UArrayCollections`,
  `VUdon-ArrayExtensions`.
- Best fit for `VR-apps-lab`:
  creator-world data-structure research and utility-substrate comparisons.

## Method 262: Self-restoring creator bootstrap on editor open through remote config and unitypackage import

- What it is:
  an editor bootstrap checks whether a required package resolver is present,
  fetches the current bootstrap URL from remote config, downloads the package
  into temp storage, and imports it automatically.
- Good for:
  official templates, self-healing starter projects, editor bring-up flows, and
  package bootstrap recovery.
- Why it matters:
  it captures a strong `healthy project on first open`
  pattern instead of assuming every contributor already has the right resolver
  or package substrate.
- Strong references:
  `template-world`, `template-udonsharp`.
- Best fit for `VR-apps-lab`:
  creator bootstrap lineage and setup-pattern research.

## Method 263: In-world assertion library with recursive equality over arrays and Udon data containers

- What it is:
  a small creator-world testing layer exposes basic assertions and compares
  nested arrays, `DataToken`, `DataList`, and `DataDictionary`
  values recursively.
- Good for:
  creator-world test helpers, validation harnesses, local logic checks, and
  data-structure verification.
- Why it matters:
  it shows how much testing leverage creators can get without a heavy runtime
  or editor framework.
- Strong references:
  `udon-test`.
- Best fit for `VR-apps-lab`:
  creator diagnostics and world-side test-harness research.

## Method 264: Language-boundary code generation from Wasm into an explicit UdonSharp runtime substrate

- What it is:
  a translator validates WebAssembly input, lowers it into a custom
  intermediate representation, and emits UdonSharp classes that expose memory,
  globals, imports, and exports explicitly.
- Good for:
  alternative-language experiments, code generation, constrained-runtime
  compilation targets, and explicit runtime substrate design.
- Why it matters:
  it shows that `UdonSharp`
  can be treated as a target language for generated code rather than only as
  the author-facing source language.
- Strong references:
  `wasm2usharp`.
- Best fit for `VR-apps-lab`:
  creator-world codegen research and alternative-language architecture studies.

## Method 265: Manual encoding fallback layer for constrained Udon runtimes

- What it is:
  a helper library implements UTF encoding and decoding manually, including
  surrogate-pair handling and `TryGet*`
  surfaces suited to constrained runtimes.
- Good for:
  text protocols, older creator-runtime support, fallback parsing, and narrow
  string-processing helpers.
- Why it matters:
  it captures an honest strategy for text handling when newer native platform
  APIs are missing or insufficient.
- Strong references:
  `udon-encoding`.
- Best fit for `VR-apps-lab`:
  constrained-runtime protocol research and historical creator-workaround
  studies.

## Method 266: Frame-sliced JWT verifier with predecoded key material and progress callbacks

- What it is:
  a token verifier decodes PEM-backed RSA public keys into serialized arrays,
  validates `RS256`
  signatures, and advances heavy modular arithmetic across delayed frames while
  reporting progress.
- Good for:
  cryptographic verification under frame budgets, token helpers, constrained
  runtime security research, and progress-aware long tasks.
- Why it matters:
  it shows how to keep mathematically heavy work inside a world-friendly
  runtime model without blocking everything else.
- Strong references:
  `udon-jwt`.
- Best fit for `VR-apps-lab`:
  creator-world protocol helpers and frame-sliced computation patterns.

## Method 267: Source-generator plus Harmony compile-hook DSL that lowers into plain loops for UdonSharp

- What it is:
  an author-friendly query surface uses source generators and a compiler hook
  so the source a creator writes is more expressive than the low-level loop code
  the compiler ultimately sees.
- Good for:
  creator tooling, DSL design, compile-pipeline intervention, author ergonomics,
  and generated loop helpers.
- Why it matters:
  it captures a strong `ergonomic source, plain emitted code`
  strategy for constrained scripting environments.
- Strong references:
  `ULinq`.
- Best fit for `VR-apps-lab`:
  creator-tooling research and compile-hook donor patterns.

## Method 268: Structured-data parser over DataDictionary or DataList with async callback parsing and path queries

- What it is:
  a parser turns structured text into `DataDictionary` or `DataList`
  objects, exposes path queries over the result, and offers callback-driven
  asynchronous parsing when frame cost matters.
- Good for:
  creator-world data ingestion, document parsing, config helpers, structured
  payload processing, and async runtime utilities.
- Why it matters:
  it shows how to build a usable structured-data surface on top of the
  platform's native data containers instead of inventing a whole new model.
- Strong references:
  `UdonXMLParser`.
- Best fit for `VR-apps-lab`:
  creator-world parsing research and native-container data tooling.

## Method 269: Build-time event resolver with serialized DataList call graph and singleton runtime dispatcher

- What it is:
  an editor or build pipeline resolves Udon event addresses ahead of time,
  serializes persistent event calls into `DataList`, and dispatches them
  through one singleton runtime handler.
- Good for:
  UnityEvent-like authoring, creator callback routing, prefab-level events, and
  serialized call-graph tooling.
- Why it matters:
  it turns event wiring into a first-class creator surface instead of leaving it
  as ad hoc `SendCustomEvent`
  strings everywhere.
- Strong references:
  `VUdon-Events`.
- Best fit for `VR-apps-lab`:
  creator-world event-surface research and serialized callback architecture.

## Method 270: Compile-time generated RPC surface over synced byte arrays with target-routing semantics

- What it is:
  a networking layer annotates methods with target metadata, generates the
  dispatch surface during compilation, serializes parameters into a synced byte
  buffer, and routes calls according to target mode.
- Good for:
  parameterized creator networking, typed RPC experiments, sync abstraction
  layers, and target-aware call routing.
- Why it matters:
  it captures how to build higher-level networking semantics on top of very
  simple transport primitives.
- Strong references:
  `UdonSharpNetworkingLib`.
- Best fit for `VR-apps-lab`:
  creator-world networking patterns and compile-generated transport surfaces.

## Method 271: In-world runtime console with abstract logger base, log-type filters, timestamps, and font controls

- What it is:
  a runtime logger separates a generic logging surface from one concrete
  console window that stores entries, filters them by type, toggles timestamps,
  and exposes in-world sizing controls.
- Good for:
  creator diagnostics, runtime debug panels, admin consoles, and world-side
  observation surfaces.
- Why it matters:
  it shows how to turn `logging`
  into a reusable world-facing tool rather than a stream of isolated debug
  lines.
- Strong references:
  `VUdon-Logger`.
- Best fit for `VR-apps-lab`:
  creator-world diagnostics and in-world debug-surface donors.

## Method 272: Editor-plus-build-postprocess depth-buffer activation for scene cameras and mirrors

- What it is:
  a small toolkit exposes editor menu actions for scene cameras, adds a runtime
  activator prefab, and patches mirror cameras through a build-time postprocess
  plus a tiny one-shot runtime component.
- Good for:
  render fixups, depth-dependent effects, mirror compatibility helpers, and
  narrow world-authoring utilities.
- Why it matters:
  it captures a very reusable `tiny fix with editor help and runtime cleanup`
  pattern for creator-world rendering problems.
- Strong references:
  `VUdon-DepthBufferToolkit`.
- Best fit for `VR-apps-lab`:
  render-fixup utilities and creator-world world-setup helpers.

## Method 273: Shader-grid and custom-render-texture stage-lighting system with local operator panel and patch export workflow

- What it is:
  a world-side lighting system drives fixtures through DMX-like textures or
  grids, exposes a local operator panel for quality and intensity control, and
  supports patch export or authoring tools in the editor.
- Good for:
  stage lighting, world operator panels, DMX-style systems, shader-driven
  control surfaces, and creator event production tools.
- Why it matters:
  it shows how a broad operator ecosystem can still stay coherent across
  runtime control, transport buffers, camera layout, and export tooling.
- Strong references:
  `VR-Stage-Lighting`.
- Best fit for `VR-apps-lab`:
  creator-world operator-surface research and complex control-system donors.

## Method 274: Shared environment controller with synced global clock and optional local override

- What it is:
  a compact controller keeps one normalized time or speed state synced for the
  whole world while optionally allowing a local preview override for the user
  adjusting it.
- Good for:
  day-night systems, ambience controllers, shared weather baselines, and simple
  world-state managers.
- Why it matters:
  it captures how a very small synced state can still drive a wide set of world
  outputs cleanly.
- Strong references:
  `UdonSharpDayNightController`.
- Best fit for `VR-apps-lab`:
  creator-world environment controllers and small shared-state donors.

## Method 275: Multi-code keypad surface with object toggles and Udon callback routing

- What it is:
  a keypad system splits input, display, settings, and validation into
  cooperating components, supports multiple codes, toggles mapped objects, and
  dispatches granted, denied, or closed callbacks into Udon programs.
- Good for:
  access control, puzzle gates, operator panels, world permissions, and
  reusable control gadgets.
- Why it matters:
  it shows a strong `component split plus declarative config`
  pattern for creator-world access surfaces.
- Strong references:
  `VRChat_Keypad`.
- Best fit for `VR-apps-lab`:
  creator-world control surfaces and access-gating donors.

## Method 276: Compact drag-and-drop keypad with allow or deny gating and per-code door separation

- What it is:
  a monolithic but configurable keypad normalizes primary and additional codes,
  applies allow or deny lists, plays optional audio cues, and can route
  different codes to different door objects.
- Good for:
  quick prefab integration, access gating, multi-door routing, small admin
  surfaces, and creator-world puzzle mechanics.
- Why it matters:
  it captures the other side of keypad design:
  `fast setup and compact ownership`
  rather than a more explicit multi-script split.
- Strong references:
  `UdonKeypad`.
- Best fit for `VR-apps-lab`:
  creator-world gadget research and compact prefab utility donors.

## Method 277: Editor workbench with project-scoped Unity prefs and dedicated pose editing for avatar setup

- What it is:
  a broad editor shell centralizes avatar setup operations while storing its
  own state under project-scoped preference keys and exposing a dedicated pose
  editing surface rather than relying only on scattered menu items.
- Good for:
  creator workbenches, project-local editor state, pose-authoring helpers, and
  reusable avatar setup shells.
- Why it matters:
  it captures how a large creator utility can stay coherent across projects
  instead of becoming one global stateful editor blob.
- Strong references:
  `PumkinsAvatarTools`.
- Best fit for `VR-apps-lab`:
  avatar authoring workbench research and project-scoped editor-tool design.

## Method 278: Generic avatar copier pipeline with ignored-transform mapping and migration-oriented copy bookkeeping

- What it is:
  a copier layer tracks from or to objects, ignored transforms, and copy-state
  bookkeeping explicitly so avatar migration tasks can be repeated and debugged
  more safely.
- Good for:
  avatar migration, partial setup cloning, tool-driven component copying, and
  editor-side remap helpers.
- Why it matters:
  it turns copying into a real pipeline surface instead of a one-shot editor
  trick.
- Strong references:
  `PumkinsAvatarTools`.
- Best fit for `VR-apps-lab`:
  avatar setup tooling and migration-helper architecture.

## Method 279: Non-destructive avatar converter that injects validator automators and tracks asset replacements through NDMF passes

- What it is:
  a conversion pipeline validates avatars while creators edit, then performs
  non-destructive build passes while tracking which objects, materials, clips,
  or controllers were replaced.
- Good for:
  mobile-target conversion, validator-driven build tooling, asset replacement
  registries, and build-pipeline authoring.
- Why it matters:
  it captures a strong way to keep heavy avatar mutation inspectable instead of
  opaque.
- Strong references:
  `VRCQuestTools`.
- Best fit for `VR-apps-lab`:
  Quest portability, validator surfaces, and non-destructive conversion
  research.

## Method 280: Upload-triggered avatar optimizer with shader-merge analysis and animator-controller rewrite stages

- What it is:
  an upload-time optimizer can inject itself into the build path, then stage
  cleanup across shader analysis, material merge, mesh transforms, and animator
  graph rewrites instead of stopping at geometry-only optimization.
- Good for:
  build-time optimization, shader-aware merging, animator cleanup, and staged
  performance tooling.
- Why it matters:
  it shows how optimization becomes much stronger once controller and shader
  structure are treated as first-class inputs.
- Strong references:
  `d4rkAvatarOptimizer`.
- Best fit for `VR-apps-lab`:
  avatar optimization research and staged build-mutation architecture.

## Method 281: Code-first facade over avatar composition components with dummy authoring and retargetable root binding

- What it is:
  a thin code layer emits or edits creator components directly, supports dummy
  or no-op mode, and can retarget the same authoring logic to another root.
- Good for:
  code-driven authoring, component-graph generation, reusable setup scripts, and
  composition automation.
- Why it matters:
  it captures a strong
  `code-first authoring over inspector-native ecosystem`
  pattern.
- Strong references:
  `modular-avatar-as-code`.
- Best fit for `VR-apps-lab`:
  creator automation and code-first component authoring research.

## Method 282: Project-manager split with core resolver library, CLI shell, and GUI background metadata sync

- What it is:
  one system keeps package resolution and project metadata logic in a core
  library while thin CLI and GUI shells reuse it and background-sync the real
  project state from disk.
- Good for:
  package managers, environment repair tools, cross-platform creator tooling,
  and library-plus-shell product design.
- Why it matters:
  it shows how project health tooling can stay both scriptable and user-facing
  without duplicating its core logic.
- Strong references:
  `vrc-get`.
- Best fit for `VR-apps-lab`:
  project-manager architecture and creator-environment tooling.

## Method 283: Attribute-discovered multi-tab avatar manager with safe per-run asset output directories

- What it is:
  an avatar helper shell discovers tool tabs dynamically and generates copied
  or merged assets into unique output directories so repeated runs stay safer.
- Good for:
  multi-tool editor shells, safe asset generation, reusable helper APIs, and
  scripted creator workflows.
- Why it matters:
  it captures how tool aggregation can stay organized without writing one giant
  hard-coded window.
- Strong references:
  `Avatars-3.0-Manager`.
- Best fit for `VR-apps-lab`:
  editor-shell design and asset-copy workflow research.

## Method 284: Clone-based playable avatar emulator with expression-menu stack and OSC loopback

- What it is:
  an emulator creates preview clones, keeps an expression-menu stack, and can
  send or receive OSC so creators can rehearse more of the live avatar
  experience inside the editor.
- Good for:
  avatar preview, live-menu emulation, rehearsal tooling, and OSC loopback
  testing.
- Why it matters:
  it captures a deeper kind of creator preview than a simple animation player.
- Strong references:
  `Av3Emulator`.
- Best fit for `VR-apps-lab`:
  avatar rehearsal environments and preview-substrate design.

## Method 285: Radial-menu preview harness with avatar-state modules, tracking dummies, and OSC debugging

- What it is:
  a preview harness organizes avatar testing through radial surfaces and
  modular subsystems for state, tools, dummies, OSC, and debug windows.
- Good for:
  gesture preview, editor rehearsal, debug-heavy tool design, and modular
  preview environments.
- Why it matters:
  it shows how a preview tool can stay operable even when it covers many
  independent avatar subsystems.
- Strong references:
  `VRC-Gesture-Manager`.
- Best fit for `VR-apps-lab`:
  preview-harness UX and modular debug-surface research.

## Method 286: Avatar repair toolkit with bone remapping, skinned-mesh combine, fitting-room, and hierarchy surgery utilities

- What it is:
  a repair suite groups several narrow intervention tools together so creators
  can remap bones, combine meshes, fit outfits, normalize armatures, and clean
  hierarchy problems without one monolithic pipeline.
- Good for:
  manual repair, fitting-room tooling, pre-upload cleanup, and narrow
  intervention surfaces.
- Why it matters:
  it captures how
  `manual avatar surgery`
  can remain reusable without pretending every fix belongs in an optimizer.
- Strong references:
  `avautils`.
- Best fit for `VR-apps-lab`:
  manual-repair donors and creator intervention toolkit research.

## Method 287: OSC sidecar with autosave, undo-history, and puppet-scene pose orchestration

- What it is:
  a pose sidecar manages save, load, autosave, scene snapshots, and undo or
  redo state across OSC messages instead of sending isolated stateless pose
  commands.
- Good for:
  external pose companions, puppet-session tools, history-aware OSC helpers,
  and pose-workflow automation.
- Why it matters:
  it shows how a sidecar can own session state and history rather than acting
  as a thin transport bridge.
- Strong references:
  `LexisPosingSystem`.
- Best fit for `VR-apps-lab`:
  avatar pose companion research and OSC-session architecture.

## Method 288: Queue-based multi-engine speech hub with VRChat listener triggers and OSC or chatbox or avatar-text fan-out

- What it is:
  a speech hub queues utterances, listens to VRChat-side triggers, and fans
  results out through OSC, chatbox, avatar text, or other integrations while
  keeping recognition and synthesis engines swappable.
- Good for:
  speech sidecars, accessibility tools, translation hubs, and multi-output
  communication utilities.
- Why it matters:
  it captures how speech tooling becomes more reusable once it is built as an
  orchestrator instead of one speech engine.
- Strong references:
  `TTS-Voice-Wizard`.
- Best fit for `VR-apps-lab`:
  speech-sidecar architecture and avatar-facing communication tooling.

## Method 289: Browser-or-server TTS pipeline with phoneme timestamps, viseme outputs, and WebSocket or WebWorker backends

- What it is:
  one TTS substrate exposes the same client contract whether inference happens
  in-browser or on a server, while returning both audio and timing data suited
  to lip-sync.
- Good for:
  viseme-aware TTS, browser speech tools, local inference fallback, and
  lip-sync-capable speech engines.
- Why it matters:
  it captures a strong way to separate deployment choice from the speech client
  API itself.
- Strong references:
  `HeadTTS`.
- Best fit for `VR-apps-lab`:
  speech-engine substrate and viseme-timing research.

## Method 290: Translator shell that combines desktop UI, OSC output, and timed OpenVR image overlays

- What it is:
  a translation helper splits operator UI, OSC data-out, and VR-visible overlay
  presentation into separate cooperating layers rather than forcing one runtime
  process to own everything.
- Good for:
  translator sidecars, caption surfaces, desktop-plus-VR helpers, and hybrid
  utility shells.
- Why it matters:
  it captures a reusable
  `desktop shell plus VR surface`
  architecture for language and text helpers.
- Strong references:
  `kikitan-translator`.
- Best fit for `VR-apps-lab`:
  translation sidecars and overlay-backed communication surfaces.

## Method 291: World-droppable speech billboard prefab built on avatar-text parameter budgets and fallback visual states

- What it is:
  an avatar-visible speech surface treats parameter space, write-default
  compatibility, world pickup or drop behavior, and fallback visibility as core
  product constraints instead of afterthoughts.
- Good for:
  avatar speech surfaces, accessibility-prefab design, product-reference
  studies, and parameter-budget-aware UX.
- Why it matters:
  it shows how an avatar-facing communication tool can deliver value even when
  the deeper speech engines live elsewhere.
- Strong references:
  `Billboard`.
- Best fit for `VR-apps-lab`:
  avatar-visible communication UX and prefab-surface research.

## Method 292: Shader material translator table that preserves render mode and render queue

- What it is:
  a material migration utility detects the source shader, chooses a target
  shader variant, applies render presets, maps properties through an explicit
  table, and restores compatibility-sensitive fields such as render queue.
- Good for:
  shader migration tools, avatar material repair, creator workflow helpers,
  and upgrade assistants.
- Why it matters:
  it turns shader conversion from a manual checklist into a reusable editor
  pass with visible caveats.
- Strong references:
  `PoiyomiToonShader`, `lilToonToPoiyomiToon`.
- Best fit for `VR-apps-lab`:
  avatar material migration and creator-side visual tooling.

## Method 293: Multi-material shader inspector with constant-property shader optimization

- What it is:
  a shader ecosystem exposes rich inspector modes and scans materials plus
  animation clips to determine which shader properties are constant enough to
  compile into defines.
- Good for:
  shader inspectors, material optimizers, multi-material editing, and
  performance-aware avatar authoring.
- Why it matters:
  it shows that shader UX and shader performance can be managed together at
  editor time.
- Strong references:
  `lilToon`.
- Best fit for `VR-apps-lab`:
  shader inspector research and upload-time visual optimization.

## Method 294: Modular shader pack built around shared include substrate

- What it is:
  a shader pack keeps specialized effect families separate while reusing
  common include files for audio, light-volume, noise, sampling, and helper
  logic.
- Good for:
  effect packs, world-reactive shaders, avatar shader libraries, and shared
  visual substrate design.
- Why it matters:
  it prevents every shader effect from becoming an isolated implementation
  island.
- Strong references:
  `Mochies-Unity-Shaders`.
- Best fit for `VR-apps-lab`:
  shader-pack architecture and reusable visual-effect substrate.

## Method 295: Avatar visual-safety grabpass dimmer with threshold, blackout, and HDR clamp

- What it is:
  an avatar-installed shader samples the background, computes luminance, dims
  bright areas, and exposes comfort controls such as threshold, softness,
  blackout, night mode, HDR clamp, and distance hide.
- Good for:
  accessibility addons, visual comfort tools, avatar-level safety helpers, and
  shader-side screen filters.
- Why it matters:
  it shows that accessibility can be shipped as a narrow avatar utility while
  still documenting its limits honestly.
- Strong references:
  `EpilepsyProtection`.
- Best fit for `VR-apps-lab`:
  visual-safety and accessibility shader research.

## Method 296: Feature-builder avatar installer with DI verification, public API wrappers, and menu auto-pagination

- What it is:
  an avatar feature system keeps a deep builder substrate internally while
  exposing small public API wrappers and validating dependency-injection
  contexts before build-time code runs.
- Good for:
  avatar install automation, feature builders, non-destructive composition, and
  generated menu systems.
- Why it matters:
  it shows how broad avatar automation can remain scriptable without losing
  internal guardrails.
- Strong references:
  `VRCFury`.
- Best fit for `VR-apps-lab`:
  avatar feature automation and install-safe helper systems.

## Method 297: Reflection-backed editor extension shell with inspector overlay, clone preview, and cleanup

- What it is:
  an extension layer reflects over an upstream tool, registers typed helper
  actions, injects inline inspector UI, and previews changes by cloning the
  avatar while cleaning abandoned previews across reloads.
- Good for:
  editor QoL tools, upstream extension shells, non-destructive preview, and
  hot-reload helper systems.
- Why it matters:
  it adds workflow value without requiring a fork, while making cleanup and
  graceful degradation explicit.
- Strong references:
  `wk-vrcfury-qol`.
- Best fit for `VR-apps-lab`:
  creator-tool extension surfaces and preview-shell design.

## Method 298: Toggle generator that emits clips, FX layers, parameters, expression menu entries, and exclusive state

- What it is:
  a generator window converts selected avatar objects and toggle settings into
  animation clips, animator layers, expression parameters, menus, exclusive
  groups, defaults, and fallback state.
- Good for:
  avatar toggles, menu generation, simple creator automation, and old-school
  asset-emission workflows.
- Why it matters:
  it captures the whole toggle pipeline in a visible, narrow tool.
- Strong references:
  `VRCToggleToolkit`.
- Best fit for `VR-apps-lab`:
  avatar toggle generation and creator micro-tool research.

## Method 299: VRChat animator DSL for parameter drivers and safe play-audio behavior

- What it is:
  fluent code extensions generate VRChat animator behaviors such as parameter
  drivers, remaps, local or unsynced randomization, and play-audio actions
  with conservative defaults.
- Good for:
  code-first avatar authoring, animator graph generation, repeatable setup, and
  behavior libraries.
- Why it matters:
  it turns fragile inspector work into reusable source-level intent.
- Strong references:
  `animator-as-code-vrchat`.
- Best fit for `VR-apps-lab`:
  code-first avatar authoring and generated animator behavior research.

## Method 300: Tiny public-API micro-tool over selected avatar objects

- What it is:
  a small editor script uses a stable public API to transform selected
  GameObjects into configured avatar features with menu paths and default
  actions.
- Good for:
  one-click creator helpers, API smoke references, and workflow shortcuts.
- Why it matters:
  it proves whether a large automation system has ergonomic APIs that small
  tools can actually reuse.
- Strong references:
  `vrchat-quick-toggle-vrcfury`.
- Best fit for `VR-apps-lab`:
  micro-utility design and public-API evaluation.

## Method 301: Sandboxed face-tracking module host with unified expression state and OSC bundle output

- What it is:
  a host app loads tracking modules through a lifecycle interface, normalizes
  their output into unified eye and expression state, batches OSC parameter
  messages, and isolates modules through a sandboxed IPC path.
- Good for:
  face tracking bridges, sensor adapter hosts, OSC tools, module registries,
  and diagnostics-heavy companion apps.
- Why it matters:
  it separates device-specific providers from the avatar-facing parameter
  output model.
- Strong references:
  `VRCFaceTracking`.
- Best fit for `VR-apps-lab`:
  tracking-helper architecture and face-tracking bridge research.

## Method 302: Cross-platform module registry shell with compatibility matrix and legacy module migration

- What it is:
  a portable desktop shell fetches remote module metadata, caches ratings and
  downloads, scans installed modules, migrates legacy DLLs into metadata
  folders, and exposes compatibility differences across platforms.
- Good for:
  plugin managers, module registries, compatibility dashboards, and
  cross-platform creator tools.
- Why it matters:
  it makes ecosystem state visible instead of hiding compatibility inside
  release notes.
- Strong references:
  `VRCFaceTracking.Avalonia`.
- Best fit for `VR-apps-lab`:
  module registry UX and cross-platform companion shells.

## Method 303: Provider module that maps local OSC, UDP, or JSON streams into unified expressions

- What it is:
  a thin provider module receives tracking data from a local app or phone,
  maps addresses or JSON shape names into normalized expression slots, applies
  scaling or simulated-shape rules, and lets the host own output.
- Good for:
  external sensor adapters, phone tracking modules, local OSC bridges, and
  face-expression normalization.
- Why it matters:
  it shows the smallest useful unit of a tracking provider when the host
  supplies lifecycle and output abstractions.
- Strong references:
  `VRCFT-Babble`, `VRCFaceTracking-MeowFace`.
- Best fit for `VR-apps-lab`:
  sensor-module templates and expression mapping research.

## Method 304: DCC shape-key preparation panel for standard face-tracking labels

- What it is:
  a Blender-side panel presents a fixed target shape-key vocabulary, lets
  creators map existing shapes to each target, handles duplicates, and creates
  missing keys or keys from source shapes.
- Good for:
  avatar authoring, face-tracking preparation, DCC-to-runtime bridges, and
  standardized expression setup.
- Why it matters:
  it closes the gap between runtime tracking data and assets that can respond
  to it.
- Strong references:
  `VRCFaceTracking-blender-plugin`.
- Best fit for `VR-apps-lab`:
  avatar authoring helpers and face-tracking setup workflows.

## Method 305: PhysBone-to-DynamicBone migration converter with explicit lossy and lossless mapping

- What it is:
  an editor converter scans PhysBone components and colliders, optionally
  duplicates the avatar subtree, maps fields into Dynamic Bone equivalents,
  and documents where restoration is approximate.
- Good for:
  component migration tools, avatar rollback workflows, editor conversion
  utilities, and transparent approximation passes.
- Why it matters:
  it models honest migration design where perfect conversion is impossible.
- Strong references:
  `PhysBone-to-DynamicBone`.
- Best fit for `VR-apps-lab`:
  avatar component migration and converter-tool research.

## Method 306: Expression-menu PhysBone tuner with reload commands and accessory world-constraint controls

- What it is:
  an avatar prefab maps expression menu controls into PhysBone and transform
  parameters, uses command state to apply presets or resets, and reloads the
  target object so changed properties take effect in-game.
- Good for:
  in-VR calibration, avatar dynamics tuning, parameter-budget-aware menus, and
  accessory placement tools.
- Why it matters:
  it turns avatar dynamics authoring into an embodied calibration workflow.
- Strong references:
  `PhysBonesTK`.
- Best fit for `VR-apps-lab`:
  in-game tuning surfaces and avatar dynamics UX.

## Method 307: Detached PhysBone component grouping for outfit toggles and component budget management

- What it is:
  a tiny editor tool copies PhysBone and collider components into a grouped
  hierarchy, removes originals, and remaps collider references so dynamic
  behavior can be toggled or managed separately.
- Good for:
  outfit toggles, component budget management, hierarchy surgery, and
  VRCFury/Modular Avatar preparation.
- Why it matters:
  it shows that small hierarchy transforms can unlock practical avatar runtime
  control.
- Strong references:
  `VRChat_PhysboneDetach`.
- Best fit for `VR-apps-lab`:
  avatar hierarchy surgery and component management tools.

## Method 308: Contact-driven avatar prop using trackers, constraints, PhysBones, and FX parameters

- What it is:
  a prefab uses contact tracker values, PhysBones, constraints, IK assumptions,
  and animator parameters so remote users can grab, orient, and drop a prop
  attached to an avatar.
- Good for:
  avatar-side physical interaction, social VR props, contact-driven controls,
  and prefab product references.
- Why it matters:
  it shows how avatar interaction can approximate world-like manipulation
  without requiring a world system.
- Strong references:
  `Avatar-Prop`.
- Best fit for `VR-apps-lab`:
  avatar physical interaction and contact-driven UX research.

## Method 309: Particle/contact collision prefab with small animator bool surface

- What it is:
  a prefab uses one particle system and contact state to expose a compact
  collision boolean surface with reset and always-reset behavior.
- Good for:
  avatar collision utilities, contact-state prefabs, low-budget interaction
  signals, and FX-controller integration.
- Why it matters:
  it packages collision detection as a small reusable state surface instead of
  a large physics subsystem.
- Strong references:
  `Collision-Detection`.
- Best fit for `VR-apps-lab`:
  contact/collision prefab design and physical-state surfaces.

## Method 310: Companion overlay live-feed shell with offscreen Electron rendering

- What it is:
  a desktop companion app gathers social, avatar, world, media, and device
  state, renders a compact VR feed, and can use an offscreen browser window to
  publish overlay frames through a runtime-facing buffer.
- Good for:
  companion apps, overlay feeds, in-headset status panels, social dashboards,
  and device-state summaries.
- Why it matters:
  it turns background app state into a live operator surface without requiring
  every feature to be native VR UI.
- Strong references:
  `VRCX`.
- Best fit for `VR-apps-lab`:
  companion overlay shells and state-feed product references.

## Method 311: VRChat OSC fan-out router with packet filtering and route debug stream

- What it is:
  a local router receives VRChat OSC on one port, filters or repairs packets,
  forwards accepted payloads to configured apps, and exposes debug events for
  allowed, dropped, malformed, and route-error cases.
- Good for:
  OSC-heavy companion ecosystems, haptics bridges, speech sidecars, tracker
  bridges, avatar automation, and local integration stacks.
- Why it matters:
  VRChat can create OSC port contention; a router makes coexistence observable
  and manageable.
- Strong references:
  `VOR`.
- Best fit for `VR-apps-lab`:
  OSC routing, diagnostics, and sidecar coexistence patterns.

## Method 312: Plugin-host OSC sender where extensions request sends and holder owns sockets

- What it is:
  a desktop holder app owns OSC socket lifecycle and exposes a plugin contract
  where extensions request sends, receive OSC callbacks, access settings, and
  observe holder status.
- Good for:
  modular OSC utilities, plugin ecosystems, creator companion apps, and
  feature packs that should not each own networking.
- Why it matters:
  it gives small plugins a stable boundary while centralizing endpoint and UDP
  state.
- Strong references:
  `VRCOSCGUI`.
- Best fit for `VR-apps-lab`:
  plugin-hosted OSC tool design and modular companion apps.

## Method 313: OSC-to-TCP data hub with type-tag extraction and split-friendly payloads

- What it is:
  a small bridge receives OSC, extracts typed values, normalizes them into a
  simple address/value text format, and forwards that stream over TCP to local
  tools that do not speak OSC.
- Good for:
  local dashboards, debug panels, simple automation scripts, and protocol
  adapters.
- Why it matters:
  it lowers the integration cost for downstream tools by converting OSC into a
  trivial local stream.
- Strong references:
  `VRCOSCDataHub`.
- Best fit for `VR-apps-lab`:
  local data hubs and protocol-simplification micro-utilities.

## Method 314: Browser avatar-parameter debug surface backed by OSC and avatar JSON

- What it is:
  a browser app loads VRChat avatar OSC JSON metadata, renders controls for
  parameters, subscribes to live OSC updates through WebSockets, and sends OSC
  commands back to VRChat.
- Good for:
  avatar debugging, creator tools, web operator panels, local control surfaces,
  and rapid UI experiments.
- Why it matters:
  it proves a browser can be a serious VRChat utility surface without a heavy
  desktop shell.
- Strong references:
  `VRCOSCWeb`.
- Best fit for `VR-apps-lab`:
  browser-based debug panels and avatar parameter tooling.

## Method 315: Tracker server hub with skeleton calibration and multi-output runtime bridges

- What it is:
  a central server receives heterogeneous tracker inputs, owns skeleton and
  calibration state, and forwards normalized tracking data to runtime bridges,
  OSC/VMC outputs, recording/export paths, and a diagnostics GUI.
- Good for:
  full-body tracking helpers, virtual tracker hosts, calibration dashboards,
  OSC/VMC bridges, and runtime integration hubs.
- Why it matters:
  it separates device-specific input from calibrated, runtime-ready tracking
  output.
- Strong references:
  `SlimeVR-Server`.
- Best fit for `VR-apps-lab`:
  tracker hub architecture and calibration UX research.

## Method 316: Firmware tracker protocol with diagnostics packets and calibration persistence

- What it is:
  tracker firmware sends pose and acceleration along with sensor identity,
  error state, battery, signal, temperature, feature flags, calibration, and
  config acknowledgements.
- Good for:
  IMU trackers, hardware diagnostics, battery dashboards, firmware protocols,
  and robust device monitors.
- Why it matters:
  tracker health should be a first-class protocol concern instead of a hidden
  firmware detail.
- Strong references:
  `SlimeVR-Tracker-ESP`.
- Best fit for `VR-apps-lab`:
  firmware telemetry and tracker diagnostics design.

## Method 317: Consumer tracker adapters that normalize Joy-Con, Mocopi, or HaritoraX streams into SlimeVR

- What it is:
  an adapter connects to a consumer tracking or controller device, normalizes
  rotation, acceleration, identity, battery, buttons, and errors, then emits a
  SlimeVR-compatible tracker stream.
- Good for:
  hardware bridges, tracker adapters, BLE/COM device wrappers, consumer-device
  experiments, and guided setup tools.
- Why it matters:
  it turns heterogeneous hardware into a common tracker protocol while keeping
  device quirks at the edge.
- Strong references:
  `slimevr-wrangler`, `moslime`, `SlimeTora`.
- Best fit for `VR-apps-lab`:
  hardware adapter UX and tracker normalization patterns.

## Method 318: Haptic player SDK facade with event, dot, path, status, and device-management calls

- What it is:
  an SDK facade registers authored feedback, submits event, dot, path, glove,
  or generated patterns, checks connected devices and playing state, and talks
  to a local haptic player runtime.
- Good for:
  haptics bridges, browser panels, Python automation, game integration, and
  accessibility output tools.
- Why it matters:
  a reusable haptics layer needs both high-level authored events and low-level
  generated feedback.
- Strong references:
  `haptic-library`, `tact-js`, `tact-python`.
- Best fit for `VR-apps-lab`:
  haptic utility APIs and non-visual feedback channels.

## Method 319: Avatar OSC-to-haptics bridge with per-motor buffers and avatar-change reset

- What it is:
  a bridge maps VRChat avatar OSC parameters into device-specific haptic motor
  buffers, reloads config, resets on avatar changes, and gates output by
  avatar/player state.
- Good for:
  social VR haptics, avatar-driven feedback, OSC sidecars, wearable devices,
  and tactile accessibility cues.
- Why it matters:
  it shows how avatar parameters can control wearable feedback while still
  needing safety, reset, and device configuration layers.
- Strong references:
  `bHapticsOSC`.
- Best fit for `VR-apps-lab`:
  avatar OSC haptics and wearable feedback research.

## Method 320: Generic haptics relay from log lines or WebSocket commands

- What it is:
  a local relay tails application logs or accepts WebSocket messages, parses a
  command vocabulary, maps commands into haptic SDK calls, and reports request
  status back to clients.
- Good for:
  modding tools, telemetry-to-haptics adapters, local automation, accessibility
  alerts, and games without direct SDK integration.
- Why it matters:
  many apps can emit logs or local messages even when they cannot embed a
  haptics SDK.
- Strong references:
  `bHapticsRelay`.
- Best fit for `VR-apps-lab`:
  event-to-output relays and lightweight integration sidecars.

## Method 321: Phone-as-HMD bridge with pairing, projection exchange, pose ingress, and video streamout

- What it is:
  an OpenVR driver pairs with a phone, negotiates display and projection data,
  receives pose, streams rendered frames, and exposes latency or FPS diagnostics
  to help the user understand quality.
- Good for:
  phone-HMD experiments, streaming bridge research, mobile viewer prototypes,
  and historical headsetless workflows.
- Why it matters:
  it breaks phone VR into explicit transport, projection, pose, and video
  components.
- Strong references:
  `PhoneVR`.
- Best fit for `VR-apps-lab`:
  phone-HMD architecture history and streaming bridge anatomy.

## Method 322: Desktop display or null display OpenVR HMD component

- What it is:
  a fake HMD driver implements the minimal tracked-device and display
  component surfaces SteamVR expects, sets render target/projection/display
  properties, and updates a valid pose each frame.
- Good for:
  no-HMD workflows, driver tutorials, desktop-display experiments, fake device
  stubs, and development harnesses.
- Why it matters:
  it documents the minimum viable OpenVR display anatomy for headsetless
  iteration.
- Strong references:
  `driver_hmd`, `faceless`.
- Best fit for `VR-apps-lab`:
  OpenVR fake-HMD reference design and driver learning.

## Method 323: External/scripted virtual-device control harness over a socket

- What it is:
  a virtual OpenVR driver listens on a local socket for pose, button, eye, or
  test commands so an external script can drive HMD/controller state and replay
  scripted scenarios.
- Good for:
  automated VR testing, regression harnesses, pose replay, input simulation,
  and CI-adjacent developer tools.
- Why it matters:
  controllable virtual devices are a path toward repeatable VR tests without
  always needing physical hardware.
- Strong references:
  `OpenVRsim`.
- Best fit for `VR-apps-lab`:
  virtual-device automation and headsetless test harnesses.

## Method 324: Keyboard-and-mouse fake HMD plus controller rig for SteamVR development

- What it is:
  a tutorial driver registers a fake HMD and fake controllers, updates pose and
  controller component handles from keyboard/mouse state, and lets SteamVR see
  a usable minimal rig.
- Good for:
  driver onboarding, local development, simple no-HMD demos, controller input
  simulation, and education.
- Why it matters:
  it shows the smallest teachable unit of a provider, fake devices, input
  thread, pose loop, and controller components.
- Strong references:
  `Pepper`.
- Best fit for `VR-apps-lab`:
  educational OpenVR driver stubs and fake-device anatomy.

## Method 325: WebXR session shell with inline and immersive split

- What it is:
  a browser XR helper owns session support checks, inline fallback, immersive
  session requests, WebGL compatibility, layer creation, reference-space setup,
  input-source updates, hit tests, controller rendering, stats, and teleport by
  reference-space offset.
- Good for:
  browser XR diagnostics, sample apps, local operator panels, controller
  visualizers, and fast WebXR experiments.
- Why it matters:
  it makes browser XR bring-up explicit enough to reuse without starting from a
  full engine or native runtime stack.
- Strong references:
  `webxr-samples`.
- Best fit for `VR-apps-lab`:
  lightweight WebXR utility shells and browser-first diagnostics.

## Method 326: WebXR input profile registry and motion-controller asset validator

- What it is:
  a registry maps input-source profiles to component layouts, gamepad mappings,
  and controller assets, while validators enforce profile inheritance,
  component definitions, duplicate rules, axes ordering, and asset naming.
- Good for:
  controller visualizers, input diagnostics, hardware profile explorers, and
  portable controller-rendering tools.
- Why it matters:
  input visualization should be data-driven and validated rather than hardcoded
  per device.
- Strong references:
  `webxr-input-profiles`.
- Best fit for `VR-apps-lab`:
  controller profile catalogs and input capability inspectors.

## Method 327: Domain-scoped browser WebXR emulator injection with DevUI and synthetic environment

- What it is:
  a browser extension injects an emulated WebXR runtime into selected domains,
  installs device and environment simulation, exposes a DevUI, and can toggle
  the injection without modifying the web app.
- Good for:
  WebXR debugging, browser devtools, device simulation, demo development, and
  local XR test harnesses.
- Why it matters:
  emulator injection gives browser XR a hardware-light development path while
  keeping scope bounded to chosen pages.
- Strong references:
  `immersive-web-emulator`.
- Best fit for `VR-apps-lab`:
  WebXR emulator/devtool architecture and browser-based test workflows.

## Method 328: Polyfill display and reality abstraction as historical browser XR fallback

- What it is:
  a polyfill installs XR classes, display abstractions, reality providers,
  anchors, camera/display paths, and fallback bridges over older browser XR
  APIs or platform-specific AR providers.
- Good for:
  architecture history, fallback design notes, browser XR compatibility
  analysis, and API evolution research.
- Why it matters:
  deprecated layers still document useful boundaries between display, reality,
  anchors, camera frames, and browser surfaces.
- Strong references:
  `webxr-polyfill`.
- Best fit for `VR-apps-lab`:
  browser XR history and abstraction comparison notes.

## Method 329: WebXR framework store with typed input states, teleport, layers, and emulator hooks

- What it is:
  a framework store owns WebXR session state, reference spaces, DOM overlay
  roots, visibility, frame rate, input-source state, pointer events, detected
  planes/meshes, layers, teleport targets, and emulator state.
- Good for:
  React/Three XR apps, browser utilities, spatial UI experiments, and web
  operator panels.
- Why it matters:
  it translates low-level WebXR session/input details into stable app state and
  reusable interaction events.
- Strong references:
  `pmndrs/xr`.
- Best fit for `VR-apps-lab`:
  browser utility state stores and WebXR UI prototypes.

## Method 330: OpenXR/XRI modular MR toolkit package split with UX, input, and spatial manipulation layers

- What it is:
  a Unity MR toolkit separates core interactable state, pressable logic,
  manipulation, solvers, UX components, diagnostics, input, and speech or
  accessibility packages into reusable modules.
- Good for:
  spatial UI, utility menus, hand/near menus, slates, dialogs, manipulation,
  and calibration surfaces.
- Why it matters:
  robust MR UI needs reusable interaction state machines and solver layers,
  not only scene-specific scripts.
- Strong references:
  `MixedRealityToolkit-Unity`.
- Best fit for `VR-apps-lab`:
  Unity spatial-UI and utility-menu architecture.

## Method 331: Scientific XR rig toolkit with configurable movement, data capture, quizzes, and exhibition helpers

- What it is:
  a Unity toolkit packages XR rig presets, locomotion options, interaction
  primitives, data gathering, CSV/HTTP export, quizzes, tutorials, HUDs,
  sockets, value-range controls, and exhibition scenes.
- Good for:
  research apps, museum demos, guided setup, training, experiment logging, and
  structured onboarding flows.
- Why it matters:
  many VR utilities need user-flow instrumentation and training scaffolding,
  not just interaction widgets.
- Strong references:
  `ExPresS-XR`.
- Best fit for `VR-apps-lab`:
  data-capturing VR workflows and guided utility experiences.

## Method 332: No-code VR training workflow graph with steps, behaviors, conditions, and scene-object properties

- What it is:
  a workflow editor represents a VR process as steps with behaviors,
  transitions, conditions, unlocked scene objects, scene-object properties,
  validation warnings, and editor fix actions.
- Good for:
  training tools, calibration wizards, guided diagnostics, procedural
  onboarding, and creator-facing workflow authoring.
- Why it matters:
  graph-based process tools can make complex VR setup flows maintainable by
  non-programmers.
- Strong references:
  `VR-Builder`.
- Best fit for `VR-apps-lab`:
  guided workflow authoring and calibration process design.

## Method 333: Prefab-composed Tilia/VRTK interaction scene with rules, actions, pointers, teleport, and grab swaps

- What it is:
  a Unity scene is assembled from reusable packages and prefabs for camera
  rigs, pointers, actions, rule aggregators, interactables, snap zones,
  haptics, locomotors, trackers, visuals, and sample interaction controllers.
- Good for:
  modular Unity prototypes, creator-facing scene kits, XR training examples,
  and interaction-sandbox scenes.
- Why it matters:
  prefab composition can be a serious architecture when packages, rules, and
  event wiring are kept explicit.
- Strong references:
  `VRTK`.
- Best fit for `VR-apps-lab`:
  Unity prefab-composition patterns and interaction sandbox structure.

## Method 334: Passthrough camera-to-world stack with permission, ray, detection, and anchor marker managers

- What it is:
  a Quest MR sample stack requests camera permissions, reads camera textures
  and metadata, maps camera viewport points into world rays, estimates
  brightness, runs object detection, and attaches persistent markers through
  spatial anchors.
- Good for:
  MR diagnostics, camera-aware overlays, object markers, visual inspectors, and
  physical-room utility tools.
- Why it matters:
  camera-aware utilities need permission, pose reliability, camera geometry,
  ML output, and marker persistence in one coherent flow.
- Strong references:
  `Unity-PassthroughCameraApiSamples`.
- Best fit for `VR-apps-lab`:
  Quest MR camera and physical-object helper patterns.

## Method 335: Depth API occlusion stack with render-pipeline branches, cutout, hand removal, and depth bias

- What it is:
  an MR depth package exposes environment depth to shaders and sample scripts
  for hard/soft occlusion, UI cutout, hand removal, scene mesh masking, wall
  views, and runtime-adjustable depth bias across BiRP and URP paths.
- Good for:
  MR overlays, world-locked panels, spatial markers, comfort controls, and
  depth-aware UI.
- Why it matters:
  real-world occlusion should be tunable and debuggable, not hidden behind a
  single rendering checkbox.
- Strong references:
  `Unity-DepthAPI`.
- Best fit for `VR-apps-lab`:
  MR overlay occlusion and depth diagnostics.

## Method 336: Shared spatial-anchor sequence with create, save, share, publish, load, bind, and align

- What it is:
  a colocated MR app creates and saves anchors, shares them to users or
  groups, publishes anchor identifiers through networking, loads unbound
  shared anchors, binds them, instantiates content, and aligns tracking space
  to a shared anchor pose.
- Good for:
  colocated utilities, shared room setup, persistent markers, physical-space
  collaboration, and MR multiplayer diagnostics.
- Why it matters:
  shared anchors are an end-to-end lifecycle and alignment problem, not just a
  storage API.
- Strong references:
  `Unity-SharedSpatialAnchors`.
- Best fit for `VR-apps-lab`:
  colocated MR setup helpers and shared utility markers.

## Method 337: MR feature motifs and full-app composition for transitions, shared activities, placement, and space sharing

- What it is:
  reusable MR blueprints isolate recurring mechanics such as passthrough
  transitions, shared activities, instant content placement, depth effects,
  room sharing, avatars, group presence, and colocated spawn management.
- Good for:
  MR product planning, feature checklists, sample scenes, onboarding, shared
  spatial experiences, and Quest helper apps.
- Why it matters:
  motifs preserve product-level lessons that are easy to lose in large sample
  apps.
- Strong references:
  `Unity-MRMotifs`, `Unity-Discover`.
- Best fit for `VR-apps-lab`:
  Quest MR product-pattern library and feature blueprints.

## Method 338: Linux XR desktop shell with Godot/OpenXR workspace composition

- What it is:
  a Linux VR desktop shell runs desktop apps through isolated display routes,
  maps windows into a VR workspace, uses gaze-active focus, exposes
  keyboard/mouse grab, workspace shortcuts, surface transforms, and optional
  runtime diagnostics.
- Good for:
  desktop-in-VR research, productivity shells, workspace UX, input-grab
  studies, and Linux runtime diagnostics.
- Why it matters:
  full desktop shells show the product shape around windows, focus, input, and
  workspace management.
- Strong references:
  `Simula`.
- Best fit for `VR-apps-lab`:
  Linux desktop-in-VR UX and full-shell reference design.

## Method 339: Stardust 2D-app bridge and virtual monitor clients for Linux spatial desktops

- What it is:
  a Stardust client converts Wayland or compositor surfaces into XR panels or
  virtual monitors, forwards pointer/touch/keyboard events, provides resize
  and close affordances, and can map screens onto a ring around the user.
- Good for:
  desktop panels, virtual monitors, Linux XR workspaces, spatial browser/app
  surfaces, and input-injection experiments.
- Why it matters:
  panel and virtual-monitor clients are smaller reusable pieces than a full VR
  desktop shell.
- Strong references:
  `flatland`, `kiara`.
- Best fit for `VR-apps-lab`:
  2D surface overlay and virtual monitor helper patterns.

## Method 340: Stardust spatial launcher and workspace grouping micro-clients

- What it is:
  small Stardust clients parse desktop entries, launch apps into the XR
  connection environment, present spatial icon grids, group clients into
  cells, and move captured windows through shared workspace roots.
- Good for:
  XR launchers, utility start panels, workspace organization, multi-window
  grouping, and Linux spatial desktop micro-utilities.
- Why it matters:
  launch and workspace grouping are reusable utility layers separate from
  rendering or compositor internals.
- Strong references:
  `protostar`, `magnetar`.
- Best fit for `VR-apps-lab`:
  spatial app launchers and workspace grouping helpers.

## Method 341: Picom and xrdesktop companion bridge for desktop window surfaces

- What it is:
  a companion process asks picom for X11 window metadata over DBus, tracks
  X11 composite/damage updates, imports textures, creates xrdesktop/gxr/gulkan
  windows, synthesizes input, and accepts stacking/overlay-mode caveats.
- Good for:
  Linux desktop mirroring, compositor-metadata experiments, X11 window
  diagnostics, and xrdesktop integration research.
- Why it matters:
  existing desktop windows can be mirrored when a helper reuses compositor
  knowledge instead of reimplementing every window-manager rule.
- Strong references:
  `picom-xrdesktop-companion`.
- Best fit for `VR-apps-lab`:
  desktop-to-XR bridge caveats and X11 compositor helper architecture.

## Method 342: Godot XR scene-pack utility toolkit with function nodes and reusable scenes

- What it is:
  a Godot addon packages XR interaction as reusable scenes and function nodes:
  gaze pointer, pointer, pickup, pose detector, teleport, movement providers,
  hands, interactables, events, desktop support, effects, rumble, staging, and
  user settings.
- Good for:
  Godot XR prototypes, utility interaction baselines, hand/controller tools,
  locomotion experiments, and scene-composed XR helper apps.
- Why it matters:
  it shows how an engine-side toolkit can make interaction modules explicit and
  swappable without becoming one monolithic sample.
- Strong references:
  `godot-xr-tools`.
- Best fit for `VR-apps-lab`:
  Godot-side utility prototypes and cross-engine interaction module comparison.

## Method 343: Godot XR starter template with action map, vendor dependency, and export feature toggles

- What it is:
  a starter project includes the OpenXR action map, XR toolkit dependency,
  template scenes, project settings, and Android export presets with vendor
  feature flags.
- Good for:
  small Godot XR baselines, repeatable project bring-up, action-map examples,
  and device-feature onboarding.
- Why it matters:
  a useful starter is not just a scene; it also preserves device/export wiring
  that future utilities can forget.
- Strong references:
  `godot-xr-template`.
- Best fit for `VR-apps-lab`:
  minimal Godot XR project baseline notes.

## Method 344: Godot vendor OpenXR extension packaging and export-plugin capability gates

- What it is:
  a Godot GDExtension plugin isolates optional vendor OpenXR extension wrappers,
  editor/project setup helpers, and export plugin toggles for Meta, Pico,
  Lynx, Magic Leap, Android XR, Khronos, and validation targets.
- Good for:
  vendor feature diagnostics, passthrough/depth/anchor experiments, capability
  explorers, and optional runtime feature gating.
- Why it matters:
  device-specific features become tractable when they are explicit optional
  wrappers and export-time gates rather than hidden assumptions.
- Strong references:
  `godot_openxr_vendors`.
- Best fit for `VR-apps-lab`:
  vendor OpenXR capability matrix and setup-checker patterns.

## Method 345: SteamVR/OpenVR backend metadata bridge for Godot utilities

- What it is:
  a Godot OpenVR backend exposes action manifests, action sets, tracking
  universe, play area, skeletons, render model names/loading, device battery,
  and charging state to Godot scripts.
- Good for:
  SteamVR diagnostics, controller/skeleton experiments, battery overlays,
  play-area inspectors, and legacy OpenVR helper tools.
- Why it matters:
  even legacy runtime backends capture practical device metadata that utility
  tools often need.
- Strong references:
  `godot_openvr`.
- Best fit for `VR-apps-lab`:
  SteamVR metadata and OpenVR diagnostic reference design.

## Method 346: Declarative WebXR component registry and primitive system

- What it is:
  a browser XR framework registers components, systems, primitives, and scenes
  so tracked controls, hands, lasers, raycasters, cursors, layers, sound, hit
  tests, stats, screenshots, and XR mode UI can be assembled declaratively.
- Good for:
  browser XR utilities, quick diagnostics, operator panels, input visualizers,
  and prototype spatial UIs.
- Why it matters:
  declarative component registration can make utility experiments faster and
  easier to inspect than low-level WebXR loops alone.
- Strong references:
  `aframe`.
- Best fit for `VR-apps-lab`:
  browser-native XR utility shell patterns.

## Method 347: Embeddable WebXR scene inspector and live component editor

- What it is:
  an inspector injects into a running WebXR scene, discovers entities and
  components, manages cameras, selection, history, shortcuts, component add
  flows, copy/export actions, and a visual scene graph.
- Good for:
  browser XR diagnostics, creator tools, scene debugging, component explorers,
  and live utility editors.
- Why it matters:
  an inspector turns runtime scene state into a product surface, not just a
  hidden developer concern.
- Strong references:
  `aframe-inspector`.
- Best fit for `VR-apps-lab`:
  in-browser and in-headset debug/edit surfaces.

## Method 348: Schema-driven networked entity sync with pluggable WebRTC/WebSocket adapters

- What it is:
  a networked XR scene declares synchronized component schemas while adapter
  classes handle WebRTC, WebSocket, Socket.IO, room membership, occupant state,
  broadcasts, and hand/control event propagation.
- Good for:
  collaborative browser utilities, multi-user diagnostics, shared operator
  panels, and lightweight networked WebXR scenes.
- Why it matters:
  separating schema from transport keeps scene sync reusable across different
  server and peer models.
- Strong references:
  `networked-aframe`.
- Best fit for `VR-apps-lab`:
  browser multi-user utility architecture and WebSocket/WebRTC bridge patterns.

## Method 349: WebXR hand-joint helper API with pinch locomotion and hand UI widgets

- What it is:
  hand tracking components wrap XRHand joints with helper accessors and convert
  pinch events into teleport, drag-move, drag-rotate, finger cursor, and
  fingertip interaction behaviors.
- Good for:
  hand-first UI, wrist/pinch controls, locomotion experiments, accessibility
  input surfaces, and browser XR interaction prototypes.
- Why it matters:
  hand data becomes more reusable when joint math and gesture widgets are
  packaged separately from app logic.
- Strong references:
  `aframe-hand-tracking-controls-extras`.
- Best fit for `VR-apps-lab`:
  hand/wrist UI and browser XR input experiments.

## Method 350: Unreal replicated grip and VR movement authority layer

- What it is:
  an Unreal plugin extends motion-controller and movement components with grip
  replication, per-object grip state, smoothing, late updates, teleport
  handling, socket/drop events, tracking scale, and client authority conflict
  handling.
- Good for:
  multiplayer VR tools, shared manipulation, replicated utility scenes, network
  interaction experiments, and grip-heavy prototypes.
- Why it matters:
  networked VR interactions need explicit authority and replication rules; they
  cannot be treated like ordinary object transforms.
- Strong references:
  `VRExpansionPlugin`.
- Best fit for `VR-apps-lab`:
  Unreal interaction donor comparison and replicated manipulation notes.

## Method 351: Unreal MR UX primitives with hand tracking, near/far input, and simulation

- What it is:
  an Unreal MR toolkit separates hand tracker interfaces, default hand tracking,
  XR simulation, near/far pointers, pressable controls, sliders, bounds,
  manipulators, menus, finger cursors, surface magnetism, and touchable volumes.
- Good for:
  spatial UI, hand menus, utility panels, manipulation tools, guided setup,
  and near/far input prototypes.
- Why it matters:
  robust MR UX depends on reusable input and control primitives, not only on
  controller pose callbacks.
- Strong references:
  `MixedReality-UXTools-Unreal`.
- Best fit for `VR-apps-lab`:
  cross-engine spatial UI primitive synthesis.

## Method 352: VR comfort tunnelling preset and mask component system

- What it is:
  a VR comfort plugin packages vignette/tunnelling modes, skybox/cubemap,
  windows, blur, masks, world-space portals, mobile variants, materials, and
  presets as configurable runtime comfort effects.
- Good for:
  locomotion comfort, accessibility options, simulator sickness mitigation,
  user settings, and visual safety research.
- Why it matters:
  comfort is a user-facing product system and should be tunable, not hidden as
  a single hardcoded shader.
- Strong references:
  `VrTunnellingPro-UE4`.
- Best fit for `VR-apps-lab`:
  comfort settings and accessibility reference patterns.

## Method 353: OpenXR hand tracking adapter with pinch-as-input and smoothed hand ray

- What it is:
  a compact Unreal adapter reads OpenXR hand/skeleton data, renders hands with
  instanced meshes, detects pinch, registers Enhanced Input actions, and
  exposes a smoothed hand ray.
- Good for:
  hand diagnostics, pinch controls, hand-first UI, pointer/ray experiments,
  and compact engine-side input adapters.
- Why it matters:
  a small adapter can turn raw hand tracking into reusable UI events without
  requiring a large interaction framework.
- Strong references:
  `FSOpenXRHandTracking`.
- Best fit for `VR-apps-lab`:
  hand tracking input adapter patterns.

## Method 354: OpenXR tracker-role-to-motion-source bridge

- What it is:
  an Unreal OpenXR extension plugin enables a tracker interaction extension,
  enumerates runtime tracker role paths, and maps them into engine motion
  source names such as chest, waist, feet, elbows, knees, shoulders, camera, or
  handheld.
- Good for:
  tracker diagnostics, custom-device plumbing, body tracker tools, runtime role
  inspectors, and motion-source bridge experiments.
- Why it matters:
  tracker roles become useful to engine code only when extension paths are
  converted into stable application-facing input names.
- Strong references:
  `UE4OpenXRViveTrackerPlugin`.
- Best fit for `VR-apps-lab`:
  tracker inventory and OpenXR extension bridge research.

## Method 355: VR teleop headset frontend plus desktop IK and UDP robot relay

- What it is:
  a headset web app streams hand/controller tracking and joystick state through
  WebSocket, while a desktop sidecar performs IK and sends JSON/UDP command
  packets to a robot or policy interface.
- Good for:
  operator panels, robot teleop references, pose stream utilities, WebXR
  control surfaces, and low-latency diagnostics.
- Why it matters:
  it separates headset UX from control computation and from robot command
  transport, making each layer inspectable and replaceable.
- Strong references:
  `kbot_vr_teleop`.
- Best fit for `VR-apps-lab`:
  generic VR control-surface architecture.

## Method 356: Headset-free OpenVR controller-pose to robot-command bridge

- What it is:
  a SteamVR/OpenVR bridge uses a null-driver/no-HMD setup and a tracked
  controller to generate 6DoF pose deltas, button/trigger gripper actions,
  haptics, IK targets, and robot command modes.
- Good for:
  headsetless labs, hardware-light input testing, controller diagnostics,
  custom control rigs, and no-HMD workflows.
- Why it matters:
  a tracked controller can be a useful VR input device even when no visual
  headset surface is needed.
- Strong references:
  `xarm_vr_teleop`.
- Best fit for `VR-apps-lab`:
  no-HMD control surfaces and OpenVR device input bridges.

## Method 357: Simulation VR teleop loop with MPC, reset callbacks, and demonstration replay

- What it is:
  an Isaac Sim/OpenXR stack links VR controller follower frames, button
  managers, robot IK/MPC goals, gripper/reset callbacks, world-state logging,
  environment randomization, and replay of recorded demonstration states.
- Good for:
  simulation telemetry, robot-learning demos, training data, replay tools,
  synthetic task environments, and VR-controlled simulation utilities.
- Why it matters:
  simulation teleop shows how operator input, physics, planning, reset, and
  replay can live in one inspectable loop.
- Strong references:
  `collab-sim`.
- Best fit for `VR-apps-lab`:
  simulation telemetry and demonstration replay references.

## Method 358: Teleop pause, recenter, smoothing, watchdog, and workspace safety gates

- What it is:
  a teleop control loop captures neutral pose, applies smoothed relative deltas,
  pauses on user gesture or connection loss, recenters on resume, clamps
  workspace bounds or delta radius, and falls back to safe stop/home behavior.
- Good for:
  any VR control surface, robot teleop, simulator control, camera rigs,
  physical-space utilities, and safety-critical operator workflows.
- Why it matters:
  pause/recenter/watchdog controls are core interaction design for any VR tool
  that controls external state.
- Strong references:
  `franka-vr-teleop`, `cambot`, `UR_VR_Teleop`.
- Best fit for `VR-apps-lab`:
  operator safety UX and reusable control-loop guardrails.

## Method 359: VR teleop diagnostics sidecar and synchronized data-capture loop

- What it is:
  a teleop system mirrors commands to a visualizer, logs command/pose/robot
  state, captures RGB/depth/video streams, records episodes, supports save/reset
  buttons, and can replay demonstrations for debugging or learning.
- Good for:
  diagnostics dashboards, robot-learning datasets, simulation replay,
  synchronized capture, and operator training tools.
- Why it matters:
  external-state utilities need observability and capture from the start, not
  only after the control loop works.
- Strong references:
  `kbot_vr_teleop`, `collab-sim`, `UR_VR_Teleop`.
- Best fit for `VR-apps-lab`:
  VR utility observability and data-capture pattern library.

## Method 360: Platform-specific streaming client shell with event watchdog and render/decoder split

- What it is:
  a headset streaming client separates entry/settings UI, immersive-space
  selection, renderer backend, video decoder setup, tracking/world state,
  outgoing workers, event watchdogs, and performance overlay.
- Good for:
  standalone-headset clients, remote display tools, streaming sidecars,
  platform bring-up, and immersive utility shells.
- Why it matters:
  platform client work stays maintainable when lifecycle, decoding, rendering,
  tracking, and diagnostics are explicit boundaries.
- Strong references:
  `alvr-visionos`.
- Best fit for `VR-apps-lab`:
  standalone client architecture and streaming-side utility references.

## Method 361: Prefix-dispatched eye and face payload adapter into a unified expression model

- What it is:
  a tracking adapter reads a float stream, dispatches fixed prefixes to
  vendor-specific eye/face parsers, normalizes eye quaternions or blendshape
  arrays, and writes one unified expression/eye data model.
- Good for:
  face-tracking modules, avatar adapters, vendor payload bridges, runtime
  translation tools, and diagnostics for expression data.
- Why it matters:
  vendor-specific tracking data becomes reusable only when translated into
  stable app-facing expression names and weights.
- Strong references:
  `VRCFT-ALVR`.
- Best fit for `VR-apps-lab`:
  face-tracking adapter and expression-schema research.

## Method 362: Streaming setup helper with dependency discovery, device monitor, and port-forward repair

- What it is:
  a micro-utility locates or downloads a required setup tool, starts its
  service, monitors connected HMD devices, applies required port forwards, and
  prints skipped/success status per device.
- Good for:
  runtime setup doctors, wired streaming helpers, device-connection repair,
  onboarding tools, and support utilities.
- Why it matters:
  many VR workflow failures are setup-state failures; a tiny repair utility can
  remove more friction than a larger feature.
- Strong references:
  `ADBForwarder`.
- Best fit for `VR-apps-lab`:
  setup-doctor and runtime-connectivity helper patterns.

## Method 363: Browser WebHID XR-glasses protocol workbench and packet logger

- What it is:
  a browser utility requests HID devices, filters XR-glasses product families,
  wraps command/report calls, parses input reports, polls IMU data, records
  packet lengths/status distributions, and exposes firmware/protocol actions.
- Good for:
  hardware diagnostics, protocol exploration, community device support,
  browser-native tooling, and safe capability probes.
- Why it matters:
  browser WebHID can make hardware protocols inspectable without a native app,
  as long as risky firmware paths are clearly separated.
- Strong references:
  `xreal-webxr`.
- Best fit for `VR-apps-lab`:
  device protocol workbenches and lightweight diagnostics.

## Method 364: Head-tracked virtual display canvas with IMU recenter, smoothing, and viewport crop

- What it is:
  a desktop helper creates a large virtual display canvas, captures or mirrors
  it, reads XR-glasses IMU orientation, recenters the quaternion, applies dead
  zones and EMA smoothing, maps yaw/pitch into viewport offsets, and crops the
  visible output.
- Good for:
  XR-glasses desktop utilities, virtual monitor tools, head-tracked reference
  screens, menu-bar helpers, and spatial workstation experiments.
- Why it matters:
  a head-tracked screen can be built as a focused viewport utility without a
  full spatial desktop runtime.
- Strong references:
  `XReal-Ultrawide`.
- Best fit for `VR-apps-lab`:
  virtual display and head-tracked desktop helper research.

## Method 365: Screen-capture plus gaze-calibrated viewport slicing for XR glasses

- What it is:
  an early desktop POC captures a multi-monitor framebuffer, asks the user to
  look at reference points, normalizes yaw, and slices/blends monitor regions
  into a glasses output window.
- Good for:
  rapid spatial-desktop experiments, calibration prototypes, display-surface
  tests, and throwaway AR workspace sketches.
- Why it matters:
  crude capture/crop prototypes can validate head-tracked display UX before
  committing to a compositor or driver.
- Strong references:
  `nreal_linux_test`.
- Best fit for `VR-apps-lab`:
  fast display-surface experiments and calibration-flow references.

## Method 366: MediaPipe landmark-to-virtual-tracker bridge with axis construction and SlimeVR UDP

- What it is:
  a camera bridge runs MediaPipe pose, derives body-segment axes from selected
  landmarks, converts axes to quaternions, smooths pose and calibration
  quaternions, and emits SlimeVR-style UDP handshake/heartbeat/rotation
  packets for multiple virtual trackers.
- Good for:
  camera-based tracking experiments, tracker bridge diagnostics, calibration
  research, and virtual-device proof-of-concepts.
- Why it matters:
  the reusable part of camera tracking is often the conversion pipeline from
  landmarks to stable tracker payloads.
- Strong references:
  `SlimeVR-Tracker-Mediapipe`.
- Best fit for `VR-apps-lab`:
  tracker bridge and camera calibration pattern library.

## Method 367: Webcam face/blendshape bridge into avatar expression parameters

- What it is:
  a small app runs a webcam face model, reads blendshape or face-landmarker
  outputs, maps them into avatar-facing parameters, and sends or previews the
  resulting expression data.
- Good for:
  avatar diagnostics, face-tracking sidecars, VRChat/VRM preview tools,
  expression calibration, and low-cost accessibility experiments.
- Why it matters:
  avatar-facing tools benefit from a clear expression mapping layer between
  model-specific coefficients and user-facing blendshape names.
- Strong references:
  `MediapipeFaceTracking_VRC`, `mediapipe-vrm-tracking`.
- Best fit for `VR-apps-lab`:
  face-tracking adapters and avatar preview utilities.

## Method 368: Minimal landmark-to-controller OSC proof

- What it is:
  a tiny bridge tracks one MediaPipe hand landmark, maps it into a simple pose
  payload, and sends it through OSC to a virtual motion tracker/controller
  endpoint.
- Good for:
  transport proofs, teaching examples, quick experiments, and validating
  target schemas before building full tracking.
- Why it matters:
  the smallest possible bridge can test integration assumptions before a
  complicated tracking model exists.
- Strong references:
  `mediapipe_VR_controller`.
- Best fit for `VR-apps-lab`:
  micro-bridge prototypes and OSC schema experiments.

## Method 369: WebXR mixed-reality capture compositor with calibration JSON and foreground/background render targets

- What it is:
  a browser MRC module defines camera calibration, chroma-key settings, and
  frame delay as JSON, captures webcam video, renders virtual background and
  foreground into delayed render targets, places the keyed webcam layer between
  them, and outputs a composited scene for recording.
- Good for:
  WebXR capture, presenter tools, calibration wizards, OBS/browser handoff,
  and scene-debug recording.
- Why it matters:
  MRC becomes reusable when camera calibration, chroma key, delay, and layer
  split are first-class objects.
- Strong references:
  `reality-mixer-js`.
- Best fit for `VR-apps-lab`:
  capture/compositing utilities and calibration flow references.

## Method 370: Mobile-camera headset capture stack with image tracking, payload protocol, renderer, and encoder

- What it is:
  a capture stack pairs a headset app with a mobile camera companion, uses
  image tracking or ARKit data to locate the camera, sends typed payloads for
  camera pose/buttons/video, renders foreground/background headset passes,
  extracts alpha, packs textures, and encodes video frames.
- Good for:
  presenter capture, mobile-camera MR workflows, headset diagnostics,
  streaming capture tools, and cross-device calibration experiments.
- Why it matters:
  real camera capture is a distributed system; pose, protocol, rendering, and
  encoding need clean boundaries.
- Strong references:
  `RealityMixerVisionPro`.
- Best fit for `VR-apps-lab`:
  mixed-reality capture architecture and cross-device utility design.

## Method 371: Unity/Oculus MRC external-camera repair helpers

- What it is:
  Unity helper scripts update Oculus MRC external camera intrinsics/extrinsics,
  convert camera pose into tracking-space-relative pose, handle Quest tracking
  origin differences, and repeatedly remove unwanted tracked-pose drivers from
  generated MRC cameras.
- Good for:
  creator capture setup, Unity XR Interaction Toolkit projects, MRC diagnostics,
  external-camera calibration, and capture reliability helpers.
- Why it matters:
  capture bugs are often caused by runtime-created cameras and incorrect
  tracking assumptions; small repair scripts can make the workflow usable.
- Strong references:
  `MrcXrtHelpers`.
- Best fit for `VR-apps-lab`:
  creator-facing capture setup and diagnostics patterns.

## Method 372: Browser person-segmentation fallback for artificial green-screen capture

- What it is:
  a browser capture helper uses a person-segmentation model to generate a mask
  from webcam input, draws the masked output to canvas, and can feed
  OBS/compositing workflows without a physical green screen.
- Good for:
  presenter capture, accessibility to MRC workflows, quick demos, browser
  compositor experiments, and setup-light recording tools.
- Why it matters:
  capture utilities should include fallback paths for users who do not have a
  calibrated studio or physical chroma screen.
- Strong references:
  `ArtificialGreenScreen`.
- Best fit for `VR-apps-lab`:
  capture helper and presenter-compositing fallback research.

## Method 373: Mouse-delta locomotion bridge with virtual gamepad output and readiness checks

- What it is:
  a host-side bridge captures relative mouse movement, recenters or accumulates
  deltas, applies sensitivity, decay, deadzone, and clamp rules, then emits a
  virtual gamepad stick value while exposing driver readiness, settings, status,
  and cleanup reset behavior.
- Good for:
  locomotion adapters, accessibility input experiments, simulator control,
  treadmill prototypes, and thin controller-emulation utilities.
- Why it matters:
  small input bridges become usable products when device/driver readiness and
  safe reset are treated as first-class UX.
- Strong references:
  `VR-Treadmill`, `vr-treadmill`.
- Best fit for `VR-apps-lab`:
  virtual-controller bridge and setup-doctor patterns.

## Method 374: Sensor-to-serial-to-OpenVR scalar controller driver

- What it is:
  a hardware sensor module sends normalized serial values, a host capture layer
  discovers and reconnects to the serial device, and an OpenVR server driver
  exposes those values as controller scalar input components.
- Good for:
  DIY hardware adapters, treadmills, pedals, pressure plates, accessibility
  controls, and runtime input experiments.
- Why it matters:
  many physical inputs do not need full pose; scalar components with stable
  action paths can be enough.
- Strong references:
  `slimstep_vr`.
- Best fit for `VR-apps-lab`:
  custom-device and virtual-controller plumbing references.

## Method 375: Hardware locomotion state classifier with keyboard or virtual joystick output

- What it is:
  a balance-board or treadmill adapter reads raw axes, normalizes values,
  classifies standing, walking, one-foot stance, jump, or absence using
  thresholds and hold timers, then outputs keyboard or virtual joystick events.
- Good for:
  walk-in-place utilities, accessibility controls, quick locomotion adapters,
  low-cost hardware experiments, and state-debug panels.
- Why it matters:
  locomotion hardware needs a user-state model before it needs complicated
  runtime integration.
- Strong references:
  `GoobleBoxVR`.
- Best fit for `VR-apps-lab`:
  hardware input and accessibility bridge research.

## Method 376: BLE/TCP command-status relay for external VR hardware

- What it is:
  a headset, desktop, or firmware component exposes small control/status
  messages over BLE or TCP, separates command writes from status notifications,
  resets on disconnect, and keeps the payload small enough for reliable
  hardware control.
- Good for:
  treadmill control, accessory bridges, device monitors, simulator sidecars,
  and hardware diagnostics.
- Why it matters:
  external VR utilities often fail at transport boundaries; small explicit
  command/status protocols are easier to debug.
- Strong references:
  `VR-treadmill-client-app`, `VR-treadmill-server-app`,
  `kittywalk-server`.
- Best fit for `VR-apps-lab`:
  external-device bridge and transport-probe patterns.

## Method 377: Session-block-trial harness with trackers and data handlers

- What it is:
  a VR utility or study defines a session, blocks, trials, settings,
  participant/context metadata, trackers, lifecycle events, and data handlers
  for tables, JSON, text, and bytes.
- Good for:
  calibration studies, diagnostics, training flows, repeatable user tests,
  tracker logging, and guided setup utilities.
- Why it matters:
  repeatable VR tools need provenance and output structure, not only scene
  scripts.
- Strong references:
  `unity-experiment-framework`.
- Best fit for `VR-apps-lab`:
  guided diagnostics and calibration data-capture harnesses.

## Method 378: Editor-authored experiment design with runtime runner and output events

- What it is:
  design assets define repetitions, variables, randomization, control settings,
  and GUI behavior, while a runtime runner loads the design, builds trial
  tables, instantiates custom experiment logic, and emits output through an
  event-driven manager.
- Good for:
  operator workflows, training graphs, non-programmer-authored test flows,
  study builders, and reusable setup scenes.
- Why it matters:
  authoring-time and runtime responsibilities should be explicit when a VR tool
  grows beyond a single scene.
- Strong references:
  `TUX`.
- Best fit for `VR-apps-lab`:
  workflow authoring and guided utility design.

## Method 379: Settings-driven VR task generator with pseudo-randomization and resume

- What it is:
  a task generator reads JSON or framework settings, interprets naming
  conventions for per-block values, pseudo-randomizes linked variables,
  creates blocks/trials, serializes settings, and resumes progress from local
  state.
- Good for:
  calibration sequences, training tasks, device validation, repeated
  diagnostics, and structured user studies.
- Why it matters:
  robust setup tools often need the same repeatable sequence and resume logic
  as experiments.
- Strong references:
  `vr_experiment_framework_v3`, `Unity-Experiment-Trial-Manager`.
- Best fit for `VR-apps-lab`:
  repeatable diagnostic and calibration workflows.

## Method 380: Remote settings, local fallback, and upload sidecars for VR sessions

- What it is:
  session setup downloads settings from a remote source, caches or falls back
  to local settings, records release/device metadata, and attaches upload
  behavior as a sidecar to file-write events.
- Good for:
  field-deployed diagnostics, research apps, operator tools, offline-capable
  utilities, and data-capture pipelines.
- Why it matters:
  VR utilities used outside development machines need reliable configuration
  and output transport.
- Strong references:
  `uxf-web-settings`, `uxf-s3-uploader`.
- Best fit for `VR-apps-lab`:
  deployment-friendly tool harnesses.

## Method 381: Standalone immersive browser shell with session, window, widget, and native-world split

- What it is:
  a headset browser separates host activity/bootstrap, browser runtime
  sessions, windows/tabs, panels, widgets, keyboard/navigation/tray surfaces,
  environment management, and native render-world placement/controllers.
- Good for:
  browser-backed utility shells, in-headset dashboards, spatial web tools,
  multi-window references, and large-scale UI architecture studies.
- Why it matters:
  even small utilities can borrow the boundary discipline of mature immersive
  browsers without copying their whole codebase.
- Strong references:
  `wolvic`, `FirefoxReality`.
- Best fit for `VR-apps-lab`:
  browser-backed shell and window/widget architecture references.

## Method 382: WebXR interstitial and immersive-mode escape surface

- What it is:
  a browser shell creates a dedicated in-scene interstitial or widget layer for
  WebXR permission, transition, and exit affordances, with placement rules for
  controllers, hands, and scene state.
- Good for:
  browser VR utilities, WebXR hosts, immersive media players, and safety/escape
  UX.
- Why it matters:
  immersive sessions need reliable exit and permission surfaces that do not
  disappear into the content being displayed.
- Strong references:
  `wolvic`, `FirefoxReality`.
- Best fit for `VR-apps-lab`:
  browser utility UX and WebXR safety patterns.

## Method 383: JavaScript WebXR runtime shim with explicit session, input, layer, and extension state

- What it is:
  a JS runtime models `navigator.xr`, `XRSession`, animation frames, session
  end/select events, gamepad/hand/eye input sources, layers, and optional
  extension-like features as inspectable objects.
- Good for:
  WebXR tooling, emulators, synthetic sessions, test harnesses, browser-native
  utility shells, and educational runtimes.
- Why it matters:
  WebXR becomes easier to test and reason about when session and input state are
  explicit boundaries.
- Strong references:
  `exokit`.
- Best fit for `VR-apps-lab`:
  browser XR runtime and synthetic-session research.

## Method 384: Controller-aware WebXR creative tool with brush feedback, tooltips, and save/load/share

- What it is:
  a WebXR creative utility maps multiple controller families to tool actions,
  visualizes brush/tool state at the controller tip, fades instructional
  tooltips after use, and treats save/load/import/upload/share as core
  workflow.
- Good for:
  browser-native creation tools, annotation surfaces, sketching utilities,
  teaching demos, and shareable VR workspaces.
- Why it matters:
  input mapping and persistence are what turn a WebXR demo into a tool.
- Strong references:
  `a-painter`.
- Best fit for `VR-apps-lab`:
  browser-native utility UX and controller mapping references.

## Method 385: Palm or secondary-hand contextual tool menu with hold/release activation

- What it is:
  a WebXR tool tracks controller and hand state, identifies main and secondary
  hands, places a camera-facing or palm-facing tool menu, uses hover/pressed/
  held/active colors, and activates tools on release after a deliberate hold.
- Good for:
  hand-first utilities, CAD/sketch tools, diagnostics panels, quick actions,
  and VR menu experiments.
- Why it matters:
  hand menus need intentional activation timing and context visibility to avoid
  accidental input.
- Strong references:
  `LeapShape`.
- Best fit for `VR-apps-lab`:
  hand, wrist, and palm UI pattern library.

## Method 386: Browser-native XR diagnostic, media, and data visualization surface

- What it is:
  a WebXR utility uses Three.js or React Three Fiber to render focused
  information surfaces such as per-eye stereo media, screen test patterns,
  audio-reactive spheres, biometric point clouds, or data dashboards with gaze,
  pinch, and canvas-texture detail panels.
- Good for:
  headset diagnostics, media viewers, telemetry dashboards, biometric
  visualization, quick WebXR prototypes, and browser-native operator surfaces.
- Why it matters:
  many VR utility ideas do not need native overlays; a deployable WebXR page can
  validate the value quickly.
- Strong references:
  `spatial-photo-webxr-viewer`, `vr-screen-tester`, `vr-visualizer-web`,
  `OpenBCI-WebXR-EEG`, `prediction-space`.
- Best fit for `VR-apps-lab`:
  WebXR utility-surface prototypes and data/diagnostics visualization.

## Method 387: Managed ADB and platform-tools bootstrap for headset companions

- What it is:
  a companion utility detects or downloads platform tools, validates ADB
  version, avoids taking over another app's ADB server when possible, discovers
  devices, grants needed permissions, hashes packages, and reports install
  progress.
- Good for:
  Quest companion apps, sideloading tools, package inventory, app install
  helpers, device diagnostics, and support tooling.
- Why it matters:
  ADB lifecycle bugs are support disasters; making ADB ownership explicit makes
  headset utilities safer.
- Strong references:
  `SideQuest`, `QuestPatcher`, `QuestAppVersionSwitcher`.
- Best fit for `VR-apps-lab`:
  Quest ADB doctor and device companion utilities.

## Method 388: Schema-first Quest mod package and staged APK patch workflow

- What it is:
  a tool validates mod packages with a formal schema, creates device-side mod
  directories, patches APK binary manifests and native libraries in named
  stages, signs/rebuilds artifacts, and persists installed mod status.
- Good for:
  mod managers, patchers, plugin/package validators, controlled app
  modification tools, and migration checkers.
- Why it matters:
  patching should be inspectable and reversible enough for users to understand
  risk.
- Strong references:
  `QuestPatcher`, `QuestPatcher.QMod`.
- Best fit for `VR-apps-lab`:
  package validation and safe patching research.

## Method 389: Quest app backup, version metadata, and downgrade state manager

- What it is:
  a utility records backup metadata for APKs, app data, OBBs, package version,
  patch state, corruption status, size, source, and store metadata, then uses
  that state to drive restore/downgrade/version switching flows.
- Good for:
  headset app managers, backup/restore tools, version switchers, metadata
  viewers, and migration utilities.
- Why it matters:
  device operations need durable state and provenance, not just one-off shell
  commands.
- Strong references:
  `QuestAppVersionSwitcher`, `OculusDB`.
- Best fit for `VR-apps-lab`:
  package inventory and backup/version companion concepts.

## Method 390: Role-based OSC pose stream protocol for avatars and tracking helpers

- What it is:
  an OSC/UDP protocol defines roles, default ports, and typed messages for
  root, bone, tracker, HMD, controller, camera, blendshape, status, time, and
  calibration data, while receivers tolerate partial implementation.
- Good for:
  avatar motion bridges, tracker helpers, diagnostics, teleoperation pose
  streams, replay tools, and headset transform senders.
- Why it matters:
  pose interoperability improves when message ownership, roles, and tolerance
  rules are documented.
- Strong references:
  `VirtualMotionCaptureProtocol`, `VirtualMotionCapture`,
  `QuestOSCTransformSender`.
- Best fit for `VR-apps-lab`:
  pose-stream bridge and diagnostics references.

## Method 391: Unity VMC receiver with filters, cutoffs, packet limiting, and daisy-chain

- What it is:
  a Unity component receives OSC pose messages, applies root/bone/blendshape
  state to VRM models, exposes freeze/late-update/filter/cutoff/calibration
  options, limits dropped packets, validates communication state, and forwards
  messages through receiver chains.
- Good for:
  VRM apps, pose diagnostics, recording tools, avatar previewers, bridge
  adapters, and motion stream visualizers.
- Why it matters:
  production pose receivers need user controls for failure modes, not only
  transform assignment.
- Strong references:
  `EasyVirtualMotionCaptureForUnity`.
- Best fit for `VR-apps-lab`:
  Unity pose receiver and avatar diagnostic prototypes.

## Method 392: Motion stream recorder/exporter with calibration gate and typed log

- What it is:
  a utility starts recording only after load/calibration state, maps humanoid
  bones, samples at a target FPS, records root/bone/blendshape deltas, and
  writes either offline animation formats such as BVH or typed binary logs for
  replay/debugging.
- Good for:
  mocap capture, diagnostics, regression tests, pose replay, exporter tools,
  and bridge troubleshooting.
- Why it matters:
  live motion streams become reusable engineering artifacts only after they can
  be recorded, validated, and replayed.
- Strong references:
  `vmc2bvh`, `vmcrec`.
- Best fit for `VR-apps-lab`:
  pose-stream capture and replay helpers.

## Method 393: Social VR mod loader with config, duplicate checks, lifecycle, and conflict diagnostics

- What it is:
  a loader discovers mod assemblies, enforces one mod entry point, logs hashes,
  loads versioned per-mod config, detects duplicate names, exposes lifecycle
  hooks, handles reflection load failures, detects headless mode, and reports
  patch conflicts.
- Good for:
  plugin systems, mod loaders, extension frameworks, creator tooling, and
  diagnostics-heavy utility ecosystems.
- Why it matters:
  mod ecosystems need governance and failure reporting before they need more
  features.
- Strong references:
  `ResoniteModLoader`.
- Best fit for `VR-apps-lab`:
  plugin/mod architecture and support-boundary patterns.

## Method 394: Manifest-backed mod manager with cache, hashes, dependencies, and installed-state reconciliation

- What it is:
  a community manifest stores categories, platforms, dependencies, conflicts,
  artifact URLs, SHA256 hashes, and install locations, while a GUI/CLI manager
  caches the manifest, falls back on stale cache, downloads artifacts, updates
  installed state, and reconciles unrecognized files.
- Good for:
  plugin managers, package catalogs, updater tools, versioned extensions, and
  public utility ecosystems.
- Why it matters:
  reusable VR utilities need trust metadata and state reconciliation, not just
  download buttons.
- Strong references:
  `resonite-mod-manifest`, `Resolute`, `QuestPatcher.QMod`.
- Best fit for `VR-apps-lab`:
  schema-first package and plugin manager references.

## Method 395: External social VR data-model SDK with WebSocket command/response and REPL

- What it is:
  an SDK connects to a social VR session over WebSocket, serializes typed
  commands with message IDs, maps pending responses, supports binary payloads,
  exposes slot/component/asset/reflection/method/batch operations, and provides
  a REPL for exploration.
- Good for:
  external automation, diagnostics, world inspection, asset import tools,
  operator panels, and integration bridges.
- Why it matters:
  external control surfaces are much easier to debug when command/response
  IDs and reflection APIs are explicit.
- Strong references:
  `ResoniteLink`.
- Best fit for `VR-apps-lab`:
  external control and inspection bridge design.

## Method 396: Social VR companion client with cached auth and reconnecting live-event hub

- What it is:
  a companion app stores credentials/tokens securely, supports cached login and
  session extension, wraps HTTP APIs, handles status-specific errors, and keeps
  a reconnecting WebSocket or SignalR-like hub for contacts, sessions,
  messages, inventory, and notifications.
- Good for:
  social VR companion apps, operator dashboards, messaging sidecars, inventory
  browsers, and session monitors.
- Why it matters:
  headset-adjacent tools often need reliable social state outside the headset.
- Strong references:
  `ReCon`.
- Best fit for `VR-apps-lab`:
  companion app architecture references.

## Method 397: In-world creator metrics counter with focused filters and exportable traces

- What it is:
  a mod collects per-element and per-object-root timings by world stage,
  filters unfocused/local/removed/blacklisted elements, supports ignored
  hierarchies, updates frame counts, writes JSON traces, and exposes hierarchy
  or detail UI panels in-world.
- Good for:
  creator diagnostics, performance profiling, world debugging, optimization
  helpers, and in-world developer panels.
- Why it matters:
  diagnostics are more useful when creators can see and export them from the
  environment where problems happen.
- Strong references:
  `ResoniteMetricsCounter`.
- Best fit for `VR-apps-lab`:
  creator diagnostics and in-world metrics utility patterns.

## Method 398: DIY headset OpenVR HMD driver with HID pose ingestion and display component settings

- What it is:
  a driver exposes an OpenVR HMD provider/display component, reads firmware
  packets through HID or other transports, updates pose in runtime callbacks,
  and maps display geometry, render target, IPD, FOV, distortion, direct/desktop
  mode, and device properties from settings.
- Good for:
  DIY HMDs, virtual display research, hardware diagnostics, driver learning
  paths, and synthetic headset prototypes.
- Why it matters:
  the hardware-to-runtime path is easier to study when firmware, settings, and
  display component responsibilities are separated.
- Strong references:
  `Relativty`, `HadesVR`.
- Best fit for `VR-apps-lab`:
  OpenVR driver bring-up references.

## Method 399: Firmware packet demux for HMD, controller, tracker, battery, and finger data

- What it is:
  firmware and drivers agree on compact packet structures for HMD raw IMU or
  quaternion data, controller quaternions, accelerometers, buttons, trigger,
  joystick, trackpad emulation, battery, fingers, grip, and tracker payloads,
  then demultiplex those packets by packet ID in the driver.
- Good for:
  DIY controllers, trackers, headset firmware, hardware bridge diagnostics,
  and virtual-device adapters.
- Why it matters:
  packet structure is the contract that decides whether hardware support is
  debuggable.
- Strong references:
  `HadesVR`, `Wand-Controller`, `DIY_VR_Controllers`.
- Best fit for `VR-apps-lab`:
  firmware transport and virtual device mapping research.

## Method 400: VR driver settings editor with typed schema and ordered JSON output

- What it is:
  a GUI editor loads default driver settings, reads a target settings file,
  maps typed category/key values, exposes panes for driver/display/HMD/
  controller/tracker settings, and writes ordered JSON so users can still
  inspect diffs by hand.
- Good for:
  driver support tools, hardware calibration, display tuning, user setup
  panels, and diagnostics companions.
- Why it matters:
  complex VR driver settings are a UX surface; without an editor they become a
  hidden support burden.
- Strong references:
  `HadesVR_GUI_Tool`.
- Best fit for `VR-apps-lab`:
  driver settings, calibration, and support tooling patterns.

## Method 401: Promise-returning modal VR keyboard service

- What it is:
  a VR scene calls a keyboard service with config, the keyboard fades in as a
  modal surface, captures text/emoji/dictation, resolves a promise or callback,
  and then restores the scene to normal flow.
- Good for:
  WebXR/WebVR utilities, search boxes, notes, chat surfaces, setup forms, and
  headset-friendly command entry.
- Why it matters:
  text entry is easier to reuse when treated as a service boundary instead of
  a component every scene reimplements.
- Strong references:
  `react-360-keyboard`.
- Best fit for `VR-apps-lab`:
  reusable VR text-entry service patterns.

## Method 402: Canvas-texture raycast keyboard with target-field binding

- What it is:
  a keyboard renders its layout to a canvas texture, raycasts pointer hits into
  key rectangles, dispatches key events, switches layouts, and writes values
  into the currently focused target field.
- Good for:
  browser-native WebXR tools, lightweight diagnostics, in-scene forms, and
  no-native-overlay text entry.
- Why it matters:
  browser XR utilities need a portable fallback when platform keyboards are
  unavailable or inconsistent.
- Strong references:
  `vr-keyboard`.
- Best fit for `VR-apps-lab`:
  browser-native keyboard and menu/input prototypes.

## Method 403: Fingertip push-depth keyboard and physical button activation

- What it is:
  a key tracks fingertip colliders, chirality/finger filters, approach
  orientation, furthest push point, throw distance, hover/activate events, and
  debounce state before accepting a press.
- Good for:
  hand-tracked keyboards, near-field menus, tactile control panels, cockpit
  switches, and training interfaces.
- Why it matters:
  physical-feeling VR UI needs depth and orientation gates, not only collider
  enter/exit events.
- Strong references:
  `VRKeyboard`.
- Best fit for `VR-apps-lab`:
  near-field interaction and hand UI comparison work.

## Method 404: Native OpenVR keyboard bridge for host scripts or mod environments

- What it is:
  a native helper creates an OpenVR overlay, calls `ShowKeyboardForOverlay`,
  polls keyboard events, reads text through `GetKeyboardText`, and exposes a
  small polling API to the host script layer with desktop/non-VR fallback.
- Good for:
  SteamVR overlays, game mods, script hosts, configuration panels, and
  environments that do not have reliable text input.
- Why it matters:
  many VR utility hosts are not full engines; a thin native keyboard bridge can
  unlock text entry without rewriting the host.
- Strong references:
  `VR_Keyboard`.
- Best fit for `VR-apps-lab`:
  OpenVR text-entry bridge and mod-host utility research.

## Method 405: OSC input emitter with explicit transient reset cadence

- What it is:
  a companion app maps keyboard/controller state into OSC addresses, sends
  values to a target runtime, then resets transient axes/buttons each evaluation
  tick so movement or look commands do not stick.
- Good for:
  VRChat input helpers, accessibility tools, control sidecars, keyboard-to-OSC
  bridges, and remote control surfaces.
- Why it matters:
  OSC control bridges are safer when stateless/transient behavior is explicit.
- Strong references:
  `VRC-KeyboardController-in-VR_OSC`.
- Best fit for `VR-apps-lab`:
  VRChat OSC bridge and accessibility sidecar patterns.

## Method 406: Queued VR subtitle director with WPM duration and speaker/FOV placement

- What it is:
  subtitles are queued, sorted by priority, assigned duration from text length,
  optionally attached to a speaker or portrait, kept facing or near the user's
  field of view, and faded through lifecycle events.
- Good for:
  accessibility captions, narrative VR, training apps, guided setup, and
  information overlays.
- Why it matters:
  legible VR text is a scheduling and placement problem, not just a UI label.
- Strong references:
  `vr-subtitles`.
- Best fit for `VR-apps-lab`:
  caption/subtitle surfaces and guided diagnostics.

## Method 407: Projection-aware subtitle burn-in for stereo 360 video

- What it is:
  a media helper splits a top-bottom stereo 360 video into eye halves, burns
  identical ASS/SRT subtitles into both halves with geometry-aware size and
  margins, then stacks the halves back together to avoid horizontal disparity.
- Good for:
  immersive video archives, accessibility preprocessing, creator media
  pipelines, and projection-aware playback support.
- Why it matters:
  conventional subtitle burn-in can become uncomfortable in stereo VR if eye
  geometry is ignored.
- Strong references:
  `VR_SUBTITLES_BURNERRR`.
- Best fit for `VR-apps-lab`:
  projection-aware media helper research.

## Method 408: STT/translation overlay fan-out with typed message history and OCR controls

- What it is:
  a local companion coordinates speech recognition, translation, TTS, OCR,
  VR overlays, font fallback, message history, fade/expiration, tracking
  targets, and optional chatbox/OSC output.
- Good for:
  accessibility companions, live translation, speech logs, VRChat chat helpers,
  and in-headset OCR/translation panels.
- Why it matters:
  communication tools need a pipeline and history model, not only a single
  floating text label.
- Strong references:
  `STTS`.
- Best fit for `VR-apps-lab`:
  speech, caption, translation, and OCR companion surfaces.

## Method 409: SteamVR lifecycle script runner with manifest autolaunch and quit handling

- What it is:
  an OpenVR overlay app registers itself with SteamVR, enables autolaunch,
  runs startup scripts when SteamVR attaches, waits for quit events when
  cleanup scripts exist, acknowledges quit, shuts down, and runs stop scripts.
- Good for:
  companion utility orchestration, setup/cleanup automation, lab workflows,
  streaming stacks, and debug tool bundles.
- Why it matters:
  VR support tooling often needs reliable runtime lifecycle hooks more than a
  complex UI.
- Strong references:
  `OpenVRStartup`.
- Best fit for `VR-apps-lab`:
  SteamVR lifecycle helpers and operational support tools.

## Method 410: Frametime/VRAM feedback controller for SteamVR supersampling

- What it is:
  a runtime helper reads compositor frame timing, CPU thresholds, dashboard/app
  state, manual override signals, whitelist/blacklist rules, and optional VRAM
  pressure, then adjusts SteamVR supersampling through settings keys.
- Good for:
  performance helpers, diagnostics, tuning utilities, runtime support tools,
  and adaptive quality experiments.
- Why it matters:
  automatic runtime intervention needs guardrails or it becomes another source
  of user confusion.
- Strong references:
  `OpenVR-Dynamic-Resolution`.
- Best fit for `VR-apps-lab`:
  performance-support and runtime-settings controller research.

## Method 411: Linux VR device-permission inventory as setup-doctor substrate

- What it is:
  a package keeps explicit udev/HID/raw device permission rules for headset,
  controller, tracker, and vendor devices, then uses that inventory as setup
  and troubleshooting ground truth.
- Good for:
  Linux VR setup doctors, runtime installers, hardware diagnostics, distro
  packaging, and support documentation.
- Why it matters:
  many VR failures are device-access failures before they are app bugs.
- Strong references:
  `steam-devices`.
- Best fit for `VR-apps-lab`:
  Linux setup and troubleshooting references.

## Method 412: Proxy-driver vtable wrapper with typed settings/properties and HID control

- What it is:
  a driver proxy wraps only the needed OpenVR interfaces, delegates everything
  else to a real vendor driver, writes typed properties/settings, and controls
  vendor hardware through HID feature reports/config blobs.
- Good for:
  driver research, vendor-support experiments, unsupported headset studies,
  display-mode tooling, and hardware diagnostics.
- Why it matters:
  proxying is powerful but risky; a typed minimal wrapper helps keep the blast
  radius understandable.
- Strong references:
  `VivePro2-Linux-Driver`.
- Best fit for `VR-apps-lab`:
  driver-support research references, not default app development.

## Method 413: Unity SteamVR dashboard overlay with render texture, UI event forwarding, keyboard, and OSC bridge

- What it is:
  a Unity app renders normal UI to a `RenderTexture`, submits it as a SteamVR
  dashboard overlay, maps overlay mouse coordinates into Unity UI raycasts,
  forwards hover/click/keyboard events, handles autolaunch, and bridges actions
  into an external protocol such as OSC.
- Good for:
  SteamVR dashboard utilities, VRChat OSC panels, settings tools, quick action
  tabs, and Unity-authored overlay surfaces.
- Why it matters:
  Unity dashboard overlays are practical when the tool needs rich UI without
  hand-writing native widget rendering.
- Strong references:
  `VRCOSCAvatarScaleOverlay`.
- Best fit for `VR-apps-lab`:
  dashboard overlay prototypes and VRChat utility panels.

## Method 414: OCR-assisted workflow overlay with mirror-texture capture, feedback card, persistence, and action bindings

- What it is:
  a desktop companion owns durable domain state, renders a SteamVR overlay,
  uses action bindings for clicks/haptics, captures compositor mirror textures
  for OCR, shows a head-locked feedback card, and persists settings/state with
  debug artifacts and safety boundaries.
- Good for:
  checklist overlays, inventory helpers, training/task assistants, in-headset
  workflow tools, and anti-cheat-sensitive game companions.
- Why it matters:
  the strongest VR utility pattern is often "read visible pixels, update local
  state, show a trustworthy compact overlay" without touching the game process.
- Strong references:
  `ez-wishlist-overlay`, `VR-QR-Overlay`.
- Best fit for `VR-apps-lab`:
  focused overlay micro-surfaces and OCR workflow-panel research.

## Method 415: Transparent/captured chat window with setup-overlay toggle and persistent click-through controls

- What it is:
  a desktop companion separates setup/configuration mode from live overlay
  mode, persists window/settings state, exposes hotkeys or tray actions, and
  can become click-through or non-interactive while staying visible above other
  content.
- Good for:
  chat panels, reference panels, streamer utilities, Desktop+-captured helper
  windows, and overlay prototypes that are not native OpenVR/OpenXR yet.
- Why it matters:
  many useful VR panels start life as desktop windows; setup/live mode keeps
  them usable without making the always-on overlay annoying.
- Strong references:
  `Transparent-Twitch-Chat-Overlay`, `ghost-chat`.
- Best fit for `VR-apps-lab`:
  captured-window HUDs, audience/chat panels, and companion surfaces.

## Method 416: Query-string configured browser overlay builder with live preview and validated params

- What it is:
  a browser overlay exposes its runtime configuration through URL parameters,
  validates or cleans the parameter set, and provides a form plus live preview
  so users can generate a shareable overlay URL without editing code.
- Good for:
  OBS/browser sources, WebXR panels, stream overlays, diagnostics dashboards,
  and quick prototype surfaces.
- Why it matters:
  a URL is a low-friction configuration contract for public overlays and
  captured browser panels.
- Strong references:
  `showmy.chat`, `jChat`.
- Best fit for `VR-apps-lab`:
  browser-backed overlay configuration and public demo surfaces.

## Method 417: Chat/emote fan-in renderer with provider normalization and animated effects

- What it is:
  an overlay normalizes chat, badges, emotes, and events from multiple
  providers, bounds message/visual lifetime, and renders text or animated
  effects as a controlled visual layer.
- Good for:
  audience overlays, notification surfaces, moderation panels, streamer tools,
  and playful feedback displays.
- Why it matters:
  chat and emote systems become reusable only when provider-specific quirks
  are isolated from rendering.
- Strong references:
  `jChat`, `twitch_chat_emotes`, `ghost-chat`.
- Best fit for `VR-apps-lab`:
  audience-facing VR companion panels and notification overlays.

## Method 418: VR creative tool app-state with catalogs, panel manager, global command surface, and load/export lifecycle

- What it is:
  a complex VR tool organizes itself around explicit app states, catalogs for
  brushes/assets/environments, panel managers, global commands, input hints,
  save/load, export, and external load or automation hooks.
- Good for:
  VR editors, calibration tools, creative utilities, in-headset setup panels,
  and tool-heavy dashboard apps.
- Why it matters:
  complex VR utilities fail when tools, panels, persistence, and commands are
  designed separately.
- Strong references:
  `tilt-brush`, `open-brush`.
- Best fit for `VR-apps-lab`:
  menu/tool systems and editor-like VR utility prototypes.

## Method 419: Componentized browser-native authoring shelves and brush systems

- What it is:
  a WebXR/A-Frame app defines tools as systems/components, loads brush/tool
  packs, and exposes movable shelves with close, pin, hide, popup, grab-root,
  and dynamic sizing behavior.
- Good for:
  browser-native creative tools, WebXR utilities, hand-menu experiments,
  diagnostics surfaces, and lightweight authoring panels.
- Why it matters:
  browser-native VR can build rich tool UIs without copying Unity-style manager
  architecture.
- Strong references:
  `vartiste`.
- Best fit for `VR-apps-lab`:
  WebXR utility surfaces and browser-backed tool shelves.

## Method 420: Command/proto-based VR modeling edit history and multi-format export pipeline

- What it is:
  modeling operations are represented as serializable commands, optionally
  grouped into composites, then connected to export paths such as OBJ, FBX,
  glTF, thumbnails, and asset-service upload.
- Good for:
  VR editors, scene-setup tools, calibration/layout editors, creator utilities,
  and any VR app that needs undo/history and export.
- Why it matters:
  undoable VR editing is easier to reason about when mutations are typed
  commands instead of direct scene changes.
- Strong references:
  `blocks`.
- Best fit for `VR-apps-lab`:
  editor-like utility architecture and exportable configuration workflows.

## Method 421: Research-friendly network scene with room/peer properties and arbitrary component listener

- What it is:
  a small networking substrate provides room server/client lifecycle, peer
  events, WebRTC signaling, avatars or media as optional layers, arbitrary
  network IDs, and statistics for message flow.
- Good for:
  collaborative diagnostics, lab studies, guided setup, remote support,
  multiplayer prototypes, and shared calibration tools.
- Why it matters:
  VR utility collaboration benefits from inspectable network primitives before
  it needs a full social platform.
- Strong references:
  `ubiq`.
- Best fit for `VR-apps-lab`:
  collaborative tool and research-session substrates.

## Method 422: Permissioned WebXR room channel with presence/action events and ECS networked components

- What it is:
  a social WebXR client wraps room communication in a channel with explicit
  permission tokens, presence updates, moderation/actions, media/object events,
  and networked ECS components for ownership and transforms.
- Good for:
  social utility rooms, operator panels, remote support, shared media spaces,
  moderated events, and collaborative dashboards.
- Why it matters:
  multi-user VR utilities need permission and presence design even when they
  are not social products.
- Strong references:
  `hubs`.
- Best fit for `VR-apps-lab`:
  WebXR collaboration, room permission models, and media/object action
  surfaces.

## Method 423: Declarative room snippet and generated viewer for spatial web/media embeds

- What it is:
  a spatial web client generates room snippets or viewer frames for media,
  models, avatars, video, and 360 content, then connects them to room/network
  lifecycle through URL or custom-element parameters.
- Good for:
  media/reference panels, spatial web shells, browser-native room viewers,
  embedded documentation, and lightweight social spaces.
- Why it matters:
  utility panels can embed spatial content without adopting a full world editor
  if the room/viewer contract is declarative.
- Strong references:
  `janusweb`.
- Best fit for `VR-apps-lab`:
  spatial web references and embeddable media/viewer surfaces.

## Method 424: Driver-side hand-input protocol split with UI calibration, protobuf, named-pipe, and OSC ingress

- What it is:
  custom hand-device integration is split into a calibration/control sidecar,
  typed protocol contracts, driver input/output services, named-pipe binary
  ingress, and optional OSC adapters for external tools.
- Good for:
  DIY gloves, custom controllers, accessibility hand inputs, virtual hand
  drivers, and hardware bridge research.
- Why it matters:
  separating UI, protocol, and transport keeps hardware integration debuggable
  and replaceable.
- Strong references:
  `opengloves-ui`, `opengloves-protocol`, `CS-OpenGloves-Named-Pipe-Input-Library`,
  `opengloves-osc`.
- Best fit for `VR-apps-lab`:
  custom-device bridge and hand-input integration patterns.

## Method 425: Alpha/serial/finger encoding helper library for DIY glove firmware and host tests

- What it is:
  a helper library defines typed hand/device input data, finger curl/splay,
  joystick/buttons, haptics/force feedback outputs, and encodes or decodes
  compact serial messages for firmware and host tools.
- Good for:
  DIY glove firmware, serial bridges, hardware diagnostics, synthetic tests,
  and compatibility probes.
- Why it matters:
  firmware/host integration becomes more maintainable when the packet model is
  explicit and shared across examples.
- Strong references:
  `opengloves-lib`, `pygloves`.
- Best fit for `VR-apps-lab`:
  hardware bridge diagnostics and custom controller protocol references.

## Method 426: Game event to force-feedback adapter with sidecar/mod bridge

- What it is:
  a game or Unity scene emits interaction/curl events through hover callbacks,
  logs, files, or mod scripts; a sidecar parses those events and forwards
  five-finger force-feedback values to the hand-device driver.
- Good for:
  haptic adapters, game companions, interaction demos, force-feedback
  experiments, and hardware integration proofs.
- Why it matters:
  haptic hardware can be integrated through narrow event bridges instead of
  deep game/runtime hooks, but the support boundary must be explicit.
- Strong references:
  `opengloves-force-feedback-unity-demo`, `opengloves-hl-alyx-integration`.
- Best fit for `VR-apps-lab`:
  game-to-haptics adapter research and force-feedback sidecar patterns.

## Method 427: Unity-to-WebXR export loader with JSON feature/refspace manifest and subsystem gating

- What it is:
  a Unity WebGL export package treats WebXR reference spaces, required/optional
  features, framebuffer scale, manager/input autoload, and XR subsystem choices
  as explicit serialized settings passed into the browser bridge.
- Good for:
  browser XR prototypes, no-install utility panels, Unity WebGL demos,
  compatibility probes, and feature-gated AR/VR experiences.
- Why it matters:
  WebXR feature support is too variable to hide in glue code; it should be a
  readable compatibility contract.
- Strong references:
  `unity-webxr-export`.
- Best fit for `VR-apps-lab`:
  browser-backed utility shells and WebXR capability documentation.

## Method 428: Minimal Unity WebXR bridge with shared JS/C# arrays and editor fake-device simulation

- What it is:
  a compact Unity component owns session entry, input source state, hit-test
  values, per-eye cameras, and events while a JavaScript plugin exchanges state
  through shared arrays; editor simulation supplies head/hand/projection data.
- Good for:
  quick WebXR experiments, small browser utilities, educational examples, and
  early no-HMD iteration.
- Why it matters:
  small bridge surfaces reduce prototype weight and make the runtime boundary
  easier to understand.
- Strong references:
  `Simple-WebXR-Unity`.
- Best fit for `VR-apps-lab`:
  minimal browser-XR prototypes and fake-device iteration.

## Method 429: Non-HMD WebXR display adapter with custom XRDevice lifecycle and multi-view projection

- What it is:
  a custom display surface is exposed through WebXR-like device abstractions,
  with explicit reference-space support, canvas/window ownership, and generated
  multi-view projection/inverse-view matrices.
- Good for:
  holographic displays, virtual display research, XR glasses helpers,
  desktop-to-XR bridges, and non-headset visualization.
- Why it matters:
  XR utility displays can reuse session/view concepts even when the target is
  not a headset.
- Strong references:
  `looking-glass-webxr`.
- Best fit for `VR-apps-lab`:
  virtual display and custom display-surface research.

## Method 430: Composition-layer compatibility shim with session patching and per-layer GL/media renderers

- What it is:
  a layer polyfill patches WebXR sessions, injects binding objects, normalizes
  layer creation, and renders projection, quad, cube, cylinder, equirect, media,
  texture-array, and stereo-layout surfaces through dedicated renderers.
- Good for:
  browser media panels, projection-aware video surfaces, dashboards,
  compatibility experiments, and layer API research.
- Why it matters:
  layer rendering should be separated from session interception and feature
  negotiation.
- Strong references:
  `webxr-layers-polyfill`.
- Best fit for `VR-apps-lab`:
  browser media/layer placement references.

## Method 431: Deterministic WebXR fake-device test surface

- What it is:
  a testing-only API connects simulated XR devices and input sources, controls
  poses, tracking loss, views, hit-test worlds, visibility, select events, and
  DOM overlay pointer positions, then asserts results through normal WebXR
  frames.
- Good for:
  no-HMD tests, browser XR diagnostics, CI design, hardware-free prototyping,
  and support-boundary validation.
- Why it matters:
  XR behavior must be made deterministic before it can be tested reliably.
- Strong references:
  `webxr-test-api`.
- Best fit for `VR-apps-lab`:
  fake-device, no-HMD, and XR validation research.

## Method 432: Feature-gated browser XR showcase scaffold with anchors, hit-test, planes, controllers, and configurator UI

- What it is:
  a WebXR showcase declares required/optional session features up front, then
  demonstrates focused flows such as room capture, furniture placement,
  measurement, controller motion, pointer modes, and product configuration.
- Good for:
  public demos, AR placement utilities, measurement tools, configurators, and
  quick browser XR product proofs.
- Why it matters:
  complete showcase flows reveal UX and fallback needs that isolated API
  samples hide.
- Strong references:
  `webxr-showcases`.
- Best fit for `VR-apps-lab`:
  browser XR product references and MR utility mockups.

## Method 433: Browser editor method bus with observer history, asset virtual paths, realtime rooms, and plugin actions

- What it is:
  a browser editor routes commands through a method bus, tracks mutable state
  with observer history, exposes virtual asset paths, syncs realtime documents,
  joins presence rooms, and adds tools as plugins/actions.
- Good for:
  calibration editors, diagnostic workspaces, scene setup tools, creator
  utilities, collaborative panels, and asset-heavy VR tools.
- Why it matters:
  editor-like VR utilities become maintainable when commands, assets,
  documents, presence, and plugins are separate layers.
- Strong references:
  `playcanvas/editor`.
- Best fit for `VR-apps-lab`:
  editor-style utility architecture.

## Method 434: Local project-file scene studio with action history, resource crawler, and VR entry toggle

- What it is:
  a scene editor stores projects locally, manages resource crawling, tabs,
  selection, action bundles/history, shortcuts, run/stop lifecycle, and an
  explicit VR mode toggle.
- Good for:
  local-first utility workbenches, calibration layouts, scene inspectors,
  creator tools, and prototypes that do not need cloud collaboration.
- Why it matters:
  local project documents and action histories are a simpler foundation than a
  full service-backed editor.
- Strong references:
  `nunuStudio`.
- Best fit for `VR-apps-lab`:
  local scene/workspace tools and editor-like spikes.

## Method 435: Source-code-driven 3D workspace with JSX metadata extraction and provider-injected previews

- What it is:
  a visual workspace extracts component metadata from source code, records
  transform-capable props, injects providers through virtual modules, renders
  isolated previews, and can produce screenshots.
- Good for:
  React/Three XR tools, code-first creator utilities, visual editors, preview
  workspaces, and design/debug panels.
- Why it matters:
  some tools should annotate and preview existing code instead of forcing a
  separate scene database.
- Strong references:
  `triplex`.
- Best fit for `VR-apps-lab`:
  browser-backed visual workspaces and source-aware utility editors.

## Method 436: In-VR live-coding sandbox with text panels, scene interception, local persistence, and error overlays

- What it is:
  a VR scene exposes code text panels and monitor surfaces, evaluates user code
  against scene/camera/renderer handles, tracks objects added by the sketch,
  supports cleanup, persists sketches locally, and shows runtime errors in VR.
- Good for:
  developer utilities, quick prototyping, education, diagnostics scripting, and
  headset-native debug tools.
- Why it matters:
  live scripting becomes usable in VR when feedback and errors stay inside the
  headset.
- Strong references:
  `RiftSketch`.
- Best fit for `VR-apps-lab`:
  in-headset developer tools and live utility scripting references.

## Method 437: VRM avatar runtime pipeline with spec-backed humanoid, expression, look-at, spring-bone, first-person, and constraint modules

- What it is:
  an avatar runtime loads a model through modular spec-backed components for
  metadata, humanoid mapping, expressions, first-person visibility, look-at,
  spring bones, node constraints, materials, and update loops.
- Good for:
  avatar previewers, model checkers, face/pose bridges, mocap viewers, browser
  avatar surfaces, and creator diagnostics.
- Why it matters:
  avatar tools should reason about runtime behavior and spec contracts, not
  just mesh display.
- Strong references:
  `UniVRM`, `three-vrm`, `aframe-vrm`, `vrm-specification`.
- Best fit for `VR-apps-lab`:
  avatar utility, VMC/MediaPipe/VRM bridge, and validation research.

## Method 438: Browser AR placement layer with target compiler, marker/location events, model-viewer fallback, and environment-aware WebXR renderer

- What it is:
  browser AR placement combines target compilation, marker/image/face/location
  tracking events, A-Frame AR feature wrappers, model-viewer WebXR/Scene
  Viewer/Quick Look fallbacks, hotspots/annotations, hit-test, anchors, planes,
  light estimation, depth sensing, and debug depth surfaces.
- Good for:
  MR placement helpers, object annotation, target-based diagnostics, AR
  checklists, model previews, and browser MR utility prototypes.
- Why it matters:
  MR utilities need robust placement and fallback surfaces before they need
  complex app logic.
- Strong references:
  `mind-ar-js`, `AR.js`, `Simple-AR`, `aframe-ar`, `model-viewer`,
  `enva-xr`.
- Best fit for `VR-apps-lab`:
  browser MR utility surfaces and scene-understanding diagnostics.

## Method 439: WebXR hand joint cache with composable gesture and ray components

- What it is:
  a WebXR hand system reads `XRHand` joint spaces each XR frame, stores
  visibility, position, orientation, and radius, then exposes higher-level
  components for pinch events, fingertip rays, meshes, drawing, and physics.
- Good for:
  controllerless UI, hand-first menus, calibration gestures, annotation tools,
  and browser hand diagnostics.
- Why it matters:
  hand logic stays reusable when raw joints, gesture detection, and UI
  behaviors are separated.
- Strong references:
  `webxr-handtracking`, `webxr-quest2`.
- Best fit for `VR-apps-lab`:
  WebXR hand input utilities and hand-tracking diagnostics.

## Method 440: Hand-pose telemetry bridge over WebSocket

- What it is:
  a browser/WebXR scene enables hand tracking, extracts a stable subset of
  joints, rate-limits transmission, and publishes handedness, joint poses,
  timestamps, and status over WebSocket.
- Good for:
  gesture capture, teleoperation, browser-to-local-tool bridges, diagnostics,
  and headset-as-sensor workflows.
- Why it matters:
  hand tracking becomes reusable outside the browser when it is treated as a
  transportable data product.
- Strong references:
  `webxr-hand-tracking-websocket`.
- Best fit for `VR-apps-lab`:
  hand tracking bridges, external tool adapters, and no-install diagnostics.

## Method 441: Projection-aware immersive media viewer with explicit format controls

- What it is:
  a media viewer exposes projection, FOV, stereo layout, frame packing,
  baseline, disparity, and source intake as first-class controls instead of
  hiding them inside decoder or shader assumptions.
- Good for:
  180/360 video players, spatial video QA, media diagnostics, local file
  viewers, and format troubleshooting.
- Why it matters:
  immersive media failures are often format-assumption failures; explicit
  controls make them inspectable.
- Strong references:
  `webxr-video`, `openimmersive`, `html-360-viewer`.
- Best fit for `VR-apps-lab`:
  media QA helpers and projection-aware overlay/browser surfaces.

## Method 442: In-XR canvas UI texture with controller-to-pointer event translation

- What it is:
  a 2D canvas renders a playback/settings/list UI, is placed as an XR surface,
  and controller rays or mouse state are transformed into pointer events on the
  canvas.
- Good for:
  browser-backed VR panels, media controls, settings surfaces, dashboards, and
  utility UIs that should not invent a full 3D widget system.
- Why it matters:
  many utilities can keep rich 2D UI logic while still being usable inside XR.
- Strong references:
  `webxr-video`.
- Best fit for `VR-apps-lab`:
  browser overlay panels and WebXR utility shells.

## Method 443: Portable single-file 360 viewer with drag/drop, URL parameters, and stereo toggles

- What it is:
  a single HTML utility embeds its viewer, controls, media intake, query-string
  loading, drag/drop, stereo mode toggles, zoom, screenshot, and video controls
  in one copyable file.
- Good for:
  quick inspection tools, support attachments, local media triage, demos, and
  low-friction browser diagnostics.
- Why it matters:
  not every utility needs a build system; sometimes portability is the product
  value.
- Strong references:
  `html-360-viewer`.
- Best fit for `VR-apps-lab`:
  small browser utility references and diagnostic viewers.

## Method 444: Desktop local-media shell around a browser VR player

- What it is:
  a desktop shell such as Tauri wraps a web media player, handles native file
  picker and drop events, converts local paths to safe web URLs, and delegates
  playback to browser media libraries.
- Good for:
  local 360 video players, QA tools, internal review utilities, and packaged
  no-server media viewers.
- Why it matters:
  local file permissions and drag/drop can be the hardest part of a browser
  media utility.
- Strong references:
  `360-video-player`.
- Best fit for `VR-apps-lab`:
  local media utility packaging and desktop/browser hybrid surfaces.

## Method 445: Audio analyser to normalized XR shader feature vector

- What it is:
  a WebAudio or p5 audio analyser computes small normalized features such as
  amplitude, centroid, waveform, or frequency bands, then feeds them into XR
  shader uniforms or scene parameters.
- Good for:
  audio-reactive overlays, music visualizers, microphone diagnostics, ambient
  HUDs, and sound-aware effects.
- Why it matters:
  render code should consume named audio features, not raw analyser details.
- Strong references:
  `vite-three-webxr-audio-visualizer`, `seeSound`,
  `webxr-audio-visualizer`.
- Best fit for `VR-apps-lab`:
  audio diagnostics and sound-aware visualization surfaces.

## Method 446: Native audio loopback to frequency buckets, audio texture, and shader package

- What it is:
  a native VR tool captures system audio, runs FFT and smoothing, writes
  frequency buckets into constants or textures, and loads visual effects from a
  separate shader/effect package.
- Good for:
  native audio visualizers, performance-sensitive diagnostics, shader-driven
  overlays, and app-audio status tools.
- Why it matters:
  separating capture, signal processing, render resources, and effect authoring
  keeps heavy native visualizers maintainable.
- Strong references:
  `boondoggle`.
- Best fit for `VR-apps-lab`:
  native audio diagnostics and audio-reactive overlay architecture references.

## Method 447: Renderer-owned WebXR manager with target-ray, grip, and hand scene groups

- What it is:
  a renderer keeps WebXR session/reference-space/render-target state internal
  while exposing each input source as stable scene groups for target ray, grip,
  and hand spaces.
- Good for:
  minimal WebXR utilities, controller visualization, ray UI, teleportation,
  and small browser prototypes.
- Why it matters:
  application code can treat XR input as ordinary scene objects while session
  details stay encapsulated.
- Strong references:
  `three.js`.
- Best fit for `VR-apps-lab`:
  minimal browser utility shells and controller/hand abstraction comparisons.

## Method 448: Modular WebXR feature manager with session-init extension hooks

- What it is:
  each XR capability is registered as a feature with compatibility checks,
  dependencies, attach/detach lifecycle, observables, and optional
  `XRSessionInit` extension before session creation.
- Good for:
  browser XR shells, capability-gated utilities, diagnostics, AR placement,
  hand tracking, layers, anchors, planes, depth, and teleportation.
- Why it matters:
  WebXR feature availability is fragmented; utilities need explicit feature
  negotiation and support reporting.
- Strong references:
  `Babylon.js`.
- Best fit for `VR-apps-lab`:
  WebXR feature managers and capability/support matrices.

## Method 449: Evented XR service taxonomy for input, hands, DOM overlay, hit-test, anchors, planes, meshes, and views

- What it is:
  an engine exposes XR as a manager with typed subsystem services, support and
  availability state, lifecycle events, input-source events, hand abstractions,
  and optional graphics backend bridges.
- Good for:
  diagnostics, tool shells, AR utilities, input debuggers, and scene
  understanding panels.
- Why it matters:
  utility code stays inspectable when XR capabilities are visible services
  instead of hidden helper calls.
- Strong references:
  `playcanvas/engine`.
- Best fit for `VR-apps-lab`:
  browser XR diagnostics and service-oriented utility architecture.

## Method 450: Runtime-first XR development control surface with session state, synthetic input, and scene introspection

- What it is:
  a WebXR framework writes runtime session state, exposes CLI/MCP-like control
  over browser/headset state, supports synthetic controller/hand transforms,
  and provides scene/ECS inspection such as hierarchy, snapshot, diff, pause,
  and step.
- Good for:
  no-HMD workflows, automated QA, remote support, browser XR diagnostics,
  agent-assisted development, and deterministic repros.
- Why it matters:
  XR tools become easier to debug when runtime control and observation are
  designed into the development loop.
- Strong references:
  `immersive-web-sdk`, `webxr-test-api`.
- Best fit for `VR-apps-lab`:
  testable browser XR utility shells and no-HMD validation research.

## Method 451: Declarative A-Frame widget inventory with flex-like layout and focus state

- What it is:
  an A-Frame UI library exposes buttons, toggles, sliders, inputs, labels,
  loaders, progress bars, text, colors, borders, focus, hover, active, and
  layout fields as component schemas.
- Good for:
  browser VR settings panels, quick control surfaces, simple dashboards,
  prototype menus, and no-build WebXR utility UI.
- Why it matters:
  utility UI becomes easier to remix when widgets are declarative scene
  components rather than ad-hoc imperative entity construction.
- Strong references:
  `aframe-gui`.
- Best fit for `VR-apps-lab`:
  A-Frame/browser utility menu examples and control-panel pattern notes.

## Method 452: Event-start/end teleport ray with landing validation

- What it is:
  a locomotion component starts and ends teleport targeting through named
  events, renders parabolic or straight rays, validates collision and landing
  normals, and moves the camera rig only after a valid hit.
- Good for:
  small VR scenes, browser utility rooms, data viewers, shared diagnostics
  spaces, and comfort-preserving navigation.
- Why it matters:
  teleportation should be a replaceable utility component, not tangled inside
  the whole scene or input stack.
- Strong references:
  `aframe-teleport-controls`.
- Best fit for `VR-apps-lab`:
  browser utility shells that need safe navigation without a game framework.

## Method 453: Semantic interaction grammar for hover, grab, stretch, drag, drop, and click

- What it is:
  raw controller, hand, mouse, and touch events are normalized into semantic
  object events such as hover, grab, stretch, drag, dragover, drop, and click,
  with reaction components deciding whether each event is accepted.
- Good for:
  direct manipulation, object pickup, drag/drop panels, controller/hand
  fallback, and reusable WebXR interaction layers.
- Why it matters:
  scene objects should not care which device produced the interaction if the
  intended action is the same.
- Strong references:
  `aframe-super-hands-component`.
- Best fit for `VR-apps-lab`:
  reusable interaction vocabularies for browser VR menus and utility objects.

## Method 454: Lifecycle-managed WebXR menu registry with hand-tracking pressables

- What it is:
  menus are registered by id, only one active menu is shown at a time, created
  elements and event handlers are tracked for cleanup, and optional pressable
  surfaces translate hand-tracking finger proximity into press/hover events.
- Good for:
  small in-headset settings menus, help panels, hand-first utility UI, and
  controllerless WebXR surfaces.
- Why it matters:
  VR menus leak state easily unless lifecycle and cleanup are explicit.
- Strong references:
  `aframe-webxr-ui-toolkit`, `AUXL`.
- Best fit for `VR-apps-lab`:
  browser utility menu baselines and hand/control comparison docs.

## Method 455: Immersive analytics grammar compiler with spatial views and selection/filter callbacks

- What it is:
  a JSON visualization grammar is validated, normalized, compiled into spatial
  views, axes, legends, marks, filters, scales, and tooltips, then synchronized
  with selection and filter callbacks.
- Good for:
  VR dashboards, telemetry surfaces, diagnostics data viewers, scientific
  analysis rooms, and configurable 3D charts.
- Why it matters:
  diagnostics become reusable when the view grammar is separate from the data
  and scene rendering code.
- Strong references:
  `vria`.
- Best fit for `VR-apps-lab`:
  future diagnostics visualization grammar and data-rich utility panels.

## Method 456: A-Frame graph visualization component with accessor schema and raycaster events

- What it is:
  graph data, node/link accessor functions, visual options, hover callbacks,
  and click callbacks are exposed through an A-Frame component schema, with
  A-Frame raycasters driving interaction.
- Good for:
  runtime topology maps, device graphs, dependency graphs, network/session
  maps, and browser VR graph panels.
- Why it matters:
  graph surfaces are easier to reuse when the data accessor contract is clear.
- Strong references:
  `aframe-forcegraph-component`, `3d-force-graph-vr`.
- Best fit for `VR-apps-lab`:
  graph-based diagnostics and topology visualization surfaces.

## Method 457: Scientific viewer plugin shell with managers, command bus, snapshots, and XR input mapping

- What it is:
  a complex viewer is organized around plugin context, managers, state,
  commands, render parameters, snapshots, selection/focus helpers, and a
  dedicated XR input mapper.
- Good for:
  scientific inspection, reproducible diagnostics, scene-state capture,
  measurement tools, and data viewers with complex interaction state.
- Why it matters:
  serious viewers need restorable state and named managers before they need
  more rendering features.
- Strong references:
  `molstar`.
- Best fit for `VR-apps-lab`:
  session snapshots, reproducible diagnostics, and large viewer architecture
  notes.

## Method 458: Notebook-to-WebGL volume/data widget bridge with trait sync and texture tiling

- What it is:
  Python-side widget traits synchronize scatter, mesh, volume, selection,
  hover, click, material, and camera state to a browser/WebGL view, with volume
  data serialized into tiled textures or embeddable bundles.
- Good for:
  research workflows, offline analysis, scientific data inspection, telemetry
  review, and notebook-fed VR/browser visualization.
- Why it matters:
  some VR utility data will be produced by analysis pipelines, not by the
  headset runtime itself.
- Strong references:
  `ipyvolume`.
- Best fit for `VR-apps-lab`:
  offline diagnostics, data import/export, and scientific visualization
  substrate research.

## Method 459: WebXR-to-engine remote VR streaming protocol over WebRTC data channels

- What it is:
  a browser/WebXR client receives rendered video while sending typed pose,
  button, axis, display, enter/exit VR, and session-control messages over a
  WebRTC data channel to an engine runtime.
- Good for:
  thin headset clients, remote engine utilities, guided support, streamed
  dashboards, and desktop-rendered VR tools.
- Why it matters:
  pose/control data should be a documented protocol, not an incidental blob
  hidden behind the video stream.
- Strong references:
  `VRStreaming`, `PixelStreamingInfrastructure`.
- Best fit for `VR-apps-lab`:
  remote VR utility protocol design and streamed browser/headset surfaces.

## Method 460: Render streaming stack with signaling manager, peer wrapper, data channel, and input remoting

- What it is:
  a remote rendering stack separates signaling, peer negotiation, media tracks,
  data channels, browser input-remoting messages, runtime settings, and
  signaling handlers.
- Good for:
  remote control surfaces, thin-client streaming, engine-backed dashboards,
  browser-to-engine utility shells, and support sessions.
- Why it matters:
  WebRTC utilities stay maintainable when signaling and app protocol are not
  tangled together.
- Strong references:
  `UnityRenderStreaming`, `com.unity.webrtc`.
- Best fit for `VR-apps-lab`:
  WebRTC architecture notes and future remote utility scaffolds.

## Method 461: Pixel-streaming WebXR client with video projection and selective pose messages

- What it is:
  a browser client enters WebXR, renders a streamed video texture into headset
  views, sends HMD transforms per frame, and sends eye/projection/gamepad data
  only when it changes or when startup requires it.
- Good for:
  Unreal streaming, remote VR review, engine-rendered worlds, thin immersive
  clients, and network-aware XR protocols.
- Why it matters:
  structural XR data and high-frequency pose data have different bandwidth and
  update needs.
- Strong references:
  `PixelStreamingInfrastructure`.
- Best fit for `VR-apps-lab`:
  streamed VR client design and protocol comparison matrices.

## Method 462: Shared spatial world substrate with scene schema, networked objects, media, headless clients, and app modules

- What it is:
  a collaborative VR utility treats scenes/worlds as data, separates object
  identity from network clones, publishes user/hand/media/text events through
  protocols, supports synthetic/headless clients, and loads spatial tools as
  app modules with lifecycle events.
- Good for:
  shared diagnostics rooms, collaborative support, social utility shells,
  remote inspection, load testing, and plugin-like spatial dashboards.
- Why it matters:
  multi-user utilities need explicit scene, network, avatar, media, and module
  boundaries before product features can remain stable.
- Strong references:
  `ATON`, `circlesxr`, `arena-web-core`, `Basis`, `webaverse`.
- Best fit for `VR-apps-lab`:
  shared VR diagnostics architecture, headless-client research, and
  collaborative browser utility shells.

## Method 463: Pose-derived comfort micro-overlay

- What it is:
  a tiny overlay derives a physical comfort signal from headset pose, converts
  it into coarse user-facing state, and refreshes a compact visual surface only
  when needed.
- Good for:
  cable rotation counters, comfort warnings, orientation reminders, standing
  play-space helpers, and low-friction safety surfaces.
- Why it matters:
  useful VR utilities can be built from one pose-derived signal when the
  presentation is glanceable and the state is physically meaningful.
- Strong references:
  `turncountervr`.
- Best fit for `VR-apps-lab`:
  situational comfort overlays and tiny status surfaces.

## Method 464: Hardware sensor telemetry overlay with tray, control loop, and safe cleanup

- What it is:
  a desktop utility polls hardware sensors, presents a topmost status overlay,
  exposes tray controls, applies optional fan or power-limit policies, and
  restores safe state on exit.
- Good for:
  GPU/VRAM thermal monitors, battery/device dashboards, performance overlays,
  simulator-side hardware panels, and VR-captured desktop telemetry.
- Why it matters:
  VR status tools often need robust telemetry and safety policy before they
  need native overlay rendering.
- Strong references:
  `gpu-vram-monitor`.
- Best fit for `VR-apps-lab`:
  telemetry-source adapters feeding overlay, dashboard, or desktop-capture
  surfaces.

## Method 465: Simulator shared-memory telemetry poller plus topmost utility widgets

- What it is:
  a simulator companion maps a shared-memory telemetry region, resolves named
  variables, polls current values, and feeds lightweight draggable overlay
  windows or launcher actions.
- Good for:
  racing/flight simulator dashboards, session helpers, telemetry review panels,
  lap/fuel/device overlays, and motion-cueing sidecars.
- Why it matters:
  simulator VR utilities often get value from a thin data reader plus readable
  presentation rather than from deep runtime integration.
- Strong references:
  `RacingManager`.
- Best fit for `VR-apps-lab`:
  simulator telemetry panels and app-launching companion shells.

## Method 466: VR/desktop readability profile switch for host-embedded web panels

- What it is:
  a host-embedded HTML panel changes typography, transparency, message density,
  layout, and persistence behavior when the host is in VR mode.
- Good for:
  Twitch/chat panels, subtitles, kneeboards, simulator checklists, stream
  controls, and in-host utility HUDs.
- Why it matters:
  VR readability is a product requirement, not a final CSS tweak.
- Strong references:
  `vr-twitch-chat-ui`.
- Best fit for `VR-apps-lab`:
  overlay typography guidelines and VR-aware browser-panel settings.

## Method 467: OSC parameter to HMD-relative overlay icon bridge

- What it is:
  a companion listens to OSC avatar or app parameters, maps them into symbolic
  state, and renders small HMD-relative overlay icons with configurable
  placement and fade behavior.
- Good for:
  VRChat gesture state, avatar status indicators, control-mode feedback,
  accessibility state, and small OSC-driven HUDs.
- Why it matters:
  OSC bridges can make hidden runtime or avatar state visible without requiring
  a full companion dashboard.
- Strong references:
  `GOpy`.
- Best fit for `VR-apps-lab`:
  avatar-facing micro-overlays and OSC bridge reference designs.

## Method 468: External overlay-host notification WebSocket envelope with queue/backoff/drop policy

- What it is:
  an external app or plugin filters events, sanitizes them, builds a host
  notification payload, and sends it to a running overlay host over WebSocket
  with reconnect, queueing, and drop rules.
- Good for:
  Discord/Twitch/system notifications, automation alerts, companion app
  messages, and headset-visible event feeds.
- Why it matters:
  using an overlay host as the presentation layer can keep utility sidecars
  small, but the protocol and failure policy need to be explicit.
- Strong references:
  `BD-XSOverlay-notify`.
- Best fit for `VR-apps-lab`:
  overlay-host protocol matrix and notification bridge patterns.

## Method 469: Offscreen OpenGL/ImGui texture overlay plus controller-ray mouse emulation

- What it is:
  a native overlay renders UI into an offscreen framebuffer, submits the GL
  texture to OpenVR, and maps controller rays/triggers into mouse coordinates
  for the overlay UI.
- Good for:
  minimal native overlays, ImGui dashboards, diagnostics panels, and small
  controller-driven settings surfaces.
- Why it matters:
  this is one of the clearest low-level implementation baselines for overlay UI
  without a game engine.
- Strong references:
  `EmyOverlay`, `VROverlayTest`, `zenn-overlay-tutorial`.
- Best fit for `VR-apps-lab`:
  overlay implementation guides and native dashboard prototypes.

## Method 470: Xrandr virtual display manager with modelines, virtual EDID, GPU setup, and persistence

- What it is:
  a desktop utility creates virtual monitor modes, attaches them to available
  outputs, writes GPU-specific configuration when needed, persists display
  state, and exposes a GUI for enable/edit/remove flows.
- Good for:
  Linux desktop-in-VR, OBS/Sunshine capture targets, remote desktops, virtual
  workspaces, and headset-side desktop helpers.
- Why it matters:
  a stable virtual display is often a prerequisite for streaming, capture, or
  VR desktop workflows.
- Strong references:
  `Linux-Virtual-Display-Driver`.
- Best fit for `VR-apps-lab`:
  virtual display workflow comparisons and Linux display-surface research.

## Method 471: Spatial-display OpenXR runtime split with compositor and display-processor boundaries

- What it is:
  an OpenXR runtime for non-HMD displays separates state tracking, graphics API
  compositors, device drivers, display processors, shell/controller policy, and
  app classes such as handle, texture, hosted, or IPC/service modes.
- Good for:
  spatial displays, 3D monitors, headsetless OpenXR, special-display runtimes,
  and runtime architecture comparisons.
- Why it matters:
  nonstandard displays need runtime boundaries that do not assume headset-only
  composition.
- Strong references:
  `dfattal/openxr-3d-display`.
- Best fit for `VR-apps-lab`:
  special-display architecture notes and runtime boundary research.

## Method 472: Desktop/no-HMD synthetic XR trackers and action injection

- What it is:
  an engine addon or editor tool injects synthetic head/controller trackers and
  action values so XR interactions can be driven from keyboard and mouse when
  no headset is active.
- Good for:
  no-HMD development, CI-adjacent interaction checks, editor iteration,
  accessibility testing, and fake-device workflows.
- Why it matters:
  VR utility development should not require wearing a headset for every UI or
  interaction iteration.
- Strong references:
  `GodotXRDesktop`, `AutoHandSimulator`.
- Best fit for `VR-apps-lab`:
  headsetless workflow guides and fake-XR input scaffolds.

## Method 473: OpenXR hand extension bridge for joints and skinned hand meshes

- What it is:
  a custom engine feature binds OpenXR hand tracking extension functions,
  captures predicted display time, locates hand joints, queries hand mesh data,
  converts coordinates, and updates a skinned hand representation.
- Good for:
  hand tracking prototypes, extension research, engine package gap analysis,
  and low-level input diagnostics.
- Why it matters:
  extension-level examples reveal runtime and memory boundaries hidden by
  higher-level engine packages.
- Strong references:
  `openxrhands`.
- Best fit for `VR-apps-lab`:
  hand tracking architecture notes and package-vs-extension comparisons.

## Method 474: Scientific XR toolkit primitive stack with data gathering, value ranges, sockets, and editor menu factories

- What it is:
  a research-oriented XR toolkit provides configurable rigs, data export,
  value-range interactables, socket highlighting, menus, HUDs, setup dialogs,
  and editor factories as reusable primitives.
- Good for:
  experiments, training apps, exhibitions, diagnostics workflows, guided setup,
  and utility prototypes that need repeatable interaction/data patterns.
- Why it matters:
  serious VR tools often need data capture and setup workflows as much as they
  need visual UI widgets.
- Strong references:
  `ExPresS-XR`.
- Best fit for `VR-apps-lab`:
  Unity toolkit comparison notes and future experiment/diagnostic utility
  primitives.

## Method 475: Vendor OpenXR face/eye expression normalizer with runtime restore

- What it is:
  a tracking module temporarily selects a vendor OpenXR runtime, loads native
  face/eye bridge functions, polls expression and gaze data, maps vendor
  expression names into a unified avatar shape vocabulary, and restores the
  previous runtime during teardown.
- Good for:
  face/eye module research, vendor tracking adapters, runtime safety notes, and
  expression-mapping comparisons.
- Why it matters:
  runtime switching is dangerous unless restore and failure handling are part
  of the design, not cleanup afterthoughts.
- Strong references:
  `VRCFaceTracking-QuestProOpenXR`.
- Best fit for `VR-apps-lab`:
  facetracking module architecture notes and runtime-switch safety checklists.

## Method 476: Dual local/remote VRCFT tracking ingress module

- What it is:
  one tracking family offers both a local OpenXR session module and a remote
  packet-ingress module, sharing config, expression mapping, filters,
  sensitivity profiles, and VRCFT output normalization.
- Good for:
  ALXR/streaming tracking modules, face/eye tracking sidecars, external sensor
  bridges, and extension-selection experiments.
- Why it matters:
  tracking data should not care whether it came from the local runtime or a
  remote transport once it reaches the normalizer boundary.
- Strong references:
  `VRCFT-ALXR-Modules`.
- Best fit for `VR-apps-lab`:
  tracking-ingress module patterns and local/remote sensor architecture notes.

## Method 477: Avatar facetracking package with threshold editor and OSC cleanup

- What it is:
  an avatar package ships prefabs/controllers plus Unity editor tooling for
  expression thresholds, JSON import/export, Unified Expression/ARKit modes,
  warnings, and cleanup of stale local VRChat OSC avatar config after upload.
- Good for:
  creator-side avatar setup tools, facetracking onboarding, threshold tuning,
  OSC hygiene, and reusable avatar-package checklists.
- Why it matters:
  runtime tracking quality is only useful if avatar-side setup and maintenance
  are understandable.
- Strong references:
  `VRC-Facetracking`.
- Best fit for `VR-apps-lab`:
  avatar authoring workflow notes and facetracking setup guides.

## Method 478: Real-time eye-gaze calibration client with persistent offsets

- What it is:
  a small OpenXR scene presents head-locked calibration points, records gaze
  direction on trigger confirmation, computes an average offset, persists it
  to a known file, and notifies a runtime/toolkit sidecar when calibration
  starts or stops.
- Good for:
  eye-tracking calibration, gaze diagnostics, avatar look correction, and
  device-specific calibration UX.
- Why it matters:
  calibration is a product workflow, not just a math correction.
- Strong references:
  `PSVR2EyeTrackingCalibration`.
- Best fit for `VR-apps-lab`:
  gaze calibration UX and offset persistence research.

## Method 479: AI assistant sidecar with memory, tool-calling, and VRChat OSC output

- What it is:
  a companion separates prompt/config, live audio/video/text queues, memory,
  tool definitions, tool-to-function mappings, chatbox pagination, typing
  state, and avatar OSC actions around an AI session.
- Good for:
  VRChat AI companions, accessibility sidecars, guided helpers, avatar control
  agents, and multimodal support tools.
- Why it matters:
  AI integration becomes reusable only when tools, memory, transport, and model
  provider are separate seams.
- Strong references:
  `NOVA-AI`.
- Best fit for `VR-apps-lab`:
  OSC tool-calling sidecar patterns and provider-neutral assistant notes.

## Method 480: TTS-to-chatbox bridge with virtual-audio microphone routing

- What it is:
  a text utility generates speech, echoes the text into VRChat chatbox, toggles
  typing state, and plays the generated audio through a selected virtual audio
  output so the game receives it as microphone input.
- Good for:
  accessibility speech tools, silent users, avatar performance, translation
  sidecars, and TTS communication helpers.
- Why it matters:
  speech output needs an audio-device contract as much as a text or API
  contract.
- Strong references:
  `vrc-tts-osc`.
- Best fit for `VR-apps-lab`:
  voice/TTS workflow comparisons and audio routing setup notes.

## Method 481: Chatbox telemetry composer with platform-specific data adapters

- What it is:
  a status app gathers music, system hardware, network, weather, VRChat log
  state, custom status, and manual override values, formats them into compact
  chatbox-safe strings, and sends them through OSC on an interval.
- Good for:
  Linux/Steam Deck status tools, music/status chatbox helpers, hardware
  telemetry surfaces, and compact social presence utilities.
- Why it matters:
  chatbox status is often more accessible than a full overlay for VRChat users.
- Strong references:
  `XOSC`.
- Best fit for `VR-apps-lab`:
  status-surface comparisons and platform data-adapter notes.

## Method 482: Placeholder-driven chatbox and OSC forwarder engine

- What it is:
  one placeholder engine resolves dynamic modules for text, media, time, OSC
  data, hotkeys, trackers, math, and conditions, powering both visual block
  editors and advanced templates, then forwarding resolved values to chatbox or
  arbitrary typed OSC addresses.
- Good for:
  chatbox editors, avatar parameter automation, stream/status templates,
  nontechnical OSC tools, and bridge rule builders.
- Why it matters:
  a good template engine can turn a developer-only OSC bridge into a user
  tool.
- Strong references:
  `advosc`.
- Best fit for `VR-apps-lab`:
  template-engine and OSC automation design notes.

## Method 483: World-aware avatar scale controller with compatibility shims

- What it is:
  an OSC sidecar listens to VRChat eye-height, scale, tracking mode, world
  limit, and avatar change messages, then sends target eye-height changes with
  instant or smooth interpolation and optional adapters for third-party avatar
  scaling prefab contracts.
- Good for:
  avatar scale utilities, OSC control helpers, avatar-state diagnostics, and
  safe external parameter controllers.
- Why it matters:
  writing avatar parameters safely often requires listening to runtime/world
  state first.
- Strong references:
  `vrc-avi-scaler`.
- Best fit for `VR-apps-lab`:
  avatar parameter control patterns and scale-safety checklists.

## Method 484: Avatar-authored companion protocol for camera paths and control data

- What it is:
  an avatar package captures path/control data through in-world avatar
  interactions such as contacts, constraints, physbones, gestures, menus, and
  parameters, while a companion receives the data and sends playback/control
  commands back through OSC.
- Good for:
  camera paths, staged world events, avatar-authored tools, performer utilities,
  and creator-side control systems.
- Why it matters:
  avatars can be data capture instruments, but only if the companion protocol
  is explicit and debuggable.
- Strong references:
  `VRLabs/Camera-System`.
- Best fit for `VR-apps-lab`:
  avatar-side companion protocol research and camera/path tool notes.

## Method 485: Avatar contact OSC to Bluetooth microcontroller haptics bridge

- What it is:
  a sidecar discovers VRChat OSC, receives contact-derived avatar parameters,
  estimates intensity, applies decay, exposes status/test UI, and sends compact
  packets to a microcontroller that drives physical motors.
- Good for:
  DIY haptics, wearable feedback, accessibility signals, physical alert
  devices, and low-latency avatar contact output.
- Why it matters:
  physical-output bridges need a tiny, testable protocol between software and
  hardware.
- Strong references:
  `HapticPatPat`.
- Best fit for `VR-apps-lab`:
  DIY haptic bridge notes and contact-to-output patterns.

## Method 486: OSCQuery-advertised wearable haptics effect engine

- What it is:
  a wearable haptics app advertises OSC endpoints, registers callbacks for
  named muscles/events, maps incoming values into effect modules, computes
  intensity with proximity/speed/decay settings, and manages named sensation
  play/update/stop lifecycles.
- Good for:
  OWO/bHaptics/OpenShock comparisons, avatar-contact feedback, audio-reactive
  haptics, world-integrator bridges, and settings-heavy wearable utilities.
- Why it matters:
  haptics scale better when event intake, effect calculation, and device output
  are separate layers.
- Strong references:
  `owoskin-vrc`.
- Best fit for `VR-apps-lab`:
  device-neutral haptic event schema and wearable feedback comparison matrices.

## Method 487: Generic game rumble to external-device haptics router

- What it is:
  a router captures game/controller rumble events, deduplicates them, forwards
  them through an IPC envelope, visualizes left/right power, applies baseline
  and multiplier controls, and sends normalized output to selected external
  devices through a device hub.
- Good for:
  generic haptics routing, simulator feedback, device selection UIs, debugging
  haptic streams, and non-VR game-to-device adapters.
- Why it matters:
  even when invasive hooks are not reusable, the router boundary and visualizer
  UX are useful references.
- Strong references:
  `intiface-game-haptics-router`.
- Best fit for `VR-apps-lab`:
  haptic router architecture notes and safe/non-invasive event-source
  comparisons.

## Method 488: Safe quad-view settings companion with backup and config sanitation

- What it is:
  a narrow companion creates or edits advanced runtime/layer settings, reads
  existing defaults, backs up incompatible config files, normalizes locale
  quirks, and exposes exclusions without forcing users into manual text edits.
- Good for:
  OpenXR layer settings, quad-view/foveation configs, runtime feature toggles,
  and user-safe power-tool companions.
- Why it matters:
  advanced XR features often fail because setup UX is brittle, not because the
  rendering feature is weak.
- Strong references:
  `QuadViewsCompanion`.
- Best fit for `VR-apps-lab`:
  settings companion design notes and runtime/layer UX checklists.

## Method 489: Vendor foveated-rendering SDK emulation shim with eye-provider fallback

- What it is:
  a compatibility layer exposes vendor SDK functions expected by an external
  feature library, then fills the required data from multiple providers such as
  OpenVR, Varjo, VRChat OSC, or fixed-foveation fallback paths.
- Good for:
  vendor feature adaptation research, eye-tracking provider normalization, and
  compatibility-layer comparisons.
- Why it matters:
  feature availability can be expanded by emulating narrow SDK contracts, but
  the risk surface must be explicit.
- Strong references:
  `PimaxMagic4All`.
- Best fit for `VR-apps-lab`:
  vendor SDK compatibility notes and provider-fallback architecture patterns.

## Method 490: OpenVR DLL replacement rendering wrapper with D3D11 submission hooks

- What it is:
  a replacement `openvr_api.dll` loads the real OpenVR client library, hooks
  IVR interfaces and D3D11 context calls, intercepts compositor submission, and
  applies post-processing or VRS before forwarding textures.
- Good for:
  low-level rendering intervention research, foveation wrappers, debugging
  compatibility layers, and historical OpenVR tool comparisons.
- Why it matters:
  invasive hooks can teach reusable boundaries even when they are not safe
  product defaults.
- Strong references:
  `openvr_foveated`.
- Best fit for `VR-apps-lab`:
  OpenVR wrapper risk matrices and rendering intervention architecture notes.

## Method 491: OpenXR quad-view/foveation API-layer adapter

- What it is:
  an OpenXR API layer intercepts instance, view-configuration, locate-views, and
  frame submission calls to inject foveation metadata, scale recommended image
  sizes, and patch focus/peripheral FOV values.
- Good for:
  API-layer experiments, view-chain manipulation research, runtime adaptation,
  and foveated-rendering diagnostics.
- Why it matters:
  many XR runtime interventions are really `next` chain and view-contract
  problems.
- Strong references:
  `_ARCHIVE_Varjo-Foveated`.
- Best fit for `VR-apps-lab`:
  OpenXR API-layer design notes and frame/view intervention checklists.

## Method 492: Unity component plus native VRS plugin command-buffer split

- What it is:
  Unity scripts expose presets and render-pass controls, attach command buffers
  around forward/deferred rendering, send native plugin events, and a D3D11
  plugin enables or disables vendor VRS resources.
- Good for:
  Unity rendering utilities, native plugin integration, engine-side foveation,
  and visualization/debug controls.
- Why it matters:
  a native rendering feature becomes reusable only when the Unity-side lifecycle
  and capability gates are clean.
- Strong references:
  `ViveFoveatedRendering`.
- Best fit for `VR-apps-lab`:
  Unity native plugin and command-buffer integration references.

## Method 493: Standalone OSCQuery advertiser for legacy OSC apps

- What it is:
  a tiny utility advertises an existing OSC app's service name, OSC port, and
  endpoint vocabulary through OSCQuery/mDNS without owning the app's OSC packet
  handling.
- Good for:
  retrofitting OSCQuery to older tools, multi-app VRChat OSC setups, and
  discovery micro-utilities.
- Why it matters:
  many useful OSC tools should not need a full rewrite just to coexist with
  VRChat's discovery model.
- Strong references:
  `VrcAdvert`.
- Best fit for `VR-apps-lab`:
  VRChat OSC sidecar discovery helpers and compatibility micro-tools.

## Method 494: Async VRChat OSC/OSCQuery client with direct-address fallback

- What it is:
  an async library follows OSC/OSCQuery mDNS services, registers local services,
  fetches parameters, sends by service pattern or direct address, and keeps
  lifecycle handles for unregister/shutdown.
- Good for:
  Rust OSC utilities, service-discovery bridges, multi-network OSC tools, and
  parameter-introspection sidecars.
- Why it matters:
  direct-address escape hatches are necessary because mDNS does not behave
  consistently across localhost, LAN, VPN, and Quest-like setups.
- Strong references:
  `vrchat_osc`.
- Best fit for `VR-apps-lab`:
  OSCQuery transport matrices and sidecar architecture notes.

## Method 495: Evented OSCQuery parameter cache service

- What it is:
  a library advertises local OSC/OSCQuery services, discovers VRChat clients,
  fetches the OSCQuery root tree, recursively extracts avatar parameters, and
  emits update events when the avatar parameter list changes.
- Good for:
  C# companion apps, avatar parameter dashboards, diagnostics, and OSC tools
  that need current parameter availability.
- Why it matters:
  reading local avatar JSON is less robust than discovering the live avatar
  parameter tree.
- Strong references:
  `OscQueryLibrary`.
- Best fit for `VR-apps-lab`:
  avatar parameter discovery patterns and VRChat OSC diagnostics.

## Method 496: Sidecar-backed OSCQuery discovery for protocol-light runtimes

- What it is:
  a main app keeps a small OSCQuery facade while a bundled sidecar process owns
  mDNS discovery/advertisement, process watching, and address updates.
- Good for:
  Rust, Python, game-engine, or constrained runtime tools where native mDNS is
  awkward or unreliable.
- Why it matters:
  sidecars can be a clean boundary if packaging, lifecycle, and failure modes
  are first-class.
- Strong references:
  `oyasumivr_oscquery`.
- Best fit for `VR-apps-lab`:
  protocol sidecar design and OSCQuery packaging notes.

## Method 497: Minimal Python OSCQuery root/HOST_INFO helper and multi-app proxy

- What it is:
  a Python helper serves the small OSCQuery responses VRChat needs, advertises
  `_oscjson._tcp.local`, starts a matching OSC listener, and can proxy multiple
  named app ports from a config file.
- Good for:
  quick VRChat OSC prototypes, Python accessibility tools, status utilities,
  and multi-tool local setups.
- Why it matters:
  the simplest useful OSCQuery implementation is sometimes the best reference
  for small utilities.
- Strong references:
  `vrchat_oscquery`.
- Best fit for `VR-apps-lab`:
  Python OSC utility scaffolds and discovery examples.

## Method 498: Generated data-model bindings plus converter registry

- What it is:
  an editor-side tool queries a target platform's component/type model,
  generates typed bindings and wrappers, maps primitive types into editor-native
  equivalents, and registers converters that update target objects from source
  engine components.
- Good for:
  engine-to-social-VR SDKs, data-model bridges, creator tooling, and realtime
  preview/send workflows.
- Why it matters:
  generated bindings turn a remote platform data model into an editor-native
  authoring surface.
- Strong references:
  `Resonite.UnitySDK`.
- Best fit for `VR-apps-lab`:
  cross-engine creator tooling and binding/converter architecture notes.

## Method 499: Shared DTO and named IPC processor content-export pipeline

- What it is:
  source-engine data is serialized into shared DTOs, sent through IPC, and
  handled by named target-side processors for meshes, textures, slots, avatars,
  constraints, materials, packages, or other content units.
- Good for:
  Unity-to-social-VR exporters, live preview tools, package exporters, and
  data-heavy creator bridges.
- Why it matters:
  named processors make a big import pipeline debuggable and extensible.
- Strong references:
  `ResoniteUnityExporter`.
- Best fit for `VR-apps-lab`:
  creator bridge architecture and external tool to runtime import patterns.

## Method 500: Package extraction cache with configurable asset-type import

- What it is:
  an importer hashes package files, reuses extracted cache directories, preserves
  asset paths, and exposes switches for importing files as raw assets, meshes,
  textures, audio, video, fonts, documents, prefabs, or scenes.
- Good for:
  package importers, asset migration tools, creator workflow utilities, and
  large-content handling.
- Why it matters:
  package import UX needs caching and scope controls because blindly importing
  everything is slow and noisy.
- Strong references:
  `ResoniteUnityPackagesImporter`.
- Best fit for `VR-apps-lab`:
  asset import pipeline notes and creator package handling patterns.

## Method 501: In-world component palette search overlay

- What it is:
  a mod patches a component selector UI, adds a search field, caches component
  metadata, ranks matches, scopes results, and supports generic type selection.
- Good for:
  creator QoL tools, in-headset palettes, editor search surfaces, and large
  component model browsers.
- Why it matters:
  search/palette UX can make an expert tool usable inside VR.
- Strong references:
  `CherryPick`.
- Best fit for `VR-apps-lab`:
  VR menu/search UX and component palette utility references.

## Method 502: Screenshot metadata XMP round-trip with restore-on-import

- What it is:
  a capture utility serializes world, user, camera, pose, time, and app metadata
  into image XMP, then restores that metadata when the image is imported later,
  optionally adding sharing/webhook flows.
- Good for:
  social VR screenshots, diagnostics captures, provenance tracking, MRC tools,
  and archive-friendly media utilities.
- Why it matters:
  screenshots can be reusable data artifacts, not only flat images.
- Strong references:
  `ResoniteScreenshotExtensions`.
- Best fit for `VR-apps-lab`:
  capture metadata patterns and social/diagnostic artifact design.

## Method 503: Avatar-relative tracked-object bridge with calibration matrix

- What it is:
  a companion app pairs a tracked object with a controller/hand anchor, guides
  calibration, computes the hand-to-object transform, and sends calibrated
  position/rotation through avatar parameters.
- Good for:
  tracked props, performer tools, avatar interaction utilities, physical-object
  alignment, and calibration UX research.
- Why it matters:
  object tracking quality depends on the avatar-side contract and calibration
  matrix, not just raw tracker pose.
- Strong references:
  `VRC-Tracked-Objects`.
- Best fit for `VR-apps-lab`:
  external object tracking and avatar-side companion protocol notes.

## Method 504: NatNet rigid-body to VRChat OSC tracker bridge with visual assignment

- What it is:
  a mocap bridge receives NatNet rigid bodies, converts coordinate systems,
  lets users assign rigid bodies to tracker IDs, visualizes the environment,
  and sends OSC tracker bundles to VRChat.
- Good for:
  OptiTrack integrations, mocap-to-social-VR experiments, tracker endpoint
  testing, and calibration research.
- Why it matters:
  professional mocap systems still need explicit mapping and calibration before
  they become usable avatar trackers.
- Strong references:
  `VRChatOSCOptitrack`.
- Best fit for `VR-apps-lab`:
  pose-ingress matrices and mocap bridge caveat notes.

## Method 505: Webcam motion and face-recognition to OSC command bridge

- What it is:
  a desktop app maps webcam-derived body, hand, and face cues into OSC movement,
  item-control, jump, look, or avatar expression commands.
- Good for:
  alternate-control accessibility, webcam-only interaction, social VR
  experiments, and gesture-to-OSC prototypes.
- Why it matters:
  vision input should be separated from OSC command mapping so recognition
  models and thresholds can evolve.
- Strong references:
  `VRChat-MotionOSC`.
- Best fit for `VR-apps-lab`:
  alternate input bridge notes and gesture-to-command architecture.

## Method 506: Minimal SteamVR tracker serial config to OSC FBT sender

- What it is:
  a simple script reads configured SteamVR tracker serials, polls OpenVR poses,
  applies a basic offset, and sends each device as `/tracking/trackers/{n}`
  position and rotation messages.
- Good for:
  proof-of-concept FBT bridges, OpenVR pose export references, and minimal OSC
  tracker endpoint examples.
- Why it matters:
  tiny scripts make protocol boundaries easy to inspect even when they are not
  robust product baselines.
- Strong references:
  `quest_steamvr_fbt_tool`.
- Best fit for `VR-apps-lab`:
  simple pose bridge references and tracker endpoint examples.

## Method 507: Camera-calibrated MediaPipe pose landmark to OSC tracker sender

- What it is:
  a camera pipeline captures frames, calibrates cameras, runs pose landmark
  inference, maps landmarks into tracker abstractions, applies offsets, and
  sends hip/feet/head OSC tracker messages.
- Good for:
  camera-based FBT experiments, accessibility tracking, calibration workflow
  research, and vision-based pose bridges.
- Why it matters:
  camera pose tracking is only reusable if calibration and coordinate mapping
  are explicit parts of the workflow.
- Strong references:
  `vrc_osc_tracker`.
- Best fit for `VR-apps-lab`:
  vision-based tracker bridge research and calibration UX comparison.

## Method 508: Local multimodal caption platform with websocket overlay and OSC chatbox fan-out

- What it is:
  a local sidecar accepts speech, OCR, translation, TTS, or AI features and
  exposes results through browser websocket overlays, browser remotes, and
  VRChat OSC chatbox messages.
- Good for:
  accessibility captions, translation overlays, VRChat chatbox helpers, OBS
  browser sources, and multimodal assistant sidecars.
- Why it matters:
  presentation targets should be replaceable even when recognition/model logic
  is heavyweight.
- Source evidence:
  websocket clients, browser remote handlers, `audioWhisper.py`, and
  `VRC_OSCLib.py` in `whispering`.
- Reusable core:
  separate model processing from output transports, pace chatbox writes, expose
  overlay URL flags, and keep browser control messages typed.
- Do not copy directly:
  the full AI/model dependency stack unless the product requires it.
- Strong references:
  `whispering`.
- Best fit for `VR-apps-lab`:
  caption overlay sidecars and VRChat accessibility helper design.

## Method 509: Text-event bus for captions across OBS, browser, VRChat, Twitch, Discord, and TTS targets

- What it is:
  text sources publish normalized events into a central bus, then target
  adapters send final/interim captions to OBS, browser overlays, VRChat, TTS,
  Discord, or stream chat surfaces.
- Good for:
  stream-facing caption tools, multi-target accessibility apps, chat overlays,
  and event-driven UI utilities.
- Why it matters:
  captions need source/target decoupling more than they need one perfect UI.
- Source evidence:
  pubsub, server services, OBS, VRC, and client text elements in `curses`.
- Reusable core:
  define a text event schema, store short history, fan out to target adapters,
  and let each target own timers, emotes, typing state, and visual effects.
- Do not copy directly:
  the whole application shell if only the event model is needed.
- Strong references:
  `curses`.
- Best fit for `VR-apps-lab`:
  caption pipeline architecture and target capability matrices.

## Method 510: Window-capture vision caption loop for VR scene accessibility

- What it is:
  a sidecar captures a VR app's desktop window, runs a vision-caption model on
  frames, and produces natural-language scene descriptions.
- Good for:
  accessibility experiments, AI scene understanding, remote helper overlays,
  and diagnostics summaries.
- Why it matters:
  scene understanding can begin outside the headset if capture, inference, and
  output transport are cleanly separated.
- Source evidence:
  `vision_encoder.py` in `VRChat-to-BLIP`.
- Reusable core:
  locate the target window, capture client-area pixels, run a paced caption
  loop, and route text to a separate presentation/transport layer.
- Do not copy directly:
  GPU assumptions or missing UX/output flow.
- Strong references:
  `VRChat-to-BLIP`.
- Best fit for `VR-apps-lab`:
  accessibility caption experiments and AI scene-awareness sidecars.

## Method 511: Unity Twitch IRC ingress with metadata-aware main-thread queues

- What it is:
  a Unity component owns Twitch IRC connection threads, parses tags/emotes/badges,
  queues messages, and drains them through Unity events on the main thread.
- Good for:
  audience chat panels, stream-facing VR worlds, in-headset chat surfaces, and
  social event widgets.
- Why it matters:
  chat ingress is only useful in Unity when threading and metadata are handled
  before UI code sees messages.
- Source evidence:
  `IRC.cs`, `Chatter.cs`, and `TwitchConnection.*` in `Unity-Twitch-Chat`.
- Reusable core:
  isolate read/write threads, normalize chat metadata, cap per-frame event
  processing, and expose clear connection/chat events.
- Do not copy directly:
  Twitch-only assumptions if the tool needs multi-provider chat.
- Strong references:
  `Unity-Twitch-Chat`.
- Best fit for `VR-apps-lab`:
  audience chat ingress and Unity-side overlay/world text utilities.

## Method 512: External sketch load queue with safe user-sketch copy and command dispatch

- What it is:
  a creative app accepts external sketch-load requests, copies files into a safe
  user-controlled sketch location, and lets normal app commands load the asset.
- Good for:
  creative VR tools, sketch viewers, file-open handlers, and asset import
  companions.
- Why it matters:
  external asset ingestion should not bypass normal app state or save/load
  ownership.
- Source evidence:
  `App.cs` and related editor/API tooling in `open-brush`.
- Reusable core:
  accept outside paths, copy with collision-safe naming, enqueue the request,
  and route through the app's existing load command.
- Do not copy directly:
  the full Open Brush app architecture for a small viewer.
- Strong references:
  `open-brush`.
- Best fit for `VR-apps-lab`:
  creative asset import patterns and Open Brush/Tilt pipeline notes.

## Method 513: Browser viewer metadata restoration for creative VR exports

- What it is:
  a browser viewer loads exported creative assets, restores environment/camera
  metadata, converts coordinate conventions, and supports desktop plus XR
  navigation.
- Good for:
  sketch galleries, web previews, creator portfolios, and lightweight XR asset
  viewers.
- Why it matters:
  exported VR art loses meaning if cameras, lights, sky, and authoring metadata
  are discarded.
- Source evidence:
  `viewer.ts` in `gallery-viewer`.
- Reusable core:
  parse export metadata, recreate scene environment, normalize formats, and
  expose both fly/orbit and XR navigation modes.
- Do not copy directly:
  format support beyond what a product needs.
- Strong references:
  `gallery-viewer`.
- Best fit for `VR-apps-lab`:
  creative asset viewer design and metadata-preserving import paths.

## Method 514: Open Brush/Tilt glTF material extension and shader replacement layer

- What it is:
  a renderer plugin detects Open Brush/Tilt material metadata, maps brush IDs
  and names, loads shaders/textures, and replaces generic glTF materials with
  brush-accurate materials.
- Good for:
  web sketch viewers, glTF export compatibility, shader restoration, and
  creative asset pipelines.
- Why it matters:
  brush-heavy artwork depends on material behavior, not just geometry.
- Source evidence:
  `GOOGLE_tilt_brush_material.js` and `TiltShaderLoader.js` in `three-icosa`.
- Reusable core:
  detect the custom material extension, map brush identifiers, patch texture
  paths, load shader assets asynchronously, and cache material instances.
- Do not copy directly:
  brush asset packaging assumptions without planning distribution.
- Strong references:
  `three-icosa`.
- Best fit for `VR-apps-lab`:
  shader/material compatibility layers for creative VR exports.

## Method 515: Raw `.tilt` zip/binary stroke loader into renderable geometry

- What it is:
  a loader opens `.tilt` archives, parses metadata and binary stroke data, maps
  brush/materials, and emits renderer-native stroke geometry.
- Good for:
  direct sketch previews, converters, import diagnostics, and browser creative
  tools.
- Why it matters:
  direct file loading can avoid heavyweight conversion steps if binary semantics
  are explicit.
- Source evidence:
  `TiltLoader.js` in `three-tiltloader`.
- Reusable core:
  read the archive, parse stroke count/control points, flip coordinates where
  needed, build geometry, and bind brush materials.
- Do not copy directly:
  uncertain mask/offset assumptions without verification.
- Strong references:
  `three-tiltloader`.
- Best fit for `VR-apps-lab`:
  raw creative asset ingestion and loader caveat notes.

## Method 516: Collaborative stroke segment add/remove protocol

- What it is:
  a drawing app treats collaboration as segment-level add/remove messages with
  unique IDs and serialized point arrays.
- Good for:
  collaborative sketch prototypes, networked annotation tools, whiteboards, and
  simple multi-user drawing utilities.
- Why it matters:
  a tiny protocol can validate collaboration concepts before adopting a large
  networking framework.
- Source evidence:
  `Marker.cs`, `World.cs`, and `Peer.cs` in `P2PDraw`.
- Reusable core:
  generate segment IDs, serialize strokes, send add/remove messages, and replay
  existing segments to new peers.
- Do not copy directly:
  old Unity VR API, hardcoded signaling, or checked-in artifact structure.
- Strong references:
  `P2PDraw`.
- Best fit for `VR-apps-lab`:
  collaborative drawing and shared annotation protocol sketches.

## Method 517: Gaussian splat editor with serialized command history and GPU data passes

- What it is:
  a browser editor serializes edit operations through a shared queue while GPU
  passes calculate selection masks, bounds, histograms, and intersections.
- Good for:
  heavy asset editors, splat optimization tools, selection UIs, and browser
  data-processing surfaces.
- Why it matters:
  undo/redo and async GPU work need one ordering boundary or editor state will
  drift.
- Source evidence:
  `edit-history.ts`, `data-processor/index.ts`, and `asset-loader.ts` in
  `supersplat`.
- Reusable core:
  route all edit mutations through a command queue, keep history cursor
  integrity, validate/load splat data, and return owned GPU readback buffers.
- Do not copy directly:
  full editor UI when only data processing is needed.
- Strong references:
  `supersplat`.
- Best fit for `VR-apps-lab`:
  asset editor architecture and Gaussian splat utility matrices.

## Method 518: Static WebXR splat viewer with schema, camera modes, collision, and annotations

- What it is:
  a splat viewer packages scene content and settings as a static site with a
  typed settings schema, URL overrides, WebXR entry, camera modes, collision,
  annotations, and animation tracks.
- Good for:
  shareable spatial captures, splat galleries, immersive scene documentation,
  and lightweight XR asset previews.
- Why it matters:
  portable 3D captures need settings and navigation contracts, not only a file
  loader.
- Source evidence:
  `README.md`, `xr.ts`, `app.ts`, and `camera-manager.ts` in
  `supersplat-viewer`.
- Reusable core:
  define a JSON settings schema, support URL content overrides, gate XR on
  renderer capability, and choose orbit/fly/walk/anim cameras from scene state.
- Do not copy directly:
  WebGPU/WebGL assumptions without checking the target runtime.
- Strong references:
  `supersplat-viewer`.
- Best fit for `VR-apps-lab`:
  static XR viewer patterns and publishable asset surfaces.

## Method 519: Drop-in Gaussian splat renderer library with multi-format loaders and worker sorting

- What it is:
  a Three.js library loads splat formats, can run its own render loop or be
  embedded in another scene, and uses workers/WASM or GPU-assisted paths for
  sorting.
- Good for:
  browser splat apps, mixed Three.js scenes, interactive capture viewers, and
  rendering experiments.
- Why it matters:
  utility apps often need an embeddable renderer rather than a full editor.
- Source evidence:
  `Viewer.js`, loader directories, `WebXRMode.js`, and WebXR button helpers in
  `GaussianSplats3D`.
- Reusable core:
  support self-driven/drop-in modes, format detection, progressive loading,
  external renderer/camera integration, worker sorting, and WebXR mode gates.
- Do not copy directly:
  inactive-maintenance assumptions and known large-scene/mobile caveats.
- Strong references:
  `GaussianSplats3D`.
- Best fit for `VR-apps-lab`:
  browser splat renderer comparisons and viewer prototype options.

## Method 520: Unity Gaussian splat asset/runtime render pipeline with edit/export support

- What it is:
  a Unity package imports splat files into compressed assets, renders them with
  command-buffer/GPU sorting paths, and exposes cutouts, debug modes, editing,
  merging, and export.
- Good for:
  Unity spatial capture viewers, native VR scenes, editor inspection tools, and
  high-performance asset experiments.
- Why it matters:
  splat rendering in Unity is a full asset pipeline, not just a shader.
- Source evidence:
  `GaussianSplatAsset.cs`, `GaussianSplatRenderer.cs`, and `splat-editing.md`
  in `UnityGaussianSplatting`.
- Reusable core:
  choose asset compression formats, gather active renderers per camera, sort
  splats, draw procedurally, support cutouts/selection, and export modified PLY.
- Do not copy directly:
  graphics API assumptions or data-license blind spots.
- Strong references:
  `UnityGaussianSplatting`.
- Best fit for `VR-apps-lab`:
  Unity splat runtime comparisons and editor utility references.

## Method 521: Native CUDA/OpenXR Unity plugin boundary for VR Gaussian splat rendering

- What it is:
  Unity owns scene/menu/controller UX while a native plugin owns CUDA model
  loading, render contexts, texture/depth interop, preprocessing, and drawing.
- Good for:
  high-performance native render experiments, VR capture viewers, and native
  plugin boundary studies.
- Why it matters:
  native renderers need a clean API surface or the Unity side becomes fragile.
- Source evidence:
  `GaussianSplatting.cpp` and `PluginAPI.cpp` in
  `GaussianSplattingVRViewerUnity`.
- Reusable core:
  expose load/copy/remove model APIs, create per-POV render contexts, map native
  textures/depth, set draw parameters, preprocess, draw, and keep errors
  inspectable.
- Do not copy directly:
  CUDA-only implementation without target-hardware justification.
- Strong references:
  `GaussianSplattingVRViewerUnity`.
- Best fit for `VR-apps-lab`:
  native plugin architecture notes and VR splat viewer caveats.

## Method 522: Unity VFX Graph splat data binder substrate

- What it is:
  a ScriptableObject stores splat arrays, lazily creates graphics buffers, and a
  VFX binder injects splat count, positions, axes, and colors into VFX Graph.
- Good for:
  visual experiments, shader/VFX prototypes, point effects, and quick Unity
  splat demonstrations.
- Why it matters:
  VFX Graph can be a substrate for exploration even when it is not a production
  renderer.
- Source evidence:
  `SplatData.cs`, `SplatDataBinder.cs`, importer, and VFX assets in
  `SplatVFX`.
- Reusable core:
  keep CPU arrays in a data asset, allocate buffers on demand, bind them to VFX
  properties, and release GPU resources cleanly.
- Do not copy directly:
  projection algorithm or artifact-prone renderer as product baseline.
- Strong references:
  `SplatVFX`.
- Best fit for `VR-apps-lab`:
  visual-effect experiments and Unity buffer binding examples.

## Method 523: Godot XR function-node toolkit with exported configuration and warnings

- What it is:
  Godot XR capabilities are packaged as scene nodes with exported properties,
  action names, collision masks, configuration warnings, and helper scene
  creation.
- Good for:
  Godot VR utilities, interaction prototypes, locomotion modules, hand tools,
  and reusable scene packs.
- Why it matters:
  Godot reuse often works best as composable nodes rather than one central
  manager.
- Source evidence:
  `movement_provider.gd`, `function_pointer.gd`, `function_pickup.gd`, and
  `function_teleport.gd` in `godot-xr-tools`.
- Reusable core:
  define one function per node, expose settings, validate scene placement, wire
  controller signals, and separate movement providers from player-body motion.
- Do not copy directly:
  every toolkit node into small utilities.
- Strong references:
  `godot-xr-tools`.
- Best fit for `VR-apps-lab`:
  Godot XR utility samples and toolkit composition matrices.

## Method 524: Godot OpenXR vendor extension package with export feature gates

- What it is:
  a GDExtension package exposes vendor OpenXR extensions through wrapper
  classes, project settings, export options, Android package features, docs,
  and small samples.
- Good for:
  vendor capability diagnostics, Meta/Pico/Android XR/HTC feature helpers,
  Godot XR prototypes, and export-check tools.
- Why it matters:
  vendor features need build/export gates as much as runtime API wrappers.
- Source evidence:
  export plugins, extension wrappers, doc classes, Android XR headers, and
  performance metrics sample in `godot_openxr_vendors`.
- Reusable core:
  request extensions, bind engine-facing classes, generate export options,
  prevent incompatible vendor toggles, expose feature manifests, and provide
  small diagnostics samples.
- Do not copy directly:
  vendor code without licensing and runtime capability checks.
- Strong references:
  `godot_openxr_vendors`.
- Best fit for `VR-apps-lab`:
  Godot vendor extension matrices and capability diagnostic helpers.

## Method 525: Godot XR product-template shell with persistence, staging, HUD, and pause menu

- What it is:
  a sample game composes XR toolkit modules with persistent world state,
  staging/scene transitions, HUD signal bindings, pause menu actions, and
  save/load flows.
- Good for:
  Godot XR starter apps, utility shells, game-like tools, and interaction demos.
- Why it matters:
  reusable toolkit nodes become product-ready only when the surrounding state,
  UI, and scene lifecycle are demonstrated.
- Source evidence:
  `game_state.gd`, `persistent_world.gd`, `pause_menu_3d.gd`, and
  `status_hud.gd` in `godot-xr-dungeon-template`.
- Reusable core:
  keep global state in an autoload, emit UI signals, save zone/player transform,
  stage scene transitions, and make pause/save/quit actions headset-friendly.
- Do not copy directly:
  bundled assets and dependency copies.
- Strong references:
  `godot-xr-dungeon-template`.
- Best fit for `VR-apps-lab`:
  Godot XR sample shell and stateful utility app patterns.

## Method 526: GDExtension OpenXR face-tracking bridge to engine-native face tracker

- What it is:
  a focused GDExtension requests a vendor face-tracking extension, manages
  session tracker handles, reads expression weights, maps them to engine blend
  shape slots, and registers an engine face tracker.
- Good for:
  face tracking bridges, vendor extension learning, avatar expression tools,
  and Godot XR diagnostics.
- Why it matters:
  small bridges show the lifecycle boundary between OpenXR extension data and
  engine-native tracker abstractions.
- Source evidence:
  `openxr_htc_facial_tracking_extension.cpp` and `.h` in
  `godot-htc-face-tracking-bridge`.
- Reusable core:
  request extension flags, create/destroy tracker handles with the session,
  query predicted display time, read expression weights, map unsupported values
  explicitly, and register an `XRFaceTracker`.
- Do not copy directly:
  generic template README scaffolding or duplicate upstream vendor support.
- Strong references:
  `godot-htc-face-tracking-bridge`.
- Best fit for `VR-apps-lab`:
  Godot face-tracking bridge notes and extension lifecycle references.

## Method 527: Viewport-to-mesh VR UI interaction with synthetic mouse events

- What it is:
  a VR controller ray hits a 3D mesh hosting a viewport, converts the world hit
  point into viewport coordinates, synthesizes mouse motion/button events, and
  sends them into the embedded UI.
- Good for:
  VR menus, in-world panels, legacy toolkit comparisons, and engine-agnostic UI
  interaction notes.
- Why it matters:
  2D UI in 3D remains one of the simplest useful VR utility surfaces.
- Source evidence:
  `GuiInteraction.gd`, `ViewportToMesh.gd`, `RayTeleport.gd`, and
  `VRInteractable.gd` in `godot-vr-toolkit`.
- Reusable core:
  raycast from controller, orient hit markers, convert 3D hit points via mesh
  transform to normalized UI coordinates, synthesize mouse events, and feed the
  viewport.
- Do not copy directly:
  old Godot 3/OpenVR dependencies and bundled binaries.
- Strong references:
  `godot-vr-toolkit`.
- Best fit for `VR-apps-lab`:
  VR menu/input primitives and legacy-to-modern Godot XR comparisons.

## Method 528: Bevy OpenXR render-plugin lifecycle with manual wgpu handoff

- What it is:
  an OpenXR plugin initializes the runtime, session, graphics binding, and
  wgpu device/queue, then injects those objects into Bevy's render world and
  schedules frame wait, view location, swapchain, and end-frame work.
- Good for:
  Rust XR app shells, Bevy utility prototypes, and custom engine/plugin
  boundary studies.
- Why it matters:
  engine integration is mostly ownership and scheduling; hiding it makes XR
  bugs hard to diagnose.
- Source evidence:
  `bevy_oxr`.
- Reusable core:
  initialize OpenXR before rendering, create graphics-bound wgpu resources,
  expose session/frame/view resources explicitly, and keep swapchain wait,
  image release, and end-frame stages inspectable.
- Do not copy directly:
  version-sensitive Bevy/wgpu plugin internals.
- Strong references:
  `awtterpip/bevy_oxr`.
- Best fit for `VR-apps-lab`:
  Rust/Bevy OpenXR app-shell notes and diagnostics prototypes.

## Method 529: Context-split Rust XR engine with focused-state tick loop

- What it is:
  a Rust VR engine constructs XR, Vulkan, render, input, GUI, audio, haptics,
  physics, and ECS contexts separately, then updates views/input only when the
  OpenXR session is focused.
- Good for:
  minimal XR engines, embedded app shells, and runtime bring-up testbeds.
- Why it matters:
  explicit context ownership makes complex XR loops easier to test and replace.
- Source evidence:
  `hotham/src/engine.rs`.
- Reusable core:
  construct contexts in dependency order, create durable stage/HMD entities,
  process runtime events, gate input/view updates by session focus, and keep
  world state separate from runtime handles.
- Do not copy directly:
  full engine assumptions when a small utility only needs a subset.
- Strong references:
  `leetvr/hotham`.
- Best fit for `VR-apps-lab`:
  OpenXR utility runtime shells and Rust engine architecture comparisons.

## Method 530: OpenXR runtime stub through loader negotiation and function shims

- What it is:
  a test/runtime harness implements loader negotiation and returns function
  pointers for OpenXR calls such as instance/session/frame/input functions.
- Good for:
  OpenXR loader experiments, tests, diagnostics, and headsetless bring-up
  harnesses.
- Why it matters:
  runtime stubs let tools validate loader behavior without relying on a full
  headset/runtime stack.
- Source evidence:
  `hotham-openxr-client/src/lib.rs`.
- Reusable core:
  implement `xrNegotiateLoaderRuntimeInterface`, dispatch requested functions
  through a controlled table, and stub enough frame/session/input behavior to
  exercise clients.
- Do not copy directly:
  incomplete runtime behavior as if it were a conformant runtime.
- Strong references:
  `leetvr/hotham`.
- Best fit for `VR-apps-lab`:
  headsetless workflow notes and OpenXR diagnostic harness ideas.

## Method 531: Explicit wgpu/OpenXR/Vulkan graphics binding bridge

- What it is:
  an app lets OpenXR create or validate Vulkan graphics objects, then bridges
  those objects into wgpu for rendering.
- Good for:
  minimal render samples, graphics diagnostics, and runtime capability tests.
- Why it matters:
  graphics binding order is a frequent source of OpenXR bring-up failures.
- Source evidence:
  `wgpu-example/src/xr.rs`.
- Reusable core:
  require `KHR_vulkan_enable2`, query graphics requirements, create compatible
  Vulkan instance/device through runtime-aware paths, bridge the physical device
  to wgpu HAL, and create XR swapchains deliberately.
- Do not copy directly:
  unsafe sample code without a targeted graphics validation plan.
- Strong references:
  `matthewjberger/wgpu-example`.
- Best fit for `VR-apps-lab`:
  OpenXR graphics doctor and wgpu bring-up checklist.

## Method 532: Live network data to XR panels with ray-to-UI pointer forwarding

- What it is:
  a live data viewer discovers network sources, ingests packets, normalizes
  state, renders XR panels, and forwards controller-ray hits into UI textures.
- Good for:
  telemetry dashboards, robot/control panels, simulator views, and diagnostics.
- Why it matters:
  many useful VR tools are spatial dashboards over live external state.
- Source evidence:
  `xrvis`.
- Reusable core:
  refresh network interfaces, ingest UDP/WebSocket/protobuf streams, spawn
  anchored panels, sort pointer hits by distance, convert ray hits into UI
  pointer events, and retain focus during drag interactions.
- Do not copy directly:
  domain-specific robot soccer protocol logic.
- Strong references:
  `robotics-erlangen/xrvis`.
- Best fit for `VR-apps-lab`:
  live telemetry and control-panel utility concepts.

## Method 533: VR injector callback SDK with engine/render/input/script hooks

- What it is:
  an injector exposes a structured API of lifecycle callbacks, render/runtime
  handles, engine events, input events, native hook points, and script bindings.
- Good for:
  understanding retrofit ecosystems and designing safe extension APIs.
- Why it matters:
  even if injection is avoided, the callback taxonomy is useful for plugin API
  design.
- Source evidence:
  `UEVR/include/uevr/API.h`.
- Reusable core:
  version the API, group callbacks by lifecycle stage, expose handles through
  controlled accessors, and keep scripting/custom event surfaces separate from
  native hooks.
- Do not copy directly:
  process injection or game hook logic.
- Strong references:
  `praydog/UEVR`.
- Best fit for `VR-apps-lab`:
  safe extension-surface and compatibility-boundary documentation.

## Method 534: Graphics hook coexistence with temporary unhook/restore

- What it is:
  a graphics hook temporarily removes its own hook while creating a device or
  swapchain, then restores it to avoid recursive hook conflicts and coexist with
  other overlays/mods.
- Good for:
  capture tools, overlays, diagnostics, and modding compatibility analysis.
- Why it matters:
  graphics hooks often fail by fighting each other rather than by rendering
  incorrectly.
- Source evidence:
  `REFramework/src/D3D11Hook.cpp`.
- Reusable core:
  make hook install/remove idempotent, guard present/resize callbacks, use
  mutexes where needed, and treat other overlays as expected neighbors.
- Do not copy directly:
  invasive hook internals into ordinary VR utilities.
- Strong references:
  `praydog/REFramework`.
- Best fit for `VR-apps-lab`:
  overlay compatibility and graphics-hook safety notes.

## Method 535: VR mod manager manifest with provider discovery and compatibility database

- What it is:
  a manager discovers installed games through providers, models mods through
  declarative manifests, and records compatibility/install state in a database.
- Good for:
  utility managers, compatibility launchers, mod/package catalogs, and helper
  installers.
- Why it matters:
  compatibility knowledge should live in data rather than ad-hoc code paths.
- Source evidence:
  `rai-pal`.
- Reusable core:
  separate game discovery from mod metadata, use stable installed-game IDs,
  declare install/extract/write actions, model dependencies and environment
  overrides, and track installed/outdated/compatible state.
- Do not copy directly:
  mod data without license and safety review.
- Strong references:
  `Raicuparta/rai-pal`.
- Best fit for `VR-apps-lab`:
  non-invasive VR utility manager schemas.

## Method 536: Unity XR subsystem injection bundle with UI redirection

- What it is:
  a Unity retrofit copies coherent XR subsystem/plugin bundles, removes stale
  loaders, patches global VR settings, and redirects legacy screen-space UI into
  VR-visible render targets.
- Good for:
  understanding Unity XR loader boundaries and owned-project UI migration.
- Why it matters:
  screen-space UI is a major obstacle when converting flat Unity apps to VR.
- Source evidence:
  `uuvr`.
- Reusable core:
  treat XR loaders as bundles, clean stale plugin files first, patch settings
  deliberately, capture canvases through cameras/render textures, and redirect
  mirror output where needed.
- Do not copy directly:
  patching third-party game files.
- Strong references:
  `Raicuparta/uuvr`.
- Best fit for `VR-apps-lab`:
  Unity UI-to-VR migration notes and injector caveats.

## Method 537: Unity VR safe-mode gate with backend selection and scene reinit

- What it is:
  a Unity VR mod starts in a safe mode, delays VR initialization until allowed,
  selects an OpenVR/OpenXR backend, and invalidates/reinitializes on scene
  changes.
- Good for:
  compatibility-sensitive VR utilities and retrofit prototypes.
- Why it matters:
  safe startup can prevent a broken VR path from trapping the user.
- Source evidence:
  `UnityVRMod`.
- Reusable core:
  expose safe mode, make backend selection explicit, delay first VR init,
  invalidate camera/backend state on scene changes, and provide teardown levels.
- Do not copy directly:
  BepInEx/game injection scaffolding.
- Strong references:
  `NewUnityModder/UnityVRMod`.
- Best fit for `VR-apps-lab`:
  VR startup safety checklists.

## Method 538: Game-specific VR mod startup gates and patch groups

- What it is:
  a game VR mod uses disable flags, user prompts, game version/hash checks,
  dependency preload, asset loading, and scoped patch groups before enabling VR.
- Good for:
  compatibility doctors, safe patchers, and risky runtime helpers.
- Why it matters:
  users need clear exit paths and compatibility failures before runtime patches
  begin.
- Source evidence:
  `LCVR` and `RepoXR`.
- Reusable core:
  provide hard disable flags, ask before enabling, verify game/runtime support,
  preload dependencies, separate universal and VR-only patches, and show visible
  errors when critical patches fail.
- Do not copy directly:
  game-specific Harmony patches, bypasses, or offsets.
- Strong references:
  `DaXcess/LCVR`, `DaXcess/RepoXR`.
- Best fit for `VR-apps-lab`:
  compatibility gate templates and diagnostic UX.

## Method 539: Attribute-driven VR network RPC patch registration

- What it is:
  VR-specific network/RPC patches are marked with attributes and registered as
  a distinct compatibility surface.
- Good for:
  networked mod tooling, compatibility auditing, and patch organization.
- Why it matters:
  network-facing VR changes deserve extra visibility and failure handling.
- Source evidence:
  `RepoXR`.
- Reusable core:
  mark special patches declaratively, scan/register them separately, and warn
  users when network compatibility patches fail.
- Do not copy directly:
  game-specific RPC patches.
- Strong references:
  `DaXcess/RepoXR`.
- Best fit for `VR-apps-lab`:
  patch metadata patterns and compatibility documentation.

## Method 540: Calibrated passthrough-camera ArUco marker pose pipeline

- What it is:
  a headset passthrough camera supplies intrinsics and frames, OpenCV detects
  markers, and marker poses update scene objects.
- Good for:
  calibration helpers, MR alignment, diagnostics, and marker-anchored tools.
- Why it matters:
  reliable marker tracking depends on intrinsics and coordinate handling, not
  only detection.
- Source evidence:
  `QuestArUcoMarkerTracking`.
- Reusable core:
  scale camera intrinsics to active resolution, configure detector/refinement
  parameters, estimate marker pose, and map marker IDs to GameObjects.
- Do not copy directly:
  vendor-specific camera access without capability checks.
- Strong references:
  `TakashiYoshinaga/QuestArUcoMarkerTracking`.
- Best fit for `VR-apps-lab`:
  passthrough marker calibration tools.

## Method 541: Vendor marker-callback scene-object map

- What it is:
  a headset/vendor SDK emits marker ID and pose callbacks, and the app updates
  scene objects directly from those callbacks.
- Good for:
  vendor-specific marker tools, device comparisons, and MR utilities.
- Why it matters:
  callbacks can simplify marker tracking but need a portability boundary.
- Source evidence:
  `picoxr/ArUcoMarkerTracking`.
- Reusable core:
  initialize the vendor service, register marker callbacks with explicit origin
  mode, enable/restore seethrough, and maintain a marker ID to object map.
- Do not copy directly:
  bundled SDK state or vendor APIs into generic utilities.
- Strong references:
  `picoxr/ArUcoMarkerTracking`.
- Best fit for `VR-apps-lab`:
  marker-tracking device matrices.

## Method 542: Remote hand-data split transport

- What it is:
  high-frequency hand poses are sent over UDP while large skeleton/mesh data is
  sent over reliable length-prefixed TCP packets.
- Good for:
  hand tracking bridges, remote preview, capture tools, and diagnostics.
- Why it matters:
  one transport rarely fits both low-latency pose updates and heavy structural
  hand data.
- Source evidence:
  `Unity.QuestRemoteHandTracking`.
- Reusable core:
  split pose and skeleton/mesh channels, frame TCP packets with lengths, queue
  network data off-thread, and emit Unity events on the main thread.
- Do not copy directly:
  dated XML/OVRPlugin implementation without modernization.
- Strong references:
  `handzlikchris/Unity.QuestRemoteHandTracking`.
- Best fit for `VR-apps-lab`:
  hand-data bridge protocol comparisons.

## Method 543: Unity ArUco calibration package architecture

- What it is:
  a Unity package abstracts camera sources, collects marker/ChArUco
  observations, runs calibration, and stores camera parameters.
- Good for:
  calibration wizards, marker utilities, and multi-camera tools.
- Why it matters:
  calibration is a workflow and data model, not just a detector call.
- Source evidence:
  `ArucoUnity`.
- Reusable core:
  separate camera abstraction, board definitions, observation buffers,
  asynchronous calibration, minimum-observation checks, and timestamped camera
  parameter persistence.
- Do not copy directly:
  old Unity/OpenCV package assumptions.
- Strong references:
  `NormandErwan/ArucoUnity`.
- Best fit for `VR-apps-lab`:
  marker calibration helper designs.

## Method 544: HoloLens research-mode marker pose with camera-to-world composition

- What it is:
  HoloLens spatial camera frames and intrinsics feed marker detection, and
  marker-to-camera pose is composed with camera-to-world transforms.
- Good for:
  HoloLens diagnostics, AR calibration, and coordinate-frame references.
- Why it matters:
  most marker tracking bugs are coordinate-frame bugs.
- Source evidence:
  `HoloLens2CVExperiments`.
- Reusable core:
  initialize spatial cameras, load intrinsics per sensor, detect markers,
  estimate pose, compose camera/world transforms, and expose HUD diagnostics.
- Do not copy directly:
  HoloLens-only setup into portable headset tools.
- Strong references:
  `nooway077/HoloLens2CVExperiments`.
- Best fit for `VR-apps-lab`:
  coordinate-frame and marker-tracking comparison notes.

## Method 545: Docs-first XR instrumentation recorder/viewer workflow

- What it is:
  a research toolbox presents recording, portable session files, asset bundles,
  replay viewer, event markers, and physiological timelines as one user
  workflow.
- Good for:
  study tools, replayable diagnostics, and product documentation.
- Why it matters:
  users understand instrumentation through workflows, not raw data formats.
- Source evidence:
  `PLUME`.
- Reusable core:
  provide low-friction recorder install, portable record files, independent
  viewer playback, camera switching, timeline controls, marker lists, and
  physiological streams.
- Do not copy directly:
  implementation claims without source/source-license confirmation.
- Strong references:
  `liris-xr/PLUME`.
- Best fit for `VR-apps-lab`:
  XR instrumentation docs and replay UX concepts.

## Method 546: Unity XR behavioral recording/replay with metadata and analysis surfaces

- What it is:
  a Unity package discovers tracked XR objects, records object/event metadata
  into CSV files, and replays sessions with clones, gaze, trajectories, and
  heatmaps.
- Good for:
  study prototypes, replayable debugging, and in-situ analysis.
- Why it matters:
  replayable VR state can turn invisible interaction problems into inspectable
  artifacts.
- Source evidence:
  `XREcho`.
- Reusable core:
  track camera/controllers/interactables/layers, store format files separately
  from data, log scene-load/events, clone tracked objects for replay, and expose
  trajectory/gaze/heatmap UI.
- Do not copy directly:
  singleton-heavy old code without modernization.
- Strong references:
  `liris-xr/XREcho`.
- Best fit for `VR-apps-lab`:
  replayable diagnostics and Unity instrumentation samples.

## Method 547: Olfactory display bridge from Unity scene logic to physical device commands

- What it is:
  Unity sends semantic odor/diffusion commands to a hardware diffuser through
  serial communication or an Android plugin.
- Good for:
  multisensory XR, physical-output bridges, and experiment control.
- Why it matters:
  VR utilities can control physical devices, not only render overlays.
- Source evidence:
  `Nebula-Core`.
- Reusable core:
  discover the device by handshake, map semantic commands to low-level device
  codes, support Windows/editor and Android paths, clean up output on quit, and
  keep UI override separate from automatic behavior.
- Do not copy directly:
  blocking serial loops, thread aborts, or device-specific commands.
- Strong references:
  `liris-xr/Nebula-Core`.
- Best fit for `VR-apps-lab`:
  physical-output bridge patterns beyond haptics.

## Method 548: Proximity-driven multisensory behavior with experiment CSV logging

- What it is:
  virtual objects trigger and modulate physical output based on head proximity,
  while experiment trial state is pseudo-randomized and logged to CSV.
- Good for:
  multisensory studies, training, accessibility experiments, and physical
  output UX.
- Why it matters:
  physical feedback should be tied to scene semantics and measurable events.
- Source evidence:
  `Nebula-Core`.
- Reusable core:
  attach trigger colliders to the head/player, modulate duty cycle by distance
  or binary mode, allow GUI override, reset scene objects, and log trial IDs,
  detected times, ratings, and notation times.
- Do not copy directly:
  device-specific PWM assumptions.
- Strong references:
  `liris-xr/Nebula-Core`.
- Best fit for `VR-apps-lab`:
  multisensory XR experiment patterns.

## Method 549: Modular sparse-camera mocap reconstruction pipeline

- What it is:
  a configurable pipeline processes multiple RGB camera views through detection,
  calibration, triangulation, bundle adjustment, timing annotations, and motion
  reconstruction.
- Good for:
  mocap import helpers, avatar animation preparation, and external camera
  capture utilities.
- Why it matters:
  mocap can feed VR tools even when the capture tool is not itself an HMD app.
- Source evidence:
  `kineo`.
- Reusable core:
  define typed pipeline stages, instantiate them from config, load live/offline
  camera views, validate calibration annotations, triangulate weighted points,
  run bundle adjustment, and record per-stage timings.
- Do not copy directly:
  heavy ML stack, datasets, checkpoints, or non-commercial research code.
- Strong references:
  `liris-xr/kineo`.
- Best fit for `VR-apps-lab`:
  motion-capture helper and export/import planning.

## Method 550: Motion export helper stages for BVH, USD, and viewer artifacts

- What it is:
  reconstructed motion and camera data are exported to interchange/viewer
  formats such as BVH, USD, and Rerun-style visualization outputs.
- Good for:
  Unity/Unreal import, Blender review, avatar animation, and diagnostics.
- Why it matters:
  capture is only reusable when outputs fit the rest of the toolchain.
- Source evidence:
  `kineo/pipeline/stages/bvh/export_bvh.py` and
  `kineo/pipeline/stages/export_to_usd.py`.
- Reusable core:
  derive FPS from global timestamps, filter frame ranges, convert coordinates
  intentionally, export skeleton hierarchy and root motion, and keep output path
  templates configurable.
- Do not copy directly:
  SMPL/model-dependent export code without license and dependency review.
- Strong references:
  `liris-xr/kineo`.
- Best fit for `VR-apps-lab`:
  motion export/import utility branches and format comparison notes.

## Method 551: Electron offscreen shared-texture OpenVR overlay lifecycle

- What it is:
  an Electron window renders offscreen, exposes a native shared texture handle,
  and a small OpenVR native addon submits that texture as an interactive overlay.
- Good for:
  browser-backed dashboards, chat/media panels, developer overlays, and fast UI
  iteration.
- Why it matters:
  web UI can become a VR overlay if the pixel-transfer and lifecycle boundary is
  explicit.
- Source evidence:
  `react-electron-openvr`.
- Reusable core:
  create a transparent offscreen `BrowserWindow`, enable shared texture
  painting, submit the native handle to OpenVR, configure mouse scale/input
  mode, and drive create/update/remove through declarative UI props.
- Do not copy directly:
  Windows-only shared texture assumptions or arbitrary web content without a
  secure preload boundary.
- Strong references:
  `imagitama/react-electron-openvr`.
- Best fit for `VR-apps-lab`:
  browser-backed overlay shell prototypes.

## Method 552: Injected overlay surface IPC with explicit input controls

- What it is:
  a host injects a helper into a target process and controls window surfaces
  through typed IPC commands for position, shared handles, input listening, and
  cursor blocking.
- Good for:
  architecture comparison, overlay manager API design, and high-risk game
  overlay research.
- Why it matters:
  even risky overlay paths expose reusable command boundaries.
- Source evidence:
  `steamvr-overlay`.
- Reusable core:
  model each surface with a window ID, separate texture updates from pose/margin
  updates, expose input listen/block as explicit commands, and keep forwarding
  errors visible.
- Do not copy directly:
  process injection or anti-cheat-sensitive hooks into safe companion tools.
- Strong references:
  `KotRikD/steamvr-overlay`.
- Best fit for `VR-apps-lab`:
  overlay engine contract and risk taxonomy.

## Method 553: Flag-gated modular SteamVR driver/overlay utility host

- What it is:
  one driver/overlay umbrella hosts multiple utility modules, enabling them
  through marker files, safety checks, per-module IPC, logs, and UI tabs.
- Good for:
  utility suites, driver-side helpers, experimental feature rollout, and
  operator-facing diagnostics.
- Why it matters:
  many small VR utilities are safer when they share one controlled host instead
  of multiplying fragile runtime components.
- Source evidence:
  `WKOpenVR`.
- Reusable core:
  define a feature plugin interface, gate modules through explicit flags,
  isolate module pipes/channels, auto-disable suspicious/stale states, and show
  module status/logs inside one overlay.
- Do not copy directly:
  driver-specific internals or hook-heavy modules without review.
- Strong references:
  `RealWhyKnot/WKOpenVR`.
- Best fit for `VR-apps-lab`:
  modular overlay/runtime helper shell designs.

## Method 554: External editor plus OpenXR layer engine for captured overlay sources

- What it is:
  a desktop editor owns layouts and source configuration while an OpenXR API
  layer captures hidden browser/windows, composes quad layers, and receives
  commands through a bounded pipe protocol.
- Good for:
  serious overlay managers, simulator dashboards, race/flight utility panels,
  and external-source VR placement.
- Why it matters:
  high-quality overlay tools often need an editor/runtime split rather than a
  monolithic in-headset app.
- Source evidence:
  `Honey_Overlays`.
- Reusable core:
  keep the editor out of the XR process, send length-prefixed JSON commands,
  spawn hidden browser hosts per source, capture windows into D3D textures,
  compose OpenXR quad layers, and provide in-headset grab/scale/opacity/cycle
  placement controls.
- Do not copy directly:
  game-specific gates, Windows-only capture assumptions, or D3D-specific code
  without an abstraction boundary.
- Strong references:
  `Alphasumsi/Honey_Overlays`.
- Best fit for `VR-apps-lab`:
  overlay manager architecture notes and future editor-driven overlay
  prototypes.

## Method 555: OpenXR runtime-side adapter layer for external tracking data

- What it is:
  an API layer receives external protocol data and answers standard OpenXR
  extension calls from cached normalized state.
- Good for:
  eye/face tracking adapters, hand/body data bridges, diagnostics, and runtime
  compatibility experiments.
- Why it matters:
  a runtime-facing adapter can make app compatibility better than app-specific
  OSC integrations.
- Source evidence:
  `openxr_oscclient`.
- Reusable core:
  negotiate as an API layer, filter self-provided extension names, receive
  external data on a background thread, normalize/clamp values, guard state with
  locks, and answer extension functions from the cached state.
- Do not copy directly:
  fixed ports, undocumented OSC schemas, or extension-provider conflicts.
- Strong references:
  `LordOfDragons/openxr_oscclient`.
- Best fit for `VR-apps-lab`:
  OpenXR face/eye adapter and layer-conflict documentation.

## Method 556: Runtime-side hand-joint transform correction layer

- What it is:
  an OpenXR API layer intercepts hand-joint location calls and applies a
  calibration transform to every returned joint pose.
- Good for:
  headsetless workflows, desk-mounted hand tracking, calibration helpers, and
  input adaptation tools.
- Why it matters:
  coordinate corrections can be isolated at the runtime boundary instead of
  patched into every application.
- Source evidence:
  `OpenXR-Hand-Transform-Offset-Layer`.
- Reusable core:
  load a small calibration profile, periodically reload changes, intercept
  `xrLocateHandJointsEXT`, rotate/translate joint positions and orientations,
  and keep the layer narrow.
- Do not copy directly:
  hardcoded desk-tracker assumptions or text-file-only UX.
- Strong references:
  `CraigMason/OpenXR-Hand-Transform-Offset-Layer`.
- Best fit for `VR-apps-lab`:
  hand tracking calibration micro-layer concepts.

## Method 557: Graphics compatibility API layer with frontend/backend swapchain wrappers

- What it is:
  an OpenXR API layer substitutes unsupported graphics bindings with a supported
  backend and wraps sessions/swapchains to bridge acquire/release behavior.
- Good for:
  graphics compatibility research, runtime diagnostics, and understanding
  rendering boundary risks.
- Why it matters:
  graphics-binding gaps can sometimes be bridged, but only with careful wrapper
  ownership and synchronization.
- Source evidence:
  `sorenon_openxr_layer`.
- Reusable core:
  detect runtime capabilities, replace requested graphics extensions, wrap
  session graphics state, maintain swapchain wrapper registries, and translate
  frontend release paths into backend resource operations.
- Do not copy directly:
  experimental synchronization paths, `glFinish`, `vkQueueWaitIdle`, or
  TODO-heavy compatibility logic.
- Strong references:
  `Sorenon/sorenon_openxr_layer`.
- Best fit for `VR-apps-lab`:
  rendering adaptation matrices and diagnostic notes.

## Method 558: Anchor-relative shared scene serialization

- What it is:
  a shared spatial anchor is created and shared first, then scene objects are
  serialized relative to that anchor for colocated reconstruction.
- Good for:
  colocated MR utilities, shared scene previews, calibration snapshots, and
  semantic-room tools.
- Why it matters:
  relative-to-anchor scene data is more portable than assuming stable global
  coordinates.
- Source evidence:
  `Unreal-SharedSceneSample`.
- Reusable core:
  share the anchor before scene data, store object labels, mesh references, and
  transforms relative to the shared anchor, multicast reconstruction data, and
  expose visibility toggles by semantic label.
- Do not copy directly:
  sample-only networking or platform-specific scene APIs without abstraction.
- Strong references:
  `oculus-samples/Unreal-SharedSceneSample`.
- Best fit for `VR-apps-lab`:
  colocation and anchor persistence notes.

## Method 559: Localization-gated spatial anchor persistence with binding storage

- What it is:
  content bindings are saved against spatial anchor IDs, and anchor queries are
  performed only when localization/head-pose state is valid.
- Good for:
  spatial-anchor utilities, persistence tools, content restore flows, and
  vendor anchor comparisons.
- Why it matters:
  persistent anchors fail as product UX unless localization, query cadence, and
  binding state are explicit.
- Source evidence:
  `SpatialAnchorsExample` and `MagicLeapSpatialAnchors`.
- Reusable core:
  listen for localization and anchor events, clear/reload state on space
  changes, run anchor queries off the main thread, save anchor-to-content
  bindings in local JSON, handle publish/query/delete callbacks, and display
  tracking confidence/status.
- Do not copy directly:
  vendor-specific storage APIs without a portability boundary.
- Strong references:
  `magicleap/SpatialAnchorsExample`,
  `dilmerv/MagicLeapSpatialAnchors`.
- Best fit for `VR-apps-lab`:
  spatial-anchor lifecycle and persistence matrices.

## Method 560: VRChat OSC diagnostic and parameter browser surfaces

- What it is:
  small companion tools listen to OSC or discover OSCQuery services, then show
  live avatar parameters, values, types, and statuses in a table, tree, or web
  panel.
- Good for:
  OSC doctors, avatar parameter debugging, creator support, and companion
  utility dashboards.
- Why it matters:
  VRChat OSC work becomes much easier when parameter state is visible and
  filterable.
- Source evidence:
  `VRChatOSCDebugger`, `VRChatOscDebugger`, and `VRChat-OSC-WebPanel`.
- Reusable core:
  support passive wildcard listening for live values, OSCQuery discovery for
  schemas, avatar JSON loading for parameter metadata, ignore/filter controls,
  copy/export actions, and web or desktop parameter panels.
- Do not copy directly:
  unauthenticated web panels, incomplete write controls, or hardcoded local
  paths without warnings.
- Strong references:
  `firocore/VRChatOSCDebugger`,
  `Misaka-L/VRChatOscDebugger`,
  `networkpenetrationtester/VRChat-OSC-WebPanel`.
- Best fit for `VR-apps-lab`:
  VRChat OSC doctor and parameter browser prototype planning.

## Method 561: Sensor and finger data to VRChat avatar-parameter bridge

- What it is:
  external sensor streams are converted into avatar parameters with raw values,
  normalized values, status booleans, heartbeat signals, and optional SDK/plugin
  ingress.
- Good for:
  biometric avatars, hand/finger tracking, accessibility status indicators,
  stream avatars, and device diagnostics.
- Why it matters:
  a reusable sensor bridge schema makes many one-off OSC tools easier to design
  consistently.
- Source evidence:
  `leapmotion-osc` and `HRtoVRChat_OSC`.
- Reusable core:
  separate sensor managers from OSC writers, publish connected/active/heartbeat
  booleans, normalize raw values into avatar-safe ranges, reset parameters on
  shutdown, expose source names/status to helper UIs, and allow plugins through
  a constrained SDK or network protocol.
- Do not copy directly:
  broad plugin loading, service-specific endpoints, or unsmoothed raw sensor
  values without calibration.
- Strong references:
  `ThatGuyThimo/leapmotion-osc`,
  `200Tigersbloxed/HRtoVRChat_OSC`.
- Best fit for `VR-apps-lab`:
  sensor-to-avatar bridge schema and small OSC bridge templates.

## Method 562: Source-first camera-to-expression tracking pipeline

- What it is:
  a companion app turns headset-mounted camera frames into expression or gaze
  values through ROI transforms, model/pupil inference, calibration, smoothing,
  and outbound protocol writing.
- Good for:
  DIY eye tracking, mouth tracking, face tracking, avatar expression tools, and
  accessibility input experiments.
- Why it matters:
  the reusable part is the observable pipeline boundary, not any single model.
- Source evidence:
  `ProjectBabble`, `EyeTrackVR`, and `ryan9411vr/EyeTracking`.
- Reusable core:
  separate capture, ROI/crop/rotate/flip, inference, calibration, smoothing,
  preview/metrics, and output writers; make every stage visible enough for
  setup and diagnostics.
- Do not copy directly:
  hardware-specific calibration constants, unsafely broad exception handling,
  or model assets without license and safety review.
- Strong references:
  `Project-Babble/ProjectBabble`, `EyeTrackVR/EyeTrackVR`,
  `ryan9411vr/EyeTracking`.
- Best fit for `VR-apps-lab`:
  tracking pipeline matrices and future expression-tracking helper notes.

## Method 563: Multi-target eye/expression output bridge

- What it is:
  one tracking pipeline can publish to multiple consumer schemas such as VRChat
  native eye vectors, VRCFT v1/v2 avatar parameters, OSC avatar parameters, or
  engine input drivers.
- Good for:
  cross-app tracking helpers, VRChat/Resonite bridges, compatibility layers,
  and creator tools.
- Why it matters:
  users should not need one tracker per target app when the output schema can be
  selected or fanned out.
- Source evidence:
  `EyeTrackVR`, `ryan9411vr/EyeTracking`,
  `VRCFaceTracking-TobiiXR`, and `ResoniteOpenXREyeTracking`.
- Reusable core:
  isolate normalized tracking state from protocol writers, cache output-mode
  configuration, support single-eye and unavailable-device fallbacks, expose
  status booleans, and keep schema prefixes/addresses explicit.
- Do not copy directly:
  app-specific parameter names without a compatibility table.
- Strong references:
  `EyeTrackVR/EyeTrackVR`, `ryan9411vr/EyeTracking`,
  `cspark-development/VRCFaceTracking-TobiiXR`,
  `headassbtw/ResoniteOpenXREyeTracking`.
- Best fit for `VR-apps-lab`:
  tracking-output schema comparison across social VR targets.

## Method 564: In-headset calibration routine runner

- What it is:
  calibration is modeled as a set of in-headset routines driven by packets,
  backend adapters, progress/completion events, and user-visible targets.
- Good for:
  eye tracking, mouth tracking, controller calibration, tracker alignment, and
  gaze-driven UX tests.
- Why it matters:
  tracking quality often depends on routines that should run where the user is
  actually looking or moving, not only in a desktop settings panel.
- Source evidence:
  `BabbleCalibration` and `ryan9411vr/EyeTracking`.
- Reusable core:
  separate runtime backend, companion protocol, routine state, target display,
  and completion packet; support reticle/gaze/dilation/convergence/debug
  routine types and clear routine transitions.
- Do not copy directly:
  incomplete backend implementations or app-specific packet names without a
  protocol contract.
- Strong references:
  `Project-Babble/BabbleCalibration`, `ryan9411vr/EyeTracking`.
- Best fit for `VR-apps-lab`:
  calibration wizard and routine-runner design notes.

## Method 565: Containerized headless social-XR server

- What it is:
  a headless XR/social runtime is deployed as a container with update, launch,
  config, logs, mods, and optional sync split into explicit operator-facing
  phases.
- Good for:
  Resonite headlesses, social XR room servers, test servers, and automated
  world/session infrastructure.
- Why it matters:
  repeatable operations are a product feature for persistent social VR spaces.
- Source evidence:
  `resonite-headless-docker`.
- Reusable core:
  keep runtime dependencies in the image, mount config/log/mod folders, split
  update from launch, preserve logs, make mod auto-install visible, and document
  credential/cache cleanup behavior.
- Do not copy directly:
  destructive cache cleanup or credential handling without operator consent.
- Strong references:
  `voxelbonecloud/resonite-headless-docker`.
- Best fit for `VR-apps-lab`:
  headless deployment checklists.

## Method 566: Remote headless operations surface

- What it is:
  a web, Discord, REST, or CLI-attached control surface sends commands to a
  headless runtime, streams logs, parses state, and exposes restart/config
  operations.
- Good for:
  server operators, community managers, diagnostics dashboards, and automation
  bots.
- Why it matters:
  headless tools need safe control surfaces beyond raw terminal access.
- Source evidence:
  `resonite-headless-manager`,
  `Resonite-Headless-Discord-Bot`, and `resonite-rest`.
- Reusable core:
  define auth/role checks, command timeouts, output markers or structured
  routes, rolling logs, status parsing, restart fallback, and config mutation
  boundaries.
- Do not copy directly:
  unauthenticated local-network assumptions or Docker socket exposure without
  threat modeling.
- Strong references:
  `Zetaphor/resonite-headless-manager`,
  `FlippedCodes/Resonite-Headless-Discord-Bot`,
  `JackTheFoxOtter/resonite-rest`.
- Best fit for `VR-apps-lab`:
  headless operations UI and safety matrices.

## Method 567: Compatibility pre-patcher plus runtime shim

- What it is:
  an irreversible assembly pre-patcher and a runtime Harmony shim are paired to
  keep old runtime/plugin expectations working across platform or .NET changes.
- Good for:
  compatibility research, migration tools, and understanding invasive support
  boundaries.
- Why it matters:
  some VR ecosystems rely on fragile runtime internals; tools need an honest
  risk taxonomy for those interventions.
- Source evidence:
  `Cumulo` and `Nimbus`.
- Reusable core:
  warn before modifying files, resolve target assemblies explicitly, apply
  named method patches, bundle runtime helpers, gate by version, and document
  rollback or backup expectations.
- Do not copy directly:
  destructive patch flows into user-facing tools without backups and support
  boundaries.
- Strong references:
  `BlueCyro/Cumulo`, `BlueCyro/Nimbus`.
- Best fit for `VR-apps-lab`:
  compatibility-layer risk documentation.

## Method 568: Shared-memory headless state exporter

- What it is:
  a headless runtime exports scene, material, texture, or render-state packets
  through shared-memory buffers for an external viewer or bridge process.
- Good for:
  headless previews, remote render experiments, diagnostics, and replay/export
  infrastructure.
- Why it matters:
  headless runtimes can expose structured state without pretending they are a
  normal interactive client.
- Source evidence:
  `ResoniteHeadlessHeadServer`.
- Reusable core:
  create sync/main/return buffers, wait for a client, queue high and normal
  priority packets, serialize packet IDs and payloads, and keep connector
  boundaries explicit.
- Do not copy directly:
  deprecated version-coupled connector internals.
- Strong references:
  `Nytra/ResoniteHeadlessHeadServer`.
- Best fit for `VR-apps-lab`:
  headless preview and state-export research notes.

## Method 569: Gaze-contingent visual impairment shader pipeline

- What it is:
  per-eye post-processing simulates visual conditions using gaze coordinates,
  masks, blur pyramids, condition parameters, and debug views.
- Good for:
  accessibility simulation, design review, user research, and low-vision
  training tools.
- Why it matters:
  accessibility simulation becomes more useful when effects follow gaze and can
  be configured per eye or per condition.
- Source evidence:
  `OpenVisSim`, `VARID-plugin-ue5`, and `Glaucoma-VR`.
- Reusable core:
  store per-eye condition state, update normalized gaze, generate masks from
  data or parameters, build blur levels, expose debug views, and clearly reset
  or clear conditions.
- Do not copy directly:
  medical claims, deprecated engine code, or vendor-specific gaze assumptions
  without validation.
- Strong references:
  `petejonze/OpenVisSim`, `VARID-XR/VARID-plugin-ue5`,
  `lukasmaxim/Glaucoma-VR`.
- Best fit for `VR-apps-lab`:
  accessibility simulation matrices and shader-pattern notes.

## Method 570: Mobile passthrough low-vision filter

- What it is:
  a mobile or headset app captures camera frames, displays them in dual-eye
  views, and applies mutable low-vision filters such as edge, center, warp, or
  periphery effects.
- Good for:
  assistive passthrough experiments, phone/headset prototypes, and camera
  accessibility tools.
- Why it matters:
  small mobile filters can validate accessibility value before a full XR
  runtime integration exists.
- Source evidence:
  `VisualImpairmentVR` and `LowVisionVR`.
- Reusable core:
  stage camera frames into textures, keep left/right display surfaces aligned,
  expose runtime mode/parameter controls, and isolate filter kernels or shaders
  from camera capture.
- Do not copy directly:
  deprecated RenderScript or old camera APIs without modernization.
- Strong references:
  `rulyox/VisualImpairmentVR`, `ojwalch/LowVisionVR`.
- Best fit for `VR-apps-lab`:
  low-vision passthrough prototype notes.

## Method 571: Screen-reader-like Unity UI accessibility layer

- What it is:
  an in-app accessibility manager adds labels, hints, navigation order, spoken
  feedback, touch exploration, gestures, and virtual keyboard behavior to Unity
  UI.
- Good for:
  VR menus, accessibility overlays, creator tools, settings panels, and
  non-visual operation.
- Why it matters:
  VR utility menus need accessible focus and feedback models, not only visual
  layout.
- Source evidence:
  `UnityAccessibilityPlugin`.
- Reusable core:
  register accessible elements, group them in containers, compute navigation
  order, queue TTS/audio prompts with interrupts, support hints/prefixes, expose
  touch exploration and gestures, and adapt virtual keyboard input.
- Do not copy directly:
  2D-only focus rules without spatial/VR interaction adaptation.
- Strong references:
  `mikrima/UnityAccessibilityPlugin`.
- Best fit for `VR-apps-lab`:
  VR menu accessibility contracts.

## Method 572: Cubemap-to-equirectangular screenshot capture

- What it is:
  a Unity capture helper renders a camera to a cubemap, converts it to an
  equirectangular image, reads pixels, encodes the result, and embeds panorama
  metadata.
- Good for:
  360 screenshots, VR scene documentation, media utilities, and diagnostics
  artifacts.
- Why it matters:
  research repositories benefit from reproducible visual artifacts, and VR
  tools often need projection-aware exports.
- Source evidence:
  `Unity360ScreenshotCapture`.
- Reusable core:
  use cubemap render targets, equirectangular conversion shader, async GPU
  readback when available, `ReadPixels` fallback, JPEG/PNG encoding, GPano XMP,
  and temporary render texture cleanup.
- Do not copy directly:
  platform-specific capture assumptions without a target support check.
- Strong references:
  `yasirkula/Unity360ScreenshotCapture`.
- Best fit for `VR-apps-lab`:
  360 capture and documentation artifact helpers.

## Method 573: Authoring-time screenshot and thumbnail utility

- What it is:
  an editor utility provides camera selection, preview rendering, transparent
  backgrounds, resolution presets, repeatable filenames, and saved settings.
- Good for:
  creator screenshots, VRChat/world thumbnails, store images, documentation,
  and localization QA.
- Why it matters:
  tiny authoring tools make reusable projects more publishable and easier to
  document.
- Source evidence:
  `Editor-Screenshot` and `UnityScreenShooter`.
- Reusable core:
  save capture settings, support resolution presets, select/follow/create
  cameras, toggle transparent background or UI overlay, pause when needed, wait
  for the right frame, and name files with useful metadata.
- Do not copy directly:
  editor-only APIs into runtime utilities without separation.
- Strong references:
  `rurre/Editor-Screenshot`, `Team-on/UnityScreenShooter`.
- Best fit for `VR-apps-lab`:
  creator utility and documentation tooling notes.

## Method 574: Window, desktop, and headset-screen texture ingress

- What it is:
  external surfaces such as desktop windows, browser pages, desktop frames, or
  Quest screen output are captured and exposed as Unity textures or streams.
- Good for:
  overlays, desktop-in-VR panels, diagnostics, remote viewing, QR workflows,
  and situational HUDs.
- Why it matters:
  many VR overlays are really surface-ingress tools first and XR tools second.
- Source evidence:
  `UnityWindowsCapture` and `QuestMediaProjection`.
- Reusable core:
  track capture source lifecycle, resize buffers, upload texture data, compose
  cursor/highlight overlays, wrap platform services, expose update events, and
  document permissions/privacy.
- Do not copy directly:
  Windows-only or archived Android workaround code without platform review.
- Strong references:
  `Phylliida/UnityWindowsCapture`, `t-34400/QuestMediaProjection`.
- Best fit for `VR-apps-lab`:
  surface-ingress matrices for overlay utilities.

## Method 575: Photomode and immersive media record/playback pipeline

- What it is:
  a capture mode or media SDK organizes camera handoff, pause/state changes,
  post-processing controls, overlays/stickers, recording, upload, and playback
  events.
- Good for:
  VR scene capture, creator tools, immersive media players, 360/stereo video,
  and share/export workflows.
- Why it matters:
  media utilities are strongest when capture UX, recording lifecycle, metadata,
  and playback state are designed together.
- Source evidence:
  `PhotoMode` and `vimeo-unity-sdk`.
- Reusable core:
  switch input/event systems, raise activation events, isolate a capture camera
  or render input, expose postprocess/UI controls, reset state, encode frames or
  360/stereo projections, publish upload progress, and load media metadata for
  playback.
- Do not copy directly:
  account-token or flat-screen UX assumptions without VR-specific adaptation.
- Strong references:
  `UnityTechnologies/PhotoMode`, `vimeo/vimeo-unity-sdk`.
- Best fit for `VR-apps-lab`:
  photomode, immersive media, and capture UX references.

## Method 576: WebView/browser-rendered XR keyboard bridge

- What it is:
  a keyboard UI is rendered in a browser/WebView surface and communicates text
  events, language changes, visibility, and voice state to the native XR host.
- Good for:
  overlays, command palettes, search fields, web-backed tools, and Unity apps
  already using browser surfaces.
- Why it matters:
  text entry is expensive to build natively; a browser keyboard can centralize
  layout, styling, localization, and input messages.
- Source evidence:
  `vuplex/unity-keyboard`.
- Reusable core:
  define a small typed message protocol, initialize the keyboard surface,
  send input values through the WebView bridge, receive host commands such as
  language or visibility changes, and bundle the browser UI for native loading.
- Do not copy directly:
  a WebView dependency unless the target product already accepts browser
  surface cost and focus/privacy responsibilities.
- Strong references:
  `vuplex/unity-keyboard`.
- Best fit for `VR-apps-lab`:
  text-entry and overlay input-surface notes.

## Method 577: Raycast/UV or collider-driven XR keyboard interaction

- What it is:
  a spatial keyboard maps controller rays or physical collider presses into key
  events using UV masks, key meshes, press-depth state, or layout rows.
- Good for:
  headset-native keyboards, controller/direct-touch menus, VR settings panels,
  and command surfaces.
- Why it matters:
  XR keyboards need stable interaction state, not just rendered key labels.
- Source evidence:
  `xrkeys`, `XRSimpleKeyboard`, `vr-virtual-keyboard`, and
  `XR-Keyboard-for-Unity`.
- Reusable core:
  define a host update contract, map ray hits or collider overlaps to a key,
  detect press/release edges, keep key visual feedback separate from text
  editing, support layout metadata, and emit key events through a narrow API.
- Do not copy directly:
  fixed layouts, hardcoded delete keys, or one-demo pointer mapping.
- Strong references:
  `felixtrz/xrkeys`, `pinglis/XRSimpleKeyboard`.
- Best fit for `VR-apps-lab`:
  VR keyboard comparison matrix and input-surface prototypes.

## Method 578: Canvas texture keyboard with dirty-state updates

- What it is:
  a keyboard is drawn into a canvas, receives pointer UVs from the XR host, and
  exposes a dirty flag so the host updates the texture only when needed.
- Good for:
  engine-neutral keyboard surfaces, WebXR planes, Unity/Three texture panels,
  and localized text-entry widgets.
- Why it matters:
  canvas textures let complex keyboard rendering remain decoupled from runtime
  input and texture-upload policy.
- Source evidence:
  `VirtualKeyboard-VR-Ready`.
- Reusable core:
  map UV input into canvas pixels, update layout/language/suggestion/swipe
  state, redraw the canvas, mark texture dirty, and let the host poll or react
  to that dirty flag.
- Do not copy directly:
  word lists or language assumptions without localization and accessibility
  review.
- Strong references:
  `ErikSom/VirtualKeyboard-VR-Ready`.
- Best fit for `VR-apps-lab`:
  reusable text-entry surfaces and texture-panel notes.

## Method 579: Shell keyboard plugin key-event injection

- What it is:
  a compositor, shell, or XR desktop environment exposes a virtual keyboard
  plugin that emits OS/toolkit key events rather than app-local text messages.
- Good for:
  Linux/XR workspaces, spatial desktops, system keyboards, and cross-app text
  input.
- Why it matters:
  some XR utilities need text entry at the shell/runtime boundary, not inside a
  single app.
- Source evidence:
  `stardust-xr-keyboard-plugin`.
- Reusable core:
  implement a keyboard plugin interface, map virtual keys to host key events,
  emit press and delayed release, and keep app focus/destination explicit.
- Do not copy directly:
  hardcoded sample key events or toolkit-specific code without a real input
  routing design.
- Strong references:
  `technobaboo/stardust-xr-keyboard-plugin`.
- Best fit for `VR-apps-lab`:
  shell/desktop-in-VR input boundary notes.

## Method 580: WebXR room server plus P2P pose/audio channel

- What it is:
  a room server handles membership and signaling while WebRTC peer channels
  carry voice and low-latency pose/avatar state.
- Good for:
  collaborative WebXR tools, social rooms, shared dashboards, and browser XR
  micro-worlds.
- Why it matters:
  separating room control from media/data streams keeps shared XR tools small
  and hostable.
- Source evidence:
  `blocks` and `webroom-vr`.
- Reusable core:
  assign identities, broadcast join/leave, forward peer signals, open
  audio/data channels, choose binary or JSON pose payloads, update peers at a
  fixed cadence, and handle disconnect/reconnect explicitly.
- Do not copy directly:
  public-room assumptions without identity, moderation, and media-permission
  handling.
- Strong references:
  `danielesteban/blocks`, `Radet5/webroom-vr`.
- Best fit for `VR-apps-lab`:
  shared-room substrate and social utility notes.

## Method 581: Unity WebXR multiplayer room shell

- What it is:
  a Unity WebXR scene uses hosted services and Unity networking to manage
  lobbies, relay, voice, player state, hand/controller replication, and shared
  UI.
- Good for:
  Unity WebXR collaboration prototypes, training rooms, and service-backed
  multi-user utilities.
- Why it matters:
  Unity WebXR multiplayer has different constraints than native PCVR or pure
  browser WebXR; service boundaries should be explicit.
- Source evidence:
  `webxr-multiplayer-template`.
- Reusable core:
  orchestrate auth, lobby create/join, relay allocation, voice login/state,
  player transforms, hand pose fidelity levels, network variables, and
  server/client RPC UI widgets.
- Do not copy directly:
  hosted service dependencies unless their operational cost and lock-in are
  acceptable.
- Strong references:
  `De-Panther/webxr-multiplayer-template`.
- Best fit for `VR-apps-lab`:
  Unity WebXR room design notes.

## Method 582: Spatial HUD view registry with presence and agent overlays

- What it is:
  a spatial application composes rooms, shared view/filter state, pluggable
  view lifecycles, hand/voice input, HUD panels, minimaps, and agent overlays.
- Good for:
  data visualization, diagnostic workspaces, knowledge graphs, and
  collaboration dashboards.
- Why it matters:
  complex XR tools need view/plugin lifecycle management before they need more
  scene objects.
- Source evidence:
  `xrai-spatial-web`.
- Reusable core:
  keep room state transport-agnostic, expose presence/cursor/view/filter
  messages, define view plugin methods, route events through a bus, and compose
  HUD, voice, hand tracking, filters, minimap, and agent panels around that
  lifecycle.
- Do not copy directly:
  roadmap/spec claims or AI-specific assumptions as finished product logic.
- Strong references:
  `JT5D/xrai-spatial-web`.
- Best fit for `VR-apps-lab`:
  spatial dashboard and diagnostics shell architecture.

## Method 583: Safety-gated VR pose to robot command bridge

- What it is:
  tracked VR poses become robot targets only after coordinate conversion, IK,
  measured-state checks, enabled/mode gates, and visible validity feedback.
- Good for:
  robotics, remote operation, simulation control, and high-risk VR command
  surfaces.
- Why it matters:
  remote-control VR tools need explicit safety and stale/jump handling, not
  direct pose passthrough.
- Source evidence:
  `vr_teleop`, `vr-teleoperation`, and `vr_teleoperation_ros`.
- Reusable core:
  normalize pose frames, seed IK or target transforms from measured state,
  gate command publishing by enable/mode, reject large jumps, debounce gripper
  or command toggles, publish validity/status, and keep camera/operator
  feedback visible.
- Do not copy directly:
  robot-specific kinematics, hardcoded paths, or actuation topics.
- Strong references:
  `UM-ARM-Lab/vr_teleop`,
  `Intelligent-Robotics-Lab/vr-teleoperation`,
  `zz0320/vr_teleoperation_ros`.
- Best fit for `VR-apps-lab`:
  remote-control safety and operator-mode checklists.

## Method 584: Normalized XR controller/tracker publisher for ROS

- What it is:
  a Unity/OpenXR bridge publishes controller and tracker poses, twists,
  buttons, axes, and device roles into ROS or ROS2 topics.
- Good for:
  robotics, diagnostics, tracker inventory, external device bridges, and
  headset-to-simulation utilities.
- Why it matters:
  many integrations need standardized tracked-device snapshots before they can
  reason about control.
- Source evidence:
  `vr_ros2_bridge`.
- Reusable core:
  enumerate XR devices, filter controllers and trackers, map vendor roles,
  convert coordinate systems, publish pose/twist/button/axis snapshots at a
  fixed cadence, and expose debug visualization topics.
- Do not copy directly:
  one vendor tracker profile without feature/capability checks.
- Strong references:
  `UM-ARM-Lab/vr_ros2_bridge`.
- Best fit for `VR-apps-lab`:
  external tracking and ROS bridge notes.

## Method 585: Fixed-rate WebSocket-to-ROS operator command buffer

- What it is:
  a WebSocket receiver accepts VR operator packets asynchronously, stores the
  latest state, and publishes ROS commands on a fixed timer by current mode.
- Good for:
  remote-control panels, robotics labs, data collection, and UI-to-backend
  command bridges.
- Why it matters:
  fixed-rate buffering gives a clear place for smoothing, stale-data behavior,
  mode switching, and feedback.
- Source evidence:
  `zz0320/vr_teleoperation_ros`.
- Reusable core:
  receive JSON VR state, acknowledge packet IDs, buffer latest pose/buttons,
  publish on a ROS timer, split arm/torso/base modes, smooth position and
  quaternion deltas, debounce toggles, call services for special states, and
  play status feedback.
- Do not copy directly:
  compiled IK binaries, hardcoded robot topics, or generated cache.
- Strong references:
  `zz0320/vr_teleoperation_ros`.
- Best fit for `VR-apps-lab`:
  remote-control bridge and command-buffer design notes.

## Method 586: ROS camera wall and operator diagnostics surface

- What it is:
  a VR operator scene displays robot camera feeds and connection status through
  world-space panels, ROS image subscriptions, HTTP feeds, and network tests.
- Good for:
  teleoperation, remote diagnostics, monitoring overlays, and training labs.
- Why it matters:
  operator tools need feedback surfaces as much as input mapping.
- Source evidence:
  `VR-Teleoperation-Robotics-Platform`,
  `vr-teleoperation`, and `ros_reality_bridge`.
- Reusable core:
  subscribe to compressed images before raw fallback, decode into textures,
  create world-space camera grids, show FPS/status labels, test robot/HTTP/ROS
  endpoints, and keep camera transport separate from command transport.
- Do not copy directly:
  hardcoded IP addresses, plaintext SSH shortcuts, or old camera pipelines.
- Strong references:
  `Mcen25/VR-Teleoperation-Robotics-Platform`,
  `Intelligent-Robotics-Lab/vr-teleoperation`,
  `h2r/ros_reality_bridge`.
- Best fit for `VR-apps-lab`:
  diagnostic camera panels and remote-status overlays.

## Method 587: Microcontroller HMD HID report pipeline

- What it is:
  a DIY headset firmware reads IMU sensors and exposes motion as a VR/HMD HID
  report to a host-side runtime or driver.
- Good for:
  hardware bring-up, device diagnostics, driver experiments, and low-level
  XR input research.
- Why it matters:
  understanding firmware report boundaries helps future tools reason about
  custom devices without importing whole hardware projects.
- Source evidence:
  `NxtVR`.
- Reusable core:
  initialize I2C, read accel/gyro, define HID report descriptors, pack motion
  axes into reports, send over USB/HID at a fixed interval, expose mount/suspend
  state, and keep calibration separate.
- Do not copy directly:
  raw IMU-only tracking expectations as full headset tracking.
- Strong references:
  `vis3r/NxtVR`.
- Best fit for `VR-apps-lab`:
  custom-device and headset firmware boundary notes.

## Method 588: DIY controller firmware to runtime driver boundary

- What it is:
  firmware sends orientation/input packets over HID or serial/Bluetooth, while
  a runtime driver parses packets, maps them to controller input components,
  handles freshness, and sends haptic output back.
- Good for:
  DIY controllers, driver tutorials, custom input devices, haptics, and device
  protocol experiments.
- Why it matters:
  the useful reusable knowledge is the protocol and driver boundary, not the
  exact enclosure or board.
- Source evidence:
  `DIY_VR_Controller` and `VRController`.
- Reusable core:
  document packet layout, include packet IDs/timing, send quaternion/buttons/
  joystick data, parse report IDs and endian details, update runtime pose/input
  components, track dropped packets/staleness, and map runtime haptics back to
  firmware output reports.
- Do not copy directly:
  built DLLs, bundled third-party artifacts, device IDs, or naive
  accelerometer-position tracking.
- Strong references:
  `shehraan/DIY_VR_Controller`, `dhfmzk/VRController`.
- Best fit for `VR-apps-lab`:
  custom controller protocol and driver-boundary documentation.

## Method 589: Bright-marker camera tracker to UDP

- What it is:
  a camera-based tracker thresholds bright IR/LED markers, chooses marker
  candidates, normalizes screen coordinates, and sends them to another process.
- Good for:
  DIY controllers, calibration experiments, quick pose/proxy input tests, and
  camera-tracking prototypes.
- Why it matters:
  small vision bridges are useful fast experiments even when not robust enough
  for final 6DoF tracking.
- Source evidence:
  `DIY-VR-Controller-OpenCV`.
- Reusable core:
  capture frames, threshold/blur, find contours, choose candidate markers,
  normalize coordinates, preserve last known value on dropout, send UDP, and
  show debug overlays.
- Do not copy directly:
  Python2 code, fixed thresholds, or single-camera depth shortcuts.
- Strong references:
  `BlaiseSaunders/DIY-VR-Controller-OpenCV`.
- Best fit for `VR-apps-lab`:
  quick camera-tracking and calibration bridge notes.

## Method 590: Headset specification dataset with validation schema

- What it is:
  headset capabilities and physical traits are stored as JSON/CSV data with a
  schema covering display, optics, tracking, audio, connectivity, battery,
  physical attributes, features, and best-use tags.
- Good for:
  compatibility matrices, device inventory, recommendation helpers,
  diagnostics, and documentation.
- Why it matters:
  VR tools often need headset capability knowledge, and ad-hoc prose is hard
  to validate or compare.
- Source evidence:
  `vr-headset-specs`.
- Reusable core:
  assign stable device IDs, keep structured fields for common capabilities,
  provide both machine-readable JSON and spreadsheet-friendly CSV, validate
  contributions with schema, and document provenance requirements.
- Do not copy directly:
  prices or specs as current truth without verification and source links.
- Strong references:
  `vrrare/vr-headset-specs`.
- Best fit for `VR-apps-lab`:
  device capability and compatibility research.

## Method 591: DIY XR hardware documentation pack

- What it is:
  a hardware project documents BOM, CAD, PCB, optics/display choices, firmware
  status, driver dependencies, assembly/printing notes, and maturity warnings
  as one coherent package.
- Good for:
  open headset/controller projects, maker-facing docs, and hardware-inspired
  software research.
- Why it matters:
  clear hardware documentation prevents false confidence and exposes practical
  constraints software-only projects miss.
- Source evidence:
  `FloV3R`, `Persephone-VR-Headset`, and `OpenVision`.
- Reusable core:
  keep parts lists, cost estimates, PCB/assembly/printing docs, CAD links,
  optics/display constraints, firmware/driver status, external dependencies,
  and do-not-build-yet warnings close together.
- Do not copy directly:
  incomplete hardware plans as validated designs.
- Strong references:
  `Kwiatens/FloV3R`,
  `Jade-Vincent/Persephone-VR-Headset`,
  `CSParnell78/OpenVision`.
- Best fit for `VR-apps-lab`:
  hardware boundary documentation and device-constraint matrices.

## Method 592: WebRTC media track to XR texture receiver

- What it is:
  a small XR receiver accepts WebRTC signaling separately from media and binds
  a decoded remote video track to a world-space material or panel texture.
- Good for:
  remote camera panels, support tools, operator views, and low-latency
  diagnostic displays.
- Why it matters:
  the reusable boundary is signaling/media separation and texture handoff, not
  a complete streaming platform.
- Source evidence:
  `XR-Low-Latency-Stereo-Streaming`.
- Reusable core:
  exchange SDP/ICE over a lightweight signaling channel, buffer ICE until the
  remote description is ready, subscribe to the remote video track, and hand
  decoded frames to an XR renderer.
- Do not copy directly:
  LAN-only assumptions, no-auth signaling, no TURN fallback, or mono webcam
  scope as production design.
- Strong references:
  `bugman-007/XR-Low-Latency-Stereo-Streaming`.
- Best fit for `VR-apps-lab`:
  external surface ingress and remote diagnostics notes.

## Method 593: Fixed-contract stereo stream panel

- What it is:
  a spatial panel subscribes to a room video track and renders it using an
  explicit stereo layout contract such as left-right side-by-side.
- Good for:
  telepresence, stereo video viewers, immersive media surfaces, and robot or
  camera wall prototypes.
- Why it matters:
  stereo display bugs usually come from implicit texture assumptions; the
  format contract should be visible in code and docs.
- Source evidence:
  `spatial-video`.
- Reusable core:
  create a panel or surface with known pixel/world dimensions, mark stereo mode,
  bind the selected room track to a renderer, and detach/hide cleanly when the
  track unsubscribes.
- Do not copy directly:
  hardcoded room credentials, one fixed resolution, or service-specific sample
  config.
- Strong references:
  `livekit-examples/spatial-video`.
- Best fit for `VR-apps-lab`:
  stereo media and external video panel patterns.

## Method 594: UDP point-cloud fragments to Unity mesh

- What it is:
  a sender packs point data into numbered UDP chunks and a receiver reassembles
  complete frames into a point mesh on the Unity main thread.
- Good for:
  spatial diagnostics, sensor previews, robot perception panels, calibration,
  and quick point-cloud experiments.
- Why it matters:
  point-cloud tools need an explicit payload/header boundary before they can be
  optimized or made reliable.
- Source evidence:
  `PointCast3D`.
- Reusable core:
  pack `x/y/z/r/g/b` point records, prefix chunks with frame ID and chunk
  counts, collect fragments off the main thread, discard incomplete frames, and
  update `MeshTopology.Points` only from the main thread.
- Do not copy directly:
  no-loss-policy UDP handling, thread abort patterns, or CPU full-mesh rebuilds
  as the final renderer.
- Strong references:
  `Cont-ai-ner/PointCast3D`.
- Best fit for `VR-apps-lab`:
  point-cloud ingress and spatial diagnostic surfaces.

## Method 595: Quest MediaProjection WebRTC sender state machine

- What it is:
  a headset-side sender owns capture permission, foreground-service lifetime,
  codec selection, signaling, publishing, and adaptive downgrade policy as one
  observable session.
- Good for:
  headset mirroring, remote assistance, diagnostics, capture tools, and
  support utilities.
- Why it matters:
  production value comes from permission/state/error handling, not just from
  calling a screen-capture API.
- Source evidence:
  `relavr`.
- Reusable core:
  validate config, request or restore projection permission, probe codec
  support, open signaling, publish media, expose session snapshots, downgrade
  bitrate/FPS/resolution after repeated overload, and release all resources on
  stop or failure.
- Do not copy directly:
  app-specific QR payloads, UI strings, or assumptions about audio-capture
  availability.
- Strong references:
  `N78Wy/relavr`.
- Best fit for `VR-apps-lab`:
  Quest capture sender, media diagnostics, and remote-support patterns.

## Method 596: Native WebView to world-surface browser shell

- What it is:
  a native XR app renders web media through a platform WebView texture placed
  on a world-space surface instead of depending on WebXR page capabilities.
- Good for:
  browser video panels, reference windows, learning tools, and DRM/CORS-limited
  media experiments.
- Why it matters:
  native WebView composition can bypass browser/WebXR limitations while still
  preserving an XR interaction shell.
- Source evidence:
  `SpatialVideoBrowser`.
- Reusable core:
  embed a native WebView texture, place it on a world-space canvas or panel,
  combine it with XR input/locomotion, and document lifecycle, keyboard, and
  permission handling separately.
- Do not copy directly:
  template URLs, unresolved package assumptions, or platform WebView behavior
  as portable truth.
- Strong references:
  `ranvuemor/SpatialVideoBrowser`.
- Best fit for `VR-apps-lab`:
  browser-video and reference-surface product notes.

## Method 597: Embodied wheel-grab locomotion rig

- What it is:
  wheelchair movement is modeled through wheel interactables, hand grab
  proxies, velocity-based braking, and haptic feedback instead of abstract
  stick movement.
- Good for:
  accessibility studies, alternative locomotion, training, embodiment, and
  physical-input experiments.
- Why it matters:
  accessibility locomotion should preserve user embodiment and physical
  assumptions rather than only remapping thumbsticks.
- Source evidence:
  `vr-wheelchair`.
- Reusable core:
  create wheel XR interactables, spawn disposable jointed grab points at the
  hands, force-select proxies, detach when hands drift, brake near zero hand
  velocity, and map deceleration to haptics.
- Do not copy directly:
  hardcoded thresholds, prototype prefab assumptions, or one locomotion mode as
  a complete accessibility answer.
- Strong references:
  `justinmajetich/vr-wheelchair`.
- Best fit for `VR-apps-lab`:
  accessibility locomotion and embodied input matrices.

## Method 598: Locomotion hub with input, modifier, and movement split

- What it is:
  locomotion input providers register with a hub, modifiers transform movement
  vectors, and movement consumers apply final translation or physics behavior.
- Good for:
  configurable locomotion labs, comfort testing, accessibility options, and
  reusable movement plugins.
- Why it matters:
  the split makes locomotion modes comparable and swappable without rewriting
  the whole rig.
- Source evidence:
  `ddw-locomotion-system`.
- Reusable core:
  register primary/secondary inputs, emit begin/end/input events, transform
  vectors through active modifiers, and let translation or Rigidbody consumers
  subscribe independently.
- Do not copy directly:
  old SteamVR package contents or legacy project setup.
- Strong references:
  `DigitalDiceworks/ddw-locomotion-system`.
- Best fit for `VR-apps-lab`:
  locomotion abstraction and input-composition notes.

## Method 599: Redirected-walking gains with telemetry

- What it is:
  a redirector applies translation or rotation gains to the play-area parent
  and logs redirection events for later analysis.
- Good for:
  locomotion research tools, spatial design diagnostics, room-scale comfort
  experiments, and level-design helpers.
- Why it matters:
  redirected walking is only reusable if the gain model and measurements are
  visible.
- Source evidence:
  `space-extender`.
- Reusable core:
  define start/end play areas, compute HMD translation or rotation deltas,
  apply gains around the play-area object, expose start/end events, and log
  duration plus accumulated rotation/translation.
- Do not copy directly:
  old Unity assumptions, singleton auto-creation, or fragile float equality
  checks.
- Strong references:
  `curvaturegames/space-extender`.
- Best fit for `VR-apps-lab`:
  locomotion telemetry and redirected-walking notes.

## Method 600: Zero-G grab and thruster control with comfort toggle

- What it is:
  zero-G movement combines physical grab joints, release behavior, hand
  thrusters, and a switch between physically accurate and comfort-oriented
  movement.
- Good for:
  space/zero-G tools, training, embodied manipulation, and non-walking
  locomotion experiments.
- Why it matters:
  realism and comfort should be an explicit user-facing tradeoff, not an
  accidental physics setting.
- Source evidence:
  `echo-unity`.
- Reusable core:
  use grab grace windows, penetration checks, configurable joints, hand/body
  mass scaling, release velocity dampening, heat-based thrusters, and a toggle
  that changes body rotation constraints and release accuracy.
- Do not copy directly:
  game-specific objectives, demo assets, or expensive mesh tests without
  profiling.
- Strong references:
  `simeonradivoev/echo-unity`.
- Best fit for `VR-apps-lab`:
  alternative locomotion and embodied control references.

## Method 601: Numeric-spring radial command menu

- What it is:
  radial menu items are placed dynamically, selected through hover/step state,
  and animated through reusable numeric spring components.
- Good for:
  in-headset command palettes, tool menus, quick actions, settings, and
  controller/hand UI experiments.
- Why it matters:
  menu reuse improves when placement, item state, attachments, events, and
  animation are independent.
- Source evidence:
  `RadialMenuVR`.
- Reusable core:
  compute item positions from radius/count/circle mode, track hovered and
  selected indices, emit hover/select/toggle/rebuild events, animate
  transforms with spring values, and attach indicators/text to selected items.
- Do not copy directly:
  demo assets, optional editor dependencies, or unfinished roadmap assumptions.
- Strong references:
  `Gustorvo/RadialMenuVR`.
- Best fit for `VR-apps-lab`:
  VR command-surface and radial menu patterns.

## Method 602: Physical VR launcher command objects

- What it is:
  apps or commands are represented as grabbable 3D objects, and a physical
  interaction such as collision confirms the command.
- Good for:
  VR home menus, launcher surfaces, kiosk tools, and tangible command UX.
- Why it matters:
  physical confirmation can make menu actions legible in VR, but it needs
  explicit error and safety feedback.
- Source evidence:
  `Quest-VR-Menu`.
- Reusable core:
  represent commands as labeled objects, detect a deliberate physical
  confirmation action, map objects to package/intent metadata, and invoke the
  platform launcher from the XR app.
- Do not copy directly:
  random assignment, brittle Android helper code, old SDK assumptions, or weak
  fallback handling.
- Strong references:
  `kblood/Quest-VR-Menu`.
- Best fit for `VR-apps-lab`:
  launcher/menu product references and tangible command UX notes.

## Method 603: Recursive VRChat expression-menu editor utility

- What it is:
  a Unity Editor tool traverses nested VRChat expression menus and mutates
  menu/control names or related metadata in bulk.
- Good for:
  localization, accessibility labels, menu QA, migration tools, and avatar
  creator workflows.
- Why it matters:
  creator utilities often need safe recursive traversal of menu graphs rather
  than one-off asset edits.
- Source evidence:
  `VRC-Menu-Translator`.
- Reusable core:
  open an editor window, accept an avatar root, find the avatar descriptor,
  recursively collect expression menus and submenus, present rows for review,
  mutate control/menu names, mark assets dirty, and save.
- Do not copy directly:
  blocking HTTP calls, unescaped provider URLs, no Undo, or no dry-run mode.
- Strong references:
  `CascadianVR/VRC-Menu-Translator`.
- Best fit for `VR-apps-lab`:
  creator-facing menu tooling and validation helpers.

## Method 604: Desktop OSC macro surface with slots and avatar feedback

- What it is:
  a desktop companion provides named command slots, hotkeys, OSC send/receive,
  OSCQuery discovery, and feedback from avatar parameters.
- Good for:
  VRChat companions, quick settings, accessibility shortcuts, avatar state
  tools, and menu-limit workarounds.
- Why it matters:
  not every VR command surface has to be in-HMD; desktop companions can make
  slow radial-menu actions fast and reliable.
- Source evidence:
  `VrCScalingTool`.
- Reusable core:
  clamp command values, persist slots, send OSC parameters, listen for avatar
  trigger booleans, expose OSCQuery parameter trees, provide global hotkeys,
  keep undo state, and optionally register as a SteamVR dashboard app.
- Do not copy directly:
  avatar-scale-specific values, Windows-only UI assumptions, or unsigned
  distribution flows.
- Strong references:
  `Tazaur/VrCScalingTool`.
- Best fit for `VR-apps-lab`:
  command companion and avatar-control surface designs.

## Method 605: Wearable heart-rate parameter schema for avatars

- What it is:
  heart-rate bridges publish a small compatible set of avatar parameters such
  as raw BPM, digits, normalized float, connected, active, beat, and session
  min/max values.
- Good for:
  biometric avatar effects, stream/social presentation, compatibility with
  prefabs, and diagnostics.
- Why it matters:
  the avatar interface should stay stable while BLE, ANT+, HTTP, OBS, or web
  services change underneath it.
- Source evidence:
  `HeartRateMonitorVRC`, `osc-hr-ble`, `HeartRateOnStream-OSC`,
  `ble-osc-heartrate`, and `vrc_hyperate_chatbox`.
- Reusable core:
  split BPM into digits, compute normalized ranges, expose active/connected or
  stale booleans, optionally emulate beat pulses, and send related parameters
  together when possible.
- Do not copy directly:
  one project's parameter names as universal truth without compatibility notes.
- Strong references:
  `DangerKiddy/HeartRateMonitorVRC`, `Naraenda/osc-hr-ble`,
  `Curtis-VL/HeartRateOnStream-OSC`.
- Best fit for `VR-apps-lab`:
  avatar telemetry schema and sensor bridge conventions.

## Method 606: OBS/WebSocket compatibility shim for sensor ingress

- What it is:
  a local service mimics enough of an existing app protocol, such as OBS
  WebSocket, to receive wearable data and forward it to VR/avatar protocols.
- Good for:
  reusing existing phone/watch apps, migration bridges, quick compatibility
  adapters, and no-new-mobile-app workflows.
- Why it matters:
  protocol shims can unlock useful input sources without owning the whole
  sensor capture stack.
- Source evidence:
  `HeartRateOnStream-OSC`.
- Reusable core:
  host a local WebSocket server, answer the source app's handshake/request
  messages, parse the known update event, normalize latest data, and forward
  multiple compatible avatar parameters.
- Do not copy directly:
  string-built JSON, hardcoded ports/request IDs, or no cancellation/reconnect
  policy.
- Strong references:
  `Curtis-VL/HeartRateOnStream-OSC`.
- Best fit for `VR-apps-lab`:
  companion protocol bridges and compatibility adapters.

## Method 607: Transport-isolated BLE/ANT wearable reader

- What it is:
  wearable transport code is isolated behind a reader loop while avatar
  parameters are produced by a separate schema/output layer.
- Good for:
  BLE GATT monitors, BLE advertisement devices, ANT+ dongles, phone helpers,
  and multi-source biometric tools.
- Why it matters:
  transport-specific failure modes should not leak into avatar parameter
  schema or product UI.
- Source evidence:
  `HeartRateMonitorVRC`, `osc-hr-ble`, `vrchat_ant_hr`,
  `ble-osc-heartrate`, and `OSC-VRChat-Feeder`.
- Reusable core:
  keep BLE/ANT scanning, connection, parsing, reconnect, and permission setup
  separate from BPM normalization, digit splitting, connection booleans, and
  OSC output.
- Do not copy directly:
  device-specific magic bytes, fixed manufacturer offsets, first-device-only
  selection, or hidden USB/BLE permission prerequisites.
- Strong references:
  `DangerKiddy/HeartRateMonitorVRC`, `RedlineTriad/vrchat_ant_hr`,
  `Naraenda/osc-hr-ble`, `Solexid/OSC-VRChat-Feeder`.
- Best fit for `VR-apps-lab`:
  biometric bridge transport matrices and failure-mode notes.

## Method 608: Profile-driven phone sensor feeder to OSC

- What it is:
  a mobile companion maps multiple phone or wearable sensor inputs to OSC
  parameters through user-editable profiles and normalization rules.
- Good for:
  phone-as-controller experiments, wearable bridges, avatar telemetry, and
  quick sensor-to-parameter prototypes.
- Why it matters:
  profile schemas make one-off sensor bridges reusable across devices and
  avatar parameters.
- Source evidence:
  `OSC-VRChat-Feeder`.
- Reusable core:
  model input type, root path, parameter name, value type, min/max, clamp and
  normalization policy, persist profiles, and route BLE/phone sensor updates
  through the same OSC sender.
- Do not copy directly:
  Mi Band magic bytes, bundled binaries, or old mobile permission assumptions.
- Strong references:
  `Solexid/OSC-VRChat-Feeder`.
- Best fit for `VR-apps-lab`:
  mobile sensor feeder and avatar telemetry experiments.

## Method 609: VAD-gated direct audio-to-chatbox translation pipeline

- What it is:
  a microphone sidecar segments speech with VAD, sends only speech phrases to a
  recognizer/translator, and publishes translated text to VRChat chatbox.
- Good for:
  speech translation companions, accessibility sidecars, travel/social VR
  tools, and microphone-to-text experiments.
- Why it matters:
  speech tools need a capture gate so cloud STT does not process continuous
  silence, private background audio, or avoidable paid traffic.
- Source evidence:
  `FoxTrans`.
- Reusable core:
  record fixed-size mono frames, keep a short pre-roll, use speech/silence
  counters around WebRTC VAD, pack the resulting phrase, set chatbox typing
  while processing, and send the final translated message to `/chatbox/input`.
- Do not copy directly:
  provider-specific prompts/models, cloud audio defaults, custom OSC packing
  without validation, or missing retry/backoff.
- Strong references:
  `MrShitFox/FoxTrans`.
- Best fit for `VR-apps-lab`:
  voice translation sidecar architecture and privacy checklist.

## Method 610: Avatar-controlled STT/translation pipeline with extension chain

- What it is:
  a speech pipeline exposes language, PTT, on/off, and output behavior through
  avatar OSC parameters while routing recognized text through translation and
  optional extension processors.
- Good for:
  in-world controllable translation tools, accessibility utilities, bilingual
  chatbox apps, and creator-facing voice companions.
- Why it matters:
  avatar parameters let the user control speech tools without leaving VR.
- Source evidence:
  `OSC-SRTC`.
- Reusable core:
  run a local OSC server, map avatar parameter callbacks to pipeline state,
  capture/recognize speech, translate one or more targets, pass text through
  ordered extensions, and send a composed chatbox message.
- Do not copy directly:
  query-string extension forwarding, process-kill shutdown, unofficial provider
  assumptions, or weak API-key handling.
- Strong references:
  `R-VUt/OSC-SRTC`.
- Best fit for `VR-apps-lab`:
  avatar-controllable voice utility and extension-boundary notes.

## Method 611: Chatbox input mode router

- What it is:
  one utility routes several input sources, such as time, file lines, local
  STT, and cloud STT, into a common VRChat chatbox output path.
- Good for:
  rapid chatbox experiments, diagnostics, accessibility prototypes, and
  provider comparison tools.
- Why it matters:
  a shared output path makes it easier to compare recognition providers and
  non-voice inputs without rewriting OSC sending code.
- Source evidence:
  `OSC_Voice`.
- Reusable core:
  present mode selection, keep source-specific capture/recognition in separate
  modules, normalize text output, toggle typing when relevant, and route all
  sources through one chatbox sender.
- Do not copy directly:
  hardcoded paths/IPs, ASCII-only OSC packing, crude thresholds, or streaming
  defaults that create surprise cost.
- Strong references:
  `ewrt101/OSC_Voice`.
- Best fit for `VR-apps-lab`:
  chatbox source-router prototypes and STT provider comparison.

## Method 612: Dependency-gated Linux chatbox composer

- What it is:
  a Linux chatbox utility exposes optional modules only when their external
  dependencies and data sources are available.
- Good for:
  Linux VRChat companions, media/status overlays, MPRIS/playerctl tools, and
  system telemetry chatbox apps.
- Why it matters:
  Linux utility UX improves when missing dependencies are visible constraints,
  not mysterious broken fields.
- Source evidence:
  `RustyChatBox`.
- Reusable core:
  load persisted module settings, check external dependencies up front, format
  media/status/system strings through modules, disable or warn on unavailable
  modules, and send final text through one OSC sender.
- Do not copy directly:
  early POC UI coupling, Linux-only assumptions as universal behavior, or
  emoji/string handling without validation.
- Strong references:
  `Voiasis/RustyChatBox`.
- Best fit for `VR-apps-lab`:
  Linux-first chatbox/status companion notes.

## Method 613: Playback-to-chatbox bridge with OAuth and lyric scheduling

- What it is:
  a media companion authenticates to a playback service, polls current track
  state, sends now-playing chatbox text, and optionally schedules lyric lines
  against playback progress.
- Good for:
  music status companions, social VR presentation, streamer tools, and
  lyric/subtitle experiments.
- Why it matters:
  playback bridges need token persistence, send cadence, and timed text
  scheduling as explicit boundaries.
- Source evidence:
  `vrc-osc-spotify`, `vrchat-osc-spotify`.
- Reusable core:
  run OAuth/PKCE login, persist and refresh tokens, poll playback state, format
  a bounded message, clear old timers on track change, schedule lyric lines by
  playback offset, and avoid repeated sends.
- Do not copy directly:
  internal lyric APIs, anti-AFK behavior, secret handling shortcuts, or
  Windows-only status helpers as generic code.
- Strong references:
  `bddvlpr/vrc-osc-spotify`,
  `Massivendurchfall/vrchat-osc-spotify`.
- Best fit for `VR-apps-lab`:
  media/status chatbox utility design.

## Method 614: Template-variable chatbox composer with bounded send cadence

- What it is:
  a chatbox utility expands placeholders from registered data sources, previews
  the result, enforces message limits, and sends manually, periodically, or on
  change.
- Good for:
  status panels, telemetry text, media summaries, active-window indicators,
  tiny automation senders, and chatbox diagnostics.
- Why it matters:
  chatbox surfaces are small; useful tools need formatter, limiter, privacy,
  and cadence policies rather than raw string sends.
- Source evidence:
  `VRChat-OSC-ChatBox`, `VRChat_OSC_Display_Mate`,
  `VRChat_OSC_Chatbox_for_GO`.
- Reusable core:
  register placeholders by category, expand templates, preview the final
  message, warn or truncate near the limit, detect changes, keep a keepalive
  interval, and expose a tiny CLI sender for scripts.
- Do not copy directly:
  unfiltered active-window titles, Selenium scraping defaults, no length checks,
  or platform-specific metric probes without capability flags.
- Strong references:
  `Null-K/VRChat-OSC-ChatBox`,
  `WillW129/VRChat_OSC_Display_Mate`,
  `nekochanfood/VRChat_OSC_Chatbox_for_GO`.
- Best fit for `VR-apps-lab`:
  reusable chatbox composer and tiny OSC sender baseline.

## Method 615: Browser/phone OSC controller bridge

- What it is:
  a local web or phone UI sends allowlisted commands through HTTP/WebSocket to
  an OSC service that controls VRChat chatbox, input paths, or avatar
  parameters.
- Good for:
  phone companion panels, accessibility controls, avatar command surfaces,
  remote debugging, and browser-based OSC utilities.
- Why it matters:
  browser controls are convenient but dangerous unless binding, auth, command
  schemas, and emergency reset behavior are explicit.
- Source evidence:
  `WebVRChatOSC`, `VRChat-OSC-Controller-Client`,
  `VRChat-OSC-Controller-Server`.
- Reusable core:
  keep OSC send/listen in a local service, expose a typed command API, store
  custom buttons, discover avatar parameters from VRChat OSC JSON or OSCQuery,
  map browser controls to named commands, and provide key-up-all/emergency
  reset behavior.
- Do not copy directly:
  arbitrary script execution, unauthenticated public WebSockets, raw path sends
  without allowlists, or hardcoded public endpoints.
- Strong references:
  `sselecirPyM/WebVRChatOSC`,
  `MiaBub/VRChat-OSC-Controller-Client`,
  `MiaBub/VRChat-OSC-Controller-Server`.
- Best fit for `VR-apps-lab`:
  secure web/phone OSC control surface patterns.

## Method 616: Avatar OSC to haptic event and device-manager pipeline

- What it is:
  a haptics server normalizes VRChat OSC contact/avatar parameters into haptic
  events, maps those events to device nodes, interpolates intensity, and routes
  output through device-specific managers.
- Good for:
  wearable haptics, DIY motor devices, vendor-agnostic haptic routers, and
  avatar-driven physical-output systems.
- Why it matters:
  reusable haptics tools should separate avatar ingress from event maps and
  hardware transport.
- Source evidence:
  `VRCH-Server`, `VRC-Haptics-Host`.
- Reusable core:
  listen to VRChat OSC, batch/cache parameter changes, map addresses to haptic
  nodes/groups, compute intensity/interpolation, hold per-device settings, and
  route timed output through WiFi/BLE/device handles.
- Do not copy directly:
  project-specific node maps, experimental sidecars, old protocol assumptions,
  or hardware control without safety gates.
- Strong references:
  `VRC-Haptics/VRCH-Server`,
  `virtuallyaverage/VRC-Haptics-Host`.
- Best fit for `VR-apps-lab`:
  physical-output router and haptic event schema design.

## Method 617: Firmware-side haptic protocol with config and stale reset

- What it is:
  firmware receives compact haptic packets and control commands, persists
  device config, advertises/discovers over the network, and resets outputs when
  data goes stale.
- Good for:
  DIY haptics, wearable devices, accessory-control bridges, and custom physical
  output experiments.
- Why it matters:
  physical output must fail safe; stale packets, power limits, config, and
  discovery are part of the method, not implementation details.
- Source evidence:
  `VRCH-Firmware`, `VRCHaptics`, `VRC-Haptics-Hardware`.
- Reusable core:
  load flash config, expose serial/OSC commands, announce device identity,
  parse compact motor payloads, drive PWM/PCA outputs, stop motors on timeout,
  and document BOM/PCB/pin-map assumptions beside firmware.
- Do not copy directly:
  DIY pin maps, magic multicast constants, old firmware, or motor control code
  without electrical, thermal, and safety review.
- Strong references:
  `VRC-Haptics/VRCH-Firmware`, `Pillazo/VRCHaptics`,
  `virtuallyaverage/VRC-Haptics-Hardware`.
- Best fit for `VR-apps-lab`:
  firmware/hardware boundary checklist for physical-output tools.

## Method 618: OSC-triggered haptic preset and tracker-node bridge

- What it is:
  OSC avatar parameters trigger haptic patterns or tracker-node vibration
  commands through a vendor or hardware-specific backend.
- Good for:
  bHaptics pattern playback, tracker haptics, compatibility modules, avatar
  contact effects, and lightweight physical feedback experiments.
- Why it matters:
  not every haptic tool needs a full custom firmware stack; many can translate
  avatar parameters into existing vendor/device actions.
- Source evidence:
  `HapticPatternTriggerOSC`, `AXHaptics`.
- Reusable core:
  persist parameter-to-pattern or parameter-to-node mappings, listen for OSC
  booleans/floats, play the mapped pattern or command node vibration, scale
  proximity/intensity values, and reset one-shot booleans when needed.
- Do not copy directly:
  boolean-only limitations, deprecated tracker protocols, no-auth receivers,
  or vendor SDK coupling as the only backend.
- Strong references:
  `sync1211/HapticPatternTriggerOSC`, `TahvoDev/AXHaptics`.
- Best fit for `VR-apps-lab`:
  haptic preset bridges and compatibility modules.

## Method 619: PSVR2 shared-memory passthrough OpenXR composition layer

- What it is:
  an OpenXR implicit API layer injects calibrated external camera imagery into
  application frames as a runtime-side passthrough surface.
- Good for:
  experimental passthrough tools, runtime-side view augmentation, camera-feed
  research, and vendor enhancement layers.
- Why it matters:
  passthrough utilities need a clean boundary between API-layer interception,
  camera data providers, calibration, user toggles, and comfort constraints.
- Source evidence:
  `Obsidiate/psvr2passthrough`.
- Reusable core:
  negotiate the OpenXR API-layer interface, wrap dispatch, adopt only supported
  graphics sessions, read camera frames and calibration from a side provider,
  create per-eye swapchains, inject composition only when enabled/visible, and
  keep alpha, geometry, reprojection, and toggle config user-controlled.
- Do not copy directly:
  PSVR2-specific shared-memory format, D3D11-only assumptions,
  reverse-engineered calibration, registry install code, or latency-sensitive
  passthrough defaults.
- Strong references:
  `Obsidiate/psvr2passthrough`.
- Maturity:
  experimental and device-specific.
- Best fit for `VR-apps-lab`:
  passthrough layer architecture notes and OpenXR layer safety checklists.

## Method 620: SteamVR driver shim to expose vendor gaze data

- What it is:
  a SteamVR driver shim wraps a target HMD driver and exposes a vendor gaze
  stream through a standard gaze interaction surface.
- Good for:
  eye-tracking compatibility research, driver-shim comparisons, and runtime
  feature-gap analysis.
- Why it matters:
  vendor data often exists before clean runtime exposure; shim patterns show
  both the opportunity and the risk.
- Source evidence:
  `BattleAxeVR/PSVR2_STEAMVR_EYE_TRACKING_SHIM`.
- Reusable core:
  hook the server-driver registration boundary, detect the target driver and
  tracked-device class, wrap only the intended HMD, connect to a local gaze
  data transport, request combined/per-eye gaze samples, validate samples, and
  expose them through a standardized interface.
- Do not copy directly:
  Detours-based driver hooks, exact driver names, bundled binaries, unfinished
  calibration, or named-pipe protocol assumptions without current review.
- Strong references:
  `BattleAxeVR/PSVR2_STEAMVR_EYE_TRACKING_SHIM`.
- Maturity:
  high-risk compatibility shim.
- Best fit for `VR-apps-lab`:
  runtime feature-gap and driver-shim risk taxonomy.

## Method 621: Multi-source eye tracker to OpenXR gaze interaction layer

- What it is:
  an OpenXR API layer maps many tracker backends into
  `XR_EXT_eye_gaze_interaction` with extension gating, tracker priority, and
  stale-data validation.
- Good for:
  gaze sidecars, provider-neutral eye tracking, calibration clients, and
  compatibility layers.
- Why it matters:
  gaze tools need a provider abstraction before they can support runtime,
  device SDK, OSC, TCP, and simulated sources consistently.
- Source evidence:
  `mbucchia/_ARCHIVE_OpenXR-Eye-Trackers`.
- Reusable core:
  detect whether the app requested gaze support, choose a tracker backend by
  runtime support and configured priority, poll backend-specific transports,
  normalize combined/per-eye gaze, reject stale or invalid samples, and expose
  action/pose data through OpenXR gaze interaction.
- Do not copy directly:
  archived code, tracker-specific SDK assumptions, Windows-only install paths,
  or stale compatibility lists.
- Strong references:
  `mbucchia/_ARCHIVE_OpenXR-Eye-Trackers`.
- Maturity:
  archived but conceptually strong.
- Best fit for `VR-apps-lab`:
  provider-neutral gaze abstraction and calibration matrix.

## Method 622: Avatar OSC physical-output router with safety caps, cooldown, and panic stop

- What it is:
  a local bridge normalizes avatar OSC/device commands into a controlled queue,
  applies safety limits, exposes status, and routes output to physical-device
  backends only through explicit gates.
- Good for:
  haptics, accessory-control bridges, device-control sidecars, consent-first
  physical feedback, and safety-focused bridge design.
- Why it matters:
  physical output must fail safe. Queue clearing, cooldown, hard caps, panic
  stop, consent, and visible status are architecture, not polish.
- Source evidence:
  `VRChat-Shocker-Link-CPP`, `DG-LAB-VRChat-Sensora`,
  `DG-LAB-VRCOSC`, and `VRC-DGLAB`.
- Reusable core:
  discover or configure OSC parameters, normalize incoming commands, enqueue
  actions with source labels, enforce max duration/intensity and rate limits,
  allow global disable and panic queue clearing, expose chatbox/UI status, and
  isolate device backends behind explicit service boundaries.
- Do not copy directly:
  shocker/DG-LAB-specific semantics, external API assumptions, credential
  handling, or any action path that bypasses consent and local safety controls.
- Strong references:
  `poprox24/VRChat-Shocker-Link-CPP`,
  `Null-K/DG-LAB-VRChat-Sensora`,
  `ccvrc/DG-LAB-VRCOSC`, `ion-aluminium/VRC-DGLAB`.
- Maturity:
  strong method candidate with mandatory safety review.
- Best fit for `VR-apps-lab`:
  physical-output safety requirements and device-neutral router design.

## Method 623: Parameter-threshold physical output mapper with distance, touch, and trigger modes

- What it is:
  avatar parameters are mapped to physical-output actions through explicit
  rules, modes, thresholds, waveforms, channels, and bounded durations.
- Good for:
  contact receiver bridges, avatar menu controls, proximity feedback, and
  compact rule editors.
- Why it matters:
  simple bridges can stay understandable when intent mapping is separated from
  device actuation and bounded by visible rules.
- Source evidence:
  `VRCHAT-OSC-to-DGLAB`, `DG-LAB-VRChat-Sensora`, `ShockVRC`,
  and `PiShockTouch`.
- Reusable core:
  let users select avatar parameters, choose match modes or value ranges,
  select a mode such as distance/touch/trigger, clamp channel/intensity/duration
  fields, map normalized values to device-safe commands, and expose reset or
  cooldown behavior.
- Do not copy directly:
  default shock/device parameters, raw float-to-intensity conversions, silent
  avatar config patching, or missing emergency stop behavior.
- Strong references:
  `boyqiu-001/VRCHAT-OSC-to-DGLAB`,
  `Null-K/DG-LAB-VRChat-Sensora`, `noideaman/ShockVRC`,
  `DesMakesStuff/PiShockTouch`.
- Maturity:
  useful mapper pattern, incomplete without Method 622 safety gates.
- Best fit for `VR-apps-lab`:
  avatar intent schema and contact receiver rule editor notes.

## Method 624: MIDI/DMX live-performance bridge with backpressure and sync telemetry

- What it is:
  MIDI is used as a VRChat control/data plane for DMX, physical controller
  mirrors, and live performance state, with sender backpressure and world-side
  telemetry.
- Good for:
  VRChat events, music worlds, lighting control, DJ/controller props, and world
  control channels.
- Why it matters:
  high-rate MIDI can crash or desync worlds unless the transport makes
  readiness, loss, latency, and rate limits visible.
- Source evidence:
  `VRC-MIDIDMX`, `UDJ-1000`, and `vrcMidiOverNetworkExample`.
- Reusable core:
  pack control data into MIDI messages, reserve control/handshake messages,
  filter noisy hardware input, update Udon state arrays, serialize only through
  ownership-aware paths, expose send success/loss/latency counters, and pause
  senders until the world reports readiness.
- Do not copy directly:
  crash-prone MIDI flooding, device-specific CC maps, demo sync loops, or
  shader/world layouts without target testing.
- Strong references:
  `micksam7/VRC-MIDIDMX`, `laserimouto/UDJ-1000`,
  `labthe3rd/vrcMidiOverNetworkExample`.
- Maturity:
  strong but world-specific.
- Best fit for `VR-apps-lab`:
  live-performance control and backpressure matrix.

## Method 625: Piano/MIDI note-to-OSC sender with GUI/CLI profile mapping

- What it is:
  MIDI notes, pedals, and files are mapped to VRChat OSC key/path schemas with
  device selection, profile persistence, reset behavior, and performer UX.
- Good for:
  VRChat piano worlds, performer companion apps, music automation, and input
  bridge baselines.
- Why it matters:
  different worlds use different path schemas; reusable tools need profile
  mapping, stuck-note reset, and device UX.
- Source evidence:
  `OSCMidi`, `OSCPianoPlayer`, `midi-osc-client`,
  `USharp-midi-tuna`, and `vrc_midi_transposer`.
- Reusable core:
  list and open MIDI devices, persist selected ports and path schemas, map note
  on/off to indexed or named OSC paths, handle sustain/pedal controls, reset
  stuck keys, optionally schedule MIDI files, and expose note/particle/voice
  limits to the user.
- Do not copy directly:
  hardcoded world paths, old MIDI libraries, setup bugs, bundled build
  artifacts, or note naming as a universal standard.
- Strong references:
  `Mathieu52/OSCMidi`, `ShadowForests/OSCPianoPlayer`,
  `MaverickLong/midi-osc-client`, `fltuna/USharp-midi-tuna`,
  `marcus-universe/vrc_midi_transposer`.
- Maturity:
  mature as a family pattern, fragmented by world schemas.
- Best fit for `VR-apps-lab`:
  performer utility and OSC path compatibility notes.

## Method 626: Twitch/audience event to OSC action-rule engine

- What it is:
  audience events become typed trigger rules that execute bounded VRChat OSC
  actions through permission gates, cooldowns, reward identity, queues, and
  world/context guards.
- Good for:
  streamer tools, audience interaction, channel-point controls, moderation-aware
  command panels, and remote event bridges.
- Why it matters:
  audience control can become remote control of a user's avatar or world; rule
  identity and moderation gates are the safety boundary.
- Source evidence:
  `crystal-relay-public` and `TwitchIntegration`.
- Reusable core:
  model trigger type, command/reward identity, access roles, costs/ranges,
  global and per-user cooldowns, actions with target/default/duration fields,
  queued or parallel execution, reward lifecycle sync, world/context guards,
  and user-visible feedback.
- Do not copy directly:
  credentials, hosted guard dependencies, product-specific reward management,
  or broad action sets without streamer-owned controls.
- Strong references:
  `seluvia/crystal-relay-public`, `Killers0992/TwitchIntegration`.
- Maturity:
  strong product/reuse pattern.
- Best fit for `VR-apps-lab`:
  audience event bridge and safe remote-control rule schemas.

## Method 627: Twitch chat command bot with timed OSC pulse actions

- What it is:
  a lightweight bot maps Twitch chat commands to OSC parameter pulses and
  resets them after a short duration.
- Good for:
  small streamer utilities, stage/camera controls, proof-of-value bots, and
  simple audience command surfaces.
- Why it matters:
  many audience tools start as command-to-pulse scripts; documenting the safe
  minimal boundary prevents hardcoded, unbounded remote control.
- Source evidence:
  `EZTwitchOSCBot`, `VRChatTwitchOSCTrigger`, `RizumuBot`, and `LucentOSC`.
- Reusable core:
  connect to chat, parse prefixed commands, filter senders or roles, map
  aliases to OSC paths and values, send an on value, wait a bounded duration,
  send a reset value, apply cooldown/whitelist/profile settings, and report
  status to the streamer.
- Do not copy directly:
  hardcoded channels, no-auth public control, missing moderation, raw OAuth
  handling, or unbounded command execution.
- Strong references:
  `AcChosen/EZTwitchOSCBot`, `Motscoud/VRChatTwitchOSCTrigger`,
  `exmello/RizumuBot`, `Maikatura/LucentOSC`.
- Maturity:
  useful micro-pattern when wrapped in safety gates.
- Best fit for `VR-apps-lab`:
  streamer command deck and timed OSC action baselines.

## Method 628: Provider-backed chatbox status composer with templates, cropping, and cadence

- What it is:
  a VRChat chatbox sidecar collects status from one or more providers, renders
  it through a bounded template, applies privacy/cropping rules, and sends at a
  controlled cadence.
- Good for:
  media status, IDE presence, lyrics, system telemetry, active-window status,
  heart rate, speech translation, and compact availability indicators.
- Why it matters:
  the hard part is not sending OSC; it is preventing stale, spammy, too-long,
  or privacy-leaking messages.
- Source evidence:
  `VRChatStatusTask`, `vrc-osc-mpris`, `vrchat-osc-windows-media`,
  `sillyosc`, `mpd-vrchat-osc`, `VRC-Lyrics`, and `VRCTalk`.
- Reusable core:
  isolate each source as a provider, normalize source fields, render through a
  user-visible template, crop or omit sensitive fields, debounce unchanged
  output, send at a bounded cadence, and clear or stop the chatbox output when
  disabled.
- Do not copy directly:
  raw editor lines, active window names, speech transcripts, cloud credentials,
  or fixed message formats without user control.
- Strong references:
  `AtomikkuLabs/VRC-Lyrics`, `Null-K/VRChatStatusTask`,
  `KannaCS/VRCTalk`, `lexiuwu71/sillyosc`.
- Maturity:
  strong reusable method.
- Best fit for `VR-apps-lab`:
  chatbox composer contract, privacy matrix, and status sidecar prototypes.

## Method 629: Plugin or module fan-in chatbox composer

- What it is:
  a chatbox host loads small modules that each return optional text, then joins
  their outputs into one bounded message.
- Good for:
  MOTD/status tools, extensible chatbox dashboards, AFK/status modules, media
  status, PC stats, and local custom scripts.
- Why it matters:
  plugin fan-in lets tiny utility ideas compose without turning the repository
  into one monolithic status app.
- Source evidence:
  `kotleni/vrchat-osc-motd`, with comparison value from `RustyChatBox` and
  `VRChat-OSC-ChatBox`.
- Reusable core:
  define a plugin lifecycle, load enabled modules, collect non-empty outputs,
  apply per-module and global length policy, join messages deterministically,
  and route through one OSC sender with clear logging.
- Do not copy directly:
  unsandboxed dynamic plugin loading, fixed ports, or plugins that expose
  sensitive data without a permission model.
- Strong references:
  `kotleni/vrchat-osc-motd`.
- Maturity:
  promising local-extension method.
- Best fit for `VR-apps-lab`:
  modular status/composer sidecars and plugin trust policy.

## Method 630: Audio loopback to normalized avatar parameters

- What it is:
  a sidecar captures system audio, computes normalized audio features, smooths
  them, and sends avatar parameters only when values materially change.
- Good for:
  external AudioLink-style tools, music-reactive avatars, volume/direction
  parameters, performer utilities, and visualizers.
- Why it matters:
  VRChat avatar parameters need bounded, smoothed, low-spam values instead of
  raw audio-rate data.
- Source evidence:
  `VRC-OSC-Audio-Reaction` and `VRC-Visualizer`.
- Reusable core:
  capture loopback or input audio, compute volume/band/direction features,
  smooth and clamp values, apply a minimum precision floor if needed, threshold
  unchanged sends, and document avatar-side parameter contracts.
- Do not copy directly:
  hardcoded devices, high-frequency audio-callback sends, telemetry defaults,
  or Windows-only assumptions as the only backend.
- Strong references:
  `Codel1417/VRC-OSC-Audio-Reaction`, `FreneticFurry/VRC-Visualizer`.
- Maturity:
  strong method candidate.
- Best fit for `VR-apps-lab`:
  external audio-reactivity and AudioLink-style sidecar design.

## Method 631: Avatar-parameter triggered local soundpack with OSCQuery discovery

- What it is:
  a local sidecar advertises sound trigger parameters, plays local one-shot or
  looping audio when VRChat toggles them, and supports soundpack import/export.
- Good for:
  local soundboards, avatar-triggered SFX, stream companion tools, accessibility
  audio cues, and debug packs.
- Why it matters:
  OSCQuery reduces manual setup friction and soundpacks make local audio
  utilities portable.
- Source evidence:
  `octalmage/oscsound`.
- Reusable core:
  model sounds as name, parameter, path, type, and volume; advertise
  parameters via OSCQuery; trigger one-shots on rising edges; start/stop loops
  on boolean state; preview locally; and import/export packs with a manifest.
- Do not copy directly:
  assumptions that other users hear local playback, untrusted soundpack paths,
  or missing rate limits.
- Strong references:
  `octalmage/oscsound`.
- Maturity:
  strong product/method donor.
- Best fit for `VR-apps-lab`:
  OSCQuery-aware soundboard and local asset pack patterns.

## Method 632: Avatar menu to OS/media-control command bridge

- What it is:
  avatar boolean parameters are mapped to local operating-system commands such
  as media keys, keyboard actions, or small automation commands.
- Good for:
  in-VR media controls, accessibility shortcuts, desktop automation, recording
  controls, and utility toggles.
- Why it matters:
  many useful VR utilities are just safe bridges from avatar/menu state to
  local OS actions.
- Source evidence:
  `vrc-osc-audio-controls` and `vrchat-osc-automator`.
- Reusable core:
  listen for explicit command parameters, act on rising or bounded values,
  map only to visible allowlisted commands, debounce repeated sends, expose a
  reset/stop path, and make dangerous OS automation opt-in.
- Do not copy directly:
  fragile OSC string parsing, broad shell execution, or hidden command maps.
- Strong references:
  `shadorki/vrc-osc-audio-controls`, `njm2360/vrchat-osc-automator`.
- Maturity:
  useful micro-utility method.
- Best fit for `VR-apps-lab`:
  safe in-VR local control surfaces.

## Method 633: XSOverlay notification bridge with Discord client hooks

- What it is:
  a Discord client hook normalizes notification events and forwards them to an
  existing VR overlay host as structured notification payloads.
- Good for:
  VR notifications, Discord-in-headset utilities, overlay communication
  surfaces, and notification routing sidecars.
- Why it matters:
  user-facing notification quality depends on filtering, context, payload
  fields, and transport compatibility.
- Source evidence:
  `xsOverlayVencord`, `XSOverlay-BetterDiscord`,
  `XSOverlay-Discord-Notifications`, and
  `XSOverlay-BetterDiscord-Notifications`.
- Reusable core:
  filter self/bot/muted messages, preserve DM/guild/channel/call context,
  normalize embeds/stickers/attachments/mentions, fetch or omit icons based on
  privacy settings, build the overlay notification payload, and send through
  WebSocket or UDP transport.
- Do not copy directly:
  Discord client internals, stale mod APIs, broad message exposure, or image
  fetches without privacy controls.
- Strong references:
  `nyakowint/xsOverlayVencord`, `Eidenz/XSOverlay-BetterDiscord`.
- Maturity:
  useful but compatibility-sensitive.
- Best fit for `VR-apps-lab`:
  overlay notification bridge and message-normalization matrices.

## Method 634: Authenticated remote notification proxy into an existing VR overlay host

- What it is:
  a local proxy accepts remote notification requests with authentication and
  forwards validated payloads to an overlay host's local protocol.
- Good for:
  server alerts, bots, CI notifications, stream events, home automation, and
  phone-to-VR notifications.
- Why it matters:
  remote notification ingress crosses a network trust boundary and needs
  explicit auth, rate limiting, health checks, and payload validation.
- Source evidence:
  `GreyFoxx74/xsoverlay-proxy`.
- Reusable core:
  require a non-default secret, expose a health endpoint, accept a bounded
  notification schema, apply rate limits, forward to local overlay UDP or
  WebSocket, provide a CLI sender, and document firewall/TLS assumptions.
- Do not copy directly:
  self-signed cert shortcuts, verify-disabled clients, public bind defaults,
  or plaintext secrets without rotation.
- Strong references:
  `GreyFoxx74/xsoverlay-proxy`.
- Maturity:
  strong method with security review required.
- Best fit for `VR-apps-lab`:
  secure event-to-overlay proxy design.

## Method 635: Avatar remote board and automation sender with named actions

- What it is:
  a sidecar exposes named controls or sequences that send typed VRChat OSC
  actions through an authenticated board or macro interface.
- Good for:
  remote avatar control, accessibility panels, streamer/admin controls,
  avatar testing, macro decks, and collaborative control surfaces.
- Why it matters:
  remote control is useful only when it is scoped, typed, authenticated,
  resettable, and visible to the user.
- Source evidence:
  `VRC-Avatar-Remote-Server`, `vrchat-osc-automator`,
  `SimpleVRChatOSCSender`, and `VRChat-OSC-Toys`.
- Reusable core:
  model controls as typed actions, validate target avatar and parameter type,
  require auth or local trust, send button/toggle/range or sequence actions,
  mirror state back to clients, reset values or held inputs on completion and
  interruption, and support import/export only through validation.
- Do not copy directly:
  unauthenticated internet-exposed boards, unsafe OS input automation, or
  profiles that can execute hidden commands.
- Strong references:
  `jangxx/VRC-Avatar-Remote-Server`,
  `njm2360/vrchat-osc-automator`,
  `t-34400/SimpleVRChatOSCSender`.
- Maturity:
  strong method family.
- Best fit for `VR-apps-lab`:
  secure remote-control boards and OSC automation sequence schemas.

## Method 636: External device/status to avatar parameter micro-bridge

- What it is:
  a small sidecar polls or reads external state and publishes normalized avatar
  parameters only when needed.
- Good for:
  time, smart-home state, light color, device battery/status, weather, heart
  rate, sensor values, and compact avatar-driven environmental effects.
- Why it matters:
  micro-bridges are valuable when their parameter contract is explicit and
  their credential/polling behavior is safe.
- Source evidence:
  `OSCTimeSender`, `vrchat-light-sync`, with comparison to earlier sensor and
  device-status waves.
- Reusable core:
  define a tiny parameter schema, read external state, normalize values to
  VRChat-friendly bool/int/float/string fields, poll at a bounded cadence,
  send only on change when possible, and store credentials safely.
- Do not copy directly:
  fixed paths/ports, plaintext bearer tokens, panic-on-network-failure loops,
  or high-frequency polling of remote services.
- Strong references:
  `hrolfurgylfa/vrchat-light-sync`, `TheUnifox/OSCTimeSender`.
- Maturity:
  useful micro-utility method.
- Best fit for `VR-apps-lab`:
  device/status bridge schema and small utility prototypes.

## Method 637: Module-pack distribution boundary for VR utility hosts

- What it is:
  a VR utility host exposes a stable module lifecycle, settings model,
  persistence layer, runtime views, and send/reset helpers so independently
  shipped modules can each own one source or action boundary.
- Good for:
  VRCOSC-like plugin hosts, overlay module packs, sensor modules, service
  bridges, avatar parameter helpers, and third-party utility ecosystems.
- Why it matters:
  a host becomes reusable when modules can be added without changing host
  internals, but every module still needs a clear trust surface.
- Source evidence:
  `VRCOSC-Modules`, `CrookedToe-s-Modules`, `Yeusepes-Modules`, `FuviiOSC`,
  `VRCOSC-BluetoothHeartrate`, `VrcOscLeash`, and `File-Reading-Module`.
- Reusable core:
  define module lifecycle hooks, typed settings, grouped parameters, persistent
  module state, runtime status views, host-owned OSC send helpers, neutral reset
  behavior, per-module docs/prefab contracts, and explicit module trust labels.
- Do not copy directly:
  physical-output modules, service credentials, OpenVR movement manipulation,
  local file reads, or BLE/network side channels without permission and safety
  review.
- Strong references:
  `VolcanicArts/VRCOSC-Modules`, `CrookedToe/CrookedToe-s-Modules`,
  `FuviiPeshu/FuviiOSC`.
- Maturity:
  strong method family.
- Best fit for `VR-apps-lab`:
  future utility host/plugin architecture and third-party module trust policy.

## Method 638: Event-source to avatar parameter queue with accumulator and decay

- What it is:
  an external live-event source is normalized into typed queues, then fanned out
  to chatbox messages, avatar parameters, animation triggers, counters, and
  time-decaying values.
- Good for:
  Twitch/Bilibili/Discord audience bridges, livestream event overlays, reward
  counters, avatar reactions, moderation-aware automation, and chatbox
  notifications.
- Why it matters:
  live events are bursty and remote-controlled; queueing, accumulation,
  backpressure, moderation, and decay are the safe architecture boundary.
- Source evidence:
  `VRCOSC-Bilibili`, `VRCOSC-Modules` Twitch module, and earlier audience-event
  waves.
- Reusable core:
  normalize provider events, split provider API code from output consumers,
  enqueue chatbox and OSC work separately, accumulate counters when useful,
  decay parameters over time, bound queue size/rate, and expose event/source
  enablement in configuration.
- Do not copy directly:
  provider credentials, browser-cookie assumptions, hardcoded event names, or
  unbounded remote action queues.
- Strong references:
  `TZFC/VRCOSC-Bilibili`, `VolcanicArts/VRCOSC-Modules`.
- Maturity:
  strong method candidate.
- Best fit for `VR-apps-lab`:
  audience-event sidecars and live-service-to-avatar bridges.

## Method 639: Shared-room adapter contract with reliable/unreliable transport and media streams

- What it is:
  a WebXR room adapter owns signaling, presence, reliable control messages,
  high-rate unreliable state, reconnect behavior, and optional audio/video
  stream access behind one framework-facing interface.
- Good for:
  shared WebXR rooms, A-Frame/social XR apps, spatial collaboration tools,
  media rooms, cross-runtime room clients, and multiplayer diagnostics.
- Why it matters:
  networking utility code should not hardwire WebRTC, Firebase, Janus, Socket.IO,
  media streams, and moderation into scene components.
- Source evidence:
  `naf-firebase-adapter`, `naf-janus-adapter`, `naf-valid-avatars`,
  `networked-aframe-unity-client`, and `networked-resonance-audio`.
- Reusable core:
  separate adapter lifecycle from scene entities, model presence and peers,
  provide reliable and unreliable send paths, expose media stream getters and
  setters, freeze or buffer during reconnect, surface block/kick/moderation
  primitives, and gate UI features by adapter capability.
- Do not copy directly:
  stale backend APIs, public credentials, unauthenticated media sharing, or
  server deployment assumptions hidden inside components.
- Strong references:
  `mozilla/naf-janus-adapter`, `networked-aframe/naf-firebase-adapter`,
  `networked-aframe/naf-valid-avatars`.
- Maturity:
  strong reusable method.
- Best fit for `VR-apps-lab`:
  shared-room substrates and future browser-native utility collaboration.

## Method 640: Shared-room entity persistence and ownership handoff

- What it is:
  a shared XR scene persists entities by stable ids and defines what happens to
  ownership, local edits, remote edits, and media state when participants join,
  leave, or reconnect.
- Good for:
  collaborative WebXR editors, shared media rooms, multiplayer whiteboards,
  persistent object layouts, and room-state recovery.
- Why it matters:
  persistence without ownership rules creates duplicate entities, stale remote
  objects, or lost edits.
- Source evidence:
  `naf-persist`, `naf-entity-saver`, and
  `networked-aframe-synced-video-example`.
- Reusable core:
  serialize only allowed entity attributes/components, store by stable DOM or
  network id, decide local-versus-remote conflict policy, persist owner-gated
  state separately from media assets, provide explicit leave-time handoff, and
  treat owner transfer as a first-class event.
- Do not copy directly:
  broad component serialization, monkeypatching networking internals, blind
  preservation of every remote entity, or synced media without drift/buffer
  policy.
- Strong references:
  `martintribo/naf-persist`,
  `chenzlabs/networked-aframe-synced-video-example`.
- Maturity:
  promising but needs conflict policy.
- Best fit for `VR-apps-lab`:
  shared WebXR room persistence and collaborative authoring prototypes.

## Method 641: Serializable XR authoring surface with in-headset edit primitives

- What it is:
  a lightweight XR authoring tool lets users select, place, grab, scale, edit,
  serialize, undo, and export VR content through a small manifest, graph, scene
  metadata, animation curve, or level file.
- Good for:
  360 tour builders, A-Frame/WebXR scene editors, visual node graphs, VR text
  workspaces, in-VR Unity animation tools, and creator microtools.
- Why it matters:
  authoring tools become reusable when the editing interaction and persistence
  format are explicit, small, and recoverable.
- Source evidence:
  `VRTourEditor`, `aframe-vreditor-component`, `GNode`,
  `WebXR_VRController_Editor_template`, `vrcode`, `UnityVRAnimationEditor`,
  `webgl-vr-editor`, and `VRC-Editor-Toolbox`.
- Reusable core:
  support clear selection feedback, controller ray or grip manipulation,
  transform preservation on grab/reparent, clone/scale operations when needed,
  undo or reset, a documented serialized format, autosave or export, and a
  desktop/editor bridge when the target workflow is Unity or VRChat.
- Do not copy directly:
  old controller APIs, missing undo, generated scene names as universal input
  bindings, UnityEditor reflection without migration plan, or arbitrary import
  data without validation.
- Strong references:
  `Humangle/VRTourEditor`, `umiyuki/UnityVRAnimationEditor`,
  `caseyyee/aframe-vreditor-component`, `wakufactory/GNode`.
- Maturity:
  strong UX/method family, implementation maturity varies by project.
- Best fit for `VR-apps-lab`:
  authoring spikes, creator utilities, and documentation of editor interaction
  patterns.

## Method 642: Vendor tracker/glove protocol interpreter to generic VR bridge

- What it is:
  a vendor-specific tracker or glove protocol is decoded at the edge and
  republished through a generic VR-facing contract such as SteamVR/OpenVR
  input, SlimeVR UDP, VMC/OSC, VRChat avatar parameters, or local input events.
- Good for:
  ContactGlove, Haritora, DIY trackers, wearable sensors, custom controllers,
  avatar setup packages, and tracking helper sidecars.
- Why it matters:
  the reusable part is not the vendor packet itself; it is the interpreter,
  calibration, role mapping, diagnostics, and output boundary.
- Source evidence:
  `freescuba`, `ContactGloveOSC`, `Glove2Kb`,
  `haritorax-slimevr-bridge`, `haritorax-interpreter`,
  `haritora-gx-poc`, `HaritoraToSlime`, and
  `osc_haritorax2_camera_tracking`.
- Reusable core:
  isolate transport adapters, decode raw packets into normalized domain values,
  preserve device identity and roles, expose battery/status/button/quality
  signals, choose one generic output contract, provide calibration and stale
  data handling, and keep diagnostics visible.
- Do not copy directly:
  driver installation, hardware VID/PID assumptions, Index controller
  impersonation, OS input injection, unwrap-heavy loops, or vendor parameters
  without compatibility review.
- Strong references:
  `hyblocker/freescuba`, `sim1222/haritorax-slimevr-bridge`,
  `JovannMC/haritorax-interpreter`.
- Maturity:
  strong method family with high platform/hardware risk.
- Best fit for `VR-apps-lab`:
  tracker bridge architecture, receiver protocols, and hardware-integration
  diagnostics.

## Method 643: Tracking fusion sidecar with preflight, diagnostics, and event fan-out

- What it is:
  a tracking helper combines multiple input sources, runs fusion/state logic,
  gates startup with preflight checks, and fans processed frames into optional
  outputs such as OSC/VMC, dashboards, REST APIs, OBS overlays, recordings, and
  notifications.
- Good for:
  camera-plus-IMU tracking, body tracker helpers, calibration utilities,
  streamer diagnostics, motion capture recorders, and headset/tracker support
  tools.
- Why it matters:
  tracking utilities fail in messy real environments; diagnostics, mode state,
  and actionable preflight are what make the tool operable.
- Source evidence:
  `Fuwaaaaaa/osc_haritorax2_camera_tracking`, with comparison value from
  Haritora and SlimeVR bridge variants.
- Reusable core:
  select receivers through config, run heavy camera/inference work in a separate
  process or boundary, fuse camera positions and IMU rotations through a state
  machine, publish frame events to optional subscribers, validate models,
  calibration files, and ports before startup, expose dashboard/API status, and
  test protocol/calibration/persistence boundaries.
- Do not copy directly:
  camera/model defaults, app-specific UI assets, hardware assumptions, or
  calibration shortcuts without user-facing setup.
- Strong references:
  `Fuwaaaaaa/osc_haritorax2_camera_tracking`.
- Maturity:
  strong sidecar architecture donor.
- Best fit for `VR-apps-lab`:
  future tracking diagnostics, calibration helpers, and body-tracking runtime
  sidecars.

## Method 644: WebXR runtime device abstraction behind guarded API injection

- What it is:
  a WebXR fallback or emulator exposes an app-facing `navigator.xr` surface
  while routing session, frame, pose, view, input, and feature behavior through
  a replaceable device backend.
- Good for:
  browser-native XR prototypes, emulator shells, headsetless development,
  compatibility shims, runtime diagnostics, and WebXR feature test harnesses.
- Why it matters:
  WebXR utility code should not hardwire browser quirks or headset state into
  scene components; the reusable boundary is the device/runtime adapter.
- Source evidence:
  `immersive-web/webxr-polyfill`, `holokit/holokit-webxr`,
  `mvilledieu/magicleap-helio-webxr-polyfill`.
- Reusable core:
  guard global API injection, patch only missing or incompatible browser
  surfaces, define a device backend for sessions, animation frames, viewports,
  projection/base poses, input sources, input poses, reference spaces, and
  feature support, and keep vendor/browser drift isolated in small shims.
- Do not copy directly:
  stale WebVR/Cardboard assumptions, old draft method names, hardcoded user
  agents, viewer-specific projection quirks, or broad monkeypatches without a
  capability gate.
- Strong references:
  `immersive-web/webxr-polyfill`, `michelesandroni/xrview`.
- Maturity:
  conceptually strong, implementation must track current WebXR behavior.
- Best fit for `VR-apps-lab`:
  WebXR runtime compatibility matrix, browser-native prototype shell, and
  headsetless test harness.

## Method 645: WebXR emulator shell with separated operator UI and injected page runtime

- What it is:
  an extension or standalone shell injects a synthetic WebXR runtime into a
  page while a separate operator UI controls device pose, input, device type,
  and session state.
- Good for:
  developer tooling, WebXR UX iteration, demo testing without a headset,
  emulator panels, and browser-shell diagnostics.
- Why it matters:
  emulator state should be controlled from a trusted tool boundary and passed
  to page code through explicit bounded messages.
- Source evidence:
  `MozillaReality/WebXR-emulator-extension`, `michelesandroni/xrview`.
- Reusable core:
  inject runtime code early, keep panel/toolbar code separate from page code,
  pass pose/input/device messages through a content-script or shell bridge,
  mirror immersive/session state back to the operator UI, validate navigation,
  and isolate native/shell capabilities from untrusted content.
- Do not copy directly:
  stale spec names, extension-only assumptions, all-powerful webviews,
  unvalidated URL schemes, or native capability exposure to arbitrary pages.
- Strong references:
  `michelesandroni/xrview`, `MozillaReality/WebXR-emulator-extension`.
- Maturity:
  strong product-method candidate with security review required.
- Best fit for `VR-apps-lab`:
  future WebXR emulator/playground shell and runtime doctor tooling.

## Method 646: WebXR input-profile metadata to engine visual-response model loader

- What it is:
  a utility resolves WebXR input-source profiles into profile JSON, layout
  routing, model assets, and visual-response transforms for rendering
  controller models inside an engine or UI shell.
- Good for:
  controller visualizers, emulator UIs, input diagnostics, onboarding demos,
  runtime compatibility tools, and cross-engine WebXR helpers.
- Why it matters:
  controller visuals and affordances should follow runtime-reported profile
  metadata instead of hardcoded per-device assumptions.
- Source evidence:
  `De-Panther/webxr-input-profiles-loader`, with comparison value from
  `pmndrs/xr` controller layout/model helpers.
- Reusable core:
  resolve profile-name lists, load the profile registry and profile JSON, cache
  handedness layout routing, load glTF assets, map component visual responses
  to named nodes, and drive transforms from button/axis state.
- Do not copy directly:
  CDN-only asset assumptions, engine-specific asset packaging, missing offline
  cache, or shader/model defaults without fallback.
- Strong references:
  `De-Panther/webxr-input-profiles-loader`, `pmndrs/xr`.
- Maturity:
  practical reusable method.
- Best fit for `VR-apps-lab`:
  controller diagnostics, emulator UI, and input-profile compatibility notes.

## Method 647: Declarative XR component primitive with schema, lifecycle, and event payloads

- What it is:
  a reusable XR scene behavior is packaged as a component with explicit schema,
  setup/update/remove lifecycle, asset ownership, input adapters, and typed
  events.
- Good for:
  A-Frame utilities, browser-native prototypes, locomotion helpers, keyboards,
  environment presets, rendering helpers, and small scene tools.
- Why it matters:
  small utilities remain reusable when configuration, input, output events, and
  cleanup are visible instead of buried in scene code.
- Source evidence:
  `aframe-cursor-teleport`, `aframe-super-keyboard`,
  `aframe-environment-component`, `aframe-blink`,
  `aframe-daylight-system`, `aframe-environment-map-component`,
  and `aframe-react`.
- Reusable core:
  declare a narrow schema, attach only needed runtime objects, support one
  behavior, handle ray/cursor/UV/controller input through a small adapter, emit
  useful events with target/value/pose payloads, and clean up generated objects
  and listeners.
- Do not copy directly:
  global listeners without cleanup, old A-Frame APIs as current best practice,
  giant hardcoded presets without schema, or hidden render visibility side
  effects.
- Strong references:
  `supermedium/aframe-super-keyboard`, `topstar-ai/aframe-blink`,
  `c-frame/aframe-cursor-teleport`.
- Maturity:
  strong method family, implementation age varies.
- Best fit for `VR-apps-lab`:
  component template guidance for browser XR micro-utilities.

## Method 648: Scene physics driver boundary with worker/network interpolation

- What it is:
  scene entities declare physics bodies while a system/driver boundary owns the
  physics engine, stepping, worker or network transport, snapshots, and
  collision/contact events.
- Good for:
  interaction labs, hand-object tests, small editors, shared scenes, physics
  diagnostics, and engine-agnostic scene utilities.
- Why it matters:
  physics becomes reusable only when object declarations are separated from the
  runtime stepping/threading model.
- Source evidence:
  `n5ro/aframe-physics-system`.
- Reusable core:
  expose local/worker/network/engine drivers, cap timestep, map scene geometry
  to body shapes, sync static bodies to physics and dynamic bodies back to
  scene objects, serialize worker snapshots, interpolate remote state, and emit
  collision/contact events.
- Do not copy directly:
  stale physics engines, unchecked auto-shape generation, network physics
  without ownership policy, or worker transports without debug visibility.
- Strong references:
  `n5ro/aframe-physics-system`.
- Maturity:
  useful architecture method with dependency-age caveats.
- Best fit for `VR-apps-lab`:
  interaction/physics lab spikes and reusable object-affordance testing.

## Method 649: Godot protocol source to XRServer tracker bridge

- What it is:
  a Godot addon decodes an external tracking protocol and publishes normalized
  body, face, hand, or device data through Godot `XRServer` trackers.
- Good for:
  VMC/OSC bridges, Rokoko/Axis/Haritora style mocap sources, custom body
  trackers, avatar drivers, calibration utilities, and recording tools.
- Why it matters:
  engine tools should consume engine-native trackers, while protocol parsing,
  role mapping, calibration, and packet caveats stay in a source plugin.
- Source evidence:
  `GodotXRVmcTracker`, `GodotXRAxisStudioTracker`,
  `GodotXRRokokoTracker`, and `GodotXROpenXRTracker`.
- Reusable core:
  isolate transport/protocol parsing, register the right tracker types,
  normalize joints/blendshapes/buttons/status, support position modes and root
  transform policy, publish confidence/tracking flags, and expose diagnostics
  for stale data, ports, and source health.
- Do not copy directly:
  fixed ports, unauthenticated OSC, vendor joint names in scene code, missing
  stale-data behavior, or calibration assumptions hidden from users.
- Strong references:
  `Malcolmnixon/GodotXRVmcTracker`.
- Maturity:
  strong bridge method.
- Best fit for `VR-apps-lab`:
  Godot tracking bridge templates, tracker diagnostics, and source-to-engine
  comparison matrices.

## Method 650: XR tracker stream to engine animation/resource recorder

- What it is:
  a recorder samples live XR trackers and writes timed body, hand, face,
  blendshape, and root-motion data into replayable engine resources or
  animation tracks.
- Good for:
  tracking diagnostics, mocap capture, calibration comparison, regression
  repros, avatar animation authoring, and replay tools.
- Why it matters:
  live tracking problems need inspectable artifacts; recording turns ephemeral
  pose streams into reviewable data.
- Source evidence:
  `Malcolmnixon/GodotXRAnimationRecorder`, with comparison value from earlier
  mocap/recording waves.
- Reusable core:
  select trackers by name or role, sample at a stable cadence, preserve
  monotonic timestamps, write skeleton position/rotation tracks, record face
  blendshapes and optional root motion, separate capture from output writing,
  and optimize/export after stop.
- Do not copy directly:
  engine-only output as the only archival format, hidden tracker-name
  assumptions, missing unit/world-scale metadata, or no replay/export path.
- Strong references:
  `Malcolmnixon/GodotXRAnimationRecorder`.
- Maturity:
  strong diagnostic method.
- Best fit for `VR-apps-lab`:
  tracker recorder/replay utilities and calibration debug artifacts.

## Method 651: Modular XR toolkit function node with explicit composition contracts

- What it is:
  XR player behavior is decomposed into attachable functions or nodes such as
  teleport, pickup, hand pose, UI, snapping, movement providers, debug, and
  spectator views.
- Good for:
  Godot XR kits, Unity/Godot interaction labs, custom player rigs, in-headset
  authoring tools, and reusable comfort/locomotion helpers.
- Why it matters:
  XR toolkits become hard to reuse when all hands, locomotion, UI, and comfort
  logic are fused into one player controller.
- Source evidence:
  `BastiaanOlij/godot-xr-tools2`, `RevolNoom/godot_xr_handtracking`,
  `patrykkalinowski/godot-xr-kit`.
- Reusable core:
  model each behavior as one node/function, expose exported options, emit
  start/cancel/done or pose/pick events, coordinate with movement providers,
  support overridable validation checks, and keep fade/comfort effects visible.
- Do not copy directly:
  WIP APIs without version tracking, hand-only assumptions, hidden player-rig
  dependencies, or behavior nodes that silently override other movement.
- Strong references:
  `BastiaanOlij/godot-xr-tools2`.
- Maturity:
  strong method, concrete APIs still moving.
- Best fit for `VR-apps-lab`:
  reusable Godot/engine interaction primitives and toolkit comparison notes.

## Method 652: React/Three XR store plus spatial UI/lab substrate

- What it is:
  a browser-native XR utility stack centralizes WebXR session/input state in a
  store, renders spatial UI through a layout/input substrate, and hosts focused
  interaction labs with HUD, live tuning, and logs.
- Good for:
  browser-native VR utilities, diagnostic HUDs, AR measurement tools, spatial
  settings panels, interaction experiments, and prototype shells.
- Why it matters:
  WebXR tools need more than scene meshes: they need runtime state, input
  abstraction, panels/forms, telemetry, and repeatable lab structure.
- Source evidence:
  `pmndrs/xr`, `pmndrs/uikit`, `webxr-playground`,
  `DefaultReactXR`, `xrTeleport`, `react-three-xr-measurement`,
  `BoltXR`, and `glb-ar-viewer`.
- Reusable core:
  bind a store to `WebXRManager`, synchronize input sources into typed states,
  expose pointer/teleport utilities, build UI with layout, clipping, scroll,
  text input and focus handling, register labs by mode/question, surface HUD
  metrics, allow live tuning, and store session notes.
- Do not copy directly:
  version-volatile internals without pinning, hidden DOM input assumptions
  without accessibility testing, old `@react-three/xr` APIs from microtools,
  product-specific crypto/security logic, or asset loading without validation.
- Strong references:
  `pmndrs/xr`, `pmndrs/uikit`, `kewanglab/webxr-playground`.
- Maturity:
  strongest browser-native substrate method in the current WebXR line.
- Best fit for `VR-apps-lab`:
  future browser-native utility shells, spatial UI prototypes, and interaction
  lab scaffolds.

## Method 653: Direct media/browser surface to OpenVR overlay texture loop

- What it is:
  a small surface producer, such as a media engine, Unity render texture,
  static/generated image, or browser/CEF surface, is rendered into a texture or
  image and submitted to an OpenVR overlay.
- Good for:
  video overlays, note/checklist panels, telemetry dashboards, browser-backed
  control panels, lightweight media surfaces, and proof-of-value overlay
  prototypes.
- Why it matters:
  many useful VR utilities start as one small surface; they do not need a full
  app framework before proving placement, input, and update-loop value.
- Source evidence:
  `iigomaru/MPVR`, `Yukiiro-Nite/notebook-vr-overlay`,
  `Daniel-Webster/WT-OpenVR-Overlay`, and `Wulkop/VolumeVR`.
- Reusable core:
  choose a surface producer, create an overlay app/session, create the overlay
  handle, set placement and texture bounds, route mouse/controller input when
  needed, update the surface texture/image, submit it to the overlay, and make
  lifecycle, persistence, and cleanup explicit.
- Do not copy directly:
  bundled binaries, hardcoded paths, hardcoded tracked-device indexes, old
  dependency versions, no-sandbox browser defaults, sleep-driven render loops,
  or missing cleanup as production behavior.
- Strong references:
  `iigomaru/MPVR` for direct media texture submission and
  `Daniel-Webster/WT-OpenVR-Overlay` for Unity telemetry overlay shell shape.
- Maturity:
  medium method; strong as a lower-bound architecture pattern, weaker as
  product-ready code.
- Best fit for `VR-apps-lab`:
  overlay media surfaces, note/checklist panels, telemetry overlays, and
  surface-producer comparison matrices.

## Method 654: XR glasses protocol workbench and head-tracked desktop viewport

- What it is:
  XR glasses are treated as a diagnosable device plus optional display surface:
  protocol code discovers HID interfaces, parses packets, reads IMU/status or
  calibration data, then a separate desktop or viewport layer uses that data.
- Good for:
  Xreal/Nreal diagnostics, WebHID workbenches, native protocol readers,
  head-tracked desktop helpers, virtual display experiments, drift correction,
  and lightweight spatial-display tools.
- Why it matters:
  vendor glasses work can become risky and tangled unless read-only diagnostics,
  command writing, calibration, and display UX are separated early.
- Source evidence:
  `jakedowns/xreal-webxr`, `edwatt/real_utilities`,
  `alexwilson1/nreal_linux_test`, and `Mailbot/Nreal_Air_Desktop_tool`.
- Reusable core:
  filter devices by vendor/product IDs, separate interface roles, define packet
  and command metadata, isolate parser/build helpers, expose read-only status
  and IMU flows, store calibration/drift state, and keep viewport/window layout
  logic outside the protocol layer.
- Do not copy directly:
  firmware update flows as default behavior, root/X11 deployment assumptions,
  yaw-only desktop slicing as a final compositor model, or README-only UX
  claims as implementation evidence.
- Strong references:
  `jakedowns/xreal-webxr` for browser WebHID workbench structure and
  `edwatt/real_utilities` for native protocol parser boundaries.
- Maturity:
  medium-strong diagnostic method; product UX still needs modern comparison.
- Best fit for `VR-apps-lab`:
  XR glasses diagnostics, display-surface helpers, protocol readers, and
  drift/layout control studies.

## Method 655: Camera inference to avatar/tracker signal normalizer

- What it is:
  a camera-inference sidecar captures model output, normalizes it into a clear
  signal schema, exposes tuning/calibration controls, and emits target-specific
  avatar, tracker, or engine messages.
- Good for:
  VRChat/VRCFT expression bridges, VRM avatar diagnostics, Unity body tracking,
  virtual tracker output, webcam FBT, pose visualization, and calibration tools.
- Why it matters:
  model output is noisy and target runtimes all expect different schemas; the
  reusable value is the normalization/mapping layer, not just the inference
  model.
- Source evidence:
  `hotaru86/MediapipeFaceTracking_VRC`,
  `how-people-lived/mediapipe-vrm-tracking`, `Metastazius/VRBodyTrack`, and
  `MasonSakai/VR-AI-Full-Body-Tracking`.
- Reusable core:
  keep capture/inference, source signal names, target schema names, per-signal
  sensitivity/min/max, confidence gates, calibration transforms, persistence,
  diagnostics, and transport output as separable parts.
- Do not copy directly:
  hardcoded camera IDs, hardcoded local Python paths, checked-in Unity
  `Library` artifacts, legacy OpenVR Input Emulator output, or single-file
  mapping logic if the target needs multiple runtimes.
- Strong references:
  `MediapipeFaceTracking_VRC` for VRCFT expression mapping and
  `VR-AI-Full-Body-Tracking` for multi-camera triangulation concepts.
- Maturity:
  strong sidecar method; individual donors vary in hygiene and runtime age.
- Best fit for `VR-apps-lab`:
  avatar/tracker bridge schemas, mapping tools, tracking diagnostics, and
  calibration sidecars.

## Method 656: WebXR/VR teleoperation control surface with safety gates and feedback loop

- What it is:
  a VR or WebXR frontend collects headset/controller/hand input and shows live
  feedback, while a sidecar validates commands, applies IK or other control
  logic, enforces safety gates, and sends output to a robot, runtime, device, or
  remote service.
- Good for:
  robot teleoperation, remote camera heads, overlay automation panels, remote
  desktop/device controls, diagnostics actions, runtime helpers, and any VR
  utility where commands can affect an external system.
- Why it matters:
  control surfaces are only trustworthy when users can see mode, command,
  transport, feedback, and safety state at the same time.
- Source evidence:
  `h2r/GHOST`, `nakama-lab/VR_Teleop_Interface`,
  `kscalelabs/kbot_vr_teleop`, and `open-thought/cambot`.
- Reusable core:
  model explicit operator modes, collect tracked input into typed payloads,
  throttle and pause command streams, validate in a sidecar, expose convergence
  or stale-data state, publish bidirectional telemetry, show transport/media
  health in a HUD, and enforce pause/home/calibration/watchdog/jump-limit
  behavior before output.
- Do not copy directly:
  robot-specific kinematics, hardware safety thresholds, actuator command
  schemas, or ROS/UDP/WebRTC choices without a target-specific risk review.
- Strong references:
  `open-thought/cambot` for safety/HUD/transport design and
  `kscalelabs/kbot_vr_teleop` for WebXR frontend plus Python sidecar
  boundaries.
- Maturity:
  strong architecture method; requires target-specific safety adaptation.
- Best fit for `VR-apps-lab`:
  VR control surfaces, remote-device helpers, operator HUDs, safety-gated
  command sidecars, and command/status/error documentation templates.

## Method 657: Browser XR shared-room presence, pose, and media adapter

- What it is:
  a browser or A-Frame XR room keeps membership and pose state explicit, creates
  remote entities from presence events, and binds optional WebRTC/media streams
  to spatial audio, video surfaces, or avatar feedback.
- Good for:
  shared WebXR rooms, remote assistance utilities, multiplayer diagnostics,
  shared creator tools, browser-native control rooms, and lightweight social
  prototypes.
- Why it matters:
  many useful VR utilities need "another person/device is here" before they
  need a full social platform. The reusable value is the room/presence/media
  adapter boundary.
- Source evidence:
  `jure/wooglies`, `danbuckland/aframe-socket-io`,
  `Srushtika/realtime-multiplayer-webvr-aframe`, and
  `RangerMauve/aframe-dat-peers-networking`.
- Reusable core:
  define room id and user id, emit join/leave, publish head and hand/controller
  pose fields, interpolate or send only changed pose, create/remove remote
  entities, relay or negotiate media streams, attach streams to spatial audio
  or video surfaces, and clean up stale peers.
- Do not copy directly:
  obsolete Deepstream hubs, Beaker/datPeers APIs, old A-Frame/WebRTC versions,
  Twilio-specific ICE setup, full-mesh media assumptions, or prototype trust
  models.
- Strong references:
  `jure/wooglies` for P2P positional audio plus interpolated pose and
  `danbuckland/aframe-socket-io` for separated game/media/signaling systems.
- Maturity:
  medium method; strong architecture donor, old implementation details need
  modernization.
- Best fit for `VR-apps-lab`:
  browser-native shared utility rooms, remote-presence overlays, peer-assisted
  diagnostics, and multi-user creator surfaces.

## Method 658: Spatial UI package boundary with interaction, data, visual, and accessibility layers

- What it is:
  spatial UI is built as cooperating layers: input/interactable state,
  data-binding/list consumers, placement solvers, shader/material feedback,
  accessibility providers, and optional extension services.
- Good for:
  VR settings panels, menus, slates, dashboards, calibration surfaces,
  accessible controls, gaze/dwell input, robotics or device panels, and
  engine-neutral UI architecture studies.
- Why it matters:
  VR utility panels become fragile when button logic, visuals, placement, data,
  and accessibility are all encoded in one component.
- Source evidence:
  `MixedRealityToolkit/MixedRealityToolkit-Unity`,
  `microsoft/MixedReality-GraphicsTools-Unity`, `ms-iot/ros_msft_mrtk`, and
  `The-COGAIN-Association/EyeMRTK`.
- Reusable core:
  model select/toggle/dwell/press state separately from visuals, bind panel
  lists through data sources and pooled item consumers, place panels through
  solver targets and offsets, expose visual feedback through material/shader
  services, keep accessibility in a provider subsystem, and normalize alternate
  input such as gaze before dispatching UI events.
- Do not copy directly:
  Unity/MRTK package names, old HoloLens/SteamVR SDK assumptions, generated
  shader animator code without platform review, or experimental data-binding
  APIs without version pinning.
- Strong references:
  MRTK3 for interaction/data/solver/accessibility boundaries and Graphics Tools
  for visual-material feedback separation.
- Maturity:
  strong method; implementation must be adapted per engine.
- Best fit for `VR-apps-lab`:
  future spatial UI prototypes, accessible menus, engine-neutral interaction
  contracts, and calibration/service panels.

## Method 659: VRChat/Udon world menu package surface with prefab-state contracts

- What it is:
  a world utility menu exposes actions through a prefab or package surface with
  explicit activation, placement, tabs/pages, player selection, permission
  checks, module dispatch, feedback, and optional diagnostics.
- Good for:
  VRChat world tools, creator utility prefabs, admin/GM panels, local settings
  menus, player utilities, runtime consoles, and engine-neutral command-menu
  references.
- Why it matters:
  VR command surfaces need safe lifecycle and state contracts. Otherwise strong
  actions such as teleport, summon, voice changes, or diagnostics become hidden
  and brittle.
- Source evidence:
  `Varneon/UdonEssentials`, `Varneon/VUdon`, `SylanTroh/GMMenu`, and
  `kurotori4423/KurotoriUdonMenu`.
- Reusable core:
  define desktop and VR activation gestures, place and scale the menu relative
  to player/head/hand state, generate pages or tabs from configured menu items,
  route actions through module references, gate actions through permissions or
  roles, expose selected-player state, provide HUD/log feedback, and keep
  package or prefab install boundaries clear.
- Do not copy directly:
  roleplay-specific teleport/summon semantics, deprecated UdonEssentials APIs,
  world-admin permissions without consent/safety review, or VRChat-only voice
  controls as generic behavior.
- Strong references:
  `SylanTroh/GMMenu` for permissioned operator actions and
  `kurotori4423/KurotoriUdonMenu` for small local tabbed menu lifecycle.
- Maturity:
  strong product-pattern method; implementation is platform-specific.
- Best fit for `VR-apps-lab`:
  command menus, admin/control surfaces, local utility panels, and package
  decomposition decisions.

## Method 660: Immersive media/audio substrate boundary for VR surfaces

- What it is:
  media and audio functionality is split into substrate layers: decode or DSP
  backend, texture/render-surface output, engine audio bridge, spatial renderer,
  listener/source wrapper, shader-readable analysis bus, and user controls.
- Good for:
  VR video players, 360/HDR/media surfaces, spatial audio tools, audio-reactive
  worlds, shader visualizers, diagnostics, and media-backed overlays.
- Why it matters:
  VR media tools fail when playback, projection, audio routing, shader data,
  UI controls, and platform risk are undocumented inside one component.
- Source evidence:
  `videolan/vlc-unity`, `videolan/libspatialaudio`, `VoidXH/Cavern`, and
  `llealloo/audiolink`.
- Reusable core:
  own backend lifecycle separately, publish textures or render targets through
  display helpers, route audio through engine callbacks when needed, expose
  object/HOA/binaural renderer configuration and head orientation, wrap spatial
  audio in listener/source components, publish audio analysis once through a
  global texture or bus, and document platform/license/performance constraints.
- Do not copy directly:
  native plugin packaging, codec or DSP license assumptions, fixed shader
  texture layouts, channel layouts, buffer sizes, or async readback behavior
  without target-specific testing.
- Strong references:
  `videolan/vlc-unity` for media backend to Unity surface/audio bridge,
  `libspatialaudio` for renderer API shape, `Cavern` for listener/source
  wrappers, and `AudioLink` for global audio-reactive shader bus design.
- Maturity:
  strong substrate method; product implementation needs platform and license
  review.
- Best fit for `VR-apps-lab`:
  immersive media players, audio-reactive tools, spatial audio diagnostics,
  overlay media surfaces, and media/audio substrate comparison matrices.

## Method 661: OpenXR conformance and diagnostics harness boundary

- What it is:
  OpenXR diagnostics are split into runtime inventory, registry/spec
  explanation, API-layer validation, API dump/tracing, CTS-style test
  invocation, graphics binding selection, and report/runner UI.
- Good for:
  OpenXR doctor tools, runtime bring-up, layer diagnostics, extension matrices,
  developer reports, conformance-runner wrappers, and validation output
  explainers.
- Why it matters:
  users need to know what their OpenXR runtime exposes and what failed without
  confusing ordinary diagnostics with official conformance certification.
- Source evidence:
  `KhronosGroup/OpenXR-CTS`, `rpavlik/openxr-cts-runner`,
  `KhronosGroup/OpenXR-Docs`, and `KhronosGroup/OpenXR-SDK-Source`.
- Reusable core:
  collect runtime/layer/extension inventory, map capabilities to registry/spec
  names, select graphics binding, wrap CLI or layer tools through explicit
  launch settings, capture stdout/stderr or structured output, present skipped
  and noninteractive checks, and emit a report with caveats.
- Do not copy directly:
  conformance claims, official CTS test scope, generated layer internals,
  spec text, or hardware/runtime assumptions without process and license
  review.
- Strong references:
  `OpenXR-CTS` for harness/report/test boundaries,
  `OpenXR-SDK-Source` for API dump/core validation/list-json inventory, and
  `openxr-cts-runner` for a thin GUI wrapper around an authoritative CLI.
- Maturity:
  strong diagnostic method; product work must separate everyday checks from
  official conformance.
- Best fit for `VR-apps-lab`:
  OpenXR doctor/report prototypes, runtime capability matrices, validation
  layer explainers, and graphics-binding diagnostics.

## Method 662: Spatial desktop client stack with protocol, UI, panel, and placement layers

- What it is:
  XR desktop clients are modeled as cooperating layers: wire protocol,
  scenegraph/spatial objects, input fields, interaction primitives,
  declarative UI, panel/window protocol, surface ingestion service, and
  spatial launch placement.
- Good for:
  spatial desktop helpers, desktop-in-VR systems, protocol-backed overlay
  windows, Linux XR workspace tools, placement-aware launchers, and
  scenegraph-first utility architecture.
- Why it matters:
  overlay/window tools become brittle when surface capture, input, placement,
  UI, launch, and transport are all owned by one process.
- Source evidence:
  `StardustXR/core`, `StardustXR/molecules`, `StardustXR/asteroids`,
  `StardustXR/panel-item`, `StardustXR/wayland-service`, and
  `StardustXR/gravity`.
- Reusable core:
  define a protocol schema, expose typed client wrappers, represent every
  object spatially, package high-level interactions, render UI from diffable
  state, model panel state as toplevel/child/cursor/surface events, ingest OS
  surfaces through a service, and pass launch placement through a startup
  token or environment contract.
- Do not copy directly:
  Linux-only transport assumptions, unstable StardustXR APIs, Wayland/binder
  service internals, or generated protocol code as a cross-platform default.
- Strong references:
  `StardustXR/core` for protocol/client substrate, `molecules` for interaction
  primitives, `asteroids` for declarative UI, `panel-item`/`wayland-service`
  for window/surface protocol, and `gravity` for placement launch.
- Maturity:
  strong architecture method; portability requires adapter layers.
- Best fit for `VR-apps-lab`:
  desktop-in-VR design studies, overlay/window protocol boundaries, spatial
  launcher references, and scenegraph-oriented utility prototypes.

## Method 663: Udon runtime utility substrate with profiling, data structures, and predictive sync

- What it is:
  VRChat/Udon utility packages share a substrate for lifecycle validation,
  logging, dirty serialization, sync pause, network time, snapshots,
  diagnostics UI, encoded data structures, prediction, and tuning surfaces.
- Good for:
  VRChat world utility packages, admin tools, data-heavy world systems,
  diagnostics overlays, networked physics, leaderboards, synchronized
  interactables, and Udon framework baselines.
- Why it matters:
  Udon constraints make copy-pasted prefab logic expensive; reusable runtime
  foundations reduce setup errors, timing bugs, serialization mistakes, and
  debugging friction.
- Source evidence:
  `Guribo/UdonUtils`, `Guribo/UdonProfiling`, `Guribo/UdonAVLTree`,
  `Guribo/UdonVehicleSync`, and `Guribo/UdonLeaderBoard` as a product-only
  caveat.
- Reusable core:
  base behavior with setup validation, logging severity, compile-symbol debug
  mode, pending serialization/retry, local sync pause, network/game time
  sources, snapshot and prediction hooks, model/controller diagnostics,
  DataList-encoded structures, dynamic send-rate thresholds, and owner-gated
  tuning UI.
- Do not copy directly:
  package-specific defines, prefab references, VRChat world thresholds,
  predictive physics constants, or placeholder/package-only repos as code
  donors.
- Strong references:
  `UdonUtils` for base runtime substrate, `UdonProfiling` for in-world
  diagnostics, `UdonAVLTree` for DataList structure encoding, and
  `UdonVehicleSync` for prediction-aware sync.
- Maturity:
  strong Udon-specific method; needs world-specific validation before product
  use.
- Best fit for `VR-apps-lab`:
  Udon method documentation, diagnostics surface patterns, constrained runtime
  data structures, and VRChat sync/prediction research.

## Method 664: VRChat external content ingress pipeline for image/model/texture/avatar-data surfaces

- What it is:
  external content enters a VRChat world through an explicit pipeline: source,
  authority/persistence policy, downloader/parser/sync/carrier mechanism,
  cached runtime data, output surface or hierarchy, loading/error/progress UI,
  and platform/runtime caveats.
- Good for:
  image galleries, tablet displays, remote signage, user URL surfaces, runtime
  model viewers, synced whiteboards, data textures, avatar-driven text/data
  carriers, and creator-facing content update tools.
- Why it matters:
  worlds need late-bound content, but Udon restrictions make it easy to hide
  risk in one script unless source, carrier, output, authority, and caveats are
  documented separately.
- Source evidence:
  `vrchat-community/examples-image-loading`, `vr-voyage/vrchat-glb-loader`,
  `DrBlackRat/VRC-Picture-Loader`, `Narazaka/SyncTexture`, and
  `Miner28/AvatarImageReader`.
- Reusable core:
  keep downloader or parser lifetime explicit, cache downloaded data, expose
  callback/progress state, apply output through material/UI/model hierarchy,
  isolate URL input and persistence authority, sync chunked texture data when
  needed, encode/decode data carriers with capacity metadata, and publish
  unsupported feature lists.
- Do not copy directly:
  deprecated avatar-image workflows as first choice, unbounded user URL entry,
  GLB feature parity claims, texture chunk sizes, persistence authority rules,
  or platform capacity assumptions without review.
- Strong references:
  official image-loading sample for minimal downloader/cache flow,
  `VRC-Picture-Loader` for product UX, `vrchat-glb-loader` for staged parser
  and limitation reporting, `SyncTexture` for chunked texture sync, and
  `AvatarImageReader` for historical data-carrier/deprecation context.
- Maturity:
  strong content-ingress method; each carrier has different platform and trust
  limits.
- Best fit for `VR-apps-lab`:
  VRChat external-content matrices, image/model/texture surface studies,
  texture-as-data comparisons, and deprecated workaround documentation.

## Method 665: World-locked coordinate stabilization with marker/cloud-anchor binding

- What it is:
  spatial stability is treated as a layered coordinate system: raw tracking
  frame, stabilized world frame, anchor graph, alignment pins, persistence
  bindings, and explicit reset/search/refreeze UX.
- Good for:
  calibration helpers, CAD/workspace tools, shared-room alignment, MR utility
  apps, anchor diagnostics, multi-session scene persistence, and physical
  reference workflows.
- Why it matters:
  users experience drift, tracking-origin resets, stale anchors, and
  multi-device disagreement; hiding this inside camera offsets makes tools hard
  to debug or recover.
- Source evidence:
  `microsoft/MixedReality-WorldLockingTools-Unity`,
  `microsoft/MixedReality-WorldLockingTools-Samples`,
  `microsoft/WorldLockingTools-Unreal`, and
  `brunoshine/StereoKit.Samples.AzureSpatialAnchors`.
- Reusable core:
  expose a raw/spongy tracking frame, compute or maintain a locked/frozen world
  frame, manage local anchors and edges, add named alignment pins or marker
  bindings, persist or publish bindings, surface search/delete/reset/refreeze
  controls, and report diagnostics/failure state.
- Do not copy directly:
  FrozenWorld internals, Azure Spatial Anchors credential flows, HoloLens-only
  assumptions, Unity/Unreal camera hierarchy names, or cloud availability as a
  default requirement.
- Strong references:
  WLT Unity for vocabulary and anchor/alignment services, WLT Samples for QR
  and ASA product UX, WLT Unreal for cross-engine translation, and the
  StereoKit ASA demo for minimal cloud-anchor UI.
- Maturity:
  strong architecture method; product use needs runtime/engine and persistence
  boundary review.
- Best fit for `VR-apps-lab`:
  spatial-stability matrices, calibration helpers, shared-anchor diagnostics,
  CAD workspace alignment, and anchor UX checklists.

## Method 666: Vendor OpenXR extension wrapper with lifecycle, capability, and build gates

- What it is:
  optional OpenXR features are wrapped as explicit feature units with required
  extension strings, support checks, function pointer loading, lifecycle hooks,
  handle ownership, engine-facing APIs, build metadata, and caveats.
- Good for:
  OpenXR doctors, vendor feature explorers, Unity/Unreal/native extension
  prototypes, passthrough helpers, body/hand tracking wrappers, QR/scene tools,
  virtual keyboard surfaces, and capability matrices.
- Why it matters:
  extension-dependent tools become fragile when runtime support, session
  handles, function loading, Android manifests, preview status, or vendor
  licenses are hidden in feature code.
- Source evidence:
  `microsoft/OpenXR-MixedReality`, `microsoft/Microsoft-OpenXR-Unreal`,
  `meta-quest/Meta-OpenXR-SDK`, and `mikeskydev/unity-openxr-extensions`.
- Reusable core:
  declare required extensions, query runtime support, enable extensions during
  instance creation, load function pointers, create/destroy feature handles on
  session lifecycle, update per frame when needed, expose feature wrappers to
  engine/product code, and publish build/package gates plus caveats.
- Do not copy directly:
  vendor SDK license assumptions, preview/experimental feature claims,
  platform flags, engine plugin internals, or sample-specific object ownership
  without target-specific review.
- Strong references:
  Microsoft OpenXR samples for feature mapping, Microsoft Unreal plugin for
  modular feature registry, Meta SDK for broad native sample/helper coverage,
  and `unity-openxr-extensions` for a small Unity `OpenXRFeature` wrapper
  pattern.
- Maturity:
  strong extension-wrapper method; implementation must stay runtime-gated.
- Best fit for `VR-apps-lab`:
  OpenXR feature wrapper skeletons, capability matrices, manifest/build checks,
  extension diagnostics, and vendor-feature comparison docs.

## Method 667: Purpose-bounded VR input/calibration/display microhelper

- What it is:
  a narrow helper translates one XR source into one useful target through a
  small adapter, state machine, safety gate, config profile, and target sink.
- Good for:
  simulator cockpit hand clicking, tracking-origin calibration, mixed-device
  observer alignment, camera-to-overlay passthrough, controller/hand
  translation, and small operator utilities.
- Why it matters:
  many valuable VR tools are not platforms; they are precise bridges that need
  to be safe, diagnosable, configurable, and honest about their target runtime
  or application.
- Source evidence:
  `fredemmott/HTCC`, `galister/motoc`, `dag10/HoloViveObserver`, and
  `yshui/index_camera_passthrough`.
- Reusable core:
  isolate source signal acquisition, translate into target-specific actions or
  display/calibration output, keep state transitions explicit, store per-app or
  per-profile config, expose monitor/feedback modes, reject invalid data or
  unsafe motion, and document target-app/hardware/runtime caveats.
- Do not copy directly:
  simulator-specific bindings, Monado-only APIs, old Unity cloud networking,
  Linux/Index camera assumptions, or experimental projection defaults.
- Strong references:
  HTCC for API-layer hand-to-action translation, motoc for calibration
  strategies and saved transforms, HoloViveObserver for two-party alignment
  ritual, and Index camera passthrough for capture-to-overlay pipeline.
- Maturity:
  strong microhelper method; each use case remains narrow by design.
- Best fit for `VR-apps-lab`:
  micro-utility design guidelines, tracking/calibration helpers, display
  surface experiments, and safety matrices for input translators.

## Method 668: Creator workbench interaction shell with CAD/model/UI edit affordances

- What it is:
  in-headset creation is structured as a shell of runtime/session integration,
  controller picking, menu/panel widgets, command modes, domain-object adapters,
  selection, snapping, file/text/color input, and feedback surfaces.
- Good for:
  CAD viewers, in-VR modeling tools, creator utility panels, file/keyboard
  dialogs, color/material tools, mesh authoring, workspace editors, and
  calibration/avatar feedback views.
- Why it matters:
  creator tools fail when input, menu state, document commands, selection,
  snapping, and feedback are mixed into one script or treated like ordinary
  gameplay interactions.
- Source evidence:
  `kwahoo2/freecad-xr-workbench`, `createthis/createthis_vr_ui`,
  `createthis/mesh_maker_vr`, and `createthis/unity_vr_ik_mecanim`.
- Reusable core:
  wrap the XR runtime separately, represent controllers as ray/pick objects,
  expose menus and panels as composable widgets, keep command modes explicit,
  adapt host-app or model operations behind domain functions, track selection
  state, support snapping/working planes, provide input widgets, and render
  visual or embodied feedback.
- Do not copy directly:
  Unity 5.x dependencies, SteamVR/VRTK assumptions, asset-store packages,
  FreeCAD-specific APIs, old Mecanim IK limitations, or legacy project
  structure as a modern baseline.
- Strong references:
  FreeCAD XR for modern addon-over-fork CAD workflow, Createthis VR UI for
  panel/file/keyboard/menu widgets, Mesh Maker VR for edit modes and
  geometry-controller interactions, and Unity VR IK Mecanim for mirror/avatar
  feedback.
- Maturity:
  strong product/interaction method; implementation should be rebuilt on a
  modern target stack.
- Best fit for `VR-apps-lab`:
  VR menu matrices, CAD helper patterns, in-headset authoring prototypes,
  creator UI playbooks, and legacy-to-modern toolkit comparisons.

## Method 669: XR research data lifecycle with capture, validation, and export stages

- What it is:
  an XR research or diagnostics tool treats data as a lifecycle: session
  metadata, task/trial state, event markers, continuous streams, custom rows,
  validation checks, quality flags, raw/derivative output, and reports.
- Good for:
  experiment templates, calibration logs, tracker-quality reports, training
  analytics, accessibility studies, telemetry capture, and post-session
  diagnostics tools.
- Why it matters:
  XR data becomes hard to reuse when continuous tracking, events, clocks,
  participant/session metadata, validation, and analysis output are hidden in
  one scene or one ad hoc CSV.
- Source evidence:
  `ResXR/resxr-unity-research-template`, `ResXR/resxr-python-pipeline`,
  `ixperience-lab/VRSTK`, and `eisclimber/ExPresS-XR`.
- Reusable core:
  define a session/task/trial model, emit explicit event rows, keep continuous
  streams separate, allow custom data tables, store metadata and clock policy,
  split streams offline, run validation checks through a registry, preserve raw
  output, create derivative/masked output, and generate reports.
- Do not copy directly:
  Quest/OVR tracking assumptions, BIDS as a mandatory default, legacy Unity
  toolkit structure, broad asset folders, reflection-style export bindings
  without validation, or research schemas without privacy review.
- Strong references:
  ResXR Unity for clear-box capture and event/custom CSV tables, ResXR Python
  for validation/export/report pipeline, VRSTK for biosignals/replay/study
  flow, and ExPresS-XR for editor-guided data-gathering bindings.
- Maturity:
  strong architecture method; product use needs schema, privacy, and runtime
  scope decisions.
- Best fit for `VR-apps-lab`:
  XR data lifecycle matrices, diagnostics log schema, research template notes,
  calibration report concepts, and future data-aware utility prototypes.

## Method 670: WebRTC surface ingress into XR panels with media/data/control split

- What it is:
  an external screen, camera, stereo feed, or monitor enters XR through explicit
  source capture, signaling, media transport, control transport, trust policy,
  spatial panel rendering, and interaction feedback.
- Good for:
  desktop-in-VR panels, local camera monitors, stereo camera viewers, remote
  support tools, QR-paired monitor utilities, and browser-based overlay
  surfaces.
- Why it matters:
  remote panels become unsafe and hard to maintain when pairing, media,
  control input, file transfer, auth, and spatial manipulation are all hidden
  in one WebRTC demo.
- Source evidence:
  `binzume/webrtc-rdp`, `DiscreteTom/WebCaster`,
  `hideki5123/stereo-webrtc-viewer`, `rclarke87/WebXR-IPCam`, and
  `JYJang476/VRMonitor`.
- Reusable core:
  select a bounded signaling/pairing flow, carry media as WebRTC/WHEP tracks,
  use data channels or WebSockets for auth/control/files/input, describe
  capabilities, turn streams into video textures, expose controller or gaze
  manipulation, show connection state, and document local/demo/security
  boundaries.
- Do not copy directly:
  public demo signaling rooms, hardcoded ngrok or LAN endpoints, bundled
  dependency folders, no-auth prototypes, PHP/browser glue as production
  structure, or camera URLs without configuration.
- Strong references:
  `webrtc-rdp` for service/capability split, WebCaster for compact spatial
  panel manipulation, stereo-webrtc-viewer for per-eye camera routing,
  WebXR-IPCam for WHEP panel minimalism, and VRMonitor for QR/local pairing.
- Maturity:
  strong product method; implementation needs security, reconnect, and
  platform review.
- Best fit for `VR-apps-lab`:
  desktop/camera overlay concepts, WebRTC surface-ingress matrices, local
  pairing UX, remote-control boundaries, and browser-to-XR panel prototypes.

## Method 671: Projection-aware browser media viewer with synchronized source, projection, and control layers

- What it is:
  an immersive browser media tool separates media source, transport, projection
  transform, renderer, player controls, persistence, debug/XR layout, and
  latency or recovery policy.
- Good for:
  360/180 video players, SBS stereo streamers, depth-video viewers, WebXR TV
  shells, local file players, gaze-controlled desktop viewers, and media
  diagnostics tools.
- Why it matters:
  media utilities fail when file/stream transport, projection math, stereo
  routing, controls, placement, settings, and recovery are all mixed into one
  viewer script.
- Source evidence:
  `amariichi/VideoDepthViewer3D`, `mysterion/aframe-vr-player`,
  `mrgeralds/WebXR-TV-Demo`, `orgixmh/GazeDesk`, and
  `ZhiqiaoGong/3D-Streaming-Demo`.
- Reusable core:
  declare the source and transport, choose a projection mode, keep stereo or
  depth routing explicit, expose timeline/subtitles/channel/volume/recenter or
  gaze controls, persist presets/settings, provide debug and immersive layouts,
  tune buffering/reconnect/missing-frame behavior, and document browser or
  model/runtime caveats.
- Do not copy directly:
  heavy ML inference stacks unless needed, hardcoded media/proxy URLs, demo
  signaling servers, vendored old player stacks, or README-only features as
  implementation proof.
- Strong references:
  VideoDepthViewer3D for latency-aware depth media, aframe-vr-player for
  projection presets/settings/stereo layers, WebXR-TV-Demo for TV/menu/reposition
  shell, GazeDesk for gaze/dwell accessibility framing, and 3D-Streaming-Demo
  for SBS split plus debug/XR layouts.
- Maturity:
  strong product/UX method; implementation should be scoped by media type and
  target browser/runtime.
- Best fit for `VR-apps-lab`:
  immersive media matrices, projection-aware player notes, SBS/depth viewer
  concepts, gaze media controls, and browser media surface prototypes.

## Method 672: OpenGloves-compatible adapter boundary for DIY haptic glove variants

- What it is:
  DIY glove integrations are modeled as a chain from sensor hardware and
  firmware encoding through transport and converter sidecar into normalized
  OpenGloves input plus force-feedback output scaling.
- Good for:
  DIY haptic gloves, OpenGloves bridge sidecars, named-pipe test fixtures,
  firmware variants, BLE/HID/serial adapters, and physical-output safety
  research.
- Why it matters:
  glove projects vary wildly by sensors, pins, packet formats, transport, and
  haptic actuators; a stable adapter boundary prevents every hardware variant
  from becoming a separate driver architecture.
- Source evidence:
  `SparkleTech-VR/OpenPulseConverter`,
  `danwillm/opengloves-named-pipe-example`, `DasKatzchen/GloveBridge`,
  `Stargazer6481/Compact-Gloves`, and `xRayz3n/ExoTouch-2.0`.
- Reusable core:
  isolate sensor acquisition, firmware calibration, packet encoding, transport
  adapter, packet decoder, normalized flexion/splay/buttons/trigger schema,
  OpenGloves input sink, force-feedback source, haptic scaling, reconnect
  behavior, and hardware-specific caveats.
- Do not copy directly:
  forked firmware wholesale, hardcoded pipe paths, board pins, BLE UUIDs,
  WIP converter globals, actuator scaling values, no-validation examples, or
  physical-output code without safety review.
- Strong references:
  OpenPulseConverter for full HID-to-pipe plus haptics loop, named-pipe example
  for minimal v2 input contract, GloveBridge for BLE bridge shape, Compact
  Gloves for hardware onboarding docs, and ExoTouch for firmware module
  separation.
- Maturity:
  strong adapter-boundary method; code donors are uneven and hardware-specific.
- Best fit for `VR-apps-lab`:
  OpenGloves protocol matrices, DIY haptics safety notes, hardware onboarding
  references, adapter sidecar design, and firmware-variant comparison docs.

## Method 673: WebXR hand-pose template and gesture-event bridge

- What it is:
  a hand input layer converts native WebXR hands, fallback hand sources, or
  controller-like hand data into named gesture events with explicit confidence,
  threshold, frame-budget, and privacy boundaries.
- Good for:
  hand menus, wrist/palm shortcuts, accessibility gestures, overlay window
  commands, hand/controller fallback pointers, and user-defined gesture
  profiles.
- Why it matters:
  raw hand joints are too low-level for utility applications; reusable tools
  need a stable command event layer that can survive runtime differences,
  browser support gaps, and privacy constraints.
- Source evidence:
  `stewdio/handy.js`, `stewdio/vr-hands`,
  `physicslibrary/Threejs-VR-Hand-Input`,
  `vrmeup/threejs-webxr-hands-example`,
  `martatesar/webxr-hands-gestures-recognition`,
  `beemsoft/webxr-handtracking-playground`, and
  `immersive-web/webxr-hand-input`.
- Reusable core:
  isolate hand-source adapters, capture wrist-local or palm-relative joint
  features, compare against templates or simple thresholds, emit
  started/updated/ended events, expose score or confidence, support controller
  fallback, bound recognition work per frame, and document sampling precision
  plus privacy policy.
- Do not copy directly:
  old WebXR helper APIs, vendored Three.js copies, static thresholds as
  universal truth, console-only gesture persistence, MediaPipe demo coupling,
  or recorded hand data without consent and retention rules.
- Strong references:
  `handy.js` for compact eventized pose matching, `webxr-hands-gestures-recognition`
  for wrist-local learner flow, `vrmeup` for hand/controller pointer
  abstraction, `beemsoft` for fallback hand sources, and the hand-input
  explainer for performance/privacy constraints.
- Maturity:
  strong method; implementation must stay feature-detected and privacy-aware.
- Best fit for `VR-apps-lab`:
  hand menu prototypes, overlay shortcut schemas, accessibility gesture
  configuration, and WebXR hand-input matrices.

## Method 674: Data-to-spatial-encoding workbench pipeline

- What it is:
  an immersive data tool separates source data, semantic schema, transform,
  layout, scene/update transport, interaction, annotation, export, and trust
  policy.
- Good for:
  Python-driven XR dashboards, scientific visualization, robot model viewers,
  teleoperation workbenches, QR-paired immersive artifacts, and collaborative
  data review rooms.
- Why it matters:
  data-first VR tools become hard to reuse when data loading, spatial mapping,
  live updates, collaboration, and export are hidden in one scene script.
- Source evidence:
  `vuer-ai/vuer`, `thomann/plotAR`, `TsatsuAmable/nemosyne`,
  `smrghsh/brahma`, and `jurmy24/mechaverse`.
- Reusable core:
  keep data/session ownership outside the renderer, model semantic fields
  explicitly, transform fields through a mapping layer, choose spatial layouts,
  deliver updates as scene operations or generated artifacts, support
  annotations or callouts when collaborative, route file groups to specialized
  viewers, and document local/remote access trust.
- Do not copy directly:
  hardcoded public WebSocket endpoints, old WebVR pages, open local data
  servers without access policy, desktop-only robotics viewers as completed VR
  surfaces, or broad research-preview code as a stable SDK.
- Strong references:
  `vuer` for Python async scene operations, `plotAR` for QR-paired plot
  artifacts, `nemosyne` for semantic mapping/layout/DSL, `brahma` for
  callout/presence shell, and `mechaverse` for format dispatch.
- Maturity:
  strong architecture method; product use needs data privacy and transport
  scope decisions.
- Best fit for `VR-apps-lab`:
  immersive diagnostics dashboards, robotics viewer notes, teleoperation data
  panels, and data visualization method matrices.

## Method 675: Scriptable XR workbench and display-surface shell

- What it is:
  a productive XR surface separates editor or host-app state, live evaluation
  or export/reload, runtime scene, input adapters, in-headset menu state,
  display effects, and desktop mirror/debug surfaces.
- Good for:
  CAD/model viewers, headset-side code tools, host-app export bridges,
  in-headset configuration panels, audio-reactive visualizers, passthrough
  display shells, and creator utilities.
- Why it matters:
  serious VR tools need work surfaces, not just scenes; text input, model
  state, host app export, menu controls, and special rendering should not be
  tangled into one runtime loop.
- Source evidence:
  `vipenzo/ridley`, `id3vi5er/fusion360_webxr_viewer`,
  `felipereigosa/kairon`, and `phobi82/webxr_butterchurn`.
- Reusable core:
  isolate domain state from rendering, expose live-eval or import/export
  boundaries, support desktop companion input when typing is heavy, keep
  controller commands explicit, build menu state separately from menu drawing,
  support reload/version feedback, and provide a desktop mirror or TestLab
  surface for debugging.
- Do not copy directly:
  self-signed local server defaults as production UX, ADB-heavy setup as
  normal onboarding, broad CAD internals wholesale, intense visualizer defaults
  without comfort review, or project-specific path/build assumptions.
- Strong references:
  `Ridley` for code-preserving manipulation and headset sync concepts,
  `fusion360_webxr_viewer` for host export plus WebXR reload, `Kairon` for
  desktop keyboard companion input, and `webxr_butterchurn` for modular menu,
  runtime, depth, audio, and desktop mirror boundaries.
- Maturity:
  strong product/architecture method; each donor has platform and maturity
  caveats.
- Best fit for `VR-apps-lab`:
  VR workbench playbooks, host-app export bridge concepts, menu texture
  modules, in-headset editor notes, and creative display-surface prototypes.

## Method 676: WebXR prototyping runtime primitive stack

- What it is:
  a runtime layer packages common WebXR boilerplate into explicit lifecycle,
  options, session, input, gesture, depth, UI, sound/video, simulator, and
  cleanup modules, while labeling whether the source is a mature SDK, thin
  wrapper, or rough demo.
- Good for:
  browser-native VR utilities, AR product viewers, hand/depth interaction
  prototypes, spatial UI experiments, AI-assisted XR sketches, and small
  cross-device demos.
- Why it matters:
  WebXR experiments often repeat the same setup and accidentally promote rough
  starter code into platform code. A tiered runtime model lets
  `VR-apps-lab` reuse primitives without over-trusting demos.
- Source evidence:
  `google/xrblocks`, `w3reality/threelet`, `simonedevit/reactylon`,
  `vishnu7560834213/threexr`, `ARDings/EverythingController`, and
  `dmvrg/webxr-ar-demos`.
- Reusable core:
  choose runtime tier, centralize options and feature gates, own session and
  renderer lifecycle, expose script/component hooks, separate input/gesture,
  depth, UI, model, sound, and world modules, provide simulator or desktop
  fallback when possible, make disposal explicit, and keep product-specific
  demos outside the runtime core.
- Do not copy directly:
  one-file depth demos without permission review, rough starter scaffolds as
  frameworks, console-heavy hot paths, hardcoded assets, device-specific demo
  assumptions, or AI/API-key flows without trust boundaries.
- Strong references:
  `XR Blocks` for broad SDK boundaries, `threelet` for thin wrapper shape,
  `Reactylon` for declarative React/Babylon ownership, `EverythingController`
  for depth UI diagnostics, and `webxr-ar-demos` for product-like hand UI.
- Maturity:
  strong comparison method; implementation choice depends heavily on product
  scope and team stack.
- Best fit for `VR-apps-lab`:
  WebXR runtime matrices, simulator-backed prototype notes, interaction
  primitive catalogs, and framework maturity labels.

## Method 677: XR teleoperation command bridge with safety-gated input

- What it is:
  a headset or browser XR frontend emits pose, controller, hand, body, grip,
  mode, and reset state into an adapter layer that validates stale data,
  enforces motion gates, and only then commands an external robot or device.
- Good for:
  robot teleoperation, external-device control, operator HUDs, risky overlay
  actions, data collection, and diagnostics that need explicit safety state.
- Why it matters:
  raw XR pose streams are too risky to wire directly into physical or external
  actions; reusable tools need deadman gates, stale-data policy, transform
  checks, feedback, and validation.
- Source evidence:
  `SpesRobotics/teleop`, `ajhai/teleop-xr`,
  `fracapuano/maniskill-quest-teleop`, `almond-bot/axol-vr`, and
  `vivek-kanjarla/Quest3-Fairino`.
- Reusable core:
  isolate XR input source, normalized payload schema, transport,
  robot/device adapter, safety gates, stale timeout, pose jump protection,
  transform/IK mapping, operator HUD, validation or simulation mode, recording,
  and debug capture.
- Do not copy directly:
  hardware IPs, robot SDK calls, certificates, hardcoded LAN endpoints, ADB
  transport assumptions, no-auth control servers, or physical actuation without
  deadman, stale-data, and validation layers.
- Strong references:
  `Quest3-Fairino` for staged safety and diagnostics, `maniskill-quest-teleop`
  for WebRTC telemetry/backpressure, `teleop-xr` for typed robot payloads,
  `axol-vr` for operator HUD state, and `SpesRobotics/teleop` for compact
  transform-gated callback shape.
- Maturity:
  strong method; implementations remain hardware- and safety-policy-specific.
- Best fit for `VR-apps-lab`:
  teleoperation safety matrices, external-device command schemas, operator HUD
  design, and future high-risk utility control surfaces.

## Method 678: Operational XR surface from command, grid, or data state

- What it is:
  a utility exposes bounded command, terminal, diagnostic, network, log, or
  dashboard state as a spatial panel instead of streaming a full desktop or
  unbounded application window.
- Good for:
  VR terminals, log panels, OpenXR/SteamVR doctor reports, network maps,
  local-first dashboards, notes/bookmarks/photos, and cockpit widgets.
- Why it matters:
  operational surfaces need clarity and safety: users should see the command
  or data model, not inherit the entire risk and bandwidth profile of a remote
  desktop.
- Source evidence:
  `max-gaspers-scott/VR-Terminal`, `coderofsalvation/xrsh`,
  `soren42/visual-traceroute`, `CanaanMuayad/earthshift-vr`, and
  `MKTHINGS/webxr-dashboard-meta-quest`.
- Reusable core:
  isolate data/command source, state snapshot model, renderer/panel, input or
  keymap model, progress/status channel, local persistence/export, and
  privilege/auth scope.
- Do not copy directly:
  shell exposure without auth, root network probing without scope, giant
  bundled shell artifacts, public command servers, or personal dashboard
  content as general product logic.
- Strong references:
  `VR-Terminal` for character-grid snapshots, `visual-traceroute` for
  diagnostic graph/report flow, `earthshift-vr` for panel manipulation, and
  `webxr-dashboard-meta-quest` for local-first dashboard models.
- Maturity:
  strong product pattern; security boundaries must be designed first.
- Best fit for `VR-apps-lab`:
  runtime doctor panels, VR logs/terminal prototypes, local dashboard
  microtools, and operational overlay design.

## Method 679: Constrained smart-glasses HUD runtime and BLE/protocol boundary

- What it is:
  a smart-glasses utility separates vendor/device transport from HUD screen
  routing, render cadence, text/image/audio constraints, gestures, paging,
  keep-alive, and shutdown behavior.
- Good for:
  optical smart-glasses HUDs, BLE text dashboards, head-mouse utilities,
  virtual display helpers, low-bandwidth notification panes, and G2/G1 style
  app templates.
- Why it matters:
  smart-glasses displays are small, slow, and device-specific; render queues,
  lens sync, BLE ack behavior, and text/image constraints become first-class
  architecture, not implementation details.
- Source evidence:
  `boomskats/woahland`, `Wojtekb30/EasyVXR`, `darkclad/uxspace`,
  `emingenc/even_glasses`, `fabioglimb/even-toolkit`,
  `even-realities/evenhub-templates`, and `Commute773/g2-kit-unofficial`.
- Reusable core:
  isolate device adapter, session/prelude, envelope/ack/backpressure, display
  constants, screen router, render coalescer, pager, gesture debounce,
  keep-alive, exit/shutdown path, and protocol/device caveats.
- Do not copy directly:
  proprietary SDK binaries, reverse-engineered constants without review,
  hardcoded BLE UUIDs as universal truth, concurrent render writes, animated
  scrolling that can desync lenses, or platform-specific driver assumptions.
- Strong references:
  `g2-kit-unofficial` for BLE/protocol separation and render coalescing,
  `even-toolkit` for per-screen app routing, `evenhub-templates` for official
  template constraints, `UxSpace` for spatial desktop layering, and `woahland`
  for IMU-to-input runtime control.
- Maturity:
  strong method; direct reuse depends on device, license, and support status.
- Best fit for `VR-apps-lab`:
  XR-glasses protocol matrices, constrained HUD design rules, virtual display
  comparisons, and low-bandwidth notification surfaces.

## Method 680: Browser-native WebXR creative stroke workbench

- What it is:
  a WebXR creative or annotation tool separates controller input, tool state,
  active stroke data, geometry building, palette/menu selection, erasing,
  persistence, and collaboration transport.
- Good for:
  VR whiteboards, annotation overlays, sketch tools, calibration markups,
  ruler/measurement panels, 3D drawing utilities, and browser-native creator
  workbenches.
- Why it matters:
  creative tools reveal reusable VR interaction mechanics: pressure, sampling,
  smoothing, mode gating, palette blocking, undo, save/load, and geometry
  limits are broadly useful beyond art apps.
- Source evidence:
  `localtoast42/webxr-whiteboard`, `felixtrz/canvrs`,
  `n1ckfg/LightningLoops`, `nuonical/webxr-babylon`,
  `sierrajanson/Harold-in-VR`, and `cpufreestyle/vr-paint`.
- Reusable core:
  isolate controller adapter, pressure/trigger mapping, tool/mode state,
  active stroke buffer, geometry strategy, eraser/selection, palette/menu
  blocking, persistence/export adapter, and optional collaboration transport.
- Do not copy directly:
  classroom/demo globals, old WebVR bundles, large binary assets or dist
  builds, public socket servers, forked brush code without upstream review, or
  unbounded point buffers.
- Strong references:
  `vr-paint` for mature brush/storage shape, `webxr-babylon` for chunking and
  palette blocking, `canvrs` for compact multitool design, `LightningLoops` for
  collaborative/generative strokes, and `Harold-in-VR` for menu/mode/ruler
  UX.
- Maturity:
  strong interaction method; donors vary from micro-probes to mature forks.
- Best fit for `VR-apps-lab`:
  annotation/whiteboard prototypes, browser-native tool menu patterns, stroke
  storage matrices, and future diagnostic markup surfaces.

## Method 681: Comfort-aware locomotion and embodiment microcontrol stack

- What it is:
  a small VR movement/embodiment layer separates input mapping, movement mode,
  teleport preview, comfort response, body/collider adaptation, and avatar arm
  estimation.
- Good for:
  utility scenes, in-headset menus, calibration workspaces, accessibility
  helpers, prototype viewers, and small tools that need movement without a full
  game locomotion stack.
- Why it matters:
  locomotion code becomes hard to reuse when comfort, controller bindings,
  body height, teleport arc, and avatar estimation are tangled into one scene
  controller.
- Source evidence:
  `RoWoCha/LocomotionVR`,
  `pascalmariany/Unity-WebXR-Teleportation-and-SmoothLocomotion`,
  `dabeschte/VRArmIK`, and the source-light
  `ralph-immrsv/UnityVR-ArmSwingMovement` exclusion.
- Reusable core:
  isolate input adapter, movement vector calculation, teleport preview/commit,
  vignette/fade comfort policy, environment comfort gates, HMD/collider
  sizing, calibration persistence, and arm/shoulder solver.
- Do not copy directly:
  demo scene assumptions, old SteamVR/Oculus bindings, fixed comfort values,
  hardcoded scale constants, or IK heuristics as ergonomic truth.
- Strong references:
  `LocomotionVR` for comfort blinders and intensity gates,
  `Unity-WebXR-Teleportation-and-SmoothLocomotion` for delayed teleport
  preview, and `VRArmIK` for head/hand-only embodiment boundaries.
- Maturity:
  useful micro-pattern; product use needs comfort testing and device-specific
  input review.
- Best fit for `VR-apps-lab`:
  movement wrappers for utility prototypes, comfort matrices, teleport UX
  notes, and embodied pointer/wrist tool experiments.

## Method 682: Spatial sensing and point-cloud XR viewer pipeline

- What it is:
  a spatial utility separates permission gates, capture source, sampling,
  reconstruction, render representation, export/import, loading UI, fallback
  mode, and startup diagnostics.
- Good for:
  WebXR depth capture tools, point-cloud viewers, AR measurement utilities,
  lidar-style diagnostics, splat viewers, and large spatial dataset panels.
- Why it matters:
  sensing/viewer code is fragile when browser permissions, depth buffers,
  worker queues, asset loading, and XR startup state are hidden in the same
  render loop.
- Source evidence:
  `Ramith-D-Rodrigo/webxr-point-cloud`, `Dhruvi509/Webxr-room-scanner`,
  `BSoDium/Lidar`, `sterngefeuert/webxr-gaussian-splat`, and
  `MikeWise2718/messelpit_viewer`.
- Reusable core:
  feature/permission gate, raw capture adapter, sample policy, worker or
  reconstruction stage, point/splat/dataset renderer, progress state,
  import/export adapter, desktop fallback, and runtime startup checklist.
- Do not copy directly:
  overclaimed scanner labels, undisposed point buffers, heavy datasets,
  hardcoded drivers, experimental browser feature assumptions, or vendor
  runtime setup as universal onboarding.
- Strong references:
  `webxr-point-cloud` for depth/camera-to-points, `Webxr-room-scanner` for
  hit-test measurement, `Lidar` for visible ray-grid feedback,
  `webxr-gaussian-splat` for progressive viewer ingestion, and
  `messelpit_viewer` for XR startup diagnostics.
- Maturity:
  strong method family; direct implementation depends on browser/runtime
  support and dataset scale.
- Best fit for `VR-apps-lab`:
  point-cloud capture notes, measurement microtools, spatial asset viewers,
  and OpenXR startup diagnostic playbooks.

## Method 683: Scenario training harness with sensor, coach, and evaluation loop

- What it is:
  a training/evaluation VR system separates scenario state, episode reset,
  scoring/reward, observation capture, sensor ingress, live feedback, coach
  logic, logging/export, and security policy.
- Good for:
  training simulators, rehab feedback loops, simulated-user tests, operator
  coaching, research scenarios, and evaluation harnesses for VR utility UX.
- Why it matters:
  training projects become difficult to reuse when reward, sensors, scenario
  objects, AI coaching, credentials, and logs are mixed into one scene or script
  folder.
- Source evidence:
  `fl0fischer/sim2vr`, `kaayran/ShootingRangeVR`,
  `GxRay/Trunk-Rehabilitation-VR-Training-Simulator-`,
  `Nelliel2/VR-training-simulator`,
  `NagashreeSP/VR-Fire-Safety-Training-Simulator`, and
  `superjaviko/RESILIENCE`.
- Reusable core:
  explicit scenario lifecycle, reset hook, reward/scoring hook, observation or
  camera capture, sensor transport, filter pipeline, feedback surface,
  coach/advisor adapter, external data adapter, logger/exporter, and security
  review.
- Do not copy directly:
  hardcoded API keys, service-account paths, local absolute paths, hardware
  IPs, patient/research artifacts, weapon assets, or README-only concepts as
  implementation donors.
- Strong references:
  `sim2vr` for reward/reset/observation harnessing, `Trunk-Rehabilitation` for
  sensor/filter/feedback loops, `ShootingRangeVR` for scenario scoring, and
  `RESILIENCE` for AI coach boundaries plus security anti-patterns.
- Maturity:
  strong architecture method; each donor needs domain, safety, and privacy
  review before product reuse.
- Best fit for `VR-apps-lab`:
  VR utility evaluation harnesses, training-loop matrices, rehab sensor notes,
  AI coach safety guidance, and scenario logging patterns.

## Method 684: Game-retrofit VR interaction shell with patch, UI, and input layers

- What it is:
  a retrofit shell separates plugin/patch entry, runtime readiness, VR systems
  ownership, input remap, world-space UI, wrist/radial/keyboard surfaces,
  haptics, comfort, calibration, focus-state handling, and debug tooling.
- Good for:
  game VR mods, legacy app VR conversions, overlay-like in-game utilities,
  controller-to-action bridges, wrist dashboards, radial menus, and virtual
  keyboard experiments.
- Why it matters:
  retrofit projects reveal strong interaction patterns, but they become risky
  when game hooks, UI conversion, input mappings, multiplayer behavior, and
  comfort/haptics are not separated.
- Source evidence:
  `Okabintaro/SubmersedVR`, `dortamur/satisfactory-uevr-enhancements`,
  `DSprtn/GTFO_VR_Plugin`, and `KyleTheScientist/Bark`.
- Reusable core:
  plugin entry, runtime gate, VR systems singleton, game-action adapter,
  controller and pointer rig, world-space UI conversion, radial/wrist/menu
  widgets, text input layer, haptics adapter, comfort policy, calibration
  logger, focus router, and debug panel.
- Do not copy directly:
  game assets, binary Blueprint logic, hardcoded game internals, controller
  bindings as universal defaults, cheat-like modules, unsupported multiplayer
  assumptions, or injection strategy as normal app architecture.
- Strong references:
  `SubmersedVR` for UI lasers, wrist HUD, keyboard, and quick slots;
  `GTFO_VR_Plugin` for IL2CPP systems, world-space UI, watch, keyboard, and
  haptics; `satisfactory-uevr-enhancements` for UEVR companion UX; and `Bark`
  for gesture-summoned physical menus and module gating.
- Maturity:
  strong interaction-shell method; reuse requires licensing, ToS, multiplayer,
  and safety review.
- Best fit for `VR-apps-lab`:
  overlay/control-surface design, radial and wrist menu matrices, virtual
  keyboard patterns, retrofit safety notes, and patch-layer architecture
  comparisons.

## Method 685: VR WebView surface with focus-gated keyboard routing

- What it is:
  a Quest/Unity WebView tool treats web content as a native XR panel with a
  clear prefab adapter, URL/search control flow, load/error callbacks,
  focus-gated text input, and platform-specific rendering/permission gates.
- Good for:
  in-headset browser panels, documentation/reference surfaces, login or search
  panels, web dashboards, help panes, and VR tools that need HTML content
  without capturing a desktop window.
- Why it matters:
  WebView surfaces are deceptively easy to describe and easy to make brittle if
  keyboard focus, Android permissions, graphics backend, editor fallback, and
  XR-stack-specific prefabs are not separated.
- Source evidence:
  `TLabAltoh/TLabWebViewVR`,
  `TLabAltoh/TLabWebViewVR-XRInteractionToolkit-2022`, and
  `TLabAltoh/TLabWebViewVR-OculusIntegration-2022`.
- Reusable core:
  WebView prefab boundary, XR interaction adapter, URL/search field, page-load
  callbacks, dialog/error callbacks, focused input field, keyboard visibility
  trigger, key-event forwarding bridge, Android Internet permission, render
  mode selection, and graphics-backend compatibility notes.
- Do not copy directly:
  Unity-version-specific package manifests, Android-only assumptions,
  HardwareBuffer/ByteBuffer mode as a universal default, JavaScript focus hooks
  without security review, or editor behavior as evidence of headset behavior.
- Strong references:
  `TLabWebViewVR` for the package family and keyboard bridge,
  `TLabWebViewVR-XRInteractionToolkit-2022` for the XRI sample boundary, and
  `TLabWebViewVR-OculusIntegration-2022` for the Meta XR variant.
- Maturity:
  useful implementation method; platform constraints need explicit validation
  before product reuse.
- Best fit for `VR-apps-lab`:
  WebView/browser panel checklists, VR text-entry matrices, Quest-native
  documentation panes, and native-web-surface versus captured-window
  comparisons.

## Method 686: Unity XR UI adapter and physical-control microcomponent boundary

- What it is:
  a Unity XR control surface can be decomposed into small adapters: ray-to-panel
  mapping, visible grab affordance, hand state, physical button, keypad,
  reveal/door event, and feedback-state components.
- Good for:
  VR utility menus, in-world settings panels, puzzle/control surfaces,
  training controls, radial/wrist UI experiments, and reusable XRI interaction
  samples.
- Why it matters:
  many Unity XR samples mix scene setup, input, visual feedback, and business
  logic. Reuse gets easier when each control answers one question and exposes a
  small event boundary.
- Source evidence:
  `BernwardWeigand/UnityUIToolkitXRAdapter`,
  `podobaas/XRGrabInteractableRing`,
  `Priyanshu-CODERX/Unity-XR-Interaction-Toolkit-VR-Mechanisms`, and
  `Youkaku-1/VRPuzzelGame`.
- Reusable core:
  collider-backed UI document, local pointer coordinate mapping, synthetic
  input-device state, render texture resize sync, text focus bridge, grab-ring
  distance threshold, hand animation action mapping, hand visibility toggle,
  physical button event, keypad state machine, accepted/denied feedback, and
  unlock/reveal event dispatch.
- Do not copy directly:
  demo scene wiring, one-off puzzle values, asset-heavy scene dependencies,
  source-light package claims as implementation evidence, or hardwired
  controller assumptions.
- Strong references:
  `UnityUIToolkitXRAdapter` for UI Toolkit/XRI bridging,
  `XRGrabInteractableRing` for affordance parameters,
  `Unity-XR-Interaction-Toolkit-VR-Mechanisms` for micro-sample boundaries, and
  `VRPuzzelGame` for physical keypad/door/reveal feedback.
- Maturity:
  strong control-pattern method; best reused as a checklist and local sample
  plan rather than copied wholesale.
- Best fit for `VR-apps-lab`:
  Unity XR control-pattern matrices, physical button/keypad examples, grab
  affordance UX notes, and panel adapter design.

## Method 687: Sensor-tracked training control loop with calibration and logging

- What it is:
  a VR training or rehabilitation tool separates sensor ingress, calibration,
  smoothing/filtering, validity state, scenario condition, safety gates,
  feedback, and structured logging.
- Good for:
  physical-tool tracking, OptiTrack or motion-capture studies, rehab feedback,
  industrial robot training, safety tutorials, and research/evaluation
  harnesses.
- Why it matters:
  sensor-driven VR becomes hard to reason about when raw pose data, participant
  setup, scenario scoring, safety state, and logs are hidden inside scene
  scripts.
- Source evidence:
  `WestCoastGod/XR-CV-Forceps-Tracking-Unity`,
  `jghanania/MotionCapture-AgilityLadder-XR-Study`,
  `jesusfernandorl/Industrial_Twin_XR-Safe-Robotics-and-6-Axis-VR-Control`,
  and `purva-rana/MindscapeVR`.
- Reusable core:
  marker or mocap ingress, coordinate-frame alignment, participant/environment
  condition setup, smoothing filter, reprojection/validity metric, freeze or
  safety gate, physical-state mapping, feedback surface, trial/session manager,
  and CSV/event export.
- Do not copy directly:
  device-specific marker layouts, clinical or industrial safety claims,
  README-only concepts as code donors, participant-data schemas without privacy
  review, or robot-control logic without real interlock validation.
- Strong references:
  `XR-CV-Forceps-Tracking-Unity` for pose smoothing and tool-state mapping,
  `MotionCapture-AgilityLadder-XR-Study` for study orchestration and logging,
  `Industrial_Twin_XR-Safe-Robotics-and-6-Axis-VR-Control` for safety-state
  framing, and `MindscapeVR` for rehabilitation product metaphor.
- Maturity:
  strong architecture method; implementation reuse requires domain, privacy,
  hardware, and safety review.
- Best fit for `VR-apps-lab`:
  sensor-ingress matrices, training loop templates, calibration/logging
  checklists, and industrial/clinical safety caveat docs.

## Method 688: Spatial workbench state loop for measure, model, manipulate, project, and collaborate

- What it is:
  a spatial workbench utility exposes a state loop where users capture spatial
  points or surfaces, edit/model/manipulate them, project the result, share or
  collaborate on it, and preserve history or study logs.
- Good for:
  AR measurement tools, MR planning panels, mesh editing, collaborative object
  manipulation, spatial galleries, guided tours, and design-review utilities.
- Why it matters:
  spatial workbench projects often look unrelated, but their reusable boundary
  is the same: capture state, editable object, manipulation semantics,
  persistence/history, collaboration authority, and feedback/logging.
- Source evidence:
  `rtkCode/Sizer`, `byte-banditt/Meshelanjelo`,
  `B22DigitalTwins2022/ar-resilience-planner-v2`,
  `adityanooka/Unity-Dive-VR`, and `Hempp/street-art-gallery`.
- Reusable core:
  hit-test or pointer capture, measurement/model object, edit toolbar,
  gesture/pinch manipulation, deformation radius and falloff, panel/menu state,
  local history, projection target, collaboration ownership, selection-count
  gate, server-authoritative state changes, social hotspots, and action logs.
- Do not copy directly:
  student-project scaffolding, source-light feature lists as implementation
  evidence, marker-only AR as the only projection model, or collaboration
  ownership rules without conflict/latency review.
- Strong references:
  `Sizer` for measure/model/project history, `Meshelanjelo` for hand-driven
  mesh deformation, `ar-resilience-planner-v2` for planning panels and logs,
  `Unity-Dive-VR` for shared-object authority, and `street-art-gallery` for
  social gallery product framing.
- Maturity:
  useful synthesis method; individual donors vary from code-level strong to
  source-light product references.
- Best fit for `VR-apps-lab`:
  spatial-authoring matrices, MR workbench UX notes, undo/history requirements,
  collaborative ownership patterns, and hand-manipulation caveats.

## Method 689: Overlay micro-surface lifecycle with telemetry, placement, and external-feed boundaries

- What it is:
  a small overlay utility is decomposed into runtime identity, surface creation,
  transform placement, texture or panel update, event/input loop, settings,
  edit mode, optional autostart, and external telemetry/log ingestion.
- Good for:
  SteamVR/OpenVR overlays, dashboard widgets, controller-attached panels,
  physical playspace markers, telemetry instruments, game-log HUDs, and
  situational micro-panels.
- Why it matters:
  micro-overlays are easy to overbuild. They stay reusable when overlay
  plumbing, rendering, placement, settings, and data sources are separate.
- Source evidence:
  `Sch1nken/VRChatOverlay`, `ObnubiladO/vram-overlay`,
  `Spacefish/OpenVR-Overlay`, `lukis101/VRPoleOverlay`, and
  `AArchAngel/Remlok-HUD`.
- Reusable core:
  runtime initialization, overlay app key, create/show/hide lifecycle,
  transform placement, texture source, event polling, hotkey or edit-mode
  controls, chaperone/runtime awareness, local settings, autostart manifest,
  telemetry/log parser, user feedback, and cleanup.
- Source evidence details:
  Wave 244 includes C++ OpenVR/SFML texture upload, WPF telemetry panel
  settings, C# Vulkan texture submission, controller snap/drag landmark
  placement, SteamVR manifest writing, and Elite journal file watching.
- Do not copy directly:
  legacy OpenGL assumptions as a default, example overlay keys, hardcoded game
  paths, old game data endpoints, desktop topmost windows as VR overlays, or
  product-specific mission logic.
- Strong references:
  `VRPoleOverlay` for placement/edit mode, `OpenVR-Overlay` for C#/Vulkan
  submission, `VRChatOverlay` for minimal lifecycle, `vram-overlay` for
  micro-panel UX, and `Remlok-HUD` for log-driven HUDs.
- Maturity:
  strong utility-shell method; individual donors vary from minimal examples to
  niche game-specific surfaces.
- Best fit for `VR-apps-lab`:
  overlay settings schemas, micro-panel prototypes, OpenVR lifecycle
  checklists, log-driven HUD research, and small overlay UX references.

## Method 690: OpenXR API-layer intervention loop for render, frame, and diagnostics changes

- What it is:
  an OpenXR API layer wraps loader negotiation, dispatch, configuration,
  capability gates, narrowly scoped hooks, resource lifetime tracking, output
  or diagnostics, and safe bypass/cleanup behavior.
- Good for:
  OpenXR doctors, runtime inspectors, tracking recorders, foveation helpers,
  render-scaling layers, view/frame/swapchain experiments, and compatibility
  shims.
- Why it matters:
  runtime-adjacent utilities can affect every application. A reusable layer
  pattern must make hook scope, safety gates, bypass, logging, and resource
  ownership explicit.
- Source evidence:
  `danny1marshall1587-maker/MonoEye`, `TripleJ160/Beyond-EVO`,
  `marcsabat/xr-tracking-diagnostics`, and
  `mbucchia/_ARCHIVE_XR_APILAYER_NOVENDOR_nis_scaler`.
- Reusable core:
  layer manifest, loader negotiation, dispatch table, env/INI config,
  enable/bypass switch, logging path, session/graphics binding capture,
  extension/device capability checks, frame/view/swapchain/pose hook,
  resource lifecycle tracking, diagnostic output, user control, and cleanup.
- Source evidence details:
  Wave 245 includes mono-view enumeration intervention, D3D12/VRS/gaze
  capability gates, `xrWaitFrame` pose CSV recording, and archived D3D11
  swapchain scaler resource wrapping.
- Do not copy directly:
  archived scaler implementation as current best practice, game/hardware-only
  assumptions, broad hook surfaces for simple diagnostics, render-changing
  logic without bypass, registry-only settings, or unmanaged resource lifetimes.
- Strong references:
  `xr-tracking-diagnostics` for minimal doctor-style hook scope,
  `Beyond-EVO` for capability gates and live control, `MonoEye` for view-hook
  experimentation, and archived NIS scaler for swapchain resource lessons.
- Maturity:
  high-value architecture method with high compatibility risk; each concrete
  implementation needs runtime/device validation before reuse.
- Best fit for `VR-apps-lab`:
  OpenXR doctor plans, layer safety checklists, render intervention risk
  matrices, foveation/gaze notes, and diagnostic recorder prototypes.

## Method 691: DIY tracker hardware boundary matrix

- What it is:
  a tracker hardware note captures MCU, IMU, radio, PCB, battery, charger,
  enclosure, strap, firmware config, calibration, packet schema, manufacturing
  outputs, license, and maturity as separate reusable boundaries.
- Good for:
  SlimeVR derivatives, DIY body trackers, custom tracker boards, Zephyr/ESP
  firmware references, case ergonomics, battery/charger reviews, and
  hardware-to-driver bridge planning.
- Why it matters:
  tracker projects are rarely reusable as one blob. The reusable knowledge is
  usually in a boundary decision: IMU compatibility, solderability, packet
  schema, case comfort, calibration, or manufacturing documentation.
- Source evidence:
  `zhangwenchao1992/SlimeVR_DeftTracker`, `frosty6742/frozen-slimes-v2`,
  `TheButlah/slimevr_pcb`, `gumorr/GummySlime`,
  `Tropingenie/Caribou-Slime`, `infopcgood/SMORES`,
  `ZRock35/TinyOfficial-Case`, and `1vers1on/vr_trackers`.
- Reusable core:
  hardware family role, MCU/radio, IMU options, auxiliary tracker support,
  charger and battery, PCB outputs, BOM, assembly instructions, case/strap
  ergonomics, firmware defines, packet schema, calibration routine, transport
  status, license, and caveats.
- Source evidence details:
  Wave 246 includes full tracker kits, multi-IMU bridge pads, ESP32-C3
  board-family choices, hand-solderable board design, reciprocal hardware
  license notes, source-light nRF tiny-board direction, case ergonomics, and a
  Zephyr packet/calibration skeleton.
- Do not copy directly:
  board files without electronics review, license-restricted hardware sources,
  fixed IMU orientation, source-light designs as proven donors, or incomplete
  firmware loops as production protocol.
- Strong references:
  `slimevr_pcb` for board family documentation, `frozen-slimes-v2` for maker
  assembly UX, `GummySlime` for firmware macro pairing, `vr_trackers` for
  packet/calibration skeleton, and `TinyOfficial-Case` for mechanical caveats.
- Maturity:
  strong research/template method; not an endorsement of manufacturing any
  hardware without separate review.
- Best fit for `VR-apps-lab`:
  tracker hardware matrices, future hardware-note templates, packet schema
  comparisons, calibration checklists, and hardware-license caveat docs.

## Method 692: Camera/avatar tracking bridge pipeline with calibration, transport, solving, and retargeting boundaries

- What it is:
  a camera/avatar tracking bridge separates capture, calibration, inference,
  smoothing, pose solving, transport, output adapter, and retargeting so the
  same body data can feed OSC trackers, SteamVR devices, Unity bones, VRM
  avatars, or networked avatars.
- Good for:
  webcam body tracking, MediaPipe to OSC, MediaPipe to SteamVR drivers,
  VRM/Vtubing surfaces, Unity avatar retargeting, multi-camera calibration,
  SlimeVR/VRChat bridge planning, and external tracker prototypes.
- Why it matters:
  body tracking quality is hard to reason about when sensor capture, ML model,
  coordinate conversion, smoothing, transport, and avatar output are coupled.
  Reuse starts by naming each boundary and its caveats.
- Source evidence:
  `zekailin00/VR-Full-Body-Tracking-System`,
  `Raraph84/Cameras-Full-Body-Tracking`,
  `DubbsPi/Mediapipe-SteamVR-Full-Body-Tracking-for-Linux`,
  `yeemachine/kalidoface-3d`, and `Neleac/MesekaiUnity`.
- Reusable core:
  camera or IMU capture, calibration UI, landmark or sensor buffer, confidence
  gate, smoothing policy, coordinate-frame conversion, pose solver, transport
  protocol, OSC/driver/avatar output adapter, template-avatar retargeting,
  blendshape mapping, tuning controls, persistence, and user-facing caveats.
- Source evidence details:
  Wave 247 includes ESP8266/Flask/Unity HTTP loops, browser WebRTC MediaPipe
  triangulation to OSC, Python MediaPipe to Linux OpenVR driver through Unix
  socket, browser VRM/Vtubing UX, and Unity pose/hand/face solvers with Photon
  replication.
- Do not copy directly:
  hardcoded WiFi credentials or IPs, fixed camera dimensions, identity
  rotations as complete FBT, bundled/minified browser code as clean donor
  evidence, or student polling loops as final architecture.
- Strong references:
  `Cameras-Full-Body-Tracking` for browser calibration/WebRTC/OSC,
  `Mediapipe-SteamVR-Full-Body-Tracking-for-Linux` for CV-to-driver separation,
  `MesekaiUnity` for template-avatar retargeting, and `kalidoface-3d` for
  webcam-avatar product UX.
- Maturity:
  strong architecture method; individual donors need validation before any
  tracking-quality or headset-compatibility claims.
- Best fit for `VR-apps-lab`:
  body-tracking transport matrices, calibration UX checklists, avatar
  retargeting comparisons, synthetic tracker schemas, and webcam-to-avatar
  product references.

## Method 693: VRChat world metadata overlay pipeline for OBS browser sources

- What it is:
  a stream-facing utility reads current VRChat world state from a local or
  account-backed source, enriches it with world metadata, and exposes it as an
  OBS browser source, text source, or OBS-native scene action.
- Good for:
  VRChat stream overlays, world-credit cards, current-world lower thirds,
  transition scenes, event metadata panels, and lightweight streamer widgets.
- Why it matters:
  these tools stay maintainable when world-state ingress, metadata lookup,
  overlay rendering, and stream-output integration are separate.
- Source evidence:
  `Natsumi-sama/VRC-OBS-Overlay`,
  `philippgitpush/vrc-obs-world-overlay`,
  `ktmage/vrc-world-credit-streaming-overlay`,
  `Mahcks/vrc-world-teller`, `Elocin-Anagram/VRC_World_Location`, and
  `nosjo/obs-vrchat-log-reader`.
- Reusable core:
  state source adapter, current-world dedupe, metadata fetch/cache, stale or
  rate-limit state, browser-source or text-file renderer, OBS script action,
  local port/path config, and privacy notes.
- Source evidence details:
  Wave 248 includes registry polling, VRCX SQLite reads, log tailing with file
  offsets, VRChat API response validation, SSE, plain text files, and
  OBS-native Lua scene switching.
- Do not copy directly:
  credential polling without a security model, auth-cookie extraction without
  user consent, brittle log strings as the only parser, broad execution-policy
  changes, or page scraping as the default metadata path.
- Strong references:
  `vrc-world-credit-streaming-overlay` for typed log-to-SSE design,
  `vrc-obs-world-overlay` for polished config/overlay UX,
  `VRC-OBS-Overlay` for registry micro-overlay shape, and
  `obs-vrchat-log-reader` for OBS-native no-companion automation.
- Maturity:
  strong micro-utility method; source adapters vary in safety and stability.
- Best fit for `VR-apps-lab`:
  streamer overlay templates, VRChat state-source matrices, OBS browser-source
  examples, and privacy/rate-limit caveat docs.

## Method 694: Bidirectional VRChat-to-OBS control bridge with status feedback

- What it is:
  a control bridge maps VRChat avatar parameters, OSC messages, log events, or
  local web-app actions to OBS commands and returns stream, record, replay,
  scene, microphone, or player state to the operator.
- Good for:
  in-VR stream control, action-menu scene switching, replay buffer capture,
  microphone mute sync, loading-screen scene changes, event-night queue
  control, and OBS automation panels.
- Why it matters:
  controlling OBS from VR is risky if commands are fire-and-forget. A reusable
  bridge needs schema, idempotency, status feedback, debounce, and permission
  boundaries.
- Source evidence:
  `nerdywoffy/vrchat-obs-controller`,
  `rogeraabbccdd/VRChat-OBSOSC`, `ioarchive/obscontrol`,
  `TuTu475/VRC-OBS-MicControl`, `dimebag29/VRChatObsMicMuteLink`,
  `0x29a-blink/VRChat-Movie-Night`, and
  `MissingNO123/OBS-Scripts-for-VRChat`.
- Reusable core:
  command source, parameter schema, OBS adapter, action mapper, feedback
  sender, reconnect/backoff, debounce/correction, scene bounds, credentials,
  and visible failure state.
- Source evidence details:
  Wave 249 includes Go OSC sidecar adapters for OBS/Streamlabs, Node OBS v4/v5
  compatibility, OBS-native Python scripts, a historical quick-menu mod,
  hotkey shims, and an authenticated movie-night web stack with queue/player
  state.
- Do not copy directly:
  VRChat mod hooks as current architecture, global hotkeys without conflict
  review, empty OBS passwords, media-download scope creep, command handlers
  without feedback, or broad localhost access without operator consent.
- Strong references:
  `vrchat-obs-controller` for parameter contracts and backend interfaces,
  `VRChat-OBSOSC` for compact OBS v4/v5 bridging,
  `OBS-Scripts-for-VRChat` for OBS-native packaging, and
  `VRChat-Movie-Night` for robust queue/OBS/HLS operator state.
- Maturity:
  strong control-pattern method; security and permission model must be designed
  before implementation reuse.
- Best fit for `VR-apps-lab`:
  OSC-to-OBS bridge templates, OBS script patterns, safe stream-control schema,
  and event-operator backlog items.

## Method 695: VR event production media pipeline across world controls, OBS, and HLS playback

- What it is:
  an event-production utility separates in-world production controls, desktop
  visual/media sources, OBS capture or ingest, transcode/segment services,
  public playback URLs, preview paths, and browser-source outputs.
- Good for:
  VRChat events, virtual production stages, VJing, live world video players,
  remote camera direction, avatar/browser-source outputs, and stream plugin
  dashboards.
- Why it matters:
  live VR events fail at boundaries: camera control, preview, ingest,
  transcoding, network exposure, and viewer playback need to be documented as
  one pipeline but implemented as separable parts.
- Source evidence:
  `designio360/virtualproduction-vrchat`, `valkyriedimension/TD2VRC`,
  `RemilRLs/StreamToVRC`, `dragokenlancer/VRC-Camera-control-webpage`,
  `reece-berens/vrc-stream-plugins`, and `furukawa1020/VRcoverOBS`.
- Reusable core:
  production source, operator controls, media ingest, transcode or segment
  service, playback URL, preview source, browser-source route, stream health,
  latency choice, public port policy, and setup checklist.
- Source evidence details:
  Wave 250 includes VRChat camera/crane/slide production packages,
  TouchDesigner/OBS routing, NGINX RTMP-to-HLS configs, browser camera OSC
  control with sessions, stream plugin output routes, and browser-avatar OBS
  output.
- Do not copy directly:
  source-light Unity packages as code donors, public RTMP/HLS ports as safe
  defaults, beta camera OSC addresses as stable APIs, or broad avatar/AI stacks
  as core production architecture.
- Strong references:
  `StreamToVRC` for minimal RTMP-to-HLS infrastructure,
  `VRC-Camera-control-webpage` for authenticated camera-control separation,
  `virtualproduction-vrchat` for in-world production UX, and `TD2VRC` for VJ
  routing workflow.
- Maturity:
  useful production-pipeline method; individual projects range from source
  code donors to workflow/product references.
- Best fit for `VR-apps-lab`:
  VR event production checklists, HLS transport comparisons, camera-control
  safety notes, and operator-surface backlog items.

## Method 696: OpenVR compatibility driver boundary for legacy sensors and synthetic devices

- What it is:
  an OpenVR compatibility driver makes hardware or synthetic devices visible to
  SteamVR through an explicit boundary between driver registration, hardware
  polling or shim source, pose/input transport, identity, settings,
  calibration, and cleanup.
- Good for:
  legacy hand sensors, Kinect body trackers, DIY headset experiments,
  no-HMD drivers, virtual-HMD helpers, compatibility shims, and custom-device
  learning paths.
- Why it matters:
  driver projects become risky when they hide identity spoofing, sensor IO,
  calibration, and runtime registration inside one opaque DLL. Reuse starts by
  naming each boundary and caveat.
- Source evidence:
  `SDraw/driver_leap`, `SDraw/driver_kinectV1`,
  `SDraw/driver_kinectV2`, `schellingb/PseudoVive`,
  `r57zone/Half-Life-Alyx-novr`,
  `lixiangwuxian/Viulux-V9-Driver-for-SteamVR`, and
  `Blockmann2K/MurlokVR`.
- Reusable core:
  driver manifest, `HmdDriverFactory`, provider, device class, property
  schema, pose/input contract, sensor runtime or shim source, calibration UI,
  companion app, settings, transport, cleanup, and compatibility warnings.
- Source evidence details:
  Wave 251 includes Leap polling to Index-like controllers, Kinect skeletons
  to generic trackers, MinHook property spoofing, no-HMD key/controller maps,
  vendor headset lineage notes, and a Rust runtime to OpenVR shared-memory HMD
  split.
- Do not copy directly:
  model-name spoofing as a recommended pattern, obsolete Kinect/Leap SDK
  setup, global key injection, README-only hardware claims, hardcoded COM
  ports, or game-specific mappings as general-purpose drivers.
- Strong references:
  `driver_leap` for sensor polling plus controller/skeleton mapping,
  `driver_kinectV1` and `driver_kinectV2` for skeleton-to-tracker calibration,
  `PseudoVive` for compatibility-shim caveats, and `MurlokVR` for
  runtime-to-driver shared-memory separation.
- Maturity:
  high-value driver-boundary method with high compatibility risk.
- Best fit for `VR-apps-lab`:
  OpenVR driver matrices, custom-device note templates, identity spoofing risk
  docs, DIY HMD transport comparisons, and headsetless workflow caveats.

## Method 697: Hands-free XR input microtool with head, hand, chord, and wrist-menu boundaries

- What it is:
  a controllerless input utility separates sensor capture, calibration,
  gesture or pose interpretation, output adaptation, feedback, and emergency
  disable behavior.
- Good for:
  cockpit helpers, accessibility input, hand-only text entry, wrist menus,
  pinch-ray tools, raw hand-joint debuggers, and controllerless command
  surfaces.
- Why it matters:
  hands-free input is useful only when the boundary between "what the body is
  doing" and "what command is emitted" is explicit, recalibratable, and easy to
  stop.
- Source evidence:
  `SimForgeEngineering/DCS-HandsFree`, `JonahSagers/VRChord`,
  `Haidere1/VarjoXR-CustomHandTracking-Test`, and
  `zodiepupper/godothandtrackingtests`.
- Reusable core:
  input source, calibration/recenter state, normalized pose or curl vector,
  threshold/chord classifier, debounce or latch, output adapter, visible
  feedback, and safety disable path.
- Source evidence details:
  Wave 252 includes StereoKit HMD pose to Windows cursor mapping, Unity XR
  Hands curl dictionaries and feedback, Unreal OpenXR/Varjo hand-keypoint
  pinch rays, and Godot OpenXR joint trackers with wrist UI.
- Do not copy directly:
  hardcoded yaw/pitch ranges, controllerless input without an escape hatch,
  bundled sample assets as architecture, vendor-specific hand wiring, or rough
  thresholds without fatigue/error review.
- Strong references:
  `VRChord` for chord classifier and feedback shape,
  `godothandtrackingtests` for raw joint-to-wrist-UI experiments,
  `DCS-HandsFree` for minimal head-to-cursor boundaries, and
  `VarjoXR-CustomHandTracking-Test` for engine-level pinch-ray sample code.
- Maturity:
  useful pattern family with strong caveat requirements around calibration and
  safety.
- Best fit for `VR-apps-lab`:
  accessibility microhelpers, cockpit-control prototypes, wrist-menu input
  notes, hand-derived command surfaces, and controllerless UX safety
  checklists.

## Method 698: SteamVR dashboard navigation shim with driver, companion, and runtime-patch boundaries

- What it is:
  a dashboard navigation helper adapts a nonstandard input source into SteamVR
  dashboard control through a driver shim, synthetic controller, companion
  process, URI command, runtime resource patch, or audio/control bridge.
- Good for:
  keyboard dashboard control, Quest system-button forwarding, gamepad-to-VR
  controller shims, dashboard keyboard customization, and reusing existing VR
  sliders as external control surfaces.
- Why it matters:
  SteamVR dashboard helpers often work by touching risky seams. Reuse requires
  naming the adapter boundary, compatibility assumptions, feedback path, and
  cleanup story.
- Source evidence:
  `mbucchia/SteamVR-Dashboard-KeyboardNav`,
  `lmore377/quest-steamvr-system-button`, `AJBats/pad-vr`,
  `MagnaLunas/SteamVRKeyboardLayoutChanger`, and `bpbwaite/ahk-svrvmr`.
- Reusable core:
  input signal source, activation gate, SteamVR adapter, optional shared IPC,
  dashboard visibility or state feedback, compatibility notes, uninstall path,
  and conflict handling with real devices or global hotkeys.
- Source evidence details:
  Wave 253 includes HMD driver wrapping with custom input profiles, ADB logcat
  to debug URI dispatch, XInput to synthetic controller drivers, dashboard web
  resource patching, and AutoHotkey volume-to-Voicemeeter routing.
- Do not copy directly:
  low-level keyboard hooks as safe defaults, logcat strings as stable APIs,
  bundled dashboard JavaScript patching as current architecture, global audio
  side effects, or synthetic controller identity choices without conflict
  review.
- Strong references:
  `SteamVR-Dashboard-KeyboardNav` for driver shim plus companion split,
  `pad-vr` for gamepad-to-controller plumbing,
  `quest-steamvr-system-button` for tiny platform-event adapters, and
  `SteamVRKeyboardLayoutChanger` as a cautionary resource-patch boundary.
- Maturity:
  high-value SteamVR utility method with high runtime compatibility risk.
- Best fit for `VR-apps-lab`:
  dashboard accessibility helpers, synthetic controller comparison notes,
  SteamVR command-path caveats, and system-input bridge prototypes.

## Method 699: VRChat OSC microtool composer with source adapters, cadence, templates, and privacy gates

- What it is:
  a VRChat OSC microtool composes public chatbox or avatar-parameter output
  from one or more external data sources through explicit adapters, templates,
  cadence gates, and privacy rules.
- Good for:
  media status, lyrics, clocks, heart-rate text files, desktop status, avatar
  parameter helpers, small OSC libraries, Android/Quest companion clients, and
  modular chatbox tools.
- Why it matters:
  the difference between a useful chatbox utility and spammy status leakage is
  mostly cadence, consent, templating, blanking, and source trust.
- Source evidence:
  `lillithrosepup/Lilypad`, `ohkaelynn/iron-heart-chatbox`,
  `MeltyMooncakes/VRChat-OSC-Script`,
  `o0F-0oF/VRChat-Spotify-Chatbox`,
  `o0F-0oF/VRChat-Spotify-Chatbox-CS`,
  `Mezque/VRC-SpotifyOSC-Py`, `Mezque/VRC-ClockOSC-Py`,
  `eepyfemboi/ezmusic-desktop-client`, `ActuallyAbby/VRC-JavaOSC`, and
  `Disconnect3301/DisconnectOSC`.
- Reusable core:
  source adapter, template formatter, cadence/dedupe gate, OSC sender/listener,
  optional OSCQuery discovery, plugin/module boundary, credential storage,
  privacy mode, and visible pause/error state.
- Source evidence details:
  Wave 254 includes Kotlin module registries, TypeScript YAML line composers,
  Python/C# Spotify window-title senders, Spotipy OAuth state, clock senders,
  desktop webview clients, Java OSC wrappers, and console module toys.
- Do not copy directly:
  auto-installing dependencies on import, secrets in source, unbounded plugin
  imports, public biometric output without consent, prank/selfbot features,
  tracked `bin`/`obj`/`.vs` artifacts, or fixed ports without configuration.
- Strong references:
  `Lilypad` for modular Android chatbox architecture,
  `VRChat-OSC-Script` for template/cadence shape,
  `VRC-JavaOSC` for typed library boundaries, and
  `iron-heart-chatbox` for file-sensor to tray-controlled chatbox flow.
- Maturity:
  mature as a microtool composition method; individual projects vary widely in
  privacy, packaging, and security quality.
- Best fit for `VR-apps-lab`:
  OSC composer templates, source-adapter matrices, privacy-aware chatbox UX,
  media/biometric status caveats, and Quest/Android companion architecture.

## Method 700: Smart-glasses and WebXR utility surface boundary with sensor, config, display, and authoring adapters

- What it is:
  an XR utility surface separates hardware/config setup, pose or display data,
  shell/browser rendering, IPC or signaling, and authoring/export workflow into
  small adapters instead of one monolithic app.
- Good for:
  smart-glasses desktops, IMU-to-display transforms, Android external-display
  setup, desktop indicators, WebXR remote displays, in-HMD dev consoles,
  Blender-to-WebXR export tools, and scene annotation surfaces.
- Why it matters:
  many useful XR tools live outside headset runtimes. They sit in OS display
  settings, shell extensions, browser dev tools, authoring packages, and
  smart-glasses config flows.
- Source evidence:
  `ProjectBlueSkies/xr-desktop`, `mhalder/xreal-desktop-mode`,
  `marbetschar/wingpanel-indicator-xrdesktop`, `cong-lab/LabOS-Runtime`,
  `sawa-zen/three-fiber-webxr-toolbox`, `laffan/blender-webxr-tools`, and
  `pravinpoudel/building-annotation`.
- Reusable core:
  device/config adapter, pose or display-state channel, shell/browser/UI
  surface, IPC/DBus/WebRTC/file transport, setup checklist, authoring/export
  step, security constraints, and device/version caveats.
- Source evidence details:
  Wave 255 includes Viture IMU daemon to shared memory to GNOME extension
  transforms, Xreal Android desktop-mode ADB scripts, xrdesktop DBus panel
  indicators, lab-runtime glasses connectors, React/Three WebXR remote
  display helpers, Blender export automation, and annotation schemas.
- Do not copy directly:
  hidden Android settings as universal behavior, broad CORS signaling defaults,
  subprocess JSX rewriting without review, VITURE-specific config deployment,
  GNOME/Pantheon assumptions, or large Docker/Tailscale lab stacks as a
  general runtime.
- Strong references:
  `xr-desktop` for sensor-daemon to shell-extension boundaries,
  `xreal-desktop-mode` for setup microtool shape,
  `three-fiber-webxr-toolbox` for WebXR dev utility surfaces, and
  `blender-webxr-tools` for authoring pipeline automation.
- Maturity:
  strong cross-surface method; most donors are device, shell, or workflow
  specific and need adapter layers before reuse.
- Best fit for `VR-apps-lab`:
  smart-glasses desktop setup notes, WebXR utility surface prototypes,
  authoring/export checklists, annotation schemas, and OS/display boundary
  comparison docs.

## Method 701: Identity-preserving motion protocol bridge with pose source, envelope, and monitor surface

- What it is:
  a motion bridge separates pose acquisition, local protocol parsing, network
  transport, client identity, destination routing, and operator monitoring.
- Good for:
  VMC relays, OpenXR-to-VMC experiments, OSC tracker transport, VRM motion
  bridges, avatar mocap sharing, and multi-machine motion debugging.
- Why it matters:
  pose streams become brittle when identity, calibration, and routing are
  hidden in one UDP sender. A bridge should make the source, envelope,
  transform, and destination visible.
- Source evidence:
  `LukasLichten/simple-xr2vmc`, `sotanmochi/VMCTransportBridge`,
  `sotanmochi/VMCTransportHub`, and the source-light `vivi90/python-vmc`
  follow-up node.
- Reusable core:
  pose source, local protocol codec, typed message model, transform/calibration
  layer, client identity, transport envelope, destination router, reconnect
  policy, monitor UI, and trust/auth gates.
- Source evidence details:
  Wave 256 includes a headless OpenXR action-space pose poller, a VMC
  MessagePack transport envelope with network client id, subscriber filters,
  `/Transported` message re-emission, and a WPF/Blazor hub with destination
  and message-monitor controls.
- Do not copy directly:
  incomplete or commented-out sender code, fixed controller bindings, network
  transport without explicit auth, hidden transform assumptions, or
  operator-less relays that cannot show what client/source is active.
- Strong references:
  `VMCTransportBridge` for the protocol-envelope split,
  `VMCTransportHub` for operator and monitor surface shape, and
  `simple-xr2vmc` for a minimal OpenXR pose-source boundary.
- Maturity:
  strong bridge-boundary method; individual donors need security, calibration,
  and robustness review before reuse.
- Best fit for `VR-apps-lab`:
  VMC/VRM/OSC bridge matrices, headless OpenXR pose-source helpers,
  identity-preserving tracker relays, and transport-monitor UI prototypes.

## Method 702: VR notification relay with source adapters, privacy gates, and overlay transport targets

- What it is:
  a notification relay normalizes events from desktop, app, log, audio, status,
  or device sources and sends them to a VR overlay or compatibility target.
- Good for:
  XSOverlay notification bridges, Windows toast relays, VRChat log/status
  alerts, vendor battery monitors, audio-recognition helpers, Linux
  compatibility daemons, and future overlay-agnostic notification cores.
- Why it matters:
  VR notification tools are valuable only when they avoid leaking private data,
  provide filtering/fallback behavior, and keep the event source independent
  from the overlay transport.
- Source evidence:
  `nnaaa-vr/XSOverlay-VRChat-Parser`, `bluskript/xsoverlay-notifier`,
  `nnaaa-vr/XSNotifications`, `Minty-Labs/WindowsXSO`,
  `Duinrahaic/XSSocket`, `Zyphrono/XSOverlay-VRChat-Status`,
  `project-vrcat/XSNotifier-Go`, `gizmogoat/XSNotifyDaemon`,
  `JacobA2000/VRCazam`, and `pikepikeid/PICOBatteryWatcher`.
- Reusable core:
  event source adapter, permission gate, source-app/device metadata, privacy
  filter, dedupe/cadence or threshold policy, normalized notification event,
  payload builder, transport adapter, delivery fallback, and visible pause or
  error state.
- Source evidence details:
  Wave 257 includes Windows toast listener/polling strategies, VRChat log and
  status polling adapters, PICO Connect log parsing, XSOverlay UDP and
  WebSocket client libraries, a Linux WebSocket compatibility daemon, and an
  avatar-OSC-triggered audio-recognition notification loop.
- Do not copy directly:
  unfiltered desktop notification mirroring, unauthenticated WebSocket command
  surfaces, audio capture without consent, stale service component ids,
  manual JSON without schema validation, or checked-in build artifacts.
- Strong references:
  `WindowsXSO` for permission/filter/lifecycle UX,
  `xsoverlay-notifier` for Windows notification extraction,
  `XSSocket` for WebSocket API shape, `XSNotifications` and `XSNotifier-Go`
  for compact UDP clients, and `XSNotifyDaemon` for compatibility shims.
- Maturity:
  mature as a notification relay method; privacy and transport safety are the
  main reuse gates.
- Best fit for `VR-apps-lab`:
  overlay notification cores, privacy-safe event relays, vendor-log telemetry
  helpers, and XSOverlay-compatible payload/API matrices.

## Method 703: VRChat OSC micro-control utility with state mirror, queue, and safety gates

- What it is:
  a VRChat OSC micro-control utility converts one small source signal into
  avatar/input/chatbox OSC output through typed addresses, visible state, and
  bounded send behavior.
- Good for:
  mute toggles, AFK automation, controller axis repair, rapid-use helpers,
  eye-height senders, shell chatbox commands, MIDI-to-parameter tools, heart
  rate bridges, and typed OSC libraries.
- Why it matters:
  most useful VRChat helpers are small. The reusable part is not feature
  breadth; it is making the source, state, cadence, release, and privacy rules
  explicit.
- Source evidence:
  `Sayamame-beans/VRC_AFK_AutoMuter`, `03milo/InputFixer`,
  `Airbee/VRChat-OSC-Scaling`, `koturn/OscRapidUseRight`,
  `Hino-VRChat/vrchat-mute-toggle`, `SourLemonJuice/VRChat-OSC-Shell`,
  `YimuQrrr/OSC_Tool`, `xiaoBingge114514/VRChat-OSC-Chat-Tool`,
  `Ero-Cat/hr_push`, and `kb10uy/phorcys`.
- Reusable core:
  source adapter, typed OSC address contract, sender/listener split, state
  mirror or parameter cache, queue/cooldown/debounce, safe release or blanking,
  process/lifecycle gate, config, visible tray/UI/CLI state, privacy mode, and
  port conflict recovery.
- Source evidence details:
  Wave 258 includes AFK/mute state mirrors, OpenVR axis remapping, one-field
  avatar parameter UI, raw OSC rapid input loops, robust tray hotkey queues,
  shell chatbox wrappers, OSC scanners and address testers, multi-source
  chatbox composers, BLE heart-rate bridges, and Rust typed OSC/avatar config
  libraries.
- Do not copy directly:
  unbounded input spam, public biometric output without consent, unsafe
  process-kill/open commands, hardcoded ports with no recovery, monolithic
  script growth, unvalidated ranges, or raw packet builders without tests.
- Strong references:
  `vrchat-mute-toggle` for robust microtool lifecycle,
  `phorcys` for typed OSC/config foundations, `hr_push` for sensor throttling
  and privacy-sensitive output, and `VRChat-OSC-Shell` for shell-friendly
  command surfaces.
- Maturity:
  strong microtool method; individual projects range from polished utility to
  rough proof of concept.
- Best fit for `VR-apps-lab`:
  OSC microhelper templates, safety checklists, typed-address matrices,
  external-signal bridges, and avatar-parameter control prototypes.

## Method 704: Meta Quest companion helper boundary for capture, setup, sensors, and device-risk operations

- What it is:
  a Quest companion helper separates device discovery/setup, permissions,
  capture or sensor acquisition, desktop processing, operator UI, rollback, and
  safety warnings.
- Good for:
  Quest screenshot/media loaders, screen casting helpers, ADB Wi-Fi setup,
  registry/config patchers, Reality Capture dataset pipelines, hand/eye
  tracking recorders, and camera/ML companion workarounds.
- Why it matters:
  Quest tooling often crosses sensitive seams: ADB, storage permissions, power
  state, registry edits, identity settings, casting, camera workarounds, and
  biometric data. Reuse needs explicit boundaries before code reuse.
- Source evidence:
  `t-34400/metaquest-3d-reconstruction`,
  `kodaekwan/MetaQuest_HandTracking`,
  `lukasmoro/cameraaccess-metaquest`,
  `CHUNx3/MetaQuestBitrateRegistryEditor`,
  `t-34400/MetaQuestScreenshotLoader`,
  `hiroyamochi/quest-screen-caster`,
  `XargonWan/metaquest-username-changer`,
  `SinanAkkoyun/OculusQuest2ADBAutoWifi`, and
  `Clept0/Unity_QuestPro_EyeTrackingRecorder`.
- Reusable core:
  device discovery, model/version detection, permission or ADB gate, risky
  operation confirmation, capture/sensor adapter, transport/schema, desktop or
  Unity plugin boundary, operator UI, rollback/restore path, privacy warning,
  and cleanup.
- Source evidence details:
  Wave 259 includes Quest Reality Capture dataset reconstruction, hand UDP
  packets and coordinate transforms, cast/OBS to YOLO to Unity TCP workarounds,
  Link registry patching, Android screenshot byte loading, scrcpy/screenrecord
  GUI casting with wake/proximity guards, username/config ADB patches, ADB
  Wi-Fi onboarding, and OVR eye-gaze CSV/heatmap/analysis flows.
- Do not copy directly:
  hidden setting edits without backup, identity patches without warnings,
  power/proximity commands without user consent, hardcoded ADB paths,
  unversioned UDP schemas, direct camera workarounds without privacy language,
  or bundled Unity sample assets as reusable architecture.
- Strong references:
  `quest-screen-caster` for Quest capture operator guards,
  `MetaQuestScreenshotLoader` for Unity/Android media ingestion,
  `metaquest-3d-reconstruction` for structured capture datasets,
  `MetaQuest_HandTracking` for sensor telemetry transforms, and
  `Unity_QuestPro_EyeTrackingRecorder` for research data capture.
- Maturity:
  high-value device-helper method with high safety, privacy, and platform
  compatibility caveats.
- Best fit for `VR-apps-lab`:
  Quest capture matrices, setup-helper checklists, sensor stream schemas,
  desktop companion prototypes, and risky device-operation documentation.

## Method 705: VRChat API companion boundary with auth, typed domains, pipeline events, and local logs

- What it is:
  a VRChat companion utility separates account consent, auth/TFA, cookie or
  token storage, typed REST domains, pipeline WebSocket events, local log
  ingestion, cache state, and visible privacy controls.
- Good for:
  social/session companions, friend/world notification tools, avatar or world
  dashboards, mobile/desktop sidecars, pipeline-event viewers, and local log
  sync utilities.
- Why it matters:
  VRChat service-data tools often mix login, cookies, API polling, pipeline
  sockets, local logs, and notification tasks in one surface. Reuse needs an
  explicit boundary so credentials, privacy, rate limits, and stale API
  behavior do not leak into every feature.
- Source evidence:
  `LinaTsukusu/vrchat-client`, `ccamgr/vrcp`,
  `binn/VRChat.API.Client`, `calmery/vrchat`, `Ox0017/vrc`, and
  `VRCMG/vrcapi-client`.
- Reusable core:
  credential source, consent/account state, TFA flow, cookie/token store,
  user-agent and rate/backoff policy, generated or typed domain modules,
  REST adapter, pipeline WebSocket adapter, local-log adapter, cache or local
  database, background task scheduler, privacy filter, and session visibility.
- Source evidence details:
  Wave 260 includes TypeScript module-per-domain clients, Expo/Tauri
  SecureStore-backed auth and desktop log sync, .NET fluent generated-client
  factories, compact auth/TFA wrappers, Java request-context DTO clients, and
  pipeline WebSocket token initialization.
- Do not copy directly:
  stale hardcoded API keys, raw credential logging, unbounded polling,
  invisible auto-login, global cookie state, direct pipeline URLs without
  lifecycle handling, or companion notifications without privacy gates.
- Strong references:
  `ccamgr/vrcp` for full companion boundaries, `binn/VRChat.API.Client` for
  host/factory integration, and `VRCMG/vrcapi-client` for REST plus pipeline
  split.
- Maturity:
  strong service-companion method with API-volatility and privacy caveats.
- Best fit for `VR-apps-lab`:
  VRChat API companion checklists, typed service adapters, event-vs-polling
  comparisons, privacy-aware notification surfaces, and log sync prototypes.

## Method 706: VRChat expression-menu authoring pipeline with generated assets, preview, and conflict checks

- What it is:
  an expression-menu authoring tool turns avatar objects, icons, menus,
  parameters, and animator/controller state into generated VRChat assets with
  preview, validation, budget checks, and cleanup metadata.
- Good for:
  toggle generators, outfit/prop menu builders, menu visualizers, icon
  pipelines, ModularAvatar/native-menu adapters, and creator-side repair
  tools.
- Why it matters:
  Expression menus are small, but authoring them crosses many brittle seams:
  eight-control menu limits, parameter budgets, animator layers, icon format,
  Unity asset GUIDs, ModularAvatar metadata, Undo, and generated file cleanup.
- Source evidence:
  `nekochanfood/VRCStyledIconMaker`,
  `nekoare/vrchat-expression-menu-visualizer`,
  `imagitama/vrc-menu-merger`,
  `zutozuto/VRChat-Menu-Creation-Tool`,
  `Knucklesfan/VRChatTextToMenu`, `Lucario4LyfeYT/EasyToggle`,
  `AtiLion/VRCMenuUtils`, and `CaelBun/DontOverrenderMyMenuV2`.
- Reusable core:
  source-object intake, icon normalization, parameter contract, menu page and
  pagination planner, animator/controller writer, conflict detector, preview
  tree/grid, generated asset markers, Undo/rollback path, and native,
  ModularAvatar, VRCFury, or runtime-patch adapter boundary.
- Source evidence details:
  Wave 261 includes SVG/PNG icon processing, Unity menu tree/grid editing,
  ModularAvatar reflection, menu/parameter/animator merge checks, grouped
  clothing/ornament toggle generation, raw YAML menu generation caveats,
  animation/layer/toggle generation, and historical runtime menu patching.
- Do not copy directly:
  destructive asset writes without Undo, raw YAML post-processing as a primary
  architecture, runtime quick-menu reflection patches, unbounded animator
  layer growth, or menu generation without cap and parameter conflict checks.
- Strong references:
  `vrchat-expression-menu-visualizer` for preview/edit UX,
  `vrc-menu-merger` for conflict checks, `EasyToggle` for generated toggle
  assets, and `VRCStyledIconMaker` for tiny icon-pipeline value.
- Maturity:
  strong creator-tooling method; runtime menu patch projects are historical or
  caveated references only.
- Best fit for `VR-apps-lab`:
  expression-menu authoring checklists, avatar control asset generators,
  menu preview prototypes, and native-vs-ModularAvatar comparison notes.

## Method 707: VPM package repository pipeline with manifest, lock, release fetch, validation, and listing UX

- What it is:
  a creator package publication pipeline turns package sources and release
  assets into validated VPM indexes, lockfiles, public listing pages, and
  VCC/ALCOM add-repository links.
- Good for:
  reusable VRChat creator packages, package-index generators, static listing
  sites, Linux packaging wrappers, release hygiene checks, and public package
  discovery pages.
- Why it matters:
  future `VR-apps-lab` prototype packages will need repeatable publication
  hygiene: package metadata, SemVer, dependencies, release URLs, hashes,
  licenses, generated indexes, and friendly add-to-client entry points.
- Source evidence:
  `Limitex/voyager-vpm`, `NathMorgan/vrchat-vpm`,
  `tamakiii/vrchat-vpm`, and `cuebitt/vpm`.
- Reusable core:
  source manifest, package manifest reader, SemVer and dependency validator,
  release asset fetcher, URL and hash verifier, lockfile writer,
  crash-recoverable transaction log, generated `index.json`, static listing
  page, VCC/ALCOM link builder, license notice, and platform permission
  boundary.
- Source evidence details:
  Wave 262 includes a Rust manifest/lock/index generator with GitHub release
  fetching and transaction recovery, a Flatpak wrapper with pinned dotnet
  dependencies and permissions, minimal static VPM links, and generated
  package listing sites with search, metadata modals, and copy/add actions.
- Do not copy directly:
  unvalidated package URLs, manually drifting indexes, hidden broad filesystem
  permissions, unpinned release assets, missing license notices, or website UX
  that hides repository trust boundaries.
- Strong references:
  `voyager-vpm` for validation and transaction design, `cuebitt/vpm` for
  listing UX, and `NathMorgan/vrchat-vpm` for Linux wrapper constraints.
- Maturity:
  strong package-publication method, especially for future reusable
  VRChat/Unity creator packages.
- Best fit for `VR-apps-lab`:
  VPM publication checklists, generated package indexes, package validation
  reports, and public listing UX for reusable prototypes.

## Method 708: Source-light VRChat utility triage across overlay, editor, world, and Udon surfaces

- What it is:
  a source-light triage pass classifies small VRChat utilities by surface,
  entry point, data source, artifact hygiene, generated assets, sync/network
  behavior, and donor-vs-reference value before promoting them into methods.
- Good for:
  tiny desktop overlays, historical SteamVR overlay experiments, editor
  packages, avatar inspectors, world helper scripts, Udon microcomponents, and
  package-template repositories.
- Why it matters:
  small VRChat repositories are often useful, but their reuse value varies
  sharply. A thin repo may be a strong product reference, a partial historical
  artifact, a package template, or a donor-worthy editor/runtime pattern.
- Source evidence:
  `o0F-0oF/vrchatoverlay`, `kizuki1749/VRChatOverlay`,
  `kxn4t/kanameliser-editor-plus`, `Zaknin/VRCTools`,
  `Himakuma/VRChatWorldTools`, `yassann325/VRC-NetworkQueue`, and
  `PeaceKunihiro/vrchat-udon-tools`.
- Reusable core:
  surface classification, entry-point map, data-source map, privacy/artifact
  audit, editor-vs-runtime boundary, generated asset/package state, sync or
  serialization behavior, install route, donor/reference/follow-up decision,
  and explicit caveat note.
- Source evidence details:
  Wave 263 includes Avalonia click-through log overlays, a partial
  Unity/SteamVR overlay with heavy artifacts, VPM editor QoL tools, avatar
  asset inspectors, SDK2 world helper callbacks, a mostly template VPM package,
  and tiny synced Udon audio/switch/auto-hide scripts.
- Do not copy directly:
  tracked `Library`, `bin`, `obj`, `.vs`, stale auth artifacts, SDK2-only
  assumptions, package templates with no implementation, or Udon scripts
  without reviewing ownership, serialization, and deserialization semantics.
- Strong references:
  `kanameliser-editor-plus` for editor QoL surfaces, `VRCTools` for avatar
  asset inspection, `vrchatoverlay` for log-driven overlay UX, and
  `vrchat-udon-tools` for tiny synced world-component behavior.
- Maturity:
  pragmatic intake method; useful for keeping the registry honest when repos
  are small, partial, or artifact-heavy.
- Best fit for `VR-apps-lab`:
  source-light intake checklists, artifact hygiene rules, VRChat editor
  diagnostics, Udon sync review notes, and transparent desktop overlay
  privacy patterns.

## Method 709: Spatial-video utility pipeline across conversion, metadata, camera control, playback, and export

- What it is:
  a spatial-video utility separates capture source, camera/lens profile,
  remap/projection transforms, metadata parsing or writing, optional
  stabilization, export format, and playback fallback.
- Good for:
  VR180 converters, stereo photo tools, projection metadata validators, camera
  companions, browser VR180 players, and local player projection shaders.
- Why it matters:
  VR180 projects often hide several brittle seams behind one UI. Reuse becomes
  safer when calibration, metadata, playback, and export are explicit modules.
- Source evidence:
  `34j/vr180-convert`, `silverqsy/VR180-Silver-Bullet`,
  `nallic/convert_VR180`, `aosoft/VR180MeshProjection`,
  `Vargol/VR180PhotoTools`, `ganeshv/egarim`,
  `Verdi/VR180-Web-Player`, `steren/stereo-img`, and
  `kasper93/mpv360`.
- Reusable core:
  source media adapter, lens/profile selection, remap map, feature-based or
  manual calibration, metadata parser/writer, device-control adapter,
  stabilization/timing stage, export preset, player capability gate, fallback
  mode, and diagnostics.
- Source evidence details:
  Wave 264 includes OpenCV remap CLIs, GoPro-style gyro processing, Canon
  ST-map conversion, Mesh Projection Box parsing, EXIF/XMP/right-eye photo
  tools, encrypted VR180 camera APIs, WebXR/fallback players, custom stereo
  image elements, and mpv shader controls.
- Do not copy directly:
  unsafe transform evaluation, hardware-specific scripts as generic logic,
  camera secrets or key files, incomplete parsers without guards, or viewers
  that silently ignore unsupported spatial-video formats.
- Strong references:
  `stereo-img` for declarative web-component playback, `vr180-convert` for
  small conversion CLI boundaries, `VR180-Silver-Bullet` for pipeline staging,
  and `VR180MeshProjection` for metadata parser evidence.
- Maturity:
  strong pattern family with uneven project maturity and many format/hardware
  caveats.
- Best fit for `VR-apps-lab`:
  VR180/spatial-video pipeline matrices, projection validators, browser media
  components, camera profile boundaries, and future spatial-media utility
  prototypes.

## Method 710: VRChat helper surface triage across editor, service, Udon, device, monitor, and OSC utilities

- What it is:
  a VRChat helper utility is first classified by surface and risk boundary:
  editor action, service CLI, Udon runtime library, device developer helper,
  social monitor, or avatar OSC controller.
- Good for:
  avatar editor workbenches, API CLIs, Udon byte serializers, Quest/ADB dev
  companions, friend/session monitors, and local avatar parameter tools.
- Why it matters:
  small VRChat utilities can touch credentials, public social data, destructive
  device actions, generated avatar assets, and Udon runtime state. Reuse needs
  safety gates before code ideas are promoted.
- Source evidence:
  `crestudio/VRSuya-Utility`, `te260ku/VRMenuUtility`,
  `AkitaIkeda/VRCFileUtility`, `thymespace/VRCPacketUtility`,
  `korinVR/VRDeveloperUtility`,
  `namoshika/VRChatUtility_FriendListMonitor`,
  `kikookraft/vrc-utility`, and `falnen/Python-VRC-utility`.
- Reusable core:
  surface type, entry point, credential or device gate, privacy exposure,
  action target, Undo/rollback/cooldown, visible operator state, package
  status, artifact hygiene, and donor/reference/source-light decision.
- Source evidence details:
  Wave 265 includes creator editor batch tools, Spectre.Console login/TFA
  CLIs, Udon byte buffers, Quest ADB/device action companions, cloud-backed
  friend-list monitors, artifact-only repos, and Python OSC avatar controllers.
- Do not copy directly:
  XML token storage, unreviewed Udon byte serializers, ADB/service commands
  without confirmation, public social monitoring without privacy gates,
  artifact-only repos as donor evidence, or syntax-broken prototypes.
- Strong references:
  `VRDeveloperUtility` for developer companion ergonomics,
  `VRSuya-Utility` for creator editor batch surfaces, and
  `VRCFileUtility` for service CLI routing after credential redesign.
- Maturity:
  pragmatic triage method; strong for safety and classification, with mixed
  source quality across projects.
- Best fit for `VR-apps-lab`:
  VRChat helper risk matrices, Quest developer companion prototypes, avatar
  editor batch tools, Udon serialization checklists, and privacy-first social
  monitor guidance.

## Method 711: Engine/browser XR primitive intake across devices, input selectors, locomotion, and projection components

- What it is:
  an XR primitive package is studied by the contracts it exposes: runtime
  device adapter, feature map, input event model, selector, target module,
  locomotion/body model, debug surface, and projection or texture helper.
- Good for:
  engine OpenVR addons, Unity XR input wrappers, selector frameworks,
  A-Frame/WebXR component libraries, and source-light runtime support packages.
- Why it matters:
  primitive packages are rarely polished products, but they can reveal reusable
  boundaries for future VR utilities if framework assumptions and deprecated
  APIs are named clearly.
- Source evidence:
  `Silverlan/PragmaVR`, `TheUtDuong/unity-vr-utilities`,
  `loganator956/unity-vr-utilities`, `nukadelic/UXRU`,
  `Ponsukeee/VRInputModule`,
  `Sunflower-Reality-Labs/aframe-srl-utils`, and
  `acerwebvr/Acer-VR-Utility-for-Browser-WebVR-Release`.
- Reusable core:
  runtime adapter, device identity, feature discovery/cache, input event enum,
  selector mode, current target/module handoff, fallback target, locomotion
  and collider model, debug HUD, projection material, lifecycle cleanup, and
  framework migration caveat.
- Source evidence details:
  Wave 266 includes Pragma OpenVR tracked-device entities, Unity loader
  switches, legacy XR trackers/player locomotion, laser and collision selector
  modules, A-Frame controller event panels and projection components, plus
  WebVR release-only packaging references.
- Do not copy directly:
  deprecated Unity XR APIs without migration notes, hardcoded rig names,
  vendor/sample payloads as original code, release-only browser packages, or
  selector logic without lifecycle tests.
- Strong references:
  `PragmaVR` for tracked-device entity abstraction,
  `VRInputModule` for selector/module boundaries,
  `aframe-srl-utils` for declarative browser components, and `UXRU` for
  legacy input primitive mapping.
- Maturity:
  useful primitive intake method with framework-specific caveats.
- Best fit for `VR-apps-lab`:
  selector pipeline comparisons, framework-neutral input contracts, browser XR
  component diagnostics, locomotion/body-model notes, and legacy-to-modern XR
  migration matrices.

## Method 712: Source-light overlay intake across README intent, vendor shells, minimal native loops, and MR panels

- What it is:
  a source-light overlay pass classifies each candidate by implementation
  evidence before reuse: README-only intent, placeholder, vendor-heavy shell,
  minimal native overlay loop, or narrow MR panel reference.
- Good for:
  OpenVR/SteamVR overlay searches, game HUD ideas, Unity overlay shells,
  minimal C/OpenVR baselines, and Quest MR annotation panels.
- Why it matters:
  overlay searches produce many noisy repositories. Promoting them without
  source evidence pollutes the registry; dismissing them entirely loses useful
  product-demand and minimal-baseline signals.
- Source evidence:
  `bwmcadams/vorpal`, `UpsilonScorpi/VRP-Overlay`,
  `LapisGit/OVRTweaks`, `JasonPKnoll/vr_overlay`, and
  `pouya-codes/VR_overlay`.
- Reusable core:
  source evidence level, overlay API or MR framework, texture submission path,
  placement model, input/toggle model, artifact hygiene, binary/vendor payload
  check, product intent, donor/reference classification, and follow-up route.
- Source evidence details:
  Wave 267 includes two README-only overlay names, a SteamVR-heavy Unity
  project shell, a tiny C/rawdraw/OpenVR texture submission loop, and a Quest
  mixed-reality heatmap image panel with opacity and hand/controller toggles.
- Do not copy directly:
  checked-in executables, uninitialized overlay state, vendor SteamVR payloads
  as original logic, placeholder repos, mixed clinical/demo docs, or Meta-only
  passthrough scripts as generic overlay APIs.
- Strong references:
  `JasonPKnoll/vr_overlay` for minimal native OpenVR texture submission and
  `pouya-codes/VR_overlay` for narrow MR annotation-panel UX, both with
  explicit caveats.
- Maturity:
  intake and triage method, not a full implementation pattern.
- Best fit for `VR-apps-lab`:
  minimal overlay baselines, source-light overlay checklists, game-HUD demand
  references, MR image/annotation panel ideas, and vendor-heavy caveat rules.
