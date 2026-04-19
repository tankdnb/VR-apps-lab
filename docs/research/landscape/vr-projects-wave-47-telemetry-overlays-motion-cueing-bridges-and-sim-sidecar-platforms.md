# VR Projects Wave 47: Telemetry Overlays, Motion-Cueing Bridges, and Sim-Sidecar Platforms

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `simulation telemetry overlays`, `motion-cueing bridges`, and
  `sim-sidecar platforms`.

## Why this wave exists

`VR-apps-lab` already had overlays and runtime-side helpers, but one
VR-adjacent systems branch was still too diffuse:

- mature telemetry overlay hosts with modular widgets and presets;
- sidecars that translate simulator data into force feedback or motion-device
  behavior;
- bridges that normalize many unsupported games into standard telemetry outputs;
- research simulator stacks that already combine VR, rich sensors, and replay.

This wave exists to make
`simulation telemetry overlays, motion-cueing bridges, and sim-sidecar
platforms`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with telemetry-overlay, force-feedback, and simulator-platform
   queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `TinyPedal/TinyPedal` | Strong donor for a modular telemetry overlay host with adapters, widget packs, and preset logic |
| `walmis/VPforce-TelemFFB` | Strong donor for a multi-instance simulator sidecar that maps telemetry into force-feedback devices |
| `PHARTGAMES/SpaceMonkey` | Strong donor for telemetry normalization across unsupported games into common outputs |
| `SimFeedback/SimFeedback-AC-Servo` | Strong donor for a motion-platform ecosystem with telemetry providers and extension boundaries |
| `HARPLab/DReyeVR` | Strong donor for a research simulator platform that already combines VR, sensors, and replay |
| `giuseppdimaria/Unity-VRlines` | Useful comparison node for an embodied XR control-surface prototype built around flight controls |

## Secondary candidates surfaced in the same wave

No secondary candidate in this wave was stronger than the frozen shortlist.

## Deep-pass notes by project

## `TinyPedal/TinyPedal`

