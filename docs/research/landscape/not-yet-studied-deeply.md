# Not Yet Studied Deeply

- Date: `2026-06-05`
- Goal: keep a prioritized list of repositories that either:
  - are not yet represented in `VR-apps-lab`;
  - are only lightly covered;
  - or belong to a high-value overlap family that deserves a deeper code-level
    pass.

## How to use this file

For each project, track four things:

- `interesting idea`
- `code donor value`
- `product reference value`
- `what to inspect next`

This keeps the backlog aligned with the existing wave documents and makes it
easier to decide whether the next pass should focus on architecture, UX, or
implementation details.

- Use this file as the active deep-study and follow-up queue.
- The status values shown here are copied from `../catalog/project-registry.md`
  for queue context only.
- For a shorter `what matters now` view, start with `../current-focus.md`.

## Priority batch A

These are the strongest next candidates after the latest runtime, bridge, and
overlay-host waves.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `krazysh01/VirtualDesktop-OpenVR-Trackers` | Partially studied | Product direction suggests body-state-to-tracker bridging, but the current public snapshot looks much thinner than expected | Medium | Medium | Re-check only if the public repo grows a real data-ingress surface or visible tracker-role mapping logic |
| `Sharrnah/whispering` | Already studied in Wave 164 | Broad local speech platform where VR is one consumer among OSC, websocket, TTS, and plugin outputs | High | High | No urgent follow-up; revisit only when building a caption pipeline matrix or extracting a small overlay/OSC transport slice |

## Priority batch B: comparison variants and forks

These are worth keeping visible, but they should usually be studied after the
main upstream or main family representative is understood.

| Project | Why it matters | What to inspect next |
|---|---|---|
| `surplex-io/OpenVR-Driver` | Variant of the John-Dean WebSocket tracker-driver line | Revisit only if the fork diverges materially beyond tracker-role mapping or becomes the better-maintained branch |
| `3NekoSystem/OpenVR-Tracker-Websocket-Driver` | Simpler JSON/WebSocket fork in the tracker-driver family | Revisit only if the lighter `8082` branch becomes the better-maintained ingress baseline |
| `v0xie/OpenVR-Tracker-Websocket-Driver` | Near-mirror of the John-Dean WebSocket line with extra web-service surfaces | Revisit only if its HTTP/HTTPS side channels become a clearly reused product pattern |
| `TrueOpenVR/SteamVR-TrueOpenVR` | Sample-derived bridge driver that still depends on an external TrueOpenVR data surface | Revisit only if the public bridge contract or DLL-side standard becomes easier to map in source form |

## Priority batch C: newly discovered GitHub wave candidates

These were discovered in the latest GitHub source pass and added to the
registry, but not yet studied deeply enough to promote beyond `Not studied
deeply`.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `Nexz/turncountervr` | Already studied in Wave 152 | Rotation/cable-awareness overlay variant | Low-Medium | Medium | No urgent follow-up; revisit only when extracting a generic pose-derived comfort micro-overlay |
| `Denwa/vive-wireless-info-overlay` | Source-light product reference after Wave 152 | Device-specific thermal micro-overlay with very focused user value | Low | Medium | Revisit only if fuller source appears; the product framing is clearer than the current donor surface |
| `mbucchia/_ARCHIVE_OverXR` | Fork / variant only | Archive shell pointing to a once-promising overlay compatibility idea | Low | Medium | Whether useful code exists in releases, tags, or external mirrors |

## Priority batch C2: Waves 116-119 follow-up candidates

These were clarified during the latest Godot, A-Frame/WebXR, Unreal, and VR
teleoperation source pass. They are already represented in the registry, but
they remain useful deeper-study candidates if one of these branches becomes an
active prototype or reuse-plan target.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `GodotVR/godot-xr-tools` | Already studied in Wave 167 | Scene-pack XR toolkit whose strongest value is reusable function nodes for interaction, hands, movement, and settings | High | High | No urgent follow-up; next useful work is a function-node matrix, not another repo-level reread |
| `GodotVR/godot_openxr_vendors` | Already studied in Wave 167 | Vendor OpenXR extension packaging where export plugins and capability gates may become a strong diagnostics pattern | High | High | No urgent follow-up; next useful work is a vendor feature/export matrix across runtime capabilities |
| `aframevr/aframe-inspector` | Already studied | Browser scene inspector that can become a reference for in-headset or in-browser debug/edit surfaces | High | High | Compare entity/component history, selection, export, and component-add flows against native overlay diagnostics |
| `networked-aframe/networked-aframe` | Partially studied | Schema-driven scene sync with pluggable WebRTC/WebSocket adapters | High | High | Compare adapter boundaries with OSC/WebSocket bridge families and decide what a generic browser utility sync layer should keep |
| `mordentral/VRExpansionPlugin` | Partially studied | Replicated Unreal grip/movement framework whose donor value sits in authority, smoothing, and grip event boundaries | High | High | Deepen only if Unreal networked interaction becomes active scope; isolate grip replication and movement actions first |
| `microsoft/MixedReality-UXTools-Unreal` | Partially studied as archived reference | Archived but rich MR UX primitive library with hand tracker, near/far input, menus, touchables, and simulation | High | High | Use as comparison material for a cross-engine near/far UI primitive matrix |
| `NVlabs/collab-sim` | Partially studied | Isaac Sim/OpenXR robot teleop with MPC, reset callbacks, logging, and replay | High | High | Deepen data logger, replay, and controller callback design if simulation telemetry becomes active |
| `kscalelabs/kbot_vr_teleop` | Partially studied | WebXR headset frontend plus Python IK and UDP relay architecture | High | High | Compare browser tracking transport, joystick commands, IK sidecar, and Rerun visualizer against `cambot` |
| `open-thought/cambot` | Partially studied | Polished WebXR telepresence surface with WebSocket/WebRTC transport, HUD, watchdog, safety bounds, and head-pose IK | High | High | Extract a generic operator HUD/safety/transport blueprint if VR control surfaces become a reuse-plan branch |

## Priority batch C3: Waves 120-123 follow-up candidates

These were clarified during the latest streaming-sidecar, XR-glasses,
MediaPipe bridge, and mixed-reality capture source pass. Some are useful
follow-up nodes, while others are intentionally marked thin or source-limited.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `alvr-org/alvr-visionos` | Partially studied | Platform-specific streaming client shell with entry UI, immersive renderer choices, decoder/tracking boundaries, and event watchdogs | High | High | Compare with Android/Quest ALVR client boundaries if standalone headset client UX becomes active |
| `alvr-org/Monado-ALVR` | Partially studied as runtime-fork reference | Runtime bridge/fork whose strongest current value is remote-driver, manifest, IPC, tracing, and metrics documentation | Medium | Medium-High | Revisit only if a future runtime-fork wave needs exact ALVR integration diffs against upstream Monado |
| `jakedowns/xreal-webxr` | Partially studied | Browser WebHID workbench for XREAL/Nreal protocol probing, packet logging, IMU polling, and firmware command scaffolding | High | High | Deepen only inside a dedicated XR-glasses protocol/diagnostics pass |
| `alexwilson1/nreal_linux_test` | Partially studied as Linux/X11 POC | Screen-capture and gaze-calibrated viewport slicing before a full compositor exists | Medium | Medium | Compare against `XReal-Ultrawide`, `breezy-desktop`, and `Simula` if head-tracked desktop helpers become a prototype target |
| `Mailbot/Nreal_Air_Desktop_tool` | Partially studied as product reference only | Thin Nreal Air desktop-control framing with little donor source in the current pass | Low | Medium | Revisit only if source depth appears or releases expose implementation details |
| `edwatt/real_utilities` | Partially studied | Native protocol utility around Nreal Air command/report handling | Medium | Medium | Read protocol files more deeply only if an XREAL protocol matrix is started |
| `hotaru86/MediapipeFaceTracking_VRC` | Partially studied | Webcam face landmarker to VRChat-facing expression bridge | Medium-High | High | Compare expression mapping with VRCFaceTracking modules and `VRCFT-ALVR` |
| `how-people-lived/mediapipe-vrm-tracking` | Partially studied | Browser-only MediaPipe/VRM face, hand, and arm tracking with ARKit-compatible blendshape framing | Medium | Medium-High | Modularize lessons only if browser avatar diagnostics become active |
| `Metastazius/VRBodyTrack` | Partially studied | Python MediaPipe world-landmark process feeding Unity avatar IK through a named pipe | Medium | Medium | Compare against cleaner Unity/OSC body-tracking bridges; avoid copying checked-in Unity cache/build artifacts |
| `fabio914/RealityMixerVisionPro` | Partially studied | Vision Pro/iPhone MRC stack with image tracking, camera pose payloads, renderer, encoder, and server boundaries | High | High | Deepen protocol and iPhone companion side if capture/compositing becomes a prototype branch |
| `zengmmm00/MixedRealityCapture` | Not studied deeply; source not released yet | Quest 3 MRC phone/computer workflow signal without toolkit source yet | Low | Medium | Revisit after the planned toolkit source appears |
| `LIV/CalibrationForQuest` | Rejected; empty repository in current clone | Historical LIV Quest calibration marker, but no current source to study | Low | Low | Do not promote unless source appears in tags/releases or another maintained mirror |

## Priority batch C31: Waves 152-155 follow-up candidates

These were clarified during the latest telemetry, overlay-bridge,
display-surface, and hand-control source pass. Most are already represented in
the registry; they remain here only where a future condition or comparison pass
could make another inspection useful.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `OrangeJuicy69/VRC-NexusChat` | Source-light product reference | VRChat OSC companion framing for chatbox/HUD/time and planned media/status helpers | Low | Medium | Revisit only if public source appears or licensing changes |
| `r57zone/VR-Display` | Source-light historical concept reference | DIY HDMI/MIPI display and USB gyro headset-display concept | Low | Medium | Revisit only for DIY display BOM or hardware bring-up comparisons |
| `tejasXR/Virtual-Desktop-VR` | Source-light historical Unity/SteamVR POC | Old virtual-desktop-in-VR project with little visible current donor surface | Low | Low-Medium | Revisit only for historical Unity/SteamVR desktop-in-VR examples |
| `InfernoDigital/RoboHands-UnityXR` | Source-light product reference | Unity XR hand-pose package framing and gesture inventory | Low | Medium | Revisit only if package source becomes public or local source is available |
| `maximum-game-22/openxr-3d-display` | Fork / variant only | DisplayXR spatial-display runtime variant | Low | Medium | Compare only if it diverges materially from `dfattal/openxr-3d-display` |

## Priority batch D: Wave 9 follow-up candidates

These were discovered during the Wave 9 source pass, added to the registry, and
kept for the next deeper inspection round.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `I5UCC/ParameterSaveStates` | Not studied deeply | VRChat or control-surface state management that may complement remote-control overlays | Medium | Medium | State model, persistence approach, OSC or app-integration flow, overlap with `SteaMeeter` |
| `MeroFune/GOpy` | Already studied in Wave 153 | OSC gesture-parameter to HMD-relative overlay icon bridge | Medium | Medium | No urgent follow-up; compare only inside an OSC-to-overlay bridge matrix |

## Priority batch E: Wave 11 follow-up candidates

These were surfaced or only partially exhausted during the Wave 11 source pass.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `OpenDisplayXR/OpenDisplayXR-VDD` | Inaccessible during latest remote check | Simulated OpenVR/OpenXR virtual hardware driver path | Low | Medium | Keep as signal-only until normal GitHub remote operations expose source/docs again |

## Priority batch F: Wave 13 follow-up candidates

These were surfaced or only partially exhausted during the Wave 13 source pass.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `MasonSakai/VR-AI-Full-Body-Tracking` | Not studied deeply | Camera FBT path that still carries InputEmulator-era assumptions while aiming at a cleaner driver rewrite | Medium | Medium | Whether the rewrite lands, how much of the current repo is reusable, and how it compares with `Mediapipe-VR-Fullbody-Tracking` |

## Priority batch G: foundational retro-normalization follow-up candidates

These were clarified during the foundational `waves 1-7` normalization pass and
should remain visible as the next honest follow-ups from the older corpus.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `CrispyPin/ovr-utils` | Partially studied | Historical utility-suite lineage whose GitHub repo is now mostly a relocation stub | Low-Medium | Medium | Follow the current non-GitHub upstream only if a dedicated recovery pass is worthwhile, and compare the lineage with `ovr-utils-dashboard` plus `openvr_widgets` |

## Priority batch H: Wave 14 follow-up candidates

These were surfaced during the Wave 14 source pass, or clarified as the next
honest follow-ups from the tracker-ingress and OSC-export family.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `TheNexusAvenger/Enigma` | Not studied deeply | Consumer-side export of SteamVR tracker roles into a non-XR client with a companion plugin path | Medium | Medium | Clipboard and companion-plugin transport, tracker-role mapping, and whether the pattern generalizes beyond Roblox |
| `ThatGuyThimo/leapmotion-osc` | Not studied deeply | Finger-only OSC export that complements SteamVR hand-tracking stacks | Medium | Medium | Avatar parameter model, OSC send cadence, and whether it teaches anything beyond `VRCThumbParamsOSC` |

