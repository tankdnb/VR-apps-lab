# VR Projects Wave 53: Media Launcher Overlays, Playback Surfaces, and Lightweight In-Headset Display Shells

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `media launcher overlays`, `playback surfaces`, and
  `lightweight in-headset display shells`.

## Why this wave exists

`VR-apps-lab` already had desktop mirror suites and browser-backed overlays,
but another adjacent branch still needed clearer donor boundaries:

- overlays that mainly launch or wrap external desktop apps;
- lightweight media-control surfaces for `MPRIS`-style players;
- video or window-capture apps that use `OpenVR` as a display target;
- rough proof-of-concept repos that embed a media player directly inside an
  overlay.

This wave exists to make
`media launcher overlays, playback surfaces, and lightweight in-headset display shells`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with launcher-overlay, media-overlay, and VR-video-player
   queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `Mon-Ouie/launcher-openvr-overlay` | Strong donor for an overlay that launches desktop apps, mirrors them through an external player path, and exposes quick in-headset shortcuts |
| `Mon-Ouie/mpris-openvr-overlay` | Strong donor for a tiny state-and-control overlay over Linux media players |
| `Mon-Ouie/vr-video-player-overlay` | Strong donor for a fuller video and window-capture display surface with multiple projection modes |
| `iigomaru/MPVR` | Useful proof-of-concept donor for embedding libmpv directly in an OpenVR overlay |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `PhialsBasement/fnuidesktop-VR` | Already tracked and still useful as the stronger `desktop mirror` comparison anchor, while this wave focused on launcher and media display shells |

## Deep-pass notes by project

## `Mon-Ouie/launcher-openvr-overlay`

- GitHub:
  [Mon-Ouie/launcher-openvr-overlay](https://github.com/Mon-Ouie/launcher-openvr-overlay)
- What it is:
  a Linux OpenVR overlay shell that lists apps, launches them with optional
  `gamescope` wrapping, and can hand mirrored apps or videos off to
  `vr-video-player`.
- Why it matters:
  it is the clearest donor in the repo for
  `overlay shell as process orchestrator for app launch and display handoff`.
- Interesting ideas:
  keep the overlay UI thin while real launching and mirroring happen through
  external tools; combine icons, app metadata, and player parameters into a
  focused quick-access shell; let the overlay start automatically with SteamVR.
- Interesting implementation choices:
  `src/main.cpp`
  and
  `src/application_launcher.hpp`
  make the `overlay lifecycle -> app list UI -> external process launch ->
  optional video-player path` split explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  Linux-centric assumptions narrow portability, but the orchestration pattern is
  still very reusable.
- What to inspect next:
  keep it visible whenever a future branch needs
  `overlay launcher over external desktop tools`.

## `Mon-Ouie/mpris-openvr-overlay`

- GitHub:
  [Mon-Ouie/mpris-openvr-overlay](https://github.com/Mon-Ouie/mpris-openvr-overlay)
- What it is:
  a Rust plus egui overlay that shows current player state and sends control
  commands through Linux `MPRIS`.
- Why it matters:
  it is the clearest donor in the repo for
  `small state-and-control overlay over an existing desktop bus`.
- Interesting ideas:
  keep the overlay small and single-purpose; render egui into a ping-pong
  texture path; treat player discovery and overlay event handling as one tight
  loop.
- Interesting implementation choices:
  `src/main.rs`
  makes the `player discovery -> egui render -> ping-pong framebuffer -> OpenVR
  control-bar overlay` flow explicit.
- Code donor value:
  high.
- Product reference value:
  medium-high.
- Architecture reference value:
  high.
- Caveats:
  Linux `MPRIS` keeps it niche, but that same constraint makes the structure
  refreshingly clean.
- What to inspect next:
  keep it visible whenever a future branch needs
  `desktop bus -> tiny overlay control surface`.

## `Mon-Ouie/vr-video-player-overlay`

- GitHub:
  [Mon-Ouie/vr-video-player-overlay](https://github.com/Mon-Ouie/vr-video-player-overlay)
- What it is:
  a Linux VR video player that can show built-in mpv playback or captured X11
  windows in flat, plane, sphere, and 360-style modes, including a SteamVR
  overlay path.
- Why it matters:
  it is the clearest donor in the repo for
  `window or video content treated as a configurable VR display surface`.
- Interesting ideas:
  use one app for both video playback and arbitrary window capture; support
  multiple projection modes; let overlay mode coexist with a more ordinary VR
  scene mode.
- Interesting implementation choices:
  `src/main.cpp`
  exposes the large `mode selection -> input handling -> render loop ->
  overlay render` path, while
  `src/window_texture.c`
  shows the `X11 window capture -> GL texture` boundary explicitly.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  Linux- and X11-heavy, but the display-surface architecture generalizes well.
- What to inspect next:
  keep it visible whenever a future branch needs
  `captured content displayed in VR` rather than a full desktop shell.

## `iigomaru/MPVR`

- GitHub:
  [iigomaru/MPVR](https://github.com/iigomaru/MPVR)
- What it is:
  a rough proof-of-concept that embeds libmpv in the context of an OpenVR
  overlay.
- Why it matters:
  it is a comparison node for
  `direct media-engine embed inside overlay`, without the extra layers of a
  fuller player shell.
- Interesting ideas:
  keep the repo brutally small; prove the concept of `mpv instance -> overlay`
  without building a broad UI or host shell around it.
- Interesting implementation choices:
  `MPVR.c`
  makes the `mpv render callbacks -> OpenVR overlay init -> event loop` path
  explicit.
- Code donor value:
  medium.
- Product reference value:
  medium.
- Architecture reference value:
  medium.
- Caveats:
  very rough and ships bundled binaries, so it is more valuable as a comparison
  node than as a polished mainline donor.
- What to inspect next:
  revisit only if a future branch needs a sharper
  `libmpv directly in overlay` comparison against fuller player shells.

## Main takeaways from Wave 53

- `Display shell` work is clearer when split into:
  - `launcher overlay`
  - `player-state control overlay`
  - `window/video display surface`
  - `rough media-engine embed proof-of-concept`
- The biggest reusable lesson is that many useful VR display tools do not need
  to be `desktop replacements`; they can be narrow wrappers over external app,
  bus, capture, or media pipelines.

## Reusable methods clarified by this wave

- `Focused overlay wrapper over external launcher or media toolchains`
- `Window or video content treated as a configurable VR display surface`

## Recommended next moves after this wave

1. Treat `launcher-openvr-overlay` as the main donor for
   `overlay as app orchestrator`.
2. Treat `mpris-openvr-overlay` as the cleanest small donor for
   `desktop-state-to-overlay control surface`.
3. Keep `vr-video-player-overlay` visible whenever a future branch needs
   `captured content or video as a VR surface`.
4. Keep `MPVR` as a rough but useful lower-bound comparison node.
