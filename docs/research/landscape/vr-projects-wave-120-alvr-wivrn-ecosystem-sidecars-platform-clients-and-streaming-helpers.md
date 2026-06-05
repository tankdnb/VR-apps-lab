# VR Projects Wave 120: ALVR/WiVRn Ecosystem Sidecars, Platform Clients, and Streaming Helpers

- Date: `2026-06-05`
- Goal: add a focused GitHub discovery wave for ALVR/WiVRn-adjacent projects
  that extend streaming ecosystems through platform clients, runtime bridge
  variants, tracking adapters, USB forwarding, and timing inspection tools.

## Why this wave exists

Mainline `ALVR` and `WiVRn` are already covered in the repository. This wave
looks around those cores, because ecosystem sidecars often reveal more reusable
utility patterns than the large streaming stacks themselves.

The central lesson is that a VR utility can be deliberately narrow: make one
platform work, translate one tracking payload family, repair one setup step, or
surface one timing dataset. That is especially relevant for `VR-apps-lab`,
where future tools may be thin helpers around existing runtimes rather than
full replacement runtimes.

## Better workflow used in this wave

This wave followed the repository's research pipeline:

1. search GitHub by ALVR/WiVRn ecosystem families;
2. deduplicate against registry and family docs;
3. freeze a bounded shortlist of sidecars, not mainline duplicate projects;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, product value, caveats, and family overlap;
6. promote findings into registry, families, methods, backlog, and indexes.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `alvr-org/alvr-visionos` | Platform-specific ALVR client for Apple Vision Pro with renderer, decoder, tracking, performance, and event-loop boundaries |
| `alvr-org/Monado-ALVR` | ALVR-oriented Monado fork/reference useful for remote-driver, runtime manifest, IPC, tracing, and driver documentation patterns |
| `alvr-org/VRCFT-ALVR` | VRCFaceTracking module that converts ALVR eye/face packets into unified tracking data |
| `AtlasTheProto/ADBForwarder` | Narrow wired-streaming setup helper for ADB server/device monitor/port forwarding |
| `Kierek/WiVRnTimings` | Small timing preset parser/viewer around WiVRn-style CSV timing data |

## Deep-pass notes by project

## `alvr-org/alvr-visionos`