## Priority batch I: Waves 20-21 surfaced follow-up candidates

These were surfaced while deepening the rendering-mod and OpenXR gaze-layer
families, but they were intentionally kept out of the core shortlist until the
stronger mainline donors were fully integrated.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `LordOfDragons/openxr_oscclient` | Not studied deeply | Thin OSC-to-OpenXR signal bridge hinting at a lighter runtime-side adaptation path | Medium | Medium | Inspect extension boundary, OSC transport model, and whether it complements or duplicates the broader OpenXR gaze-layer family |

## Priority batch J: Waves 24-27 surfaced follow-up candidates

These were surfaced while strengthening the accessibility, headsetless QA,
vendor IPC, and alignment families, but they were intentionally kept as honest
follow-up nodes instead of being over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `davidrios/openxr-device-simulator` | Not studied deeply | Rust-based runtime simulator that hints at a leaner fake-device path | Medium | Medium | Inspect the rest of the runtime surface, input model, and whether it grows into a stronger simulator comparison node |
| `tobexeon/PSVR2EyeTrackingCalibration` | Already studied in Wave 156 | Real-time PSVR2 eye-calibration client with no runtime restart requirement | Medium | Medium | No urgent follow-up; keep it as a calibration UX and offset-persistence reference unless PSVR2 eye-tracking becomes active scope |

## Priority batch K: Waves 28-31 surfaced follow-up candidates

These were surfaced while deepening VR keyboard, menu, framework, and
teleoperation families, but they were intentionally kept as honest follow-up
nodes instead of being over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `MixedRealityToolkit/MixedRealityToolkit-Unity` | Partially studied | Current-generation continuation of the MRTK spatial-UI line; Wave 113 covered package split, stateful interactables, pressable buttons, manipulation, and solver handlers | High | High | Revisit accessibility helpers, data binding, keyboard, and menu-specific internals if Unity spatial UI becomes active prototype scope |
| `nakama-lab/VR_Teleop_Interface` | Partially studied | Teleoperation stack whose architectural decomposition matters more than any single widget; Wave 119 mapped the main Unity/ROS2/ZED/Franka architecture | Medium | Medium-high | Inspect non-main branches, Unity scene structure, ROS nodes, stereo feed, and haptic feedback internals if this becomes an active teleop branch |
| `h2r/GHOST` | Not studied deeply | Visualization-rich teleoperation sidecar with point-cloud and gesture-control overlap | Medium | Medium-high | Inspect visualization pipeline, gesture boundary, and how tightly it couples to `ros_reality` |

## Priority batch L: Waves 32-35 surfaced follow-up candidates

These were surfaced while deepening communication-sidecar, alternative-runtime,
tracked-device, and expressive-input families, but they were intentionally kept
as honest follow-up nodes instead of being over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `maximum-game-22/openxr-3d-display` | Fork / variant only after Wave 154 | Monado-derived spatial-display runtime variant | Low | Medium | Compare only if it diverges materially from canonical `dfattal/openxr-3d-display` |
| `Kartaverse/OpenDisplayXR` | Not studied deeply | Nonstandard-display project cluster that may expose additional runtime packaging and deployment patterns | Medium | Medium | Inspect the exact split between runtime code, resources, and surrounding platform assets |
| `fughilli/ViveTrackedDevice` | Partially studied | Documentation-first reverse-engineering donor whose main code still sits behind submodules | Medium | Medium | Revisit only when a deeper submodule-aware pass on Lighthouse device internals becomes worthwhile |
| `ebadier/ViveTrackers` | Not studied deeply | Unity-side consumer library for Vive tracker hardware that may clarify the `hardware consumer` side of tracker tooling | Medium | Medium | Inspect API surface, data model, and whether it teaches more than the existing tracker-helper nodes |
| `takana-v/quest_steamvr_fbt_tool` | Studied in Wave 163 | Quest/PC SteamVR tracker serial config and OpenVR-to-OSC FBT export path aimed at avatar-facing consumers | Medium | Low | Keep as a simple reference; compare later only if building a pose-ingress matrix |

## Priority batch M: Waves 36-39 surfaced follow-up candidates

These were surfaced while deepening broader OpenXR utility platforms,
mixed-VR controller bridges, workflow micro-tools, and overlay-host lineage,
but they were intentionally kept as honest follow-up nodes instead of being
over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `bdub1011/Quest-Link-Hand-Tracking` | Partially studied | Gesture-configurable Quest hand tracking mapped to SteamVR controller semantics | Low-Medium | Medium-high | Revisit only if the public driver source grows beyond the current thin placeholder snapshot |

## Priority batch N: Waves 40-43 surfaced follow-up candidates

These were surfaced while deepening VRChat text sidecars, avatar-facing OSC
companions, XR-glasses stacks, and wearable-haptics families, but they were
intentionally kept as honest follow-up nodes instead of being over-promoted
immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `lenoobkinda/VRCOSCUtils` | Partially studied | Broader mixed helper repo that still adds a useful comparison angle around small VRChat-side automation tools | Medium | Medium | Revisit only if a future pass needs a sharper comparison between weakly-structured helper bundles and the clearer companion-framework donors |

## Priority batch O: Waves 44-47 surfaced follow-up candidates

These were surfaced while deepening playspace tooling, redirected-walking
platforms, XR latency measurement stacks, and simulator-sidecar families, but
they were intentionally kept as honest follow-up nodes instead of being
over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `Knerten0815/VR_Dodge_Study` | Fork / variant only | Thesis-driven OpenRDW fork focused on dodging-informed reset research | Low-Medium | Medium | Revisit only if a future redirected-walking pass needs thesis-specific trial-data and sampling-interval changes rather than the main OpenRDW architecture |
| `Greendayle/VR-Motion-to-photon-latency-` | Partially studied | VRChat world plus smartphone slow-motion methodology for quick motion-to-photon checks | Low-Medium | High | Revisit if `VR-apps-lab` needs a more reproducible consumer-grade latency workflow or clearer asset breakdown beyond the Udon script and spreadsheet results |
| `giuseppdimaria/Unity-VRlines` | Partially studied | XR flight-sim prototype with modular aircraft physics and VR controller input mapping | Medium | Medium-high | Inspect the moved manuscript repo, scene architecture, and aircraft-control modules if a future pass needs richer embodied-control or simulator-shell references |

## Priority batch P: Waves 48-51 surfaced follow-up candidates

These were surfaced while deepening VRChat text workflows, OSC companion
frameworks, XR-glasses shells, and biometric or accessory-control families, but
they were intentionally kept as honest follow-up nodes instead of being
over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `MaurerKrisztian/vrc-tts-osc` | Already studied in Wave 157 | Narrow speech or TTS-to-chatbox path that sharpens the `text workflow` comparison line without requiring a broader desktop shell | Medium | Medium | No urgent follow-up; keep it as a virtual-audio plus chatbox micro-utility reference unless voice routing becomes active scope |
| `samyk/myo-osc` | Not studied deeply | Historical armband-to-OSC bridge that could add a useful `wearable input to avatar-facing signal` comparison node | Medium | Medium | Inspect whether it teaches more about wearable acquisition and gesture routing than the newer biometric and accessory-control donors |

## Priority batch Q: Waves 52-55 surfaced follow-up candidates

These were surfaced while deepening overlay scaffolds, media display shells,
Discord or note overlays, and specialized creator or companion surfaces, but
they were intentionally kept as honest follow-up nodes instead of being
over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `Marlamin/VROverlayTest` | Already studied in Wave 153 | Extra-thin C#/OpenTK/OpenVR texture submission scratchpad | Medium-Low | Low-Medium | No urgent follow-up; compare only inside a minimal overlay implementation matrix |
| `beareogaming/BD-XSOverlay-notify` | Already studied in Wave 153 | Desktop plugin that pushes notifications into an existing overlay host over the official XSOverlay WebSocket contract | Medium | Medium | No urgent follow-up; compare payload model inside a future overlay-host protocol matrix |
| `iigomaru/MPVR` | Partially studied | Very rough `libmpv inside OpenVR overlay` proof of concept that may still matter as a lower-bound media embed comparison node | Medium | Medium | Revisit only if a future pass needs a cleaner comparison between full `vr-video-player-overlay` style shells and direct media-engine embedding |

## Priority batch R: Waves 56-59 surfaced follow-up candidates

These were surfaced while deepening browser-backed overlay runtimes, Linux
overlay shells, micro-overlays, and embodied-control surfaces, but they were
intentionally kept as honest follow-up nodes instead of being over-promoted
immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `CrispyPin/sinpin-vr` | Not studied deeply | Linux overlay project whose GitHub repo is now mostly a relocation stub | Low-Medium | Medium | Follow the moved upstream only if a future Linux overlay recovery pass becomes worthwhile |
| `Yukiiro-Nite/notebook-vr-overlay` | Partially studied | Rough note-surface overlay with explicit event plumbing but incomplete drawing or persistence flow | Medium | Medium | Revisit if a future pass needs deeper note persistence, drawing, or writing-state UX rather than just a lower-bound prototype |
| `OpenShock/VROverlay` | Partially studied | Older Unity lineage for a stronger current remote-device control overlay branch | Medium | Medium-High | Revisit only if a future lineage pass needs a tighter comparison against `OVR-Shock` |
| `NewChromantics/PopExposeXr` | Not studied deeply | Thin XR-state exposure concept that hints at a possible outward-facing bridge family | Medium | Medium | Inspect the networking contract and state-exposure model only if the public repo grows beyond its current sparse snapshot |

## Priority batch S: Waves 60-63 surfaced follow-up candidates

These were surfaced while deepening low-level overlay scaffolds,
managed-language starters, companion overlays, and specialized effect surfaces,
but they were intentionally kept as honest follow-up nodes instead of being
over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `Daniel-Webster/WT-OpenVR-Overlay` | Partially studied | Broad Unity overlay app whose local webservice and embedded overlay-framework lineage may still hide reusable pieces | Medium | Medium-High | Narrow the next pass to the reusable `OVRLay` boundary, local service consumption, and what is genuinely donor-worthy beyond the War Thunder-specific shell |
| `kurohuku7/zenn-overlay-tutorial` | Already studied in Wave 153 | Tutorial-first SteamVR overlay teaching path that may matter more as onboarding material than as a code donor | Low-Medium | Medium | No urgent follow-up; use when writing overlay lifecycle/onboarding docs |
| `Wulkop/VolumeVR` | Partially studied | Narrow `CEF`-based media or volume shell whose current public donor surface exposes bootstrapping more clearly than overlay behavior | Medium | Medium | Inspect whether deeper overlay logic lives in submodules or hidden paths, and compare the result against broader browser-runtime hosts |
| `emymin/EmyOverlay` | Already studied in Wave 153 | Thin OpenGL/ImGui overlay skeleton with offscreen framebuffer and controller-ray mouse input | Medium | Low-Medium | No urgent follow-up; compare only inside a native overlay baseline matrix |

## Priority batch T: Waves 80-83 surfaced follow-up candidates

These were surfaced while deepening VR audio helpers, immersive playback
systems, spatial-audio substrate, and creator-facing audio frameworks, but
they were intentionally kept as honest follow-up nodes instead of being
over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `BIVROST/360PlayerWindows` | Partially studied | Mature multi-headset media shell whose reusable value may extend beyond the current shell and headset split coverage | High | High | Inspect decoder, service-result, and per-backend playback layers more deeply if a future media-shell pass needs stronger desktop-plus-headset references |
| `videolan/vlc-unity` | Partially studied | Broad engine media framework where the strongest donor value may sit in packaging, backend abstraction, and immersive playback demos rather than one player prefab | High | High | Narrow the next pass to plugin packaging, demo scripts, and what parts of the LibVLC bridge are most reusable for VR utility work |
| `videolabs/libspatialaudio` | Partially studied | Unified spatial audio renderer spanning HOA, objects, speaker, and binaural output | High | Medium-High | Narrow the next pass to the actual `Renderer` implementation, object flow, and how much of the doc surface corresponds to direct donor code |
| `VoidXH/Cavern` | Partially studied | Broad immersive audio framework with Unity-like listener or source semantics plus filters and remapping | High | High | Revisit only if a future audio-substrate pass needs a fuller map of rendering, calibration, and Unity-side integration rather than current high-level architecture notes |
| `llealloo/audiolink` | Partially studied | Audio-reactive ecosystem where `_AudioTexture`, controller surfaces, and creator-side integrations may justify a dedicated donor pass | High | High | Inspect player APIs, mini-player flow, sync semantics, and shader or script integration boundaries more deeply |
| `JLChnToZ/VVMW` | Partially studied | Large modular creator-facing media frontend whose strongest reusable boundaries may sit between core, playlist, screen, and overlay subsystems | High | High | Narrow the next pass to core partials, frontend or queue boundaries, and which slices are genuinely donor-worthy beyond the full product shell |

