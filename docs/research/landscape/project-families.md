# Project Families

- Date: `2026-04-21`
- Goal: reorganize the `VR-apps-lab` research corpus around logical overlap
  families instead of a long flat list of repositories.

## Why this file exists

At this point `VR-apps-lab` already contains:

- a large initial landscape pass;
- multiple follow-up research waves;
- several focused reuse-plan documents;
- deeper passes on under-documented repositories.

The next useful step is not more random expansion. It is `grouping`,
`deduplication by idea`, and understanding which clusters are already mature.

## Status legend

- `Already studied`
  covered well enough across one or more existing docs.
- `Partially studied`
  present in `VR-apps-lab`, but still deserving a dedicated deeper code-level pass.
- `Not studied deeply`
  either missing from the repo or only known through a quick mention.
- `Fork / variant only`
  valuable for comparison, but probably not worth a full standalone deep dive
  before the main upstream is understood.

## Role note

- Use this file for overlap, comparison, and family-level product direction.
- The status labels shown here are mirrored for convenience.
- `../catalog/project-registry.md` remains the canonical owner of per-repo
  status.

## Family 1: OpenXR runtime switchers, inventories, and layer managers

This family is already converging into the future `OpenXR Doctor` direction.

| Project | Status | Notes |
|---|---|---|
| `KhronosGroup/OpenXR-Inventory` | Already studied | Structured capability matrix for runtime and middleware support |
| `rpavlik/xr-picker` | Already studied | Clean core/GUI split for runtime picking and manifest inspection |
| `elliotttate/OpenXR-Simulator` | Already studied | Headsetless runtime and runtime-registration reference |
| `ox-runtime/ox-sim-driver` | Already studied | Automation-friendly simulator runtime with shared core plus GUI and programmatic control paths |
| `davidrios/openxr-device-simulator` | Not studied deeply | Thin but relevant Rust runtime-simulator signal that still needs a clearer public pass |
| `mbucchia/OpenXR-Vk-D3D12` | Already studied | Graphics API adapter layer bridging Vulkan/OpenGL apps into D3D12-only runtime paths |
| `mbucchia/VirtualDesktop-OpenXR` | Already studied | Full runtime implementation reference with registration, settings watch, and precompositor paths |
| `fredemmott/OpenXR-API-Layers-GUI` | Already studied | Strongest layer diagnostics and enable/disable UX reference |
| `WaGi-Coding/OpenXR-Runtime-Switcher` | Already studied | Runtime switching reference with admin-aware UX |
| `UniStuttgart-VISUS/OpenXR-Runtime-Switcher` | Already studied | Alternate runtime switcher framing |
| `ytdlder/OpenXR-Switcher` | Already studied | Runtime and layer toggling overlap |
| `jonyrh/OXR_Switcher` | Already studied | Runtime manager UX variant with CLI angle |
| `shiena/OpenXRRuntimeSelector` | Already studied | Engine-side runtime selection helper built around runtime providers and registry enumeration |
| `1runeberg/OpenXRProvider` | Already studied | Library plus sandbox wrapper around OpenXR core, render, and input bring-up |
| `mbucchia/OpenXR-Layer-Template` | Already studied | Bootstrap template for future layer work |
| `Jabbah/OpenXR-Layer-OBSMirror` | Already studied | Practical example of a layer built from a template |
| `maluoi/openxr-explorer` | Already studied | Strongest single reference for `OpenXR doctor/runtime inspector` |
| `Ybalrid/OpenXR-Runtime-Manager` | Already studied | Small WPF runtime switcher built around registry reads plus well-known manifest probes |
| `PlutoVR/OpenXR-OverlayLayer-1` | Already studied | Remote overlay client plus API-layer experiment using shared-memory RPC |
| `pembem22/etvr-openxr-layer` | Already studied | Android-side implicit API layer that adapts OSC eye-tracking data into OpenXR gaze surfaces |
| `clear-xr/clearxr-server` | Already studied | Runtime-side platform split across desktop streamer, landing-space app, and action-rewriting OpenXR API layer |
| `vrkit-platform/vrkit-platform` | Already studied | Plugin-manifest runtime and overlay platform with service-daemon slices, native interop, and explicit OpenXR-facing modules |

### Consolidation note

This is one of the highest-overlap families in the whole repository. The main
output of this family for `VR-apps-lab` should be a single future product concept:

- `OpenXR Doctor`
- `runtime capability matrix`
- `runtime adapter and bring-up playbook`

## Family 2: SteamVR/OpenVR notification and remote-control overlays

This family centers on letting an external process drive overlay or
notification behavior.

| Project | Status | Notes |
|---|---|---|
| `BOLL7708/OpenVROverlayPipe` | Already studied | Best reference for `server-driven overlay creation` |
| `jeppevinkel/OpenVRNotificationPipe` | Already studied | Focused notification pipe reference |
| `WiiPlayer2/VnotifieR` | Already studied | Local HTTP notification server with config-driven overlay placement and fade behavior |
| `BOLL7708/OpenVR2WS` | Already studied | Broader runtime I/O and settings bridge |
| `I5UCC/SteaMeeter` | Already studied | Dashboard bridge into an external audio/control system |
| `I5UCC/ParameterSaveStates` | Not studied deeply | Related automation/control-surface family node |
| `hai-vr/h-view` | Already studied | Desktop-plus-overlay utility host with OSCQuery tooling, hardware views, and strong overlay-management slices |
| `MeroFune/GOpy` | Not studied deeply | Additional control/integration utility candidate |

### Consolidation note

This family points toward a future `VR notification / overlay service bus`
instead of several unrelated mini-tools.

## Family 3: Lighthouse managers and room-state helpers

This is a large family with very high overlap in problem space and very low
need for flat duplication in the index.

| Project | Status | Notes |
|---|---|---|
| `kurotu/OVR-Lighthouse-Manager` | Already studied | One of the main Windows references |
| `DHCPCD9/go-steamvr-lighthouse-manager` | Already studied | Alternate UI/automation angle |
| `xi-ve/openvr-lighthouse-manager-linux` | Already studied | Linux port/reference |
| `nouser2013/lighthouse-v2-manager` | Already studied | Small scripting-oriented variant |
| `SeeUnsharp/LighthouseManager` | Already studied | Command-line and Windows BLE angle |
| `seader/LighthouseManagerPimax` | Already studied | Pimax-oriented variant |
| `FennecLabsLtd/LighthouseManager` | Already studied | Config backup/restore framing |
| `risa2000/lhctrl` | Already studied | Linux BLE micro-tool for v1 |
| `risa2000/lh2ctrl` | Already studied | Linux BLE micro-tool for v2 |
| `ugokutennp/watchman-pairing-assistant` | Already studied | GUI wrapper around pairing flows and `lighthouse_console` |

### Consolidation note

This family deserves a later comparative matrix, because the main axis is not
just platform but also:

- `power only`
- `BLE control`
- `room/config backup`
- `SteamVR automation`

## Family 4: Battery and device-monitor utilities

This family has a lot of logical duplication, but it is still useful because it
shows different product scales: tray app, overlay, notification tool, inventory
panel, and logging utility.

| Project | Status | Notes |
|---|---|---|
| `OVRTools/OpenVRDeviceBattery` | Already studied | Strong tray-app and background-helper reference |
| `zeroae/VRBattery` | Already studied | Tiny Qt battery widget rendered into an OpenVR dashboard surface |
| `Black4Blade/SteamVR-Devices-Battery-Status` | Already studied | Tiny battery micro-tool reference |
| `rhaamo/OpenVR-Display-Devices` | Already studied | Broader device inventory view |
| `copperpixel/steamvrbattery` | Already studied | Minimal CLI property-polling battery monitor |
| `Denwa/vive-wireless-info-overlay` | Not studied deeply | Source-light wireless-temperature micro-overlay whose product framing is stronger than its visible code donor value |
| `KaftanOS/SteamVR-Battery-Checker` | Already studied | Tiny one-shot Python battery inspector with almost no product baggage |
| `jangxx/openvr-battery-monitoring` | Already studied | Tray watcher that reacts to charging-state changes and can notify through desktop or OVRT channels |
| `mutr/openvr_battery_monitor` | Already studied | Background battery exporter that writes per-device telemetry to InfluxDB |

### Consolidation note

This should become a single `Device Monitor` family inside `VR-apps-lab`, with
sub-modes like:

- wrist/device overlay
- tray/desktop watcher
- notification-only helper
- inventory/detail screen

## Family 5: Virtual tracker, OSC, WebSocket, and bridge tooling

This is one of the most strategically valuable families because it converts
external data into `SteamVR/OpenVR devices`, `pose streams`, or `OSC events`.

| Project | Status | Notes |
|---|---|---|
| `Timocop/PSMoveServiceEx-VMT` | Already studied | Core virtual-tracker reference |
| `gpsnmeajp/VirtualMotionTracker` | Already studied | Mature OSC tracker platform with manager/driver split and skeletal input support |
| `faidra/VMC2VMT` | Already studied | Unity-side protocol adapter that forwards performer data into `VMT` instead of creating a new driver |
| `gpsnmeajp/SkeletonPoseTester` | Already studied | Tiny skeletal-input validation utility that complements the heavier `VMT` host line |
| `John-Dean/OpenVR-Tracker-Websocket-Driver` | Already studied | Mainline WebSocket tracker-service driver with local HTTP test surface and pose echo |
| `surplex-io/OpenVR-Driver` | Fork / variant only | Near-clone of the John-Dean line that mainly adds tracker-role mapping |
| `ju1ce/Simple-OpenVR-Bridge-Driver` | Already studied | Named-pipe bridge-driver skeleton with explicit tracker lifecycle, timing sync, and pose readback helpers |
| `3NekoSystem/OpenVR-Tracker-Websocket-Driver` | Fork / variant only | Simpler JSON/WebSocket fork on `8082` that trims the broader local-service ambitions of the main WebSocket line |
| `v0xie/OpenVR-Tracker-Websocket-Driver` | Fork / variant only | Near-mirror of the John-Dean line with the same local web page, HTTPS helpers, and device-state echo surfaces |
| `krazysh01/VirtualDesktop-OpenVR-Trackers` | Partially studied | Tracker-bridge signal from an external ecosystem whose current public snapshot still looks thinner than expected |
| `SophiaH67/soph_wireless` | Already studied | UDP relay driver that re-registers tracker state from another SteamVR instance |
| `SophiaH67/soph_wireless_transmitter` | Already studied | Tiny paired sender utility that makes the relay packet contract explicit |
| `Greendayle/SteamVR_To_OSC` | Already studied | SteamVR to OSC bridge |
| `ZekkVRC/OpenVR2OSC` | Already studied | VRChat-oriented input bridge |
| `BarakChamo/OpenVR-OSC` | Already studied | Minimal OpenVR pose-to-OSC exporter built around `triad_openvr` and OSC bundles |
| `logicmachine/OVR-VRC-OSC-Bridge` | Already studied | Config-defined action-set compiler that generates an OpenVR manifest and maps controller state into OSC bundles |
| `jangxx/steamvr-osc-control` | Already studied | Control bridge for SteamVR functions |
| `choyai/SteamVRTrackerUtility` | Already studied | Tiny serial-based identity helper for deterministic tracker binding workflows |
| `TriadSemi/triad_openvr` | Already studied | Strong Python wrapper for scripting, events, and device polling |
| `biosmanager/unity-openvr-tracking` | Already studied | Unity-side OpenVR adapter with no-HMD-friendly initialization and SteamVR tracker-role reuse |
| `JLChnToZ/axis-vrc-osc-bridge` | Already studied | Standalone vendor-tracker-to-VRChat OSC bridge that bypasses the SteamVR driver path |
| `I5UCC/VRCThumbParamsOSC` | Already studied | Configurable SteamVR/XInput-to-VRChat OSC exporter with OSCQuery and auto-launch support |
| `TheNexusAvenger/Enigma` | Not studied deeply | Consumer-side export of SteamVR tracker roles into a non-XR client with a companion plugin path |
| `ThatGuyThimo/leapmotion-osc` | Not studied deeply | Finger-only OSC egress utility adjacent to the hand-tracking and avatar-parameter bridge family |

### Consolidation note

This family is the clearest foundation for a future:

- `Tracker Bridge Service`
- `SteamVR/OSC bridge`
- `external sensor -> virtual tracker` platform
- `engine-side role reuse and direct consumer export`

## Family 6: Desktop and overlay utility suites

This family overlaps heavily in product goal even when implementation differs
by runtime or operating system.

| Project | Status | Notes |
|---|---|---|
| `DesktopXR` | Already studied | OpenXR desktop-overlay product reference |
| `DesktopPlus` | Already studied | Strongest Windows/OpenVR product reference |
| `OpenVRDesktopDisplayPortal` | Already studied | Early but feature-rich overlay utility |
| `DesktopPortal` | Already studied | Utility-suite framing with watch controls |
| `UVROverlay` | Already studied | General-purpose overlay shell |
| `WlxOverlay` | Already studied | Linux-first overlay reference |
| `wlx-overlay-s` | Already studied | Modern lightweight Linux overlay reference |
| `wlx-overlay-x` | Already studied | Transitional OpenXR overlay path |
| `fnuidesktop-VR` | Already studied | Direct desktop interaction patterns |
| `wayvr` | Already studied | Low-overhead desktop/app-launching view |
| `rrkpp/SpotifyOverlay` | Already studied | Qt dashboard micro-utility rendered offscreen into OpenVR |
| `Hotrian/OpenVRTwitchChat` | Already studied | Twitch-specific chat overlay with threaded service layer and profile persistence |
| `CrispyPin/ovr-utils` | Partially studied | GitHub snapshot is now mostly a relocation stub, but the lineage still matters for the suite family |
| `mittorn/ovr-utils-dashboard` | Already studied | Godot overlay shell with settings-driven overlay instances and reusable add-ons |
| `artumino/SteamVR_HUDCenter` | Already studied | C# overlay helper and notification library with WinForms or WPF rasterization into VR |
| `LapisGit/LapisOverlay` | Already studied | In-progress overlay-first host with dashboard, wrist surface, and media sidecar split |
| `elvissteinjr/SteamVR-PrimaryDesktopOverlay` | Already studied | Micro-tool that patches SteamVR's existing desktop overlay instead of rendering a new one |
| `Nexz/turncountervr` | Not studied deeply | Rotation counter / cable-awareness overlay node |
| `Martin-Oehler/SteamVR-WebApps` | Already studied | Thin browser-backed dashboard wrappers built on top of `SteamVR-Webkit` |
| `Mon-Ouie/launcher-openvr-overlay` | Already studied | Linux launcher shell that hands app windows and videos off to external display tools such as `gamescope` and `vr-video-player` |
| `Mon-Ouie/mpris-openvr-overlay` | Already studied | Very small egui-based media-state and transport-control surface over the desktop `MPRIS` bus |
| `Mon-Ouie/vr-video-player-overlay` | Already studied | Focused `window or video -> VR display surface` path with flat, plane, sphere, and overlay modes |
| `iigomaru/MPVR` | Partially studied | Rough libmpv-in-overlay proof of concept that is weaker as a product but still useful as a lower-bound media-embed comparison node |
| `hiinaspace/vr-notes-anywhere` | Already studied | Projection-overlay note surface that proves annotation can be treated as a tiny scene-state problem instead of a desktop mirror |
| `jacklul/SteamVR-PhasmoMatrix` | Already studied | Ultra-thin website-wrapper overlay whose main value is focused domain packaging, not a broad host shell |
| `SteveMarkhamGIT/SmudgeTimerOpenVR` | Already studied | Wrist-mounted game-status overlay with controller-tip gesture triggering and generated-texture updates |

### Consolidation note

This family should feed a future comparative UX document, not just more
individual project entries. The real overlap axes are:

- `desktop mirror`
- `window portal`
- `wrist/watch controls`
- `dashboard suite`
- `overlay patch micro-tool`
- `media/player overlay`
- `annotation surface`
- `game-specific status surface`
- `Linux vs Windows UX`
- `OpenVR overlay vs OpenXR layer`

## Family 7: Accessibility overlays and assistive HUDs

This family is now clearly large enough to be treated as a first-class product
direction.

| Project | Status | Notes |
|---|---|---|
| `Vinventive/live-captions-vr` | Already studied | Speech-to-text overlay reference |
| `MochiDoesVR/OpenVRCaptions` | Already studied | C#/SteamVR captions reference |
| `ctobin1114/UniversalVR-CC` | Already studied | Browser-first closed-caption surface meant to be pulled into VR through another host |
| `gt0777/VRCLiveCaptionsMod` | Already studied | App-internal live-captions path built around a VRChat voice hook |
| `matzman666/OpenVR-MicrophoneControl` | Already studied | Dashboard mute/PTT overlay with OS audio integration |
| `Beyley/eepyxr` | Already studied | OpenXR overlay utility framed around comfort/sleep use |
| `rrazgriz/VRCMicOverlay` | Already studied | Minimal HMD-relative mic-state overlay with OSC/audio hooks |
| `I5UCC/VRCTextboxSTT` | Already studied | Local STT service with SteamVR overlay as one output surface |
| `OpenVROverlayPipe` / notification tools | Already studied | Assistive notification angle |
| `TurnSignal` | Already studied | Comfort/safety micro-utility |
| `SteamVR_ClockOverlay_Public` | Already studied | Minimal assistive wrist-clock pattern |
| `lukis101/VRPoleOverlay` | Already studied | Spatial-awareness overlay that renders a known room object and borrows chaperone color and height as configuration defaults |

### Consolidation note

This is big enough to be treated as a product family:

- captions
- status hints
- assistive HUDs
- comfort and orientation helpers
- anchored room-awareness overlays

## Family 8: Driver tutorials and custom-device plumbing

This family is less about end-user utilities and more about building the
knowledge needed for `device-side tooling`.

| Project | Status | Notes |
|---|---|---|
| `terminal29/Simple-OpenVR-Driver-Tutorial` | Already studied | Best current public learning-path repo for sample-like OpenVR driver structure |
| `ValveSoftware/openvr` tutorial/sample code | Already studied | Foundational reference |
| `ChristophHaag/SteamVR-OpenHMD` | Already studied | OpenHMD hardware bridge into SteamVR/OpenVR |
| `mm0zct/Oculus_Touch_Steam_Link` | Already studied | Mixed-VR controller, tracker, and sensor bridge driver |
| `kodowiec/Yet-Another-OpenVR-IPC-Driver` | Already studied | Named-pipe or Unix-socket bridge driver that spawns synthetic trackers and controllers from external commands |
| `bdub1011/Quest-Link-Hand-Tracking` | Partially studied | Gesture-configurable Quest hand-tracking to SteamVR controller-emulation path whose current public source is thin |
| `mSparks43/PSVR-SteamVR-openHMD` | Already studied | PSVR-specific OpenHMD bridge variant with extra helper code and hardware-focused adaptations |
| `SlimeVR/SlimeVR-OpenVR-Driver` | Already studied | Modern tracker bridge driver with external service transport |
| `oleuzop/VirtualSteamVRDriver` | Already studied | Virtual HMD driver for no-headset development and testing |
| `finallyfunctional/openvr-driver-example` | Already studied | Beginner-friendly controller/input-emulation driver tutorial |
| `Somebody32x2/RemoteVVR` | Already studied | Rough but explicit file-fed and browser-fed synthetic HMD/controller driver |
| `codeysun/OpenVR-Tracker-Driver-Example` | Already studied | Minimal generic tracker plus tracking-override harness for head-pose experiments |
| `SecondReality/VirtualControllerDriver` | Already studied | Tiny synthetic controller driver for mixed-reality workflows |
| `oneup03/VRto3D` | Already studied | Productized stereo-display and AR-glasses driver that heavily reshapes SteamVR behavior |
| `ValveSoftware/driver_hydra` | Already studied | Official peripheral bridge driver with controller realignment and calibration monitor |
| `alatnet/OpenPSVR` | Already studied | Full PSVR HMD/display driver with monitor detection, power control, display component, and IMU-based tracking |
| `r57zone/OpenVR-driver-for-DIY` | Already studied | Keyboard-driven DIY null-HMD plus controller path built close to the stock sample |
| `gpsnmeajp/SegsVRControllerDriverSample` | Already studied | Controller-driver sample with a shared-memory helper client and JSON payloads |
| `puresoul/Barebone` | Already studied | XInput-driven synthetic Vive controller path anchored relative to the HMD |
| `mmorselli/Joy2OpenVR` | Already studied | DirectInput-to-InputEmulator sidecar for unusual physical controllers |
| `mdovgialo/SteamVR-Glove` | Already studied | Arduino glove proof of concept piggybacking on existing Vive controller tracking |
| `openvrmc/OpenVR-MotionCompensation` | Already studied | Pose-rewrite driver with shared library and in-VR dashboard configuration |
| `OpenDisplayXR/OpenDisplayXR-VDD` | Not studied deeply | Sparse but relevant signal for a simulated OpenVR/OpenXR virtual hardware path |
| `verncat/RayNeo-Air-3S-Pro-OpenVR` | Already studied | SDK-first RayNeo glasses bridge whose transport and API layer now sit cleanly beside a dedicated driver repo |
| `verncat/RayNeo-Air-3S-Pro-OpenVR-Driver` | Already studied | Dedicated RayNeo OpenVR driver repo with bindings, prelauncher, and clearer device-provider split |
| `LucidVR/opengloves-driver` | Already studied | Hand-specific custom device path with driver, service, and overlay split |
| `LucidVR/lucidgloves` | Already studied | Matching firmware and hardware ecosystem for the same glove family |
| `r57zone/OpenVR-ArduinoHMD` | Already studied | DIY HMD path with serial IMU ingest, display tuning, and helper monitor workflow |
| `DaniXmir/GlassVr` | Already studied | XR/AR glasses bridge with Python sidecar, headset/controller/tracker emulation, and hand-simulation path |
| `Copprhead/hotas-vr-controller` | Already studied | Domain-specific cockpit/device bridge with config-driven offsets and hook-based clicks |
| `TrueOpenVR/SteamVR-TrueOpenVR` | Partially studied | Sample-derived bridge that feeds SteamVR from an external TrueOpenVR DLL surface |
| `HoboVR-Labs/hobo_vr` | Already studied | Driver prototyping stack with an explicit external poser protocol and language bindings |
| `r57zone/Razer-Hydra-SteamVR-driver` | Already studied | Legacy peripheral bridge with helper monitor and controller-role mapping |

### Consolidation note

This should eventually become a dedicated learning track in `VR-apps-lab`:

- `driver tutorial`
- `custom device plumbing`
- `synthetic controller and input-emulation sidecars`
- `pose rewriting and motion-manipulation drivers`
- `domain-specific hardware bridges`
- `virtual display and repurposed output drivers`

## Family 9: Vendor enhancement and mod layers

These projects are especially useful because they sit `on top of` official
vendor stacks instead of replacing them.

| Project | Status | Notes |
|---|---|---|
| `BnuuySolutions/PSVR2Toolkit` | Already studied | Vendor-driver wrapper with versioned IPC for gaze data and trigger-effect control |
| `BnuuySolutions/PSVR2Toolkit.VRCFT` | Already studied | Downstream consumer module that maps toolkit IPC into VRCFaceTracking semantics |
| `s-ilent/PSVR2ToolkitTriggerConfig` | Already studied | Focused desktop trigger-config utility layered over the toolkit IPC contract |
| `tabithamoon/ResonitePSVR2` | Already studied | Engine-specific eye-tracking bridge that consumes the toolkit IPC surface |
| `PSVR2-related forks/variants` | Not studied deeply | Worth mapping later if this branch expands |

### Consolidation note

This family supports a future `vendor enhancement` research direction:

- augment official stack
- keep vendor runtime intact
- expose extra features through utility-side APIs

## Family 10: Compatibility layers and runtime translation

These projects sit between incompatible or competing runtime ecosystems and are
valuable for understanding translation, emulation, and compatibility shims.

| Project | Status | Notes |
|---|---|---|
| `QuestCraftPlusPlus/OpenComposite` | Already studied | Main OpenVR-to-OpenXR compatibility reference |
| `Supreeeme/xrizer` | Already studied | Alternate OpenVR-on-OpenXR direction |
| `LibreVR/Revive` | Already studied | Compatibility layer between Oculus stack and OpenVR/OpenXR |
| `alvr-org/ALVR` | Already studied | Streaming stack, but also useful for runtime compatibility patterns |
| `OSVR/SteamVR-OSVR` | Already studied | Foreign-framework compatibility driver that maps OSVR HMD and tracked-device surfaces into SteamVR |
| `terminal29/OSVR-SteamVR-Bridge` | Already studied | Smaller alias-mapping comparison node for the same OSVR-to-SteamVR bridge family |

### Consolidation note

This family matters less as a direct product target and more as a source of:

- translation-layer architecture
- runtime compatibility patterns
- install and registration models

## Family 11: Performance, rendering, and post-process tooling

This family is about image processing, foveation, scaling, and rendering-side
instrumentation rather than overlays or device control.

