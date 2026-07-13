# Wave 355: MR Digital Twin Safety Drone Robot and Industrial Control Surfaces

## Scope

This wave studies MR projects where real-world context, spatial anchors, JSON or
API data, dashboards, annotations, mode systems, and control commands meet. The
reusable lesson is a safety-first digital-twin surface rather than a raw control
panel.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `mr-talukdar/Pyrosafe-Game` | Studied | Fire/safety training direction marker for procedural safety scenarios and hazard-response framing |
| `limasantoss/fabrica-segura-vr` | Studied | Smart-factory safety microtraining with production-line navigation, emergency-stop interaction, and visible feedback |
| `Kreline1993/gardsbriller` | Studied | Quest MR garden digital twin with JSON plant rows, MultiSet VPS localization, mode state machine, overview/picking/weeding modes, info panels, wrist menu, LOD/clustering icons, and localization toasts |
| `ACROSS-Lab/HoanKiemAirVR-Unity` | Studied | Environmental/air VR direction marker for city/environment monitoring surfaces |
| `ACROSS-Lab/Rac-VR` | Studied | Environmental/city VR direction marker; Windows checkout exposed case-collision hygiene caveats in external source layout |
| `ototadana/TyDrone` | Studied | Quest MR virtual cockpit for Tello drone using Android plugin notes, passthrough, hand/controller setup, and restored MRTK-style cockpit features |
| `AndreasFranke5/TwinCity` | Studied | Collaborative MR city digital twin with Cesium/Google 3D Tiles, Shared Spatial Anchors, Photon Fusion, markers, water-level simulation, map controls, and emergency-planning framing |
| `Mukheem/TwinTurbine` | Studied | Collaborative MR turbine digital twin with physical turbine, servo/generator/photoresistor data, SMHI API, dashboard, avatar guidance, Shared Spatial Anchors, Photon, and Proxima/debug surfaces |
| `Infinity-Spark/Infinity-Spark-App` | Studied | HoloLens/ABB RobotStudio industrial robot monitoring/control dashboard direction |
| `SL-thws/Mixed-Reality-for-Training-in-Human-Robot-Collaboration` | Studied | Human-robot collaboration training direction marker for safety and role-based MR procedure design |

## Reusable Pattern Extraction

- Pattern candidate: `MR digital twin control and safety surface`.
- Problem solved: MR twins mix physical alignment, live data, user roles, and
  control commands; without boundaries they become unsafe demos.
- Reusable core: space anchor/VPS/SSA boundary, data model or live API adapter,
  scene/twin generator, mode state machine, dashboard/panel, annotation layer,
  operator role, command envelope, connection health, emergency stop, dry-run
  mode, multi-user sync, and safety/caveat labels.
- Source evidence: Gardsbriller uses JSON plant data, `TwinDataLoader`,
  `TwinGenerator`, `TwinDatabase`, `ModeController`, mode states, wrist menu,
  and localization toasts; TwinCity uses Cesium/3D Tiles, SSA/Photon, markers,
  map controls, and water-level simulation; TwinTurbine combines physical
  turbine data, SMHI API, dashboard, avatar guidance, SSA/Photon, and debug
  tooling; TyDrone documents a Quest MR cockpit and Android drone plugin.
- Abstraction boundary: live physical control should sit behind explicit
  adapters and safety state; MR panels should visualize state and authority
  before sending commands.
- What not to copy: hardcoded cloud/API credentials, live robot/drone defaults,
  opaque anchor state, command buttons without authority/connection health, or
  external source trees with case-colliding folders.
- Method catalog action: create a new MR digital-twin control-surface method.

## Project Notes

### `Kreline1993/gardsbriller`

- Interesting idea: a real garden becomes a Quest MR digital twin loaded from
  JSON, localized with VPS, and controlled through task-specific modes.
- Code donor value: high for JSON twin loader, database queries, mode state
  machine, proximity highlights, wrist menu, info panels, and localization
  toasts.
- Product reference value: very strong for practical MR utility overlays.
- What to inspect next: map localization failure handling, plant-data editing,
  and mode extensibility.
- Caveats: active project uses Quest, MultiSet, passthrough, and newer Unity.

### `limasantoss/fabrica-segura-vr`

- Interesting idea: a narrow factory safety scenario focuses on one valuable
  interaction: emergency stop with visible system feedback.
- Code donor value: moderate for safety microtraining structure.
- Product reference value: useful for small, focused industrial training apps.
- What to inspect next: task success criteria, hazard state, and reset flow.
- Caveats: narrow scope but valuable as micro-utility reference.

### `ototadana/TyDrone`

- Interesting idea: a Quest MR cockpit can mediate drone control through an
  Android plugin while passthrough preserves physical context.
- Code donor value: high for cockpit/product architecture and plugin boundary.
- Product reference value: strong for MR control panels.
- What to inspect next: command throttling, connection health, and emergency
  stop behavior.
- Caveats: do not reuse live drone control without safety envelopes.

### `AndreasFranke5/TwinCity`

- Interesting idea: a photorealistic tabletop city twin supports markers,
  annotations, water-level simulation, and co-located multi-user planning.
- Code donor value: high for map placement, marker management, simulation UI,
  Cesium/Google tile boundary, SSA, and Photon collaboration.
- Product reference value: very strong for emergency-planning MR surfaces.
- What to inspect next: authoritative state sync, marker persistence, and
  sensor/API ingest.
- Caveats: cloud map keys and networking setup need credential hygiene.

### `Mukheem/TwinTurbine`

- Interesting idea: a scaled physical turbine is linked to an MR twin,
  dashboard, avatar onboarding, API weather data, and collaborative anchors.
- Code donor value: high for physical/digital twin framing, dashboard, API/IoT
  split, SSA/Photon reuse, and debug tooling.
- Product reference value: strong for education and industrial monitoring.
- What to inspect next: serial/physical data bridge, SMHI API wrapper, and
  authority model for control.
- Caveats: physical hardware and multi-user setup add operational complexity.

### `Infinity-Spark/Infinity-Spark-App`

- Interesting idea: industrial robot status/control is framed as an MR dashboard
  beyond classic SCADA panels.
- Code donor value: moderate pending deeper ABB/HoloLens source pass.
- Product reference value: useful for industrial MR dashboard direction.
- What to inspect next: ABB RobotStudio adapter, command authorization, and
  HoloLens-specific interaction model.
- Caveats: vendor dependency and real robot safety.

## Product Direction

This wave supports an `MR digital twin utility` branch: make real-world state
visible first, expose command authority second, and always include connection,
safety, and fallback states.

