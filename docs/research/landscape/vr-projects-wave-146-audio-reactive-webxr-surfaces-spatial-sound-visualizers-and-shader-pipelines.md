# VR Projects Wave 146: Audio-Reactive WebXR Surfaces, Spatial Sound Visualizers, and Shader Pipelines

- Date: `2026-06-05`
- Goal: study sound-aware VR/WebXR projects that convert audio into scene,
  shader, or diagnostic signals.

## Why this wave exists

Audio can be a utility signal, not only content. A VR diagnostic overlay could
show microphone permission, channel balance, spatial direction, frequency
activity, beat detection, or app audio levels. These projects show several
ways to turn audio into visual state across browser and native stacks.

## Better workflow used in this wave

1. searched by WebXR audio visualizer, VR music visualizer, WebAudio VR,
   spatial audio WebXR, and raymarching visualizer families;
2. deduplicated against previous audio player, spatial audio SDK, browser
   video, and media waves;
3. froze a shortlist across WebXR AR, Three/WebXR, native Oculus/D3D, and
   A-Frame examples;
4. inspected local-only source clones;
5. extracted reusable methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `shift/webxr-audio-visualizer` | Stereo microphone analysis and directional AR waveform sources |
| `Alex-DG/vite-three-webxr-audio-visualizer` | WebAudio/p5 analysis feeding Three/WebXR shader uniforms |
| `ConorStokes/boondoggle` | Native WASAPI/FFT/audio-texture pipeline for VR raymarching |
| `DranoelMit/seeSound` | Simple A-Frame frequency-bin geometry visualizer |

## Deep-pass notes by project

## `shift/webxr-audio-visualizer`

