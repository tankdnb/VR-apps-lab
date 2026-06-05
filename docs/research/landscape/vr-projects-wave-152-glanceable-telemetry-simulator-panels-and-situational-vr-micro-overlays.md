# VR Projects Wave 152: Glanceable Telemetry, Simulator Panels, and Situational VR Micro-Overlays

- Date: `2026-06-05`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 152 studies small utilities that surface a narrow state in or around VR:
cable rotation, Vive Wireless temperature, GPU/VRAM telemetry, simulator
telemetry, and Twitch chat. The common lesson is that many useful VR tools are
not full applications. They are tiny, glanceable surfaces with strong data
ingress, readable presentation, and minimal user interruption.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `Nexz/turncountervr` | Cable-awareness and comfort micro-overlays | Concept donor, light code donor |
| `Denwa/vive-wireless-info-overlay` | Device-status micro-overlays | Source-light product reference |
| `yydsok520/gpu-vram-monitor` | Hardware telemetry and control overlays | Strong desktop utility donor, VR-adjacent |
| `JMmayranpaa/RacingManager` | Simulator telemetry panels and launchers | Strong telemetry/windowing donor, VR-adjacent |
| `ironsled/vr-twitch-chat-ui` | In-host communication panels | Strong UX/settings donor |

## `Nexz/turncountervr`

- Interesting idea:
  a dashboard overlay counts user rotation so a Vive cable can be untangled
  without taking the headset off.
- Code donor value:
  medium-low. The code is small and dated, but it demonstrates deriving a
  comfort signal from HMD pose and presenting it as a tiny OpenVR overlay.
- Product reference value:
  medium. The product is intentionally tiny and solves one high-friction
  physical VR problem.
- What to inspect next:
  compare with comfort, cable-management, and metrics overlays before designing
  a generic `pose-derived comfort signal` module.
- Architecture pattern:
  C# OpenVR overlay app initializes as `VRApplication_Overlay`, creates a
  dashboard overlay, polls `GetDeviceToAbsoluteTrackingPose`, converts the HMD
  matrix into a coarse facing quadrant, tracks quadrant crossings, and refreshes
  a generated PNG texture when the overlay is visible.
- Caveats:
  assumes HMD device index `0`, uses file-based texture refresh through
  `SetOverlayFromFile`, and should be treated as a concept baseline rather than
  modern production code.

## `Denwa/vive-wireless-info-overlay`

- Interesting idea:
  a dedicated Vive Wireless Adapter temperature overlay shows adapter thermal
  state at a slow, readable cadence.
- Code donor value:
  low. The public repository is source-light and currently exposes mostly
  README-level behavior and a screenshot.
- Product reference value:
  medium. The focused framing is good: one device-specific health value in VR
  is enough to justify a utility.
- What to inspect next:
  revisit only if fuller source, tags, or implementation details become
  available.
- Architecture pattern:
  product-level pattern only: device-specific polling plus a small overlay,
  reportedly updating `mTemperature` and `rTemperature` around every five
  seconds.
- Caveats:
  do not treat this as a code donor in its current public form.

## `yydsok520/gpu-vram-monitor`

- Interesting idea:
  a Windows desktop overlay and tray app tracks GPU memory junction
  temperature, core temperature, board power, clocks, fan RPM, fan control, and
  power-limit presets.
- Code donor value:
  high for telemetry/control-loop utility design, medium for direct VR reuse.
  It is not a native VR overlay, but it is a strong donor for the data and
  safety side of a VR hardware monitor.
- Product reference value:
  high. It demonstrates how one strong hardware pain point can become a compact
  utility with tray presence, topmost overlay, and control affordances.
- What to inspect next:
  split hardware polling, presentation, and control policy before adapting it
  into any VR-visible overlay or desktop-capture surface.
