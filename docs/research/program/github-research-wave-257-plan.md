# GitHub Research Wave 257 Plan - XSOverlay Notification Wrappers, Relays, and Compatibility Daemons

## Goal

Study XSOverlay notification wrappers, relays, and compatibility shims to
extract a reusable notification bridge model for VR utilities.

## Research Questions

- What does the XSOverlay UDP and WebSocket notification payload surface look
  like across languages?
- How do tools adapt Windows toasts, VRChat logs, service status, vendor logs,
  OSC triggers, and Linux notification daemons into the same VR notification
  flow?
- Which privacy, fallback, permission, and lifecycle gates are needed before
  copying this pattern into future tools?

## Shortlist

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

## Required Checks

- Deduplicate against existing XSOverlay, overlay, and VRChat notification
  entries.
- Clone only into local-only source cache.
- Read source statically; do not run, build, install, or launch projects.
- Capture mandatory repository fields and reusable pattern extraction bridge.
- Update registry, families, methods, current focus, and follow-up gaps.

## Expected Outputs

- Landscape synthesis for Wave 257.
- Registry section and family entry for XSOverlay notification relays.
- Method catalog entry or update around notification bridge payload, transport,
  and security/privacy gates.
- Follow-up matrix gaps for API coverage, Linux compatibility, and privacy.
