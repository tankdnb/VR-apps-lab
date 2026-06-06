# Current Focus

- Date: `2026-06-06`
- Purpose: give a short `what matters now` view of `VR-apps-lab` without
  forcing a new session or visitor through the full wave archive.

## What this repository is doing now

`VR-apps-lab` is being maintained as a public:

- `knowledge repository`
- `pattern library`
- `working lab`

for VR utilities, overlays, diagnostics, tracking helpers, runtime tools, and
experimental XR integrations.

The repository is no longer trying to act like one hidden main application.

## Strongest active directions

These are the clearest current product and research lines:

1. `Overlay implementation references and overlay-first utility hosts`
   small and medium overlay surfaces remain one of the strongest donor areas in
   the whole repo, now including thinner access layers and starter variants.
2. `OpenXR runtime, capability-injection layers, diagnostics, and micro-layer utilities`
   the repository now has enough material to support both an `OpenXR doctor /
   runtime inspector` branch and smaller capability, passthrough, and
   operator-facing layer utilities.
3. `Tracker, OSC, and virtual-device tooling`
   `VMT`, OSC exporters, and synthetic-device hosts form a strong reusable
   implementation family.
4. `Mixed-VR bridge patterns`
   controller, hand-tracking, and hardware-interop bridges are now a clear
   comparison line of their own.
5. `OpenVR driver learning paths`
   the repo now contains a stronger baseline for future driver experiments than
   it did earlier.
6. `Accessibility, communication, and companion surfaces`
   small user-value-first tools remain an important public direction, not just
   a side branch.
7. `VR audio, immersive playback, projection-aware video systems, and creator-facing media tools`
   the repository now has a clearer branch for mic-state tools, media-player
   shells, panoramic video donors, nonstandard 3D viewers, spatial-audio
   substrate, and creator-side media frameworks.
8. `VRChat creator-world tooling, bootstrap baselines, runtime substrate, micro-libraries, and physical or world-control mechanics`
   the repository now has a much clearer branch for world-authoring helpers,
   creator bootstrap lineage, runtime substrate, persistence and external-data
   bridges, diagnostics, event-camera systems, reusable utility surfaces, Udon
   protocol micro-libraries, runtime helper frameworks, world-control gadgets,
   and embodied interaction donors.
9. `VRChat avatar toolchains, preview environments, and avatar-facing speech surfaces`
   the repository now has stronger coverage of avatar setup workbenches, Quest
   portability, composition and packaging, preview or repair tools, pose
   companions, and avatar-facing speech or translation sidecars.
10. `VRChat avatar visual tooling, face tracking, and dynamics`
   the repository now has clearer coverage of shader ecosystems, material
   translators, visual-safety shaders, VRCFury automation, face-tracking module
   pipelines, blendshape preparation, PhysBone tuning, and contact-driven
   avatar interaction.
11. `VRChat companion surfaces, tracker ecosystems, haptics, and headsetless development helpers`
   the repository now has clearer coverage of external companion apps, OSC
   routers, browser debug panels, SlimeVR-style tracker stacks, haptic relays,
   and no-HMD or virtual-HMD driver references.
12. `WebXR, Unity XR toolkits, Quest MR samples, and Linux spatial desktop clients`
   the repository now has stronger coverage of browser-native XR sessions,
   controller profiles, WebXR emulators, modern Unity MR toolkits, Quest
   camera/depth/anchor samples, MR motifs, Stardust clients, and Linux
   desktop-in-XR helpers.
13. `Godot XR, A-Frame component systems, Unreal XR plugins, and VR teleoperation control surfaces`
   the repository now has fresh coverage of Godot scene-pack toolkits and
   vendor extension stacks, A-Frame inspectors and networked components,
   Unreal replicated interaction/hand/tracker/comfort plugins, and VR
   teleoperation architectures that use headsets as operator surfaces.
14. `Streaming sidecars, XR-glasses desktop helpers, camera tracking bridges, and mixed-reality capture`
   the repository now has fresh coverage of ALVR/WiVRn ecosystem companions,
   XREAL/Nreal WebHID and head-tracked virtual display utilities,
   MediaPipe-to-tracker/avatar/controller bridges, and MRC calibration or
   presenter-compositing helpers.
15. `Locomotion hardware bridges, VR study harnesses, immersive browser shells, and browser-native WebXR utility surfaces`
   the repository now has fresh coverage of treadmill and balance-board input
   bridges, Unity session/trial/data-capture frameworks, standalone browser
   shell architecture, WebXR runtime shims, hand/palm menu tools, local-first
   stereo media viewers, diagnostics, and VR data dashboards.
16. `VR text entry, captions/OCR, SteamVR operational support, and focused overlay micro-surfaces`
   the repository now has fresh coverage of modal and native keyboard
   surfaces, subtitle/caption/STT/OCR accessibility flows, runtime lifecycle
   and performance-support helpers, Unity dashboard overlays, QR/media/game
   HUD micro-tools, and OCR-assisted workflow panels.
17. `Face/eye tracking modules, chatbox sidecars, avatar OSC controls, and wearable haptics`
   the repository now has fresh coverage of OpenXR/VRCFT expression modules,
   calibration clients, avatar facetracking setup packages, AI/TTS/chatbox
   companions, OSC telemetry and avatar scaling helpers, avatar-authored camera
   paths, and physical-output or wearable haptic routers.
18. `Rendering adaptation, OSCQuery plumbing, Resonite creator workflows, and external pose ingress`
   the repository now has fresh coverage of foveated rendering settings and
   layer/wrapper patterns, VRChat OSCQuery implementation primitives,
   Resonite creator import/export and metadata utilities, and external
   object/mocap/camera/SteamVR tracker data bridges into VRChat OSC.
19. `Caption fan-out, creative asset pipelines, Gaussian splat viewers, and Godot XR reusable nodes`
   the repository now has fresh coverage of multimodal caption sidecars,
   OBS/browser/VRChat text-event routing, Open Brush/Tilt asset pipelines,
   browser shader restoration and raw `.tilt` loaders, Gaussian splat editor
   and viewer stacks, Unity/native splat runtimes, and Godot XR function-node
   plus vendor-extension package patterns.
20. `Overlay window substrates, game overlay managers, and modular overlay hosts`
   the repository now has fresh coverage of Electron shared-texture OpenVR
   overlays, injected window-surface IPC, flag-gated SteamVR driver/overlay
   umbrellas, Unity overlay module baselines, and editor-driven OpenXR overlay
   engines with hidden browser/window capture.
21. `OpenXR adaptation micro-layers and compatibility shims`
   the repository now has fresh coverage of OSC eye/face tracking adapters,
   runtime-side hand-joint transform correction, Rust graphics compatibility
   wrappers, and compact generated-dispatch C layer templates.
22. `Spatial anchors, colocation, and shared scene persistence`
   the repository now has fresh coverage of Meta Unreal shared anchors, shared
   scene reconstruction relative to anchors, Magic Leap localization-gated
   persistence, ARFoundation/OpenXR storage callbacks, and anchor status UI.
23. `VRChat OSC diagnostics, web panels, and sensor-to-avatar bridges`
   the repository now has fresh coverage of browser chatbox panels, passive and
   OSCQuery-aware parameter debuggers, TypeScript web parameter panels, C# OSC
   helper libraries, Leap Motion finger bridges, controller micro-tools, and
   heart-rate SDK/device bridges.
24. `XR text entry, shared WebXR rooms, teleoperation operators, and DIY hardware boundaries`
   the repository now has fresh coverage of WebView/UV/canvas/collider keyboard
   surfaces, shared WebXR room transports, Unity WebXR multiplayer shells,
   ROS/OpenVR/WebSocket teleoperation safety gates, and DIY headset/controller
   firmware-driver-spec boundaries.
25. `Voice/chatbox composition, browser OSC controls, and VRC haptics lineage`
   the repository now has fresh coverage of VAD-gated voice translation,
   local/cloud STT mode routers, avatar-controlled STT/translation extensions,
   media/status chatbox composers, browser/phone OSC control panels, and
   avatar-driven haptics server/firmware/hardware boundaries.
26. `PSVR2 integration, physical-output safety, live-performance bridges, and audience-event control`
   the repository now has fresh coverage of PSVR2 OpenXR passthrough and gaze
   shims, safety-first avatar OSC physical-output routers, MIDI/DMX/piano
   performance bridges, and Twitch/audience-event rule engines for VRChat OSC.
27. `VRChat chatbox composers, audio-reactive sidecars, overlay notifications, and remote-control boards`
   the repository now has fresh coverage of IDE/media/lyrics/speech chatbox
   composers, audio loopback and OSCQuery soundboards, XSOverlay notification
   bridges, secure remote avatar boards, OSC automation sequencers, and tiny
   time/smart-home state bridges.
28. `VRCOSC module ecosystems, shared WebXR rooms, lightweight XR authoring, and vendor tracker/glove bridges`
   the repository now has fresh coverage of VRCOSC module-pack distribution,
   event queues and sensor modules, Networked-AFrame adapters and persistence,
   in-headset authoring surfaces, and ContactGlove/Haritora bridge sidecars.
29. `WebXR runtime scaffolding, A-Frame/Godot component layers, and React/Three spatial UI labs`
   the repository now has fresh coverage of WebXR polyfills and emulator
   shells, input-profile loaders, A-Frame micro-components, Godot XR tracker
   bridges and recorders, React/Three XR store substrates, spatial UI layout,
   interaction lab shells, and AR measurement/model-viewer microtools.
30. `Overlay media micro-surfaces, XR glasses protocols, camera tracking sidecars, and VR/WebXR control safety`
   the repository now has fresh deepening coverage of direct media-to-overlay
   texture loops, note and telemetry overlay shells, Xreal/Nreal WebHID and
   native protocol readers, head-tracked desktop helpers, MediaPipe/VRCFT/VRM
   mapping sidecars, AI full-body tracking fusion, and teleoperation-inspired
   operator HUDs, command sidecars, and safety gates.