## Priority batch U: Waves 84-87 surfaced follow-up candidates

These were surfaced while deepening browser panoramic players, engine-side
stereo panoramic viewers, creator-side synced video systems, and nonstandard
3D media viewers, but they were intentionally kept as honest follow-up nodes
instead of being over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `UNAmedia/ue5-stereo-panoramic-player-demo` | Partially studied | Public Unreal demo shell that exposes a strong `authoring surface plus programmable sphere` split even though the core plugin is external | Medium | High | Revisit only if a future pass needs the real plugin boundary, actor model, and asset flow rather than the public demo client |
| `koorimizuw/YamaPlayer` | Partially studied | Broad modular creator-facing video frontend with playlist, queue, handler, and integration surfaces | High | High | Narrow the next pass to controller partials, handler abstraction, module boundaries, and what is genuinely reusable beyond the full creator package |
| `fbriggs/lifecast_public` | Partially studied | Volumetric and VR180 playback substrate spanning WebXR player code and engine export targets | High | High | Narrow the next pass to media-format handling, volumetric playback core, and where the reusable web or engine boundaries actually sit |
| `parkchamchi/DepthViewer` | Partially studied | Depth-expanded 3D viewer that turns image or video input plus several inference backends into a navigable mesh surface | Medium-High | High | Revisit if `VR-apps-lab` needs a deeper `depth-to-3D media viewer` donor pass or clearer backend comparison |
| `prefrontalcortex/DomeTools` | Partially studied | Dome-style viewing environment where local media, `NDI`, and `Spout` ingest all feed one immersive shell | Medium | High | Revisit when a future pass needs deeper source-ingest flow, creator-viewer split, and dome-space interaction coverage |

## Priority batch V: Waves 88-91 surfaced follow-up candidates

These were surfaced while deepening VRChat creator-world authoring, runtime
infrastructure, camera/admin control, and utility-prefab families, but they
were intentionally kept as honest follow-up nodes instead of being
over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `Varneon/UdonEssentials` | Partially studied | Historical prefab-suite baseline that still matters for lineage even though the repo is deprecated | Medium | High | Compare the old bundle more directly against `VUdon` package decomposition and identify which legacy prefabs still deserve standalone follow-up |
| `Varneon/VUdon` | Partially studied | Ecosystem umbrella for packageized creator tools where the strongest donor value sits in the linked package repos | Medium | High | Inspect `QuickMenu`, `Menus`, `PlayerTracker`, and `Common` as individual package repos rather than treating the umbrella as the whole system |
| `VRLabs/Camera-System` | Partially studied; Wave 158 deepened companion architecture | Avatar-driven OSC camera path system whose main architecture crosses an avatar package and an external companion executable | Medium | High | Next follow-up should target companion source/protocol details only if the missing executable/source path becomes available or camera-path tools become active scope |
| `SylanTroh/GMMenu` | Partially studied | Broad modular admin surface where watch camera, pings, permissions, teleports, and optional audio modes interact | High | High | Map the permission model, ping or alert flow, and optional `AudioManager` branch more directly instead of only the watch-camera slice |
| `Miner28/AvatarImageReader` | Partially studied | Unusual dynamic data carrier that encodes text through avatar imagery and runtime pedestal decoding | Medium | High | Re-check the editor encoder, multi-avatar queueing, and what parts still matter after the original string-loading era shifted |
| `Guribo/UdonLeaderBoard` | Not studied deeply | Possible scoreboard or ranking layer that may pair especially well with recycled-cell list infrastructure | Medium | Medium | Inspect whether it is mostly prefab sugar over `UdonRecyclingScrollRect` or whether it contributes a stronger data-model and sorting layer of its own |

## Priority batch W: Waves 92-95 surfaced follow-up candidates

These were surfaced while deepening VRChat world persistence, creator
diagnostics, embodied interaction, and creator utility-foundation families, but
they were intentionally kept as honest follow-up nodes instead of being
over-promoted immediately.

| Project | Current status in `VR-apps-lab` | Interesting idea | Code donor value | Product reference value | What to inspect next |
|---|---|---|---|---|---|
| `ChrisFeline/ToNSaveManager` | Partially studied | World-specific save companion that becomes interesting as a reusable `log parser + event bus + plugin host` even outside its original world | High | High | Narrow the next pass to DB model, JS plugin API, WebSocket event contract, and where the world-specific logic cleanly separates from the generic sidecar substrate |
| `DarthShader/Udon-MIDI-Web-Helper` | Partially studied | External helper that extends creator worlds through logs, HTTP, WebSocket, local storage, and MIDI return transport without client mods | High | High | Map the exact request framing, trust boundaries, local-storage model, and how much of the transport is reusable outside this specific helper |
| `GotoFinal/GotoUdon` | Partially studied | Broad editor-side Udon rehearsal stack whose strongest value may be the split between emulation, event injection, and multi-client test workflow | High | High | Inspect the client-launch automation, ownership or networking shims, and how much of the simulation core is reusable independently of the Unity editor chrome |
| `Janooba/immersive-interactions` | Partially studied | Package-shaped physical interaction toolkit where the strongest donor value may sit in collider rig generation, switch variants, and prefab decomposition | High | High | Split the next pass across buttons, switches, levers, and skeleton-generation helpers instead of treating the package as one surface |
| `Nestorboy/NUMovement` | Partially studied | Extensible movement framework that may hide several reusable sub-patterns under one broad controller package | High | High | Inspect the extension seams, debug helpers, moving-platform model, and which slices are best kept as framework substrate versus narrow movement donors |
| `kurotori4423/KurotoriUdonKart` | Partially studied | Broad creator vehicle rig whose most reusable value may be in seat-state, handle logic, and time-attack or race-side companions rather than the base kart loop alone | Medium-High | High | Map the seat, ranking, and state-side modules and compare the VR steering surface more directly against other embodied-control donors |
| `Guribo/UdonUtils` | Partially studied | Broad creator utility foundation where lifecycle, singleton identity, and execution-order validation are only the first layer of a larger subsystem tree | High | High | Peel off network-time, task, event, or helper subsystems and decide whether `UdonUtils` should become a multi-pass foundation donor rather than one registry node |

## Family-level gaps that now deserve deeper passes

These are larger than a single repo and should guide the next research wave.

### 1. `Virtual tracker / OSC platform`

- Main entries:
  `VirtualMotionTracker`, `SteamVR_To_OSC`, `OpenVR2OSC`, `OpenVR-OSC`,
  `VRCThumbParamsOSC`, `axis-vrc-osc-bridge`
- Why it matters:
  this is still one of the strongest product directions in the whole repo, and
  it now spans both `SteamVR-centric export` and `direct OSC consumer` flows.

### 2. `Overlay implementation references and overlay-first hosts`

- Main entries:
  `VROverlay`, `SteamVR-Webkit`, `SteamVR_HUDCenter`, `SteamVR-WebApps`,
  `OVROverlayManager`, `LapisOverlay`, `h-view`, `VRSceneOverlay`,
  `godot-openvr-overlay`, `csharp-openvr-overlay-imgui`, `SampleVRO`,
  `ovrsalt`, `electron-openvr`, `ovrly`, `ComposeVR`
- Why it matters:
  this remains the clearest place to compare `scene-overlay scaffolds`,
  `desktop UI rasterization bridges`, `overlay-first hosts`,
  `engine-native projection overlays`, `browser-backed overlay runtimes`,
  and `micro-overlay patches` as distinct construction strategies.

### 3. `Runtime-side service hosts and broader OpenXR utility platforms`

- Main entries:
  `clearxr-server`, `vrkit-platform`, `openxr-explorer`,
  `OpenXR-API-Layers-GUI`
- Why it matters:
  Wave 36 clarified the family considerably, but the repo still needs a
  narrower follow-up on the broadest platform node, especially
  `vrkit-platform`, so the donor picture does not collapse back into a generic
  `runtime tools` bucket.

### 4. `Mixed-VR controller and tracker bridges`

- Main entries:
  `Oculus_Touch_Steam_Link`, `SteamVR-OpenHMD`,
  `Yet-Another-OpenVR-IPC-Driver`, `Quest-Link-Hand-Tracking`,
  `VirtualDesktop-OpenVR-Trackers`
- Why it matters:
  Wave 37 made the mainline donors much clearer, but the family still benefits
  from future comparison between strong bridges, thin hand-emulation repos, and
  hardware-specific variants.

### 5. `Low-level driver tutorial and custom-device plumbing`

- Main entries:
  `Simple-OpenVR-Driver-Tutorial`, `Barebone`, `OpenVR-ArduinoHMD`,
  `SteamVR-TrueOpenVR`
- Why it matters:
  the mainline donors are now strong enough that the remaining value is in
  thinner comparison nodes and more explicit learning-path synthesis.

### 6. `Virtual display and repurposed output workflows`

- Main entries:
  `virtual_display`, `VRto3D`, `Virtual-Display-Driver`,
  `OpenDisplayXR-VDD`
- Why it matters:
  this family keeps pointing toward glasses, creator, and simulated-hardware
  workflows that do not fit neatly into ordinary overlay buckets.

### 7. `Vision-based hand and body tracking bridges`

- Main entries:
  `driver_ultraleap`, `HandOfLesser`, `Mediapipe-VR-Fullbody-Tracking`,
  `NVIDIA-BodyTracking`, `VR-AI-Full-Body-Tracking`
- Why it matters:
  cameras, vendor hand-tracking services, and foreign runtimes are now a
  distinct architecture zone for producing SteamVR hands, trackers, or body
  inputs.

### 8. `PSVR2-specific OpenXR eye-tracking and calibration follow-up`

- Main entries:
  `PSVR2_OpenXR_Eye_Tracking`, `PSVR2EyeTrackingCalibration`,
  `PSVR2Toolkit`
- Why it matters:
  the broader vendor-enhancement family is now much stronger, which makes the
  remaining PSVR2-specific OpenXR and calibration nodes more valuable as a
  future focused comparison wave.

### 9. `Validation and workflow micro-utilities`

- Main entries:
  `SteamVR-ActionsManifestValidator`, `Lighthouse-Scale-Fix`,
  `SteamVRAdaptiveBrightness`, `steamvr-exconfig`, `WFOVFix`
- Why it matters:
  Wave 38 clarified the core donor patterns, and the remaining value now lies
  more in productization and comparison than in basic discovery.

### 10. `Historical utility-suite recovery`

- Main entries:
  `ovr-utils`, `ovr-utils-dashboard`, `openvr_widgets`
- Why it matters:
  Wave 39 made the lineage much clearer, but one partly unresolved branch still
  exists because the live `ovr-utils` code moved off GitHub and the public
  donor picture is still partly archival.

### 11. `VRChat text workflow refinements and TTS follow-up`

- Main entries:
  `vrcosc-magicchatbox`, `Chatbox`, `VRCT`, `TaSTT`, `KillFrenzyAvatarText`,
  `VRCOSCChatbox`
- Why it matters:
  the repo now has strong donors for `bounded text composition`,
  `mobile relay`, `translation shell`, `avatar text surfaces`, and
  `tiny senders`, so the remaining value is in sharper TTS follow-up and
  cleaner product comparison rather than basic discovery.

### 12. `Avatar-facing OSC companion frameworks and automation relays`

- Main entries:
  `OscGoesBrrr`, `VRCRouter`, `Quest2-VRC`, `vrc-oscquery-lib`,
  `vrchat-mcp-osc`, `OSCmooth`
- Why it matters:
  these repos now clarify desktop companions, discovery frameworks, relays, and
  smoothing layers; the next value lies in sharper comparison and productization
  rather than proving the family exists.

### 13. `XR glasses workspace shells and head-tracked screen tools`

- Main entries:
  `XRLinuxDriver`, `breezy-desktop`, `OpenVR-xrealAirGlassesHMD`,
  `virtual-display-rs`, `viture_virtual_display`, `desktop2stereo`,
  `PhoenixHeadTracker`
- Why it matters:
  special-display workflows now span platform shells, runtime-facing HMD paths,
  virtual-display services, screen-transformation tools, and non-XR tracking
  sidecars.

### 14. `Biometric, neurofeedback, and accessory-control bridges`

- Main entries:
  `PulsoidToOSC`, `iron-heart`, `vrc-osc-miband-hrm`, `vrc-osc-manager`,
  `OpenShock-ESP-Legacy`, `BrainFlowsIntoVRChat`
- Why it matters:
  the repo now has a distinct branch for measurements, biosignal trees,
  accessory plugins, and safety-aware embedded controllers, which is different
  from ordinary haptics bridges.

### 15. `Wearable haptics and avatar-driven feedback systems`

- Main entries:
  `ShockOSC`, `VRChatOSC`, `VRC-Haptic-Pancake`, `vrc-patpatpat`,
  `senseshift-firmware`
- Why it matters:
  tactile tooling now has clear layers around avatar authoring, bridge routing,
  solver logic, and firmware or hardware reference stacks.

### 16. `Playspace editors and room-boundary tooling`

