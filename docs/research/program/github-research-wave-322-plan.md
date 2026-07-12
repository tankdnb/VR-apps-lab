# GitHub Research Wave 322 Plan - XSOverlay Companion Bridges, Phone Notifications, and Translation-Control Sidecars

## Goal

Study companion-side XSOverlay bridges that connect external apps, phones,
translation tools, and desktop tray controls into in-headset overlay workflows.

## Research Questions

- What is the cleanest boundary between phone/desktop source, relay service,
  XSOverlay payload, and local configuration?
- How do narrow sidecars discover ports, own reconnect behavior, and expose
  operator controls?
- Which ideas should become reusable bridge patterns instead of project-local
  observations?

## Shortlist

- `jonreeve/NotifyXso`
- `Daniel81i/YncneoXSOBridge`

## Required Checks

- Deduplicate against previous notification and XSOverlay relay waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Capture security, privacy, and monolith/global-state caveats.

## Expected Outputs

- Landscape synthesis for Wave 322.
- Registry/family entries for XSOverlay companion bridges.
- Method catalog entry for companion bridge boundaries across source, relay,
  payload mapping, reconnect policy, and tray/operator control.