31. `Shared WebXR rooms, MRTK spatial UI contracts, Udon menus, and media/audio substrates`
   the repository now has fresh coverage of browser XR presence and P2P media
   adapters, MRTK interaction/data/visual/accessibility boundaries, VRChat/Udon
   menu and package surfaces, and immersive media/audio substrate patterns for
   LibVLC, spatial renderers, listener/source wrappers, and shader audio buses.
32. `Spatial stability, OpenXR extension wrappers, VR microhelpers, and creator workbench interactions`
   the repository now has fresh coverage of world-locking/anchor binding,
   vendor OpenXR feature wrappers, cockpit hand-clicking, tracking-origin
   calibration, camera-to-overlay passthrough, CAD workbenches, VR panels,
   mesh editing modes, and embodied feedback surfaces.
33. `XR research data lifecycles, WebRTC media surfaces, browser projection viewers, and DIY haptics adapters`
   the repository now has fresh coverage of structured XR data capture and
   validation, WebRTC desktop/camera/stereo panels, projection-aware browser
   media viewers, gaze-controlled media/desktop surfaces, and OpenGloves
   adapter boundaries for DIY haptic glove variants.
34. `WebXR hand input, immersive data workbenches, scriptable work surfaces, and runtime primitive stacks`
   the repository now has fresh coverage of hand-pose templates and
   fallback hand tracking, Python/data-to-WebXR scene bridges, robotics and
   scientific visualization workbenches, CAD/code/editor work surfaces,
   audio-reactive depth/passthrough menus, and WebXR SDK/runtime maturity
   comparisons.

## Most useful current docs

Use these first if you need fast recovery:

1. `../foundation/current-operating-context.md`
2. `program/new-session-quickstart.md`
3. `catalog/project-registry.md`
4. `landscape/project-families.md`
5. `landscape/not-yet-studied-deeply.md`
6. `methods/vr-utility-methods-catalog.md`

## Recent landmark waves

These are the most useful recent reference waves if you need current examples
instead of full history:

- `landscape/vr-projects-wave-64-openxr-sample-apps-rendering-baselines-and-bring-up-references.md`
- `landscape/vr-projects-wave-67-openvr-tracking-export-recording-and-robotics-bridge-tooling.md`
- `landscape/vr-projects-wave-68-vmt-adapters-osc-action-compilers-and-skeletal-validation-utilities.md`
- `landscape/vr-projects-wave-69-openxr-platform-shells-layer-managers-and-runtime-inspection-workbenches.md`
- `landscape/vr-projects-wave-70-mixed-vr-controller-bridges-hand-emulation-and-external-tracker-interop.md`
- `landscape/vr-projects-wave-71-openvr-driver-learning-paths-synthetic-devices-and-remote-input-ingress.md`
- `landscape/vr-projects-wave-72-openvr-overlay-access-layers-starter-variants-and-minimal-shell-experiments.md`
- `landscape/vr-projects-wave-73-wayvr-ecosystem-add-ons-linux-dashboard-extensions-and-ipc-backed-overlay-surfaces.md`
- `landscape/vr-projects-wave-74-openvr-capture-replay-and-orchestration-toolchains.md`
- `landscape/vr-projects-wave-75-openxr-micro-layers-for-view-shaping-streamout-debugging-capture-and-frame-time-intervention.md`
- `landscape/vr-projects-wave-76-openxr-capability-injection-layers-input-remappers-and-peripheral-extension-bridges.md`
- `landscape/vr-projects-wave-77-openxr-helper-stacks-layer-toolchains-and-runtime-adaptation-helpers.md`
- `landscape/vr-projects-wave-78-openxr-passthrough-samples-and-engine-side-extension-integration-references.md`
- `landscape/vr-projects-wave-79-desktop-window-overlay-shells-linux-capture-utilities-and-launcher-stubs.md`
- `landscape/vr-projects-wave-80-microphone-control-voice-input-pipelines-and-audio-routing-helpers.md`
- `landscape/vr-projects-wave-81-immersive-music-players-vr-media-playback-surfaces-and-browser-video-shells.md`
- `landscape/vr-projects-wave-82-spatial-audio-sdks-renderers-and-object-optimization-toolchains.md`
- `landscape/vr-projects-wave-83-creator-facing-audio-systems-synced-player-frameworks-and-world-side-voice-management.md`
- `landscape/vr-projects-wave-84-browser-panoramic-video-players-mobile-wrappers-and-projection-aware-web-playback.md`
- `landscape/vr-projects-wave-85-engine-side-stereo-panoramic-viewers-vendor-player-samples-and-layout-specific-video-surfaces.md`
- `landscape/vr-projects-wave-86-vrchat-synced-video-player-frameworks-queue-frontends-and-event-optimized-media-shells.md`
- `landscape/vr-projects-wave-87-transformed-volumetric-and-nonstandard-3d-video-viewers.md`
- `landscape/vr-projects-wave-88-vrchat-world-authoring-toolkits-optimization-helpers-and-prefab-ecosystems.md`
- `landscape/vr-projects-wave-89-vrchat-world-runtime-infrastructure-voice-networking-and-player-state-helpers.md`
- `landscape/vr-projects-wave-90-vrchat-camera-staging-and-admin-control-systems-for-world-events.md`
- `landscape/vr-projects-wave-91-vrchat-interaction-ui-and-information-surface-prefabs.md`
- `landscape/vr-projects-wave-92-vrchat-world-persistence-inventory-save-manager-companions-and-external-data-bridges.md`
- `landscape/vr-projects-wave-93-vrchat-creator-diagnostics-editor-inspection-profiling-and-static-analysis-helpers.md`
- `landscape/vr-projects-wave-94-vrchat-embodied-interaction-custom-movement-and-physical-world-mechanics.md`
- `landscape/vr-projects-wave-95-udon-data-structure-libraries-serialization-helpers-and-creator-utility-foundations.md`
- `landscape/vr-projects-wave-96-vrchat-creator-starter-baselines-test-harnesses-and-language-boundary-experiments.md`
- `landscape/vr-projects-wave-97-udon-encoding-token-query-and-structured-data-micro-libraries.md`
- `landscape/vr-projects-wave-98-udon-sync-events-runtime-logging-and-shared-helper-micro-frameworks.md`
- `landscape/vr-projects-wave-99-vrchat-world-control-gadgets-environmental-systems-and-specialized-operator-surfaces.md`
- `landscape/vr-projects-wave-100-vrchat-avatar-setup-optimization-and-quest-portability.md`
- `landscape/vr-projects-wave-101-vrchat-avatar-composition-packaging-and-install-automation.md`
- `landscape/vr-projects-wave-102-vrchat-avatar-emulation-gesture-preview-repair-and-osc-assisted-posing.md`
- `landscape/vr-projects-wave-103-vrchat-avatar-text-speech-translation-and-viseme-sidecars.md`
- `landscape/vr-projects-wave-104-vrchat-shader-ecosystems-material-translators-and-visual-safety-shaders.md`
- `landscape/vr-projects-wave-105-vrcfury-toggle-automation-avatar-animator-dsls-and-editor-qol-overlays.md`
- `landscape/vr-projects-wave-106-vrcfacetracking-core-modules-templates-and-blendshape-preparation.md`
- `landscape/vr-projects-wave-107-vrchat-avatar-dynamics-physbone-migration-contact-prefabs-and-in-game-tuning.md`
- `landscape/vr-projects-wave-108-vrchat-companion-apps-osc-routers-plugin-senders-data-hubs-and-web-debug-surfaces.md`
- `landscape/vr-projects-wave-109-slimevr-server-tracker-firmware-adapters-and-calibration-ecosystem.md`
- `landscape/vr-projects-wave-110-bhaptics-sdks-osc-bridges-relays-and-telemetry-to-haptic-adapters.md`
- `landscape/vr-projects-wave-111-no-hmd-and-virtual-hmd-openvr-helpers-phone-bridges-and-controllable-driver-stubs.md`
- `landscape/vr-projects-wave-112-webxr-browser-api-samples-input-profiles-emulators-polyfills-and-react-three-xr-wrappers.md`
- `landscape/vr-projects-wave-113-unity-xr-interaction-workflow-toolkits-scientific-rigs-training-graphs-and-tilia-composition.md`
- `landscape/vr-projects-wave-114-meta-quest-mr-camera-depth-spatial-anchor-presence-and-motifs-samples.md`
- `landscape/vr-projects-wave-115-linux-spatial-desktop-stardust-workspace-clients-and-desktop-to-xr-helpers.md`
- `landscape/vr-projects-wave-116-godot-xr-engine-toolkits-templates-backends-and-vendor-extension-stacks.md`
- `landscape/vr-projects-wave-117-aframe-webxr-components-inspectors-networked-scenes-and-hand-ui.md`
- `landscape/vr-projects-wave-118-unreal-vr-interaction-toolkits-hand-tracking-comfort-and-tracker-plugins.md`
- `landscape/vr-projects-wave-119-vr-teleoperation-headset-frontends-robot-bridges-and-data-capture.md`
- `landscape/vr-projects-wave-120-alvr-wivrn-ecosystem-sidecars-platform-clients-and-streaming-helpers.md`
- `landscape/vr-projects-wave-121-xr-glasses-webhid-virtual-displays-and-head-tracked-desktop-helpers.md`
- `landscape/vr-projects-wave-122-mediapipe-camera-tracking-bridges-for-slimevr-vrchat-vrm-and-virtual-controllers.md`
- `landscape/vr-projects-wave-123-mixed-reality-capture-calibration-and-presenter-compositing-helpers.md`
- `landscape/vr-projects-wave-124-vr-treadmill-locomotion-hardware-input-adapters-and-virtual-controller-bridges.md`
- `landscape/vr-projects-wave-125-unity-vr-experiment-frameworks-data-capture-and-study-orchestration-helpers.md`
- `landscape/vr-projects-wave-126-immersive-browser-shells-webxr-runtimes-home-spaces-and-spatial-web-frontends.md`
- `landscape/vr-projects-wave-127-browser-native-webxr-utility-surfaces-creative-tools-diagnostics-and-data-visualization.md`
- `landscape/vr-projects-wave-128-quest-app-sideloading-modding-version-management-and-store-metadata-tooling.md`
- `landscape/vr-projects-wave-129-vmc-vrm-motion-capture-protocol-osc-transform-receivers-and-recording-export-tools.md`
- `landscape/vr-projects-wave-130-resonite-neos-modding-headless-external-sdk-and-social-utility-tooling.md`
- `landscape/vr-projects-wave-131-diy-open-source-headset-hardware-bring-up-drivers-pcbs-and-controller-firmware.md`
- `landscape/vr-projects-wave-132-vr-keyboard-text-entry-and-osc-input-surfaces.md`
- `landscape/vr-projects-wave-133-vr-subtitles-captions-stt-and-ocr-accessibility-surfaces.md`
- `landscape/vr-projects-wave-134-steamvr-operational-support-startup-automation-dynamic-performance-and-linux-driver-helpers.md`
- `landscape/vr-projects-wave-135-focused-overlay-micro-surfaces-qr-media-game-huds-and-ocr-assisted-workflow-panels.md`
- `landscape/vr-projects-wave-156-openxr-vrcft-eye-face-modules-calibration-clients-and-avatar-facetracking-preparation.md`
- `landscape/vr-projects-wave-157-vrchat-chatbox-speech-tts-ai-companions-and-text-composition-sidecars.md`
- `landscape/vr-projects-wave-158-vrchat-osc-telemetry-avatar-scaling-device-status-and-parameter-control-helpers.md`
- `landscape/vr-projects-wave-159-haptic-physical-output-routers-and-wearable-feedback-bridges.md`
- `landscape/vr-projects-wave-160-foveated-rendering-quad-view-settings-and-graphics-layer-adaptation-helpers.md`
- `landscape/vr-projects-wave-161-oscquery-vrchat-discovery-libraries-and-client-primitives.md`
- `landscape/vr-projects-wave-162-resonite-creator-import-export-inspection-and-screenshot-utility-helpers.md`
- `landscape/vr-projects-wave-163-external-pose-object-and-sensor-data-to-vrchat-osc-bridges.md`
- `landscape/vr-projects-wave-164-vrchat-obs-audience-captions-translation-and-chat-ingress-surfaces.md`
- `landscape/vr-projects-wave-165-open-brush-tilt-asset-pipeline-browser-viewers-shader-loaders-and-collaborative-drawing.md`
- `landscape/vr-projects-wave-166-gaussian-splat-immersive-3d-asset-viewers-editors-and-xr-display-surfaces.md`
- `landscape/vr-projects-wave-167-godot-xr-toolkits-vendor-extensions-templates-and-face-tracking-bridges.md`
- `landscape/vr-projects-wave-184-low-latency-xr-video-point-cloud-and-browser-stream-surfaces.md`
- `landscape/vr-projects-wave-185-accessibility-embodied-locomotion-redirected-walking-and-zero-g-control.md`
- `landscape/vr-projects-wave-186-vr-menu-radial-control-avatar-menu-editing-and-osc-command-surfaces.md`
- `landscape/vr-projects-wave-187-heart-rate-wearable-ant-ble-and-sensor-to-osc-bridge-variants.md`
- `landscape/vr-projects-wave-188-vrchat-osc-voice-stt-translation-and-extensionable-chatbox-pipelines.md`
- `landscape/vr-projects-wave-189-vrchat-chatbox-media-status-and-bounded-text-composition-microtools.md`
- `landscape/vr-projects-wave-190-web-phone-and-browser-remote-osc-control-surfaces.md`
- `landscape/vr-projects-wave-191-vrc-haptics-server-firmware-hardware-and-trigger-bridge-lineage.md`
- `landscape/vr-projects-wave-196-vrchat-chatbox-status-media-lyrics-and-ide-presence-micro-composers.md`
- `landscape/vr-projects-wave-197-vrchat-audio-reactive-osc-audiolink-soundboard-and-system-audio-control-sidecars.md`
- `landscape/vr-projects-wave-198-xsoverlay-discord-and-remote-notification-protocol-bridges.md`
- `landscape/vr-projects-wave-199-vrchat-avatar-remote-control-toy-automation-time-and-smart-light-sidecars.md`
- `landscape/vr-projects-wave-200-vrcosc-module-packs-add-on-modules-and-plugin-distribution-boundaries.md`
- `landscape/vr-projects-wave-201-networked-aframe-adapters-persistence-media-and-unity-client-variants.md`
- `landscape/vr-projects-wave-202-lightweight-xr-editor-tour-builder-live-coding-and-creator-microtools.md`
- `landscape/vr-projects-wave-203-contactglove-haritora-and-vendor-tracker-bridge-sidecars.md`
- `landscape/vr-projects-wave-204-webxr-runtime-dev-scaffolding-polyfills-emulators-and-input-profile-loaders.md`
- `landscape/vr-projects-wave-205-aframe-ui-locomotion-environment-and-physics-micro-components.md`
- `landscape/vr-projects-wave-206-godot-xr-addons-hand-tracker-recording-and-reference-plugin-periphery.md`
- `landscape/vr-projects-wave-207-react-three-xr-runtime-spatial-ui-and-interaction-lab-surfaces.md`
- `landscape/vr-projects-wave-208-overlay-media-micro-surfaces-notes-browser-and-direct-video-overlays.md`
- `landscape/vr-projects-wave-209-xr-glasses-webhid-protocol-and-head-tracked-desktop-helpers.md`
- `landscape/vr-projects-wave-210-mediapipe-avatar-tracking-sidecars-vrm-and-full-body-bridges.md`
- `landscape/vr-projects-wave-211-vr-teleoperation-control-frontends-robot-bridges-and-safety-huds.md`
- `landscape/vr-projects-wave-212-shared-room-webxr-aframe-presence-webrtc-and-peer-adapter-microprototypes.md`
- `landscape/vr-projects-wave-213-mrtk-spatial-ui-graphics-robotics-and-gaze-extension-nodes.md`
- `landscape/vr-projects-wave-214-vrchat-udon-menu-package-surfaces-world-admin-and-creator-prefabs.md`
- `landscape/vr-projects-wave-215-immersive-media-audio-substrates-libvlc-spatial-renderers-and-audiolink.md`
- `landscape/vr-projects-wave-216-openxr-conformance-spec-validation-and-runner-toolchain.md`
- `landscape/vr-projects-wave-217-stardustxr-client-infrastructure-panel-protocols-and-spatial-desktop-microclients.md`
- `landscape/vr-projects-wave-218-udon-runtime-diagnostics-data-structures-and-predictive-sync-utilities.md`
- `landscape/vr-projects-wave-219-vrchat-external-content-ingress-image-glb-texture-and-avatar-data-surfaces.md`
- `landscape/vr-projects-wave-220-world-locking-spatial-coordinate-stabilization-and-anchor-sharing.md`
- `landscape/vr-projects-wave-221-vendor-openxr-extension-stacks-feature-wrappers-and-sample-matrices.md`
- `landscape/vr-projects-wave-222-cockpit-hand-clicking-calibration-observer-and-passthrough-microhelpers.md`
- `landscape/vr-projects-wave-223-xr-creator-cad-ui-workbenches-and-legacy-unity-interaction-donors.md`
- `landscape/vr-projects-wave-224-xr-research-data-lifecycle-templates-validation-and-analysis-pipelines.md`
- `landscape/vr-projects-wave-225-webrtc-webxr-remote-surfaces-camera-streams-and-spatial-panels.md`
- `landscape/vr-projects-wave-226-browser-media-depth-video-projection-and-gaze-viewer-surfaces.md`
- `landscape/vr-projects-wave-227-opengloves-diy-haptics-adapters-named-pipe-and-firmware-variants.md`
- `landscape/vr-projects-wave-228-webxr-hand-input-gesture-template-and-fallback-hand-tracking-primitives.md`
- `landscape/vr-projects-wave-229-immersive-data-robotics-and-scientific-visualization-workbenches.md`
- `landscape/vr-projects-wave-230-scriptable-webxr-modeling-viewer-and-creative-surfaces.md`
- `landscape/vr-projects-wave-231-webxr-prototyping-runtime-micro-frameworks-and-experimental-primitives.md`

## Strong donor clusters right now

If the goal is to extract high-value implementation patterns, these are some of
the strongest current clusters:

- `openxr-explorer`, `OpenXR-API-Layers-GUI`, `clearxr-server`,
  `vrkit-platform`
  for runtime inspection, layer-state repair, and desktop-plus-XR platform
  splits.
- `VirtualMotionTracker`, `VMC2VMT`, `OVR-VRC-OSC-Bridge`,
  `SteamVR_To_OSC`
  for tracker-host design, adapter layers, and controller-to-OSC compilers.
- `Yet-Another-OpenVR-IPC-Driver`, `Simple-OpenVR-Driver-Tutorial`,
  `OpenVR-Tracker-Driver-Example`, `OpenVR-ArduinoHMD`
  for synthetic-device ingress, driver learning, and test harnesses.
- `DesktopPlus`, `OpenKneeboard`, `h-view`, `SteamVR-WebApps`,
  `VRSceneOverlay`
  for overlay-first utility shells and in-headset workflow surfaces.
- `ovr_overlay`, `OpenVR.ALBRT.overlay`, `wayvr`, `wayvr-ipc`
  for overlay backplanes, Linux host ecosystems, and desktop-shell plus
  overlay-backend splits.
- `vr-capture-replay`, `VRScout_Agent_Orchestration_Unity_Project`, `ViRe`
  for record-replay harnesses, orchestration loops, and VR-native recording
  studios.
- `OpenXR-RecenterOverride`, `OpenXR-Layer-crop-fov`,
  `openxr-renderdoc-layer`, `openxr_streamout_layer`
  for operator-facing and developer-facing OpenXR micro-layers.