- Main entries:
  `ChaperoneTweak`, `xr-chaperone`, `Guardian2Chaperone`,
  `Playspace-Mover`, `RotatoExpress`
- Why it matters:
  this family now clearly spans room authoring, boundary import, live room
  transform control, and shared-space helper patterns.

### 17. `Redirected walking and locomotion adaptation toolkits`

- Main entries:
  `RDWT`, `OpenRDW`, `OpenRDW2`, `ArmSwinger`
- Why it matters:
  algorithm harnesses and comfort locomotion are now a distinct reusable
  family rather than just scattered movement experiments.

### 18. `XR latency measurement and replay-analysis tooling`

- Main entries:
  `motion-to-photon-measurement`, `VRLate`, `vrlatency`,
  `dreyevr_recording_analyzer`
- Why it matters:
  this family now spans lab-style measurement, consumer-grade checks, and
  parser or analyzer tooling for XR replay data.

### 19. `Simulation telemetry overlays and motion-cueing sidecars`

- Main entries:
  `TinyPedal`, `VPforce-TelemFFB`, `SpaceMonkey`, `SimFeedback-AC-Servo`,
  `DReyeVR`
- Why it matters:
  mature sim sidecars and research simulator stacks are now clear donor lines
  for future VR utility and helper-app design.

### 20. `Context-aware overlay surfaces and specialized display shells`

- Main entries:
  `SteamVR-Discord-Overlay`, `vr-notes-anywhere`, `SmudgeTimerOpenVR`,
  `VRBro-Overlay`, `ROVER`, `steamvr-overlay-vrbuddy`, `VRPoleOverlay`
- Why it matters:
  the latest waves made it clear that some of the best overlay donors are not
  desktop mirrors at all, but narrow contextual surfaces with their own local
  state, control panel, study schema, collaborator view, or room anchor.

### 21. `Browser-backed overlay runtimes and web-tech UI hosts`

- Main entries:
  `ovrsalt`, `electron-openvr`, `ovrly`, `ComposeVR`
- Why it matters:
  these repos now expose several distinct answers to `web or declarative UI as
  overlay runtime`, from tiny frame-capture bridges to daemon-backed browser
  hosts.

### 22. `Linux overlay control shells and desktop-service panels`

- Main entries:
  `OVR4X11`, `SVRLinuxTools`, `OpenVR_Audio_Manager`
- Why it matters:
  Linux overlay tooling now has enough donor surface to justify its own follow-
  up branch around service panels, controller-mouse interaction, and desktop
  fallback modes.

### 23. `Micro-overlays, timed status surfaces, and informational display helpers`

- Main entries:
  `OVRBrightnessAPI`, `VR-Slideshow-Overlay`, `VRSessionTimer`,
  `notebook-vr-overlay`
- Why it matters:
  the latest pass made it clear that `small overlay with one strong value` is a
  coherent donor family, not just a set of weak side projects.

### 24. `Embodied workflow overlays and external-device control panels`

- Main entries:
  `bikeheadvr`, `Omni-Tune`, `OVR-Shock`, `OpenShock/VROverlay`
- Why it matters:
  these repos show that some overlay families are really `control surfaces`
  over body motion, live tuning, or remote hardware rather than informational
  panels.

### 25. `Code-first overlay scaffolds and projection-overlay baselines`

- Main entries:
  `OpenGL-VROverlay`, `OpenVRWindowOverlay`, `openvr-overlay-test`,
  `openvr-overlay-bunny`
- Why it matters:
  the latest pass made it clear that `small honest overlay baselines` are a
  reusable family of their own rather than just implementation trivia.

### 26. `Managed-language overlay starters and Unity event-bridge scaffolds`

- Main entries:
  `uitoko-ovr`, `BasicOverlay`, `OpenVR-Overlay`, `WT-OpenVR-Overlay`
- Why it matters:
  this branch now spans reusable Unity templates, managed GPU-interoperable
  hosts, and broader app-specific scaffolds with clearer service boundaries.

### 27. `Desktop-adjacent companion overlays and phone or media control surfaces`

- Main entries:
  `OVR_SLDO`, `OVRPhoneBridge`, `ViveOverlayPaster`, `VolumeVR`
- Why it matters:
  the overlay corpus now clearly includes `companions for external workflows`,
  not just dashboards or full runtime hosts.

### 28. `Specialized effect overlays and visibility-shaping comfort surfaces`

- Main entries:
  `OpenMixerXR`, `SteamVRBlackBarOverlay`, `VR-Overlay-Half_Ring`,
  `OpenVR-Windows-Activation`
- Why it matters:
  the latest pass made it clear that `effect-first overlays` are a meaningful
  product family with reuse value for comfort, passthrough cutouts, and visual
  masking.

### 29. `OpenXR sample-app bring-up references and rendering baselines`

- Main entries:
  `OpenXRSamples`, `openxr-vulkan-example`, `wgpu-openxr-example`,
  `android_openxr_gles`, `openxr-simple-example`, `OpenXR-Samples`
- Why it matters:
  the latest pass made it clear that `OpenXR bring-up references` are a
  reusable donor family of their own, spanning one-file lower bounds,
  structured sample apps, desktop-to-XR migration paths, and shared-core sample
  suites.

### 30. `OpenXR language bindings and wrapper-generation systems`

- Main entries:
  `openxrs`, `pyopenxr`, `OpenXR.NET`, `openxr-zig`, `openxr.py`, `rlOpenXR`
- Why it matters:
  the repo now has a distinct donor branch for `how OpenXR gets wrapped`,
  including safe-plus-raw stacks, generated scripting facades, managed-language
  emitters, and build-integrated wrapper generation.

### 31. `OpenVR language bindings and runtime facades`

- Main entries:
  `rust-openvr`, `pyopenvr`, `openvr-go`, `node-openvr`, `OpenVR.NET`,
  `java openvr`
- Why it matters:
  the latest pass made it clear that `OpenVR access layers` are not just thin
  interop trivia; they are reusable donor families for typed wrappers,
  scripting surfaces, runtime bridges, and richer managed-language facades.

### 32. `OpenVR tracking export, record-replay, and robotics integration`

- Main entries:
  `OpenVR-Tracking-Example`, `openvr_ros`, `openvr_ros_bridge`,
  `openvr_ros2_tracker`, `openvr-input-recorder`, `vrviz`, `vrpn-openvr`
- Why it matters:
  tracking export is now clearly broader than `send poses somewhere`; it
  includes pluggable publishers, record-replay harnesses, and VR-native
  consumers for robotics topics.

### 33. `VMT adapters, OSC action compilers, and skeletal validation utilities`

- Main entries:
  `VirtualMotionTracker`, `SteamVR_To_OSC`, `OpenVR-OSC`, `VMC2VMT`,
  `SkeletonPoseTester`, `OVR-VRC-OSC-Bridge`
- Why it matters:
  this branch now separates `mature tracker host`, `thin OSC exporter`,
  `protocol adapter`, `skeletal validation node`, and `config-defined
  controller-state compiler` into one coherent product family.

### 34. `OpenXR platform shells, layer managers, and runtime inspection workbenches`

- Main entries:
  `vrkit-platform`, `clearxr-server`, `openxr-explorer`,
  `OpenXR-API-Layers-GUI`
- Why it matters:
  this family turns `OpenXR doctor` from a vague idea into a concrete cluster
  of runtime-side platforms, session-owning shells, shared GUI-plus-CLI
  inspectors, and repair-oriented layer managers.

### 35. `Mixed-VR controller bridges, hand emulation, and external-tracker interop`

- Main entries:
  `Oculus_Touch_Steam_Link`, `SteamVR-OpenHMD`,
  `Yet-Another-OpenVR-IPC-Driver`, `Quest-Link-Hand-Tracking`,
  `PSVR-SteamVR-openHMD`, `VirtualDesktop-OpenVR-Trackers`
- Why it matters:
  controller reuse is now broader than pose transport alone; it spans profile
  reuse, command-driven synthetic devices, declarative hand emulation, and
  hardware-specific OpenHMD variants.

### 36. `OpenVR driver learning paths, synthetic devices, and remote-input ingress`

- Main entries:
  `Simple-OpenVR-Driver-Tutorial`, `openvr-driver-example`, `Barebone`,
  `OpenVR-ArduinoHMD`, `RemoteVVR`, `OpenVR-Tracker-Driver-Example`
- Why it matters:
  this family exposes the smallest honest `driver baseline` path, from
  tutorial shells and narrow input examples to DIY HMDs, remote/file-fed
  ingress, and tracking-override harnesses.

### 37. `OpenVR overlay access layers, starter variants, and minimal shell experiments`

- Main entries:
  `ovr_overlay`, `OpenVROverlayTest`, `UniversalVROverlay`,
  `OpenVR.ALBRT.overlay`
- Why it matters:
  this family now makes the `smallest honest overlay implementation layers`
  explicit, from focused access wrappers to dashboard starters and desktop
  shells over shared overlay backends.

### 38. `WayVR ecosystem add-ons, Linux dashboard extensions, and IPC-backed overlay surfaces`

- Main entries:
  `wayvr`, `wayvr-dashboard`, `wayvr-ipc`, `WayvrWalltaker`
- Why it matters:
  the latest pass made it clear that some Linux desktop-in-VR families are
  really `host ecosystems`, not single tools, with reusable splits across
  compositor core, protocol crate, dashboard client, and script extension.

### 39. `OpenVR capture, replay, and orchestration toolchains`

- Main entries:
  `vr-capture-replay`, `virtual-camera-offset`,
  `VRScout_Agent_Orchestration_Unity_Project`, `ViRe`
- Why it matters:
  this branch now separates `capture artifact`, `replay driver`,
  `post-capture alignment`, `closed-loop orchestration`, and
  `VR-native recording studio`
  into one coherent product family.

### 40. `OpenXR micro-layers for view shaping, streamout, debugging capture, and frame-time intervention`

- Main entries:
  `OpenXR-RecenterOverride`, `OpenXR-Layer-crop-fov`,
  `openxr_streamout_layer`, `openxr-renderdoc-layer`,
  `Smoothing-OpenXR-Layer`
- Why it matters:
  the latest pass made it clear that `OpenXR layer` is not only about generic
  templates or compatibility work; it now includes operator-facing micro-tools,
  stream bridges, developer-tool integration, and advanced frame intervention.

### 41. `OpenXR capability-injection layers, input remappers, and peripheral extension bridges`

- Main entries:
  `OpenXRHandTracking`, `openxr_remapping_layer`, `OpenXR_ApiLayer_Patstrap`
- Why it matters:
  the latest pass made it clear that some of the best OpenXR layers do not
  inspect or patch rendering at all; they add new capability surfaces or remap
  semantics before the app sees them.

### 42. `OpenXR helper stacks, layer toolchains, and runtime adaptation helpers`

- Main entries:
  `quark`, `rayxr`, `openxr-layer-scripts`, `OpenXR-CAS`
- Why it matters:
  this branch now spans authoring frameworks, tiny renderer-facing helpers,
  loader-hygiene micro-tools, and more productized runtime adaptation layers.

### 43. `OpenXR passthrough samples and engine-side extension integration references`

- Main entries:
  `ue-openxr-passthrough`, `godot_test_passthrough`,
  `mr-openxr-unity-meta-passthrough-sample`
- Why it matters:
  the latest pass made it clear that engine-facing OpenXR integration is a
  reusable family of its own, especially when a plugin or sample adds one
  runtime feature cleanly without dragging in a full vendor stack.

### 44. `Desktop-window overlay shells, Linux capture utilities, and launcher stubs`

- Main entries:
  `DesktopOverlayer`, `ovr-penguin`, `RobloxVRLauncher`
- Why it matters:
  this branch now captures a rougher but still useful part of the overlay
  landscape: native texture bridges, CLI-first capture hosts, and thin launcher
  product directions that should be tracked honestly.

### 45. `Microphone control, voice-input fan-out, and audio routing helpers`

- Main entries:
  `OpenVR-MicrophoneControl`, `VRCTextboxSTT`, `OpenVR_Audio_Manager`,
  `Virtual-Audio-Driver`
- Why it matters:
  this branch now makes `VR audio helpers` much more explicit, spanning
  mic-state dashboards, STT fan-out sidecars, endpoint-routing panels, and
  lower-layer virtual audio substrate.

### 46. `Immersive media playback and browser video shells`

- Main entries:
  `around-sound`, `360PlayerWindows`, `WebXR-video-player`, `vlc-unity`
- Why it matters:
  immersive playback is now a clearer family of its own, spanning VR-native
  music experiences, desktop-plus-headset shells, browser-native video players,
  and engine-side media frameworks.

### 47. `Spatial audio SDKs, renderers, and audio-object optimization`

- Main entries:
  `spatialaudio-unity`, `libspatialaudio`, `omnitone`, `Cavern`,
  `spatial-audio-clustering`
- Why it matters:
  the repository now has a much stronger lower-layer audio branch covering
  engine spatializers, unified renderers, browser ambisonics, broad immersive
  audio frameworks, and object-budget optimization.

