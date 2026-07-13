# Wave 367: XR Analytics Action Recording Telemetry SDKs and Immersive Data Surfaces

## Scope

This wave studies XR analytics and data-surface projects: action recording,
spatial context capture, telemetry APIs, assessment/objective events, storage,
debug/exit-poll tools, LLM-assisted analysis, and 3D data visualization.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `yoonsang0910/ExplainableXR` | Studied | UAD action recorder with discrete/continuous action IDs, user/location/time/action/intent/source/referent/context fields, microphone/audio/image/object capture, processor, and dashboard direction |
| `ArborXR/abxrlib-for-unity` | Studied | Open-source XR analytics SDK with assessment/objective/interaction events, telemetry, storage, device/org metadata, QR scanner, editor config, and backend protocol framing |
| `informXR/iXRLibForUnity` | Studied | XR analytics SDK with authentication, events, object/system/input tracking, debug window, exit poll, keyboard UI, and post-build/config tooling |
| `stonecodecs/visiograph` | Studied | Unity data visualizer with TCP batch ingestion, main-thread data-point creation, camera/player input, selection/teleport markers, and collider gating |
| `eliaCandela/Optimizing-Data-Visualization-Through-Virtual-Reality` | Source-light marker | Business-metrics VR data visualization direction with alerts and immersive chart framing but little source content in cloned tree |

## Reusable Pattern Extraction

- Pattern candidate: `XR action telemetry and analytics event schema`.
- Problem solved: XR apps need analytics that understand spatial actions,
  context, referents, devices, assessments, and privacy rather than flat button
  clicks.
- Reusable core: session/user ID, device metadata, discrete/continuous action
  IDs, action verb, intent, trigger source, pose/location, referent object,
  referent transform, context capture, audio/image/object artifacts, assessment
  events, objective events, telemetry channel, storage, debug panel, exit poll,
  export/upload adapter, and dashboard/processor boundary.
- Source evidence: ExplainableXR defines `UserActionDescriptor`, action types,
  trigger sources, microphone capture, screenshots, object GLB export, and
  processor/dashboard modules; ABXR exposes assessment, objective, telemetry,
  storage, module, AI proxy, device/org metadata, and QR scan APIs; iXR exposes
  object/system/input tracking, debug window, exit polls, and config tooling;
  visiograph receives TCP data batches and creates 3D datapoints on the Unity
  main thread.
- Abstraction boundary: collection schema should be backend-neutral; upload,
  dashboard, AI analysis, and in-headset data visualization should be optional
  adapters.
- What not to copy: tokens/secrets, always-on capture, unclear consent,
  backend lock-in, per-frame logging without sampling policy, or dashboards
  without anonymization/export rules.
- Method catalog action: create an XR analytics event schema method.

## Project Notes

### `yoonsang0910/ExplainableXR`

- Interesting idea: user actions are recorded as a rich 5W1H descriptor that
  links who, where, when, what, why, how, referent, transform, and context.
- Code donor value: very high for action schema, continuous action lifecycle,
  microphone/image/object capture, sample trackers, and processor/dashboard
  split.
- Product reference value: strong for study recording, replay, AI analysis, and
  privacy-aware analytics tooling.
- What to inspect next: output schema stability, anonymization, dashboard code,
  and LLM prompt boundaries.
- Caveats: OpenAI/API and platform setup required; do not copy credentials or
  hidden capture defaults.

### `ArborXR/abxrlib-for-unity`

- Interesting idea: analytics are packaged as an SDK with assessment,
  objective, interaction, telemetry, storage, module, device/org metadata, QR,
  and backend protocol surfaces.
- Code donor value: very high for public API shape, configuration/editor
  tooling, telemetry/storage channels, and token safety notes.
- Product reference value: strong for enterprise/training XR instrumentation.
- What to inspect next: protocol schema, offline buffering, consent UI, and
  backend-neutral implementation.
- Caveats: service-adjacent SDK; reuse event taxonomy and boundaries, not
  vendor dependency assumptions.

### `informXR/iXRLibForUnity`

- Interesting idea: the SDK combines event tracking with input/device/system
  tracking, debug windows, exit polls, keyboard UI, and build/config helpers.
- Code donor value: high for runtime tracking components and operator/debug
  surfaces.
- Product reference value: useful for training analytics and post-session
  feedback.
- What to inspect next: auth flow, event schema, privacy defaults, and exit poll
  UX.
- Caveats: vendor SDK; isolate the neutral telemetry model.

### `stonecodecs/visiograph`

- Interesting idea: a simple TCP data bridge streams batches into Unity, then
  materializes rows as 3D points on the main thread.
- Code donor value: moderate for data ingestion, batching, and data-point
  creation boundaries.
- Product reference value: useful for immersive analytics surfaces and
  data-space navigation.
- What to inspect next: labels/colors, schema negotiation, large dataset
  performance, and VR input integration.
- Caveats: early prototype; current input is mouse/keyboard-oriented.

### `eliaCandela/Optimizing-Data-Visualization-Through-Virtual-Reality`

- Interesting idea: a business-metrics VR dashboard can surface dynamic charts
  and alert states in immersive space.
- Code donor value: low in this pass because the cloned tree was source-light.
- Product reference value: useful as a direction marker for alert-aware
  dashboard UX.
- What to inspect next: whether source is in another branch/release, chart data
  schema, and alert state model.
- Caveats: do not promote as donor until richer source is available.

## Product Direction

This wave supports an `XR analytics backbone` branch: future VR utilities can
share a neutral action/telemetry schema, consent model, storage/export adapter,
and optional dashboard or in-headset data surface.

