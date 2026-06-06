# GitHub Research Wave 194 Backlog

- Date: `2026-06-06`
- Theme: `VRChat MIDI, DMX, piano, and live-performance control bridges`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for VRChat MIDI, DMX, OSC piano, Udon MIDI sync, DJ
  controller, and networked MIDI examples.
- `Done` Dedupe against earlier audio-player and world-utility waves.
- `Done` Freeze a live-performance shortlist around MIDI as transport,
  control, piano, and sync surface.

## Source Sync

- `Done` Confirm `VRC-MIDIDMX` in local-only cache.
- `Done` Confirm `vrc_midi_transposer` in local-only cache.
- `Done` Confirm `UDJ-1000` in local-only cache.
- `Done` Confirm `USharp-midi-tuna` in local-only cache.
- `Done` Confirm `OSCMidi` in local-only cache.
- `Done` Confirm `OSCPianoPlayer` in local-only cache.
- `Done` Confirm `midi-osc-client` in local-only cache.
- `Done` Confirm `vrcMidiOverNetworkExample` in local-only cache.

## Code Reading

- `Done` Inspect MIDI packing, `MIDIREADY` watchdog, bank/control channel,
  shader texture output, Udon callbacks, and crash/backpressure warnings in
  `VRC-MIDIDMX`.
- `Done` Inspect Rust config, MIDI forwarding/transposition, OSC command
  control, MQTT/Home Assistant integration, note-name OSC emission, and avatar
  setup docs in `vrc_midi_transposer`.
- `Done` Inspect Unity controller mapping, UdonSynced controller state,
  transform/material updates, and Python CC filter in `UDJ-1000`.
- `Done` Inspect Udon MIDI note/control handling, sustain, voice budget,
  network event emulation, pitch converter, and editor audio-source tool in
  `USharp-midi-tuna`.
- `Done` Inspect PySide MIDI device selector, output forwarding, piano OSC
  mapping, particle buffer, reset behavior, and UI state in `OSCMidi`.
- `Done` Inspect MIDI-file scheduling, tempo/tick parsing, OSC key paths, and
  reset behavior in `OSCPianoPlayer`.
- `Done` Inspect minimal CLI config, path schema variants, sustain pedals, and
  known implementation caveats in `midi-osc-client`.
- `Done` Inspect Udon manual sync, ownership, serialization status,
  deserialization latency, and loss counters in `vrcMidiOverNetworkExample`.

## Integration

- `Done` Create Wave 194 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for MIDI/DMX performance bridges and
  piano/note-to-OSC mappers.
- `Next` Build a MIDI backpressure and VRChat path-schema matrix across
  DMX worlds, piano worlds, Udon sync, OSC clients, and physical controller
  mirrors.
