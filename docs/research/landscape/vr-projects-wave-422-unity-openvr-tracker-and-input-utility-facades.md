# VR Projects Wave 422 - Unity OpenVR Tracker And Input Utility Facades

- Date: `2026-07-13`
- Theme: Unity-facing OpenVR tracker, pose, input, UI, and interaction facades.

## Shortlist

| Project | Study status | Why it matters |
|---|---|---|
| `gpsnmeajp/EasyOpenVRUtil` | Studied | Utility layer for direct OpenVR access from Unity, including trackers/controllers, battery, screenshots, device lists, and non-VR pose access |
| `ebadier/ViveTrackers` | Deepened from follow-up queue | Small Unity tracker library with manager/list model, fake manager, calibration save/load, pogo-pin events, and no-HMD documentation |
| `VRMADA/ultimatexr-unity` | Studied | Broad Unity VR framework with UI pointers, keyboard prefabs, interaction, locomotion, avatar, haptics, and cross-platform guides |

## Cross-Project Synthesis

This wave focuses on Unity utility facades: turn low-level OpenVR/XR details
into reusable scene components, data records, and input modules. The projects
range from direct OpenVR helpers, through tracker-specific libraries, to a broad
interaction framework.

Reusable pattern:

- separate low-level runtime calls from Unity components;
- maintain tracker/device inventory and stable serial mapping;
- support no-HMD or fake/simulator development modes;
- surface poses, buttons, calibration, UI pointers, and keyboard interactions
  as scene-level primitives.

## Project Notes

### `gpsnmeajp/EasyOpenVRUtil`

- Interesting idea:
  bypass awkward SteamVR plugin input paths when a Unity utility simply needs
  direct device pose, tracker serial, battery, screenshot, or device-list data.
- Code donor value:
  README documents direct OpenVR access for controllers/trackers, serial
  identification, battery, screenshots, device list, and non-VR applications
  that still read tracker/controller poses.
- Product reference value:
  useful reference for diagnostic and helper tools that need OpenVR device data
  without becoming full VR experiences.
- Source evidence:
  README explicitly describes reading controller/tracker coordinates, serial
  identification, battery level, VR screenshots, device inventory, and tracker
  poses from non-VR apps.
- Reusable core:
  direct OpenVR utility facade, device inventory, pose/battery/screenshot
  commands, serial lookup, and Unity wrapper API.
- What not to copy:
  quick-prototype caveats, old SteamVR plugin dependency assumptions, or
  Japanese-only docs without translated operator notes.
- What to inspect next:
  wiki usage examples, EasyOpenVRActionInput companion, error handling, and
  OpenXR equivalent mapping.

### `ebadier/ViveTrackers`

- Interesting idea:
  keep Vive Tracker use small and explicit: manager, tracker objects, optional
  CSV whitelist, calibration, simulated manager, and button events.
- Code donor value:
  `Scripts/ViveTrackersManager.cs`, `ViveTrackersManagerBase.cs`,
  `ViveTrackersManagerFake.cs`, `ViveTracker.cs`, and
  `ViveTrackersTest.cs` define a compact tracker lifecycle and no-HMD
  development path.
- Product reference value:
  strong reference for tracker-first utilities where tracker identity and
  calibration are more important than a whole interaction framework.
- Source evidence:
  README documents direct OpenVR usage, position/rotation updates, pogo-pin
  buttons, simulator, test scene, no-HMD setup, refresh/calibrate/save/load
  hotkeys, and CSV serial stability.
- Reusable core:
  tracker manager, tracker records, fake manager, calibration persistence,
  serial whitelist, hotkey/operator actions, and event callbacks.
- What not to copy:
  Unity 2017-era assumptions, test-scene-first UX, or tracker serial handling
  without migration and diagnostics.
- What to inspect next:
  PDF documentation, calibration math, serial CSV parsing, and event contracts.

### `VRMADA/ultimatexr-unity`

- Interesting idea:
  provide a broad Unity VR framework where locomotion, hand poses, haptics,
  avatars, manipulation, and UI input are reusable modules.
- Code donor value:
  `Runtime/Scripts/UI` contains laser pointers, fingertip/camera pointers, a
  pointer input module, custom raycasters, keyboard prefabs, shaders, and
  non-drawing graphics for VR UI.
- Product reference value:
  useful as a reference for mature framework boundaries and documentation
  shape, not something to absorb wholesale into `VR-apps-lab`.
- Source evidence:
  README lists cross-platform VR, manipulation, hand pose editor, locomotion,
  haptics, full-body IK avatars, UI interaction, and platform guides; source
  includes UI pointer modules and keyboard prefabs.
- Reusable core:
  modular package shape, UI pointer abstractions, keyboard prefab, platform
  guide matrix, and sample-scene organization.
- What not to copy:
  full framework scope, enterprise architecture weight, or platform-specific
  adapters before a smaller utility boundary is known.
- What to inspect next:
  `UxrPointerInputModule`, `UxrCanvas`, hand pose editor data, and locomotion
  module boundaries.

## Reusable Pattern Extraction

- Pattern candidate:
  `Unity tracker/input utility facade`.
- Problem solved:
  VR utility prototypes need reliable tracker/controller/UI data without being
  locked to one sample scene or one runtime plugin abstraction.
- Reusable core:
  runtime adapter, device inventory, stable IDs, pose polling, calibration,
  simulated mode, button events, Unity components, UI pointer modules, and
  operator diagnostics.
- Abstraction boundary:
  keep OpenVR/OpenXR reads behind a provider; expose Unity-facing records and
  components that can be swapped or simulated.
- Method catalog action:
  add new method for Unity tracker/input utility facades.

## Follow-Up Gaps

- Compare direct OpenVR, SteamVR plugin, Unity XR Interaction Toolkit, and
  OpenXR action-based equivalents.
- Build a neutral tracker record schema for future research docs.
- Track no-HMD/headsetless use cases separately from full VR app use cases.
