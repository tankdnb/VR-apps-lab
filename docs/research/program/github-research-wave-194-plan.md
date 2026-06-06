# GitHub Research Wave 194 Plan

- Date: `2026-06-06`
- Theme: `VRChat MIDI, DMX, piano, and live-performance control bridges`
- Scope: MIDI and DMX data paths into VRChat worlds, Udon sync, piano/player
  OSC senders, physical controller mirrors, and performer-facing MIDI control
  utilities.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

VRChat performance tools repeatedly bend MIDI into a general control/data
plane. Wave 194 studies how projects handle backpressure, Udon synchronization,
shader texture outputs, controller mirroring, piano note schemas, particle
limits, and performer-facing configuration.

## Search Families

- VRChat MIDI to DMX/world control
- MIDI piano to VRChat OSC
- Udon MIDI synchronization
- physical controller mirror props
- live performance control bridges

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `micksam7/VRC-MIDIDMX` | MIDI-as-data transport for DMX texture output in VRChat worlds with watchdog/backpressure | Strong DMX transport donor |
| `marcus-universe/vrc_midi_transposer` | Rust MIDI transposer controlled by VRChat OSC/MQTT and emitting note-state OSC | Strong multi-protocol control donor |
| `laserimouto/UDJ-1000` | Unity/Udon prop mirroring a physical DJ controller with Python MIDI filter | Physical controller mirror reference |
| `fltuna/USharp-midi-tuna` | UdonSharp MIDI piano with voice budget, sustain, and event sync | Strong Udon MIDI playback donor |
| `Mathieu52/OSCMidi` | PySide MIDI piano to VRChat OSC GUI with device selectors and particle mapping | Strong performer GUI donor |
| `ShadowForests/OSCPianoPlayer` | MIDI-file scheduler to OSC piano world | Offline scheduler reference |
| `MaverickLong/midi-osc-client` | Minimal CLI MIDI-to-OSC piano compatibility layer | Thin micro-bridge reference |
| `labthe3rd/vrcMidiOverNetworkExample` | Udon manual sync example with serialization status and latency | Sync telemetry donor |

## Dedupe Notes

- Earlier media/audio waves covered players and spatial audio; this wave keeps
  projects where MIDI/DMX is a control or performance data plane.
- Thin piano clients are retained only when they expose path compatibility or
  scheduling patterns.
- No MIDI device, Unity editor, VRChat world, or network service was started.

## Code-Level Pass Targets

- MIDI message packing and backpressure.
- Udon MIDI callbacks, manual serialization, and loss/latency telemetry.
- OSC note/path schemas and particle/key limits.
- Controller CC filtering and physical transform mirroring.
- Performer GUI device selection and profile persistence.
- Multi-protocol control through OSC and MQTT.

## Expected Outputs

- Wave 194 landscape synthesis.
- Registry/family placement for MIDI/DMX/live-performance bridges.
- Methods for MIDI-as-data-plane, piano note-to-OSC mapping, and Udon sync.
