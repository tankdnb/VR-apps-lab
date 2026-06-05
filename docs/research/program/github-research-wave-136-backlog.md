# GitHub Research Wave 136 Backlog

- Date: `2026-06-05`
- Scope: audience chat overlays, stream-facing browser surfaces, transparent
  desktop windows, and animated emote HUD references.

## Completed in this wave

- Studied `baffler/Transparent-Twitch-Chat-Overlay` as a WPF/WebView2 desktop
  overlay with setup vs overlay display modes, border/interactable toggles,
  persistent JSON settings, jChat integration, hotkeys, sounds, and third-party
  emote options.
- Studied `Enubia/ghost-chat` as a Go/Wails/React transparent chat companion
  with multi-provider chat clients, tray controls, window-state persistence,
  and vanish/click-through behavior.
- Studied `giambaJ/jChat` as a static browser-source chat renderer with URL
  parameter configuration, BTTV/FFZ/7TV/Twitch badge and emote loading, queued
  messages, pruning, and fade behavior.
- Studied `BenDMyers/showmy.chat` as a shareable overlay URL builder with
  validated query parameters, live preview iframe, and simple theme controls.
- Studied `teklynk/twitch_chat_emotes` as an animated emote/event browser
  overlay with provider fan-in, API-server fallback, reconnect handling, and
  movement/effect options.

## Reuse candidates

- `Transparent-Twitch-Chat-Overlay` is the strongest desktop-window donor for
  setup mode, click-through mode, hotkeys, settings, and embedded chat UI.
- `ghost-chat` is the strongest multi-provider sidecar donor.
- `showmy.chat` is the cleanest overlay-URL/product-onboarding reference.
- `jChat` and `twitch_chat_emotes` are strong static browser-source references
  for provider normalization and visual effect layers.

## Follow-up backlog

1. Compare transparent desktop-window chat overlays with native VR dashboard
   chat surfaces.
2. Extract a compact browser-source configuration contract for future overlay
   prototypes.
3. Build a provider-normalization checklist for chat, badges, emotes, and
   event overlays.
4. Queue multi-user/moderator-controlled stream overlays for a future pass if
   audience interaction becomes active.

## Quality notes

- No found project was built, launched, installed, or run.
- Source clones were local-only and scheduled for cleanup after documentation
  integration.
