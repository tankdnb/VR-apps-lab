# GitHub Research Wave 198 Backlog

- Date: `2026-06-06`
- Theme: `XSOverlay Discord and remote notification protocol bridges`
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Discovery

- `Done` Search GitHub for XSOverlay Discord notifications, BetterDiscord,
  Vencord, Powercord, Discord RPC, and remote XSOverlay proxy projects.
- `Done` Dedupe against earlier overlay-host, Discord overlay, and notification
  utility waves.
- `Done` Freeze a protocol-focused shortlist rather than a broad Discord mod
  list.

## Source Sync

- `Done` Confirm `xsoverlay-proxy` in local-only cache.
- `Done` Confirm `XSOverlay-Discord-Notifications` in local-only cache.
- `Done` Confirm `XSOverlay-BetterDiscord` in local-only cache.
- `Done` Confirm `xsOverlayVencord` in local-only cache.
- `Done` Confirm `XSOverlay-BetterDiscord-Notifications` in local-only cache.
- `Done` Confirm `Discord-XSOverlay-Notifications` in local-only cache.

## Code Reading

- `Done` Inspect HTTPS-to-UDP forwarding, auth key validation, rate limiting,
  health endpoint, CLI sender, install notes, and watchdog script in
  `xsoverlay-proxy`.
- `Done` Inspect Powercord notification hook, payload building, icon fetch, and
  timeout/opacity settings in `XSOverlay-Discord-Notifications`.
- `Done` Inspect BetterDiscord message filtering, DM/server toggles,
  mention/role/emote/channel formatting, attachment labels, icon base64, and
  UDP send in `XSOverlay-BetterDiscord`.
- `Done` Inspect Vencord settings, message/call filtering, attachment/embed
  normalization, image handling, WebSocket transport, and legacy UDP fallback
  in `xsOverlayVencord`.
- `Done` Inspect BetterDiscord variant settings, cooldown, DND/ignore checks,
  formatted messages, avatar icons, and UDP send in
  `XSOverlay-BetterDiscord-Notifications`.
- `Done` Inspect Discord RPC notification subscription, OAuth/app fields, icon
  download, and standalone UDP dispatch in `Discord-XSOverlay-Notifications`.

## Integration

- `Done` Create Wave 198 landscape document.
- `Done` Update registry/family placement.
- `Done` Add reusable methods for Discord-to-overlay notification hooks and
  authenticated remote notification proxies.
- `Next` Build a XSOverlay notification compatibility/security matrix covering
  payload fields, transports, auth, icon handling, Discord client-mod risks,
  and LAN exposure.