### 48. `Creator-facing audio systems and world voice management`

- Main entries:
  `audiolink`, `USharpVideo`, `USharpVideoQueue`, `VVMW`, `AudioManager`
- Why it matters:
  creator-side audio is now clearly broader than one player or one reactive
  prefab. It spans audio-reactive substrate, synced media cores, queue
  companions, modular media frontends, and world voice-state control.

### 49. `Browser panoramic video players and projection-aware web playback`

- Main entries:
  `360WebPlayer`, `videojs-panorama`, `videojs-vr`, `VR-Player`
- Why it matters:
  the latest pass made it clear that `immersive browser playback` is not one
  shell shape; it spans full playback frameworks, plugin upgrades over existing
  players, projection-enum control surfaces, and thin mobile wrappers.

### 50. `Engine-side stereo panoramic viewers and vendor playback samples`

- Main entries:
  `Unity_Panorama180View`, `VideoPlayer-UnityXR`,
  `ue5-stereo-panoramic-player-demo`
- Why it matters:
  engine-side playback now has a clearer donor branch of its own around
  projection-surface components, layout-specific sample matrices, and
  higher-level panoramic authoring shells.

### 51. `Creator-side synced video player frameworks and queue frontends`

- Main entries:
  `VideoTXL`, `UdonVideoplayer`, `YamaPlayer`
- Why it matters:
  the latest pass made it clear that `creator video system` is broader than one
  sync script; it spans manager splits, queue and playlist flow, backend
  abstraction, and extension-heavy frontends for events or shared spaces.

### 52. `Transformed, volumetric, and nonstandard 3D video viewers`

- Main entries:
  `VR-reversal`, `lifecast_public`, `DepthViewer`, `DomeTools`
- Why it matters:
  this branch now captures several unusual but reusable media directions:
  transform-driven viewers, volumetric and VR180 substrate, depth-expanded
  media viewers, and immersive dome environments with multi-source ingest.

### 53. `VRChat world-authoring toolkits, optimization helpers, and prefab ecosystems`

- Main entries:
  `VRWorldToolkit`, `UdonSharpOptimizer`, `UdonEssentials`, `VUdon`
- Why it matters:
  the latest pass made it clear that `creator-world tooling before runtime` is
  a reusable donor branch of its own, spanning build-request guardrails,
  compiler-pipeline intervention, legacy prefab suites, and ecosystem-shaped
  package constellations.

### 54. `VRChat world runtime infrastructure, voice, networking, and player-state helpers`

- Main entries:
  `UdonVoiceUtils`, `UNet`, `UdonPlayerPlatformHook`, `CyanPlayerObjectPool`
- Why it matters:
  this branch now shows that `creator-world runtime substrate` is broader than
  one sync script, spanning voice-state control, byte-array transport,
  moving-platform correction, and stable per-player object anchoring.

### 55. `VRChat camera, staging, and admin-control systems for world events`

- Main entries:
  `VRChatCameraWorks`, `CameraSystem`, `Camera-System`, `GMMenu`
- Why it matters:
  the latest pass made it clear that `creator camera tooling` splits into
  prefab staging rigs, world-side operator consoles, avatar-driven OSC camera
  paths, and broader admin surfaces with watch-camera modules.

### 56. `VRChat interaction, utility UI, and information-surface prefabs`

- Main entries:
  `U-Key`, `VRCMarker`, `AvatarImageReader`, `UdonRecyclingScrollRect`,
  `UdonLeaderBoard`
- Why it matters:
  this branch now captures a broad but coherent family of creator-world
  interaction surfaces: access-control prefabs, annotation tools, dynamic data
  carriers, and lower-layer list or board infrastructure.

### 57. `VRChat world persistence, inventory, and external-data bridges`

- Main entries:
  `NUSaveState`, `ToNSaveManager`, `InventorySystem`,
  `Udon-MIDI-Web-Helper`
- Why it matters:
  this family now shows that `creator-world persistence` splits across pure
  in-world encoding, synced inventory ownership, world-specific save
  companions, and external helper bridges for data the platform does not expose
  directly.

### 58. `VRChat creator diagnostics, editor inspection, profiling, and static analysis`

- Main entries:
  `GotoUdon`, `UdonExplorer`, `UdonSharpProfiler`,
  `UdonRabbit.Analyzer`
- Why it matters:
  this family now makes `creator diagnostics` a concrete branch of its own,
  spanning simulation, inspection, compiler instrumentation, and analyzer-based
  guardrails.

### 59. `VRChat embodied interaction, custom movement, and physical world mechanics`

- Main entries:
  `immersive-interactions`, `UdonTether`, `NUMovement`, `UdonDoor`,
  `KurotoriUdonKart`
- Why it matters:
  this family now captures a strong creator-world mechanics branch where the
  key donor value sits in collider rigs, locomotion controllers, narrow
  physical prefabs, and vehicle-state splits rather than in generic UI.

### 60. `Udon data-structure libraries, serialization helpers, and creator utility foundations`

- Main entries:
  `UdonUtils`, `udon-list`, `udon-dictionary`, `udon-json`,
  `UArrayCollections`, `VUdon-ArrayExtensions`
- Why it matters:
  this family now makes `creator substrate` explicit, from lifecycle and
  execution-order foundations to historical collection emulation and modern
  array-first helper layers.

### 61. `VRChat creator starter baselines, test harnesses, and language-boundary experiments`

- Main entries:
  `template-world`, `template-udonsharp`, `udon-test`, `wasm2usharp`
- Why it matters:
  this family now makes the `very first creator-world layer` explicit, spanning
  official bootstrap lineage, in-world assertion helpers, and unusual
  alternative-language experiments that still target UdonSharp.

### 62. `Udon encoding, token, query, and structured-data micro-libraries`

- Main entries:
  `udon-encoding`, `udon-jwt`, `ULinq`, `UdonXMLParser`
- Why it matters:
  this family now captures a strong constrained-runtime micro-library branch:
  manual encoding fallback, frame-sliced cryptography, compile-time query DSL
  lowering, and structured-data parsing over `DataDictionary` or `DataList`.

### 63. `Udon sync, events, runtime logging, and shared helper micro-frameworks`

- Main entries:
  `VUdon-Events`, `UdonSharpNetworkingLib`, `LightSync`, `VUdon-Logger`
- Why it matters:
  this family now makes `creator runtime helper frameworks` much clearer,
  spanning serialized event routing, typed RPC surfaces, stateful sync lineage,
  and in-world diagnostics.

### 64. `VRChat world control gadgets, environmental systems, and specialized operator surfaces`

- Main entries:
  `VUdon-DepthBufferToolkit`, `VR-Stage-Lighting`,
  `UdonSharpDayNightController`, `VRChat_Keypad`, `UdonKeypad`
- Why it matters:
  this family now captures a coherent control-surface branch across narrow
  render fixups, shared environmental clocks, larger operator ecosystems, and
  reusable access-control gadgets.

### 65. `VRChat avatar setup, optimization, and Quest portability`

- Main entries:
  `PumkinsAvatarTools`, `VRCQuestTools`, `d4rkAvatarOptimizer`,
  `immersive_scaler`
- Why it matters:
  this family now makes the avatar bring-up pipeline explicit across editor
  workbenches, validator-driven mobile conversion, upload-time optimization,
  and DCC-side proportional scaling.

### 66. `VRChat avatar composition, packaging, and install automation`

- Main entries:
  `modular-avatar`, `modular-avatar-as-code`, `vrc-get`,
  `Avatars-3.0-Manager`
- Why it matters:
  this family now captures a strong creator integration branch where
  composition substrate, package management, and install-safe helper shells all
  matter together.

### 67. `VRChat avatar emulation, gesture preview, repair, and OSC-assisted posing`

- Main entries:
  `Av3Emulator`, `VRC-Gesture-Manager`, `avautils`, `LexisPosingSystem`
- Why it matters:
  this family now makes `avatar rehearsal and intervention`
  explicit, spanning full emulators, preview harnesses, repair suites, and
  pose-session OSC companions.

### 68. `VRChat avatar text, speech, translation, and viseme sidecars`

- Main entries:
  `TTS-Voice-Wizard`, `kikitan-translator`, `HeadTTS`, `Billboard`
- Why it matters:
  this family now captures the avatar-facing speech stack more honestly across
  operator speech hubs, overlay-backed translation shells, viseme-aware engines,
  and avatar-visible speech surfaces.

### 69. `VRChat shader ecosystems, material translators, and visual-safety shaders`

- Main entries:
  `PoiyomiToonShader`, `lilToon`, `Mochies-Unity-Shaders`,
  `lilToonToPoiyomiToon`, `EpilepsyProtection`
- Why it matters:
  this family now captures the avatar visual tooling branch: shader editor
  ecosystems, material migration, shader-pack includes, and accessibility
  filters. A future deeper pass should isolate shader inspector UX, generated
  variants, material validation, and visual comfort safeguards.

### 70. `VRCFury toggle automation, avatar animator DSLs, and editor QoL overlays`

- Main entries:
  `VRCFury`, `wk-vrcfury-qol`, `VRCToggleToolkit`,
  `animator-as-code-vrchat`, `vrchat-quick-toggle-vrcfury`
- Why it matters:
  this family now captures avatar feature automation around build-time
  builders, public APIs, reflection-backed editor overlays, clone preview,
  toggle generators, and code-first animator behavior authoring.

### 71. `VRCFaceTracking core, modules, templates, and blendshape preparation`

- Main entries:
  `VRCFaceTracking`, `VRCFaceTracking.Avalonia`, `VRCFT-Babble`,
  `VRCFaceTracking-MeowFace`, `VRCFaceTracking-blender-plugin`
- Why it matters:
  this family now makes face tracking a pipeline rather than a hardware list:
  module lifecycle, unified expression state, OSC/UDP/JSON input, cross-platform
  registry shells, and DCC-side avatar shape preparation.

### 72. `VRChat avatar dynamics, PhysBone migration, contact prefabs, and in-game tuning`

- Main entries:
  `PhysBone-to-DynamicBone`, `PhysBonesTK`, `VRChat_PhysboneDetach`,
  `Avatar-Prop`, `Collision-Detection`
- Why it matters:
  this family now captures avatar physical interaction as a practical branch:
  migration tools, in-game tuning menus, component grouping, grabbable props,
  and compact contact/collision state prefabs.

### 73. `VRChat companion apps, OSC routers, plugin senders, data hubs, and web debug surfaces`

- Main entries:
  `VRCX`, `VOR`, `VRCOSCGUI`, `VRCOSCDataHub`, `VRCOSCWeb`
- Why it matters:
  this family now captures the external VRChat utility layer: companion state,
  overlay feeds, OSC routing, plugin-owned send requests, local data hubs, and
  browser-based avatar parameter controls. A future deeper pass should compare
  overlay feed ergonomics, route debug UX, and browser-vs-desktop companion
  tradeoffs.

### 74. `SlimeVR server, tracker firmware, adapters, and calibration ecosystem`

- Main entries:
  `SlimeVR-Server`, `SlimeVR-Tracker-ESP`, `slimevr-wrangler`, `moslime`,
  `SlimeTora`
- Why it matters:
  this family now captures SlimeVR as a full tracker ecosystem: firmware
  telemetry, server hubs, skeleton calibration, runtime bridges, consumer
  controller adapters, BLE bridges, guided hardware onboarding, and per-tracker
  diagnostics. A future deeper pass should isolate calibration UX and compare
  adapter health-state models.

### 75. `bHaptics SDKs, OSC bridges, relays, and telemetry-to-haptic adapters`

- Main entries:
  `haptic-library`, `tact-js`, `tact-python`, `bHapticsOSC`, `bHapticsRelay`
- Why it matters:
  this family now captures haptics as a reusable output channel across native,
  browser, Python, avatar OSC, log-tail, and WebSocket command surfaces. A
  future deeper pass should compare generic haptics relays with telemetry,
  accessibility, and simulator sidecar patterns.

### 76. `No-HMD and virtual-HMD OpenVR helpers, phone bridges, and controllable driver stubs`

- Main entries:
  `PhoneVR`, `driver_hmd`, `faceless`, `OpenVRsim`, `Pepper`
- Why it matters:
  this family now captures headsetless development and virtual-device
  workflows: phone-HMD streaming, desktop/null display components, fake head
  pose from controllers or trackers, socket-controlled virtual devices, and
  keyboard/mouse fake rigs. A future deeper pass should consolidate these into
  a minimum viable fake-device anatomy guide.

### 77. `WebXR browser API samples, input profiles, emulators, polyfills, and React/Three XR wrappers`

- Main entries:
  `webxr-samples`, `webxr-input-profiles`, `immersive-web-emulator`,
  `webxr-polyfill`, `xr`
- Why it matters:
  this family now captures browser-native XR as a utility substrate: session
  shells, controller-profile registries, devtool-style emulator injection,
  deprecated polyfill history, and framework stores. A future deeper pass
  should compare browser utility ergonomics against native overlay and OpenXR
  helper approaches.