- `OpenXRHandTracking`, `openxr_remapping_layer`, `quark`, `OpenXR-CAS`,
  `ue-openxr-passthrough`
  for capability injection, layer authoring, runtime adaptation, and
  engine-side extension integration.
- `spatialaudio-unity`, `omnitone`, `libspatialaudio`, `Cavern`,
  `spatial-audio-clustering`
  for spatial-audio substrate, renderer abstractions, and object-budget-aware
  audio tooling.
- `AudioLink`, `USharpVideo`, `USharpVideoQueue`, `VVMW`, `AudioManager`
  for creator-facing audio infrastructure, synced media systems, and world
  voice-state control.
- `360WebPlayer`, `videojs-panorama`, `videojs-vr`, `Unity_Panorama180View`,
  `VideoTXL`, `VR-reversal`, `DomeTools`
  for projection-aware playback layers, creator-side video systems, and
  nonstandard 3D viewing environments.
- `VRWorldToolkit`, `UdonSharpOptimizer`, `VUdon`, `UdonEssentials`
  for creator-world authoring, package ecosystems, and pre-runtime workflow
  tooling.
- `UdonVoiceUtils`, `UNet`, `CyanPlayerObjectPool`, `VRChatCameraWorks`,
  `CameraSystem`, `GMMenu`, `U-Key`, `VRCMarker`, `UdonRecyclingScrollRect`
  for creator-world runtime substrate, staging systems, admin surfaces, and
  utility-prefab infrastructure.
- `NUSaveState`, `InventorySystem`, `ToNSaveManager`,
  `Udon-MIDI-Web-Helper`
  for creator-world persistence, companion save managers, and external-data
  bridge architecture.
- `GotoUdon`, `UdonExplorer`, `UdonSharpProfiler`,
  `UdonRabbit.Analyzer`
  for creator diagnostics, editor inspection, compiler instrumentation, and
  static guardrails.
- `immersive-interactions`, `UdonTether`, `NUMovement`, `UdonDoor`,
  `KurotoriUdonKart`
  for embodied interaction, locomotion mechanics, and physical world-control
  donors.
- `UdonUtils`, `udon-list`, `udon-dictionary`, `udon-json`,
  `UArrayCollections`, `VUdon-ArrayExtensions`
  for creator-world substrate, lifecycle foundations, and constrained
  data-structure design.
- `template-world`, `udon-test`, `wasm2usharp`, `udon-encoding`, `udon-jwt`,
  `ULinq`, `UdonXMLParser`
  for creator bootstrap lineage, testing substrate, alternative-language
  pipelines, and constrained-runtime protocol or parsing helpers.
- `VUdon-Events`, `UdonSharpNetworkingLib`, `LightSync`, `VUdon-Logger`
  for creator runtime helper frameworks, serialized event routing, typed
  networking, sync lineage, and in-world diagnostics.
- `VUdon-DepthBufferToolkit`, `VR-Stage-Lighting`,
  `UdonSharpDayNightController`, `VRChat_Keypad`, `UdonKeypad`
  for render-fixup micro-tools, operator surfaces, shared environment control,
  and access-control gadgets.
- `PumkinsAvatarTools`, `VRCQuestTools`, `d4rkAvatarOptimizer`,
  `immersive_scaler`, `modular-avatar`, `vrc-get`, `Avatars-3.0-Manager`
  for avatar bring-up workbenches, Quest portability, upload-time optimization,
  non-destructive composition, and creator project-package management.
- `Av3Emulator`, `VRC-Gesture-Manager`, `avautils`, `LexisPosingSystem`,
  `TTS-Voice-Wizard`, `kikitan-translator`, `HeadTTS`, `Billboard`
  for avatar rehearsal, repair, pose-session sidecars, speech-hub design,
  viseme-aware TTS substrate, and avatar-visible communication surfaces.
- `PoiyomiToonShader`, `lilToon`, `Mochies-Unity-Shaders`,
  `lilToonToPoiyomiToon`, `EpilepsyProtection`
  for shader editor ecosystems, material migration, modular shader-pack
  layouts, and visual-safety avatar addons.
- `VRCFury`, `wk-vrcfury-qol`, `VRCToggleToolkit`,
  `animator-as-code-vrchat`, `vrchat-quick-toggle-vrcfury`
  for avatar feature builders, reflection-backed editor overlays, toggle
  generation, code-first animator authoring, and public-API micro-tools.
- `VRCFaceTracking`, `VRCFaceTracking.Avalonia`, `VRCFT-Babble`,
  `VRCFaceTracking-MeowFace`, `VRCFaceTracking-blender-plugin`
  for face-tracking hosts, cross-platform module registries, provider modules,
  OSC/UDP/JSON expression normalization, and DCC-side blendshape preparation.
- `PhysBone-to-DynamicBone`, `PhysBonesTK`, `VRChat_PhysboneDetach`,
  `Avatar-Prop`, `Collision-Detection`
  for PhysBone migration, in-game dynamics tuning, detached component grouping,
  grabbable avatar props, and contact/collision state prefabs.
- `VRCX`, `VOR`, `VRCOSCGUI`, `VRCOSCDataHub`, `VRCOSCWeb`
  for external VRChat companion feeds, OSC fan-out routing, plugin sender
  boundaries, local data hubs, and browser avatar-parameter controls.
- `SlimeVR-Server`, `SlimeVR-Tracker-ESP`, `slimevr-wrangler`, `moslime`,
  `SlimeTora`
  for tracker hubs, firmware diagnostics protocols, consumer-device adapters,
  BLE normalization, guided setup, and per-tracker health UX.
- `haptic-library`, `tact-js`, `tact-python`, `bHapticsOSC`,
  `bHapticsRelay`
  for haptic SDK facades, browser/Python command layers, avatar OSC haptics,
  and generic log/WebSocket event-to-haptics relays.
- `PhoneVR`, `driver_hmd`, `faceless`, `OpenVRsim`, `Pepper`
  for phone-HMD bridge anatomy, fake display components, no-HMD pose
  inference, socket-controlled virtual devices, and keyboard/mouse fake rigs.
- `webxr-samples`, `webxr-input-profiles`, `immersive-web-emulator`,
  `webxr-polyfill`, `xr`
  for browser XR session shells, controller-profile registries, emulator
  injection, deprecated polyfill history, and framework-level WebXR stores.
- `MixedRealityToolkit-Unity`, `ExPresS-XR`, `VR-Builder`, `VRTK`
  for modern Unity spatial UI, scientific/exhibition rigs, data capture,
  training workflow graphs, editor validation, and prefab-composed interaction
  ecosystems.
- `Unity-PassthroughCameraApiSamples`, `Unity-DepthAPI`,
  `Unity-SharedSpatialAnchors`, `Unity-Discover`, `Unity-MRMotifs`
  for Quest MR camera access, camera-to-world rays, depth occlusion, shared
  anchors, room alignment, full-app structure, and reusable MR motifs.
- `Simula`, `flatland`, `kiara`, `protostar`, `magnetar`,
  `picom-xrdesktop-companion`
  for Linux desktop-in-XR shells, 2D panel bridges, virtual monitors,
  launchers, workspace grouping, and compositor-assisted window mirroring.
- `godot-xr-tools`, `godot-xr-template`, `godot_openxr_vendors`,
  `godot_openvr`
  for Godot scene-pack XR toolkits, action-map/export baselines, vendor
  OpenXR extension gates, and SteamVR metadata helpers.
- `aframe`, `aframe-inspector`, `networked-aframe`, `superframe`,
  `aframe-hand-tracking-controls-extras`
  for browser-native XR component systems, scene inspection, schema-driven
  networked sync, in-VR diagnostics, and hand/pinch UI widgets.
- `VRExpansionPlugin`, `MixedReality-UXTools-Unreal`,
  `VrTunnellingPro-UE4`, `FSOpenXRHandTracking`,
  `UE4OpenXRViveTrackerPlugin`
  for Unreal replicated grips, MR near/far UX primitives, comfort tunnelling,
  OpenXR hand tracking, and tracker role mapping.
- `kbot_vr_teleop`, `xarm_vr_teleop`, `collab-sim`,
  `franka-vr-teleop`, `VR_Teleop_Interface`, `cambot`, `UR_VR_Teleop`
  for VR operator/control-surface architecture, pose transport, IK/MPC loops,
  safety gates, diagnostics sidecars, and data-capture workflows.
- `alvr-visionos`, `VRCFT-ALVR`, `ADBForwarder`, `WiVRnTimings`
  for streaming ecosystem companions, platform-client lifecycle, face/eye
  payload adapters, setup repair, and timing viewers.
- `xreal-webxr`, `nreal_linux_test`, `XReal-Ultrawide`
  for browser WebHID XR-glasses diagnostics, screen-capture viewport POCs,
  virtual display lifecycle, IMU recenter/smoothing, and head-tracked desktop
  helpers.
- `SlimeVR-Tracker-Mediapipe`, `MediapipeFaceTracking_VRC`,
  `mediapipe-vrm-tracking`, `VRBodyTrack`, `mediapipe_VR_controller`
  for camera landmark bridge patterns across SlimeVR UDP, avatar expressions,
  Unity pipes, browser VRM, and OSC virtual-controller payloads.
- `reality-mixer-js`, `RealityMixerVisionPro`, `mrc-client`, `MrcXrtHelpers`,
  `ArtificialGreenScreen`
  for mixed-reality capture calibration, foreground/background compositing,
  mobile camera payloads, Oculus/Unity MRC repair helpers, and segmentation
  fallback workflows.
- `vr-treadmill`, `slimstep_vr`, `GoobleBoxVR`,
  `VR-treadmill-server-app`
  for locomotion hardware bridge readiness, serial/OpenVR scalar input
  plumbing, balance-board state classification, and BLE command/status
  firmware.
- `unity-experiment-framework`, `TUX`, `vr_experiment_framework_v3`,
  `uxf-web-settings`, `uxf-s3-uploader`
  for session/block/trial lifecycle, tracker/data-handler abstraction,
  editor-authored study design, settings-driven task generation, remote
  settings, fallback, and upload sidecars.
