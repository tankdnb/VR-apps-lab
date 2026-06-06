# VR Projects Wave 245: OpenXR Micro-Layer Render Shaping, Foveation, and Tracking Diagnostics

Date: 2026-06-06

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Theme

This wave studies compact OpenXR API-layer variants: mono-eye render shaping,
game/hardware-specific foveated rendering, pose recording diagnostics, and an
archived NIS scaling layer that later informed a larger toolkit.

## Why It Matters For `VR-apps-lab`

OpenXR layers are one of the richest donor families in the repository because
they show how to intervene between application and runtime. This wave adds
micro-layer references that are intentionally narrow: alter view enumeration,
hook D3D12/VRS and gaze actions, record head pose at frame boundaries, or
intercept swapchains for post-processing. These are useful as patterns even
when the specific layer is experimental or superseded.

## Project Notes

### `danny1marshall1587-maker/MonoEye`

- Interesting idea:
  an OpenXR API layer can report a mono view to the application while tracking
  stereo state internally for single-eye rendering plus depth-based
  reconstruction.
- Code donor value:
  `layer_negotiation.cpp` implements `xrNegotiateLoaderApiLayerInterface`
  validation and fills the API-layer interface. Generated dispatch helpers and
  hook files split negotiation, instance/session, view, frame, swapchain,
  config, logging, and Vulkan utilities. `hooks_view.cpp` intercepts
  `xrEnumerateViewConfigurationViews` and `xrLocateViews`; when enabled, it
  reports a single view outward while internally locating two views for IPD and
  second-eye reconstruction. `config.cpp` reads environment variables for
  enable/bypass, IPD override, render-width percentage, warp quality, and debug
  paths.
- Product reference value:
  useful research reference for performance/comfort experiments that need
  reversible runtime-layer configuration.
- What to inspect next:
  inspect shader and swapchain handling in a deeper pass if mono-eye
  reconstruction becomes strategically relevant.
- Architecture pattern:
  OpenXR negotiation -> dispatch hook table -> view-count intervention ->
  internal stereo state -> Vulkan compute reconstruction.
- Reusable method:
  expose risky render interventions behind env-configured enable, bypass, and
  diagnostic flags.
- Caveats:
  experimental concept, depth reconstruction complexity, app/runtime
  compatibility risks, and no OpenVR support despite phase notes.

### `TripleJ160/Beyond-EVO`

- Interesting idea:
  game-specific foveated rendering can be packaged as an OpenXR API layer that
  gates itself on runtime extension support, D3D12 device capabilities, eye
  gaze validity, and live control commands.
- Code donor value:
  `layer.cpp` captures `XrGraphicsBindingD3D12KHR` during session creation,
  validates the D3D12 device, checks `XR_EXT_eye_gaze_interaction`, queries
  VRS Tier 2 and tile size, and forwards calls to the runtime. The README and
  code describe a frame loop around `xrBeginFrame`, gaze pipeline update,
  VRS-manager tile generation, D3D12 command list hooks, and `xrEndFrame`
  cleanup. `gaze_pipeline.cpp` creates eye-gaze actions and spaces, syncs
  actions, locates gaze spaces, smooths projected gaze UVs, handles invalid
  streaks, and supports mouse fallback. `vrs_manager.cpp` manages shading-rate
  image ring buffers, descriptors, compute pipeline state, heatmap/debug
  resources, and upload buffers. The README also documents an INI config and a
  named-pipe command surface for reload, jitter clamp, jitter mirror, VRS, and
  debug toggles.
- Product reference value:
  strong reference for guarded render intervention UX: capability checks,
  fallback mode, live controls, async logging, warnings, and debug heatmaps.
- What to inspect next:
  compare against Quad-Views-Foveated and OpenXR Toolkit notes to separate
  generic foveation lessons from Bigscreen/ACE-specific details.
- Architecture pattern:
  OpenXR D3D12 layer -> capability gates -> eye-gaze action pipeline -> VRS
  resource manager -> command-list hooks -> live control pipe.
- Reusable method:
  every render-modifying layer needs runtime/device/extension gates plus a
  safe fallback and live diagnostics.
- Caveats:
  highly hardware/game-specific, partly aspirational in documentation, and
  not a generic donor without substantial validation.

### `marcsabat/xr-tracking-diagnostics`

- Interesting idea:
  a diagnostic API layer can stay tiny by intercepting only loader creation,
  session lifecycle, `xrWaitFrame`, and reference-space pose reads.
