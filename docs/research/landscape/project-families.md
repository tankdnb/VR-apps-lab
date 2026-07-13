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
| `I5UCC/ParameterSaveStates` | Deepened in Wave 324 | SteamVR dashboard and local Web UI for VRChat per-avatar parameter profiles |
| `hai-vr/h-view` | Already studied | Desktop-plus-overlay utility host with OSCQuery tooling, hardware views, and strong overlay-management slices |
| `MeroFune/GOpy` | Already studied as OSC gesture-parameter to HMD-relative overlay icon bridge | Additional control/integration utility candidate now promoted through Wave 153 |

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
| `Denwa/vive-wireless-info-overlay` | Source-light product reference for Vive Wireless temperature micro-overlays | Wireless-temperature micro-overlay whose product framing is stronger than its visible code donor value |
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
| `Nexz/turncountervr` | Already studied as cable-awareness rotation counter micro-overlay | Rotation counter / cable-awareness overlay node |
| `Martin-Oehler/SteamVR-WebApps` | Already studied | Thin browser-backed dashboard wrappers built on top of `SteamVR-Webkit` |
| `Mon-Ouie/launcher-openvr-overlay` | Already studied | Linux launcher shell that hands app windows and videos off to external display tools such as `gamescope` and `vr-video-player` |
| `Mon-Ouie/mpris-openvr-overlay` | Already studied | Very small egui-based media-state and transport-control surface over the desktop `MPRIS` bus |
| `Mon-Ouie/vr-video-player-overlay` | Already studied | Focused `window or video -> VR display surface` path with flat, plane, sphere, and overlay modes |
| `iigomaru/MPVR` | Deepened in Wave 208 | Rough libmpv-in-overlay proof of concept that is weaker as a product but useful as a lower-bound direct media-engine texture donor |
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
| `OpenDisplayXR/OpenDisplayXR-VDD` | Inaccessible during latest remote check; keep as signal-only backlog node | Sparse but relevant signal for a simulated OpenVR/OpenXR virtual hardware path |
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
| `Marlamin/VROverlayTest` | Already studied as C# OpenTK/OpenVR texture submission scratchpad | Additional ultra-thin Windows baseline for managed OpenVR texture submission |
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
| `tobexeon/PSVR2EyeTrackingCalibration` | Already studied as real-time PSVR2 eye-gaze calibration client | Nine-point OpenXR gaze calibration scene, localhost IPC start/stop commands, averaged X/Y offset persistence, and custom PSVR2Toolkit fork dependency |

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
| `MasonSakai/VR-AI-Full-Body-Tracking` | Deepened in Wave 210 | Camera FBT comparison node with browser camera inference, MoveNet, multi-camera triangulation, dampened tracker output, and InputEmulator-era caveats |

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
| `nakama-lab/VR_Teleop_Interface` | Deepened in Wave 211 | Architectural comparison node for broader teleoperation interface decomposition, topic contracts, and command/status/error sequence docs |
| `h2r/GHOST` | Deepened in Wave 211 | Unity/Quest ROS teleoperation frontend with mode manager, controller commands, robot joint publishing, and point-cloud/depth hooks |

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
| `Sharrnah/whispering` | Already studied as local multimodal speech/OCR/TTS platform with websocket overlay and VRChat OSC fan-out | Broad local speech platform whose VR value comes from OSC, websocket overlays, browser remote commands, and chatbox pacing rather than a single overlay |
| `Hotrian/OpenVRTwitchChat` | Already studied | Twitch-chat overlay reference with a stronger in-headset presentation bias |
| `MeroFune/GOpy` | Already studied as OSC gesture-parameter to HMD-relative overlay icon bridge | Smaller integration-helper comparison node that adds an OSC-to-overlay communication angle |
| `I5UCC/VRCTextboxSTT` | Already studied | Local speech-to-text helper where the SteamVR overlay is one output surface among others |
| `gt0777/VRCLiveCaptionsMod` | Already studied | App-internal speech surface comparison node from the accessibility and social boundary |
| `rrazgriz/VRCMicOverlay` | Already studied | Minimal status-overlay node for avatar-facing communication state |
| `Larsundso/SteamVR-Discord-Overlay` | Already studied | Rich Discord-local-IPC overlay with message subscriptions, button overlays, and a localhost control dashboard |
| `Artemol/DiscOverlay` | Already studied | Thin Unity shell around the Discord Streamkit voice widget with an in-VR positioning dashboard |
| `imagitama/steamvr-overlay-vrbuddy` | Already studied | Remote companion visualization overlay that renders another person's head and hands in your local playspace |
| `beareogaming/BD-XSOverlay-notify` | Already studied as BetterDiscord to XSOverlay WebSocket notification bridge | BetterDiscord plugin that treats an existing external overlay host as the render target for notifications |

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
| `maximum-game-22/openxr-3d-display` | Fork / variant only; canonical upstream studied as dfattal/openxr-3d-display | Monado-derived spatial-display comparison node |
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
| `takana-v/quest_steamvr_fbt_tool` | Already studied as simple OpenVR-to-VRChat OSC FBT tracker bridge in Wave 163 | Quest/PC SteamVR tracker serial config, null-driver setup note, OpenVR pose polling, and `/tracking/trackers` OSC sender |

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
| `Yukiiro-Nite/notebook-vr-overlay` | Deepened in Wave 208 | Rough note-surface prototype with image surface, mouse/event plumbing, tracked-device placement, and incomplete writing workflow |

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
| `Daniel-Webster/WT-OpenVR-Overlay` | Deepened in Wave 208 | Broader Unity overlay app over a local webservice, useful as a Unity telemetry overlay and OVRLay scaffold node |
| `kurohuku7/zenn-overlay-tutorial` | Already studied as tutorial-grade OpenVR overlay lifecycle reference | Tutorial-first note for Unity or SteamVR overlay learning rather than a mainline code donor |

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
| `Wulkop/VolumeVR` | Deepened in Wave 208 as weak donor | `CEF`-backed narrow media or volume shell whose public repo mainly exposes runtime bootstrap logic |

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
| `emymin/EmyOverlay` | Already studied as C++ OpenGL/ImGui OpenVR overlay skeleton | Thin effect-overlay node now useful as an offscreen OpenGL/ImGui texture-submission baseline |

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
| `VRLabs/Camera-System` | Partially studied; Wave 158 deepened avatar-authored OSC camera-path companion architecture | Avatar-side OSC camera-path system with VPM package, expression menu/parameters, contacts/constraints/physbones path capture, companion executable, preview, B-spline, loop, circle, and closed-loop path settings |
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
| `eisclimber/ExPresS-XR` | Partially studied; Wave 155 deepened data-gathering, value-range, socket, menu, and toolkit primitives | Scientific/exhibition toolkit with configurable rig, movement presets, data gathering, quizzes, value-range interactables, sockets, menus, HUDs, and tutorial helpers |
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
| `GodotVR/godot-xr-tools` | Already studied as Godot XR function-node toolkit | Modular XR scene pack with gaze/pointer/pickup/pose/teleport/movement functions, hands, interactables, desktop support, effects, staging, rumble, settings, exported properties, and configuration warnings |
| `GodotVR/godot-xr-template` | Already studied | Starter project with OpenXR action map, XR Tools wiring, OpenXR Vendors dependency, and Android export feature toggles |
| `GodotVR/godot_openxr_for_godot_3.x` | Partially studied | Legacy Godot 3 OpenXR backend with interface/config/action/pose/hand/skeleton/extension wrapper boundaries |
| `GodotVR/godot_openxr_vendors` | Already studied as Godot OpenXR vendor extension stack with export feature gates | Godot 4 GDExtension stack for Android XR, Meta, Pico, Lynx, Magic Leap, Khronos, passthrough, anchors, depth, body/face/hand, scene, render-model, performance metrics, composition layers, docs, and export-plugin features |
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
| `kscalelabs/kbot_vr_teleop` | Deepened in Wave 211 | React/WebXR headset frontend with hand/controller tracking, robot/video surfaces, Python IK, UDP robot command schema, pause gates, convergence checks, and feedback |
| `dwaitbhatt/xarm_vr_teleop` | Already studied | Headset-free SteamVR/OpenVR controller-to-xArm bridge with null-driver setup, pose deltas, IK/control modes, trigger gripper, haptics, and menu exit |
| `NVlabs/collab-sim` | Partially studied | Isaac Sim/OpenXR VR robot teleop with CuRobo IK/MPC, controller follower frames, button managers, reset callbacks, data logging, and replay |
| `wengmister/franka-vr-teleop` | Partially studied | Quest hand-pose stream through ROS2/UDP/TCP/ADB reverse into weighted IK, Ruckig joint velocity, smoothing, pause/recenter, and pose visualization |
| `nakama-lab/VR_Teleop_Interface` | Deepened in Wave 211 | Unity/Quest/ROS2/ZED/Franka bridge documentation with stereo feed, controller publishers, force/torque-to-rumble feedback, ROS TCP topics, and command/status/error sequences |
| `open-thought/cambot` | Deepened in Wave 211 | WebXR stereo camera-arm telepresence with HTTPS/WebSocket, WebRTC fallback, VR HUD, head-pose IK, safety bounds, watchdog, pause, home, and transport controls |
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
| `jakedowns/xreal-webxr` | Deepened in Wave 209 | Browser WebHID workbench with XREAL/Nreal device filtering, Air/Light managers, input-report parsing, IMU packet polling, firmware command scaffolding, and packet logging |
| `alexwilson1/nreal_linux_test` | Deepened in Wave 209 as Linux/X11 POC | GStreamer/OpenCV screen capture POC with left/right gaze calibration, yaw normalization, and multi-monitor viewport slicing for Nreal Air |
| `Mailbot/Nreal_Air_Desktop_tool` | Deepened in Wave 209 as product reference only | Thin desktop-control framing for Nreal Air; useful as product reference but not a current code donor |
| `edwatt/real_utilities` | Deepened in Wave 209 | Native protocol utility around Nreal Air device commands, reports, packet build/parse, CRC, and calibration reads |
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
| `hotaru86/MediapipeFaceTracking_VRC` | Deepened in Wave 210 | Python webcam face tracker with MediaPipe face-landmarker model, ARKit/VRCFT mapping, parameter tuning, JSON persistence, and OSC output |
| `how-people-lived/mediapipe-vrm-tracking` | Deepened in Wave 210 | Browser-only MediaPipe/VRM face, hand, and arm tracking demo with avatar preview, mapping editor, JSON export, and ARKit-compatible blendshape framing |
| `Metastazius/VRBodyTrack` | Deepened in Wave 210 | Python MediaPipe world-landmark server plus Unity avatar/body analysis scene connected through length-prefixed Windows named-pipe text payloads |
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
| `icosa-foundation/open-brush` | Already studied as Open Brush creative app/API/sketch-load/export and brush/toolchain donor | Modern XR/OpenXR direction, external `.tilt` load handling, user sketch path management, Lua/API/editor/doc generators, brush tooling, export pipelines, Photon multiplayer, RPC batching, and voice paths |
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

## Family 119: WebXR engine export bridges, device-display adapters, layers, and test/showcase scaffolds

This family covers browser-XR infrastructure where the reusable value is
engine export, feature gating, display adaptation, composition layers,
deterministic testing, and product-scale WebXR examples.

| Project | Status | Notes |
|---|---|---|
| `De-Panther/unity-webxr-export` | Already studied as Unity WebXR loader/settings/export bridge | Unity XR loader and WebGL bridge with JSON reference-space/feature settings, framebuffer scale, manager/input autoload, subsystem gating, camera/controller event handling, and haptics |
| `Rufus31415/Simple-WebXR-Unity` | Already studied as minimal Unity WebXR bridge and editor simulator | One-component Unity WebXR bridge with enter AR/VR UI, shared JS/C# arrays, left/right input state, select/squeeze events, hit-test data, per-eye cameras, and editor simulator |
| `Looking-Glass/looking-glass-webxr` | Already studied as non-HMD WebXR display adapter | Polyfill-backed XRDevice adapter for Looking Glass displays with supported reference spaces, canvas/window lifecycle, and multi-view/quilt projection synthesis |
| `immersive-web/webxr-layers-polyfill` | Already studied as composition-layer polyfill and renderer reference | Session patching, XRWebGLBinding/XRMediaBinding injection, projection/quad/cube/cylinder/equirect layers, media textures, stereo layouts, and GL renderer separation |
| `immersive-web/webxr-test-api` | Already studied as deterministic WebXR fake-device test API reference | Testing-only simulated XR device/input/control surface for views, poses, tracking loss, select events, hit-test worlds, and DOM overlay pointer coordinates |
| `meta-quest/webxr-showcases` | Already studied as feature-gated Quest/WebXR showcase reference | WebXR product examples for anchors, hit-test, plane detection, measurement, controller motion, pointer modes, and configurator UI |

### Consolidation note

This family matters because browser-XR tools can become no-install utilities,
diagnostic panels, public demos, and custom display experiments. It now clearly
includes:

- Unity-to-WebXR loader and minimal bridge patterns
- explicit reference-space and feature manifests
- editor fake-device simulation
- custom non-HMD XR display adaptation
- composition-layer session patching and media/layer rendering
- deterministic fake XR devices for tests
- feature-gated showcase UX for AR/VR scenes

It suggests a stronger branch inside `VR-apps-lab` around:

- browser-XR utility shells
- WebXR feature/support matrices
- no-HMD/fake-device browser test surfaces
- WebXR media/layer placement references

## Family 120: Browser-based XR editors, live-coding sandboxes, visual workspaces, and scene tooling

This family covers editor-like browser and XR tools where the reusable value is
scene/project structure, asset APIs, realtime documents, source-code visual
workspaces, in-VR live coding, templates, and readable 3D UI/text.

| Project | Status | Notes |
|---|---|---|
| `playcanvas/editor` | Already studied as browser editor architecture and realtime asset/document reference | Method bus, observer history, asset virtual paths, realtime document loading, scene presence rooms, plugin actions, texture LOD tooling, and OBJ export |
| `tentone/nunuStudio` | Already studied as self-contained scene editor and VR-toggle studio | Local project files, action history, resource crawler, tabs, run/stop lifecycle, selection tree, shortcuts, and VR entry/exit toggle |
| `pmndrs/triplex` | Already studied as source-code-driven React Three Fiber visual workspace | JSX metadata extraction, transform tracking, provider injection, scene virtual modules, editor panels, preview renderer, and screenshot rendering |
| `brianpeiris/RiftSketch` | Already studied as in-VR live-coding sandbox | VR text panels, scene interception and cleanup, localStorage sketches, runtime function evaluation, error feedback surfaces, and monitor/editor toggles |
| `teliportme/remixvr` | Already studied as template-based VR creation and classroom publishing reference | Flask/React backend/frontend with classrooms, activities, submissions, reactions, short codes, and A-Frame/WebVR template packages |
| `protectwise/troika` | Already studied as Three.js facade/UI/text infrastructure donor | Facade/world classes, 3D UI blocks, flex layout, dat-gui facade, SDF glyph generation, worker utilities, instanced/batched text, and derived materials |

### Consolidation note

This family matters because many VR utilities are small editors: calibration
workspaces, diagnostic scenes, menu builders, reference panels, authoring
surfaces, and live-debug environments. It now clearly includes:

- browser editor method buses and observable histories
- asset virtual paths and plugin actions
- local project files and action bundles
- source-code-driven scene metadata extraction
- in-VR live-code and error surfaces
- template-based publishing and response loops
- 3D text, flex, facade, worker, and SDF infrastructure

It suggests a stronger branch inside `VR-apps-lab` around:

- editor-like utility architecture
- scene/project/action-history matrices
- in-headset developer and scripting surfaces
- readable 3D text/UI checklists

## Family 121: VRM/avatar web stacks, model specs, runtime loaders, and browser avatar/mocap surfaces

This family covers VRM/avatar infrastructure where the reusable value is model
contracts, humanoid mapping, expressions, look-at, first-person visibility,
spring bones, constraints, loaders, components, and browser mocap/avatar
surfaces.

| Project | Status | Notes |
|---|---|---|
| `vrm-c/UniVRM` | Already studied as Unity VRM runtime/editor/import/export stack | Unity import/export/migration, viewers, humanoid mapping, metadata callbacks, expression controls, look-at, first-person samples, spring-bone runtime toggles, and WebGL file helpers |
| `pixiv/three-vrm` | Already studied as modular Three.js VRM loader/runtime | GLTFLoader plugin composition for meta, humanoid, expressions, first-person, look-at, spring bones, node constraints, MToon materials, VRM object assembly, and runtime update loop |
| `binzume/aframe-vrm` | Already studied as A-Frame VRM component layer | `vrm`, `vrm-anim`, `vrm-skeleton`, `vrm-poser`, and `vrm-mimic` components for loading, first-person, blink/look-at, animation, pose get/set, skeleton debug, and simpleIK mimic |
| `ButzYung/SystemAnimatorOnline` | Already studied as browser avatar/mocap and XR Animator lineage reference | XR Animator, VRM/MMD/BVH/FBX motion support, AI webcam/media motion capture, audio-reactive animation, MMD physics workers, transparent/desktop host modes, and child animations |
| `vrm-c/vrm-specification` | Already studied as canonical VRM spec/schema contract source | VRM 0.0/1.0 specs and schemas for humanoid, first-person, expressions, look-at, spring bones, extended colliders, node constraints, MToon, animation, metadata, and license semantics |

### Consolidation note

This family matters because avatar utilities sit between runtimes, trackers,
face inputs, OSC/VMC streams, and creator tools. It now clearly includes:

- Unity runtime/editor/import/export avatar workflows
- Three.js modular loader plugin composition
- declarative A-Frame avatar components
- browser avatar/mocap product surfaces
- expression, look-at, spring-bone, first-person, and constraint contracts
- schema-first validation and compatibility boundaries

It suggests a stronger branch inside `VR-apps-lab` around:

- avatar preview/checker utilities
- VRM runtime capability matrices
- VMC/MediaPipe/VRChat/VRM bridge comparisons
- avatar metadata/license/support-boundary notes

## Family 122: WebAR marker/image tracking, model-viewer AR surfaces, and lightweight scene-understanding utilities

This family covers browser AR and mixed-reality placement references where the
reusable value is target compilation, marker/image/face/location tracking,
A-Frame component wrappers, AR model placement fallbacks, hit-test, planes,
anchors, light, depth, and debug surfaces.

| Project | Status | Notes |
|---|---|---|
| `hiukim/mind-ar-js` | Already studied as image/face tracking, compiler, and A-Frame integration reference | Image target compiler/offline compiler, runtime controller, target dimensions, target found/lost/update events, face landmark anchors, face mesh entities, camera mirroring, and occluders |
| `AR-js-org/AR.js` | Already studied as marker, NFT, and location-based WebAR stack | Three.js marker controls/context/source, A-Frame marker events, barcode/NFT examples, GPS camera/entity placement, simulated locations, distance display, smoothing, and look-at labels |
| `akbartus/Simple-AR` | Already studied as minimal WebAR starter and cross-framework reference | Small A-Frame starter with camera/target setup, on-video-started and target-distance framing, plus Three.js/Babylon-style example folders |
| `chenzlabs/aframe-ar` | Already studied as A-Frame WebXR AR helper component layer | `ar` scene component, AR camera projection takeover, images, anchors, planes add/update/remove events, AR raycaster helpers, and feature absence handling |
| `google/model-viewer` | Already studied as production AR model-viewer component and fallback UX reference | Web component with WebXR/Scene Viewer/Quick Look mode detection, AR/poster/exit slots, hotspot and annotation surfaces, platform fallback, and hit-derived surface data |
| `tentone/enva-xr` | Already studied as environment-aware WebXR AR renderer | Feature-negotiated immersive-ar renderer with hit-test, anchors, plane detection, light estimation, reflection cube maps, depth sensing, depth textures, debug depth canvas, and GUI overlay container |

### Consolidation note

This family matters because MR utility tools need reliable placement and
scene-understanding patterns before they need a full app. It now clearly
includes:

- image target compilation and runtime tracking controllers
- marker, NFT, and location-based WebAR components
- minimal AR onboarding starters
- A-Frame AR source/camera/raycaster/plane wrappers
- production AR model-viewer fallback and hotspot UX
- WebXR AR hit-test, anchors, planes, light, and depth renderer anatomy

It suggests a stronger branch inside `VR-apps-lab` around:

- browser AR placement matrices
- target/marker/location utility diagnostics
- AR annotation and hotspot surfaces
- WebXR scene-understanding debug panels

## Family 123: WebXR hand tracking, hand input surfaces, and hand-data bridges

This family covers browser-native hand tracking where the reusable value is
raw joint streams, pinch and release events, fingertip rays, hand-role splits,
direct manipulation, and exporting hand pose to external tools.

| Project | Status | Notes |
|---|---|---|
| `marlon360/webxr-handtracking` | Already studied as WebXR hand joint, pinch gesture, fingertip ray, and A-Frame component donor | `XRHand` joint cache, `getJointPose`, visibility/radius/orientation state, A-Frame hand components, pinch hysteresis, fingertip raycaster, drawing, mesh, and physics hooks |
| `TakashiYoshinaga/webxr-hand-tracking-sample` | Already studied as minimal pinch drawing and hand-role split sample | Right-hand pinch creates boxes and draws along movement; left-hand pinch clears scene; visible fingertip marker and simple color cycling |
| `rick98033/webxr-hand-tracking-websocket` | Already studied as Babylon WebXR hand-pose WebSocket bridge | Babylon hand feature enablement, 13-joint subset, handedness selection, rate-limited JSON telemetry, auto-reconnect, callbacks, and receiver examples |
| `danielklinkhammer/webxr-quest2` | Already studied as Quest/A-Frame passthrough hand-grab micro-demo | Transparent AR scene, hand-tracking required feature, pinch midpoint grab, nearest interactable selection, hover/active color feedback, and fallback laser rays |

### Consolidation note

This family matters because controllerless VR utilities need simple, reliable
input patterns before they need full gesture-recognition systems. It now
clearly includes:

- raw WebXR hand joint streams
- pinch start/release thresholds and hysteresis
- fingertip raycasting
- direct pinch-midpoint object grabbing
- left/right hand role assignment
- hand pose telemetry over WebSocket
- passthrough-friendly hand UI defaults

It suggests a stronger branch inside `VR-apps-lab` around:

- hand-first overlay/menu controls
- hand tracking diagnostics and latency surfaces
- WebXR hand-to-OSC/WebSocket bridges
- small controllerless calibration and annotation tools

## Family 124: Immersive 360 video players, stereo projection, and local media surfaces

This family covers immersive media viewers where the reusable value is
projection awareness, stereo layout, in-headset playback controls, local file
intake, browser/Tauri packaging, and Vision Pro-style format explanation.

| Project | Status | Notes |
|---|---|---|
| `greggman/webxr-video` | Already studied as modular WebXR video viewer with renderer/UI split | WebGL/WebGPU/WebXR Layers variants, viewer/session orchestration, canvas UI texture, controller-to-pointer mapping, playlist directory scanning, projection and stereo settings |
| `brandynbuchanan/VR180-video-player` | Already studied as minimal A-Frame VR180 stereoscopic player | `a-videosphere`, left/right stereoscopic flag, video asset, simple control panel, play/pause, timeline indicator, and seek sketch |
| `ProGamerGov/html-360-viewer` | Already studied as one-file 360 image/video viewer and stereo-toggle utility | Single HTML file with drag/drop, query URL loading, mono/top-bottom/side-by-side toggles, zoom, fullscreen, screenshot, and video controls |
| `thehancode/360-video-player` | Already studied as Tauri/Svelte local 360 video player shell | Tauri file picker/drop, `convertFileSrc`, Svelte selector/view switch, Video.js, `videojs-vr`, and local desktop packaging |
| `acuteimmersive/openimmersive` | Already studied as Vision Pro projection/frame-packing immersive video player | Equirectangular/rectilinear/AIVU projection options, side-by-side/over-under packing, FOV, baseline, disparity, gallery/file/HLS sources, and immersive attachments |

### Consolidation note

This family matters because media utilities are format utilities. It now
clearly includes:

- 180/360 and equirectangular/rectilinear projection controls
- stereo layout and frame-packing choices
- in-headset canvas UI surfaces
- local file and drag/drop intake
- browser one-file inspection tools
- desktop shells around browser media players
- Vision Pro spatial/immersive format settings

It suggests a stronger branch inside `VR-apps-lab` around:

- projection-aware media diagnostics
- stereo/packing/FOV vocabulary
- local media QA viewers
- video surfaces for browser-backed overlay panels

## Family 125: Audio-reactive WebXR surfaces, spatial sound visualizers, and shader pipelines

This family covers sound-aware VR/WebXR projects where the reusable value is
audio source intake, analyser pipelines, normalized audio features, frequency
buckets, shader uniforms, audio textures, and spatial sound feedback.

| Project | Status | Notes |
|---|---|---|
| `shift/webxr-audio-visualizer` | Already studied as stereo microphone and directional AR waveform visualizer | Audio permission gate, stereo microphone constraints, channel splitter, left/right analysers, source objects, position smoothing, waveform rings, and glow intensity |
| `Alex-DG/vite-three-webxr-audio-visualizer` | Already studied as Three/WebXR audio-feature-to-shader-uniform visualizer | p5 sound FFT/amplitude analysis, spectral centroid/volume mapping, optional waveform, AR button with DOM overlay, sphere and particle shader uniforms |
| `ConorStokes/boondoggle` | Already studied as native Oculus/D3D audio texture and shader package visualizer | WASAPI loopback capture, KissFFT, smoothing, frequency bucketing, sound texture/SRV, D3D renderer, JSON effect package compiler, shader/sampler/effect validation |
| `DranoelMit/seeSound` | Already studied as A-Frame WebAudio frequency-bin geometry visualizer | Media element source, analyser bins, upload object URL, bars/cubes spawned around user, per-frame geometry scale updates |

### Consolidation note

This family matters because audio can be a diagnostic and context signal, not
only media playback. It now clearly includes:

- microphone and media-element audio sources
- WebAudio analyser and FFT paths
- normalized audio feature vectors
- stereo/directional visual feedback
- frequency-bin geometry widgets
- native loopback capture and audio textures
- shader package separation for visual effects

It suggests a stronger branch inside `VR-apps-lab` around:

- audio diagnostics overlays
- channel balance and microphone permission surfaces
- ambient sound-aware HUD widgets
- reusable audio-to-visual feature pipelines

## Family 126: WebXR runtime frameworks, session/input feature managers, and testable spatial UI substrates

This family covers framework-level WebXR foundations where the reusable value
is session lifecycle, reference-space management, feature registration, input
abstraction, hand tracking, DOM overlay, layers, locomotion, spatial UI, and
runtime/test control surfaces.

| Project | Status | Notes |
|---|---|---|
| `mrdoob/three.js` | Already studied as minimal renderer-level WebXR manager and controller/hand space reference | `WebXRManager`, target-ray/grip/hand groups, session start/end, controller events, WebXR layers/depth hooks, `VRButton`, and reference-space-offset teleport example |
| `BabylonJS/Babylon.js` | Already studied as WebXR session manager, experience helper, and feature manager stack | Session manager observables, experience helper, feature manager contracts, session-init extension, hand tracking, DOM overlay, layers, hit-test, anchors, movement, and teleportation |
| `playcanvas/engine` | Already studied as evented XR service taxonomy and hand/input subsystem model | `XrManager` services for input, DOM overlay, hit-test, anchors, planes, meshes, light, views, graphics binding, evented input sources, hand rays, and squeeze emulation |
| `facebook/immersive-web-sdk` | Already studied as ECS/action/spatial-UI framework with runtime-first dev tooling | XR input manager, primary source selection, multi-pointers, visual adapters, action-backed locomotion, spatial UI compiler, layers, runtime session file, CLI/MCP-like XR control tools |

### Consolidation note

This family matters because future browser-backed utilities need a substrate,
not just standalone samples. It now clearly includes:

- renderer-owned WebXR session managers
- feature manager and session-init extension patterns
- typed XR capability service objects
- target-ray, grip, and hand coordinate spaces
- hand squeeze/ray abstractions
- DOM overlay and layer surface wrappers
- action-backed locomotion and spatial UI compilation
- runtime-first dev/test control surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- WebXR utility shell architecture
- browser XR feature manager prototypes
- testable no-HMD browser XR workflows
- controller/hand/action abstraction comparisons

## Family 127: A-Frame GUI, locomotion, and reusable interaction component primitives

This family covers A-Frame component-level building blocks where the reusable
value is widget schemas, flex-like layouts, teleport rays, semantic
interaction events, menu factories, lifecycle cleanup, and hand-tracking press
surfaces.

| Project | Status | Notes |
|---|---|---|
| `rdub80/aframe-gui` | Already studied as declarative A-Frame widget, layout, and interaction component library | GUI item, interactable, flex container, labels, buttons, icon buttons, toggles, radio controls, progress bars, sliders, input, Troika text, hover/focus/active state, and style schemas |
| `fernandojsg/aframe-teleport-controls` | Already studied as parabolic/line teleport ray and landing-validation helper | Custom start/end events, parabolic and line ray modes, hit/miss visualization, collision entities, landing normal/max-angle validation, and camera-rig repositioning |
| `wmurphyrd/aframe-super-hands-component` | Already studied as semantic hover/grab/stretch/drag/drop/click interaction layer | Controller/hand/mouse/touch event normalization, cancelable semantic events, hover ordering, reaction components, grab/drop promotion, and mouse-like dispatch |
| `Minty-Crisp/AUXL` | Already studied as broad A-Frame world/menu factory and utility-shell construction kit | AUXL system, object cores, layers, scene/world tracking, menus, multi-menus, mega menus, hover menus, scroll menus, inventory, movement, physics, weather, and external loading |
| `SvetimFM/aframe-webxr-ui-toolkit` | Already studied as lifecycle-managed menu registry and hand-tracking pressable toolkit | `BaseMenu`, `MenuRegistry`, cleanup-aware elements/listeners, active menu switching, button/text input helpers, bounding-box hand press detection, pinch/ray/gaze helpers |

### Consolidation note

This family matters because WebXR utilities need reliable controls before they
need large app frameworks. It now clearly includes:

- declarative A-Frame widget schemas
- flex-like VR panel layout
- ray-based teleport and landing validation
- semantic hover/grab/stretch/drag/drop/click events
- world/menu factory stacks
- menu lifecycle cleanup and active-menu switching
- hand-tracking press surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- browser VR settings/help panels
- A-Frame utility menu shells
- controller/hand/mouse fallback input comparison
- reusable interaction vocabularies for small WebXR tools

## Family 128: Immersive analytics, spatial data visualization, and scientific viewer substrates

This family covers data-rich VR/WebXR visualization projects where the
reusable value is visualization grammars, graph accessors, scientific viewer
state managers, snapshots, XR input mapping, notebook data bridges, and volume
or graph transfer formats.

| Project | Status | Notes |
|---|---|---|
| `vriajs/vria` | Already studied as immersive analytics grammar, spatial view compiler, and selection/filter callback surface | React/A-Frame `VRIA` component, config compiler, datasets, marks, axes, legends, filters, scales, tooltips, custom marks, builder UI, and selection/filter callbacks |
| `vasturiano/3d-force-graph-vr` | Already studied as VR force-graph scene shell with controller/mouse raycasters and tooltips | Kapsule wrapper, embedded A-Frame scene, camera group, movement controls, tooltips, mouse cursor, laser raycasters, node/link callbacks, particles, and d3 force pass-throughs |
| `vasturiano/aframe-forcegraph-component` | Already studied as A-Frame force graph component with accessor schemas and raycaster events | Component schema for graph data/accessors, JSON/function parsers, loading/info text, `ThreeForceGraph` binding, raycaster intersection details, and click handlers |
| `molstar/molstar` | Already studied as scientific viewer plugin shell with managers, snapshots, Canvas3D, and XR input mapping | Plugin context, command/state managers, Canvas3D params, XR manager, viewer pose, controller rays, passthrough toggle, input-source mapping, camera/selection/focus snapshots |
| `widgetti/ipyvolume` | Already studied as notebook-to-WebGL 3D data bridge with synced traits and volume texture tiling | Python traitlets, scatter/volume sync, selection/hover/click state, image/volume serializers, texture tiling, Three renderer, stereo/panorama/cube settings, and embed exports |

### Consolidation note

This family matters because diagnostics and research utilities need data
surfaces, not only control panels. It now clearly includes:

- immersive analytics config compilers
- spatial views, axes, legends, marks, filters, and selections
- graph accessor schemas and raycaster hover/click
- scientific viewer managers and command/state buses
- restorable viewer snapshots
- XR input mapping for scientific viewers
- notebook-to-browser 3D data transport
- volume tiling and embed/export paths

It suggests a stronger branch inside `VR-apps-lab` around:

- VR diagnostics visualization grammars
- data-rich overlay or browser utility panels
- graph and topology viewers for runtime/device state
- session snapshot and replay-friendly scientific/diagnostic viewers

## Family 129: WebRTC remote rendering, WebXR streaming, and bidirectional input/control channels

This family covers remote rendering and thin-client VR architectures where the
reusable value is video streaming, signaling, peer negotiation, data channels,
input remoting, pose/control protocols, WebXR video projection, and deployment
or matchmaker shells.

| Project | Status | Notes |
|---|---|---|
| `FusedVR/VRStreaming` | Already studied as WebXR-to-Unity pose/control data-channel and VR camera streaming prototype | Binary VR data types for pose, buttons, axes, display, enter/exit VR, remote input receiver, coordinate conversion, multi-camera render textures, video tracks, bitrate/framerate control |
| `Unity-Technologies/UnityRenderStreaming` | Already studied as Unity signaling, peer, data-channel, and browser input-remoting stack | Browser input remoting messages, peer negotiation wrapper, glare handling, data channel base, render streaming settings, signaling manager, handler registration, and command-line overrides |
| `Unity-Technologies/com.unity.webrtc` | Already studied as low-level Unity WebRTC peer connection and data-channel primitive layer | Peer connection events, tracks, transceivers, offer/answer flow, data channel options, ordered/retransmit settings, byte messages, and lifecycle delegates |
| `EpicGamesExt/PixelStreamingInfrastructure` | Already studied as Unreal Pixel Streaming WebXR video projection and HMD/eye/gamepad client | JSON signaling protocol, data channel controller, keyboard/mouse input handlers, WebXR controller, XR-compatible WebGL canvas, video texture projection, and selective eye/HMD messages |
| `Azure/Unreal-Pixel-Streaming` | Already studied as deployment-oriented Unreal signaling and matchmaker shell | Express signaling server, frontend proxy, auth/logging, Application Insights, STUN config, matchmaker ports/keepalive/retry, static routes, lifecycle scripts, and Azure deployment helpers |

### Consolidation note

This family matters because remote VR utilities can separate rendering from
headset-side sensors and controls. It now clearly includes:

- WebRTC video tracks and render textures
- browser/Unity input remoting
- typed pose, button, axis, display, and session-mode messages
- peer wrappers and signaling managers
- low-level Unity data-channel primitives
- WebXR streamed-video projection for Unreal
- selective structural vs per-frame XR messages
- signaling and matchmaker deployment shells

It suggests a stronger branch inside `VR-apps-lab` around:

- remote diagnostics and support rooms
- thin headset clients for desktop/engine utilities
- pose/control data-channel schemas
- streamed VR dashboard surfaces

## Family 130: Social/world framework shells, scene schemas, and multi-user spatial app substrates

This family covers shared spatial runtime foundations where the reusable value
is scene schema, semantic graph parsing, world packaging, networked object
identity, MQTT/WebSocket/Jitsi media flows, headless avatar clients, app
modules, and world/player managers.

| Project | Status | Notes |
|---|---|---|
| `phoenixbf/aton` | Already studied as scene JSON, semantic graph, spatial UI, media, Photon, and avatar platform | `ATON` namespace, `SceneHub` JSON parsers, scene/semantic graphs, environment, soundscape, nav, measurements, viewpoints, XPF network, SUI roots, Photon users, avatars, chat, focus, and media panels |
| `PlumCantaloupe/circlesxr` | Already studied as Networked-AFrame world shell with avatar templates, ownership, and object-world identity | Generated world parts, `networked-scene`, avatar manager, user-networked component, object-world metadata, networked-basic clone/ownership/visibility flow, websocket attach/detach events, and world settings |
| `arenaxr/arena-web-core` | Already studied as MQTT-backed A-Frame scene client with hands, Jitsi media, screenshare, prompts, and spatial audio | ARENA systems/components, user head/name/mic/Jitsi, hand pose/button MQTT publishing, Jitsi video surfaces, screenshare registry, SweetAlert text input, WebRTC positional audio patch, and remote-render visibility |
| `BasisVR/Basis` | Already studied as Unity/social VR networking, headless clients, compressed avatar sync, and avatar loading stack | Transport registry, connection abstractions, server probes, headless console clients, DID auth, fake pose generator, movement sender, avatar bit packing, bone compression, avatar buffers, loading/fallback gates |
| `webaverse-studios/webaverse` | Already studied as browser app-runtime, dynamic import, world/app manager, and player manager substrate | `App` object components/events, dynamic import manager, component templates, postMessage comms proxies, world `AppManager`, realm loading, local/remote players, app managers, and React/DOM UI boundary |

### Consolidation note

This family matters because collaborative utilities need room, user, media,
and object state boundaries. It now clearly includes:

- JSON scene and semantic graph parsing
- generated Networked-AFrame world shells
- network clone vs object-world identity
- MQTT scene-user messages
- Jitsi/WebRTC spatial media surfaces
- DOM prompt to scene-event bridges
- headless avatar clients and compressed avatar packets
- dynamic app modules and world/player app managers

It suggests a stronger branch inside `VR-apps-lab` around:

- shared VR diagnostics rooms
- collaborative browser utility shells
- synthetic/headless clients for load tests and replay
- scene/schema comparisons across analytics, world, and app-runtime families

## Family 131: Glanceable telemetry, simulator panels, and situational VR micro-overlays

This family covers compact status surfaces where the reusable value is not a
large overlay shell, but a narrow state loop: pose-derived comfort, device
temperature, GPU health, simulator telemetry, or chat readability inside a VR
host.

| Project | Status | Notes |
|---|---|---|
| `Nexz/turncountervr` | Already studied as cable-awareness rotation counter micro-overlay | HMD pose polling, facing-quadrant crossing counter, dashboard overlay texture refresh, and comfort framing |
| `Denwa/vive-wireless-info-overlay` | Source-light product reference for Vive Wireless temperature micro-overlays | Strong product framing around adapter thermal state, but current public donor surface is README/screenshot level |
| `yydsok520/gpu-vram-monitor` | Already studied as Windows GPU/VRAM telemetry overlay with tray, fan, and power-limit controls | LibreHardwareMonitor polling, `nvidia-smi` power-limit bridge, fan control, topmost layered window, tray shell, and cleanup safety |
| `JMmayranpaa/RacingManager` | Already studied as iRacing shared-memory telemetry panels and app launcher | iRacing memory-mapped telemetry reader, Qt topmost draggable overlays, overlay manager, and detached app launcher config |
| `ironsled/vr-twitch-chat-ui` | Already studied as MSFS VR-aware Twitch chat panel with readability profiles | Twitch IRC WebSocket, VR detection, persistent settings, transparent panel mode, emote cache, reconnect watchdog, and separate VR typography profiles |

### Consolidation note

This family matters because many useful VR utilities should be glanceable,
small, and state-specific. It now clearly includes:

- pose-derived comfort counters
- device-specific thermal status
- desktop hardware telemetry that can feed VR-visible surfaces
- simulator shared-memory telemetry panels
- in-host chat panels with VR readability profiles

It suggests a stronger branch inside `VR-apps-lab` around:

- a `glanceable status surface` checklist
- telemetry-source adapters separated from overlay presentation
- simulator panels and comfort micro-tools
- VR typography/readability profiles for narrow utility windows

## Family 132: Protocol-driven overlay bridges, external overlay hosts, and minimal implementation baselines

This family covers projects where the reusable value is the boundary between a
producer, a protocol, an overlay host, and a renderer. It complements the larger
overlay-host families by keeping the minimum implementation shapes visible.

| Project | Status | Notes |
|---|---|---|
| `MeroFune/GOpy` | Already studied as OSC gesture-parameter to HMD-relative overlay icon bridge | AsyncIO OSC server, VRChat gesture parameters, left/right icon overlays, HMD-relative placement, alpha fading, and config file |
| `beareogaming/BD-XSOverlay-notify` | Already studied as BetterDiscord to XSOverlay WebSocket notification bridge | Message filters, markdown sanitization, avatar icon handling, XSOverlay `SendNotification` envelope, queueing, and reconnect backoff |
| `OrangeJuicy69/VRC-NexusChat` | Source-light product reference for VRChat OSC companion chat/HUD concepts | Electron/React/TypeScript and OSC-to-VRChat framing, but visible public source is not enough for code reuse |
| `kurohuku7/zenn-overlay-tutorial` | Already studied as tutorial-grade OpenVR overlay lifecycle reference | Overlay key/name, handle invalidation, `CreateOverlay`, error handling, cleanup, and SteamVR Overlay Viewer teaching path |
| `emymin/EmyOverlay` | Already studied as C++ OpenGL/ImGui OpenVR overlay skeleton | Framebuffer-backed ImGui rendering, GL texture submission, overlay manager, and controller-ray mouse emulation |
| `Marlamin/VROverlayTest` | Already studied as C# OpenTK/OpenVR texture submission scratchpad | Invisible GL context, OpenVR overlay bootstrap, image-to-texture upload, `Texture_t` submission, and minimal transform setup |

### Consolidation note

This family matters because future overlay utilities need clear roles:

- event producer
- protocol bridge
- overlay host
- renderer
- tutorial baseline

It suggests a stronger branch inside `VR-apps-lab` around:

- an overlay-host protocol matrix
- minimal overlay implementation guides by stack
- OSC/WebSocket bridge envelopes with failure-policy notes
- source-light companion apps kept separate from true code donors

## Family 133: Virtual displays, spatial-display OpenXR runtimes, and desktop fallback surfaces

This family covers projects that make display targets exist or make XR content
usable outside a normal headset path: Linux virtual monitors, spatial-display
OpenXR runtimes, stereo viewers, historical DIY display concepts, and no-HMD
desktop fallbacks.

| Project | Status | Notes |
|---|---|---|
| `VirtualDrivers/Linux-Virtual-Display-Driver` | Already studied as Linux xrandr/EDID virtual display manager with GTK workflow | CVT modeline generation, xrandr output state, virtual EDID, NVIDIA xorg config, GDM monitor handling, persistence, and GTK cards |
| `dfattal/openxr-3d-display` | Already studied as canonical DisplayXR spatial-display OpenXR runtime | Monado-derived runtime, state tracker/compositor/driver/display-processor split, handle/texture/hosted/IPC app classes, and shell/controller policy separation |
| `maximum-game-22/openxr-3d-display` | Fork / variant only; canonical upstream studied as dfattal/openxr-3d-display | Keep only as comparison node unless it materially diverges from the canonical DisplayXR runtime |
| `newilia/SbsImageViewer` | Already studied as OpenXR stereo image viewer with launcher and projection controls | SBS/separate-file source handling, Tk launcher, drag/drop, remembered path, GL texture creation, labels, and in-XR angular controls |
| `r57zone/VR-Display` | Source-light historical DIY HDMI/MIPI display concept reference | Hardware BOM/checklist signal around display controller, STM32 gyro, IMU, power, brightness, and axis tests |
| `tejasXR/Virtual-Desktop-VR` | Source-light historical Unity/SteamVR virtual desktop POC | Old Unity/SteamVR project with little current donor surface; useful mainly as historical desktop-in-VR signal |
| `Malcolmnixon/GodotXRDesktop` | Already studied as Godot no-HMD synthetic XR tracker/action fallback addon | Synthetic `XRPositionalTracker`/`XRControllerTracker`, `XRServer` registration, desktop movement/head-look, and Input Map to OpenXR action injection |

### Consolidation note

This family matters because `display surface` is a broader problem than classic
VR overlay rendering. It now clearly includes:

- OS-level virtual monitor creation
- special-display OpenXR runtime architecture
- stereo media viewer surfaces
- historical DIY display bring-up concepts
- no-HMD engine fallback through synthetic trackers and actions

It suggests a stronger branch inside `VR-apps-lab` around:

- virtual display workflow matrices
- spatial-display runtime boundary notes
- desktop/no-HMD development paths
- projection/source-aware media utility surfaces

## Family 134: Hand tracking, simulated XR hands, and reusable hand/control primitives

This family covers hand/control work at three levels: runtime extension data,
engine pose/action simulation, and toolkit-level interaction/data primitives.

| Project | Status | Notes |
|---|---|---|
| `joemarshall/openxrhands` | Already studied as Unity OpenXR hand joint and hand mesh extension bridge | Custom `OpenXRFeature`, `xrWaitFrame` predicted time hook, `XR_EXT_hand_tracking`, `XR_FB_hand_tracking_mesh`, joint location, skinned mesh creation, and Unity conversion |
| `MThogersen/AutoHandSimulator` | Already studied as AutoHand no-HMD hand/body interaction simulator | Mock HMD detection, pose-driver replacement, keyboard/mouse body/head/hand modes, grab/release triggers, and reset behavior |
| `InfernoDigital/RoboHands-UnityXR` | Source-light product reference for Unity XR hand-pose package framing | Gesture-pose inventory and onboarding framing, but visible source is not enough for code reuse |
| `eisclimber/ExPresS-XR` | Partially studied; Wave 155 deepened data-gathering, value-range, socket, menu, and toolkit primitives | Data gatherer, value-range interactables, socket highlighting, virtual hands, movement modes, HUDs, setup dialogs, and editor menu factories |

### Consolidation note

This family matters because hand support should be reusable even before a final
input stack is chosen. It now clearly includes:

- OpenXR extension-level hand joints and meshes
- no-HMD/editor hand simulation
- product-level gesture-pose vocabulary
- data-gathering and interaction primitives from scientific XR toolkits

It suggests a stronger branch inside `VR-apps-lab` around:

- no-HMD hand/control testing matrices
- hand extension vs engine package comparisons
- reusable hand-pose vocabulary
- Unity toolkit primitive extraction only when a prototype needs it

## Family 135: OpenXR/VRCFT eye-face modules, calibration clients, and avatar facetracking preparation

This family covers the path from vendor/runtime tracking data to avatar-ready
facetracking: OpenXR module boundaries, remote tracking packet ingress,
expression normalization, avatar-side authoring packages, and calibration UX.

| Project | Status | Notes |
|---|---|---|
| `regzo2/VRCFaceTracking-QuestProOpenXR` | Already studied as archived Quest Pro OpenXR/VRCFT expression-mapping reference | VRCFT `ExtTrackingModule`, Oculus runtime switch/restore, native bridge DLLs, Meta/FB face and eye expressions, gaze conversion, and archived/broken caveat |
| `korejan/VRCFT-ALXR-Modules` | Already studied as local/remote ALXR VRCFT module donor | Local OpenXR/ALXR session config, headless/simulated-headless modes, extension selection, remote TCP packet ingress, One Euro filters, and hot-reloaded sensitivity profiles |
| `PawlygonStudio/VRC-Facetracking` | Already studied as avatar-side facetracking package, threshold editor, and OSC cleanup donor | Unified Expression/ARKit prefabs, controller assets, Unity threshold editor, JSON import/export, warnings around low thresholds, and local OSC config cleanup after upload |
| `tobexeon/PSVR2EyeTrackingCalibration` | Already studied as real-time PSVR2 eye-gaze calibration client | OpenXR red-dot calibration scene, trigger-based gaze sampling, Documents offset file, localhost IPC start/stop, and custom PSVR2Toolkit fork caveat |

### Consolidation note

This family matters because face/eye tracking is not one integration point. It
now clearly includes:

- vendor OpenXR face/eye data extraction
- local and remote tracking ingress
- extension and headless-session selection
- expression normalization into avatar-ready shapes
- avatar authoring packages and threshold tooling
- calibration clients and persistent offsets

It suggests a stronger branch inside `VR-apps-lab` around:

- facetracking setup checklists
- tracking-ingress module patterns
- calibration UX comparison
- avatar-side authoring and cleanup workflows

## Family 136: VRChat chatbox, speech/TTS, AI companions, and text-composition sidecars

This family covers VRChat text utilities where the reusable value is composing,
pacing, previewing, voicing, or automating text before it reaches the chatbox or
OSC parameters.

| Project | Status | Notes |
|---|---|---|
| `S0L0GUY/NOVA-AI` | Already studied as AI assistant, memory, multimodal input, and VRChat OSC tool-calling sidecar | YAML config/prompt split, Gemini Live loop, audio queues, screenshot tools, SQLite memory, typed tool definitions, chatbox pagination, typing state, and avatar action OSC tools |
| `MaurerKrisztian/vrc-tts-osc` | Already studied as TTS, virtual-audio, and chatbox micro-utility | Tkinter settings, OpenAI/ElevenLabs TTS, selected audio output device, `ttsoutput.mp3`, virtual-cable microphone routing, chatbox echo, and typing indicator |
| `hollyntt/XOSC` | Already studied as Linux-native chatbox telemetry and status composer | Raylib/ImGui C# UI, Linux `/proc` and `/sys` telemetry, `playerctl` and `xdotool` media sources, weather/network/status/manual overrides, and raw `/chatbox/input` OSC packets |
| `TheArmagan/advosc` | Already studied as visual chatbox editor, placeholder engine, avatar parameter control, and OSC forwarder | Electron/Svelte shell, OSC sockets, avatar schema watcher, simple block editor, advanced template editor, placeholder modules, recursion guard, and typed interval OSC forwarder |

### Consolidation note

This family matters because chatbox output is often the most reachable
headset-visible surface for VRChat users. It now clearly includes:

- AI assistant to chatbox/tool bridge
- TTS plus virtual microphone routing
- typing state and chatbox pagination
- Linux status and media telemetry
- placeholder and template engines
- visual block editors for nontechnical users
- arbitrary typed OSC forwarding from resolved templates

It suggests a stronger branch inside `VR-apps-lab` around:

- chatbox pacing and pagination rules
- text template engine comparisons
- TTS/audio routing setup patterns
- chatbox versus overlay versus avatar-parameter presentation decisions

## Family 137: VRChat OSC telemetry, avatar scaling, device/status, and parameter-control helpers

This family covers narrow avatar-parameter utilities where external tools make
avatar state visible or controllable through OSC rather than through a full
overlay or world package.

| Project | Status | Notes |
|---|---|---|
| `Quesys-tech/vrcwatch.rs` | Already studied as minimal avatar-as-watch OSC telemetry sender | Rust CLI, normalized second/minute/hour floats, moonphase calculation, per-second timing, OSC address validation, and demo mode |
| `KutayX7/vrc-avi-scaler` | Already studied as avatar eye-height scaling and compatibility shim donor | OSC receiver/sender, VRChat eye-height/world-limit intake, smooth geometric interpolation, quantization mitigation, FPS/frequency commands, and Jackal/Mag/KtySize compatibility handlers |
| `VRLabs/Camera-System` | Partially studied; Wave 158 deepened avatar-authored OSC camera-path companion architecture | Avatar package plus companion model, constraints/contacts/physbones data capture, expression menus and parameters, point placement, gestures, preview, playback, and path-mode settings |

### Consolidation note

This family matters because some VRChat utilities should live at the avatar
parameter boundary instead of in an overlay. It now clearly includes:

- avatar-as-display telemetry
- normalized parameter contracts
- world-aware external avatar scale control
- third-party scaling system adapters
- avatar-authored camera/path data capture
- companion protocols driven by avatar contacts and menus

It suggests a stronger branch inside `VR-apps-lab` around:

- avatar-parameter utility design
- scale-control safety checklists
- avatar-as-display telemetry guidelines
- companion protocol notes for avatar-authored tools

## Family 138: Haptic, physical-output routers, and wearable feedback bridges

This family covers tools that turn virtual events into physical output:
avatar-contact events, OSCQuery endpoints, microcontroller packets, wearable
muscle maps, named sensations, game rumble capture, and generic device routers.

| Project | Status | Notes |
|---|---|---|
| `kikookraft/HapticPatPat` | Already studied as DIY Bluetooth ESP32 head-pat feedback bridge | VRChat OSCQuery discovery, `/avatar/parameters/pat_left` and `pat_right`, intensity delta/decay loop, PyQt status/test UI, Bluetooth RFCOMM packets, keepalive, and ESP32 PWM motors |
| `sync1211/owoskin-vrc` | Already studied as OWO Skin VRChat integration and effect-engine donor | OSCQuery service advertisement, OSC receiver callbacks, collider effect module, muscle maps, decay and proximity/speed intensity, named sensation lifecycle, audio/velocity/world settings, UI/CLI, and Unity payloads |
| `intiface/intiface-game-haptics-router` | Already studied as generic game rumble to external-device haptics router reference | Intiface Central WebSocket client, device selection, process list, EasyHook XInput/UWP payloads, IPC message envelope, visualizer, multiplier/baseline controls, and anti-cheat/process-injection caveats |

### Consolidation note

This family matters because haptics should not be designed as one device SDK
too early. It now clearly includes:

- avatar contact event vocabularies
- OSCQuery discovery and fallback ports
- physical-output status/test controls
- Bluetooth and firmware packet contracts
- wearable muscle maps and named sensations
- audio/collider/velocity effect modules
- generic game rumble event capture and device routing

It suggests a stronger branch inside `VR-apps-lab` around:

- device-neutral haptic event schemas
- haptics bridge comparison matrices
- avatar-contact-to-output routing guides
- safe boundaries for invasive versus non-invasive event sources

## Family 139: Foveated rendering, quad-view settings, and graphics-layer adaptation helpers

This family covers utilities that adapt rendering behavior around existing VR
applications: safe settings companions, vendor SDK emulation, OpenVR DLL
wrappers, OpenXR view-chain API layers, and Unity native VRS plugins.

| Project | Status | Notes |
|---|---|---|
| `TallyMouse/QuadViewsCompanion` | Source-light product/settings reference | QuadViews settings creation/update, incompatible config backup, locale decimal cleanup, defaults discovery, and Pimax exclusions |
| `mbucchia/PimaxMagic4All` | Already studied as vendor foveation SDK emulation and eye-provider fallback donor | Pimax/PVR API compatibility shim, LibMagic attach path, OpenVR/Varjo/VRChat OSC/Baballonia eye providers, and fixed-foveation fallback |
| `fholger/openvr_foveated` | Already studied as OpenVR DLL replacement foveated-rendering wrapper | `openvr_api.dll` replacement, IVRCompositor `Submit` hooks, D3D11 context hooks, RDM/VRS modes, config hotkeys, sharpening, logs, and compatibility caveats |
| `mbucchia/_ARCHIVE_Varjo-Foveated` | Already studied as archived OpenXR quad-view/foveation API-layer reference | `xrEnumerateViewConfigurationViews`, `xrLocateViews`, and `xrEndFrame` intervention, foveated `next` chain injection, FOV scaling, and settings/logging |
| `ViveSoftware/ViveFoveatedRendering` | Already studied as Unity native VRS plugin and command-buffer reference | Unity component/editor surface, command buffers around render passes, native D3D11 plugin events, NVAPI VRS helper, gaze updater, and visualizer |

### Consolidation note

This family matters because rendering-adaptation helpers have very different
risk surfaces:

- safe settings editors
- vendor compatibility shims
- OpenVR DLL replacement and D3D11 hooks
- OpenXR API layer view-chain edits
- engine-native VRS plugins

It suggests a stronger branch inside `VR-apps-lab` around:

- rendering adaptation risk matrices
- foveation fallback UX notes
- settings backup/sanity-check companions
- explicit separation between product-safe helpers and invasive hooks

## Family 140: OSCQuery VRChat discovery libraries and client primitives

This family covers the plumbing underneath VRChat OSC utilities: advertising,
discovery, avatar parameter fetching, mDNS sidecars, and multi-app coexistence.

| Project | Status | Notes |
|---|---|---|
| `galister/VrcAdvert` | Already studied as minimal OSCQuery app advertiser | CLI service name/HTTP/OSC ports, `/avatar/parameters`, optional tracking endpoints, official `VRC.OSCQuery` builder, and discovery logging |
| `minetake01/vrchat_osc` | Already studied as Rust VRChat OSC/OSCQuery client and registration crate | Tokio mDNS, advertised-IP selection, service registration/unregister, direct-address fallback, parameter fetch, service handles, and localhost/LAN/VPN caveats |
| `Natsumi-sama/OscQueryLibrary` | Already studied as C# OSCQuery parameter-discovery and service-advertisement library | available port selection, mDNS advertise/discover, `VRChat-Client-*` filtering, recursive parameter extraction, avatar ID capture, and update events |
| `Raphiiko/oyasumivr_oscquery` | Already studied as limited Rust OSCQuery library with dotnet mDNS sidecar | Rust client/server facade, process-watched C# mDNS sidecar, OSC/OSCQuery advertise/discover, endpoint registration, and dynamic advertised port updates |
| `theepicsnail/vrchat_oscquery` | Already studied as Python asyncio/threaded OSCQuery helper and multi-app proxy | minimal root/HOST_INFO responses, zeroconf service info, aiohttp/threaded variants, unused port selection, and config-driven multi-app advertisement |

### Consolidation note

This family matters because OSCQuery is reusable infrastructure, not just an app
feature. It now clearly includes:

- standalone advertisers for legacy OSC apps
- Rust/C#/Python library surfaces
- mDNS sidecars when native discovery is awkward
- direct-address fallbacks
- avatar parameter cache/update flows
- proxy patterns for multiple OSC apps

It suggests a stronger branch inside `VR-apps-lab` around:

- OSCQuery implementation matrices
- discovery reliability checklists
- Quest/LAN/VPN caveat notes
- clear separation between OSC packet handling and OSCQuery advertisement

## Family 141: Resonite creator import/export, inspection, and screenshot utility helpers

This family covers creator-facing Resonite tooling that moves content in,
inspects platform component models, or preserves capture context as metadata.

| Project | Status | Notes |
|---|---|---|
| `Yellow-Dog-Man/Resonite.UnitySDK` | Already studied as official Unity-to-Resonite SDK with generated bindings and converters | ResoniteLink, generated type/component wrappers, Unity primitive mapping, converter registry, realtime editor send, and beta/contribution workflow |
| `Phylliida/ResoniteUnityExporter` | Already studied as Unity exporter, shared DTO, and IPC import processor reference | Unity package, shared DTOs, memory-mapped/bridge IPC, named import processors, Resonite mod path, standalone package server, and material/avatar/world import flows |
| `dfgHiatus/ResoniteUnityPackagesImporter` | Already studied as Unity package extraction/cache/import mod donor | `.unitypackage` import extension patch, hash cache, unpacked asset paths, import type toggles, material/texture mapping, prefabs/scenes alpha, and hang/Unicode caveats |
| `BlueCyro/CherryPick` | Already studied as Resonite component selector search QoL reference | Harmony UI patch, component search field, worker metadata cache, ranking, scope filtering, generic type support, result-count config, and ProtoFlux visibility toggle |
| `hantabaru1014/ResoniteScreenshotExtensions` | Already studied as screenshot metadata, restore, and webhook utility donor | XMP metadata embedding, restore-on-import, photo/user/location/camera fields, format/folder controls, legacy graph loading, Discord webhook menu/auto-upload |

### Consolidation note

This family matters because creator tools are more than import scripts. It now
clearly includes:

- generated data-model bindings
- converter registries
- shared DTO and IPC import processors
- package extraction caches
- in-world component search/palette UX
- screenshot metadata round-tripping and sharing

It suggests a stronger branch inside `VR-apps-lab` around:

- cross-engine creator bridge checklists
- generated bindings versus direct import processors
- asset package cache/retry UX
- metadata-rich capture artifacts

## Family 142: External pose, object, and sensor data to VRChat OSC bridges

This family covers utilities that move external pose or sensor state into
VRChat through avatar parameters or `/tracking/trackers` OSC endpoints.

| Project | Status | Notes |
|---|---|---|
| `jangxx/VRC-Tracked-Objects` | Already studied as avatar-relative tracked-object OSC bridge with calibration matrix | avatar package contract, VRCFury/manual setup, WPF config UI, OpenVR controller/tracker selection, calibration overlays, matrix math, OSCQuery/manual OSC, and status states |
| `FizzyApple12/VRChatOSCOptitrack` | Already studied as NatNet rigid-body to VRChat OSC tracker bridge | NatNet frame ingestion, rigid-body collections, coordinate conversion, ImGui/OpenGL visualizer, tracker ID assignment, tinyosc bundles, and no-playspace-calibration caveat |
| `rogeraabbccdd/VRChat-MotionOSC` | Already studied as webcam motion and face-expression OSC controller reference | Electron/Vue shell, OSC UDP sender, IPC command handlers, webcam face/motion gestures, movement/jump/item control semantics, and experimental caveat |
| `takana-v/quest_steamvr_fbt_tool` | Already studied as simple SteamVR/OpenVR tracker to VRChat OSC FBT sender | null-driver setup note, serial-based device config, OpenVR overlay init, `getLastPoses`, Y offset from standard device, wx tray exit, and simple OSC tracker messages |
| `Alpyg/vrc_osc_tracker` | Already studied as MediaPipe camera pose-estimation OSC tracker reference | frame capture, intrinsic/extrinsic calibration commands, transform solving, pose landmarker, hip/head/foot tracker abstraction, offsets, and OSC tracker sender |

### Consolidation note

This family matters because pose ingress should name its coordinate contract.
It now clearly includes:

- avatar-relative tracked objects
- playspace/mocap rigid-body streams
- webcam gesture/motion controllers
- simple SteamVR tracker to OSC FBT scripts
- camera-calibrated MediaPipe tracker senders

It suggests a stronger branch inside `VR-apps-lab` around:

- pose-ingress matrices across OpenVR, NatNet, MediaPipe, VMC, VMT, and SlimeVR
- calibration UX categories
- OSC tracker endpoint contracts
- smoothing/scale/activation safety notes

## Family 143: VRChat, OBS, audience captions, translation, and chat-ingress surfaces

This family covers text/caption utilities that move speech, OCR, translation,
vision captions, or stream chat into browser overlays, OBS, VRChat OSC chatbox,
avatar text, Discord, TTS, or Unity-side VR surfaces.

| Project | Status | Notes |
|---|---|---|
| `Sharrnah/whispering` | Already studied as local multimodal speech/OCR/TTS platform with websocket overlay and VRChat OSC fan-out | websocket overlay clients, browser remote settings/plugin commands, OCR window capture knobs, plugin timers, chatbox chunking, typing state, and heavy model dependency caveat |
| `mmpneo/curses` | Already studied as text-event bus and multi-target caption fan-out donor | STT/translation/Twitch/Discord/input sources, pubsub text history, OBS native captions, browser overlays, VRChat chatbox/avatar text targets, emotes, particles, timers, and TTS |
| `Harry-Jing/vrc-live-caption` | Source-light VRChat live-caption and translation product reference | README-only pass; useful as Chinese/mixed-language live-caption framing, not code donor |
| `FionnaPrefabs/Fionnas-Audio-Captions-Prefab` | Package/distribution caveat only | VPM package/listing workflow template residue; do not treat as caption implementation donor until real prefab/runtime assets appear |
| `Vinventive/VRChat-to-BLIP` | Already studied as window-capture AI scene-caption accessibility experiment | VRChat desktop-window capture with `mss`/Win32/PIL, BLIP caption loop, 10-second cadence, high-end GPU caveat, and missing output transport |
| `lexonegit/Unity-Twitch-Chat` | Already studied as Unity Twitch IRC ingress and metadata-aware main-thread queue donor | Twitch IRC connect/join, tag/emote/badge parsing, anonymous/auth modes, rate-limit checks, reconnects, read/write threads, and capped Unity main-thread event processing |

### Consolidation note

This family matters because captions are an event-routing problem before they
are an overlay problem. It now clearly includes:

- local speech/OCR/TTS/translation sidecars
- browser websocket overlays and remote control pages
- OBS native stream captions
- VRChat chatbox pacing and typing state
- stream chat metadata ingress
- AI scene-caption experiments
- source-light product signals and package caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- caption pipeline matrices
- target capability comparisons
- chatbox pacing rules
- browser overlay URL contracts
- accessibility caption product concepts

## Family 144: Open Brush, Tilt asset pipelines, browser viewers, shader loaders, and collaborative drawing

This family covers the creative asset path around Open Brush/Tilt Brush:
sketch loading, app state, exported viewer metadata, brush shader restoration,
raw `.tilt` parsing, conversion, and collaborative stroke protocols.

| Project | Status | Notes |
|---|---|---|
| `icosa-foundation/open-brush` | Already studied as Open Brush creative app/API/sketch-load/export and brush/toolchain donor | external `.tilt` load queue, user sketch path copying, app command flow, Lua/API/editor/doc generators, brush/export tooling, panels, multiplayer, and large Unity caveat |
| `icosa-foundation/gallery-viewer` | Already studied as browser Open Brush/Tilt asset viewer with metadata restoration and XR mode | Three.js loaders for glTF/OBJ/FBX/PLY/STL/USDZ/VOX/splats, Tilt metadata parsing, lighting/environment restoration, fly/orbit navigation, and XR controller models |
| `icosa-foundation/three-icosa` | Already studied as Three.js Open Brush/Tilt material and shader restoration donor | `GOOGLE_tilt_brush_material` handling, brush GUID/name mapping, texture URI patching, attribute conversion, shader include/texture loading, and material cache |
| `icosa-foundation/three-tiltloader` | Already studied as raw .tilt zip/binary stroke loader | `.tilt` header skip, fflate unzip, metadata and binary stroke parsing, control points, handedness flip, stroke geometry, and uncertain mask-offset caveat |
| `Prystopia/c-sharp-tiltbrush-toolkit` | Already studied as C# .tilt parse/edit/write toolkit | typed control-point/header/metadata helpers, export parsing, mesh merge helpers, and programmatic `.tilt` manipulation examples |
| `DrHibbitts/TiltBrushConverter` | Already studied as Python OBJ/FBX conversion option and mesh semantics reference | FBX/OBJ exporters, cooked/raw geometry options, merge by stroke/brush, backface handling, PyQt GUI, progress, and old Python/FBX SDK caveat |
| `Phylliida/P2PDraw` | Already studied as collaborative stroke segment protocol idea with legacy Unity caveats | segment add/remove messages, float-array stroke payloads, base64 peer messages, existing-segment replay, hardcoded signaling, old Unity VR API, and checked-in artifact caveat |

### Consolidation note

This family matters because creative VR reuse lives in the asset pipeline:

- app-side sketch loading and command state
- browser viewer metadata restoration
- brush shader/material compatibility
- raw `.tilt` stroke parsing
- programmatic edit/write utilities
- conversion options and mesh semantics
- collaborative stroke protocols

It suggests a stronger branch inside `VR-apps-lab` around:

- Open Brush/Tilt pipeline maps
- creative asset viewer prototypes
- brush shader restoration notes
- collaborative stroke protocol comparisons

## Family 145: Gaussian splat immersive 3D asset viewers, editors, and XR display surfaces

This family covers Gaussian splat utilities across browser editors, static WebXR
viewers, model viewer shells, Three.js libraries, Unity renderers, native
plugins, and visual-effect experiments.

| Project | Status | Notes |
|---|---|---|
| `playcanvas/supersplat` | Already studied as browser Gaussian splat editor with command history and GPU data passes | editor event bus, dirty/export cursor, shared command queue, undo/redo, `splat-transform` loading, GPU bounds/histogram/intersection/range selection, gzip/progress writers |
| `playcanvas/supersplat-viewer` | Already studied as static WebXR splat viewer with settings schema, camera modes, collision, and annotations | URL content/settings/collision parameters, typed settings schema/migration, WebGL-gated WebXR, AR/VR session restore, orbit/fly/walk/anim cameras, annotations, skybox, sound, and post effects |
| `playcanvas/model-viewer` | Already studied as general PlayCanvas model viewer shell with XR/AR placement controller | glTF/GLB drag-drop viewer, resource/component stack, GSplat handler, AR hit-test placement, DOM overlay rotate input, and general viewer substrate value |
| `mkkellogg/GaussianSplats3D` | Already studied as Three.js drop-in splat renderer with multi-format loaders, workers, and WebXR caveats | PLY/SPLAT/KSPLAT/SPZ loaders, self-driven/drop-in modes, external renderer/camera support, workers/WASM sorting, WebXR mode, raycaster, and inactive-maintenance/performance caveats |
| `aras-p/UnityGaussianSplatting` | Already studied as Unity Gaussian splat asset/runtime renderer with editing, cutouts, compression, and VR caveats | asset compression/data layout, renderer command buffers, camera gathering, GPU sorting, procedural draw, debug modes, cutouts, merge/export, VR/platform caveats, and data-license note |
| `clarte53/GaussianSplattingVRViewerUnity` | Already studied as native CUDA/OpenXR Unity plugin and VR splat viewer reference | CUDA/differential rasterization plugin, multi-model load/remove/crop, per-POV render contexts, native texture/depth pointers, controller move/scale/menu UX, and Windows/CUDA performance caveat |
| `keijiro/SplatVFX` | Already studied as experimental Unity VFX Graph splat binder and substrate caveat | ScriptableObject splat arrays, lazy graphics buffers, VFX property binder, importer/VFX/shader graph, 8M point capacity note, and explicit not-ready/artifact caveat |

### Consolidation note

This family matters because Gaussian splat tools should not be lumped into one
category. It now clearly includes:

- browser editors
- static WebXR viewers
- general model viewer shells
- drop-in web renderer libraries
- Unity asset/runtime renderers
- native CUDA/OpenXR plugins
- VFX Graph experiments

It suggests a stronger branch inside `VR-apps-lab` around:

- Gaussian splat utility matrices
- viewer settings/schema patterns
- WebXR versus native VR navigation comparisons
- splat data provenance and performance caveats

## Family 146: Godot XR toolkits, vendor extensions, templates, and face-tracking bridges

This family covers Godot XR reusable building blocks: function-node toolkits,
vendor OpenXR extension stacks, product templates, GDExtension face tracking,
and legacy OpenVR UI/teleport primitives.

| Project | Status | Notes |
|---|---|---|
| `GodotVR/godot-xr-tools` | Already studied as Godot XR function-node toolkit | exported properties, configuration warnings, movement-provider base, pointer events, pickup/ranged grab, teleport arc and validation, hands, desktop support, audio/effects/staging/settings, and scene-node composition |
| `GodotVR/godot_openxr_vendors` | Already studied as Godot OpenXR vendor extension stack with export feature gates | GDExtension wrappers, Android XR/Meta/Pico/HTC/Magic Leap/Lynx/Khronos feature surfaces, export options, mutually exclusive vendor toggles, composition layers, performance metrics, docs, samples, and validation layers |
| `Malcolmnixon/godot-xr-dungeon-template` | Already studied as Godot XR product-template shell with persistence, staging, HUD, and pause menu references | XR Tools and Vendors composition, persistent world autoload, zone save/restore, HUD state signals, pause menu save/quit, NPC state, item modifiers, and asset/dependency caveats |
| `beepobb/godot-htc-face-tracking-bridge` | Already studied as source-driven HTC facial tracking GDExtension bridge caveat | requested HTC facial tracking extension, session tracker handles, expression weight reads, Godot `XRFaceTracker` mapping/registration, and generic template README caveat |
| `boku-ilen/godot-vr-toolkit` | Already studied as legacy Godot OpenVR viewport-to-mesh UI, teleport, and interactable primitive reference | viewport-to-mesh coordinate mapping, synthetic mouse events, controller ray/indicator UX, Bezier teleport ray, interactable base class, object menus, and old Godot/OpenVR caveats |

### Consolidation note

This family matters because Godot XR reuse has two strong shapes:

- scene-node composition for interactions and locomotion
- vendor extension/export-gate matrices for runtime capabilities

It now clearly includes:

- pointer/pickup/teleport/movement function nodes
- editor-facing exported settings and configuration warnings
- vendor extension wrappers and project/export toggles
- product-template persistence/staging/HUD composition
- focused GDExtension bridge examples
- legacy viewport-to-mesh UI lessons

It suggests a stronger branch inside `VR-apps-lab` around:

- Godot XR function-node matrices
- Godot OpenXR vendor feature matrices
- Godot versus Unity toolkit composition comparisons
- modern ports of legacy viewport-to-mesh UI concepts

## Family 147: Rust, Bevy, wgpu, and OpenXR app/rendering bring-up

This family covers application-side OpenXR bring-up in Rust: Bevy plugin
integration, custom engine context splits, wgpu/Vulkan graphics binding,
runtime stubs, and live-data XR visualization.

| Project | Status | Notes |
|---|---|---|
| `awtterpip/bevy_oxr` | Already studied as Bevy OpenXR plugin/render lifecycle donor | OpenXR init plugin, enabled extensions, session state events, custom Bevy render plugin, manual wgpu device/queue handoff, frame wait/view/swapchain/end-frame stages, action examples, passthrough/hands/overlay feature surfaces |
| `leetvr/hotham` | Already studied as Rust XR engine context split and OpenXR runtime stub donor | Android event pre-processing, XR/Vulkan/render/audio/gui/haptic/input/physics contexts, HMD/stage ECS entities, focused-state update loop, and `xrNegotiateLoaderRuntimeInterface` runtime shim with function pointer stubs |
| `blaind/xrbevy` | Already studied as legacy Bevy OpenXR architecture caution | architecture notes for global OpenXR state, custom swapchains, Vulkan/wgpu handle ownership, hand trackers, and renderer boundary risks |
| `matthewjberger/wgpu-example` | Already studied as explicit wgpu/OpenXR/Vulkan graphics binding sample | `KHR_vulkan_enable2`, graphics requirements, runtime-created Vulkan instance/device, wgpu HAL bridge, swapchain creation, and Android/desktop entry split |
| `robotics-erlangen/xrvis` | Already studied as live network data to XR panel visualization reference | multicast interface discovery, UDP/WebSocket protobuf ingestion, XR UI panel spawning, controller ray picking, texture/UI pointer forwarding, and drag focus retention |

### Consolidation note

This family matters because Rust/OpenXR reuse has several layers:

- raw graphics binding and swapchain bring-up
- engine plugin scheduling and resource ownership
- custom engine context construction
- OpenXR runtime stubs and loader test harnesses
- live network data to XR panel products

It suggests a stronger branch inside `VR-apps-lab` around:

- Rust OpenXR app-shell matrices
- minimal OpenXR/wgpu diagnostics samples
- Bevy XR plugin boundary notes
- live telemetry and control-panel prototypes

## Family 148: Universal VR game mod injectors, managers, and compatibility shells

This family covers the invasive edge of VR tooling: universal injectors, mod
managers, Unity XR subsystem replacement, safe modes, game compatibility gates,
graphics hook coexistence, and patch grouping.

| Project | Status | Notes |
|---|---|---|
| `praydog/UEVR` | Already studied as Unreal VR injector callback SDK and profile/script reference | renderer IDs, OpenXR handles, present/reset/input/tick/Slate/stereo/viewport/native-hook callbacks, Lua customization, and strong process-injection caveats |
| `praydog/REFramework` | Already studied as graphics-hook coexistence and mod API reference | D3D11 hook lifecycle, temporary unhook/restore around device creation, present/resize callbacks, Lua/C#/ImGui surfaces, method hooks, and invasive framework caveats |
| `Raicuparta/rai-pal` | Already studied as VR mod manager manifest/provider/database donor | Steam provider discovery, executable-path identity, manifest schema, dependencies, install actions, Wine overrides, environment/args, compatibility/outdated database state |
| `Raicuparta/uuvr` | Already studied as Unity XR subsystem injection and UI redirection donor | XR subsystem bundle copy, stale loader cleanup, globalgamemanagers enabledVRDevices patch, screen-space canvas capture, mirror texture redirection, and invasive caveats |
| `keton/chihuahua` | Already studied as compact DLL injection utility boundary/caveat | `OpenProcess`, remote allocation/write, `CreateRemoteThread`, `LoadLibraryW`, remote export invocation, and operator error flow |
| `NewUnityModder/UnityVRMod` | Already studied as Unity VR safe-mode and backend abstraction reference | BepInEx/UniverseLib startup, safe mode, delayed VR init, OpenVR/OpenXR backend selection, camera invalidation, scene-change reinitialization, and WIP caveats |
| `DaXcess/LCVR` | Already studied as game-specific VR mod safety shell | config/command-line disable, ask-on-startup dialog, game assembly hash verification, dependency preload, asset bundle load, and universal vs VR-only Harmony patch groups |
| `DaXcess/RepoXR` | Already studied as game-specific OpenXR compatibility shell | supported game version gate, runtime dependency preload, OpenXR runtime info logging, asset load, patch groups, attribute-driven RPC patch registration, and warning dialogs |

### Consolidation note

This family matters because VR retrofit tooling repeatedly exposes the same
safety and compatibility lessons:

- do not hide invasive boundaries
- log runtime and game compatibility early
- provide hard disable and safe-mode paths
- separate universal and VR-only patch groups
- keep mod compatibility in manifests/databases where possible
- make graphics hook coexistence a first-class concern

It suggests a stronger branch inside `VR-apps-lab` around:

- safe companion versus injector boundary docs
- VR compatibility doctor checklists
- manifest-driven utility managers
- startup gate and patch-group patterns

## Family 149: Quest, PICO, HoloLens marker tracking and remote hand-data utilities

This family covers camera/tracking helper utilities that turn passthrough
frames, vendor marker callbacks, HoloLens CV data, or Quest hand state into
poses, scene objects, and remote streams.

| Project | Status | Notes |
|---|---|---|
| `TakashiYoshinaga/QuestArUcoMarkerTracking` | Already studied as calibrated Quest passthrough camera marker-tracking donor | camera intrinsics scaling, ArUco3 detection, subpixel refinement, ChArUco/marker pose estimation, marker ID to object mapping, debug texture/object toggles |
| `picoxr/ArUcoMarkerTracking` | Already studied as PICO Enterprise marker callback and seethrough lifecycle donor | enterprise service init/bind, marker callback registration with floor origin, seethrough enable/resume, and marker ID pose map |
| `handzlikchris/Unity.QuestRemoteHandTracking` | Already studied as remote Quest hand-data split transport donor | OVR hand polling, high-frequency UDP pose packets, reliable TCP skeleton/mesh packets, length-prefix framing, gzip/XML serialization, receive queues, UnityEvents |
| `doughtmw/ArUcoDetectionHoloLens-Unity` | Already studied as HoloLens ArUco calibration/Research Mode reference | HoloLensCamCalib, HoloLensForCV, OpenCV package context, MRTK bundling caveat, and calibration-heavy sample packaging |
| `NormandErwan/ArucoUnity` | Already studied as reusable Unity ArUco camera/calibration package donor | camera abstraction, board/ChArUco calibration, multi-camera image buffers, async calibration, marker observations, and camera-parameter persistence |
| `nooway077/HoloLens2CVExperiments` | Already studied as HoloLens2 Research Mode marker pose pipeline donor | spatial camera intrinsics, left/right front camera loops, OpenCV bridge marker detection, rvec/tvec pose, camera-to-world composition, and HUD diagnostics |

### Consolidation note

This family matters because marker and remote-hand utilities are often small
but highly reusable:

- camera source and intrinsics handling
- local OpenCV detection versus vendor callbacks
- marker ID to scene-object maps
- coordinate-frame composition
- split transport for live hand state and heavy skeleton/mesh data
- calibration package/wizard structure

It suggests a stronger branch inside `VR-apps-lab` around:

- marker-tracking device matrices
- passthrough camera calibration helpers
- remote hand-data transport comparisons
- HoloLens/Quest/PICO coordinate-frame notes

## Family 150: XR behavior recording, physiological replay, olfactory display, and sparse-camera mocap

This family covers research-grade XR instrumentation and XR-adjacent capture
helpers: record/replay workflows, event and physiological timelines, Unity
recording/replay internals, multisensory hardware bridges, and sparse-camera
mocap exports.

| Project | Status | Notes |
|---|---|---|
| `liris-xr/PLUME` | Already studied as docs-first XR recorder/viewer/timeline product reference | recorder workflow, `.plm` files, asset bundle replay, standalone viewer, timeline, event markers, physiological signals, native-frequency LSL capture claims, and docs-site caveat |
| `liris-xr/XREcho` | Already studied as Unity XR recording/replay source donor | singleton/config managers, tracked camera/controllers/interactables/layers, CSV metadata/events/object formats, scene-load events, replay clones, camera switching, gaze, trajectories, heatmaps, and TODO-heavy modernization caveats |
| `liris-xr/Nebula-Core` | Already studied as multisensory olfactory display bridge donor | serial/Android plugin bridge, port handshake, command mapping, head-proximity diffusion, GUI override, application cleanup, pseudo-randomized trials, and CSV experiment logging |
| `liris-xr/kineo` | Already studied as sparse-camera mocap pipeline and export helper reference | typed pipeline stages, Hydra configs, offline/online modes, live camera calibration, triangulation, bundle adjustment, stage timings, BVH/USD/Rerun-style exports, heavy ML stack, and non-commercial research-license caveat |

### Consolidation note

This family matters because instrumentation is a complete product chain, not
just data capture:

- recorders with low-friction integration
- metadata and event files
- physiological/time-series capture
- replay viewers and timelines
- in-situ analysis surfaces
- physical-output devices and experiment logs
- mocap reconstruction and export helpers

It suggests a stronger branch inside `VR-apps-lab` around:

- XR instrumentation matrices
- replayable diagnostics and event-marker UX
- multisensory physical-output bridge patterns
- motion-capture import/export helper directions

## Family 151: Overlay window surfaces, game overlay managers, and scriptable overlay shells

This family covers overlay implementation substrates: browser-backed OpenVR
surfaces, process-injected window managers, modular driver/overlay umbrellas,
game-specific OpenXR overlay engines, Unity overlay baselines, and scriptable
overlay engine references.

| Project | Status | Notes |
|---|---|---|
| `imagitama/react-electron-openvr` | Already studied as Electron/React offscreen shared-texture OpenVR overlay donor | transparent offscreen BrowserWindow, Windows NT shared texture handles, native OpenVR submit, mouse scale/input mode, body/world/head attach modes, and declarative React overlay lifecycle |
| `KotRikD/steamvr-overlay` | Already studied as injected overlay window manager and typed IPC donor | process injection caveat, shared-handle updates, window IDs, position/anchor/margin commands, input listen/block controls, cursor blocking, and typed Rust/Node request model |
| `RealWhyKnot/WKOpenVR` | Already studied as modular SteamVR driver/overlay umbrella donor | feature plugin interface, flag-file activation, module safety gates, named pipes, shared memory, ImGui tabs, dev tools, logs, and one-driver-module packaging rationale |
| `SableVII/Sable-Overlay` | Already studied as Unity modular boundary overlay reference | module interfaces, setting UI interfaces, boundary module, overlay settings/log modules, OSC controller, persisted JSON boundary colors/widths/height/sensitivity |
| `Alphasumsi/Honey_Overlays` | Already studied as game-specific OpenXR overlay manager donor | WPF editor, named-pipe length-prefixed JSON, hidden browser-host processes, WebView2/DWM cloaking, Windows Graphics Capture, D3D11 quad layers, per-car/session layouts, and place-in-VR controls |
| `Ikeiwa/VRMocapOverlay` | Already studied as Unity/OpenVR overlay prefab baseline | render-texture camera overlays, dashboard thumbnail, OpenVR event polling, dashboard/standby/quit callbacks, and legacy OVRLay-derived caveat |
| `4x8Matrix/Hoku` | Source-light scriptable overlay product reference | Luau-driven OpenVR overlay engine concept with 2D testing and OpenGL integration goals; not a current source donor |

### Consolidation note

This family matters because overlay products depend on substrate decisions:

- who owns the surface
- how pixels cross into VR
- how input is routed or blocked
- how placement is represented
- how feature modules are enabled safely
- how source capture and browser windows are managed

It suggests a stronger branch inside `VR-apps-lab` around:

- overlay-substrate matrices
- safe companion versus injected overlay boundary docs
- browser-backed overlay engine contracts
- in-headset overlay placement UX patterns

## Family 152: OpenXR API-layer adaptation, hand transform offsets, and graphics compatibility

This family covers narrow OpenXR API layers that adapt data or runtime
capabilities: OSC eye/face extension adapters, hand-joint transform correction,
graphics-binding substitution, and minimal generated-dispatch layer templates.

| Project | Status | Notes |
|---|---|---|
| `LordOfDragons/openxr_oscclient` | Already studied as OSC eye/face tracking to OpenXR extension adapter donor | loader negotiation, self-provided extension filtering, OSC UDP read thread, lowercased targets, clamped expression values, eye/facial tracking extension calls, and local-space/fixed-port caveats |
| `CraigMason/OpenXR-Hand-Transform-Offset-Layer` | Already studied as runtime-side hand transform correction micro-layer | `xrLocateHandJointsEXT` shim, env-var config path, periodic config reload, yaw/pitch/translation offsets for each joint, and desktop-mounted hand-tracker workflow |
| `Sorenon/sorenon_openxr_layer` | Already studied as Rust graphics compatibility API layer | loader/API version validation, runtime detection, OpenGL-to-Vulkan extension replacement, session graphics wrappers, swapchain wrapper registry, external memory path, and synchronization/performance TODO caveats |
| `maluoi/openxr-layer-template` | Already studied as compact C11/CMake API-layer template | negotiation validation, chained instance creation, `xrGetInstanceProcAddr` interception, generated dispatch cases, requested/override function config, and manifest disable environment |

### Consolidation note

This family matters because runtime-side helpers should be small and explicit:

- adapt protocol data into standard OpenXR extension surfaces
- correct transform spaces at a narrow API boundary
- diagnose or bridge graphics capability gaps
- start from templates that make dispatch ownership obvious
- document provider conflicts and disable paths

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR micro-layer starter packs
- API-layer install/disable safety checklists
- adaptation-layer matrices by target surface
- runtime-side calibration and compatibility diagnostics

## Family 153: Spatial anchors, shared scenes, Magic Leap persistence, and colocation

This family covers spatial-anchor persistence and colocation patterns across
Meta Unreal and Magic Leap samples: local/cloud/storage state, shared anchors,
anchor-relative scene reconstruction, localization gating, anchor queries, and
status/control panels.

| Project | Status | Notes |
|---|---|---|
| `oculus-samples/Unreal-SpatialAnchorsSample` | Source-light Meta Unreal spatial anchor baseline | Blueprint/content sample and setup reference; low code donor value in static source pass |
| `oculus-samples/Unreal-SharedAnchorsSample` | Already studied as shared-anchor UX and persistence reference | create/select/load flow, local/cloud save state, anchor action menu, orient-to-anchor, erase/share actions, LAN session context, and OculusXR module dependencies |
| `oculus-samples/Unreal-SharedSceneSample` | Already studied as anchor-relative shared scene donor | UI/menu manager, async operation utilities, shared anchor before scene data, semantic labels, relative transforms, static mesh references, multicast reconstruction, and visibility toggles |
| `magicleap/SpatialAnchorsExample` | Already studied as Magic Leap persistence donor | localization events, anchor event manager, head-pose-valid query gating, worker/main thread dispatcher, JSON content bindings, persistent content restore, and Space selector |
| `dilmerv/MagicLeapSpatialAnchors` | Already studied as ARFoundation/OpenXR Storage API lifecycle donor | anchor subsystem readiness, controller placement preview, publish/query/delete callbacks, local/stored anchor records, restore/clear panel, confidence/tracking status UI, and duplication caveat |

### Consolidation note

This family matters because anchor systems are product workflows, not isolated
API calls:

- create/select/load/save/share/erase states
- local versus cloud/storage persistence
- localization readiness and query cadence
- anchor-to-content bindings
- shared scene data relative to an anchor
- semantic label visibility and status surfaces

It suggests a stronger branch inside `VR-apps-lab` around:

- spatial-anchor persistence matrices
- generic anchor action menu patterns
- colocation scene snapshot schemas
- vendor-specific anchor lifecycle comparison notes

## Family 154: VRChat OSC web panels, debug surfaces, controller helpers, and sensor bridges

This family covers small-to-medium VRChat OSC helper tools: chatbox web panels,
passive packet debuggers, OSCQuery parameter browsers, avatar/controller
micro-tools, finger tracking bridges, and biometric sensor-to-avatar pipelines.

| Project | Status | Notes |
|---|---|---|
| `ThatGuyThimo/leapmotion-osc` | Already studied as Leap Motion finger-to-OSC bridge | Leap frame subscription, finger tip-to-palm distance, metacarpal/proximal spread, finger-specific limits, `/avatar/parameters/...` sends, connection/FPS/hand-status UI, and calibration/smoothing caveat |
| `a2942/VRChat-OSC-WEB-Chat` | Already studied as browser chatbox panel micro-utility | Flask routes for chatbox input/typing, OSC endpoint config, JSON persistence, uploaded avatar/background assets, responsive chat UI, and network exposure caveat |
| `qbitzvr/Drone-OSC-Controller` | Product workflow reference for VRCLens drone-control OSC micro-tool | avatar submenu enable/mode/speed controls, opposite-hand or Xbox input through OSC parameters, Modular Avatar install flow, smoothing tweaks, and source-light/package caveat |
| `ChrisFeline/VRChatOSCLib` | Already studied as C# VRChat OSC primitive library | typed parameter/input/chatbox helpers, async sends, listener socket, `VRCMessage` classification, input button/axis structs, and lightweight library scope |
| `firocore/VRChatOSCDebugger` | Already studied as Python/Tk passive OSC debugger | wildcard UDP listener, latest-value table, ignore-list persistence, multi-select copy, clear button, VRChat log setting checks, and passive-only caveat |
| `Misaka-L/VRChatOscDebugger` | Already studied as Avalonia OSCQuery parameter browser | OSCQuery service discovery, host info/node fetch, endpoint derivation, service refresh, local-address filtering, avatar-change refresh, and hierarchical tree data grid |
| `networkpenetrationtester/VRChat-OSC-WebPanel` | Already studied as TypeScript OSC router and web parameter panel donor | avatar JSON loading, type maps, `/avatar/change` refresh, path-pattern listener cache, app forwarding, send acknowledgement by echo, live Svelte parameter panel, and rough frontend caveats |
| `200Tigersbloxed/HRtoVRChat_OSC` | Already studied as heart-rate sensor/SDK to VRChat OSC bridge donor | many HR sources, parameter normalization, active/connected/heartbeat booleans, avatar file listener, app bridge messages, reflected/network SDK plugins, and plugin-security caveats |

### Consolidation note

This family matters because VRChat OSC utility value often appears in small
surfaces:

- web/mobile chatbox panels
- live OSC packet tables
- OSCQuery parameter browsers
- typed OSC helper libraries
- avatar-authored controller workflows
- sensor/finger/biometric parameter bridges
- status and heartbeat parameters

It suggests a stronger branch inside `VR-apps-lab` around:

- VRChat OSC doctor and parameter browser prototypes
- sensor-to-avatar bridge schemas
- chatbox/web-panel safety and pacing notes
- OSCQuery versus passive listener comparison matrices

## Family 155: DIY eye/mouth tracking, VRCFT modules, gaze calibration, and OpenXR eye consumers

This family covers source-first expression tracking stacks: camera-based
mouth/eye tracking, per-user calibration, model inference, VRChat native/VRCFT
outputs, hardware SDK modules, in-headset calibration routines, and engine-side
OpenXR eye consumers.

| Project | Status | Notes |
|---|---|---|
| `Project-Babble/ProjectBabble` | Already studied as DIY mouth tracking pipeline donor | camera ROI/crop/rotate/flip, ONNX provider selection, calibration, `OneEuroFilter` smoothing, OSC expression output, recalibration receiver, and non-commercial/license caveats |
| `EyeTrackVR/EyeTrackVR` | Already studied as DIY eye tracking and output bridge donor | multiple pupil algorithms, warmup/calibration gates, preview/latency metrics, VRChat native eye vectors, VRCFT v1/v2 parameters, and single-eye fallback |
| `cspark-development/VRCFaceTracking-TobiiXR` | Already studied as hardware SDK to VRCFT module donor | embedded native DLL extraction, Tobii context/device setup, wearable consumer data thread, per-eye validity checks, and hardcoded calibration caveats |
| `ryan9411vr/EyeTracking` | Already studied as user-trained eye tracking workflow donor | Electron/TensorFlow client, model reloads, openness calibration, VRChat native/VRCFT OSC output, Unity VR target theta WebSocket server, and LFS/dependency caveat |
| `Project-Babble/BabbleCalibration` | Already studied as in-headset calibration routine runner | Godot OpenVR/OpenXR backends, TCP packet dispatcher, text/video/tutorial/gaze/reticle/dilation/convergence/graph/debug routines, and incomplete OpenXR overlay backend |
| `headassbtw/ResoniteOpenXREyeTracking` | Already studied as OpenXR extension consumer to engine input driver | headless OpenXR session, `XR_MND_headless`, `XR_FB_face_tracking2`, theoretical `XR_EXT_eye_gaze_interaction` fallback, Resonite input driver mapping, and destroy-path caveat |
| `edvardsoe/foveated-rendering-demo` | Source-light foveation product reference | useful as gaze/foveated-rendering communication reference, not current code donor |

### Consolidation note

This family matters because tracking utilities are pipelines, not isolated model
calls:

- camera source and ROI transforms
- model or pupil algorithm selection
- calibration routines and user feedback
- smoothing and fallback behavior
- VRChat/VRCFT/OpenXR/engine output schemas
- hardware SDK packaging and teardown

It suggests a stronger branch inside `VR-apps-lab` around:

- eye/mouth tracking pipeline matrices
- output-schema comparison across VRChat native, VRCFT, OSC, and engine inputs
- in-headset calibration routine contracts
- OpenXR eye/face consumer patterns

## Family 156: Resonite headless deployment, operations, REST/IPC, and compatibility patches

This family covers server-side and operator-facing Resonite utility work:
containerized headless deployment, web/Discord control surfaces, in-engine REST
resources, shared-memory state export, and compatibility patchers.

| Project | Status | Notes |
|---|---|---|
| `voxelbonecloud/resonite-headless-docker` | Already studied as containerized headless deployment donor | Debian/.NET image, Steam headless download, config/log/RML volumes, mod auto-install, launch/update split, git sync, and credential/cache caveats |
| `Zetaphor/resonite-headless-manager` | Already studied as web headless operations console donor | FastAPI, WebSocket clients, Docker attach socket, rolling logs, parsed worlds/status/users/bans, restart fallback, metrics, and local-network security caveat |
| `FlippedCodes/Resonite-Headless-Discord-Bot` | Already studied as Discord operations surface donor | slash commands, role/channel checks, Docker label discovery, command markers, config-file editing, world-list message parsing, and Docker socket/race caveats |
| `JackTheFoxOtter/resonite-rest` | Already studied as in-engine REST resource tree donor | `HttpListener`, route registration, resource paths, contact/user/cloud-variable managers, host/port lifecycle, and early-development security caveats |
| `Nytra/ResoniteHeadlessHeadServer` | Already studied as shared-memory state export experiment | execution hook, circular buffers, high/normal priority packet queues, world/material/texture connectors, and deprecated/version-fragile status |
| `BlueCyro/Nimbus` | Already studied as runtime Harmony compatibility shim | targeted thread/type-name patches, legacy compatibility helpers, and brittle version-specific scope |
| `BlueCyro/Cumulo` | Already studied as irreversible compatibility pre-patcher | Mono.Cecil resolver, method patch attributes, Nimbus/Harmony bundling, destructive warning, and rollback/version caveats |

### Consolidation note

This family matters because social XR utilities often have a headless operations
side:

- deployment images and update scripts
- logs and command channels
- web, Discord, REST, and CLI control surfaces
- structured versus string-parsed operations
- shared-state export from headless runtimes
- compatibility shims and support boundaries

It suggests a stronger branch inside `VR-apps-lab` around:

- headless operations matrices
- remote control surface security checklists
- Discord/web/REST comparison notes
- compatibility patch risk taxonomy

## Family 157: Visual impairment simulation, gaze-contingent accessibility, and UI accessibility helpers

This family covers accessibility and visual simulation methods: per-eye
impairment rendering, gaze-contingent masks, mobile passthrough filters,
patient-data-driven field maps, and screen-reader-like Unity UI support.

| Project | Status | Notes |
|---|---|---|
| `petejonze/OpenVisSim` | Already studied as Unity visual impairment simulation donor | linkable per-eye effects, gaze-contingent field-loss masks, overlay textures, blur mip levels, Unity 2017/GPL/deprecation caveats |
| `VARID-XR/VARID-plugin-ue5` | Already studied as Unreal visual impairment plugin donor | Blueprint condition setters, per-eye state, normalized gaze, debug modes, RDG compute blur pyramids, and UE5.5/medical caveats |
| `rulyox/VisualImpairmentVR` | Already studied as mobile passthrough shader reference | `WebCamTexture`, render-texture staging, UV offsets, distortion shader, Cardboard/Unity 2018 thin-sample caveat |
| `ojwalch/LowVisionVR` | Already studied as native Android low-vision filter reference | dual-eye camera preview, async processing, joystick controls, RenderScript kernels for edge/center/warp/periphery, and deprecated API caveat |
| `lukasmaxim/Glaucoma-VR` | Already studied as patient-data mask and Varjo gaze simulation reference | CSV/grid mask generation, context/focus textures, Varjo gaze/HMD state, gaze logging, and no-doc/vendor-specific caveats |
| `mikrima/UnityAccessibilityPlugin` | Already studied as Unity UI accessibility donor | labels/hints/prefixes, container ordering, touch exploration, gestures, virtual keyboard, audio/TTS queue, platform wrappers, and in-app accessibility caveat |

### Consolidation note

This family matters because accessibility is an engineering substrate:

- simulation shaders and masks
- gaze-contingent effects
- per-eye state and debug modes
- patient-data or profile-driven settings
- mobile camera passthrough filters
- navigable, spoken, hinted UI containers

It suggests a stronger branch inside `VR-apps-lab` around:

- accessibility simulation matrices
- VR menu accessibility contracts
- gaze-contingent shader references
- low-vision passthrough/filter prototypes

## Family 158: Capture, screenshot, media projection, window capture, and photomode helpers

This family covers capture and media-surface helpers: 360 screenshots,
transparent editor screenshots, deterministic screenshot sequences, Windows
window/desktop/browser capture, Quest screen projection, photomode UX, and
360/stereo media record/playback pipelines.

| Project | Status | Notes |
|---|---|---|
| `yasirkula/Unity360ScreenshotCapture` | Already studied as 360 screenshot capture donor | cubemap render, equirectangular converter shader, async GPU readback, `ReadPixels` fallback, JPEG/PNG encoding, GPano XMP metadata, and platform support caveats |
| `rurre/Editor-Screenshot` | Already studied as editor transparent screenshot donor | UI Toolkit window, scene/game camera selection, preview render texture, transparent background, near clip override, resolution presets, `EditorPrefs`, and editor-only scope |
| `Team-on/UnityScreenShooter` | Already studied as screenshot sequence helper | data-driven target camera/resolution/UI/language settings, timescale pause, one-frame wait, structured filenames, and output-path caveat |
| `Phylliida/UnityWindowsCapture` | Already studied as external surface texture ingress donor | window registry, Win32 BitBlt, bitmap row alignment, Desktop Duplication plugin callbacks, cursor composition, Chromium shared-memory browser textures, and Windows/legacy caveats |
| `t-34400/QuestMediaProjection` | Already studied as Quest MediaProjection wrapper reference | `ServiceContainer`, AndroidJavaObject media projection manager, texture polling, barcode services, image saving, WebRTC peer wrappers, WebSocket signaling, and archive/API caveat |
| `UnityTechnologies/PhotoMode` | Already studied as photomode UX/control donor | EventSystem handoff, Cinemachine photo camera, pause/unscaled time, postprocess sliders, filters, frames, stickers, grid/UI toggles, URP blit feature, and non-VR-first caveat |
| `vimeo/vimeo-unity-sdk` | Already studied as 360/stereo media pipeline reference | recorder state/events, MediaEncoder inputs, cubemap/equirectangular 360 capture, chunked Vimeo upload, metadata loading, Unity/AVPro playback, and account/editor caveats |

### Consolidation note

This family matters because many VR utilities need surface ingress or media
output before they become overlays or tools:

- camera/render-texture/desktop/window capture
- cubemap and equirectangular conversion
- metadata-rich screenshots
- editor and runtime capture UX
- Quest screen capture and WebRTC streaming
- photomode mode management
- 360/stereo recording and playback

It suggests a stronger branch inside `VR-apps-lab` around:

- surface-ingress matrices
- capture privacy and permission checklists
- authoring screenshot utility patterns
- photomode and media-output UX references

## Family 159: XR text-entry keyboards, input surfaces, and pointer bridges

This family covers keyboard/input surfaces across WebView, WebXR mesh, Unity
collider, canvas texture, A-Frame, hand-attached, and shell-plugin boundaries.

| Project | Status | Notes |
|---|---|---|
| `vuplex/unity-keyboard` | Already studied as WebView keyboard bridge | React/TypeScript keyboard, generated C# HTML bundle, `window.vuplex` messages, multilingual layout state, and Vuplex dependency caveat |
| `felixtrz/xrkeys` | Already studied as WebXR mesh keyboard donor | GLB keyboard, low draw calls, controller raycast, UV key-mask picking, press-edge tracking, and Three.js/fixed-layout caveat |
| `ErikSom/VirtualKeyboard-VR-Ready` | Already studied as canvas texture keyboard donor | UV pointer input, texture dirty flag, multilingual layouts, collision zones, swipe suggestions, and host texture integration caveat |
| `robertlalum/vr-virtual-keyboard` | Already studied as A-Frame keyboard micro-utility | controller ray keys, text buffer, pointer mapping, optional WebSocket key/text/pointer bridge, and one-file demo caveat |
| `JuliusWon/XR-Keyboard-for-Unity` | Thin procedural Unity keyboard baseline | generated key grid, TMP input append/delete behavior, and hardcoded delete/generated-cache caveats |
| `pinglis/XRSimpleKeyboard` | Already studied as physical Unity XR keyboard donor | layout width rows, key-width prefabs, localized labels, collider press set, key depth/material changes, and UnityEvents |
| `MalekiRe/bevy_xr_keyboard` | Experimental hand-attached text-entry reference | Bevy/OpenXR hand tracking, palm-mounted text surfaces, pinch selection, and incomplete/no-README caveat |
| `technobaboo/stardust-xr-keyboard-plugin` | Thin shell keyboard plugin sample | Qt virtual-keyboard plugin boundary, synthetic `QKeyEvent` press/release, and hardcoded sample output caveat |

### Consolidation note

This family matters because text input is a foundation for command palettes,
chat, settings, search, diagnostics, and remote-control overlays:

- WebView keyboards centralize UI complexity in browser code
- UV/mesh keyboards minimize draw calls and DOM dependency
- canvas keyboards make texture-update ownership explicit
- physical collider keyboards provide direct-touch affordance
- hand-attached keyboards explore wrist/palm text entry
- shell plugins show OS/runtime key-event injection boundaries

It suggests a stronger branch inside `VR-apps-lab` around:

- VR text-entry comparison matrices
- keyboard focus/destination/privacy contracts
- reusable text-input abstraction notes
- accessibility-aware keyboard UX patterns

## Family 160: WebXR multiplayer, shared rooms, and WebRTC scene shells

This family covers shared WebXR and Unity WebXR room infrastructure: signaling,
presence, P2P audio/data, pose payloads, shared-object events, chat/classrooms,
and spatial HUD orchestration.

| Project | Status | Notes |
|---|---|---|
| `danielesteban/blocks` | Already studied as WebXR room and P2P donor | WebSocket/protobuf signaling, SimplePeer audio/data, binary head/hand pose payloads, self-host config, and voxel app caveat |
| `De-Panther/webxr-multiplayer-template` | Already studied as Unity WebXR multiplayer shell | Lobby/Relay/Vivox/NGO, player state, voice status, XR hand pose fidelity tiers, networked sliders, and service-heavy caveat |
| `kylebakerio/vrgoclub` | Product reference only | social WebXR Go club framing with mixed VR/desktop users, voice/video, hand tracking, board sync, and AI heatmap ideas |
| `Immersive-Collective/webxr-webrtc-dc-scene` | Capability/media reference | webcam-to-texture, rayline pointers, teleport helpers, WebRTC capability docs, and actual DataChannel sync caveat |
| `Radet5/webroom-vr` | Already studied as lightweight shared-object room donor | socket.io/simple-peer signaling, VR and screen users, Cannon objects, grab/release events, throw velocity, and hardcoded API caveat |
| `JT5D/xrai-spatial-web` | Already studied as spatial HUD/presence architecture reference | room state, presence WebSocket, view registry lifecycle, HUD orchestrator, hand/voice/agent overlay, and roadmap/spec caveat |
| `RNMUDS/webxr-multiplayer-room` | Already studied as A-Frame room baseline | HTTPS server, Socket.IO rooms, chat, colored avatars, pose thresholds, PeerJS setup, and no real media/data caveat |

### Consolidation note

This family matters because shared XR utilities need explicit room layers:

- room identity and membership
- signaling versus data/media channels
- pose update cadence and payload shape
- shared object authority and release events
- chat and fallback desktop users
- voice/video/media permissions
- pluggable spatial views and HUD composition

It suggests a stronger branch inside `VR-apps-lab` around:

- shared-room transport matrices
- WebXR/Unity WebXR multiplayer shells
- pose payload schema comparisons
- privacy and moderation checklists for public XR rooms

## Family 161: ROS/robot teleoperation bridges and VR operator shells

This family covers VR operator systems that translate tracked poses, buttons,
camera streams, and modes into ROS/robot command and diagnostics pipelines.

| Project | Status | Notes |
|---|---|---|
| `UM-ARM-Lab/vr_teleop` | Already studied as safety-gated ROS1 pose-to-IK donor | Vive messages, MoveIt IK, measured joint seed, enabled service, joint-distance safety gate, gripper commands, and robot-specific caveats |
| `UM-ARM-Lab/vr_ros2_bridge` | Already studied as ROS2 XR device publisher donor | Unity OpenXR controller/tracker enumeration, HTC Vive tracker role profile, pose/twist/button axes, coordinate conversion, and RViz debug topics |
| `h2r/ros_reality_bridge` | Legacy ROS-to-Unity scene bridge reference | TF frame sweep, compact string pose stream, rosbridge/camera launch plumbing, Python2/ROS Indigo caveat |
| `Intelligent-Robotics-Lab/vr-teleoperation` | Already studied as OpenVR robot operator station | OpenVR actions, ROS publishers, Standby/RobotControl/Calibration modes, ImGui dashboard, camera texture, and hardcoded robot paths |
| `zz0320/vr_teleoperation_ros` | Already studied as WebSocket-to-ROS command-buffer donor | fixed-rate ROS timer, arm/torso/base modes, smoothing, gripper clamp, long-press data collection, audio feedback, RelaxedIK, and binary/cache caveats |
| `Mcen25/VR-Teleoperation-Robotics-Platform` | Thin Unity ROS camera/diagnostics reference | ROS# camera grid, compressed/raw image fallback, HTTP video feed, SSH/network tests, and hardcoded IP/template caveats |

### Consolidation note

This family matters because VR teleoperation exposes high-value utility
patterns beyond robotics:

- tracked pose normalization and coordinate conversion
- asynchronous input to fixed-rate command buffers
- mode switches and operator-ready gates
- camera/status panels inside VR
- stale-data and jump-distance safety
- audio/visual feedback for control state
- separation between operator UI and actuation backend

It suggests a stronger branch inside `VR-apps-lab` around:

- VR teleoperation bridge matrices
- operator mode and safety-gate checklists
- ROS camera/status panel references
- remote-control architecture notes for non-robot VR utilities

## Family 162: DIY VR headset/controller hardware, firmware, and spec references

This family covers DIY VR hardware projects and datasets: headset BOM/CAD/PCB
references, microcontroller firmware, HID packet boundaries, OpenVR driver
shells, marker tracking, haptics, and headset spec schemas.

| Project | Status | Notes |
|---|---|---|
| `vis3r/NxtVR` | Already studied as DIY headset firmware/HID reference | Pico/STM32 IMU readout, TinyUSB/USBComposite HMD reports, VR HID descriptor, MPU6050 calibration, and OpenHMD/runtime caveats |
| `Kwiatens/FloV3R` | Already studied as hardware documentation reference | BOM, optics/display choices, PCBs, controller transceivers, PSMoveServiceEx/HadesVR dependency, and firmware/driver TODO caveat |
| `Jade-Vincent/Persephone-VR-Headset` | Thin DIY headset CAD/BOM reference | 2K LCD, lenses, Pro Micro/Pico plan, MPU6050, STEP files, and maturity warning |
| `CSParnell78/OpenVision` | Source-light headset concept reference | display, ATmega32U4/Pro Micro, gyro, phone shell, wireless transmitter choices, and no source caveat |
| `vrrare/vr-headset-specs` | Already studied as headset specs schema/dataset donor | JSON/CSV data, JSON Schema, display/optics/tracking/audio/connectivity/physical fields, and freshness/provenance caveat |
| `dhfmzk/VRController` | Already studied as compact firmware packet donor | Arduino/MPU9250 DMP, Bluetooth serial, 34-byte marker-delimited packet, quaternion/position/joystick/trigger data, and dead-reckoning caveat |
| `BlaiseSaunders/DIY-VR-Controller-OpenCV` | Already studied as bright-marker UDP tracker donor | Python/OpenCV thresholding, contour selection, normalized coordinate UDP output, and Python2/single-camera caveat |
| `shehraan/DIY_VR_Controller` | Already studied as end-to-end DIY controller stack donor | ESP32 firmware, Madgwick filter, EEPROM calibration, BLE HID input/output, haptics, OpenVR driver, input profiles, freshness gates, and built-binary caveats |
| `Windastella/open-vr-controller` | Source-light no-progress concept | retained only as thin direction signal for OpenXR-capable DIY controllers |

### Consolidation note

This family matters because DIY hardware teaches boundary design:

- firmware sensor readout and calibration
- packet schemas and report descriptors
- USB/BLE HID transport
- haptic output paths
- runtime driver profiles and resource manifests
- CAD/BOM/PCB documentation
- headset spec schemas and device comparison data

It suggests a stronger branch inside `VR-apps-lab` around:

- DIY XR hardware boundary matrices
- firmware-to-driver packet notes
- headset capability/spec datasets
- hardware-inspired diagnostics and inventory tools

## Family 163: Low-latency stream ingress, stereo panels, point clouds, and browser surfaces

This family covers small projects that bring external surfaces into XR:
WebRTC/LiveKit video, Quest MediaProjection, UDP point clouds, and native
WebView/browser video panels.

| Project | Status | Notes |
|---|---|---|
| `bugman-007/XR-Low-Latency-Stereo-Streaming` | Already studied as minimal WebRTC-to-texture receiver | browser sender, WebSocket signaling, SDP/ICE buffering, Unity `VideoStreamTrack` to material texture, and POC caveats |
| `livekit-examples/spatial-video` | Already studied as stereo panel reference | Meta Spatial SDK panel, left-right stereo mode, LiveKit room track binding, and hardcoded sample config caveats |
| `Cont-ai-ner/PointCast3D` | Already studied as point-cloud payload donor | RealSense point payload, UDP chunk headers, frame reassembly, Unity `MeshTopology.Points`, and packet-loss caveats |
| `studio4evr/FFMPEG-VRQ` | Empty/source-light exclusion | search result promised Quest VR180 SBS decode, but clone contained no source |
| `N78Wy/relavr` | Already studied as Quest sender-state donor | MediaProjection permission, foreground service, codec probing, signaling codec, adaptive downgrade, and receiver/security follow-up |
| `ranvuemor/SpatialVideoBrowser` | Already studied as browser-video surface reference | native Android WebView texture on Unity/Quest world surface, XRI composition, and package/lifecycle follow-up |

### Consolidation note

This family matters because many VR utilities need external surfaces before
they need full overlay products:

- live camera and remote support panels
- stereo video room viewers
- headset mirror/capture senders
- point-cloud diagnostics and calibration previews
- browser-video surfaces that bypass WebXR media limits
- transport health and downgrade UX

It suggests a stronger branch inside `VR-apps-lab` around:

- external surface ingress matrices
- Quest capture sender permission/state machines
- stereo panel format contracts
- low-latency media diagnostics and fallback UX

## Family 164: Accessibility, embodied locomotion, redirected walking, and zero-G control

This family covers locomotion as reusable utility knowledge: physical ability
assumptions, embodied input, configurable locomotion modules, redirected
walking, and zero-G comfort controls.

| Project | Status | Notes |
|---|---|---|
| `justinmajetich/vr-wheelchair` | Already studied as embodied locomotion donor | wheel XR interactables, disposable grab proxies, brake assist, haptic deceleration, and prototype thresholds |
| `XR-Access-Initiative/Locomotion-Accessibility-Toolkit` | Already studied as accessibility framing reference | gaze teleport, smooth locomotion, snap turn, instruction surfaces, and imported XRI sample caveat |
| `simeonradivoev/echo-unity` | Already studied as zero-G mechanics donor | hand grab joints, dynamic/static interactions, thruster heat, release dampening, IK, and comfort/realism toggle |
| `DigitalDiceworks/ddw-locomotion-system` | Already studied as locomotion abstraction donor | hub/input/modifier/movement split, event boundaries, sprint modifier, and legacy SteamVR caveat |
| `curvaturegames/space-extender` | Already studied as redirected-walking tooling donor | translation and rotation gains, overlapping rooms, editor scripts, CSV logging, and old Unity assumptions |
| `LariWa/VR-Locomotion` | Empty/source-light exclusion | search result described locomotion comparisons, but clone contained no source |

### Consolidation note

This family matters because locomotion tools should expose more than movement
vectors:

- physical ability and comfort assumptions
- input burden and embodiment model
- controller, hand, wheel, body, and environment constraints
- redirection gain and telemetry behavior
- realism versus comfort toggles
- user-facing explanation of movement modes

It suggests a stronger branch inside `VR-apps-lab` around:

- locomotion/accessibility option matrices
- configurable locomotion hub samples
- redirected-walking telemetry notes
- alternative embodiment input references

## Family 165: VR command surfaces, radial menus, launchers, and avatar-menu utilities

This family covers command surfaces used to control VR utilities: in-headset
radial menus, physical launcher metaphors, editor-side expression-menu tools,
and desktop OSC companions that replace slow in-game menus.

| Project | Status | Notes |
|---|---|---|
| `VRwithAndrew/VR-RadialMenu` | Source-light radial menu baseline | prefab/art shell with empty scripts; retained as tutorial contrast only |
| `Gustorvo/RadialMenuVR` | Already studied as radial-menu donor | numeric springs, item manager, hover/select events, attachments, menu movement/scaling, and roadmap caveats |
| `ryangadz/RadialMenu` | Source-light Unreal asset reference | `.uasset` plugin package with limited static extraction value |
| `GabrielDiDomenico/RadialMenu` | Already studied as wrist-menu concept | wrist-rotation idea, alpha-hit-test UI notes, and imported XRI sample caveat |
| `kblood/Quest-VR-Menu` | Already studied as physical launcher/menu reference | app cubes, collision confirmation, Android package/intent launching, and old Quest/Unity caveats |
| `CascadianVR/VRC-Menu-Translator` | Already studied as editor-side menu utility donor | recursive VRChat expression-menu traversal, bulk rename/translate, asset dirty/save, and undo/API caveats |
| `Tazaur/VrCScalingTool` | Already studied as desktop OSC command surface donor | scale slots, hotkeys, OSC receive triggers, OSCQuery, tray UI, SteamVR manifest, and Windows-specific caveats |

### Consolidation note

This family matters because VR command UX is broader than one radial menu:

- radial item placement and animation
- wrist or hand orientation selection
- physical command confirmation
- editor-side menu mutation and validation
- desktop companion slots, hotkeys, and OSC triggers
- safety bounds and state feedback for commands

It suggests a stronger branch inside `VR-apps-lab` around:

- VR command-surface comparison matrices
- reusable radial-menu architecture notes
- VRChat expression-menu editor tooling
- OSC macro companion design

## Family 166: Heart-rate, wearable, ANT/BLE, and sensor-to-avatar bridges

This family covers smaller biometric/sensor bridge variants that publish
wearable data to VRChat OSC parameters or chatbox surfaces.

| Project | Status | Notes |
|---|---|---|
| `kamyu1537/hr-osc` | Already studied as Tauri HTTP/OSC HR bridge | local HTTP BPM ingress, Rust OSC commands, UI/service split, and sparse setup caveat |
| `Curtis-VL/HeartRateOnStream-OSC` | Already studied as OBS/WebSocket compatibility shim | OBS-style WebSocket messages, text-source parsing, multiple HR parameter encodings, and hardcoded JSON caveats |
| `Solexid/OSC-VRChat-Feeder` | Already studied as Android sensor feeder reference | BLE/Mi Band HR and steps, phone sensors, profiles, normalization, and device-specific caveats |
| `TangNPC/ble-osc-heartrate` | Already studied as BLE advertisement micro-bridge | manufacturer data filter, fixed byte offset, raw/digit/float parameters, and stale-data caveat |
| `KotRikD/vrc_hyperate_chatbox` | Already studied as Hyperate chatbox bridge donor | Phoenix WebSocket, service heartbeat, debounce, trend formatting, Electron IPC, and API/config caveats |
| `DangerKiddy/HeartRateMonitorVRC` | Already studied as Windows BLE HR donor | GATT HR parsing, reconnect loop, derived parameters, beat emulation, session ranges, and Windows dependency caveat |
| `RedlineTriad/vrchat_ant_hr` | Already studied as ANT+ HR donor | ANT reader thread, computed/intra-beat BPM modes, anomaly filter, log mode, and hardware setup caveat |
| `Naraenda/osc-hr-ble` | Already studied as tiny BLE GATT HR donor | Heart Rate Measurement parser, optional energy/RR data, OSC bundle, digit/normalized parameters, and no UI caveat |

### Consolidation note

This family matters because sensor bridges repeatedly solve the same interface
problems across different transports:

- raw, digit, normalized, connected, active, and beat parameters
- BLE GATT versus BLE advertisement versus ANT+ transport
- service WebSocket, HTTP, OBS-WebSocket, and local phone ingress
- stale/reconnect/status behavior
- chatbox formatting and social presentation
- avatar prefab compatibility

It suggests a stronger branch inside `VR-apps-lab` around:

- biometric bridge compatibility tables
- sensor parameter schema conventions
- transport-specific failure-mode notes
- avatar telemetry and chatbox presentation helpers

## Family 167: VRChat OSC voice, STT, translation, and extensionable chatbox pipelines

This family covers voice-driven VRChat chatbox companions: microphone capture,
VAD, STT, translation, typing indicators, avatar-side control, and extension
hooks.

| Project | Status | Notes |
|---|---|---|
| `MrShitFox/FoxTrans` | Already studied as VAD-gated voice translation donor | WebRTC VAD, pre-roll, WAV packing, OpenRouter direct audio translation, `/chatbox/typing`, `/chatbox/input`, and cloud/privacy caveats |
| `ewrt101/OSC_Voice` | Already studied as chatbox input mode-router reference | time/file display, local STT, AssemblyAI realtime/chunk STT, manual OSC packing, typing state, and hardcoded/config caveats |
| `R-VUt/OSC-SRTC` | Already studied as avatar-controlled STT/translation pipeline | GUI, recognizer/translator routing, avatar language/PTT/on-off parameters, dual-language output, Romaji, Flask extension chain, and security caveats |

### Consolidation note

This family matters because voice-to-chatbox tools need reusable boundaries
beyond a single provider:

- microphone gating and speech segmentation
- local versus cloud recognizer routing
- translation provider abstraction
- typing and stale/error feedback
- avatar-controlled language/PTT state
- extension hooks with safe input/output contracts

It suggests a stronger branch inside `VR-apps-lab` around:

- provider-neutral voice sidecar contracts
- microphone privacy and cloud-audio checklists
- chatbox typing/status UX
- avatar-controllable speech translation utilities

## Family 168: VRChat chatbox media/status and bounded text composition microtools

This family covers chatbox tools that compose short bounded messages from
media playback, templates, system stats, active windows, lyrics, and tiny CLI
senders.

| Project | Status | Notes |
|---|---|---|
| `Voiasis/RustyChatBox` | Already studied as Linux Rust/egui chatbox composer | dependency-gated modules, playerctl/MPRIS media, system stats, persisted config, rosc output, and Linux/POC caveats |
| `bddvlpr/vrc-osc-spotify` | Already studied as Spotify OAuth and lyric scheduler donor | OAuth callback, token persistence, playback polling, chatbox sends, avatar bool state, lyric timeouts, and internal API caveats |
| `Massivendurchfall/vrchat-osc-spotify` | Already studied as polished Spotify status composer | PKCE auth, templates, progress bars, 144-char clamping, anti-spam, AFK tags, keepalive, and Windows/automation caveats |
| `Jakhaxz/VRChatSpotifyControler` | Already studied as avatar-menu media controller | OSC parameter input for play/pause, next/previous, volume, now-playing output, and Windows media-session caveats |
| `Null-K/VRChat-OSC-ChatBox` | Already studied as template-variable chatbox GUI | placeholder catalog, extension registry, preview, timed send, length warning, and cross-platform metric caveats |
| `WillW129/VRChat_OSC_Display_Mate` | Already studied as status aggregator microtool | active window, system stats, now playing, idle, Pulsoid HR, changed/keepalive sends, and privacy/Selenium caveats |
| `nekochanfood/VRChat_OSC_Chatbox_for_GO` | Already studied as tiny Go sender baseline | message/host/port flags, continuous mode, and minimal sender caveats |

### Consolidation note

This family matters because chatbox utilities repeatedly need the same
composition shape:

- source modules
- formatter/template layer
- message limit policy
- change detection and keepalive
- privacy-sensitive fields
- output send cadence

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable chatbox composer contracts
- media/status privacy controls
- text-length strategies and rotating pages
- tiny OSC sender baselines for scripts and diagnostics

## Family 169: Web, phone, and browser remote OSC control surfaces

This family covers browser and phone-facing control panels that send VRChat OSC
commands through local HTTP APIs or WebSocket relays.

| Project | Status | Notes |
|---|---|---|
| `sselecirPyM/WebVRChatOSC` | Already studied as local web OSC control panel | ASP.NET/Quasar UI, CoreOSC service, LiteDB custom buttons, avatar JSON parameter browser, chatbox/input controls, and public-binding/script risks |
| `MiaBub/VRChat-OSC-Controller-Client` | Already studied as browser/phone remote-control client | keyboard, joystick, jump, chatbox payloads, WebSocket reconnect/ping, and hardcoded/no-auth caveats |
| `MiaBub/VRChat-OSC-Controller-Server` | Already studied as WebSocket-to-OSC relay | command map, input-path sends, chatbox relay, key-up-all reset, profanity filter, and remote-control security caveats |

### Consolidation note

This family matters because remote OSC control is useful but risky:

- phone-first command surfaces
- custom button/action storage
- avatar parameter discovery
- WebSocket relay schemas
- key-up/emergency reset behavior
- authentication, origin, binding, and allowlist requirements

It suggests a stronger branch inside `VR-apps-lab` around:

- secure browser-to-OSC command schemas
- avatar parameter browser helpers
- remote-control safety checklists
- phone-accessible accessibility/control panels

## Family 170: VRC haptics server, firmware, hardware, and trigger bridge lineage

This family covers avatar-driven haptic output systems: VRChat OSC contact
ingress, haptic maps, interpolation, device managers, WiFi/BLE firmware,
hardware artifacts, preset triggers, and tracker haptics modules.

| Project | Status | Notes |
|---|---|---|
| `VRC-Haptics/VRCH-Server` | Already studied as mature VRC haptics manager | OSC batching, `/avatar/change`, haptic maps, interpolation, device manager, WiFi/BLE transports, and sidecar/config caveats |
| `VRC-Haptics/VRCH-Firmware` | Already studied as ESP haptics firmware donor | LittleFS config, serial/OSC commands, multicast discovery, haptic packet parsing, LEDC/PCA output, stale reset, and power/thermal caveats |
| `virtuallyaverage/VRC-Haptics-Host` | Already studied as readable Python lineage donor | mDNS discovery, VRC contact callbacks, board handler, modulation, compact output packets, and superseded protocol caveats |
| `virtuallyaverage/VRC-Haptics-Firmware` | Superseded firmware lineage reference | retained for protocol/history comparison only |
| `virtuallyaverage/VRC-Haptics-Hardware` | Hardware documentation lineage reference | PCB, Gerber, KiCad, BOM, CPL, and ordered JLC exports; development moved to newer hardware repo |
| `sync1211/HapticPatternTriggerOSC` | Already studied as bHaptics preset trigger bridge | tact imports, OSC boolean parameter mapping, pattern playback, false reset, and boolean-only caveat |
| `TahvoDev/AXHaptics` | Already studied as AXIS tracker haptics VRCOSC module | VRC/bHaptics-compatible parameter mapping, UDP node commands, proximity intensity, and deprecation caveat |
| `Pillazo/VRCHaptics` | Already studied as legacy DIY haptics baseline | VB.NET OSC host, serial provisioning, multicast intensity packets, BOM/hardware docs, ESP firmware, and old-stack caveats |

### Consolidation note

This family matters because haptic utilities need a device-neutral event layer:

- avatar/contact parameter ingress
- haptic event normalization
- maps, nodes, groups, and interpolation
- vendor preset trigger paths
- firmware packet protocols
- hardware safety and stale-output reset

It suggests a stronger branch inside `VR-apps-lab` around:

- haptic event schema matrices
- OSC-to-physical-output safety rules
- firmware/hardware documentation checklists
- device-neutral haptic routers and preset bridges

## Family 171: PSVR2 OpenXR passthrough, eye-tracking, and runtime-driver shims

This family covers PSVR2-specific runtime integration projects: OpenXR
passthrough layers, SteamVR eye-tracking shims, Monado driver forks, and
archived multi-source gaze layers.

| Project | Status | Notes |
|---|---|---|
| `Obsidiate/psvr2passthrough` | Already studied as PSVR2 OpenXR passthrough API layer | loader negotiation, dispatch interception, D3D11 session adoption, shared-memory camera feed, per-eye composition, button/config gates, and latency/calibration caveats |
| `BattleAxeVR/PSVR2_STEAMVR_EYE_TRACKING_SHIM` | Already studied as SteamVR gaze shim | HMD driver wrapping, named-pipe gaze ingress, validity checks, and high-risk Detours/driver-hook caveats |
| `DMJC/monado-psvr2` | Already studied as runtime-driver integration reference | Monado driver option, prober, USB endpoints, status/SLAM/camera paths, distortion, pose/view handling, and fork/runtime caveats |
| `etwodev/Volby` | Source-light product reference | retained only as PSVR2 SteamVR integration framing until source boundaries are visible |
| `mbucchia/_ARCHIVE_OpenXR-Eye-Trackers` | Already studied as archived multi-source OpenXR gaze layer | extension gating, tracker priority, PSVR2 Toolkit TCP polling, stale-data checks, and archival caveats |

### Consolidation note

This family matters because PSVR2 utility work repeatedly crosses risky
runtime boundaries:

- OpenXR API-layer interception
- SteamVR driver wrapping
- runtime driver integration
- camera/gaze calibration and stale-data gates
- user-controlled passthrough/gaze enablement

It suggests a stronger branch inside `VR-apps-lab` around:

- PSVR2 calibration and validity matrices
- API-layer versus driver-shim risk comparison
- vendor hardware data provider boundaries
- runtime-side passthrough/gaze safety checklists

## Family 172: VRChat OSC physical-output safety and device-control bridges

This family covers VRChat OSC bridges that can trigger physical device output.
The reusable focus is safety architecture: queues, cooldowns, panic stops,
source gates, rate limits, consent, and visible status.

| Project | Status | Notes |
|---|---|---|
| `ccvrc/DG-LAB-VRCOSC` | Already studied as DG-LAB/VRCOSC router | PySide6 tabs, YAML config, command queue, source flags/cooldowns, chatbox telemetry, SoundPad/ToN integrations, OSCQuery, and generated-code safety caveat |
| `amoeet/VRChat_X_DGLAB` | Source-light DG-LAB GUI variant | retained as thin Windows parameter-to-waveform bridge reference |
| `boyqiu-001/VRCHAT-OSC-to-DGLAB` | Already studied as parameter-rule mapper | Tkinter rule editor, judge modes, waveform patterns, channel/intensity/ticks, and minimal safety caveats |
| `ion-aluminium/VRC-DGLAB` | Already studied as service-oriented DG-LAB bridge | FastAPI/React split, OSC service, exact/regex listeners, job debounce, waveform fill, config/device services, and auth/safety gaps |
| `Null-K/DG-LAB-VRChat-Sensora` | Already studied as safety-window DG-LAB bridge | WebSocket/HTTP/OSC, distance/shock/touch modes, chatbox templates, channel limits, rate limits, safety window, and waveform monitor |
| `noideaman/ShockVRC` | Already studied as avatar-menu PiShock/OpenShock bridge | type/intensity/duration/target/touchpoint parameter schema and thin credential/safety caveats |
| `DesMakesStuff/PiShockTouch` | Already studied as contact receiver bridge and installer | avatar OSC JSON backup/patch, contact/menu parameters, PiShock API path, and rollback/safety caveats |
| `poprox24/VRChat-Shocker-Link-CPP` | Already studied as strongest safety hub donor | C++ ImGui, OSCQuery, PiShock/OpenShock/serial backends, queue, panic hotkey, global disable, cooldown curves, chatbox/notification telemetry |

### Consolidation note

This family matters because physical-output bridges should be judged primarily
by safety behavior:

- consent and local trust boundary
- max duration/intensity limits
- queue clearing and global disable
- panic hotkey behavior
- per-source and per-user cooldown
- chatbox/status visibility
- configuration validation

It suggests a stronger branch inside `VR-apps-lab` around:

- physical-output safety matrices
- avatar-parameter intent schemas
- device-agnostic output router contracts
- minimum requirements before any physical-output prototype is considered

## Family 173: VRChat MIDI, DMX, piano, and live-performance control bridges

This family covers MIDI and DMX as VRChat control/data planes: world lighting,
performer tools, piano clients, Udon sync, and physical controller mirrors.

| Project | Status | Notes |
|---|---|---|
| `micksam7/VRC-MIDIDMX` | Already studied as MIDI-to-DMX world data plane | packed note transport, control channel, `MIDIREADY` watchdog/backpressure, shader texture output, and crash-risk caveats |
| `marcus-universe/vrc_midi_transposer` | Already studied as Rust MIDI transposer and control bridge | OSC/MQTT/Home Assistant controls, MIDI forwarding, note-name OSC emission, and avatar setup docs |
| `laserimouto/UDJ-1000` | Already studied as physical DJ controller mirror | UdonSynced controller arrays, transform/material/text updates, Python CC filter, and DDJ-specific caveats |
| `fltuna/USharp-midi-tuna` | Already studied as Udon MIDI piano/player | note/control callbacks, sustain, voice budget, event sync emulation, pitch conversion, and editor source-generation tool |
| `Mathieu52/OSCMidi` | Already studied as PySide performer MIDI-to-OSC GUI | device selectors, MIDI output forwarding, note/path mapping, particle buffer, reset behavior, and repo-hygiene caveats |
| `ShadowForests/OSCPianoPlayer` | Already studied as MIDI-file to OSC scheduler | tempo/tick parsing, key sends, reset flow, old-library caveats, and world-specific paths |
| `MaverickLong/midi-osc-client` | Already studied as tiny MIDI-to-OSC compatibility CLI | key-index/name/pedal schemas, persisted config, and setup bug caveat |
| `labthe3rd/vrcMidiOverNetworkExample` | Already studied as Udon sync telemetry example | ownership, `RequestSerialization`, success/loss counters, byte counts, and latency display |

### Consolidation note

This family matters because MIDI performance bridges need the same recurring
boundaries:

- input device selection and reconnection
- note/path schema compatibility
- backpressure and rate limits
- Udon manual sync and diagnostics
- stuck-note reset behavior
- world-specific path profiles
- physical control surface filtering

It suggests a stronger branch inside `VR-apps-lab` around:

- MIDI path-schema matrices
- backpressure patterns for high-volume world control
- performer-facing configuration UX
- sync telemetry and voice/particle budget checklists

## Family 174: Twitch and audience-event to VRChat OSC control surfaces

This family covers Twitch/audience triggers that execute VRChat OSC actions:
chat commands, channel points, bits, subs, follows, moderation events, command
decks, and timed OSC pulses.

| Project | Status | Notes |
|---|---|---|
| `seluvia/crystal-relay-public` | Already studied as mature audience-event rule engine | trigger/action models, reward identity, chat-command fusion, managed rewards, manual OSC packets, world guard, moderation UX, and strongest product donor value |
| `AcChosen/EZTwitchOSCBot` | Already studied as Electron command deck | 12 command slots, OSC value types, timed reset message, whitelist, delay, save/load profiles, and hardcoded-slot caveat |
| `Motscoud/VRChatTwitchOSCTrigger` | Already studied as minimal Twitch IRC to OSC pulse script | command parse, OSC send/reset, hardcoded channel/commands, and no moderation/cooldown caveat |
| `Killers0992/TwitchIntegration` | Already studied as TwitchLib event model donor | chat/PubSub handlers, reward/bits/sub/follow/ban/timeout configs, access gates, global/user delays, random actions, and OSC action queues |
| `Killers0992/TwitchVrcAvatarOSC` | Source-light migration reference | retained as successor pointer only |
| `Maikatura/LucentOSC` | Already studied as native command-tree app | Twitch IRC client, Discord/VRChat command classes, movement/look/parameter/avatar/speak commands, and broad native app caveats |
| `exmello/RizumuBot` | Already studied as Twitch camera-command bot | bot/self filters, camera aliases, chat replies, timed OSC float pulse, and narrow command-surface caveats |

### Consolidation note

This family matters because audience control surfaces can easily become
unbounded remote-control channels:

- permission gates and streamer control
- per-user/global cooldown
- reward lifecycle and identity
- world or context guards
- queued versus parallel action execution
- timed reset pulses
- chatbox and chat feedback

It suggests a stronger branch inside `VR-apps-lab` around:

- provider-neutral audience trigger schemas
- safe OSC action queues
- moderation-aware command decks
- streamer control-panel and overlay integration patterns

## Family 175: VRChat chatbox status, media, lyrics, IDE presence, and MOTD micro-composers

This family covers small and medium VRChat chatbox utilities that compose short
bounded text from IDE state, media playback, lyrics, system status, plugin
outputs, speech recognition, and translation.

| Project | Status | Notes |
|---|---|---|
| `Null-K/VRChatStatusTask` | Already studied as IDE presence micro-composer | IntelliJ scheduled service, placeholders, editor highlighter counts, line/file fields, cropping, and privacy caveats |
| `bunboop/vrc-osc-mpris` | Already studied as Linux MPRIS media sender | TOML config, active/named player lookup, small-bubble formatting, progress fields, and no-player loop caveat |
| `Auzlex/vrchat-osc-windows-media` | Already studied as Windows media sender | Windows Media Controls polling, playback-type filter, duplicate-send gate, and bundled-artifact caveat |
| `lexiuwu71/sillyosc` | Already studied as multi-source status composer | time/media/system stats, scrolling title, Discord RPC side channel, simple config, and process-title privacy caveat |
| `lexiuwu71/mpd-vrchat-osc` | Already studied as MPD micro-bridge | tiny now-playing/remaining-time sender baseline |
| `AtomikkuLabs/VRC-Lyrics` | Already studied as lyrics/provider pipeline | Flet UI, Spotify/Windows playback providers, LRCLib/Spotify lyrics, worker queue, chatbox/parameter OSC managers, and credential caveats |
| `kotleni/vrchat-osc-motd` | Already studied as plugin fan-in composer | plugin loader, MOTD/AFK/PC stats/Spotify modules, output join, fixed port, and plugin trust caveat |
| `KannaCS/VRCTalk` | Already studied as STT/translation chatbox sidecar | Tauri/Rust OSC commands, WebSpeech/Whisper providers, mute listener, typing indicator, translation retry, and cloud/privacy caveats |

### Consolidation note

This family matters because chatbox tools repeatedly need the same reusable
shape:

- source/provider modules
- template and formatter layer
- cropping or message-length policy
- change detection and send cadence
- typing and clear-on-stop behavior
- privacy controls for sensitive source fields

It suggests a stronger branch inside `VR-apps-lab` around:

- provider-neutral chatbox composer contracts
- status privacy and cadence matrices
- plugin trust policy for local chatbox modules
- voice/media/IDE status sidecar boundaries

## Family 176: VRChat audio-reactive OSC, AudioLink-style, soundboard, and audio-control sidecars

This family covers audio bridges that either send audio-derived data into
avatar parameters or use avatar parameters to control local audio, soundboards,
media keys, haptics, and DSP engines.

| Project | Status | Notes |
|---|---|---|
| `shadorki/vrc-osc-audio-controls` | Already studied as avatar menu to media-key bridge | Go OSC listener, play/pause/next/previous/mute parameters, Windows SendKeys backend, and parsing/debounce caveats |
| `Codel1417/VRC-OSC-Audio-Reaction` | Already studied as loopback audio-reactive donor | NAudio WASAPI loopback, stereo RMS/direction, smoothing, thresholded sends, precision floor, and telemetry caveat |
| `octalmage/oscsound` | Already studied as OSCQuery local soundboard | Wails/Go app, avatar parameter advertising, one-shot/loop sounds, soundpack import/export, preview, and local-routing caveat |
| `FreneticFurry/VRC-Visualizer` | Already studied as FFT visualizer baseline | sounddevice/numpy FFT, smoothing, delayed parameter history, and hardcoded setup caveats |
| `bWoojer/WoojerOSC` | Already studied as haptic event to tactile audio bridge | bHaptics OSC/log parsing, sine provider pool, pan/frequency mapping, preset timers, and physical-output safety caveats |
| `Zeno-Fluff/OALSVRC` | Source-light external AudioLink product reference | system audio capture, FFT bands/waveform/amplitude OSC, GUI routing claims, and source/license caveats |
| `Azumarite/Dynamic-Vocoder-and-Instrument-with-Supercollider-VRChat` | Already studied as avatar-controlled DSP script | SuperCollider vocoder/effect toggles, synth pitch mapping, and manual audio routing caveats |

### Consolidation note

This family matters because audio sidecars share recurring engineering
boundaries:

- capture source and device selection
- normalization, smoothing, thresholding, and value floors
- avatar parameter schemas for volume/bands/direction
- one-shot versus looping local output
- reset/debounce for avatar-to-audio controls
- physical/tactile output safety

It suggests a stronger branch inside `VR-apps-lab` around:

- external AudioLink-style sidecar contracts
- OSCQuery soundpack utilities
- avatar menu to OS command bridges
- audio-reactive safety and privacy checklists

## Family 177: XSOverlay Discord and remote notification protocol bridges

This family covers projects that send external events into XSOverlay through
direct UDP, WebSocket companion transports, Discord client hooks, Discord RPC,
or authenticated remote proxies.

| Project | Status | Notes |
|---|---|---|
| `GreyFoxx74/xsoverlay-proxy` | Already studied as remote notification proxy | HTTPS POST to local XSOverlay UDP, auth key, rate limits, health check, CLI sender, watchdog, and LAN/TLS caveats |
| `nitrog0d/XSOverlay-Discord-Notifications` | Already studied as Powercord notification bridge | Discord notification hook, payload construction, timeout/opacity settings, icon fetch, and stale client-mod caveat |
| `Eidenz/XSOverlay-BetterDiscord` | Already studied as BetterDiscord formatting donor | DM/server toggles, mute/mention policy, mention/role/emote/channel formatting, attachment labels, and avatar base64 icons |
| `nyakowint/xsOverlayVencord` | Already studied as strongest Discord hook donor | Vencord settings, bot/server/DM/group/call filters, image/attachment handling, WebSocket transport, and UDP fallback |
| `Arsenic110/XSOverlay-BetterDiscord-Notifications` | Already studied as BetterDiscord variant | duration/opacity settings, cooldown, DND/ignore checks, formatting helpers, and copied-client-code caveats |
| `jpdown/Discord-XSOverlay-Notifications` | Already studied as Discord RPC baseline | notification subscription, icon download, XSOverlay UDP payload, and OAuth/RPC caveats |

### Consolidation note

This family matters because overlay notification bridges sit on a trust
boundary:

- local overlay-host protocol compatibility
- direct UDP versus WebSocket companion transport
- remote proxy auth, TLS, and rate limits
- Discord message normalization and privacy
- icon/image fetch handling
- client-mod compatibility risk

It suggests a stronger branch inside `VR-apps-lab` around:

- overlay notification payload matrices
- secure remote event-to-overlay proxy design
- communication notification UX
- transport fallback and compatibility checklists

## Family 178: VRChat avatar remote control, toy automation, time, and smart-light sidecars

This family covers VRChat OSC utilities that expose remote control surfaces,
sequence automation, generic sender/receiver harnesses, physical-output
bridges, web toys, and tiny external-state-to-avatar bridges.

| Project | Status | Notes |
|---|---|---|
| `Sakura0721/osc-toys` | Already studied as safety-sensitive OSC-to-device WebUI | FastAPI/WebUI, Coyote BLE interface, moving-average smoothing, max-power sliders, patterns, safe-mode caps, and auth/panic-stop caveats |
| `UnusualNorm/VRChat-OSC-Toys` | Already studied as web toy/menu reference | Next.js/Socket.IO namespaces, shared cursors, MIDI-to-avatar note channels, avatar toy menu, and incomplete/auth caveats |
| `Blise518B/OscGoesPurrr` | Source-light multi-backend haptic router product reference | smoothing, OSCQuery/product claims, backend list, profile/debugger framing, and source-boundary caveats |
| `jangxx/VRC-Avatar-Remote-Server` | Already studied as strongest remote-board donor | Express/Socket.IO boards, avatar/group/control schema, sessions/API keys, avatar hashing, active-avatar checks, and OSC send boundaries |
| `njm2360/vrchat-osc-automator` | Already studied as strongest automation donor | WPF/MVVM sequencer, polymorphic slots, loops, breakpoints, transitions, reset-on-complete, keyboard/mouse cleanup, import/export, and tests |
| `t-34400/SimpleVRChatOSCSender` | Already studied as generic OSC harness | Tkinter tabs for avatar params, input, chatbox, trackers, receiver rebuild, and config controls |
| `TheUnifox/OSCTimeSender` | Already studied as tiny local time bridge | normalized hour/minute parameters, 10-second cadence, and fixed-path/port caveats |
| `hrolfurgylfa/vrchat-light-sync` | Already studied as smart-home state bridge | Home Assistant polling, hue/brightness normalization, change-only sends, config, and bearer-token caveats |

### Consolidation note

This family matters because remote and automated avatar control needs explicit
safety boundaries:

- authentication and local trust scope
- active-avatar validation
- board/control schemas and parameter types
- reset-on-complete and held-input cleanup
- remote exposure and rate limits
- physical-output caps and panic stops
- credential handling for external services

It suggests a stronger branch inside `VR-apps-lab` around:

- secure avatar remote-control boards
- reusable OSC automation sequence schemas
- generic VRChat OSC harnesses
- external state/device micro-bridge patterns

## Family 179: VRCOSC module packs, add-on modules, and plugin-distribution boundaries

This family covers official and third-party VRCOSC modules that extend the host
with live services, sensors, media state, voice commands, avatar-parameter
compatibility, SteamVR/OpenVR body-device data, local files, and non-Twitch
audience events.

| Project | Status | Notes |
|---|---|---|
| `VolcanicArts/VRCOSC-Modules` | Already studied as official module suite | typed SDK usage, EventSub nodes, media/status controls, voice commands, parameter sync, PiShock, OpenVR gestures, persistent state, runtime views, and service/physical-output caveats |
| `CrookedToe/CrookedToe-s-Modules` | Already studied as third-party module pack | OSCLeash wildcard/legacy path compatibility, movement reset, OpenVR chaperone manipulation, audio bands, AGC, spike detection, and movement/audio caveats |
| `Yeusepe/Yeusepes-Modules` | Already studied as service-heavy module pack | Spotify, Discord, Shazam, QR/code surfaces, VRChat API helpers, broad avatar parameters, and credential/native dependency caveats |
| `FuviiPeshu/FuviiOSC` | Already studied as SteamVR/VRChat body-device modules | tracker haptics, paw/controller parameter mapping, trigger modes, token cancellation, avatar changer, and physical-output/tracker-role caveats |
| `WentTheFox/VRCOSC-BluetoothHeartrate` | Already studied as BLE sensor module | device selection persistence, scan/reconnect state, runtime view, avatar parameter output, and optional WebSocket rebroadcast |
| `RichiCoder1/VrcOscLeash` | Already studied as avatar-prefab compatibility shim | avatar-config-driven discovery, wildcard route handling, legacy paths, movement/look/run outputs, and safe reset |
| `03milo/File-Reading-Module` | Already studied as file-to-chatbox micro-module | local file polling, chatbox variable/event output, path privacy, and length/cadence caveats |
| `TZFC/VRCOSC-Bilibili` | Already studied as non-Twitch live-event bridge | async queues, chatbox and animation consumers, parameter accumulation, decay behavior, and credential/i18n caveats |

### Consolidation note

This family matters because a VR utility host grows through its module boundary:

- typed module lifecycle and settings
- persistent module state and runtime views
- avatar parameter contracts and compatibility shims
- service credentials and local trust surfaces
- physical-output and OpenVR movement safety
- queueing, accumulation, decay, and backpressure for live events
- third-party module distribution and versioning

It suggests a stronger branch inside `VR-apps-lab` around:

- VRCOSC-style module host contracts
- third-party module trust matrices
- event-source-to-avatar queue patterns
- avatar prefab compatibility layers
- sensor and local-file micro-module baselines

## Family 180: Networked-AFrame adapters, persistence, media, and Unity-client variants

This family covers Networked-AFrame periphery: signaling adapters, SFU media
adapters, room UX shells, entity persistence, ownership handoff, synced media,
spatial audio streams, and cross-runtime Unity clients.

| Project | Status | Notes |
|---|---|---|
| `networked-aframe/naf-firebase-adapter` | Already studied as Firebase adapter | Realtime Database presence cleanup, WebRTC peer data channels, timestamp offer tie-breaker, and guaranteed backend messages |
| `mozilla/naf-janus-adapter` | Already studied as Janus SFU adapter | media streams, reliable/unreliable transports, reconnect jitter, frozen updates, join tokens, and block/kick primitives |
| `networked-aframe/naf-valid-avatars` | Already studied as NAF social room shell | avatar picker, username entry, presence store, users/chat panels, mic/screen/camera controls, and CDN/media caveats |
| `ttravaglini/networked-aframe-unity-client` | Already studied as Unity NAF/EasyRTC client | Socket.IO auth/join, networked entity ownership, schema parsing, interpolation, and incomplete ownership caveats |
| `chenzlabs/networked-aframe-synced-video-example` | Already studied as synced media micro-component | owner-gated paused/currentTime state, time slop, singleton network id, and buffering/owner-transfer caveats |
| `martintribo/naf-persist` | Already studied as entity persistence layer | PouchDB serialization, DOM/NAF id options, local-vs-remote preference, and conflict caveats |
| `martintribo/naf-entity-saver` | Already studied as ownership handoff caveat | strips `networked-remote`, reattaches local `networked`, preserves entities, and exposes NAF ownership fragility |
| `AudioGroupCologne/networked-resonance-audio` | Already studied as media-stream spatial audio bridge | adapter media stream lookup, Three/Resonance positional audio binding, and browser media caveats |

### Consolidation note

This family matters because shared WebXR rooms need more than synchronized
transforms:

- signaling and presence
- reliable control data versus high-rate state updates
- audio/video/screen media streams
- reconnect and moderation primitives
- avatar selection and room entry UX
- entity ownership and persistence
- cross-runtime client schema mapping

It suggests a stronger branch inside `VR-apps-lab` around:

- adapter contracts independent of one WebXR framework
- shared-room persistence and ownership checklists
- media-stream to spatial-audio bridges
- social room entry and presence shells

## Family 181: Lightweight XR editor, tour-builder, live-coding, and creator microtools

This family covers narrow authoring tools that let users place, edit, serialize,
export, or automate VR content without becoming a full engine/editor.

| Project | Status | Notes |
|---|---|---|
| `Humangle/VRTourEditor` | Already studied as browser 360 tour editor | `.hvrj` manifest, link placement, desktop/VR ray picking, localStorage autosave, save/export zip, and generated WebXR runtime |
| `caseyyee/aframe-vreditor-component` | Already studied as in-headset A-Frame edit primitive | grip/collision selection, reparent-on-grab, clone-on-two-hand grab, axis scaling, and old API/no-undo caveats |
| `wakufactory/GNode` | Already studied as visual scene graph | node/socket/joint model, graph serialization, node edit bridge, A-Frame output, and validation caveats |
| `flushpot1125/WebXR_VRController_Editor_template` | Already studied as Babylon.js WebXR controller template | generated script lifecycle, `fromScene` links, motion-controller component handling, and hardcoded input-index caveats |
| `dkaraush/vrcode` | Already studied as WebXR text/code workspace | movable VR displays, ray-drag state, VR keyboard mesh, textarea object, and incomplete IDE/persistence caveats |
| `umiyuki/UnityVRAnimationEditor` | Already studied as in-VR Unity animation editor | grabbable animation nodes, VRTK interaction, Undo-backed curve recording, Animation Window reflection, and modernization caveats |
| `evanw/webgl-vr-editor` | Already studied as historical Cardboard/WebGL voxel editor | edit/play modes, orientation-relative cursor, undo tracker, file save/load, and obsolete headset/toolchain caveats |
| `Reava/VRC-Editor-Toolbox` | Already studied as Unity/VRChat creator microtools | circle placement, teleport-to-transform, sequential naming, light-volume toggles, Bakery mass editing, and Undo/scope caveats |

### Consolidation note

This family matters because lightweight authoring tools are often the fastest
path from research idea to reusable utility:

- ray selection and object manipulation
- manifest, graph, entity, or animation serialization
- undo and reset semantics
- generated runtime export
- in-headset authoring plus desktop editor bridge
- one-operation production microtools

It suggests a stronger branch inside `VR-apps-lab` around:

- serializable XR authoring surfaces
- in-headset edit primitives
- VR text/keyboard workspaces
- Unity/VRChat creator microtools
- authoring UX matrices across selection, manipulation, undo, and export

## Family 182: ContactGlove, Haritora, and vendor tracker bridge sidecars

This family covers vendor-specific glove and tracker bridges that translate
ContactGlove or Haritora data into generic SteamVR/OpenVR inputs, VRChat avatar
packages, keyboard input, SlimeVR packets, VMC/OSC streams, and camera/IMU
fusion sidecars.

| Project | Status | Notes |
|---|---|---|
| `hyblocker/freescuba` | Already studied as ContactGlove OpenVR driver and overlay | driver/overlay split, serial protocol, named-pipe IPC, skeleton/input components, pose/input threads, input profiles, and high-risk driver caveats |
| `Diver-X/ContactGloveOSC` | Already studied as official VRChat avatar setup package | automatic setup, full/lite parameters, expression menus, hand-sign copy tools, VPM package shape, and controller conflict caveats |
| `1000100Den/Glove2Kb` | Already studied as hand-pose to keyboard/pointer bridge | VMC/OSC bone reception, origin/deadzone correction, grip gating, pointer movement, and OS-input safety caveats |
| `sim1222/haritorax-slimevr-bridge` | Already studied as Rust Haritora BLE to SlimeVR bridge | BLE characteristic UUIDs, IMU decode, battery/button notifications, handshake, rotation/gravity packets, and reconnect/role caveats |
| `JovannMC/haritorax-interpreter` | Already studied as Haritora interpreter library | COM/Bluetooth/Linux-Bluetooth modes, EventEmitter API, tracker maps, IMU/battery/button/mag/info events, and maturity caveats |
| `JovannMC/haritora-gx-poc` | Already studied as thin Haritora GX protocol probe | serial echo parsing, line classification, IMU decode, battery/button logging, and prototype caveats |
| `cytsai1008/HaritoraToSlime` | Already studied as Python OSC to SlimeVR bridge | config bootstrap, broadcast handshake, add-IMU packets, rotation/accel encoding, and parser/acceleration caveats |
| `Fuwaaaaaa/osc_haritorax2_camera_tracking` | Already studied as mature camera/IMU tracking sidecar | receiver abstraction, camera subprocess/shared memory, fusion engine, event bus, preflight checks, REST/dashboard/OBS/VMC outputs, persistence, and tests |

### Consolidation note

This family matters because vendor tracker/glove utilities need a clean generic
output boundary:

- SteamVR/OpenVR driver input and skeleton components
- VRChat avatar setup and parameter packages
- VMC/OSC hand/body pose streams
- SlimeVR UDP handshake and packet encoding
- keyboard/input bridges with explicit gating
- camera/IMU fusion and diagnostics
- calibration, role mapping, stale-data checks, and battery/status output

It suggests a stronger branch inside `VR-apps-lab` around:

- vendor protocol interpreter libraries
- tracking bridge diagnostic checklists
- SlimeVR/VMC/SteamVR output comparison matrices
- driver-versus-sidecar risk boundaries
- generic receiver protocols before device-specific prototypes

## Family 183: WebXR runtime/dev scaffolding, polyfills, emulators, and input profile loaders

This family covers projects that make browser-native XR development possible
when the real runtime is missing, incomplete, browser-specific, or inconvenient
for iteration.

| Project | Status | Notes |
|---|---|---|
| `immersive-web/webxr-polyfill` | Already studied as runtime fallback donor | guarded API-class injection, `navigator.xr` fallback, WebGL compatibility patching, abstract `XRDevice`, and stale WebVR/Cardboard caveats |
| `MozillaReality/WebXR-emulator-extension` | Already studied as extension emulator donor | content-script/page custom events, devtools panel, pose/button/device messages, and old 2019 draft caveat |
| `De-Panther/webxr-input-profiles-loader` | Already studied as input-profile model loader | profile-list/profile JSON cache, handedness layout routing, glTF visual-response nodes, and Unity/CDN caveats |
| `michelesandroni/xrview` | Already studied as standalone emulator shell | Tauri toolbar/browser webviews, all-frame IWER injection, URL gating, and capability isolation |
| `holokit/holokit-webxr` | Already studied as viewer-specific device adapter | HoloKit immersive AR sessions, multiview projection/viewport logic, and device-specific caveats |
| `realitydeslab/holoweb-webxr-polyfills` | Fork / variant only | HoloKit-style module-surface comparison node with overlapping donor value |
| `mvilledieu/magicleap-helio-webxr-polyfill` | Already studied as vendor-browser API shim | Helio support/session/frame/input/reference-space wrappers and hardcoded stale-browser assumptions |

### Consolidation note

This family matters because WebXR utilities need a testable runtime boundary:

- app-facing `navigator.xr` versus device backend
- extension or shell UI versus injected page runtime
- dev-only emulation versus production headset behavior
- controller input-profile metadata versus rendered engine model
- standalone browser shell trust isolation
- tiny compatibility shims for browser API drift

It suggests a stronger branch inside `VR-apps-lab` around:

- WebXR runtime compatibility matrices
- emulator/test harness shells
- controller/profile visualization utilities
- browser-native XR prototype scaffolds
- security checklists for embedded browser shells

## Family 184: A-Frame UI, locomotion, environment, and physics micro-components

This family covers small A-Frame components that package one reusable scene,
input, environment, physics, or rendering behavior behind a declarative schema
and event/lifecycle contract.

| Project | Status | Notes |
|---|---|---|
| `c-frame/aframe-cursor-teleport` | Already studied as cursor teleport fallback | camera raycast, collision/ignore selectors, default ground plane, landing angle, marker, and transition easing |
| `supermedium/aframe-super-keyboard` | Already studied as text-entry component donor | keyboard atlas, raycaster UV mapping, filters, max length, hand/raycaster integration, and value events |
| `supermedium/aframe-environment-component` | Already studied as environment generator | presets, sky/fog/lights/ground/grid, terrain/dressing generation, and quick scene context |
| `n5ro/aframe-physics-system` | Already studied as physics substrate donor | local/worker/network/ammo drivers, CANNON body sync, fixed timestep, worker snapshots, and debug hooks |
| `supermedium/aframe-react` | Already studied as framework bridge reference | React prop diffing to A-Frame attributes/events, primitive mapping, and old React API caveat |
| `topstar-ai/aframe-blink` | Already studied as teleport UX donor | parabolic target, rotation output, hit/miss colors, thumbstick support, and `teleported` event payload |
| `EX3D/aframe-daylight-system` | Already studied as daylight micro-reference | time/location sun position, sky shader, and fog controls |
| `msfeldstein/aframe-environment-map-component` | Already studied as environment-map helper | CubeCamera/PMREM capture, environment-only visibility, envMap assignment, and old Three API caveat |

### Consolidation note

This family matters because component-sized XR utilities can be reused across
many prototypes:

- schema-driven configuration
- raycaster, cursor, UV, or controller input adapters
- visible event payloads for teleport, text, and physics
- system/driver boundaries for runtime substrates
- environment presets for fast spatial context
- lifecycle cleanup and asset ownership

It suggests a stronger branch inside `VR-apps-lab` around:

- component contract templates for future browser XR utilities
- VR text-entry and keyboard comparison matrices
- locomotion event/comfort baselines
- physics-driver and worker-boundary studies
- quick environment/staging helpers for interaction labs

## Family 185: Godot XR addon periphery: hands, tracker bridges, recording, and reference plugin baselines

This family covers Godot XR addon projects that turn external protocols, hand
poses, live trackers, and toolkit functions into engine-native XRServer,
animation, or scene-node boundaries.

| Project | Status | Notes |
|---|---|---|
| `patrykkalinowski/godot-xr-kit` | Already studied as XR addon kit reference | template hand-pose recognition, quaternion scoring, pose-change signals, movement/smoothing/cinematic primitives |
| `RevolNoom/godot_xr_handtracking` | Already studied as hand interaction donor | pose catalogue, stabilized matching, pose-gated pick areas, hand snap, ranged/touch modes, and setup warnings |
| `Malcolmnixon/GodotXRVmcTracker` | Already studied as strong tracker bridge donor | OSC/VMC parser, body/face tracker registration, position modes, joint/blend mapping, root transform, and confidence flags |
| `Malcolmnixon/GodotXRAxisStudioTracker` | Already studied as vendor tracker variant | Axis Studio source to `XRBodyTracker`, position modes, joint mapping, and vendor caveats |
| `Malcolmnixon/GodotXRRokokoTracker` | Already studied as vendor tracker variant | body/face/finger optional modalities, tracker flags, and packet assumptions |
| `Malcolmnixon/GodotXROpenXRTracker` | Thin tracker demo/reference | OpenXR body/hand tracker setup, `XRServer.world_scale`, and demo-level controls |
| `Malcolmnixon/GodotXRAnimationRecorder` | Already studied as recorder donor | tracker stream sampling, body/face/hand resources, skeleton/blendshape tracks, root motion, timestamps, and optimization |
| `GodotVR/godot_xr_reference` | Already studied as native interface baseline | minimal `XRInterface` lifecycle, head tracker, view transforms, projection, distortion/display properties |
| `BastiaanOlij/godot-xr-tools2` | Already studied as toolkit architecture donor | hand attachment functions, teleport gating, movement-provider disable, fade, ray/arc target, slope/collision checks |

### Consolidation note

This family matters because Godot can host compact XR utilities if the addon
boundaries stay clean:

- pose templates versus raw skeleton reads
- pick areas and hand snaps as object-local affordance contracts
- protocol source nodes versus XRServer tracker consumers
- body, face, and finger capabilities as optional outputs
- recorder sampling separated from animation/resource writing
- toolkit functions separated from player composition
- native interface baselines before custom runtime logic

It suggests a stronger branch inside `VR-apps-lab` around:

- Godot tracker-source bridge templates
- hand-pose and pose-gated affordance studies
- tracker recording and replay diagnostics
- modular Godot XR toolkit primitives
- Godot native XRInterface learning notes

## Family 186: React/Three XR runtime, spatial UI, and interaction lab surfaces

This family covers browser-native React/Three XR substrates: runtime stores,
spatial UI layout/input, lab shells, AR measurement/model-viewer microtools,
and hand/product UI references.

| Project | Status | Notes |
|---|---|---|
| `pmndrs/xr` | Already deepened as strong runtime donor | XR store, session/input/layer/frame state, `WebXRManager` binding, emulator injection, typed input-source states, teleport, and React boundary |
| `pmndrs/uikit` | Already studied as strong spatial UI donor | Yoga/flex layout, pointer ordering/clipping, scroll, text selection, hidden DOM input bridge, and component kits |
| `kewanglab/webxr-playground` | Already studied as interaction lab shell | lab registry, tuning presets, XR root/origin, TagAlong HUD, selection/manipulation labs, session logger, and shell framing |
| `WawasCode/DefaultReactXR` | Already studied as thin starter reference | Vite/TypeScript starter, pointer config, UIKit enter button, support checks, and starter-only caveats |
| `randykeller11/xrTeleport` | Already studied as locomotion micro-reference | raycast teleport target, normal-aligned indicator, player pose update, snap rotation, and old API caveats |
| `alxxtexxr/react-three-xr-measurement` | Already studied as AR measurement microtool | hit-test reticle, select point capture, line/label distance, and no-persistence caveat |
| `BOLTEVM/BoltXR` | Already studied as cautious product/hand UI reference | WebXR panels, IWER emulation flag, MediaPipe pinch/tap/drag/scale overlay pipeline, and crypto/product caveats |
| `aazutaku/glb-ar-viewer` | Already studied as AR model viewer reference | upload/key routing, WebXR/dom-overlay store, iOS fallback, animation toggle, transform controls, and model streaming |

### Consolidation note

This family matters because browser-native XR utilities need both runtime and
UI foundations:

- store-owned WebXR session and input state
- typed hand/controller/gaze/screen/transient input states
- pointer event routing and teleport target filtering
- spatial UI layout, clipping, scroll, text, and focus
- interaction labs with HUD, live tuning, and session notes
- small AR measurement/model-viewer utilities
- cautious hand-landmark overlay gesture references

It suggests a stronger branch inside `VR-apps-lab` around:

- React/Three XR app-shell baselines
- spatial UI and form/input prototypes
- interaction lab scaffolds for comparing techniques
- browser-native diagnostic HUDs and session loggers
- AR asset viewer and measurement micro-utilities

## Family 187: Overlay media micro-surfaces: notes, telemetry shells, browser bootstraps, and direct video overlays

This family covers small overlay projects that prove a surface can be brought
into VR without a large application shell: image/note overlays, Unity telemetry
panels, browser-backed runtime bootstraps, and direct media-player texture
submission.

| Project | Status | Notes |
|---|---|---|
| `Yukiiro-Nite/notebook-vr-overlay` | Deepened in Wave 208 | minimal OpenVR note/image surface with mouse input scale, tracked-device placement, event loop, hardcoded paths, and incomplete persistence |
| `Daniel-Webster/WT-OpenVR-Overlay` | Deepened in Wave 208 | Unity/OVRLay telemetry shell with render textures, dashboard thumbnails, tracked-device transforms, OpenVR mouse routing, and local War Thunder JSON/image polling |
| `Wulkop/VolumeVR` | Deepened in Wave 208 as weak donor | CEF/windowless browser bootstrap with remote-debug/no-sandbox caveats; inspected source did not confirm overlay submission |
| `iigomaru/MPVR` | Deepened in Wave 208 | direct libmpv/OpenGL/OpenVR overlay texture loop with controller-relative placement and rough proof-of-concept caveats |

### Consolidation note

This family matters because future VR utility surfaces can choose the smallest
surface producer that proves the value:

- static or generated image surface for notes and checklists
- Unity render texture for telemetry dashboards
- browser/CEF surface for HTML-based control panels
- native media-engine texture for video playback
- explicit input, placement, lifecycle, and persistence boundaries

It suggests a stronger branch inside `VR-apps-lab` around:

- surface-producer comparison matrices
- direct media-to-overlay prototypes
- overlay note/checklist microtools
- browser-backed overlay caution notes
- telemetry panel shell reuse

## Family 188: XR glasses WebHID protocol workbenches and head-tracked desktop helpers

This family covers Nreal/Xreal-style device protocol tools and lightweight
desktop helpers that turn XR glasses into diagnosable sensors, displays, or
head-tracked viewport surfaces.

| Project | Status | Notes |
|---|---|---|
| `jakedowns/xreal-webxr` | Deepened in Wave 209 | browser WebHID workbench with device filtering, packet/message tables, IMU/status parsing, Air/Light routing, and firmware-command caveats |
| `alexwilson1/nreal_linux_test` | Deepened in Wave 209 as Linux/X11 POC | external-driver pose parsing, GStreamer/X11 capture, yaw calibration, and multi-monitor viewport slicing |
| `edwatt/real_utilities` | Deepened in Wave 209 | native hidapi utility with separate IMU/control interfaces, command metadata, packet build/parse helpers, CRC, and calibration reads |
| `Mailbot/Nreal_Air_Desktop_tool` | Deepened in Wave 209 as product reference only | desktop windows, saved layouts, curvature, drift correction, focus recovery, and menu-control ideas without source-depth evidence |

### Consolidation note

This family matters because XR glasses utilities need clear separation between:

- device discovery and permission flow
- HID interface roles
- read-only parser/status diagnostics
- risky firmware/control commands
- calibration/drift correction
- display-surface or desktop viewport UX

It suggests a stronger branch inside `VR-apps-lab` around:

- safe XR glasses protocol readers
- head-tracked desktop viewport helpers
- drift-correction and layout persistence UX
- browser WebHID versus native HID comparison
- display-surface diagnostics for lightweight XR hardware

## Family 189: MediaPipe/avatar tracking sidecars, VRM diagnostics, named-pipe body bridges, and AI FBT pipelines

This family covers camera-inference projects that normalize face, hand, body,
or pose signals and bridge them into avatar systems, Unity, VRChat/VRCFT,
VRM previews, or virtual tracker outputs.

| Project | Status | Notes |
|---|---|---|
| `hotaru86/MediapipeFaceTracking_VRC` | Deepened in Wave 210 | MediaPipe Face Landmarker to VRCFT OSC sidecar with ARKit/VRCFT mapping, per-parameter tuning, JSON persistence, and boolean decomposition |
| `how-people-lived/mediapipe-vrm-tracking` | Deepened in Wave 210 | browser MediaPipe/VRM diagnostics workbench with VRM drag/drop, blendshape mapping UI, Face/Hand/Pose landmarkers, and JSON export |
| `Metastazius/VRBodyTrack` | Deepened in Wave 210 | Python MediaPipe to Unity named-pipe body bridge with length-prefixed landmarks, joint-angle calculation, and repo hygiene caveats |
| `MasonSakai/VR-AI-Full-Body-Tracking` | Deepened in Wave 210 | multi-camera AI FBT pipeline with MoveNet, keypoint confidence, triangulation, dampened virtual tracker output, and legacy InputEmulator caveats |

### Consolidation note

This family matters because camera tracking utilities should share a normalized
sidecar shape:

- capture/inference input
- source signal schema
- target avatar/tracker schema
- sensitivity, min/max, confidence, and calibration controls
- transport boundary such as OSC, named pipe, WebSocket, or runtime driver
- diagnostics and persistence

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable avatar/tracker signal schemas
- browser avatar diagnostics surfaces
- VRCFT/VRM/OSC mapping tools
- body landmark and joint-angle sidecars
- multi-camera tracker fusion references

## Family 190: VR teleoperation control frontends, robot bridges, safety gates, and feedback HUDs

This family covers VR and WebXR teleoperation projects whose reusable value is
the control loop: headset input, command sidecars, robot/runtime transports,
live feedback, explicit modes, safety gates, and operator HUDs.

| Project | Status | Notes |
|---|---|---|
| `h2r/GHOST` | Deepened in Wave 211 | Unity/Quest ROS teleop frontend with mode manager, controller commands, robot joint publisher, and point-cloud/depth visualization hooks |
| `nakama-lab/VR_Teleop_Interface` | Deepened in Wave 211 | branch-separated Unity/ROS2/ZED architecture with topic contracts and command/status/error sequence documentation |
| `kscalelabs/kbot_vr_teleop` | Deepened in Wave 211 | WebXR frontend plus Python IK/UDP sidecar with hand/controller tracking payloads, pause gates, throttling, feedback, and convergence checks |
| `open-thought/cambot` | Deepened in Wave 211 | WebXR stereo camera teleop stack with HUD telemetry, WebSocket/WebRTC transport, RTT/backpressure, calibration, smoothing, workspace bounds, watchdog, pause, and home |

### Consolidation note

This family matters because teleoperation projects force VR utilities to be
honest about command risk and feedback:

- visible operator modes
- bidirectional telemetry and status
- pause/home/calibrate flows
- stale-data and jump-prevention gates
- sidecar-level command validation
- transport health and media feedback
- safety envelopes before actuator/runtime output

It suggests a stronger branch inside `VR-apps-lab` around:

- VR/WebXR control surface patterns
- safety-gated command sidecars
- operator HUD templates
- command/status/error sequence documentation
- adapting teleop safety lessons to non-robot VR utilities

## Family 191: Shared-room WebXR/A-Frame presence, media, and peer adapters

This family covers small browser and A-Frame projects that prove shared-room
state, remote avatars, media streams, and transport adapters without becoming a
full social platform.

| Project | Status | Notes |
|---|---|---|
| `jure/wooglies` | Studied in Wave 212 | React/Three/WebXR room with Socket.IO snapshots, SnapshotInterpolation, simple-peer signaling, positional audio, and analyser-driven avatar behavior |
| `danbuckland/aframe-socket-io` | Studied in Wave 212 | A-Frame room prototype split into server signaling, game/pose system, WebRTC media system, and video-stream component |
| `Srushtika/realtime-multiplayer-webvr-aframe` | Studied in Wave 212 | minimal Deepstream presence-record avatar sync with 100ms camera pose updates and generated avatars |
| `RangerMauve/aframe-dat-peers-networking` | Studied in Wave 212 | Beaker/datPeers adapter that maps room/user messages into A-Frame events and remote template entities |

### Consolidation note

This family matters because browser XR utilities can reuse the same small
presence/media boundary across social rooms, remote assistance tools, shared
diagnostics, and multi-user creator surfaces:

- room identity and join/leave events
- explicit head/hand/controller pose schema
- interpolation or changed-state sends
- remote entity factories and cleanup
- WebRTC or media-stream attachment
- transport adapter APIs that survive platform changes

It suggests a stronger branch inside `VR-apps-lab` around:

- shared-room payload matrices
- WebXR remote-presence utility shells
- P2P audio/video plus pose prototypes
- transport-neutral peer adapter contracts

## Family 192: MRTK spatial UI, graphics, robotics, and gaze extension nodes

This family covers MRTK and adjacent extension projects whose reusable value is
the split between interaction state, data binding, visual feedback, placement,
accessibility, services, and alternate input.

| Project | Status | Notes |
|---|---|---|
| `MixedRealityToolkit/MixedRealityToolkit-Unity` | Deepened in Wave 213 | MRTK3 package/contract baseline with stateful interactables, pressable buttons, data binding, pooled lists, solvers, and accessibility subsystem |
| `microsoft/MixedReality-GraphicsTools-Unity` | Studied in Wave 213 | visual-feedback substrate with proximity lights, material animators, mesh instancing, text inversion, and magnifier utilities |
| `ms-iot/ros_msft_mrtk` | Studied in Wave 213 | archived ROS2/MRTK extension with node singleton, lidar provider/renderer split, QR spatial pinning, and hand-menu calibration |
| `The-COGAIN-Association/EyeMRTK` | Studied in Wave 213 | legacy gaze toolkit with normalized rays, smoothing/saccade detection, interaction events, dwell, and confirmation paths |

### Consolidation note

This family matters because spatial UI gets brittle when every panel owns every
concern. The reusable boundary is:

- input/interactable state machine
- visual shader/material feedback
- data source and list virtualization
- solver/placement tracking
- accessibility provider
- extension service and calibration action
- gaze or alternate-input normalization

It suggests a stronger branch inside `VR-apps-lab` around:

- engine-neutral spatial UI contracts
- accessible menu and panel patterns
- data-bound VR settings/list panels
- calibration hand-menu references
- gaze/dwell confirmation flows

## Family 193: VRChat/Udon menu package surfaces, world admin, and creator prefabs

This family covers VRChat/Udon projects that expose local menus, admin/GM
surfaces, runtime diagnostics, player utilities, permission gates, and modular
package ecosystems.

| Project | Status | Notes |
|---|---|---|
| `Varneon/UdonEssentials` | Deepened in Wave 214 | deprecated but source-rich prefab collection with event dispatcher, in-world console, playerlist, groups, music, and settings utilities |
| `Varneon/VUdon` | Deepened in Wave 214 | modular VPM ecosystem index for Quick Menu, Menus, Logger, Playerlist, Event Dispatcher, Common, Roles, and other utility packages |
| `SylanTroh/GMMenu` | Deepened in Wave 214 | role/admin menu with VR/desktop activation, permissions, synced pings, teleport/undo/summon, watch camera, HUD modules, and settings |
| `kurotori4423/KurotoriUdonMenu` | Studied in Wave 214 | local extensible tabbed menu with trigger/M-key activation, progress animation, player teleporter, and voice-range options |

### Consolidation note

This family matters because useful VR command menus need more than buttons:

- activation gesture and placement
- tabs/pages/options
- player target selection
- permission and role gates
- runtime diagnostics/logging
- action dispatch and reversible operations
- package/prefab install boundaries

It suggests a stronger branch inside `VR-apps-lab` around:

- generic VR command-menu checklists
- permissioned operator HUDs
- in-world diagnostics prefabs
- small package versus standalone-app decision rules

## Family 194: Immersive media/audio substrates, spatial renderers, and audio-reactive buses

This family covers lower-level media and audio projects that expose reusable
substrate boundaries for decode, texture output, audio callbacks, spatial
rendering, listener/source models, and shader-readable analysis buses.

| Project | Status | Notes |
|---|---|---|
| `videolan/vlc-unity` | Deepened in Wave 215 | LibVLC/LibVLCSharp Unity bridge with central player lifecycle, render texture updates, mesh/UGUI display helpers, and Unity audio callback routing |
| `videolan/libspatialaudio` | Deepened in Wave 215 | spatial renderer API for object, HOA, direct-speaker, binaural, HRTF, head orientation, and output layout flows |
| `VoidXH/Cavern` | Deepened in Wave 215 | C# immersive audio framework with Listener/Source model, Unity wrappers, filters, remapping, virtualization, and room-correction concepts |
| `llealloo/audiolink` | Deepened in Wave 215 | VRChat/Unity audio-reactive data bus with sampled audio chunks, CustomRenderTexture processing, global shader texture, and shader include API |

### Consolidation note

This family matters because media and audio tools should make substrate
ownership explicit:

- native decoder or renderer backend
- texture/render-surface output
- audio callback or engine-audio bridge
- object/HOA/binaural renderer configuration
- listener/source component wrappers
- shader-readable analysis bus
- platform, license, and performance caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- media/audio substrate comparison matrices
- Unity and browser media-surface boundaries
- spatial audio renderer API studies
- audio-reactive global data bus patterns
- license/platform risk notes for media tools

## Family 195: OpenXR conformance, specification, validation layers, and runner toolchain

This family covers OpenXR projects that help diagnose, validate, inventory, or
explain runtime behavior through CTS-style harnesses, specification/registry
tooling, API layers, loader tests, and thin runner UIs.

| Project | Status | Notes |
|---|---|---|
| `KhronosGroup/OpenXR-CTS` | Studied in Wave 216 | official conformance harness with CLI, Catch2 test library, graphics plugins, conformance API layer, generated dispatch, and report output |
| `rpavlik/openxr-cts-runner` | Studied in Wave 216 | Rust/egui GUI wrapper around `conformance_cli` with graphics API options, noninteractive filtering, process output capture, and cancellation |
| `KhronosGroup/OpenXR-Docs` | Studied in Wave 216 | specification/registry source with generated headers, extension inclusion helpers, validation checks, and extension-process governance |
| `KhronosGroup/OpenXR-SDK-Source` | Deepened in Wave 216 | API dump, core validation, loader tests, list-json runtime inventory, debug-utils output, and generated dispatch boundaries |

### Consolidation note

This family matters because an OpenXR doctor should be assembled from separate
parts rather than one opaque test button:

- runtime and loader inventory
- API layer and extension discovery
- registry/spec-backed explanation
- validation and API-dump output
- CTS-style test invocation and filtering
- graphics binding selection
- report and runner UI

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR doctor/report schemas
- validation-layer output viewers
- conformance-runner UX without conformance claims
- registry-backed extension matrices
- runtime inventory and graphics-binding diagnostics

## Family 196: StardustXR client infrastructure, panel protocols, and spatial desktop microclients

This family covers StardustXR client-side projects that model XR desktop work
as protocol, scenegraph, spatial interaction, declarative UI, panel surface,
Wayland ingestion, and placement-launcher layers.

| Project | Status | Notes |
|---|---|---|
| `StardustXR/core` | Studied in Wave 217 | wire/protocol/fusion/gluon workspace with FlatBuffer messaging, KDL protocol parsing, typed client wrappers, scenegraph nodes, and spatial resources |
| `StardustXR/molecules` | Studied in Wave 217 | high-level interaction library with grabbables, buttons, hover/touch planes, zones, input queues, reparenting, and visual debug |
| `StardustXR/asteroids` | Studied in Wave 217 | declarative UI layer with state reification, element diffing, resource registry, task callbacks, and spatial element wrappers |
| `StardustXR/panel-item` | Studied in Wave 217 | panel protocol and Asteroids shell with toplevel/child/cursor state, surface update channels, and acceptor events |
| `StardustXR/wayland-service` | Studied in Wave 217 | Wayland socket/service bridge with Vulkan context, binder device, xdg/core/dmabuf protocols, and panel item provider |
| `StardustXR/gravity` | Studied in Wave 217 | placement-aware launcher that creates a spatial transform, exports connection environment, emits startup token, and execs a command |

### Consolidation note

This family matters because spatial desktop systems can be decomposed into:

- wire protocol and schema
- scenegraph/spatial object model
- input fields and interaction primitives
- declarative UI/diff layer
- panel/window protocol
- desktop surface ingestion service
- spatial launch and placement contract

It suggests a stronger branch inside `VR-apps-lab` around:

- protocol-backed overlay/window concepts
- placement-aware launcher UX
- scenegraph-first utility architecture
- StardustXR versus SteamVR overlay comparison
- spatial interaction primitive reuse

## Family 197: VRChat/Udon runtime diagnostics, data structures, and predictive sync utilities

This family covers Udon packages whose reusable value is runtime substrate:
base lifecycle, logging, serialization, network time, profiling, encoded data
structures, predictive sync, and in-world tuning.

| Project | Status | Notes |
|---|---|---|
| `Guribo/UdonUtils` | Deepened in Wave 218 | TLP base substrate with lifecycle validation, logging, dirty serialization/retry, sync pause, network time, accurate sync hooks, events, physics helpers, and tests |
| `Guribo/UdonProfiling` | Studied in Wave 218 | ScreenSpace performance overlay with MVC stat controller, global profiler handler, frame-time accumulation, threshold warnings, and debug-frame log hooks |
| `Guribo/UdonLeaderBoard` | Product reference only in Wave 218 | current checkout has package placeholder only; useful as leaderboard lineage/follow-up but not a code donor yet |
| `Guribo/UdonAVLTree` | Studied in Wave 218 | DataList-backed U# AVL tree with node pool, parent/payload/child/wire layout, comparer boundary, balance and rotation helpers |
| `Guribo/UdonVehicleSync` | Studied in Wave 218 | predictive rigidbody sync with network-time send stamps, dynamic send-rate thresholds, teleport/respawn, debug trails, and sync-tweaker UI |

### Consolidation note

This family matters because VRChat world utilities need shared foundations:

- setup and dependency validation
- bounded logging and debug compile symbols
- dirty serialization and retry behavior
- network/game time sources
- snapshot and prediction hooks
- data-structure workarounds
- profiling and in-world diagnostics
- tuning UI for live parameters

It suggests a stronger branch inside `VR-apps-lab` around:

- Udon runtime substrate matrices
- diagnostic HUD/panel patterns
- constrained-runtime data structures
- prediction-aware sync and dynamic send cadence
- package-source triage rules

## Family 198: VRChat external content ingress, image/model/texture/avatar-data surfaces

This family covers VRChat projects that route external or late-bound content
into worlds through URL image downloads, strings, runtime model parsers,
synced textures, persisted URL inputs, and avatar-thumbnail data carriers.

| Project | Status | Notes |
|---|---|---|
| `vrchat-community/examples-image-loading` | Studied in Wave 219 | official image/caption slideshow sample with persistent downloader, cached textures, caption string loading, server-time slide selection, and GitHub Pages hosting |
| `vr-voyage/vrchat-glb-loader` | Studied in Wave 219 | runtime GLB/VRM loader with staged parser, meshes/materials/textures/scenes, DDS/preconverted textures, extension handlers, and unsupported-feature caveats |
| `DrBlackRat/VRC-Picture-Loader` | Studied in Wave 219 | productized image loader with manager/lite/url-input/persistence/tablet modes, texture settings, loading/error textures, and UI progress |
| `Narazaka/SyncTexture` | Studied in Wave 219 | chunked Texture2D sync with color encoders, GPU readback/GetPixels, progress, callbacks, manager sequencing, resend, and late-join support |
| `Miner28/AvatarImageReader` | Deepened in Wave 219 | deprecated avatar-thumbnail text/data carrier with editor encoder, runtime pedestal readback, UTF-8/UTF-16 decode, avatar chaining, and platform capacity limits |

### Consolidation note

This family matters because external content ingress should name:

- content source and authority
- downloader, parser, sync, or carrier mechanism
- cached runtime data shape
- output surface or model hierarchy
- loading/error/progress UI
- persistence and ownership policy
- platform/runtime limitations

It suggests a stronger branch inside `VR-apps-lab` around:

- VRChat content-ingress matrices
- image gallery and tablet-display UX
- runtime asset parser caveat tracking
- texture-as-data and shader-bus comparisons
- deprecated workaround documentation

## Family 199: World-locking, spatial coordinate stabilization, and anchor sharing

This family covers projects that make spatial stability explicit through raw
tracking space, stabilized world space, anchor graphs, marker bindings, cloud
anchor persistence, and user-facing reset/search/publish controls.

| Project | Status | Notes |
|---|---|---|
| `microsoft/MixedReality-WorldLockingTools-Unity` | Studied in Wave 220 | canonical Unity world-locking stack with spongy/locked/frozen frames, anchor graph, alignment manager, SpacePins, diagnostics, and persistence |
| `microsoft/MixedReality-WorldLockingTools-Samples` | Studied in Wave 220 | QR SpacePins and Azure Spatial Anchors samples with binding oracle, publish/load/search/purge/reset controls, and physical marker matching |
| `microsoft/WorldLockingTools-Unreal` | Studied in Wave 220 | Unreal translation using ARPins, tracking-to-world transforms, pawn hierarchy adjustment, and FrozenWorld plugin calls |
| `brunoshine/StereoKit.Samples.AzureSpatialAnchors` | Studied in Wave 220 | minimal StereoKit ASA demo with cloud session state, nearby anchor search, save/delete controls, and feedback UI |

### Consolidation note

This family matters because stable spatial tools should name:

- raw tracking frame
- stabilized world frame
- anchor graph or anchor set
- alignment pins or marker bindings
- persistence and cloud binding
- reset/refreeze/search/delete UI
- diagnostics and failure feedback

It suggests a stronger branch inside `VR-apps-lab` around:

- spatial-stability matrices
- anchor UX checklists
- calibration helpers that separate tracking and world frames
- shared-room alignment references
- CAD/workspace tools with stable physical references

## Family 200: Vendor OpenXR extension stacks, feature wrappers, and sample matrices

This family covers projects that wrap optional OpenXR features behind explicit
extension strings, support checks, lifecycle hooks, function loading, build
metadata, and engine-facing APIs.

| Project | Status | Notes |
|---|---|---|
| `microsoft/OpenXR-MixedReality` | Studied in Wave 221 | Microsoft C++ OpenXR samples with feature-to-extension mapping, instance context, QR scene-marker filtering, and MR sample coverage |
| `microsoft/Microsoft-OpenXR-Unreal` | Studied in Wave 221 | Unreal plugin with modular Microsoft feature registration, Blueprint wrappers, QR tracking, PV camera, speech, remoting, and spatial mapping |
| `meta-quest/Meta-OpenXR-SDK` | Studied in Wave 221 | Quest native OpenXR SDK with shared app lifecycle, broad sample matrix, extension helper classes, and preview/license caveats |
| `mikeskydev/unity-openxr-extensions` | Studied in Wave 221 | small Unity OpenXRFeature wrapper set with required extension checks, function pointer hooks, passthrough/body/boundary wrappers, and Android build hooks |

### Consolidation note

This family matters because optional OpenXR features need:

- required extension declarations
- runtime support queries
- function pointer loading
- instance/session/frame lifecycle ownership
- handle create/destroy boundaries
- engine/plugin wrapper surfaces
- build/package manifest gates
- preview/license/platform caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR feature wrapper skeletons
- extension availability matrices
- vendor feature comparison docs
- OpenXR doctor feature explanations
- build-gate and manifest-check utilities

## Family 201: Cockpit hand-clicking, calibration, observer, and passthrough microhelpers

This family covers narrow VR helper tools that translate one source signal into
one useful target: hand tracking to simulator actions, tracking origins to a
calibrated frame, mixed-device poses to a shared observer space, or camera
frames to a VR overlay.

| Project | Status | Notes |
|---|---|---|
| `fredemmott/HTCC` | Studied in Wave 222 | OpenXR API-layer cockpit helper with private hand tracking, PointCTRL source, virtual controller action sink, pinch/scroll/aim states, and per-exe config |
| `galister/motoc` | Studied in Wave 222 | Monado/WiVRn calibration CLI with sampled SVD calibration, continuous offset smoothing, monitor/recenter modes, saved JSON profiles, and anomaly handling |
| `dag10/HoloViveObserver` | Studied in Wave 222 | historical Unity HoloLens/Vive observer alignment prototype with networked alignment manager, controller target/click ritual, and legacy caveats |
| `yshui/index_camera_passthrough` | Studied in Wave 222 | Linux Index camera passthrough overlay with V4L capture, Vulkan YUYV/correction/projection, OpenVR/OpenXR backend trait, and overlay placement modes |

### Consolidation note

This family matters because useful microhelpers should expose:

- source adapter
- target action/display/calibration sink
- compact state machine
- safety or validity gates
- profile/config persistence
- monitor or feedback mode
- platform and target-app caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- microhelper safety matrices
- input translation design
- tracking-origin operator tools
- camera-to-overlay display surfaces
- mixed-device observer calibration rituals

## Family 202: XR creator/CAD/UI workbenches and legacy Unity interaction donors

This family covers projects that support real work inside XR: CAD viewing and
editing, controller menus, panels, file dialogs, keyboards, snapping, mesh
selection, mirrors, and embodied feedback.

| Project | Status | Notes |
|---|---|---|
| `kwahoo2/freecad-xr-workbench` | Studied in Wave 223 | Python OpenXR FreeCAD addon with pyopenxr/OpenGL render loop, controller rays, Coin3D menus, movement modes, CAD selection/editing, Qt widget projection, and tracked camera |
| `createthis/createthis_vr_ui` | Studied in Wave 223 | legacy Unity VR UI toolkit with grabbable panels, panel manager, keyboard, file dialogs, kinetic scroller, touchpad radial menu, selection materials, and factories |
| `createthis/mesh_maker_vr` | Studied in Wave 223 | VR mesh authoring tool with explicit edit modes, vertex/triangle controllers, sticky selection, snapping, fill/normal/delete operations, settings, and HUD feedback |
| `createthis/unity_vr_ik_mecanim` | Studied in Wave 223 | small embodied feedback demo with controller hand IK, hip-tracker body placement, mirror render texture, translucent controllers, and Mecanim limitations |

### Consolidation note

This family matters because creator workbenches need:

- runtime/session integration
- controller ray and picking layer
- menu and panel system
- command-mode state
- document or model adapter
- selection and snapping
- file/text/color input
- visual and embodied feedback
- persistence, undo, and export boundaries

It suggests a stronger branch inside `VR-apps-lab` around:

- VR menu and panel matrices
- CAD helper patterns
- in-headset file/keyboard/color input
- creative authoring interaction primitives
- legacy-to-modern Unity XRI comparison

## Family 203: XR research data lifecycle templates, validation, and analysis pipelines

This family covers projects that make XR session data explicit through capture
templates, event tables, continuous streams, metadata, validation, replay,
quality flags, and downstream analysis or reporting.

| Project | Status | Notes |
|---|---|---|
| `ResXR/resxr-unity-research-template` | Studied in Wave 224 | Quest/Unity clear-box research template with base scene, session/task/trial flow, event/custom CSV tables, continuous tracking, face streams, live callbacks, room calibration, and metadata |
| `ResXR/resxr-python-pipeline` | Studied in Wave 224 | downstream pipeline with YAML config, session discovery, continuous-data splitting, BIDS output, validation registry, quality masking, derivatives, and reports |
| `ixperience-lab/VRSTK` | Studied in Wave 224 | legacy scientific VR toolkit with phase control, tracking, biosignals, questionnaires, replay, JSON/CSV export, and analysis scripts |
| `eisclimber/ExPresS-XR` | Deepened in Wave 224 | editor-guided experiment setup and data-gathering bindings with local/HTTP CSV export, component-member binding, and periodic/input-triggered collection |

### Consolidation note

This family matters because research-grade and diagnostics-grade XR tools need:

- session, task, trial, and event models
- continuous tracking streams
- custom data table schema
- metadata and clock policy
- validation and quality flags
- raw versus derivative output
- replay or report surfaces
- authoring/setup helpers

It suggests a stronger branch inside `VR-apps-lab` around:

- XR research data lifecycle matrices
- session/event/log schema design
- tracker-quality and calibration reports
- privacy-aware data capture notes
- downstream validation and export helpers

## Family 204: WebRTC/WebXR remote surfaces, camera streams, and spatial panels

This family covers browser and WebRTC projects that bring external screens,
cameras, stereo feeds, or local monitor streams into XR as controllable spatial
panels.

| Project | Status | Notes |
|---|---|---|
| `binzume/webrtc-rdp` | Studied in Wave 225 | WebRTC remote desktop with Ayame signaling, PIN pairing, persisted devices, media tracks, service requests, control/data channels, and A-Frame WebXR input |
| `DiscreteTom/WebCaster` | Studied in Wave 225 | minimal peerjs/Three screen caster with WebXR video-texture panels, controller ray selection, grab/drop, push/pull, and scale interactions |
| `hideki5123/stereo-webrtc-viewer` | Studied in Wave 225 | dual-stream Sora WebRTC stereo camera viewer with WebGL2 WebXR session setup and per-eye texture routing |
| `rclarke87/WebXR-IPCam` | Studied in Wave 225 | WHEP/IP camera microtool with A-Frame video panels, receive-only PeerConnections, labels, and mute controls |
| `JYJang476/VRMonitor` | Studied in Wave 225 | local QR/WebSocket/WebRTC monitor prototype with browser screen capture, role relay, and Babylon video texture output |

### Consolidation note

This family matters because remote surface tools should separate:

- source capture or endpoint
- signaling and pairing
- media transport
- data/control transport
- auth and trust policy
- spatial panel renderer
- controller or gaze interaction
- reconnect and status feedback

It suggests a stronger branch inside `VR-apps-lab` around:

- WebRTC surface-ingress matrices
- desktop and camera panel shells
- QR/PIN/local pairing UX
- media versus control channel boundaries
- security review for demo transport flows

## Family 205: Browser media, depth-video projection, and gaze-viewer surfaces

This family covers browser media viewers that make projection, stereo/depth,
player controls, accessibility input, and spatial placement explicit.

| Project | Status | Notes |
|---|---|---|
| `amariichi/VideoDepthViewer3D` | Studied in Wave 226 | FastAPI/PyAV/PyTorch plus Three/WebXR depth-video viewer with inference workers, binary depth streams, buffer tuning, relief/pinhole projection, and RawXR rendering |
| `mysterion/aframe-vr-player` | Studied in Wave 226 | A-Frame/WebXR video player with local files, projection presets, stereo layers, persistent settings, subtitles, timeline, and recenter controls |
| `mrgeralds/WebXR-TV-Demo` | Studied in Wave 226 | WebXR TV shell with dash.js playback, channel metadata, info bar, paged channel menu, secondary screen, and VR reposition plane |
| `orgixmh/GazeDesk` | Product reference in Wave 226 | README-level Cardboard/MJPEG desktop viewer with head cursor, gaze dwell, SBS tuning, pan/zoom/IPD, wake lock, and local persistence |
| `ZhiqiaoGong/3D-Streaming-Demo` | Studied in Wave 226 | WebRTC SBS streaming demo with local publisher capture, receiver texture split, left/right layers, debug/XR layouts, and reconnect behavior |

### Consolidation note

This family matters because projection-aware media surfaces need:

- source and transport boundary
- flat, 180, 360, SBS, per-eye, or depth projection
- player controls and metadata
- debug and immersive layouts
- spatial placement behavior
- persistence and preset storage
- latency, buffering, and recovery policy
- controller-free or accessibility controls

It suggests a stronger branch inside `VR-apps-lab` around:

- browser media projection matrices
- depth-video and SBS viewer patterns
- gaze/dwell accessibility media controls
- spatial TV/player shells
- debug layouts for stereo and projection issues

## Family 206: OpenGloves DIY haptics adapters, named pipes, and firmware variants

This family covers OpenGloves-compatible projects that expose the boundary
between DIY hardware, firmware packets, transports, converter sidecars, driver
input, and force-feedback or haptic output.

| Project | Status | Notes |
|---|---|---|
| `SparkleTech-VR/OpenPulseConverter` | Studied in Wave 227 | WIP BiFrost Pulse HID to OpenGloves converter with bit extraction, calibration, normalized flexion/splay, v2 named-pipe writes, force-feedback reads, and haptic conversion |
| `danwillm/opengloves-named-pipe-example` | Studied in Wave 227 | minimal Windows named-pipe writer for OpenGloves v2 input fields, useful as contract/test-fixture reference |
| `DasKatzchen/GloveBridge` | Studied in Wave 227 | Python BLE bridge concept with left/right device discovery, GATT read/write tasks, OpenGloves v1 input/force-feedback pipe paths, and unfinished format caveats |
| `Stargazer6481/Compact-Gloves` | Studied in Wave 227 | compact DIY glove product/reference with BOM, hardware docs, ESP32 Bluetooth Serial firmware, OpenGloves setup, and calibration guide |
| `xRayz3n/ExoTouch-2.0` | Studied in Wave 227 | LucidGloves-derived exoskeleton variant with AS5600 encoder input, I2C multiplexer, calibration loops, serial/Bluetooth abstraction, alphabetic encoding, and servo haptics |

### Consolidation note

This family matters because DIY haptic glove integrations should name:

- sensor and actuator hardware
- firmware encoding and calibration
- USB Serial, Bluetooth Serial, BLE, HID, or pipe transport
- converter sidecar boundary
- normalized hand input schema
- driver input contract
- force-feedback output contract
- safety, scaling, and variant caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenGloves adapter matrices
- DIY haptics safety notes
- named-pipe protocol examples
- firmware-variant comparison
- hardware documentation/onboarding patterns

## Family 207: WebXR hand input, gesture templates, and fallback hand-tracking primitives

This family covers small WebXR hand-input projects that make pose templates,
pinch/palm gates, hand/controller fallback, and hand-source caveats explicit.

| Project | Status | Notes |
|---|---|---|
| `stewdio/handy.js` | Studied in Wave 228 | compact pose-template matcher with wrist/head-relative snapshots, sorted search, small per-hand recognition budget, and pose began/ended events |
| `stewdio/vr-hands` | Studied in Wave 228 | deprecated gesture lineage with direct fist/horns/finger-gun bindings into scene behavior |
| `physicslibrary/Threejs-VR-Hand-Input` | Studied in Wave 228 | Quest/Three micro-recipes for joint reads, pinch distance, palm-up toggles, and old Oculus hand model caveats |
| `vrmeup/threejs-webxr-hands-example` | Studied in Wave 228 | unified hand/controller pointer abstraction with wrist/palm/finger tracking, damped rays, and pinch-plus-palm gates |
| `martatesar/webxr-hands-gestures-recognition` | Studied in Wave 228 | wrist-local JSON gesture recognizer/learner with opposite-hand pinch confirmation and gesture_changed events |
| `beemsoft/webxr-handtracking-playground` | Studied in Wave 228 | native WebXR plus MediaPipe fallback with landmark meshes, open/stop heuristics, and physics proxy joints |
| `immersive-web/webxr-hand-input` | Studied in Wave 228 | API/spec reference for joint spaces, batch pose reads, performance, and privacy/security caveats |

### Consolidation note

This family matters because hand input for utility apps should name:

- hand source and fallback path
- joint feature extraction
- wrist/palm-relative coordinate space
- template or threshold recognizer
- gesture state and confidence
- action sink separation
- frame budget and privacy policy

It suggests a stronger branch inside `VR-apps-lab` around:

- hand-command event schemas
- hand menu and overlay triggers
- accessibility gesture configuration
- MediaPipe versus native WebXR fallback matrices
- hand-data privacy and sampling guidance

## Family 208: Immersive data, robotics, and scientific visualization workbenches

This family covers data-first XR tools that transform Python sessions, plots,
robot files, scientific state, or collaboration annotations into spatial
workbenches.

| Project | Status | Notes |
|---|---|---|
| `vuer-ai/vuer` | Studied in Wave 229 | Python async WebSocket scene bridge with msgpack events, scene operations, workspace assets, robotics schemas, and teleoperation examples |
| `thomann/plotAR` | Studied in Wave 229 | generated immersive plot workflow with QR pairing, VR/keyboard pages, glTF/USDZ export, WebSocket commands, and WebVR/security caveats |
| `TsatsuAmable/nemosyne` | Studied in Wave 229 | data-native WebXR visualization engine with semantic mapping, VR-aware layouts, transform DSL, and stream extensions |
| `smrghsh/brahma` | Studied in Wave 229 | collaborative scientific room shell with selectable/grasp/controller modules, remote embodiment, callouts, and hardcoded endpoint caveats |
| `jurmy24/mechaverse` | Studied in Wave 229 | adjacent robotics viewer dispatch shell for URDF, MJCF, and USD file groups; not yet an XR viewer |

### Consolidation note

This family matters because immersive data tools should separate:

- data or file source
- schema and semantic fields
- transform/mapping layer
- layout and spatial encoding
- scene artifact or scene operation transport
- interaction, annotation, and collaboration
- export and local/remote trust policy

It suggests a stronger branch inside `VR-apps-lab` around:

- data-to-spatial-encoding matrices
- Python/WebSocket to WebXR bridges
- robot model viewer dispatch shells
- scientific callout and annotation rooms
- local data server safety guidance

## Family 209: Scriptable WebXR modeling, viewer, editor, and creative display surfaces

This family covers XR work surfaces where a user edits, exports, reloads,
inspects, configures, or visualizes content rather than only consuming a scene.

| Project | Status | Notes |
|---|---|---|
| `vipenzo/ridley` | Studied in Wave 230 | CAD-as-code workbench with SCI runtime evaluation, turtle geometry, editor/REPL, pilot-mode generated code, WebXR hooks, PeerJS sync, voice input, and Windows checkout caveat |
| `id3vi5er/fusion360_webxr_viewer` | Studied in Wave 230 | Fusion 360 OBJ/MTL export plus threaded local HTTPS WebXR viewer with LAN URLs, reload, centering, scaling, and controller manipulation |
| `felipereigosa/kairon` | Studied in Wave 230 | VR code editor with desktop keyboard/input companion, tab/terminal model, code execution, controller polling, haptics, locomotion, and visibility toggles |
| `phobi82/webxr_butterchurn` | Studied in Wave 230 | modular WebXR audio visualizer shell with app config, audio, menu, depth, passthrough, lighting, runtime, movement, TestLab, and desktop menu preview |

### Consolidation note

This family matters because productive XR work surfaces should name:

- source/editor/host-app boundary
- live evaluation or export/reload path
- asset and model import pipeline
- desktop companion input strategy
- in-headset menu state
- runtime display and effect modules
- desktop mirror/debug surface
- comfort, permission, and local-network caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- in-headset editor and keyboard strategy matrices
- CAD and host-app export bridges
- menu texture and desktop mirror playbooks
- depth/passthrough creative display shells
- audio-reactive XR utility surfaces

## Family 210: WebXR prototyping runtime micro-frameworks and experimental interaction primitives

This family covers SDKs, wrappers, starters, and demo sets that package common
WebXR boilerplate: scene setup, session lifecycle, input, hand gestures, depth,
simulator, UI, model loading, and cleanup.

| Project | Status | Notes |
|---|---|---|
| `google/xrblocks` | Studied in Wave 231 | broad AI plus WebXR SDK with script/core/options boundaries, gestures, hand estimators, depth, simulator, spatial UI, sound/video/world modules, and agents |
| `w3reality/threelet` | Studied in Wave 231 | compact Three/WebXR wrapper with auto defaults, optional VR/AR/XR buttons, loop switching, event abstraction, controller rays, and disposal |
| `simonedevit/reactylon` | Studied in Wave 231 | declarative React/Babylon XR framework with reconciler, scene injection, generated components, default XR experience hook, and disposal policy |
| `vishnu7560834213/threexr` | Studied in Wave 231 | rough Three/Vite starter with VRButton, controller grips, joystick extraction, player capsule, BVH collision, and immature packaging |
| `ARDings/EverythingController` | Studied in Wave 231 | single-file XR Blocks depth-body controller demo with point-cloud collision, debug/occlusion mesh, and spatial settings panel |
| `dmvrg/webxr-ar-demos` | Studied in Wave 231 | product-style WebXR AR demos with hand pinch, UI planes, product controls, exploded views, and direct manipulation |

### Consolidation note

This family matters because WebXR prototypes should declare:

- runtime tier and maturity
- session and renderer ownership
- script/component lifecycle
- options and feature gates
- input, gestures, depth, UI, sound, and model modules
- simulator or desktop fallback
- disposal and cleanup policy
- device, permission, and demo-specific caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- WebXR SDK/runtime comparison matrices
- interaction primitive catalogs
- simulator-backed prototyping guidance
- framework maturity labels
- depth/gesture/UI reusable module boundaries

## Family 211: WebXR robot teleoperation frontends, safety gates, and data collection

This family covers WebXR/Quest headset frontends that transform controller,
hand, body, or headset state into bounded robot/device command streams with
operator feedback, recording, and validation.

| Project | Status | Notes |
|---|---|---|
| `SpesRobotics/teleop` | Studied in Wave 232 | compact WebXR pose-to-callback bridge with hold-to-move, scale presets, transform conversion, relative pose reset, and jump limiting |
| `ajhai/teleop-xr` | Studied in Wave 232 | protobuf robot adapter with binary WebSocket, heartbeat, robot manager, status/joint/camera payloads, and camera planes |
| `fracapuano/maniskill-quest-teleop` | Studied in Wave 232 | Quest WebRTC telemetry/control bridge with rate partitioning, stale-hand policy, backpressure, and debug capture |
| `almond-bot/axol-vr` | Studied in Wave 232 | R3F operator HUD and data collection surface with teleop/recording state, body-tracked elbows, lock flags, and countdown UX |
| `vivek-kanjarla/Quest3-Fairino` | Studied in Wave 232 | safety-first physical robot pipeline with stale gates, deadman switch, delta mapping, sim/validate/live modes, diagnostics, and episode recording |

### Consolidation note

This family matters because risky external-control surfaces should name:

- XR input source and payload schema
- transport and backpressure model
- safety gate and stale-data policy
- transform/IK/adapter boundary
- operator HUD state
- validation or simulation stage
- recording/debug capture
- hardware and network caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- teleoperation safety matrices
- headset operator HUD patterns
- external-device command schemas
- WebXR-to-device adapter boundaries
- recording and debug-capture checklists

## Family 212: VR terminal, shell, and operational dashboard surfaces

This family covers XR surfaces that render command, text-grid, data, network,
or local dashboard state as spatial panels rather than arbitrary desktop
pixels.

| Project | Status | Notes |
|---|---|---|
| `max-gaspers-scott/VR-Terminal` | Studied in Wave 233 | Rust PTY/VTE terminal with Socket.IO snapshots, cell attributes, row revisions, command overlay, canvas texture, and A-Frame plane |
| `coderofsalvation/xrsh` | Studied in Wave 233 | shell-as-XR-world concept with A-Frame terminal, self-container, hand/ray/gaze controls, and windowing substrate |
| `soren42/visual-traceroute` | Studied in Wave 233 | CLI network scan to WebXR graph artifact with progress server, status polling, MST/BFS/force layout, and self-contained output |
| `CanaanMuayad/earthshift-vr` | Studied in Wave 233 | modular cockpit with draggable glass panels, border-drag versus center-click separation, locomotion store, and persisted widget state |
| `MKTHINGS/webxr-dashboard-meta-quest` | Studied in Wave 233 | Quest/A-Frame local-first notes/bookmarks/photos dashboard with haptics, autosave, JSON import/export, and unsupported-device overlay |

### Consolidation note

This family matters because operational XR tools should name:

- state source and privilege boundary
- low-bandwidth state model
- panel rendering strategy
- input/keymap/focus model
- progress and diagnostics reporting
- local persistence/export
- auth, TLS, scan scope, and command-exposure caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- terminal/log panel patterns
- diagnostic report surfaces
- local-first utility dashboards
- VR cockpit widget placement
- secure command surface guidance

## Family 213: XR/smart glasses SDK, virtual display, protocol, and constrained HUD stacks

This family covers optical XR/smart glasses implementation patterns across
IMU/head-mouse helpers, vendor SDK wrappers, spatial desktops, BLE transports,
and constrained HUD templates.

| Project | Status | Notes |
|---|---|---|
| `boomskats/woahland` | Studied in Wave 234 | Linux Viture head-mouse with uinput output, IMU mapping, smoothing/deadzone, roll-scroll, config reload, Unix socket control, and recenter |
| `Wojtekb30/EasyVXR` | Studied in Wave 234 | thread-safe minimal C Viture SDK facade for IMU data, quaternion/euler decoding, 3D mode, frequency, and safe disconnect |
| `darkclad/uxspace` | Studied in Wave 234 | Android/Windows XR glasses spatial desktop with VirtualDisplay/SurfaceTexture, Shizuku app screens, IddCx virtual monitors, DDA capture, and vendor-neutral tracker boundary |
| `emingenc/even_glasses` | Studied in Wave 234 | Python BLE G1 command library with scanning, write lock, heartbeat, reconnect, text pages, RSVP, dashboard, brightness, notes, and notifications |
| `fabioglimb/even-toolkit` | Studied in Wave 234 | G2 app framework/design system with per-screen router, layout constants, split/column pages, gesture debounce, keep-alive, STT, and web components |
| `even-realities/evenhub-templates` | Studied in Wave 234 | official G2 templates for minimal text, ASR, image, long-text pagination, event routing, render debounce, and double-tap shutdown |
| `Commute773/g2-kit-unofficial` | Studied in Wave 234 | reverse-engineered G2 BLE/protocol stack with L/R session, aa21 framing, CRC, magic acks, pipelined writes, events, audio, images, coalescer, pager, and gotcha docs |

### Consolidation note

This family matters because smart-glasses utilities should name:

- device/vendor adapter
- IMU/head-pose or BLE transport layer
- session/prelude/ack/backpressure behavior
- display and layout constraints
- render cadence and coalescing
- paging versus scrolling choice
- keep-alive and shutdown/exit path
- proprietary/reverse-engineered protocol caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- XR glasses protocol matrices
- constrained HUD design rules
- virtual display and spatial desktop comparisons
- BLE render backpressure guidance
- optical-display comfort caveats

## Family 214: Browser-native WebXR drawing, whiteboard, and creative workbench surfaces

This family covers WebXR/A-Frame/Three/Babylon creative surfaces whose reusable
value sits in controller input, tool menus, stroke geometry, palettes,
measurement, persistence, and collaboration.

| Project | Status | Notes |
|---|---|---|
| `localtoast42/webxr-whiteboard` | Studied in Wave 235 | thin controller/entity hit-test probe with grip/ray spaces, gamepad wrapper, squeeze checks, and bounding-box feedback |
| `felixtrz/canvrs` | Studied in Wave 235 | controller-attached AR paint multitool with pressure strokes, line buffer ranges, min-distance sampling, colors, eraser, and bounding boxes |
| `n1ckfg/LightningLoops` | Studied in Wave 235 | networked/generative LATK stroke surface with socket.io frame server, local/remote layers, turtle stroke morphs, Magenta input, and JSON save |
| `nuonical/webxr-babylon` | Studied in Wave 235 | Babylon creative workbench with XR lifecycle, trigger drawing, palette pointer blocking, tube/ribbon/metaball modes, chunking, limits, haptics, and tests |
| `sierrajanson/Harold-in-VR` | Studied in Wave 235 | A-Frame drawing/prototyping tool with shared tool state, menu/submenu isolation, raycast color picker, ruler, shapes, grid, and clear/erase surfaces |
| `cpufreestyle/vr-paint` | Studied in Wave 235 | A-Painter fork with brush registration, pressure-aware points, shared buffer geometry, undo/clear, apa/json persistence, URL load, upload/share, and controller mappings |

### Consolidation note

This family matters because browser-native creative utilities should name:

- controller pressure and trigger mapping
- tool and mode state
- palette/menu blocking
- stroke sampling and smoothing
- geometry builder and point limits
- eraser/selection/ruler/shape tools
- persistence, import/export, and sharing
- collaboration or remote stroke transport

It suggests a stronger branch inside `VR-apps-lab` around:

- VR annotation and whiteboard patterns
- browser-native brush engine comparisons
- in-headset tool menu state machines
- stroke persistence formats
- creative-surface performance limits

## Family 215: VR locomotion, embodiment, and comfort microcontrols

This family covers small movement and embodiment systems whose reusable value
sits in input mapping, comfort response, teleport state, collider/body
adaptation, and head/hand-only avatar estimation.

| Project | Status | Notes |
|---|---|---|
| `RoWoCha/LocomotionVR` | Studied in Wave 236 | SteamVR locomotion with HMD-relative direction, dynamic speed, CharacterController sizing, snap-turn around head, speed-linked blinders, and intensity gates |
| `pascalmariany/Unity-WebXR-Teleportation-and-SmoothLocomotion` | Studied in Wave 236 | WebXR smooth movement plus delayed teleport preview, release commit, ballistic arc linecasts, and head/body offset compensation |
| `dabeschte/VRArmIK` | Studied in Wave 236 | head/hand-only arm IK with persisted calibration, shoulder estimation, behind-head handling, arm-length clamp, and XR node input |
| `ralph-immrsv/UnityVR-ArmSwingMovement` | Source-light in Wave 236 | checkout had only git/ignore metadata; retained as exclusion note |

### Consolidation note

This family matters because small VR utilities should name:

- input source and movement mode
- comfort vignette or fade policy
- teleport preview and commit state
- dynamic HMD/collider handling
- calibration and body-dimension persistence
- avatar/arm solver assumptions
- source-light or demo-maturity caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- comfort locomotion comparison matrices
- teleport UX micro-patterns
- head/hand embodiment constraints
- utility-safe movement wrappers
- wrist/tool offset calibration notes

## Family 216: WebXR depth, point-cloud, room-scan, and spatial dataset viewers

This family covers spatial sensing and viewer flows across browser depth
capture, AR measurement, simulated lidar, splat assets, and large scientific
dataset viewers.

| Project | Status | Notes |
|---|---|---|
| `Ramith-D-Rodrigo/webxr-point-cloud` | Studied in Wave 237 | WebXR camera/depth capture with feature gates, framebuffer readback, randomized sampling, worker reconstruction, Three point meshes, and GLTF export |
| `Dhruvi509/Webxr-room-scanner` | Studied in Wave 237 | Babylon AR measurement micro-tool with hit-test, anchor fallback, live line preview, and distance label |
| `BSoDium/Lidar` | Studied in Wave 237 | React/Three XR lidar ray-grid with Raycaster/ArrowHelper arrays, visible hit feedback, BVH intent, terrain shader, and point-budget caveats |
| `sterngefeuert/webxr-gaussian-splat` | Studied in Wave 237 | Three/WebXR splat viewer with progressive loading, AR/VR entry, drag/drop, query-param loading, and desktop fallback controls |
| `MikeWise2718/messelpit_viewer` | Studied in Wave 237 | Omniverse Kit dataset viewer with separate desktop/streaming/XR apps, OpenXR startup diagnostics, in-VR panels, and viewpoint controls |

### Consolidation note

This family matters because spatial sensing tools should name:

- permission and feature gates
- capture source and sampling policy
- worker or reconstruction stage
- render representation
- export/import and local-file handling
- progress/fallback UI
- XR startup/runtime diagnostics

It suggests a stronger branch inside `VR-apps-lab` around:

- WebXR sensing pipeline matrices
- point-cloud lifecycle rules
- measurement micro-tool patterns
- splat/dataset viewer loading UX
- OpenXR startup diagnostic playbooks

## Family 217: VR training, rehabilitation, and simulated-user evaluation harnesses

This family covers training/evaluation systems that join scenario state,
reward/scoring, sensor ingress, feedback, coach logic, and logs.

| Project | Status | Notes |
|---|---|---|
| `fl0fischer/sim2vr` | Studied in Wave 238 | Unity/UitB bridge with RLEnv hooks, ZMQ state exchange, simulated anchors, RGB-D observations, time-scale negotiation, and recorder output |
| `kaayran/ShootingRangeVR` | Studied in Wave 238 | SteamVR weapon/equipment training scenario with target scoring, accuracy panel, remote target movement, and object-state modules |
| `GxRay/Trunk-Rehabilitation-VR-Training-Simulator-` | Studied in Wave 238 | rehab biofeedback loop with TCP EMG/accelerometer ingress, filters, live graphs, Spaceball commands, gaze menu, and HUD stats |
| `Nelliel2/VR-training-simulator` | Checked in Wave 238 | asset-heavy Unity training tree retained as construction/worksite scenario reference |
| `NagashreeSP/VR-Fire-Safety-Training-Simulator` | Source-light in Wave 238 | README-only fire-safety training concept |
| `superjaviko/RESILIENCE` | Studied in Wave 238 | AI-assisted training reference with UPBGE scripts, voice coach, operator-data lookup, navigation helpers, and hardcoded-secret caveats |

### Consolidation note

This family matters because training VR tools should name:

- scenario state and reset hooks
- scoring/reward and termination
- observation or camera capture
- sensor ingress and filtering
- live feedback and graphing
- coach/advisor and external-data adapter
- logging/export and security policy

It suggests a stronger branch inside `VR-apps-lab` around:

- training/evaluation harness patterns
- simulated-user test hooks
- rehab sensor-feedback loops
- AI coach safety boundaries
- scenario scoring and reporting matrices

## Family 218: Game-specific VR retrofit interaction shells and in-game control surfaces

This family covers VR retrofit mods and companion layers that convert existing
games into more complete VR interaction systems through patches, input
adapters, world-space UI, wrist/radial surfaces, keyboards, haptics, and
calibration.

| Project | Status | Notes |
|---|---|---|
| `Okabintaro/SubmersedVR` | Studied in Wave 239 | Subnautica retrofit with SteamVR input patches, settings tabs, laser pointers, virtual keyboard, camera rig, wrist HUD, quick-slot radial wheel, calibration, and debug panel |
| `dortamur/satisfactory-uevr-enhancements` | Studied in Wave 239 | UEVR companion product reference with controller mappings, wrist/radial UI, haptics, help tips, onboarding, input actions, and binary Blueprint assets |
| `DSprtn/GTFO_VR_Plugin` | Studied in Wave 239 | IL2CPP/BepInEx retrofit with SteamVR gate, class injection, VRSystems, input mapping, world-space UI, watch/radial surfaces, terminal keyboard, comfort, and haptics |
| `KyleTheScientist/Bark` | Studied in Wave 239 | Gorilla Tag mod shell with gesture summon, grabbable menu, physical buttons, module lifecycle, hand/pointer interactors, networked state, and manual tests |

### Consolidation note

This family matters because game-retrofit UX should name:

- patch/plugin entry and readiness gate
- VR system owner and focus states
- game-action-to-VR-input adapter
- world-space UI and pointer strategy
- wrist/radial/menu/keyboard surfaces
- comfort, haptics, calibration, and debug layers
- game-specific, binary-asset, ToS, and multiplayer caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- retrofit interaction-shell matrices
- radial/wrist/keyboard pattern extraction
- game-mod-derived UX safety review
- patch layer versus utility layer boundaries
- haptics and comfort policy comparisons

## Family 219: VR WebView browser surfaces and spatial keyboard routing

This family covers Unity/Quest browser surfaces where native WebView content is
treated as an XR panel with explicit search/load controls, focus handling,
spatial keyboard input, and platform/rendering caveats.

| Project | Status | Notes |
|---|---|---|
| `TLabAltoh/TLabWebViewVR` | Studied in Wave 240 | Quest-native WebView package family with Meta XR and XRI adapters, prefabs, spatial keyboard scene, XRBrowserInputField key forwarding, callbacks, Android-only rendering, permission, and rendering-mode caveats |
| `TLabAltoh/TLabWebViewVR-XRInteractionToolkit-2022` | Studied in Wave 240 | Minimal Unity 2022 XRI WebView sample with TLabWebView_XRInteractionToolkit prefab, searchbar example, manifest boundary, and XRI compatibility notes |
| `TLabAltoh/TLabWebViewVR-OculusIntegration-2022` | Studied in Wave 240 | Meta XR WebView variant with TLabWebView_MetaXR prefab, searchbar callbacks, dialog/error events, input-field components, and JavaScript focus/focusout keyboard reference |

### Consolidation note

This family matters because VR browser panels should name:

- native WebView surface versus captured/browser overlay boundary
- XR stack adapter and prefab contract
- URL/search/load callback flow
- focus-gated spatial keyboard routing
- Android permission and render texture mode
- HardwareBuffer/ByteBuffer, Vulkan/OpenGLES, and editor fallback caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- Quest-native WebView surface checklists
- VR text-entry matrix updates
- browser panel permission and rendering-mode notes
- focus/keyboard UX probes
- WebView versus WebRTC versus captured-window comparison tables

## Family 220: Unity XR UI adapter and physical-control microcomponents

This family covers small Unity XR control donors: UI Toolkit panel adapters,
visible grab affordances, physical buttons, keypads, hand-state helpers, and
puzzle/control feedback components.

| Project | Status | Notes |
|---|---|---|
| `BernwardWeigand/UnityUIToolkitXRAdapter` | Studied in Wave 241 | UI Toolkit to XRI bridge with collider-backed UIDocuments, synthetic Input System controller state, ray-to-panel local position mapping, render texture resizing, text-field focus, and angular-size UI |
| `podobaas/XRGrabInteractableRing` | Source-light in Wave 241 | XRI grab-ring affordance reference documenting ring prefab, attach transform, show-on-selected, layer mask, threshold, scale, timing, and events |
| `Priyanshu-CODERX/Unity-XR-Interaction-Toolkit-VR-Mechanisms` | Studied in Wave 241 | XRI mechanism set with UI proximity events, hand animation, hand visibility toggles, XRPushButton, and focused scenes for grab, teleport, UI, snap, hands, and buttons |
| `Youkaku-1/VRPuzzelGame` | Studied in Wave 241 | VR puzzle/control reference with keypad input, accepted/denied feedback, emissive screen state, press animation, door events, decal reveal, and XRI scene surfaces |

### Consolidation note

This family matters because reusable XR controls should name:

- ray-to-panel coordinate mapping
- render texture/collider synchronization
- distance-readable UI scale
- grab affordance visibility and threshold policy
- physical button/keypad event boundary
- hand animation and hand visibility coupling
- feedback surfaces for accepted, denied, locked, revealed, and opened states

It suggests a stronger branch inside `VR-apps-lab` around:

- Unity XR control-pattern matrices
- local sample plans for physical buttons and keypads
- grab-affordance UX comparison
- UI Toolkit versus Canvas/XRI adapter notes
- puzzle/control microcomponent reuse checklists

## Family 221: CV, mocap, and industrial training control loops

This family covers VR systems where the central reusable pattern is not a menu
or overlay, but a sensor-driven loop: ingress, calibration, smoothing, validity
state, safety state, scenario feedback, and structured logs.

| Project | Status | Notes |
|---|---|---|
| `WestCoastGod/XR-CV-Forceps-Tracking-Unity` | Studied in Wave 242 | Quest 3 ArUco forceps tracking with multi-marker rigid pose, reprojection error, One Euro smoothing, visibility-marker clamp state, clamp freeze, geometric grab mapping, and XRI release |
| `jghanania/MotionCapture-AgilityLadder-XR-Study` | Studied in Wave 242 | Quest/OptiTrack study harness with balanced Latin-square conditions, AR/VR/real switching, occlusion control, avatar scaling, mocap alignment, foot-contact measurement, and CSV logging |
| `jesusfernandorl/Industrial_Twin_XR-Safe-Robotics-and-6-Axis-VR-Control` | Source-light in Wave 242 | Industrial robot VR training reference for deadman switch, soft limits, interlocks, physical HMI feedback, spatial audio, Unity Robotics Hub/ROS direction, and safety-standard framing |
| `purva-rana/MindscapeVR` | Source-light in Wave 242 | Neuro-rehabilitation concept with clinical-room to mindscape transition, neural blockage metaphor, XRI framing, and trigger-driven difficulty escalation |

### Consolidation note

This family matters because sensor-tracked VR training tools should name:

- sensor ingress and coordinate frame
- calibration/alignment and participant setup
- smoothing/filtering and validity state
- safety or freeze gates
- scenario condition assignment
- physical/clinical/industrial feedback loop
- logs, CSVs, and privacy/security caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- sensor-ingress training matrices
- ArUco/OptiTrack/EMG/ROS bridge comparisons
- CSV/logging schema review
- industrial safety-state UX references
- rehabilitation metaphor versus measurement boundaries

## Family 222: Spatial measuring, modeling, collaboration, and MR workbench surfaces

This family covers spatial workbench utilities where users capture a point or
surface, edit/model/manipulate it, project it into context, share it, or log the
planning session.

| Project | Status | Notes |
|---|---|---|
| `rtkCode/Sizer` | Studied in Wave 243 | Browser AR measure/model/project donor with WebXR hit-test reticle, distance/angle capture, DOM overlay cards, local history, A-Frame box editing, toolbar gestures, and AR.js marker projection |
| `byte-banditt/Meshelanjelo` | Studied in Wave 243 | Meta Quest MR mesh manipulation donor with OVRHand pinch detection, pointer-pose deformation center, left-pull/right-push semantics, smoothed intensity, and Burst/job vertex-normal radius falloff |
| `B22DigitalTwins2022/ar-resilience-planner-v2` | Studied in Wave 243 | MR planning workbench with additive scene loading, persistent menu state, panel selector, solution grouping, simulation updates, and timestamped user-study CSV logs |
| `adityanooka/Unity-Dive-VR` | Studied in Wave 243 | Collaborative VR reference with Unity Netcode, XRI selection-count lift gates, server-owned spawning, server-only proximity reactions, ownership-guarded movement, and VR/desktop fallback |
| `Hempp/street-art-gallery` | Source-light in Wave 243 | Social VR gallery product reference for hotspots, guided tours, avatars, emotes, voice, nametags, gathering areas, and comfort settings |

### Consolidation note

This family matters because spatial workbench utilities should name:

- capture/measurement source and result object
- model/edit/project stage
- hand or controller manipulation semantics
- local history, undo, and persistence
- collaboration authority and ownership boundaries
- panel/menu state and user-study logs
- social or guided-tour affordances when the tool becomes a shared space

It suggests a stronger branch inside `VR-apps-lab` around:

- spatial-authoring workbench matrices
- undo/history requirements
- collaborative ownership and selection gates
- MR planning panel patterns
- hand-deformation and model-editing safety notes

## Family 223: OpenVR overlay micro-surfaces, telemetry panels, and game HUD prototypes

This family covers small overlay or overlay-like surfaces where the reusable
lesson is lifecycle, placement, texture/data update, settings, edit mode, and
external telemetry or log ingestion.

| Project | Status | Notes |
|---|---|---|
| `Sch1nken/VRChatOverlay` | Studied in Wave 244 | Legacy OpenVR/SFML/OpenGL overlay skeleton with overlay init, tracked-device placement, width/alpha, event polling, texture upload, and dashboard/keyboard notes |
| `ObnubiladO/vram-overlay` | Studied in Wave 244 | Desktop telemetry micro-panel with transparent topmost WPF window, F8 hotkey, GPU memory polling, WMI fallback, context menu, dragging, and JSON settings |
| `Spacefish/OpenVR-Overlay` | Studied in Wave 244 | C# OpenVR overlay with Vulkan texture submission, controller-relative placement, mouse input, dashboard control flags, haptics, and cleanup |
| `lukis101/VRPoleOverlay` | Studied in Wave 244 | OpenVR playspace landmark overlay with edit mode, controller snap/drag, chaperone height/color, fade settings, and SteamVR autostart manifest |
| `AArchAngel/Remlok-HUD` | Studied in Wave 244 | Unity/OVRLay Elite HUD driven by process checks, journal file watching, JSON mission parsing, mission sorting, data loading, and voice prompts |

### Consolidation note

This family matters because tiny overlay utilities should name:

- overlay runtime identity and lifecycle
- transform placement and edit mode
- texture submission or panel rendering source
- telemetry/log/event ingestion
- hotkeys, input, haptics, and user feedback
- settings persistence and autostart boundaries
- hardcoded path, runtime, and game-specific caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenVR overlay lifecycle matrices
- overlay settings schema extraction
- log-driven HUD and notification-feed comparisons
- telemetry micro-panel UX references
- placement/edit-mode overlay prototypes

## Family 224: OpenXR micro-layer render shaping, foveation, and tracking diagnostics

This family covers narrow OpenXR API layers that change view/frame/swapchain
behavior, gate graphics capabilities, record tracking data, or wrap graphics
resources for post-processing.

| Project | Status | Notes |
|---|---|---|
| `danny1marshall1587-maker/MonoEye` | Studied in Wave 245 | Experimental OpenXR mono-eye layer with negotiation, generated dispatch, env enable/bypass, view-count intervention, internal stereo state, and Vulkan/depth-warp intent |
| `TripleJ160/Beyond-EVO` | Studied in Wave 245 | D3D12/VRS foveation layer with graphics-binding capture, extension/device gates, gaze actions, smoothing/fallback, SRI resources, heatmaps, INI, and named-pipe controls |
| `marcsabat/xr-tracking-diagnostics` | Studied in Wave 245 | Minimal OpenXR diagnostic recorder with session/reference-space setup, xrWaitFrame pose reads, F9 toggle, beeps, logs, duration config, and CSV traces |
| `mbucchia/_ARCHIVE_XR_APILAYER_NOVENDOR_nis_scaler` | Studied in Wave 245 | Archived NIS scaler ancestor with swapchain hooks, D3D11 resource wrapping, scaler modes, stats, screenshots, hotkeys, and resource-lifecycle lessons |

### Consolidation note

This family matters because OpenXR layers should name:

- loader negotiation and manifest/config boundary
- dispatch table and hook scope
- runtime/device/extension gates
- bypass, logging, and output paths
- graphics/session resource lifecycle
- frame, view, swapchain, or pose-record intervention
- uninstall, compatibility, and archived-code caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR layer safety checklists
- diagnostic recorder templates
- render-changing layer risk matrices
- foveation/gaze capability gates
- swapchain resource lifecycle notes

## Family 225: SlimeVR DIY tracker hardware, PCB, case, and firmware boundaries

This family covers tracker hardware references where the reusable knowledge is
the boundary between MCU, IMU, battery/charging, PCB, case, firmware config,
calibration, packet schema, and licensing.

| Project | Status | Notes |
|---|---|---|
| `zhangwenchao1992/SlimeVR_DeftTracker` | Studied in Wave 246 | Full tracker kit with main/aux tracker, charge hub, cases, PCB outputs, photos, and broad SlimeVR firmware subtree |
| `frosty6742/frozen-slimes-v2` | Studied in Wave 246 | Maker PCB with Wemos, multi-IMU bridge pads, TP4056, 18650, strap slots, assembly checklist, firmware orientation, and calibration notes |
| `TheButlah/slimevr_pcb` | Studied in Wave 246 | Board family split across simple breakout and ESP32-C3 ferrous_slime, with IMU compatibility jumpers, breakout adapters, changelogged fixes, and open-hardware posture |
| `gumorr/GummySlime` | Studied in Wave 246 | Hand-solderable SlimeVR-compatible board with 0603 passives, module IMUs, ESP32-C3, auxiliary pads, USB-C/charging, BOM, KiCad, and PlatformIO defines |
| `Tropingenie/Caribou-Slime` | Studied in Wave 246 | ESP32-C3/BMI270 tracker PCB with BOM/cost notes, charger/battery design, hand-assembly or PCBA framing, and reciprocal hardware license |
| `infopcgood/SMORES` | Source-light in Wave 246 | Tiny-board direction around EBYTE E73/nRF52840 and ICM-45686 requiring deeper schematic/firmware evidence |
| `ZRock35/TinyOfficial-Case` | Source-light in Wave 246 | Mechanical case reference for official SlimeVR PCB with strap loops, open/closed tops, battery orientation, foam, and connector warnings |
| `1vers1on/vr_trackers` | Studied in Wave 246 | Zephyr tracker skeleton with IMU/magnetometer/fuel/charger/button/USB init, packet schema, gyro calibration, board DTS, and incomplete runtime loop |

### Consolidation note

This family matters because DIY tracker research should name:

- MCU, radio, and IMU compatibility
- battery, charger, and power-management choices
- PCB, BOM, Gerber, KiCad, and assembly state
- case, strap, battery, and connector ergonomics
- firmware defines, packet schema, and calibration
- license obligations and manufacturing caveats
- maturity level before donor promotion

It suggests a stronger branch inside `VR-apps-lab` around:

- SlimeVR derivative matrices
- tracker hardware note templates
- firmware packet and calibration comparisons
- case/strap UX checklists
- open-hardware license caveat notes

## Family 226: Webcam avatar body tracking bridges and VRM motion surfaces

This family covers body-tracking bridges that turn camera, IMU, or
headset/controller data into OSC tracker poses, SteamVR synthetic trackers,
Unity avatar bones, VRM avatars, or networked avatar expressions.

| Project | Status | Notes |
|---|---|---|
| `zekailin00/VR-Full-Body-Tracking-System` | Studied in Wave 247 | ESP8266 IMU plus Unity HMD/controller HTTP bridge with Flask pose solver, shared structs, smoothing, body mapping, Unity pose polling, and hardcoded-network caveats |
| `Raraph84/Cameras-Full-Body-Tracking` | Studied in Wave 247 | Browser/WebRTC multi-camera MediaPipe bridge with square calibration, homography/focal estimation, DLT triangulation, smoothing, and OSC tracker output |
| `DubbsPi/Mediapipe-SteamVR-Full-Body-Tracking-for-Linux` | Studied in Wave 247 | Linux Python MediaPipe process feeding an OpenVR server driver through Unix socket packets to expose generic trackers |
| `yeemachine/kalidoface-3d` | Studied in Wave 247 | Browser VRM/Vtubing product reference with MediaPipe/Kalidokit, Three/VRM, local persistence, backgrounds/stickers, OBS mode, and P2P voice framing |
| `Neleac/MesekaiUnity` | Studied in Wave 247 | Unity MediaPipe avatar retargeting with pose/hand/face solvers, blendshape mapping, template-avatar transfer, ReadyPlayerMe loading, and Photon serialization |

### Consolidation note

This family matters because body-tracking bridges should name:

- capture source and calibration flow
- landmark/IMU validity and smoothing
- transport protocol and timing
- pose solving and coordinate-frame conversion
- output adapter: OSC, driver, Unity bones, VRM, or network avatar
- retargeting and template-avatar boundaries
- hardcoded network, source-bundle, and fixed-dimension caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- camera/body-tracking transport matrices
- calibration UX checklists
- avatar retargeting comparisons
- synthetic tracker output schemas
- webcam-to-avatar product reference notes

## Family 227: VRChat OBS world metadata and browser source overlays

This family covers streamer-facing overlays that convert VRChat world/location
state into OBS browser sources, text files, or scene events.

| Project | Status | Notes |
|---|---|---|
| `Natsumi-sama/VRC-OBS-Overlay` | Studied in Wave 248 | Blazor localhost OBS browser source using VRChat registry location context, world metadata extraction, Razor UI updates, no-cache responses, and CSS customization |
| `philippgitpush/vrc-obs-world-overlay` | Studied in Wave 248 | Electron/Vue overlay reading VRCX SQLite world state and auth-cookie data, serving local Express routes, storing settings, and rendering polished placement/platform overlays |
| `ktmage/vrc-world-credit-streaming-overlay` | Studied in Wave 248 | TypeScript log watcher and SSE browser source with incremental file offsets, Zod schemas, VRChat API contact handling, cache/rate-limit state, and card/topbar styles |
| `Mahcks/vrc-world-teller` | Studied in Wave 248 | Tiny Node VRChat API poller that writes current world text for OBS text sources |
| `Elocin-Anagram/VRC_World_Location` | Studied in Wave 248 | PowerShell log tailer with adaptive tail sizing, generated world/performance text files, and HTML browser-source polling |
| `nosjo/obs-vrchat-log-reader` | Studied in Wave 248 | OBS Lua script reading VRChat logs directly and switching OBS scenes on room transition events |

### Consolidation note

This family matters because stream overlays should name:

- state source: registry, VRCX, log file, API, or OBS script
- dedupe and current-world detection
- metadata fetch/cache and rate-limit state
- browser-source, text-file, or scene-switch output
- privacy and credential boundaries
- stale/error UI for stream viewers

It suggests a stronger branch inside `VR-apps-lab` around:

- safe VRChat state-source adapters
- OBS browser-source templates
- log-to-SSE overlay examples
- streamer metadata overlays with explicit privacy notes
- OBS-native script versus companion-app comparisons

## Family 228: VRChat OBS control, OSC scene switching, and movie night queues

This family covers control bridges where VRChat, avatar parameters, OBS
scripts, local apps, or world-transition state control OBS stream, record,
replay, microphone, scene, or media playback state.

| Project | Status | Notes |
|---|---|---|
| `nerdywoffy/vrchat-obs-controller` | Studied in Wave 249 | Go OSC sidecar with avatar parameter contracts, OBS v5/Streamlabs adapters, replay/record/stream/scene controls, status polling, and avatar feedback |
| `rogeraabbccdd/VRChat-OBSOSC` | Studied in Wave 249 | Compact Node OBS v4/v5 bridge controlled by expression-menu parameters with startup state sync and OBS event feedback |
| `ioarchive/obscontrol` | Historical UX reference in Wave 249 | VRChat MelonLoader/ReMod quick-menu OBS controller with world-transition scene switching; retained with EAC/TOS caveats |
| `TuTu475/VRC-OBS-MicControl` | Studied in Wave 249 | OBS Python script listening to VRChat mute OSC with debounce, correction interval, source selection, and script settings |
| `dimebag29/VRChatObsMicMuteLink` | Studied in Wave 249 | Windows tray app mapping VRChat mute OSC to global OBS hotkey chords |
| `0x29a-blink/VRChat-Movie-Night` | Studied in Wave 249 | Local event operator stack with auth, media queue, OBS media-source control, auto-advance, MediaMTX HLS presets, and stream health checks |
| `MissingNO123/OBS-Scripts-for-VRChat` | Studied in Wave 249 | OBS-native scripts for VRChat loading-screen scene switching and action-menu OSC control with status feedback |

### Consolidation note

This family matters because in-VR stream control should name:

- command source and avatar parameter schema
- OBS backend/API version
- action idempotency and scene index bounds
- status feedback into VRChat or OBS UI
- debounce, correction, reconnect, and backoff
- auth, localhost, hotkey, and mod-policy caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- bidirectional OSC-to-OBS control adapters
- OBS-native script templates
- safe stream-control schemas
- movie-night/world-video-player operator surfaces
- mic sync and loading-screen scene switching microtools

## Family 229: VRChat virtual production, camera routing, and live stream pipelines

This family covers VR event-production pipelines where world cameras, VJ tools,
OBS, RTMP/HLS, camera-control pages, and browser-source outputs form one
operator workflow.

| Project | Status | Notes |
|---|---|---|
| `designio360/virtualproduction-vrchat` | Source-light in Wave 250 | Unity package reference for VRChat production stages with cameras, crane, overlay slides, lighting controls, in-world buttons, keyboard controls, and OBS capture |
| `valkyriedimension/TD2VRC` | Source-light in Wave 250 | TouchDesigner-to-VRChat VJ routing guide using OBS, Spout/window capture, RTSP, stream links, screenshots, and a `.toe` example |
| `RemilRLs/StreamToVRC` | Studied in Wave 250 | Docker/NGINX RTMP-to-HLS donor with OBS ingest, ffmpeg bitrate variants, HLS fragments, CORS/no-cache headers, and VRChat video-player URL framing |
| `dragokenlancer/VRC-Camera-control-webpage` | Studied in Wave 250 | POC browser camera-control page with password sessions, public-viewing split, OSC pose/zoom address mapping, and preview-routing intent |
| `reece-berens/vrc-stream-plugins` | Adjacent reference in Wave 250 | Browser-source plugin shell with API helper service, Next output pages, and typed event-score helpers |
| `furukawa1020/VRcoverOBS` | Adjacent reference in Wave 250 | Avatar/OBS output system with tracking-to-WebSocket gateway, browser avatar runtime, canvas streaming, and OBS setup docs |

### Consolidation note

This family matters because VR event production should name:

- in-world production controls
- external visual/media source
- media ingest and transcode layer
- public playback URL and latency
- preview and camera-control path
- OBS browser-source or virtual-camera output
- public port, auth, and beta API caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- VR event production checklists
- RTMP/HLS and MediaMTX/NGINX comparisons
- VRChat camera-control safety notes
- VJ and visual-production workflow references
- browser-source plugin packaging

## Family 230: OpenVR legacy sensor compatibility and synthetic driver shims

This family covers driver-side adaptation projects for legacy sensors,
identity compatibility, no-HMD control, DIY headsets, and vendor headset
bridge lineage.

| Project | Status | Notes |
|---|---|---|
| `SDraw/driver_leap` | Studied in Wave 251 | Leap Motion to SteamVR controller driver with Leap poller, tracking reference, left/right controller devices, skeleton/input mapping, overlays, and settings app |
| `SDraw/driver_kinectV1` | Studied in Wave 251 | Kinect V1 skeleton to SteamVR generic tracker driver with joint filters, Vive Tracker-style identity, dashboard settings, tracker toggles, and calibration |
| `SDraw/driver_kinectV2` | Studied in Wave 251 | Kinect V2 sensor variant with similar driver/dashboard/calibration boundaries and runtime-specific caveats |
| `schellingb/PseudoVive` | Studied in Wave 251 | Early-load OpenVR property hook forcing Vive manufacturer/model identity, with optional systray toggle |
| `r57zone/Half-Life-Alyx-novr` | Studied in Wave 251 | Game-specific no-HMD SteamVR driver and key/mouse to VR controller mapping reference |
| `lixiangwuxian/Viulux-V9-Driver-for-SteamVR` | Source-light in Wave 251 | README-only vendor headset bridge lineage tying Viulux, Relativty, OpenHMD, and Nolo requirements together |
| `Blockmann2K/MurlokVR` | Studied in Wave 251 | DIY HMD experiment with firmware, Rust serial runtime, shared-memory pose contract, OpenVR factory/provider, settings, and pose polling |

### Consolidation note

This family matters because custom OpenVR drivers should name:

- driver manifest, factory, provider, and device class
- hardware polling or shim source
- device identity and compatibility assumptions
- pose/input transport and timing
- calibration or companion control surface
- cleanup, unload, and runtime registration
- obsolete SDK, spoofing, and hardcoded transport caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenVR driver-boundary matrices
- legacy sensor to tracker/controller comparisons
- identity spoofing risk notes
- DIY HMD runtime-to-driver transport templates
- no-HMD/virtual-HMD caveat checklists

## Family 231: Hands-free and hand-derived XR input microtools

This family covers small utilities and samples that turn HMD pose, hand
tracking, finger curls, pinch rays, or wrist-mounted UI into practical input
for VR tools.

| Project | Status | Notes |
|---|---|---|
| `SimForgeEngineering/DCS-HandsFree` | Studied in Wave 252 | StereoKit/OpenXR head-pose to Windows foreground-window cursor mapper with yaw/pitch normalization and Win32 cursor output |
| `JonahSagers/VRChord` | Studied in Wave 252 | Unity XR Hands chording keyboard with curl classifiers, chord dictionaries, fist-distance enable latch, thumb actions, and TextMeshPro feedback |
| `Haidere1/VarjoXR-CustomHandTracking-Test` | Studied in Wave 252 | Unreal/Varjo OpenXR hand-keypoint, pinch-ray, poseable-mesh, widget, and scene-manipulation sample |
| `zodiepupper/godothandtrackingtests` | Studied in Wave 252 | Godot OpenXR raw joint tracker and wrist-menu experiment with passthrough branch, fingertip collision layers, smoothing, and Panel3D addon |

### Consolidation note

This family matters because controllerless utility input should name:

- sensor source: head pose, hand joints, finger curls, pinch rays, or wrist UI
- calibration, recenter, and normalization
- gesture/chord thresholds and fatigue risk
- output adapter: cursor, text, scene ray, panel, or command
- visible feedback and escape/disable path
- platform, vendor, and runtime assumptions

It suggests a stronger branch inside `VR-apps-lab` around:

- hands-free cursor and accessibility microhelpers
- hand-derived text and command input
- wrist menu safety checklists
- controllerless calibration/recenter UX
- engine-specific hand input boundary comparisons

## Family 232: SteamVR dashboard navigation and system-input shims

This family covers helpers that route keyboard, Quest system-button, gamepad,
dashboard keyboard layout, or volume-slider signals into SteamVR dashboard and
runtime control paths.

| Project | Status | Notes |
|---|---|---|
| `mbucchia/SteamVR-Dashboard-KeyboardNav` | Studied in Wave 253 | OpenVR driver shim wrapping an HMD driver, overriding input profile paths, using shared-memory click IPC, and launching a keyboard-hook companion |
| `lmore377/quest-steamvr-system-button` | Studied in Wave 253 | ADB/logcat Quest home-button watcher dispatching SteamVR dashboard toggle URIs for OculusKiller/Link workflows |
| `AJBats/pad-vr` | Studied in Wave 253 | XInput gamepad to synthetic SteamVR controller driver with chest pose, Index-style input paths, companion IPC, dashboard and recenter actions |
| `MagnaLunas/SteamVRKeyboardLayoutChanger` | Obsolete runtime patch reference in Wave 253 | SteamVR dashboard keyboard layout patch via copied JSON/JavaScript resources and cache-clearing instructions |
| `bpbwaite/ahk-svrvmr` | Studied in Wave 253 | AutoHotkey bridge mapping SteamVR or Windows volume state to Voicemeeter gain through Vista Audio and VoicemeeterRemote |

### Consolidation note

This family matters because dashboard helpers should name:

- input signal source and capture risk
- runtime adapter: driver shim, synthetic controller, URI command, resource
  patch, or external DLL route
- activation gate and stale-state behavior
- dashboard visibility and feedback
- compatibility with SteamVR versions, device drivers, and real controllers
- uninstall/cleanup and user consent

It suggests a stronger branch inside `VR-apps-lab` around:

- safe SteamVR dashboard navigation shims
- synthetic controller and guide-button bridge comparisons
- runtime patch caveat docs
- dashboard command feedback patterns
- small accessibility helpers for SteamVR menus

## Family 233: VRChat OSC chatbox media, status, and library microtools

This family covers chatbox and OSC microtools that publish media, clock,
biometric, system, template, or module-driven status into VRChat.

| Project | Status | Notes |
|---|---|---|
| `lillithrosepup/Lilypad` | Studied in Wave 254 | Kotlin Multiplatform/Compose Android OSC client with modules, OSCQuery, Spotify/LastFM, synced lyrics, avatar presets, banners, and clocks |
| `ohkaelynn/iron-heart-chatbox` | Studied in Wave 254 | Iron-Heart BPM text-file to chatbox tray bridge with trend/history formatting, process checks, cadence, and privacy caveats |
| `MeltyMooncakes/VRChat-OSC-Script` | Studied in Wave 254 | TypeScript chatbox composer with YAML templates, OSC property cache, media adapters, plugin loader, and send-interval gates |
| `o0F-0oF/VRChat-Spotify-Chatbox` | Studied in Wave 254 | Tiny Python Spotify window-title to chatbox sender |
| `o0F-0oF/VRChat-Spotify-Chatbox-CS` | Studied in Wave 254 | C# SharpOSC Spotify window-title chatbox sender with compact polling and port caveat |
| `Mezque/VRC-SpotifyOSC-Py` | Studied in Wave 254 | Spotipy OAuth now-playing chatbox sender with settings.ini and timer-based resend behavior |
| `Mezque/VRC-ClockOSC-Py` | Studied in Wave 254 | Minimal clock-to-chatbox sender with format string configuration |
| `eepyfemboi/ezmusic-desktop-client` | Product reference in Wave 254 | Desktop music/status client with webview login, cookie persistence, GPU/system stats, Discord RPC, and VRChat OSC output |
| `ActuallyAbby/VRC-JavaOSC` | Studied in Wave 254 | Java OSC helper library with default VRChat ports, parameter cache, avatar-parameter listeners, and typed set/get helpers |
| `Disconnect3301/DisconnectOSC` | Caveated reference in Wave 254 | C# console OSC toy modules with chatbox commands and recording timer, retained with artifact and prank-feature caveats |

### Consolidation note

This family matters because chatbox utilities should name:

- data source adapter: media API, window title, file sensor, clock, stats, or
  avatar parameter
- template engine and privacy policy
- cadence, dedupe, keep-open, and blanking behavior
- OSCQuery or fixed-address routing
- plugin/module trust boundary
- credential storage and consent for public status

It suggests a stronger branch inside `VR-apps-lab` around:

- chatbox composer templates
- source-adapter safety matrices
- OSC library comparison notes
- privacy-aware media and biometric status UX
- Android/Quest companion chatbox architecture

## Family 234: XR desktop, smart-glasses, and WebXR authoring utility surfaces

This family covers utilities around smart-glasses desktop routing, IMU-driven
display transforms, desktop indicators, WebXR developer surfaces, and
authoring/export helpers.

| Project | Status | Notes |
|---|---|---|
| `ProjectBlueSkies/xr-desktop` | Studied in Wave 255 | Viture XR Pro Linux desktop helper with C IMU daemon, shared-memory quaternion IPC, and GNOME Shell world-lock transform |
| `mhalder/xreal-desktop-mode` | Studied in Wave 255 | ADB desktop-mode configuration microtool for Xreal One Pro with Android desktop/freeform settings and external-display density tuning |
| `marbetschar/wingpanel-indicator-xrdesktop` | Studied in Wave 255 | Elementary/Pantheon panel indicator exposing xrdesktop enabled state through DBus, dynamic icon, and popover UI |
| `cong-lab/LabOS-Runtime` | Studied in Wave 255 | VITURE smart-glasses lab runtime with connector abstraction, USB config deployment, voice/web/dashboard services, MediaMTX, and gRPC |
| `sawa-zen/three-fiber-webxr-toolbox` | Studied in Wave 255 | React/Three WebXR dev toolbox with in-HMD console, curved remote display, Vite/socket.io WebRTC signaling, portals, and passthrough helpers |
| `laffan/blender-webxr-tools` | Studied in Wave 255 | Blender addon for WebXR/R3F export preparation with bake/transform helpers, gltfjsx subprocess integration, and JSX rewrite caveats |
| `pravinpoudel/building-annotation` | Studied in Wave 255 | WebXR building annotation reference with manual annotation schema, camera/lookAt metadata, and dev-mode raycast capture |

### Consolidation note

This family matters because XR utility surfaces should name:

- hardware or display configuration adapter
- pose/IMU, shell, or browser display boundary
- IPC, DBus, WebRTC, or file/export transport
- setup and calibration UX
- authoring/export lifecycle
- device, browser, CORS, ADB, or shell-extension caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- smart-glasses desktop setup microtools
- IMU-to-shell world-lock templates
- WebXR development utility overlays
- Blender/WebXR export pipeline checklists
- annotation schema and scene-inspection surfaces

## Family 235: VMC transport and identity-preserving motion bridges

This family covers projects that move VMC, OpenXR pose, or avatar motion data
across local protocol, network transport, and operator-monitor boundaries.

| Project | Status | Notes |
|---|---|---|
| `LukasLichten/simple-xr2vmc` | Studied in Wave 256 | Minimal Rust OpenXR headless pose sampler with extension gates, action-set pose polling, session events, predicted-time reads, and incomplete VMC output |
| `sotanmochi/VMCTransportBridge` | Studied in Wave 256 | Unity/.NET VMC transport bridge with typed messages, MessagePack envelopes, network client identity, transport adapters, subscriber filters, and re-emission |
| `sotanmochi/VMCTransportHub` | Studied in Wave 256 | WPF/Blazor operator hub for VMC transport choice, destination routing, client-id filters, connection state, and message monitoring |
| `vivi90/python-vmc` | Source-light in Wave 256 | Moved Python VMC wrapper pointer, retained as a scripting-language follow-up node |

### Consolidation note

This family matters because pose bridges should name:

- pose source and runtime/session assumptions
- local protocol parser or sender
- typed message model and transform/calibration boundary
- client identity and routing model
- network transport and reconnect behavior
- monitor or operator surface
- security and trust assumptions

It suggests a stronger branch inside `VR-apps-lab` around:

- VMC/VRM/OSC tracker bridge matrices
- identity-preserving motion relay patterns
- headless OpenXR pose-source helpers
- bridge monitor and operator UI templates
- transport auth, latency, and transform-calibration caveats

## Family 236: XSOverlay notification relay and compatibility surfaces

This family covers projects that send desktop, app, vendor-log, audio, status,
or VRChat events into XSOverlay-compatible notification APIs.

| Project | Status | Notes |
|---|---|---|
| `nnaaa-vr/XSOverlay-VRChat-Parser` | Studied in Wave 257 | VRChat log-event parser with per-event XSOverlay notification config |
| `bluskript/xsoverlay-notifier` | Studied in Wave 257 | Rust Windows toast listener/poller to XSOverlay UDP bridge |
| `nnaaa-vr/XSNotifications` | Studied in Wave 257 | Queue-backed .NET XSOverlay UDP notification helper library |
| `Minty-Labs/WindowsXSO` | Studied in Wave 257 | Windows toast companion with app filters, permission guidance, SteamVR lifecycle, and notification heuristics |
| `Duinrahaic/XSSocket` | Studied in Wave 257 | C# XSOverlay WebSocket command/status wrapper for notifications, overlay commands, device info, media, and settings |
| `Zyphrono/XSOverlay-VRChat-Status` | Studied in Wave 257 | VRChat service-status change detector with XSOverlay warnings |
| `project-vrcat/XSNotifier-Go` | Studied in Wave 257 | Minimal Go XSOverlay UDP payload normalizer and client |
| `gizmogoat/XSNotifyDaemon` | Studied in Wave 257 | Linux compatibility daemon that accepts XSOverlay-like WebSocket notifications and forwards to `notify-send` |
| `JacobA2000/VRCazam` | Studied in Wave 257 | VRChat OSC trigger to loopback audio recognition and XSOverlay/desktop notification |
| `pikepikeid/PICOBatteryWatcher` | Studied in Wave 257 | PICO Connect log-tail battery monitor with XSOverlay WebSocket notifications |

### Consolidation note

This family matters because notification relays should name:

- event source and permission gate
- event normalization and privacy filter
- dedupe, cadence, and threshold policy
- payload schema and transport adapter
- delivery/fallback behavior
- platform compatibility or daemon emulation boundary
- user-facing filter and pause state

It suggests a stronger branch inside `VR-apps-lab` around:

- XSOverlay UDP/WebSocket payload matrices
- privacy-safe desktop-to-VR notification relays
- vendor-log telemetry microtools
- compatibility-daemon patterns for Linux and alternate overlay hosts
- avatar-triggered desktop action and notification loops

## Family 237: VRChat OSC micro-control and external-signal utilities

This family covers small VRChat OSC tools that convert hotkeys, controller
state, BLE/MIDI/device signals, shell commands, or UI actions into avatar,
input, and chatbox endpoints.

| Project | Status | Notes |
|---|---|---|
| `Sayamame-beans/VRC_AFK_AutoMuter` | Studied in Wave 258 | AFK/MuteSelf state mirror with delayed `/input/Voice` pulse |
| `03milo/InputFixer` | Studied in Wave 258 | OpenVR controller axis poller and threshold remapper for VRChat OSC input |
| `Airbee/VRChat-OSC-Scaling` | Studied in Wave 258 | Tiny eye-height parameter sender UI |
| `koturn/OscRapidUseRight` | Studied in Wave 258 | Global-hotkey rapid `/input/UseRight` sender with safe release on stop |
| `Hino-VRChat/vrchat-mute-toggle` | Studied in Wave 258 | Robust tray mute toggle with hotkey queue, state listener, process polling, and cooldown |
| `SourLemonJuice/VRChat-OSC-Shell` | Studied in Wave 258 | CLI chatbox and typing wrapper for shell scripts |
| `YimuQrrr/OSC_Tool` | Studied in Wave 258 | Chatbox, OSC scanner, address tester, MIDI mapper, key-file mode, and log monitor toolkit |
| `xiaoBingge114514/VRChat-OSC-Chat-Tool` | Studied in Wave 258 | Desktop chatbox/status composer with music, lyrics, heart rate, system stats, and templates |
| `Ero-Cat/hr_push` | Studied in Wave 258 | Flutter BLE heart-rate bridge with HTTP/WS/MQTT/OSC outputs and chatbox templates |
| `kb10uy/phorcys` | Studied in Wave 258 | Rust OSC parser/serializer, VRChat config helpers, and MIDI-to-parameter mapper |

### Consolidation note

This family matters because OSC micro-control utilities should name:

- input/source adapter
- typed OSC address contract
- state mirror, listener, or parameter cache
- queue, cooldown, debounce, and safe release behavior
- process/lifecycle gate
- visible tray, UI, CLI, or log feedback
- privacy and consent for public or biometric output
- port conflicts and OSCQuery fallback strategy

It suggests a stronger branch inside `VR-apps-lab` around:

- VRChat OSC microtool safety checklists
- external-signal to avatar-parameter routing
- typed OSC library comparisons
- queue/cadence patterns for command surfaces
- biometric and MIDI bridge caveats

## Family 238: Meta Quest companion capture, telemetry, and setup helpers

This family covers Quest companion utilities that handle capture, media
ingestion, sensor streams, ADB setup, registry/config patching, screen
casting, and research data export.

| Project | Status | Notes |
|---|---|---|
| `t-34400/metaquest-3d-reconstruction` | Studied in Wave 259 | Quest Reality Capture images/depth to Open3D/COLMAP reconstruction pipeline with dataset contracts and coordinate transforms |
| `kodaekwan/MetaQuest_HandTracking` | Studied in Wave 259 | Quest/Unity hand and headset UDP telemetry receiver, coordinate transformer, visualizer, and adjacent UDP JPEG streamer |
| `lukasmoro/cameraaccess-metaquest` | Studied in Wave 259 | Quest cast plus OBS virtual camera to Python YOLO and Unity TCP client workaround |
| `CHUNx3/MetaQuestBitrateRegistryEditor` | Studied in Wave 259 | WinForms Meta Link registry patcher with restore-by-delete behavior |
| `t-34400/MetaQuestScreenshotLoader` | Studied in Wave 259 | Unity Android plugin loading latest Quest screenshot bytes into a texture |
| `hiroyamochi/quest-screen-caster` | Studied in Wave 259 | Quest GUI over scrcpy and ADB screenrecord with model detection, wireless ADB, wake/proximity guards, display-id fallback, and ffplay/OBS modes |
| `XargonWan/metaquest-username-changer` | Studied in Wave 259 | Bash/ADB username JSON and global-setting patch microtool with progress-reset warning |
| `SinanAkkoyun/OculusQuest2ADBAutoWifi` | Studied in Wave 259 | Node CLI for Quest ADB Wi-Fi setup using USB wait, `tcpip 5555`, and route-based IP discovery |
| `Clept0/Unity_QuestPro_EyeTrackingRecorder` | Studied in Wave 259 | Unity OVR eye-tracking recorder with calibration scenes, CSV schema, heatmap particles, and Python gaze-error analysis |

### Consolidation note

This family matters because Quest helper utilities should name:

- device discovery and version/model assumptions
- permission, ADB, registry, storage, or identity gate
- capture/sensor adapter
- transport and data schema
- desktop processing or Unity plugin boundary
- operator UI and rollback path
- privacy, power-state, and device safety caveats

It suggests a stronger branch inside `VR-apps-lab` around:

- Quest capture path matrices
- ADB setup and safety checklists
- screenshot/media ingestion helpers
- screenrecord/scrcpy/OBS virtual-camera comparisons
- Quest hand/eye/depth/camera telemetry schemas

## Family 239: VRChat API client, mobile companion, and pipeline surfaces

This family covers projects that expose VRChat service data through API
clients, companion apps, generated bindings, pipeline WebSocket access, local
log sync, and typed friend/world/notification helpers.

| Project | Status | Notes |
|---|---|---|
| `LinaTsukusu/vrchat-client` | Studied in Wave 260 | Compact TypeScript API wrapper with module-per-domain clients, axios base URL switching, cookie-based login, and shared request helpers |
| `ccamgr/vrcp` | Studied in Wave 260 | Expo/Tauri companion with generated API bindings, SecureStore auth/TFA, desktop log sync, session analytics, and notification background task |
| `binn/VRChat.API.Client` | Studied in Wave 260 | .NET fluent/generated-client wrapper with IVRChat domain interface, builder options, auth cookie injection, and named client factory |
| `calmery/vrchat` | Studied in Wave 260 | Compact TypeScript auth/TFA/cookie wrapper with explicit errors and authenticated CRUD helpers |
| `Ox0017/vrc` | Studied in Wave 260 | Java API client with request context, DTO/serializer surface, auth verification, and session token refresh/clear behavior |
| `VRCMG/vrcapi-client` | Studied in Wave 260 | TypeScript REST and pipeline client with endpoint modules, login/config fetch, and WebSocket token initialization |

### Consolidation note

This family matters because VRChat service-data utilities should name:

- credential source and consent state;
- TFA and cookie/token lifecycle;
- REST, pipeline WebSocket, local log, or VRCX data adapter;
- typed domain modules and generated-client boundary;
- cache/local database and background task behavior;
- privacy filter, rate/backoff policy, and account/session visibility.

It suggests a stronger branch inside `VR-apps-lab` around:

- VRChat API companion checklists;
- typed friend/world/notification data adapters;
- pipeline-event vs polling comparisons;
- privacy-aware social/session companion surfaces;
- local log and desktop/mobile sync boundaries.

## Family 240: VRChat expression menu authoring and runtime menu helpers

This family covers creator-side expression-menu tools, generated avatar-toggle
assets, icon pipelines, menu/parameter/animator mergers, and caveated runtime
menu patches.

| Project | Status | Notes |
|---|---|---|
| `nekochanfood/VRCStyledIconMaker` | Studied in Wave 261 | Expression-menu icon processor with SVG-to-PNG resize/padding, gradient recolor, shadow, and transparent canvas output |
| `nekoare/vrchat-expression-menu-visualizer` | Studied in Wave 261 | Unity expression-menu visualizer/editor with tree/grid view, search/stats, edit mode, ModularAvatar reflection, and generated marker metadata |
| `imagitama/vrc-menu-merger` | Studied in Wave 261 | Menu/parameter/animator merger with 8-control cap checks and parameter type conflict detection |
| `zutozuto/VRChat-Menu-Creation-Tool` | Studied in Wave 261 | Outfit/prop menu generator with ScriptableObject config, cloth/ornament/extra groups, show/hide paths, and sub toggles |
| `Knucklesfan/VRChatTextToMenu` | Studied in Wave 261 | Text-to-submenu generator with Unity YAML pages, 8-item pagination, and GUID post-pass caveats |
| `Lucario4LyfeYT/EasyToggle` | Studied in Wave 261 | Unity editor toggle generator that creates animation clips, animator layers, parameters, and menu controls |
| `AtiLion/VRCMenuUtils` | Caveated reference in Wave 261 | Runtime VRChat quick-menu mod library with reflection-based UI manager access and quick-menu page/button helpers |
| `CaelBun/DontOverrenderMyMenuV2` | Caveated reference in Wave 261 | Runtime menu overrender patch with cloned UI camera, culling masks, Harmony patches, and quick-menu toggle |

### Consolidation note

This family matters because expression-menu authoring should name:

- input objects, icons, materials, and source menus;
- generated parameter contract and parameter budget;
- menu page limit and submenu generation;
- animator/controller changes;
- preview, Undo, metadata markers, and cleanup;
- native menu, ModularAvatar, VRCFury, or runtime-patch boundary.

It suggests a stronger branch inside `VR-apps-lab` around:

- expression-menu authoring checklists;
- generated avatar-control assets;
- menu visualizer/editor prototypes;
- ModularAvatar/native menu comparison notes;
- historical runtime menu patch caveats.

## Family 241: VPM package index and creator package publication tooling

This family covers tools and repository shapes that publish VRChat creator
packages through VPM-compatible indexes, public listing pages, and platform
wrappers.

| Project | Status | Notes |
|---|---|---|
| `Limitex/voyager-vpm` | Studied in Wave 262 | Rust VPM package index generator with manifest/lock workflow, crash-recoverable transactions, GitHub release fetch, validation, URL checks, and index output |
| `NathMorgan/vrchat-vpm` | Studied in Wave 262 | Flatpak-style Linux wrapper for VRChat VPM CLI with dotnet SDK extension, pinned NuGet source, and license notices |
| `tamakiii/vrchat-vpm` | Studied in Wave 262 | Minimal static VPM listing with hand-authored index JSON and browser-generated VCC add-repo links |
| `cuebitt/vpm` | Studied in Wave 262 | Public VPM repository with source manifest, generated listing website, search, metadata modal, dependencies, licenses, and Add-to-VCC links |

### Consolidation note

This family matters because reusable creator packages should name:

- package source manifest and release asset contract;
- manifest/lock/hash validation;
- URL, SemVer, dependency, and license checks;
- generated `index.json` and public listing page;
- VCC/ALCOM add-repo link;
- Linux/CLI packaging and permission constraints.

It suggests a stronger branch inside `VR-apps-lab` around:

- VPM publication checklists for reusable packages;
- package-index validation reports;
- public listing UX references;
- Linux creator tooling wrappers;
- package release hygiene for future prototype reuse.

## Family 242: Source-light VRChat overlay, editor, world, and Udon microtools

This family covers small VRChat utility repositories where the main research
value is classification across surfaces: desktop overlay, SteamVR overlay,
Unity editor package, world editor helper, Udon runtime component, or package
template.

| Project | Status | Notes |
|---|---|---|
| `o0F-0oF/vrchatoverlay` | Studied in Wave 263 | Avalonia transparent click-through desktop overlay that tails VRChat logs and renders player join/leave state |
| `kizuki1749/VRChatOverlay` | Partially studied in Wave 263 | Historical Unity/SteamVR overlay experiment with scene-level render texture, overlay placement, bundled API client, and heavy artifact caveats |
| `kxn4t/kanameliser-editor-plus` | Studied in Wave 263 | VPM-installable editor QoL suite with mesh info, NDMF preview, material matching, ModularAvatar material helper, AO bounds, and blendshape insertion |
| `Zaknin/VRCTools` | Studied in Wave 263 | Unity avatar asset inspector with renderer/material/texture/shader scans, memory estimates, missing-reference detection, performance icons, and packager states |
| `Himakuma/VRChatWorldTools` | Studied in Wave 263 | SDK2-era world editor helper that wires reset-position callbacks to a selected button |
| `yassann325/VRC-NetworkQueue` | Source-light in Wave 263 | Mostly VRChat template-package/VPM listing reference; real NetworkQueue implementation needs confirmation |
| `PeaceKunihiro/vrchat-udon-tools` | Studied in Wave 263 | Tiny Udon scripts for synced cycle switching, audio selection, owner transfer, serialization, and delayed auto-hide |

### Consolidation note

This family matters because source-light VRChat repos should name:

- surface type: overlay, editor, world, Udon, or template;
- data source and entry point;
- artifact hygiene and bundled dependencies;
- editor/runtime boundary;
- generated assets, package state, and install route;
- donor/reference/follow-up classification.

It suggests a stronger branch inside `VR-apps-lab` around:

- source-light utility triage checklists;
- avatar editor diagnostics;
- Udon microtool sync review;
- transparent desktop overlay/log privacy notes;
- artifact hygiene rules for future source intake.

## Family 243: VR180 spatial-video conversion, metadata, camera, and playback utilities

This family covers VR180 and stereo-media projects where the reusable value is
not one player, but a pipeline across capture, conversion, metadata, export,
and playback fallback.

| Project | Status | Notes |
|---|---|---|
| `34j/vr180-convert` | Studied in Wave 264 | OpenCV/Typer remap CLI with stereo pair auto-matching and feature-based rotation calibration |
| `silverqsy/VR180-Silver-Bullet` | Studied in Wave 264 | Professional GoPro Max 2 processing pipeline with gyro/stabilization/GPU/export stages |
| `nallic/convert_VR180` | Studied in Wave 264 | Canon dual-fisheye conversion using precomputed ST maps and batch processing |
| `aosoft/VR180MeshProjection` | Studied in Wave 264 | Unity MP4 Mesh Projection Box parser and mesh reconstruction reference |
| `Vargol/VR180PhotoTools` | Studied in Wave 264 | VR180 photo EXIF/XMP/right-eye payload conversion utilities |
| `ganeshv/egarim` | Studied in Wave 264 | Lenovo Mirage VR180 camera companion with pairing, encrypted transport, capture, and viewfinder controls |
| `Verdi/VR180-Web-Player` | Studied in Wave 264 | Browser VR180 player with WebXR mode and non-XR draggable fallback |
| `steren/stereo-img` | Studied in Wave 264 | Declarative stereo-image custom element with parser registry and embedded right-eye/XMP handling |
| `kasper93/mpv360` | Studied in Wave 264 | mpv Lua and GLSL projection control with OSD, key bindings, and SBS eye output |

### Consolidation note

This family matters because spatial-video utilities should name:

- source media and capture device;
- camera/lens profile or calibration source;
- remap/projection transform;
- metadata parser or writer;
- stabilization, timing, and export stage;
- playback shell and fallback mode;
- format limits and operator-visible diagnostics.

It suggests a stronger branch inside `VR-apps-lab` around:

- VR180/spatial-video pipeline matrices;
- projection metadata validators;
- browser/web-component spatial media viewers;
- local player shader-control references;
- camera companion and calibration profile boundaries.

## Family 244: VRChat creator/user helper utilities and developer companions

This family covers small VRChat helpers that cross editor workflows, service
auth, Udon byte utilities, Quest/ADB developer actions, social monitoring, and
local OSC avatar control.

| Project | Status | Notes |
|---|---|---|
| `crestudio/VRSuya-Utility` | Studied in Wave 265 | Creator editor workbench with texture/material replacement, PhysBone batch actions, avatar helpers, and Undo usage |
| `te260ku/VRMenuUtility` | Source-light in Wave 265 | Unity skeleton with no meaningful implementation found in the inspected branch |
| `AkitaIkeda/VRCFileUtility` | Studied in Wave 265 | Spectre.Console VRChat service CLI with login/TFA/token persistence and file feature routing |
| `thymespace/VRCPacketUtility` | Studied in Wave 265 | UdonSharp sequential byte-packet helper with cursor and bounds/type caveats |
| `korinVR/VRDeveloperUtility` | Studied in Wave 265 | Windows Quest developer companion with ADB discovery, device status, screenshots, and runtime/service actions |
| `namoshika/VRChatUtility_FriendListMonitor` | Studied in Wave 265 | AWS/Notion friend-list and desktop-log monitor with API polling and privacy caveats |
| `kikookraft/vrc-utility` | Source-light in Wave 265 | Diagram/logo-only repository with no source donor value found |
| `falnen/Python-VRC-utility` | Studied with caveats in Wave 265 | Python OSC avatar controller with avatar-log matching and per-avatar controller lifecycle |

### Consolidation note

This family matters because VRChat helper utilities should name:

- surface type: editor, service CLI, Udon runtime, device helper, monitor, or OSC controller;
- credential, device, or privacy gate;
- input data source and action target;
- Undo, rollback, cooldown, or safe-release behavior;
- packaging state and artifact hygiene;
- donor/reference/source-light classification.

It suggests a stronger branch inside `VR-apps-lab` around:

- VRChat helper risk matrices;
- Quest/VRChat developer companion surfaces;
- avatar editor batch-repair workbenches;
- Udon byte-packet review checklists;
- social/session monitor privacy patterns.

## Family 245: Engine and browser XR utility primitives

This family covers low-level primitives that are not full products: tracked
device wrappers, input selectors, locomotion/body models, projection materials,
and browser component diagnostics.

| Project | Status | Notes |
|---|---|---|
| `Silverlan/PragmaVR` | Studied in Wave 266 | Pragma OpenVR addon with tracked-device entities, render model fallback, haptics, laser primitives, and video texture wrapper |
| `TheUtDuong/unity-vr-utilities` | Source-light in Wave 266 | Unity settings skeleton with little implementation evidence |
| `loganator956/unity-vr-utilities` | Studied in Wave 266 | Tiny Unity XR loader-specific controller prefab switch |
| `nukadelic/UXRU` | Studied in Wave 266 | Legacy Unity XR tracker/input, locomotion, body collider, and transform smoothing helpers |
| `Ponsukeee/VRInputModule` | Studied in Wave 266 | Unity input module framework with device/module/selector interfaces, laser selector, and collision selector |
| `Sunflower-Reality-Labs/aframe-srl-utils` | Studied in Wave 266 | A-Frame locomotion, two-hand grab, controller event HUD, and projection material components |
| `acerwebvr/Acer-VR-Utility-for-Browser-WebVR-Release` | Source-light in Wave 266 | Historical browser WebVR release/install reference for Acer/WMR |

### Consolidation note

This family matters because XR primitive packages should name:

- runtime or framework adapter;
- device and feature map;
- input event and selector contract;
- target module or component lifecycle;
- visible debug state;
- locomotion/body/collider assumptions;
- projection or texture helper boundary;
- deprecated API or framework caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- selector pipeline references;
- framework-neutral XR input abstractions;
- browser component diagnostics;
- locomotion/body model comparison;
- legacy-to-modern XR API migration notes.

## Family 246: Source-light OpenVR/SteamVR overlay and HUD variants

This family covers overlay-related projects whose main value is intake
classification: README-only intent, vendor-heavy Unity shells, minimal native
OpenVR loops, or narrow Quest MR image-panel references.

| Project | Status | Notes |
|---|---|---|
| `bwmcadams/vorpal` | Source-light in Wave 267 | README-only Elite Dangerous overlay proof-of-concept intent |
| `UpsilonScorpi/VRP-Overlay` | Source-light in Wave 267 | README-only overlay placeholder |
| `LapisGit/OVRTweaks` | Partially studied in Wave 267 | Unity/SteamVR overlay/tweak shell dominated by vendor/sample payload in the inspected branch |
| `JasonPKnoll/vr_overlay` | Studied in Wave 267 | Minimal native C/OpenVR overlay texture loop with controller-relative placement |
| `pouya-codes/VR_overlay` | Studied with caveats in Wave 267 | Quest MR image plus heatmap overlay demo with opacity, gesture/controller toggles, and passthrough setup |

### Consolidation note

This family matters because overlay search results should be triaged by:

- source evidence level;
- native overlay API versus Unity/Quest MR panel;
- texture submission path;
- placement/input model;
- vendor payload and checked-in binary hygiene;
- product intent versus implementation donor value;
- source-light caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- minimal OpenVR overlay baselines;
- source-light overlay intake checklists;
- game-HUD demand references;
- MR annotation panel UX;
- vendor-heavy Unity overlay caveat rules.

## Family 247: VR measurement, calibration, and body-distance utility surfaces

This family covers small measurement helpers that turn headset, browser, phone,
or engine state into user-facing calibration values. The useful lesson is not a
single perfect measurement algorithm, but the boundary between visual prompts,
captured points, body metrics, persistence, and caveats.

| Project | Status | Notes |
|---|---|---|
| `leetarry/VR_Measure` | Source-light in Wave 268 | Empty measurement-intent repository with no donor evidence in the inspected branch |
| `rlaboiss/ipd-vr-measure` | Studied in Wave 268 | Pygame visual IPD helper with converging/diverging targets, key-captured extrema, pixel-to-mm transform, and hardcoded display geometry |
| `AyOhEe/Godot-VR-Measurements` | Studied in Wave 268 | Godot XR measurement autoload with persisted config, measurement-change signal, body-value estimation, and camera-rig tracked-offset correction |
| `NeosoftMadhuri/webxr-measure` | Source-light in Wave 268 | Empty WebXR measurement-intent repository with no donor evidence in the inspected branch |
| `maverickjimmx/webxr-measure` | Studied with caveats in Wave 268 | Browser/mobile inspection form with device-orientation coaching, camera view, point/vertical fields, canvas sketch/signature capture, and Apps Script submit |
| `Vedant22-marda/webxr-measurement-app` | Studied with caveats in Wave 268 | Camera/WebRTC measurement demo with tap-to-measure overlay, rough pixel-distance scaling, SocketIO signaling, STUN, and unauthenticated default-room caveats |

### Consolidation note

This family matters because calibration helpers should name:

- measurement primitive and confidence;
- visual prompt or body-state source;
- user correction and persistence path;
- unit conversion assumptions;
- privacy and camera/network caveats;
- remote-assist or collaboration boundary;
- source-light versus donor-ready evidence.

It suggests a stronger branch inside `VR-apps-lab` around:

- IPD/body metric helper comparisons;
- Godot XR measurement-state services;
- phone/browser measurement companion UX;
- remote-assist measurement privacy gates;
- calibration confidence and fallback rules.

## Family 248: OpenXR action, hotkey, OSC, and command bridges

This family covers projects that translate XR actions or desktop hotkeys into
commands, keyboard events, OSC pulses, generated bindings, or diagnostic action
state. The central lesson is to keep input capture, gesture interpretation,
target action, and safety policy separate.

| Project | Status | Notes |
|---|---|---|
| `art0007i/openxr-command-runner` | Studied in Wave 269 | OpenXR input-to-command bridge with EXTX overlay session, JSON5 command/action config, suggested bindings, bool/float handling, and gesture detection |
| `swirllyman/SimpleOpenXRInput` | Studied in Wave 269 | Unity OpenXR input facade with generated InputActionMap, static controller events, haptic helper assignment, and static-lifecycle caveats |
| `gameflorist/uevr-touch-buttons-mapping-plugin` | Studied in Wave 269 | UEVR/OpenXR touch-to-keyboard plugin that maps unused touch inputs to SendInput key presses with per-key state and haptic feedback |
| `germansmedia/openxr-actions-test` | Partially studied in Wave 269 | Raw Rust FFI OpenXR action/session harness with proc loading, diagnostics, and checked-in target/debug artifact caveats |
| `danwillm/openxr-actions-tester` | Studied in Wave 269 | JSON-driven OpenXR action tester with headless extension setup, action sets, suggested bindings, bool/pose polling, and Vive tracker examples |
| `brycehutchings/OpenXR-Action-Code-Generator` | Studied in Wave 269 | OpenXR action code generator for action manifests, helper structs, action states, subactions, action spaces, and suggested bindings |
| `tmddn0230/monado-input-system` | Variant/reference in Wave 269 | Monado-scale fork useful for runtime input/device boundary evidence, but not a direct donor until unique diff is isolated |
| `Somahc/VRCVoiceHotkey` | Studied with caveats in Wave 269 | Windows tray hotkey bridge mapping Ctrl+M to a VRChat OSC voice pulse with hardcoded hotkey/port and mojibake caveats |

### Consolidation note

This family matters because command bridges should name:

- input source and runtime binding;
- action schema or generated binding artifact;
- gesture recognizer and debounce state;
- command target and side effect class;
- haptic or visible feedback;
- safety confirmation, cooldown, and allowlist;
- diagnostics and portability caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR action-to-command bridge prototypes;
- safe keyboard/OSC action routers;
- generated OpenXR action binding helpers;
- input diagnostics without a full app shell;
- UEVR/Unity/OpenXR command-surface comparisons.

## Family 249: VRChat resource, asset, and package discovery surfaces

This family covers public-facing catalog and package-listing projects for
VRChat creators. The reusable lesson is how discovery surfaces combine
metadata normalization, preview UX, graph relationships, package manifests,
deep links, provenance, and editor-side cleanup helpers.

| Project | Status | Notes |
|---|---|---|
| `vanquish3r/vrchat-asset-browser` | Studied in Wave 270 | Static free asset database with JSON normalization, category filters, search, sort, linkified notes, preview links, and theme persistence |
| `marklibert404-eng/Obelisk` | Rejected/non-fit in Wave 270 | Browser VPN/proxy extension with remote-content injection behavior and no VRChat asset/tooling donor value |
| `Fraxul/VRChatResources` | Studied in Wave 270 | VRChat creator/editor microtools for scene visibility filters, collision proxy visualization, GPU instancing checks, prefab static flags, triggers, and occlusion volumes |
| `dark-swordsman/VRCRW` | Studied in Wave 270 | Next/Prisma/Mongo resource cards plus Pixi draggable graph view and experimental relationship UX |
| `tiry/nuxeo-vr-assets-browser` | Studied in Wave 270 | A-Frame/WebVR DAM browser backed by Nuxeo auth, thumbnails/renditions, asset grid, paging, and zoom panel |
| `ElMoha943/valenvrc_package_listing` | Studied in Wave 270 | VPM package listing with source.json release arrays, package-list-action workflow, production deploy branch, and CNAME support |
| `Purpzie/vpm` | Studied in Wave 270 | Generated VPM listing page with search, copyable URLs, vcc://vpm/addRepo links, package modal, dependencies, and license display |
| `Limitex/vrchat-package-template` | Studied with caveats in Wave 270 | VPM package template with package metadata, VPM dependencies, Editor/Runtime asmdefs, Samples/Tests/Documentation, and skeletal placeholder docs |

### Consolidation note

This family matters because creator discovery surfaces should name:

- canonical metadata schema;
- package index and release artifact;
- preview/provenance/license fields;
- filter, sort, graph, or VR-native browsing mode;
- deep-link and copy/share path;
- editor-side validation or cleanup helper;
- stale, unsafe, or non-fit source caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- VRChat package-listing UX patterns;
- asset catalog provenance and preview rules;
- graph-based resource discovery;
- VR-native asset browser experiments;
- editor helper surfaces that pair discovery with cleanup.

## Family 250: VR whiteboard, annotation, and note-taking surfaces

This family covers drawing and annotation tools for VR rooms, WebVR/WebXR
spaces, Unity/Oculus scenes, remote observers, and point-cloud/video datasets.
The reusable lesson is how interaction rays become strokes, texture pixels,
landmarks, shared events, or timeline annotations.

| Project | Status | Notes |
|---|---|---|
| `jorisvddonk/drawplane` | Studied in Wave 271 | A-Frame collaborative blackboard with controller crayon raycasts, meshline stroke accumulation, PeerJS host/client sharing, and hash rooms |
| `liuchen1701/VR-Whiteboard` | Studied with caveats in Wave 271 | Unity Daydream whiteboard prototype with controller raycast to named board and instantiated painter marks |
| `arcwhite/vr-whiteboard` | Studied in Wave 271 | Three.js/WebVR dynamic texture whiteboard with Vive controllers, barycentric hit-to-UV conversion, canvas drawing, and WebVR-era caveats |
| `yankanp/web-vr-annotation` | Studied in Wave 271 | WebSocket/WebRTC remote annotation bridge with VR/annotation roles, signaling relay, normalized clicks, Babylon picking rays, arrows, and floating text |
| `MichaeliusAChapelo/VR-Annotation-Scripts` | Studied with license caveat in Wave 271 | Unity/Oculus annotation scripts with raycast dots, dominant-hand mapping, transform controls, CSV import/export, and explicit no-permission license |
| `rafaelkuffner/VR-Annotator` | Studied with caveats in Wave 271 | Unity point-cloud/video annotation tool with modes, manager state, frame ingestion, skeleton playback, config parsing, and artifact payload caveats |
| `Danda420/vr-whiteboard` | Studied with artifact caveat in Wave 271 | Unity texture whiteboard with board-owned Texture2D, pen textureCoord raycasts, pixel interpolation, and heavy checked-in Unity artifacts |

### Consolidation note

This family matters because annotation tools should name:

- target surface type;
- ray, hand, pointer, or remote input source;
- coordinate conversion boundary;
- stroke, pixel, landmark, text, or timeline data model;
- collaboration and late-join state;
- persistence/export format;
- license and artifact hygiene caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- collaborative WebXR whiteboard baselines;
- dynamic texture drawing helpers;
- remote expert annotation bridges;
- point-cloud/video annotation tools;
- note-taking and surface persistence checklists.

## Family 251: VR file, local asset, and VRM browser surfaces

This family covers projects that expose local files, creator assets, folders,
or VRM models inside a VR or creator-facing workflow. The reusable lesson is
how file discovery, metadata, preview/import, and destructive operations are
separated from the in-headset selection surface.

| Project | Status | Notes |
|---|---|---|
| `NaruAkitsuki/VrmFileManager` | Studied with caveats in Wave 272 | Unity runtime VRM import helper with async VRMImporterContext load, parent assignment, collider/rigidbody/animator setup, and hardcoded resource caveats |
| `AkiMoriDev/VRC-Files-Manager` | Studied with caveats in Wave 272 | Rust/egui local asset catalog with root picker, SQLite tags/categories, filesystem category sync, search, and item folder packaging |
| `SirSerl/VRFileManager` | Studied with artifact and safety caveats in Wave 272 | Unity/SteamVR spatial file manager with cabinet shelves, file-type prefabs, search/sort, preview, copy, move, and trash operations |
| `agoetschm/vr_file_browser` | Studied with caveats in Wave 272 | Unity/GoogleVR folder tree that expands filesystem entries into world objects and destroys unfocused branches |
| `Vode1969/vr-file-browser` | Studied with caveats in Wave 272 | Compact Unity VR file picker with drive roots, hidden/system filtering, extension filters, scroll rows, and collider selection |
| `hunterdquant/Seeker` | Source-light in Wave 272 | README-only Unity VR local-file browser intent for loading non-project local files |

### Consolidation note

This family matters because file and asset browsers should name:

- root/source selection and permission assumptions;
- file/folder classification and filter rules;
- preview, import, or action target;
- metadata schema for tags, categories, and packages;
- destructive operation safety for copy, move, and delete;
- platform-specific path and storage caveats;
- source-light or artifact-heavy evidence status.

It suggests a stronger branch inside `VR-apps-lab` around:

- VRM/local asset import helpers;
- in-headset file pickers with explicit safety rails;
- creator asset catalogs with tag/category sync;
- spatial shelf and physical-object file UX;
- file-browser permission and destructive-action checklists.

## Family 252: VR performance tuning, FSR, and FPS helper surfaces

This family covers tools that tune rendering or frame-rate behavior around
OpenVR, VRPerfKit, FSR, mod DLLs, and engine starter baselines. The reusable
lesson is how target discovery, config schemas, backup/restore, and compatibility
warnings must be separated from the tuning action itself.

| Project | Status | Notes |
|---|---|---|
| `tappi287/openvr_fsr_app` | Studied with caveats in Wave 273 | GUI manager with Steam library scanning, selected DLL paths, original DLL backup/restore, mod source selection, config schema UI, and settings reset |
| `LavaGang/ML_OpenVR_FSR` | Studied with caveats in Wave 273 | MelonLoader wrapper that extracts bundled OpenVR FSR resources into UserData and NativeLibrary.Loads them before OpenVR starts |
| `komori/vrperfkit-ocq2` | Reference-only in Wave 273 | Binary/config VRPerfKit quality-tuning variant without source donor evidence in the inspected branch |
| `GodotVR/godot_openvr_fps` | Studied with caveats in Wave 273 | Godot/OpenVR FPS baseline with OpenVR init, 90Hz assumptions, movement vignette, viewport-to-material UI, teleport/grab/throw, and legacy caveats |

### Consolidation note

This family matters because performance helpers should name:

- target discovery and ownership;
- file/config mutation boundaries;
- backup, restore, reset, and version state;
- settings schema, ranges, and compatibility notes;
- loader replacement versus runtime extraction strategy;
- FPS/comfort baseline and user-facing feedback;
- binary-only or source-light risk level.

It suggests a stronger branch inside `VR-apps-lab` around:

- safe VR performance manager checklists;
- config-schema-driven tuning UIs;
- DLL replacement rollback rules;
- engine FPS comfort starter baselines;
- compatibility evidence and warning surfaces.

## Family 253: Playspace, chaperone, boundary, and safety-awareness utilities

This family covers tools that read, visualize, or intervene around playspace
boundaries, chaperone data, game-local player positions, guardian grids,
passthrough windows, and study logging. The reusable lesson is how safety
surfaces should keep boundary source, trigger, intervention, and evidence logs
separate.

| Project | Status | Notes |
|---|---|---|
| `GiantSox/ChaperoneFail` | Failure/caution reference in Wave 274 | Minimal OpenVR chaperone polling example with unsafe null HmdQuad_t use and no robust error handling |
| `Graicc/Echo-Vr-Playspace-Abuse-Detector` | Studied with caveats in Wave 274 | Unity Echo VR local-API monitor with team/player DTOs, settings JSON, follower playspace capsules, bounds containment, and offender list |
| `benpaddlejones/VR-Playspace` | Partially studied with artifact caveat in Wave 274 | Unity/MRTK playspace payload with checked-in chaperone_info.vrchap, WMR/MRTK assets, and limited original custom scripts |
| `TXST-CS7389I-Spring-2026-Group-Project/DreamGuard` | Studied with caveats in Wave 274 | Quest MR safety study with passthrough window, grid/fragment/intervention styles, Godot XR alpha blending, Unity room experiment flow, and CSV logging |

### Consolidation note

This family matters because safety utilities should name:

- boundary source and coordinate frame;
- safe-region model and confidence;
- tracked object or player state source;
- trigger and intervention style;
- passthrough, grid, fog, or depth technique;
- logging and study evidence;
- artifact-heavy and vendor-specific caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- chaperone/boundary diagnostic checklists;
- game-local safe-region monitors;
- Quest MR passthrough-window safety references;
- safety intervention comparison matrices;
- logging schemas for XR safety experiments.

## Family 254: VR launchers, startup orchestration, and app-library surfaces

This family covers launchers that open hidden Quest system screens, SteamVR or
WMR apps, game libraries, external processes, profile stacks, and background
agents. The reusable lesson is how app identity, config/profile state, launch
channel, process lifecycle, and rollback are modeled before any command is
executed.

| Project | Status | Notes |
|---|---|---|
| `ptrpaws/vrLauncher` | Studied as variant in Wave 275 | Kotlin Quest hidden-system launcher with hardcoded versioned systemux URI catalogs, GitHub release update check, searchable spinner UI, and vrshell activity launch |
| `conexto/vrLauncher` | Variant/fork-line in Wave 275 | Same Quest systemux hidden-surface launcher pattern as `ptrpaws/vrLauncher` |
| `blakeblair/uvrl` | Studied in Wave 275 | Universal VR Launcher CLI with SQLite app/config/profile schema, discovery catalog, backup/apply, profile validation, dry-run mode, and multi-channel launch steps |
| `marianhlavac/immersion-vr-agent` | Studied with caveats in Wave 275 | WPF OpenVR background agent that polls scene app and quit events, launches tutorial/launcher processes, and tracks status |
| `dewaffled/vr-launcher` | Studied with safety caveats in Wave 275 | Self-elevating PowerShell micro-utility that enables or disables Windows Mixed Reality Holographic PnP devices |
| `Paladinleeds/PaladinVR-Launcher` | Studied with caveats in Wave 275 | Archived UWP Cliff House tile that launches SteamVR via steam://rungameid/250820 and exits |
| `keithbphillips/vr-pinball-launcher` | Studied with caveats in Wave 275 | Unity VR app-library carousel with JSON config, table scanner, world-space menu, external process handoff, XR stop/restart, and return-to-menu lifecycle |
| `CactusVRStudios/Lambda1VR_Launcher` | Studied with artifact caveat in Wave 275 | Quest Unity launcher that detects /sdcard/xash folders, writes commandline.txt, launches com.drbeef.lambda1vr, and falls back to SideQuest |
| `Bluscream/VRChatLauncher` | Studied with deprecation caveats in Wave 275 | Historical VRChat launcher with argument parsing, URI protocol handling, registry setup, IPC singleton handoff, mod checks, and process side effects |

### Consolidation note

This family matters because launchers should name:

- launch channel and side effects;
- app/config metadata and discovery source;
- profile step ordering and validation;
- backup, rollback, and dry-run behavior;
- process/runtime lifecycle and return path;
- hidden intent, registry, or device-toggle risk;
- deprecation, fork, and artifact caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- VR app-library launcher UX;
- profile-driven startup orchestration;
- Quest hidden-intent catalog guardrails;
- external-process handoff and return-to-menu lifecycle;
- launcher safety policy and rollback checklists.

## Family 255: WebXR museum, guided-tour, and artifact-gallery surfaces

This family covers museum, gallery, guided-tour, and artifact-viewing projects
that turn content metadata into spatial exhibits, media frames, AR/WebXR
viewers, annotations, and creator preview shells. The reusable lesson is to
separate durable exhibit data from engine-specific viewer adapters.

| Project | Status | Notes |
|---|---|---|
| `artificialmuseum/sandbox` | Studied with remote-engine caveat in Wave 276 | Artifact manifest, custom scene lifecycle hooks, injected engine boundary, skybox/model paths, and preview-shell behavior |
| `torashad99/xr-photo-museum` | Studied in Wave 276 | Multiplayer WebXR photo museum with frame slots, parallax portals, generated-world polling, annotations, voice notes, strokes, and room state |
| `TashaGandevia/GamingMuseum_WebXR` | Studied with engine caveats in Wave 276 | Wonderland museum with console metadata, CanvasUI panels, cursor events, haptics, spatial sounds, and generated dependency caveats |
| `rohanbk10/Museum` | Studied in Wave 276 | Schema-first museum SPA with annotations, desktop 3D viewer, MindAR image targets, WebXR anchors, router lifecycle, and cleanup discipline |
| `Shree-svg/Neural_Nexus-Virtual_3D_Museum` | Source-light reference in Wave 276 | Minimal atmospheric museum shell, useful mainly for product framing |
| `UMN-VR/UMN-VR-Quest-2-App` | Artifact-heavy reference in Wave 276 | Photogrammetry museum proof-of-concept with APK/cache payload and repository-hygiene caveats |

### Consolidation note

This family matters because spatial content browsers should name:

- content schema and asset provenance;
- artifact or exhibit manifest;
- frame, portal, or viewer slot lifecycle;
- annotation, voice, drawing, or collaboration model;
- desktop, AR, WebXR, and Quest fallback paths;
- cleanup and disposal rules;
- generated-asset and repository-hygiene caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable museum/gallery content schemas;
- WebXR media-room and portal-surface experiments;
- artifact preview sandboxes for creator workflows;
- AR/WebXR viewer adapter comparisons;
- documentation rules for artifact-heavy Unity/Quest archives.

## Family 256: VR rehabilitation, therapy, and treatment-loop prototypes

This family covers rehab, therapy, neurofeedback, and sensor-training projects
that combine assessment, input confidence, task generation, feedback, and logs.
The reusable lesson is to extract engineering loops while keeping medical,
privacy, and validation claims explicit.

| Project | Status | Notes |
|---|---|---|
| `mahmoud1yaser/VR-Therapist-Virtual-Mental-Health-Experience` | Studied with medical/privacy caveats in Wave 277 | Unity mic capture to Flask STT/LLM/TTS loop with avatar playback and unsafe clinical/auth caveats |
| `jessieyang0320/VHab` | Partially studied in Wave 277 | Legacy web hand-rehab microgames around finger angle, pinch, grab, selectors, buttons, and whack-a-mole tasks |
| `reboot-corp/Reboot-Hackathon` | Studied with prototype caveats in Wave 277 | LSL/BrainFlow EEG ingress, Unity concentration feedback ring, local serialization, and validation caveats |
| `EyalMaoz/Pinch_Rehabilitation_VR_Personalized_Treatment` | Studied in Wave 277 | OVR pinch classification, calibration, patient range persistence, treatment plans, adaptive difficulty, and task generation |
| `TheBananaGuy/rehab-in-vr` | Studied with source-light caveats in Wave 277 | Leap/Oculus sustained grab-and-hold target loop |
| `pcallej/ADHD-Unity` | Studied with legacy caveats in Wave 277 | GoogleVR attention-training path/target games and vendor payload caveats |
| `WestonBDev/Modules-for-Burn-Injury-Rehabilitation` | Studied in Wave 277 | Timed trigger boxes, XR haptic configuration, accessibility module framing, and CSV motion logging |
| `songer1993/vr-cat-bath-study` | Studied in Wave 277 | Gamified cat-care rehab tasks with grasp/pinch strength indicators, timers, and capture hooks |
| `harr-data/Simple-VR-Rehab` | Source-light reference in Wave 277 | Browser task/metric suite around tracking, reflex, memory, stability, latency, and deviation |

### Consolidation note

This family matters because rehab utilities should name:

- assessment and calibration flow;
- input device, confidence, and sensor quality;
- personalized range and difficulty;
- task generator and scoring;
- visual, audio, haptic, or avatar feedback;
- session logs and therapist/operator views;
- consent, privacy, validation, and medical-claim boundaries.

It suggests a stronger branch inside `VR-apps-lab` around:

- calibration-first VR exercise loops;
- reusable hand/pinch/grasp task kits;
- biometric ingress to feedback surfaces;
- therapist-facing session logs;
- safety language for medical-adjacent VR tools.

## Family 257: Camera-to-VRM/avatar retargeting and virtual-camera output

This family covers projects that turn camera frames into avatar pose, hand,
face, gaze, blendshape, and virtual-camera output. The reusable lesson is to
keep capture, inference, retargeting, avatar output, and publishing as separate
boundaries.

| Project | Status | Notes |
|---|---|---|
| `Kariaro/VRigUnity` | Studied with side-effect caveats in Wave 278 | Camera/avatar output utility with capture settings, mirrored output, annotation modules, EVMC/VMC periphery, thread helper, and Windows virtual-camera scripts |
| `creativeIKEP/HolisticMotionCapture` | Studied in Wave 278 | Camera-to-VRM pipeline with holistic processing, score gates, smoothing filters, pose/hand/face renderers, blendshapes, gaze, upper-body mode, and reset |
| `zacharyguan/VRigUnity` | Variant-only in Wave 278 | Fork/lineage node of `Kariaro/VRigUnity`, not promoted without unique donor evidence |

### Consolidation note

This family matters because avatar retargeting utilities should name:

- camera frame source and privacy policy;
- inference model and score thresholds;
- smoothing/filter strategy;
- body, hand, face, and gaze maps;
- avatar-specific output layer;
- virtual-camera or video publishing adapter;
- reset, calibration, and platform side effects.

It suggests a stronger branch inside `VR-apps-lab` around:

- camera-to-avatar retargeting matrices;
- MediaPipe-to-VRM pipeline references;
- virtual-camera output safety rules;
- VMC/camera-inference bridge comparisons;
- fork-lineage/dedupe handling for avatar tools.

## Family 258: Remote, cloud, WebRTC VR streaming, and live SDK surfaces

This family covers local and cloud streaming projects that connect input uplink,
camera/video output, WebRTC or custom transport, signaling, session control,
and viewer surfaces. The reusable lesson is to treat transport, capture,
signaling, backend allocation, and privacy gates as separate components.

| Project | Status | Notes |
|---|---|---|
| `PierfrancescoSoffritti/RemoteVR_UnityServer` | Studied with legacy caveats in Wave 279 | Unity TCP/UDP server with gyro/touch input, resolution negotiation, and rendered-image downlink |
| `PierfrancescoSoffritti/RemoteVR_AndroidClient` | Studied with legacy caveats in Wave 279 | Android calibrated gyroscope client with UDP session init, image receive loop, and touch/gyro packets |
| `TheAnonymousMan/WebRTC-VR-Server` | Studied in Wave 279 | Unity-hosted WebRTC/WebSocket signaling server with camera track, ICE buffering, answer creation, and data channel |
| `GitEducaverse2024/com.educa360.live` | Studied in Wave 279 | Unity live-streaming SDK with config asset, backend abstraction, setup wizard, Quest capture workaround, FPS monitor, and kill-switch settings |
| `shinyoshiaki/quest-view` | Studied with caveats in Wave 279 | Quest WebRTC video receiver with WebSocket signaling, I420 frame queue, YUV-to-texture conversion, and brittle signaling caveats |
| `jlin3/substream-sdk` | Studied with scope caveats in Wave 279 | Cloud streaming SDK/control plane with auth, IVS stage allocation, WHIP provisioning, webhooks, recording/highlights, and Unity script families |
| `kasimmj/vrcollab` | Source-light architecture reference in Wave 279 | Pose-frame, SFU, spatial-audio, and asset-service product sketch with thin inspected source |
| `jakubtom/UnityRenderStreaming_StereoWebcam` | README-only reference in Wave 279 | Stereo webcam through Unity Render Streaming concept |

### Consolidation note

This family matters because streaming utilities should name:

- capture source and output surface;
- input uplink and sensor packet model;
- signaling, pairing, and auth;
- WebRTC, WHIP, UDP/TCP, or cloud-stage transport;
- FPS, resolution, bitrate, and frame queue;
- backend lifecycle, recording, and webhooks;
- privacy, TLS, kill-switch, and cleanup.

It suggests a stronger branch inside `VR-apps-lab` around:

- Unity-hosted WebRTC camera streams;
- Quest receiver texture pipelines;
- streaming SDK setup-wizard patterns;
- cloud stage/session lifecycle references;
- privacy-first remote VR viewing checklists.

## Family 259: VR training, assessment, scenario grading, and skill-practice prototypes

This family covers training projects that convert immersive actions into task
state, scores, feedback, notes, and study metrics. The reusable lesson is to
separate scenario content from grading, persistence, and validation claims.

| Project | Status | Notes |
|---|---|---|
| `cepdnaclk/e16-4yp-Virtual-Patient-Simulator-for-Skill-Training-in-Dentistry` | Studied in Wave 280 | Multi-domain dental score reducer, feedback/evaluation flow, Firebase-backed case data, and medical/privacy caveats |
| `sharnajh/VR_CPR_Training` | Source-light in Wave 280 | Basic Unity movement/crouch shell with weak visible CPR assessment logic |
| `Carolina-Riddick/Parkinson-App-Virtual-Reality` | Studied with medical caveats in Wave 280 | Socket-count task gates, next-level unlocks, and force-launch interaction |
| `SLVNE/VRNurseTrainingProgram` | Studied with caveats in Wave 280 | Blood-pressure and lung-answer auto-graders with immediate verdict UI |
| `DarkSmiling/OpenVRTraining` | Asset-heavy reference in Wave 280 | Unreal/SteamVR training scene with VRExpansion/SteamVR bindings and limited readable custom code |
| `pspacewoman/Emergency-Quest-VR-Game-MasterThesis` | README/thesis reference with license caveat in Wave 280 | Checklist-guided first-aid scenario with hazards, NPC/audio, score, and feedback framing |
| `KosmidisMixalis/ViRtus-A-Virtual-Reality-Application-for-Training-and-Performance-Analysis` | Source-light methodology reference in Wave 280 | VR task metric export and Python statistical analysis scripts |
| `E5H4/m.e.-simulator` | Studied in Wave 280 | Score/timer/grade panels, difficulty branch, AED pad prerequisites, and hardcoded-scene caveats |
| `Hannah-Ashna/VRWalkin-UE-Plugin` | Blueprint-heavy reference in Wave 280 | UE locomotion-training plugin packaging multiple travel paradigms |
| `hasanhaswary/CSVRSystem` | Studied in Wave 280 | Firebase auth, case selection, and per-user Firestore notes for crime-scene training |
| `37743/VR-Welding-101` | Studied with caveats in Wave 280 | Configurable joint push-button toggle and welding skill-practice framing |
| `MPL-projects/vr-aim-study` | Studied in Wave 280 | Throwing accuracy scoring, target feedback, and ball reset loop |
| `glenbo111/webxr-medical-training-simulation` | Source-light in Wave 280 | One-file A-Frame medical scenario skeleton |
| `byebyenin10dog/KHXR` | Studied with artifact caveat in Wave 280 | WebXR-to-Unity browser bridge, session lifecycle, controller/gamepad packets, and telemetry caveats |
| `fxnode2000/webxr.github.io` | Skipped/no-source in Wave 280 | Empty inspected branch retained only as dedupe evidence |

### Consolidation note

This family matters because training utilities should name:

- scenario/case schema;
- task gates and prerequisites;
- action evidence and scoring dimensions;
- difficulty, timer, grade, and feedback policy;
- learner notes, auth, and privacy;
- metric export and study-analysis handoff;
- medical, license, and validation caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- training scenario score engines;
- checklist and procedure-feedback panels;
- authenticated case notebooks;
- study metric export templates;
- source-light training triage rules.

## Family 260: XR hand input, bare-hand manipulation, and hand-pose transport experiments

This family covers hand input projects that bridge runtime hand tracking into
gestures, object manipulation, avatar skeletons, network packets, and replay.
The reusable lesson is to keep raw tracking, derived gestures, manipulation,
avatar output, and transport as separate boundaries.

| Project | Status | Notes |
|---|---|---|
| `Mystfit/NectoXRTemplate` | Studied with dependency caveats in Wave 281 | Unreal OpenXR hand template with hand-tracked VR character setup, LiveLink skeleton output, and replicated-avatar boundaries |
| `Clyfr/BURG-v2` | Studied with sample caveats in Wave 281 | Unity XR Hands One Euro filter, pinch midpoint proxy, and poke gesture detector |
| `reubenlavin08/spindle-whorl-ar` | Studied in Wave 281 | Quest passthrough gallery with XR Hands pinch-grab hysteresis, tracking-loss release, hand visualization, floor-origin retry, procedural disc mesh, and cultural-data caveats |
| `Zer0pa/ZPE-XR` | Studied with runtime caveats in Wave 281 | Hand-pose codec with keyframe/delta packets, CRC validation, replay/recovery simulation, and benchmark caveats |

### Consolidation note

This family matters because hand-input utilities should name:

- runtime subsystem and tracking confidence;
- joint smoothing and tracking-loss behavior;
- pinch, poke, and gesture thresholds;
- object manipulation offset and release policy;
- avatar/LiveLink/retargeting adapter;
- packet/replay codec and evidence caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- XR Hands gesture primitive comparisons;
- passthrough bare-hand object manipulation;
- hand-pose transport/replay schemas;
- LiveLink/OpenXR/Leap boundary matrices.

## Family 261: Spatial audio, acoustic accessibility, and voice presence surfaces

This family covers audio-centered XR projects where sound acts as spatial
feedback, navigation, description, accessibility, or collaboration presence.
The reusable lesson is to separate audio asset preparation, runtime
spatialization, accessibility state, voice transport, and privacy gates.

| Project | Status | Notes |
|---|---|---|
| `nikita-s-nair/Spatial-Audio-VR` | Studied in Wave 282 | WebXR/Three.js positional audio starter with listener setup, speaker GLTF, distance model, XR audio resume, and iwer fallback |
| `rvedantv/Spatial-Audio-VR` | Source-light audio reference in Wave 282 | BRIR convolution preprocessing workflow for binaural spatial audio assets |
| `xavieraustralia/aioptimisationlabvirtual` | Studied with scope caveats in Wave 282 | WebRTC peer audio, WebSocket signaling, AnalyserNode VAD, speaking-state broadcasts, and microphone/privacy caveats |
| `lanzhang76/artEcho` | Studied in Wave 282 | Acoustic accessibility museum with onboarding, positional sounds, echo samples, object descriptions, hints, interruption recovery, and canvas accessibility attributes |
| `Devanik21/Hackathon-VR-180-Immersive-Experience` | Non-fit/source-light side node in Wave 282 | Streamlit 2D-to-VR180 depth-conversion sketch, not promoted as an audio donor |

### Consolidation note

This family matters because audio utilities should name:

- listener and positional source lifecycle;
- falloff, directionality, and room assumptions;
- offline BRIR or spatial asset preprocessing;
- onboarding, hints, object descriptions, and echo feedback;
- voice transport, VAD, and speaking indicators;
- microphone, accessibility, and privacy caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- acoustic accessibility checklists;
- WebXR positional audio starters;
- voice-presence companion surfaces;
- audio interruption/restoration state machines.

## Family 262: XR study recording, replay, analysis, and multimodal training data

This family covers projects that record, replay, analyze, or stream XR session
data. The reusable lesson is to keep capture channels, storage, replay state,
analysis queries, visualization, and privacy policy separate.

| Project | Status | Notes |
|---|---|---|
| `vrsys/Recording-And-Analysis-Plugin` | Studied in Wave 283 | Native recorder-ID plugin with transform/sound/generic channels, scene metadata, ring buffers, object-ID remapping, and analysis queries |
| `vrsys/Immersive-Study-Analyzer` | Studied in Wave 283 | Unity record/replay and analysis UI with recorder controller, transform recorder, annotations, radial menu/time controls, and Photon sync |
| `mvidaldp/wd_ride` | Studied with artifact/privacy caveats in Wave 283 | Tobii eye/head tracking, gaze/nose raycast hits, fixed LSL streams, protobuf IO, and replay visualization |
| `leonkoech/SignWhisper` | Studied with prototype caveats in Wave 283 | Leap VectorHand byte transport over Unity Netcode, avatar head/body sync, and partial ASL training minigame evidence |

### Consolidation note

This family matters because study/replay utilities should name:

- transform, sound, generic, biometric, and annotation channels;
- recorder IDs and file-version boundaries;
- scene graph metadata and object-ID remapping;
- replay buffers and time navigation;
- interval/quantitative analysis queries;
- export, replay visualization, privacy, and consent gates.

It suggests a stronger branch inside `VR-apps-lab` around:

- engine-agnostic XR recording adapters;
- in-VR study-analysis dashboards;
- LSL/Tobii/multimodal schema references;
- replay and annotation UI prototypes.

## Family 263: VRCFaceTracking face/eye tracking modules, templates, and receiver bridges

This family covers VRCFaceTracking modules and avatar-facing tools that turn
hardware or software face/eye input into unified expressions, avatar
parameters, receiver streams, and setup templates. The reusable lesson is to
separate source transport, schema normalization, smoothing, avatar preparation,
and diagnostics.

| Project | Status | Notes |
|---|---|---|
| `VRCFaceTracking/docs` | Studied in Wave 284 | Compatibility/setup taxonomy for hardware, addons, desktop/VR pages, and interface documentation |
| `guygodin/VirtualDesktop.VRCFaceTracking` | Studied in Wave 284 | Memory-mapped Virtual Desktop face state, wait handle update cadence, tracking-state detection, and unified expression mapping |
| `Adjerry91/VRCFaceTracking-Templates` | Studied with asset-heavy caveats in Wave 284 | VPM/avatar preparation templates for ARKit and Unified Expressions animation/parameter layout |
| `hazre/VRCFTReceiver` | Studied in Wave 284 | FT/v2 OSC path parsing, avatar parameter request, UDP listen loop, and lazy ValueStream creation |
| `regzo2/BinaryParameterTool` | Studied in Wave 284 | VRChat expression-cost guards, duplicate checks, generated parameters, and animator controller preparation |
| `200Tigersbloxed/VRCFTOmniceptModule` | Studied in Wave 284 | HP Omnicept Glia subscription, eye-only conversion, smoothing worker lifecycle, and vendor SDK caveats |
| `lonelyicer/VRCFTPicoModule` | Studied in Wave 284 | PICO dual UDP ports, legacy packets, disable flags, localization, updater helper, and partial support |
| `ghostiam/VRCFTTobiiAdvanced` | Studied in Wave 284 | Tobii/BrokenEye fallback, channel handoff, low-pass filtering, pupil/openness handling, and config defaults |
| `kusomaigo/VRCFaceTracking-LiveLink` | Studied in Wave 284 | Apple ARKit/LiveLink UDP ingress, configurable port, first-packet wait, and blendshape mapping |
| `xverse-engine/XVRFaceTracking` | Studied with prototype caveats in Wave 284 | ESP32/camera plus Python ONNX mouth tracking with PyQt tuning UI, One Euro smoothing, and OSC output |

### Consolidation note

This family matters because face/eye tracking utilities should name:

- hardware or software source;
- transport and packet/shared-memory contract;
- validity flags and partial support;
- smoothing and coordinate conversion;
- unified expression mapping;
- avatar parameter and template setup;
- receiver/diagnostic surface;
- privacy, licensing, port, and version caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- VRCFT module compatibility matrices;
- avatar-preparation wizards;
- face-tracking receiver/diagnostic panels;
- DIY camera-to-expression calibration references.

## Family 264: bHaptics wearable haptics routers, simulator bridges, and Android service boundaries

This family covers wearable haptics projects that route simulator, avatar,
input, game, or service events into bHaptics player patterns and direct motor
frames. The reusable lesson is to keep event capture, pattern selection,
transport, device status, and safety policy separate.

| Project | Status | Notes |
|---|---|---|
| `cercata/pysim2bhap` | Studied in Wave 285 | Simulator telemetry to `.tact` patterns with intensity/duration scaling, thresholds, and config presets |
| `HerpDerpinstine/bHapticsLib` | Studied in Wave 285 | C# WebSocket player client with register/submit queues, pattern cache, reconnect policy, device status, and stop APIs |
| `NovaVoidHowl/VRCBhapticsIntegration` | Studied with modding caveats in Wave 285 | VRChat avatar cameras/render textures parsed into bHaptics motor values plus Unity setup helpers |
| `Team-Beef-Studios/HapticsService` | Studied in Wave 285 | Android AIDL service boundary for haptic events, updates, stops, frame ticks, enable/disable, and client binding |
| `SeekND/YAWVR-and-BHaptics-addons` | Studied with script caveats in Wave 285 | Keyboard/mouse/joystick/simulator scripts using direct bHaptics dot submissions and user-tuned intensity |
| `bhaptics/TactUnrealEngine4` | Studied with blueprint-heavy caveats in Wave 285 | Unreal package reference for pairing UI, device visualization, Android UI panels, and feedback assets |

### Consolidation note

This family matters because wearable haptics utilities should name:

- event source and event schema;
- pattern catalog and direct frame fallback;
- intensity, duration, angle, and position scaling;
- transport queue and reconnect policy;
- device status and capability checks;
- service binding and app identity;
- enable/disable, cooldown, consent, and emergency stop.

It suggests a stronger branch inside `VR-apps-lab` around:

- physical-output safety checklists;
- bHaptics event-router prototypes;
- cockpit/simulator haptic companions;
- Quest/Android haptic service adapters.

## Family 265: Tilt Brush/Open Brush creative asset pipelines, AR/Web display, and tilt parsers

This family covers creative XR asset projects that preserve or display Tilt
Brush/Open Brush style sketches, strokes, brush metadata, exported geometry,
and public archive provenance. The reusable lesson is to separate authoring
capture, file parsing, export, preview, shader restoration, and license
metadata.

| Project | Status | Notes |
|---|---|---|
| `weeeBox/TiltBrushFile` | Studied in Wave 286 | `.tilt` parser/writer with binary header, zipped sketch payload, metadata, thumbnail, strokes, and control points |
| `MrMMu/tiltbrushfbxexport` | Studied with legacy caveats in Wave 286 | Tilt JSON-to-FBX exporter preserving brush grouping, vertex colors, normals, UVs, tangents, materials, and metadata |
| `FusedVR/ARKitTiltBrush` | Studied in Wave 286 | ARFrame camera-position painting, particle strokes, color/reset modes, and point-distance thresholding |
| `dogtownmedia/ARKit-SceneKit-Paint-Tiltbrush-Demo` | Studied in Wave 286 | SceneKit AR drawing with line nodes, color picker, world-tracking session, and interruption hooks |
| `thijsvb/TiltBrushDisplay` | Studied in Wave 286 | Tiny Processing OBJ/shader viewer for exported brush geometry with rotation and axis display |
| `arodic/polygone.art` | Archive/provenance reference in Wave 286 | Salvaged Google Poly assets, CC-BY framing, torrent/split downloads, and public preservation language |
| `keijiro/Forestica` | Studied with asset-heavy caveats in Wave 286 | Unity Tilt Brush render/material/postprocess reference for preserving brush-art look |
| `PushyPixels/WebVR-Poly-Framework` | Studied with package caveats in Wave 286 | Unity WebVR/Poly browser and presentation reference with dead-service replacement caveats |

### Consolidation note

This family matters because creative XR asset utilities should name:

- stroke and control-point schema;
- brush identity, color, size, and material;
- archive metadata and thumbnail sidecars;
- export format and geometry grouping;
- shader/material restoration requirements;
- preview/browser surface;
- author, license, provenance, and dead-service caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- `.tilt` inspection and conversion tools;
- VR-native asset browsers;
- provenance-first archive viewers;
- lightweight creative sketch previewers.

## Family 266: Gaussian splat XR Unity viewers, VR forks, and external render bus surfaces

This family covers Gaussian splat projects that import, render, browse,
generate, stream, or externally feed splat scenes into XR/Unity surfaces. The
reusable lesson is to keep file import, GPU resources, sorting/cutouts, VR
viewer UX, dynamic streaming, API generation, and external render transport as
separate boundaries.

| Project | Status | Notes |
|---|---|---|
| `wuyize25/gsplat-unity` | Studied in Wave 287 | `.ply`/`.spz` importer, source-coordinate conversion, cache keys, renderer registration, GPU resources, sorting, cutouts, and global draw |
| `dylanebert/UnityGaussianSplatting` | Studied in Wave 287 | Compact `.splat` ScriptedImporter and SplatData starter baseline |
| `HiFi-Human/DynGsplat-unity` | Studied in Wave 287 | Dynamic splat Addressables block streaming, frame assets, compute updates, codebooks, and cleanup |
| `Enndee/Splatviewer_VR` | Studied in Wave 287 | Runtime splat loading, OpenXR controls, file browser/favorites, movie mode, desktop fallback, and file associations |
| `ninjamode/Unity-VR-Gaussian-Splatting` | Studied with fork/sample caveats in Wave 287 | VR/URP splat project with package runtime/editor code, XR Interaction Toolkit samples, and scene scripts |
| `ptc-lexvandersluijs/Unity3DGS_VR` | Studied with fork/sample caveats in Wave 287 | BIRP/VR splat project with package layout, XR Interaction Toolkit samples, and input side nodes |
| `nigelhartman/worldlabs_unity` | Studied in Wave 287 | WorldLabs editor/API workflow, text/image/video prompts, `.spz`/`.ply` import, compression quality, scene placement, and env loader |
| `RockyXu66/splatbus` | Studied in Wave 287 | Python OpenGL client, Unity native plugin, CUDA IPC, socket/JSON handshake, color/depth sharing, camera-pose messages, and cleanup caveats |
| `roth-hex-lab/Multi-Layer-Anatomy-GS-Unity-Rendering` | Studied with specialization caveats in Wave 287 | Multi-layer anatomy Gaussian splat rendering reference |

### Consolidation note

This family matters because Gaussian splat XR utilities should name:

- import formats and source coordinate frames;
- compression/cache policy;
- asset and GPU resource lifecycle;
- sorting, cutout, and render-pipeline integration;
- runtime file loading and file permissions;
- VR locomotion, browser, favorites, and desktop fallback;
- dynamic frame/block streaming;
- API generation and secret handling;
- external color/depth render transport and cleanup.

It suggests a stronger branch inside `VR-apps-lab` around:

- splat import/rendering matrices;
- VR-native spatial asset viewers;
- generated-world import workbenches;
- external renderer to XR-surface experiments.

## Family 267: MRUK room-aware mixed reality scene data and panel placement utilities

This family covers MRUK and scene-data projects that treat the user's room as a
live utility substrate. The reusable lesson is to keep scene acquisition,
semantic anchors, environment raycasts, panel placement, export, and diagnostics
separate from the final app/game feature.

| Project | Status | Notes |
|---|---|---|
| `oculus-samples/Unity-MRUtilityKitSample` | Studied in Wave 288 | Environment raycasts, panel magnetism, world-lock, wall anchors, QR tracking, room mesh/navmesh, and virtual-home samples |
| `dilmerv/MixedRealityUtilityKitDemos` | Studied in Wave 288 | RoomCreatedEvent binding, current-room storage, wall-anchor prefab toggling, and logger feedback |
| `oculus-samples/Unreal-MRUtilityKitSample` | Studied with blueprint/content caveats in Wave 288 | Unreal MRUK scene-data sample with VR pawn/game-state C++ entry points and blueprint-heavy decorators/widgets |
| `VeksCZ/XRHouseDesignExport` | Studied with artifact-heavy caveats in Wave 288 | MRUK scene sync, semantic labels, JSON/report generation, OBJ/GLB export, per-room folders, and XR menu/logging |
| `Luizfelm/FlightFollower` | Studied in Wave 288 | XR controller line drawing and checkpoint spawning along sampled LineRenderer paths |

### Consolidation note

This family matters because room-aware MR utilities should name:

- permission and scene-load gates;
- room, anchor, semantic, and global-mesh data;
- environment raycast and placement solvers;
- world-lock and smoothing policy;
- panel/debug visualization;
- room export and report formats;
- storage, permission, and artifact hygiene caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- MRUK scene doctors;
- room-aware panel/overlay placement helpers;
- anchor inventory and surface inspectors;
- room export/report utilities.

## Family 268: WebXR spatial UI primitives, mesh text layout, and fullstack UI shells

This family covers browser-native spatial UI projects that create XR-safe UI
inside Three.js or A-Frame scenes. The reusable lesson is to keep UI
description, render backend, raycast input, widget state, update cadence, and
transport actions separate.

| Project | Status | Notes |
|---|---|---|
| `NikLever/CanvasUI` | Studied in Wave 289 | CanvasTexture panel mesh, widget config, controller raycasts, UV-to-pixel hit tests, hover/select/scroll, keyboard, sliders, and color picker |
| `felixmariotto/three-mesh-ui` | Studied in Wave 289 | Mesh-native Object3D blocks/text, MSDF fonts, nested layout, keyboard examples, and deferred UpdateManager lifecycle |
| `Retchut/aframe-mesh-ui-components` | Studied in Wave 289 | A-Frame declarative wrappers for three-mesh-ui blocks/text with schema mapping and recursive registration |
| `shiveshjadon/webxr-fullstack-boilerplate` | Studied with boilerplate caveats in Wave 289 | React/Three/WebXR shell with ThreeMeshUI, VRControl selection states, VRButton, Express, and Socket.IO button events |

### Consolidation note

This family matters because WebXR UI utilities should name:

- canvas texture versus mesh-native layout choice;
- font and texture asset requirements;
- raycast and UV hit-testing model;
- hover, select, scroll, keyboard, and slider state;
- update cadence and cleanup/dispose behavior;
- declarative wrappers for scene authors;
- optional server/socket command boundary.

It suggests a stronger branch inside `VR-apps-lab` around:

- WebXR settings/debug panels;
- spatial UI primitive comparison matrices;
- browser-native operator surfaces;
- socket-backed in-headset command panels.

## Family 269: VR assembly, maintenance, and procedure training workflows

This family covers assembly and maintenance projects that sequence physical
interaction, snap validation, procedure steps, persistence, scoring, and
instructor reporting. The reusable lesson is to keep manipulation, procedure
logic, save/load, scoring, and dashboards separate.

| Project | Status | Notes |
|---|---|---|
| `T0riU/VR-Assembly-Manager` | Studied in Wave 290 | Strong donor for parts, attach IDs, sockets, snap compatibility, forced release, visual affordances, JSON save/load, thumbnails, stats, and prefab registry |
| `carlosMoragon/VR-Assembly-Simulator` | Studied with vendor/asset caveats in Wave 290 | Score decay, error penalties, matching-tag placement, and temporary grab disabling |
| `NopparatSang/SCGVR2` | Studied with SDK-heavy caveats in Wave 290 | Maintenance process steps, tool validation, screw/bolt/locknut animations, object gates, timers, rankings, and OVR tool panels |
| `JonyHM/VRDoorAssembly` | Studied in Wave 290 | Angular companion scoreboard with score table and GET/POST score service |
| `lintglitch/vr-assembly` | Source-light in Wave 290 | Assembly environment/asset comparison node with limited custom logic visible |
| `nyu-lgcoop/VRTrainingUnity` | Source-light in Wave 290 | Legacy training shell dominated by Standard Assets in inspected source |
| `White-H-21/VR-assembly-system` | Skipped/no-source in Wave 290 | Empty/no-readable-content candidate in local study cache |

### Consolidation note

This family matters because procedure-training utilities should name:

- part and attach-point schema;
- socket compatibility and snap policy;
- hand-release and grab disable behavior;
- step/work-type controllers;
- tool validation and active object gates;
- score, timer, ranking, and feedback screens;
- persistence and companion/instructor dashboards.

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable snap/socket samples;
- procedure-authoring schemas;
- training score dashboards;
- assembly persistence and replay references.

## Family 270: Mixed reality robotics, ROS/Unity, URDF/CAD, and digital twin control surfaces

This family covers robotics and digital-twin projects that connect XR/MR
interfaces to robot assets, state, commands, calibration, and safety policy.
The reusable lesson is to keep asset import, digital-twin visualization, live
state, command transport, calibration, and physical safety separate.

| Project | Status | Notes |
|---|---|---|
| `2000222/Robotic-Arm-IK-in-Unity` | Studied in Wave 291 | Minimal gradient-descent IK baseline with per-joint axes, forward kinematics, and target distance gradients |
| `sabeaussan/ROS_Unity` | Studied in Wave 291 | ROS Float32MultiArray joint subscriber, Unity joint rotation, launch files, and reacher scripts |
| `KosmosisDire/UrdfUnityToolkit` | Studied in Wave 291 | Unity URDF/Xacro import, parse, clean menu actions, URDFBuilder entry point, and typed XML helpers |
| `bernhard-42/three-cad-viewer` | Studied in Wave 291 | Hierarchical CAD Shapes tree, transforms, visibility states, tessellated geometry arrays, and viewer options |
| `KKallas/manual-override` | Studied in Wave 291 | Server-authoritative robot control architecture, calibration/safety framing, SSE live-state helper, and Dobot TCP joint driver |
| `mortenterhart/mixed-reality-robot-control` | Studied in Wave 291 | MRTK/MQTT digital-twin command surface with shelf selection, animator state, and store-in/out messages |
| `MixedRealityETHZ/Mixed-Reality-Robotic-Grasp-Teacher` | Studied with prototype caveats in Wave 291 | MRTK pinch trajectory capture, trajectory spheres, position lists, and grasp-teaching shell |
| `giuliano-97/mixed_reality_robots` | Studied with vendor-heavy caveats in Wave 291 | ROS launch/URDF examples, cmd_vel publisher baseline, and Unity mixed-reality shell overlap |

### Consolidation note

This family matters because robotics/XR utilities should name:

- URDF/CAD import and coordinate conventions;
- digital-twin hierarchy and part visibility states;
- live joint/pose state transport;
- command queue and transport protocol;
- calibration between robot, camera, screen, and world frames;
- server-authoritative speed limits, stale gates, and E-stop;
- separation between visualization, simulation, and real hardware control.

It suggests a stronger branch inside `VR-apps-lab` around:

- MR robot-control safety shells;
- ROS/Unity digital twin inspectors;
- CAD/URDF asset pipeline helpers;
- hand/trajectory teaching and operator dashboards.

## Family 271: VR comfort tunnelling, cybersickness scoring, and comfort profile utilities

This family covers VR comfort projects that convert motion signals, user
preferences, and rendering interventions into reusable comfort systems. The
reusable lesson is to keep motion sensing, comfort scoring, intervention
policy, visual effect rendering, and profile persistence separate.

| Project | Status | Notes |
|---|---|---|
| `sigtrapgames/VrTunnellingPro-Unity` | Studied in Wave 292 | Rich tunnelling plugin with vignette, cage, window, portal, blur, masking, presets, and shaders |
| `ExtendRealityLtd/Tilia.Visuals.Vignette.Unity` | Studied in Wave 292 | Facade/configurator split for velocity/angular-velocity vignette intensity and smoothing |
| `BryanRalston/vr-comfort-framework` | Studied in Wave 292 | Comfort score, fold/recovery state machine, sustain timers, and post-recovery conservative window |
| `Skyfall1235/VR-Player-Comfort-Profile-SDK` | Studied in Wave 292 | JSON comfort profile schema for locomotion, turning, vignette, subtitles, haptics, and controls |
| `KRASAV4EK/BP_Foveated-Rendering-In-PC-VR` | Studied with asset-heavy caveats in Wave 292 | URP VRS feature, gaze marker, foveation toggles, mask/debug controls, and comfort/perception study framing |
| `melisgokalp/Cybersickness` | Source-light in Wave 292 | Search candidate with no usable source tree in local pass |

### Consolidation note

This family matters because comfort utilities should name:

- motion/velocity inputs;
- comfort score and hysteresis state;
- visual intervention renderer;
- user profile schema and versioning;
- foveation/performance controls;
- safe defaults, consent, and user overrides.

It suggests a stronger branch inside `VR-apps-lab` around:

- comfort settings panels;
- adaptive vignette/tunnelling helpers;
- shared comfort profile import/export;
- comfort diagnostics and user-controlled intervention status.

## Family 272: Eye-tracking recorders, accuracy tests, heatmaps, and gaze analytics

This family covers VR eye-tracking projects that turn vendor gaze data into
calibration tasks, target tests, heatmaps, logs, and analysis-ready exports.
The reusable lesson is to keep vendor SDK ingress, calibration, sampling,
visualization, analysis, and privacy policy separate.

| Project | Status | Notes |
|---|---|---|
| `med-material/VREyeTrackingAccuracyTest` | Studied in Wave 293 | Pupil Labs target/FOV harness, gaze path capture, 50 ms logging loop, CSV writer, and display settings |
| `RealBrandonChen/Unity-Eyetracking-Heatmap` | Studied in Wave 293 | Pupil request/subscription controllers, gaze/frame listeners, recording controls, and visualization scripts |
| `simpleOmnia/sXR` | Studied in Wave 293 | SRanipal gaze recording, tagged eyetracker output, screen/gaze fixation, pupil/open fields, and dataframe helper |
| `FoveHMD/UnityPlugin` | Studied in Wave 293 | FOVE gaze recorder, coordinate spaces, recording sync modes, gazable objects, and project checks |
| `FoveHMD/FoveUnitySample` | Studied in Wave 293 | Minimal FOVE gaze ray cursor with per-eye access and combined-gaze fallback |
| `n3urovirtual/PicoXR_EyeTracking_Demo` | Studied with source caveats in Wave 293 | Gaze selection/TTS product reference; visible source is mostly PICO SDK API surface |
| `VR-HCI-Group/Unity-VR-EyeTracking` | Studied in Wave 293 | Vive SRanipal callback recorder with gaze, openness, pupil, and file output fields |
| `caseycotes-turpin/EyeTrackingAnalysis` | Source-light in Wave 293 | README-only analysis search candidate |

### Consolidation note

This family matters because gaze utilities should name:

- hardware/vendor adapter;
- gaze ray, validity, and confidence;
- calibration and target-test state;
- coordinate space and timestamp schema;
- heatmap/gaze visualization;
- export consent and privacy boundaries.

It suggests a stronger branch inside `VR-apps-lab` around:

- neutral gaze recorder adapters;
- eye-tracking accuracy panels;
- gaze heatmap/target-test utilities;
- privacy-aware research export schemas.

## Family 273: WebXR hand-tracking primitives, emulation, MIDI, and hand-driven utilities

This family covers WebXR projects that use bare hands as input, UI, test data,
physics bodies, or external command sources. The reusable lesson is to keep
joint sampling, recognition, UI action mapping, emulation, and external output
separate.

| Project | Status | Notes |
|---|---|---|
| `AdaRoseCannon/handy-work` | Studied in Wave 294 | Worker-backed pose registry, A-Frame handy controls, fuse timings, controller fallback, and magnetic helpers |
| `mrdoob/webxr-webcam-emulator` | Studied in Wave 294 | Chrome extension polyfill using MediaPipe face/hand landmarkers, smoothing, stereo toggle, and injected WebXR state |
| `fcor/hand-tracking-butane` | Studied in Wave 294 | Three.js hands, Cannon hand bodies, atom bodies, molecular constraints, and hand-object physics |
| `miguelppais/airbender-webxr-midi` | Studied in Wave 294 | WebXR hand-to-MIDI setup panel with output scan, channel, preset grid, mapping UI, and status LED |
| `RichardMeng1/custom-hand-gaze-webxr` | Studied in Wave 294 | Handedness ordering, palm-up canvas menu, poke selection, gaze ray tests, game modes, and WSS relay |
| `tatta-chotdog/webxr-hands-starter` | Studied in Wave 294 | Minimal scene/controller/hand manager split and wrist-distance gesture classifier |

### Consolidation note

This family matters because WebXR hand utilities should name:

- XRHand joint acquisition;
- gesture/pose schema and hysteresis;
- controller fallback;
- palm/wrist/poke UI;
- headsetless emulation and camera privacy;
- Web MIDI/WebSocket/external command safety.

It suggests a stronger branch inside `VR-apps-lab` around:

- browser-native hand debug panels;
- hand gesture event libraries;
- WebXR emulator compatibility checks;
- hand-to-command adapter prototypes.

## Family 274: VR calibration overlays, rig alignment, and tracking-space helpers

This family covers calibration and alignment projects that capture device,
body, gaze, surface, or room values and turn them into validated configuration.
The reusable lesson is to keep readiness checks, capture, solving, validation,
persistence, and user feedback separate.

| Project | Status | Notes |
|---|---|---|
| `mika-sandbox/Unity-VRIK-Calibration` | Studied in Wave 295 | Avatar scale, HMD assignment, active tracker assignment, FinalIK targets, and VRIK root control |
| `ahstevens/FishTankCalibrator` | Studied in Wave 295 | Four-corner display calibration, external DLL projection solve, XML output, and editor visualization |
| `PeterWolf93/PupilLabs_VR_Calibration` | Studied in Wave 295 | Pupil data loading, validation grids, polynomial calibration, regression coefficients, masking, and plotting |
| `TKorpXR/MooveoPlugin` | Studied in Wave 295 | Device checkers, tester prefabs, calibration state, points/normals config, UI events, and OpenVR tracker smoothing |
| `CamsAvis/VRC-Calibration-Detection` | Source-light product reference in Wave 295 | VRChat avatar calibration-complete bool and setup guidance |
| `Erimelowo/SlimeVR-Calibration` | Micro-utility in Wave 295 | Browser skeleton preview from body segment lengths for SlimeVR onboarding |

### Consolidation note

This family matters because calibration utilities should name:

- device readiness and validity;
- capture targets and measurement sources;
- solving/calibration algorithm;
- validation report;
- persisted profile/config schema;
- rollback and user feedback.

It suggests a stronger branch inside `VR-apps-lab` around:

- calibration doctor surfaces;
- tracker/avatar setup helpers;
- display/surface calibration tools;
- body-measurement previews and profile import/export.

## Family 275: Spatial anchors, colocation, persistent MR spaces, and room registration

This family covers projects that use anchors, room data, or registration
transforms to keep MR content stable across sessions, users, devices, or
physical spaces. The reusable lesson is to keep anchor lifecycle, world
alignment, content attachment, sharing, persistence, and repair/status UI
separate.

| Project | Status | Notes |
|---|---|---|
| `oculus-samples/Unity-SharedSpatialAnchors` | Deepened from partial in Wave 296 | Official Meta donor for anchor source typing, save/load/share, group discovery, origin alignment, Photon handoff, and MRUK world lock |
| `oculus-samples/Unity-Discover` | Deepened from partial/source-heavy in Wave 296 | Larger MR product-composition reference rather than main anchor donor |
| `arghyasur1991/QuestRoomScan` | Studied in Wave 296 | Persistent room scan packages, OVRSpatialAnchor persistence, MRUK fallback, relocation matrices, scene-object registry, and runtime guard |
| `NirajArts/SpatialAnchorTracking_Meta` | Studied in Wave 296 | Universal anchor setup helper with create/delete/load/reset/reposition UI and transform application |
| `jamesdowzard/quest-launcher` | Studied in Wave 296 | Quest MR launcher shell with Android helper bridge, model loader, HUD, and bootstrap split |
| `ftmghorbani/MX_Ink_2Ddrawing_Sample` | Studied in Wave 296 | Anchored MX Ink stylus/canvas workflow with pressure, double-tap, three anchors, and drawing persistence |
| `abhinavazad/XR-Experiment-Design-Toolbox` | Studied in Wave 296 | Procrustes scene re-registration, anchor JSON, prefab placement, replay, and experiment logs |

### Consolidation note

This family matters because persistent MR utilities should name:

- local, cloud, shared, and room-anchor sources;
- anchor create/localize/save/load/erase/share actions;
- world-origin alignment and content parenting;
- room/scene package manifests;
- relocation matrices and registration error metrics;
- anchor inventory, repair, deletion, and privacy controls.

It suggests a stronger branch inside `VR-apps-lab` around:

- persistent MR utility shells;
- anchor inventory and repair panels;
- room scan export/import tools;
- shared-space setup helpers;
- spatial experiment registration utilities.

## Family 276: XR captions, subtitles, accessibility text, and live caption surfaces

This family covers projects that make speech, timed text, or source labels
readable in VR/AR. The reusable lesson is to keep caption source, parser,
timing clock, renderer, placement policy, sync, user settings, and privacy
separate.

| Project | Status | Notes |
|---|---|---|
| `XR-Access-Initiative/chirp-captions` | Studied in Wave 297 | Caption source/render manager split, timed captions, head-locked renderer, safe area, and source-direction arrows |
| `A11YTK/A11YTK` | Studied in Wave 297 | SRT parser, subtitle source controllers, headset/object/screen renderers, VideoPlayer binding, and option assets |
| `neogeek/a11ytk-rewrite` | Variant marker in Wave 297 | Rewrite/package-shape comparison node for the original A11YTK approach |
| `craigm26/LiveCaptionsXR` | Studied in Wave 297 | Live AR/XR caption stack with stereo audio, STT, contextual enhancement, localization, anchors, and model management |
| `lavin-a/aframe-xr-access-design` | Studied in Wave 297 | A-Frame directional caption controller and browser-native accessibility scene |
| `jayrosen-design/XR-Caption` | Micro-reference in Wave 297 | Small Flask/web stereo caption layout reference |
| `jacklul/USharpVideo-Subtitles` | Studied in Wave 297 | VRChat/Udon subtitle overlay with URL/text loading, chunk sync, parser budget, update cadence, and styling |
| `Ikbenmathijs/VRC-ProTV-Subtitles` | Studied in Wave 297 | Minimal ProTV subtitle downloader/parser/current-time sync |

### Consolidation note

This family matters because caption/accessibility text utilities should name:

- timed text versus live STT source;
- parser format and parser budget;
- source clock or video time;
- head-locked, object, screen, directional, or anchored placement;
- safe area, contrast, text scale, and background style;
- sync, ownership, and privacy/consent rules.

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable caption renderer kits;
- safe-area text panels;
- directional caption helpers;
- VRChat video subtitle utilities;
- live STT accessibility overlays.

## Family 277: OpenXR/Unity hand gesture recognition, sign learning, and hand data bridges

This family covers Unity/OpenXR hand projects that turn raw hand joints into
recognized gestures, sign-learning feedback, controller replacement, or remote
hand-data streams. The reusable lesson is to keep joint sampling,
normalization, recording/training, recognition, state transitions, feedback,
and side effects separate.

| Project | Status | Notes |
|---|---|---|
| `HankunYu/Kuji-Kiri` | Studied in Wave 298 | Strong donor for wrist-local hand snapshots, feature vectors, MLP static classifier, DTW dynamic recognizer, state machine, and editor training |
| `Phlegmati/SimpleGestureRecorder` | Studied in Wave 298 | Compact XRHandShape recorder/debugger with timed capture, screenshots, jointsUpdated checks, hold gates, and distance debug |
| `TF-polygon/XR-SignQuest` | Studied with asset/model caveats in Wave 298 | VR ASL learning reference with mirror-camera YOLO/ONNX feedback, confidence color, and memory discipline |
| `ariesiitr/Hand-Tracking-VR` | Source-light/package reference in Wave 298 | Unitypackage hand-tracking demo marker for grab/pinch/point interaction |
| `Vin-meido/COM3D25_OpenXRHandsPOC` | Studied in Wave 298 | OpenXR hands to legacy controller/game input adapter with InputAction filters and One Euro smoothing |
| `ARCLab-MIT/BeaVR-app` | Studied in Wave 298 | Quest hand tracking to robot/server bridge with ordered XR Hands joints, NetMQ sockets, pinch toggles, and IP/port config |

### Consolidation note

This family matters because hand gesture utilities should name:

- runtime hand source and joint ordering;
- coordinate normalization and hand-size assumptions;
- training/recording assets;
- static, dynamic, threshold, or camera-inference recognizer;
- hold/release/cooldown state;
- feedback surface and confidence display;
- output clamps, transport schema, and safety policy.

It suggests a stronger branch inside `VR-apps-lab` around:

- Unity hand gesture recorder/debug panels;
- recognizer adapter interfaces;
- sign-learning feedback prototypes;
- hand-to-command bridge safety;
- teleoperation hand-packet schemas.

## Family 278: Voice-driven VR communication, control, agents, and speech surfaces

This family covers voice projects that convert microphone input into commands,
chat, avatar parameters, assistant responses, voice chat, speech bubbles, or
feedback recordings. The reusable lesson is to keep mic consent, capture,
recognition, command/agent pipeline, transport, output, and privacy controls
separate.

| Project | Status | Notes |
|---|---|---|
| `oculus-samples/voicesdk-samples-whisperer` | Studied with asset-heavy caveats in Wave 299 | Official Voice SDK product reference for consent, mic levels, listenable objects, speech bubbles, and voice UI |
| `UCL-VR/ubiq-genie` | Studied in Wave 299 | Service-orchestrated agent and transcription stack with media receiver, STT, text generation, TTS, Unity receivers, and audio injection |
| `vr-the-feedback/vr-the-feedback-unity` | Source-light legacy reference in Wave 299 | Grabbable mic and feedback recording flow with backend/project-key caveats |
| `nikaera/MagicOnionExample-OculusMobileVoiceChat` | Studied in Wave 299 | Microphone ring buffer, Opus encode/decode, MagicOnion room hub, avatar transforms, and remote audio playback |
| `xiaolazhu/vrc-voice-params` | Studied in Wave 299 | Web Speech to VRChat OSC avatar parameter sidecar with command CRUD, Go OSC sender, and debug receiver |
| `Jurangren/VRC-Voicebridge` | Studied in Wave 299 | Cancelable STT/translation/TTS/OSC pipeline with local Whisper, chatbox/typing/voice paths, virtual mic playback, tray UI, and status overlay |
| `Alchemishty/ExpressVR` | Studied in Wave 299 | Networked speech bubble/emote wheel with client registry, RPC broadcasts, settings, animation, and XR input abstraction |
| `ahmedbegovic/VoiceInteractionVR` | Source-light puzzle reference in Wave 299 | Voice-interaction search marker; visible source is mostly puzzle/environment logic |

### Consolidation note

This family matters because voice-driven XR tools should name:

- consent and mic activation status;
- STT and command recognition source;
- command registry and confirmation policy;
- text generation/TTS service boundary;
- voice chat codec and room transport;
- OSC/chatbox/avatar output validation;
- speech bubble/status overlay feedback;
- privacy, cancellation, and error states.

It suggests a stronger branch inside `VR-apps-lab` around:

- speech command sidecars;
- VRChat OSC voice utilities;
- conversational assistant surfaces;
- voice chat transport references;
- speech bubble accessibility and moderation patterns.

## Family 279: XR text entry, keyboard variants, gaze, dictation, and query input surfaces

This family covers projects that let users enter text, commands, search terms,
or query tokens inside XR. The reusable lesson is to keep keyboard layout,
interaction source, target receiver, accessibility mode, feedback, and privacy
separate.

| Project | Status | Notes |
|---|---|---|
| `ViRGIS-Team/VR-Keyboard` | Studied in Wave 300 | Compact Unity XR keyboard with key events, layer state, XRUIInputModule setup, and collider/direct interactor mapping |
| `magicleap/MagicLeapXRKeyboard` | Studied with vendor caveats in Wave 300 | Keyboard manager, layout data, row/key builder, TMP input receiver, follow/recenter behavior, haptics, and preview |
| `fabio914/EyeTrackingKeyboard` | Prototype studied in Wave 300 | Gaze/dwell raycast keyboard with eye-height following, shift/secondary modes, highlight, and audio feedback |
| `vitrivr/vitrivr-vr` | Studied in Wave 300 | Search/query app with static text router, physical keyboard generator, phrase insertion, dictation controllers, and query-term providers |

### Consolidation note

This family matters because XR text-entry utilities should name:

- layout data and key semantics;
- controller, direct hand, gaze, physical keyboard, and dictation input modes;
- target text receiver or query model;
- debounce, dwell, haptics, preview, and audio feedback;
- privacy/password behavior and accidental input protection.

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable XR keyboard kits;
- gaze/dwell accessibility text entry;
- command-palette and search/query surfaces;
- text-input diagnostics for focus, input modules, and target receivers.

## Family 280: Quest camera wrappers, permissions, QR/world tracking, and camera observation state

This family covers Quest camera projects that expose camera access, frame
metadata, QR/object detections, world placement, and camera-derived state. The
reusable lesson is to separate permission/support gates, capture, conversion,
detection, placement, tracker state, and privacy.

| Project | Status | Notes |
|---|---|---|
| `xrdevrob/QuestCameraKit` | Sample/common-layer reference in Wave 301 | Marker pool and marker controller for update/text/scale/idle-hide camera labels |
| `Uralstech/UXR.QuestCamera` | Studied in Wave 301 | HorizonOS permissions, camera discovery, Camera2 callbacks, continuous/on-demand pipelines, YUV conversion, metadata, and error taxonomy |
| `HoloLabInc/QuestCameraTools-Unity` | Studied in Wave 301 | WebCamTexture manager, QR detector/tracker, cancellation, environment raycast placement, filters, anchor selection, and tracking events |
| `oculus-samples/Unity-SpatialLingo` | Studied in Wave 301 | Camera taxon tracker, object classifier, face blur, reliability scoring, observe/miss counts, and add/update/remove events |

### Consolidation note

This family matters because camera utilities should name:

- platform support and permission state;
- camera inventory, selected eye/source, and frame format;
- pose, intrinsics, timestamp, and conversion metadata;
- detection adapter and world raycast/placement;
- marker/tracker lifecycle and lost-state policy;
- privacy, face/object recognition, and debug UI.

It suggests a stronger branch inside `VR-apps-lab` around:

- Quest camera diagnostic panels;
- QR/world-marker utilities;
- camera permission and support doctors;
- privacy-aware camera observation state.

## Family 281: Quest camera CV, object detection, segmentation, and world marker pipelines

This family covers camera-to-CV projects that run object detection,
segmentation, ArUco/QR, or semantic tracking over Quest passthrough frames. The
reusable lesson is to keep camera adapters, model execution, output parsing,
world projection, marker/tracker state, and privacy/debug surfaces separate.

| Project | Status | Notes |
|---|---|---|
| `demoPlz/Unity-MultiObjectDetection` | Studied with caveats in Wave 302 | Permission-aware object detection menu, inference idle gate, layer-per-frame scheduling, marker placement/de-dupe, and recenter cleanup |
| `EnoxSoftware/QuestWithOpenCVForUnityExample` | Studied with package/license caveats in Wave 302 | Passthrough-to-OpenCV Mat helper, camera pose/intrinsics, ArUco, YOLOX/Sentis, ByteTrack, and debug/FPS controls |
| `rikturnbull/xr-image-segmentation` | Studied in Wave 302 | Quest segmentation prototype with inference executor state machine, async output requests, mask renderer, and confidence thresholds |
| `oculus-samples/Unity-SpatialLingo` | Cross-wave reference in Wave 302 | Official object classifier and reliability-aware taxon tracker overlap with Wave 301 |

### Consolidation note

This family matters because camera-CV utilities should name:

- frame adapter and ownership;
- pose/intrinsics metadata;
- model scheduler and backpressure;
- detector/segmenter output schema;
- world projection, marker de-dupe, and tracked entity lifecycle;
- confidence, debug status, privacy, and model provenance.

It suggests a stronger branch inside `VR-apps-lab` around:

- camera-CV debug surfaces;
- object-label and marker-placement utilities;
- segmentation-assisted accessibility overlays;
- calibration-aware OpenCV helper packages.

## Family 282: Embodied locomotion, walking-in-place, redirected walking, and comfort/experiment packaging

This family covers projects that turn controllers, trackers, body movement,
redirected-walking gains, or room transitions into locomotion. The reusable
lesson is to keep input-source adapters, movement application, comfort
mitigation, RDW world transforms, and metrics separate.

| Project | Status | Notes |
|---|---|---|
| `singaporetech/immersification-wip-locomotion` | Studied in Wave 303 | Strong WIP donor with input manager, movement manager, tracker allocator, arm/head/leg movement modules, stale reset, and smoothing |
| `DarkerQueenSara/ProjetoVR-V2` | Studied with research caveats in Wave 303 | RDW gains, room/portal generation, teleport handoff, and real/virtual/gain CSV metrics |
| `tmitro/ucf-ist-redirected-walking` | Source-light/fork-lineage in Wave 303 | Vive/OpenVR redirected-walking framework marker with vendored SteamVR/VRTK and RDWT artifact caveats |
| `VRatPolito/CET-VR` | Product/reference node in Wave 303 | XRI dynamic movement direction, joystick blocked state, arrow affordance, jump curve, and tunnelling comfort preset surfaces |

### Consolidation note

This family matters because locomotion utilities should name:

- raw input source and tracker allocation;
- normalized movement magnitude/direction;
- movement manager and stale-input reset;
- calibration/tuning UI and fallback mode;
- comfort vignette/tunnelling/preset controls;
- RDW gain/world transform, room transitions, and experiment metrics.

It suggests a stronger branch inside `VR-apps-lab` around:

- embodied locomotion mode kits;
- walking-in-place calibration/debug panels;
- comfort profile integration;
- redirected-walking experiment metrics and lineage cleanup.

## Family 283: In-VR questionnaires, study surveys, affect ratings, and remote lab overlays

This family covers VR research-study projects that collect questionnaires,
survey answers, affect ratings, UI events, transforms, or remote-lab state
inside an immersive session. The reusable lesson is to keep survey schema,
generated UI, input feedback, validation, participant/session metadata, export,
replay alignment, network sync, and privacy policy separate.

| Project | Status | Notes |
|---|---|---|
| `MartinFk/VRQuestionnaireToolkit` | Studied in Wave 304 | JSON questionnaire metadata, prefab page factory, required validation, haptic/audio feedback, participant/condition setup, and CSV/TXT export |
| `JakobJoSchmidt/immersive-questionnaire-unity-vr` | Studied in Wave 304 | CSV-driven service with Likert options, random inversion, editing-time output, verbal labels, and answer CSV generation |
| `microsoft/Remote-Lab` | Studied in Wave 304 | ScriptableObject questionnaire content, replay-aligned answer logs, Photon sync, transform recording, OBS, UI events, and custom variables |
| `Pepn/SurveyToolkit` | Studied in Wave 304 | Page/question data split, required highlighting, CSV export, persistent storage, and optional upload with security caveats |
| `afourcade/AffectTracker_validation` | Analysis companion in Wave 304 | Continuous affect validation pipeline, preprocessing, BIDS formatting, plotting, modeling, and runtime follow-up marker |

### Consolidation note

This family matters because study overlays should name:

- question schema and authoring format;
- page factory and supported answer widgets;
- required-answer validation and feedback;
- participant/session metadata and timeline alignment;
- local export, upload, replay, sync, and analysis boundaries;
- consent, privacy, and upload-secret handling.

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable survey panels;
- research-study overlay shells;
- replay-aligned questionnaire logs;
- participant metadata/privacy checklists;
- affect and subjective-rating input surfaces.

## Family 284: VR wayfinding, navigation guidance, and spatial navigation study tasks

This family covers VR projects that test or support spatial navigation through
targets, gaze destinations, city routes, room transitions, NPC/agent advice,
haptic boundaries, or comfort aids. The reusable lesson is to separate
movement, route state, guidance source, comfort/haptic aids, condition
randomization, and telemetry.

| Project | Status | Notes |
|---|---|---|
| `pepwuper/Google-Cardboard-VR-Navigation` | Studied in Wave 305 | Gaze cursor to NavMesh destination and player-following UI height preservation |
| `npresearchlab/NavCity_Toolkit` | Studied in Wave 305 | Target sequencing, mission text, headset X/Z/rotation/time CSV logging, and participant ID caveats |
| `zcbtmfc/Wayfinding-Task` | Studied in Wave 305 | Randomized wayfinding conditions, additive room loading, agent advice/audio, ask/distance/time logs, and decision capture |
| `maxleblanc/sightless-vr` | Source-light product reference in Wave 305 | Haptic wearable/no-HMD architectural wayfinding and ghost-obstacle framing |
| `angsamuel/GingerVR` | Source-light product reference in Wave 305 | Cybersickness/navigation aid taxonomy across rest frames, blur/FOV, dots, head snap, vision lock, and virtual CAVE |

### Consolidation note

This family matters because navigation tasks should name:

- destination source and movement actuator;
- target/waypoint state and route progression;
- room/scene transition model;
- guide, agent, hint, or haptic feedback source;
- comfort intervention and opt-in state;
- participant/session metadata and reconstructable logs.

It suggests a stronger branch inside `VR-apps-lab` around:

- gaze-to-destination movement adapters;
- wayfinding experiment scaffolds;
- route/target telemetry schemas;
- haptic boundary and no-HMD navigation references;
- comfort-aware navigation UI.

## Family 285: XR testing, simulation, input validation, and performance harnesses

This family covers projects that inspect XR input/runtime state, create minimal
repro scenes, assert device/display/audio behavior, collect performance
samples, or simulate XR providers in editor. The reusable lesson is to separate
live inspection, manual repros, automated assertions, performance metadata,
result export, and simulation backends.

| Project | Status | Notes |
|---|---|---|
| `Unity-Technologies/XRInputTests` | Studied in Wave 306 | XR Tests view, scene driver, live feature TreeViews, haptic capability/impulse panels, and export/update workflows |
| `Unity-Technologies/xr.sdk.functionaltests` | Studied in Wave 306 | Functional test base, display/input/device/audio assertions, runtime skips, and timing/refresh checks |
| `Unity-Technologies/com.unity.xr.test-framework.performance` | Studied in Wave 306 | Sample groups, profiler markers, statistics, build/runtime metadata, TestRunner callbacks, and JSON/XML result output |
| `needle-tools/ar-simulation` | Studied with package/license caveats in Wave 306 | ARFoundation/editor simulation backend for planes, point clouds, image tracking, touch, and provider-level simulation |

### Consolidation note

This family matters because XR validation utilities should name:

- live device and feature inventory;
- haptic/display/input/audio capability probes;
- minimal repro scene packaging;
- automated assertion scope and skip gates;
- performance sample definitions and environment metadata;
- simulation backend boundaries and production exclusion.

It suggests a stronger branch inside `VR-apps-lab` around:

- XR doctor reports;
- input and haptic debug panels;
- functional test matrices;
- performance-result schemas;
- editor simulation and repro-scene helpers.

## Family 286: XR gaze, pinch, dwell, onboarding, and Android XR interaction samples

This family covers projects that use gaze, eye rays, camera-center rays, dwell,
pinch, controller confirmation, onboarding cards, status dashboards, or user
simulation to drive XR interactions. The reusable lesson is to keep ray
source, interactable contract, reticle/progress, confirmation trigger, menu
layout, onboarding, telemetry, and capability state separate.

| Project | Status | Notes |
|---|---|---|
| `DFKI-Interactive-Machine-Learning/de.dfki-iml.xr-gaze-interaction-toolkit` | Studied in Wave 307 | Global gaze manager, gaze interactables, information displays, radial/pie menus, guide/questionnaire cards, attention monitoring, accuracy tests, and CSV export |
| `tomazsaraiva/unity-gaze-interaction` | Studied in Wave 307 | Compact gaze raycast, enter/stay/exit/activated events, reticle scaling/alignment, dwell progress, and exit delay |
| `microsoft/MixedReality-EyeTracking-Sample` | Studied in Wave 307 | HoloLens 2 extended eye-tracking provider with permissions, tracker watcher, SpatialGraphNode transforms, and left/right/combined gaze |
| `holokit/holokit-unity-sdk` | Studied in Wave 307 | Gaze raycast interactable, gaze+pinch adapter, dwell button UI, hand tracking, stereo phone MR, and calibration/recording references |
| `android/xr-unity-samples` | Studied in Wave 307 | Android XR gaze+pinch samples, gesture detector, status dashboard, permission request UI, menu tutorial, passthrough, and simulation assets |

### Consolidation note

This family matters because gaze and pinch utilities should name:

- gaze/eye/camera ray provider and validity;
- target interface and enter/stay/exit events;
- reticle, progress, dwell, cancel, and reset behavior;
- pinch/controller confirmation adapter;
- radial, pie, guide-card, or dashboard menu surface;
- permission, capability, simulation, telemetry, and privacy state.

It suggests a stronger branch inside `VR-apps-lab` around:

- gaze/dwell interaction kits;
- controller-free menu prototypes;
- gaze accuracy and AOI monitoring tools;
- Android XR permission/status panels;
- onboarding cards for hand, gaze, and pinch input.

## Family 287: VR/3D annotation, point-cloud labeling, and linked-data note surfaces

This family covers projects that let users annotate scenes, label point clouds,
attach notes to spatial targets, revisit annotation viewpoints, or persist
label records locally/remotely. The reusable lesson is to keep dataset import,
geometry services, label/annotation schema, manipulation handles, persistence,
navigation, and provenance separate.

| Project | Status | Notes |
|---|---|---|
| `ahstevens/VR-Point-Cloud-Editor` | Studied in Wave 308 | Native point-cloud plugin boundary, LAZ import/export, LOD/culling, closest-point/sphere queries, outlier highlight/delete, undo, and editor/runtime manager |
| `florianwirth/PointAtMe` | Studied in Wave 308 | Point-cloud/image sequence labeling, 65k mesh chunking, bounding-box labels, track IDs, class/quality dialogs, and controller manipulation |
| `framefield/vr-annotate` | Studied in Wave 308 | Linked-data annotation manager, target node selectors, local/REST persistence, W3C-style annotation JSON, viewport recall, and annotation tours |

### Consolidation note

This family matters because annotation utilities should name:

- dataset source and import/export adapter;
- spatial target identity and geometry query service;
- label/annotation schema and taxonomy dialogs;
- controller manipulation and review navigation;
- provenance fields such as author, time, target ID, and viewport pose;
- local/remote storage adapter, sync, auth, and conflict boundaries.

It suggests a stronger branch inside `VR-apps-lab` around:

- spatial review and issue-tracking tools;
- point-cloud inspection and labeling shells;
- annotation schema templates;
- linked-data note surfaces;
- dataset QA and revisit/tour workflows.

## Family 288: VR motion capture, pose recording, BVH, muscle compression, and body tracker samples

This family covers projects that capture HMD/controller/body tracker poses,
retarget them to avatars, record/replay tracking streams, export motion
formats, compress humanoid motion, or surface tracker state. The reusable
lesson is to keep live device APIs, retargeting, recording schema, playback,
export, compression, and diagnostics separate.

| Project | Status | Notes |
|---|---|---|
| `alexismorin/OpenMocap` | Studied in Wave 309 | Roomscale HMD/controller sampling, humanoid IK, hip/head offset, and Unity Recorder coupling |
| `andrewjc/VRRecorder` | Studied in Wave 309 | SteamVR matrix/controller-state keyframes, text logs, HMD/controller recorder proxies, and playback device injection |
| `emilianavt/BVHTools` | Studied in Wave 309 | BVH recorder/parser, humanoid bone mapping, bone renaming, skeleton hierarchy, Blender axis mode, and channel parsing |
| `gree/MuscleCompressor` | Partially studied in Wave 309 | Muscle-space Humanoid compression workflow, motion `.data` storage, bytes-to-animation conversion, and core-isolation follow-up |
| `Pico-Developer/PICOMotionTrackerSample-Unity` | Studied in Wave 309 | PICO tracker inventory, serial numbers, confidence, calibration/battery UI, 24-joint body pose, CSV playback, and bone-length updates |

### Consolidation note

This family matters because mocap and tracker utilities should name:

- live tracker/device inventory and confidence state;
- sample clock, pose schema, and controller-state schema;
- avatar retargeting and calibration;
- recording and playback provider boundaries;
- export/interchange format and compression adapter;
- battery, calibration, assisted-role, and vendor fallback UI.

It suggests a stronger branch inside `VR-apps-lab` around:

- tracker diagnostics overlays;
- pose recording and replay harnesses;
- avatar motion export helpers;
- BVH/muscle/OSC/VMC interchange comparison;
- body tracker calibration and confidence dashboards.

## Family 289: Game-specific VR retrofit mods, runtime bootstrap, UI patches, and comfort product lessons

This family covers projects that retrofit existing games with OpenXR/SteamVR,
motion controls, input remapping, world-space UI, virtual keyboards, comfort
modes, and setup/support guidance. The reusable lesson is to separate the
general retrofit boundary from the game-specific patch layer.

| Project | Status | Notes |
|---|---|---|
| `ethanporcaro/BF2VR-Alpha` | Studied in Wave 310 | Native C++ OpenXR/D3D11 session binding, swapchains, render-target views, action setup, and ViGEm virtual gamepad output |
| `DrBibop/RoR2VRMod` | Studied in Wave 310 | Unity/BepInEx OpenXR loader bootstrap, controller profiles, body-specific hand/tool mapping, wrist/watch HUD, and haptics |
| `Raicuparta/nomai-vr` | Studied in Wave 310 | Ordered SteamVR module graph, action manifests, mode-aware input maps, virtual keyboard, tools/hands/HUD, and compatibility checks |
| `Raicuparta/two-forks-vr` | Studied in Wave 310 | Harmony patches that convert screen-space canvases into static/interactive world-space UI surfaces with laser-pointer affordances |
| `LukeRoss00/gta5-real-mod` | Source-light product reference in Wave 310 | Setup discipline, settings backup/restore, fixed/headlocked HUD, headshake recenter, gamepad/head aiming, and cutscene comfort modes |

### Consolidation note

This family matters because retrofit utilities should name:

- runtime/session bootstrap and graphics bridge;
- action maps, virtual gamepad, keyboard, and legacy input adapters;
- game-patch modules and compatibility gates;
- UI surface classification and world-space conversion;
- recentering, comfort modes, cutscene modes, and HUD behavior;
- setup/support docs, backup/restore, and legal/support boundaries.

It suggests a stronger branch inside `VR-apps-lab` around:

- world-space UI migration patterns;
- virtual keyboard/input prompt adapters;
- comfort/setup documentation templates;
- runtime bootstrap risk checklists;
- retrofit-safe module graphs and compatibility reports.

## Family 290: Rust, Bevy, and Godot OpenXR bring-up variants, app shells, and input/rendering boundaries

This family covers Rust, Bevy, Godot, and hand-rolled OpenXR experiments that
make instance/session lifecycle, graphics binding, swapchains, frame-loop
systems, texture handoff, input resources, and platform adapters visible. The
reusable lesson is to treat the app shell itself as a donor pattern.

| Project | Status | Notes |
|---|---|---|
| `blaind/bevy_openxr` | Studied in Wave 311 | WGPU/OpenXR handoff, one-shot XrInstance storage, custom runner, and separated device/event/hand/swapchain/render graph modules |
| `MalekiRe/bevy_openxr_android` | Studied in Wave 311 | Quest/Android Bevy sample with DefaultXrPlugins, typed controller resources, frame/session/input resources, and controller gizmos |
| `occuros/bevy_openxr_performance_test` | Studied in Wave 311 | Manual RenderPlugin replacement, FutureXrResources, manual texture views, XR frame systems, and swapchain image lifecycle |
| `richardanaya/godot_openxr__rust` | Studied in Wave 311 | Godot XR scene plus Rust GDExtension controller logic that reads `XRController3D` and updates mesh material |
| `TheHellBox/SlashMania` | Studied in Wave 311 | Rust Specs/OpenGL OpenXR game loop with explicit instance/session/swapchain/reference-space/frame-stream module |

### Consolidation note

This family matters because engine app shells should name:

- instance, system, session, and reference-space lifecycle;
- graphics backend binding and ownership handoff;
- swapchain image acquire/wait/release/end semantics;
- render texture or manual texture view handoff;
- action/controller resources and ECS/Godot node boundaries;
- Android/Quest packaging and platform adapter assumptions.

It suggests a stronger branch inside `VR-apps-lab` around:

- Rust OpenXR app-shell templates;
- Bevy XR render/input boundary matrices;
- Godot Rust extension micro-patterns;
- swapchain/frame-loop diagrams;
- engine-version and platform-adapter risk notes.

## Family 291: VRCFaceTracking vendor modules, shared memory, vendor SDKs, and loopback bridges

This family covers vendor-specific VRCFaceTracking modules that ingest eye or
face data through shared memory, vendor SDK DLLs, or local UDP/JSON bridges.
The reusable lesson is to keep headset/vendor capture ownership, transport
parsing, smoothing/fallback, stale-state handling, and VRCFT slot publication
separate.

| Project | Status | Notes |
|---|---|---|
| `BigscreenVR/VRCFT-Beyond` | Studied in Wave 312 | Thin shared-memory eye-only module with a fixed gaze/openness schema and 3D-to-2D gaze conversion |
| `benaclejames/VRCFTPimaxModule` | Studied in Wave 312 | Embedded vendor DLL extraction, JSON smoothing config, blink/wink timing, and one-eye fallback |
| `UikaMisumi/DreamAirTracking.VrcftModule` | Studied in Wave 312 | Loopback UDP/JSON bridge with stale timeout, neutralization, optional pupil/expression output, and coexistence notes |

### Consolidation note

This family matters because vendor VRCFT modules should name:

- headset/vendor capture ownership versus module ownership;
- transport shape such as memory map, callback DLL, or loopback UDP;
- normalization, smoothing, and tracking-loss fallback;
- stale timeout and neutral output policy;
- eye-only versus eye-plus-expression slot claims;
- coexistence rules with other active modules.

It suggests a stronger branch inside `VR-apps-lab` around:

- vendor module comparison matrices;
- loopback/shared-memory bridge templates;
- eye-loss fallback heuristics;
- slot-coexistence guidance for multi-module stacks;
- transport/schema diagnostics for tracking bridges.

## Family 292: VRCFaceTracking downstream bridges, simulation panels, and avatar setup automation

This family covers tools that receive VRCFaceTracking output, translate it into
another avatar/runtime ecosystem, simulate or manually override tracking, or
generate avatar assets and animator layers. The reusable lesson is to keep
upstream tracking transport, downstream translation, control/simulation UI, and
creator-time asset generation separate.

| Project | Status | Notes |
|---|---|---|
| `tkns3/VRCFTtoVMCP` | Studied in Wave 313 | OSC ingest, VMC/PerfectSync translation, avatar-change orchestration, and local discovery/service advertisement |
| `Toys0125/VirtualFaceTracking` | Studied in Wave 313 | VRCFT module plus named-pipe GUI companion, diagnostics, simulation engine, and persistent session state |
| `LumKitty/VRCFTnyan` | Studied in Wave 313 | VNyan-facing plugin adapter with config, triggers, avatar JSON handoff, and downstream blendshape ownership |
| `ImTiara/FaceTrackingSetup` | Studied in Wave 313 | Inspector-driven face-tracking setup flow with searchable blendshape mapping and guided authoring |
| `benaclejames/VRCFTSetupUtility` | Studied in Wave 313 | Param-metadata-driven renderer diff capture, animation generation, and FX layer synthesis |

### Consolidation note

This family matters because downstream VRCFT tools should name:

- upstream parameter ingest and storage;
- downstream protocol or consumer-specific mapping;
- local discovery, avatar handoff, and lifecycle coordination;
- manual/simulated control surfaces and diagnostics;
- persistent session/config state;
- metadata-driven animation and animator-layer generation.

It suggests a stronger branch inside `VR-apps-lab` around:

- VRCFT downstream compatibility matrices;
- named-pipe or local companion harnesses;
- manual face-tracking test surfaces;
- avatar-setup generators and param-meta templates;
- creator onboarding flows that replace long manual checklists.

## Family 293: PSVR2Toolkit downstream clients, gaze capture, haptics, and installer microtools

This family covers downstream utilities built around PSVR2Toolkit rather than
the toolkit core itself. The reusable lesson is to separate toolkit/runtime
ownership from narrow client surfaces such as eye-image capture, haptic relays,
driver patch management, and game-specific trigger consumers.

| Project | Status | Notes |
|---|---|---|
| `BnuuySolutions/PSVR2Toolkit.Baballonia` | Studied in Wave 314 | Thin C API gaze-image adapter that copies a fixed PSVR2 image payload into an OpenCV capture surface |
| `tabithamoon/PSVR2HeadpatHaptics` | Studied in Wave 314 | OSCQuery/WebSocket headset-rumble relay with velocity-derived intensity mapping |
| `MaidScientistIzutsumiMarin/psvr2toolkit-installer` | Studied in Wave 314 | Signed-driver validation, reversible install/uninstall, release checks, and config toggles |
| `Kingoooooooo/Pistol-Whip-Adaptive-Triggers` | Studied in Wave 314 | MelonLoader consumer of local toolkit IPC for adaptive trigger profiles |

### Consolidation note

This family matters because toolkit-adjacent utilities should name:

- native C API or local IPC client boundaries;
- capture-provider or physical-output consumer shape;
- driver-state validation, rollback, and update logic;
- hardware command vocabularies versus game-specific policy;
- safety, auth, and cooldown expectations for haptics;
- release/update assumptions for runtime-adjacent installers.

It suggests a stronger branch inside `VR-apps-lab` around:

- vendor-runtime client adapters;
- haptic relay and safety-policy sidecars;
- reversible driver patch managers;
- game-state-to-hardware policy layers;
- diagnostics around toolkit availability and version drift.

## Family 294: XREAL One companions, virtual displays, IMU readers, and display-triggered microhelpers

This family covers XREAL One and adjacent smart-glasses companions that expose
IMU transport, virtual-display lifecycle, helper-service boundaries, or small
platform automations. The reusable lesson is to separate sensor transport,
display lifecycle, privileged operations, and narrow user-value automations.

| Project | Status | Notes |
|---|---|---|
| `dripster82/ar_workspace_manager_for_xreal` | Studied in Wave 315 | Full smart-glasses workspace manager with IMU transport split, stable display identity, diagnostics, widgets, media, and helper services |
| `SamiMitwalli/One-Pro-IMU-Retriever-Demo` | Studied in Wave 315 | Small network IMU reader with calibration and complementary-filter head tracking |
| `rohitsangwan01/xreal_one_driver` | Studied in Wave 315 | Rust driver core plus C ABI around XREAL One IMU packet parsing |
| `shugi12345/xreal-show-taps` | Studied in Wave 315 | Android foreground service that toggles a privileged system setting on external display attach/detach |
| `DeskUnreal/xreal-vio-vr` | Studied in Wave 315 as a stack marker | Linux VIO/OpenXR/overlay direction marker with useful patches but still mostly skeletal runtime code |

### Consolidation note

This family matters because smart-glasses utilities should name:

- transport source such as HID-like versus network IMU access;
- packet framing, sanity guards, drift and mount calibration;
- virtual-display identity and churn-management strategy;
- diagnostics for private/platform-fragile display behavior;
- helper-service or permissioned sidecar boundaries;
- narrow display-triggered automations on mobile/desktop platforms.

It suggests a stronger branch inside `VR-apps-lab` around:

- smart-glasses workspace-shell design notes;
- runtime-neutral IMU driver cores;
- stable virtual-display identity guidance;
- Android display-trigger utilities;
- cautious Linux stack framing with patch-level evidence and maturity caveats.

## Family 295: XR WebView browser panels, native WebView bridges, and input surfaces

This family covers XR browser-panel implementations where a native WebView or
browser surface is hosted by one layer, rendered into a texture or panel by
another, and connected to XR input and focus management through explicit
adapters. The reusable lesson is to keep browser core, transport, and
interaction wiring separate.

| Project | Status | Notes |
|---|---|---|
| `rwpersson/OpenWebView-Unity` | Studied in Wave 316 | Android `WebView` via `Presentation`/`VirtualDisplay`, texture transport, broad event/policy callbacks, and browser-core versus XR panel split |
| `t-34400/SimpleUnity3DWebView` | Studied in Wave 316 | Compact browser manager with pointer source, Java bridge, and texture updater for a minimal 3D browser panel |
| `vuplex/meta-xr-webview-example` | Source-light integration sample in Wave 316 | Meta XR browser-panel scene wiring and prefab-level setup rather than browser-core donor logic |
| `vuplex/xr-interaction-webview-example` | Source-light integration sample in Wave 316 | XRI tracked-device raycaster, event-camera, and world-space browser wiring expectations |

### Consolidation note

This family matters because XR browser surfaces should name:

- native page host versus engine-facing panel ownership;
- texture capture or transport path;
- pointer-to-UV and keyboard/focus routing;
- JS/app message and browser callback surfaces;
- browser permissions, downloads, file chooser, and external-link policy;
- XR interaction-stack adapters rather than implicit prefab assumptions.

It suggests a stronger branch inside `VR-apps-lab` around:

- native Quest/Android browser shells;
- keyboard/focus ownership patterns for world-space browser panels;
- XRI and other engine/browser integration checklists;
- transport-layer comparisons such as CPU copy versus GPU/zero-copy paths;
- browser utility panels for docs, operators, dashboards, and remote control.

## Family 296: VR notification, chat overlays, and local message relay sidecars

This family covers VR notification utilities that ingest phone, desktop, or
chat events and relay them into OpenVR, XSOverlay, OVR Toolkit, or similar
surfaces. The reusable lesson is to separate source adapters, privacy policy,
delivery queue, renderer, and target sink.

| Project | Status | Notes |
|---|---|---|
| `BOLL7708/TwitchVRNotifications` | Studied in Wave 317 | Twitch chat ingest, reconnect behavior, auth/local-secret handling, card rendering, and OpenVR notification emission |
| `balazs565/PhoneNotificationsVR` | Studied in Wave 317 | Layered source contract, bounded queue, filter/history policy, overlay anchoring, and supervisor loops |
| `tyunta/notifyxsoverlay` | Studied in Wave 317 | WinRT notification ingest, dedupe, learning-mode filters, config hygiene, startup manifest helpers, and XSOverlay WebSocket relay |
| `NekoSuneProjects/vrnotications` | Studied in Wave 317 | Minimal XSOverlay/OVR Toolkit/desktop adapters and reusable image normalization across payload forms |

### Consolidation note

This family matters because notification tools should name:

- event-source contract and source-merging policy;
- allow/block or learning-mode privacy filters;
- queue/drop semantics and history retention;
- card/payload rendering versus sink transport;
- startup/autostart/runtime supervision;
- trust and auth assumptions for local relay endpoints.

It suggests a stronger branch inside `VR-apps-lab` around:

- notification-source adapters for phone, desktop, and audience/chat inputs;
- privacy-aware relay defaults and filter UX;
- bounded event-queue helpers for overlays and micro-panels;
- OpenVR versus XSOverlay target capability comparisons;
- small message-to-overlay bridges for situational HUDs and operator tools.

## Family 297: Runtime launch sidecars, overlay autostart, and session operator helpers

This family covers runtime-adjacent helpers that watch VR runtime state, start
or stop supporting processes, switch runtimes safely, expose operator surfaces,
or guide session bring-up. The reusable lesson is to separate runtime
observation, task policy, runtime switching, and operator-facing helper UX.

| Project | Status | Notes |
|---|---|---|
| `dreiekk/OpenVR-Autostarter` | Studied in Wave 318 | OpenVR runtime polling, manifest registration, autostart, and configurable start/stop task policy |
| `Eidenz/monadeck` | Studied in Wave 318 | Backup-safe OpenXR runtime switching, Steam/game inventory, install/orchestration helpers, and shared desktop plus in-headset control shell |
| `Eidenz/monado-frame` | Studied in Wave 318 | File-decoupled screenshot/gesture helper, overlay UI, async processing, and libmonado-based input arbitration |
| `EllieWasteland/CaronteLauncherVR` | Source-light product reference in Wave 318 | Runtime selection, capture-path selection, profile/addon loading, and bring-up wizard framing |

### Consolidation note

This family matters because runtime operator helpers should name:

- runtime detection and activation hooks;
- manifest/autostart registration versus session polling;
- task registry plus start/stop/kill policy;
- backup/restore and rollback-safe runtime switching;
- file-coupled overlay or helper contracts;
- operator-facing wizard or control-panel UX for bring-up and recovery.

It suggests a stronger branch inside `VR-apps-lab` around:

- runtime lifecycle watchers and launch coordinators;
- backup-safe OpenXR runtime switchers;
- overlay-sidecar helpers that watch files or runtime state;
- operator bring-up wizards for capture/runtime/profile selection;
- input-arbitration patterns tied to runtime client state instead of app-name heuristics.

## Family 298: Stereo display-surface viewers, depth conversion, and spatial-display runtimes

This family covers viewer-style utilities that ingest flat or stereo content,
apply depth or display transforms, and present it through explicit runtime or
display-geometry models. The reusable lesson is to separate content ingress,
transform pipeline, live control plane, and display/view-rig ownership.

| Project | Status | Notes |
|---|---|---|
| `Bastian-Noel/DepthVistaXR` | Studied in Wave 319 | Desktop/window ingress, depth-estimation stage, threaded OpenXR output, backend ladder, and live controls |
| `BerZerker96/Osiris-Vr-Viewer` | Studied in Wave 319 | Persistent preset plus shared-memory live override split and viewer-versus-GUI process boundary |
| `DisplayXR/displayxr-unity` | Studied in Wave 319 | Camera-centric versus display-centric rigs, provider tunables, explicit display geometry, and local-2D composition layer |
| `DisplayXR/displayxr-demo-gaussiansplat` | Studied in Wave 319 | Compact display-centric viewer with focus/orbit controls, transparent layering, and runtime-owned display geometry |

### Consolidation note

This family matters because display-surface viewers should name:

- source ingress such as desktop capture, stereo input, or runtime-native content;
- transform stage such as depth estimation, stereo conversion, or display-rig projection;
- persistent preset store versus live override/control channel;
- explicit display/view-rig geometry ownership;
- 2D/HUD composition layered over 3D content;
- viewer interaction controls such as orbit, focus, zoom, and recenter.

It suggests a stronger branch inside `VR-apps-lab` around:

- desktop-to-VR viewer shells and backend fallback ladders;
- shared-memory or other control-plane patterns for viewer utilities;
- spatial-display runtime notes and `XR_EXT_view_rig`-style abstractions;
- local 2D-over-3D composition helpers;
- display-centric product references for single-surface XR utilities.

## Family 299: Declarative overlay frameworks, free overlay shells, and spatial manipulation clients

This family covers overlay and spatial UI shells that expose reusable
composition boundaries instead of only shipping one finished utility. The
reusable lesson is to keep UI composition, render/layer trees, runtime overlay
submission, placement mode, and spatial manipulation adapters separate.

| Project | Status | Notes |
|---|---|---|
| `sumx21t-3310/FloatSoda` | Studied in Wave 320 | Flutter-like SteamVR overlay framework with widget/render/layer separation and dashboard/world/device-tracked window types |
| `DelfinVT-uwu/FreeOverlay` | Studied in Wave 320 with maturity caveats | Free/open overlay shell with themes, media, notifications, calendar/reminders, and monolithic Python-script caveats |
| `Schmarni-Dev/absolute-solver` | Studied in Wave 320 | StardustXR spatial manipulation client with hand/tip selection rays, object capture, mover flow, and model/line feedback |

### Consolidation note

This family matters because overlay shells should name:

- declarative UI/widget model versus runtime overlay identity;
- render object/layer tree versus GPU texture submission;
- dashboard, world-space, device-tracked, or spatial-object placement mode;
- input dispatch and controller/hand/ray adapters;
- theme, persistence, media, and notification source boundaries;
- maturity caveats for compact prototype shells.

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable SteamVR overlay UI frameworks;
- headset companion shells with explicit source adapters;
- StardustXR-style spatial manipulation clients;
- overlay framework comparisons across retained, immediate, and declarative
  approaches.

## Family 300: SteamVR performance HUDs, sensor fan-in, and overlay QoL patch packs

This family covers small operator overlays and patch packs that reveal how VR
users monitor and tune their sessions. The reusable lesson is to keep telemetry
providers, metric aggregation, HUD rendering, overlay placement, settings, and
patch-friction evidence separate.

| Project | Status | Notes |
|---|---|---|
| `Karlan-Trade/VR-Performance-Profiler` | Studied in Wave 321 | SteamVR HUD with HWiNFO/MSI/SteamVR providers, metric aggregation, OpenVR overlay manager, D3D/Direct2D rendering, and settings/tray split |
| `chaixshot/xsoverlay-tweak` | Studied in Wave 321 | XSOverlay BepInEx/Harmony patch pack mapping pointer, wrist, keyboard, haptic, overlay attach, WebView, and refresh-rate friction |

### Consolidation note

This family matters because operator HUDs and overlay patches should name:

- sensor provider contracts and fallback behavior;
- metric normalization, preference scoring, and configured selection;
- renderer versus runtime overlay manager ownership;
- tray/settings surfaces and SteamVR readiness checks;
- UX friction evidence from patch packs;
- version fragility for app-internal patches.

It suggests a stronger branch inside `VR-apps-lab` around:

- performance and device-monitor overlay panels;
- provider fan-in libraries for headset HUDs;
- XSOverlay friction matrices;
- operator-facing settings/tray controls for VR utilities.

## Family 301: XSOverlay companion bridges, phone notifications, and translation-control sidecars

This family covers companion apps that bridge external events, phone
notifications, translation state, or desktop controls into XSOverlay-facing
workflows. The reusable lesson is to separate source permissions, local relay,
payload mapping, reconnect policy, privacy, and tray/operator UI.

| Project | Status | Notes |
|---|---|---|
| `jonreeve/NotifyXso` | Studied in Wave 322 | Android notification listener plus Ktor HTTP relay and UDP XSOverlay message mapper |
| `Daniel81i/YncneoXSOBridge` | Studied in Wave 322 | Translation/control bridge with registry port discovery, WebSocket reconnect handling, tray status, logging, and global-state caveats |

### Consolidation note

This family matters because XSOverlay companions should name:

- source app permission and privacy boundary;
- local HTTP/WebSocket/UDP relay contract;
- payload and icon normalization;
- reconnect and stale-state handling;
- tray/status/operator controls;
- log retention and trust assumptions.

It suggests a stronger branch inside `VR-apps-lab` around:

- phone-to-overlay relay scaffolds;
- translation and caption companion bridges;
- XSOverlay payload/transport comparisons;
- privacy-aware local sidecar templates.

## Family 302: Narrow OpenXR API layers, cockpit anchors, inline profilers, and game injection toolkits

This family covers invasive but bounded runtime/game-layer tools that add one
clear capability while keeping hook points and heavy processing explicit. The
reusable lesson is to keep runtime interception narrow and move policy, UI,
logging, profiling, or media processing into separated components.

| Project | Status | Notes |
|---|---|---|
| `Majed6/KATOXR` | Studied in Wave 323 | OpenXR treadmill-to-stick micro-layer with action interception, HMD-relative remapping, calibration, and trailing stop |
| `robogears/cockpit-anchor` | Studied in Wave 323 | Seated cockpit anchoring API layer with STAGE anchor capture, LOCAL rebasing, hotkeys, audio feedback, and per/shared anchor files |
| `mledour/xrprof` | Studied in Wave 323 | Inline API-layer profiler with CPU/GPU RAII scopes, D3D11/D3D12 attach points, frame commit, and CSV output |
| `AndrewAltimit/game-mods` | Studied in Wave 323 | Minimal-injection toolkit with daemon/injector/overlay split, IPC, shared memory, video decode, and hook templates |

### Consolidation note

This family matters because runtime/game-layer helpers should name:

- exact API hook/interception points;
- external data or daemon source;
- calibration, anchor, or profiling state;
- persistent files and bypass/rollback controls;
- injected-process budget and crash-isolation policy;
- diagnostics, logs, and operator feedback.

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR input remapping micro-layers;
- seated/cockpit anchoring and calibration helpers;
- API-layer profiling utilities;
- minimal-injection game overlay architectures.

## Family 303: VRChat parameter state dashboards and local web control mirrors

This family covers dashboard utilities that persist runtime/avatar state and
mirror the same control model into a local browser surface. The reusable lesson
is to keep runtime discovery, typed state snapshots, profile persistence,
dashboard controls, and local web APIs separate.

| Project | Status | Notes |
|---|---|---|
| `I5UCC/ParameterSaveStates` | Studied in Wave 324 | SteamVR dashboard plus local Web UI for VRChat per-avatar parameter profiles with OSCQuery discovery, typed replay, filters, auto-sync, export/import, and SSE updates |

### Consolidation note

This family matters because state/profile dashboards should name:

- runtime discovery and current-object identity;
- typed state snapshot and replay;
- profile persistence and ordering;
- apply filters, exclusions, and auto-sync policy;
- headset dashboard versus browser/control mirror;
- export/import and destructive-action safeguards.

It suggests a stronger branch inside `VR-apps-lab` around:

- reusable VR utility state/profile managers;
- dashboard plus local-web companion shells;
- profile import/export safety patterns;
- runtime object identity and typed-setting replay.

## Family 304: SteamVR hardware provisioning, session autolaunch, and Watchman dongle utilities

This family covers small hardware/session helpers that make VR runtime bring-up
or device provisioning easier. The reusable lesson is to separate hardware
detection, target selection, command execution, irreversible warnings,
firmware/artifact provenance, and operator fallback controls.

| Project | Status | Notes |
|---|---|---|
| `The-Graze/PSVR2-SteamVR-AutoLaunch` | Studied in Wave 325 | PSVR2 USB-triggered SteamVR tray autolaunch helper with WMI watcher, single-instance guard, manual launch, and SteamVR URI startup |
| `ykeara/SteamVR-Dongle-Flash` | Studied in Wave 325 | Source-light Watchman dongle flashing guide/script with permanent-action warnings and hardcoded default SteamVR path caveats |
| `ugokutennp/flowing-dongle-ccd` | Studied in Wave 325 as hardware reference | DIY multi-device Watchman dongle artifact bundle with nRF52840/USB hub hardware, PCB/case/BOM outputs, and firmware-source caveats |

### Consolidation note

This family matters because VR hardware helpers should name:

- stable device identification and inventory;
- launch/provision action and manual fallback;
- dry-run or explicit target selection;
- destructive or irreversible action warnings;
- firmware, PCB, case, and BOM provenance;
- path/runtime assumptions and diagnostics.

It suggests a stronger branch inside `VR-apps-lab` around:

- session bring-up microhelpers;
- SteamVR hardware provisioning safety checklists;
- dongle/tracker hardware artifact comparisons;
- operator-facing readiness and rollback UX.

## Family 305: KAT Walk Linux locomotion overlay and OpenXR layer split

This family covers hardware sensor utilities that split device IO, locomotion
logic, HUD rendering, and OpenXR runtime integration into separate components.
The reusable lesson is to keep the daemon and HUD brain outside the game
process while using a narrow OpenXR layer for injection, poses, composition,
and click transport.

| Project | Status | Notes |
|---|---|---|
| `BBPSBB/katwalk-linux` | Studied in Wave 326 | Linux KAT Walk C2+ daemon plus OpenXR implicit layer with USB parser, locomotion fusion, shared-memory buses, web tuner, pure-Pillow HUD, wrist placement, and laser/click return path |
| `Kiichiuwu/WTVFSVR-war-thunder-virtual-flight-stick-for-vr` | Empty/source-light in Wave 326 | Virtual flight-stick overlay product-intent marker with no donor code found |

### Consolidation note

This family matters because hardware locomotion/HUD tools should name:

- hardware reader and protocol parser;
- locomotion or control model;
- head/body/reference fusion;
- daemon control plane and web tuner;
- shared-memory transport schema;
- pure HUD renderer versus OpenXR composition/input layer;
- N=1 hardware and runtime/container caveats.

It suggests a stronger branch inside `VR-apps-lab` around:

- OpenXR-first utility HUDs without SteamVR overlays;
- hardware sensor daemon architectures;
- shared-memory layer/daemon protocols;
- in-VR tuning panels with clear operator feedback.

## Family 306: Window mirror managers, capture/remix surfaces, and stream-safe overlay pipelines

This family covers utilities that manage live desktop/window surfaces for
streaming, reference views, or remixable capture channels. The reusable lesson
is to keep the mirror worker, launch ownership, sink/tile registration,
watchdog, and manager UI separate.

| Project | Status | Notes |
|---|---|---|
| `aguirretim/apollo-mirror-manager` | Studied in Wave 327 | PowerShell/WinForms DWM mirror manager with persistent mirror surface, virtual-display detection, target handoff file, debounced teardown, watchdog/PID fallback, Apollo tile manager, and ownership markers |
| `PhotonIO/RemixPlayer` | Source-light in Wave 327 | README-only capture/remix concept for VR, overlays, replay files, graphics captures, FPS, and performance metrics as separate viewer-remix channels |

### Consolidation note

This family matters because mirror/capture surface tools should name:

- source window/process resolver;
- persistent mirror or capture surface;
- virtual display or overlay sink;
- launch and close ownership policy;
- watchdog and health/repair controls;
- config backup and tile/source registration;
- channel/schema model for recorded overlay/session data.

It suggests a stronger branch inside `VR-apps-lab` around:

- stream-safe reference-window utilities;
- desktop/window mirror workers for VR companion panels;
- launch ownership markers for session helpers;
- channelized VR session recording and remix concepts.

## Family 307: VRChat communication, translation, media, and notification OSC companions

This family covers VRChat companion tools that route speech, translation,
media state, desktop notifications, and avatar parameters through explicit
communication channels. The reusable lesson is to separate source adapters,
provider calls, routing policy, chatbox output, subtitle/overlay output, and
avatar-parameter output.

| Project | Status | Notes |
|---|---|---|
| `PaciStardust/HOSCY` | Studied in Wave 328 | Modular communication/OSC companion with recognition providers, Whisper subprocess IPC, OSC routing/OSCQuery, output preprocessors, counters, AFK, TTS, and legacy-config migration |
| `kapitalismho/PuriPuly-heart` | Studied in Wave 328 | LLM two-way translator with self/peer channel separation, subtitle overlay, provider routing, brokered key flow, cost framing, and privacy caveats |
| `VespeiProjects/SpotifyOSC` | Studied in Wave 328 | WPF Spotify/status-to-chatbox microtool with process polling, settings, prefix/save options, and system-stat fallback |
| `shadorki/vrc-osc-discord-band` | Studied in Wave 328 | Windows notification to avatar bracelet OSC utility with Discord classification, port config, and Unity avatar setup |

### Consolidation note

This family matters because VR communication helpers should name:

- source adapter and microphone/notification/media privacy;
- provider module and cloud/local boundary;
- self versus peer output channel;
- chatbox, subtitle, overlay, and avatar-parameter sinks;
- OSCQuery/OSC routing and rate limits;
- config migration and operator toggles.

It suggests a stronger branch inside `VR-apps-lab` around:

- accessibility subtitle companions;
- safe chatbox composers;
- avatar-wearable notification tools;
- provider-pluggable speech and translation utilities.

## Family 308: SteamVR runtime settings, recovery, and WMR patch microtools

This family covers tiny SteamVR maintenance utilities that toggle runtimes,
patch settings, recover sessions, or edit driver configuration. The reusable
lesson is to keep discovery, mutation, process control, recovery, config
persistence, and rollback/operator feedback separate.

| Project | Status | Notes |
|---|---|---|
| `demonixis/SteamVREnabler` | Studied in Wave 329 | WinForms SteamVR runtime folder toggle and process kill switch based on `openvrpaths.vrpath` |
| `ZipFile/ovr-update-settings` | Studied in Wave 329 | OpenVR `IVRSettings` CLI for get/set/delete/add/neg operations with type inference |
| `Raphiiko/Raphiis-SteamVR-Crash-Recovery` | Studied in Wave 329 | Rust SteamVR/VRChat crash recovery helper with latest-world log parsing and relaunch |
| `Burnt-Delta/ez-wmr` | Studied in Wave 329 | WMR SteamVR driver settings patcher for thumbstick controls with direct config writes |

### Consolidation note

This family matters because runtime/config microtools should name:

- runtime and path discovery;
- target process/config identity;
- typed settings API versus raw file patching;
- graceful shutdown and forced-kill policy;
- dry-run, backup, restore, and rollback;
- visible target/relaunch feedback.

It suggests a stronger branch inside `VR-apps-lab` around:

- SteamVR config patch safety checklists;
- recovery operators for VR sessions;
- typed settings CLIs;
- runtime/path doctor tools.

## Family 309: SteamVR device provisioning, base-station diagnostics, and visual asset patchers

This family covers SteamVR hardware and resource helpers for dongle flashing,
base-station diagnostics, and icon/render-model replacement. The reusable
lesson is to expose target identity, action prerequisites, provenance,
diagnostics, backup, restore, and irreversible-action warnings.

| Project | Status | Notes |
|---|---|---|
| `jaki-gh/Viva-Dongle-Flasher` | Studied in Wave 330 | Python GUI Watchman dongle flasher with SteamVR firmware zip lookup, UF2 generation, drive selection, and disabled flash actions until prerequisites exist |
| `TerayTech/SteamVR_BaseStation2.0_Diagnostic_Tool` | Studied in Wave 330 | Base-station serial diagnostic viewer with worker queues, parser categories, status thresholds, and bounded logs |
| `nicolas-riera/SteamVR-IconsSwitcher` | Studied in Wave 330 | SteamVR icon resource patcher with registry path lookup, current-state detection, and update-overwrite caveats |
| `nicolas-riera/SteamVR-RenderModelSwitcher` | Studied in Wave 330 | SteamVR render-model resource patcher with Quest/Vive asset trees, state detection, and destructive replacement caveats |

### Consolidation note

This family matters because hardware/resource patchers should name:

- physical target and removable-drive identity;
- firmware/resource provenance;
- disabled actions until prerequisites are satisfied;
- serial diagnostics and bounded logs;
- backup/restore and update overwrite handling;
- irreversible operation copy.

It suggests a stronger branch inside `VR-apps-lab` around:

- SteamVR hardware doctor surfaces;
- target-aware firmware/provisioning helpers;
- reversible SteamVR resource patchers;
- visual device-identity customization notes.

## Family 310: Overlay surface proxies, dashboard notifications, hand redirection, and tracker recording utilities

This family covers utilities that proxy desktop surfaces into VR-compatible
windows, render dashboard notifications, redirect hand targets, or record
tracker data. The reusable lesson is to keep source discovery, render/capture
backend, output surface, runtime manifest, remote transport, interaction
algorithm, tracker identity, and recording/replay separate.

| Project | Status | Notes |
|---|---|---|
| `Eldon27232/KugouLyricsMirror` | Studied in Wave 331 | Desktop lyrics/window proxy with HWND capture, PrintWindow/BitBlt fallback, DWM proxy mode, chroma-key/region fallback, and normal top-level VR capture target |
| `ZephyrVR/tempest-overlay` | Studied in Wave 331 | Older Qt/OpenVR dashboard overlay with manifest/autolaunch, QML-to-FBO texture submission, overlay events, keyboard integration, token watching, and Socket.IO notifications |
| `AndreZenner/hand-redirection-toolkit` | Studied in Wave 331 | Unity hand redirection toolkit with RedirectionManager, HandRedirector classes, real/virtual target links, edit-mode analysis, visualization, packages, and movement logging |
| `Avdbergnmf/SteamVR-Utils` | Studied in Wave 331 | Unity SteamVR tracker utilities with serial mapping, assignment UI, threaded pose recording, circular queues, UXF seams, and replay scaffolding |

### Consolidation note

This family matters because proxy/interaction/data utilities should name:

- source resolver and output sink;
- capture/render backend and compatibility rules;
- manifest/autolaunch and remote event transport;
- interaction algorithm and provider add-ons;
- tracker identity and assignment UI;
- recording schema, replay maturity, and analysis visualization.

It suggests a stronger branch inside `VR-apps-lab` around:

- VR-capturable desktop proxy windows;
- dashboard notification overlays;
- hand-retargeting/interaction evaluation tools;
- tracker recording and replay helpers.

## Family 311: A-Frame VR UI primitives, DOM surfaces, and in-scene input widgets

This family covers browser-native UI primitives for WebXR/A-Frame utilities:
HTML surfaces, layout widgets, text entry, virtual keyboards, and contextual
dialogs. The reusable lesson is to keep surface rendering, layout, input
capture, keyboard dispatch, popup lifecycle, and application data separate.

| Project | Status | Notes |
|---|---|---|
| `supereggbert/aframe-htmlembed-component` | Studied in Wave 332 | HTML-to-canvas/texture A-Frame surface with raycaster coordinate mapping, DOM mutation redraws, focus/input forwarding, and CSS state hacks |
| `binzume/aframe-xylayout` | Studied in Wave 332 | A-Frame flex-like layout and widgets with xycontainer, xyinput, labels, rounded rects, copy/paste, caret, keyboard request events, and haptic hover cues |
| `WandererOU/aframe-keyboard` | Studied in Wave 332 | Compact virtual keyboard with template rendering, desktop/VR event forwarding, locale hooks, and button feedback |
| `EditVR/aframe-dialog-popup-component` | Studied in Wave 332 | Configurable dialog popup with opener/close icons, title/body/image composition, and camera-facing placement |

### Consolidation note

This family matters because WebXR utilities often need overlay-like panels
without native overlay APIs. It suggests a stronger branch around:

- browser-native utility panels;
- reusable VR text-entry surfaces;
- contextual help and annotation dialogs;
- WebXR settings/debug panels.

## Family 312: WebXR capability probes, pass-through testbeds, and utility labs

This family covers static browser-side XR doctors, capability report pages, AR
placement helpers, pass-through/video plane experiments, and thin utility lab
surfaces. The reusable lesson is to separate feature collection, report/export,
rendering experiments, and product-lab positioning.

| Project | Status | Notes |
|---|---|---|
| `rwth-acis/i5-Toolkit-for-WebXR` | Studied in Wave 333 | WebXR helper toolkit with hit-test placement, boundary/edit helper, and loading indicator classes |
| `gareth-morgan-nv/WebXR-utils` | Studied in Wave 333 | Browser capability matrix with spec links, timeout checks, JSON export, and WebGL pass-through plane testbed |
| `webvrdev/webvrdev-labs` | Thin reference in Wave 333 | Public lab positioning reference; no donor code in current clone |

### Consolidation note

This family matters because browser XR capability pages can become a lightweight
preflight diagnostic layer before native tooling. It suggests a branch around:

- headset browser capability reports;
- WebXR pass-through/video surface experiments;
- browser-only XR doctors;
- public utility lab indexes.

## Family 313: Godot XR hand poses, menus, spatial entities, and Android surface bridges

This family covers Godot OpenXR interaction and surface utilities: semantic hand
pose recognition, auto hand tracking, radial menus, wrist UIs, spatial entities,
persistent anchors, and Android surface/plugin bridges. The reusable lesson is
to keep tracker discovery, semantic gesture state, UI selection, spatial
persistence, native Android work, and app content separate.

| Project | Status | Notes |
|---|---|---|
| `Malcolmnixon/GodotXRHandPoseDetector` | Studied in Wave 334 | Hand pose resources with fitness functions, palm tracking gates, hold/release timing, and semantic pose signals |
| `Godot-Dojo/Godot-XR-AH` | Studied in Wave 334 | Auto hand tracker, controller fallback, OpenXR joint mapping, radial menu ray selection, and spatial anchor glue |
| `BastiaanOlij/spatial-entities-demo` | Studied in Wave 334 | Spatial entity manager, persistent UUID-to-scene mapping, anchor child scenes, and wrist SubViewport touch UI |
| `GodotVR/godot-openxr-android-surface-plugin-example` | Studied in Wave 334 | Android surface composition-layer example with Godot plugin/Kotlin MediaPlayer handoff |
| `yelrom0/godot-openxr-notification-handler-plugin` | Thin/low maturity in Wave 334 | Notification plugin idea, but current code remains close to Android plugin template |

### Consolidation note

This family matters because Godot can support serious XR utility surfaces when
gestures, menus, spatial persistence, and Android native surfaces are treated as
separate layers. It suggests a branch around:

- Godot hand-only utility controls;
- radial and wrist menu patterns;
- persistent spatial annotation tools;
- Android media/notification surface bridges.

## Family 314: Unity XR research templates, telemetry scaffolds, and controller baselines

This family covers Unity XR research scaffolds, base scenes, player/data/scene
manager splits, continuous logging, experiment flow, and minimal controller
baselines. The reusable lesson is to keep player state, data collection, scene
flow, calibration, experiment flow, and vendor SDK integration separate.

| Project | Status | Notes |
|---|---|---|
| `TAU-XR/TAUXR-Research-Template` | Studied in Wave 335 | Unity XR research template with TXR player, data manager, scene manager, continuous CSV logging, hand/eye/face data, calibration, and Meta Interaction SDK coexistence |
| `TAU-XR/TAUXR-OpenTemplate` | Studied in Wave 335 | Open template variant with the same base-scene/data-manager shape plus sample scenes and Quest/vendor package caveats |
| `dilmerv/XRToolKitPlayerController` | Studied in Wave 335 | Minimal XR player controller with XRNode device lookup, joystick movement, jump gating, rigidbody/capsule setup, and scene/component tests |
| `traggett/UnityXRInteractionToolkitExtensions` | Rejected in Wave 335 | Empty repository; no code donor value |

### Consolidation note

This family matters because research-oriented VR apps need reusable telemetry
and scene-flow scaffolding before the actual experiment logic. It suggests a
branch around:

- experiment-ready base scenes;
- transform/eye/face/event CSV logging;
- session/trial/round flow managers;
- lightweight controller and smoke-test baselines.

## Family 315: Headsetless XR simulator harnesses and runtime/operator workflows

This family covers no-headset XR development support across runtime-level
OpenXR simulators, engine/editor simulator plugins, starter templates, and
runtime selector/operator surfaces. The reusable lesson is to keep simulated
device state, input adapters, runtime/engine registration, replay, and app
logic separate.

| Project | Status | Notes |
|---|---|---|
| `jrng/openxr_simulator` | Studied in Wave 336 | Runtime-level OpenXR simulator with loader negotiation, stereo views, swapchains, D3D11/OpenGL, keyboard/mouse pose driving |
| `Cafezinhu/godot-vr-simulator` | Studied in Wave 336 | Godot editor autoload that injects XRCamera3D/XRController3D tracker poses and OpenXR action-map inputs |
| `sanky369/OpenXRSim` | Studied in Wave 336 | Unreal simulator plugin with XR system/input-device split, Slate panel, room JSON, XInput, UDP forwarding, and record/replay |
| `kcking/bevy_xr_app` | Studied in Wave 336 | Bevy starter template with simulator/editor/Quest/PCVR mode separation |
| `demonixis/OpenXR-OSX` | Architecture reference in Wave 336 | OXRSys runtime/operator surface with runtime JSON selection, Home apps, headset clients, Unity helper, and simulator windows |

### Consolidation note

This family matters because simulator support can become a repeatable
development and diagnostics utility branch. It suggests a stronger branch
around no-headset XR doctors, pose/action replay schemas, editor/runtime
registration safety, and live forwarded tracker/controller input.

## Family 316: OpenVR notification primitives, overlay wrappers, and OS notification bridges

This family covers the path from minimal `IVRNotifications` samples to full
Windows notification overlay applications. The reusable lesson is to separate
source permissions, notification policy, queue/history, rendering, OpenVR
overlay calls, dashboard settings, and packaging.

| Project | Status | Notes |
|---|---|---|
| `AlexMcArdle/openvr-notifications` | Thin marker in Wave 337 | README-level phone-to-OpenVR direction; no current implementation donor |
| `BOLL7708/OpenVRNotificationTest` | Studied in Wave 337 | Minimal C# OpenVR notification primitive with overlay handle, bitmap preparation, and `CreateNotification` |
| `erenoa-6621/vr-notification-overlay` | Studied in Wave 337 | Windows notification listener to OpenVR overlay pipeline with filters, queue, history, settings, dashboard overlay, and packaging |
| `OVRTools/OVRSharp` | Studied in Wave 337 | C# OpenVR overlay wrapper for app init, overlay handles, transforms, textures, alpha/curvature/mouse scale, and events |

### Consolidation note

This family matters because notification utilities need privacy-safe product
logic as much as overlay rendering. It suggests a branch around OS notification
consent/filter policy, persistent cards versus transient notifications,
dashboard settings panels, and OpenVR wrapper ergonomics.

## Family 317: Browser VR video players, projection modes, and media-library surfaces

This family covers WebXR/WebVR media players, projection metadata, stereo
layout handling, source catalogs, and in-headset media-library UX. The reusable
lesson is to keep media metadata, projection rendering, source discovery,
catalog generation, controls, and browser capability checks separate.

| Project | Status | Notes |
|---|---|---|
| `TimoWilhelm/vr-player` | Studied in Wave 338 | Modern WebXR player with mono/SBS/TB layout enums, worker layout detection, file/URL input, and frame-aware texture upload |
| `Bivrost/360WebPlayer` | Studied in Wave 338 | Mature embeddable 360 player with declarative config, mono/stereo pictures/video, HLS, input modules, and compatibility matrix |
| `michal-repo/web_vr_video_player` | Studied in Wave 338 | In-headset media library with JSON catalogs, thumbnails, search/sort, VR keyboard, draggable panels, and projection switching |

### Consolidation note

This family matters because media/viewer utilities often need projection
correctness and source browsing before advanced features. It suggests a branch
around projection-aware media descriptors, WebXR video surface renderers,
in-headset file/source browsers, and browser CORS/HTTPS preflight UX.

## Family 318: Unreal vendor OpenXR interaction samples and feature bridges

This family covers Unreal/vendor sample projects for controller, hand, body,
eye, and mixed-reality feature surfaces. The reusable lesson is to keep vendor
plugin setup, tracked data acquisition, interaction semantics, rendering/debug
visualization, scene routing, and sample content separate.

| Project | Status | Notes |
|---|---|---|
| `picoxr/PICO_UE5_OpenXRSample` | Studied in Wave 339 | PICO UE5 sample with hub, controller interactions, hand gestures, pinch grab, haptics, and full-body avatar tracking |
| `oculus-samples/Unreal-InteractionSDK-Sample` | Studied in Wave 339 | Meta Unreal Interaction SDK sample with explicit plugin/dependency and license boundaries |
| `demonixis/FSOpenXRHandTracking` | Studied in Wave 339 | Unreal hand tracking plugin with instanced/wireframe rendering, pinch, Enhanced Input, hand rays, and MetaXR skeleton bridge |
| `varjocom/VarjoUnrealOpenXRExamples` | Studied in Wave 339 | Varjo OpenXR example for pass-through, depth, foveation, markers, eye tracking, and hand tracking |

### Consolidation note

This family matters because vendor demos can teach feature decomposition even
when their assets are not reusable. It suggests a branch around Unreal XR
feature-demo hubs, hand-ray and pinch interaction components, vendor adapter
boundaries, and explicit hardware/license support labelling.

## Family 319: visionOS native rendering, WebXR probes, and XR provider boundaries

This family covers native and Unity/package-level visionOS projects that expose
compositor-facing rendering, ARKit world tracking, WebXR browser probes,
provider APIs, build processors, and validation rules. The reusable lesson is
to keep OS permission state, compositor lifecycle, rendering, browser probes,
resource packaging, and product microapps separate.

| Project | Status | Notes |
|---|---|---|
| `metal-by-example/metal-spatial-rendering` | Studied in Wave 340 | ARKit world tracking, CompositorServices frame timing, render thread, dedicated/layered drawables, per-view pose constants, vertex amplification, and mixed immersion |
| `chrisdubya/avp-threejs-webxr-test` | Studied in Wave 340 | Three.js WebXR hand/controller probe, pinch object spawn/grab/scale, fingertip collisions, and MediaRecorder microphone capture |
| `needle-mirror/com.unity.xr.visionos` | Studied in Wave 340 | Unity visionOS provider package with LayerRenderer access, authorization events, build processors, AR resource packaging, and project validation |
| `IvanCampos/visionOS-examples` | Studied in Wave 340 | SwiftUI/RealityKit microapps for head anchoring, battery/status, hand tracking, controllers, WebSocket feeds, chat/search, and music/countdown surfaces |

### Consolidation note

This family matters because visionOS utility work needs platform gates as much
as scene UI. It suggests a branch around:

- visionOS validation checklists;
- compositor/provider boundary notes;
- WebXR-on-visionOS capability probes;
- SwiftUI/RealityKit utility microapp references.

## Family 320: visionOS Unity plugin bridges, WebView surfaces, and controller adapters

This family covers Unity projects that adapt Apple framework plug-ins, web
panels, external controllers, and setup templates to Apple Vision Pro. The
reusable lesson is to keep native framework wrappers, build mutation, surface
UI, input adapters, permissions, and onboarding checklists separate.

| Project | Status | Notes |
|---|---|---|
| `apple/unityplugins` | Studied in Wave 341 | Apple.Core build/postprocess and native-wrapper architecture plus Accessibility, CoreHaptics, GameController, GameKit, PHASE, and SpatialController packages |
| `vuplex/visionos-metal-webview-example` | Studied in Wave 341 | Unity Metal-mode visionOS WebView scene with world-space Canvas, tracked-device raycaster, passthrough toggle, XR loaders, and mock editor fallback |
| `surreal-interactive/SDK` | Studied in Wave 341 | Surreal Touch controller SDK with OVR-style API mapping, SVRCameraRig, SVRInput layers, hand/controller mode switch, haptics, and Bluetooth plist postprocessor |
| `TonGarcia/UnityVisionVRTemplate` | Studied in Wave 341 | Unity visionOS checklist/template for ARKit/OpenXR/XR Hands/XRI/PolySpatial setup, URP/foveation/depth notes, and simulator workflow |

### Consolidation note

This family matters because platform-specific Unity utilities should be built
as adapter packages, not undocumented project mutations. It suggests:

- reusable platform-adapter checklists;
- visionOS WebView/browser-panel prototypes;
- Apple PHASE/CoreHaptics bridge comparisons;
- controller migration maps for non-hand input.

## Family 321: Spectator cameras, mixed-reality capture, and observer roles

This family covers simple spectator cameras, calibrated MRC stacks, companion
capture kits, and multiplayer observer roles. The reusable lesson is to keep
demo spectator views, calibrated capture, companion tooling, network transport,
recording, and observer authority separate.

| Project | Status | Notes |
|---|---|---|
| `Unity-Technologies/VR-Spectator-Sample` | Studied in Wave 342 | Minimal two-camera spectator rig with overlay-only UI camera, movable spectator camera, attachment points, preview displays, and replaceable visuals |
| `microsoft/MixedReality-SpectatorView` | Studied in Wave 342 | Calibration/intrinsics/extrinsics, spatial coordinates, QR/ArUco/ASA localization, compositor, pose cache, time sync, networking, and recording services |
| `Microsoft/MixedRealityCompanionKit` | Studied in Wave 342 | Companion toolkit with remoting, KinectIPD, remote compositor, spectator view, commander, asset bundler, spatial mapping, network state, and calibration zones |
| `spatialos/sdk-for-unity-vr-starter-project` | Studied in Wave 342 | Multiplayer VR starter with headset-player and spectator roles, replicated peripheral offsets, teleport, and server-validated grabbing |

### Consolidation note

This family matters because utility demos, streams, and operator tools need a
clear outside-the-headset view. It suggests:

- minimal spectator-camera components;
- MRC calibration provenance docs;
- observer/operator role models;
- capture stack comparison between legacy HoloLens and Vision Pro/iPhone flows.

## Family 322: Physics hands, two-hand interaction, and hand data capture

This family covers force/joint-driven hands, two-hand object interactions,
cross-platform hand subsystem APIs, hand capture/playback, and WebXR hand
prototype labs. The reusable lesson is to keep tracking source, hand
representation, physical actuation, semantic interaction, two-hand object
logic, capture/playback, and debug UI separate.

| Project | Status | Notes |
|---|---|---|
| `oxters168/VRPhysicsHands` | Studied in Wave 343 | Unity/Oculus physics hands controlled by forces/joints with bone values, emulator, input adapters, and grabber bridge |
| `emilyslouie/xri-two-hands` | Studied in Wave 343 | XRI two-hand prototypes with dynamic attach points, multi-grabbable objects, bow/arrow, staff/stick tools, pull measurement, and custom interaction manager |
| `needle-mirror/com.unity.xr.hands` | Studied in Wave 343 | Unity XR Hands package with subsystem/provider APIs, joints/mesh data, OpenXR features, gestures, recording, playback, coordinate transforms, and editor tooling |
| `sketchpunklabs/xrhand` | Studied in Wave 343 | WebXR hand prototype lab with input managers, controller/hand classes, slide locomotion, dynamic debug meshes, GLTF helpers, and prototype pages |

### Consolidation note

This family matters because hand utilities should not mix raw tracking, physics,
gestures, and grab rules. It suggests:

- two-hand tool interaction checklists;
- hand capture/replay diagnostics;
- physics-hand safety notes;
- browser/native hand data comparison matrices.

## Family 323: Molecular scientific visualization and interactive simulation viewers

This family covers scientific XR viewers that import domain files, render
molecular or scientific structures, play or stream trajectories, and expose
measurement or manipulation tools. The reusable lesson is to keep domain data
adapters, representation layers, simulation/session transport, VR input, and
measurement UI separate.

| Project | Status | Notes |
|---|---|---|
| `LBT-CNRS/UnityMol-Releases` | Studied in Wave 344 | Large molecular workbench with many file parsers, trajectory support, selection language, Python console, representations, save/load, and VR scenes |
| `ur-whitelab/simview` | Studied in Wave 344 | HOOMD/ZeroMQ viewer with frame queues, interpolated positions, particle names, bonds, GPU molecule updates, VR/AR scenes, and instructor view |
| `kwstanths/MRend` | Studied in Wave 344 | Minimal PDB parser/spawner baseline with ATOM/HETATM parsing and Angstrom-to-nanometer conversion |
| `WangLabforComputationalBiology/VisionMol` | Studied in Wave 344 | Quest protein viewer with representations, labels, distance measurement, molecule splicing, residue coloring, and VR manipulation |
| `RBVI/LookSee` | Studied in Wave 344 | ChimeraX-to-Quest GLTF handoff model using GLTFast and Oculus/OpenXR loaders |
| `IRL2/nanover-imd-vr` | Studied in Wave 344 | Interactive molecular dynamics client with service discovery, WebSocket/autoconnect, controller manager, passthrough, calibration, and commands |

### Consolidation note

This family matters because scientific VR tools need a reusable viewer shell
that can swap parser/transport modules without rewriting the interaction model.
It suggests a branch around domain-data adapters, measurement widgets,
trajectory/session playback, and remote simulation controls.

## Family 324: CAD BIM industrial XR and training workflows

This family covers engineering and industrial XR flows across model inspection,
CAD import/export, BIM metadata extraction, Revit/Archicad handoffs, task-based
training, LLM/STT assistant panels, and HMI dashboards. The reusable lesson is
to treat geometry, metadata, task state, annotations, edit logs, and
authoring-tool mutation as separate layers.

| Project | Status | Notes |
|---|---|---|
| `LukeA25/vrCadViewer` | Studied in Wave 345 | Quest CAD inspection app with grab, slice, explode, draw, pointer tools, EzySlice, and mode switching |
| `UnityCommunity/CADImportExport` | Source-light marker in Wave 345 | Runtime CAD import/export direction for Unity desktop and Quest/Android targets |
| `giorgosfatouros/XR2IND-VR` | Studied in Wave 345 | Industrial training with classrooms, task whiteboards, interactive routers/switches, STT, LLM REST panel, and RAG/manual dependency |
| `krishnahsanghani-netizen/visualyze-core` | Studied in Wave 345 | VR-to-Revit edit-log workflow with JSON edits, coordinate conversion, confirmation, and Revit transaction application |
| `isaddiq/BIMUniXchange` | Studied in Wave 345 | Revit/Archicad/Unity BIM pipeline with Archicad metadata extraction, CSV samples, and export summaries |
| `game4automation/realvirtual-WEB` | Studied in Wave 345 | Industrial HMI web surface with annotations, tooltips, sim controls, layout planner, MCP bridge, and Teams shell |

### Consolidation note

This family matters because XR engineering tools should be safe workbenches,
not direct destructive editors. It suggests a product branch around inspect,
slice, annotate, validate, write edit logs, and apply them through explicit
CAD/BIM adapters with rollback and provenance.

## Family 325: Accessibility low-vision audio haptics and sign-language VR tools

This family covers low-vision magnification, audio and haptic substitution,
accessibility game feedback, ASL/sign recognition, and finger alphabet
training. The reusable lesson is to keep capability sensing, accessibility
transforms, gesture validation, output surfaces, and privacy/consent separate.

| Project | Status | Notes |
|---|---|---|
| `microsoft/SeeingVRtoolkit` | Studied in Wave 346 | Accessibility toolkit with magnification shaders, post-process tools, bindings, and low-vision support framing |
| `SuHCI/MagniVR` | Studied in Wave 346 | Hand-held magnifier prototype with render textures, manager/prefab wiring, and SeeingVR-style tools |
| `xability/punch-pulse` | Studied in Wave 346 | Accessible boxing game with directional audio cues, boundary audio, menu toggles, haptics assets, and audio mixers |
| `hojats7731/VRSignify` | Source-light marker in Wave 346 | Quest 3 ASL-to-text direction with hand tracking and custom ML framing but limited visible donor scripts |
| `dillondrum70/ASL-Passthrough` | Studied in Wave 346 | HandPose/HandGesture assets, pose stack, hold/null-time gesture matching, two-hand gestures, and editor pose capture |
| `cpvrlab/vrTrainingFingerAlphabet` | Studied in Wave 346 | Finger alphabet trainer with saved hand forms, weighted orientation/finger/tip scoring, debug canvas, and virtual hand feedback |

### Consolidation note

This family matters because accessibility should be a reusable system layer.
It suggests a branch around magnifier surfaces, audio/haptic alternatives,
gesture-to-text pipelines, sign-learning validators, and explicit capability
and privacy defaults.

## Family 326: NeRF Gaussian splat and light-field VR viewers

This family covers nonstandard spatial media viewers where the main challenge
is separating asset discovery, loading, GPU/native rendering, stereo output,
locomotion, quality scaling, and platform caveats.

| Project | Status | Notes |
|---|---|---|
| `uhhhci/immersive-ngp` | Studied in Wave 347 | Unity/instant-ngp stereo NeRF renderer with native plug-in wrapper, external textures, GL plugin events, DLSS, locomotion, crop/FoV/edit concepts |
| `alexwing/nerf_Unity_VR` | Studied in Wave 347 | Smaller Unity NeRF VR scene shell with camera/depth scripts and Quest/URP settings |
| `zachdrouin/GaussianSplatViewer` | Studied in Wave 347 | Quest splat viewer with async PLY loader, Burst jobs, compute shaders, radix sort, culling, LOD/streaming, VR file browser, and locomotion |
| `julienkay/LightfieldVideoUnity` | Release-only marker in Wave 347 | Light-field video viewer concept for Quest/Rift with compiled releases and explicit proprietary playback caveats |

### Consolidation note

This family matters because spatial media viewers should share browsing,
navigation, capability, and performance shells even when the renderer changes.
It suggests a branch around a generic spatial-media descriptor and pluggable
NeRF/splat/light-field/panoramic render adapters.

## Family 327: Gaze eye analytics and XR behavior telemetry

This family covers live eye-tracker ingress, calibration, saccade/blink events,
offline fixation analysis, heatmaps, and product analytics. The reusable lesson
is to separate provider APIs, confidence filtering, event detection, local
analysis, hosted dashboards, and privacy gates.

| Project | Status | Notes |
|---|---|---|
| `MotorControlLearning/SaccadeVR-mobile` | Source-light marker in Wave 348 | Saccade study direction that reinforces protocol/detector/logging separation |
| `pupil-labs/hmd-eyes` | Studied in Wave 348 | Unity/Pupil network plug-in with request/subscription layers, calibration, gaze/pupil listeners, time sync, recording, annotations, screencast, and eye-frame display |
| `AndreZenner/saccade-detection` | Studied in Wave 348 | Vive Pro Eye saccade/blink detector with threshold tuning, events, test scenarios, logging, and replay/simulation hooks |
| `ViveSoftware/VRS-Studio-OpenXR` | Studied in Wave 348 | HTC OpenXR sample bundle with eye gaze plus facial/body tracking, Ultimate Tracker, spectator camera, and hand interaction |
| `Robertson-Lab/vrGazeCore-Toolbox` | Studied in Wave 348 | MATLAB/Python fixation and heatmap pipeline with confidence/headset parameters and time-segmented outputs |
| `GossipAnalyticsXR/Gossip_Analytics_Unity-SDK` | Studied in Wave 348 | Unity XR analytics package with auto trackers, heatmaps, device/session/performance trackers, settings, build checks, and uninstall flow |

### Consolidation note

This family matters because gaze telemetry can easily become privacy-sensitive
and vendor-locked. It suggests a branch around normalized gaze events, local
recording, offline heatmaps, UX diagnostics, and explicit consent/capability
labels.

## Family 328: Rehabilitation biofeedback and vestibular training loops

This family covers therapy-oriented VR/MR prototypes where body motion,
feet/controllers, EEG/biosignals, scent, and game tasks become progress and
training artifacts. The reusable lesson is the patient-task loop: calibrate,
guide, adapt, log, review, and keep claims bounded.

| Project | Status | Notes |
|---|---|---|
| `praggam/REVIRE` | Partially studied in Wave 349 | Quest rehab prototype with recording and LSL clues; queued for session/telemetry follow-up |
| `vladyslav-tsalko/REMIRE` | Partially studied in Wave 349 | Quest rehab app marker with APK/docs/source layout and exercise/logging follow-up value |
| `omarrayyann/A-Fine-Day` | Studied in Wave 349 | Stroke rehab minigames with Ultraleap, calibration, menu delay, motion graphs, and therapist progress framing |
| `aneall/NeuroScent` | Studied in Wave 349 | Multimodal biofeedback concept with OpenBCI Galea, Varjo Aero, scent output, and mental-wellbeing framing |
| `soheilbr82/Mind-Controlled-Virtual-Car` | Studied in Wave 349 | EEG/MATLAB-to-Unity control with SSVEP direction selection, SMR gating, command transport, and visual feedback |
| `JDGuldager/AR-and-VR-Application-for-Vestibular-Dysfunction-in-Elderly` | Studied in Wave 349 | Quest 3 vestibular rehab with foot-mounted controllers, frog/lily-pad stepping, VR/AR comparison, difficulty control, and safety evaluation |

### Consolidation note

This family matters because rehab tools need therapist-visible progress and
safety constraints, not only engaging scenes. It suggests reusable schemas for
calibration, difficulty, signal capture, progress graphs, and modality safety.

## Family 329: XR robotics operator cockpits and hand-pose streams

This family covers headset-driven robot operation across hand/head/controller
uplink, video/simulation downlink, robot adapters, safety gates, and
demonstration recording. The reusable lesson is that headset apps, transport,
robot SDKs, and recording pipelines should remain separate.

| Project | Status | Notes |
|---|---|---|
| `arghyasur1991/synth-vr` | Studied in Wave 350 | Quest MR humanoid package with hand-tracked MuJoCo bodies, MRUK colliders, passthrough, scene wizard, performance and permissions |
| `unitreerobotics/xr_teleoperate` | Studied in Wave 350 | Unitree AVP/PICO/Quest teleop framework with Vuer/WebRTC, robot/end-effector modes, simulation/physical deployment, recording, IPC, and safety |
| `Improbable-AI/VisionProTeleop` | Studied in Wave 350 | AVP hand/head streaming, video/audio/simulation return streams, MuJoCo/Isaac AR scenes, egocentric recording, cloud sync, and calibration |
| `XR-Robotics/XRoboToolkit-Unity-Client-Quest` | Studied in Wave 350 | Quest operator UI with network/tracking/video/recording/log controls, pause toggle, remote stereo vision, JNI/Android video plugin, and QoS split |
| `GeneralTrajectory/dex-teleop` | Studied in Wave 350 | Vive/Quest to xArm/Inspire teleop with bimanual support, HDF5 recording, workspace limits, collisions, and smooth re-engagement |
| `h2r/GHOST` | Studied in Wave 350 | Quest/Unity Spot teleop half with point-cloud visualization, gesture controls, URDF via ROSBridge, and ros_reality dependency |
| `wengmister/quest-wrist-tracker` | Studied in Wave 350 | Quest hand/wrist streaming appliance with 21 landmarks, 6DoF wrist pose, UDP/TCP, HUD/logs, video streaming, and Python SDK |

### Consolidation note

This family matters because robot operation is high-risk and latency-sensitive.
It suggests product branches around headset telemetry appliances, operator HUDs,
video panels, dry-run defaults, safety state machines, and dataset recorders.

## Family 330: Multisensory hardware feedback and output routers

This family covers VR/MR systems that route semantic scene events to scent,
thermal, tactile, drag/air-resistance, and robotic haptic hardware. The
reusable lesson is to keep event semantics, body targets, modifiers, device
adapters, safety limits, and consent separate.

| Project | Status | Notes |
|---|---|---|
| `mimuc/RoboThermalHaptics` | Studied in Wave 351 | Encountered-type thermal display with Kinova cobot, Vive Pro Eye, Ultraleap, VR/robot calibration, and Cobity dependency |
| `Ultimatonium/sensoricFramework` | Studied in Wave 351 | Unity sender/receiver/device framework for tactile, thermal, olfactory, bHaptics, Cilia, ThermoReal, manager singleton, and modifiers |
| `egekaraca/Multisensory-VR-Gardens` | Source-light marker in Wave 351 | Garden/therapy multisensory direction pending richer source evidence |
| `CUXR/Olfactory-Display` | Studied in Wave 351 | PCB/BOM scent display reference with XIAO Sense, MOSFETs, atomizers, converter, headers, batteries, and Gerbers |
| `jdthamores/BioEssence` | Studied in Wave 351 | Physio-olfactory wearable with cardio-respiratory sensing, three-scent output, electronics/case/app framing, and research positioning |
| `amarqu88/Multisensory-Proximity-and-Transition-Cues` | Studied in Wave 351 | Limited-FOV awareness study with visual/audio/tactile proximity and transition cues, Steam Audio, extOSC, Raspberry Pi vibration, and logs |
| `AndreZenner/dragon` | Studied in Wave 351 | Drag:on DIY controller with air-resistance/weight-shift haptics, Arduino, Unity serial package, circuit, 3D prints, tracker alignment, and patent caveat |

### Consolidation note

This family matters because physical feedback can be immersive and risky at
the same time. It suggests a reusable sensory event router with capability
labels, intensity/cooldown limits, device health, fallback cues, and explicit
consent.

## Family 331: Scientific dome planetarium and projection-surface viewers

This family covers VR/dome systems that combine sky or scientific data with
projection adapters, time/location state, and exhibit interaction. The reusable
lesson is to separate the domain provider from headset, dome, fisheye, or live
skybox output.

| Project | Status | Notes |
|---|---|---|
| `arcAstroVR/arcAstroVR` | Studied in Wave 352 | Stellarium bridge, watched skybox files, GIS/location conversion, marker/line editing, and domemaster output |
| `mymess/Planetarium` | Studied in Wave 352 | Local astronomy algorithms, sky/star models, and date/location/settings editors |
| `imclab/VR-Planetarium` | Studied in Wave 352 | Legacy Leap Motion planetarium with arm HUD, joyball interaction, constellation labels, and video toggles |
| `At-Bristol/DEV0006-DataDomeUnityToolkit` | Studied in Wave 352 | Dome toolkit with world/projection cameras, fisheye shader, cubemap capture, hotkeys, and settings persistence |

### Consolidation note

This family matters because scientific viewers often need multiple output
surfaces. It suggests adapters for sky providers, local astronomy engines,
projection rigs, and operator controls.

## Family 332: Workshop-grade exhibition gallery and depth-aware media spaces

This family covers VR exhibitions, galleries, museums, and content surfaces that
should be assembled from reusable rigs, templates, content adapters, and media
schemas rather than one-off scenes.

| Project | Status | Notes |
|---|---|---|
| `eisclimber/ExPresS-XR` | Studied in Wave 353 | Scientific OpenXR toolkit with rig, movement, interactions, hand/wrist menus, data gathering, questionnaires, debug console, localization, and setup dialogs |
| `eisclimber/VRMuseumTemplate` | Studied in Wave 353 | Beginner workshop template with handout and completed exhibit |
| `Hempp/street-art-gallery` | Studied in Wave 353 | Compact spatial art gallery reference |
| `Kilamper/Art-Museum-VR` | Studied in Wave 353 | VR art room with creative object interaction, pixel canvas, and floating instructions |
| `ericyoondotcom/OculusGooglePhotos` | Studied in Wave 353 | Personal media gallery direction marker |
| `usmanbutt-dev/VR-DepthAPI-Gallery` | Studied in Wave 353 | Quest local image gallery with file browser, opacity, movable panels, and Depth API occlusion |
| `echo3Dco/Unity-Oculus-echo3D-demo-VR-Zoo-Explorer` | Studied in Wave 353 | Cloud-managed VR zoo using echo3D metadata and project keys |

### Consolidation note

This family matters because galleries are valuable as reusable utility shells.
It suggests an exhibit manifest plus local, cloud, and depth-aware media
adapters.

## Family 333: AI-assisted education labs and procedure-training loops

This family covers science/medical training projects where task state, safety,
reset, tutor guidance, quiz, and validation caveats are part of the product
architecture.

| Project | Status | Notes |
|---|---|---|
| `kenny2077/ChemAI` | Studied in Wave 354 | Quest chemistry lab with free-order stations, voice AI, live state, safety warnings, failures, reset, and credential hygiene |
| `2227500/Team-Chem-Training-VR-App` | Studied in Wave 354 | Chemistry onboarding/safety/lab/quiz training sequence |
| `37743/Classroom-VR` | Studied in Wave 354 | AI tutor classroom with RAG/curriculum framing |
| `VR-Biomolecules/HandsOnDNA` | Studied in Wave 354 | DNA outreach experience with scale transition and sequenced activities |
| `CRISPGroup/Mission-Control-MRI-VR` | Studied in Wave 354 | MRI familiarization app with story, bed/glide metaphor, movement feedback, caregiver role, and non-validated caveat |

### Consolidation note

This family matters because AI should assist a validated task model, not replace
it. It suggests deterministic state hubs, tutor adapters, safety/failure gates,
and teacher/caregiver roles.

## Family 334: MR digital twin control surfaces and safety dashboards

This family covers MR/VR systems that visualize and sometimes control real-world
spaces, devices, robots, drones, safety scenarios, or industrial processes. The
reusable lesson is to expose state, authority, and safety before commands.

| Project | Status | Notes |
|---|---|---|
| `mr-talukdar/Pyrosafe-Game` | Studied in Wave 355 | Fire/safety training direction marker |
| `limasantoss/fabrica-segura-vr` | Studied in Wave 355 | Smart-factory safety microtraining with emergency-stop feedback |
| `Kreline1993/gardsbriller` | Studied in Wave 355 | Quest MR garden digital twin with JSON plants, VPS, modes, wrist UI, LOD icons, and localization toasts |
| `ACROSS-Lab/HoanKiemAirVR-Unity` | Studied in Wave 355 | Environmental/air VR direction marker |
| `ACROSS-Lab/Rac-VR` | Studied in Wave 355 | Environmental/city VR direction marker with external source hygiene caveat |
| `ototadana/TyDrone` | Studied in Wave 355 | Quest MR drone cockpit with Android plugin and passthrough control framing |
| `AndreasFranke5/TwinCity` | Studied in Wave 355 | Collaborative city twin with Cesium/3D Tiles, SSA, Photon, markers, water simulation, and planning controls |
| `Mukheem/TwinTurbine` | Studied in Wave 355 | Physical/MR turbine twin with IoT/API data, dashboard, avatar onboarding, SSA, and Photon |
| `Infinity-Spark/Infinity-Spark-App` | Studied in Wave 355 | HoloLens/ABB robot monitoring/control dashboard direction |
| `SL-thws/Mixed-Reality-for-Training-in-Human-Robot-Collaboration` | Studied in Wave 355 | Human-robot collaboration training direction marker |

### Consolidation note

This family matters because MR control tools can affect real hardware or
real-world procedures. It suggests a safety-first control surface with anchors,
data adapters, command envelopes, connection health, and emergency stop states.

## Family 335: Guided wellness session loops and stress-protocol VR

This family covers breath, meditation, mindfulness, and stress-protocol projects
that turn phase timing into visual, audio, haptic, environmental, or task
feedback. The reusable lesson is to separate session timing from cue rendering
and claims.

| Project | Status | Notes |
|---|---|---|
| `Mohit-Bagri/windmill-vr` | Studied in Wave 356 | Four-phase breathing loop with countdown, rounds, text fade, and windmill exhale feedback |
| `InderSinghMehrok/breatheEase--CS-458-Project` | Studied in Wave 356 | Multi-exercise wellness shell with cards, session data, breathing variants, orb pulse, yoga, and qigong |
| `Roseburgendy/VR_Breathing_Intervention` | Studied in Wave 356 | Breath rhythm events drive beams, hand movement paths, haptics, phase progression, crystals, fog, and seasons |
| `IrtazaDevs/VR-Meditation` | Source-light marker in Wave 356 | Mystical forest guided-breathing reference |
| `luffy-yu/FloatMind` | Studied in Wave 356 | AI/hand-gesture wellness reference with emotion bubbles, STT/TTS/LLM adapter, portal transition, and scene blending |
| `kalpthakkar/MindFit-Realm` | Source-light marker in Wave 356 | Mindfulness/wellness marker pending deeper guided-activity inspection |
| `MIEC/vr-tsst` | Studied in Wave 356 | Research stress protocol with participant IDs, cognitive tasks, NPC behavior, timers, and panels |

### Consolidation note

This family matters because wellness tools can be useful while also easy to
overclaim. It suggests a reusable session shell with phase events, cue channels,
privacy/ethics labels, and non-clinical boundaries.

## Family 336: Embodied VR instruments and input-to-sound tools

This family covers hand-tracked, Leap-driven, controller, percussion, piano, and
biosignal projects where embodied input becomes audio or audiovisual feedback.

| Project | Status | Notes |
|---|---|---|
| `SeungWon0927/VR_Piano` | Studied in Wave 357 | Quest hand-tracked piano with collision-based key/audio and semitone pitch offsets |
| `JustinLin905/Pear-Piano` | Studied in Wave 357 | Oculus Interaction-heavy piano comparison node |
| `waltzaround/Matter-VR` | Partially studied in Wave 357 | Embodied/physics music marker |
| `magicinthesky/VR-Drumming` | Partially studied in Wave 357 | Drum-hit interaction marker |
| `kahogeoff/vr-war-drum` | Partially studied in Wave 357 | War-drum/percussion marker with vendor-heavy source |
| `HackTheBrain/B-vr` | Studied in Wave 357 | EEG/OpenViBE-driven visual music architecture |
| `krebsm249/Vr-LeapMotion-playing-a-Piano` | Studied in Wave 357 | Leap piano with CSV reader, teacher scripts, menu flow, and physics UI |

### Consolidation note

This family matters because input source, note/hit event, sound adapter, and
lesson logic should be reusable separately. It suggests a neutral event schema
for hand, controller, Leap, MIDI, OSC, or biosignal instruments.

## Family 337: VR creative authoring and export workbenches

This family covers painting, sketching, sculpting, modeling, export/import, and
retrieval-backed creative workflows.

| Project | Status | Notes |
|---|---|---|
| `eman2XR/Virtual-Studio` | Studied in Wave 358 | VR painting/design toolkit with palette, brush, eraser, mesh extrusion, grabbables, networking markers, transform saver, and OBJ exporter |
| `DhruvaRawal/SculpIt` | Studied in Wave 358 | Thin rig-spawn and line-drawing reference |
| `johnsandiego/PolySculpt` | Partially studied in Wave 358 | Poly/SteamVR sculpting marker |
| `not-surt/CarveVR` | Partially studied in Wave 358 | Voxel sculpting marker |
| `E-BAO/3D-VR-Painting` | Partially studied in Wave 358 | Oculus-era 3D painting marker |
| `Rowl1ng/SketchyVR` | Studied in Wave 358 | Line/tube sketching with save logic, OBJ export, and OBJ import |
| `SamuelBoerlin/3D-VR-Modelling-and-Vitrivr` | Studied in Wave 358 | VR sculpting plus Cineast/Vitrivr retrieval, voxel/SDF backend, JSON conversion, and OBJ loader |

### Consolidation note

This family matters because creative VR utilities need a document model: tool
state, stroke/mesh geometry, persistence, export/import, provenance, and optional
retrieval should not be fused into one scene.

## Family 338: VR sports skill loops and movement-feedback shells

This family covers sports, fitness, drill, and reaction projects where target
hits, equipment proxies, movement validation, scoring, tutorials, results, and
safety matter.

| Project | Status | Notes |
|---|---|---|
| `oculus-samples/Unity-MoveFast` | Studied in Wave 359 | Hand-hit fitness sample with pose gates, trigger zones, velocity scoring, combos, tutorial, and results |
| `partharora1105/Badminton_VR` | Partially studied in Wave 359 | Badminton racket/shuttle direction marker |
| `rishidevde/Badminton_Computer_Graphics` | Partially studied in Wave 359 | Quest/XRI badminton direction marker |
| `LittleQBerry/REVERIE-Sports` | Partially studied in Wave 359 | Sports learning/training marker |
| `ticahere/VIRD-demo` | Partially studied in Wave 359 | Movement/training demo marker |
| `oculus-samples/Unity-UltimateGloveBall` | Studied in Wave 359 | Multiplayer glove-ball sample with player/glove services, UI ownership, and network/voice boundaries |

### Consolidation note

This family matters because sport/fitness mechanics can be reused as neutral
drill loops: valid hit, speed/pose gate, score, tutorial, results, reset, and
playspace safety.

## Family 339: World transition previews and interaction showcase shells

This family covers world switching, destination preview, hand/controller
transition, debug/showcase tooling, and starter interaction baselines.

| Project | Status | Notes |
|---|---|---|
| `mott-lab/WorldSwitchUI` | Studied in Wave 360 | Portal, gallery, wheel, palette, and WIM transition interfaces separated from interaction controllers |
| `oculus-samples/Unity-NorthStar` | Studied in Wave 360 | Meta showcase with debug menus, scene loading, IK/editor helpers, subtitles, and vendor boundaries |
| `alexismorin/Unity-VR-Hand-Tracking-Template` | Source-light marker in Wave 360 | Quest hand-tracking starter and performance setup reference |
| `Corysia/Unity-Oculus-Example` | Source-light marker in Wave 360 | Oculus Integration starter for hands, locomotion, collision, grabbing, and setup caveats |

### Consolidation note

This family matters because future launchers, labs, dataset viewers, and
utility suites need a neutral destination catalog, preview surface, activation
adapter, transition service, and logging/debug shell.

## Family 340: Physics locomotion and XR interaction microtools

This family covers small reusable locomotion and interaction components:
physics rigs, drag/rotate/scale, climbing, fixed-joint grabs, and bounds-based
buttons.

| Project | Status | Notes |
|---|---|---|
| `KavanBahrami/XRDrag` | Studied in Wave 361 | Unreal drag locomotion component for moving, rotating, and scaling the VR pawn |
| `pierricklyons/real-motion-vr` | Studied in Wave 361 | Unity physics locomotion rig with movement sphere, spine, crouch, jump, grab, and climb modules |
| `DuckiesGaems/EasyXR` | Studied in Wave 361 | Lightweight bounds button and climbing microtools with cooldown/debug boundaries |

### Consolidation note

This family matters because movement modules should expose input, forces,
comfort, and conflict states instead of hiding them inside one player prefab.

## Family 341: Collaborative classroom whiteboard and learning surfaces

This family covers shared rooms, whiteboards, avatar presence, AI tutor adapters,
voice/network packages, and classroom collaboration shells.

| Project | Status | Notes |
|---|---|---|
| `SimonCzy/Whiteboard-UnityXR` | Studied in Wave 362 | Whiteboard creation gesture, pen texture writing, reset/debug controls, avatars, voice, and Photon |
| `AnnavarapuGanesh/VR-CLASSROOM` | Studied in Wave 362 | Gemini AI tutor wrapper, classroom shell, room/lobby scripts, and board/text framing |
| `AnnavarapuGanesh/VR-CLASSROOM-MULTIPLAYER` | Partially studied in Wave 362 | Multiplayer classroom variant for avatar/room/AI/board sync comparison |

### Consolidation note

This family matters because collaborative learning tools should separate room
state, participant presence, board strokes, AI responses, networking, and
privacy/credential handling.

## Family 342: Voice intent command and speech-to-XR action adapters

This family covers voice-controlled XR actions, spellcasting metaphors, local
keyword recognizers, cloud intent systems, transcripts, TTS, and command
dispatchers.

| Project | Status | Notes |
|---|---|---|
| `eugenek07/hairy-otter` | Studied in Wave 363 | Wit.ai VR spellcasting with activation state, transcript UI, Conduit intent mapping, and spell dispatcher |
| `ajinkyasatuse/Enchantress_AR` | Studied in Wave 363 | Windows keyword command dictionary, AR raycast placement, summon/fight/fly actions, and fallback spawn |
| `wit-ai/wit-unity` | Studied as substrate in Wave 363 | VoiceService, transcription events, Conduit, intent/entity handlers, TTS/cache/audio, and lipsync boundaries |

### Consolidation note

This family matters because voice features need a neutral command registry with
mic consent, transcript feedback, recognizer adapters, parameter resolution,
action safety, and vendor/offline fallback boundaries.

## Family 343: Body-anchored equipment sockets and inventory shells

This family covers body-relative tool belts, holsters, item slots, controller
data helpers, hand visibility, and starter interaction templates.

| Project | Status | Notes |
|---|---|---|
| `Isabela-Tellez/InventarioArmasVR` | Studied in Wave 364 | Inventory ScriptableObjects, item slots, UI buttons, collectables, and XRI starter overlap |
| `Fist-Full-of-Shrimp/FFOS-VR-Tutorial-Resources` | Studied in Wave 364 | HMD-relative body sockets, controller data, flashlight, FPS, and weapon snippets |
| `Fist-Full-of-Shrimp/FFOS-Unity-VR-Template` | Partially studied in Wave 364 | HMD height, hand visibility on select, and teleport ray baseline |

### Consolidation note

This family matters because many utility tools need fast body-relative access to
diagnostics, tools, settings, or capture controls without becoming flat menus.

## Family 344: Navigation target catalogs route cues and recenter helpers

This family covers waypoint arrows, destination catalogs, route lines, QR/marker
recentering, floor/context switching, and route visibility controls.

| Project | Status | Notes |
|---|---|---|
| `bhartinderjoshi/Waypoint_Arrow` | Studied in Wave 365 | Minimal target-facing arrow cue |
| `nlalert/AR-Indoor-Navigation` | Studied in Wave 365 | JSON target catalog, target facades, dropdown selection, NavMesh route lines, QR recentering, and floor switching |

### Consolidation note

This family matters because route guidance should separate target metadata,
visual cues, path calculation, and world-origin repair.

## Family 345: Embodiment calibration mirrored bodies and movement study harnesses

This family covers self-avatar calibration, mirrored-body mapping, tool-use
tasks, universe alignment, tracker capture, and movement-study pipelines.

| Project | Status | Notes |
|---|---|---|
| `JashoBell/vr-tool-use` | Studied in Wave 366 | Participant/avatar/universe calibration, task generation, UXF logging, VRPN/Manus/OpenVR tracking, and filters |
| `eric-cornellvel/VR-MirrorTherapy` | Studied in Wave 366 | Mirror rig, hand tracking, transform/object follow, sphere tasks, save data, and Oculus SDK caveats |

### Consolidation note

This family matters because embodiment tools need validated calibration state,
task flow, and telemetry before avatar or mirror effects can be trusted.

## Family 346: XR analytics action telemetry and immersive data surfaces

This family covers action descriptors, telemetry SDKs, assessment/objective
events, object/system tracking, storage, dashboards, and in-headset data
visualization.

| Project | Status | Notes |
|---|---|---|
| `yoonsang0910/ExplainableXR` | Studied in Wave 367 | UAD action recorder, continuous/discrete actions, context/referent capture, processor, and dashboard direction |
| `ArborXR/abxrlib-for-unity` | Studied in Wave 367 | Assessment/objective events, telemetry, storage, device/org metadata, QR, and backend protocol surfaces |
| `informXR/iXRLibForUnity` | Studied in Wave 367 | Event tracking, input/object/system trackers, debug window, exit poll, keyboard, and config tooling |
| `stonecodecs/visiograph` | Studied in Wave 367 | TCP batch ingestion and main-thread 3D datapoint creation |
| `eliaCandela/Optimizing-Data-Visualization-Through-Virtual-Reality` | Source-light marker in Wave 367 | Business metrics VR dashboard and alert direction |

### Consolidation note

This family matters because XR analytics should understand spatial context,
referents, duration, hardware state, privacy, and export/dashboard boundaries.

## Family 347: Spatial network cybersecurity maps and Wi-Fi diagnostics

This family covers network/security state that is rendered as spatial objects:
node/edge graphs, service drill-down, Wi-Fi signal markers, scan history,
security filters, and collaborative inspection.

| Project | Status | Notes |
|---|---|---|
| `danieljharris/PARSEC` | Studied in Wave 368 | Collaborative VR cybersecurity network graph with filters, probes, presenter state, and perspective scaling |
| `Orgzales/Unity-XR-NetworkMapper-Project` | Studied in Wave 368 | Quest wireless mapper with Android Wi-Fi metadata, signal pillars, hidden SSID notes, and scan database concepts |

### Consolidation note

This family matters because future diagnostics tools need a neutral data
adapter, spatial marker schema, filter policy, and permission/privacy labels
before network/security state can be trusted in XR.

## Family 348: XR pose to robot command and localization bridges

This family covers headset, controller, and hand pose streams used for robot
teleoperation, localization, gripper control, data collection, and health
monitoring.

| Project | Status | Notes |
|---|---|---|
| `aadhithya14/Open-Teach` | Studied in Wave 369 | Quest teleoperation stack with ZMQ keypoints, hand-frame transforms, robot operators, camera streams, and data collection |
| `paulonhantumbojr/sawyer_vr_teleop` | Studied in Wave 369 | Quest-to-Sawyer ROS bridge with pose topics, desired trajectory, velocity control, and gripper mapping |
| `MARSProgramming/QuestNavTest` | Studied in Wave 369 | QuestNav FRC localization with NT4 topics, heartbeat, battery state, zeroing, and wired/power constraints |

### Consolidation note

This family matters because XR pose should become robot intent only after
calibration, coordinate conversion, transport health, heartbeat, command limits,
and explicit safety/authority gates.

## Family 349: Medical and scientific volume XR viewers

This family covers medical/scientific volume pipelines: study manifests, DICOM
or VRDF import, 3D textures, raymarch shaders, labels, segmentation, progress,
and hand/controller/voice UI.

| Project | Status | Notes |
|---|---|---|
| `cassandra-stack/CASSANDRA-XR` | Studied in Wave 370 | REST/WebSocket/VRDF medical volume platform with URP raymarching, XR hands, brain menus, and Gemini/voice assistant |
| `SitronX/FNO-Hololens2-visualisation` | Studied in Wave 370 | HoloLens/PCVR viewer with DICOM/NRRD/NIFTI import, labels, segmentation sliders, async loading, and transform persistence |

### Consolidation note

This family matters because volume viewers must keep data import, rendering,
segmentation, XR manipulation, metadata, and clinical caveats separate.

## Family 350: Redirected-walking authoring and obstacle policy variants

This family covers redirected-walking tools that extend or surround core RDW
frameworks with path authoring, curve configuration, obstacle policies, and
fork-lineage lessons.

| Project | Status | Notes |
|---|---|---|
| `klngbhn/RDW_CurvedPathConfigurator` | Studied in Wave 371 | Unity editor path configurator with joints, curves, intersections, gain, tracking-space dimensions, and path assets |
| `omegafantasy/Bypassing-Obstacles` | Studied as variant in Wave 371 | OpenRDW2-derived obstacle-bypass redirector with waypoint/VE path and gain-policy lessons |

### Consolidation note

This family matters because RDW comparison requires explicit authoring assets,
physical-space constraints, redirector policies, reset behavior, and experiment
metadata instead of hardcoded scene paths.

## Family 351: Unity XR input adapters and action composition

This family covers backend input readers, typed action streams, callback
conversion, command composition, velocity sources, and binding-template
boundaries for Unity XR utilities.

| Project | Status | Notes |
|---|---|---|
| `ExtendRealityLtd/Tilia.Input.UnityInputManager` | Studied in Wave 372 | Legacy Unity Input Manager wrapper into neutral action streams |
| `ExtendRealityLtd/Tilia.Input.UnityInputSystem` | Studied in Wave 372 | Input System callback/property transformers, typed actions, GenericXR sample direction, and velocity tracker |
| `ExtendRealityLtd/Tilia.Input.CombinedActions.Unity` | Studied in Wave 372 | Axes/angle/boolean/double-click action grammar primitives |

### Consolidation note

This family matters because VR utilities should consume neutral named commands
rather than binding every feature directly to one Unity input backend.

## Family 352: Pointer spatial target and remote grab primitives

This family covers object pointers, ray/cursor payloads, hover/activation
targets, dispatchers, validity rules, and pointer-to-interactor bridges.

| Project | Status | Notes |
|---|---|---|
| `ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity` | Studied in Wave 373 | Straight/curved pointer prefabs, ray payloads, and pointer component extractors |
| `ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity` | Studied in Wave 373 | Hover/activation target state, flags, source validity, collidable objects, and dispatchers |
| `ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity` | Studied in Wave 373 | Pointer/distance grabber layer with raycast rules and target validity |

### Consolidation note

This family matters because overlay windows, in-world menus, diagnostics nodes,
and remote object controls need reusable aim/hover/activate primitives.

## Family 353: Prefab interaction docking locomotion and rig adapter modules

This family covers facade/configurator packages for interactables, snap zones,
locomotion targets, camera rig adapters, and headsetless simulator boundaries.

| Project | Status | Notes |
|---|---|---|
| `ExtendRealityLtd/Tilia.Interactions.Interactables.Unity` | Studied in Wave 374 | Interactor/interactable facades, touch/grab events, attach points, velocity, and provider/receiver boundaries |
| `ExtendRealityLtd/Tilia.Interactions.SnapZone.Unity` | Studied in Wave 374 | Snap zone states, validity, transition, scale/highlight policy, and thrown-object auto-snap |
| `ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity` | Studied in Wave 374 | Teleport target/offset/floor-snap/fade module with target/camera validity |
| `ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity` | Studied in Wave 374 | Axis movement facade with target, forward offset, rotation pivot, camera rules, and events |
| `ExtendRealityLtd/Tilia.CameraRigs.XRPluginFramework.Unity` | Studied in Wave 374 | XR node records, rig prefab creator, and camera-rig adapter boundary |
| `ExtendRealityLtd/Tilia.CameraRigs.SpatialSimulator.Unity` | Studied in Wave 374 | Spatial simulator package direction for editor/headsetless interaction |

### Consolidation note

This family matters because reusable VR lab tools need modular interaction,
docking, locomotion, and rig boundaries instead of one-off scene scripts.

## Family 354: Haptics pseudo-body hand visuals and collision comfort modules

This family covers feedback intent routing, haptic profiles, body proxies,
basic hand/controller visuals, collision rules, and camera fade overlays.

| Project | Status | Notes |
|---|---|---|
| `ExtendRealityLtd/Tilia.Output.InteractorHaptics.Unity` | Studied in Wave 375 | Interactor-to-controller haptic routing with tracked alias, queued interactor, profile, and intensity |
| `ExtendRealityLtd/Tilia.Trackers.PseudoBody.Unity` | Studied in Wave 375 | Source-following pseudo-body with collision prevention, divergence, grounding, and ignored-object policy |
| `ExtendRealityLtd/Tilia.Visuals.BasicHand.Unity` | Studied in Wave 375 | Lightweight hand/controller visual package boundary |
| `ExtendRealityLtd/Tilia.Visuals.CollisionFader.Unity` | Studied in Wave 375 | Collision-triggered camera overlay/fade with source, camera validity, collision validity, and fade events |

### Consolidation note

This family matters because utility overlays and lab scenes need explicit
feedback, body-safety, and comfort modules that do not depend on one avatar or
camera implementation.

## Family 355: Spatial UI buttons highlighters and world-control state

This family covers spatial click/toggle/option buttons, state styles, grouped
options, interactable highlighting, validity-gated focus, and world-space UI
feedback.

| Project | Status | Notes |
|---|---|---|
| `ExtendRealityLtd/Tilia.Interactions.SpatialButtons.Unity` | Studied in Wave 376 | Spatial button state, `ButtonStyle`, enabled/hover/active/disabled styling, and option groups |
| `ExtendRealityLtd/Tilia.Visuals.InteractableHighlighter.Unity` | Studied in Wave 376 | Interactable highlight material, interactor validity, and highlight/unhighlight events |

### Consolidation note

This family matters because VR menus and utility panels need explicit state
vocabulary and feedback instead of ad-hoc color or material changes.

## Family 356: Constrained controls and locomotion assist modules

This family covers physical UI controls and movement helpers: linear/angular
drives, teleport target helpers, climbing release behavior, movement
amplification, and collider following.

| Project | Status | Notes |
|---|---|---|
| `ExtendRealityLtd/Tilia.Interactions.Controllables.Unity` | Studied in Wave 377 | Linear/angular joint and transform drives with axis limits and target values |
| `ExtendRealityLtd/Tilia.Locomotors.TeleportTargets.Unity` | Studied in Wave 377 | Point/area teleport target prefab creators |
| `ExtendRealityLtd/Tilia.Locomotors.Climbing.Unity` | Studied in Wave 377 | Climbable/climbing facade and release velocity multiplier |
| `ExtendRealityLtd/Tilia.Locomotors.MovementAmplifier.Unity` | Studied in Wave 377 | Source-to-target movement amplification with ignored radius and multiplier |
| `ExtendRealityLtd/Tilia.Trackers.ColliderFollower.Unity` | Studied in Wave 377 | Source-following collider tracker with snap-to-source |

### Consolidation note

This family matters because sliders, levers, movement assists, and collider
proxies are reusable primitives for settings, calibration, accessibility, and
comfort tools.

## Family 357: OpenXR vendor rig and passthrough capability adapters

This family covers camera rig records, device details, vendor SDK wrappers,
runtime validity checks, passthrough managers, and capability surfaces.

| Project | Status | Notes |
|---|---|---|
| `ExtendRealityLtd/Tilia.CameraRigs.OpenXR.Unity` | Studied in Wave 378 | OpenXR node records, passthrough manager boundary, and Vive OpenXR sample |
| `ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity` | Studied in Wave 378 | PICO controller mapping, connection checks, dominant hand priority, and see-through toggles |
| `ExtendRealityLtd/Tilia.SDK.WaveXR.Unity` | Studied in Wave 378 | WaveXR SDK wrapper and vendor rig integration marker |

### Consolidation note

This family matters because generic VR utilities should consume capability
records instead of embedding vendor SDK calls in feature code.

## Family 358: Zinnia and VRTK composition substrate

This family covers low-level Unity component primitives and tutorial
composition layers below Tilia packages.

| Project | Status | Notes |
|---|---|---|
| `ExtendRealityLtd/Zinnia.Unity` | Studied in Wave 379 | Process moments, rules, observable lists, transformers, actions, casts, event proxies, and tests |
| `ExtendRealityLtd/VRTK.Tutorials.YouTube` | Studied in Wave 379 | Tutorial scene/project composition for Tilia package integration |

### Consolidation note

This family matters because package-level findings need a clear lower-level
primitive vocabulary for process, rule, transform, action, cast, and event
composition.

## Family 359: Godot Quest interaction toolkit and hand asset pipeline

This family covers Quest-era Godot interaction toolkits, game-level
composition, OpenXR action maps, and hand rigging/asset pipeline references.

| Project | Status | Notes |
|---|---|---|
| `NeoSpark314/godot_oculus_quest_toolkit` | Studied in Wave 380 | OQ Toolkit, demos, utilities, and Quest-focused toolkit lineage |
| `arpruss/OpenSaberPlus` | Studied in Wave 380 | Saber/rhythm game composition using toolkit assets and OpenXR action maps |
| `ClonedPuppy/Blender_OpenXR_Hand_Rigging` | Studied in Wave 380 | Blender-to-Godot hand rigging and OpenXR hand visualization pipeline |

### Consolidation note

This family matters because Godot VR utilities need reusable interaction
assets, action maps, and hand visuals that stay separate from game rules and
old headset-specific assumptions.

## Family 360: Godot XR networking social avatar and WebRTC shells

This family covers minimal networked XR rooms, avatar presence, WebRTC/game
expansions, social-world shells, and deprecated avatar framework lineage.

| Project | Status | Notes |
|---|---|---|
| `goatchurchprime/Godot_XR_networking` | Studied in Wave 381 | Minimal main-scene/avatar/networking shell |
| `teddybear082/Godot_XR_Networking-Plus-Game` | Studied in Wave 381 | WebRTC/game expansion around a Godot XR networking base |
| `zodiepupper/barkvr` | Studied in Wave 381 | Larger Godot VR social/world shell with WebRTC and system folders |
| `Godot-Dojo/Deprecated-Godot-XR-Avatar` | Studied in Wave 381 | Deprecated avatar/interactable component taxonomy |

### Consolidation note

This family matters because collaborative VR utilities need room/session,
avatar, object authority, transport-health, and privacy boundaries before
product-specific tools are layered in.

## Family 361: Godot cross-device OpenXR platform experiments

This family covers Samsung/OpenXR probes, Apple Vision Pro engine patch
experiments, and legacy Godot OpenXR backend comparison nodes.

| Project | Status | Notes |
|---|---|---|
| `Jax-Danger/Godot-Samsung-XR` | Studied in Wave 382 | Compact Samsung/OpenXR project with Level, Player, scripts, action map, and export preset |
| `ibrews/godot-avp-cascade` | Studied in Wave 382 | AVP-oriented engine patches, test project, tools, docs, and captures |
| `GodotVR/godot_openxr_for_godot_3.x` | Deepened in Wave 382 | Legacy Godot 3 OpenXR backend, Android samples, and native action/session/space plumbing |

### Consolidation note

This family matters because platform experiments should be documented as
provenance-rich envelopes with action maps, test scenes, patch history, and
clear migration caveats.

## Family 362: Godot VR retrofit profiles modloaders and AI NPC tooling

This family covers Godot VR retrofit shells, injector/profile splits,
modloader-style patching, game profile stores, and AI NPC adapter surfaces.

| Project | Status | Notes |
|---|---|---|
| `teddybear082/UGVR` | Studied in Wave 383 | XR injector and override config retrofit envelope |
| `teddybear082/UGVR_game_profiles` | Studied in Wave 383 | Per-game profile folders for retrofit compatibility knowledge |
| `teddybear082/CrueltySquadVR-Modloader` | Studied in Wave 383 | Modloader scripts, override config, and XR Tools graft points |
| `teddybear082/godot-ai-npc-example` | Studied in Wave 383 | AI NPC example envelope with scripts, demo, assets, and provider caveats |

### Consolidation note

This family matters because retrofit and assistant tooling must separate
target-specific profiles, installer/injector behavior, reusable XR assets, and
privacy/safety state.

## Family 363: Quest hand telemetry bridges

This family covers Quest/OpenXR hand tracking as a data source for ROS,
actuators, virtual desktop/game input, and teleoperation utilities.

| Project | Status | Notes |
|---|---|---|
| `NU-MECH-ENG-495/vr-hand-tracking` | Studied in Wave 384 | Unity hand-joint sender plus ROS2 receiver/visualizer |
| `minsley/avatar-quest` | Studied in Wave 384 | Native Quest OpenXR hand curl to ESP32 UDP stream with passthrough/debug overlay |
| `yefeblgn/VR-Hand-Steering-Bridge` | Studied in Wave 384 | OpenXR hand pose to vJoy steering bridge with loader discovery |
| `lts0429/teleoperation` | Studied in Wave 384 | Quest UDP headset/hand pose packets to ROS2 topics and TF frames |

### Consolidation note

This family matters because hand tracking becomes reusable only when packet
schemas, confidence, coordinate conversion, output adapters, and safety states
are explicit.

## Family 364: XR robot teleoperation control loops

This family covers XR operator consoles, camera downlinks, robot adapters,
simulation/headless modes, discovery, calibration, recording, and headsetless
tracker roles.

| Project | Status | Notes |
|---|---|---|
| `fiveages-sim/xr_teleoperate_ocs2_ros2` | Studied in Wave 385 | TeleVuer, shared-memory images, arm/hand adapters, sim/headless flags, episode writer |
| `IIT-SoftBots/UnitySoftbotsTeleopRelease` | Studied in Wave 385 | Unity softbot teleop shell with Movement SDK calibration, ROS1/ROS2, discovery, UI modules |
| `stex2005/Unity-HTC` | Studied in Wave 385 | SteamVR Null Driver headsetless tracker workflow and logical tracker roles |

### Consolidation note

This family matters because teleoperation utilities need operator-mode
selection, connection health, calibration, recording, and safety before any
robot-specific control code is trusted.

## Family 365: XR hardware runtime bootstrap templates

This family covers hardware-specific Unity templates, OpenXR extension
bindings, GUI launchers, action subscription, haptics, and setup caveats.

| Project | Status | Notes |
|---|---|---|
| `Adjuvo/Unity-Template` | Studied in Wave 386 | SenseGlove Unity template with interaction scenes and headset settings |
| `Toni-SM/semu.xr.openxr` | Studied in Wave 386 | Omniverse OpenXR Python binding, UI launcher, action/haptic/render loop |

### Consolidation note

This family matters because hardware/runtime onboarding should be captured as
template scenes, settings, lifecycle, and provenance rather than hidden setup
steps.

## Family 366: Spatial application UX patterns

This family covers product-level UX references for scientific analysis,
passthrough strategy interactions, rehabilitation task systems, radial/wrist
menus, object-driven rules, and session state.

| Project | Status | Notes |
|---|---|---|
| `Superkart/Immersive_Cosmology_Explorer` | Studied in Wave 387 | Scientific VR/desktop visualization with filtering, radial menus, annotations, and session state |
| `WallerTheDeveloper/vr-tower-defense` | Studied in Wave 387 | Passthrough tower defense with wrist menu, pinch gestures, factories, commands, and pooling |
| `vladyslav-tsalko/REMIRE` | Deepened in Wave 387 | MR rehab tasks with MRUK, hand tracking, object-driven grab rules, difficulty, and LFS caveat |

### Consolidation note

This family matters because application examples reveal reusable menu, task,
placement, filter, and session patterns that are easy to miss in toolkit-only
research.

## Family 367: Quest passthrough vision bridges

This family covers Quest camera capture, external inference streams, object
detection results, 3D bounding boxes, and spatial marker placement.

| Project | Status | Notes |
|---|---|---|
| `samuelm2/OpenQuestCapture` | Studied in Wave 388 | Quest camera wrapper, native library, 3D reconstruction, docs, rebuild script |
| `danieloquelis/Unity-QuestVisionStream` | Studied in Wave 388 | Passthrough Camera API package with WebRTC server/offload split |
| `sandeepv6/questvision` | Studied in Wave 388 | MR object detection with server inference, 2D/3D boxes, and scene raycasts |

### Consolidation note

This family matters because MR vision utility value depends on a safe camera
permission, frame transport, inference, spatial projection, and privacy split.

## Family 368: MR templates and world transform envelopes

This family covers Quest MR templates, MRUK setup caveats, AI world transform
services, official MR sample composition, and vendor dependency boundaries.

| Project | Status | Notes |
|---|---|---|
| `noritsune/quest-mr-template` | Studied in Wave 389 | Compact MRUK template with runtime action bindings and recenter caveat |
| `DecartAI/Decart-XR` | Studied in Wave 389 | Quest AI world transformation with Unity/service/WebRTC/voice boundary |
| `oculus-samples/Unity-TheWorldBeyond` | Studied in Wave 389 | Scene API, Passthrough, Voice SDK, Interaction SDK, Audio Spatializer, and MRUK sample |

### Consolidation note

This family matters because MR app templates need setup rules, scene mesh
alignment, provider/service boundaries, and fallback UX before product logic.

## Family 369: MR robot SLAM and user-study dashboards

This family covers MR robot dashboards, SLAM map summaries, user-study
record/replay, remote tracking, network health, and consent/safety state.

| Project | Status | Notes |
|---|---|---|
| `mustafizur-r/WalkerProject` | Studied in Wave 390 | MR gait rehab robot walker with MRUK, Photon, MQTT, and tracking feedback |
| `prakash-aryan/MR-SLAM` | Studied in Wave 390 | Quest/Unity dashboard over ROS2 multi-robot SLAM, map merge, Nav2, and stats topics |
| `danieljtrujillo/The-Future-is-Chrome-MIT-Reality-Hack-2026` | Studied in Wave 390 | Hackathon MR/robot app with Unity, robot-server, docs, and Booster SDK assets |
| `mi2lab/mrat-passthrough-quest` | Studied in Wave 390 | Passthrough MR user-testing toolkit with recording/replay and cross-device tracking |

### Consolidation note

This family matters because operator/research dashboards need scene context,
identity, topic freshness, replay, authority, and data-retention labels.

## Family 370: Hand packages social tabletop and puzzle tasks

This family covers lightweight hand packages, pose-to-action mapping, social MR
tabletop sessions, shared anchors, room UI, and puzzle/task flow references.

| Project | Status | Notes |
|---|---|---|
| `Extrys/XRMasterHands` | Studied in Wave 391 | OpenXR hand package with Runtime/Editor/Samples and pose-to-action samples |
| `oculus-samples/Unity-SpiritSling` | Studied in Wave 391 | Social MR tabletop with contextual board placement, anchors, avatars, networking, and hand grabs |
| `francesctr4/EscapeRoomVR` | Studied in Wave 391 | Compact escape-room app reference for puzzle/object task state |

### Consolidation note

This family matters because colocated MR and hand-driven apps need reusable
hand commands, session/anchor state, player presence, puzzle gates, and
fallback input boundaries.

## Family 371: Accessibility communication surfaces

This family covers captions, voice-command surfaces, descriptive object menus,
safe-area placement, sound-source cues, and privacy boundaries for speech or
caption providers.

| Project | Status | Notes |
|---|---|---|
| `XR-Access-Initiative/chirp-captions` | Deepened in Wave 392 | Caption runtime/package reference with timed captions, renderer choices, safe areas, and source cues |
| `XR-Access-Initiative/voicesdk-samples-whisperer-captions` | Studied in Wave 392 | Voice SDK sample with speak gesture, object commands, prompts, TTS/cache, and Wit.ai caveats |
| `JustinMorera/VR-Accessibility-SDK` | Studied in Wave 392 | Partial-vision object targeting with descriptive text menus and Input System binding |

### Consolidation note

This family matters because accessible communication utilities need source
adapters, renderer preferences, object-description metadata, feedback state,
and privacy labels before they can become reusable overlays or helpers.

## Family 372: Low-vision and nonvisual accessibility feedback loops

This family covers magnification, focus targets, spatial audio, haptic cue
semantics, nonvisual menus, tutorial flow, and accessibility contribution
requirements.

| Project | Status | Notes |
|---|---|---|
| `XR-Access-Initiative/Vision-Accessibility-Toolkit` | Studied in Wave 393 | FirstHand-derived accessibility toolkit/reference with hand interaction base and audio cues |
| `SuHCI/MagniVR` | Studied in Wave 393 | Low-vision magnification research prototype with VR room, models, and UI prototype |
| `xability/punch-pulse` | Studied in Wave 393 | Blind/low-vision boxing app with spatial audio, haptics, accessible menus, and tutorial guidance |

### Consolidation note

This family matters because low-vision and blind-user VR tools need a feedback
loop that spans visual magnification, nonvisual routing, haptics, onboarding,
fallbacks, and comfort constraints.

## Family 373: Sign-language and gesture recognition training

This family covers hand-pose learning, saved hand forms, angle/distance
features, hold-to-confirm scoring, confidence labels, gesture recognizers, and
quiz/training state.

| Project | Status | Notes |
|---|---|---|
| `Somanyloopholes/SignPoseVR` | Studied in Wave 394 | Quest ASL trainer with learn/quiz modes, reference prompts, hand tracking, and glow feedback |
| `cpvrlab/vrTrainingFingerAlphabet` | Deepened in Wave 394 | German finger alphabet trainer with saved hand forms, explainable scoring, and debug/UI helpers |
| `MARUI-PlugIn/MiVRy` | Studied in Wave 394 | Multi-engine gesture recognition plugin with Unity, Unreal, native, and mobile package boundaries |

### Consolidation note

This family matters because sign-language and gesture tools need explainable
pose schemas, calibration, tolerance, confidence, and user-variation caveats,
not only a pass/fail hand-tracking check.

## Family 374: Eye-tracking safety and calibration

This family covers gaze source adapters, calibration harnesses, fixation or
velocity signals, overload detection, adaptation policies, user override, and
clinical/privacy caveats.

| Project | Status | Notes |
|---|---|---|
| `leonkoech/AutismDetector` | Studied in Wave 395 | Magic Leap eye-tracking sensory-overload SDK with demos, EEG context, and clinical caveats |
| `mvidaldp/unity_htcvivepro_et_calibration` | Studied in Wave 395 | Vive Pro Eye calibration project with Unity/SteamVR harness structure and bundled asset caveats |

### Consolidation note

This family matters because gaze-based accessibility or safety tools must make
calibration quality, signal confidence, adaptation authority, consent, and
medical-claim boundaries explicit.

## Family 375: VR research session and annotation toolkits

This family covers study package scaffolds, participant/session/trial state,
operator UIs, posture measurement, raw motion logs, retrospective annotation,
and exportable analysis artifacts.

| Project | Status | Notes |
|---|---|---|
| `MPIB/arc-vr` | Studied in Wave 396 | Package-based Unity VR research toolbox with settings, logger, dev console, and modular package split |
| `immersivecognition/posture-assessment-vr` | Studied in Wave 396 | UXF-backed posture/balance measurement with operator UI, participant CSV, and raw HMD motion logs |
| `revealcentre/retrosketch` | Studied in Wave 396 | Retrospective video replay with emotion/presence curves, keypoints, annotations, validation, and export |

### Consolidation note

This family matters because VR research tools need reusable study lifecycle,
operator control, measurement, replay, annotation, export, and consent
boundaries instead of one-off experiment scenes.

## Family 376: File and media intake surfaces

This family covers runtime file browsers, native mobile document pickers,
gallery/photo/video bridges, desktop open/save dialogs, permissions, filters,
callbacks, and platform capability labels.

| Project | Status | Notes |
|---|---|---|
| `yasirkula/UnitySimpleFileBrowser` | Studied in Wave 397 | Runtime uGUI file browser with filters, quick links, multi-select, Android SAF, and Quest caveats |
| `yasirkula/UnityNativeFilePicker` | Studied in Wave 397 | Android/iOS document picker/export bridge with MIME/UTI filters and async permission flow |
| `yasirkula/UnityNativeGallery` | Studied in Wave 397 | Gallery/photos media bridge for image/video/audio picking, saving, thumbnails, and permissions |
| `gkngkc/UnityStandaloneFileBrowser` | Studied in Wave 397 | Desktop native open/save dialogs with filters, async callbacks, and platform plugins |

### Consolidation note

This family matters because VR utilities often need external media, models,
configs, logs, or datasets, and that requires explicit provider, permission,
path, persistence, and fallback boundaries.

## Family 377: Spatial room layout and anchored design persistence

This family covers MR room import, manual room grids, furniture catalogs,
placement rays, spatial anchors, relative transforms, layout JSON, material
changes, snapshots, exports, and product catalog caveats.

| Project | Status | Notes |
|---|---|---|
| `TeamFWS/room-designer` | Studied in Wave 398 | Quest MR room designer with MRUK, placement ray, OVR anchors, layout JSON, IKEA loader, and wall paint |
| `pnlt/VNE5T-SolutionForAVR` | Studied in Wave 398 | VR interior design product reference with manipulation, material, measurement, annotation, export, and AI claims |
| `lakshmikosre/Elite-In-Decora` | Lightly studied in Wave 398 | AR interior design requirements node around catalog, gallery, recommendations, cart, and ARCore framing |

### Consolidation note

This family matters because spatial authoring utilities need a durable layout
document, recovery-aware anchors, model provenance, and clear separation
between room geometry, object catalog, and user arrangement state.

## Family 378: VR task testbeds and dataset recorders

This family covers annotated task simulators, behavioral study apps,
locomotion evaluation scenarios, calibration artifacts, participant configs,
event/predicate schemas, trial CSVs, statistics loggers, and replay/postprocess
flows.

| Project | Status | Notes |
|---|---|---|
| `michaelkoller/vacesimulator` | Studied in Wave 399 | Annotated VR kitchen simulator with recipe HUD, object/action events, predicates, RGB/depth/segmentation, and replay |
| `JohnBacho/VIBES-Lab-Project2` | Studied in Wave 399 | Eye-tracked gambling behavior study with tutorial flow, wallets, trial CSV, pupil metrics, and SRanipal |
| `VRatPolito/LET-VR` | Studied in Wave 399 | OpenXR locomotion evaluation testbed with scenarios, configuration, calibration, input wrapper, and statistics loggers |

### Consolidation note

This family matters because robust VR research utilities need repeatable task
conditions, calibrated inputs, objective metrics, physiological/event streams,
and export pipelines that can be audited later.

## Family 379: VR welding and industrial procedure trainers

This family covers VR skill trainers where the user learns a physical procedure
through guided steps, ghost-path reference motion, part discovery, contextual
errors, gauges, quizzes, and attempt summaries.

| Project | Status | Notes |
|---|---|---|
| `Marcel-Castro/VR-Welding` | Studied with caveats in Wave 400 | Welding workstation prototype with gauges, lessons, attachments, and MRTK-heavy package surface |
| `stjakubi/VR-SLM-printer` | Studied in Wave 400 | Metal 3D-printer operation trainer with part discovery, contextual errors, labels, and learning progress |
| `NandiniDevraj/WeldingSimulationSpline` | Studied in Wave 400 | Spline/ghost-path welding trainer with distance, angle, speed, guided/exam, HUD, and summary metrics |

### Consolidation note

This family matters because many future VR utilities can reuse the same
skill-practice envelope even when the domain is not welding: ideal movement,
live correction, hidden-hint exam mode, and post-attempt evidence.

## Family 380: VR chemistry and laboratory learning scenarios

This family covers educational lab environments where domain objects, scenario
validators, grabbable/sampleable affordances, and environment consequences make
the learning task legible in 3D.

| Project | Status | Notes |
|---|---|---|
| `chemistry-lab/chemistry-lab-vr` | Studied in Wave 401 | Chemistry lab scenario toolkit with molecule packs, grabbables, atom interactions, goal validators, and visible consequence feedback |
| `alinaduca/BachelorsThesis-UnityLab` | Studied with caveats in Wave 401 | Chemistry reaction learning app with thesis/demo route, AI tutor surfaces, and vendor/sample-code caveats |

### Consolidation note

This family matters because lab-like VR utilities need more than a quiz: they
need object metadata, visible state changes, explanation surfaces, and reusable
task validators.

## Family 381: VR surgery and precision-task training

This family covers careful-manipulation trainers where score depends on path
accuracy, touch discipline, velocity thresholds, containment state, and
completion gates.

| Project | Status | Notes |
|---|---|---|
| `UoA-eResearch/SurgeryQuest` | Studied with caveats in Wave 402 | Quest surgery simulator reference with hand/controller fallback and simple cut interactions |
| `IsaacYu15/VR-Surgery` | Studied in Wave 402 | Surgery robot lessons for grabbing, cutting, and suturing with accuracy, touch, velocity, and completion scoring |

### Consolidation note

This family matters as a non-clinical precision-task pattern: repair, lab,
accessibility practice, and industrial training can reuse the same carefulness
penalties without copying medical claims.

## Family 382: VR drone robot and operator-control testbeds

This family covers VR operator-control systems with movement baselines,
control-mode dispatch, subject/session configuration, external signal ingress,
and trial-grade telemetry.

| Project | Status | Notes |
|---|---|---|
| `vkrishnan998/UnityVR-Drone-Simulation` | Studied with caveats in Wave 403 | Thin VR drone movement/user-study baseline |
| `GTamilSelvan07/Unity_VR_Drone_Simulator` | Studied in Wave 403 | Compact drone-control scripts with speed, battery, power-up, and penalty state |
| `MPI-IS/ArmSym` | Studied in Wave 403 | Assistive robotic-arm research harness with trials, control modes, biosignal ingress, and preallocated telemetry logging |

### Consolidation note

This family matters because robot, drone, tracker, and external-control VR
utilities need clean separation between input adapters, device models, trial
protocols, and data writers.

## Family 383: Physics hand interaction and grab joints

This family covers VR interaction systems where tracked controller input is
mediated through physical hands, rigidbodies, attach points, joint constraints,
hover/highlight state, drop thresholds, and release impulses.

| Project | Status | Notes |
|---|---|---|
| `TomorrowTodayLabs/NewtonVR` | Studied in Wave 404 | Unity physics interaction toolkit with velocity matching, attach points, levers, sliders, buttons, and SDK adapters |
| `JScott/ViveGrip` | Studied in Wave 404 | ConfigurableJoint grab abstraction with highlights, weighted objects, levers, dials, guns, and examples |
| `JLPM22/VRPhysicsInteractionUnity` | Studied with caveats in Wave 404 | Quest physics interaction prototype with nearby-object highlight and trigger grab |
| `jtnicholl/godot4-vr-physics-template` | Studied in Wave 404 | Godot 4 physical hand template with RigidBody3D hand proxies and pickup/release scripts |

### Consolidation note

This family matters because reusable VR utilities often need robust object
handling before they need app-specific features: hover, attach, pull, collide,
drop, throw, and recover should be explicit interaction states.

## Family 384: VR math and embodied learning visualization

This family covers math/geometry learning tools where equations, matrices,
graphs, or abstract spaces become embodied actions, spatial boards, controller
experiments, and analytics-friendly learning loops.

| Project | Status | Notes |
|---|---|---|
| `Rud156/MathSaber` | Studied in Wave 405 | Equation practice game with generated blocks, custom questions, slicing action, analytics, and logs |
| `PNCaruana/VR-Classroom` | Studied in Wave 405 | Matrix/FFT classroom visualization with generated 3D bars and color scaling |
| `mtwoodard/hypVR-Ray` | Studied in Wave 405 | WebVR hyperbolic raymarching with controller abstraction and display fallback |
| `jmacd/grraph` | Lightly studied in Wave 405 | Thin VR graph/math playground reference |

### Consolidation note

This family matters because education utilities need a reusable path from
abstract content to spatial representation, user action, correctness feedback,
and exportable evidence.

## Family 385: Anatomy and medical learning objects

This family covers anatomy/medical education projects that expose domain
objects through labels, isolation, slicing, volume rendering, snapping puzzles,
and data-bound UI controls.

| Project | Status | Notes |
|---|---|---|
| `chrislarkee/VR-Neuroanatomy` | Studied in Wave 406 | Brain learning object with labelled/parcellated anatomy, part scripts, labels, menus, and slicing |
| `asemahassan/3DPuzzleVR` | Studied in Wave 406 | Anatomy puzzle with snapping, distance checks, wand control, and laser UI |
| `malyalar/vr-volume-renderer` | Studied in Wave 406 | Medical volume rendering learning object with volume controllers and slice/rotate exploration |
| `auroey/mr-IMVA-unity` | Studied with caveats in Wave 406 | MRTK data/UX shell with data controllers, item placers, dialogs, sliders, and layered UI examples |

### Consolidation note

This family matters because medical learning objects should separate domain
data, inspect/isolate/slice controls, task state, clinical caveats, and UI
shells rather than hiding everything inside one scene.

## Family 386: VR museums exhibitions and guide analytics

This family covers exhibit-centric VR systems with room/exhibit manifests,
catalogs, gaze and dwell tracking, AI or scripted guides, web collection
surfaces, and curatorial analytics exports.

| Project | Status | Notes |
|---|---|---|
| `KuhakuNeko/VR-AI-Museum` | Studied in Wave 407 | Local AI museum guide with gaze/room logs, RAG, voice adapters, survey/export files, and privacy framing |
| `doktorfrag/museum-experience-vr` | Studied in Wave 407 | Museum prototype with catalog entries, picture/statue scripts, location detection, and catalog UI |
| `christian-acuna/react-vr-museum` | Studied in Wave 407 | React/Web museum shell with art objects, collections, sessions, search, and profile flows |
| `VIRTUE-DBIS/vre-mixnhack19` | Studied in Wave 407 | Data-driven WebVR exhibition reference with backend/media-query configuration |

### Consolidation note

This family matters because exhibition utilities need both visitor-facing
interpretation and operator-facing evidence: exhibit metadata, attention logs,
journey narratives, chat transcripts, and consent-aware exports.

## Family 387: Input-neutral spatial UI panels

This family covers 3D widget systems, spatial layouts, viewport panels,
physical/contact surfaces, ray or hand input adapters, and native widget planes.

| Project | Status | Notes |
|---|---|---|
| `artflow-vr/vr-ui` | Studied in Wave 408 | Three.js spatial UI with layout classes, view primitives, Object3D input registration, and discontinued-project caveats |
| `csiro-scientific-computing/vr-ui` | Studied in Wave 408 | Unity interaction surfaces/volumes with collider affordances, haptics, sliders, radial dials, and state payloads |
| `MT-ZD/Godot-3D-VR-UI` | Studied in Wave 408 | Godot SubViewport-to-quad panel with raycast coordinate conversion and synthetic mouse input |
| `Squareys/magnum-vr-ui` | Studied in Wave 408 | Native C++ Magnum/Oculus/Leap widget-plane reference |

### Consolidation note

This family matters because future overlay and utility panels should separate
widget/layout state from input origin. Ray, hand, collider, synthetic mouse, and
native pointer adapters should feed the same command surface.

## Family 388: Browser-backed and WebView VR surfaces

This family covers native WebView wrappers, WebView2 bridges, editor web panels,
texture-backed Android browser surfaces, JavaScript callbacks, permissions,
focus, and synthetic touch/mouse input.

| Project | Status | Notes |
|---|---|---|
| `gree/unity-webview` | Studied in Wave 409 | Cross-platform Unity WebView wrapper with callback/lifecycle matrix and native overlay caveats |
| `umetaman/UnityWebView2` | Studied in Wave 409 | Minimal Unity/Windows WebView2 bridge with UI rectangle synchronization |
| `olegmrzv/UnityWebViewInEditor` | Studied in Wave 409 | Unity Editor WebView and JS callback bridge over hidden editor APIs |
| `t-34400/UnityWebViewLib` | Studied in Wave 409 | Android texture-backed WebView bridge with frame bytes, synthetic touch, JS bridge, and lifecycle manager |

### Consolidation note

This family matters because web content is often the fastest path to useful VR
dashboards, but native-overlay and true 3D texture-surface ownership have very
different UX, focus, keyboard, and rendering constraints.

## Family 389: CloudXR and immersive remote-rendering clients

This family covers CloudXR runtime adapters, WebXR streaming clients, headset
receiver apps, device profiles, pose uplink, video/audio downlink, pairing,
metrics, and reconnect/pause state.

| Project | Status | Notes |
|---|---|---|
| `NVIDIA/cloudxr-lovr-sample` | Studied in Wave 410 | LÖVR CloudXR plugin with pre-OpenXR runtime startup, service properties, opaque data channels, and audio streaming |
| `NVIDIA/cloudxr-js-samples` | Studied in Wave 410 | WebXR/WebRTC CloudXR browser client with device profiles, tracking uplink, render loop, and connection settings |
| `picoxr/OpenXR_CloudXR_Client_Demo` | Studied in Wave 410 | PICO OpenXR CloudXR client with tracking assembly, framebuffer lifecycle, pause/resume, and stream metrics |
| `apple/StreamingSession` | Studied in Wave 410 | Apple remote streaming session reference with mDNS/TCP/QR pairing and CloudXR launch/session readiness |

### Consolidation note

This family matters because remote VR utility clients need an explicit
lifecycle around profile selection, runtime/session startup, tracking uplink,
frame delivery, diagnostics, pairing, and security identity.

## Family 390: Creator capture remotes and live mocap production bridges

This family covers Quest capture remotes, mixed-reality spectator camera
injection, mocap live-link receivers, actor/prop/face mapping, media pull, and
operator command APIs.

| Project | Status | Notes |
|---|---|---|
| `GregMadison/quest-capture-remote` | Studied in Wave 411 | Android Quest recorder remote with wireless ADB, capture presets, internal recorder commands, and media pull |
| `LIV/BoneworksLIV` | Studied in Wave 411 | LIV mixed-reality capture mod with spectator camera prefab, layer masks, body visibility, and audio capture |
| `pnmocap/Neuron_Mocap_Live_Unity` | Studied in Wave 411 | Axis Studio/Perception Neuron live-link bridge with TCP/UDP sessions, actor/tracker model, and Animator/Transform/Rigidbody targets |
| `Rokoko/rokoko-studio-live-unity` | Studied in Wave 411 | Rokoko Studio Unity live plugin with UDP JSON frames, actors, props, face blendshapes, prefab pooling, and Command API |

### Consolidation note

This family matters because creator utilities often combine a data receive path
with an operator control path. The reusable part is a bounded control plane
around capture, camera, actor, prop, face, recording, and calibration state.

## Family 391: Tiny OpenXR and OpenVR render-framework adapters

This family covers small framework adapters that bring XR session, swapchain,
view, input, haptic, and mirror-window ownership into lightweight render loops
without forcing a full game-engine dependency.

| Project | Status | Notes |
|---|---|---|
| `FireFlyForLife/rlOpenXR` | Deepened in Wave 412 | Raylib-facing OpenXR binding with rlgl backend, head/hand state, examples, and WIP controller caveats |
| `caszuu/rlxr` | Studied in Wave 412 | Single-header Raylib OpenXR module with platform graphics bindings, swapchain lifecycle, actions, bindings, and haptics |
| `branchpanic/raylib-openvr` | Studied in Wave 412 | OpenVR/Raylib prototype with HMD/controller tracking and stereo rendering |
| `geefr/vsgvr` | Studied in Wave 412 | VulkanSceneGraph OpenXR integration with rendering, input, tracking, extension handling, coordinate-space notes, and desktop mirror |

### Consolidation note

This family matters because many future VR utilities need a small XR shell, not
a full engine. The reusable boundary is framework render loop in one direction,
and XR instance/session/swapchain/action ownership in the other.

## Family 392: Runtime retrofit SLAM and OpenXR engine substrates

This family covers projects that retrofit XR into existing runtimes, provide
DIY hardware or SLAM tracking substrate, or build a reusable OpenXR/Vulkan scene
engine boundary.

| Project | Status | Notes |
|---|---|---|
| `mcxr-org/MCXR` | Studied in Wave 413 | Archived Minecraft OpenXR/Fabric retrofit with core/play split, non-VR/server boundary, and game integration caveats |
| `alexstrei/Custom-VR` | Studied in Wave 413 | DIY 3D-printable headset with BOM, assembly docs, Monado driver fork, and Basalt dependency |
| `CIFASIS/basalt-xr` | Studied in Wave 413 | Basalt-for-Monado tracking backend with dataset replay, calibration/config paths, debug GUI flags, and library discovery |
| `Adrian-Hirt/XRe` | Studied in Wave 413 | WIP OpenXR/Vulkan engine substrate with resources, scene components, grab/teleport/highlight, and hand tracking |

### Consolidation note

This family matters because runtime bring-up is usually a boundary problem:
game loop, driver stack, SLAM config, graphics backend, scene state, and user
interaction should be separable instead of fused into one prototype.

## Family 393: Gaussian splat and spatial asset viewer pipelines

This family covers VR viewers for Gaussian splats, point clouds, camera paths,
spatial asset previews, and editor-to-viewer pipelines with saved alignment
state.

| Project | Status | Notes |
|---|---|---|
| `warpgatelabs/RSR` | Studied in Wave 414 | D3D12/OpenXR splat viewer with PLY/SOG, runtime VR toggle, folder navigation, DLSS option, and grip transforms |
| `hyperlogic/splatapult` | Studied in Wave 414 | OpenGL/OpenXR splat viewer with cameras.json, vr.json alignment persistence, SfM toggle, frustums, and Quest caveats |
| `jacobvanbeets/splat-vr-viewer` | Studied in Wave 414 | LichtFeld plugin exporting PLY to localhost PlayCanvas WebXR viewer with panel state, HTTP lifecycle, and cleanup |
| `eleanor-studio/photon.editor` | Studied in Wave 414 | Browser editor playground with reactive controls, GLB/GLTF loader, environment/camera controls, and WebXR preview value |

### Consolidation note

This family matters because spatial asset tools become more useful when import,
preview, VR alignment, camera context, and cleanup are first-class workflow
states rather than hidden viewer side effects.

## Family 394: XR utility automation authoring and scripting surfaces

This family covers in-headset command surfaces, desktop-plus-overlay utilities,
phase-state automation, scripting bindings, WebXR editors, and broad XR
capability wrappers.

| Project | Status | Notes |
|---|---|---|
| `RangerMauve/dat-xr-scene-ide` | Studied in Wave 415 | WebXR/A-Frame terminal editor with DOM scene commands, curved terminal surface, write/mkdir/eval commands, and safety caveats |
| `Eidenz/NemuriXR` | Studied in Wave 415 | Linux/Monado sleep utility with desktop app, OpenXR overlay, Unix-socket IPC, VRChat/OSC automation, and phase state |
| `Phantomxm2021/ARMOD-Framework` | Studied in Wave 415 | AR/XR capability wrapper with visual configuration, session management, light estimation, platform mutation, and docs |
| `drypy/openxr.py` | Studied in Wave 415 | Python ctypes OpenXR binding with package/tests/examples value for scripting diagnostics and probes |

### Consolidation note

This family matters because useful XR utilities often need a safe command
surface: what can run in-headset, what must stay in a companion app, which
actions are automated, and which operations need explicit trust boundaries.

## Family 395: XR testbeds validation runners and reproducible package overlays

This family covers modular XR research harnesses, conformance runner shells,
package overlays, source pinning, profile files, and distribution metadata for
runtime/helper ecosystems.

| Project | Status | Notes |
|---|---|---|
| `ILLIXR/ILLIXR` | Studied in Wave 416 | Modular XR testbed with plugin profiles, switchboard dataflow, Monado/headless/native/offload modes, and subsystem docs |
| `nix-community/nixpkgs-xr` | Studied in Wave 416 | Reproducible XR package overlay with source pins, NixOS module, package overrides, and runtime-tool grouping |
| `KhronosGroup/OpenXR-CTS` | Deepened in Wave 416 | Official conformance harness model with generated dispatch, manifests, test runtimes, conformance layers, and artifacts |
| `rpavlik/openxr-cts-runner` | Studied in Wave 416 | Experimental GUI wrapper for CTS with config, process runner, state, and UI separation |

### Consolidation note

This family matters because future XR utility reliability depends on profile
selection, package provenance, capability validation, and operator-facing test
runners as much as it depends on application code.

## Family 396: Hosted WebXR companion capture avatar and editor surfaces

This family covers browser-first XR companion elements, AR capture plugins,
avatar preview pages, thin scene editors, and static deployment surfaces.

| Project | Status | Notes |
|---|---|---|
| `k1pp0/model-viewer-webxr-capture` | Studied in Wave 417 | Companion custom element for model-viewer with camera-access injection, frame hooks, capture provider, preview UI, and version caveats |
| `voyagerD/webxr-avatar` | Studied in Wave 417 | Thin WebXR avatar preview with GLB animation assets and static browser deployment |
| `Damfino1970/quest2-webxr-editor` | Studied in Wave 417 | Small Quest/WebXR editor page with one-file browser deployment and limited source depth |

### Consolidation note

This family matters because web XR utilities can be shipped as companion
surfaces around an existing viewer/editor, but private host hooks and browser
feature gates must be documented honestly.

## Family 397: VRChat OSC micro apps and package sidecars

This family covers small avatar/OSC utilities, Python/Rust/WPF sidecars,
parameter/config models, desktop entries, distro package recipes, and wrapper
scripts.

| Project | Status | Notes |
|---|---|---|
| `99oblivius/Livi-s-VRChatOSC-Tools` | Studied in Wave 418 | Small Rust OSC tool with explicit input module and compiled sidecar shape |
| `theepicsnail/vrchat_osc_app` | Studied in Wave 418 | Minimal Python VRChat OSC app with package entry point and app module |
| `niwaniwa/VRChat-OSC-app` | Studied in Wave 418 | WPF/WPF UI/R3 desktop shell with dashboard/chat/data/settings pages, config model, and Rug.Osc |
| `noideaman/ArchOSCApps` | Studied in Wave 418 | Arch package collection for OSC apps with PKGBUILDs, desktop entries, wrappers, config, and upstream references |

### Consolidation note

This family matters because many useful avatar tools are micro-sidecars. Their
long-term value comes from parameter schemas, config, desktop/package wrappers,
and clear distribution notes rather than large app architecture.

## Family 398: Retrofit launchers injected loaders and capability layers

This family covers flatscreen-to-VR launchers, injected loader services,
runtime capability layers, placeholder launch ideas, and support-boundary
caveats.

| Project | Status | Notes |
|---|---|---|
| `TheNewJavaman/unreal-vr` | Studied in Wave 419 | Unreal flatscreen-to-VR retrofit with launcher/profile UI, injected loader, D3D11/OpenXR/UE4 services, hooks, shaders, and IPC |
| `gamenew09/RobloxVRLauncher` | Reviewed in Wave 419 | Empty OpenVR dashboard launcher placeholder; product idea only, no code donor value |
| `ultraleap/OpenXRHandTracking` | Deepened in Wave 419 | Archived implicit hand-tracking API layer with extension gating, active-state caveats, service timeouts, conformance fixes, and installer/log notes |

### Consolidation note

This family matters because retrofit and capability-injection tools need a hard
boundary between launcher/profile UX, injected code, runtime service state, and
the support claims made to users.

## Family 399: VR media cockpit library and social audio panels

This family covers in-headset companion panels for media libraries, cockpit
documents, maps, recognition results, social notifications, and external service
outputs.

| Project | Status | Notes |
|---|---|---|
| `VersaYT/JellyVR` | Studied in Wave 420 | Godot/OpenXR Jellyfin theater with MPV playback, floating controls, server/login/content states, and keyboard/menu toggles |
| `fpw/avitab` | Studied in Wave 420 | X-Plane cockpit tablet with chart/map/manual/notes apps, simulator command bindings, and native window/VR panel lifecycle |
| `Soapwood/VXMusic` | Studied in Wave 420 | Social-VR music recognition companion with HUD notifications, VRChat ChatBox output, service links, logs, and SteamVR plugin install |

### Consolidation note

This family matters because many useful VR tools are companion panels: their
value comes from provider adapters, placement/focus behavior, notification
routing, local logs, and clear boundaries around social sharing.

## Family 400: Lighthouse base-station and VR-room automation bridges

This family covers base-station discovery, BLE power commands, grouped hardware
state, Home Assistant integration, CLI automation, retries, and permission
caveats.

| Project | Status | Notes |
|---|---|---|
| `jariz/homeassistant-basestation` | Studied with archive caveat in Wave 421 | Home Assistant BLE switch entity for Valve Index Base Stations with polling, writes, grouping, and automation ideas |
| `ShayBox/Lighthouse` | Studied in Wave 421 | Rust CLI/library for Lighthouse V1/V2 power states with target matching, retries, scan timeout, and logging |

### Consolidation note

This family matters because VR-room readiness is not only an app concern. Base
stations, room presence, smart-home state, SteamVR launch, and shutdown flows
need a safe hardware automation boundary.

## Family 401: Unity tracker input and VR UI utility facades

This family covers Unity-facing wrappers for OpenVR/OpenXR device poses,
tracker identity, calibration, simulated modes, UI pointers, keyboards, and
interaction modules.

| Project | Status | Notes |
|---|---|---|
| `gpsnmeajp/EasyOpenVRUtil` | Studied in Wave 422 | Direct OpenVR Unity helper for tracker/controller poses, serials, batteries, screenshots, inventory, and non-VR pose access |
| `ebadier/ViveTrackers` | Deepened in Wave 422 | Compact Unity Vive Tracker library with manager/list model, fake manager, calibration, CSV serials, and pogo-pin events |
| `VRMADA/ultimatexr-unity` | Studied in Wave 422 | Broad Unity VR framework with UI pointers, keyboard prefabs, interaction, locomotion, haptics, avatars, and platform guides |

### Consolidation note

This family matters because future tracker and utility prototypes need a stable
Unity component surface over low-level runtime data, plus simulator/no-HMD
paths for development and diagnostics.

## Family 402: VR comfort text-entry and compositor microtools

This family covers focused utilities for locomotion comfort, VR text entry,
prediction keyboards, compositor clarity, and runtime settings patching.

| Project | Status | Notes |
|---|---|---|
| `MoonMotionProject/MoonMotion` | Studied in Wave 423 | SteamVR-era Unity locomotion toolkit with ready player, locomotion modules, camera smoothing, dynamic colliders, and project template |
| `rjth/Punchkeyboard` | Studied in Wave 423 | Unity VR keyboard with autocomplete, next-word prediction, corpora/dictionary generation, and physical key feedback |
| `elvissteinjr/SteamVR-ForceCompositorScale` | Studied in Wave 423 | Tiny SteamVR compositor-scale patcher with overlay-app registration, settings mutation, restart caveats, and backup warning |

### Consolidation note

This family matters because small daily-use problems often deserve small tools.
The reusable lesson is a narrow value proposition, visible settings, explicit
compatibility labels, and safe rollback when runtime config is mutated.

## Family 403: OpenVR chaperone boundary safety and debug geometry microtools

This family covers chaperone universe IO, play-area debug maps, tracked-device
pose visualizers, boundary proximity warnings, and room-safety diagnostics.

| Project | Status | Notes |
|---|---|---|
| `zodsoft/openvr_chaperone_io` | Studied in Wave 424 | Compact C++ chaperone universe parse/write surface for backup, preview, diff, and rollback-oriented utilities |
| `Dawars/processing_openvr_debug` | Studied in Wave 424 | Processing/OpenVR play-area and device debug visualizer with chaperone event refresh |
| `systemofapwne/VRGuard` | Studied in Wave 424 | Python/pyopenvr boundary monitor with controller pose polling, distance thresholds, height filtering, and audio warnings |

### Consolidation note

This family matters because tracked-space safety tools need to make runtime
boundary state visible, reversible, and actionable without sending users back
through a full room-setup flow.

## Family 404: Vendor OpenXR sensing setup and permission samples

This family covers vendor OpenXR setup flows, scoped package registries,
loader/feature toggles, permission gates, capability probes, gaze signals,
plane queries, and sample-scene validation.

| Project | Status | Notes |
|---|---|---|
| `dilmerv/MagicLeapPlaneDetection` | Studied in Wave 425 | Magic Leap Unity/OpenXR plane-detection sample with spatial mapping permission and semantic query flags |
| `dilmerv/MagicLeapEyeTracking` | Studied in Wave 425 | Magic Leap eye-tracking sample with permission gate, gaze pose adapter, dwell progress, and callback flow |
| `magicleap/MixedRealityToolkit-Unity-PreGA` | Studied in Wave 425 | Magic Leap-oriented MRTK fork/reference with broad interaction primitives and pre-GA support caveats |

### Consolidation note

This family matters because vendor sensing features are usually blocked by
setup, permission, and capability state before product UX begins. Future tools
need visible feature doctors rather than hidden sample-project assumptions.

## Family 405: Mocap pose solving avatar tracking and recording pipelines

This family covers capture sources, landmark providers, pose/face/hand solvers,
avatar rig binding, tracker sidecars, UDP/WebXR/Socket.IO transports, recording
sessions, and privacy/performance boundaries.

| Project | Status | Notes |
|---|---|---|
| `xianfei/SysMocap` | Studied in Wave 426 | Electron/Vue/MediaPipe/Kalidokit/three-vrm mocap app with model binding, recording, OBS, and WebXR forwarding |
| `yeemachine/kalidokit` | Studied in Wave 426 | Pose/face/hand solver library producing avatar-friendly rotations and blendshape data |
| `emilianavt/OpenSeeFace` | Studied in Wave 426 | CPU face tracker sidecar with UDP transport, Unity receiver, calibration, and process launcher |
| `freemocap/freemocap` | Studied in Wave 426 | Research-grade motion capture platform reference for session/recording/export workflows |

### Consolidation note

This family matters because pose data becomes more reusable when detection,
solving, transport, avatar binding, and recording are independent pipeline
stages with explicit privacy and confidence metadata.

## Family 406: WebXR toolkit retrofit bridges for Unity interaction stacks

This family covers Unity WebGL/WebXR host pages, browser-to-engine pose bridges,
transparent canvas composition, WebXR hand-joint providers, toolkit bone maps,
and browser feature fallback labels.

| Project | Status | Notes |
|---|---|---|
| `Rufus31415/MixedRealityToolkit-Unity-WebXR` | Studied with deprecation caveat in Wave 427 | MRTK WebXR/WebGL POC with Three.js camera bridge, transparent Unity canvas, and SendMessage transform JSON |
| `Rufus31415/HPTK-Sample-WebXR` | Studied in Wave 427 | HPTK/SimpleWebXR sample mapping WebXR hand joints into toolkit bones with session gates and rotation conversion |

### Consolidation note

This family matters because many Unity interaction systems can become
browser-delivered XR surfaces if browser session plumbing, data providers, and
toolkit interaction code remain cleanly separated.

## Family 407: PCVR launch profiles and Quest operator companions

This family covers launcher generators, runtime profile shortcuts, Quest app
catalogs, managed ADB/Meta tooling, diagnostics bundles, and safety-gated
operator surfaces.

| Project | Status | Notes |
|---|---|---|
| `harryeffinpotter/VRL` | Studied in Wave 428 | Windows PCVR launch-profile generator with Unity/Unreal target detection, Virtual Desktop/Link/Oculus launch templates, AppData settings, and generated wrappers |
| `MesmerPrism/Rusty-XR-Companion-Apps` | Studied in Wave 428 | Quest operator companion with shared WPF/CLI/MCP operation catalog, command planning, managed tools, app/runtime profiles, and diagnostics bundles |

### Consolidation note

This family matters because many VR utilities fail before runtime: the user needs
the right launch mode, package id, tool path, device status, and rollback path.
Future helper apps should treat those details as visible profiles, not hidden
commands.

## Family 408: Quest hand pose and ADB telemetry companions

This family covers Quest-side companions, pose/button telemetry, hand-streaming
setup, ADB install/bootstrap, Wi-Fi host discovery, logcat/TCP transports, and
connection-state UX.

| Project | Status | Notes |
|---|---|---|
| `MOVIN3D/MOVIN-MetaQuest-APK` | Studied in Wave 429 | APK-only Quest hand-streaming setup reference with controller-only UI, Wi-Fi host discovery, manual IP fallback, reconnect state, and permission checklist |
| `rail-berkeley/oculus_reader` | Studied in Wave 429 | Quest pose/button telemetry bridge with APK bootstrap, ADB USB/TCP transport, tagged logcat parser, and latest transform/button cache |

### Consolidation note

This family matters because headset/controller/hand data can be useful to desktop
tools without becoming a full runtime integration. Transport, schema, permission,
and consent boundaries need to be explicit.

## Family 409: WebXR hand gesture avatar and browser interaction labs

This family covers WebXR hand-joint sampling, browser capability gates, gesture
training, avatar hand model adapters, direct hand manipulation, gesture hints,
and browser-first interaction experiments.

| Project | Status | Notes |
|---|---|---|
| `AlbertoElias/webxr-hand-tracking` | Studied in Wave 430 | three.js/WebXR hand/avatar adapter harness with pinch-to-cycle model switching and controller fallback rays |
| `kimbanica/aframe-libras` | Studied in Wave 430 | A-Frame/WebXR gesture trainer with joint markers, thumb-index threshold, dwell acceptance, and target gesture UX |
| `Phocidae-dev/Kinetic-Swarm` | Studied in Wave 430 | WebXR hand microgame with gesture hints, input-source processing, orb state machine, and lift/freeze/push/draw interactions |

### Consolidation note

This family matters because hand tracking becomes reusable only when raw joints,
target gestures, confidence/dwell rules, visual feedback, and model adapters can
be inspected separately.

## Family 410: Domain-specific VR game timer and helper overlays

This family covers narrow game-helper timers, no-memory-reading policies,
foreground/hotkey gates, bitmap or browser timer surfaces, domain-state models,
and freshness labels for game-specific data.

| Project | Status | Notes |
|---|---|---|
| `84z0r/PhasmoTimer` | Studied in Wave 431 | External Phasmophobia timer overlay with no-memory policy, foreground checks, global hotkeys, JSON config, and timer/UI settings |
| `SteveMarkhamGIT/PhasmoTimer` | Studied in Wave 431 | Bitmap-rendered timer surface with image layers, digit glyph resources, hover/touch masks, and output texture buffer |
| `DrBrad/phastimer` | Studied in Wave 431 | Browser/OBS-friendly timer helper with smudge/Obambo/ghost-speed state and simple web-panel portability |

### Consolidation note

This family matters because a tiny domain tool can be valuable in VR when it is
transparent, focus-aware, reversible, and honest about game-data freshness.

## Family 411: Unity XR input event facades

This family covers small Unity/XRI wrappers that convert controller feature
state into reusable event streams for prototypes, teaching projects, and helper
tools.

| Project | Status | Notes |
|---|---|---|
| `Volorf/XR-Emitter` | Studied in Wave 432 | Unity XRI per-hand controller event facade with trigger/grip/button/2D-axis static events and demo subscribers |

### Consolidation note

This family matters because small VR utility prototypes benefit from readable
input events, but the facade must make lifecycle, device ownership, and action
map compatibility explicit.

## Family 412: Scientific VR annotation workbenches

This family covers point-cloud annotation, image-stack tracing, gaze/controller
selection, label palettes, bounding boxes, annotation graphs, native dataset
adapters, and export schemas.

| Project | Status | Notes |
|---|---|---|
| `RMonica/vr_hand_gaze_annotation` | Studied in Wave 433 | Quest Pro point-cloud annotation with eye/controller/box modes, PCL native plugin, label colors, and point search/export |
| `newgen211/Vr-axion` | Studied in Wave 433 | Neuron image-stack annotation with z-spaced quads, raycast point placement, line connections, edit modes, and JSON export |

### Consolidation note

This family matters because scientific VR tools need data provenance, coordinate
frames, interaction mode labels, and export schemas as first-class product
features.

## Family 413: Educational XR model annotation and passthrough retrofits

This family covers educational model viewers, part labels, callouts, exploded
views, large-asset setup, learning modes, and migration of legacy VR scenes into
mixed-reality passthrough contexts.

| Project | Status | Notes |
|---|---|---|
| `Chinmay-HS/AeroVerse-XR-Headsets` | Studied in Wave 434 | OpenXR/XRI educational model viewer with dynamic annotations, model selection, external asset hydration, and build workflow notes |
| `MixedRealityDevelopment-CalebCram/Neuroanatomy_Passthrough_Quest2` | Studied in Wave 434 | Legacy neuroanatomy VR app retrofitted for Quest passthrough with OVRInput interactions and scene/background caveats |

### Consolidation note

This family matters because reusable education tools need a clear split between
model metadata, callout behavior, asset provenance, runtime capabilities, and
legacy retrofit caveats.

## Family 414: HoloLens OpenXR repro and MRTK micro-samples

This family covers minimal HoloLens repro projects, tracking-state displays,
OpenXR/MRTK package snapshots, hand-touch microgames, and thin tutorial/setup
references.

| Project | Status | Notes |
|---|---|---|
| `camnewnham/Unity-Repro-OpenXR-TrackingLoss` | Studied in Wave 435 | Minimal HoloLens tracking-loss repro with package versions, steps, ARSession/head/center-eye text, and spatial mesh expectation |
| `Purecon/Hololens-SphereDefender-` | Studied in Wave 435 | MRTK/OpenXR sphere-defense microgame with ScriptableObject waves, sphere-surface spawning, and hand-touch hook |
| `nikolajIvanov/MRTK-Tutorial` | Thin setup pass in Wave 435 | Scene/package setup reference with local MRTK archives and Microsoft Mixed Reality OpenXR manifest |

### Consolidation note

This family matters because small repros and micro-samples are useful when they
preserve exact package versions, visible runtime state, and honest donor-scope
labels.

## Family 415: Unity calibration micro-libraries

This family covers coordinate-space alignment, viewer/screen profile
calibration, visible calibration error, tooltip/controller-tip calibration,
screen DPI/safe-area correction, and transform/profile persistence.

| Project | Status | Notes |
|---|---|---|
| `MaxHeimbrock/KabschCalibrationUnity` | Studied in Wave 436 | Unity Kabsch calibration package with source/target point capture, mean-distance error, tooltip calibration, editor point authoring, and JSON transform persistence |
| `epyyny/google_cardboard_calibration_unity_plugin` | Studied in Wave 436 | Cardboard XR fork adding ruler/DPI calibration and XRLoader screen-parameter handoff with Android/OpenGLES caveats |

### Consolidation note

This family matters because calibration is a reusable utility layer when sample
capture, solver/measurement boundaries, error labels, runtime parameter handoff,
and saved artifacts are explicit.

## Family 416: VR accessibility visibility and design playgrounds

This family covers editor-to-headset visibility tools, accessibility review
surfaces, height/scale controls, locomotion toggles, hand/interaction variants,
and small scenes for comparing comfort/accessibility choices.

| Project | Status | Notes |
|---|---|---|
| `hai-vr/let-me-see` | Studied in Wave 437 | Unity editor-driven VR visibility harness with XR lifecycle control, camera alignment modes, user height/rescale settings, and repaint/restore hooks |
| `GuillemD/VRDesignPlayground` | Studied in Wave 437 | Unity accessibility design playground with height, locomotion, hand presence, offset grab, custom throw, and physics button primitives |

### Consolidation note

This family matters because accessibility work needs both reviewer visibility
and small comparable design knobs, not only final-app settings menus.

## Family 417: Inclusive VR impairment and mobility simulations

This family covers wheelchair navigation scenarios, impairment profile switching,
visual/motor condition filters, educational empathy framing, support settings,
and caveat labels that keep simulation claims honest.

| Project | Status | Notes |
|---|---|---|
| `rehabnj/vr-wheelchair-simulator` | Studied in Wave 438 | Wheelchair accessibility awareness simulation with captions, brightness overlay, audio preference persistence, and scenario/product framing |
| `VlasiosKasapakis/VR4ALL` | README/thin source pass in Wave 438 | Impairment simulation reference with profile switching for visual and motor conditions, Unity/XR Toolkit asset framing, and external source caveats |

### Consolidation note

This family matters because inclusive-design simulations are useful when profile
taxonomy, support UI, scenario tasks, and educational caveats are separated from
unvalidated medical or lived-experience claims.

## Family 418: Modern XRI templates and setup-scope labels

This family covers Unity/XRI/OpenXR starter baselines, package manifests,
template asset grouping, validation scripts, small reusable controls, and
explicit labels for README-only or setup-only repos.

| Project | Status | Notes |
|---|---|---|
| `Fist-Full-of-Shrimp/Shrimp-XRI-Template` | Studied in Wave 439 | Unity 6/XRI 3.x template with OpenXR, XR Hands, accessibility module, validation rules, teleport/callout/knob/video controls, and Unity-sample provenance caveats |
| `BanQingTian/MultiPlayer_Unity_OpenXR` | README-only pass in Wave 439 | Placeholder repo with no inspected Assets/Packages/scripts and no code donor value despite useful title keywords |

### Consolidation note

This family matters because templates are only reusable when package versions,
sample provenance, removable scope, and donor value are visible.

## Recommended synthesis path for `VR-apps-lab`

The next useful step is not another long unsorted list.

It is:

1. build product concepts around `families`, not repos;
2. prioritize deep dives where status is `Partially studied` or
   `Not studied deeply`;
3. keep forks/variants as comparison nodes instead of promoting each one to a
   full standalone research wave.