- `wolvic`, `FirefoxRealityPC`, `exokit`, `exokit-browser`
  for immersive browser shell boundaries, windows/widgets/session stores,
  WebXR interstitials, dependency-readiness launchers, and explicit WebXR
  session/input modeling.
- `a-painter`, `LeapShape`, `spatial-photo-webxr-viewer`,
  `vr-screen-tester`, `prediction-space`
  for controller-aware WebXR creative tools, palm/secondary-hand menus,
  local-first stereo media, micro-diagnostics, and gaze/pinch data dashboards.
- `SideQuest`, `QuestPatcher`, `QuestPatcher.QMod`,
  `QuestAppVersionSwitcher`, `OculusDB`
  for managed ADB/platform-tools bootstrap, Quest APK patch/sign workflows,
  mod package schemas, backup/version metadata, and app-store metadata
  services.
- `VirtualMotionCaptureProtocol`, `EasyVirtualMotionCaptureForUnity`,
  `QuestOSCTransformSender`, `vmc2bvh`, `vmcrec`
  for role-based OSC pose streams, Unity VRM receivers, Quest transform
  senders, packet validation, typed motion logs, and BVH export.
- `ResoniteModLoader`, `Resolute`, `resonite-mod-manifest`,
  `ResoniteLink`, `ReCon`, `ResoniteMetricsCounter`
  for social VR mod-loader lifecycle, schema-first manifests, external
  data-model SDKs, companion auth/live-event clients, and in-world metrics.
- `Relativty`, `HadesVR`, `Wand-Controller`, `Basic-HMD-PCB`,
  `HadesVR_GUI_Tool`, `DIY_VR_Controllers`
  for DIY headset firmware, OpenVR HMD driver bring-up, HID/UART/RF packet
  transport, driver settings GUIs, PCB/BOM/STL assets, and controller
  calibration variants.
- `react-360-keyboard`, `vr-keyboard`, `VRKeyboard`, `VR_Keyboard`,
  `VRC-KeyboardController-in-VR_OSC`
  for modal keyboard services, raycast/canvas keyboards, fingertip physical
  keys, native OpenVR keyboard bridges, and VRChat OSC input emitters.
- `vr-subtitles`, `VR_SUBTITLES_BURNERRR`, `WebVR-Captioning`, `STTS`
  for subtitle queues, speaker/FOV placement, projection-aware subtitle
  burn-in, screenshot captioning, STT/translation overlays, OCR controls, and
  VRChat chatbox bridges.
- `OpenVRStartup`, `OpenVR-Dynamic-Resolution`, `steam-devices`,
  `VivePro2-Linux-Driver`
  for SteamVR lifecycle automation, dynamic runtime settings controllers,
  Linux device-permission inventories, proxy drivers, and typed
  settings/property helpers.
- `VRCOSCAvatarScaleOverlay`, `VR-QR-Overlay`, `VR-Music-Remote`,
  `EchoVR-Overlay`, `ez-wishlist-overlay`
  for Unity dashboard overlays, mirror-texture recognition, window-captured
  media HUDs, browser telemetry surfaces, and OCR-assisted workflow panels.
- `Transparent-Twitch-Chat-Overlay`, `ghost-chat`, `jChat`,
  `showmy.chat`, `twitch_chat_emotes`
  for transparent/captured chat windows, setup/live overlay toggles,
  browser-source URL contracts, provider-normalized chat/emote fan-in, and
  stream-facing event surfaces.
- `tilt-brush`, `open-brush`, `blocks`, `SideSketch`, `vartiste`
  for VR creative-tool app states, brush/tool catalogs, Unity panels, WebXR
  shelves, command/proto histories, export pipelines, scripting APIs, and
  fork-lineage lessons.
- `ubiq`, `hubs`, `janusweb`, `vrsys-core`
  for room servers/clients, presence, permissions, networked ECS/component
  state, WebRTC/peer events, declarative spatial-web embeds, and Unity
  Netcode/XRI/Meta Avatar composition.
- `opengloves-ui`, `opengloves-protocol`, `pygloves`, `opengloves-lib`,
  `CS-OpenGloves-Named-Pipe-Input-Library`, `opengloves-osc`,
  `opengloves-force-feedback-unity-demo`, `opengloves-hl-alyx-integration`
  for hand-device sidecars, protobuf contracts, named-pipe input, OSC ingress,
  alpha serial encoding, synthetic tests, Unity FFB, and game-log haptic
  adapters.
- `unity-webxr-export`, `Simple-WebXR-Unity`, `looking-glass-webxr`,
  `webxr-layers-polyfill`, `webxr-test-api`, `webxr-showcases`
  for WebXR export loaders, minimal JS/C# bridges, non-HMD display adapters,
  composition-layer shims, deterministic fake-device testing, and feature-gated
  browser XR showcases.
- `playcanvas/editor`, `nunuStudio`, `triplex`, `RiftSketch`, `remixvr`,
  `troika`
  for browser editor method buses, local project/action histories,
  source-code-driven visual workspaces, in-VR live coding, template publishing,
  and readable Three.js UI/text infrastructure.
- `UniVRM`, `three-vrm`, `aframe-vrm`, `SystemAnimatorOnline`,
  `vrm-specification`
  for VRM runtime/editor stacks, modular browser avatar loaders, A-Frame avatar
  components, browser avatar/mocap surfaces, and schema-backed avatar behavior
  contracts.
- `mind-ar-js`, `AR.js`, `Simple-AR`, `aframe-ar`, `model-viewer`, `enva-xr`
  for browser AR target compilation, marker/location tracking, AR starter
  surfaces, A-Frame AR wrappers, AR model-viewer fallback UX, and WebXR
  hit-test/light/depth scene-understanding helpers.
- `webxr-handtracking`, `webxr-hand-tracking-sample`,
  `webxr-hand-tracking-websocket`, `webxr-quest2`
  for WebXR joint caches, pinch gestures, fingertip rays, per-hand verbs,
  passthrough hand grabbing, and WebSocket hand-pose export.
- `webxr-video`, `VR180-video-player`, `html-360-viewer`,
  `360-video-player`, `openimmersive`
  for projection-aware immersive media viewers, local file ingress,
  drag/drop browser viewers, controller-to-canvas UI, and explicit
  stereo/FOV/baseline controls.
- `webxr-audio-visualizer`, `vite-three-webxr-audio-visualizer`,
  `boondoggle`, `seeSound`
  for audio analysers, stereo channel splitting, FFT feature vectors,
  audio-to-shader uniforms, native loopback capture, and sound-texture
  pipelines.
- `three.js`, `Babylon.js`, `playcanvas/engine`, `immersive-web-sdk`
  for WebXR session managers, controller/grip/hand abstractions, modular
  feature managers, evented XR service taxonomies, synthetic input, and
  runtime-first spatial UI tooling.
- `aframe-gui`, `aframe-teleport-controls`,
  `aframe-super-hands-component`, `AUXL`, `aframe-webxr-ui-toolkit`
  for declarative A-Frame widgets, teleport rays, semantic interaction events,
  menu factories, lifecycle-managed menus, and hand-tracking pressables.
- `vria`, `3d-force-graph-vr`, `aframe-forcegraph-component`, `molstar`,
  `ipyvolume`
  for immersive analytics grammars, graph accessor schemas, scientific viewer
  managers/snapshots, XR input mapping, notebook trait sync, and volume data
  tiling.
- `VRStreaming`, `UnityRenderStreaming`, `com.unity.webrtc`,
  `PixelStreamingInfrastructure`, `Unreal-Pixel-Streaming`
  for remote VR streaming, WebRTC signaling, peer/data-channel layers, input
  remoting, WebXR video projection, pose/control protocols, and matchmaker
  deployment shells.
- `ATON`, `circlesxr`, `arena-web-core`, `Basis`, `webaverse`
  for scene JSON, semantic graphs, Networked-AFrame ownership, MQTT/Jitsi
  media surfaces, headless avatar clients, compressed avatar packets, and
  spatial app runtimes.
- `turncountervr`, `vive-wireless-info-overlay`, `gpu-vram-monitor`,
  `RacingManager`, `vr-twitch-chat-ui`
  for cable-awareness micro-overlays, wireless temperature product framing,
  GPU/VRAM telemetry and control loops, simulator shared-memory panels, and
  VR readability profiles for host-embedded chat.
- `GOpy`, `BD-XSOverlay-notify`, `VRC-NexusChat`,
  `zenn-overlay-tutorial`, `EmyOverlay`, `VROverlayTest`
  for OSC-to-overlay icons, external overlay-host WebSocket envelopes,
  source-light VRChat OSC companion framing, overlay lifecycle onboarding,
  OpenGL/ImGui texture submission, and C# OpenVR scratchpads.
- `Linux-Virtual-Display-Driver`, `openxr-3d-display`, `SbsImageViewer`,
  `VR-Display`, `Virtual-Desktop-VR`, `GodotXRDesktop`
  for Linux virtual monitors, spatial-display OpenXR runtime boundaries,
  stereo image viewer controls, historical display hardware references,
  virtual desktop POCs, and Godot no-HMD synthetic XR trackers/actions.
- `openxrhands`, `AutoHandSimulator`, `RoboHands-UnityXR`, `ExPresS-XR`
  for Unity OpenXR hand extension bridges, no-HMD hand/body simulation,
  gesture-pose package framing, and scientific XR toolkit primitives.
- `VRCFaceTracking-QuestProOpenXR`, `VRCFT-ALXR-Modules`,
  `VRC-Facetracking`, `PSVR2EyeTrackingCalibration`
  for vendor OpenXR face/eye expression mapping, local/remote tracking ingress,
  avatar threshold/setup tooling, OSC hygiene, and persistent gaze calibration.
- `NOVA-AI`, `vrc-tts-osc`, `XOSC`, `advosc`
  for AI assistant sidecars, memory/tool-calling, TTS and virtual-audio
  routing, chatbox telemetry, placeholder engines, block editors, and typed
  OSC forwarding.
