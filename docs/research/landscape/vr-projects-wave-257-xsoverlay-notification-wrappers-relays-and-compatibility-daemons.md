# Wave 257 - XSOverlay Notification Wrappers, Relays, and Compatibility Daemons

This wave studies projects that send desktop, app, status, audio, battery, and
VRChat events into XSOverlay or emulate enough of its API to preserve
notification workflows.

## Scope

The wave focused on XSOverlay UDP and WebSocket surfaces:

- notification payload schema wrappers;
- Windows toast and VRChat log adapters;
- status and device-log pollers;
- Linux compatibility daemons;
- avatar/OSC triggered notification helpers.

No external project was run, built, installed, or launched.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `nnaaa-vr/XSOverlay-VRChat-Parser` | XSOverlay notification relay | Studied | VRChat log parser with per-event notification config |
| `bluskript/xsoverlay-notifier` | Windows notification to XSOverlay | Studied | Rust Windows toast listener/poller with XSOverlay UDP sender |
| `nnaaa-vr/XSNotifications` | XSOverlay UDP helper library | Studied | Small queue-backed .NET notification client |
| `Minty-Labs/WindowsXSO` | Windows notification to XSOverlay | Studied | User-facing filter, permission, and SteamVR lifecycle reference |
| `Duinrahaic/XSSocket` | XSOverlay WebSocket API wrapper | Studied | Typed control/status API surface for XSOverlay automation |
| `Zyphrono/XSOverlay-VRChat-Status` | Status monitor to XSOverlay | Studied | VRChat service status change detector and notifier |
| `project-vrcat/XSNotifier-Go` | XSOverlay UDP helper library | Studied | Minimal Go payload normalizer and UDP client |
| `gizmogoat/XSNotifyDaemon` | XSOverlay API compatibility daemon | Studied | Linux WebSocket shim that maps XSOverlay notification API to `notify-send` |
| `JacobA2000/VRCazam` | Avatar-triggered notification action | Studied | VRChat OSC trigger to Shazam loopback recognition to XSOverlay notification |
| `pikepikeid/PICOBatteryWatcher` | Vendor device log to XSOverlay | Studied | PICO Connect battery log parser with WebSocket notifications |

## Code-Level Findings

### `nnaaa-vr/XSOverlay-VRChat-Parser`

- Interesting idea:
  translate VRChat log events into configurable in-VR notifications.
- Code donor value:
  good for log-root discovery, event-specific configuration, timeout/volume
  settings, and per-event icon/audio routing.
- Product reference value:
  useful for social VR event awareness without building a full overlay.
- What to inspect next:
  stronger log-tail durability, duplicate suppression, and fallback desktop
  notifications when XSOverlay is absent.
- Caveats:
  README notes missing XSOverlay-running detection and normal-audio fallback.

### `bluskript/xsoverlay-notifier`

- Interesting idea:
  bridge Windows toast notifications into VR with either listener or polling
  strategy.
- Code donor value:
  strong donor for permission request flow, notification extraction, source-app
  metadata, icon handling, and restartable sender loop.
- Product reference value:
  shows a privacy-sensitive system-to-VR relay with fallback strategies.
- What to inspect next:
  app filtering, privacy modes, and install/capability requirements.
- Caveats:
  Windows notification permission and MSIX capability details matter; delivery
  is UDP and should be treated as best-effort.

### `nnaaa-vr/XSNotifications`

- Interesting idea:
  keep the XSOverlay UDP payload schema as a small reusable .NET library.
- Code donor value:
  good for payload defaults, camelCase JSON serialization, UDP endpoint
  defaults, and queue-backed worker sending.
- Product reference value:
  useful as a compact library boundary that app authors can embed.
- What to inspect next:
  backpressure, exception handling, and whether ack/retry is needed for any
  future `VR-apps-lab` helper.
- Caveats:
  no delivery acknowledgement and limited error visibility.

### `Minty-Labs/WindowsXSO`

- Interesting idea:
  make Windows-to-VR notifications operable with allow/deny lists, SteamVR
  process lifecycle, auto-minimize, and user permission guidance.
- Code donor value:
  strong for user-facing filters, SteamVR process gating, height/timeout
  heuristics, image filename masking, and permission explanation.
- Product reference value:
  one of the better examples of turning a raw notification bridge into a
  usable desktop companion.
- What to inspect next:
  privacy UI, evented notification path, and whether app-list editing can be
  reused in other overlay relays.
- Caveats:
  polling, auto-update, and desktop-toast privacy need care.

### `Duinrahaic/XSSocket`

- Interesting idea:
  expose XSOverlay WebSocket control and state updates through typed C# command
  and response objects.
- Code donor value:
  strong for API surface mapping: notifications, overlay creation, recenter,
  keyboard, media controls, layout state, device info, performance, settings,
  and overlay id requests.
