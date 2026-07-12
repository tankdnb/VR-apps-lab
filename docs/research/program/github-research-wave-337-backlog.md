# GitHub Research Wave 337 Backlog - OpenVR Notification Primitives, Overlay Wrappers, and Windows Toast Bridges

## Executed Scope

- Dedupe rejected previously studied XSOverlay Discord and Windows companions.
- Froze four projects around native OpenVR notifications, overlay wrappers, and
  a full Windows notification-to-overlay application.
- Read source and documentation statically from local-only cache.
- Extracted notification bitmap preparation, overlay handle requirements,
  OpenVR wrapper ergonomics, Windows notification listener packaging, filtering,
  history, DND, dashboard settings, and autolaunch manifest behavior.

## Studied Projects

- `AlexMcArdle/openvr-notifications`
- `BOLL7708/OpenVRNotificationTest`
- `erenoa-6621/vr-notification-overlay`
- `OVRTools/OVRSharp`

## Backlog Findings

- Preserve a tiny native notification primitive as a separate method from a
  full notification-overlay product.
- Use wrapper libraries to reduce pointer/error boilerplate, but keep raw
  OpenVR fallback visible.
- Treat Windows notification permission, filters, history, and DND as product
  concerns outside the renderer.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include studied projects.
- Method catalog captures notification-to-overlay pipeline.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
