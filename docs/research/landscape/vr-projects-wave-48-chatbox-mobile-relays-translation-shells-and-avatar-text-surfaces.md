# VR Projects Wave 48: Chatbox Mobile Relays, Translation Shells, and Avatar Text Surfaces

- Date: `2026-04-19`
- Goal: add the next serious GitHub discovery wave for repositories that were
  not yet represented deeply enough in `VR-apps-lab`, focusing on
  `mobile chatbox relays`, `translation and transcription shells`, and
  `avatar text-surface installers`.

## Why this wave exists

`VR-apps-lab` already had chatbox composers, textbox tools, and some STT notes,
but the broader `social text workflow` branch still had major gaps:

- mobile-first chatbox relays that avoid returning to a desktop textbox;
- translation and transcription shells that mix desktop UI, overlays,
  local-model management, and `OSCQuery`;
- avatar text-surface installers that automate parameter-grid and animator
  setup;
- extremely small chatbox senders that clarify the minimum useful queueing and
  rate-limiting story.

This wave exists to make
`chatbox mobile relays, translation shells, and avatar text surfaces`
clearer inside `VR-apps-lab`.

## Better workflow used in this wave

This wave followed the repository's post-restructure research pipeline:

1. search GitHub with VRChat chatbox, relay, translation, and avatar-text
   queries;
2. deduplicate against the registry;
3. freeze a bounded shortlist;
4. inspect local source clones in `.research-sources/github/`;
5. extract methods, donor value, and family overlap;
6. promote findings into the registry, families, methods, and backlog.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `BoiHanny/vrcosc-magicchatbox` | Revisiting it against stronger neighbors makes the broad `multi-status chatbox shell` pattern much clearer |
| `ScrapW/Chatbox` | Strong donor for a mobile-first chatbox relay with an Android overlay entry surface |
| `misyaguziya/VRCT` | Strong donor for a translation and transcription shell that spans Tauri, Python, overlays, and `OSCQuery` |
| `killfrenzy96/KillFrenzyAvatarText` | Strong donor for avatar text-surface installation driven by parameter-grid encoding and editor automation |
| `dbqt/VRCOSCChatbox` | Strong donor for the minimum viable `rate-limited chatbox sender` product shape |

## Secondary candidates surfaced in the same wave

| Project | Why it was not promoted further yet |
|---|---|
| `MaurerKrisztian/vrc-tts-osc` | Useful narrow comparison node, but the frozen shortlist already covered stronger donors for relay UX, translation shells, avatar text surfaces, and thin chatbox sending |

## Deep-pass notes by project

## `BoiHanny/vrcosc-magicchatbox`

