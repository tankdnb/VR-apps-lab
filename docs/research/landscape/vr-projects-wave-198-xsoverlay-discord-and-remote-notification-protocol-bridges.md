# VR Projects Wave 198: XSOverlay Discord and Remote Notification Protocol Bridges

- Date: `2026-06-06`
- Research mode: code-level reading pass only
- Build/run status: not run, not built, not installed, not launched
- Local source cache: temporary `.research-sources/` clone cache only

## Theme

Wave 198 studies projects that send notifications into XSOverlay. The
reusable value is the bridge architecture: client hooks, Discord message
normalization, XSOverlay payload fields, direct UDP, WebSocket companion
transport, remote HTTPS proxying, icon/base64 handling, and security boundaries
for notification ingress.

## Studied Projects

| Project | Placement | Reuse posture |
|---|---|---|
| `GreyFoxx74/xsoverlay-proxy` | Remote HTTPS proxy to XSOverlay UDP | Strong remote bridge donor |
| `nitrog0d/XSOverlay-Discord-Notifications` | Powercord notification hook | Thin client-hook reference |
| `Eidenz/XSOverlay-BetterDiscord` | BetterDiscord Discord notification bridge | Formatting/filter donor |
| `nyakowint/xsOverlayVencord` | Vencord WebSocket/UDP notification bridge | Strongest Discord hook donor |
| `Arsenic110/XSOverlay-BetterDiscord-Notifications` | BetterDiscord variant with settings/cooldown | Variant reference |
| `jpdown/Discord-XSOverlay-Notifications` | Discord RPC notification reader | Standalone RPC baseline |

## `GreyFoxx74/xsoverlay-proxy`

- Interesting idea:
  an HTTPS service accepts remote notification payloads with a shared auth key
  and forwards them as UDP datagrams to a local XSOverlay instance.
- Code donor value:
  high for proxy boundary, health check, rate limit, auth validation, CLI
  sender, install docs, and watchdog framing.
- Product reference value:
  high for remote server, bot, and cron notifications in VR.
- What to inspect next:
  TLS/cert flow, bind-address defaults, key rotation, payload validation, and
  LAN exposure.
- Source evidence:
  `xsoverlay-proxy.js`, `send2xso.py`, `config/default.json`,
  `local.json.example`, and `xsoverlay-proxy.ps1`.
- Reusable pattern extraction:
  authenticated remote notification proxy into an existing VR overlay host.
- Reusable core:
  require a non-default auth key, accept a bounded notification payload, apply
  rate limits, expose health/status, forward to the overlay's local protocol,
  and provide a scriptable sender plus watchdog.
- Do not copy directly:
  self-signed certificate defaults, verify-disabled clients, public bind
  assumptions, or secrets in config files.
- Caveats:
  strongest donor in this wave, but it needs explicit threat modeling.

## `nitrog0d/XSOverlay-Discord-Notifications`

- Interesting idea:
  a Powercord plugin hooks Discord notifications and forwards title/content,
  timeout, opacity, height, source app, and base64 avatar icons to XSOverlay.
- Code donor value:
  medium for direct Discord notification hook and payload construction.
- Product reference value:
  medium for the earliest/simple client-mod shape.
- What to inspect next:
  current Powercord compatibility, mute filtering, and richer message
  normalization.
- Source evidence:
  `index.js` and `Settings.jsx`.
- Reusable pattern extraction:
  Discord client hook to XSOverlay notification payload.
- Reusable core:
  intercept the client's notification event, derive title/content/icon, expose
  timeout/opacity settings, and send a JSON notification object over UDP.
- Do not copy directly:
  stale client-mod APIs or minimal filtering as a final design.
- Caveats:
  useful as lineage, less mature than the Vencord variant.

## `Eidenz/XSOverlay-BetterDiscord`

- Interesting idea:
  a BetterDiscord plugin normalizes Discord messages, filters by DM/server
  settings and mention policy, formats mentions/roles/emotes/channels, and
  sends XSOverlay UDP payloads with avatar icons.
- Code donor value:
  high for message formatting and notification height policy.
- Product reference value:
  high for Discord-in-VR notification UX.
- What to inspect next:
  current BetterDiscord compatibility, relationship event bug path, and
  setting persistence.
- Source evidence:
  `XSOverlay.plugin.js`.
- Reusable pattern extraction:
  Discord message normalization for VR overlay notifications.
- Reusable core:
  ignore self, respect mute/mention policy, build context-aware titles for
  guild/DM/group channels, label embeds/stickers/attachments, replace mentions
  and roles with readable text, fetch the author icon, and dispatch one
  overlay notification.
