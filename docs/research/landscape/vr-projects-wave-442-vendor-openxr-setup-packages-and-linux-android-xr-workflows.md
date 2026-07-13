# VR Projects Wave 442: Vendor OpenXR Setup Packages and Linux Android XR Workflows

Date: 2026-07-13

Theme: platform/vendor setup packages and operator workflows that make OpenXR
features discoverable, configurable, and diagnosable across Android XR, VIVE,
and Linux/Quest development paths.

## Shortlist

| Project | Family placement | Study status |
| --- | --- | --- |
| `android/android-xr-unity-package` | Android XR Unity extension package | Code-level pass |
| `ViveSoftware/VIVE-OpenXR-Sample-Unity` | VIVE OpenXR sample and feature setup | Code-level pass |
| `Stridemann/Unity-XR-on-Linux-for-Meta-Quest` | Linux Quest OpenXR compatibility workflow | Code-level pass |

## Project Notes

### `android/android-xr-unity-package`

- Interesting idea: Android XR Unity extension package that exposes session
  management, tracking, meshing, passthrough composition, body/fine-eye support,
  recommended settings, XR streaming, lighting, and trackpad gestures.
- Code donor value: useful donor for feature-group packaging, sample list
  metadata, project validation guidance, extension availability checks, and
  changelog-based support boundaries.
- Product reference value: strong reference for future lab docs that separate
  "feature exists", "runtime supports it", and "project settings are valid".
- Architecture pattern: Unity package with feature group selection through XR
  Plug-in Management/OpenXR, samples in `package.json`, and per-feature runtime
  `IsExtensionEnabled` style checks.
- Reusable method: `vendor OpenXR setup package and platform workflow note`.
- UX/product lesson: XR feature setup becomes less mysterious when package
  import, OpenXR provider selection, validation fixes, feature toggles, and API
  level constraints are documented in one operator path.
- Caveats: moving Android XR pre-release surface; changelog shows features being
  deprecated, moved to Unity packages, or changed across versions.
- Source evidence: README lists Android XR APIs and setup steps; `package.json`
  lists samples for passthrough, object/image/body tracking, scene meshing,
  controller, cubemap lighting, and trackpad gestures; changelog documents
  extension availability and package dependency changes.
- Reusable core: feature matrix, sample metadata, package dependency snapshot,
  validation checklist, extension support checks, and deprecation notes.
- What not to copy: pre-release package assumptions, removed features, or
  platform-specific APIs as generic OpenXR.
- Method catalog action: create platform workflow method.
- What to inspect next: sample-level README files for body tracking, scene
  meshing, passthrough, and trackpad gesture UX.

### `ViveSoftware/VIVE-OpenXR-Sample-Unity`

- Interesting idea: VIVE OpenXR sample project showing plugin installation,
  VIVE XR Support feature enablement, MR scenes, passthrough/performance docs,
  and import/export guidance for own projects.
- Code donor value: useful donor for vendor sample packaging, feature-enable
  instructions, MR performance controls, passthrough quality/image-rate knobs,
  and collider event input plumbing.
- Product reference value: confirms that vendor-specific sample repos are best
  treated as operator playbooks with clear plugin dependency and license labels.
- Architecture pattern: sample scenes under `Assets/VIVE/OpenXR/CodeSamples`,
  documentation folder, plugin installer instruction, and utility package
  components for collider events and performance UI.
- Reusable method: `vendor feature sample import workflow`.
- UX/product lesson: a good vendor workflow tells developers how to copy samples
  into another project and which scenes/features/settings must travel together.
- Caveats: HTC license, plugin dependency, large Unity sample footprint, and
  some docs marked "to be released".
- Source evidence: README describes VIVE OpenXR plugin installation and feature
  enablement; `PerformanceController.cs` exposes passthrough and foveation
  controls; `ColliderEventCaster.cs` shows event-handler lists for hover, press,
  drag, drop, click, and axis changes.
- Reusable core: plugin install step, feature toggle checklist, sample import
  route, performance/passthrough control panel, and input event routing.
- What not to copy: vendor packages, license-bound assets, or sample project
  structure as a generic baseline.
- Method catalog action: update platform workflow method with vendor sample
  import and performance control subpattern.
- What to inspect next: MR documentation and passthrough scripts as a focused
  future wave if VIVE-specific utility work becomes important.

### `Stridemann/Unity-XR-on-Linux-for-Meta-Quest`

- Interesting idea: compatibility shim/workflow for running Unity 6 VR projects
  on Linux with a Quest headset through SteamVR and ALVR by bridging Android
  OpenXR binary assumptions.
- Code donor value: strong conceptual donor for a diagnostic playbook: bionic to
  glibc shim, OpenXR API layer stripping Android extensions, Vulkan implicit
  layer, fake JVM, loader path patch, launch script, and troubleshooting table.
- Product reference value: excellent reference for headsetless/operator workflow
  docs that explain runtime layers, shims, environment variables, and known
  failure modes.
- Architecture pattern: `NativeFix` folder plus `launch_unity_vr.sh` orchestrate
  loader/layer/preload environment for Unity editor play mode; APK builds are
  explicitly separated as native Android path.
- Reusable method: `runtime compatibility shim workflow`.
- UX/product lesson: complex XR setup hacks become reusable when the README
  includes requirements, quick start, migration steps, known issues, and symptom
  to fix mapping.
- Caveats: proof-of-concept, Linux/Unity/version sensitive, self-reported status,
  and includes scripts intended to build shims when used; research pass only
  read source/docs and did not execute anything.
- Source evidence: README documents NativeFix components, launch script, OpenXR
  loader patch, ALVR/SteamVR requirements, controller-profile caveat, APK path,
  and troubleshooting; `launch_unity_vr.sh` sets loader, API layer, Vulkan
  layer, fake JVM, and Vulkan flags.
- Reusable core: compatibility component inventory, launch environment table,
  runtime/loader diagnostics, known-issue matrix, and strict "editor shim vs
  APK native" boundary.
- What not to copy: binary shims, local Unity paths, self-healing build scripts,
  or proof-of-concept claims without independent validation.
- Method catalog action: update platform workflow method with compatibility-shim
  and troubleshooting subpattern.
- What to inspect next: technical docs and native layer code if the lab needs a
  Linux XR runtime doctor.

## Reusable Pattern Extraction

- Pattern candidate: `vendor OpenXR setup package and platform workflow note`.
- Problem solved: OpenXR development often fails because package versions,
  feature toggles, platform requirements, and runtime layers are scattered.
- Reusable core: platform label, package/dependency snapshot, feature matrix,
  setup checklist, validation/fix route, extension availability check, sample
  import route, runtime-layer inventory, and known-issue table.
- Source evidence: Android XR package README/changelog/package samples, VIVE
  OpenXR sample setup/performance scripts, and Unity-XR-on-Linux NativeFix plus
  launch workflow.
- Abstraction boundary: operator workflow and diagnostics are reusable; vendor
  SDK internals, pre-release assumptions, binary shims, and license-bound assets
  are not.

## Follow-Up Gaps

- Create a platform workflow template for Android XR, Meta Quest, VIVE, SteamVR,
  Linux/ALVR, and WebXR setup notes.
- Compare extension availability checks across Android XR, VIVE OpenXR, Meta,
  Unity OpenXR, and raw OpenXR loader diagnostics.
