# Wave 306 - XR Testing, Simulation, Input Validation, and Performance Harnesses

This wave studies XR testing and simulation projects as reusable references for
feature inventory, input/haptics debugging, device-functional tests, display
assertions, spatial audio tests, performance metadata, and non-invasive editor
simulation backends.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- XR input/device/debugging test harnesses;
- functional tests for XR display, tracking, device, audio, and settings APIs;
- performance sample capture and build/run metadata;
- editor simulation backends and user simulation settings;
- dedupe against OpenXR conformance, diagnostics, runtime-tool, and
  training-evaluation waves.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `Unity-Technologies/XRInputTests` | Manual XR input and haptics test suite | Studied | XR device feature tree, haptics trigger UI, test scene driver, test-scene export, and minimum reproduction workflow |
| `Unity-Technologies/xr.sdk.functionaltests` | Automated XR functional test harness | Studied | NUnit/UnityTest assertions for tracking, display subsystem, XRDevice, audio source behavior, test stage setup, and platform/target exclusions |
| `Unity-Technologies/com.unity.xr.test-framework.performance` | XR performance test extension | Studied | Sample groups, profiler/custom metrics, test-run JSON, player/build/XR metadata, and result serialization |
| `needle-tools/ar-simulation` | Non-invasive XR/AR editor simulation backend | Studied as README-heavy product/architecture reference | Custom XR plugin backend for ARFoundation/editor iteration, simulated planes/images/point clouds/touch, and clear limits/license caveats |

## Code-Level Findings

### `Unity-Technologies/XRInputTests`

- Interesting idea:
  XR input debugging benefits from both a live device-feature inspector and
  portable single-scene repro exports.
- Code donor value:
  high. `XRInputDebugger.cs` builds editor TreeViews for connected
  `InputDevice`s, feature usages, feature values, haptic capabilities, impulse
  support, buffer support, amplitude/duration controls, and trigger buttons.
  `TestDriver.cs` persists across scene loads, cycles test scenes, moves to a
  camera anchor, and updates instruction UI from a `TestInstructions` object.
  `CreateTestDriver.cs` ensures a normal or AR driver exists in the scene.
- Product reference value:
  high for an `XR input doctor`, repro-package generator, controller/haptics
  diagnostic panel, and QA-facing headset test deck.
- What to inspect next:
  XR Tests editor panel implementation, export/min-repro workflow, haptics test
  scenes, shared test assets, and modern Input System equivalents.
- Reusable pattern extraction:
  combine live runtime inventory with scene-based repros, so users can both see
  current device state and isolate a failing feature.

### `Unity-Technologies/xr.sdk.functionaltests`

- Interesting idea:
  XR compatibility can be represented as a family of small automated assertions
  over display, input, tracking, device, audio, and settings behavior.
- Code donor value:
  high. `XrFunctionalTestBase.cs` creates camera/light/test-cube stages, cleans
  them up, switches stereo rendering paths in editor, skips frames, and ignores
  incompatible simulation/runtime modes. `XrInputTrackingTests.cs` validates
  head/eye node presence, user presence, feature values/usages, eye parallel
  geometry, and tracking events. `XrDisplayTests.cs` checks display running
  state, refresh rate, GPU/compositor timings, dropped frames, focus plane,
  mirror blit, and render texture access. `XrDeviceTests.cs` checks tracking
  origin, native pointer, device model, refresh rate, zoom factor, and camera
  tracking. `AudioSourceTests.cs` treats spatial audio controls as testable XR
  behavior.
- Product reference value:
  very high for a future `XR doctor`, validation matrix, and regression pack
  for prototype utilities.
- What to inspect next:
  custom attributes such as `ConditionalAssembly` and `TargetXrDisplays`,
  settings resource schema, CI/build target assumptions, and how tests report
  skipped/ignored cases.
- Reusable pattern extraction:
  write XR validation as small capability assertions with explicit runtime,
  platform, display, and emulation gates.