| Project | Status | Notes |
|---|---|---|
| `fholger/vrperfkit` | Already studied | Main donor for D3D11 post-process patterns |
| `fholger/openvr_fsr` | Already studied | Earlier, smaller reference for the same lineage |
| `RavenSystem/VRPerfKit_RSF` | Already studied | Practical `vrperfkit` continuation with dynamic modes, hidden radial mask control, and original-DLL chaining |
| `CamelCaseName/OpenVRPerfKit` | Already studied | Backend-expanded fork line that pushes the same family toward `D3D12` and bundled `FSR2` |
| `Granther/foveated-rendering` | Already studied | Dynamic focus-source experiment that currently leans on cursor-driven control more than mature gaze ingestion |
| `mbucchia/Quad-Views-Foveated` | Already studied | Important OpenXR rendering-adaptation layer for quad views and foveation compatibility |
| `mbucchia/OpenXR-Eye-Trackers` | Already studied | Multi-backend eye-gaze adaptation layer that normalizes several foreign sources into OpenXR gaze surfaces |
| `retroluxfilm/reshade-vrtoolkit` | Already studied | VR-first shader bundle for sharpening, color treatment, and other image adjustments |
| `zhukovv/upscale-injection` | Already studied | Generic D3D11 injection and upscaling donor for low-level hook mechanics |

### Consolidation note

This family should feed:

- GPU-side processing ideas
- future texture-path upgrades
- foveation and eye-tracking experimentation

## Family 12: Passthrough, reality layers, and camera experiments

This family matters because it covers real-world view, passthrough, and
camera-adjacent utility directions, even though not all projects are practical
product donors for current target hardware.

| Project | Status | Notes |
|---|---|---|
| `Rectus/openxr-steamvr-passthrough` | Already studied | Closest PC/SteamVR architectural analogue to the original idea |
| `zhangxuelei86/WMR-Passthrough` | Already studied | OpenXR API-layer plus camera-service pattern |
| `Danealor/VRPassthrough` | Already studied | Lightweight USB-camera passthrough utility path |
| `jangxx/LeapOVRPassthrough` | Already studied | Gesture-triggered passthrough UX reference |
| `alexander-clarke/openvr-room-mapping` | Already studied | Pose-plus-image capture pipeline that sits between environment reconstruction and alignment research |

### Consolidation note

This family is now best treated as:

- `research and experimentation`
- `external camera / scoped passthrough` inspiration

rather than a guaranteed production direction.

## Family 13: Creator tools, capture, metrics, and workflow utilities

These projects are more about recording, inspection, workflow support, and
creator-facing XR use than about simple end-user overlays.

| Project | Status | Notes |
|---|---|---|
| `OpenKneeboard/OpenKneeboard` | Already studied | Strong simulator and workflow-oriented overlay reference |
| `baffler/OBS-OpenVR-Input-Plugin` | Already studied | OpenVR mirror-texture capture into OBS through D3D11 shared resources |
| `ValveSoftware/virtual_display` | Already studied | `IVRVirtualDisplay` sample with out-of-process remote presentation transport |
| `BOLL7708/SuperScreenShotterVR` | Already studied | Screenshot utility combining viewfinder overlays, notifications, timers, and WebSocket automation |
| `iigomaru/Periodic-Immersive-SteamVR-Screenshots` | Already studied | Ultra-small timed screenshot micro-utility for startup-overlay workflows |
| `xrtlab/clovr` | Already studied | Session capture and research-tooling reference |
| `ethanporcaro/tracking-toolkit` | Already studied | Creator-facing OpenXR recording and Blender integration |
| `Nyabsi/openvr-metrics` | Already studied | Strong metrics + control overlay product reference |
| `fredemmott/XRFrameTools` | Already studied | OpenXR frame-loop metrics reference |
| `peacepenguin/Virtual-Display-Driver` | Already studied | Infrastructure for desktop and workflow scenarios |
| `ValveSoftware/OpenXR-Canonical-Pose-Tool` | Already studied | Runtime-vendor pose validation and canonical-pose comparison tool |
| `MuffinTastic/openvr-device-positions` | Already studied | Creator-side pose inventory exporter with dashboard overlay and FBX output path |
| `99oblivius/VRBro-Overlay` | Already studied | OBS-control overlay with wrist-menu and dashboard split over a local plugin protocol |
| `kuentzel/ROVER` | Already studied | Standalone questionnaire and study station whose overlay manager, operator UI, and importable study schema matter more than any one screen |

### Consolidation note

This family supports a separate `creator and diagnostics` branch inside
`VR-apps-lab`, not just consumer-facing overlays.

It also strengthens a smaller but useful sub-branch:

- screenshot workflow helpers
- creator micro-automation tools
- remote-triggered capture flows
- creator control surfaces
- standalone study stations

## Family 14: Overlay implementation references and host scaffolds

These repos are especially useful for understanding `how to build` overlays,
not only how finished utility products behave.

| Project | Status | Notes |
|---|---|---|
| `sh-akira/VROverlay` | Already studied | Unity/OpenVR overlay sample with VR UI pointer plumbing |
| `BenWoodford/SteamVR-Webkit` | Already studied | Browser-backed overlay toolkit with JS interop and dual dashboard/in-game surfaces |
| `BenWoodford/OVROverlayManager` | Already studied | Tiny Unity helper that turns render textures and OpenVR events into reusable overlay projectors |
| `beniwtv/vr-streaming-overlay` | Already studied | Godot multi-overlay shell with widget/config split |
| `Nyabsi/steamvr_overlay_vulkan` | Already studied | Modern Vulkan/ImGui overlay template |
| `Hotrian/HeadlessOverlayToolkit` | Already studied | Hidden-window and background-host overlay pattern in Unity |
| `cnlohr/openvr_overlay_model` | Already studied | Experimental stereo-per-eye overlay technique for pseudo-3D content |
| `JoeLudwig/overlay_experiments` | Already studied | Historical browser-backed OpenVR dashboard experiments |
| `artumino/SteamVR_HUDCenter` | Already studied | Older but valuable C# overlay library with notification flow and desktop-UI-backed surfaces |
| `Martin-Oehler/SteamVR-WebApps` | Already studied | Web-app-driven overlay wrappers that demonstrate the thinnest `browser -> dashboard` shell |
| `LapisGit/LapisOverlay` | Already studied | Unity overlay host with dashboard, wrist-surface, and sidecar-fed media panel pattern |
| `KainosSoftwareLtd/VRSceneOverlay` | Already studied | Unity scene-overlay scaffold with tracked helpers and Leap-oriented augmentation |
| `hai-vr/h-view` | Already studied | Modern overlay-first utility host with ImGui rendering, desktop parity, and action-manifest-driven overlay management |
| `vrkit-platform/vrkit-platform` | Already studied | OpenXR monitor/overlay platform with plugin-manager, native interop, and service-daemon boundaries now clarified by a deeper pass |
| `LunarG/OpenXR-Overlays-UE4-Plugin` | Already studied | Tiny Unreal-side reference for injecting `XR_EXTX_overlay` session-create info |
| `mbucchia/_ARCHIVE_OverXR` | Fork / variant only | Current GitHub state is an archive shell with little code to inspect |
| `foxt/csharp-openvr-overlay-imgui` | Already studied | C# overlay host with Dear ImGui input forwarding, fake desktop debug view, and adjacent desktop-duplication slice |
| `hiinaspace/godot-openvr-overlay` | Already studied | Godot-native projection-overlay extension that exposes tracker poses, action state, and stereo eye submission through an XR interface |
| `ondorela/OpenVROverlay_imgui` | Already studied | Small D3D11 plus ImGui sample showing direct overlay-event forwarding into the UI stack |
| `thomasmo/SampleVRO` | Already studied | Explicit Win32 plus D3D11 texture-to-overlay sample with forwarded keyboard or pointer interaction |
| `ovrlay/LibOverlay` | Already studied | Minimal Unity helper over raw OpenVR overlay calls with tracked-device attachment and texture refresh |
| `Marlamin/VROverlayTest` | Not studied deeply | Additional D3D11 overlay scratchpad that may matter only if a future pass needs an even thinner Windows baseline |
| `ephemeral-laboratories/ComposeVR` | Not studied deeply | Prototype of rendering Jetpack Compose into an OpenVR overlay, useful mainly if a future pass needs `Compose-style UI -> overlay texture` |

### Consolidation note

This family should feed `VR-apps-lab` as a methods donor layer:

- overlay lifecycle references
- graphics-path references
- UI stack references
- host-scene and render-loop scaffolds
- overlay patch helpers
- engine-side overlay extension hooks
- engine-native projection-overlay extensions
- UI-to-texture bridges with explicit event forwarding

## Family 15: SteamVR environment helpers and runtime hygiene tools

These utilities improve the way SteamVR behaves around startup, dashboard
interaction, distortion, or overlay-heavy workflows.

| Project | Status | Notes |
|---|---|---|
| `MuffinTastic/steamvr-exconfig` | Already studied | Backup-safe config patcher for disabling autolaunch apps and always-active drivers before startup |
| `BnuuySolutions/OculusKiller` | Already studied | Vendor-shell replacement that redirects Oculus launch flow into SteamVR |
| `username223/SteamVRNoHeadset` | Already studied | Null-driver and no-HMD recipe for SteamVR workflows |
| `n1ckfg/ViveTrackerExample` | Already studied | Tracker-without-HMD workflow and tiny Unity helper |
| `craftyinsomniac/WFOVFix` | Already studied | Guided SteamVR settings patcher for wide-FOV headsets |
| `BnuuySolutions/SteamVRLinuxFixes` | Already studied | Vulkan-layer and compositor-fix utility for Linux SteamVR |
| `simonowen/dashfix` | Already studied | Dashboard-input fix via SDL hook injection |
| `W-Drew/SteamVR-Toggle` | Already studied | Tray utility that toggles SteamVR by renaming install path |
| `sencercoltu/steamvr-undistort` | Already studied | Lens distortion adjustment tool for custom optics |
| `elvissteinjr/SteamVR-VoidScene` | Already studied | Minimal scene app to lower baseline cost for overlay use |
| `shieldmeidunn/SteamVRNullFlipper` | Already studied | Tiny backup-aware helper for flipping SteamVR into null-driver mode |
| `Virus-vr/SteamVRAdaptiveBrightness` | Already studied | Mirror-texture feedback daemon that continuously rewrites SteamVR brightness |
| `username223/SteamVR-ActionsManifestValidator` | Already studied | CI-friendly manifest linter with explicit warning gates and duplicate-key rejection |
| `Erimelowo/Lighthouse-Scale-Fix` | Already studied | Backup-safe one-shot patcher for lighthouse scale configuration |
| `DavidRisch/steamvr_utils` | Already studied | Linux helper collection with a SteamVR lifecycle daemon, base-station power control, and audio switching |

### Consolidation note

This family points toward a separate `environment helper` track inside
`VR-apps-lab`, not just overlays:

- tray toggles
- dashboard fixes
- scene-host helpers
- compositor and distortion helpers
- headsetless/null-driver helpers
- vendor-shell redirects and focused config patchers
- validation and lint micro-tools
- backup-safe config patchers

## Family 17: Calibration, motion compensation, and tracking alignment

These projects are unified by one practical problem: helping the user keep
different tracking spaces, poses, or sensors aligned enough to remain usable.

| Project | Status | Notes |
|---|---|---|
| `pushrax/OpenVR-SpaceCalibrator` | Already studied | Foundational mixed-space calibration reference |
| `Stavdel/OpenVR-SpaceCalibrator` | Already studied | Fork line preserved mainly for historical comparison |
| `Marshall-vak/OpenVR-SpaceCalibrator2` | Already studied | Continuous-calibration extension of the SpaceCalibrator idea |
| `BuzzteeBear/OpenXR-MotionCompensation` | Already studied | OpenXR-side motion compensation and calibration flow |
| `openvrmc/OpenVR-MotionCompensation` | Already studied | Driver-side pose rewrite plus dashboard configuration path |
| `RedHawk989/EyeTrackVR-OpenVR-Calibration-Overlay` | Already studied | Minimal overlay-first 9-point eye-tracking calibration surface |
| `alexander-clarke/openvr-room-mapping` | Already studied | Spatial capture and reconstruction path that overlaps with alignment and room-space research |
| `tobexeon/PSVR2EyeTrackingCalibration` | Not studied deeply | Real-time PSVR2 eye-calibration client that currently depends on a custom toolkit fork |

### Consolidation note

This family matters because the best tracking helper is often not a new sensor
or a new driver, but a better `alignment UX`:

- guided point sequences
- overlay-first feedback
- persistent offsets
- continuous correction
- pose-rewrite layers and drivers
- capture-driven alignment artifacts

## Family 16: Vision-based tracking, hand-input bridges, and headsetless camera runtimes

This family covers repositories that use cameras, computer vision,
hand-tracking services, or foreign runtimes to generate SteamVR devices or
OpenXR substitute inputs without relying on classic lighthouse-tracked
controller stacks.

| Project | Status | Notes |
|---|---|---|
| `ultraleap/driver_ultraleap` | Already studied | Mature hardware-service to SteamVR hand-driver path with optional elbow trackers and a `DebugRequest` external-input hook |
| `Nordskog/HandOfLesser` | Already studied | Quest/OpenXR hand-tracking bridge into SteamVR and VRChat with structured packets plus named-pipe and UDP transport |
| `NovaAshwolfDev/HandCameraDriver` | Already studied | Archived webcam-hand-tracking WIP with a Python-sidecar plus custom SteamVR driver split |
| `KinectToVR/KinectToVR` | Already studied | Legacy multi-process Kinect and PSMove full-body stack with heavy calibration and tracker-orientation math |
| `KinectToVR/Amethyst` | Already studied | Plugin-based body-tracking host with device plugins and service-endpoint contracts |
| `ju1ce/Mediapipe-VR-Fullbody-Tracking` | Already studied | Single-camera body tracking with switchable SteamVR-driver and VRChat OSC backends plus Quest-friendly WebUI |
| `Wunder-Wulfe/NVIDIA-BodyTracking` | Already studied | GPU-assisted camera body-tracking driver with overlay-assisted alignment and dense tracker-role configuration |
| `chnoblouch/aethervr` | Already studied | Webcam-driven custom OpenXR runtime with a Python tracker connected over local TCP |
| `MasonSakai/VR-AI-Full-Body-Tracking` | Not studied deeply | Camera FBT comparison node still partly anchored in an InputEmulator-era transition |

### Consolidation note

This family shows that `vision-driven XR utility design` is now large enough to
split into several repeatable sub-branches:

- `service-backed hand drivers`
- `camera CV sidecars with SteamVR or OSC backends`
- `legacy tracker apps evolving into plugin platforms`
- `headsetless camera runtimes`

The strongest future product concepts suggested by this family are:

- `vision tracking sandbox`
- `driver/backend-agnostic tracking bridge`
- `headsetless camera QA runtime`

## Family 18: Text entry, tracked keyboards, and non-native input surfaces

This family covers the UI surfaces that let a VR utility collect text or short
commands without bouncing the user back to a desktop monitor.

| Project | Status | Notes |
|---|---|---|
| `campfireunion/VRKeys` | Already studied | Focused drum-style keyboard with validation-aware lifecycle, layout switching, and hand-attached mallets |
| `ultraleap/XR-Keyboard` | Already studied | Physical keyboard generator with prefab, manager, and keymap split |
| `oculus-samples/Unity-TrackedKeyboard` | Already studied | Tracked hardware keyboard sample with hand-proximity reveal and MR desk context |
| `Ayfel/MRTK-Keyboard` | Already studied | Semantic non-native keyboard with multiple layout modes and host-facing callbacks |
| `RTUITLab/Oculus-HandTracking-Keyboard` | Already studied | Lightweight fingertip-driven hand-tracking keyboard experiment |

### Consolidation note

This family matters because `text entry` is one of the fastest ways a VR tool
falls back to a desktop if the UX is not handled deliberately.

It suggests a separate donor branch inside `VR-apps-lab`:

- setup and configuration keyboards
- overlay-side text entry
- mixed-reality desk-aware typing
- semantic non-native keyboard components

## Family 19: Hand, palm, radial, and quick-access menus

This family covers the fast-launch and quick-selection surfaces that make VR
tools feel usable without a large persistent desktop metaphor.

| Project | Status | Notes |
|---|---|---|
| `NovaUI-Unity/XRHandMenuSample` | Already studied | Palm-up launcher that opens richer panels at a detached popup anchor |
| `Housz/VRMenuDesigner` | Already studied | Menu-archetype toolkit spanning default, radial, ring, and editor-side modifiers |
| `Oyshoboy/RadialMenuVR` | Already studied | Minimal radial-selection donor with hover scaling and auto-hide |
| `yusufalibrahim1994/UnityXR-Physicalized-Radial-Menu` | Already studied | Radial selection that resolves into real interactables in the hand |
| `auroreRakoto/XR-UI-Prototype` | Already studied | Small menu-list to contextual secondary-panel comparison node |

### Consolidation note

This family points toward a strong `quick-access shell` branch inside
`VR-apps-lab`:

- palm launchers
- radial selectors
- contextual detail panels
- menu archetypes that can be reused across utilities

## Family 20: Spatial UI interaction frameworks and input stacks

This family is less about one finished menu and more about the lower-level
plumbing that makes ordinary UI surfaces usable in XR.

| Project | Status | Notes |
|---|---|---|
| `Unity-Technologies/XR-Interaction-Toolkit-Examples` | Already studied | Broad baseline for spatial keyboard, 2D UI, 3D UI, gaze, and toolkit-scale interaction samples |
| `microsoft/MixedRealityToolkit-Unity` | Already studied | Legacy but still strong solver-driven hand-menu and prefab-UI donor |
| `MixedRealityToolkit/MixedRealityToolkit-Unity` | Partially studied | Current-generation MRTK continuation; Wave 113 covered package split, stateful interactables, pressable buttons, object manipulation, and solver handlers |
| `ViveSoftware/ViveInputUtility-Unity` | Already studied | VR-aware 3D pointer and custom EventSystem input-module donor |
| `Unity-Technologies/mr-example-meta-openxr` | Already studied | Modern Meta/OpenXR sample stack for hand-menu, gesture, and spatial-panel flows |

### Consolidation note

This family matters because many future `VR-apps-lab` tools will not need a new
menu idea as much as they will need a clean `input and UI substrate`.

It strengthens a framework-donor layer around:

- UI EventSystem adaptation
- ray, poke, and hand-input routing
- palm and gesture gating
- toolkit-side keyboard and panel scaffolds

## Family 21: Teleoperation workspaces and embodied control surfaces

This family covers VR applications that behave like control rooms, operator
stations, or embodied dashboards for external systems.

| Project | Status | Notes |
|---|---|---|
| `leggedrobotics/unity_ros_teleoperation` | Already studied | Palm-menu teleoperation shell with ROS-state surfaces and subsystem toggles |
| `h2r/ros_reality` | Already studied | Semantic action-menu reference over a websocket bridge |
| `elpis-lab/UR10_Teleop` | Already studied | Thin controller-pose exporter to an external robot-control process |
| `pollen-robotics/ReachyTeleoperation` | Already studied | Strong staged teleoperation product with connection, mirror, and live-control rooms |
| `nakama-lab/VR_Teleop_Interface` | Not studied deeply | Architectural comparison node for broader teleoperation interface decomposition |
| `h2r/GHOST` | Not studied deeply | Adjacent visualization and gesture-control node worth later comparison |

### Consolidation note

This family matters because it shows a wider product branch than ordinary
utility overlays:

- VR control-room shells
- side-panel and palm-menu command surfaces
- staged setup-to-operation room flows
- thin VR frontends that hand control to an external process

## Family 22: Social overlays, communication sidecars, and companion surfaces

This family covers repositories where the core value is not a generic dashboard
but an ongoing social, speech, or communication workflow that can feed VR
through overlays, `OSC`, `WebSocket`, or desktop companion surfaces.

| Project | Status | Notes |
|---|---|---|
| `designeerlabs/discord-vr` | Already studied | Browser-automation sidecar that turns Discord voice presence into a prefab-driven OpenVR overlay |
| `kittynXR/VRCattoChatto` | Already studied | Desktop-native chat companion with Twitch plus OSC outputs and persisted broadcaster/auth state |
| `Wolf-G88/vrchat-proximity-app` | Already studied | Service-first proximity sidecar with OSC transport and optional SteamVR overlay controls |
| `Sharrnah/whispering` | Partially studied | Broad local speech platform whose VR value comes from OSC and websocket fan-out rather than a single overlay |
| `Hotrian/OpenVRTwitchChat` | Already studied | Twitch-chat overlay reference with a stronger in-headset presentation bias |
| `MeroFune/GOpy` | Not studied deeply | Smaller integration-helper comparison node that may still add another desktop-to-VR communication angle |
| `I5UCC/VRCTextboxSTT` | Already studied | Local speech-to-text helper where the SteamVR overlay is one output surface among others |
| `gt0777/VRCLiveCaptionsMod` | Already studied | App-internal speech surface comparison node from the accessibility and social boundary |
| `rrazgriz/VRCMicOverlay` | Already studied | Minimal status-overlay node for avatar-facing communication state |
| `Larsundso/SteamVR-Discord-Overlay` | Already studied | Rich Discord-local-IPC overlay with message subscriptions, button overlays, and a localhost control dashboard |
| `Artemol/DiscOverlay` | Already studied | Thin Unity shell around the Discord Streamkit voice widget with an in-VR positioning dashboard |
| `imagitama/steamvr-overlay-vrbuddy` | Already studied | Remote companion visualization overlay that renders another person's head and hands in your local playspace |
| `beareogaming/BD-XSOverlay-notify` | Not studied deeply | BetterDiscord plugin that treats an existing external overlay host as the render target for notifications |

### Consolidation note

This family matters because it shows that `communication tooling` is its own VR
utility branch, not just an accessibility afterthought:

- social-presence overlays
- desktop-native chat companions
- service-first speech utilities
- VRChat-facing sidecars with optional overlay control surfaces
- Discord-local-IPC overlays with companion dashboards
- companion-visualization overlays for other people or remote collaborators

## Family 23: Alternative OpenXR runtimes, special-display paths, and platform experiments

This family covers runtime implementations that target nontraditional hardware,
embedded platform contexts, or proof-of-concept runtime architectures rather
than ordinary HMD-first desktop setups.

| Project | Status | Notes |
|---|---|---|
| `DisplayXR/displayxr-runtime` | Already studied | Clean layered runtime architecture for spatial displays and 3D monitors |
| `JoeyAnthony/XRGameBridge` | Already studied | Focused runtime wrapper for UEVR-style game flows on special displays |
| `warrenm/OpenXRKit` | Already studied | Embedded Apple-platform OpenXR runtime framework with platform-specific system implementations |
| `rinsuki/FruitXR` | Already studied | Local IPC and runtime-server proof-of-concept for macOS |
| `maximum-game-22/openxr-3d-display` | Not studied deeply | Monado-derived spatial-display comparison node |
| `Kartaverse/OpenDisplayXR` | Not studied deeply | Project cluster around OpenXR paths for nonstandard displays |
| `chnoblouch/aethervr` | Already studied | Webcam-driven custom OpenXR runtime that reinforces the broader nonstandard-runtime branch |

### Consolidation note

This family matters because it expands `runtime research` beyond switchers and
layers into `runtime ownership for nontraditional targets`:

- special-display runtimes
- embedded platform runtimes
- local IPC runtime experiments
- custom runtimes that are better understood as architecture donors than as products

## Family 24: Tracked-device geometry, CAD, and auxiliary tracker tooling

This family covers the point where tracked-device design becomes an explicit
engineering workflow rather than only a pose-ingestion problem.

| Project | Status | Notes |
|---|---|---|
| `fughilli/ViveTrackedDevice` | Partially studied | Documentation-first reverse-engineering donor for Lighthouse-tracked device internals |
| `TriadSemi/Fusion360_SteamVR_Json` | Already studied | CAD-authored path from construction geometry to SteamVR tracking JSON |
| `aughip/augmented-hip` | Already studied | Derived waist-tracker driver built from existing tracked body nodes |
| `m9cd0n9ld/IMU-VR-Full-Body-Tracker` | Already studied | Full-stack DIY tracker ecosystem spanning firmware, desktop tooling, and driver registration |
| `ebadier/ViveTrackers` | Not studied deeply | Unity-side consumer node for Vive tracker hardware data |
| `choyai/SteamVRTrackerUtility` | Already studied | Narrow tracker-identity and serial helper for deterministic role workflows |
| `jangxx/UniversalTrackerMarkers` | Already studied | Marker and identity helper that reinforces the auxiliary tracker-tooling side of the family |

### Consolidation note

This family matters because `tracked-device work` is not only about network
bridges:

- reverse-engineered device geometry
- CAD authoring for sensor definitions
- derived or synthetic role devices
- auxiliary tracker identity and hardware workflows

## Family 25: Expressive tracking, face and eye input, and avatar-facing bridges

This family covers the branches where the input is not only a body pose but a
more expressive face, eye, hand, or avatar-facing signal that must be adapted
into SteamVR, OpenXR, or avatar-consumer surfaces.

