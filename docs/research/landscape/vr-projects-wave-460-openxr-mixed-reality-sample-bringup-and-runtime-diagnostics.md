# Wave 460: OpenXR mixed-reality sample bring-up and runtime diagnostics

- Date: `2026-07-13`
- Scope: Unity/OpenXR mixed-reality sample projects, runtime information
  panels, logs-in-headset, passthrough setup, controller input, remoting,
  ARFoundation compatibility, anchors, hand/eye/locatable-camera samples, and
  build/deploy helper boundaries.
- Rule: source/documentation reading only; no install, build, launch, or
  third-party smoke test.

## Frozen shortlist

| Repository | Status | Family placement |
|---|---|---|
| `microsoft/OpenXR-Unity-MixedReality-Samples` | Studied | OpenXR/MR sample suite |
| `olir/mr-openxr-unity-meta-passthrough-sample` | Deepened from partial | Quest OpenXR passthrough sample |

## Why this wave matters

The repository already tracks OpenXR setup and vendor workflows, but these
samples are useful as a bring-up pattern: visible runtime state, visible logs,
feature-specific sample scenes, and clear package/runtime caveats. That is
especially useful for future VR utilities that need to explain why a runtime,
display, input source, passthrough mode, anchor feature, or remoting mode is not
working.

## Project notes

### `microsoft/OpenXR-Unity-MixedReality-Samples`

- Interesting idea:
  official sample suite for Unity + Mixed Reality OpenXR with separate scenes
  for anchors, hand tracking, eye tracking, locatable camera, ARFoundation
  compatibility, Azure Spatial Anchors, and holographic remoting.
- Code donor value:
  strong donor for runtime diagnostic panels and sample-scene organization:
  runtime name/version, Unity/OpenXR plugin versions, display opacity/render
  mode/depth mode, and per-node tracking state are shown through `RuntimeInfo`.
- Product reference value:
  demonstrates a practical "bring-up cockpit" for OpenXR features where each
  feature has its own scene, readme, script, and visible state label.
- Source evidence:
  `README.md`, `SampleShared/Assets/Scripts/RuntimeInfo.cs`,
  `SampleShared/Assets/Scripts/DisplayUnityLogs.cs`,
  `SampleShared/Assets/Scripts/XrHelpers.cs`,
  `BasicSample/Assets/*`, and `AzureSpatialAnchorsSample/*`.
- Reusable core:
  sample hub, feature scenes, runtime info text provider, Unity log panel,
  OpenXR runtime/plugin version labels, XR display mode labels, head/hand
  tracking state, ARFoundation/OpenXR compatibility scenes, remoting sample,
  and tool-version matrix.
- What not to copy:
  Microsoft sample assets, trademark/docs wording, Git LFS bulk, or version
  recommendations without date/version labels.
- What to inspect next:
  `XrHelpers`, hand-joint managers, locatable camera flow, remoting connection
  state, and anchor sample persistence.

### `olir/mr-openxr-unity-meta-passthrough-sample`

- Interesting idea:
  small Quest 3 MR/OpenXR passthrough sample with project settings, build
  scripts, sideload helpers, manifest verification, OpenXR settings, and test
  result artifacts.
- Code donor value:
  useful as a "sample hygiene" comparison node: README names expected scenes,
  passthrough manager, input handler, manifest tools, and Android build path.
- Product reference value:
  shows that even thin MR samples should document passthrough permissions,
  runtime extension gates, build/sideload scripts, and troubleshooting state.
- Source evidence:
  `README.md`, `Packages/manifest.json`, `ProjectSettings/OpenXRSettings.asset`,
  `build.ps1`, `sideload.ps1`, `verify-manifest.ps1`,
  `TestResults*.xml`, and `Assets/_Shared/*`.
- Reusable core:
  feature checklist, OpenXR project settings, Android build helpers, manifest
  verification, passthrough safety notes, controller/head tracking framing, and
  test result artifacts.
- What not to copy:
  build/deploy scripts as-is, generated upgrade/test artifacts, or device claims
  beyond their documented Quest 3 scope.
- What to inspect next:
  actual `PassthroughManager` and `XRInputHandler` scripts, manifest mutation,
  and test coverage shape.

## Reusable pattern extraction

- Pattern candidate:
  `OpenXR feature bring-up cockpit`.
- Problem solved:
  make XR feature availability visible and debuggable by separating sample
  scenes, runtime labels, logs, setup requirements, and feature-specific
  troubleshooting.
- Reusable core:
  feature matrix, sample scene registry, runtime/plugin version label, display
  mode label, tracking-state label, log panel, setup version matrix, manifest
  check, build/deploy scripts, test artifacts, and feature caveats.
- Abstraction boundary:
  sample scene owns the feature; diagnostic panel owns runtime/state/logs;
  build scripts own deploy path; docs own version and device caveats.
- Method catalog action:
  create a new method for OpenXR feature bring-up cockpits.

## Caveats

- Treat these as source-reading references, not runnable validation for this
  repository.
- Vendor/runtime versions matter; all reusable setup notes need date and device
  labels.
- Large sample assets and generated files should not be copied into
  `VR-apps-lab`.