- Product reference value:
  shows XSOverlay as more than notifications: it can be an automation target.
- What to inspect next:
  command correctness, version compatibility, and two-way control safety.
- Caveats:
  repo includes build artifacts and some commands appear copy-pasted with wrong
  command strings.

### `Zyphrono/XSOverlay-VRChat-Status`

- Interesting idea:
  notify inside VR when VRChat service components degrade or recover.
- Code donor value:
  useful for status API polling, previous-state comparison, app-active gating,
  tray lifecycle, and warning/default notification types.
- Product reference value:
  a compact operational-awareness microtool for social VR users.
- What to inspect next:
  maintained status component ids, user-controlled subscriptions, and rate
  limiting.
- Caveats:
  old dependencies, checked-in packages, hardcoded service ids, and updater
  assumptions.

### `project-vrcat/XSNotifier-Go`

- Interesting idea:
  keep a Go XSOverlay UDP client thin enough to embed in sidecars.
- Code donor value:
  useful for message defaults, field normalization, and mutex-protected UDP
  connection reuse.
- Product reference value:
  library-only node; good for Go-based VRChat or OBS sidecars.
- What to inspect next:
  integration examples and error strategy under bursty sends.
- Caveats:
  narrow scope and no delivery-state model.

### `gizmogoat/XSNotifyDaemon`

- Interesting idea:
  emulate XSOverlay WebSocket notification intake on Linux and forward to
  desktop `notify-send`.
- Code donor value:
  strong for compatibility-daemon pattern: implement only the subset needed by
  existing tools while preserving the expected WebSocket route.
- Product reference value:
  good reference for keeping overlay integrations useful when XSOverlay itself
  is not available on a platform.
- What to inspect next:
  wlxoverlay-s integration, auth, icon temp-file cleanup, and more API command
  coverage.
- Caveats:
  only `SendNotification` is covered, depends on `notify-send`, and has no auth
  boundary.

### `JacobA2000/VRCazam`

- Interesting idea:
  a VRChat avatar parameter can trigger a desktop audio recognition workflow
  and return the answer as an in-VR notification.
- Code donor value:
  good for `OSC trigger -> desktop action -> notification response` flow, plus
  loopback audio capture and history logging.
- Product reference value:
  illustrates an avatar-driven command surface that does not require a custom
  VR UI.
- What to inspect next:
  consent UX, audio device selection, API reliability, and notification
  fallback.
- Caveats:
  audio privacy, Shazam/API dependence, and loopback device fragility.

### `pikepikeid/PICOBatteryWatcher`

- Interesting idea:
  parse vendor runtime logs for headset/controller battery events and surface
  threshold crossings through XSOverlay WebSocket notifications.
- Code donor value:
  strong for log-tail telemetry extraction, per-device threshold reset logic,
  and WebSocket notification payload sending.
- Product reference value:
  battery microtools are valuable even when no formal API exists.
- What to inspect next:
  log format drift, multi-language UI, and a generic vendor-log adapter model.
- Caveats:
  PICO Connect log dependence, manual JSON, and runtime-specific strings.

## Reusable Pattern Extraction

- Pattern candidate:
  VR notification relay with source adapters and transport-specific payloads.
- Problem solved:
  useful desktop/runtime events often happen outside the headset and need a
  narrow, privacy-aware path into VR.
- Reusable core:
  source adapter, permission gate, event normalizer, dedupe/cadence policy,
  payload schema, transport adapter, delivery-state UI, fallback, and privacy
  filter.
- Source evidence:
  Windows toast bridges, VRChat log/status adapters, PICO log parsing,
  XSOverlay UDP/WebSocket libraries, and a Linux compatibility daemon.
- Abstraction boundary:
  event sources should not depend directly on XSOverlay; they should emit a
  normalized notification event that can target XSOverlay, desktop, browser,
  SteamVR overlay, or logs.
- What not to copy:
  unfiltered private notifications, unchecked audio capture, unauthenticated
  remote command APIs, stale service IDs, and vendored build artifacts.
- Method catalog action:
  create or deepen the XSOverlay notification bridge method with explicit
  source evidence and privacy gates.

## Family Placement

This wave creates a new family for XSOverlay notification relay and
compatibility surfaces. It overlaps with overlay micro-surfaces, VRChat OSC
sidecars, device monitors, and Linux overlay compatibility, but the defining
feature is the notification contract.

## Backlog Impact

- Build an XSOverlay payload and API matrix: UDP, WebSocket, one-way, two-way,
  library wrappers, and compatibility daemons.
- Compare privacy gates for desktop notifications, audio recognition, and
  vendor log telemetry.
- Consider a generic `notification relay core` pattern for future
  `VR-apps-lab` helpers.
