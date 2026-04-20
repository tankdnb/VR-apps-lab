# VR Projects Wave 81: Immersive Music Players, VR Media Playback Surfaces, and Browser Video Shells

- Date: `2026-04-20`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `immersive music players`, `VR media playback surfaces`, and
  `browser-backed or engine-backed video shells`.

## Why this wave exists

`VR-apps-lab` already had overlay media surfaces and launcher overlays, but it
still lacked a clearer answer to:

`what the strongest reusable playback patterns look like when the player itself is the product, not only one feature inside a broader overlay host`.

This wave exists to make that family clearer.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with VR music player, 360 player, WebXR video, and engine
   playback queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `JustinLin905/around-sound` | Strong product reference for a VR-native spatial music player built around movable speakers |
| `BIVROST/360PlayerWindows` | Strong product reference for a headset-aware immersive media shell with multiple desktop and headset control paths |
| `VR-cam/WebXR-video-player` | Strong donor for browser-based immersive video playback with explicit projection abstraction |
| `videolan/vlc-unity` | Strong framework reference for broad-codec, stream-aware, VR-capable playback inside Unity |

## Deep-pass notes by project

## `JustinLin905/around-sound`

- GitHub:
  [JustinLin905/around-sound](https://github.com/JustinLin905/around-sound)
- What it is:
  a Unity-based immersive music player where the user loads local audio files
  and places or edits multiple virtual speakers in the environment.
- Why it matters:
  it is the clearest product reference in this wave for
  `speaker-topology-first music playback`.
- Interesting ideas:
  treat the listening space itself as the main UI; load music from a fixed
  folder under the user's documents directory instead of hard-coding tracks
  into the build; let speaker spawning and catch-up behavior matter as part of
  the product, not only the audio engine.
- Interesting implementation choices:
  `LoadMusic.cs`
  scans
  `Documents\\Around Sound`
  and ingests local `wav`, `ogg`, and `mp3` files through
  `UnityWebRequest`; `MusicControls.cs`
  treats all tagged speaker objects as playback endpoints and keeps newly added
  speakers synchronized by copying clip and playback time into the new
  `AudioSource`.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium.
- Caveats:
  the project is app-shaped and Unity-scene-heavy, so it is stronger as a UX
  and product reference than as a small reusable library.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `VR-native music player`
  reference built around spatial speaker layout.

## `BIVROST/360PlayerWindows`

- GitHub:
  [BIVROST/360PlayerWindows](https://github.com/BIVROST/360PlayerWindows)
- What it is:
  a Windows 360 video and image player with desktop UI plus headset playback
  backends for Oculus, OpenVR, OSVR, and WMR-related workflows.
- Why it matters:
  it is the clearest product reference in this wave for
  `desktop media shell + pluggable headset backend`.
- Interesting ideas:
  keep ordinary desktop controls, drag-and-drop, keyboard shortcuts, and
  gamepad support as first-class UX even when the repo is VR-oriented; let
  headset mode be a replaceable runtime concern instead of hard-coding one VR
  stack; keep startup UI and playback UI inside one WPF shell.
- Interesting implementation choices:
  `ShellViewModel.cs`
  owns decoder lifecycle, buffering, analytics, and notification flow while
  `ShellViewModel_Headsets.cs`
  keeps headset initialization and backend selection isolated through distinct
  `OculusPlayback`, `OSVRPlayback`, and `OpenVRPlayback` implementations.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the repo is fairly broad and multi-project, so it remains stronger as a
  product and shell-architecture reference than as a tiny donor.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `headset-aware desktop media shell`
  comparison.

## `VR-cam/WebXR-video-player`

- GitHub:
  [VR-cam/WebXR-video-player](https://github.com/VR-cam/WebXR-video-player)
- What it is:
  a Babylon.js and TypeScript WebXR video player with support for local media,
  live WebRTC streams, and device-specific projection handling.
- Why it matters:
  it is the clearest donor in this wave for
  `browser-native immersive video shell with explicit projection abstraction`.
- Interesting ideas:
  make device projection a first-class module; keep the public API small and
  focused around play, pause, mute, set-video, and enter-VR; treat local-file
  playback and stream playback as parallel examples, not one monolithic player.
- Interesting implementation choices:
  `player.ts`
  owns the top-level player flow while
  `projectionManager.ts`
  and the `vrCamV1` or `vrCamV2` device modules keep projection logic separate;
  UI components such as `audioButton.ts`, `playButton.ts`, and `userPanel.ts`
  show a compact in-headset control surface.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  the repo is somewhat device-shaped, so its strongest reuse value is in
  projection and player-shell boundaries rather than as a general-purpose media
  product.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `browser-based immersive player`
  baseline.

## `videolan/vlc-unity`

- GitHub:
  [videolan/vlc-unity](https://github.com/videolan/vlc-unity)
- What it is:
  a Unity integration layer around LibVLC and LibVLCSharp with demos for
  minimal playback, 360 playback, subtitles, and stereo-cinema scenarios.
- Why it matters:
  it is the clearest framework reference in this wave for
  `broad-codec media substrate inside a game engine`.
- Interesting ideas:
  treat immersive playback as one capability inside a general media framework,
  not a one-off demo; keep codec, stream, subtitle, and 360 support under one
  media layer; provide demo scenes that span ordinary and immersive playback
  shapes.
- Interesting implementation choices:
  the repo ships a substantial `Demos` tree with scripts such as
  `VLCMinimalPlayback`, `VLCPlayerExample`, `VLCThreeSixty`, and
  `VLCYouTubePlayback`, which makes the media substrate reusable across several
  player shapes instead of only one prefab.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  the repo is a broad engine framework, so it is only partially exhausted by
  this pass and deserves deeper future inspection if `VR-apps-lab` needs a
  serious media-engine donor.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs an
  `engine-integrated media substrate`
  reference rather than a narrow overlay player.

## Main takeaways from Wave 81

- `Immersive playback`
  now splits more cleanly into:
  - `speaker-topology-first VR music player`
  - `desktop media shell with pluggable headset backends`
  - `browser-native immersive player with explicit projection abstraction`
  - `engine-side media substrate with broad codec and stream support`
- The strongest lesson from this wave is that
  `media player`
  is not one shape. The deepest reuse value often lives in projection logic,
  headset backend selection, or backend abstraction rather than the visible
  transport controls alone.
- Another strong lesson is that browser-native, desktop-native, and engine-side
  media stacks can all be donor-worthy when they expose different playback
  boundaries clearly.

## Reusable methods clarified by this wave

- `VR-native spatial music player built around editable speaker topology and local-file queue ingestion`
- `Desktop immersive media shell with pluggable headset backends and mirrored operator UI`
- `Browser-based immersive video shell with explicit projection-manager and device-abstraction layers`
- `Engine-integrated media substrate that keeps codec, stream, subtitle, and immersive playback support under one reusable backend`

## Recommended next moves after this wave

1. Keep `around-sound` visible as a strong
   `speaker-topology music player`
   reference.
2. Treat `360PlayerWindows` as a valuable
   `desktop shell + headset backend`
   comparison node.
3. Keep `vlc-unity` visible whenever `VR-apps-lab` needs a deeper future pass
   on
   `media playback substrate inside engines`.
