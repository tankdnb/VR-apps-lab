# VR Projects Wave 215: Immersive Media/Audio Substrates, LibVLC, Spatial Renderers, and AudioLink

Date: 2026-06-06

Program docs:

- `docs/research/program/github-research-wave-215-plan.md`
- `docs/research/program/github-research-wave-215-backlog.md`

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Matters

Video and audio tools for VR need clear substrate boundaries. The reusable
question is not only "can it play media?", but where decoding happens, how
textures reach the scene, how audio reaches the engine, how spatial rendering
is configured, how shader consumers read audio data, and where platform or
licensing constraints live.

Wave 215 studies media/audio substrates rather than media-player products.

## Project Findings

### `videolan/vlc-unity`

- Interesting idea: LibVLC can be wrapped as a Unity media backend that owns
  native playback while Unity owns scene surfaces, render textures, and optional
  audio-source routing.
- Code donor value: very high. `VLCMediaPlayer.cs` centralizes static LibVLC
  and `MediaPlayer` ownership, media path opening, event callbacks, main-thread
  action dispatch, video-size detection, render-texture resizing, texture
  updates, and flipped blits. `VLCDisplayMesh.cs` applies textures through
  `MaterialPropertyBlock`. `VLCAudioSource.cs` bridges VLC audio callbacks into
  a pinned circular buffer and Unity `AudioClip`/`AudioSource` read path.
- Product reference value: very high for video surfaces, 360 media, streams,
  HDR, and native codec-backed VR media tools.
- Architecture pattern: native media backend plus Unity texture/audio bridge
  plus display helper components.
- Reusable method: keep decode/playback ownership separate from surface
  binding, audio routing, and UI controls.
- Constraints and caveats: native plugins, LGPL/proprietary licensing choices,
  platform graphics constraints, Android/Linux/UWP caveats, and package import
  complexity.
- What to inspect next: 360 projection samples, subtitle/control surfaces,
  platform import settings, and how audio routing behaves in XR scenes.
- Why it matters for `VR-apps-lab`: it is a strong donor for serious media
  backend boundaries.

#### Reusable Pattern Extraction

- Pattern candidate: native media backend to Unity VR surface/audio bridge.
- Problem solved: bring robust codec and stream support into a VR scene without
  binding UI, decoding, texture updates, and audio processing into one object.
- Reusable core: backend instance, media player lifecycle, async open, event
  queue, video-size detection, render-texture resize/update, display helper,
  audio callback buffer, and Unity audio-source output.
- Source evidence: `VLCMediaPlayer.cs`, `VLCDisplayMesh.cs`,
  `VLCAudioSource.cs`, and package documentation.
- Abstraction boundary: backend decode, Unity texture output, Unity audio
  output, display component, and product controls stay separate.
- What not to copy: native package settings, license assumptions, platform
  workarounds, or audio buffer sizes without testing the target.
- Method catalog action: create Method 660.

### `videolan/libspatialaudio`

- Interesting idea: spatial audio rendering can expose one renderer API for
  object, higher-order ambisonic, direct-speaker, and binaural streams while
  keeping head orientation and output layout explicit.
- Code donor value: high. `include/Renderer.h` exposes `Configure`, `AddObject`,
  `AddHoa`, `AddDirectSpeaker`, `AddBinaural`, `GetRenderedAudio`,
  `SetHeadOrientation`, and `SetOutputGain`. Internals include output layout,
  HOA decoder/rotator/binauralizer, object and direct-speaker gain
  calculators, interpolators, decorrelator, and virtual speaker buffers.
- Product reference value: high for immersive video, spatial music, audio
  diagnostics, and head-tracked binaural output.
- Architecture pattern: renderer substrate with explicit stream types, output
  layout, HRTF path, and head-orientation boundary.
- Reusable method: normalize immersive audio inputs into declared stream types
  and keep renderer configuration separate from media playback UI.
- Constraints and caveats: DSP complexity, native C++ integration, codec/spec
  knowledge, and license review.
- What to inspect next: sample integration code, head-orientation update rates,
  and how stream metadata maps from video containers.
- Why it matters for `VR-apps-lab`: it is a source-level reference for
  object/HOA/binaural renderer APIs.

### `VoidXH/Cavern`

- Interesting idea: a managed audio framework can model immersive sound through
  listeners, sources, filters, remapping, virtualization, room correction, and
  Unity-like components.