| Project | Status | Notes |
|---|---|---|
| `Project-Babble/Baballonia` | Already studied | Cross-platform expressive-tracking host with overlay-assisted calibration and modular capture sources |
| `jcorvinus/HandshakeVR` | Already studied | Hand-provider remapping layer that normalizes incompatible input models |
| `moshimeow/mercury_steamvr_driver` | Already studied | SteamVR hand-driver path built around an out-of-process tracking source |
| `BattleAxeVR/PSVR2_OpenXR_Eye_Tracking` | Already studied | Vendor-specific gaze source translated into standard OpenXR layer surfaces |
| `Nordskog/HandOfLesser` | Already studied | Quest or OpenXR hand-tracking bridge into SteamVR and avatar-facing consumers |
| `mbucchia/OpenXR-Eye-Trackers` | Already studied | OpenXR-side gaze and eye-tracking adaptation donor |
| `pembem22/etvr-openxr-layer` | Already studied | OSC eye-tracking to OpenXR gaze adaptation path |
| `ThatGuyThimo/leapmotion-osc` | Not studied deeply | Finger-only avatar-facing OSC output comparison node |
| `takana-v/quest_steamvr_fbt_tool` | Not studied deeply | Quest-derived body state and avatar-facing export follow-up node |

### Consolidation note

This family matters because it pulls together several adaptation layers that
would otherwise look unrelated:

- overlay-assisted expressive calibration
- hand-provider remapping
- driver plus subprocess expressive input
- vendor-specific gaze adaptation into standard XR surfaces
- avatar-facing exports built on top of those richer inputs

## Family 26: VRChat chatbox, STT, and text-surface sidecars

This family covers utilities whose core job is to get text into VRChat through
chatbox output, avatar parameter surfaces, or compact desktop-side text tools.

| Project | Status | Notes |
|---|---|---|
| `BoiHanny/vrcosc-magicchatbox` | Already studied | Broad modular chatbox composer that squeezes many live status modules into one bounded text surface |
| `ScrapW/Chatbox` | Already studied | Android relay with floating overlay entry surface and configurable local or remote chatbox targets |
| `misyaguziya/VRCT` | Already studied | Tauri and Python translation shell with overlay output, Whisper management, and OSCQuery-aware VRChat delivery |
| `killfrenzy96/KillFrenzyAvatarText` | Already studied | Unity-side installer for avatar text surfaces built around pointer-indexed parameter grids |
| `dbqt/VRCOSCChatbox` | Already studied | Tiny buffered WPF chatbox sender with explicit rate-limited background queue |
| `yum-food/TaSTT` | Already studied | STT-to-avatar text surface built around generated parameter grids and animator assets |
| `cyberkitsune/vrc-osc-scripts` | Already studied | Small Python donors for rate-limited chatbox updates and narrow status helpers |
| `nyakowint/xsoverlay-keyboard-osc` | Already studied | Harmony patch that reuses an existing overlay keyboard as VRChat chat input |
| `I5UCC/VRCTextboxOSC` | Already studied | Thin textbox utility with focus hotkey, overflow trimming, and always-on-top behavior |
| `Lioncat6/OSC-Chat-Tools` | Already studied | Product-rich monolithic status composer for chatbox-centered utility workflows |
| `I5UCC/VRCTextboxSTT` | Already studied | Thin STT overlap node that keeps speech-to-text inside a focused textbox utility |

### Consolidation note

This family matters because `text workflows` in social VR are broader than one
caption or subtitle app:

- character-budgeted status composition
- mobile relay surfaces
- translation and transcription shells over local models and overlays
- avatar text surfaces driven by parameter grids
- patched overlay keyboards for in-VR text entry
- thin textbox or STT micro-utilities
- micro-script donors for one narrow text output

It suggests a stronger product branch inside `VR-apps-lab` around:

- chatbox-sidecar composition
- relay-first handheld chat tools
- translation and transcription shells for social VR
- speech-to-avatar text surfaces
- text-entry helpers for overlay-first workflows

## Family 27: Avatar-facing OSC companions, routers, and consumer automation sidecars

This family covers tools where avatar parameters, headset telemetry, or
VRChat-facing `OSC` become a desktop-service bus for routing, automation, or
consumer actions.

| Project | Status | Notes |
|---|---|---|
| `OscToys/OscGoesBrrr` | Already studied | Broad Electron companion with typed IPC, diagnostics pages, and OSCQuery-aware services |
| `valuef/VRCRouter` | Already studied | Config-driven OSC router with route presets, sidecar launch, and cleanup handling |
| `Sergey004/Quest2-VRC` | Already studied | Plugin-based Quest telemetry host that fans device state into OSC and side integrations |
| `I5UCC/VRCMeeter` | Already studied | Focused avatar-parameter bridge into Voicemeeter actions and profiles |
| `I5UCC/VRCAvatarParameterSync` | Already studied | Snapshot and replay helper for selected avatar parameters across avatar changes |
| `ZenithVal/OSCLeash` | Already studied | Config-driven avatar or physbone sidecar that turns state into control behavior |
| `ZenithVal/OSCLock` | Already studied | Avatar-driven timer and Bluetooth-actuator workflow with a clear desktop safety surface |
| `lenoobkinda/VRCOSCUtils` | Partially studied | Broader comparison node for mixed VRChat OSC helpers that is weaker than the mainline donors above |
| `vrchat-community/vrc-oscquery-lib` | Already studied | Reusable OSCQuery discovery library and example set for chatbox, tracker, and monitor clients |
| `Krekun/vrchat-mcp-osc` | Already studied | Relay-based automation bridge that exposes VRChat OSC to higher-level MCP tools |
| `regzo2/OSCmooth` | Already studied | Unity-side smoothing and proxy-parameter generator for noisy OSC-driven avatar inputs |

### Consolidation note

This family matters because it turns `avatar-facing OSC` into a broader product
branch than simple parameter export:

- focused routers and sidecar launchers
- diagnostics-rich desktop companion shells
- reusable OSCQuery discovery and auto-connect libraries
- plugin-based telemetry hosts
- AI or automation relays over safer transport boundaries
- avatar parameter bridges into desktop services
- parameter continuity helpers across avatar changes
- consumer automation flows and consumer-side smoothing layers

It suggests a stronger branch inside `VR-apps-lab` around:

- OSC-aware desktop companion shells
- OSCQuery-first discovery helpers
- AI and automation relays into avatar-facing surfaces
- avatar-state automation tools
- headset telemetry hosts with modular consumers

## Family 28: XR-glasses virtual displays, workspace shells, and spatial screen utilities

This family covers repositories that treat special displays, XR glasses, or
head-tracked screens as their main target instead of a conventional VR headset
dashboard.

| Project | Status | Notes |
|---|---|---|
| `wheaney/XRLinuxDriver` | Already studied | Base Linux XR-glasses driver with device backends and feature hooks |
| `wheaney/breezy-desktop` | Already studied | Broad workspace shell over the glasses driver with desktop-environment and Vulkan-mode split |
| `wheaney/decky-XRGaming` | Already studied | SteamOS/Game Mode wrapper over the Breezy and XR driver stack |
| `MolotovCherry/virtual-display-rs` | Already studied | User-session virtual-display service stack with named-pipe IPC and control layers |
| `mgschwan/viture_virtual_display` | Already studied | Capture-to-head-tracked screen utility built around Viture IMU data |
| `lc700x/desktop2stereo` | Already studied | AI depth pipeline that turns ordinary desktop or video content into a stereoscopic screen workflow |
| `wheaney/OpenVR-xrealAirGlassesHMD` | Already studied | Thin OpenVR HMD path that adapts XREAL IMU data into a runtime-facing headset device |
| `iVideoGameBoss/PhoenixHeadTracker` | Already studied | Head-tracking sidecar that exports glasses orientation into opentrack-style or mouse-look consumers |
| `peacepenguin/Virtual-Display-Driver` | Already studied | Generic Windows virtual-display comparison node without glasses-specific shell logic |

### Consolidation note

This family matters because `special-display workflows` now look like a real
product branch rather than a pile of isolated driver experiments:

- base hardware drivers for XR glasses
- workspace shells layered on top
- Game Mode or platform-native wrappers
- user-session virtual-display services
- head-tracked screen utilities
- thin runtime-facing HMD paths
- screen-transformation pipelines

It suggests a stronger branch inside `VR-apps-lab` around:

- XR-glasses workspace shells
- runtime-facing glasses device paths
- managed virtual-display service tooling
- spatial screen helpers outside ordinary headset runtime flows

## Family 29: Wearable haptics, tactile bridges, and avatar-driven feedback systems

This family covers software and hardware stacks where avatar events, `OSC`, or
other social-VR signals become tactile output on wearables or repurposed
consumer hardware.

| Project | Status | Notes |
|---|---|---|
| `OpenShock/ShockOSC` | Already studied | Configurable wearable-haptics router with grouped outputs, debug surfaces, and change-tracked OSC values |
| `bhaptics/VRChatOSC` | Already studied | Unity-side avatar setup tooling for bHaptics-driven VRChat wearables |
| `senseshift/senseshift-firmware` | Already studied | Firmware donor for a modular DIY tactile wearable platform |
| `senseshift/senseshift-hardware` | Already studied | Hardware-reference donor paired with the SenseShift firmware ecosystem |
| `Z4urce/VRC-Haptic-Pancake` | Already studied | Multi-transport bridge from VRChat or Resonite into haptic-style outputs |
| `lebaston100/vrc-patpatpat` | Already studied | Sparse contact solver that expands limited avatar receivers into richer actuator placement |
| `shadorki/vrc-owo-suit` | Already studied | Narrow OWO suit bridge with clear avatar contact authoring and intensity grouping |
| `Python1320/vrcjoycon` | Already studied | Consumer-device bridge that repurposes Joy-Con rumble for avatar-facing tactile output |

### Consolidation note

This family matters because `wearable haptics` now has enough donor surface to
split into clear layers:

- avatar authoring and editor tooling
- desktop bridge apps and hardware groups
- sparse-contact solver logic
- firmware and hardware reference stacks
- narrow hardware-specific or consumer-device bridges

It suggests a stronger branch inside `VR-apps-lab` around:

- avatar-driven haptics routers
- tactile solver experiments
- DIY wearable platform references

This family is now distinct from the newer
`biometric, neurofeedback, and accessory-control bridges`
branch, which focuses on measurements, host shells, and safety-aware accessory
platforms rather than tactile output specifically.

## Family 30: Playspace editors, boundary importers, and shared-space helpers

This family covers repositories where the main value is not generic
`recentering`, but explicit ownership of room boundaries, playspace transforms,
or shared physical-space awareness.

| Project | Status | Notes |
|---|---|---|
| `Xavr0k/ChaperoneTweak` | Already studied | In-headset SteamVR chaperone editor with controller hit-zones for wall and playspace edits |
| `FrostyCoolSlug/xr-chaperone` | Already studied | Desktop setup wizard plus headless OpenXR room-boundary service with polygon-distance fading |
| `Sgeo/Guardian2Chaperone` | Already studied | Vendor-boundary import utility from Oculus Guardian into SteamVR chaperone |
| `hai-vr/unity-chaperone-tweaker` | Already studied | Unity-editor workflow over raw `.vrchap` universes and boundary points |
| `Rafacasari/Playspace-Mover` | Already studied | Runtime local playspace offset mover driven by controller deltas inside an existing VR app |
| `mdovgialo/OpenVRSharedPlayspace` | Already studied | LAN peer-visibility helper that shows shared-room companions as distance-faded overlays |
| `LIV/RotatoExpress` | Already studied | Live playspace transform rotator with explicit restore-on-exit behavior |

### Consolidation note

This family matters because `room-space tooling` is broader than calibration:

- live in-headset boundary editors
- desktop setup plus service-mode boundary tools
- vendor-boundary import utilities
- runtime local playspace movers
- shared-room peer overlays

## Family 31: Redirected-walking toolkits, locomotion adaptation, and space-redirection research

This family covers repositories that explicitly study, simulate, or implement
ways of adapting user motion to limited physical space.

| Project | Status | Notes |
|---|---|---|
| `USC-ICT-MxR/RDWT` | Already studied | Foundational redirected-walking toolkit with pluggable redirectors, resetters, and simulation manager |
| `yaoling1997/OpenRDW` | Already studied | Expanded redirected-walking research platform with richer configuration, algorithms, and multi-avatar ownership |
| `omegafantasy/OpenRDW2` | Already studied | Multi-user online redirected-walking platform with networking, separate-space logic, and batch experiment generation |
| `ElectricNightOwl/ArmSwinger` | Already studied | Comfort-heavy locomotion module with smoothing, prevention, rewind, and pushback layers |
| `Knerten0815/VR_Dodge_Study` | Fork / variant only | Thesis-oriented OpenRDW variation focused on dodging and reset research rather than a new mainline platform |

### Consolidation note

This family matters because it separates two related but different answers to
`small-room movement`:

- research-grade redirected-walking platforms
- user-facing locomotion modules with safety or comfort stacks

## Family 32: XR latency measurement, recording parsers, and experiment harnesses

This family covers tools that explicitly measure XR latency, encode signals for
later video alignment, or parse and analyze rich simulator recordings.

| Project | Status | Notes |
|---|---|---|
| `immersivecognition/motion-to-photon-measurement` | Already studied | Unity motion-to-photon harness with combined scene coding and tracked output |
| `vr-thi/VRLate` | Already studied | External hardware latency rig with GPS synchronization, serial capture, and brightness encoding |
| `Greendayle/VR-Motion-to-photon-latency-` | Partially studied | VRChat-world and smartphone slow-motion methodology for low-cost latency checks |
| `HARPLab/dreyevr_recording_analyzer` | Already studied | Parser-plus-notebook stack for rich DReyeVR replay analysis |
| `HARPLab/DReyeVR-parser` | Already studied | Thin standalone parser and cache layer for DReyeVR recordings |
| `ratcave/vrlatency` | Already studied | Scriptable Python latency lab with display, tracking, and total-latency experiment classes |

### Consolidation note

This family matters because `XR measurement tooling` is now broader than
generic metrics:

- engine-side visual coding for later alignment
- external hardware latency rigs
- consumer-grade latency methodologies
- replay parsers and notebook analyzers
- reusable experiment-lab frameworks

## Family 33: Simulation telemetry overlays, motion-cueing bridges, and sim-sidecar platforms

This family covers repositories where simulator telemetry becomes the backbone
for overlays, force-feedback sidecars, motion-platform tooling, or broader VR
simulator platforms.

| Project | Status | Notes |
|---|---|---|
| `TinyPedal/TinyPedal` | Already studied | Modular telemetry overlay host with adapters, widget lifecycle control, and preset-aware behavior |
| `walmis/VPforce-TelemFFB` | Already studied | Multi-instance telemetry sidecar that maps simulator state into force-feedback device roles |
| `PHARTGAMES/SpaceMonkey` | Already studied | Telemetry normalization bridge that translates unsupported games into common outputs |
| `SimFeedback/SimFeedback-AC-Servo` | Already studied | Motion-platform ecosystem with telemetry providers and extension facade boundaries |
| `HARPLab/DReyeVR` | Already studied | VR simulator platform with ego sensor, replay pipeline, and research-oriented data streaming |
| `giuseppdimaria/Unity-VRlines` | Partially studied | XR flight-simulator prototype with modular aircraft physics and VR controller mappings |

### Consolidation note

This family matters because mature simulator tooling reinforces several
construction patterns that also matter for `VR-apps-lab`:

- desktop plus overlay host splits
- telemetry-to-device sidecars
- output normalization bridges
- simulator platforms with replay and analytics

## Family 34: Biometric, neurofeedback, and accessory-control bridges

This family covers repositories where biometric measurements, richer biosignal
trees, or avatar-facing `OSC` become the control plane for monitoring,
accessory behavior, or safety-aware sidecar platforms.

| Project | Status | Notes |
|---|---|---|
| `Honzackcz/PulsoidToOSC` | Already studied | Thin biometric bridge with OSCQuery-aware discovery, chatbox templating, and multi-client fan-out |
| `nullstalgia/iron-heart` | Already studied | Rich Rust companion shell with BLE or WebSocket inputs, charts, logs, and many output sinks |
| `vard88508/vrc-osc-miband-hrm` | Already studied | Minimal browser-plus-node wearable bridge with multiple parameter encodings |
| `DASPRiD/vrc-osc-manager` | Already studied | Plugin-oriented avatar-facing accessory manager with persisted settings and OSCQuery services |
| `nullstalgia/OpenShock-ESP-Legacy` | Already studied | Embedded ESP32 accessory-control firmware with OSC, browser config, and emergency-stop surfaces |
| `ChilloutCharles/BrainFlowsIntoVRChat` | Already studied | Biosignal pipeline that preserves a nested parameter tree before flattening it into VRChat OSC paths |

### Consolidation note

This family matters because it makes a previously diffuse branch explicit:

- thin wearable or heart-rate bridges
- richer operator-facing biometrics shells
- browser-plus-local wearable relays
- plugin-oriented accessory hosts
- embedded safety-aware controllers
- neurofeedback or biosignal exporters

It suggests a stronger branch inside `VR-apps-lab` around:

- biometric sidecars for avatar-facing consumers
- accessory-control hosts with plugin boundaries
- embedded controller research with explicit safety surfaces
- richer biosignal schemas instead of flat parameter bags

## Family 35: Browser-backed overlay runtimes, web-tech hosts, and UI runtime experiments

This family covers repositories where the interesting overlay boundary lives in
the runtime split itself: native host, browser or web-facing app layer,
offscreen UI renderer, or other declarative runtime that becomes the overlay
surface.

| Project | Status | Notes |
|---|---|---|
| `mekanoe/ovrsalt` | Already studied | Scrapped but unusually clear backend, runtime, and frontend split over shared buffers and process launch |
| `mekanoe/electron-openvr` | Already studied | Minimal offscreen `Electron` window mirrored directly into an `OpenVR` texture |
| `joshperry/ovrly` | Already studied | `CEF` overlay host with per-app daemons, local `HTTP`, and in-page native API hooks |
| `ephemeral-laboratories/ComposeVR` | Already studied | `Compose Multiplatform` experiment that renders declarative UI into a tracked `OpenVR` overlay |

### Consolidation note

This family matters because `browser-backed overlays` are no longer one vague
idea. They now split into distinct construction patterns:

- native backend plus browser runtime
- offscreen browser-window mirroring
- browser host plus daemonized app model
- non-browser declarative UI runtime experiments

It suggests a stronger branch inside `VR-apps-lab` around:

- overlay hosts that behave like local runtime platforms
- desktop-first UI runtimes that mirror into VR
- explicit `HTTP` or `IPC` contracts between overlay shell and app logic

## Family 36: Linux overlay control shells, desktop-service panels, and interaction variants

This family covers repositories where Linux desktop or service workflows are
the main value, and where controller interaction plus desktop-side debug modes
matter as much as the visible VR panel.

| Project | Status | Notes |
|---|---|---|
| `galister/OVR4X11` | Already studied | Linux screen-control shell with `X11` capture, controller pointer logic, and on-overlay keyboard helpers |
| `DrogonMar/SVRLinuxTools` | Already studied | `Qt` or KDE-style overlay shell hosting multiple desktop-service panels with a useful `--novr` mode |
| `Dragon092/OpenVR_Audio_Manager` | Already studied | Focused `Qt` dashboard for HMD-aware audio routing and persisted device preferences |
| `CrispyPin/sinpin-vr` | Not studied deeply | GitHub relocation stub that points to a moved Linux overlay project rather than exposing a useful code donor on GitHub today |

### Consolidation note

This family matters because `Linux overlay shells` expose several lessons that
are easy to miss in Windows-heavy donor pools:

- desktop capture plus controller-mouse interaction
- service-panel hosts rather than one fixed tool
- narrow device-manager overlays with explicit preference state
- non-VR debug paths as a maintainability feature

It suggests a stronger branch inside `VR-apps-lab` around:

- Linux-side desktop-control overlays
- service-panel shells with desktop fallback
- stateful routing or inventory dashboards

## Family 37: Micro-overlays, timed status surfaces, and plugin-fed informational display helpers

This family covers repositories where the main value comes from one small
overlay with one strong job: comfort control, timer state, informational feed,
or a note surface rather than a broad dashboard host.

| Project | Status | Notes |
|---|---|---|
| `R-VUt/OVRBrightnessAPI` | Already studied | Tiny comfort overlay exposed through local `HTTP` and `OSC` control planes |
| `CorvinRyder/VR-Slideshow-Overlay` | Already studied | Provider-fed informational surface with multiple outputs including overlay, chatbox, and file |
| `Podshot/VRSessionTimer` | Already studied | Timer overlay that escalates from passive HUD into notifications and restart loops |
| `Yukiiro-Nite/notebook-vr-overlay` | Partially studied | Rough note-surface prototype with explicit overlay event plumbing but incomplete writing workflow |

### Consolidation note

This family matters because it makes `small overlays` much more structured:

- tiny local-control-plane overlays
- provider-fed informational surfaces
- timed reminder or escalation overlays
- rough note or writing lower-bound prototypes

It suggests a stronger branch inside `VR-apps-lab` around:

- automation-friendly micro-overlays
- provider-driven status surfaces
- reminder and intervention overlays
- note or annotation overlays with explicit small state models

## Family 38: Embodied locomotion overlays, live tuning surfaces, and external-device control panels

This family covers repositories where the overlay is not just informational.
It actively shapes movement, live tuning, or control of remote hardware.

| Project | Status | Notes |
|---|---|---|
| `hiinaspace/bikeheadvr` | Already studied | Controllerless locomotion overlay that maps tracker motion and gaze interaction into avatar-facing movement intent |
| `MartyDude20/Omni-Tune` | Already studied | Desktop profile editor mirrored into a live VR tuning surface through a native helper |
| `OpenShock/OVR-Shock` | Already studied | Modern remote-device control overlay with persisted config, API client, and hand-aware interaction |
| `OpenShock/VROverlay` | Partially studied | Older Unity lineage node for the same device-control branch |
| `NewChromantics/PopExposeXr` | Not studied deeply | Thin follow-up node hinting at XR state exposure, but too sparse for mainline promotion |

### Consolidation note

This family matters because it separates several stronger `control-first`
overlay answers from ordinary dashboard surfaces:

- embodied locomotion overlays
- desktop-first editor plus live VR tuning
- remote-device control panels
- lineage comparisons between older and newer overlay hosts

It suggests a stronger branch inside `VR-apps-lab` around:

- embodied-control surfaces
- live tuning overlays for external rigs or movement systems
- in-headset control panels for remote devices and networked accessories

## Family 39: Code-first overlay scaffolds, projection samples, and window-to-texture baselines

This family covers repositories where the main value is not the final product
surface, but the explicit low-level path from pixels, transforms, or desktop
capture into an `OpenVR` overlay.

| Project | Status | Notes |
|---|---|---|
| `stevenjwheeler/OpenGL-VROverlay` | Already studied | Tiny `C` plus rawdraw baseline for controller-attached `OpenVR` texture submission |
| `ChristophHaag/OpenVRWindowOverlay` | Already studied | Linux `X11` window-capture bridge that pushes real app content into an overlay texture |
| `pfgithub/openvr-overlay-test` | Already studied | Zig-language restatement of the small `OpenVR` texture-submit baseline |
| `hiinaspace/openvr-overlay-bunny` | Already studied | Projection-overlay donor with explicit per-eye frusta, transform math, and honest runtime caveats |

### Consolidation note

This family matters because `overlay implementation reference` should not mean
only big frameworks. The strongest donor lines here are:

- tiny `draw -> texture -> overlay` baselines
- direct `desktop or app window -> overlay` capture bridges
- honest projection-overlay worked examples

It suggests a stronger branch inside `VR-apps-lab` around:

- low-level overlay bring-up references
- window-to-texture overlay utilities
- projection-overlay math and transform notes

## Family 40: Managed-language overlay starters, UIToolkit templates, and higher-level scaffolds

This family covers repositories where the interesting lesson is how a
managed-language or Unity overlay keeps lifecycle, texture transport, and UI
events explicit without dropping back to a tiny native baseline.

| Project | Status | Notes |
|---|---|---|
| `someka-vrc/uitoko-ovr` | Already studied | Reusable Unity `UIToolkit` overlay template with explicit `OpenVR` lifecycle and event bridge |
| `AanthonyRusso/BasicOverlay` | Already studied | Focused `C++` overlay whose desktop helper refreshes cover art and text for a small HMD-relative surface |
| `Spacefish/OpenVR-Overlay` | Already studied | Managed-language `OpenVR` host with Vulkan texture interop and controller attachment |
| `Daniel-Webster/WT-OpenVR-Overlay` | Partially studied | Broader Unity overlay app over a local webservice, useful as a higher-level scaffold node |
| `kurohuku7/zenn-overlay-tutorial` | Not studied deeply | Tutorial-first note for Unity or SteamVR overlay learning rather than a mainline code donor |

### Consolidation note

This family matters because `starter overlays` now split more cleanly into:

- reusable Unity UI templates
- desktop-side content feeders for narrow overlays
- managed GPU-interoperable hosts
- broader app-specific scaffolds with local-service dependencies

It suggests a stronger branch inside `VR-apps-lab` around:

- Unity overlay templates with real UI frameworks
- managed-language overlay hosts with explicit texture interop
- higher-level overlay scaffolds that still expose reusable boundaries

## Family 41: Desktop-adjacent companion overlays, phone bridges, and media or text control surfaces

This family covers repositories where the overlay acts as a companion surface
for an external device, desktop workflow, or operator-fed content stream.

