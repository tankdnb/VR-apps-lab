# Wave 337 - OpenVR Notification Primitives, Overlay Wrappers, and Windows Toast Bridges

This wave studies the path from small OpenVR notification experiments to a more
complete Windows notification overlay product.

No external project was run, installed, built, or launched.

## Scope

The wave was bounded to native OpenVR notification primitives, C# overlay
wrapper ergonomics, Windows notification listener to VR overlay pipelines,
filtering, history, DND, dashboard settings, and autolaunch boundaries.

## Shortlist

| Project | Family placement | Study status | Why it matters |
|---|---|---|---|
| `AlexMcArdle/openvr-notifications` | Minimal OpenVR notification reference | Thin README-level reference | Shows the existence of iOS-to-OpenVR notification direction but current clone has no implementation beyond README |
| `BOLL7708/OpenVRNotificationTest` | Native OpenVR notification primitive | Studied | Compact C# donor for OpenVR background init, overlay creation, bitmap channel preparation, and `CreateNotification` |
| `erenoa-6621/vr-notification-overlay` | Windows notification to OpenVR overlay app | Studied | Strong product/architecture reference for Windows listener, queue/filter/history/settings, Skia rendering, OpenVR overlay manager, dashboard settings, packaging, and autolaunch manifest |
| `OVRTools/OVRSharp` | C# OpenVR overlay wrapper | Studied | Useful wrapper donor for application type init, overlay creation, dashboard overlays, texture submission, tracked-device transforms, curvature/alpha/mouse scale, and event polling |

## Code-Level Findings

### `AlexMcArdle/openvr-notifications`

- Interesting idea: phone-originated notifications can be routed into OpenVR.
- Code donor value: none in current clone; README only.
- Product reference value: low but useful as a dedupe/lineage marker.
- What to inspect next: history, forks, or releases if implementation appears.

### `BOLL7708/OpenVRNotificationTest`

- Interesting idea: a SteamVR notification can be reduced to background
  OpenVR init, an overlay handle, a bitmap payload, and `IVRNotifications`.
- Code donor value: medium-high as a minimal primitive. `Program.cs` initializes
  `VRApplication_Background`, creates an overlay, loads a bitmap, flips red/blue
  channels, builds `NotificationBitmap_t`, and calls `CreateNotification`.
- Product reference value: medium for a notification doctor or sample.
- What to inspect next: non-image notifications, overlay icon fallback,
  notification click behavior, and shutdown/error handling.
- Caveat: sample-level code with bundled API DLL and simple lifetime handling.

### `erenoa-6621/vr-notification-overlay`

- Interesting idea: Windows notifications should be treated as a full pipeline:
  source adapter, domain card, filters, queue, history, settings, renderer, and
  overlay manager.
- Code donor value: high conceptually. `ServiceRegistration.cs` wires
  settings, history, queue, Windows notification adapter, pipeline service,
  OpenVR overlay manager, dashboard overlay, and hosted services. Packaging
  includes notification-listener capability, portable setup, NSIS installer,
  and SteamVR manifest registration.
- Product reference value: very high for future notification/accessibility
  overlay utilities.
- What to inspect next: `WindowsNotificationAdapter`, Skia renderer, dashboard
  overlay, filter persistence, and permission failure UX.
- Caveat: Windows-only, README text encoding in the clone is noisy, and direct
  installer behavior needs careful security review.

### `OVRTools/OVRSharp`

- Interesting idea: overlay utilities benefit from a high-level wrapper that
  turns OpenVR error codes, handles, transforms, and texture calls into a more
  idiomatic API.
- Code donor value: high as an abstraction reference. `Application` wraps
  OpenVR init by application type. `Overlay` exposes dashboard and normal
  overlays, tracked-device-relative transforms, texture bounds, mouse scale,
  input method, width, curvature, alpha, and event polling.
- Product reference value: high for C# overlay prototypes.
- What to inspect next: event thread cleanup, DirectX/OpenGL compositor helpers,
  raw `Valve.VR` escape hatches, and maintained API coverage.

## Reusable Pattern Extraction

- Pattern candidate: OS notification to VR overlay pipeline.
- Problem solved: users need actionable desktop or phone notifications while
  staying in VR, but raw notification APIs, privacy filters, rendering, and VR
  placement should not be mixed together.
- Reusable core: source adapter, permission check, notification domain card,
  filter chain, priority/DND policy, bounded queue, history store, renderer,
  overlay manager, dashboard/settings UI, autolaunch manifest, and diagnostics.
- Source evidence: `BOLL7708/OpenVRNotificationTest`,
  `erenoa-6621/vr-notification-overlay`, and `OVRTools/OVRSharp`;
  `AlexMcArdle/openvr-notifications` is only a thin lineage marker.
- Abstraction boundary: keep capture/source permissions, notification policy,
  card rendering, OpenVR texture/notification calls, settings UI, and packaging
  separate.
- What not to copy: raw Windows notification capture without consent UX,
  unbounded history, fragile channel-swapping bitmap code without validation,
  global DND toggles without explainers, or wrapper APIs that hide lifecycle
  failures.
- Method catalog action: add OS notification to VR overlay pipeline.

## Follow-Up Gaps

- Compare OpenVR native notifications with persistent overlay cards for
  dismiss/replay/history behavior.
- Define a privacy-safe notification card schema.
- Inspect dashboard settings overlays as a reusable companion pattern.
