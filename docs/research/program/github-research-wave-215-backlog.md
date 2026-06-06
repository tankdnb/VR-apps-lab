# GitHub Research Wave 215 Backlog

Date: 2026-06-06

Theme: immersive media/audio substrates, spatial renderers, and audio-reactive
shader buses.

## Completed In This Wave

- Deepened `videolan/vlc-unity` as a LibVLC/LibVLCSharp Unity media backend
  with central media player, render texture updates, display helpers, and Unity
  `AudioSource` callback routing.
- Deepened `videolan/libspatialaudio` as a spatial audio renderer substrate for
  object, HOA, direct-speaker, binaural, HRTF, and head-orientation flows.
- Deepened `VoidXH/Cavern` as a C# immersive audio renderer with listener and
  source models, Unity wrappers, filters, remapping, virtualization, and room
  correction concepts.
- Deepened `llealloo/audiolink` as a VRChat/Unity audio-reactive data bus with
  sampled audio chunks, CustomRenderTexture processing, global shader texture,
  and shader include accessors.
- Added a reusable method entry for immersive media/audio substrate boundaries.

## Follow-Up Queue

1. Compare `vlc-unity` with earlier immersive video player repos to separate
   media backend, surface UI, projection, and platform constraints.
2. Compare `libspatialaudio` and `Cavern` for object/HOA/binaural renderer API
   shapes and listener/source abstractions.
3. Treat `AudioLink` as the strongest donor for a global audio-data bus that
   shader consumers can use without direct audio-source coupling.
4. Build a media/audio substrate matrix: decoder, texture output, audio output,
   spatial renderer, shader bus, UI controls, platform, and license.
5. Revisit previous audio waves and upgrade their notes with substrate-level
   evidence where needed.

## Do Not Spend Time On Yet

- Do not compile or import Unity packages from these repositories.
- Do not treat native codec, HRTF, or DSP licensing as solved without a product
  target.
- Do not copy audio callback or shader-buffer logic without performance and
  platform review.
