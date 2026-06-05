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