- GitHub:
  [BoiHanny/vrcosc-magicchatbox](https://github.com/BoiHanny/vrcosc-magicchatbox)
- What it is:
  a broad WPF desktop companion that assembles many modules into bounded
  VRChat chatbox output.
- Why it matters:
  it remains the clearest donor in the repo for
  `character-budgeted modular chatbox composition`.
- Interesting ideas:
  treat the chatbox like a compact utility dashboard; keep status modules such
  as media, AFK, weather, and hardware state separate; trim to the last
  allowed characters instead of letting output sprawl unpredictably.
- Interesting implementation choices:
  `MainWindow.xaml.cs`
  makes the `many module timers -> aggregate text fields -> bounded 140-char
  payload` flow explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  licensing is more restrictive than the repo's mainline open-source donors, so
  it remains a stronger idea donor than a copy-ready code donor.
- What to inspect next:
  revisit only when a future branch needs a tighter comparison of
  module boundaries, provider extensibility, or source-available licensing.

## `ScrapW/Chatbox`

- GitHub:
  [ScrapW/Chatbox](https://github.com/ScrapW/Chatbox)
- What it is:
  an Android app that can send VRChat chatbox text locally or remotely and
  exposes a floating overlay surface for entry on mobile devices.
- Why it matters:
  it is the clearest donor in the repo for
  `mobile chatbox relay with a floating overlay entry surface`.
- Interesting ideas:
  move chat entry onto a phone instead of only a desktop; keep remote and local
  OSC targets configurable; support message stash, repeat, and realtime sending
  with typing indicators.
- Interesting implementation choices:
  `ChatboxOSC.kt`,
  `OverlayService.kt`, and
  `ChatboxViewModel.kt`
  make the `mobile overlay button -> message editor -> rate-limited OSC chatbox
  send` path explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  medium-high.
- Caveats:
  Android overlay permissions and mobile assumptions narrow the runtime target,
  but the relay pattern generalizes well.
- What to inspect next:
  keep it visible whenever a future branch needs
  `handheld relay UX` rather than another desktop textbox.

## `misyaguziya/VRCT`

- GitHub:
  [misyaguziya/VRCT](https://github.com/misyaguziya/VRCT)
- What it is:
  a Tauri desktop shell with a Python backend for translation, transcription,
  overlay output, and VRChat chat delivery.
- Why it matters:
  it is the clearest donor in the repo for
  `translation and transcription shell spanning desktop UI, local models,
  overlays, and OSCQuery`.
- Interesting ideas:
  keep the visible desktop shell thin while backend services handle translation,
  transcription, model downloads, and overlay logic; advertise or discover
  `OSCQuery` services when local; support both overlay and chatbox surfaces as
  separate outputs.
- Interesting implementation choices:
  `src-tauri/src/lib.rs`,
  `src-python/models/overlay/overlay.py`,
  `src-python/models/transcription/transcription_whisper.py`, and
  `src-ui/logics/common/useHandleOscQuery.js`
  make the `Tauri UI -> Python service modules -> overlay and OSC outputs`
  split explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the stack is broad and includes Aptabase telemetry, so it is best treated as
  a strong architecture and product donor rather than a copy-paste baseline.
- What to inspect next:
  keep it visible whenever a future branch needs
  `local-model speech shell plus overlay and OSC output`.

## `killfrenzy96/KillFrenzyAvatarText`

- GitHub:
  [killfrenzy96/KillFrenzyAvatarText](https://github.com/killfrenzy96/KillFrenzyAvatarText)
- What it is:
  a Unity and editor-side avatar text system that installs parameters, menus,
  animator assets, and an in-world keyboard flow.
- Why it matters:
  it is the clearest donor in the repo for
  `avatar text-surface installer driven by pointer-indexed parameter grids`.
- Interesting ideas:
  treat avatar parameters as a display bus; automate the repetitive menu and
  animator setup; encode text through a pointer plus chunked character-sync
  floats rather than only raw chatbox emission.
- Interesting implementation choices:
  `KAT_Main.cs` and
  `KAT_Parameters.cs`
  make the `editor installer -> parameter-grid encoding -> avatar-side text
  surface` path explicit.
- Code donor value:
  high.
- Product reference value:
  high.
- Architecture reference value:
  high.
- Caveats:
  the strongest donor is the installation and encoding method, not a general
  desktop-side text product.
- What to inspect next:
  keep it visible whenever a future branch needs
  `avatar-visible text surfaces` instead of a bounded chatbox line.

## `dbqt/VRCOSCChatbox`

- GitHub:
  [dbqt/VRCOSCChatbox](https://github.com/dbqt/VRCOSCChatbox)
- What it is:
  a very small WPF app that buffers and rate-limits outgoing VRChat chatbox
  messages.
- Why it matters:
  it is the clearest product reference in the repo for
  `tiny chatbox micro-utility with one background send queue`.
- Interesting ideas:
  keep the tool tiny; use one queue and one sender task; separate typing
  indicator behavior from final message sends; keep character counts and empty
  clears simple.
- Interesting implementation choices:
  `MainWindow.xaml.cs`
  makes the `textbox -> buffered queue -> background sender with rate limits`
  flow explicit.
- Code donor value:
  medium-high.
- Product reference value:
  high.
- Architecture reference value:
  medium.
- Caveats:
  intentionally narrow scope means its main lesson is product sharpness and send
  hygiene, not platform breadth.
- What to inspect next:
  keep it visible whenever a future branch needs
  `the smallest useful chatbox sender`.

## Main takeaways from Wave 48

- `VRChat text workflows` are now broader than desktop textbox or STT tools.
- The strongest split in this family is:
  - `broad modular chatbox composer`
  - `mobile chatbox relay`
  - `translation and transcription shell`
  - `avatar text-surface installer`
  - `tiny buffered chatbox micro-utility`
- The most reusable lesson is that `text output in social VR` spans several
  different construction styles:
  - bounded status composition
  - handheld relay surfaces
  - local-model translation or transcription shells
  - avatar-side text buses
  - minimal rate-limited senders

## Reusable methods clarified by this wave

- `Mobile or handheld chatbox relay with a floating overlay entry surface`
- `Translation and transcription desktop shell over overlay, local-model, and OSCQuery services`
- `Avatar text-surface installer driven by pointer-indexed parameter grids`
- `Tiny buffered chatbox micro-utility with one background sender task`