### 78. `Unity XR interaction/workflow toolkits, scientific rigs, training graphs, and Tilia composition`

- Main entries:
  `MixedRealityToolkit-Unity`, `ExPresS-XR`, `VR-Builder`, `VRTK`
- Why it matters:
  this family now captures Unity toolkit design as reusable interaction and
  workflow substrate: spatial UI state machines, scientific data capture,
  training graphs, editor validation, and prefab-composed package ecosystems.
  A future deeper pass should isolate menu/keyboard/accessibility and guided
  setup flows if a Unity utility prototype starts.

### 79. `Meta Quest MR camera, depth, spatial-anchor, presence, and motif samples`

- Main entries:
  `Unity-PassthroughCameraApiSamples`, `Unity-DepthAPI`,
  `Unity-SharedSpatialAnchors`, `Unity-Discover`, `Unity-MRMotifs`
- Why it matters:
  this family now captures Quest MR feature implementation around camera
  access, depth occlusion, shared anchors, room alignment, full-app structure,
  and product motifs. A future deeper pass should synthesize a camera-depth-
  anchor diagnostics plan before any MR prototype work.

### 80. `Linux spatial desktop, Stardust workspace clients, and desktop-to-XR helpers`

- Main entries:
  `Simula`, `flatland`, `kiara`, `protostar`, `magnetar`,
  `picom-xrdesktop-companion`
- Why it matters:
  this family now captures desktop-in-XR as multiple architectures: full
  shells, panel bridges, virtual monitors, app launchers, workspace cells, and
  compositor-assisted mirroring. A future deeper pass should compare input
  injection and workspace grouping against WayVR and earlier desktop-overlay
  families.

### 81. `Godot XR engine toolkits, templates, backends, and vendor extension stacks`

- Main entries:
  `godot-xr-tools`, `godot-xr-template`, `godot_openxr_for_godot_3.x`,
  `godot_openxr_vendors`, `godot_openvr`, `godot_oculus_mobile`
- Why it matters:
  this family now captures Godot as a compact XR utility substrate: reusable
  scene/function modules, action-map templates, OpenXR/OpenVR backend anatomy,
  vendor extension packaging, export feature gates, and deprecated mobile
  bridge migration lessons. A future deeper pass should build a vendor-feature
  matrix and compare Godot interaction modules against Unity, Unreal, and
  WebXR toolkits.

### 82. `A-Frame WebXR components, inspectors, networked scenes, and hand UI`

- Main entries:
  `aframe`, `aframe-inspector`, `aframe-extras`, `networked-aframe`,
  `superframe`, `aframe-hand-tracking-controls-extras`
- Why it matters:
  this family now captures browser XR above raw WebXR APIs: declarative
  components, visual scene inspection, locomotion packs, schema-driven
  networking, in-VR diagnostics, and hand-joint widgets. A future deeper pass
  should compare browser utility ergonomics with native overlay and engine-side
  toolkit approaches.

### 83. `Unreal VR interaction toolkits, hand tracking, comfort, and tracker plugins`

- Main entries:
  `VRExpansionPlugin`, `RunebergVRPlugin`, `MixedReality-UXTools-Unreal`,
  `VrTunnellingPro-UE4`, `FSOpenXRHandTracking`,
  `UE4OpenXRViveTrackerPlugin`, `ue5-xrcore`
- Why it matters:
  this family now captures Unreal plugin-side XR utility architecture:
  replicated grips, compact Blueprint/C++ components, MR UX primitives,
  comfort tunnelling, OpenXR hand tracking, tracker role mapping, and
  multiplayer interaction helpers. A future deeper pass should isolate the
  near/far UI primitive matrix and replicated grip authority model.

### 84. `VR teleoperation headset frontends, robot bridges, and data capture`

- Main entries:
  `kbot_vr_teleop`, `xarm_vr_teleop`, `collab-sim`, `franka-vr-teleop`,
  `VR_Teleop_Interface`, `cambot`, `UR_VR_Teleop`
- Why it matters:
  this family now captures VR as an operator/control surface: headset
  frontends, pose/control transports, IK/MPC loops, robot/simulation command
  relays, safety gates, visualizers, and synchronized data capture. A future
  deeper pass should extract a generic teleop/control-surface blueprint without
  turning `VR-apps-lab` into a robot-control repository.

### 85. `ALVR/WiVRn ecosystem sidecars, platform clients, and streaming helpers`

- Main entries:
  `alvr-visionos`, `Monado-ALVR`, `VRCFT-ALVR`, `ADBForwarder`,
  `WiVRnTimings`
- Why it matters:
  this family now captures the companion-tool layer around streaming stacks:
  platform client shells, runtime bridge references, face/eye payload adapters,
  setup repair helpers, and timing viewers. A future deeper pass should compare
  standalone headset client boundaries and setup-doctor ergonomics rather than
  restudying mainline `ALVR` or `WiVRn`.

### 86. `XR glasses WebHID, virtual displays, and head-tracked desktop helpers`

- Main entries:
  `xreal-webxr`, `nreal_linux_test`, `Nreal_Air_Desktop_tool`,
  `real_utilities`, `XReal-Ultrawide`
- Why it matters:
  this family now captures XR-glasses utility slices around WebHID protocol
  probing, native protocol utilities, screen capture/cropping POCs, and
  virtual-display plus IMU viewport apps. A future deeper pass should compare
  head-tracked display helpers across macOS, Linux, browser, and driver-backed
  approaches.

### 87. `MediaPipe camera tracking bridges for SlimeVR, VRChat, VRM, and virtual controllers`

- Main entries:
  `SlimeVR-Tracker-Mediapipe`, `MediapipeFaceTracking_VRC`,
  `mediapipe-vrm-tracking`, `VRBodyTrack`, `mediapipe_VR_controller`
- Why it matters:
  this family now captures camera tracking as bridge architecture rather than
  production tracking quality: landmarks, axes, quaternions, blendshapes,
  smoothing, calibration, UDP/OSC/pipe/browser output, and target schema
  caveats. A future deeper pass should synthesize calibration and payload
  schemas across SlimeVR, VMT, VRChat OSC, Unity, and browser VRM.

### 88. `Mixed reality capture, calibration, and presenter compositing helpers`

- Main entries:
  `reality-mixer-js`, `RealityMixerVisionPro`, `mrc-client`,
  `MixedRealityCapture`, `MrcXrtHelpers`, `ArtificialGreenScreen`
- Why it matters:
  this family now captures MRC as reusable utility architecture: calibration
  schema, camera pose, foreground/background rendering, chroma or segmentation,
  video payload parsing, encoder/decoder boundaries, and external camera
  repair helpers. A future deeper pass should build a capture/compositing
  method matrix before any presenter-tool prototype work.

### 89. `VR treadmill locomotion hardware, input adapters, and virtual controller bridges`

- Main entries:
  `VR-Treadmill`, `vr-treadmill`, `slimstep_vr`, `GoobleBoxVR`, `tacovr`,
  `kittywalk-server`, `VR-treadmill-client-app`,
  `VR-treadmill-server-app`
- Why it matters:
  this family now captures locomotion hardware as bridge architecture: raw
  sensor capture, state classification, keyboard or virtual gamepad output,
  OpenVR scalar input components, BLE/serial/TCP command surfaces, and driver
  readiness. A future deeper pass should extract a hardware-input bridge
  checklist only if locomotion or accessibility hardware becomes active.

### 90. `Unity VR experiment frameworks, data capture, and study orchestration helpers`

- Main entries:
  `unity-experiment-framework`, `TUX`, `Unity-Experiment-Trial-Manager`,
  `PsyWueVR`, `VR_Motion_Tracker`, `vr_experiment_framework_v3`,
  `uxf-s3-uploader`, `uxf-web-settings`
- Why it matters:
  this family now captures repeatable VR utility infrastructure: session,
  block, trial, tracker, data handler, settings, remote configuration,
  fallback, upload, and resume. A future deeper pass should extract a compact
  session/trial/tracker blueprint for diagnostics and calibration utilities.

### 91. `Immersive browser shells, WebXR runtimes, home spaces, and spatial web frontends`

- Main entries:
  `wolvic`, `FirefoxReality`, `FirefoxRealityPC`, `exokit`,
  `exokit-browser`, `exokit-frontend`, `home-space`
- Why it matters:
  this family now captures browser-in-VR shell architecture: session stores,
  windows, widgets, native render worlds, WebXR interstitials, environments,
  runtime shims, and spatial homes. A future deeper pass should build a
  boundary matrix instead of trying to restudy huge browser codebases.

### 92. `Browser-native WebXR utility surfaces, creative tools, diagnostics, and data visualization`

- Main entries:
  `a-painter`, `LeapShape`, `spatial-photo-webxr-viewer`,
  `vr-screen-tester`, `vr-visualizer-web`, `OpenBCI-WebXR-EEG`,
  `prediction-space`, `taplive-webxr`
- Why it matters:
  this family now captures WebXR as a compact utility surface substrate:
  controller-aware creative tools, palm menus, local-first stereo media,
  screen diagnostics, audio/biometric visualizers, gaze/pinch dashboards, and
  streaming viewer product framing. A future deeper pass should compare these
  with native overlay menu and dashboard patterns.

### 93. `Quest app sideloading, modding, version management, and store metadata tooling`

- Main entries:
  `SideQuest`, `SideQuestAppLauncher`, `QuestPatcher`, `QuestPatcher.QMod`,
  `QuestAppVersionSwitcher`, `OculusDB`
- Why it matters:
  this family now captures Quest companion utility architecture rather than
  one specific app: managed ADB/platform-tools bootstrap, sideloading,
  launcher/updater UI, APK manifest patching, mod package schemas,
  backup/version metadata, and store metadata indexing. A future deeper pass
  should build a safety checklist for ADB, patching, backup/restore, and
  metadata support boundaries before any prototype work.

### 94. `VMC/VRM motion-capture protocol, OSC transform receivers, and recording/export tools`

- Main entries:
  `VirtualMotionCapture`, `VirtualMotionCaptureProtocol`,
  `EasyVirtualMotionCaptureForUnity`, `QuestOSCTransformSender`, `vmc2bvh`,
  `vmcrec`
- Why it matters:
  this family now captures VMC as a reusable pose-stream layer: OSC role/port
  conventions, root/bone/tracker/HMD/controller/blendshape messages, Unity
  receiver controls, Quest transform sending, packet validation, recording,
  replay, and BVH export. A future deeper pass should compare VMC, SlimeVR,
  VMT, VRChat OSC, MediaPipe, and OpenVR tracker export schemas.

### 95. `Resonite/Neos modding, headless, external SDK, and social utility tooling`

- Main entries:
  `ResoniteModLoader`, `Resolute`, `resonite-mod-manifest`,
  `ResoniteLink`, `resonite-headless`, `ReCon`, `ResoniteMetricsCounter`
- Why it matters:
  this family now captures social VR ecosystem tooling: loader lifecycle,
  schema-first manifests, GUI manager state, external WebSocket SDKs, headless
  deployment, companion auth/hub clients, and in-world metrics. A future
  deeper pass should compare mod/package schemas across Resonite, Quest QMOD,
  VRChat creator tooling, and any future `VR-apps-lab` package format.

### 96. `DIY open-source headset hardware bring-up, drivers, PCBs, and controller firmware`

- Main entries:
  `Relativty`, `HadesVR`, `Wand-Controller`, `Basic-HMD-PCB`,
  `HadesVR_GUI_Tool`, `DIY_VR_Controllers`, `DietzVR`
- Why it matters:
  this family now captures hardware bring-up discipline: firmware packet
  contracts, HID/UART/RF transport, OpenVR HMD display components, display
  settings, controller/tracker input components, IMU filtering, calibration,
  PCB/BOM/Gerber/STL assets, and settings GUI tooling. A future deeper pass
  should extract a compact OpenVR HMD bring-up anatomy and transport
  diagnostics checklist if hardware-support work becomes active.

### 97. `VR keyboard, text-entry, avatar keyboard, and OSC input surfaces`

- Main entries:
  `react-360-keyboard`, `vr-keyboard`, `VRKeyboard`, `VR_Keyboard`,
  `VRC-KeyboardController-in-VR_OSC`, `KillFrenzyVRCAvatarKeyboard`
- Why it matters:
  this family now captures text entry as a reusable utility surface:
  promise-returning modal keyboards, canvas/raycast keyboard layouts,
  fingertip push-depth keys, native OpenVR keyboard bridges, script-host
  fallback routing, VRChat OSC input emitters, and deprecated avatar-contained
  keyboard caveats. A future deeper pass should compare keyboard service
  boundaries against dashboard/menu input needs.

### 98. `VR subtitles, captions, STT/OCR accessibility, and projection-aware subtitle tooling`

- Main entries:
  `vr-subtitles`, `VR-Subtitles-WIP`, `VR_SUBTITLES_BURNERRR`,
  `VR-Subtitles-in-Unreal-5`, `WebVR-Captioning`, `STTS`