- `vrcwatch.rs`, `vrc-avi-scaler`, `Camera-System`
  for OSC telemetry clocks, world-aware avatar scaling, compatibility shims,
  avatar-authored camera paths, and companion-control protocols.
- `HapticPatPat`, `owoskin-vrc`, `intiface-game-haptics-router`
  for OSC contact-to-hardware bridges, OSCQuery haptic effect engines, muscle
  maps, Bluetooth microcontroller output, rumble routers, IPC envelopes, and
  device-hub visualizers.
- `QuadViewsCompanion`, `PimaxMagic4All`, `openvr_foveated`,
  `Varjo-Foveated`, `ViveFoveatedRendering`
  for safe quad-view settings companions, vendor foveation SDK emulation,
  OpenVR DLL wrappers, OpenXR view-chain API-layer edits, and Unity native VRS
  command-buffer plugins.
- `VrcAdvert`, `vrchat_osc`, `OscQueryLibrary`, `oyasumivr_oscquery`,
  `vrchat_oscquery`
  for OSCQuery advertisement, Rust/C#/Python client primitives, direct-address
  fallback, mDNS sidecars, avatar parameter fetching, and multi-app proxy
  patterns.
- `Resonite.UnitySDK`, `ResoniteUnityExporter`,
  `ResoniteUnityPackagesImporter`, `CherryPick`,
  `ResoniteScreenshotExtensions`
  for generated data-model bindings, converter registries, shared DTO plus IPC
  import processors, package extraction caches, component-search palettes, and
  screenshot metadata round-tripping.
- `VRC-Tracked-Objects`, `VRChatOSCOptitrack`, `VRChat-MotionOSC`,
  `quest_steamvr_fbt_tool`, `vrc_osc_tracker`
  for avatar-relative tracked objects, NatNet rigid-body OSC trackers, webcam
  motion controls, simple OpenVR-to-OSC FBT scripts, and camera-calibrated
  MediaPipe tracker senders.
- `whispering`, `curses`, `VRChat-to-BLIP`, `Unity-Twitch-Chat`
  for multimodal caption fan-out, central text-event buses, window-capture
  scene captioning, and Unity audience-chat ingress.
- `open-brush`, `gallery-viewer`, `three-icosa`, `three-tiltloader`,
  `c-sharp-tiltbrush-toolkit`, `TiltBrushConverter`, `P2PDraw`
  for Open Brush/Tilt sketch loading, metadata restoration, shader replacement,
  raw `.tilt` parsing, conversion options, and collaborative stroke protocols.
- `supersplat`, `supersplat-viewer`, `model-viewer`, `GaussianSplats3D`,
  `UnityGaussianSplatting`, `GaussianSplattingVRViewerUnity`, `SplatVFX`
  for Gaussian splat editors, static WebXR viewers, model-viewer shells,
  Three.js libraries, Unity asset/runtime rendering, native plugin boundaries,
  and VFX substrates.
- `godot-xr-tools`, `godot_openxr_vendors`, `godot-xr-dungeon-template`,
  `godot-htc-face-tracking-bridge`, `godot-vr-toolkit`
  for Godot XR function nodes, vendor extension/export gates, product-template
  composition, face-tracking GDExtension bridges, and legacy viewport-to-mesh
  UI primitives.
- `bevy_oxr`, `hotham`, `xrbevy`, `wgpu-example`, `xrvis`
  for Rust OpenXR app-shell bring-up, Bevy render-world handoff, custom engine
  context splits, OpenXR runtime stubs, wgpu/Vulkan graphics binding, and live
  network data XR panels.
- `UEVR`, `REFramework`, `rai-pal`, `uuvr`, `chihuahua`, `UnityVRMod`, `LCVR`,
  `RepoXR`
  for VR retrofit API surfaces, graphics-hook coexistence, mod manager
  manifests, Unity XR subsystem injection, safe-mode gates, compatibility
  checks, and patch-group organization.
- `QuestArUcoMarkerTracking`, `ArUcoMarkerTracking`,
  `Unity.QuestRemoteHandTracking`, `ArUcoDetectionHoloLens-Unity`,
  `ArucoUnity`, `HoloLens2CVExperiments`
  for passthrough marker tracking, vendor marker callbacks, remote hand-data
  split transport, Unity ArUco calibration, and HoloLens camera-to-world marker
  pose pipelines.
- `PLUME`, `XREcho`, `Nebula-Core`, `kineo`
  for XR recorder/viewer workflows, Unity behavior replay, physiological and
  event timelines, olfactory device bridges, experiment logging, sparse-camera
  mocap, and BVH/USD motion exports.
- `react-electron-openvr`, `steamvr-overlay`, `WKOpenVR`, `Sable-Overlay`,
  `Honey_Overlays`, `VRMocapOverlay`, `Hoku`
  for Electron shared-texture overlays, injected surface IPC, modular
  driver/overlay feature hosts, Unity overlay modules, game-specific OpenXR
  overlay engines, and scriptable overlay product framing.
- `openxr_oscclient`, `OpenXR-Hand-Transform-Offset-Layer`,
  `sorenon_openxr_layer`, `openxr-layer-template`
  for OSC eye/face adapters, runtime-side hand transform correction, graphics
  compatibility layers, and compact API-layer templates.
- `Unreal-SpatialAnchorsSample`, `Unreal-SharedAnchorsSample`,
  `Unreal-SharedSceneSample`, `SpatialAnchorsExample`,
  `MagicLeapSpatialAnchors`
  for shared anchors, local/cloud/storage persistence, anchor-relative scene
  reconstruction, Magic Leap localization, and anchor status/control panels.
- `leapmotion-osc`, `VRChat-OSC-WEB-Chat`, `Drone-OSC-Controller`,
  `VRChatOSCLib`, `VRChatOSCDebugger`, `VRChatOscDebugger`,
  `VRChat-OSC-WebPanel`, `HRtoVRChat_OSC`
  for browser chatbox panels, passive and OSCQuery-aware OSC debuggers, typed
  OSC client primitives, avatar/controller micro-tools, finger bridges, and
  biometric sensor-to-avatar pipelines.
- `ProjectBabble`, `EyeTrackVR`, `VRCFaceTracking-TobiiXR`,
  `ryan9411vr/EyeTracking`, `BabbleCalibration`,
  `ResoniteOpenXREyeTracking`, `foveated-rendering-demo`
  for DIY mouth/eye tracking, per-user calibration, VRChat native/VRCFT
  outputs, in-headset calibration routines, and OpenXR/engine eye consumers.
- `resonite-headless-docker`, `resonite-headless-manager`,
  `Resonite-Headless-Discord-Bot`, `resonite-rest`,
  `ResoniteHeadlessHeadServer`, `Nimbus`, `Cumulo`
  for Resonite headless deployment, Docker/web/Discord/REST operations,
  shared-memory state export, and compatibility patch risk patterns.
- `OpenVisSim`, `VARID-plugin-ue5`, `VisualImpairmentVR`, `LowVisionVR`,
  `Glaucoma-VR`, `UnityAccessibilityPlugin`
  for visual impairment simulation, gaze-contingent masks, mobile passthrough
  filters, patient-data field maps, and screen-reader-like Unity UI.
- `Unity360ScreenshotCapture`, `Editor-Screenshot`, `UnityScreenShooter`,
  `UnityWindowsCapture`, `QuestMediaProjection`, `PhotoMode`,
  `vimeo-unity-sdk`
  for 360 screenshots, transparent editor capture, screenshot sequences,
  window/desktop/browser capture, Quest screen projection, photomode UX, and
  360/stereo media record/playback.
- `unity-keyboard`, `xrkeys`, `VirtualKeyboard-VR-Ready`,
  `vr-virtual-keyboard`, `XR-Keyboard-for-Unity`, `XRSimpleKeyboard`,
  `bevy_xr_keyboard`, `stardust-xr-keyboard-plugin`
  for WebView keyboards, raycast-to-UV key masks, canvas texture keyboards,
  physical collider keys, hand-attached pinch text entry, A-Frame keyboard
  micro-utilities, and shell key-event injection.
- `blocks`, `webxr-multiplayer-template`, `vrgoclub`,
  `webxr-webrtc-dc-scene`, `webroom-vr`, `xrai-spatial-web`,
  `webxr-multiplayer-room`
  for WebXR room signaling, P2P pose/audio channels, Unity Relay/NGO/Vivox
  rooms, shared-object events, chat/classroom baselines, and spatial HUD view
  registries.
- `vr_teleop`, `vr_ros2_bridge`, `ros_reality_bridge`,
  `vr-teleoperation`, `zz0320/vr_teleoperation_ros`,
  `VR-Teleoperation-Robotics-Platform`
  for ROS/OpenVR/WebSocket teleoperation bridges, tracked-pose publishers,
  safety gates, operator modes, camera panels, command buffers, and audio or
  diagnostic feedback.
- `NxtVR`, `FloV3R`, `Persephone-VR-Headset`, `OpenVision`,
  `vr-headset-specs`, `VRController`, `DIY-VR-Controller-OpenCV`,
  `DIY_VR_Controller`
  for DIY headset/controller HID reports, BLE/serial packets, OpenVR driver
  boundaries, haptics, marker tracking, CAD/BOM/PCB documentation, and headset
  specification schemas.
- `XR-Low-Latency-Stereo-Streaming`, `spatial-video`, `PointCast3D`,
  `relavr`, `SpatialVideoBrowser`
  for WebRTC/LiveKit video ingress, Quest capture sender state, UDP point-cloud
  meshes, browser-video world surfaces, and stereo/media format contracts.
- `vr-wheelchair`, `echo-unity`, `ddw-locomotion-system`, `space-extender`,
  `Locomotion-Accessibility-Toolkit`
  for embodied accessibility locomotion, zero-G grab/thruster control,
  hub/modifier/movement splits, redirected-walking telemetry, and option-set
  framing.