- GitHub:
  [shift/webxr-audio-visualizer](https://github.com/shift/webxr-audio-visualizer)
- What it is:
  a single-page WebXR AR directional audio waveform visualizer using Three.js
  and WebAudio microphone input.
- Interesting idea:
  make sound direction visible as tracked AR sources rather than a flat
  spectrum panel.
- Code-level notes:
  `index.html` requests stereo microphone input with echo cancellation,
  noise suppression, and auto gain disabled. It creates a channel splitter,
  left/right analysers, and multiple `AudioSource` visual objects. Each source
  owns a line waveform, glow sphere, target/current position, smoothing,
  intensity, active state, and geometry updates. Waveform vertices form a
  circle around the source point, with radius/depth driven by analyser data.
  AR entry is hidden until audio permission succeeds.
- Architecture pattern:
  microphone permission gate plus stereo analysis plus source visualization
  objects.
- Reusable method:
  separate audio permission/setup from XR session entry and model each detected
  sound source as its own scene object.
- Code donor value:
  medium for WebAudio setup and source visualization shape.
- Product reference value:
  high for audio diagnostics and spatial sound feedback.
- Caveats:
  source localization is heuristic and browser microphone behavior varies by
  device.
- What to inspect next:
  compare with real spatial audio SDK telemetry and microphone routing helpers.

## `Alex-DG/vite-three-webxr-audio-visualizer`

- GitHub:
  [Alex-DG/vite-three-webxr-audio-visualizer](https://github.com/Alex-DG/vite-three-webxr-audio-visualizer)
- What it is:
  a Vite/Three/WebXR AR audio-reactive visualizer with p5 sound analysis and
  shader-driven visuals.
- Interesting idea:
  convert audio analysis into a small normalized feature vector that drives
  XR shader uniforms.
- Code-level notes:
  `SoundAnalyse.js` loads audio through p5, initializes `p5.FFT` and
  `p5.Amplitude`, computes volume and spectral centroid, maps them to `mapA`
  and `mapF`, and optionally draws waveform overlay. `experience/index.js`
  creates an XR-enabled Three renderer, an AR button with `dom-overlay`, a
  sphere material, and a particle material. The render loop only updates while
  XR is presenting, then writes `uTime`, `uFrequency`, and `uAmplitude`
  uniforms from the audio analysis state.
- Architecture pattern:
  audio analysis singleton plus XR scene materials consuming normalized audio
  features.
- Reusable method:
  publish audio as a tiny stable feature vector for renderers instead of
  binding visuals directly to raw analyser arrays.
- Code donor value:
  high for browser audio-to-shader uniform flow.
- Product reference value:
  medium for lightweight sound-reactive surfaces.
- Caveats:
  uses p5 sound and a bundled audio asset; microphone/app-audio intake would
  need a different source adapter.
- What to inspect next:
  generalize `mapF` / `mapA` into named utility channels such as RMS, centroid,
  bass, mid, treble, and peak.

## `ConorStokes/boondoggle`

- GitHub:
  [ConorStokes/boondoggle](https://github.com/ConorStokes/boondoggle)
- What it is:
  a Windows/Oculus/D3D11 VR music visualizer based on shadertoy-style
  raymarching.
- Interesting idea:
  treat audio analysis as a runtime texture and effect-package input so visual
  effects can be authored separately from the capture/render loop.
- Code-level notes:
  `boondoggle/audio.cpp` uses WASAPI loopback capture through default render
  endpoint clients, initializes capture buffers, uses KissFFT, applies smoothing
  and frequency bucketing, and prepares data for audio textures and constants.
  `visualizer.cpp` owns the D3D window, device, swap chain, constant buffer,
  sound texture/SRV, and effect package loading. `compiler/compiler_main.cpp`
  compiles JSON-defined shaders, samplers, textures, procedural textures, and
  effects into a binary package. `example/example.json` defines shaders,
  samplers, static textures, and an effect that samples a built-in `sound`
  texture.
- Architecture pattern:
  native audio capture plus FFT processing plus audio texture plus shader
  package compiler.
- Reusable method:
  for heavier native utilities, decouple signal processing, render resources,
  and visual effect authoring.
- Code donor value:
  high for audio texture/frequency bucket architecture and package validation.
- Product reference value:
  medium for immersive audio visualization.
- Caveats:
  older Windows/Oculus/D3D11 stack and not a modern OpenXR codebase.
- What to inspect next:
  port the audio texture idea conceptually to OpenXR/WebXR overlay diagnostics.

## `DranoelMit/seeSound`

- GitHub:
  [DranoelMit/seeSound](https://github.com/DranoelMit/seeSound)
- What it is:
  an in-browser A-Frame VR music visualizer.
- Interesting idea:
  a simple spectrum visualizer can be spatialized as rings of scene geometry
  around the user.
- Code-level notes:
  `docs/JS/SoundGrabber.js` creates an `AudioContext`, connects a selected
  media element through `createMediaElementSource`, creates an analyser, pulls
  `getByteFrequencyData` on each animation frame, and passes bins into
  `update`. `docs/JS/DispSound.js` spawns 100 bars around a circle and cubes in
  wider rings, then updates bar and cube scales from frequency bins. It also
  supports file upload by object URL and starts paired audio elements.
- Architecture pattern:
  WebAudio analyser plus A-Frame geometry generation plus per-frame scale
  updates.
- Reusable method:
  use spatially arranged geometry as a readable audio status display in VR.
- Code donor value:
  low-medium as a simple A-Frame/WebAudio example.
- Product reference value:
  medium for beginner-friendly ambient audio displays.
- Caveats:
  direct global state, duplicated audio elements, and magic layout numbers.
- What to inspect next:
  convert the ring layout into a reusable, configurable audio widget.

## Cross-project synthesis

- Strongest code donors:
  `ConorStokes/boondoggle` and
  `Alex-DG/vite-three-webxr-audio-visualizer`.
- Strongest product references:
  `shift/webxr-audio-visualizer` and `DranoelMit/seeSound`.
- Main reusable methods:
  audio permission staging, analyser-driven feature vectors, directional
  waveform source objects, frequency-bin geometry, audio textures, and
  shader-package separation.

## Fit for `VR-apps-lab`

This wave strengthens sound-aware utility patterns. Future diagnostics,
overlays, or browser tools can reuse the pipeline from audio source to
normalized features to visual feedback, especially for microphone/app-audio
status, channel balance, spatial cues, and ambient HUDs.
