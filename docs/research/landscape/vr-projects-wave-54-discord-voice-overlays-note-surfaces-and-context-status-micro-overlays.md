# VR Projects Wave 54: Discord Voice Overlays, Note Surfaces, and Context-Status Micro-Overlays

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `Discord voice overlays`, `note surfaces`, and
  `context-status micro-overlays`.

## Why this wave exists

`VR-apps-lab` already had communication sidecars, captions, and some
micro-overlays, but another adjacent branch still needed a cleaner map:

- Discord overlays with direct local IPC instead of generic web or OSC bridges;
- browser-widget overlays that wrap one narrow presence view;
- session-scoped note or annotation surfaces;
- game-specific overlays that prove how much value a tiny in-headset display can
  deliver.

This wave exists to make
`Discord voice overlays, note surfaces, and context-status micro-overlays`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with Discord-overlay, notes-overlay, and status-overlay
   queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `Larsundso/SteamVR-Discord-Overlay` | Strong donor for a Discord-local-IPC overlay with message subscriptions, button overlays, and a localhost control dashboard |
| `Artemol/DiscOverlay` | Useful donor for the thinner `browser widget projected into Unity overlay` approach |
| `hiinaspace/vr-notes-anywhere` | Strong donor for a session-scoped drawing and annotation surface rendered through projection overlays |
| `jacklul/SteamVR-PhasmoMatrix` | Useful donor for the thinnest `website wrapper as domain overlay` pattern |
| `SteveMarkhamGIT/SmudgeTimerOpenVR` | Strong donor for a wrist-mounted game-status overlay with gesture-triggered controls |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `beareogaming/BD-XSOverlay-notify` | Interesting `external plugin -> overlay host` angle, but the main wave lessons were clearer in repos that owned their render surface directly |

## Deep-pass notes by project

## `Larsundso/SteamVR-Discord-Overlay`