- Do not copy directly:
  client-mod internals or broad message exposure without privacy settings.
- Caveats:
  strong formatting donor, but tied to Discord internals.

## `nyakowint/xsOverlayVencord`

- Interesting idea:
  a Vencord plugin supports both WebSocket transport to a companion host and
  legacy UDP fallback while filtering bots, DMs, groups, calls, images, and
  extended durations.
- Code donor value:
  very high for modern client-hook boundaries, transport abstraction, filters,
  attachment/mention/embed handling, and call-event support.
- Product reference value:
  very high for polished notification UX.
- What to inspect next:
  companion WebSocket protocol, image encoding, message length policy, and
  Discord client update resilience.
- Source evidence:
  `index.tsx` and `native.ts`.
- Reusable pattern extraction:
  overlay notification bridge with transport fallback and rich filters.
- Reusable core:
  normalize Discord events, apply explicit settings for bot/server/DM/group/call
  notifications, enrich payloads with avatars/images and context, choose
  WebSocket or UDP transport, and adjust duration by message content.
- Do not copy directly:
  Discord client internals, avatar/image fetch assumptions, or mod-specific
  native bridges without compatibility review.
- Caveats:
  strongest Discord client-hook donor in this wave.

## `Arsenic110/XSOverlay-BetterDiscord-Notifications`

- Interesting idea:
  a BetterDiscord variant adds settings for notification duration/opacity,
  DND and ignore checks, cooldown behavior, formatted message helpers, and
  XSOverlay UDP sends.
- Code donor value:
  medium for cooldown and setting variants.
- Product reference value:
  medium as a fork/variant comparison node.
- What to inspect next:
  copied library code, broken settings placeholders, and compatibility with
  current Discord internals.
- Source evidence:
  `XSOverlayNotifier.plugin.js`.
- Reusable pattern extraction:
  client-hook notification bridge variant.
- Reusable core:
  combine Discord notification eligibility checks, configurable timeout and
  opacity, author/icon enrichment, cooldown gating, and UDP dispatch.
- Do not copy directly:
  embedded UI/toast scaffolding, placeholder ignore lists, or copied client
  internals.
- Caveats:
  useful for comparison, weaker as a clean donor.

## `jpdown/Discord-XSOverlay-Notifications`

- Interesting idea:
  a standalone Node script uses Discord RPC notification subscriptions and sends
  resulting events to XSOverlay over UDP.
- Code donor value:
  medium for the standalone RPC alternative to client mods.
- Product reference value:
  medium for a minimal bridge that avoids patching the Discord renderer.
- What to inspect next:
  OAuth app setup, notification scope availability, token handling, and current
  Discord RPC support.
- Source evidence:
  `index.js`.
- Reusable pattern extraction:
  Discord RPC notification reader to overlay payload.
- Reusable core:
  subscribe to notification events through Discord RPC, download the event icon,
  build an XSOverlay notification object, and dispatch it over local UDP.
- Do not copy directly:
  empty client secrets, local OAuth assumptions, or unvalidated event payloads.
- Caveats:
  good baseline if Discord RPC remains viable.

## Cross-Project Lessons

- Overlay notification bridges need transport abstraction: direct UDP, local
  WebSocket companion, and authenticated remote proxy have different trust
  boundaries.
- Discord notifications need normalization before VR display: channel context,
  embeds, stickers, attachments, calls, mentions, roles, bots, and DMs.
- Icons and images improve glanceability but add network fetches and privacy
  exposure.
- Remote notification proxies must treat LAN and shared auth keys as security
  design issues, not installation details.
- Client-mod bridges are fragile and should be documented as compatibility
  references, not stable platform APIs.

## Reuse Recommendations

1. Use `xsoverlay-proxy` for remote notification proxy design.
2. Use `xsOverlayVencord` as the strongest Discord hook and transport donor.
3. Use `XSOverlay-BetterDiscord` for message formatting and context handling.
4. Use `Discord-XSOverlay-Notifications` as a standalone RPC baseline.
5. Keep Powercord/BetterDiscord variants as compatibility and lineage nodes.

## Follow-Up Gaps

- Build a XSOverlay payload compatibility matrix across message fields,
  timeouts, opacity, icon modes, audio paths, and source apps.
- Define a secure remote notification proxy checklist: bind address, auth,
  TLS, rate limits, payload validation, and health checks.
- Compare Discord client-mod, RPC, and webhook/bot approaches for long-term
  maintainability.
- Decide whether notification bridges belong under overlay hosts, protocol
  bridges, or communication utilities in future synthesis.
