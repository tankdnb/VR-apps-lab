# GitHub Research Wave 322 Backlog - XSOverlay Companion Bridges, Phone Notifications, and Translation-Control Sidecars

## Executed Scope

- Searched and deduplicated XSOverlay companion, notification, and translation
  bridge projects.
- Froze a two-project shortlist.
- Read source and documentation statically from local-only cache.
- Extracted Android notification access, Ktor relay, UDP payload mapping,
  registry/port discovery, WebSocket reconnect logic, tray controls, logging,
  and PyInstaller resource handling.

## Studied Projects

- `jonreeve/NotifyXso`
- `Daniel81i/YncneoXSOBridge`

## Backlog Findings

- Compare UDP, WebSocket, HTTP, and OSC-style transports for XSOverlay-facing
  sidecars.
- Add a privacy/security checklist for phone and translation bridges.
- Revisit tray-controller and reconnect-loop patterns as reusable sidecar
  scaffolding.

## Completion Criteria

- Wave landscape document exists.
- Registry and families include all studied projects.
- Method catalog includes an XSOverlay companion bridge method.
- Follow-up gaps are queued.
- Local-only cache is cleaned before commit.
