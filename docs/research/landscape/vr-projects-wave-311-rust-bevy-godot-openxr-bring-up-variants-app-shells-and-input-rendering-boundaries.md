# Wave 311 - Rust, Bevy, and Godot OpenXR Bring-Up Variants, App Shells, and Input/Rendering Boundaries

This wave studies Rust/Bevy/Godot OpenXR experiments as reusable references
for app-shell bring-up, graphics binding, swapchain lifecycle, Bevy render
plugin replacement, frame-loop systems, OpenXR input resources, Godot Rust
extension boundaries, and minimal game-loop XR integration.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- Rust OpenXR bring-up and small app shells;
- Bevy plugin approaches to OpenXR resources and manual texture views;
- Android/Quest Bevy variants;
- Godot XR controller state accessed from Rust extensions;
- minimal OpenGL/OpenXR game-loop boundaries.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `blaind/bevy_openxr` | Bevy OpenXR plugin/core experiment | Studied | `XrInstance` handoff, WGPU/OpenXR device boundary, custom runner, hand tracking, swapchain/render graph modules, and Bevy app integration |
| `MalekiRe/bevy_openxr_android` | Android/Quest Bevy OpenXR app shell variant | Studied | `DefaultXrPlugins`, Oculus controller resource, Bevy systems for hand gizmos, frame state/session/input resources, and Android-targeted example structure |
| `occuros/bevy_openxr_performance_test` | Bevy OpenXR performance/plugin boundary | Studied | Manual RenderPlugin replacement, future resource handoff, left/right manual texture views, XR begin/post/end frame systems, swapchain/image handling, and action-set resources |
| `richardanaya/godot_openxr__rust` | Godot XR scene plus Rust GDExtension controller sample | Studied | Minimal Rust class that reads parent `XRController3D` trigger state and mutates a sibling `MeshInstance3D` material |
| `TheHellBox/SlashMania` | Rust OpenXR rhythm game/game-loop experiment | Studied | Specs ECS loop, OpenGL OpenXR session, stereo swapchain, reference spaces, locate views, frame stream begin/end, and song/note systems |

## Code-Level Findings

### `blaind/bevy_openxr`

- Interesting idea:
  Bevy OpenXR integration can be modeled as a startup handoff from a
  pre-created WGPU/OpenXR device into Bevy resources and a custom app runner.
- Code donor value:
  medium-high. `xr_instance.rs` stores a one-shot `XrInstance` in a global
  `OnceCell`, packages `WGPUOpenXR` plus `openxr::Instance`, and converts them
  into `XRDevice` and Bevy-accessible OpenXR structures. `runner.rs` replaces
  the normal loop with an XR runner that repeatedly calls `app.update()`,
  tracks average frame time, and destroys the WGPU/OpenXR resource at shutdown.
  The tree also separates device, event, hand tracking, keyboard, swapchain,
  systems, platform adapters, render graph, and view transform modules.
- Product reference value:
  high for Rust engine experiments and for understanding where an engine
  should accept an XR-owned device/session instead of creating a desktop window
  first.
- What to inspect next:
  render graph nodes, hand tracking resources, platform adapter for Oculus
  Android, event handling completeness, and WGPU/OpenXR crate maturity.
- Reusable pattern extraction:
  keep `XR-owned graphics device`, `engine resource handoff`, and `runner`
  explicit.

### `MalekiRe/bevy_openxr_android`

- Interesting idea:
  an Android/Quest Bevy sample can show controller state as ordinary Bevy
  resources/systems once the XR plugin owns the app shell.
- Code donor value:
  medium. `src/lib.rs` uses `DefaultXrPlugins`, diagnostic plugins, a startup
  scene that spawns cube grids, and an update `hands` system that reads
  `OculusController`, `XrFrameState`, `XrInput`, `XrInstance`, and `XrSession`.
  It gets grip spaces for left/right hands, changes gizmo color from A/B/right
  trigger state, and uses controller input to despawn cubes.
- Product reference value:
  medium-high for minimal Quest app shells, input resource shape, and debugging
  controller-space visualization.
- What to inspect next:
  Android manifest/Gradle packaging, asset deployment, lifecycle handling,
  permissions, and whether the sample diverges from upstream Hotham/Bevy
  plugin assumptions.
- Reusable pattern extraction:
  expose XR controllers as typed Bevy resources consumed by normal ECS systems.

### `occuros/bevy_openxr_performance_test`

- Interesting idea:
  the Bevy render path can be redirected to OpenXR by disabling the normal
  renderer, installing a manual renderer, and registering left/right texture
  views during the XR frame loop.
