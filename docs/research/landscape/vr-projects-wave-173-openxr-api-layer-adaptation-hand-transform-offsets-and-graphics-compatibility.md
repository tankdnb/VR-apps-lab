# VR Projects Wave 173: OpenXR API-Layer Adaptation, Hand Transform Offsets, and Graphics Compatibility

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 173 studies OpenXR API layers that adapt data at runtime: OSC face/eye
tracking exposed through standardized extension calls, hand-joint transform
correction, graphics-binding compatibility wrappers, and compact generated
dispatch templates for future micro-layers.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `LordOfDragons/openxr_oscclient` | Protocol-to-OpenXR extension adapter | Strong adapter donor |
| `CraigMason/OpenXR-Hand-Transform-Offset-Layer` | Hand tracking coordinate adaptation layer | Strong micro-layer donor |
| `Sorenon/sorenon_openxr_layer` | Graphics compatibility API layer | Strong architecture donor with performance caveats |
| `maluoi/openxr-layer-template` | OpenXR layer starter template | Strong small-layer scaffold donor |

## `LordOfDragons/openxr_oscclient`

- Interesting idea:
  receive OSC eye/face tracking data and expose it through OpenXR extension
  surfaces such as `XR_EXT_eye_gaze_interaction` and HTC facial tracking calls.
- Code donor value:
  high for protocol-to-extension adaptation, loader negotiation, extension
  filtering, instance/session interception, OSC parse mapping, and thread-safe
  expression state.
- Product reference value:
  high for future face/eye bridge tools that want runtime-facing compatibility
  instead of app-specific OSC consumers.
- What to inspect next:
  define a clear OSC target schema and compare local-space eye-gaze caveats
  against VRCFT/OpenXR face-tracking modules.
- Source evidence:
  `olotApiLayer.cpp`, `olotOcsClient.cpp`, `olotInstance.cpp`, and README
  extension notes.
- Reusable pattern extraction:
  protocol-to-standard OpenXR extension adapter.
- Reusable core:
  negotiate as an API layer, filter self-provided extension names before
  forwarding to runtimes that do not know them, receive OSC on a background
  thread, normalize target names, clamp expression values, and answer OpenXR
  extension calls from the cached state.
- Do not copy directly:
  fixed ports, implicit OSC path conventions, or local-space-only gaze
  assumptions without configuration.
- Caveats:
  only one layer should provide the same eye/face extension surface; layer
  ordering and provider conflicts need explicit docs.

## `CraigMason/OpenXR-Hand-Transform-Offset-Layer`

- Interesting idea:
  intercept `xrLocateHandJointsEXT` and apply reloadable yaw/pitch/translation
  offsets to every hand joint so desktop-mounted hand tracking can be used in
  headsetless or alternate-tracking workflows.
- Code donor value:
  high for a minimal hand-tracking micro-layer: function shim registration,
  config reload, joint pose rotation/translation, and narrow runtime boundary.
- Product reference value:
  high for headsetless development, Leap Motion style desk setups, and
  calibration micro-tools.
- What to inspect next:
  generalize the file config into a proper calibration profile with UI and
  per-device presets.
- Source evidence:
  `layer_shims.cpp`, `hand_transform_config.txt`, and README notes about
  desktop-mounted Leap Motion Controller 2 workflows.
- Reusable pattern extraction:
  runtime-side hand-pose coordinate correction layer.
- Reusable core:
  locate a config file through an environment variable, poll/reload it safely,
  intercept `xrLocateHandJointsEXT`, rotate/translate each joint position and
  orientation, and keep the layer narrow enough to be understandable.
- Do not copy directly:
  hardcoded coordinate assumptions or text-file-only calibration UX.
- Caveats:
  specific to hand tracking and desktop-mounted device assumptions.

## `Sorenon/sorenon_openxr_layer`

- Interesting idea:
  compensate for missing OpenGL runtime support by replacing an OpenGL session
  path with Vulkan-backed compatibility objects and external-memory copy/release
  behavior inside an OpenXR API layer.
- Code donor value:
  high for Rust layer negotiation, runtime detection, wrapper registries,
  session graphics substitution, swapchain wrapping, and frontend/backend
  ownership boundaries.
- Product reference value:
  medium-high for graphics compatibility diagnostics and runtime capability
  workaround research.
- What to inspect next:
  study performance and correctness caveats before deriving any production
  guidance from the design.
- Source evidence:
  `layer_entry/src/lib.rs`, `layer_core/src/entry.rs`,
  `interceptors/instance.rs`, `interceptors/session.rs`, and swapchain wrapper
  code.
- Reusable pattern extraction:
  graphics compatibility API layer that substitutes unsupported graphics
  bindings with backend swapchains.
- Reusable core:
  negotiate and log once, validate loader/API versions, detect runtime names,
  replace requested graphics extensions at instance creation, wrap sessions and
  swapchains, and translate frontend acquire/release operations into backend
  resource operations.
- Do not copy directly:
  `glFinish`, `vkQueueWaitIdle`, incomplete semaphore handling, or TODO-heavy
  compatibility logic.
- Caveats:
  sophisticated but experimental; strongest as an architecture and diagnostic
  reference.

## `maluoi/openxr-layer-template`

- Interesting idea:
  provide a compact modern C11/CMake OpenXR API-layer template with generated
  dispatch code, manifest scaffolding, and explicit override/requested function
  lists.
- Code donor value:
  high for starting small diagnostics/adapters without dragging in a large
  framework.
- Product reference value:
  high for future `VR-apps-lab` micro-layer experiments and documentation.
- What to inspect next:
  compare with C++ and Rust templates to choose one recommended starter path.
- Source evidence:
  `dispatch_core.c`, `layer.c`, `scripts/layer_config.py`, generated dispatch
  outputs, and manifest files.
- Reusable pattern extraction:
  minimal generated-dispatch C API-layer skeleton.
- Reusable core:
  validate negotiation structs and layer names, create the next layer instance
  through the chain, initialize a context, intercept `xrGetInstanceProcAddr`
  and selected functions, generate function dispatch cases from a small config,
  and ship a manifest with disable-environment controls.
- Do not copy directly:
  template names or placeholder logic without product-specific safety docs.
- Caveats:
  scaffold only; does not provide a product feature by itself.

## Cross-Project Lessons

- OpenXR API layers are most reusable when they are narrow, inspectable, and
  honest about conflicts and disable paths.
- Runtime-side adapters can turn app-specific protocols into standard OpenXR
  surfaces, but they also create provider-ordering and capability-claim risks.
- Hand and face/eye adaptation layers are strong micro-tool candidates because
  the transform/data boundary is clear.
- Graphics compatibility layers require extra caution: the architecture is
  valuable, but performance and synchronization details can dominate the real
  cost.
- A good template matters because most useful API-layer ideas should start as
  small diagnostics or adapters, not as large opaque runtime modifications.
