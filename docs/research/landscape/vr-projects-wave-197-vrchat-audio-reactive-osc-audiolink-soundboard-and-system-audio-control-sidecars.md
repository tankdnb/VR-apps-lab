# VR Projects Wave 197: VRChat Audio-Reactive OSC, AudioLink, Soundboard, and System-Audio Control Sidecars

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 197 studies VRChat OSC sidecars that connect audio and avatar state in
both directions: system audio to avatar parameters, avatar parameters to local
soundboards or OS media keys, bHaptics/log events to tactile audio output, and
avatar controls to external DSP/instrument engines.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `shadorki/vrc-osc-audio-controls` | Avatar menu to Windows media keys | Small bridge donor |
| `Codel1417/VRC-OSC-Audio-Reaction` | Loopback audio to avatar parameters | Strong audio-reactive donor |
| `octalmage/oscsound` | OSCQuery local soundboard | Strong soundboard/product donor |
| `FreneticFurry/VRC-Visualizer` | FFT visualizer baseline | Tiny mapping reference |
| `bWoojer/WoojerOSC` | bHaptics/log to tactile audio | Physical/tactile reference |
| `Zeno-Fluff/OALSVRC` | External AudioLink-style product | Source-light product reference |
| `Azumarite/Dynamic-Vocoder-and-Instrument-with-Supercollider-VRChat` | VRChat-controlled DSP instrument | DSP control donor |

## `shadorki/vrc-osc-audio-controls`

- Interesting idea:
  avatar expression parameters trigger operating-system media commands such as
  play/pause, next, previous, and mute.
- Code donor value:
  medium for the simple avatar-menu to OS-command bridge shape.
- Product reference value:
  medium for controller-free music control in VRChat.
- What to inspect next:
  debounce, command reset, configurable paths, and safer process invocation.
- Source evidence:
  `main.go`.
- Reusable pattern extraction:
  avatar menu to OS/media-control command bridge.
- Reusable core:
  listen on the VRChat OSC input port, map explicit boolean avatar parameters
  to local command actions, act only on true/rising values, and keep command
  mapping small and visible.
- Do not copy directly:
  fragile string parsing of OSC messages, hardcoded parameter names, or
  PowerShell SendKeys as the final command backend.
- Caveats:
  Windows-only and intentionally narrow.

## `Codel1417/VRC-OSC-Audio-Reaction`

- Interesting idea:
  Windows audio loopback is converted into normalized avatar parameters for
  volume and stereo direction.
- Code donor value:
  high for WASAPI loopback capture, smoothing, thresholded sends, direction
  calculation, and VRChat precision-floor handling.
- Product reference value:
  high for external AudioLink-style avatar reactivity.
- What to inspect next:
  device selection, privacy/telemetry settings, multi-band analysis, and
  cross-platform abstraction.
- Source evidence:
  `AudioReactionControl.cs` and `Audio.cs`.
- Reusable pattern extraction:
  audio loopback to normalized avatar parameters.
- Reusable core:
  capture audio loopback, compute channel energy, smooth values, derive
  direction/volume, clamp to VRChat-safe ranges, and send only when values
  materially change.
- Do not copy directly:
  Windows-only NAudio assumptions or telemetry defaults without review.
- Caveats:
  strong technical donor for avatar audio reactivity.

## `octalmage/oscsound`

- Interesting idea:
  a local Wails/Go soundboard advertises avatar parameters via OSCQuery and
  plays one-shot or looping local sounds when VRChat toggles them.
- Code donor value:
  very high for OSCQuery discovery, soundpack import/export, playback routing,
  one-shot versus loop behavior, and preview UX.
- Product reference value:
  very high for local avatar-controlled soundpacks.
- What to inspect next:
  sound routing to users/stream, per-sound security, rate limits, and
  multi-profile behavior.
- Source evidence:
  `app.go`, `oscquery.go`, and `frontend/src/main.js`.
- Reusable pattern extraction:
  avatar-parameter triggered local soundpack with OSCQuery discovery.
- Reusable core:
  define named sound entries, expose their avatar parameters over OSCQuery,
  load local audio assets, distinguish rising-edge one-shots from true/false
  loops, offer preview/import/export, and keep UI state synchronized with
  active loop playback.
- Do not copy directly:
  assumptions that other users can hear local playback without routing.
- Caveats:
  strongest product donor in this wave.

## `FreneticFurry/VRC-Visualizer`

- Interesting idea:
  a small Python visualizer maps FFT-derived values and previous samples into
  avatar parameters for a VRChat AudioLink-like effect.
- Code donor value:
  medium as a tiny FFT/smoothing/delay-line example.
