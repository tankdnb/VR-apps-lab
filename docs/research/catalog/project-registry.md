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
- `iigomaru/MPVR` - `Partially studied`
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
- `I5UCC/ParameterSaveStates` - `Not studied deeply`
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
- `MasonSakai/VR-AI-Full-Body-Tracking` - `Not studied deeply`

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
- `nakama-lab/VR_Teleop_Interface` - `Not studied deeply`
- `h2r/GHOST` - `Not studied deeply`

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
- `Yukiiro-Nite/notebook-vr-overlay` - `Partially studied`

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
- `Daniel-Webster/WT-OpenVR-Overlay` - `Partially studied`
- `kurohuku7/zenn-overlay-tutorial` - `Already studied as tutorial-grade OpenVR overlay lifecycle reference`

## 41. Desktop-adjacent companion overlays, phone bridges, and media or text control surfaces

Primary docs:

- `../landscape/vr-projects-wave-62-desktop-adjacent-companion-overlays-phone-bridges-and-media-or-text-control-surfaces.md`
- `../landscape/project-families.md`

- `happysmash27/OVR_SLDO` - `Already studied`
- `Desuuuu/OVRPhoneBridge` - `Already studied`
- `adks3489/ViveOverlayPaster` - `Already studied`
- `Wulkop/VolumeVR` - `Partially studied`

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

- `kscalelabs/kbot_vr_teleop` - `Partially studied`
- `dwaitbhatt/xarm_vr_teleop` - `Already studied`
- `NVlabs/collab-sim` - `Partially studied`
- `wengmister/franka-vr-teleop` - `Partially studied`
- `nakama-lab/VR_Teleop_Interface` - `Partially studied; deepened from earlier not-yet marker`
- `open-thought/cambot` - `Partially studied`
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

- `jakedowns/xreal-webxr` - `Partially studied`
- `alexwilson1/nreal_linux_test` - `Partially studied as Linux/X11 POC`
- `Mailbot/Nreal_Air_Desktop_tool` - `Partially studied as product reference only`
- `edwatt/real_utilities` - `Partially studied`
- `DannyDesert/XReal-Ultrawide` - `Already studied`

## 93. MediaPipe camera tracking bridges for SlimeVR, VRChat, VRM, and virtual controllers

Primary docs:

- `../landscape/vr-projects-wave-122-mediapipe-camera-tracking-bridges-for-slimevr-vrchat-vrm-and-virtual-controllers.md`
- `../landscape/project-families.md`

- `TkskKurumi/SlimeVR-Tracker-Mediapipe` - `Already studied`
- `hotaru86/MediapipeFaceTracking_VRC` - `Partially studied`
- `how-people-lived/mediapipe-vrm-tracking` - `Partially studied`
- `Metastazius/VRBodyTrack` - `Partially studied`
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

## Registry maintenance rule

Any future repository added to `VR-apps-lab` should update:

1. this file;
2. `../landscape/project-families.md` if the overlap model changes;
3. `../landscape/not-yet-studied-deeply.md` if a follow-up pass is needed.
