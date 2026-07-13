# Project Registry

- Date: `2026-04-21`
- Scope: canonical grouped registry of repositories currently tracked by
  `VR-apps-lab`
- Purpose: make every tracked project discoverable through one file, with a
  visible family and current study status.

## Status legend

- `Already studied`
- `Partially studied`
- `Not studied deeply`
- `Fork / variant only`

## How to use this file

- Use this as the canonical "what is in scope" registry.
- Treat this file as the single source of truth for per-repository study
  status.
- If status wording in another document differs, this file wins.
- Use `../landscape/project-families.md` to understand family overlap.
- Use `../landscape/not-yet-studied-deeply.md` for priority next passes.
- Use `../program/study-method.md` and `../templates/project-study-template.md`
  when deepening an entry.

## 1. SDKs, runtimes, templates, and base frameworks

Primary docs:

- `../landscape/vr-utilities-repo-landscape.md`
- `../landscape/project-families.md`
- `../landscape/vr-projects-wave-11-runtime-adapters-virtual-displays-and-validation.md`
- `../landscape/vr-projects-wave-21-openxr-provider-stacks-gaze-layers-and-runtime-side-utility-platforms.md`

- `ValveSoftware/openvr` - `Already studied`
- `ValveSoftware/steamvr_unity_plugin` - `Already studied`
- `ValveSoftware/unity-xr-plugin` - `Already studied`
- `KhronosGroup/OpenXR-SDK-Source` - `Already studied`
- `1runeberg/OpenXRProvider` - `Already studied`
- `mbucchia/OpenXR-Layer-Template` - `Already studied`
- `Ybalrid/OpenXR-API-Layer-Template` - `Already studied`
- `StereoKit/StereoKit` - `Already studied`
- `OpenHMD/OpenHMD` - `Already studied`
- `leviathanch/monado` - `Already studied`
- `StardustXR/server` - `Already studied`
- `WiVRn/WiVRn` - `Already studied`

## 2. OpenXR runtime tools, API layers, overlay utilities, and diagnostics

Primary docs:

- `../landscape/vr-projects-wave-3-utilities.md`
- `../landscape/vr-projects-wave-10-runtime-bridge-and-headsetless-tools.md`
- `../landscape/vr-projects-wave-11-runtime-adapters-virtual-displays-and-validation.md`
- `../landscape/vr-projects-wave-9-runtime-overlay-devtools.md`
- `../landscape/vr-projects-wave-13-vision-tracking-hand-bridges-and-headsetless-camera-runtimes.md`
- `../landscape/vr-projects-wave-17-openxr-runtime-managers-layers-and-service-hosts.md`
- `../landscape/vr-projects-wave-21-openxr-provider-stacks-gaze-layers-and-runtime-side-utility-platforms.md`
- `../landscape/vr-projects-wave-25-headsetless-qa-runtimes-null-driver-helpers-and-virtual-device-simulators.md`
- `../landscape/vr-projects-wave-36-runtime-service-hosts-openxr-utility-platforms-and-layer-doctoring.md`
- `../landscape/vr-projects-wave-69-openxr-platform-shells-layer-managers-and-runtime-inspection-workbenches.md`
- `../landscape/vr-projects-wave-75-openxr-micro-layers-for-view-shaping-streamout-debugging-capture-and-frame-time-intervention.md`
- `../landscape/project-families.md`

- `mbucchia/OpenXR-Toolkit` - `Already studied`
- `mbucchia/OpenXR-Vk-D3D12` - `Already studied`
- `mbucchia/VirtualDesktop-OpenXR` - `Already studied`
- `KhronosGroup/OpenXR-Inventory` - `Already studied`
- `rpavlik/xr-picker` - `Already studied`
- `elliotttate/OpenXR-Simulator` - `Already studied`
- `davidrios/openxr-device-simulator` - `Not studied deeply`
- `ox-runtime/ox-sim-driver` - `Already studied`
- `chnoblouch/aethervr` - `Already studied`
- `fredemmott/OpenXR-API-Layers-GUI` - `Already studied`
- `WaGi-Coding/OpenXR-Runtime-Switcher` - `Already studied`
- `UniStuttgart-VISUS/OpenXR-Runtime-Switcher` - `Already studied`
- `ytdlder/OpenXR-Switcher` - `Already studied`
- `jonyrh/OXR_Switcher` - `Already studied`
- `shiena/OpenXRRuntimeSelector` - `Already studied`
- `Jabbah/OpenXR-Layer-OBSMirror` - `Already studied`
- `maluoi/openxr-explorer` - `Already studied`
- `LunarG/OpenXR-OverlayLayer` - `Already studied`
- `PlutoVR/OpenXR-OverlayLayer-1` - `Already studied`
- `Ybalrid/OpenXR-Runtime-Manager` - `Already studied`
- `clear-xr/clearxr-server` - `Already studied`
- `pembem22/etvr-openxr-layer` - `Already studied`
- `vrkit-platform/vrkit-platform` - `Already studied`
- `LunarG/OpenXR-Overlays-UE4-Plugin` - `Already studied`
- `rublev/OpenXR-RecenterOverride` - `Already studied`
- `mledour/OpenXR-Layer-crop-fov` - `Already studied`
- `haraldsteinlechner/openxr_streamout_layer` - `Already studied`
- `rAzoR8/openxr-renderdoc-layer` - `Already studied`
- `mbucchia/_ARCHIVE_OverXR` - `Fork / variant only`
- `mbucchia/Quad-Views-Foveated` - `Already studied`
- `mbucchia/OpenXR-Eye-Trackers` - `Already studied`
- `fzeruhn/Smoothing-OpenXR-Layer` - `Partially studied`

## 3. Compatibility layers and runtime translation

Primary docs:

- `../landscape/vr-utilities-repo-landscape.md`
- `../landscape/vr-projects-wave-23-glove-platforms-poser-stacks-and-nonstandard-hardware-bridge-drivers.md`

- `Supreeeme/xrizer` - `Already studied`
- `QuestCraftPlusPlus/OpenComposite` - `Already studied`
- `LibreVR/Revive` - `Already studied`
- `alvr-org/ALVR` - `Already studied`
- `OSVR/SteamVR-OSVR` - `Already studied`
- `terminal29/OSVR-SteamVR-Bridge` - `Already studied`

## 4. Desktop overlays, dashboards, and in-VR utility surfaces

Primary docs:

- `../landscape/vr-utilities-repo-landscape.md`
- `../landscape/vr-projects-wave-3-utilities.md`
- `../landscape/vr-projects-wave-7-depth-pass.md`
- `../landscape/vr-projects-foundational-waves-1-7-retro-normalization.md`
- `../landscape/vr-projects-wave-10-runtime-bridge-and-headsetless-tools.md`
- `../landscape/vr-projects-wave-9-runtime-overlay-devtools.md`
- `../landscape/vr-projects-wave-39-overlay-host-lineage-dashboard-shells-and-browser-backed-surfaces.md`
- `../landscape/vr-projects-wave-53-media-launcher-overlays-playback-surfaces-and-lightweight-in-headset-display-shells.md`
- `../landscape/vr-projects-wave-54-discord-voice-overlays-note-surfaces-and-context-status-micro-overlays.md`
- `../landscape/vr-projects-wave-55-creator-control-overlays-research-stations-and-specialized-companion-presence-surfaces.md`

- `glenimp617/DesktopXR` - `Already studied`
- `elvissteinjr/DesktopPlus` - `Already studied`
- `Hotrian/OpenVRDesktopDisplayPortal` - `Already studied`
- `CircuitLord/DesktopPortal` - `Already studied`
- `scudzey/UVROverlay` - `Already studied`
- `galister/WlxOverlay` - `Already studied`
- `matrixfurry/wlx-overlay-s` - `Already studied`
- `galister/wlx-overlay-x` - `Already studied`
- `PhialsBasement/fnuidesktop-VR` - `Already studied`
- `wayvr-org/wayvr` - `Already studied`
- `rrkpp/SpotifyOverlay` - `Already studied`
- `Hotrian/OpenVRTwitchChat` - `Already studied`
- `CrispyPin/ovr-utils` - `Partially studied`
- `mittorn/ovr-utils-dashboard` - `Already studied`
- `benotter/OVRLay` - `Already studied`
- `SDraw/openvr_widgets` - `Already studied`
- `artumino/SteamVR_HUDCenter` - `Already studied`
- `LapisGit/LapisOverlay` - `Already studied`
- `elvissteinjr/SteamVR-PrimaryDesktopOverlay` - `Already studied`
- `Nexz/turncountervr` - `Already studied as cable-awareness rotation counter micro-overlay`
- `Martin-Oehler/SteamVR-WebApps` - `Already studied`
- `OpenKneeboard/OpenKneeboard` - `Already studied`
- `dantman/elite-vr-cockpit` - `Already studied`
- `OVRTools/WhereIsForward` - `Already studied`
- `Mon-Ouie/launcher-openvr-overlay` - `Already studied`
- `Mon-Ouie/mpris-openvr-overlay` - `Already studied`
- `Mon-Ouie/vr-video-player-overlay` - `Already studied`
- `iigomaru/MPVR` - `Deepened in Wave 208; see overlay media micro-surface section 179`
- `hiinaspace/vr-notes-anywhere` - `Already studied`
- `jacklul/SteamVR-PhasmoMatrix` - `Already studied`
- `SteveMarkhamGIT/SmudgeTimerOpenVR` - `Already studied`

## 5. Notification, remote-control, and automation overlays

Primary docs:

- `../landscape/vr-projects-wave-3-utilities.md`
- `../landscape/vr-projects-wave-9-runtime-overlay-devtools.md`
- `../landscape/vr-projects-foundational-waves-1-7-retro-normalization.md`
- `../landscape/vr-projects-wave-39-overlay-host-lineage-dashboard-shells-and-browser-backed-surfaces.md`
- `../landscape/project-families.md`

- `BOLL7708/OpenVROverlayPipe` - `Already studied`
- `jeppevinkel/OpenVRNotificationPipe` - `Already studied`
- `WiiPlayer2/VnotifieR` - `Already studied`
- `BOLL7708/OpenVR2WS` - `Already studied`
- `BOLL7708/OpenVR2Key` - `Already studied`
- `Raphiiko/OyasumiVR` - `Already studied`
- `I5UCC/SteaMeeter` - `Already studied`
- `I5UCC/ParameterSaveStates` - `Deepened in Wave 324`
- `hai-vr/h-view` - `Already studied`
- `MeroFune/GOpy` - `Already studied as OSC gesture-parameter to HMD-relative overlay icon bridge`

## 6. Lighthouse managers, room state, and device power control

Primary docs:

- `../landscape/vr-projects-wave-3-utilities.md`
- `../landscape/vr-projects-wave-9-runtime-overlay-devtools.md`
- `../landscape/project-families.md`

- `kurotu/OVR-Lighthouse-Manager` - `Already studied`
- `DHCPCD9/go-steamvr-lighthouse-manager` - `Already studied`
- `xi-ve/openvr-lighthouse-manager-linux` - `Already studied`
- `nouser2013/lighthouse-v2-manager` - `Already studied`
- `SeeUnsharp/LighthouseManager` - `Already studied`
- `FennecLabsLtd/LighthouseManager` - `Already studied`
- `seader/LighthouseManagerPimax` - `Already studied`
- `risa2000/lhctrl` - `Already studied`
- `risa2000/lh2ctrl` - `Already studied`
- `ugokutennp/watchman-pairing-assistant` - `Already studied`

## 7. Battery, device inventory, and micro-monitor utilities

Primary docs:

- `../landscape/vr-projects-wave-4-gap-fill.md`
- `../landscape/vr-projects-wave-9-runtime-overlay-devtools.md`
- `../landscape/project-families.md`
- `../landscape/vr-projects-wave-7-depth-pass.md`
- `../landscape/vr-projects-foundational-waves-1-7-retro-normalization.md`
- `../landscape/vr-projects-wave-16-device-monitors-pose-exporters-and-environment-helpers.md`
- `../landscape/vr-projects-wave-55-creator-control-overlays-research-stations-and-specialized-companion-presence-surfaces.md`

- `OVRTools/OpenVRDeviceBattery` - `Already studied`
- `zeroae/VRBattery` - `Already studied`
- `copperpixel/steamvrbattery` - `Already studied`
- `Black4Blade/SteamVR-Devices-Battery-Status` - `Already studied`
- `KaftanOS/SteamVR-Battery-Checker` - `Already studied`
- `Denwa/vive-wireless-info-overlay` - `Source-light product reference for Vive Wireless temperature micro-overlays`
- `rhaamo/OpenVR-Display-Devices` - `Already studied`
- `jangxx/openvr-battery-monitoring` - `Already studied`
- `mutr/openvr_battery_monitor` - `Already studied`

## 8. Virtual trackers, OSC bridges, WebSocket bridges, and input export

Primary docs:

- `../landscape/vr-projects-wave-5-osc-tracking-tools.md`
- `../landscape/vr-projects-wave-6-driver-bridges.md`
- `../landscape/vr-projects-foundational-waves-1-7-retro-normalization.md`
- `../landscape/vr-projects-wave-10-runtime-bridge-and-headsetless-tools.md`
- `../landscape/vr-projects-wave-9-runtime-overlay-devtools.md`
- `../landscape/vr-projects-wave-13-vision-tracking-hand-bridges-and-headsetless-camera-runtimes.md`
- `../landscape/vr-projects-wave-14-tracker-ingress-osc-egress-and-role-binding-utilities.md`
- `../landscape/vr-projects-wave-23-glove-platforms-poser-stacks-and-nonstandard-hardware-bridge-drivers.md`
- `../landscape/vr-projects-wave-68-vmt-adapters-osc-action-compilers-and-skeletal-validation-utilities.md`
- `../landscape/project-families.md`

- `Timocop/PSMoveServiceEx-VMT` - `Already studied`
- `SlimeVR/SlimeVR-OpenVR-Driver` - `Already studied`
- `gpsnmeajp/VirtualMotionTracker` - `Already studied`
- `faidra/VMC2VMT` - `Already studied`
- `gpsnmeajp/SkeletonPoseTester` - `Already studied`
- `John-Dean/OpenVR-Tracker-Websocket-Driver` - `Already studied`
- `surplex-io/OpenVR-Driver` - `Fork / variant only`
- `ju1ce/Simple-OpenVR-Bridge-Driver` - `Already studied`
- `3NekoSystem/OpenVR-Tracker-Websocket-Driver` - `Fork / variant only`
- `v0xie/OpenVR-Tracker-Websocket-Driver` - `Fork / variant only`
- `krazysh01/VirtualDesktop-OpenVR-Trackers` - `Partially studied`
- `SophiaH67/soph_wireless` - `Already studied`
- `SophiaH67/soph_wireless_transmitter` - `Already studied`
- `Greendayle/SteamVR_To_OSC` - `Already studied`
- `ZekkVRC/OpenVR2OSC` - `Already studied`
- `BarakChamo/OpenVR-OSC` - `Already studied`
- `logicmachine/OVR-VRC-OSC-Bridge` - `Already studied`
- `jangxx/steamvr-osc-control` - `Already studied`
- `choyai/SteamVRTrackerUtility` - `Already studied`
- `jangxx/UniversalTrackerMarkers` - `Already studied`
- `TriadSemi/triad_openvr` - `Already studied`
- `biosmanager/unity-openvr-tracking` - `Already studied`
- `JLChnToZ/axis-vrc-osc-bridge` - `Already studied`
- `I5UCC/VRCThumbParamsOSC` - `Already studied`
- `TheNexusAvenger/Enigma` - `Not studied deeply`
- `ThatGuyThimo/leapmotion-osc` - `Not studied deeply`
- `ShayBox/VRC-OSC` - `Already studied`
- `VolcanicArts/VRCOSC` - `Already studied`
- `pottedmeat7/OpenVR-WalkInPlace` - `Already studied`
- `mdovgialo/steam-vr-wheel` - `Already studied`

## 9. Calibration, motion compensation, and tracking alignment

Primary docs:

- `../landscape/vr-utilities-repo-landscape.md`
- `../landscape/vr-projects-wave-4-gap-fill.md`
- `../landscape/vr-projects-foundational-waves-1-7-retro-normalization.md`
- `../landscape/vr-projects-wave-27-motion-compensation-calibration-overlays-and-spatial-alignment-tools.md`
- `../landscape/project-families.md`
- `../landscape/not-yet-studied-deeply.md`

- `pushrax/OpenVR-SpaceCalibrator` - `Already studied`
- `Stavdel/OpenVR-SpaceCalibrator` - `Already studied`
- `Marshall-vak/OpenVR-SpaceCalibrator2` - `Already studied`
- `BuzzteeBear/OpenXR-MotionCompensation` - `Already studied`
- `openvrmc/OpenVR-MotionCompensation` - `Already studied`
- `RedHawk989/EyeTrackVR-OpenVR-Calibration-Overlay` - `Already studied`
- `tobexeon/PSVR2EyeTrackingCalibration` - `Already studied as real-time PSVR2 eye-gaze calibration client`

## 10. Marker-based, camera-based, and low-cost full-body paths

Primary docs:

- `../landscape/vr-projects-wave-5-osc-tracking-tools.md`
- `../landscape/vr-projects-wave-13-vision-tracking-hand-bridges-and-headsetless-camera-runtimes.md`
- `../landscape/vr-projects-wave-22-vision-tracking-hosts-camera-full-body-bridges-and-hand-input-sidecars.md`

- `terminal29/VRUco` - `Already studied`
- `GoLez28/Aruco-TagTracking-VR` - `Already studied`
- `ju1ce/April-Tag-VR-FullBody-Tracker` - `Already studied`
- `KinectToVR/KinectToVR` - `Already studied`
- `KinectToVR/Amethyst` - `Already studied`
- `ju1ce/Mediapipe-VR-Fullbody-Tracking` - `Already studied`
- `Wunder-Wulfe/NVIDIA-BodyTracking` - `Already studied`
- `MasonSakai/VR-AI-Full-Body-Tracking` - `Deepened in Wave 210; see MediaPipe/avatar tracking sidecar section 181`

## 11. Passthrough, camera, and reality tools

Primary docs:

- `../landscape/vr-utilities-repo-landscape.md`
- `../landscape/vr-projects-wave-10-runtime-bridge-and-headsetless-tools.md`
- `../landscape/vr-projects-wave-27-motion-compensation-calibration-overlays-and-spatial-alignment-tools.md`
- `../landscape/project-families.md`

- `Rectus/openxr-steamvr-passthrough` - `Already studied`
- `zhangxuelei86/WMR-Passthrough` - `Already studied`
- `Danealor/VRPassthrough` - `Already studied`
- `jangxx/LeapOVRPassthrough` - `Already studied`
- `alexander-clarke/openvr-room-mapping` - `Already studied`

## 12. Performance, image processing, and rendering mods

Primary docs:

- `../landscape/vr-projects-wave-20-performance-mods-graphics-injection-and-vr-sweet-spot-shaders.md`

- `fholger/vrperfkit` - `Already studied`
- `fholger/openvr_fsr` - `Already studied`
- `RavenSystem/VRPerfKit_RSF` - `Already studied`
- `CamelCaseName/OpenVRPerfKit` - `Already studied`
- `Granther/foveated-rendering` - `Already studied`
- `retroluxfilm/reshade-vrtoolkit` - `Already studied`
- `zhukovv/upscale-injection` - `Already studied`

## 13. Vendor enhancement, custom hardware, and driver plumbing

Primary docs:

- `../landscape/vr-projects-wave-6-driver-bridges.md`
- `../landscape/vr-projects-foundational-waves-1-7-retro-normalization.md`
- `../landscape/vr-projects-wave-10-runtime-bridge-and-headsetless-tools.md`
- `../landscape/vr-projects-wave-11-runtime-adapters-virtual-displays-and-validation.md`
- `../landscape/vr-projects-wave-13-vision-tracking-hand-bridges-and-headsetless-camera-runtimes.md`
- `../landscape/vr-projects-wave-18-driver-learning-paths-and-repurposed-display-bridges.md`
- `../landscape/vr-projects-wave-19-vendor-mods-repurposed-output-bridges-and-alternative-hardware-paths.md`
- `../landscape/vr-projects-wave-23-glove-platforms-poser-stacks-and-nonstandard-hardware-bridge-drivers.md`
- `../landscape/vr-projects-wave-26-vendor-ipc-ecosystems-glasses-bridges-and-official-stack-enhancement-tools.md`
- `../landscape/vr-projects-wave-37-mixed-vr-controller-bridges-driver-side-input-emulation-and-hand-tracking-adaptation.md`
- `../landscape/vr-projects-wave-70-mixed-vr-controller-bridges-hand-emulation-and-external-tracker-interop.md`
- `../landscape/vr-projects-wave-71-openvr-driver-learning-paths-synthetic-devices-and-remote-input-ingress.md`
- `../landscape/not-yet-studied-deeply.md`

- `BnuuySolutions/PSVR2Toolkit` - `Already studied`
- `BnuuySolutions/PSVR2Toolkit.VRCFT` - `Already studied`
- `s-ilent/PSVR2ToolkitTriggerConfig` - `Already studied`
- `tabithamoon/ResonitePSVR2` - `Already studied`
- `ChristophHaag/SteamVR-OpenHMD` - `Already studied`
- `mm0zct/Oculus_Touch_Steam_Link` - `Already studied`
- `kodowiec/Yet-Another-OpenVR-IPC-Driver` - `Already studied`
- `bdub1011/Quest-Link-Hand-Tracking` - `Partially studied`
- `mSparks43/PSVR-SteamVR-openHMD` - `Already studied`
- `oleuzop/VirtualSteamVRDriver` - `Already studied`
- `finallyfunctional/openvr-driver-example` - `Already studied`
- `Somebody32x2/RemoteVVR` - `Already studied`
- `codeysun/OpenVR-Tracker-Driver-Example` - `Already studied`
- `SecondReality/VirtualControllerDriver` - `Already studied`
- `oneup03/VRto3D` - `Already studied`
- `ValveSoftware/driver_hydra` - `Already studied`
- `r57zone/Razer-Hydra-SteamVR-driver` - `Already studied`
- `alatnet/OpenPSVR` - `Already studied`
- `r57zone/OpenVR-driver-for-DIY` - `Already studied`
- `gpsnmeajp/SegsVRControllerDriverSample` - `Already studied`
- `puresoul/Barebone` - `Already studied`
- `mmorselli/Joy2OpenVR` - `Already studied`
- `mdovgialo/SteamVR-Glove` - `Already studied`
- `ultraleap/driver_ultraleap` - `Already studied`
- `Nordskog/HandOfLesser` - `Already studied`
- `NovaAshwolfDev/HandCameraDriver` - `Already studied`
- `OpenDisplayXR/OpenDisplayXR-VDD` - `Inaccessible during latest remote check; keep as signal-only backlog node`
- `verncat/RayNeo-Air-3S-Pro-OpenVR` - `Already studied`
- `verncat/RayNeo-Air-3S-Pro-OpenVR-Driver` - `Already studied`
- `LucidVR/opengloves-driver` - `Already studied`
- `LucidVR/lucidgloves` - `Already studied`
- `HoboVR-Labs/hobo_vr` - `Already studied`
- `r57zone/OpenVR-ArduinoHMD` - `Already studied`
- `DaniXmir/GlassVr` - `Already studied`
- `terminal29/Simple-OpenVR-Driver-Tutorial` - `Already studied`
- `Copprhead/hotas-vr-controller` - `Already studied`
- `r57zone/OpenVR-OpenTrack` - `Already studied`
- `TrueOpenVR/SteamVR-TrueOpenVR` - `Partially studied`
- `matzman666/OpenVR-InputEmulator` - `Already studied`
- `Erimelowo/OpenVR-InputEmulator-Fixed` - `Already studied`
- `wirelessdreamer/OpenVR-InputEmulator` - `Already studied`

## 14. SteamVR environment helpers and runtime hygiene tools

Primary docs:

- `../landscape/vr-projects-wave-8-github-source-pass.md`
- `../landscape/vr-projects-foundational-waves-1-7-retro-normalization.md`
- `../landscape/vr-projects-wave-10-runtime-bridge-and-headsetless-tools.md`
- `../landscape/vr-projects-wave-11-runtime-adapters-virtual-displays-and-validation.md`
- `../landscape/vr-projects-wave-9-runtime-overlay-devtools.md`
- `../landscape/vr-projects-wave-16-device-monitors-pose-exporters-and-environment-helpers.md`
- `../landscape/vr-projects-wave-25-headsetless-qa-runtimes-null-driver-helpers-and-virtual-device-simulators.md`
- `../landscape/vr-projects-wave-38-steamvr-validation-patchers-and-environment-hygiene-micro-tools.md`
- `../landscape/project-families.md`

- `BnuuySolutions/OculusKiller` - `Already studied`
- `username223/SteamVRNoHeadset` - `Already studied`
- `n1ckfg/ViveTrackerExample` - `Already studied`
- `craftyinsomniac/WFOVFix` - `Already studied`
- `BnuuySolutions/SteamVRLinuxFixes` - `Already studied`
- `MuffinTastic/steamvr-exconfig` - `Already studied`
- `simonowen/dashfix` - `Already studied`
- `sencercoltu/steamvr-undistort` - `Already studied`
- `W-Drew/SteamVR-Toggle` - `Already studied`
- `elvissteinjr/SteamVR-VoidScene` - `Already studied`
- `shieldmeidunn/SteamVRNullFlipper` - `Already studied`
- `Virus-vr/SteamVRAdaptiveBrightness` - `Already studied`
- `username223/SteamVR-ActionsManifestValidator` - `Already studied`
- `Erimelowo/Lighthouse-Scale-Fix` - `Already studied`
- `DavidRisch/steamvr_utils` - `Already studied`

## 15. Overlay implementation references and templates

Primary docs:

- `../landscape/vr-projects-wave-8-github-source-pass.md`
- `../landscape/vr-projects-foundational-waves-1-7-retro-normalization.md`
- `../landscape/vr-projects-wave-9-runtime-overlay-devtools.md`
- `../landscape/vr-projects-wave-39-overlay-host-lineage-dashboard-shells-and-browser-backed-surfaces.md`
- `../landscape/project-families.md`
- `../landscape/vr-projects-wave-52-overlay-render-scaffolds-ui-to-texture-bridges-and-engine-native-projection-overlays.md`

- `sh-akira/VROverlay` - `Already studied`
- `BenWoodford/SteamVR-Webkit` - `Already studied`
- `BenWoodford/OVROverlayManager` - `Already studied`
- `beniwtv/vr-streaming-overlay` - `Already studied`
- `Nyabsi/steamvr_overlay_vulkan` - `Already studied`
- `Hotrian/HeadlessOverlayToolkit` - `Already studied`
- `cnlohr/openvr_overlay_model` - `Already studied`
- `JoeLudwig/overlay_experiments` - `Already studied`
- `KainosSoftwareLtd/VRSceneOverlay` - `Already studied`
- `foxt/csharp-openvr-overlay-imgui` - `Already studied`
- `hiinaspace/godot-openvr-overlay` - `Already studied`
- `ondorela/OpenVROverlay_imgui` - `Already studied`
- `thomasmo/SampleVRO` - `Already studied`
- `ovrlay/LibOverlay` - `Already studied`
- `Marlamin/VROverlayTest` - `Already studied as C# OpenTK/OpenVR texture submission scratchpad`
- `ephemeral-laboratories/ComposeVR` - `Not studied deeply`

## 16. Creator, capture, metrics, and workflow tools

Primary docs:

- `../landscape/vr-projects-master-index.md`
- `../landscape/vr-projects-wave-7-depth-pass.md`
- `../landscape/vr-projects-wave-10-runtime-bridge-and-headsetless-tools.md`
- `../landscape/vr-projects-wave-11-runtime-adapters-virtual-displays-and-validation.md`
- `../landscape/vr-projects-wave-9-runtime-overlay-devtools.md`
- `../landscape/vr-projects-wave-16-device-monitors-pose-exporters-and-environment-helpers.md`
- `../landscape/vr-projects-wave-55-creator-control-overlays-research-stations-and-specialized-companion-presence-surfaces.md`
- `../landscape/vr-projects-wave-74-openvr-capture-replay-and-orchestration-toolchains.md`

- `baffler/OBS-OpenVR-Input-Plugin` - `Already studied`
- `ValveSoftware/virtual_display` - `Already studied`
- `BOLL7708/SuperScreenShotterVR` - `Already studied`
- `iigomaru/Periodic-Immersive-SteamVR-Screenshots` - `Already studied`
- `xrtlab/clovr` - `Already studied`
- `Nyabsi/openvr-metrics` - `Already studied`
- `ethanporcaro/tracking-toolkit` - `Already studied`
- `fredemmott/XRFrameTools` - `Already studied`
- `peacepenguin/Virtual-Display-Driver` - `Already studied`
- `ValveSoftware/OpenXR-Canonical-Pose-Tool` - `Already studied`
- `MuffinTastic/openvr-device-positions` - `Already studied`
- `99oblivius/VRBro-Overlay` - `Already studied`
- `kuentzel/ROVER` - `Already studied`
- `NVIDIA/vr-capture-replay` - `Already studied`
- `CodeSmith2000/virtual-camera-offset` - `Already studied`
- `wrainw/VRScout_Agent_Orchestration_Unity_Project` - `Partially studied`
- `TrackLab/ViRe` - `Already studied`

## 17. Accessibility, assistive HUDs, and comfort tools

Primary docs:

- `../landscape/project-families.md`
- `../landscape/vr-projects-wave-3-utilities.md`
- `../landscape/vr-projects-wave-8-github-source-pass.md`
- `../landscape/vr-projects-wave-9-runtime-overlay-devtools.md`
- `../landscape/vr-projects-wave-24-accessibility-captions-and-assistive-overlay-utilities.md`
- `../landscape/vr-projects-wave-55-creator-control-overlays-research-stations-and-specialized-companion-presence-surfaces.md`

- `Beyley/eepyxr` - `Already studied`
- `Vinventive/live-captions-vr` - `Already studied`
- `MochiDoesVR/OpenVRCaptions` - `Already studied`
- `ctobin1114/UniversalVR-CC` - `Already studied`
- `gt0777/VRCLiveCaptionsMod` - `Already studied`
- `matzman666/OpenVR-MicrophoneControl` - `Already studied`
- `rrazgriz/VRCMicOverlay` - `Already studied`
- `I5UCC/VRCTextboxSTT` - `Already studied`
- `Otter-Co/TurnSignal` - `Already studied`
- `Deryck2000/SteamVR_ClockOverlay_Public` - `Already studied`
- `lukis101/VRPoleOverlay` - `Already studied`

## 18. Text entry, tracked keyboards, and non-native input surfaces

Primary docs:

- `../landscape/vr-projects-wave-28-text-entry-tracked-keyboards-and-non-native-input-surfaces.md`
- `../landscape/vr-projects-wave-30-spatial-ui-interaction-frameworks-and-input-stacks.md`
- `../landscape/project-families.md`

- `campfireunion/VRKeys` - `Already studied`
- `ultraleap/XR-Keyboard` - `Already studied`
- `oculus-samples/Unity-TrackedKeyboard` - `Already studied`
- `Ayfel/MRTK-Keyboard` - `Already studied`
- `RTUITLab/Oculus-HandTracking-Keyboard` - `Already studied`

## 19. Hand, palm, radial, and quick-access menus

Primary docs:

- `../landscape/vr-projects-wave-29-hand-palm-radial-and-quick-access-menus.md`
- `../landscape/vr-projects-wave-30-spatial-ui-interaction-frameworks-and-input-stacks.md`
- `../landscape/project-families.md`

- `NovaUI-Unity/XRHandMenuSample` - `Already studied`
- `Housz/VRMenuDesigner` - `Already studied`
- `Oyshoboy/RadialMenuVR` - `Already studied`
- `yusufalibrahim1994/UnityXR-Physicalized-Radial-Menu` - `Already studied`
- `auroreRakoto/XR-UI-Prototype` - `Already studied`

## 20. Spatial UI interaction frameworks and input stacks

Primary docs:

- `../landscape/vr-projects-wave-28-text-entry-tracked-keyboards-and-non-native-input-surfaces.md`
- `../landscape/vr-projects-wave-29-hand-palm-radial-and-quick-access-menus.md`
- `../landscape/vr-projects-wave-30-spatial-ui-interaction-frameworks-and-input-stacks.md`
- `../landscape/project-families.md`

- `Unity-Technologies/XR-Interaction-Toolkit-Examples` - `Already studied`
- `microsoft/MixedRealityToolkit-Unity` - `Already studied`
- `MixedRealityToolkit/MixedRealityToolkit-Unity` - `Partially studied`
- `ViveSoftware/ViveInputUtility-Unity` - `Already studied`
- `Unity-Technologies/mr-example-meta-openxr` - `Already studied`

## 21. Teleoperation workspaces and embodied control surfaces

Primary docs:

- `../landscape/vr-projects-wave-31-teleoperation-workspaces-and-embodied-control-surfaces.md`
- `../landscape/project-families.md`

- `leggedrobotics/unity_ros_teleoperation` - `Already studied`
- `h2r/ros_reality` - `Already studied`
- `elpis-lab/UR10_Teleop` - `Already studied`
- `pollen-robotics/ReachyTeleoperation` - `Already studied`
- `nakama-lab/VR_Teleop_Interface` - `Deepened in Wave 211; see VR teleoperation control section 182`
- `h2r/GHOST` - `Deepened in Wave 211; see VR teleoperation control section 182`

## 22. Social overlays, communication sidecars, and companion surfaces

Primary docs:

- `../landscape/vr-projects-wave-32-social-overlays-communication-sidecars-and-vrchat-companion-surfaces.md`
- `../landscape/project-families.md`
- `../landscape/vr-projects-wave-54-discord-voice-overlays-note-surfaces-and-context-status-micro-overlays.md`
- `../landscape/vr-projects-wave-55-creator-control-overlays-research-stations-and-specialized-companion-presence-surfaces.md`

- `designeerlabs/discord-vr` - `Already studied`
- `kittynXR/VRCattoChatto` - `Already studied`
- `Wolf-G88/vrchat-proximity-app` - `Already studied`
- `Sharrnah/whispering` - `Already studied as local multimodal speech/OCR/TTS platform with websocket overlay and VRChat OSC fan-out`
- `Larsundso/SteamVR-Discord-Overlay` - `Already studied`
- `Artemol/DiscOverlay` - `Already studied`
- `imagitama/steamvr-overlay-vrbuddy` - `Already studied`
- `beareogaming/BD-XSOverlay-notify` - `Already studied as BetterDiscord to XSOverlay WebSocket notification bridge`

## 23. Alternative OpenXR runtimes, special-display paths, and platform experiments

Primary docs:

- `../landscape/vr-projects-wave-33-alternative-openxr-runtimes-and-special-display-paths.md`
- `../landscape/project-families.md`

- `DisplayXR/displayxr-runtime` - `Already studied`
- `JoeyAnthony/XRGameBridge` - `Already studied`
- `warrenm/OpenXRKit` - `Already studied`
- `rinsuki/FruitXR` - `Already studied`
- `maximum-game-22/openxr-3d-display` - `Fork / variant only; canonical upstream studied as dfattal/openxr-3d-display`
- `Kartaverse/OpenDisplayXR` - `Not studied deeply`

## 24. Tracked-device geometry, CAD, and auxiliary tracker tooling

Primary docs:

- `../landscape/vr-projects-wave-34-tracked-device-geometry-cad-and-auxiliary-tracker-tooling.md`
- `../landscape/project-families.md`

- `fughilli/ViveTrackedDevice` - `Partially studied`
- `TriadSemi/Fusion360_SteamVR_Json` - `Already studied`
- `aughip/augmented-hip` - `Already studied`
- `m9cd0n9ld/IMU-VR-Full-Body-Tracker` - `Already studied`
- `ebadier/ViveTrackers` - `Not studied deeply`

## 25. Expressive tracking and avatar-facing input bridges

Primary docs:

- `../landscape/vr-projects-wave-35-expressive-tracking-and-avatar-facing-input-bridges.md`
- `../landscape/project-families.md`

- `Project-Babble/Baballonia` - `Already studied`
- `jcorvinus/HandshakeVR` - `Already studied`
- `moshimeow/mercury_steamvr_driver` - `Already studied`
- `BattleAxeVR/PSVR2_OpenXR_Eye_Tracking` - `Already studied`
- `takana-v/quest_steamvr_fbt_tool` - `Already studied as simple OpenVR-to-VRChat OSC FBT tracker bridge in Wave 163`

## 26. VRChat chatbox, STT, and text-surface sidecars

Primary docs:

- `../landscape/vr-projects-wave-40-vrchat-chatbox-stt-and-text-surface-sidecars.md`
- `../landscape/vr-projects-wave-48-chatbox-mobile-relays-translation-shells-and-avatar-text-surfaces.md`
- `../landscape/project-families.md`

- `BoiHanny/vrcosc-magicchatbox` - `Already studied`
- `ScrapW/Chatbox` - `Already studied`
- `misyaguziya/VRCT` - `Already studied`
- `killfrenzy96/KillFrenzyAvatarText` - `Already studied`
- `dbqt/VRCOSCChatbox` - `Already studied`
- `yum-food/TaSTT` - `Already studied`
- `cyberkitsune/vrc-osc-scripts` - `Already studied`
- `nyakowint/xsoverlay-keyboard-osc` - `Already studied`
- `I5UCC/VRCTextboxOSC` - `Already studied`
- `Lioncat6/OSC-Chat-Tools` - `Already studied`
- `I5UCC/VRCTextboxSTT` - `Already studied`

## 27. Avatar-facing OSC companions, routers, and consumer automation sidecars

Primary docs:

- `../landscape/vr-projects-wave-41-avatar-facing-osc-companions-routers-and-consumer-automation.md`
- `../landscape/vr-projects-wave-49-oscquery-companion-frameworks-ai-bridges-and-parameter-smoothing.md`
- `../landscape/project-families.md`

- `OscToys/OscGoesBrrr` - `Already studied`
- `valuef/VRCRouter` - `Already studied`
- `Sergey004/Quest2-VRC` - `Already studied`
- `I5UCC/VRCMeeter` - `Already studied`
- `I5UCC/VRCAvatarParameterSync` - `Already studied`
- `ZenithVal/OSCLeash` - `Already studied`
- `ZenithVal/OSCLock` - `Already studied`
- `lenoobkinda/VRCOSCUtils` - `Partially studied`
- `vrchat-community/vrc-oscquery-lib` - `Already studied`
- `Krekun/vrchat-mcp-osc` - `Already studied`
- `regzo2/OSCmooth` - `Already studied`

## 28. XR-glasses virtual displays, workspace shells, and spatial screen utilities

Primary docs:

- `../landscape/vr-projects-wave-42-xr-glasses-virtual-display-stacks-and-spatial-screen-utilities.md`
- `../landscape/vr-projects-wave-50-xr-glasses-workspace-shells-openvr-hmd-paths-and-head-tracked-screen-tools.md`
- `../landscape/project-families.md`

- `wheaney/XRLinuxDriver` - `Already studied`
- `wheaney/breezy-desktop` - `Already studied`
- `wheaney/decky-XRGaming` - `Already studied`
- `MolotovCherry/virtual-display-rs` - `Already studied`
- `mgschwan/viture_virtual_display` - `Already studied`
- `lc700x/desktop2stereo` - `Already studied`
- `wheaney/OpenVR-xrealAirGlassesHMD` - `Already studied`
- `iVideoGameBoss/PhoenixHeadTracker` - `Already studied`
- `peacepenguin/Virtual-Display-Driver` - `Already studied`

## 29. Wearable haptics, tactile bridges, and avatar-driven feedback systems

Primary docs:

- `../landscape/vr-projects-wave-43-wearable-haptics-tactile-bridges-and-avatar-driven-feedback.md`
- `../landscape/project-families.md`

- `OpenShock/ShockOSC` - `Already studied`
- `bhaptics/VRChatOSC` - `Already studied`
- `senseshift/senseshift-firmware` - `Already studied`
- `senseshift/senseshift-hardware` - `Already studied`
- `Z4urce/VRC-Haptic-Pancake` - `Already studied`
- `lebaston100/vrc-patpatpat` - `Already studied`
- `shadorki/vrc-owo-suit` - `Already studied`
- `Python1320/vrcjoycon` - `Already studied`

## 30. Playspace editors, boundary importers, and shared-space helpers

Primary docs:

- `../landscape/vr-projects-wave-44-playspace-editors-boundary-importers-and-shared-space-helpers.md`
- `../landscape/project-families.md`

- `Xavr0k/ChaperoneTweak` - `Already studied`
- `FrostyCoolSlug/xr-chaperone` - `Already studied`
- `Sgeo/Guardian2Chaperone` - `Already studied`
- `hai-vr/unity-chaperone-tweaker` - `Already studied`
- `Rafacasari/Playspace-Mover` - `Already studied`
- `mdovgialo/OpenVRSharedPlayspace` - `Already studied`
- `LIV/RotatoExpress` - `Already studied`

## 31. Redirected-walking toolkits, locomotion adaptation, and space-redirection research

Primary docs:

- `../landscape/vr-projects-wave-45-redirected-walking-toolkits-locomotion-sidecars-and-space-redirection-research.md`
- `../landscape/project-families.md`

- `USC-ICT-MxR/RDWT` - `Already studied`
- `yaoling1997/OpenRDW` - `Already studied`
- `omegafantasy/OpenRDW2` - `Already studied`
- `ElectricNightOwl/ArmSwinger` - `Already studied`
- `Knerten0815/VR_Dodge_Study` - `Fork / variant only`

## 32. XR latency measurement, recording parsers, and experiment harnesses

Primary docs:

- `../landscape/vr-projects-wave-46-xr-latency-measurement-recording-parsers-and-experiment-harnesses.md`
- `../landscape/project-families.md`

- `immersivecognition/motion-to-photon-measurement` - `Already studied`
- `vr-thi/VRLate` - `Already studied`
- `Greendayle/VR-Motion-to-photon-latency-` - `Partially studied`
- `HARPLab/dreyevr_recording_analyzer` - `Already studied`
- `HARPLab/DReyeVR-parser` - `Already studied`
- `ratcave/vrlatency` - `Already studied`

## 33. Simulation telemetry overlays, motion-cueing bridges, and sim-sidecar platforms

Primary docs:

- `../landscape/vr-projects-wave-47-telemetry-overlays-motion-cueing-bridges-and-sim-sidecar-platforms.md`
- `../landscape/project-families.md`

- `TinyPedal/TinyPedal` - `Already studied`
- `walmis/VPforce-TelemFFB` - `Already studied`
- `PHARTGAMES/SpaceMonkey` - `Already studied`
- `SimFeedback/SimFeedback-AC-Servo` - `Already studied`
- `HARPLab/DReyeVR` - `Already studied`
- `giuseppdimaria/Unity-VRlines` - `Partially studied`

## 34. Biometric, neurofeedback, and accessory-control bridges

Primary docs:

- `../landscape/vr-projects-wave-51-biometric-bridges-neurofeedback-osc-and-accessory-control-platforms.md`
- `../landscape/project-families.md`

- `Honzackcz/PulsoidToOSC` - `Already studied`
- `nullstalgia/iron-heart` - `Already studied`
- `vard88508/vrc-osc-miband-hrm` - `Already studied`
- `DASPRiD/vrc-osc-manager` - `Already studied`
- `nullstalgia/OpenShock-ESP-Legacy` - `Already studied`
- `ChilloutCharles/BrainFlowsIntoVRChat` - `Already studied`

## 35. Browser-backed overlay runtimes, web-tech hosts, and UI runtime experiments

Primary docs:

- `../landscape/vr-projects-wave-56-browser-backed-overlay-runtimes-web-tech-hosts-and-ui-runtime-experiments.md`
- `../landscape/vr-projects-wave-73-wayvr-ecosystem-add-ons-linux-dashboard-extensions-and-ipc-backed-overlay-surfaces.md`
- `../landscape/project-families.md`

- `mekanoe/ovrsalt` - `Already studied`
- `mekanoe/electron-openvr` - `Already studied`
- `joshperry/ovrly` - `Already studied`
- `ephemeral-laboratories/ComposeVR` - `Already studied`
- `oo8dev/wayvr-dashboard` - `Already studied`

## 36. Linux overlay control shells, desktop-service panels, and interaction variants

Primary docs:

- `../landscape/vr-projects-wave-57-linux-overlay-control-shells-desktop-service-panels-and-interaction-variants.md`
- `../landscape/vr-projects-wave-73-wayvr-ecosystem-add-ons-linux-dashboard-extensions-and-ipc-backed-overlay-surfaces.md`
- `../landscape/project-families.md`

- `galister/OVR4X11` - `Already studied`
- `DrogonMar/SVRLinuxTools` - `Already studied`
- `Dragon092/OpenVR_Audio_Manager` - `Already studied`
- `oo8dev/wayvr` - `Already studied`
- `oo8dev/wayvr-ipc` - `Already studied`
- `noideaman/WayvrWalltaker` - `Already studied`
- `CrispyPin/sinpin-vr` - `Not studied deeply`

## 37. Micro-overlays, timed status surfaces, and plugin-fed informational display helpers

Primary docs:

- `../landscape/vr-projects-wave-58-micro-overlays-timed-status-surfaces-and-plugin-fed-informational-display-helpers.md`
- `../landscape/project-families.md`

- `R-VUt/OVRBrightnessAPI` - `Already studied`
- `CorvinRyder/VR-Slideshow-Overlay` - `Already studied`
- `Podshot/VRSessionTimer` - `Already studied`
- `Yukiiro-Nite/notebook-vr-overlay` - `Deepened in Wave 208; see overlay media micro-surface section 179`

## 38. Embodied locomotion overlays, live tuning surfaces, and external-device control panels

Primary docs:

- `../landscape/vr-projects-wave-59-embodied-locomotion-overlays-live-tuning-surfaces-and-external-device-control-panels.md`
- `../landscape/project-families.md`

- `hiinaspace/bikeheadvr` - `Already studied`
- `MartyDude20/Omni-Tune` - `Already studied`
- `OpenShock/OVR-Shock` - `Already studied`
- `OpenShock/VROverlay` - `Partially studied`
- `NewChromantics/PopExposeXr` - `Not studied deeply`

## 39. Code-first overlay scaffolds, projection samples, and window-to-texture baselines

Primary docs:

- `../landscape/vr-projects-wave-60-code-first-overlay-scaffolds-projection-samples-and-window-to-texture-baselines.md`
- `../landscape/vr-projects-wave-72-openvr-overlay-access-layers-starter-variants-and-minimal-shell-experiments.md`
- `../landscape/project-families.md`

- `stevenjwheeler/OpenGL-VROverlay` - `Already studied`
- `ChristophHaag/OpenVRWindowOverlay` - `Already studied`
- `pfgithub/openvr-overlay-test` - `Already studied`
- `hiinaspace/openvr-overlay-bunny` - `Already studied`
- `ViveIsAwesome/OpenVROverlayTest` - `Already studied`
- `scudzey/UniversalVROverlay` - `Already studied`

## 40. Managed-language overlay starters, UIToolkit templates, and higher-level scaffolds

Primary docs:

- `../landscape/vr-projects-wave-61-managed-language-overlay-starters-uitoolkit-templates-and-higher-level-scaffolds.md`
- `../landscape/vr-projects-wave-72-openvr-overlay-access-layers-starter-variants-and-minimal-shell-experiments.md`
- `../landscape/project-families.md`

- `someka-vrc/uitoko-ovr` - `Already studied`
- `AanthonyRusso/BasicOverlay` - `Already studied`
- `Spacefish/OpenVR-Overlay` - `Already studied`
- `albrt-vr/OpenVR.ALBRT.overlay` - `Already studied`
- `Daniel-Webster/WT-OpenVR-Overlay` - `Deepened in Wave 208; see overlay media micro-surface section 179`
- `kurohuku7/zenn-overlay-tutorial` - `Already studied as tutorial-grade OpenVR overlay lifecycle reference`

## 41. Desktop-adjacent companion overlays, phone bridges, and media or text control surfaces

Primary docs:

- `../landscape/vr-projects-wave-62-desktop-adjacent-companion-overlays-phone-bridges-and-media-or-text-control-surfaces.md`
- `../landscape/project-families.md`

- `happysmash27/OVR_SLDO` - `Already studied`
- `Desuuuu/OVRPhoneBridge` - `Already studied`
- `adks3489/ViveOverlayPaster` - `Already studied`
- `Wulkop/VolumeVR` - `Deepened in Wave 208; see overlay media micro-surface section 179`

## 42. Specialized effect overlays, visibility shaping, and passthrough cutout surfaces

Primary docs:

- `../landscape/vr-projects-wave-63-specialized-effect-overlays-visibility-shaping-and-passthrough-cutout-surfaces.md`
- `../landscape/project-families.md`

- `Alex-J-Lopez/OpenMixerXR` - `Already studied`
- `joaoseabra/SteamVRBlackBarOverlay` - `Already studied`
- `tnsgud9/VR-Overlay-Half_Ring` - `Already studied`
- `RedHawk989/OpenVR-Windows-Activation` - `Already studied`
- `emymin/EmyOverlay` - `Already studied as C++ OpenGL/ImGui OpenVR overlay skeleton`

## 43. OpenXR sample apps, rendering baselines, and bring-up references

Primary docs:

- `../landscape/vr-projects-wave-64-openxr-sample-apps-rendering-baselines-and-bring-up-references.md`
- `../landscape/project-families.md`

- `maluoi/OpenXRSamples` - `Already studied`
- `janhsimon/openxr-vulkan-example` - `Already studied`
- `philpax/wgpu-openxr-example` - `Already studied`
- `terryky/android_openxr_gles` - `Already studied`
- `KHeresy/openxr-simple-example` - `Already studied`
- `jherico/OpenXR-Samples` - `Not studied deeply`

## 44. OpenXR language bindings, generator-backed wrappers, and SDK facades

Primary docs:

- `../landscape/vr-projects-wave-65-openxr-language-bindings-generator-backed-wrappers-and-sdk-facades.md`
- `../landscape/project-families.md`

- `Ralith/openxrs` - `Already studied`
- `cmbruns/pyopenxr` - `Already studied`
- `EvergineTeam/OpenXR.NET` - `Already studied`
- `s-ol/openxr-zig` - `Already studied`
- `drypy/openxr.py` - `Not studied deeply`
- `FireFlyForLife/rlOpenXR` - `Not studied deeply`

## 45. OpenVR language bindings, managed wrappers, and scripting access layers

Primary docs:

- `../landscape/vr-projects-wave-66-openvr-language-bindings-managed-wrappers-and-scripting-access-layers.md`
- `../landscape/vr-projects-wave-72-openvr-overlay-access-layers-starter-variants-and-minimal-shell-experiments.md`
- `../landscape/project-families.md`

- `rust-openvr/rust-openvr` - `Already studied`
- `cmbruns/pyopenvr` - `Already studied`
- `tbogdala/openvr-go` - `Already studied`
- `node-xr/node-openvr` - `Already studied`
- `Flutterish/OpenVR.NET` - `Already studied`
- `TheButlah/ovr_overlay` - `Already studied`
- `java-graphics/openvr` - `Not studied deeply`
- `matinas/openvrsimplexamples` - `Not studied deeply`

## 46. OpenVR tracking export, recording, and robotics bridge tooling

Primary docs:

- `../landscape/vr-projects-wave-67-openvr-tracking-export-recording-and-robotics-bridge-tooling.md`
- `../landscape/project-families.md`

- `Omnifinity/OpenVR-Tracking-Example` - `Already studied`
- `sharif1093/openvr_ros` - `Already studied`
- `personalrobotics/openvr_ros_bridge` - `Already studied`
- `qeftser/openvr_ros2_tracker` - `Already studied`
- `lebek/openvr-input-recorder` - `Already studied`
- `RViMLab/vrviz` - `Already studied`
- `zhouhs88/vrpn-openvr` - `Not studied deeply`

## 47. OpenXR capability-injection layers, input remappers, and peripheral extension bridges

Primary docs:

- `../landscape/vr-projects-wave-76-openxr-capability-injection-layers-input-remappers-and-peripheral-extension-bridges.md`
- `../landscape/project-families.md`

- `ultraleap/OpenXRHandTracking` - `Partially studied`
- `Sorenon/openxr_remapping_layer` - `Already studied`
- `verncat/OpenXR_ApiLayer_Patstrap` - `Already studied`

## 48. OpenXR helper stacks, layer toolchains, and runtime adaptation helpers

Primary docs:

- `../landscape/vr-projects-wave-77-openxr-helper-stacks-layer-toolchains-and-runtime-adaptation-helpers.md`
- `../landscape/project-families.md`

- `technobaboo/quark` - `Already studied`
- `doraibu/rayxr` - `Already studied`
- `fredemmott/openxr-layer-scripts` - `Already studied`
- `elliotttate/OpenXR-CAS` - `Already studied`

## 49. OpenXR passthrough samples and engine-side extension integration references

Primary docs:

- `../landscape/vr-projects-wave-78-openxr-passthrough-samples-and-engine-side-extension-integration-references.md`
- `../landscape/project-families.md`

- `AgileLens/ue-openxr-passthrough` - `Already studied`
- `BastiaanOlij/godot_test_passthrough` - `Already studied`
- `olir/mr-openxr-unity-meta-passthrough-sample` - `Partially studied`

## 50. Desktop-window overlay shells, Linux capture utilities, and launcher stubs

Primary docs:

- `../landscape/vr-projects-wave-79-desktop-window-overlay-shells-linux-capture-utilities-and-launcher-stubs.md`
- `../landscape/project-families.md`

- `ShiraoShotaro/DesktopOverlayer` - `Already studied`
- `nyxpirientity/ovr-penguin` - `Already studied`
- `gamenew09/RobloxVRLauncher` - `Not studied deeply`

## 51. Microphone control overlays, voice-input pipelines, and audio routing helpers

Primary docs:

- `../landscape/vr-projects-wave-80-microphone-control-voice-input-pipelines-and-audio-routing-helpers.md`
- `../landscape/project-families.md`

- `matzman666/OpenVR-MicrophoneControl` - `Already studied`
- `I5UCC/VRCTextboxSTT` - `Already studied`
- `Dragon092/OpenVR_Audio_Manager` - `Already studied`
- `VirtualDrivers/Virtual-Audio-Driver` - `Already studied`

## 52. Immersive music players, VR media playback surfaces, and browser video shells

Primary docs:

- `../landscape/vr-projects-wave-81-immersive-music-players-vr-media-playback-surfaces-and-browser-video-shells.md`
- `../landscape/project-families.md`

- `JustinLin905/around-sound` - `Already studied`
- `BIVROST/360PlayerWindows` - `Partially studied`
- `VR-cam/WebXR-video-player` - `Already studied`
- `videolan/vlc-unity` - `Partially studied`

## 53. Spatial audio SDKs, renderers, and object-optimization toolchains

Primary docs:

- `../landscape/vr-projects-wave-82-spatial-audio-sdks-renderers-and-object-optimization-toolchains.md`
- `../landscape/project-families.md`

- `microsoft/spatialaudio-unity` - `Already studied`
- `videolabs/libspatialaudio` - `Partially studied`
- `GoogleChrome/omnitone` - `Already studied`
- `VoidXH/Cavern` - `Partially studied`
- `carbonengine/spatial-audio-clustering` - `Already studied`

## 54. Creator-facing audio systems, synced player frameworks, and world-side voice management

Primary docs:

- `../landscape/vr-projects-wave-83-creator-facing-audio-systems-synced-player-frameworks-and-world-side-voice-management.md`
- `../landscape/project-families.md`

- `llealloo/audiolink` - `Partially studied`
- `MerlinVR/USharpVideo` - `Already studied`
- `sam-ln/USharpVideoQueue` - `Already studied`
- `JLChnToZ/VVMW` - `Partially studied`
- `SylanTroh/AudioManager` - `Already studied`

## 55. Browser panoramic video players, mobile wrappers, and projection-aware web playback

Primary docs:

- `../landscape/vr-projects-wave-84-browser-panoramic-video-players-mobile-wrappers-and-projection-aware-web-playback.md`
- `../landscape/project-families.md`

- `BIVROST/360WebPlayer` - `Already studied`
- `yanwsh/videojs-panorama` - `Already studied`
- `videojs/videojs-vr` - `Already studied`
- `flutterwtf/VR-Player` - `Already studied`

## 56. Engine-side stereo panoramic viewers, vendor player samples, and layout-specific video surfaces

Primary docs:

- `../landscape/vr-projects-wave-85-engine-side-stereo-panoramic-viewers-vendor-player-samples-and-layout-specific-video-surfaces.md`
- `../landscape/project-families.md`

- `ft-lab/Unity_Panorama180View` - `Already studied`
- `picoxr/VideoPlayer-UnityXR` - `Already studied`
- `UNAmedia/ue5-stereo-panoramic-player-demo` - `Partially studied`

## 57. VRChat synced video player frameworks, queue frontends, and event-optimized media shells

Primary docs:

- `../landscape/vr-projects-wave-86-vrchat-synced-video-player-frameworks-queue-frontends-and-event-optimized-media-shells.md`
- `../landscape/project-families.md`

- `vrctxl/VideoTXL` - `Already studied`
- `UdonVR/UdonVideoplayer` - `Already studied`
- `koorimizuw/YamaPlayer` - `Partially studied`

## 58. Transformed, volumetric, and nonstandard 3D video viewers

Primary docs:

- `../landscape/vr-projects-wave-87-transformed-volumetric-and-nonstandard-3d-video-viewers.md`
- `../landscape/project-families.md`

- `dfaker/VR-reversal` - `Already studied`
- `fbriggs/lifecast_public` - `Partially studied`
- `parkchamchi/DepthViewer` - `Partially studied`
- `prefrontalcortex/DomeTools` - `Partially studied`

## 59. VRChat world-authoring toolkits, optimization helpers, and prefab ecosystems

Primary docs:

- `../landscape/vr-projects-wave-88-vrchat-world-authoring-toolkits-optimization-helpers-and-prefab-ecosystems.md`
- `../landscape/project-families.md`

- `oneVR/VRWorldToolkit` - `Already studied`
- `BlueAmulet/UdonSharpOptimizer` - `Already studied`
- `Varneon/UdonEssentials` - `Partially studied`
- `Varneon/VUdon` - `Partially studied`

## 60. VRChat world runtime infrastructure, voice, networking, and player-state helpers

Primary docs:

- `../landscape/vr-projects-wave-89-vrchat-world-runtime-infrastructure-voice-networking-and-player-state-helpers.md`
- `../landscape/project-families.md`

- `Guribo/UdonVoiceUtils` - `Already studied`
- `Xytabich/UNet` - `Already studied`
- `Superbstingray/UdonPlayerPlatformHook` - `Already studied`
- `CyanLaser/CyanPlayerObjectPool` - `Already studied`

## 61. VRChat camera, staging, and admin-control systems for world events

Primary docs:

- `../landscape/vr-projects-wave-90-vrchat-camera-staging-and-admin-control-systems-for-world-events.md`
- `../landscape/project-families.md`

- `laserimouto/VRChatCameraWorks` - `Already studied`
- `rhaamo/CameraSystem` - `Already studied`
- `VRLabs/Camera-System` - `Partially studied; Wave 158 deepened avatar-authored OSC camera-path companion architecture`
- `SylanTroh/GMMenu` - `Partially studied`

## 62. VRChat interaction, utility UI, and information-surface prefabs

Primary docs:

- `../landscape/vr-projects-wave-91-vrchat-interaction-ui-and-information-surface-prefabs.md`
- `../landscape/project-families.md`

- `Reava/U-Key` - `Already studied`
- `z3y/VRCMarker` - `Already studied`
- `Miner28/AvatarImageReader` - `Partially studied`
- `Guribo/UdonRecyclingScrollRect` - `Already studied`
- `Guribo/UdonLeaderBoard` - `Not studied deeply`

## 63. VRChat world persistence, inventory, save-manager companions, and external-data bridges

Primary docs:

- `../landscape/vr-projects-wave-92-vrchat-world-persistence-inventory-save-manager-companions-and-external-data-bridges.md`
- `../landscape/project-families.md`

- `Nestorboy/NUSaveState` - `Already studied`
- `ChrisFeline/ToNSaveManager` - `Partially studied`
- `TealOrangeCat/InventorySystem` - `Already studied`
- `DarthShader/Udon-MIDI-Web-Helper` - `Partially studied`

## 64. VRChat creator diagnostics, editor inspection, profiling, and static-analysis helpers

Primary docs:

- `../landscape/vr-projects-wave-93-vrchat-creator-diagnostics-editor-inspection-profiling-and-static-analysis-helpers.md`
- `../landscape/project-families.md`

- `GotoFinal/GotoUdon` - `Partially studied`
- `Varneon/UdonExplorer` - `Already studied`
- `DeltaNeverUsed/UdonSharpProfiler` - `Already studied`
- `esnya/UdonRabbit.Analyzer` - `Already studied`

## 65. VRChat embodied interaction, custom movement, and physical world mechanics

Primary docs:

- `../landscape/vr-projects-wave-94-vrchat-embodied-interaction-custom-movement-and-physical-world-mechanics.md`
- `../landscape/project-families.md`

- `Janooba/immersive-interactions` - `Partially studied`
- `squiddingme/UdonTether` - `Already studied`
- `Nestorboy/NUMovement` - `Partially studied`
- `esnya/UdonDoor` - `Already studied`
- `kurotori4423/KurotoriUdonKart` - `Partially studied`

## 66. Udon data-structure libraries, serialization helpers, and creator utility foundations

Primary docs:

- `../landscape/vr-projects-wave-95-udon-data-structure-libraries-serialization-helpers-and-creator-utility-foundations.md`
- `../landscape/project-families.md`

- `Guribo/UdonUtils` - `Partially studied`
- `koyashiro/udon-list` - `Already studied`
- `koyashiro/udon-dictionary` - `Already studied`
- `koyashiro/udon-json` - `Already studied`
- `hoke946/UArrayCollections` - `Already studied`
- `Varneon/VUdon-ArrayExtensions` - `Already studied`

## 67. VRChat creator starter baselines, test harnesses, and language-boundary experiments

Primary docs:

- `../landscape/vr-projects-wave-96-vrchat-creator-starter-baselines-test-harnesses-and-language-boundary-experiments.md`
- `../landscape/project-families.md`

- `vrchat-community/template-world` - `Already studied`
- `vrchat-community/template-udonsharp` - `Fork / variant only`
- `koyashiro/udon-test` - `Already studied`
- `raii-x/wasm2usharp` - `Already studied`

## 68. Udon encoding, token, query, and structured-data micro-libraries

Primary docs:

- `../landscape/vr-projects-wave-97-udon-encoding-token-query-and-structured-data-micro-libraries.md`
- `../landscape/project-families.md`

- `koyashiro/udon-encoding` - `Already studied`
- `koyashiro/udon-jwt` - `Already studied`
- `aiczk/ULinq` - `Already studied`
- `m-hayabusa/UdonXMLParser` - `Already studied`

## 69. Udon sync, events, runtime logging, and shared helper micro-frameworks

Primary docs:

- `../landscape/vr-projects-wave-98-udon-sync-events-runtime-logging-and-shared-helper-micro-frameworks.md`
- `../landscape/project-families.md`

- `Varneon/VUdon-Events` - `Already studied`
- `DeltaNeverUsed/UdonSharpNetworkingLib` - `Already studied`
- `MMMaellon/LightSync` - `Partially studied`
- `Varneon/VUdon-Logger` - `Already studied`

## 70. VRChat world control gadgets, environmental systems, and specialized operator surfaces

Primary docs:

- `../landscape/vr-projects-wave-99-vrchat-world-control-gadgets-environmental-systems-and-specialized-operator-surfaces.md`
- `../landscape/project-families.md`

- `Varneon/VUdon-DepthBufferToolkit` - `Already studied`
- `AcChosen/VR-Stage-Lighting` - `Partially studied`
- `tommaier123/UdonSharpDayNightController` - `Already studied`
- `MolotovCherry/VRChat_Keypad` - `Already studied`
- `KitKat4191/UdonKeypad` - `Already studied`

## 71. VRChat avatar setup, optimization, and Quest portability

Primary docs:

- `../landscape/vr-projects-wave-100-vrchat-avatar-setup-optimization-and-quest-portability.md`
- `../landscape/project-families.md`

- `rurre/PumkinsAvatarTools` - `Already studied`
- `kurotu/VRCQuestTools` - `Already studied`
- `d4rkc0d3r/d4rkAvatarOptimizer` - `Already studied`
- `triazo/immersive_scaler` - `Already studied`

## 72. VRChat avatar composition, packaging, and install automation

Primary docs:

- `../landscape/vr-projects-wave-101-vrchat-avatar-composition-packaging-and-install-automation.md`
- `../landscape/project-families.md`

- `bdunderscore/modular-avatar` - `Already studied`
- `hai-vr/modular-avatar-as-code` - `Already studied`
- `vrc-get/vrc-get` - `Already studied`
- `VRLabs/Avatars-3.0-Manager` - `Already studied`

## 73. VRChat avatar emulation, gesture preview, repair, and OSC-assisted posing

Primary docs:

- `../landscape/vr-projects-wave-102-vrchat-avatar-emulation-gesture-preview-repair-and-osc-assisted-posing.md`
- `../landscape/project-families.md`

- `lyuma/Av3Emulator` - `Already studied`
- `BlackStartx/VRC-Gesture-Manager` - `Already studied`
- `JLChnToZ/avautils` - `Already studied`
- `IlexisTheMadcat/LexisPosingSystem` - `Partially studied`

## 74. VRChat avatar text, speech, translation, and viseme sidecars

Primary docs:

- `../landscape/vr-projects-wave-103-vrchat-avatar-text-speech-translation-and-viseme-sidecars.md`
- `../landscape/project-families.md`

- `VRCWizard/TTS-Voice-Wizard` - `Already studied`
- `YusufOzmen01/kikitan-translator` - `Already studied`
- `met4citizen/HeadTTS` - `Already studied`
- `Frosty704/Billboard` - `Partially studied`

## 75. VRChat shader ecosystems, material translators, and visual-safety shaders

Primary docs:

- `../landscape/vr-projects-wave-104-vrchat-shader-ecosystems-material-translators-and-visual-safety-shaders.md`
- `../landscape/project-families.md`

- `poiyomi/PoiyomiToonShader` - `Partially studied`
- `lilxyzw/lilToon` - `Partially studied`
- `MochiesCode/Mochies-Unity-Shaders` - `Already studied`
- `LinesGuy/lilToonToPoiyomiToon` - `Already studied`
- `LesseVR/EpilepsyProtection` - `Already studied`

## 76. VRCFury toggle automation, avatar animator DSLs, and editor QoL overlays

Primary docs:

- `../landscape/vr-projects-wave-105-vrcfury-toggle-automation-avatar-animator-dsls-and-editor-qol-overlays.md`
- `../landscape/project-families.md`

- `VRCFury/VRCFury` - `Partially studied`
- `RealWhyKnot/wk-vrcfury-qol` - `Already studied`
- `SuperFlue/VRCToggleToolkit` - `Already studied`
- `hai-vr/animator-as-code-vrchat` - `Already studied`
- `vr-voyage/vrchat-quick-toggle-vrcfury` - `Already studied`

## 77. VRCFaceTracking core, modules, templates, and blendshape preparation

Primary docs:

- `../landscape/vr-projects-wave-106-vrcfacetracking-core-modules-templates-and-blendshape-preparation.md`
- `../landscape/project-families.md`

- `benaclejames/VRCFaceTracking` - `Partially studied`
- `dfgHiatus/VRCFaceTracking.Avalonia` - `Partially studied`
- `dfgHiatus/VRCFT-Babble` - `Already studied`
- `regzo2/VRCFaceTracking-MeowFace` - `Already studied`
- `Adjerry91/VRCFaceTracking-blender-plugin` - `Already studied`

## 78. VRChat avatar dynamics, PhysBone migration, contact prefabs, and in-game tuning

Primary docs:

- `../landscape/vr-projects-wave-107-vrchat-avatar-dynamics-physbone-migration-contact-prefabs-and-in-game-tuning.md`
- `../landscape/project-families.md`

- `FACS01-01/PhysBone-to-DynamicBone` - `Already studied`
- `naqtn/PhysBonesTK` - `Already studied`
- `TizzureOne/VRChat_PhysboneDetach` - `Already studied`
- `ThatFatKidsMom/Avatar-Prop` - `Partially studied`
- `VRLabs/Collision-Detection` - `Already studied`

## 79. VRChat companion apps, OSC routers, plugin senders, data hubs, and web debug surfaces

Primary docs:

- `../landscape/vr-projects-wave-108-vrchat-companion-apps-osc-routers-plugin-senders-data-hubs-and-web-debug-surfaces.md`
- `../landscape/project-families.md`

- `vrcx-team/VRCX` - `Partially studied`
- `SutekhVRC/VOR` - `Already studied`
- `YABam/VRCOSCGUI` - `Partially studied`
- `PlagueVRC/VRCOSCDataHub` - `Already studied`
- `EveryDayCompute/VRCOSCWeb` - `Already studied`

## 80. SlimeVR server, tracker firmware, adapters, and calibration ecosystem

Primary docs:

- `../landscape/vr-projects-wave-109-slimevr-server-tracker-firmware-adapters-and-calibration-ecosystem.md`
- `../landscape/project-families.md`

- `SlimeVR/SlimeVR-Server` - `Partially studied`
- `SlimeVR/SlimeVR-Tracker-ESP` - `Partially studied`
- `carl-anders/slimevr-wrangler` - `Already studied`
- `moslime/moslime` - `Already studied`
- `OCSYT/SlimeTora` - `Partially studied`

## 81. bHaptics SDKs, OSC bridges, relays, and telemetry-to-haptic adapters

Primary docs:

- `../landscape/vr-projects-wave-110-bhaptics-sdks-osc-bridges-relays-and-telemetry-to-haptic-adapters.md`
- `../landscape/project-families.md`

- `bhaptics/haptic-library` - `Partially studied`
- `bhaptics/tact-js` - `Already studied`
- `bhaptics/tact-python` - `Partially studied`
- `HerpDerpinstine/bHapticsOSC` - `Already studied`
- `Dteyn/bHapticsRelay` - `Already studied`

## 82. No-HMD and virtual-HMD OpenVR helpers, phone bridges, and controllable driver stubs

Primary docs:

- `../landscape/vr-projects-wave-111-no-hmd-and-virtual-hmd-openvr-helpers-phone-bridges-and-controllable-driver-stubs.md`
- `../landscape/project-families.md`

- `PhoneVR-Developers/PhoneVR` - `Partially studied`
- `SDraw/driver_hmd` - `Already studied`
- `pema99/faceless` - `Already studied`
- `kajsaantonigelstrom/OpenVRsim` - `Already studied`
- `blakebeckcoding/Pepper` - `Partially studied`

## 83. WebXR browser API samples, input profiles, emulators, polyfills, and React/Three XR wrappers

Primary docs:

- `../landscape/vr-projects-wave-112-webxr-browser-api-samples-input-profiles-emulators-polyfills-and-react-three-xr-wrappers.md`
- `../landscape/project-families.md`

- `immersive-web/webxr-samples` - `Already studied`
- `immersive-web/webxr-input-profiles` - `Already studied`
- `meta-quest/immersive-web-emulator` - `Already studied`
- `mozilla/webxr-polyfill` - `Partially studied`
- `pmndrs/xr` - `Partially studied`

## 84. Unity XR interaction/workflow toolkits, scientific rigs, training graphs, and Tilia composition

Primary docs:

- `../landscape/vr-projects-wave-113-unity-xr-interaction-workflow-toolkits-scientific-rigs-training-graphs-and-tilia-composition.md`
- `../landscape/project-families.md`

- `MixedRealityToolkit/MixedRealityToolkit-Unity` - `Partially studied`
- `eisclimber/ExPresS-XR` - `Partially studied; Wave 155 deepened data-gathering, value-range, socket, menu, and toolkit primitives`
- `MindPort-GmbH/VR-Builder` - `Partially studied`
- `ExtendRealityLtd/VRTK` - `Partially studied`

## 85. Meta Quest MR camera, depth, spatial-anchor, presence, and motif samples

Primary docs:

- `../landscape/vr-projects-wave-114-meta-quest-mr-camera-depth-spatial-anchor-presence-and-motifs-samples.md`
- `../landscape/project-families.md`

- `oculus-samples/Unity-PassthroughCameraApiSamples` - `Already studied`
- `oculus-samples/Unity-DepthAPI` - `Already studied`
- `oculus-samples/Unity-SharedSpatialAnchors` - `Partially studied`
- `oculus-samples/Unity-Discover` - `Partially studied`
- `oculus-samples/Unity-MRMotifs` - `Partially studied`

## 86. Linux spatial desktop, Stardust workspace clients, and desktop-to-XR helpers

Primary docs:

- `../landscape/vr-projects-wave-115-linux-spatial-desktop-stardust-workspace-clients-and-desktop-to-xr-helpers.md`
- `../landscape/project-families.md`

- `SimulaVR/Simula` - `Partially studied`
- `StardustXR/flatland` - `Partially studied`
- `StardustXR/kiara` - `Already studied`
- `StardustXR/protostar` - `Already studied`
- `StardustXR/magnetar` - `Already studied`
- `yshui/picom-xrdesktop-companion` - `Partially studied`

## 87. Godot XR engine toolkits, templates, backends, and vendor extension stacks

Primary docs:

- `../landscape/vr-projects-wave-116-godot-xr-engine-toolkits-templates-backends-and-vendor-extension-stacks.md`
- `../landscape/project-families.md`

- `GodotVR/godot-xr-tools` - `Already studied as Godot XR function-node toolkit for pointer, pickup, teleport, movement, hands, settings, and scene composition`
- `GodotVR/godot-xr-template` - `Already studied`
- `GodotVR/godot_openxr_for_godot_3.x` - `Partially studied`
- `GodotVR/godot_openxr_vendors` - `Already studied as Godot OpenXR vendor extension stack with export feature gates and runtime capability surfaces`
- `GodotVR/godot_openvr` - `Partially studied`
- `GodotVR/godot_oculus_mobile` - `Already studied as deprecated reference`

## 88. A-Frame WebXR components, inspectors, networked scenes, and hand UI

Primary docs:

- `../landscape/vr-projects-wave-117-aframe-webxr-components-inspectors-networked-scenes-and-hand-ui.md`
- `../landscape/project-families.md`

- `aframevr/aframe` - `Partially studied`
- `aframevr/aframe-inspector` - `Already studied`
- `c-frame/aframe-extras` - `Already studied`
- `networked-aframe/networked-aframe` - `Partially studied`
- `supermedium/superframe` - `Partially studied`
- `gftruj/aframe-hand-tracking-controls-extras` - `Already studied`

## 89. Unreal VR interaction toolkits, hand tracking, comfort, and tracker plugins

Primary docs:

- `../landscape/vr-projects-wave-118-unreal-vr-interaction-toolkits-hand-tracking-comfort-and-tracker-plugins.md`
- `../landscape/project-families.md`

- `mordentral/VRExpansionPlugin` - `Partially studied`
- `1runeberg/RunebergVRPlugin` - `Already studied`
- `microsoft/MixedReality-UXTools-Unreal` - `Partially studied as archived reference`
- `sigtrapgames/VrTunnellingPro-UE4` - `Already studied`
- `demonixis/FSOpenXRHandTracking` - `Already studied`
- `Rectus/UE4OpenXRViveTrackerPlugin` - `Already studied`
- `V4C38/ue5-xrcore` - `Partially studied`

## 90. VR teleoperation headset frontends, robot bridges, and data capture

Primary docs:

- `../landscape/vr-projects-wave-119-vr-teleoperation-headset-frontends-robot-bridges-and-data-capture.md`
- `../landscape/project-families.md`

- `kscalelabs/kbot_vr_teleop` - `Deepened in Wave 211; see VR teleoperation control section 182`
- `dwaitbhatt/xarm_vr_teleop` - `Already studied`
- `NVlabs/collab-sim` - `Partially studied`
- `wengmister/franka-vr-teleop` - `Partially studied`
- `nakama-lab/VR_Teleop_Interface` - `Deepened in Wave 211 as architecture documentation and command/status/error flow donor`
- `open-thought/cambot` - `Deepened in Wave 211; see VR teleoperation control section 182`
- `plund-dtu/UR_VR_Teleop` - `Partially studied`

## 91. ALVR/WiVRn ecosystem sidecars, platform clients, and streaming helpers

Primary docs:

- `../landscape/vr-projects-wave-120-alvr-wivrn-ecosystem-sidecars-platform-clients-and-streaming-helpers.md`
- `../landscape/project-families.md`

- `alvr-org/alvr-visionos` - `Partially studied`
- `alvr-org/Monado-ALVR` - `Partially studied as runtime-fork reference`
- `alvr-org/VRCFT-ALVR` - `Already studied`
- `AtlasTheProto/ADBForwarder` - `Already studied`
- `Kierek/WiVRnTimings` - `Already studied as micro-utility`

## 92. XR glasses WebHID, virtual displays, and head-tracked desktop helpers

Primary docs:

- `../landscape/vr-projects-wave-121-xr-glasses-webhid-virtual-displays-and-head-tracked-desktop-helpers.md`
- `../landscape/project-families.md`

- `jakedowns/xreal-webxr` - `Deepened in Wave 209; see XR glasses protocol section 180`
- `alexwilson1/nreal_linux_test` - `Deepened in Wave 209 as Linux/X11 head-tracked desktop POC`
- `Mailbot/Nreal_Air_Desktop_tool` - `Deepened in Wave 209 as product reference only`
- `edwatt/real_utilities` - `Deepened in Wave 209; see XR glasses protocol section 180`
- `DannyDesert/XReal-Ultrawide` - `Already studied`

## 93. MediaPipe camera tracking bridges for SlimeVR, VRChat, VRM, and virtual controllers

Primary docs:

- `../landscape/vr-projects-wave-122-mediapipe-camera-tracking-bridges-for-slimevr-vrchat-vrm-and-virtual-controllers.md`
- `../landscape/project-families.md`

- `TkskKurumi/SlimeVR-Tracker-Mediapipe` - `Already studied`
- `hotaru86/MediapipeFaceTracking_VRC` - `Deepened in Wave 210; see MediaPipe/avatar tracking sidecar section 181`
- `how-people-lived/mediapipe-vrm-tracking` - `Deepened in Wave 210; see MediaPipe/avatar tracking sidecar section 181`
- `Metastazius/VRBodyTrack` - `Deepened in Wave 210; see MediaPipe/avatar tracking sidecar section 181`
- `vwitted/mediapipe_VR_controller` - `Already studied as micro-utility`

## 94. Mixed reality capture, calibration, and presenter compositing helpers

Primary docs:

- `../landscape/vr-projects-wave-123-mixed-reality-capture-calibration-and-presenter-compositing-helpers.md`
- `../landscape/project-families.md`

- `fabio914/reality-mixer-js` - `Already studied`
- `fabio914/RealityMixerVisionPro` - `Partially studied`
- `jonathanperret/mrc-client` - `Already studied`
- `zengmmm00/MixedRealityCapture` - `Not studied deeply; source not released yet`
- `TonyViT/MrcXrtHelpers` - `Already studied`
- `smaerdlatigid/ArtificialGreenScreen` - `Already studied as capture helper`
- `LIV/CalibrationForQuest` - `Rejected; empty repository in current clone`

## 95. VR treadmill locomotion hardware, input adapters, and virtual controller bridges

Primary docs:

- `../landscape/vr-projects-wave-124-vr-treadmill-locomotion-hardware-input-adapters-and-virtual-controller-bridges.md`
- `../landscape/project-families.md`

- `fer-sler/VR-Treadmill` - `Already studied as minimal bridge`
- `TimStewartJ/vr-treadmill` - `Already studied`
- `Cycrus/slimstep_vr` - `Already studied`
- `jurassicjordan/GoobleBoxVR` - `Already studied`
- `srepmub/tacovr` - `Already studied as hardware firmware/control reference`
- `ssohbn/kittywalk-server` - `Already studied as micro-utility`
- `cybernetic-research/VR-treadmill-client-app` - `Already studied`
- `cybernetic-research/VR-treadmill-server-app` - `Already studied`

## 96. Unity VR experiment frameworks, data capture, and study orchestration helpers

Primary docs:

- `../landscape/vr-projects-wave-125-unity-vr-experiment-frameworks-data-capture-and-study-orchestration-helpers.md`
- `../landscape/project-families.md`

- `immersivecognition/unity-experiment-framework` - `Already studied`
- `BioMotionLab/TUX` - `Already studied`
- `jinwook31/Unity-Experiment-Trial-Manager` - `Already studied as minimal baseline`
- `Nesbi/PsyWueVR` - `Already studied`
- `social-spatial-interaction-lab/VR_Motion_Tracker` - `Already studied as composition reference`
- `SensoriMotorControlLab/vr_experiment_framework_v3` - `Already studied`
- `jackbrookes/uxf-s3-uploader` - `Already studied`
- `jackbrookes/uxf-web-settings` - `Already studied`

## 97. Immersive browser shells, WebXR runtimes, home spaces, and spatial web frontends

Primary docs:

- `../landscape/vr-projects-wave-126-immersive-browser-shells-webxr-runtimes-home-spaces-and-spatial-web-frontends.md`
- `../landscape/project-families.md`

- `Igalia/wolvic` - `Partially studied as large architecture reference`
- `MozillaReality/FirefoxReality` - `Partially studied as archived lineage reference`
- `MozillaReality/FirefoxRealityPC` - `Partially studied as PC shell reference`
- `exokitxr/exokit` - `Partially studied`
- `exokitxr/exokit-browser` - `Already studied as thin shell reference`
- `exokitxr/exokit-frontend` - `Already studied as frontend/menu reference`
- `madjin/home-space` - `Already studied as product/UX reference`

## 98. Browser-native WebXR utility surfaces, creative tools, diagnostics, and data visualization

Primary docs:

- `../landscape/vr-projects-wave-127-browser-native-webxr-utility-surfaces-creative-tools-diagnostics-and-data-visualization.md`
- `../landscape/project-families.md`

- `aframevr/a-painter` - `Already studied`
- `leapmotion/LeapShape` - `Already studied`
- `zfox23/spatial-photo-webxr-viewer` - `Already studied`
- `ivanik7/vr-screen-tester` - `Already studied as micro-utility`
- `kquizz/vr-visualizer-web` - `Already studied`
- `Kineviz/OpenBCI-WebXR-EEG` - `Already studied`
- `msitarzewski/prediction-space` - `Already studied`
- `taplivenetwork/taplive-webxr` - `Not studied deeply; source not present in current clone`

## 99. Quest app sideloading, modding, version management, and store metadata tooling

Primary docs:

- `../landscape/vr-projects-wave-128-quest-app-sideloading-modding-version-management-and-store-metadata-tooling.md`
- `../landscape/project-families.md`

- `SideQuestVR/SideQuest` - `Already studied`
- `SideQuestVR/SideQuestAppLauncher` - `Already studied`
- `Lauriethefish/QuestPatcher` - `Already studied`
- `Lauriethefish/QuestPatcher.QMod` - `Already studied`
- `ComputerElite/QuestAppVersionSwitcher` - `Already studied`
- `ComputerElite/OculusDB` - `Already studied`

## 100. VMC/VRM motion-capture protocol, OSC transform receivers, and recording/export tools

Primary docs:

- `../landscape/vr-projects-wave-129-vmc-vrm-motion-capture-protocol-osc-transform-receivers-and-recording-export-tools.md`
- `../landscape/project-families.md`

- `sh-akira/VirtualMotionCapture` - `Already studied`
- `sh-akira/VirtualMotionCaptureProtocol` - `Already studied`
- `gpsnmeajp/EasyVirtualMotionCaptureForUnity` - `Already studied`
- `sh-akira/QuestOSCTransformSender` - `Already studied`
- `infosia/vmc2bvh` - `Already studied`
- `infosia/vmcrec` - `Already studied`

## 101. Resonite/Neos modding, headless, external SDK, and social utility tooling

Primary docs:

- `../landscape/vr-projects-wave-130-resonite-neos-modding-headless-external-sdk-and-social-utility-tooling.md`
- `../landscape/project-families.md`

- `resonite-modding-group/ResoniteModLoader` - `Already studied`
- `Gawdl3y/Resolute` - `Already studied`
- `resonite-modding-group/resonite-mod-manifest` - `Already studied`
- `Yellow-Dog-Man/ResoniteLink` - `Already studied`
- `shadowpanther/resonite-headless` - `Already studied`
- `Nutcake/ReCon` - `Already studied`
- `esnya/ResoniteMetricsCounter` - `Already studied`

## 102. DIY open-source headset hardware bring-up, drivers, PCBs, and controller firmware

Primary docs:

- `../landscape/vr-projects-wave-131-diy-open-source-headset-hardware-bring-up-drivers-pcbs-and-controller-firmware.md`
- `../landscape/project-families.md`

- `relativty/Relativty` - `Already studied`
- `HadesVR/HadesVR` - `Already studied`
- `HadesVR/Wand-Controller` - `Already studied`
- `HadesVR/Basic-HMD-PCB` - `Already studied`
- `JX5S/HadesVR_GUI_Tool` - `Already studied`
- `dmcke5/DIY_VR_Controllers` - `Already studied`
- `dietzus/DietzVR` - `Rejected; current clone contains no reusable source beyond license metadata`

## 103. VR keyboard, text-entry, avatar keyboard, and OSC input surfaces

Primary docs:

- `../landscape/vr-projects-wave-132-vr-keyboard-text-entry-and-osc-input-surfaces.md`
- `../landscape/project-families.md`

- `danielbuechele/react-360-keyboard` - `Already studied`
- `erosmarcon/vr-keyboard` - `Already studied`
- `jcorvinus/VRKeyboard` - `Already studied`
- `mrowrpurr/VR_Keyboard` - `Already studied`
- `anosatsuk124/VRC-KeyboardController-in-VR_OSC` - `Already studied`
- `killfrenzy96/KillFrenzyVRCAvatarKeyboard` - `Already studied as deprecated historical reference`

## 104. VR subtitles, captions, STT/OCR accessibility, and projection-aware subtitle tooling

Primary docs:

- `../landscape/vr-projects-wave-133-vr-subtitles-captions-stt-and-ocr-accessibility-surfaces.md`
- `../landscape/project-families.md`

- `bjennings76/vr-subtitles` - `Already studied`
- `AhhhhHeyyy/VR-Subtitles-WIP` - `Already studied as WIP prototype`
- `CarlUpright/VR_SUBTITLES_BURNERRR` - `Already studied as projection-aware micro-utility`
- `zacharykeeler/VR-Subtitles-in-Unreal-5` - `Partially studied as report-only UX reference`
- `akbartus/WebVR-Captioning` - `Already studied`
- `DanielCirry/STTS` - `Partially studied as large STT/translation/OCR overlay stack`

## 105. SteamVR operational support, startup automation, dynamic performance, Linux permissions, and driver helpers

Primary docs:

- `../landscape/vr-projects-wave-134-steamvr-operational-support-startup-automation-dynamic-performance-and-linux-driver-helpers.md`
- `../landscape/project-families.md`

- `BOLL7708/OpenVRStartup` - `Already studied as archived lifecycle micro-utility`
- `Erimelowo/OpenVR-Dynamic-Resolution` - `Already studied`
- `ValveSoftware/steam-devices` - `Already studied as Linux device-permission reference`
- `CertainLach/VivePro2-Linux-Driver` - `Partially studied as vendor driver proxy/reference`

## 106. Focused overlay micro-surfaces, situational HUDs, QR/media helpers, and OCR-assisted workflow panels

Primary docs:

- `../landscape/vr-projects-wave-135-focused-overlay-micro-surfaces-qr-media-game-huds-and-ocr-assisted-workflow-panels.md`
- `../landscape/project-families.md`

- `MetroTS/AdressableOverlaySteamVR` - `Partially studied as early/incomplete status-dashboard sketch`
- `haolink/VRCOSCAvatarScaleOverlay` - `Already studied`
- `Psychpsyo/VR-QR-Overlay` - `Already studied`
- `Rycia/OVR-Deck` - `Rejected; current clone contains no reusable source beyond README/license metadata`
- `ToxicOrca/VR-Music-Remote` - `Already studied as window-captured micro-utility`
- `DavidDriessen/EchoVR-Overlay` - `Already studied as browser/OBS telemetry HUD reference`
- `etiennechabert/ez-wishlist-overlay` - `Partially studied as strong overlay/OCR/workflow donor`

## 107. Audience chat overlays, stream-facing browser surfaces, and captured-window HUD patterns

Primary docs:

- `../landscape/vr-projects-wave-136-audience-chat-overlays-stream-facing-browser-surfaces-and-captured-window-hud-patterns.md`
- `../landscape/project-families.md`

- `baffler/Transparent-Twitch-Chat-Overlay` - `Already studied as transparent desktop chat overlay donor`
- `Enubia/ghost-chat` - `Already studied as multi-provider transparent chat sidecar`
- `giambaJ/jChat` - `Already studied as static browser-source chat renderer`
- `BenDMyers/showmy.chat` - `Already studied as overlay URL builder and preview reference`
- `teklynk/twitch_chat_emotes` - `Already studied as animated emote/event overlay`

## 108. VR creative authoring, drawing/modeling tools, and in-headset tool/menu systems

Primary docs:

- `../landscape/vr-projects-wave-137-vr-creative-authoring-drawing-modeling-tools-and-in-headset-tool-menu-systems.md`
- `../landscape/project-families.md`

- `googlevr/tilt-brush` - `Partially studied as large archived Unity creative-tool architecture reference`
- `icosa-foundation/open-brush` - `Already studied as Open Brush creative app/API/sketch-load/export and brush/toolchain donor`
- `googlevr/blocks` - `Partially studied as archived VR modeling command/export reference`
- `SideQuestVR/SideSketch` - `Fork / variant only; useful for rebrand and distribution lessons`
- `zach-capalbo/vartiste` - `Partially studied as browser-native WebXR authoring and shelf/tool reference`

## 109. Networked/social XR frameworks, room clients, and multi-user state substrates

Primary docs:

- `../landscape/vr-projects-wave-138-networked-social-xr-frameworks-room-clients-and-multi-user-state-substrates.md`
- `../landscape/project-families.md`

- `UCL-VR/ubiq` - `Already studied as research-friendly network scene and room substrate`
- `mozilla/hubs` - `Partially studied as large WebXR social room client reference`
- `janusvr/janusweb` - `Already studied as historical spatial-web room/client reference`
- `vrsys/vrsys-core` - `Partially studied as Unity Netcode/XRI/Meta Avatar composition reference`

## 110. OpenGloves sidecars, protocols, named-pipe input, OSC ingress, and force-feedback adapters

Primary docs:

- `../landscape/vr-projects-wave-139-opengloves-sidecars-protocols-named-pipe-input-osc-ingress-and-force-feedback-adapters.md`
- `../landscape/project-families.md`

- `LucidVR/opengloves-ui` - `Already studied as Tauri/Svelte calibration and control sidecar`
- `LucidVR/opengloves-protocol` - `Already studied as protobuf communication contract reference`
- `PerlinWarp/pygloves` - `Already studied as Python named-pipe tester and hand visualization harness`
- `senseshift/opengloves-lib` - `Already studied as C++ data model and alpha serial encoding helper`
- `Rin-Wilson/CS-OpenGloves-Named-Pipe-Input-Library` - `Already studied as C# named-pipe input helper`
- `Python1320/opengloves-osc` - `Already studied as OSC-to-named-pipe ingress micro-bridge`
- `LucidVR/opengloves-force-feedback-unity-demo` - `Already studied as Unity/SteamVR force-feedback adapter demo`
- `LucidVR/opengloves-hl-alyx-integration` - `Already studied as game-log/file-watcher force-feedback sidecar`

## 111. WebXR engine export bridges, device-display adapters, layers, and test/showcase scaffolds

Primary docs:

- `../landscape/vr-projects-wave-140-webxr-engine-export-bridges-device-display-adapters-layers-and-test-showcase-scaffolds.md`
- `../landscape/project-families.md`

- `De-Panther/unity-webxr-export` - `Already studied as Unity WebXR loader/settings/export bridge`
- `Rufus31415/Simple-WebXR-Unity` - `Already studied as minimal Unity WebXR bridge and editor simulator`
- `Looking-Glass/looking-glass-webxr` - `Already studied as non-HMD WebXR display adapter`
- `immersive-web/webxr-layers-polyfill` - `Already studied as composition-layer polyfill and renderer reference`
- `immersive-web/webxr-test-api` - `Already studied as deterministic WebXR fake-device test API reference`
- `meta-quest/webxr-showcases` - `Already studied as feature-gated Quest/WebXR showcase reference`

## 112. Browser-based XR editors, live-coding sandboxes, visual workspaces, and scene tooling

Primary docs:

- `../landscape/vr-projects-wave-141-browser-based-xr-editors-live-coding-sandboxes-visual-workspaces-and-scene-tooling.md`
- `../landscape/project-families.md`

- `playcanvas/editor` - `Already studied as browser editor architecture and realtime asset/document reference`
- `tentone/nunuStudio` - `Already studied as self-contained scene editor and VR-toggle studio`
- `pmndrs/triplex` - `Already studied as source-code-driven React Three Fiber visual workspace`
- `brianpeiris/RiftSketch` - `Already studied as in-VR live-coding sandbox`
- `teliportme/remixvr` - `Already studied as template-based VR creation and classroom publishing reference`
- `protectwise/troika` - `Already studied as Three.js facade/UI/text infrastructure donor`

## 113. VRM/avatar web stacks, model specs, runtime loaders, and browser avatar/mocap surfaces

Primary docs:

- `../landscape/vr-projects-wave-142-vrm-avatar-web-stacks-model-specs-runtime-loaders-and-browser-avatar-mocap-surfaces.md`
- `../landscape/project-families.md`

- `vrm-c/UniVRM` - `Already studied as Unity VRM runtime/editor/import/export stack`
- `pixiv/three-vrm` - `Already studied as modular Three.js VRM loader/runtime`
- `binzume/aframe-vrm` - `Already studied as A-Frame VRM component layer`
- `ButzYung/SystemAnimatorOnline` - `Already studied as browser avatar/mocap and XR Animator lineage reference`
- `vrm-c/vrm-specification` - `Already studied as canonical VRM spec/schema contract source`

## 114. WebAR marker/image tracking, model-viewer AR surfaces, and lightweight scene-understanding utilities

Primary docs:

- `../landscape/vr-projects-wave-143-webar-marker-image-tracking-model-viewer-ar-surfaces-and-lightweight-scene-understanding-utilities.md`
- `../landscape/project-families.md`

- `hiukim/mind-ar-js` - `Already studied as image/face tracking, compiler, and A-Frame integration reference`
- `AR-js-org/AR.js` - `Already studied as marker, NFT, and location-based WebAR stack`
- `akbartus/Simple-AR` - `Already studied as minimal WebAR starter and cross-framework reference`
- `chenzlabs/aframe-ar` - `Already studied as A-Frame WebXR AR helper component layer`
- `google/model-viewer` - `Already studied as production AR model-viewer component and fallback UX reference`
- `tentone/enva-xr` - `Already studied as environment-aware WebXR AR renderer`

## 115. WebXR hand tracking, hand input surfaces, and hand-data bridges

Primary docs:

- `../landscape/vr-projects-wave-144-webxr-hand-tracking-hand-input-surfaces-and-hand-data-bridges.md`
- `../landscape/project-families.md`

- `marlon360/webxr-handtracking` - `Already studied as WebXR hand joint, pinch gesture, fingertip ray, and A-Frame component donor`
- `TakashiYoshinaga/webxr-hand-tracking-sample` - `Already studied as minimal pinch drawing and hand-role split sample`
- `rick98033/webxr-hand-tracking-websocket` - `Already studied as Babylon WebXR hand-pose WebSocket bridge`
- `danielklinkhammer/webxr-quest2` - `Already studied as Quest/A-Frame passthrough hand-grab micro-demo`

## 116. Immersive 360 video players, stereo projection, and local media surfaces

Primary docs:

- `../landscape/vr-projects-wave-145-immersive-360-video-players-stereo-projection-and-local-media-surfaces.md`
- `../landscape/project-families.md`

- `greggman/webxr-video` - `Already studied as modular WebXR video viewer with renderer/UI split`
- `brandynbuchanan/VR180-video-player` - `Already studied as minimal A-Frame VR180 stereoscopic player`
- `ProGamerGov/html-360-viewer` - `Already studied as one-file 360 image/video viewer and stereo-toggle utility`
- `thehancode/360-video-player` - `Already studied as Tauri/Svelte local 360 video player shell`
- `acuteimmersive/openimmersive` - `Already studied as Vision Pro projection/frame-packing immersive video player`

## 117. Audio-reactive WebXR surfaces, spatial sound visualizers, and shader pipelines

Primary docs:

- `../landscape/vr-projects-wave-146-audio-reactive-webxr-surfaces-spatial-sound-visualizers-and-shader-pipelines.md`
- `../landscape/project-families.md`

- `shift/webxr-audio-visualizer` - `Already studied as stereo microphone and directional AR waveform visualizer`
- `Alex-DG/vite-three-webxr-audio-visualizer` - `Already studied as Three/WebXR audio-feature-to-shader-uniform visualizer`
- `ConorStokes/boondoggle` - `Already studied as native Oculus/D3D audio texture and shader package visualizer`
- `DranoelMit/seeSound` - `Already studied as A-Frame WebAudio frequency-bin geometry visualizer`

## 118. WebXR runtime frameworks, session/input feature managers, and testable spatial UI substrates

Primary docs:

- `../landscape/vr-projects-wave-147-webxr-runtime-frameworks-session-input-feature-managers-and-testable-spatial-ui-substrates.md`
- `../landscape/project-families.md`

- `mrdoob/three.js` - `Already studied as minimal renderer-level WebXR manager and controller/hand space reference`
- `BabylonJS/Babylon.js` - `Already studied as WebXR session manager, experience helper, and feature manager stack`
- `playcanvas/engine` - `Already studied as evented XR service taxonomy and hand/input subsystem model`
- `facebook/immersive-web-sdk` - `Already studied as ECS/action/spatial-UI framework with runtime-first dev tooling`

## 119. A-Frame GUI, locomotion, and reusable interaction component primitives

Primary docs:

- `../landscape/vr-projects-wave-148-aframe-gui-locomotion-and-reusable-interaction-component-primitives.md`
- `../landscape/project-families.md`

- `rdub80/aframe-gui` - `Already studied as declarative A-Frame widget, layout, and interaction component library`
- `fernandojsg/aframe-teleport-controls` - `Already studied as parabolic/line teleport ray and landing-validation helper`
- `wmurphyrd/aframe-super-hands-component` - `Already studied as semantic hover/grab/stretch/drag/drop/click interaction layer`
- `Minty-Crisp/AUXL` - `Already studied as broad A-Frame world/menu factory and utility-shell construction kit`
- `SvetimFM/aframe-webxr-ui-toolkit` - `Already studied as lifecycle-managed menu registry and hand-tracking pressable toolkit`

## 120. Immersive analytics, spatial data visualization, and scientific viewer substrates

Primary docs:

- `../landscape/vr-projects-wave-149-immersive-analytics-spatial-data-visualization-and-scientific-viewer-substrates.md`
- `../landscape/project-families.md`

- `vriajs/vria` - `Already studied as immersive analytics grammar, spatial view compiler, and selection/filter callback surface`
- `vasturiano/3d-force-graph-vr` - `Already studied as VR force-graph scene shell with controller/mouse raycasters and tooltips`
- `vasturiano/aframe-forcegraph-component` - `Already studied as A-Frame force graph component with accessor schemas and raycaster events`
- `molstar/molstar` - `Already studied as scientific viewer plugin shell with managers, snapshots, Canvas3D, and XR input mapping`
- `widgetti/ipyvolume` - `Already studied as notebook-to-WebGL 3D data bridge with synced traits and volume texture tiling`

## 121. WebRTC remote rendering, WebXR streaming, and bidirectional input/control channels

Primary docs:

- `../landscape/vr-projects-wave-150-webrtc-remote-rendering-webxr-streaming-and-bidirectional-input-control-channels.md`
- `../landscape/project-families.md`

- `FusedVR/VRStreaming` - `Already studied as WebXR-to-Unity pose/control data-channel and VR camera streaming prototype`
- `Unity-Technologies/UnityRenderStreaming` - `Already studied as Unity signaling, peer, data-channel, and browser input-remoting stack`
- `Unity-Technologies/com.unity.webrtc` - `Already studied as low-level Unity WebRTC peer connection and data-channel primitive layer`
- `EpicGamesExt/PixelStreamingInfrastructure` - `Already studied as Unreal Pixel Streaming WebXR video projection and HMD/eye/gamepad client`
- `Azure/Unreal-Pixel-Streaming` - `Already studied as deployment-oriented Unreal signaling and matchmaker shell`

## 122. Social/world framework shells, scene schemas, and multi-user spatial app substrates

Primary docs:

- `../landscape/vr-projects-wave-151-social-world-framework-shells-scene-schemas-and-multi-user-spatial-app-substrates.md`
- `../landscape/project-families.md`

- `phoenixbf/aton` - `Already studied as scene JSON, semantic graph, spatial UI, media, Photon, and avatar platform`
- `PlumCantaloupe/circlesxr` - `Already studied as Networked-AFrame world shell with avatar templates, ownership, and object-world identity`
- `arenaxr/arena-web-core` - `Already studied as MQTT-backed A-Frame scene client with hands, Jitsi media, screenshare, prompts, and spatial audio`
- `BasisVR/Basis` - `Already studied as Unity/social VR networking, headless clients, compressed avatar sync, and avatar loading stack`
- `webaverse-studios/webaverse` - `Already studied as browser app-runtime, dynamic import, world/app manager, and player manager substrate`

## 123. Glanceable telemetry, simulator panels, and situational VR micro-overlays

Primary docs:

- `../landscape/vr-projects-wave-152-glanceable-telemetry-simulator-panels-and-situational-vr-micro-overlays.md`
- `../landscape/project-families.md`

- `Nexz/turncountervr` - `Already studied as cable-awareness rotation counter micro-overlay`
- `Denwa/vive-wireless-info-overlay` - `Source-light product reference for Vive Wireless temperature micro-overlays`
- `yydsok520/gpu-vram-monitor` - `Already studied as Windows GPU/VRAM telemetry overlay with tray, fan, and power-limit controls`
- `JMmayranpaa/RacingManager` - `Already studied as iRacing shared-memory telemetry panels and app launcher`
- `ironsled/vr-twitch-chat-ui` - `Already studied as MSFS VR-aware Twitch chat panel with readability profiles`

## 124. Protocol-driven overlay bridges, external overlay hosts, and minimal implementation baselines

Primary docs:

- `../landscape/vr-projects-wave-153-protocol-driven-overlay-bridges-external-overlay-hosts-and-minimal-implementation-baselines.md`
- `../landscape/project-families.md`

- `MeroFune/GOpy` - `Already studied as OSC gesture-parameter to HMD-relative overlay icon bridge`
- `beareogaming/BD-XSOverlay-notify` - `Already studied as BetterDiscord to XSOverlay WebSocket notification bridge`
- `OrangeJuicy69/VRC-NexusChat` - `Source-light product reference for VRChat OSC companion chat/HUD concepts`
- `kurohuku7/zenn-overlay-tutorial` - `Already studied as tutorial-grade OpenVR overlay lifecycle reference`
- `emymin/EmyOverlay` - `Already studied as C++ OpenGL/ImGui OpenVR overlay skeleton`
- `Marlamin/VROverlayTest` - `Already studied as C# OpenTK/OpenVR texture submission scratchpad`

## 125. Virtual displays, spatial-display OpenXR runtimes, and desktop fallback surfaces

Primary docs:

- `../landscape/vr-projects-wave-154-virtual-displays-spatial-display-openxr-runtimes-and-desktop-fallback-surfaces.md`
- `../landscape/project-families.md`

- `VirtualDrivers/Linux-Virtual-Display-Driver` - `Already studied as Linux xrandr/EDID virtual display manager with GTK workflow`
- `dfattal/openxr-3d-display` - `Already studied as canonical DisplayXR spatial-display OpenXR runtime`
- `maximum-game-22/openxr-3d-display` - `Fork / variant only; canonical upstream studied as dfattal/openxr-3d-display`
- `newilia/SbsImageViewer` - `Already studied as OpenXR stereo image viewer with launcher and projection controls`
- `r57zone/VR-Display` - `Source-light historical DIY HDMI/MIPI display concept reference`
- `tejasXR/Virtual-Desktop-VR` - `Source-light historical Unity/SteamVR virtual desktop POC`
- `Malcolmnixon/GodotXRDesktop` - `Already studied as Godot no-HMD synthetic XR tracker/action fallback addon`

## 126. Hand tracking, simulated XR hands, and reusable hand/control primitives

Primary docs:

- `../landscape/vr-projects-wave-155-hand-tracking-simulated-xr-hands-and-reusable-hand-control-primitives.md`
- `../landscape/project-families.md`

- `joemarshall/openxrhands` - `Already studied as Unity OpenXR hand joint and hand mesh extension bridge`
- `MThogersen/AutoHandSimulator` - `Already studied as AutoHand no-HMD hand/body interaction simulator`
- `InfernoDigital/RoboHands-UnityXR` - `Source-light product reference for Unity XR hand-pose package framing`
- `eisclimber/ExPresS-XR` - `Partially studied; Wave 155 deepened data-gathering, value-range, socket, menu, and toolkit primitives`

## 127. OpenXR/VRCFT eye-face modules, calibration clients, and avatar facetracking preparation

Primary docs:

- `../landscape/vr-projects-wave-156-openxr-vrcft-eye-face-modules-calibration-clients-and-avatar-facetracking-preparation.md`
- `../landscape/project-families.md`

- `regzo2/VRCFaceTracking-QuestProOpenXR` - `Already studied as archived Quest Pro OpenXR/VRCFT expression-mapping reference`
- `korejan/VRCFT-ALXR-Modules` - `Already studied as local/remote ALXR VRCFT module donor`
- `PawlygonStudio/VRC-Facetracking` - `Already studied as avatar-side facetracking package, threshold editor, and OSC cleanup donor`
- `tobexeon/PSVR2EyeTrackingCalibration` - `Already studied as real-time PSVR2 eye-gaze calibration client`

## 128. VRChat chatbox, speech/TTS, AI companions, and text-composition sidecars

Primary docs:

- `../landscape/vr-projects-wave-157-vrchat-chatbox-speech-tts-ai-companions-and-text-composition-sidecars.md`
- `../landscape/project-families.md`

- `S0L0GUY/NOVA-AI` - `Already studied as AI assistant, memory, multimodal input, and VRChat OSC tool-calling sidecar`
- `MaurerKrisztian/vrc-tts-osc` - `Already studied as TTS, virtual-audio, and chatbox micro-utility`
- `hollyntt/XOSC` - `Already studied as Linux-native chatbox telemetry and status composer`
- `TheArmagan/advosc` - `Already studied as visual chatbox editor, placeholder engine, avatar parameter control, and OSC forwarder`

## 129. VRChat OSC telemetry, avatar scaling, device/status, and parameter-control helpers

Primary docs:

- `../landscape/vr-projects-wave-158-vrchat-osc-telemetry-avatar-scaling-device-status-and-parameter-control-helpers.md`
- `../landscape/project-families.md`

- `Quesys-tech/vrcwatch.rs` - `Already studied as minimal avatar-as-watch OSC telemetry sender`
- `KutayX7/vrc-avi-scaler` - `Already studied as avatar eye-height scaling and compatibility shim donor`
- `VRLabs/Camera-System` - `Partially studied; Wave 158 deepened avatar-authored OSC camera-path companion architecture`

## 130. Haptic, physical-output routers, and wearable feedback bridges

Primary docs:

- `../landscape/vr-projects-wave-159-haptic-physical-output-routers-and-wearable-feedback-bridges.md`
- `../landscape/project-families.md`

- `kikookraft/HapticPatPat` - `Already studied as DIY Bluetooth ESP32 head-pat feedback bridge`
- `sync1211/owoskin-vrc` - `Already studied as OWO Skin VRChat integration and effect-engine donor`
- `intiface/intiface-game-haptics-router` - `Already studied as generic game rumble to external-device haptics router reference`

## 131. Foveated rendering, quad-view settings, and graphics-layer adaptation helpers

Primary docs:

- `../landscape/vr-projects-wave-160-foveated-rendering-quad-view-settings-and-graphics-layer-adaptation-helpers.md`
- `../landscape/project-families.md`

- `TallyMouse/QuadViewsCompanion` - `Source-light product/settings reference for safe QuadViews settings editing`
- `mbucchia/PimaxMagic4All` - `Already studied as vendor foveation SDK emulation and eye-provider fallback donor`
- `fholger/openvr_foveated` - `Already studied as OpenVR DLL replacement foveated-rendering wrapper`
- `mbucchia/_ARCHIVE_Varjo-Foveated` - `Already studied as archived OpenXR quad-view/foveation API-layer reference`
- `ViveSoftware/ViveFoveatedRendering` - `Already studied as Unity native D3D11/NVAPI VRS plugin and command-buffer reference`

## 132. OSCQuery VRChat discovery libraries and client primitives

Primary docs:

- `../landscape/vr-projects-wave-161-oscquery-vrchat-discovery-libraries-and-client-primitives.md`
- `../landscape/project-families.md`

- `galister/VrcAdvert` - `Already studied as minimal OSCQuery app advertiser`
- `minetake01/vrchat_osc` - `Already studied as Rust VRChat OSC/OSCQuery client and service-registration crate`
- `Natsumi-sama/OscQueryLibrary` - `Already studied as C# OSCQuery parameter-discovery and service-advertisement library`
- `Raphiiko/oyasumivr_oscquery` - `Already studied as limited Rust OSCQuery library with dotnet mDNS sidecar`
- `theepicsnail/vrchat_oscquery` - `Already studied as Python asyncio/threaded OSCQuery helper and multi-app proxy`

## 133. Resonite creator import/export, inspection, and screenshot utility helpers

Primary docs:

- `../landscape/vr-projects-wave-162-resonite-creator-import-export-inspection-and-screenshot-utility-helpers.md`
- `../landscape/project-families.md`

- `Yellow-Dog-Man/Resonite.UnitySDK` - `Already studied as official Unity-to-Resonite SDK with generated bindings and converters`
- `Phylliida/ResoniteUnityExporter` - `Already studied as Unity exporter, shared DTO, and IPC import processor reference`
- `dfgHiatus/ResoniteUnityPackagesImporter` - `Already studied as Unity package extraction/cache/import mod donor`
- `BlueCyro/CherryPick` - `Already studied as Resonite component selector search QoL reference`
- `hantabaru1014/ResoniteScreenshotExtensions` - `Already studied as screenshot metadata, restore, and webhook utility donor`

## 134. External pose, object, and sensor data to VRChat OSC bridges

Primary docs:

- `../landscape/vr-projects-wave-163-external-pose-object-and-sensor-data-to-vrchat-osc-bridges.md`
- `../landscape/project-families.md`

- `jangxx/VRC-Tracked-Objects` - `Already studied as avatar-relative tracked-object OSC bridge with calibration matrix`
- `FizzyApple12/VRChatOSCOptitrack` - `Already studied as NatNet rigid-body to VRChat OSC tracker bridge`
- `rogeraabbccdd/VRChat-MotionOSC` - `Already studied as webcam motion and face-expression OSC controller reference`
- `takana-v/quest_steamvr_fbt_tool` - `Already studied as simple SteamVR/OpenVR tracker to VRChat OSC FBT sender`
- `Alpyg/vrc_osc_tracker` - `Already studied as MediaPipe camera pose-estimation OSC tracker reference`

## 135. VRChat, OBS, audience captions, translation, and chat-ingress surfaces

Primary docs:

- `../landscape/vr-projects-wave-164-vrchat-obs-audience-captions-translation-and-chat-ingress-surfaces.md`
- `../landscape/project-families.md`

- `Sharrnah/whispering` - `Already studied as local multimodal speech/OCR/TTS platform with websocket overlay and VRChat OSC fan-out`
- `mmpneo/curses` - `Already studied as text-event bus and multi-target caption fan-out donor`
- `Harry-Jing/vrc-live-caption` - `Source-light VRChat live-caption and translation product reference`
- `FionnaPrefabs/Fionnas-Audio-Captions-Prefab` - `Package/distribution caveat only; current repo state is not a caption code donor`
- `Vinventive/VRChat-to-BLIP` - `Already studied as window-capture AI scene-caption accessibility experiment`
- `lexonegit/Unity-Twitch-Chat` - `Already studied as Unity Twitch IRC ingress and metadata-aware main-thread queue donor`

## 136. Open Brush, Tilt asset pipelines, browser viewers, shader loaders, and collaborative drawing

Primary docs:

- `../landscape/vr-projects-wave-165-open-brush-tilt-asset-pipeline-browser-viewers-shader-loaders-and-collaborative-drawing.md`
- `../landscape/project-families.md`

- `icosa-foundation/open-brush` - `Already studied as Open Brush creative app/API/sketch-load/export and brush/toolchain donor`
- `icosa-foundation/gallery-viewer` - `Already studied as browser Open Brush/Tilt asset viewer with metadata restoration and XR mode`
- `icosa-foundation/three-icosa` - `Already studied as Three.js Open Brush/Tilt material and shader restoration donor`
- `icosa-foundation/three-tiltloader` - `Already studied as raw .tilt zip/binary stroke loader`
- `Prystopia/c-sharp-tiltbrush-toolkit` - `Already studied as C# .tilt parse/edit/write toolkit`
- `DrHibbitts/TiltBrushConverter` - `Already studied as Python OBJ/FBX conversion option and mesh semantics reference`
- `Phylliida/P2PDraw` - `Already studied as collaborative stroke segment protocol idea with legacy Unity caveats`

## 137. Gaussian splat immersive 3D asset viewers, editors, and XR display surfaces

Primary docs:

- `../landscape/vr-projects-wave-166-gaussian-splat-immersive-3d-asset-viewers-editors-and-xr-display-surfaces.md`
- `../landscape/project-families.md`

- `playcanvas/supersplat` - `Already studied as browser Gaussian splat editor with command history and GPU data passes`
- `playcanvas/supersplat-viewer` - `Already studied as static WebXR splat viewer with settings schema, camera modes, collision, and annotations`
- `playcanvas/model-viewer` - `Already studied as general PlayCanvas model viewer shell with XR/AR placement controller`
- `mkkellogg/GaussianSplats3D` - `Already studied as Three.js drop-in splat renderer with multi-format loaders, workers, and WebXR caveats`
- `aras-p/UnityGaussianSplatting` - `Already studied as Unity Gaussian splat asset/runtime renderer with editing, cutouts, compression, and VR caveats`
- `clarte53/GaussianSplattingVRViewerUnity` - `Already studied as native CUDA/OpenXR Unity plugin and VR splat viewer reference`
- `keijiro/SplatVFX` - `Already studied as experimental Unity VFX Graph splat binder and substrate caveat`

## 138. Godot XR toolkits, vendor extensions, templates, and face-tracking bridges

Primary docs:

- `../landscape/vr-projects-wave-167-godot-xr-toolkits-vendor-extensions-templates-and-face-tracking-bridges.md`
- `../landscape/project-families.md`

- `GodotVR/godot-xr-tools` - `Already studied as Godot XR function-node toolkit for pointer, pickup, teleport, movement, hands, settings, and scene composition`
- `GodotVR/godot_openxr_vendors` - `Already studied as Godot OpenXR vendor extension stack with export feature gates and runtime capability surfaces`
- `Malcolmnixon/godot-xr-dungeon-template` - `Already studied as Godot XR product-template shell with persistence, staging, HUD, and pause menu references`
- `beepobb/godot-htc-face-tracking-bridge` - `Already studied as source-driven HTC facial tracking GDExtension bridge caveat`
- `boku-ilen/godot-vr-toolkit` - `Already studied as legacy Godot OpenVR viewport-to-mesh UI, teleport, and interactable primitive reference`

## 139. Rust, Bevy, wgpu, and OpenXR app/rendering bring-up

Primary docs:

- `../landscape/vr-projects-wave-168-rust-bevy-wgpu-and-openxr-app-rendering-bring-up.md`
- `../landscape/project-families.md`

- `awtterpip/bevy_oxr` - `Already studied as Bevy OpenXR plugin/render lifecycle donor with manual wgpu device/queue handoff`
- `leetvr/hotham` - `Already studied as Rust XR engine context split and OpenXR runtime stub/harness donor`
- `blaind/xrbevy` - `Already studied as legacy Bevy OpenXR architecture caution around renderer and swapchain ownership`
- `matthewjberger/wgpu-example` - `Already studied as explicit wgpu/OpenXR/Vulkan graphics binding and Android/desktop bring-up sample`
- `robotics-erlangen/xrvis` - `Already studied as live network data to XR panel visualization and ray-to-UI pointer reference`

## 140. Universal VR game mod injectors, managers, and compatibility shells

Primary docs:

- `../landscape/vr-projects-wave-169-universal-vr-game-mod-injectors-managers-and-compatibility-shells.md`
- `../landscape/project-families.md`

- `praydog/UEVR` - `Already studied as Unreal VR injector callback SDK and profile/script reference with strong invasive caveats`
- `praydog/REFramework` - `Already studied as graphics-hook coexistence and mod API reference with invasive caveats`
- `Raicuparta/rai-pal` - `Already studied as VR mod manager manifest, provider discovery, install action, and compatibility database donor`
- `Raicuparta/uuvr` - `Already studied as Unity XR subsystem injection and screen-space UI redirection reference with invasive caveats`
- `keton/chihuahua` - `Already studied as compact DLL injection utility boundary and safety caveat`
- `NewUnityModder/UnityVRMod` - `Already studied as Unity VR safe-mode startup, backend abstraction, and scene-change reinitialization reference`
- `DaXcess/LCVR` - `Already studied as game-specific VR mod startup gate, hash/version check, dependency preload, and patch-group reference`
- `DaXcess/RepoXR` - `Already studied as game-specific OpenXR compatibility shell with runtime logging and RPC patch registration`

## 141. Quest, PICO, HoloLens marker tracking and remote hand-data utilities

Primary docs:

- `../landscape/vr-projects-wave-170-quest-pico-hololens-marker-tracking-and-remote-hand-data-utilities.md`
- `../landscape/project-families.md`

- `TakashiYoshinaga/QuestArUcoMarkerTracking` - `Already studied as calibrated Quest passthrough camera ArUco/ChArUco marker-tracking donor`
- `picoxr/ArUcoMarkerTracking` - `Already studied as PICO Enterprise marker callback and seethrough lifecycle donor`
- `handzlikchris/Unity.QuestRemoteHandTracking` - `Already studied as remote Quest hand-data split transport donor with UDP poses and TCP skeleton/mesh`
- `doughtmw/ArUcoDetectionHoloLens-Unity` - `Already studied as dependency-heavy HoloLens ArUco calibration and Research Mode reference`
- `NormandErwan/ArucoUnity` - `Already studied as reusable Unity ArUco camera abstraction and calibration package donor`
- `nooway077/HoloLens2CVExperiments` - `Already studied as HoloLens2 Research Mode marker pose and camera-to-world transform pipeline donor`

## 142. XR behavior recording, physiological replay, olfactory display, and sparse-camera mocap

Primary docs:

- `../landscape/vr-projects-wave-171-xr-behavior-recording-physiological-replay-olfactory-display-and-sparse-camera-mocap.md`
- `../landscape/project-families.md`

- `liris-xr/PLUME` - `Already studied as docs-first XR recorder/viewer/timeline/physiological-signal product reference`
- `liris-xr/XREcho` - `Already studied as Unity XR recording, replay, event, trajectory, gaze, and heatmap source donor`
- `liris-xr/Nebula-Core` - `Already studied as multisensory olfactory display serial/Android bridge and experiment logging donor`
- `liris-xr/kineo` - `Already studied as sparse-camera mocap pipeline, online calibration, and BVH/USD export helper reference`

## 143. Overlay window surfaces, game overlay managers, and scriptable overlay shells

Primary docs:

- `../landscape/vr-projects-wave-172-overlay-window-surfaces-game-overlay-managers-and-scriptable-overlay-shells.md`
- `../landscape/project-families.md`

- `imagitama/react-electron-openvr` - `Already studied as Electron/React offscreen shared-texture OpenVR overlay donor`
- `KotRikD/steamvr-overlay` - `Already studied as injected overlay window manager and typed IPC donor with invasive caveats`
- `RealWhyKnot/WKOpenVR` - `Already studied as modular SteamVR driver/overlay umbrella, flag-gated modules, pipes, safety gates, and ImGui host donor`
- `SableVII/Sable-Overlay` - `Already studied as Unity modular boundary overlay, module UI, OSC hook, and JSON settings reference`
- `Alphasumsi/Honey_Overlays` - `Already studied as iRacing OpenXR overlay engine with WPF editor, browser/window capture, named-pipe control, and in-headset placement donor`
- `Ikeiwa/VRMocapOverlay` - `Already studied as Unity/OpenVR render-texture overlay prefab and event-loop baseline`
- `4x8Matrix/Hoku` - `Source-light scriptable OpenVR/Luau overlay-engine product reference`

## 144. OpenXR API-layer adaptation, hand transform offsets, and graphics compatibility

Primary docs:

- `../landscape/vr-projects-wave-173-openxr-api-layer-adaptation-hand-transform-offsets-and-graphics-compatibility.md`
- `../landscape/project-families.md`

- `LordOfDragons/openxr_oscclient` - `Already studied as OSC eye/face tracking to OpenXR extension adapter donor`
- `CraigMason/OpenXR-Hand-Transform-Offset-Layer` - `Already studied as runtime-side hand-joint transform correction micro-layer`
- `Sorenon/sorenon_openxr_layer` - `Already studied as Rust OpenXR graphics compatibility layer and wrapper-registry donor with performance caveats`
- `maluoi/openxr-layer-template` - `Already studied as compact C11/CMake generated-dispatch OpenXR API-layer template`

## 145. Spatial anchors, shared scenes, Magic Leap persistence, and colocation

Primary docs:

- `../landscape/vr-projects-wave-174-spatial-anchors-shared-scenes-magic-leap-persistence-and-colocation.md`
- `../landscape/project-families.md`

- `oculus-samples/Unreal-SpatialAnchorsSample` - `Source-light Meta Unreal spatial anchor baseline and setup reference`
- `oculus-samples/Unreal-SharedAnchorsSample` - `Already studied as shared-anchor menu, local/cloud persistence state, LAN session, and anchor action UX reference`
- `oculus-samples/Unreal-SharedSceneSample` - `Already studied as anchor-relative shared scene serialization and reconstruction donor`
- `magicleap/SpatialAnchorsExample` - `Already studied as Magic Leap localization-gated anchor manager, persistent content binding, worker query, and Space selector donor`
- `dilmerv/MagicLeapSpatialAnchors` - `Already studied as ARFoundation/OpenXR Storage API lifecycle, publish/query/delete callbacks, control panel, and anchor status UI donor`

## 146. VRChat OSC web panels, debug surfaces, controller helpers, and sensor bridges

Primary docs:

- `../landscape/vr-projects-wave-175-vrchat-osc-web-panels-debug-surfaces-and-sensor-bridges.md`
- `../landscape/project-families.md`

- `ThatGuyThimo/leapmotion-osc` - `Already studied as Leap Motion finger distance/spread to VRChat OSC avatar-parameter bridge`
- `a2942/VRChat-OSC-WEB-Chat` - `Already studied as Flask/browser VRChat chatbox panel with theme/assets config and OSC chat/typing routes`
- `qbitzvr/Drone-OSC-Controller` - `Product workflow reference for VRCLens drone-control avatar/menu OSC micro-tool`
- `ChrisFeline/VRChatOSCLib` - `Already studied as C# VRChat OSC client, parameter/input/chatbox wrapper, listener, and message classifier`
- `firocore/VRChatOSCDebugger` - `Already studied as lightweight Python/Tk live OSC debugger with ignore list and VRChat settings log checks`
- `Misaka-L/VRChatOscDebugger` - `Already studied as Avalonia OSCQuery service discovery and hierarchical parameter browser reference`
- `networkpenetrationtester/VRChat-OSC-WebPanel` - `Already studied as TypeScript OSC router/interface, avatar JSON loader, acknowledgement helper, and Svelte parameter panel donor`
- `200Tigersbloxed/HRtoVRChat_OSC` - `Already studied as heart-rate sensor/service/SDK bridge to VRChat avatar parameters and app-bridge status donor`

## 147. DIY eye/mouth tracking, VRCFT modules, gaze calibration, and OpenXR eye consumers

Primary docs:

- `../landscape/vr-projects-wave-176-diy-eye-mouth-tracking-vrcft-modules-and-gaze-calibration.md`
- `../landscape/project-families.md`

- `Project-Babble/ProjectBabble` - `Already studied as source-first mouth tracking app with camera ROI, ONNX inference, calibration, smoothing, and OSC expression output`
- `EyeTrackVR/EyeTrackVR` - `Already studied as affordable eye tracking stack with multiple pupil algorithms, calibration, VRChat native eye output, and VRCFT v1/v2 bridges`
- `cspark-development/VRCFaceTracking-TobiiXR` - `Already studied as Tobii Stream Engine to VRCFaceTracking module with native DLL extraction and per-eye mapping`
- `ryan9411vr/EyeTracking` - `Already studied as user-trained TensorFlow eye tracking client with Unity VR target-acquisition helper and multi-format OSC output`
- `Project-Babble/BabbleCalibration` - `Already studied as Godot OpenVR/OpenXR in-headset calibration routine runner connected to a desktop controller`
- `headassbtw/ResoniteOpenXREyeTracking` - `Already studied as Resonite mod consuming OpenXR eye/face extensions through a headless session and engine input driver`
- `edvardsoe/foveated-rendering-demo` - `Source-light gaze/foveated-rendering product reference`

## 148. Resonite headless deployment, operations, REST/IPC, and compatibility patches

Primary docs:

- `../landscape/vr-projects-wave-177-resonite-headless-deployment-operations-rest-ipc-and-compatibility.md`
- `../landscape/project-families.md`

- `voxelbonecloud/resonite-headless-docker` - `Already studied as containerized Resonite headless runtime with Steam update, config/log/mod volumes, and git sync`
- `Zetaphor/resonite-headless-manager` - `Already studied as FastAPI/WebSocket Docker attach console with logs, parsed status, commands, restart, and metrics`
- `FlippedCodes/Resonite-Headless-Discord-Bot` - `Already studied as Discord slash-command operations surface using Docker labels, command markers, world-list messages, and config edits`
- `JackTheFoxOtter/resonite-rest` - `Already studied as in-engine REST server and resource tree for Resonite/headless data`
- `Nytra/ResoniteHeadlessHeadServer` - `Already studied as deprecated but useful shared-memory packet/export model for headless scene/render state`
- `BlueCyro/Nimbus` - `Already studied as Harmony runtime compatibility shim for Resonite/.NET transition issues`
- `BlueCyro/Cumulo` - `Already studied as Mono.Cecil irreversible pre-patcher plus Nimbus/Harmony bundling compatibility helper`

## 149. Visual impairment simulation, gaze-contingent accessibility, and UI accessibility helpers

Primary docs:

- `../landscape/vr-projects-wave-178-visual-impairment-simulation-gaze-contingent-accessibility-and-ui-a11y.md`
- `../landscape/project-families.md`

- `petejonze/OpenVisSim` - `Already studied as Unity per-eye visual impairment simulator with gaze-contingent masks, blur levels, and linkable effect fields`
- `VARID-XR/VARID-plugin-ue5` - `Already studied as Unreal visual impairment post-process plugin with Blueprint condition setters, per-eye state, gaze input, and RDG blur pyramids`
- `rulyox/VisualImpairmentVR` - `Already studied as mobile/Cardboard camera passthrough impairment shader reference`
- `ojwalch/LowVisionVR` - `Already studied as Android dual-eye camera preview and RenderScript low-vision filter app`
- `lukasmaxim/Glaucoma-VR` - `Already studied as patient-data-to-mask Varjo gaze/context/focus visual-field simulator`
- `mikrima/UnityAccessibilityPlugin` - `Already studied as Unity screen-reader-like UI accessibility manager with labels, hints, containers, TTS/audio queue, touch exploration, and virtual keyboard`

## 150. Capture, screenshot, media projection, window capture, and photomode helpers

Primary docs:

- `../landscape/vr-projects-wave-179-capture-screenshot-media-projection-window-capture-and-photomode-helpers.md`
- `../landscape/project-families.md`

- `yasirkula/Unity360ScreenshotCapture` - `Already studied as Unity cubemap-to-equirectangular 360 screenshot capture with async readback and GPano metadata`
- `rurre/Editor-Screenshot` - `Already studied as Unity editor transparent screenshot and thumbnail authoring utility`
- `Team-on/UnityScreenShooter` - `Already studied as screenshot sequence/helper with data settings, pause/unpause, filenames, language, and UI state`
- `Phylliida/UnityWindowsCapture` - `Already studied as Windows window/desktop/Chromium capture into Unity textures through BitBlt, Desktop Duplication, and browser texture wrappers`
- `t-34400/QuestMediaProjection` - `Already studied as Quest MediaProjection service wrapper exposing screen capture as Texture2D, barcode results, saved images, and WebRTC streams`
- `UnityTechnologies/PhotoMode` - `Already studied as Unity in-game photomode surface with camera/postprocess/UI/sticker/frame controls`
- `vimeo/vimeo-unity-sdk` - `Already studied as Unity 360/stereo recording, chunked upload, metadata playback, and Vimeo media pipeline reference`

## 151. XR text-entry keyboards, input surfaces, and pointer bridges

Primary docs:

- `../landscape/vr-projects-wave-180-xr-text-entry-keyboards-input-surfaces-and-pointer-bridges.md`
- `../landscape/project-families.md`

- `vuplex/unity-keyboard` - `Already studied as browser-rendered Unity/WebView keyboard bridge with generated C# HTML bundle and JS/native messages`
- `felixtrz/xrkeys` - `Already studied as Three.js WebXR low-draw-call keyboard with raycast-to-UV key-mask picking`
- `ErikSom/VirtualKeyboard-VR-Ready` - `Already studied as canvas texture keyboard with UV pointer input, texture dirty state, multilingual layouts, swipe, and suggestions`
- `robertlalum/vr-virtual-keyboard` - `Already studied as A-Frame controller-ray keyboard with optional WebSocket key/text/pointer bridge`
- `JuliusWon/XR-Keyboard-for-Unity` - `Already studied as minimal Unity procedural key-grid baseline with TMP input caveats`
- `pinglis/XRSimpleKeyboard` - `Already studied as Unity physical collider keyboard with localized layouts, key-width prefabs, two-hand press tracking, and UnityEvents`
- `MalekiRe/bevy_xr_keyboard` - `Already studied as experimental Bevy/OpenXR hand-attached pinch-select text-entry surface`
- `technobaboo/stardust-xr-keyboard-plugin` - `Already studied as thin Stardust XR Qt virtual-keyboard plugin sample emitting synthetic key events`

## 152. WebXR multiplayer, shared rooms, and WebRTC scene shells

Primary docs:

- `../landscape/vr-projects-wave-181-webxr-multiplayer-shared-rooms-and-webrtc-scene-shells.md`
- `../landscape/project-families.md`

- `danielesteban/blocks` - `Already studied as WebXR room with WebSocket/protobuf signaling, SimplePeer audio/data, binary pose payloads, and canvas menu UI`
- `De-Panther/webxr-multiplayer-template` - `Already studied as Unity WebXR multiplayer template with Lobby, Relay, Vivox, NGO, XR player state, and hand-pose fidelity tiers`
- `kylebakerio/vrgoclub` - `Product reference for social WebXR Go club with cross-device presence, voice/video, hand tracking, board sync, and AI heatmap framing`
- `Immersive-Collective/webxr-webrtc-dc-scene` - `Already studied as WebXR media/capability scene with webcam texture, rayline/pointer visuals, teleport helpers, and DataChannel caveat`
- `Radet5/webroom-vr` - `Already studied as socket.io/simple-peer WebXR room with VR/desktop users, shared physics objects, grab/release events, and throw velocity`
- `JT5D/xrai-spatial-web` - `Already studied as spatial-web presence room, view registry, HUD orchestrator, hand/voice input, and agent-overlay architecture reference`
- `RNMUDS/webxr-multiplayer-room` - `Already studied as minimal A-Frame classroom with Socket.IO rooms, chat, colored avatars, pose thresholds, and PeerJS setup caveat`

## 153. ROS/robot teleoperation bridges and VR operator shells

Primary docs:

- `../landscape/vr-projects-wave-182-ros-robot-teleoperation-bridges-and-vr-operator-shells.md`
- `../landscape/project-families.md`

- `UM-ARM-Lab/vr_teleop` - `Already studied as ROS1 VR pose-to-MoveIt IK bridge with enabled service, measured-state seed, joint-distance safety gate, gripper commands, and validity publishing`
- `UM-ARM-Lab/vr_ros2_bridge` - `Already studied as Unity OpenXR controller/tracker publisher to ROS2 with HTC Vive tracker roles, pose/twist/button axes, coordinate conversion, and RViz debug topics`
- `h2r/ros_reality_bridge` - `Already studied as legacy ROS TF/camera/rosbridge to Unity scene bridge with compact string pose stream and camera compression launch plumbing`
- `Intelligent-Robotics-Lab/vr-teleoperation` - `Already studied as OpenVR/ROS robot operator station with modes, ImGui dashboard, camera texture, action abstraction, and calibrated transform-to-joint mapping`
- `zz0320/vr_teleoperation_ros` - `Already studied as WebSocket VR pose receiver to fixed-rate ROS commands with arm/torso/base modes, smoothing, RelaxedIK, camera UDP chunks, and audio feedback`
- `Mcen25/VR-Teleoperation-Robotics-Platform` - `Already studied as thin Unity XRI/ROS# camera wall and network diagnostics shell for robot operator views`
- `lingxiaomeng/VR_teleoperation_ros` - `Source sync candidate was empty; not registered as studied beyond this exclusion note`

## 154. DIY VR headset/controller hardware, firmware, and spec references

Primary docs:

- `../landscape/vr-projects-wave-183-diy-vr-headset-controller-hardware-firmware-and-spec-references.md`
- `../landscape/project-families.md`

- `vis3r/NxtVR` - `Already studied as DIY headset firmware/HID reference with Pico/STM32 IMU readout, TinyUSB/USBComposite HMD reports, and MPU6050 calibration`
- `Kwiatens/FloV3R` - `Already studied as DIY 6DoF headset/controller BOM, PCB, CAD, PSMoveServiceEx/HadesVR dependency, and incomplete firmware/driver documentation reference`
- `Jade-Vincent/Persephone-VR-Headset` - `Already studied as source-light DIY headset CAD/BOM reference with 2K LCD, lenses, Pro Micro/Pico, and MPU6050`
- `CSParnell78/OpenVision` - `Already studied as source-light DIY headset concept with display, microcontroller, gyro, phone shell, and wireless transmitter checklist`
- `vrrare/vr-headset-specs` - `Already studied as JSON/CSV headset specification dataset with schema for display, optics, tracking, audio, connectivity, battery, physical, and feature fields`
- `dhfmzk/VRController` - `Already studied as Arduino/MPU9250 Bluetooth controller firmware with documented 34-byte quaternion/position/joystick/trigger packet`
- `BlaiseSaunders/DIY-VR-Controller-OpenCV` - `Already studied as Python/OpenCV IR bright-marker tracker sending normalized coordinates over UDP`
- `Windastella/open-vr-controller` - `Source-light no-progress OpenXR DIY controller concept; retained only as thin/excluded reference`
- `shehraan/DIY_VR_Controller` - `Already studied as ESP32/MPU6050 BLE HID controller plus OpenVR driver shell with Madgwick filter, EEPROM calibration, haptics, HID transport, input profile, and freshness gates`

## 155. Low-latency XR video, point-cloud, and browser stream surfaces

Primary docs:

- `../landscape/vr-projects-wave-184-low-latency-xr-video-point-cloud-and-browser-stream-surfaces.md`
- `../landscape/project-families.md`

- `bugman-007/XR-Low-Latency-Stereo-Streaming` - `Already studied as minimal browser sender, WebSocket signaling server, and Unity WebRTC video-track-to-texture receiver`
- `livekit-examples/spatial-video` - `Already studied as Meta Spatial SDK stereo panel connected to LiveKit room video tracks with left-right stereo contract`
- `Cont-ai-ner/PointCast3D` - `Already studied as RealSense UDP point-cloud sender with chunk headers and Unity mesh-point receiver`
- `studio4evr/FFMPEG-VRQ` - `Empty/source-light candidate; cloned with no source files and retained only as exclusion note`
- `N78Wy/relavr` - `Already studied as Quest MediaProjection/WebRTC sender with permission/session coordinator, codec probing, QR/manual connection, and adaptive profile downgrade`
- `ranvuemor/SpatialVideoBrowser` - `Already studied as native Unity/Quest WebView video browser surface using XRI and Android WebView texture composition`

## 156. Accessibility, embodied locomotion, redirected walking, and zero-G control

Primary docs:

- `../landscape/vr-projects-wave-185-accessibility-embodied-locomotion-redirected-walking-and-zero-g-control.md`
- `../landscape/project-families.md`

- `justinmajetich/vr-wheelchair` - `Already studied as embodied wheelchair locomotion rig with wheel interactables, disposable grab points, brake assist, and haptic feedback`
- `XR-Access-Initiative/Locomotion-Accessibility-Toolkit` - `Already studied as accessibility locomotion option pack around gaze teleport, smooth motion, snap turn, and in-world instruction framing`
- `simeonradivoev/echo-unity` - `Already studied as zero-G grab/thruster movement donor with static/dynamic joints, release behavior, thruster heat, and comfort/realism toggle`
- `DigitalDiceworks/ddw-locomotion-system` - `Already studied as natural locomotion hub with input providers, modifiers, movement consumers, and event boundaries`
- `curvaturegames/space-extender` - `Already studied as redirected-walking Unity package with translation/rotation gains, overlapping-room redirectors, editor UX, and CSV telemetry`
- `LariWa/VR-Locomotion` - `Empty/source-light candidate; cloned with no source files and retained only as exclusion note`

## 157. VR menu, radial control, avatar-menu editing, and OSC command surfaces

Primary docs:

- `../landscape/vr-projects-wave-186-vr-menu-radial-control-avatar-menu-editing-and-osc-command-surfaces.md`
- `../landscape/project-families.md`

- `VRwithAndrew/VR-RadialMenu` - `Source-light Unity radial menu template with prefab/assets and effectively empty core scripts`
- `Gustorvo/RadialMenuVR` - `Already studied as numeric-spring radial command menu with dynamic items, hover/select events, attachments, and menu animation`
- `ryangadz/RadialMenu` - `Source-light Unreal XR radial-menu plugin reference dominated by binary Blueprint/assets`
- `GabrielDiDomenico/RadialMenu` - `Already studied as wrist-rotation radial-menu concept and thin Unity/XRI sample with alpha-hit-test UI selection notes`
- `kblood/Quest-VR-Menu` - `Already studied as Quest launcher/home menu prototype using grabbable app cubes, collision confirmation, and Android launch intents`
- `CascadianVR/VRC-Menu-Translator` - `Already studied as Unity Editor utility recursively traversing and translating VRChat expression menus and controls`
- `Tazaur/VrCScalingTool` - `Already studied as desktop VRChat OSC scaling command companion with slots, hotkeys, OSCQuery, avatar feedback, tray UI, and SteamVR manifest`

## 158. Heart-rate, wearable, ANT/BLE, and sensor-to-OSC bridge variants

Primary docs:

- `../landscape/vr-projects-wave-187-heart-rate-wearable-ant-ble-and-sensor-to-osc-bridge-variants.md`
- `../landscape/project-families.md`

- `kamyu1537/hr-osc` - `Already studied as Tauri/Rust heart-rate bridge with HTTP BPM ingress and native OSC sender commands`
- `Curtis-VL/HeartRateOnStream-OSC` - `Already studied as OBS-WebSocket compatibility shim that receives HeartRateOnStream updates and forwards multiple VRChat OSC HR encodings`
- `Solexid/OSC-VRChat-Feeder` - `Already studied as Android/MAUI BLE and phone-sensor feeder with profiles, normalization, Mi Band HR/steps, rotation, and OSC output`
- `TangNPC/ble-osc-heartrate` - `Already studied as minimal Python BLE advertisement HR micro-bridge to VRChat OSC parameters`
- `KotRikD/vrc_hyperate_chatbox` - `Already studied as Electron Hyperate WebSocket bridge with chatbox formatting, debounce, connection state, and prefab-compatible OSC parameters`
- `DangerKiddy/HeartRateMonitorVRC` - `Already studied as Windows BLE pulse-oximeter bridge with reconnect, GATT HR parsing, derived avatar parameters, session min/max, and beat emulation`
- `RedlineTriad/vrchat_ant_hr` - `Already studied as Rust ANT+ HR dongle bridge with computed/intra-beat BPM modes, anomaly filtering, and VRChat OSC output`
- `Naraenda/osc-hr-ble` - `Already studied as compact Rust BLE GATT heart-rate parser sending raw/digit/normalized OSC bundle parameters`

## 159. VRChat OSC voice, STT, translation, and extensionable chatbox pipelines

Primary docs:

- `../landscape/vr-projects-wave-188-vrchat-osc-voice-stt-translation-and-extensionable-chatbox-pipelines.md`
- `../landscape/project-families.md`

- `MrShitFox/FoxTrans` - `Already studied as C# WebRTC VAD voice-translation sidecar with pre-roll buffering, WAV packing, OpenRouter direct audio translation, typing indicator, and VRChat chatbox output`
- `ewrt101/OSC_Voice` - `Already studied as C# multi-mode chatbox sender for time/file display, local STT, AssemblyAI realtime/chunk STT, manual OSC packing, and typing state`
- `R-VUt/OSC-SRTC` - `Already studied as Python GUI STT/translation pipeline with avatar OSC language/PTT/on-off controls, dual-language output, Romaji, and Flask extension chain`

## 160. VRChat chatbox media/status and bounded text composition microtools

Primary docs:

- `../landscape/vr-projects-wave-189-vrchat-chatbox-media-status-and-bounded-text-composition-microtools.md`
- `../landscape/project-families.md`

- `Voiasis/RustyChatBox` - `Already studied as Linux Rust/egui chatbox composer with dependency-gated media/system modules, persisted config, MPRIS/playerctl integration, and rosc output`
- `bddvlpr/vrc-osc-spotify` - `Already studied as Node/TypeScript Spotify OAuth bridge with token persistence, playback polling, chatbox output, avatar bool state, and lyric scheduling`
- `Massivendurchfall/vrchat-osc-spotify` - `Already studied as Python Spotify status GUI with PKCE auth, templates, progress bars, truncation, anti-spam, AFK tags, and keepalive sends`
- `Jakhaxz/VRChatSpotifyControler` - `Already studied as Windows avatar-OSC-to-Spotify media controller with play/pause, next/previous, volume, and now-playing chatbox output`
- `Null-K/VRChat-OSC-ChatBox` - `Already studied as template-variable chatbox GUI with placeholder catalog, extension registry, live preview, timer sends, and length warning`
- `WillW129/VRChat_OSC_Display_Mate` - `Already studied as Windows status aggregator for active window, system stats, media, idle, Pulsoid HR, and change/keepalive send gating`
- `nekochanfood/VRChat_OSC_Chatbox_for_GO` - `Already studied as minimal Go CLI chatbox sender baseline with message, host, port, and continuous flags`

## 161. Web, phone, and browser remote OSC control surfaces

Primary docs:

- `../landscape/vr-projects-wave-190-web-phone-and-browser-remote-osc-control-surfaces.md`
- `../landscape/project-families.md`

- `sselecirPyM/WebVRChatOSC` - `Already studied as ASP.NET/Quasar local web OSC panel with CoreOSC service, LiteDB custom buttons, avatar JSON parameter discovery, and chatbox/input controls`
- `MiaBub/VRChat-OSC-Controller-Client` - `Already studied as static browser/phone control client with keyboard, joystick, jump, chatbox, WebSocket reconnect, and ping loop`
- `MiaBub/VRChat-OSC-Controller-Server` - `Already studied as Node WebSocket-to-OSC relay with command map, input-path sends, chatbox relay, key-up-all reset, and remote-control security caveats`

## 162. VRC haptics server, firmware, hardware, and trigger bridge lineage

Primary docs:

- `../landscape/vr-projects-wave-191-vrc-haptics-server-firmware-hardware-and-trigger-bridge-lineage.md`
- `../landscape/project-families.md`

- `VRC-Haptics/VRCH-Server` - `Already studied as Rust/Tauri VRC haptics manager with OSC batching, haptic maps, interpolation, device manager, WiFi/BLE transports, and config save loop`
- `VRC-Haptics/VRCH-Firmware` - `Already studied as ESP32/ESP8266 haptics firmware with LittleFS config, serial/OSC commands, multicast discovery, LEDC/PCA motor outputs, and stale reset behavior`
- `virtuallyaverage/VRC-Haptics-Host` - `Already studied as older Python VRC haptics host with mDNS discovery, contact parameter callbacks, modulation, board handlers, and `/h` packet output`
- `virtuallyaverage/VRC-Haptics-Firmware` - `Superseded firmware lineage reference for comparison with modern VRC-Haptics/VRCH-Firmware`
- `virtuallyaverage/VRC-Haptics-Hardware` - `Hardware lineage reference with PCB, Gerber, KiCad, BOM, CPL, and ordered JLC export artifacts; development moved to newer hardware repo`
- `sync1211/HapticPatternTriggerOSC` - `Already studied as WinForms OSC boolean-to-bHaptics tact preset trigger bridge with pattern import, mapping, playback, and reset`
- `TahvoDev/AXHaptics` - `Already studied as deprecated VRCOSC AXIS tracker haptics module mapping VRC/bHaptics-compatible parameters to UDP node vibration commands`
- `Pillazo/VRCHaptics` - `Already studied as legacy DIY VRC haptics stack with VB.NET OSC host, serial provisioning, multicast intensity packets, BOM/hardware docs, and ESP firmware`

## 163. PSVR2 OpenXR passthrough, eye-tracking, and SteamVR integration shims

Primary docs:

- `../landscape/vr-projects-wave-192-psvr2-openxr-passthrough-eye-tracking-and-steamvr-integration-shims.md`
- `../landscape/project-families.md`

- `Obsidiate/psvr2passthrough` - `Already studied as PSVR2 OpenXR implicit API layer with loader negotiation, dispatch interception, D3D11 session adoption, shared-memory camera feed, per-eye passthrough composition, config toggles, and latency/calibration caveats`
- `BattleAxeVR/PSVR2_STEAMVR_EYE_TRACKING_SHIM` - `Already studied as SteamVR server-driver shim wrapping the PSVR2 HMD driver and exposing named-pipe gaze data through a standard gaze interaction path; high-risk driver-hook caveat`
- `DMJC/monado-psvr2` - `Already studied as Monado PSVR2 runtime-driver fork with build option, prober, USB endpoint constants, distortion, pose/view handling, status/SLAM/camera flows, and runtime-driver caveats`
- `etwodev/Volby` - `Source-light PSVR2 SteamVR integration product reference; retained as thin framing node until source boundaries are visible`
- `mbucchia/_ARCHIVE_OpenXR-Eye-Trackers` - `Already studied as archived multi-source OpenXR eye-tracker API layer with gaze extension gating, tracker priority, PSVR2 Toolkit TCP polling, validity checks, and stale-data behavior`

## 164. VRChat OSC physical-output safety and device-control bridge variants

Primary docs:

- `../landscape/vr-projects-wave-193-vrchat-osc-physical-output-safety-and-device-control-bridge-variants.md`
- `../landscape/project-families.md`

- `ccvrc/DG-LAB-VRCOSC` - `Already studied as PySide6 DG-LAB/VRCOSC bridge with GUI tabs, YAML config, command queue, source enable/cooldown flags, chatbox telemetry, SoundPad/ToN integration, OSCQuery service, and generated-code/safety caveats`
- `amoeet/VRChat_X_DGLAB` - `Thin C# DG-LAB GUI bridge variant; retained as source-light parameter-to-waveform reference`
- `boyqiu-001/VRCHAT-OSC-to-DGLAB` - `Already studied as Tkinter avatar-parameter rule editor mapping judge modes, values, waveform patterns, channel, intensity, and ticks to DG-LAB output`
- `ion-aluminium/VRC-DGLAB` - `Already studied as FastAPI/React DG-LAB bridge with OSC service, exact/regex listeners, config and waveform services, job debounce, waveform fill, and service-boundary donor value`
- `Null-K/DG-LAB-VRChat-Sensora` - `Already studied as Python DG-LAB bridge with WebSocket/HTTP/OSC orchestration, distance/shock/touch modes, chatbox templates, per-channel limits, rate limits, safety window, and waveform monitor`
- `noideaman/ShockVRC` - `Already studied as thin PiShock/OpenShock avatar expression-menu bridge with type/intensity/duration/target/touchpoint parameter schema and credential/safety caveats`
- `DesMakesStuff/PiShockTouch` - `Already studied as PiShock contact receiver bridge with installer-backed VRChat avatar OSC JSON patching, backup flow, menu/contact parameters, and rollback/safety caveats`
- `poprox24/VRChat-Shocker-Link-CPP` - `Already studied as C++ ImGui OSCQuery physical-output hub with PiShock/OpenShock/serial backends, queue, panic hotkey, global disable, dynamic cooldown, curve presets, chatbox/notification telemetry, and strong safety architecture`

## 165. VRChat MIDI, DMX, piano, and live-performance control bridges

Primary docs:

- `../landscape/vr-projects-wave-194-vrchat-midi-dmx-piano-and-live-performance-control-bridges.md`
- `../landscape/project-families.md`

- `micksam7/VRC-MIDIDMX` - `Already studied as VRChat MIDI-as-DMX data plane with packed note messages, bank/control channel, MIDIREADY watchdog/backpressure, shader texture output, and crash-risk caveats`
- `marcus-universe/vrc_midi_transposer` - `Already studied as Rust MIDI transposer with OSC/MQTT/Home Assistant control, MIDI forwarding, note-name avatar OSC emission, and performer setup docs`
- `laserimouto/UDJ-1000` - `Already studied as Unity/Udon physical DJ controller mirror with UdonSynced controller arrays, transform/material updates, Python MIDI CC filter, and DDJ-1000 mapping caveats`
- `fltuna/USharp-midi-tuna` - `Already studied as UdonSharp MIDI piano/player with note/control callbacks, sustain, voice budget, event sync emulation, pitch conversion, and editor sample-source tool`
- `Mathieu52/OSCMidi` - `Already studied as PySide MIDI piano to VRChat OSC GUI with device selection, MIDI forwarding, note range mapping, particle buffer, reset behavior, and repo-hygiene caveats`
- `ShadowForests/OSCPianoPlayer` - `Already studied as MIDI-file to OSC piano scheduler with tempo/tick parsing, key path sends, reset flow, and old-library/world-path caveats`
- `MaverickLong/midi-osc-client` - `Already studied as minimal CLI MIDI-to-OSC piano compatibility layer with key-index, named-note, and pedal path schemas plus setup bug caveat`
- `labthe3rd/vrcMidiOverNetworkExample` - `Already studied as Udon manual MIDI sync example with ownership, serialization status, lost-send counters, byte counts, and deserialization latency telemetry`

## 166. Twitch and audience-event to VRChat OSC control surfaces

Primary docs:

- `../landscape/vr-projects-wave-195-twitch-audience-events-to-vrchat-osc-control-surfaces.md`
- `../landscape/project-families.md`

- `seluvia/crystal-relay-public` - `Already studied as mature Twitch/VRChat OSC rule engine with chat commands, channel points, bits, subs, follows, cash payments, avatar/input/chatbox actions, managed rewards, OSCQuery/cache behavior, world guard, moderation UX, and strongest product donor value`
- `AcChosen/EZTwitchOSCBot` - `Already studied as Electron/tmi.js/osc-js command deck with 12 command slots, custom OSC address/value/type, optional timed reset message, whitelist, delay, and save/load profiles`
- `Motscoud/VRChatTwitchOSCTrigger` - `Already studied as tiny Twitch IRC to VRChat OSC pulse script with hardcoded command mapping, short reset, and no-config/no-moderation caveats`
- `Killers0992/TwitchIntegration` - `Already studied as C# TwitchLib/PubSub integration with command access gates, reward/bits/sub/follow/ban/timeout event models, global/user cooldowns, random actions, and OSC action queues`
- `Killers0992/TwitchVrcAvatarOSC` - `Source-light successor/product migration pointer; retained as lineage only`
- `Maikatura/LucentOSC` - `Already studied as native C++/ImGui Twitch/Discord/VRChat command app with Twitch IRC client, VRChat command classes, movement/look/parameter/avatar/speak commands, and broad command-tree reference value`
- `exmello/RizumuBot` - `Already studied as C# Twitch IRC bot with bot/self filtering, camera command aliases, chat replies, timed OSC float pulses, and narrow camera-control donor value`

## 167. VRChat chatbox status, media, lyrics, IDE presence, and MOTD micro-composers

Primary docs:

- `../landscape/vr-projects-wave-196-vrchat-chatbox-status-media-lyrics-and-ide-presence-micro-composers.md`
- `../landscape/project-families.md`

- `Null-K/VRChatStatusTask` - `Already studied as IntelliJ IDE presence to VRChat chatbox with project/file/error/warning/uptime/line placeholders, scheduled sends, cropping, settings persistence, and privacy caveats`
- `bunboop/vrc-osc-mpris` - `Already studied as Rust/Linux MPRIS now-playing chatbox sender with TOML config, small-bubble formatting, playback progress fields, and no-player loop caveat`
- `Auzlex/vrchat-osc-windows-media` - `Already studied as Python Windows Media Controls chatbox bridge with playback-type filtering, duplicate-send gate, paused/no-media messages, and bundled-artifact caveat`
- `lexiuwu71/sillyosc` - `Already studied as WPF status composer for media, time, system stats, chatbox output, and Discord RPC with process-title/privacy caveats`
- `lexiuwu71/mpd-vrchat-osc` - `Already studied as tiny Python MPD now-playing and remaining-time chatbox sender baseline`
- `AtomikkuLabs/VRC-Lyrics` - `Already studied as Flet playback/lyrics provider pipeline with worker queues, Spotify/Windows playback, LRCLib/Spotify lyrics, chatbox/parameter OSC managers, and credential/privacy caveats`
- `kotleni/vrchat-osc-motd` - `Already studied as TypeScript plugin fan-in chatbox composer with dynamic plugins for MOTD/AFK/PC stats/Spotify, output joining, fixed port, and plugin-trust caveat`
- `KannaCS/VRCTalk` - `Already studied as Tauri/Rust/TypeScript speech recognition and translation chatbox sidecar with WebSpeech/Whisper providers, mute listener, typing indicator, translation retry, and cloud/privacy caveats`

## 168. VRChat audio-reactive OSC, AudioLink-style, soundboard, and audio-control sidecars

Primary docs:

- `../landscape/vr-projects-wave-197-vrchat-audio-reactive-osc-audiolink-soundboard-and-system-audio-control-sidecars.md`
- `../landscape/project-families.md`

- `shadorki/vrc-osc-audio-controls` - `Already studied as Go avatar-parameter to Windows media-key bridge with play/pause, next, previous, mute handlers, SendKeys backend, and debounce/parsing caveats`
- `Codel1417/VRC-OSC-Audio-Reaction` - `Already studied as C#/WPF NAudio WASAPI loopback to avatar audio direction/volume parameters with smoothing, change thresholds, VRChat precision floor, and telemetry/privacy caveats`
- `octalmage/oscsound` - `Already studied as Wails/Go OSCQuery local soundboard with soundpack import/export, one-shot/loop playback, preview, avatar parameter advertising, and local-audio routing caveat`
- `FreneticFurry/VRC-Visualizer` - `Already studied as Python sounddevice/numpy FFT visualizer mapping smoothed audio magnitude and delayed samples to avatar parameters`
- `bWoojer/WoojerOSC` - `Already studied as C# bHaptics OSC/log to Woojer/tactile audio bridge with sine providers, pan/frequency mapping, preset timers, and physical-output caveats`
- `Zeno-Fluff/OALSVRC` - `Source-light external AudioLink-style product reference for system audio capture, FFT bands, waveform/amplitude OSC, GUI routing, and restrictive/source-boundary caveats`
- `Azumarite/Dynamic-Vocoder-and-Instrument-with-Supercollider-VRChat` - `Already studied as SuperCollider VRChat OSC-controlled vocoder/synth/instrument script with effect toggles, normalized pitch mapping, and manual audio-routing caveats`

## 169. XSOverlay Discord and remote notification protocol bridges

Primary docs:

- `../landscape/vr-projects-wave-198-xsoverlay-discord-and-remote-notification-protocol-bridges.md`
- `../landscape/project-families.md`

- `GreyFoxx74/xsoverlay-proxy` - `Already studied as HTTPS authenticated remote notification proxy to XSOverlay UDP with auth key validation, rate limits, health endpoint, CLI sender, watchdog, and LAN/TLS caveats`
- `nitrog0d/XSOverlay-Discord-Notifications` - `Already studied as Powercord Discord notification hook to XSOverlay UDP payload with timeout/opacity settings, avatar icon fetch, and stale client-mod caveats`
- `Eidenz/XSOverlay-BetterDiscord` - `Already studied as BetterDiscord XSOverlay notification bridge with DM/server filters, mute/mention policy, message/attachment/role/mention formatting, base64 avatar icons, and client-internals caveats`
- `nyakowint/xsOverlayVencord` - `Already studied as Vencord XSOverlay bridge with rich message/call filters, image/attachment handling, WebSocket transport, legacy UDP fallback, and strongest Discord hook donor value`
- `Arsenic110/XSOverlay-BetterDiscord-Notifications` - `Already studied as BetterDiscord notification variant with duration/opacity settings, cooldown, DND/ignore checks, formatting helpers, and copied-client-code caveats`
- `jpdown/Discord-XSOverlay-Notifications` - `Already studied as standalone Node Discord RPC notification reader that downloads icons and dispatches XSOverlay UDP payloads`

## 170. VRChat avatar remote control, toy automation, time, and smart-light sidecars

Primary docs:

- `../landscape/vr-projects-wave-199-vrchat-avatar-remote-control-toy-automation-time-and-smart-light-sidecars.md`
- `../landscape/project-families.md`

- `Sakura0721/osc-toys` - `Already studied as FastAPI/WebUI VRChat OSC to DG-LAB Coyote bridge with moving-average smoothing, pattern selection, max-power sliders, BLE interface, safe-mode caps, and physical-output safety caveats`
- `UnusualNorm/VRChat-OSC-Toys` - `Already studied as Next.js/Socket.IO VRChat web toy menu with shared cursors, MIDI-to-avatar note channel allocation, and incomplete/auth caveats`
- `Blise518B/OscGoesPurrr` - `Source-light multi-backend VRChat OSC haptic router product reference with smoothing, OSCQuery/product claims, profile binding, diagnostics, and safety framing`
- `jangxx/VRC-Avatar-Remote-Server` - `Already studied as web remote avatar control board with Express/Socket.IO, board/avatar/group/control schema, session/API-key auth, avatar id hashing, active-avatar checks, and OSC output boundaries`
- `njm2360/vrchat-osc-automator` - `Already studied as WPF/MVVM OSC/keyboard/mouse automation sequencer with polymorphic slots, loops, breakpoints, transitions, reset-on-complete, import/export, hotkeys, and test coverage`
- `t-34400/SimpleVRChatOSCSender` - `Already studied as Tkinter generic VRChat OSC sender/receiver harness covering avatar params, input controller, chatbox, trackers, receiver rebuild, and config tabs`
- `TheUnifox/OSCTimeSender` - `Already studied as tiny C# local time to normalized Hour/Minute avatar parameter sender with fixed cadence and fixed-path caveats`
- `hrolfurgylfa/vrchat-light-sync` - `Already studied as Rust Home Assistant light-state to VRChat avatar parameter bridge with hue/brightness normalization, change-only sends, polling config, and bearer-token caveats`

## 171. VRCOSC module packs, add-on modules, and plugin-distribution boundaries

Primary docs:

- `../landscape/vr-projects-wave-200-vrcosc-module-packs-add-on-modules-and-plugin-distribution-boundaries.md`
- `../landscape/project-families.md`

- `VolcanicArts/VRCOSC-Modules` - `Already studied as official VRCOSC module suite with typed SDK usage, EventSub nodes, media/status controls, voice commands, parameter sync, PiShock, OpenVR gestures, persistent state, runtime views, and service/physical-output caveats`
- `CrookedToe/CrookedToe-s-Modules` - `Already studied as third-party VRCOSC module pack with OSCLeash wildcard/legacy path compatibility, movement reset, OpenVR chaperone manipulation, audio bands, AGC, spike detection, and movement/audio caveats`
- `Yeusepe/Yeusepes-Modules` - `Already studied as service-heavy VRCOSC module pack for Spotify, Discord, Shazam, QR/code surfaces, VRChat API helpers, broad avatar parameters, and credential/native dependency caveats`
- `FuviiPeshu/FuviiOSC` - `Already studied as SteamVR/VRChat body-device module pack with tracker haptics, paw/controller parameter mapping, trigger modes, token cancellation, avatar changer, and physical-output/tracker-role caveats`
- `WentTheFox/VRCOSC-BluetoothHeartrate` - `Already studied as Windows BLE heart-rate VRCOSC module with device selection persistence, scan/reconnect state, runtime view, avatar parameter output, and optional local WebSocket rebroadcast`
- `RichiCoder1/VrcOscLeash` - `Already studied as avatar-config-driven OSCLeash compatibility module with wildcard route handling, legacy paths, movement/look/run outputs, and safe neutral reset behavior`
- `03milo/File-Reading-Module` - `Already studied as tiny VRCOSC local-file-to-chatbox variable/event module with file polling, path privacy, and length/cadence caveats`
- `TZFC/VRCOSC-Bilibili` - `Already studied as Bilibili live-event bridge with async queues, chatbox and animation consumers, OSC parameter accumulation, decay behavior, and credential/i18n caveats`

## 172. Networked-AFrame adapters, persistence, media, and Unity-client variants

Primary docs:

- `../landscape/vr-projects-wave-201-networked-aframe-adapters-persistence-media-and-unity-client-variants.md`
- `../landscape/project-families.md`

- `networked-aframe/naf-firebase-adapter` - `Already studied as Firebase Realtime Database adapter for Networked-AFrame with presence cleanup, WebRTC peer data channels, timestamp offer tie-breaker, and guaranteed backend messages`
- `mozilla/naf-janus-adapter` - `Already studied as Janus SFU adapter for Networked-AFrame with media streams, reliable/unreliable transports, reconnect jitter, frozen updates, join tokens, and block/kick primitives`
- `networked-aframe/naf-valid-avatars` - `Already studied as Networked-AFrame room shell with avatar picker, username entry, presence store, users/chat panels, mic/screen/camera controls, and CDN/media caveats`
- `ttravaglini/networked-aframe-unity-client` - `Already studied as Unity client mirroring Networked-AFrame/EasyRTC concepts with Socket.IO auth/join, networked entity ownership, schema parsing, and interpolation caveats`
- `chenzlabs/networked-aframe-synced-video-example` - `Already studied as owner-gated synced video micro-component with paused/currentTime state, time slop, singleton network id, and buffering/owner-transfer caveats`
- `martintribo/naf-persist` - `Already studied as PouchDB-backed A-Frame/NAF entity persistence system with DOM/NAF id options, local-vs-remote preference, serialization, and conflict caveats`
- `martintribo/naf-entity-saver` - `Already studied as leave-time entity preservation hack that strips networked-remote, reattaches local networked state, and exposes NAF ownership fragility`
- `AudioGroupCologne/networked-resonance-audio` - `Already studied as NAF adapter media-stream to Three/Resonance positional audio bridge with owner stream lookup, panner binding, and browser media caveats`

## 173. Lightweight XR editor, tour-builder, live-coding, and creator microtools

Primary docs:

- `../landscape/vr-projects-wave-202-lightweight-xr-editor-tour-builder-live-coding-and-creator-microtools.md`
- `../landscape/project-families.md`

- `Humangle/VRTourEditor` - `Already studied as browser 360 tour editor with .hvrj manifest, link/button placement, desktop and VR ray picking, localStorage autosave, save/export zip, and generated WebXR runtime player`
- `caseyyee/aframe-vreditor-component` - `Already studied as A-Frame in-headset edit component with grip/collision selection, reparent-on-grab, clone-on-two-hand grab, axis scaling, and old API/no-undo caveats`
- `wakufactory/GNode` - `Already studied as visual node graph for geometry/A-Frame entities with sockets, joints, serialized graph positions, node edit bridge, A-Frame output, and validation caveats`
- `flushpot1125/WebXR_VRController_Editor_template` - `Already studied as Babylon.js Editor WebXR controller template with generated script lifecycle, fromScene links, motion-controller component handling, and hardcoded input-index caveats`
- `dkaraush/vrcode` - `Already studied as Three/WebXR text/code workspace with movable VR displays, ray-drag state, VR keyboard mesh, textarea object, and incomplete IDE/persistence caveats`
- `umiyuki/UnityVRAnimationEditor` - `Already studied as Unity in-VR animation editor with generated grabbable nodes, VRTK interaction, Undo-backed curve recording, Animation Window reflection, and modernization caveats`
- `evanw/webgl-vr-editor` - `Already studied as historical Cardboard/WebGL voxel editor with edit/play modes, orientation-relative cursor, undo tracker, file save/load, and obsolete headset/toolchain caveats`
- `Reava/VRC-Editor-Toolbox` - `Already studied as Unity/VRChat creator microtool package with circle placement, teleport-to-transform, sequential naming, light-volume toggles, Bakery mass editing, and Undo/scope caveats`

## 174. ContactGlove, Haritora, and vendor tracker bridge sidecars

Primary docs:

- `../landscape/vr-projects-wave-203-contactglove-haritora-and-vendor-tracker-bridge-sidecars.md`
- `../landscape/project-families.md`

- `hyblocker/freescuba` - `Already studied as ContactGlove OpenVR driver plus overlay with driver/overlay split, serial protocol, named-pipe IPC, skeleton/input components, pose/input threads, input profiles, and high-risk driver caveats`
- `Diver-X/ContactGloveOSC` - `Already studied as official Unity/VRChat ContactGlove OSC package with automatic avatar setup, full/lite parameters, expression menus, hand-sign copy tools, VPM package shape, and controller conflict caveats`
- `1000100Den/Glove2Kb` - `Already studied as VMC/OSC hand-pose to keyboard/pointer utility with bone rotation reception, origin/deadzone correction, grip gating, pointer movement, and OS-input safety caveats`
- `sim1222/haritorax-slimevr-bridge` - `Already studied as Rust Haritora BLE to SlimeVR UDP bridge with characteristic UUIDs, IMU decode, battery/button notifications, handshake, rotation/gravity packets, and reconnect/role caveats`
- `JovannMC/haritorax-interpreter` - `Already studied as TypeScript Haritora COM/Bluetooth/Linux-Bluetooth interpreter library with EventEmitter API, tracker maps, IMU/battery/button/mag/info events, and maturity caveats`
- `JovannMC/haritora-gx-poc` - `Already studied as thin Python Haritora GX serial-data probe with line classification, IMU decode, battery/button logging, and manual echo/prototype caveats`
- `cytsai1008/HaritoraToSlime` - `Already studied as Python OSC Haritora to SlimeVR bridge with config bootstrap, broadcast handshake, add-IMU packets, rotation/accel encoding, and parser/acceleration caveats`
- `Fuwaaaaaa/osc_haritorax2_camera_tracking` - `Already studied as mature camera/IMU tracking middleware with receiver abstraction, camera subprocess/shared memory, fusion engine, event bus, preflight checks, REST/dashboard/OBS/VMC outputs, persistence, and tests`

## 175. WebXR runtime/dev scaffolding, polyfills, emulators, and input profile loaders

Primary docs:

- `../landscape/vr-projects-wave-204-webxr-runtime-dev-scaffolding-polyfills-emulators-and-input-profile-loaders.md`
- `../landscape/project-families.md`

- `immersive-web/webxr-polyfill` - `Already studied as guarded navigator.xr fallback with API-class injection, WebGL compatibility patching, abstract XRDevice boundary, and stale WebVR/Cardboard caveats`
- `MozillaReality/WebXR-emulator-extension` - `Already studied as browser extension emulator with content-script/page custom-event bridge, devtools device panel, pose/button/device messages, and old-spec/input-limit caveats`
- `De-Panther/webxr-input-profiles-loader` - `Already studied as Unity WebXR input-profile loader with profile-list/profile JSON cache, handedness layout routing, glTF visual-response nodes, and CDN/package caveats`
- `michelesandroni/xrview` - `Already studied as standalone Tauri WebXR emulator shell with trust-separated toolbar/browser webviews, all-frame IWER injection, URL gating, and capability-isolation caveats`
- `holokit/holokit-webxr` - `Already studied as viewer-specific WebXR device adapter/polyfill with HoloKit immersive AR sessions, multiview projection/viewport logic, and device-specific caveats`
- `realitydeslab/holoweb-webxr-polyfills` - `Fork / variant only as HoloKit-style WebXR polyfill family member with broad module type surface and overlapping donor value`
- `mvilledieu/magicleap-helio-webxr-polyfill` - `Already studied as Magic Leap Helio WebXR API-drift micro-shim wrapping support/session/frame/input/reference-space methods with hardcoded stale-browser caveats`

## 176. A-Frame UI, locomotion, environment, and physics micro-components

Primary docs:

- `../landscape/vr-projects-wave-205-aframe-ui-locomotion-environment-and-physics-micro-components.md`
- `../landscape/project-families.md`

- `c-frame/aframe-cursor-teleport` - `Already studied as cursor-camera teleport fallback with collision/ignore selectors, ground-plane fallback, landing angle checks, transition easing, and desktop/mobile value`
- `supermedium/aframe-super-keyboard` - `Already studied as texture-atlas keyboard with raycaster UV key selection, filters, max length, value events, hand/raycaster integration, and old dependency caveats`
- `supermedium/aframe-environment-component` - `Already studied as declarative environment/preset generator for sky, fog, lights, ground, terrain, dressing, grids, and fast scene-context setup`
- `n5ro/aframe-physics-system` - `Already studied as A-Frame physics system with local/worker/network/ammo drivers, CANNON body sync, fixed timestep, worker snapshots, and maintenance/performance caveats`
- `supermedium/aframe-react` - `Already studied as React-to-A-Frame entity bridge with attribute diff/remove, event attach/detach, primitive mapping, and old React API caveats`
- `topstar-ai/aframe-blink` - `Already studied as teleport component with parabolic target, rotation output, thumbstick support, hit/miss colors, teleported event payload, and WIP caveats`
- `EX3D/aframe-daylight-system` - `Already studied as tiny time/latitude/declination-driven sky, fog, and sun-position component`
- `msfeldstein/aframe-environment-map-component` - `Already studied as environment-only CubeCamera/PMREM capture helper with target envMap assignment and visibility/API caveats`

## 177. Godot XR addon periphery: hands, tracker bridges, recording, and reference plugin baselines

Primary docs:

- `../landscape/vr-projects-wave-206-godot-xr-addons-hand-tracker-recording-and-reference-plugin-periphery.md`
- `../landscape/project-families.md`

- `patrykkalinowski/godot-xr-kit` - `Already studied as Godot XR addon kit with template hand-pose recognition, quaternion scoring, pose-change signals, physics movement, smoothing, and cinematic-view references`
- `RevolNoom/godot_xr_handtracking` - `Already studied as Godot hand-pose catalogue and pose-gated pickup toolkit with hand snap, pick-area modes, stabilization, and configuration warnings`
- `Malcolmnixon/GodotXRVmcTracker` - `Already studied as OSC/VMC body and face tracker bridge into Godot XRServer with OSC parser, position modes, joint/blend mapping, root transform, and confidence flags`
- `Malcolmnixon/GodotXRAxisStudioTracker` - `Already studied as Axis Studio vendor body tracker bridge variant using the Godot XRServer source-to-tracker boundary`
- `Malcolmnixon/GodotXRRokokoTracker` - `Already studied as Rokoko body/face/finger tracker bridge variant with optional modality handling and vendor packet caveats`
- `Malcolmnixon/GodotXROpenXRTracker` - `Thin tracker demo/reference for Godot OpenXR body/hand tracker setup, world-scale controls, and demo-level caveats`
- `Malcolmnixon/GodotXRAnimationRecorder` - `Already studied as Godot XR tracker and animation recorder with body/face/hand tracker sampling, skeleton/blendshape tracks, root motion, timestamps, and optimization`
- `GodotVR/godot_xr_reference` - `Already studied as native Godot XRInterface reference plugin with property binding, head tracker registration, per-eye transforms/projections, and native build caveats`
- `BastiaanOlij/godot-xr-tools2` - `Already studied as WIP modular Godot XR toolkit v2 with hand attachment functions, teleport gating, movement-provider disable, fade, slope/collision checks, and API-stability caveats`

## 178. React/Three XR runtime, spatial UI, and interaction lab surfaces

Primary docs:

- `../landscape/vr-projects-wave-207-react-three-xr-runtime-spatial-ui-and-interaction-lab-surfaces.md`
- `../landscape/project-families.md`

- `pmndrs/xr` - `Already deepened as React/Three XR store runtime substrate with session/input/layer/frame state, WebXRManager binding, emulator injection, teleport utilities, pointer integration, and version-pin caveats`
- `pmndrs/uikit` - `Already studied as spatial UI substrate with Yoga/flex layout, pointer ordering/clipping, scroll handling, 3D text/selection, hidden DOM input bridge, and kit/component exports`
- `kewanglab/webxr-playground` - `Already studied as WebXR interaction lab shell with lab registry, tuning presets, XR root/origin, TagAlong HUD, selection/manipulation labs, session logger, and agent-friendly architecture`
- `WawasCode/DefaultReactXR` - `Already studied as thin React Three XR + Vite + UIKit starter with store options, pointer config, support-aware enter button, and starter-only caveats`
- `randykeller11/xrTeleport` - `Already studied as basic React Three XR teleport and snap-rotation micro-reference with raycast target, normal-aligned indicator, player pose update, and old API caveats`
- `alxxtexxr/react-three-xr-measurement` - `Already studied as AR hit-test measurement microtool with reticle, select point capture, line drawing, midpoint distance label, and no-persistence caveat`
- `BOLTEVM/BoltXR` - `Already studied as product-specific spatial UI/hand-interaction reference with WebXR scene panels, IWER emulation flag, MediaPipe pinch/tap/drag/scale overlay pipeline, and crypto/product caveats`
- `aazutaku/glb-ar-viewer` - `Already studied as Next.js GLB AR viewer with upload/key routing, WebXR/dom-overlay store, iOS launcher fallback, animation toggle, transform controls, model streaming, and validation caveats`

## 179. Overlay media micro-surfaces: notes, telemetry shells, browser bootstraps, and direct video overlays

Primary docs:

- `../landscape/vr-projects-wave-208-overlay-media-micro-surfaces-notes-browser-and-direct-video-overlays.md`
- `../landscape/project-families.md`

- `Yukiiro-Nite/notebook-vr-overlay` - `Deepened in Wave 208 as minimal OpenVR note/image overlay bootstrap with overlay creation, mouse input scale, tracked-device transform, event loop, hardcoded-path caveats, and incomplete drawing/persistence`
- `Daniel-Webster/WT-OpenVR-Overlay` - `Deepened in Wave 208 as Unity/OVRLay telemetry overlay shell with render textures, dashboard thumbnails, tracked-device placement, OpenVR mouse input, local JSON/texture polling, and War Thunder-specific coupling`
- `Wulkop/VolumeVR` - `Deepened in Wave 208 as CEF/windowless browser bootstrap reference with remote-debug/no-sandbox caveats and no confirmed overlay texture submission in inspected source`
- `iigomaru/MPVR` - `Deepened in Wave 208 as direct libmpv/OpenGL/OpenVR texture-loop prototype with hidden GL window, mpv render context, OpenVR overlay texture submission, controller-relative placement, bundled-binary and rough-loop caveats`

## 180. XR glasses WebHID protocol workbenches and head-tracked desktop helpers

Primary docs:

- `../landscape/vr-projects-wave-209-xr-glasses-webhid-protocol-and-head-tracked-desktop-helpers.md`
- `../landscape/project-families.md`

- `jakedowns/xreal-webxr` - `Deepened in Wave 209 as browser WebHID protocol workbench with device filtering, connect/disconnect state, Air/Light routing, packet/message tables, IMU/status parsing, firmware-command scaffolding, and read/write safety caveats`
- `alexwilson1/nreal_linux_test` - `Deepened in Wave 209 as Linux/X11 head-tracked desktop slicing POC with external driver stdout pose parsing, GStreamer capture, yaw calibration, viewport slicing, root/X11/yaw-only caveats`
- `edwatt/real_utilities` - `Deepened in Wave 209 as native hidapi/zlib Nreal protocol utility with separate control/IMU HID interfaces, command metadata, packet build/parse helpers, CRC, calibration segment reads, and low-level command caveats`
- `Mailbot/Nreal_Air_Desktop_tool` - `Deepened in Wave 209 as README-level product reference for AR desktop windows, saved layout, curvature, drift correction, focus recovery, and no-current-source donor limitation`

## 181. MediaPipe/avatar tracking sidecars, VRM diagnostics, named-pipe body bridges, and AI FBT pipelines

Primary docs:

- `../landscape/vr-projects-wave-210-mediapipe-avatar-tracking-sidecars-vrm-and-full-body-bridges.md`
- `../landscape/project-families.md`

- `hotaru86/MediapipeFaceTracking_VRC` - `Deepened in Wave 210 as MediaPipe Face Landmarker to VRCFT OSC expression sidecar with ARKit/VRCFT mapping, per-parameter sensitivity/min/max, JSON persistence, boolean decomposition, and single-process caveats`
- `how-people-lived/mediapipe-vrm-tracking` - `Deepened in Wave 210 as browser MediaPipe/VRM avatar diagnostics workbench with VRM drag/drop, Face/Hand/Pose landmarkers, blendshape mapping UI, JSON export, and CDN/single-file caveats`
- `Metastazius/VRBodyTrack` - `Deepened in Wave 210 as Python MediaPipe to Unity named-pipe body landmark bridge with length-prefixed payloads, joint angle calculation, hardcoded camera/path caveats, and checked-in Unity artifact hygiene warnings`
- `MasonSakai/VR-AI-Full-Body-Tracking` - `Deepened in Wave 210 as AI full-body tracking pipeline with browser camera pages, MoveNet inference, confidence filtering, multi-camera ray triangulation, dampened virtual tracker output, and legacy InputEmulator caveats`

## 182. VR teleoperation control frontends, robot bridges, safety gates, and feedback HUDs

Primary docs:

- `../landscape/vr-projects-wave-211-vr-teleoperation-control-frontends-robot-bridges-and-safety-huds.md`
- `../landscape/project-families.md`

- `h2r/GHOST` - `Deepened in Wave 211 as Unity/Quest ROS teleoperation frontend with explicit mode manager, controller command mapping, robot joint publisher, point-cloud/depth visualization hooks, and ros_reality/robot-specific caveats`
- `nakama-lab/VR_Teleop_Interface` - `Deepened in Wave 211 as multi-branch Unity/ROS2/ZED/Franka teleop architecture and documentation reference with topic contracts, command/status/error sequences, haptic feedback notes, and branch-split caveats`
- `kscalelabs/kbot_vr_teleop` - `Deepened in Wave 211 as WebXR headset frontend plus Python IK/UDP command sidecar with hand/controller tracking payloads, pause gates, throttling, kinematics feedback, convergence checks, and robot-schema caveats`
- `open-thought/cambot` - `Deepened in Wave 211 as WebXR stereo camera teleop stack with HUD telemetry, WebSocket/WebRTC transport, RTT/backpressure, calibration, smoothing, workspace bounds, watchdog, pause/home safety, and hardware-specific thresholds`

## 183. Shared-room WebXR/A-Frame presence, media, and peer-adapter microprototypes

Primary docs:

- `../landscape/vr-projects-wave-212-shared-room-webxr-aframe-presence-webrtc-and-peer-adapter-microprototypes.md`
- `../landscape/project-families.md`

- `jure/wooglies` - `Studied in Wave 212 as browser WebXR shared-room prototype with Socket.IO room state, SnapshotInterpolation pose snapshots, simple-peer media streams, positional audio/analyser avatar reactivity, Twilio ICE, and experimental/old API caveats`
- `danbuckland/aframe-socket-io` - `Studied in Wave 212 as A-Frame Socket.IO/WebRTC room prototype with server signaling, game/pose system, WebRTC media system, video-texture avatars, and old full-mesh/VR-limited caveats`
- `Srushtika/realtime-multiplayer-webvr-aframe` - `Studied in Wave 212 as tiny Deepstream/A-Frame presence-record avatar sync sample with 100ms camera updates, presence subscribe, generated avatars, and obsolete hub/CDN caveats`
- `RangerMauve/aframe-dat-peers-networking` - `Studied in Wave 212 as Beaker/datPeers A-Frame networking adapter with room/user messages, remote entity templates, changed-position sends, chat events, and obsolete datPeers caveats`

## 184. MRTK spatial UI, graphics, robotics, and gaze extension nodes

Primary docs:

- `../landscape/vr-projects-wave-213-mrtk-spatial-ui-graphics-robotics-and-gaze-extension-nodes.md`
- `../landscape/project-families.md`

- `MixedRealityToolkit/MixedRealityToolkit-Unity` - `Deepened in Wave 213 as MRTK3 package/contract baseline with XRI/OpenXR architecture, data binding/theming/list virtualization, StatefulInteractable/PressableButton state contracts, solver handlers, and accessibility subsystem caveats`
- `microsoft/MixedReality-GraphicsTools-Unity` - `Studied in Wave 213 as MR visual-fidelity package with proximity lights, material animators, mesh instancing, text inversion utility, magnifier render features, and shader/package caveats`
- `ms-iot/ros_msft_mrtk` - `Studied in Wave 213 as archived ROS2/MRTK HoloLens extension with ROS node singleton, lidar provider/renderer, QR spatial pinning service, hand-menu calibration, and old platform caveats`
- `The-COGAIN-Association/EyeMRTK` - `Studied in Wave 213 as legacy gaze interaction toolkit with normalized ray sources, smoothing/saccade detection, InteractionRay events, dwell/confirmation states, Tobii/SMI/Pupil support, and Unity 2017/SDK caveats`

## 185. VRChat/Udon menu package surfaces, world admin, and creator prefabs

Primary docs:

- `../landscape/vr-projects-wave-214-vrchat-udon-menu-package-surfaces-world-admin-and-creator-prefabs.md`
- `../landscape/project-families.md`

- `Varneon/UdonEssentials` - `Deepened in Wave 214 as deprecated Udon prefab collection with event dispatcher, in-world console, playerlist/groups/music/settings utilities, runtime logging, and VUdon migration caveat`
- `Varneon/VUdon` - `Deepened in Wave 214 as VUdon package-ecosystem index with Quick Menu, Menus, Logger, Playerlist, Event Dispatcher, Udonity, Common, and modular package-status framing`
- `SylanTroh/GMMenu` - `Deepened in Wave 214 as VPM VRChat role/admin menu with VR/desktop activation, permissions, synced pings, teleport/undo/summon, watch camera, HUD modules, and optional audio-manager boundary`
- `kurotori4423/KurotoriUdonMenu` - `Studied in Wave 214 as local extensible Udon menu with trigger/M-key activation, progress animation, tab generation, player teleporter, voice-range options, and language/older Udon caveats`

## 186. Immersive media/audio substrates, spatial renderers, and audio-reactive shader buses

Primary docs:

- `../landscape/vr-projects-wave-215-immersive-media-audio-substrates-libvlc-spatial-renderers-and-audiolink.md`
- `../landscape/project-families.md`

- `videolan/vlc-unity` - `Deepened in Wave 215 as LibVLCSharp/LibVLC Unity media substrate with central VLCMediaPlayer, mesh/UGUI texture helpers, Unity AudioSource callback bridge, 360/HDR/stream support, and native/licensing/platform caveats`
- `videolan/libspatialaudio` - `Deepened in Wave 215 as spatial audio renderer substrate with unified Renderer for object/HOA/direct/binaural streams, HRTF/head orientation, gain interpolation, decorrelation, and DSP/licensing caveats`
- `VoidXH/Cavern` - `Deepened in Wave 215 as C# immersive audio renderer with Listener/Source model, Unity AudioListener3D/AudioSource3D wrappers, filters/remapping/virtualization, and nonstandard license/performance caveats`
- `llealloo/audiolink` - `Deepened in Wave 215 as VRChat/Unity audio-reactive data bus with GetOutputData sampling, CustomRenderTexture processing, global _AudioTexture shader API, controller sync, and shader/readback caveats`

## 187. OpenXR conformance, specification, validation layers, and runner toolchain

Primary docs:

- `../landscape/vr-projects-wave-216-openxr-conformance-spec-validation-and-runner-toolchain.md`
- `../landscape/project-families.md`

- `KhronosGroup/OpenXR-CTS` - `Studied in Wave 216 as official OpenXR conformance harness with CLI launcher, Catch2 test library, graphics plugins, conformance API layer, generated dispatch, runtime/layer/extension reporting, and process/conformance caveats`
- `rpavlik/openxr-cts-runner` - `Studied in Wave 216 as experimental Rust/egui GUI runner around conformance_cli with graphics API arguments, noninteractive filtering, output polling, cancel/done state, and text-output caveats`
- `KhronosGroup/OpenXR-Docs` - `Studied in Wave 216 as specification/registry/tooling source with Asciidoctor spec sources, registry XML, generated headers, extension helper scripts, validation checks, and extension-process governance`
- `KhronosGroup/OpenXR-SDK-Source` - `Deepened in Wave 216 for API dump, core validation, loader tests, list-json runtime inventory, generated dispatch, debug-utils output, and API-layer activation caveats`

## 188. StardustXR client infrastructure, panel protocols, and spatial desktop microclients

Primary docs:

- `../landscape/vr-projects-wave-217-stardustxr-client-infrastructure-panel-protocols-and-spatial-desktop-microclients.md`
- `../landscape/project-families.md`

- `StardustXR/core` - `Studied in Wave 217 as StardustXR wire/protocol/fusion/gluon workspace with FlatBuffer messaging, KDL protocols, typed client wrappers, scenegraph nodes, spatial transforms, resources, and async event loops`
- `StardustXR/molecules` - `Studied in Wave 217 as high-level Fusion interaction library with grabbables, buttons, hover/touch planes, zones, keyboard/mouse bridges, input queues, drop handlers, reparenting, and visual debug`
- `StardustXR/asteroids` - `Studied in Wave 217 as declarative StardustXR UI library with state reification, element diffing, resource registry, task callbacks, and spatial panel/button elements`
- `StardustXR/panel-item` - `Studied in Wave 217 as panel item protocol and Asteroids integration with toplevel/child/cursor/geometry state, surface update channels, panel shell events, and generated-protocol caveats`
- `StardustXR/wayland-service` - `Studied in Wave 217 as Wayland-to-Stardust surface bridge with socket service, Vulkan context, binder device, xdg/core/dmabuf protocols, panel item provider, and Linux-specific caveats`
- `StardustXR/gravity` - `Studied in Wave 217 as spatial launcher micro-utility that creates a transform, reads connection environment, generates startup token, and execs target commands`

## 189. VRChat/Udon runtime diagnostics, data structures, and predictive sync utilities

Primary docs:

- `../landscape/vr-projects-wave-218-udon-runtime-diagnostics-data-structures-and-predictive-sync-utilities.md`
- `../landscape/project-families.md`

- `Guribo/UdonUtils` - `Deepened in Wave 218 as TLP Udon runtime substrate with TlpBaseBehaviour lifecycle validation, logging, dirty serialization/retry, SyncPaused, network time, accurate sync hooks, events, physics helpers, and tests`
- `Guribo/UdonProfiling` - `Studied in Wave 218 as ScreenSpace Udon performance overlay with MVC-style stat model/controller, Stopwatch frame calculations, global profiler handler, threshold warnings, and debug-frame log hooks`
- `Guribo/UdonLeaderBoard` - `Recorded in Wave 218 as package/product reference only because current checkout exposes README/package placeholder rather than source-rich leaderboard implementation`
- `Guribo/UdonAVLTree` - `Studied in Wave 218 as U# AVL tree using DataList node encoding, node pool, parent/payload/child/wire fields, comparer boundary, balance/rotation helpers, and testability caveats`
- `Guribo/UdonVehicleSync` - `Studied in Wave 218 as predictive non-kinematic rigidbody sync package with network-time send stamps, dynamic send-rate thresholds, position/rotation/velocity prediction, teleport/respawn flags, debug trails, and sync tweaker UI`

## 190. VRChat external content ingress, image/GLB/texture, and avatar data surfaces

Primary docs:

- `../landscape/vr-projects-wave-219-vrchat-external-content-ingress-image-glb-texture-and-avatar-data-surfaces.md`
- `../landscape/project-families.md`

- `vrchat-community/examples-image-loading` - `Studied in Wave 219 as official remote image/caption slideshow sample with persistent VRCImageDownloader, VRCStringDownloader captions, cached Texture2D array, server-time slide selection, and GitHub Pages hosting`
- `vr-voyage/vrchat-glb-loader` - `Studied in Wave 219 as runtime GLB/VRM loader with VRCStringDownloader, staged DataDictionary parser, meshes/materials/textures/scenes, DDS/preconverted texture handling, material extension plugins, and unsupported-feature caveats`
- `DrBlackRat/VRC-Picture-Loader` - `Studied in Wave 219 as productized VPM image ingress package with manager/lite downloader, URL input, persistence, tablet mode, texture settings, loading/error textures, and authority/persistence caveats`
- `Narazaka/SyncTexture` - `Studied in Wave 219 as chunked Texture2D synchronization package with color encoders, GPU readback/GetPixels source capture, BulkCount progress, partial apply, callback events, manager sequencing, resend, and late-join support`
- `Miner28/AvatarImageReader` - `Deepened in Wave 219 as deprecated avatar-thumbnail text/data carrier with editor encoder, runtime pedestal texture readback, UTF-8/UTF-16 frame-sliced decoding, avatar chaining, and platform capacity caveats`

## 191. World-locking, spatial coordinate stabilization, and anchor sharing

Primary docs:

- `../landscape/vr-projects-wave-220-world-locking-spatial-coordinate-stabilization-and-anchor-sharing.md`
- `../landscape/project-families.md`

- `microsoft/MixedReality-WorldLockingTools-Unity` - `Studied in Wave 220 as canonical Unity world-locking architecture with spongy/locked/frozen frames, WorldLockingManager service boundary, anchor graph, alignment manager, SpacePins, diagnostics, auto refreeze/load/save, and persistence caveats`
- `microsoft/MixedReality-WorldLockingTools-Samples` - `Studied in Wave 220 as QR SpacePins and Azure Spatial Anchors product UX with physical marker/proxy matching, binding oracle, publish/load/search/purge/reset controls, and ASA credential/location caveats`
- `microsoft/WorldLockingTools-Unreal` - `Studied in Wave 220 as Unreal port of world-locking concepts through ARPins, tracking-to-world transforms, pawn hierarchy adjustment, FrozenWorld plugin calls, and HoloLens/OpenXR caveats`
- `brunoshine/StereoKit.Samples.AzureSpatialAnchors` - `Studied in Wave 220 as minimal StereoKit ASA session UI with CloudSpatialAnchorSession, nearby search, save/delete controls, PlatformLocationProvider, feedback state, and service/permission caveats`

## 192. Vendor OpenXR extension stacks, feature wrappers, and sample matrices

Primary docs:

- `../landscape/vr-projects-wave-221-vendor-openxr-extension-stacks-feature-wrappers-and-sample-matrices.md`
- `../landscape/project-families.md`

- `microsoft/OpenXR-MixedReality` - `Studied in Wave 221 as Microsoft C++ OpenXR sample matrix with instance context, feature-to-extension mapping, QR scene-marker filtering, hand/eye/anchor/secondary-view samples, and WMR/HoloLens caveats`
- `microsoft/Microsoft-OpenXR-Unreal` - `Studied in Wave 221 as Unreal Microsoft OpenXR plugin with modular feature registration, Blueprint availability wrappers, QR tracking watcher, spatial graph bridge, PV camera, speech, remoting, and engine-version caveats`
- `meta-quest/Meta-OpenXR-SDK` - `Studied in Wave 221 as Quest native OpenXR SDK/sample matrix with shared XrApp lifecycle, extension helper classes, virtual keyboard wrapper, scene/anchor/depth/passthrough sample coverage, and license/experimental caveats`
- `mikeskydev/unity-openxr-extensions` - `Studied in Wave 221 as Unity OpenXRFeature wrapper set with generic FeatureBase, function pointer hooks, FB passthrough, META boundary visibility, body tracking, Android manifest build hooks, and unofficial-wrapper caveats`

## 193. Cockpit hand-clicking, calibration, observer, and passthrough microhelpers

Primary docs:

- `../landscape/vr-projects-wave-222-cockpit-hand-clicking-calibration-observer-and-passthrough-microhelpers.md`
- `../landscape/project-families.md`

- `fredemmott/HTCC` - `Studied in Wave 222 as OpenXR API-layer cockpit helper that privately consumes hand tracking/PointCTRL, hides raw hand support from apps, maps pinch/scroll/aim to virtual controller actions, and uses per-exe configuration`
- `galister/motoc` - `Studied in Wave 222 as Monado/WiVRn tracking-origin calibration CLI with device/origin monitor, sampled SVD calibration, continuous offset smoothing, recentering, saved JSON profiles, and anomaly handling`
- `dag10/HoloViveObserver` - `Studied in Wave 222 as historical HoloLens/Vive observer alignment prototype with networked alignment manager, floating controller target, Vive trigger click calibration, role-specific players, and legacy Unity/cloud caveats`
- `yshui/index_camera_passthrough` - `Studied in Wave 222 as Linux Valve Index camera passthrough overlay with V4L capture, Vulkan YUYV/correction/projection pipeline, OpenVR/OpenXR backend trait, HMD/sticky/absolute placement, and projection caveats`

## 194. XR creator/CAD/UI workbenches and legacy Unity interaction donors

Primary docs:

- `../landscape/vr-projects-wave-223-xr-creator-cad-ui-workbenches-and-legacy-unity-interaction-donors.md`
- `../landscape/project-families.md`

- `kwahoo2/freecad-xr-workbench` - `Studied in Wave 223 as Python OpenXR FreeCAD addon with addon-over-fork architecture, pyopenxr/OpenGL render loop, controller rays, Coin3D menu widgets, Free/Arch movement, CAD selection/editing, Qt widget projection, and third-person camera support`
- `createthis/createthis_vr_ui` - `Studied in Wave 223 as legacy Unity VR UI toolkit with grabbable panels, global panel manager, keyboard, file open/save dialogs, kinetic scroller, touchpad radial menu, selectable/highlight materials, and factory-generated UI`
- `createthis/mesh_maker_vr` - `Studied in Wave 223 as VR mesh authoring tool with explicit edit modes, vertex/triangle controllers, sticky selection, drag broadcasting, snap increments, fill/normal/delete operations, HUD/pointer color feedback, and legacy dependency caveats`
- `createthis/unity_vr_ik_mecanim` - `Studied in Wave 223 as small embodied feedback demo with Mecanim hand IK from controllers, hip-tracker avatar placement, headset rotation, mirror render texture, translucent controller model materials, and demo/Final-IK caveats`

## 195. XR research data lifecycle templates, validation, and analysis pipelines

Primary docs:

- `../landscape/vr-projects-wave-224-xr-research-data-lifecycle-templates-validation-and-analysis-pipelines.md`
- `../landscape/project-families.md`

- `ResXR/resxr-unity-research-template` - `Studied in Wave 224 as a Quest/Unity research template with persistent base scene, session/task/trial flow, room calibration, event tables, custom CSV data classes, continuous tracking streams, face-expression capture, live callbacks, and metadata output`
- `ResXR/resxr-python-pipeline` - `Studied in Wave 224 as a downstream XR data pipeline with YAML config, session discovery, stream splitting, BIDS motion/events/channels output, validation registry, quality masking, derivatives, and reports`
- `ixperience-lab/VRSTK` - `Studied in Wave 224 as a legacy scientific VR toolkit with phase/condition control, tracking, biosignal OSC/serial ingress, questionnaires, replay, JSON/CSV export, and R/Python analysis templates`
- `eisclimber/ExPresS-XR` - `Deepened in Wave 224 from existing coverage as an experiment authoring/data-binding reference with editor setup dialogs, arbitrary component-member export bindings, local/HTTP CSV export, and periodic or input-triggered collection`

## 196. WebRTC/WebXR remote surfaces, camera streams, and spatial panels

Primary docs:

- `../landscape/vr-projects-wave-225-webrtc-webxr-remote-surfaces-camera-streams-and-spatial-panels.md`
- `../landscape/project-families.md`

- `binzume/webrtc-rdp` - `Studied in Wave 225 as WebRTC remote desktop for WebXR with Ayame signaling, PIN pairing, persisted devices, media tracks, service requests, control/data channels, file/control services, and A-Frame controller input`
- `DiscreteTom/WebCaster` - `Studied in Wave 225 as a minimal peerjs/Three WebXR screen caster with video-texture panels, stream audio, controller ray selection, grab/drop, push/pull, and scale interactions`
- `hideki5123/stereo-webrtc-viewer` - `Studied in Wave 225 as a Sora WebRTC stereo viewer with separate left/right camera streams, WebGL2 WebXR layer setup, and per-eye video texture routing`
- `rclarke87/WebXR-IPCam` - `Studied in Wave 225 as a tiny WHEP/IP camera viewer with A-Frame video panels, receive-only PeerConnections, SDP POST flow, camera labels, and mute controls`
- `JYJang476/VRMonitor` - `Studied in Wave 225 as a local QR/WebSocket/WebRTC monitor prototype with browser screen capture, role-based signaling relay, and Babylon video texture output`

## 197. Browser media, depth-video projection, and gaze-viewer surfaces

Primary docs:

- `../landscape/vr-projects-wave-226-browser-media-depth-video-projection-and-gaze-viewer-surfaces.md`
- `../landscape/project-families.md`

- `amariichi/VideoDepthViewer3D` - `Studied in Wave 226 as a FastAPI/PyAV/PyTorch plus Three/WebXR depth-video viewer with inference workers, priority queues, binary depth streams, frontend depth lead tuning, relief/pinhole projection, RawXR rendering, and cache/runtime caveats`
- `mysterion/aframe-vr-player` - `Studied in Wave 226 as an A-Frame/WebXR video player with local file support, projection presets, stereo eye layers, persistent settings, subtitles, timeline, camera adjustment, and recenter controls`
- `mrgeralds/WebXR-TV-Demo` - `Studied in Wave 226 as a WebXR TV shell with dash.js playback, service-list channel metadata, info bar, paged channel menu, volume controls, secondary screen, and controller-only repositioning`
- `orgixmh/GazeDesk` - `Studied in Wave 226 as a README-level Cardboard/MJPEG desktop viewer product reference with head cursor, gaze dwell menu, SBS/Flat tuning, pan/zoom/IPD controls, wake lock, and local persistence`
- `ZhiqiaoGong/3D-Streaming-Demo` - `Studied in Wave 226 as a minimal WebRTC SBS video streaming demo with publisher captureStream, receiver texture split, left/right layers, debug/XR layouts, safe scaling, and reconnect behavior`

## 198. OpenGloves DIY haptics adapters, named pipes, and firmware variants

Primary docs:

- `../landscape/vr-projects-wave-227-opengloves-diy-haptics-adapters-named-pipe-and-firmware-variants.md`
- `../landscape/project-families.md`

- `SparkleTech-VR/OpenPulseConverter` - `Studied in Wave 227 as a WIP BiFrost Pulse HID to OpenGloves converter with VID/PID discovery, pull/splay bit extraction, calibration prompts, normalized flexion/splay output, named-pipe writes, OpenGloves force-feedback reads, and haptic conversion caveats`
- `danwillm/opengloves-named-pipe-example` - `Studied in Wave 227 as a minimal OpenGloves v2 Windows named-pipe contract example with flexion, splay, joystick, button, menu, calibrate, and trigger-value fields`
- `DasKatzchen/GloveBridge` - `Studied in Wave 227 as a Python BLE-to-OpenGloves pipe bridge concept with target left/right devices, GATT read/write loops, v1 input/force-feedback pipe paths, rediscovery, and unfinished format/error caveats`
- `Stargazer6481/Compact-Gloves` - `Studied in Wave 227 as a compact DIY SteamVR/OpenGloves glove reference with BOM, hardware docs, ESP32 Bluetooth Serial firmware, OpenGloves setup, standard-format notes, and calibration guidance`
- `xRayz3n/ExoTouch-2.0` - `Studied in Wave 227 as a LucidGloves-derived exoskeleton glove hardware/firmware variant with AS5600 encoder input, I2C multiplexer selection, calibration loops, serial/Bluetooth communication abstraction, alphabetic encoding, and servo force-feedback output`

## 199. WebXR hand input, gesture templates, and fallback hand-tracking primitives

Primary docs:

- `../landscape/vr-projects-wave-228-webxr-hand-input-gesture-template-and-fallback-hand-tracking-primitives.md`
- `../landscape/project-families.md`

- `stewdio/handy.js` - `Studied in Wave 228 as a compact WebXR hand-pose template matcher with wrist/head-relative pose snapshots, sorted pose search, bounded per-hand recognition budget, isPose helper, and pose began/ended events`
- `stewdio/vr-hands` - `Studied in Wave 228 as deprecated Handy.js lineage showing direct fist, horns, and finger-gun gesture bindings into scene behavior`
- `physicslibrary/Threejs-VR-Hand-Input` - `Studied in Wave 228 as old but useful Quest/Three hand-input micro-recipes with joint reads, pinch distances, palm-up visibility toggles, and Oculus hand pointer model caveats`
- `vrmeup/threejs-webxr-hands-example` - `Studied in Wave 228 as a hand/controller input abstraction with required hand tracking, mechanical controller fallback, wrist/palm/finger feature extraction, damped pointer rays, and pinch-plus-palm gates`
- `martatesar/webxr-hands-gestures-recognition` - `Studied in Wave 228 as a TypeScript wrist-local gesture template recognizer and learner with JSON templates, opposite-hand pinch confirmation, and gesture_changed events`
- `beemsoft/webxr-handtracking-playground` - `Studied in Wave 228 as a native WebXR plus MediaPipe hand-tracking playground with landmark meshes, open/stop-hand heuristics, Ammo/Cannon proxy joints, and desktop fallback caveats`
- `immersive-web/webxr-hand-input` - `Studied in Wave 228 as the canonical WebXR hand-input explainer for 25 joint spaces, getJointPose, fillPoses/fillJointRadii performance, and privacy/security caveats`

## 200. Immersive data, robotics, and scientific visualization workbenches

Primary docs:

- `../landscape/vr-projects-wave-229-immersive-data-robotics-and-scientific-visualization-workbenches.md`
- `../landscape/project-families.md`

- `vuer-ai/vuer` - `Studied in Wave 229 as a Python async WebSocket scene bridge with msgpack events, declarative scene operations, workspace asset serving, robotics schemas, hand/body tracking docs, and teleoperation examples`
- `thomann/plotAR` - `Studied in Wave 229 as a generated immersive plot workflow with QR pairing, VR/keyboard pages, glTF/USDZ export, simple WebSocket control commands, and older WebVR/security caveats`
- `TsatsuAmable/nemosyne` - `Studied in Wave 229 as a data-native WebXR visualization engine with artifact registration, semantic property mapping, VR-aware layout algorithms, transform DSL, and stream extensions`
- `smrghsh/brahma` - `Studied in Wave 229 as a collaborative scientific WebXR room shell with environment/controller modules, selectable/grasp/locomotion primitives, remote embodiment, callouts, and hardcoded endpoint caveats`
- `jurmy24/mechaverse` - `Studied in Wave 229 as an adjacent browser robotics viewer dispatch shell for URDF, MJCF, and USD file groups with drag/drop payload events and non-XR caveats`

## 201. Scriptable WebXR modeling, viewer, editor, and creative display surfaces

Primary docs:

- `../landscape/vr-projects-wave-230-scriptable-webxr-modeling-viewer-and-creative-surfaces.md`
- `../landscape/project-families.md`

- `vipenzo/ridley` - `Studied in Wave 230 as a CAD-as-code workbench with ClojureScript/SCI runtime evaluation, turtle geometry, editor/REPL, pilot-mode code generation, WebXR VR/AR hooks, PeerJS desktop-headset sync, voice input, and Windows-invalid-path checkout caveat`
- `id3vi5er/fusion360_webxr_viewer` - `Studied in Wave 230 as a Fusion 360 add-in bridge with toolbar commands, OBJ/MTL export, threaded local HTTPS server, LAN URL listing, WebXR AR viewer reload, centering, scaling, and controller grab/rotate controls`
- `felipereigosa/kairon` - `Studied in Wave 230 as a VR code editor with desktop keyboard/input companion, tab and terminal model, code execution, controller polling, haptics, locomotion, physics, and editor visibility toggles`
- `phobi82/webxr_butterchurn` - `Studied in Wave 230 as a modular no-build WebXR audio visualizer shell with app config, audio analyser, in-headset menu sections/sliders/cyclers, depth/passthrough, lighting, runtime, movement, TestLab, and desktop menu preview`

## 202. WebXR prototyping runtime micro-frameworks and experimental interaction primitives

Primary docs:

- `../landscape/vr-projects-wave-231-webxr-prototyping-runtime-micro-frameworks-and-experimental-primitives.md`
- `../landscape/project-families.md`

- `google/xrblocks` - `Studied in Wave 231 as a broad AI plus WebXR SDK with Script/Core/Options/User boundaries, gestures, WebXR and MediaPipe hand estimators, depth, simulator, spatial UI blocks, sound/video/world modules, and AI/agent integrations`
- `w3reality/threelet` - `Studied in Wave 231 as a compact Three/WebXR wrapper with auto scene/camera/renderer defaults, optional VR/AR/XR buttons, render-loop switching, mouse/pointer/touch/XR events, controller ray helpers, and disposal utilities`
- `simonedevit/reactylon` - `Studied in Wave 231 as a declarative React/Babylon XR framework with custom reconciler, scene injection, generated components, default XR experience hook, WebGPU/WebGL engine wrapper, model hook, and automatic disposal`
- `vishnu7560834213/threexr` - `Studied in Wave 231 as a rough Three/Vite WebXR starter with VRButton setup, controller grips, gamepad axes/buttons, player capsule, BVH collision helper, camera follow, and immature packaging caveats`
- `ARDings/EverythingController` - `Studied in Wave 231 as a single-file XR Blocks depth-sensing body-as-controller demo with point-cloud reconstruction, collision/hit detection, debug/occlusion instancing, and spatial settings panel`
- `dmvrg/webxr-ar-demos` - `Studied in Wave 231 as a WebXR AR demo set with hand pinch, UI planes, product color/size controls, burger exploded view, switch cooldowns, direct manipulation, and Spectacles/product-demo caveats`

## 203. WebXR robot teleoperation frontends, safety gates, and data collection

Primary docs:

- `../landscape/vr-projects-wave-232-webxr-robot-teleoperation-frontends-safety-gates-and-data-collection.md`
- `../landscape/project-families.md`

- `SpesRobotics/teleop` - `Studied in Wave 232 as a compact WebXR pose-to-Python callback bridge with FastAPI/WebSocket entry point, shadow-DOM motion UI, hold-to-move gate, scale presets, RUB-to-FLU transform conversion, relative pose reset, and transform jump limiting`
- `ajhai/teleop-xr` - `Studied in Wave 232 as a protobuf-backed robot adapter surface with binary WebSocket transport, heartbeat, robot manager, joint/status/camera payloads, reconnect handling, camera texture planes, and AR help overlays`
- `fracapuano/maniskill-quest-teleop` - `Studied in Wave 232 as a Quest WebRTC telemetry bridge with unordered telemetry channel, ordered control channel, hand/controller/view/head state, backpressure limits, stale-hand policy, telemetry-only mode, and debug capture`
- `almond-bot/axol-vr` - `Studied in Wave 232 as an R3F headset operator HUD and data-collection surface with explicit teleop/recording/saving/error state, button-edge handling, body-tracked elbows, controller poses, grip values, lock flags, and countdown UX`
- `vivek-kanjarla/Quest3-Fairino` - `Studied in Wave 232 as a safety-first Quest3-to-Fairino pipeline with multiple transport modes, stale-data invalidation, deadman switch, delta Cartesian mapping, IK seed reuse, joint/rate limits, sim/validate/live modes, diagnostics, and episode recording`

## 204. VR terminal, shell, and operational dashboard surfaces

Primary docs:

- `../landscape/vr-projects-wave-233-vr-terminal-shell-and-operational-dashboard-surfaces.md`
- `../landscape/project-families.md`

- `max-gaspers-scott/VR-Terminal` - `Studied in Wave 233 as a Rust PTY/VTE terminal surface with Socket.IO snapshots, cell attributes, row revisions, frontend command buffer, home-row keymap, canvas texture rendering, and A-Frame terminal plane`
- `coderofsalvation/xrsh` - `Studied in Wave 233 as a shell-as-XR-world concept with A-Frame scene, ISO-backed terminal, self-container flow, hand/ray/gaze controls, teleport/navigation buttons, and windowing substrate caveats`
- `soren42/visual-traceroute` - `Studied in Wave 233 as an operational network graph pipeline with discovery/scanning, MST/BFS/force layout, built-in progress server, polling status page, done/error sentinels, and self-contained WebXR/Three output`
- `CanaanMuayad/earthshift-vr` - `Studied in Wave 233 as a modular VR cockpit with widget registry, draggable glass panels, border-drag versus center-click separation, shared locomotion store, and localStorage-backed state`
- `MKTHINGS/webxr-dashboard-meta-quest` - `Studied in Wave 233 as a Quest/A-Frame local-first dashboard with programmatic UI manager, notes/bookmarks/photos models, haptic feedback, unsupported-device overlay, VR enter/exit handling, and autosave`

## 205. XR/smart glasses low-level SDKs, virtual displays, and BLE HUD templates

Primary docs:

- `../landscape/vr-projects-wave-234-xr-smart-glasses-low-level-sdks-virtual-displays-and-ble-hud-templates.md`
- `../landscape/project-families.md`

- `boomskats/woahland` - `Studied in Wave 234 as a Linux Viture head-mouse with uinput mouse output, IMU yaw/pitch/roll decoding, sensitivity/deadzone/smoothing, roll-scroll, config fallback, Unix socket runtime commands, recenter, pause/resume, reload, and CLI control`
- `Wojtekb30/EasyVXR` - `Studied in Wave 234 as a minimal thread-safe C wrapper around the Viture SDK with Euler/quaternion decoding, latest IMU copies, start/connect, safe disconnect, IMU/3D/frequency helpers, and Linux/vendor-SDK caveats`
- `darkclad/uxspace` - `Studied in Wave 234 as an Android/Windows XR glasses spatial desktop with VirtualDisplay/SurfaceTexture screens, Shizuku-launched app screens, cursor dispatch, IddCx virtual monitors, DDA capture, D3D11 stereo composition, named-pipe driver control, and vendor-neutral tracker boundaries`
- `emingenc/even_glasses` - `Studied in Wave 234 as a Python BLE command micro-library for Even Realities glasses with left/right scanning, write lock, reconnect attempts, heartbeat, command enums, text pagination, RSVP, dashboard, brightness, silent mode, notes, and notification chunking`
- `fabioglimb/even-toolkit` - `Studied in Wave 234 as a G2 app framework and design system with per-screen display/action routing, 576x288 layout constants, split/column pages, raw EvenHub bridge access, gesture debouncing, text-update scroll suppression, keep-alive, STT modules, and web components`
- `even-realities/evenhub-templates` - `Studied in Wave 234 as official G2 starter templates for minimal text, ASR/mic streaming, image rendering, long-text pagination, event routing, double-tap shutdown, render debounce, and grayscale/image preprocessing caveats`
- `Commute773/g2-kit-unofficial` - `Studied in Wave 234 as a reverse-engineered G2 BLE/protocol stack with L/R arm session prelude, aa21 envelope framing, CRC-16, protobuf builders, magic ack matching, pipelined writes, async events, LC3 audio, image tiling, render coalescer, explicit pager, and firmware gotcha docs`

## 206. Browser-native WebXR drawing, whiteboard, and creative surfaces

Primary docs:

- `../landscape/vr-projects-wave-235-browser-native-webxr-drawing-whiteboard-and-creative-surfaces.md`
- `../landscape/project-families.md`

- `localtoast42/webxr-whiteboard` - `Studied in Wave 235 as a thin Three/WebXR interaction probe with engine/player/controller boundaries, XRButton, controller grip/ray spaces, gamepad wrapper, squeeze-driven object hit checks, and bounding-box material feedback`
- `felixtrz/canvrs` - `Studied in Wave 235 as an Elixr/Three AR painting micro-tool with GLTF multitool attachment, mode toggle, pressure threshold, color cycling, line buffer draw ranges, min-distance sampling, line bounding boxes, and eraser-size variants`
- `n1ckfg/LightningLoops` - `Studied in Wave 235 as a networked/generative LATK stroke surface with Express/socket.io frame server, client stroke upload, frame requests, local/remote layers, frame motor, turtle-generated stroke morphs, Magenta input, JSON save, and stroke lifetime cleanup`
- `nuonical/webxr-babylon` - `Studied in Wave 235 as a Babylon creative workbench with XR lifecycle, controller locomotion, trigger drawing, palette toggles, pointer blocking, desktop fallback drawing, tube/ribbon/metaball strokes, chunk splitting, stroke/point limits, haptics, portal tests, and in-world FPS diagnostics`
- `sierrajanson/Harold-in-VR` - `Studied in Wave 235 as an A-Frame drawing/prototyping tool with global tool state, left-trigger menu, shape submenu, tool isolation, gradient color picker via raycast UV canvas sampling, ruler measurements, shape drag/resize workflows, grid/background UX, and clear/erase surfaces`
- `cpufreestyle/vr-paint` - `Studied in Wave 235 as an A-Painter fork with controller input mappings, brush registration API, pressure-aware strokes, shared buffer geometry, undo/clear/remove, JSON and binary apa save/load, URL-based load, upload/share flow, tooltip fade, and controller model feedback`

## 207. VR locomotion, embodiment, and comfort microcontrols

Primary docs:

- `../landscape/vr-projects-wave-236-vr-locomotion-embodiment-and-comfort-microcontrols.md`
- `../landscape/project-families.md`

- `RoWoCha/LocomotionVR` - `Studied in Wave 236 as a SteamVR locomotion demo with HMD-relative joystick direction, speed ramping, dynamic CharacterController height/center, snap-turn around head position, speed-linked comfort blinders, full snap-turn vignette pulse, and trigger-volume intensity gates`
- `pascalmariany/Unity-WebXR-Teleportation-and-SmoothLocomotion` - `Studied in Wave 236 as a WebXR movement/teleport hybrid with thumbstick deadzone, camera-yaw movement, controller-axis teleport preview delay, release-to-commit teleport, ballistic arc linecasts, marker placement, and head/body offset compensation`
- `dabeschte/VRArmIK` - `Studied in Wave 236 as head/hand-only avatar embodiment donor with persisted HMD/wrist calibration, shoulder pose estimation, behind-head handling, arm-length clamping, elbow rotation, and local XR node input`
- `ralph-immrsv/UnityVR-ArmSwingMovement` - `Checked in Wave 236 as source-light search result; checkout contained only git/ignore metadata and no usable implementation files`

## 208. WebXR depth, point-cloud, room-scan, and spatial dataset viewers

Primary docs:

- `../landscape/vr-projects-wave-237-webxr-depth-point-cloud-room-scan-and-spatial-dataset-viewers.md`
- `../landscape/project-families.md`

- `Ramith-D-Rodrigo/webxr-point-cloud` - `Studied in Wave 237 as a WebXR camera/depth point-cloud pipeline with depth-sensing, camera-access, DOM overlay controls, camera framebuffer readback, randomized depth sampling, worker reconstruction, Three point meshes, and GLTF export`
- `Dhruvi509/Webxr-room-scanner` - `Studied in Wave 237 as a Babylon WebXR AR measurement micro-tool with hit-test, background removal, anchor fallback, first/second point flow, live preview line, and distance label`
- `BSoDium/Lidar` - `Studied in Wave 237 as a React/Three XR lidar-style ray-grid and point-cloud reveal reference with Raycaster/ArrowHelper arrays, hit/miss color feedback, BVH raycast intent, terrain shader feedback, and point-budget caveats`
- `sterngefeuert/webxr-gaussian-splat` - `Studied in Wave 237 as a Three/WebXR Gaussian splat viewer with shared renderer/camera/scene, progressive loading, AR DOM overlay, VR button, drag/drop local file ingestion, query-param loading, reload UI, and desktop fallback controls`
- `MikeWise2718/messelpit_viewer` - `Studied in Wave 237 as an Omniverse Kit spatial dataset viewer with separate desktop/streaming/XR apps, OpenXR startup diagnostics, in-VR floating panels, shared viewpoint controls, and RTX/Quest/driver caveats`

## 209. VR training, rehabilitation, and simulated-user evaluation harnesses

Primary docs:

- `../landscape/vr-projects-wave-238-vr-training-rehabilitation-and-simulated-user-evaluation-harnesses.md`
- `../landscape/project-families.md`

- `fl0fischer/sim2vr` - `Studied in Wave 238 as a Unity/User-in-the-Box evaluation harness with RLEnv reward/reset/time/log hooks, ZMQ state exchange, simulated HMD/controller anchors, RGB-D camera observations, time-scale negotiation, and recorder output`
- `kaayran/ShootingRangeVR` - `Studied in Wave 238 as a SteamVR training scenario with modular weapon/ammunition/grenade/equipment mechanics, target accuracy scoring, average accuracy panel, remote target movement, audio one-shots, and controller-binding caveats`
- `GxRay/Trunk-Rehabilitation-VR-Training-Simulator-` - `Studied in Wave 238 as a rehab biofeedback system with TCP EMG/accelerometer ingress, IIR/notch filtering, Spaceball command sender, gaze-menu framing, live graph widgets, score/life HUD, and hardware-specific caveats`
- `Nelliel2/VR-training-simulator` - `Checked in Wave 238 as an asset-heavy Unity construction/worksite training tree; retained as scenario reference requiring deeper script extraction before donor promotion`
- `NagashreeSP/VR-Fire-Safety-Training-Simulator` - `Checked in Wave 238 as README-only fire-safety training concept; no code donor value in current tree`
- `superjaviko/RESILIENCE` - `Studied in Wave 238 as AI-assisted VR training reference with UPBGE logic scripts, socket training-session lookup, Google Sheets access, voice coach flow, navigation-arrow setup, audio triggers, and strong hardcoded-secret/local-path caveats`

## 210. Game-specific VR retrofit UX, mod interaction shells, and in-game control surfaces

Primary docs:

- `../landscape/vr-projects-wave-239-game-specific-vr-retrofit-ux-mod-interaction-shells-and-in-game-control-surfaces.md`
- `../landscape/project-families.md`

- `Okabintaro/SubmersedVR` - `Studied in Wave 239 as a Subnautica VR retrofit with SteamVR input patches, settings tabs, snap-turn gating, controller/UI laser pointers, virtual keyboard patches, camera-rig ownership, wrist HUD, quick-slot radial wheel, offset calibration logging, main-menu camera stealing, and debug panel`
- `dortamur/satisfactory-uevr-enhancements` - `Studied in Wave 239 as a UEVR companion product reference with SML plugin metadata, controller mappings, input actions, wrist UI, radial menus, haptics, help tips, onboarding patches, keyboard actions, UEVR profile coupling, and mostly binary Blueprint assets`
- `DSprtn/GTFO_VR_Plugin` - `Studied in Wave 239 as an IL2CPP/BepInEx VR retrofit donor with SteamVR process gate, class injection, Harmony patches, VRSystems focus handling, SteamVR input mapping, movement vignette, snap-turn fade, world-space UI conversion, watch/radial surfaces, terminal keyboard, and haptics`
- `KyleTheScientist/Bark` - `Studied in Wave 239 as a Gorilla Tag mod interaction shell with BepInEx/Utilla lifecycle, modded-lobby gating, gesture menu summon, grabbable/thrown menu, physical collision buttons, module lifecycle, hand/pointer interactors, networked module status, and manual testing procedures`

## 211. VR WebView browser surfaces, spatial keyboards, and Quest-native web content

Primary docs:

- `../landscape/vr-projects-wave-240-vr-webview-browser-surfaces-spatial-keyboards-and-quest-native-web-content.md`
- `../landscape/project-families.md`

- `TLabAltoh/TLabWebViewVR` - `Studied in Wave 240 as a Quest-native Unity WebView surface family with Meta XR and XRI package folders, WebView prefabs, spatial keyboard scene, XRBrowserInputField focus-gated key-event forwarding, search/load callbacks, Android-only rendering, OpenXR Internet permission, HardwareBuffer/ByteBuffer, Vulkan/OpenGLES, and Unity 6000 caveats`
- `TLabAltoh/TLabWebViewVR-XRInteractionToolkit-2022` - `Studied in Wave 240 as a minimal Unity 2022 XRI WebView sample with TLabWebView_XRInteractionToolkit prefab, searchbar example, package manifests, and XRI 2.5.4 compatibility boundary`
- `TLabAltoh/TLabWebViewVR-OculusIntegration-2022` - `Studied in Wave 240 as a Meta XR WebView variant with TLabWebView_MetaXR prefab, searchbar callbacks, dialog/error events, input-field components, and JavaScript focus/focusout keyboard visibility reference`

## 212. Unity XR UI adapters, grab affordances, and physical control microcomponents

Primary docs:

- `../landscape/vr-projects-wave-241-unity-xr-ui-adapters-grab-affordances-and-physical-control-microcomponents.md`
- `../landscape/project-families.md`

- `BernwardWeigand/UnityUIToolkitXRAdapter` - `Studied in Wave 241 as a Unity UI Toolkit to XRI adapter with collider-backed UIDocuments, synthetic Input System controller state, ray-to-panel local position mapping, RenderTextureResizer, text-field focus bridge, and angular-size UI elements`
- `podobaas/XRGrabInteractableRing` - `Checked in Wave 241 as a source-light XRI grab affordance reference documenting ring prefab, attach transforms, show-on-selected, layer mask, distance threshold, min/max scale, animation timing, and show/hide events`
- `Priyanshu-CODERX/Unity-XR-Interaction-Toolkit-VR-Mechanisms` - `Studied in Wave 241 as an XRI mechanism set with UI proximity events, hand animation action mapping, hand visibility on grab, XRPushButton, and scenes for grab, teleport, UI, snap, hands, and physical buttons`
- `Youkaku-1/VRPuzzelGame` - `Studied in Wave 241 as a Unity VR puzzle/control reference with keypad input, accepted/denied feedback, emissive screen state, button press animation, door events, decal reveal triggers, and XRI grab/socket/teleport scene surfaces`

## 213. CV, mocap, and industrial VR training control loops

Primary docs:

- `../landscape/vr-projects-wave-242-cv-mocap-and-industrial-vr-training-control-loops.md`
- `../landscape/project-families.md`

- `WestCoastGod/XR-CV-Forceps-Tracking-Unity` - `Studied in Wave 242 as a Quest 3 ArUco physical-tool tracking donor with multi-marker rigid pose estimation, reprojection error, One Euro position/rotation/scale smoothing, visibility-marker clamp state, clamp freeze, geometric object-size mapping, and XRI grab/release`
- `jghanania/MotionCapture-AgilityLadder-XR-Study` - `Studied in Wave 242 as a Quest/OptiTrack research harness with balanced Latin-square conditions, AR/VR/real-world switching, occlusion control, avatar scaling, camera-rig mocap alignment, ladder path sequencing, foot-contact measurement, and participant CSV logging`
- `jesusfernandorl/Industrial_Twin_XR-Safe-Robotics-and-6-Axis-VR-Control` - `Checked in Wave 242 as a source-light industrial robot VR training reference for deadman switch, soft limits, interlock logic, physical HMI feedback, spatial audio, Unity Robotics Hub/ROS direction, and safety-standard framing`
- `purva-rana/MindscapeVR` - `Checked in Wave 242 as a source-light neuro-rehabilitation VR concept with clinical-room to mindscape transition, neural blockage metaphor, XR Interaction Toolkit framing, and trigger-driven difficulty escalation`

## 214. Spatial measuring, modeling, collaboration, and MR workbench surfaces

Primary docs:

- `../landscape/vr-projects-wave-243-spatial-measuring-modeling-collaboration-and-mr-workbench-surfaces.md`
- `../landscape/project-families.md`

- `rtkCode/Sizer` - `Studied in Wave 243 as a browser AR measure/model/project donor with WebXR hit-test reticle, point-pair distance and angle capture, DOM overlay measurement cards, local history, A-Frame box editing, toolbar controls, drag/rotation gestures, AR.js marker projection, and marker-found/lost feedback`
- `byte-banditt/Meshelanjelo` - `Studied in Wave 243 as a Meta Quest MR mesh manipulation donor with OVRHand pinch detection, pointer-pose deformation center, left-pull/right-push semantics, smoothed intensity/rebound, and Burst/job PushPullDeformer vertex/normal radius falloff`
- `B22DigitalTwins2022/ar-resilience-planner-v2` - `Studied in Wave 243 as an MR planning workbench with additive scene loading, persistent menu state, panel selector, solution grouping, simulation updates, and timestamped user-study CSV logs`
- `adityanooka/Unity-Dive-VR` - `Studied in Wave 243 as a collaborative VR reference with Unity Netcode, XRI selection-count lift gates, server-owned random spawning, server-only proximity reactions, ownership-guarded movement, and VR/desktop locomotion fallback`
- `Hempp/street-art-gallery` - `Checked in Wave 243 as a source-light social VR gallery product reference for hotspots, guided tours, avatars, emotes, voice, nametags, gathering areas, and comfort settings`

## 215. OpenVR overlay micro-surfaces, telemetry panels, and game HUD prototypes

Primary docs:

- `../landscape/vr-projects-wave-244-openvr-overlay-micro-surfaces-telemetry-panels-and-game-hud-prototypes.md`
- `../landscape/project-families.md`

- `Sch1nken/VRChatOverlay` - `Studied in Wave 244 as a legacy OpenVR/SFML/OpenGL overlay skeleton with VRApplication_Overlay init, CreateOverlay and dashboard/keyboard notes, tracked-device-relative placement, width/alpha settings, overlay event polling, SFML render texture upload, and early chat-plugin framing`
- `ObnubiladO/vram-overlay` - `Studied in Wave 244 as a desktop telemetry micro-panel reference with transparent topmost WPF window, F8 hotkey, context menu, draggable surface, PerformanceCounter GPU memory polling, WMI fallback, and local JSON settings persistence`
- `Spacefish/OpenVR-Overlay` - `Studied in Wave 244 as a C#/.NET OpenVR overlay donor with Vulkan VRVulkanTextureData_t submission, controller-relative placement, mouse input, dashboard control-bar flags, event polling, cleanup, and haptic feedback`
- `lukis101/VRPoleOverlay` - `Studied in Wave 244 as an OpenVR playspace landmark overlay with settings.json, edit mode, trigger snap/drag adjustment, chaperone height/color awareness, fade controls, SteamVR autostart manifest, and space-offset caveats`
- `AArchAngel/Remlok-HUD` - `Studied in Wave 244 as a Unity/OVRLay game HUD reference driven by process checks, FileSystemWatcher journal reads, JSON mission parsing, mission filtering/sorting, EDDB-style data loading, UI updates, and voice prompts`

## 216. OpenXR micro-layer render shaping, foveation, and tracking diagnostics

Primary docs:

- `../landscape/vr-projects-wave-245-openxr-micro-layer-render-shaping-foveation-and-tracking-diagnostics.md`
- `../landscape/project-families.md`

- `danny1marshall1587-maker/MonoEye` - `Studied in Wave 245 as an experimental OpenXR mono-eye layer with loader negotiation, generated dispatch, env-configured enable/bypass, view-count intervention, internal stereo/IPD state, Vulkan utility boundaries, and depth-warp reconstruction intent`
- `TripleJ160/Beyond-EVO` - `Studied in Wave 245 as a game/hardware-specific D3D12/VRS foveation layer with OpenXR graphics-binding capture, extension/device capability gates, eye-gaze actions, smoothing/fallback, shading-rate image resources, heatmaps, INI config, and named-pipe live controls`
- `marcsabat/xr-tracking-diagnostics` - `Studied in Wave 245 as a minimal OpenXR tracking doctor layer with dispatch table setup, session/reference-space management, xrWaitFrame pose reads, F9 recording toggle, beeps, logs, duration config, and CSV pose traces`
- `mbucchia/_ARCHIVE_XR_APILAYER_NOVENDOR_nis_scaler` - `Studied in Wave 245 as an archived OpenXR NIS scaler ancestor with swapchain hooks, D3D11 device/resource wrapping, scaler modes, config, stats, screenshots, hotkeys, and resource-lifecycle lessons`

## 217. SlimeVR DIY tracker hardware, PCB, case, and firmware boundaries

Primary docs:

- `../landscape/vr-projects-wave-246-slimevr-diy-tracker-hardware-pcb-case-and-firmware-boundaries.md`
- `../landscape/project-families.md`

- `zhangwenchao1992/SlimeVR_DeftTracker` - `Studied in Wave 246 as a full SlimeVR-style hardware kit with main tracker, auxiliary tracker, charge hub, STL/case files, PCB BOM/Gerber/schematic outputs, photos, and a broad SlimeVR firmware subtree`
- `frosty6742/frozen-slimes-v2` - `Studied in Wave 246 as a maker-friendly tracker PCB reference with Wemos D1 mini, MPU/BMI/BNO IMU options, TP4056 charging, hotswappable 18650, strap slots, bridge pads, assembly checklist, firmware orientation notes, and calibration caveats`
- `TheButlah/slimevr_pcb` - `Studied in Wave 246 as a SlimeVR PCB family donor with simple breakout board, ESP32-C3/RISC-V/BLE ferrous_slime design, IMU compatibility jumpers, ICM20948 breakout, hardware changelog, and open-hardware license posture`
- `gumorr/GummySlime` - `Studied in Wave 246 as a hand-solderable SlimeVR-compatible board with 0603 passives, module IMU boundary, ESP32-C3-WROOM-02, auxiliary pads, USB-C/charging notes, BOM, KiCad files, and PlatformIO defines`
- `Tropingenie/Caribou-Slime` - `Studied in Wave 246 as a compact ESP32-C3 SuperMini plus BMI270 tracker PCB with BOM/cost notes, charger/battery choices, hand-assembly or PCBA framing, and reciprocal open-hardware license requirements`
- `infopcgood/SMORES` - `Checked in Wave 246 as a source-light tiny tracker PCB direction around EBYTE E73/nRF52840 and ICM-45686, useful only as a schematic follow-up candidate until deeper evidence is gathered`
- `ZRock35/TinyOfficial-Case` - `Checked in Wave 246 as a mechanical SlimeVR case reference with official-board enclosure remix, clip/backplate options, angled strap loops, battery orientation, foam pad notes, and connector-fragility warnings`
- `1vers1on/vr_trackers` - `Studied in Wave 246 as a Zephyr tracker firmware/hardware skeleton with IMU/magnetometer/fuel-gauge/charger/button/USB init, packed tracker packet schema, gyroscope calibration, board DTS, and incomplete transport-loop caveat`

## 218. Webcam avatar body tracking bridges and VRM motion surfaces

Primary docs:

- `../landscape/vr-projects-wave-247-webcam-avatar-body-tracking-bridges-and-vrm-motion-surfaces.md`
- `../landscape/project-families.md`

- `zekailin00/VR-Full-Body-Tracking-System` - `Studied in Wave 247 as an IMU plus headset/controller tracking bridge with ESP8266 HTTP firmware upload, Flask tracker and Unity endpoints, shared input/output structs, IMU smoothing and body mapping, Unity HMD/controller upload, pose polling, and hardcoded-network caveats`
- `Raraph84/Cameras-Full-Body-Tracking` - `Studied in Wave 247 as a browser multi-camera MediaPipe bridge with HTTPS static host, WebSocket/WebRTC signaling, four-corner square calibration, homography/focal estimation, DLT triangulation, smoothing, and OSC tracker output`
- `DubbsPi/Mediapipe-SteamVR-Full-Body-Tracking-for-Linux` - `Studied in Wave 247 as a Linux CV-to-SteamVR bridge with Python webcam/MediaPipe inference, GUI offsets/smoothing/brightness, Unix-domain socket packets, and an OpenVR server driver exposing synthetic generic trackers`
- `yeemachine/kalidoface-3d` - `Studied in Wave 247 as a browser VRM/Vtubing product reference with MediaPipe/Kalidokit, Three/VRM, localforage persistence, custom backgrounds/stickers, chroma/OBS mode, six-digit P2P voice framing, and bundled-source caveat`
- `Neleac/MesekaiUnity` - `Studied in Wave 247 as a Unity MediaPipe avatar retargeting donor with pose/hand/face solvers, mirror mode, smoothing, blendshape mapping, template-avatar motion transfer, ReadyPlayerMe avatar loading, and Photon serialization`

## 219. VRChat OBS world metadata and browser source overlays

Primary docs:

- `../landscape/vr-projects-wave-248-vrchat-obs-world-metadata-and-browser-source-overlays.md`
- `../landscape/project-families.md`

- `Natsumi-sama/VRC-OBS-Overlay` - `Studied in Wave 248 as a Blazor localhost OBS browser-source overlay with VRChat Windows registry location polling, OpenGraph world metadata extraction, no-cache server responses, Razor UI updates, and CSS customization`
- `philippgitpush/vrc-obs-world-overlay` - `Studied in Wave 248 as an Electron/Vue overlay reading VRCX SQLite world state and auth-cookie data, serving local Express routes, exposing settings JSON, enforcing local CORS, and rendering configurable overlay placement/platform UI`
- `ktmage/vrc-world-credit-streaming-overlay` - `Studied in Wave 248 as a TypeScript VRChat log watcher and browser-source overlay with incremental file offsets, Zod schemas, official API contact handling, cache/rate-limit state, SSE updates, and card/topbar styles`
- `Mahcks/vrc-world-teller` - `Studied in Wave 248 as a tiny Node VRChat API poller that writes current world or world-plus-author text to a file for OBS text sources, with credential/rate-limit caveats`
- `Elocin-Anagram/VRC_World_Location` - `Studied in Wave 248 as a PowerShell VRChat log tailer with adaptive tail size, generated text/performance files, and a browser-source HTML page polling local files`
- `nosjo/obs-vrchat-log-reader` - `Studied in Wave 248 as an OBS Lua script that reads VRChat logs directly and switches scenes on room transition events`

## 220. VRChat OBS control, OSC scene switching, and movie night queues

Primary docs:

- `../landscape/vr-projects-wave-249-vrchat-obs-control-osc-scene-switching-and-movie-night-queues.md`
- `../landscape/project-families.md`

- `nerdywoffy/vrchat-obs-controller` - `Studied in Wave 249 as a Go OSC sidecar with VRChat avatar parameter contracts, OBS v5 and Streamlabs adapters, replay/record/stream/scene controls, 500 ms status polling, and avatar feedback`
- `rogeraabbccdd/VRChat-OBSOSC` - `Studied in Wave 249 as a compact Node OBS v4/v5 WebSocket bridge controlled by VRChat expression-menu parameters with startup state sync and scene/stream event feedback`
- `ioarchive/obscontrol` - `Studied in Wave 249 as a historical MelonLoader/ReMod quick-menu OBS controller with obs-websocket buttons and world leave/join scene switching, retained mainly as UX reference with EAC/TOS caveats`
- `TuTu475/VRC-OBS-MicControl` - `Studied in Wave 249 as an OBS Python script that listens to VRChat muteself OSC, debounces input, periodically corrects OBS microphone mute state, and exposes script-panel settings`
- `dimebag29/VRChatObsMicMuteLink` - `Studied in Wave 249 as a Windows tray app mapping VRChat MuteSelf OSC to global OBS hotkey chords through pythonosc, pywin32, and pystray`
- `0x29a-blink/VRChat-Movie-Night` - `Studied in Wave 249 as a local event operator stack with authenticated web UI, media library/queue, OBS media-source control, auto-advance, OBS busy/offline handling, MediaMTX HLS presets, and VRChat video-player HLS output`
- `MissingNO123/OBS-Scripts-for-VRChat` - `Studied in Wave 249 as OBS-native Python scripts for VRChat loading-screen scene switching and OSC action-menu OBS controls with status feedback`

## 221. VRChat virtual production, camera routing, and live stream pipelines

Primary docs:

- `../landscape/vr-projects-wave-250-vrchat-virtual-production-camera-routing-and-live-stream-pipelines.md`
- `../landscape/project-families.md`

- `designio360/virtualproduction-vrchat` - `Studied in Wave 250 as a source-light Unity package reference for VRChat production stages with multiple cameras, camera crane, overlay slides, lighting controls, in-world buttons, keyboard controls, and OBS capture`
- `valkyriedimension/TD2VRC` - `Studied in Wave 250 as a TouchDesigner-to-VRChat VJ routing workflow using OBS, Spout/window capture, RTSP, stream links, screenshots, and a .toe example`
- `RemilRLs/StreamToVRC` - `Studied in Wave 250 as a Docker/NGINX RTMP-to-HLS donor with OBS ingest, ffmpeg multi-bitrate variants, HLS fragment settings, CORS/no-cache headers, and VRChat video-player URL framing`
- `dragokenlancer/VRC-Camera-control-webpage` - `Studied in Wave 250 as a POC browser control surface for VRChat camera OSC pose/zoom with local password sessions, public-viewing separation, hand-rolled OSC parsing, and preview-routing intent`
- `reece-berens/vrc-stream-plugins` - `Studied in Wave 250 as an adjacent browser-source stream plugin shell with API helper service, Next route/output pages, and typed event-score helpers`
- `furukawa1020/VRcoverOBS` - `Studied in Wave 250 as an adjacent avatar/OBS output system with OpenSeeFace/MediaPipe to WebSocket gateway, browser avatar runtime, tracking reconnects, canvas-to-WebSocket streaming, and OBS browser-source/virtual-camera docs`

## 222. OpenVR legacy sensor compatibility and synthetic driver shims

Primary docs:

- `../landscape/vr-projects-wave-251-openvr-legacy-sensor-compatibility-and-synthetic-driver-shims.md`
- `../landscape/project-families.md`

- `SDraw/driver_leap` - `Studied in Wave 251 as a Leap Motion to SteamVR controller driver with Leap poller thread, tracking reference registration, left/right controller devices, skeleton/input mapping, hand/cursor overlays, and companion settings app`
- `SDraw/driver_kinectV1` - `Studied in Wave 251 as a Kinect V1 skeleton to SteamVR generic tracker driver with joint filters, Vive Tracker-style identity properties, dashboard settings, tracker toggles, and controller-driven calibration`
- `SDraw/driver_kinectV2` - `Studied in Wave 251 as a Kinect V2 sensor variant with similar driver/dashboard/calibration boundaries and runtime-specific caveats`
- `schellingb/PseudoVive` - `Studied in Wave 251 as an early-load OpenVR driver shim using MinHook around property writes to force Vive manufacturer/model identity, with optional systray toggling`
- `r57zone/Half-Life-Alyx-novr` - `Studied in Wave 251 as a game-specific no-HMD SteamVR driver and keyboard/mouse control-mapping reference with sample-driver lineage, INI key maps, and heavy caveats`
- `lixiangwuxian/Viulux-V9-Driver-for-SteamVR` - `Studied in Wave 251 as a README-only vendor headset bridge reference tying Viulux, Relativty, OpenHMD, and Nolo requirements together with explicit bug warnings`
- `Blockmann2K/MurlokVR` - `Studied in Wave 251 as a DIY HMD experiment with firmware, Rust serial runtime, shared-memory pose contract, OpenVR factory/provider, HMD settings, input profile, and pose snapshot polling`

## 223. Hands-free OpenXR hand tracking input and wrist UI microtools

Primary docs:

- `../landscape/vr-projects-wave-252-hands-free-openxr-hand-tracking-input-and-wrist-ui-microtools.md`
- `../landscape/project-families.md`

- `SimForgeEngineering/DCS-HandsFree` - `Studied in Wave 252 as a tiny StereoKit/OpenXR HMD orientation to Windows cursor mapper with foreground-window bounds, yaw/pitch normalization, and Win32 cursor output`
- `JonahSagers/VRChord` - `Studied in Wave 252 as a Unity XR Hands chording keyboard with finger-curl classifiers, ASETNIOP-style chord dictionaries, fist-distance enable latch, thumb actions, and TextMeshPro feedback`
- `Haidere1/VarjoXR-CustomHandTracking-Test` - `Studied in Wave 252 as an Unreal/Varjo OpenXR hand-keypoint sample with poseable hand meshes, pinch rays, widget components, enhanced input contexts, and Cesium scene-manipulation caveats`
- `zodiepupper/godothandtrackingtests` - `Studied in Wave 252 as a Godot OpenXR hand-joint and wrist-menu experiment with procedural joint trackers, fingertip collision layers, passthrough enablement, smoothing, and Panel3D addon boundaries`

## 224. SteamVR dashboard menu keyboard and gamepad navigation shims

Primary docs:

- `../landscape/vr-projects-wave-253-steamvr-dashboard-menu-keyboard-and-gamepad-navigation-shims.md`
- `../landscape/project-families.md`

- `mbucchia/SteamVR-Dashboard-KeyboardNav` - `Studied in Wave 253 as an OpenVR driver shim plus companion utility with HMD driver wrapping, custom input profile, shared-memory click flag, low-level keyboard hook, and dashboard toggle behavior`
- `lmore377/quest-steamvr-system-button` - `Studied in Wave 253 as a Quest logcat to SteamVR dashboard toggle micro-utility using ADB home-button events, vrdashboard process checks, and vrmonitor debug URI dispatch`
- `AJBats/pad-vr` - `Studied in Wave 253 as a SteamVR synthetic controller driver and XInput companion with chest-mounted pose, Index-style input paths, shared-memory guide-button IPC, and recenter/dashboard URI actions`
- `MagnaLunas/SteamVRKeyboardLayoutChanger` - `Studied in Wave 253 as an obsolete but useful SteamVR dashboard keyboard layout patch reference with JSON layout files, bundled dashboard JavaScript, cache-clearing docs, and SteamVR 2.0 caveats`
- `bpbwaite/ahk-svrvmr` - `Studied in Wave 253 as an AutoHotkey bridge mapping SteamVR/Windows volume state to Voicemeeter bus gain through Vista Audio polling and VoicemeeterRemote DLL calls`

## 225. VRChat OSC chatbox media status and library microtools

Primary docs:

- `../landscape/vr-projects-wave-254-vrchat-osc-chatbox-media-status-and-library-microtools.md`
- `../landscape/project-families.md`

- `lillithrosepup/Lilypad` - `Studied in Wave 254 as a Kotlin Multiplatform/Compose VRChat OSC chatbox client with modules, OSCQuery address discovery, Spotify/LastFM, synced lyrics, avatar presets, banners, clocks, and Android/Quest companion framing`
- `ohkaelynn/iron-heart-chatbox` - `Studied in Wave 254 as a tray-based Iron-Heart BPM text-file to VRChat chatbox bridge with process checks, trend/history formatting, keep-open cadence, and biometric privacy caveats`
- `MeltyMooncakes/VRChat-OSC-Script` - `Studied in Wave 254 as a TypeScript OSC chatbox composer with YAML line templates, incoming avatar property cache, MPRIS/Windows media adapters, plugin loading, and send-interval gates`
- `o0F-0oF/VRChat-Spotify-Chatbox` - `Studied in Wave 254 as a tiny Python Windows Spotify window-title to VRChat chatbox sender with polling, title filtering, and platform/title-parsing caveats`
- `o0F-0oF/VRChat-Spotify-Chatbox-CS` - `Studied in Wave 254 as a C# SharpOSC Spotify window-title chatbox sender with compact process polling and nonstandard port caveats`
- `Mezque/VRC-SpotifyOSC-Py` - `Studied in Wave 254 as a Spotipy-backed now-playing chatbox sender with OAuth callback, formatted track state, volume/duration fields, settings.ini, and timer-based resend behavior`
- `Mezque/VRC-ClockOSC-Py` - `Studied in Wave 254 as a minimal clock-to-chatbox microtool with format string configuration, recursive timer loop, and narrow product-reference value`
- `eepyfemboi/ezmusic-desktop-client` - `Studied in Wave 254 as a rich desktop music/status client with webview login, cookie persistence, GPU/system stats, Discord RPC, VRChat OSC output, and dependency/security caveats`
- `ActuallyAbby/VRC-JavaOSC` - `Studied in Wave 254 as a Java VRChat OSC helper library with default port builder, optional parameter cache, avatar-parameter listeners, typed set/get helpers, and lifecycle caveats`
- `Disconnect3301/DisconnectOSC` - `Studied in Wave 254 as a C# console OSC module toy with chatbox commands, recording timer output, BuildSoft OSC usage, and strong caveats around tracked build artifacts and prank-style modules`

## 226. XR desktop smart-glasses and WebXR authoring utility surfaces

Primary docs:

- `../landscape/vr-projects-wave-255-xr-desktop-smart-glasses-and-webxr-authoring-utility-surfaces.md`
- `../landscape/project-families.md`

- `ProjectBlueSkies/xr-desktop` - `Studied in Wave 255 as a Viture XR Pro Linux desktop helper with C IMU daemon, udev/device SDK boundary, shared-memory quaternion IPC, GNOME Shell extension polling, and world-lock transform caveats`
- `mhalder/xreal-desktop-mode` - `Studied in Wave 255 as an ADB desktop-mode configuration microtool for Xreal One Pro with persistent Android desktop/freeform settings, external-display density tuning, wireless address persistence, and hidden-setting caveats`
- `marbetschar/wingpanel-indicator-xrdesktop` - `Studied in Wave 255 as an Elementary/Pantheon panel indicator exposing xrdesktop enabled state through a small DBus service, dynamic icon, and popover UI`
- `cong-lab/LabOS-Runtime` - `Studied in Wave 255 as a smart-glasses lab assistant runtime with connector abstraction, VITURE USB config deployment, voice/web/dashboard services, MediaMTX, gRPC, and large-stack caveats`
- `sawa-zen/three-fiber-webxr-toolbox` - `Studied in Wave 255 as a React/Three WebXR development toolbox with in-HMD console, curved remote display mesh, Vite/socket.io WebRTC signaling, portal/passthrough helpers, and dev-security caveats`
- `laffan/blender-webxr-tools` - `Studied in Wave 255 as a Blender addon for WebXR/R3F export preparation with bake/transform helpers, GLB/GLTF export, gltfjsx subprocess integration, JSX rewriting, and authoring-pipeline caveats`
- `pravinpoudel/building-annotation` - `Studied in Wave 255 as a WebXR/three.js building annotation reference with manual annotation schema, camera/lookAt metadata, dev-mode raycast capture, and educational demo caveats`

## 227. VMC protocol transport, OpenXR motion, and bridge adapters

Primary docs:

- `../landscape/vr-projects-wave-256-vmc-protocol-transport-openxr-motion-and-bridge-adapters.md`
- `../landscape/project-families.md`

- `LukasLichten/simple-xr2vmc` - `Studied in Wave 256 as a minimal Rust OpenXR headless pose sampler intended for OpenXR-to-VMC output, with extension gates, action-set pose polling, session events, predicted-time location reads, and incomplete/commented VMC send caveats`
- `sotanmochi/VMCTransportBridge` - `Studied in Wave 256 as a Unity/.NET VMC transport library with typed local VMC messages, MessagePack envelopes, network client identity, transport adapters, subscriber filters, and transported-message re-emission`
- `sotanmochi/VMCTransportHub` - `Studied in Wave 256 as a WPF/Blazor operator surface for VMC transport selection, gRPC/Photon connection state, destination routing, client-id filters, message counts, monitor UI, and appsettings-based configuration`
- `vivi90/python-vmc` - `Checked in Wave 256 as a source-light GitHub pointer to moved Python VMC work, useful as a follow-up scripting-wrapper candidate rather than current donor evidence`

## 228. XSOverlay notification wrappers, relays, and compatibility daemons

Primary docs:

- `../landscape/vr-projects-wave-257-xsoverlay-notification-wrappers-relays-and-compatibility-daemons.md`
- `../landscape/project-families.md`

- `nnaaa-vr/XSOverlay-VRChat-Parser` - `Studied in Wave 257 as a C#/.NET/Avalonia VRChat log parser that emits configurable XSOverlay notifications for join/leave, portals, world changes, and shader keyword events`
- `bluskript/xsoverlay-notifier` - `Studied in Wave 257 as a Rust Windows toast to XSOverlay UDP bridge with permission request flow, listener/polling strategies, icon/source extraction, sender restart loop, and privacy/filter caveats`
- `nnaaa-vr/XSNotifications` - `Studied in Wave 257 as a compact .NET XSOverlay UDP library with payload defaults, camelCase JSON, endpoint defaults, concurrent queue, AutoResetEvent worker, and best-effort delivery caveats`
- `Minty-Labs/WindowsXSO` - `Studied in Wave 257 as a Windows notification to XSOverlay companion with allow/deny app filters, notification permission guidance, SteamVR process lifecycle, height/timeout heuristics, and image masking`
- `Duinrahaic/XSSocket` - `Studied in Wave 257 as a C# XSOverlay WebSocket API wrapper with typed notifications, overlay commands, media/layout/device/performance/settings status requests, and command-name/artifact caveats`
- `Zyphrono/XSOverlay-VRChat-Status` - `Studied in Wave 257 as a VRChat service-status monitor that polls component state, tracks degraded/recovered transitions, gates work on VRChat process presence, and emits XSOverlay warnings`
- `project-vrcat/XSNotifier-Go` - `Studied in Wave 257 as a minimal Go XSOverlay UDP notification client with payload normalization, default values, mutex-protected UDP connection reuse, and narrow library-only scope`
- `gizmogoat/XSNotifyDaemon` - `Studied in Wave 257 as a Linux compatibility daemon exposing an XSOverlay-like WebSocket SendNotification subset and forwarding to notify-send, with temp-icon and no-auth caveats`
- `JacobA2000/VRCazam` - `Studied in Wave 257 as a VRChat OSC-triggered audio recognition utility that records speaker loopback, calls Shazam, logs track history, and returns desktop or XSOverlay notifications`
- `pikepikeid/PICOBatteryWatcher` - `Studied in Wave 257 as a PICO Connect log-tail battery monitor with threshold reset logic, HMD/controller parsing, XSOverlay WebSocket notification payloads, and vendor-log drift caveats`

## 229. VRChat OSC micro-control, input, and avatar-parameter utilities

Primary docs:

- `../landscape/vr-projects-wave-258-vrchat-osc-micro-control-input-and-avatar-parameter-utilities.md`
- `../landscape/project-families.md`

- `Sayamame-beans/VRC_AFK_AutoMuter` - `Studied in Wave 258 as a Python VRChat OSC state mirror that watches AFK and MuteSelf parameters and emits delayed `/input/Voice` pulses only when mute state requires it`
- `03milo/InputFixer` - `Studied in Wave 258 as a C# OpenVR background input remapper that reads left-controller axes, thresholds/clamps values, zeroes on menu-like read failures, and sends VRChat OSC input axes`
- `Airbee/VRChat-OSC-Scaling` - `Studied in Wave 258 as a tiny customtkinter eye-height OSC sender that demonstrates one-parameter utility UI value with range-validation caveats`
- `koturn/OscRapidUseRight` - `Studied in Wave 258 as a WinForms global-hotkey utility that repeatedly sends raw `/input/UseRight` press/release OSC packets and ensures release on stop`
- `Hino-VRChat/vrchat-mute-toggle` - `Studied in Wave 258 as a robust tray-based mute toggle with global keyboard hook, queued OSC sender, OSC state listener, cooldown, VRChat process polling, and hook-reinstall lifecycle`
- `SourLemonJuice/VRChat-OSC-Shell` - `Studied in Wave 258 as a C CLI wrapper for VRChat chatbox and typing endpoints with shell-script examples, chatbox length guard, and rough string/portability caveats`
- `YimuQrrr/OSC_Tool` - `Studied in Wave 258 as a Python customtkinter VRChat OSC toolkit with chatbox UI, OSC scanner, address tester, MIDI-to-parameter mapping, key-file mode, log monitor, and unsafe command caveats`
- `xiaoBingge114514/VRChat-OSC-Chat-Tool` - `Studied in Wave 258 as a large Tk chatbox/status compositor with music, lyrics, BLE heart rate, Windows media, templates, history, system stats, custom endpoint settings, and monolithic/privacy caveats`
- `Ero-Cat/hr_push` - `Studied in Wave 258 as a Flutter BLE heart-rate bridge with standard Heart Rate Service parsing, stale gates, throttled HTTP/WS/MQTT/OSC outputs, chatbox templates, and biometric privacy caveats`
- `kb10uy/phorcys` - `Studied in Wave 258 as a Rust OSC and VRChat OSC workspace with OSC parser/serializer, address-pattern matching, avatar config discovery, MIDI-to-parameter tables, typed validation, and library extraction value`

## 230. Meta Quest device, camera, screenshot, streaming, and setup helpers

Primary docs:

- `../landscape/vr-projects-wave-259-meta-quest-device-camera-screenshot-streaming-and-setup-helpers.md`
- `../landscape/project-families.md`

- `t-34400/metaquest-3d-reconstruction` - `Studied in Wave 259 as a Quest Reality Capture image/depth to Open3D/COLMAP reconstruction pipeline with strict dataset layout, confidence maps, coordinate-system transforms, caches, and offline-heavy caveats`
- `kodaekwan/MetaQuest_HandTracking` - `Studied in Wave 259 as a Quest/Unity hand telemetry receiver and visualizer with fixed UDP packet parsing, Unity-to-world coordinate transforms, bone link groups, delay measurement, and adjacent UDP JPEG streaming utilities`
- `lukasmoro/cameraaccess-metaquest` - `Studied in Wave 259 as a pragmatic Quest camera workaround using Quest cast plus OBS virtual camera, Python YOLO detection, JSON-like TCP output, and Unity client consumption`
- `CHUNx3/MetaQuestBitrateRegistryEditor` - `Studied in Wave 259 as a WinForms Meta/Oculus Link registry patcher for bitrate/HEVC/DBR/sharpening values with input validation, toggle UI, restore-by-delete behavior, and registry-risk caveats`
- `t-34400/MetaQuestScreenshotLoader` - `Studied in Wave 259 as a Unity Android plugin that requests storage permission, locates latest Quest screenshots, returns bytes to C#, and loads them as textures`
- `hiroyamochi/quest-screen-caster` - `Studied in Wave 259 as a Quest-specific Flet GUI over scrcpy and ADB screenrecord with model detection, wireless ADB, crop/rotation presets, wake/proximity guards, display-id fallback, ffplay and OBS UDP output modes`
- `XargonWan/metaquest-username-changer` - `Studied in Wave 259 as a Bash/ADB username patch microtool generating JSON files, pushing them to /sdcard/, setting a global username value, and warning about save/progress reset risk`
- `SinanAkkoyun/OculusQuest2ADBAutoWifi` - `Studied in Wave 259 as a Node CLI for Quest ADB Wi-Fi onboarding with device-list parsing, USB wait loop, adb tcpip 5555, route-based IP extraction, and hardcoded Unity ADB path caveats`
- `Clept0/Unity_QuestPro_EyeTrackingRecorder` - `Studied in Wave 259 as a Unity/OVR Quest Pro eye-tracking recorder with left/right OVREyeGaze sampling, CSV schema, calibration/stabilization scenes, heatmap particles, persistent-data export, and Python gaze-error analysis`

## 231. VRChat API client, mobile companion, and pipeline surfaces

Primary docs:

- `../landscape/vr-projects-wave-260-vrchat-api-client-mobile-companion-and-pipeline-surfaces.md`
- `../landscape/project-families.md`

- `LinaTsukusu/vrchat-client` - `Studied in Wave 260 as a compact TypeScript VRChat API wrapper with module-per-domain clients, axios base URL switching, cookie-based login, shared request helpers, and old-auth/2FA caveats`
- `ccamgr/vrcp` - `Studied in Wave 260 as a mobile/desktop VRChat companion with generated API bindings, SecureStore auth/TFA state, desktop log sync, session analytics, background notification polling, and privacy/credential caveats`
- `binn/VRChat.API.Client` - `Studied in Wave 260 as a .NET fluent/generated-client wrapper with IVRChat domain APIs, builder configuration, auth cookie injection, timeout/proxy/user-agent options, named client factory, and lifetime caveats`
- `calmery/vrchat` - `Studied in Wave 260 as a compact TypeScript auth/TFA/cookie wrapper with explicit error classes, authenticated CRUD helpers, cookie parsing, and stale API-key/rate-limit caveats`
- `Ox0017/vrc` - `Studied in Wave 260 as a Java VRChat API client with request context, DTO/serializer surface, auth verification and token refresh/clear behavior, custom HttpClient boundary, and old Cloudflare/auth caveats`
- `VRCMG/vrcapi-client` - `Studied in Wave 260 as a TypeScript REST and pipeline client with endpoint modules, axios defaults, login/config fetch, WebSocket token initialization, tests, and global-cookie/security caveats`

## 232. VRChat expression menu authoring, visualization, and runtime menu helpers

Primary docs:

- `../landscape/vr-projects-wave-261-vrchat-expression-menu-authoring-visualization-and-runtime-menu-helpers.md`
- `../landscape/project-families.md`

- `nekochanfood/VRCStyledIconMaker` - `Studied in Wave 261 as an expression-menu icon pipeline with SVG-to-PNG resize/padding, PIL/OpenCV gradient recolor, shadow generation, transparent 256 canvas output, and licensing/tooling caveats`
- `nekoare/vrchat-expression-menu-visualizer` - `Studied in Wave 261 as a Unity editor expression-menu visualizer/editor with avatar descriptor selection, tree/grid view, search/stats, edit mode, ModularAvatar reflection, drag/drop hierarchy, generated marker metadata, and save/Undo caveats`
- `imagitama/vrc-menu-merger` - `Studied in Wave 261 as a menu/parameter/animator merger with 8-control limit checks, duplicate control handling, parameter type conflict errors, animator layer/parameter merging, and shallow-reference caveats`
- `zutozuto/VRChat-Menu-Creation-Tool` - `Studied in Wave 261 as an outfit/prop menu generator with avatar-specific ScriptableObject config, cloth/ornament/extra-group models, hierarchy path capture, show/hide lists, sub toggles, preview toggling, and path-drift caveats`
- `Knucklesfan/VRChatTextToMenu` - `Studied in Wave 261 as a text-to-submenu generator that writes Unity menu YAML pages, handles 8-item pages, performs GUID post-pass replacement, and carries raw-YAML/compiled-artifact caveats`
- `Lucario4LyfeYT/EasyToggle` - `Studied in Wave 261 as a one-file Unity editor toggle generator with selected object intake, animation clip creation, animator layer/transition generation, VRC parameter appending, 8-control menu pagination, and parameter/layer budget caveats`
- `AtiLion/VRCMenuUtils` - `Caveated reference in Wave 261 as a runtime VRChat quick-menu mod library with reflection-based UI manager access, pre-flow UI setup, popup/input helpers, quick-menu page/button duplication, and EAC/TOS reuse caveats`
- `CaelBun/DontOverrenderMyMenuV2` - `Caveated reference in Wave 261 as a runtime menu visibility patch with cloned UI camera, culling-mask/layer separation, Harmony patches, preference-backed quick-menu toggle, and direct-runtime-patch caveats`

## 233. VPM package index generation, Flatpak, and repository publication tooling

Primary docs:

- `../landscape/vr-projects-wave-262-vpm-package-index-generation-flatpak-and-repository-publication-tooling.md`
- `../landscape/project-families.md`

- `Limitex/voyager-vpm` - `Studied in Wave 262 as a Rust VPM package index generator with voyager.toml/lock workflow, crash-recoverable manifest+lock transactions, GitHub release asset fetch, retry/backoff, package manifest validation, SemVer/URL/hash checks, and index generation`
- `NathMorgan/vrchat-vpm` - `Studied in Wave 262 as a Flatpak-style Linux package for VRChat VPM CLI with dotnet SDK extension, pinned NuGet package source, network/host filesystem permissions, and explicit third-party/VRChat license notices`
- `tamakiii/vrchat-vpm` - `Studied in Wave 262 as a minimal static VPM listing with hand-authored index JSON and browser-generated vcc://vpm/addRepo links`
- `cuebitt/vpm` - `Studied in Wave 262 as a public VPM package repository with source manifest, GitHub package list, generated landing page, search/filter UI, package metadata modal, dependency/license display, copyable URLs, and Add-to-VCC links`

## 234. VRChat overlay, world editor, and Udon microtools

Primary docs:

- `../landscape/vr-projects-wave-263-vrchat-overlay-world-editor-and-udon-microtools.md`
- `../landscape/project-families.md`

- `o0F-0oF/vrchatoverlay` - `Studied in Wave 263 as an Avalonia transparent click-through desktop overlay that tails VRChat logs, parses OnPlayerJoined/OnPlayerLeft events, updates a player list on the UI thread, and carries busy-wait/artifact/privacy caveats`
- `kizuki1749/VRChatOverlay` - `Partially studied in Wave 263 as a historical Unity/SteamVR VRChat data overlay experiment with scene-level overlay render texture, SteamVR overlay component, overlay placement fields, bundled VRChat API client, and heavy Library/bin/obj/stale-auth caveats`
- `kxn4t/kanameliser-editor-plus` - `Studied in Wave 263 as a VPM-installable VRChat editor QoL suite with mesh info and NDMF preview support, component manager, material copier/matching, ModularAvatar material setter/swap generation, AO bounds batch UI, and missing blendshape insertion`
- `Zaknin/VRCTools` - `Studied in Wave 263 as a Unity avatar asset inspector with scanner/result model, renderer/material/texture/shader collection, texture/mesh memory estimates, missing reference detection, performance icons, report/packager states, and editor-only caveats`
- `Himakuma/VRChatWorldTools` - `Studied in Wave 263 as an SDK2-era Unity world editor microtool that wires VRC_SceneResetPosition callbacks to a selected reset button through persistent UnityEvent listeners`
- `yassann325/VRC-NetworkQueue` - `Source-light in Wave 263 as a mostly VRChat template-package/VPM listing reference with package skeleton, vpm-manifest, generated website, and follow-up need to confirm real NetworkQueue implementation`
- `PeaceKunihiro/vrchat-udon-tools` - `Studied in Wave 263 as tiny Udon world utilities with synced cycle switch, synced audio selector with optional stop slot, owner transfer, RequestSerialization, OnDeserialization state application, and delayed auto-hide behavior`

## 235. VR180 spatial video conversion, playback, camera control, and metadata utilities

Primary docs:

- `../landscape/vr-projects-wave-264-vr180-spatial-video-conversion-playback-camera-control-and-metadata-utilities.md`
- `../landscape/project-families.md`

- `34j/vr180-convert` - `Studied in Wave 264 as an OpenCV/Typer VR180 image conversion CLI with stereo pair timestamp auto-matching, split-image handling, remap map generation, AKAZE feature matching, and robust rotation calibration caveats`
- `silverqsy/VR180-Silver-Bullet` - `Studied in Wave 264 as a professional GoPro Max 2 VR180 processing pipeline with FFmpeg/PyAV/Numba/CUDA gates, GPMF gyro parsing, stabilization/export helpers, platform logging, and hardware-specific caveats`
- `nallic/convert_VR180` - `Studied in Wave 264 as a Canon dual-fisheye image converter using precomputed EXR ST maps, batch conversion, camera/lens-specific profiles, and single-resample output caveats`
- `aosoft/VR180MeshProjection` - `Studied in Wave 264 as a Unity MP4 Mesh Projection Box parser with deflate handling, big-endian binary readers, signed delta decoding, vertex/index reconstruction, and incomplete-parser caveats`
- `Vargol/VR180PhotoTools` - `Studied in Wave 264 as .NET VR180 photo conversion tools with EXIF/XMP write-back, right-eye payload extraction/embedding, layout flags, FOV options, and older-runtime caveats`
- `ganeshv/egarim` - `Studied in Wave 264 as a Lenovo Mirage VR180 camera companion with Bluetooth pairing, encrypted API transport, signed HTTP requests, capture/media/viewfinder controls, and Linux/crypto-helper caveats`
- `Verdi/VR180-Web-Player` - `Studied in Wave 264 as a browser VR180 player with WebXR capability gate, draggable 2D fallback, world-space controls, auto-hide UI, canvas button textures, and limited-format caveats`
- `steren/stereo-img` - `Studied in Wave 264 as a declarative stereo image web component with parser registry, VR180/XMP/GPano handling, embedded right-eye extraction, Three.js display modes, and browser metadata/CORS caveats`
- `kasper93/mpv360` - `Studied in Wave 264 as an mpv Lua plus GLSL projection controller with configurable 360/stereo modes, shader option updates, key bindings, OSD state, and host-player-specific caveats`

## 236. VRChat creator/user utility microtools and service dev helpers

Primary docs:

- `../landscape/vr-projects-wave-265-vrchat-creator-user-utility-microtools-and-service-dev-helpers.md`
- `../landscape/project-families.md`

- `crestudio/VRSuya-Utility` - `Studied in Wave 265 as a VRChat creator editor workbench with texture/material replacement UI, localized inspectors, PhysBone batch actions, humanoid bone/collider helpers, Undo usage, and VRC SDK caveats`
- `te260ku/VRMenuUtility` - `Source-light in Wave 265 as a Unity project skeleton with sample scene/settings but no meaningful menu utility source found in the inspected branch`
- `AkitaIkeda/VRCFileUtility` - `Studied in Wave 265 as a Spectre.Console VRChat service CLI with BasicAuth/TFA login, token XML persistence, feature selection, and credential-storage/API-age caveats`
- `thymespace/VRCPacketUtility` - `Studied in Wave 265 as a UdonSharp sequential byte-buffer helper with fixed packet storage, read/write cursor state, numeric overloads, and byte-size/bounds/endian caveats`
- `korinVR/VRDeveloperUtility` - `Studied in Wave 265 as a Windows Quest/VRChat developer companion with ADB discovery, device status, app launch/stop, screenshot/media pull, Meta service actions, and destructive-action caution`
- `namoshika/VRChatUtility_FriendListMonitor` - `Studied in Wave 265 as an AWS/Notion VRChat friend-list and desktop-log monitor with API polling, log regex event extraction, queues, and privacy/credential caveats`
- `kikookraft/vrc-utility` - `Source-light in Wave 265 as a diagram/logo-only repository with no source donor value found in the inspected branch`
- `falnen/Python-VRC-utility` - `Studied with caveats in Wave 265 as a Python OSC avatar controller with dispatcher queues, avatar JSON/log matching, per-avatar controller lifecycle, and syntax/packaging caveats`

## 237. Engine and browser XR utility packages, input, and locomotion primitives

Primary docs:

- `../landscape/vr-projects-wave-266-engine-browser-xr-utility-packages-input-and-locomotion-primitives.md`
- `../landscape/project-families.md`

- `Silverlan/PragmaVR` - `Studied in Wave 266 as a Pragma engine OpenVR utility addon with tracked-device entities, render model fallback, activity state, pose updates, haptic pulses, laser primitives, and mpv-backed texture wrapper`
- `TheUtDuong/unity-vr-utilities` - `Source-light in Wave 266 as a Unity project settings skeleton with little implementation evidence in the inspected branch`
- `loganator956/unity-vr-utilities` - `Studied in Wave 266 as a tiny Unity XR loader-specific controller prefab switch that enables Oculus-package controller objects when the Oculus loader is active`
- `nukadelic/UXRU` - `Studied in Wave 266 as a legacy Unity XR utility package with InputDevice tracker wrappers, feature caching, axis/button fallbacks, locomotion/body collider helpers, teleport reset, and transform smoothing`
- `Ponsukeee/VRInputModule` - `Studied in Wave 266 as a Unity VR input module framework with device/module/selector interfaces, click/double-click input routing, laser raycast selector, collision selector, and module handoff`
- `Sunflower-Reality-Labs/aframe-srl-utils` - `Studied in Wave 266 as an A-Frame component micro-library with Oculus Touch locomotion, two-hand grab/rotation, controller event HUDs, and equirectangular projection material components`
- `acerwebvr/Acer-VR-Utility-for-Browser-WebVR-Release` - `Source-light in Wave 266 as a historical Acer/WMR browser WebVR installer/extension release reference with no source donor found`

## 238. Source-light OpenVR/SteamVR overlay, tweak, and HUD variants

Primary docs:

- `../landscape/vr-projects-wave-267-source-light-openvr-steamvr-overlay-tweak-and-hud-variants.md`
- `../landscape/project-families.md`

- `bwmcadams/vorpal` - `Source-light in Wave 267 as a README-only Elite Dangerous VR overlay proof-of-concept intent with no implementation evidence in the inspected branch`
- `UpsilonScorpi/VRP-Overlay` - `Source-light in Wave 267 as a README-only overlay placeholder with no donor code found`
- `LapisGit/OVRTweaks` - `Partially studied in Wave 267 as a Unity/SteamVR overlay/tweak project shell whose inspected tree is mostly SteamVR vendor/sample payload and project settings rather than isolated custom overlay code`
- `JasonPKnoll/vr_overlay` - `Studied in Wave 267 as a minimal C/OpenVR/rawdraw overlay loop with overlay app initialization, function-table lookup, OpenGL texture creation, SetOverlayTexture submission, and controller-relative placement caveats`
- `pouya-codes/VR_overlay` - `Studied with caveats in Wave 267 as a Quest MR H&E plus heatmap image overlay demo with layered images, CanvasGroup opacity, controller/hand toggles, passthrough layer setup, and mixed-doc/placeholder caveats`

## 239. VR/WebXR/Godot measurement and body-distance utilities

Primary docs:

- `../landscape/vr-projects-wave-268-vr-webxr-godot-measurement-and-body-distance-utilities.md`
- `../landscape/project-families.md`

- `leetarry/VR_Measure` - `Source-light in Wave 268 as an empty measurement-intent repository with no donor evidence in the inspected branch`
- `rlaboiss/ipd-vr-measure` - `Studied in Wave 268 as a tiny Pygame visual IPD measurement helper with converging/diverging targets, key-captured extrema, pixel-to-mm transform, and hardcoded display caveats`
- `AyOhEe/Godot-VR-Measurements` - `Studied in Wave 268 as a Godot XR measurement autoload with config persistence, measurement-change signal, body-value estimation, and camera-rig tracked-offset correction`
- `NeosoftMadhuri/webxr-measure` - `Source-light in Wave 268 as an empty WebXR measurement-intent repository with no donor evidence in the inspected branch`
- `maverickjimmx/webxr-measure` - `Studied with caveats in Wave 268 as a browser/mobile inspection measurement form with device-orientation pitch coaching, camera view, point/vertical distance fields, canvas sketch/signature capture, progress gating, and hardcoded Google Apps Script submission`
- `Vedant22-marda/webxr-measurement-app` - `Studied with caveats in Wave 268 as a camera/WebRTC measurement demo with environment-camera capture, tap-to-measure overlay canvas, rough pixel-distance scaling, Flask-SocketIO signaling, STUN config, and unauthenticated default-room caveats`

## 240. OpenXR action/input command and hotkey utility bridges

Primary docs:

- `../landscape/vr-projects-wave-269-openxr-action-input-command-and-hotkey-utility-bridges.md`
- `../landscape/project-families.md`

- `art0007i/openxr-command-runner` - `Studied in Wave 269 as an OpenXR input-to-command bridge with EXTX overlay session, JSON5 command/action config, suggested bindings, bool/float input handling, single/double/long gesture detection, and shell-command safety caveats`
- `swirllyman/SimpleOpenXRInput` - `Studied in Wave 269 as a Unity OpenXR input facade with generated InputActionMap, static controller events, left/right bindings, haptic helper assignment, and static-lifecycle caveats`
- `gameflorist/uevr-touch-buttons-mapping-plugin` - `Studied in Wave 269 as a UEVR/OpenXR touch-to-keyboard plugin that maps unused touch inputs to SendInput key presses with per-key state and haptic feedback`
- `germansmedia/openxr-actions-test` - `Partially studied in Wave 269 as a raw Rust FFI OpenXR action/session test harness with proc loading, diagnostics, and checked-in target/debug artifact caveats`
- `danwillm/openxr-actions-tester` - `Studied in Wave 269 as a JSON-driven OpenXR action tester using headless extension setup, action sets, suggested bindings, bool/pose polling, and Vive tracker pose examples`
- `brycehutchings/OpenXR-Action-Code-Generator` - `Studied in Wave 269 as an OpenXR action code generator that reads action manifests and emits C/C++ helper structs for action sets, action states, subactions, action spaces, and suggested bindings`
- `tmddn0230/monado-input-system` - `Variant/reference in Wave 269 as a Monado-scale fork useful for runtime input/device boundary evidence such as xrt_device input/output structures, async hand tracking, and Xreal Air driver plumbing, but not a direct donor until unique diff is isolated`
- `Somahc/VRCVoiceHotkey` - `Studied with caveats in Wave 269 as a Windows tray hotkey bridge that installs a low-level keyboard hook, maps Ctrl+M to a `/input/Voice` OSC 0->1->0 pulse over UDP, and carries hardcoded hotkey/port and mojibake caveats`

## 241. VRChat asset, resource, package discovery, and listing surfaces

Primary docs:

- `../landscape/vr-projects-wave-270-vrchat-asset-resource-package-discovery-and-listing-surfaces.md`
- `../landscape/project-families.md`

- `vanquish3r/vrchat-asset-browser` - `Studied in Wave 270 as a static VRChat free asset database with JSON normalization, category filters, search, sort, linkified notes, preview links, theme persistence, and provenance/license caveats`
- `marklibert404-eng/Obelisk` - `Rejected/non-fit in Wave 270 as a browser VPN/proxy extension with remote-content injection behavior and no VRChat asset/tooling donor value`
- `Fraxul/VRChatResources` - `Studied in Wave 270 as VRChat creator/editor microtools with scene visibility filters, collision proxy visualization, GPU instancing checks, prefab static-flag batch edits, player trigger occupancy, and manual occlusion volumes`
- `dark-swordsman/VRCRW` - `Studied in Wave 270 as a Next/Prisma VRChat resources website with Mongo-backed resource cards, graph nodes/relations, Pixi draggable graph view, zoom interpolation, and experimental graph UX caveats`
- `tiry/nuxeo-vr-assets-browser` - `Studied in Wave 270 as an A-Frame/WebVR DAM browser backed by Nuxeo auth, thumbnail/rendition selection, asset grid, fuse cursor, animated paging, and zoom panel with old-stack credential caveats`
- `ElMoha943/valenvrc_package_listing` - `Studied in Wave 270 as a VRChat VPM package listing with source.json release arrays, website data copying, package-list-action build workflow, production-branch deploy, and CNAME support`
- `Purpzie/vpm` - `Studied in Wave 270 as a generated VPM listing page with package search, copyable URLs, vcc://vpm/addRepo deep links, package info modal, dependency/license display, and templating caveats`
- `Limitex/vrchat-package-template` - `Studied with caveats in Wave 270 as a VPM-ready VRChat package template with package metadata, VPM dependencies, Editor/Runtime asmdefs, Samples/Tests/Documentation folders, and skeletal placeholder-doc caveats`

## 242. VR whiteboard, annotation, and note-taking surfaces

Primary docs:

- `../landscape/vr-projects-wave-271-vr-whiteboard-annotation-and-note-taking-surfaces.md`
- `../landscape/project-families.md`

- `jorisvddonk/drawplane` - `Studied in Wave 271 as an A-Frame collaborative VR blackboard with controller crayon raycasts, meshline stroke accumulation, PeerJS host/client sharing, hash-based room identity, and late-join/persistence caveats`
- `liuchen1701/VR-Whiteboard` - `Studied with caveats in Wave 271 as a Unity Daydream whiteboard prototype that raycasts from controller orientation to a named board and instantiates painter marks, with GoogleVR/vendor payload caveats`
- `arcwhite/vr-whiteboard` - `Studied in Wave 271 as a Three.js/WebVR dynamic texture whiteboard with VR viewer shell, Vive controllers, barycentric hit-to-UV conversion, canvas drawing, and WebVR-era caveats`
- `yankanp/web-vr-annotation` - `Studied in Wave 271 as a WebSocket/WebRTC remote annotation bridge with VR and annotation roles, offer/answer/ICE relay, normalized click coordinates, Babylon picking rays, temporary arrows, floating text planes, and local-cert/single-client caveats`
- `MichaeliusAChapelo/VR-Annotation-Scripts` - `Studied with license caveat in Wave 271 as Unity/Oculus annotation scripts with raycast dots, dominant-hand input mapping, object transform controls, CSV import/export of positions/normals, and explicit no-permission license`
- `rafaelkuffner/VR-Annotator` - `Studied with caveats in Wave 271 as a Unity point-cloud/video annotation tool with annotation modes, manager state, point-cloud frame ingestion, skeleton playback, config parsing, and large artifact/dataset payload caveats`
- `Danda420/vr-whiteboard` - `Studied with artifact caveat in Wave 271 as a Unity texture whiteboard with board-owned Texture2D, pen raycast to textureCoord, pixel interpolation, and heavy checked-in Library/Temp/Logs/user-setting artifacts`

## 243. VR file, local asset, and VRM browser surfaces

Primary docs:

- `../landscape/vr-projects-wave-272-vr-file-local-asset-and-vrm-browser-surfaces.md`
- `../landscape/project-families.md`

- `NaruAkitsuki/VrmFileManager` - `Studied with caveats in Wave 272 as a compact Unity runtime VRM import helper using VRMImporterContext, async load, parent assignment, collider/rigidbody/animator setup, and hardcoded resource/path caveats`
- `AkiMoriDev/VRC-Files-Manager` - `Studied with caveats in Wave 272 as a Rust/egui local asset catalog with root folder selection, SQLite tags/categories/subcategories, filesystem category sync, search, and item folder packaging`
- `SirSerl/VRFileManager` - `Studied with artifact and safety caveats in Wave 272 as a Unity/SteamVR spatial file manager with file-type prefabs, cabinet shelves, search/sort, image/audio previews, copy/trash/move tools, and destructive operation risks`
- `agoetschm/vr_file_browser` - `Studied with caveats in Wave 272 as a Unity/GoogleVR spatial folder tree that expands directories into world objects, includes parent entries, and destroys unfocused branches`
- `Vode1969/vr-file-browser` - `Studied with caveats in Wave 272 as a compact Unity VR file picker with logical-drive root, hidden/system filtering, extension filters, scroll windows, collider-backed row selection, and Windows-centric path caveats`
- `hunterdquant/Seeker` - `Source-light in Wave 272 as a README-only Unity VR local-file browser intent for loading non-project local files`

## 244. VR performance tuning, FSR, and FPS helper surfaces

Primary docs:

- `../landscape/vr-projects-wave-273-vr-performance-tuning-fsr-and-fps-helper-surfaces.md`
- `../landscape/project-families.md`

- `tappi287/openvr_fsr_app` - `Studied with caveats in Wave 273 as a GUI mod manager for OpenVR FSR, foveated rendering, and VRPerfKit with Steam library scanning, selected DLL paths, original DLL backup/restore, config schema UI, settings reset, and compatibility caveats`
- `LavaGang/ML_OpenVR_FSR` - `Studied with caveats in Wave 273 as a MelonLoader OpenVR FSR wrapper that extracts bundled DLL/config resources into UserData and NativeLibrary.Loads the mod before OpenVR starts`
- `komori/vrperfkit-ocq2` - `Reference-only in Wave 273 as a binary/config VRPerfKit quality-tuning variant with no source donor evidence in the inspected branch`
- `GodotVR/godot_openvr_fps` - `Studied with caveats in Wave 273 as a Godot OpenVR FPS starter baseline with OpenVR init, 90Hz assumptions, movement vignette, viewport-to-material UI, controller state, teleport/grab/throw interaction, and legacy stack caveats`

## 245. Playspace, chaperone, boundary, and safety-awareness utilities

Primary docs:

- `../landscape/vr-projects-wave-274-playspace-chaperone-boundary-and-safety-awareness-utilities.md`
- `../landscape/project-families.md`

- `GiantSox/ChaperoneFail` - `Studied as a failure/caution reference in Wave 274 for OpenVR chaperone polling with unsafe null HmdQuad_t usage, no error handling, and minimal product logic`
- `Graicc/Echo-Vr-Playspace-Abuse-Detector` - `Studied with caveats in Wave 274 as a Unity Echo VR local-API monitor with team/player DTOs, settings JSON, velocity-integrated follower playspace capsules, bounds containment abuse detection, and operator offender list`
- `benpaddlejones/VR-Playspace` - `Partially studied with artifact caveat in Wave 274 as a Unity/MRTK playspace payload with boundary/teleport framework references, checked-in chaperone_info.vrchap, WMR controller assets, and limited original custom scripts`
- `TXST-CS7389I-Spring-2026-Group-Project/DreamGuard` - `Studied with caveats in Wave 274 as a Quest MR safety study framework with passthrough window, grid/fragment/intervention styles, Unity room experiment flow, Godot XR alpha-blend management, and CSV study logging`

## 246. VR launchers, startup orchestration, and app-library surfaces

Primary docs:

- `../landscape/vr-projects-wave-275-vr-launchers-startup-orchestration-and-app-library-surfaces.md`
- `../landscape/project-families.md`

- `ptrpaws/vrLauncher` - `Studied as a variant in Wave 275 as a Kotlin Quest hidden-system launcher with hardcoded versioned systemux:// URI catalogs, GitHub release update check, searchable spinner UI, and explicit com.oculus.vrshell MainActivity launch`
- `conexto/vrLauncher` - `Variant/fork-line in Wave 275 with the same Quest systemux:// hidden-surface launcher pattern as ptrpaws/vrLauncher`
- `blakeblair/uvrl` - `Studied in Wave 275 as a Universal VR Launcher CLI with SQLite app/config/variant/backup/profile schema, discovery catalog, scanner, config backup/apply, profile validation, dry-run mode, Steam/Flatpak/native/script launch paths, waits/delays/URLs, and failure behavior`
- `marianhlavac/immersion-vr-agent` - `Studied with caveats in Wave 275 as a WPF OpenVR background agent that initializes as VRApplication_Background, polls scene app and quit events, launches ImmersionVR tutorial/launcher processes, and tracks status`
- `dewaffled/vr-launcher` - `Studied with safety caveats in Wave 275 as a self-elevating PowerShell micro-utility that enables or disables Windows Mixed Reality Holographic PnP devices`
- `Paladinleeds/PaladinVR-Launcher` - `Studied with caveats in Wave 275 as an archived UWP Cliff House tile that launches SteamVR via steam://rungameid/250820 and exits`
- `keithbphillips/vr-pinball-launcher` - `Studied with caveats in Wave 275 as a Unity VR app-library carousel for Visual Pinball with JSON config, table scanner, wheel image matching, world-space menu, external process launch/focus, XR stop/restart, and return-to-menu lifecycle`
- `CactusVRStudios/Lambda1VR_Launcher` - `Studied with artifact caveat in Wave 275 as a Quest Unity launcher that detects /sdcard/xash game folders, writes commandline.txt, saves custom commands, launches com.drbeef.lambda1vr via Android PackageManager, and falls back to SideQuest`
- `Bluscream/VRChatLauncher` - `Studied with deprecation caveats in Wave 275 as a historical VRChat launcher/workbench with argument parsing, vrchat:// URI handling, registry install/check, IPC singleton handoff, mod checks, INI config, and clipboard/process side effects`

## 247. WebXR museum, guided-tour, and artifact-gallery surfaces

Primary docs:

- `../landscape/vr-projects-wave-276-webxr-museum-guided-tour-and-artifact-gallery-surfaces.md`
- `../landscape/project-families.md`

- `artificialmuseum/sandbox` - `Studied with remote-engine caveat in Wave 276 as a compact artifact preview sandbox with artifact.js metadata, CustomScene lifecycle hooks, engine injection, skybox/model paths, and tick-driven model behavior`
- `torashad99/xr-photo-museum` - `Studied in Wave 276 as a multiplayer WebXR photo museum with spatial frame slots, parallax portal frames, Socket.IO room state, annotations, strokes, voice notes, generated world polling, and privacy/API caveats`
- `TashaGandevia/GamingMuseum_WebXR` - `Studied with engine caveats in Wave 276 as a Wonderland/WebXR gaming museum with console metadata records, CanvasUI panels, cursor events, haptic feedback, spatial sounds, scroll/input UI, and generated dependency caveats`
- `rohanbk10/Museum` - `Studied in Wave 276 as a museum SPA with normalized collection schema, annotations, hash router cleanup, MindAR image tracking, WebXR hit-test placement, desktop 3D viewer, CSS2D pins, and dispose discipline`
- `Shree-svg/Neural_Nexus-Virtual_3D_Museum` - `Source-light in Wave 276 as a minimal atmospheric virtual museum shell useful mainly for product framing and scene mood`
- `UMN-VR/UMN-VR-Quest-2-App` - `Artifact-heavy reference in Wave 276 as a photogrammetry museum proof-of-concept with checked-in APK/Unity cache payload and limited clean source donor signal`

## 248. VR rehabilitation, therapy, and treatment-loop prototypes

Primary docs:

- `../landscape/vr-projects-wave-277-vr-rehabilitation-therapy-and-treatment-loop-prototypes.md`
- `../landscape/project-families.md`

- `mahmoud1yaser/VR-Therapist-Virtual-Mental-Health-Experience` - `Studied with medical/privacy caveats in Wave 277 as a Unity microphone-to-Flask voice loop with local wav upload, polling, STT, LLM response, AWS Polly TTS, avatar playback, and unsafe clinical/auth caveats`
- `jessieyang0320/VHab` - `Partially studied in Wave 277 as a legacy web hand-rehab microgame suite with finger-angle, pinch-strength, grab-strength, selector, button, and whack-a-mole exercise controllers`
- `reboot-corp/Reboot-Hackathon` - `Studied with prototype caveats in Wave 277 as a neurofeedback rehab prototype with LSL StreamInlet EEG ingress, BrainFlow/math references, Unity concentration ring fill, local serialization, and validation caveats`
- `EyalMaoz/Pinch_Rehabilitation_VR_Personalized_Treatment` - `Studied in Wave 277 as a personalized pinch rehabilitation pipeline with OVR hand confidence, pinch classification, calibration steps, patient motion-range persistence, treatment plans, adaptive difficulty, and task object generation`
- `TheBananaGuy/rehab-in-vr` - `Studied with source-light caveats in Wave 277 as an educational Leap/Oculus rehab prototype around sustained grab-and-hold frog targets`
- `pcallej/ADHD-Unity` - `Studied with legacy caveats in Wave 277 as a GoogleVR attention-training project with train/path-following exercises, target counters, and vendor payload caveats`
- `WestonBDev/Modules-for-Burn-Injury-Rehabilitation` - `Studied in Wave 277 as modular Unity rehab components with prolonged interaction trigger boxes, XR haptic intensity/frequency controls, controller-side selection, and CSV movement logging`
- `songer1993/vr-cat-bath-study` - `Studied in Wave 277 as a gamified hand-strength rehab study with cat-care tasks, grasp/pinch strength indicators, timers, food/hair-dryer interactions, and optional capture hooks`
- `harr-data/Simple-VR-Rehab` - `Source-light in Wave 277 as a browser rehab metric reference around target tracking, reflex response, memory sequence tasks, HUD metrics, stability index, and latency/deviation framing`

## 249. Camera-to-VRM/avatar retargeting and virtual-camera output

Primary docs:

- `../landscape/vr-projects-wave-278-camera-to-vrm-avatar-retargeting-and-virtual-camera-output.md`
- `../landscape/project-families.md`

- `Kariaro/VRigUnity` - `Studied with side-effect caveats in Wave 278 as a Unity camera/avatar output tool with camera capture settings, mirrored output, visualization/annotation modules, EVMC/VMC periphery, thread helper, and Windows virtual-camera install scripts`
- `creativeIKEP/HolisticMotionCapture` - `Studied in Wave 278 as a camera-to-VRM retargeting package with MediaPipe-style holistic pipeline, max-FPS throttling, pose/hand/face renderers, score thresholds, low-pass filters, upper-body mode, VRM blendshapes, gaze, and reset behavior`
- `zacharyguan/VRigUnity` - `Variant-only in Wave 278 as a fork/lineage node of Kariaro/VRigUnity without independent donor promotion in this pass`

## 250. Remote, cloud, WebRTC VR streaming, and live SDK surfaces

Primary docs:

- `../landscape/vr-projects-wave-279-remote-cloud-webrtc-vr-streaming-and-live-sdk-surfaces.md`
- `../landscape/project-families.md`

- `PierfrancescoSoffritti/RemoteVR_UnityServer` - `Studied with legacy caveats in Wave 279 as a Unity remote VR server with TCP/UDP abstraction, player lifecycle, gyro/touch input, initial rotation offset, client resolution negotiation, and rendered-image downlink`
- `PierfrancescoSoffritti/RemoteVR_AndroidClient` - `Studied with legacy caveats in Wave 279 as an Android remote VR client with calibrated gyroscope quaternion integration, UDP session init, resolution handshake, image receive loop, and touch/gyro packet uplink`
- `TheAnonymousMan/WebRTC-VR-Server` - `Studied in Wave 279 as a Unity-hosted WebRTC server with in-process WebSocket signaling, camera CaptureStreamTrack, peer connection, buffered ICE candidates, answer creation, data channel, and main-thread dispatch`
- `GitEducaverse2024/com.educa360.live` - `Studied in Wave 279 as a Unity live-streaming SDK with LiveStreamManager, config asset validation, backend interface, WebGL/native selection, setup wizard, FPS monitor, Quest capture workaround, kill-switch settings, and portal dependency caveats`
- `shinyoshiaki/quest-view` - `Studied with caveats in Wave 279 as a Quest WebRTC video receiver with Android peer-factory bridge, WebSocket signaling, I420 frame queue, YUV-to-RGBA texture conversion, data channel, and auth/signaling caveats`
- `jlin3/substream-sdk` - `Studied with scope caveats in Wave 279 as a cloud streaming SDK/control plane with authenticated stream creation, platform whitelist, IVS stage allocation/release, WHIP provisioning, webhooks, recording/highlight architecture, and Unity streaming script families`
- `kasimmj/vrcollab` - `Source-light architecture reference in Wave 279 as a VR collaboration server sketch with pose-frame protocol, docker services, SFU/spatial-audio claims, and code-depth caveats`
- `jakubtom/UnityRenderStreaming_StereoWebcam` - `README-only reference in Wave 279 as a stereo webcam streaming concept using Unity Render Streaming for phone-in-headset viewing`

## 251. VR training, assessment, scenario grading, and skill-practice prototypes

Primary docs:

- `../landscape/vr-projects-wave-280-vr-training-assessment-scenario-grading-and-skill-practice-prototypes.md`
- `../landscape/project-families.md`

- `cepdnaclk/e16-4yp-Virtual-Patient-Simulator-for-Skill-Training-in-Dentistry` - `Studied in Wave 280 as a dental virtual-patient simulator with multi-domain score reducer, score actions, Firebase-backed feedback/evaluation flow, and medical/privacy caveats`
- `sharnajh/VR_CPR_Training` - `Source-light in Wave 280 as a Unity CPR training shell with only basic movement/crouch logic visible in inspected source`
- `Carolina-Riddick/Parkinson-App-Virtual-Reality` - `Studied with medical caveats in Wave 280 as a Unity XR motor-task prototype with socket-count task gates, next-level unlocks, and force-launch interaction`
- `SLVNE/VRNurseTrainingProgram` - `Studied with caveats in Wave 280 as a nursing procedure auto-grader with blood-pressure and lung-answer verdict UI`
- `DarkSmiling/OpenVRTraining` - `Asset-heavy reference in Wave 280 as an Unreal/SteamVR training scene with VRExpansion/SteamVR bindings and limited readable custom code`
- `pspacewoman/Emergency-Quest-VR-Game-MasterThesis` - `README/thesis reference with license caveat in Wave 280 as a Quest first-aid scenario around checklists, hazards, NPC/audio, score, and feedback`
- `KosmidisMixalis/ViRtus-A-Virtual-Reality-Application-for-Training-and-Performance-Analysis` - `Source-light methodology reference in Wave 280 as a VR training study with metric export and Python statistical analysis scripts`
- `E5H4/m.e.-simulator` - `Studied in Wave 280 as a Unity medical emergency simulator with score/timer/grade panels, difficulty branch, AED pad prerequisites, and hardcoded scene caveats`
- `Hannah-Ashna/VRWalkin-UE-Plugin` - `Blueprint-heavy reference in Wave 280 as a UE 4.27 locomotion-training plugin packaging multiple travel paradigms for independent-travel training`
- `hasanhaswary/CSVRSystem` - `Studied in Wave 280 as a crime-scene VR training system with Firebase auth, case selection, and per-user Firestore notes`
- `37743/VR-Welding-101` - `Studied with caveats in Wave 280 as a welding skill-practice prototype with configurable joint push-button toggles and AI-feedback claims not visible in inspected source`
- `MPL-projects/vr-aim-study` - `Studied in Wave 280 as a Quest throwing-accuracy study with distance-based scoring, target feedback, and ball reset loop`
- `glenbo111/webxr-medical-training-simulation` - `Source-light in Wave 280 as a one-file A-Frame medical scenario skeleton with minimal interaction`
- `byebyenin10dog/KHXR` - `Studied with artifact caveat in Wave 280 as a Unity WebXR browser shell with session lifecycle, capability callbacks, controller/gamepad packets, and telemetry caveats`
- `fxnode2000/webxr.github.io` - `Skipped/no-source in Wave 280 because the inspected branch had no readable repository content`

## 252. XR hand input, bare-hand manipulation, and hand-pose transport experiments

Primary docs:

- `../landscape/vr-projects-wave-281-xr-hand-input-bare-hand-manipulation-and-hand-pose-transport-experiments.md`
- `../landscape/project-families.md`

- `Mystfit/NectoXRTemplate` - `Studied with dependency caveats in Wave 281 as an Unreal OpenXR hand template with hand-tracked VR character setup, OpenXR hand keypoints, LiveLink skeleton output, and replicated-avatar boundaries`
- `Clyfr/BURG-v2` - `Studied with sample caveats in Wave 281 as a Unity XR Hands sample aggregation with One Euro filtering, pinch midpoint proxy, and poke gesture detection`
- `reubenlavin08/spindle-whorl-ar` - `Studied in Wave 281 as a Quest passthrough AR object-gallery prototype with XR Hands pinch-grab hysteresis, tracking-loss release, hand visualization, floor-origin retry, procedural biconvex disc mesh, and cultural-data caveats`
- `Zer0pa/ZPE-XR` - `Studied with runtime caveats in Wave 281 as a Python/Rust hand-pose transport codec with keyframe/delta packets, CRC validation, replay/recovery simulation, and explicit benchmark caveats`

## 253. Spatial audio, acoustic accessibility, and voice presence surfaces

Primary docs:

- `../landscape/vr-projects-wave-282-spatial-audio-acoustic-accessibility-and-voice-presence-surfaces.md`
- `../landscape/project-families.md`

- `nikita-s-nair/Spatial-Audio-VR` - `Studied in Wave 282 as a WebXR/Three.js positional audio starter with listener setup, speaker GLTF, distance-model config, XR session audio-context resume, and iwer fallback`
- `rvedantv/Spatial-Audio-VR` - `Source-light audio reference in Wave 282 as a BRIR convolution preprocessing workflow for binaural spatial audio assets`
- `xavieraustralia/aioptimisationlabvirtual` - `Studied with scope caveats in Wave 282 as a web voice-presence surface with WebRTC peer audio, WebSocket signaling, AnalyserNode VAD, speaking-state broadcasts, and microphone/privacy caveats`
- `lanzhang76/artEcho` - `Studied in Wave 282 as an acoustic accessibility museum with onboarding narration, positional chamber/object sounds, echo samples, object descriptions, hint cadence, audio interruption/restoration, and canvas accessibility attributes`
- `Devanik21/Hackathon-VR-180-Immersive-Experience` - `Non-fit/source-light side node in Wave 282 as a Streamlit 2D-to-VR180 depth-conversion sketch discovered during audio search, not promoted as an audio donor`

## 254. XR study recording, replay, analysis, and multimodal training data

Primary docs:

- `../landscape/vr-projects-wave-283-xr-study-recording-replay-analysis-and-multimodal-training-data.md`
- `../landscape/project-families.md`

- `vrsys/Recording-And-Analysis-Plugin` - `Studied in Wave 283 as a native cross-platform XR recording/replay plugin with recorder-ID endpoints, transform/sound/generic channels, scene metadata, ring buffers, object-ID remapping, and composable analysis queries`
- `vrsys/Immersive-Study-Analyzer` - `Studied in Wave 283 as a Unity immersive replay/analysis layer with recorder controller, transform recorder, analysis UI, annotation hooks, radial menu/time controls, Photon sync, and plugin coupling caveats`
- `mvidaldp/wd_ride` - `Studied with artifact and privacy caveats in Wave 283 as a multimodal VR city-ride study with Tobii eye/head tracking, gaze and nose-vector raycast hits, fixed LSL streams, protobuf IO, and replay visualization`
- `leonkoech/SignWhisper` - `Studied with prototype caveats in Wave 283 as an ASL/hand-pose training surface with Leap VectorHand byte transport over Unity Netcode, avatar head/body sync, and incomplete scoring/persistence evidence`

## 255. VRCFaceTracking face/eye tracking modules, templates, and receiver bridges

Primary docs:

- `../landscape/vr-projects-wave-284-vrcfacetracking-face-eye-tracking-modules-templates-and-receiver-bridges.md`
- `../landscape/project-families.md`

- `VRCFaceTracking/docs` - `Studied in Wave 284 as VRCFT compatibility/setup taxonomy covering hardware, addons, desktop/VR pages, and interface documentation boundaries`
- `guygodin/VirtualDesktop.VRCFaceTracking` - `Studied in Wave 284 as a Virtual Desktop VRCFT module using memory-mapped face state, event wait handles, tracking-state detection, and unified expression mapping`
- `Adjerry91/VRCFaceTracking-Templates` - `Studied with asset-heavy caveats in Wave 284 as a VPM/avatar preparation template set for ARKit and Unified Expressions animation/parameter layout`
- `hazre/VRCFTReceiver` - `Studied in Wave 284 as a VRCFT OSC receiver with FT/v2 path parsing, avatar parameter request, UDP listen loop, and lazy ValueStream creation`
- `regzo2/BinaryParameterTool` - `Studied in Wave 284 as a Unity editor parameter-generation helper with VRChat expression-cost guards, duplicate checks, animator controller parameters, and add/remove flows`
- `200Tigersbloxed/VRCFTOmniceptModule` - `Studied in Wave 284 as an HP Omnicept eye-only VRCFT module with Glia subscription, eye data conversion, smoothing worker lifecycle, and vendor SDK caveats`
- `lonelyicer/VRCFTPicoModule` - `Studied in Wave 284 as a PICO VRCFT module with dual UDP ports, legacy packet support, disable flags, localization, updater helper, and partial eye/expression support`
- `ghostiam/VRCFTTobiiAdvanced` - `Studied in Wave 284 as a Tobii/BrokenEye VRCFT eye module with API fallback, channel handoff, low-pass filtering, pupil/openness handling, and config defaults`
- `kusomaigo/VRCFaceTracking-LiveLink` - `Studied in Wave 284 as an Apple ARKit/LiveLink UDP VRCFT module with configurable port, first-packet wait, and ARKit-to-Unified expression mapping`
- `xverse-engine/XVRFaceTracking` - `Studied with prototype caveats in Wave 284 as DIY ESP32/camera plus Python ONNX mouth tracking with PyQt tuning UI, One Euro smoothing, and OSC blendshape output`

## 256. bHaptics wearable haptics routers, simulator bridges, and Android service boundaries

Primary docs:

- `../landscape/vr-projects-wave-285-bhaptics-wearable-haptics-routers-simulator-bridges-and-android-service-boundaries.md`
- `../landscape/project-families.md`

- `cercata/pysim2bhap` - `Studied in Wave 285 as a simulator telemetry to bHaptics router with tact registration, intensity/duration scaling, flight/car thresholds, and Tk/config presets`
- `HerpDerpinstine/bHapticsLib` - `Studied in Wave 285 as a C# bHaptics WebSocket client with register/submit queues, pattern cache, reconnect policy, device status reads, frame/dot/key APIs, and stop controls`
- `NovaVoidHowl/VRCBhapticsIntegration` - `Studied with modding caveats in Wave 285 as a VRChat avatar-to-bHaptics integration using avatar cameras/render textures, motor pixel parsing, MelonMod/Harmony hooks, and Unity setup helpers`
- `Team-Beef-Studios/HapticsService` - `Studied in Wave 285 as an Android/Quest bound haptic service boundary with AIDL hapticEvent, update, stop, frame tick, enable/disable calls, and client binding helpers`
- `SeekND/YAWVR-and-BHaptics-addons` - `Studied with script caveats in Wave 285 as keyboard/mouse/joystick/simulator haptics scripts using direct bHaptics dot submissions and user-tuned intensity`
- `bhaptics/TactUnrealEngine4` - `Studied with blueprint-heavy caveats in Wave 285 as an Unreal bHaptics package reference for pairing UI, device visualization, feedback effect assets, and Android UI panels`

## 257. Tilt Brush/Open Brush creative asset pipelines, AR/Web display, and tilt parsers

Primary docs:

- `../landscape/vr-projects-wave-286-tilt-brush-open-brush-creative-asset-pipelines-ar-web-display-and-tilt-parsers.md`
- `../landscape/project-families.md`

- `weeeBox/TiltBrushFile` - `Studied in Wave 286 as a Unity/C# tilt parser/writer with binary header, zipped sketch payload, thumbnail, metadata, brush strokes, control points, clone, and write paths`
- `MrMMu/tiltbrushfbxexport` - `Studied with legacy caveats in Wave 286 as a Tilt Brush JSON-to-FBX exporter preserving brush grouping, vertex colors, normals, UVs, tangents, materials, and sidecar metadata`
- `FusedVR/ARKitTiltBrush` - `Studied in Wave 286 as an ARKit drawing baseline with ARFrame camera-position sampling, particle-system strokes, color/reset modes, and point-distance thresholds`
- `dogtownmedia/ARKit-SceneKit-Paint-Tiltbrush-Demo` - `Studied in Wave 286 as a SceneKit AR drawing baseline with ARSCNView line nodes, color picker, world-tracking session, and interruption hooks`
- `thijsvb/TiltBrushDisplay` - `Studied in Wave 286 as a tiny Processing OBJ/shader viewer for exported Tilt Brush geometry with rotation and axis display`
- `arodic/polygone.art` - `Studied as archive/provenance reference in Wave 286 for salvaged Google Poly assets, CC-BY framing, torrent/split downloads, and public preservation language`
- `keijiro/Forestica` - `Studied with asset-heavy caveats in Wave 286 as a Unity Tilt Brush scene render/material/postprocess reference for preserving brush-art look`
- `PushyPixels/WebVR-Poly-Framework` - `Studied with package/dead-service caveats in Wave 286 as a Unity WebVR/Poly asset browser and presentation framework reference`

## 258. Gaussian splat XR Unity viewers, VR forks, and external render bus surfaces

Primary docs:

- `../landscape/vr-projects-wave-287-gaussian-splat-xr-unity-viewers-vr-forks-and-external-render-bus-surfaces.md`
- `../landscape/project-families.md`

- `wuyize25/gsplat-unity` - `Studied in Wave 287 as a Unity Gaussian splat package with ply/spz ScriptedImporter, source-coordinate conversion, cache keys, renderer registration, GPU resources, sorting, cutouts, and global draw support`
- `dylanebert/UnityGaussianSplatting` - `Studied in Wave 287 as a compact Unity splat importer/data-binder baseline with ScriptedImporter-created SplatData and minimal starter shape`
- `HiFi-Human/DynGsplat-unity` - `Studied in Wave 287 as a dynamic Gaussian splat runtime with Addressables block streaming, frame assets, sliding-window loads, compute updates, codebooks, and resource cleanup`
- `Enndee/Splatviewer_VR` - `Studied in Wave 287 as a VR Gaussian splat viewer with runtime ply/spz/spx/sog loading, OpenXR controls, file browser/favorites, movie mode, desktop fallback, and file associations`
- `ninjamode/Unity-VR-Gaussian-Splatting` - `Studied with fork/sample caveats in Wave 287 as a VR/URP Gaussian splat project combining package runtime/editor code, XR Interaction Toolkit samples, and scene scripts`
- `ptc-lexvandersluijs/Unity3DGS_VR` - `Studied with fork/sample caveats in Wave 287 as a BIRP/VR Gaussian splat project with package runtime/editor layout, XR Interaction Toolkit samples, and input side nodes`
- `nigelhartman/worldlabs_unity` - `Studied in Wave 287 as a generated-world editor/import tool with WorldLabs API UI, prompt/image/video inputs, spz/ply import, compression quality, scene placement, and env loader`
- `RockyXu66/splatbus` - `Studied in Wave 287 as an external render bus with Python OpenGL client, Unity native plugin, CUDA IPC, socket/JSON handshake, color/depth buffer sharing, camera-pose messages, and cleanup caveats`
- `roth-hex-lab/Multi-Layer-Anatomy-GS-Unity-Rendering` - `Studied with specialization caveats in Wave 287 as a domain-specific multi-layer anatomy Gaussian splat rendering reference`

## 259. MRUK room-aware mixed reality scene data and panel placement utilities

Primary docs:

- `../landscape/vr-projects-wave-288-mruk-room-aware-mixed-reality-scene-data-and-panel-placement-utilities.md`
- `../landscape/project-families.md`

- `oculus-samples/Unity-MRUtilityKitSample` - `Studied in Wave 288 as an official MRUK Unity sample set with environment raycasts, panel magnetism, world-lock toggles, wall anchors, QR tracking, room mesh/navmesh, virtual-home, keyboard, relighting, and scene-aware utility behaviors`
- `dilmerv/MixedRealityUtilityKitDemos` - `Studied in Wave 288 as a compact MRUK demo/debug surface with RoomCreatedEvent binding, current-room storage, wall-anchor prefab toggling, and spatial logger feedback`
- `oculus-samples/Unreal-MRUtilityKitSample` - `Studied with blueprint/content caveats in Wave 288 as an Unreal MRUK scene-data sample with VR pawn/game-state C++ entry points and blueprint-heavy scene decoration/widgets`
- `VeksCZ/XRHouseDesignExport` - `Studied with artifact-heavy caveats in Wave 288 as an MRUK room export utility with scene sync, room filtering, semantic labels, JSON dumps, reports, OBJ/GLB model export, per-room breakdowns, and in-headset menu/logging`
- `Luizfelm/FlightFollower` - `Studied in Wave 288 as a small MR path-following utility with XR controller line drawing and checkpoint spawning along sampled LineRenderer paths`

## 260. WebXR spatial UI primitives, mesh text layout, and fullstack UI shells

Primary docs:

- `../landscape/vr-projects-wave-289-webxr-spatial-ui-primitives-mesh-text-layout-and-fullstack-ui-shells.md`
- `../landscape/project-families.md`

- `NikLever/CanvasUI` - `Studied in Wave 289 as a Three.js WebXR CanvasTexture panel system with offscreen canvas, plane mesh, config/content schema, controller raycasts, UV-to-pixel hit testing, hover/select/scroll states, keyboard, sliders, color picker, and texture invalidation`
- `felixmariotto/three-mesh-ui` - `Studied in Wave 289 as a mesh-native Three.js UI layout library with Object3D blocks/text, MSDF fonts, nested layout, keyboard examples, and deferred parsing/layout/inner updates through UpdateManager`
- `Retchut/aframe-mesh-ui-components` - `Studied in Wave 289 as an A-Frame wrapper around three-mesh-ui blocks/text with declarative schemas, recursive child registration, and tick-driven update calls`
- `shiveshjadon/webxr-fullstack-boilerplate` - `Studied with boilerplate caveats in Wave 289 as a React/Three/WebXR starter with VRButton, VRControl, raycast UI states, ThreeMeshUI buttons, and Socket.IO button events`

## 261. VR assembly, maintenance, and procedure training workflows

Primary docs:

- `../landscape/vr-projects-wave-290-vr-assembly-maintenance-and-procedure-training-workflows.md`
- `../landscape/project-families.md`

- `T0riU/VR-Assembly-Manager` - `Studied in Wave 290 as a strong assembly donor with XRGrabInteractable parts, attach point IDs, socket compatibility, closest-candidate snap, forced hand release, attached/free/held states, visual affordances, JSON save/load, thumbnails, stats, and prefab registry`
- `carlosMoragon/VR-Assembly-Simulator` - `Studied with vendor/asset caveats in Wave 290 as a procedure assembly training scenario with score decay, error penalties, final score display, matching-tag placement, and temporary grab disabling`
- `NopparatSang/SCGVR2` - `Studied with SDK-heavy caveats in Wave 290 as a maintenance workflow with process steps, tool validation, screw/bolt/locknut animations, active/deactive object gates, timers, rankings, OVR tool panels, and tool staging`
- `JonyHM/VRDoorAssembly` - `Studied in Wave 290 as a companion scoreboard/admin reference with Angular score table, route-resolved score response, and GET/POST score service`
- `lintglitch/vr-assembly` - `Source-light in Wave 290 as an assembly environment/asset comparison node with limited clean custom logic visible in this pass`
- `nyu-lgcoop/VRTrainingUnity` - `Source-light in Wave 290 as a legacy Unity training shell where inspected source was mostly Standard Assets rather than donor-quality training logic`
- `White-H-21/VR-assembly-system` - `Skipped/no-source in Wave 290 because the local study clone had no usable checked-out repository content`

## 262. Mixed reality robotics, ROS/Unity, URDF/CAD, and digital twin control surfaces

Primary docs:

- `../landscape/vr-projects-wave-291-mixed-reality-robotics-ros-unity-urdf-cad-and-digital-twin-control-surfaces.md`
- `../landscape/project-families.md`

- `2000222/Robotic-Arm-IK-in-Unity` - `Studied in Wave 291 as a minimal Unity robotic-arm IK baseline with per-joint axes, start offsets, forward kinematics, finite-difference partial gradients, and local Euler angle updates`
- `sabeaussan/ROS_Unity` - `Studied in Wave 291 as a ROS-to-Unity bridge with UnitySubscriber Float32MultiArray joint angles, per-axis rotation flags, stepped angle interpolation, ROS launch files, and reacher scripts`
- `KosmosisDire/UrdfUnityToolkit` - `Studied in Wave 291 as a Unity URDF/Xacro import pipeline with editor menu import/parse/clean actions, Xacro conversion, URDFBuilder entry point, and typed XML attribute helpers`
- `bernhard-42/three-cad-viewer` - `Studied in Wave 291 as a web CAD/digital-twin viewer with hierarchical Shapes tree, part IDs, transforms, bounding boxes, face/edge visibility states, tessellated geometry arrays, and viewer display options`
- `KKallas/manual-override` - `Studied in Wave 291 as a server-authoritative robot-control architecture with game server, vision service, robot drivers, referee GUI, calibration frames, WebSocket/HTTP plans, SSE live-state helper, and Dobot TCP joint driver with feedback parsing and acceleration-limited ServoJ setpoints`
- `mortenterhart/mixed-reality-robot-control` - `Studied in Wave 291 as an MR digital twin command surface with MQTT store-in/store-out commands, shelf selection, button color state, local robot animation triggers, and command UI caveats`
- `MixedRealityETHZ/Mixed-Reality-Robotic-Grasp-Teacher` - `Studied with prototype caveats in Wave 291 as an MRTK hand trajectory/grasp teacher with pinch-threshold sampling, trajectory spheres, position lists, countdown text, and reset behavior`
- `giuliano-97/mixed_reality_robots` - `Studied with vendor-heavy caveats in Wave 291 as a ROS/MRTK robotics integration reference with Jackal/Panda URDF and launch files, ROS cmd_vel publisher baseline, and Unity mixed-reality shell overlap`

## 263. VR comfort tunnelling, cybersickness scoring, and comfort profile utilities

Primary docs:

- `../landscape/vr-projects-wave-292-vr-comfort-tunnelling-cybersickness-scoring-and-comfort-profile-utilities.md`
- `../landscape/project-families.md`

- `sigtrapgames/VrTunnellingPro-Unity` - `Studied in Wave 292 as a Unity tunnelling comfort plugin with motion-aware vignette/cage/window/portal modes, presets, masking, shaders, mobile variants, and runtime controls`
- `ExtendRealityLtd/Tilia.Visuals.Vignette.Unity` - `Studied in Wave 292 as a Tilia/VRTK vignette prefab with facade/configurator split, velocity and angular-velocity sources, smoothing, magnitude limits, and prefab package boundaries`
- `BryanRalston/vr-comfort-framework` - `Studied in Wave 292 as a comfort-score and cybersickness state-machine reference with locomotion/angular-velocity/frame-drop/session-duration scoring, fold/recovery hysteresis, and post-recovery conservative window`
- `Skyfall1235/VR-Player-Comfort-Profile-SDK` - `Studied in Wave 292 as a shared player comfort profile SDK with JSON movement, turning, vignette, subtitles, haptics, grip, and trigger/grip swap preferences`
- `KRASAV4EK/BP_Foveated-Rendering-In-PC-VR` - `Studied with asset-heavy caveats in Wave 292 as a foveated rendering comfort/perception reference with URP VRS render feature, ETFR/level/mask toggles, gaze marker, and user-study framing`
- `melisgokalp/Cybersickness` - `Source-light in Wave 292 as a comfort experiment search candidate whose local clone did not expose a usable source tree`

## 264. Eye-tracking recorders, accuracy tests, heatmaps, and gaze analytics

Primary docs:

- `../landscape/vr-projects-wave-293-eye-tracking-recorders-accuracy-tests-heatmaps-and-gaze-analytics.md`
- `../landscape/project-families.md`

- `med-material/VREyeTrackingAccuracyTest` - `Studied in Wave 293 as a Pupil Labs accuracy/FOV test harness with target workflows, gaze path capture, 50 ms logging loop, CSV writer, PlayerPrefs display settings, FOV calibration, and Pupil plugin payload`
- `RealBrandonChen/Unity-Eyetracking-Heatmap` - `Studied in Wave 293 as a Pupil Labs heatmap and recording shell with request/subscription controllers, gaze/frame listeners, recording controls, calibration scripts, and visualization components`
- `simpleOmnia/sXR` - `Studied in Wave 293 as an experiment framework with SRanipal gaze recording, tagged eyetracker file output, screen/gaze fixation fields, pupil/openness data, dataframe helper, replay, and settings infrastructure`
- `FoveHMD/UnityPlugin` - `Studied in Wave 293 as a FOVE Unity SDK reference with gaze recorder export settings, recording sync modes, coordinate spaces, gazable object registration, calibration/test scenes, and project checks`
- `FoveHMD/FoveUnitySample` - `Studied in Wave 293 as a minimal FOVE gaze interaction sample with per-eye ray access, combined-gaze fallback, raycast cursor placement, and sample-scene behavior`
- `n3urovirtual/PicoXR_EyeTracking_Demo` - `Studied with source caveats in Wave 293 as a PICO gaze-selection/TTS product reference whose README indicates app source was not released; visible code is mostly PICO SDK eye-tracking API surface`
- `VR-HCI-Group/Unity-VR-EyeTracking` - `Studied in Wave 293 as a Vive SRanipal recorder with callback registration, combined/left/right gaze rays, openness, pupil diameter/position, gaze coordinates, and TXT/CSV output`
- `caseycotes-turpin/EyeTrackingAnalysis` - `Source-light in Wave 293 as a README-only analysis search candidate and duplicate-search marker`

## 265. WebXR hand-tracking primitives, emulation, MIDI, and hand-driven utilities

Primary docs:

- `../landscape/vr-projects-wave-294-webxr-hand-tracking-primitives-emulation-midi-and-hand-driven-utilities.md`
- `../landscape/project-families.md`

- `AdaRoseCannon/handy-work` - `Studied in Wave 294 as a worker-backed WebXR hand pose library with pose registry, A-Frame handy controls, controller fallback, fuse timing, joint normalization, and magnetic hand constraints`
- `mrdoob/webxr-webcam-emulator` - `Studied in Wave 294 as a Chrome extension WebXR webcam emulator with MediaPipe face/hand landmarkers, injected polyfill, head/hand state, smoothing, depth scale, and popup toggles`
- `fcor/hand-tracking-butane` - `Studied in Wave 294 as a WebXR hand physics demo with Three.js hands, Cannon world, hand sphere bodies, atom bodies, molecular constraints, and hand-object interaction framing`
- `miguelppais/airbender-webxr-midi` - `Studied in Wave 294 as a WebXR hand-to-MIDI control surface with spatial setup panel, MIDI output scan, channel selector, preset grid, mapping UI, LED status, and Web MIDI/WebXR caveats`
- `RichardMeng1/custom-hand-gaze-webxr` - `Studied in Wave 294 as a hand/gaze WebXR utility suite with handedness ordering, palm-up menu, right-index poke selection, gaze ray extraction, game modes, floating back button, and WSS relay test`
- `tatta-chotdog/webxr-hands-starter` - `Studied in Wave 294 as a minimal WebXR hand starter with scene/controller/hand manager split, XRHand joint sampling, wrist-distance thresholds, and simple gesture classification`

## 266. VR calibration overlays, rig alignment, and tracking-space helpers

Primary docs:

- `../landscape/vr-projects-wave-295-vr-calibration-overlays-rig-alignment-and-tracking-space-helpers.md`
- `../landscape/project-families.md`

- `mika-sandbox/Unity-VRIK-Calibration` - `Studied in Wave 295 as a SteamVR/VRIK avatar calibration baseline with avatar scale from player height/view position, HMD assignment, active tracker assignment, FinalIK targets, and VRIK root controller handoff`
- `ahstevens/FishTankCalibrator` - `Studied in Wave 295 as a display/surface calibration utility with four-corner surface capture, ScreenCalibrator DLL calls, XML output, probe point workflow, and editor line visualization`
- `PeterWolf93/PupilLabs_VR_Calibration` - `Studied in Wave 295 as a Pupil Labs calibration/validation script set with pupil data loading, validation grids, polynomial design matrix, linear regression coefficients, masking, plotting, and degree conversion`
- `TKorpXR/MooveoPlugin` - `Studied in Wave 295 as an interactive-space calibration SDK with device checkers, tester prefabs, calibration state, point/normal persistence, UI events, calibration controllers, and OpenVR tracker smoothing`
- `CamsAvis/VRC-Calibration-Detection` - `Studied as source-light product reference in Wave 295 for a VRChat avatar calibration-complete boolean and setup UX`
- `Erimelowo/SlimeVR-Calibration` - `Studied as a micro-utility in Wave 295 with browser body-segment inputs, canvas skeleton preview, default lengths, and SlimeVR body-proportion onboarding value`

## 267. Spatial anchors, colocation, persistent MR spaces, and room registration

Primary docs:

- `../landscape/vr-projects-wave-296-spatial-anchors-colocation-persistent-mr-spaces-and-room-registration.md`
- `../landscape/project-families.md`

- `oculus-samples/Unity-SharedSpatialAnchors` - `Deepened from partial in Wave 296 as the strongest official Meta shared-anchor donor with anchor source typing, save/load/erase/share flows, remembered UUIDs, Photon/group discovery, origin alignment, non-anchored object realignment, and MRUK custom world-lock handoff`
- `oculus-samples/Unity-Discover` - `Deepened from partial/source-heavy in Wave 296 as a larger Meta MR product-composition reference for end-to-end mixed-reality sample structure rather than the main anchor donor`
- `arghyasur1991/QuestRoomScan` - `Studied in Wave 296 as a persistent room scan toolkit with depth capture, volume integration, mesh extraction, versioned scan packages, anchor.json, MRUK fallback anchors, OVRSpatialAnchor persistence, relocation matrices, scene-object registry, and XR runtime guard`
- `NirajArts/SpatialAnchorTracking_Meta` - `Studied in Wave 296 as a single-universal-anchor setup helper with UI create/delete/reset/load actions, saved anchor and center transforms, singleton/event anchor access, and scene transform application`
- `jamesdowzard/quest-launcher` - `Studied in Wave 296 as a Quest MR launcher shell with Android helper bridge, Unity bootstrap, model loader, info HUD, orbit controller, and product-shell separation`
- `ftmghorbani/MX_Ink_2Ddrawing_Sample` - `Studied in Wave 296 as an anchored stylus/canvas drawing sample with MX Ink pressure and double-tap actions, three-anchor canvas setup, PlayerPrefs persistence, and OpenXR action bindings`
- `abhinavazad/XR-Experiment-Design-Toolbox` - `Studied in Wave 296 as an experiment registration toolkit with Procrustes re-registration, anchor JSON, prefab placement, movement replay, experiment lifecycle logs, and alignment metrics`

## 268. XR captions, subtitles, accessibility text, and live caption surfaces

Primary docs:

- `../landscape/vr-projects-wave-297-xr-captions-subtitles-accessibility-text-and-live-caption-surfaces.md`
- `../landscape/project-families.md`

- `XR-Access-Initiative/chirp-captions` - `Studied in Wave 297 as a Unity XR caption system with caption source/render manager split, timed captions, renderer switching, head-locked stacking, safe-area FOV sizing, and directional arrows toward off-screen audio sources`
- `A11YTK/A11YTK` - `Studied in Wave 297 as a Unity accessibility toolkit with SRT parsing, subtitle source controllers, headset/object/screen render modes, VideoPlayer time binding, object billboarding, wrapping, background styling, and option assets`
- `neogeek/a11ytk-rewrite` - `Studied as a rewrite/variant marker in Wave 297 for package-shape and modernization comparison with the original A11YTK caption/subtitle approach`
- `craigm26/LiveCaptionsXR` - `Studied in Wave 297 as a live AR/XR caption app with Flutter/native architecture, stereo audio capture, on-device STT, model management, contextual enhancement, speaker localization, AR anchors, MethodChannels, and caption confidence/timestamps`
- `lavin-a/aframe-xr-access-design` - `Studied in Wave 297 as an A-Frame/WebXR directional captions reference with browser-native caption controller, scene-level accessibility components, and source-direction UX`
- `jayrosen-design/XR-Caption` - `Studied as a micro-reference in Wave 297 for a Flask/web stereo caption surface with projection/layout value`
- `jacklul/USharpVideo-Subtitles` - `Studied in Wave 297 as a VRChat/Udon video subtitle overlay with URL/text loading, local/synced data, chunked sync, parser time limits, update-rate controls, overlap support, callbacks, and overlay styling`
- `Ikbenmathijs/VRC-ProTV-Subtitles` - `Studied in Wave 297 as a compact ProTV subtitle integration with VRCStringDownloader, timestamp parsing, time/text arrays, current-time update, and seek resync`

## 269. OpenXR/Unity hand gesture recognition, sign learning, and hand data bridges

Primary docs:

- `../landscape/vr-projects-wave-298-openxr-unity-hand-gesture-recognition-sign-learning-and-hand-data-bridges.md`
- `../landscape/project-families.md`

- `HankunYu/Kuji-Kiri` - `Studied in Wave 298 as a strong Unity XR Hands gesture donor with wrist-local snapshots, feature extraction, MLP static recognition, DTW dynamic recognition, sliding windows, confidence thresholds, gesture state machine, editor dataset/training tools, and tests`
- `Phlegmati/SimpleGestureRecorder` - `Studied in Wave 298 as a compact XR Hands gesture recorder/debugger with timed XRHandShape asset capture, screenshot saving, jointsUpdated condition checks, hold/interval gates, distance debug, and combo detection`
- `TF-polygon/XR-SignQuest` - `Studied with asset/model caveats in Wave 298 as a VR ASL learning product reference with mirror-camera capture, YOLOv8/ONNX/Barracuda inference, bounding boxes, confidence color, NMS, and VR memory-allocation discipline`
- `ariesiitr/Hand-Tracking-VR` - `Source-light/package reference in Wave 298 for a Unity hand-tracking `.unitypackage` covering controller-free grab, pinch, point, and hand interaction concepts`
- `Vin-meido/COM3D25_OpenXRHandsPOC` - `Studied in Wave 298 as an OpenXR hands-to-legacy-controller/game-input POC with hand tracking controller adapter, InputAction filters, virtual button mapping, and One Euro position smoothing`
- `ARCLab-MIT/BeaVR-app` - `Studied in Wave 298 as a Quest hand-tracking teleoperation bridge with ordered 26-joint XR Hands payloads, absolute/relative hand vectors, pinch toggles, NetMQ named sockets, IP/port config, reconnect behavior, and camera/graph stream references`

## 270. Voice-driven VR communication, control, agents, and speech surfaces

Primary docs:

- `../landscape/vr-projects-wave-299-voice-driven-vr-communication-control-agents-and-speech-surfaces.md`
- `../landscape/project-families.md`

- `oculus-samples/voicesdk-samples-whisperer` - `Studied with asset-heavy caveats in Wave 299 as an official Quest Voice SDK product reference with consent/onboarding, mic-level events, listenable objects, voice UI, speech bubbles, spatial audio, and sample-world voice UX`
- `UCL-VR/ubiq-genie` - `Studied in Wave 299 as a service-orchestrated conversational agent and transcription stack with media receiver, STT, text generation, TTS, audio recorder, CSV transcription logs, Unity network receivers, assistant audio injection, and peer-targeted responses`
- `vr-the-feedback/vr-the-feedback-unity` - `Studied as a legacy/source-light voice feedback reference in Wave 299 for grabbable mic, record/save feedback flow, backend/project-key caveats, and SteamVR/VRTK dependency notes`
- `nikaera/MagicOnionExample-OculusMobileVoiceChat` - `Studied in Wave 299 as a mobile Oculus voice chat loop with microphone ring buffer, Opus encoding, MagicOnion streaming hub, player parts and voice payload broadcast, remote avatar updates, and Opus playback`
- `xiaolazhu/vrc-voice-params` - `Studied in Wave 299 as a VRChat voice-to-OSC sidecar with Web Speech API recognition, command CRUD, language restart behavior, Go command matching, OSC parameter sender, debug receiver, and filtered noisy avatar paths`
- `Jurangren/VRC-Voicebridge` - `Studied in Wave 299 as a VRChat STT/translation/TTS/OSC sidecar with cancelable pipeline, local faster-whisper GPU model cache, translation, OpenAI TTS, OSC chatbox/typing/voice paths, virtual mic playback, tray UI, and desktop status overlay`
- `Alchemishty/ExpressVR` - `Studied in Wave 299 as a networked speech bubble and emote wheel package with bubble registry by client ID, settings-driven show/hide animation, emote sounds, ServerRpc/ClientRpc broadcasts, and XR input abstraction`
- `ahmedbegovic/VoiceInteractionVR` - `Studied as source-light puzzle reference in Wave 299 where visible code is mostly puzzle activation/progression rather than reusable voice-recognition plumbing`

## 271. XR text entry, keyboard variants, gaze, dictation, and query input surfaces

Primary docs:

- `../landscape/vr-projects-wave-300-xr-text-entry-keyboard-variants-gaze-dictation-and-query-input-surfaces.md`
- `../landscape/project-families.md`

- `ViRGIS-Team/VR-Keyboard` - `Studied in Wave 300 as a compact Unity XR keyboard package with event-driven key output, upper/lower/other layers, XRUIInputModule setup, collider/direct interactor mapping, and hover-to-type caveats`
- `magicleap/MagicLeapXRKeyboard` - `Studied with vendor/deprecation caveats in Wave 300 as a keyboard package reference with KeyboardManager, layout data, row/key builder, TMP input receiver, follow/recenter behavior, haptics, preview, and JSON-like authoring`
- `fabio914/EyeTrackingKeyboard` - `Studied with prototype caveats in Wave 300 as a gaze/dwell keyboard with raycast selection, dwell timer, eye-height following, shift/secondary modes, highlight/audio feedback, and calibration caveats`
- `vitrivr/vitrivr-vr` - `Studied in Wave 300 as a VR search/query app with static text router, physical keyboard generation, word/phrase insertion, dictation-adjacent controllers, and modular query-term providers`

## 272. Quest passthrough camera wrappers, permissions, capture, and QR world tracking

Primary docs:

- `../landscape/vr-projects-wave-301-quest-passthrough-camera-wrappers-permissions-capture-and-qr-world-tracking.md`
- `../landscape/project-families.md`

- `xrdevrob/QuestCameraKit` - `Studied as sample/common-layer reference in Wave 301 for marker pooling, marker transform/text update, idle hiding, and camera-detection label lifecycle`
- `Uralstech/UXR.QuestCamera` - `Studied in Wave 301 as a native Quest camera wrapper package with HorizonOS/Quest support gates, camera permission constants, device discovery/cache, Camera2 callbacks, session/converter split, metadata, and explicit error taxonomy`
- `HoloLabInc/QuestCameraTools-Unity` - `Studied in Wave 301 as a Quest camera tools package with WebCamTexture permission/support manager, cancellable QR decode loop, environment raycast placement, filters, anchor point selection, physical-size scaling, and detected/lost events`
- `oculus-samples/Unity-SpatialLingo` - `Studied in Wave 301 as an official camera/object/speech MR sample with camera taxon tracker, GPU object classifier, face blur utilities, surface samples, reliability scoring, observe/miss counts, and add/update/remove detection events`

## 273. Quest camera CV, object detection, segmentation, and world marker pipelines

Primary docs:

- `../landscape/vr-projects-wave-302-quest-camera-cv-object-detection-segmentation-and-world-marker-pipelines.md`
- `../landscape/project-families.md`

- `demoPlz/Unity-MultiObjectDetection` - `Studied with fork/commented-code caveats in Wave 302 as a Quest camera object-detection sample with permission-aware menu, inference idle gate, layer-per-frame Sentis scheduling, environment raycast marker placement, class/distance de-dupe, and recenter cleanup`
- `EnoxSoftware/QuestWithOpenCVForUnityExample` - `Studied with package/license caveats in Wave 302 as a Quest passthrough-to-OpenCV bridge with AsyncGPUReadback/Texture2D conversion, camera pose/intrinsics metadata, ArUco detection, YOLOX/Sentis toggles, ByteTrack, and debug/FPS controls`
- `rikturnbull/xr-image-segmentation` - `Studied in Wave 302 as a Quest passthrough segmentation prototype with model-load idle gate, layer-scheduled executor state machine, async output requests, mask RawImage/texture reuse, box clipping, and confidence-colored masks`

Overlap note: Wave 302 also cross-references `oculus-samples/Unity-SpatialLingo`
for object-classifier scheduling, taxon reliability, world sampling, and
face/object privacy boundaries; its canonical registry entry remains in section
272.

## 274. Embodied locomotion, walking-in-place, redirected walking, and RDW experiment packaging

Primary docs:

- `../landscape/vr-projects-wave-303-embodied-locomotion-walking-in-place-redirected-walking-and-rdw-experiment-packaging.md`
- `../landscape/project-families.md`

- `singaporetech/immersification-wip-locomotion` - `Studied in Wave 303 as a strong walking-in-place locomotion donor with input manager, movement manager, stale-input reset, Vive tracker allocator, arm-swing/head-bob/leg-lift modules, acceleration/deceleration, smoothing, and mode requirements`
- `DarkerQueenSara/ProjetoVR-V2` - `Studied with research/student caveats in Wave 303 as an RDW/impossible-space prototype with translation gain, rotation gain, room/portal factory, teleport room handoff, and detailed real/virtual/gain experiment CSV metrics`
- `tmitro/ucf-ist-redirected-walking` - `Studied as source-light/fork-lineage node in Wave 303 for Vive/OpenVR redirected-walking framework packaging, RDWT artifact comparison, and vendored SteamVR/VRTK caveats`
- `VRatPolito/CET-VR` - `Studied as product/reference node in Wave 303 for XRI dynamic move direction blending, joystick blocked state, visual arrow direction affordance, jump curve, and tunnelling comfort preset surfaces`

## 275. In-VR questionnaires, study surveys, affect ratings, and remote lab overlays

Primary docs:

- `../landscape/vr-projects-wave-304-in-vr-questionnaires-study-surveys-affect-ratings-and-remote-lab-overlays.md`
- `../landscape/project-families.md`

- `MartinFk/VRQuestionnaireToolkit` - `Studied in Wave 304 as a Unity/SteamVR questionnaire toolkit with JSON metadata, page prefab factory, required-question validation, haptic/audio feedback, participant/condition setup, local/server CSV/TXT export, and finish events`
- `JakobJoSchmidt/immersive-questionnaire-unity-vr` - `Studied in Wave 304 as a CSV-driven immersive questionnaire service with intro/farewell pages, configurable Likert scales, random inversion, editing-time output, answer CSV generation, and display state tracking`
- `microsoft/Remote-Lab` - `Studied in Wave 304 as a remote VR study toolkit with ScriptableObject questionnaire content, UI templates, validation, replay-aligned answer logs, Photon questionnaire sync, transform recording/replay, OBS, UI events, and custom variables`
- `Pepn/SurveyToolkit` - `Studied in Wave 304 as a plug-and-play survey toolkit with page/question data split, required validation, incomplete-question highlighting, CSV export, persistent storage, and optional upload with security caveats`
- `afourcade/AffectTracker_validation` - `Studied as analysis companion in Wave 304 for continuous valence/arousal validation, preprocessing, BIDS formatting, plotting, modeling, and follow-up runtime inspection`

## 276. VR wayfinding, navigation guidance, and spatial navigation study tasks

Primary docs:

- `../landscape/vr-projects-wave-305-vr-wayfinding-navigation-guidance-and-spatial-navigation-study-tasks.md`
- `../landscape/project-families.md`

- `pepwuper/Google-Cardboard-VR-Navigation` - `Studied in Wave 305 as a minimal gaze-to-NavMesh navigation reference with cursor destination selection, floor event trigger framing, and player-following UI height preservation`
- `npresearchlab/NavCity_Toolkit` - `Studied in Wave 305 as a city navigation study toolkit with active target sequencing, mission text, headset position/rotation/time CSV logging, and participant ID caveats`
- `zcbtmfc/Wayfinding-Task` - `Studied in Wave 305 as an HTC Vive wayfinding experiment with randomized conditions, additive room loading, agent advice/audio/animation, ask/distance/time logging, decision capture, and per-trial CSV output`
- `maxleblanc/sightless-vr` - `Studied as source-light product reference in Wave 305 for haptic wearable/no-HMD architectural wayfinding and ghost-obstacle concepts`
- `angsamuel/GingerVR` - `Studied as source-light product reference in Wave 305 for cybersickness and navigation aids including rest-frame noses, blur/FOV, dot effects, head snapping, vision lock, and virtual CAVE framing`

## 277. XR testing, simulation, input validation, and performance harnesses

Primary docs:

- `../landscape/vr-projects-wave-306-xr-testing-simulation-input-validation-and-performance-harnesses.md`
- `../landscape/project-families.md`

- `Unity-Technologies/XRInputTests` - `Studied in Wave 306 as an XR input repro/debug suite with editor test view, scene driver, device feature TreeViews, haptic capability/impulse panels, template creation, and export/update workflows`
- `Unity-Technologies/xr.sdk.functionaltests` - `Studied in Wave 306 as a Unity XR functional test suite with reusable stage setup, frame skip, display/input/device/audio assertions, runtime/platform skip gates, and timing/refresh metrics`
- `Unity-Technologies/com.unity.xr.test-framework.performance` - `Studied in Wave 306 as a Unity XR performance test framework with sample groups, profiler markers, statistics, metadata capture, build/runtime info, TestRunner callbacks, and JSON/XML result output`
- `needle-tools/ar-simulation` - `Studied with package/license caveats in Wave 306 as a Unity XR simulation backend reference for ARFoundation/editor simulation, simulated planes/point clouds/images/touch, and non-invasive provider architecture`

## 278. XR gaze, pinch, dwell, onboarding, and Android XR interaction samples

Primary docs:

- `../landscape/vr-projects-wave-307-xr-gaze-pinch-dwell-onboarding-and-android-xr-interaction-samples.md`
- `../landscape/project-families.md`

- `DFKI-Interactive-Machine-Learning/de.dfki-iml.xr-gaze-interaction-toolkit` - `Studied in Wave 307 as a broad Unity gaze toolkit with global gaze manager, gaze interactables, information displays, radial/pie menus, guide cards, questionnaire cards, attention monitoring, accuracy tests, CSV export, and non-commercial license caveats`
- `tomazsaraiva/unity-gaze-interaction` - `Studied in Wave 307 as a compact gaze/dwell package with raycast interactor, enter/stay/exit/activated events, reticle scaling/alignment, progress fill, exit delay, and resource-loaded prefab defaults`
- `microsoft/MixedReality-EyeTracking-Sample` - `Studied in Wave 307 as a HoloLens 2 extended eye-tracking sample with permission flow, EyeGazeTrackerWatcher, highest-frame-rate tracker selection, SpatialGraphNode transforms, and left/right/combined gaze conversion`
- `holokit/holokit-unity-sdk` - `Studied in Wave 307 as an optical MR SDK reference with gaze raycast interactables, gaze+pinch gesture adapter, dwell button UI, stereo phone MR framing, hand tracking, recording, calibration, and sample-only caveats`
- `android/xr-unity-samples` - `Studied in Wave 307 as an Android XR Unity sample set with gaze+pinch plane selection, catapult interaction, gesture detector, permission/status dashboard, menu tutorial, passthrough status, and XR simulation assets`

## 279. VR/3D annotation, point-cloud labeling, and linked-data note surfaces

Primary docs:

- `../landscape/vr-projects-wave-308-vr-3d-annotation-point-cloud-labeling-and-linked-data-note-surfaces.md`
- `../landscape/project-families.md`

- `ahstevens/VR-Point-Cloud-Editor` - `Studied in Wave 308 as a Unity/native-plugin point-cloud editor with LAZ import/export, point-cloud metadata, miniature reset, LOD/frustum culling, closest-point and sphere queries, outlier highlight/delete, undo, and editor/runtime manager boundaries`
- `florianwirth/PointAtMe` - `Studied in Wave 308 as an in-VR point-cloud labeling tool with point-cloud/image sequence navigation, 65k-point mesh chunking, bounding-box labels, track IDs, class/quality/priority/direction dialogs, controller box manipulation, and hardcoded-path caveats`
- `framefield/vr-annotate` - `Studied in Wave 308 as a linked-data architectural annotation package with annotation manager, target node selectors, viewport recall, local/REST persistence, W3C-style JSON-LD records, author/time provenance, and annotation tour navigation`

## 280. VR motion capture, pose recording, BVH, muscle compression, and body tracker samples

Primary docs:

- `../landscape/vr-projects-wave-309-vr-motion-capture-pose-recording-bvh-muscle-compression-and-body-tracker-samples.md`
- `../landscape/project-families.md`

- `alexismorin/OpenMocap` - `Studied in Wave 309 as a Unity roomscale mocap baseline with HMD/controller sampling, humanoid IK, hip/head offset, Unity Recorder integration, trigger start/stop recording, and old XR API caveats`
- `andrewjc/VRRecorder` - `Studied in Wave 309 as a SteamVR pose/controller-state recorder with 0.01-second keyframes, HMD/controller matrix logs, button/axis state, playback device proxies, and fragile unversioned text schema caveats`
- `emilianavt/BVHTools` - `Studied in Wave 309 as a Unity BVH recorder/parser with humanoid bone mapping, bone renaming, skeleton hierarchy generation, Blender axis mode, frame/channel parsing, and transform/rest-pose caveats`
- `gree/MuscleCompressor` - `Partially studied in Wave 309 as a Unity Humanoid muscle-space compression reference with recording/loading/conversion workflow, StreamingAssets motion data, bytes-to-animation conversion, and dependency-heavy core-isolation gaps`
- `Pico-Developer/PICOMotionTrackerSample-Unity` - `Studied in Wave 309 as a PICO motion/body tracker sample with serial-number inventory, confidence feedback, connected tracker manager, calibration/battery UI, 24-joint body poses, CSV playback, recording UI, and bone-length updates`

## 281. Game-specific VR retrofit mods, OpenXR/SteamVR bootstrap, UI patches, and comfort product lessons

Primary docs:

- `../landscape/vr-projects-wave-310-game-specific-vr-retrofit-mods-openxr-steamvr-ui-patches-and-comfort-product-lessons.md`
- `../landscape/project-families.md`

- `ethanporcaro/BF2VR-Alpha` - `Studied in Wave 310 as an archived native C++ OpenXR/D3D11 game retrofit with existing-device session binding, stereo swapchains, D3D11 render target views, OpenXR action setup, ViGEm virtual X360 output, and injection/GPL caveats`
- `DrBibop/RoR2VRMod` - `Studied in Wave 310 as a Unity/BepInEx OpenXR runtime bootstrap mod with dynamic XR loader setup, controller profiles, asset-bundle hands, body-specific motion controls, wrist/watch HUD, haptics, recentering, and config gates`
- `Raicuparta/nomai-vr` - `Studied in Wave 310 as a SteamVR/OWML VR conversion with ordered module activation, SteamVR action manifest/bindings, mode-aware input maps, tools/hands/HUD modules, virtual keyboard patching, and compatibility checks`
- `Raicuparta/two-forks-vr` - `Studied in Wave 310 as a SteamVR/BepInEx Firewatch VR mod with Harmony patching, screen-space canvas conversion into static/interactive world-space UI, laser pointer, attached UI surfaces, settings menu, and ignore/disable lists`
- `LukeRoss00/gta5-real-mod` - `Studied as source-light product reference in Wave 310 for VR retrofit setup discipline, settings backup/restore, fixed/headlocked HUD behavior, headshake recenter, gamepad/head aiming, cutscene comfort modes, and detailed support guidance`

## 282. Rust, Bevy, and Godot OpenXR bring-up variants, app shells, and input/rendering boundaries

Primary docs:

- `../landscape/vr-projects-wave-311-rust-bevy-godot-openxr-bring-up-variants-app-shells-and-input-rendering-boundaries.md`
- `../landscape/project-families.md`

- `blaind/bevy_openxr` - `Studied in Wave 311 as a Bevy OpenXR plugin/core experiment with WGPU/OpenXR handoff, one-shot XrInstance storage, custom XR runner, device/event/hand-tracking/swapchain/render-graph modules, and lifecycle caveats`
- `MalekiRe/bevy_openxr_android` - `Studied in Wave 311 as an Android/Quest Bevy OpenXR sample with DefaultXrPlugins, typed Oculus controller resources, frame/session/input resources, hand gizmos, trigger/button visual feedback, and Android packaging follow-up gaps`
- `occuros/bevy_openxr_performance_test` - `Studied in Wave 311 as a Bevy OpenXR performance/plugin boundary with manual RenderPlugin replacement, FutureXrResources handoff, left/right ManualTextureViews, xr_begin_frame/post_frame/end_frame systems, swapchain image lifecycle, and action-set resources`
- `richardanaya/godot_openxr__rust` - `Studied in Wave 311 as a Godot XR plus Rust GDExtension sample with a Rust class reading parent XRController3D trigger state and mutating sibling MeshInstance3D material, mirroring a tiny GDScript controller sample`
- `TheHellBox/SlashMania` - `Studied in Wave 311 as a Rust OpenXR rhythm-game experiment with Specs ECS loop, OpenGL OpenXR instance/session, stereo swapchain, reference spaces, event polling, locate views, frame-stream begin/end, and hand-rolled app-shell caveats`

## 283. VRCFaceTracking vendor modules, shared memory, vendor SDKs, and loopback bridges

Primary docs:

- `../landscape/vr-projects-wave-312-vrcfacetracking-vendor-modules-shared-memory-vendor-sdks-and-loopback-bridges.md`
- `../landscape/project-families.md`

- `BigscreenVR/VRCFT-Beyond` - `Studied in Wave 312 as a very thin shared-memory VRCFT eye module with a `VRCFTMemmapData` schema, 3D-to-2D gaze conversion, eyelid-closure-to-openness mapping, and external-producer ownership caveats`
- `benaclejames/VRCFTPimaxModule` - `Studied in Wave 312 as a Pimax eye-tracking VRCFT module with embedded vendor DLL extraction, JSON-tuned smoothing, blink/wink timers, eye-loss fallback, and normalization into UnifiedTracking eye data`
- `UikaMisumi/DreamAirTracking.VrcftModule` - `Studied in Wave 312 as a Dream Air loopback UDP/JSON VRCFT module with stale timeout, neutralization, pupil and optional expression output, and explicit coexistence with another lip/face module`

## 284. VRCFaceTracking downstream bridges, simulation panels, and avatar setup automation

Primary docs:

- `../landscape/vr-projects-wave-313-vrcfacetracking-downstream-bridges-simulation-panels-and-avatar-setup-automation.md`
- `../landscape/project-families.md`

- `tkns3/VRCFTtoVMCP` - `Studied in Wave 313 as a VRCFT-to-VMC/PerfectSync bridge with OSC receive, VMC bundle send, local OSC JSON service, avatar-change orchestration, JSON config, and downstream schema translation`
- `Toys0125/VirtualFaceTracking` - `Studied in Wave 313 as a VRCFT module plus companion GUI with named-pipe state snapshots, diagnostics, manual controls, simulation engine, persistent JSON state, and GUI auto-launch`
- `LumKitty/VRCFTnyan` - `Studied in Wave 313 as a VNyan consumer-side VRCFT adapter with config-file loading, plugin button/trigger entry points, avatar JSON handoff, and direct downstream blendshape-override framing`
- `ImTiara/FaceTrackingSetup` - `Studied in Wave 313 as an inspector-driven Unity setup helper with blendshape search, ARKit auto-fill, eye/blink/pupil/mouth authoring fields, thresholds, toggles, and generated output-folder workflow`
- `benaclejames/VRCFTSetupUtility` - `Studied in Wave 313 as a metadata-driven avatar setup generator with renderer save states, param-meta JSON, diff capture, animation asset generation, and linear/binary FX layer builders`

## 285. PSVR2Toolkit downstream clients, gaze capture, haptics, and installer microtools

Primary docs:

- `../landscape/vr-projects-wave-314-psvr2toolkit-downstream-clients-gaze-capture-haptics-and-installer-microtools.md`
- `../landscape/project-families.md`

- `BnuuySolutions/PSVR2Toolkit.Baballonia` - `Studied in Wave 314 as a PSVR2 gaze-image capture adapter that initializes the toolkit C API, validates a fixed image header, copies BC4 eye-image payloads into OpenCV mats, and exposes a narrow Baballonia capture-provider boundary`
- `tabithamoon/PSVR2HeadpatHaptics` - `Studied in Wave 314 as a headset-rumble relay with CLI flags, OSCQuery endpoint publication, optional WebSocket server, velocity-derived rumble, and direct `SetHmdRumble` frequency mapping`
- `MaidScientistIzutsumiMarin/psvr2toolkit-installer` - `Studied in Wave 314 as a NiceGUI installer/rollback tool with Steam path resolution, Authenticode-based driver validation, reversible signed/unsigned driver swapping, release checks, and eyelid-estimation toggles`
- `Kingoooooooo/Pistol-Whip-Adaptive-Triggers` - `Studied in Wave 314 as a game-specific PSVR2 adaptive-trigger client with MelonLoader bootstrap, local IPC handshake, trigger-effect command structs, and gun-state-driven feedback profiles`

## 286. XREAL One companions, virtual displays, IMU readers, and display-triggered microhelpers

Primary docs:

- `../landscape/vr-projects-wave-315-xreal-one-companions-virtual-displays-imu-readers-and-display-triggered-microhelpers.md`
- `../landscape/project-families.md`

- `dripster82/ar_workspace_manager_for_xreal` - `Studied in Wave 315 as a high-value smart-glasses workspace donor with modular IMU transport, drift/mount calibration, virtual-display identity reuse, diagnostics/churn telemetry, HUD/media/voice subsystems, and helper-service boundaries`
- `SamiMitwalli/One-Pro-IMU-Retriever-Demo` - `Studied in Wave 315 as a Python XREAL One Pro IMU proof-of-access with TCP packet framing, six-float decode, callback reader, 500-sample gyro calibration, complementary filter, and zero-view controls`
- `rohitsangwan01/xreal_one_driver` - `Studied in Wave 315 as a Rust plus C FFI driver core with buffer framing, sanity guards, axis remap, timestamp extraction, and a minimal `xo_new`/`xo_next`/`xo_free` ABI`
- `shugi12345/xreal-show-taps` - `Studied in Wave 315 as an Android display-trigger helper with a foreground `DisplayManager` listener, restore-state persistence, Shizuku permission flow, and AIDL-backed `show_touches` sidecar control`
- `DeskUnreal/xreal-vio-vr` - `Studied in Wave 315 primarily as Linux smart-glasses stack framing and patch evidence, with Basalt `Fisheye624` patches, a headset-as-ground-reference FSM concept, and mostly skeletal OpenVR/bridge/runtime code`

## 287. XR WebView browser panels, native WebView bridges, and input surfaces

Primary docs:

- `../landscape/vr-projects-wave-316-xr-webview-browser-panels-native-webview-event-bridges-and-input-surfaces.md`
- `../landscape/project-families.md`

- `rwpersson/OpenWebView-Unity` - `Studied in Wave 316 as a high-value Unity/Quest browser donor with Android `WebView` hosting through `Presentation` and `VirtualDisplay`, explicit texture transport, broad browser callback/policy surfaces, and clear browser-core versus XR panel boundaries`
- `t-34400/SimpleUnity3DWebView` - `Studied in Wave 316 as a compact Android/Quest browser-panel baseline with manager, pointer source, Java bridge, texture updater, and lightweight 3D browser integration seams`
- `vuplex/meta-xr-webview-example` - `Studied as a source-light Meta XR integration sample in Wave 316 for prefab-level browser-panel setup and runtime-specific scene wiring rather than browser-core donor value`
- `vuplex/xr-interaction-webview-example` - `Studied in Wave 316 as a source-light XRI browser-panel integration reference for tracked-device raycaster, event-camera, and world-space browser wiring expectations`

## 288. VR notification, chat overlays, and local message relay sidecars

Primary docs:

- `../landscape/vr-projects-wave-317-vr-notification-chat-overlays-and-local-message-relay-sidecars.md`
- `../landscape/project-families.md`

- `BOLL7708/TwitchVRNotifications` - `Studied in Wave 317 as a Twitch-chat-to-SteamVR notification bridge with reconnect behavior, auth and local-secret handling, card rendering, avatar/image handling, and explicit OpenVR notification emission`
- `balazs565/PhoneNotificationsVR` - `Studied in Wave 317 as a high-value phone notification overlay donor with layered architecture, `INotificationSource`, bounded `Channel` dispatch, filter/history policy, overlay anchoring, and supervisor loops`
- `tyunta/notifyxsoverlay` - `Studied in Wave 317 as a Windows-notification-to-XSOverlay sidecar with WinRT ingest, dedupe, allow/block and learning-mode filters, config hygiene, manifest/startup helpers, and WebSocket relay transport`
- `NekoSuneProjects/vrnotications` - `Studied in Wave 317 as a small multi-target notification wrapper with XSOverlay/OVR Toolkit/desktop targets and reusable image normalization across payload forms`

## 289. Runtime launch sidecars, overlay autostart, and session operator helpers

Primary docs:

- `../landscape/vr-projects-wave-318-runtime-launch-sidecars-overlay-autostart-and-session-operator-helpers.md`
- `../landscape/project-families.md`

- `dreiekk/OpenVR-Autostarter` - `Studied in Wave 318 as an OpenVR background helper with manifest registration, runtime polling, start/stop task orchestration, graceful-close versus force-kill policy, and hidden/autostart operation`
- `Eidenz/monadeck` - `Studied in Wave 318 as a Linux XR operator shell with backup-safe OpenXR runtime switching, Steam library and compatdata inspection, game/orchestrator inventory, and shared core for desktop plus in-headset control surfaces`
- `Eidenz/monado-frame` - `Studied in Wave 318 as a Monado overlay companion with file-decoupled screenshot and gesture-config contracts, runtime-aware wrist panels, async processing, and libmonado-based input arbitration`
- `EllieWasteland/CaronteLauncherVR` - `Studied as a source-light product-reference shell in Wave 318 for runtime choice, capture-path choice, profile/addon loading, and operator-facing session bring-up wizard UX`

## 290. Stereo display-surface viewers, depth conversion, and spatial-display runtimes

Primary docs:

- `../landscape/vr-projects-wave-319-stereo-display-surface-viewers-depth-conversion-and-spatial-display-runtimes.md`
- `../landscape/project-families.md`

- `Bastian-Noel/DepthVistaXR` - `Studied in Wave 319 as a desktop-capture-to-stereo viewer with backend ladder, depth-estimation stage, threaded OpenXR output, controller-to-desktop input synthesis, and live Dear PyGui control surfaces`
- `BerZerker96/Osiris-Vr-Viewer` - `Studied in Wave 319 as a stereo viewer with persistent presets, shared-memory live control plane, in-VR control panel, source hot-swap framing, and explicit viewer-versus-GUI process split`
- `DisplayXR/displayxr-unity` - `Studied in Wave 319 as a spatial-display Unity runtime plugin with camera-centric versus display-centric rigs, provider tunables, explicit view-rig ownership, and a strong local-2D composition layer`
- `DisplayXR/displayxr-demo-gaussiansplat` - `Studied in Wave 319 as a compact display-centric viewer with runtime-owned display geometry, focus/pivot/orbit controls, transparent layering, and small-viewer product lessons`

## 291. Declarative overlay frameworks, free overlay shells, and spatial manipulation clients

Primary docs:

- `../landscape/vr-projects-wave-320-declarative-overlay-frameworks-free-overlay-shells-and-spatial-manipulation-clients.md`
- `../landscape/project-families.md`

- `sumx21t-3310/FloatSoda` - `Studied in Wave 320 as a declarative SteamVR overlay framework with widget/render/layer tree separation, render-thread OpenGL texture submission, OpenVR overlay wrappers, and dashboard/world/device-tracked window types`
- `DelfinVT-uwu/FreeOverlay` - `Studied with maturity caveats in Wave 320 as a free/open XSOverlay-like desktop companion shell with OpenVR/GLFW/PIL rendering, themes, media controls, notifications, calendar reminders, and monolithic-script caveats`
- `Schmarni-Dev/absolute-solver` - `Studied in Wave 320 as a StardustXR spatial manipulation client with hand/tip selection rays, object capture into mover logic, ring input, line/model feedback, and accent-color integration`

## 292. SteamVR performance HUDs, sensor fan-in, and overlay QoL patch packs

Primary docs:

- `../landscape/vr-projects-wave-321-steamvr-performance-huds-sensor-fan-in-and-overlay-qol-patch-packs.md`
- `../landscape/project-families.md`

- `Karlan-Trade/VR-Performance-Profiler` - `Studied in Wave 321 as a SteamVR performance HUD with HWiNFO/MSI/SteamVR provider fan-in, metric aggregation, OpenVR overlay manager, D3D/Direct2D rendering, settings, tray UI, and SteamVR readiness probing`
- `chaixshot/xsoverlay-tweak` - `Studied in Wave 321 as an XSOverlay BepInEx/Harmony QoL patch pack covering refresh rate, pointer/cursor, wrist panel, keyboard, haptics, overlay attach, WebView stability, and patch-fragility caveats`

## 293. XSOverlay companion bridges, phone notifications, and translation-control sidecars

Primary docs:

- `../landscape/vr-projects-wave-322-xsoverlay-companion-bridges-phone-notifications-and-translation-control-sidecars.md`
- `../landscape/project-families.md`

- `jonreeve/NotifyXso` - `Studied in Wave 322 as an Android-to-XSOverlay notification bridge with notification-listener source, filter/config repository, HTTP/Ktor relay, UDP XSOverlay payload mapping, capped icon handling, and datagram-size guard`
- `Daniel81i/YncneoXSOBridge` - `Studied in Wave 322 as a translation/control XSOverlay companion with registry port discovery, WebSocket reconnect surfaces, tray status/menu controller, translation logging, PyInstaller resource handling, and global-state caveats`

## 294. Narrow OpenXR API layers, cockpit anchors, inline profilers, and game injection toolkits

Primary docs:

- `../landscape/vr-projects-wave-323-narrow-openxr-api-layers-cockpit-anchors-inline-profilers-and-game-injection-toolkits.md`
- `../landscape/project-families.md`

- `Majed6/KATOXR` - `Studied in Wave 323 as a narrow OpenXR treadmill-to-stick micro-layer with action/binding interception, KAT device polling, HMD-relative velocity conversion, calibration, trailing stop, and OpenComposite compatibility hooks`
- `robogears/cockpit-anchor` - `Studied in Wave 323 as a seated cockpit anchoring OpenXR API layer with STAGE-space anchor capture, LOCAL-space rebasing, shared/per-game anchor files, hotkey/audio feedback, bypass mode, and Virtual Desktop workaround caveats`
- `mledour/xrprof` - `Studied in Wave 323 as an inline OpenXR API-layer profiling library with per-session probes, CPU/GPU RAII scopes, D3D11/D3D12 attachment seams, live enable toggles, frame commit, and layer-owned CSV output`
- `AndrewAltimit/game-mods` - `Studied in Wave 323 as a Rust minimal-injection game retrofit toolkit with launcher/daemon/injector/overlay split, IPC, single-writer shared memory, protocol crates, video decode, Vulkan/OpenVR hook framing, and crash-isolation constraints`

## 295. VRChat parameter state dashboards and local web control mirrors

Primary docs:

- `../landscape/vr-projects-wave-324-vrchat-parameter-state-dashboards-and-local-web-control-mirrors.md`
- `../landscape/project-families.md`

- `I5UCC/ParameterSaveStates` - `Studied in Wave 324 as a SteamVR dashboard and local Web UI for VRChat per-avatar parameter profiles, with OSCQuery discovery, typed parameter cache/replay, profile folders, apply filters, auto-sync settings, export/import, SSE web updates, tray/browser fallback, and SteamVR manifest registration`

## 296. SteamVR hardware provisioning, session autolaunch, and Watchman dongle utilities

Primary docs:

- `../landscape/vr-projects-wave-325-steamvr-hardware-provisioning-session-autolaunch-and-watchman-dongle-utilities.md`
- `../landscape/project-families.md`

- `The-Graze/PSVR2-SteamVR-AutoLaunch` - `Studied in Wave 325 as a PSVR2 USB-triggered SteamVR autolaunch tray microhelper with single-instance guard, WMI Win32_USBControllerDevice watcher, device-name match, manual tray launch, and steam://run/250820 startup`
- `ykeara/SteamVR-Dongle-Flash` - `Studied in Wave 325 as a source-light Watchman dongle provisioning guide/script with SteamVR lighthouse_watchman_update.exe reuse, default-path batch file, flash-all risk, and permanent-firmware warning copy`
- `ugokutennp/flowing-dongle-ccd` - `Studied in Wave 325 as a DIY multi-device Watchman dongle hardware/product reference with nRF52840 plus USB hub design, KiCad PCB, case models, JLCPCB artifacts, firmware-source notes, and licensing/provenance caveats`

## 297. KAT Walk Linux locomotion overlay and OpenXR layer split

Primary docs:

- `../landscape/vr-projects-wave-326-kat-walk-linux-locomotion-overlay-and-openxr-layer-split.md`
- `../landscape/project-families.md`

- `BBPSBB/katwalk-linux` - `Studied in Wave 326 as a Linux KAT Walk C2+ treadmill utility with USB frame parser, locomotion model, body/HMD fusion, daemon web tuner, shared-memory stick/HUD/laser buses, pure-Pillow wrist HUD, OpenXR implicit layer for input/HUD composition, and N=1 hardware caveats`
- `Kiichiuwu/WTVFSVR-war-thunder-virtual-flight-stick-for-vr` - `Checked in Wave 326 as an empty/source-light virtual flight-stick overlay placeholder; no donor code found`

## 298. Window mirror managers, capture/remix surfaces, and stream-safe overlay pipelines

Primary docs:

- `../landscape/vr-projects-wave-327-window-mirror-managers-capture-remix-surfaces-and-stream-safe-overlay-pipelines.md`
- `../landscape/project-families.md`

- `aguirretim/apollo-mirror-manager` - `Studied in Wave 327 as a stream-safe DWM window mirror manager for Apollo/Moonlight with persistent WinForms mirror worker, DWM thumbnail registration, virtual-display detection, target handoff file, debounced teardown, PID/watchdog repair, tile manager, apps.json backups, and ownership-marker close policy`
- `PhotonIO/RemixPlayer` - `Studied in Wave 327 as a source-light channelized capture/remix product concept for audio, video, VR, overlays, replay files, graphics captures, FPS, and performance metrics`

## 299. VRChat communication, translation, media, and notification OSC companions

Primary docs:

- `../landscape/vr-projects-wave-328-vrchat-communication-translation-media-and-notification-osc-companions.md`
- `../landscape/project-families.md`

- `PaciStardust/HOSCY` - `Studied in Wave 328 as a modular VRChat communication companion with recognition providers, Whisper subprocess IPC, OSC routing/OSCQuery, output preprocessors, counters, AFK, TTS, media controls, and legacy-config migration`
- `kapitalismho/PuriPuly-heart` - `Studied in Wave 328 as an LLM two-way VRChat translator with self-versus-peer channel separation, native subtitle overlay, provider routing, brokered key flow, context-aware prompts, cost framing, and privacy caveats`
- `VespeiProjects/SpotifyOSC` - `Studied in Wave 328 as a narrow WPF Spotify/status-to-chatbox sidecar with process polling, settings persistence, `/chatbox/input` OSC sends, prefix/save options, and system-stat fallback`
- `shadorki/vrc-osc-discord-band` - `Studied in Wave 328 as a Windows notification to avatar bracelet OSC utility with Discord notification classification, config-file port override, Unity package setup, and avatar-parameter output`

## 300. SteamVR runtime settings, recovery, and WMR patch microtools

Primary docs:

- `../landscape/vr-projects-wave-329-steamvr-runtime-settings-recovery-and-wmr-patch-microtools.md`
- `../landscape/project-families.md`

- `demonixis/SteamVREnabler` - `Studied in Wave 329 as a WinForms SteamVR runtime folder toggle and kill-switch microtool using openvrpaths.vrpath, known SteamVR process names, and fragile folder rename semantics`
- `ZipFile/ovr-update-settings` - `Studied in Wave 329 as an OpenVR IVRSettings CLI with get/set/delete/add/neg operations, type inference, VRApplication_Utility init, and transaction/rollback gaps`
- `Raphiiko/Raphiis-SteamVR-Crash-Recovery` - `Studied in Wave 329 as a Rust SteamVR/VRChat crash recovery helper with process detection, latest VRChat log parsing, SteamVR relaunch, and vrchat://launch?id=... last-world restore`
- `Burnt-Delta/ez-wmr` - `Studied in Wave 329 as a WMR SteamVR driver settings patcher for thumbstick controls with direct default.vrsettings seek writes, local config persistence, and backup/JSON-parser caveats`

## 301. SteamVR device provisioning, base-station diagnostics, and visual asset patchers

Primary docs:

- `../landscape/vr-projects-wave-330-steamvr-device-provisioning-base-station-diagnostics-and-visual-asset-patchers.md`
- `../landscape/project-families.md`

- `jaki-gh/Viva-Dongle-Flasher` - `Studied in Wave 330 as a Python GUI Watchman dongle flasher with SteamVR firmware zip lookup, UF2 generation, device/drive selection, disabled flash buttons until prerequisites exist, and irreversible-action caveats`
- `TerayTech/SteamVR_BaseStation2.0_Diagnostic_Tool` - `Studied in Wave 330 as a base-station serial diagnostic viewer with worker queues, bounded logs, telemetry parsing, category/status classification, thresholds, and localization/validation caveats`
- `nicolas-riera/SteamVR-IconsSwitcher` - `Studied in Wave 330 as a Python SteamVR icon resource patcher with registry Steam path lookup, current-state detection, custom/default icon sets, and update-overwrite/backup caveats`
- `nicolas-riera/SteamVR-RenderModelSwitcher` - `Studied in Wave 330 as a Python SteamVR render-model resource patcher with current-model detection, Quest/Vive asset trees, copy/restore flows, and destructive directory replacement caveats`

## 302. Overlay surface proxies, dashboard notifications, hand redirection, and tracker recording utilities

Primary docs:

- `../landscape/vr-projects-wave-331-overlay-surface-proxies-dashboard-notifications-hand-redirection-and-tracker-recording-utilities.md`
- `../landscape/project-families.md`

- `Eldon27232/KugouLyricsMirror` - `Studied in Wave 331 as a desktop lyrics/window proxy tool for VR capture with HWND capture, PrintWindow/BitBlt fallback, DWM proxy mode, chroma-key/region fallback, click-through/no-focus preview, and normal top-level capture target`
- `ZephyrVR/tempest-overlay` - `Studied in Wave 331 as an older Qt/OpenVR dashboard overlay with manifest/autolaunch helpers, QML-to-FBO texture submission, overlay event polling, keyboard integration, token file watching, Socket.IO notification rooms, and GPL/vendor caveats`
- `AndreZenner/hand-redirection-toolkit` - `Studied in Wave 331 as a Unity hand redirection research toolkit with RedirectionManager, HandRedirector subclasses, real/virtual target links, edit-mode analysis, threshold visualization, optional Leap/SRAnipal packages, and movement logging`
- `Avdbergnmf/SteamVR-Utils` - `Studied in Wave 331 as Unity SteamVR utilities for tracker serial mapping, tracker assignment UI, threaded pose recording, circular queues, UXF integration seams, and replay scaffolding`

## 303. A-Frame VR UI primitives, DOM surfaces, and in-scene input widgets

Primary docs:

- `../landscape/vr-projects-wave-332-aframe-vr-ui-primitives-dom-surfaces-and-input-widgets.md`
- `../landscape/project-families.md`

- `supereggbert/aframe-htmlembed-component` - `Studied in Wave 332 as an A-Frame HTML-to-plane surface with DOM mutation redraws, SVG/canvas texture rendering, raycaster pixel mapping, mouse/focus/input forwarding, and CSS hover/active/focus hacks`
- `binzume/aframe-xylayout` - `Studied in Wave 332 as an A-Frame flex-like layout and widget system with xycontainer, xyinput, rounded rects, text/canvas fallback, caret/copy/paste handling, keyboard request events, and hover haptics`
- `WandererOU/aframe-keyboard` - `Studied in Wave 332 as a compact A-Frame virtual keyboard with template rendering, desktop key forwarding, VR click forwarding, locale hooks, and button hover/press feedback`
- `EditVR/aframe-dialog-popup-component` - `Studied in Wave 332 as an A-Frame dialog popup component with configurable opener/close icons, title/body/image composition, visibility toggles, and camera-facing placement`

## 304. WebXR capability probes, pass-through testbeds, and lightweight utility labs

Primary docs:

- `../landscape/vr-projects-wave-333-webxr-capability-probes-pass-through-testbeds-and-utility-labs.md`
- `../landscape/project-families.md`

- `rwth-acis/i5-Toolkit-for-WebXR` - `Studied in Wave 333 as a WebXR helper toolkit with AR hit-test placement helper, boundary/edit reticle helper, loading indicator microclass, and render-hook based Three.js integration`
- `gareth-morgan-nv/WebXR-utils` - `Studied in Wave 333 as a browser XR capability probe and pass-through testbed with spec-linked feature checks, timeout wrappers, JSON report export, WebXR/WebGPU/media/WebRTC probes, and WebGL2 video/static plane rendering`
- `webvrdev/webvrdev-labs` - `Studied as a thin Wave 333 reference for a public WebXR utility lab index; current clone contains only README/license and no donor code yet`

## 305. Godot XR hand poses, spatial entities, wrist UI, and Android surface bridges

Primary docs:

- `../landscape/vr-projects-wave-334-godot-xr-hand-poses-spatial-entities-wrist-ui-and-android-surfaces.md`
- `../landscape/project-families.md`

- `Malcolmnixon/GodotXRHandPoseDetector` - `Studied in Wave 334 as a Godot XR hand pose recognizer with pose resources, hand tracker lookup, fitness functions, palm tracking gates, hold/release hysteresis, and pose started/ended signals`
- `Godot-Dojo/Godot-XR-AH` - `Studied in Wave 334 as a Godot XR auto-hand/radial-menu/spatial-anchor add-on set with controller/hand fallback, OpenXR joint-to-skeleton mapping, radial menu ray selection, and FB scene manager glue`
- `BastiaanOlij/spatial-entities-demo` - `Studied in Wave 334 as a Godot OpenXR spatial entities demo with tracker-to-scene management, persistent UUID-to-scene mapping, anchor child scenes, wrist SubViewport UI, and 3D touch-to-mouse injection`
- `GodotVR/godot-openxr-android-surface-plugin-example` - `Studied in Wave 334 as a Godot OpenXR Android surface composition-layer example with Android plugin export wiring, get_android_surface handoff, Kotlin MediaPlayer surface update, and media-surface caveats`
- `yelrom0/godot-openxr-notification-handler-plugin` - `Checked in Wave 334 as a low-maturity Godot Android notification plugin experiment; current source remains close to the plugin template and is not a donor implementation yet`

## 306. Unity XR research templates, data logging, scene flow, and minimal controller baselines

Primary docs:

- `../landscape/vr-projects-wave-335-unity-xr-research-templates-data-logging-scene-flow-and-controller-baselines.md`
- `../landscape/project-families.md`

- `TAU-XR/TAUXR-Research-Template` - `Studied in Wave 335 as a Unity XR research template with base scene, TXR player singleton, data manager, scene manager, continuous CSV logging, hand/eye/face tracking surfaces, calibration, and Meta Interaction SDK coexistence notes`
- `TAU-XR/TAUXR-OpenTemplate` - `Studied in Wave 335 as an open Unity XR template variant reinforcing the TXR base-scene/data-manager/scene-manager structure with sample scenes, Quest settings, and third-party package caveats`
- `dilmerv/XRToolKitPlayerController` - `Studied in Wave 335 as a minimal Unity XR player controller baseline with XRNode device lookup, joystick movement, jump gating, rigidbody/capsule setup, and scene/component existence tests`
- `traggett/UnityXRInteractionToolkitExtensions` - `Rejected in Wave 335 as an empty repository with no current code donor value`

## 307. Headsetless OpenXR, Godot, Bevy, and runtime simulator harnesses

Primary docs:

- `../landscape/vr-projects-wave-336-headsetless-openxr-godot-bevy-and-runtime-simulator-harnesses.md`
- `../landscape/project-families.md`

- `jrng/openxr_simulator` - `Studied in Wave 336 as a runtime-level OpenXR simulator with loader negotiation, session/view/swapchain stubs, D3D11/OpenGL paths, stereo view config, keyboard/mouse HMD motion, and runtime registration caveats`
- `Cafezinhu/godot-vr-simulator` - `Studied in Wave 336 as a Godot editor autoload that injects XRCamera3D/XRController3D tracker poses and OpenXR action-map inputs from keyboard, mouse, scroll, and controller-selection keys`
- `sanky369/OpenXRSim` - `Studied in Wave 336 as an Unreal XR simulator plugin with HMD/input-device modules, shared simulator state, Slate panel, room JSON, XInput, UDP forwarding, and JSON record/replay`
- `kcking/bevy_xr_app` - `Studied in Wave 336 as a Bevy OpenXR starter template with simulator/editor/Quest/PCVR mode separation and headsetless WASD/mouse development framing`
- `demonixis/OpenXR-OSX` - `Studied in Wave 336 as a broad OXRSys runtime/operator reference with runtime JSON selection, Home apps, Quest/PICO client telemetry, Unity editor helper, macOS loader postprocessor, and simulator windows`

## 308. OpenVR notification primitives, overlay wrappers, and Windows toast bridges

Primary docs:

- `../landscape/vr-projects-wave-337-openvr-notification-primitives-overlay-wrappers-and-windows-toast-bridges.md`
- `../landscape/project-families.md`

- `AlexMcArdle/openvr-notifications` - `Checked in Wave 337 as a thin README-level OpenVR notification direction marker with no current code donor value`
- `BOLL7708/OpenVRNotificationTest` - `Studied in Wave 337 as a minimal C# OpenVR notification primitive with background init, overlay creation, bitmap channel preparation, NotificationBitmap_t, and IVRNotifications.CreateNotification`
- `erenoa-6621/vr-notification-overlay` - `Studied in Wave 337 as a Windows notification to OpenVR overlay app with listener permission, queue/filter/history/settings pipeline, Skia renderer, dashboard settings, SteamVR manifest, and installer/portable packaging`
- `OVRTools/OVRSharp` - `Studied in Wave 337 as a C# OpenVR overlay wrapper with application-type init, dashboard/normal overlays, texture submission, tracked-device transforms, curvature/alpha/mouse scale, and event polling`

## 309. Browser VR video players, projection modes, and in-headset media libraries

Primary docs:

- `../landscape/vr-projects-wave-338-browser-vr-video-players-projection-modes-and-in-headset-media-libraries.md`
- `../landscape/project-families.md`

- `TimoWilhelm/vr-player` - `Studied in Wave 338 as a modern WebXR 180/360 player with mono/top-bottom/left-right layout enums, drag/drop and URL input, worker-assisted video layout recognition, requestVideoFrameCallback texture upload, and split debug/VR renderers`
- `Bivrost/360WebPlayer` - `Studied in Wave 338 as a mature embeddable browser 360 player with declarative player tags, mono/stereo video and picture support, HLS, touch/keyboard/gyro/WebVR input, browser matrix, CORS/HTTPS caveats, and older WebVR constraints`
- `michal-repo/web_vr_video_player` - `Studied in Wave 338 as an in-headset WebXR media-library player with JSON media catalogs, filename projection tags, generated thumbnails, search/sort, VR keyboard, draggable panels, controller shortcuts, and screen/projection switching`

## 310. Unreal vendor OpenXR interaction samples, hand tracking, and MR feature bridges

Primary docs:

- `../landscape/vr-projects-wave-339-unreal-vendor-openxr-interaction-samples-hand-tracking-and-mr-feature-bridges.md`
- `../landscape/project-families.md`

- `picoxr/PICO_UE5_OpenXRSample` - `Studied in Wave 339 as a PICO Unreal OpenXR sample with hub scene, controller interaction, locomotion, teleport, UI, grab/remote grab, haptics, hand gestures, pinch grab, V-gesture return, and full-body avatar tracking`
- `oculus-samples/Unreal-InteractionSDK-Sample` - `Studied in Wave 339 as a Meta Unreal Interaction SDK sample with explicit Meta XR/Interaction SDK dependency boundaries, C++ sample plugin helpers, setup docs, and license constraints`
- `demonixis/FSOpenXRHandTracking` - `Studied in Wave 339 as an Unreal OpenXR hand tracking plugin with FXRMotionControllerData updates, instanced/wireframe rendering, pinch detection, Enhanced Input hooks, lagged hand rays, and MetaXR skeleton bridge`
- `varjocom/VarjoUnrealOpenXRExamples` - `Studied in Wave 339 as a Varjo Unreal OpenXR example project for pass-through MR, depth occlusion, foveated rendering, markers, eye tracking, hand tracking, branch/version policy, and vendor hardware caveats`

## 311. visionOS native spatial rendering, WebXR probes, and XR provider boundaries

Primary docs:

- `../landscape/vr-projects-wave-340-visionos-native-spatial-rendering-webxr-probes-and-xr-provider-boundaries.md`
- `../landscape/project-families.md`

- `metal-by-example/metal-spatial-rendering` - `Studied in Wave 340 as a native visionOS Metal/CompositorServices renderer with ARKit world tracking, render thread, predicted frame timing, device-anchor queries, dedicated versus layered drawable paths, per-view pose constants, vertex amplification, mixed/full immersion behavior, and platform-specific caveats`
- `chrisdubya/avp-threejs-webxr-test` - `Studied in Wave 340 as a small WebXR/Three.js Apple Vision Pro probe with hand/controller setup, pinchstart/pinchend object spawn/grab/scale, fingertip collision checks, MediaRecorder microphone capture, and permission/browser-support caveats`
- `needle-mirror/com.unity.xr.visionos` - `Studied in Wave 340 as Unity's visionOS XR provider package reference with LayerRenderer access, immersive-space readiness, simulator detection, authorization events, frame-repeat API, XR subsystems, build processors, AR image/object resource packaging, and project validation rules`
- `IvanCampos/visionOS-examples` - `Studied in Wave 340 as a SwiftUI/RealityKit visionOS microapp gallery with head anchoring, battery widgets, hand tracking, controller input, WebSocket/social feed examples, chat/search surfaces, music/countdown apps, and broad sample-maturity caveats`

## 312. visionOS Unity plugin bridges, WebView surfaces, and controller adapters

Primary docs:

- `../landscape/vr-projects-wave-341-visionos-unity-plugin-bridges-webview-surfaces-and-controller-adapters.md`
- `../landscape/project-families.md`

- `apple/unityplugins` - `Studied in Wave 341 as Apple framework bridge packages for Unity with Apple.Core build profiles/postprocess steps, native wrappers, signing/Xcode command wrappers, Accessibility nodes, CoreHaptics, GameController, GameKit, PHASE, and SpatialController package surfaces`
- `vuplex/visionos-metal-webview-example` - `Studied in Wave 341 as a visionOS Metal-mode Unity WebView integration sample with world-space Canvas WebView, event camera, Tracked Device Graphic Raycaster, passthrough toggle, PolySpatial/XR loader settings, mock editor fallback, and commercial native package caveat`
- `surreal-interactive/SDK` - `Studied in Wave 341 as a Surreal Touch visionOS controller SDK with Oculus-style input API mapping, SVRCameraRig, SVRInput manager/controller/device layers, hand/controller tracking-mode switch, haptic API, grab/distance-grab scripts, and Bluetooth plist postprocessor`
- `TonGarcia/UnityVisionVRTemplate` - `Studied in Wave 341 as a Unity visionOS setup template/checklist with ARKit/OpenXR/XR Hands/XRI/PolySpatial package guidance, simulator workflow, URP/foveation/depth notes, VolumeCamera concepts, hand expression captures, and version-fragile docs caveat`

## 313. Spectator cameras, mixed-reality capture, and multiplayer observer roles

Primary docs:

- `../landscape/vr-projects-wave-342-spectator-cameras-mixed-reality-capture-and-multiplayer-observer-roles.md`
- `../landscape/project-families.md`

- `Unity-Technologies/VR-Spectator-Sample` - `Studied in Wave 342 as a minimal Unity spectator-camera sample with overlay-only spectator view camera, movable spectator camera, attachment-point cycling, preview displays, visual/UI object naming, and old-sample caveats`
- `microsoft/MixedReality-SpectatorView` - `Studied in Wave 342 as a mature HoloLens/MRC spectator stack with calibration data providers, camera intrinsics/extrinsics, spatial coordinate services, Azure Spatial Anchors and QR/ArUco marker localization, compositor wrapper, pose cache, time sync, texture manager, TCP networking, and mobile recording services`
- `Microsoft/MixedRealityCompanionKit` - `Studied in Wave 342 as a legacy MR companion toolkit with remoting host, KinectIPD, remote compositor, spectator view, commander, asset bundler, stage/menu managers, network state, calibration zones, persistence, spatial mapping, and HoloToolkit-era caveats`
- `spatialos/sdk-for-unity-vr-starter-project` - `Studied in Wave 342 as a multiplayer VR starter reference with headset-player versus mouse/keyboard spectator roles, replicated HMD/controller offsets, teleport targeting, server-validated grabbing, grabbable transform/rigidbody handlers, and obsolete SpatialOS SDK caveat`

## 314. Physics hands, two-hand interaction, and hand data capture baselines

Primary docs:

- `../landscape/vr-projects-wave-343-physics-hands-two-hand-interaction-and-hand-data-capture-baselines.md`
- `../landscape/project-families.md`

- `oxters168/VRPhysicsHands` - `Studied in Wave 343 as a Unity/Oculus physics-hand baseline with force/joint-driven hands, BoneId/BonePart/HandBoneValues, hand emulator, input-to-bone manipulator interface, Oculus hand/touch input adapters, grabber bridge, and Quest/Oculus dependency caveats`
- `emilyslouie/xri-two-hands` - `Studied in Wave 343 as an XRI two-hand interaction prototype set with dynamic attach points, multi-grabbable objects, CustomInteractionManager, ObjectManipulator, VirtualTransformChild, bow/arrow/notch/quiver/pull scripts, staff/stick/cymbal/lawn tools, and Hackweek asset-heavy caveats`
- `needle-mirror/com.unity.xr.hands` - `Studied in Wave 343 as Unity XR Hands package reference with XRHandSubsystem/provider APIs, joints/mesh/MetaAim/common gestures, skeleton driver, tracking events, OpenXR feature drawers, hand capture recording blobs, frame buffers, playback providers, time controllers, and coordinate transforms`
- `sketchpunklabs/xrhand` - `Studied in Wave 343 as a WebXR/Three.js hand prototype lab with XRManager, XRInputManager, XRController, XRHand, XRSlideLocomotion, dynamic mesh/debug helpers, GLTF utilities, hand model prototypes, and browser/device support caveats`

## 315. Molecular scientific visualization and interactive simulation viewers

Primary docs:

- `../landscape/vr-projects-wave-344-molecular-scientific-visualization-and-interactive-simulation-viewers.md`
- `../landscape/project-families.md`

- `LBT-CNRS/UnityMol-Releases` - `Studied in Wave 344 as a large Unity molecular workbench with PDB/mmCIF/GRO/MOL2/SDF/XYZ import, trajectory support, selection language, Python console, save/load commands, HyperBalls, surfaces, and VR scenes`
- `ur-whitelab/simview` - `Studied in Wave 344 as a HOOMD/ZeroMQ molecular simulation viewer with frame queues, interpolated positions, particle names, bonds, GPU molecule system, VR/AR scenes, and instructor view`
- `kwstanths/MRend` - `Studied in Wave 344 as a compact Unity PDB parser/render baseline with ATOM/HETATM parsing, Angstrom-to-nanometer conversion, atom spawning, and mock-HMD settings`
- `WangLabforComputationalBiology/VisionMol` - `Studied in Wave 344 as a Quest-oriented protein viewer with multiple molecular representations, labels, distance measurement, molecule merging/splicing, residue coloring, and VR manipulation`
- `RBVI/LookSee` - `Studied in Wave 344 as a Quest molecular/cell scene viewer that receives GLTF scenes exported from UCSF ChimeraX and uses GLTFast plus Oculus/OpenXR loaders`
- `IRL2/nanover-imd-vr` - `Studied in Wave 344 as an interactive molecular dynamics client with service discovery, WebSocket/autoconnect paths, controller manager, simulation-space manipulation, passthrough, calibration, and user commands`

## 316. CAD BIM industrial XR and training workflows

Primary docs:

- `../landscape/vr-projects-wave-345-cad-bim-industrial-xr-and-training-workflows.md`
- `../landscape/project-families.md`

- `LukeA25/vrCadViewer` - `Studied in Wave 345 as a Quest CAD viewer with grab, slice, explode, draw, pointer tools, mode switching, EzySlice integration, and original-position mapping`
- `UnityCommunity/CADImportExport` - `Studied in Wave 345 as a source-light runtime CAD import/export direction marker for Unity desktop and Quest/Android targets`
- `giorgosfatouros/XR2IND-VR` - `Studied in Wave 345 as an industrial VR training app with tutorial/assembly/troubleshooting rooms, task whiteboards, interactive network-equipment models, STT, LLM assistant REST calls, and RAG/manual dependency`
- `krishnahsanghani-netizen/visualyze-core` - `Studied in Wave 345 as a Visualyze MVP with Unity VR client plus Revit edit applier that reads JSON edit logs and moves elements inside a transaction`
- `isaddiq/BIMUniXchange` - `Studied in Wave 345 as a BIM-to-Unity pipeline with Archicad Python metadata extraction, Revit/Archicad/Unity documentation, CSV samples, and export summaries`
- `game4automation/realvirtual-WEB` - `Studied in Wave 345 as a web industrial digital-twin/HMI surface with React/TypeScript annotation panels, tooltips, sim-controller toolbar, layout planner, MCP bridge, and Teams shell`

## 317. Accessibility low-vision audio haptics and sign-language VR tools

Primary docs:

- `../landscape/vr-projects-wave-346-accessibility-low-vision-audio-haptics-and-sign-language-vr-tools.md`
- `../landscape/project-families.md`

- `microsoft/SeeingVRtoolkit` - `Studied in Wave 346 as an accessibility toolkit with magnification shaders, post-processing tools, SteamVR bindings, and low-vision support framing`
- `SuHCI/MagniVR` - `Studied in Wave 346 as a magnifier-focused VR prototype that builds on SeeingVR-style tools, render textures, hand-held magnifier prefabs, and challenge scenes`
- `xability/punch-pulse` - `Studied in Wave 346 as an accessible VR boxing game with audio-direction cues, boundary collision sounds, menu toggles, haptics/Bhaptics assets, and audio mixers`
- `hojats7731/VRSignify` - `Studied in Wave 346 as a source-light Quest 3 ASL-to-text product direction marker with hand tracking and custom ML claims but limited visible donor scripts`
- `dillondrum70/ASL-Passthrough` - `Studied in Wave 346 as a Quest hand tracking and passthrough ASL/spell gesture recognizer with HandPose/HandGesture assets, pose stack, hold times, null-time tolerance, two-hand gestures, and editor pose capture`
- `cpvrlab/vrTrainingFingerAlphabet` - `Studied in Wave 346 as an Oculus Quest finger alphabet trainer with saved hand forms, finger-angle/tip-distance/wrist-orientation scoring, debug canvas, virtual hand feedback, and German documentation`

## 318. NeRF Gaussian splat and light-field VR viewers

Primary docs:

- `../landscape/vr-projects-wave-347-nerf-gaussian-splat-and-light-field-vr-viewers.md`
- `../landscape/project-families.md`

- `uhhhci/immersive-ngp` - `Studied in Wave 347 as a Unity/instant-ngp stereo NeRF renderer with native plug-in wrapper, external textures, OpenGL/OpenVR/MRTK setup, DLSS support, 6DoF locomotion, volume slices, crop/FoV/edit concepts, and Magic NeRF Lens branch`
- `alexwing/nerf_Unity_VR` - `Studied in Wave 347 as a smaller Unity NeRF VR experiment with camera/depth/scene scripts, Quest/URP project settings, and source-light but useful scene-shell evidence`
- `zachdrouin/GaussianSplatViewer` - `Studied in Wave 347 as a Quest 3 Gaussian splat viewer with async binary PLY loader, Burst jobs, Gaussian data model, compute shaders, radix sort, culling, LOD/streaming managers, VR file browser, and locomotion`
- `julienkay/LightfieldVideoUnity` - `Studied in Wave 347 as a release-only light-field video viewer concept for Quest/Rift with compiled releases and explicit Unity/proprietary playback caveats`

## 319. Gaze eye analytics, saccade/fixation analysis, and XR behavior telemetry

Primary docs:

- `../landscape/vr-projects-wave-348-gaze-eye-analytics-saccade-fixation-and-xr-behavior-telemetry.md`
- `../landscape/project-families.md`

- `MotorControlLearning/SaccadeVR-mobile` - `Source-light marker in Wave 348 as a mobile/Vive Pro Eye saccade study direction that reinforces protocol/detector/logging separation`
- `pupil-labs/hmd-eyes` - `Studied in Wave 348 as a Unity/Pupil eye-tracking plug-in with network request/subscription layers, gaze/pupil listeners, calibration flow, time sync, recording, annotations, screencast, and eye-frame visualization`
- `AndreZenner/saccade-detection` - `Studied in Wave 348 as a Vive Pro Eye online saccade/blink detector with velocity/acceleration/noise thresholds, inspector tuning, Unity events, test scenarios, and CSV logging`
- `ViveSoftware/VRS-Studio-OpenXR` - `Studied in Wave 348 as an HTC OpenXR vendor sample bundle with eye gaze, facial/body tracking, Ultimate Tracker, spectator camera, hand interaction, and capability-gating value`
- `Robertson-Lab/vrGazeCore-Toolbox` - `Studied in Wave 348 as a MATLAB/Python VR gaze analytics toolbox with raw-data parsing, confidence filtering, fixation detection, duration/time-segmented heatmaps, GIF outputs, and headset parameters`
- `GossipAnalyticsXR/Gossip_Analytics_Unity-SDK` - `Studied in Wave 348 as a Unity XR analytics SDK with auto tracker deployment, heatmaps, eye/hand/controller/session/device/performance trackers, environment keys, build checks, and uninstall tooling`

## 320. Rehabilitation biofeedback olfactory and vestibular training prototypes

Primary docs:

- `../landscape/vr-projects-wave-349-rehabilitation-biofeedback-olfactory-and-vestibular-training-prototypes.md`
- `../landscape/project-families.md`

- `praggam/REVIRE` - `Partially studied in Wave 349 as a Quest rehabilitation prototype with recording folders and LSL script evidence; queued for deeper session/telemetry inspection`
- `vladyslav-tsalko/REMIRE` - `Partially studied in Wave 349 as a Quest rehabilitation app marker with APK/docs/source layout and follow-up value for exercise flow and logging`
- `omarrayyann/A-Fine-Day` - `Studied in Wave 349 as a stroke rehab minigame suite with Oculus Rift, Ultraleap hand tracking, Whack-A-Mole/Baskets exercises, calibration, menu delay UX, velocity/acceleration graphs, and therapist progress framing`
- `aneall/NeuroScent` - `Studied in Wave 349 as a multimodal mental-wellbeing/biofeedback VR concept combining OpenBCI Galea, Varjo Aero, Project Nebula-style olfactory output, and scent/vision/biosignal setup notes`
- `soheilbr82/Mind-Controlled-Virtual-Car` - `Studied in Wave 349 as a Unity virtual car controlled by EEG/MATLAB signals using SSVEP direction selection, SMR move/stop gating, asynchronous command transport, and multi-camera feedback`
- `JDGuldager/AR-and-VR-Application-for-Vestibular-Dysfunction-in-Elderly` - `Studied in Wave 349 as a Quest 3 vestibular rehab prototype with foot-mounted controllers, frog/lily-pad stepping guidance, VR versus passthrough AR modes, difficulty timing/distance, and safety/user-acceptance evaluation`

## 321. XR robotics teleoperation hand pose streaming and operator datasets

Primary docs:

- `../landscape/vr-projects-wave-350-xr-robotics-teleoperation-hand-pose-streaming-and-operator-datasets.md`
- `../landscape/project-families.md`

- `arghyasur1991/synth-vr` - `Studied in Wave 350 as a Quest MR humanoid/robot package with Meta Building Blocks validation, hand-tracked MuJoCo bodies, MRUK room colliders, passthrough rendering, scene wizard, performance manager, lighting estimation, and permission checks`
- `unitreerobotics/xr_teleoperate` - `Studied in Wave 350 as a Unitree XR teleoperation framework with AVP/PICO/Quest support, Vuer/WebRTC/HTTPS setup, hand/controller modes, robot/end-effector selection, simulation/physical deployment, recording, IPC, and safety notes`
- `Improbable-AI/VisionProTeleop` - `Studied in Wave 350 as a Vision Pro robotics ecosystem with hand/head streaming, video/audio/simulation return streams, MuJoCo/Isaac AR scene streaming, egocentric dataset recording, cloud sync, calibration, and companion app`
- `XR-Robotics/XRoboToolkit-Unity-Client-Quest` - `Studied in Wave 350 as a Quest Unity teleoperation client with network/tracking/video/recording/log UI, pose channel toggles, A-button pause, remote stereo vision, data collection, JNI/Android video plugin, and QoS split`
- `GeneralTrajectory/dex-teleop` - `Studied in Wave 350 as a VR dexterous teleoperation stack with Vive Tracker to xArm, Quest hand tracking to Inspire hands, bimanual support, HDF5 synchronized recording, workspace limits, collision checks, and smooth re-engagement`
- `h2r/GHOST` - `Studied in Wave 350 as a Unity/Quest half of a Spot teleoperation system with immersive point-cloud visualization, gesture controls, URDF via ROSBridge, and ros_reality dependency`
- `wengmister/quest-wrist-tracker` - `Studied in Wave 350 as a Quest hand/wrist telemetry app with 21 landmarks, 6DoF wrist pose, UDP/TCP streaming, in-headset configuration, HUD/logs, phantom hand visualization, video streaming, and Python SDK`

## 322. Multisensory hardware feedback, olfactory, thermal, vibration, and drag haptics

Primary docs:

- `../landscape/vr-projects-wave-351-multisensory-hardware-feedback-olfactory-thermal-vibration-and-drag-haptics.md`
- `../landscape/project-families.md`

- `mimuc/RoboThermalHaptics` - `Studied in Wave 351 as an encountered-type thermal haptic display with Kinova cobot, Vive Pro Eye, Ultraleap, VR/robot calibration, and Cobity dependency`
- `Ultimatonium/sensoricFramework` - `Studied in Wave 351 as a Unity multisensory sender/receiver/device framework for tactile, thermal, olfactory, bHaptics, Cilia, ThermoReal, manager singleton, modifiers, and Doxygen docs`
- `egekaraca/Multisensory-VR-Gardens` - `Source-light marker in Wave 351 as a multisensory garden/therapy direction pending richer source evidence`
- `CUXR/Olfactory-Display` - `Studied in Wave 351 as a scent-generating hardware reference with PCB/Gerber/parts list around Seeed XIAO Sense, MOSFETs, atomizers, converter, headers, and batteries`
- `jdthamores/BioEssence` - `Studied in Wave 351 as a physio-olfactory wearable display with cardio-respiratory sensing, up to three simultaneous scents, PCB/electronics/case/Android app framing, and clinical research positioning`
- `amarqu88/Multisensory-Proximity-and-Transition-Cues` - `Studied in Wave 351 as a VR/AR limited-FOV awareness study with visual/audio/tactile proximity and transition cues, Steam Audio, extOSC, Raspberry Pi vibration setup, and study logging`
- `AndreZenner/dragon` - `Studied in Wave 351 as Drag:on, a DIY VR controller with air-resistance and weight-shift haptics, Arduino firmware, Unity serial package, circuit, 3D-print files, Vive Tracker alignment, and patent caveat`

## 323. Astronomy planetarium dome and archaeoastronomy viewers

Primary docs:

- `../landscape/vr-projects-wave-352-astronomy-planetarium-dome-and-archaeoastronomy-viewers.md`
- `../landscape/project-families.md`

- `arcAstroVR/arcAstroVR` - `Studied in Wave 352 as an archaeoastronomy Unity viewer with Stellarium HTTP bridge, file-watched six-sided skybox updates, GIS/location conversion, dataset selection, marker/line editing, and domemaster output`
- `mymess/Planetarium` - `Studied in Wave 352 as a Unity planetarium with local astronomy algorithms, sky/star models, and date/location/settings editor tooling`
- `imclab/VR-Planetarium` - `Studied in Wave 352 as a legacy Leap Motion planetarium with arm HUD, joyball hand interaction, constellation labels, video manager, and data-binding toggles`
- `At-Bristol/DEV0006-DataDomeUnityToolkit` - `Studied in Wave 352 as a dome projection toolkit with world/projection camera split, fisheye shader, cubemap capture, operator hotkeys, settings persistence, and FPS feedback`

## 324. Scientific exhibition gallery museum and depth-aware media spaces

Primary docs:

- `../landscape/vr-projects-wave-353-scientific-exhibition-gallery-museum-and-depth-aware-media-spaces.md`
- `../landscape/project-families.md`

- `eisclimber/ExPresS-XR` - `Studied in Wave 353 as a scientific OpenXR toolkit with rig setup, movement modes, interactions, hand/wrist menus, data gathering, questionnaires, debug console, localization, and setup dialogs`
- `eisclimber/VRMuseumTemplate` - `Studied in Wave 353 as a beginner-oriented VR exhibition workshop template with handout and completed exhibit structure on top of ExPresS-XR`
- `Hempp/street-art-gallery` - `Studied in Wave 353 as a compact gallery reference for spatial art display and simple room/media framing`
- `Kilamper/Art-Museum-VR` - `Studied in Wave 353 as a Spanish VR art room with creative 3D object interaction, pixel-art canvas, and floating instructions`
- `ericyoondotcom/OculusGooglePhotos` - `Studied in Wave 353 as an Oculus/Google Photos direction marker for external personal-media gallery ingestion`
- `usmanbutt-dev/VR-DepthAPI-Gallery` - `Studied in Wave 353 as a Quest gallery with local storage scanning, image display, opacity slider, movable panels, file browser, and Meta Depth API occlusion`
- `echo3Dco/Unity-Oculus-echo3D-demo-VR-Zoo-Explorer` - `Studied in Wave 353 as a cloud-managed VR zoo with echo3D project keys, scene metadata, model indexes, and audio/video project separation`

## 325. VR education AI tutor chemistry biology and medical procedure training

Primary docs:

- `../landscape/vr-projects-wave-354-vr-education-ai-tutor-chemistry-biology-and-medical-procedure-training.md`
- `../landscape/project-families.md`

- `kenny2077/ChemAI` - `Studied in Wave 354 as a Quest 3 chemistry lab with free-order stations, state-aware voice AI assistant, Azure OpenAI STT/chat/TTS, station failures, safety warnings, reset manager, and credential hygiene`
- `2227500/Team-Chem-Training-VR-App` - `Studied in Wave 354 as a chemistry training flow with onboarding, safety room, lab room, manual evaporator experiment, and quiz`
- `37743/Classroom-VR` - `Studied in Wave 354 as an AI tutor classroom direction with RAG/curriculum framing and teacher/persona structure`
- `VR-Biomolecules/HandsOnDNA` - `Studied in Wave 354 as a DNA outreach experience with lab-to-cell/atomic scale transition and sequenced interactive biomolecular activities`
- `CRISPGroup/Mission-Control-MRI-VR` - `Studied in Wave 354 as a Quest MRI familiarization app with story mission, bed/glide metaphor, movement feedback, caregiver controller role, and non-validated medical caveat`

## 326. MR digital twin safety drone robot and industrial control surfaces

Primary docs:

- `../landscape/vr-projects-wave-355-mr-digital-twin-safety-drone-robot-and-industrial-control-surfaces.md`
- `../landscape/project-families.md`

- `mr-talukdar/Pyrosafe-Game` - `Studied in Wave 355 as a fire/safety training direction marker for procedural safety scenarios and hazard-response framing`
- `limasantoss/fabrica-segura-vr` - `Studied in Wave 355 as a smart-factory safety microtraining with production-line navigation, emergency-stop interaction, and visible feedback`
- `Kreline1993/gardsbriller` - `Studied in Wave 355 as a Quest MR garden digital twin with JSON plant rows, MultiSet VPS localization, mode state machine, overview/picking/weeding modes, info panels, wrist menu, LOD/clustering icons, and localization toasts`
- `ACROSS-Lab/HoanKiemAirVR-Unity` - `Studied in Wave 355 as an environmental/air VR direction marker for city/environment monitoring surfaces`
- `ACROSS-Lab/Rac-VR` - `Studied in Wave 355 as an environmental/city VR direction marker with Windows case-collision hygiene caveats in the external source layout`
- `ototadana/TyDrone` - `Studied in Wave 355 as a Quest MR virtual cockpit for Tello drone using Android plugin notes, passthrough, hand/controller setup, and restored MRTK-style cockpit features`
- `AndreasFranke5/TwinCity` - `Studied in Wave 355 as a collaborative MR city digital twin with Cesium/Google 3D Tiles, Shared Spatial Anchors, Photon Fusion, markers, water-level simulation, map controls, and emergency-planning framing`
- `Mukheem/TwinTurbine` - `Studied in Wave 355 as a collaborative MR turbine digital twin with physical turbine, servo/generator/photoresistor data, SMHI API, dashboard, avatar guidance, Shared Spatial Anchors, Photon, and Proxima/debug surfaces`
- `Infinity-Spark/Infinity-Spark-App` - `Studied in Wave 355 as a HoloLens/ABB RobotStudio industrial robot monitoring/control dashboard direction`
- `SL-thws/Mixed-Reality-for-Training-in-Human-Robot-Collaboration` - `Studied in Wave 355 as a human-robot collaboration training direction marker for safety and role-based MR procedure design`

## 327. Guided breathing meditation wellness and stress protocol VR

Primary docs:

- `../landscape/vr-projects-wave-356-guided-breathing-meditation-wellness-and-stress-protocol-vr.md`
- `../landscape/project-families.md`

- `Mohit-Bagri/windmill-vr` - `Studied in Wave 356 as a compact Quest/Unity breathing microtool with coroutine phase loop, countdown text, rounds, text fading, and windmill exhale feedback`
- `InderSinghMehrok/breatheEase--CS-458-Project` - `Studied in Wave 356 as a multi-exercise wellness shell with box breathing, 4-7-8/10-second variants, meditation cards, session data, scene fades, orb pulse, yoga, and qigong modules`
- `Roseburgendy/VR_Breathing_Intervention` - `Studied in Wave 356 as a breath-driven narrative intervention with rhythm controller, breath pacer, beam segments, movement patterns, hand tracking, haptics, phase managers, and environmental responders`
- `IrtazaDevs/VR-Meditation` - `Source-light marker in Wave 356 as a mystical forest Quest meditation reference with dynamic perspectives, spline movement, optimized environment, guided breathing cues, and settings framing`
- `luffy-yu/FloatMind` - `Studied in Wave 356 as an AI-powered AR/VR meditation product reference with STT/TTS/LLM mood analysis, hand gestures, emotion bubbles, portal transitions, scene blending, and controller-free flow`
- `kalpthakkar/MindFit-Realm` - `Source-light marker in Wave 356 as a mindfulness/wellness direction queued for deeper guided-activity and emotional-state UX inspection`
- `MIEC/vr-tsst` - `Studied in Wave 356 as a VR Trier Social Stress Test protocol with participant IDs, NBack/Stroop tasks, NPC gaze/head behavior, timers, panels, and research-session management`

## 328. VR music instruments and embodied sound tools

Primary docs:

- `../landscape/vr-projects-wave-357-vr-music-instruments-hand-tracked-piano-drums-and-biosignal-audiovisual-tools.md`
- `../landscape/project-families.md`

- `SeungWon0927/VR_Piano` - `Studied in Wave 357 as a Quest hand-tracked piano where finger/key collisions trigger audio with semitone pitch offsets and README-noted lighting/tracking caveats`
- `JustinLin905/Pear-Piano` - `Studied in Wave 357 as an Oculus Interaction-heavy piano direction for comparing modern hand interaction substrate against simple collision-key approaches`
- `waltzaround/Matter-VR` - `Partially studied in Wave 357 as an embodied/physics music direction marker pending deeper instrument-surface inspection`
- `magicinthesky/VR-Drumming` - `Partially studied in Wave 357 as a drum-hit interaction marker for timing, collision, and percussive feedback comparison`
- `kahogeoff/vr-war-drum` - `Partially studied in Wave 357 as a war-drum/percussion marker with vendor-heavy source layout and follow-up value for hit-surface triage`
- `HackTheBrain/B-vr` - `Studied in Wave 357 as an EEG/OpenViBE-driven visual music architecture where alpha/beta/theta and trained parameters shape audio/visual state`
- `krebsm249/Vr-LeapMotion-playing-a-Piano` - `Studied in Wave 357 as a Leap Motion piano lesson/reference with CSV reader, teacher scripts, menu loaders, and Leap Interaction Engine physics UI`

## 329. VR creative authoring sculpting painting modeling and retrieval tools

Primary docs:

- `../landscape/vr-projects-wave-358-vr-creative-authoring-sculpting-painting-modeling-and-content-retrieval-tools.md`
- `../landscape/project-families.md`

- `eman2XR/Virtual-Studio` - `Studied in Wave 358 as a Unity VR painting/design toolkit with color picker, paint palette, eraser, paint brush, mesh extrusion, grabbables, networked brush traces, transform saver, and OBJ exporter`
- `DhruvaRawal/SculpIt` - `Studied in Wave 358 as a thin sculpt/draw reference with camera-rig spawning and line drawing scripts`
- `johnsandiego/PolySculpt` - `Partially studied in Wave 358 as a Poly/SteamVR sculpting direction queued for deeper custom script and VRTK-era interaction comparison`
- `not-surt/CarveVR` - `Partially studied in Wave 358 as a voxel sculpting direction marker for comparing abandoned/minimal sculpting implementations`
- `E-BAO/3D-VR-Painting` - `Partially studied in Wave 358 as an Oculus-era 3D painting direction marker for brush/stroke comparison`
- `Rowl1ng/SketchyVR` - `Studied in Wave 358 as a sketching pipeline with color manager, line/point managers, mesh line renderer, tube renderer, save sketch logic, OBJ exporter, and OBJ import loader`
- `SamuelBoerlin/3D-VR-Modelling-and-Vitrivr` - `Studied in Wave 358 as VR sculpting integrated with Vitrivr/Cineast retrieval, CSG/SDF/voxel components, query plates/results, JSON converter, OBJ loader, and API adapter`

## 330. VR sports fitness movement training badminton and reaction games

Primary docs:

- `../landscape/vr-projects-wave-359-vr-sports-fitness-movement-training-badminton-and-reaction-games.md`
- `../landscape/project-families.md`

- `oculus-samples/Unity-MoveFast` - `Studied in Wave 359 as a Meta fitness sample with hand-hit detectors, pose gates, target zones, velocity scoring, combo breakers, tutorial flow, results UI, and 90 FPS setting`
- `partharora1105/Badminton_VR` - `Partially studied in Wave 359 as a badminton direction marker for racket/shuttle interaction, scoring, and sport-specific movement comparison`
- `rishidevde/Badminton_Computer_Graphics` - `Partially studied in Wave 359 as a Quest 3 badminton direction marker with XR Interaction Toolkit, racket interaction, XR movement, and gameplay mechanics framing`
- `LittleQBerry/REVERIE-Sports` - `Partially studied in Wave 359 as a sports-learning/training direction marker for future drill and coaching comparison`
- `ticahere/VIRD-demo` - `Partially studied in Wave 359 as a movement/training demo marker for future sensor, rehab, or drill-loop inspection`
- `oculus-samples/Unity-UltimateGloveBall` - `Studied in Wave 359 as a Meta multiplayer sports sample with local/remote player entities, gloves, UI hover ownership, arena services, Photon/Netcode-style package boundaries, and voice/network caveats`

## 331. World switching hand controller transition interfaces and interaction showcases

Primary docs:

- `../landscape/vr-projects-wave-360-world-switching-hand-controller-transition-interfaces-and-interaction-showcases.md`
- `../landscape/project-families.md`

- `mott-lab/WorldSwitchUI` - `Studied in Wave 360 as CHI 2026 transition-interface software with portal/gallery/wheel/palette/WIM world previews, separated display and interaction controllers, target managers, study logging, and hand/controller fallback`
- `oculus-samples/Unity-NorthStar` - `Studied in Wave 360 as a Meta Quest showcase with debug menus, scene loaders, IK/retarget helpers, editor hygiene utilities, subtitle/dialogue surfaces, and vendor-sample caveats`
- `alexismorin/Unity-VR-Hand-Tracking-Template` - `Source-light marker in Wave 360 as a Quest hand-tracking bootstrap with performance-oriented Unity/Oculus setup notes and modular kit framing`
- `Corysia/Unity-Oculus-Example` - `Source-light marker in Wave 360 as an Oculus Integration starter recipe for animated hands, locomotion, collision, grabbing, Android/Quest graphics settings, and credential caveats`

## 332. Physics locomotion drag scale climb and bounds based XR interaction microtools

Primary docs:

- `../landscape/vr-projects-wave-361-physics-locomotion-drag-scale-climb-and-bounds-based-xr-interaction-microtools.md`
- `../landscape/project-families.md`

- `KavanBahrami/XRDrag` - `Studied in Wave 361 as an Unreal VR drag locomotion component for controller-driven move, rotate, scale, input mappings, plane locks, and grip-conflict caveats`
- `pierricklyons/real-motion-vr` - `Studied in Wave 361 as a Unity physics body locomotion rig with locomotion sphere, hexabody/capsule model, spring spine, crouch, jump preload, grabbing, and climbing`
- `DuckiesGaems/EasyXR` - `Studied in Wave 361 as lightweight Unity XR microtools with bounds buttons, cooldowns, editor/debug helpers, XR input climbing, layer checks, and non-rigidbody fallback`

## 333. Collaborative classrooms whiteboards avatar rooms and AI learning surfaces

Primary docs:

- `../landscape/vr-projects-wave-362-collaborative-classrooms-whiteboards-avatar-rooms-and-ai-learning-surfaces.md`
- `../landscape/project-families.md`

- `SimonCzy/Whiteboard-UnityXR` - `Studied in Wave 362 as an Oculus/Photon/Meta Avatar whiteboard with creation gesture, pen texture writing, poke/grab interaction, reset/debug controls, avatar spawner, connection manager, and entitlement gate`
- `AnnavarapuGanesh/VR-CLASSROOM` - `Studied in Wave 362 as a Unity classroom with Gemini AI tutor adapter, prompt/history classes, room/lobby scripts, board/text framing, and credential hygiene caveats`
- `AnnavarapuGanesh/VR-CLASSROOM-MULTIPLAYER` - `Partially studied in Wave 362 as a multiplayer classroom variant with Photon room/avatar direction, virtual board, AI tutor framing, and follow-up value for authority/sync inspection`

## 334. Voice intent command spellcasting and speech to XR action adapters

Primary docs:

- `../landscape/vr-projects-wave-363-voice-intent-command-spellcasting-and-speech-to-xr-action-adapters.md`
- `../landscape/project-families.md`

- `eugenek07/hairy-otter` - `Studied in Wave 363 as a Meta/Wit.ai VR spellcasting prototype with voice activation, transcript UI, Conduit intent mapping, command validation, and spell dispatcher`
- `ajinkyasatuse/Enchantress_AR` - `Studied in Wave 363 as a Unity AR voice-command prototype using Windows KeywordRecognizer, command dictionary, AR raycast placement, summon/fight/fly actions, and fallback spawn logic`
- `wit-ai/wit-unity` - `Studied in Wave 363 as a voice SDK substrate with VoiceService, request/transcription events, Conduit parameter mapping, intent/entity handlers, TTS/cache/audio, and lipsync boundaries`

## 335. VR inventory equipment sockets holsters and starter interaction templates

Primary docs:

- `../landscape/vr-projects-wave-364-vr-inventory-equipment-sockets-holsters-and-starter-interaction-templates.md`
- `../landscape/project-families.md`

- `Isabela-Tellez/InventarioArmasVR` - `Studied in Wave 364 as a Unity/XRI inventory and weapon project with Inventory ScriptableObjects, SlotInventory, item UI buttons, collectables, controller manager, and large XRI sample overlap caveat`
- `Fist-Full-of-Shrimp/FFOS-VR-Tutorial-Resources` - `Studied in Wave 364 as a tutorial resource pack with BodySocketInventory, HMD-relative socket heights, controller input display, flashlight, FPS display, and weapon/fire snippets`
- `Fist-Full-of-Shrimp/FFOS-Unity-VR-Template` - `Partially studied in Wave 364 as a starter VR template with HMD character-controller height updates, hand visibility on select, and teleportation ray toggles`

## 336. VR AR wayfinding waypoint arrows QR recentering and route cues

Primary docs:

- `../landscape/vr-projects-wave-365-vr-ar-wayfinding-waypoint-arrows-qr-recentering-and-route-cues.md`
- `../landscape/project-families.md`

- `bhartinderjoshi/Waypoint_Arrow` - `Studied in Wave 365 as a minimal target-facing waypoint arrow using Quaternion.LookRotation`
- `nlalert/AR-Indoor-Navigation` - `Studied in Wave 365 as an AR navigation shell with JSON target catalog, generated target facades, dropdown target selection, NavMesh path lines, QR code recentering, and floor/context switching`

## 337. Avatar embodiment mirror therapy tool use calibration and movement study harnesses

Primary docs:

- `../landscape/vr-projects-wave-366-avatar-embodiment-mirror-therapy-tool-use-calibration-and-movement-study-harnesses.md`
- `../landscape/project-families.md`

- `JashoBell/vr-tool-use` - `Studied in Wave 366 as a dissertation-grade embodiment/tool-use study harness with participant calibration, avatar IK target calibration, SteamVR universe alignment, UXF task flow, VRPN/Manus/OpenVR tracking, and One Euro filters`
- `eric-cornellvel/VR-MirrorTherapy` - `Studied in Wave 366 as a mirror-therapy Unity project with custom mirror rig scripts, hand tracking, transform/object following, sphere spawning/detection tasks, save data helpers, and Oculus SDK caveats`

## 338. XR analytics action recording telemetry SDKs and immersive data surfaces

Primary docs:

- `../landscape/vr-projects-wave-367-xr-analytics-action-recording-telemetry-sdks-and-immersive-data-surfaces.md`
- `../landscape/project-families.md`

- `yoonsang0910/ExplainableXR` - `Studied in Wave 367 as an XR action recorder and analytics framework with UserActionDescriptor, discrete/continuous actions, microphone/image/object capture, UAD output, processor, and dashboard direction`
- `ArborXR/abxrlib-for-unity` - `Studied in Wave 367 as an open XR analytics SDK with assessment/objective/interaction events, telemetry, storage, modules, device/org metadata, QR scanner, editor config, and backend protocol framing`
- `informXR/iXRLibForUnity` - `Studied in Wave 367 as an XR analytics SDK with authentication, event tracking, object/system/input tracking, debug window, exit poll, keyboard UI, and post-build/config tooling`
- `stonecodecs/visiograph` - `Studied in Wave 367 as a Unity VR data visualizer with TCP batch ingestion, async data transfer, main-thread 3D datapoint creation, camera/player input, teleport markers, and collider gating`
- `eliaCandela/Optimizing-Data-Visualization-Through-Virtual-Reality` - `Source-light marker in Wave 367 as a business-metrics VR data visualization direction with alert-aware dashboard framing but little source in the cloned tree`

## 339. XR network cybersecurity visualization and Wi-Fi mappers

Primary docs:

- `../landscape/vr-projects-wave-368-xr-network-cybersecurity-visualization-and-wifi-mappers.md`
- `../landscape/project-families.md`

- `danieljharris/PARSEC` - `Studied in Wave 368 as a collaborative VR cybersecurity network visualizer with node/edge graphs, service drill-down, wand probes, menu filters, presenter state, Photon Fusion networking, and perspective scaling`
- `Orgzales/Unity-XR-NetworkMapper-Project` - `Studied in Wave 368 as a Quest/Unity wireless network mapper with Android Wi-Fi API snippets, SSID/BSSID/RSSI/security metadata, signal pillars, hidden-network scan notes, scan history, passthrough markers, and HUD/database concepts`

## 340. Quest robot pose teleoperation and localization bridges

Primary docs:

- `../landscape/vr-projects-wave-369-quest-robot-pose-teleoperation-and-localization-bridges.md`
- `../landscape/project-families.md`

- `aadhithya14/Open-Teach` - `Studied in Wave 369 as a Meta Quest teleoperation and data-collection stack with Unity VR apps, ZMQ keypoint streams, hand-frame transforms, gesture pause/gripper mapping, robot operators, camera streams, configs, and datasets`
- `paulonhantumbojr/sawyer_vr_teleop` - `Studied in Wave 369 as a Quest 2 to Sawyer ROS teleoperation bridge with ROS TCP Connector, HMD/controller pose topics, desired trajectory generation, velocity control, gripper mapping, and safety caveats`
- `MARSProgramming/QuestNavTest` - `Studied in Wave 369 as a QuestNav FRC localization bridge with NetworkTables 4 topics, heartbeat, battery/connection state, pose/yaw zeroing, mount offset compensation, and wired/power adapter operational notes`

## 341. Medical volume XR viewers DICOM VRDF and hand AI interfaces

Primary docs:

- `../landscape/vr-projects-wave-370-medical-volume-xr-viewers-dicom-vrdf-and-hand-ai-interfaces.md`
- `../landscape/project-families.md`

- `cassandra-stack/CASSANDRA-XR` - `Studied in Wave 370 as a mixed-reality medical volume platform with REST study service, WebSocket status changes, VRDF loader, URP raymarch shaders, XR hand manipulation, brain menus, Gemini/voice assistant, and Quest reload-performance caveat`
- `SitronX/FNO-Hololens2-visualisation` - `Studied in Wave 370 as a HoloLens/PCVR volume viewer using UnityVolumeRendering, dataset folders, DICOM/NRRD/NIFTI/image sequence import, labels/segmentation sliders, hand/controller menus, async loading, progress handlers, and transform persistence`

## 342. Redirected walking path configurators and obstacle-aware redirectors

Primary docs:

- `../landscape/vr-projects-wave-371-redirected-walking-path-configurators-and-obstacle-aware-redirectors.md`
- `../landscape/project-families.md`

- `klngbhn/RDW_CurvedPathConfigurator` - `Studied in Wave 371 as a Unity editor tool for curve-based redirected-walking path layouts with joint points, curves, intersections, gain, tracking-space side length, safety distance, walking radius, and ScriptableObject persistence`
- `omegafantasy/Bypassing-Obstacles` - `Studied as an OpenRDW2 variant in Wave 371 for obstacle-aware redirected walking, bypass redirector policy, waypoint/VE path logic, curvature/rotation/translation gain reasoning, and fork-lineage caveats`

## 343. Tilia input adapters and action composition packages

Primary docs:

- `../landscape/vr-projects-wave-372-tilia-input-adapters-and-action-composition-packages.md`
- `../landscape/project-families.md`

- `ExtendRealityLtd/Tilia.Input.UnityInputManager` - `Studied in Wave 372 as a legacy Unity Input Manager wrapper into neutral Zinnia-style Boolean/Float/Vector action streams`
- `ExtendRealityLtd/Tilia.Input.UnityInputSystem` - `Studied in Wave 372 as Unity Input System callback/property transformers, typed action conversion, GenericXR sample direction, and velocity tracker source`
- `ExtendRealityLtd/Tilia.Input.CombinedActions.Unity` - `Studied in Wave 372 as action-composition utilities for axes-to-vector, axes-to-angle, angle ranges, boolean-to-axis, double-click, and command grammar primitives`

## 344. Tilia pointers spatial targets and pointer grabbers

Primary docs:

- `../landscape/vr-projects-wave-373-tilia-pointers-spatial-targets-and-pointer-grabbers.md`
- `../landscape/project-families.md`

- `ExtendRealityLtd/Tilia.Indicators.ObjectPointers.Unity` - `Studied in Wave 373 as straight/curved object pointer prefabs with caster/origin/segment/destination extraction, ray visuals, and event payload boundaries`
- `ExtendRealityLtd/Tilia.Indicators.SpatialTargets.Unity` - `Studied in Wave 373 as hover/activation spatial target state with flags, source validity, collidable objects, dispatchers, and target override behavior`
- `ExtendRealityLtd/Tilia.Interactions.PointerInteractors.Unity` - `Studied in Wave 373 as pointer and distance grabber layer connecting object pointers, raycast rules, target validity, and interactable output`

## 345. Tilia interactables snap zones locomotion and camera rigs

Primary docs:

- `../landscape/vr-projects-wave-374-tilia-interactables-snap-zones-locomotion-and-camera-rigs.md`
- `../landscape/project-families.md`

- `ExtendRealityLtd/Tilia.Interactions.Interactables.Unity` - `Studied in Wave 374 as interactor/interactable facade model with touch/grab events, attach points, velocity trackers, provider/receiver boundaries, and conflict caveats`
- `ExtendRealityLtd/Tilia.Interactions.SnapZone.Unity` - `Studied in Wave 374 as snap zone state machine with validity, transition duration, scale policy, highlight state, initial snaps, and thrown-object auto-snap option`
- `ExtendRealityLtd/Tilia.Locomotors.Teleporter.Unity` - `Studied in Wave 374 as teleport target/offset/floor-snap/fade module with target validity, destination rotation, camera validity, and blink threshold settings`
- `ExtendRealityLtd/Tilia.Locomotors.AxisMove.Unity` - `Studied in Wave 374 as action-axis movement facade with target, forward offset, rotation pivot, scene-camera rules, multipliers, and movement events`
- `ExtendRealityLtd/Tilia.CameraRigs.XRPluginFramework.Unity` - `Studied in Wave 374 as XR Plugin Framework camera-rig package with node records, prefab creator, and rig adapter boundary`
- `ExtendRealityLtd/Tilia.CameraRigs.SpatialSimulator.Unity` - `Studied in Wave 374 as spatial simulator package direction for headsetless/editor spatial interaction and rig abstraction`

## 346. Tilia haptics pseudo-body hand visuals and collision faders

Primary docs:

- `../landscape/vr-projects-wave-375-tilia-haptics-pseudobody-hand-visuals-and-collision-faders.md`
- `../landscape/project-families.md`

- `ExtendRealityLtd/Tilia.Output.InteractorHaptics.Unity` - `Studied in Wave 375 as interactor-to-controller haptic routing with tracked alias, left/right interactors, queued interactor, profile, intensity, and cancel flows`
- `ExtendRealityLtd/Tilia.Trackers.PseudoBody.Unity` - `Studied in Wave 375 as collidable pseudo-body tracker with source/offset, external mutators, collision prevention, divergence thresholds, grounding, jump, and ignored-object policy`
- `ExtendRealityLtd/Tilia.Visuals.BasicHand.Unity` - `Studied in Wave 375 as lightweight hand/controller visual package boundary for presence without owning a full avatar stack`
- `ExtendRealityLtd/Tilia.Visuals.CollisionFader.Unity` - `Studied in Wave 375 as collision-triggered camera overlay/fade module with source follower, camera validity, collision validity, fade/unfade events, and diagnostics caveat`

## 347. Tilia spatial buttons highlighters and world UI state

Primary docs:

- `../landscape/vr-projects-wave-376-tilia-spatial-buttons-highlighters-and-world-ui-state.md`
- `../landscape/project-families.md`

- `ExtendRealityLtd/Tilia.Interactions.SpatialButtons.Unity` - `Studied in Wave 376 as spatial click/toggle/option button prefabs with ButtonStyle records, enabled/hover/active/disabled state, text/mesh styling, and group dispatcher direction`
- `ExtendRealityLtd/Tilia.Visuals.InteractableHighlighter.Unity` - `Studied in Wave 376 as interactable highlight module with material overrides, interactor validity, highlight/unhighlight events, and touch/grab event routing`

## 348. Tilia controllables teleport targets and locomotion assist modules

Primary docs:

- `../landscape/vr-projects-wave-377-tilia-controllables-teleport-targets-and-locomotion-assist-modules.md`
- `../landscape/project-families.md`

- `ExtendRealityLtd/Tilia.Interactions.Controllables.Unity` - `Studied in Wave 377 as linear/angular constrained controls with joint/transform drive modes, axis limits, target values, editor creators, and slider/lever product value`
- `ExtendRealityLtd/Tilia.Locomotors.TeleportTargets.Unity` - `Studied in Wave 377 as point/area teleport target prefab package with editor creator boundary and destination helper value`
- `ExtendRealityLtd/Tilia.Locomotors.Climbing.Unity` - `Studied in Wave 377 as climbable/climbing module with climbing facade link and release velocity multiplier`
- `ExtendRealityLtd/Tilia.Locomotors.MovementAmplifier.Unity` - `Studied in Wave 377 as source-to-target movement amplification module with ignored radius, multiplier, and stabilization caveats`
- `ExtendRealityLtd/Tilia.Trackers.ColliderFollower.Unity` - `Studied in Wave 377 as source-following collider tracker with snap-on-enable and snap-to-source behavior`

## 349. OpenXR vendor camera rig and passthrough adapter packages

Primary docs:

- `../landscape/vr-projects-wave-378-openxr-vendor-camera-rig-and-passthrough-adapter-packages.md`
- `../landscape/project-families.md`

- `ExtendRealityLtd/Tilia.CameraRigs.OpenXR.Unity` - `Studied in Wave 378 as OpenXR rig adapter with node records, passthrough manager boundary, runtime-specific samples, and profile-switching direction`
- `ExtendRealityLtd/Tilia.SDK.PicoIntegration.Unity` - `Studied in Wave 378 as PICO SDK wrapper with XRNode-to-PXR controller mapping, connectivity, dominant-hand priority, passthrough toggles, and haptics direction`
- `ExtendRealityLtd/Tilia.SDK.WaveXR.Unity` - `Studied in Wave 378 as HTC WaveXR SDK wrapper package and vendor rig integration marker`

## 350. Zinnia core primitives and VRTK tutorial composition substrate

Primary docs:

- `../landscape/vr-projects-wave-379-zinnia-core-primitives-and-vrtk-tutorial-composition-substrate.md`
- `../landscape/project-families.md`

- `ExtendRealityLtd/Zinnia.Unity` - `Studied in Wave 379 as core Unity component primitive substrate with process moments, rule containers, observable lists, transformers, actions, casts, event proxies, and tests`
- `ExtendRealityLtd/VRTK.Tutorials.YouTube` - `Studied in Wave 379 as tutorial composition project with GlobalResources, Samples, Scenes, Tilia package importer, XR setup, and reference-scene caveats`

## 351. Godot Quest interaction toolkits saber game and hand rigging pipeline

Primary docs:

- `../landscape/vr-projects-wave-380-godot-quest-interaction-toolkits-saber-game-and-hand-rigging-pipeline.md`
- `../landscape/project-families.md`

- `NeoSpark314/godot_oculus_quest_toolkit` - `Studied in Wave 380 as Quest-focused Godot toolkit lineage with OQ_Toolkit, demos, utilities, GameMain shell, and older platform-assumption caveats`
- `arpruss/OpenSaberPlus` - `Studied in Wave 380 as Godot VR saber/rhythm game composition with OQ Toolkit assets, action map, game folder, Android/export boundary, and timing-loop donor value`
- `ClonedPuppy/Blender_OpenXR_Hand_Rigging` - `Studied in Wave 380 as narrow Blender-to-Godot OpenXR hand rigging pipeline with assets, scenes, scripts, and skeleton/import provenance questions`

## 352. Godot XR networking social avatar and WebRTC world shells

Primary docs:

- `../landscape/vr-projects-wave-381-godot-xr-networking-social-avatar-and-webrtc-world-shells.md`
- `../landscape/project-families.md`

- `goatchurchprime/Godot_XR_networking` - `Studied in Wave 381 as minimal Godot XR networking shell with Main scene/script, avatars, plug glue, action map, and authority/packet follow-up`
- `teddybear082/Godot_XR_Networking-Plus-Game` - `Studied in Wave 381 as expanded Godot XR networking/game variant with WebRTC, objects, scenes, and ownership/fallback questions`
- `zodiepupper/barkvr` - `Studied in Wave 381 as larger Godot VR social/world shell with barkvr-system, WebRTC, Android/export boundaries, and identity/privacy caveats`
- `Godot-Dojo/Deprecated-Godot-XR-Avatar` - `Studied in Wave 381 as deprecated Godot XR avatar/interactable lineage with hand, pickup, highlight, snap-zone, and interaction component taxonomy`

## 353. Godot cross-device OpenXR platform experiments

Primary docs:

- `../landscape/vr-projects-wave-382-godot-cross-device-openxr-samsung-avp-and-legacy-backend-experiments.md`
- `../landscape/project-families.md`

- `Jax-Danger/Godot-Samsung-XR` - `Studied in Wave 382 as compact Samsung/OpenXR Godot device experiment with Level, Player, scripts, action map, export preset, and artifact provenance caveat`
- `ibrews/godot-avp-cascade` - `Studied in Wave 382 as Apple Vision Pro-oriented Godot experiment envelope with engine-patches, test-project, tools, docs, captures, and patch-provenance lessons`
- `GodotVR/godot_openxr_for_godot_3.x` - `Deepened in Wave 382 as legacy Godot 3 OpenXR backend comparison node with src, Android samples, demo, action/session/space plumbing, and migration caveats`

## 354. Godot VR retrofit modloader profiles and AI NPC tooling

Primary docs:

- `../landscape/vr-projects-wave-383-godot-vr-retrofit-modloader-game-profiles-and-ai-npc-tooling.md`
- `../landscape/project-families.md`

- `teddybear082/UGVR` - `Studied in Wave 383 as Godot VR retrofit/injector shell with xr_injector, overridecfg, project shell, and rollback/profile safety follow-up`
- `teddybear082/UGVR_game_profiles` - `Studied in Wave 383 as per-game retrofit profile collection with game-named folders and target/version/provenance schema lessons`
- `teddybear082/CrueltySquadVR-Modloader` - `Studied in Wave 383 as modloader-style VR patch project with install scripts, modloader.gd, override.cfg, XR Tools graft points, and dry-run safety caveats`
- `teddybear082/godot-ai-npc-example` - `Studied in Wave 383 as Godot AI NPC example envelope with scripts, demo, assets, addons, fonts, and provider/privacy boundary questions`

## 355. Quest hand streaming steering and ROS bridge utilities

Primary docs:

- `../landscape/vr-projects-wave-384-quest-hand-streaming-steering-and-ros-bridge-utilities.md`
- `../landscape/project-families.md`

- `NU-MECH-ENG-495/vr-hand-tracking` - `Studied in Wave 384 as Unity/Meta Quest hand-joint capture plus UDP and ROS2 receiver/visualizer with launch and packet-schema follow-up`
- `minsley/avatar-quest` - `Studied in Wave 384 as native Quest OpenXR hand curl to ESP32 UDP stream with passthrough, TinyUI/debug overlay, extension setup, and hardcoded endpoint caveat`
- `yefeblgn/VR-Hand-Steering-Bridge` - `Studied in Wave 384 as PC OpenXR hand-joint reader mapping Quest/Virtual Desktop hand pose to vJoy steering with loader discovery and Kalman/config caveats`
- `lts0429/teleoperation` - `Studied in Wave 384 as Quest UDP pose bridge to ROS2 headset/left_hand/right_hand topics and TF frames with Unity-to-ROS coordinate conversion`

## 356. XR robot teleoperation control loops and dataset recorders

Primary docs:

- `../landscape/vr-projects-wave-385-xr-robot-teleoperation-control-loops-and-dataset-recorders.md`
- `../landscape/project-families.md`

- `fiveages-sim/xr_teleoperate_ocs2_ros2` - `Studied in Wave 385 as XR teleoperation control loop with TeleVuer, shared-memory image feeds, arm/end-effector adapters, simulation/headless flags, and episode recorder`
- `IIT-SoftBots/UnitySoftbotsTeleopRelease` - `Studied in Wave 385 as Unity soft-robot teleoperation shell with Movement SDK body calibration, ROS1/ROS2 compatibility, broadcast discovery, UI modules, and license/completeness caveats`
- `stex2005/Unity-HTC` - `Studied in Wave 385 as SteamVR Null Driver headsetless tracker setup with tracker-to-object binding, logical roles, dynamic swapping, and serial persistence follow-up`

## 357. XR hardware runtime templates and Omniverse OpenXR bindings

Primary docs:

- `../landscape/vr-projects-wave-386-xr-hardware-runtime-templates-and-omniverse-openxr-extension-bindings.md`
- `../landscape/project-families.md`

- `Adjuvo/Unity-Template` - `Studied in Wave 386 as SenseGlove Unity template with example interactions, headset-specific settings, gesture teleport, and hardware/plugin provenance caveats`
- `Toni-SM/semu.xr.openxr` - `Studied in Wave 386 as Omniverse OpenXR extension with Python binding, GUI launcher, action subscription, haptics, stereo rendering, native bins, and extension lifecycle lessons`

## 358. Spatial application UX patterns for science rehab and strategy tools

Primary docs:

- `../landscape/vr-projects-wave-387-spatial-application-ux-patterns-for-science-rehab-and-strategy-tools.md`
- `../landscape/project-families.md`

- `Superkart/Immersive_Cosmology_Explorer` - `Studied in Wave 387 as Unity VR/desktop scientific visualization workbench with point-cloud filtering, radial menus, session state, collaboration framing, and asset provenance caveats`
- `WallerTheDeveloper/vr-tower-defense` - `Studied in Wave 387 as Quest passthrough strategy game reference with wrist tower menu, pinch gestures, factories, commands, state machines, pooling, and spatial UI lessons`
- `vladyslav-tsalko/REMIRE` - `Deepened in Wave 387 as MR rehabilitation task/grab-rule reference with MRUK, Meta XR Hands, adaptive placement, difficulty levels, grip strength, and missing LFS APK caveat`

## 359. Quest passthrough camera capture vision streaming and detection bridges

Primary docs:

- `../landscape/vr-projects-wave-388-quest-passthrough-camera-capture-vision-streaming-and-detection-bridges.md`
- `../landscape/project-families.md`

- `samuelm2/OpenQuestCapture` - `Studied in Wave 388 as Quest camera capture and 3D reconstruction package with QuestCameraLib, Unity wrapper, docs, rebuild script, and native-library provenance caveats`
- `danieloquelis/Unity-QuestVisionStream` - `Studied in Wave 388 as Unity Passthrough Camera API package with WebRTC streaming to external inference server and package/server split`
- `sandeepv6/questvision` - `Studied in Wave 388 as Quest 3 MR object detection sample with camera frames, server-side inference, 2D/3D bounding boxes, scene raycasts, and marker reliability questions`

## 360. MR templates world transform and scene-aware game samples

Primary docs:

- `../landscape/vr-projects-wave-389-mr-templates-world-transform-and-scene-aware-game-samples.md`
- `../landscape/project-families.md`

- `noritsune/quest-mr-template` - `Studied in Wave 389 as compact Meta Quest MR Unity template with MRUK setup, runtime action bindings, and recenter/scene-mesh caveats`
- `DecartAI/Decart-XR` - `Studied in Wave 389 as Quest real-time AI world-transformation app with Unity/service/WebRTC/voice boundary and provider privacy caveats`
- `oculus-samples/Unity-TheWorldBeyond` - `Studied in Wave 389 as official MR sample composition reference with Scene API, Passthrough, Voice SDK, Interaction SDK, Audio Spatializer, and MRUK`

## 361. MR robot SLAM user study and passthrough analysis dashboards

Primary docs:

- `../landscape/vr-projects-wave-390-mr-robot-slam-user-study-and-passthrough-analysis-dashboards.md`
- `../landscape/project-families.md`

- `mustafizur-r/WalkerProject` - `Studied in Wave 390 as MR gait rehab robot walker serious game with MRUK, Photon Fusion, MQTT robot coordination, patient/robot tracking, and safety caveats`
- `prakash-aryan/MR-SLAM` - `Studied in Wave 390 as Unity/Quest multi-robot SLAM dashboard with ROS2 map merge, Nav2 launch files, stats publisher, and namespace/freshness lessons`
- `danieljtrujillo/The-Future-is-Chrome-MIT-Reality-Hack-2026` - `Studied in Wave 390 as MR/robot hackathon app with Unity assets, robot-server, docs, Booster Robotics SDK assets, and vendor-drop caveats`
- `mi2lab/mrat-passthrough-quest` - `Studied in Wave 390 as MRAT passthrough user-testing toolkit with local/online recording, replay, live head/hand tracking, and consent/retention follow-up`

## 362. Hand interaction packages social tabletop and escape room samples

Primary docs:

- `../landscape/vr-projects-wave-391-hand-interaction-packages-social-tabletop-and-escape-room-samples.md`
- `../landscape/project-families.md`

- `Extrys/XRMasterHands` - `Studied in Wave 391 as Unity OpenXR hand tracking package with Runtime, Editor, Samples, skeleton driver, gesture samples, and hand pose-to-action mapping`
- `oculus-samples/Unity-SpiritSling` - `Studied in Wave 391 as official social MR tabletop sample with contextual board placement, shared anchors, avatars, networking, hand grabs, and LFS-heavy caveat`
- `francesctr4/EscapeRoomVR` - `Studied in Wave 391 as compact Unity VR escape-room reference with puzzle/object interaction structure and task-state follow-up`

## 363. Caption voice and descriptive accessibility surfaces

Primary docs:

- `../landscape/vr-projects-wave-392-caption-voice-and-descriptive-accessibility-surfaces.md`
- `../landscape/project-families.md`

- `XR-Access-Initiative/chirp-captions` - `Deepened in Wave 392 as caption runtime/package reference with renderer switching, timed captions, head-locked safe area, and source-direction cue lessons`
- `XR-Access-Initiative/voicesdk-samples-whisperer-captions` - `Studied in Wave 392 as Voice SDK accessible command sample with speak gesture, object commands, TTS/cache, prompts, and Wit.ai privacy caveats`
- `JustinMorera/VR-Accessibility-SDK` - `Studied in Wave 392 as compact partial-vision accessibility package with object targeting, descriptive text menus, prefab setup, and Input System command binding`

## 364. Low vision nonvisual and haptic accessibility toolkits

Primary docs:

- `../landscape/vr-projects-wave-393-low-vision-nonvisual-and-haptic-accessibility-toolkits.md`
- `../landscape/project-families.md`

- `XR-Access-Initiative/Vision-Accessibility-Toolkit` - `Studied in Wave 393 as FirstHand-derived visual accessibility toolkit/reference with hand-interaction scene base, audio cues, and vendor-sample extraction caveats`
- `SuHCI/MagniVR` - `Studied in Wave 393 as low-vision magnification research prototype with VR room, model, UI prototype, and lens/comfort follow-up`
- `xability/punch-pulse` - `Studied in Wave 393 as accessible VR boxing app for blind/low-vision users with spatial audio, haptic feedback, accessible menus, tutorial flow, and contribution checklist`

## 365. Sign language hand pose and gesture recognition training

Primary docs:

- `../landscape/vr-projects-wave-394-sign-language-hand-pose-and-gesture-recognition-training.md`
- `../landscape/project-families.md`

- `Somanyloopholes/SignPoseVR` - `Studied in Wave 394 as Quest ASL alphabet/digit trainer with learn/quiz modes, reference prompts, hand tracking, glow feedback, and hold-to-confirm scoring`
- `cpvrlab/vrTrainingFingerAlphabet` - `Deepened in Wave 394 as explainable finger alphabet trainer with saved hand forms, angle/tip/orientation scoring, debug canvas, and VRUI editor helpers`
- `MARUI-PlugIn/MiVRy` - `Studied in Wave 394 as multi-engine gesture recognition plugin with Unity, Unreal, Android, Windows, Linux, macOS, and UWP package boundaries`

## 366. Eye tracking sensory overload and calibration safety

Primary docs:

- `../landscape/vr-projects-wave-395-eye-tracking-sensory-overload-and-calibration-safety.md`
- `../landscape/project-families.md`

- `leonkoech/AutismDetector` - `Studied in Wave 395 as Magic Leap eye-tracking sensory-overload SDK with fixation/gaze features, demo scenes, EEG context, and clinical caveats`
- `mvidaldp/unity_htcvivepro_et_calibration` - `Studied in Wave 395 as Unity/SteamVR Vive Pro Eye calibration project with calibration harness structure and bundled asset caveats`

## 367. VR research toolkits posture and retrospective experience measurement

Primary docs:

- `../landscape/vr-projects-wave-396-vr-research-toolkits-posture-and-retrospective-experience-measurement.md`
- `../landscape/project-families.md`

- `MPIB/arc-vr` - `Studied in Wave 396 as package-based Unity VR research toolbox with core/motion/ui/avatar/phys/net package split, settings, dev console, logger, and GPL caveats`
- `immersivecognition/posture-assessment-vr` - `Studied in Wave 396 as UXF-backed posture/balance measurement app with session/trial lifecycle, operator UI, participant CSV updates, raw HMD motion logs, and analysis recipe`
- `revealcentre/retrosketch` - `Studied in Wave 396 as retrospective emotion/presence annotation tool with video replay, keypoints, continuous rating curves, text annotations, validation, and export flow`

## 368. Unity file media picker and import export surfaces

Primary docs:

- `../landscape/vr-projects-wave-397-unity-file-media-picker-and-import-export-surfaces.md`
- `../landscape/project-families.md`

- `yasirkula/UnitySimpleFileBrowser` - `Studied in Wave 397 as runtime uGUI file browser with filters, quick links, multi-select, coroutine/callback APIs, Android SAF support, Quest caveats, and recycled-list performance`
- `yasirkula/UnityNativeFilePicker` - `Studied in Wave 397 as Android/iOS document picker and export bridge with MIME/UTI filters, async callbacks, permission flow, native bridges, and persistent-copy caveats`
- `yasirkula/UnityNativeGallery` - `Studied in Wave 397 as Android/iOS gallery/photos media bridge with image/video/audio picking, save-to-gallery APIs, thumbnail loading, permission modes, and retention caveats`
- `gkngkc/UnityStandaloneFileBrowser` - `Studied in Wave 397 as desktop native open/save dialog wrapper for Windows/Mac/Linux with extension filters, async callbacks, and desktop-vs-headset ownership caveats`

## 369. Spatial room layout furniture placement and design persistence

Primary docs:

- `../landscape/vr-projects-wave-398-spatial-room-layout-furniture-placement-and-design-persistence.md`
- `../landscape/project-families.md`

- `TeamFWS/room-designer` - `Studied in Wave 398 as Quest MR room design app with MRUK room import, ray furniture placement, OVR spatial anchors, layout JSON, IKEA model loader, wall painting, and manual room grid`
- `pnlt/VNE5T-SolutionForAVR` - `Studied in Wave 398 as VR interior-design product reference with object manipulation, material swapping, measurement/annotation/snapshot/export claims, AI framing, and research-use caveats`
- `lakshmikosre/Elite-In-Decora` - `Studied lightly in Wave 398 as AR interior-design requirements/reference with catalog, gallery, product recommendation, cart, ARCore framing, and thin VR donor value`

## 370. VR task dataset locomotion and behavioral testbeds

Primary docs:

- `../landscape/vr-projects-wave-399-vr-task-dataset-locomotion-and-behavioral-testbeds.md`
- `../landscape/project-families.md`

- `michaelkoller/vacesimulator` - `Studied in Wave 399 as annotated VR kitchen dataset simulator with recipe HUD, recording toggle, object/action events, RGB/depth/segmentation renders, predicates, playback, and postprocess mode`
- `JohnBacho/VIBES-Lab-Project2` - `Studied in Wave 399 as eye-tracked VR behavioral study app with gambling task conditions, wallets, tutorial flow, trial CSV, pupil metrics, SRanipal, and ethics/privacy caveats`
- `VRatPolito/LET-VR` - `Studied in Wave 399 as OpenXR locomotion evaluation testbed with scenarios, configuration file, calibration artifact, locomotion manager, input wrapper, statistics loggers, and weighted scoring material`

## 371. VR welding and industrial procedure training

Primary docs:

- `../landscape/vr-projects-wave-400-vr-welding-and-industrial-procedure-training.md`
- `../landscape/project-families.md`

- `Marcel-Castro/VR-Welding` - `Studied with caveats in Wave 400 as an MRTK welding lab prototype with lesson objects, equipment attachments, gauges, regulator/valve scripts, and workstation composition value`
- `stjakubi/VR-SLM-printer` - `Studied in Wave 400 as a metal 3D-printer procedure trainer with part discovery, progress UI, contextual workflow errors, controller labels, and quiz-ready learning flow`
- `NandiniDevraj/WeldingSimulationSpline` - `Studied in Wave 400 as a spline-guided welding accuracy trainer with ghost/user pose comparison, distance/angle/speed scoring, guided/exam modes, HUD, summary, and ML-Agents hooks`

## 372. VR chemistry and laboratory learning scenarios

Primary docs:

- `../landscape/vr-projects-wave-401-vr-chemistry-and-laboratory-learning-scenarios.md`
- `../landscape/project-families.md`

- `chemistry-lab/chemistry-lab-vr` - `Studied in Wave 401 as a chemistry lab scenario toolkit with molecule/atom packs, grabbables, sampleable objects, scenario goal validators, scene transitions, and environment consequence feedback`
- `alinaduca/BachelorsThesis-UnityLab` - `Studied with caveats in Wave 401 as a chemistry education app with VR reactions, thesis/demo material, AI tutor/chatbot framing, book/canvas surfaces, and large vendor sample bundles`

## 373. VR surgery task scoring and medical simulation

Primary docs:

- `../landscape/vr-projects-wave-402-vr-surgery-task-scoring-and-medical-simulation.md`
- `../landscape/project-families.md`

- `UoA-eResearch/SurgeryQuest` - `Studied with caveats in Wave 402 as a Quest surgery simulator reference with hand/controller fallback and simple cutting interaction scripts`
- `IsaacYu15/VR-Surgery` - `Studied in Wave 402 as a surgery robot task simulator with cutting, grabbing, suturing, random cut paths, ring/rope checks, touch counters, velocity penalties, and score displays`

## 374. VR drone robot and operator-control testbeds

Primary docs:

- `../landscape/vr-projects-wave-403-vr-drone-robot-and-operator-control-testbeds.md`
- `../landscape/project-families.md`

- `vkrishnan998/UnityVR-Drone-Simulation` - `Studied with caveats in Wave 403 as a small VR drone/user-study movement baseline with rigidbody player control and camera-follow scripts`
- `GTamilSelvan07/Unity_VR_Drone_Simulator` - `Studied in Wave 403 as a compact drone-control prototype with movement methods, max-speed state, battery/player behaviour, collision-triggered power-ups, and penalty modifiers`
- `MPI-IS/ArmSym` - `Studied in Wave 403 as a VR assistive robotic-arm experiment harness with session/subject JSON, practice/trial progression, control-mode delegates, biosignal ingress, and preallocated CSV telemetry`

## 375. VR physics interaction grab joints and hand templates

Primary docs:

- `../landscape/vr-projects-wave-404-vr-physics-interaction-grab-joint-and-hand-templates.md`
- `../landscape/project-families.md`

- `TomorrowTodayLabs/NewtonVR` - `Studied in Wave 404 as a Unity physics interaction toolkit with rigidbody velocity matching, attach points, hand abstractions, levers, sliders, buttons, and SDK adapters`
- `JScott/ViveGrip` - `Studied in Wave 404 as a ConfigurableJoint-based VR grab abstraction with highlights, weighted objects, levers, dials, guns, and example-driven affordances`
- `JLPM22/VRPhysicsInteractionUnity` - `Studied with caveats in Wave 404 as a Quest physics interaction course project with nearby-object highlighting, lateral-trigger grab, and vendor bundle caveats`
- `jtnicholl/godot4-vr-physics-template` - `Studied in Wave 404 as a Godot 4 physical hand template with RigidBody3D hands, collision-blocked controller anchors, pickup/release scripts, and throw impulses`

## 376. VR math geometry visualization and classroom games

Primary docs:

- `../landscape/vr-projects-wave-405-vr-math-geometry-visualization-and-classroom-games.md`
- `../landscape/project-families.md`

- `Rud156/MathSaber` - `Studied in Wave 405 as a Beat-Saber-like math practice game with equation generators, block controllers, custom question data, analytics, and text-file logging`
- `PNCaruana/VR-Classroom` - `Studied in Wave 405 as a VR classroom visualization prototype with matrix-to-bar board graphs, color scaling, complex helpers, and 2D FFT utilities`
- `mtwoodard/hypVR-Ray` - `Studied in Wave 405 as a WebVR hyperbolic raymarching experiment with controller abstraction, display fallback, pose transforms, and shader-driven geometry`
- `jmacd/grraph` - `Lightly studied in Wave 405 as a thin Unity VR graph/math playground reference with follow-up needed for scene-level object models`

## 377. VR anatomy volume dissection and medical learning objects

Primary docs:

- `../landscape/vr-projects-wave-406-vr-anatomy-volume-dissection-and-medical-learning-objects.md`
- `../landscape/project-families.md`

- `chrislarkee/VR-Neuroanatomy` - `Studied in Wave 406 as a brain learning object with labelled/parcellated anatomy, brain part scripts, label toggles, slicing, laser/menu interaction, and dissection framing`
- `asemahassan/3DPuzzleVR` - `Studied in Wave 406 as an anatomy education puzzle with wand control, snapping, distance checks, physics/no-gravity variants, laser UI, and task reset follow-up`
- `malyalar/vr-volume-renderer` - `Studied in Wave 406 as a medical volume-rendering learning object with volume rendering controllers, slice/rotate exploration, and legacy mobile VR caveats`
- `auroey/mr-IMVA-unity` - `Studied with caveats in Wave 406 as an MRTK data/UX shell reference with data controllers, item placers, dialogs, sliders, pressable buttons, and layered UI examples`

## 378. VR museum AI guide exhibition analytics and web exhibit spaces

Primary docs:

- `../landscape/vr-projects-wave-407-vr-museum-ai-guide-exhibition-analytics-and-web-exhibit-spaces.md`
- `../landscape/project-families.md`

- `KuhakuNeko/VR-AI-Museum` - `Studied in Wave 407 as a local AI museum guide with gaze/room tracking, Ollama/RAG integration, Whisper/TTS adapters, chat logging, survey/export files, and privacy-first framing`
- `doktorfrag/museum-experience-vr` - `Studied in Wave 407 as a museum experience prototype with catalog entries, picture/statue scripts, location detection, UI catalog management, and VRTK caveats`
- `christian-acuna/react-vr-museum` - `Studied in Wave 407 as a React/Web museum shell with art-object, collection, session, user-collection, search, token, and profile/client architecture`
- `VIRTUE-DBIS/vre-mixnhack19` - `Studied in Wave 407 as a data-driven WebVR exhibition reference with database/server/Cineast media-query configuration and manifest follow-up`

## 379. Spatial UI widgets layouts and input-neutral panels

Primary docs:

- `../landscape/vr-projects-wave-408-spatial-ui-widgets-layouts-and-input-neutral-panels.md`
- `../landscape/project-families.md`

- `artflow-vr/vr-ui` - `Studied in Wave 408 as Three.js spatial UI layout/widget framework with Object3D input registration, grid/linear layouts, view primitives, and discontinued-project caveats`
- `csiro-scientific-computing/vr-ui` - `Studied in Wave 408 as Unity VR UI toolkit with interaction surfaces, interaction volumes, collider/rigidbody affordances, haptics, sliders, radial dials, and SteamVR-era caveats`
- `MT-ZD/Godot-3D-VR-UI` - `Studied in Wave 408 as Godot SubViewport-to-3D-panel bridge with Area3D/RayCast3D hit conversion and synthetic mouse events`
- `Squareys/magnum-vr-ui` - `Studied in Wave 408 as native C++ Magnum UI/Oculus/Leap reference for widget planes and hand/pointer adaptation`

## 380. WebView browser panel bridges and texture-backed web surfaces

Primary docs:

- `../landscape/vr-projects-wave-409-webview-browser-panel-bridges-and-texture-backed-web-surfaces.md`
- `../landscape/project-families.md`

- `gree/unity-webview` - `Studied in Wave 409 as cross-platform Unity WebView wrapper with callbacks, native overlay lifecycle, WebView2 texture notes, and 3D-surface caveats`
- `umetaman/UnityWebView2` - `Studied in Wave 409 as minimal Unity/Windows WebView2 bridge with RectTransform-to-native-bound synchronization`
- `olegmrzv/UnityWebViewInEditor` - `Studied in Wave 409 as Unity Editor WebView/JavaScript bridge using hidden editor APIs and script-object callbacks`
- `t-34400/UnityWebViewLib` - `Studied in Wave 409 as Android texture-backed WebView bridge for Unity with frame bytes, synthetic touch input, JavaScript bridge, and lifecycle manager`

## 381. CloudXR immersive streaming runtime and client adapters

Primary docs:

- `../landscape/vr-projects-wave-410-cloudxr-immersive-streaming-runtime-and-client-adapters.md`
- `../landscape/project-families.md`

- `NVIDIA/cloudxr-lovr-sample` - `Studied in Wave 410 as LÖVR CloudXR runtime plugin with pre-OpenXR service startup, opaque data channels, audio streaming, device profiles, and runtime adapter caveats`
- `NVIDIA/cloudxr-js-samples` - `Studied in Wave 410 as WebXR/WebRTC CloudXR browser client with device profiles, tracking uplink, streamed video rendering, and connection-state UI`
- `picoxr/OpenXR_CloudXR_Client_Demo` - `Studied in Wave 410 as PICO OpenXR CloudXR client with tracking-state assembly, framebuffer latch/blit/release, pause/resume, and stream metrics`
- `apple/StreamingSession` - `Studied in Wave 410 as Apple visionOS/iOS remote streaming session reference with pairing, mDNS/TCP/QR identity, CloudXR launch, and framework boundary caveats`

## 382. VR capture remote mocap and live production helpers

Primary docs:

- `../landscape/vr-projects-wave-411-vr-capture-remote-mocap-and-live-production-helpers.md`
- `../landscape/project-families.md`

- `GregMadison/quest-capture-remote` - `Studied in Wave 411 as Android/Compose Quest capture companion using wireless ADB, capture presets, internal recorder service commands, capture listing, and MP4 pull flow`
- `LIV/BoneworksLIV` - `Studied in Wave 411 as MelonLoader LIV mixed-reality capture integration with spectator camera prefab, layer masks, player visibility, audio capture, and game-specific mod caveats`
- `pnmocap/Neuron_Mocap_Live_Unity` - `Studied in Wave 411 as Axis Studio/Perception Neuron Unity live-link bridge with TCP/UDP sessions, actor/tracker model, skeleton branching, and Animator/Transform/Rigidbody targets`
- `Rokoko/rokoko-studio-live-unity` - `Studied in Wave 411 as Rokoko Studio Unity live plugin with UDP JSON v3 frames, actors, props, face blendshapes, prefab pooling, and Command API controls`

## 383. Lightweight OpenXR render framework adapters

Primary docs:

- `../landscape/vr-projects-wave-412-lightweight-openxr-render-framework-adapters.md`
- `../landscape/project-families.md`

- `FireFlyForLife/rlOpenXR` - `Deepened in Wave 412 from not-studied-deeply status as Raylib-facing OpenXR binding with rlgl backend, head/hand pose state, examples, and Windows/WIP caveats`
- `caszuu/rlxr` - `Studied in Wave 412 as single-header Raylib OpenXR module with session/render/action/binding APIs, swapchain lifecycle, platform graphics bindings, and haptics`
- `branchpanic/raylib-openvr` - `Studied in Wave 412 as OpenVR/Raylib prototype with HMD/controller tracking, stereo rendering, examples, and fork/submodule caveats`
- `geefr/vsgvr` - `Studied in Wave 412 as VulkanSceneGraph OpenXR integration with rendering/input/controller tracking, extension handling, coordinate-space notes, and desktop mirror`

## 384. Runtime retrofit SLAM and OpenXR engine substrates

Primary docs:

- `../landscape/vr-projects-wave-413-runtime-retrofit-slam-and-openxr-engine-substrates.md`
- `../landscape/project-families.md`

- `mcxr-org/MCXR` - `Studied in Wave 413 as archived Minecraft OpenXR/Fabric mod with core/play split, non-VR/server boundary, LWJGL OpenXR structs, and game-retrofit caveats`
- `alexstrei/Custom-VR` - `Studied in Wave 413 as DIY 3D-printable VR headset project with BOM, assembly docs, Monado driver fork, Basalt dependency, and hardware caveats`
- `CIFASIS/basalt-xr` - `Studied in Wave 413 as Basalt-for-Monado tracking backend with dataset replay, calibration/config paths, debug GUI flags, and Monado library discovery`
- `Adrian-Hirt/XRe` - `Studied in Wave 413 as WIP OpenXR/Vulkan engine substrate with app/render split, resources, scene components, grab/teleport/highlight, and hand tracking`

## 385. Gaussian splat and spatial asset viewer pipelines

Primary docs:

- `../landscape/vr-projects-wave-414-gaussian-splat-and-spatial-asset-viewer-pipelines.md`
- `../landscape/project-families.md`

- `warpgatelabs/RSR` - `Studied in Wave 414 as D3D12/OpenXR Gaussian splat viewer with PLY/SOG, runtime VR toggle, folder navigation, DLSS option, and VR grip transform controls`
- `hyperlogic/splatapult` - `Studied in Wave 414 as C++/OpenGL/OpenXR Gaussian splat viewer with cameras.json, vr.json alignment persistence, SfM point-cloud toggle, camera frustums, and Quest caveats`
- `jacobvanbeets/splat-vr-viewer` - `Studied in Wave 414 as LichtFeld Studio plugin exporting PLY to localhost PlayCanvas WebXR viewer with panel state, HTTP server lifecycle, config, and cleanup`
- `eleanor-studio/photon.editor` - `Studied in Wave 414 as browser editor playground with reactive UI-to-engine binding, GLB/GLTF loader, camera/environment controls, and Three.js/WebXR preview value`

## 386. XR utility automation authoring and scripting surfaces

Primary docs:

- `../landscape/vr-projects-wave-415-xr-utility-automation-authoring-and-scripting-surfaces.md`
- `../landscape/project-families.md`

- `RangerMauve/dat-xr-scene-ide` - `Studied in Wave 415 as WebXR/A-Frame in-headset terminal editor with DOM scene commands, curved terminal surface, write/mkdir/eval commands, and safety caveats`
- `Eidenz/NemuriXR` - `Studied in Wave 415 as Linux/Monado sleep utility with desktop app, OpenXR overlay, shared config, Unix-socket IPC, VRChat/OSC automation, brightness/audio/fan phases, and privacy caveats`
- `Phantomxm2021/ARMOD-Framework` - `Studied in Wave 415 as broad AR/XR capability-wrapper SDK with visual configuration, session management, platform mutation, light estimation, docs/tutorials, and quota/support caveats`
- `drypy/openxr.py` - `Studied in Wave 415 as Python ctypes OpenXR binding with package/tests/examples value for scripting diagnostics and runtime probes`

## 387. XR testbeds conformance runners and reproducible packaging

Primary docs:

- `../landscape/vr-projects-wave-416-xr-testbeds-conformance-runners-and-reproducible-packaging.md`
- `../landscape/project-families.md`

- `ILLIXR/ILLIXR` - `Studied in Wave 416 as modular XR research testbed with plugin profiles, switchboard dataflow, Monado/headless/native/offload modes, hand/lighthouse/timewarp/OpenWarp/ZED components, and subsystem docs`
- `nix-community/nixpkgs-xr` - `Studied in Wave 416 as reproducible XR package overlay with source pins, NixOS module wiring, package overrides, Monado/WiVRn/WayVR/OpenComposite/xrizer grouping, and update metadata`
- `KhronosGroup/OpenXR-CTS` - `Deepened in Wave 416 as official conformance harness model with generated dispatch, manifests, test runtimes, conformance layer generation, CLI runner, and platform artifacts`
- `rpavlik/openxr-cts-runner` - `Studied in Wave 416 as experimental GUI wrapper for CTS execution with config, process management, state model, and runner UI separation`

## 388. WebXR capture avatar and micro editor surfaces

Primary docs:

- `../landscape/vr-projects-wave-417-webxr-capture-avatar-and-micro-editor-surfaces.md`
- `../landscape/project-families.md`

- `k1pp0/model-viewer-webxr-capture` - `Studied in Wave 417 as model-viewer companion custom element adding WebXR AR screenshot capture via host bridge, camera-access injection, frame hooks, capture provider, preview UI, and Chrome workaround gates`
- `voyagerD/webxr-avatar` - `Studied in Wave 417 as thin WebXR avatar preview with GLB animation assets and static browser deployment`
- `Damfino1970/quest2-webxr-editor` - `Studied in Wave 417 as small Quest/WebXR editor page with one-file browser deployment and limited source depth`

## 389. VRChat OSC micro apps and distribution sidecars

Primary docs:

- `../landscape/vr-projects-wave-418-vrchat-osc-micro-apps-and-distribution-sidecars.md`
- `../landscape/project-families.md`

- `99oblivius/Livi-s-VRChatOSC-Tools` - `Studied in Wave 418 as small Rust VRChat OSC tool with explicit osc_inputs module and compiled micro-sidecar shape`
- `theepicsnail/vrchat_osc_app` - `Studied in Wave 418 as minimal Python VRChat OSC app package with setup entry point and app module`
- `niwaniwa/VRChat-OSC-app` - `Studied in Wave 418 as WPF/WPF UI/R3 OSC desktop shell with dashboard/chat/data/settings pages, config model, services, MVVM structure, and Rug.Osc dependency`
- `noideaman/ArchOSCApps` - `Studied in Wave 418 as Arch Linux package collection for VRChat OSC apps with PKGBUILDs, desktop entries, wrapper scripts, config files, and upstream references`

## 390. VR retrofit launcher and hand layer edge cases

Primary docs:

- `../landscape/vr-projects-wave-419-vr-retrofit-launcher-and-hand-layer-edge-cases.md`
- `../landscape/project-families.md`

- `TheNewJavaman/unreal-vr` - `Studied in Wave 419 as flatscreen Unreal-to-VR retrofit with launcher/profile UI, injected loader, D3D11/OpenXR/UE4 services, hooks, shaders, pipes, and reverse-engineering notes`
- `gamenew09/RobloxVRLauncher` - `Reviewed in Wave 419 as empty OpenVR dashboard launcher placeholder with product-reference value only and no code donor value`
- `ultraleap/OpenXRHandTracking` - `Deepened in Wave 419 as archived implicit hand-tracking API layer with extension gating, service timeout, active-state caveats, conformance fixes, layer-init issues, UWP/WebXR notes, and installer/logging caveats`

## 391. VR media cockpit library and social audio panels

Primary docs:

- `../landscape/vr-projects-wave-420-vr-media-cockpit-library-and-social-audio-panels.md`
- `../landscape/project-families.md`

- `VersaYT/JellyVR` - `Studied in Wave 420 as Godot/OpenXR Jellyfin VR theater with controller menu toggles, floating MPV playback controls, server/login/content state machine, keyboard panel, and provider caveats`
- `fpw/avitab` - `Studied in Wave 420 as X-Plane VR cockpit tablet with chart/map/manual/notes app launcher, simulator command bindings, native window/VR panel lifecycle, placement persistence, and provider routing`
- `Soapwood/VXMusic` - `Studied in Wave 420 as social-VR music recognition companion with Shazam recognition, SteamVR/XSOverlay/OVR Toolkit notifications, VRChat ChatBox output, Spotify/Last.fm links, logs, and SteamVR plugin install`

## 392. Lighthouse base station and home automation bridges

Primary docs:

- `../landscape/vr-projects-wave-421-lighthouse-base-station-and-home-automation-bridges.md`
- `../landscape/project-families.md`

- `jariz/homeassistant-basestation` - `Studied with archive caveat in Wave 421 as Home Assistant BLE switch entity for Valve Index Base Stations with MAC config, availability polling, power writes, grouping, and automation ideas`
- `ShayBox/Lighthouse` - `Studied in Wave 421 as Rust Lighthouse power-management CLI/library with V1/V2 UUID handling, scan timeouts, target matching, write retries, logging, and small release-binary profile`

## 393. Unity OpenVR tracker and input utility facades

Primary docs:

- `../landscape/vr-projects-wave-422-unity-openvr-tracker-and-input-utility-facades.md`
- `../landscape/project-families.md`

- `gpsnmeajp/EasyOpenVRUtil` - `Studied in Wave 422 as Unity direct-OpenVR utility facade for tracker/controller poses, serial lookup, battery, screenshots, device inventory, and non-VR pose access`
- `ebadier/ViveTrackers` - `Deepened in Wave 422 as compact Unity Vive Tracker library with manager/list model, fake manager, calibration save/load, CSV serial stability, pogo-pin events, test scene, and no-HMD setup docs`
- `VRMADA/ultimatexr-unity` - `Studied in Wave 422 as broad Unity VR framework reference with modular UI pointers, keyboard prefabs, interaction, locomotion, haptics, avatars, platform guides, and framework-scope caveats`

## 394. VR comfort text entry and compositor microtools

Primary docs:

- `../landscape/vr-projects-wave-423-vr-comfort-text-entry-and-compositor-microtools.md`
- `../landscape/project-families.md`

- `MoonMotionProject/MoonMotion` - `Studied in Wave 423 as SteamVR-era Unity locomotion toolkit with ready VR player, locomotion modules, object interactivity, camera smoothing, dynamic colliders, project template, and version caveats`
- `rjth/Punchkeyboard` - `Studied in Wave 423 as Unity VR keyboard with autocomplete, next-word prediction, corpora/dictionary generation, Levenshtein matching, keyboard mesh, key feedback, and personalization caveats`
- `elvissteinjr/SteamVR-ForceCompositorScale` - `Studied in Wave 423 as tiny OpenVR/SteamVR compositor-scale patcher with overlay-app registration, supersample setting mutation, restart caveat, JSON backup warning, and rollback needs`

## 395. OpenVR chaperone debug boundary safety and geometry IO microtools

Primary docs:

- `../landscape/vr-projects-wave-424-openvr-chaperone-debug-boundary-safety-and-geometry-io-microtools.md`
- `../landscape/project-families.md`

- `zodsoft/openvr_chaperone_io` - `Studied in Wave 424 as compact chaperone universe parser/writer surface for boundary backup, preview, migration, and rollback-oriented tools`
- `Dawars/processing_openvr_debug` - `Studied in Wave 424 as Processing/OpenVR play-area and tracked-device debug visualizer with chaperone event refresh and top-down device map value`
- `systemofapwne/VRGuard` - `Studied in Wave 424 as Python/pyopenvr chaperone proximity monitor with controller pose polling, height filtering, distance thresholds, and audio warning routing`

## 396. Magic Leap OpenXR sensing gaze plane and setup samples

Primary docs:

- `../landscape/vr-projects-wave-425-magic-leap-openxr-sensing-gaze-plane-and-setup-samples.md`
- `../landscape/project-families.md`

- `dilmerv/MagicLeapPlaneDetection` - `Studied in Wave 425 as Unity/Magic Leap OpenXR plane-detection sample with scoped registry setup, spatial mapping permission, subsystem query flags, and semantic/min-area filters`
- `dilmerv/MagicLeapEyeTracking` - `Studied in Wave 425 as Unity/Magic Leap eye-tracking sample with permission gate, gaze pose adapter, dwell passcode interaction, progress material, and callback flow`
- `magicleap/MixedRealityToolkit-Unity-PreGA` - `Studied in Wave 425 as Magic Leap-oriented MRTK fork/reference with cross-platform interaction primitives, OpenXR support context, and pre-GA support-boundary caveats`

## 397. Mocap pose-solving avatar tracking and research recording donors

Primary docs:

- `../landscape/vr-projects-wave-426-mocap-pose-solving-avatar-tracking-and-research-recording-donors.md`
- `../landscape/project-families.md`

- `xianfei/SysMocap` - `Studied in Wave 426 as Electron/Vue/MediaPipe/Kalidokit/three-vrm avatar mocap app with VRM/FBX binding, OBS/WebXR forwarding, Socket.IO transport, and recording caveats`
- `yeemachine/kalidokit` - `Studied in Wave 426 as solver library turning face/pose/hand landmarks into VRM/Live2D-friendly rotations, blendshapes, and stabilization outputs`
- `emilianavt/OpenSeeFace` - `Studied in Wave 426 as CPU face/facial landmark tracker sidecar with UDP transport, Unity receiver, calibration/expression flow, and launcher/process-supervision value`
- `freemocap/freemocap` - `Studied in Wave 426 as open-source research-grade motion capture platform reference for recording/session pipeline, hardware-agnostic capture, and export/provenance follow-up`

## 398. WebXR toolkit retrofit bridges for MRTK and HPTK

Primary docs:

- `../landscape/vr-projects-wave-427-webxr-toolkit-retrofit-bridges-for-mrtk-and-hptk.md`
- `../landscape/project-families.md`

- `Rufus31415/MixedRealityToolkit-Unity-WebXR` - `Studied with deprecation caveat in Wave 427 as MRTK WebXR/WebGL POC with transparent Unity canvas, Three.js/WebXR camera bridge, SendMessage transform JSON, and hard-coded calibration caveats`
- `Rufus31415/HPTK-Sample-WebXR` - `Studied in Wave 427 as HPTK/SimpleWebXR hand-joint adapter with session/availability confidence gates, WebXR-to-HPTK rotation conversion, bone mapping, and editor fixtures`

## 399. PCVR launch profile and Quest operator companion tools

Primary docs:

- `../landscape/vr-projects-wave-428-pcvr-launch-profile-and-quest-operator-companion-tools.md`
- `../landscape/project-families.md`

- `harryeffinpotter/VRL` - `Studied in Wave 428 as Windows PCVR launch-profile generator with Unity/Unreal target detection, Virtual Desktop/Link/Oculus launch templates, AppData settings, and generated shortcut/wrapper caveats`
- `MesmerPrism/Rusty-XR-Companion-Apps` - `Studied in Wave 428 as Quest operator companion with shared WPF/CLI/MCP operation catalog, safety-gated command planning, managed tooling, app/runtime profiles, diagnostics bundles, and profile caveats`

## 400. Quest hand pose streaming and ADB telemetry companions

Primary docs:

- `../landscape/vr-projects-wave-429-quest-hand-pose-streaming-and-adb-telemetry-companions.md`
- `../landscape/project-families.md`

- `MOVIN3D/MOVIN-MetaQuest-APK` - `Studied in Wave 429 as APK-only Quest hand-streaming companion reference with ADB install, developer-mode setup, controller-only UI, Wi-Fi host discovery, manual IP fallback, reconnect state, and product/setup caveat`
- `rail-berkeley/oculus_reader` - `Studied in Wave 429 as Quest pose/button telemetry bridge with APK bootstrap, ADB USB/TCP transport, tagged logcat parser, transform/button cache, ROS option, and active-fork caveat`

## 401. WebXR hand gesture avatar and browser interaction microtools

Primary docs:

- `../landscape/vr-projects-wave-430-webxr-hand-gesture-avatar-and-browser-interaction-microtools.md`
- `../landscape/project-families.md`

- `AlbertoElias/webxr-hand-tracking` - `Studied in Wave 430 as WebXR hand/avatar model adapter harness with three.js hand/controller setup, pinch-to-cycle model switching, and controller fallback rays`
- `kimbanica/aframe-libras` - `Studied in Wave 430 as A-Frame/WebXR gesture trainer with capability checks, joint markers, thumb-index distance threshold, dwell timer, target gesture, and calibration caveats`
- `Phocidae-dev/Kinetic-Swarm` - `Studied in Wave 430 as WebXR hand interaction microgame with gesture hints, input-source processing, orb state machine, lift/freeze/push/draw interactions, and single-file prototype caveats`

## 402. Domain-specific VR game timer overlays and helper microtools

Primary docs:

- `../landscape/vr-projects-wave-431-domain-specific-vr-game-timer-overlays-and-helper-microtools.md`
- `../landscape/project-families.md`

- `84z0r/PhasmoTimer` - `Studied in Wave 431 as external no-memory-reading Phasmophobia timer overlay with foreground gating, global hotkeys, JSON config, feature toggles, UI styling, and domain-data freshness caveats`
- `SteveMarkhamGIT/PhasmoTimer` - `Studied in Wave 431 as bitmap-rendered timer surface with resource layers, digit glyph loader, hover/touch masks, output image buffer, and OpenVR texture-surface follow-up`
- `DrBrad/phastimer` - `Studied in Wave 431 as browser/OBS-friendly Phasmophobia timer helper with DOM controls, 16 ms update loop, smudge/Obambo/ghost-speed state, and no native VR integration caveat`

## 403. Unity XRI controller event emitter microtool

Primary docs:

- `../landscape/vr-projects-wave-432-unity-xri-controller-event-emitter-microtool.md`
- `../landscape/project-families.md`

- `Volorf/XR-Emitter` - `Studied in Wave 432 as Unity XR Interaction Toolkit controller event facade with per-hand feature polling, static typed events for trigger/grip/buttons/2D axis, demo subscribers, and static-lifecycle caveats`

## 404. VR scientific annotation point-cloud and slice-stack tools

Primary docs:

- `../landscape/vr-projects-wave-433-vr-scientific-annotation-point-cloud-and-slice-stack-tools.md`
- `../landscape/project-families.md`

- `RMonica/vr_hand_gaze_annotation` - `Studied in Wave 433 as Quest Pro point-cloud annotation tool with eye/controller/box modes, PCL native plugin bridge, label palette, cone/radius selection, bounding-box search, and export caveats`
- `newgen211/Vr-axion` - `Studied in Wave 433 as Unity neuron image-stack annotation tool with z-spaced textured quads, raycast point placement, line connections, move/annotate/connect modes, JSON export, and cache/provenance caveats`

## 405. XR educational model annotation and passthrough retrofit samples

Primary docs:

- `../landscape/vr-projects-wave-434-xr-educational-model-annotation-and-passthrough-retrofit-samples.md`
- `../landscape/project-families.md`

- `Chinmay-HS/AeroVerse-XR-Headsets` - `Studied in Wave 434 as OpenXR/XRI educational model inspection app with part-name callouts, dynamic label scaling/avoidance, model selection, external asset hydration, and AI/product-claim caveats`
- `MixedRealityDevelopment-CalebCram/Neuroanatomy_Passthrough_Quest2` - `Studied in Wave 434 as legacy neuroanatomy VR-to-Quest-passthrough retrofit with OVRInput brain-part interactions, laser SendMessage routing, scene/background retrofit notes, and legacy-code caveats`

## 406. HoloLens OpenXR repro and MRTK gameplay micro-samples

Primary docs:

- `../landscape/vr-projects-wave-435-hololens-openxr-repro-and-mrtk-gameplay-micro-samples.md`
- `../landscape/project-families.md`

- `camnewnham/Unity-Repro-OpenXR-TrackingLoss` - `Studied in Wave 435 as HoloLens OpenXR/ARFoundation tracking-loss repro with exact package versions, sensor-cover movement steps, ARSession/head/center-eye state text, and repro-scope caveats`
- `Purecon/Hololens-SphereDefender-` - `Studied in Wave 435 as MRTK/OpenXR sphere-defense microgame with ScriptableObject enemy waves, sphere-surface spawning, central objective, hand-touch hook, and incomplete tutorial-code caveats`
- `nikolajIvanov/MRTK-Tutorial` - `Studied in Wave 435 as thin HoloLens MRTK/OpenXR setup reference with scene-only project, local MRTK package archives, manifest snapshot, and low code-donor value`

## 407. Unity coordinate calibration and Cardboard profile micro-libraries

Primary docs:

- `../landscape/vr-projects-wave-436-unity-coordinate-calibration-and-cardboard-profile-micro-libraries.md`
- `../landscape/project-families.md`

- `MaxHeimbrock/KabschCalibrationUnity` - `Studied in Wave 436 as Unity coordinate-space calibration micro-library with source/target point capture, Kabsch solver, mean-distance error, tooltip calibration, editor point authoring, and JSON transform persistence`
- `epyyny/google_cardboard_calibration_unity_plugin` - `Studied in Wave 436 as modified Cardboard XR package with ruler/DPI calibration, safe-area/orientation recalculation, XRLoader screen-parameter handoff, Android/OpenGLES caveats, and upstream-fork provenance needs`

## 408. VR accessibility visibility and design playground samples

Primary docs:

- `../landscape/vr-projects-wave-437-vr-accessibility-visibility-and-design-playground-samples.md`
- `../landscape/project-families.md`

- `hai-vr/let-me-see` - `Studied in Wave 437 as Unity editor-driven VR visibility harness with XR lifecycle control, SceneView/local camera modes, user height/rescale settings, OpenXR force mode, repaint/restore hooks, and editor-hack caveats`
- `GuillemD/VRDesignPlayground` - `Studied in Wave 437 as Unity accessibility design playground with height manager, locomotion activation threshold, hand presence, offset grabs, custom throw, physics buttons, and sample-scale caveats`

## 409. Inclusive VR wheelchair and impairment simulation tools

Primary docs:

- `../landscape/vr-projects-wave-438-inclusive-vr-wheelchair-and-impairment-simulation-tools.md`
- `../landscape/project-families.md`

- `rehabnj/vr-wheelchair-simulator` - `Studied in Wave 438 as wheelchair accessibility awareness simulation with captions, brightness overlay, audio preference persistence, imported XRI/URP sample caveats, and scenario-framing value`
- `VlasiosKasapakis/VR4ALL` - `Studied in Wave 438 as impairment-simulation product/reference node with visual/motor condition profile switching, Unity/XR Toolkit asset framing, external asset caveats, and no public source donor value in the inspected tree`

## 410. Modern XRI template and OpenXR multiplayer setup samples

Primary docs:

- `../landscape/vr-projects-wave-439-modern-xri-template-and-openxr-multiplayer-setup-samples.md`
- `../landscape/project-families.md`

- `Fist-Full-of-Shrimp/Shrimp-XRI-Template` - `Studied in Wave 439 as Unity 6/XRI 3.x template baseline with OpenXR/XR Hands/accessibility package manifest, template scripts, teleport/callout/knob/video controls, validation rules, and Unity-sample provenance caveats`
- `BanQingTian/MultiPlayer_Unity_OpenXR` - `Reviewed in Wave 439 as README-only OpenXR multiplayer setup placeholder with no Assets/Packages/scripts in the inspected public tree and no code donor value`

## Registry maintenance rule

Any future repository added to `VR-apps-lab` should update:

1. this file;
2. `../landscape/project-families.md` if the overlap model changes;
3. `../landscape/not-yet-studied-deeply.md` if a follow-up pass is needed.
