# Wave 344: Molecular Scientific Visualization and Interactive Simulation Viewers

## Scope

This wave studies VR projects that turn scientific data into inspectable,
measurable, or manipulable immersive scenes. The useful lesson is not just
`molecule viewer`; it is the split between domain data import, representation,
trajectory updates, simulation/session transport, VR manipulation, and
measurement UI.

## Studied Projects

| Project | Status | Main reusable signal |
|---|---|---|
| `LBT-CNRS/UnityMol-Releases` | Studied | Large Unity molecular workbench with PDB/mmCIF/GRO/MOL2/SDF/XYZ import, trajectory support, selection language, Python console, save/load commands, HyperBalls, surfaces, and VR scenes |
| `ur-whitelab/simview` | Studied | HOOMD/ZeroMQ-driven molecular simulation viewer with frame queues, interpolated positions, particle names, bonds, GPU molecule system, VR/AR scenes, and instructor view |
| `kwstanths/MRend` | Studied | Compact Unity PDB parser/render baseline with ATOM/HETATM parsing, Angstrom-to-nanometer conversion, atom spawning, and mock-HMD settings |
| `WangLabforComputationalBiology/VisionMol` | Studied | Quest-oriented protein viewer with multiple molecular representations, labels, distance measurement, molecule merging/splicing, residue coloring, and VR manipulation |
| `RBVI/LookSee` | Studied | Quest molecular/cell scene viewer that receives GLTF scenes exported from UCSF ChimeraX and uses GLTFast plus Oculus/OpenXR loaders |
| `IRL2/nanover-imd-vr` | Studied | Interactive molecular dynamics client with service discovery, WebSocket/autoconnect paths, controller manager, simulation-space manipulation, passthrough, calibration, and user commands |

## Reusable Pattern Extraction

- Pattern candidate: `scientific VR data/viewer decomposition`.
- Problem solved: scientific XR tools need domain-specific import and update
  loops without hard-coupling parser logic, visualization representation, VR
  controls, and remote simulation state.
- Reusable core: domain file/session adapter, normalized data model, molecular
  representation layer, trajectory/frame queue, interpolation, measurement
  tools, selection/query language, scene save/load, simulation transport,
  calibration/passthrough gates, and VR manipulation UI.
- Source evidence: UnityMol's parser/representation/API breadth, simview's
  HOOMD frame queues and GPU molecule system, MRend's minimal PDB parser,
  VisionMol's measurement and representation UI, LookSee's ChimeraX-to-GLTF
  handoff, and NanoVer's service/session/controller split.
- Abstraction boundary: scientific data import and simulation state should be
  isolated from XR input, scene rendering, and UI panels.
- What not to copy: heavy scientific assets, undocumented data assumptions,
  old GoogleVR/SteamVR/Oculus package blobs, hardcoded paths, and live
  simulation transports without reconnection and provenance.
- Method catalog action: create a new method for scientific VR
  viewer/simulation decomposition.

## Project Notes

### `LBT-CNRS/UnityMol-Releases`

- Interesting idea: full molecular workbench rather than a single viewer path.
- Code donor value: high for parser coverage, representation taxonomy,
  selection language, Python console, trajectory reader, scene persistence,
  and high-level API shape.
- Product reference value: strong reference for a domain workbench where users
  load, select, script, measure, and preserve scientific scenes.
- What to inspect next: `UMolAPI.md`, parser directories, VR scene wiring,
  trajectory smoothing, and dependency/license boundaries.
- Caveats: large Unity project with mandatory external assets for some modes.

### `ur-whitelab/simview`

- Interesting idea: live simulation stream is buffered into position queues and
  interpolated before rendering.
- Code donor value: strong for frame queue, HOOMD/FlatBuffers/ZeroMQ
  integration, molecule GPU update paths, and instructor/VR scene separation.
- Product reference value: good model for live scientific visualizers that need
  remote simulation status plus local frame smoothing.
- What to inspect next: `vrCommClient`, `FilterChannelClient`, schema files,
  and instructor-view UI.
- Caveats: legacy GoogleVR content and research-code maturity.

### `kwstanths/MRend`

- Interesting idea: minimal PDB-to-Unity path for fast bring-up.
- Code donor value: useful as a small parser/spawner reference, especially
  `PDBParser.cs` and `SpawnPDB.cs`.
- Product reference value: lower than UnityMol/VisionMol, but valuable as a
  thin baseline for tests and tutorials.
- What to inspect next: connection handling and bond generation if the project
  grows beyond ATOM/HETATM parsing.
- Caveats: compact implementation with many scientific features absent.

### `WangLabforComputationalBiology/VisionMol`

- Interesting idea: Quest-first molecular viewer with measurement, labels,
  merge/splice operations, residue coloring, and representation switching.
- Code donor value: high for Quest-oriented molecular UI and measurement
  behavior; inspect deeper before direct reuse.
- Product reference value: strong for an in-headset scientific inspection
  workflow.
- What to inspect next: PDB loading, label controls, distance measurement,
  molecule merge/splice actions, and representation switching.
- Caveats: includes generated Burst debug directories and likely heavy assets.

### `RBVI/LookSee`

- Interesting idea: use a mature desktop scientific application as the
  authoring/export side and keep the headset app as a GLTF viewer.
- Code donor value: moderate; strongest donor is the product boundary between
  ChimeraX export and Quest viewing.
- Product reference value: strong for `author in expert tool, inspect in VR`
  workflows.
- What to inspect next: GLTFast loading, file transfer assumptions, and
  headset-side scene navigation.
- Caveats: depends on external ChimeraX workflow and Oculus Integration.

### `IRL2/nanover-imd-vr`

- Interesting idea: interactive molecular dynamics as a networked XR client
  with service discovery, simulation sessions, passthrough, calibration, and
  command discovery.
- Code donor value: high for session/service split, controller manager,
  simulation-space manipulation, connection health, and calibration hooks.
- Product reference value: strong reference for live remote-science utilities.
- What to inspect next: `NanoverImdSimulation`, trajectory session adapters,
  command UI, WebSocket auto-connect, and physical calibration.
- Caveats: specialized NanoVer ecosystem dependencies.

## Product Direction

This wave strengthens a `scientific XR utility` branch: load/import domain data,
normalize into a common scene model, provide measurement/selection tools, and
keep live simulation transport separate from local VR controls.