- `RadialMenuVR`, `Quest-VR-Menu`, `VRC-Menu-Translator`, `VrCScalingTool`
  for radial command menus, physical launcher commands, editor-side VRChat
  expression-menu traversal, desktop OSC slots, hotkeys, and avatar feedback.
- `HeartRateMonitorVRC`, `osc-hr-ble`, `vrchat_ant_hr`,
  `HeartRateOnStream-OSC`, `OSC-VRChat-Feeder`, `vrc_hyperate_chatbox`
  for BLE/ANT/HTTP/WebSocket heart-rate ingress, avatar parameter schemas,
  connection-state booleans, chatbox presentation, and phone sensor profiles.
- `FoxTrans`, `OSC_Voice`, `OSC-SRTC`, `RustyChatBox`,
  `vrc-osc-spotify`, `VRChat-OSC-ChatBox`, `WebVRChatOSC`,
  `VRCH-Server`, `VRCH-Firmware`, `HapticPatternTriggerOSC`
  for VAD-gated speech translation, local/cloud STT routing,
  avatar-controlled translation extensions, bounded chatbox composition,
  browser/phone OSC command surfaces, and avatar-driven haptics
  server/firmware/preset boundaries.
- `psvr2passthrough`, `PSVR2_STEAMVR_EYE_TRACKING_SHIM`,
  `monado-psvr2`, `_ARCHIVE_OpenXR-Eye-Trackers`,
  `VRChat-Shocker-Link-CPP`, `DG-LAB-VRChat-Sensora`,
  `VRC-MIDIDMX`, `OSCMidi`, `crystal-relay-public`,
  `TwitchIntegration`
  for PSVR2 passthrough/gaze/runtime shims, safety-first physical-output
  routers, MIDI/DMX/piano live-performance bridges, and audience-event
  OSC action engines.
- `VRC-Lyrics`, `vrchat-osc-motd`, `VRC-OSC-Audio-Reaction`,
  `oscsound`, `xsoverlay-proxy`, `xsOverlayVencord`,
  `VRC-Avatar-Remote-Server`, `vrchat-osc-automator`,
  `SimpleVRChatOSCSender`
  for provider-backed chatbox composers, plugin fan-in, audio-reactive
  parameter normalization, OSCQuery soundpacks, overlay notification proxies,
  Discord notification hooks, secure avatar remote boards, automation
  sequencing, and generic VRChat OSC harnesses.
- `VRCOSC-Modules`, `CrookedToe-s-Modules`, `FuviiOSC`,
  `VRCOSC-BluetoothHeartrate`, `VRCOSC-Bilibili`, `naf-janus-adapter`,
  `naf-persist`, `networked-resonance-audio`, `VRTourEditor`,
  `UnityVRAnimationEditor`, `freescuba`, `haritorax-slimevr-bridge`,
  `haritorax-interpreter`, `osc_haritorax2_camera_tracking`
  for VRCOSC module host boundaries, event-source queues, shared-room adapter
  contracts, WebXR/entity persistence, authoring/export primitives,
  driver-versus-sidecar tracker bridges, and diagnosable tracking fusion
  runtimes.
- `webxr-polyfill`, `WebXR-emulator-extension`, `xrview`,
  `webxr-input-profiles-loader`, `aframe-super-keyboard`,
  `aframe-physics-system`, `GodotXRVmcTracker`,
  `GodotXRAnimationRecorder`, `godot-xr-tools2`, `pmndrs/xr`,
  `pmndrs/uikit`, `webxr-playground`
  for WebXR runtime abstraction, emulator shells, controller-profile visual
  loaders, declarative component primitives, scene physics driver boundaries,
  Godot tracker/recorder bridges, modular toolkit nodes, React/Three XR store
  architecture, spatial UI layout/input, and interaction-lab shells.
- `wooglies`, `aframe-socket-io`, `MixedRealityToolkit-Unity`,
  `MixedReality-GraphicsTools-Unity`, `GMMenu`, `KurotoriUdonMenu`,
  `vlc-unity`, `libspatialaudio`, `Cavern`, `AudioLink`
  for shared-room presence/media adapters, layered spatial UI packages,
  permissioned in-world command menus, native media bridges, spatial audio
  renderer APIs, and global audio-reactive shader buses.
- `OpenXR-CTS`, `openxr-cts-runner`, `OpenXR-Docs`,
  `OpenXR-SDK-Source`, `StardustXR/core`, `StardustXR/molecules`,
  `StardustXR/asteroids`, `StardustXR/panel-item`,
  `StardustXR/wayland-service`, `StardustXR/gravity`,
  `UdonUtils`, `UdonProfiling`, `UdonAVLTree`, `UdonVehicleSync`,
  `examples-image-loading`, `vrchat-glb-loader`, `VRC-Picture-Loader`,
  `SyncTexture`, `AvatarImageReader`, `MixedReality-WorldLockingTools-Unity`,
  `MixedReality-WorldLockingTools-Samples`, `WorldLockingTools-Unreal`,
  `StereoKit.Samples.AzureSpatialAnchors`, `OpenXR-MixedReality`,
  `Microsoft-OpenXR-Unreal`, `Meta-OpenXR-SDK`,
  `unity-openxr-extensions`, `HTCC`, `motoc`, `HoloViveObserver`,
  `index_camera_passthrough`, `freecad-xr-workbench`,
  `createthis_vr_ui`, `mesh_maker_vr`, `unity_vr_ik_mecanim`
  for OpenXR conformance/diagnostic harnesses, StardustXR protocol-backed
  spatial desktop clients, Udon runtime substrate and prediction utilities,
  VRChat external content-ingress surfaces, spatial-stability stacks, vendor
  extension wrappers, purpose-bounded microhelpers, and XR creator workbench
  interactions.

## Highest-value next follow-up passes

If a new research wave should start soon, these remain especially strong next
directions:

