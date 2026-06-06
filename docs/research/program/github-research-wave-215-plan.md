# GitHub Research Wave 215 Plan

Date: 2026-06-06

Theme: immersive media and audio substrates: LibVLC, spatial renderers, Unity
audio wrappers, and shader audio buses.

Research mode: static source reading only. No external repository was run,
built, installed, or launched.

## Why This Wave Exists

Media and audio projects are strong donors for VR utilities because they force
clear boundaries between native decoders, Unity surfaces, render textures,
audio callbacks, spatial renderers, listener/source abstractions, shader data
buses, and platform/licensing constraints.

Wave 215 studies immersive media/audio substrate nodes to extract reusable
patterns for future video, audio, and audio-reactive VR tools.

## Search Families

- Unity video playback backends and LibVLC bridges.
- 360 video, HDR, and native media surfaces.
- Spatial audio renderers, HOA/object/binaural pipelines, and HRTF handling.
- Unity listener/source wrappers for 3D audio.
- VRChat/Unity audio-reactive shader data buses.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `videolan/vlc-unity` | LibVLC/LibVLCSharp Unity bridge with central media player, texture output, mesh/UGUI display helpers, and Unity AudioSource callback routing. | Unity media backend substrate |
| `videolan/libspatialaudio` | Cross-platform spatial audio renderer with unified object, HOA, direct-speaker, and binaural rendering APIs. | Spatial audio renderer substrate |
| `VoidXH/Cavern` | C# immersive audio framework with listener/source model, Unity wrappers, filters, room correction, and virtualization. | Managed immersive audio renderer |
| `llealloo/audiolink` | VRChat/Unity audio-reactive data bus that samples audio, writes CustomRenderTexture data, and exposes global shader accessors. | Audio-reactive shader bus |

## Dedupe Notes

Earlier waves covered VR audio reactivity and video player product surfaces.
Wave 215 focuses on substrate boundaries: how media/audio data moves from
native or engine backends into VR surfaces, Unity audio, spatial renderers, and
shader consumers.

## Code-Level Pass Targets

- Media-player lifecycle and native backend ownership.
- Texture output and render-surface helpers.
- Audio callback and Unity `AudioSource` bridging.
- Spatial renderer input/output APIs and head-orientation boundaries.
- Listener/source abstractions, filters, and remapping.
- Audio-reactive texture layouts and shader include contracts.
- Platform, license, and performance caveats.

## Expected Outputs

- Wave 215 landscape synthesis.
- Registry and family deepening for immersive media/audio substrates.
- Method catalog entry for immersive media/audio substrate boundaries.
- Follow-up backlog for comparing substrate patterns with earlier video player
  and audio-reactive waves.
