# Wave 322 - XSOverlay Companion Bridges, Phone Notifications, and Translation-Control Sidecars

This wave studies companion-side bridges that push external events or control
state into XSOverlay workflows.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- XSOverlay-facing companion bridges;
- phone notification and translation/control sidecars;
- projects with explicit payload mapping, transport, reconnect, or operator
  controls;
- projects not already tracked in registry/families.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `jonreeve/NotifyXso` | Phone-to-XSOverlay notification bridge | Studied | Strong donor for Android notification listener, HTTP relay, UDP XSOverlay payload mapping, icon handling, filters, and configuration |
| `Daniel81i/YncneoXSOBridge` | Translation/control bridge to XSOverlay | Studied | Product/reference donor for registry-based port discovery, WebSocket reconnect, tray status, logging, translation profiles, and desktop companion operation |

## Code-Level Findings

### `jonreeve/NotifyXso`

- Interesting idea:
  phone notifications can be split into an Android source app, a local server,
  and a small XSOverlay UDP payload mapper instead of embedding all behavior in
  one desktop app.
- Code donor value:
  high. `MyNotificationListenerService` extracts title/content, applies
  exclusions, respects enable/config state, converts notification icons to a
  capped bitmap/base64 payload, and sends JSON over HTTP. The Ktor server
  receives `MyNotification`, maps it to `XsoMessage`, enforces datagram size,
  and sends to the configured XSOverlay UDP port.
- Product reference value:
  high for phone notification overlays, event relays, and source-to-overlay
  bridge scaffolding.
- What to inspect next:
  UI configuration flows, auth/trust assumptions for the HTTP relay, retention
  defaults, and Android notification permission onboarding.
- Reusable pattern extraction:
  keep `mobile source`, `privacy/filter config`, `local relay`, `payload
  mapper`, and `overlay sink` separate.

### `Daniel81i/YncneoXSOBridge`

- Interesting idea:
  a desktop companion can be useful when it discovers external app ports,
  manages reconnects, exposes tray status, and bridges translation/control data
  into XSOverlay.
- Code donor value:
  medium. The repo has practical pieces: `config.json`, registry lookup for
  Yukarinette/Yncneo ports, WebSocket objects for XSOverlay and data feeds,
  cleanup hooks, PyInstaller resource paths, tray tooltip/menu management, and
  a translation logger. The main script is global-state heavy, so direct reuse
  should be selective.
- Product reference value:
  high for translation overlays, local companion apps, and tray-managed
  operator sidecars.
- What to inspect next:
  actual XSOverlay message schema, profile-switching commands, reconnect
  backoff, and log retention/privacy.
- Reusable pattern extraction:
  borrow `port discovery`, `tray status`, `reconnect supervisor`, and
  `translation profile/log surfaces`; do not copy the monolithic loop.

## Reusable Pattern Extraction

- Pattern candidate:
  XSOverlay companion bridge boundary across source app, local relay,
  configuration/privacy, payload mapping, reconnect policy, and operator tray.
- Problem solved:
  overlay companions become hard to maintain when notification access,
  translation state, config, transport, payload shaping, and tray control are
  fused together.
- Reusable core:
  source adapter, filter/config repository, transport receiver, XSOverlay
  payload mapper, icon/media normalizer, reconnect supervisor, tray/status UI,
  and structured logging.
- Source evidence:
  `jonreeve/NotifyXso` and `Daniel81i/YncneoXSOBridge`.
- Abstraction boundary:
  separate source permissions and privacy from local transport and overlay sink
  delivery.
- What not to copy:
  unauthenticated relay defaults without trust notes, global mutable state as
  the main architecture, or raw notification/translation logs without retention
  policy.
- Method catalog action:
  add an XSOverlay companion bridge method.

## Follow-Up Gaps

- Compare XSOverlay UDP, WebSocket, HTTP, and OSC relay shapes.
- Add a privacy/security matrix for phone notification and translation bridges.
- Search for companion sidecars with cleaner reconnect supervisors and schema
  versioning.