### `Unity-Technologies/com.unity.xr.test-framework.performance`

- Interesting idea:
  XR performance data is most reusable when it includes sample groups plus
  editor/player/build/XR metadata, not just raw frame-time numbers.
- Code donor value:
  high. `PerformanceTest.cs` records test name, categories, version, start/end
  times, sample groups, statistical values, JSON output markers, and metadata.
  `Measure.cs` exposes custom samples, scope timing, profiler marker
  measurement, method timing, and frame measurement. `PerformanceTestRunSaver.cs`
  registers test runner callbacks, writes `TestResults.xml`, parses
  performance runs, and stores `PerformanceTestResults.json`.
  `TestRunBuilder.cs` captures editor version, player settings, build target,
  graphics API, stereo rendering path, scripting backend, XR targets, runtime
  versions, render pipeline, test revisions, and Android architecture.
- Product reference value:
  very high for headset perf baselines, regression reports, and reproducible
  benchmark snapshots.
- What to inspect next:
  `PlayerCallbacks`, baseline comparison, JSON schema, metadata manager
  dependency, and how XR runtime settings are injected.
- Reusable pattern extraction:
  always attach environment/build/runtime metadata to XR performance samples.

### `needle-tools/ar-simulation`

- Interesting idea:
  an editor simulation backend can plug into XR provider architecture so
  ARFoundation apps can iterate without code changes or device deployment.
- Code donor value:
  medium/source-light in this pass. README-level material describes a custom
  XR plugin backend, ARFoundation compatibility, simulated planes/point clouds,
  tracked images, touch/click input, simulated environments, input-system
  support, and editor-only/non-invasive build boundaries.
- Product reference value:
  high for headsetless workflows, simulated-user testing, editor iteration,
  and local validation of spatial features.
- What to inspect next:
  package runtime/editor source, loader implementation, simulated trackable
  providers, touch injection, environment prefab schema, license boundaries,
  and multiplayer/desktop-build caveats.
- Reusable pattern extraction:
  keep simulation as a backend/provider layer, not as app-specific mock code.

## Reusable Pattern Extraction

- Pattern candidate:
  XR validation harness boundary across feature inventory, scene repros,
  automated functional assertions, performance sampling, metadata capture, and
  simulation backends.
- Problem solved:
  XR tools fail in device-specific ways. Manual testing alone misses regressions,
  while automated tests without inventory/simulation are hard to reproduce.
  Reuse needs a layered validation system that can observe, assert, measure,
  and simulate.
- Reusable core:
  device feature inventory, haptics capability panel, test-scene driver,
  single-scene export, functional test base, platform/runtime skip gates,
  display/input/device/audio assertions, sample group definitions, profiler
  markers, build/player/runtime metadata, result JSON, and provider-level
  editor simulation.
- Source evidence:
  `Unity-Technologies/XRInputTests`,
  `Unity-Technologies/xr.sdk.functionaltests`,
  `Unity-Technologies/com.unity.xr.test-framework.performance`, and
  `needle-tools/ar-simulation`.
- Abstraction boundary:
  keep live inspection, manual repro scenes, automated assertions, performance
  measurement, metadata capture, and simulation providers separate.
- What not to copy:
  running device tests as part of documentation research, editor-only
  assumptions in runtime code, perf samples without environment metadata,
  haptic triggers without user consent, or simulations that silently ship in
  production builds.
- Method catalog action:
  add an XR validation and simulation harness method.

## Follow-Up Gaps

- Deepen `XRInputTests` editor panel/export workflow.
- Deepen `com.unity.xr.test-framework.performance` result JSON and metadata
  schema for a possible `VR-apps-lab` validation report format.
- Inspect `needle-tools/ar-simulation` runtime/editor source if accessible
  under package release tags.
- Build an `XR doctor` matrix across live inventory, device tests, feature
  assertions, perf metrics, simulation, and report export.
