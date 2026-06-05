# GitHub Research Wave 146 Backlog

- Date: `2026-06-05`
- Scope: WebXR/AR audio visualizers, Three/WebXR audio-reactive scenes,
  native VR raymarching visualizers, and A-Frame music visualizer examples.

## Completed in this wave

- Studied `shift/webxr-audio-visualizer` as a WebXR AR directional audio
  visualizer that requests stereo microphone input, splits left/right channels,
  tracks multiple virtual source visualizations, smooths positions, and renders
  waveform rings/glows in AR.
- Studied `Alex-DG/vite-three-webxr-audio-visualizer` as a Vite/Three/WebXR
  audio-reactive scene where p5 sound analysis drives shader uniforms for a
  sphere and particle field.
- Studied `ConorStokes/boondoggle` as a native Windows/Oculus/D3D11 music
  visualizer with WASAPI loopback capture, FFT processing, audio textures,
  shader packages, and JSON-defined visual effects.
- Studied `DranoelMit/seeSound` as an A-Frame browser music visualizer where
  WebAudio frequency bins scale rings of bars and cubes around the user.

## Reuse candidates

- `ConorStokes/boondoggle` is the strongest donor for native audio capture,
  frequency bucketing, audio textures, and shader-package separation.
- `Alex-DG/vite-three-webxr-audio-visualizer` is the strongest browser donor
  for normalized audio features feeding WebXR shader uniforms.
- `shift/webxr-audio-visualizer` is a product reference for directional audio
  visualization and microphone permission staging.
- `DranoelMit/seeSound` is a simple A-Frame reference for geometry responses
  driven by WebAudio bins.

## Follow-up backlog

1. Extract a shared audio-reactive pipeline note: source, analyser, features,
   smoothing, update rate, visual response, and permission/autoplay constraints.
2. Compare native WASAPI loopback, browser microphone, and media-element audio
   sources as utility input types.
3. Consider an `audio diagnostics overlay` product branch: source levels,
   channel balance, frequency buckets, and spatial cues.
4. Link this wave to prior microphone control, spatial audio, and media-player
   waves.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