- Why it matters:
  this family now captures accessibility and communication surfaces:
  subtitle queues, speaker/FOV placement, wait-for-input dialogue, stereo-360
  subtitle burn-in, screenshot-to-caption WebXR loops, STT/translation overlay
  histories, OCR controls, and VRChat OSC chatbox bridges. A future deeper pass
  should build a subtitle/caption placement matrix and an OCR/STT overlay
  pipeline comparison.

### 99. `SteamVR operational support, startup automation, dynamic performance, and Linux driver helpers`

- Main entries:
  `OpenVRStartup`, `OpenVR-Dynamic-Resolution`, `steam-devices`,
  `VivePro2-Linux-Driver`
- Why it matters:
  this family now captures the support layer around runtime use: manifests,
  autolaunch, quit-event cleanup, performance feedback loops, SteamVR settings
  writes, Linux device permissions, proxy drivers, typed properties/settings,
  and HID config/control. A future deeper pass should extract a SteamVR
  operational-support checklist before building any setup/doctor utility.

### 100. `Focused overlay micro-surfaces, situational HUDs, and OCR-assisted workflow panels`

- Main entries:
  `AdressableOverlaySteamVR`, `VRCOSCAvatarScaleOverlay`, `VR-QR-Overlay`,
  `OVR-Deck`, `VR-Music-Remote`, `EchoVR-Overlay`, `ez-wishlist-overlay`
- Why it matters:
  this family now captures small overlays as first-class product references:
  Unity dashboard overlays, mirror-texture QR/OCR recognition, window-captured
  media HUDs, browser telemetry overlays, VRChat OSC dashboard panels, and
  persistent OCR-assisted checklist/workflow surfaces. A future deeper pass
  should extract a reusable overlay micro-surface checklist and consider an
  `ez-wishlist-overlay` reuse plan if OCR panels become active.

### 101. `Audience chat overlays, stream-facing browser surfaces, and captured-window HUD patterns`

- Main entries:
  `Transparent-Twitch-Chat-Overlay`, `ghost-chat`, `jChat`, `showmy.chat`,
  `twitch_chat_emotes`
- Why it matters:
  this family captures chat and audience overlays as reusable captured-window
  and browser-source patterns: setup/live overlay mode, click-through/vanish
  behavior, provider fan-in, URL configuration, live preview, emote rendering,
  and animation bounds. A future deeper pass should compare these with native
  VR dashboard chat and notification surfaces.

### 102. `VR creative authoring, drawing/modeling tools, and in-headset tool/menu systems`

- Main entries:
  `tilt-brush`, `open-brush`, `blocks`, `SideSketch`, `vartiste`
- Why it matters:
  this family captures complex VR tool UX: app-state lifecycles, brush and
  asset catalogs, panels, WebXR shelves, command/proto histories, exports,
  scripting APIs, multiplayer, and fork-lineage caveats. A future deeper pass
  should build a menu/tool/shelf comparison matrix across Unity and WebXR
  creative tools.

### 103. `Networked/social XR frameworks, room clients, and multi-user state substrates`

- Main entries:
  `ubiq`, `hubs`, `janusweb`, `vrsys-core`
- Why it matters:
  this family captures collaboration substrates: room servers, room clients,
  peer events, presence, permissions, networked ECS/component state,
  declarative spatial-web embeds, and Unity prefab/package composition. A
  future deeper pass should extract a small room/presence/permission checklist
  for collaborative diagnostics and remote support utilities.

### 104. `OpenGloves sidecars, protocols, named-pipe input, OSC ingress, and force-feedback adapters`

- Main entries:
  `opengloves-ui`, `opengloves-protocol`, `pygloves`, `opengloves-lib`,
  `CS-OpenGloves-Named-Pipe-Input-Library`, `opengloves-osc`,
  `opengloves-force-feedback-unity-demo`, `opengloves-hl-alyx-integration`
- Why it matters:
  this family captures custom hand-device integration as a stack: calibration
  sidecars, protobuf contracts, named-pipe structs, OSC ingress, alpha serial
  encoding, synthetic test harnesses, Unity FFB, and game-log sidecars. A
  future deeper pass should build an OpenGloves transport/version matrix before
  any reuse.

### 105. `WebXR engine export bridges, device-display adapters, layers, and test/showcase scaffolds`

- Main entries:
  `unity-webxr-export`, `Simple-WebXR-Unity`, `looking-glass-webxr`,
  `webxr-layers-polyfill`, `webxr-test-api`, `webxr-showcases`
- Why it matters:
  this family captures WebXR infrastructure rather than one content app:
  engine export settings, tiny bridges, display adapters, layer shims,
  fake-device testing, and complete feature-gated showcase flows. A future
  deeper pass should build a WebXR feature/support matrix and compare it with
  native OpenXR/OpenVR fake-device and overlay workflows.

### 106. `Browser-based XR editors, live-coding sandboxes, visual workspaces, and scene tooling`

- Main entries:
  `playcanvas/editor`, `nunuStudio`, `triplex`, `RiftSketch`, `remixvr`,
  `troika`
- Why it matters:
  this family captures editor-like foundations that many VR utilities need:
  method buses, observable history, asset paths, project files, source-code
  scene metadata, in-VR live code, template publishing, and readable 3D text/UI.
  A future deeper pass should create an editor-boundary matrix and a 3D
  readability checklist.

### 107. `VRM/avatar web stacks, model specs, runtime loaders, and browser avatar/mocap surfaces`

- Main entries:
  `UniVRM`, `three-vrm`, `aframe-vrm`, `SystemAnimatorOnline`,
  `vrm-specification`
- Why it matters:
  this family captures avatar runtime contracts across Unity, browser, A-Frame,
  and specs: humanoid, expressions, first-person, look-at, spring bones,
  constraints, metadata, and mocap surfaces. A future deeper pass should build
  a VRM capability matrix against VMC, MediaPipe, VRChat OSC, and face-tracking
  references.

### 108. `WebAR marker/image tracking, model-viewer AR surfaces, and lightweight scene-understanding utilities`

- Main entries:
  `mind-ar-js`, `AR.js`, `Simple-AR`, `aframe-ar`, `model-viewer`, `enva-xr`
- Why it matters:
  this family captures browser AR placement and scene understanding:
  target compilation, marker/image/face/location tracking, A-Frame wrappers,
  production AR fallback UX, hotspots, hit-test, planes, anchors, light, depth,
  and debug surfaces. A future deeper pass should build a browser AR placement
  matrix before any MR utility prototype.

### 109. `WebXR hand tracking, hand input surfaces, and hand-data bridges`

- Main entries:
  `webxr-handtracking`, `webxr-hand-tracking-sample`,
  `webxr-hand-tracking-websocket`, `webxr-quest2`
- Why it matters:
  this family captures hand input as a reusable utility-control layer: joint
  caches, pinch hysteresis, fingertip raycasters, per-hand role assignment,
  passthrough hand-grab demos, and WebSocket hand-pose export. A future deeper
  pass should compare WebXR hand thresholds and event vocabularies across
  A-Frame, Babylon, PlayCanvas, and lower-level browser samples.

### 110. `Immersive 360 video players, stereo projection, and local media surfaces`

- Main entries:
  `webxr-video`, `VR180-video-player`, `html-360-viewer`,
  `360-video-player`, `openimmersive`
- Why it matters:
  this family captures media surface mechanics that matter for utility shells:
  projection/layout controls, stereo modes, local file ingress, drag/drop,
  browser-to-XR UI textures, native gallery/source pickers, HLS sources, and
  explicit field-of-view/baseline/disparity controls. A future deeper pass
  should build a projection and media-source matrix before any reusable VR
  viewer component.

### 111. `Audio-reactive WebXR surfaces, spatial sound visualizers, and shader pipelines`

- Main entries:
  `webxr-audio-visualizer`, `vite-three-webxr-audio-visualizer`,
  `boondoggle`, `seeSound`
- Why it matters:
  this family captures audio as live XR data: microphone analysers, stereo
  channel splitting, FFT/amplitude/centroid feature vectors, shader uniforms,
  native loopback capture, audio textures, and JSON-defined effect packages. A
  future deeper pass should turn these into an audio-reactive diagnostics and
  ambience checklist.

### 112. `WebXR runtime frameworks, session/input feature managers, and testable spatial UI substrates`

- Main entries:
  `three.js`, `Babylon.js`, `playcanvas/engine`, `immersive-web-sdk`
- Why it matters:
  this family captures the architectural substrate below browser VR utilities:
  renderer-owned session managers, controller/grip/hand scene groups, modular
  feature managers, evented XR services, DOM overlay roots, synthetic input,
  runtime session state, and scene-inspection tooling. A future deeper pass
  should compare framework boundaries before choosing a browser utility shell
  baseline.

### 113. `A-Frame GUI, locomotion, and reusable interaction component primitives`

- Main entries:
  `aframe-gui`, `aframe-teleport-controls`,
  `aframe-super-hands-component`, `AUXL`,
  `aframe-webxr-ui-toolkit`
- Why it matters:
  this family captures reusable browser VR controls below a full app:
  declarative widgets, flex-like panels, teleport rays, semantic grab/drop
  events, menu factories, lifecycle cleanup, and hand pressables. A future
  deeper pass should build a small A-Frame utility menu kit comparison and
  decide which interaction vocabulary is easiest to reuse.

### 114. `Immersive analytics, spatial data visualization, and scientific viewer substrates`

- Main entries:
  `vria`, `3d-force-graph-vr`, `aframe-forcegraph-component`, `molstar`,
  `ipyvolume`
- Why it matters:
  this family captures data-rich utility surfaces: visualization grammars,
  spatial views, graph accessors, raycaster events, scientific viewer
  snapshots, XR input mapping, notebook trait sync, and volume texture tiling.
  A future deeper pass should turn these into a diagnostics visualization
  grammar and snapshot/replay checklist.

### 115. `WebRTC remote rendering, WebXR streaming, and bidirectional input/control channels`

- Main entries:
  `VRStreaming`, `UnityRenderStreaming`, `com.unity.webrtc`,
  `PixelStreamingInfrastructure`, `Unreal-Pixel-Streaming`
- Why it matters:
  this family captures thin-client VR architectures: streamed video, signaling,
  data channels, input remoting, WebXR pose/gamepad messages, selective
  projection updates, and matchmaker/deployment shells. A future deeper pass
  should produce a remote VR protocol matrix before any streamed utility
  prototype.

### 116. `Social/world framework shells, scene schemas, and multi-user spatial app substrates`

- Main entries:
  `ATON`, `circlesxr`, `arena-web-core`, `Basis`, `webaverse`
- Why it matters:
  this family captures collaborative utility foundations: scene JSON,
  semantic graphs, Networked-AFrame ownership, MQTT/Jitsi media, text prompts,
  WebRTC positional audio, headless avatar clients, compressed pose packets,
  and app-runtime modules. A future deeper pass should define a shared VR
  diagnostics room architecture.

### 117. `Glanceable telemetry, simulator panels, and situational VR micro-overlays`

- Main entries:
  `turncountervr`, `vive-wireless-info-overlay`, `gpu-vram-monitor`,
  `RacingManager`, `vr-twitch-chat-ui`
- Why it matters:
  this family captures tiny high-value utility surfaces: pose-derived comfort
  counters, wireless temperature status, GPU/VRAM telemetry, simulator
  shared-memory panels, and VR-aware chat readability. A future deeper pass
  should turn these into a `glanceable status surface` checklist.

### 118. `Protocol-driven overlay bridges, external overlay hosts, and minimal implementation baselines`

- Main entries:
  `GOpy`, `BD-XSOverlay-notify`, `VRC-NexusChat`,
  `zenn-overlay-tutorial`, `EmyOverlay`, `VROverlayTest`
- Why it matters:
  this family captures the boundary between event producers, bridge protocols,
  overlay hosts, and render baselines. A future deeper pass should produce an
  overlay-host protocol matrix before new notification or OSC overlay work.

### 119. `Virtual displays, spatial-display OpenXR runtimes, and desktop fallback surfaces`

- Main entries:
  `Linux-Virtual-Display-Driver`, `openxr-3d-display`, `SbsImageViewer`,
  `VR-Display`, `Virtual-Desktop-VR`, `GodotXRDesktop`
- Why it matters:
  this family captures display targets as a reusable platform problem:
  OS-level virtual monitors, spatial-display OpenXR runtimes, stereo media
  surfaces, historical display hardware concepts, and no-HMD synthetic tracker
  injection. A future deeper pass should build a display-surface taxonomy.

### 120. `Hand tracking, simulated XR hands, and reusable hand/control primitives`

- Main entries:
  `openxrhands`, `AutoHandSimulator`, `RoboHands-UnityXR`, `ExPresS-XR`
- Why it matters:
  this family captures hand/control work across extension-level data, no-HMD
  simulation, gesture-pose vocabulary, and toolkit primitives. A future deeper
  pass should compare Unity, Godot, WebXR, and virtual-driver no-HMD hand
  workflows.

