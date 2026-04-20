# VR Projects Wave 83: Creator-Facing Audio Systems, Synced Player Frameworks, and World-Side Voice Management

- Date: `2026-04-20`
- Goal: add the next serious GitHub discovery wave for repositories that map
  `creator-facing audio systems`, `synced player frameworks`, and
  `world-side voice management`.

## Why this wave exists

`VR-apps-lab` already had VRChat-side text, OSC, and overlay references, but it
still lacked a clearer answer to:

`what the strongest reusable audio and media systems look like inside creator ecosystems where syncing, shader hooks, permission state, and voice behavior all matter at once`.

This wave exists to make that family clearer.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with audio-reactive, VRChat video player, queue system, and
   world voice-control queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `llealloo/audiolink` | Strong donor for world and avatar audio-reactive infrastructure |
| `MerlinVR/USharpVideo` | Strong donor for synced media playback core in VRChat worlds |
| `sam-ln/USharpVideoQueue` | Strong donor for queue ownership, permissions, and playback handoff around an existing player |
| `JLChnToZ/VVMW` | Strong product and architecture reference for a modular creator-facing media frontend |
| `SylanTroh/AudioManager` | Strong donor for world-side player voice settings, fake occlusion, and priority composition |

## Deep-pass notes by project

## `llealloo/audiolink`