- Product reference value:
  medium for beginner-friendly avatar setup docs.
- What to inspect next:
  device selection, frequency bands, rate limiting, and parameter naming.
- Source evidence:
  `Visualizer.py`.
- Reusable pattern extraction:
  audio spectrum delay-line to avatar parameters.
- Reusable core:
  capture an audio input device, compute a simple magnitude, smooth it, send a
  current value plus delayed previous values, and document the avatar-side
  blend-tree setup.
- Do not copy directly:
  hardcoded device names or high-frequency sends from an audio callback.
- Caveats:
  good micro-reference, not a polished tool.

## `bWoojer/WoojerOSC`

- Interesting idea:
  bHaptics-compatible VRChat OSC/log events are converted into stereo sine
  output for Woojer/tactile transducers.
- Code donor value:
  medium for event parsing, haptic-grid interpretation, preset patterns, and
  pan/frequency/volume mapping.
- Product reference value:
  medium for physical/tactile output alternatives.
- What to inspect next:
  safe volume limits, output-device persistence, generated artifacts, and
  bHaptics protocol compatibility.
- Source evidence:
  `Program.cs`, `Presets.cs`, `SineProvider.cs`, and `SinePool.cs`.
- Reusable pattern extraction:
  haptic event to tactile audio rendering.
- Reusable core:
  parse haptic event paths or logs, map body positions to pan/frequency/volume,
  use a pool/mixer for overlapping sine tones, and keep presets bounded by
  timers.
- Do not copy directly:
  physical-output defaults, console device prompts, or bundled build artifacts.
- Caveats:
  any tactile/audio physical output needs explicit safety controls.

## `Zeno-Fluff/OALSVRC`

- Interesting idea:
  a source-light product reference for an external AudioLink-style system that
  captures system audio, analyzes bands/waveform/amplitude, and transmits OSC
  to VRChat.
- Code donor value:
  low because source boundaries are not visible.
- Product reference value:
  medium for product framing.
- What to inspect next:
  source availability, license constraints, signal model, and GUI routing.
- Source evidence:
  README and repository assets.
- Reusable pattern extraction:
  external AudioLink product framing.
- Do not copy directly:
  claims without code evidence or restrictive-license material.
- Caveats:
  useful as market/product confirmation only.

## `Azumarite/Dynamic-Vocoder-and-Instrument-with-Supercollider-VRChat`

- Interesting idea:
  VRChat avatar parameters control SuperCollider vocoder effects, voice gates,
  synth state, and pitch mapping for live audio performance.
- Code donor value:
  high for external DSP engine control via OSC parameters.
- Product reference value:
  high for experimental performer tools.
- What to inspect next:
  UI safety, audio routing, parameter schema, pitch quantization, and reusable
  engine wrapper.
- Source evidence:
  `SpeakerInstrument.scd`.
- Reusable pattern extraction:
  avatar menu to external DSP/instrument control.
- Reusable core:
  define OSC addresses for effect toggles, synth state, and normalized pitch,
  map avatar parameters into DSP state, and keep audio routing outside VRChat
  while VRChat acts as the control surface.
- Do not copy directly:
  manual routing assumptions, raw script setup, or unbounded audio output.
- Caveats:
  strong experimental pattern for performer utilities.

## Cross-Project Lessons

- Audio-reactive tools need normalization, smoothing, thresholds, and value
  floors before sending to VRChat.
- Avatar-to-audio tools need reset/debounce behavior or they become stuck
  controls.
- OSCQuery is valuable when a sidecar expects avatar parameters to be created
  or discovered by users.
- Physical or tactile audio output belongs in the same safety class as haptics.
- External DSP engines make VRChat a useful control surface even when the sound
  is produced outside VRChat.

## Reuse Recommendations

1. Use `oscsound` as the strongest local soundboard and OSCQuery donor.
2. Use `VRC-OSC-Audio-Reaction` for audio loopback normalization and
   thresholded avatar sends.
3. Use `vrc-osc-audio-controls` for the simplest avatar menu to OS command
   pattern.
4. Use the SuperCollider project for performer/DSP control ideas.
5. Treat `WoojerOSC` and `OALSVRC` as safety/product references rather than
   direct implementation sources.

## Follow-Up Gaps

- Build a matrix of audio-reactive approaches: loopback, microphone, MPRIS,
  OSCQuery soundpacks, AudioLink-like external senders, and DSP engines.
- Define a reusable normalized-audio parameter schema for volume, direction,
  bands, and delayed samples.
- Define safe local-output requirements for soundboards, tactile transducers,
  and physical haptics.
- Compare how tools avoid spam, stuck notes, stuck loops, and stale media state.
