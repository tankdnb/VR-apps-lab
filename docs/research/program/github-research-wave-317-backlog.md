# GitHub Research Wave 317 Backlog - VR Notification, Chat Overlays, and Local Message Relay Sidecars

## Executed Scope

- Searched and deduplicated VR notification, Twitch-chat, and XSOverlay relay
  projects.
- Froze a four-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted source contracts, queue/drop behavior, privacy filters,
  renderer/card-building seams, WebSocket relay patterns, and startup/runtime
  glue.

## Studied Projects

- `BOLL7708/TwitchVRNotifications`
- `balazs565/PhoneNotificationsVR`
- `tyunta/notifyxsoverlay`
- `NekoSuneProjects/vrnotications`

## Backlog Findings

- Compare OpenVR and XSOverlay target capabilities more directly.
- Revisit notification privacy defaults and retention rules as a cross-wave
  method concern.
- Deepen ANCS/test-source and history/replay handling in `PhoneNotificationsVR`.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes a VR notification relay method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
