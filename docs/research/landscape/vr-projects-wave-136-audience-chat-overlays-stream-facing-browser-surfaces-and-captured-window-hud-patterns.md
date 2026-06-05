# VR Projects Wave 136: Audience Chat Overlays, Stream-Facing Browser Surfaces, and Captured-Window HUD Patterns

- Date: `2026-06-05`
- Goal: study stream/audience overlay projects as reusable references for
  future VR companion surfaces, captured windows, and browser-backed HUDs.

## Why this wave exists

Chat overlays are a useful adjacent family for VR utilities because they solve
many of the same product problems: legibility, interruption control, input
pass-through, configuration, provider fan-in, and a clear difference between
setup mode and live overlay mode. These projects are not VR-native, but several
are strong donors for windows that can be captured into VR or rebuilt as
dashboard overlays.

## Better workflow used in this wave

1. searched by transparent chat overlay, browser source, emote overlay, and
   multi-provider stream chat families;
2. deduplicated against prior overlay and captured-window waves;
3. froze a shortlist of desktop and browser-source donors;
4. inspected local-only source clones;
5. extracted code-level methods without running or building the projects.

## Repositories deeply studied in this wave

| Project | Why it entered the wave |
|---|---|
| `baffler/Transparent-Twitch-Chat-Overlay` | Transparent Windows chat overlay with setup/overlay mode and jChat integration |
| `Enubia/ghost-chat` | Go/Wails multi-provider transparent chat companion with vanish mode |
| `giambaJ/jChat` | Static browser-source chat renderer with URL configuration and emote providers |
| `BenDMyers/showmy.chat` | Overlay URL builder with validated params and live preview |
| `teklynk/twitch_chat_emotes` | Animated emote/event browser overlay with provider fan-in |

## Deep-pass notes by project

## `baffler/Transparent-Twitch-Chat-Overlay`