| Project | Status | Notes |
|---|---|---|
| `happysmash27/OVR_SLDO` | Already studied | Linux desktop-proxy overlay rooted in shared-memory `X11` capture |
| `Desuuuu/OVRPhoneBridge` | Already studied | Secure phone-companion overlay with encrypted transport, notifications, SMS, and SteamVR keyboard integration |
| `adks3489/ViveOverlayPaster` | Already studied | Tiny operator-driven text overlay that rasterizes desktop-authored content into VR |
| `Wulkop/VolumeVR` | Partially studied | `CEF`-backed narrow media or volume shell whose public repo mainly exposes runtime bootstrap logic |

### Consolidation note

This family matters because `companion overlays` are not just small dashboard
copies. They now include:

- desktop-proxy surfaces
- secure external-device companions
- operator-authored text or notification tools
- browser-based narrow control shells

It suggests a stronger branch inside `VR-apps-lab` around:

- overlays as companions for phone or desktop workflows
- secure bridge-driven overlay shells
- very small operator tools with one clear value

## Family 42: Specialized effect overlays, visibility shaping, and passthrough cutout surfaces

This family covers repositories where the overlay's main job is a visual
effect, comfort intervention, or spatial cutout rather than ordinary UI.

| Project | Status | Notes |
|---|---|---|
| `Alex-J-Lopez/OpenMixerXR` | Already studied | Chroma-key passthrough cutout manager with dashboard editing and controller grab or resize |
| `joaoseabra/SteamVRBlackBarOverlay` | Already studied | Focused HMD-relative top-of-view mask for visibility shaping |
| `tnsgud9/VR-Overlay-Half_Ring` | Already studied | Unity comfort overlay that follows headset roll and exposes simple user controls |
| `RedHawk989/OpenVR-Windows-Activation` | Already studied | Tiny static-image environmental effect overlay |
| `emymin/EmyOverlay` | Not studied deeply | Thin effect-overlay node whose current public donor surface is still too sparse |

### Consolidation note

This family matters because `overlay utilities` should include comfort and
perception tools, not only content panels. The strongest lines here are:

- spatial passthrough cutout management
- field-of-view masking
- orientation-aware comfort overlays
- tiny static-image effect surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- effect-first overlays
- visibility-shaping comfort tools
- passthrough cutout editors and spatial masking surfaces

## Family 43: OpenXR sample apps, rendering baselines, and bring-up references

This family covers repositories where the main value is not a finished product,
but a clear worked answer to `how OpenXR app bring-up is structured`.

| Project | Status | Notes |
|---|---|---|
| `maluoi/OpenXRSamples` | Already studied | Strong one-file `D3D11` bootstrap donor with explicit extension filtering, swapchains, and action spaces |
| `janhsimon/openxr-vulkan-example` | Already studied | Structured sample-app split across context, headset, controllers, mirror view, and renderer |
| `philpax/wgpu-openxr-example` | Already studied | Staged `desktop -> XR` bring-up donor over `OpenXR + Vulkan + wgpu` |
| `terryky/android_openxr_gles` | Already studied | Shared OpenXR utility core reused across several Android feature samples |
| `KHeresy/openxr-simple-example` | Already studied | Compact SDL/OpenGL lower-bound sample for minimal bring-up comparisons |
| `jherico/OpenXR-Samples` | Not studied deeply | Useful historical comparison node, but less compelling than the mainline donors in this pass |

### Consolidation note

This family matters because `OpenXR sample code` is not one generic donor pool.
It now splits into:

- single-file bootstraps
- structured non-engine sample apps
- desktop-first migration paths
- shared-core sample suites
- minimal graphics lower bounds

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR bring-up references
- runtime-facing rendering baselines
- reusable sample-app architecture notes

## Family 44: OpenXR language bindings, generator-backed wrappers, and SDK facades

This family covers repositories where the interesting lesson is how OpenXR is
generated, wrapped, or adapted into another host language while preserving the
runtime-facing API model.

| Project | Status | Notes |
|---|---|---|
| `Ralith/openxrs` | Already studied | Layered `safe + raw` Rust OpenXR stack with real usage examples |
| `cmbruns/pyopenxr` | Already studied | Registry-driven Python bindings with higher-level helpers and optional API-layer tooling |
| `EvergineTeam/OpenXR.NET` | Already studied | `.NET` binding emitter generated from `xr.xml` with explicit native-library resolution |
| `s-ol/openxr-zig` | Already studied | Zig wrapper that integrates OpenXR code generation directly into the build |
| `drypy/openxr.py` | Not studied deeply | Thin comparison node for Python-side OpenXR access rather than the mainline donor here |
| `FireFlyForLife/rlOpenXR` | Not studied deeply | Wrapper experiment that is more app-facing than binding-system-focused |

### Consolidation note

This family matters because `OpenXR bindings` now split more cleanly into:

- layered raw plus ergonomic stacks
- generator-backed scripting facades
- registry-driven managed-language emitters
- build-integrated host-language wrappers

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR binding strategies for future tools
- registry-driven code generation notes
- host-language adaptation patterns for XR APIs

## Family 45: OpenVR language bindings, managed wrappers, and scripting access layers

This family covers repositories where the interesting lesson is how OpenVR is
wrapped into another language or runtime while keeping initialization,
subsystem access, and interface ownership understandable.

| Project | Status | Notes |
|---|---|---|
| `rust-openvr/rust-openvr` | Already studied | Typed OpenVR wrapper with explicit context ownership and subsystem handles |
| `cmbruns/pyopenvr` | Already studied | Generated `ctypes` binding surface with a large scripting-oriented sample set |
| `tbogdala/openvr-go` | Already studied | `cgo` bridge over raw OpenVR interfaces, adapted into Go-friendly wrappers |
| `node-xr/node-openvr` | Already studied | Native Node addon that exposes runtime and system calls into JavaScript |
| `Flutterish/OpenVR.NET` | Already studied | Object-oriented `.NET` facade over runtime, draw, input, update, and manifest operations |
| `java-graphics/openvr` | Not studied deeply | Comparison node for JVM-side access rather than a stronger donor than the shortlisted repos |
| `matinas/openvrsimplexamples` | Not studied deeply | Sample-first comparison node, useful for lineage but thin as a wrapper donor |

### Consolidation note

This family matters because `OpenVR access layers` are no longer one vague
category. They now split into:

- typed wrappers
- scripting-first binding stacks
- bridges into other host runtimes
- broader object-oriented runtime facades

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenVR wrappers for fast experimentation
- managed-language runtime facades
- integration patterns that bridge native VR APIs into other ecosystems

## Family 46: OpenVR tracking export, recording, and robotics bridge tooling

This family covers repositories where the main value is not tracking as an end
user feature, but what happens when SteamVR tracking is exported, replayed, or
consumed by other systems.

| Project | Status | Notes |
|---|---|---|
| `Omnifinity/OpenVR-Tracking-Example` | Already studied | Small lower-bound donor for background tracking collection |
| `sharif1093/openvr_ros` | Already studied | Thin SteamVR-to-ROS pose bridge with separate `tf` rebroadcast helper |
| `personalrobotics/openvr_ros_bridge` | Already studied | Modular export host with multiple publishers, status UI, and transport choices |
| `qeftser/openvr_ros2_tracker` | Already studied | Minimal `ROS2` tracker bridge with parameterized topic and visualization flow |
| `lebek/openvr-input-recorder` | Already studied | Record and replay harness that serializes device metadata and timed samples |
| `RViMLab/vrviz` | Already studied | VR-native consumer of robotics topics such as point clouds, markers, and transforms |
| `zhouhs88/vrpn-openvr` | Not studied deeply | Useful comparison node for `VRPN` export, but thinner than the mainline donors here |

### Consolidation note

This family matters because `tracking export` now splits more cleanly into:

- simple tracking collectors
- thin ROS bridges
- modular multi-publisher export hosts
- record and replay harnesses
- VR-native robotics consumers

It suggests a stronger branch inside `VR-apps-lab` around:

- pluggable tracking-export services
- motion recording and replay harnesses
- robotics-facing XR integration patterns

## Family 47: VMT adapters, OSC action compilers, and skeletal validation utilities

This family covers repositories that orbit `VirtualMotionTracker` and adjacent
OSC exporter lines without all solving the same problem in the same layer.

| Project | Status | Notes |
|---|---|---|
| `gpsnmeajp/VirtualMotionTracker` | Already studied | Mature manager-plus-driver tracker host with OSC transport and skeletal-input support |
| `Greendayle/SteamVR_To_OSC` | Already studied | Thin action-manifest-driven OpenVR utility that exports mapped controller values to OSC |
| `BarakChamo/OpenVR-OSC` | Already studied | Lower-bound pose-bundle exporter over `triad_openvr` |
| `faidra/VMC2VMT` | Already studied | Protocol adapter that feeds `VMT` instead of implementing a new SteamVR driver |
| `gpsnmeajp/SkeletonPoseTester` | Already studied | Tiny skeletal-input validation node for `VMT` and custom driver experiments |
| `logicmachine/OVR-VRC-OSC-Bridge` | Already studied | Config-defined controller-state compiler into OSC with analog mapping and rotate actions |

### Consolidation note

This family matters because `VMT and OSC tooling` is not one donor line. It now
splits into:

- a mature tracker host
- thin OpenVR-to-OSC exporters
- protocol adapters into an existing host
- skeletal validation utilities
- config-defined input-to-OSC compilers

It suggests a stronger branch inside `VR-apps-lab` around:

- `VMT`-centric adapter layers
- controller-to-OSC compilers
- skeletal-input validation tools

## Family 48: OpenXR platform shells, layer managers, and runtime inspection workbenches

This family covers repositories where the main value is not one tiny switcher
or one tiny layer template, but a fuller runtime-side utility surface.

| Project | Status | Notes |
|---|---|---|
| `vrkit-platform/vrkit-platform` | Already studied | Plugin-manifest runtime or overlay platform with service-daemon and native-interop slices |
| `clear-xr/clearxr-server` | Already studied | Desktop session host plus OpenXR API layer plus XR landing-space application |
| `maluoi/openxr-explorer` | Already studied | Shared GUI plus CLI runtime inspector with a common runtime data model |
| `fredemmott/OpenXR-API-Layers-GUI` | Already studied | Lint-and-fix layer manager with loader-state snapshots and repair actions |

### Consolidation note

This family matters because `OpenXR utilities` now split more cleanly into:

- plugin-manifest platforms
- session-owning desktop shells
- shared GUI plus CLI inspectors
- repair-oriented layer managers

It suggests a stronger branch inside `VR-apps-lab` around:

- runtime-side OpenXR utility platforms
- layer-state diagnostics and fixers
- `OpenXR doctor` style workbenches

## Family 49: Mixed-VR controller bridges, hand emulation, and external-tracker interop

This family covers repositories where foreign runtime state, hand tracking, or
external hardware is translated into SteamVR controllers or adjacent tracker
surfaces.

| Project | Status | Notes |
|---|---|---|
| `mm0zct/Oculus_Touch_Steam_Link` | Already studied | Mixed-runtime Oculus Touch bridge that can also surface devices in tracker-like modes |
| `ChristophHaag/SteamVR-OpenHMD` | Already studied | OpenHMD-backed bridge with explicit device-role mapping and controller-profile reuse |
| `kodowiec/Yet-Another-OpenVR-IPC-Driver` | Already studied | Command-driven synthetic controller and tracker host over named pipes or sockets |
| `bdub1011/Quest-Link-Hand-Tracking` | Partially studied | Gesture-configurable hand-emulation line whose public code remains thin |
| `mSparks43/PSVR-SteamVR-openHMD` | Already studied | PSVR-specific OpenHMD bridge variant and hardware-focused comparison donor |
| `krazysh01/VirtualDesktop-OpenVR-Trackers` | Partially studied | Promising tracker-bridge direction whose public snapshot still under-exposes ingress logic |

### Consolidation note

This family matters because `controller bridge` work is not only about pose
transport. It now clearly includes:

- native profile and render-model reuse
- external-command synthetic controller hosts
- declarative hand-emulation mappings
- hardware-specific OpenHMD variants
- thin public snapshots whose product direction is stronger than visible code

It suggests a stronger branch inside `VR-apps-lab` around:

- mixed-runtime controller reuse
- hand-tracking emulation into SteamVR semantics
- explicit external-command controller bridges

## Family 50: OpenVR driver learning paths, synthetic devices, and remote-input ingress

This family covers repositories whose main value is teaching or exposing the
lower-bound path into synthetic OpenVR devices.

| Project | Status | Notes |
|---|---|---|
| `terminal29/Simple-OpenVR-Driver-Tutorial` | Already studied | Best tutorial-grade central driver shell for learning OpenVR device classes |
| `finallyfunctional/openvr-driver-example` | Already studied | Tiny controller-scalar input example for locomotion or external hardware |
| `puresoul/Barebone` | Already studied | HMD-relative synthetic controller helper driven by XInput |
| `r57zone/OpenVR-ArduinoHMD` | Already studied | DIY HMD path over serial IMU data and config-defined display setup |
| `Somebody32x2/RemoteVVR` | Already studied | File-fed and browser-fed synthetic HMD/controller experiment |
| `codeysun/OpenVR-Tracker-Driver-Example` | Already studied | Generic tracker plus tracking-override harness for head-pose replacement |

### Consolidation note

This family matters because `driver learning path` is not one sample repo. It
now splits into:

- full tutorial shells
- narrow controller-input examples
- HMD-relative controller helpers
- DIY HMD baselines
- remote-ingress experiments
- tracking-override harnesses

It suggests a stronger branch inside `VR-apps-lab` around:

- onboarding and learning-path driver references
- synthetic-device ingress baselines
- very small remote-input contracts into OpenVR drivers

## Family 51: OpenVR overlay access layers, starter variants, and minimal shell experiments

This family covers repositories where the main value is not a finished overlay
product, but the smallest reusable layer that makes overlay ownership,
bootstrap, and shell split visible.

| Project | Status | Notes |
|---|---|---|
| `TheButlah/ovr_overlay` | Already studied | Overlay-focused Rust access layer with explicit context ownership and subsystem managers |
| `ViveIsAwesome/OpenVROverlayTest` | Already studied | Tiny C# dashboard overlay bootstrap with explicit image surfaces and visibility loop |
| `scudzey/UniversalVROverlay` | Already studied | C++ architecture sketch with `OverlayManager`, static overlays, and unfinished window-overlay split |
| `albrt-vr/OpenVR.ALBRT.overlay` | Already studied | Managed desktop shell plus shared overlay backend and evented runtime ownership |

### Consolidation note

This family matters because `overlay implementation` now splits more cleanly
into:

- focused access layers
- tiny dashboard starters
- early architecture-sketch shells
- desktop shell plus shared overlay backend patterns

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable overlay backplanes
- lower-bound dashboard starters
- configurable overlay apps with desktop control shells

## Family 52: WayVR ecosystem add-ons, Linux dashboard extensions, and IPC-backed overlay surfaces

This family covers repositories where the interesting lesson is not one Linux
overlay app in isolation, but how a host ecosystem is split across core,
protocol, dashboard, and extension repos.

| Project | Status | Notes |
|---|---|---|
| `oo8dev/wayvr` | Already studied | Embedded compositor and display host for Linux apps inside VR surfaces |
| `oo8dev/wayvr-dashboard` | Already studied | External dashboard client over explicit IPC into the host |
| `oo8dev/wayvr-ipc` | Already studied | Standalone protocol crate with handshake, queueing, and local-socket transport |
| `noideaman/WayvrWalltaker` | Already studied | Script and panel-XML extension that injects live content into a WayVR panel |

### Consolidation note

This family matters because `Linux desktop-in-VR host` is not one repo or one
binary. It now clearly splits into:

- compositor-capable host core
- external dashboard client
- standalone host protocol crate
- panel and script extension module

It suggests a stronger branch inside `VR-apps-lab` around:

- protocolized overlay-host ecosystems
- Linux dashboard clients over local IPC
- scriptable panel-extension surfaces

## Family 53: OpenVR capture, replay, and orchestration toolchains

This family covers repositories where VR state is recorded, transformed,
replayed, or routed into orchestration loops and creator workflows.

| Project | Status | Notes |
|---|---|---|
| `NVIDIA/vr-capture-replay` | Already studied | Mature capture-to-tape and replay-driver toolchain with helper utilities and automation flags |
| `CodeSmith2000/virtual-camera-offset` | Already studied | Narrow post-capture alignment helper for tracker-to-camera offsets |
| `wrainw/VRScout_Agent_Orchestration_Unity_Project` | Partially studied | Broad orchestration shell for synchronized capture, inference, and virtual-device control |
| `TrackLab/ViRe` | Already studied | VR-native mocap studio with recorder, settings UI, and operator workflow |

### Consolidation note

This family matters because `capture tooling` is now clearly broader than
`log some poses`. It splits into:

- capture artifact plus replay-driver pipelines
- post-capture normalization helpers
- capture plus inference orchestration shells
- VR-native recording studios

It suggests a stronger branch inside `VR-apps-lab` around:

- record-replay harnesses
- closed-loop XR orchestration
- creator-facing VR recording shells

## Family 54: OpenXR micro-layers for view shaping, streamout, debugging capture, and frame-time intervention

This family covers repositories where the main value is a narrow but strong
OpenXR API-layer intervention rather than a general runtime utility platform.

| Project | Status | Notes |
|---|---|---|
| `rublev/OpenXR-RecenterOverride` | Already studied | Per-app recenter override layer with operator-facing controls and logging |
| `mledour/OpenXR-Layer-crop-fov` | Already studied | Per-app FOV shaping layer with bootstrapped settings and bypass logic |
| `haraldsteinlechner/openxr_streamout_layer` | Already studied | Swapchain and frame-hook layer that streams rendered output outward |
| `rAzoR8/openxr-renderdoc-layer` | Already studied | Developer-tool bridge layer that wraps RenderDoc capture around XR frames |
| `fzeruhn/Smoothing-OpenXR-Layer` | Partially studied | Heavier staged frame-intervention pipeline with Vulkan and compute components |

### Consolidation note

This family matters because `OpenXR layers` now split more cleanly into:

- operator-facing per-app micro-layers
- per-app view-shaping and patch layers
- stream-out transport layers
- developer-tool bridge layers
- heavier staged frame-intervention systems

It suggests a stronger branch inside `VR-apps-lab` around:

- per-app OpenXR utility layers
- tool-bridge and transport-bridge API layers
- advanced frame-intervention research

## Family 55: OpenXR capability-injection layers, input remappers, and peripheral extension bridges

This family covers repositories where the main value is not diagnostics or
rendering intervention, but injecting new capability surfaces or reshaping
input semantics before the engine ever sees them.

| Project | Status | Notes |
|---|---|---|
| `ultraleap/OpenXRHandTracking` | Partially studied | Archived implicit hand-tracking layer that injects `XR_EXT_hand_tracking` support from external hardware |
| `Sorenon/openxr_remapping_layer` | Already studied | SuInput-backed remapping layer with runtime detection and per-handle wrapper state |
| `verncat/OpenXR_ApiLayer_Patstrap` | Already studied | Tiny Rust negotiation-and-forwarding skeleton for new capability-layer experiments |

### Consolidation note

This family matters because `OpenXR layer` work is not only about diagnostics,
view shaping, or capture. It now clearly includes:

- external hardware capability injection
- runtime-level input remapping
- very small capability-layer baselines

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR capability injection
- input-remapping API layers
- low-ceremony Rust API-layer bootstraps

## Family 56: OpenXR helper stacks, layer toolchains, and runtime adaptation helpers

This family covers repositories whose main value sits between `platform`,
`binding`, and `sample`: they help author layers, collapse boilerplate, fix
loader state, or adapt runtime output.

| Project | Status | Notes |
|---|---|---|
| `technobaboo/quark` | Already studied | Macro-generated Rust framework for authoring OpenXR API layers with typed handle registries |
| `doraibu/rayxr` | Already studied | Tiny graphics-facing OpenXR facade for raylib and narrow rendering bring-up |
| `fredemmott/openxr-layer-scripts` | Already studied | Windows registry-backed micro-tools for listing, enabling, and reordering layers |
| `elliotttate/OpenXR-CAS` | Already studied | Mature D3D11 post-process OpenXR layer with config precedence and live reload |

### Consolidation note

This family matters because `OpenXR helper` work now splits more cleanly into:

- layer-authoring frameworks
- tiny renderer-facing wrappers
- layer-state hygiene micro-tools
- runtime adaptation layers

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR layer authoring toolkits
- boilerplate-cutting graphics facades
- operator workflow tools for loader hygiene
- runtime adaptation micro-utilities

## Family 57: OpenXR passthrough samples and engine-side extension integration references

This family covers repositories where the main value is not a runtime-side API
layer, but the way an engine plugin or sample requests and integrates
passthrough-related OpenXR features.

| Project | Status | Notes |
|---|---|---|
| `AgileLens/ue-openxr-passthrough` | Already studied | Clean Unreal plugin that injects passthrough support without the full Meta XR stack |
| `BastiaanOlij/godot_test_passthrough` | Already studied | Lower-bound Godot passthrough toggle with explicit transparent viewport handling |
| `olir/mr-openxr-unity-meta-passthrough-sample` | Partially studied | Unity sample with runtime manager, diagnostics overlay, and editor bootstrap helpers |

### Consolidation note

This family matters because `OpenXR passthrough` is not only a runtime-side
patch story. It now clearly includes:

- engine-native extension plugins
- tiny scene-level toggle samples
- editor-assisted mixed-reality setup references

It suggests a stronger branch inside `VR-apps-lab` around:

- engine plugin references for one-feature OpenXR extensions
- thin passthrough setup baselines for major engines
- editor and diagnostics scaffolding for mixed-reality samples

## Family 58: Desktop-window overlay shells, Linux capture utilities, and launcher stubs

This family covers repositories where the interesting lesson is how desktop or
window surfaces are captured, routed, and controlled in VR when the shell is
older, rougher, or thinner than a full desktop-in-VR host.

| Project | Status | Notes |
|---|---|---|
| `ShiraoShotaro/DesktopOverlayer` | Already studied | Unity desktop-capture overlay with native texture bridge and manual transform controls |
| `nyxpirientity/ovr-penguin` | Already studied | CLI-first Linux overlay host over PipeWire, portal capture, and a small scene graph |
| `gamenew09/RobloxVRLauncher` | Not studied deeply | Public launcher-direction placeholder with no commits yet |

### Consolidation note

This family matters because `desktop surface in VR` now also includes:

- native texture bridges into managed overlay shells
- command-first capture hosts
- public launcher or shell placeholders that matter as product-direction nodes

It suggests a stronger branch inside `VR-apps-lab` around:

- capture-backed window surfaces
- CLI-first overlay hosts
- launcher-shaped companion shells
  tracked honestly as follow-up nodes

## Family 59: Microphone control overlays, voice-input pipelines, and audio routing helpers

This family covers repositories where the main value is not ordinary media
playback, but microphone state, voice-input fan-out, or audio-device routing
substrate.

| Project | Status | Notes |
|---|---|---|
| `matzman666/OpenVR-MicrophoneControl` | Already studied | Focused dashboard mute and push-to-talk overlay over OS microphone state |
| `I5UCC/VRCTextboxSTT` | Already studied | Local STT sidecar that fans one transcription pipeline into overlay, OSC, browser, and websocket outputs |
| `Dragon092/OpenVR_Audio_Manager` | Already studied | HMD-aware audio routing dashboard with persisted endpoint preferences |
| `VirtualDrivers/Virtual-Audio-Driver` | Already studied | Virtual speaker and microphone driver pair that works as routing substrate under higher-level voice tools |

### Consolidation note

This family matters because `VR audio helpers` now split more clearly into:

- dashboard mic-state control
- voice-input and transcription fan-out
- endpoint-routing dashboards
- lower-layer virtual audio substrate

It suggests a stronger branch inside `VR-apps-lab` around:

- mic-state overlays and push-to-talk surfaces
- voice-input companion apps
- virtual audio routing helpers

## Family 60: Immersive music players, VR media playback surfaces, and browser video shells

This family covers repositories where playback itself is the product, whether
the host is a VR-native app, a desktop shell, a WebXR shell, or a broader
engine media framework.

| Project | Status | Notes |
|---|---|---|
| `JustinLin905/around-sound` | Already studied | VR-native music player built around editable speaker topology and local-file ingestion |
| `BIVROST/360PlayerWindows` | Partially studied | Desktop immersive media shell with multiple headset backends and operator controls |
| `VR-cam/WebXR-video-player` | Already studied | Browser-native immersive video shell with explicit projection-manager and device split |
| `videolan/vlc-unity` | Partially studied | Engine media substrate with demos for 360 playback, subtitles, and broad codec support |
| `Mon-Ouie/vr-video-player-overlay` | Already studied | Narrow overlay-native video display surface that complements the heavier playback shells |

### Consolidation note

This family matters because `immersive playback` is no longer one vague media
category. It now clearly includes:

- speaker-topology music players
- desktop shells with headset backends
- browser-native immersive players
- engine-side media substrates
- narrow overlay-native playback surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- VR music and listening tools
- immersive desktop media shells
- browser-backed video surfaces
- reusable media backends inside engines

## Family 61: Spatial audio SDKs, renderers, and object-optimization toolchains

This family covers repositories where the main value sits below the UI layer in
rendering, spatialization, ambisonics, or audio object-budget management.

