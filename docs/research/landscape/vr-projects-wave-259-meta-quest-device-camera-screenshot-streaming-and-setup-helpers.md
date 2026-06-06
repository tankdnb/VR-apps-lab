# Wave 259 - Meta Quest Device, Camera, Screenshot, Streaming, and Setup Helpers

This wave studies Meta Quest companion utilities and prototypes around
passthrough datasets, hand/eye tracking, camera workarounds, ADB setup,
screenshot ingestion, screen casting, registry patching, and device identity
microtools.

## Scope

The wave was bounded to projects that provide reusable Quest helper patterns:

- Quest capture or dataset pipeline;
- Unity or Python bridge around Quest sensors;
- desktop companion for camera/ML/screen mirroring;
- ADB or registry setup microtool;
- screenshot/media ingestion into Unity;
- eye-tracking recorder and analysis flow.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `t-34400/metaquest-3d-reconstruction` | Quest capture dataset pipeline | Studied | Reality Capture images/depth to Open3D/COLMAP reconstruction |
| `kodaekwan/MetaQuest_HandTracking` | Quest hand telemetry bridge | Studied | Unity/Quest hand packet receiver, coordinate transforms, visualizer |
| `lukasmoro/cameraaccess-metaquest` | Quest camera workaround | Studied | Casting/OBS virtual camera to Python YOLO to Unity over TCP |
| `CHUNx3/MetaQuestBitrateRegistryEditor` | Meta Link config patcher | Studied | Windows registry microtool for bitrate and Link tuning |
| `t-34400/MetaQuestScreenshotLoader` | Quest screenshot ingestion | Studied | Android Unity plugin loading latest Quest screenshot bytes |
| `hiroyamochi/quest-screen-caster` | Quest screen casting helper | Studied | GUI over scrcpy and ADB screenrecord with device guards |
| `XargonWan/metaquest-username-changer` | Quest username/config patcher | Studied | Bash/ADB JSON and global setting microtool |
| `SinanAkkoyun/OculusQuest2ADBAutoWifi` | Quest ADB Wi-Fi setup | Studied | Node CLI for USB-to-Wi-Fi ADB connection |
| `Clept0/Unity_QuestPro_EyeTrackingRecorder` | Quest eye-tracking recorder | Studied | Unity OVR eye-gaze logging, calibration scenes, and Python analysis |

## Code-Level Findings

### `t-34400/metaquest-3d-reconstruction`

- Interesting idea:
  treat Quest Reality Capture outputs as a structured offline dataset for
  reconstruction rather than as ad hoc screenshots.
- Code donor value:
  strong for project path layout, camera/depth directory contracts, confidence
  maps, coordinate-system conversions, COLMAP export, Open3D trajectory/depth
  filtering, and reconstruction cache flags.
- Product reference value:
  useful for future `Quest capture -> inspectable dataset -> reconstruction`
  tooling.
- What to inspect next:
  data capture instructions, supported Quest OS versions, and whether the
  pipeline can be decomposed into import/validate/export steps.
- Caveats:
  heavy offline research pipeline, QRC-specific, not a live overlay/tool.

### `kodaekwan/MetaQuest_HandTracking`

- Interesting idea:
  receive Quest/Unity hand and headset telemetry as fixed-size UDP packets and
  visualize transformed skeletons on desktop.
- Code donor value:
  strong for hand packet schema, Unity-left-handed to Python/right-handed
  coordinate transforms, bone link groups, delay measurement, and UDP JPEG
  chunking in adjacent stereo-stream utilities.
- Product reference value:
  useful for robotics, desktop debugging, and external hand-data bridge
  prototypes.
- What to inspect next:
  Unity sender source, packet versioning, reliability, and transform
  calibration UI.
- Caveats:
  hardcoded IPs, sparse transmitter source, robotics-oriented assumptions, and
  UDP reliability limits.

### `lukasmoro/cameraaccess-metaquest`

- Interesting idea:
  when direct Quest camera access is unavailable, route Quest cast through OBS
  virtual camera to desktop ML, then send detected objects back to Unity over
  TCP.
- Code donor value:
  useful for pragmatic companion architecture: virtual camera source, YOLO
  detection, JSON-like socket stream, and Unity client consumption.
- Product reference value:
  clear workaround path for prototypes that need passthrough-derived computer
  vision without privileged camera APIs.
- What to inspect next:
  latency measurement, schema hardening, user permission language, and direct
  camera API alternatives.
- Caveats:
  manual OBS/casting setup, login/privacy issues, latency, and fragile virtual
  camera routing.

### `CHUNx3/MetaQuestBitrateRegistryEditor`

- Interesting idea:
  package Meta/Oculus Link registry tuning into a small restore-capable GUI.
- Code donor value:
  useful for config patcher shape: read known vendor keys, validate numeric
  input, toggle booleans, restore by deleting override values, and surface
  state in a WinForms UI.
- Product reference value:
  a narrow device-helper can be valuable if it names the risky setting it
  changes and offers rollback.
- What to inspect next:
  exact registry key stability, admin requirement, backup/export path, and
  modern Link/Air Link behavior.
- Caveats:
  registry edits are risky and version-sensitive.

### `t-34400/MetaQuestScreenshotLoader`

- Interesting idea:
  use an Android Java plugin to request storage permission, find the latest
  Quest screenshot, return bytes to Unity, and load them into a texture.
