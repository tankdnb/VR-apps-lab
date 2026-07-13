# VR Projects Wave 411 - VR Capture Remote Mocap And Live Production Helpers

- Date: `2026-07-13`
- Scope: capture control, mixed-reality creator tooling, mocap live-link
  bridges, and production helper surfaces around VR workflows.
- Rule: source/documentation reading only; no builds, installs, launches, ADB
  commands, headset actions, or device tests were performed.

## Shortlist

- `GregMadison/quest-capture-remote`
- `LIV/BoneworksLIV`
- `pnmocap/Neuron_Mocap_Live_Unity`
- `Rokoko/rokoko-studio-live-unity`

## Why This Wave Matters

Creator tooling is a strong VR utility direction: start/stop capture, change
recording quality, pull media, route spectator cameras, stream mocap actors,
and control external production software. The reusable pattern is a control
plane around VR/creator state, not the exact app-specific integration.

## Project Notes

### `GregMadison/quest-capture-remote`

- Interesting idea: Android phone remote for Meta Quest recording that controls
  capture over wireless ADB without installing anything on the headset.
- Architecture pattern: Kotlin/Compose UI builds a capture preset; controller
  applies `debug.oculus.capture.*` properties, starts/stops Meta's internal
  recorder service, lists captures, and pulls MP4s from headset storage.
- Code donor value: strong control-plane reference for headset settings,
  capture presets, network/ADB connectivity checks, media listing/download, and
  user-safe toggles.
- Product reference value: excellent micro-utility model: one narrow creator
  problem, phone-first UX, obvious start/stop affordance, capture list, and
  headset status.
- Source evidence: `CapturePreset.kt`, `QuestController.kt`,
  `QuestFinder.kt`, `UsbAdb.kt`, `MainViewModel.kt`, and `MainActivity.kt`.
- Reusable core: external companion app sends bounded command presets to a
  headset/runtime service and mirrors result state back to the user.
- What not to copy: raw ADB/property commands should remain device-specific and
  gated by explicit capability checks.
- What to inspect next: design a generic `headset control plane` abstraction for
  capture, metrics HUD, proximity/guardian toggles, and media pull.

### `LIV/BoneworksLIV`

- Interesting idea: MelonLoader mod injecting LIV mixed-reality/spectator camera
  support into Boneworks.
- Architecture pattern: mod initializes IL2CPP/LIV types, loads LIV bridge
  assets, creates a `LIV` object, assigns HMD camera and MR camera prefab,
  configures volumetric SDK/stage/layer masks, and patches game camera points.
- Code donor value: useful camera/spectator injection reference: cloned camera
  prefab, layer-mask control, avatar/body visibility management, audio capture,
  lifecycle reset, and patch-bound integration.
- Product reference value: validates creator-facing capture support as a
  separate layer that can wrap an existing app without changing core gameplay.
- Source evidence: `BoneworksLivMod.cs`, `BodyRendererManager.cs`, `GameLayer.cs`,
  `LIV/LIV.cs`, `LIVVolumetricGameSDK/*`, and SDK audio capture classes.
- Reusable core: spectator/MR camera adapter with explicit player visibility,
  capture layers, and lifecycle hooks.
- What not to copy: game-specific mod hooks, bundled SDK assets, and
  MelonLoader/IL2CPP specifics.
- What to inspect next: compare with mixed-reality capture calibration waves for
  a reusable spectator-camera checklist.

### `pnmocap/Neuron_Mocap_Live_Unity`

- Interesting idea: Unity bridge for streaming Axis Studio/Perception Neuron
  mocap into animated avatars, transforms, rigidbodies, and trackers.
- Architecture pattern: `MocapApiManager` owns TCP/UDP connection reuse,
  skeleton settings, event polling, avatar/tracker updates, and actor
  acquisition; instances apply frames to Animator, Transform, or physical
  Rigidbody targets.
- Code donor value: strong live-link reference for connection pooling,
  skeleton-type branching, actor identity, event-driven updates, transform
  caches, physics update modes, and tracker/ridgidbody mapping.
- Product reference value: useful for future tracker bridges, live avatar
  previews, calibration panels, and mocap diagnostics.
- Source evidence: `MocapApiManager.cs`, `NeuronActor.cs`,
  `NeuronAnimatorInstance.cs`, `NeuronTransformsInstance.cs`,
  `NeuronTracker.cs`, and `NeuronDataReaderManaged.cs`.
- Reusable core: mocap stream adapter that separates transport/session,
  actor/tracker model, and scene application target.
- What not to copy: vendor SDK/API specifics and legacy Unity assumptions.
- What to inspect next: extract a vendor-neutral mocap actor/tracker frame
  schema.

### `Rokoko/rokoko-studio-live-unity`

- Interesting idea: Unity plugin for receiving Rokoko Studio live data and
  controlling Studio recording/calibration through a command API.
- Architecture pattern: UDP receiver decodes JSON v3 live frames; manager
  instantiates or overrides actor/prop prefabs; actor/face components map body,
  gloves, props, and ARKit-style blendshapes; command API posts HTTP requests.
- Code donor value: strong reference for live mocap JSON schema, actor/prop
  prefab pooling, face blendshape mapping, override profiles, Command API
  controls, and error messages.
- Product reference value: shows how a creator tool should combine data ingest
  with operator controls like record/stop/calibrate.
- Source evidence: `StudioReceiver.cs`, `UDPReceiver.cs`,
  `JsonLiveSerializerV3.cs`, `StudioManager.cs`, `Actor.cs`, `Face.cs`,
  `RokokoHelper.cs`, `PrefabPool.cs`, and `StudioCommandAPIBase.cs`.
- Reusable core: live production bridge with receive path plus command path.
- What not to copy: LGPL/license implications and Rokoko-specific naming/API
  endpoints need isolation.
- What to inspect next: compare with VMC/OSC/mocap waves for a common live
  actor/prop/face mapping model.

## Extracted Method Candidate

`Creator capture control plane and live mocap bridge`: expose capture, spectator
camera, mocap actor, prop, face, and recording controls as a bounded operator
surface, while isolating device/vendor commands behind adapters.

## Follow-Up

- Revisit Waves 90, 123, 129, 179, 210, and 361 for capture/mocap/live
  production overlap.
- Consider future reuse plans for `headset capture companion` and
  `vendor-neutral live actor frame`.
