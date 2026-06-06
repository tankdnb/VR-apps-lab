# GitHub Research Wave 257 Backlog - XSOverlay Notification Wrappers, Relays, and Compatibility Daemons

## Executed Scope

- Searched and deduplicated XSOverlay notification, library, and daemon
  candidates.
- Froze a shortlist covering Windows toasts, VRChat events, status monitors,
  vendor battery logs, UDP/WebSocket libraries, Linux compatibility, and avatar
  OSC triggers.
- Read source and documentation statically from local-only cache.
- Extracted reusable source-adapter, payload, transport, privacy, and fallback
  lessons.

## Studied Projects

- `nnaaa-vr/XSOverlay-VRChat-Parser`
- `bluskript/xsoverlay-notifier`
- `nnaaa-vr/XSNotifications`
- `Minty-Labs/WindowsXSO`
- `Duinrahaic/XSSocket`
- `Zyphrono/XSOverlay-VRChat-Status`
- `project-vrcat/XSNotifier-Go`
- `gizmogoat/XSNotifyDaemon`
- `JacobA2000/VRCazam`
- `pikepikeid/PICOBatteryWatcher`

## Backlog Findings

- Build an XSOverlay payload matrix for UDP vs WebSocket and one-way vs
  two-way API usage.
- Compare compatibility daemons such as `XSNotifyDaemon` with native overlay
  surfaces and Linux notification backends.
- Add a privacy checklist for desktop notification, audio recognition, and
  vendor log relay helpers.
- Inspect whether `XSSocket` command-name copy bugs exist upstream or in
  downstream users.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog captures notification relay reusable core and caveats.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
