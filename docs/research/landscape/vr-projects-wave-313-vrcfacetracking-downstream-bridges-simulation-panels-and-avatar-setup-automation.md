# Wave 313 - VRCFaceTracking Downstream Bridges, Simulation Panels, and Avatar Setup Automation

This wave studies downstream VRCFaceTracking bridges and creator-side setup
tools as reusable references for protocol translation, named-pipe companion
GUIs, manual/simulated face output, avatar JSON handoff, parameter metadata,
and generated animator assets.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- downstream consumers of VRCFaceTracking output;
- protocol translation from VRCFT into VMC/PerfectSync or app-specific APIs;
- manual/simulated VRCFT module companions;
- VNyan and avatar-consumer-specific adapters;
- Unity editor setup automation for face-tracking avatar authoring.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `tkns3/VRCFTtoVMCP` | VRCFT-to-VMC/PerfectSync protocol bridge | Studied | OSC receiver, VMC sender, local discovery, avatar-change orchestration, and config-driven translation |
| `Toys0125/VirtualFaceTracking` | VRCFT module plus named-pipe GUI simulator | Studied | Companion GUI, state snapshots, simulation engine, diagnostics, and persistent session state |
| `LumKitty/VRCFTnyan` | VNyan consumer-side VRCFT adapter | Studied | VNyan plugin button/trigger entry, avatar JSON handoff, and direct blendshape override consumer |
| `ImTiara/FaceTrackingSetup` | Unity inspector-driven avatar setup helper | Studied | Searchable blendshape mapping, thresholds, toggles, and generated output folders/controllers |
| `benaclejames/VRCFTSetupUtility` | Metadata-driven animator/layer setup generator | Studied | Param-meta recording, renderer diffs, animation asset generation, and FX layer builders |

## Code-Level Findings

### `tkns3/VRCFTtoVMCP`

- Interesting idea:
  a bridge can sit between VRCFT and downstream avatar tools by receiving VRCFT
  OSC, translating it into another expression schema, and coordinating avatar
  switching/discovery itself.
- Code donor value:
  medium-high. `VrcOscReceiver.cs` binds a UDP receiver, parses OSC packets,
  and updates a central parameter store. `VMCPSender.cs` copies the latest
  parameter weights at a timer-defined send rate, maps VRCFT parameters into
  PerfectSync/VMCProtocol blendshapes, optionally emits eye-target positions,
  and sends a bundle per frame. `MainWindow.xaml.cs` loads/saves JSON config,
  auto-starts the pipeline, hosts an OSC JSON service, advertises it with
  mDNS, creates temporary avatar JSON files, and sends `/avatar/change` to
  VRCFT consumers discovered through Zeroconf.
- Product reference value:
  high for downstream bridges between avatar ecosystems and for local-sidecar
  control panels that need to own translation and handshake details.
- What to inspect next:
  the OSC JSON server details, parameter coverage versus newer VRCFT releases,
  timer/send-rate tradeoffs, and how robustly discovery behaves with multiple
  consumers.
- Reusable pattern extraction:
  keep `upstream OSC ingest`, `central parameter store`, `schema translation`,
  and `local discovery/avatar handshake` separate.

### `Toys0125/VirtualFaceTracking`

- Interesting idea:
  a VRCFT module can double as a manual/simulated tracking harness when paired
  with a Windows GUI companion over a stateful named-pipe channel.
- Code donor value:
  very high. `VirtualFaceTrackingModule.cs` resolves deployment paths, starts
  diagnostics, loads defaults and persisted state, auto-launches the GUI when
  needed, and gates output on connection heartbeat and output-enable state.
  `NamedPipeModuleServer.cs` exposes connection snapshots, message handling,
  periodic state broadcasts, and reconnect behavior. `VirtualSimulationEngine`
  synthesizes fixations, blink envelopes, brows, and face motion. The GUI
  (`MainForm.cs`) layers tabs, diagnostics, reset commands, verbose pipe
  logging, and periodic flush loops over the same shared state model.
- Product reference value:
  very high for testing surfaces, calibration harnesses, manual override tools,
  and research-friendly companion apps.
- What to inspect next:
  the expression-mapping layer, the tests around simulation/state reducers, and
  whether the GUI/module contract is stable enough to generalize.
- Reusable pattern extraction:
  keep `module`, `companion GUI`, `state snapshot protocol`, `simulation
  engine`, and `persistent session state` separate.

### `LumKitty/VRCFTnyan`

- Interesting idea:
  a downstream avatar app plugin can claim only the consumer-specific layer,
  leaving VRCFT upstream unchanged and mapping into the target app's native
  blendshape override API.
