# VR Projects Wave 9: Runtime Intelligence, Overlay Hosts, and Dev Helpers

- Date: `2026-04-18`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet in `VR.app`, focusing on runtime intelligence tools, headless overlay
  hosts, dashboard micro-utilities, and tracking-development helpers.

## Why this wave exists

The repository already had strong coverage of:

- large utility suites;
- classic OpenVR overlays;
- OpenXR runtime switchers;
- tracker bridges and battery tools.

What was still missing was a more explicit layer of:

- `runtime intelligence` and capability data tools;
- `headless or hidden-window overlay hosts`;
- `dashboard micro-utilities` tied to audio, VRChat, and streaming;
- `tracking-development helpers` that are useful without becoming full custom
  drivers.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with focused queries;
2. deduplicate against the registry;
3. freeze a shortlist;
4. sync only that shortlist into `.research-sources/github/`;
5. inspect code and structure;
6. promote the findings into the catalog, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `KhronosGroup/OpenXR-Inventory` | Structured capability inventory for runtimes and middleware |
| `rpavlik/xr-picker` | Cross-platform runtime picker with a clean core/gui split |
| `ValveSoftware/OpenXR-Canonical-Pose-Tool` | Runtime-comparison and pose-validation utility |
| `elliotttate/OpenXR-Simulator` | Headsetless OpenXR runtime for development and desktop preview |
| `Hotrian/HeadlessOverlayToolkit` | Early but important Unity headless/background overlay-host pattern |
| `rrkpp/SpotifyOverlay` | Dashboard micro-utility with Qt offscreen rendering |
| `cnlohr/openvr_overlay_model` | Experimental stereo-per-eye overlay trick for pseudo-3D content |
| `JoeLudwig/overlay_experiments` | Browser-backed OpenVR dashboard overlay experiments |
| `rrazgriz/VRCMicOverlay` | High-quality C# mic-status overlay with minimal loop design |
| `I5UCC/VRCTextboxSTT` | Local STT service that also exposes a SteamVR overlay path |
| `I5UCC/SteaMeeter` | Unity dashboard app controlling an external audio system |
| `ugokutennp/watchman-pairing-assistant` | GUI wrapper around `lighthouse_console` pairing workflow |
| `TriadSemi/triad_openvr` | Python wrapper that simplifies device access and tracking data use |

## Deep-pass notes by project

## `KhronosGroup/OpenXR-Inventory`

