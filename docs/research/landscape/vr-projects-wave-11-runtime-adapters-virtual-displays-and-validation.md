# VR Projects Wave 11: Runtime Adapters, Virtual Displays, and Validation Microtools

- Date: `2026-04-18`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet in `VR-apps-lab`, focusing on runtime adapters, driver examples,
  virtual-display workflows, validation helpers, and creator-oriented
  micro-utilities.

## Why this wave exists

The repository already had strong coverage of:

- OpenXR runtime switchers and doctor-style tools;
- classic OpenVR overlays and dashboard utilities;
- tracker bridges, headsetless workflows, and bridge drivers;
- SteamVR environment helpers and runtime hygiene projects.

What was still missing was a stronger layer of:

- `graphics/runtime adapters`, not only runtime selectors;
- `library + sandbox` OpenXR frameworks for app bring-up learning;
- `virtual display and remote presentation` references;
- smaller `driver example` projects that teach device plumbing without a full
  bridge stack;
- `validation and config-patch microtools`;
- screenshot and capture helpers with clear workflow value.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with focused queries;
2. deduplicate against the registry;
3. freeze a shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `mbucchia/OpenXR-Vk-D3D12` | OpenXR graphics/runtime adapter and API-layer interop reference |
| `shiena/OpenXRRuntimeSelector` | Lightweight runtime selection helper for Unity-side workflows |
| `1runeberg/OpenXRProvider` | Library plus sandbox wrapper around OpenXR bring-up |
| `ValveSoftware/virtual_display` | Canonical `IVRVirtualDisplay` sample and remote-process transport reference |
| `finallyfunctional/openvr-driver-example` | Minimal and readable OpenVR driver learning reference |
| `SecondReality/VirtualControllerDriver` | Tiny synthetic controller example with mixed-reality workflow value |
| `oneup03/VRto3D` | Large display-repurposing driver for 3D displays and AR glasses |
| `BOLL7708/SuperScreenShotterVR` | Screenshot workflow utility with overlay, timer, notification, and WebSocket automation |
| `iigomaru/Periodic-Immersive-SteamVR-Screenshots` | Ultra-small scheduled screenshot overlay utility |
| `Virus-vr/SteamVRAdaptiveBrightness` | Mirror-texture analysis helper that live-adjusts SteamVR brightness |
| `username223/SteamVR-ActionsManifestValidator` | SteamVR manifest linting and validation micro-tool |
| `Erimelowo/Lighthouse-Scale-Fix` | Focused config patcher with backup/rollback behavior |

## Secondary candidate surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `OpenDisplayXR/OpenDisplayXR-VDD` | The repository currently exposes only a minimal README and license, so it is useful as a signal but not yet as a true code donor |

## Deep-pass notes by project

## `mbucchia/OpenXR-Vk-D3D12`