- Code donor value:
  medium. `VRCFTnyan.cs` loads a simple config file, registers VNyan buttons
  and triggers, writes a VRChat avatar JSON descriptor, toggles a local active
  GameObject, and sends `/avatar/change` to VRCFT. The code reuses conversion
  helpers from `VRCFTtoVMCP` for eye and face parameter mapping, showing how
  a narrow consumer-side plugin can stay lightweight.
- Product reference value:
  medium-high for app-specific face-tracking consumers, pluginized bridges, and
  "just enough downstream adapter" design.
- What to inspect next:
  the actual update loop that writes VNyan blendshape overrides, conflict
  handling with other VNyan plugins, and code deduplication relative to
  `VRCFTtoVMCP`.
- Reusable pattern extraction:
  keep `consumer plugin API`, `avatar handoff`, and `parameter mapping`
  separate from the upstream tracker transport.

### `ImTiara/FaceTrackingSetup`

- Interesting idea:
  editor-time face-tracking setup can be expressed as a structured authoring
  object plus a custom inspector instead of a long manual checklist.
- Code donor value:
  high. `FaceTrackingSetup.cs` stores output path, expression parameters,
  controllers, toggles, thresholds, eye/bink/pupil mappings, and a 37-entry
  mouth affector catalog. `FaceTrackingSetup_Editor.cs` validates required
  assets, scans mesh blendshapes, offers searchable blendshape pickers,
  auto-fills ARKit eye names, manages advanced/simple eye settings, and guides
  the user through setup decisions in one inspector surface.
- Product reference value:
  high for creator tooling, onboarding flows, and "guided setup over raw docs"
  UX.
- What to inspect next:
  the actual asset output path contents, write-default policy implications, and
  how parameter counts interact with avatar limits.
- Reusable pattern extraction:
  keep `authoring state`, `searchable mapping UI`, `preset autofill`, and
  `generated output folder` separate.

### `benaclejames/VRCFTSetupUtility`

- Interesting idea:
  avatar setup can be turned into a metadata-driven capture process that records
  renderer diffs and then synthesizes animator layers automatically.
- Code donor value:
  very high. `VRCFTSetupWindow.cs` walks the user through avatar descriptor and
  param-meta selection, records step-by-step blendshape diffs, and advances a
  guided workflow. `VRCFTSetupLogic.cs` constructs child renderer save states,
  loads parameter metadata from JSON, captures animation steps, saves clips,
  and chooses linear or binary layer builders. `LinearLayer.cs` shows a clean
  animator synthesis path through generated parameters, blend trees, and FX
  controller layers.
- Product reference value:
  very high for repeatable avatar-setup tooling, especially where metadata and
  generated assets are more maintainable than hand-built animator graphs.
- What to inspect next:
  param meta schema evolution, robustness of diff capture on complex avatars,
  and how binary versus linear parameter families are chosen.
- Reusable pattern extraction:
  keep `param metadata`, `renderer diff capture`, `animation asset generation`,
  and `layer builder synthesis` separate.

## Reusable Pattern Extraction

- Pattern candidate:
  VRCFaceTracking downstream bridge and avatar-setup boundary across protocol
  translation, companion GUIs, simulation state, avatar handoff, metadata, and
  generated animator assets.
- Problem solved:
  once face tracking exists, the hard reuse problem shifts to translation,
  monitoring, testing, and creator setup. Keeping transport, simulation, and
  editor automation distinct makes that work reusable across ecosystems.
- Reusable core:
  upstream parameter ingest, central parameter store, downstream schema mapper,
  named-pipe or local IPC snapshot channel, persistent config/state, manual and
  simulated control surfaces, avatar JSON/config handoff, metadata catalog,
  renderer diff capture, generated animations, and generated animator layers.
- Source evidence:
  `tkns3/VRCFTtoVMCP`, `Toys0125/VirtualFaceTracking`,
  `LumKitty/VRCFTnyan`, `ImTiara/FaceTrackingSetup`, and
  `benaclejames/VRCFTSetupUtility`.
- Abstraction boundary:
  keep tracking-source transport, downstream translation, control/simulation
  UI, persisted session state, and editor-generated avatar assets separate.
- What not to copy:
  hardcoded avatar IDs without lifecycle notes, duplicated mapping code across
  projects, GUI auto-start assumptions without diagnostics, or editor wizards
  that hide generated asset consequences from the user.
- Method catalog action:
  add a VRCFT downstream bridge and setup-automation method.

## Follow-Up Gaps

- Compare VMC/PerfectSync, VNyan, and future consumer adapters as one
  compatibility matrix rather than isolated bridges.
- Deepen `VirtualFaceTracking` tests, expression mapping, and GUI/module
  contract stability.
- Deepen the generated asset shape and param metadata schema in both setup
  tools.
