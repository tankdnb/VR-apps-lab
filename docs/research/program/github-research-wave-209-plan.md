# GitHub Research Wave 209 Plan

Date: 2026-06-06

Theme: XR glasses WebHID protocol workbenches and head-tracked desktop helper proofs of concept.

Research mode: static source reading only. No external repository was run, built, installed, or launched.

## Why This Wave Exists

XR glasses and lightweight AR display tools keep appearing around VR utility workflows because they expose a different but reusable problem: protocol intake, IMU streams, calibration, drift correction, and head-tracked desktop surfaces outside a full VR runtime.

Wave 209 deepens the Nreal/Xreal backlog and extracts the reusable boundary between device protocol workbench and display/desktop UX.

## Search Families

- WebHID and native HID protocol tools for XR glasses.
- Head-tracked desktop and virtual display helpers.
- Calibration, drift correction, and saved layout utilities.
- Low-level device command parsers that may inform future XR diagnostics.

## Frozen Shortlist

| Project | Why included | Initial placement |
| --- | --- | --- |
| `jakedowns/xreal-webxr` | Browser WebHID workbench for Xreal/Nreal device detection, message parsing, firmware/status commands, and IMU protocol exploration. | WebHID protocol workbench |
| `alexwilson1/nreal_linux_test` | Linux/X11 proof of head-tracked multi-display slicing driven by Nreal yaw values. | Head-tracked desktop POC |
| `edwatt/real_utilities` | Native hidapi/zlib command parser and calibration reader for Nreal Air. | Low-level HID protocol utility |
| `Mailbot/Nreal_Air_Desktop_tool` | Product reference for Windows AR desktop windows, saved layouts, curvature, drift correction, and focus controls. | Desktop UX reference |

## Dedupe Notes

These repos sit in an already known XR glasses family, but prior notes did not separate protocol workbench value from desktop product value. Wave 209 records that separation and updates the reusable-method catalog accordingly.

## Code-Level Pass Targets

- WebHID/native HID device discovery and interface roles.
- Packet/message table and parser boundaries.
- IMU/status/calibration command handling.
- Head-tracked viewport, saved layout, and drift-correction product ideas.
- Security and platform caveats around X11, browser HID permissions, firmware commands, and hardcoded drivers.

## Expected Outputs

- Wave 209 landscape synthesis.
- Registry/family deepening notes.
- Method catalog entry for XR glasses protocol workbench plus head-tracked desktop viewport.
- Follow-up backlog for safer protocol readers and display-surface UX comparison.