- Code donor value:
  `layer.cpp` implements a single translation-unit layer with dispatch table
  setup, `xrCreateApiLayerInstance`, `xrGetInstanceProcAddr`, session and
  instance lifecycle hooks, and `xrWaitFrame` interception. `session.cpp`
  creates a `VIEW` space, prefers `STAGE` with `LOCAL` fallback, polls F9
  through `GetAsyncKeyState`, toggles recording with audible beeps, and locates
  head pose during frame wait. `recorder.cpp` writes CSV files under the user's
  Documents folder with frame, timestamp, position, rotation, and validity
  columns. Config uses environment duration, and logs go to temp files.
- Product reference value:
  excellent donor for an OpenXR doctor: low hook surface, clear record toggle,
  plain CSV output, and obvious user feedback.
- What to inspect next:
  compare with layer GUI, OpenXR layer scripts, and validation tools to design
  a reusable diagnostics bundle.
- Architecture pattern:
  OpenXR frame hook -> locate reference-space pose -> hotkey toggled recorder
  -> CSV plus beep/log feedback.
- Reusable method:
  diagnostic layers should minimize intercepted calls and produce portable
  traces before adding UI.
- Caveats:
  Windows hotkey/audio assumptions, fixed output paths, and tracking validity
  analysis left to external tooling.

### `mbucchia/_ARCHIVE_XR_APILAYER_NOVENDOR_nis_scaler`

- Interesting idea:
  an archived single-purpose scaler layer is still valuable as source evidence
  for swapchain interception, D3D11 resource wrapping, config, hotkeys, GPU
  timing, stats, and screenshots.
- Code donor value:
  `dllmain.cpp` defines layer metadata, registry/config/log paths, hook points
  for view configuration, swapchain formats, session creation, swapchain
  creation/enumeration/acquire/destroy, and `xrEndFrame`. It tracks D3D11
  devices, scaler resources per swapchain, NIS/bilinear/NVSharpen modes,
  intermediate textures, SRV/UAV/RTV arrays, GPU timers, stats, screenshots,
  hotkey state, scaling factor, sharpness, intermediate format, and context
  options. `DeviceResources.cpp` wraps the application's D3D11 device/context
  and creates SRVs, samplers, textures, constant buffers, and views.
- Product reference value:
  useful ancestor reference for OpenXR Toolkit-style post-processing layers.
- What to inspect next:
  compare against current OpenXR Toolkit and layer-template docs before using
  any structure as modern advice.
- Architecture pattern:
  OpenXR swapchain hooks -> graphics-device resource wrapper -> post-process
  scaler -> stats/hotkey/screenshot side channel.
- Reusable method:
  treat swapchain interception as a resource-lifecycle problem first and an
  image-effect problem second.
- Caveats:
  archived and superseded, D3D11-focused, Windows/registry assumptions, and no
  longer the preferred implementation path.

## Reusable Pattern Extraction

- Pattern candidate:
  OpenXR API-layer intervention loop for render, frame, and diagnostic changes.
- Problem solved:
  runtime-adjacent tools need a disciplined way to intercept OpenXR calls
  without turning every layer into an unbounded compatibility risk.
- Reusable core:
  loader negotiation, generated or explicit dispatch tables, capability gates,
  config/bypass/log paths, narrowly scoped hooks, runtime/device/extension
  checks, resource lifetime tracking, frame or swapchain intervention, user
  feedback, and trace output.
- Source evidence:
  `MonoEye`, `Beyond-EVO`, `xr-tracking-diagnostics`, and archived
  `XR_APILAYER_NOVENDOR_nis_scaler`.
- Abstraction boundary:
  separate loader/dispatch plumbing, session/device capture, intervention
  logic, diagnostics, and user control/config surfaces.
- What not to copy:
  archived code as current best practice, game-specific VRS assumptions,
  registry-only configuration, risky render modifications without bypass, or
  broad hook surfaces for simple diagnostics.
- Method catalog action:
  add a method entry for OpenXR micro-layer intervention boundaries.

## Follow-Up Gaps

- Compare these micro-layers against OpenXR Toolkit, Quad-Views-Foveated,
  OpenXR-Layer-Template, and layer GUI notes.
- Extract a layer-safety checklist: manifest, enable/bypass, logs, capability
  gates, output paths, cleanup, and uninstall story.
- Separate render-changing, tracking-diagnostic, and installer/config-layer
  methods in future reuse plans.