| Project | Status | Notes |
|---|---|---|
| `microsoft/spatialaudio-unity` | Already studied | Native DSP spatializer plugin package for Unity with sample integration |
| `videolabs/libspatialaudio` | Partially studied | Unified renderer architecture spanning HOA, object, speaker, and binaural models |
| `GoogleChrome/omnitone` | Already studied | Web ambisonic decoder and binaural renderer with explicit audio-graph modules |
| `VoidXH/Cavern` | Partially studied | Broad immersive audio framework with source-listener semantics, filters, and remapping |
| `carbonengine/spatial-audio-clustering` | Already studied | Wwise object-clustering plugin that reduces spatial object consumption while keeping centroidized spatial output |

### Consolidation note

This family matters because `audio substrate for XR`
now splits more cleanly into:

- engine-native spatializer packages
- unified renderer libraries
- browser ambisonic renderers
- broad immersive audio frameworks
- object-budget optimization plugins

It suggests a stronger branch inside `VR-apps-lab` around:

- spatial-audio engine integration
- reusable renderer abstractions
- ambisonic and binaural web references
- audio object-budget tooling

## Family 62: Creator-facing audio systems, synced player frameworks, and world-side voice management

This family covers repositories where creator ecosystems combine audio-reactive
infrastructure, synced playback, queue ownership, and world-level voice-state
control.

| Project | Status | Notes |
|---|---|---|
| `llealloo/audiolink` | Partially studied | Audio-reactive substrate that broadcasts analyzed audio into a shared texture and broader helper ecosystem |
| `MerlinVR/USharpVideo` | Already studied | Synced VRChat media-player core with backend abstraction and network time ownership |
| `sam-ln/USharpVideoQueue` | Already studied | Queue and permissions companion around an existing synced media-player core |
| `JLChnToZ/VVMW` | Partially studied | Modular creator-facing media frontend with AudioLink, overlay, playlist, and screen-control layers |
| `SylanTroh/AudioManager` | Already studied | Priority-based world voice settings and fake-occlusion manager for social spaces |

### Consolidation note

This family matters because `creator-side audio systems` are not just one
player prefab. They now clearly include:

- audio-reactive world substrate
- synced media-player cores
- queue and permission companions
- modular creator-facing frontends
- world-side voice-state managers

It suggests a stronger branch inside `VR-apps-lab` around:

- audio-reactive utility layers
- synced creator-side playback systems
- queue ownership and moderation surfaces
- world voice-state and social-space audio control

## Family 63: Browser panoramic video players, mobile wrappers, and projection-aware web playback

This family covers repositories where the main value sits in how panoramic or
immersive video playback is layered over browser players, plugin ecosystems, or
thin mobile wrappers.

| Project | Status | Notes |
|---|---|---|
| `BIVROST/360WebPlayer` | Already studied | Full browser playback framework with explicit split across media type, stereoscopy, projection family, and renderer mode |
| `yanwsh/videojs-panorama` | Already studied | `Video.js` plugin that swaps rendering path based on panoramic video type and adds hotspots plus VR control surface |
| `videojs/videojs-vr` | Already studied | Projection-aware `Video.js` VR plugin with several 180, 360, stereo, cubemap, and equi-angular modes |
| `flutterwtf/VR-Player` | Already studied | Thin Flutter wrapper over native 360 playback SDKs using platform-view bridges |

### Consolidation note

This family matters because `browser video in VR` now splits more clearly into:

- full browser playback frameworks
- enhancement plugins over existing player stacks
- projection-enum plugins with reusable layout taxonomy
- thin cross-platform mobile wrappers over native media surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- projection-aware browser playback donors
- existing-player upgrade patterns
- mobile wrapper references for immersive media shells

## Family 64: Engine-side stereo panoramic viewers, vendor player samples, and layout-specific video surfaces

This family covers repositories where immersive playback is modeled through
engine components, shader-backed panoramic surfaces, or layout-specific sample
matrices rather than whole desktop media shells.

| Project | Status | Notes |
|---|---|---|
| `ft-lab/Unity_Panorama180View` | Already studied | Compact Unity panoramic surface with image-video parity and explicit projection modes |
| `picoxr/VideoPlayer-UnityXR` | Already studied | Vendor layout matrix expressed as several playback scenes and materials rather than one reusable player core |
| `UNAmedia/ue5-stereo-panoramic-player-demo` | Partially studied | Unreal demo client that exposes a strong authoring split, but not the underlying player plugin code |

### Consolidation note

This family matters because `engine-side immersive video` now splits more
clearly into:

- reusable panoramic surface components
- vendor scene matrices for layout coverage
- high-level authoring shells over lower-level panoramic actors

It suggests a stronger branch inside `VR-apps-lab` around:

- Unity panoramic-surface donors
- vendor sample matrices as layout references
- engine authoring workflows for immersive playback

## Family 65: VRChat synced video player frameworks, queue frontends, and event-optimized media shells

This family covers repositories where the main value is creator-side video
system design: sync ownership, screen routing, playlists, queueing, handlers,
permissions, and multi-module playback flow.

| Project | Status | Notes |
|---|---|---|
| `vrctxl/VideoTXL` | Already studied | Strong manager-split package with separate video, audio, and screen layers for creator-side playback |
| `UdonVR/UdonVideoplayer` | Already studied | Compact owner-synced Udon player with backend switching and resync heuristics |
| `koorimizuw/YamaPlayer` | Partially studied | Broad modular creator-facing player with playlist, history, handler, and integration surfaces |

### Consolidation note

This family matters because `creator-side video playback` is no longer just one
sync script. It now clearly includes:

- package-level manager splits
- lean sync-core baselines
- broader modular frontends with playlists and extensions

It suggests a stronger branch inside `VR-apps-lab` around:

- creator-side synced video systems
- queue and playlist control surfaces
- modular event or venue-oriented media shells

## Family 66: Transformed, volumetric, and nonstandard 3D video viewers

This family covers repositories where the viewing model itself is unusual:
video is transformed, depth-expanded, volumetric, or embedded in a dome-style
media environment instead of an ordinary sphere or flat screen.

| Project | Status | Notes |
|---|---|---|
| `dfaker/VR-reversal` | Already studied | Transform-driven media shell over `mpv` and `ffmpeg` with head-motion logging |
| `fbriggs/lifecast_public` | Partially studied | Broad volumetric and VR180 playback substrate spanning WebXR and engine export targets |
| `parkchamchi/DepthViewer` | Partially studied | Image or video viewer that expands media into a 3D surface through depth inference and mesh controls |
| `prefrontalcortex/DomeTools` | Partially studied | Dome-style viewing environment with local media, `NDI`, and `Spout` ingest plus XR menu anchoring |

### Consolidation note

This family matters because `3D video viewer` is no longer just a stereo-sphere
variation. It now clearly includes:

- transform-driven viewers over ordinary media engines
- volumetric and VR180 playback substrate
- depth-expanded viewers with inference backends
- immersive media environments with multi-source ingest

It suggests a stronger branch inside `VR-apps-lab` around:

- nonstandard 3D playback shells
- volumetric media substrate
- depth-to-3D viewer references
- dome and spatial-media environments

## Family 67: VRChat world-authoring toolkits, optimization helpers, and prefab ecosystems

This family covers repositories where the main value sits before runtime:
editor automation, build validation, compiler optimization, or package and
prefab ecosystem design for VRChat world creation.

| Project | Status | Notes |
|---|---|---|
| `oneVR/VRWorldToolkit` | Already studied | Editor-time build checks, sync-mode policy automation, and creator convenience tools under one authoring toolkit |
| `BlueAmulet/UdonSharpOptimizer` | Already studied | Harmony-injected post-emit optimizer for generated Udon and UdonSharp compilation output |
| `Varneon/UdonEssentials` | Partially studied | Deprecated but still useful historical prefab-suite baseline with event-dispatch lineage |
| `Varneon/VUdon` | Partially studied | Umbrella repo for a package ecosystem of creator-facing Udon tools and shared common resources |

### Consolidation note

This family matters because `VRChat creator tooling` now splits more clearly
into:

- editor guardrails and build blocking
- compiler-pipeline optimization
- historical prefab suites
- package ecosystems with shared common dependencies

It suggests a stronger branch inside `VR-apps-lab` around:

- world-authoring editor helpers
- Udon optimization tooling
- prefab-suite lineage and migration
- creator-tool package decomposition

## Family 68: VRChat world runtime infrastructure, voice, networking, and player-state helpers

This family covers repositories where the main value is not media playback or
UI chrome, but lower-layer creator-world runtime infrastructure such as voice
state, transport, locomotion correction, or stable per-player object anchors.

| Project | Status | Notes |
|---|---|---|
| `Guribo/UdonVoiceUtils` | Already studied | Package-shaped voice controller with zones, occlusion, privacy channels, and runtime configuration models |
| `Xytabich/UNet` | Already studied | Reliable byte-level transport over Udon sync with explicit connection, socket, manager, and public interface layers |
| `Superbstingray/UdonPlayerPlatformHook` | Already studied | Narrow moving-platform helper that keeps local players aligned to moving colliders |
| `CyanLaser/CyanPlayerObjectPool` | Already studied | Stable per-player pooled object assignment with master verification and compiler-agnostic examples |

### Consolidation note

This family matters because `creator-world runtime infrastructure` now splits
more clearly into:

- world voice-state controllers
- byte-array transport layers
- moving-reference-frame locomotion helpers
- per-player object anchoring systems

It suggests a stronger branch inside `VR-apps-lab` around:

- creator-world runtime substrate
- per-player state and anchor utilities
- narrow locomotion correction helpers
- reusable transport abstractions for Udon worlds

## Family 69: VRChat camera, staging, and admin-control systems for world events

This family covers repositories where creators need camera coverage,
operator-facing control, or event moderation surfaces rather than generic media
players or overlays.

| Project | Status | Notes |
|---|---|---|
| `laserimouto/VRChatCameraWorks` | Already studied | Prefab-first multicam and fisheye staging rig with tiny controller scripts and autopilot support |
| `rhaamo/CameraSystem` | Already studied | Permission-gated world camera console with synced live output, handheld cameras, and operator controls |
| `VRLabs/Camera-System` | Partially studied | Avatar-side OSC camera-path system whose strongest value is companion-bound architecture and path-authoring workflow |
| `SylanTroh/GMMenu` | Partially studied | Modular admin package where watch camera, teleports, permissions, and voice controls live inside one GM surface |

### Consolidation note

This family matters because `creator camera tools` now split more clearly into:

- prefab staging rigs
- world-side operator consoles
- avatar-driven OSC camera paths
- broader admin packages with watch-camera modules

It suggests a stronger branch inside `VR-apps-lab` around:

- event-camera staging
- permission-gated creator control surfaces
- avatar-side camera-path authoring
- admin-plus-camera workflow tooling

## Family 70: VRChat interaction, utility UI, and information-surface prefabs

This family covers repositories where the main value is creator-world
interaction or reusable UI substrate: keypads, markers, data carriers, lists,
boards, and other utility-prefab surfaces.

| Project | Status | Notes |
|---|---|---|
| `Reava/U-Key` | Already studied | Rich keypad prefab with allow and deny lists, per-code routing, remote allow-list loading, and event relays |
| `z3y/VRCMarker` | Already studied | Shared 3D marker and drawing surface with compact sync strategy and PC-plus-Quest scope |
| `Miner28/AvatarImageReader` | Partially studied | Deprecated but still valuable dynamic text carrier built on avatar-thumbnail image decoding |
| `Guribo/UdonRecyclingScrollRect` | Already studied | Pool-backed Udon list infrastructure with datasource contract and delayed initialization |
| `Guribo/UdonLeaderBoard` | Not studied deeply | Thin follow-up node that likely matters most as a scoreboard layer over stronger list infrastructure |

### Consolidation note

This family matters because `creator-world utility UI` now splits more clearly
into:

- access-control and keypad surfaces
- shared drawing and annotation tools
- dynamic data carriers under platform constraints
- lower-layer reusable list and board infrastructure

It suggests a stronger branch inside `VR-apps-lab` around:

- interaction-prefab baselines
- utility UI and information surfaces
- scoreboard and board infrastructure
- creator-facing annotation and collaborative marker tools

## Family 71: VRChat world persistence, inventory, save-manager companions, and external-data bridges

This family covers repositories where the main value is how creator worlds keep
state across sessions or reach outside platform limits through companions,
helper processes, or encoded in-world persistence carriers.

| Project | Status | Notes |
|---|---|---|
| `Nestorboy/NUSaveState` | Already studied | Avatar-backed persistence system that encodes save state through parameter writers, data avatars, and finger-bone readback |
| `ChrisFeline/ToNSaveManager` | Partially studied | World-specific save companion with log watcher, local history, WebSocket API, OSC or chatbox fan-out, and JS plugin runtime |
| `TealOrangeCat/InventorySystem` | Already studied | Auto-registered holster inventory with per-item owner arrays, scene-scan setup, and hand-collider access gating |
| `DarthShader/Udon-MIDI-Web-Helper` | Partially studied | Terms-compliant external helper that extends Udon with HTTP, WebSocket, browser-open, and local-storage operations through logs plus MIDI |

### Consolidation note

This family matters because `creator-world persistence`
is no longer one lane. It now clearly includes:

- avatar-carried in-platform save state
- synced inventory ownership and holster state
- log-driven world save companions
- helper-process data bridges for web and local storage

It suggests a stronger branch inside `VR-apps-lab` around:

- constrained in-world persistence donors
- companion-app save managers
- external sidecars over creator-world transport limits
- inventory and ownership substrate for reusable world mechanics

## Family 72: VRChat creator diagnostics, editor inspection, profiling, and static-analysis helpers

This family covers repositories where the main value is earlier feedback for
creators: editor simulation, scene inspection, compile-time instrumentation, or
IDE and analyzer rules that catch invalid Udon or UdonSharp patterns.

| Project | Status | Notes |
|---|---|---|
| `GotoFinal/GotoUdon` | Partially studied | Editor-side Udon rehearsal environment with simulated players, event buttons, and multi-client launch helpers |
| `Varneon/UdonExplorer` | Already studied | Sortable scene-wide Udon metadata explorer with drill-through into source and serialized program assets |
| `DeltaNeverUsed/UdonSharpProfiler` | Already studied | Harmony-patched compiler instrumentation that emits Perfetto-friendly trace data from generated UdonSharp |
| `esnya/UdonRabbit.Analyzer` | Already studied | Roslyn analyzer suite for unsupported UdonSharp patterns, networking rules, and event-contract checks |

### Consolidation note

This family matters because `creator diagnostics`
now clearly splits into:

- editor-side runtime rehearsal
- scene metadata inspection
- compile-time trace instrumentation
- static-analysis guardrails inside the IDE

It suggests a stronger branch inside `VR-apps-lab` around:

- creator iteration acceleration
- scene-diagnostics surfaces
- compiler-adjacent instrumentation
- ecosystem-specific analyzer authoring

## Family 73: VRChat embodied interaction, custom movement, and physical world mechanics

This family covers repositories where the main value is physical interaction or
player embodiment inside creator worlds: buttons, switches, grapples, doors,
movement controllers, and vehicle rigs.

| Project | Status | Notes |
|---|---|---|
| `Janooba/immersive-interactions` | Partially studied | Physics-first interaction toolkit built around avatar-bone colliders, sleeping controls, and rich feedback surfaces |
| `squiddingme/UdonTether` | Already studied | Compact grapple controller with auto-aim, shared property object, and optional rigidbody manipulation |
| `Nestorboy/NUMovement` | Partially studied | Broad movement framework with abstract controller substrate, stance or platform handling, and extension-oriented design |
| `esnya/UdonDoor` | Already studied | Narrow but elegant pickup-driven hinge door built around signed-angle targeting and synced audio cues |
| `kurotori4423/KurotoriUdonKart` | Partially studied | Controller-steered vehicle rig split across seat, handle, throttle, and visual-state companions |

### Consolidation note

This family matters because `embodied world mechanics`
now clearly includes:

- avatar-bone collider interaction rigs
- grapple and swing locomotion
- extensible custom movement frameworks
- small physical object mechanics like doors
- vehicle control and seat-state systems

It suggests a stronger branch inside `VR-apps-lab` around:

- physics-first creator interaction donors
- movement and locomotion frameworks
- reusable physical control surfaces
- vehicle and cockpit-style creator mechanics

## Family 74: Udon data-structure libraries, serialization helpers, and creator utility foundations

This family covers repositories where the main value is lower-layer creator
substance rather than end-user prefabs: shared lifecycle layers, collection
emulation, serialization helpers, and array-oriented utility foundations.

| Project | Status | Notes |
|---|---|---|
| `Guribo/UdonUtils` | Partially studied | Broad creator utility foundation with base behaviour, singleton identity, execution-order validation, and shared helpers |
| `koyashiro/udon-list` | Already studied | Historical object-backed generic-list emulation for pre-`DataList` UdonSharp |
| `koyashiro/udon-dictionary` | Already studied | Historical paired-list dictionary emulation that layers dictionary semantics over list substrate |
| `koyashiro/udon-json` | Already studied | Historical JSON DOM, serializer, and parse-or-error surface for pre-`VRCJSON` creator workflows |
| `hoke946/UArrayCollections` | Already studied | Array-first list, dictionary, queue, and stack helpers under UdonSharp constraints |
| `Varneon/VUdon-ArrayExtensions` | Already studied | Array extension layer that adds partial `List<T>` semantics when arrays remain the deliberate runtime choice |

### Consolidation note

This family matters because `creator utility substrate`
is broader than data containers alone. It now clearly includes:

- shared lifecycle and logging foundations
- execution-order validation
- historical collection and JSON emulation
- modern array-first helper layers

It suggests a stronger branch inside `VR-apps-lab` around:

- creator-world base-framework donors
- fallback substrate under platform limits
- array-vs-container design choices
- serialization and collection helpers for larger world systems

## Family 75: VRChat creator starter baselines, test harnesses, and language-boundary experiments

This family covers repositories where the main value appears before the creator
world is even fully "running": official project bootstrap, in-world unit-style
testing, and experimental code-generation paths that still target UdonSharp.

| Project | Status | Notes |
|---|---|---|
| `vrchat-community/template-world` | Already studied | Official bootstrap baseline with editor-time resolver restoration through remote config and unitypackage import |
| `vrchat-community/template-udonsharp` | Fork / variant only | Deprecated official template whose strongest value is migration and template-lineage context |
| `koyashiro/udon-test` | Already studied | Tiny assertion substrate with recursive equality for arrays and Udon data containers |
| `raii-x/wasm2usharp` | Already studied | Rust-based Wasm-to-UdonSharp translator with explicit generated runtime substrate and test-mode output |

### Consolidation note

This family matters because `creator-world bootstrap substrate`
is broader than project scaffolding alone. It now clearly includes:

- official template bootstrap and package restoration
- historical template-variant lineage
- small in-world testing helpers
- language-boundary experiments that still land as UdonSharp

It suggests a stronger branch inside `VR-apps-lab` around:

- creator bootstrap and template lineage
- creator-world test harnesses
- code generation into UdonSharp
- early-phase authoring and bring-up patterns

## Family 76: Udon encoding, token, query, and structured-data micro-libraries

This family covers repositories where the main value is narrow but highly
reusable constrained-runtime helpers: manual encoding, cryptographic token
verification, query ergonomics, and structured-data parsing.

| Project | Status | Notes |
|---|---|---|
| `koyashiro/udon-encoding` | Already studied | Historical UTF encoding fallback for earlier creator-runtime limits |
| `koyashiro/udon-jwt` | Already studied | Frame-sliced RS256 verifier with PEM parsing and Montgomery-style modular arithmetic |
| `aiczk/ULinq` | Already studied | Source-generator and Harmony compile-hook DSL for LINQ-like authoring over arrays |
| `m-hayabusa/UdonXMLParser` | Already studied | `DataDictionary` or `DataList` XML DOM and path-query helper with async callback mode |

### Consolidation note

This family matters because `micro-libraries`
often expose the most honest constrained-runtime engineering decisions. It now
clearly includes:

- manual protocol and encoding fallback
- cryptographic verification under frame budgets
- compile-time DSL lowering for better author ergonomics
- structured-data parsing over creator-native containers

It suggests a stronger branch inside `VR-apps-lab` around:

- narrow constrained-runtime donors
- protocol and parsing helpers
- compile-hook and authoring-surface experiments
- structured-data micro-utilities

## Family 77: Udon sync, events, runtime logging, and shared helper micro-frameworks

This family covers repositories where the main value is reusable creator-world
runtime framework substrate: serialized event routing, typed networking,
stateful sync helpers, and in-world diagnostics.

| Project | Status | Notes |
|---|---|---|
| `Varneon/VUdon-Events` | Already studied | Build-time event resolver plus singleton runtime dispatcher for UnityEvent-like authoring |
| `DeltaNeverUsed/UdonSharpNetworkingLib` | Already studied | Compiler-patched RPC framework over synced byte arrays with target-routing semantics |
| `MMMaellon/LightSync` | Partially studied | Ambitious but currently unstable object-sync substrate with custom state components and auto-setup helpers |
| `Varneon/VUdon-Logger` | Already studied | Abstract logger plus in-world console surface with filters, timestamps, and sizing controls |

### Consolidation note

This family matters because `creator runtime helper frameworks`
are now clearly more than one generic utility bucket. They split into:

- serialized event-routing substrate
- typed parameterized networking
- stateful object-sync lineage
- runtime diagnostics surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- creator-world runtime framework donors
- compile-time and build-time helper layers
- event and network routing comparisons
- in-world diagnostics and debug surfaces

## Family 78: VRChat world control gadgets, environmental systems, and specialized operator surfaces

This family covers repositories where creators or operators need focused
control surfaces inside the world itself: render fixups, environmental clocks,
lighting panels, and access-control gadgets.

| Project | Status | Notes |
|---|---|---|
| `Varneon/VUdon-DepthBufferToolkit` | Already studied | Narrow render-fixup toolkit for scene cameras and mirror depth activation |
| `AcChosen/VR-Stage-Lighting` | Partially studied | Broad operator-facing lighting ecosystem with DMX grids, patch export, camera setup, and runtime controls |
| `tommaier123/UdonSharpDayNightController` | Already studied | Compact synchronized environment controller with local preview override |
| `MolotovCherry/VRChat_Keypad` | Already studied | Component-split keypad with multi-code routing, object toggles, and Udon callbacks |
| `KitKat4191/UdonKeypad` | Already studied | Compact all-in-one keypad with allow or deny lists, audio cues, and per-code door routing |

### Consolidation note

This family matters because `world control surface`
is not one thing. It now clearly includes:

- tiny render-fixup helpers
- shared environment-state controllers
- large operator ecosystems for stage control
- reusable access-control prefabs

It suggests a stronger branch inside `VR-apps-lab` around:

- world-embedded operator surfaces
- environment and lighting controllers
- render-fixup micro-tools
- keypad and access-gating gadget donors

## Family 79: VRChat avatar setup, optimization, and Quest portability

This family covers repositories where the main value sits in the avatar
pipeline before composition is even "done": editor workbenches, conversion
passes, upload optimizers, and DCC-side preparation for portable shipping.

| Project | Status | Notes |
|---|---|---|
| `rurre/PumkinsAvatarTools` | Already studied | Broad avatar workbench with project-scoped prefs, copier infrastructure, pose editing, and setup helpers |
| `kurotu/VRCQuestTools` | Already studied | Non-destructive Quest conversion toolchain with validator automators, NDMF passes, and guided setup windows |
| `d4rkc0d3r/d4rkAvatarOptimizer` | Already studied | Upload-time optimizer with shader analysis, material merge decisions, animator rewrites, and staged cleanup |
| `triazo/immersive_scaler` | Already studied | Blender-side scaler and proportional alignment tool built around avatar body metrics and armature reconciliation |

### Consolidation note

This family matters because `avatar setup pipeline`
is broader than one converter or one optimizer. It now clearly includes:

- editor workbench shells
- validator-driven Quest portability
- graph-aware upload optimization
- DCC-side pre-import scaling and alignment

It suggests a stronger branch inside `VR-apps-lab` around:

- avatar bring-up workbenches
- mobile-target validation and conversion
- upload-time cleanup and optimization
- DCC-to-Unity bridge patterns for avatar preparation

## Family 80: VRChat avatar composition, packaging, and install automation

This family covers repositories where the main value is assembling avatar parts,
merging authoring components, moving packages into projects, or keeping creator
projects healthy as install surfaces evolve.

| Project | Status | Notes |
|---|---|---|
| `bdunderscore/modular-avatar` | Already studied | Major non-destructive avatar composition system with merge-armature, merge-animator, and retargeted mesh passes |
| `hai-vr/modular-avatar-as-code` | Already studied | Code-first facade that emits Modular Avatar component graphs from source instead of from inspector-only setup |
| `vrc-get/vrc-get` | Already studied | Cross-platform project and package manager with core resolver library, CLI shell, and GUI environment sync |
| `VRLabs/Avatars-3.0-Manager` | Already studied | GUI-first avatar helper shell with reusable asset-copy APIs, controller merging, and safe unique output directories |

### Consolidation note

This family matters because `avatar composition`
is now clearly more than one merge plugin. It includes:

- non-destructive build-pipeline composition
- code-generated composition facades
- project-package management and repair
- helper-shell install and asset-copy surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- avatar composition substrate
- project-health tooling for creator ecosystems
- install-safe asset generation patterns
- package and component orchestration for reusable avatar stacks

## Family 81: VRChat avatar emulation, gesture preview, repair, and OSC-assisted posing

This family covers repositories where the main value is avatar rehearsal or
intervention after assembly: playable emulation, gesture preview, manual repair,
and pose-session sidecars.

| Project | Status | Notes |
|---|---|---|
| `lyuma/Av3Emulator` | Already studied | Full playable avatar emulator with clone variants, expression-menu stack, and OSC loopback |
| `BlackStartx/VRC-Gesture-Manager` | Already studied | Broad preview harness with radial menus, debug tools, OSC module, and dummy-avatar modes |
| `JLChnToZ/avautils` | Already studied | Manual avatar surgery suite with mesh combine, bone remap, fitting-room, and hierarchy repair helpers |
| `IlexisTheMadcat/LexisPosingSystem` | Partially studied | Paid product with a publicly visible OSC sidecar that exposes pose history, autosave, and scene orchestration |

### Consolidation note

This family matters because `avatar rehearsal and intervention`
is not one generic preview bucket. It now clearly includes:

- full playable emulation
- tool-driven gesture and expression preview
- manual repair and fitting-room workflows
- OSC-assisted pose-session companions

It suggests a stronger branch inside `VR-apps-lab` around:

- avatar rehearsal environments
- preview harnesses and debug shells
- manual repair donors
- pose-session automation and sidecar orchestration

## Family 82: VRChat avatar text, speech, translation, and viseme sidecars

This family covers repositories where the main value is turning speech,
translation, or text into avatar-visible or avatar-driven output, whether
through OSC, overlays, viseme timing, or prefab speech surfaces.

| Project | Status | Notes |
|---|---|---|
| `VRCWizard/TTS-Voice-Wizard` | Already studied | Broad speech hub with queue-based TTS, VRChat listeners, translation, and OSC plus chatbox plus avatar-text fan-out |
| `YusufOzmen01/kikitan-translator` | Already studied | Hybrid translator sidecar that splits React or Tauri UI, Rust OSC egress, and OpenVR overlay output |
| `met4citizen/HeadTTS` | Already studied | Reusable TTS substrate with browser or server backends, phoneme timestamps, and viseme output |
| `Frosty704/Billboard` | Partially studied | Strong product reference for a world-droppable avatar speech surface built over avatar-text substrate and parameter budgets |

### Consolidation note

This family matters because `avatar-facing speech tooling`
is broader than one chatbox app. It now clearly includes:

- sidecar speech hubs
- translation plus overlay shells
- viseme-aware TTS substrate
- avatar-visible speech surfaces and prefab UX

It suggests a stronger branch inside `VR-apps-lab` around:

- avatar speech and translation companions
- viseme and lip-sync donor engines
- overlay-backed language or subtitle surfaces
- speech-bubble and avatar-text UX references

## Family 83: VRChat shader ecosystems, material translators, and visual-safety shaders

This family covers repositories where avatar visual tooling is the main value:
shader ecosystems, material migration utilities, shader inspector or optimizer
logic, modular effect packs, and avatar-installed visual comfort filters.

| Project | Status | Notes |
|---|---|---|
| `poiyomi/PoiyomiToonShader` | Partially studied | Large shader ecosystem with built-in lilToon-to-Poiyomi translator, shader variant selection, render preset setup, and render queue restoration |
| `lilxyzw/lilToon` | Partially studied | Large shader ecosystem with custom inspector modes, multi-material editing, material conversion utilities, and constant-property shader optimization |
| `MochiesCode/Mochies-Unity-Shaders` | Already studied | Modular shader pack with water, glass, screen, particle, toon, and shared common include substrate |
| `LinesGuy/lilToonToPoiyomiToon` | Already studied | Narrow one-shot material converter with backup flow, target shader selection, render mode mapping, and skipped-material reporting |
| `LesseVR/EpilepsyProtection` | Already studied | Avatar-installed visual-safety shader using background grab, luminance thresholding, blackout, HDR clamp, night mode, and distance hide |

### Consolidation note

This family matters because `avatar visual tooling` is not just shader art. It
now clearly includes:

- heavy shader editor ecosystems
- material migration tables
- multi-material and optimizer workflows
- modular effect-pack include layouts
- accessibility and comfort shader addons

It suggests a stronger branch inside `VR-apps-lab` around:

- creator-facing material migration helpers
- shader inspector UX and validation
- shader-pack architecture
- avatar visual-safety and comfort tools

## Family 84: VRCFury toggle automation, avatar animator DSLs, and editor QoL overlays

This family covers repositories where the main value is avatar feature
automation around VRCFury, toggle generation, code-first animator authoring, and
editor workflow improvements.

| Project | Status | Notes |
|---|---|---|
| `VRCFury/VRCFury` | Partially studied | Major avatar feature-builder substrate with menu auto-pagination, avatar utility helpers, DI validation, and public toggle API wrappers |
| `RealWhyKnot/wk-vrcfury-qol` | Already studied | Reflection-backed QoL extension with UIElements inspector overlay, context-menu registration, clone preview, hot reload, and cleanup |
| `SuperFlue/VRCToggleToolkit` | Already studied | Generator window that emits animation clips, FX layers, VRChat parameters, expression menus, exclusive toggles, and fallback state |
| `hai-vr/animator-as-code-vrchat` | Already studied | Code-first DSL extensions for VRChat animator parameter drivers, local or unsynced randomization, and play-audio behaviors |
| `vr-voyage/vrchat-quick-toggle-vrcfury` | Already studied | Tiny VRCFury public-API micro-utility that creates menu-path toggles from selected GameObjects |

### Consolidation note

This family matters because `avatar feature automation` is broader than a
single installer. It now clearly includes:

- feature-builder substrate
- public API wrappers
- reflection-backed editor extensions
- clone-based preview
- generated toggle assets
- code-first animator behavior authoring

It suggests a stronger branch inside `VR-apps-lab` around:

- avatar feature automation
- editor QoL overlays
- non-destructive preview helpers
- tiny creator micro-utilities powered by stable public APIs

## Family 85: VRCFaceTracking core, modules, templates, and blendshape preparation

This family covers repositories where the main value is face or eye tracking
for VRChat: host apps, module SDKs, provider modules, cross-platform shells,
OSC or UDP data ingestion, and avatar authoring helpers for compatible shapes.

| Project | Status | Notes |
|---|---|---|
| `benaclejames/VRCFaceTracking` | Partially studied | Core bridge with module lifecycle, unified expression state, OSC parameter sending, UI pages, module metadata, and sandboxed module IPC |
| `dfgHiatus/VRCFaceTracking.Avalonia` | Partially studied | Cross-platform shell with module compatibility matrix, registry service, ratings/download metadata, legacy module migration, and drop overlay control |
| `dfgHiatus/VRCFT-Babble` | Already studied | Compact Project Babble module that receives local OSC and maps addresses into unified VRCFT expressions |
| `regzo2/VRCFaceTracking-MeowFace` | Already studied | UDP JSON phone-tracking module with local IP setup, enum-indexed blendshape conversion, eye mapping, and expression normalization |
| `Adjerry91/VRCFaceTracking-blender-plugin` | Already studied | Blender shape-key preparation addon with fixed VRCFT labels, selected-shape mapping, duplicate handling, and create/overwrite operator |

### Consolidation note

This family matters because `face tracking` is a pipeline rather than a device
list. It now clearly includes:

- host app and module lifecycle substrate
- normalized unified expression state
- OSC, UDP, JSON, and registry integration
- cross-platform compatibility and packaging concerns
- DCC-side blendshape preparation

It suggests a stronger branch inside `VR-apps-lab` around:

- face-tracking module templates
- sensor-to-expression normalization
- tracking diagnostics and module registries
- avatar authoring helpers for compatible expression targets

## Family 86: VRChat avatar dynamics, PhysBone migration, contact prefabs, and in-game tuning

This family covers repositories where the main value is avatar physical
interaction: PhysBone migration, in-game tuning, component grouping, contact
trackers, grabbable props, and collision-state prefabs.

| Project | Status | Notes |
|---|---|---|
| `FACS01-01/PhysBone-to-DynamicBone` | Already studied | Editor converter with duplicate-safe flow, lossless/lossy parameter mapping, collider migration, gravity falloff handling, and helper GameObjects |
| `naqtn/PhysBonesTK` | Already studied | In-game PhysBone tuning kit with expression menus, parameter-value mapping, reload commands, body-bone and accessory-item variants, and world-constraint controls |
| `TizzureOne/VRChat_PhysboneDetach` | Already studied | Tiny editor hierarchy-surgery utility that groups copied PhysBone and collider components for outfit toggles and resource management |
| `ThatFatKidsMom/Avatar-Prop` | Partially studied | Grabbable avatar prop reference using PhysBones, constraints, contact trackers, FinalIK assumptions, and Modular Avatar or VRCFury install variants |
| `VRLabs/Collision-Detection` | Already studied | Contact/particle collision prefab with `IsColliding`, `AlwaysReset`, and `Reset` bool surface plus a conditional Instancer hook |

### Consolidation note

This family matters because `avatar dynamics` is a practical interaction
branch, not only a physics label. It now clearly includes:

- editor migration and approximation tools
- in-VR tuning menus
- component grouping for toggles
- contact-driven prop manipulation
- collision-state prefabs with small animator bool surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- avatar physical interaction patterns
- PhysBone authoring and migration helpers
- in-game calibration surfaces
- contact/collision prefab design

## Family 87: VRChat companion apps, OSC routers, plugin senders, data hubs, and web debug surfaces

This family covers repositories where the main value is an external VRChat
companion or local integration surface: desktop social state, overlay feeds,
OSC routing, plugin-hosted senders, local data hubs, and browser controls.

| Project | Status | Notes |
|---|---|---|
| `vrcx-team/VRCX` | Partially studied | Large Electron/Vue companion with social/world/avatar state, VR overlay feed, device-status cards, and Linux offscreen shared-memory overlay rendering |
| `SutekhVRC/VOR` | Already studied | Rust OSC fan-out router with packet filtering, malformed-packet cleanup, route status, sync/async routing, and debug streams |
| `YABam/VRCOSCGUI` | Partially studied | Plugin-hosted OSC sender where plugins request sends and receive holder status while the holder owns sockets |
| `PlagueVRC/VRCOSCDataHub` | Already studied | Narrow OSC-to-TCP hub with type-tag extraction and split-friendly address/value payload formatting |
| `EveryDayCompute/VRCOSCWeb` | Already studied | Quart/WebSocket/browser avatar-parameter debug surface backed by local VRChat OSC avatar JSON and D3 controls |

### Consolidation note

This family matters because `VRChat companion surfaces` are a major utility
branch outside Unity. It now clearly includes:

- desktop companion state and overlay feeds
- OSC fan-out and packet sanitation
- plugin-hosted sender boundaries
- local OSC-to-TCP data normalization
- browser-native avatar parameter debug panels

It suggests a stronger branch inside `VR-apps-lab` around:

- local companion shells
- OSC routing and contention management
- browser debug/control surfaces
- overlay feeds that summarize social, device, and avatar state

## Family 88: SlimeVR server, tracker firmware, adapters, and calibration ecosystem

This family covers repositories where the main value is SlimeVR-style tracking
infrastructure: firmware packets, server hubs, skeleton calibration, runtime
bridges, consumer-device adapters, BLE normalization, battery/health
diagnostics, and guided tracker setup.

| Project | Status | Notes |
|---|---|---|
| `SlimeVR/SlimeVR-Server` | Partially studied | Central tracker hub with named-pipe/Unix-socket driver bridges, OSC/VMC/BVH outputs, FlatBuffer WebSocket API, GUI, and VR setup mode |
| `SlimeVR/SlimeVR-Tracker-ESP` | Partially studied | ESP tracker firmware with IMU loop, UDP packet vocabulary, diagnostics packets, battery monitor, calibration persistence, and feature flags |
| `carl-anders/slimevr-wrangler` | Already studied | Rust/Iced Joy-Con adapter with Deku packet serialization, handshake, rotation/acceleration mapping, reset action, and device status UI |
| `moslime/moslime` | Already studied | Python Mocopi BLE bridge with SlimeVR autodiscovery, quaternion conversion, packet-drop checks, battery reporting, and reconnect loops |
| `OCSYT/SlimeTora` | Partially studied | Electron HaritoraX adapter with model/dongle/COM detection, tracker emulation, button actions, battery smoothing, visualization, and debug events |

### Consolidation note

This family matters because `tracker helper` design is an ecosystem problem.
It now clearly includes:

- firmware health and diagnostics protocols
- central server hubs with multiple output bridges
- skeleton calibration and guided setup
- consumer-controller and BLE tracker adapters
- hardware onboarding and per-tracker debug surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- tracker hubs and bridge abstraction
- battery and signal diagnostics
- hardware adapter UX
- calibration workflows that survive heterogeneous input devices

## Family 89: bHaptics SDKs, OSC bridges, relays, and telemetry-to-haptic adapters

This family covers repositories where the main value is translating events
from games, avatars, browsers, scripts, logs, or WebSockets into wearable
haptic feedback.

| Project | Status | Notes |
|---|---|---|
| `bhaptics/haptic-library` | Partially studied | Native C++ library and Player WebSocket manager with feedback registration, event playback, dot/path submission, status, and turn-off calls |
| `bhaptics/tact-js` | Already studied | TypeScript/browser SDK facade for event, dot, path, glove, device, mapping, connection, and playing-state calls |
| `bhaptics/tact-python` | Partially studied | Thin Python command reference for async haptic event, dot, path, glove, ping, device info, and Player status workflows |
| `HerpDerpinstine/bHapticsOSC` | Already studied | VRChat OSC-to-haptics bridge with config hot reload, reflection-bound OSC handlers, avatar-change reset, and per-device motor buffers |
| `Dteyn/bHapticsRelay` | Already studied | WPF relay that tails log lines or accepts WebSocket commands and maps them into SDK2 haptic playback calls with offline fallback |

### Consolidation note

This family matters because `haptics integration` is a reusable VR output
channel. It now clearly includes:

- vendor SDK facades
- browser and Python command surfaces
- avatar OSC-to-haptics bridges
- log-tail and WebSocket relays
- event, dot, path, glove, and device-management APIs

It suggests a stronger branch inside `VR-apps-lab` around:

- haptic alert/feedback sidecars
- event-to-output relay architecture
- avatar parameter tactile feedback
- browser panels that control non-visual feedback

## Family 90: No-HMD and virtual-HMD OpenVR helpers, phone bridges, and controllable driver stubs

This family covers repositories where the main value is headsetless or virtual
device development: phone-HMD bridges, desktop-display HMD drivers,
controller/tracker fake-HMD pose, socket-controlled virtual devices, and
keyboard/mouse fake rigs.

| Project | Status | Notes |
|---|---|---|
| `PhoneVR-Developers/PhoneVR` | Partially studied | Phone-as-HMD bridge with OpenVR driver, TCP pairing, projection exchange, pose stream, virtual display present path, and Android client paths |
| `SDraw/driver_hmd` | Already studied | Minimal desktop-display-as-HMD OpenVR driver with display component, pose update loop, debug transform request, and keyboard controls |
| `pema99/faceless` | Already studied | No-HMD driver that infers fake head pose from controllers or tracker and persists calibration through keybind-driven settings |
| `kajsaantonigelstrom/OpenVRsim` | Already studied | Null OpenVR driver controlled by Python through ZeroMQ, with scripted pose/button commands and CSV test-case flows |
| `blakebeckcoding/Pepper` | Partially studied | Tutorial-style fake HMD plus controllers rig with provider, fake devices, controller components, and keyboard/mouse input thread |

### Consolidation note

This family matters because `headsetless VR workflows` are useful for
diagnostics, development, automated tests, and hardware-light iteration. It now
clearly includes:

- phone-as-HMD streaming bridges
- desktop display or null display HMD components
- controller/tracker-derived fake head pose
- socket-controlled virtual-device harnesses
- keyboard/mouse fake HMD and controller rigs

It suggests a stronger branch inside `VR-apps-lab` around:

- no-HMD development helpers
- repeatable VR test harnesses
- controllable virtual devices
- documentation of minimum viable OpenVR fake-device anatomy

## Family 91: WebXR browser API samples, input profiles, emulators, polyfills, and React/Three XR wrappers

This family covers repositories where the main value is browser-native XR:
session shells, inline/immersive mode handling, controller-profile assets,
browser emulator injection, historical polyfills, and framework-level WebXR
state stores.

| Project | Status | Notes |
|---|---|---|
| `immersive-web/webxr-samples` | Already studied | Canonical WebXR sample shell with session support checks, inline/immersive setup, reference spaces, layers, input-source rendering, hit tests, stats, and teleportation |
| `immersive-web/webxr-input-profiles` | Already studied | Controller profile registry and motion-controller package with profile validation, component mappings, gamepad polling, and asset naming rules |
| `meta-quest/immersive-web-emulator` | Already studied | Browser extension that installs an emulated WebXR runtime, DevUI, and synthetic environment through domain-scoped content-script injection |
| `mozilla/webxr-polyfill` | Partially studied | Deprecated WebXR/WebVR polyfill lineage with display/reality abstractions, FlatDisplay AR path, and fallback architecture history |
| `pmndrs/xr` | Partially studied | Modern React Three Fiber and vanilla WebXR wrapper with session store, typed input states, events, teleport, layers, anchors, and emulator hooks |

### Consolidation note

This family matters because `browser XR` is a fast utility substrate rather
than only a demo target. It now clearly includes:

- session and frame-loop wrappers
- controller-profile and asset registries
- browser emulator/runtime injection
- historical display/reality polyfill abstractions
- framework stores for typed input, teleport, anchors, and layers

It suggests a stronger branch inside `VR-apps-lab` around:

- browser-based VR diagnostics
- controller visualizers and input-profile explorers
- WebSocket/browser operator panels
- lightweight WebXR utility shells

## Family 92: Unity XR interaction/workflow toolkits, scientific rigs, training graphs, and Tilia composition

This family covers repositories where the main value is reusable Unity XR
toolkit design: modular MR UX primitives, scientific or exhibition rigs,
training/workflow graphs, scene-object properties, editor validation, and
prefab-composed interaction ecosystems.

| Project | Status | Notes |
|---|---|---|
| `MixedRealityToolkit/MixedRealityToolkit-Unity` | Partially studied | Modern MRTK3 packages with stateful interactables, pressable buttons, object manipulation, solver handlers, menus, slates, dialogs, and OpenXR/XRI positioning |
| `eisclimber/ExPresS-XR` | Partially studied | Scientific/exhibition toolkit with configurable rig, movement presets, data gathering, quizzes, value-range interactables, sockets, menus, HUDs, and tutorial helpers |
| `MindPort-GmbH/VR-Builder` | Partially studied | VR training workflow editor with steps, behaviors, transitions, scene-object references, process properties, conditions, validation, and fix buttons |
| `ExtendRealityLtd/VRTK` | Partially studied | VRTK v4/Tilia composition ecosystem with action/rule/pointer/interactable/snap-zone packages and prefab-driven scene wiring |

### Consolidation note

This family matters because Unity XR utilities often need reusable interaction
and workflow scaffolding, not only runtime API calls. It now clearly includes:

- stateful MR UI and pressable controls
- manipulation and solver orchestration
- experiment/training data capture
- no-code step/condition workflow graphs
- prefab-composed rules, actions, pointers, haptics, and snap zones

It suggests a stronger branch inside `VR-apps-lab` around:

- in-headset utility menu primitives
- guided setup and calibration workflows
- training and experiment helper shells
- Unity package composition patterns

## Family 93: Meta Quest MR camera, depth, spatial-anchor, presence, and motif samples

This family covers repositories where the main value is Quest mixed-reality
implementation: passthrough camera access, camera-to-world mapping, depth and
occlusion, shared spatial anchors, colocated rooms, full MR app composition,
and reusable product motifs.

| Project | Status | Notes |
|---|---|---|
| `oculus-samples/Unity-PassthroughCameraApiSamples` | Already studied | Passthrough camera samples with permission gating, camera-to-world rays, brightness estimation, Sentis object detection, pose reliability, and anchor-backed markers |
| `oculus-samples/Unity-DepthAPI` | Already studied | Environment depth package and samples with BiRP/URP branches, occlusion toggles, hand removal, UI cutout, depth bias, and scene mesh masking |
| `oculus-samples/Unity-SharedSpatialAnchors` | Partially studied | Shared anchor lifecycle with saved/cloud loading, group sharing, colocation advertisement/discovery, anchor binding, Photon publishing, and world-origin alignment |
| `oculus-samples/Unity-Discover` | Partially studied | Full MR app composition reference using Meta XR SDK, Scene API, Interaction SDK, passthrough, spatial anchors, networking, and project-structure docs |
| `oculus-samples/Unity-MRMotifs` | Partially studied | MR motif library covering passthrough transitions, shared activities, instant placement, depth effects, room sharing, and colocated experiences |

### Consolidation note

This family matters because `mixed-reality utility design` needs camera,
depth, anchors, and shared-room semantics together. It now clearly includes:

- camera texture, pose, and permission workflows
- camera-to-world rays and detection markers
- depth occlusion, bias, cutout, and hand-removal controls
- shared spatial-anchor lifecycle and alignment
- product motifs for transitions, placement, space sharing, and shared
  activities

It suggests a stronger branch inside `VR-apps-lab` around:

- MR diagnostics and camera/depth inspectors
- physical-room utility markers
- shared spatial setup helpers
- Quest-specific MR feature blueprints

## Family 94: Linux spatial desktop, Stardust workspace clients, and desktop-to-XR helpers

This family covers repositories where the main value is desktop and workspace
surfaces in XR on Linux: full VR desktops, panel bridges, virtual monitors,
launchers, workspace cells, input injection, and compositor-assisted window
mirroring.

| Project | Status | Notes |
|---|---|---|
| `SimulaVR/Simula` | Partially studied | Full Linux VR desktop shell with gaze-active windows, workspace shortcuts, keyboard/mouse grab, xpra/Wayland display routes, Godot backend glue, and Monado HUD references |
| `StardustXR/flatland` | Partially studied | Stardust 2D panel bridge with toplevel state, pointer/touch injection, resize handles, close button, panel transfer, and HMD-relative placement |
| `StardustXR/kiara` | Already studied | Stardust shell that launches Niri and maps a 360-degree virtual monitor/ring with pointer/hand/tip coordinate forwarding |
| `StardustXR/protostar` | Already studied | Stardust launcher family with desktop-entry parsing, connection environment, startup token, systemd or double-fork launch, and spatial icon grids |
| `StardustXR/magnetar` | Already studied | Workspace client with movable cylindrical fields, cells, zones, capture queues, parent-in-place capture, and ring/grab affordances |
| `yshui/picom-xrdesktop-companion` | Partially studied | X11/picom DBus companion that mirrors windows through xrdesktop/gxr/gulkan, with composite/damage texture handling, input synthesis, and stacking caveats |

### Consolidation note

This family matters because `desktop-in-XR` is a set of product architectures,
not one feature. It now clearly includes:

- full Linux VR desktop shells
- per-window or per-panel surface bridges
- virtual monitor shells around the user
- XR launchers for normal desktop apps
- workspace grouping through spatial zones
- compositor metadata helpers for existing desktop windows

It suggests a stronger branch inside `VR-apps-lab` around:

- panel/window overlay helpers
- spatial workspace organization
- launcher and app-session utilities
- Linux desktop mirroring tradeoff notes

## Family 95: Godot XR engine toolkits, templates, backends, and vendor extension stacks

This family covers repositories where the main value is Godot-side XR utility
architecture: scene-pack interaction toolkits, starter templates, OpenXR/OpenVR
backend plugins, vendor OpenXR extension wrappers, export feature toggles, and
legacy mobile VR migration references.

| Project | Status | Notes |
|---|---|---|
| `GodotVR/godot-xr-tools` | Partially studied | Modular XR scene pack with gaze/pointer/pickup/pose/teleport/movement functions, hands, interactables, desktop support, effects, staging, rumble, and settings |
| `GodotVR/godot-xr-template` | Already studied | Starter project with OpenXR action map, XR Tools wiring, OpenXR Vendors dependency, and Android export feature toggles |
| `GodotVR/godot_openxr_for_godot_3.x` | Partially studied | Legacy Godot 3 OpenXR backend with interface/config/action/pose/hand/skeleton/extension wrapper boundaries |
| `GodotVR/godot_openxr_vendors` | Partially studied | Godot 4 GDExtension stack for Android XR, Meta, Pico, Lynx, Magic Leap, Khronos, passthrough, anchors, depth, body/face/hand, scene, render-model, and export-plugin features |
| `GodotVR/godot_openvr` | Partially studied | Godot 4 OpenVR/SteamVR backend with action manifests, skeletons, play-area, render-model, battery, and charging helpers |
| `GodotVR/godot_oculus_mobile` | Already studied as deprecated reference | Deprecated Oculus Mobile bridge useful only for migration/API-shaping lessons around vendor wrapper surfaces |

### Consolidation note

