# VR Projects Wave 194: VRChat MIDI, DMX, Piano, and Live-Performance Control Bridges

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 194 studies MIDI and DMX as VRChat performance control surfaces. The
important reusable ideas are backpressure, event packing, Udon sync, note-path
schemas, voice/particle limits, physical controller mirroring, and performer
setup UX.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `micksam7/VRC-MIDIDMX` | MIDI transport for DMX texture output | Strong data-plane donor |
| `marcus-universe/vrc_midi_transposer` | Rust MIDI transposer controlled by OSC/MQTT | Strong multi-protocol donor |
| `laserimouto/UDJ-1000` | MIDI DJ controller mirror in VRChat | Physical controller UX reference |
| `fltuna/USharp-midi-tuna` | UdonSharp MIDI piano/player | Strong Udon voice/sync donor |
| `Mathieu52/OSCMidi` | PySide MIDI piano to OSC GUI | Strong performer GUI donor |
| `ShadowForests/OSCPianoPlayer` | MIDI-file to OSC piano scheduler | Offline scheduler reference |
| `MaverickLong/midi-osc-client` | Minimal MIDI-to-OSC CLI | Thin compatibility reference |
| `labthe3rd/vrcMidiOverNetworkExample` | Udon network sync example | Strong sync telemetry reference |

## `micksam7/VRC-MIDIDMX`

- Interesting idea:
  MIDI is used as a high-volume data transport to drive DMX texture output in
  VRChat worlds, with a log-based `MIDIREADY` watchdog to avoid overrun.
- Code donor value:
  very high for data packing, Udon MIDI callbacks, watchdog/backpressure,
  shader-side texture output, and explicit crash-risk documentation.
- Product reference value:
  high for live events and world lighting control.
- What to inspect next:
  robust sender implementation, queue limits, world-side debug UX, and safer
  backpressure APIs.
- Source evidence:
  `PROTOCOL.md`, `Runtime/Scripts/MIDIDMX.cs`, and
  `Runtime/Shaders/MIDIDMX.shader`.
- Reusable pattern extraction:
  MIDI-as-data-plane with watchdog-controlled backpressure.
- Reusable core:
  pack address/value data into MIDI note messages, reserve a control channel
  for bank/clear/watchdog/handshake, update world-side state arrays, write
  blocks into a shader texture, and make the sender pause until the world emits
  readiness feedback.
- Do not copy directly:
  overrun-prone raw MIDI flooding, crash-prone defaults, or world-specific
  texture layout assumptions.
- Caveats:
  powerful because it documents the danger clearly.

## `marcus-universe/vrc_midi_transposer`

- Interesting idea:
  a Rust utility transposes live MIDI and can be controlled from VRChat OSC,
  MQTT, or Home Assistant while emitting note-state OSC parameters.
- Code donor value:
  high for config roles, multi-protocol control, MIDI forwarding, note-name
  path encoding, and avatar setup documentation.
- Product reference value:
  high for performer tools that let VR users control live music state.
- What to inspect next:
  hot-reload, device reconnection, and richer control surfaces.
- Source evidence:
  `src/main.rs`, `general/forwarder.rs`, and `remote/osc_sender.rs`.
- Reusable pattern extraction:
  live MIDI processor with VR/automation control inputs and OSC note output.
- Reusable core:
  persist MIDI/OSC/MQTT config, read MIDI input, apply a bounded transpose
  value, forward to MIDI output, accept OSC commands for up/down/set/debug,
  and publish normalized note or pitch states as avatar parameters.
- Do not copy directly:
  local port assumptions, manual avatar setup, or note-name mapping as a
  universal schema without compatibility options.
- Caveats:
  strong for architecture and docs, not a generic audio player.

## `laserimouto/UDJ-1000`

- Interesting idea:
  a VRChat prop mirrors a physical Pioneer DDJ-1000 controller through MIDI,
  while a Python filter suppresses noisy CC messages to avoid VRChat crashes.
- Code donor value:
  medium-to-high for physical control mirroring and input filtering.
- Product reference value:
  high for in-world DJ/performance tools.
- What to inspect next:
  controller abstraction, alternate mappings, and sync behavior with multiple
  viewers.
- Source evidence:
  `Python/midifilter.py` and `Assets/.../UDJ1000MidiController.cs`.
- Reusable pattern extraction:
  physical controller mirror with pre-filtered MIDI ingress.
- Reusable core:
  filter high-frequency controller-change noise before it reaches VRChat,
  map CC/button events to Udon-synced arrays, update transforms/materials/text,
  and manually sync visual controller state.
- Do not copy directly:
  DDJ-1000-specific CC maps or crash-workaround assumptions as generic MIDI
  behavior.
- Caveats:
  strongest as a product/UX reference for physical control surfaces.

## `fltuna/USharp-midi-tuna`

- Interesting idea:
  an UdonSharp MIDI piano/player handles note on/off, sustain, voice budget,
  remote event emulation, and editor-generated note audio sources.
- Code donor value:
  high for voice allocation, sustain handling, network replication shape, and
  editor tooling.
- Product reference value:
  high for world-side music instruments.
- What to inspect next:
  actual sync reliability, sample memory budgets, and latency under load.
- Source evidence:
  `Scripts/MidiPlayer.cs`, `MidiPitchConverter.cs`, and `Editor/Tool.cs`.