- GitHub:
  [llealloo/audiolink](https://github.com/llealloo/audiolink)
- What it is:
  an audio-reactive framework for Unity creator ecosystems that converts audio
  into a shared texture and exposes it to shaders and scripts.
- Why it matters:
  it is the clearest donor in this wave for
  `GPU-broadcast audio-reactive substrate shared across world and avatar content`.
- Interesting ideas:
  treat audio reactivity as shared infrastructure rather than one prefab effect;
  send processed data into a `CustomRenderTexture` that every compatible shader
  can read; expose controller, player, theme-color, and helper scripts as part
  of the same system rather than a detached sample.
- Interesting implementation choices:
  `AudioLink.cs`
  makes the data path explicit: sample the audio source, manage EQ and fade
  parameters, publish to `_AudioTexture`, and optionally synchronize media state;
  the runtime surface also includes `AudioLinkController`, `AudioLinkMiniPlayer`,
  `AudioReactive*` behaviours, and `ThemeColorController`.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the repo is a broad ecosystem, so this pass only partially exhausts it.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs an
  `audio-reactive world substrate`
  reference.

## `MerlinVR/USharpVideo`

- GitHub:
  [MerlinVR/USharpVideo](https://github.com/MerlinVR/USharpVideo)
- What it is:
  a synced VRChat video player built with UdonSharp and a proxy layer over
  Unity and AVPro player backends.
- Why it matters:
  it is the clearest donor in this wave for
  `network-synced media player core with backend abstraction`.
- Interesting ideas:
  keep the visible player logic separate from the concrete video-player
  components; support playlist, live stream mode, sync thresholds, and lock or
  permission state inside one reusable player behaviour; let one player shape
  work across multiple backend implementations.
- Interesting implementation choices:
  `USharpVideoPlayer.cs`
  owns networked URL, playlist, time-sync, lock state, and playback logic while
  `VideoPlayerManager.cs`
  proxies events and hides the split between Unity and AVPro players, plus
  volume or mute handling across multiple audio sources.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the repo is tightly tied to VRChat world tooling, so some of its sync and
  permission assumptions are ecosystem-specific.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `synced creator-side media player core`
  donor.

## `sam-ln/USharpVideoQueue`

- GitHub:
  [sam-ln/USharpVideoQueue](https://github.com/sam-ln/USharpVideoQueue)
- What it is:
  a queue companion for `USharpVideo` that adds synchronized queue management,
  per-user limits, URL whitelisting, and playback handoff.
- Why it matters:
  it is the clearest donor in this wave for
  `queue ownership and permission shell around an existing networked media player`.
- Interesting ideas:
  keep queue state separate from the player core; make owner RPC, per-user
  limits, and URL whitelist policy explicit; expose a callback event surface so
  other scripts can react to queue changes without patching the queue itself.
- Interesting implementation choices:
  `VideoQueue.cs`
  stores synced arrays for URLs, titles, and player ownership while using owner
  network events for queue requests; it explicitly sequences wait-before-play
  timing and backend switching instead of burying that logic inside UI widgets.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  it is companion-shaped by design, so it depends on a specific player family
  rather than standing alone.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `network-owned queue companion`
  donor.

## `JLChnToZ/VVMW`

- GitHub:
  [JLChnToZ/VVMW](https://github.com/JLChnToZ/VVMW)
- What it is:
  a modular creator-facing video player frontend for VRChat with playlist,
  queue, screen, overlay, AudioLink, and localized UI subsystems.
- Why it matters:
  it is the clearest product and architecture reference in this wave for
  `large modular media frontend inside a creator ecosystem`.
- Interesting ideas:
  split the player into partial core files for audio, timing, screen,
  persistence, AudioLink, and more; support both on-screen UI and overlay or
  wrist-control surfaces; make auxiliary integrations such as AudioLink, LTCGI,
  and lighting updaters optional but first-class.
- Interesting implementation choices:
  `Core_Audio.cs`
  and
  `Core_AudioLink.cs`
  show how audio and AudioLink integration are isolated as partial core slices;
  `OverlayControl.cs`
  shows the separate wrist or desktop control surface; the runtime tree also
  contains explicit frontend, playlist, queue, and screen configurator layers.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the repo is large and feature-rich, so this pass only partially exhausts it.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `modular creator-facing media frontend`
  comparison.

## `SylanTroh/AudioManager`

- GitHub:
  [SylanTroh/AudioManager](https://github.com/SylanTroh/AudioManager)
- What it is:
  a world-side system for setting player voice volume, fake occlusion, and
  audio-setting zones through UdonSharp components.
- Why it matters:
  it is the clearest donor in this wave for
  `priority-based world voice-state management`.
- Interesting ideas:
  model voice settings as composable state rather than one global world value;
  let zone membership and priority determine which settings win; use explicit
  IDs and negative-zone semantics to create transition spaces or fake
  occlusion.
- Interesting implementation choices:
  `AudioSettingButton.cs`
  packages a voice-setting tuple into a `DataList` and applies it through an
  `AudioSettingManager`; the repo also exposes utility scripts and manager
  components that make per-player audio-state composition a first-class system.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  the repo is VRChat-world-specific, so its direct reuse is strongest for world
  or social-space tooling rather than ordinary overlay utilities.
- What to inspect next:
  keep it visible whenever `VR-apps-lab` needs a
  `world voice settings and fake occlusion`
  reference.

## Main takeaways from Wave 83

- `Creator-facing audio systems`
  now split more cleanly into:
  - `audio-reactive substrate`
  - `synced media player core`
  - `queue and permission companion`
  - `modular creator-facing media frontend`
  - `world-side voice-state manager`
- The strongest lesson from this wave is that the best creator-side donors are
  not one script or one prefab. They are systems that keep synchronization,
  permissions, backend abstraction, and world-state integration explicit.
- Another strong lesson is that audio in creator ecosystems often touches
  shaders, UI, network ownership, and social-space behavior at once, which
  makes the architecture boundaries especially reusable.

## Reusable methods clarified by this wave

- `GPU-broadcast audio-reactive texture bus that exposes analyzed audio globally to shaders and scripts`
- `Network-synced media player core with backend proxy split between visible player logic and concrete player components`
- `Owner-routed queue companion with per-user limits, URL policy, and playback handoff around an existing player`
- `Modular creator-facing media frontend that splits core audio, audio-reactive integration, overlays, playlists, and screen control into partial subsystems`
- `Priority-based world voice-state manager with zone membership, transition semantics, and fake occlusion`

## Recommended next moves after this wave

1. Keep `AudioLink` visible as a strong
   `audio-reactive infrastructure`
   donor.
2. Treat `USharpVideo` and `USharpVideoQueue` as a strong comparison line for
   `synced media core + queue companion`.
3. Keep `VVMW` and `AudioManager` visible whenever a future pass needs richer
   creator-side references for
   `modular media frontends`
   and
   `world voice-state management`.