- Code donor value: high. `Listener.cs` owns loudspeaker layouts, source lists,
  environment state, rendering cadence, and output buffer generation.
  `Source.cs` performs clip collection, pitch/doppler, resampling, 1D/stereo
  mixing, 3D mixing, distance simulation, spatial filters, and nearest-source
  culling. Unity wrappers `AudioListener3D.cs` and `AudioSource3D.cs` expose
  familiar component properties for update rate, quality, delay, LFE,
  normalizer, virtualizer, doppler, rolloff, size, and spatial filters.
- Product reference value: high for managed spatial audio, room correction,
  and Unity-like immersive audio component UX.
- Architecture pattern: listener/source renderer plus optional Unity wrapper
  components.
- Reusable method: expose low-level renderer capabilities through familiar
  listener/source component contracts.
- Constraints and caveats: nonstandard license, performance complexity,
  specialized audio domain, and target-specific channel layouts.
- What to inspect next: layout loading, room-correction calibration, Unity
  wrapper lifecycle, and test coverage for spatial filters.
- Why it matters for `VR-apps-lab`: it complements native spatial audio with a
  managed component-oriented donor.

### `llealloo/audiolink`

- Interesting idea: audio data can become a global shader-readable texture bus,
  letting world prefabs, avatars, and materials react to audio without each
  consumer reading the audio source directly.
- Code donor value: very high for audio-reactive VR worlds. `AudioLink.cs`
  samples left and right audio data through `GetOutputData`, chunks it into
  material arrays, controls a `CustomRenderTexture`, publishes global
  `_AudioTexture`, handles sync timing and master metadata, and supports editor
  versus in-game texture update modes. `AudioLink.cginc` defines the texture
  layout, access helpers, DFT/waveform/4-band data, chrono/time helpers, global
  strings, and source-position helpers. `AudioLinkController.cs` exposes UI
  controls for gain, fade, crossover, threshold, autogain, power, theme, and
  sync behavior.
- Product reference value: very high for VRChat audio-reactive environments and
  shader-driven visualization systems.
- Architecture pattern: audio source sampler plus render-texture processing
  plus global shader API plus controller surface.
- Reusable method: publish normalized audio analysis once, then let shader and
  prefab consumers read a shared bus.
- Constraints and caveats: VRChat/Unity shader pipeline, Udon/MonoBehaviour
  dual compile paths, performance/readback concerns, and consumer dependence on
  texture layout.
- What to inspect next: texture layout docs, theme/sync controller UX, and
  compatibility with non-VRChat Unity or WebXR shader pipelines.
- Why it matters for `VR-apps-lab`: it is the strongest donor for audio-reactive
  data-bus design.

#### Reusable Pattern Extraction

- Pattern candidate: global audio-reactive shader data bus.
- Problem solved: many scene consumers need audio analysis, but reading and
  transforming audio separately in each consumer is fragile and expensive.
- Reusable core: authoritative audio source, sample extraction, chunk upload,
  render-texture processing, global shader texture, include/helper API,
  controller UI, sync state, and documented texture layout.
- Source evidence: `AudioLink.cs`, `AudioLink.cginc`, `AudioLinkController.cs`,
  and package metadata.
- Abstraction boundary: audio capture, analysis texture production, shader
  read API, consumer effects, and UI control are separate.
- What not to copy: VRChat-specific wrappers, fixed texture layout, or async
  readback assumptions without target performance tests.
- Method catalog action: included in Method 660.

## Cross-Project Lessons

- Media/audio work should name the substrate boundary: decoder, renderer,
  texture output, audio output, shader bus, and UI controls are different
  responsibilities.
- Native codec and DSP libraries bring license and platform constraints that
  must be documented beside the architecture.
- Unity-friendly wrappers are valuable when they expose familiar component
  contracts while keeping backend ownership clear.
- Audio-reactive systems scale better when analysis is published once as a bus.

## Method Catalog Actions

- Added Method 660: immersive media/audio substrate boundary for VR surfaces.

## Follow-Up Gaps

- Build a cross-wave media matrix that separates player UX, decoder substrate,
  projection model, texture output, audio output, and platform/licensing risk.
- Compare `libspatialaudio` and `Cavern` API shapes for object, HOA, binaural,
  listener/source, and layout configuration.
- Revisit earlier audio-reactive and video-player waves to mark which projects
  are surface/product references versus substrate donors.
