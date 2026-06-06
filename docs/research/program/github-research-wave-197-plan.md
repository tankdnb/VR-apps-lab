# GitHub Research Wave 197 Plan

- Date: `2026-06-06`
- Theme: `VRChat audio-reactive OSC, AudioLink-style, soundboard, and system-audio control sidecars`
- Scope: audio loopback, avatar-parameter reactivity, local soundboards,
  media-key control, tactile/audio haptics, vocoder/instrument control, and
  external AudioLink-style products.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Audio and VRChat OSC tools repeatedly use the same reusable shapes: capture or
listen to audio, normalize it, route it into avatar parameters, trigger local
audio output from avatar menus, or map avatar parameters back into operating
system and DSP actions. Wave 197 captures those shapes without trying to
validate any third-party audio routing or hardware setup.

## Search Families

- VRChat OSC audio visualizers and audio-reactive avatar senders
- avatar menu to media-key or OS audio controls
- OSCQuery soundboards and local audio pack triggers
- AudioLink-style external sidecars
- haptics/audio/tactile transducer bridges
- VRChat-controlled vocoder or instrument engines

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `shadorki/vrc-osc-audio-controls` | Avatar parameters trigger Windows media keys | Avatar menu to OS command bridge |
| `Codel1417/VRC-OSC-Audio-Reaction` | Windows loopback audio to avatar float parameters | Strong audio-reactive donor |
| `octalmage/oscsound` | OSCQuery-aware local soundboard controlled by avatar params | Strong soundboard donor |
| `FreneticFurry/VRC-Visualizer` | Minimal Python FFT/delay-line visualizer | Tiny audio-reactive baseline |
| `bWoojer/WoojerOSC` | bHaptics OSC/log events to Woojer/audio transducer output | Tactile audio bridge reference |
| `Zeno-Fluff/OALSVRC` | Source-light external AudioLink product framing | Product reference |
| `Azumarite/Dynamic-Vocoder-and-Instrument-with-Supercollider-VRChat` | VRChat parameters control SuperCollider vocoder/synth | DSP/instrument control donor |

## Dedupe Notes

- Earlier waves covered media players, spatial audio SDKs, and creator audio
  systems. Wave 197 is focused specifically on avatar-parameter/audio sidecars.
- Source-light product references are documented as references, not promoted as
  deep code donors.
- No audio device, VRChat client, SuperCollider script, executable, or third
  party repo was run.

## Code-Level Pass Targets

- Audio capture and normalization boundaries.
- Avatar parameter schemas for audio volume, direction, delay, and control.
- OSCQuery discovery and avatar parameter advertising.
- Local soundboard pack import/export and one-shot versus loop behavior.
- OS media-key command mapping and debounce/reset behavior.
- Physical/tactile output safety and audio-device caveats.
- External DSP control via avatar parameters.

## Expected Outputs

- Wave 197 landscape synthesis.
- Registry/family placement for audio-reactive and audio-control sidecars.
- Methods around audio loopback normalization, OSCQuery soundboards, and avatar
  menu to OS/media control bridges.
