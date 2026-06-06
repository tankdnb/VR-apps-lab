# GitHub Research Wave 197 Backlog

- Date: `2026-06-06`
- Theme: `VRChat audio-reactive OSC, AudioLink-style, soundboard, and system-audio control sidecars`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for VRChat OSC audio reaction, soundboard, media
  control, AudioLink-style, haptic audio, and SuperCollider/DSP sidecars.
- `Done` Dedupe against previously studied media players, spatial audio SDKs,
  creator audio worlds, and haptics bridges.
- `Done` Freeze a shortlist that covers both audio-to-avatar and
  avatar-to-audio directions.

## Source Sync

- `Done` Confirm `vrc-osc-audio-controls` in local-only cache.
- `Done` Confirm `VRC-OSC-Audio-Reaction` in local-only cache.
- `Done` Confirm `oscsound` in local-only cache.
- `Done` Confirm `VRC-Visualizer` in local-only cache.
- `Done` Confirm `WoojerOSC` in local-only cache.
- `Done` Confirm `OALSVRC` in local-only cache.
- `Done` Confirm `Dynamic-Vocoder-and-Instrument-with-Supercollider-VRChat` in
  local-only cache.

## Code Reading

- `Done` Inspect OSC avatar parameter handlers and Windows media-key SendKeys
  mapping in `vrc-osc-audio-controls`.
- `Done` Inspect NAudio WASAPI loopback capture, left/right smoothing,
  direction/volume computation, thresholded sends, and precision floor in
  `VRC-OSC-Audio-Reaction`.
- `Done` Inspect Wails/Go config, OSCQuery advertising, soundpack schema,
  one-shot/loop playback, import/export, and preview behavior in `oscsound`.
- `Done` Inspect Python sounddevice FFT, smoothing, delay-line avatar
  parameters, and VB-Audio Cable setup assumptions in `VRC-Visualizer`.
- `Done` Inspect VRChat OSC/log parsing, bHaptics pattern mapping, sine
  provider pool, pan/frequency routing, and audio-device prompt in `WoojerOSC`.
- `Done` Mark `OALSVRC` as source-light external AudioLink product reference.
- `Done` Inspect SuperCollider OSC definitions, vocoder/synth controls,
  pitch mapping, and audio routing assumptions in the dynamic vocoder project.

## Integration

- `Done` Create Wave 197 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for audio loopback to avatar params, OSCQuery
  local soundpacks, and avatar-menu OS media-control bridges.
- `Next` Build an external audio-reactivity matrix across loopback capture,
  OSCQuery soundboards, AudioLink-style sidecars, media controls, DSP engines,
  and physical-output safety.