- GitHub:
  [baffler/Transparent-Twitch-Chat-Overlay](https://github.com/baffler/Transparent-Twitch-Chat-Overlay)
- What it is:
  a Windows WPF/WebView2 transparent chat overlay for streamers.
- Interesting idea:
  separate setup mode from live overlay mode so a utility can be positioned,
  configured, made click-through, and then restored when interaction is needed.
- Code-level notes:
  `BrowserWindow.cs` exposes border visibility, top-most state, interaction
  toggles, reset behavior, and `WindowDisplayMode.Setup` vs `Overlay`.
  `AppSettings.cs` persists portable JSON settings through Jot and carries chat
  type, opacity, fade, blocked users, allowed users, sound clips, hotkeys,
  OAuth, and BTTV/FFZ/7TV flags. The app embeds jChat/native chat rendering and
  generates user/mod/VIP highlight CSS.
- Code donor value:
  high for setup/live overlay state, hotkey control, persistent config, and
  desktop-window capture patterns.
- Product reference value:
  high for single-monitor/captured-window chat HUD workflows.
- Caveats:
  Windows/WPF/WebView2 focused and not a native VR overlay.
- What to inspect next:
  compare its interaction toggles with native SteamVR overlay mouse handling.

## `Enubia/ghost-chat`

- GitHub:
  [Enubia/ghost-chat](https://github.com/Enubia/ghost-chat)
- What it is:
  a transparent chat companion built with Go, Wails, React, and TypeScript.
- Interesting idea:
  normalize Twitch, YouTube, and Kick chat into one transparent top-most
  window while exposing vanish/click-through behavior from a tray-controlled
  companion app.
- Code-level notes:
  `main.go` embeds the frontend, creates a frameless transparent always-on-top
  window, and adds tray actions for center, vanish toggle, config folder, and
  quit. `app.go` owns config, window, and provider clients, emits
  `chat:message` events into the UI, saves window state on shutdown, and uses
  `SetIgnoreMouseEvents` for vanish mode. Provider clients live under
  `internal/chat/{twitch,youtube,kick}`.
- Code donor value:
  high for multi-provider chat fan-in, tray lifecycle, vanish mode, and config
  migration.
- Product reference value:
  high for lightweight sidecars that can become VR companion panels.
- Caveats:
  desktop transparent-window architecture; VR placement would need an overlay
  host such as Desktop+ or a native rewrite.
- What to inspect next:
  compare provider normalization with broader audience-interaction overlays.

## `giambaJ/jChat`

- GitHub:
  [giambaJ/jChat](https://github.com/giambaJ/jChat)
- What it is:
  a static browser-source Twitch chat overlay.
- Interesting idea:
  make the overlay contract just a URL with query parameters, then keep all
  rendering local to browser-source code.
- Code-level notes:
  `v2/script.js` parses query parameters for animation, bots, command hiding,
  badge hiding, fade, size, font, stroke, shadow, and blocked users. It loads
  BTTV, FFZ, 7TV, Twitch badges, cheer images, and emotes, queues messages,
  appends lines on a timer, prunes to 100 messages, and optionally fades old
  entries.
- Code donor value:
  medium-high for browser-source config parsing and provider-specific emote
  normalization.
- Product reference value:
  high for capture-friendly static overlays.
- Caveats:
  Twitch/browser-source focused and not a full desktop app.
- What to inspect next:
  extract a generic query-parameter schema for VR browser-source panels.

## `BenDMyers/showmy.chat`

- GitHub:
  [BenDMyers/showmy.chat](https://github.com/BenDMyers/showmy.chat)
- What it is:
  an overlay URL builder and chat overlay front door.
- Interesting idea:
  productize a browser-source overlay by giving users a short form, live
  preview, and shareable/copyable URL instead of making them edit code.
- Code-level notes:
  the Netlify serverless sanitizer declares valid parameters for demo mode,
  message expiration, animated emotes, hidden users, commands, latest-message
  behavior, and theme. The homepage uses a three-step builder UI, preview
  iframe, and copy button. `buildURL(isDemo)` turns form state into a clean
  overlay URL.
- Code donor value:
  medium for validated overlay configuration and shareable URL generation.
- Product reference value:
  high for onboarding and preview UX.
- Caveats:
  the donor is product/configuration flow more than runtime VR code.
- What to inspect next:
  reuse the builder pattern for any future browser-backed VR overlay.

## `teklynk/twitch_chat_emotes`

- GitHub:
  [teklynk/twitch_chat_emotes](https://github.com/teklynk/twitch_chat_emotes)
- What it is:
  a Twitch chat bot/browser overlay that animates chat emotes.
- Interesting idea:
  treat chat as an event stream that produces bounded animated visual objects
  rather than only text rows.
- Code-level notes:
  `assets/js/bot.js` reads URL parameters for API server, provider toggles,
  size, custom size, effect, speed, duration, channel, and emote limit. It
  selects API servers with timeout fallback, fetches provider emotes in
  parallel, connects through TMI, handles reconnect error UI, bounds emote
  counts, and animates images with vertical, horizontal, random, fade, pop,
  grow, rotate, and skew effects.
- Code donor value:
  medium-high for animated event-to-visual overlay behavior and provider
  fallback.
- Product reference value:
  medium-high for playful audience feedback surfaces.
- Caveats:
  streaming/OBS focused; needs careful moderation and legibility constraints
  before VR use.
- What to inspect next:
  compare emote animation rules with notification-overlay motion limits.

## Cross-project extraction

- Setup/live overlay state is a reusable control boundary:
  `Transparent-Twitch-Chat-Overlay` and `ghost-chat` both separate placement
  and configuration from click-through viewing.
- Query strings are a strong public contract for browser-source overlays:
  `jChat`, `showmy.chat`, and `twitch_chat_emotes` all show different levels
  of parameter validation and preview.
- Provider fan-in should be normalized early:
  chat, badges, emotes, and events become reusable only when Twitch, YouTube,
  Kick, BTTV, FFZ, and 7TV differences are isolated behind a provider layer.
- Captured windows remain a valid VR utility path:
  a top-most transparent desktop window can be valuable before a native
  OpenVR/OpenXR overlay exists.

## Reusable methods extracted

- Transparent/captured chat window with setup/overlay toggle and persistent
  click-through controls.
- Query-string configured browser overlay builder with live preview and
  validated params.
- Chat/emote fan-in renderer with provider normalization and animated effects.

## Caveats for future use

- These are stream/audience overlays, not VR-native runtime integrations.
- Chat surfaces can become noisy in-headset if animation, opacity, and message
  lifetime are not constrained.
- Provider API drift is likely, so future reuse should isolate providers behind
  small adapters.

## Next gaps

- Search moderator-controlled collaborative overlays and remote audience
  control panels.
- Compare captured desktop chat windows with native dashboard overlays.
- Extract a generic browser-source overlay config schema.