This family matters because `Godot XR` can be a compact prototyping substrate
for utilities when interaction and device features are made explicit as addons,
templates, action maps, and export gates. It now clearly includes:

- scene-pack interaction functions and reusable scenes
- starter templates with action maps and export presets
- OpenXR/OpenVR backend anatomy
- vendor feature wrappers and project setup helpers
- deprecated mobile bridges as migration references

It suggests a stronger branch inside `VR-apps-lab` around:

- Godot XR utility prototypes
- vendor feature capability explorers
- action-map and export-preset baselines
- cross-engine comparison of interaction module boundaries

## Family 96: A-Frame WebXR components, inspectors, networked scenes, and hand UI

This family covers repositories where the main value is browser-native XR
composition above raw WebXR APIs: declarative entity components, systems,
primitives, visual scene inspectors, locomotion packs, schema-driven networked
scenes, in-VR diagnostics, and hand-joint helper components.

| Project | Status | Notes |
|---|---|---|
| `aframevr/aframe` | Partially studied | Declarative WebXR ECS runtime with tracked/hand/laser controls, raycaster, cursor, sound, layers, AR hit test, XR mode UI, stats, screenshot, and spectator camera paths |
| `aframevr/aframe-inspector` | Already studied | Embeddable visual scene graph and live component editor with entity selection, cameras, history, component add/edit, copy, and GLB export paths |
| `c-frame/aframe-extras` | Already studied | Locomotion/input helper pack with movement controls, gamepad/keyboard/touch/trackpad/nipple inputs, navmesh agents, checkpoint, grab, sphere collider, and loaders |
| `networked-aframe/networked-aframe` | Partially studied | Schema-driven scene sync with networked-scene config, adapter factory for WebRTC/WebSocket transports, room server, and networked hand controls |
| `supermedium/superframe` | Partially studied | Component library with in-VR logs, haptics, state, templates, layout, FPS/debug helpers, audio analysis, thumb controls, and micro-utility components |
| `gftruj/aframe-hand-tracking-controls-extras` | Already studied | WebXR hand-joint helper API with pinch-driven hand teleport, drag move/rotate, finger cursor, and fingertip interaction components |

### Consolidation note

This family matters because `browser XR` can be a practical utility substrate
when low-level WebXR details are lifted into components, schemas, inspectors,
and diagnostics. It now clearly includes:

- declarative entity-component XR scenes
- embedded scene inspection and live component editing
- composable locomotion/input controls
- schema-driven networked scenes
- in-VR logs and micro-diagnostics
- hand-joint helpers and pinch UI widgets

It suggests a stronger branch inside `VR-apps-lab` around:

- browser-based XR utility shells
- WebXR scene inspectors and debug panels
- collaborative operator surfaces
- hand-first WebXR UI experiments

## Family 97: Unreal VR interaction toolkits, hand tracking, comfort, and tracker plugins

This family covers repositories where the main value is Unreal-side XR utility
architecture: replicated grip/movement systems, Blueprint/C++ component packs,
MR UX primitives, comfort/tunnelling plugins, OpenXR hand tracking, Vive tracker
role plugins, and compact multiplayer interaction frameworks.

| Project | Status | Notes |
|---|---|---|
| `mordentral/VRExpansionPlugin` | Partially studied | Large replicated VR interaction framework with grip motion controllers, object grip replication, smoothing, movement actions, teleport events, and OpenXR hand pose helpers |
| `1runeberg/RunebergVRPlugin` | Already studied | Compact VR component pack for pawn, grabber, movement, teleporter, gaze, gesture database, climb, and custom gravity |
| `microsoft/MixedReality-UXTools-Unreal` | Partially studied as archived reference | MR UX plugin with hand tracker abstraction, near/far input, simulation, pressable buttons, sliders, bounds, manipulators, menus, pointers, and touchables |
| `sigtrapgames/VrTunnellingPro-UE4` | Already studied | Comfort plugin with vignette/tunnelling, masks, skybox/cubemap, windows, blur, mobile paths, and presets |
| `demonixis/FSOpenXRHandTracking` | Already studied | Compact OpenXR hand tracking adapter with instanced hand rendering, pinch detection, Enhanced Input actions, and smoothed hand rays |
| `Rectus/UE4OpenXRViveTrackerPlugin` | Already studied | Thin OpenXR extension plugin mapping Vive tracker role paths into Unreal motion source names |
| `V4C38/ue5-xrcore` | Partially studied | Modern XRCore framework with replicated hands, lasers, interactors, grab/trigger interactions, connector sockets, holograms, highlights, and replicated physics helpers |

### Consolidation note

This family matters because `Unreal XR utilities` often need plugin-level
boundaries for authority, input, UX primitives, comfort, and extension mapping.
It now clearly includes:

- replicated grip and VR movement authority
- compact Blueprint-facing VR components
- MR near/far UI and hand simulation
- comfort vignette/tunnelling preset systems
- OpenXR hand tracking and tracker role plugins
- lightweight multiplayer interaction components

It suggests a stronger branch inside `VR-apps-lab` around:

- Unreal interaction donor comparison
- near/far spatial UI synthesis
- tracker role diagnostics
- comfort setting and accessibility references

## Family 98: VR teleoperation headset frontends, robot bridges, and data capture

This family covers repositories where VR headsets, controllers, and hand
tracking become control surfaces for robots, simulation robots, or camera arms.
The reusable value is usually in frontend/transport/control-loop/safety/logging
architecture rather than in robot-specific code.

| Project | Status | Notes |
|---|---|---|
| `kscalelabs/kbot_vr_teleop` | Partially studied | React/WebXR headset frontend with hand/controller tracking, robot/video surfaces, Python IK, UDP robot command schema, joystick commands, finger UDP helpers, and Rerun visualizer |
| `dwaitbhatt/xarm_vr_teleop` | Already studied | Headset-free SteamVR/OpenVR controller-to-xArm bridge with null-driver setup, pose deltas, IK/control modes, trigger gripper, haptics, and menu exit |
| `NVlabs/collab-sim` | Partially studied | Isaac Sim/OpenXR VR robot teleop with CuRobo IK/MPC, controller follower frames, button managers, reset callbacks, data logging, and replay |
| `wengmister/franka-vr-teleop` | Partially studied | Quest hand-pose stream through ROS2/UDP/TCP/ADB reverse into weighted IK, Ruckig joint velocity, smoothing, pause/recenter, and pose visualization |
| `nakama-lab/VR_Teleop_Interface` | Partially studied | Unity/Quest/ROS2/ZED/Franka bridge with stereo feed, controller publishers, force/torque-to-rumble feedback, ROS TCP topics, Docker ZED deployment, and SSH launch |
| `open-thought/cambot` | Partially studied | WebXR stereo camera-arm telepresence with HTTPS/WebSocket, WebRTC fallback, VR HUD, head-pose IK, safety bounds, watchdog, pause, home, and transport controls |
| `plund-dtu/UR_VR_Teleop` | Partially studied | OpenVR/Meta Quest controller bridge for UR robots with RTDE servoL, axis remap, Robotiq gripper, pause/recenter, RealSense workers, episode save/reset, and custom logging loop |

### Consolidation note

This family matters because `VR teleoperation` turns many recurring utility
problems into one architecture: headset frontend, pose/control transport,
command relay, IK/MPC/control loop, safety gates, visualization, and data
capture. It now clearly includes:

- WebXR headset frontends for robot/operator surfaces
- SteamVR/OpenVR controller-pose bridges
- Unity/ROS2/Quest/ZED multi-machine bridges
- Isaac Sim/OpenXR simulation teleop and replay
- UDP/TCP/WebSocket/WebRTC/ROS transport models
- pause, recenter, smoothing, watchdog, workspace bounds, and data logging

It suggests a stronger branch inside `VR-apps-lab` around:

- generic VR operator/control-surface architecture
- pose stream diagnostics and visualizers
- safe recenter/pause UX patterns
- synchronized demonstration capture and replay references

## Family 99: ALVR/WiVRn ecosystem sidecars, platform clients, and streaming helpers

This family covers repositories around already studied streaming cores. The
value is not in duplicating `ALVR` or `WiVRn`, but in understanding the
companion tools that make platform bring-up, runtime integration, tracking
payload translation, wired setup, and timing inspection more usable.

| Project | Status | Notes |
|---|---|---|
| `alvr-org/alvr-visionos` | Partially studied | visionOS ALVR client with SwiftUI entry window, immersive spaces, RealityKit/Metal render paths, VideoToolbox decoding, AR/world tracking, eye broadcast, event watchdogs, and performance overlay |
| `alvr-org/Monado-ALVR` | Partially studied as runtime-fork reference | ALVR-oriented Monado fork most useful here for remote-driver, manifest, IPC, tracing, metrics, and driver-writing documentation patterns |
| `alvr-org/VRCFT-ALVR` | Already studied | VRCFaceTracking module that receives ALVR UDP float payloads, prefix-dispatches eye/face packet families, and maps vendor expressions into unified eye/expression data |
| `AtlasTheProto/ADBForwarder` | Already studied | Wired ALVR setup helper that locates/downloads ADB, starts the server, monitors Quest/Go devices, applies port forwards, and prints device-level status |
| `Kierek/WiVRnTimings` | Already studied as micro-utility | Kotlin/Compose timing preset parser/viewer that turns CSV timing frames and parts into a small inspection surface |

### Consolidation note

This family matters because mature streaming stacks often need thin companion
tools more than they need another monolith. It now clearly includes:

- platform-specific headset clients
- runtime bridge and remote-driver references
- eye/face tracking payload adapters
- USB/ADB setup repair helpers
- timing and latency inspection micro-tools

It suggests a stronger branch inside `VR-apps-lab` around:

- streaming setup doctors
- tracking-payload adapter references
- platform-client lifecycle patterns
- runtime telemetry and timing sidecars

## Family 100: XR glasses WebHID, virtual displays, and head-tracked desktop helpers

This family covers small XR-glasses utilities that sit around stronger driver
or spatial-desktop projects. The reusable value is in WebHID probing,
protocol/IMU utilities, X11 capture POCs, virtual display lifecycle, menu-bar
control surfaces, and head-orientation-to-viewport mapping.

| Project | Status | Notes |
|---|---|---|
| `jakedowns/xreal-webxr` | Partially studied | Browser WebHID workbench with XREAL/Nreal device filtering, Air/Light managers, input-report parsing, IMU packet polling, firmware command scaffolding, and packet logging |
| `alexwilson1/nreal_linux_test` | Partially studied as Linux/X11 POC | GStreamer/OpenCV screen capture POC with left/right gaze calibration, yaw normalization, and multi-monitor viewport slicing for Nreal Air |
| `Mailbot/Nreal_Air_Desktop_tool` | Partially studied as product reference only | Thin desktop-control framing for Nreal Air; useful as product reference but not a current code donor |
| `edwatt/real_utilities` | Partially studied | Native protocol utility around Nreal Air device commands and reports; useful as a low-level comparison node |
| `DannyDesert/XReal-Ultrawide` | Already studied | macOS menu-bar app with private CGVirtualDisplay lifecycle, ScreenCaptureKit/Metal viewport path, XREAL IMU service, recenter, smoothing, dead zone, and lean-to-zoom |

### Consolidation note

This family matters because `XR glasses` utility work is often a stack of
small surfaces rather than one runtime. It now clearly includes:

- browser-side WebHID diagnostics
- native protocol helpers
- Linux capture/crop prototypes
- macOS virtual display companions
- IMU recenter/smoothing/viewport mapping

It suggests a stronger branch inside `VR-apps-lab` around:

- head-tracked desktop helper patterns
- virtual display and viewport-crop utilities
- hardware protocol workbenches
- small menu-bar or tray control surfaces

## Family 101: MediaPipe camera tracking bridges for SlimeVR, VRChat, VRM, and virtual controllers

This family covers small camera/MediaPipe projects that convert webcam
landmarks into tracker rotations, avatar expressions, browser VRM animation,
Unity avatar landmarks, or virtual-controller messages. The reusable value is
in conversion boundaries, not production tracking quality.

| Project | Status | Notes |
|---|---|---|
| `TkskKurumi/SlimeVR-Tracker-Mediapipe` | Already studied | Python MediaPipe pose bridge that derives limb axes, smooths quaternions, uses pose-neighborhood calibration, and sends SlimeVR-style UDP tracker packets |
| `hotaru86/MediapipeFaceTracking_VRC` | Partially studied | Python webcam face tracker with bundled MediaPipe face-landmarker model and avatar-facing blendshape/parameter mapping intent |
| `how-people-lived/mediapipe-vrm-tracking` | Partially studied | Browser-only MediaPipe/VRM face, hand, and arm tracking demo with ARKit-compatible blendshape framing |
| `Metastazius/VRBodyTrack` | Partially studied | Python MediaPipe world-landmark server plus Unity avatar scene connected through length-prefixed Windows named-pipe text payloads |
| `vwitted/mediapipe_VR_controller` | Already studied as micro-utility | Minimal MediaPipe Hands wrist-landmark to `/VMT/Raw/Unity` OSC payload proof |

### Consolidation note

This family matters because camera tracking bridges reveal reusable conversion
seams:

- camera capture and model inference
- landmark confidence and visibility gates
- axes, quaternions, blendshapes, or simple positions
- smoothing and calibration
- target-specific UDP/OSC/pipe/browser output schemas

It suggests a stronger branch inside `VR-apps-lab` around:

- camera landmark bridge blueprints
- tracker/OSC payload schema comparison
- calibration and smoothing guardrails
- lightweight avatar or controller preview tools

## Family 102: Mixed reality capture, calibration, and presenter compositing helpers

This family covers mixed-reality capture and presenter-compositing utilities.
The reusable value is camera calibration, real/virtual layer splitting,
chroma-key or segmentation, video payload transport, external-camera repair,
and recording handoff.

| Project | Status | Notes |
|---|---|---|
| `fabio914/reality-mixer-js` | Already studied | WebXR/Three.js MRC module with JSON calibration schema, webcam/chroma setup, frame delay, foreground/background render targets, and browser compositor |
| `fabio914/RealityMixerVisionPro` | Partially studied | Vision Pro plus iPhone MRC stack with image tracking, camera pose updates, server/payload protocol, RealityKit foreground/background rendering, alpha extraction, and video encoding |
| `jonathanperret/mrc-client` | Already studied | Minimal Oculus MRC TCP client that parses typed length-prefixed frames, handles video dimensions, and pipes video data to `ffplay` |
| `zengmmm00/MixedRealityCapture` | Not studied deeply; source not released yet | Quest 3 MRC placeholder with open-source plan but no toolkit source in the current pass |
| `TonyViT/MrcXrtHelpers` | Already studied | Unity XRT/Oculus MRC helpers for default external camera intrinsics/extrinsics, tracking-space conversion, and repeated removal of unwanted tracked-pose drivers |
| `smaerdlatigid/ArtificialGreenScreen` | Already studied as capture helper | Browser BodyPix person segmentation tool that can provide artificial green-screen masks for OBS/capture workflows |
| `LIV/CalibrationForQuest` | Rejected empty repository | Empty clone in the current pass; kept only as a dedupe marker, not as a donor |

### Consolidation note

This family matters because MRC is a utility architecture, not just a media
feature. It now clearly includes:

- calibration schemas and setup wizards
- camera intrinsics/extrinsics and image tracking
- foreground/background virtual render passes
- chroma key and person segmentation
- TCP/video payload clients and encoders
- Unity/OVR external camera repair helpers

It suggests a stronger branch inside `VR-apps-lab` around:

- capture calibration helpers
- presenter/compositing utilities
- MRC diagnostics and protocol probes
- OBS/browser handoff references

## Family 103: VR treadmill locomotion hardware, input adapters, and virtual controller bridges

This family covers small locomotion-hardware projects where the reusable value
is not a specific treadmill product, but the bridge shape from raw sensor or
controller state into keyboard, virtual gamepad, OpenVR input components, BLE,
serial, or TCP.

| Project | Status | Notes |
|---|---|---|
| `fer-sler/VR-Treadmill` | Already studied as minimal bridge | Mouse Y delta polling, cursor recentering, smoothing, clamp, PyQt controls, and virtual Xbox gamepad stick output |
| `TimStewartJ/vr-treadmill` | Already studied | Windows mouse-to-ViGEm bridge with config/status objects, decay/deadzone, driver readiness probe, atomic settings, and cleanup reset |
| `Cycrus/slimstep_vr` | Already studied | Load-cell Arduino module plus OpenVR server driver exposing scalar trigger/trackpad/joystick inputs through serial COM capture |
| `jurassicjordan/GoobleBoxVR` | Already studied | Wii Balance Board Linux joystick reader with standing/walking/flamingo/jump/absence states and keyboard or virtual joystick output |
| `srepmub/tacovr` | Already studied as hardware firmware/control reference | Pixy sensor and stepper-based treadmill state machine with left/right calibration and serial diagnostics |
| `ssohbn/kittywalk-server` | Already studied as micro-utility | Tiny Rust TCP receiver for fixed-size treadmill byte payloads |
| `cybernetic-research/VR-treadmill-client-app` | Already studied | Unity/Quest controller joystick-state relay over TCP |
| `cybernetic-research/VR-treadmill-server-app` | Already studied | ESP32 BLE treadmill service with control/status characteristics and output-pin state |

### Consolidation note

This family matters because `locomotion hardware` is a bridge problem before it
is a product problem. It now clearly includes:

- raw sensor and joystick device capture
- calibration, thresholds, smoothing, and latency tradeoffs
- keyboard and virtual-gamepad output
- OpenVR controller scalar input exposure
- BLE, serial, and TCP command/status surfaces
- driver/device readiness and safe cleanup patterns

It suggests a stronger branch inside `VR-apps-lab` around:

- hardware-input bridge checklists
- virtual-controller readiness panels
- locomotion/accessibility input adapters
- serial/BLE/TCP ingress diagnostics

## Family 104: Unity VR experiment frameworks, data capture, and study orchestration helpers

This family covers Unity research frameworks where the reusable value is
repeatable session structure, trial generation, tracker logging, settings
provenance, data-handler abstraction, remote configuration, and upload
sidecars.

| Project | Status | Notes |
|---|---|---|
| `immersivecognition/unity-experiment-framework` | Already studied | UXF session/block/trial lifecycle with settings, data handlers, trackers, events, and typed data output routing |
| `BioMotionLab/TUX` | Already studied | Editor-authored experiment design files, variable system, runtime runner, GUI setup, output manager, and event-driven output |
| `jinwook31/Unity-Experiment-Trial-Manager` | Already studied as minimal baseline | Compact CSV trial manager with row reading, result writing, timer/logger helpers, and environment reset |
| `Nesbi/PsyWueVR` | Already studied | Psychology VR controller with subject representation, input defaults, blackout/instruction/status UI, and headtracking toggles |
| `social-spatial-interaction-lab/VR_Motion_Tracker` | Already studied as composition reference | UXF plus Unity MR/OpenXR template composition for pose/motion tracking shells |
| `SensoriMotorControlLab/vr_experiment_framework_v3` | Already studied | UXF/JSON task generator with settings prefixes, pseudo-randomization, linked variable lists, resume, and task/tracker components |
| `jackbrookes/uxf-s3-uploader` | Already studied | UXF write-file sidecar that uploads outputs to S3 with credential/bucket ScriptableObjects and async upload tracking |
| `jackbrookes/uxf-web-settings` | Already studied | Remote settings downloader with StreamingAssets fallback, participant metadata, session begin, and release-info logging |

### Consolidation note

This family matters because `repeatable VR utilities` often need the same
infrastructure as experiments: lifecycle, settings, trackers, output, and
deployment. It now clearly includes:

- session/block/trial lifecycle models
- CSV, JSON, remote, and editor-authored settings
- tracker and measurement-row abstractions
- local file, cloud upload, and fallback handlers
- resume, participant metadata, and release provenance

It suggests a stronger branch inside `VR-apps-lab` around:

- calibration and diagnostics study harnesses
- repeatable setup/test flows
- tracker/data capture sidecars
- remote-config and offline-fallback utility design

## Family 105: Immersive browser shells, WebXR runtimes, home spaces, and spatial web frontends

This family covers headset browsers and spatial web shells where the reusable
value is large-scale shell architecture: activity/bootstrap, session store,
windows, widgets, native render world, WebXR interstitials, environments,
runtime shims, and spatial home/front-end surfaces.

| Project | Status | Notes |
|---|---|---|
| `Igalia/wolvic` | Partially studied as large architecture reference | Standalone headset browser with activity shell, session store, windows/tabs, widgets, keyboard/tray/navigation, WebXR interstitial, environments, and native render world |
| `MozillaReality/FirefoxReality` | Partially studied as archived lineage reference | Historical Android VR browser with Gecko/VRB render world, WebXR rendering state, controllers, widgets, mover/resizer, and interstitial lineage |
| `MozillaReality/FirefoxRealityPC` | Partially studied as PC shell reference | Unity/OpenVR shell around Firefox Desktop with install/config readiness checks, action bindings, environment loaders, and launcher flow |
| `exokitxr/exokit` | Partially studied | JavaScript runtime with explicit WebXR session, input source, layer, hand/eye/gamepad, and extension-state modeling |
| `exokitxr/exokit-browser` | Already studied as thin shell reference | HTTPS static Exokit browser shell with interface, app, service worker, site list, keyboard assets, and API bridge |
| `exokitxr/exokit-frontend` | Already studied as frontend/menu reference | React frontend split into engine, DOM, console, launch, and menu surfaces |
| `madjin/home-space` | Already studied as product/UX reference | Spatial home/startpage scene with screens, media props, Janus assets, VRChat/Unity material, and lightweight media scripts |

### Consolidation note

This family matters because `browser-in-VR` exposes shell patterns that are
useful even for much smaller browser-backed utilities. It now clearly includes:

- browser runtime and session-store boundaries
- window, tab, panel, and widget management
- keyboard, navigation, tray, and permission surfaces
- WebXR interstitial and escape UX
- native render world placement/resizing/controllers
- JS WebXR runtime/session/input shims
- spatial homes and startpage rooms

It suggests a stronger branch inside `VR-apps-lab` around:

- browser-backed utility shells
- WebXR interstitial and permission UX references
- window/widget/session architecture matrices
- spatial home and launch-surface product references

## Family 106: Browser-native WebXR utility surfaces, creative tools, diagnostics, and data visualization

This family covers compact browser-native WebXR utilities where the main value
is a focused surface: creative input, hand menus, stereo media viewing,
diagnostics, visualizers, biometric streams, data dashboards, or streaming
viewer framing.

| Project | Status | Notes |
|---|---|---|
| `aframevr/a-painter` | Already studied | A-Frame VR painting tool with controller-specific mappings, brush-tip feedback, tooltip fade, save/load, URL import, and upload/share events |
| `leapmotion/LeapShape` | Already studied | Three.js/WebXR modelling tool with controller/hand input, pinch state, palm/secondary-hand menu placement, contextual tool slots, and OpenCascade backend |
| `zfox23/spatial-photo-webxr-viewer` | Already studied | Local-first Apple Spatial Photo HEIC conversion into side-by-side per-eye WebXR textures |
| `ivanik7/vr-screen-tester` | Already studied as micro-utility | React Three Fiber/WebXR headset pattern tester with color/glare patterns, FPS display, and XR control state |
| `kquizz/vr-visualizer-web` | Already studied | Audio-reactive Three.js/WebXR visualizer with inverted-sphere canvas texture, passthrough fallback, presets, and controller parameter modes |
| `Kineviz/OpenBCI-WebXR-EEG` | Already studied | OpenBCI data server plus Three.js EEG point cloud with device profile positions, shader attributes, and frequency/intensity mapping |
| `msitarzewski/prediction-space` | Already studied | WebXR data dashboard with volume/probability spheres, category zones, gaze hover, pinch selection, canvas-texture detail panels, and two-hand scene manipulation |
| `taplivenetwork/taplive-webxr` | Not studied deeply; source not present in current clone | README-level WebXR/WebRTC 360 streaming viewer framing with LiveKit/SFU/API intent but no source in this pass |

### Consolidation note

This family matters because `browser-native WebXR` is a practical utility
surface, not just a demo platform. It now clearly includes:

- controller-aware creative tools
- hand/palm contextual menu systems
- local-first stereo media conversion
- screen-pattern and FPS diagnostics
- audio-reactive and biometric visualizers
- gaze/pinch data dashboards
- WebRTC/360 streaming viewer product framing

It suggests a stronger branch inside `VR-apps-lab` around:

- WebXR utility-surface prototypes
- browser-native diagnostics and data dashboards
- hand/palm menu comparisons
- local-first media and visualization helpers

## Family 107: Quest app-management companions, patchers, mod packages, and metadata services

This family covers Quest utility tools where the reusable value is headset app
management rather than in-headset rendering: ADB bootstrap, sideloading,
launcher surfaces, APK patching/signing, mod package schemas, backup/version
metadata, and store metadata services.