- Architecture pattern:
  .NET 8 WinForms single-instance tray app with a polling timer,
  `LibreHardwareMonitor` sensor reader, `nvidia-smi` power-limit integration,
  motherboard fan-control discovery, and a layered-window topmost overlay with
  rounded alpha, fan slider, auto/manual mode, and preset buttons.
- Reusable method:
  hardware telemetry overlay with explicit fallback behavior when sensors are
  absent, plus cleanup that restores fan behavior on dispose.
- Caveats:
  desktop-only, NVIDIA/Windows-biased, and some controls require administrator
  rights or hardware-specific SuperIO sensor names.

## `JMmayranpaa/RacingManager`

- Interesting idea:
  a Qt utility reads iRacing shared memory, presents telemetry overlays, and
  launches supporting apps from a saved configuration.
- Code donor value:
  high for simulator telemetry ingestion and utility-window structure.
- Product reference value:
  medium-high. The value is practical: one companion utility can own telemetry,
  overlay toggles, and session app launch.
- What to inspect next:
  compare the shared-memory reader and overlay manager with earlier simulator
  overlays and motion-cueing sidecars.
- Architecture pattern:
  C++20/Qt app maps `Local\\IRSDKMemMapFileName`, resolves `irsdk_header` and
  variable headers by name, reads floats/ints from the latest var buffer, then
  feeds frameless translucent topmost Qt windows on a fast timer.
- Reusable method:
  simulator shared-memory telemetry poller plus draggable topmost widgets and a
  detached app launcher backed by a JSON config under the app config directory.
- Caveats:
  desktop overlay rather than OpenVR/OpenXR overlay, so reuse should focus on
  telemetry and window-management lessons.

## `ironsled/vr-twitch-chat-ui`

- Interesting idea:
  an MSFS 2024 in-game panel connects to Twitch IRC and adapts chat readability
  for desktop versus VR use.
- Code donor value:
  medium-high for panel UX, settings persistence, reconnect logic, and provider
  normalization.
- Product reference value:
  high. It is a good example of a utility embedded into a host simulator rather
  than rendered as an external overlay.
- What to inspect next:
  extract a general `VR readability profile` checklist for chat, subtitles,
  kneeboards, and telemetry panels.
- Architecture pattern:
  Coherent/HTML custom panel connects to Twitch IRC over WebSocket as an
  anonymous user, requests tags/commands, joins a channel, detects VR mode
  through simulator state or resolution heuristics, persists settings, and
  applies separate desktop/VR font profiles and transparent-background options.
- Reusable method:
  provider-normalized chat fan-in with watchdog reconnect, emote caching,
  message caps, pinned positioning, and VR-specific typography settings.
- Caveats:
  MSFS-specific host APIs and panel lifecycle mean the exact implementation is
  not portable, but the settings and readability model are broadly reusable.

## Cross-Project Lessons

- A micro-overlay can be valuable when the state is physically relevant,
  time-sensitive, and glanceable.
- Native VR overlay code is not the only donor class. Desktop windows,
  simulator panels, and host-embedded HTML panels can still teach data ingress,
  settings, readability, and control-loop patterns.
- Source-light projects should be retained as product references only when the
  utility framing is strong enough to guide future product design.
- Telemetry overlays should separate polling, safety/control policy, and
  presentation before being reused inside `VR-apps-lab`.

## Reusable Methods Extracted

- Pose-derived comfort micro-overlay.
- Hardware sensor telemetry overlay with tray, fan curve, and power-limit
  controls.
- Simulator shared-memory telemetry poller plus topmost utility widgets.
- VR/desktop readability profile switch for in-host web panels.

## Follow-Up Backlog

- Build a compact `glanceable status surface` checklist that covers update
  cadence, typography, warning thresholds, and dismissal behavior.
- Compare simulator shared-memory, OSC, WebSocket, and hardware sensor polling
  as four utility data-ingress styles.
- Keep source-light device overlays in product-reference lanes unless stronger
  code appears.
