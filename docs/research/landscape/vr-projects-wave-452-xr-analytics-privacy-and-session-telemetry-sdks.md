# Wave 452: XR analytics privacy and session telemetry SDKs

- Date: `2026-07-13`
- Scope: code-level reading pass over XR analytics SDKs and privacy-gated
  telemetry packages.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `CognitiveVR/cvr-sdk-unity` | Studied | XR analytics SDK and session telemetry |
| `CognitiveVR/xrprivacyframework-unity` | Studied | XR privacy consent and data-category gating |
| `CognitiveVR/c3d-sdk-webxr` | Studied | WebXR analytics SDK and engine adapters |
| `CognitiveVR/cvr-sdk-unreal` | Studied | Unreal analytics SDK and Blueprint/C++ adapter |

## Why this wave matters

Earlier analytics coverage already included `informXR`,
`ArborXR/abxrlib-for-unity`, and `GossipAnalyticsXR`. This wave adds a
provider-family that exposes a more explicit telemetry surface: session
lifecycle, dynamic objects, gaze, sensors, boundary, controller input, exit
polls, media/audio, room capture, remote controls, and privacy categories.

## Project notes

### `CognitiveVR/cvr-sdk-unity`

- Interesting idea:
  package XR analytics as a Unity SDK with editor setup, feature builder,
  runtime manager prefab, active-session visualization, dynamic objects, gaze,
  sensors, exit polls, room capture, remote controls, and multiple tracking
  components.
- Code donor value:
  strong reference for separating `Cognitive3D_Manager`, preferences, network
  endpoints, custom events, dynamic object snapshots, gaze/fixation recording,
  sensor recording, analytics components, and editor feature installers.
- Product reference value:
  shows analytics as an operator-configured feature set instead of a hidden
  background logger.
- Source evidence:
  `Runtime/Scripts/Cognitive3D_Manager.cs`,
  `Runtime/Internal/NetworkManager.cs`,
  `Runtime/Internal/CustomEvent.cs`, `Runtime/Internal/SensorRecorder.cs`,
  `Runtime/Scripts/DynamicObject.cs`, `Runtime/Scripts/PhysicsGaze.cs`,
  `Runtime/ExitPoll/Scripts/*`, `Runtime/Components/*`,
  `Editor/ProjectSetupWindow.cs`, and `Editor/Features/*`.
- Reusable core:
  session identity, scene/version metadata, event batch queues, dynamic object
  identity, gaze/fixation samples, sensor payloads, exit poll surfaces, feature
  enablement UI, and privacy-aware optional collectors.
- What not to copy:
  provider credentials, endpoint URLs, dashboard-specific payload assumptions,
  or large plugin/editor bulk.
- What to inspect next:
  exact payload schemas, offline queue behavior, failure/retry policy, and how
  privacy-framework categories gate each collector.

### `CognitiveVR/xrprivacyframework-unity`

- Interesting idea:
  a small consent package that exposes user choices as typed XR data
  categories: hardware, spatial, location, social, bio, audio, and room
  capture.
- Code donor value:
  useful minimal API shape: `IXRPFProvider`, `PrivacyFramework.Agreement`,
  `SetNewAgreement`, null-deny defaults, and change event notification.
- Product reference value:
  shows a reusable in-headset privacy agreement surface that can be styled and
  configured by data category.
- Source evidence:
  `Runtime/XRPrivacyFramework.cs`, `Samples~/CodeSamples/LoopingComponent.cs`,
  and the sample agreement canvas described in `readme.md`.
- Reusable core:
  data-category registry, default-off/null agreement, consent-changed event,
  required/default/unused UI flags, privacy-policy link, and collector-side
  checks before recording sensitive data.
- What not to copy:
  legal wording, vendor branding, or the assumption that a single popup is
  enough for every jurisdiction or study protocol.
- What to inspect next:
  persistence model, localization, revocation flow, and integration with
  telemetry SDKs other than Cognitive3D.

### `CognitiveVR/c3d-sdk-webxr`

- Interesting idea:
  WebXR analytics core with feature modules and thin adapters for Three.js,
  Babylon.js, PlayCanvas, and Wonderland Engine.
- Code donor value:
  strong JavaScript/TypeScript reference for modular telemetry collectors:
  gaze tracker, custom events, dynamic objects, sensors, exit poll, controller
  tracking, controller input, boundary, framerate, HMD orientation, profiler,
  environment detection, and WebXR reference-space fallback.
- Product reference value:
  proves analytics can be engine-neutral in WebXR if the engine adapters own
  scene/object extraction while the core owns session/batch/network semantics.
- Source evidence:
  `src/core.ts`, `src/index.ts`, `src/network.ts`, `src/gazetracker.ts`,
  `src/customevent.ts`, `src/dynamicobject.ts`, `src/sensors.ts`,
  `src/utils/webxr.ts`, `src/utils/ControllerTracker.ts`,
  `src/utils/ControllerInputTracker.ts`, and `src/adapters/*`.
- Reusable core:
  singleton analytics core, feature-module composition, `setScene` /
  `startSession` / `endSession`, batch sizes, changed session properties,
  deterministic dynamic-object IDs, and adapter boundaries.
- What not to copy:
  provider API calls, hard-coded batch defaults, or dashboard-specific object
  identity assumptions.
- What to inspect next:
  adapter payload differences, local-floor/local fallback behavior, and consent
  or opt-out hooks for browser XR.

### `CognitiveVR/cvr-sdk-unreal`

- Interesting idea:
  Unreal plugin packaging for the same analytics domain with C++ and Blueprint
  support.
- Code donor value:
  useful mostly as cross-engine comparison for plugin/module boundaries rather
  than as direct donor code.
- Product reference value:
  confirms that analytics features should be represented as engine-neutral
  concepts with per-engine adapters.
- Source evidence:
  `Cognitive3DTest/Plugins/Cognitive3D/Source/*`,
  `Cognitive3DEditor.Build.cs`, and update scripts for Unreal versions.
- Reusable core:
  engine plugin packaging, editor/runtime module split, Blueprint-facing
  analytics actions, and engine-version migration scripts.
- What not to copy:
  Unreal plugin internals unless a future Unreal branch is being built.
- What to inspect next:
  Blueprint API surface, feature parity with Unity/WebXR, and engine-version
  upgrade strategy.

## Reusable pattern extraction

- Pattern candidate:
  `privacy-gated XR telemetry SDK`.
- Problem solved:
  collect useful XR session telemetry without making every tracker a hidden,
  always-on collector.
- Reusable core:
  session lifecycle, scene/version metadata, collector modules, event/gaze/
  sensor/dynamic object batches, engine adapters, feature setup UI, privacy
  category checks, retry/flush state, and operator debug surfaces.
- Abstraction boundary:
  app owns consent and event semantics; telemetry SDK owns batching and
  transport; provider dashboard owns storage and analysis.
- Method catalog action:
  create a new method for privacy-gated XR telemetry.

## Caveats

- These SDKs are provider-bound and should be used as architecture references,
  not copied wholesale.
- Privacy APIs are technical gates, not legal compliance by themselves.
- Analytics code can collect sensitive XR data; future utilities need visible
  consent, opt-out, retention, and debug labels.

