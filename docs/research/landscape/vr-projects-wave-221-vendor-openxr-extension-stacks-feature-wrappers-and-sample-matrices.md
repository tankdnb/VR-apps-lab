# VR Projects Wave 221: Vendor OpenXR Extension Stacks, Feature Wrappers, and Sample Matrices

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-221-plan.md`
- `docs/research/program/github-research-wave-221-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

Advanced XR utilities often depend on optional extensions: hand meshes, QR
markers, passthrough, body tracking, scene understanding, virtual keyboards,
anchors, secondary views, or camera access. The reusable challenge is not just
"call an extension"; it is to expose capability checks, lifecycle ownership,
function pointer loading, build/deployment gates, sample-to-feature mapping,
and caveats.

## Project Findings

### `microsoft/OpenXR-MixedReality`

- Interesting idea: the repository acts as a feature-to-sample map for
  Microsoft mixed-reality OpenXR capabilities.
- Code donor value: high for native sample organization. `XrInstanceContext.h`
  creates instances from enabled extension lists and prepares common paths.
  `Scene_QRCode.cpp` shows a bounded QR scene-marker flow with filter modes,
  action bindings, view-space filter bounds, polling of scene compute state,
  and visual update logic.
- Product reference value: high for diagnostics and feature explorer tools.
- Architecture pattern: core app/sample framework plus feature-specific scene
  modules.
- Reusable method: document feature support by mapping extension names to
  sample files and visible behaviors.
- Constraints and caveats: Microsoft/WMR/HoloLens focus, preview extensions,
  D3D/UWP/Win32 assumptions, and platform-specific feature availability.
- What to inspect next: `ThreeSpacesUwp`, scene understanding samples, and
  secondary-view configuration.
- Why it matters for `VR-apps-lab`: it is a good reference for an OpenXR
  feature matrix or doctor UI.

#### Reusable Pattern Extraction

- Pattern candidate: vendor OpenXR extension wrapper with lifecycle,
  capability, and build gates.
- Problem solved: optional XR features are fragile when extension strings,
  handles, function pointers, runtime support, and deployment requirements are
  hidden inside feature code.
- Reusable core: feature declaration, required extension list, support query,
  instance/session hooks, function pointer loading, handle create/destroy,
  per-frame update, build/package gate, and caveat output.
- Source evidence: `XrInstanceContext.h`, `Scene_QRCode.cpp`,
  `MicrosoftOpenXR.cpp`, `QRTrackingPlugin.cpp`, `XrApp.cpp`,
  `XrVirtualKeyboardHelper.cpp`, `FeatureBase.cs`,
  `FBPassthrough.cs`, `FBPassthroughBuildHook.cs`, and
  `FBBodyTracking.cs`.
- Abstraction boundary: runtime extension check, engine wrapper, UX helper,
  build metadata, and vendor policy should stay separate.
- What not to copy: vendor license assumptions, experimental feature claims,
  platform flags, or sample-specific object ownership without adapting them.
- Method catalog action: create Method 666.

### `microsoft/Microsoft-OpenXR-Unreal`

- Interesting idea: an engine plugin can present optional OpenXR features as a
  registry of modules and Blueprint-friendly wrappers rather than one monolith.
- Code donor value: high. `MicrosoftOpenXR.cpp` conditionally registers
  spatial anchors, hand mesh, secondary views, Azure Object Anchors, QR
  tracking, locatable camera, speech, spatial mapping, scene understanding,
  remoting, and holographic window attachment. `QRTrackingPlugin.cpp` loads
  QR libraries, requests access, starts a watcher, handles added/updated/removed
  events, maps spatial graph node IDs, and updates tracked geometry.
- Product reference value: high for engine-side extension UX.
- Architecture pattern: modular feature registry plus capability-gated
  Blueprint wrapper functions.
- Reusable method: expose availability checks and feature-specific wrappers
  before presenting controls to users.
- Constraints and caveats: Unreal version coupling, Microsoft plugin conflicts,
  Windows/HoloLens orientation, and optional DLLs.
- What to inspect next: spatial anchor plugin and PV camera wrapper.
- Why it matters for `VR-apps-lab`: it demonstrates how a runtime feature
  set becomes an engine/tooling surface.

### `meta-quest/Meta-OpenXR-SDK`

- Interesting idea: a vendor SDK can be mined as an extension capability map
  when samples are organized by feature and helper classes isolate handle
  ownership.
- Code donor value: high as reference, not as copy target. `XrApp.cpp` owns
  Android activity commands, session state, performance levels, event polling,
  and reference-space changes. `XrVirtualKeyboardHelper.cpp` loads
  `XR_META_virtual_keyboard` functions, declares required extensions, creates
  keyboard and keyboard space handles, suggests location, queries texture/model
  state, and guards null handles.
- Product reference value: high for Quest feature discovery and UX comparison.
- Architecture pattern: shared app framework plus per-feature helper classes.
- Reusable method: make each extension helper own support checks, function
  pointers, handles, spaces, and user-visible state transitions.
- Constraints and caveats: Oculus SDK license, preview/experimental APIs,
  Quest platform assumptions, and system property requirements for some
  experimental features.
- What to inspect next: scene, colocation, passthrough, depth, and spatial
  anchor helpers.
- Why it matters for `VR-apps-lab`: it is a broad reference for capability
  surface design and caveat language.

### `mikeskydev/unity-openxr-extensions`

- Interesting idea: small Unity extension wrappers can be built with a generic
  `OpenXRFeature` base that centralizes required extension checks and function
  hooks.
- Code donor value: very high for wrapper shape. `FeatureBase.cs` stores
  instance/session handles, intercepts `xrGetInstanceProcAddr`, hooks/unhooks
  functions, and checks required extensions. `FBPassthrough.cs` creates and
  destroys passthrough/layer handles, starts/pauses passthrough, caches a small
  number of layers due Unity cleanup caveats, and registers a layer provider.
  `FBPassthroughBuildHook.cs` edits Android manifest `uses-feature` metadata.
  `FBBodyTracking.cs` captures system/frame/app-space state and locates body
  joints.
- Product reference value: high for Unity prototypes that need extension
  wrappers without a full vendor plugin.
- Architecture pattern: generic feature base plus one class per extension
  family plus build hooks.
- Reusable method: keep runtime lifecycle and Android/package metadata in the
  same feature package but separate files.
- Constraints and caveats: unofficial wrapper, Unity/OpenXR package coupling,
  layer-count workaround, and vendor feature availability.
- What to inspect next: boundary visibility, body tracking skeleton update,
  and editor build hooks.
- Why it matters for `VR-apps-lab`: it is the clearest small donor for future
  extension-wrapper prototypes.

## Cross-Project Synthesis

The common pattern is an OpenXR feature wrapper with explicit gates:

- required extension strings
- runtime support query
- function pointer loading
- instance/session/frame lifecycle
- handle ownership and cleanup
- engine-facing wrapper API
- build/package manifest requirements
- caveat and preview status

For `VR-apps-lab`, this supports an OpenXR doctor, feature explorer,
vendor-extension comparison matrix, and small extension-prototype shells.
