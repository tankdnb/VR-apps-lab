# GitHub Research Wave 198 Plan

- Date: `2026-06-06`
- Theme: `XSOverlay Discord and remote notification protocol bridges`
- Scope: Discord client hooks, XSOverlay UDP/WebSocket notification payloads,
  remote notification proxies, icon/base64 handling, notification filtering,
  and overlay-host bridge security.
- Execution rule: static source-reading only; do not run, build, install, or
  launch any found repository.

## Why This Wave Exists

Overlay notification tools are a practical part of VR utility design: they
convert external desktop or network events into glanceable in-headset messages.
Wave 198 studies XSOverlay notification bridges as a protocol family: direct
UDP payloads, WebSocket companion-host paths, Discord client hooks, and remote
HTTPS proxying.

## Search Families

- XSOverlay Discord notification plugins
- XSOverlay UDP notification payload senders
- Discord client mod notification bridges
- remote notification proxy to XSOverlay
- overlay notification security and payload compatibility

## Frozen Shortlist

| Project | Why included | Initial family placement |
|---|---|---|
| `GreyFoxx74/xsoverlay-proxy` | HTTPS remote proxy with auth, rate limit, health check, CLI, and watchdog | Strong remote-notification donor |
| `nitrog0d/XSOverlay-Discord-Notifications` | Powercord Discord notification hook to XSOverlay UDP payload | Discord hook reference |
| `Eidenz/XSOverlay-BetterDiscord` | BetterDiscord plugin with DM/server filters and mention/attachment formatting | Discord formatting donor |
| `nyakowint/xsOverlayVencord` | Vencord plugin with WebSocket/UDP transport, filters, images, and call events | Strongest client-hook donor |
| `Arsenic110/XSOverlay-BetterDiscord-Notifications` | BetterDiscord variant with settings, cooldown, and notification formatting | Variant/reference |
| `jpdown/Discord-XSOverlay-Notifications` | Node Discord RPC notification reader to XSOverlay UDP | Standalone RPC baseline |

## Dedupe Notes

- Prior overlay waves covered overlay hosts and surface implementation. This
  wave focuses on notification payload bridges into an existing overlay host.
- Discord mod variants are kept as variants only when they add formatting,
  filtering, transport, or compatibility lessons.
- No Discord client, XSOverlay instance, proxy service, or network listener was
  run.

## Code-Level Pass Targets

- XSOverlay notification payload fields and transport variants.
- Discord message normalization for DMs, groups, guild channels, calls,
  attachments, embeds, stickers, mentions, and roles.
- Filtering by mute state, bot/self, DM/server flags, and notification policy.
- Avatar/icon fetching and base64 handling.
- Remote proxy auth, rate limit, health check, bind address, cert, and
  watchdog behavior.
- Compatibility caveats across Powercord, BetterDiscord, Vencord, and Discord
  RPC.

## Expected Outputs

- Wave 198 landscape synthesis.
- Registry/family placement for XSOverlay notification protocol bridges.
- Methods around Discord client notification hooks and authenticated remote
  overlay notification proxies.
