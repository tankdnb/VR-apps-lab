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
- `Nexz/turncountervr` - `Not studied deeply`
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
- `MeroFune/GOpy` - `Not studied deeply`

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
- `Denwa/vive-wireless-info-overlay` - `Not studied deeply`
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
- `tobexeon/PSVR2EyeTrackingCalibration` - `Not studied deeply`

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
- `OpenDisplayXR/OpenDisplayXR-VDD` - `Not studied deeply`
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
- `Marlamin/VROverlayTest` - `Not studied deeply`
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
- `Sharrnah/whispering` - `Partially studied`
- `Larsundso/SteamVR-Discord-Overlay` - `Already studied`
- `Artemol/DiscOverlay` - `Already studied`
- `imagitama/steamvr-overlay-vrbuddy` - `Already studied`
- `beareogaming/BD-XSOverlay-notify` - `Not studied deeply`

## 23. Alternative OpenXR runtimes, special-display paths, and platform experiments

Primary docs:

- `../landscape/vr-projects-wave-33-alternative-openxr-runtimes-and-special-display-paths.md`
- `../landscape/project-families.md`

- `DisplayXR/displayxr-runtime` - `Already studied`
- `JoeyAnthony/XRGameBridge` - `Already studied`
- `warrenm/OpenXRKit` - `Already studied`
- `rinsuki/FruitXR` - `Already studied`
- `maximum-game-22/openxr-3d-display` - `Not studied deeply`
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
- `takana-v/quest_steamvr_fbt_tool` - `Not studied deeply`

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
- `kurohuku7/zenn-overlay-tutorial` - `Not studied deeply`

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
- `emymin/EmyOverlay` - `Not studied deeply`

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
- `VRLabs/Camera-System` - `Partially studied`
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
- `eisclimber/ExPresS-XR` - `Partially studied`
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

- `GodotVR/godot-xr-tools` - `Partially studied`
- `GodotVR/godot-xr-template` - `Already studied`
- `GodotVR/godot_openxr_for_godot_3.x` - `Partially studied`
- `GodotVR/godot_openxr_vendors` - `Partially studied`
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
- `icosa-foundation/open-brush` - `Partially studied as active Tilt Brush evolution with API/multiplayer donor value`
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

## Registry maintenance rule

Any future repository added to `VR-apps-lab` should update:

1. this file;
2. `../landscape/project-families.md` if the overlap model changes;
3. `../landscape/not-yet-studied-deeply.md` if a follow-up pass is needed.