- GitHub:
  [TinyPedal/TinyPedal](https://github.com/TinyPedal/TinyPedal)
- What it is:
  a cross-platform racing telemetry overlay application with modular widgets,
  adapters, presets, and tray-style overlay control.
- Why it matters:
  it is the clearest donor in the repo for
  `modular telemetry overlay host with adapter and widget boundaries`.
- Interesting ideas:
  keep overlay state and widget lifecycle separate; drive features through
  modules and widgets instead of one huge monolith; auto-load presets when
  classes or contexts change; pair a lightweight overlay with a deeper desktop
  config shell.
- Interesting implementation choices:
  `overlay_control.py` and
  `module_control.py`
  make the `adapter state -> overlay state -> widget module lifecycle -> preset
  reload` path explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  simulator-specific inputs remain, but the host structure generalizes well.
- What to inspect next:
  keep it visible whenever a future branch needs
  `desktop host plus lightweight always-on-top overlay`.

## `walmis/VPforce-TelemFFB`

- GitHub:
  [walmis/VPforce-TelemFFB](https://github.com/walmis/VPforce-TelemFFB)
- What it is:
  a large Python and Qt application that reads simulator telemetry and maps it
  into force-feedback behavior across multiple device roles.
- Why it matters:
  it is the clearest donor in the repo for
  `multi-instance telemetry sidecar with device-role ownership and IPC`.
- Interesting ideas:
  make master and child instances explicit; split joystick, pedals, collective,
  and trimwheel ownership; keep telemetry listeners, settings, IPC, and device
  orchestration distinct; let one sidecar own lifecycle and effects for several
  peripherals without collapsing into one unstructured process.
- Interesting implementation choices:
  `main.py`
  makes the `argument parsing -> device-role config -> IPC network ->
  telemetry listener -> main window` flow explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  device and domain assumptions are specific, but the sidecar architecture is
  broadly reusable.
- What to inspect next:
  keep it visible whenever a future branch needs
  `multi-peripheral sidecar ownership`.

## `PHARTGAMES/SpaceMonkey`

- GitHub:
  [PHARTGAMES/SpaceMonkey](https://github.com/PHARTGAMES/SpaceMonkey)
- What it is:
  a broad telemetry bridge platform for unsupported games that exports common
  formats over UDP, MMF, or callback outputs.
- Why it matters:
  it is the clearest donor in the repo for
  `telemetry normalization bridge across many native and injected sources`.
- Interesting ideas:
  normalize unsupported games into one target protocol; keep output transports
  configurable; layer filters and outputs on top of many provider-specific
  acquisition paths; support both standalone app mode and callback-driven
  embedding.
- Interesting implementation choices:
  `TelemetrySender.cs` and
  `TelemetryOutputMMF.cs`
  make the `provider -> normalized packet -> UDP or MMF output` path explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  breadth is high enough that not every provider is equally strong, but the
  output-normalization story is the main donor.
- What to inspect next:
  keep it visible whenever a future branch needs
  `one bridge that hides many incompatible game telemetry sources`.

## `SimFeedback/SimFeedback-AC-Servo`

- GitHub:
  [SimFeedback/SimFeedback-AC-Servo](https://github.com/SimFeedback/SimFeedback-AC-Servo)
- What it is:
  a motion-platform ecosystem for DIY actuators, telemetry providers, and
  extensions.
- Why it matters:
  it is the clearest donor in the repo for
  `motion-platform ecosystem with telemetry providers plus extension facade`.
- Interesting ideas:
  pair software, electronics, and hardware guidance in one ecosystem; keep
  telemetry providers modular; expose a stable extension facade for add-ons and
  custom behaviors.
- Interesting implementation choices:
  `AbstractSimFeedbackExtension.cs`
  makes the `extension metadata -> facade -> start or stop lifecycle` boundary
  explicit.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  the broader ecosystem value is stronger than any one code file.
- What to inspect next:
  keep it visible whenever a future branch needs
  `extensions over a telemetry-driven motion platform`.

## `HARPLab/DReyeVR`

- GitHub:
  [HARPLab/DReyeVR](https://github.com/HARPLab/DReyeVR)
- What it is:
  a VR driving simulator built on top of CARLA, with a VR ego vehicle, eye and
  user-input sensors, recorder and replayer support, and research-oriented data
  streaming.
- Why it matters:
  it is the clearest donor in the repo for
  `research simulator platform split across VR runtime, sensor stream, and
  recorder or replayer`.
- Interesting ideas:
  extend a large simulator instead of building a thin desktop sidecar; treat the
  ego sensor as an explicit data product; support recording, replay, custom
  actors, and external Python clients as first-class parts of the platform.
- Interesting implementation choices:
  `Carla/Sensor/DReyeVRSensor.cpp` and
  `Carla/Recorder/DReyeVRRecorder.h`
  make the `aggregate sensor data -> serialize to clients -> record and replay`
  boundary explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  much broader than an ordinary utility app, but still valuable as a systems
  donor.
- What to inspect next:
  keep it visible whenever a future branch needs a richer
  `VR simulator plus analytics pipeline` reference.

## `giuseppdimaria/Unity-VRlines`

- GitHub:
  [giuseppdimaria/Unity-VRlines](https://github.com/giuseppdimaria/Unity-VRlines)
- What it is:
  a Unity XR flight-simulator prototype with modular aircraft physics and
  SteamVR controller mappings.
- Why it matters:
  it is a useful comparison node for
  `embodied XR control surface over a simulator shell`.
- Interesting ideas:
  map discrete controller actions and analog axes into aircraft-specific control
  surfaces; keep aircraft physics modules separate from VR input mapping.
- Interesting implementation choices:
  `ViveController.cs`
  makes the `SteamVR actions -> airplane controller commands` path explicit.
- Code donor value:
  medium.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium.
- Caveats:
  the manuscript moved to another repo and the remaining public snapshot is a
  narrower code donor than the other projects in this wave.
- What to inspect next:
  keep it visible whenever a future branch needs
  `XR control-surface prototypes` rather than mature sidecar platforms.

## Main takeaways from Wave 47

- `Simulation sidecars` are now a distinct family, not just unrelated sim-rig
  curiosities.
- The strongest split in this family is:
  - `modular telemetry overlay host`
  - `multi-instance force-feedback sidecar`
  - `telemetry normalization bridge`
  - `motion-platform ecosystem with extensions`
  - `research simulator platform with replay`
  - `XR simulator control-surface prototype`
- The most reusable lesson is that mature simulator tooling often separates
  `telemetry acquisition`, `desktop or overlay UX`, `device-effect outputs`, and
  `research replay analytics` much more cleanly than many smaller VR utilities
  do.