- Code donor value:
  strong for Unity-to-Android plugin boundary, permission callback, byte-array
  media ingestion, and main-thread Unity texture loading.
- Product reference value:
  useful for prototypes that bootstrap camera/media workflows from the user
  screenshot gesture.
- What to inspect next:
  Android scoped-storage compatibility and MediaStore vs filesystem paths.
- Caveats:
  relies on user/system screenshot flow and changing Android storage rules.

### `hiroyamochi/quest-screen-caster`

- Interesting idea:
  provide a Quest-specific GUI over scrcpy and ADB screenrecord, with model
  detection, crop presets, wireless connect, ADB reset, and screenrecord
  guards.
- Code donor value:
  strong for device discovery, `getprop ro.product.model`, ADB tcpip/connect,
  screen wake/proximity disable, lingering screenrecord cleanup, display-id
  fallback, ffplay low-latency flags, OBS UDP output mode, and model-specific
  scrcpy crop/rotation/scale offsets.
- Product reference value:
  excellent Quest helper reference because it wraps sharp command-line tools in
  a user-facing operator surface.
- What to inspect next:
  device safety, multilingual UI polish, dependency packaging, and whether the
  screenrecord/ffplay backend can become a generic capture adapter.
- Caveats:
  uses ADB commands that alter power/proximity behavior, depends on scrcpy and
  ffmpeg/ffplay, and has device/model-specific tuning.

### `XargonWan/metaquest-username-changer`

- Interesting idea:
  a tiny ADB script can patch several username JSON files and set a global
  Quest username value.
- Code donor value:
  low-to-medium donor for config patch microtool shape: prompt/input, generate
  files, push to `/sdcard/`, and update device settings.
- Product reference value:
  useful as a warning-rich example of a one-purpose device patcher.
- What to inspect next:
  which apps read the generated JSON files, rollback, and whether newer Quest
  OS versions still honor the global setting.
- Caveats:
  README warns progress can reset for some games; scripts that patch identity
  should require explicit backup and confirmation.

### `SinanAkkoyun/OculusQuest2ADBAutoWifi`

- Interesting idea:
  reduce ADB Wi-Fi setup to a single Node CLI that waits for USB, switches the
  device to TCP mode, extracts IP from `adb shell ip route`, and connects.
- Code donor value:
  useful for onboarding flow, device-list parsing, already-connected detection,
  wait loop, and route-based IP discovery.
- Product reference value:
  shows that small setup helpers can remove repeated friction from Quest
  development workflows.
- What to inspect next:
  robust path selection, multiple devices, disconnection states, and platform
  support beyond a hardcoded Unity ADB path.
- Caveats:
  hardcoded Unity editor path logic, fragile regex/IP assumptions, and no
  broad device-selection UI.

### `Clept0/Unity_QuestPro_EyeTrackingRecorder`

- Interesting idea:
  record Quest Pro OVR eye-gaze transforms during calibration/stabilization
  scenes, export CSV, and analyze gaze error offline in Python.
- Code donor value:
  strong for `OVREyeGaze` sampling, left/right eye CSV schema, confidence
  fields, calibration scene sequencing, persistent-data export, raycast heatmap
  particle visualization, and Python gaze-point/error analysis.
- Product reference value:
  useful reference for research-oriented VR data capture and evaluation loops.
- What to inspect next:
  consent, data format cleanup, package boundaries, and headset/runtime
  compatibility outside Quest Pro/Quest Link.
- Caveats:
  Unity sample includes many bundled assets, depends on OVR eye tracking and
  Quest Link setup, and analysis scripts assume local dataset names.

## Reusable Pattern Extraction

- Pattern candidate:
  Quest companion helper boundary across device setup, media capture, sensor
  data, and desktop processing.
- Problem solved:
  many Quest workflows need desktop-side helpers because raw device APIs,
  media access, ADB setup, Link settings, or sensor streams are not smooth
  inside a single app.
- Reusable core:
  device discovery, permission/ADB gate, version/model detection, capture or
  sensor adapter, transport/schema, desktop processing, operator UI, rollback,
  privacy warning, and cleanup.
- Source evidence:
  reconstruction datasets, hand UDP receivers, OBS/cast camera workaround,
  registry editor, screenshot loader, screen caster, username patcher, ADB
  Wi-Fi setup CLI, and eye-tracking recorder.
- Abstraction boundary:
  Quest helpers should keep dangerous device/config operations separate from
  capture/processing and from the user-facing operator surface.
- What not to copy:
  hidden setting edits without backup, identity patching without warnings,
  direct camera workarounds without privacy language, hardcoded ADB paths,
  unversioned packet schemas, and massive sample assets as reusable code.
- Method catalog action:
  create a new Quest device-helper method tied to capture, setup, and sensor
  workflows.

## Family Placement

This wave creates a Quest companion capture, telemetry, and setup helper
family. It overlaps with Meta MR samples, surface-ingress, WebRTC/camera
workflows, sensor bridges, and research data capture, but the practical center
is the companion utility boundary around a Quest device.

## Backlog Impact

- Build a Quest helper safety checklist covering ADB, storage permissions,
  registry edits, power/proximity changes, and identity/config patches.
- Compare Quest capture paths: screenshots, cast/OBS virtual camera,
  screenrecord/scrcpy, Reality Capture datasets, and plugin media access.
- Add a future matrix for Quest sensor streams: hands, eye gaze, depth, camera,
  screenshots, and desktop ML feedback.