### 121. `OpenXR/VRCFT eye-face modules, calibration clients, and avatar facetracking preparation`

- Main entries:
  `VRCFaceTracking-QuestProOpenXR`, `VRCFT-ALXR-Modules`,
  `VRC-Facetracking`, `PSVR2EyeTrackingCalibration`
- Why it matters:
  this family captures the bridge from vendor face/eye tracking into avatar
  expression systems: runtime switching and restore, local versus remote
  tracking ingress, extension selection, expression filters, avatar threshold
  editors, stale OSC config cleanup, and persistent eye-gaze calibration.
  A future deeper pass should compare safe runtime switching, calibration UX,
  and avatar-side setup hygiene across the broader VRCFT ecosystem.

### 122. `VRChat chatbox, speech/TTS, AI companions, and text-composition sidecars`

- Main entries:
  `NOVA-AI`, `vrc-tts-osc`, `XOSC`, `advosc`
- Why it matters:
  this family captures text as a utility surface: AI tool-calling sidecars,
  memory, screenshots, TTS and virtual-audio microphone routing, compact
  telemetry strings, placeholder engines, block editors, and typed OSC
  forwarding. A future deeper pass should build a chatbox composition matrix
  that separates text source, formatting, pacing, audio output, and OSC
  address routing.

### 123. `VRChat OSC telemetry, avatar scaling, device status, and parameter-control helpers`

- Main entries:
  `vrcwatch.rs`, `vrc-avi-scaler`, `Camera-System`
- Why it matters:
  this family captures avatar-facing OSC as both display and control channel:
  time or moon telemetry, validated OSC addresses, world-aware avatar scaling,
  compatibility shims, smooth parameter interpolation, and avatar-authored
  camera/path companion protocols. A future deeper pass should define safety
  patterns for external avatar-parameter writers.

### 124. `Haptic/physical-output routers and wearable feedback bridges`

- Main entries:
  `HapticPatPat`, `owoskin-vrc`, `intiface-game-haptics-router`
- Why it matters:
  this family captures physical-output routing from avatar contacts, wearable
  effect engines, Bluetooth microcontrollers, OSCQuery endpoints, muscle maps,
  controller rumble capture, IPC envelopes, visualizers, and device hubs. A
  future deeper pass should produce a device-neutral event schema and compare
  non-invasive OSC/event ingress against process-hooked rumble sources.

### 125. `Foveated rendering, quad-view settings, and graphics-layer adaptation helpers`

- Main entries:
  `QuadViewsCompanion`, `PimaxMagic4All`, `openvr_foveated`,
  `Varjo-Foveated`, `ViveFoveatedRendering`
- Why it matters:
  this family captures the risk spectrum from safe settings companions to
  invasive OpenVR/OpenXR/native rendering hooks. A future deeper pass should
  build a rendering-adaptation matrix that separates settings UX, API-layer
  view-chain edits, DLL replacement wrappers, vendor SDK emulation, and
  engine-native VRS plugins.

### 126. `OSCQuery VRChat discovery libraries and client primitives`

- Main entries:
  `VrcAdvert`, `vrchat_osc`, `OscQueryLibrary`, `oyasumivr_oscquery`,
  `vrchat_oscquery`
- Why it matters:
  this family captures reusable OSCQuery plumbing across C#, Rust, Python, and
  sidecar patterns. A future deeper pass should produce a discovery matrix that
  compares mDNS behavior, direct-address fallbacks, avatar parameter fetch,
  service lifecycle, and Quest/LAN/VPN caveats.

### 127. `Resonite creator import/export, inspection, and screenshot utility helpers`

- Main entries:
  `Resonite.UnitySDK`, `ResoniteUnityExporter`,
  `ResoniteUnityPackagesImporter`, `CherryPick`,
  `ResoniteScreenshotExtensions`
- Why it matters:
  this family captures creator pipeline patterns beyond mod loading: generated
  data-model bindings, converter registries, shared DTO and IPC import
  processors, package extraction caches, component search palettes, and
  screenshot metadata round-trips. A future deeper pass should compare these
  with VRChat creator/import tooling.

### 128. `External pose, object, and sensor data to VRChat OSC bridges`

- Main entries:
  `VRC-Tracked-Objects`, `VRChatOSCOptitrack`, `VRChat-MotionOSC`,
  `quest_steamvr_fbt_tool`, `vrc_osc_tracker`
- Why it matters:
  this family captures pose ingress through avatar parameters and OSC tracker
  endpoints. A future deeper pass should compare avatar-relative,
  playspace-relative, camera-relative, and device-relative calibration models
  across OpenVR, NatNet, MediaPipe, VMC, VMT, and SlimeVR-style bridges.

## Recommended next move

If `VR-apps-lab` continues this research, the next most valuable deep-pass order is:

1. `Overlay implementation references and overlay-first hosts`
2. `OpenXR capability-injection, passthrough extension, and runtime-side intervention tooling`
3. `Vision-based hand and body tracking bridges`
4. `Virtual display and repurposed output workflows`
5. `OpenVR capture, replay, and orchestration toolchains`
6. `WayVR ecosystem and Linux overlay surfaces`
7. `PSVR2-specific OpenXR eye-tracking and calibration follow-up`
8. `Browser panoramic video players and projection-aware web playback`
9. `Creator-side synced video player frameworks and queue frontends`
10. `Engine-side stereo panoramic viewers and vendor playback samples`
11. `Transformed, volumetric, and nonstandard 3D video viewers`
12. `Historical utility-suite recovery`
13. `Validation and workflow micro-utilities`
14. `Biometric, neurofeedback, and accessory-control bridges`
15. `VRChat world-authoring toolkits and optimization helpers`
16. `VRChat world runtime infrastructure and per-player state helpers`
17. `VRChat camera, staging, and admin-control systems`
18. `VRChat interaction prefabs and utility UI`
19. `VRChat text workflow refinements and TTS follow-up`
20. `Avatar-facing OSC companion frameworks and automation relays`
21. `XR glasses workspace shells and head-tracked screen tools`
22. `Wearable haptics and avatar-driven feedback systems`
23. `Simulation telemetry overlays and motion-cueing sidecars`
24. `Microphone control, voice-input, and audio routing helpers`
25. `Immersive media playback and browser video shells`
26. `Spatial audio SDKs, renderers, and audio-object optimization`
27. `Creator-facing audio systems and world voice management`
28. `VRChat world persistence, inventory, and external-data bridges`
29. `VRChat creator diagnostics, editor inspection, profiling, and static analysis`
30. `VRChat embodied interaction, custom movement, and physical world mechanics`
31. `Udon data-structure libraries, serialization helpers, and creator utility foundations`
32. `VRChat creator starter baselines, test harnesses, and language-boundary experiments`
33. `Udon encoding, token, query, and structured-data micro-libraries`
34. `Udon sync, events, runtime logging, and shared helper micro-frameworks`
35. `VRChat world control gadgets, environmental systems, and specialized operator surfaces`
36. `VRChat avatar setup, optimization, and Quest portability`
37. `VRChat avatar composition, packaging, and install automation`
38. `VRChat avatar emulation, gesture preview, repair, and OSC-assisted posing`
39. `VRChat avatar text, speech, translation, and viseme sidecars`
40. `VRChat shader ecosystems, material translators, and visual-safety shaders`
41. `VRCFury toggle automation, avatar animator DSLs, and editor QoL overlays`
42. `VRCFaceTracking core, modules, templates, and blendshape preparation`
43. `VRChat avatar dynamics, PhysBone migration, contact prefabs, and in-game tuning`
44. `VRChat companion apps, OSC routers, plugin senders, data hubs, and web debug surfaces`
45. `SlimeVR server, tracker firmware, adapters, and calibration ecosystem`
46. `bHaptics SDKs, OSC bridges, relays, and telemetry-to-haptic adapters`
47. `No-HMD and virtual-HMD OpenVR helpers, phone bridges, and controllable driver stubs`
48. `WebXR browser API samples, input profiles, emulators, polyfills, and React/Three XR wrappers`
49. `Unity XR interaction/workflow toolkits, scientific rigs, training graphs, and Tilia composition`
50. `Meta Quest MR camera, depth, spatial-anchor, presence, and motif samples`
51. `Linux spatial desktop, Stardust workspace clients, and desktop-to-XR helpers`
52. `Godot XR engine toolkits, templates, backends, and vendor extension stacks`
53. `A-Frame WebXR components, inspectors, networked scenes, and hand UI`
54. `Unreal VR interaction toolkits, hand tracking, comfort, and tracker plugins`
55. `VR teleoperation headset frontends, robot bridges, and data capture`
56. `ALVR/WiVRn ecosystem sidecars, platform clients, and streaming helpers`
57. `XR glasses WebHID, virtual displays, and head-tracked desktop helpers`
58. `MediaPipe camera tracking bridges for SlimeVR, VRChat, VRM, and virtual controllers`
59. `Mixed reality capture, calibration, and presenter compositing helpers`
60. `VR treadmill locomotion hardware, input adapters, and virtual controller bridges`
61. `Unity VR experiment frameworks, data capture, and study orchestration helpers`
62. `Immersive browser shells, WebXR runtimes, home spaces, and spatial web frontends`
63. `Browser-native WebXR utility surfaces, creative tools, diagnostics, and data visualization`
64. `Quest app sideloading, modding, version management, and store metadata tooling`
65. `VMC/VRM motion-capture protocol, OSC transform receivers, and recording/export tools`
66. `Resonite/Neos modding, headless, external SDK, and social utility tooling`
67. `DIY open-source headset hardware bring-up, drivers, PCBs, and controller firmware`
68. `VR keyboard, text-entry, avatar keyboard, and OSC input surfaces`
69. `VR subtitles, captions, STT/OCR accessibility, and projection-aware subtitle tooling`
70. `SteamVR operational support, startup automation, dynamic performance, and Linux driver helpers`
71. `Focused overlay micro-surfaces, situational HUDs, and OCR-assisted workflow panels`
72. `Audience chat overlays, stream-facing browser surfaces, and captured-window HUD patterns`
73. `VR creative authoring, drawing/modeling tools, and in-headset tool/menu systems`
74. `Networked/social XR frameworks, room clients, and multi-user state substrates`
75. `OpenGloves sidecars, protocols, named-pipe input, OSC ingress, and force-feedback adapters`
76. `WebXR engine export bridges, device-display adapters, layers, and test/showcase scaffolds`
77. `Browser-based XR editors, live-coding sandboxes, visual workspaces, and scene tooling`
78. `VRM/avatar web stacks, model specs, runtime loaders, and browser avatar/mocap surfaces`
79. `WebAR marker/image tracking, model-viewer AR surfaces, and lightweight scene-understanding utilities`
80. `WebXR hand tracking, hand input surfaces, and hand-data bridges`
81. `Immersive 360 video players, stereo projection, and local media surfaces`
82. `Audio-reactive WebXR surfaces, spatial sound visualizers, and shader pipelines`
83. `WebXR runtime frameworks, session/input feature managers, and testable spatial UI substrates`
84. `A-Frame GUI, locomotion, and reusable interaction component primitives`
85. `Immersive analytics, spatial data visualization, and scientific viewer substrates`
86. `WebRTC remote rendering, WebXR streaming, and bidirectional input/control channels`
87. `Social/world framework shells, scene schemas, and multi-user spatial app substrates`
88. `Glanceable telemetry, simulator panels, and situational VR micro-overlays`
89. `Protocol-driven overlay bridges, external overlay hosts, and minimal implementation baselines`
90. `Virtual displays, spatial-display OpenXR runtimes, and desktop fallback surfaces`
91. `Hand tracking, simulated XR hands, and reusable hand/control primitives`
92. `VRCFT/OpenXR face tracking, avatar preparation, and calibration follow-up`
93. `VRChat chatbox template, TTS, AI, and telemetry composition matrix`
94. `Avatar-parameter telemetry, scaling, and companion protocol helpers`
95. `Wearable haptics, physical-output routers, and device-neutral event schemas`
96. `Rendering adaptation: foveation settings companions, API layers, DLL wrappers, and native VRS plugins`
97. `OSCQuery implementation matrix across C#, Rust, Python, sidecars, and direct-address fallbacks`
98. `Resonite creator import/export pipelines, component search UX, and metadata-rich capture artifacts`
99. `External pose/object/sensor ingress to VRChat OSC tracker endpoints and avatar parameters`
100. `Caption pipeline matrix across speech/OCR/translation, OBS, browser overlays, VRChat chatbox, and Unity/audience chat surfaces`
101. `Open Brush/Tilt asset pipeline map across raw .tilt, shader restoration, web viewers, conversion, and collaborative strokes`
102. `Gaussian splat utility matrix across browser editors, static WebXR viewers, Unity runtimes, native plugins, and VFX substrates`
103. `Godot XR function-node and OpenXR vendor feature/export matrices`

For the longer-range family backlog beyond this shorter priority order, use the
`Family-level gaps` section below.