- GitHub:
  [alvr-org/alvr-visionos](https://github.com/alvr-org/alvr-visionos)
- What it is:
  a platform-specific ALVR client for Apple visionOS and Apple Vision Pro.
- Interesting idea:
  a streaming client can be split into a normal SwiftUI entry/control window,
  multiple immersive spaces, RealityKit and Metal render paths, VideoToolbox
  decoding, AR/world tracking, eye broadcast, and a watchdog-backed ALVR event
  loop.
- Code-level notes:
  `ALVRClientApp.swift` configures CompositorServices layer format,
  foveation/layout choices, entry window lifecycle, settings save/load, and
  immersive-space selection. `EventHandler.swift` owns ALVR initialization,
  mDNS/Bonjour handling, connection state, frame queue, event threads, outgoing
  workers, heartbeat tracking, and restart/watchdog state. `VideoHandler.swift`
  wraps VideoToolbox decoder setup and platform pixel-format handling.
  `WorldTracker.swift`, `RealityKitClientSystem.swift`, `MetalClientSystem.swift`,
  `Renderer.swift`, and `PerformanceOverlayView.swift` show the platform-client
  split between tracking, rendering, and in-headset diagnostics.
- Code donor value:
  very high for platform-specific headset client structure, event watchdogs,
  decoder/render split, performance overlay, and settings/lifecycle boundaries.
- Product reference value:
  high for future standalone-headset utility shells that need a companion
  control window plus immersive runtime mode.
- Caveats:
  Apple private/platform APIs, ALVR ABI expectations, and Vision Pro-specific
  assumptions make this a conceptual donor, not reusable code.
- What to inspect next:
  compare with Android ALVR clients if a future pass studies standalone-client
  UI/setup differences.

## `alvr-org/Monado-ALVR`

- GitHub:
  [alvr-org/Monado-ALVR](https://github.com/alvr-org/Monado-ALVR)
- What it is:
  a Monado fork that integrates with ALVR, useful here mainly as a runtime
  bridge and documentation reference rather than as a small standalone tool.
- Interesting idea:
  runtime-side integration work should expose remote-driver configuration,
  runtime manifest generation, IPC/swapchain design, tracing, metrics, and
  driver-writing guidance as inspectable artifacts.
- Code-level notes:
  the repository carries Monado's `doc/howto-remote-driver.md`,
  `doc/ipc-design.md`, `doc/swapchains-ipc.md`, `doc/metrics.md`,
  `doc/tracing*.md`, `doc/writing-driver.md`, `doc/implementing-extension.md`,
  and `cmake/openxr_manifest.in.json`. The ALVR-specific fork is less useful as
  a compact donor than the surrounding runtime-operability documentation.
- Code donor value:
  medium for runtime manifest, remote-driver, IPC, tracing, metrics, and
  driver documentation organization.
- Product reference value:
  medium-high for future OpenXR runtime or streaming bridge diagnostics.
- Caveats:
  large fork; this wave did not attempt a full diff against upstream Monado.
- What to inspect next:
  only revisit if a future runtime-fork wave needs exact ALVR integration
  deltas.

## `alvr-org/VRCFT-ALVR`

- GitHub:
  [alvr-org/VRCFT-ALVR](https://github.com/alvr-org/VRCFT-ALVR)
- What it is:
  a VRCFaceTracking module for consuming ALVR eye and face tracking payloads.
- Interesting idea:
  tracking adapters become easier to extend when incoming payloads are
  prefix-dispatched to vendor-specific mappers and all outputs land in one
  unified eye/expression model.
- Code-level notes:
  `ALVRModule.cs` binds a UDP socket on port `0xA1F7`, reads a `FloatParams`
  stream, dispatches eight-byte prefixes such as `EyesQuat`, `CombQuat`,
  `FaceFb`, `FacePico`, `EyesHtc`, and `LipHtc`, then updates unified
  VRCFaceTracking data. `EyeTracking.cs` normalizes eye quaternions into gaze.
  `FbFaceTracking.cs`, `PicoFaceTracking.cs`, and `HtcFaceTracking.cs` map
  vendor expression enums into unified expression weights and eye openness.
- Code donor value:
  high for prefix-dispatched tracking packet parsing and vendor-to-unified
  expression remapping.
- Product reference value:
  high for adapter-style utilities where runtime/vendor payloads need to be
  translated into stable app-facing signals.
- Caveats:
  tightly coupled to VRCFaceTracking and ALVR packet conventions.
- What to inspect next:
  compare with Wave 106 VRCFaceTracking module templates and blendshape
  preparation references.

## `AtlasTheProto/ADBForwarder`

- GitHub:
  [AtlasTheProto/ADBForwarder](https://github.com/AtlasTheProto/ADBForwarder)
- What it is:
  a console utility for forwarding ALVR-related TCP ports between a PC and
  Quest/Go devices over USB.
- Interesting idea:
  setup friction can be productized as a tiny statusful repair tool: locate or
  download a platform dependency, start its service, monitor devices, apply the
  required port forwards, and print simple success/failure messages.
- Code-level notes:
  `Program.cs` selects platform-specific ADB paths, downloads platform tools
  when needed, starts the ADB server through `SharpAdbClient`, starts a device
  monitor, filters supported HMD products, forwards ports, and reports skipped
  or successfully forwarded devices.
- Code donor value:
  medium-high for setup-helper anatomy, dependency discovery, device monitor,
  and user-readable status loop.
- Product reference value:
  high for future `VR-apps-lab` micro-tools that repair runtime/network setup.
- Caveats:
  old headset list and ALVR-specific port assumptions; do not vendor ADB or
  platform tools into this repository.
- What to inspect next:
  compare with WiVRn/systemd launch helpers if a setup-doctor branch appears.

## `Kierek/WiVRnTimings`

- GitHub:
  [Kierek/WiVRnTimings](https://github.com/Kierek/WiVRnTimings)
- What it is:
  a small Kotlin/Compose desktop viewer for timing preset CSV files.
- Interesting idea:
  latency and timing work can start as a file parser plus quick visual surface,
  not as a full telemetry suite.
- Code-level notes:
  `PresetsParser.kt` scans CSV files, groups rows by frame and part, stores
  timing fields into `PartData`, and produces `PresetFile` summaries. `Main.kt`
  creates a Compose UI that lists parsed presets, frame counts, and part
  information.
- Code donor value:
  medium for parser-to-visualizer micro-utility structure.
- Product reference value:
  medium for timing/latency inspection sidecars.
- Caveats:
  very small and lightly documented; useful mostly as micro-utility evidence.
- What to inspect next:
  compare against richer frame timing tools if streaming telemetry becomes an
  active branch.

## Cross-project synthesis

These projects reinforce a compact `streaming ecosystem companion` family:

- platform client shell: entry window, settings, immersive mode, renderer,
  decoder, tracking, diagnostics;
- runtime bridge: manifest, remote-driver config, tracing, metrics, IPC docs;
- tracking adapter: packet prefix, vendor payload parser, unified output model;
- setup helper: dependency discovery, device monitor, port forward, status;
- timing viewer: parse file/stream data, surface quick inspection.

The strongest reusable method is not video streaming itself. It is the habit of
turning difficult setup/runtime/tracking edges into small inspectable companion
tools.

## Follow-up

1. Extract a generic setup-doctor pattern for VR runtime helpers.
2. Compare `VRCFT-ALVR` with VRCFaceTracking module templates from Wave 106.
3. Keep platform-client sidecars visible as a separate family from mainline
   streaming stacks.