| Project | Status | Notes |
|---|---|---|
| `SideQuestVR/SideQuest` | Already studied | Electron/Angular companion with managed platform-tools bootstrap, ADB wrapper, install-token tasks, blacklist hash checks, and install progress |
| `SideQuestVR/SideQuestAppLauncher` | Already studied | Android launcher/wrapper apps with app drawer, settings overlays, updater dialogs, adapters, and headset-local launcher UX |
| `Lauriethefish/QuestPatcher` | Already studied | ADB ownership hygiene, app filtering, binary manifest patching, OpenXR/hand/passthrough permission edits, mod directories, and patch/sign workflow |
| `Lauriethefish/QuestPatcher.QMod` | Already studied | QMOD ZIP/spec/schema with one `mod.json`, package metadata, mod/library files, cover images, and file-copy instructions |
| `ComputerElite/QuestAppVersionSwitcher` | Already studied | Backup metadata, APK/OBB/data detection, patch-state inspection, loopback/on-device ADB, downgrade/version tooling, and mod/version UX |
| `ComputerElite/OculusDB` | Already studied | Oculus GraphQL pagination, locale normalization, database/frontend/scraper split, and metadata backend for version tools |

### Consolidation note

This family matters because many headset utilities are `device companion
systems`, not overlays. It now clearly includes:

- managed ADB/platform-tools lifecycle
- APK install, patch, manifest, and signing flows
- mod package schema and file placement
- backup, downgrade, and durable app-state metadata
- headset-local launcher/updater surfaces
- store metadata indexing and service boundaries

It suggests a stronger branch inside `VR-apps-lab` around:

- Quest ADB doctor and app inventory helpers
- mod/package validators
- headset companion utility design
- backup/version metadata checklists

## Family 108: VMC/VRM OSC motion streams, receivers, senders, recorders, and exporters

This family covers VMC Protocol and adjacent motion-stream utilities where the
main value is a simple interoperable pose, tracker, controller, camera,
blendshape, record, and export layer.

| Project | Status | Notes |
|---|---|---|
| `sh-akira/VirtualMotionCapture` | Already studied | Unity runtime plus WPF control panel, memory-mapped IPC, external sender/receiver settings, tracker assignment, filters, and virtual tracker controls |
| `sh-akira/VirtualMotionCaptureProtocol` | Already studied | Role-based OSC/UDP protocol docs with Marionette/Performer/Assistant roles, default ports, message tolerance, and sample sender/receiver scripts |
| `gpsnmeajp/EasyVirtualMotionCaptureForUnity` | Already studied | Unity receiver package with packet limiter, freeze, root options, blendshape/bone filters, cutoffs, auto VRM load, validator, and daisy-chain |
| `sh-akira/QuestOSCTransformSender` | Already studied | Quest Unity sender for world/local HMD and controller transforms over VMC-style OSC |
| `infosia/vmc2bvh` | Already studied | C++ VMC listener that waits for calibration/VRM, maps VRM humanoid bones, samples motion, and exports BVH plus blendshape JSON |
| `infosia/vmcrec` | Already studied | C++ VMC recorder/replay/dump utility with FlatBuffers command schema, length-prefixed records, timestamps, and blendshape name tables |

### Consolidation note

This family matters because pose-stream tooling is a bridge layer used by many
VR utilities. It now clearly includes:

- OSC/UDP role and port conventions
- root, bone, tracker, HMD, controller, blendshape, and status messages
- receiver validation, filters, cutoffs, packet limiting, and daisy-chain
- Quest transform senders
- stream recording, typed logs, replay, and BVH export

It suggests a stronger branch inside `VR-apps-lab` around:

- VMC/OSC diagnostic receiver panels
- pose-stream capture and replay helpers
- protocol matrices across VMC, SlimeVR, VMT, VRChat OSC, and MediaPipe
- calibration-aware motion export tooling

## Family 109: Resonite/Neos social VR ecosystem tooling, manifests, SDKs, and diagnostics

This family covers Resonite/Neos ecosystem utilities where the reusable value
is not one mod, but the system around social VR: loaders, manifests, managers,
external SDKs, headless deployments, companion clients, and in-world metrics.

| Project | Status | Notes |
|---|---|---|
| `resonite-modding-group/ResoniteModLoader` | Already studied | Assembly discovery, single mod-class enforcement, config loading/versioning, Harmony conflict logs, duplicate checks, SHA256 logs, and headless detection |
| `Gawdl3y/Resolute` | Already studied | Tauri/Rust/Vue manifest-backed mod manager with cache staleness, installed-state reconciliation, artifact download/update/delete, and unrecognized mod handling |
| `resonite-modding-group/resonite-mod-manifest` | Already studied | Schema-first mod registry with categories, platforms, dependencies, conflicts, artifact SHA256, install locations, author folders, and generator scripts |
| `Yellow-Dog-Man/ResoniteLink` | Already studied | WebSocket command/response SDK and REPL for slots, components, assets, reflection, method calls, and batched data-model operations |
| `shadowpanther/resonite-headless` | Already studied | Docker/Kubernetes packaging with SteamCMD setup, persistent config/log volumes, env-driven beta/login, and start/setup scripts |
| `Nutcake/ReCon` | Already studied | Flutter companion client with secure login, cached session, API wrappers, reconnecting hub events, contacts, sessions, inventory, and messages |
| `esnya/ResoniteMetricsCounter` | Already studied | RML metrics/profiling mod with focused-world filters, blacklist/ignored hierarchy, per-stage/per-object storage, JSON traces, and UIX panels |

### Consolidation note

This family matters because social VR tooling is an ecosystem-management
problem. It now clearly includes:

- loader lifecycle and conflict diagnostics
- schema-first mod manifests and artifact hashes
- GUI mod manager cache/install/update/delete state
- external data-model WebSocket SDKs and REPLs
- headless deployment packaging
- social companion auth/API/hub clients
- in-world metrics and creator diagnostics

It suggests a stronger branch inside `VR-apps-lab` around:

- plugin/mod ecosystem governance
- manifest-backed manager blueprints
- external social-VR automation SDKs
- creator diagnostics and in-world metrics surfaces

## Family 110: DIY headset hardware bring-up, OpenVR drivers, firmware transports, and settings GUIs

This family covers DIY/open-source headset and controller projects where the
reusable value is the full physical-to-runtime chain: PCBs, firmware packets,
HID/UART/RF transports, IMU filtering, OpenVR HMD display components,
controller/tracker input components, calibration, and settings editors.

| Project | Status | Notes |
|---|---|---|
| `relativty/Relativty` | Already studied | Full DIY headset with PCB/Gerbers/STLs, Arduino HID firmware, OpenVR driver factory, HID quaternion ingestion, optional TCP position, and pose update threads |
| `HadesVR/HadesVR` | Already studied | Rich DIY ecosystem with HMD display settings, direct/desktop modes, distortion/IPD/FOV, RF/HID/UART firmware, controller/tracker packets, OpenVR input components, filters, and docs |
| `HadesVR/Wand-Controller` | Already studied | Controller PCB and firmware with RF24 payloads, IMU/Madgwick filtering, role switches, joystick/trigger/battery/finger/grip fields, and calibration docs |
| `HadesVR/Basic-HMD-PCB` | Already studied | Beginner HMD PCB with EasyEDA/Gerber/schematic assets, Pro Micro/FastIMU/NRF24 reference, serial calibration, VID/PID lookup, and LED error codes |
| `JX5S/HadesVR_GUI_Tool` | Already studied | Qt settings editor for HadesVR `default.vrsettings`, typed category/key map, ordered JSON writer, and driver/display/HMD/controller/tracker defaults |
| `dmcke5/DIY_VR_Controllers` | Already studied | HadesVR-compatible 3D printed controller variant with KiCad/STL/BOM assets and added joystick/trigger calibration routine |
| `dietzus/DietzVR` | Rejected; current clone contains no reusable source | Local clone contained only license metadata, so no donor or product reference value was extracted |

### Consolidation note

This family matters because hardware utility work is mostly about bring-up
discipline and diagnostics. It now clearly includes:

- firmware packet schema and transport choices
- OpenVR HMD display component anatomy
- display geometry, distortion, IPD, direct/desktop mode settings
- controller, skeleton, haptic, scalar, button, and tracker input components
- IMU filtering, Kalman/Madgwick, and calibration UX
- PCB/BOM/Gerber/STL repository structure
- settings GUI and ordered JSON config editing

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenVR HMD bring-up anatomy
- hardware transport diagnostics
- driver settings editors
- controller input component mapping
- hardware documentation templates

## Family 111: VR keyboard, text-entry, avatar keyboard, and OSC input surfaces

This family covers VR text-entry and control-input projects where the reusable
value is how a user enters text or emits control state while staying in VR:
modal keyboards, raycast/canvas keyboards, physical fingertip keys, native
OpenVR keyboard bridges, and VRChat OSC input emitters.

| Project | Status | Notes |
|---|---|---|
| `danielbuechele/react-360-keyboard` | Already studied | React 360 modal keyboard with promise-returning NativeModule flow, configurable initial value/placeholder, emoji, dictation, and fade lifecycle |
| `erosmarcon/vr-keyboard` | Already studied | Three.js canvas-texture keyboard with layouts, raycaster collision, target-field binding, and key events |
| `jcorvinus/VRKeyboard` | Already studied | Unity physical keyboard with fingertip orientation gates, press throw, hover/activate events, and audio feedback |
| `mrowrpurr/VR_Keyboard` | Already studied | OpenVR keyboard bridge for Skyrim VR mods with overlay polling, Papyrus API, and non-VR fallback routing |
| `anosatsuk124/VRC-KeyboardController-in-VR_OSC` | Already studied | Rust/egui keyboard-to-VRChat OSC input emitter with movement/look addresses and reset cadence |
| `killfrenzy96/KillFrenzyVRCAvatarKeyboard` | Already studied as deprecated historical reference | Avatar-contained keyboard lineage using parameter sync, finger colliders, FX/expression setup, and a clear platform-breakage caveat |

### Consolidation note

This family matters because text entry is still a frequent blocker for useful
VR utilities. It now clearly includes:

- modal keyboard service boundaries
- browser-native raycast keyboard layouts
- fingertip/physical keypress interaction
- native OpenVR keyboard polling
- host-script fallback routing
- VRChat OSC control emitters and reset cadence
- avatar-contained keyboard platform-risk lessons

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable VR text-entry service patterns
- overlay keyboard and host-mod bridges
- VRChat OSC accessibility/control tools
- input-surface comparison matrices

## Family 112: VR subtitles, captions, STT/OCR accessibility, and projection-aware subtitle tooling

This family covers accessibility and information surfaces where the reusable
value is text/audio comprehension in VR: subtitle queues, speaker/FOV
placement, dialogue progression, stereo media subtitles, screenshot captioning,
speech/translation overlays, OCR capture regions, and VRChat chatbox bridges.

| Project | Status | Notes |
|---|---|---|
| `bjennings76/vr-subtitles` | Already studied | Unity subtitle director with queue, priority sorting, WPM duration, speaker roosting, FOV behavior, portrait UI, and fade lifecycle |
| `AhhhhHeyyy/VR-Subtitles-WIP` | Already studied as WIP prototype | Compact TMP subtitle/dialogue queue with wait-for-input progression, callbacks, and canvas display |
| `CarlUpright/VR_SUBTITLES_BURNERRR` | Already studied as projection-aware micro-utility | FFmpeg/PowerShell stereo-360 top-bottom subtitle burn-in with per-eye split/burn/vstack and geometry-aware sizing |
| `zacharykeeler/VR-Subtitles-in-Unreal-5` | Partially studied as report-only UX reference | Unreal subtitle UX comparison across fixed, character/comic, portrait/backing-plane, and HMD-fixed approaches |
| `akbartus/WebVR-Captioning` | Already studied | A-Frame screenshot-to-caption prototype with remote model call, scene annotation, timeout, and captured-photo feedback |
| `DanielCirry/STTS` | Partially studied as large overlay stack | SteamVR STT/translation/OCR overlays with typed message log, CJK fonts, OCR control overlays, Tauri/Python split, and VRChat OSC chatbox |

### Consolidation note

This family matters because accessibility surfaces are reusable overlay
surfaces. It now clearly includes:

- subtitle timing, priority, and lifecycle
- speaker-roosted and FOV-stabilized placement
- dialogue wait-for-input queues
- projection-aware stereo media subtitle burn-in
- WebXR screenshot-to-caption loops
- speech/translation overlay histories
- OCR capture controls and feedback surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- caption/subtitle placement matrices
- STT and translation companion overlays
- OCR-assisted information panels
- projection-aware immersive media helpers

## Family 113: SteamVR operational support, lifecycle automation, dynamic performance, and Linux driver helpers

This family covers utilities that support VR runtime operation rather than
displaying user content: startup/shutdown script runners, dynamic SteamVR
settings controllers, Linux device-permission packages, and vendor driver
proxy/helper stacks.

| Project | Status | Notes |
|---|---|---|
| `BOLL7708/OpenVRStartup` | Already studied as archived lifecycle micro-utility | OpenVR overlay app that registers autolaunch, runs `start/*.cmd`, waits for `VREvent_Quit`, acknowledges quit, and runs `stop/*.cmd` |
| `Erimelowo/OpenVR-Dynamic-Resolution` | Already studied | Frametime/CPU/VRAM feedback controller for SteamVR supersampling with app gates, dashboard gates, manual override checks, and ImGui/tray UI |
| `ValveSoftware/steam-devices` | Already studied as Linux device-permission reference | Canonical udev HID/raw permission inventory for SteamVR/HTC/Valve/Bigscreen devices |
| `CertainLach/VivePro2-Linux-Driver` | Partially studied as vendor driver proxy/reference | Linux Vive Pro 2 proxy driver with OpenVR vtable wrapping, typed settings/properties, HID config/control, and install packaging |

### Consolidation note

This family matters because runtime-support tools reduce user friction before a
visible overlay can even work. It now clearly includes:

- SteamVR application manifests and autolaunch
- startup/shutdown automation and quit-event handling
- frametime/VRAM feedback loops
- SteamVR settings writes and safety gates
- Linux udev/device-permission packaging
- proxy-driver and vendor HID support patterns

It suggests a stronger branch inside `VR-apps-lab` around:

- SteamVR lifecycle helper design
- runtime settings controllers
- Linux VR setup doctors
- driver proxy anatomy references
- high-risk support-boundary documentation

## Family 114: Focused overlay micro-surfaces, situational HUDs, and OCR-assisted workflow panels

This family covers small utility surfaces where one focused value is enough:
dashboard tabs, QR scanners, media-control windows, browser/OBS game HUDs,
VRChat OSC control panels, and OCR-backed workflow overlays.

| Project | Status | Notes |
|---|---|---|
| `MetroTS/AdressableOverlaySteamVR` | Partially studied as early/incomplete status-dashboard sketch | WinForms/OpenVR concept with HMD/controller battery, playtime, FPS, and search UI framing |
| `haolink/VRCOSCAvatarScaleOverlay` | Already studied | Unity SteamVR dashboard overlay with render-texture submission, mouse/keyboard event forwarding, autolaunch, OSCQuery, and VRChat avatar-scale OSC |
| `Psychpsyo/VR-QR-Overlay` | Already studied | C++ OpenVR mirror-texture QR scanner with SDL/GLEW, quirc, controller-relative result overlay, and haptic feedback |
| `Rycia/OVR-Deck` | Rejected; current clone contains no reusable source | Local clone contained only README/license metadata |
| `ToxicOrca/VR-Music-Remote` | Already studied as window-captured micro-utility | Tkinter media remote with Windows Global Media Session metadata, album art, media keys, hidden cursor, topmost window, and VR-readable marquee |
| `DavidDriessen/EchoVR-Overlay` | Already studied as browser/OBS telemetry HUD reference | Vue/Express local API proxy and game-state HUD with scoreboard, players, stats, score event, and minimap |
| `etiennechabert/ez-wishlist-overlay` | Partially studied as strong overlay/OCR/workflow donor | Rust desktop plus SteamVR overlay with OpenVR worker, action bindings, world anchoring, mirror-texture OCR, feedback card, settings, persistence, and domain data |

### Consolidation note

This family matters because small overlays are often the quickest path from
idea to reusable utility. It now clearly includes:

- Unity dashboard overlay skeletons
- native OpenVR situational recognition overlays
- Desktop+-captured standard-window HUDs
- browser/OBS telemetry surfaces
- OCR-assisted VR workflow panels
- overlay-host decision points

It suggests a stronger branch inside `VR-apps-lab` around:

- overlay micro-surface blueprints
- dashboard overlay vs captured-window comparisons
- OCR/checklist workflow panels
- focused telemetry and media-control HUDs

## Family 115: Audience chat overlays, stream-facing browser surfaces, and captured-window HUD patterns

This family covers stream/audience overlays that are not VR-native by default
but are strong references for captured windows, browser-source panels,
transparent sidecars, chat/event fan-in, and configuration UX.

| Project | Status | Notes |
|---|---|---|
| `baffler/Transparent-Twitch-Chat-Overlay` | Already studied as transparent desktop chat overlay donor | WPF/WebView2 overlay with setup vs overlay mode, border and interaction toggles, top-most state, hotkeys, persistent JSON settings, jChat/native chat integration, sounds, OAuth, and BTTV/FFZ/7TV options |
| `Enubia/ghost-chat` | Already studied as multi-provider transparent chat sidecar | Go/Wails/React companion with transparent always-on-top window, tray actions, Twitch/YouTube/Kick clients, config/window-state persistence, and vanish/click-through mode |
| `giambaJ/jChat` | Already studied as static browser-source chat renderer | URL-parameter configured chat renderer with message queue/pruning/fade, Twitch badges, BTTV/FFZ/7TV emote loading, blocked users, and style controls |
| `BenDMyers/showmy.chat` | Already studied as overlay URL builder and preview reference | Validated query-parameter contract, live preview iframe, three-step form, demo URL generation, and copyable overlay URL onboarding |
| `teklynk/twitch_chat_emotes` | Already studied as animated emote/event overlay | Browser overlay with provider fan-in, API fallback, TMI reconnect handling, bounded emote display, and movement/effect options |

### Consolidation note

This family matters because many useful VR utility surfaces can begin as
transparent desktop windows or browser-source panels before they become native
OpenVR/OpenXR overlays. It now clearly includes:

- setup mode vs live overlay/click-through mode
- captured-window chat HUDs
- browser-source query-string configuration
- chat, badge, and emote provider normalization
- stream/audience event-to-visual overlays
- onboarding with live preview and copyable URLs

It suggests a stronger branch inside `VR-apps-lab` around:

- browser-backed overlay configuration contracts
- audience/chat companion surfaces for VR
- provider-normalized notification and chat panels
- Desktop+/captured-window bridge references

## Family 116: VR creative authoring, drawing/modeling tools, and in-headset tool/menu systems

This family covers VR creative tools where the reusable value is not the art
output itself but the tool architecture: catalogs, panels, shelves, commands,
save/load, export, scripting, multiplayer, and in-headset menu systems.

| Project | Status | Notes |
|---|---|---|
| `googlevr/tilt-brush` | Partially studied as large archived Unity creative-tool architecture reference | App-state lifecycle, brush/environment catalogs, pointer/controller systems, panels, sketch load/export, tutorial hints, HTTP load callback, and global command surfaces |
| `icosa-foundation/open-brush` | Partially studied as active Tilt Brush evolution with API/multiplayer donor value | Modern XR/OpenXR direction, Lua/API wrappers across app/brush/camera/color/environment/group/guide/headset/image/layer, Photon multiplayer, RPC batching, and voice paths |
| `googlevr/blocks` | Partially studied as archived VR modeling command/export reference | Proto-backed command messages, add/copy/delete/move/replace/group mesh operations, face property changes, OBJ/FBX/glTF/export and asset-service flows |
| `SideQuestVR/SideSketch` | Fork / variant only | Tilt Brush fork with SideQuest rebrand/distribution lessons and limited unique architecture beyond upstream |
| `zach-capalbo/vartiste` | Partially studied as browser-native WebXR authoring and shelf/tool reference | A-Frame brush system, brush packs/user brushes, movable shelf component with pin/close/hide behavior, upload/interceptor flows, and avatar/spectator/Hubs references |

### Consolidation note

This family matters because complex VR utilities need the same foundations as
creative tools: tool switching, mode clarity, undo/history, persistent assets,
and in-headset configuration. It now clearly includes:

- app-state and loading lifecycles
- brush/tool/environment catalogs
- Unity panel managers and WebXR shelves
- command-object/proto edit histories
- save/load/export and asset upload paths
- scripting/API and multiplayer extension points
- fork lineage and distribution caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- VR menu, shelf, and tool-surface comparison matrices
- command/history patterns for editor-like utilities
- creative-tool API boundaries
- Unity vs WebXR authoring-surface architecture

## Family 117: Networked/social XR frameworks, room clients, and multi-user state substrates

This family covers social/networked XR infrastructure where the reusable value
is room membership, presence, permissions, state sync, avatars, media, voice,
and collaborative diagnostics rather than one specific social world.

| Project | Status | Notes |
|---|---|---|
| `UCL-VR/ubiq` | Already studied as research-friendly network scene and room substrate | Node room server, TCP/WSS wrappers, ICE provider, Unity/browser room clients, network scene, peer events, WebRTC connections, avatars, voice, arbitrary network IDs, and component statistics |
| `mozilla/hubs` | Partially studied as large WebXR social room client reference | Phoenix room channel, permission tokens, presence, mute/kick, spawn camera/drawing/media actions, pinning, voice/chat, streaming/recording/raise-hand/typing events, and bitECS networked components |
| `janusvr/janusweb` | Already studied as historical spatial-web room/client reference | Declarative viewer/frame custom elements, image/video/model/avatar room snippets, chat, VoIP/networking options, binary WebSocket connection, URL-hash room subscribe/unsubscribe, and reconnect lifecycle |
| `vrsys/vrsys-core` | Partially studied as Unity Netcode/XRI/Meta Avatar composition reference | Unity prefab/package composition with Netcode manager, user spawner, connection manager, desktop/HMD/Meta Avatar user prefabs, network prefab lists, and collocation settings |

### Consolidation note

This family matters because collaborative VR utilities need a small,
inspectable room substrate before they need a full social platform. It now
clearly includes:

- room servers and room clients
- peer connection and signaling paths
- presence and identity events
- permission-gated room actions
- networked ECS/component state
- declarative spatial-web embeds
- Unity prefab/package composition

It suggests a stronger branch inside `VR-apps-lab` around:

- collaborative diagnostics and remote support rooms
- permission/presence checklists for VR utilities
- networked component state references
- spatial web and media-room embedding patterns

## Family 118: OpenGloves sidecars, protocols, named-pipe input, OSC ingress, and force-feedback adapters

This family covers OpenGloves/LucidGloves ecosystem helpers where the reusable
value is custom hand-device integration: calibration UI, protocol contracts,
named-pipe input, OSC ingress, serial encodings, synthetic tests, and
force-feedback adapters.

| Project | Status | Notes |
|---|---|---|
| `LucidVR/opengloves-ui` | Already studied as Tauri/Svelte calibration and control sidecar | Local driver HTTP boundary on port `52060`, configuration/functions/settings routes, reset, pose calibration, servo calibration, and minimal Tauri shell |
| `LucidVR/opengloves-protocol` | Already studied as protobuf communication contract reference | Driver input tracking-reference service, server output device info and stream shells, and force-feedback curl input service |
| `PerlinWarp/pygloves` | Already studied as Python named-pipe tester and hand visualization harness | Packed finger/joystick/button writes, left/right pipe helper, Matplotlib sliders/buttons, and SteamVR-hand pose visualization |
| `senseshift/opengloves-lib` | Already studied as C++ data model and alpha serial encoding helper | Hand/device types, finger curl/splay, joystick/buttons, analog buttons, output force feedback/haptics, and alpha serial encode/decode |
| `Rin-Wilson/CS-OpenGloves-Named-Pipe-Input-Library` | Already studied as C# named-pipe input helper | v2 pipe path, 20-value flexion struct, splay, joystick, booleans, trigger value, managed marshaling, and pipe write |
| `Python1320/opengloves-osc` | Already studied as OSC-to-named-pipe ingress micro-bridge | OSC receiver on port `9007` mapping joystick/button addresses into a C# named-pipe input struct |
| `LucidVR/opengloves-force-feedback-unity-demo` | Already studied as Unity/SteamVR force-feedback adapter demo | Interactable injection, skeleton-pose curl estimation, left/right FFB providers, and curl pipe writes |
| `LucidVR/opengloves-hl-alyx-integration` | Already studied as game-log/file-watcher force-feedback sidecar | Tauri/Svelte UI and C# sidecar that tails tagged game output, parses five curl values per hand, supports hand inversion, and writes to FFB curl pipes |

### Consolidation note

This family matters because custom hand hardware is an integration stack, not
one app. It now clearly includes:

- driver sidecar calibration UI
- schema-first driver/server protocol contracts
- named-pipe binary input structs
- OSC ingress for external tools
- serial/alpha firmware encoding helpers
- synthetic hand input and visualization tests
- Unity and game-log force-feedback adapters
- version-sensitive pipe and struct compatibility caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- hand-device transport matrices
- custom controller/glove bridge patterns
- OSC/named-pipe/serial adapter comparison
- force-feedback adapter safety boundaries

## Recommended synthesis path for `VR-apps-lab`

The next useful step is not another long unsorted list.

It is:

1. build product concepts around `families`, not repos;
2. prioritize deep dives where status is `Partially studied` or
   `Not studied deeply`;
3. keep forks/variants as comparison nodes instead of promoting each one to a
   full standalone research wave.