1. `Overlay implementation references and overlay-first hosts`
2. `OpenXR capability-injection, passthrough extension, and runtime-side intervention tooling`
3. `Vision-based hand and body tracking bridges`
4. `Virtual display and repurposed output workflows`
5. `OpenVR capture, replay, and orchestration toolchains`
6. `Historical utility-suite recovery`
7. `Browser panoramic video players and projection-aware web playback`
8. `Creator-side synced video player frameworks and queue frontends`
9. `Engine-side stereo panoramic viewers and vendor playback samples`
10. `Transformed, volumetric, and nonstandard 3D video viewers`
11. `Microphone control, voice-input, and audio routing helpers`
12. `Immersive media playback and browser video shells`
13. `Spatial audio SDKs, renderers, and audio-object optimization`
14. `Creator-facing audio systems and world voice management`
15. `VRChat world-authoring toolkits and optimization helpers`
16. `VRChat world runtime infrastructure and per-player state helpers`
17. `VRChat camera, staging, and admin-control systems`
18. `VRChat interaction prefabs and utility UI`
19. `VRChat world persistence, inventory, and external-data bridges`
20. `VRChat creator diagnostics, editor inspection, profiling, and static analysis`
21. `VRChat embodied interaction, custom movement, and physical world mechanics`
22. `Udon data-structure libraries, serialization helpers, and creator utility foundations`
23. `VRChat creator starter baselines, test harnesses, and language-boundary experiments`
24. `Udon encoding, token, query, and structured-data micro-libraries`
25. `Udon sync, events, runtime logging, and shared helper micro-frameworks`
26. `VRChat world control gadgets, environmental systems, and specialized operator surfaces`
27. `VRChat avatar setup, optimization, and Quest portability`
28. `VRChat avatar composition, packaging, and install automation`
29. `VRChat avatar emulation, gesture preview, repair, and OSC-assisted posing`
30. `VRChat avatar text, speech, translation, and viseme sidecars`
31. `VRChat shader ecosystems, material translators, and visual-safety shaders`
32. `VRCFury toggle automation, avatar animator DSLs, and editor QoL overlays`
33. `VRCFaceTracking core, modules, templates, and blendshape preparation`
34. `VRChat avatar dynamics, PhysBone migration, contact prefabs, and in-game tuning`
35. `VRChat companion apps, OSC routers, plugin senders, data hubs, and web debug surfaces`
36. `SlimeVR server, tracker firmware, adapters, and calibration ecosystem`
37. `bHaptics SDKs, OSC bridges, relays, and telemetry-to-haptic adapters`
38. `No-HMD and virtual-HMD OpenVR helpers, phone bridges, and controllable driver stubs`
39. `WebXR browser API samples, input profiles, emulators, polyfills, and React/Three XR wrappers`
40. `Unity XR interaction/workflow toolkits, scientific rigs, training graphs, and Tilia composition`
41. `Meta Quest MR camera, depth, spatial-anchor, presence, and motif samples`
42. `Linux spatial desktop, Stardust workspace clients, and desktop-to-XR helpers`
43. `Godot XR engine toolkits, templates, backends, and vendor extension stacks`
44. `A-Frame WebXR components, inspectors, networked scenes, and hand UI`
45. `Unreal VR interaction toolkits, hand tracking, comfort, and tracker plugins`
46. `VR teleoperation headset frontends, robot bridges, and data capture`
47. `ALVR/WiVRn ecosystem sidecars, platform clients, and streaming helpers`
48. `XR glasses WebHID, virtual displays, and head-tracked desktop helpers`
49. `MediaPipe camera tracking bridges for SlimeVR, VRChat, VRM, and virtual controllers`
50. `Mixed reality capture, calibration, and presenter compositing helpers`
51. `VR treadmill locomotion hardware, input adapters, and virtual controller bridges`
52. `Unity VR experiment frameworks, data capture, and study orchestration helpers`
53. `Immersive browser shells, WebXR runtimes, home spaces, and spatial web frontends`
54. `Browser-native WebXR utility surfaces, creative tools, diagnostics, and data visualization`
55. `Quest app sideloading, modding, version management, and store metadata tooling`
56. `VMC/VRM motion-capture protocol, OSC transform receivers, and recording/export tools`
57. `Resonite/Neos modding, headless, external SDK, and social utility tooling`
58. `DIY open-source headset hardware bring-up, drivers, PCBs, and controller firmware`
59. `VR keyboard, text-entry, avatar keyboard, and OSC input surfaces`
60. `VR subtitles, captions, STT/OCR accessibility, and projection-aware subtitle tooling`
61. `SteamVR operational support, startup automation, dynamic performance, and Linux driver helpers`
62. `Focused overlay micro-surfaces, situational HUDs, and OCR-assisted workflow panels`
63. `Audience chat overlays, stream-facing browser surfaces, and captured-window HUD patterns`
64. `VR creative authoring, drawing/modeling tools, and in-headset tool/menu systems`
65. `Networked/social XR frameworks, room clients, and multi-user state substrates`
66. `OpenGloves sidecars, protocols, named-pipe input, OSC ingress, and force-feedback adapters`
67. `WebXR engine export bridges, device-display adapters, layers, and test/showcase scaffolds`
68. `Browser-based XR editors, live-coding sandboxes, visual workspaces, and scene tooling`
69. `VRM/avatar web stacks, model specs, runtime loaders, and browser avatar/mocap surfaces`
70. `WebAR marker/image tracking, model-viewer AR surfaces, and lightweight scene-understanding utilities`
71. `WebXR hand tracking, hand input surfaces, and hand-data bridges`
72. `Immersive 360 video players, stereo projection, and local media surfaces`
73. `Audio-reactive WebXR surfaces, spatial sound visualizers, and shader pipelines`
74. `WebXR runtime frameworks, session/input feature managers, and testable spatial UI substrates`
75. `A-Frame GUI, locomotion, and reusable interaction component primitives`
76. `Immersive analytics, spatial data visualization, and scientific viewer substrates`
77. `WebRTC remote rendering, WebXR streaming, and bidirectional input/control channels`
78. `Social/world framework shells, scene schemas, and multi-user spatial app substrates`
79. `Glanceable telemetry/status micro-overlays and simulator panels`
80. `Overlay host protocol bridges and minimal implementation baselines`
81. `Spatial-display runtimes, virtual displays, and no-HMD desktop fallback surfaces`
82. `Hand simulation, extension-level hand tracking, and reusable hand/control primitives`
83. `VRCFT/OpenXR face tracking, avatar preparation, and calibration`
84. `VRChat chatbox template, TTS, AI, and telemetry sidecars`
85. `Avatar-parameter telemetry, scaling, and companion protocol helpers`
86. `Wearable haptics, physical-output routers, and device-neutral event schemas`
87. `Rendering adaptation: foveation settings companions, API layers, DLL wrappers, and native VRS plugins`
88. `OSCQuery implementation matrix across C#, Rust, Python, sidecars, and direct-address fallbacks`
89. `Resonite creator import/export pipelines, component search UX, and metadata-rich capture artifacts`
90. `External pose/object/sensor ingress to VRChat OSC tracker endpoints and avatar parameters`
91. `Caption pipeline matrix across speech/OCR/translation, OBS, browser overlays, VRChat chatbox, and Unity/audience chat surfaces`
92. `Open Brush/Tilt asset pipeline map across raw .tilt, shader restoration, web viewers, conversion, and collaborative strokes`
93. `Gaussian splat utility matrix across browser editors, static WebXR viewers, Unity runtimes, native plugins, and VFX substrates`
94. `Godot XR function-node and OpenXR vendor feature/export matrices`
95. `Rust OpenXR app-shell matrix across Bevy, wgpu, custom-engine, and runtime-stub bring-up`
96. `VR retrofit safety matrix across injectors, managers, safe modes, compatibility gates, and patch groups`
97. `Marker tracking and remote hand-data matrix across Quest, PICO, HoloLens, Unity ArUco, and transport bridges`
98. `XR instrumentation and mocap matrix across record/replay, event timelines, physical-output bridges, and motion exports`
99. `Overlay substrate matrix across Electron shared textures, injected surfaces, modular overlay hosts, OpenXR layer engines, and Unity overlay baselines`
100. `OpenXR micro-layer starter matrix across protocol adapters, hand transform correction, graphics compatibility, and generated dispatch templates`
101. `Spatial-anchor persistence and colocation matrix across Meta Unreal, Magic Leap, ARFoundation storage, local/cloud states, and anchor-relative scenes`
102. `VRChat OSC diagnostics and sensor bridge matrix across web panels, passive listeners, OSCQuery browsers, typed libraries, finger tracking, and heart-rate SDKs`
103. `DIY eye/mouth tracking matrix across camera ROI, inference, calibration, smoothing, VRChat native output, VRCFT, OSC, and OpenXR/engine consumers`
104. `Resonite headless operations matrix across containers, web/Discord/REST control surfaces, shared-memory export, and compatibility patch risks`
105. `Accessibility simulation and VR menu accessibility matrix across gaze-contingent impairment shaders, mobile passthrough filters, patient masks, and spoken UI`
106. `Surface-ingress and media-output matrix across 360 screenshots, editor capture, window/desktop capture, Quest MediaProjection, photomode, and 360/stereo playback`
107. `VR text-entry matrix across WebView, mesh/UV, canvas texture, physical collider, hand-attached, A-Frame, and shell keyboard approaches`
108. `Shared WebXR room matrix across WebSocket signaling, WebRTC P2P, Unity Relay/NGO, socket.io/simple-peer, A-Frame chat, and spatial HUD presence`
109. `VR teleoperation safety and camera-feedback matrix across ROS, OpenVR operator shells, WebSocket command buffers, IK, modes, and stale/jump gates`
110. `DIY XR hardware boundary matrix across firmware packets, HID/BLE/serial transport, runtime drivers, haptics, CAD/BOM/PCB docs, and headset spec schemas`
111. `External surface ingress matrix across WebRTC, LiveKit, UDP point clouds, Quest MediaProjection, and native WebView surfaces`
112. `Locomotion/accessibility matrix across embodied wheel input, zero-G control, redirection gains, mode options, and input hubs`
113. `VR command surface matrix across radial menus, physical launchers, editor expression-menu tools, and desktop OSC macro companions`
114. `Biometric bridge compatibility matrix across BLE, ANT+, HTTP, OBS WebSocket, Hyperate, phone sensors, avatar parameters, and chatbox output`
115. `Voice-to-chatbox pipeline matrix across VAD, STT, translation, avatar control, and extensions`
116. `Chatbox composition matrix across media, lyrics, templates, status, keepalive, and tiny senders`
117. `Browser and phone OSC control matrix across local web APIs, WebSocket relays, avatar parameter discovery, and safety gates`
118. `VRC haptics event matrix across OSC contacts, server maps, firmware packets, hardware docs, presets, and tracker nodes`
119. `PSVR2 calibration, passthrough, gaze validity, and runtime-shim risk matrix`
120. `Physical-output bridge safety matrix across consent, cooldown, panic stop, and device actuation`
121. `MIDI backpressure, VRChat path schemas, and Udon live-performance sync matrix`
122. `Audience-event rule engines, reward lifecycle, moderation gates, and OSC action queues`
123. `Chatbox status composer privacy, template, and cadence matrix`
124. `External audio reactivity and sound-trigger matrix across loopback, OSCQuery soundpacks, media keys, and DSP engines`
125. `XSOverlay notification bridge payload, transport, and security matrix`
126. `Avatar remote-control and external state bridge safety matrix`
127. `VRCOSC module-pack trust, distribution, and compatibility matrix`
128. `Networked-AFrame adapter, persistence, media-stream, and ownership matrix`
129. `Lightweight XR authoring surface matrix across manipulation, serialization, undo, and export`
130. `ContactGlove and Haritora bridge protocol, calibration, and diagnostics matrix`
131. `WebXR runtime emulator, polyfill, and input-profile compatibility matrix`
132. `A-Frame component primitive matrix across schema, input, events, assets, and lifecycle`
133. `Godot XR addon matrix across hand pose, pickup, tracker source, recorder, toolkit node, and native interface`
134. `React/Three XR substrate matrix across runtime store, spatial UI, labs, and microtools`
135. `Overlay media micro-surface matrix across image notes, telemetry, browser shells, and direct video textures`
136. `XR glasses protocol and head-tracked desktop matrix across WebHID, native HID, calibration, and drift UX`
137. `Camera inference to avatar/tracker matrix across VRCFT, VRM, Unity named pipes, and virtual trackers`
138. `VR/WebXR control surface safety matrix across modes, HUDs, sidecars, telemetry, and watchdogs`
139. `Shared-room WebXR/A-Frame presence and media adapter matrix`
140. `MRTK spatial UI package boundary and alternate-input matrix`
141. `VRChat/Udon world menu package and operator-surface matrix`
142. `Immersive media/audio substrate boundary matrix`
143. `OpenXR conformance and diagnostics report matrix`
144. `StardustXR client stack and spatial desktop panel matrix`
145. `Udon runtime substrate, diagnostics, data-structure, and predictive sync matrix`
146. `VRChat external content ingress matrix across image, model, texture, and avatar-data carriers`
147. `World-locking and spatial-stability matrix across tracking frames, anchors, and bindings`
148. `Vendor OpenXR extension-wrapper matrix across lifecycle, feature gates, and build metadata`
149. `VR microhelper safety matrix across input translation, calibration, observer, and passthrough tools`
150. `XR creator workbench interaction matrix across CAD, menus, panels, files, snapping, and feedback`

## Current repository-maintenance priorities

Besides new research waves, the main repository-maintenance work now is:

- keep `project-registry.md` as the clear per-repository source of truth;
- keep `project-families.md` focused on synthesis instead of status ownership;
- keep `not-yet-studied-deeply.md` focused on active queueing;
- reduce archive pressure in front-door docs;
- preserve wave history without making every entry document chronological.

## If you need deeper history

For the full chronological archive, use:

- `program/README.md`
- `landscape/README.md`
- `landscape/vr-projects-master-index.md`