- Reusable pattern extraction:
  Udon MIDI instrument with voice budget and optional network event sync.
- Reusable core:
  handle MIDI note/control callbacks, filter channels and CCs, manage sustain,
  allocate limited voices, retire oldest voices, map velocity to volume, store
  the latest MIDI event for sync, and provide editor tooling to build note
  sources from assets.
- Do not copy directly:
  note sample assumptions, README/code mismatch, or voice limits without
  testing the target world.
- Caveats:
  good donor for world-side constraints.

## `Mathieu52/OSCMidi`

- Interesting idea:
  a PySide app selects MIDI devices, forwards MIDI output, maps piano notes to
  VRChat OSC keys/particles, and provides performer-facing controls.
- Code donor value:
  high for device selection UX, output forwarding, reset behavior, note-range
  mapping, and particle buffer limits.
- Product reference value:
  high for musician-friendly OSC utilities.
- What to inspect next:
  path presets, profile export/import, and cleanup of generated artifacts.
- Source evidence:
  `src/OSCMidiController.py` and `src/PianoOSC.py`.
- Reusable pattern extraction:
  performer GUI for MIDI device selection and note-to-OSC mapping.
- Reusable core:
  refresh available MIDI devices, open selected input/output, forward incoming
  messages, map note range to avatar/world paths, manage a bounded particle
  index buffer, and reset keys slowly to avoid stuck notes.
- Do not copy directly:
  bundled build/cache artifacts or world-specific path constants as defaults.
- Caveats:
  strong UX reference despite repo hygiene issues.

## `ShadowForests/OSCPianoPlayer`

- Interesting idea:
  a simple MIDI-file scheduler sends timed OSC key on/off events to a VRChat
  piano world.
- Code donor value:
  medium for offline scheduling and reset flow.
- Product reference value:
  medium for automated world instruments.
- What to inspect next:
  modern MIDI parser, concurrent playback prevention, and world path presets.
- Source evidence:
  `OSCPianoPlayer.py` and `MusicPlayerOSC.py`.
- Reusable pattern extraction:
  offline MIDI-file to OSC piano scheduler.
- Reusable core:
  parse MIDI tempo/tick timing, schedule note on/off paths, reset the world
  piano state before/after playback, and block concurrent songs.
- Do not copy directly:
  old library assumptions, hardcoded world paths, or single-song console UX.
- Caveats:
  useful as a minimal scheduler lineage node.

## `MaverickLong/midi-osc-client`

- Interesting idea:
  a minimal CLI maps MIDI input to several VRChat piano OSC path schemas,
  including key indices, named notes, and pedal controls.
- Code donor value:
  low-to-medium for compact compatibility mapping.
- Product reference value:
  medium for scriptable bridge baselines.
- What to inspect next:
  CLI setup bug, profile validation, and stuck-note handling.
- Source evidence:
  `cli.py` and `utils.py`.
- Reusable pattern extraction:
  tiny MIDI-to-OSC compatibility layer.
- Reusable core:
  persist device config, open MIDI ports, map note on/off to selected path
  schemas, send sustain pedal booleans, and keep a dummy MIDI out path.
- Do not copy directly:
  current CLI setup bug or minimal error handling.
- Caveats:
  keep as a micro-reference, not a preferred donor.

## `labthe3rd/vrcMidiOverNetworkExample`

- Interesting idea:
  an Udon example manually serializes MIDI events across a VRChat world and
  displays serialization success, loss counts, and deserialization latency.
- Code donor value:
  high for sync telemetry and ownership-aware manual serialization.
- Product reference value:
  high for multiplayer performance debugging.
- What to inspect next:
  event throughput, ownership conflicts, and whether batching is needed.
- Source evidence:
  `MidiNetworkManualExample.cs`.
- Reusable pattern extraction:
  Udon manual-sync telemetry for MIDI/control events.
- Reusable core:
  take ownership before sending, store channel/number/value/toggle state, call
  `RequestSerialization`, track post-serialization success and byte counts,
  count lost sends, and compute receive latency from server time.
- Do not copy directly:
  demo UI and unbatched event model as a production transport.
- Caveats:
  excellent diagnostic sample.

## Cross-Project Lessons

- MIDI in VRChat is often a control/data transport, not just music input.
- Backpressure is mandatory when MIDI is used for high-volume data such as DMX.
- World-side Udon sync needs telemetry: success, lost sends, bytes, and
  latency.
- Piano/world clients benefit from multiple path schemas and reset logic.
- Physical performance controls should filter noisy input before VRChat sees
  it.

## Reuse Recommendations

1. Use `VRC-MIDIDMX` as the backpressure and DMX data-plane donor.
2. Use `vrc_midi_transposer` for multi-protocol performer control.
3. Use `USharp-midi-tuna` and `vrcMidiOverNetworkExample` for Udon sync and
   voice budget patterns.
4. Use `OSCMidi`, `OSCPianoPlayer`, and `midi-osc-client` for note-path
   compatibility and performer/client UX.
5. Use `UDJ-1000` as the physical controller mirror reference.

## Follow-Up Gaps

- Build a MIDI path-schema matrix across worlds and clients.
- Compare sender backpressure strategies: logs, OSC feedback, queues, and rate
  caps.
- Extract a generic "performer control surface" method that is not limited to
  piano or DMX.
- Decide what minimal diagnostics a MIDI-to-VRChat bridge should expose.