- GitHub:
  [KhronosGroup/OpenXR-Inventory](https://github.com/KhronosGroup/OpenXR-Inventory)
- What it is:
  a machine-readable inventory of OpenXR runtime and middleware extension
  support that is rendered into a public support report.
- Why it matters:
  it adds a pattern `VR.app` did not previously represent clearly enough:
  capability intelligence as structured data instead of only prose notes.
- Interesting ideas:
  split inventories for `runtimes` and `clients`; schema-backed JSON files;
  static report generation; runtime entries include extensions, form factors,
  view configurations, and environment blend modes.
- Interesting implementation choices:
  Python dataclasses parse inventory JSON into typed runtime/client entries;
  Jinja templating and reusable inventory modules make it suitable for report
  generation or future diagnostic tooling.
- Code donor value:
  medium-high for data-driven `OpenXR Doctor` or compatibility reporting.
- Product reference value:
  high for capability dashboards and public support matrices.
- Architecture reference value:
  high for `inventory data -> parser -> report` architecture.
- Caveats:
  this is a community-maintained knowledge source, not an always-live runtime
  probe.
- What to inspect next:
  diff/report generation paths and whether `VR.app` should adopt a similar
  machine-readable compatibility layer.

## `rpavlik/xr-picker`

- GitHub:
  [rpavlik/xr-picker](https://github.com/rpavlik/xr-picker)
- What it is:
  a cross-platform OpenXR runtime picker with a Rust core crate and an `egui`
  GUI frontend.
- Why it matters:
  this is one of the cleanest public references for a `runtime management`
  utility, and it is noticeably stronger architecturally than many small
  switchers.
- Interesting ideas:
  preserve manually added extra runtimes between sessions; distinguish Windows
  32-bit and 64-bit active-state combinations; use heuristics to name runtimes
  when manifests are incomplete.
- Interesting implementation choices:
  core logic separated from GUI; strong typed error model; `unsafe` forbidden;
  platform-specific runtime discovery hidden behind a common platform trait;
  refresh logic keeps existing ordering while deduplicating runtime manifests.
- Code donor value:
  high for runtime-inspection and runtime-switching logic.
- Product reference value:
  high for a future `OpenXR Doctor`.
- Architecture reference value:
  very high.
- Caveats:
  it focuses on runtime selection, not full diagnostics or layer state.
- What to inspect next:
  platform modules, privilege strategy on Windows, and persistent extra-manifest
  UX.

## `ValveSoftware/OpenXR-Canonical-Pose-Tool`

- GitHub:
  [ValveSoftware/OpenXR-Canonical-Pose-Tool](https://github.com/ValveSoftware/OpenXR-Canonical-Pose-Tool)
- What it is:
  a utility that outputs pose-reference files so runtime vendors can compare
  their action poses against intended "canonical" controller poses.
- Why it matters:
  it expands the calibration family beyond user-facing alignment tools into
  `vendor/developer validation` tooling.
- Interesting ideas:
  XML-driven configuration for runtimes, interaction profiles, actions, output
  items, and extension requirements; runtime names are normalized through regex
  matching before output.
- Interesting implementation choices:
  item-set architecture; one-shot frame-loop behavior that waits for a focused
  session, extracts the configured pose set, writes XML outputs, then exits;
  same project supports PC and Quest standalone.
- Code donor value:
  medium-high for developer-facing calibration and validation tools.
- Product reference value:
  medium-high for future pose-check and reference tools.
- Architecture reference value:
  high.
- Caveats:
  it is much more of a vendor/dev workflow tool than a consumer utility.
- What to inspect next:
  additional item sets, runtime reference comparison flow, and whether similar
  ideas can support `VR.app` calibration helpers.

## `elliotttate/OpenXR-Simulator`

- GitHub:
  [elliotttate/OpenXR-Simulator](https://github.com/elliotttate/OpenXR-Simulator)
- What it is:
  a lightweight OpenXR runtime that lets applications run in a desktop window
  without a physical headset.
- Why it matters:
  it adds a valuable `headsetless runtime for dev/testing` pattern that is
  highly relevant to tooling and validation work.
- Interesting ideas:
  desktop preview with stereo side-by-side output; mouse/keyboard input as a
  development interaction path; registration/unregistration scripts that back up
  the existing runtime.
- Interesting implementation choices:
  direct runtime implementation in native C++; support for D3D11, D3D12, and
  OpenGL; persistent preview window; explicit log file; D3D12 path uses a
  GDI-based presentation workaround to avoid overlay-hook conflicts.
- Code donor value:
  high for runtime simulation and test harness work.
- Product reference value:
  medium-high for developer tooling.
- Architecture reference value:
  high.
- Caveats:
  the project still presents as early-stage and some README links or names are
  placeholder-like.
- What to inspect next:
  action emulation depth, registration flow hardening, and how validation-layer
  or recording features could extend the tool.

## `Hotrian/HeadlessOverlayToolkit`

- GitHub:
  [Hotrian/HeadlessOverlayToolkit](https://github.com/Hotrian/HeadlessOverlayToolkit)
- What it is:
  a stripped SteamVR Unity project with a custom overlay layer focused on
  multi-overlay support and hidden-window/background-host behavior.
- Why it matters:
  it documents a powerful pattern that is still useful today:
  `run a Unity app mostly as an overlay host, not as a visible desktop app`.
- Interesting ideas:
  multiple simultaneous overlays; world/controller/screen attachment; gaze
  animations; custom tracked-device manager because stock controller assignment
  was unreliable.
- Interesting implementation choices:
  unique overlay keys per instance; cached-change update pattern; only one
  high-quality overlay at a time; off-screen/hidden desktop window strategy
  instead of true `-batchmode`; attachment-point abstraction for controllers.
- Code donor value:
  medium-high for Unity-hosted overlay services.
- Product reference value:
  high for background utility overlays.
- Architecture reference value:
  high.
- Caveats:
  tightly tied to old Unity and old SteamVR plugin assumptions; author points to
  a more modern `redux` branch.
- What to inspect next:
  the `redux` branch, the custom inspector UX, and how much of the attachment
  model still generalizes well.

## `rrkpp/SpotifyOverlay`

- GitHub:
  [rrkpp/SpotifyOverlay](https://github.com/rrkpp/SpotifyOverlay)
- What it is:
  a SteamVR dashboard overlay that acted as a third-party Spotify client.
- Why it matters:
  even though the product is defunct, it is still a strong `dashboard
  micro-utility` reference.
- Interesting ideas:
  auto-registering dashboard overlay with SteamVR; reconnect strategy when the
  target desktop app is not running on first launch; keyboard-driven search
  inside the overlay.
- Interesting implementation choices:
  Qt `QGraphicsScene` rendered into an FBO, then uploaded to the overlay as an
  OpenGL texture; dashboard overlay plus thumbnail overlay; mouse input routed
  from OpenVR overlay events into the Qt scene.
- Code donor value:
  medium for Qt/OpenVR dashboard patterns.
- Product reference value:
  high for focused media-control overlays.
- Architecture reference value:
  high for `toolkit GUI -> offscreen framebuffer -> VR dashboard overlay`.
- Caveats:
  the integration broke when Spotify changed the desktop client behavior.
- What to inspect next:
  manifest generation, thumbnail refresh path, and whether the Qt input-routing
  pattern can inform future `VR.app` overlays.

## `cnlohr/openvr_overlay_model`

- GitHub:
  [cnlohr/openvr_overlay_model](https://github.com/cnlohr/openvr_overlay_model)
- What it is:
  an experimental OpenVR overlay that renders different imagery per eye to make
  a 2D overlay behave like a pseudo-3D model.
- Why it matters:
  this is a rare public example of using overlay mechanics for
  `stereo-per-eye illusion`, not just flat UI.
- Interesting ideas:
  use `VROverlayFlags_SideBySide_Parallel` to feed separate eye images; render a
  3D model into a texture pair and present it as a single overlay aimed at the
  user.
- Interesting implementation choices:
  plain C implementation; hidden rawdraw/OpenGL host window; direct OpenVR C
  API tables; custom math helpers and texture-bounds control; companion file in
  the repo also shows a battery-monitor overlay pattern.
- Code donor value:
  medium-high for unusual overlay rendering techniques.
- Product reference value:
  medium.
- Architecture reference value:
  high for advanced overlay experimentation.
- Caveats:
  very experimental and intentionally "cursed"; not a polished product base.
- What to inspect next:
  whether the stereo-overlay trick can support more readable 3D indicators or
  object markers in future utilities.

## `JoeLudwig/overlay_experiments`

- GitHub:
  [JoeLudwig/overlay_experiments](https://github.com/JoeLudwig/overlay_experiments)
- What it is:
  a set of OpenVR dashboard overlay experiments that render web pages via
  Awesomium.
- Why it matters:
  it is one of the clearest historic references for the `web UI inside overlay`
  approach.
- Interesting ideas:
  multiple browser overlays from one host; explicit intention to inspire other
  overlay products; planned JavaScript hooks into OpenVR APIs.
- Interesting implementation choices:
  SDL hidden OpenGL context; Awesomium off-screen rendering; `CWebOverlay`
  instances updated every frame; explicit security note about not treating the
  stack like a safe general-purpose browser.
- Code donor value:
  high for historical/browser-overlay architecture.
- Product reference value:
  high for web-based dashboards and external-control surfaces.
- Architecture reference value:
  high.
- Caveats:
  Awesomium is old and not a modern browser stack.
- What to inspect next:
  `common/weboverlay` internals, texture update path, and how this could be
  translated into a modern Chromium/CEF or WebView-based overlay stack.

## `rrazgriz/VRCMicOverlay`

- GitHub:
  [rrazgriz/VRCMicOverlay](https://github.com/rrazgriz/VRCMicOverlay)
- What it is:
  a C# OpenVR overlay that shows a custom microphone icon and audio cues for
  VRChat.
- Why it matters:
  it is an excellent example of a reliable `status micro-overlay` with a very
  small runtime footprint.
- Interesting ideas:
  generated `settings.json`; overlay always attached relative to the HMD;
  icon-shifting to reduce display burn-in; OSCQuery used to avoid conflicts with
  other OSC listeners.
- Interesting implementation choices:
  console app with a tight inner loop; OpenVR overlay autostart setup; settings
  validation on startup; optional top-most sort order; direct audio-device
  monitoring to infer muted mic activity even when VRChat itself stops sending
  voice level updates.
- Code donor value:
  high for lightweight C# overlay architecture.
- Product reference value:
  high for status overlays and assistive HUDs.
- Architecture reference value:
  high.
- Caveats:
  optimized for one problem and one ecosystem rather than broad reusability.
- What to inspect next:
  autostart flow, asset packaging, and whether the same loop pattern can support
  other tiny status overlays in `VR.app`.

## `I5UCC/VRCTextboxSTT`

- GitHub:
  [I5UCC/VRCTextboxSTT](https://github.com/I5UCC/VRCTextboxSTT)
- What it is:
  a local speech-to-text application that can output to VRChat text channels,
  KAT, OBS, WebSocket clients, and a SteamVR overlay.
- Why it matters:
  it is a very strong `service + overlay + OSC + accessibility` reference.
- Interesting ideas:
  one transcription engine powers multiple output channels; Steam Input action
  path for VR-side trigger control; language-specific overlay fonts; overlay is
  treated as a helper surface, not the only output.
- Interesting implementation choices:
  Python application with OpenVR overlay path; generates the overlay image in
  Pillow, then uploads it with `setOverlayRaw`; registers an app manifest and
  action manifest; retries overlay init on request failures; combines local STT,
  translation, OSC, WebSocket, browsersource, and VR overlay output.
- Code donor value:
  high for service-oriented VR utility architecture.
- Product reference value:
  high for accessibility and communication tools.
- Architecture reference value:
  very high.
- Caveats:
  large dependency surface and strong VRChat-specific assumptions.
- What to inspect next:
  binding manifests, updater/install path, and how the overlay path cooperates
  with the rest of the service outputs.

## `I5UCC/SteaMeeter`

- GitHub:
  [I5UCC/SteaMeeter](https://github.com/I5UCC/SteaMeeter)
- What it is:
  a SteamVR dashboard application that controls Voicemeeter virtual inputs and
  also exposes OSCQuery/VRChat control paths.
- Why it matters:
  it is one of the strongest examples of a `dashboard as remote-control surface
  for an external desktop app`.
- Interesting ideas:
  load one Voicemeeter profile on SteamVR startup and another on shutdown;
  dashboard sliders and controls mirrored to OSCQuery endpoints; media-control
  endpoints built into the same VR panel.
- Interesting implementation choices:
  Unity app with `OVRLay`-based overlay infrastructure; `app.vrmanifest`
  dashboard registration; INI-based config; OSC receiver/sender plus OSCQuery
  service; Unity-main-thread dispatcher used to bridge asynchronous input into
  UI changes; hidden-window/tray support via `WindowController`.
- Code donor value:
  high for dashboard utilities that control external software.
- Product reference value:
  high for audio, stream, and automation surfaces.
- Architecture reference value:
  high.
- Caveats:
  depends on Voicemeeter Potato and a fairly niche user workflow.
- What to inspect next:
  scene/UI structure, OVRLay integration details, and the profile/persistence
  flow for more general automation dashboards.

## `ugokutennp/watchman-pairing-assistant`

- GitHub:
  [ugokutennp/watchman-pairing-assistant](https://github.com/ugokutennp/watchman-pairing-assistant)
- What it is:
  a GUI wrapper for pairing SteamVR tracking devices using
  `lighthouse_console`.
- Why it matters:
  it shows a very practical pattern for `GUI around an existing vendor/SteamVR
  command-line tool`.
- Interesting ideas:
  serial-focused UI; per-device action buttons plus global bulk actions;
  configurable path to `lighthouse_console.exe`; status polling and delayed
  refresh.
- Interesting implementation choices:
  built in Python with `customtkinter`; command execution handled via
  subprocesses and timers; parses serials and maps them into coarse device
  categories such as Tundra or Index firmware dongles.
- Code donor value:
  medium for wrapper-utility architecture.
- Product reference value:
  high for pairing/setup helper flows.
- Architecture reference value:
  medium-high.
- Caveats:
  heavily dependent on the behavior and output format of `lighthouse_console`.
- What to inspect next:
  command mapping completeness, error handling, and how the wrapper behaves when
  multiple dongles or device classes are mixed.

## `TriadSemi/triad_openvr`

- GitHub:
  [TriadSemi/triad_openvr](https://github.com/TriadSemi/triad_openvr)
- What it is:
  an enhanced Python wrapper around `pyopenvr` that makes SteamVR device access
  easier and more analysis-friendly.
- Why it matters:
  it is a strong reference for `OpenVR scripting and tooling` without forcing
  users into a full compiled application.
- Interesting ideas:
  serial-stable naming via `config.json`; device classes exposed as easy Python
  objects; pose sampling buffers; Euler/quaternion conversion helpers; simple
  controller input dictionary.
- Interesting implementation choices:
  wrapper classes for tracked devices; event polling that auto-adds and removes
  devices; sample buffering with timestamps; optional UDP emitter/receiver
  helpers in the repository.
- Code donor value:
  high for Python prototypes, analysis tools, and external bridges.
- Product reference value:
  medium-high for scripting helpers and research tools.
- Architecture reference value:
  high.
- Caveats:
  still depends on the underlying `pyopenvr` ecosystem and older Python/OpenVR
  assumptions.
- What to inspect next:
  UDP paths, device-role handling, and whether a modernized `VR.app` Python tool
  layer should adopt similar serial-stable naming behavior.

## Repositories discovered in this wave but not yet deeply studied

| Project | Why it matters next |
|---|---|
| `Ybalrid/OpenXR-Runtime-Manager` | Another runtime-manager UX variant that should be compared directly against `xr-picker` and the existing switcher family |
| `clear-xr/clearxr-server` | App + OpenXR layer combination that may add packaging and registration ideas |
| `pembem22/etvr-openxr-layer` | Useful bridge example for forwarding OSC eye-gaze data into an OpenXR-native interface |
| `Martin-Oehler/SteamVR-WebApps` | Shows how multiple dashboard apps can be packaged on top of `SteamVR-Webkit` |
| `I5UCC/ParameterSaveStates` | Dashboard profile manager for VRChat parameters and per-avatar state |
| `Denwa/vive-wireless-info-overlay` | Hardware-status micro-overlay for Vive Wireless temperature monitoring |
| `hai-vr/h-view` | Dev-facing ImGui/OSCQuery SteamVR overlay and VR development playground |
| `MeroFune/GOpy` | OSC-driven VRChat gesture overlay node |
| `biosmanager/unity-openvr-tracking` | Unity-side SteamVR tracking path that tries to avoid the null-driver/HMD requirement problem |
| `MuffinTastic/openvr-device-positions` | Tracker-position export tool that may fit the creator/workflow family |

## Main conclusions from this wave

1. `VR.app` needed better coverage of `runtime intelligence` as a first-class
   utility category, not only switchers and overlays.
2. `Headless or hidden-window overlay hosts` are now clearly a reusable method,
   not just an implementation quirk.
3. `Dashboard micro-utilities` tied to audio, STT, VRChat, and desktop apps are
   a strong recurring product family.
4. `Tracking development helpers` deserve more attention even when they are not
   full driver stacks.
5. The repository can now describe a more complete path from:
   `runtime inventory -> runtime picker -> runtime simulator -> overlay host ->
   micro-utility/dashboard`.
