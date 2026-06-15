# Wave 309 - VR Motion Capture, Pose Recording, BVH, Muscle Compression, and Body Tracker Samples

This wave studies VR motion capture and pose-recording projects as reusable
references for tracker ingestion, humanoid retargeting, controller/HMD capture,
playback injection, BVH interchange, muscle-space compression, body-tracker
inventory, calibration state, and vendor tracker diagnostics.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- roomscale HMD/controller mocap and avatar IK;
- pose and controller-state recording/playback;
- BVH export/import and humanoid bone mapping;
- muscle-value compression as an alternative animation representation;
- PICO motion tracker and body tracker sample flows.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `alexismorin/OpenMocap` | Unity roomscale avatar capture and recorder coupling | Studied | Minimal HMD/controller sampling, humanoid IK mapping, hip/head offset, and Unity Recorder integration |
| `andrewjc/VRRecorder` | SteamVR pose/controller-state recorder and playback injector | Studied | Text keyframe format, HMD/controller device proxies, and playback objects that replace live SteamVR tracking |
| `emilianavt/BVHTools` | Unity BVH recording/parsing/export utility | Studied | Compact skeleton/motion interchange boundary, humanoid bone renaming, Blender axis mode, and parser/recorder split |
| `gree/MuscleCompressor` | Muscle-space Humanoid motion compression reference | Partially studied | Product-level workflow for recording, compressing, loading, and converting Unity Humanoid motion data |
| `Pico-Developer/PICOMotionTrackerSample-Unity` | Vendor motion/body tracker sample and diagnostics UI | Studied | Tracker inventory, serial-number state, confidence feedback, calibration/battery UI, 24-joint body pose, CSV playback, and bone-length update |

## Code-Level Findings

### `alexismorin/OpenMocap`

- Interesting idea:
  a useful mocap baseline can be small: roomscale HMD/controller poses drive a
  humanoid IK rig while Unity Recorder captures the animated hierarchy.
- Code donor value:
  medium-high. `openMocapActor.cs` sets roomscale tracking, samples
  `InputTracking.GetNodeStates`, maps left/right XR hand poses to transforms,
  derives an HMD root and hip offset, applies animator body/hand/foot/look-at
  IK, and starts/stops an `AnimationRecorderSettings` capture from trigger
  threshold changes.
- Product reference value:
  high for quick avatar capture prototypes, teaching rigs, and motion data
  capture utilities where simplicity is more valuable than full-body accuracy.
- What to inspect next:
  recorder output settings, `canRecord` gating, duplicate left-hand block,
  foot placement limits, and migration away from older Unity XR APIs.
- Reusable pattern extraction:
  decouple `tracked nodes`, `avatar retargeting`, and `recording/export`.

### `andrewjc/VRRecorder`

- Interesting idea:
  a plain-text pose log can be valuable when paired with a playback layer that
  replaces live tracked devices inside a Unity scene.
- Code donor value:
  medium-high. `VRRecorder.cs` samples SteamVR HMD/controller matrices and
  `VRControllerState_t` every 0.01 seconds, stores time, matrix values,
  buttons, touches, axes, and object name, then writes one line per keyframe.
  `VRPlayer.cs` adds recorder proxies to HMD/left/right tracked objects,
  disables live SteamVR during playback, attaches playback devices, and changes
  the HMD camera into a monoscopic replay camera.
- Product reference value:
  high for QA replay, interaction regression review, training capture, and
  deterministic demonstrations.
- What to inspect next:
  schema/versioning, controller axis semantics, memory limits, replay timing,
  and safer live/playback session switching.
- Reusable pattern extraction:
  define recording as `timestamped pose + controller state + device identity`,
  and playback as a separate device-provider adapter.

### `emilianavt/BVHTools`

- Interesting idea:
  BVH is a useful interchange boundary when the recorder owns hierarchy
  construction and the parser stays Unity-independent.
- Code donor value:
  high. `BVHRecorder.cs` exposes frame rate, directory/filename,
  overwrite/catch-up/scripted API flags, humanoid bone enforcement, bone
  renaming, Blender axis mode, target avatar, root bone, and skeleton list.
  It can populate humanoid bones from `HumanBodyBones`, detect bones from
  `SkinnedMeshRenderer`, build a minimal hierarchy, and write offsets,
  channels, and motion frames. `BVHParser.cs` parses ROOT/JOINT/OFFSET/
  CHANNELS, channel order, frame count, frame time, and motion values without
  Unity runtime dependencies.
