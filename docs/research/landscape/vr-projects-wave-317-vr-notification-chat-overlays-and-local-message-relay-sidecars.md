# Wave 317 - VR Notification, Chat Overlays, and Local Message Relay Sidecars

This wave studies VR notification and message-relay utilities as reusable
references for source adapters, filtering, queueing, privacy controls, overlay
targets, and lightweight bridge transports.

No external project was run, built, installed, or launched.

## Scope

The wave was bounded to:

- phone, desktop, and chat notifications routed into VR;
- OpenVR and XSOverlay notification sinks;
- local relay sidecars over WebSocket or direct overlay APIs;
- privacy/filtering and source-selection logic for notification utilities.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `BOLL7708/TwitchVRNotifications` | Twitch chat to SteamVR notification bridge | Studied | Strong donor for message-source filtering, auth, notification card rendering, and OpenVR notification emission |
| `balazs565/PhoneNotificationsVR` | Multi-layer phone notification overlay app | Studied | Highest-value donor in the cluster for source abstraction, bounded queueing, filtering, overlay anchoring, and operator-friendly architecture |
| `tyunta/notifyxsoverlay` | Windows-notification to XSOverlay sidecar | Studied | Thin but strong donor for WinRT notification ingest, learning-mode filters, config hygiene, and WebSocket payload relay |
| `NekoSuneProjects/vrnotications` | Minimal cross-target notification wrapper library | Studied | Useful micro-utility reference for targeting multiple sinks and normalizing images/payloads with very little ceremony |

## Code-Level Findings

### `BOLL7708/TwitchVRNotifications`

- Interesting idea:
  a narrow chat-to-VR notification tool can still teach a lot if it keeps auth,
  filtering, avatar/image generation, reconnect behavior, and overlay emission
  visible as separate concerns.
- Code donor value:
  medium-high. `MainController.cs` clearly owns chat/client orchestration,
  reconnect logic, API fetches, notification-card assembly, and OpenVR
  notification submission instead of scattering those responsibilities. Local
  storage of secrets and explicit thread separation for OpenVR help mark the
  reliability seams.
- Product reference value:
  high for stream-facing overlays, situational HUDs, and audience-message
  surfaces where a small amount of filtered text matters more than a general
  desktop-notification product.
- What to inspect next:
  avatar/image cache behavior, moderation/filter rules, and whether broader
  chat sources can share the same source-to-overlay pipeline shape.
- Reusable pattern extraction:
  keep `message source`, `filter/moderation`, `card builder`, and `overlay
  sink` separate.

### `balazs565/PhoneNotificationsVR`

- Interesting idea:
  notification overlays become donor-worthy when they explicitly separate
  source contracts, filter/history policy, bounded dispatch, and overlay
  presentation instead of treating notifications as a single event callback.
- Code donor value:
  very high. The `Core` layer defines `INotificationSource` and
  `NotificationDispatcher`; the dispatcher uses a bounded
  `Channel<PhoneNotification>` and keeps filtering, history, and overlay output
  distinct. `CompositeNotificationSource` merges real and test sources behind a
  shared contract. `SteamVrOverlayService` and `NotificationRenderer` isolate
  overlay lifecycle, animation, and upload/update behavior from source logic.
  `AppFilter`, supervisor loops, and multiple anchor modes make the architecture
  especially reusable.
- Product reference value:
  extremely high for phone-notification overlays, device/phone companions,
  glanceable micro-panels, and any future VR utility that needs event
  queueing with user-facing presentation rules.
- What to inspect next:
  deeper ANCS path behavior, overlay asset management, settings migration, and
  how history/replay should surface in other event-driven VR tools.
- Reusable pattern extraction:
  keep `source contract`, `bounded dispatcher`, `filter/history`, and `overlay
  sink` separate.

### `tyunta/notifyxsoverlay`

- Interesting idea:
  a thin local sidecar can get a lot done if it cleanly owns WinRT ingest,
  allow/block and learning-mode policy, config reload, and one small VR sink
  transport.
- Code donor value:
  high. `bridge.py` makes notification access, app/text extraction, dedupe,
  privacy filtering, XSOverlay payload formatting, and optional SteamVR
  lifecycle watching explicit. `config.py` adds normalization, save/restore,
  and corruption recovery rather than treating config as incidental. `cli.py`
  is especially useful as a tiny reference for SteamVR manifest generation and
  startup overlay registration.
- Product reference value:
  high for small sidecars where the VR-facing value is one transport and one
  notification shape rather than a large multi-layer app.
- What to inspect next:
  relay auth or local-network assumptions, filter UX, and whether the same
  sidecar shape maps cleanly to other overlay targets.
- Reusable pattern extraction:
  keep `platform ingest`, `privacy/filter policy`, `relay transport`, and
  `startup/runtime glue` separate.

### `NekoSuneProjects/vrnotications`

- Interesting idea:
  very small libraries can still matter if they normalize payloads and image
  handling across multiple notification targets.
- Code donor value:
  medium. The XSOverlay and OVR Toolkit wrappers are shallow, but the library
  makes target-specific message transport visible and `imageHelper.js` is a
  useful micro-pattern for accepting image data in multiple forms before
  emitting the target-specific representation.
- Product reference value:
  medium-high as a micro-utility and quick reference for multi-target
  notification sending from Node-based tools or bots.
- What to inspect next:
  delivery guarantees, queue behavior, and whether the same interface can be
  expanded into a more reliable event pipeline without losing simplicity.
- Reusable pattern extraction:
  keep `payload normalizer` and `target adapters` separate.

## Reusable Pattern Extraction

- Pattern candidate:
  VR notification relay boundary across source adapters, privacy filtering,
  bounded queueing, message rendering, and overlay or WebSocket sinks.
- Problem solved:
  notification tools become noisy and hard to reuse when source-specific
  ingestion, privacy policy, queue semantics, and overlay transport are all
  fused together.
- Reusable core:
  notification source contract, source merger, allow/block and learning-mode
  policy, bounded queue, history store, renderer/card builder, overlay or
  relay sink adapter, startup/runtime supervisor, and settings/config surface.
- Source evidence:
  `BOLL7708/TwitchVRNotifications`, `balazs565/PhoneNotificationsVR`,
  `tyunta/notifyxsoverlay`, and `NekoSuneProjects/vrnotications`.
- Abstraction boundary:
  keep notification ingest, policy/filtering, delivery queue, and target sink
  separate.
- What not to copy:
  broad notification access without privacy framing, hidden queue/drop
  semantics, sink-specific payload construction scattered across source code, or
  unauthenticated relay endpoints treated as safe defaults.
- Method catalog action:
  add a VR notification relay method.

## Follow-Up Gaps

- Compare OpenVR notification sinks with XSOverlay and other external overlay
  hosts to make target capabilities more explicit.
- Deepen the ANCS and test-source surfaces inside `PhoneNotificationsVR`.
- Revisit privacy, allow/block, and retention defaults as a cross-wave policy
  pattern rather than a per-project detail.
