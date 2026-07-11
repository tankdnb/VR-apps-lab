# GitHub Research Wave 317 Plan - VR Notification, Chat Overlays, and Local Message Relay Sidecars

## Goal

Study VR notification and message-relay utilities as reusable references for
source adapters, privacy filtering, queueing, renderer/sink boundaries, and
small local transport sidecars.

## Research Questions

- How do the stronger notification tools separate source ingestion from overlay
  output?
- What privacy, filtering, allow/block, or learning-mode patterns recur?
- Which projects are strong code donors versus tiny wrapper or target-library
  references?
- How different are OpenVR and XSOverlay-facing tool shapes in practice?

## Shortlist

- `BOLL7708/TwitchVRNotifications`
- `balazs565/PhoneNotificationsVR`
- `tyunta/notifyxsoverlay`
- `NekoSuneProjects/vrnotications`

## Required Checks

- Deduplicate against earlier notification, XSOverlay, and overlay-bridge
  waves.
- Sync sources only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch found projects.
- Keep privacy, relay transport, and queue semantics explicit.

## Expected Outputs

- Landscape synthesis for Wave 317.
- Registry/family entries for notification/chat overlay donors.
- Method catalog entry for notification relay boundaries.
- Follow-up gaps for privacy policy, target capability comparison, and source
  adapter generalization.