- Product reference value:
  high for motion interchange, offline tools, and reusable export modules.
- What to inspect next:
  translation-channel limitations, rest-pose assumptions, non-zero rotation
  caveats, humanoid mapping quality, and retargeting to non-humanoid rigs.
- Reusable pattern extraction:
  keep skeleton hierarchy, channel order, sample timing, and engine-specific
  transform conversion as separate layers.

### `gree/MuscleCompressor`

- Interesting idea:
  Unity Humanoid motion can be stored as compact muscle values instead of
  shipping large `.anim` clips.
- Code donor value:
  medium as a partial pass. The README documents recording motion while
  wearing VR gear, saving `.data` files under `StreamingAssets/Motion`,
  converting bytes to animation clips through `VRStudioLab>Bytes2Anim`, and
  claims major size reduction versus `.anim`. The visible tree includes
  VRM/UniGLTF/DVRSDK support and motion transform helpers, but the first pass
  did not isolate the full compressor core cleanly.
- Product reference value:
  high for long-session motion capture, avatar replay libraries, and storage
  constrained datasets.
- What to inspect next:
  actual muscle data schema, compression algorithm, QueTra/PICO capture path,
  Final IK dependency boundary, playback interpolation, and license/dependency
  constraints.
- Reusable pattern extraction:
  consider `tracked pose -> humanoid muscle vector -> compressed stream ->
  clip/replay adapter` as a reusable motion pipeline.

### `Pico-Developer/PICOMotionTrackerSample-Unity`

- Interesting idea:
  vendor tracker support needs a visible state model: serial numbers,
  confidence, connection count, calibration health, battery, assisted-tracker
  roles, and body-joint validity.
- Code donor value:
  high. `MotionTrackerSampler.cs` subscribes to motion tracker key actions,
  handles serial numbers, confidence events, particle feedback, offset JSON,
  `GetMotionTrackerLocations`, and `Application.onBeforeRender` updates.
  `MotionTrackingManager.cs` tracks connected devices by serial number,
  instantiates prefabs, updates setting panels/dropdowns, and removes
  disconnected trackers. `BodyTrackerSampler.cs` reads 24-joint body tracking
  poses, supports CSV playback in editor, records UI-driven data, draws cube
  joints/lines, maps rotations to joints, and updates bone lengths through the
  SDK. `UIMotionTrackerState.cs` exposes connection count, calibration state,
  and battery.
- Product reference value:
  very high for diagnostics overlays, tracker setup helpers, calibration
  wizards, and future device inventory panels.
- What to inspect next:
  SDK version compatibility, abnormal calibration handling, assisted tracker
  role UX, body-joint confidence/invalid-pose handling, and vendor fallback
  paths.
- Reusable pattern extraction:
  surface tracker state as inventory + confidence + calibration + battery +
  pose stream, not just as transforms.

## Reusable Pattern Extraction

- Pattern candidate:
  VR motion capture and pose recording boundary across live trackers, avatar
  retargeting, sampling, compression, playback, export, and calibration.
- Problem solved:
  mocap utilities often bind live device APIs directly to avatar animation and
  export. Reuse needs device capture, retargeting, recording, compression,
  playback, and diagnostics to remain independently replaceable.
- Reusable core:
  tracker/device inventory, pose sampler, controller-state sampler, confidence
  and calibration state, avatar retargeting layer, keyframe stream, schema or
  interchange exporter, playback provider, compression adapter, and UI for
  recording/session state.
- Source evidence:
  `alexismorin/OpenMocap`, `andrewjc/VRRecorder`, `emilianavt/BVHTools`,
  `gree/MuscleCompressor`, and
  `Pico-Developer/PICOMotionTrackerSample-Unity`.
- Abstraction boundary:
  keep vendor tracker APIs, tracking-state UI, avatar retargeting, raw pose
  recording, compressed storage, export format, and replay device provider
  separate.
- What not to copy:
  old SteamVR/XR APIs, unversioned text logs, hidden recording gates,
  vendor-heavy sample packages, or compression claims without isolating the
  schema and algorithm.
- Method catalog action:
  add a VR motion capture and pose-recording method.

## Follow-Up Gaps

- Build a capture/replay matrix for device type, sample clock, schema,
  compression, playback injection, avatar retargeting, and export target.
- Deepen `MuscleCompressor` to isolate the exact muscle stream and conversion
  code.
- Compare PICO tracker state UI with earlier battery/device-monitor and
  diagnostics waves.
- Compare BVH export with future OSC/WebSocket tracker bridges and body pose
  interchange formats.