- GitHub:
  [Larsundso/SteamVR-Discord-Overlay](https://github.com/Larsundso/SteamVR-Discord-Overlay)
- What it is:
  a .NET 8 SteamVR overlay that talks directly to Discord's local IPC pipe,
  renders VC members and message cards, and exposes a localhost web dashboard
  for control.
- Why it matters:
  it is the clearest donor in the repo for
  `communication overlay plus localhost dashboard plus optional button surfaces`.
- Interesting ideas:
  treat Discord IPC as the source of truth instead of a bot token; render both
  voice presence and subscribed text-channel messages; add separate mute or
  deafen button overlays; expose full settings and live state through an
  embedded web dashboard.
- Interesting implementation choices:
  `VRDiscordOverlay/Discord/DiscordRpcClient.cs`
  makes the `local pipe -> RPC subscription -> voice and message events` path
  explicit, while
  `VRDiscordOverlay/Web/WebServer.cs`
  shows a second `overlay state -> localhost REST/WebSocket dashboard` surface.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  Discord-specific scope narrows direct reuse, but the `overlay + local control
  panel` architecture generalizes very well.
- What to inspect next:
  keep it visible whenever a future branch needs
  `rich communication overlay with desktop-side control surface`.

## `Artemol/DiscOverlay`

- GitHub:
  [Artemol/DiscOverlay](https://github.com/Artemol/DiscOverlay)
- What it is:
  a Unity-based SteamVR overlay that shows Discord voice status using the
  Streamkit Voice Widget rendered through a browser view.
- Why it matters:
  it is the clearest donor in the repo for
  `browser widget embedded inside a thin Unity overlay shell`.
- Interesting ideas:
  outsource most content rendering to Discord's existing browser widget; keep
  the native VR app responsible only for placement, sizing, and dashboard-side
  adjustment; let a custom URL override the default widget path.
- Interesting implementation choices:
  `Assets/Scripts/DiscordOverlay.cs`
  handles the actual overlay texture path, while
  `Assets/Scripts/DashboardOverlay.cs`
  shows a second dashboard overlay for in-VR positioning and settings control.
- Code donor value:
  medium-high.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium.
- Caveats:
  the main lesson is `browser content inside overlay shell`, not custom
  rendering or custom communication plumbing.
- What to inspect next:
  keep it visible whenever a future branch needs
  `thin wrapper over a web widget` instead of a heavier host.

## `hiinaspace/vr-notes-anywhere`

- GitHub:
  [hiinaspace/vr-notes-anywhere](https://github.com/hiinaspace/vr-notes-anywhere)
- What it is:
  a Python desktop app that renders session-scoped world-space notes into
  SteamVR projective overlays, with controller-based draw and erase actions.
- Why it matters:
  it is the clearest donor in the repo for
  `annotation overlay with explicit scene state and projection-overlay runtime`.
- Interesting ideas:
  keep notes session-only; split desktop control window from overlay runtime;
  use one controller as draw hand and the other as eraser; treat notes as a
  tiny scene graph rather than a bitmap pasted into VR.
- Interesting implementation choices:
  `src/vr_notes_anywhere/app.py`
  makes the `desktop engine -> per-frame tick -> scene update` flow explicit,
  while
  `src/vr_notes_anywhere/vr_runtime.py`
  shows action registration, overlay creation, and GL texture submission.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  narrow purpose and session-only state are intentional; that constraint is part
  of the product lesson.
- What to inspect next:
  keep it visible whenever a future branch needs
  `drawing, markup, or annotation inside VR`.

## `jacklul/SteamVR-PhasmoMatrix`

- GitHub:
  [jacklul/SteamVR-PhasmoMatrix](https://github.com/jacklul/SteamVR-PhasmoMatrix)
- What it is:
  a tiny SteamVR overlay wrapper around the Phasmophobia Matrix website, built
  on top of `SteamVR-Webkit`.
- Why it matters:
  it is a clean donor for
  `focused website wrapper as a domain-specific overlay`.
- Interesting ideas:
  do almost nothing beyond repackaging a single trusted web tool into a VR
  surface; reuse a browser-backed overlay toolkit instead of inventing a new
  rendering stack.
- Interesting implementation choices:
  `Program.cs`
  is intentionally thin and makes the `SteamVR-Webkit overlay -> load website ->
  event hooks` path explicit.
- Code donor value:
  medium.
- Product reference value:
  medium-high.
- Architecture reference value:
  medium.
- Caveats:
  its donor value is intentionally small because it is mostly a focused wrapper.
- What to inspect next:
  keep it visible whenever a future branch needs the thinnest possible
  `domain website -> VR overlay` pattern.

## `SteveMarkhamGIT/SmudgeTimerOpenVR`

- GitHub:
  [SteveMarkhamGIT/SmudgeTimerOpenVR](https://github.com/SteveMarkhamGIT/SmudgeTimerOpenVR)
- What it is:
  a wrist-mounted Phasmophobia helper overlay that shows a smudge timer and can
  be started or stopped by touching controller tips together.
- Why it matters:
  it is one of the clearest donors in the repo for
  `game-specific wrist overlay with gesture-based interaction`.
- Interesting ideas:
  anchor a generated texture to the left wrist; keep configuration in a console
  loop outside VR; use proximity between controllers as a direct gesture input
  instead of adding more UI chrome.
- Interesting implementation choices:
  `SmudgeTimerOpenVR/SmudgeTimerOverlay.cs`
  makes the `generated image -> OpenGL compositor -> wrist overlay -> tracked
  controller gesture` path explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  game-specific domain keeps the product narrow, but the interaction and wrist
  anchor lessons generalize well.
- What to inspect next:
  keep it visible whenever a future branch needs
  `gesture-triggered wrist micro-overlay`.

## Main takeaways from Wave 54

- `Narrow overlay surfaces` are often more reusable than they first look:
  - `Discord IPC overlay + web dashboard`
  - `browser widget inside Unity shell`
  - `annotation projection overlay`
  - `single-site game helper`
  - `gesture-driven wrist status overlay`
- The clearest product lesson is that a good overlay does not need to be a
  desktop environment; it can just show the one thing the user needed badly
  enough to keep their headset on.

## Reusable methods clarified by this wave

- `Overlay plus localhost dashboard sidecar for live communication state`
- `Session-scoped annotation overlay with explicit scene state`
- `Gesture-driven domain-specific wrist micro-overlay`

## Recommended next moves after this wave

1. Treat `SteamVR-Discord-Overlay` as the main donor for
   `rich communication overlay plus desktop-side dashboard`.
2. Keep `DiscOverlay` visible as the thinner
   `browser widget projected into Unity overlay` comparison node.
3. Keep `vr-notes-anywhere` and `SmudgeTimerOpenVR` visible as proof that very
   focused overlays can still justify serious donor extraction.
4. Keep `SteamVR-PhasmoMatrix` as the smallest `website wrapper` reference.