- Code donor value:
  high. `OpenXrPlugin` initializes XR graphics from the primary window raw
  handles, stores future XR resources behind `Arc<Mutex<Option<_>>>`, disables
  the default `RenderPlugin` and `PipelinedRenderingPlugin`, installs a manual
  `RenderPlugin`, inserts XR resources into the main app and render app, creates
  left/right `ManualTextureView` handles, and schedules `xr_begin_frame`,
  `post_frame`, and `end_frame` systems. `xr_begin_frame` polls XR events,
  begins/ends sessions on state changes, waits and begins frames, and locates
  views. `post_frame` acquires/waits swapchain images and updates manual
  texture views. `end_frame` releases images and submits projection layers.
- Product reference value:
  very high for engine-layer app-shell design, performance harnesses, and
  future Rust prototypes.
- What to inspect next:
  graphics initialization, Vulkan/WGPU backend assumptions, controller action
  sets, frame-timing metrics, image lifetime safety, and session stop/loss
  behavior.
- Reusable pattern extraction:
  split XR frame loop into `poll events`, `wait/begin frame`, `locate views`,
  `acquire/wait image`, `render texture handoff`, `release/end frame`.

### `richardanaya/godot_openxr__rust`

- Interesting idea:
  Godot can keep scene/XR setup in GDScript while small Rust GDExtension
  classes own type-safe logic against Godot XR nodes.
- Code donor value:
  medium. `rust_openxr/src/lib.rs` defines a `TriggerColorChanger` Godot class
  that runs in `process`, retrieves the parent `XRController3D`, retrieves a
  sibling `ControllerMesh`, casts its material to `StandardMaterial3D`, and
  changes albedo based on `is_button_pressed("trigger")`. `RightController.gd`
  shows the same logic in GDScript, making the bridge boundary easy to compare.
- Product reference value:
  high for mixed Godot/Rust XR utilities where only a small performance- or
  safety-sensitive behavior needs Rust.
- What to inspect next:
  OpenXR action map, main scene setup, extension loading/build script, input
  names, and Godot 4 compatibility limits.
- Reusable pattern extraction:
  keep platform scene setup in the engine and move only narrow XR node logic
  into the Rust extension.

### `TheHellBox/SlashMania`

- Interesting idea:
  a small Rust game can keep OpenXR as an explicit module around an otherwise
  conventional ECS/game-loop structure.
- Code donor value:
  medium-high. `main.rs` uses a Specs world, sound/note/obstacle systems, a
  thread-local render window, song/difficulty CLI selection, and a continuous
  dispatcher loop. `openxr_module/mod.rs` creates an OpenGL OpenXR instance,
  verifies `KHR_opengl_enable`, creates an HMD system/session, begins primary
  stereo, initializes reference spaces, creates an array-size-2 stereo
  swapchain, tracks session state, polls events, locates views, recreates the
  swapchain on resolution changes, and performs frame stream wait/begin/end
  with projection views.
- Product reference value:
  high for minimal native Rust XR game structure and for comparing Bevy
  engine-owned loops with hand-rolled OpenXR loops.
- What to inspect next:
  render backend bridge, input handling, reference-space buglets, session-loss
  handling, audio timing, and content parser boundaries.
- Reusable pattern extraction:
  keep OpenXR lifecycle as a module with explicit swapchain/frame-stream calls
  that the render loop can call in a predictable order.

## Reusable Pattern Extraction

- Pattern candidate:
  Rust/Bevy/Godot OpenXR app-shell boundary across instance/session lifecycle,
  graphics binding, swapchains, frame loop, actions, and platform adapters.
- Problem solved:
  experimental XR app shells often hide the critical boundary between engine
  startup, runtime session, graphics resources, swapchain images, frame timing,
  and input actions. Reuse needs these seams visible.
- Reusable core:
  instance/session creator, graphics binding, system/view configuration,
  reference spaces, swapchain images, event polling, frame wait/begin/end,
  texture-view handoff, action/controller resources, engine plugin/runner
  boundary, and platform adapter.
- Source evidence:
  `blaind/bevy_openxr`, `MalekiRe/bevy_openxr_android`,
  `occuros/bevy_openxr_performance_test`,
  `richardanaya/godot_openxr__rust`, and `TheHellBox/SlashMania`.
- Abstraction boundary:
  keep runtime lifecycle, graphics device/session binding, render texture
  handoff, input action resources, platform-specific packaging, and
  engine/game-loop integration separate.
- What not to copy:
  unsafe global handoff without lifecycle guards, panic-heavy session handling,
  unbounded render-loop assumptions, engine-version-specific APIs, or samples
  that treat Android packaging as an afterthought.
- Method catalog action:
  add a Rust/Bevy/Godot OpenXR app-shell method.

## Follow-Up Gaps

- Build a Rust XR app-shell matrix comparing Bevy, Godot, hand-rolled OpenGL,
  WGPU/OpenXR, Android/Quest packaging, and input action handling.
- Deepen `occuros` graphics initialization and swapchain image safety.
- Deepen `blaind` render graph/hand-tracking/platform modules.
- Compare Godot Rust extension boundaries with Unity native plugin and OpenXR
  layer/plugin boundaries from earlier waves.
