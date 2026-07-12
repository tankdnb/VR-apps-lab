# GitHub Research Wave 337 Plan - OpenVR Notification Primitives, Overlay Wrappers, and Windows Toast Bridges

## Goal

Study small OpenVR notification and overlay projects that clarify the lowest
useful boundary for showing messages or panels in SteamVR.

## Research Questions

- What is the minimal OpenVR notification path?
- When should a tool use native `IVRNotifications` versus a persistent overlay?
- How should Windows notifications, filtering, settings, history, and
  autolaunch be separated from the overlay renderer?

## Shortlist

- `AlexMcArdle/openvr-notifications`
- `BOLL7708/OpenVRNotificationTest`
- `erenoa-6621/vr-notification-overlay`
- `OVRTools/OVRSharp`

## Required Checks

- Deduplicate against XSOverlay and OpenVROverlayPipe waves.
- Sync source only into local-only cache.
- Read source and documentation statically; do not run, build, install, or
  launch any found project.

## Expected Outputs

- Landscape synthesis for Wave 337.
- Registry/family entries for notification and overlay primitives.
- Method catalog entry for Windows notification to VR overlay pipeline.