- GitHub:
  [mbucchia/OpenXR-Vk-D3D12](https://github.com/mbucchia/OpenXR-Vk-D3D12)
- What it is:
  an OpenXR API layer that adapts Vulkan and OpenGL applications to runtimes
  that expect `D3D12`.
- Why it matters:
  it adds a very strong `runtime adapter` reference to `VR-apps-lab`, not just a
  runtime selector or inspector.
- Interesting ideas:
  graphics API bridging via an OpenXR layer; swapchain import instead of an
  extra composition step; fence-based synchronization across incompatible
  graphics paths; generated dispatch framework plus installer/manifest flow.
- Interesting implementation choices:
  the layer intercepts `xrGetInstanceProcAddr` and instance/session creation;
  session state tracks runtime-side D3D12 resources together with Vulkan/OpenGL
  interop resources; extension exposure is adjusted to fit the adapted path.
- Code donor value:
  high for advanced compatibility and interop research.
- Product reference value:
  medium.
- Architecture reference value:
  very high.
- Caveats:
  this is an advanced layer and much more complex than typical utility apps.
- What to inspect next:
  swapchain lifetime management, fence handling, and how its generated-dispatch
  approach compares with other OpenXR layer bases.

## `shiena/OpenXRRuntimeSelector`

- GitHub:
  [shiena/OpenXRRuntimeSelector](https://github.com/shiena/OpenXRRuntimeSelector)
- What it is:
  a Unity package for selecting the active OpenXR runtime JSON before starting
  XR.
- Why it matters:
  most runtime switchers in the repo are desktop utilities. This one adds an
  `engine-side runtime selector` pattern.
- Interesting ideas:
  runtime providers for environment variable, system default, and vendor
  runtimes; registry-based enumeration of available runtimes; app-driven choice
  of runtime path instead of external switching only.
- Interesting implementation choices:
  provider abstraction for runtime manifests; use of
  `HKLM\\SOFTWARE\\Khronos\\OpenXR\\1\\AvailableRuntimes`; simple helper API for
  setting runtime by path or known runtime type.
- Code donor value:
  medium-high.
- Product reference value:
  high for developer-facing helpers.
- Architecture reference value:
  high.
- Caveats:
  strongly oriented around Unity and Windows runtime-discovery behavior.
- What to inspect next:
  how it behaves in packaged builds, how it handles stale runtime manifests,
  and whether its provider model can feed a future `OpenXR Doctor` helper API.

## `1runeberg/OpenXRProvider`

- GitHub:
  [1runeberg/OpenXRProvider](https://github.com/1runeberg/OpenXRProvider)
- What it is:
  a reusable OpenXR wrapper library paired with a sandbox executable.
- Why it matters:
  it is a good public example of `library + demo sandbox` as a learning and
  integration pattern.
- Interesting ideas:
  split the wrapper into `Core`, `Render`, and `Input`; expose input profiles
  for several controller ecosystems; ship a runnable sandbox as a bring-up and
  verification harness.
- Interesting implementation choices:
  `XRCore` owns instance/system/session/reference-space bring-up plus extension
  enablement and logging; `XRRender` validates stereo support, begins the
  session, creates swapchains, and tracks depth-support; `XRProvider` keeps the
  three-manager surface small and easy to consume.
- Code donor value:
  high.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  the project is large enough that it is better marked as `Partially studied`
  until its extension wrappers and input profiles get a deeper pass.
- What to inspect next:
  input profile design, sandbox render loop, extension wrapper quality, and
  where the wrapper stops hiding raw OpenXR complexity.

## `ValveSoftware/virtual_display`

- GitHub:
  [ValveSoftware/virtual_display](https://github.com/ValveSoftware/virtual_display)
- What it is:
  an example OpenVR driver demonstrating `IVRVirtualDisplay`.
- Why it matters:
  it is one of the strongest public references for `virtual display` and
  remote presentation workflows.
- Interesting ideas:
  use the compositor's final backbuffer as a transport source; move the remote
  presentation path into a separate process; communicate through shared memory
  and explicit frame events.
- Interesting implementation choices:
  the sample explains why D3D `Present` inside the same process can block GPU
  work; the driver launches `virtual_display.exe`; frame timing and texture
  state are shipped through shared state and synchronization primitives.
- Code donor value:
  very high.
- Product reference value:
  medium-high.
- Architecture reference value:
  very high.
- Caveats:
  sample-focused rather than a polished end-user tool.
- What to inspect next:
  shared-memory structure details, frame pacing, and how it compares with
  other remote display or stereo-display repurposing projects.

## `finallyfunctional/openvr-driver-example`

- GitHub:
  [finallyfunctional/openvr-driver-example](https://github.com/finallyfunctional/openvr-driver-example)
- What it is:
  a beginner-friendly OpenVR driver example that continuously feeds virtual
  joystick and trackpad values.
- Why it matters:
  it provides one of the clearest small-scale examples of `input-emulation
  driver` plumbing.
- Interesting ideas:
  minimal controller driver with one clear job; strong tutorial posture; use
  of OpenVR input components as the main teaching surface.
- Interesting implementation choices:
  small `DeviceProvider` creates the driver and runs frame updates; the
  controller driver declares a treadmill-style controller role, creates scalar
  input components, and updates them each frame.
- Code donor value:
  high for learning.
- Product reference value:
  medium.
- Architecture reference value:
  high.
- Caveats:
  intentionally minimal and not a full hardware bridge.
- What to inspect next:
  wiki/tutorial material, how it differs from Valve's own sample, and whether
  it can become the default learning reference in `VR-apps-lab`.

## `SecondReality/VirtualControllerDriver`

- GitHub:
  [SecondReality/VirtualControllerDriver](https://github.com/SecondReality/VirtualControllerDriver)
- What it is:
  a tiny OpenVR driver that simulates a single controller for mixed-reality
  video workflows.
- Why it matters:
  it shows how small a synthetic device driver can be when it only needs one
  narrow purpose.
- Interesting ideas:
  third-controller concept for mixed-reality capture; static synthetic device
  positioned in the play space; property-driven device emulation without a huge
  codebase.
- Interesting implementation choices:
  the driver advertises a controller device with fixed properties and a static
  pose; it demonstrates how far you can get with only core driver interfaces
  and a small amount of property wiring.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high for micro-driver design.
- Caveats:
  the implementation is intentionally narrow and static.
- What to inspect next:
  how to generalize static synthetic devices into calibration or creator-tool
  helpers.

## `oneup03/VRto3D`

- GitHub:
  [oneup03/VRto3D](https://github.com/oneup03/VRto3D)
- What it is:
  an OpenVR driver that repurposes VR output for side-by-side and top-and-bottom
  3D displays, AR glasses, and related stereo display workflows.
- Why it matters:
  it is a very strong example of `repurposed runtime output` rather than a
  normal headset utility.
- Interesting ideas:
  per-game profile system; display selection by index; HMD yaw/pitch emulation
  over `XInput`; optional `OpenTrack` loopback; launch-script automation;
  workflow shaping through SteamVR settings and app-window focus control.
- Interesting implementation choices:
  the device provider watches SteamVR process events to load and unload game
  profiles; the HMD driver writes a custom chaperone JSON, disables or reshapes
  several SteamVR dashboard and compositor behaviors, and launches helper
  scripts once on activation.
- Code donor value:
  high.
- Product reference value:
  very high.
- Architecture reference value:
  high.
- Caveats:
  it is large and productized, so selective extraction is better than trying
  to mirror it wholesale.
- What to inspect next:
  JSON/profile manager internals, display-component implementation, and how its
  workflow automation compares with `virtual_display` and other output bridge
  approaches.

## `BOLL7708/SuperScreenShotterVR`

- GitHub:
  [BOLL7708/SuperScreenShotterVR](https://github.com/BOLL7708/SuperScreenShotterVR)
- What it is:
  a SteamVR screenshot utility with timers, delayed capture, notifications,
  viewfinder overlays, and a local WebSocket server.
- Why it matters:
  it is a strong reference for `creator workflow micro-utilities` that combine
  overlay UX with automation.
- Interesting ideas:
  multi-overlay viewfinder with pitch and roll aids; timer and delayed capture;
  same-chord screenshot support; local WebSocket API that can trigger shots and
  return Base64 PNG results.
- Interesting implementation choices:
  WPF desktop app with EasyOpenVR helper layer; multiple overlays created and
  attached to the tracked device; SteamVR input actions for both direct and
  chord bindings; screenshot results routed into notifications and the remote
  server.
- Code donor value:
  high.
- Product reference value:
  very high.
- Architecture reference value:
  high.
- Caveats:
  built on a higher-level helper stack, so some low-level overlay details are
  abstracted away.
- What to inspect next:
  remote server implementation, screenshot file tagging, and how its
  overlay-plus-server split compares with other automation tools in `VR-apps-lab`.

## `iigomaru/Periodic-Immersive-SteamVR-Screenshots`

- GitHub:
  [iigomaru/Periodic-Immersive-SteamVR-Screenshots](https://github.com/iigomaru/Periodic-Immersive-SteamVR-Screenshots)
- What it is:
  an extremely small utility that takes a SteamVR screenshot every hour at the
  top of the hour.
- Why it matters:
  it is a great example of a narrow `workflow micro-utility` with almost no
  abstraction overhead.
- Interesting ideas:
  manifest-register the app once, then just run as a SteamVR startup overlay;
  build timestamped output folder structure; use the screenshot API directly
  from C.
- Interesting implementation choices:
  plain C program with OpenVR C API; uses `TakeStereoScreenshot`; checks hourly
  boundary and emits a screenshot only when the hour changes.
- Code donor value:
  medium.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium.
- Caveats:
  intentionally tiny and not extensible by itself.
- What to inspect next:
  whether `VR-apps-lab` should keep a dedicated category for automation-style
  microtools this small.

## `Virus-vr/SteamVRAdaptiveBrightness`

- GitHub:
  [Virus-vr/SteamVRAdaptiveBrightness](https://github.com/Virus-vr/SteamVRAdaptiveBrightness)
- What it is:
  a SteamVR background utility that continuously adjusts headset brightness
  based on the live mirror image.
- Why it matters:
  it combines compositor access, GPU-side image analysis, and a focused comfort
  outcome.
- Interesting ideas:
  pull mirror texture from the compositor; run a compute shader over a cropped
  and downscaled image; convert brightness estimate into SteamVR `analogGain`;
  keep the app quietly resident as a tray helper.
- Interesting implementation choices:
  uses `GetMirrorTextureD3D11`; drives a compute shader and UAV pipeline in
  `D3D11`; writes settings back through `VRSettings`; keeps a Windows tray icon
  for desktop-side control.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  hardware- and SteamVR-specific, and the comfort value depends on headset
  support for the setting.
- What to inspect next:
  compute shader details, smoothing behavior, and whether the same pattern can
  support more general image-analysis helpers.

## `username223/SteamVR-ActionsManifestValidator`

- GitHub:
  [username223/SteamVR-ActionsManifestValidator](https://github.com/username223/SteamVR-ActionsManifestValidator)
- What it is:
  a Python CLI for validating SteamVR action manifest JSON files.
- Why it matters:
  it adds a clear `validation and lint micro-tool` pattern to the repository.
- Interesting ideas:
  validate duplicate JSON keys explicitly; check for missing actions, action
  sets, localization, and default bindings; make warnings individually
  suppressible from the CLI; keep test fixtures for each failure mode.
- Interesting implementation choices:
  custom `object_pairs_hook` catches duplicate JSON keys; small check functions
  map directly to one user-facing rule; unit tests exercise disable-flags and
  expected exit codes.
- Code donor value:
  medium-high.
- Product reference value:
  high for developer tooling.
- Architecture reference value:
  medium-high.
- Caveats:
  narrow by design and scoped to one SteamVR manifest type.
- What to inspect next:
  whether `VR-apps-lab` should eventually group similar tools under a general `XR
  manifest validator` track.

## `Erimelowo/Lighthouse-Scale-Fix`

- GitHub:
  [Erimelowo/Lighthouse-Scale-Fix](https://github.com/Erimelowo/Lighthouse-Scale-Fix)
- What it is:
  a small Go utility that rewrites SteamVR's `lighthouse_scale.json` so all
  device scales become `1`, while keeping a backup.
- Why it matters:
  it is a clean example of a `safe config patcher` with rollback built in.
- Interesting ideas:
  backup-before-write; one-file focused patch; explicit user framing around
  risk and manual rollback.
- Interesting implementation choices:
  load JSON into a typed map; preserve model points while rewriting only the
  `scale` field; create `.bkp` automatically before writing the modified file.
- Code donor value:
  medium.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium.
- Caveats:
  hardcodes the SteamVR path and intentionally solves only one narrow issue.
- What to inspect next:
  whether a generalized `VR-apps-lab` config patch helper should standardize backup,
  diff, and rollback behavior across multiple SteamVR fixes.

## Cross-wave synthesis

Wave 11 sharpened several families that already existed in `VR-apps-lab`, but were
not yet dense enough:

- `OpenXR runtime and layer tools`
  now include a stronger `graphics/runtime adapter` angle through
  `OpenXR-Vk-D3D12`, plus engine-side runtime selection through
  `OpenXRRuntimeSelector`.
- `Driver tutorials and custom-device plumbing`
  now include three additional scales:
  beginner sample (`openvr-driver-example`),
  synthetic micro-driver (`VirtualControllerDriver`),
  and productized display-repurposing driver (`VRto3D`).
- `Creator tools and workflow utilities`
  now include screenshot automation, timer capture, and remote-shot control
  patterns.
- `SteamVR environment helpers`
  now include validation, backup-safe patching, and comfort/image-analysis
  utilities, not only startup or dashboard fixes.

## Most reusable methods clarified by this wave

- `runtime graphics adapter layer`
- `library + sandbox learning harness`
- `virtual display and remote presentation driver`
- `validation and lint micro-tool`
- `safe config patch utility`
- `creator screenshot workflow helper`

## Best follow-up work after this wave

1. compare `OpenXR-Vk-D3D12`, `VirtualDesktop-OpenXR`, and `OpenComposite`
   around runtime adaptation and compatibility boundaries;
2. compare `virtual_display`, `VRto3D`, and `OpenDisplayXR-VDD` as one
   `virtual display and repurposed output` family;
3. compare `SteamVRAdaptiveBrightness`, `SteamVR-ActionsManifestValidator`,
   `Lighthouse-Scale-Fix`, and `steamvr-exconfig` as one `workflow
   micro-utilities` family;
4. deepen `OpenXRProvider`, especially extension wrappers and input profiles.
